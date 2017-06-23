Imports LanguageUtil

Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = LanguageResourceUtil.GetInstance().GetString("M001001", {"aaa"})

        MessageBox.Show(message)
    End Sub
End Class