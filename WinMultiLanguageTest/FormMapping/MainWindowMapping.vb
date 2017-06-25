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
    ''' <param name="resource">リソースユーティリティのインスタンス</param>
    Public Sub SetProperties(form As Form, ByVal resource As LanguageResourceUtil) Implements IMapping.SetProperties
        Dim target As MainForm = DirectCast(form, MainForm)

        ' フォームにリソースの値を設定
        target.confirmMessage = resource.GetString(ResourceKeys.Keys.MainForm_確認)
        target.Text = resource.GetString(ResourceKeys.Keys.MainForm_タイトル)
        target.Label1.Text = resource.GetString(ResourceKeys.Keys.MainForm_ラベル1)
        target.Label2.Text = resource.GetString(ResourceKeys.Keys.MainForm_ラベル2)
    End Sub
End Class
