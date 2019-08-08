'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormFont.vb
'  Created by David S on - I've forgotten
'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports Core.Animation
Imports Core.Fonts

Public Class FormFont

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
    Private Sub FormFont_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormFont_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set opacity
        Opacity = 0
        'Set form theme
        SetFontThemeAccent()

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormFont_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormFont_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetFontThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        For Each c As Control In tlpBottom.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdInstall_Click(sender As Object, e As EventArgs) Handles cmdInstall.Click

        CType(sender, Button).Enabled = False

        Dim i As Integer = FontInstaller.InstallFont(FontInstaller.SegoeUISemiBoldResource, "Segoe UI Semibold (TrueType)", "seguisb.ttf", FontInstaller.FileFontFallback)

        Select Case i
            Case 0
                lbInfo.Text = FontInstaller.FontInstallerError
            Case 1
                lbInfo.Text = "Font installed successfully. You may now close this window."
                cmdCancel.Text = "Close"
            Case 2
                lbInfo.Text = "'Couldn't install the seguisb.ttf font. Please install it manually (placed on desktop)."
            Case 3
                lbInfo.Text = "'Could not write seguisb.ttf to disk."
        End Select

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

#End Region

End Class