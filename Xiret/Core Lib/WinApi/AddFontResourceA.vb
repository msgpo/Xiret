﻿'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  AddFontResourceA.vb
'  Created by David S

Imports System.Runtime.InteropServices

Namespace Core.WinApi

    Public Class AddFontResourceA

        '// http://pinvoke.net/default.aspx/gdi32.AddFontResource
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("gdi32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
        Public Shared Function AddFontResource(lpFileName As String) As Integer
        End Function

    End Class

End Namespace


