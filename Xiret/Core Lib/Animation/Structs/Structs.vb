'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  Structs.vb
'  Created by David S

Imports System.Runtime.InteropServices

Namespace Animation

    Public Module Structs

        <StructLayout(LayoutKind.Sequential)>
        Public Structure AccentPolicy

            Public AccentState As AccentState
            Public AccentFlags As Integer
            Public GradientColor As Integer
            Public AnimationId As Integer

        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Public Structure WindowCompositionAttributeData

            Public Attribute As WindowCompositionAttribute
            Public Data As IntPtr
            Public SizeOfData As Integer

        End Structure

    End Module

End Namespace


