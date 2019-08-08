Imports System.IO

Imports Core.Helpers

Friend Class Files

    Friend Shared ReadOnly FileTemporary As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Temp\imgur_" + FileHelper.GenerateRandomString(8, False) + ".png"
    Friend Shared ReadOnly FileXiretLog As String = Path.Combine(Directories.DirAppData, "xiret.log")
    Friend Shared ReadOnly FileImgurLog As String = Path.Combine(Directories.DirAppData, "imgurlinks.log")
    Friend Shared ReadOnly FileAppLoader As String = New Uri(Reflection.Assembly.GetExecutingAssembly().ManifestModule.Assembly.EscapedCodeBase).LocalPath

    Friend Shared FileCurrentToDisk As String = ""
    Friend Shared FileLatestFormalXML As String = ""

End Class
