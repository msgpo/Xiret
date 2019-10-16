Imports Xiret.Controls

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
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.sWinsat = New System.Windows.Forms.Label()
        Me.PanReset = New System.Windows.Forms.Panel()
        Me.CmdReset = New System.Windows.Forms.Button()
        Me.CbxResetWinsat = New Controls.GambolCheckbox()
        Me.sWinsatInfo = New System.Windows.Forms.Label()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.PanPurge = New System.Windows.Forms.Panel()
        Me.sApplication = New System.Windows.Forms.Label()
        Me.sApplicationInfo = New System.Windows.Forms.Label()
        Me.CmdPurge = New System.Windows.Forms.Button()
        Me.CbxPurgeSettings = New Controls.GambolCheckbox()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanReset.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.PanPurge.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(2)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(488, 40)
        Me.PanHead.TabIndex = 0
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
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TlpHeadImage.Controls.Add(Me.PbxHead, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(40, 40)
        Me.TlpHeadImage.TabIndex = 73
        '
        'PbxHead
        '
        Me.PbxHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxHead.BackColor = System.Drawing.Color.Transparent
        Me.PbxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxHead.Image = Global.Xiret.My.Resources.Resources.icon24px
        Me.PbxHead.Location = New System.Drawing.Point(9, 8)
        Me.PbxHead.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PbxHead.Name = "PbxHead"
        Me.PbxHead.Size = New System.Drawing.Size(24, 24)
        Me.PbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHead.TabIndex = 1
        Me.PbxHead.TabStop = False
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(181, 2)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(129, 38)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "Cleanup"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sWinsat
        '
        Me.sWinsat.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sWinsat.Dock = System.Windows.Forms.DockStyle.Top
        Me.sWinsat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sWinsat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sWinsat.Location = New System.Drawing.Point(0, 0)
        Me.sWinsat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sWinsat.Name = "sWinsat"
        Me.sWinsat.Size = New System.Drawing.Size(472, 24)
        Me.sWinsat.TabIndex = 107
        Me.sWinsat.Text = "Reset WinSAT"
        Me.sWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanReset
        '
        Me.PanReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanReset.Controls.Add(Me.CmdReset)
        Me.PanReset.Controls.Add(Me.CbxResetWinsat)
        Me.PanReset.Controls.Add(Me.sWinsatInfo)
        Me.PanReset.Controls.Add(Me.sWinsat)
        Me.PanReset.Location = New System.Drawing.Point(8, 8)
        Me.PanReset.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.PanReset.Name = "PanReset"
        Me.PanReset.Size = New System.Drawing.Size(472, 118)
        Me.PanReset.TabIndex = 119
        '
        'CmdReset
        '
        Me.CmdReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdReset.Enabled = False
        Me.CmdReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdReset.FlatAppearance.BorderSize = 0
        Me.CmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdReset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdReset.Location = New System.Drawing.Point(384, 75)
        Me.CmdReset.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdReset.Name = "CmdReset"
        Me.CmdReset.Size = New System.Drawing.Size(80, 35)
        Me.CmdReset.TabIndex = 1
        Me.CmdReset.Text = "Reset"
        Me.CmdReset.UseVisualStyleBackColor = False
        '
        'CbxResetWinsat
        '
        Me.CbxResetWinsat.ActiveBorderColor = System.Drawing.Color.White
        Me.CbxResetWinsat.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CbxResetWinsat.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CbxResetWinsat.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CbxResetWinsat.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CbxResetWinsat.Location = New System.Drawing.Point(14, 84)
        Me.CbxResetWinsat.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxResetWinsat.Name = "CbxResetWinsat"
        Me.CbxResetWinsat.Size = New System.Drawing.Size(88, 22)
        Me.CbxResetWinsat.TabIndex = 0
        Me.CbxResetWinsat.Text = "I agree"
        Me.CbxResetWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sWinsatInfo
        '
        Me.sWinsatInfo.AutoSize = True
        Me.sWinsatInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sWinsatInfo.Location = New System.Drawing.Point(5, 31)
        Me.sWinsatInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sWinsatInfo.Name = "sWinsatInfo"
        Me.sWinsatInfo.Size = New System.Drawing.Size(424, 38)
        Me.sWinsatInfo.TabIndex = 114
        Me.sWinsatInfo.Text = "Deletes all system scores and the log file. Deletion is permanent and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cannot be " &
    "reversed. Application will restart."
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpMain)
        Me.PanMain.Controls.Add(Me.PanSplit)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 41)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(488, 256)
        Me.PanMain.TabIndex = 124
        '
        'TlpMain
        '
        Me.TlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.Controls.Add(Me.PanPurge, 0, 1)
        Me.TlpMain.Controls.Add(Me.PanReset, 0, 0)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMain.Location = New System.Drawing.Point(0, 2)
        Me.TlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.Padding = New System.Windows.Forms.Padding(2, 8, 2, 2)
        Me.TlpMain.RowCount = 3
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TlpMain.Size = New System.Drawing.Size(488, 254)
        Me.TlpMain.TabIndex = 127
        '
        'PanPurge
        '
        Me.PanPurge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanPurge.Controls.Add(Me.sApplication)
        Me.PanPurge.Controls.Add(Me.sApplicationInfo)
        Me.PanPurge.Controls.Add(Me.CmdPurge)
        Me.PanPurge.Controls.Add(Me.CbxPurgeSettings)
        Me.PanPurge.Location = New System.Drawing.Point(8, 128)
        Me.PanPurge.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.PanPurge.Name = "PanPurge"
        Me.PanPurge.Size = New System.Drawing.Size(472, 118)
        Me.PanPurge.TabIndex = 120
        '
        'sApplication
        '
        Me.sApplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sApplication.Dock = System.Windows.Forms.DockStyle.Top
        Me.sApplication.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sApplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sApplication.Location = New System.Drawing.Point(0, 0)
        Me.sApplication.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sApplication.Name = "sApplication"
        Me.sApplication.Size = New System.Drawing.Size(472, 24)
        Me.sApplication.TabIndex = 130
        Me.sApplication.Text = "Clean Configuration"
        Me.sApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sApplicationInfo
        '
        Me.sApplicationInfo.AutoSize = True
        Me.sApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sApplicationInfo.Location = New System.Drawing.Point(5, 31)
        Me.sApplicationInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sApplicationInfo.Name = "sApplicationInfo"
        Me.sApplicationInfo.Size = New System.Drawing.Size(386, 38)
        Me.sApplicationInfo.TabIndex = 114
        Me.sApplicationInfo.Text = "Removes all Xiret files, folders and logs. Deletion is permanent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and cannot be r" &
    "eversed. Application will exit."
        '
        'CmdPurge
        '
        Me.CmdPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdPurge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPurge.Enabled = False
        Me.CmdPurge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdPurge.FlatAppearance.BorderSize = 0
        Me.CmdPurge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdPurge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdPurge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPurge.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPurge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdPurge.Location = New System.Drawing.Point(384, 75)
        Me.CmdPurge.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPurge.Name = "CmdPurge"
        Me.CmdPurge.Size = New System.Drawing.Size(80, 35)
        Me.CmdPurge.TabIndex = 3
        Me.CmdPurge.Text = "Clean"
        Me.CmdPurge.UseVisualStyleBackColor = False
        '
        'CbxPurgeSettings
        '
        Me.CbxPurgeSettings.ActiveBorderColor = System.Drawing.Color.White
        Me.CbxPurgeSettings.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CbxPurgeSettings.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CbxPurgeSettings.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CbxPurgeSettings.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CbxPurgeSettings.Location = New System.Drawing.Point(14, 84)
        Me.CbxPurgeSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxPurgeSettings.Name = "CbxPurgeSettings"
        Me.CbxPurgeSettings.Size = New System.Drawing.Size(88, 22)
        Me.CbxPurgeSettings.TabIndex = 2
        Me.CbxPurgeSettings.Text = "I agree"
        Me.CbxPurgeSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(0, 0)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(488, 2)
        Me.PanSplit.TabIndex = 125
        '
        'FormCleanup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 298)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanHead)
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
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanReset.ResumeLayout(False)
        Me.PanReset.PerformLayout()
        Me.PanMain.ResumeLayout(False)
        Me.TlpMain.ResumeLayout(False)
        Me.PanPurge.ResumeLayout(False)
        Me.PanPurge.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents sWinsat As System.Windows.Forms.Label
    Friend WithEvents PanReset As System.Windows.Forms.Panel
    Friend WithEvents sWinsatInfo As System.Windows.Forms.Label
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents TlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents PanPurge As System.Windows.Forms.Panel
    Friend WithEvents sApplicationInfo As System.Windows.Forms.Label
    Friend WithEvents CbxResetWinsat As GambolCheckbox
    Friend WithEvents CbxPurgeSettings As GambolCheckbox
    Friend WithEvents CmdReset As System.Windows.Forms.Button
    Friend WithEvents CmdPurge As System.Windows.Forms.Button
    Friend WithEvents sApplication As Label
End Class
