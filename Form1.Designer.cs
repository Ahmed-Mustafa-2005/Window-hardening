namespace DynamicSecurityMonitor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monitorTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStatus = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.statusCardFirewall = new DynamicSecurityMonitor.StatusCard();
            this.statusCardAntivirus = new DynamicSecurityMonitor.StatusCard();
            this.statusCardUac = new DynamicSecurityMonitor.StatusCard();
            this.statusCardDep = new DynamicSecurityMonitor.StatusCard();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnReEnable = new System.Windows.Forms.Button();
            this.tabPageScanners = new System.Windows.Forms.TabPage();
            this.gbUnquotedServices = new System.Windows.Forms.GroupBox();
            this.lvUnquotedServices = new System.Windows.Forms.ListView();
            this.chServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServicePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUnquotedActions = new System.Windows.Forms.Panel();
            this.btnFixService = new System.Windows.Forms.Button();
            this.btnScanServices = new System.Windows.Forms.Button();
            this.tabPageStartup = new System.Windows.Forms.TabPage();
            this.gbStartup = new System.Windows.Forms.GroupBox();
            this.lvStartupItems = new System.Windows.Forms.ListView();
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelStartupActions = new System.Windows.Forms.Panel();
            this.btnDisableStartupItem = new System.Windows.Forms.Button();
            this.btnScanStartup = new System.Windows.Forms.Button();
            this.tabPageVirusScan = new System.Windows.Forms.TabPage();
            this.gbVirusScan = new System.Windows.Forms.GroupBox();
            this.lblScanStatus = new System.Windows.Forms.Label();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.tabPageUpdates = new System.Windows.Forms.TabPage();
            this.gbUpdates = new System.Windows.Forms.GroupBox();
            this.lblPatchAnalysis = new System.Windows.Forms.Label();
            this.btnAnalyzePatches = new System.Windows.Forms.Button();
            this.lvHotfixes = new System.Windows.Forms.ListView();
            this.chHotfixId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInstallUpdates = new System.Windows.Forms.Button();
            this.lblWinVer = new System.Windows.Forms.Label();
            this.lblWinEdition = new System.Windows.Forms.Label();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageStatus.SuspendLayout();
            this.flowLayoutPanelStatus.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.tabPageScanners.SuspendLayout();
            this.gbUnquotedServices.SuspendLayout();
            this.panelUnquotedActions.SuspendLayout();
            this.tabPageStartup.SuspendLayout();
            this.gbStartup.SuspendLayout();
            this.panelStartupActions.SuspendLayout();
            this.tabPageVirusScan.SuspendLayout();
            this.gbVirusScan.SuspendLayout();
            this.tabPageUpdates.SuspendLayout();
            this.gbUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitorTimer
            // 
            this.monitorTimer.Tick += new System.EventHandler(this.monitorTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Dynamic Security Monitor";
            this.notifyIcon1.Visible = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStatus);
            this.tabControlMain.Controls.Add(this.tabPageScanners);
            this.tabControlMain.Controls.Add(this.tabPageStartup);
            this.tabControlMain.Controls.Add(this.tabPageVirusScan);
            this.tabControlMain.Controls.Add(this.tabPageUpdates);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(884, 661);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStatus
            // 
            this.tabPageStatus.BackColor = System.Drawing.Color.White;
            this.tabPageStatus.Controls.Add(this.flowLayoutPanelStatus);
            this.tabPageStatus.Controls.Add(this.panelActions);
            this.tabPageStatus.Location = new System.Drawing.Point(4, 34);
            this.tabPageStatus.Name = "tabPageStatus";
            this.tabPageStatus.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageStatus.Size = new System.Drawing.Size(876, 623);
            this.tabPageStatus.TabIndex = 0;
            this.tabPageStatus.Text = "System Status Dashboard";
            // 
            // flowLayoutPanelStatus
            // 
            this.flowLayoutPanelStatus.AutoScroll = true;
            this.flowLayoutPanelStatus.Controls.Add(this.statusCardFirewall);
            this.flowLayoutPanelStatus.Controls.Add(this.statusCardAntivirus);
            this.flowLayoutPanelStatus.Controls.Add(this.statusCardUac);
            this.flowLayoutPanelStatus.Controls.Add(this.statusCardDep);
            this.flowLayoutPanelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelStatus.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelStatus.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelStatus.Name = "flowLayoutPanelStatus";
            this.flowLayoutPanelStatus.Size = new System.Drawing.Size(856, 543);
            this.flowLayoutPanelStatus.TabIndex = 0;
            this.flowLayoutPanelStatus.WrapContents = false;
            this.flowLayoutPanelStatus.SizeChanged += new System.EventHandler(this.flowLayoutPanelStatus_SizeChanged);
            // 
            // statusCardFirewall
            // 
            this.statusCardFirewall.BackColor = System.Drawing.Color.Gainsboro;
            this.statusCardFirewall.Location = new System.Drawing.Point(3, 3);
            this.statusCardFirewall.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.statusCardFirewall.Name = "statusCardFirewall";
            this.statusCardFirewall.Size = new System.Drawing.Size(820, 95);
            // 
            // statusCardAntivirus
            // 
            this.statusCardAntivirus.BackColor = System.Drawing.Color.Gainsboro;
            this.statusCardAntivirus.Location = new System.Drawing.Point(3, 111);
            this.statusCardAntivirus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.statusCardAntivirus.Name = "statusCardAntivirus";
            this.statusCardAntivirus.Size = new System.Drawing.Size(820, 95);
            // 
            // statusCardUac
            // 
            this.statusCardUac.BackColor = System.Drawing.Color.Gainsboro;
            this.statusCardUac.Location = new System.Drawing.Point(3, 219);
            this.statusCardUac.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.statusCardUac.Name = "statusCardUac";
            this.statusCardUac.Size = new System.Drawing.Size(820, 95);
            // 
            // statusCardDep
            // 
            this.statusCardDep.BackColor = System.Drawing.Color.Gainsboro;
            this.statusCardDep.Location = new System.Drawing.Point(3, 327);
            this.statusCardDep.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.statusCardDep.Name = "statusCardDep";
            this.statusCardDep.Size = new System.Drawing.Size(820, 95);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnReEnable);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(10, 553);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(856, 60);
            // 
            // btnReEnable
            // 
            this.btnReEnable.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnReEnable.Location = new System.Drawing.Point(3, 8);
            this.btnReEnable.Name = "btnReEnable";
            this.btnReEnable.Size = new System.Drawing.Size(280, 45);
            this.btnReEnable.Text = "Re-enable Firewalls";
            this.btnReEnable.Click += new System.EventHandler(this.btnReEnable_Click);
            // 
            // tabPageScanners
            // 
            this.tabPageScanners.BackColor = System.Drawing.Color.White;
            this.tabPageScanners.Controls.Add(this.gbUnquotedServices);
            this.tabPageScanners.Location = new System.Drawing.Point(4, 34);
            this.tabPageScanners.Name = "tabPageScanners";
            this.tabPageScanners.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageScanners.Size = new System.Drawing.Size(876, 623);
            this.tabPageScanners.Text = "Vulnerability Scanners";
            // 
            // gbUnquotedServices
            // 
            this.gbUnquotedServices.Controls.Add(this.lvUnquotedServices);
            this.gbUnquotedServices.Controls.Add(this.panelUnquotedActions);
            this.gbUnquotedServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUnquotedServices.Location = new System.Drawing.Point(10, 10);
            this.gbUnquotedServices.Name = "gbUnquotedServices";
            this.gbUnquotedServices.Size = new System.Drawing.Size(856, 603);
            this.gbUnquotedServices.TabStop = false;
            this.gbUnquotedServices.Text = "Unquoted Service Path Scan";
            // 
            // lvUnquotedServices
            // 
            this.lvUnquotedServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.chServiceName, this.chServicePath });
            this.lvUnquotedServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUnquotedServices.FullRowSelect = true;
            this.lvUnquotedServices.HideSelection = false;
            this.lvUnquotedServices.Location = new System.Drawing.Point(3, 27);
            this.lvUnquotedServices.Name = "lvUnquotedServices";
            this.lvUnquotedServices.Size = new System.Drawing.Size(850, 511);
            this.lvUnquotedServices.View = System.Windows.Forms.View.Details;
            this.lvUnquotedServices.SelectedIndexChanged += new System.EventHandler(this.lvUnquotedServices_SelectedIndexChanged);
            // 
            // chServiceName
            // 
            this.chServiceName.Text = "Service Name";
            this.chServiceName.Width = 200;
            // 
            // chServicePath
            // 
            this.chServicePath.Text = "Vulnerable Path";
            this.chServicePath.Width = 500;
            // 
            // panelUnquotedActions
            // 
            this.panelUnquotedActions.Controls.Add(this.btnFixService);
            this.panelUnquotedActions.Controls.Add(this.btnScanServices);
            this.panelUnquotedActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUnquotedActions.Location = new System.Drawing.Point(3, 538);
            this.panelUnquotedActions.Name = "panelUnquotedActions";
            this.panelUnquotedActions.Size = new System.Drawing.Size(850, 62);
            // 
            // btnFixService
            // 
            this.btnFixService.Enabled = false;
            this.btnFixService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFixService.Location = new System.Drawing.Point(162, 9);
            this.btnFixService.Name = "btnFixService";
            this.btnFixService.Size = new System.Drawing.Size(200, 45);
            this.btnFixService.Text = "Fix Selected Service";
            this.btnFixService.Click += new System.EventHandler(this.btnFixService_Click);
            // 
            // btnScanServices
            // 
            this.btnScanServices.Location = new System.Drawing.Point(3, 9);
            this.btnScanServices.Name = "btnScanServices";
            this.btnScanServices.Size = new System.Drawing.Size(150, 45);
            this.btnScanServices.Text = "Scan Now";
            this.btnScanServices.Click += new System.EventHandler(this.btnScanServices_Click);
            // 
            // tabPageStartup
            // 
            this.tabPageStartup.BackColor = System.Drawing.Color.White;
            this.tabPageStartup.Controls.Add(this.gbStartup);
            this.tabPageStartup.Location = new System.Drawing.Point(4, 34);
            this.tabPageStartup.Name = "tabPageStartup";
            this.tabPageStartup.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageStartup.Size = new System.Drawing.Size(876, 623);
            this.tabPageStartup.TabIndex = 2;
            this.tabPageStartup.Text = "Startup Manager";
            // 
            // gbStartup
            // 
            this.gbStartup.Controls.Add(this.lvStartupItems);
            this.gbStartup.Controls.Add(this.panelStartupActions);
            this.gbStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStartup.Location = new System.Drawing.Point(10, 10);
            this.gbStartup.Name = "gbStartup";
            this.gbStartup.Size = new System.Drawing.Size(856, 603);
            this.gbStartup.TabStop = false;
            this.gbStartup.Text = "Programs that Run at Startup";
            // 
            // lvStartupItems
            // 
            this.lvStartupItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.chItemName, this.chItemPath, this.chItemLocation });
            this.lvStartupItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStartupItems.FullRowSelect = true;
            this.lvStartupItems.HideSelection = false;
            this.lvStartupItems.Location = new System.Drawing.Point(3, 27);
            this.lvStartupItems.Name = "lvStartupItems";
            this.lvStartupItems.Size = new System.Drawing.Size(850, 511);
            this.lvStartupItems.View = System.Windows.Forms.View.Details;
            this.lvStartupItems.SelectedIndexChanged += new System.EventHandler(this.lvStartupItems_SelectedIndexChanged);
            // 
            // chItemName
            // 
            this.chItemName.Text = "Program Name";
            this.chItemName.Width = 200;
            // 
            // chItemPath
            // 
            this.chItemPath.Text = "Command / Path";
            this.chItemPath.Width = 400;
            // 
            // chItemLocation
            // 
            this.chItemLocation.Text = "Location";
            this.chItemLocation.Width = 200;
            // 
            // panelStartupActions
            // 
            this.panelStartupActions.Controls.Add(this.btnDisableStartupItem);
            this.panelStartupActions.Controls.Add(this.btnScanStartup);
            this.panelStartupActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStartupActions.Location = new System.Drawing.Point(3, 538);
            this.panelStartupActions.Name = "panelStartupActions";
            this.panelStartupActions.Size = new System.Drawing.Size(850, 62);
            // 
            // btnDisableStartupItem
            // 
            this.btnDisableStartupItem.Enabled = false;
            this.btnDisableStartupItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDisableStartupItem.Location = new System.Drawing.Point(219, 9);
            this.btnDisableStartupItem.Name = "btnDisableStartupItem";
            this.btnDisableStartupItem.Size = new System.Drawing.Size(200, 45);
            this.btnDisableStartupItem.Text = "Disable Selected";
            this.btnDisableStartupItem.Click += new System.EventHandler(this.btnDisableStartupItem_Click);
            // 
            // btnScanStartup
            // 
            this.btnScanStartup.Location = new System.Drawing.Point(3, 9);
            this.btnScanStartup.Name = "btnScanStartup";
            this.btnScanStartup.Size = new System.Drawing.Size(200, 45);
            this.btnScanStartup.Text = "Scan Startup Items";
            this.btnScanStartup.Click += new System.EventHandler(this.btnScanStartup_Click);
            // 
            // tabPageVirusScan
            // 
            this.tabPageVirusScan.BackColor = System.Drawing.Color.White;
            this.tabPageVirusScan.Controls.Add(this.gbVirusScan);
            this.tabPageVirusScan.Location = new System.Drawing.Point(4, 34);
            this.tabPageVirusScan.Name = "tabPageVirusScan";
            this.tabPageVirusScan.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageVirusScan.Size = new System.Drawing.Size(876, 623);
            this.tabPageVirusScan.TabIndex = 3;
            this.tabPageVirusScan.Text = "Virus & Threat Scan";
            // 
            // gbVirusScan
            // 
            this.gbVirusScan.Controls.Add(this.lblScanStatus);
            this.gbVirusScan.Controls.Add(this.progressBarScan);
            this.gbVirusScan.Controls.Add(this.btnStartScan);
            this.gbVirusScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVirusScan.Location = new System.Drawing.Point(10, 10);
            this.gbVirusScan.Name = "gbVirusScan";
            this.gbVirusScan.Size = new System.Drawing.Size(856, 603);
            this.gbVirusScan.TabIndex = 0;
            this.gbVirusScan.TabStop = false;
            this.gbVirusScan.Text = "Windows Defender Antivirus Scan";
            // 
            // lblScanStatus
            // 
            this.lblScanStatus.AutoSize = true;
            this.lblScanStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblScanStatus.Location = new System.Drawing.Point(20, 110);
            this.lblScanStatus.Name = "lblScanStatus";
            this.lblScanStatus.Size = new System.Drawing.Size(126, 31);
            this.lblScanStatus.TabIndex = 2;
            this.lblScanStatus.Text = "Status: Idle";
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(26, 145);
            this.progressBarScan.MarqueeAnimationSpeed = 50;
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(400, 23);
            this.progressBarScan.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarScan.Visible = false;
            // 
            // btnStartScan
            // 
            this.btnStartScan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStartScan.Location = new System.Drawing.Point(26, 40);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(250, 55);
            this.btnStartScan.TabIndex = 0;
            this.btnStartScan.Text = "Start Quick Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // tabPageUpdates
            // 
            this.tabPageUpdates.BackColor = System.Drawing.Color.White;
            this.tabPageUpdates.Controls.Add(this.gbUpdates);
            this.tabPageUpdates.Location = new System.Drawing.Point(4, 34);
            this.tabPageUpdates.Name = "tabPageUpdates";
            this.tabPageUpdates.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageUpdates.Size = new System.Drawing.Size(876, 623);
            this.tabPageUpdates.TabIndex = 4;
            this.tabPageUpdates.Text = "Windows Update & Version";
            // 
            // gbUpdates
            // 
            this.gbUpdates.Controls.Add(this.lblPatchAnalysis);
            this.gbUpdates.Controls.Add(this.btnAnalyzePatches);
            this.gbUpdates.Controls.Add(this.lvHotfixes);
            this.gbUpdates.Controls.Add(this.btnInstallUpdates);
            this.gbUpdates.Controls.Add(this.lblWinVer);
            this.gbUpdates.Controls.Add(this.lblWinEdition);
            this.gbUpdates.Controls.Add(this.lblUpdateStatus);
            this.gbUpdates.Controls.Add(this.btnCheckUpdates);
            this.gbUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUpdates.Location = new System.Drawing.Point(10, 10);
            this.gbUpdates.Name = "gbUpdates";
            this.gbUpdates.Size = new System.Drawing.Size(856, 603);
            this.gbUpdates.TabIndex = 0;
            this.gbUpdates.TabStop = false;
            this.gbUpdates.Text = "System Version & Update Status";
            // 
            // lblPatchAnalysis
            // 
            this.lblPatchAnalysis.AutoSize = true;
            this.lblPatchAnalysis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic);
            this.lblPatchAnalysis.Location = new System.Drawing.Point(20, 180);
            this.lblPatchAnalysis.Name = "lblPatchAnalysis";
            this.lblPatchAnalysis.Size = new System.Drawing.Size(370, 31);
            this.lblPatchAnalysis.TabIndex = 6;
            this.lblPatchAnalysis.Text = "Analysis: Ready to analyze patch status...";
            // 
            // btnAnalyzePatches
            // 
            this.btnAnalyzePatches.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAnalyzePatches.Location = new System.Drawing.Point(26, 130);
            this.btnAnalyzePatches.Name = "btnAnalyzePatches";
            this.btnAnalyzePatches.Size = new System.Drawing.Size(250, 45);
            this.btnAnalyzePatches.TabIndex = 7;
            this.btnAnalyzePatches.Text = "Analyze Patch Status";
            this.btnAnalyzePatches.UseVisualStyleBackColor = true;
            this.btnAnalyzePatches.Click += new System.EventHandler(this.btnAnalyzePatches_Click);
            // 
            // lvHotfixes
            // 
            this.lvHotfixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHotfixes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.chHotfixId });
            this.lvHotfixes.HideSelection = false;
            this.lvHotfixes.Location = new System.Drawing.Point(450, 40);
            this.lvHotfixes.Name = "lvHotfixes";
            this.lvHotfixes.Size = new System.Drawing.Size(380, 540);
            this.lvHotfixes.TabIndex = 4;
            this.lvHotfixes.UseCompatibleStateImageBehavior = false;
            this.lvHotfixes.View = System.Windows.Forms.View.Details;
            // 
            // chHotfixId
            // 
            this.chHotfixId.Text = "Installed Security Hotfixes (KB IDs)";
            this.chHotfixId.Width = 350;
            // 
            // btnInstallUpdates
            // 
            this.btnInstallUpdates.Enabled = false;
            this.btnInstallUpdates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInstallUpdates.Location = new System.Drawing.Point(26, 350);
            this.btnInstallUpdates.Name = "btnInstallUpdates";
            this.btnInstallUpdates.Size = new System.Drawing.Size(250, 55);
            this.btnInstallUpdates.TabIndex = 5;
            this.btnInstallUpdates.Text = "Install Updates...";
            this.btnInstallUpdates.UseVisualStyleBackColor = true;
            this.btnInstallUpdates.Click += new System.EventHandler(this.btnInstallUpdates_Click);
            // 
            // lblWinVer
            // 
            this.lblWinVer.AutoSize = true;
            this.lblWinVer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblWinVer.Location = new System.Drawing.Point(20, 80);
            this.lblWinVer.Name = "lblWinVer";
            this.lblWinVer.Size = new System.Drawing.Size(189, 31);
            this.lblWinVer.TabIndex = 3;
            this.lblWinVer.Text = "Version: Loading...";
            // 
            // lblWinEdition
            // 
            this.lblWinEdition.AutoSize = true;
            this.lblWinEdition.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblWinEdition.Location = new System.Drawing.Point(20, 40);
            this.lblWinEdition.Name = "lblWinEdition";
            this.lblWinEdition.Size = new System.Drawing.Size(199, 32);
            this.lblWinEdition.TabIndex = 2;
            this.lblWinEdition.Text = "Edition: Loading...";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblUpdateStatus.Location = new System.Drawing.Point(20, 290);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(325, 31);
            this.lblUpdateStatus.TabIndex = 1;
            this.lblUpdateStatus.Text = "New Update Status: Ready to check...";
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCheckUpdates.Location = new System.Drawing.Point(26, 230);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(250, 55);
            this.btnCheckUpdates.TabIndex = 0;
            this.btnCheckUpdates.Text = "Check for New Updates";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Dynamic Security Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStatus.ResumeLayout(false);
            this.flowLayoutPanelStatus.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.tabPageScanners.ResumeLayout(false);
            this.gbUnquotedServices.ResumeLayout(false);
            this.panelUnquotedActions.ResumeLayout(false);
            this.tabPageStartup.ResumeLayout(false);
            this.gbStartup.ResumeLayout(false);
            this.panelStartupActions.ResumeLayout(false);
            this.tabPageVirusScan.ResumeLayout(false);
            this.gbVirusScan.ResumeLayout(false);
            this.gbVirusScan.PerformLayout();
            this.tabPageUpdates.ResumeLayout(false);
            this.gbUpdates.ResumeLayout(false);
            this.gbUpdates.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Timer monitorTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStatus;
        private StatusCard statusCardFirewall;
        private StatusCard statusCardAntivirus;
        private StatusCard statusCardUac;
        private StatusCard statusCardDep;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnReEnable;
        private System.Windows.Forms.TabPage tabPageScanners;
        private System.Windows.Forms.GroupBox gbUnquotedServices;
        private System.Windows.Forms.ListView lvUnquotedServices;
        private System.Windows.Forms.Panel panelUnquotedActions;
        private System.Windows.Forms.Button btnFixService;
        private System.Windows.Forms.Button btnScanServices;
        private System.Windows.Forms.ColumnHeader chServiceName;
        private System.Windows.Forms.ColumnHeader chServicePath;
        private System.Windows.Forms.TabPage tabPageStartup;
        private System.Windows.Forms.GroupBox gbStartup;
        private System.Windows.Forms.ListView lvStartupItems;
        private System.Windows.Forms.Panel panelStartupActions;
        private System.Windows.Forms.Button btnDisableStartupItem;
        private System.Windows.Forms.Button btnScanStartup;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemPath;
        private System.Windows.Forms.ColumnHeader chItemLocation;
        private System.Windows.Forms.TabPage tabPageVirusScan;
        private System.Windows.Forms.GroupBox gbVirusScan;
        private System.Windows.Forms.Label lblScanStatus;
        private System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.TabPage tabPageUpdates;
        private System.Windows.Forms.GroupBox gbUpdates;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Button btnCheckUpdates;
        private System.Windows.Forms.Label lblWinVer;
        private System.Windows.Forms.Label lblWinEdition;
        private System.Windows.Forms.ListView lvHotfixes;
        private System.Windows.Forms.ColumnHeader chHotfixId;
        private System.Windows.Forms.Button btnInstallUpdates;
        private System.Windows.Forms.Label lblPatchAnalysis;
        private System.Windows.Forms.Button btnAnalyzePatches;
    }
}
