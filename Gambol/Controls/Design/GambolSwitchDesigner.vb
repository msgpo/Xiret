'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Gambol UI
'  GambolSwitchDesigner.vb
'  Created by David S on 20.03.2016
'  Updated on 02.01.2019 - DR

Imports System.Windows.Forms.Design

Namespace Controls.Design

    Public Class GambolSwitchDesigner
        Inherits ControlDesigner

        Protected Overrides Sub PostFilterProperties(properties As IDictionary)

            properties.Remove("ImeMode")
            properties.Remove("CheckAlign")
            properties.Remove("Padding")
            properties.Remove("FlatAppearance")
            properties.Remove("FlatStyle")
            properties.Remove("Text")
            properties.Remove("TextAlign")

            properties.Remove("Image")
            properties.Remove("ImageAlign")
            properties.Remove("ImageIndex")
            properties.Remove("ImageKey")
            properties.Remove("ImageList")
            properties.Remove("TextImageRelation")

            properties.Remove("BackgroundImage")
            properties.Remove("BackgroundImageLayout")
            properties.Remove("UseVisualStyleBackColor")

            properties.Remove("RightToLeft")

            MyBase.PostFilterProperties(properties)

        End Sub

    End Class

End Namespace


