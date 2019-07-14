Imports System.Runtime.InteropServices

Public Module CueText

        Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
        Private Const EM_SETCUEBANNER As Integer = &H1501
        <DllImport("user32.dll", CharSet:=CharSet.Auto)>
        Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Integer
        End Function
    Public Sub SetCueText(cntrl As Control, text As String)
        SendMessage(cntrl.Handle, EM_SETCUEBANNER, 0, text)
    End Sub

End Module



