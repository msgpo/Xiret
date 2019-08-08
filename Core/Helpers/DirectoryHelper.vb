'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  DirectoryHelper.vb
'  Created by David S
'  Updated on 15.07.2019 - DS (Move DHGetApplicationImage())

Imports System.IO
Imports System.Text

Imports Core.WinApi

Namespace Helpers

    Public Class DirectoryHelper
        Public Shared Function GetApplicationPath() As String
            Dim Builder As New StringBuilder(255)
            GetModuleFilenameA.GetModuleFileName(IntPtr.Zero, Builder, Builder.Capacity)
            Dim Info As New FileInfo(Builder.ToString())
            Return Info.Directory.FullName
        End Function

    End Class

End Namespace





