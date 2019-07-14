﻿'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  WriteProfileStringA.vb
'  Created by David S

Imports System.Runtime.InteropServices

Namespace WinApi

    Public Class WriteProfileStringA

        '// http://pinvoke.net/default.aspx/kernel32.WriteProfileString
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)>
        Shared Function WriteProfileString(ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Integer
        End Function

    End Class

End Namespace


