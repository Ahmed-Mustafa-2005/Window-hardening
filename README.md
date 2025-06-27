Dynamic Security Monitor (v1.0)
Project Overview
Dynamic Security Monitor is a comprehensive system hardening and monitoring utility for the Windows operating system, developed in C# using Windows Forms. This tool provides real-time security status monitoring, on-demand vulnerability scanning, and active system management capabilities through a clean, modern, multi-tabbed interface.
The project was developed to provide system administrators, IT professionals, and security-conscious users with a centralized dashboard to proactively identify, analyze, and remediate common security misconfigurations and threats.

Key Features
The tool is organized into a five-tab layout for clear and intuitive navigation:

1. System Status Dashboard
    A live dashboard that continuously monitors critical system settings and provides at-a-glance status using color-coded cards.

    Windows Firewall: Monitors Public, Private, and Domain profiles.

    Antivirus: Checks for an active and running AV solution via WMI.

    User Account Control (UAC): Ensures UAC is enabled and not set to an insecure "auto-approve" level.

    Data Execution Prevention (DEP): Reports the active DEP policy.

Live Notifications: Triggers desktop alerts if a monitored setting becomes insecure.

2. Vulnerability Scanners
Contains tools for finding common privilege escalation vectors.

Unquoted Service Path Scanner: Detects and provides a one-click fix for services with unquoted executable paths.

3. Startup Manager
A powerful utility to inspect and manage programs that launch automatically on system boot.

Comprehensive Scan: Scans all common registry keys and startup folders for both the current user and all users.

Disable Functionality: Allows users to select and permanently disable unwanted or suspicious startup items.

4. Virus & Threat Scan
Provides an interface for on-demand threat scanning.

Windows Defender Integration: Launches a silent "Quick Scan" using the built-in Windows Defender command-line tool.

Progress Feedback: Displays the scan status to the user.

5. Windows Update & Version
Offers tools to analyze the system's patch level and version.

Accurate OS Versioning: Uses the systeminfo command and WMI to get the correct OS name, build number, and patch history.

Patch Recency Analysis: Analyzes the install dates of security hotfixes to determine if the system is actively patched.

Update Check & Install: Checks for new available updates via the Windows Update Agent API and provides a button to open the Windows Update settings page.

How to Run
Navigate to the Releases page.

Download the latest release archive (DynamicSecurityMonitor.zip).

Extract the contents.

Ensure DynamicSecurityMonitor.exe and DynamicSecurityMonitor.exe.config are in the same folder.

Right-click DynamicSecurityMonitor.exe and select "Run as administrator" or double-click and approve the UAC prompt.

Technical Details
Language: C# (.NET Framework)

Platform: Windows Forms (WinForms)

Core APIs Used: WMI, Windows Registry, Windows Update Agent API (WUApiLib), .NET Process and File System APIs.