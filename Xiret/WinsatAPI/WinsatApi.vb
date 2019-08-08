﻿'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  WinSATAPI.vb
'  Created by David S
'  Updated on 31.07.2019 - DS (Better error handling)

Imports WINSATLib
Imports WINSATLib.WINSAT_BITMAP_SIZE
Imports System.Runtime.InteropServices

'<TypeLibType(2)>
'<ClassInterface(0)>
'<Guid("F3BDFAD3-F276-49E9-9B17-C474F48F0764")>

Friend Class WinsatApi

#Region "Functions"

    Friend Shared Function GetAssessmentValidityInt() As Integer

        Dim query = New CQueryWinSAT()
        Try
            Return query.Info.AssessmentState
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetAssessmentValidityInt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function

    Friend Shared Function GetWinsatHardwareAPIInfo(WinType As WINSAT_ASSESSMENT_TYPE, InfType As InfoType) As String

        Dim query As New CQueryWinSAT()
        Dim queryInf As IProvideWinSATAssessmentInfo = query.Info.GetAssessmentInfo(WinType)
        Try
            Select Case InfType
                Case InfoType.Description
                    Return queryInf.Description
                Case InfoType.Score
                    Return CStr(queryInf.Score)
                Case InfoType.Title
                    Return queryInf.Title
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatHardwareAPIInfo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Unknown"
        End Try

    End Function

    Friend Shared Function GetWinsatBaseScore() As String

        Try
            Dim query As New CQueryWinSAT()
            Return CStr(query.Info.SystemRating)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatBaseScore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Unknown"
        End Try

    End Function

    Friend Shared Function GetWinsatLastUpdateDate() As Date

        Try
            Dim query As New CQueryWinSAT()
            Return CDate(query.Info.AssessmentDateTime)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatLastUpdateDate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

    Friend Shared Function GetWinsatVisual(Optional SizeMode As VisualSize = VisualSize.Small) As Bitmap

        'This function is used to retrieve the winsat visual bitmap
        'Usage ExamplePicturebox.Image = GetWinsatVisual(VisualSize.Normal)
        'VisualSize.Small returns the small image seen in Control Panel > All > System (Up to Windows 8)
        'VisualSize.Large returns the large image seen in the graph in Control Panel > All > Performance Information and Tools (Up to Windows 8)

        Dim query As New CQueryWinSAT()
        Dim Buffer(3) As Byte
        Dim GHC As GCHandle = GCHandle.Alloc(Buffer, GCHandleType.Pinned)
        Dim Pointer As IntPtr = GHC.AddrOfPinnedObject()
        Dim queryVisual As New CProvideWinSATVisuals()

        Try
            If SizeMode = VisualSize.Small Then
                queryVisual.get_Bitmap(WINSAT_BITMAP_SIZE_SMALL, query.Info.AssessmentState, query.Info.SystemRating, Pointer)
            Else
                queryVisual.get_Bitmap(WINSAT_BITMAP_SIZE_NORMAL, query.Info.AssessmentState, query.Info.SystemRating, Pointer)
            End If

            GHC.Free()

            If BitConverter.ToInt32(Buffer, 0) <> 0 Then
                Dim Bmp As Bitmap = Image.FromHbitmap(New IntPtr(BitConverter.ToInt32(Buffer, 0)))
                Return Bmp
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatVisual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

#End Region

End Class




