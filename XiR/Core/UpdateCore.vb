'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  UpdateCore.vb
'  Created by David S on 20.03.2016
'  Updated on 02.01.2019 - DS

Imports System.Xml

Module UpdateCore

    Private xVersionDoc As XmlDocument = New XmlDocument

    Public UpdateLocalVersion As String = ""
    Public UpdateServerVersion As String = ""
    Public UpdateReleaseDate As String = ""
    Public UpdateType As String = ""

    Public Function CheckNewerVersion() As Boolean

        Try

            Dim sMaj As Integer
            Dim sMin As Integer
            Dim sRev As Integer

            xVersionDoc.Load(StringVer)

            'Remote
            Dim vNode = xVersionDoc.SelectSingleNode("data/CurrentBuild")
            sMaj = CInt(vNode("Maj").InnerText)
            sMin = CInt(vNode("Min").InnerText)
            sRev = CInt(vNode("Build").InnerText)
            UpdateServerVersion = sMaj & "." & sMin & "." & sRev
            vNode = Nothing
            vNode = xVersionDoc.SelectSingleNode("data")
            UpdateReleaseDate = vNode("LatestReleaseDate").InnerText
            UpdateType = vNode("LatestReleaseType").InnerText

            'Local
            Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileAppImage)
            Dim fMaj As Integer = fvi.FileMajorPart
            Dim fMin As Integer = fvi.FileMinorPart
            Dim fRev As Integer = fvi.FileBuildPart

            UpdateLocalVersion = fMaj & "." & fMin & "." & fRev

            Dim sFull As Integer = CInt(sMaj & sMin & sRev)
            Dim fFull As Integer = CInt(fMaj & fMin & fRev)

            If sFull > fFull Then
                Return True
            Else
                If sFull < fFull Then
                    Return False
                Else
                    If sFull = fFull Then
                        Return False
                    End If
                End If
            End If

            vNode = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return False

    End Function

End Module
