Imports Xiret.Base.Helpers

Public Module Files

    Public ReadOnly FileTemporary As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Temp\upload" + FileHelper.FHNameAppendage() + ".png"
    Public ReadOnly FileXiretLog As String = DirAppData & "\xiret.log"
    Public ReadOnly FileImgurLog As String = DirAppData & "\imgurlinks.log"
    Public FileCurrentToDisk As String = String.Empty
    Public FileLatestFormalXML As String = ""

    Public FileAppImage As String = DHGetApplicationImage()
    Public FileAppLoader As String = New Uri(Reflection.Assembly.GetExecutingAssembly().ManifestModule.Assembly.EscapedCodeBase).LocalPath

End Module
