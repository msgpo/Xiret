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
'  Updated on 07.10.2019 - DS (Fix cross-thread bug, add dropshadow)
'  Updated on 16.10.2019 - DS (Update CheckNotify() to finish tasks before updating menu items)
'  Updated on 21.10.2019 - DS (Switch thread to task, task handling)

Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers
Imports Xiret.Core.WMI

Imports Xiret.Winsat
Imports Xiret.Controls
Imports Xiret.UI

#Disable Warning IDE0067

Public Class FormMain

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetMainThemeAccent()
        CmsExport.Renderer = New GambolToolstripRenderer
        CmsOptions.Renderer = New GambolToolstripRenderer
        CmsTools.Renderer = New GambolToolstripRenderer
        CmsHelp.Renderer = New GambolToolstripRenderer
        CmsExplorer.Renderer = New GambolToolstripRenderer
    End Sub

#End Region

#Region "Overriden Properties"
    Const WS_MINIMIZEBOX As Integer = &H20000
    Const CS_DBLCLKS As Integer = &H8
    Const CS_DROP As Integer = &H20000
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or WS_MINIMIZEBOX
            cp.ClassStyle = cp.ClassStyle Or CS_DBLCLKS Or CS_DROP
            Return cp
        End Get
    End Property
#End Region
#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove,
        LabVersion.MouseMove, PanHead.MouseMove

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
    Private Sub CmdSettings_Click(sender As Object, e As EventArgs) Handles CmdSettings.Click
        Fade.FadeBehindChild(Me)

        Dim F As New FormSettings
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()
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
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.W Then
            ViewWinSATLogToolStripMenuItem.PerformClick()
        End If

        'Refresh scores
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.ShiftKeyDown And e.KeyCode = Keys.R Then
            RefreshScoresToolStripMenuItem.PerformClick()
        End If

        'Save res
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.R Then
            SaveResourcesToDIskToolStripMenuItem.PerformClick()
        End If

        'View app data
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.G Then
            ProgramDataToolStripMenuItem.PerformClick()
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

        'Changelog
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.L Then
            ChangelogToolStripMenuItem.PerformClick()
        End If

        'About
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.A Then
            AboutToolStripMenuItem.PerformClick()
        End If

        'Acknowledgements
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.K Then
            AcknowledgementsToolStripMenuItem.PerformClick()
        End If

    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Hide items that are only shown when needed
        HotfixAvailableToolStripMenuItem.Visible = False
        UpdateAvailableToolStripMenuItem.Visible = False

        'Load data to labels
        LabVersion.Text = Application.ProductVersion

        'This is to stop me releasing debug accidentally
#If DEBUG Then
        LabHead.ForeColor = Color.Tomato
        LabHead.Text &= " (Debug Mode)"
#End If

        If OSHelper.IsWinTen Then
            LabOpSys.Text = OSHelper.GetWindowsName & " " & OSHelper.GetWindowsReleaseId & " " & OSHelper.GetWindowsBitness
        Else
            LabOpSys.Text = OSHelper.GetWindowsName & " " & OSHelper.GetWindowsCurrentBuild & " " & OSHelper.GetWindowsBitness
        End If

        LabScale.Text = DetermineScaleOf()

        'Load scores
        WSR4.GetWinsatSPR()

        'Show hardware
        If Settings.ShowHardwareOnStartup = 1 Then
            GswHardware.Checked = True
        End If

        'UI Update
        UpdateControls()

        'Check notifications
        Task.Factory.StartNew(Sub() CheckNotifications())

    End Sub

    Private Sub CheckNotifications()

        'Updated 07.10.2019
        'All hotfixes are loaded from WMI into a data structure which can be referenced 3x faster with less overhead.
        'This means we're not iterating through every hotfix in WMI multiple times. Good news for slower processors.
        Dim ListOfUpdates As List(Of String) = Knowledgebase.ListAllHotfixes

        'Moved from Program.vb. Holds back spawn time on Win7.
        If OSHelper.IsWinSeven() Then
            'Check convenience rollup KB3125574
            If Not ListOfUpdates.Contains("KB3125574") Then 'Rollup missing, so...
                'Check for older patch KB2687862
                If Not ListOfUpdates.Contains("KB2687862") Then
                    Booleans.BoolMissingHotfix = True 'Still missing
                Else
                    Booleans.BoolMissingHotfix = False 'Installed
                End If
            Else
                Booleans.BoolMissingHotfix = False 'Installed
            End If
        End If

        If Updater.IsNewVersionAvailable() Then
            Booleans.BoolMissingUpdate = True
        End If

        Invoke(DirectCast(Sub() OnFinishedCheckNotifications(), MethodInvoker))

    End Sub

    Private Sub OnFinishedCheckNotifications()

        If Booleans.BoolMissingHotfix Then
            Integers.IntNotificationCount += 1
            UpdateToolstripHotfixItem()
        End If

        If Booleans.BoolMissingUpdate Then
            LabVersion.Text = Application.ProductVersion & " (Outdated)"
            Integers.IntNotificationCount += 1
            UpdateToolstripUpdateItem()
        End If

        If Not Integers.IntNotificationCount = 0 Then
            Notifier1.Controls.Add(CmdHelp, Integers.IntNotificationCount)
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


        PanSplit.BackColor = Settings.ThemeColor

        LabBasescore.ForeColor = Settings.ThemeColor
        GswHardware.SwitchOnColor = Settings.ThemeColor

        'Change buttons
        For Each Ctrl As Control In TlpTop.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        For Each Ctrl As Control In TlpBottom.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        'Export Menu
        For Each Item As ToolStripItem In CmsExport.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Options Menu
        For Each Item As ToolStripItem In CmsOptions.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Tools Menu
        For Each Item As ToolStripItem In CmsTools.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Help Menu
        For Each Item As ToolStripItem In CmsHelp.Items
            Item.ForeColor = Settings.ThemeColor
        Next

        'Reverse changes to cmsHelp.items if notifications are available
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
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles CmdAssess.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
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
            ToastAlert.Show("The system must be rated to use this feature.", ToastType.Warning)
        Else
            Fade.FadeBehindChild(Me)
            Dim FMetrics As New FormMetrics
            AddHandler FMetrics.FormClosed, AddressOf ChildFormClosedNoRefresh
            FMetrics.ShowDialog()
        End If

    End Sub
    Private Sub CmdRunInDepth_Click(sender As Object, e As EventArgs) Handles CmdRunInDepth.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            Fade.FadeBehindChild(Me)
            Dim FAssess As New FormAssessVerbose
            AddHandler FAssess.FormClosed, AddressOf ChildFormClosedRefreshUI
            FAssess.ShowDialog()
        End If
    End Sub
#End Region
#Region "Menu Button Event Handlers"
    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles CmdExport.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("There must be a valid Experience Index rating to use these features.", ToastType.Warning)
        Else
            Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
            ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
            CmsExport.Show(ptLowerLeft)
        End If

    End Sub
    Private Sub CmdOptions_Click(sender As Object, e As EventArgs) Handles CmdOptions.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsOptions.Show(ptLowerLeft)

    End Sub
    Private Sub CmdTools_Click(sender As Object, e As EventArgs) Handles CmdTools.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsTools.Show(ptLowerLeft)

    End Sub
    Private Sub CmdHelp_Click(sender As Object, e As EventArgs) Handles CmdHelp.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsHelp.Show(ptLowerLeft)

    End Sub
#End Region
#Region "Gambol Switch Event Handlers"

    Private Sub GSwitchHardware_CheckedChanged(sender As Object, e As EventArgs) Handles GswHardware.CheckedChanged
        If CType(sender, GambolSwitch).Checked Then
            LabShowHardware.Text = "On"
        Else
            LabShowHardware.Text = "Off"
        End If
        SetHW()
    End Sub

#End Region
#Region "Picturebox Event Handlers"
    Private Sub PbxMain_DoubleClick(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToScreen()
    End Sub
#End Region

#Region "Context Menu (Export)"

    Private Sub JPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JPGToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                .FileName = "Xiret-JPG",
                .Filter = "JPEG (*.jpg)|*.jpg",
                .InitialDirectory = Directories.DirSpecialDesktop,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Jpeg)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved to " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could not be saved to disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub PNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNGToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                   .FileName = "Xiret-PNG",
                   .Filter = "Portable Network Graphics (*.png)|*.png",
                   .InitialDirectory = Directories.DirSpecialDesktop,
                   .OverwritePrompt = True
                }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Png)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved to " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could not be saved to disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub BMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMPToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                .FileName = "Xiret-BMP",
                .Filter = "Bitmap Image File (*.bmp)|*.bmp",
                .InitialDirectory = Directories.DirSpecialDesktop,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Bmp)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved to " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could not be saved to disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub TXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem.Click

        If CDbl(Strings.StringBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            Dim SBuilder As New StringBuilder
            SBuilder.Append("Windows Experience Index scores generated by Xiret on " & Date.Today & "." & vbNewLine & vbNewLine)
            SBuilder.Append("Base Score: " & LabBasescore.Text & vbNewLine & vbNewLine)

            If Strings.StringProcessorScore = Strings.StringBaseScore Then
                SBuilder.Append("Processor Score:  " & LabProcessorScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Processor Score:  " & LabProcessorScore.Text & vbNewLine)
            End If

            If Strings.StringMemoryScore = Strings.StringBaseScore Then
                SBuilder.Append("Memory Score:     " & LabMemoryScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Memory Score:     " & LabMemoryScore.Text & vbNewLine)
            End If

            If Strings.StringGraphicsScore = Strings.StringBaseScore Then
                SBuilder.Append("Graphics Score:   " & LabGraphicsScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Graphics Score:   " & LabGraphicsScore.Text & vbNewLine)
            End If

            If Strings.StringGamingScore = Strings.StringBaseScore Then
                SBuilder.Append("Gaming Score:     " & LabGamingScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Gaming Score:     " & LabGamingScore.Text & vbNewLine)
            End If

            If Strings.StringDiskScore = Strings.StringBaseScore Then
                SBuilder.Append("Disk Score:       " & LabDiskScore.Text & " (*)" & vbCrLf & vbCrLf)
            Else
                SBuilder.Append("Disk Score:       " & LabDiskScore.Text & vbCrLf & vbCrLf)
            End If

            SBuilder.Append("(*) - Lowest subscore")

            Dim Sfd As New SaveFileDialog With {
                .FileName = "Xiret-Scores",
                .Filter = "Text File (*.txt)|*.txt",
                .InitialDirectory = Directories.DirSpecialDesktop,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(Sfd.FileName, SBuilder.ToString, False)
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("File saved to " & Sfd.FileName.ToString, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("Could not save scores to a text file.", ToastType.Warning)
            Finally
                Sfd.Dispose()
            End Try

        End If

    End Sub
    Private Sub ImgurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImgurToolStripMenuItem.Click

        CType(sender, ToolStripMenuItem).Enabled = False

        If Strings.StringImgurClientID = "" Then
            ToastAlert.Show("Imgur API client key needed.", ToastType.Warning)
        Else
            If CDbl(Strings.StringBaseScore) = 0 Then 'Unrated system
                ToastAlert.Show("You must rate your system first.", ToastType.Warning)
            Else 'Check imgur is online
                If NetHelper.IsWebsiteAvailable(Strings.StringImgurUrl) Then

                    'Enter printscreen mode
                    EnterPrintMode()

                    'Capture image to upload
                    ImageHelper.CaptureControl(Files.FileTemporary, PanCapture)

                    ' // Imgur Api moved to Core\Helpers\ImageHelper > PostToImgur
                    If Settings.UseCustomImgurApiKey = 1 Then
                        UploadCustomClient()
                    Else
                        UploadNormalClient()
                    End If

                Else 'No connection to Imgur
                    ToastAlert.Show("Could not connect to Imgur. The service may be unavailable.", ToastType.Warning)
                End If
            End If
        End If

        'Finish up
        ExitPrintMode()

        CType(sender, ToolStripMenuItem).Enabled = True

    End Sub

    Private Sub UploadCustomClient()

        Dim exitCode As Integer = ImageHelper.PostToImgur(Files.FileTemporary, Files.FileImgurLog, Settings.StringUserImgurClientId, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

    Private Sub UploadNormalClient()

        Dim exitCode As Integer = ImageHelper.PostToImgur(Files.FileTemporary, Files.FileImgurLog, Strings.StringImgurClientID, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

#End Region
#Region "Context Menu (Options)"

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click
        Try
            Process.Start(Files.FileXiretLog)
        Catch
            ToastAlert.Show("The assessment log file has not been created. It will be available after rating your system at least once.", ToastType.Warning)
        End Try
    End Sub
    Private Sub ViewImgurLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImgurLinksToolStripMenuItem.Click
        Try
            Process.Start(Files.FileImgurLog)
        Catch
            ToastAlert.Show("The Imgur link file has not been created. It will be available after you upload a valid system rating.", ToastType.Warning)
        End Try
    End Sub

    Private Sub ViewWinSATLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWinSATLogToolStripMenuItem.Click
        Try
            Process.Start(Files.FileWinsatLog)
        Catch
            ToastAlert.Show("Could not open winsat.log.", ToastType.Warning)
        End Try
    End Sub

    Private Sub RefreshScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshScoresToolStripMenuItem.Click

        If WinsatApi.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this option.", ToastType.Warning)
        Else
            WSR4.GetWinsatSPR()
            UpdateControls()
        End If

    End Sub

    Private Sub SaveResourcesToDIskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveResourcesToDIskToolStripMenuItem.Click

        Dim FBD As New FolderBrowserDialog With {
        .RootFolder = Environment.SpecialFolder.Desktop,
        .ShowNewFolderButton = True,
        .Description = "Choose a folder to save the items..."
        }

        If FBD.ShowDialog = DialogResult.OK Then
            File.WriteAllBytes(FBD.SelectedPath & "\Windows6_1_KB2687862_x86.msu", My.Resources.Windows6_1_KB2687862_x86)
            File.WriteAllBytes(FBD.SelectedPath & "\Windows6_1_KB2687862_x64.msu", My.Resources.Windows6_1_KB2687862_x64)
            File.WriteAllBytes(FBD.SelectedPath & "\segoeui.ttf", My.Resources.segoeui)
            File.WriteAllBytes(FBD.SelectedPath & "\segoeuib.ttf", My.Resources.segoeuib)
            File.WriteAllBytes(FBD.SelectedPath & "\seguisb.ttf", My.Resources.seguisb)
            ToastAlert.Show("Resources saved to " & FBD.SelectedPath & ".", ToastType.Information)
        End If

    End Sub

    Private Sub ProgramDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramDataToolStripMenuItem.Click
        Try
            Process.Start(Directories.DirAppData)
        Catch
            ToastAlert.Show("Could not navigate to directory.", ToastType.Warning)
        End Try
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
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            Fade.FadeBehindChild(Me)
            Dim F As New FormAssess
            AddHandler F.FormClosed, AddressOf ChildFormClosedRefreshUI
            F.ShowDialog()
        End If

    End Sub
    Private Sub RunVerboseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunVerboseToolStripMenuItem.Click

        If Not PowerHelper.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
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
            Dim TroubProc As New Process
            Dim TempFile As String = Directories.DirTemporary & "\Troubleshooting.rtf"

            Dim buff As Byte() = Encoding.UTF8.GetBytes(My.Resources.troubleshooting)

            File.WriteAllBytes(TempFile, buff)

            If File.Exists(TempFile) = True Then
                With TroubProc.StartInfo
                    .FileName = TempFile
                    .UseShellExecute = True
                    .WindowStyle = ProcessWindowStyle.Maximized
                End With
                TroubProc.Start()
            End If
        Catch ex As IOException
            ToastAlert.Show("Troubleshooting is already open.", ToastType.Information)
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

    Private Sub AcknowledgementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcknowledgementsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAckn
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

#End Region
#Region "Context Menu (Application)"

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
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
    Private Function DetermineScaleOf() As String

        Select Case OSHelper.GetKernelVersion.ProductMajorPart
            Case 6
                If OSHelper.GetKernelVersion.ProductMinorPart = 0 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 5.9." : End If 'Vista
                If OSHelper.GetKernelVersion.ProductMinorPart = 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 7.9." : End If '7
                If OSHelper.GetKernelVersion.ProductMinorPart > 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." : End If '8, 8.1
            Case 10
                Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." '10
            Case Else
                Return "The Experience Index assesses key system components."
        End Select

        Return "The Experience Index assesses key system components."

    End Function
    Private Sub EnterPrintMode()
        CmdAssess.Hide()
        If OSHelper.IsWinTen Then
            LabScale.Text = "Xiret v" & Application.ProductVersion & " on " & OSHelper.GetWindowsName() & " v" & OSHelper.GetWindowsReleaseId() & " " _
                & OSHelper.GetWindowsBitness() & " (Branch: " & OSHelper.GetWindowsBuildBranch & ")"
        Else
            LabScale.Text = "Xiret v" & Application.ProductVersion & " on " & OSHelper.GetWindowsName() & " " _
                & OSHelper.GetWindowsBitness() & " (" & OSHelper.GetWindowsBuildLab & ")"
        End If
    End Sub
    Private Sub ExitPrintMode()
        CmdAssess.Show()
        LabScale.Text = DetermineScaleOf()
    End Sub
    Private Sub ChildFormClosedRefreshUI(ByVal sender As Object, ByVal e As EventArgs)
        Fade.RefadeIn(Me)
        WSR4.GetWinsatSPR()
        UpdateControls()
        MemHelper.FreeMemory()
    End Sub
    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)
        Fade.RefadeIn(Me)
        MemHelper.FreeMemory()
    End Sub
    Friend Sub UpdateControls()

        'Check assessment validity
        LabEIState.Text = State.ConvertAssessmentState(WinsatApi.GetAssessmentValidityInt())
        CmdAssess.Text = State.GenerateRunStateText

        If WinsatApi.GetAssessmentValidityInt() = 1 Then : LabBasescore.ForeColor = Settings.ThemeColor : PanValidityState.BackColor = Colors.ColorValid
        Else : LabBasescore.ForeColor = Colors.ColorBaseScoreUnrated : PanValidityState.BackColor = Colors.ColorInvalid
        End If

        'Check CPU score against Base score
        If Strings.StringProcessorScore = Strings.StringBaseScore Then : PanSubProcessor.BackColor = Colors.ColorPanelActive : LabProcessorScore.ForeColor = Settings.ThemeColor
        Else : PanSubProcessor.BackColor = Colors.ColorPanelNormal : LabProcessorScore.ForeColor = Color.White
        End If

        'Check Memory score against Base score
        If Strings.StringMemoryScore = Strings.StringBaseScore Then : PanSubMemory.BackColor = Colors.ColorPanelActive : LabMemoryScore.ForeColor = Settings.ThemeColor
        Else : PanSubMemory.BackColor = Colors.ColorPanelNormal : LabMemoryScore.ForeColor = Color.White
        End If

        'Check Graphics Score against Base score
        If Strings.StringGraphicsScore = Strings.StringBaseScore Then : PanSubGraphics.BackColor = Colors.ColorPanelActive : LabGraphicsScore.ForeColor = Settings.ThemeColor
        Else : PanSubGraphics.BackColor = Colors.ColorPanelNormal : LabGraphicsScore.ForeColor = Color.White
        End If

        'Check Gaming score against Base score
        If Strings.StringGamingScore = Strings.StringBaseScore Then : PanSubGaming.BackColor = Colors.ColorPanelActive : LabGamingScore.ForeColor = Settings.ThemeColor
        Else : PanSubGaming.BackColor = Colors.ColorPanelNormal : LabGamingScore.ForeColor = Color.White
        End If

        'Check Disk score against Base score
        If Strings.StringDiskScore = Strings.StringBaseScore Then : PanSubDisk.BackColor = Colors.ColorPanelActive : LabDiskScore.ForeColor = Settings.ThemeColor
        Else : PanSubDisk.BackColor = Colors.ColorPanelNormal : LabDiskScore.ForeColor = Color.White
        End If

        'Determine last assessment date
        Strings.StringDate = Format(WinsatApi.GetWinsatLastUpdateDate(), "dddd, MMM d yyyy hh:mm tt")
        If (Strings.StringDate = "") Or Strings.StringDate.Contains("1999") Then
            LabLastUpdate.Text = "Never"
        Else
            LabLastUpdate.Text = Strings.StringDate
        End If

        'Hardware switch
        If GswHardware.Checked Then
            LabShowHardware.Text = "On"
        Else
            LabShowHardware.Text = "Off"
        End If

        'Pass score strings to UI
        LabBasescore.Text = Strings.StringBaseScore
        LabProcessorScore.Text = Strings.StringProcessorScore
        LabMemoryScore.Text = Strings.StringMemoryScore
        LabGraphicsScore.Text = Strings.StringGraphicsScore
        LabGamingScore.Text = Strings.StringGamingScore
        LabDiskScore.Text = Strings.StringDiskScore

        If Strings.StringBaseScore = "0" Or Strings.StringBaseScore = Nothing Then
            LabBasescore.Text = "0.0"
        End If

        SetSwitchState()
        LoadHardwareStrings()

    End Sub
    Private Sub SetSwitchState()
        If Not WinsatApi.GetAssessmentValidityInt() = 3 Then
            GswHardware.Enabled = True
        Else
            GswHardware.Checked = False : GswHardware.Enabled = False
        End If
    End Sub
    Private Sub LoadHardwareStrings()
        If Settings.UseApiHardware = 1 Then
            WSR4.ReadAPIHardware()
        Else
            WSR4.ReadXMLHardware()
        End If
    End Sub
    Public Sub SetHW()

        LoadHardwareStrings()

        If GswHardware.Checked Then
            LabWirProcessor.Text = Strings.StringProcessorHW.Replace("(R)", "®").Replace("(TM)", "™")
            LabWirMemory.Text = Strings.StringMemoryHW
            LabWirGraphics.Text = Strings.StringGraphicsHW.Replace("(R)", "®").Replace("(TM)", "™")
            LabWirGaming.Text = Strings.StringGamingHW
            LabWirDisk.Text = Strings.StringDiskHW
        Else
            LabWirProcessor.Text = Strings.StringProcessorRO
            LabWirMemory.Text = Strings.StringMemoryRO
            LabWirGraphics.Text = Strings.StringGraphicsRO
            LabWirGaming.Text = Strings.StringGamingRO
            LabWirDisk.Text = Strings.StringDiskRO
        End If

    End Sub
    Private Sub UpdateToolstripHotfixItem()
        HotfixAvailableToolStripMenuItem.Visible = True
        HotfixAvailableToolStripMenuItem.ForeColor = Color.White
        HotfixAvailableToolStripMenuItem.Text = "Hotfix Available"
        HotfixAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub
    Private Sub UpdateToolstripUpdateItem()
        UpdateAvailableToolStripMenuItem.Visible = True
        UpdateAvailableToolStripMenuItem.ForeColor = Color.White
        UpdateAvailableToolStripMenuItem.Text = "Download Update"
        UpdateAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub

    Friend Sub HotfixWasInstalled()

        HotfixAvailableToolStripMenuItem.Visible = False
        Integers.IntNotificationCount -= 1
        Notifier1.DeactivateAll()

        If Not Integers.IntNotificationCount = 0 Then
            Notifier1.Controls.Add(CmdHelp, Integers.IntNotificationCount)
            Notifier1.Activate()
        End If

    End Sub

#End Region
#Region "Misc design"
    Private Sub GSwitchHardware_MouseEnter(sender As Object, e As EventArgs) Handles GswHardware.MouseEnter
        LabShowHardware.BackColor = Color.FromArgb(10, 10, 10)
    End Sub
    Private Sub GSwitchHardware_MouseLeave(sender As Object, e As EventArgs) Handles GswHardware.MouseLeave
        LabShowHardware.BackColor = Color.FromArgb(35, 35, 35)
    End Sub

    Private Sub LabVersion_Click(sender As Object, e As EventArgs) Handles LabVersion.Click
        If Booleans.BoolMissingUpdate Then
            Fade.FadeBehindChild(Me)

            Dim FUpdate As New FormUpdate
            AddHandler FUpdate.FormClosed, AddressOf ChildFormClosedNoRefresh
            FUpdate.ShowDialog()
        End If
    End Sub

    Private Sub LabVersion_MouseEnter(sender As Object, e As EventArgs) Handles LabVersion.MouseEnter
        If Booleans.BoolMissingUpdate Then
            CType(sender, Label).Cursor = Cursors.Hand
        End If
    End Sub

#End Region

End Class
