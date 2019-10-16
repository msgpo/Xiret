'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  GambolPanel.vb
'  Created by David S on 20.03.2016
'  Updated on 07.07.2019 - DS (Cleanup, enhanced properties, removed toolboxbitmap, fixed designer error)

Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.Design

Namespace Controls

    <Designer(GetType(ParentControlDesigner))>
    Public Class GambolPanel
        Inherits Panel

        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            DoubleBuffered = True
        End Sub

#Region "Enum"
        Enum SeperatorType
            Left
            Top
            Right
            Bottom
        End Enum
#End Region
#Region "Properties"

        Private pBlendBackground As Boolean = False
        <Description("Determine if the panel has background blending"),
        Category("Gambol Appearence")>
        Property BlendBackground As Boolean
            Get
                Return pBlendBackground
            End Get
            Set(value As Boolean)
                pBlendBackground = value
                Invalidate()
            End Set
        End Property

        Private pBlendPrimaryColor As Color = Color.FromArgb(30, 30, 30)
        <Description("Background blending primary color"),
        Category("Gambol Appearence")>
        Property BlendPrimaryColor As Color
            Get
                Return pBlendPrimaryColor
            End Get
            Set(value As Color)
                pBlendPrimaryColor = value
                Invalidate()
            End Set
        End Property

        Private pBlendSecondaryColor As Color = Color.FromArgb(80, 80, 80)
        <Description("Background blending secondary color"),
        Category("Gambol Appearence")>
        Property BlendSecondaryColor As Color
            Get
                Return pBlendSecondaryColor
            End Get
            Set(value As Color)
                pBlendSecondaryColor = value
                Invalidate()
            End Set
        End Property

        Private pBlendDirection As LinearGradientMode = LinearGradientMode.Horizontal
        <Description("Background blend direction"),
        Category("Gambol Appearence")>
        Property BlendDirection As LinearGradientMode
            Get
                Return pBlendDirection
            End Get
            Set(value As LinearGradientMode)
                pBlendDirection = value
                Invalidate()
            End Set
        End Property

        Private pSmoothing As SmoothingMode = SmoothingMode.None
        <Description("Set the panels Smoothing type"),
        Category("Gambol Rendering")>
        Property Smoothing As SmoothingMode
            Get
                Return pSmoothing
            End Get
            Set(value As SmoothingMode)
                If value = SmoothingMode.Invalid Then
                    'Fix designer error (08.07.2019)
                    pSmoothing = pSmoothing
                    MessageBox.Show("Cannot use this mode. Nothing was changed.", "Gambol.Controls", MessageBoxButtons.OK)
                Else
                    pSmoothing = value
                End If
                Invalidate()
            End Set
        End Property

        Private pShowSeperator As Boolean = False
        <Description("Determine if the panel has an edge seperator"),
        Category("Gambol Properties")>
        Property ShowSeperator As Boolean
            Get
                Return pShowSeperator
            End Get
            Set(value As Boolean)
                pShowSeperator = value
                Invalidate()
            End Set
        End Property

        Private pSeperatorLocation As SeperatorType = SeperatorType.Left
        <Description("Set the panels edge seperator location"),
        Category("Gambol Properties")>
        Property SeperatorLocation As SeperatorType
            Get
                Return pSeperatorLocation
            End Get
            Set(value As SeperatorType)
                pSeperatorLocation = value
                Invalidate()
            End Set
        End Property

        Private pSeperatorColor As Color = Color.FromArgb(100, 100, 100)
        <Description("Set the panels edge seperator color"),
        Category("Gambol Properties")>
        Property SeperatorColor As Color
            Get
                Return pSeperatorColor
            End Get
            Set(value As Color)
                pSeperatorColor = value
                Invalidate()
            End Set
        End Property

#End Region

#Region "OnPaint"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)

            Dim G As Graphics = e.Graphics
            Dim ControlRectangle As New Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height)

            If BlendBackground Then
                Using LGBrush As New LinearGradientBrush(ControlRectangle, BlendPrimaryColor, BlendSecondaryColor, BlendDirection)
                    G.SmoothingMode = Smoothing
                    G.FillRectangle(LGBrush, ControlRectangle)
                End Using
            Else
                Dim SBrush As Brush = New SolidBrush(BackColor)
                G.FillRectangle(SBrush, ControlRectangle)
            End If

            If ShowSeperator Then
                Using SepPen As New Pen(SeperatorColor) With {.Width = 1.0F}
                    Select Case SeperatorLocation
                        Case SeperatorType.Left
                            G.DrawLine(SepPen, 0, 0, 0, Height)
                        Case SeperatorType.Top
                            G.DrawLine(SepPen, 0, 0, Width, 0)
                        Case SeperatorType.Right
                            G.DrawLine(SepPen, Width - 1, 0, Width - 1, Height)
                        Case SeperatorType.Bottom
                            G.DrawLine(SepPen, 0, Height - 1, Width, Height - 1)
                    End Select
                End Using
            End If

        End Sub

#End Region

    End Class

End Namespace


