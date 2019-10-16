'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  Composition.vb
'  Created by David S

'Imports System.Runtime.InteropServices

'Imports Xiret.Core.WinApi.SetWindowCompositionAttributeA

Namespace Animation

    'Public Class Composition

    '    Public Shared Sub BlurWinForm(Form As Form, Type As AccentState, CompositionAttribute As WindowCompositionAttribute)

    '        Dim AccPolicy = New AccentPolicy With {
    '            .AccentState = Type
    '        }

    '        Dim AccStructSize = Marshal.SizeOf(AccPolicy)

    '        Dim AccPtr = Marshal.AllocHGlobal(AccStructSize)
    '        Marshal.StructureToPtr(AccPolicy, AccPtr, False)

    '        Dim data = New WindowCompositionAttributeData With {
    '            .Attribute = CompositionAttribute,
    '            .SizeOfData = AccStructSize,
    '            .data = AccPtr
    '        }

    '        SetWindowCompositionAttribute(Form.Handle, data)

    '        Marshal.FreeHGlobal(AccPtr)

    '    End Sub

    'End Class

End Namespace
