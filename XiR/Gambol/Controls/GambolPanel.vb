'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  GambolPanel.vb
'  Created by David S on 20.03.2016
'  Updated on 04.07.2019 - DS (Cleanup)

#Region "Directives"

Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Design
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.Design

#End Region

Namespace Gambol.Controls

    <Designer(GetType(ParentControlDesigner)), ToolboxBitmap(GetType(Panel))> _
    Public Class GambolPanel
        Inherits Panel

#Region "Constructor"

        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            DoubleBuffered = True
        End Sub

#End Region

#Region "Enum"
        Enum SeperatorType
            Left
            Top
            Right
            Bottom
        End Enum
#End Region
#Region "Properties"

        Private BoolShowBlend As Boolean = False
        <Description("Background primary color"), _
        Category("Gambol Appearence")> _
        Property BackgroundBlend As Boolean
            Get
                Return BoolShowBlend
            End Get
            Set(value As Boolean)
                BoolShowBlend = value
            End Set
        End Property

        Private FirstColor As Color = Color.FromArgb(31, 34, 41)
        <Description("Background primary color"), _
        Category("Gambol Appearence")> _
        Property BlendPrimaryColor As Color
            Get
                Return FirstColor
            End Get
            Set(value As Color)
                FirstColor = value
                Invalidate()
            End Set
        End Property

        Private SecondaryColor As Color = Color.FromArgb(41, 44, 51)
        <Description("Background primary color"), _
        Category("Gambol Appearence")> _
        Property BlendSecondColor As Color
            Get
                Return SecondaryColor
            End Get
            Set(value As Color)
                SecondaryColor = value
                Invalidate()
            End Set
        End Property

        Private GradientMode As LinearGradientMode = LinearGradientMode.Horizontal
        <Description("Background gradient mode"),
        Category("Gambol Settings")>
        Property GradientDirection As LinearGradientMode
            Get
                Return GradientMode
            End Get
            Set(value As LinearGradientMode)
                GradientMode = value
                Invalidate()
            End Set
        End Property

        Private InterpolationType As InterpolationMode = InterpolationMode.Default
        <Description("Set the controls Interpolation type"), _
        Category("Rendering")> _
        Property Interpolation As InterpolationMode
            Get
                Return InterpolationType
            End Get
            Set(value As InterpolationMode)
                InterpolationType = value
                Invalidate()
            End Set
        End Property

        Private SmoothingType As SmoothingMode = SmoothingMode.None
        <Description("Set the controls Smoothing type"), _
        Category("Rendering")> _
        Property Smoothing As SmoothingMode
            Get
                Return SmoothingType
            End Get
            Set(value As SmoothingMode)
                SmoothingType = value
                Invalidate()
            End Set
        End Property

        Private HasSeperator As Boolean = False
        <Description("Determine if the control has an edge seperator"), _
        Category("Gambol Properties")> _
        Property ShowSeperator As Boolean
            Get
                Return HasSeperator
            End Get
            Set(value As Boolean)
                HasSeperator = value
                Invalidate()
            End Set
        End Property

        Private SepLocation As SeperatorType = SeperatorType.Left
        <Description("Set the control edge seperator location"), _
        Category("Gambol Properties")> _
        Property SeperatorLocation As SeperatorType
            Get
                Return SepLocation
            End Get
            Set(value As SeperatorType)
                SepLocation = value
                Invalidate()
            End Set
        End Property
        Private SepColor As Color = Color.FromArgb(100, 100, 100)
        <Description("Set the control edge seperator color"), _
        Category("Gambol Properties")> _
        Property SeperatorColor As Color
            Get
                Return SepColor
            End Get
            Set(value As Color)
                SepColor = value
            End Set
        End Property

#End Region

#Region "OnPaint"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim g As Graphics = e.Graphics

            Dim rect As New Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height)

            If BoolShowBlend Then
                Using b As New LinearGradientBrush(rect, FirstColor, SecondaryColor, GradientDirection)
                    g.SmoothingMode = SmoothingType
                    g.InterpolationMode = InterpolationType
                    g.FillRectangle(b, rect)
                End Using
            End If

            If HasSeperator Then
                Using p As New Pen(SepColor) With {.Width = 1.0F}
                    Select Case SeperatorLocation
                        Case SeperatorType.Left
                            g.DrawLine(p, 0, 0, 0, Height)
                        Case SeperatorType.Top
                            g.DrawLine(p, 0, 0, Width, 0)
                        Case SeperatorType.Right
                            g.DrawLine(p, Width - 1, 0, Width - 1, Height)
                        Case SeperatorType.Bottom
                            g.DrawLine(p, 0, Height - 1, Width, Height - 1)
                    End Select
                End Using
            End If

        End Sub

#End Region

    End Class

End Namespace


