Imports System.IO
Imports LanguageUtil

Public Class Form1
    Inherits BaseFrom

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim languages As New Dictionary(Of String, String)
        languages.Add(LanguageResourceUtility.LanguageResources.Japanese, LanguageResourceUtility.LanguageResources.Japanese.ToString())
        languages.Add(LanguageResourceUtility.LanguageResources.English, LanguageResourceUtility.LanguageResources.English.ToString())
        Me.ComboBox1.DisplayMember = "value"
        Me.ComboBox1.ValueMember = "key"
        Me.ComboBox1.DataSource = languages.ToList()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Form1F0001.Click
        If Me.ComboBox1.SelectedItem Is Nothing Then
            Return
        End If

        LanguageResourceUtility.GetInstance().LoadLanguageResource(Me.ComboBox1.SelectedItem.key)

        Dim mainForm = New MainForm()
        mainForm.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LanguageResourceUtility.GetInstance().LoadLanguageResource(Me.ComboBox1.SelectedItem.key)

        ' リソースの値をフォームのプロパティに設定
        MyBase.windowInitialize(Me)
        Me.Text = Me.getString("Form1F0000")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Form1F0002.Click

        ' 連携ファイル書き出し
        LanguageResourceUtility.GetInstance().WriteLanguageFile()

        ' 実行ファイルを呼び出し
        Process.Start("ExeProject.exe")
    End Sub
End Class
