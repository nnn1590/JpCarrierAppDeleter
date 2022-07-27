namespace CarrierAppDeleter.Forms {
	partial class MainForm {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanelDevice = new System.Windows.Forms.TableLayoutPanel();
			this.buttonRefreshDevices = new System.Windows.Forms.Button();
			this.comboBoxDevice = new System.Windows.Forms.ComboBox();
			this.groupBoxDevice = new System.Windows.Forms.GroupBox();
			this.groupBoxApplications = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelApplications = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelAppActions = new System.Windows.Forms.TableLayoutPanel();
			this.labelAppActions = new System.Windows.Forms.Label();
			this.radioButtonAppActUninstall = new System.Windows.Forms.RadioButton();
			this.radioButtonAppActDisable = new System.Windows.Forms.RadioButton();
			this.radioButtonAppActRestore = new System.Windows.Forms.RadioButton();
			this.buttonRefreshApplications = new System.Windows.Forms.Button();
			this.checkedListBoxApplications = new System.Windows.Forms.CheckedListBox();
			this.tableLayoutPanelAppListActions = new System.Windows.Forms.TableLayoutPanel();
			this.buttonSelectAllApps = new System.Windows.Forms.Button();
			this.buttonDeselectAllApps = new System.Windows.Forms.Button();
			this.buttonExclDisasterApps = new System.Windows.Forms.Button();
			this.buttonExclWiFiApps = new System.Windows.Forms.Button();
			this.buttonExecuteAppActions = new System.Windows.Forms.Button();
			this.groupBoxLog = new System.Windows.Forms.GroupBox();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainerAppsAndLog = new System.Windows.Forms.SplitContainer();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tableLayoutPanelDevice.SuspendLayout();
			this.groupBoxDevice.SuspendLayout();
			this.groupBoxApplications.SuspendLayout();
			this.tableLayoutPanelApplications.SuspendLayout();
			this.tableLayoutPanelAppActions.SuspendLayout();
			this.tableLayoutPanelAppListActions.SuspendLayout();
			this.groupBoxLog.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerAppsAndLog)).BeginInit();
			this.splitContainerAppsAndLog.Panel1.SuspendLayout();
			this.splitContainerAppsAndLog.Panel2.SuspendLayout();
			this.splitContainerAppsAndLog.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// tableLayoutPanelDevice
			//
			this.tableLayoutPanelDevice.AutoSize = true;
			this.tableLayoutPanelDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelDevice.ColumnCount = 2;
			this.tableLayoutPanelDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelDevice.Controls.Add(this.buttonRefreshDevices, 1, 0);
			this.tableLayoutPanelDevice.Controls.Add(this.comboBoxDevice, 0, 0);
			this.tableLayoutPanelDevice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelDevice.Location = new System.Drawing.Point(3, 15);
			this.tableLayoutPanelDevice.Name = "tableLayoutPanelDevice";
			this.tableLayoutPanelDevice.RowCount = 1;
			this.tableLayoutPanelDevice.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelDevice.Size = new System.Drawing.Size(420, 28);
			this.tableLayoutPanelDevice.TabIndex = 0;
			//
			// buttonRefreshDevices
			//
			this.buttonRefreshDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonRefreshDevices.AutoSize = true;
			this.buttonRefreshDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonRefreshDevices.Location = new System.Drawing.Point(362, 3);
			this.buttonRefreshDevices.Name = "buttonRefreshDevices";
			this.buttonRefreshDevices.Size = new System.Drawing.Size(55, 22);
			this.buttonRefreshDevices.TabIndex = 1;
			this.buttonRefreshDevices.Text = "Refresh";
			this.buttonRefreshDevices.UseVisualStyleBackColor = true;
			this.buttonRefreshDevices.Click += new System.EventHandler(buttonRefreshDevices_Click);
			//
			// comboBoxDevice
			//
			this.comboBoxDevice.FormattingEnabled = true;
			this.comboBoxDevice.Location = new System.Drawing.Point(3, 3);
			this.comboBoxDevice.Name = "comboBoxDevice";
			this.comboBoxDevice.Size = new System.Drawing.Size(353, 20);
			this.comboBoxDevice.TabIndex = 0;
			this.comboBoxDevice.SelectionChangeCommitted += new System.EventHandler(comboBoxDevice_SelectionChangeCommittedOrLeave);
			this.comboBoxDevice.Leave += new System.EventHandler(comboBoxDevice_SelectionChangeCommittedOrLeave);
			this.comboBoxDevice.GotFocus += new System.EventHandler(comboBoxDevice_GotFocus);
			//
			// groupBoxDevice
			//
			this.groupBoxDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxDevice.Controls.Add(this.tableLayoutPanelDevice);
			this.groupBoxDevice.Location = new System.Drawing.Point(12, 27);
			this.groupBoxDevice.Name = "groupBoxDevice";
			this.groupBoxDevice.Size = new System.Drawing.Size(426, 46);
			this.groupBoxDevice.TabIndex = 1;
			this.groupBoxDevice.TabStop = false;
			this.groupBoxDevice.Text = "Device";
			//
			// groupBoxApplications
			//
			this.groupBoxApplications.Controls.Add(this.tableLayoutPanelApplications);
			this.groupBoxApplications.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxApplications.Location = new System.Drawing.Point(0, 0);
			this.groupBoxApplications.Name = "groupBoxApplications";
			this.groupBoxApplications.Size = new System.Drawing.Size(426, 238);
			this.groupBoxApplications.TabIndex = 0;
			this.groupBoxApplications.TabStop = false;
			this.groupBoxApplications.Text = "Applications";
			//
			// tableLayoutPanelApplications
			//
			this.tableLayoutPanelApplications.ColumnCount = 1;
			this.tableLayoutPanelApplications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelApplications.Controls.Add(this.tableLayoutPanelAppActions, 0, 0);
			this.tableLayoutPanelApplications.Controls.Add(this.checkedListBoxApplications, 0, 1);
			this.tableLayoutPanelApplications.Controls.Add(this.tableLayoutPanelAppListActions, 0, 2);
			this.tableLayoutPanelApplications.Controls.Add(this.buttonExecuteAppActions, 0, 3);
			this.tableLayoutPanelApplications.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelApplications.Location = new System.Drawing.Point(3, 15);
			this.tableLayoutPanelApplications.Name = "tableLayoutPanelApplications";
			this.tableLayoutPanelApplications.RowCount = 4;
			this.tableLayoutPanelApplications.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelApplications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelApplications.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelApplications.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelApplications.Size = new System.Drawing.Size(420, 220);
			this.tableLayoutPanelApplications.TabIndex = 2;
			//
			// tableLayoutPanelAppActions
			//
			this.tableLayoutPanelAppActions.AutoSize = true;
			this.tableLayoutPanelAppActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelAppActions.ColumnCount = 6;
			this.tableLayoutPanelAppActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelAppActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppActions.Controls.Add(this.labelAppActions, 0, 0);
			this.tableLayoutPanelAppActions.Controls.Add(this.radioButtonAppActUninstall, 1, 0);
			this.tableLayoutPanelAppActions.Controls.Add(this.radioButtonAppActDisable, 2, 0);
			this.tableLayoutPanelAppActions.Controls.Add(this.radioButtonAppActRestore, 3, 0);
			this.tableLayoutPanelAppActions.Controls.Add(this.buttonRefreshApplications, 5, 0);
			this.tableLayoutPanelAppActions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelAppActions.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelAppActions.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelAppActions.Name = "tableLayoutPanelAppActions";
			this.tableLayoutPanelAppActions.RowCount = 1;
			this.tableLayoutPanelAppActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAppActions.Size = new System.Drawing.Size(420, 28);
			this.tableLayoutPanelAppActions.TabIndex = 0;
			//
			// labelAppActions
			//
			this.labelAppActions.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelAppActions.AutoSize = true;
			this.labelAppActions.Location = new System.Drawing.Point(3, 8);
			this.labelAppActions.Name = "labelAppActions";
			this.labelAppActions.Size = new System.Drawing.Size(40, 12);
			this.labelAppActions.TabIndex = 4;
			this.labelAppActions.Text = "Action:";
			//
			// radioButtonAppActUninstall
			//
			this.radioButtonAppActUninstall.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radioButtonAppActUninstall.AutoSize = true;
			this.radioButtonAppActUninstall.Location = new System.Drawing.Point(49, 6);
			this.radioButtonAppActUninstall.Name = "radioButtonAppActUninstall";
			this.radioButtonAppActUninstall.Size = new System.Drawing.Size(68, 16);
			this.radioButtonAppActUninstall.TabIndex = 0;
			this.radioButtonAppActUninstall.TabStop = true;
			this.radioButtonAppActUninstall.Text = "Uninstall";
			this.radioButtonAppActUninstall.UseVisualStyleBackColor = true;
			this.radioButtonAppActUninstall.CheckedChanged += new System.EventHandler(UpdateExecuteButton);
			//
			// radioButtonAppActDisable
			//
			this.radioButtonAppActDisable.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radioButtonAppActDisable.AutoSize = true;
			this.radioButtonAppActDisable.Location = new System.Drawing.Point(123, 6);
			this.radioButtonAppActDisable.Name = "radioButtonAppActDisable";
			this.radioButtonAppActDisable.Size = new System.Drawing.Size(61, 16);
			this.radioButtonAppActDisable.TabIndex = 1;
			this.radioButtonAppActDisable.TabStop = true;
			this.radioButtonAppActDisable.Text = "Disable";
			this.radioButtonAppActDisable.UseVisualStyleBackColor = true;
			this.radioButtonAppActDisable.CheckedChanged += new System.EventHandler(UpdateExecuteButton);
			//
			// radioButtonAppActRestore
			//
			this.radioButtonAppActRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radioButtonAppActRestore.AutoSize = true;
			this.radioButtonAppActRestore.Location = new System.Drawing.Point(190, 6);
			this.radioButtonAppActRestore.Name = "radioButtonAppActRestore";
			this.radioButtonAppActRestore.Size = new System.Drawing.Size(63, 16);
			this.radioButtonAppActRestore.TabIndex = 2;
			this.radioButtonAppActRestore.TabStop = true;
			this.radioButtonAppActRestore.Text = "Restore";
			this.radioButtonAppActRestore.UseVisualStyleBackColor = true;
			this.radioButtonAppActRestore.CheckedChanged += new System.EventHandler(UpdateExecuteButton);
			this.radioButtonAppActRestore.Visible = false;
			//
			// buttonRefreshApplications
			//
			this.buttonRefreshApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonRefreshApplications.AutoSize = true;
			this.buttonRefreshApplications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonRefreshApplications.Location = new System.Drawing.Point(362, 3);
			this.buttonRefreshApplications.Name = "buttonRefreshApplications";
			this.buttonRefreshApplications.Size = new System.Drawing.Size(55, 22);
			this.buttonRefreshApplications.TabIndex = 3;
			this.buttonRefreshApplications.Text = "Refresh";
			this.buttonRefreshApplications.UseVisualStyleBackColor = true;
			this.buttonRefreshApplications.Click += new System.EventHandler(buttonRefreshApplications_Click);
			//
			// checkedListBoxApplications
			//
			this.checkedListBoxApplications.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxApplications.FormattingEnabled = true;
			this.checkedListBoxApplications.Location = new System.Drawing.Point(3, 28);
			this.checkedListBoxApplications.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.checkedListBoxApplications.Name = "checkedListBoxApplications";
			this.checkedListBoxApplications.ScrollAlwaysVisible = true;
			this.checkedListBoxApplications.Size = new System.Drawing.Size(414, 139);
			this.checkedListBoxApplications.TabIndex = 1;
			//
			// tableLayoutPanelAppListActions
			//
			this.tableLayoutPanelAppListActions.AutoSize = true;
			this.tableLayoutPanelAppListActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelAppListActions.ColumnCount = 4;
			this.tableLayoutPanelAppListActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppListActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppListActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppListActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAppListActions.Controls.Add(this.buttonSelectAllApps, 0, 0);
			this.tableLayoutPanelAppListActions.Controls.Add(this.buttonDeselectAllApps, 0, 0);
			this.tableLayoutPanelAppListActions.Controls.Add(this.buttonExclDisasterApps, 0, 0);
			this.tableLayoutPanelAppListActions.Controls.Add(this.buttonExclWiFiApps, 0, 0);
			this.tableLayoutPanelAppListActions.Location = new System.Drawing.Point(0, 170);
			this.tableLayoutPanelAppListActions.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelAppListActions.Name = "tableLayoutPanelAppListActions";
			this.tableLayoutPanelAppListActions.RowCount = 1;
			this.tableLayoutPanelAppListActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAppListActions.Size = new System.Drawing.Size(400, 25);
			this.tableLayoutPanelAppListActions.TabIndex = 1;
			//
			// buttonSelectAllApps
			//
			this.buttonSelectAllApps.AutoSize = true;
			this.buttonSelectAllApps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonSelectAllApps.Location = new System.Drawing.Point(255, 0);
			this.buttonSelectAllApps.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.buttonSelectAllApps.Name = "buttonSelectAllApps";
			this.buttonSelectAllApps.Size = new System.Drawing.Size(63, 22);
			this.buttonSelectAllApps.TabIndex = 2;
			this.buttonSelectAllApps.Text = "Select all";
			this.buttonSelectAllApps.UseVisualStyleBackColor = true;
			this.buttonSelectAllApps.Click += new System.EventHandler(buttonSelectAllApps_Click);
			//
			// buttonDeselectAllApps
			//
			this.buttonDeselectAllApps.AutoSize = true;
			this.buttonDeselectAllApps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonDeselectAllApps.Location = new System.Drawing.Point(321, 0);
			this.buttonDeselectAllApps.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.buttonDeselectAllApps.Name = "buttonDeselectAllApps";
			this.buttonDeselectAllApps.Size = new System.Drawing.Size(76, 22);
			this.buttonDeselectAllApps.TabIndex = 3;
			this.buttonDeselectAllApps.Text = "Deselect all";
			this.buttonDeselectAllApps.UseVisualStyleBackColor = true;
			this.buttonDeselectAllApps.Click += new System.EventHandler(buttonDeselectAllApps_Click);
			//
			// buttonExclDisasterApps
			//
			this.buttonExclDisasterApps.AutoSize = true;
			this.buttonExclDisasterApps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonExclDisasterApps.Location = new System.Drawing.Point(3, 0);
			this.buttonExclDisasterApps.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.buttonExclDisasterApps.Name = "buttonExclDisasterApps";
			this.buttonExclDisasterApps.Size = new System.Drawing.Size(128, 22);
			this.buttonExclDisasterApps.TabIndex = 0;
			this.buttonExclDisasterApps.Text = "Exclude disaster apps";
			this.buttonExclDisasterApps.UseVisualStyleBackColor = true;
			this.buttonExclDisasterApps.Click += new System.EventHandler(buttonExclDisasterApps_Click);
			//
			// buttonExclWiFiApps
			//
			this.buttonExclWiFiApps.AutoSize = true;
			this.buttonExclWiFiApps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonExclWiFiApps.Location = new System.Drawing.Point(134, 0);
			this.buttonExclWiFiApps.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.buttonExclWiFiApps.Name = "buttonExclWiFiApps";
			this.buttonExclWiFiApps.Size = new System.Drawing.Size(115, 22);
			this.buttonExclWiFiApps.TabIndex = 1;
			this.buttonExclWiFiApps.Text = "Exclude Wi-Fi apps";
			this.buttonExclWiFiApps.UseVisualStyleBackColor = true;
			this.buttonExclWiFiApps.Click += new System.EventHandler(buttonExclWiFiApps_Click);
			//
			// buttonExecuteAppActions
			//
			this.buttonExecuteAppActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExecuteAppActions.AutoSize = true;
			this.buttonExecuteAppActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonExecuteAppActions.Enabled = false;
			this.buttonExecuteAppActions.Location = new System.Drawing.Point(361, 195);
			this.buttonExecuteAppActions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.buttonExecuteAppActions.Name = "buttonExecuteAppActions";
			this.buttonExecuteAppActions.Size = new System.Drawing.Size(56, 22);
			this.buttonExecuteAppActions.TabIndex = 2;
			this.buttonExecuteAppActions.Text = "Execute";
			this.buttonExecuteAppActions.UseVisualStyleBackColor = true;
			this.buttonExecuteAppActions.Click += new System.EventHandler(buttonExecuteAppActions_Click);
			//
			// groupBoxLog
			//
			this.groupBoxLog.Controls.Add(this.textBoxLog);
			this.groupBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxLog.Location = new System.Drawing.Point(0, 0);
			this.groupBoxLog.Name = "groupBoxLog";
			this.groupBoxLog.Size = new System.Drawing.Size(426, 95);
			this.groupBoxLog.TabIndex = 0;
			this.groupBoxLog.TabStop = false;
			this.groupBoxLog.Text = "Log";
			//
			// textBoxLog
			//
			this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLog.Location = new System.Drawing.Point(3, 15);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxLog.Size = new System.Drawing.Size(420, 77);
			this.textBoxLog.TabIndex = 0;
			this.textBoxLog.MaxLength = 0;
			//
			// statusStrip
			//
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripProgressBar,
			this.toolStripStatusLabelStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 419);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(450, 23);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			//
			// toolStripProgressBar
			//
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 17);
			//
			// toolStripStatusLabelStatus
			//
			this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
			this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(44, 18);
			this.toolStripStatusLabelStatus.Text = "Ready";
			//
			// splitContainerAppsAndLog
			//
			this.splitContainerAppsAndLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainerAppsAndLog.Location = new System.Drawing.Point(12, 79);
			this.splitContainerAppsAndLog.Name = "splitContainerAppsAndLog";
			this.splitContainerAppsAndLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			// splitContainerAppsAndLog.Panel1
			//
			this.splitContainerAppsAndLog.Panel1.Controls.Add(this.groupBoxApplications);
			//
			// splitContainerAppsAndLog.Panel2
			//
			this.splitContainerAppsAndLog.Panel2.Controls.Add(this.groupBoxLog);
			this.splitContainerAppsAndLog.Size = new System.Drawing.Size(426, 337);
			this.splitContainerAppsAndLog.SplitterDistance = 238;
			this.splitContainerAppsAndLog.TabIndex = 5;
			//
			// menuStrip
			//
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(450, 26);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			//
			// fileToolStripMenuItem
			//
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.settingsToolStripMenuItem,
			this.toolStripSeparator1,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
			this.fileToolStripMenuItem.Text = "&File";
			//
			// exitToolStripMenuItem
			//
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			//
			// helpToolStripMenuItem
			//
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
			this.helpToolStripMenuItem.Text = "&Help";
			//
			// aboutToolStripMenuItem
			//
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			//
			// settingsToolStripMenuItem
			//
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			//
			// FormCarrierAppDeleter
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 442);
			this.Controls.Add(this.splitContainerAppsAndLog);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.groupBoxDevice);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormCarrierAppDeleter";
			this.Text = "CarrierAppDeleter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanelDevice.ResumeLayout(false);
			this.tableLayoutPanelDevice.PerformLayout();
			this.groupBoxDevice.ResumeLayout(false);
			this.groupBoxDevice.PerformLayout();
			this.groupBoxApplications.ResumeLayout(false);
			this.tableLayoutPanelApplications.ResumeLayout(false);
			this.tableLayoutPanelApplications.PerformLayout();
			this.tableLayoutPanelAppActions.ResumeLayout(false);
			this.tableLayoutPanelAppActions.PerformLayout();
			this.tableLayoutPanelAppListActions.ResumeLayout(false);
			this.tableLayoutPanelAppListActions.PerformLayout();
			this.groupBoxLog.ResumeLayout(false);
			this.groupBoxLog.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.splitContainerAppsAndLog.Panel1.ResumeLayout(false);
			this.splitContainerAppsAndLog.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerAppsAndLog)).EndInit();
			this.splitContainerAppsAndLog.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDevice;
		private System.Windows.Forms.ComboBox comboBoxDevice;
		private System.Windows.Forms.Button buttonRefreshDevices;
		private System.Windows.Forms.GroupBox groupBoxDevice;
		private System.Windows.Forms.GroupBox groupBoxApplications;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelApplications;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAppActions;
		private System.Windows.Forms.Label labelAppActions;
		private System.Windows.Forms.RadioButton radioButtonAppActUninstall;
		private System.Windows.Forms.Button buttonRefreshApplications;
		private System.Windows.Forms.RadioButton radioButtonAppActRestore;
		private System.Windows.Forms.RadioButton radioButtonAppActDisable;
		private System.Windows.Forms.CheckedListBox checkedListBoxApplications;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAppListActions;
		private System.Windows.Forms.Button buttonExclWiFiApps;
		private System.Windows.Forms.Button buttonSelectAllApps;
		private System.Windows.Forms.Button buttonDeselectAllApps;
		private System.Windows.Forms.Button buttonExclDisasterApps;
		private System.Windows.Forms.GroupBox groupBoxLog;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.SplitContainer splitContainerAppsAndLog;
		private System.Windows.Forms.Button buttonExecuteAppActions;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}
