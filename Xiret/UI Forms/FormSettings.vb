'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormSettings.vb
'  Created by David S on 01.11.2018
'  Updated on 04.07.2019 - DS (Cleanup, updated shown and load events)

Imports System.IO
Imports System.Threading

Imports Xiret.Base.Helpers

Public Class FormSettings

#Region "Variables"

    Private IntAccent As Integer = 0

#End Region

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

        Opacity = 0

        cmdWarn.Hide()

        'Set form theme
        SetOptionsThemeAccent()

        'Check current settings and set controls state
        CheckAutoHardware()
        CheckHardwareMode()
        CheckAssMode()
        CheckTheme()
        CheckApplyBorder()
        CheckPortable()
        CheckCustomClientId()

        If rbnClientDisable.Checked Then
            tbxClientId.Hide()
        Else
            tbxClientId.Show()
        End If

    End Sub

#End Region
#Region "Shown Event"

    Private Sub FormSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try
            For FadeIn = 0.0 To 1.0 Step 0.2
                Opacity = FadeIn
                Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Opacity = 1.0
        End Try

    End Sub

#End Region
#Region "Closed Event"

    Private Sub FormSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try
            For FadeOut = 1.0 To 0.0 Step -0.2
                Opacity = FadeOut
                Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Close()
        End Try

    End Sub

#End Region

#Region "Theme"
    Private Sub SetOptionsThemeAccent()

        pnlSplit.BackColor = GlobalThemeColor

        rbnHardwareDisable.CheckedColor = GlobalThemeColor
        rbnHardwareEnable.CheckedColor = GlobalThemeColor

        rbnXml.CheckedColor = GlobalThemeColor
        rbnApi.CheckedColor = GlobalThemeColor

        rbnNormal.CheckedColor = GlobalThemeColor
        rbnVerbose.CheckedColor = GlobalThemeColor

        cbxApplyToBorder.CheckedColor = GlobalThemeColor

        rbnAppdata.CheckedColor = GlobalThemeColor
        rbnAppath.CheckedColor = GlobalThemeColor

        cmdCancel.ForeColor = GlobalThemeColor
        cmdOkay.ForeColor = GlobalThemeColor
        cmdApply.ForeColor = GlobalThemeColor

        tbxClientId.ForeColor = GlobalThemeColor

        If BoolThemeApplyBorder Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If

    End Sub

#End Region

#Region "Buttons"
    Private Sub cmdOkay_Click(sender As Object, e As EventArgs) Handles cmdOkay.Click

        MoveSettings()
        CheckPortable()

        'Update background integers
        ApplySettingsIntegers()

        'Save new user settings
        CreateSettings()

        'Load new settings to memory
        LoadSettings()

        If FormMain.GSwitchHardware.Checked Then
            FormMain.SetHW()
        End If

        'Set theme
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        'Done
        Close()

    End Sub
    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click

        MoveSettings()
        CheckPortable()

        'Update background integers
        ApplySettingsIntegers()

        'Save new user settings
        CreateSettings()

        'Load new settings to memory
        LoadSettings()

        'Set theme
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        SendToastToScreen("Settings updated.", ToastType.IsInformational)

    End Sub
    Private Sub cmdWarn_Click(sender As Object, e As EventArgs) Handles cmdWarn.Click

        SetOpacity()

        Dim FWarn As New FormWarn
        AddHandler FWarn.FormClosed, AddressOf ChildFormClosedNoRefresh
        FWarn.ShowDialog()

    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

#End Region
#Region "Routines"

    Private Sub CheckAutoHardware()

        Select Case SettingsAutoHardwareInt
            Case 0
                rbnHardwareDisable.Checked = True
            Case 1
                rbnHardwareEnable.Checked = True
            Case Else
                rbnHardwareDisable.Checked = True
        End Select

    End Sub
    Private Sub CheckHardwareMode()

        Select Case SettingsHardwareModeInt
            Case 0
                rbnXml.Checked = True
            Case 1
                rbnApi.Checked = True
            Case Else
                rbnXml.Checked = True
        End Select

    End Sub

    Private Sub CheckAssMode()

        Select Case SettingsAssModeInt
            Case 0
                rbnNormal.Checked = True
            Case 1
                rbnVerbose.Checked = True
            Case Else
                rbnNormal.Checked = True
        End Select

    End Sub
    Private Sub CheckTheme()

        Select Case SettingsThemeInt
            Case 0
                rbnThemeDef0.Checked = True
            Case 1
                rbnThemeSky1.Checked = True
            Case 2
                rbnThemeTurq2.Checked = True
            Case 3
                rbnThemeEmerald3.Checked = True
            Case 4
                rbnThemeAmethyst4.Checked = True
            Case 5
                rbnThemeCarrot5.Checked = True
            Case 6
                rbnThemeSun6.Checked = True
            Case 7
                rbnThemeAlazarin7.Checked = True
            Case Else
                rbnThemeDef0.Checked = True
        End Select

    End Sub

    Private Sub CheckApplyBorder()

        Select Case SettingsThemeApplyToBorderInt
            Case 0
                cbxApplyToBorder.Checked = False
            Case 1
                cbxApplyToBorder.Checked = True
            Case Else
                cbxApplyToBorder.Checked = False
        End Select

    End Sub

    Private Sub CheckCustomClientId()

        Select Case SettingsUseCustomImgurApiKey
            Case 0
                rbnClientDisable.Checked = True
            Case 1
                rbnClientEnable.Checked = True
            Case Else
                rbnClientDisable.Checked = True
        End Select

    End Sub

    Private Sub ApplySettingsIntegers()

        '// Show hardware on startup
        If (rbnHardwareDisable.Checked) Then
            SettingsAutoHardwareInt = 0
        End If
        If (rbnHardwareEnable.Checked) Then
            SettingsAutoHardwareInt = 1
        End If

        '// Hardware mode
        If (rbnXml.Checked) Then
            SettingsHardwareModeInt = 0
        End If
        If (rbnApi.Checked) Then
            SettingsHardwareModeInt = 1
        End If

        '// Assessment Mode
        If (rbnNormal.Checked) Then
            SettingsAssModeInt = 0
        End If
        If (rbnVerbose.Checked) Then
            SettingsAssModeInt = 1
        End If

        '// Theme
        If (rbnThemeDef0.Checked) Then
            SettingsThemeInt = 0
        End If
        If (rbnThemeSky1.Checked) Then
            SettingsThemeInt = 1
        End If
        If (rbnThemeTurq2.Checked) Then
            SettingsThemeInt = 2
        End If
        If (rbnThemeEmerald3.Checked) Then
            SettingsThemeInt = 3
        End If
        If (rbnThemeAmethyst4.Checked) Then
            SettingsThemeInt = 4
        End If
        If (rbnThemeCarrot5.Checked) Then
            SettingsThemeInt = 5
        End If
        If (rbnThemeSun6.Checked) Then
            SettingsThemeInt = 6
        End If
        If (rbnThemeAlazarin7.Checked) Then
            SettingsThemeInt = 7
        End If

        'Apply theme to border
        Select Case cbxApplyToBorder.CheckState
            Case CheckState.Unchecked
                SettingsThemeApplyToBorderInt = 0
            Case CheckState.Checked
                SettingsThemeApplyToBorderInt = 1
            Case Else
                SettingsThemeApplyToBorderInt = 0
        End Select

    End Sub

    Private Sub CheckPortable()

        If (IO.File.Exists(FileWorkingSettings)) And (IO.File.Exists(FileAppdataSettings)) Then

            cmdWarn.Show()

            rbnAppath.Checked = False
            rbnAppath.Enabled = False

            rbnAppdata.Checked = False
            rbnAppdata.Enabled = False

        Else
            If (IO.File.Exists(FileWorkingSettings)) Then
                SettingsCore.BoolWorkingDirectory = True
                rbnAppath.Checked = True
            Else
                If (IO.File.Exists(FileAppdataSettings)) Then
                    SettingsCore.BoolWorkingDirectory = False
                    rbnAppdata.Checked = True
                End If
            End If
        End If

    End Sub

#End Region

#Region "Update UI"

    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)

        ResetOpacity()

    End Sub
    Private Sub SetOpacity()

        For FadeOut = 1.0 To 0.4 Step -0.2
            Me.Opacity = FadeOut
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next

    End Sub
    Private Sub ResetOpacity()

        If (Opacity <> 0.4) Then
            For FadeIn = 0.4 To 1.0 Step 0.2
                Opacity = FadeIn
                Refresh()
                Threading.Thread.Sleep(10)
            Next
        End If

    End Sub

#End Region

    'PLz mov me
    Private Sub MoveSettings()

        If rbnAppath.Checked Then 'Move to working dir
            If Not File.Exists(FileWorkingSettings) Then
                FHMove(FileAppdataSettings, FileWorkingSettings)
            End If
        Else
            If rbnAppdata.Checked Then 'Move to appdata
                If Not File.Exists(FileAppdataSettings) Then
                    FHMove(FileWorkingSettings, FileAppdataSettings)
                End If
            End If
        End If

    End Sub

    Private Sub rbnClientDisable_CheckedChanged(sender As Object, e As EventArgs) Handles rbnClientDisable.CheckedChanged
        tbxClientId.Hide()
    End Sub

    Private Sub rbnClientEnable_CheckedChanged(sender As Object, e As EventArgs) Handles rbnClientEnable.CheckedChanged
        tbxClientId.Show()
        SetCueText(tbxClientId, "Enter Client ID")
    End Sub
End Class