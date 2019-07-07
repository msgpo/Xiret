Imports Xiret.Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.sThree = New System.Windows.Forms.Label()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pnlAssessmentStyle = New System.Windows.Forms.Panel()
        Me.sEight = New System.Windows.Forms.Label()
        Me.rbnVerbose = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnNormal = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.pnlShowHardware = New System.Windows.Forms.Panel()
        Me.sSeven = New System.Windows.Forms.Label()
        Me.rbnHardwareDisable = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnHardwareEnable = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.pnlPortability = New System.Windows.Forms.Panel()
        Me.cmdWarn = New System.Windows.Forms.Button()
        Me.rbnAppath = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnAppdata = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.sTen = New System.Windows.Forms.Label()
        Me.sFour = New System.Windows.Forms.Label()
        Me.pnlTheme = New System.Windows.Forms.Panel()
        Me.rbnThemeCarrot5 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnThemeSun6 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnThemeAlazarin7 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.cbxApplyToBorder = New Xiret.Gambol.Controls.GambolCheckbox()
        Me.sNine = New System.Windows.Forms.Label()
        Me.rbnThemeDef0 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnThemeAmethyst4 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnThemeSky1 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnThemeTurq2 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnThemeEmerald3 = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbnXml = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.rbnApi = New Xiret.Gambol.Controls.GambolRadioButton()
        Me.pnlConfiguration = New System.Windows.Forms.Panel()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOkay = New System.Windows.Forms.Button()
        Me.sFive = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAssessmentStyle.SuspendLayout()
        Me.pnlShowHardware.SuspendLayout()
        Me.pnlPortability.SuspendLayout()
        Me.pnlTheme.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgTileHead
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
        Me.tlpIcon.Size = New System.Drawing.Size(39, 40)
        Me.tlpIcon.TabIndex = 73
        '
        'pbxMain
        '
        Me.pbxMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxMain.BackColor = System.Drawing.Color.Transparent
        Me.pbxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMain.Image = Global.Xiret.My.Resources.Resources.imgmain
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
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(8, 6)
        Me.sThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(62, 23)
        Me.sThree.TabIndex = 89
        Me.sThree.Text = "Theme"
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(8, 6)
        Me.sOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(213, 23)
        Me.sOne.TabIndex = 107
        Me.sOne.Text = "Show hardware on startup"
        '
        'pnlAssessmentStyle
        '
        Me.pnlAssessmentStyle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAssessmentStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlAssessmentStyle.Controls.Add(Me.sEight)
        Me.pnlAssessmentStyle.Controls.Add(Me.rbnVerbose)
        Me.pnlAssessmentStyle.Controls.Add(Me.rbnNormal)
        Me.pnlAssessmentStyle.Controls.Add(Me.sTwo)
        Me.pnlAssessmentStyle.Location = New System.Drawing.Point(8, 212)
        Me.pnlAssessmentStyle.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlAssessmentStyle.Name = "pnlAssessmentStyle"
        Me.pnlAssessmentStyle.Size = New System.Drawing.Size(472, 100)
        Me.pnlAssessmentStyle.TabIndex = 118
        '
        'sEight
        '
        Me.sEight.AutoSize = True
        Me.sEight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sEight.Location = New System.Drawing.Point(12, 31)
        Me.sEight.Name = "sEight"
        Me.sEight.Size = New System.Drawing.Size(358, 19)
        Me.sEight.TabIndex = 115
        Me.sEight.Text = "Toggle the amount of data shown during the assessment"
        '
        'rbnVerbose
        '
        Me.rbnVerbose.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnVerbose.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnVerbose.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnVerbose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rbnVerbose.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rbnVerbose.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnVerbose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnVerbose.ForeColor = System.Drawing.Color.White
        Me.rbnVerbose.Location = New System.Drawing.Point(113, 63)
        Me.rbnVerbose.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnVerbose.Name = "rbnVerbose"
        Me.rbnVerbose.Size = New System.Drawing.Size(92, 22)
        Me.rbnVerbose.TabIndex = 115
        Me.rbnVerbose.Text = "Verbose"
        '
        'rbnNormal
        '
        Me.rbnNormal.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnNormal.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnNormal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rbnNormal.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rbnNormal.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnNormal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNormal.ForeColor = System.Drawing.Color.White
        Me.rbnNormal.Location = New System.Drawing.Point(20, 63)
        Me.rbnNormal.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnNormal.Name = "rbnNormal"
        Me.rbnNormal.Size = New System.Drawing.Size(89, 22)
        Me.rbnNormal.TabIndex = 116
        Me.rbnNormal.Text = "Normal"
        '
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTwo.ForeColor = System.Drawing.Color.White
        Me.sTwo.Location = New System.Drawing.Point(8, 6)
        Me.sTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(206, 23)
        Me.sTwo.TabIndex = 108
        Me.sTwo.Text = "Default assessment mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlShowHardware
        '
        Me.pnlShowHardware.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlShowHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlShowHardware.Controls.Add(Me.sSeven)
        Me.pnlShowHardware.Controls.Add(Me.sOne)
        Me.pnlShowHardware.Controls.Add(Me.rbnHardwareDisable)
        Me.pnlShowHardware.Controls.Add(Me.rbnHardwareEnable)
        Me.pnlShowHardware.Location = New System.Drawing.Point(8, 8)
        Me.pnlShowHardware.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlShowHardware.Name = "pnlShowHardware"
        Me.pnlShowHardware.Size = New System.Drawing.Size(472, 100)
        Me.pnlShowHardware.TabIndex = 119
        '
        'sSeven
        '
        Me.sSeven.AutoSize = True
        Me.sSeven.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sSeven.Location = New System.Drawing.Point(12, 31)
        Me.sSeven.Name = "sSeven"
        Me.sSeven.Size = New System.Drawing.Size(405, 19)
        Me.sSeven.TabIndex = 114
        Me.sSeven.Text = "Automatically show system hardware when the application starts"
        '
        'rbnHardwareDisable
        '
        Me.rbnHardwareDisable.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnHardwareDisable.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnHardwareDisable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnHardwareDisable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnHardwareDisable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnHardwareDisable.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnHardwareDisable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnHardwareDisable.ForeColor = System.Drawing.Color.White
        Me.rbnHardwareDisable.Location = New System.Drawing.Point(20, 63)
        Me.rbnHardwareDisable.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnHardwareDisable.Name = "rbnHardwareDisable"
        Me.rbnHardwareDisable.Size = New System.Drawing.Size(66, 22)
        Me.rbnHardwareDisable.TabIndex = 112
        Me.rbnHardwareDisable.Text = "Off"
        '
        'rbnHardwareEnable
        '
        Me.rbnHardwareEnable.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnHardwareEnable.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnHardwareEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnHardwareEnable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnHardwareEnable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnHardwareEnable.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnHardwareEnable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnHardwareEnable.ForeColor = System.Drawing.Color.White
        Me.rbnHardwareEnable.Location = New System.Drawing.Point(90, 63)
        Me.rbnHardwareEnable.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnHardwareEnable.Name = "rbnHardwareEnable"
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
        Me.pnlPortability.Controls.Add(Me.sTen)
        Me.pnlPortability.Controls.Add(Me.sFour)
        Me.pnlPortability.Location = New System.Drawing.Point(8, 416)
        Me.pnlPortability.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlPortability.Name = "pnlPortability"
        Me.pnlPortability.Size = New System.Drawing.Size(472, 100)
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
        Me.cmdWarn.Location = New System.Drawing.Point(378, 62)
        Me.cmdWarn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWarn.Name = "cmdWarn"
        Me.cmdWarn.Size = New System.Drawing.Size(86, 30)
        Me.cmdWarn.TabIndex = 129
        Me.cmdWarn.Text = "1 Warning"
        Me.cmdWarn.UseVisualStyleBackColor = False
        '
        'rbnAppath
        '
        Me.rbnAppath.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnAppath.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnAppath.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnAppath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rbnAppath.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rbnAppath.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnAppath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnAppath.ForeColor = System.Drawing.Color.White
        Me.rbnAppath.Location = New System.Drawing.Point(150, 63)
        Me.rbnAppath.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnAppath.Name = "rbnAppath"
        Me.rbnAppath.Size = New System.Drawing.Size(179, 22)
        Me.rbnAppath.TabIndex = 126
        Me.rbnAppath.Text = "On (Application Path)"
        '
        'rbnAppdata
        '
        Me.rbnAppdata.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnAppdata.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnAppdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnAppdata.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rbnAppdata.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.rbnAppdata.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnAppdata.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnAppdata.ForeColor = System.Drawing.Color.White
        Me.rbnAppdata.Location = New System.Drawing.Point(20, 63)
        Me.rbnAppdata.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnAppdata.Name = "rbnAppdata"
        Me.rbnAppdata.Size = New System.Drawing.Size(126, 22)
        Me.rbnAppdata.TabIndex = 117
        Me.rbnAppdata.Text = "Off (Appdata)"
        '
        'sTen
        '
        Me.sTen.AutoSize = True
        Me.sTen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sTen.Location = New System.Drawing.Point(12, 33)
        Me.sTen.Name = "sTen"
        Me.sTen.Size = New System.Drawing.Size(330, 19)
        Me.sTen.TabIndex = 125
        Me.sTen.Text = "This option allows you to quickly move your settings"
        '
        'sFour
        '
        Me.sFour.AutoSize = True
        Me.sFour.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFour.ForeColor = System.Drawing.Color.White
        Me.sFour.Location = New System.Drawing.Point(10, 8)
        Me.sFour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFour.Name = "sFour"
        Me.sFour.Size = New System.Drawing.Size(87, 23)
        Me.sFour.TabIndex = 89
        Me.sFour.Text = "Portability"
        '
        'pnlTheme
        '
        Me.pnlTheme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlTheme.Controls.Add(Me.rbnThemeCarrot5)
        Me.pnlTheme.Controls.Add(Me.rbnThemeSun6)
        Me.pnlTheme.Controls.Add(Me.rbnThemeAlazarin7)
        Me.pnlTheme.Controls.Add(Me.cbxApplyToBorder)
        Me.pnlTheme.Controls.Add(Me.sNine)
        Me.pnlTheme.Controls.Add(Me.sThree)
        Me.pnlTheme.Controls.Add(Me.rbnThemeDef0)
        Me.pnlTheme.Controls.Add(Me.rbnThemeAmethyst4)
        Me.pnlTheme.Controls.Add(Me.rbnThemeSky1)
        Me.pnlTheme.Controls.Add(Me.rbnThemeTurq2)
        Me.pnlTheme.Controls.Add(Me.rbnThemeEmerald3)
        Me.pnlTheme.Location = New System.Drawing.Point(8, 314)
        Me.pnlTheme.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlTheme.Name = "pnlTheme"
        Me.pnlTheme.Size = New System.Drawing.Size(472, 100)
        Me.pnlTheme.TabIndex = 122
        '
        'rbnThemeCarrot5
        '
        Me.rbnThemeCarrot5.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeCarrot5.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeCarrot5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeCarrot5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeCarrot5.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.rbnThemeCarrot5.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeCarrot5.ForeColor = System.Drawing.Color.White
        Me.rbnThemeCarrot5.Location = New System.Drawing.Point(154, 63)
        Me.rbnThemeCarrot5.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeCarrot5.Name = "rbnThemeCarrot5"
        Me.rbnThemeCarrot5.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeCarrot5.TabIndex = 120
        '
        'rbnThemeSun6
        '
        Me.rbnThemeSun6.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeSun6.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeSun6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeSun6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeSun6.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.rbnThemeSun6.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeSun6.ForeColor = System.Drawing.Color.White
        Me.rbnThemeSun6.Location = New System.Drawing.Point(181, 63)
        Me.rbnThemeSun6.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeSun6.Name = "rbnThemeSun6"
        Me.rbnThemeSun6.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeSun6.TabIndex = 121
        '
        'rbnThemeAlazarin7
        '
        Me.rbnThemeAlazarin7.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeAlazarin7.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeAlazarin7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeAlazarin7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeAlazarin7.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.rbnThemeAlazarin7.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeAlazarin7.ForeColor = System.Drawing.Color.White
        Me.rbnThemeAlazarin7.Location = New System.Drawing.Point(208, 63)
        Me.rbnThemeAlazarin7.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeAlazarin7.Name = "rbnThemeAlazarin7"
        Me.rbnThemeAlazarin7.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeAlazarin7.TabIndex = 122
        '
        'cbxApplyToBorder
        '
        Me.cbxApplyToBorder.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cbxApplyToBorder.ActiveBorderColor = System.Drawing.Color.White
        Me.cbxApplyToBorder.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cbxApplyToBorder.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbxApplyToBorder.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxApplyToBorder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxApplyToBorder.ForeColor = System.Drawing.Color.White
        Me.cbxApplyToBorder.Location = New System.Drawing.Point(250, 63)
        Me.cbxApplyToBorder.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxApplyToBorder.Name = "cbxApplyToBorder"
        Me.cbxApplyToBorder.Size = New System.Drawing.Size(146, 22)
        Me.cbxApplyToBorder.TabIndex = 119
        Me.cbxApplyToBorder.Text = "Apply to Borders"
        Me.cbxApplyToBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sNine
        '
        Me.sNine.AutoSize = True
        Me.sNine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.sNine.Location = New System.Drawing.Point(12, 31)
        Me.sNine.Name = "sNine"
        Me.sNine.Size = New System.Drawing.Size(275, 19)
        Me.sNine.TabIndex = 117
        Me.sNine.Text = "Set your preferred application accent colour"
        '
        'rbnThemeDef0
        '
        Me.rbnThemeDef0.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeDef0.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeDef0.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeDef0.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeDef0.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnThemeDef0.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeDef0.ForeColor = System.Drawing.Color.White
        Me.rbnThemeDef0.Location = New System.Drawing.Point(20, 63)
        Me.rbnThemeDef0.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeDef0.Name = "rbnThemeDef0"
        Me.rbnThemeDef0.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeDef0.TabIndex = 90
        '
        'rbnThemeAmethyst4
        '
        Me.rbnThemeAmethyst4.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeAmethyst4.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeAmethyst4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeAmethyst4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeAmethyst4.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.rbnThemeAmethyst4.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeAmethyst4.ForeColor = System.Drawing.Color.White
        Me.rbnThemeAmethyst4.Location = New System.Drawing.Point(128, 63)
        Me.rbnThemeAmethyst4.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeAmethyst4.Name = "rbnThemeAmethyst4"
        Me.rbnThemeAmethyst4.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeAmethyst4.TabIndex = 102
        '
        'rbnThemeSky1
        '
        Me.rbnThemeSky1.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeSky1.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeSky1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeSky1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeSky1.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rbnThemeSky1.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeSky1.ForeColor = System.Drawing.Color.White
        Me.rbnThemeSky1.Location = New System.Drawing.Point(47, 63)
        Me.rbnThemeSky1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeSky1.Name = "rbnThemeSky1"
        Me.rbnThemeSky1.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeSky1.TabIndex = 91
        '
        'rbnThemeTurq2
        '
        Me.rbnThemeTurq2.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeTurq2.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeTurq2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeTurq2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeTurq2.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.rbnThemeTurq2.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeTurq2.ForeColor = System.Drawing.Color.White
        Me.rbnThemeTurq2.Location = New System.Drawing.Point(74, 63)
        Me.rbnThemeTurq2.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeTurq2.Name = "rbnThemeTurq2"
        Me.rbnThemeTurq2.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeTurq2.TabIndex = 92
        '
        'rbnThemeEmerald3
        '
        Me.rbnThemeEmerald3.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeEmerald3.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeEmerald3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeEmerald3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeEmerald3.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.rbnThemeEmerald3.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnThemeEmerald3.ForeColor = System.Drawing.Color.White
        Me.rbnThemeEmerald3.Location = New System.Drawing.Point(101, 63)
        Me.rbnThemeEmerald3.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeEmerald3.Name = "rbnThemeEmerald3"
        Me.rbnThemeEmerald3.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeEmerald3.TabIndex = 93
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel7.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel7.Controls.Add(Me.pnlSplit)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 41)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(488, 628)
        Me.Panel7.TabIndex = 124
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlShowHardware, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlConfiguration, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlPortability, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTheme, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlAssessmentStyle, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 626)
        Me.TableLayoutPanel1.TabIndex = 127
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.rbnXml)
        Me.Panel1.Controls.Add(Me.rbnApi)
        Me.Panel1.Location = New System.Drawing.Point(8, 110)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 100)
        Me.Panel1.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 19)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Determine where hardware information is loaded from"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 23)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Default hardware mode"
        '
        'rbnXml
        '
        Me.rbnXml.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnXml.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnXml.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnXml.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnXml.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnXml.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnXml.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnXml.ForeColor = System.Drawing.Color.White
        Me.rbnXml.Location = New System.Drawing.Point(20, 63)
        Me.rbnXml.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnXml.Name = "rbnXml"
        Me.rbnXml.Size = New System.Drawing.Size(66, 22)
        Me.rbnXml.TabIndex = 112
        Me.rbnXml.Text = "XML"
        '
        'rbnApi
        '
        Me.rbnApi.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnApi.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnApi.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnApi.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnApi.ClientBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rbnApi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnApi.ForeColor = System.Drawing.Color.White
        Me.rbnApi.Location = New System.Drawing.Point(90, 63)
        Me.rbnApi.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnApi.Name = "rbnApi"
        Me.rbnApi.Size = New System.Drawing.Size(63, 22)
        Me.rbnApi.TabIndex = 113
        Me.rbnApi.Text = "API"
        '
        'pnlConfiguration
        '
        Me.pnlConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlConfiguration.Controls.Add(Me.cmdApply)
        Me.pnlConfiguration.Controls.Add(Me.Label1)
        Me.pnlConfiguration.Controls.Add(Me.cmdCancel)
        Me.pnlConfiguration.Controls.Add(Me.cmdOkay)
        Me.pnlConfiguration.Controls.Add(Me.sFive)
        Me.pnlConfiguration.Location = New System.Drawing.Point(8, 518)
        Me.pnlConfiguration.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlConfiguration.Name = "pnlConfiguration"
        Me.pnlConfiguration.Size = New System.Drawing.Size(472, 100)
        Me.pnlConfiguration.TabIndex = 123
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdApply.FlatAppearance.BorderSize = 0
        Me.cmdApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 19)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Cancel or save your changes"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
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
        Me.cmdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdOkay.FlatAppearance.BorderSize = 0
        Me.cmdOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
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
        'sFive
        '
        Me.sFive.AutoSize = True
        Me.sFive.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFive.ForeColor = System.Drawing.Color.White
        Me.sFive.Location = New System.Drawing.Point(10, 8)
        Me.sFive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFive.Name = "sFive"
        Me.sFive.Size = New System.Drawing.Size(116, 23)
        Me.sFive.TabIndex = 90
        Me.sFive.Text = "Configuration"
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
        Me.ClientSize = New System.Drawing.Size(490, 670)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(490, 670)
        Me.MinimumSize = New System.Drawing.Size(490, 670)
        Me.Name = "FormSettings"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAssessmentStyle.ResumeLayout(False)
        Me.pnlAssessmentStyle.PerformLayout()
        Me.pnlShowHardware.ResumeLayout(False)
        Me.pnlShowHardware.PerformLayout()
        Me.pnlPortability.ResumeLayout(False)
        Me.pnlPortability.PerformLayout()
        Me.pnlTheme.ResumeLayout(False)
        Me.pnlTheme.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlConfiguration.ResumeLayout(False)
        Me.pnlConfiguration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents sThree As System.Windows.Forms.Label
    Friend WithEvents rbnThemeDef0 As GambolRadioButton
    Friend WithEvents rbnThemeSky1 As GambolRadioButton
    Friend WithEvents rbnThemeTurq2 As GambolRadioButton
    Friend WithEvents rbnThemeEmerald3 As GambolRadioButton
    Friend WithEvents rbnThemeAmethyst4 As GambolRadioButton
    Friend WithEvents sOne As System.Windows.Forms.Label
    Friend WithEvents rbnHardwareEnable As GambolRadioButton
    Friend WithEvents rbnHardwareDisable As GambolRadioButton
    Friend WithEvents pnlAssessmentStyle As System.Windows.Forms.Panel
    Friend WithEvents pnlShowHardware As System.Windows.Forms.Panel
    Friend WithEvents pnlPortability As System.Windows.Forms.Panel
    Friend WithEvents rbnVerbose As GambolRadioButton
    Friend WithEvents rbnNormal As GambolRadioButton
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents pnlTheme As System.Windows.Forms.Panel
    Friend WithEvents sFour As System.Windows.Forms.Label
    Friend WithEvents sEight As System.Windows.Forms.Label
    Friend WithEvents sSeven As System.Windows.Forms.Label
    Friend WithEvents cbxApplyToBorder As GambolCheckbox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents sNine As System.Windows.Forms.Label
    Friend WithEvents rbnThemeCarrot5 As GambolRadioButton
    Friend WithEvents rbnThemeSun6 As GambolRadioButton
    Friend WithEvents rbnThemeAlazarin7 As GambolRadioButton
    Friend WithEvents rbnAppath As GambolRadioButton
    Friend WithEvents rbnAppdata As GambolRadioButton
    Friend WithEvents sTen As System.Windows.Forms.Label
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlConfiguration As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOkay As System.Windows.Forms.Button
    Friend WithEvents sFive As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents cmdWarn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbnXml As GambolRadioButton
    Friend WithEvents rbnApi As GambolRadioButton
End Class
