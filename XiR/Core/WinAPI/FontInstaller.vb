'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FontInstaller.vb
'  Created by David S on 08.01.2019
'  Updated on 04.07.2019 - DS (Cleanup)

Imports System.Runtime.InteropServices
Imports System.IO

Namespace Core.WinApi

    Friend Class FontInstaller

        'Variables
        Friend Shared ReadOnly FileFont As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) & "\seguisb.ttf"
        Friend Shared ReadOnly FileFontFallback As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\seguisb.ttf"
        Private Const WM_FONTCHANGE As Integer = &H1D
        Private Const HWND_BROADCAST As Integer = &HFFFF

        'Interop
        '// http://pinvoke.net/default.aspx/gdi32.AddFontResource
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("gdi32", Charset:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)> _
        Shared Function AddFontResource(ByVal lpFileName As String) As Integer
        End Function

        '// http://pinvoke.net/default.aspx/user32.SendMessage
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("user32.dll", Charset:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)> _
        Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
        End Function

        '// http://pinvoke.net/default.aspx/kernel32.WriteProfileString
        <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")> <DllImport("kernel32.dll", Charset:=CharSet.Unicode, SetLastError:=True, ThrowOnUnmappableChar:=True)> _
        Shared Function WriteProfileString(ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Integer
        End Function

#Region "Routines"

        Shared Function WriteFontToDisk() As Boolean

            Try
                File.WriteAllBytes(FileFont, My.Resources.seguisb)
                If File.Exists(FileFont) Then : Return True
                Else : Return False
                End If
            Catch ex As Exception
                Return False
            End Try

        End Function

        Friend Shared Sub InstallMissingFont()

            Try
                If Not WriteFontToDisk() Then

                    File.WriteAllBytes(FileFontFallback, My.Resources.seguisb)
                    MessageBox.Show("Couldn't install the seguisb.ttf font. Please install it manually (Placed on Desktop).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    Dim IntRet As Integer
                    Dim IntRes As Integer

                    IntRet = AddFontResource(FileFont)
                    IntRes = SendMessage(CType(HWND_BROADCAST, IntPtr), WM_FONTCHANGE, 0, CType(0, IntPtr))
                    IntRet = WriteProfileString("fonts", "Segoe UI Semibold (TrueType)", "seguisb.ttf")

                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

#End Region

    End Class

End Namespace
