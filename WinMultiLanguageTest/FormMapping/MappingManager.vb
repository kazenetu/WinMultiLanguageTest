Public Class MappingManager
    Public Shared Sub SetProperties(ByVal form As MainForm)
        Dim targetMapper As IMapping = New MainWindowMapping()
        targetMapper.SetProperties(form)
    End Sub
End Class
