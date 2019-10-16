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
'  Updated on 23.09.2019 - DS (Move checksum generation from SHA256 to SHA512)

Imports System.IO
Imports System.Net
Imports System.Threading.Tasks

Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers

Public Class FormHotfix

    Private ReadOnly StringTempPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp\Windows6.1-KB2687862.msu")

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

        'If OSHelper.IsWinSeven Then
        '    CmdInstall.Enabled = True
        'Else
        '    LabHead.Text = "Support (Disabled on this OS)"
        '    CmdInstall.Enabled = False
        'End If

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
        PbrPercentage.ProgressColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpBottom.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Routines"

    Private Sub InstallKB()
        FileHelper.InstallMsu(StringTempPath)
    End Sub

    Private Sub InstallFinished()

        Booleans.BoolRestartWin = True
        LabDownload.Text = "Hotfix installed. A system restart is required."
        CmdClose.Enabled = False
        CmdCancel.Enabled = False
        CmdInstall.Enabled = True
        CmdInstall.Text = "Restart"
        PbrPercentage.Value = 0

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdInstall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdInstall.Click

        If Booleans.BoolRestartWin Then
            Process.Start("shutdown", "-r -t 00")
        Else

            LabDownload.Text = "Please wait..."
            'Disable button from clicking
            CType(sender, Button).Enabled = False

            'Determine bitness for appropriate hotfix

            If NetHelper.IsWebsiteAvailable(Strings.StringBitmightUrl) = True Then

                Dim WClient As New WebClient
                AddHandler WClient.DownloadProgressChanged, AddressOf WClient_ProgressChanged
                AddHandler WClient.DownloadFileCompleted, AddressOf WClient_DownloadCompleted

                If OSHelper.IsWindows64Bit() Then
                    WClient.DownloadFileAsync(New Uri(Strings.StringHotfix64Url), StringTempPath)
                Else
                    WClient.DownloadFileAsync(New Uri(Strings.StringHotfix86Url), StringTempPath)
                End If

                WClient.Dispose()

            Else
                ToastAlert.Show("Could not reach server", ToastType.IsWarning)
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

#Region "WebClient"

    Private Sub WClient_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        Invoke(DirectCast(Sub() LabDownload.Text = "Downloading: " & Integer.Parse(Math.Truncate(percentage).ToString()) & "%", MethodInvoker))

        'PbrUpdate.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        'PbrUpdate.Refresh()

    End Sub
    Private Sub WClient_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        'PbrUpdate.Value = 0
        'PbrUpdate.Hide()

        Dim DoInstall As Task = Nothing

        'Validate x64 download success
        If OSHelper.IsWindows64Bit() Then
            If CryptoHelper.GetSha512FromFile(StringTempPath) = Strings.StringHotfixChecksum64 Then
                Invoke(DirectCast(Sub() LabDownload.Text = "Validation success. Installing KB2687862...", MethodInvoker))
                DoInstall = Task.Factory.StartNew(Sub() InstallKB())
            Else
                File.Delete(StringTempPath)
                Invoke(DirectCast(Sub() LabDownload.Text = "File validation failure. Download was deleted.", MethodInvoker))
            End If
        Else
            'Validate x86 download success
            If CryptoHelper.GetSha512FromFile(StringTempPath) = Strings.StringHotfixChecksum86 Then
                Invoke(DirectCast(Sub() LabDownload.Text = "Validation success. Installing KB2687862...", MethodInvoker))
                DoInstall = Task.Factory.StartNew(Sub() InstallKB())
            Else
                File.Delete(StringTempPath)
                Invoke(DirectCast(Sub() LabDownload.Text = "File validation failure. Download was deleted.", MethodInvoker))
            End If
        End If

        InstallFinished()

    End Sub

#End Region

End Class