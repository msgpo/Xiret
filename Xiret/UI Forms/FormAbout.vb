'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormAbout.vb
'  Created by David S on 20.03.2016
'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports Core.Animation

Friend Class FormAbout

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

#End Region

#Region "WndProc"
    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove
        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If
    End Sub
#End Region
#Region "KeyDown Events"
    Private Sub FormAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
#End Region
#Region "Frame Buttons"
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub
#End Region

#Region "Theme"
    Private Sub SetAboutThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        For Each c As Control In pnlMain.Controls
            If TypeOf c Is LinkLabel Then DirectCast(c, LinkLabel).LinkColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Load Event Handler"
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        Opacity = 0
        SetAboutThemeAccent()
        lbName.Text = "Xiret " & Application.ProductVersion & " RC2"

    End Sub

#End Region
#Region "Shown Event Handler"
    Private Sub FormAbout_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub
#End Region
#Region "Closed Event Handler"
    Private Sub FormAbout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Linklabel Event Handlers"
    Private Sub LlBitmight_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llBitmight.LinkClicked
        Process.Start(Strings.StringBitmightUrl)
    End Sub
    Private Sub LlSOurce_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSOurce.LinkClicked
        Process.Start("https://github.com/K4onashi/Xiret")
    End Sub
    Private Sub LlForum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llForum.LinkClicked
        Process.Start("https://forums.mydigitallife.net/threads/xiret-experience-index-returns.68890/")
    End Sub
    Private Sub LlContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llContact.LinkClicked
        Dim str As String = "Xiret version " & Application.ProductVersion
        Process.Start("mailto:support@bitmight.uk?subject=Xiret Bug Report&body=" & vbCrLf & str)
    End Sub
    Private Sub LlDonate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llDonate.LinkClicked
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CUZ2TP495UZZS")
    End Sub
    Private Sub LlFlaticon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFlaticon.LinkClicked
        Process.Start("http://www.flaticon.com")
    End Sub
    Private Sub LlVectors_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llVectors.LinkClicked
        Process.Start("https://www.flaticon.com/authors/vectors-market")
    End Sub
#End Region

End Class