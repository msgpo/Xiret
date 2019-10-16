'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  Notifier.vb
'  Created by David S on 19.07.2019

Imports System.ComponentModel
Imports System.Linq

Namespace Notifier

    'USAGE:
    ' Notifier1.Controls.Add(Control, Int) eg. Notifier1.Controls.Add(Button1, 4)
    ' Notifier1.Activate()

    Partial Public Class Notifier
        Inherits Component
        Public ReadOnly Property Controls As Dictionary(Of Control, Integer)
        Public Sub New(ICont As IContainer)
            ICont.Add(Me)
            Controls = New Dictionary(Of Control, Integer)()
        End Sub
        Public Sub Activate()
            For Each Ctrl As Control In Controls.Keys
                AddHandler Ctrl.Paint, AddressOf DrawNotification
                Ctrl.Invalidate()
            Next
        End Sub
        Public Sub DeactivateControl(Control As Control)
            Controls.Remove(Control)
            Control.Invalidate()
        End Sub
        Public Sub DeactivateAll()
            For Each Ctrl As Control In Controls.Keys.ToList()
                Controls.Remove(Ctrl)
                Ctrl.Invalidate()
            Next
        End Sub

        Private Sub DrawNotification(ByVal sender As Object, ByVal e As PaintEventArgs)

            Dim Ctrl = CType(sender, Control)
            Dim CtrlRect As Rectangle
            Dim NotificationCount As Integer = 0

            If Ctrl IsNot Nothing AndAlso Controls.TryGetValue(Ctrl, NotificationCount) Then

                Using p As Pen = New Pen(Color.White, 2)
                    CtrlRect = New Rectangle(Ctrl.Width - 20, Ctrl.Height - Ctrl.Height + 8, 10, 10)
                    Dim g As Graphics = e.Graphics
                    g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    g.DrawEllipse(p, CtrlRect)
                    g.FillEllipse(New SolidBrush(Color.White), CtrlRect)
                    g.DrawString(If(NotificationCount > 9, "+", NotificationCount.ToString()), New Font(New FontFamily("Arial"), 6.0F, FontStyle.Bold),
                                 New SolidBrush(Color.FromArgb(30, 30, 30)), CtrlRect.X + 1, CtrlRect.Y - 1)
                End Using
            End If
        End Sub

    End Class

End Namespace


