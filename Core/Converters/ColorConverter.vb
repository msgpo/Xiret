'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  ColorConverter.vb
'  Created by David S on 07.08.2019

Namespace Converters

    Public Class ColorConverter

#Region "RGB to Int"

        Public Shared Function RgbtoInt(Red As Integer, Green As Integer, Blue As Integer) As Integer

            If Red > 255 OrElse Red < 0 Then
                Throw New ArgumentException("Invalid integer", "'Value of " & Red & " is not valid for 'Red'. 'Red' should be greater than or equal to 0 and less than or equal to 255.'")
            End If

            If Green > 255 OrElse Green < 0 Then
                Throw New ArgumentException("Invalid integer", "'Value of " & Green & " is not valid for 'Green'. 'Green' should be greater than or equal to 0 and less than or equal to 255.'")
            End If

            If Blue > 255 OrElse Blue < 0 Then
                Throw New ArgumentException("Invalid integer", "'Value of " & Blue & " is not valid for 'Blue'. 'Blue' should be greater than or equal to 0 and less than or equal to 255.'")
            End If

            'Smallest power of 16 L > R (BGR)
            Return (Blue << 16) + (Green << 8) + Red

        End Function

#End Region

    End Class

End Namespace


