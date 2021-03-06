﻿Imports System.Environment
Imports System.Globalization
Imports System.IO
Imports System.Resources

''' <summary>
''' 言語リソースユーティリティ
''' </summary>
Public Class LanguageResourceUtility

    Public Enum LanguageResources
        Japanese
        English
    End Enum

    ''' <summary>
    ''' 連携ファイル名
    ''' </summary>
    Private Const LANGUAGE_FILE As String = "lang.txt"

    ''' <summary>
    ''' インスタンス
    ''' </summary>
    Private Shared _instance As New LanguageResourceUtility()

    ''' <summary>
    ''' リソースデータ
    ''' </summary>
    Private _resource As New Dictionary(Of String, String)

    ''' <summary>
    ''' ロードしている言語
    ''' </summary>
    Private _loadedLanguage As LanguageResources

    ''' <summary>
    ''' シングルトンのためプライベートコンストラクタ
    ''' </summary>
    Private Sub New()
    End Sub

    ''' <summary>
    ''' インスタンス取得
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetInstance() As LanguageResourceUtility
        Return _instance
    End Function

    ''' <summary>
    ''' 文字列の言語名を言語列挙型に変換する
    ''' </summary>
    ''' <param name="languageName">言語名</param>
    ''' <returns>言語列挙型</returns>
    Public Function ConvertStringToLanguageResource(ByVal languageName As String) As LanguageResources
        For Each resource As LanguageResources In [Enum].GetValues(GetType(LanguageResources))
            If resource.ToString() = languageName Then
                Return resource
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' 現在の言語を返す
    ''' </summary>
    ''' <returns>言語列挙型</returns>
    Public Function GetLanguageResource() As LanguageResources
        Return _loadedLanguage
    End Function

    ''' <summary>
    ''' 言語リソースを読み込む
    ''' </summary>
    ''' <param name="language">読み込む言語リソース</param>
    Public Sub LoadLanguageResource(language As LanguageResources)
        Dim languageName As String = String.Empty

        ' 言語名を設定する
        Select Case language
            Case LanguageResources.Japanese
                languageName = "日本語"
            Case LanguageResources.English
                languageName = "英語"
        End Select

        ' Excelファイルからリソースファイルを生成する
        Dim excel2Resource As New ExcelToResource()
        Dim resourceFileName As String = excel2Resource.GenerateResource("dummy_id.xlsx", "target", languageName)

        ' リソースデータをクリアする
        Me._resource.Clear()

        ' リソースを読み込む
        Using reader As New ResXResourceReader(resourceFileName)
            For Each entry As System.Collections.DictionaryEntry In reader
                Me._resource.Add(entry.Key, entry.Value)
            Next
        End Using

        ' ロード済み言語を設定する
        Me._loadedLanguage = language

    End Sub

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

    ''' <summary>
    ''' 連携ファイル出力
    ''' </summary>
    Public Sub WriteLanguageFile()
        Dim languageFilePath As String = Path.Combine(GetFolderPath(SpecialFolder.LocalApplicationData), LANGUAGE_FILE)

        ' 連携ファイル書き出し
        Using file As New StreamWriter(languageFilePath)
            file.Write(Me._loadedLanguage.ToString())
        End Using
    End Sub

    ''' <summary>
    ''' 連携ファイル読み込み
    ''' </summary>
    ''' <returns>言語名</returns>
    Public Function ReadLanguageFile() As String
        Dim languageName As String = LanguageResources.Japanese.ToString

        Dim languageFilePath As String = Path.Combine(GetFolderPath(SpecialFolder.LocalApplicationData), LANGUAGE_FILE)
        If File.Exists(languageFilePath) Then
            ' 連携ファイル読み出し
            Using file As New StreamReader(languageFilePath)
                languageName = file.ReadToEnd()
            End Using
        End If

        Return languageName
    End Function

End Class
