'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  FormMetrics.vb
'  Created by David S on 01.07.2019
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'  This is a work in progress.

Imports System.Linq
Imports System.Xml

Imports Core.Animation

Public Class FormMetrics

    Private Blacklist() As String = {"Signature", "L1Cache", "L2Cache", "L3Cache", "LogicalProcessorInfo"}

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxMain.MouseMove, tlpIcon.MouseMove, lbHead.MouseMove, tlpHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormMetrics_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormMetrics_Load(sender As Object, e As EventArgs) Handles Me.Load

        Opacity = 0

        SetMetricsThemeAccent()

        Log("Choose an option from the menu", "", Color.White, Color.White)

        'GetXMLInfoWinsat("CPUEncryption2Assessment", False)

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormMetrics_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Fade.FadeIn(Me)
    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormMetrics_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Private Sub SetMetricsThemeAccent()

        pnlSplit.BackColor = Settings.ThemeColor

        For Each c As Control In tlpMenu.Controls
            If TypeOf c Is Button Then DirectCast(c, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdProgramInfo_Click(sender As Object, e As EventArgs) Handles CmdProgramInfo.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("ProgramInfo", False) 'CHECK
    End Sub

    Private Sub CmdSysEnviron_Click(sender As Object, e As EventArgs) Handles CmdSysEnviron.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("SystemEnvironment", False) 'CHECK
    End Sub

    Private Sub CmdWinSpr_Click(sender As Object, e As EventArgs) Handles CmdWinSpr.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("WinSPR", False)
    End Sub

    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles cmdMetrics.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("Metrics", False) 'CHECK < This is all we need for Metrics
    End Sub

    Private Sub CmdOS_Click(sender As Object, e As EventArgs) Handles CmdOS.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("OSVersion", False)
        GetXMLInfoWinsat("Platform", False)
    End Sub

    Private Sub CmdSystem_Click(sender As Object, e As EventArgs) Handles CmdSystem.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("MotherBoard", False)
        GetXMLInfoWinsat("BIOS", False)
        GetXMLInfoWinsat("Machine", False)
    End Sub

    Private Sub CmdProcessor_Click(sender As Object, e As EventArgs) Handles CmdProcessor.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("Processor", False)
        GetXMLInfoWinsat("Signature", True)
        GetXMLInfoWinsat("L1Cache", True)
        GetXMLInfoWinsat("L2Cache", True)
        GetXMLInfoWinsat("L3Cache", True)
        GetXMLInfoWinsat("LogicalProcessorInfo", True)
    End Sub

    Private Sub CmdMemory_Click(sender As Object, e As EventArgs) Handles CmdMemory.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("Memory", False)
    End Sub

    Private Sub CmdGraphics_Click(sender As Object, e As EventArgs) Handles CmdGraphics.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("Graphics", False)
        GetXMLInfoWinsat("Monitors", False)
    End Sub

    Private Sub CmdDisk_Click(sender As Object, e As EventArgs) Handles CmdDisk.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("SystemDisk", False) 'Iffy when using just 'Disk'
    End Sub

    Private Sub CmdDwm_Click(sender As Object, e As EventArgs) Handles CmdDwm.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("DWMAssessment", False)
    End Sub

    Private Sub CmdD3D_Click(sender As Object, e As EventArgs) Handles CmdD3D.Click
        rtbInfo.Text = ""
        GetXMLInfoWinsat("D3DAssessment", False)
    End Sub

#End Region

#Region "Routines"

    Private Sub GetXMLInfoWinsat(ByVal LookIn As String, IsInnerNode As Boolean)

        If IsInnerNode Then
            Log("Output from " & LookIn, "", Color.MediumOrchid, Color.White, FontStyle.Bold)
        Else
            Log("> " & LookIn, "", Color.LightSalmon, Color.White, FontStyle.Bold)
        End If

        rtbInfo.AppendText(vbCrLf)

        Dim xmlDoc As New XmlDocument
        Dim MainNodeList As XmlNodeList
        xmlDoc.Load(Files.FileLatestFormalXML)

        MainNodeList = xmlDoc.GetElementsByTagName(LookIn)
        Dim Attribs As String = ""

        For Each MainNode As XmlNode In MainNodeList
            For Each BaseNode As XmlNode In MainNode
                If BaseNode.Attributes IsNot Nothing Then
                    For Each atr As XmlAttribute In BaseNode.Attributes
                        Attribs += atr.Name & ": " & atr.Value & " "
                    Next
                End If

                Log(" " & BaseNode.Name & " ", Attribs, Color.LightSkyBlue, Color.FromArgb(250, 236, 133))
                Attribs = ""

                For Each Node As XmlNode In BaseNode

                    If Not Blacklist.Any(Function(Str) Node.Name.IndexOf(Str, StringComparison.CurrentCultureIgnoreCase) >= 0) Then 'Ignore blacklisted nodes

                        If Not Node.InnerText = "" Or Node.InnerXml = "" Then
                            'Log("  - " & Node.Name & ": ", Node.InnerText, Color.LightCoral, Color.White)
                            Log("  - " & Node.Name.Replace("#cdata-section", "CData").Replace("#text", "Text") & ": ", CType(IIf(Node.InnerText = "", "No Data", Node.InnerText), String), Color.LightSeaGreen, Color.White)
                        Else
                            Log("  - " & Node.Name & ": ", "No Data", Color.LightCoral, Color.Tomato)
                        End If
                    Else
                        Log("  - " & Node.Name & ": ", "See below data", Color.MediumOrchid, Color.White)
                    End If
                Next
                rtbInfo.AppendText(vbCrLf)
            Next
        Next

        xmlDoc = Nothing
        MainNodeList = Nothing

        rtbInfo.SelectionStart = 0
        rtbInfo.ScrollToCaret()

    End Sub

    Private Sub InnerFormat(XMLString As String)

        Try
            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(XMLString)


            For Each Node As XmlNode In xmlDoc

                If Not Node.InnerText = "" Or Node.InnerXml = "" Then
                    If Node.HasChildNodes Then
                        Log("  - " & Node.Name & ": ", Node.InnerText, Color.LightSeaGreen, Color.White)
                    Else
                        Log("  - " & Node.Name.Replace("#cdata-section", "CData").Replace("#text", "Text") & ": ", Node.InnerText, Color.LightCoral, Color.White)
                    End If
                Else
                    Log("  - " & Node.Name & ": ", "No Data", Color.LightCoral, Color.Tomato)
                End If
            Next
        Catch ex As Exception

        End Try


    End Sub

#End Region

#Region "Logger"

    Private Sub Log(ByVal StringNode As String, ByVal StringData As String, ByVal StringNodeColor As Color, StringDataColor As Color, Optional Style As FontStyle = FontStyle.Regular)

        Dim logTypeText As String = Nothing

        logTypeText = StringNode

        On Error Resume Next

        rtbInfo.AppendText(logTypeText)
        rtbInfo.Select(rtbInfo.TextLength - logTypeText.Length, logTypeText.Length)
        rtbInfo.SelectionColor = StringNodeColor
        rtbInfo.SelectionFont = New Font("Consolas", 9, Style)
        rtbInfo.Select(rtbInfo.TextLength, StringData.Length)
        rtbInfo.SelectionColor = StringDataColor
        rtbInfo.AppendText(StringData)
        rtbInfo.AppendText(vbCrLf)
        rtbInfo.ScrollToCaret()

    End Sub

#End Region

End Class