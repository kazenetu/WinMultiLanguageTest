Imports System.Globalization
Imports System.Resources

''' <summary>
''' 言語リソースユーティリティ
''' </summary>
Public Class LanguageResourceUtil

    Public Enum LanguageResources
        Japanese
        English
    End Enum

    ''' <summary>
    ''' インスタンス
    ''' </summary>
    Private Shared _instance As New LanguageResourceUtil()

    ''' <summary>
    ''' リソースデータ
    ''' </summary>
    Private _resource As New Dictionary(Of String, String)

    ''' <summary>
    ''' シングルトンのためプライベートコンストラクタ
    ''' </summary>
    Private Sub New()
    End Sub

    ''' <summary>
    ''' インスタンス取得
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetInstance() As LanguageResourceUtil
        Return _instance
    End Function

    ''' <summary>
    ''' 言語リソースを読み込む
    ''' </summary>
    ''' <param name="language">読み込む言語リソース</param>
    Public Sub LoadLanguageResource(language As LanguageResources)
        Dim resourceFileName As String = String.Empty

        ' 言語リソースファイルを設定する
        Select Case language
            Case LanguageResources.Japanese
                resourceFileName = "ja-JP"
            Case LanguageResources.English
                resourceFileName = "en-US"
        End Select

        Dim rm As New ResourceManager("LanguageUtil.Resource", GetType(LanguageResourceUtil).Assembly)

        ' リソースデータをクリアする
        Me._resource.Clear()

        ' リソースを読み込む
        For Each resource As DictionaryEntry In rm.GetResourceSet(New CultureInfo(resourceFileName), True, False)
            Me._resource.Add(resource.Key, resource.Value)
        Next
    End Sub

    ''' <summary>
    ''' ResourceKeys.Keysの値から言語に沿った文字列を返す
    ''' </summary>
    ''' <param name="id">ID</param>
    ''' <returns>言語に沿った文字列</returns>
    Public Function GetString(id As ResourceKeys.Keys) As String
        Return Me.GetString(id.ToString())
    End Function


    ''' <summary>
    ''' IDから言語に沿った文字列を返す
    ''' </summary>
    ''' <param name="id">ID</param>
    ''' <returns>言語に沿った文字列</returns>
    Public Function GetString(id As String) As String
        If (Not Me._resource.Keys.Contains(id)) Then
            Return String.Empty
        End If

        Dim result As String = Me._resource(id)

        ' リソースデータにIDが存在しない場合は空文字を返す
        If result Is Nothing Then
            Return String.Empty
        End If

        Return result
    End Function

End Class
