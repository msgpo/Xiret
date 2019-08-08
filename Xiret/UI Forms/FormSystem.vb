'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormSystem.vb
'  Created by David S on 07.02.2019
'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WncProc)

Imports Core.Animation
Imports Core.Helpers

Public Class FormSystem

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
    Private Sub FormSystem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormSystem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set opacity
        Opacity = 0
        'Set form theme
        SetCleanupThemeAccent()

        lbOpSys.Text = OSHelper.GetOSName()
        lbBitness.Text = OSHelper.GetOSBitness()
        lbServicePack.Text = OSHelper.GetServicePack()

        lbKernel.Text = OSHelper.GetKernelVersion.FileVersion
        lbWinsat.Text = OSHelper.GetWinsatVersion.ProductVersion
        lbApi.Text = OSHelper.GetWinsatApiVersion.ProductVersion

        lbUptime.Text = OSHelper.GetWindowsUptime()

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormSystem_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormSystem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetCleanupThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        CmdRefresh.ForeColor = Settings.ThemeColor

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"
    Private Sub Cmdrefresh_Click(sender As Object, e As EventArgs) Handles CmdRefresh.Click
        lbUptime.Text = OSHelper.GetWindowsUptime
    End Sub
#End Region

End Class