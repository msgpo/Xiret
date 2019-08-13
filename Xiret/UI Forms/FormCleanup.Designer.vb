Imports Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCleanup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCleanup))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pnlReset = New System.Windows.Forms.Panel()
        Me.CmdReset = New System.Windows.Forms.Button()
        Me.CbxResetWinsat = New Gambol.Controls.GambolCheckbox()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPurge = New System.Windows.Forms.Panel()
        Me.CmdPurge = New System.Windows.Forms.Button()
        Me.CbxPurgeSettings = New Gambol.Controls.GambolCheckbox()
        Me.sFour = New System.Windows.Forms.Label()
        Me.sThree = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReset.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlPurge.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.pnlHead.Controls.Add(Me.CmdClose)
        Me.pnlHead.Controls.Add(Me.tlpIcon)
        Me.pnlHead.Controls.Add(Me.lbHead)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(1, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(488, 40)
        Me.pnlHead.TabIndex = 0
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(448, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 71
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'tlpIcon
        '
        Me.tlpIcon.BackColor = System.Drawing.Color.Transparent
        Me.tlpIcon.ColumnCount = 1
        Me.tlpIcon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpIcon.Controls.Add(Me.pbxMain, 0, 0)
        Me.tlpIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpIcon.Location = New System.Drawing.Point(0, 0)
        Me.tlpIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpIcon.Name = "tlpIcon"
        Me.tlpIcon.RowCount = 1
        Me.tlpIcon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIcon.Size = New System.Drawing.Size(43, 40)
        Me.tlpIcon.TabIndex = 73
        '
        'pbxMain
        '
        Me.pbxMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxMain.BackColor = System.Drawing.Color.Transparent
        Me.pbxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMain.Image = Global.Xiret.My.Resources.Resources.icon24px
        Me.pbxMain.Location = New System.Drawing.Point(9, 8)
        Me.pbxMain.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.pbxMain.Name = "pbxMain"
        Me.pbxMain.Size = New System.Drawing.Size(24, 24)
        Me.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMain.TabIndex = 1
        Me.pbxMain.TabStop = False
        '
        'lbHead
        '
        Me.lbHead.BackColor = System.Drawing.Color.Transparent
        Me.lbHead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHead.ForeColor = System.Drawing.Color.White
        Me.lbHead.Location = New System.Drawing.Point(181, 2)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(129, 38)
        Me.lbHead.TabIndex = 70
        Me.lbHead.Text = "Cleanup"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(8, 6)
        Me.sOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(115, 23)
        Me.sOne.TabIndex = 107
        Me.sOne.Text = "Reset WinSAT"
        '
        'pnlReset
        '
        Me.pnlReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlReset.Controls.Add(Me.CmdReset)
        Me.pnlReset.Controls.Add(Me.CbxResetWinsat)
        Me.pnlReset.Controls.Add(Me.sTwo)
        Me.pnlReset.Controls.Add(Me.sOne)
        Me.pnlReset.Location = New System.Drawing.Point(8, 8)
        Me.pnlReset.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlReset.Name = "pnlReset"
        Me.pnlReset.Size = New System.Drawing.Size(472, 118)
        Me.pnlReset.TabIndex = 119
        '
        'CmdReset
        '
        Me.CmdReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdReset.Enabled = False
        Me.CmdReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdReset.FlatAppearance.BorderSize = 0
        Me.CmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdReset.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdReset.Location = New System.Drawing.Point(384, 80)
        Me.CmdReset.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdReset.Name = "CmdReset"
        Me.CmdReset.Size = New System.Drawing.Size(80, 30)
        Me.CmdReset.TabIndex = 129
        Me.CmdReset.Text = "Reset"
        Me.CmdReset.UseVisualStyleBackColor = False
        '
        'CbxResetWinsat
        '
        Me.CbxResetWinsat.ActiveBorderColor = System.Drawing.Color.White
        Me.CbxResetWinsat.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CbxResetWinsat.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CbxResetWinsat.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CbxResetWinsat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxResetWinsat.ForeColor = System.Drawing.Color.White
        Me.CbxResetWinsat.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CbxResetWinsat.Location = New System.Drawing.Point(19, 84)
        Me.CbxResetWinsat.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxResetWinsat.Name = "CbxResetWinsat"
        Me.CbxResetWinsat.Size = New System.Drawing.Size(88, 22)
        Me.CbxResetWinsat.TabIndex = 120
        Me.CbxResetWinsat.Text = "I agree"
        Me.CbxResetWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sTwo.Location = New System.Drawing.Point(12, 31)
        Me.sTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(424, 38)
        Me.sTwo.TabIndex = 114
        Me.sTwo.Text = "Deletes all system scores and the log file. Deletion is permanent and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cannot be " &
    "reversed. Application will restart."
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel7.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel7.Controls.Add(Me.pnlSplit)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 41)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(488, 256)
        Me.Panel7.TabIndex = 124
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlPurge, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlReset, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2, 8, 2, 2)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 254)
        Me.TableLayoutPanel1.TabIndex = 127
        '
        'pnlPurge
        '
        Me.pnlPurge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlPurge.Controls.Add(Me.CmdPurge)
        Me.pnlPurge.Controls.Add(Me.CbxPurgeSettings)
        Me.pnlPurge.Controls.Add(Me.sFour)
        Me.pnlPurge.Controls.Add(Me.sThree)
        Me.pnlPurge.Location = New System.Drawing.Point(8, 128)
        Me.pnlPurge.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlPurge.Name = "pnlPurge"
        Me.pnlPurge.Size = New System.Drawing.Size(472, 118)
        Me.pnlPurge.TabIndex = 120
        '
        'CmdPurge
        '
        Me.CmdPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdPurge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPurge.Enabled = False
        Me.CmdPurge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdPurge.FlatAppearance.BorderSize = 0
        Me.CmdPurge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdPurge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdPurge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPurge.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPurge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdPurge.Location = New System.Drawing.Point(384, 80)
        Me.CmdPurge.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPurge.Name = "CmdPurge"
        Me.CmdPurge.Size = New System.Drawing.Size(80, 30)
        Me.CmdPurge.TabIndex = 129
        Me.CmdPurge.Text = "Purge"
        Me.CmdPurge.UseVisualStyleBackColor = False
        '
        'CbxPurgeSettings
        '
        Me.CbxPurgeSettings.ActiveBorderColor = System.Drawing.Color.White
        Me.CbxPurgeSettings.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CbxPurgeSettings.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CbxPurgeSettings.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CbxPurgeSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxPurgeSettings.ForeColor = System.Drawing.Color.White
        Me.CbxPurgeSettings.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CbxPurgeSettings.Location = New System.Drawing.Point(19, 84)
        Me.CbxPurgeSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxPurgeSettings.Name = "CbxPurgeSettings"
        Me.CbxPurgeSettings.Size = New System.Drawing.Size(88, 22)
        Me.CbxPurgeSettings.TabIndex = 121
        Me.CbxPurgeSettings.Text = "I agree"
        Me.CbxPurgeSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sFour
        '
        Me.sFour.AutoSize = True
        Me.sFour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sFour.Location = New System.Drawing.Point(12, 31)
        Me.sFour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFour.Name = "sFour"
        Me.sFour.Size = New System.Drawing.Size(386, 38)
        Me.sFour.TabIndex = 114
        Me.sFour.Text = "Removes all Xiret files, folders and logs. Deletion is permanent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and cannot be r" &
    "eversed. Application will exit."
        '
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(8, 6)
        Me.sThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(144, 23)
        Me.sThree.TabIndex = 107
        Me.sThree.Text = "Purge application"
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(0, 0)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(488, 2)
        Me.pnlSplit.TabIndex = 125
        '
        'FormCleanup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 298)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(490, 298)
        Me.MinimumSize = New System.Drawing.Size(490, 298)
        Me.Name = "FormCleanup"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cleanup"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReset.ResumeLayout(False)
        Me.pnlReset.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlPurge.ResumeLayout(False)
        Me.pnlPurge.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents pnlReset As System.Windows.Forms.Panel
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPurge As System.Windows.Forms.Panel
    Friend WithEvents sFour As System.Windows.Forms.Label
    Friend WithEvents sThree As System.Windows.Forms.Label
    Friend WithEvents CbxResetWinsat As GambolCheckbox
    Friend WithEvents CbxPurgeSettings As GambolCheckbox
    Friend WithEvents CmdReset As System.Windows.Forms.Button
    Friend WithEvents CmdPurge As System.Windows.Forms.Button
End Class
