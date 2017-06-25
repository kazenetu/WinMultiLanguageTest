Imports LanguageUtil
''' <summary>
''' フォームマッピング
''' </summary>
Public Class MappingManager
    ''' <summary>
    ''' リソースの値をフォームのプロパティに設定する
    ''' </summary>
    ''' <param name="form">メインフォーム</param>
    Public Shared Sub SetProperties(ByVal form As MainForm)
        Dim targetMapper As IMapping = New MainWindowMapping()
        targetMapper.SetProperties(form, LanguageResourceUtil.GetInstance())
    End Sub

    ''' <summary>
    ''' リソースの値をフォームのプロパティに設定する
    ''' </summary>
    ''' <param name="form">フォーム1</param>
    Public Shared Sub SetProperties(ByVal form As Form1)
        Dim targetMapper As IMapping = New Form1Mapping()
        targetMapper.SetProperties(form, LanguageResourceUtil.GetInstance())
    End Sub
End Class
