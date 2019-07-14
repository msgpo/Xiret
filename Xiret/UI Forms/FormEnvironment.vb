'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormEnvironment.vb
'  Created by David S on 06.07.2016
'  Updated on 04.07.2019 - DS (Cleanup)

Imports Xiret.Base.Helpers

Public Class FormEnvironment

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Me.Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormEnvironment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub
#End Region

#Region "Load Event"

    Private Sub FormEnvironment_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetEnvironmentThemeAccent()

        If OSHWinIsServer() Then : lbMessage.Text = "This software does not support Windows Server. The application will now exit."
        Else : lbMessage.Text = "Whoa there, Grandma. This program requires Windows Vista or later to function correctly. The application will now exit."
        End If

    End Sub

#End Region

#Region "Theme"
    Private Sub SetEnvironmentThemeAccent()

        pnlSplit.BackColor = GlobalThemeColor
        cmdOkay.ForeColor = GlobalThemeColor
        llWebsite.LinkColor = GlobalThemeColor

        'Apply border
        If BoolThemeApplyBorder Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If

    End Sub
#End Region
#Region "Buttons"

    Private Sub cmdOkay_Click(sender As Object, e As EventArgs) Handles cmdOkay.Click
        Close()
    End Sub

#End Region
#Region "Links"

    Private Sub llWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llWebsite.LinkClicked
        Process.Start("https://forums.mydigitallife.net/threads/xiret-experience-index-returns.68890/")
    End Sub

#End Region

End Class