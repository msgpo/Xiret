'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormCleanup.vb
'  Created by David S on 01.11.2018
'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports System.IO

Imports Xiret.Core.Animation

Imports Xiret.Controls

Public Class FormCleanup

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetCleanupThemeAccent()
    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove, PanHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormCleanup_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

#Region "Shown Event Handler"

    Private Sub FormCleanup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormCleanup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetCleanupThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        CbxResetWinsat.CheckedColor = Settings.ThemeColor
        CbxPurgeSettings.CheckedColor = Settings.ThemeColor

        CmdReset.ForeColor = Settings.ThemeColor
        CmdPurge.ForeColor = Settings.ThemeColor

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdReset_Click(sender As Object, e As EventArgs) Handles CmdReset.Click

        'Delete system scores
        BatchRemoveFiles("*.xml", Directories.DirWinsatDatastore)
        'Delete winsat log
        BatchRemoveFiles("*.log", Directories.DirWinsat)
        'Restart application
        Application.Restart()

    End Sub
    Private Sub CmdPurge_Click(sender As Object, e As EventArgs) Handles CmdPurge.Click

        'First off, we want no new settings being created on exit.
        Booleans.BoolCreateFilepath = False

        'Delete updater path, settings, xiret log and imgur links.
        BatchRemoveFiles("*.*", Directories.DirAppData)

        'Delete appdata folder
        If Directory.Exists(Directories.DirAppData) Then : Directory.Delete(Directories.DirAppData)
        End If

        'Exit application
        Application.Exit()

    End Sub
#End Region
#Region "Checkbox Event Handlers"

    Private Sub CbxResetWinsat_CheckedChanged(sender As Object, e As EventArgs) Handles CbxResetWinsat.CheckedChanged
        If CType(sender, GambolCheckbox).Checked Then
            CmdReset.Enabled = True
            PanPurge.Enabled = False
        Else
            CmdReset.Enabled = False
            PanPurge.Enabled = True
        End If
    End Sub

    Private Sub CbxPurgeSettings_CheckedChanged(sender As Object, e As EventArgs) Handles CbxPurgeSettings.CheckedChanged

        If CType(sender, GambolCheckbox).Checked Then : CmdPurge.Enabled = True : PanReset.Enabled = False
        Else : CmdPurge.Enabled = False : PanReset.Enabled = True
        End If

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

#Region "Routines"

    Private Sub BatchRemoveFiles(FileFlags As String, ByVal FileDirectory As String)

        Dim Array() As String
        Array = Directory.GetFileSystemEntries(FileDirectory, FileFlags)
        For Each Element As String In Array
            If Not Directory.Exists(Element) Then
                File.Delete(Path.Combine(FileDirectory, Path.GetFileName(Element)))
            End If
        Next

    End Sub

#End Region

End Class