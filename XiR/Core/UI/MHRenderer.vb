'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  MHRenderer.vb
'  Created by David S
'  Updated on 10.06.2019 - DR (Enhanced colours)

Namespace Core.UI

    Public Class MHRenderer
        Inherits ToolStripProfessionalRenderer

        Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)

            Try
                Dim r As New Rectangle(Point.Empty, e.Item.Size)
                Dim c As Color = CType(IIf(e.Item.Selected, Color.FromArgb(20, 20, 20), Color.FromArgb(38, 38, 38)), Color)
                Using b As New SolidBrush(c)
                    e.Graphics.FillRectangle(b, r)
                End Using
            Catch ex As Exception
            End Try

        End Sub
        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)

            If e.Vertical OrElse TryCast(e.Item, ToolStripSeparator) Is Nothing Then
                MyBase.OnRenderSeparator(e)
            Else
                Dim sep As Rectangle = New Rectangle(Point.Empty, e.Item.Size)
                Using b = New SolidBrush(Color.FromArgb(38, 38, 38))
                    e.Graphics.FillRectangle(b, sep)
                End Using
                Dim y As Integer = CInt(sep.Bottom - (sep.Height / 2) - 1)
                Dim l As Integer = sep.Left + 5
                Dim r As Integer = sep.Right - 5
                Using b = New SolidBrush(Color.FromArgb(100, 100, 100))
                    e.Graphics.DrawLine(New Pen(b), l, y, r, y)
                End Using
            End If
        End Sub

    End Class

End Namespace


