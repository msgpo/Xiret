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
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'  Updated on 07.10.2019 - DS (Cleanup)

Imports Xiret.Core.Animation

Friend Class FormAbout

    Private TheCatReturns As Boolean = False
    Private ReadOnly Version As String = "Build " & Program.XiretBuild & " (V" & Application.ProductVersion & ") - " & Program.ProductChannel

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetAboutThemeAccent()
    End Sub

#End Region

#Region "WndProc"
    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove, PanHead.MouseMove
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

        PanSplit.BackColor = Settings.ThemeColor

        For Each Ctrl As Control In PanMain.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Load Event Handler"
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabBuild.Text = Version
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

#Region "Picturebox Event Handler"
    Private Sub PbxHead_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region
#Region "Linklabel Event Handlers"
    Private Sub LnkForum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkForum.LinkClicked
        Process.Start("https://forums.mydigitallife.net/threads/xiret-experience-index-returns.68890/")
    End Sub
    Private Sub LnkContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkContact.LinkClicked
        Dim str As String = "Xiret build: " & Program.XiretBuild
        Process.Start("mailto:support@bitmight.uk?subject=" & "Software enquiry or bug report&body=" & vbCrLf & str)
    End Sub
    Private Sub LnkSource_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSource.LinkClicked
        Process.Start("https://github.com/K4onashi/Xiret")
    End Sub
    Private Sub LnkDonate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkDonate.LinkClicked
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CUZ2TP495UZZS")
    End Sub
    Private Sub LnkBitmight_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkBitmight.LinkClicked
        Process.Start(Strings.StringBitmightUrl)
    End Sub
    Private Sub LnkMajorgeeks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMajorgeeks.LinkClicked
        Process.Start("https://www.majorgeeks.com/")
    End Sub
    Private Sub LnkFlaticon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFlaticon.LinkClicked
        Process.Start("http://www.flaticon.com")
    End Sub
    Private Sub LnkVectors_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkVectors.LinkClicked
        Process.Start("https://www.flaticon.com/authors/vectors-market")
    End Sub
#End Region

#Region "Neko no Ongaeshi"

    Private Sub PbxLogo_Click(sender As Object, e As EventArgs) Handles PbxLogo.Click
        If TheCatReturns Then
            TheCatReturns = False
            CType(sender, PictureBox).Image = My.Resources.icon64px
            LabAppName.Text = "Scratch, scratch"
        Else
            TheCatReturns = True
            CType(sender, PictureBox).Image = My.Resources.mow
            LabAppName.Text = "Purrrrrrrrrrr"
        End If
    End Sub

    Private Sub PbxLogo_MouseEnter(sender As Object, e As EventArgs) Handles PbxLogo.MouseEnter
        If TheCatReturns Then
            LabAppName.Text = "Purrrrrrrrrrr"
        Else
            LabAppName.Text = "Scratch, scratch"
        End If
    End Sub

    Private Sub PbxLogo_MouseLeave(sender As Object, e As EventArgs) Handles PbxLogo.MouseLeave
        LabAppName.Text = "Xiret❷"
    End Sub

#End Region

End Class