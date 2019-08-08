'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormSettings.vb
'  Created by David S on 01.11.2018
'  Updated on 15.07.2019 - DS (Cleanup, add custom client id)
'  Updated on 31.07.2019 - DS (Animation, update imports, cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports System.IO

Imports Core.Animation
Imports Core.Helpers

Imports Gambol.Controls

Public Class FormSettings

#Region "Variables"

    Private IntAccent As Integer = 0

#End Region

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
            WndProc(Message.Create(Me.Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        'Set opacity
        Opacity = 0
        'Set theme colors
        SetOptionsThemeAccent()

        cmdWarn.Hide()

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
            tbxClientId.Text = Settings.StringUserImgurClientId
        End If

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetOptionsThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        tbxClientId.ForeColor = Settings.ThemeColor

        For Each c As Control In pnlShowHardware.Controls
            If TypeOf c Is GambolRadioButton Then DirectCast(c, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each c As Control In pnlHardwareMode.Controls
            If TypeOf c Is GambolRadioButton Then DirectCast(c, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each c As Control In pnlAssessmentMode.Controls
            If TypeOf c Is GambolRadioButton Then DirectCast(c, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each c As Control In pnlThemeColor.Controls
            If TypeOf c Is GambolCheckbox Then DirectCast(c, GambolCheckbox).CheckedColor = Settings.ThemeColor
        Next

        For Each c As Control In pnlPortability.Controls
            If TypeOf c Is GambolRadioButton Then DirectCast(c, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each c As Control In pnlCustomID.Controls
            If TypeOf c Is GambolRadioButton Then DirectCast(c, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each c As Control In pnlConfiguration.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"
    Private Sub CmdOkay_Click(sender As Object, e As EventArgs) Handles cmdOkay.Click

        MoveSettings()
        CheckPortable()
        WriteClientID()

        'Update background integers
        ApplySettingsIntegers()

        'Save new user settings
        Settings.CreateSettings()

        'Load new settings to memory
        Settings.LoadSettings()

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
    Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click

        MoveSettings()
        CheckPortable()
        WriteClientID()

        'Update background integers
        ApplySettingsIntegers()

        'Save new user settings
        Settings.CreateSettings()

        'Load new settings to memory
        Settings.LoadSettings()

        'Set theme
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        ToastAlert.Show("Settings updated.", ToastType.IsInformational)

    End Sub
    Private Sub CmdWarn_Click(sender As Object, e As EventArgs) Handles cmdWarn.Click

        Fade.FadeBehindChild(Me)

        Dim FWarn As New FormWarn
        AddHandler FWarn.FormClosed, AddressOf ChildFormClosedNoRefresh
        FWarn.ShowDialog()

    End Sub
    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

#End Region

#Region "Routines"

    Private Sub CheckAutoHardware()

        Select Case Settings.ShowHardwareOnStarup
            Case 0
                rbnHardwareDisable.Checked = True
            Case 1
                rbnHardwareEnable.Checked = True
            Case Else
                rbnHardwareDisable.Checked = True
        End Select

    End Sub
    Private Sub CheckHardwareMode()

        Select Case Settings.UseApiHardware
            Case 0
                rbnXml.Checked = True
            Case 1
                rbnApi.Checked = True
            Case Else
                rbnXml.Checked = True
        End Select

    End Sub

    Private Sub CheckAssMode()

        Select Case Settings.UseVerboseMode
            Case 0
                rbnNormal.Checked = True
            Case 1
                rbnVerbose.Checked = True
            Case Else
                rbnNormal.Checked = True
        End Select

    End Sub
    Private Sub CheckTheme()

        Select Case Settings.ThemeInt
            Case 0
                rbnDefault0.Checked = True
            Case 1
                rbnSky1.Checked = True
            Case 2
                rbnTurq2.Checked = True
            Case 3
                rbnEmerald3.Checked = True
            Case 4
                rbnMegenta4.Checked = True
            Case 5
                rbnPink5.Checked = True
            Case 6
                rbnCarrot6.Checked = True
            Case 7
                rbnYellow7.Checked = True
            Case 8
                rbnAlazarin8.Checked = True
            Case Else
                rbnDefault0.Checked = True
        End Select

    End Sub

    Private Sub CheckApplyBorder()

        Select Case Settings.ApplyThemeColorToBorder
            Case 0
                cbxApplyToBorder.Checked = False
            Case 1
                cbxApplyToBorder.Checked = True
            Case Else
                cbxApplyToBorder.Checked = False
        End Select

    End Sub

    Private Sub CheckCustomClientId()

        Select Case Settings.UseCustomImgurApiKey
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
        If rbnHardwareDisable.Checked Then
            Settings.ShowHardwareOnStarup = 0
        Else
            Settings.ShowHardwareOnStarup = 1
        End If

        '// Hardware mode
        If rbnXml.Checked Then
            Settings.UseApiHardware = 0
        Else
            Settings.UseApiHardware = 1
        End If

        '// Assessment Mode
        If rbnNormal.Checked Then
            Settings.UseVerboseMode = 0
        Else
            Settings.UseVerboseMode = 1
        End If

        '// Theme
        If rbnDefault0.Checked Then
            Settings.ThemeInt = 0
        End If
        If rbnSky1.Checked Then
            Settings.ThemeInt = 1
        End If
        If rbnTurq2.Checked Then
            Settings.ThemeInt = 2
        End If
        If rbnEmerald3.Checked Then
            Settings.ThemeInt = 3
        End If
        If rbnMegenta4.Checked Then
            Settings.ThemeInt = 4
        End If
        If rbnPink5.Checked Then
            Settings.ThemeInt = 5
        End If
        If rbnCarrot6.Checked Then
            Settings.ThemeInt = 6
        End If
        If rbnYellow7.Checked Then
            Settings.ThemeInt = 7
        End If
        If rbnAlazarin8.Checked Then
            Settings.ThemeInt = 8
        End If

        'Apply theme to border
        If Not cbxApplyToBorder.Checked Then
            Settings.ApplyThemeColorToBorder = 0
        Else
            Settings.ApplyThemeColorToBorder = 1
        End If

        'Custom Imgur Client ID
        If rbnClientDisable.Checked Then
            Settings.UseCustomImgurApiKey = 0
        Else
            If rbnClientEnable.Checked And tbxClientId.Text = "" Then
                Settings.UseCustomImgurApiKey = 0
            Else
                Settings.UseCustomImgurApiKey = 1
            End If

        End If

    End Sub

    Private Sub CheckPortable()

        If File.Exists(Settings.WorkingDirFile) And File.Exists(Settings.AppdataFile) Then

            cmdWarn.Show()

            rbnAppath.Checked = False
            rbnAppath.Enabled = False

            rbnAppdata.Checked = False
            rbnAppdata.Enabled = False

        Else
            If File.Exists(Settings.WorkingDirFile) Then
                Settings.BoolWorkingDirectory = True
                rbnAppath.Checked = True
            Else
                If File.Exists(Settings.AppdataFile) Then
                    Settings.BoolWorkingDirectory = False
                    rbnAppdata.Checked = True
                End If
            End If
        End If

    End Sub
    Private Sub MoveSettings()

        If rbnAppath.Checked Then 'Move to working dir
            If Not File.Exists(Settings.WorkingDirFile) Then
                FileHelper.MoveSafely(Settings.AppdataFile, Settings.WorkingDirFile)
            End If
        Else
            If rbnAppdata.Checked Then 'Move to appdata
                If Not File.Exists(Settings.AppdataFile) Then
                    FileHelper.MoveSafely(Settings.WorkingDirFile, Settings.AppdataFile)
                End If
            End If
        End If

    End Sub

    Private Sub WriteClientID()

        If rbnClientDisable.Checked Then
            Settings.StringUserImgurClientId = ""
        Else
            Settings.StringUserImgurClientId = tbxClientId.Text
        End If

    End Sub

    Private Sub RbnClientDisable_CheckedChanged(sender As Object, e As EventArgs) Handles rbnClientDisable.CheckedChanged
        tbxClientId.Text = ""
        tbxClientId.Hide()
    End Sub

    Private Sub RbnClientEnable_CheckedChanged(sender As Object, e As EventArgs) Handles rbnClientEnable.CheckedChanged
        tbxClientId.Show()
        ControlHelper.SetCueText(tbxClientId, "Enter Client ID")
    End Sub
#End Region

#Region "Update UI"

    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)
        Fade.RefadeIn(Me)
    End Sub


#End Region

End Class