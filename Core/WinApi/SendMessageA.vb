﻿'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  SendMessageA.vb
'  Created by David S
'  Updated on 31.07.2019 - DS (Added SendMessage() variant)

Imports System.Runtime.InteropServices

Namespace WinApi

    Public Class SendMessageA

        '// http://pinvoke.net/default.aspx/user32.SendMessage
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
        Public Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As UInteger, lParam As IntPtr) As Integer
        End Function

        '// Variant for SetCueText
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
        Public Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As UInteger, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Integer
        End Function

    End Class

End Namespace
