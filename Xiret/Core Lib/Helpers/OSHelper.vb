'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  OSHelper.vb
'  Created by David S
'  Updated on 22.09.2019 - DS (Update imports, windows name switch to reg, add install date, add release id, add current build, add build lab, add username, update GetServicePack)
'  Updated on 01.10.2019 - DS (Update GetWindowsBitness, update IsWindows64Bit)

Imports System.IO
Imports System.Management
Imports System.Security.Principal

Imports Microsoft.Win32

Imports Xiret.Core.WinApi

Namespace Core.Helpers

    Public Class OSHelper

        Private Shared ReadOnly SysDirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
        Private Shared ReadOnly CompName As String = My.Computer.Name

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

            'Explicitly defining ProductType knocks speed off the query. SELECT * becomes SELECT ProductType.
            Using Searcher As New ManagementObjectSearcher("SELECT ProductType FROM Win32_OperatingSystem")
                For Each MObject As ManagementObject In Searcher.Get()
                    Dim Int As UInteger = CUInt(MObject.GetPropertyValue("ProductType"))
                    Return Int <> 1 'Server build, ret true.
                Next
            End Using

            Return False 'Ret false, not server.

        End Function
#End Region
#Region "Windows Name"

        Public Shared Function GetWindowsName() As String

            Dim key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, My.Computer.Name)

            Try
                key = key.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return key.GetValue("ProductName").ToString().Replace(" (TM)", "™")
            Catch ex As Exception
                Return ""
            End Try

            Return ""

        End Function

#End Region
#Region "Windows Architecture"
        Public Shared Function GetWindowsBitness(Optional ShortArc As Boolean = False) As String

            If Environment.Is64BitOperatingSystem Then
                If ShortArc Then
                    Return "x64"
                Else
                    Return "64-Bit"
                End If
            Else
                If ShortArc Then
                    Return "x86"
                Else
                    Return "32-Bit"
                End If
            End If

        End Function
        Public Shared Function IsWindows64Bit() As Boolean

            If Environment.Is64BitOperatingSystem Then
                Return True
            Else
                Return False 'x86
            End If

        End Function

#End Region
#Region "Windows Service Pack"

        Public Shared Function GetWindowsServicePack() As String

            Dim Str As String = Environment.OSVersion.ServicePack

            If Str = "" Then
                Return "Not applicable"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Windows Uptime"

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
#Region "Windows Install Date"

        'Public Shared Function GetWindowsInstallDate(ComputerName As String) As String
        Public Shared Function GetWindowsInstallDate() As String

            'Dim key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, ComputerName)
            Dim key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                key = key.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                If key IsNot Nothing Then
                    Dim startDate As Date
                    Dim regVal As Long
                    startDate = New DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime
                    regVal = Convert.ToInt64(key.GetValue("InstallDate").ToString())
                    Return CStr(startDate.AddSeconds(regVal))
                End If
            Catch
                Return CStr(Date.MinValue)
            Finally
                key.Dispose()
            End Try

            Return CStr(Date.MinValue)

        End Function

#End Region
#Region "Windows Release Id"

        Public Shared Function GetWindowsReleaseId() As String

            Dim key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                key = key.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return key.GetValue("ReleaseId").ToString()
            Catch ex As Exception
                Return ""
            Finally
                key.Dispose()
            End Try

        End Function

#End Region
#Region "Windows Build Branch"

        Public Shared Function GetWindowsBuildBranch() As String

            Dim Key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                Key = Key.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return Key.GetValue("BuildBranch").ToString().Replace("_release", "").ToUpper
            Catch ex As Exception
                Return ""
            Finally
                Key.Dispose()
            End Try

        End Function

#End Region
#Region "Windows Current Build"

        Public Shared Function GetWindowsCurrentBuild() As String

            Dim Key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                Key = Key.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return Key.GetValue("CurrentBuild").ToString()
            Catch ex As Exception
                Return ""
            Finally
                Key.Dispose()
            End Try

        End Function

#End Region
#Region "Windows Build Lab"

        Public Shared Function GetWindowsBuildLab() As String

            Dim Key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                Key = Key.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                Return Key.GetValue("BuildLab").ToString()
            Catch ex As Exception
                Return ""
            Finally
                Key.Dispose()
            End Try

        End Function

#End Region
#Region "Username"

        Public Shared Function GetUsername() As String
            Return Environment.UserName
        End Function

#End Region
#Region "Admin"
        Public Shared Function IsElevated() As Boolean
            Return WindowsIdentity.GetCurrent.Owner.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid)
        End Function
#End Region
#Region "NET Framework"

        Public Shared Function GetNetv4Reg() As Boolean

            Dim Key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                Key = Key.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", False)
                If Key IsNot Nothing Then
                    Return True
                Else Return False
                End If
            Catch ex As Exception
                Return False
            Finally
                Key.Dispose()
            End Try

        End Function

        Public Shared Function GetNetv4Value(Value As String) As String

            Dim Key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, CompName)

            Try
                Key = Key.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", False)
                Return Key.GetValue(Value).ToString()
            Catch ex As Exception
                Return "Unknown"
            Finally
                Key.Dispose()
            End Try

        End Function

#End Region

    End Class

End Namespace


