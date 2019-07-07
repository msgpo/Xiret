'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormSystem.vb
'  Created by David S on 07.02.2019
'  Updated on 04.07.2019 - DS (Cleanup)

Imports System.Threading

Imports Xiret.Core.Helpers

Public Class FormSystem

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub

#End Region
#Region "Frame Buttons"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
#End Region

#Region "Load Event"

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Opacity = 0

        'Set form theme
        SetCleanupThemeAccent()

        lbOpSys.Text = OSHGetName()
        lbBitness.Text = OSHGetBitness()
        lbServicePack.Text = OSHGetServicepack()

        lbKernel.Text = OSHKernelVersion.FileVersion
        lbWinsat.Text = OSHWinsatVersion.ProductVersion
        lbApi.Text = OSHWinsatApiVersion.ProductVersion

        lbUptime.Text = OSHWinGetUptime()

    End Sub

#End Region
#Region "Shown Event"

    Private Sub FormSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown

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
#Region "Closed Event"

    Private Sub FormSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try
            For FadeOut = 1.0 To 0.0 Step -0.2
                Opacity = FadeOut
                Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Close()
        End Try

    End Sub

#End Region

#Region "Theme"
    Private Sub SetCleanupThemeAccent()

        pnlSplit.BackColor = GlobalThemeColor

        cmdrefresh.ForeColor = GlobalThemeColor

        If (BoolThemeApplyBorder) Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If

    End Sub

#End Region

#Region "Refresh Button"
    Private Sub cmdrefresh_Click(sender As Object, e As EventArgs) Handles cmdrefresh.Click
        lbUptime.Text = OSHWinGetUptime()
    End Sub
#End Region

End Class