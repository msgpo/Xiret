'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  Some ContextMenu settings are overriden by Gambol\UI\MHRenderer like background color, etc
'  FormMain.vb
'  Created by David S on 24.03.2016
'  Updated on 09.07.2019 - DS (Updated Imgur code)

Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Threading

Imports Xiret.Base.WSR
Imports Xiret.Base.WinsatApi
Imports Xiret.Base.Helpers
Imports Xiret.Base.Converters

Imports Gambol.UI

Public Class FormMain

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove,
        lbHeadVer.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "CreateParams"
    Const WS_MINIMIZEBOX As Integer = &H20000
    Const CS_DBLCLKS As Integer = &H8
    'Const WS_EX_COMPOSITED As Integer = &H2000000
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or WS_MINIMIZEBOX
            cp.ClassStyle = cp.ClassStyle Or CS_DBLCLKS
            Return cp
        End Get

    End Property

#End Region
#Region "Frame Buttons"

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdMinimize_Click(sender As Object, e As EventArgs) Handles cmdMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'EXPORT MENU

        'Save as JPG
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.J Then
            JPGToolStripMenuItem.PerformClick()
        End If

        'Save as PNG
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.P Then
            PNGToolStripMenuItem.PerformClick()
        End If

        'Save as BMP
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.B Then
            BMPToolStripMenuItem.PerformClick()
        End If

        'Save as text
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.T Then
            TXTToolStripMenuItem.PerformClick()
        End If

        'Upload Imgur
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.I Then
            ImgurToolStripMenuItem.PerformClick()
        End If
        '------------------------

        'OPTIONS MENU

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.L Then
            ViewImgurLinksToolStripMenuItem.PerformClick()
        End If

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.X Then
            ViewLogToolStripMenuItem.PerformClick()
        End If

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.ShiftKeyDown And e.KeyCode = Keys.R Then
            RefreshScoresToolStripMenuItem.PerformClick()
        End If

        'Settings
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.S Then
            SettingsToolstripMenuItem.PerformClick()
        End If
        '------------------------

        'TOOLS MENU

        'Cleanup
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.C Then
            CleanupToolStripMenuItem.PerformClick()
        End If

        'View System Details
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.D Then
            ViewSystemDetailsToolStripMenuItem.PerformClick()
        End If

        'Rate Normal
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.N Then
            RunToolStripMenuItem.PerformClick()
        End If

        'Rate Verbose
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.V Then
            RunVerboseToolStripMenuItem.PerformClick()
        End If
        '------------------------

        'HELP MENU

        'Media Feature Pack
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.M Then
            MediaFeaturePackToolStripMenuItem.PerformClick()
        End If

        'Troubleshooting
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.T Then
            TroubleshootingToolStripMenuItem.PerformClick()
        End If

        'Check for updates
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.U Then
            CheckForUpdateToolStripMenuItem.PerformClick()
        End If

        'Troubleshooting
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.O Then
            ChangelogToolStripMenuItem.PerformClick()
        End If

        'About
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.A Then
            AboutToolStripMenuItem.PerformClick()
        End If

    End Sub
#End Region

#Region "Load Event"

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sTemp = ""

        cmsExport.Renderer = New MHRenderer : cmsOptions.Renderer = New MHRenderer
        cmsTools.Renderer = New MHRenderer : cmsHelp.Renderer = New MHRenderer

        'Set theme
        SetMainThemeAccent()

        'Set title and hide
        lbShowOnPrint.Text = "Xiret v" & Application.ProductVersion : lbShowOnPrint.Hide()

        'Hide hotfix button
        cmdHotfix.Hide()

        'Set version
        lbHeadVer.Text = Application.ProductVersion

        'Set scale of
        Select Case OSHKernelVersion.ProductMajorPart
            Case 6
                If (OSHKernelVersion.ProductMinorPart = 0) Then : sTemp = "The Experience Index assesses key system components on a scale of 1.0 to 5.9" : End If 'Vista
                If (OSHKernelVersion.ProductMinorPart = 1) Then : sTemp = "The Experience Index assesses key system components on a scale of 1.0 to 7.9" : End If '7
                If (OSHKernelVersion.ProductMinorPart > 1) Then : sTemp = "The Experience Index assesses key system components on a scale of 1.0 to 9.9" : End If '8, 8.1
            Case 10
                sTemp = "The Experience Index assesses key system components on a scale of 1.0 to 9.9" '10
        End Select
        lbScaleOf.Text = sTemp
        sTemp = ""

        'Load scores
        GetWinsatSPR()

        'Determine Operating System and Architecture
        sTemp = OSHGetName() & " " & OSHGetBitness() : lbOperatingSystem.Text = sTemp : sTemp = ""

        'Show hardware setting
        If (BoolShowHardware) Then : GSwitchHardware.Checked = True : End If

        'Push UI Update
        UpdateControls()

    End Sub

#End Region
#Region "Closed Handle"

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try
            For FadeOut = 1.0 To 0.0 Step -0.2
                Opacity = FadeOut
                Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Close()
        End Try

    End Sub

#End Region

#Region "Theme"
    Friend Sub SetMainThemeAccent()

        'Form
        pnlSplit.BackColor = GlobalThemeColor
        lbBaseScore.ForeColor = GlobalThemeColor
        GSwitchHardware.SwitchOnColor = GlobalThemeColor

        'Change buttons
        For Each c As Control In tlpMenu.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = GlobalThemeColor
        Next
        For Each c As Control In tlpBottom.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = GlobalThemeColor
        Next

        'Export Menu
        For Each itm As ToolStripItem In cmsExport.Items
            itm.ForeColor = GlobalThemeColor
        Next
        'Options Menu
        For Each itm As ToolStripItem In cmsOptions.Items
            itm.ForeColor = GlobalThemeColor
        Next
        'Tools Menu
        For Each itm As ToolStripItem In cmsTools.Items
            itm.ForeColor = GlobalThemeColor
        Next
        'Help Menu
        For Each itm As ToolStripItem In cmsHelp.Items
            itm.ForeColor = GlobalThemeColor
        Next

        If (BoolThemeApplyBorder) Then : Me.BackColor = GlobalThemeColor
        Else : Me.BackColor = ColorBorderStandard
        End If

    End Sub
#End Region

#Region "Buttons"
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click

        If Not PHIsAdapterPlugged() Then
            SendToastToScreen("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.IsWarning)
        Else
            If PHIsAdapterPlugged() Then
                SetOpacityOut()
                If (BoolVerbose) Then
                    Dim FAssess As New FormAssessVerbose
                    AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
                    FAssess.ShowDialog()
                Else
                    Dim FAssess As New FormAssess
                    AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
                    FAssess.ShowDialog()
                End If
            End If
        End If

    End Sub
    Private Sub cmdMetrics_Click(sender As Object, e As EventArgs) Handles cmdMetrics.Click

        'SendToastToScreen("This is currently being developed. It will be available in RC2.", ToastType.IsDebug)

        SetOpacityOut()

        Dim FNetrics As New FormMetrics
        AddHandler FNetrics.FormClosed, AddressOf ChildFormClosedNoRefresh
        FNetrics.ShowDialog()

    End Sub
#End Region
#Region "Menu Buttons"
    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click

        If CDbl(StringBaseScore) = 0 Then
            SendToastToScreen("There must be a valid Experience Index rating to use these functions.", ToastType.IsWarning)
        Else
            Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
            ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
            cmsExport.Show(ptLowerLeft)
        End If

    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsOptions.Show(ptLowerLeft)

    End Sub
    Private Sub cmdTools_Click(sender As Object, e As EventArgs) Handles cmdTools.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsTools.Show(ptLowerLeft)

    End Sub
    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsHelp.Show(ptLowerLeft)

    End Sub

#End Region
#Region "Gambol Switches"

    Private Sub GSwitchHardware_CheckedChanged(sender As Object, e As EventArgs) Handles GSwitchHardware.CheckedChanged

        SetHW()

    End Sub

    Public Sub SetHW()

        LoadHardwareStrings()

        If GSwitchHardware.Checked Then
            sProcessor.Text = StringProcessorHW.Replace("(R)", "®").Replace("(TM)", "™")
            sMemory.Text = StringMemoryHW
            sGraphics.Text = StringGraphicsHW.Replace("(R)", "®").Replace("(TM)", "™")
            sGaming.Text = StringGamingHW
            sDisk.Text = StringDiskHW
        Else
            sProcessor.Text = StringProcessorRO
            sMemory.Text = StringMemoryRO
            sGraphics.Text = StringGraphicsRO
            sGaming.Text = StringGamingRO
            sDisk.Text = StringDiskRO
        End If

    End Sub

#End Region

#Region "Context Menu (Export)"

    Private Sub JPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JPGToolStripMenuItem.Click

        If CDbl(StringBaseScore) = 0 Then
            SendToastToScreen("You must rate your system first.", ToastType.IsWarning)
        Else
            lbShowOnPrint.Show()
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = DirSpecialDesktop
                .Filter = "JPEG (*.jpg)|*.jpg"
                .OverwritePrompt = True
                .FileName = "xiret_JPG"
            End With
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using bm As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(bm, New Rectangle(Point.Empty, bm.Size))
                        bm.Save(sfd.FileName, Imaging.ImageFormat.Jpeg)
                    End Using

                    If File.Exists(sfd.FileName) Then
                        FileCurrentToDisk = sfd.FileName.ToString
                        SendToastToScreen("Image saved to " & sfd.FileName, ToastType.IsInformational)
                    Else
                        If Not File.Exists(sfd.FileName) Then
                            SendToastToScreen("The image could not be saved to disk.", ToastType.IsWarning)
                        End If
                    End If

                Catch
                End Try

            End If
        End If
        lbShowOnPrint.Hide()

    End Sub
    Private Sub PNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNGToolStripMenuItem.Click

        If CDbl(StringBaseScore) = 0 Then
            SendToastToScreen("You must rate your system first.", ToastType.IsWarning)
        Else
            lbShowOnPrint.Show()
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = DirSpecialDesktop
                .Filter = "Portable Network Graphics (*.png)|*.png"
                .OverwritePrompt = True
                .FileName = "xiret_PNG"
            End With
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using bm As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(bm, New Rectangle(Point.Empty, bm.Size))
                        bm.Save(sfd.FileName, Imaging.ImageFormat.Png)
                    End Using
                    If File.Exists(sfd.FileName) Then
                        FileCurrentToDisk = sfd.FileName.ToString
                        SendToastToScreen("Image saved to " & sfd.FileName, ToastType.IsInformational)
                    Else
                        SendToastToScreen("The image could not be saved to disk.", ToastType.IsWarning)
                    End If

                Catch
                End Try
            End If
        End If
        lbShowOnPrint.Hide()

    End Sub
    Private Sub BMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMPToolStripMenuItem.Click

        If CDbl(StringBaseScore) = 0 Then
            SendToastToScreen("You must rate your system first.", ToastType.IsWarning)
        Else
            lbShowOnPrint.Show()
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = DirSpecialDesktop
                .Filter = "Bitmap Image File (*.bmp)|*.bmp"
                .OverwritePrompt = True
                .FileName = "xiret_BMP"
            End With
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using bm As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(bm, New Rectangle(Point.Empty, bm.Size))
                        bm.Save(sfd.FileName, Imaging.ImageFormat.Bmp)
                    End Using
                    If File.Exists(sfd.FileName) Then
                        FileCurrentToDisk = sfd.FileName.ToString
                        SendToastToScreen("Image saved to " & sfd.FileName, ToastType.IsInformational)
                    Else
                        SendToastToScreen("The image could not be saved to disk.", ToastType.IsWarning)
                    End If
                Catch
                End Try
            End If
        End If
        lbShowOnPrint.Hide()

    End Sub
    Private Sub TXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem.Click

        If (CDbl(StringBaseScore) = 0) Then
            SendToastToScreen("You must rate your system first.", ToastType.IsWarning)
        Else
            Dim sb As New StringBuilder
            sb.Append("Windows Experience Index scores generated by Xiret on " & Date.Today & "." & vbNewLine & vbNewLine)
            sb.Append("Base Score: " & lbBaseScore.Text & vbNewLine & vbNewLine)

            If (StringProcessorScore = StringBaseScore) Then
                sb.Append("Processor Score:  " & lbCpuScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Processor Score:  " & lbCpuScore.Text & vbNewLine)
            End If
            If (StringMemoryScore = StringBaseScore) Then
                sb.Append("Memory Score:     " & lbMemoryScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Memory Score:     " & lbMemoryScore.Text & vbNewLine)
            End If
            If (StringGraphicsScore = StringBaseScore) Then
                sb.Append("Graphics Score:   " & lbGraphicsScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Graphics Score:   " & lbGraphicsScore.Text & vbNewLine)
            End If
            If (StringGamingScore = StringBaseScore) Then
                sb.Append("Gaming Score:     " & lbGamingScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Gaming Score:     " & lbGamingScore.Text & vbNewLine)
            End If
            If (StringDiskScore = StringBaseScore) Then
                sb.Append("Disk Score:       " & lbDiskScore.Text & " (*)" & vbCrLf & vbCrLf)
            Else
                sb.Append("Disk Score:       " & lbDiskScore.Text & vbCrLf & vbCrLf)
            End If
            sb.Append("(*) - Lowest subscore" & vbCrLf & vbCrLf)
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = DirSpecialDesktop
                .Filter = "Text File (*.txt)|*.txt"
                .OverwritePrompt = True
                .FileName = "xiret_TXT"
            End With
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                File.WriteAllText(sfd.FileName, sb.ToString, Encoding.UTF8)
                If File.Exists(sfd.FileName) Then
                    FileCurrentToDisk = sfd.FileName.ToString
                    SendToastToScreen("File saved to " & sfd.FileName.ToString, ToastType.IsInformational)
                Else
                    SendToastToScreen("Could not save text file to disk.", ToastType.IsWarning)
                End If
            End If
        End If

    End Sub
    Private Sub ImgurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImgurToolStripMenuItem.Click

        CType(sender, ToolStripMenuItem).Enabled = False

        If StringImgurClientID = "" Then
            SendToastToScreen("Imgur API client key missing.", ToastType.IsWarning)
        Else
            If CDbl(StringBaseScore) = 0 Then 'Unrated system
                SendToastToScreen("You must rate your system first.", ToastType.IsWarning)
            Else 'Check imgur is online
                If NHIsSiteAvailable(StringImgurUrl) Then
                    lbShowOnPrint.Show()
                    CaptureControl(FileTemporary, pnlCapture)
                    Try
                        Dim wClient As New WebClient()
                        wClient.Headers.Add("Authorization", Convert.ToString("Client-ID ") & StringImgurClientID)
                        Dim nKeys As New Specialized.NameValueCollection From {
                            {"image", Convert.ToBase64String(File.ReadAllBytes(FileTemporary))}
                        }
                        Dim b As Byte() = wClient.UploadValues("https://api.imgur.com/3/image", nKeys)
                        Dim s As String = Encoding.ASCII.GetString(b)
                        Dim rx As New RegularExpressions.Regex("link"":""(.*?)""")
                        Dim m As RegularExpressions.Match = rx.Match(s)
                        Dim uri As String = m.ToString().Replace("link"":""", "").Replace("""", "").Replace("\/", "/")
                        My.Computer.FileSystem.WriteAllText(FileImgurLog, DateTime.Now & " - " & uri & vbCrLf, True)
                        Process.Start(uri)
                        SendToastToScreen("Screenshot uploaded to Imgur", ToastType.IsInformational)
                        'Remove temporary file
                        If File.Exists(FileTemporary) Then
                            File.Delete(FileTemporary)
                        End If
                    Catch
                        SendToastToScreen("Could not upload screenshot to Imgur's database.", ToastType.IsError)
                    End Try
                Else 'No connection to Imgur
                    SendToastToScreen("Could not connect to Imgur. The service may be unavailable.", ToastType.IsWarning)
                End If
            End If
        End If

        'Finish up
        lbShowOnPrint.Hide() : CType(sender, ToolStripMenuItem).Enabled = True

    End Sub


#End Region
#Region "Context Menu (Options)"

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click

        Try
            Process.Start(FileXiretLog)
        Catch ex As Exception
            SendToastToScreen("The assessment log file has not been created. It will be available after rating your system at least once.", ToastType.IsWarning)
        End Try

    End Sub
    Private Sub ViewImgurLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImgurLinksToolStripMenuItem.Click

        Try
            Process.Start(FileImgurLog)
        Catch ex As Exception
            SendToastToScreen("The Imgur link file has not been created. It will be available after you upload a rating.", ToastType.IsWarning)
        End Try

    End Sub

    Private Sub RefreshScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshScoresToolStripMenuItem.Click

        GetWinsatSPR()
        UpdateControls()

    End Sub
    Private Sub SettingsToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolstripMenuItem.Click

        SetOpacityOut()

        Dim FSettings As New FormSettings
        AddHandler FSettings.FormClosing, AddressOf ChildFormClosedNoRefresh
        FSettings.ShowDialog()

    End Sub


#End Region
#Region "Context Menu (Tools)"
    Private Sub CleanupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanupToolStripMenuItem.Click

        SetOpacityOut()

        Dim F As New FormCleanup
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub
    Private Sub ViewSystemDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSystemDetailsToolStripMenuItem.Click

        SetOpacityOut()

        Dim F As New FormSystem
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click

        If Not PHIsAdapterPlugged() Then
            SendToastToScreen("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.IsWarning)
        Else
            SetOpacityOut()
            Dim FAssess As New FormAssess
            AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
            FAssess.ShowDialog()
        End If

    End Sub
    Private Sub RunVerboseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunVerboseToolStripMenuItem.Click

        If Not PHIsAdapterPlugged() Then
            SendToastToScreen("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.IsWarning)
        Else
            SetOpacityOut()
            Dim FAssess As New FormAssessVerbose
            AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
            FAssess.ShowDialog()
        End If

    End Sub

#End Region
#Region "Context Menu (Help)"
    Private Sub MediaFeaturePackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MediaFeaturePackToolStripMenuItem.Click

        Process.Start("http://windows.microsoft.com/en-gb/windows/download-windows-media-player")

    End Sub
    Private Sub TroubleshootingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TroubleshootingToolStripMenuItem.Click

        Try
            Dim proc As Process = New Process
            Dim sTemp As String = DirTemporary & "\Troubleshooting.rtf"

            Dim buff As Byte() = Encoding.UTF8.GetBytes(My.Resources.troubleshooting)

            File.WriteAllBytes(sTemp, buff)

            If File.Exists(sTemp) = True Then
                With proc.StartInfo
                    .FileName = sTemp
                    .UseShellExecute = True
                    .WindowStyle = ProcessWindowStyle.Maximized
                End With

                proc.Start()

            Else
                Exit Sub
            End If
        Catch ex As IOException
            SendToastToScreen("Troubleshooting is already open.", ToastType.IsInformational)
        End Try

    End Sub
    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click

        SetOpacityOut()

        Dim FUpdate As New FormUpdate
        AddHandler FUpdate.FormClosed, AddressOf ChildFormClosedNoRefresh
        FUpdate.ShowDialog()

    End Sub
    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click

        SetOpacityOut()

        Dim FChangelog As New FormChangelog
        AddHandler FChangelog.FormClosed, AddressOf ChildFormClosedNoRefresh
        FChangelog.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        SetOpacityOut()

        Dim FAbout As New FormAbout
        AddHandler FAbout.FormClosed, AddressOf ChildFormClosedNoRefresh
        FAbout.ShowDialog()

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

#Region "Extra Designer Code"

    Private Sub BtnHotfix_Paint(sender As Object, e As PaintEventArgs) Handles cmdHotfix.Paint

        Dim p As New Pen(Color.Tomato)
        Dim rect As New Rectangle(CInt(CType(sender, Button).Width / 2 - 10), CType(sender, Button).Height - 4, 20, 2)
        e.Graphics.DrawRectangle(p, rect)
        e.Graphics.FillRectangle(New SolidBrush(Color.Tomato), rect)
        p.Dispose()

    End Sub

#End Region

#Region "Update UI"

    Private Sub ChildFormClosedRefreshUI(ByVal sender As Object, ByVal e As EventArgs)

        ResetOpacity()
        GetWinsatSPR()
        UpdateControls()

    End Sub
    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)

        ResetOpacity()

    End Sub
    Private Sub SetOpacityOut()

        Try
            For FadeOut = 1.0 To 0.4 Step -0.2
                Opacity = FadeOut
                Refresh()
                Thread.Sleep(10)
            Next
        Catch
            Opacity = 0.4
        End Try

    End Sub
    Private Sub ResetOpacity()

        Try
            If Opacity <> 0.4 Then
                For FadeIn = 0.4 To 1.0 Step 0.2
                    Opacity = FadeIn
                    Refresh()
                    Thread.Sleep(10)
                Next
            End If
        Catch
            Opacity = 1.0
        End Try


    End Sub
    Friend Sub UpdateControls()

        'Check assessment validity
        lbState.Text = ConvertAssessmentState(GetAssessmentValidityInt())

        If GetAssessmentValidityInt() = 1 Then : lbBaseScore.ForeColor = GlobalThemeColor : pnlValidityState.BackColor = GlobalThemeColor
        Else : lbBaseScore.ForeColor = ColorBaseScoreUnrated : pnlValidityState.BackColor = ColorInvalid
        End If

        'Check CPU score against Base score
        If (StringProcessorScore = StringBaseScore) Then : PnlSubProcessor.BackColor = ColorPanelActive : lbCpuScore.ForeColor = GlobalThemeColor
        Else : PnlSubProcessor.BackColor = ColorPanelNormal : lbCpuScore.ForeColor = Color.White
        End If

        'Check Memory score against Base score
        If (StringMemoryScore = StringBaseScore) Then : PnlSubMemory.BackColor = ColorPanelActive : lbMemoryScore.ForeColor = GlobalThemeColor
        Else : PnlSubMemory.BackColor = ColorPanelNormal : lbMemoryScore.ForeColor = Color.White
        End If

        'Check Graphics Score against Base score
        If (StringGraphicsScore = StringBaseScore) Then : PnlSubGraphics.BackColor = ColorPanelActive : lbGraphicsScore.ForeColor = GlobalThemeColor
        Else : PnlSubGraphics.BackColor = ColorPanelNormal : lbGraphicsScore.ForeColor = Color.White
        End If

        'Check Gaming score against Base score
        If (StringGamingScore = StringBaseScore) Then : PnlSubGaming.BackColor = ColorPanelActive : lbGamingScore.ForeColor = GlobalThemeColor
        Else : PnlSubGaming.BackColor = ColorPanelNormal : lbGamingScore.ForeColor = Color.White
        End If

        'Check Disk score against Base score
        If (StringDiskScore = StringBaseScore) Then : PnlSubDisk.BackColor = ColorPanelActive : lbDiskScore.ForeColor = GlobalThemeColor
        Else : PnlSubDisk.BackColor = ColorPanelNormal : lbDiskScore.ForeColor = Color.White
        End If

        'Determine last assessment date
        StringDate = Format(GetWinsatLastUpdateDate(), "dddd, MMM d yyyy hh:mm tt")
        If (StringDate = Nothing) Or (StringDate.Contains("1999")) Then : lbLastUpdated.Text = "Never"
        Else : lbLastUpdated.Text = StringDate
        End If

        'Pass score strings to UI
        lbBaseScore.Text = StringBaseScore : lbCpuScore.Text = StringProcessorScore : lbMemoryScore.Text = StringMemoryScore
        lbGraphicsScore.Text = StringGraphicsScore : lbGamingScore.Text = StringGamingScore : lbDiskScore.Text = StringDiskScore

        If StringBaseScore = "0" Or StringBaseScore = Nothing Then : lbBaseScore.Text = "0.0" : End If

        CheckRated()
        LoadHardwareStrings()

    End Sub

    Private Sub CheckRated()

        If isRated Then : GSwitchHardware.Enabled = True
        Else : GSwitchHardware.Checked = False : GSwitchHardware.Enabled = False
        End If

    End Sub

    Private Sub LoadHardwareStrings()

        If BoolHardwareApiMode Then : ReadAPIHardware()
        Else : ReadXMLHardware()
        End If

    End Sub

#End Region

End Class
