Imports System.IO
Imports LanguageUtil

Public Class MainForm
    Inherits BaseFrom

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        MyBase.formId = "EXEMainForm"

        ' リソースの値をフォームのプロパティに設定
        MyBase.windowInitialize(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles F0003.Click
        Dim message As String = String.Format(MyBase.getString("M0001"), "aaa")

        MessageBox.Show(message)
    End Sub

End Class