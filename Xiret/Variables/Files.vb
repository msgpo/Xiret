Imports System.IO

Imports Xiret.Core.Helpers

Friend Class Files

    Friend Shared ReadOnly FileTemporary As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Temp\imgur_" + FileHelper.GenerateRandomString(8, False) + ".png"
    Friend Shared ReadOnly FileXiretLog As String = Path.Combine(Directories.DirAppData, "xiret.log")
    Friend Shared ReadOnly FileImgurLog As String = Path.Combine(Directories.DirAppData, "imgurlinks.log")
    Friend Shared ReadOnly FileWinsatLog As String = Path.Combine(Directories.DirWinsat, "winsat.log")
    Friend Shared ReadOnly FileAppLoader As String = New Uri(Reflection.Assembly.GetExecutingAssembly().ManifestModule.Assembly.EscapedCodeBase).LocalPath
    Friend Shared FileLatestFormalXML As String = ""

    Friend Shared ReadOnly FontSegoeUI As String = Directories.DirWindows & "\Fonts\segoeui.ttf"
    Friend Shared ReadOnly FontSegoeUISemibold As String = Directories.DirWindows & "\Fonts\seguisb.ttf"
    Friend Shared ReadOnly FontSegoeUIBold As String = Directories.DirWindows & "\Fonts\segoeuib.ttf"

    Friend Shared ReadOnly FileWinsat As String = Path.Combine(Directories.DirSys32, "winsat.exe")
    Friend Shared ReadOnly FileWinsatApi As String = Path.Combine(Directories.DirSys32, "winsatapi.dll")

End Class
