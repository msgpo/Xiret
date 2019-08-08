'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  NetHelper.vb
'  Created by David S
'  Updated on 07.08.2019 - DS (Cleanup)

Imports System.Net

Namespace Helpers

    Public Class NetHelper
        Public Shared Function IsWebsiteAvailable(WebAddress As String) As Boolean

            Try
                Dim Request As WebRequest
                Dim Response As WebResponse
                Request = WebRequest.Create(WebAddress)
                Request.Timeout = 10000
                Response = Request.GetResponse()
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

End Namespace


