'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  SetWindowCompositionAttributeA.vb
'  Created by David S

Imports System.Runtime.InteropServices

Imports Core.Animation

Namespace WinApi

    Public Class SetWindowCompositionAttributeA

        'Mostly undocumented
        'https://undoc.airesoft.co.uk/user32.dll/SetWindowCompositionAttribute.php
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ThrowOnUnmappableChar:=True)>
        Public Shared Function SetWindowCompositionAttribute(hWnd As IntPtr, pAttrData As WindowCompositionAttributeData) As Boolean
        End Function

    End Class

End Namespace


