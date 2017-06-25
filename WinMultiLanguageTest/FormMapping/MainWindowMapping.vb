Imports LanguageUtil

''' <summary>
''' メインフォーム設定用クラス
''' </summary>
Public Class MainWindowMapping
    Implements IMapping

    ''' <summary>
    ''' フォームのプロパティに設定
    ''' </summary>
    ''' <param name="form">対象フォーム</param>
    Public Sub SetProperties(form As Form) Implements IMapping.SetProperties
        Dim target As MainForm = DirectCast(form, MainForm)

        ' フォームにリソースの値を設定
        target.confirmMessage = LanguageResourceUtil.GetInstance().GetString("M001001")
        target.Text = LanguageResourceUtil.GetInstance().GetString("S001000")
        target.Label1.Text = LanguageResourceUtil.GetInstance().GetString("S001001")
        target.Label2.Text = LanguageResourceUtil.GetInstance().GetString("S001002")
    End Sub
End Class
