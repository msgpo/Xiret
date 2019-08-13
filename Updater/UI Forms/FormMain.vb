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

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Application.Exit()
    End Sub

#End Region
#Region "WebClient"
    'Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    '    If CheckConnection(bitmight_wa) = True Then

    '        Dim fbd As New FolderBrowserDialog

    '        With fbd
    '            .ShowNewFolderButton = True
    '            .Description = "Select a location you would like the update to be stored"
    '        End With

    '        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then

    '            CType(sender, Button).Hide()
    '            lbdli.Show()
    '            pbUpdate.Show()

    '            Dim wclientup As WebClient = New WebClient
    '            AddHandler wclientup.DownloadProgressChanged, AddressOf client_ProgressChanged
    '            AddHandler wclientup.DownloadFileCompleted, AddressOf client_DownloadCompleted

    '            If CheckConnection(bitmight_wa) = True Then
    '                wclientup.DownloadFileAsync(New Uri("https://www.bitmight.uk/software/xiret/download/xiret.zip"), strPath & "\xiret.zip")
    '            Else
    '                'Server down
    '            End If
    '        End If
    '    Else
    '        SendToastToScreen("Warning", "Could not reach bitmight.uk server", ct_body, ct_border, ct_orange, Color.FromArgb(210, 210, 210), False)
    '    End If

    'End Sub
    'Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

    '    Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
    '    Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
    '    Dim percentage As Double = bytesIn / totalBytes * 100

    '    'lbdli.Text = "Downloading: " & Int32.Parse(Math.Truncate(percentage).ToString()) & "%"
    '    BtnUpdate.Refresh()

    '    'pbUpdate.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    '    'pbUpdate.Refresh()

    'End Sub
    'Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

    '    BtnUpdate.Show()
    '    'lbdli.Text = "Initializing..."
    '    'lbdli.Hide()
    '    'pbUpdate.Value = 0
    '    'pbUpdate.Hide()

    '    Dim strFull As String = strPath & "\xiret.zip"

    '    If IO.File.Exists(strFull) = True Then
    '        Process.Start(strFull)
    '    End If

    'End Sub

#End Region

End Class
