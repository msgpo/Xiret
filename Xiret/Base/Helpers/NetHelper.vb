'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  NetHelper.vb
'  Created by David S
'  Updated on 08.07.2019 - DS (Cleanup)

Imports System.Net

Namespace Base.Helpers

    Module NetHelper

        Public Function NHIsSiteAvailable(ByVal WebAddress As String) As Boolean

            Try
                Dim req As WebRequest
                Dim res As WebResponse
                req = WebRequest.Create(WebAddress)
                req.Timeout = 10000
                res = req.GetResponse()
                Return True
            Catch
                Return False
            End Try

        End Function

    End Module

End Namespace


