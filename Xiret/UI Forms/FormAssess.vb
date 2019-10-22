'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormAssess.vb
'  Created by David S on 20.03.2016
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'  Updated on 06.10.2019 - DS (Add build number to InitData(), bugfixing)

Imports System.Text

Imports Xiret.Core.Animation
Imports Xiret.Core.Helpers

#Disable Warning IDE0069

Friend Class FormAssess

#Region "Variables"

    'Delete sub routines
    Private Delegate Sub StatusDelegate(StringStatus As String)
    Private Delegate Sub ExitCodeDelegate(IntExitCode As Integer)
    Private Delegate Sub LogDelegate(StringData As String)
    Private Delegate Sub ProgressDelegate(IntValue As Integer)
    Private Delegate Sub InvokeAsync(StringAsync As String)

    'Strings
    Private StringStatusMessage As String = String.Empty
    Private StringInformationMessage As String = String.Empty

    'Integers
    Private IntExitCode As Integer = 0
    Private IntProgress As Integer = 0

    'Bool
    Private IsComplete As Boolean = False
    Private IsClosing As Boolean = False

    Private BoolRanWithError As Boolean = False
    Private BoolRanWithWarning As Boolean = False

    Private PSI As ProcessStartInfo
    Private WinSATProcess As Process

    Private WithEvents ProcessWatcher As Timers.Timer

    Private IntErrorCount As Integer = 0
    Private IntWarningCount As Integer = 0

#End Region

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetAssessThemeAccent()
    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove, PanHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        CmdCancel.PerformClick()
    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormAssess_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            CmdCancel.PerformClick()
        End If
    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormAssess_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitData()

        ProcessWatcher = New Timers.Timer(2000)
        AddHandler ProcessWatcher.Elapsed, AddressOf WaitForUnexpectedExit
        ProcessWatcher.Start()

        PSI = New ProcessStartInfo("winsat", "formal")

        Dim enc As Encoding
        If OSHelper.IsWinVista() Then
            enc = Encoding.Unicode
        Else
            enc = Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
        End If

        With PSI
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardErrorEncoding = enc
            .StandardOutputEncoding = enc
        End With

        WinSATProcess = New Process With {.StartInfo = PSI, .EnableRaisingEvents = True}

        AddHandler WinSATProcess.ErrorDataReceived, AddressOf ASyncronousDataReceived
        AddHandler WinSATProcess.OutputDataReceived, AddressOf ASyncronousDataReceived
        WinSATProcess.Start()
        WinSATProcess.BeginOutputReadLine()
        WinSATProcess.BeginErrorReadLine()

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormAssess_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"
    Private Sub FormAssess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetAssessThemeAccent()

        PanSplit.BackColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpButtons.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click

        If Not IsComplete Then
            My.Computer.FileSystem.WriteAllText(Files.FileXiretLog, "Test interruped by user" & vbCrLf, True)
        End If

        IsClosing = True

        KillWatcher()
        KillWinsat()

        Close()

    End Sub
    Private Sub CmdLog_Click(sender As Object, e As EventArgs) Handles CmdViewLog.Click

        Try
            Process.Start(Files.FileXiretLog)
        Catch ex As Exception
            ToastAlert.Show("The log file is missing or has not been created.", ToastType.Warning)
        End Try

    End Sub
#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxHead_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "AsyncOut Routines"
    Private Sub ASyncronousDataReceived(sender As Object, e As DataReceivedEventArgs)

        If IsClosing Then
            Exit Sub
        Else
            If e.Data Is Nothing Then
                Exit Sub
            Else
                Invoke(New InvokeAsync(AddressOf AsyncOut), e.Data)
            End If
        End If

    End Sub
    Private Sub AsyncOut(StringAsync As String)

        If StringAsync.Contains("Total Run Time") Then 'Finished

            Log(StringAsync)

            KillWatcher()

            IsComplete = True

            IntProgress = 100
            Invoke(New ProgressDelegate(AddressOf InvokeProgress), New Object() {IntProgress})

            If BoolRanWithError Then
                Log("The assessment ran with " & IntErrorCount & " error(s)")
                IntExitCode = 1
            End If

            If BoolRanWithWarning Then
                Log("The assessment ran with " & IntWarningCount & " warning(s)")
                IntExitCode = 1
            End If

            If Not BoolRanWithError And Not BoolRanWithWarning Then
                IntExitCode = 0
            End If

            Invoke(New ExitCodeDelegate(AddressOf InvokeExitCode), New Object() {IntExitCode})

            Exit Sub

        Else
            If Not StringAsync.Contains("Total Run Time") Then 'Running

                Log(StringAsync)

                If StringAsync.Contains("Error") Then
                    BoolRanWithError = True
                    IntErrorCount += 1
                End If
                If StringAsync.Contains("Warning") Then
                    BoolRanWithWarning = True
                    IntWarningCount += 1
                End If

                If OSHelper.IsWinVista() Then 'Vista

                    If StringAsync.Contains("Running: Feature Enumeration") Then
                        LabStatus.Text = "Gathering System Information..."
                        IntProgress = 0
                    End If
                    If StringAsync.Contains("Assessing desktop graphics") Then
                        LabStatus.Text = "Running the Direct3D 9 Aero Assessment..."
                        IntProgress = 10
                    End If
                    If StringAsync.Contains("Direct3D9 alpha blend") Then
                        LabStatus.Text = "Running the Direct3D 9 Alpha Blend Assessment..."
                        IntProgress = 20
                    End If
                    If StringAsync.Contains("Direct3D9 texture load") Then
                        LabStatus.Text = "Running the Direct3D 9 Texture Load Assessment..."
                        IntProgress = 30
                    End If
                    If StringAsync.Contains("Direct3D9 ALU performance") Then
                        LabStatus.Text = "Running the Direct3D 9 ALU Assessment..."
                        IntProgress = 40
                    End If
                    If StringAsync.Contains("Running: Media Decode/Encode") Then
                        LabStatus.Text = "Assessing Windows Media Encoding Performance..."
                        IntProgress = 50
                    End If
                    If StringAsync.Contains("Running: Media Foundation") Then
                        LabStatus.Text = "Assessing Windows Media Decoding Performance..."
                        IntProgress = 60
                    End If
                    If StringAsync.Contains("Running: CPU Assessment") Then
                        LabStatus.Text = "Assessing CPU Performance..."
                        IntProgress = 70
                    End If
                    If StringAsync.Contains("Running: System memory performance") Then
                        LabStatus.Text = "Assessing Memory Performance..."
                        IntProgress = 80
                    End If
                    If StringAsync.Contains("Running: Storage Assessment") Then
                        LabStatus.Text = "Assessing Disk Performance..."
                        IntProgress = 90
                    End If

                Else
                    If OSHelper.IsWinTen() Then '10

                        If StringAsync.Contains("Running: Feature Enumeration") Then
                            LabStatus.Text = "Gathering System Information..."
                            IntProgress = 5
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-aname DWM") Then
                            LabStatus.Text = "Running the Direct3D 9 Aero Assessment..."
                            IntProgress = 10
                        End If
                        '// From here, Windows 10 skips these tests
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-aname Batch") Then
                            Log(" ! Skipped the Direct3D 9 Batch Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-aname Alpha") Then
                            Log(" ! Skipped the Direct3D 9 Alpha Blend Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-aname Tex") Then
                            Log(" ! Skipped the Direct3D 9 Texture Load Assessment")
                            IntProgress = 20
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-aname ALU") Then
                            Log(" ! Skipped the Direct3D 9 ALU Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Batch") Then
                            Log(" ! Skipped the Direct3D 10 Batch Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Alpha") Then
                            Log(" ! Skipped the Direct3D 10 Alpha Blend Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Tex") Then
                            Log(" ! Skipped the Direct3D 10 Texture Load Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname ALU") Then
                            Log(" ! Skipped the Direct3D 10 ALU Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Geom") Then
                            Log(" ! Skipped the Direct3D 10 Geometry Assessment")
                        End If
                        If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname CBuffer") Then
                            Log(" ! Skipped the Direct3D 10 Constant Buffer Assessment")
                        End If
                        If StringAsync.Contains("Running: Media Foundation") Then
                            LabStatus.Text = "Assessing Windows Media Decoding Performance..."
                            IntProgress = 65
                        End If
                        If StringAsync.Contains("Running: Extended Media Assessment") Then
                            LabStatus.Text = "Tuning Windows Media Decoding..."
                            IntProgress = 70
                        End If
                        If StringAsync.Contains("Running: Media Decode/Encode") Then
                            LabStatus.Text = "Assessing Windows Media Encoding Performance..."
                            IntProgress = 75
                        End If
                        '//
                        If StringAsync.Contains("Running: CPU Assessment") Then
                            LabStatus.Text = "Assessing CPU Performance..."
                            IntProgress = 80
                        End If
                        If StringAsync.Contains("Running: System memory performance") Then
                            LabStatus.Text = "Assessing Memory Performance..."
                            IntProgress = 85
                        End If
                        If StringAsync.Contains("Running: Storage Assessment") Then
                            LabStatus.Text = "Assessing Disk Performance..."
                            IntProgress = 95
                        End If

                    Else
                        If Not OSHelper.IsWinVista() And Not OSHelper.IsWinTen() Then '7 - 8.1

                            If StringAsync.Contains("Running: Feature Enumeration") Then
                                LabStatus.Text = "Gathering System Information..."
                                IntProgress = 5
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-aname DWM") Then
                                LabStatus.Text = "Running the Direct3D 9 Aero Assessment..."
                                IntProgress = 10
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-aname Batch") Then
                                LabStatus.Text = "Running the Direct3D 9 Batch Assessment..."
                                IntProgress = 15
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-aname Alpha") Then
                                LabStatus.Text = "Running the Direct3D 9 Alpha Blend Assessment..."
                                IntProgress = 25
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-aname Tex") Then
                                LabStatus.Text = "Running the Direct3D 9 Texture Load Assessment..."
                                IntProgress = 20
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-aname ALU") Then
                                LabStatus.Text = "Running the Direct3D 9 ALU Assessment..."
                                IntProgress = 30
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Batch") Then
                                LabStatus.Text = "Running the Direct3D 10 Batch Assessment..."
                                IntProgress = 35
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Alpha") Then
                                LabStatus.Text = "Running the Direct3D 10 Alpha Blend Assessment..."
                                IntProgress = 40
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Tex") Then
                                LabStatus.Text = "Running the Direct3D 10 Texture Load Assessment..."
                                IntProgress = 45
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname ALU") Then
                                LabStatus.Text = "Running the Direct3D 10 ALU Assessment..."
                                IntProgress = 50
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname Geom") Then
                                LabStatus.Text = "Running the Direct3D 10 Geometry Assessment..."
                                IntProgress = 55
                            End If
                            If StringAsync.Contains("WinSAT Direct3D Assessment '-dx10  -aname CBuffer") Then
                                LabStatus.Text = "Running the Direct3D 10 Constant Buffer Assessment..."
                                IntProgress = 60
                            End If
                            If StringAsync.Contains("Running: Media Foundation") Then
                                LabStatus.Text = "Assessing Windows Media Decoding Performance..."
                                IntProgress = 65
                            End If
                            If StringAsync.Contains("Running: Extended Media Assessment") Then
                                LabStatus.Text = "Tuning Windows Media Decoding..."
                                IntProgress = 70
                            End If
                            If StringAsync.Contains("Running: Media Decode/Encode") Then
                                LabStatus.Text = "Assessing Windows Media Encoding Performance..."
                                IntProgress = 75
                            End If
                            If StringAsync.Contains("Running: CPU Assessment") Then
                                LabStatus.Text = "Assessing CPU Performance..."
                                IntProgress = 80
                            End If
                            If StringAsync.Contains("Running: System memory performance") Then
                                LabStatus.Text = "Assessing Memory Performance..."
                                IntProgress = 85
                            End If
                            If StringAsync.Contains("Running: Storage Assessment") Then
                                LabStatus.Text = "Assessing Disk Performance..."
                                IntProgress = 95
                            End If

                        End If
                    End If
                End If

                'Update progress
                Invoke(New ProgressDelegate(AddressOf InvokeProgress), New Object() {IntProgress})

            End If
        End If

    End Sub

#End Region
#Region "Delegate Routines"

    Private Sub InvokeExitCode(IntExitCode As Integer)

        If Not IsClosing Then

            Select Case IntExitCode
                Case 0
                    StringStatusMessage = "Process finished"
                    StringInformationMessage = "The assessment completed successfully. You may close this window to see your scores."
                Case 1
                    StringStatusMessage = "Code 0x1: WinSAT ran with errors."
                    StringInformationMessage = "The assessment may not have completed properly. See the log for problem details."
                Case 2
                    StringStatusMessage = "Code 0x2: Process error"
                    StringInformationMessage = "The assessment did not complete before it finished as WinSAT quit unexpectedly. See the log for problem details."
            End Select

            If InvokeRequired Then
                LabStatus.Invoke(DirectCast(Sub() LabStatus.Text = StringStatusMessage, MethodInvoker))
                LabInfo.Invoke(DirectCast(Sub() LabInfo.Text = StringInformationMessage, MethodInvoker))
                CmdCancel.Invoke(DirectCast(Sub() CmdCancel.Text = "Close", MethodInvoker))
                PbxLoad.Invoke(DirectCast(Sub() PbxLoad.Hide(), MethodInvoker))
                LabProgress.Invoke(DirectCast(Sub() LabProgress.Text = "", MethodInvoker))
            Else
                LabStatus.Text = StringStatusMessage
                LabInfo.Text = StringInformationMessage
                CmdCancel.Text = "Close"
                PbxLoad.Hide()
                LabProgress.Text = ""
            End If

            Log("ExitCode: " & IntExitCode)
            Log("Validity Int: " & WinsatAPI.GetAssessmentValidityInt())
            Log("Process finished")

        End If

    End Sub

    Private Sub InvokeProgress(ByVal IntValue As Integer)

        If Not IsClosing Then
            If InvokeRequired Then
                GProgressBar.Invoke(DirectCast(Sub() GProgressBar.Value = IntValue, MethodInvoker))
                LabProgress.Invoke(DirectCast(Sub() LabInfo.Text = CStr(IntValue & "%"), MethodInvoker))
            Else
                GProgressBar.Value = IntValue
                LabProgress.Text = IntValue & "%"
            End If
        End If

    End Sub

#End Region
#Region "Misc Routines"

    Private Sub KillWinsat()

        If WinSATProcess IsNot Nothing Then
            Try
                If Not WinSATProcess.HasExited Then
                    LabStatus.Text = "Waiting for WinSAT to exit..."
                    Log("WinSAT wait...")
                    Do Until (WinSATProcess.HasExited)
                        WinSATProcess.Kill()
                    Loop
                    Log("WinSAT shutdown complete")
                    Log("Process finished")
                End If
            Catch
            End Try
        End If

    End Sub
    Private Sub KillWatcher()

        If ProcessWatcher.Enabled Then
            LabStatus.Text = "Waiting for ProcessWatcher to exit..."
            Log("ProcessWatcher Wait...")
            Do Until Not ProcessWatcher.Enabled
                ProcessWatcher.Stop()
            Loop
            Log("ProcessWatcher shutdown complete")
        End If

    End Sub
    Private Sub WaitForUnexpectedExit(sender As Object, e As EventArgs)

        If IsComplete Then
            Exit Sub
        Else
            If Not IsComplete And (WinSATProcess.HasExited = True) Then
                If Not IsClosing Then
                    ProcessWatcher.Stop()
                    Invoke(DirectCast(Sub() Log("ProcessWatcher: WinSAT was closed or unexpectedly quit"), MethodInvoker))
                    IntProgress = 0
                    Invoke(New ProgressDelegate(AddressOf InvokeProgress), New Object() {IntProgress})
                    IntExitCode = 2
                    Invoke(New ExitCodeDelegate(AddressOf InvokeExitCode), New Object() {IntExitCode})
                End If
            End If
        End If

    End Sub
    Private Sub InitData()

        Log("New Test Started on " & Format(Date.Now, "dddd, MMM d yyyy hh:mm tt"))
        Log("Xiret v" & Application.ProductVersion & " " & Program.ProductChannel & " (" & Program.XiretBuild & ")")
        Log("OS: " & OSHelper.GetWindowsName() & " (Kernel: " & OSHelper.GetKernelVersion.ProductVersion & ")")
        Log("Arch: " & OSHelper.GetWindowsBitness(True))
        Log("Winsat EXE v" & OSHelper.GetWinsatVersion.ProductVersion)
        Log("Winsat API v" & OSHelper.GetWinsatApiVersion.ProductVersion)

        If OSHelper.IsWinVista() Then
            Log("Method: AsyncOut [Vista]")
        Else
            If (OSHelper.IsWinTen()) Then
                Log("Method: AsyncOut [Redstone]")
            Else
                Log("Method: AsyncOut [SAE]")
            End If
        End If

        Log("Mode: Normal")
        Log("Validity Int: " & WinsatApi.GetAssessmentValidityInt())

    End Sub
#End Region

#Region "Logger"

    Private Sub Log(ByVal StringReceived As String)
        My.Computer.FileSystem.WriteAllText(Files.FileXiretLog, StringReceived & vbCrLf, True)
    End Sub

#End Region

End Class