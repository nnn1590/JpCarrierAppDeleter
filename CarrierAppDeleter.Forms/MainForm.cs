using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrierAppDeleter.Forms {
	partial class MainForm : Form {
		private class DeviceInfo {
			public string Serial, VersionRelease;
			public int VersionSdk;
			// public DeviceInfo();
			public static DeviceInfo FromSerial(string serial) {
				DeviceInfo d = new DeviceInfo() { Serial = serial };
				(string path, bool isSucceeded) = GetAdbPath();
				if (!isSucceeded) return null;
				Process sdkP = QuickAdb(path, serial, "shell getprop ro.build.version.sdk");
				sdkP.Start();
				sdkP.WaitForExit();
				d.VersionSdk = (sdkP.ExitCode == 0) ? int.Parse(sdkP.StandardOutput.ReadLine()) : -1;
				sdkP.Dispose();
				Process relP = QuickAdb(path, serial, "shell getprop ro.build.version.release");
				relP.Start();
				relP.WaitForExit();
				d.VersionRelease = (relP.ExitCode == 0) ? relP.StandardOutput.ReadLine() : $"Error ({relP.StandardError.ReadToEnd()})";
				relP.Dispose();
				return d;
			}
			public string GetUserVisibleText() {
				return $"{Serial} (Android {VersionRelease}, API {VersionSdk})";
			}
		}
		private readonly List<DeviceInfo> deviceInfos = new List<DeviceInfo>();

		private static Process QuickAdb(string adbPath, string deviceSerial, string arg) {
			// (string path, bool isSucceeded) = GetAdbPath();
			// if (!isSucceeded) return null;
			Process process = new Process();
			process.StartInfo.FileName = adbPath;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;
			if (deviceSerial == null) process.StartInfo.Arguments = arg;
			else process.StartInfo.Arguments = $"-s \"{deviceSerial.Replace("\\", "\\\\").Replace("\"", "\\\"")}\" {arg}";
			return process;
		}

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			this.MinimumSize = Size;
			// Fillしてからアンカーを設定することで上下中央揃えする
			comboBoxDevice.Dock = DockStyle.Fill;
			comboBoxDevice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			if (RefreshDevices() == 1) buttonRefreshApplications_Click(null, null);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			Assembly assembly = Assembly.GetExecutingAssembly();
			MessageBox.Show($"{assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title} {assembly.GetName().Version}", $"About {assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e) => new SettingsForm().ShowDialog();

		private void ToggleControls(bool status, int level = 0) {
			List<object> objs = new object[] {
				// checkedListBoxApplications,
				radioButtonAppActDisable, radioButtonAppActRestore, radioButtonAppActUninstall,
				buttonExclDisasterApps, buttonDeselectAllApps, buttonExclWiFiApps, buttonExecuteAppActions,
				buttonRefreshApplications, buttonSelectAllApps,
				// buttonRefreshDevices,
				// comboBoxDevice,
				labelAppActions,
				/* groupBoxApplications, */ groupBoxDevice,
				exitToolStripMenuItem, settingsToolStripMenuItem, aboutToolStripMenuItem,
				// fileToolStripMenuItem, helpToolStripMenuItem
			}.ToList();
			if (level >= 1) objs.AddRange(new object[] { checkedListBoxApplications, groupBoxApplications });
			foreach (object o in objs) {
				if (o is Control c) c.Enabled = status;
				else if (o is ToolStripMenuItem m) m.Enabled = status;
			}
			if (status) UpdateExecuteButton(null, null);
			if (checkedListBoxApplications.Items.Count <= 0) {
				foreach (Button b in new Button[] {
					buttonDeselectAllApps, buttonSelectAllApps, buttonExclDisasterApps, buttonExclWiFiApps, buttonExecuteAppActions
				}) b.Enabled = false;
			}
		}

		private static (string path, bool isSucceeded) GetAdbPath() {
			(string path, bool isSucceeded) = Utils.GetAdbPath();
			if (!isSucceeded && (MessageBox.Show("ADB not found, do you want to setup ADB now?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)) {
				new SettingsForm().ShowDialog();
			}
			return (path, isSucceeded);
		}

		private void buttonRefreshApplications_Click(object sender, EventArgs e) => Task.Run(() => RefreshApplications(true));
		private class CheckedListBoxAppStat {
			public int TopIndex = -1, SelectedIndex = -1;
			public string SelectedItem = null;
		}
		private CheckedListBoxAppStat checkedListBoxAppStat;
		private void RefreshApplications(bool keepChecked = true) {
			// if (InvokeRequired) {}
			(string path, bool isSucceeded) = GetAdbPath();
			if (!isSucceeded) return;
			Invoke((MethodInvoker)(() => {
				ResetToolStrip();
				toolStripProgressBar.Style = ProgressBarStyle.Marquee;
				toolStripStatusLabelStatus.Text = "Refreshing applications...";
				checkedListBoxApplications.SuspendLayout();
				checkedListBoxApplications.ResumeLayout(false);
				ToggleControls(false, 1);
			}));
			List<string> packages = new List<string>();
			Process process = QuickAdb(path, GetSelectedDeviceSerial(), "shell pm list packages");
			// process.StartInfo.Arguments = $"-s \"{GetSelectedDeviceSerial().Replace("\\", "\\\\").Replace("\"", "\\\"")}\" shell pm list packages";
			// process.StartInfo.ArgumentList = { "-s", GetSelectedDeviceSerial(), "shell", "pm list packages" };
			process.Start();
			process.WaitForExit();
			string read;
			// VSCode/iumでデバッグするとここで謎の文字列が混入する (Mono + ms-vscode.mono-debug + VSCodium + Ubuntu 20.04で確認済み)
			// Content-Length: 46
			// {"command":"threads","type":"request","seq":5}
			// (その後に本来のstdoutが取れる)
			while ((read = process.StandardOutput.ReadLine()) != null) {
				read = Regex.Replace(read, "^package:", "", RegexOptions.Compiled);
				if (Regex.IsMatch(read, Properties.Settings.Default.PackageRegex, RegexOptions.None, TimeSpan.FromMilliseconds(1000)))
					packages.Add(read);
			}
			CheckedListBox.ObjectCollection objectCollection = new CheckedListBox.ObjectCollection(checkedListBoxApplications);
			CheckedListBox.CheckedItemCollection checkedItems = checkedListBoxApplications.CheckedItems;
			List<string> checkedPackages = new List<string>();
			if (keepChecked) foreach (string o in checkedItems) checkedPackages.Add(o);
			Invoke((MethodInvoker)(() => {
				checkedListBoxApplications.Items.Clear();
				checkedListBoxAppStat = new CheckedListBoxAppStat() {
					TopIndex = checkedListBoxApplications.TopIndex,
					SelectedItem = checkedListBoxApplications.SelectedItem as string,
					SelectedIndex = checkedListBoxApplications.SelectedIndex
				};
			}));
			if (process.ExitCode != 0) {
				Invoke((MethodInvoker)(() => ShowError($"Failed to get list of packages:\n{process.StandardError.ReadToEnd()}")));
			} else if (packages.Count == 0) {
				Invoke((MethodInvoker)(() => MessageBox.Show("No applications were found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)));
			}

			Invoke((MethodInvoker)(() => {
				foreach (string package in packages) {
					objectCollection.Add(package, checkedPackages.Contains(package));
				}
				checkedListBoxApplications.Items.AddRange(objectCollection);
				checkedListBoxApplications.TopIndex = checkedListBoxAppStat.TopIndex;
				if (packages.Contains(checkedListBoxAppStat.SelectedItem)) checkedListBoxApplications.SelectedItem = checkedListBoxAppStat.SelectedItem;
				else checkedListBoxApplications.SelectedIndex = checkedListBoxAppStat.SelectedIndex;
			}));
			Invoke((MethodInvoker)(() => {
				checkedListBoxApplications.ResumeLayout();
				ToggleControls(true, 1);
				toolStripProgressBar.Style = ProgressBarStyle.Blocks;
				toolStripStatusLabelStatus.Text = "Ready";
			}));
		}

		private static void ShowError(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		private void buttonRefreshDevices_Click(object sender, EventArgs e) => RefreshDevices();
		private int RefreshDevices() {
			int deviceCountAll = -1;
			(string path, bool isSucceeded) = GetAdbPath();
			if (!isSucceeded) return deviceCountAll;
			List<string> devices = new List<string>();

#if true
			Process process = QuickAdb(path, null, "devices");
			// process.StartInfo.Arguments = "devices";
			// process.StartInfo.ArgumentList = { "devices" };
			process.Start();
			process.WaitForExit();
			string read;
			if (process.ExitCode == 0) while ((read = process.StandardOutput.ReadLine()) != null) devices.Add(read);
#else
			string stdoutFilePath = Path.GetTempFileName();
			string stderrFilePath = Path.GetTempFileName();
#pragma warning disable CS0618
			int forkResult = Mono.Posix.Syscall.fork();
#pragma warning restore CS0618
			if (forkResult == 0) {
				int originStdout = Mono.Unix.Native.Syscall.dup(1);
				int originStderr = Mono.Unix.Native.Syscall.dup(2);
				int fdStdout = Mono.Unix.Native.Syscall.open(stdoutFilePath, Mono.Unix.Native.OpenFlags.O_RDWR | Mono.Unix.Native.OpenFlags.O_CREAT, Mono.Unix.Native.FilePermissions.S_IRUSR | Mono.Unix.Native.FilePermissions.S_IWUSR);
				int fdStderr = Mono.Unix.Native.Syscall.open(stderrFilePath, Mono.Unix.Native.OpenFlags.O_RDWR | Mono.Unix.Native.OpenFlags.O_CREAT, Mono.Unix.Native.FilePermissions.S_IRUSR | Mono.Unix.Native.FilePermissions.S_IWUSR);
				bool failed = false;
				string errorText = string.Empty;
				if (fdStdout < 0) {
					errorText = "Failed to open stdout redirect file";
					failed = true;
				}
				if (fdStderr < 0) {
					errorText = failed ? "Failed to open both stdout and stderr redirect files" : "Failed to open stderr redirect file";
					failed = true;
				}
				if (failed) {
					ShowError(errorText);
					Mono.Unix.Native.Stdlib.exit(1);
				}
				Mono.Unix.Native.Syscall.dup2(fdStdout, 1);
				Mono.Unix.Native.Syscall.dup2(fdStderr, 2);
				Mono.Unix.Native.Syscall.close(fdStdout);
				Mono.Unix.Native.Syscall.close(fdStderr);
				int r = Mono.Unix.Native.Syscall.execv(path, new string[] { "adb", "devices", null });
				Mono.Unix.Native.Syscall.dup2(originStdout, 1);
				Mono.Unix.Native.Syscall.dup2(originStderr, 2);
				ShowError($"execv failed: {r}");
				Mono.Unix.Native.Stdlib.exit(1);
				throw new InvalidOperationException("Child process continued");
			} else if (forkResult > 0) {
				int waitPidResult;
				waitPidResult = Mono.Unix.Native.Syscall.waitpid(forkResult, out int childResult, 0);
				if (waitPidResult < 0) {
					ShowError($"waitpid failed ({Mono.Unix.Native.Stdlib.GetLastError()}), child pid: {waitPidResult}");
				} else {
					if (Mono.Unix.Native.Syscall.WIFEXITED(childResult)) devices = File.ReadAllLines(stdoutFilePath).ToList();
					// Console.WriteLine(File.ReadAllText(stdoutFilePath));
					// Console.Error.WriteLine(File.ReadAllText(stderrFilePath));
				}
			} else {
				ShowError($"Failed to create fork ({Mono.Unix.Native.Stdlib.GetLastError()})");
			}

			File.Delete(stdoutFilePath);
			File.Delete(stderrFilePath);
#endif
			comboBoxDevice.Items.Clear();
			deviceInfos.Clear();
			for (int i = devices.Count - 1; i >= 0; i--) {
				if (string.IsNullOrEmpty(devices[i]) || string.IsNullOrWhiteSpace(devices[i]) || devices[i].Equals("List of devices attached"))
					devices.RemoveAt(i);
			}
			deviceCountAll = devices.Count;
			for (int i = devices.Count - 1; i >= 0; i--) {
				if (!devices[i].Split('\t')[1].Equals("device"))
					devices.RemoveAt(i);
			}
			if (devices.Count <= 0) {
				ShowError("Failed to fetch devices or no device found\n\nPlease check:\n* Device is turned on\n* Device is connected\n* USB debugging is on (if connected via USB)\n* ADB installed correctly\n\nThis tool exclude devices which the 2nd column of 'adb devices' is not 'device'");
				comboBoxDevice.Items.Add("Failed to fetch devices or no device found");
			} else {
				for (int i = 0; i < devices.Count; i++) {
					devices[i] = devices[i].Split('\t')[0];
					DeviceInfo deviceInfo = DeviceInfo.FromSerial(devices[i]);
					deviceInfos.Add(deviceInfo);
					comboBoxDevice.Items.Add(deviceInfo.GetUserVisibleText());
				}
			}
			return deviceCountAll;
		}

		string comboBoxDevicePrev = null;
		private void comboBoxDevice_GotFocus(object sender, EventArgs e) {
			comboBoxDevicePrev = comboBoxDevice.Text;
		}
		private void comboBoxDevice_SelectionChangeCommittedOrLeave(object sender, EventArgs e) {
			if (!comboBoxDevice.Text.Equals(comboBoxDevicePrev)) {
				comboBoxDevicePrev = comboBoxDevice.Text;
				// LostFocus時にモーダルダイアログ(MessageBox.Show()やForm#ShowDialog()など)を出すとcatch不可なNREで落ちるので注意 (Mono 6.12.0.182 で確認)
				// Unhandled Exception:
				// System.NullReferenceException: Object reference not set to an instance of an object
				//   at System.Windows.Forms.X11Keyboard.CreateOverTheSpotXic(System.IntPtr window, System.IntPtr xim)[0x00007] in < 28e46de2d20c496895000ef0abfc2106 >:0
				//   at System.Windows.Forms.X11Keyboard.CreateXic(System.IntPtr window, System.IntPtr xim)
				//   (以下略)
				// なのでアプリケーションを実行している.NETランタイムがMonoの場合はモーダルダイアログが出ないように気をつける
				// NG: MessageBox.Show("");      ←は落ちる
				// NG: new Form().ShowDialog();  ←も落ちる
				// OK: new Form().Show();        ←非モーダルは落ちない
				// ちなみにLeave時やroot権限で実行すると落ちない
				// Wine上の.NET 6でも落ちず、かつスタックトレースの内容からして恐らくMonoのバグっぽい

				// if (Type.GetType("Mono.Runtime") == null)
				Task.Run(() => RefreshApplications(false));
			}
		}

		private void buttonSelectAllApps_Click(object sender, EventArgs e) => ToggleSelectAll(true);
		private void buttonDeselectAllApps_Click(object sender, EventArgs e) => ToggleSelectAll(false);
		private void ToggleSelectAll(bool status) {
			for (int i = 0; i < checkedListBoxApplications.Items.Count; i++)
				checkedListBoxApplications.SetItemChecked(i, status);
		}

		private void UpdateExecuteButton(object sender, EventArgs e) {
			buttonExecuteAppActions.Enabled = (checkedListBoxApplications.Items.Count > 1) && (radioButtonAppActDisable.Checked || radioButtonAppActRestore.Checked || radioButtonAppActUninstall.Checked);
			if (radioButtonAppActDisable.Checked) buttonExecuteAppActions.Text = "Disable checked application(s)";
			else if (radioButtonAppActRestore.Checked) buttonExecuteAppActions.Text = "Restore checked application(s)";
			else if (radioButtonAppActUninstall.Checked) buttonExecuteAppActions.Text = "Uninstall checked application(s)";
		}
		private void buttonExclDisasterApps_Click(object sender, EventArgs e) {
			ExcludeApps(new string[] { "com.kddi.disasterapp", "jp.co.nttdocomo.saigaiban", "jp.softbank.mb.cbrl", "jp.softbank.mb.dmb" });
		}
		private void buttonExclWiFiApps_Click(object sender, EventArgs e) {
			ExcludeApps(new string[] { "jp.co.softbank.wispr.froyo", "com.kddi.android.au_wifi_connect2" });
		}
		private void ExcludeApps(string[] packageNames) {
			if (packageNames == null) return;
			string[] strs = checkedListBoxApplications.Items.OfType<string>().Where(packageNames.Contains).ToArray();
			for (int i = 0; i < checkedListBoxApplications.Items.Count; i++) {
				if (strs.Contains((string)checkedListBoxApplications.Items[i])) checkedListBoxApplications.SetItemChecked(i, false);
			}
		}

		bool shouldLogScrollToEnd = true;
		private void AppendLog(string text) {
			if (shouldLogScrollToEnd) textBoxLog.AppendText(text);
			else textBoxLog.Text += text;
		}

		void ResetToolStrip() {
			toolStripProgressBar.Value = 0;
			toolStripProgressBar.Style = ProgressBarStyle.Blocks;
			toolStripStatusLabelStatus.Text = "Ready";
		}

		private void buttonExecuteAppActions_Click(object sender, EventArgs e) {
			(string path, bool isSucceeded) = GetAdbPath();
			if (!isSucceeded) return;

			ResetToolStrip();
			int actionCount = 0;
			actionCount += (radioButtonAppActDisable.Checked ? 1 : 0) +
				(radioButtonAppActRestore.Checked ? 1 : 0) +
				(radioButtonAppActUninstall.Checked ? 1 : 0);
			if (actionCount <= 0) {
				ShowError("Please select action first");
				return;
			} else if (actionCount > 1) {
				throw new InvalidOperationException("Action checked more than 1");
			}
			int appsCount = checkedListBoxApplications.CheckedItems.Count;
			string[] apps = checkedListBoxApplications.CheckedItems.OfType<string>().ToArray();
			if (appsCount != apps.Count()) {
				throw new InvalidOperationException($"appsCount({appsCount} and apps.Count()({apps.Count()}) doesn't match");
			}
			string device = GetSelectedDeviceSerial();
			if (appsCount <= 0) {
				ShowError("No applications checked. Please check at least one");
				ResetToolStrip();
				return;
			}

			AppAction action;
			if (radioButtonAppActDisable.Checked) action = AppAction.Disable;
			else if (radioButtonAppActRestore.Checked) action = AppAction.Reinstall;
			else if (radioButtonAppActUninstall.Checked) action = AppAction.Uninstall;
			else throw new InvalidOperationException();

			Dictionary<AppAction, string> LogVerb = new Dictionary<AppAction, string>() {
				{ AppAction.Uninstall, "Uninstalling" },
				{ AppAction.Disable, "Disabling" },
				{ AppAction.Enable, "Enabling" },
				{ AppAction.Reinstall, "Reinstalling" }
			};
			Dictionary<AppAction, string> PastVerb = new Dictionary<AppAction, string>() {
				{ AppAction.Uninstall, "uninstalled from" },
				{ AppAction.Disable, "disabled in" },
				{ AppAction.Enable, "enabled in" },
				{ AppAction.Reinstall, "reinstalled to" }
			};
			string TextApplications(int count) => "application" + ((Math.Abs(count) == 1) ? "" : "s");

			if (MessageBox.Show($"Checked {appsCount} {TextApplications(appsCount)} will be {PastVerb[action]} {device}.\n" +
				"Do you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
				toolStripProgressBar.Maximum = appsCount;
				toolStripProgressBar.Style = ProgressBarStyle.Continuous;
				toolStripProgressBar.Step = 1;
				toolStripStatusLabelStatus.Text = $"{LogVerb[action]} {appsCount} {TextApplications(appsCount)}...";

				Process sdkP = QuickAdb(path, device, "shell getprop ro.build.version.sdk");
				sdkP.Start();
				sdkP.WaitForExit();
				int versionSdk = (sdkP.ExitCode == 0) ? int.Parse(sdkP.StandardOutput.ReadLine()) : -1;
				sdkP.Dispose();

				if (!string.IsNullOrEmpty(textBoxLog.Text)) AppendLog("===============\n");
				DateTime dateTimeStart = DateTime.Now;
				AppendLog($"{LogVerb[action]} {appsCount} {TextApplications(appsCount)}... Started at {dateTimeStart.ToLongDateString()} {dateTimeStart.ToLongTimeString()} ({TimeZoneInfo.Local})\n");
				AppendLog($"Device: {device} (API level {versionSdk})\n");
				void EndLog(int errorCount = 0) {
					DateTime dateTimeEnd = DateTime.Now;
					AppendLog($"Action done at {dateTimeEnd.ToLongDateString()} {dateTimeEnd.ToLongTimeString()} ({TimeZoneInfo.Local})\nElapsed: {dateTimeEnd - dateTimeStart}\n" +
					((errorCount > 0) ? $"{errorCount} app(s) errored\n" : null));
				}
				bool shouldKeepData = true;
				if (radioButtonAppActUninstall.Checked) {
					shouldKeepData = MessageBox.Show("Should keep data?\n\nYou can uninstall applications without losing data.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
				}
				if (radioButtonAppActDisable.Checked) {
					if (versionSdk <= 2) {
						const string str = "Android 1.2 or earlier doesn't support disable applications";
						ShowError(str);
						toolStripStatusLabelStatus.Text = "Done with error";
						AppendLog($"Error: {str}");
						EndLog();
						return;
					}
				}
				ToggleControls(false);
				Dictionary<AppAction, string> Command = new Dictionary<AppAction, string>() {
					{ AppAction.Uninstall, "uninstall" + (shouldKeepData ? " -k" : null) },
					{ AppAction.Disable, "disable" },
					{ AppAction.Enable, "enable" }
				};
				Task.Run(() => {
					int errorCount = 0;
					for (int i = 0; i < appsCount; i++) {
						Invoke((MethodInvoker)(() => {
							toolStripProgressBar.Value = i;
							AppendLog($"=> {LogVerb[action]} '{apps[i]}'...");
						}));
						Process p = QuickAdb(path, device, $"shell pm {Command[action]} {apps[i]}");
						p.Start();
						p.WaitForExit();
						string stdout = p.StandardOutput.ReadToEnd();
						string stderr = p.StandardError.ReadToEnd();
						Regex regex = new Regex("([ \t]*Killed[ \t]+pm.*$|^Failure(\r\n|\r|\n)$|^Error: )", RegexOptions.Compiled | RegexOptions.Singleline, TimeSpan.FromMilliseconds(1000));
						// Console.WriteLine(stdout);
						// Console.Error.WriteLine(stderr);
						bool errorPrintedToStdout = regex.IsMatch(stdout);
						if (p.ExitCode != 0 || !string.IsNullOrEmpty(stderr) || errorPrintedToStdout) {
							errorCount++;
							string errorSource = errorPrintedToStdout ? stdout : stderr;
							Invoke((MethodInvoker)(() => AppendLog($" error: {errorSource}" +
								(errorSource.Last().Equals('\n') ? null : "\n"))));
						} else {
							Invoke((MethodInvoker)(() => AppendLog(" done\n")));
						}
					}
					Invoke((MethodInvoker)(() => {
						toolStripProgressBar.Value = toolStripProgressBar.Maximum;
						toolStripStatusLabelStatus.Text = "Done" + ((errorCount > 0) ? $". {errorCount} app(s) errored" : null);
						EndLog(errorCount);
						ToggleControls(true);
					}));
				});
			} else ResetToolStrip();
		}

		private enum AppAction {
			None,
			Uninstall,
			Disable,
			Enable,
			Reinstall
		}

		private string GetSelectedDeviceSerial() {
			// Regex regex = new Regex(@"^[a-zA-Z0-9_+:\-]+", RegexOptions.Compiled);
			return comboBoxDevice.Text.Split(' ')[0].Split('\t')[0];
		}
	}
}
