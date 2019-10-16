Imports Xiret.Controls

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
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.PanAssessmentMode = New System.Windows.Forms.Panel()
        Me.sDefaultAss = New System.Windows.Forms.Label()
        Me.sInfoAssessment = New System.Windows.Forms.Label()
        Me.RadAssessmentVerbose = New Controls.GambolRadioButton()
        Me.RadAssessmentNormal = New Controls.GambolRadioButton()
        Me.PanPortability = New System.Windows.Forms.Panel()
        Me.sPortabilityInfo = New System.Windows.Forms.Label()
        Me.CmdWarn = New System.Windows.Forms.Button()
        Me.RadPortabilityOn = New Controls.GambolRadioButton()
        Me.RadPortabilityOff = New Controls.GambolRadioButton()
        Me.sPortability = New System.Windows.Forms.Label()
        Me.PanThemeColor = New System.Windows.Forms.Panel()
        Me.sTheme = New System.Windows.Forms.Label()
        Me.sThemeInfo = New System.Windows.Forms.Label()
        Me.RadPink5 = New Controls.GambolRadioButton()
        Me.RadCarrot6 = New Controls.GambolRadioButton()
        Me.RadYellow7 = New Controls.GambolRadioButton()
        Me.RadAlazarin8 = New Controls.GambolRadioButton()
        Me.CbxApplyToBorder = New Controls.GambolCheckbox()
        Me.RadDefault0 = New Controls.GambolRadioButton()
        Me.RadMegenta4 = New Controls.GambolRadioButton()
        Me.RadSky1 = New Controls.GambolRadioButton()
        Me.RadTurquoise2 = New Controls.GambolRadioButton()
        Me.RadEmerald3 = New Controls.GambolRadioButton()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.PanShowHardware = New System.Windows.Forms.Panel()
        Me.sStartup = New System.Windows.Forms.Label()
        Me.RadHardwareDisable = New Controls.GambolRadioButton()
        Me.RadHardwareEnable = New Controls.GambolRadioButton()
        Me.PanHardwareMode = New System.Windows.Forms.Panel()
        Me.sHardwareMode = New System.Windows.Forms.Label()
        Me.RadHardwaremodeXml = New Controls.GambolRadioButton()
        Me.RadHardwaremodeApi = New Controls.GambolRadioButton()
        Me.PanImgur = New System.Windows.Forms.Panel()
        Me.sImgur = New System.Windows.Forms.Label()
        Me.sImgurInfo = New System.Windows.Forms.Label()
        Me.TlpText = New System.Windows.Forms.TableLayoutPanel()
        Me.TbxClientId = New System.Windows.Forms.TextBox()
        Me.RadCustomClientOff = New Controls.GambolRadioButton()
        Me.RadCustomClientOn = New Controls.GambolRadioButton()
        Me.PanConfig = New System.Windows.Forms.Panel()
        Me.sConfig = New System.Windows.Forms.Label()
        Me.CmdApply = New System.Windows.Forms.Button()
        Me.sConfigInfo = New System.Windows.Forms.Label()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOkay = New System.Windows.Forms.Button()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanAssessmentMode.SuspendLayout()
        Me.PanPortability.SuspendLayout()
        Me.PanThemeColor.SuspendLayout()
        Me.PanMain.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        Me.PanShowHardware.SuspendLayout()
        Me.PanHardwareMode.SuspendLayout()
        Me.PanImgur.SuspendLayout()
        Me.TlpText.SuspendLayout()
        Me.PanConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanHead.BackgroundImage = CType(resources.GetObject("PanHead.BackgroundImage"), System.Drawing.Image)
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(2)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(496, 40)
        Me.PanHead.TabIndex = 0
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
        Me.CmdClose.Location = New System.Drawing.Point(456, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 71
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
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
        Me.TlpHeadImage.TabIndex = 73
        '
        'PbxHead
        '
        Me.PbxHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxHead.BackColor = System.Drawing.Color.Transparent
        Me.PbxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxHead.Image = CType(resources.GetObject("PbxHead.Image"), System.Drawing.Image)
        Me.PbxHead.Location = New System.Drawing.Point(9, 8)
        Me.PbxHead.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PbxHead.Name = "PbxHead"
        Me.PbxHead.Size = New System.Drawing.Size(24, 24)
        Me.PbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHead.TabIndex = 1
        Me.PbxHead.TabStop = False
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
        Me.LabHead.Size = New System.Drawing.Size(416, 40)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "Settings"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAssessmentMode
        '
        Me.PanAssessmentMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanAssessmentMode.Controls.Add(Me.sDefaultAss)
        Me.PanAssessmentMode.Controls.Add(Me.sInfoAssessment)
        Me.PanAssessmentMode.Controls.Add(Me.RadAssessmentVerbose)
        Me.PanAssessmentMode.Controls.Add(Me.RadAssessmentNormal)
        Me.PanAssessmentMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanAssessmentMode.Location = New System.Drawing.Point(0, 72)
        Me.PanAssessmentMode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanAssessmentMode.Name = "PanAssessmentMode"
        Me.PanAssessmentMode.Size = New System.Drawing.Size(482, 90)
        Me.PanAssessmentMode.TabIndex = 0
        '
        'sDefaultAss
        '
        Me.sDefaultAss.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sDefaultAss.Dock = System.Windows.Forms.DockStyle.Top
        Me.sDefaultAss.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sDefaultAss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sDefaultAss.Location = New System.Drawing.Point(0, 0)
        Me.sDefaultAss.Margin = New System.Windows.Forms.Padding(0)
        Me.sDefaultAss.Name = "sDefaultAss"
        Me.sDefaultAss.Size = New System.Drawing.Size(482, 24)
        Me.sDefaultAss.TabIndex = 118
        Me.sDefaultAss.Text = "Default Assessment Mode"
        Me.sDefaultAss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sInfoAssessment
        '
        Me.sInfoAssessment.AutoSize = True
        Me.sInfoAssessment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sInfoAssessment.Location = New System.Drawing.Point(4, 28)
        Me.sInfoAssessment.Name = "sInfoAssessment"
        Me.sInfoAssessment.Size = New System.Drawing.Size(259, 19)
        Me.sInfoAssessment.TabIndex = 0
        Me.sInfoAssessment.Text = "In-depth mode enables real time logging"
        '
        'RadAssessmentVerbose
        '
        Me.RadAssessmentVerbose.ActiveBorderColor = System.Drawing.Color.White
        Me.RadAssessmentVerbose.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadAssessmentVerbose.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadAssessmentVerbose.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.RadAssessmentVerbose.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadAssessmentVerbose.Location = New System.Drawing.Point(107, 56)
        Me.RadAssessmentVerbose.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAssessmentVerbose.Name = "RadAssessmentVerbose"
        Me.RadAssessmentVerbose.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadAssessmentVerbose.Size = New System.Drawing.Size(92, 22)
        Me.RadAssessmentVerbose.TabIndex = 115
        Me.RadAssessmentVerbose.Text = "In-depth"
        '
        'RadAssessmentNormal
        '
        Me.RadAssessmentNormal.ActiveBorderColor = System.Drawing.Color.White
        Me.RadAssessmentNormal.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadAssessmentNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadAssessmentNormal.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.RadAssessmentNormal.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadAssessmentNormal.Location = New System.Drawing.Point(14, 56)
        Me.RadAssessmentNormal.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAssessmentNormal.Name = "RadAssessmentNormal"
        Me.RadAssessmentNormal.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadAssessmentNormal.Size = New System.Drawing.Size(89, 22)
        Me.RadAssessmentNormal.TabIndex = 116
        Me.RadAssessmentNormal.Text = "Normal"
        '
        'PanPortability
        '
        Me.PanPortability.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanPortability.Controls.Add(Me.sPortabilityInfo)
        Me.PanPortability.Controls.Add(Me.CmdWarn)
        Me.PanPortability.Controls.Add(Me.RadPortabilityOn)
        Me.PanPortability.Controls.Add(Me.RadPortabilityOff)
        Me.PanPortability.Controls.Add(Me.sPortability)
        Me.PanPortability.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanPortability.Location = New System.Drawing.Point(0, 254)
        Me.PanPortability.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanPortability.Name = "PanPortability"
        Me.PanPortability.Size = New System.Drawing.Size(482, 90)
        Me.PanPortability.TabIndex = 0
        '
        'sPortabilityInfo
        '
        Me.sPortabilityInfo.AutoSize = True
        Me.sPortabilityInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sPortabilityInfo.Location = New System.Drawing.Point(4, 28)
        Me.sPortabilityInfo.Name = "sPortabilityInfo"
        Me.sPortabilityInfo.Size = New System.Drawing.Size(250, 19)
        Me.sPortabilityInfo.TabIndex = 0
        Me.sPortabilityInfo.Text = "Change where the settings file is stored"
        '
        'CmdWarn
        '
        Me.CmdWarn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CmdWarn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdWarn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdWarn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CmdWarn.FlatAppearance.BorderSize = 0
        Me.CmdWarn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmdWarn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmdWarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdWarn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdWarn.ForeColor = System.Drawing.Color.Tomato
        Me.CmdWarn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdWarn.Location = New System.Drawing.Point(384, 49)
        Me.CmdWarn.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdWarn.Name = "CmdWarn"
        Me.CmdWarn.Size = New System.Drawing.Size(86, 30)
        Me.CmdWarn.TabIndex = 99
        Me.CmdWarn.Text = "1 Warning"
        Me.CmdWarn.UseVisualStyleBackColor = False
        '
        'RadPortabilityOn
        '
        Me.RadPortabilityOn.ActiveBorderColor = System.Drawing.Color.White
        Me.RadPortabilityOn.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadPortabilityOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadPortabilityOn.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadPortabilityOn.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadPortabilityOn.Location = New System.Drawing.Point(148, 57)
        Me.RadPortabilityOn.Margin = New System.Windows.Forms.Padding(2)
        Me.RadPortabilityOn.Name = "RadPortabilityOn"
        Me.RadPortabilityOn.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadPortabilityOn.Size = New System.Drawing.Size(184, 22)
        Me.RadPortabilityOn.TabIndex = 126
        Me.RadPortabilityOn.Text = "On (Application Path)"
        '
        'RadPortabilityOff
        '
        Me.RadPortabilityOff.ActiveBorderColor = System.Drawing.Color.White
        Me.RadPortabilityOff.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadPortabilityOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadPortabilityOff.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadPortabilityOff.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadPortabilityOff.Location = New System.Drawing.Point(14, 56)
        Me.RadPortabilityOff.Margin = New System.Windows.Forms.Padding(2)
        Me.RadPortabilityOff.Name = "RadPortabilityOff"
        Me.RadPortabilityOff.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadPortabilityOff.Size = New System.Drawing.Size(130, 22)
        Me.RadPortabilityOff.TabIndex = 117
        Me.RadPortabilityOff.Text = "Off (Appdata)"
        '
        'sPortability
        '
        Me.sPortability.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sPortability.Dock = System.Windows.Forms.DockStyle.Top
        Me.sPortability.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sPortability.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sPortability.Location = New System.Drawing.Point(0, 0)
        Me.sPortability.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sPortability.Name = "sPortability"
        Me.sPortability.Size = New System.Drawing.Size(482, 24)
        Me.sPortability.TabIndex = 89
        Me.sPortability.Text = "Portability Mode"
        Me.sPortability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanThemeColor
        '
        Me.PanThemeColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanThemeColor.Controls.Add(Me.sTheme)
        Me.PanThemeColor.Controls.Add(Me.sThemeInfo)
        Me.PanThemeColor.Controls.Add(Me.RadPink5)
        Me.PanThemeColor.Controls.Add(Me.RadCarrot6)
        Me.PanThemeColor.Controls.Add(Me.RadYellow7)
        Me.PanThemeColor.Controls.Add(Me.RadAlazarin8)
        Me.PanThemeColor.Controls.Add(Me.CbxApplyToBorder)
        Me.PanThemeColor.Controls.Add(Me.RadDefault0)
        Me.PanThemeColor.Controls.Add(Me.RadMegenta4)
        Me.PanThemeColor.Controls.Add(Me.RadSky1)
        Me.PanThemeColor.Controls.Add(Me.RadTurquoise2)
        Me.PanThemeColor.Controls.Add(Me.RadEmerald3)
        Me.PanThemeColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanThemeColor.Location = New System.Drawing.Point(0, 163)
        Me.PanThemeColor.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanThemeColor.Name = "PanThemeColor"
        Me.PanThemeColor.Size = New System.Drawing.Size(482, 90)
        Me.PanThemeColor.TabIndex = 0
        '
        'sTheme
        '
        Me.sTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sTheme.Dock = System.Windows.Forms.DockStyle.Top
        Me.sTheme.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTheme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sTheme.Location = New System.Drawing.Point(0, 0)
        Me.sTheme.Margin = New System.Windows.Forms.Padding(0)
        Me.sTheme.Name = "sTheme"
        Me.sTheme.Size = New System.Drawing.Size(482, 24)
        Me.sTheme.TabIndex = 124
        Me.sTheme.Text = "Theme Color"
        Me.sTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sThemeInfo
        '
        Me.sThemeInfo.AutoSize = True
        Me.sThemeInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sThemeInfo.Location = New System.Drawing.Point(4, 28)
        Me.sThemeInfo.Name = "sThemeInfo"
        Me.sThemeInfo.Size = New System.Drawing.Size(227, 19)
        Me.sThemeInfo.TabIndex = 0
        Me.sThemeInfo.Text = "Change the application accent color"
        '
        'RadPink5
        '
        Me.RadPink5.ActiveBorderColor = System.Drawing.Color.White
        Me.RadPink5.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadPink5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadPink5.CheckedColor = System.Drawing.Color.HotPink
        Me.RadPink5.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadPink5.Location = New System.Drawing.Point(148, 56)
        Me.RadPink5.Margin = New System.Windows.Forms.Padding(2)
        Me.RadPink5.Name = "RadPink5"
        Me.RadPink5.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadPink5.Size = New System.Drawing.Size(22, 22)
        Me.RadPink5.TabIndex = 123
        '
        'RadCarrot6
        '
        Me.RadCarrot6.ActiveBorderColor = System.Drawing.Color.White
        Me.RadCarrot6.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadCarrot6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadCarrot6.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadCarrot6.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadCarrot6.Location = New System.Drawing.Point(174, 56)
        Me.RadCarrot6.Margin = New System.Windows.Forms.Padding(2)
        Me.RadCarrot6.Name = "RadCarrot6"
        Me.RadCarrot6.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadCarrot6.Size = New System.Drawing.Size(22, 22)
        Me.RadCarrot6.TabIndex = 120
        '
        'RadYellow7
        '
        Me.RadYellow7.ActiveBorderColor = System.Drawing.Color.White
        Me.RadYellow7.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadYellow7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadYellow7.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.RadYellow7.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadYellow7.Location = New System.Drawing.Point(200, 56)
        Me.RadYellow7.Margin = New System.Windows.Forms.Padding(2)
        Me.RadYellow7.Name = "RadYellow7"
        Me.RadYellow7.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadYellow7.Size = New System.Drawing.Size(22, 22)
        Me.RadYellow7.TabIndex = 121
        '
        'RadAlazarin8
        '
        Me.RadAlazarin8.ActiveBorderColor = System.Drawing.Color.White
        Me.RadAlazarin8.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadAlazarin8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadAlazarin8.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadAlazarin8.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadAlazarin8.Location = New System.Drawing.Point(227, 56)
        Me.RadAlazarin8.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAlazarin8.Name = "RadAlazarin8"
        Me.RadAlazarin8.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadAlazarin8.Size = New System.Drawing.Size(22, 22)
        Me.RadAlazarin8.TabIndex = 122
        '
        'CbxApplyToBorder
        '
        Me.CbxApplyToBorder.ActiveBorderColor = System.Drawing.Color.White
        Me.CbxApplyToBorder.ActiveCheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CbxApplyToBorder.AutoSize = True
        Me.CbxApplyToBorder.CheckboxBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CbxApplyToBorder.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CbxApplyToBorder.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CbxApplyToBorder.Location = New System.Drawing.Point(271, 56)
        Me.CbxApplyToBorder.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxApplyToBorder.Name = "CbxApplyToBorder"
        Me.CbxApplyToBorder.Size = New System.Drawing.Size(153, 23)
        Me.CbxApplyToBorder.TabIndex = 119
        Me.CbxApplyToBorder.Text = "Apply to Borders"
        Me.CbxApplyToBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadDefault0
        '
        Me.RadDefault0.ActiveBorderColor = System.Drawing.Color.White
        Me.RadDefault0.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadDefault0.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadDefault0.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadDefault0.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadDefault0.Location = New System.Drawing.Point(14, 56)
        Me.RadDefault0.Margin = New System.Windows.Forms.Padding(2)
        Me.RadDefault0.Name = "RadDefault0"
        Me.RadDefault0.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadDefault0.Size = New System.Drawing.Size(22, 22)
        Me.RadDefault0.TabIndex = 90
        '
        'RadMegenta4
        '
        Me.RadMegenta4.ActiveBorderColor = System.Drawing.Color.White
        Me.RadMegenta4.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadMegenta4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadMegenta4.CheckedColor = System.Drawing.Color.Magenta
        Me.RadMegenta4.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadMegenta4.Location = New System.Drawing.Point(122, 56)
        Me.RadMegenta4.Margin = New System.Windows.Forms.Padding(2)
        Me.RadMegenta4.Name = "RadMegenta4"
        Me.RadMegenta4.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadMegenta4.Size = New System.Drawing.Size(22, 22)
        Me.RadMegenta4.TabIndex = 102
        '
        'RadSky1
        '
        Me.RadSky1.ActiveBorderColor = System.Drawing.Color.White
        Me.RadSky1.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadSky1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadSky1.CheckedColor = System.Drawing.Color.DeepSkyBlue
        Me.RadSky1.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadSky1.Location = New System.Drawing.Point(41, 56)
        Me.RadSky1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadSky1.Name = "RadSky1"
        Me.RadSky1.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadSky1.Size = New System.Drawing.Size(22, 22)
        Me.RadSky1.TabIndex = 91
        '
        'RadTurquoise2
        '
        Me.RadTurquoise2.ActiveBorderColor = System.Drawing.Color.White
        Me.RadTurquoise2.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadTurquoise2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadTurquoise2.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.RadTurquoise2.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadTurquoise2.Location = New System.Drawing.Point(68, 56)
        Me.RadTurquoise2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadTurquoise2.Name = "RadTurquoise2"
        Me.RadTurquoise2.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadTurquoise2.Size = New System.Drawing.Size(22, 22)
        Me.RadTurquoise2.TabIndex = 92
        '
        'RadEmerald3
        '
        Me.RadEmerald3.ActiveBorderColor = System.Drawing.Color.White
        Me.RadEmerald3.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadEmerald3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadEmerald3.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RadEmerald3.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadEmerald3.Location = New System.Drawing.Point(95, 56)
        Me.RadEmerald3.Margin = New System.Windows.Forms.Padding(2)
        Me.RadEmerald3.Name = "RadEmerald3"
        Me.RadEmerald3.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadEmerald3.Size = New System.Drawing.Size(22, 22)
        Me.RadEmerald3.TabIndex = 93
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpMain)
        Me.PanMain.Controls.Add(Me.PanSplit)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 41)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(496, 557)
        Me.PanMain.TabIndex = 124
        '
        'TlpMain
        '
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.Controls.Add(Me.TlpTop, 0, 0)
        Me.TlpMain.Controls.Add(Me.PanAssessmentMode, 0, 1)
        Me.TlpMain.Controls.Add(Me.PanThemeColor, 0, 2)
        Me.TlpMain.Controls.Add(Me.PanPortability, 0, 3)
        Me.TlpMain.Controls.Add(Me.PanImgur, 0, 4)
        Me.TlpMain.Controls.Add(Me.PanConfig, 0, 5)
        Me.TlpMain.Location = New System.Drawing.Point(7, 9)
        Me.TlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.RowCount = 6
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TlpMain.Size = New System.Drawing.Size(482, 541)
        Me.TlpMain.TabIndex = 127
        '
        'TlpTop
        '
        Me.TlpTop.ColumnCount = 2
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpTop.Controls.Add(Me.PanShowHardware, 0, 0)
        Me.TlpTop.Controls.Add(Me.PanHardwareMode, 1, 0)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpTop.Location = New System.Drawing.Point(0, 0)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpTop.Size = New System.Drawing.Size(482, 72)
        Me.TlpTop.TabIndex = 125
        '
        'PanShowHardware
        '
        Me.PanShowHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanShowHardware.Controls.Add(Me.sStartup)
        Me.PanShowHardware.Controls.Add(Me.RadHardwareDisable)
        Me.PanShowHardware.Controls.Add(Me.RadHardwareEnable)
        Me.PanShowHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanShowHardware.Location = New System.Drawing.Point(0, 0)
        Me.PanShowHardware.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanShowHardware.Name = "PanShowHardware"
        Me.PanShowHardware.Size = New System.Drawing.Size(240, 71)
        Me.PanShowHardware.TabIndex = 0
        '
        'sStartup
        '
        Me.sStartup.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sStartup.Dock = System.Windows.Forms.DockStyle.Top
        Me.sStartup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sStartup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sStartup.Location = New System.Drawing.Point(0, 0)
        Me.sStartup.Margin = New System.Windows.Forms.Padding(0)
        Me.sStartup.Name = "sStartup"
        Me.sStartup.Size = New System.Drawing.Size(240, 24)
        Me.sStartup.TabIndex = 114
        Me.sStartup.Text = "Show Hardware on Startup"
        Me.sStartup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadHardwareDisable
        '
        Me.RadHardwareDisable.ActiveBorderColor = System.Drawing.Color.White
        Me.RadHardwareDisable.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadHardwareDisable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadHardwareDisable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadHardwareDisable.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadHardwareDisable.Location = New System.Drawing.Point(14, 36)
        Me.RadHardwareDisable.Margin = New System.Windows.Forms.Padding(2)
        Me.RadHardwareDisable.Name = "RadHardwareDisable"
        Me.RadHardwareDisable.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadHardwareDisable.Size = New System.Drawing.Size(66, 22)
        Me.RadHardwareDisable.TabIndex = 0
        Me.RadHardwareDisable.Text = "Off"
        '
        'RadHardwareEnable
        '
        Me.RadHardwareEnable.ActiveBorderColor = System.Drawing.Color.White
        Me.RadHardwareEnable.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadHardwareEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadHardwareEnable.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadHardwareEnable.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadHardwareEnable.Location = New System.Drawing.Point(84, 36)
        Me.RadHardwareEnable.Margin = New System.Windows.Forms.Padding(2)
        Me.RadHardwareEnable.Name = "RadHardwareEnable"
        Me.RadHardwareEnable.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadHardwareEnable.Size = New System.Drawing.Size(63, 22)
        Me.RadHardwareEnable.TabIndex = 1
        Me.RadHardwareEnable.Text = "On"
        '
        'PanHardwareMode
        '
        Me.PanHardwareMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanHardwareMode.Controls.Add(Me.sHardwareMode)
        Me.PanHardwareMode.Controls.Add(Me.RadHardwaremodeXml)
        Me.PanHardwareMode.Controls.Add(Me.RadHardwaremodeApi)
        Me.PanHardwareMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHardwareMode.Location = New System.Drawing.Point(241, 0)
        Me.PanHardwareMode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanHardwareMode.Name = "PanHardwareMode"
        Me.PanHardwareMode.Size = New System.Drawing.Size(241, 71)
        Me.PanHardwareMode.TabIndex = 0
        '
        'sHardwareMode
        '
        Me.sHardwareMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sHardwareMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.sHardwareMode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sHardwareMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sHardwareMode.Location = New System.Drawing.Point(0, 0)
        Me.sHardwareMode.Margin = New System.Windows.Forms.Padding(0)
        Me.sHardwareMode.Name = "sHardwareMode"
        Me.sHardwareMode.Size = New System.Drawing.Size(241, 24)
        Me.sHardwareMode.TabIndex = 114
        Me.sHardwareMode.Text = "Hardware Mode"
        Me.sHardwareMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadHardwaremodeXml
        '
        Me.RadHardwaremodeXml.ActiveBorderColor = System.Drawing.Color.White
        Me.RadHardwaremodeXml.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadHardwaremodeXml.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadHardwaremodeXml.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadHardwaremodeXml.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadHardwaremodeXml.Location = New System.Drawing.Point(14, 36)
        Me.RadHardwaremodeXml.Margin = New System.Windows.Forms.Padding(2)
        Me.RadHardwaremodeXml.Name = "RadHardwaremodeXml"
        Me.RadHardwaremodeXml.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadHardwaremodeXml.Size = New System.Drawing.Size(66, 22)
        Me.RadHardwaremodeXml.TabIndex = 2
        Me.RadHardwaremodeXml.Text = "Xml"
        '
        'RadHardwaremodeApi
        '
        Me.RadHardwaremodeApi.ActiveBorderColor = System.Drawing.Color.White
        Me.RadHardwaremodeApi.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadHardwaremodeApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadHardwaremodeApi.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadHardwaremodeApi.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadHardwaremodeApi.Location = New System.Drawing.Point(84, 36)
        Me.RadHardwaremodeApi.Margin = New System.Windows.Forms.Padding(2)
        Me.RadHardwaremodeApi.Name = "RadHardwaremodeApi"
        Me.RadHardwaremodeApi.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadHardwaremodeApi.Size = New System.Drawing.Size(63, 22)
        Me.RadHardwaremodeApi.TabIndex = 3
        Me.RadHardwaremodeApi.Text = "Api"
        '
        'PanImgur
        '
        Me.PanImgur.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanImgur.Controls.Add(Me.sImgur)
        Me.PanImgur.Controls.Add(Me.sImgurInfo)
        Me.PanImgur.Controls.Add(Me.TlpText)
        Me.PanImgur.Controls.Add(Me.RadCustomClientOff)
        Me.PanImgur.Controls.Add(Me.RadCustomClientOn)
        Me.PanImgur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanImgur.Location = New System.Drawing.Point(0, 345)
        Me.PanImgur.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanImgur.Name = "PanImgur"
        Me.PanImgur.Size = New System.Drawing.Size(482, 90)
        Me.PanImgur.TabIndex = 0
        '
        'sImgur
        '
        Me.sImgur.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sImgur.Dock = System.Windows.Forms.DockStyle.Top
        Me.sImgur.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sImgur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sImgur.Location = New System.Drawing.Point(0, 0)
        Me.sImgur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sImgur.Name = "sImgur"
        Me.sImgur.Size = New System.Drawing.Size(482, 24)
        Me.sImgur.TabIndex = 130
        Me.sImgur.Text = "Imgur Client ID"
        Me.sImgur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sImgurInfo
        '
        Me.sImgurInfo.AutoSize = True
        Me.sImgurInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sImgurInfo.Location = New System.Drawing.Point(4, 28)
        Me.sImgurInfo.Name = "sImgurInfo"
        Me.sImgurInfo.Size = New System.Drawing.Size(266, 19)
        Me.sImgurInfo.TabIndex = 0
        Me.sImgurInfo.Text = "Enable the use of a custom Imgur client id"
        '
        'TlpText
        '
        Me.TlpText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TlpText.ColumnCount = 1
        Me.TlpText.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpText.Controls.Add(Me.TbxClientId, 0, 0)
        Me.TlpText.Location = New System.Drawing.Point(145, 54)
        Me.TlpText.Name = "TlpText"
        Me.TlpText.RowCount = 1
        Me.TlpText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpText.Size = New System.Drawing.Size(176, 26)
        Me.TlpText.TabIndex = 128
        '
        'TbxClientId
        '
        Me.TbxClientId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxClientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TbxClientId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxClientId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxClientId.ForeColor = System.Drawing.Color.White
        Me.TbxClientId.Location = New System.Drawing.Point(3, 3)
        Me.TbxClientId.Name = "TbxClientId"
        Me.TbxClientId.Size = New System.Drawing.Size(169, 20)
        Me.TbxClientId.TabIndex = 128
        Me.TbxClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadCustomClientOff
        '
        Me.RadCustomClientOff.ActiveBorderColor = System.Drawing.Color.White
        Me.RadCustomClientOff.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadCustomClientOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadCustomClientOff.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadCustomClientOff.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadCustomClientOff.Location = New System.Drawing.Point(14, 56)
        Me.RadCustomClientOff.Margin = New System.Windows.Forms.Padding(2)
        Me.RadCustomClientOff.Name = "RadCustomClientOff"
        Me.RadCustomClientOff.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadCustomClientOff.Size = New System.Drawing.Size(60, 22)
        Me.RadCustomClientOff.TabIndex = 126
        Me.RadCustomClientOff.Text = "Off"
        '
        'RadCustomClientOn
        '
        Me.RadCustomClientOn.ActiveBorderColor = System.Drawing.Color.White
        Me.RadCustomClientOn.ActiveRadioBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RadCustomClientOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RadCustomClientOn.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadCustomClientOn.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RadCustomClientOn.Location = New System.Drawing.Point(78, 56)
        Me.RadCustomClientOn.Margin = New System.Windows.Forms.Padding(2)
        Me.RadCustomClientOn.Name = "RadCustomClientOn"
        Me.RadCustomClientOn.RadioBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RadCustomClientOn.Size = New System.Drawing.Size(63, 22)
        Me.RadCustomClientOn.TabIndex = 127
        Me.RadCustomClientOn.Text = "On"
        '
        'PanConfig
        '
        Me.PanConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanConfig.Controls.Add(Me.sConfig)
        Me.PanConfig.Controls.Add(Me.CmdApply)
        Me.PanConfig.Controls.Add(Me.sConfigInfo)
        Me.PanConfig.Controls.Add(Me.CmdCancel)
        Me.PanConfig.Controls.Add(Me.CmdOkay)
        Me.PanConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanConfig.Location = New System.Drawing.Point(0, 436)
        Me.PanConfig.Margin = New System.Windows.Forms.Padding(0)
        Me.PanConfig.Name = "PanConfig"
        Me.PanConfig.Size = New System.Drawing.Size(482, 105)
        Me.PanConfig.TabIndex = 0
        '
        'sConfig
        '
        Me.sConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.sConfig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sConfig.Location = New System.Drawing.Point(0, 0)
        Me.sConfig.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sConfig.Name = "sConfig"
        Me.sConfig.Size = New System.Drawing.Size(482, 24)
        Me.sConfig.TabIndex = 131
        Me.sConfig.Text = "Configuration"
        Me.sConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdApply
        '
        Me.CmdApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdApply.FlatAppearance.BorderSize = 0
        Me.CmdApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdApply.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdApply.Location = New System.Drawing.Point(391, 61)
        Me.CmdApply.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdApply.Name = "CmdApply"
        Me.CmdApply.Size = New System.Drawing.Size(80, 35)
        Me.CmdApply.TabIndex = 3
        Me.CmdApply.Text = "Apply"
        Me.CmdApply.UseVisualStyleBackColor = False
        '
        'sConfigInfo
        '
        Me.sConfigInfo.AutoSize = True
        Me.sConfigInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sConfigInfo.Location = New System.Drawing.Point(4, 28)
        Me.sConfigInfo.Name = "sConfigInfo"
        Me.sConfigInfo.Size = New System.Drawing.Size(183, 19)
        Me.sConfigInfo.TabIndex = 0
        Me.sConfigInfo.Text = "Cancel or save your changes"
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(305, 61)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(80, 35)
        Me.CmdCancel.TabIndex = 2
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdOkay
        '
        Me.CmdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOkay.FlatAppearance.BorderSize = 0
        Me.CmdOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOkay.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOkay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdOkay.Location = New System.Drawing.Point(219, 61)
        Me.CmdOkay.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOkay.Name = "CmdOkay"
        Me.CmdOkay.Size = New System.Drawing.Size(80, 35)
        Me.CmdOkay.TabIndex = 1
        Me.CmdOkay.Text = "OK"
        Me.CmdOkay.UseVisualStyleBackColor = False
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(0, 0)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(496, 2)
        Me.PanSplit.TabIndex = 125
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 599)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(498, 599)
        Me.MinimumSize = New System.Drawing.Size(498, 599)
        Me.Name = "FormSettings"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanAssessmentMode.ResumeLayout(False)
        Me.PanAssessmentMode.PerformLayout()
        Me.PanPortability.ResumeLayout(False)
        Me.PanPortability.PerformLayout()
        Me.PanThemeColor.ResumeLayout(False)
        Me.PanThemeColor.PerformLayout()
        Me.PanMain.ResumeLayout(False)
        Me.TlpMain.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        Me.PanShowHardware.ResumeLayout(False)
        Me.PanHardwareMode.ResumeLayout(False)
        Me.PanImgur.ResumeLayout(False)
        Me.PanImgur.PerformLayout()
        Me.TlpText.ResumeLayout(False)
        Me.TlpText.PerformLayout()
        Me.PanConfig.ResumeLayout(False)
        Me.PanConfig.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents RadDefault0 As GambolRadioButton
    Friend WithEvents RadSky1 As GambolRadioButton
    Friend WithEvents RadTurquoise2 As GambolRadioButton
    Friend WithEvents RadEmerald3 As GambolRadioButton
    Friend WithEvents RadMegenta4 As GambolRadioButton
    Friend WithEvents PanAssessmentMode As System.Windows.Forms.Panel
    Friend WithEvents PanPortability As System.Windows.Forms.Panel
    Friend WithEvents RadAssessmentVerbose As GambolRadioButton
    Friend WithEvents RadAssessmentNormal As GambolRadioButton
    Friend WithEvents PanThemeColor As System.Windows.Forms.Panel
    Friend WithEvents sPortability As System.Windows.Forms.Label
    Friend WithEvents CbxApplyToBorder As GambolCheckbox
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents RadCarrot6 As GambolRadioButton
    Friend WithEvents RadYellow7 As GambolRadioButton
    Friend WithEvents RadAlazarin8 As GambolRadioButton
    Friend WithEvents RadPortabilityOn As GambolRadioButton
    Friend WithEvents RadPortabilityOff As GambolRadioButton
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanConfig As System.Windows.Forms.Panel
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdOkay As System.Windows.Forms.Button
    Friend WithEvents TlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents sConfigInfo As System.Windows.Forms.Label
    Friend WithEvents CmdApply As System.Windows.Forms.Button
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents CmdWarn As System.Windows.Forms.Button
    Friend WithEvents PanHardwareMode As System.Windows.Forms.Panel
    Friend WithEvents RadHardwaremodeXml As GambolRadioButton
    Friend WithEvents RadHardwaremodeApi As GambolRadioButton
    Friend WithEvents PanImgur As Panel
    Friend WithEvents TbxClientId As TextBox
    Friend WithEvents RadCustomClientOff As GambolRadioButton
    Friend WithEvents RadCustomClientOn As GambolRadioButton
    Friend WithEvents TlpText As TableLayoutPanel
    Friend WithEvents RadPink5 As GambolRadioButton
    Friend WithEvents PanShowHardware As Panel
    Friend WithEvents RadHardwareDisable As GambolRadioButton
    Friend WithEvents RadHardwareEnable As GambolRadioButton
    Friend WithEvents TlpTop As TableLayoutPanel
    Friend WithEvents sInfoAssessment As Label
    Friend WithEvents sPortabilityInfo As Label
    Friend WithEvents sThemeInfo As Label
    Friend WithEvents sImgurInfo As Label
    Friend WithEvents sDefaultAss As Label
    Friend WithEvents sTheme As Label
    Friend WithEvents sStartup As Label
    Friend WithEvents sHardwareMode As Label
    Friend WithEvents sImgur As Label
    Friend WithEvents sConfig As Label
End Class
