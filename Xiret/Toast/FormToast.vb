'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  Toast.vb
'  Created by David S on 20.03.2016
'  Updated on 31.07.2019 - DS (Update bool value, update PreFilterMessage)
'  Updated on 07.08.2019 - DS (Increment PxFromEdge 6 > 10, cleanup)

Imports Core.Animation
Imports Core.Animation.Enums
Imports Core.Helpers

Public Class FormToast
    Implements IMessageFilter

#Region "Variables"

    Private MouseInForm As Boolean = False
    Private Int As Integer = 0

#End Region

#Region "PreMessageFilter"

    Private Function PreFilterMessage(ByRef ID As Message) As Boolean _
        Implements IMessageFilter.PreFilterMessage

        If ID.Msg = Integers.WM_MOUSELEAVE OrElse ID.Msg = Integers.WM_MOUSEMOVE Then
            Dim OnClient As Boolean = ClientRectangle.Contains(PointToClient(MousePosition))
            If OnClient Then
                If Not MouseInForm Then
                    OnMouseEnter(Nothing)
                End If
                MouseInForm = True
            Else
                If MouseInForm Then
                    OnMouseLeave(Nothing)
                End If
                MouseInForm = False
            End If
        End If

        Return Nothing

    End Function

#End Region

#Region "Button Handles"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

#End Region
#Region "Shown Event"

    Private Sub Toast_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Load Handle"

    Private Sub Toast_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If OSHelper.IsWinTen Then
            Composition.BlurWinForm(Me, AccentState.ACCENT_ENABLE_BLURBEHIND, WindowCompositionAttribute.WCA_ACCENT_POLICY)
        End If

        TopMost = True
        BringToFront()

    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set opactity
        Opacity = 0

        'Hide the close button
        cmdClose.Hide()

        'Add mouseover message override
        Application.AddMessageFilter(Me)

        'Set toast type passed
        Select Case ToastAlert.AlertType
            Case ToastType.IsError
                lbTitle.Text = "Error"
                GProgressBar.ProgressColor = Color.FromArgb(232, 17, 35)
                BackColor = Color.FromArgb(232, 17, 35)
            Case ToastType.IsInformational
                lbTitle.Text = "Information"
                GProgressBar.ProgressColor = Color.FromArgb(120, 120, 120)
                BackColor = Color.FromArgb(120, 120, 120)
            Case ToastType.IsWarning
                lbTitle.Text = "Warning"
                GProgressBar.ProgressColor = Color.Tomato
                BackColor = Color.Tomato
            Case ToastType.IsDebug
                lbTitle.Text = "Debug"
                GProgressBar.ProgressColor = Color.BurlyWood
                BackColor = Color.BurlyWood
        End Select

        lbMessage.Text = ToastAlert.AlertMessage
        TopMost = True

        RespectTaskbar()

    End Sub

#End Region
#Region "Closed Handle"

    Private Sub Toast_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'Remove PreMessageFilter
        Application.RemoveMessageFilter(Me)

        If Not ToastAlert.BoolCancelCurrentToast Then
            Fade.FadeOut(Me)
        End If


    End Sub

#End Region

#Region "RespectTaskbar"

    Private Sub RespectTaskbar()

        Dim PxFromEdge As Integer = 10
        Dim Width As Integer = MyBase.Width
        Dim Height As Integer = MyBase.Height
        Dim Monitor As Screen = Screen.PrimaryScreen

        Select Case Taskbar.GetLocation()
            Case TaskBarLocation.Bottom
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.WorkingArea.Height - Height - PxFromEdge)
            Case TaskBarLocation.Left
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.Bounds.Height - Height - PxFromEdge)
            Case TaskBarLocation.Top
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.Bounds.Height - Height - PxFromEdge)
            Case TaskBarLocation.Right
                Location = New Point(Monitor.WorkingArea.Width - Width - PxFromEdge, Monitor.Bounds.Height - Height - PxFromEdge)
            Case Else
                'Assume standard position?
                Location = New Point(Monitor.Bounds.Width - Width - PxFromEdge, Monitor.WorkingArea.Height - Height - PxFromEdge)
        End Select

    End Sub

#End Region

#Region "Timer"

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles tDraw.Tick

        If Int = 20000 Then
            Close()
            Exit Sub
        Else
            Int += 40
            GProgressBar.Value = CInt(Int / 100)
        End If

    End Sub

    Private Sub Toast_MouseDetect(sender As Object, e As EventArgs) Handles Me.MouseEnter, Me.MouseLeave

        If tDraw.Enabled = True Then
            tDraw.Stop()
            GProgressBar.Hide()
            cmdClose.Show()
        Else
            tDraw.Start()
            GProgressBar.Show()
            cmdClose.Hide()
        End If

    End Sub

#End Region

End Class