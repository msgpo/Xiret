'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  Crypto.vb
'  Created by David S
'  Updated on 01.08.2019 - DS (Added optional char casing)
'  Updated on 07.08.2019 - DS (Cleanup)

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace Helpers

    Public Class CryptoHelper

#Region "SHA256"

        Public Shared Function GetSha256FromFile(FilePath As String, Optional UpperCase As Boolean = False) As String

            Dim Builder As New StringBuilder()
            Dim Hash As SHA256 = SHA256.Create()

            Using Stream As FileStream = File.OpenRead(FilePath)
                For Each HByte As Byte In Hash.ComputeHash(Stream)
                    If Not UpperCase Then
                        Builder.Append(HByte.ToString("x2").ToLower())
                    Else
                        Builder.Append(HByte.ToString("x2").ToUpper())
                    End If
                Next
            End Using

            Return Builder.ToString()

        End Function

#End Region
#Region "SHA512"

        Public Shared Function GetSha512FromFile(FilePath As String, Optional UpperCase As Boolean = False) As String

            Dim Builder As New StringBuilder()
            Dim HashType As SHA512 = SHA512.Create()

            Using Stream As FileStream = File.OpenRead(FilePath)
                For Each HByte As Byte In HashType.ComputeHash(Stream)
                    If Not UpperCase Then
                        Builder.Append(HByte.ToString("x2").ToLower())
                    Else
                        Builder.Append(HByte.ToString("x2").ToUpper())
                    End If
                Next
            End Using

            Return Builder.ToString()

        End Function

#End Region

    End Class

End Namespace


