using System;
using System.Windows.Forms;
using System.IO;

namespace CarrierAppDeleter.Forms {
	public partial class SettingsForm : Form {
		private bool closing;

		public SettingsForm() {
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
			textBoxAdbPath.Dock = DockStyle.Fill;
			textBoxAdbPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			LoadSettings();
		}

		private (string path, bool isExists) IsAdbExists(bool ignoreUserSettings = false) {
			string path = null;
			bool isFound = false;
			if (checkBoxAutoDetectAdb.Checked) {
				(path, isFound) = Utils.GetAdbPath(ignoreUserSettings);
			} else {
				if (File.Exists(textBoxAdbPath.Text)) {
					path = textBoxAdbPath.Text;
					isFound = true;
				}
			}
			return (path, isFound);
		}

		private void UpdateControls(object sender = null, EventArgs e = null) {
			bool customAdbPathEnabled = !checkBoxAutoDetectAdb.Checked;
			labelAdbPath.Enabled = customAdbPathEnabled;
			textBoxAdbPath.Enabled = customAdbPathEnabled;
			buttonChooseAdb.Enabled = customAdbPathEnabled;

			(string path, bool isFound) = IsAdbExists(true);
			textBoxUsingThisAdb.Text = isFound ? $"ADB found: {path}" : "ADB not found";
		}

		private void LoadSettings() {
			checkBoxAutoDetectAdb.Checked = Properties.Settings.Default.AutoDetectAdb;
			textBoxAdbPath.Text = Properties.Settings.Default.AdbCustomPath;
			UpdateControls();
		}

		private void SaveSettings() {
			Properties.Settings.Default.AutoDetectAdb = checkBoxAutoDetectAdb.Checked;
			Properties.Settings.Default.AdbCustomPath = textBoxAdbPath.Text;
			Properties.Settings.Default.Save();
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			SaveSettings();
			if (!closing) Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e) {
			if (!closing) Close();
		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
			closing = true;
			buttonCancel_Click(sender, null);
		}

		private void buttonChooseAdb_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog() {
				CheckPathExists = true,
				RestoreDirectory = true,
				ShowReadOnly = false,
				ReadOnlyChecked = true,
				Title = "Please select ADB executable",
				Multiselect = false
			};
			if (File.Exists(textBoxAdbPath.Text)) {
				openFileDialog.FileName = Path.GetFileName(textBoxAdbPath.Text);
				openFileDialog.InitialDirectory = Path.GetDirectoryName(textBoxAdbPath.Text);
			} else if (Directory.Exists(textBoxAdbPath.Text)) {
				openFileDialog.InitialDirectory = textBoxAdbPath.Text;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				textBoxAdbPath.Text = openFileDialog.FileName;
			}
		}

		private void buttonSetupAdb_Click(object sender, EventArgs e) => buttonSetupAdb_Click(sender, e, default);
		private void buttonSetupAdb_Click(object sender, EventArgs e, bool dontAsk = false) {
			(string path, bool isExists) = IsAdbExists(true);
			if (!dontAsk && isExists && (MessageBox.Show($"It seems ADB already exists at '{path}'.\nDo you want to continue anyway?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)) return;
			try {
				Utils.SetupAndroidSdk(default, dontAsk);
				checkBoxAutoDetectAdb.Checked = true;
			} catch (Exception ex) {
				if (MessageBox.Show($"Failed to setup ADB:\n{ex.Message}", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) buttonSetupAdb_Click(sender, e, true);
			}
		}
	}
}
