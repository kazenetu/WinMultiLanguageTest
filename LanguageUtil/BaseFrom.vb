Imports System.Windows.Forms

''' <summary>
''' フォームのスーパークラス
''' </summary>
Public Class BaseFrom
    Inherits Form

    ''' <summary>
    ''' リソースの値が設定できない場合の値
    ''' </summary>
    Private Const RESOURCE_NONE As String = "----"

    ''' <summary>
    ''' IDから言語に沿った文字列を返す
    ''' </summary>
    ''' <param name="id">コントロールID</param>
    ''' <returns>言語に沿った文字列</returns>
    Protected Function getString(ByVal id As String) As String
        ' idがなければ空文字を
        If String.IsNullOrEmpty(id) Then
            Return String.Empty
        End If

        Dim text As String = LanguageResourceUtility.GetInstance().GetString(id)

        ' 値がなければその旨を設定
        If String.IsNullOrEmpty(text) Then
            Return RESOURCE_NONE
        End If

        Return text
    End Function

    ''' <summary>
    ''' ウィンドウ(フォーム)の初期化
    ''' </summary>
    ''' <param name="src">対象コントロール</param>
    Protected Sub windowInitialize(ByVal src As Control)
        Dim text As String = Me.getString(src.Name)

        ' リソースの値を取得できれば設定
        If Not String.IsNullOrEmpty(text) Then
            Me.setContorl(src, text)
        End If

        ' 子のコントロールを設定
        For Each child As Control In src.Controls
            windowInitialize(child)
        Next

    End Sub

    ''' <summary>
    ''' コントロールのテキスト設定
    ''' </summary>
    ''' <param name="src">対象コントロール</param>
    ''' <param name="text">設定テキスト</param>
    Private Sub setContorl(ByVal src As Object, ByVal text As String)

        ' ラベルの設定
        If TypeOf src Is Label Then
            Me.setContorl(DirectCast(src, Label), text)
            Return
        End If

        ' ボタンの設定
        If TypeOf src Is Button Then
            Me.setContorl(DirectCast(src, Button), text)
            Return
        End If

    End Sub

    ''' <summary>
    ''' コントロールのテキスト設定：ラベル
    ''' </summary>
    ''' <param name="src">対象コントロール</param>
    ''' <param name="text">設定テキスト</param>
    Private Sub setContorl(ByVal src As Label, ByVal text As String)
        src.Text = text
    End Sub

    ''' <summary>
    ''' コントロールのテキスト設定：ボタン
    ''' </summary>
    ''' <param name="src">対象コントロール</param>
    ''' <param name="text">設定テキスト</param>
    Private Sub setContorl(ByVal src As Button, ByVal text As String)
        src.Text = text
    End Sub

End Class
