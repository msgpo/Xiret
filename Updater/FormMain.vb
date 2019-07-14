Public Class FormMain

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Event"
    Private Sub FormAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

#End Region

End Class
