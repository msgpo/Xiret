Imports System.Runtime.InteropServices

Imports Core.WinApi

Namespace Helpers

    <StructLayout(LayoutKind.Sequential)>
    Public Structure ProcessHelper
        Friend Reserved As IntPtr
        Friend PebBaseAddress As IntPtr
        Friend Reserved2 As IntPtr
        Friend Reserved2_1 As IntPtr
        Friend UniqueProcessId As IntPtr
        Friend InheritedFromUniqueProcessId As IntPtr

        Public Shared Function GetParentProcess() As Process
            Return GetParentProcess(Process.GetCurrentProcess().Handle)
        End Function

        Public Shared Function GetParentProcess(ByVal id As Integer) As Process
            Dim process As Process = Process.GetProcessById(id)
            Return GetParentProcess(process.Handle)
        End Function

        Public Shared Function GetParentProcess(ByVal handle As IntPtr) As Process
            Dim pbi As ProcessHelper = New ProcessHelper()
            Dim returnLength As Integer
            Dim status As Integer = NtQueryInformationProcessA.NtQueryInformationProcess(handle, 0, pbi, Marshal.SizeOf(pbi), returnLength)
            If status <> 0 Then Throw New Exception(CType(status, String))

            Try
                Return Process.GetProcessById(pbi.InheritedFromUniqueProcessId.ToInt32())
            Catch ex As ArgumentException
                Return Nothing
            End Try
        End Function

    End Structure

End Namespace


