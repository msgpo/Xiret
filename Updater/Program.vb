'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Updater
'  Program.vb
'  Created by David S on 07.07.2019
'  Updated on 07.07.2019 - DS (Fixed missing properties)

Imports Microsoft.VisualBasic.ApplicationServices

Imports Core.Helpers
Imports Core.WinApi
Imports Updater.Support

<Module: CodeName("EFA11")>
<Module: TestedBy("K4onashi")>
<Module: ProductChannel("RC")>
<Module: ProductVersion("1.0.0")>
<Module: BuiltBy("K4onashi - 07.06.2019")>
<Module: TableFlip("┬─┬﻿ ノ( ゜-゜ノ)")>

Public Class Program

    <STAThread()>
    Public Shared Sub Main(ByVal Args() As String)

        'Set DPI awarenesss
        SetProcessDPIAwareA.SetProcessDPIAware()

        'Signature verification
        Dim IsSigEnforced As Boolean = False
        Dim IsSigVerified As Boolean = StrongNameSignatureVerificationA.StrongNameSignatureVerificationEx(Application.ExecutablePath, False, IsSigEnforced)
        Dim ExecProc As Process = ProcessHelper.GetParentProcess

        'Start signature check
        If IsSigEnforced And IsSigVerified Then 'Valid

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            If Not ExecProc.MainWindowTitle = "Experience Index UI" Then
                MessageBox.Show("This application is not designed to run under '" & ExecProc.ProcessName & "'.", "Program.Main()", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Environment.Exit(0)
            Else
                ExecProc.Kill()
            End If

            Dim Run As New ApplicationSupport(FormMain, Args)

        Else
            MessageBox.Show("File has been edited. Cannot continue." & vbCrLf & "ISE# " & IsSigEnforced & vbCrLf & "ISV# " & IsSigVerified, "Application Support", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If

    End Sub

End Class

Namespace Support

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

#Region "Application Next Instance"
        Private Sub ApplicationSupport_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            e.BringToForeground = True
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



