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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.sThree = New System.Windows.Forms.Label()
        Me.sOne = New System.Windows.Forms.Label()
        Me.pnlAssessmentMode = New System.Windows.Forms.Panel()
        Me.rbnVerbose = New Gambol.Controls.GambolRadioButton()
        Me.rbnNormal = New Gambol.Controls.GambolRadioButton()
        Me.sTwo = New System.Windows.Forms.Label()
        Me.pnlHardwareStartup = New System.Windows.Forms.Panel()
        Me.rbnHardwareDisable = New Gambol.Controls.GambolRadioButton()
        Me.rbnHardwareEnable = New Gambol.Controls.GambolRadioButton()
        Me.pnlPortability = New System.Windows.Forms.Panel()
        Me.cmdWarn = New System.Windows.Forms.Button()
        Me.rbnAppath = New Gambol.Controls.GambolRadioButton()
        Me.rbnAppdata = New Gambol.Controls.GambolRadioButton()
        Me.sFour = New System.Windows.Forms.Label()
        Me.pnlThemeColor = New System.Windows.Forms.Panel()
        Me.rbnThemeCarrot5 = New Gambol.Controls.GambolRadioButton()
        Me.rbnThemeSun6 = New Gambol.Controls.GambolRadioButton()
        Me.rbnThemeAlazarin7 = New Gambol.Controls.GambolRadioButton()
        Me.cbxApplyToBorder = New Gambol.Controls.GambolCheckbox()
        Me.rbnThemeDef0 = New Gambol.Controls.GambolRadioButton()
        Me.rbnThemeAmethyst4 = New Gambol.Controls.GambolRadioButton()
        Me.rbnThemeSky1 = New Gambol.Controls.GambolRadioButton()
        Me.rbnThemeTurq2 = New Gambol.Controls.GambolRadioButton()
        Me.rbnThemeEmerald3 = New Gambol.Controls.GambolRadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tlpText = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxClientId = New System.Windows.Forms.TextBox()
        Me.rbnClientDisable = New Gambol.Controls.GambolRadioButton()
        Me.rbnClientEnable = New Gambol.Controls.GambolRadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlDefaultHardware = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbnXml = New Gambol.Controls.GambolRadioButton()
        Me.rbnApi = New Gambol.Controls.GambolRadioButton()
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
        Me.pnlAssessmentMode.SuspendLayout()
        Me.pnlHardwareStartup.SuspendLayout()
        Me.pnlPortability.SuspendLayout()
        Me.pnlThemeColor.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tlpText.SuspendLayout()
        Me.pnlDefaultHardware.SuspendLayout()
        Me.pnlConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = CType(resources.GetObject("pnlHead.BackgroundImage"), System.Drawing.Image)
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
        'sThree
        '
        Me.sThree.AutoSize = True
        Me.sThree.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sThree.ForeColor = System.Drawing.Color.White
        Me.sThree.Location = New System.Drawing.Point(8, 6)
        Me.sThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sThree.Name = "sThree"
        Me.sThree.Size = New System.Drawing.Size(94, 20)
        Me.sThree.TabIndex = 89
        Me.sThree.Text = "Theme color"
        '
        'sOne
        '
        Me.sOne.AutoSize = True
        Me.sOne.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOne.ForeColor = System.Drawing.Color.White
        Me.sOne.Location = New System.Drawing.Point(8, 6)
        Me.sOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sOne.Name = "sOne"
        Me.sOne.Size = New System.Drawing.Size(189, 20)
        Me.sOne.TabIndex = 107
        Me.sOne.Text = "Show hardware on startup"
        '
        'pnlAssessmentMode
        '
        Me.pnlAssessmentMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAssessmentMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlAssessmentMode.Controls.Add(Me.rbnVerbose)
        Me.pnlAssessmentMode.Controls.Add(Me.rbnNormal)
        Me.pnlAssessmentMode.Controls.Add(Me.sTwo)
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
        'sTwo
        '
        Me.sTwo.AutoSize = True
        Me.sTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTwo.ForeColor = System.Drawing.Color.White
        Me.sTwo.Location = New System.Drawing.Point(8, 6)
        Me.sTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sTwo.Name = "sTwo"
        Me.sTwo.Size = New System.Drawing.Size(181, 20)
        Me.sTwo.TabIndex = 108
        Me.sTwo.Text = "Default assessment mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlHardwareStartup
        '
        Me.pnlHardwareStartup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlHardwareStartup.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlHardwareStartup.Controls.Add(Me.sOne)
        Me.pnlHardwareStartup.Controls.Add(Me.rbnHardwareDisable)
        Me.pnlHardwareStartup.Controls.Add(Me.rbnHardwareEnable)
        Me.pnlHardwareStartup.Location = New System.Drawing.Point(8, 8)
        Me.pnlHardwareStartup.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlHardwareStartup.Name = "pnlHardwareStartup"
        Me.pnlHardwareStartup.Size = New System.Drawing.Size(472, 70)
        Me.pnlHardwareStartup.TabIndex = 119
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
        Me.pnlPortability.Controls.Add(Me.sFour)
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
        'sFour
        '
        Me.sFour.AutoSize = True
        Me.sFour.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFour.ForeColor = System.Drawing.Color.White
        Me.sFour.Location = New System.Drawing.Point(10, 8)
        Me.sFour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFour.Name = "sFour"
        Me.sFour.Size = New System.Drawing.Size(122, 20)
        Me.sFour.TabIndex = 89
        Me.sFour.Text = "Portability mode"
        '
        'pnlThemeColor
        '
        Me.pnlThemeColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlThemeColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeCarrot5)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeSun6)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeAlazarin7)
        Me.pnlThemeColor.Controls.Add(Me.cbxApplyToBorder)
        Me.pnlThemeColor.Controls.Add(Me.sThree)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeDef0)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeAmethyst4)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeSky1)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeTurq2)
        Me.pnlThemeColor.Controls.Add(Me.rbnThemeEmerald3)
        Me.pnlThemeColor.Location = New System.Drawing.Point(8, 224)
        Me.pnlThemeColor.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlThemeColor.Name = "pnlThemeColor"
        Me.pnlThemeColor.Size = New System.Drawing.Size(472, 70)
        Me.pnlThemeColor.TabIndex = 122
        '
        'rbnThemeCarrot5
        '
        Me.rbnThemeCarrot5.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeCarrot5.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeCarrot5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeCarrot5.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.rbnThemeCarrot5.ForeColor = System.Drawing.Color.White
        Me.rbnThemeCarrot5.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeCarrot5.Location = New System.Drawing.Point(153, 36)
        Me.rbnThemeCarrot5.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeCarrot5.Name = "rbnThemeCarrot5"
        Me.rbnThemeCarrot5.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeCarrot5.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeCarrot5.TabIndex = 120
        '
        'rbnThemeSun6
        '
        Me.rbnThemeSun6.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeSun6.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeSun6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeSun6.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.rbnThemeSun6.ForeColor = System.Drawing.Color.White
        Me.rbnThemeSun6.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeSun6.Location = New System.Drawing.Point(180, 36)
        Me.rbnThemeSun6.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeSun6.Name = "rbnThemeSun6"
        Me.rbnThemeSun6.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeSun6.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeSun6.TabIndex = 121
        '
        'rbnThemeAlazarin7
        '
        Me.rbnThemeAlazarin7.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeAlazarin7.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeAlazarin7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeAlazarin7.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.rbnThemeAlazarin7.ForeColor = System.Drawing.Color.White
        Me.rbnThemeAlazarin7.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeAlazarin7.Location = New System.Drawing.Point(207, 36)
        Me.rbnThemeAlazarin7.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeAlazarin7.Name = "rbnThemeAlazarin7"
        Me.rbnThemeAlazarin7.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeAlazarin7.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeAlazarin7.TabIndex = 122
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
        Me.cbxApplyToBorder.Location = New System.Drawing.Point(249, 36)
        Me.cbxApplyToBorder.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxApplyToBorder.Name = "cbxApplyToBorder"
        Me.cbxApplyToBorder.Size = New System.Drawing.Size(146, 22)
        Me.cbxApplyToBorder.TabIndex = 119
        Me.cbxApplyToBorder.Text = "Apply to Borders"
        Me.cbxApplyToBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbnThemeDef0
        '
        Me.rbnThemeDef0.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeDef0.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeDef0.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeDef0.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbnThemeDef0.ForeColor = System.Drawing.Color.White
        Me.rbnThemeDef0.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeDef0.Location = New System.Drawing.Point(19, 36)
        Me.rbnThemeDef0.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeDef0.Name = "rbnThemeDef0"
        Me.rbnThemeDef0.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeDef0.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeDef0.TabIndex = 90
        '
        'rbnThemeAmethyst4
        '
        Me.rbnThemeAmethyst4.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeAmethyst4.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeAmethyst4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeAmethyst4.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.rbnThemeAmethyst4.ForeColor = System.Drawing.Color.White
        Me.rbnThemeAmethyst4.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeAmethyst4.Location = New System.Drawing.Point(127, 36)
        Me.rbnThemeAmethyst4.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeAmethyst4.Name = "rbnThemeAmethyst4"
        Me.rbnThemeAmethyst4.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeAmethyst4.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeAmethyst4.TabIndex = 102
        '
        'rbnThemeSky1
        '
        Me.rbnThemeSky1.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeSky1.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeSky1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeSky1.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rbnThemeSky1.ForeColor = System.Drawing.Color.White
        Me.rbnThemeSky1.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeSky1.Location = New System.Drawing.Point(46, 36)
        Me.rbnThemeSky1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeSky1.Name = "rbnThemeSky1"
        Me.rbnThemeSky1.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeSky1.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeSky1.TabIndex = 91
        '
        'rbnThemeTurq2
        '
        Me.rbnThemeTurq2.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeTurq2.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeTurq2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeTurq2.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.rbnThemeTurq2.ForeColor = System.Drawing.Color.White
        Me.rbnThemeTurq2.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeTurq2.Location = New System.Drawing.Point(73, 36)
        Me.rbnThemeTurq2.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeTurq2.Name = "rbnThemeTurq2"
        Me.rbnThemeTurq2.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeTurq2.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeTurq2.TabIndex = 92
        '
        'rbnThemeEmerald3
        '
        Me.rbnThemeEmerald3.ActiveBorderColor = System.Drawing.Color.White
        Me.rbnThemeEmerald3.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.rbnThemeEmerald3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rbnThemeEmerald3.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.rbnThemeEmerald3.ForeColor = System.Drawing.Color.White
        Me.rbnThemeEmerald3.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbnThemeEmerald3.Location = New System.Drawing.Point(100, 36)
        Me.rbnThemeEmerald3.Margin = New System.Windows.Forms.Padding(2)
        Me.rbnThemeEmerald3.Name = "rbnThemeEmerald3"
        Me.rbnThemeEmerald3.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbnThemeEmerald3.Size = New System.Drawing.Size(22, 22)
        Me.rbnThemeEmerald3.TabIndex = 93
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel7.Controls.Add(Me.tlpMain)
        Me.Panel7.Controls.Add(Me.pnlSplit)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 41)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(488, 550)
        Me.Panel7.TabIndex = 124
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.Panel2, 0, 5)
        Me.tlpMain.Controls.Add(Me.pnlDefaultHardware, 0, 1)
        Me.tlpMain.Controls.Add(Me.pnlHardwareStartup, 0, 0)
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
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tlpText)
        Me.Panel2.Controls.Add(Me.rbnClientDisable)
        Me.Panel2.Controls.Add(Me.rbnClientEnable)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(8, 368)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 70)
        Me.Panel2.TabIndex = 124
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 20)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Use custom Imgur Client ID"
        '
        'pnlDefaultHardware
        '
        Me.pnlDefaultHardware.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlDefaultHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlDefaultHardware.Controls.Add(Me.Label3)
        Me.pnlDefaultHardware.Controls.Add(Me.rbnXml)
        Me.pnlDefaultHardware.Controls.Add(Me.rbnApi)
        Me.pnlDefaultHardware.Location = New System.Drawing.Point(8, 80)
        Me.pnlDefaultHardware.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlDefaultHardware.Name = "pnlDefaultHardware"
        Me.pnlDefaultHardware.Size = New System.Drawing.Size(472, 70)
        Me.pnlDefaultHardware.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Default hardware mode"
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
        Me.pnlConfiguration.Controls.Add(Me.Label1)
        Me.pnlConfiguration.Controls.Add(Me.cmdCancel)
        Me.pnlConfiguration.Controls.Add(Me.cmdOkay)
        Me.pnlConfiguration.Controls.Add(Me.sFive)
        Me.pnlConfiguration.Location = New System.Drawing.Point(8, 440)
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
        Me.cmdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
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
        'sFive
        '
        Me.sFive.AutoSize = True
        Me.sFive.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFive.ForeColor = System.Drawing.Color.White
        Me.sFive.Location = New System.Drawing.Point(10, 8)
        Me.sFive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sFive.Name = "sFive"
        Me.sFive.Size = New System.Drawing.Size(104, 20)
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
        Me.ClientSize = New System.Drawing.Size(490, 592)
        Me.Controls.Add(Me.Panel7)
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
        Me.pnlHardwareStartup.ResumeLayout(False)
        Me.pnlHardwareStartup.PerformLayout()
        Me.pnlPortability.ResumeLayout(False)
        Me.pnlPortability.PerformLayout()
        Me.pnlThemeColor.ResumeLayout(False)
        Me.pnlThemeColor.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tlpText.ResumeLayout(False)
        Me.tlpText.PerformLayout()
        Me.pnlDefaultHardware.ResumeLayout(False)
        Me.pnlDefaultHardware.PerformLayout()
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
    Friend WithEvents pnlAssessmentMode As System.Windows.Forms.Panel
    Friend WithEvents pnlHardwareStartup As System.Windows.Forms.Panel
    Friend WithEvents pnlPortability As System.Windows.Forms.Panel
    Friend WithEvents rbnVerbose As GambolRadioButton
    Friend WithEvents rbnNormal As GambolRadioButton
    Friend WithEvents sTwo As System.Windows.Forms.Label
    Friend WithEvents pnlThemeColor As System.Windows.Forms.Panel
    Friend WithEvents sFour As System.Windows.Forms.Label
    Friend WithEvents cbxApplyToBorder As GambolCheckbox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents rbnThemeCarrot5 As GambolRadioButton
    Friend WithEvents rbnThemeSun6 As GambolRadioButton
    Friend WithEvents rbnThemeAlazarin7 As GambolRadioButton
    Friend WithEvents rbnAppath As GambolRadioButton
    Friend WithEvents rbnAppdata As GambolRadioButton
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlConfiguration As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOkay As System.Windows.Forms.Button
    Friend WithEvents sFive As System.Windows.Forms.Label
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents cmdWarn As System.Windows.Forms.Button
    Friend WithEvents pnlDefaultHardware As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbnXml As GambolRadioButton
    Friend WithEvents rbnApi As GambolRadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxClientId As TextBox
    Friend WithEvents rbnClientDisable As GambolRadioButton
    Friend WithEvents rbnClientEnable As GambolRadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents tlpText As TableLayoutPanel
End Class
