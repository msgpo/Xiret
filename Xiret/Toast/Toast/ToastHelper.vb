'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  ToastHelper.vb
'  Created by David S

Imports System.Linq

Module ToastHelper

#Region "Toast Manager"

    Public StringMessage As String = Nothing

    Public TypeIs As ToastType

    Public toastQuickCancel As Boolean = False

    Public Sub SendToastToScreen(StringToSend As String, TypeToSend As ToastType)

        'Set string variables passed
        StringMessage = StringToSend.ToString
        TypeIs = TypeToSend

        Try
            If Application.OpenForms().OfType(Of Toast).Any Then
                toastQuickCancel = True
                Toast.Close()
                Toast.Show()
            Else
                Toast.Show()
            End If
        Catch
        End Try

        toastQuickCancel = False

    End Sub

#End Region

End Module


