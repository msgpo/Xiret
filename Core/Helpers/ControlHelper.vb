'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  ControlHelper.vb
'  Created by David S
'  Updated on 31.07.2019 - DS (Moved API to Core\WinApi\SendMessageA)

Imports System.Windows.Forms

Imports Core.WinApi

Namespace Helpers

    Public Class ControlHelper

        Public Shared Sub SetCueText(Textbox As Control, Text As String)
            SendMessageA.SendMessage(Textbox.Handle, &H1501, 0, CStr(Text))
        End Sub

    End Class

End Namespace


