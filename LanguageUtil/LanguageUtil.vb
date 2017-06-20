Imports System.Resources

''' <summary>
''' 言語ユーティリティ
''' </summary>
Public Class LanguageUtil

    Public Enum LanguageResources
        Japanese
        English
    End Enum

    ''' <summary>
    ''' インスタンス
    ''' </summary>
    Private Shared _instance As New LanguageUtil()

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
    Public Shared Function GetInstance() As LanguageUtil
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
                resourceFileName = "Resources\Resource_ja.resx"
            Case LanguageResources.English
                resourceFileName = "Resources\Resource_en.resx"
        End Select

        ' リソースデータをクリアする
        Me._resource.Clear()

        ' リソースを読み込む
        Using resxSet As New ResXResourceReader(resourceFileName)
            For Each resource As DictionaryEntry In resxSet
                Me._resource.Add(resource.Key, resource.Value)
            Next
        End Using
    End Sub

    ''' <summary>
    ''' IDから言語に沿った文字列を返す
    ''' </summary>
    ''' <param name="id">ID</param>
    ''' <param name="params">パラメータ</param>
    ''' <returns>言語に沿った文字列</returns>
    Public Function GetString(id As String, params() As String) As String
        Dim result As String = Me._resource(id)

        ' リソースデータにIDが存在しない場合は空文字を返す
        If result Is Nothing Then
            Return String.Empty
        End If

        Return String.Format(result, params)
    End Function





End Class
