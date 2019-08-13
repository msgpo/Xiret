<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMetrics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMetrics))
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.tlpHead = New System.Windows.Forms.TableLayoutPanel()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdProgramInfo = New System.Windows.Forms.Button()
        Me.CmdSysEnviron = New System.Windows.Forms.Button()
        Me.CmdWinSpr = New System.Windows.Forms.Button()
        Me.cmdMetrics = New System.Windows.Forms.Button()
        Me.CmdOS = New System.Windows.Forms.Button()
        Me.CmdGraphics = New System.Windows.Forms.Button()
        Me.CmdMemory = New System.Windows.Forms.Button()
        Me.CmdProcessor = New System.Windows.Forms.Button()
        Me.CmdSystem = New System.Windows.Forms.Button()
        Me.CmdDisk = New System.Windows.Forms.Button()
        Me.CmdDwm = New System.Windows.Forms.Button()
        Me.CmdD3D = New System.Windows.Forms.Button()
        Me.pnlHead.SuspendLayout()
        Me.tlpHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpWindow.SuspendLayout()
        Me.tlpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(998, 2)
        Me.pnlSplit.TabIndex = 74
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = CType(resources.GetObject("pnlHead.BackgroundImage"), System.Drawing.Image)
        Me.pnlHead.Controls.Add(Me.tlpHead)
        Me.pnlHead.Controls.Add(Me.CmdClose)
        Me.pnlHead.Controls.Add(Me.tlpIcon)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(1, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(998, 40)
        Me.pnlHead.TabIndex = 73
        '
        'tlpHead
        '
        Me.tlpHead.BackColor = System.Drawing.Color.Transparent
        Me.tlpHead.ColumnCount = 1
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHead.Controls.Add(Me.lbHead, 0, 0)
        Me.tlpHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHead.Location = New System.Drawing.Point(40, 0)
        Me.tlpHead.Name = "tlpHead"
        Me.tlpHead.RowCount = 1
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHead.Size = New System.Drawing.Size(918, 40)
        Me.tlpHead.TabIndex = 96
        '
        'lbHead
        '
        Me.lbHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbHead.BackColor = System.Drawing.Color.Transparent
        Me.lbHead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHead.ForeColor = System.Drawing.Color.White
        Me.lbHead.Location = New System.Drawing.Point(407, 1)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(104, 38)
        Me.lbHead.TabIndex = 69
        Me.lbHead.Text = "Metrics"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.CmdClose.Location = New System.Drawing.Point(958, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
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
        Me.tlpIcon.Size = New System.Drawing.Size(40, 40)
        Me.tlpIcon.TabIndex = 74
        '
        'pbxMain
        '
        Me.pbxMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxMain.BackColor = System.Drawing.Color.Transparent
        Me.pbxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMain.Image = CType(resources.GetObject("pbxMain.Image"), System.Drawing.Image)
        Me.pbxMain.Location = New System.Drawing.Point(9, 8)
        Me.pbxMain.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.pbxMain.Name = "pbxMain"
        Me.pbxMain.Size = New System.Drawing.Size(24, 24)
        Me.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMain.TabIndex = 1
        Me.pbxMain.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tlpWindow)
        Me.pnlMain.Controls.Add(Me.tlpMenu)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(998, 556)
        Me.pnlMain.TabIndex = 75
        '
        'tlpWindow
        '
        Me.tlpWindow.ColumnCount = 1
        Me.tlpWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpWindow.Controls.Add(Me.rtbInfo, 0, 0)
        Me.tlpWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWindow.Location = New System.Drawing.Point(159, 0)
        Me.tlpWindow.Name = "tlpWindow"
        Me.tlpWindow.Padding = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.tlpWindow.RowCount = 1
        Me.tlpWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpWindow.Size = New System.Drawing.Size(839, 556)
        Me.tlpWindow.TabIndex = 2
        '
        'rtbInfo
        '
        Me.rtbInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbInfo.DetectUrls = False
        Me.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbInfo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInfo.ForeColor = System.Drawing.Color.White
        Me.rtbInfo.Location = New System.Drawing.Point(7, 12)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.ReadOnly = True
        Me.rtbInfo.Size = New System.Drawing.Size(825, 532)
        Me.rtbInfo.TabIndex = 4
        Me.rtbInfo.Text = ""
        '
        'tlpMenu
        '
        Me.tlpMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tlpMenu.ColumnCount = 1
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.Controls.Add(Me.CmdProgramInfo, 0, 1)
        Me.tlpMenu.Controls.Add(Me.CmdSysEnviron, 0, 2)
        Me.tlpMenu.Controls.Add(Me.CmdWinSpr, 0, 3)
        Me.tlpMenu.Controls.Add(Me.cmdMetrics, 0, 4)
        Me.tlpMenu.Controls.Add(Me.CmdOS, 0, 5)
        Me.tlpMenu.Controls.Add(Me.CmdGraphics, 0, 9)
        Me.tlpMenu.Controls.Add(Me.CmdMemory, 0, 8)
        Me.tlpMenu.Controls.Add(Me.CmdProcessor, 0, 7)
        Me.tlpMenu.Controls.Add(Me.CmdSystem, 0, 6)
        Me.tlpMenu.Controls.Add(Me.CmdDisk, 0, 10)
        Me.tlpMenu.Controls.Add(Me.CmdDwm, 0, 11)
        Me.tlpMenu.Controls.Add(Me.CmdD3D, 0, 12)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 14
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(159, 556)
        Me.tlpMenu.TabIndex = 0
        '
        'CmdProgramInfo
        '
        Me.CmdProgramInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdProgramInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdProgramInfo.FlatAppearance.BorderSize = 0
        Me.CmdProgramInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdProgramInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdProgramInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdProgramInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdProgramInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdProgramInfo.Location = New System.Drawing.Point(0, 20)
        Me.CmdProgramInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdProgramInfo.Name = "CmdProgramInfo"
        Me.CmdProgramInfo.Size = New System.Drawing.Size(159, 36)
        Me.CmdProgramInfo.TabIndex = 3
        Me.CmdProgramInfo.Text = "  ProgramInfo"
        Me.CmdProgramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProgramInfo.UseVisualStyleBackColor = False
        '
        'CmdSysEnviron
        '
        Me.CmdSysEnviron.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdSysEnviron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdSysEnviron.FlatAppearance.BorderSize = 0
        Me.CmdSysEnviron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSysEnviron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSysEnviron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSysEnviron.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSysEnviron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdSysEnviron.Location = New System.Drawing.Point(0, 56)
        Me.CmdSysEnviron.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSysEnviron.Name = "CmdSysEnviron"
        Me.CmdSysEnviron.Size = New System.Drawing.Size(159, 36)
        Me.CmdSysEnviron.TabIndex = 4
        Me.CmdSysEnviron.Text = "  SystemEnvironment"
        Me.CmdSysEnviron.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSysEnviron.UseVisualStyleBackColor = False
        '
        'CmdWinSpr
        '
        Me.CmdWinSpr.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdWinSpr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdWinSpr.FlatAppearance.BorderSize = 0
        Me.CmdWinSpr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdWinSpr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdWinSpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdWinSpr.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdWinSpr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdWinSpr.Location = New System.Drawing.Point(0, 92)
        Me.CmdWinSpr.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdWinSpr.Name = "CmdWinSpr"
        Me.CmdWinSpr.Size = New System.Drawing.Size(159, 36)
        Me.CmdWinSpr.TabIndex = 8
        Me.CmdWinSpr.Text = "  WinSPR"
        Me.CmdWinSpr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdWinSpr.UseVisualStyleBackColor = False
        '
        'cmdMetrics
        '
        Me.cmdMetrics.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.BorderSize = 0
        Me.cmdMetrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdMetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMetrics.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMetrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdMetrics.Location = New System.Drawing.Point(0, 128)
        Me.cmdMetrics.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdMetrics.Name = "cmdMetrics"
        Me.cmdMetrics.Size = New System.Drawing.Size(159, 36)
        Me.cmdMetrics.TabIndex = 9
        Me.cmdMetrics.Text = "  Metrics"
        Me.cmdMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMetrics.UseVisualStyleBackColor = False
        '
        'CmdOS
        '
        Me.CmdOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdOS.FlatAppearance.BorderSize = 0
        Me.CmdOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOS.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdOS.Location = New System.Drawing.Point(0, 164)
        Me.CmdOS.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdOS.Name = "CmdOS"
        Me.CmdOS.Size = New System.Drawing.Size(159, 36)
        Me.CmdOS.TabIndex = 10
        Me.CmdOS.Text = "  OSVersion"
        Me.CmdOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOS.UseVisualStyleBackColor = False
        '
        'CmdGraphics
        '
        Me.CmdGraphics.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdGraphics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdGraphics.FlatAppearance.BorderSize = 0
        Me.CmdGraphics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdGraphics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGraphics.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGraphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdGraphics.Location = New System.Drawing.Point(0, 308)
        Me.CmdGraphics.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdGraphics.Name = "CmdGraphics"
        Me.CmdGraphics.Size = New System.Drawing.Size(159, 36)
        Me.CmdGraphics.TabIndex = 7
        Me.CmdGraphics.Text = "  Graphics"
        Me.CmdGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGraphics.UseVisualStyleBackColor = False
        '
        'CmdMemory
        '
        Me.CmdMemory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdMemory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdMemory.FlatAppearance.BorderSize = 0
        Me.CmdMemory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMemory.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdMemory.Location = New System.Drawing.Point(0, 272)
        Me.CmdMemory.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdMemory.Name = "CmdMemory"
        Me.CmdMemory.Size = New System.Drawing.Size(159, 36)
        Me.CmdMemory.TabIndex = 6
        Me.CmdMemory.Text = "  Memory (RAM)"
        Me.CmdMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMemory.UseVisualStyleBackColor = False
        '
        'CmdProcessor
        '
        Me.CmdProcessor.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdProcessor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdProcessor.FlatAppearance.BorderSize = 0
        Me.CmdProcessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdProcessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdProcessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdProcessor.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdProcessor.Location = New System.Drawing.Point(0, 236)
        Me.CmdProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdProcessor.Name = "CmdProcessor"
        Me.CmdProcessor.Size = New System.Drawing.Size(159, 36)
        Me.CmdProcessor.TabIndex = 5
        Me.CmdProcessor.Text = "  Processor"
        Me.CmdProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProcessor.UseVisualStyleBackColor = False
        '
        'CmdSystem
        '
        Me.CmdSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdSystem.FlatAppearance.BorderSize = 0
        Me.CmdSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdSystem.Location = New System.Drawing.Point(0, 200)
        Me.CmdSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSystem.Name = "CmdSystem"
        Me.CmdSystem.Size = New System.Drawing.Size(159, 36)
        Me.CmdSystem.TabIndex = 11
        Me.CmdSystem.Text = "  System"
        Me.CmdSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSystem.UseVisualStyleBackColor = False
        '
        'CmdDisk
        '
        Me.CmdDisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdDisk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdDisk.FlatAppearance.BorderSize = 0
        Me.CmdDisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDisk.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDisk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDisk.Location = New System.Drawing.Point(0, 344)
        Me.CmdDisk.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdDisk.Name = "CmdDisk"
        Me.CmdDisk.Size = New System.Drawing.Size(159, 36)
        Me.CmdDisk.TabIndex = 12
        Me.CmdDisk.Text = "  Disk"
        Me.CmdDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdDisk.UseVisualStyleBackColor = False
        '
        'CmdDwm
        '
        Me.CmdDwm.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdDwm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdDwm.FlatAppearance.BorderSize = 0
        Me.CmdDwm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDwm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDwm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDwm.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDwm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDwm.Location = New System.Drawing.Point(0, 380)
        Me.CmdDwm.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdDwm.Name = "CmdDwm"
        Me.CmdDwm.Size = New System.Drawing.Size(159, 36)
        Me.CmdDwm.TabIndex = 13
        Me.CmdDwm.Text = "  DWMAssessment"
        Me.CmdDwm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdDwm.UseVisualStyleBackColor = False
        '
        'CmdD3D
        '
        Me.CmdD3D.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdD3D.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdD3D.FlatAppearance.BorderSize = 0
        Me.CmdD3D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdD3D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdD3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdD3D.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdD3D.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdD3D.Location = New System.Drawing.Point(0, 416)
        Me.CmdD3D.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdD3D.Name = "CmdD3D"
        Me.CmdD3D.Size = New System.Drawing.Size(159, 36)
        Me.CmdD3D.TabIndex = 14
        Me.CmdD3D.Text = "  D3DAssessment"
        Me.CmdD3D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdD3D.UseVisualStyleBackColor = False
        '
        'FormMetrics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "FormMetrics"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Metrics"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpWindow.ResumeLayout(False)
        Me.tlpMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents tlpIcon As TableLayoutPanel
    Friend WithEvents pbxMain As PictureBox
    Friend WithEvents lbHead As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents CmdProgramInfo As Button
    Friend WithEvents CmdSysEnviron As Button
    Friend WithEvents CmdProcessor As Button
    Friend WithEvents CmdMemory As Button
    Friend WithEvents CmdGraphics As Button
    Friend WithEvents tlpWindow As TableLayoutPanel
    Friend WithEvents rtbInfo As RichTextBox
    Friend WithEvents tlpHead As TableLayoutPanel
    Friend WithEvents CmdWinSpr As Button
    Friend WithEvents cmdMetrics As Button
    Friend WithEvents CmdOS As Button
    Friend WithEvents CmdSystem As Button
    Friend WithEvents CmdDisk As Button
    Friend WithEvents CmdDwm As Button
    Friend WithEvents CmdD3D As Button
End Class
