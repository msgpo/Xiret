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
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCurrent = New System.Windows.Forms.Panel()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pnlServer = New System.Windows.Forms.Panel()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.pnlType = New System.Windows.Forms.Panel()
        Me.sThree = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbType = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbCurrent = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbServer = New System.Windows.Forms.Label()
        Me.llChangelog = New System.Windows.Forms.LinkLabel()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlCurrent.SuspendLayout()
        Me.pnlServer.SuspendLayout()
        Me.pnlType.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(373, 2)
        Me.pnlSplit.TabIndex = 74
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
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(373, 40)
        Me.pnlHead.TabIndex = 73
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(333, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 7
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
        Me.tlpIcon.TabIndex = 71
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
        Me.lbHead.Location = New System.Drawing.Point(136, 2)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(102, 38)
        Me.lbHead.TabIndex = 69
        Me.lbHead.Text = "Update"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlMain.Controls.Add(Me.llChangelog)
        Me.pnlMain.Controls.Add(Me.lbInfo)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(373, 266)
        Me.pnlMain.TabIndex = 75
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cmdUpdate, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmdCancel, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(218, 221)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(146, 35)
        Me.TableLayoutPanel3.TabIndex = 88
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdUpdate.FlatAppearance.BorderSize = 0
        Me.cmdUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdUpdate.Location = New System.Drawing.Point(0, 0)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(70, 35)
        Me.cmdUpdate.TabIndex = 75
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(77, 0)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(70, 35)
        Me.cmdCancel.TabIndex = 76
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlCurrent, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlServer, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlType, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(21, 87)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(332, 87)
        Me.TableLayoutPanel2.TabIndex = 87
        '
        'pnlCurrent
        '
        Me.pnlCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlCurrent.Controls.Add(Me.sOne)
        Me.pnlCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCurrent.Location = New System.Drawing.Point(0, 0)
        Me.pnlCurrent.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pnlCurrent.Name = "pnlCurrent"
        Me.pnlCurrent.Size = New System.Drawing.Size(129, 28)
        Me.pnlCurrent.TabIndex = 79
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.BackColor = System.Drawing.Color.Transparent
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(3, 3)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(120, 20)
        Me.sOne.TabIndex = 48
        Me.sOne.Text = "Current Version:"
        '
        'pnlServer
        '
        Me.pnlServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlServer.Controls.Add(Me.sTwo)
        Me.pnlServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlServer.Location = New System.Drawing.Point(0, 29)
        Me.pnlServer.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pnlServer.Name = "pnlServer"
        Me.pnlServer.Size = New System.Drawing.Size(129, 28)
        Me.pnlServer.TabIndex = 80
        '
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.BackColor = System.Drawing.Color.Transparent
        Me.sTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTwo.ForeColor = System.Drawing.Color.White
        Me.sTwo.Location = New System.Drawing.Point(3, 4)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(113, 20)
        Me.sTwo.TabIndex = 49
        Me.sTwo.Text = "Server Version:"
        '
        'pnlType
        '
        Me.pnlType.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlType.Controls.Add(Me.sThree)
        Me.pnlType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlType.Location = New System.Drawing.Point(0, 58)
        Me.pnlType.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlType.Name = "pnlType"
        Me.pnlType.Size = New System.Drawing.Size(129, 29)
        Me.pnlType.TabIndex = 83
        '
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.BackColor = System.Drawing.Color.Transparent
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(3, 4)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(99, 20)
        Me.sThree.TabIndex = 49
        Me.sThree.Text = "Update Type:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbType)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(130, 58)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(202, 29)
        Me.Panel5.TabIndex = 84
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.BackColor = System.Drawing.Color.Transparent
        Me.lbType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbType.Location = New System.Drawing.Point(4, 4)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(18, 20)
        Me.lbType.TabIndex = 78
        Me.lbType.Text = "..."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbCurrent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(130, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 28)
        Me.Panel3.TabIndex = 81
        '
        'lbCurrent
        '
        Me.lbCurrent.AutoSize = True
        Me.lbCurrent.BackColor = System.Drawing.Color.Transparent
        Me.lbCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbCurrent.Location = New System.Drawing.Point(4, 3)
        Me.lbCurrent.Name = "lbCurrent"
        Me.lbCurrent.Size = New System.Drawing.Size(18, 20)
        Me.lbCurrent.TabIndex = 77
        Me.lbCurrent.Text = "..."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbServer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(130, 29)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(202, 28)
        Me.Panel4.TabIndex = 82
        '
        'lbServer
        '
        Me.lbServer.AutoSize = True
        Me.lbServer.BackColor = System.Drawing.Color.Transparent
        Me.lbServer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbServer.Location = New System.Drawing.Point(4, 4)
        Me.lbServer.Name = "lbServer"
        Me.lbServer.Size = New System.Drawing.Size(18, 20)
        Me.lbServer.TabIndex = 78
        Me.lbServer.Text = "..."
        '
        'llChangelog
        '
        Me.llChangelog.ActiveLinkColor = System.Drawing.Color.White
        Me.llChangelog.AutoSize = True
        Me.llChangelog.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llChangelog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llChangelog.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llChangelog.Location = New System.Drawing.Point(17, 38)
        Me.llChangelog.Name = "llChangelog"
        Me.llChangelog.Size = New System.Drawing.Size(120, 20)
        Me.llChangelog.TabIndex = 86
        Me.llChangelog.TabStop = True
        Me.llChangelog.Text = "View Changelog"
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo.ForeColor = System.Drawing.Color.White
        Me.lbInfo.Location = New System.Drawing.Point(17, 18)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(306, 20)
        Me.lbInfo.TabIndex = 85
        Me.lbInfo.Text = "A new version of Xiret is ready for download."
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(375, 310)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(375, 310)
        Me.MinimumSize = New System.Drawing.Size(375, 310)
        Me.Name = "FormUpdate"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.pnlCurrent.ResumeLayout(False)
        Me.pnlCurrent.PerformLayout()
        Me.pnlServer.ResumeLayout(False)
        Me.pnlServer.PerformLayout()
        Me.pnlType.ResumeLayout(False)
        Me.pnlType.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbServer As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbCurrent As System.Windows.Forms.Label
    Friend WithEvents pnlServer As System.Windows.Forms.Panel
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents pnlCurrent As System.Windows.Forms.Panel
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents pnlType As System.Windows.Forms.Panel
    Friend WithEvents sThree As System.Windows.Forms.Label
    Friend WithEvents llChangelog As System.Windows.Forms.LinkLabel
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
End Class
