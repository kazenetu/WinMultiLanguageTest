Imports LanguageUtil

Public Class Program
    ''' <summary>
    ''' エントリメソッド
    ''' </summary>
    Shared Sub Main()
        ' 連携ファイル読み出し
        Dim languageName = LanguageResourceUtil.GetInstance().ReadLanguageFile()

        Dim resource = LanguageResourceUtil.GetInstance().ConvertStringToLanguageResource(languageName)
        LanguageResourceUtil.GetInstance().LoadLanguageResource(resource)

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub
End Class
