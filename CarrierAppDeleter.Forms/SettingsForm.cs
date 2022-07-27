using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace CarrierAppDeleter.Forms {
	public partial class SettingsForm : Form {
		private bool closing;

		public SettingsForm() {
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
			foreach (TextBox textBox in new TextBox[] { textBoxAdbPath, textBoxRegex }) {
				textBox.Size = new Size(1, 1);
				textBox.Dock = DockStyle.Fill;
				textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			}
			// ErrorProvider errorProvider = new ErrorProvider();
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

			CheckRegex(null, null);
		}

		private void LoadSettings() {
			checkBoxAutoDetectAdb.Checked = Properties.Settings.Default.AutoDetectAdb;
			textBoxAdbPath.Text = Properties.Settings.Default.AdbCustomPath;

			checkBoxECMARegex.Checked = Properties.Settings.Default.IsPackageRegexECMA;
			textBoxRegex.Text = Properties.Settings.Default.PackageRegex;

			UpdateControls();
		}

		private void SaveSettings() {
			Properties.Settings.Default.AutoDetectAdb = checkBoxAutoDetectAdb.Checked;
			Properties.Settings.Default.AdbCustomPath = textBoxAdbPath.Text;

			Properties.Settings.Default.IsPackageRegexECMA = checkBoxECMARegex.Checked;
			Properties.Settings.Default.PackageRegex = textBoxRegex.Text;

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
				(string dest, bool isSucceeded) = Utils.SetupAndroidSdk(default, dontAsk);
				if (isSucceeded) {
					checkBoxAutoDetectAdb.Checked = false;
					textBoxAdbPath.Text = $"{dest}/platform-tools/adb" + (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ".exe" : null);
				}
			} catch (Exception ex) {
				if (MessageBox.Show($"Failed to setup ADB:\n{ex.Message}", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) buttonSetupAdb_Click(sender, e, true);
			}
		}

		private void buttonResetRegex_Click(object sender, EventArgs e) {
			textBoxRegex.Text = (string)Properties.Settings.Default.Properties["PackageRegex"].DefaultValue;
			// boolへのキャストではInvalidCastExceptionが発生してしまう
			checkBoxECMARegex.Checked = bool.Parse((string)Properties.Settings.Default.Properties["IsPackageRegexECMA"].DefaultValue);
		}

		private void CheckRegex(object sender, EventArgs e) {
			try {
				new Regex(textBoxRegex.Text, checkBoxECMARegex.Checked ? RegexOptions.ECMAScript : RegexOptions.None);
				textBoxRegexChecker.Text = "Valid regex pattern";
			} catch (ArgumentException ex) {
				textBoxRegexChecker.Text = $"Invalid regex pattern:\n{ex.Message}";
			}
		}
	}
}
