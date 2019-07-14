'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  PowerHelper.vb
'  Created by David S

Namespace Base.Helpers

    Module PowerHelper

        Friend Function PHIsAdapterPlugged() As Boolean

            Dim pls As PowerStatus = SystemInformation.PowerStatus

            Select Case pls.PowerLineStatus
                Case PowerLineStatus.Offline 'Return false
                    Return False
                Case PowerLineStatus.Online 'Return true
                    Return True
                Case PowerLineStatus.Unknown 'If not present winsat will kick up an error
                    Return True
                Case Else
                    Return True 'Same as unknown
            End Select
        End Function

    End Module

End Namespace


