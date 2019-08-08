'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Core class library
'  Knowledgebase.vb
'  Created by David S on 15.07.2019

Imports System.Management
Imports System.Windows.Forms

Namespace WMI

    Public Class Knowledgebase

        Shared Function CheckFor(ByVal ID As String) As Boolean

            'Checks if any given hotfix ID is installed
            'Example usage: If CheckForHotfix("KB4499728") Then : MessageBox.Show("KB4499728 is installed") : End If

            Try
                Dim s As String
                Dim mos As New ManagementObjectSearcher("root\CIMV2", "SELECT HotFixID FROM Win32_QuickFixEngineering")
                For Each obj As ManagementObject In mos.Get() 'Iterate through items in QuickFixEngineering
                    s = obj.GetPropertyValue("HotFixID").ToString
                    If s.Contains(ID) Then  'Desired hotfix is installed
                        Return True
                    End If
                Next
                'Desired hotfix is missing on the target machine, this was determined as the iteration is finished and no match was found
                Return False
            Catch
                MessageBox.Show("Could not query hotfix " & ID, "Core.WMI.Knowldgebase.CheckFor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try

        End Function

    End Class

End Namespace

