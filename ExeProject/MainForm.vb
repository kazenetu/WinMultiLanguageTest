Imports System.IO
Imports LanguageUtil

Public Class MainForm
    ''' <summary>
    ''' 確認メッセージ
    ''' </summary>
    ''' <returns></returns>
    Public Property confirmMessage As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = String.Format(confirmMessage, "newExe")

        MessageBox.Show(message)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim languageNmae As String = LanguageResourceUtil.LanguageResources.Japanese.ToString()

        ' 連携ファイル読み出し
        Using file As New StreamReader("lang.txt")
            languageNmae = file.ReadToEnd()
        End Using

        Dim resource = LanguageResourceUtil.GetInstance().ConvertStringToLanguageResource(languageNmae)
        LanguageResourceUtil.GetInstance().LoadLanguageResource(resource)

        ' リソースの値をフォームのプロパティに設定
        SetProperties()
    End Sub

    Private Sub SetProperties()
        ' フォームにリソースの値を設定
        Dim resource = LanguageResourceUtil.GetInstance()
        Me.confirmMessage = resource.GetString(ResourceKeys.Keys.MainForm_確認)
        Me.Text = resource.GetString(ResourceKeys.Keys.MainForm_タイトル)
        Me.Label1.Text = resource.GetString(ResourceKeys.Keys.MainForm_ラベル1)
        Me.Label2.Text = resource.GetString(ResourceKeys.Keys.MainForm_ラベル2)

    End Sub
End Class