# JpCarrierAppDeleter
## CarrierAppDeleter.Forms
Implementation of CarrierAppDeleter(WPF) with WinForms

### Why WinForms?
* Application should be multi-platform
* Mono and .NET(a.k.a .NET Core) are open source multi-platform .NET implementation
* .NET supports WPF/WinForms on Windows only
* Currently(2022/7/27), Mono doesn't support WPF but WinForms

Therefore, it has been used.

### What changed from upstream
* Stopped deleting existing files
* Find `adb` from environment variables `PATH`, `ANDROID_HOME`, `ANDROID_SDK_ROOT`
* Downloading `platform-tools`(Google Android SDK Platform-Tools) supported on Windows, GNU/Linux and macOS
* Ask user before downloading `platform-tools`
