using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarrierAppDeleter.Forms {
	static class Utils {
		internal static (string dest, bool isSucceeded) SetupAndroidSdk(string dest = null, bool dontAsk = false) {
			void ensureNotExists(string path, bool allowEmptyDirectory = true) {
				if (!allowEmptyDirectory && Directory.Exists(path)) throw new InvalidOperationException($"The directory '{path}' already exists");
				else if (Directory.Exists(path) && Directory.EnumerateFileSystemEntries(path).Any()) throw new InvalidOperationException($"The directory '{path}' is not empty");

				if (File.Exists(path)) throw new InvalidOperationException($"The file '{path}' already exists");
			}
			string _dest = dest ?? Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
			string downloadAddress = string.Empty;
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) downloadAddress = "https://dl.google.com/android/repository/platform-tools-latest-windows.zip";
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) /* || RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD) <-- .NET Core >= 3.0 and Linux emulation may be needed */)
				downloadAddress = "https://dl.google.com/android/repository/platform-tools-latest-linux.zip";
			if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) downloadAddress = "https://dl.google.com/android/repository/platform-tools-latest-darwin.zip";
			string tempFilePath = Path.GetTempFileName();  // mktemp
			try {
				if (!dontAsk && MessageBox.Show($"Download Google Android SDK Platform-Tools?\n\nIt will be extracted to {_dest}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return (null, false);
				ensureNotExists(Path.Combine(_dest, "platform-tools"));
				System.Net.WebClient wc = new System.Net.WebClient();
				wc.DownloadFile(downloadAddress, tempFilePath);
				wc.Dispose();
				ZipArchive zipArchive = ZipFile.OpenRead(tempFilePath);
				try {
					HashSet<string> hashSet = new HashSet<string>();
					foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
						hashSet.Add(zipArchiveEntry.FullName.Replace('\\', '/').Split('/')[0]);
					foreach (string zipItem in hashSet) {
						string p = Path.Combine(_dest, zipItem);
						ensureNotExists(p, false);
					}
					zipArchive.ExtractToDirectory(_dest);
				} finally {
					zipArchive.Dispose();
				}
			} finally {
				File.Delete(tempFilePath);
			}
			return (_dest, true);
		}

		internal static (string path, bool isSucceeded) IsCommandExistsInPath(string commandName, System.Collections.IDictionary env = null) {
			if (commandName == null) throw new ArgumentNullException("The argument 'commandName' cannot be null");
			if (env == null) env = Environment.GetEnvironmentVariables();
			List<string> commands = new List<string> { commandName };
			if (env.Contains("PATHEXT")) {
				foreach (string pathExt in env["PATHEXT"].ToString().Split(Path.PathSeparator)) {
					commands.Add($"{commandName}{pathExt}");
				}
			}
			if (env.Contains("PATH")) {
				foreach (string path in env["PATH"].ToString().Split(Path.PathSeparator)) {
					foreach (string command in commands) {
						string commandFullPath = Path.Combine(path, command);
						if (File.Exists(commandFullPath)) return (commandFullPath, true);
					}
				}
			}
			return (null, false);
		}
		internal static (string path, bool isSucceeded) GetAdbPath(bool ignoreUserSettings = false, bool ensureExists = true, System.Collections.IDictionary env = null) {
			Properties.Settings settings = Properties.Settings.Default;
			if (!ignoreUserSettings && !settings.AutoDetectAdb)
				if (!ensureExists || File.Exists(settings.AdbCustomPath))
					return (settings.AdbCustomPath, true);
				else
					return (null, false);

			System.Collections.IDictionary _env;
			if (env == null) _env = Environment.GetEnvironmentVariables();
			else {
				_env = new Dictionary<string, string>();
				foreach (System.Collections.DictionaryEntry e in env) _env.Add(e.Key, e.Value);
			}

			if (_env.Contains("PATH")) {
				List<string> path = _env["PATH"].ToString().Split(Path.PathSeparator).ToList();
				foreach (string envKey in new string[] { "ANDROID_HOME", "ANDROID_SDK_ROOT" })
					if (_env.Contains(envKey))
						path.Add(_env[envKey].ToString());
				string autoPlatformTools = Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName, "platform-tools");
				if (Directory.Exists(autoPlatformTools)) path.Add(autoPlatformTools);
				_env["PATH"] = string.Join(Path.PathSeparator.ToString(), path);
			}

			return IsCommandExistsInPath("adb", _env);
		}
		internal static (string path, bool isSucceeded) GetAndroidSdkPath(System.Collections.IDictionary env = null, bool existsOnly = true) {
			if (env == null) env = Environment.GetEnvironmentVariables();
			foreach (string envKey in new string[] { "ANDROID_HOME", "ANDROID_SDK_ROOT" })
				if (env.Contains(envKey) && (!existsOnly || Directory.Exists(env[envKey].ToString()))) return (env[envKey].ToString(), true);
			return (null, false);
		}
	}
}
