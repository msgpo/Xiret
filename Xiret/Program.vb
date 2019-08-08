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
'  Updated on 14.07.2019 - DS (Update Main())

Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Imports Core.Fonts
Imports Core.Helpers
Imports Core.WinApi

Imports Xiret.Prog.Support

<Module: CodeName("EFA11")>
<Module: TestedBy("K4onashi, Carlos Detweiller, ItielMaN, MichaelJoy")>
<Module: ProductChannel("RC")>
<Module: ProductVersion("2.0.0")>
<Module: BuiltBy("K4onashi - 29.07.2019")>
<Module: TableFlip(" It's not a bug it's a feature (╯°□°）╯︵ ┻━┻")>

Friend Class Program

    <STAThread()>
    Friend Shared Sub Main(ByVal Args() As String)

        'Set DPI scaling
        SetProcessDPIAwareA.SetProcessDPIAware()

        'Check Hotfix
        '// Moved to thread in FormMain - Caused slow loading time on WIndows 7

        'Signature verification
        Dim IsSigVerified As Boolean = False
        Dim IsSigEnforced As Boolean = StrongNameSignatureVerificationA.StrongNameSignatureVerificationEx(Application.ExecutablePath, False, IsSigVerified)

        'Start signature check
        If IsSigEnforced And IsSigVerified Then 'Valid

            CheckLibraries()

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            'SettingsCore
            Settings.CreateUpdaterSettings()
            Settings.CheckSettings()

            'Check missing Vista font
            If OSHelper.IsWinVista() Then
                If Not File.Exists(FontInstaller.FileFontStatic) Then
                    FormFont.ShowDialog()
                End If
            End If

            Dim DEC25OCT31 As New ApplicationSupport(FormMain, Args)

        Else
            MessageBox.Show("File has been edited. Cannot continue." & vbCrLf & "ISE# " & IsSigEnforced & vbCrLf & "ISV# " & IsSigVerified, "Application Support", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If

    End Sub

#Region "Library Protection"

    Friend Shared Sub CheckLibraries()

        'Plz don hack -- I find u

        Dim CoreDLLChecksum As String = CryptoHelper.GetSha512FromFile(Path.Combine(Directories.DirAppPath, "Core.dll"), True)
        Dim CoreDllExpected As String = "64BC0DA488512554ADBC064E540330E1B8E496BD9A467987BBE19F3ACB45E8E55145DC5F486D34C175745B2D022BC32E385BFACFD65520C5DB7769498CE96102"

        Dim GambolDLLChecksum As String = CryptoHelper.GetSha512FromFile(Path.Combine(Directories.DirAppPath, "Gambol.dll"), True)
        Dim GambolDLLExpected As String = "B007E1670AC5AB0E6F5189A7745F55B24DC0FED23C144E4A9401FC06DFD1C87C7EF5467D486CAFD26B5D6FC0816DB05C73B0F6B788666DE5E889DD25C4B1D474"

        Dim IsCoreDllVerified As Boolean = CoreDLLChecksum = CoreDllExpected
        Dim IsGambolDllVerified As Boolean = GambolDLLChecksum = GambolDLLExpected

        Dim Core As String = CType(IIf(IsCoreDllVerified, "is verified.", "checksum mismatch!"), String)
        Dim Gambol As String = CType(IIf(IsGambolDllVerified, "is verified.", "checksum mismatch!"), String)

        If IsCoreDllVerified And IsGambolDllVerified Then
            Exit Sub
        Else
            Dim DR As DialogResult = MessageBox.Show("One or more DLL files did not pass verification. Unless this is intentional, it's highly recommended not to use the application." _
                                                     & vbCrLf & vbCrLf & "Core.dll " & Core & vbCrLf & "Gambol.dll " & Gambol & vbCrLf & vbCrLf & "Click OK to continue. Click cancel to exit.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If DR = DialogResult.Cancel Then
                Environment.Exit(0)
            End If

        End If

    End Sub

End Class

#End Region

Namespace Prog.Support

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

        Private Sub ApplicationSupport_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            Dim FE As New FormEnvironment
            AddHandler FE.FormClosed, AddressOf Wait

            If (OSHelper.GetKernelVersion.ProductMajorPart < 6) OrElse OSHelper.IsWinServer() Then : FE.ShowDialog() : End If 'Unsupported os version

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

        Public Shared StringStackTrace As String = Nothing
        Public Shared StringException As String = Nothing

        Private Sub ApplicationSupport_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException

            StringStackTrace = e.Exception.StackTrace
            StringException = e.Exception.Message

            Dim ExceptionF As New FormException

            With ExceptionF
                .TopMost = True
                .Show()
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



