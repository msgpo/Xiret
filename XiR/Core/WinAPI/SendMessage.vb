'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  SendMessageA.vb
'  Created by David S

Imports System.Runtime.InteropServices

Namespace Core.WinApi

    Friend NotInheritable Class SendMessageA

        '// http://pinvoke.net/default.aspx/user32.SendMessage
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("user32.dll", CharSet:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)>
        Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
        End Function

    End Class

End Namespace


