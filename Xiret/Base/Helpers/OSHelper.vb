'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  OSHelper.vb
'  Created by David S
'  Updated 06.07.2019 - DS (Removed win32 reg call in OSHGetName)

Imports System.Management

Imports Core.WinApi

Namespace Base.Helpers

    Module OSHelper

        Public ReadOnly OSHKernelVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory & "\kernel32.dll")
        Public ReadOnly OSHWinsatVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory & "\WinSAT.exe")
        Public ReadOnly OSHWinsatApiVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory & "\WinSATAPI.dll")

#Region "OS Bool"

        Friend Function OSHWinIsVista() As Boolean

            If (OSHKernelVersion.ProductMajorPart = 6) And (OSHKernelVersion.ProductMinorPart < 1) Then
                Return True
            Else
                If (OSHKernelVersion.ProductMajorPart >= 6) And (OSHKernelVersion.ProductMinorPart >= 1) Then
                    Return False
                End If
            End If

            Return False

        End Function

        Friend Function OSHWinIsTen() As Boolean

            If OSHKernelVersion.ProductMajorPart = 10 Then
                Return True
            Else
                If OSHKernelVersion.ProductMajorPart < 10 Then
                    Return False
                End If
            End If

            Return False

        End Function
        Public Function OSHWinIsServer() As Boolean
            Using search As New ManagementObjectSearcher("SELECT ProductType FROM Win32_OperatingSystem")
                For Each managementObject As ManagementObject In search.[Get]()
                    Dim type As UInteger = CUInt(managementObject.GetPropertyValue("ProductType"))
                    Return type <> 1
                Next
            End Using
            Return False
        End Function
#End Region
#Region "Get Windows Name"

        Friend Function OSHGetName() As String

            Try
                Return My.Computer.Info.OSFullName.Replace("Microsoft ", "").Replace("(TM)", "™").Replace("Microsoft® ", "")
            Catch
                Return "null"
            End Try

        End Function

#End Region
#Region "Get Windows Architecture"

        Friend Function OSHGetBitness(Optional ShortArc As Boolean = False) As String

            Select Case IntPtr.Size
                Case 4 '32 bit
                    If (ShortArc) Then
                        Return "x86"
                    Else
                        Return "32-Bit"
                    End If
                Case 8 '64 bit
                    If (ShortArc) Then
                        Return "x64"
                    Else
                        Return "64-Bit"
                    End If
                Case Else 'Unknown Arch
                    Return Nothing
            End Select

        End Function

#End Region
#Region "Get Windows Service Pack"

        Friend Function OSHGetServicepack() As String
            Dim sTemp As String = Environment.OSVersion.ServicePack
            Try
                If sTemp = "" Then : Return "None"
                Else : Return sTemp
                End If
            Catch
                Return "Unknown"
            End Try
        End Function

#End Region
#Region "Get Windows Uptime"

        Friend Function OSHWinGetUptime() As String
            Dim i As Integer = CInt(GetTickCountA.GetTickCount() / 1000)
            Try
                Return Format$(i \ 3600 \ 24, "0") & "d, " & Format$((i \ 3600) Mod 24, "00") & "h, " _
                     & Format$((i Mod 3600) \ 60, "00") & "m, " & Format$(i Mod 60, "00") & "s"
            Catch
                Return ""
            End Try
        End Function

#End Region

    End Module

End Namespace


