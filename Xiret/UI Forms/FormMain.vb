'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  Some ContextMenu settings are overriden by Gambol\UI\MHRenderer like background color, etc
'  FormMain.vb
'  Created by David S on 24.03.2016
'  Updated on 27.07.2019 - DS (Cleanup, removed webclient block, animation, update imports, moved imgur api)
'  Updated on 31.07.2019 - DS (Cleanup, implement FreeMemory)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc, update CheckNotify, disabled refreshing scores when Winsat State=3)
'  Updated on 08.08.2019 - DS (Added application context menu (Right click top image), double click icon to close application)

Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Imports Core.Animation
Imports Core.Helpers
Imports Core.WMI

Imports Xiret.Winsat

Imports Gambol.UI

Public Class FormMain

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

#End Region

#Region "Overriden Properties"
    Const WS_MINIMIZEBOX As Integer = &H20000
    Const CS_DBLCLKS As Integer = &H8
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or WS_MINIMIZEBOX
            cp.ClassStyle = cp.ClassStyle Or CS_DBLCLKS
            Return cp
        End Get
    End Property
#End Region
#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, LbHead.MouseMove,
        LbHeadVer.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Application.Exit()
    End Sub

    Private Sub CmdMinimize_Click(sender As Object, e As EventArgs) Handles CmdMinimize.Click
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

        'Hotfix available
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.H Then
            HotfixAvailableToolStripMenuItem.PerformClick()
        End If

        'Update available
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.U Then
            UpdateAvailableToolStripMenuItem.PerformClick()
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

#Region "Load Event Handler"

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Set theme
        SetMainThemeAccent()

        'Set context menu renderer
        cmsExport.Renderer = New MHRenderer
        cmsOptions.Renderer = New MHRenderer
        cmsTools.Renderer = New MHRenderer
        cmsHelp.Renderer = New MHRenderer
        cmsExplorer.Renderer = New MHRenderer

        'Hide controls that are only shown when needed
        HotfixAvailableToolStripMenuItem.Visible = False
        UpdateAvailableToolStripMenuItem.Visible = False
        lbShowOnPrint.Visible = False

        'Load data to labels
        lbShowOnPrint.Text = "Xiret v" & Application.ProductVersion
        LbHeadVer.Text = Application.ProductVersion
        lbOperatingSystem.Text = OSHelper.GetOSName() & " " & OSHelper.GetOSBitness()

        Select Case OSHelper.GetKernelVersion.ProductMajorPart
            Case 6
                If OSHelper.GetKernelVersion.ProductMinorPart = 0 Then : lbScale.Text = "The Experience Index assesses key system components on a scale of 1.0 to 5.9." : End If 'Vista
                If OSHelper.GetKernelVersion.ProductMinorPart = 1 Then : lbScale.Text = "The Experience Index assesses key system components on a scale of 1.0 to 7.9." : End If '7
                If OSHelper.GetKernelVersion.ProductMinorPart > 1 Then : lbScale.Text = "The Experience Index assesses key system components on a scale of 1.0 to 9.9." : End If '8, 8.1
            Case 10
                lbScale.Text = "The Experience Index assesses key system components on a scale of 1.0 to 9.9." '10
            Case Else
                lbScale.Text = "The Experience Index assesses key system components."
        End Select

        'Load scores
        WSR.GetWinsatSPR()

        'Show hardware
        If Settings.ShowHardwareOnStarup = 1 Then
            GSwitchHardware.Checked = True
        End If

        'UI Update
        UpdateControls()

        'Check notifications
        Dim NotifyTask As Task = Task.Factory.StartNew(Sub() CheckNotify())

    End Sub
    Private Sub CheckNotify()

        'Moved from Program.vb. Holds back spawn time on Win7.
        If OSHelper.IsWinSeven() Then
            'Check convenience rollup KB3125574
            If Not Knowledgebase.CheckFor("KB3125574") Then
                Booleans.BoolMissingHotfix = True 'Missing
            Else
                Booleans.BoolMissingHotfix = False 'Installed
            End If
            'If KB3125574 missing then check for older patch KB2687862
            If Booleans.BoolMissingHotfix Then
                If Not Knowledgebase.CheckFor("KB2687862") Then
                    Booleans.BoolMissingHotfix = True 'Missing
                Else
                    Booleans.BoolMissingHotfix = False 'Installed
                End If
            End If
        End If

        If Booleans.BoolMissingHotfix Then
            Integers.IntNotificationCount += 1
            UpdateToolstripHotfixItem()
        End If

        If Updater.CheckForUpdate() Then
            Integers.IntNotificationCount += 1
            Booleans.BoolMissingUpdate = True
            UpdateToolstripUpdateItem()
        End If

        If Not Integers.IntNotificationCount <= 0 Then
            Notifier1.Controls.Add(cmdHelp, Integers.IntNotificationCount)
            Notifier1.Activate()
        End If

    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Friend Sub SetMainThemeAccent()


        pnlSplit.BackColor = Settings.ThemeColor

        lbBaseScore.ForeColor = Settings.ThemeColor
        GSwitchHardware.SwitchOnColor = Settings.ThemeColor

        'Change buttons
        For Each c As Control In tlpMenu.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        For Each c As Control In tlpBottom.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        'Export Menu
        For Each itm As ToolStripItem In cmsExport.Items
            itm.ForeColor = Settings.ThemeColor
        Next

        'Options Menu
        For Each itm As ToolStripItem In cmsOptions.Items
            itm.ForeColor = Settings.ThemeColor
        Next

        'Tools Menu
        For Each itm As ToolStripItem In cmsTools.Items
            itm.ForeColor = Settings.ThemeColor
        Next

        'Help Menu
        For Each itm As ToolStripItem In cmsHelp.Items
            itm.ForeColor = Settings.ThemeColor
        Next

        'Negate changes to cmsHelp.items if notifications are available
        If Booleans.BoolMissingHotfix Then
            UpdateToolstripHotfixItem()
        End If
        If Booleans.BoolMissingUpdate Then
            UpdateToolstripUpdateItem()
        End If

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.IsWarning)
        Else
            If PowerHelper.IsAdapterPluggedIn() Then
                Fade.FadeBehindChild(Me)
                If Settings.UseVerboseMode = 1 Then
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
    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles cmdMetrics.Click

        If WinsatApi.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this feature.", ToastType.IsWarning)
        Else
            Fade.FadeBehindChild(Me)

            Dim FMetrics As New FormMetrics
            AddHandler FMetrics.FormClosed, AddressOf ChildFormClosedNoRefresh
            FMetrics.ShowDialog()
        End If

    End Sub
#End Region
#Region "Menu Button Event Handlers"
    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("There must be a valid Experience Index rating to use these features.", ToastType.IsWarning)
        Else
            Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
            ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
            cmsExport.Show(ptLowerLeft)
        End If

    End Sub
    Private Sub CmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsOptions.Show(ptLowerLeft)

    End Sub
    Private Sub CmdTools_Click(sender As Object, e As EventArgs) Handles cmdTools.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsTools.Show(ptLowerLeft)

    End Sub
    Private Sub CmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsHelp.Show(ptLowerLeft)

    End Sub

#End Region
#Region "Gambol Switch Event Handlers"

    Private Sub GSwitchHardware_CheckedChanged(sender As Object, e As EventArgs) Handles GSwitchHardware.CheckedChanged
        SetHW()
    End Sub

#End Region
#Region "Picturebox Event Handlers"
    Private Sub PbxMain_DoubleClick(sender As Object, e As EventArgs) Handles pbxMain.DoubleClick
        Application.Exit()
    End Sub
#End Region

#Region "Context Menu (Export)"

    Private Sub JPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JPGToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.IsWarning)
        Else
            lbShowOnPrint.Show()
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = Directories.DirSpecialDesktop
                .Filter = "JPEG (*.jpg)|*.jpg"
                .OverwritePrompt = True
                .FileName = "xiret_jpg"
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using bm As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(bm, New Rectangle(Point.Empty, bm.Size))
                        bm.Save(sfd.FileName, Imaging.ImageFormat.Jpeg)
                    End Using

                    If File.Exists(sfd.FileName) Then
                        Files.FileCurrentToDisk = sfd.FileName.ToString
                        ToastAlert.Show("Image saved to " & sfd.FileName, ToastType.IsInformational)
                    Else
                        If Not File.Exists(sfd.FileName) Then
                            ToastAlert.Show("The image could not be saved to disk.", ToastType.IsWarning)
                        End If
                    End If
                Catch
                End Try
            End If
        End If

        lbShowOnPrint.Hide()

    End Sub
    Private Sub PNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNGToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.IsWarning)
        Else
            lbShowOnPrint.Show()
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = Directories.DirSpecialDesktop
                .Filter = "Portable Network Graphics (*.png)|*.png"
                .OverwritePrompt = True
                .FileName = "xiret_png"
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using bm As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(bm, New Rectangle(Point.Empty, bm.Size))
                        bm.Save(sfd.FileName, Imaging.ImageFormat.Png)
                    End Using
                    If File.Exists(sfd.FileName) Then
                        Files.FileCurrentToDisk = sfd.FileName.ToString
                        ToastAlert.Show("Image saved to " & sfd.FileName, ToastType.IsInformational)
                    Else
                        ToastAlert.Show("The image could not be saved to disk.", ToastType.IsWarning)
                    End If

                Catch
                End Try
            End If
        End If

        lbShowOnPrint.Hide()

    End Sub
    Private Sub BMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMPToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.IsWarning)
        Else
            lbShowOnPrint.Show()
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = Directories.DirSpecialDesktop
                .Filter = "Bitmap Image File (*.bmp)|*.bmp"
                .OverwritePrompt = True
                .FileName = "xiret_bmp"
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using bm As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(bm, New Rectangle(Point.Empty, bm.Size))
                        bm.Save(sfd.FileName, Imaging.ImageFormat.Bmp)
                    End Using
                    If File.Exists(sfd.FileName) Then
                        Files.FileCurrentToDisk = sfd.FileName.ToString
                        ToastAlert.Show("Image saved to " & sfd.FileName, ToastType.IsInformational)
                    Else
                        ToastAlert.Show("The image could not be saved to disk.", ToastType.IsWarning)
                    End If
                Catch
                End Try
            End If
        End If

        lbShowOnPrint.Hide()

    End Sub
    Private Sub TXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem.Click

        If (CDbl(Strings.StringBaseScore) = 0) Then
            ToastAlert.Show("You must rate your system first.", ToastType.IsWarning)
        Else
            Dim sb As New StringBuilder
            sb.Append("Windows Experience Index scores generated by Xiret on " & Date.Today & "." & vbNewLine & vbNewLine)
            sb.Append("Base Score: " & lbBaseScore.Text & vbNewLine & vbNewLine)

            If (Strings.StringProcessorScore = Strings.StringBaseScore) Then
                sb.Append("Processor Score:  " & lbCpuScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Processor Score:  " & lbCpuScore.Text & vbNewLine)
            End If
            If (Strings.StringMemoryScore = Strings.StringBaseScore) Then
                sb.Append("Memory Score:     " & lbMemoryScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Memory Score:     " & lbMemoryScore.Text & vbNewLine)
            End If
            If (Strings.StringGraphicsScore = Strings.StringBaseScore) Then
                sb.Append("Graphics Score:   " & lbGraphicsScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Graphics Score:   " & lbGraphicsScore.Text & vbNewLine)
            End If
            If (Strings.StringGamingScore = Strings.StringBaseScore) Then
                sb.Append("Gaming Score:     " & lbGamingScore.Text & " (*)" & vbNewLine)
            Else
                sb.Append("Gaming Score:     " & lbGamingScore.Text & vbNewLine)
            End If
            If (Strings.StringDiskScore = Strings.StringBaseScore) Then
                sb.Append("Disk Score:       " & lbDiskScore.Text & " (*)" & vbCrLf & vbCrLf)
            Else
                sb.Append("Disk Score:       " & lbDiskScore.Text & vbCrLf & vbCrLf)
            End If
            sb.Append("(*) - Lowest subscore" & vbCrLf & vbCrLf)
            Dim sfd As New SaveFileDialog
            With sfd
                .InitialDirectory = Directories.DirSpecialDesktop
                .Filter = "Text File (*.txt)|*.txt"
                .OverwritePrompt = True
                .FileName = "xiret_txt"
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                File.WriteAllText(sfd.FileName, sb.ToString, Encoding.UTF8)
                If File.Exists(sfd.FileName) Then
                    Files.FileCurrentToDisk = sfd.FileName.ToString
                    ToastAlert.Show("File saved to " & sfd.FileName.ToString, ToastType.IsInformational)
                Else
                    ToastAlert.Show("Could not save text file to disk.", ToastType.IsWarning)
                End If
            End If

        End If

    End Sub
    Private Sub ImgurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImgurToolStripMenuItem.Click

        CType(sender, ToolStripMenuItem).Enabled = False

        If Strings.StringImgurClientID = "" Then
            ToastAlert.Show("Imgur API client key needed.", ToastType.IsWarning)
        Else
            If CDbl(Strings.StringBaseScore) = 0 Then 'Unrated system
                ToastAlert.Show("You must rate your system first.", ToastType.IsWarning)
            Else 'Check imgur is online
                If NetHelper.IsWebsiteAvailable(Strings.StringImgurUrl) Then

                    'Show version label
                    lbShowOnPrint.Show()

                    'Capture image to upload
                    ImageHelper.CaptureControl(Files.FileTemporary, pnlCapture)

                    ' // Imgur Api moved to Core\Helpers\ImageHelper > PostToImgur
                    If Settings.UseCustomImgurApiKey = 1 Then
                        UploadCustomClient()
                    Else
                        UploadNormalClient()
                    End If

                Else 'No connection to Imgur
                    ToastAlert.Show("Could not connect to Imgur. The service may be unavailable.", ToastType.IsWarning)
                End If
            End If
        End If

        'Finish up
        lbShowOnPrint.Hide()
        CType(sender, ToolStripMenuItem).Enabled = True

    End Sub

    Private Sub UploadCustomClient()

        Dim exitCode As Integer = ImageHelper.PostToImgur(Files.FileTemporary, Files.FileImgurLog, Settings.StringUserImgurClientId, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.IsInformational)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.IsError)
        End If

    End Sub

    Private Sub UploadNormalClient()

        Dim exitCode As Integer = ImageHelper.PostToImgur(Files.FileTemporary, Files.FileImgurLog, Strings.StringImgurClientID, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.IsInformational)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.IsError)
        End If

    End Sub

#End Region
#Region "Context Menu (Options)"

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click
        Try
            Process.Start(Files.FileXiretLog)
        Catch
            ToastAlert.Show("The assessment log file has not been created. It will be available after rating your system with Xiret at least once.", ToastType.IsWarning)
        End Try
    End Sub
    Private Sub ViewImgurLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImgurLinksToolStripMenuItem.Click
        Try
            Process.Start(Files.FileImgurLog)
        Catch
            ToastAlert.Show("The Imgur link file has not been created. It will be available after you upload a valid system rating.", ToastType.IsWarning)
        End Try
    End Sub

    Private Sub RefreshScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshScoresToolStripMenuItem.Click

        If WinsatApi.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this option.", ToastType.IsWarning)
        Else
            WSR.GetWinsatSPR()
            UpdateControls()
        End If


    End Sub
    Private Sub SettingsToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolstripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormSettings
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub


#End Region
#Region "Context Menu (Tools)"
    Private Sub CleanupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanupToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormCleanup
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub
    Private Sub ViewSystemDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSystemDetailsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormSystem
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.IsWarning)
        Else
            Fade.FadeBehindChild(Me)
            Dim F As New FormAssess
            AddHandler F.FormClosed, AddressOf ChildFormClosedRefreshUI
            F.ShowDialog()
        End If

    End Sub
    Private Sub RunVerboseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunVerboseToolStripMenuItem.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.IsWarning)
        Else
            Fade.FadeBehindChild(Me)
            Dim F As New FormAssessVerbose
            AddHandler F.FormClosed, AddressOf ChildFormClosedRefreshUI
            F.ShowDialog()
        End If

    End Sub

#End Region
#Region "Context Menu (Help)"
    Private Sub MediaFeaturePackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MediaFeaturePackToolStripMenuItem.Click
        Process.Start(Strings.StringMediaFeatureUrl)
    End Sub
    Private Sub TroubleshootingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TroubleshootingToolStripMenuItem.Click

        Try
            Dim proc As Process = New Process
            Dim temp As String = Directories.DirTemporary & "\Troubleshooting.rtf"

            Dim buff As Byte() = Encoding.UTF8.GetBytes(My.Resources.troubleshooting)

            File.WriteAllBytes(temp, buff)

            If File.Exists(temp) = True Then
                With proc.StartInfo
                    .FileName = temp
                    .UseShellExecute = True
                    .WindowStyle = ProcessWindowStyle.Maximized
                End With

                proc.Start()

            Else
                Exit Sub
            End If
        Catch ex As IOException
            ToastAlert.Show("Troubleshooting is already open.", ToastType.IsInformational)
        End Try

    End Sub
    Private Sub HotfixAvaiableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotfixAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FHotfix As New FormHotfix
        AddHandler FHotfix.FormClosed, AddressOf ChildFormClosedNoRefresh
        FHotfix.ShowDialog()

    End Sub
    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FUpdate As New FormUpdate
        AddHandler FUpdate.FormClosed, AddressOf ChildFormClosedNoRefresh
        FUpdate.ShowDialog()

    End Sub
    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FChangelog As New FormChangelog
        AddHandler FChangelog.FormClosed, AddressOf ChildFormClosedNoRefresh
        FChangelog.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim FAbout As New FormAbout
        AddHandler FAbout.FormClosed, AddressOf ChildFormClosedNoRefresh
        FAbout.ShowDialog()

    End Sub

#End Region
#Region "Context Menu (Application)"

    Private Sub MinimiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimiseToolStripMenuItem.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ResetPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPositionToolStripMenuItem.Click
        CenterToScreen()
    End Sub

    Private Sub ResetApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetApplicationToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItemExplorer_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click

        Fade.FadeBehindChild(Me)

        Dim FAbout As New FormAbout
        AddHandler FAbout.FormClosed, AddressOf ChildFormClosedNoRefresh
        FAbout.ShowDialog()

    End Sub

#End Region

#Region "Routines"

    Private Sub ChildFormClosedRefreshUI(ByVal sender As Object, ByVal e As EventArgs)
        Fade.RefadeIn(Me)
        WSR.GetWinsatSPR()
        UpdateControls()
        MemHelper.FreeMemory()
    End Sub
    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)
        Fade.RefadeIn(Me)
        MemHelper.FreeMemory()
    End Sub

    Friend Sub UpdateControls()

        'Check assessment validity
        lbState.Text = State.ConvertAssessmentState(WinsatApi.GetAssessmentValidityInt())

        If WinsatApi.GetAssessmentValidityInt() = 1 Then : lbBaseScore.ForeColor = Settings.ThemeColor : pnlValidityState.BackColor = Colors.ColorValid
        Else : lbBaseScore.ForeColor = Colors.ColorBaseScoreUnrated : pnlValidityState.BackColor = Colors.ColorInvalid
        End If

        'Check CPU score against Base score
        If Strings.StringProcessorScore = Strings.StringBaseScore Then : PnlSubProcessor.BackColor = Colors.ColorPanelActive : lbCpuScore.ForeColor = Settings.ThemeColor
        Else : PnlSubProcessor.BackColor = Colors.ColorPanelNormal : lbCpuScore.ForeColor = Color.White
        End If

        'Check Memory score against Base score
        If Strings.StringMemoryScore = Strings.StringBaseScore Then : PnlSubMemory.BackColor = Colors.ColorPanelActive : lbMemoryScore.ForeColor = Settings.ThemeColor
        Else : PnlSubMemory.BackColor = Colors.ColorPanelNormal : lbMemoryScore.ForeColor = Color.White
        End If

        'Check Graphics Score against Base score
        If Strings.StringGraphicsScore = Strings.StringBaseScore Then : PnlSubGraphics.BackColor = Colors.ColorPanelActive : lbGraphicsScore.ForeColor = Settings.ThemeColor
        Else : PnlSubGraphics.BackColor = Colors.ColorPanelNormal : lbGraphicsScore.ForeColor = Color.White
        End If

        'Check Gaming score against Base score
        If Strings.StringGamingScore = Strings.StringBaseScore Then : PnlSubGaming.BackColor = Colors.ColorPanelActive : lbGamingScore.ForeColor = Settings.ThemeColor
        Else : PnlSubGaming.BackColor = Colors.ColorPanelNormal : lbGamingScore.ForeColor = Color.White
        End If

        'Check Disk score against Base score
        If Strings.StringDiskScore = Strings.StringBaseScore Then : PnlSubDisk.BackColor = Colors.ColorPanelActive : lbDiskScore.ForeColor = Settings.ThemeColor
        Else : PnlSubDisk.BackColor = Colors.ColorPanelNormal : lbDiskScore.ForeColor = Color.White
        End If

        'Determine last assessment date
        Strings.StringDate = Format(WinsatApi.GetWinsatLastUpdateDate(), "dddd, MMM d yyyy hh:mm tt")
        If (Strings.StringDate = "") Or Strings.StringDate.Contains("1999") Then
            lbLastUpdated.Text = "Never"
        Else
            lbLastUpdated.Text = Strings.StringDate
        End If

        'Pass score strings to UI
        lbBaseScore.Text = Strings.StringBaseScore
        lbCpuScore.Text = Strings.StringProcessorScore
        lbMemoryScore.Text = Strings.StringMemoryScore
        lbGraphicsScore.Text = Strings.StringGraphicsScore
        lbGamingScore.Text = Strings.StringGamingScore
        lbDiskScore.Text = Strings.StringDiskScore

        If Strings.StringBaseScore = "0" Or Strings.StringBaseScore = Nothing Then
            lbBaseScore.Text = "0.0"
        End If

        CheckRated()
        LoadHardwareStrings()

    End Sub

    Private Sub CheckRated()

        If Not WinsatApi.GetAssessmentValidityInt() = 3 Then
            GSwitchHardware.Enabled = True
        Else
            GSwitchHardware.Checked = False : GSwitchHardware.Enabled = False
        End If

    End Sub

    Private Sub LoadHardwareStrings()

        If Settings.UseApiHardware = 1 Then
            WSR.ReadAPIHardware()
        Else
            WSR.ReadXMLHardware()
        End If

    End Sub

    Public Sub SetHW()

        LoadHardwareStrings()

        If GSwitchHardware.Checked Then
            sProcessor.Text = Strings.StringProcessorHW.Replace("(R)", "®").Replace("(TM)", "™")
            sMemory.Text = Strings.StringMemoryHW
            sGraphics.Text = Strings.StringGraphicsHW.Replace("(R)", "®").Replace("(TM)", "™")
            sGaming.Text = Strings.StringGamingHW
            sDisk.Text = Strings.StringDiskHW
        Else
            sProcessor.Text = Strings.StringProcessorRO
            sMemory.Text = Strings.StringMemoryRO
            sGraphics.Text = Strings.StringGraphicsRO
            sGaming.Text = Strings.StringGamingRO
            sDisk.Text = Strings.StringDiskRO
        End If

    End Sub

    Private Sub UpdateToolstripHotfixItem()
        HotfixAvailableToolStripMenuItem.Visible = True
        HotfixAvailableToolStripMenuItem.ForeColor = Color.White
        HotfixAvailableToolStripMenuItem.Text = "! Hotfix available"
        HotfixAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub

    Private Sub UpdateToolstripUpdateItem()
        UpdateAvailableToolStripMenuItem.Visible = True
        UpdateAvailableToolStripMenuItem.ForeColor = Color.White
        UpdateAvailableToolStripMenuItem.Text = "! Update Available"
        UpdateAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub

#End Region

End Class
