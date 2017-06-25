Imports LanguageUtil

''' <summary>
''' リソースの情報をフォームのプロパティにセットする
''' </summary>
Public Interface IMapping
    ''' <summary>
    ''' フォームのプロパティに設定
    ''' </summary>
    ''' <param name="form">対象フォーム</param>
    ''' <param name="resource">リソースユーティリティのインスタンス</param>
    Sub SetProperties(ByVal form As Form, ByVal resource As LanguageResourceUtil)
End Interface
