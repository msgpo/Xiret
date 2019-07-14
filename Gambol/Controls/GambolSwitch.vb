'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Gambol UI
'  GambolSwitch.vb
'  Created by David S on 20.03.2016
'  Updated on 09.07.2019 - DS (Cleanup, enhanced properties, removed gradientswitch code and properties, removed toolboxbitmap)

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Gambol.Controls.Design

Namespace Controls

    <Designer(GetType(GambolSwitchDesigner))>
    Public Class GambolSwitch
        Inherits CheckBox
        Public Sub New()

            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            DoubleBuffered = True

            AddHandler MouseEnter, AddressOf ProcessMouse
            AddHandler MouseLeave, AddressOf ProcessMouse

        End Sub

#Region "Properties"

        Private pInactiveBorderColor As Color = Color.FromArgb(140, 140, 140)
        <Description("Set the control border color."),
        Category("Gambol Appearance")>
        Property InactiveBorderColor As Color
            Get
                Return pInactiveBorderColor
            End Get
            Set(value As Color)
                pInactiveBorderColor = value
                Invalidate()
            End Set
        End Property

        Private pActiveBorderColor As Color = Color.White
        <Description("Set the control mouseover border color."),
        Category("Gambol Appearance")>
        Property ActiveBorderColor As Color
            Get
                Return pActiveBorderColor
            End Get
            Set(value As Color)
                pActiveBorderColor = value
                Invalidate()
            End Set
        End Property

        Private pSwitchHeadColor As Color = Color.FromArgb(180, 180, 180)
        <Description("Set the switch head color"),
        Category("Gambol Appearance")>
        Property SwitchHeadColor As Color
            Get
                Return pSwitchHeadColor
            End Get
            Set(value As Color)
                pSwitchHeadColor = value
                Invalidate()
            End Set
        End Property

        Private pSwitchOnColor As Color = Color.FromArgb(120, 180, 0)
        <Description("Set the control toggle on color."),
        Category("Gambol Appearance")>
        Property SwitchOnColor As Color
            Get
                Return pSwitchOnColor
            End Get
            Set(value As Color)
                pSwitchOnColor = value
                Invalidate()
            End Set
        End Property

        Private pSwitchOffColor As Color = Color.FromArgb(40, 40, 40)
        <Description("Set the control toggle off color."),
        Category("Gambol Appearance")>
        Property SwitchOffColor As Color
            Get
                Return pSwitchOffColor
            End Get
            Set(value As Color)
                pSwitchOffColor = value
                Invalidate()
            End Set
        End Property

        Private pActiveBackgroundColor As Color = Color.FromArgb(20, 20, 20)
        <Description("Sets the mouseover background color when the switch is set to off."),
        Category("Gambol Appearance")>
        Property ActiveBackgroundColor As Color
            Get
                Return pActiveBackgroundColor
            End Get
            Set(value As Color)
                pActiveBackgroundColor = value
                Invalidate()
            End Set
        End Property

#End Region

#Region "Paint methods"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            g.Clear(BackColor)

            Dim ColorBorderLine As Color
            If Enabled Then
                ColorBorderLine = If(MouseHovered, ActiveBorderColor, InactiveBorderColor)
            Else
                ColorBorderLine = Color.FromArgb(140, 140, 140)
            End If

            Using BPen As New Pen(ColorBorderLine) With {.Width = 1.9F}
                Dim X As Integer = Width - 1
                Dim Rect As New Rectangle(0, 0, X, ClientRectangle.Height - 1)
                g.DrawRectangle(BPen, Rect)
            End Using

            Dim ColorClientFill As Color

            If Enabled Then
                If MouseHovered Then
                    ColorClientFill = If(Checked, SwitchOnColor, ActiveBackgroundColor)
                Else
                    ColorClientFill = If(Checked, SwitchOnColor, pSwitchOffColor)
                End If

            Else
                ColorClientFill = Color.FromArgb(170, 170, 170)
            End If

            Using SBrush As New SolidBrush(ColorClientFill)
                Dim X As Integer = Width - 4
                Dim Rect As New Rectangle(2, 2, X, (ClientRectangle.Height - 4))
                g.FillRectangle(SBrush, Rect)
            End Using

            Dim ColorBackColor As Color = BackColor

            Using SBrush As New SolidBrush(ColorBackColor)
                Dim Int As Integer = CInt(If(Checked, Width - Width / 3 - 1, 0))
                Dim Rect As New Rectangle(Int, 0, CInt(ClientRectangle.Width / 3 + 1), ClientRectangle.Height)
                g.FillRectangle(SBrush, Rect)
            End Using

            Using SBrush As New SolidBrush(SwitchHeadColor)
                Dim Int As Integer = CInt(If(Checked, Width - Width / 3, 0))
                Dim Rect As New Rectangle(Int, 0, CInt(Width / 3), Height)
                g.FillRectangle(SBrush, Rect)
            End Using

        End Sub

#End Region
#Region "Custom Methods"
        Private MouseHovered As Boolean = False
        Private Sub ProcessMouse(sender As Object, e As EventArgs)

            If ClientRectangle.Contains(PointToClient(MousePosition)) Then
                If Not MouseHovered Then
                    MouseHovered = True
                    Invalidate()
                End If
            Else
                If MouseHovered Then
                    MouseHovered = False
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
            MouseHovered = False
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            MouseHovered = True
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


