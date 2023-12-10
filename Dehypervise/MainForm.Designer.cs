namespace Dehypervise
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hvLabel = new System.Windows.Forms.Label();
            this.vmpLabel = new System.Windows.Forms.Label();
            this.whpxLabel = new System.Windows.Forms.Label();
            this.wsbLabel = new System.Windows.Forms.Label();
            this.vbsLabel = new System.Windows.Forms.Label();
            this.cgLabel = new System.Windows.Forms.Label();
            this.hypLaunchLabel = new System.Windows.Forms.Label();
            this.hvStatLabel = new System.Windows.Forms.Label();
            this.vmpStatLabel = new System.Windows.Forms.Label();
            this.whpxStatLabel = new System.Windows.Forms.Label();
            this.wsbStatLabel = new System.Windows.Forms.Label();
            this.cgStatLabel = new System.Windows.Forms.Label();
            this.hypLaunchStatLabel = new System.Windows.Forms.Label();
            this.vbsStatLabel = new System.Windows.Forms.Label();
            this.featureStatusLabel = new System.Windows.Forms.Label();
            this.dismWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.hvLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vmpLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.whpxLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.wsbLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.vbsLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cgLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.hypLaunchLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.hvStatLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.vmpStatLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.whpxStatLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.wsbStatLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cgStatLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hypLaunchStatLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.vbsStatLabel, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // hvLabel
            // 
            this.hvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hvLabel.AutoSize = true;
            this.hvLabel.Location = new System.Drawing.Point(56, 10);
            this.hvLabel.Name = "hvLabel";
            this.hvLabel.Size = new System.Drawing.Size(45, 13);
            this.hvLabel.TabIndex = 0;
            this.hvLabel.Text = "Hyper-V";
            // 
            // vmpLabel
            // 
            this.vmpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vmpLabel.AutoSize = true;
            this.vmpLabel.Location = new System.Drawing.Point(18, 42);
            this.vmpLabel.Name = "vmpLabel";
            this.vmpLabel.Size = new System.Drawing.Size(121, 13);
            this.vmpLabel.TabIndex = 1;
            this.vmpLabel.Text = "Virtual Machine Platform";
            // 
            // whpxLabel
            // 
            this.whpxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whpxLabel.AutoSize = true;
            this.whpxLabel.Location = new System.Drawing.Point(6, 74);
            this.whpxLabel.Name = "whpxLabel";
            this.whpxLabel.Size = new System.Drawing.Size(145, 13);
            this.whpxLabel.TabIndex = 2;
            this.whpxLabel.Text = "Windows Hypervisor Platform";
            // 
            // wsbLabel
            // 
            this.wsbLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wsbLabel.AutoSize = true;
            this.wsbLabel.Location = new System.Drawing.Point(31, 106);
            this.wsbLabel.Name = "wsbLabel";
            this.wsbLabel.Size = new System.Drawing.Size(96, 13);
            this.wsbLabel.TabIndex = 3;
            this.wsbLabel.Text = "Windows Sandbox";
            // 
            // vbsLabel
            // 
            this.vbsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbsLabel.AutoSize = true;
            this.vbsLabel.Location = new System.Drawing.Point(9, 138);
            this.vbsLabel.Name = "vbsLabel";
            this.vbsLabel.Size = new System.Drawing.Size(139, 13);
            this.vbsLabel.TabIndex = 4;
            this.vbsLabel.Text = "Virtualization-based Security";
            // 
            // cgLabel
            // 
            this.cgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cgLabel.AutoSize = true;
            this.cgLabel.Location = new System.Drawing.Point(36, 170);
            this.cgLabel.Name = "cgLabel";
            this.cgLabel.Size = new System.Drawing.Size(86, 13);
            this.cgLabel.TabIndex = 5;
            this.cgLabel.Text = "Credential Guard";
            // 
            // hypLaunchLabel
            // 
            this.hypLaunchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hypLaunchLabel.AutoSize = true;
            this.hypLaunchLabel.Location = new System.Drawing.Point(17, 203);
            this.hypLaunchLabel.Name = "hypLaunchLabel";
            this.hypLaunchLabel.Size = new System.Drawing.Size(123, 13);
            this.hypLaunchLabel.TabIndex = 6;
            this.hypLaunchLabel.Text = "Hypervisor Launch Type";
            // 
            // hvStatLabel
            // 
            this.hvStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hvStatLabel.AutoSize = true;
            this.hvStatLabel.Location = new System.Drawing.Point(210, 10);
            this.hvStatLabel.Name = "hvStatLabel";
            this.hvStatLabel.Size = new System.Drawing.Size(52, 13);
            this.hvStatLabel.TabIndex = 7;
            this.hvStatLabel.Text = "Checking";
            // 
            // vmpStatLabel
            // 
            this.vmpStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vmpStatLabel.AutoSize = true;
            this.vmpStatLabel.Location = new System.Drawing.Point(210, 42);
            this.vmpStatLabel.Name = "vmpStatLabel";
            this.vmpStatLabel.Size = new System.Drawing.Size(52, 13);
            this.vmpStatLabel.TabIndex = 8;
            this.vmpStatLabel.Text = "Checking";
            // 
            // whpxStatLabel
            // 
            this.whpxStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whpxStatLabel.AutoSize = true;
            this.whpxStatLabel.Location = new System.Drawing.Point(210, 74);
            this.whpxStatLabel.Name = "whpxStatLabel";
            this.whpxStatLabel.Size = new System.Drawing.Size(52, 13);
            this.whpxStatLabel.TabIndex = 9;
            this.whpxStatLabel.Text = "Checking";
            // 
            // wsbStatLabel
            // 
            this.wsbStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wsbStatLabel.AutoSize = true;
            this.wsbStatLabel.Location = new System.Drawing.Point(210, 106);
            this.wsbStatLabel.Name = "wsbStatLabel";
            this.wsbStatLabel.Size = new System.Drawing.Size(52, 13);
            this.wsbStatLabel.TabIndex = 10;
            this.wsbStatLabel.Text = "Checking";
            // 
            // cgStatLabel
            // 
            this.cgStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cgStatLabel.AutoSize = true;
            this.cgStatLabel.Location = new System.Drawing.Point(210, 170);
            this.cgStatLabel.Name = "cgStatLabel";
            this.cgStatLabel.Size = new System.Drawing.Size(52, 13);
            this.cgStatLabel.TabIndex = 12;
            this.cgStatLabel.Text = "Checking";
            // 
            // hypLaunchStatLabel
            // 
            this.hypLaunchStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hypLaunchStatLabel.AutoSize = true;
            this.hypLaunchStatLabel.Location = new System.Drawing.Point(210, 203);
            this.hypLaunchStatLabel.Name = "hypLaunchStatLabel";
            this.hypLaunchStatLabel.Size = new System.Drawing.Size(52, 13);
            this.hypLaunchStatLabel.TabIndex = 13;
            this.hypLaunchStatLabel.Text = "Checking";
            // 
            // vbsStatLabel
            // 
            this.vbsStatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vbsStatLabel.AutoSize = true;
            this.vbsStatLabel.Location = new System.Drawing.Point(210, 138);
            this.vbsStatLabel.Name = "vbsStatLabel";
            this.vbsStatLabel.Size = new System.Drawing.Size(52, 13);
            this.vbsStatLabel.TabIndex = 14;
            this.vbsStatLabel.Text = "Checking";
            // 
            // featureStatusLabel
            // 
            this.featureStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.featureStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.featureStatusLabel.Name = "featureStatusLabel";
            this.featureStatusLabel.Size = new System.Drawing.Size(339, 23);
            this.featureStatusLabel.TabIndex = 1;
            this.featureStatusLabel.Text = "Features enabling Hyper-V";
            this.featureStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dismWorker
            // 
            this.dismWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dismWorker_DoWork);
            this.dismWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dismWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 266);
            this.Controls.Add(this.featureStatusLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dehypervise";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hvLabel;
        private System.Windows.Forms.Label vmpLabel;
        private System.Windows.Forms.Label whpxLabel;
        private System.Windows.Forms.Label wsbLabel;
        private System.Windows.Forms.Label vbsLabel;
        private System.Windows.Forms.Label cgLabel;
        private System.Windows.Forms.Label hypLaunchLabel;
        private System.Windows.Forms.Label featureStatusLabel;
        private System.Windows.Forms.Label hvStatLabel;
        private System.ComponentModel.BackgroundWorker dismWorker;
        private System.Windows.Forms.Label vmpStatLabel;
        private System.Windows.Forms.Label whpxStatLabel;
        private System.Windows.Forms.Label wsbStatLabel;
        private System.Windows.Forms.Label cgStatLabel;
        private System.Windows.Forms.Label hypLaunchStatLabel;
        private System.Windows.Forms.Label vbsStatLabel;
    }
}

