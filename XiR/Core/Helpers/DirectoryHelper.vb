'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  DirectoryHelper.vb
'  Created by David S

Imports System.IO

Imports Xiret.Core.WinApi
Imports System.Text

Namespace Core.Helpers

    Module DirectoryHelper

        Public Function DHGetApplicationImage() As String

            Dim SBuilder As New StringBuilder(255)
            GetModuleFilenameA.GetModuleFileName(IntPtr.Zero, SBuilder, SBuilder.Capacity)
            Return SBuilder.ToString
            SBuilder = Nothing

        End Function

        Public Function DHGetApplicationPath() As String
            Dim SBuilder As New StringBuilder(255)
            GetModuleFilenameA.GetModuleFileName(IntPtr.Zero, SBuilder, SBuilder.Capacity)
            Dim FI As New FileInfo(SBuilder.ToString())
            Return FI.Directory.FullName
        End Function

    End Module

End Namespace





