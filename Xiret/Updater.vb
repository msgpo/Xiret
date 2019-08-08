'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  Update.vb
'  Created by David S on 20.03.2016
'  Updated on 14.07.2019 - DS (Update variable)
'  Updated on 31.07.2019 - DS (Cleanup)

Imports System.Xml

Imports Core.Helpers

Friend Class Updater

    Private Shared XMLDoc As XmlDocument = New XmlDocument

    Friend Shared LocalVersion As String = ""
    Friend Shared ServerVersion As String = ""
    Friend Shared ReleaseDate As String = ""
    Friend Shared Type As String = ""

#Region "Routines"

    Friend Shared Function CheckForUpdate() As Boolean

        Try
            If NetHelper.IsWebsiteAvailable(Strings.StringBitmightUrl) Then
                XMLDoc.Load(Strings.StringServerVersionUrl)

                'Remote
                Dim XMLNode = XMLDoc.SelectSingleNode("data/CurrentBuild")
                Dim MajBuildServer = CInt(XMLNode("Maj").InnerText)
                Dim MinBuidServer = CInt(XMLNode("Min").InnerText)
                Dim RevBuildServer = CInt(XMLNode("Build").InnerText)
                ServerVersion = MajBuildServer & "." & MinBuidServer & "." & RevBuildServer

                XMLNode = Nothing

                XMLNode = XMLDoc.SelectSingleNode("data")
                ReleaseDate = XMLNode("LatestReleaseDate").InnerText
                Type = XMLNode("LatestReleaseType").InnerText

                'Local
                Dim VersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileHelper.GetApplicationImage)
                Dim MajBuildLocal As Integer = VersionInfo.FileMajorPart
                Dim MinBuildLocal As Integer = VersionInfo.FileMinorPart
                Dim RevBuildLocal As Integer = VersionInfo.FileBuildPart

                LocalVersion = MajBuildLocal & "." & MinBuildLocal & "." & RevBuildLocal

                XMLNode = Nothing

                If ServerVersion > LocalVersion Then
                    Return True
                Else
                    If ServerVersion < LocalVersion Then
                        Return False
                    Else
                        If ServerVersion = LocalVersion Then
                            Return False
                        End If
                    End If
                End If
            Else
                Return False
            End If

        Catch
            Return False
        End Try

        Return False

    End Function

#End Region

End Class
