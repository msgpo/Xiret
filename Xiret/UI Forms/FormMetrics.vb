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

Imports System.Linq
Imports System.Xml

Imports Xiret.Core.Animation

Public Class FormMetrics

    Private ReadOnly Blacklist() As String = {"Signature", "L1Cache", "L2Cache", "L3Cache", "LogicalProcessorInfo"}

#Region "Ctor"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Opacity = 0
        SetMetricsThemeAccent()
    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove, TlpHead.MouseMove

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
        GetXMLInfoWinsat("ProgramInfo", False)
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

        PanSplit.BackColor = Settings.ThemeColor

        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.ThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdProgramInfo_Click(sender As Object, e As EventArgs) Handles CmdProgramInfo.Click
        Cls()
        GetXMLInfoWinsat("ProgramInfo", False)
    End Sub

    Private Sub CmdSysEnviron_Click(sender As Object, e As EventArgs) Handles CmdSysEnviron.Click
        Cls()
        GetXMLInfoWinsat("SystemEnvironment", False)
    End Sub

    Private Sub CmdWinSpr_Click(sender As Object, e As EventArgs) Handles CmdWinSpr.Click
        Cls()
        GetXMLInfoWinsat("WinSPR", False)
    End Sub

    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles CmdMetrics.Click
        Cls()
        GetXMLInfoWinsat("Metrics", False) 'CHECK < This is all we need for Metrics
    End Sub

    Private Sub CmdOS_Click(sender As Object, e As EventArgs) Handles CmdOS.Click
        Cls()
        GetXMLInfoWinsat("OSVersion", False)
        GetXMLInfoWinsat("Platform", False)
    End Sub

    Private Sub CmdSystem_Click(sender As Object, e As EventArgs) Handles CmdSystem.Click
        Cls()
        GetXMLInfoWinsat("MotherBoard", False)
        GetXMLInfoWinsat("BIOS", False)
        GetXMLInfoWinsat("Machine", False)
    End Sub

    Private Sub CmdProcessor_Click(sender As Object, e As EventArgs) Handles CmdProcessor.Click
        Cls()
        GetXMLInfoWinsat("Processor", False)
        GetXMLInfoWinsat("Signature", True)
        GetXMLInfoWinsat("L1Cache", True)
        GetXMLInfoWinsat("L2Cache", True)
        GetXMLInfoWinsat("L3Cache", True)
        GetXMLInfoWinsat("LogicalProcessorInfo", True)
    End Sub

    Private Sub CmdMemory_Click(sender As Object, e As EventArgs) Handles CmdMemory.Click
        Cls()
        GetXMLInfoWinsat("Memory", False)
    End Sub

    Private Sub CmdGraphics_Click(sender As Object, e As EventArgs) Handles CmdGraphics.Click
        Cls()
        GetXMLInfoWinsat("Graphics", False)
        GetXMLInfoWinsat("Monitors", False)
    End Sub

    Private Sub CmdDisk_Click(sender As Object, e As EventArgs) Handles CmdDisk.Click
        Cls()
        GetXMLInfoWinsat("SystemDisk", False) 'Iffy when using just 'Disk' - make it SystemDisk.
    End Sub

    Private Sub CmdDwm_Click(sender As Object, e As EventArgs) Handles CmdDwm.Click
        Cls()
        GetXMLInfoWinsat("DWMAssessment", False)
    End Sub

    Private Sub CmdD3D_Click(sender As Object, e As EventArgs) Handles CmdD3D.Click
        Cls()
        GetXMLInfoWinsat("D3DAssessment", False)
    End Sub

#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxMain_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "Routines"

    Private Sub GetXMLInfoWinsat(ByVal LookIn As String, IsInnerNode As Boolean)

        If IsInnerNode Then
            Log("Output from " & LookIn, "", Color.MediumOrchid, Color.White, FontStyle.Bold)
        Else
            Log("> " & LookIn, "", Color.LightSalmon, Color.White, FontStyle.Bold)
        End If

        RtbData.AppendText(vbCrLf)

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
                            Log("  - " & Node.Name.Replace("#cdata-section", "CData").Replace("#text", "Text") & ": ", CType(IIf(Node.InnerText = "", "No Data", Node.InnerText), String), Color.LightSeaGreen, Color.White)
                        Else
                            Log("  - " & Node.Name & ": ", "No Data", Color.LightCoral, Color.Tomato)
                        End If
                    Else
                        Log("  - " & Node.Name & ": ", "See below data", Color.MediumOrchid, Color.White)
                    End If
                Next
                RtbData.AppendText(vbCrLf)
            Next
        Next

        xmlDoc = Nothing
        MainNodeList = Nothing

        RtbData.SelectionStart = 0
        RtbData.ScrollToCaret()

    End Sub
    Private Sub Cls()
        RtbData.Text = ""
    End Sub
#End Region

#Region "Logger"

    Private Sub Log(ByVal StringNode As String, ByVal StringData As String, ByVal StringNodeColor As Color, StringDataColor As Color, Optional Style As FontStyle = FontStyle.Regular)

        Dim logTypeText As String = Nothing

        logTypeText = StringNode

        On Error Resume Next

        RtbData.AppendText(logTypeText)
        RtbData.Select(RtbData.TextLength - logTypeText.Length, logTypeText.Length)
        RtbData.SelectionColor = StringNodeColor
        RtbData.SelectionFont = New Font("Consolas", 9, Style)
        RtbData.Select(RtbData.TextLength, StringData.Length)
        RtbData.SelectionColor = StringDataColor
        RtbData.AppendText(StringData)
        RtbData.AppendText(vbCrLf)
        RtbData.ScrollToCaret()

    End Sub

#End Region

End Class