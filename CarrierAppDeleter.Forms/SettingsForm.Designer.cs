namespace CarrierAppDeleter.Forms {
	partial class SettingsForm {
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
			this.groupBoxAdb = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelAdb = new System.Windows.Forms.TableLayoutPanel();
			this.checkBoxAutoDetectAdb = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanelAdbPath = new System.Windows.Forms.TableLayoutPanel();
			this.labelAdbPath = new System.Windows.Forms.Label();
			this.textBoxAdbPath = new System.Windows.Forms.TextBox();
			this.buttonChooseAdb = new System.Windows.Forms.Button();
			this.buttonSetupAdb = new System.Windows.Forms.Button();
			this.textBoxUsingThisAdb = new System.Windows.Forms.TextBox();
			this.flowLayoutPanelOkCancel = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.groupBoxRegex = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelRegex = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelRegexLine1 = new System.Windows.Forms.TableLayoutPanel();
			this.checkBoxECMARegex = new System.Windows.Forms.CheckBox();
			this.buttonResetRegex = new System.Windows.Forms.Button();
			this.tableLayoutPanelRegexInput = new System.Windows.Forms.TableLayoutPanel();
			this.labelRegex = new System.Windows.Forms.Label();
			this.textBoxRegex = new System.Windows.Forms.TextBox();
			this.textBoxRegexChecker = new System.Windows.Forms.TextBox();
			this.groupBoxAdb.SuspendLayout();
			this.tableLayoutPanelAdb.SuspendLayout();
			this.tableLayoutPanelAdbPath.SuspendLayout();
			this.flowLayoutPanelOkCancel.SuspendLayout();
			this.groupBoxRegex.SuspendLayout();
			this.tableLayoutPanelRegex.SuspendLayout();
			this.tableLayoutPanelRegexLine1.SuspendLayout();
			this.tableLayoutPanelRegexInput.SuspendLayout();
			this.SuspendLayout();
			//
			// groupBoxAdb
			//
			this.groupBoxAdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAdb.Controls.Add(this.tableLayoutPanelAdb);
			this.groupBoxAdb.Location = new System.Drawing.Point(12, 12);
			this.groupBoxAdb.Name = "groupBoxAdb";
			this.groupBoxAdb.Size = new System.Drawing.Size(340, 117);
			this.groupBoxAdb.TabIndex = 0;
			this.groupBoxAdb.TabStop = false;
			this.groupBoxAdb.Text = "ADB";
			//
			// tableLayoutPanelAdb
			//
			this.tableLayoutPanelAdb.AutoSize = true;
			this.tableLayoutPanelAdb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelAdb.ColumnCount = 1;
			this.tableLayoutPanelAdb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAdb.Controls.Add(this.checkBoxAutoDetectAdb, 0, 0);
			this.tableLayoutPanelAdb.Controls.Add(this.tableLayoutPanelAdbPath, 0, 1);
			this.tableLayoutPanelAdb.Controls.Add(this.buttonSetupAdb, 0, 2);
			this.tableLayoutPanelAdb.Controls.Add(this.textBoxUsingThisAdb, 0, 3);
			this.tableLayoutPanelAdb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelAdb.Location = new System.Drawing.Point(3, 15);
			this.tableLayoutPanelAdb.Name = "tableLayoutPanelAdb";
			this.tableLayoutPanelAdb.RowCount = 4;
			this.tableLayoutPanelAdb.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAdb.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAdb.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAdb.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAdb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelAdb.Size = new System.Drawing.Size(334, 99);
			this.tableLayoutPanelAdb.TabIndex = 0;
			//
			// checkBoxAutoDetectAdb
			//
			this.checkBoxAutoDetectAdb.AutoSize = true;
			this.checkBoxAutoDetectAdb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxAutoDetectAdb.Location = new System.Drawing.Point(3, 3);
			this.checkBoxAutoDetectAdb.Name = "checkBoxAutoDetectAdb";
			this.checkBoxAutoDetectAdb.Size = new System.Drawing.Size(328, 16);
			this.checkBoxAutoDetectAdb.TabIndex = 0;
			this.checkBoxAutoDetectAdb.Text = "Auto detect";
			this.checkBoxAutoDetectAdb.UseVisualStyleBackColor = true;
			this.checkBoxAutoDetectAdb.CheckedChanged += new System.EventHandler(this.UpdateControls);
			//
			// tableLayoutPanelAdbPath
			//
			this.tableLayoutPanelAdbPath.AutoSize = true;
			this.tableLayoutPanelAdbPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelAdbPath.ColumnCount = 3;
			this.tableLayoutPanelAdbPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAdbPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelAdbPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelAdbPath.Controls.Add(this.labelAdbPath, 0, 0);
			this.tableLayoutPanelAdbPath.Controls.Add(this.textBoxAdbPath, 1, 0);
			this.tableLayoutPanelAdbPath.Controls.Add(this.buttonChooseAdb, 2, 0);
			this.tableLayoutPanelAdbPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelAdbPath.Location = new System.Drawing.Point(0, 22);
			this.tableLayoutPanelAdbPath.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelAdbPath.Name = "tableLayoutPanelAdbPath";
			this.tableLayoutPanelAdbPath.RowCount = 1;
			this.tableLayoutPanelAdbPath.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelAdbPath.Size = new System.Drawing.Size(334, 28);
			this.tableLayoutPanelAdbPath.TabIndex = 1;
			//
			// labelAdbPath
			//
			this.labelAdbPath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelAdbPath.AutoSize = true;
			this.labelAdbPath.Location = new System.Drawing.Point(3, 8);
			this.labelAdbPath.Name = "labelAdbPath";
			this.labelAdbPath.Size = new System.Drawing.Size(57, 12);
			this.labelAdbPath.TabIndex = 0;
			this.labelAdbPath.Text = "ADB path:";
			//
			// textBoxAdbPath
			//
			this.textBoxAdbPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxAdbPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxAdbPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAdbPath.Location = new System.Drawing.Point(66, 3);
			this.textBoxAdbPath.MaxLength = 0;
			this.textBoxAdbPath.Name = "textBoxAdbPath";
			this.textBoxAdbPath.Size = new System.Drawing.Size(241, 19);
			this.textBoxAdbPath.TabIndex = 1;
			this.textBoxAdbPath.TextChanged += new System.EventHandler(this.UpdateControls);
			//
			// buttonChooseAdb
			//
			this.buttonChooseAdb.AutoSize = true;
			this.buttonChooseAdb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonChooseAdb.Location = new System.Drawing.Point(310, 3);
			this.buttonChooseAdb.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.buttonChooseAdb.Name = "buttonChooseAdb";
			this.buttonChooseAdb.Size = new System.Drawing.Size(21, 22);
			this.buttonChooseAdb.TabIndex = 2;
			this.buttonChooseAdb.Text = "...";
			this.buttonChooseAdb.UseVisualStyleBackColor = true;
			this.buttonChooseAdb.Click += new System.EventHandler(this.buttonChooseAdb_Click);
			//
			// buttonSetupAdb
			//
			this.buttonSetupAdb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSetupAdb.Location = new System.Drawing.Point(3, 53);
			this.buttonSetupAdb.Name = "buttonSetupAdb";
			this.buttonSetupAdb.Size = new System.Drawing.Size(328, 23);
			this.buttonSetupAdb.TabIndex = 2;
			this.buttonSetupAdb.Text = "Setup ADB";
			this.buttonSetupAdb.UseVisualStyleBackColor = true;
			this.buttonSetupAdb.Click += new System.EventHandler(this.buttonSetupAdb_Click);
			//
			// textBoxUsingThisAdb
			//
			this.textBoxUsingThisAdb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxUsingThisAdb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxUsingThisAdb.Location = new System.Drawing.Point(3, 82);
			this.textBoxUsingThisAdb.MaxLength = 0;
			this.textBoxUsingThisAdb.Name = "textBoxUsingThisAdb";
			this.textBoxUsingThisAdb.ReadOnly = true;
			this.textBoxUsingThisAdb.Size = new System.Drawing.Size(328, 12);
			this.textBoxUsingThisAdb.TabIndex = 3;
			this.textBoxUsingThisAdb.Text = "\"Using: /path/to/adb\" or \"Not detected\"";
			//
			// flowLayoutPanelOkCancel
			//
			this.flowLayoutPanelOkCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanelOkCancel.AutoSize = true;
			this.flowLayoutPanelOkCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanelOkCancel.Controls.Add(this.buttonCancel);
			this.flowLayoutPanelOkCancel.Controls.Add(this.buttonOk);
			this.flowLayoutPanelOkCancel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanelOkCancel.Location = new System.Drawing.Point(199, 256);
			this.flowLayoutPanelOkCancel.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanelOkCancel.Name = "flowLayoutPanelOkCancel";
			this.flowLayoutPanelOkCancel.Size = new System.Drawing.Size(156, 23);
			this.flowLayoutPanelOkCancel.TabIndex = 2;
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(81, 0);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			//
			// buttonOk
			//
			this.buttonOk.Location = new System.Drawing.Point(3, 0);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "&OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			//
			// groupBoxRegex
			//
			this.groupBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            	| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxRegex.Controls.Add(this.tableLayoutPanelRegex);
			this.groupBoxRegex.Location = new System.Drawing.Point(12, 135);
			this.groupBoxRegex.Name = "groupBoxRegex";
			this.groupBoxRegex.Size = new System.Drawing.Size(340, 117);
			this.groupBoxRegex.TabIndex = 1;
			this.groupBoxRegex.TabStop = false;
			this.groupBoxRegex.Text = "Regex";
			//
			// tableLayoutPanelRegex
			//
			this.tableLayoutPanelRegex.AutoSize = true;
			this.tableLayoutPanelRegex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelRegex.ColumnCount = 1;
			this.tableLayoutPanelRegex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelRegex.Controls.Add(this.tableLayoutPanelRegexLine1, 0, 0);
			this.tableLayoutPanelRegex.Controls.Add(this.tableLayoutPanelRegexInput, 0, 1);
			this.tableLayoutPanelRegex.Controls.Add(this.textBoxRegexChecker, 0, 2);
			this.tableLayoutPanelRegex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelRegex.Location = new System.Drawing.Point(3, 15);
			this.tableLayoutPanelRegex.Name = "tableLayoutPanelRegex";
			this.tableLayoutPanelRegex.RowCount = 3;
			this.tableLayoutPanelRegex.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelRegex.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelRegex.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelRegex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelRegex.Size = new System.Drawing.Size(334, 99);
			this.tableLayoutPanelRegex.TabIndex = 0;
			//
			// tableLayoutPanelRegexLine1
			//
			this.tableLayoutPanelRegexLine1.AutoSize = true;
			this.tableLayoutPanelRegexLine1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelRegexLine1.ColumnCount = 2;
			this.tableLayoutPanelRegexLine1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelRegexLine1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelRegexLine1.Controls.Add(this.checkBoxECMARegex, 0, 0);
			this.tableLayoutPanelRegexLine1.Controls.Add(this.buttonResetRegex, 1, 0);
			this.tableLayoutPanelRegexLine1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelRegexLine1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelRegexLine1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelRegexLine1.Name = "tableLayoutPanelRegexLine1";
			this.tableLayoutPanelRegexLine1.RowCount = 1;
			this.tableLayoutPanelRegexLine1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelRegexLine1.Size = new System.Drawing.Size(334, 22);
			this.tableLayoutPanelRegexLine1.TabIndex = 0;
			//
			// checkBoxECMARegex
			//
			this.checkBoxECMARegex.AutoSize = true;
			this.checkBoxECMARegex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxECMARegex.Location = new System.Drawing.Point(3, 3);
			this.checkBoxECMARegex.Name = "checkBoxECMARegex";
			this.checkBoxECMARegex.Size = new System.Drawing.Size(280, 16);
			this.checkBoxECMARegex.TabIndex = 0;
			this.checkBoxECMARegex.Text = "ECMAScript";
			this.checkBoxECMARegex.UseVisualStyleBackColor = true;
			this.checkBoxECMARegex.TextChanged += new System.EventHandler(this.CheckRegex);
			//
			// buttonResetRegex
			//
			this.buttonResetRegex.AutoSize = true;
			this.buttonResetRegex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonResetRegex.Location = new System.Drawing.Point(286, 0);
			this.buttonResetRegex.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.buttonResetRegex.Name = "buttonResetRegex";
			this.buttonResetRegex.Size = new System.Drawing.Size(45, 22);
			this.buttonResetRegex.TabIndex = 1;
			this.buttonResetRegex.Text = "Reset";
			this.buttonResetRegex.UseVisualStyleBackColor = true;
			this.buttonResetRegex.Click += new System.EventHandler(this.buttonResetRegex_Click);
			//
			// tableLayoutPanelRegexInput
			//
			this.tableLayoutPanelRegexInput.AutoSize = true;
			this.tableLayoutPanelRegexInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelRegexInput.ColumnCount = 2;
			this.tableLayoutPanelRegexInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelRegexInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelRegexInput.Controls.Add(this.labelRegex, 0, 0);
			this.tableLayoutPanelRegexInput.Controls.Add(this.textBoxRegex, 1, 0);
			this.tableLayoutPanelRegexInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelRegexInput.Location = new System.Drawing.Point(0, 22);
			this.tableLayoutPanelRegexInput.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelRegexInput.Name = "tableLayoutPanelRegexInput";
			this.tableLayoutPanelRegexInput.RowCount = 1;
			this.tableLayoutPanelRegexInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelRegexInput.Size = new System.Drawing.Size(334, 25);
			this.tableLayoutPanelRegexInput.TabIndex = 1;
			//
			// labelRegex
			//
			this.labelRegex.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelRegex.AutoSize = true;
			this.labelRegex.Location = new System.Drawing.Point(3, 6);
			this.labelRegex.Name = "labelRegex";
			this.labelRegex.Size = new System.Drawing.Size(139, 12);
			this.labelRegex.TabIndex = 0;
			this.labelRegex.Text = "Pattern for package name:";
			//
			// textBoxRegex
			//
			this.textBoxRegex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxRegex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxRegex.Location = new System.Drawing.Point(148, 3);
			this.textBoxRegex.MaxLength = 0;
			this.textBoxRegex.Name = "textBoxRegex";
			this.textBoxRegex.Size = new System.Drawing.Size(82, 19);
			this.textBoxRegex.TabIndex = 1;
			this.textBoxRegex.TextChanged += new System.EventHandler(this.CheckRegex);
			//
			// textBoxRegexChecker
			//
			this.textBoxRegexChecker.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxRegexChecker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxRegexChecker.Location = new System.Drawing.Point(3, 50);
			this.textBoxRegexChecker.MaxLength = 0;
			this.textBoxRegexChecker.Multiline = true;
			this.textBoxRegexChecker.Name = "textBoxRegexChecker";
			this.textBoxRegexChecker.ReadOnly = true;
			this.textBoxRegexChecker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxRegexChecker.Size = new System.Drawing.Size(328, 46);
			this.textBoxRegexChecker.TabIndex = 2;
			this.textBoxRegexChecker.Text = "\"Vaild\" or \"Invalid\"";
			//
			// SettingsForm
			//
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(364, 288);
			this.Controls.Add(this.groupBoxAdb);
			this.Controls.Add(this.groupBoxRegex);
			this.Controls.Add(this.flowLayoutPanelOkCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBoxAdb.ResumeLayout(false);
			this.groupBoxAdb.PerformLayout();
			this.tableLayoutPanelAdb.ResumeLayout(false);
			this.tableLayoutPanelAdb.PerformLayout();
			this.tableLayoutPanelAdbPath.ResumeLayout(false);
			this.tableLayoutPanelAdbPath.PerformLayout();
			this.flowLayoutPanelOkCancel.ResumeLayout(false);
			this.groupBoxRegex.ResumeLayout(false);
			this.groupBoxRegex.PerformLayout();
			this.tableLayoutPanelRegex.ResumeLayout(false);
			this.tableLayoutPanelRegex.PerformLayout();
			this.tableLayoutPanelRegexLine1.ResumeLayout(false);
			this.tableLayoutPanelRegexLine1.PerformLayout();
			this.tableLayoutPanelRegexInput.ResumeLayout(false);
			this.tableLayoutPanelRegexInput.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxAdb;
		private System.Windows.Forms.CheckBox checkBoxAutoDetectAdb;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdb;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdbPath;
		private System.Windows.Forms.Label labelAdbPath;
		private System.Windows.Forms.TextBox textBoxAdbPath;
		private System.Windows.Forms.Button buttonChooseAdb;
		private System.Windows.Forms.Button buttonSetupAdb;
		private System.Windows.Forms.TextBox textBoxUsingThisAdb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOkCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.GroupBox groupBoxRegex;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegex;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegexInput;
		private System.Windows.Forms.Label labelRegex;
		private System.Windows.Forms.TextBox textBoxRegex;
		private System.Windows.Forms.Button buttonResetRegex;
		private System.Windows.Forms.TextBox textBoxRegexChecker;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegexLine1;
		private System.Windows.Forms.CheckBox checkBoxECMARegex;
	}
}
