''' <summary>
''' リソースの情報をフォームのプロパティにセットする
''' </summary>
Public Interface IMapping
    ''' <summary>
    ''' フォームのプロパティに設定
    ''' </summary>
    ''' <param name="form">対象フォーム</param>
    Sub SetProperties(ByVal form As Form)
End Interface
