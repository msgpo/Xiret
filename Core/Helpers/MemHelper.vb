'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  MemHelper.vb
'  Created by David S
'  Updated on 07.08.2019 - DS (Enhancements)

Imports Core.WinApi

Namespace Helpers

    Public Class MemHelper

        Public Shared Function FreeMemory() As Boolean

            'SetProcessWorkingSetSize() will return 1 when successful,
            'so it can also return in int should you choose. e.g.
            'Dim Result as Integer = SetProcessWorkingSetSizeA.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            '
            'I'm simply returning a boolean value when the 'If' statement exits without an error.

            Try
                GC.Collect()
                GC.WaitForPendingFinalizers()
                If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                    SetProcessWorkingSetSizeA.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, CType(-1, IntPtr), CType(-1, IntPtr))
                End If
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

End Namespace


