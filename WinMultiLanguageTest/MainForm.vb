Imports LanguageUtil

Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = LanguageResourceUtil.GetInstance().GetString("M001001", {"aaa"})

        MessageBox.Show(message)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = LanguageResourceUtil.GetInstance().GetString("S001000")
        Me.Label1.Text = LanguageResourceUtil.GetInstance().GetString("S001001")
        Me.Label2.Text = LanguageResourceUtil.GetInstance().GetString("S001002")

    End Sub
End Class