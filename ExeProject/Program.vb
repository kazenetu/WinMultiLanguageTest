Imports LanguageUtil

Public Class Program
    ''' <summary>
    ''' エントリメソッド
    ''' </summary>
    Shared Sub Main()
        ' 連携ファイル読み出し
        Dim languageName = LanguageResourceUtility.GetInstance().ReadLanguageFile()

        Dim resource = LanguageResourceUtility.GetInstance().ConvertStringToLanguageResource(languageName)
        LanguageResourceUtility.GetInstance().LoadLanguageResource(resource)

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub
End Class
