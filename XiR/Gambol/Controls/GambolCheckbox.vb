'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolCheckbox.vb
'  Created by David S on 20.03.2016
'  Updated on 04.07.2019 - DS (Cleanup)

Imports System.ComponentModel

Imports Xiret.Gambol.Controls.Design

Namespace Gambol.Controls

    <Designer(GetType(GambolCheckboxDesigner))>
    Public Class GambolCheckbox
        Inherits CheckBox

#Region "Constructor"

        Public Sub New()

            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            FlatStyle = FlatStyle.Flat
            AddHandler MouseEnter, AddressOf ProcessMouse
            AddHandler MouseLeave, AddressOf ProcessMouse

        End Sub

#End Region

#Region "Properties"
        'Inactive border color (no mouse capture) property
        Private _cbBordercColor As Color = Color.FromArgb(115, 125, 135)
        Property BorderColor As Color
            Get
                Return _cbBordercColor
            End Get
            Set(value As Color)
                _cbBordercColor = value
                Invalidate()
            End Set
        End Property
        'Active border color (mouse is in client area) property
        Private _cbActiveBorderColor As Color = Color.FromArgb(45, 55, 65)
        Property ActiveBorderColor As Color
            Get
                Return _cbActiveBorderColor
            End Get
            Set(value As Color)
                _cbActiveBorderColor = value
                Invalidate()
            End Set
        End Property
        'Inner client area backcolor property
        Private _cbBgColor As Color = Color.White
        Property ClientBackColor As Color
            Get
                Return _cbBgColor
            End Get
            Set(value As Color)
                _cbBgColor = value
                Invalidate()
            End Set
        End Property
        'Inner client check color property
        Private _cbClientCheckColor As Color = Color.FromArgb(65, 75, 85)
        Property CheckedColor As Color
            Get
                Return _cbClientCheckColor
            End Get
            Set(ByVal value As Color)
                _cbClientCheckColor = value
                Invalidate()
            End Set
        End Property
        'Inner client active backcolor
        Private _cbClientActiveBackColor As Color = Color.FromArgb(20, 20, 20)
        Property ActiveBackColor As Color
            Get
                Return _cbClientActiveBackColor
            End Get
            Set(ByVal value As Color)
                _cbClientActiveBackColor = value
                Invalidate()
            End Set
        End Property
#End Region
#Region "Paint methods"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            Dim innerRect As Rectangle
            Dim outerRect As Rectangle

            g.Clear(BackColor)

            Dim diameter As Integer = ClientRectangle.Height - 1

            innerRect = New Rectangle(1, 1, diameter - 1, diameter - 1)
            outerRect = New Rectangle(1, 1, diameter - 2, diameter - 2)

            g.FillRectangle(New SolidBrush(_cbBgColor), innerRect)
            g.DrawRectangle(New Pen(_cbBordercColor), outerRect)

            If isHovered = True Then
                innerRect.Inflate(-1, -1)
                g.FillRectangle(New SolidBrush(_cbClientActiveBackColor), innerRect)
                e.Graphics.DrawRectangle(New Pen(_cbActiveBorderColor), outerRect)
            End If

            If Me.Checked Then
                innerRect = New Rectangle(1, 1, diameter - 1, diameter - 1)
                innerRect.Inflate(-4, -4)
                e.Graphics.FillRectangle(New SolidBrush(_cbClientCheckColor), innerRect)
            End If


            Dim textArea As Rectangle = New Rectangle(outerRect.Width + 5, 0, Width - outerRect.Width - 6, Height - 1)
            Dim textFormat As StringFormat = New StringFormat
            textFormat.LineAlignment = StringAlignment.Center
            e.Graphics.DrawRectangle(Pens.Transparent, textArea)

            If Enabled Then
                Using br = New SolidBrush(ForeColor)
                    e.Graphics.DrawString(Text, Font, br, textArea, textFormat)
                End Using
            Else
                Using br = New SolidBrush(Color.Black)
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
        Protected Overrides Sub OnResize(e As EventArgs)
            ResizeRedraw = True
            MyBase.OnResize(e)
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

    End Class

End Namespace



