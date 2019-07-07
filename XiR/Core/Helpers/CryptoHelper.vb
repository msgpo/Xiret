'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  CryptoHelper.vb
'  Created by David S
'  Updated on 04.07.2019 - DS (Removed sha512)

Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Namespace Core.Helpers

    Module CryptoHelper

#Region "Calculate SHA256"

        Public Function CHGeneratesha256(ByVal filepath As String) As String

            Dim sb As New StringBuilder()
            Dim hash As SHA256 = SHA256.Create()

            Using mf As FileStream = File.OpenRead(filepath)
                For Each b As Byte In hash.ComputeHash(mf)
                    sb.Append(b.ToString("x2").ToLower())
                Next
            End Using

            Return sb.ToString()

        End Function

#End Region

    End Module

End Namespace




