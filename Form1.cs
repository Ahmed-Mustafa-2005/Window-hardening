using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicSecurityMonitor.Monitors;

namespace DynamicSecurityMonitor
{
    public partial class Form1 : Form
    {
        // Add instance of the new monitor
        private readonly WindowsUpdateMonitor updateMonitor = new WindowsUpdateMonitor();
        // (Other monitor instances)
        private readonly VirusScanMonitor virusScanMonitor = new VirusScanMonitor();
        private readonly StartupProgramMonitor startupProgramMonitor = new StartupProgramMonitor();
        private readonly FirewallMonitor firewallMonitor = new FirewallMonitor();
        private readonly AntivirusMonitor antivirusMonitor = new AntivirusMonitor();
        private readonly DepMonitor depMonitor = new DepMonitor();
        private readonly UacMonitor uacMonitor = new UacMonitor();
        private readonly UnquotedServicePathMonitor unquotedServiceMonitor = new UnquotedServicePathMonitor();

        public Form1()
        {
            InitializeComponent();
            InitializeStatusCards();
        }

        private void InitializeStatusCards()
        {
            statusCardFirewall.Title = "Windows Firewall";
            statusCardFirewall.Icon = SystemIcons.Shield.ToBitmap();
            statusCardAntivirus.Title = "Antivirus";
            statusCardAntivirus.Icon = SystemIcons.Hand.ToBitmap();
            statusCardUac.Title = "User Account Control (UAC)";
            statusCardUac.Icon = SystemIcons.Question.ToBitmap();
            statusCardDep.Title = "Data Execution Prevention (DEP)";
            statusCardDep.Icon = SystemIcons.Application.ToBitmap();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanelStatus_SizeChanged(null, null);

            // On load, just get the static OS Name and Version.
            var sysInfo = await updateMonitor.GetSystemInfoAsync();
            lblWinEdition.Text = sysInfo.OsName;
            lblWinVer.Text = sysInfo.OsVersion;
            // Set the initial status text for the analysis.
            lblPatchAnalysis.Text = "Analysis: Ready to analyze patch status...";


            // Start the monitoring timer
            monitorTimer_Tick(null, null);
            monitorTimer.Interval = 3000;
            monitorTimer.Start();
        }

        // --- NEW On-Demand Analysis Method ---
        private async void btnAnalyzePatches_Click(object sender, EventArgs e)
        {
            lblPatchAnalysis.Text = "Analyzing patch history...";
            lblPatchAnalysis.ForeColor = Color.Black;
            btnAnalyzePatches.Enabled = false;
            lvHotfixes.Items.Clear();
            Application.DoEvents();

            var sysInfo = await updateMonitor.GetSystemInfoAsync();

            // Populate the Hotfixes list
            foreach (var hotfix in sysInfo.Hotfixes)
            {
                lvHotfixes.Items.Add(new ListViewItem(hotfix));
            }

            // Perform security analysis based on patch recency
            if (sysInfo.LastHotfixDate.HasValue)
            {
                TimeSpan timeSinceLastUpdate = DateTime.Now - sysInfo.LastHotfixDate.Value;

                if (timeSinceLastUpdate.TotalDays <= 35)
                {
                    lblPatchAnalysis.Text = $"Analysis: System is actively patched (last update: {sysInfo.LastHotfixDate:yyyy-MM-dd}).";
                    lblPatchAnalysis.ForeColor = Color.DarkGreen;
                }
                else if (timeSinceLastUpdate.TotalDays <= 90)
                {
                    lblPatchAnalysis.Text = $"Analysis: Last patched on {sysInfo.LastHotfixDate:yyyy-MM-dd}. Consider checking for new updates.";
                    lblPatchAnalysis.ForeColor = Color.Orange;
                }
                else
                {
                    lblPatchAnalysis.Text = $"ANALYSIS: CRITICAL! No updates installed since {sysInfo.LastHotfixDate:yyyy-MM-dd}. System is at high risk.";
                    lblPatchAnalysis.ForeColor = Color.Firebrick;
                }
            }
            else
            {
                lblPatchAnalysis.Text = "Analysis: Could not determine last update date.";
                lblPatchAnalysis.ForeColor = Color.Black;
            }
            btnAnalyzePatches.Enabled = true;
        }

        private void monitorTimer_Tick(object sender, EventArgs e)
        {
            string fwNotification = firewallMonitor.CheckStatus();
            string avNotification = antivirusMonitor.CheckStatus();
            string uacNotification = uacMonitor.CheckStatus();
            depMonitor.CheckStatus();

            if (fwNotification != null) ShowNotification("Security Alert", fwNotification, ToolTipIcon.Warning);
            if (avNotification != null) ShowNotification("Security Alert", avNotification, ToolTipIcon.Error);
            if (uacNotification != null) ShowNotification("Security Alert", uacNotification, ToolTipIcon.Error);

            UpdateUI();
        }

        private void UpdateUI()
        {
            bool allFirewallsOn = firewallMonitor.IsPublicFirewallOn && firewallMonitor.IsPrivateFirewallOn && firewallMonitor.IsDomainFirewallOn;
            statusCardFirewall.UpdateStatus(allFirewallsOn, allFirewallsOn ? "Enabled" : "DISABLED");
            statusCardAntivirus.UpdateStatus(antivirusMonitor.IsAvActive, antivirusMonitor.IsAvActive ? "Enabled" : "Disabled");
            statusCardUac.UpdateStatus(uacMonitor.IsUacEnabled, uacMonitor.IsUacEnabled ? "Enabled" : "Disabled");

            bool isDepSecure = depMonitor.DepStatus.Contains("OptOut") || depMonitor.DepStatus.Contains("AlwaysOn");
            string depDisplayText = depMonitor.DepStatus;
            if (depDisplayText.Contains("OptOut")) depDisplayText = "Enabled (OptOut)";
            else if (depDisplayText.Contains("OptIn")) depDisplayText = "Enabled (OptIn)";
            else if (depDisplayText.Contains("AlwaysOn")) depDisplayText = "Enabled (Always On)";
            else if (depDisplayText.Contains("AlwaysOff")) depDisplayText = "DISABLED";
            statusCardDep.UpdateStatus(isDepSecure, depDisplayText);

            btnReEnable.Enabled = !allFirewallsOn;
        }

        private void flowLayoutPanelStatus_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanelStatus.Controls)
                if (control is StatusCard) control.Width = flowLayoutPanelStatus.ClientSize.Width;
        }

        private void btnReEnable_Click(object sender, EventArgs e)
        {
            if (firewallMonitor.EnableFirewalls())
                MessageBox.Show("All firewall profiles have been successfully re-enabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to re-enable firewalls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UpdateUI();
        }

        private void btnScanServices_Click(object sender, EventArgs e)
        {
            btnScanServices.Text = "Scanning...";
            btnScanServices.Enabled = false;
            lvUnquotedServices.Items.Clear();
            Application.DoEvents();

            List<string> vulnerableServices = unquotedServiceMonitor.ScanForVulnerableServices();

            foreach (string result in vulnerableServices)
            {
                string[] parts = result.Split(new[] { ':' }, 2);
                ListViewItem item = new ListViewItem(parts[0]);
                if (parts.Length > 1) item.SubItems.Add(parts[1].Trim());
                lvUnquotedServices.Items.Add(item);
            }

            MessageBox.Show(lvUnquotedServices.Items.Count > 0 ? $"Found {lvUnquotedServices.Items.Count} vulnerable service(s)." : "No unquoted service path vulnerabilities found.", "Scan Complete", MessageBoxButtons.OK, lvUnquotedServices.Items.Count > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

            btnScanServices.Text = "Scan Now";
            btnScanServices.Enabled = true;
            lvUnquotedServices_SelectedIndexChanged(null, null);
        }

        private void btnFixService_Click(object sender, EventArgs e)
        {
            if (lvUnquotedServices.SelectedItems.Count == 0) return;
            string serviceName = lvUnquotedServices.SelectedItems[0].Text;
            var confirmResult = MessageBox.Show($"Are you sure you want to fix the service '{serviceName}'?", "Confirm Fix", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                if (unquotedServiceMonitor.FixService(serviceName))
                {
                    MessageBox.Show($"Successfully fixed service '{serviceName}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnScanServices_Click(null, null);
                }
                else
                    MessageBox.Show($"Failed to fix service '{serviceName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvUnquotedServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFixService.Enabled = (lvUnquotedServices.SelectedItems.Count > 0);
        }

        private void btnScanStartup_Click(object sender, EventArgs e)
        {
            btnScanStartup.Text = "Scanning...";
            btnScanStartup.Enabled = false;
            lvStartupItems.Items.Clear();
            Application.DoEvents();

            List<StartupItem> startupItems = startupProgramMonitor.ScanForStartupPrograms();

            foreach (var item in startupItems)
            {
                ListViewItem lvItem = new ListViewItem(item.Name);
                lvItem.SubItems.Add(item.Command);
                lvItem.SubItems.Add(item.Location);
                lvItem.Tag = item;
                lvStartupItems.Items.Add(lvItem);
            }

            MessageBox.Show($"Found {startupItems.Count} startup item(s).", "Scan Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnScanStartup.Text = "Scan Startup Items";
            btnScanStartup.Enabled = true;
            lvStartupItems_SelectedIndexChanged(null, null);
        }

        private void btnDisableStartupItem_Click(object sender, EventArgs e)
        {
            if (lvStartupItems.SelectedItems.Count == 0) return;
            StartupItem itemToDisable = (StartupItem)lvStartupItems.SelectedItems[0].Tag;
            var confirmResult = MessageBox.Show($"Are you sure you want to disable the startup item '{itemToDisable.Name}'?", "Confirm Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                if (startupProgramMonitor.DisableStartupItem(itemToDisable))
                {
                    MessageBox.Show($"Successfully disabled '{itemToDisable.Name}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnScanStartup_Click(null, null);
                }
                else
                    MessageBox.Show($"Failed to disable '{itemToDisable.Name}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvStartupItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDisableStartupItem.Enabled = (lvStartupItems.SelectedItems.Count > 0);
        }

        private async void btnStartScan_Click(object sender, EventArgs e)
        {
            btnStartScan.Enabled = false;
            lblScanStatus.Text = "Status: Scanning in progress...";
            progressBarScan.Visible = true;

            bool success = await virusScanMonitor.StartQuickScanAsync();

            progressBarScan.Visible = false;
            lblScanStatus.Text = "Status: Idle";
            btnStartScan.Enabled = true;

            if (success)
                MessageBox.Show("Windows Defender quick scan completed successfully.", "Scan Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to start Windows Defender scan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            btnCheckUpdates.Enabled = false;
            lblUpdateStatus.Text = "New Update Status: Checking...";
            Application.DoEvents();

            int updateCount = await updateMonitor.CheckForNewUpdatesAsync();

            if (updateCount > 0)
            {
                lblUpdateStatus.Text = $"New Update Status: {updateCount} important update(s) available!";
                lblUpdateStatus.ForeColor = Color.Firebrick;
                btnInstallUpdates.Enabled = true;
            }
            else if (updateCount == 0)
            {
                lblUpdateStatus.Text = "New Update Status: Your system is fully up to date.";
                lblUpdateStatus.ForeColor = Color.DarkGreen;
                btnInstallUpdates.Enabled = false;
            }
            else
            {
                lblUpdateStatus.Text = "New Update Status: Error checking for updates.";
                lblUpdateStatus.ForeColor = Color.Black;
                btnInstallUpdates.Enabled = false;
            }

            btnCheckUpdates.Enabled = true;
        }

        private void btnInstallUpdates_Click(object sender, EventArgs e)
        {
            updateMonitor.OpenUpdateSettings();
        }

        private void ShowNotification(string title, string text, ToolTipIcon icon)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(3000);
        }
    }
}
