'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolSwitch.vb
'  Created by David S on 20.03.2016
'  Updated on 04.07.2019 - DS (Cleanup)

Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Imports Xiret.Gambol.Controls.Design

Namespace Gambol.Controls

    <Designer(GetType(GambolSwitchDesigner)), ToolboxBitmap(GetType(CheckBox))>
    Public Class GambolSwitch
        Inherits CheckBox

#Region "Constructor"

        Public Sub New()

            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            DoubleBuffered = True

            AddHandler Me.MouseEnter, AddressOf ProcessMouse
            AddHandler Me.MouseLeave, AddressOf ProcessMouse

        End Sub

#End Region
#Region "Properties"
        Private ColorBorderInactive As Color = Color.FromArgb(180, 180, 180)
        <Description("Set the control inactive border color."), _
        Category("Gambol Appearance")> _
        Property InactiveBorderColor As Color
            Get
                Return ColorBorderInactive
            End Get
            Set(value As Color)
                ColorBorderInactive = value
                Invalidate()
            End Set
        End Property
        Private ColorBorderActive As Color = Color.FromArgb(40, 50, 60)
        <Description("Set the control active border color."), _
        Category("Gambol Appearance")> _
        Property ActiveBorderColor As Color
            Get
                Return ColorBorderActive
            End Get
            Set(value As Color)
                ColorBorderActive = value
                Invalidate()
            End Set
        End Property
        Private ColorSwitchOn As Color = Color.FromArgb(120, 180, 0)
        <Description("Set the control toggle on color."), _
        Category("Gambol Appearance")> _
        Property SwitchSetOn As Color
            Get
                Return ColorSwitchOn
            End Get
            Set(value As Color)
                ColorSwitchOn = value
                Invalidate()
            End Set
        End Property
        Private ColorSwitchOff As Color = Color.FromArgb(130, 140, 150)
        <Description("Set the control toggle off color."), _
        Category("Gambol Appearance")> _
        Property SwitchSetOff As Color
            Get
                Return ColorSwitchOff
            End Get
            Set(value As Color)
                ColorSwitchOff = value
                Invalidate()
            End Set
        End Property
        Private ColorSwitchHovered As Color = Color.FromArgb(20, 20, 20)
        <Description("Set the control toggle hovered color."), _
        Category("Gambol Appearance")> _
        Property SwitchSetHovered As Color
            Get
                Return ColorSwitchHovered
            End Get
            Set(value As Color)
                ColorSwitchHovered = value
                Invalidate()
            End Set
        End Property

        Private IsGradBG As Boolean = True
        <Description("Toggle whether the switch head contains a gradient color"), Category("Gambol Settings")>
        Property GradientSwitchHead As Boolean
            Get
                Return IsGradBG
            End Get
            Set(value As Boolean)
                IsGradBG = value
            End Set
        End Property

        Private GradientMode As LinearGradientMode = LinearGradientMode.Horizontal
        <Description("Toggle switch head gradient mode"), Category("Gambol Settings")>
        Property GradientDirection As LinearGradientMode
            Get
                Return GradientMode
            End Get
            Set(value As LinearGradientMode)
                GradientMode = value
                Invalidate()
            End Set
        End Property

#End Region

#Region "Paint methods"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            g.Clear(BackColor)

            'Draw border and fill color(s)
            Dim ColorBorderLine As Color
            If Enabled Then
                ColorBorderLine = If(isHovered, ColorBorderActive, ColorBorderInactive)
            Else
                ColorBorderLine = Color.FromArgb(140, 140, 140)
            End If

            Using BPen As New Pen(ColorBorderLine) With {.Width = 1.9F}
                Dim X As Integer = Width - 1
                Dim Rect As New Rectangle(0, 0, X, ClientRectangle.Height - 1)
                g.DrawRectangle(BPen, Rect)
            End Using

            'Draw inner client and fill color(s)
            Dim ColorClientFill As Color

            If Enabled Then
                If isHovered Then
                    ColorClientFill = If(Checked, ColorSwitchOn, ColorSwitchHovered)
                Else
                    ColorClientFill = If(Checked, ColorSwitchOn, ColorSwitchOff)
                End If

            Else
                ColorClientFill = Color.FromArgb(170, 170, 170)
            End If

            Using SBrush As New SolidBrush(ColorClientFill)
                Dim X As Integer = Width - 4
                Dim Rect As New Rectangle(2, 2, X, (ClientRectangle.Height - 4))
                g.FillRectangle(SBrush, Rect)
            End Using

            'Draw split applied with inherited BackColor
            Dim ColorBackColor As Color = BackColor

            Using SBrush As New SolidBrush(ColorBackColor)
                Dim Int As Integer = CInt(If(Checked, Width - Width / 3 - 1, 0))
                Dim Rect As New Rectangle(Int, 0, CInt(ClientRectangle.Width / 3 + 1), ClientRectangle.Height)
                g.FillRectangle(SBrush, Rect)
            End Using

            'Draw switch and fill color(s)
            Dim ColorSwitchFill As Color
            Dim ColorFillGrad As Color

            If Enabled Then
                ColorSwitchFill = Color.FromArgb(180, 180, 180)
                ColorFillGrad = Color.FromArgb(160, 180, 180, 180)
            Else
                If Not Enabled Then
                    ColorSwitchFill = Color.FromArgb(115, 125, 135)
                    ColorFillGrad = Color.FromArgb(115, 125, 135)
                End If
            End If

            Using SBrush As New SolidBrush(ColorSwitchFill)
                Dim Int As Integer = CInt(If(Checked, Width - Width / 3, 0))
                Dim Rect As New Rectangle(Int, 0, CInt(Width / 3), Height)

                If GradientSwitchHead Then
                    Dim GradBrush As New LinearGradientBrush(Rect, ColorFillGrad, ColorSwitchFill, GradientDirection)
                    g.FillRectangle(GradBrush, Rect)
                Else
                    g.FillRectangle(SBrush, Rect)
                End If

            End Using

        End Sub

#End Region
#Region "Custom Methods"
        Private isHovered As Boolean = False
        Private Sub ProcessMouse(sender As Object, e As EventArgs)

            If ClientRectangle.Contains(PointToClient(MousePosition)) Then
                If Not isHovered Then
                    isHovered = True
                    Invalidate()
                End If
            Else
                If isHovered Then
                    isHovered = False
                    Invalidate()
                End If
            End If

        End Sub

#End Region
#Region "Overriden Methods"
        Protected Overrides Sub OnCheckedChanged(e As EventArgs)
            MyBase.OnCheckedChanged(e)
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            isHovered = False
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            isHovered = True
        End Sub
        Public Overrides Function GetPreferredSize(proposedSize As Size) As Size
            Dim preferredSize As Size = MyBase.GetPreferredSize(proposedSize)
            preferredSize.Width = 30
            preferredSize.Height = 14
            Return preferredSize
        End Function

#End Region

    End Class

End Namespace


