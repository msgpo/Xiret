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
'  Updated on 21.10.2019 - DS (Stability improvements, quality of life changes, threading changes, better error output)

Imports System.IO
Imports System.Threading.Tasks
Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers

Public Class FormHotfix

    Private ReadOnly StringTempPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp\Windows6.1-KB2687862.msu")
    Private ReadOnly FileHotfix86 As Byte() = My.Resources.Windows6_1_KB2687862_x86
    Private ReadOnly FileHotfix64 As Byte() = My.Resources.Windows6_1_KB2687862_x64

    Private ExitCodeReturn As Integer = -1

    Private RestartWin As Boolean = False
    Private InstallFailed As Boolean = False

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetHotfixThemeAccent()
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
    Private Sub FormHotfix_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        PbxLoad.Hide()

        If OSHelper.IsWinSeven Then
            CmdInstall.Enabled = True
        Else
            LabHead.Text = "Support (Disabled on this OS)"
            CmdInstall.Enabled = False
        End If

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

        PanSplit.BackColor = Settings.ThemeColor
        LnkHotfix.LinkColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpBottom.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdInstall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdInstall.Click

        PbxLoad.Show()

        If RestartWin Then
            Process.Start("shutdown", "-r -t 00")
        Else
            'Disable sender
            CmdInstall.Enabled = False
            CmdClose.Enabled = False
            CmdCancel.Enabled = False

            LabDownload.Text = "Saving hotfix to disk..."

            ''Determine bitness for appropriate hotfix and save to disk
            If OSHelper.IsWindows64Bit() Then
                File.WriteAllBytes(StringTempPath, FileHotfix64)
            Else
                File.WriteAllBytes(StringTempPath, FileHotfix86)
            End If

            If File.Exists(StringTempPath) Then
                'Install hotfix to the machine
                LabDownload.Text = "Installing KB2687862..."
                Task.Factory.StartNew(Sub() InstallHotfix())
            Else
                'File did not copy
                ExitCodeReturn = -1
                InstallFailed = True
                OnInstallFinished()
            End If
        End If

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
    End Sub

#End Region
#Region "LinkLabel Event Handlers"

    Private Sub LnkHotfix_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkHotfix.LinkClicked
        Process.Start("https://support.microsoft.com/help/2687862")
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

    Private Sub InstallHotfix()

        ExitCodeReturn = FileHelper.InstallMsu(StringTempPath)
        Invoke(DirectCast(Sub() OnInstallFinished(), MethodInvoker))

    End Sub

    Private Sub OnInstallFinished()

        PbxLoad.Hide()

        If InstallFailed Then
            RestartWin = False
            InstallFailed = False
            CmdCancel.Enabled = True
            CmdClose.Enabled = True
            CmdInstall.Enabled = True
            CmdInstall.Text = "Retry"
            LabDownload.Text = "Install failed (" & ExitCodeReturn & "), click 'Retry' to try again."
        Else
            Select Case ExitCodeReturn
                Case 0 To 1
                    RestartWin = False
                    LabDownload.Text = "Hotfixed installed successfully (" & ExitCodeReturn & ")"
                    CmdClose.Enabled = True
                    CmdCancel.Enabled = True
                    CmdCancel.Text = "Close"
                    FormMain.HotfixWasInstalled() 'Notify main form to remove hotfix available from the menu and negate one from notification count
                Case Else
                    RestartWin = True
                    LabDownload.Text = "Hotfixed installed. System restart required (" & ExitCodeReturn & ")"
                    CmdClose.Enabled = True
                    CmdCancel.Enabled = True
                    CmdCancel.Text = "Ignore"
                    CmdInstall.Enabled = True
                    CmdInstall.Text = "Restart"
                    FormMain.HotfixWasInstalled() 'Notify main form to remove hotfix available from the menu and negate one from notification count
            End Select
        End If

    End Sub

#End Region

End Class