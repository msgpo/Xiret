'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolProgressBar.vb
'  Created by David S on 20.03.2016
'  Updated on 04.07.2019 - DS (Cleanup)

Imports System.ComponentModel

Namespace Gambol.Controls

    <ToolboxBitmap(GetType(ProgressBar))>
    Public Class GambolProgressBar
        Inherits Control

        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim CP As CreateParams = MyBase.CreateParams
                CP.Style = CP.Style Or &H20
                Return CP
            End Get
        End Property

#Region "Constructor"

        Sub New()
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
        End Sub

#End Region
#Region "Properties"

        Dim _pbBackColor As Color = Color.FromArgb(180, 180, 180)
        <Description("Set the control border color. Ignored when ShowBorder value is 'False'."),
        Category("Gambol Appearance")>
        Property BorderColor As Color
            Get
                Return _pbBackColor
            End Get
            Set(ByVal value As Color)
                _pbBackColor = value
                Invalidate()
            End Set
        End Property

        Dim _pcolor As Color = Color.FromArgb(120, 180, 0)
        <Description("Set the control progress loading color."),
        Category("Gambol Appearance")>
        Property ProgressColor As Color
            Get
                Return _pcolor
            End Get
            Set(ByVal value As Color)
                _pcolor = value
                Invalidate()
            End Set
        End Property

        Dim _v As Integer = 0
        <Description("The current value for the progressbar."),
        Category("Gambol Behavior")>
        Property Value As Integer
            Get
                Return _v
            End Get
            Set(ByVal v As Integer)
                If v <= _m Then _v = v Else Throw New Exception("Invalid value entered")
                Invalidate()
            End Set
        End Property

        Dim _m As Integer = 100
        <Description("Upper bound maximum range for the progressbar."),
        Category("Gambol Behavior")>
        Property Maximum As Integer
            Get
                Return _m
            End Get
            Set(ByVal value As Integer)
                If value >= _v Then _m = value Else Throw New Exception("Invalid value entered")
            End Set
        End Property

        Dim b As Boolean = True
        <Description("Setting to determine if the control has an outer border."),
        Category("Gambol Appearance")>
        Property ShowBorder As Boolean
            Get
                Return b
            End Get
            Set(value As Boolean)
                b = value
            End Set
        End Property

#End Region
#Region "Paint methods"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            Dim p As Double
            g.Clear(BackColor)

            If b Then
                p = _v / _m * (Width - 2)
                g.FillRectangle(New SolidBrush(Color.FromArgb(20, BackColor)), New Rectangle(0, 0, Width - 1, Height - 1))
                If p > 0 Then g.FillRectangle(New SolidBrush(_pcolor), New Rectangle(1, 1, CInt(p), Height - 2))
                g.DrawRectangle(New Pen(_pbBackColor), New Rectangle(0, 0, Width - 1, Height - 1))
            Else
                If Not b Then
                    p = _v / _m * (Width)
                    g.FillRectangle(New SolidBrush(Color.FromArgb(20, BackColor)), New Rectangle(0, 0, Width, Height))
                    If p > 0 Then g.FillRectangle(New SolidBrush(_pcolor), New Rectangle(0, 0, CInt(p), Height))
                End If
            End If

        End Sub

#End Region

    End Class

End Namespace



