'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  StrongNameSignatureVerificationA.vb
'  Created by David S

Imports System.Runtime.InteropServices

Namespace WinApi

    Public Class StrongNameSignatureVerificationA

        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("mscorwks.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Shared Function StrongNameSignatureVerificationEx(<MarshalAs(UnmanagedType.LPWStr)> ByVal wszFilePath As String, <MarshalAs(UnmanagedType.Bool)> ByVal fForceVerification As Boolean, <Out(), MarshalAs(UnmanagedType.Bool)> ByRef pfWasVerified As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

    End Class

End Namespace


