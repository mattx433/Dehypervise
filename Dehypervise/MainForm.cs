using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Dism;
using System.Management;

namespace Dehypervise
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("Administrator privileges are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            dismWorker.RunWorkerAsync();
            CheckVbs();
            CheckHypLaunch();
        }

        private void dismWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DismSession session;
            DismFeatureCollection features;
            DismApi.Initialize(DismLogLevel.LogErrors);
            session = DismApi.OpenOnlineSession();
            features = DismApi.GetFeatures(session);
            e.Result = features;
            DismApi.CloseSession(session);
            DismApi.Shutdown();
        }

        private void dismWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show($"Error: {e.Error.Message}");
                return;
            }
            DismFeatureCollection features = e.Result as DismFeatureCollection;
            hvStatLabel.Text = features.Any(f => f.FeatureName == "Microsoft-Hyper-V-Hypervisor") ? "Enabled" : "Disabled";
            vmpStatLabel.Text = features.Any(f => f.FeatureName == "VirtualMachinePlatform") ? "Enabled" : "Disabled";
            whpxStatLabel.Text = features.Any(f => f.FeatureName == "HypervisorPlatform") ? "Enabled" : "Disabled";
            wsbStatLabel.Text = features.Any(f => f.FeatureName == "Containers-DisposableClientVM") ? "Enabled" : "Disabled";
        }

        private void CheckVbs()
        {
            var searcher = new ManagementObjectSearcher("root\\Microsoft\\Windows\\DeviceGuard", "SELECT * FROM Win32_DeviceGuard");
            var deviceGuard = searcher.Get().OfType<ManagementObject>().FirstOrDefault();
            if (deviceGuard == null)
            {
                vbsStatLabel.Text = "Not present";
                return;
            }
            var vbsStatus = deviceGuard.Properties.OfType<PropertyData>().
                FirstOrDefault(p => p.Name == "VirtualizationBasedSecurityStatus")?.Value as uint?;
            var cgStatus = deviceGuard.Properties.OfType<PropertyData>().
                FirstOrDefault(p => p.Name == "SecurityServicesRunning")?.Value as uint?;
            vbsStatLabel.Text = (vbsStatus.HasValue && vbsStatus > 0) ? "Enabled" : "Disabled";
            cgStatLabel.Text = (cgStatus.HasValue && cgStatus > 0) ? "Enabled" : "Disabled";
        }

        private void CheckHypLaunch()
        {
            // Id is set to {current} per https://download.microsoft.com/download/a/f/7/af7777e5-7dcd-4800-8a0a-b18336565f5b/bcd.docx
            // StoreFilePath is set to "" per https://learn.microsoft.com/en-us/previous-versions/windows/desktop/bcd/bcdobject
            ManagementObject bcd = new ManagementObject("root\\WMI:BcdObject.Id=\"{fa926493-6f1c-4193-a414-58f0b2456d1e}\",StoreFilePath=\"\"");
            ManagementBaseObject inParams = bcd.GetMethodParameters("GetElement");
            // https://learn.microsoft.com/en-us/previous-versions/windows/desktop/bcd/bcdosloaderelementtypes
            inParams["Type"] = (uint) 0x250000f0;
            ManagementBaseObject outParams = bcd.InvokeMethod("GetElement", inParams, null);
            // https://learn.microsoft.com/en-us/dotnet/api/system.management.managementobject.invokemethod
            bool ok = (bool) outParams["ReturnValue"];
            // https://learn.microsoft.com/en-us/previous-versions/windows/desktop/bcd/getelement-bcdobject
            // https://learn.microsoft.com/en-us/previous-versions/windows/desktop/bcd/bcdintegerelement
            ulong state = (ulong) ((ManagementBaseObject)outParams["Element"])["Integer"];
            Console.WriteLine(state.GetType());
            if (!ok)
            {
                hypLaunchStatLabel.Text = "Unknown";
                return;
            }
            hypLaunchStatLabel.Text = state == 1 ? "Enabled" : "Disabled";
        }
    }
}
