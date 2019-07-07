'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolRadioButton.vb
'  Created by David S on 20.03.2016
'  Updated on 04.07.2019 - DS (Cleanup)

Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Imports Xiret.Gambol.Controls.Design

Namespace Gambol.Controls

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
        Dim _rbBackground As Color = Color.White
        Property ClientBackColor As Color
            Get
                Return _rbBackground
            End Get
            Set(value As Color)
                _rbBackground = value
                Invalidate()
            End Set
        End Property
        Dim _rbBorderColor As Color = Color.FromArgb(115, 125, 135)
        Property BorderColor As Color
            Get
                Return _rbBorderColor
            End Get
            Set(ByVal value As Color)
                _rbBorderColor = value
                Invalidate()
            End Set
        End Property

        Dim _rbActiveBorderColor As Color = Color.FromArgb(45, 55, 65)
        Property ActiveBorderColor As Color
            Get
                Return _rbActiveBorderColor
            End Get
            Set(value As Color)
                _rbActiveBorderColor = value
                Invalidate()
            End Set
        End Property

        Dim _rbCheckedColor As Color = Color.FromArgb(65, 75, 85)
        Property CheckedColor As Color
            Get
                Return _rbCheckedColor
            End Get
            Set(ByVal value As Color)
                _rbCheckedColor = value
                Invalidate()
            End Set
        End Property
        'Inner client active backcolor
        Private _rbClientActiveBackColor As Color = Color.FromArgb(20, 20, 20)
        Property ActiveBackColor As Color
            Get
                Return _rbClientActiveBackColor
            End Get
            Set(ByVal value As Color)
                _rbClientActiveBackColor = value
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

            g.FillEllipse(New SolidBrush(_rbBackground), innerRect)
            g.DrawEllipse(New Pen(_rbBorderColor), innerRect)
            outerRect.Inflate(-1, -1)

            If isHovered = True Then
                g.DrawArc(New Pen(_rbActiveBorderColor, 1), outerRect, 135, 180)
                g.DrawArc(New Pen(_rbActiveBorderColor, 1), outerRect, -45, 180)
                innerRect.Inflate(-1, -1)
                g.FillEllipse(New SolidBrush(_rbClientActiveBackColor), innerRect)
            End If

            If Checked Then
                innerRect = New RectangleF(1, 1, diameter - 2, diameter - 2)
                innerRect.Inflate(-4, -4)
                g.FillEllipse(New SolidBrush(_rbCheckedColor), innerRect)
            End If

            Dim textArea As Rectangle = New Rectangle(CInt(outerRect.Width + 5), 0, CInt(Width - outerRect.Width - 6), Height - 1)
            Dim textFormat As StringFormat = New StringFormat
            textFormat.LineAlignment = StringAlignment.Center
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
            isHovered = False
        End Sub

        Protected Overrides Sub OnMouseEnter(eventargs As EventArgs)
            MyBase.OnMouseEnter(eventargs)
            isHovered = True
        End Sub

#End Region
#Region "Custom Methods"

        Private isHovered As Boolean = False
        Private Sub ProcessMouse(sender As Object, e As EventArgs)

            If ClientRectangle.Contains(PointToClient(MousePosition)) Then
                If Not isHovered Then
                    isHovered = True
                    Invalidate()
                Else
                    If isHovered Then
                        isHovered = False
                        Invalidate()
                    End If
                End If
            End If

        End Sub

#End Region

    End Class

End Namespace




