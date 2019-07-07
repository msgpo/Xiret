'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  FormAssessVerbose.vb
'  Created by David S on 11.12.2016 - Original code by Joshua H (PAYMYRENT) 
'  Updated on 08/01/2019 - DS (Cleanup)

Imports System.Threading
Imports System.Net
Imports System.Text

Imports Xiret.Core.Converters
Imports Xiret.Core.Helpers
Imports Xiret.Core.Support

Public Class FormException

#Region "Variables"

    Private Property HasParent As Boolean

    'Strings
    Private StringModules As String = Nothing
    Public Shared StringBody As String = Nothing

    'Threads
    Private ThreadBuildReport As Thread
    Private ThreadSend As Thread

    'Delegate
    Private Delegate Sub StringDelegate(ByVal StringValue As String)
    Private Delegate Sub ErrorDelegate(ByVal StringError As String)

#End Region

#Region "Frame Interaction"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormException_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then : Close() : End If
    End Sub
#End Region

#Region "Theme"
    Private Sub SetExceptionThemeAccent()

        pnlSplit.BackColor = GlobalThemeColor

        'Change buttons
        For Each c As Control In tlpButtons.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = GlobalThemeColor
        Next

        'Apply border
        If BoolThemeApplyBorder Then : BackColor = GlobalThemeColor
        Else : BackColor = ColorBorderStandard
        End If

    End Sub
#End Region

#Region "Load Event"

    Private Sub FormException_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetExceptionThemeAccent()

        lbInfo.Text = ApplicationSupport.StringException

        lbStatus.Text = "Generating report data..."

        ThreadBuildReport = New Thread(AddressOf GenerateReport) With {.IsBackground = True}
        ThreadBuildReport.Start()

    End Sub

#End Region
#Region "Buttons"

    Private Sub cmdContinue_Click(sender As Object, e As EventArgs) Handles cmdContinue.Click
        Close()
    End Sub

    Private Sub cmdForceQuit_Click(sender As Object, e As EventArgs) Handles cmdForceQuit.Click
        Environment.Exit(0)
    End Sub

    Private Sub cmdSendReport_Click(sender As Object, e As EventArgs) Handles cmdSendReport.Click

        If NHIsSiteAvailable(StringBitmightURL) Then
            lbStatus.Text = "Loading..."
            cmdSendReport.Enabled = False
            cmdForceQuit.Enabled = False
            cmdContinue.Enabled = False
            ThreadSend = New Thread(AddressOf SendErrorReport) With {.IsBackground = True} : ThreadSend.Start()
        Else : lbStatus.Text = "Cannot reach bitmight.uk, check network connection."
        End If

    End Sub

#End Region

#Region "Report Routines"

    Private Sub GenerateReport()

        Try
            Dim ThisProcess As Process = Process.GetCurrentProcess
            Dim XirVersion As String = Application.ProductVersion
            Dim XirName As String = Application.ProductName
            Dim XirDate As String = CStr(DateTime.Now.ToShortDateString & " at " & DateTime.Now.ToShortTimeString)
            Dim XirPath As String = AppDomain.CurrentDomain.FriendlyName
            Dim SBuilder As New StringBuilder
            Dim IntModuleNumber As Integer = 0


            For Each LoadedModule As ProcessModule In ThisProcess.Modules

                IntModuleNumber += 1
                Dim vIn As Integer = LoadedModule.ModuleMemorySize
                Dim vOut As ULong = Convert.ToUInt64(vIn)

                With SBuilder
                    .AppendLine("  Module #" & IntModuleNumber & " -> " & "'" & LoadedModule.ModuleName & "'" & vbCrLf)
                    .AppendLine("Path: " & LoadedModule.FileName)
                    .AppendLine("Version: " & CStr(LoadedModule.FileVersionInfo.FileVersion))
                    .AppendLine("Description: " & LoadedModule.FileVersionInfo.FileDescription)
                    .AppendLine("Checksum: " & CryptoHelper.CHGeneratesha256(LoadedModule.FileName))
                    .AppendLine("Size (Bytes): " & CStr(LoadedModule.ModuleMemorySize))
                    .AppendLine("Size (Big): " & ConvertBigSize(vOut))
                    .AppendLine("Base Address: " & LoadedModule.BaseAddress.ToString)
                    .AppendLine("Entry Point: " & LoadedModule.EntryPointAddress.ToString)
                    .AppendLine()
                    .AppendLine("------------------------------------------------------------------------")
                    .AppendLine()
                End With
            Next

            StringModules = SBuilder.ToString
            SBuilder.Length = 0

            With SBuilder
                .AppendLine("# // Unhandled exception caught in web on " & XirDate & vbCrLf)
                .AppendLine("<-- Application -->" & vbCrLf)
                .AppendLine("Name: " & XirName)
                .AppendLine("Version: " & XirVersion)
                .AppendLine("Checksum: " & CryptoHelper.CHGeneratesha256(XirPath))
                .AppendLine("ProcessID: " & ThisProcess.Id & vbCrLf)
                .AppendLine("<-- Environment -->" & vbCrLf)
                .AppendLine("Operating System: " & OSHelper.OSHGetName() & " (" & OSHelper.OSHKernelVersion.ProductVersion() & ")")
                .AppendLine("Platform Architecture: " & OSHelper.OSHGetBitness())
                .AppendLine("WinSAT Executable: " & OSHelper.OSHWinsatVersion.ProductVersion())
                .AppendLine("WinSAT API: " & OSHelper.OSHWinsatApiVersion.ProductVersion() & vbCrLf)
                .AppendLine("<-- Exception -->" & vbCrLf)
                .AppendLine(ApplicationSupport.StringException & vbCrLf)
                .AppendLine("<-- Callstack -->" & vbCrLf)
                .AppendLine(ApplicationSupport.StringStackTrace & vbCrLf)
                .AppendLine("<-- Loaded Modules -->" & vbCrLf)
                .AppendLine("------------------------------------------------------------------------" & vbCrLf)
                .AppendLine(StringModules)
                .AppendLine("# // End of file")
            End With

            StringBody = SBuilder.ToString
            StringBodyFull = StringBody
            SBuilder = Nothing

            lbStatus.Invoke(DirectCast(Sub() lbStatus.Text = "Report ready to send", MethodInvoker))
            cmdContinue.Invoke(DirectCast(Sub() cmdContinue.Enabled = True, MethodInvoker))
            cmdSendReport.Invoke(DirectCast(Sub() cmdSendReport.Enabled = True, MethodInvoker))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub SendErrorReport()

        lbStatus.Invoke(DirectCast(Sub() lbStatus.Text = "Sending report...", MethodInvoker))

        Try
            Dim StringURL As String = "https://www.bitmight.uk/software/xiret/autogen/autogen.php?program=Xiret"

            Using WClient As New WebClient

                Dim SetCachePolicy As Cache.RequestCachePolicy = New Cache.RequestCachePolicy(Cache.RequestCacheLevel.NoCacheNoStore)
                WClient.CachePolicy = SetCachePolicy

                Dim WParams As New Specialized.NameValueCollection From {{"report", StringBody}}

                Dim ResBytes = WClient.UploadValues(StringURL, "POST", WParams)
                Dim StringResponse As String = Encoding.UTF8.GetString(ResBytes)

                Invoke(New StringDelegate(AddressOf InvokeString), New Object() {StringResponse})

            End Using

        Catch ex As Exception
            Invoke(New ErrorDelegate(AddressOf InvokeError), New Object() {ex.ToString})
        End Try

        'tut tut, lazy lazy
        cmdForceQuit.Invoke(DirectCast(Sub() cmdForceQuit.Enabled = True, MethodInvoker))
        cmdContinue.Invoke(DirectCast(Sub() cmdContinue.Enabled = True, MethodInvoker))

    End Sub

#End Region
#Region "Delegate Routines"

    Private Sub InvokeError(ByVal StringError As String)
        MessageBox.Show(StringError)
    End Sub

    Private Sub InvokeString(ByVal StringValue As String)
        If StringValue.ToLower().Contains("unknown") Then
            lbStatus.Text = StringValue
        Else
            lbStatus.Text = StringValue
        End If
    End Sub

#End Region

End Class