'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormUpdate.vb
'  Created by David S on 01.11.2018
'  Updated on 29.07.2019 - DS (Migrating to new system)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'  This is a WIP

Imports Core.Animation
Public Class FormUpdate

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

    Private Sub FormUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set opacity
        Opacity = 0
        'Set theme color
        SetThemeAccent()

        If Booleans.BoolMissingUpdate Then
            lbInfo.Text = "A new version of Xiret is ready for download."
            lbType.Text = Updater.Type
        Else
            lbInfo.Text = "No update available."
            lbType.Text = "None"
        End If

        lbCurrent.Text = Updater.LocalVersion
        lbServer.Text = Updater.ServerVersion & " (" & Updater.ReleaseDate & ")"

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormUpdate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"

    Private Sub SetThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        llChangelog.LinkColor = Settings.ThemeColor

        For Each c As Control In tlpButtons.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

#End Region
#Region "Linklabel Event Handlers"

    Private Sub LlChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llChangelog.LinkClicked
        Process.Start("https://www.bitmight.uk/software/xiret/changelog.txt")
    End Sub

#End Region

End Class