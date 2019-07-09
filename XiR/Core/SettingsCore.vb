'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  SettingsCore.vb
'  Created by David S on 20.03.2016
'  Updated on 06.07.2019 - DS (HardwareModeInt)

Imports System.IO
Imports System.Xml


Module SettingsCore

    'Files
    Public ReadOnly FileAppdataSettings As String = Path.Combine(DirAppData, "settings.xir")
    Public ReadOnly FileWorkingSettings As String = Path.Combine(DirAppPath, "settings.xir")

    'Integers
    Public SettingsAutoHardwareInt As Integer = 0
    Public SettingsHardwareModeInt As Integer = 0
    Public SettingsAssModeInt As Integer = 0
    Public SettingsThemeInt As Integer = 0
    Public SettingsThemeApplyToBorderInt As Integer = 0

    'Bool
    Public BoolWorkingDirectory As Boolean = False
    Public BoolShowHardware As Boolean = False
    Public BoolHardwareApiMode As Boolean = False
    Public BoolVerbose As Boolean = False
    Public BoolThemeApplyBorder As Boolean = False

    'Colours
    Public GlobalThemeColor As Color = Color.FromArgb(120, 180, 0)

#Region "Check Settings"

    Public Sub CheckSettings()

        If (File.Exists(FileWorkingSettings)) Then
            BoolWorkingDirectory = True
            LoadSettings()
        Else
            If (File.Exists(FileAppdataSettings)) Then
                BoolWorkingDirectory = False
                LoadSettings()
            Else
                BoolWorkingDirectory = False
                CreateSettings()
            End If
        End If

    End Sub

#End Region
#Region "Load Settings"

    Public Sub LoadSettings()

        Try

            Dim xmlDoc As XmlDocument = New XmlDocument
            Dim vNode As XmlNode

            If (BoolWorkingDirectory) Then
                xmlDoc.Load(FileWorkingSettings)
            Else
                xmlDoc.Load(FileAppdataSettings)
            End If


            vNode = xmlDoc.SelectSingleNode("root")

            Try
                SettingsAutoHardwareInt = CInt(vNode("ShowHardwareOnStartup").InnerText)
                Select Case SettingsAutoHardwareInt
                    Case 0
                        BoolShowHardware = False
                    Case 1
                        BoolShowHardware = True
                    Case Else
                        BoolShowHardware = False
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <ShowHardwareOnStartup>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                SettingsHardwareModeInt = CInt(vNode("HardwareMode").InnerText)
                Select Case SettingsHardwareModeInt
                    Case 0
                        BoolHardwareApiMode = False
                    Case 1
                        BoolHardwareApiMode = True
                    Case Else
                        BoolHardwareApiMode = False
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <HardwareMode>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                SettingsAssModeInt = CInt(vNode("AssMode").InnerText)
                Select Case SettingsAssModeInt
                    Case 0
                        BoolVerbose = False
                    Case 1
                        BoolVerbose = True
                    Case Else
                        BoolVerbose = False
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <AssMode>. (lol)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            Try
                SettingsThemeInt = CInt(vNode("Theme").InnerText)
                Select Case SettingsThemeInt
                    Case 0
                        GlobalThemeColor = Color.FromArgb(120, 180, 0)
                    Case 1
                        GlobalThemeColor = Color.FromArgb(80, 166, 252)
                    Case 2
                        GlobalThemeColor = Color.FromArgb(26, 188, 156)
                    Case 3
                        GlobalThemeColor = Color.FromArgb(46, 204, 113)
                    Case 4
                        GlobalThemeColor = Color.FromArgb(198, 111, 226)
                    Case 5
                        GlobalThemeColor = Color.FromArgb(230, 126, 34)
                    Case 6
                        GlobalThemeColor = Color.FromArgb(215, 220, 18)
                    Case 7
                        GlobalThemeColor = Color.FromArgb(224, 76, 60)
                    Case Else
                        GlobalThemeColor = Color.FromArgb(120, 180, 0)
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <Theme>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            Try
                SettingsThemeApplyToBorderInt = CInt(vNode("ThemeApplyToBorder").InnerText)
                Select Case SettingsThemeApplyToBorderInt
                    Case 0
                        BoolThemeApplyBorder = False
                    Case 1
                        BoolThemeApplyBorder = True
                    Case Else
                        BoolThemeApplyBorder = False
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <ThemeApplyToBorder>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            Dim dr As DialogResult = MessageBox.Show("The settings file is malformed or corrupt. Should the file be deleted?" & vbCrLf & vbCrLf & ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If dr = DialogResult.Yes Then
                If (File.Exists(FileAppdataSettings)) Then
                    File.Delete(FileAppdataSettings)
                End If
                Application.Restart()
            End If
        End Try

    End Sub

#End Region
#Region "Create Settings"
    Public Sub CreateSettings()

        If Not Directory.Exists(DirAppData) Then
            Directory.CreateDirectory(DirAppData)
        End If

        Dim XWrite As XmlTextWriter
        If BoolWorkingDirectory Then
            XWrite = New XmlTextWriter(FileWorkingSettings, Nothing)
        Else
            XWrite = New XmlTextWriter(FileAppdataSettings, Nothing)
        End If

        XWrite.Formatting = Formatting.Indented
        XWrite.Indentation = 4

        xwrite.WriteStartDocument()
        xwrite.WriteComment("Xiret Settings File")
        xwrite.WriteStartElement("root")
        XWrite.WriteComment("0:Off 1:On")
        XWrite.WriteElementString("ShowHardwareOnStartup", CStr(SettingsAutoHardwareInt))
        XWrite.WriteComment("0:XML 1:API")
        XWrite.WriteElementString("HardwareMode", CStr(SettingsHardwareModeInt))
        XWrite.WriteComment("0:Normal 1:Verbose")
        xwrite.WriteElementString("AssMode", CStr(SettingsAssModeInt))
        XWrite.WriteComment("ThemeInteger 0-7")
        xwrite.WriteElementString("Theme", CStr(SettingsThemeInt))
        xwrite.WriteComment("0:Disable 1:Enable")
        xwrite.WriteElementString("ThemeApplyToBorder", CStr(SettingsThemeApplyToBorderInt))
        xwrite.WriteEndElement()
        xwrite.WriteEndDocument()
        xwrite.Close()

        Exit Sub

    End Sub
    Public Sub CreateUpdaterSettings()

        If Not Directory.Exists(DirAppData) Then
            Directory.CreateDirectory(DirAppData)
        End If

        Dim xwrite As New XmlTextWriter(DirAppData & "\paths.xml", Nothing)

        xwrite.WriteStartDocument()
        xwrite.WriteStartElement("root")
        xwrite.WriteElementString("Path", FileAppImage) 'Write path for updater
        xwrite.WriteEndElement()
        xwrite.WriteEndDocument()
        xwrite.Close()

        Exit Sub

    End Sub

#End Region

End Module
