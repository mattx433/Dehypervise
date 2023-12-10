# Dehypervise
A tool that tries to find out why Windows is running with Hyper-V.

## Why?
QEMU, VMware and VirtualBox have to resort to using Windows' hypervisor platform
API to run virtual machines when Hyper-V is active. This API is much slower than
the custom virtualization drivers used by these alternatives, and also causes
issues when running legacy operating systems.

Windows 11 can enable the hypervisor even if all optional features relating to it
are disabled. This software aims to identify when that is occuring.