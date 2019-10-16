'Xiret -Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  DetectTaskbar.vb
'  Created by David S

Module DetectTaskbar

    Public Enum TaskBarLocation
        Top
        Bottom
        Left
        Right
    End Enum
    Public Function GetTaskbarLocation() As TaskBarLocation
        Dim Bounds As Rectangle = Screen.PrimaryScreen.Bounds
        Dim Area As Rectangle = Screen.PrimaryScreen.WorkingArea
        If Area.Height < Bounds.Height And Area.Y > 0 Then
            Return TaskBarLocation.Top
        ElseIf Area.Height < Bounds.Height And Area.Y = 0 Then
            Return TaskBarLocation.Bottom
        ElseIf Area.Width < Bounds.Width And Area.X > 0 Then
            Return TaskBarLocation.Left
        ElseIf Area.Width < Bounds.Width And Area.X = 0 Then
            Return TaskBarLocation.Right
        Else
            Return Nothing
        End If
    End Function
End Module


