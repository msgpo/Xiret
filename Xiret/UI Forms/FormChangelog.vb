'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormChangelog.vb
'  Created by David S on 20.06.2019
'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports Core.Animation

Public Class FormChangelog

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, tlpHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormChangelog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

#Region "Load Event Handler"

    Private Sub FormChangelog_Load(sender As Object, e As EventArgs) Handles Me.Load

        Opacity = 0
        SetChangelogThemeAccent()

        rtbChanges.Rtf = My.Resources.changelog

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormChangelog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormChangelog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Fade.FadeOut(Me)

    End Sub

#End Region

#Region "Theme"
    Private Sub SetChangelogThemeAccent()

        'Split colour
        pnlSplit.BackColor = Settings.ThemeColor

        'Apply border colour
        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Deprecated"

    'Private Sub cmdFull_MouseEnter(sender As Object, e As EventArgs) Handles cmdFull.MouseEnter
    '    lbGlobe.Text = "" 'MDL Assets E774 (Globe)
    '    rtbURL.Text = URL
    '    rtbURL.Select(rtbURL.TextLength - 52, 8)
    '    rtbURL.SelectionColor = Color.FromArgb(18, 180, 0)
    '    rtbURL.SelectionFont = New Font("Segoe UI Semibold", 10)
    '    rtbURL.Select(rtbURL.TextLength - 28, 28)
    '    rtbURL.SelectionColor = Color.FromArgb(180, 180, 180)

    'End Sub

    'Private Sub cmdFull_MouseLeave(sender As Object, e As EventArgs) Handles cmdFull.MouseLeave
    '    lbGlobe.Text = ""
    '    rtbURL.Text = ""
    'End Sub

#End Region

End Class