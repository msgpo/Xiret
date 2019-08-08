<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.llSOurce = New System.Windows.Forms.LinkLabel()
        Me.llBitmight = New System.Windows.Forms.LinkLabel()
        Me.llVectors = New System.Windows.Forms.LinkLabel()
        Me.llFlaticon = New System.Windows.Forms.LinkLabel()
        Me.llDonate = New System.Windows.Forms.LinkLabel()
        Me.llContact = New System.Windows.Forms.LinkLabel()
        Me.llForum = New System.Windows.Forms.LinkLabel()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.TlpLabels = New System.Windows.Forms.TableLayoutPanel()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbCopyright = New System.Windows.Forms.Label()
        Me.LbInfo = New System.Windows.Forms.Label()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpLabels.SuspendLayout()
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
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(578, 40)
        Me.pnlHead.TabIndex = 69
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(538, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 95
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
        Me.tlpIcon.Size = New System.Drawing.Size(41, 40)
        Me.tlpIcon.TabIndex = 74
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
        Me.lbHead.Location = New System.Drawing.Point(238, 2)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(104, 38)
        Me.lbHead.TabIndex = 69
        Me.lbHead.Text = "About"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(578, 2)
        Me.pnlSplit.TabIndex = 72
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.llSOurce)
        Me.pnlMain.Controls.Add(Me.llBitmight)
        Me.pnlMain.Controls.Add(Me.llVectors)
        Me.pnlMain.Controls.Add(Me.llFlaticon)
        Me.pnlMain.Controls.Add(Me.llDonate)
        Me.pnlMain.Controls.Add(Me.llContact)
        Me.pnlMain.Controls.Add(Me.llForum)
        Me.pnlMain.Controls.Add(Me.PbxLogo)
        Me.pnlMain.Controls.Add(Me.TlpLabels)
        Me.pnlMain.Controls.Add(Me.LbInfo)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(578, 316)
        Me.pnlMain.TabIndex = 73
        '
        'llSOurce
        '
        Me.llSOurce.ActiveLinkColor = System.Drawing.Color.White
        Me.llSOurce.AutoSize = True
        Me.llSOurce.BackColor = System.Drawing.Color.Transparent
        Me.llSOurce.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llSOurce.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llSOurce.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llSOurce.Location = New System.Drawing.Point(88, 271)
        Me.llSOurce.Name = "llSOurce"
        Me.llSOurce.Size = New System.Drawing.Size(55, 20)
        Me.llSOurce.TabIndex = 94
        Me.llSOurce.TabStop = True
        Me.llSOurce.Text = "Github"
        '
        'llBitmight
        '
        Me.llBitmight.ActiveLinkColor = System.Drawing.Color.White
        Me.llBitmight.AutoSize = True
        Me.llBitmight.BackColor = System.Drawing.Color.Transparent
        Me.llBitmight.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llBitmight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llBitmight.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llBitmight.Location = New System.Drawing.Point(15, 271)
        Me.llBitmight.Name = "llBitmight"
        Me.llBitmight.Size = New System.Drawing.Size(67, 20)
        Me.llBitmight.TabIndex = 93
        Me.llBitmight.TabStop = True
        Me.llBitmight.Text = "Bitmight"
        '
        'llVectors
        '
        Me.llVectors.ActiveLinkColor = System.Drawing.Color.White
        Me.llVectors.AutoSize = True
        Me.llVectors.BackColor = System.Drawing.Color.Transparent
        Me.llVectors.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llVectors.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llVectors.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llVectors.Location = New System.Drawing.Point(414, 271)
        Me.llVectors.Name = "llVectors"
        Me.llVectors.Size = New System.Drawing.Size(112, 20)
        Me.llVectors.TabIndex = 92
        Me.llVectors.TabStop = True
        Me.llVectors.Text = "Vectors Market"
        '
        'llFlaticon
        '
        Me.llFlaticon.ActiveLinkColor = System.Drawing.Color.White
        Me.llFlaticon.AutoSize = True
        Me.llFlaticon.BackColor = System.Drawing.Color.Transparent
        Me.llFlaticon.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llFlaticon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llFlaticon.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llFlaticon.Location = New System.Drawing.Point(344, 271)
        Me.llFlaticon.Name = "llFlaticon"
        Me.llFlaticon.Size = New System.Drawing.Size(63, 20)
        Me.llFlaticon.TabIndex = 91
        Me.llFlaticon.TabStop = True
        Me.llFlaticon.Text = "Flaticon"
        '
        'llDonate
        '
        Me.llDonate.ActiveLinkColor = System.Drawing.Color.White
        Me.llDonate.AutoSize = True
        Me.llDonate.BackColor = System.Drawing.Color.Transparent
        Me.llDonate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llDonate.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llDonate.Location = New System.Drawing.Point(278, 271)
        Me.llDonate.Name = "llDonate"
        Me.llDonate.Size = New System.Drawing.Size(59, 20)
        Me.llDonate.TabIndex = 89
        Me.llDonate.TabStop = True
        Me.llDonate.Text = "Donate"
        '
        'llContact
        '
        Me.llContact.ActiveLinkColor = System.Drawing.Color.White
        Me.llContact.AutoSize = True
        Me.llContact.BackColor = System.Drawing.Color.Transparent
        Me.llContact.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llContact.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llContact.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llContact.Location = New System.Drawing.Point(210, 271)
        Me.llContact.Name = "llContact"
        Me.llContact.Size = New System.Drawing.Size(61, 20)
        Me.llContact.TabIndex = 88
        Me.llContact.TabStop = True
        Me.llContact.Text = "Contact"
        '
        'llForum
        '
        Me.llForum.ActiveLinkColor = System.Drawing.Color.White
        Me.llForum.AutoSize = True
        Me.llForum.BackColor = System.Drawing.Color.Transparent
        Me.llForum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llForum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llForum.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llForum.Location = New System.Drawing.Point(149, 271)
        Me.llForum.Name = "llForum"
        Me.llForum.Size = New System.Drawing.Size(54, 20)
        Me.llForum.TabIndex = 87
        Me.llForum.TabStop = True
        Me.llForum.Text = "Forum"
        '
        'PbxLogo
        '
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.Image = Global.Xiret.My.Resources.Resources.icon64px
        Me.PbxLogo.Location = New System.Drawing.Point(16, 16)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(64, 64)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLogo.TabIndex = 78
        Me.PbxLogo.TabStop = False
        '
        'TlpLabels
        '
        Me.TlpLabels.BackColor = System.Drawing.Color.Transparent
        Me.TlpLabels.ColumnCount = 1
        Me.TlpLabels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLabels.Controls.Add(Me.lbName, 0, 0)
        Me.TlpLabels.Controls.Add(Me.lbCopyright, 0, 1)
        Me.TlpLabels.Location = New System.Drawing.Point(87, 25)
        Me.TlpLabels.Name = "TlpLabels"
        Me.TlpLabels.RowCount = 2
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpLabels.Size = New System.Drawing.Size(366, 46)
        Me.TlpLabels.TabIndex = 82
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.ForeColor = System.Drawing.Color.White
        Me.lbName.Location = New System.Drawing.Point(4, 0)
        Me.lbName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(358, 23)
        Me.lbName.TabIndex = 75
        Me.lbName.Text = "Xiret"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCopyright
        '
        Me.lbCopyright.AutoSize = True
        Me.lbCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lbCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCopyright.ForeColor = System.Drawing.Color.White
        Me.lbCopyright.Location = New System.Drawing.Point(4, 23)
        Me.lbCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCopyright.Name = "lbCopyright"
        Me.lbCopyright.Size = New System.Drawing.Size(358, 23)
        Me.lbCopyright.TabIndex = 77
        Me.lbCopyright.Text = "Copyright © 2016-2019 Bitmight Software"
        Me.lbCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbInfo
        '
        Me.LbInfo.BackColor = System.Drawing.Color.Transparent
        Me.LbInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.LbInfo.Location = New System.Drawing.Point(14, 93)
        Me.LbInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbInfo.Name = "LbInfo"
        Me.LbInfo.Size = New System.Drawing.Size(552, 156)
        Me.LbInfo.TabIndex = 76
        Me.LbInfo.Text = resources.GetString("LbInfo.Text")
        Me.LbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(580, 360)
        Me.MinimumSize = New System.Drawing.Size(580, 360)
        Me.Name = "FormAbout"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpLabels.ResumeLayout(False)
        Me.TlpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbCopyright As System.Windows.Forms.Label
    Friend WithEvents PbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LbInfo As System.Windows.Forms.Label
    Friend WithEvents TlpLabels As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents llFlaticon As System.Windows.Forms.LinkLabel
    Friend WithEvents llDonate As System.Windows.Forms.LinkLabel
    Friend WithEvents llContact As System.Windows.Forms.LinkLabel
    Friend WithEvents llForum As System.Windows.Forms.LinkLabel
    Friend WithEvents llVectors As System.Windows.Forms.LinkLabel
    Friend WithEvents llBitmight As System.Windows.Forms.LinkLabel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents llSOurce As LinkLabel
End Class
