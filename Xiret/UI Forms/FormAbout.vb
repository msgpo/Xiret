'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormAbout.vb
'  Created by David S on 20.03.2016
'  Updated on 10.07.2019 - DS (Added Github link to project source)

Imports System.Threading

Friend Class FormAbout

#Region "Frame Interaction"
    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove
        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If
    End Sub
#End Region
#Region "KeyDown Event"
    Private Sub FormAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub
#End Region
#Region "Frame Buttons"
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
#End Region

#Region "Load Event"
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        SetAboutThemeAccent()
        lbName.Text = "Xiret " & Application.ProductVersion & " RC2"
    End Sub

#End Region
#Region "Shown Event"
    Private Sub FormAbout_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
    Private Sub FormAbout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
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
    Private Sub SetAboutThemeAccent()
        'Split colour
        pnlSplit.BackColor = GlobalThemeColor
        'Change link colours
        For Each c As Control In pnlMain.Controls
            If TypeOf c Is LinkLabel Then DirectCast(c, LinkLabel).LinkColor = GlobalThemeColor
        Next
        'Apply border colour
        If BoolThemeApplyBorder Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If
    End Sub
#End Region
#Region "Links"
    Private Sub llBitmight_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llBitmight.LinkClicked
        Process.Start(StringBitmightURL)
    End Sub
    Private Sub llSOurce_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSOurce.LinkClicked
        Process.Start("https://github.com/K4onashi/Xiret")
    End Sub
    Private Sub llForum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llForum.LinkClicked
        Process.Start("https://forums.mydigitallife.net/threads/xiret-experience-index-returns.68890/")
    End Sub
    Private Sub llContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llContact.LinkClicked
        Dim str As String = "Xiret version " & Application.ProductVersion
        Process.Start("mailto:support@bitmight.uk?subject=Xiret Bug Report&body=" & vbCrLf & str)
    End Sub
    Private Sub llDonate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llDonate.LinkClicked
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CUZ2TP495UZZS")
    End Sub
    Private Sub llFlaticon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFlaticon.LinkClicked
        Process.Start("http://www.flaticon.com")
    End Sub
    Private Sub llVectors_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llVectors.LinkClicked
        Process.Start("https://www.flaticon.com/authors/vectors-market")
    End Sub
#End Region

End Class