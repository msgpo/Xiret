Imports Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.sFour = New System.Windows.Forms.Label()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pnlAssessmentMode = New System.Windows.Forms.Panel()
        Me.rbnVerbose = New Gambol.Controls.GambolRadioButton()
        Me.rbnNormal = New Gambol.Controls.GambolRadioButton()
        Me.sThree = New System.Windows.Forms.Label()
        Me.pnlShowHardware = New System.Windows.Forms.Panel()
        Me.rbnHardwareDisable = New Gambol.Controls.GambolRadioButton()
        Me.rbnHardwareEnable = New Gambol.Controls.GambolRadioButton()
        Me.pnlPortability = New System.Windows.Forms.Panel()
        Me.cmdWarn = New System.Windows.Forms.Button()
        Me.rbnAppath = New Gambol.Controls.GambolRadioButton()
        Me.rbnAppdata = New Gambol.Controls.GambolRadioButton()
        Me.sFive = New System.Windows.Forms.Label()
        Me.pnlThemeColor = New System.Windows.Forms.Panel()
        Me.rbnPink5 = New Gambol.Controls.GambolRadioButton()
        Me.rbnCarrot6 = New Gambol.Controls.GambolRadioButton()
        Me.rbnYellow7 = New Gambol.Controls.GambolRadioButton()
        Me.rbnAlazarin8 = New Gambol.Controls.GambolRadioButton()
        Me.cbxApplyToBorder = New Gambol.Controls.GambolCheckbox()
        Me.rbnDefault0 = New Gambol.Controls.GambolRadioButton()
        Me.rbnMegenta4 = New Gambol.Controls.GambolRadioButton()
        Me.rbnSky1 = New Gambol.Controls.GambolRadioButton()
        Me.rbnTurq2 = New Gambol.Controls.GambolRadioButton()
        Me.rbnEmerald3 = New Gambol.Controls.GambolRadioButton()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCustomID = New System.Windows.Forms.Panel()
        Me.tlpText = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxClientId = New System.Windows.Forms.TextBox()
        Me.rbnClientDisable = New Gambol.Controls.GambolRadioButton()
        Me.rbnClientEnable = New Gambol.Controls.GambolRadioButton()
        Me.sSix = New System.Windows.Forms.Label()
        Me.pnlHardwareMode = New System.Windows.Forms.Panel()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.rbnXml = New Gambol.Controls.GambolRadioButton()
        Me.rbnApi = New Gambol.Controls.GambolRadioButton()
        Me.pnlConfiguration = New System.Windows.Forms.Panel()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.sEight = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOkay = New System.Windows.Forms.Button()
        Me.sSeven = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAssessmentMode.SuspendLayout()
        Me.pnlShowHardware.SuspendLayout()
        Me.pnlPortability.SuspendLayout()
        Me.pnlThemeColor.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.pnlCustomID.SuspendLayout()
        Me.tlpText.SuspendLayout()
        Me.pnlHardwareMode.SuspendLayout()
        Me.pnlConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = CType(resources.GetObject("pnlHead.BackgroundImage"), System.Drawing.Image)
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
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(448, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
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
        Me.tlpIcon.Size = New System.Drawing.Size(39, 40)
        Me.tlpIcon.TabIndex = 73
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
        Me.lbHead.Text = "Settings"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sFour
        '
        Me.sFour.AutoSize = True
        Me.sFour.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFour.ForeColor = System.Drawing.Color.White
        Me.sFour.Location = New System.Drawing.Point(8, 6)
        Me.sFour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFour.Name = "sFour"
        Me.sFour.Size = New System.Drawing.Size(96, 20)
        Me.sFour.TabIndex = 89
        Me.sFour.Text = "Theme Color"
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(8, 6)
        Me.sOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(193, 20)
        Me.sOne.TabIndex = 107
        Me.sOne.Text = "Show Hardware on Startup"
        '
        'pnlAssessmentMode
        '
        Me.pnlAssessmentMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAssessmentMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlAssessmentMode.Controls.Add(Me.rbnVerbose)
        Me.pnlAssessmentMode.Controls.Add(Me.rbnNormal)
        Me.pnlAssessmentMode.Controls.Add(Me.sThree)
        Me.pnlAssessmentMode.Location = New System.Drawing.Point(8, 152)
        Me.pnlAssessmentMode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlAssessmentMode.Name = "pnlAssessmentMode"
        Me.pnlAssessmentMode.Size = New System.Drawing.Size(472, 70)
        Me.pnlAssessmentMode.TabIndex = 118
        '
        'rbnVerbose
        '
        Me.rbnVerbose.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnVerbose.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnVerbose.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnVerbose.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rbnVerbose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnVerbose.ForeColor = System.Drawing.Color.White
        Me.rbnVerbose.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnVerbose.Location = New System.Drawing.Point(112, 36)
        Me.rbnVerbose.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnVerbose.Name = "rbnVerbose"
        Me.rbnVerbose.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnVerbose.Size = New System.Drawing.Size(92, 22)
        Me.rbnVerbose.TabIndex = 115
        Me.rbnVerbose.Text = "Verbose"
        '
        'rbnNormal
        '
        Me.rbnNormal.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnNormal.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnNormal.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rbnNormal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNormal.ForeColor = System.Drawing.Color.White
        Me.rbnNormal.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnNormal.Location = New System.Drawing.Point(19, 36)
        Me.rbnNormal.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnNormal.Name = "rbnNormal"
        Me.rbnNormal.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnNormal.Size = New System.Drawing.Size(89, 22)
        Me.rbnNormal.TabIndex = 116
        Me.rbnNormal.Text = "Normal"
        '
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(8, 6)
        Me.sThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(184, 20)
        Me.sThree.TabIndex = 108
        Me.sThree.Text = "Default Assessment Mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlShowHardware
        '
        Me.pnlShowHardware.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlShowHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlShowHardware.Controls.Add(Me.sOne)
        Me.pnlShowHardware.Controls.Add(Me.rbnHardwareDisable)
        Me.pnlShowHardware.Controls.Add(Me.rbnHardwareEnable)
        Me.pnlShowHardware.Location = New System.Drawing.Point(8, 8)
        Me.pnlShowHardware.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlShowHardware.Name = "pnlShowHardware"
        Me.pnlShowHardware.Size = New System.Drawing.Size(472, 70)
        Me.pnlShowHardware.TabIndex = 119
        '
        'rbnHardwareDisable
        '
        Me.rbnHardwareDisable.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnHardwareDisable.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnHardwareDisable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnHardwareDisable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnHardwareDisable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnHardwareDisable.ForeColor = System.Drawing.Color.White
        Me.rbnHardwareDisable.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnHardwareDisable.Location = New System.Drawing.Point(19, 36)
        Me.rbnHardwareDisable.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnHardwareDisable.Name = "rbnHardwareDisable"
        Me.rbnHardwareDisable.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnHardwareDisable.Size = New System.Drawing.Size(66, 22)
        Me.rbnHardwareDisable.TabIndex = 112
        Me.rbnHardwareDisable.Text = "Off"
        '
        'rbnHardwareEnable
        '
        Me.rbnHardwareEnable.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnHardwareEnable.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnHardwareEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnHardwareEnable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnHardwareEnable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnHardwareEnable.ForeColor = System.Drawing.Color.White
        Me.rbnHardwareEnable.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnHardwareEnable.Location = New System.Drawing.Point(89, 36)
        Me.rbnHardwareEnable.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnHardwareEnable.Name = "rbnHardwareEnable"
        Me.rbnHardwareEnable.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnHardwareEnable.Size = New System.Drawing.Size(63, 22)
        Me.rbnHardwareEnable.TabIndex = 113
        Me.rbnHardwareEnable.Text = "On"
        '
        'pnlPortability
        '
        Me.pnlPortability.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlPortability.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlPortability.Controls.Add(Me.cmdWarn)
        Me.pnlPortability.Controls.Add(Me.rbnAppath)
        Me.pnlPortability.Controls.Add(Me.rbnAppdata)
        Me.pnlPortability.Controls.Add(Me.sFive)
        Me.pnlPortability.Location = New System.Drawing.Point(8, 296)
        Me.pnlPortability.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlPortability.Name = "pnlPortability"
        Me.pnlPortability.Size = New System.Drawing.Size(472, 70)
        Me.pnlPortability.TabIndex = 121
        '
        'cmdWarn
        '
        Me.cmdWarn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmdWarn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdWarn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdWarn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdWarn.FlatAppearance.BorderSize = 0
        Me.cmdWarn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdWarn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdWarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdWarn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWarn.ForeColor = System.Drawing.Color.Tomato
        Me.cmdWarn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdWarn.Location = New System.Drawing.Point(378, 34)
        Me.cmdWarn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWarn.Name = "cmdWarn"
        Me.cmdWarn.Size = New System.Drawing.Size(86, 30)
        Me.cmdWarn.TabIndex = 129
        Me.cmdWarn.Text = "1 Warning"
        Me.cmdWarn.UseVisualStyleBackColor = False
        '
        'rbnAppath
        '
        Me.rbnAppath.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnAppath.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnAppath.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnAppath.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnAppath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnAppath.ForeColor = System.Drawing.Color.White
        Me.rbnAppath.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnAppath.Location = New System.Drawing.Point(149, 38)
        Me.rbnAppath.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnAppath.Name = "rbnAppath"
        Me.rbnAppath.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnAppath.Size = New System.Drawing.Size(179, 22)
        Me.rbnAppath.TabIndex = 126
        Me.rbnAppath.Text = "On (Application Path)"
        '
        'rbnAppdata
        '
        Me.rbnAppdata.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnAppdata.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnAppdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnAppdata.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnAppdata.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnAppdata.ForeColor = System.Drawing.Color.White
        Me.rbnAppdata.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnAppdata.Location = New System.Drawing.Point(19, 38)
        Me.rbnAppdata.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnAppdata.Name = "rbnAppdata"
        Me.rbnAppdata.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnAppdata.Size = New System.Drawing.Size(126, 22)
        Me.rbnAppdata.TabIndex = 117
        Me.rbnAppdata.Text = "Off (Appdata)"
        '
        'sFive
        '
        Me.sFive.AutoSize = True
        Me.sFive.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFive.ForeColor = System.Drawing.Color.White
        Me.sFive.Location = New System.Drawing.Point(10, 8)
        Me.sFive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFive.Name = "sFive"
        Me.sFive.Size = New System.Drawing.Size(123, 20)
        Me.sFive.TabIndex = 89
        Me.sFive.Text = "Portability Mode"
        '
        'pnlThemeColor
        '
        Me.pnlThemeColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlThemeColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlThemeColor.Controls.Add(Me.rbnPink5)
        Me.pnlThemeColor.Controls.Add(Me.rbnCarrot6)
        Me.pnlThemeColor.Controls.Add(Me.rbnYellow7)
        Me.pnlThemeColor.Controls.Add(Me.rbnAlazarin8)
        Me.pnlThemeColor.Controls.Add(Me.cbxApplyToBorder)
        Me.pnlThemeColor.Controls.Add(Me.sFour)
        Me.pnlThemeColor.Controls.Add(Me.rbnDefault0)
        Me.pnlThemeColor.Controls.Add(Me.rbnMegenta4)
        Me.pnlThemeColor.Controls.Add(Me.rbnSky1)
        Me.pnlThemeColor.Controls.Add(Me.rbnTurq2)
        Me.pnlThemeColor.Controls.Add(Me.rbnEmerald3)
        Me.pnlThemeColor.Location = New System.Drawing.Point(8, 224)
        Me.pnlThemeColor.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlThemeColor.Name = "pnlThemeColor"
        Me.pnlThemeColor.Size = New System.Drawing.Size(472, 70)
        Me.pnlThemeColor.TabIndex = 122
        '
        'rbnPink5
        '
        Me.rbnPink5.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnPink5.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnPink5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnPink5.CheckedColor = System.Drawing.Color.HotPink
        Me.rbnPink5.ForeColor = System.Drawing.Color.White
        Me.rbnPink5.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnPink5.Location = New System.Drawing.Point(153, 36)
        Me.rbnPink5.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnPink5.Name = "rbnPink5"
        Me.rbnPink5.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnPink5.Size = New System.Drawing.Size(22, 22)
        Me.rbnPink5.TabIndex = 123
        '
        'rbnCarrot6
        '
        Me.rbnCarrot6.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnCarrot6.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnCarrot6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnCarrot6.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnCarrot6.ForeColor = System.Drawing.Color.White
        Me.rbnCarrot6.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnCarrot6.Location = New System.Drawing.Point(179, 36)
        Me.rbnCarrot6.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnCarrot6.Name = "rbnCarrot6"
        Me.rbnCarrot6.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnCarrot6.Size = New System.Drawing.Size(22, 22)
        Me.rbnCarrot6.TabIndex = 120
        '
        'rbnYellow7
        '
        Me.rbnYellow7.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnYellow7.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnYellow7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnYellow7.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.rbnYellow7.ForeColor = System.Drawing.Color.White
        Me.rbnYellow7.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnYellow7.Location = New System.Drawing.Point(205, 36)
        Me.rbnYellow7.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnYellow7.Name = "rbnYellow7"
        Me.rbnYellow7.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnYellow7.Size = New System.Drawing.Size(22, 22)
        Me.rbnYellow7.TabIndex = 121
        '
        'rbnAlazarin8
        '
        Me.rbnAlazarin8.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnAlazarin8.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnAlazarin8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnAlazarin8.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnAlazarin8.ForeColor = System.Drawing.Color.White
        Me.rbnAlazarin8.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnAlazarin8.Location = New System.Drawing.Point(232, 36)
        Me.rbnAlazarin8.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnAlazarin8.Name = "rbnAlazarin8"
        Me.rbnAlazarin8.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnAlazarin8.Size = New System.Drawing.Size(22, 22)
        Me.rbnAlazarin8.TabIndex = 122
        '
        'cbxApplyToBorder
        '
        Me.cbxApplyToBorder.ActiveBorderColor = System.Drawing.Color.White
        Me.cbxApplyToBorder.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cbxApplyToBorder.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbxApplyToBorder.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbxApplyToBorder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxApplyToBorder.ForeColor = System.Drawing.Color.White
        Me.cbxApplyToBorder.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cbxApplyToBorder.Location = New System.Drawing.Point(274, 36)
        Me.cbxApplyToBorder.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxApplyToBorder.Name = "cbxApplyToBorder"
        Me.cbxApplyToBorder.Size = New System.Drawing.Size(146, 22)
        Me.cbxApplyToBorder.TabIndex = 119
        Me.cbxApplyToBorder.Text = "Apply to Borders"
        Me.cbxApplyToBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbnDefault0
        '
        Me.rbnDefault0.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnDefault0.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnDefault0.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnDefault0.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnDefault0.ForeColor = System.Drawing.Color.White
        Me.rbnDefault0.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnDefault0.Location = New System.Drawing.Point(19, 36)
        Me.rbnDefault0.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnDefault0.Name = "rbnDefault0"
        Me.rbnDefault0.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnDefault0.Size = New System.Drawing.Size(22, 22)
        Me.rbnDefault0.TabIndex = 90
        '
        'rbnMegenta4
        '
        Me.rbnMegenta4.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnMegenta4.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnMegenta4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnMegenta4.CheckedColor = System.Drawing.Color.Magenta
        Me.rbnMegenta4.ForeColor = System.Drawing.Color.White
        Me.rbnMegenta4.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnMegenta4.Location = New System.Drawing.Point(127, 36)
        Me.rbnMegenta4.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnMegenta4.Name = "rbnMegenta4"
        Me.rbnMegenta4.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnMegenta4.Size = New System.Drawing.Size(22, 22)
        Me.rbnMegenta4.TabIndex = 102
        '
        'rbnSky1
        '
        Me.rbnSky1.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnSky1.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnSky1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnSky1.CheckedColor = System.Drawing.Color.DeepSkyBlue
        Me.rbnSky1.ForeColor = System.Drawing.Color.White
        Me.rbnSky1.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnSky1.Location = New System.Drawing.Point(46, 36)
        Me.rbnSky1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnSky1.Name = "rbnSky1"
        Me.rbnSky1.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnSky1.Size = New System.Drawing.Size(22, 22)
        Me.rbnSky1.TabIndex = 91
        '
        'rbnTurq2
        '
        Me.rbnTurq2.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnTurq2.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnTurq2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnTurq2.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.rbnTurq2.ForeColor = System.Drawing.Color.White
        Me.rbnTurq2.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnTurq2.Location = New System.Drawing.Point(73, 36)
        Me.rbnTurq2.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnTurq2.Name = "rbnTurq2"
        Me.rbnTurq2.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnTurq2.Size = New System.Drawing.Size(22, 22)
        Me.rbnTurq2.TabIndex = 92
        '
        'rbnEmerald3
        '
        Me.rbnEmerald3.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnEmerald3.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnEmerald3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnEmerald3.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.rbnEmerald3.ForeColor = System.Drawing.Color.White
        Me.rbnEmerald3.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnEmerald3.Location = New System.Drawing.Point(100, 36)
        Me.rbnEmerald3.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnEmerald3.Name = "rbnEmerald3"
        Me.rbnEmerald3.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnEmerald3.Size = New System.Drawing.Size(22, 22)
        Me.rbnEmerald3.TabIndex = 93
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tlpMain)
        Me.pnlMain.Controls.Add(Me.pnlSplit)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 41)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(488, 550)
        Me.pnlMain.TabIndex = 124
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.pnlCustomID, 0, 5)
        Me.tlpMain.Controls.Add(Me.pnlHardwareMode, 0, 1)
        Me.tlpMain.Controls.Add(Me.pnlShowHardware, 0, 0)
        Me.tlpMain.Controls.Add(Me.pnlPortability, 0, 4)
        Me.tlpMain.Controls.Add(Me.pnlThemeColor, 0, 3)
        Me.tlpMain.Controls.Add(Me.pnlAssessmentMode, 0, 2)
        Me.tlpMain.Controls.Add(Me.pnlConfiguration, 0, 6)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpMain.Location = New System.Drawing.Point(0, 2)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.tlpMain.RowCount = 7
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.tlpMain.Size = New System.Drawing.Size(488, 548)
        Me.tlpMain.TabIndex = 127
        '
        'pnlCustomID
        '
        Me.pnlCustomID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCustomID.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlCustomID.Controls.Add(Me.tlpText)
        Me.pnlCustomID.Controls.Add(Me.rbnClientDisable)
        Me.pnlCustomID.Controls.Add(Me.rbnClientEnable)
        Me.pnlCustomID.Controls.Add(Me.sSix)
        Me.pnlCustomID.Location = New System.Drawing.Point(8, 368)
        Me.pnlCustomID.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlCustomID.Name = "pnlCustomID"
        Me.pnlCustomID.Size = New System.Drawing.Size(472, 70)
        Me.pnlCustomID.TabIndex = 124
        '
        'tlpText
        '
        Me.tlpText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tlpText.ColumnCount = 1
        Me.tlpText.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpText.Controls.Add(Me.tbxClientId, 0, 0)
        Me.tlpText.Location = New System.Drawing.Point(177, 36)
        Me.tlpText.Name = "tlpText"
        Me.tlpText.RowCount = 1
        Me.tlpText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpText.Size = New System.Drawing.Size(176, 26)
        Me.tlpText.TabIndex = 128
        '
        'tbxClientId
        '
        Me.tbxClientId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxClientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tbxClientId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxClientId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxClientId.ForeColor = System.Drawing.Color.White
        Me.tbxClientId.Location = New System.Drawing.Point(3, 3)
        Me.tbxClientId.Name = "tbxClientId"
        Me.tbxClientId.Size = New System.Drawing.Size(169, 20)
        Me.tbxClientId.TabIndex = 128
        Me.tbxClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbnClientDisable
        '
        Me.rbnClientDisable.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnClientDisable.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnClientDisable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnClientDisable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnClientDisable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnClientDisable.ForeColor = System.Drawing.Color.White
        Me.rbnClientDisable.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnClientDisable.Location = New System.Drawing.Point(19, 38)
        Me.rbnClientDisable.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnClientDisable.Name = "rbnClientDisable"
        Me.rbnClientDisable.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnClientDisable.Size = New System.Drawing.Size(66, 22)
        Me.rbnClientDisable.TabIndex = 126
        Me.rbnClientDisable.Text = "Off"
        '
        'rbnClientEnable
        '
        Me.rbnClientEnable.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnClientEnable.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnClientEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnClientEnable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnClientEnable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnClientEnable.ForeColor = System.Drawing.Color.White
        Me.rbnClientEnable.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnClientEnable.Location = New System.Drawing.Point(89, 38)
        Me.rbnClientEnable.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnClientEnable.Name = "rbnClientEnable"
        Me.rbnClientEnable.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnClientEnable.Size = New System.Drawing.Size(63, 22)
        Me.rbnClientEnable.TabIndex = 127
        Me.rbnClientEnable.Text = "On"
        '
        'sSix
        '
        Me.sSix.AutoSize = True
        Me.sSix.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sSix.ForeColor = System.Drawing.Color.White
        Me.sSix.Location = New System.Drawing.Point(10, 8)
        Me.sSix.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sSix.Name = "sSix"
        Me.sSix.Size = New System.Drawing.Size(167, 20)
        Me.sSix.TabIndex = 89
        Me.sSix.Text = "Custom Imgur Client ID"
        '
        'pnlHardwareMode
        '
        Me.pnlHardwareMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlHardwareMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlHardwareMode.Controls.Add(Me.sTwo)
        Me.pnlHardwareMode.Controls.Add(Me.rbnXml)
        Me.pnlHardwareMode.Controls.Add(Me.rbnApi)
        Me.pnlHardwareMode.Location = New System.Drawing.Point(8, 80)
        Me.pnlHardwareMode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlHardwareMode.Name = "pnlHardwareMode"
        Me.pnlHardwareMode.Size = New System.Drawing.Size(472, 70)
        Me.pnlHardwareMode.TabIndex = 120
        '
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTwo.ForeColor = System.Drawing.Color.White
        Me.sTwo.Location = New System.Drawing.Point(8, 6)
        Me.sTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(120, 20)
        Me.sTwo.TabIndex = 107
        Me.sTwo.Text = "Hardware Mode"
        '
        'rbnXml
        '
        Me.rbnXml.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnXml.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnXml.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnXml.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnXml.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnXml.ForeColor = System.Drawing.Color.White
        Me.rbnXml.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnXml.Location = New System.Drawing.Point(19, 36)
        Me.rbnXml.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnXml.Name = "rbnXml"
        Me.rbnXml.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnXml.Size = New System.Drawing.Size(66, 22)
        Me.rbnXml.TabIndex = 112
        Me.rbnXml.Text = "XML"
        '
        'rbnApi
        '
        Me.rbnApi.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnApi.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnApi.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnApi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnApi.ForeColor = System.Drawing.Color.White
        Me.rbnApi.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnApi.Location = New System.Drawing.Point(89, 36)
        Me.rbnApi.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnApi.Name = "rbnApi"
        Me.rbnApi.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnApi.Size = New System.Drawing.Size(63, 22)
        Me.rbnApi.TabIndex = 113
        Me.rbnApi.Text = "API"
        '
        'pnlConfiguration
        '
        Me.pnlConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlConfiguration.Controls.Add(Me.cmdApply)
        Me.pnlConfiguration.Controls.Add(Me.sEight)
        Me.pnlConfiguration.Controls.Add(Me.cmdCancel)
        Me.pnlConfiguration.Controls.Add(Me.cmdOkay)
        Me.pnlConfiguration.Controls.Add(Me.sSeven)
        Me.pnlConfiguration.Location = New System.Drawing.Point(8, 440)
        Me.pnlConfiguration.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlConfiguration.Name = "pnlConfiguration"
        Me.pnlConfiguration.Size = New System.Drawing.Size(472, 100)
        Me.pnlConfiguration.TabIndex = 123
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdApply.FlatAppearance.BorderSize = 0
        Me.cmdApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdApply.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdApply.Location = New System.Drawing.Point(385, 62)
        Me.cmdApply.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(80, 30)
        Me.cmdApply.TabIndex = 128
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = False
        '
        'sEight
        '
        Me.sEight.AutoSize = True
        Me.sEight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sEight.Location = New System.Drawing.Point(12, 33)
        Me.sEight.Name = "sEight"
        Me.sEight.Size = New System.Drawing.Size(183, 19)
        Me.sEight.TabIndex = 127
        Me.sEight.Text = "Cancel or save your changes"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(299, 62)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 30)
        Me.cmdCancel.TabIndex = 92
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOkay
        '
        Me.cmdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOkay.FlatAppearance.BorderSize = 0
        Me.cmdOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOkay.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOkay.Location = New System.Drawing.Point(213, 62)
        Me.cmdOkay.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOkay.Name = "cmdOkay"
        Me.cmdOkay.Size = New System.Drawing.Size(80, 30)
        Me.cmdOkay.TabIndex = 91
        Me.cmdOkay.Text = "OK"
        Me.cmdOkay.UseVisualStyleBackColor = False
        '
        'sSeven
        '
        Me.sSeven.AutoSize = True
        Me.sSeven.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sSeven.ForeColor = System.Drawing.Color.White
        Me.sSeven.Location = New System.Drawing.Point(10, 8)
        Me.sSeven.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sSeven.Name = "sSeven"
        Me.sSeven.Size = New System.Drawing.Size(104, 20)
        Me.sSeven.TabIndex = 90
        Me.sSeven.Text = "Configuration"
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
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 592)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(490, 592)
        Me.Name = "FormSettings"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAssessmentMode.ResumeLayout(False)
        Me.pnlAssessmentMode.PerformLayout()
        Me.pnlShowHardware.ResumeLayout(False)
        Me.pnlShowHardware.PerformLayout()
        Me.pnlPortability.ResumeLayout(False)
        Me.pnlPortability.PerformLayout()
        Me.pnlThemeColor.ResumeLayout(False)
        Me.pnlThemeColor.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.pnlCustomID.ResumeLayout(False)
        Me.pnlCustomID.PerformLayout()
        Me.tlpText.ResumeLayout(False)
        Me.tlpText.PerformLayout()
        Me.pnlHardwareMode.ResumeLayout(False)
        Me.pnlHardwareMode.PerformLayout()
        Me.pnlConfiguration.ResumeLayout(False)
        Me.pnlConfiguration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents sFour As System.Windows.Forms.Label
    Friend WithEvents rbnDefault0 As GambolRadioButton
    Friend WithEvents rbnSky1 As GambolRadioButton
    Friend WithEvents rbnTurq2 As GambolRadioButton
    Friend WithEvents rbnEmerald3 As GambolRadioButton
    Friend WithEvents rbnMegenta4 As GambolRadioButton
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents rbnHardwareEnable As GambolRadioButton
    Friend WithEvents rbnHardwareDisable As GambolRadioButton
    Friend WithEvents pnlAssessmentMode As System.Windows.Forms.Panel
    Friend WithEvents pnlShowHardware As System.Windows.Forms.Panel
    Friend WithEvents pnlPortability As System.Windows.Forms.Panel
    Friend WithEvents rbnVerbose As GambolRadioButton
    Friend WithEvents rbnNormal As GambolRadioButton
    Friend WithEvents sThree As System.Windows.Forms.Label
    Friend WithEvents pnlThemeColor As System.Windows.Forms.Panel
    Friend WithEvents sFive As System.Windows.Forms.Label
    Friend WithEvents cbxApplyToBorder As GambolCheckbox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents rbnCarrot6 As GambolRadioButton
    Friend WithEvents rbnYellow7 As GambolRadioButton
    Friend WithEvents rbnAlazarin8 As GambolRadioButton
    Friend WithEvents rbnAppath As GambolRadioButton
    Friend WithEvents rbnAppdata As GambolRadioButton
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlConfiguration As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOkay As System.Windows.Forms.Button
    Friend WithEvents sSeven As System.Windows.Forms.Label
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents sEight As System.Windows.Forms.Label
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents cmdWarn As System.Windows.Forms.Button
    Friend WithEvents pnlHardwareMode As System.Windows.Forms.Panel
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents rbnXml As GambolRadioButton
    Friend WithEvents rbnApi As GambolRadioButton
    Friend WithEvents pnlCustomID As Panel
    Friend WithEvents tbxClientId As TextBox
    Friend WithEvents rbnClientDisable As GambolRadioButton
    Friend WithEvents rbnClientEnable As GambolRadioButton
    Friend WithEvents sSix As Label
    Friend WithEvents tlpText As TableLayoutPanel
    Friend WithEvents rbnPink5 As GambolRadioButton
End Class
