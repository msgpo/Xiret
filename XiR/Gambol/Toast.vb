'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  Toast.vb
'  Created by David S on 20.03.2016
'  Updated on 08.07.2019 - DS (UI enhancements)

#Region "Directives"



#End Region

Imports System.Threading

Public Class Toast
    Implements IMessageFilter

#Region "Variables"

    Private MouseInForm As Boolean = False
    Private Int As Integer = 0

#End Region

#Region "PreMessageFilter"

    Private Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage

        If m.Msg = WM_MOUSELEAVE OrElse m.Msg = WM_MOUSEMOVE Then
            'WM_MOUSELEAVE does not provide the mouse location, use MousePosition.
            Dim hit As Boolean = ClientRectangle.Contains(PointToClient(MousePosition))
            If hit Then
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
#Region "Window Location"

    Private Sub SetLocationOfWindow()

        Dim N As Integer = 6 '//Magic number for bounds - W or H (Edge Spacing)
        Dim W As Integer = Width '//Width of Form
        Dim H As Integer = Height '//Height of Form
        Dim LCD As Screen = Screen.PrimaryScreen

        Select Case GetTaskbarLocation() '//Gambol/Toast/DetectTaskBar
            Case TaskBarLocation.Bottom
                Location = New Point(LCD.Bounds.Width - W - N, LCD.WorkingArea.Height - H - N)
            Case TaskBarLocation.Left
                Location = New Point(LCD.Bounds.Width - W - N, LCD.Bounds.Height - H - N)
            Case TaskBarLocation.Top
                Location = New Point(LCD.Bounds.Width - W - N, LCD.Bounds.Height - H - N)
            Case TaskBarLocation.Right
                Location = New Point(LCD.WorkingArea.Width - W - N, LCD.Bounds.Height - H - N)
            Case Else
                'Assume standard position in WorkingArea?
                Location = New Point(LCD.Bounds.Width - W - N, LCD.WorkingArea.Height - H - N)
        End Select


    End Sub

#End Region

#Region "Button Handles"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

#End Region
#Region "Shown Event"

    Private Sub Toast_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            For FadeIn = 0.0 To 1.0 Step 0.2
                Opacity = FadeIn
                Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Opacity = 1.0
        End Try
    End Sub

#End Region
#Region "Load Handle"

    Private Sub Toast_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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
        Select Case TypeIs
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

        'Set message text passed
        lbMessage.Text = StringMessage

        'Set on top of other windows
        TopMost = True

        'Set location in relation to taskbar
        SetLocationOfWindow()

    End Sub

#End Region
#Region "Closed Handle"

    Private Sub xNotify_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'Remove PreMessageFilter
        Application.RemoveMessageFilter(Me)

        If toastQuickCancel = True Then
            Exit Sub
        Else
            If Not toastQuickCancel Then
                Try
                    For FadeOut = 1.0 To 0.0 Step -0.2
                        Opacity = FadeOut
                        Refresh()
                        Thread.Sleep(10)
                    Next
                Catch
                    Close()
                End Try
            End If
        End If

    End Sub

#End Region

#Region "Timer"

    Private Sub tDraw_Tick(sender As Object, e As EventArgs) Handles tDraw.Tick

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