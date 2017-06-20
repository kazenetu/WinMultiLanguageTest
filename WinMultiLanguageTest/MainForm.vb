Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = LanguageUtil.LanguageUtil.GetInstance().GetString("M001001", {"aaa"})

        MessageBox.Show(message)
    End Sub
End Class