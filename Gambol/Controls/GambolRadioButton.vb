'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Gambol UI
'  GambolRadioButton.vb
'  Created by David S on 20.03.2016
'  Updated on 08.07.2019 - DS (Cleanup, enhanced properties, rmoved toolboxbitmap)

Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Gambol.Controls.Design

Namespace Controls

    <Designer(GetType(GambolRadioButtonDesigner))>
    Public Class GambolRadioButton
        Inherits RadioButton

#Region "Constructor"

        Public Sub New()

            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)

            AddHandler MouseEnter, AddressOf ProcessMouse
            AddHandler MouseLeave, AddressOf ProcessMouse

        End Sub

#End Region

#Region "Properties"

        Private pInactiveBorderColor As Color = Color.FromArgb(80, 80, 80)
        <Description("Check area border color"),
        Category("Gambol Appearence")>
        Property InactiveBorderColor As Color
            Get
                Return pInactiveBorderColor
            End Get
            Set(value As Color)
                pInactiveBorderColor = value
                Invalidate()
            End Set
        End Property

        Private pActiveBorderColor As Color = Color.FromArgb(160, 160, 160)
        <Description("Check area mouseover border color"),
        Category("Gambol Appearence")>
        Property ActiveBorderColor As Color
            Get
                Return pActiveBorderColor
            End Get
            Set(value As Color)
                pActiveBorderColor = value
                Invalidate()
            End Set
        End Property

        Private pRadioBackColor As Color = Color.FromArgb(40, 40, 40)
        <Description("Check area backcolor"),
        Category("Gambol Appearence")>
        Property RadioBackColor As Color
            Get
                Return pRadioBackColor
            End Get
            Set(value As Color)
                pRadioBackColor = value
                Invalidate()
            End Set
        End Property

        Private pActiveRadioBackColor As Color = Color.FromArgb(20, 20, 20)
        <Description("Check area mouseover color"),
        Category("Gambol Appearence")>
        Property ActiveRadioBackColor As Color
            Get
                Return pActiveRadioBackColor
            End Get
            Set(value As Color)
                pActiveRadioBackColor = value
                Invalidate()
            End Set
        End Property

        Private pCheckedColor As Color = Color.FromArgb(120, 180, 0)
        <Description("Control checked color"),
        Category("Gambol Appearence")>
        Property CheckedColor As Color
            Get
                Return pCheckedColor
            End Get
            Set(value As Color)
                pCheckedColor = value
                Invalidate()
            End Set
        End Property
#End Region
#Region "Paint methods"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            Dim innerRect As RectangleF
            Dim outerRect As RectangleF

            g.Clear(BackColor)

            Dim diameter As Integer = ClientRectangle.Height - 1
            outerRect = New RectangleF(0, 0, diameter, diameter)
            innerRect = New RectangleF(1, 1, diameter - 2, diameter - 2)

            g.SmoothingMode = SmoothingMode.AntiAlias

            g.FillEllipse(New SolidBrush(RadioBackColor), innerRect)
            g.DrawEllipse(New Pen(InactiveBorderColor), innerRect)
            outerRect.Inflate(-1, -1)

            If MouseHovered = True Then
                g.DrawArc(New Pen(ActiveBorderColor, 1), outerRect, 135, 180)
                g.DrawArc(New Pen(ActiveBorderColor, 1), outerRect, -45, 180)
                innerRect.Inflate(-1, -1)
                g.FillEllipse(New SolidBrush(ActiveRadioBackColor), innerRect)
            End If

            If Checked Then
                innerRect = New RectangleF(1, 1, diameter - 2, diameter - 2)
                innerRect.Inflate(-4, -4)
                g.FillEllipse(New SolidBrush(CheckedColor), innerRect)
            End If

            Dim textArea As Rectangle = New Rectangle(CInt(outerRect.Width + 5), 0, CInt(Width - outerRect.Width - 6), Height - 1)
            Dim textFormat As StringFormat = New StringFormat With {
                .LineAlignment = StringAlignment.Center
            }

            e.Graphics.DrawRectangle(Pens.Transparent, textArea)

            If Enabled Then
                Using br = New SolidBrush(ForeColor)
                    e.Graphics.DrawString(Text, Font, br, textArea, textFormat)
                End Using
            Else
                Using br = New SolidBrush(Color.FromArgb(100, 100, 100))
                    e.Graphics.DrawString(Text, Font, br, textArea, textFormat)
                End Using
            End If


        End Sub

#End Region
#Region "Overriden Methods"

        Protected Overrides Sub OnCheckedChanged(e As EventArgs)
            MyBase.OnCheckedChanged(e)
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(eventargs As EventArgs)
            MyBase.OnMouseLeave(eventargs)
            MouseHovered = False
        End Sub

        Protected Overrides Sub OnMouseEnter(eventargs As EventArgs)
            MyBase.OnMouseEnter(eventargs)
            MouseHovered = True
        End Sub

#End Region
#Region "Custom Methods"

        Private MouseHovered As Boolean = False
        Private Sub ProcessMouse(sender As Object, e As EventArgs)

            If ClientRectangle.Contains(PointToClient(MousePosition)) Then
                If Not MouseHovered Then
                    MouseHovered = True
                    Invalidate()
                Else
                    If MouseHovered Then
                        MouseHovered = False
                        Invalidate()
                    End If
                End If
            End If

        End Sub

#End Region

    End Class

End Namespace




