Public Class MappingManager
    Public Shared Sub SetProperties(ByVal form As MainForm)
        Dim targetMapper As IMapping = New MainWindowMapping()
        targetMapper.SetProperties(form)
    End Sub

    Public Shared Sub SetProperties(ByVal form As Form1)
        Dim targetMapper As IMapping = New Form1Mapping()
        targetMapper.SetProperties(form)
    End Sub
End Class
