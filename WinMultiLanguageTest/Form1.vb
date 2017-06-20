Imports LanguageUtil.LanguageUtil

Public Class Form1
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim languages As New Dictionary(Of String, String)
        languages.Add(LanguageResources.Japanese, LanguageResources.Japanese.ToString())
        languages.Add(LanguageResources.English, LanguageResources.English.ToString())

        Me.ComboBox1.DataSource = languages.ToList()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ComboBox1.SelectedItem Is Nothing Then
            Return
        End If

        LanguageUtil.LanguageUtil.GetInstance().LoadLanguageResource(Me.ComboBox1.SelectedItem.key)

        Dim mainForm = New MainForm()
        mainForm.ShowDialog()
    End Sub
End Class
