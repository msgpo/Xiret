'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormMetrics.vb
'  Created by David S on 01.07.2019
'  This is WIP

Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class FormMetrics

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Event"
    Private Sub FormAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event"

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set opacity to 0 to eliminate form glitch
        Opacity = 0

        'Set theme colours
        SetMetricsThemeAccent()

    End Sub

#End Region
#Region "Shown Event"

    Private Sub FormAbout_Shown(sender As Object, e As EventArgs) Handles Me.Shown

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

    Private Sub FormAbout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

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
    Private Sub SetMetricsThemeAccent()

        'Split colour
        pnlSplit.BackColor = GlobalThemeColor

        'Change link colours
        For Each c As Control In TableLayoutPanel1.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = GlobalThemeColor
        Next

        'Apply border colour
        If BoolThemeApplyBorder Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If

    End Sub
#End Region

#Region "Active Button Code"

    Private Sub PaintLine(sender As Object, e As PaintEventArgs) Handles cmdWinsat.Paint

        ' Create Pens
        Dim rectPen As New Pen(GlobalThemeColor)
        ' Create a rectangle
        Dim rect As New Rectangle(CInt(CType(sender, Button).Width - 4), CInt(CType(sender, Button).Height / 2 - 12), 2, 24)
        ' Draw ellipses
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.DrawRectangle(rectPen, rect)
        Dim MC As Color = GlobalThemeColor
        Dim MB As Brush = New SolidBrush(MC)
        e.Graphics.FillRectangle(MB, rect)
        'Dispose of objects
        rectPen.Dispose()

    End Sub

#End Region

End Class