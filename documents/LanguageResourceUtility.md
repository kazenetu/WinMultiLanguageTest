# LanguageResourceUtility

### 所属プロジェクト
MultiLanguageUtility

## 概要
言語リソースユーティリティ  
リソースファイルの管理を行うシングルトンクラス

## 機能
* 言語リソースの読み込み
* リソースファイルから値取得
* 実行ファイル間連携用の言語ファイルの読み書き  

## 注意事項
* 新たに言語を追加する場合は下記を行う
 1. 「Resources/Resource.__言語名__.resx」 を追加する
 1. 列挙型「LanguageResourceUtility.LanguageResources」に言語名を追加する
 1. LanguageResourceUtility#LoadLanguageResourceメソッド内の下記を追加する  
 ``` vb.net
 ' 言語リソースファイルを設定する
 Select Case language
     ～中略～
     Case LanguageResources.言語名
         resourceFileName = "リソースファイルに追加する言語名"
 End Select
 ```
