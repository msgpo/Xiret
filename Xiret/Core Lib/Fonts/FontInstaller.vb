'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  FontInstaller.vb
'  Created by David S on 08.01.2019
'  Updated on 27.07.2019 - DS (Combined to one routine, added args to InstallFont())

Imports System.IO

Imports Xiret.Core.WinApi

Namespace Core.Fonts

    Public Class FontInstaller

        Public Shared ReadOnly SystemFontSegoeUI As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\segoeui.ttf"
        Public Shared ReadOnly SystemFontSegoeUIBold As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\segoeuib.ttf"
        Public Shared ReadOnly SystemFontSegoeUISemibold As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\seguisb.ttf"

        Public Shared FontInstallerError As String = ""

        Private Const WM_FONTCHANGE As Integer = &H1D
        Private Const HWND_BROADCAST As Integer = &HFFFF

        Public Shared Function InstallFont(FileName As String, FontToInstall As Byte(), ProfileName As String) As Integer

            '// This needs more work.

            Try
                File.WriteAllBytes(FileName, FontToInstall)

                If File.Exists(FileName) Then
                    Dim IntRet As Integer = AddFontResourceA.AddFontResource(FileName)
                    Dim IntRes As Integer = SendMessageA.SendMessage(CType(HWND_BROADCAST, IntPtr), WM_FONTCHANGE, 0, CType(0, IntPtr))
                    IntRet = WriteProfileStringA.WriteProfileString("fonts", ProfileName, FileName)
                    Return 1 'Install success
                Else
                    Return 2
                End If
            Catch ex As Exception
                FontInstallerError = ex.ToString
                Return 0 'Error
            End Try

        End Function

    End Class

End Namespace


