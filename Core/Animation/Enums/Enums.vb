﻿'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  Enums.vb
'  Created by David S

Namespace Animation

    Public Module Enums
        Public Enum AccentState

            ACCENT_DISABLED = 0
            ACCENT_ENABLE_GRADIENT = 1
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2
            ACCENT_ENABLE_BLURBEHIND = 3
            ACCENT_INVALID_STATE = 4

        End Enum
        Public Enum WindowCompositionAttribute

            WCA_ACCENT_POLICY = 19

        End Enum

    End Module

End Namespace

