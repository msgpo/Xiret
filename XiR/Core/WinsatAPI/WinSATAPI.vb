'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  WinSATAPI.vb
'  Created by David S

Imports WINSATLib
Imports System.Runtime.InteropServices

Namespace Core.WinsatApi
    <TypeLibType(2)>
    <ClassInterface(0)>
    <Guid("F3BDFAD3-F276-49E9-9B17-C474F48F0764")>
    Public Module CQueryWinSATClass

        Public Function GetAssessmentValidityInt() As Integer
            Dim q = New CQueryWinSAT()
            Try
                Return q.Info.AssessmentState
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Core.WinsatApi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return Nothing
        End Function

        Public Function GetWinsatHardwareAPIInfo(WinType As WINSAT_ASSESSMENT_TYPE, InfType As InfoType) As String

            Dim qWinsat As New CQueryWinSAT()
            Dim qAssInfo As IProvideWinSATAssessmentInfo = qWinsat.Info.GetAssessmentInfo(WinType)

            Select Case InfType
                Case InfoType.Description
                    Return qAssInfo.Description
                Case InfoType.Score
                    Return CStr(qAssInfo.Score)
                Case InfoType.Title
                    Return qAssInfo.Title
            End Select

            Return Nothing

        End Function

        Public Function GetWinsatBaseScore() As String

            Dim qWinsat As New CQueryWinSAT()
            Return CStr(qWinsat.Info.SystemRating)

        End Function

        Public Function GetWinsatLastUpdateDate() As DateTime

            Dim qWinsat As New CQueryWinSAT()
            Return CDate(qWinsat.Info.AssessmentDateTime)

        End Function

        Public Enum InfoType

            Description
            Score
            Title

        End Enum

    End Module

End Namespace





