'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  Fade.vb
'  Created by David S on 26.07.2019

Imports System.Threading

Namespace Core.Animation

    Public Class Fade

#Region "Main"
        Public Shared Sub FadeIn(Form As Form)

            Try
                For FIn = 0.0 To 1.0 Step 0.2
                    Form.Opacity = FIn
                    Form.Refresh()
                    Thread.Sleep(10)
                Next
            Catch
                Form.Opacity = 1.0
            End Try

        End Sub
        Public Shared Sub FadeOut(Form As Form)

            Try
                For FOut = 1.0 To 0.0 Step -0.2
                    Form.Opacity = FOut
                    Form.Refresh()
                    Thread.Sleep(10)
                Next
            Catch
                Form.Close()
            End Try

        End Sub
#End Region
#Region "Child"
        Public Shared Sub FadeBehindChild(Form As Form)
            Try
                For FOut = 1.0 To 0.4 Step -0.2
                    Form.Opacity = FOut
                    Form.Refresh()
                    Thread.Sleep(10)
                Next
            Catch
                Form.Opacity = 0.4
            End Try
        End Sub
        Public Shared Sub RefadeIn(Form As Form)
            Try
                If Form.Opacity <> 0.4 Then
                    For FIn = 0.4 To 1.0 Step 0.2
                        Form.Opacity = FIn
                        Form.Refresh()
                        Thread.Sleep(10)
                    Next
                End If
            Catch
                Form.Opacity = 1.0
            End Try
        End Sub
#End Region

    End Class

End Namespace


