'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  Program.vb
'  Created by David S on 20.03.2016
'  Updated on 14.07.2019 - DS (Update Main())

Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Imports Core.WinApi
Imports Core.Fonts
Imports Xiret.Base.Helpers
Imports Xiret.Base.Support

<Module: CodeName("EFA11")>
<Module: TestedBy("K4onashi, Carlos Detweiller, ItielMaN")>
<Module: ProductChannel("RC")> 
<Module: ProductVersion("2.0.0")>
<Module: BuiltBy("K4onashi - 06.07.2019")>
<Module: TableFlip("(╯°□°）╯︵ ┻━┻")>

Public Class Program

    <STAThread()>
    Public Shared Sub Main(ByVal Args() As String)

        'Set DPI awarenesss
        SetProcessDPIAwareA.SetProcessDPIAware()

        'Signature verification
        Dim IsSigEnforced As Boolean = False
        Dim IsSigVerified As Boolean = StrongNameSignatureVerificationA.StrongNameSignatureVerificationEx(Application.ExecutablePath, False, IsSigEnforced)

        'Start signature check
        If IsSigEnforced And IsSigVerified Then 'Valid
            'Check missing Vista font
            If OSHWinIsVista() Then
                If Not File.Exists(FontInstaller.FileFont) Then
                    FontInstaller.InstallFont("Segoe UI Semibold (TrueType)", "seguisb.ttf")
                    MessageBox.Show("SegoeUI Semibold TTF installed.")
                End If
            End If
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            'SettingsCore
            CreateUpdaterSettings()
            CheckSettings()
            Dim Run As New ApplicationSupport(FormMain, Args)
        Else
            MessageBox.Show("Invalid signature.", "Application Support", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If

    End Sub

End Class

Namespace Base.Support

    Public Class ApplicationSupport
        Inherits WindowsFormsApplicationBase

        'Constructor
        Public Sub New(ByVal MainForm As Form, ByVal Args() As String)

            MyBase.MainForm = FormMain
            EnableVisualStyles = True
            ShutdownStyle = ShutdownMode.AfterMainFormCloses
            IsSingleInstance = True
            Run(Args)

        End Sub

#Region "Application Startup"

        Private Sub ApplicationSupport_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            Dim FE As New FormEnvironment
            AddHandler FE.FormClosed, AddressOf Wait

            If (OSHKernelVersion.ProductMajorPart < 6) OrElse (OSHWinIsServer()) Then : FE.ShowDialog() : End If 'Unsupported os version

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
            If (BoolCreateFilepath) Then
                CreateUpdaterSettings()
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
                .ShowDialog()
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



