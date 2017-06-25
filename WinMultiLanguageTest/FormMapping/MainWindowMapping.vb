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
        target.confirmMessage = LanguageResourceUtil.GetInstance().GetString(ResourceKeys.Keys.MainForm_確認)
        target.Text = LanguageResourceUtil.GetInstance().GetString(ResourceKeys.Keys.MainForm_タイトル)
        target.Label1.Text = LanguageResourceUtil.GetInstance().GetString(ResourceKeys.Keys.MainForm_ラベル1)
        target.Label2.Text = LanguageResourceUtil.GetInstance().GetString(ResourceKeys.Keys.MainForm_ラベル2)
    End Sub
End Class
