'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  Program.vb
'  Created by David S on 20.03.2016
'  Updated on 16.10.2019 - DS (Removed library check)

Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Imports System.Text

Imports Xiret.Main.Support

Imports Xiret.Core.Fonts
Imports Xiret.Core.Helpers
Imports Xiret.Core.WinApi


#Disable Warning IDE0060

<Module: CodeName("EFA11")>
<Module: TestedBy("K4onashi, Carlos Detweiller, ItielMaN")>
<Module: ProductChannel("Release")>
<Module: ProductVersion("2.0.2")>
<Module: BuiltBy("David S aka K4onashi")>
<Module: TableFlip(" It's not a bug it's a feature (╯°□°）╯︵ ┻━┻")>

Friend Class Program

    ' ## PLEASE FILL BEFORE RELEASE ## '
    Friend Shared ReadOnly ProductChannel As String = "Release"
    Friend Shared ReadOnly ProductReleaseDate As String = "22th October 2019"
    Friend Shared XiretBuild As String = "1HL20"

    <STAThread()>
    Friend Shared Sub Main(ByVal Args() As String)

        'Set DPI scaling
        SetProcessDPIAwareA.SetProcessDPIAware()

        'Signature verification
        Dim IsSigVerified As Boolean = False
        Dim IsSigEnforced As Boolean = StrongNameSignatureVerificationA.StrongNameSignatureVerificationEx(Application.ExecutablePath, False, IsSigVerified)

        'Start signature check
        If IsSigEnforced And IsSigVerified Then 'Valid

            CreateAppdataFolder()
            RunLaunchDiags()

            'Framework
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            'Settings
            Settings.CreateUpdaterSettings()
            Settings.CheckSettings()

            'Check fonts
            CheckFonts()

            Dim DEC25OCT31 As New ApplicationSupport(FormMain, Args)

        Else
            MessageBox.Show("File has been edited. Cannot continue." & vbCrLf & "Enforced: " & IsSigEnforced & vbCrLf & "Verified: " & IsSigVerified, "Application Support", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If

    End Sub

#Region "Create Folder(s)"

    Private Shared Sub CreateAppdataFolder()

        Try
            If Not Directory.Exists(Directories.DirAppData) Then
                Directory.CreateDirectory(Directories.DirAppData)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Program.CreateAppdataFolder()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region
#Region "Pre-launch Diagnostics"

    Friend Shared Sub RunLaunchDiags()

        Dim SBuilder As New StringBuilder

        Try
            SBuilder.AppendLine("Pre-launch diagnostics")
            SBuilder.AppendLine()
            SBuilder.AppendLine("Build: " & Application.ProductVersion & " " & XiretBuild)
            SBuilder.AppendLine("OpSys: " & OSHelper.GetWindowsBuildLab)

            If File.Exists(Files.FontSegoeUI) Then
                SBuilder.AppendLine("SegoeUI: Found")
            Else
                SBuilder.AppendLine("SegoeUI: Missing")
            End If

            If File.Exists(Files.FontSegoeUIBold) Then
                SBuilder.AppendLine("SegoeUIBold: Found")
            Else
                SBuilder.AppendLine("SegoeUIBold: Missing")
            End If

            If File.Exists(Files.FontSegoeUISemibold) Then
                SBuilder.AppendLine("SegoeUISemibold: Found")
            Else
                SBuilder.AppendLine("SegoeUISemibold: Missing")
            End If

            If File.Exists(Files.FileWinsat) Then
                SBuilder.AppendLine("WinSAT: Found")
            Else
                SBuilder.AppendLine("WinSAT: Missing")
            End If

            If File.Exists(Files.FileWinsatApi) Then
                SBuilder.AppendLine("WinSAT API: Found")
            Else
                SBuilder.AppendLine("WinSAT API: Missing")
            End If

            If OSHelper.IsElevated Then
                SBuilder.AppendLine("Token: WellKnown")
            Else
                SBuilder.AppendLine("Token: Standard")
            End If

            If OSHelper.GetNetv4Reg Then
                SBuilder.AppendLine("Framework: Found (v4)")
                SBuilder.AppendLine(" - Path: " & OSHelper.GetNetv4Value("InstallPath"))
                SBuilder.AppendLine(" - Release: " & OSHelper.GetNetv4Value("Release"))
                SBuilder.AppendLine(" - Target: " & OSHelper.GetNetv4Value("TargetVersion"))
                SBuilder.AppendLine(" - Version: " & OSHelper.GetNetv4Value("Version"))
            Else
                SBuilder.AppendLine("Framework: Missing")
            End If

            My.Computer.FileSystem.WriteAllText(Directories.DirAppData & "\prelaunch.log", SBuilder.ToString(), False)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Program.RunLaunchDiags()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region
#Region "Font Checker"

    Private Shared Function DoesFontExist(ByVal fontFamilyName As String, ByVal fontStyle As FontStyle) As Boolean

        Try
            Using Fam As FontFamily = New FontFamily(fontFamilyName)
                Return Fam.IsStyleAvailable(fontStyle)
            End Using

        Catch ex As ArgumentException
            Return False
        End Try

    End Function

    Private Shared Sub CheckFonts()

        Dim DidInstall As Boolean = False

        If Not DoesFontExist("Segoe UI", FontStyle.Regular) Then
            Dim i = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeUI, My.Resources.segoeui, "Segoe UI")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If Not DoesFontExist("Segoe UI", FontStyle.Bold) Then
            Dim i = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeUIBold, My.Resources.segoeuib, "Segoe UI Bold")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If Not DoesFontExist("Segoe UI Semibold", FontStyle.Regular) Then
            Dim i = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeUISemibold, My.Resources.seguisb, "Segoe UI Semibold")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If DidInstall Then
            MessageBox.Show("One or more fonts from the Segoe UI family were missing and installed for proper functionality. If application fonts are displayed incorrectly, a system restart may be required." & vbCrLf & vbCrLf & "Please start the application again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Environment.Exit(0)
        End If

    End Sub

#End Region

End Class
Namespace Main.Support

    Friend Class ApplicationSupport
        Inherits WindowsFormsApplicationBase

        'Ctor
        Friend Sub New(ByVal MainForm As Form, ByVal Args() As String)

            MyBase.MainForm = MainForm
            EnableVisualStyles = True
            ShutdownStyle = ShutdownMode.AfterMainFormCloses
            IsSingleInstance = True
            Run(Args)

        End Sub

#Region "Application Startup"
        Private ReadOnly FEnvironment As New FormEnvironment
        Private Sub ApplicationSupport_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            AddHandler FEnvironment.FormClosed, AddressOf Wait

            If (OSHelper.GetKernelVersion.ProductMajorPart < 6) OrElse OSHelper.IsWinServer() Then 'Unsupported os version
                FEnvironment.ShowDialog()
            Else 'Clean your mess
                RemoveHandler FEnvironment.FormClosed, AddressOf Wait
            End If

        End Sub

        Private Sub Wait(sender As Object, e As EventArgs)
            Environment.Exit(0)
        End Sub

#End Region
#Region "Application Next Instance"

        Private Sub ApplicationSupport_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            e.BringToForeground = True
        End Sub

#End Region
#Region "Application Shutdown"

        Private Sub Application_Shutdown(sender As Object, e As System.EventArgs) Handles Me.Shutdown

            'If not purging then write path to appdata
            If Booleans.BoolCreateFilepath Then
                Settings.CreateUpdaterSettings()
            End If

        End Sub

#End Region
#Region "Unhandled Exception"

        Friend Shared StringException As String
        Friend Shared StringExceptionMessage As String


        Private Sub ApplicationSupport_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException

            StringException = e.Exception.Message
            StringExceptionMessage = Convert.ToString(e.Exception)

            Dim FException As New FormException

            With FException
                .ShowDialog()
                .BringToFront()
            End With

            e.ExitApplication = False

        End Sub

#End Region

    End Class

End Namespace

#Region "Attributes"
Friend Class CodeNameAttribute
    Inherits Attribute
    Public Sub New(ByVal StringCodename As String)
    End Sub
End Class
Friend Class TestedBy
    Inherits Attribute
    Public Sub New(ByVal StringTestedBy As String)
    End Sub
End Class
Friend Class ProductChannel
    Inherits Attribute
    Public Sub New(ByVal StringProductChannel As String)
    End Sub
End Class
Friend Class ProductVersion
    Inherits Attribute
    Public Sub New(ByVal StringProductVersion As String)
    End Sub
End Class
Friend Class BuiltBy
    Inherits Attribute
    Public Sub New(ByVal StringBuiltBy As String)
    End Sub
End Class
Friend Class Comment
    Inherits Attribute
    Public Sub New(ByVal StringComment As String)
    End Sub
End Class
Friend Class TableFlip
    Inherits Attribute
    Public Sub New(ByVal StringTableFlipLOL As String)
    End Sub
End Class
#End Region