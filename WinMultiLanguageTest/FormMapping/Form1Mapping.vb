Imports LanguageUtil
''' <summary>
''' フォーム1設定用クラス
''' </summary>
Public Class Form1Mapping
    Implements IMapping

    ''' <summary>
    ''' フォームのプロパティに設定
    ''' </summary>
    ''' <param name="form">対象フォーム</param>
    ''' <param name="resource">リソースユーティリティのインスタンス</param>
    Public Sub SetProperties(form As Form, ByVal resource As LanguageResourceUtil) Implements IMapping.SetProperties
        Dim target = DirectCast(form, Form1)

        ' フォームにリソースの値を設定
        target.F0001.Text = resource.GetString(ResourceKeys.Keys.Form1_ボタン1)
    End Sub
End Class
