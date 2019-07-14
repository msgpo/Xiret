<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSystem))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pOne = New System.Windows.Forms.Panel()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pTwo = New System.Windows.Forms.Panel()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.pThree = New System.Windows.Forms.Panel()
        Me.sThree = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbServicePack = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbOpSys = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbBitness = New System.Windows.Forms.Label()
        Me.pFour = New System.Windows.Forms.Panel()
        Me.sFour = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbKernel = New System.Windows.Forms.Label()
        Me.pFive = New System.Windows.Forms.Panel()
        Me.sFive = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbWinsat = New System.Windows.Forms.Label()
        Me.pSix = New System.Windows.Forms.Panel()
        Me.sSix = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbApi = New System.Windows.Forms.Label()
        Me.pSeven = New System.Windows.Forms.Panel()
        Me.sSeven = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cmdrefresh = New System.Windows.Forms.Button()
        Me.lbUptime = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pOne.SuspendLayout()
        Me.pTwo.SuspendLayout()
        Me.pThree.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pFour.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pFive.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.pSix.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.pSeven.SuspendLayout()
        Me.Panel12.SuspendLayout()
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
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lbHead.Text = "System Details"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel7.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel7.Controls.Add(Me.pnlSplit)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 41)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(488, 238)
        Me.Panel7.TabIndex = 124
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pOne, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pTwo, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pThree, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pFour, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.pFive, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.pSix, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel10, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.pSeven, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel12, 1, 8)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(473, 219)
        Me.TableLayoutPanel2.TabIndex = 126
        '
        'pOne
        '
        Me.pOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pOne.Controls.Add(Me.sOne)
        Me.pOne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pOne.Location = New System.Drawing.Point(0, 0)
        Me.pOne.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pOne.Name = "pOne"
        Me.pOne.Size = New System.Drawing.Size(166, 28)
        Me.pOne.TabIndex = 79
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.BackColor = System.Drawing.Color.Transparent
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(3, 4)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(130, 20)
        Me.sOne.TabIndex = 48
        Me.sOne.Text = "Operating System"
        '
        'pTwo
        '
        Me.pTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pTwo.Controls.Add(Me.sTwo)
        Me.pTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTwo.Location = New System.Drawing.Point(0, 29)
        Me.pTwo.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pTwo.Name = "pTwo"
        Me.pTwo.Size = New System.Drawing.Size(166, 28)
        Me.pTwo.TabIndex = 80
        '
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.BackColor = System.Drawing.Color.Transparent
        Me.sTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTwo.ForeColor = System.Drawing.Color.White
        Me.sTwo.Location = New System.Drawing.Point(3, 4)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(56, 20)
        Me.sTwo.TabIndex = 49
        Me.sTwo.Text = "Bitness"
        '
        'pThree
        '
        Me.pThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pThree.Controls.Add(Me.sThree)
        Me.pThree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pThree.Location = New System.Drawing.Point(0, 58)
        Me.pThree.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pThree.Name = "pThree"
        Me.pThree.Size = New System.Drawing.Size(166, 29)
        Me.pThree.TabIndex = 83
        '
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.BackColor = System.Drawing.Color.Transparent
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(3, 4)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(95, 20)
        Me.sThree.TabIndex = 49
        Me.sThree.Text = "Service Pack"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbServicePack)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(167, 58)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(306, 29)
        Me.Panel5.TabIndex = 84
        '
        'lbServicePack
        '
        Me.lbServicePack.AutoSize = True
        Me.lbServicePack.BackColor = System.Drawing.Color.Transparent
        Me.lbServicePack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbServicePack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbServicePack.Location = New System.Drawing.Point(3, 4)
        Me.lbServicePack.Name = "lbServicePack"
        Me.lbServicePack.Size = New System.Drawing.Size(18, 20)
        Me.lbServicePack.TabIndex = 78
        Me.lbServicePack.Text = "..."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbOpSys)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(167, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 28)
        Me.Panel3.TabIndex = 81
        '
        'lbOpSys
        '
        Me.lbOpSys.AutoSize = True
        Me.lbOpSys.BackColor = System.Drawing.Color.Transparent
        Me.lbOpSys.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOpSys.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbOpSys.Location = New System.Drawing.Point(3, 4)
        Me.lbOpSys.Name = "lbOpSys"
        Me.lbOpSys.Size = New System.Drawing.Size(18, 20)
        Me.lbOpSys.TabIndex = 77
        Me.lbOpSys.Text = "..."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbBitness)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(167, 29)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(306, 28)
        Me.Panel4.TabIndex = 82
        '
        'lbBitness
        '
        Me.lbBitness.AutoSize = True
        Me.lbBitness.BackColor = System.Drawing.Color.Transparent
        Me.lbBitness.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBitness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbBitness.Location = New System.Drawing.Point(3, 4)
        Me.lbBitness.Name = "lbBitness"
        Me.lbBitness.Size = New System.Drawing.Size(18, 20)
        Me.lbBitness.TabIndex = 78
        Me.lbBitness.Text = "..."
        '
        'pFour
        '
        Me.pFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pFour.Controls.Add(Me.sFour)
        Me.pFour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFour.Location = New System.Drawing.Point(0, 95)
        Me.pFour.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pFour.Name = "pFour"
        Me.pFour.Size = New System.Drawing.Size(166, 28)
        Me.pFour.TabIndex = 85
        '
        'sFour
        '
        Me.sFour.AutoSize = True
        Me.sFour.BackColor = System.Drawing.Color.Transparent
        Me.sFour.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFour.ForeColor = System.Drawing.Color.White
        Me.sFour.Location = New System.Drawing.Point(3, 4)
        Me.sFour.Name = "sFour"
        Me.sFour.Size = New System.Drawing.Size(108, 20)
        Me.sFour.TabIndex = 50
        Me.sFour.Text = "Kernel Version"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbKernel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(167, 95)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 28)
        Me.Panel2.TabIndex = 86
        '
        'lbKernel
        '
        Me.lbKernel.AutoSize = True
        Me.lbKernel.BackColor = System.Drawing.Color.Transparent
        Me.lbKernel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKernel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbKernel.Location = New System.Drawing.Point(3, 4)
        Me.lbKernel.Name = "lbKernel"
        Me.lbKernel.Size = New System.Drawing.Size(18, 20)
        Me.lbKernel.TabIndex = 78
        Me.lbKernel.Text = "..."
        '
        'pFive
        '
        Me.pFive.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pFive.Controls.Add(Me.sFive)
        Me.pFive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFive.Location = New System.Drawing.Point(0, 124)
        Me.pFive.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pFive.Name = "pFive"
        Me.pFive.Size = New System.Drawing.Size(166, 28)
        Me.pFive.TabIndex = 87
        '
        'sFive
        '
        Me.sFive.AutoSize = True
        Me.sFive.BackColor = System.Drawing.Color.Transparent
        Me.sFive.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFive.ForeColor = System.Drawing.Color.White
        Me.sFive.Location = New System.Drawing.Point(3, 4)
        Me.sFive.Name = "sFive"
        Me.sFive.Size = New System.Drawing.Size(116, 20)
        Me.sFive.TabIndex = 51
        Me.sFive.Text = "WinSAT Version"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel8.Controls.Add(Me.lbWinsat)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(167, 124)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(306, 28)
        Me.Panel8.TabIndex = 88
        '
        'lbWinsat
        '
        Me.lbWinsat.AutoSize = True
        Me.lbWinsat.BackColor = System.Drawing.Color.Transparent
        Me.lbWinsat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWinsat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbWinsat.Location = New System.Drawing.Point(3, 4)
        Me.lbWinsat.Name = "lbWinsat"
        Me.lbWinsat.Size = New System.Drawing.Size(18, 20)
        Me.lbWinsat.TabIndex = 78
        Me.lbWinsat.Text = "..."
        '
        'pSix
        '
        Me.pSix.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pSix.Controls.Add(Me.sSix)
        Me.pSix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pSix.Location = New System.Drawing.Point(0, 153)
        Me.pSix.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pSix.Name = "pSix"
        Me.pSix.Size = New System.Drawing.Size(166, 29)
        Me.pSix.TabIndex = 89
        '
        'sSix
        '
        Me.sSix.AutoSize = True
        Me.sSix.BackColor = System.Drawing.Color.Transparent
        Me.sSix.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sSix.ForeColor = System.Drawing.Color.White
        Me.sSix.Location = New System.Drawing.Point(3, 4)
        Me.sSix.Name = "sSix"
        Me.sSix.Size = New System.Drawing.Size(87, 20)
        Me.sSix.TabIndex = 52
        Me.sSix.Text = "API Version"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel10.Controls.Add(Me.lbApi)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(167, 153)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(306, 29)
        Me.Panel10.TabIndex = 90
        '
        'lbApi
        '
        Me.lbApi.AutoSize = True
        Me.lbApi.BackColor = System.Drawing.Color.Transparent
        Me.lbApi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbApi.Location = New System.Drawing.Point(3, 4)
        Me.lbApi.Name = "lbApi"
        Me.lbApi.Size = New System.Drawing.Size(18, 20)
        Me.lbApi.TabIndex = 78
        Me.lbApi.Text = "..."
        '
        'pSeven
        '
        Me.pSeven.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pSeven.Controls.Add(Me.sSeven)
        Me.pSeven.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pSeven.Location = New System.Drawing.Point(0, 190)
        Me.pSeven.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pSeven.Name = "pSeven"
        Me.pSeven.Size = New System.Drawing.Size(166, 29)
        Me.pSeven.TabIndex = 91
        '
        'sSeven
        '
        Me.sSeven.AutoSize = True
        Me.sSeven.BackColor = System.Drawing.Color.Transparent
        Me.sSeven.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sSeven.ForeColor = System.Drawing.Color.White
        Me.sSeven.Location = New System.Drawing.Point(3, 4)
        Me.sSeven.Name = "sSeven"
        Me.sSeven.Size = New System.Drawing.Size(111, 20)
        Me.sSeven.TabIndex = 53
        Me.sSeven.Text = "System Uptime"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel12.Controls.Add(Me.cmdrefresh)
        Me.Panel12.Controls.Add(Me.lbUptime)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(167, 190)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(306, 29)
        Me.Panel12.TabIndex = 92
        '
        'cmdrefresh
        '
        Me.cmdrefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdrefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdrefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdrefresh.FlatAppearance.BorderSize = 0
        Me.cmdrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdrefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdrefresh.Location = New System.Drawing.Point(233, 0)
        Me.cmdrefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdrefresh.Name = "cmdrefresh"
        Me.cmdrefresh.Size = New System.Drawing.Size(73, 29)
        Me.cmdrefresh.TabIndex = 129
        Me.cmdrefresh.Text = "Refresh"
        Me.cmdrefresh.UseVisualStyleBackColor = False
        '
        'lbUptime
        '
        Me.lbUptime.AutoSize = True
        Me.lbUptime.BackColor = System.Drawing.Color.Transparent
        Me.lbUptime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUptime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbUptime.Location = New System.Drawing.Point(3, 4)
        Me.lbUptime.Name = "lbUptime"
        Me.lbUptime.Size = New System.Drawing.Size(18, 20)
        Me.lbUptime.TabIndex = 79
        Me.lbUptime.Text = "..."
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
        'FormSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 280)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(490, 280)
        Me.MinimumSize = New System.Drawing.Size(490, 280)
        Me.Name = "FormSystem"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Details"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.pOne.ResumeLayout(False)
        Me.pOne.PerformLayout()
        Me.pTwo.ResumeLayout(False)
        Me.pTwo.PerformLayout()
        Me.pThree.ResumeLayout(False)
        Me.pThree.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pFour.ResumeLayout(False)
        Me.pFour.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pFive.ResumeLayout(False)
        Me.pFive.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.pSix.ResumeLayout(False)
        Me.pSix.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.pSeven.ResumeLayout(False)
        Me.pSeven.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pOne As System.Windows.Forms.Panel
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents pTwo As System.Windows.Forms.Panel
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents pThree As System.Windows.Forms.Panel
    Friend WithEvents sThree As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbServicePack As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbOpSys As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbBitness As System.Windows.Forms.Label
    Friend WithEvents pFour As System.Windows.Forms.Panel
    Friend WithEvents sFour As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pFive As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents pSix As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lbKernel As System.Windows.Forms.Label
    Friend WithEvents sFive As System.Windows.Forms.Label
    Friend WithEvents lbWinsat As System.Windows.Forms.Label
    Friend WithEvents sSix As System.Windows.Forms.Label
    Friend WithEvents lbApi As System.Windows.Forms.Label
    Friend WithEvents pSeven As System.Windows.Forms.Panel
    Friend WithEvents sSeven As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbUptime As System.Windows.Forms.Label
    Friend WithEvents cmdrefresh As System.Windows.Forms.Button
End Class
