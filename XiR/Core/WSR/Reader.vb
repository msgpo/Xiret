'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  Reader.vb
'  Created by David S on 20/03/2016
'  Updated on 04.07.2019 - DS (Cleanup imports)

Imports System.Xml

Imports Xiret.Core.Converters
Imports Xiret.Core.WinsatApi
Imports Xiret.Core.Helpers

Namespace Core.WSR

    Module Reader

        Public isRated As Boolean = False

#Region "WSRv1"

        Public Sub GetWinsatSPR()

            Try
                If CDbl(GetWinsatBaseScore()) = 0 Then
                    StringBaseScore = "0"
                    StringProcessorScore = "Unrated"
                    StringMemoryScore = "Unrated"
                    StringGraphicsScore = "Unrated"
                    StringGamingScore = "Unrated"
                    StringDiskScore = "Unrated"
                    isRated = False
                    FormMain.UpdateControls()
                Else
                    Try
                        StringBaseScore = GetWinsatBaseScore()
                        'Append if length is 1
                        If StringBaseScore.Length = 1 Then
                            StringBaseScore = StringBaseScore & ".0"
                        Else
                            'Remove extra char
                            If StringBaseScore.Length > 3 Then
                                StringBaseScore = StringBaseScore.Substring(0, StringBaseScore.Length - 1)
                            End If
                        End If
                    Catch
                        StringBaseScore = "..."
                    End Try

                    '// Processor Score
                    Try
                        StringProcessorScore = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, InfoType.Score)
                        'Append if length is 1
                        If StringProcessorScore.Length = 1 Then
                            StringProcessorScore = StringProcessorScore & ".0"
                        Else
                            'Remove extra char
                            If StringProcessorScore.Length > 3 Then
                                StringProcessorScore = StringProcessorScore.Substring(0, StringProcessorScore.Length - 1)
                            End If
                        End If
                    Catch
                        StringProcessorScore = "..."
                    End Try

                    '// Memory Score
                    Try
                        StringMemoryScore = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, InfoType.Score)
                        'Append if length is 1
                        If StringMemoryScore.Length = 1 Then
                            StringMemoryScore = StringMemoryScore & ".0"
                        Else
                            'Remove extra char
                            If StringMemoryScore.Length > 3 Then
                                StringMemoryScore = StringMemoryScore.Substring(0, StringMemoryScore.Length - 1)
                            End If
                        End If
                    Catch
                        StringMemoryScore = "..."
                    End Try

                    '// Graphics Score
                    Try
                        StringGraphicsScore = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, InfoType.Score)
                        'Append if length is 1
                        If StringGraphicsScore.Length = 1 Then
                            StringGraphicsScore = StringGraphicsScore & ".0"
                        Else
                            'Remove extra char
                            If StringGraphicsScore.Length > 3 Then
                                StringGraphicsScore = StringGraphicsScore.Substring(0, StringGraphicsScore.Length - 1)
                            End If
                        End If
                    Catch
                        StringGraphicsScore = "..."
                    End Try

                    '// Gaming Graphics Score
                    Try
                        StringGamingScore = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, InfoType.Score)
                        'Append if length is 1
                        If StringGamingScore.Length = 1 Then
                            StringGamingScore = StringGamingScore & ".0"
                        Else
                            'Remove extra char
                            If StringGamingScore.Length > 3 Then
                                StringGamingScore = StringGamingScore.Substring(0, StringGamingScore.Length - 1)
                            End If
                        End If
                    Catch
                        StringGamingScore = "..."
                    End Try

                    '// Disk Score
                    Try
                        StringDiskScore = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, InfoType.Score)
                        'Append is length is 1
                        If StringDiskScore.Length = 1 Then
                            StringDiskScore = StringDiskScore & ".0"
                        Else
                            'Remove extra char
                            If StringDiskScore.Length > 3 Then
                                StringDiskScore = StringDiskScore.Substring(0, StringDiskScore.Length - 1)
                            End If
                        End If
                    Catch
                        StringDiskScore = "..."
                    End Try

                    If BoolHardwareApiMode Then : ReadAPIHardware()
                    Else : ReadXMLHardware()
                    End If

                    isRated = True

                End If

            Catch ex As Exception
                StringBaseScore = "0"
                StringProcessorScore = "Unrated"
                StringMemoryScore = "Unrated"
                StringGraphicsScore = "Unrated"
                StringGamingScore = "Unrated"
                StringDiskScore = "Unrated"
                FormMain.lbState.Text = "Your scores could not be read"
                FormMain.UpdateControls()
                MessageBox.Show(ex.ToString, "Core.WSR.GetWinsatSPR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

#End Region
#Region "Hardware"

        Friend Sub ReadXMLHardware()

            Try
                StringProcessorHW = GetWinsatHardwareXMLInfo("WinSAT/SystemConfig/Processor/Instance", "ProcessorName")
            Catch
                StringProcessorHW = "Unknown"
            End Try

            Try
                Dim tmp As String = MemoryTypeConverter(GetWinsatHardwareXMLInfo("WinSAT/SystemConfig/Memory/DIMM", "MemoryType"))
                Dim tmp2 As String = ConvertBigSize(CDbl(GetWinsatHardwareXMLInfo("WinSAT/SystemConfig/Memory/TotalPhysical", "Bytes")))
                StringMemoryHW = tmp & " " & tmp2
            Catch
                StringMemoryHW = "Unknown"
            End Try

            Try
                StringGraphicsHW = GetWinsatHardwareXMLInfo("WinSAT/SystemConfig/Graphics", "AdapterDescription")
            Catch
                StringGraphicsHW = "Unknown"
            End Try

            Try
                StringGamingHW = BytesToMBSquared(CDbl(GetWinsatHardwareXMLInfo("WinSAT/SystemConfig/Graphics", "DedicatedVideoMemory"))) & " MB total VRAM"
            Catch
                StringGamingHW = "Unknown"
            End Try

            Try
                StringDiskHW = GetWinsatHardwareXMLInfo("WinSAT/SystemConfig/Disk/SystemDisk", "Model")
            Catch
                StringDiskHW = "Unknown"
            End Try

        End Sub
        Friend Sub ReadAPIHardware()

            Try
                StringProcessorHW = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, InfoType.Description)
            Catch
                StringProcessorHW = "Unknown"
            End Try

            Try
                StringMemoryHW = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, InfoType.Description)
            Catch
                StringMemoryHW = "Unknown"
            End Try

            Try
                StringGraphicsHW = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, InfoType.Description)
            Catch
                StringGraphicsHW = "Unknown"
            End Try

            Try
                StringGamingHW = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, InfoType.Description)
            Catch
                StringGamingHW = "Unknown"
            End Try

            Try
                StringDiskHW = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, InfoType.Description)
            Catch
                StringDiskHW = "Unknown"
            End Try
        End Sub
#End Region

#Region "Routines"

        Friend Function GetWinsatHardwareXMLInfo(ByVal Node As String, ByVal Inner As String) As String

            Try
                Dim xDoc As New XmlDocument
                Dim xNod As XmlNode
                xDoc.Load(FHGetLatestXML)
                xNod = xDoc.SelectSingleNode(Node)
                Return xNod(Inner).InnerText
            Catch
                Return ""
            End Try

        End Function

#End Region

    End Module

End Namespace

