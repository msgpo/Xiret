'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  SizeConverter.vb
'  Created by David S

Namespace Base.Converters

    Module SizeConverter

#Region "Functions"
        Friend Function ConvertBigSize(ByVal Bytes As Double) As String

            Dim DoubleBytes As Double

            Try
                Select Case Bytes
                    Case Is >= 1099511627776
                        DoubleBytes = CDbl(Bytes / 1099511627776) 'TB
                        Return FormatNumber(DoubleBytes, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        DoubleBytes = CDbl(Bytes / 1073741824) 'GB
                        Return FormatNumber(DoubleBytes, 2) & " GB"
                        'Return Format(DoubleBytes, "########0") & " GB"
                    Case 1048576 To 1073741823
                        DoubleBytes = CDbl(Bytes / 1048576) 'MB
                        Return FormatNumber(DoubleBytes, 2) & " MB"
                    Case 1024 To 1048575
                        DoubleBytes = CDbl(Bytes / 1024) 'KB
                        Return FormatNumber(DoubleBytes, 2) & " KB"
                    Case 0 To 1023
                        DoubleBytes = Bytes ' bytes
                        Return FormatNumber(DoubleBytes, 2) & " bytes"
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try

        End Function
        Public Function BytesToMBSquared(SizeIn As Double) As String

            Dim SizeOut As Double = (SizeIn / Math.Pow(1024, 2))
            Return Format(SizeOut, "########0.00")

        End Function
#End Region

    End Module

End Namespace


