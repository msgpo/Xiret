Imports Xiret.Controls

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
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.LnkBitmight = New System.Windows.Forms.LinkLabel()
        Me.LnkForum = New System.Windows.Forms.LinkLabel()
        Me.LnkMajorgeeks = New System.Windows.Forms.LinkLabel()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.LnkContact = New System.Windows.Forms.LinkLabel()
        Me.PanTop = New Xiret.Controls.GambolPanel()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.TlpLabels = New System.Windows.Forms.TableLayoutPanel()
        Me.LabBuild = New System.Windows.Forms.Label()
        Me.LabAppName = New System.Windows.Forms.Label()
        Me.LnkDonate = New System.Windows.Forms.LinkLabel()
        Me.LnkFlaticon = New System.Windows.Forms.LinkLabel()
        Me.LnkVectors = New System.Windows.Forms.LinkLabel()
        Me.LnkSource = New System.Windows.Forms.LinkLabel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.PanTop.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(498, 40)
        Me.PanHead.TabIndex = 69
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(40, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(418, 40)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "About"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.CmdClose.Location = New System.Drawing.Point(458, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.TlpHeadImage.TabIndex = 74
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
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(498, 2)
        Me.PanSplit.TabIndex = 72
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanMain.Controls.Add(Me.LnkBitmight)
        Me.PanMain.Controls.Add(Me.LnkForum)
        Me.PanMain.Controls.Add(Me.LnkMajorgeeks)
        Me.PanMain.Controls.Add(Me.LabInfo)
        Me.PanMain.Controls.Add(Me.LnkContact)
        Me.PanMain.Controls.Add(Me.PanTop)
        Me.PanMain.Controls.Add(Me.LnkDonate)
        Me.PanMain.Controls.Add(Me.LnkFlaticon)
        Me.PanMain.Controls.Add(Me.LnkVectors)
        Me.PanMain.Controls.Add(Me.LnkSource)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(498, 331)
        Me.PanMain.TabIndex = 0
        '
        'LnkBitmight
        '
        Me.LnkBitmight.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkBitmight.AutoSize = True
        Me.LnkBitmight.BackColor = System.Drawing.Color.Transparent
        Me.LnkBitmight.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkBitmight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkBitmight.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkBitmight.Location = New System.Drawing.Point(10, 289)
        Me.LnkBitmight.Name = "LnkBitmight"
        Me.LnkBitmight.Size = New System.Drawing.Size(131, 20)
        Me.LnkBitmight.TabIndex = 8
        Me.LnkBitmight.TabStop = True
        Me.LnkBitmight.Text = "Bitmight Software"
        '
        'LnkForum
        '
        Me.LnkForum.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkForum.AutoSize = True
        Me.LnkForum.BackColor = System.Drawing.Color.Transparent
        Me.LnkForum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkForum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkForum.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkForum.Location = New System.Drawing.Point(10, 264)
        Me.LnkForum.Name = "LnkForum"
        Me.LnkForum.Size = New System.Drawing.Size(113, 20)
        Me.LnkForum.TabIndex = 2
        Me.LnkForum.TabStop = True
        Me.LnkForum.Text = "Support Forum"
        '
        'LnkMajorgeeks
        '
        Me.LnkMajorgeeks.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkMajorgeeks.AutoSize = True
        Me.LnkMajorgeeks.BackColor = System.Drawing.Color.Transparent
        Me.LnkMajorgeeks.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkMajorgeeks.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkMajorgeeks.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkMajorgeeks.Location = New System.Drawing.Point(152, 289)
        Me.LnkMajorgeeks.Name = "LnkMajorgeeks"
        Me.LnkMajorgeeks.Size = New System.Drawing.Size(89, 20)
        Me.LnkMajorgeeks.TabIndex = 7
        Me.LnkMajorgeeks.TabStop = True
        Me.LnkMajorgeeks.Text = "Majorgeeks"
        '
        'LabInfo
        '
        Me.LabInfo.BackColor = System.Drawing.Color.Transparent
        Me.LabInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LabInfo.Location = New System.Drawing.Point(0, 90)
        Me.LabInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabInfo.Size = New System.Drawing.Size(498, 156)
        Me.LabInfo.TabIndex = 0
        Me.LabInfo.Text = resources.GetString("LabInfo.Text")
        Me.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkContact
        '
        Me.LnkContact.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkContact.AutoSize = True
        Me.LnkContact.BackColor = System.Drawing.Color.Transparent
        Me.LnkContact.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkContact.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkContact.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkContact.Location = New System.Drawing.Point(129, 264)
        Me.LnkContact.Name = "LnkContact"
        Me.LnkContact.Size = New System.Drawing.Size(136, 20)
        Me.LnkContact.TabIndex = 3
        Me.LnkContact.TabStop = True
        Me.LnkContact.Text = "Contact Developer"
        '
        'PanTop
        '
        Me.PanTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanTop.BlendBackground = False
        Me.PanTop.BlendDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanTop.BlendPrimaryColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanTop.BlendSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanTop.Controls.Add(Me.PbxLogo)
        Me.PanTop.Controls.Add(Me.TlpLabels)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.SeperatorColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanTop.SeperatorLocation = Xiret.Controls.GambolPanel.SeperatorType.Bottom
        Me.PanTop.ShowSeperator = True
        Me.PanTop.Size = New System.Drawing.Size(498, 90)
        Me.PanTop.Smoothing = System.Drawing.Drawing2D.SmoothingMode.None
        Me.PanTop.TabIndex = 0
        '
        'PbxLogo
        '
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.Image = Global.Xiret.My.Resources.Resources.icon64px
        Me.PbxLogo.Location = New System.Drawing.Point(14, 13)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(64, 64)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLogo.TabIndex = 85
        Me.PbxLogo.TabStop = False
        '
        'TlpLabels
        '
        Me.TlpLabels.BackColor = System.Drawing.Color.Transparent
        Me.TlpLabels.ColumnCount = 1
        Me.TlpLabels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLabels.Controls.Add(Me.LabBuild, 0, 1)
        Me.TlpLabels.Controls.Add(Me.LabAppName, 0, 0)
        Me.TlpLabels.Location = New System.Drawing.Point(87, 22)
        Me.TlpLabels.Name = "TlpLabels"
        Me.TlpLabels.RowCount = 2
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpLabels.Size = New System.Drawing.Size(360, 46)
        Me.TlpLabels.TabIndex = 86
        '
        'LabBuild
        '
        Me.LabBuild.AutoSize = True
        Me.LabBuild.BackColor = System.Drawing.Color.Transparent
        Me.LabBuild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabBuild.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBuild.ForeColor = System.Drawing.Color.White
        Me.LabBuild.Location = New System.Drawing.Point(0, 23)
        Me.LabBuild.Margin = New System.Windows.Forms.Padding(0)
        Me.LabBuild.Name = "LabBuild"
        Me.LabBuild.Size = New System.Drawing.Size(360, 23)
        Me.LabBuild.TabIndex = 78
        Me.LabBuild.Text = "..."
        Me.LabBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabAppName
        '
        Me.LabAppName.AutoSize = True
        Me.LabAppName.BackColor = System.Drawing.Color.Transparent
        Me.LabAppName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabAppName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAppName.ForeColor = System.Drawing.Color.White
        Me.LabAppName.Location = New System.Drawing.Point(0, 0)
        Me.LabAppName.Margin = New System.Windows.Forms.Padding(0)
        Me.LabAppName.Name = "LabAppName"
        Me.LabAppName.Size = New System.Drawing.Size(360, 23)
        Me.LabAppName.TabIndex = 75
        Me.LabAppName.Text = "Xiret❷"
        Me.LabAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkDonate
        '
        Me.LnkDonate.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkDonate.AutoSize = True
        Me.LnkDonate.BackColor = System.Drawing.Color.Transparent
        Me.LnkDonate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkDonate.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkDonate.Location = New System.Drawing.Point(384, 264)
        Me.LnkDonate.Name = "LnkDonate"
        Me.LnkDonate.Size = New System.Drawing.Size(59, 20)
        Me.LnkDonate.TabIndex = 4
        Me.LnkDonate.TabStop = True
        Me.LnkDonate.Text = "Donate"
        '
        'LnkFlaticon
        '
        Me.LnkFlaticon.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkFlaticon.AutoSize = True
        Me.LnkFlaticon.BackColor = System.Drawing.Color.Transparent
        Me.LnkFlaticon.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkFlaticon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkFlaticon.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkFlaticon.Location = New System.Drawing.Point(254, 289)
        Me.LnkFlaticon.Name = "LnkFlaticon"
        Me.LnkFlaticon.Size = New System.Drawing.Size(63, 20)
        Me.LnkFlaticon.TabIndex = 5
        Me.LnkFlaticon.TabStop = True
        Me.LnkFlaticon.Text = "Flaticon"
        '
        'LnkVectors
        '
        Me.LnkVectors.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkVectors.AutoSize = True
        Me.LnkVectors.BackColor = System.Drawing.Color.Transparent
        Me.LnkVectors.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkVectors.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkVectors.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkVectors.Location = New System.Drawing.Point(331, 289)
        Me.LnkVectors.Name = "LnkVectors"
        Me.LnkVectors.Size = New System.Drawing.Size(112, 20)
        Me.LnkVectors.TabIndex = 6
        Me.LnkVectors.TabStop = True
        Me.LnkVectors.Text = "Vectors Market"
        '
        'LnkSource
        '
        Me.LnkSource.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkSource.AutoSize = True
        Me.LnkSource.BackColor = System.Drawing.Color.Transparent
        Me.LnkSource.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkSource.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkSource.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkSource.Location = New System.Drawing.Point(271, 264)
        Me.LnkSource.Name = "LnkSource"
        Me.LnkSource.Size = New System.Drawing.Size(107, 20)
        Me.LnkSource.TabIndex = 1
        Me.LnkSource.TabStop = True
        Me.LnkSource.Text = "Github Project"
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(500, 375)
        Me.MinimumSize = New System.Drawing.Size(500, 375)
        Me.Name = "FormAbout"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.PanTop.ResumeLayout(False)
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpLabels.ResumeLayout(False)
        Me.TlpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents LnkFlaticon As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkDonate As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkContact As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkForum As System.Windows.Forms.LinkLabel
    Friend WithEvents LnkVectors As System.Windows.Forms.LinkLabel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents LnkSource As LinkLabel
    Friend WithEvents PanTop As Controls.GambolPanel
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents TlpLabels As TableLayoutPanel
    Friend WithEvents LabAppName As Label
    Friend WithEvents LabBuild As Label
    Friend WithEvents LnkMajorgeeks As LinkLabel
    Friend WithEvents LabInfo As Label
    Friend WithEvents LnkBitmight As LinkLabel
End Class
