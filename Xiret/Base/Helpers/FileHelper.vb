'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FileHelper.vb
'  Created by David S
'  Updated on 10.07.2019 - DS (FHGetLatestXML will now cache the current latest formal XML file for quicker access)

Imports System.IO
Imports System.Text

Namespace Base.Helpers

    Module FileHelper

#Region "Random filename"

        Public Function FHNameAppendage() As String

            Dim s As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 4
                Dim ir As Integer = r.Next(0, 35)
                sb.Append(s.Substring(ir, 1))
            Next

            Return sb.ToString

        End Function

#End Region
#Region "File Move"

        Friend Sub FHMove(ByVal SourceFile As String, ByVal DestinationFile As String, Optional Overwrite As Boolean = False)

            Dim StringSource As String = ""
            Dim StringDestination As String = ""

            If File.Exists(SourceFile) Then

                My.Computer.FileSystem.CopyFile(SourceFile, DestinationFile, Overwrite)

                If File.Exists(DestinationFile) Then

                    StringSource = CHGeneratesha256(SourceFile)
                    StringDestination = CHGeneratesha256(DestinationFile)

                    If StringSource = StringDestination Then
                        My.Computer.FileSystem.DeleteFile(SourceFile)
                    Else
                        My.Computer.FileSystem.DeleteFile(DestinationFile)
                        MessageBox.Show("Checksum fail:" & vbCrLf & vbCrLf & StringSource & vbCrLf & StringDestination & vbCrLf & vbCrLf & "Source settings were left untouched.", "Debug Core.Helpers.FHMove")
                    End If

                Else
                    MessageBox.Show("SourceFile did not copy to DestinationFile.", "Core.Helpers.FHMove", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("SourceFile missing.", "Core.Helpers.FHMove", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End Sub

#End Region
#Region "WinSAT XML"

        Friend Function FHGetLatestXML() As String

            Dim SWatch As New Stopwatch()
            Dim newestFile As FileInfo = Nothing
            Dim StrFolder As New DirectoryInfo(DirWindows & "\Performance\WinSAT\DataStore")

            SWatch.Start()

            For Each finfo In StrFolder.EnumerateFiles("*Formal*.xml", SearchOption.TopDirectoryOnly)
                If newestFile Is Nothing OrElse finfo.LastWriteTime >= newestFile.LastWriteTime Then
                    newestFile = finfo
                End If
            Next

            SWatch.Stop()

            If (newestFile Is Nothing) And OSHWinIsVista() Then 'Vista is a little different, check for one Initial file

                For Each finfo In StrFolder.EnumerateFiles("*Initial*.xml", SearchOption.TopDirectoryOnly)
                    If newestFile Is Nothing OrElse finfo.LastWriteTime >= newestFile.LastWriteTime Then
                        newestFile = finfo
                    End If
                Next

                If newestFile Is Nothing Then
                    FileLatestFormalXML = ""
                    Return ""
                Else
                    FileLatestFormalXML = newestFile.FullName
                    Return newestFile.FullName
                End If

            Else
                FileLatestFormalXML = newestFile.FullName
                Return newestFile.FullName
            End If

            Return ""

        End Function

#End Region

    End Module

End Namespace


