# BaseForm

### 所属プロジェクト
MultiLanguageUtility

## 概要
画面フォームのスーパークラス  
Formを継承  
リソースファイル切り替えによる多言語対応を行う

## 機能
* リソースファイルから値取得
* 画面の初期化  

## 注意事項
* リソースIDは __画面ID__ + __コントロールID(F9999)__  
  または __画面ID__ + __メッセージID(M9999)__ で構成される  
 * コントロール.Nameに__リソースID__を設定  
* サブクラスではコンストラクタで画面の初期化を行う  
  例：  
  ``` vb.net
  MyBase.windowInitialize(Me)
  ```
* 別のフィールドなどを参照するコントロールやメッセージはソースコードで実装する  
  例：  
  ``` vb.net
  MessageBox.Show(String.Format(MyBase.getString("MainFormM0001"), "aaa"))
  ```
