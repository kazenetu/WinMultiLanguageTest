Imports LanguageUtil

Public Class MainForm
    ''' <summary>
    ''' 確認メッセージ
    ''' </summary>
    ''' <returns></returns>
    Public Property confirmMessage As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = String.Format(confirmMessage, "aaa")

        MessageBox.Show(message)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' リソースの値をフォームのプロパティに設定
        MappingManager.SetProperties(Me)
    End Sub
End Class