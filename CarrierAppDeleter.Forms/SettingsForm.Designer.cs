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
			this.checkBoxAutoDetectAdb = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelAdbPath = new System.Windows.Forms.TableLayoutPanel();
			this.labelAdbPath = new System.Windows.Forms.Label();
			this.textBoxAdbPath = new System.Windows.Forms.TextBox();
			this.buttonChooseAdb = new System.Windows.Forms.Button();
			this.buttonSetupAdb = new System.Windows.Forms.Button();
			this.textBoxUsingThisAdb = new System.Windows.Forms.TextBox();
			this.flowLayoutPanelOkCancel = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxAdb.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanelAdbPath.SuspendLayout();
			this.flowLayoutPanelOkCancel.SuspendLayout();
			this.SuspendLayout();
			//
			// groupBoxAdb
			//
			this.groupBoxAdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAdb.Controls.Add(this.tableLayoutPanel1);
			this.groupBoxAdb.Location = new System.Drawing.Point(12, 12);
			this.groupBoxAdb.Name = "groupBoxAdb";
			this.groupBoxAdb.Size = new System.Drawing.Size(260, 117);
			this.groupBoxAdb.TabIndex = 0;
			this.groupBoxAdb.TabStop = false;
			this.groupBoxAdb.Text = "ADB";
			//
			// checkBoxAutoDetectAdb
			//
			this.checkBoxAutoDetectAdb.AutoSize = true;
			this.checkBoxAutoDetectAdb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxAutoDetectAdb.Location = new System.Drawing.Point(3, 3);
			this.checkBoxAutoDetectAdb.Name = "checkBoxAutoDetectAdb";
			this.checkBoxAutoDetectAdb.Size = new System.Drawing.Size(248, 16);
			this.checkBoxAutoDetectAdb.TabIndex = 0;
			this.checkBoxAutoDetectAdb.Text = "Auto detect";
			this.checkBoxAutoDetectAdb.UseVisualStyleBackColor = true;
			this.checkBoxAutoDetectAdb.CheckedChanged += new System.EventHandler(this.UpdateControls);
			//
			// tableLayoutPanel1
			//
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoDetectAdb, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelAdbPath, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonSetupAdb, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxUsingThisAdb, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 15);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 99);
			this.tableLayoutPanel1.TabIndex = 0;
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
			this.tableLayoutPanelAdbPath.Size = new System.Drawing.Size(254, 28);
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
			this.textBoxAdbPath.Name = "textBoxAdbPath";
			this.textBoxAdbPath.Size = new System.Drawing.Size(161, 19);
			this.textBoxAdbPath.TabIndex = 1;
			this.textBoxAdbPath.TextChanged += new System.EventHandler(this.UpdateControls);
			//
			// buttonChooseAdb
			//
			this.buttonChooseAdb.AutoSize = true;
			this.buttonChooseAdb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonChooseAdb.Location = new System.Drawing.Point(230, 3);
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
			this.buttonSetupAdb.Size = new System.Drawing.Size(248, 23);
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
			this.textBoxUsingThisAdb.Name = "textBoxUsingThisAdb";
			this.textBoxUsingThisAdb.ReadOnly = true;
			this.textBoxUsingThisAdb.Size = new System.Drawing.Size(248, 12);
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
			this.flowLayoutPanelOkCancel.Location = new System.Drawing.Point(119, 146);
			this.flowLayoutPanelOkCancel.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanelOkCancel.Name = "flowLayoutPanelOkCancel";
			this.flowLayoutPanelOkCancel.Size = new System.Drawing.Size(156, 23);
			this.flowLayoutPanelOkCancel.TabIndex = 1;
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
			// SettingsForm
			//
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(284, 178);
			this.Controls.Add(this.flowLayoutPanelOkCancel);
			this.Controls.Add(this.groupBoxAdb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBoxAdb.ResumeLayout(false);
			this.groupBoxAdb.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanelAdbPath.ResumeLayout(false);
			this.tableLayoutPanelAdbPath.PerformLayout();
			this.flowLayoutPanelOkCancel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxAdb;
		private System.Windows.Forms.CheckBox checkBoxAutoDetectAdb;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdbPath;
		private System.Windows.Forms.Label labelAdbPath;
		private System.Windows.Forms.TextBox textBoxAdbPath;
		private System.Windows.Forms.Button buttonChooseAdb;
		private System.Windows.Forms.Button buttonSetupAdb;
		private System.Windows.Forms.TextBox textBoxUsingThisAdb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOkCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}
