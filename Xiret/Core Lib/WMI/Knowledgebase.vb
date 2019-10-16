'Xiret - Experience Index UI License
'https://github.com/K4onashi/Xiret

'You may freely use, modify, and distribute the Xiret source code, but you must adhere to the small list of restrictions:

'You must not use the source code for any monetary gain, including donations.
'You must include the above Github backlink to the original project.
'You must publicise any changes made to the code.
'You must include this license, unedited, with any changes.

'  Xiret Project
'  Knowledgebase.vb
'  Created by David S on 15.07.2019
'  Updated on 07.10.2019 - DS (Gained ListAllHotfixes())
'  Updated on 16.10.2019 - DS (Update imports)

Imports System.Management

Namespace Core.WMI

    Public Class Knowledgebase

        Shared Function CheckFor(ByVal ID As String) As Boolean

            'Checks if any given hotfix ID is installed
            'Example usage: If CheckForHotfix("KB4499728") Then : MessageBox.Show("KB4499728 is installed") : End If
            Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT HotFixID FROM Win32_QuickFixEngineering")

            Try
                For Each obj As ManagementObject In Searcher.Get() 'Iterate through items in QuickFixEngineering
                    Dim Str = obj.GetPropertyValue("HotFixID").ToString
                    If Str.Contains(ID) Then  'Desired hotfix is installed
                        Return True
                    End If
                Next
                'Desired hotfix is missing on the target machine, this was determined as the iteration is finished and no match was found
                Return False
            Catch ex As Exception
                MessageBox.Show("Could not query hotfix " & ID & vbCrLf & ex.Message, "Xiret.WMI.Knowldgebase.CheckFor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                Searcher.Dispose()
            End Try

        End Function

        Shared Function ListAllHotfixes() As List(Of String)

            Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT HotFixID FROM Win32_QuickFixEngineering")
            Dim Updates As New List(Of String)()

            Try
                For Each obj As ManagementObject In Searcher.Get() 'Iterate through items in QuickFixEngineering
                    Dim Str = obj.GetPropertyValue("HotFixID").ToString
                    Updates.Add(Str)
                Next
                Searcher.Dispose()
                Return Updates
            Catch ex As Exception
                MessageBox.Show("Could not iterate objects." & vbCrLf & ex.Message, "Xiret.WMI.Knowldgebase.ListAllHotfixes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

    End Class

End Namespace

