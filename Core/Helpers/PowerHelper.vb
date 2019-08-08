'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  PowerHelper.vb
'  Created by David S
'  Updated on 07.08.2019 - DS (Cleanup)

Imports System.Windows.Forms

Namespace Helpers

    Public Class PowerHelper

        Public Shared Function IsAdapterPluggedIn() As Boolean

            Dim Status As PowerStatus = SystemInformation.PowerStatus

            Select Case Status.PowerLineStatus
                Case PowerLineStatus.Offline 'Return false
                    Return False
                Case PowerLineStatus.Online 'Return true
                    Return True
                Case PowerLineStatus.Unknown 'Let winsat handle it
                    Return True
                Case Else
                    Return True 'Let winsat handle it
            End Select

        End Function

    End Class

End Namespace


