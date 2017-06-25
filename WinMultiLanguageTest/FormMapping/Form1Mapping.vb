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
    Public Sub SetProperties(form As Form) Implements IMapping.SetProperties
        Dim target = DirectCast(form, Form1)

        ' フォームにリソースの値を設定
        target.Button1.Text = LanguageResourceUtil.GetInstance().GetString("Form1_Button1")
    End Sub
End Class
