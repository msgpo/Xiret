'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormUpdate.vb
'  Created by David S on 01.11.2018
'  Updated on 04.07.2019 - DS (Added tablelayoutpanel, cleanup)
'  This is a WIP

Imports System.Threading

Public Class FormUpdate

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"

    Private Sub FormUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event"

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load

        Opacity = 0

        SetThemeAccent()

        If CheckNewerVersion() Then : lbInfo.Text = "A new version of Xiret is ready for download." : lbType.Text = UpdateType
        Else : lbInfo.Text = "No update available." : lbType.Text = "None"
        End If

        lbCurrent.Text = UpdateLocalVersion
        lbServer.Text = UpdateServerVersion & " (" & UpdateReleaseDate & ")"

    End Sub

#End Region
#Region "Shown Event"

    Private Sub FormUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown

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

    Private Sub FormUpdate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

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

    Private Sub SetThemeAccent()

        pnlSplit.BackColor = GlobalThemeColor

        llChangelog.LinkColor = GlobalThemeColor

        cmdCancel.ForeColor = GlobalThemeColor
        cmdUpdate.ForeColor = GlobalThemeColor

        If (BoolThemeApplyBorder) Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If

    End Sub

#End Region

#Region "Buttons"

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

#End Region
#Region "Links"

    Private Sub llChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llChangelog.LinkClicked
        Process.Start("https://www.bitmight.uk/software/xiret/changelog.txt")
    End Sub

#End Region

End Class