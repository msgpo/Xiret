<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdate))
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.LabDownload = New System.Windows.Forms.Label()
        Me.CmdDownload = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.LnkChangelog = New System.Windows.Forms.LinkLabel()
        Me.TlpGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.PanCurrent = New System.Windows.Forms.Panel()
        Me.sOne = New System.Windows.Forms.Label()
        Me.PanServer = New System.Windows.Forms.Panel()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.PanUpdateType = New System.Windows.Forms.Panel()
        Me.sThree = New System.Windows.Forms.Label()
        Me.PanThree = New System.Windows.Forms.Panel()
        Me.LabUpdateType = New System.Windows.Forms.Label()
        Me.PanOne = New System.Windows.Forms.Panel()
        Me.LabCurrent = New System.Windows.Forms.Label()
        Me.PanTwo = New System.Windows.Forms.Panel()
        Me.LabServer = New System.Windows.Forms.Label()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        Me.TlpGrid.SuspendLayout()
        Me.PanCurrent.SuspendLayout()
        Me.PanServer.SuspendLayout()
        Me.PanUpdateType.SuspendLayout()
        Me.PanThree.SuspendLayout()
        Me.PanOne.SuspendLayout()
        Me.PanTwo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(398, 2)
        Me.PanSplit.TabIndex = 74
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(398, 40)
        Me.PanHead.TabIndex = 73
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
        Me.LabHead.Size = New System.Drawing.Size(318, 40)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "Update"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TlpHeadImage.TabIndex = 71
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
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(358, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 7
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpMain)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(398, 266)
        Me.PanMain.TabIndex = 75
        '
        'TlpMain
        '
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.Controls.Add(Me.LabInfo, 0, 0)
        Me.TlpMain.Controls.Add(Me.TlpBottom, 0, 3)
        Me.TlpMain.Controls.Add(Me.LnkChangelog, 0, 1)
        Me.TlpMain.Controls.Add(Me.TlpGrid, 0, 2)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMain.Location = New System.Drawing.Point(0, 0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.RowCount = 4
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TlpMain.Size = New System.Drawing.Size(398, 266)
        Me.TlpMain.TabIndex = 89
        '
        'LabInfo
        '
        Me.LabInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabInfo.AutoSize = True
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.White
        Me.LabInfo.Location = New System.Drawing.Point(20, 20)
        Me.LabInfo.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Size = New System.Drawing.Size(18, 20)
        Me.LabInfo.TabIndex = 85
        Me.LabInfo.Text = "..."
        '
        'TlpBottom
        '
        Me.TlpBottom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TlpBottom.ColumnCount = 5
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TlpBottom.Controls.Add(Me.LabDownload, 0, 0)
        Me.TlpBottom.Controls.Add(Me.CmdDownload, 4, 0)
        Me.TlpBottom.Controls.Add(Me.CmdCancel, 2, 0)
        Me.TlpBottom.Location = New System.Drawing.Point(9, 223)
        Me.TlpBottom.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 1
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(383, 35)
        Me.TlpBottom.TabIndex = 88
        '
        'LabDownload
        '
        Me.LabDownload.AutoSize = True
        Me.LabDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabDownload.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDownload.ForeColor = System.Drawing.Color.White
        Me.LabDownload.Location = New System.Drawing.Point(3, 0)
        Me.LabDownload.Name = "LabDownload"
        Me.LabDownload.Size = New System.Drawing.Size(203, 35)
        Me.LabDownload.TabIndex = 4
        Me.LabDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdDownload
        '
        Me.CmdDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdDownload.Enabled = False
        Me.CmdDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDownload.FlatAppearance.BorderSize = 0
        Me.CmdDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDownload.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDownload.Location = New System.Drawing.Point(290, 0)
        Me.CmdDownload.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdDownload.Name = "CmdDownload"
        Me.CmdDownload.Size = New System.Drawing.Size(93, 35)
        Me.CmdDownload.TabIndex = 3
        Me.CmdDownload.Text = "Download"
        Me.CmdDownload.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(216, 0)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(67, 35)
        Me.CmdCancel.TabIndex = 1
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'LnkChangelog
        '
        Me.LnkChangelog.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkChangelog.AutoSize = True
        Me.LnkChangelog.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkChangelog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkChangelog.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkChangelog.Location = New System.Drawing.Point(20, 40)
        Me.LnkChangelog.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LnkChangelog.Name = "LnkChangelog"
        Me.LnkChangelog.Size = New System.Drawing.Size(120, 20)
        Me.LnkChangelog.TabIndex = 0
        Me.LnkChangelog.TabStop = True
        Me.LnkChangelog.Text = "View Changelog"
        '
        'TlpGrid
        '
        Me.TlpGrid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TlpGrid.ColumnCount = 2
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.TlpGrid.Controls.Add(Me.PanCurrent, 0, 0)
        Me.TlpGrid.Controls.Add(Me.PanServer, 0, 1)
        Me.TlpGrid.Controls.Add(Me.PanUpdateType, 0, 2)
        Me.TlpGrid.Controls.Add(Me.PanThree, 1, 2)
        Me.TlpGrid.Controls.Add(Me.PanOne, 1, 0)
        Me.TlpGrid.Controls.Add(Me.PanTwo, 1, 1)
        Me.TlpGrid.Location = New System.Drawing.Point(20, 81)
        Me.TlpGrid.Margin = New System.Windows.Forms.Padding(20, 0, 0, 30)
        Me.TlpGrid.Name = "TlpGrid"
        Me.TlpGrid.RowCount = 3
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TlpGrid.Size = New System.Drawing.Size(358, 87)
        Me.TlpGrid.TabIndex = 87
        '
        'PanCurrent
        '
        Me.PanCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanCurrent.Controls.Add(Me.sOne)
        Me.PanCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCurrent.Location = New System.Drawing.Point(0, 0)
        Me.PanCurrent.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanCurrent.Name = "PanCurrent"
        Me.PanCurrent.Size = New System.Drawing.Size(129, 28)
        Me.PanCurrent.TabIndex = 79
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.BackColor = System.Drawing.Color.Transparent
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(3, 3)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(119, 20)
        Me.sOne.TabIndex = 48
        Me.sOne.Text = "Current version:"
        '
        'PanServer
        '
        Me.PanServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanServer.Controls.Add(Me.sTwo)
        Me.PanServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanServer.Location = New System.Drawing.Point(0, 29)
        Me.PanServer.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanServer.Name = "PanServer"
        Me.PanServer.Size = New System.Drawing.Size(129, 28)
        Me.PanServer.TabIndex = 80
        '
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.BackColor = System.Drawing.Color.Transparent
        Me.sTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTwo.ForeColor = System.Drawing.Color.White
        Me.sTwo.Location = New System.Drawing.Point(3, 4)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(98, 20)
        Me.sTwo.TabIndex = 49
        Me.sTwo.Text = "New version:"
        '
        'PanUpdateType
        '
        Me.PanUpdateType.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanUpdateType.Controls.Add(Me.sThree)
        Me.PanUpdateType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanUpdateType.Location = New System.Drawing.Point(0, 58)
        Me.PanUpdateType.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.PanUpdateType.Name = "PanUpdateType"
        Me.PanUpdateType.Size = New System.Drawing.Size(129, 29)
        Me.PanUpdateType.TabIndex = 83
        '
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.BackColor = System.Drawing.Color.Transparent
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(3, 4)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(121, 20)
        Me.sThree.TabIndex = 49
        Me.sThree.Text = "Update channel:"
        '
        'PanThree
        '
        Me.PanThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanThree.Controls.Add(Me.LabUpdateType)
        Me.PanThree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanThree.Location = New System.Drawing.Point(130, 58)
        Me.PanThree.Margin = New System.Windows.Forms.Padding(0)
        Me.PanThree.Name = "PanThree"
        Me.PanThree.Size = New System.Drawing.Size(228, 29)
        Me.PanThree.TabIndex = 84
        '
        'LabUpdateType
        '
        Me.LabUpdateType.AutoSize = True
        Me.LabUpdateType.BackColor = System.Drawing.Color.Transparent
        Me.LabUpdateType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabUpdateType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabUpdateType.Location = New System.Drawing.Point(4, 4)
        Me.LabUpdateType.Name = "LabUpdateType"
        Me.LabUpdateType.Size = New System.Drawing.Size(18, 20)
        Me.LabUpdateType.TabIndex = 78
        Me.LabUpdateType.Text = "..."
        '
        'PanOne
        '
        Me.PanOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanOne.Controls.Add(Me.LabCurrent)
        Me.PanOne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanOne.Location = New System.Drawing.Point(130, 0)
        Me.PanOne.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanOne.Name = "PanOne"
        Me.PanOne.Size = New System.Drawing.Size(228, 28)
        Me.PanOne.TabIndex = 81
        '
        'LabCurrent
        '
        Me.LabCurrent.AutoSize = True
        Me.LabCurrent.BackColor = System.Drawing.Color.Transparent
        Me.LabCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabCurrent.Location = New System.Drawing.Point(4, 3)
        Me.LabCurrent.Name = "LabCurrent"
        Me.LabCurrent.Size = New System.Drawing.Size(18, 20)
        Me.LabCurrent.TabIndex = 77
        Me.LabCurrent.Text = "..."
        '
        'PanTwo
        '
        Me.PanTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanTwo.Controls.Add(Me.LabServer)
        Me.PanTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanTwo.Location = New System.Drawing.Point(130, 29)
        Me.PanTwo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanTwo.Name = "PanTwo"
        Me.PanTwo.Size = New System.Drawing.Size(228, 28)
        Me.PanTwo.TabIndex = 82
        '
        'LabServer
        '
        Me.LabServer.AutoSize = True
        Me.LabServer.BackColor = System.Drawing.Color.Transparent
        Me.LabServer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabServer.Location = New System.Drawing.Point(4, 4)
        Me.LabServer.Name = "LabServer"
        Me.LabServer.Size = New System.Drawing.Size(18, 20)
        Me.LabServer.TabIndex = 78
        Me.LabServer.Text = "..."
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 310)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(400, 310)
        Me.MinimumSize = New System.Drawing.Size(400, 310)
        Me.Name = "FormUpdate"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpMain.ResumeLayout(False)
        Me.TlpMain.PerformLayout()
        Me.TlpBottom.ResumeLayout(False)
        Me.TlpBottom.PerformLayout()
        Me.TlpGrid.ResumeLayout(False)
        Me.PanCurrent.ResumeLayout(False)
        Me.PanCurrent.PerformLayout()
        Me.PanServer.ResumeLayout(False)
        Me.PanServer.PerformLayout()
        Me.PanUpdateType.ResumeLayout(False)
        Me.PanUpdateType.PerformLayout()
        Me.PanThree.ResumeLayout(False)
        Me.PanThree.PerformLayout()
        Me.PanOne.ResumeLayout(False)
        Me.PanOne.PerformLayout()
        Me.PanTwo.ResumeLayout(False)
        Me.PanTwo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents PanTwo As System.Windows.Forms.Panel
    Friend WithEvents LabServer As System.Windows.Forms.Label
    Friend WithEvents PanOne As System.Windows.Forms.Panel
    Friend WithEvents LabCurrent As System.Windows.Forms.Label
    Friend WithEvents PanServer As System.Windows.Forms.Panel
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents PanCurrent As System.Windows.Forms.Panel
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents CmdDownload As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents PanThree As System.Windows.Forms.Panel
    Friend WithEvents LabUpdateType As System.Windows.Forms.Label
    Friend WithEvents PanUpdateType As System.Windows.Forms.Panel
    Friend WithEvents sThree As System.Windows.Forms.Label
    Friend WithEvents LnkChangelog As System.Windows.Forms.LinkLabel
    Friend WithEvents LabInfo As System.Windows.Forms.Label
    Friend WithEvents TlpGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents TlpMain As TableLayoutPanel
    Friend WithEvents LabDownload As Label
End Class
