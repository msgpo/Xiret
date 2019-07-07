'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  StateConverter.vb
'  Created by David S
'  Updated on 15.06.2019 - DS (Cleanup)

Namespace Core.Converters

    Module StateConverter

        Friend Function ConvertAssessmentState(ByVal i As Integer) As String

            Select Case i
                Case 0
                    Return "Could not retrieve Experience Index state"
                Case 1
                    Return "Experience Index scores are valid"
                Case 2
                    Return "Incoherent with hardware"
                Case 3
                    Return "Experience Index has not yet been established"
                Case 4
                    Return "Experience Index scores are outdated or invalid"
                Case Else
                    Return "Could not retrieve Experience Index state"
            End Select

        End Function

    End Module

End Namespace


