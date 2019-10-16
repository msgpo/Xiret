Imports System.IO

Imports Xiret.Core.Helpers

Friend Class Directories

    '!Friend Shared ReadOnly DirWindows As String = Environment.GetEnvironmentVariable("WINDIR")!
    Friend Shared ReadOnly DirWindows As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
    Friend Shared ReadOnly DirSpecialDesktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Friend Shared ReadOnly DirAppPath As String = DirectoryHelper.GetApplicationPath()
    Friend Shared ReadOnly DirTemporary As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp")
    Friend Shared ReadOnly DirWinsatDatastore As String = Path.Combine(DirWindows, "Performance\WinSAT\DataStore")
    Friend Shared ReadOnly DirWinsat As String = Path.Combine(DirWindows, "Performance\WinSAT")
    Friend Shared ReadOnly DirAppData As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Xiret")
    Friend Shared ReadOnly DirSys32 As String = Environment.GetFolderPath(Environment.SpecialFolder.System)


End Class
