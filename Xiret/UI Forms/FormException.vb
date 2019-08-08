'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormException.vb
'  Created by David S on 11.12.2016 - Original code by Joshua H (PAYMYRENT) 
'  Updated on 31.07.2019 - DS (Cleanup, update exception)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports System.Threading
Imports System.Net
Imports System.Text

Imports Core.Converters
Imports Core.Helpers

Imports Xiret.Prog.Support

Public Class FormException

    Private StringModules As String = Nothing
    Friend Shared StringBody As String = Nothing

    Private ThreadBuildReport As Thread
    Private ThreadSend As Thread

    Private Delegate Sub StringDelegate(ByVal StringValue As String)
    Private Delegate Sub ErrorDelegate(ByVal StringError As String)

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, pnlHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormException_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
#End Region

#Region "Theme"
    Private Sub SetExceptionThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        For Each c As Control In tlpButtons.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormException_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetExceptionThemeAccent()

        lbInfo.Text = ApplicationSupport.StringException

        lbStatus.Text = "Generating report data..."

        ThreadBuildReport = New Thread(AddressOf GenerateReport) With {.IsBackground = True}
        ThreadBuildReport.Start()

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdContinue_Click(sender As Object, e As EventArgs) Handles cmdContinue.Click
        Close()
    End Sub

    Private Sub CmdForceQuit_Click(sender As Object, e As EventArgs) Handles cmdForceQuit.Click
        Environment.Exit(0)
    End Sub

    Private Sub CmdSendReport_Click(sender As Object, e As EventArgs) Handles cmdSendReport.Click

        If NetHelper.IsWebsiteAvailable(Strings.StringBitmightUrl) Then
            lbStatus.Text = "Loading..."
            cmdSendReport.Enabled = False
            cmdForceQuit.Enabled = False
            cmdContinue.Enabled = False
            ThreadSend = New Thread(AddressOf SendErrorReport) With {.IsBackground = True} : ThreadSend.Start()
        Else
            lbStatus.Text = "Cannot reach bitmight.uk, check network connection."
        End If

    End Sub

#End Region

#Region "Routines"

    Private Sub GenerateReport()

        Try
            Dim proc As Process = Process.GetCurrentProcess
            Dim stringVersion As String = Application.ProductVersion
            Dim stringName As String = Application.ProductName
            Dim stringDate As String = Now.ToShortDateString & " at " & Now.ToShortTimeString
            Dim stringPath As String = AppDomain.CurrentDomain.FriendlyName
            Dim SBuilder As New StringBuilder
            Dim IntModuleNumber As Integer = 0


            For Each LoadedModule As ProcessModule In proc.Modules

                IntModuleNumber += 1
                Dim vIn As Integer = LoadedModule.ModuleMemorySize
                Dim vOut As ULong = Convert.ToUInt64(vIn)

                With SBuilder
                    .AppendLine("  Module #" & IntModuleNumber & " -> " & "'" & LoadedModule.ModuleName & "'" & vbCrLf)
                    .AppendLine("Path: " & LoadedModule.FileName)
                    .AppendLine("Version: " & LoadedModule.FileVersionInfo.FileVersion)
                    .AppendLine("Description: " & LoadedModule.FileVersionInfo.FileDescription)
                    .AppendLine("Checksum: " & CryptoHelper.GetSha256FromFile(LoadedModule.FileName))
                    .AppendLine("Size (Bytes): " & CStr(LoadedModule.ModuleMemorySize))
                    .AppendLine("Size (Big): " & SizeConverter.ConvertBigSize(vOut))
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
                .AppendLine("# // Unhandled exception caught in web on " & stringDate & vbCrLf)
                .AppendLine("<-- Application -->" & vbCrLf)
                .AppendLine("Name: " & stringName)
                .AppendLine("Version: " & stringVersion)
                .AppendLine("Checksum: " & CryptoHelper.GetSha256FromFile(stringPath))
                .AppendLine("ProcessID: " & proc.Id & vbCrLf)
                .AppendLine("<-- Environment -->" & vbCrLf)
                .AppendLine("Operating System: " & OSHelper.GetOSName() & " (" & OSHelper.GetKernelVersion.ProductVersion() & ")")
                .AppendLine("Platform Architecture: " & OSHelper.GetOSBitness())
                .AppendLine("WinSAT Executable: " & OSHelper.GetWinsatVersion.ProductVersion())
                .AppendLine("WinSAT API: " & OSHelper.GetWinsatApiVersion.ProductVersion() & vbCrLf)
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
            Strings.StringBodyFull = StringBody
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
            Dim stringUrl As String = "https://www.bitmight.uk/software/xiret/autogen/autogen.php?program=Xiret"

            Using client As New WebClient

                Dim SetCachePolicy As Cache.RequestCachePolicy = New Cache.RequestCachePolicy(Cache.RequestCacheLevel.NoCacheNoStore)
                client.CachePolicy = SetCachePolicy

                Dim params As New Specialized.NameValueCollection From {{"report", StringBody}}

                Dim bytes = client.UploadValues(stringUrl, "POST", params)
                Dim StringResponse As String = Encoding.UTF8.GetString(bytes)

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
        MessageBox.Show(StringError, "FormException.SendErrorReport", MessageBoxButtons.OK, MessageBoxIcon.Error)
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