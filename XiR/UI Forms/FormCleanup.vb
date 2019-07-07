'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormCleanup.vb
'  Created by David S on 01.11.2018
'  Some code moved from settings (WinSAT)
'  Updated on 29.06.2019 - DS (Moved multiple code blocks into BatchRemoveFiles routine)

Imports System.IO
Imports System.Threading

Imports Xiret.Gambol.Controls

Public Class FormCleanup

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            Me.WndProc(Message.Create(Me.Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Me.Close() : End If
    End Sub

#End Region
#Region "Frame Buttons"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
#End Region

#Region "Load Event"

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Opacity = 0

        'Set form theme
        SetCleanupThemeAccent()

    End Sub

#End Region
#Region "Shown Event"

    Private Sub FormSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try
            For FadeIn = 0.0 To 1.0 Step 0.2
                Me.Opacity = FadeIn
                Me.Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Me.Opacity = 1.0
        End Try

    End Sub

#End Region
#Region "Closed Event"

    Private Sub FormSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try
            For FadeOut = 1.0 To 0.0 Step -0.2
                Me.Opacity = FadeOut
                Me.Refresh()
                Threading.Thread.Sleep(10)
            Next
        Catch
            Me.Close()
        End Try

    End Sub

#End Region

#Region "Theme"
    Private Sub SetCleanupThemeAccent()

        pnlSplit.BackColor = GlobalThemeColor

        cbxResetWinsat.CheckedColor = GlobalThemeColor
        cbxPurgeSettings.CheckedColor = GlobalThemeColor

        cmdReset.ForeColor = GlobalThemeColor
        cmdPurge.ForeColor = GlobalThemeColor

        If (BoolThemeApplyBorder) Then : Me.BackColor = GlobalThemeColor
        Else : Me.BackColor = ColorBorderStandard
        End If

    End Sub

#End Region

#Region "Button Handlers"

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        'Delete system scores
        BatchRemoveFiles("*.xml", DirWinsatDatastore)
        'Delete winsat log
        BatchRemoveFiles("*.log", DirWinsat)
        'Restart application
        Application.Restart()

    End Sub
    Private Sub cmdPurge_Click(sender As Object, e As EventArgs) Handles cmdPurge.Click

        'First off, we want no new settings being created on exit.
        BoolCreateFilepath = False

        'Delete updater path, settings, xiret log and imgur links.
        BatchRemoveFiles("*.*", DirAppData)

        'Delete appdata folder
        If Directory.Exists(DirAppData) Then : Directory.Delete(DirAppData)
        End If

        'Exit application
        Application.Exit()

    End Sub
#End Region
#Region "Checkboxes"

    Private Sub cbxResetWinsat_CheckedChanged(sender As Object, e As EventArgs) Handles cbxResetWinsat.CheckedChanged

        If (CType(sender, GambolCheckbox).Checked) Then : cmdReset.Enabled = True : pnlPurge.Enabled = False
        Else : cmdReset.Enabled = False : pnlPurge.Enabled = True
        End If

    End Sub

    Private Sub cbxPurgeSettings_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPurgeSettings.CheckedChanged

        If (CType(sender, GambolCheckbox).Checked) Then : cmdPurge.Enabled = True : pnlReset.Enabled = False
        Else : cmdPurge.Enabled = False : pnlReset.Enabled = True
        End If

    End Sub

#End Region

#Region "Plz Delet filz"

    Private Sub BatchRemoveFiles(fileFlags As String, ByVal fileDir As String)

        Dim Array() As String
        Array = Directory.GetFileSystemEntries(fileDir, fileFlags)
        For Each element As String In Array
            If Not Directory.Exists(element) Then : File.Delete(Path.Combine(fileDir, Path.GetFileName(element)))
            Else
                Exit Sub
            End If
        Next

    End Sub

#End Region


End Class