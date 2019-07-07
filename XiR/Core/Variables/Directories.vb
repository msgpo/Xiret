Imports Xiret.Core.Helpers

Module Directories

    Public ReadOnly DirWindows As String = Environment.GetEnvironmentVariable("WINDIR")
    Public ReadOnly DirSpecialDesktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Public ReadOnly DirTemporary As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Temp"
    Public ReadOnly DirWinsatDatastore As String = DirWindows + "\Performance\WinSAT\DataStore"
    Public ReadOnly DirWinsat As String = DirWindows + "\Performance\WinSAT"
    Public ReadOnly DirAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Xiret"
    Public DirAppPath As String = DirectoryHelper.DHGetApplicationPath()

End Module
