'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolProgressBar.vb
'  Created by David S on 20.03.2016
'  Updated on 08.07.2019 - DS (Cleanup, enhanced properties, removed toolboxbitmap)

Imports System.ComponentModel

Namespace Gambol.Controls

    <ToolboxBitmap(GetType(ProgressBar))>
    Public Class GambolProgressBar
        Inherits Control

        Sub New()
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
        End Sub

#Region "Properties"
        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim CP As CreateParams = MyBase.CreateParams
                CP.Style = CP.Style Or &H20
                Return CP
            End Get
        End Property

        Private pBorderColor As Color = Color.FromArgb(180, 180, 180)
        <Description("Set the progressbar border color. Ignored when ShowBorder value is 'False'."),
        Category("Gambol Appearance")>
        Property BorderColor As Color
            Get
                Return pBorderColor
            End Get
            Set(value As Color)
                pBorderColor = value
                Invalidate()
            End Set
        End Property

        Private pProgressColor As Color = Color.FromArgb(120, 180, 0)
        <Description("Set the progressbar progress color"),
        Category("Gambol Appearance")>
        Property ProgressColor As Color
            Get
                Return pProgressColor
            End Get
            Set(value As Color)
                pProgressColor = value
                Invalidate()
            End Set
        End Property

        Private pShowBorder As Boolean = True
        <Description("Determine if the control has an outer border."),
        Category("Gambol Appearance")>
        Property ShowBorder As Boolean
            Get
                Return pShowBorder
            End Get
            Set(value As Boolean)
                pShowBorder = value
                Invalidate()
            End Set
        End Property

        Dim pValue As Integer = 0
        <Description("Set the current value for the progressbar."),
        Category("Gambol Behavior")>
        Property Value As Integer
            Get
                Return pValue
            End Get
            Set(ByVal val As Integer)
                If val <= pMaximum Then pValue = val Else Throw New Exception("Invalid value entered")
                Invalidate()
            End Set
        End Property

        Dim pMaximum As Integer = 100
        <Description("Set the upper bound maximum range for the progressbar."),
        Category("Gambol Behavior")>
        Property Maximum As Integer
            Get
                Return pMaximum
            End Get
            Set(ByVal value As Integer)
                If value >= pValue Then pMaximum = value Else Throw New Exception("Invalid value entered")
                Invalidate()
            End Set
        End Property

#End Region
#Region "Paint methods"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics
            Dim dbl As Double
            g.Clear(BackColor)

            If ShowBorder Then
                dbl = PValue / PMaximum * (Width - 2)
                g.FillRectangle(New SolidBrush(Color.FromArgb(20, BackColor)), New Rectangle(0, 0, Width - 1, Height - 1))
                If dbl > 0 Then g.FillRectangle(New SolidBrush(ProgressColor), New Rectangle(1, 1, CInt(dbl), Height - 2))
                g.DrawRectangle(New Pen(BorderColor), New Rectangle(0, 0, Width - 1, Height - 1))
            Else
                If Not ShowBorder Then
                    dbl = PValue / PMaximum * (Width)
                    g.FillRectangle(New SolidBrush(Color.FromArgb(20, BackColor)), New Rectangle(0, 0, Width, Height))
                    If dbl > 0 Then g.FillRectangle(New SolidBrush(ProgressColor), New Rectangle(0, 0, CInt(dbl), Height))
                End If
            End If

        End Sub

#End Region

    End Class

End Namespace



