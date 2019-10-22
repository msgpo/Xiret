'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  GambolCheckboxDesigner.vb
'  Created by David S on 20.03.2016

Imports System.Windows.Forms.Design

Namespace Controls.Design

    Public Class GambolCheckboxDesigner
        Inherits ControlDesigner

        Protected Overrides Sub PreFilterProperties(properties As IDictionary)
            MyBase.PreFilterProperties(properties)

            properties.Remove("ImeMode")
            properties.Remove("Padding")
            properties.Remove("FlatAppearance")
            properties.Remove("FlatStyle")
            properties.Remove("AutoEllipsis")

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


            MyBase.PreFilterProperties(properties)

        End Sub

    End Class

End Namespace

