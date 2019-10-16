'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  Settings.vb
'  Created by David S on 20.03.2016
'  Updated on 09.07.2019 - DS (Implement custom Imgur Api Key)
'  Updated on 31.07.2019 - DS (Cleanup variables)
'  Updated on 07.08.2019 - DS (Gain SetBorderColor(), update variables)

Imports System.IO
Imports System.Xml

Imports Xiret.Core.Helpers


Friend Class Settings

#Region "Variables"

    Friend Shared ReadOnly AppdataFile As String = Path.Combine(Directories.DirAppData, "settings.xir")
    Friend Shared ReadOnly WorkingDirFile As String = Path.Combine(Directories.DirAppPath, "settings.xir")

    Friend Shared ShowHardwareOnStartup As Integer = 0
    Friend Shared UseApiHardware As Integer = 0
    Friend Shared UseVerboseMode As Integer = 0
    Friend Shared ThemeInt As Integer = 0
    Friend Shared ApplyThemeColorToBorder As Integer = 0
    Friend Shared UseCustomImgurApiKey As Integer = 0

    Friend Shared BoolWorkingDirectory As Boolean = False

    Friend Shared StringUserImgurClientId As String = ""

    Friend Shared ThemeColor As Color = Color.FromArgb(120, 180, 0)

#End Region

#Region "Check Settings"

    Friend Shared Sub CheckSettings()

        If File.Exists(AppdataFile) Then
            BoolWorkingDirectory = False
            LoadSettings()
        Else
            If File.Exists(WorkingDirFile) Then
                BoolWorkingDirectory = True
                LoadSettings()
            Else
                BoolWorkingDirectory = False
                CreateSettings()
            End If
        End If

    End Sub

#End Region
#Region "Load Settings"

    Friend Shared Sub LoadSettings()

        Try

            Dim XmlDoc As XmlDocument = New XmlDocument
            Dim XmlNod As XmlNode

            If BoolWorkingDirectory Then
                XmlDoc.Load(WorkingDirFile)
            Else
                XmlDoc.Load(AppdataFile)
            End If

            XmlNod = XmlDoc.SelectSingleNode("root")

            Try
                ShowHardwareOnStartup = CInt(XmlNod("ShowHardwareOnStartup").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <ShowHardwareOnStartup>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                UseApiHardware = CInt(XmlNod("UseApiHardware").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <UseApiHardware>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                UseVerboseMode = CInt(XmlNod("UseVerboseMode").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <UseVerboseMode>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                ThemeInt = CInt(XmlNod("Theme").InnerText)
                Select Case ThemeInt
                    Case 0
                        ThemeColor = Color.FromArgb(120, 190, 0)
                    Case 1
                        ThemeColor = Color.FromArgb(0, 191, 255)
                    Case 2
                        ThemeColor = Color.FromArgb(0, 255, 181)
                    Case 3
                        ThemeColor = Color.FromArgb(46, 220, 110)
                    Case 4
                        ThemeColor = Color.FromArgb(245, 60, 245)
                    Case 5
                        ThemeColor = Color.FromArgb(255, 105, 180)
                    Case 6
                        ThemeColor = Color.FromArgb(255, 118, 0)
                    Case 7
                        ThemeColor = Color.FromArgb(205, 219, 18)
                    Case 8
                        ThemeColor = Color.FromArgb(255, 50, 50)
                    Case Else
                        ThemeColor = Color.FromArgb(120, 180, 0)
                End Select
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <Theme>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                ApplyThemeColorToBorder = CInt(XmlNod("ApplyThemeColorToBorder").InnerText)
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <ApplyThemeColorToBorder>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                UseCustomImgurApiKey = CInt(XmlNod("UseCustomImgurApiKey").InnerText)
                If UseCustomImgurApiKey = 1 Then
                    If XmlNod("ImgurAPIClientIdString").InnerText IsNot Nothing Then
                        StringUserImgurClientId = XmlNod("ImgurAPIClientIdString").InnerText
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Settings node malformation in <UseCustomImgurApiKey>.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            Dim dr As DialogResult = MessageBox.Show("The settings file is malformed or corrupt. Should the file be deleted?" & vbCrLf & vbCrLf & ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If dr = DialogResult.Yes Then
                If File.Exists(AppdataFile) Then
                    File.Delete(AppdataFile)
                End If
                Application.Restart()
            End If
        End Try

    End Sub

#End Region
#Region "Create Settings"
    Friend Shared Sub CreateSettings()

        Dim Writer As XmlTextWriter

        If Not Directory.Exists(Directories.DirAppData) Then
            Directory.CreateDirectory(Directories.DirAppData)
        End If

        If BoolWorkingDirectory Then
            Writer = New XmlTextWriter(WorkingDirFile, Nothing)
        Else
            Writer = New XmlTextWriter(AppdataFile, Nothing)
        End If

        Writer.Formatting = Formatting.Indented
        Writer.Indentation = 4

        Writer.WriteStartDocument()
        Writer.WriteComment("Xiret Settings File")
        Writer.WriteStartElement("root")
        Writer.WriteComment("0:Off 1:On")
        Writer.WriteElementString("ShowHardwareOnStartup", CStr(ShowHardwareOnStartup))
        Writer.WriteComment("0:XML 1:API")
        Writer.WriteElementString("UseApiHardware", CStr(UseApiHardware))
        Writer.WriteComment("0:Normal 1:Verbose")
        Writer.WriteElementString("UseVerboseMode", CStr(UseVerboseMode))
        Writer.WriteComment("ThemeInteger 0-8")
        Writer.WriteElementString("Theme", CStr(ThemeInt))
        Writer.WriteComment("0:Disable 1:Enable")
        Writer.WriteElementString("ApplyThemeColorToBorder", CStr(ApplyThemeColorToBorder))
        Writer.WriteComment("0:Disable 1:Enable")
        Writer.WriteElementString("UseCustomImgurApiKey", CStr(UseCustomImgurApiKey))
        Writer.WriteComment("User defined Imgur API Client ID")
        Writer.WriteElementString("ImgurAPIClientIdString", StringUserImgurClientId)
        Writer.WriteEndElement()
        Writer.WriteEndDocument()
        Writer.Close()

        Exit Sub

    End Sub
    Friend Shared Sub CreateUpdaterSettings()

        If Not Directory.Exists(Directories.DirAppData) Then
            Directory.CreateDirectory(Directories.DirAppData)
        End If

        Dim xwriter As New XmlTextWriter(Path.Combine(Directories.DirAppData, "paths.xir"), Nothing) With {
            .Formatting = Formatting.Indented,
            .Indentation = 4
        }

        xwriter.WriteStartDocument()
        xwriter.WriteStartElement("root")
        xwriter.WriteComment("Application directory")
        xwriter.WriteElementString("Directory", DirectoryHelper.GetApplicationPath)
        xwriter.WriteComment("Application path")
        xwriter.WriteElementString("Executable", FileHelper.GetApplicationImage)
        xwriter.WriteEndElement()
        xwriter.WriteEndDocument()
        xwriter.Close()

        Exit Sub

    End Sub

#End Region

#Region "Routines"

    Friend Shared Sub SetBorderColor(ByVal Form As Form)

        'This was created as applying the raw theme accent to the border was too 'How you fkn doin?', now it's more subtle.
        'The control passed must inherit SetStyle(ControlStyles.SupportsTransparentBackColor, True) else an error will be thrown.

        'Alpha an be tweaked here, or you could pass a ByVal integer
        'and remove the dimensioned variable 'Alpha'. e.g.
        'Public Sub SetBorderColor(Form As Form, Alpha As Integer) : End Sub

        Dim Alpha As Integer = 180

        Dim R = ThemeColor.R
        Dim G = ThemeColor.G
        Dim B = ThemeColor.B

        If ApplyThemeColorToBorder = 1 Then
            Form.BackColor = Color.FromArgb(Alpha, R, G, B)
        Else
            Form.BackColor = Colors.ColorBorderStandard
        End If

    End Sub

#End Region

End Class
