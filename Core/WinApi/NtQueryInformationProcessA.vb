Imports System.Runtime.InteropServices

Imports Core.Helpers

Namespace WinApi

    Public Class NtQueryInformationProcessA

        <DllImport("ntdll.dll")>
        Public Shared Function NtQueryInformationProcess(ByVal Handle As IntPtr, ByVal InformationClass As Integer, ByRef Information As ProcessHelper, ByVal InformationLength As Integer, <Out> ByRef ReturnLength As Integer) As Integer
        End Function

    End Class

End Namespace

