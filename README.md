# 🛡️ Windows System Security Hardening Tool

A lightweight Windows desktop application designed to assess and improve the security posture of Windows systems. This tool performs real-time monitoring, scans for common security misconfigurations, and assists users in hardening their systems against potential threats.

## 🚀 Features

- ✅ **Firewall Status Checker**  
Check, verify, and optionally enable the firewall for Public, Private, and Domain profiles.

- 🛡️ **Antivirus & Windows Defender Monitor**  
Check if Windows Defender is active, real-time protection is enabled, and initiate manual scans.

- 💾 **DEP (Data Execution Prevention) Status Checker**  
Verify whether DEP is enabled to protect against memory-based attacks.

- 🧾 **Registry Integrity Checker**  
Identify risky registry modifications that can compromise system security.

- ⚠️ **Unquoted Service Path Monitor**  
Detect services vulnerable to privilege escalation due to unquoted file paths.

- 🔒 **UAC (User Account Control) Status Check**  
Check if UAC is enabled, preventing unauthorized elevation.

- 🚀 **Startup Program Auditor**  
Detect suspicious startup programs that could indicate malware persistence.

- 🔄 **Windows Update Monitor**  
Verify update status and ensure the system is patched with the latest security fixes.

- 🧪 **Virus Scan Trigger**  
Launch an on-demand Windows Defender quick scan directly from the tool.

## 🖥️ GUI Overview

- Built with **Windows Forms (WinForms)** using C# in Visual Studio.
- Clean interface with functional buttons for each security module.
- Real-time scan results displayed in a RichTextBox with color-coded icons for easy understanding.

## 📸 Screenshots

> _Include screenshots of the GUI here._

## 🔧 Installation

1. Clone or download this repository.
2. Open the solution (`SecurityToolApp.sln`) in **Visual Studio**.
3. Build the solution (`Ctrl + Shift + B`).
4. Run the application (`F5`) or compile it into an executable from Visual Studio.

## 📂 File Structure

| File/Folder               | Description                                  |
|---------------------------|----------------------------------------------|
| `Form1.cs`                | Main GUI and event handling                 |
| `FirewallMonitor.cs`      | Firewall status and rules checking          |
| `DefenderMonitor.cs`      | Antivirus and Defender status checker       |
| `DepMonitor.cs`           | Data Execution Prevention check             |
| `RegistryMonitor.cs`      | Registry integrity scanner                  |
| `StartupProgramMonitor.cs`| Startup programs checker                    |
| `UacMonitor.cs`           | UAC status validation                       |
| `UnquotedServicePath.cs`  | Unquoted service path vulnerability checker |
| `VirusScanMonitor.cs`     | Virus scan trigger using Defender           |
| `WindowsUpdateMonitor.cs` | Windows Update status checker               |

## 🔒 Requirements

- Windows 10/11
- .NET Framework 4.7.2 or higher
- Administrator privileges (for certain checks and remediation)

## 💻 Technologies Used

- **C#**
- **Windows Forms (WinForms)**
- **Windows Management Instrumentation (WMI)**
- **PowerShell (for underlying system commands)**
- **Windows Security Center APIs**

## 🚦 How to Use

1. Launch the application.
2. Click any of the functional buttons to run security checks:
   - Example: 🔥 Click **Firewall Check** to verify firewall status.
3. Results are displayed in the output pane below.
4. Use the insights to fix security misconfigurations manually or through recommended steps.

## 🎯 Future Scope

- 🔔 Real-time system tray alerts for detected issues.
- 📝 Export scan results to PDF/HTML reports.
- 🔄 Auto-fix for selected high-risk vulnerabilities.
- 🌐 Remote monitoring capabilities for enterprise environments.

## 🤝 Contributing

Contributions, suggestions, or improvements are welcome! Feel free to open an issue or submit a pull request.

## 🛡️ Disclaimer

This tool is designed for educational and security assessment purposes. The author is not responsible for any misuse or damage caused by this tool.

---

## 📜 License

[MIT License](LICENSE)
