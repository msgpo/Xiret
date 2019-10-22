'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormAckn.vb
'  Created by David S on 22.10.2019

Imports Xiret.Core.Animation

Public Class FormAckn

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetAcknThemeAccent()
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
    Private Sub SetAcknThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpTop.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanMain.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

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
#Region "Links, top"

    Private Sub LnkVectorsGraph_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkVectorsGraph.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/bar-chart_235172")
    End Sub
    Private Sub LnkFreepikWarn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFreepikInfo.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/info-button_64494#term=information&page=1&position=74")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFreepikWarn.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/danger_272289#term=warning&page=1&position=13")
    End Sub
    Private Sub LnkSmashicons_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSmashiconsError.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/error_149690")
    End Sub
    Private Sub LnkSmashiconsSettings_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSmashiconsSettings.LinkClicked
        Process.Start("https://www.flaticon.com/free-icon/settings_149295#term=settings&page=1&position=5")
    End Sub
#End Region
#Region "Links, bottom"

    Private Sub LnkBitmight_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkBitmight.LinkClicked
        Process.Start(Strings.StringBitmightUrl)
    End Sub
    Private Sub LnkMdl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMdl.LinkClicked
        Process.Start("https://forums.mydigitallife.net/")
    End Sub

    Private Sub LnkMajorgeeks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMajorgeeks.LinkClicked
        Process.Start("https://www.majorgeeks.com/")
    End Sub

    Private Sub LnkSoftpedia_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSoftpedia.LinkClicked
        Process.Start("https://www.softpedia.com/")
    End Sub

#End Region

End Class