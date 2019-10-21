'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  ToastHelper.vb
'  Created by David S
'  Updated on 14.07.2019 - DS (Integrate ToastType enum, update variables)
'  Updated on 31.07.2019 - DS (General cleanup and improvements)

Imports System.Linq

Friend Class ToastAlert

    Friend Shared AlertMessage As String = ""
    Friend Shared AlertType As ToastType
    Friend Shared BoolCancelCurrentToast As Boolean = False

#Region "Routines"
    Friend Shared Sub Show(AlertText As String, Type As ToastType)

        AlertMessage = AlertText
        AlertType = Type

        Try
            If Application.OpenForms().OfType(Of FormToast).Any Then
                BoolCancelCurrentToast = True
                FormToast.Close()
                FormToast.Show()
            Else
                BoolCancelCurrentToast = False
                FormToast.Show()
            End If
        Catch
        End Try

        BoolCancelCurrentToast = False

    End Sub
#End Region

End Class


