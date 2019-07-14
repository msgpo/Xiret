'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret (Xir)
'  Screencap.vb
'  Created by David S

Module Screencap

    Public Sub CaptureControl(ByVal file As String, control As Control)

        Using bm As New Bitmap(control.Width, control.Height)
            control.DrawToBitmap(bm, New Rectangle(0, 0, control.Width, control.Height))
            bm.Save(file, Imaging.ImageFormat.Png)
        End Using

    End Sub

End Module
