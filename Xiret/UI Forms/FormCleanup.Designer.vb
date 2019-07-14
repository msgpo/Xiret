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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pnlReset = New System.Windows.Forms.Panel()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cbxResetWinsat = New Gambol.Controls.GambolCheckbox()
        Me.sSeven = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPurge = New System.Windows.Forms.Panel()
        Me.cmdPurge = New System.Windows.Forms.Button()
        Me.cbxPurgeSettings = New Gambol.Controls.GambolCheckbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.pnlHead.Controls.Add(Me.BtnClose)
        Me.pnlHead.Controls.Add(Me.tlpIcon)
        Me.pnlHead.Controls.Add(Me.lbHead)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(1, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(488, 40)
        Me.pnlHead.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(448, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 71
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "✕"
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me.tlpIcon.Size = New System.Drawing.Size(51, 40)
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
        Me.pnlReset.Controls.Add(Me.cmdReset)
        Me.pnlReset.Controls.Add(Me.cbxResetWinsat)
        Me.pnlReset.Controls.Add(Me.sSeven)
        Me.pnlReset.Controls.Add(Me.sOne)
        Me.pnlReset.Location = New System.Drawing.Point(8, 8)
        Me.pnlReset.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlReset.Name = "pnlReset"
        Me.pnlReset.Size = New System.Drawing.Size(472, 118)
        Me.pnlReset.TabIndex = 119
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdReset.Enabled = False
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdReset.FlatAppearance.BorderSize = 0
        Me.cmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdReset.Location = New System.Drawing.Point(384, 80)
        Me.cmdReset.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(80, 30)
        Me.cmdReset.TabIndex = 129
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cbxResetWinsat
        '
        Me.cbxResetWinsat.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cbxResetWinsat.ActiveBorderColor = System.Drawing.Color.White
        Me.cbxResetWinsat.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cbxResetWinsat.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbxResetWinsat.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxResetWinsat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxResetWinsat.ForeColor = System.Drawing.Color.White
        Me.cbxResetWinsat.Location = New System.Drawing.Point(19, 84)
        Me.cbxResetWinsat.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxResetWinsat.Name = "cbxResetWinsat"
        Me.cbxResetWinsat.Size = New System.Drawing.Size(88, 22)
        Me.cbxResetWinsat.TabIndex = 120
        Me.cbxResetWinsat.Text = "I agree"
        Me.cbxResetWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sSeven
        '
        Me.sSeven.AutoSize = True
        Me.sSeven.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sSeven.Location = New System.Drawing.Point(12, 31)
        Me.sSeven.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sSeven.Name = "sSeven"
        Me.sSeven.Size = New System.Drawing.Size(424, 38)
        Me.sSeven.TabIndex = 114
        Me.sSeven.Text = "Deletes all system scores and the log file. Deletion is permanent and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cannot be " &
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
        Me.pnlPurge.Controls.Add(Me.cmdPurge)
        Me.pnlPurge.Controls.Add(Me.cbxPurgeSettings)
        Me.pnlPurge.Controls.Add(Me.Label2)
        Me.pnlPurge.Controls.Add(Me.Label3)
        Me.pnlPurge.Location = New System.Drawing.Point(8, 128)
        Me.pnlPurge.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlPurge.Name = "pnlPurge"
        Me.pnlPurge.Size = New System.Drawing.Size(472, 118)
        Me.pnlPurge.TabIndex = 120
        '
        'cmdPurge
        '
        Me.cmdPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdPurge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdPurge.Enabled = False
        Me.cmdPurge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdPurge.FlatAppearance.BorderSize = 0
        Me.cmdPurge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdPurge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdPurge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPurge.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPurge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdPurge.Location = New System.Drawing.Point(384, 80)
        Me.cmdPurge.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPurge.Name = "cmdPurge"
        Me.cmdPurge.Size = New System.Drawing.Size(80, 30)
        Me.cmdPurge.TabIndex = 129
        Me.cmdPurge.Text = "Purge"
        Me.cmdPurge.UseVisualStyleBackColor = False
        '
        'cbxPurgeSettings
        '
        Me.cbxPurgeSettings.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cbxPurgeSettings.ActiveBorderColor = System.Drawing.Color.White
        Me.cbxPurgeSettings.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cbxPurgeSettings.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbxPurgeSettings.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxPurgeSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPurgeSettings.ForeColor = System.Drawing.Color.White
        Me.cbxPurgeSettings.Location = New System.Drawing.Point(19, 84)
        Me.cbxPurgeSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxPurgeSettings.Name = "cbxPurgeSettings"
        Me.cbxPurgeSettings.Size = New System.Drawing.Size(88, 22)
        Me.cbxPurgeSettings.TabIndex = 121
        Me.cbxPurgeSettings.Text = "I agree"
        Me.cbxPurgeSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 38)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Removes all Xiret files, folders and logs. Deletion is permanent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and cannot be r" &
    "eversed. Application will exit."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Purge application"
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
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents pnlReset As System.Windows.Forms.Panel
    Friend WithEvents sSeven As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPurge As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxResetWinsat As GambolCheckbox
    Friend WithEvents cbxPurgeSettings As GambolCheckbox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdPurge As System.Windows.Forms.Button
End Class
