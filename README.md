# CareerAppDeleter
CareerAppDeleterは[竹林人間](https://github.com/Aoi-Developer/)さんの[remove-career-app](https://github.com/Aoi-Developer/remove-career-app)の機能をWindowsのGUIで独自実装し機能を追加したものです。
## 対応環境
Windows8以上の.NET Framework 4.7.2がインストールされている環境。

ARM系CPUでの動作確認はしておりません。
### テスト環境
|項目|値|
|----|--|
|OS|Windows 10|
|CPU|Ryzen 5 1600|
|RAM|DDR4 24GB|
|SSD|500 GB|

## 注意事項
指定したアプリのデータがすべて削除されます。

アプリのデータが削除されることによりキャリアからのサポートを受けることができなくなる可能性があります。

一度削除したアプリはバックアップソフトでバックアップを取った場合をのぞき復元することができません。

削除するアプリをよく確認し実行してください。

なお、本ソフトで発生した故障や損害につきましては開発者は責任を負いかねます。

## 実行方法
### 導入
まず、[こちら](https://github.com/binary-number/CarrierAppDeleter/releases)のリンクにアクセスしCarrierAppDeleter.zipの最新版をダウンロードします。

ダウンロードしたCarrierAppDeleter.zipを解凍してください。

### 実行
キャリアアプリを削除したいAndroid端末のUSBデバッグを有効にし本ソフトを導入したパソコンに接続します。

接続はファイル転送モードにします。


フォルダ内にあるCarrierAppDeleter.exeファイルを実行してください。

本ソフトは署名がないため初回起動時には以下のような画面が表示されますが、詳細を押すと実行というボタンが表示されるのでそちらを押して実行してください。


![署名なし](https://github.com/binary-number/CarrierAppDeleter/blob/master/REAEME_Image/Image1.png)


初回起動時はplatform-toolsの導入のため5秒ほど時間がかかります。

### 操作
起動すると以下のは画面表示されます。


![実行画面](https://github.com/binary-number/CarrierAppDeleter/blob/master/REAEME_Image/Image3.png)

#### デバイスの選択
まず接続しているデバイスの検索を行う必要があります。

(接続している端末が1台の場合はデバイスの選択を行う必要はありません)

デバイスと書いてある横に*検索*と書かれたボタンがあります。

こちらのボタンを押すことで現在接続しているAndroid端末を検索することができます。

検索が終了するとデバイスが下のComboBox(ドロップダウンリスト)に追加されますので、任意の端末を選択してください。

####

## Build方法
Visual Studioで.slnファイルを開きBuildしてください。
