﻿'Xiret - Experience Index UI License
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
'  Updated on 13.08.2019 - DS (Temporarily disabled BlurWinForm whilst some issues are corrected)

Imports Xiret.Core.Animation

Public Class FormToast
    Implements IMessageFilter

    Private ReadOnly ColorInfo As Color = Color.FromArgb(0, 120, 215)
    Private ReadOnly ColorWarning As Color = Color.FromArgb(255, 185, 0)
    Private ReadOnly ColorError As Color = Color.FromArgb(240, 58, 23)

    Private MouseInForm As Boolean = False
    Private Int As Integer = 0

#Region "Overriden Properties"

    Protected Overloads Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property

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

#Region "Button Event Handlers"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub Toast_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Load Handle"

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This works great with different DPI scaling
        CmdClose.Location = New Point(PanMain.Right - CmdClose.Width, 0)

        'Set opactity
        Opacity = 0

        'Hide the close button
        CmdClose.Hide()

        'Add mouseover message override
        Application.AddMessageFilter(Me)

        'Set toast type passed
        Select Case ToastAlert.AlertType
            Case ToastType.IsError
                PbxTypeImage.BackgroundImage = My.Resources.imgtoasterror
                LabTitle.Text = "Error"
                GProgressBar.ProgressColor = ColorError
                BackColor = ColorError
            Case ToastType.IsInformational
                PbxTypeImage.BackgroundImage = My.Resources.imgtoastinfo
                LabTitle.Text = "Information"
                GProgressBar.ProgressColor = ColorInfo
                BackColor = ColorInfo
            Case ToastType.IsWarning
                PbxTypeImage.BackgroundImage = My.Resources.imgtoastwarn
                LabTitle.Text = "Warning"
                GProgressBar.ProgressColor = ColorWarning
                BackColor = ColorWarning
        End Select

        LabMessage.Text = ToastAlert.AlertMessage
        TopMost = True

        RespectTaskbar()

        TopMost = True
        BringToFront()

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

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles TimerTick.Tick

        If Int = 20000 Then
            Close()
            Exit Sub
        Else
            Int += 40
            GProgressBar.Value = CInt(Int / 100)
        End If

    End Sub

    Private Sub Toast_MouseDetect(sender As Object, e As EventArgs) Handles Me.MouseEnter, Me.MouseLeave

        If TimerTick.Enabled = True Then
            TimerTick.Stop()
            GProgressBar.Hide()
            CmdClose.Show()
        Else
            TimerTick.Start()
            GProgressBar.Show()
            CmdClose.Hide()
        End If

    End Sub

#End Region

End Class