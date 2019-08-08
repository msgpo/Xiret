'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormWarn.vb
'  Created by David S on 06.07.2016
'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Public Class FormWarn

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormWarn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormWarn_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetWarnThemeAccent()
    End Sub

#End Region

#Region "Theme"
    Private Sub SetWarnThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        CmdOkay.ForeColor = Settings.ThemeColor

        llWebsite.LinkColor = Settings.ThemeColor

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"

    Private Sub CmdOkay_Click(sender As Object, e As EventArgs) Handles CmdOkay.Click
        Close()
    End Sub

#End Region
#Region "Linklabel Event Handlers"

    Private Sub LlWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llWebsite.LinkClicked
        Process.Start("https://forums.mydigitallife.net/threads/xiret-experience-index-returns.68890/")
    End Sub

#End Region

End Class