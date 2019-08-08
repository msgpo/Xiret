'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret project
'  WinsatReader.vb
'  Created by David S on 20.03.2016
'  Updated on 01.08.2019 - DS (Hardware cleanup)
'  Updated on 07.08.2019 - DS (Gain GetLatestFormalXML())

Imports System.IO
Imports System.Xml

Imports Core.Converters
Imports Core.Helpers

Namespace Winsat

    Friend Class WSR

#Region "WinSPR"

        Friend Shared Sub GetWinsatSPR()

            Try
                If CDbl(WinsatApi.GetWinsatBaseScore()) = 0 Then
                    Strings.StringBaseScore = "0"
                    Strings.StringProcessorScore = "Unrated"
                    Strings.StringMemoryScore = "Unrated"
                    Strings.StringGraphicsScore = "Unrated"
                    Strings.StringGamingScore = "Unrated"
                    Strings.StringDiskScore = "Unrated"
                    FormMain.UpdateControls()
                Else
                    Try
                        Strings.StringBaseScore = WinsatApi.GetWinsatBaseScore()
                        'Append if length is 1
                        If Strings.StringBaseScore.Length = 1 Then
                            Strings.StringBaseScore = Strings.StringBaseScore & ".0"
                        Else
                            'Remove extra char
                            If Strings.StringBaseScore.Length > 3 Then
                                Strings.StringBaseScore = Strings.StringBaseScore.Substring(0, Strings.StringBaseScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.StringBaseScore = "..."
                    End Try

                    '// Processor Score
                    Try
                        Strings.StringProcessorScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, InfoType.Score)
                        'Append if length is 1
                        If Strings.StringProcessorScore.Length = 1 Then
                            Strings.StringProcessorScore = Strings.StringProcessorScore & ".0"
                        Else
                            'Remove extra char
                            If Strings.StringProcessorScore.Length > 3 Then
                                Strings.StringProcessorScore = Strings.StringProcessorScore.Substring(0, Strings.StringProcessorScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.StringProcessorScore = "..."
                    End Try

                    '// Memory Score
                    Try
                        Strings.StringMemoryScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, InfoType.Score)
                        'Append if length is 1
                        If Strings.StringMemoryScore.Length = 1 Then
                            Strings.StringMemoryScore = Strings.StringMemoryScore & ".0"
                        Else
                            'Remove extra char
                            If Strings.StringMemoryScore.Length > 3 Then
                                Strings.StringMemoryScore = Strings.StringMemoryScore.Substring(0, Strings.StringMemoryScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.StringMemoryScore = "..."
                    End Try

                    '// Graphics Score
                    Try
                        Strings.StringGraphicsScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, InfoType.Score)
                        'Append if length is 1
                        If Strings.StringGraphicsScore.Length = 1 Then
                            Strings.StringGraphicsScore = Strings.StringGraphicsScore & ".0"
                        Else
                            'Remove extra char
                            If Strings.StringGraphicsScore.Length > 3 Then
                                Strings.StringGraphicsScore = Strings.StringGraphicsScore.Substring(0, Strings.StringGraphicsScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.StringGraphicsScore = "..."
                    End Try

                    '// Gaming Graphics Score
                    Try
                        Strings.StringGamingScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, InfoType.Score)
                        'Append if length is 1
                        If Strings.StringGamingScore.Length = 1 Then
                            Strings.StringGamingScore = Strings.StringGamingScore & ".0"
                        Else
                            'Remove extra char
                            If Strings.StringGamingScore.Length > 3 Then
                                Strings.StringGamingScore = Strings.StringGamingScore.Substring(0, Strings.StringGamingScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.StringGamingScore = "..."
                    End Try

                    '// Disk Score
                    Try
                        Strings.StringDiskScore = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, InfoType.Score)
                        'Append is length is 1
                        If Strings.StringDiskScore.Length = 1 Then
                            Strings.StringDiskScore = Strings.StringDiskScore & ".0"
                        Else
                            'Remove extra char
                            If Strings.StringDiskScore.Length > 3 Then
                                Strings.StringDiskScore = Strings.StringDiskScore.Substring(0, Strings.StringDiskScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.StringDiskScore = "..."
                    End Try

                    If Settings.UseApiHardware = 1 Then
                        ReadAPIHardware()
                    Else
                        ReadXMLHardware()
                    End If

                End If

            Catch ex As Exception
                Strings.StringBaseScore = "0"
                Strings.StringProcessorScore = "Unrated"
                Strings.StringMemoryScore = "Unrated"
                Strings.StringGraphicsScore = "Unrated"
                Strings.StringGamingScore = "Unrated"
                Strings.StringDiskScore = "Unrated"
                FormMain.lbState.Text = "Your scores could not be read"
                FormMain.UpdateControls()
                MessageBox.Show(ex.ToString, "WSR.GetWinsatSPR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

#End Region
#Region "Hardware (XML)"

        Friend Shared Sub ReadXMLHardware()

            If WinsatApi.GetAssessmentValidityInt() = 3 Then 'Block attempts to load hardware on unreated systems
                Exit Sub
            Else
                Strings.StringProcessorHW = XMLGetProcessor()
                Strings.StringMemoryHW = XMLGetMemoryType() & " " & XMLGetMemorySize()
                Strings.StringGraphicsHW = XMLGetGraphicsName()
                Strings.StringGamingHW = XMLGetGraphicsSize()
                Strings.StringDiskHW = XMLGetDisk()
            End If

        End Sub

        Private Shared Function XMLGetProcessor() As String

            Try
                Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Processor/Instance", "ProcessorName")
                If Str = "" Then
                    Return "Unknown Processor"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function XMLGetMemoryType() As String

            Try
                Dim Str As String = MemoryConverter.ConvertMemoryInt(GetWinsatXMLInfo("WinSAT/SystemConfig/Memory/DIMM", "MemoryType"))
                If Str = "" Then
                    Return "Unknown Memory"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function XMLGetMemorySize() As String

            Try
                Dim Str As String = SizeConverter.ConvertBigSize(CDbl(GetWinsatXMLInfo("WinSAT/SystemConfig/Memory/TotalPhysical", "Bytes")))
                If Str = "" Then
                    Return "Unknown Size"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function XMLGetGraphicsName() As String

            Try
                Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Graphics", "AdapterDescription")
                If Str = "" Then
                    Return "Unknown Adapter"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function XMLGetGraphicsSize() As String

            Try
                Dim Str As String = SizeConverter.BytesToMBSquared(CDbl(GetWinsatXMLInfo("WinSAT/SystemConfig/Graphics", "DedicatedVideoMemory"))) & " MB total VRAM"
                If Str = "" Then
                    Return "Unknown Adapter Size"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function XMLGetDisk() As String

            Try
                Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Disk/SystemDisk", "Model")
                If Str = "" Then
                    Return "Unknown Disk"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

#End Region
#Region "Hardware (API)"

        Friend Shared Sub ReadAPIHardware()

            If WinsatApi.GetAssessmentValidityInt() = 3 Then 'Block attempts to load hardware on unreated systems
                Exit Sub
            Else
                Strings.StringProcessorHW = APIGetProcessor()
                Strings.StringMemoryHW = APIGetMemorySize()
                Strings.StringGraphicsHW = APIGetGraphicsName()
                Strings.StringGamingHW = APIGetGraphicsSize()
                Strings.StringDiskHW = APIGetDisk()
            End If

        End Sub

        Private Shared Function APIGetProcessor() As String

            Try
                Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, InfoType.Description)
                If Str = "" Then
                    Return "Unknown Processor"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function APIGetMemorySize() As String

            Try
                Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, InfoType.Description)
                If Str = "" Then
                    Return "Unknown Memory"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function APIGetGraphicsName() As String

            Try
                Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, InfoType.Description)
                If Str = "" Then
                    Return "Unknown Adapter"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function APIGetGraphicsSize() As String

            Try
                Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, InfoType.Description)
                If Str = "" Then
                    Return "Unknown Shared Memory"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

        Private Shared Function APIGetDisk() As String

            Try
                Dim Str As String = WinsatApi.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, InfoType.Description)
                If Str = "" Then
                    Return "Unknown Disk"
                Else
                    Return Str
                End If
            Catch
                Return "Error"
            End Try

        End Function

#End Region
#Region "Read XML"

        Friend Shared Function GetWinsatXMLInfo(ByVal Node As String, ByVal Inner As String) As String

            '// This needs enhancement

            Try
                Dim Document As New XmlDocument
                Dim XNode As XmlNode
                If Not GetLatestFormalXML() = Files.FileLatestFormalXML Then
                    Document.Load(GetLatestFormalXML())
                Else
                    Document.Load(Files.FileLatestFormalXML)
                End If
                XNode = Document.SelectSingleNode(Node)
                Return XNode(Inner).InnerText
            Catch ex As Exception
                Return ""
            End Try

        End Function

#End Region
#Region "Get Formal"

        Friend Shared Function GetLatestFormalXML() As String

            Dim Watch As New Stopwatch()
            Dim NewestFile As FileInfo = Nothing
            Dim Dir As New DirectoryInfo(Directories.DirWinsatDatastore)

            Watch.Start()

            For Each File In Dir.EnumerateFiles("*Formal*.xml", SearchOption.TopDirectoryOnly)
                If NewestFile Is Nothing OrElse File.LastWriteTime >= NewestFile.LastWriteTime Then
                    NewestFile = File
                End If
            Next

            Watch.Stop()

            If (NewestFile Is Nothing) And OSHelper.IsWinVista() Then 'Vista is a little different, check for one Initial file

                For Each File In Dir.EnumerateFiles("*Initial*.xml", SearchOption.TopDirectoryOnly)
                    If NewestFile Is Nothing OrElse File.LastWriteTime >= NewestFile.LastWriteTime Then
                        NewestFile = File
                    End If
                Next

                If NewestFile Is Nothing Then
                    Files.FileLatestFormalXML = ""
                    Return ""
                Else
                    Files.FileLatestFormalXML = NewestFile.FullName
                    Return NewestFile.FullName
                End If

            Else
                Files.FileLatestFormalXML = NewestFile.FullName
                Return NewestFile.FullName
            End If

        End Function

#End Region

    End Class

End Namespace

