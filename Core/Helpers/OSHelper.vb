'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  OSHelper.vb
'  Created by David S
'  Updated 07.08.2019 - DS (Cleanup, enhancements)

Imports System.IO
Imports System.Management
Imports Core.WinApi

Namespace Helpers

    Public Class OSHelper

        Private Shared ReadOnly SysDirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
        Public Shared ReadOnly GetKernelVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SysDirPath, "kernel32.dll"))
        Public Shared ReadOnly GetWinsatVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SysDirPath, "winsat.exe"))
        Public Shared ReadOnly GetWinsatApiVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SysDirPath, "winsatapi.dll"))

#Region "OS Bool"

        Public Shared Function IsWinVista() As Boolean

            If (GetKernelVersion.ProductMajorPart = 6) And (GetKernelVersion.ProductMinorPart = 0) Then
                Return True 'Vista, ret true.
            End If

            Return False

        End Function

        Public Shared Function IsWinSeven() As Boolean

            If (GetKernelVersion.ProductMajorPart = 6) And (GetKernelVersion.ProductMinorPart = 1) Then
                Return True 'W7, ret true.
            End If

            Return False

        End Function

        Public Shared Function IsWinTen() As Boolean

            If (GetKernelVersion.ProductMajorPart = 10) And (GetKernelVersion.ProductMinorPart = 0) Then
                Return True 'W10, ret true.
            End If

            Return False

        End Function
        Public Shared Function IsWinServer() As Boolean

            Using Searcher As New ManagementObjectSearcher("SELECT ProductType FROM Win32_OperatingSystem")
                For Each MObject As ManagementObject In Searcher.Get()
                    Dim Int As UInteger = CUInt(MObject.GetPropertyValue("ProductType"))
                    Return Int <> 1 'Server build, ret true.
                Next
            End Using

            Return False 'Ret false, not server.

        End Function
#End Region
#Region "Get Windows Name"

        Public Shared Function GetOSName() As String

            Try
                Return My.Computer.Info.OSFullName.Replace("Microsoft ", "").Replace("(TM)", "™").Replace("Microsoft® ", "")
            Catch
                Return "Unknown"
            End Try

        End Function

#End Region
#Region "Get Windows Architecture"
        'String
        Public Shared Function GetOSBitness(Optional ShortArc As Boolean = False) As String

            Select Case IntPtr.Size
                Case 4 '4 byte address space? We're x86.
                    If ShortArc Then
                        Return "x86"
                    Else
                        Return "32-Bit"
                    End If
                Case 8 '8 byte address space? We're x64.
                    If ShortArc Then
                        Return "x64"
                    Else
                        Return "64-Bit"
                    End If
                Case Else 'Unknown bitness
                    Return "Unknown"
            End Select

        End Function
        'Bool
        Public Shared Function IsOS64Bit() As Boolean

            If IntPtr.Size = 8 Then
                Return True '8 byte address space? Yes, we have x64.
            End If

            Return False 'x86

        End Function

#End Region
#Region "Get Windows Service Pack"

        Public Shared Function GetServicePack() As String

            Dim Str As String = Environment.OSVersion.ServicePack

            If Str = "" Then
                Return "None"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Get Windows Uptime"

        Public Shared Function GetWindowsUptime() As String


            Try
                Dim Int As Integer = CInt(GetTickCountA.GetTickCount() / 1000)
                Return Format$(Int \ 3600 \ 24, "0") & "d, " & Format$((Int \ 3600) Mod 24, "00") & "h, " _
                     & Format$((Int Mod 3600) \ 60, "00") & "m, " & Format$(Int Mod 60, "00") & "s"
            Catch ex As Exception
                Return "Unknown"
            End Try

        End Function

#End Region

    End Class

End Namespace


