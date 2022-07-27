# JpCarrierAppDeleter
## CarrierAppDeleter.Forms
CarrierAppDeleter(WPF)をWinFormsで再実装した物です

### なんでWinFormsなの?
* Windows以外でも動かしたい(マルチプラットフォームにしたい)
* Monoと.NET(旧 .NET Core)はオープンソースかつマルチプラットフォームの.NET実装
* .NETはWPF/WinFormsをWindowsでのみサポートしている
* 現時点(2022年7月27日時点)でMonoはWPFをサポートしていないがWinFormsはサポートしている

からね、しょうがないね

### 変更点
* 既存ファイルを削除しないようにした
* `adb`を環境変数`PATH`, `ANDROID_HOME`, `ANDROID_SDK_ROOT`から探すようにした
* `platform-tools`(Google Android SDK Platform-Tools)のダウンロードをWindows, GNU/Linux, macOSでサポートするようにした
* `platform-tools`のダウンロード前に確認を取るようにした
