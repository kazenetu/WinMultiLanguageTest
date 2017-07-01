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
        target.Text = resource.GetString(ResourceKeys.Keys.MainForm_タイトル)
        target.F0001.Text = resource.GetString(ResourceKeys.Keys.MainForm_ラベル1)
        target.F0002.Text = resource.GetString(ResourceKeys.Keys.MainForm_ラベル2)
    End Sub
End Class
