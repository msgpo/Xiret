<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHotfix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHotfix))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pbrPerc = New Gambol.Controls.GambolProgressBar()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxResetWinsat = New Gambol.Controls.GambolCheckbox()
        Me.CmdInstall = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.lbInformationTwo = New System.Windows.Forms.Label()
        Me.llInfo = New System.Windows.Forms.LinkLabel()
        Me.lbError = New System.Windows.Forms.Label()
        Me.lbInformation = New System.Windows.Forms.Label()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
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
        Me.pnlHead.Size = New System.Drawing.Size(538, 40)
        Me.pnlHead.TabIndex = 126
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
        Me.CmdClose.Location = New System.Drawing.Point(498, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
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
        Me.tlpIcon.Size = New System.Drawing.Size(39, 40)
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
        Me.lbHead.Location = New System.Drawing.Point(206, 2)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(129, 38)
        Me.lbHead.TabIndex = 70
        Me.lbHead.Text = "Support"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(538, 2)
        Me.pnlSplit.TabIndex = 127
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pbrPerc)
        Me.pnlMain.Controls.Add(Me.lbInfo)
        Me.pnlMain.Controls.Add(Me.tlpBottom)
        Me.pnlMain.Controls.Add(Me.lbInformationTwo)
        Me.pnlMain.Controls.Add(Me.llInfo)
        Me.pnlMain.Controls.Add(Me.lbError)
        Me.pnlMain.Controls.Add(Me.lbInformation)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(538, 286)
        Me.pnlMain.TabIndex = 128
        '
        'pbrPerc
        '
        Me.pbrPerc.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pbrPerc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pbrPerc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbrPerc.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbrPerc.ForeColor = System.Drawing.Color.White
        Me.pbrPerc.Location = New System.Drawing.Point(0, 234)
        Me.pbrPerc.Maximum = 100
        Me.pbrPerc.Name = "pbrPerc"
        Me.pbrPerc.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pbrPerc.ShowBorder = False
        Me.pbrPerc.Size = New System.Drawing.Size(538, 5)
        Me.pbrPerc.TabIndex = 137
        Me.pbrPerc.Value = 0
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbInfo.ForeColor = System.Drawing.Color.White
        Me.lbInfo.Location = New System.Drawing.Point(9, 209)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(0, 19)
        Me.lbInfo.TabIndex = 1
        '
        'tlpBottom
        '
        Me.tlpBottom.ColumnCount = 3
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpBottom.Controls.Add(Me.cbxResetWinsat, 0, 0)
        Me.tlpBottom.Controls.Add(Me.CmdInstall, 2, 0)
        Me.tlpBottom.Controls.Add(Me.CmdCancel, 1, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpBottom.Location = New System.Drawing.Point(0, 239)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 3, 3, 67)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 1
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(538, 47)
        Me.tlpBottom.TabIndex = 136
        '
        'cbxResetWinsat
        '
        Me.cbxResetWinsat.ActiveBorderColor = System.Drawing.Color.White
        Me.cbxResetWinsat.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cbxResetWinsat.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cbxResetWinsat.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxResetWinsat.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbxResetWinsat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxResetWinsat.ForeColor = System.Drawing.Color.White
        Me.cbxResetWinsat.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cbxResetWinsat.Location = New System.Drawing.Point(198, 12)
        Me.cbxResetWinsat.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxResetWinsat.Name = "cbxResetWinsat"
        Me.cbxResetWinsat.Size = New System.Drawing.Size(161, 22)
        Me.cbxResetWinsat.TabIndex = 135
        Me.cbxResetWinsat.Text = "I've saved my work"
        Me.cbxResetWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdInstall
        '
        Me.CmdInstall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdInstall.FlatAppearance.BorderSize = 0
        Me.CmdInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdInstall.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdInstall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInstall.Location = New System.Drawing.Point(452, 8)
        Me.CmdInstall.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdInstall.Name = "CmdInstall"
        Me.CmdInstall.Size = New System.Drawing.Size(79, 30)
        Me.CmdInstall.TabIndex = 133
        Me.CmdInstall.Text = "Install"
        Me.CmdInstall.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(364, 8)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(78, 30)
        Me.CmdCancel.TabIndex = 134
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'lbInformationTwo
        '
        Me.lbInformationTwo.AutoSize = True
        Me.lbInformationTwo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformationTwo.ForeColor = System.Drawing.Color.White
        Me.lbInformationTwo.Location = New System.Drawing.Point(9, 113)
        Me.lbInformationTwo.Name = "lbInformationTwo"
        Me.lbInformationTwo.Size = New System.Drawing.Size(475, 40)
        Me.lbInformationTwo.TabIndex = 132
        Me.lbInformationTwo.Text = "Clicking 'Install' will download and add KB2687862 x64 to your system." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more " &
    "details click the below link."
        '
        'llInfo
        '
        Me.llInfo.ActiveLinkColor = System.Drawing.Color.White
        Me.llInfo.AutoSize = True
        Me.llInfo.BackColor = System.Drawing.Color.Transparent
        Me.llInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llInfo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llInfo.Location = New System.Drawing.Point(9, 165)
        Me.llInfo.Name = "llInfo"
        Me.llInfo.Size = New System.Drawing.Size(136, 20)
        Me.llInfo.TabIndex = 94
        Me.llInfo.TabStop = True
        Me.llInfo.Text = "Hotfix Information"
        '
        'lbError
        '
        Me.lbError.AutoSize = True
        Me.lbError.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbError.ForeColor = System.Drawing.Color.Coral
        Me.lbError.Location = New System.Drawing.Point(9, 81)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(438, 20)
        Me.lbError.TabIndex = 1
        Me.lbError.Text = """Failed to properly assess the disk. The parameter is incorrect."""
        '
        'lbInformation
        '
        Me.lbInformation.AutoSize = True
        Me.lbInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformation.ForeColor = System.Drawing.Color.White
        Me.lbInformation.Location = New System.Drawing.Point(9, 9)
        Me.lbInformation.Name = "lbInformation"
        Me.lbInformation.Size = New System.Drawing.Size(511, 60)
        Me.lbInformation.TabIndex = 0
        Me.lbInformation.Text = "This system is missing a hotfix that patches an bug with winsat.exe. If you're" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" &
    "xperiencing the below error when running the assessment the hotfix can be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "insta" &
    "lled from here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormHotfix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 330)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(540, 330)
        Me.Name = "FormHotfix"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hotfix"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.tlpBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents tlpIcon As TableLayoutPanel
    Friend WithEvents pbxMain As PictureBox
    Friend WithEvents lbHead As Label
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lbInformation As Label
    Friend WithEvents lbError As Label
    Friend WithEvents llInfo As LinkLabel
    Friend WithEvents lbInformationTwo As Label
    Friend WithEvents tlpBottom As TableLayoutPanel
    Friend WithEvents CmdInstall As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents lbInfo As Label
    Friend WithEvents pbrPerc As Gambol.Controls.GambolProgressBar
    Friend WithEvents cbxResetWinsat As Gambol.Controls.GambolCheckbox
End Class
