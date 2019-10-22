﻿'Xiret - Experience Index UI License
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

#Disable Warning IDE0067

Imports System.IO

Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers

Imports Xiret.Controls

Public Class FormSettings

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetOptionsThemeAccent()
    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove, PanHead.MouseMove

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

        CmdWarn.Hide()

        'Check current settings and set controls state
        CheckAutoHardware()
        CheckHardwareMode()
        CheckAssMode()
        CheckTheme()
        CheckApplyBorder()
        CheckPortable()
        CheckCustomClientId()

        If RadCustomClientOff.Checked Then
            TbxClientId.Hide()
        Else
            TbxClientId.Show()
            TbxClientId.Text = Settings.StringUserImgurClientId
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

        PanSplit.BackColor = Settings.ThemeColor

        TbxClientId.ForeColor = Settings.ThemeColor

        For Each Ctrl As Control In PanShowHardware.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanHardwareMode.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanAssessmentMode.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanThemeColor.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanPortability.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanImgur.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In PanConfig.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"
    Private Sub CmdOkay_Click(sender As Object, e As EventArgs) Handles CmdOkay.Click

        MoveSettings()
        CheckPortable()
        WriteClientID()

        'Update background integers
        ApplySettingsIntegers()

        'Save new user settings
        Settings.CreateSettings()

        'Load new settings to memory
        Settings.LoadSettings()

        If FormMain.GswHardware.Checked Then
            FormMain.SetHW()
        End If

        'Set theme
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        'Done
        Close()

    End Sub
    Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles CmdApply.Click

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

        ToastAlert.Show("Settings updated.", ToastType.Information)

    End Sub
    Private Sub CmdWarn_Click(sender As Object, e As EventArgs) Handles CmdWarn.Click

        Fade.FadeBehindChild(Me)

        Dim FWarn As New FormWarn
        AddHandler FWarn.FormClosed, AddressOf ChildFormClosedNoRefresh
        FWarn.ShowDialog()

    End Sub
    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
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

    Private Sub CheckAutoHardware()

        Select Case Settings.ShowHardwareOnStartup
            Case 0
                RadHardwareDisable.Checked = True
            Case 1
                RadHardwareEnable.Checked = True
            Case Else
                RadHardwareDisable.Checked = True
        End Select

    End Sub
    Private Sub CheckHardwareMode()

        Select Case Settings.UseApiHardware
            Case 0
                RadHardwaremodeXml.Checked = True
            Case 1
                RadHardwaremodeApi.Checked = True
            Case Else
                RadHardwaremodeXml.Checked = True
        End Select

    End Sub

    Private Sub CheckAssMode()

        Select Case Settings.UseVerboseMode
            Case 0
                RadAssessmentNormal.Checked = True
            Case 1
                RadAssessmentVerbose.Checked = True
            Case Else
                RadAssessmentNormal.Checked = True
        End Select

    End Sub
    Private Sub CheckTheme()

        Select Case Settings.ThemeInt
            Case 0
                RadDefault0.Checked = True
            Case 1
                RadSky1.Checked = True
            Case 2
                RadTurquoise2.Checked = True
            Case 3
                RadEmerald3.Checked = True
            Case 4
                RadMegenta4.Checked = True
            Case 5
                RadPink5.Checked = True
            Case 6
                RadCarrot6.Checked = True
            Case 7
                RadYellow7.Checked = True
            Case 8
                RadAlazarin8.Checked = True
            Case Else
                RadDefault0.Checked = True
        End Select

    End Sub

    Private Sub CheckApplyBorder()

        Select Case Settings.ApplyThemeColorToBorder
            Case 0
                CbxApplyToBorder.Checked = False
            Case 1
                CbxApplyToBorder.Checked = True
            Case Else
                CbxApplyToBorder.Checked = False
        End Select

    End Sub

    Private Sub CheckCustomClientId()

        Select Case Settings.UseCustomImgurApiKey
            Case 0
                RadCustomClientOff.Checked = True
            Case 1
                RadCustomClientOn.Checked = True
            Case Else
                RadCustomClientOff.Checked = True
        End Select

    End Sub

    Private Sub ApplySettingsIntegers()

        '// Show hardware on startup
        If RadHardwareDisable.Checked Then
            Settings.ShowHardwareOnStartup = 0
        Else
            Settings.ShowHardwareOnStartup = 1
        End If

        '// Hardware mode
        If RadHardwaremodeXml.Checked Then
            Settings.UseApiHardware = 0
        Else
            Settings.UseApiHardware = 1
        End If

        '// Assessment Mode
        If RadAssessmentNormal.Checked Then
            Settings.UseVerboseMode = 0
        Else
            Settings.UseVerboseMode = 1
        End If

        '// Theme
        If RadDefault0.Checked Then
            Settings.ThemeInt = 0
        End If
        If RadSky1.Checked Then
            Settings.ThemeInt = 1
        End If
        If RadTurquoise2.Checked Then
            Settings.ThemeInt = 2
        End If
        If RadEmerald3.Checked Then
            Settings.ThemeInt = 3
        End If
        If RadMegenta4.Checked Then
            Settings.ThemeInt = 4
        End If
        If RadPink5.Checked Then
            Settings.ThemeInt = 5
        End If
        If RadCarrot6.Checked Then
            Settings.ThemeInt = 6
        End If
        If RadYellow7.Checked Then
            Settings.ThemeInt = 7
        End If
        If RadAlazarin8.Checked Then
            Settings.ThemeInt = 8
        End If

        'Apply theme to border
        If Not CbxApplyToBorder.Checked Then
            Settings.ApplyThemeColorToBorder = 0
        Else
            Settings.ApplyThemeColorToBorder = 1
        End If

        'Custom Imgur Client ID
        If RadCustomClientOff.Checked Then
            Settings.UseCustomImgurApiKey = 0
        Else
            If RadCustomClientOn.Checked And TbxClientId.Text = "" Then
                Settings.UseCustomImgurApiKey = 0
            Else
                Settings.UseCustomImgurApiKey = 1
            End If

        End If

    End Sub

    Private Sub CheckPortable()

        If File.Exists(Settings.WorkingDirFile) And File.Exists(Settings.AppdataFile) Then

            CmdWarn.Show()

            RadPortabilityOn.Checked = False
            RadPortabilityOn.Enabled = False

            RadPortabilityOff.Checked = False
            RadPortabilityOff.Enabled = False

        Else
            If File.Exists(Settings.WorkingDirFile) Then
                Settings.BoolWorkingDirectory = True
                RadPortabilityOn.Checked = True
            Else
                If File.Exists(Settings.AppdataFile) Then
                    Settings.BoolWorkingDirectory = False
                    RadPortabilityOff.Checked = True
                End If
            End If
        End If

    End Sub
    Private Sub MoveSettings()

        If RadPortabilityOn.Checked Then 'Move to working dir
            If Not File.Exists(Settings.WorkingDirFile) Then
                FileHelper.MoveSafely(Settings.AppdataFile, Settings.WorkingDirFile)
            End If
        Else
            If RadPortabilityOff.Checked Then 'Move to appdata
                If Not File.Exists(Settings.AppdataFile) Then
                    FileHelper.MoveSafely(Settings.WorkingDirFile, Settings.AppdataFile)
                End If
            End If
        End If

    End Sub

    Private Sub WriteClientID()

        If RadCustomClientOff.Checked Then
            Settings.StringUserImgurClientId = ""
        Else
            Settings.StringUserImgurClientId = TbxClientId.Text
        End If

    End Sub

    Private Sub RbnClientDisable_CheckedChanged(sender As Object, e As EventArgs) Handles RadCustomClientOff.CheckedChanged
        TbxClientId.Text = ""
        TbxClientId.Hide()
    End Sub

    Private Sub RbnClientEnable_CheckedChanged(sender As Object, e As EventArgs) Handles RadCustomClientOn.CheckedChanged
        TbxClientId.Show()
        ControlHelper.SetCueText(TbxClientId, "Enter Client ID")
    End Sub
#End Region

#Region "Update UI"

    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)
        Fade.RefadeIn(Me)
    End Sub


#End Region

End Class