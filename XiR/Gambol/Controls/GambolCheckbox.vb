'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolCheckbox.vb
'  Created by David S on 20.03.2016
'  Updated on 08.07.2019 - DS (Cleanup, enhanced properties, removed toolboxbitmap)

Imports System.ComponentModel

Imports Xiret.Gambol.Controls.Design

Namespace Gambol.Controls

    <Designer(GetType(GambolCheckboxDesigner))>
    Public Class GambolCheckbox
        Inherits CheckBox

        Public Sub New()

            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            FlatStyle = FlatStyle.Flat
            AddHandler MouseEnter, AddressOf ProcessMouse
            AddHandler MouseLeave, AddressOf ProcessMouse

        End Sub

#Region "Properties"

        Private pInactiveBorderColor As Color = Color.FromArgb(180, 180, 180)
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

        Private pActiveBorderColor As Color = Color.White
        <Description("Check area mouseover border color"),
        Category("Gambol Appearence")>
        Property ActiveBorderColor As Color
            Get
                Return pActiveBorderCOlor
            End Get
            Set(value As Color)
                pActiveBorderColor = value
                Invalidate()
            End Set
        End Property

        Private pCheckboxBackColor As Color = Color.FromArgb(40, 40, 40)
        <Description("Check area backcolor"),
        Category("Gambol Appearence")>
        Property CheckboxBackColor As Color
            Get
                Return pCheckboxBackColor
            End Get
            Set(value As Color)
                pCheckboxBackColor = value
                Invalidate()
            End Set
        End Property

        Private pActiveCheckboxBackColor As Color = Color.FromArgb(20, 20, 20)
        <Description("Check area mouseover color"),
        Category("Gambol Appearence")>
        Property ActiveCheckboxBackColor As Color
            Get
                Return pActiveCheckboxBackColor
            End Get
            Set(value As Color)
                pActiveCheckboxBackColor = value
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
            Dim innerRect As Rectangle
            Dim outerRect As Rectangle

            g.Clear(BackColor)

            Dim diameter As Integer = ClientRectangle.Height - 1

            innerRect = New Rectangle(1, 1, diameter - 1, diameter - 1)
            outerRect = New Rectangle(1, 1, diameter - 2, diameter - 2)

            g.FillRectangle(New SolidBrush(CheckboxBackColor), innerRect)
            g.DrawRectangle(New Pen(InactiveBorderColor), outerRect)

            If MouseHovered = True Then
                innerRect.Inflate(-1, -1)
                g.FillRectangle(New SolidBrush(ActiveCheckboxBackColor), innerRect)
                e.Graphics.DrawRectangle(New Pen(ActiveBorderColor), outerRect)
            End If

            If Checked Then
                innerRect = New Rectangle(1, 1, diameter - 1, diameter - 1)
                innerRect.Inflate(-4, -4)
                e.Graphics.FillRectangle(New SolidBrush(CheckedColor), innerRect)
            End If


            Dim textArea As Rectangle = New Rectangle(outerRect.Width + 5, 0, Width - outerRect.Width - 6, Height - 1)
            Dim textFormat As StringFormat = New StringFormat With {
                .LineAlignment = StringAlignment.Center
            }

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
            MouseHovered = False
        End Sub
        Protected Overrides Sub OnMouseEnter(eventargs As EventArgs)
            MyBase.OnMouseEnter(eventargs)
            MouseHovered = True
        End Sub
        Protected Overrides Sub OnResize(e As EventArgs)
            ResizeRedraw = True
            MyBase.OnResize(e)
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

    End Class

End Namespace



