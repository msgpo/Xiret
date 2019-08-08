'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormHotfix.vb
'  Created by David S on 25.07.2019
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports System.IO
Imports System.Threading.Tasks

Imports Core.Animation
Imports Core.Helpers

Imports Gambol.Controls

Public Class FormHotfix

    Private ReadOnly StringTemp As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp\Windows6.1-KB2687862.msu")
    Private exitcode As Integer = 0

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
    Private Sub FormHotfix_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region
#Region "Frame Buttons"
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        If Booleans.BoolRestartApp Then
            Application.Restart()
        Else
            Close()
        End If
    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set opacity
        Opacity = 0
        'Set form theme
        SetHotfixThemeAccent()

        cbxResetWinsat.Hide()

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormHotfix_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormHotfix_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetHotfixThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        llInfo.LinkColor = Settings.ThemeColor
        pbrPerc.ProgressColor = Settings.ThemeColor
        cbxResetWinsat.CheckedColor = Settings.ThemeColor

        For Each c As Control In tlpBottom.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Routines"

    Private Sub ValidateAndInstall()

        Dim DoInstall As Task = Nothing

        'Validate x64 download success
        If OSHelper.IsOS64Bit() Then
            If CryptoHelper.GetSha256FromFile(StringTemp) = Strings.StringHotfixChecksum64 Then
                lbInfo.Text = "Validation success. Installing KB2687862..."
                DoInstall = Task.Factory.StartNew(Sub() InstallKB())
            Else
                File.Delete(StringTemp)
                lbInfo.Text = "File validation failure. Download was deleted."
            End If
        Else
            'Validate x86 download success
            If CryptoHelper.GetSha256FromFile(StringTemp) = Strings.StringHotfixChecksum86 Then
                lbInfo.Text = "Validation success. Installing KB2687862..."
                DoInstall = Task.Factory.StartNew(Sub() InstallKB())
            Else
                File.Delete(StringTemp)
                lbInfo.Text = "File validation failure. Download was deleted."
            End If
        End If

        InstallFinished()

    End Sub
    Private Sub InstallKB()
        exitcode = FileHelper.InstallMsu(StringTemp)
    End Sub

    Private Sub InstallFinished()

        'Check exit code from install
        FormMain.HotfixAvailableToolStripMenuItem.Visible = False

        If exitcode = 0 Or exitcode = 1 Then
            Booleans.BoolRestartApp = True
            lbInfo.Text = "Hotfix installed. Application will restart."
            CmdCancel.Enabled = False
            CmdInstall.Enabled = True
            CmdInstall.Text = "Restart"
            pbrPerc.Value = 0
        Else
            Booleans.BoolRestartWin = True
            lbInfo.Text = "Hotfix installed. A system restart is required."
            CmdClose.Enabled = False
            CmdCancel.Enabled = False
            CmdInstall.Enabled = False
            CmdInstall.Text = "Restart"
            pbrPerc.Value = 0
            cbxResetWinsat.Show()
        End If

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdInstall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdInstall.Click

        If Booleans.BoolRestartWin Then
            Process.Start("shutdown", "-r -t 00")
        Else
            If Booleans.BoolRestartApp Then
                Application.Restart()
            Else
                lbInfo.Text = "Working..."
                'Disable button from clicking
                CType(sender, Button).Enabled = False

                'Determine bitness for appropriate hotfix
                If OSHelper.IsOS64Bit() Then
                    File.WriteAllBytes(StringTemp, FileHelper.Hotfix64)
                Else
                    File.WriteAllBytes(StringTemp, FileHelper.Hotfix86)
                End If

                ValidateAndInstall()

            End If
        End If

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
    End Sub

#End Region
#Region "LinkLabel Event Handlers"

    Private Sub LlInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llInfo.LinkClicked
        Process.Start("https://support.microsoft.com/help/2687862")
    End Sub

#End Region
#Region "Checkbox Event Handlers"

    Private Sub CbxResetWinsat_CheckedChanged(sender As Object, e As EventArgs) Handles cbxResetWinsat.CheckedChanged

        If CType(sender, GambolCheckbox).Checked Then
            CmdInstall.Enabled = True
        Else
            CmdInstall.Enabled = False
        End If

    End Sub

#End Region

End Class