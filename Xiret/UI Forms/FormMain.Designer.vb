Imports Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.lbShowOnPrint = New System.Windows.Forms.Label()
        Me.lbScaleOf = New System.Windows.Forms.Label()
        Me.PnlSubDisk = New System.Windows.Forms.Panel()
        Me.lbDiskScore = New System.Windows.Forms.Label()
        Me.PnlSubGaming = New System.Windows.Forms.Panel()
        Me.lbGamingScore = New System.Windows.Forms.Label()
        Me.PnlSubGraphics = New System.Windows.Forms.Panel()
        Me.lbGraphicsScore = New System.Windows.Forms.Label()
        Me.PnlSubMemory = New System.Windows.Forms.Panel()
        Me.lbMemoryScore = New System.Windows.Forms.Label()
        Me.PnlSubProcessor = New System.Windows.Forms.Panel()
        Me.lbCpuScore = New System.Windows.Forms.Label()
        Me.LBaseScore = New System.Windows.Forms.Label()
        Me.sSub = New System.Windows.Forms.Label()
        Me.lbWhatIsRated = New System.Windows.Forms.Label()
        Me.LComponent = New System.Windows.Forms.Label()
        Me.pnlComp = New System.Windows.Forms.Panel()
        Me.lbCompProc = New System.Windows.Forms.Label()
        Me.lbCompDisk = New System.Windows.Forms.Label()
        Me.lbCompGaming = New System.Windows.Forms.Label()
        Me.lbCompGraphics = New System.Windows.Forms.Label()
        Me.lbCompMem = New System.Windows.Forms.Label()
        Me.pnlRated = New System.Windows.Forms.Panel()
        Me.sProcessor = New System.Windows.Forms.Label()
        Me.sDisk = New System.Windows.Forms.Label()
        Me.sMemory = New System.Windows.Forms.Label()
        Me.sGraphics = New System.Windows.Forms.Label()
        Me.sGaming = New System.Windows.Forms.Label()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.cmdMinimize = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lbHeadVer = New System.Windows.Forms.Label()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.sLastUpdate = New System.Windows.Forms.Label()
        Me.lbLastUpdated = New System.Windows.Forms.Label()
        Me.lbOperatingSystem = New System.Windows.Forms.Label()
        Me.sOperatingSystem = New System.Windows.Forms.Label()
        Me.lbState = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdHotfix = New System.Windows.Forms.Button()
        Me.cmdTools = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.pnlCapture = New System.Windows.Forms.Panel()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlSubMain = New System.Windows.Forms.Panel()
        Me.tlpInf = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpSubscore = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBaseScore = New System.Windows.Forms.Panel()
        Me.lbBaseScore = New System.Windows.Forms.Label()
        Me.sEleven = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlValidity = New System.Windows.Forms.Panel()
        Me.pnlValidityState = New System.Windows.Forms.Panel()
        Me.sValidity = New System.Windows.Forms.Label()
        Me.cmdMetrics = New System.Windows.Forms.Button()
        Me.pnlLastUpdated = New System.Windows.Forms.Panel()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.pnlD = New System.Windows.Forms.Panel()
        Me.pnlMetrics = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlOperatingSystem = New System.Windows.Forms.Panel()
        Me.pnlA = New System.Windows.Forms.Panel()
        Me.pnlShowHardware = New System.Windows.Forms.Panel()
        Me.sShow = New System.Windows.Forms.Label()
        Me.pnlAssessment = New System.Windows.Forms.Panel()
        Me.lbAssessment = New System.Windows.Forms.Label()
        Me.pnlB = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.BMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImgurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewImgurLinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolstripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTools = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CleanupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSystemDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunVerboseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHelp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MediaFeaturePackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleshootingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GSwitchHardware = New Gambol.Controls.GambolSwitch()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSubDisk.SuspendLayout()
        Me.PnlSubGaming.SuspendLayout()
        Me.PnlSubGraphics.SuspendLayout()
        Me.PnlSubMemory.SuspendLayout()
        Me.PnlSubProcessor.SuspendLayout()
        Me.pnlComp.SuspendLayout()
        Me.pnlRated.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.tlpMenu.SuspendLayout()
        Me.pnlCapture.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.pnlSubMain.SuspendLayout()
        Me.tlpInf.SuspendLayout()
        Me.tlpSubscore.SuspendLayout()
        Me.pnlBaseScore.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.pnlValidity.SuspendLayout()
        Me.pnlLastUpdated.SuspendLayout()
        Me.pnlD.SuspendLayout()
        Me.pnlMetrics.SuspendLayout()
        Me.pnlOperatingSystem.SuspendLayout()
        Me.pnlA.SuspendLayout()
        Me.pnlShowHardware.SuspendLayout()
        Me.pnlAssessment.SuspendLayout()
        Me.pnlB.SuspendLayout()
        Me.pnlC.SuspendLayout()
        Me.cmsExport.SuspendLayout()
        Me.cmsOptions.SuspendLayout()
        Me.cmsTools.SuspendLayout()
        Me.cmsHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxMain
        '
        Me.pbxMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxMain.BackColor = System.Drawing.Color.Transparent
        Me.pbxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMain.Image = Global.Xiret.My.Resources.Resources.icon24px
        Me.pbxMain.Location = New System.Drawing.Point(11, 13)
        Me.pbxMain.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.pbxMain.Name = "pbxMain"
        Me.pbxMain.Size = New System.Drawing.Size(24, 24)
        Me.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMain.TabIndex = 1
        Me.pbxMain.TabStop = False
        '
        'lbHead
        '
        Me.lbHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbHead.BackColor = System.Drawing.Color.Transparent
        Me.lbHead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHead.ForeColor = System.Drawing.Color.White
        Me.lbHead.Location = New System.Drawing.Point(298, 4)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(255, 22)
        Me.lbHead.TabIndex = 1
        Me.lbHead.Text = "Xiret - Experience Index UI"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbShowOnPrint
        '
        Me.lbShowOnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbShowOnPrint.BackColor = System.Drawing.Color.Transparent
        Me.lbShowOnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowOnPrint.ForeColor = System.Drawing.Color.White
        Me.lbShowOnPrint.Location = New System.Drawing.Point(632, 6)
        Me.lbShowOnPrint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbShowOnPrint.Name = "lbShowOnPrint"
        Me.lbShowOnPrint.Size = New System.Drawing.Size(170, 22)
        Me.lbShowOnPrint.TabIndex = 72
        Me.lbShowOnPrint.Text = "Xiret"
        Me.lbShowOnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbScaleOf
        '
        Me.lbScaleOf.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbScaleOf.BackColor = System.Drawing.Color.Transparent
        Me.lbScaleOf.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScaleOf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbScaleOf.Location = New System.Drawing.Point(4, 7)
        Me.lbScaleOf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbScaleOf.Name = "lbScaleOf"
        Me.lbScaleOf.Size = New System.Drawing.Size(615, 20)
        Me.lbScaleOf.TabIndex = 27
        Me.lbScaleOf.Text = "The Experience Index assesses key system components on a scale of"
        '
        'PnlSubDisk
        '
        Me.PnlSubDisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PnlSubDisk.Controls.Add(Me.lbDiskScore)
        Me.PnlSubDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSubDisk.Location = New System.Drawing.Point(0, 144)
        Me.PnlSubDisk.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlSubDisk.Name = "PnlSubDisk"
        Me.PnlSubDisk.Size = New System.Drawing.Size(78, 36)
        Me.PnlSubDisk.TabIndex = 70
        '
        'lbDiskScore
        '
        Me.lbDiskScore.BackColor = System.Drawing.Color.Transparent
        Me.lbDiskScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiskScore.ForeColor = System.Drawing.Color.White
        Me.lbDiskScore.Location = New System.Drawing.Point(0, 0)
        Me.lbDiskScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDiskScore.Name = "lbDiskScore"
        Me.lbDiskScore.Size = New System.Drawing.Size(78, 36)
        Me.lbDiskScore.TabIndex = 24
        Me.lbDiskScore.Text = "..."
        Me.lbDiskScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubGaming
        '
        Me.PnlSubGaming.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PnlSubGaming.Controls.Add(Me.lbGamingScore)
        Me.PnlSubGaming.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSubGaming.Location = New System.Drawing.Point(0, 108)
        Me.PnlSubGaming.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PnlSubGaming.Name = "PnlSubGaming"
        Me.PnlSubGaming.Size = New System.Drawing.Size(78, 35)
        Me.PnlSubGaming.TabIndex = 69
        '
        'lbGamingScore
        '
        Me.lbGamingScore.BackColor = System.Drawing.Color.Transparent
        Me.lbGamingScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbGamingScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGamingScore.ForeColor = System.Drawing.Color.White
        Me.lbGamingScore.Location = New System.Drawing.Point(0, 0)
        Me.lbGamingScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGamingScore.Name = "lbGamingScore"
        Me.lbGamingScore.Size = New System.Drawing.Size(78, 35)
        Me.lbGamingScore.TabIndex = 23
        Me.lbGamingScore.Text = "..."
        Me.lbGamingScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubGraphics
        '
        Me.PnlSubGraphics.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PnlSubGraphics.Controls.Add(Me.lbGraphicsScore)
        Me.PnlSubGraphics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSubGraphics.Location = New System.Drawing.Point(0, 72)
        Me.PnlSubGraphics.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PnlSubGraphics.Name = "PnlSubGraphics"
        Me.PnlSubGraphics.Size = New System.Drawing.Size(78, 35)
        Me.PnlSubGraphics.TabIndex = 68
        '
        'lbGraphicsScore
        '
        Me.lbGraphicsScore.BackColor = System.Drawing.Color.Transparent
        Me.lbGraphicsScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbGraphicsScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGraphicsScore.ForeColor = System.Drawing.Color.White
        Me.lbGraphicsScore.Location = New System.Drawing.Point(0, 0)
        Me.lbGraphicsScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGraphicsScore.Name = "lbGraphicsScore"
        Me.lbGraphicsScore.Size = New System.Drawing.Size(78, 35)
        Me.lbGraphicsScore.TabIndex = 24
        Me.lbGraphicsScore.Text = "..."
        Me.lbGraphicsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubMemory
        '
        Me.PnlSubMemory.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PnlSubMemory.Controls.Add(Me.lbMemoryScore)
        Me.PnlSubMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSubMemory.Location = New System.Drawing.Point(0, 36)
        Me.PnlSubMemory.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PnlSubMemory.Name = "PnlSubMemory"
        Me.PnlSubMemory.Size = New System.Drawing.Size(78, 35)
        Me.PnlSubMemory.TabIndex = 67
        '
        'lbMemoryScore
        '
        Me.lbMemoryScore.BackColor = System.Drawing.Color.Transparent
        Me.lbMemoryScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMemoryScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMemoryScore.ForeColor = System.Drawing.Color.White
        Me.lbMemoryScore.Location = New System.Drawing.Point(0, 0)
        Me.lbMemoryScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMemoryScore.Name = "lbMemoryScore"
        Me.lbMemoryScore.Size = New System.Drawing.Size(78, 35)
        Me.lbMemoryScore.TabIndex = 23
        Me.lbMemoryScore.Text = "..."
        Me.lbMemoryScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubProcessor
        '
        Me.PnlSubProcessor.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PnlSubProcessor.Controls.Add(Me.lbCpuScore)
        Me.PnlSubProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSubProcessor.Location = New System.Drawing.Point(0, 0)
        Me.PnlSubProcessor.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PnlSubProcessor.Name = "PnlSubProcessor"
        Me.PnlSubProcessor.Size = New System.Drawing.Size(78, 35)
        Me.PnlSubProcessor.TabIndex = 66
        '
        'lbCpuScore
        '
        Me.lbCpuScore.BackColor = System.Drawing.Color.Transparent
        Me.lbCpuScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCpuScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCpuScore.ForeColor = System.Drawing.Color.White
        Me.lbCpuScore.Location = New System.Drawing.Point(0, 0)
        Me.lbCpuScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCpuScore.Name = "lbCpuScore"
        Me.lbCpuScore.Size = New System.Drawing.Size(78, 35)
        Me.lbCpuScore.TabIndex = 22
        Me.lbCpuScore.Text = "..."
        Me.lbCpuScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBaseScore
        '
        Me.LBaseScore.AutoSize = True
        Me.LBaseScore.BackColor = System.Drawing.Color.Transparent
        Me.LBaseScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaseScore.ForeColor = System.Drawing.Color.White
        Me.LBaseScore.Location = New System.Drawing.Point(671, 7)
        Me.LBaseScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBaseScore.Name = "LBaseScore"
        Me.LBaseScore.Size = New System.Drawing.Size(83, 20)
        Me.LBaseScore.TabIndex = 4
        Me.LBaseScore.Text = "Base score"
        Me.LBaseScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sSub
        '
        Me.sSub.AutoSize = True
        Me.sSub.BackColor = System.Drawing.Color.Transparent
        Me.sSub.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sSub.ForeColor = System.Drawing.Color.White
        Me.sSub.Location = New System.Drawing.Point(547, 7)
        Me.sSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sSub.Name = "sSub"
        Me.sSub.Size = New System.Drawing.Size(72, 20)
        Me.sSub.TabIndex = 3
        Me.sSub.Text = "Subscore"
        Me.sSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbWhatIsRated
        '
        Me.lbWhatIsRated.BackColor = System.Drawing.Color.Transparent
        Me.lbWhatIsRated.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWhatIsRated.ForeColor = System.Drawing.Color.White
        Me.lbWhatIsRated.Location = New System.Drawing.Point(195, 7)
        Me.lbWhatIsRated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbWhatIsRated.Name = "lbWhatIsRated"
        Me.lbWhatIsRated.Size = New System.Drawing.Size(125, 20)
        Me.lbWhatIsRated.TabIndex = 2
        Me.lbWhatIsRated.Text = "What is rated"
        Me.lbWhatIsRated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LComponent
        '
        Me.LComponent.BackColor = System.Drawing.Color.Transparent
        Me.LComponent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LComponent.ForeColor = System.Drawing.Color.White
        Me.LComponent.Location = New System.Drawing.Point(4, 7)
        Me.LComponent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LComponent.Name = "LComponent"
        Me.LComponent.Size = New System.Drawing.Size(125, 20)
        Me.LComponent.TabIndex = 1
        Me.LComponent.Text = "Component"
        Me.LComponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlComp
        '
        Me.pnlComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlComp.Controls.Add(Me.lbCompProc)
        Me.pnlComp.Controls.Add(Me.lbCompDisk)
        Me.pnlComp.Controls.Add(Me.lbCompGaming)
        Me.pnlComp.Controls.Add(Me.lbCompGraphics)
        Me.pnlComp.Controls.Add(Me.lbCompMem)
        Me.pnlComp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlComp.Location = New System.Drawing.Point(0, 0)
        Me.pnlComp.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlComp.Name = "pnlComp"
        Me.pnlComp.Size = New System.Drawing.Size(189, 178)
        Me.pnlComp.TabIndex = 66
        '
        'lbCompProc
        '
        Me.lbCompProc.AutoSize = True
        Me.lbCompProc.BackColor = System.Drawing.Color.Transparent
        Me.lbCompProc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompProc.ForeColor = System.Drawing.Color.White
        Me.lbCompProc.Location = New System.Drawing.Point(7, 7)
        Me.lbCompProc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCompProc.Name = "lbCompProc"
        Me.lbCompProc.Size = New System.Drawing.Size(91, 20)
        Me.lbCompProc.TabIndex = 13
        Me.lbCompProc.Text = "PROCESSOR"
        '
        'lbCompDisk
        '
        Me.lbCompDisk.AutoSize = True
        Me.lbCompDisk.BackColor = System.Drawing.Color.Transparent
        Me.lbCompDisk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompDisk.ForeColor = System.Drawing.Color.White
        Me.lbCompDisk.Location = New System.Drawing.Point(7, 151)
        Me.lbCompDisk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCompDisk.Name = "lbCompDisk"
        Me.lbCompDisk.Size = New System.Drawing.Size(154, 20)
        Me.lbCompDisk.TabIndex = 13
        Me.lbCompDisk.Text = "PRIMARY HARD DISK"
        '
        'lbCompGaming
        '
        Me.lbCompGaming.AutoSize = True
        Me.lbCompGaming.BackColor = System.Drawing.Color.Transparent
        Me.lbCompGaming.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompGaming.ForeColor = System.Drawing.Color.White
        Me.lbCompGaming.Location = New System.Drawing.Point(7, 115)
        Me.lbCompGaming.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCompGaming.Name = "lbCompGaming"
        Me.lbCompGaming.Size = New System.Drawing.Size(143, 20)
        Me.lbCompGaming.TabIndex = 13
        Me.lbCompGaming.Text = "GAMING GRAPHICS"
        '
        'lbCompGraphics
        '
        Me.lbCompGraphics.AutoSize = True
        Me.lbCompGraphics.BackColor = System.Drawing.Color.Transparent
        Me.lbCompGraphics.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompGraphics.ForeColor = System.Drawing.Color.White
        Me.lbCompGraphics.Location = New System.Drawing.Point(7, 79)
        Me.lbCompGraphics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCompGraphics.Name = "lbCompGraphics"
        Me.lbCompGraphics.Size = New System.Drawing.Size(79, 20)
        Me.lbCompGraphics.TabIndex = 3
        Me.lbCompGraphics.Text = "GRAPHICS"
        '
        'lbCompMem
        '
        Me.lbCompMem.AutoSize = True
        Me.lbCompMem.BackColor = System.Drawing.Color.Transparent
        Me.lbCompMem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompMem.ForeColor = System.Drawing.Color.White
        Me.lbCompMem.Location = New System.Drawing.Point(7, 43)
        Me.lbCompMem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCompMem.Name = "lbCompMem"
        Me.lbCompMem.Size = New System.Drawing.Size(121, 20)
        Me.lbCompMem.TabIndex = 2
        Me.lbCompMem.Text = "MEMORY (RAM)"
        '
        'pnlRated
        '
        Me.pnlRated.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlRated.Controls.Add(Me.sProcessor)
        Me.pnlRated.Controls.Add(Me.sDisk)
        Me.pnlRated.Controls.Add(Me.sMemory)
        Me.pnlRated.Controls.Add(Me.sGraphics)
        Me.pnlRated.Controls.Add(Me.sGaming)
        Me.pnlRated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRated.Location = New System.Drawing.Point(190, 0)
        Me.pnlRated.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlRated.Name = "pnlRated"
        Me.pnlRated.Size = New System.Drawing.Size(354, 178)
        Me.pnlRated.TabIndex = 69
        '
        'sProcessor
        '
        Me.sProcessor.AutoEllipsis = True
        Me.sProcessor.BackColor = System.Drawing.Color.Transparent
        Me.sProcessor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.sProcessor.Location = New System.Drawing.Point(7, 7)
        Me.sProcessor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sProcessor.Name = "sProcessor"
        Me.sProcessor.Size = New System.Drawing.Size(339, 20)
        Me.sProcessor.TabIndex = 27
        Me.sProcessor.Text = "Calculations per second"
        '
        'sDisk
        '
        Me.sDisk.AutoEllipsis = True
        Me.sDisk.BackColor = System.Drawing.Color.Transparent
        Me.sDisk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sDisk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.sDisk.Location = New System.Drawing.Point(7, 151)
        Me.sDisk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sDisk.Name = "sDisk"
        Me.sDisk.Size = New System.Drawing.Size(339, 20)
        Me.sDisk.TabIndex = 31
        Me.sDisk.Text = "Disk data transfer rate"
        '
        'sMemory
        '
        Me.sMemory.AutoEllipsis = True
        Me.sMemory.BackColor = System.Drawing.Color.Transparent
        Me.sMemory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.sMemory.Location = New System.Drawing.Point(7, 43)
        Me.sMemory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sMemory.Name = "sMemory"
        Me.sMemory.Size = New System.Drawing.Size(339, 20)
        Me.sMemory.TabIndex = 28
        Me.sMemory.Text = "Memory operations per second"
        '
        'sGraphics
        '
        Me.sGraphics.AutoEllipsis = True
        Me.sGraphics.BackColor = System.Drawing.Color.Transparent
        Me.sGraphics.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sGraphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.sGraphics.Location = New System.Drawing.Point(7, 79)
        Me.sGraphics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sGraphics.Name = "sGraphics"
        Me.sGraphics.Size = New System.Drawing.Size(339, 20)
        Me.sGraphics.TabIndex = 29
        Me.sGraphics.Text = "Desktop graphics performance"
        '
        'sGaming
        '
        Me.sGaming.AutoEllipsis = True
        Me.sGaming.BackColor = System.Drawing.Color.Transparent
        Me.sGaming.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sGaming.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.sGaming.Location = New System.Drawing.Point(7, 115)
        Me.sGaming.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sGaming.Name = "sGaming"
        Me.sGaming.Size = New System.Drawing.Size(339, 20)
        Me.sGaming.TabIndex = 30
        Me.sGaming.Text = "3D business and gaming graphics performance"
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.pnlHead.Controls.Add(Me.cmdMinimize)
        Me.pnlHead.Controls.Add(Me.cmdClose)
        Me.pnlHead.Controls.Add(Me.lbHeadVer)
        Me.pnlHead.Controls.Add(Me.lbHead)
        Me.pnlHead.Controls.Add(Me.tlpIcon)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(1, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(848, 50)
        Me.pnlHead.TabIndex = 59
        '
        'cmdMinimize
        '
        Me.cmdMinimize.BackColor = System.Drawing.Color.Transparent
        Me.cmdMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdMinimize.FlatAppearance.BorderSize = 0
        Me.cmdMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMinimize.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.Location = New System.Drawing.Point(732, 0)
        Me.cmdMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.Size = New System.Drawing.Size(58, 50)
        Me.cmdMinimize.TabIndex = 7
        Me.cmdMinimize.TabStop = False
        Me.cmdMinimize.Text = "—"
        Me.cmdMinimize.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(790, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(58, 50)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lbHeadVer
        '
        Me.lbHeadVer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbHeadVer.BackColor = System.Drawing.Color.Transparent
        Me.lbHeadVer.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHeadVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lbHeadVer.Location = New System.Drawing.Point(318, 30)
        Me.lbHeadVer.Name = "lbHeadVer"
        Me.lbHeadVer.Size = New System.Drawing.Size(214, 14)
        Me.lbHeadVer.TabIndex = 8
        Me.lbHeadVer.Text = "..."
        Me.lbHeadVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpIcon
        '
        Me.tlpIcon.BackColor = System.Drawing.Color.Transparent
        Me.tlpIcon.ColumnCount = 1
        Me.tlpIcon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpIcon.Controls.Add(Me.pbxMain, 0, 0)
        Me.tlpIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpIcon.Location = New System.Drawing.Point(0, 0)
        Me.tlpIcon.Name = "tlpIcon"
        Me.tlpIcon.RowCount = 1
        Me.tlpIcon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIcon.Size = New System.Drawing.Size(43, 50)
        Me.tlpIcon.TabIndex = 8
        '
        'sLastUpdate
        '
        Me.sLastUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sLastUpdate.AutoSize = True
        Me.sLastUpdate.BackColor = System.Drawing.Color.Transparent
        Me.sLastUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sLastUpdate.ForeColor = System.Drawing.Color.White
        Me.sLastUpdate.Location = New System.Drawing.Point(4, 4)
        Me.sLastUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sLastUpdate.Name = "sLastUpdate"
        Me.sLastUpdate.Size = New System.Drawing.Size(89, 20)
        Me.sLastUpdate.TabIndex = 67
        Me.sLastUpdate.Text = "Last Update"
        Me.sLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLastUpdated
        '
        Me.lbLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbLastUpdated.AutoSize = True
        Me.lbLastUpdated.BackColor = System.Drawing.Color.Transparent
        Me.lbLastUpdated.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLastUpdated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbLastUpdated.Location = New System.Drawing.Point(5, 4)
        Me.lbLastUpdated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLastUpdated.Name = "lbLastUpdated"
        Me.lbLastUpdated.Size = New System.Drawing.Size(21, 20)
        Me.lbLastUpdated.TabIndex = 70
        Me.lbLastUpdated.Text = "..."
        Me.lbLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOperatingSystem
        '
        Me.lbOperatingSystem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbOperatingSystem.AutoSize = True
        Me.lbOperatingSystem.BackColor = System.Drawing.Color.Transparent
        Me.lbOperatingSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOperatingSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbOperatingSystem.Location = New System.Drawing.Point(5, 4)
        Me.lbOperatingSystem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOperatingSystem.Name = "lbOperatingSystem"
        Me.lbOperatingSystem.Size = New System.Drawing.Size(21, 20)
        Me.lbOperatingSystem.TabIndex = 71
        Me.lbOperatingSystem.Text = "..."
        '
        'sOperatingSystem
        '
        Me.sOperatingSystem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sOperatingSystem.AutoSize = True
        Me.sOperatingSystem.BackColor = System.Drawing.Color.Transparent
        Me.sOperatingSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sOperatingSystem.ForeColor = System.Drawing.Color.White
        Me.sOperatingSystem.Location = New System.Drawing.Point(3, 4)
        Me.sOperatingSystem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sOperatingSystem.Name = "sOperatingSystem"
        Me.sOperatingSystem.Size = New System.Drawing.Size(130, 20)
        Me.sOperatingSystem.TabIndex = 67
        Me.sOperatingSystem.Text = "Operating System"
        Me.sOperatingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbState
        '
        Me.lbState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbState.AutoSize = True
        Me.lbState.BackColor = System.Drawing.Color.Transparent
        Me.lbState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbState.Location = New System.Drawing.Point(5, 4)
        Me.lbState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbState.Name = "lbState"
        Me.lbState.Size = New System.Drawing.Size(21, 20)
        Me.lbState.TabIndex = 78
        Me.lbState.Text = "..."
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(1, 51)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(848, 2)
        Me.pnlSplit.TabIndex = 60
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.tlpMenu)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(1, 53)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(848, 40)
        Me.pnlMenu.TabIndex = 85
        '
        'tlpMenu
        '
        Me.tlpMenu.ColumnCount = 5
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpMenu.Controls.Add(Me.cmdHotfix, 4, 0)
        Me.tlpMenu.Controls.Add(Me.cmdTools, 2, 0)
        Me.tlpMenu.Controls.Add(Me.cmdHelp, 3, 0)
        Me.tlpMenu.Controls.Add(Me.cmdExport, 0, 0)
        Me.tlpMenu.Controls.Add(Me.cmdOptions, 1, 0)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 1
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(350, 40)
        Me.tlpMenu.TabIndex = 0
        '
        'cmdHotfix
        '
        Me.cmdHotfix.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdHotfix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdHotfix.FlatAppearance.BorderSize = 0
        Me.cmdHotfix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdHotfix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdHotfix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHotfix.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHotfix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdHotfix.Location = New System.Drawing.Point(280, 0)
        Me.cmdHotfix.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdHotfix.Name = "cmdHotfix"
        Me.cmdHotfix.Size = New System.Drawing.Size(70, 40)
        Me.cmdHotfix.TabIndex = 32
        Me.cmdHotfix.Text = "Hotfix"
        Me.cmdHotfix.UseVisualStyleBackColor = False
        '
        'cmdTools
        '
        Me.cmdTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdTools.FlatAppearance.BorderSize = 0
        Me.cmdTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTools.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTools.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTools.Location = New System.Drawing.Point(140, 0)
        Me.cmdTools.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdTools.Name = "cmdTools"
        Me.cmdTools.Size = New System.Drawing.Size(70, 40)
        Me.cmdTools.TabIndex = 3
        Me.cmdTools.Text = "Tools"
        Me.cmdTools.UseVisualStyleBackColor = False
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdHelp.FlatAppearance.BorderSize = 0
        Me.cmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHelp.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdHelp.Location = New System.Drawing.Point(210, 0)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(70, 40)
        Me.cmdHelp.TabIndex = 4
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdExport.FlatAppearance.BorderSize = 0
        Me.cmdExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExport.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExport.Location = New System.Drawing.Point(0, 0)
        Me.cmdExport.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(70, 40)
        Me.cmdExport.TabIndex = 1
        Me.cmdExport.Text = "Export"
        Me.cmdExport.UseVisualStyleBackColor = False
        '
        'cmdOptions
        '
        Me.cmdOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdOptions.FlatAppearance.BorderSize = 0
        Me.cmdOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOptions.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOptions.Location = New System.Drawing.Point(70, 0)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(70, 40)
        Me.cmdOptions.TabIndex = 2
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = False
        '
        'pnlCapture
        '
        Me.pnlCapture.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlCapture.Controls.Add(Me.tlpTop)
        Me.pnlCapture.Controls.Add(Me.tlpMain)
        Me.pnlCapture.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCapture.Location = New System.Drawing.Point(1, 93)
        Me.pnlCapture.Name = "pnlCapture"
        Me.pnlCapture.Size = New System.Drawing.Size(848, 284)
        Me.pnlCapture.TabIndex = 86
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 2
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84729!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15271!))
        Me.tlpTop.Controls.Add(Me.lbScaleOf, 0, 0)
        Me.tlpTop.Controls.Add(Me.lbShowOnPrint, 1, 0)
        Me.tlpTop.Location = New System.Drawing.Point(18, 10)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 1
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Size = New System.Drawing.Size(812, 35)
        Me.tlpTop.TabIndex = 87
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 812.0!))
        Me.tlpMain.Controls.Add(Me.pnlSubMain, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpInf, 0, 1)
        Me.tlpMain.Location = New System.Drawing.Point(18, 53)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.tlpMain.Size = New System.Drawing.Size(812, 216)
        Me.tlpMain.TabIndex = 86
        '
        'pnlSubMain
        '
        Me.pnlSubMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlSubMain.Controls.Add(Me.lbWhatIsRated)
        Me.pnlSubMain.Controls.Add(Me.LBaseScore)
        Me.pnlSubMain.Controls.Add(Me.LComponent)
        Me.pnlSubMain.Controls.Add(Me.sSub)
        Me.pnlSubMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSubMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlSubMain.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlSubMain.Name = "pnlSubMain"
        Me.pnlSubMain.Size = New System.Drawing.Size(812, 34)
        Me.pnlSubMain.TabIndex = 84
        '
        'tlpInf
        '
        Me.tlpInf.ColumnCount = 4
        Me.tlpInf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpInf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355.0!))
        Me.tlpInf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.tlpInf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189.0!))
        Me.tlpInf.Controls.Add(Me.pnlComp, 0, 0)
        Me.tlpInf.Controls.Add(Me.tlpSubscore, 2, 0)
        Me.tlpInf.Controls.Add(Me.pnlRated, 1, 0)
        Me.tlpInf.Controls.Add(Me.pnlBaseScore, 3, 0)
        Me.tlpInf.Location = New System.Drawing.Point(0, 35)
        Me.tlpInf.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpInf.Name = "tlpInf"
        Me.tlpInf.RowCount = 1
        Me.tlpInf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInf.Size = New System.Drawing.Size(812, 178)
        Me.tlpInf.TabIndex = 85
        '
        'tlpSubscore
        '
        Me.tlpSubscore.ColumnCount = 1
        Me.tlpSubscore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSubscore.Controls.Add(Me.PnlSubDisk, 0, 4)
        Me.tlpSubscore.Controls.Add(Me.PnlSubProcessor, 0, 0)
        Me.tlpSubscore.Controls.Add(Me.PnlSubMemory, 0, 1)
        Me.tlpSubscore.Controls.Add(Me.PnlSubGaming, 0, 3)
        Me.tlpSubscore.Controls.Add(Me.PnlSubGraphics, 0, 2)
        Me.tlpSubscore.Location = New System.Drawing.Point(545, 0)
        Me.tlpSubscore.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSubscore.Name = "tlpSubscore"
        Me.tlpSubscore.RowCount = 5
        Me.tlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSubscore.Size = New System.Drawing.Size(78, 178)
        Me.tlpSubscore.TabIndex = 70
        '
        'pnlBaseScore
        '
        Me.pnlBaseScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlBaseScore.Controls.Add(Me.lbBaseScore)
        Me.pnlBaseScore.Controls.Add(Me.sEleven)
        Me.pnlBaseScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBaseScore.Location = New System.Drawing.Point(624, 0)
        Me.pnlBaseScore.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.pnlBaseScore.Name = "pnlBaseScore"
        Me.pnlBaseScore.Size = New System.Drawing.Size(188, 178)
        Me.pnlBaseScore.TabIndex = 71
        '
        'lbBaseScore
        '
        Me.lbBaseScore.BackColor = System.Drawing.Color.Transparent
        Me.lbBaseScore.Font = New System.Drawing.Font("Segoe UI Semibold", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBaseScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbBaseScore.Location = New System.Drawing.Point(24, 15)
        Me.lbBaseScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBaseScore.Name = "lbBaseScore"
        Me.lbBaseScore.Size = New System.Drawing.Size(139, 80)
        Me.lbBaseScore.TabIndex = 23
        Me.lbBaseScore.Text = "..."
        Me.lbBaseScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sEleven
        '
        Me.sEleven.BackColor = System.Drawing.Color.Transparent
        Me.sEleven.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sEleven.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.sEleven.Location = New System.Drawing.Point(15, 110)
        Me.sEleven.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sEleven.Name = "sEleven"
        Me.sEleven.Size = New System.Drawing.Size(159, 54)
        Me.sEleven.TabIndex = 22
        Me.sEleven.Text = "Based on the lowest" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "subscore"
        Me.sEleven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.Panel1)
        Me.pnlBottom.Controls.Add(Me.tlpBottom)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBottom.Location = New System.Drawing.Point(1, 377)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(848, 142)
        Me.pnlBottom.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(18, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 1)
        Me.Panel1.TabIndex = 81
        '
        'tlpBottom
        '
        Me.tlpBottom.ColumnCount = 4
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.tlpBottom.Controls.Add(Me.pnlValidity, 0, 0)
        Me.tlpBottom.Controls.Add(Me.cmdMetrics, 3, 2)
        Me.tlpBottom.Controls.Add(Me.pnlLastUpdated, 0, 1)
        Me.tlpBottom.Controls.Add(Me.cmdRun, 3, 1)
        Me.tlpBottom.Controls.Add(Me.pnlD, 3, 0)
        Me.tlpBottom.Controls.Add(Me.pnlMetrics, 2, 2)
        Me.tlpBottom.Controls.Add(Me.pnlOperatingSystem, 0, 2)
        Me.tlpBottom.Controls.Add(Me.pnlA, 1, 0)
        Me.tlpBottom.Controls.Add(Me.pnlShowHardware, 2, 0)
        Me.tlpBottom.Controls.Add(Me.pnlAssessment, 2, 1)
        Me.tlpBottom.Controls.Add(Me.pnlB, 1, 1)
        Me.tlpBottom.Controls.Add(Me.pnlC, 1, 2)
        Me.tlpBottom.Location = New System.Drawing.Point(18, 30)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 3
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(812, 86)
        Me.tlpBottom.TabIndex = 80
        '
        'pnlValidity
        '
        Me.pnlValidity.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlValidity.Controls.Add(Me.pnlValidityState)
        Me.pnlValidity.Controls.Add(Me.sValidity)
        Me.pnlValidity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlValidity.Location = New System.Drawing.Point(0, 0)
        Me.pnlValidity.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pnlValidity.Name = "pnlValidity"
        Me.pnlValidity.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlValidity.Size = New System.Drawing.Size(189, 28)
        Me.pnlValidity.TabIndex = 73
        '
        'pnlValidityState
        '
        Me.pnlValidityState.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlValidityState.Location = New System.Drawing.Point(185, 1)
        Me.pnlValidityState.Name = "pnlValidityState"
        Me.pnlValidityState.Size = New System.Drawing.Size(3, 26)
        Me.pnlValidityState.TabIndex = 68
        '
        'sValidity
        '
        Me.sValidity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sValidity.AutoSize = True
        Me.sValidity.BackColor = System.Drawing.Color.Transparent
        Me.sValidity.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sValidity.ForeColor = System.Drawing.Color.White
        Me.sValidity.Location = New System.Drawing.Point(5, 4)
        Me.sValidity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sValidity.Name = "sValidity"
        Me.sValidity.Size = New System.Drawing.Size(60, 20)
        Me.sValidity.TabIndex = 67
        Me.sValidity.Text = "Validity"
        Me.sValidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdMetrics
        '
        Me.cmdMetrics.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdMetrics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.BorderSize = 0
        Me.cmdMetrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMetrics.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMetrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdMetrics.Location = New System.Drawing.Point(691, 58)
        Me.cmdMetrics.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.cmdMetrics.Name = "cmdMetrics"
        Me.cmdMetrics.Size = New System.Drawing.Size(121, 28)
        Me.cmdMetrics.TabIndex = 7
        Me.cmdMetrics.Text = "View"
        Me.cmdMetrics.UseVisualStyleBackColor = False
        '
        'pnlLastUpdated
        '
        Me.pnlLastUpdated.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlLastUpdated.Controls.Add(Me.sLastUpdate)
        Me.pnlLastUpdated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLastUpdated.Location = New System.Drawing.Point(0, 29)
        Me.pnlLastUpdated.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pnlLastUpdated.Name = "pnlLastUpdated"
        Me.pnlLastUpdated.Size = New System.Drawing.Size(189, 28)
        Me.pnlLastUpdated.TabIndex = 72
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdRun.FlatAppearance.BorderSize = 0
        Me.cmdRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRun.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdRun.Location = New System.Drawing.Point(691, 29)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(121, 28)
        Me.cmdRun.TabIndex = 6
        Me.cmdRun.Text = "Start"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'pnlD
        '
        Me.pnlD.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlD.Controls.Add(Me.GSwitchHardware)
        Me.pnlD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlD.Location = New System.Drawing.Point(691, 0)
        Me.pnlD.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.pnlD.Name = "pnlD"
        Me.pnlD.Size = New System.Drawing.Size(121, 28)
        Me.pnlD.TabIndex = 75
        '
        'pnlMetrics
        '
        Me.pnlMetrics.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlMetrics.Controls.Add(Me.Label1)
        Me.pnlMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMetrics.Location = New System.Drawing.Point(546, 58)
        Me.pnlMetrics.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.pnlMetrics.Name = "pnlMetrics"
        Me.pnlMetrics.Size = New System.Drawing.Size(144, 28)
        Me.pnlMetrics.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Score Metrics"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlOperatingSystem
        '
        Me.pnlOperatingSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlOperatingSystem.Controls.Add(Me.sOperatingSystem)
        Me.pnlOperatingSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOperatingSystem.Location = New System.Drawing.Point(0, 58)
        Me.pnlOperatingSystem.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnlOperatingSystem.Name = "pnlOperatingSystem"
        Me.pnlOperatingSystem.Size = New System.Drawing.Size(189, 28)
        Me.pnlOperatingSystem.TabIndex = 73
        '
        'pnlA
        '
        Me.pnlA.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlA.Controls.Add(Me.lbState)
        Me.pnlA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlA.Location = New System.Drawing.Point(190, 0)
        Me.pnlA.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlA.Name = "pnlA"
        Me.pnlA.Size = New System.Drawing.Size(355, 28)
        Me.pnlA.TabIndex = 75
        '
        'pnlShowHardware
        '
        Me.pnlShowHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlShowHardware.Controls.Add(Me.sShow)
        Me.pnlShowHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlShowHardware.Location = New System.Drawing.Point(546, 0)
        Me.pnlShowHardware.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.pnlShowHardware.Name = "pnlShowHardware"
        Me.pnlShowHardware.Size = New System.Drawing.Size(144, 28)
        Me.pnlShowHardware.TabIndex = 77
        '
        'sShow
        '
        Me.sShow.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sShow.AutoSize = True
        Me.sShow.BackColor = System.Drawing.Color.Transparent
        Me.sShow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sShow.ForeColor = System.Drawing.Color.White
        Me.sShow.Location = New System.Drawing.Point(4, 4)
        Me.sShow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sShow.Name = "sShow"
        Me.sShow.Size = New System.Drawing.Size(115, 20)
        Me.sShow.TabIndex = 67
        Me.sShow.Text = "Show hardware"
        Me.sShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlAssessment
        '
        Me.pnlAssessment.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlAssessment.Controls.Add(Me.lbAssessment)
        Me.pnlAssessment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAssessment.Location = New System.Drawing.Point(546, 29)
        Me.pnlAssessment.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.pnlAssessment.Name = "pnlAssessment"
        Me.pnlAssessment.Size = New System.Drawing.Size(144, 28)
        Me.pnlAssessment.TabIndex = 76
        '
        'lbAssessment
        '
        Me.lbAssessment.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbAssessment.AutoSize = True
        Me.lbAssessment.BackColor = System.Drawing.Color.Transparent
        Me.lbAssessment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAssessment.ForeColor = System.Drawing.Color.White
        Me.lbAssessment.Location = New System.Drawing.Point(4, 4)
        Me.lbAssessment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAssessment.Name = "lbAssessment"
        Me.lbAssessment.Size = New System.Drawing.Size(115, 20)
        Me.lbAssessment.TabIndex = 67
        Me.lbAssessment.Text = "Run assessment"
        Me.lbAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlB
        '
        Me.pnlB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlB.Controls.Add(Me.lbLastUpdated)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlB.Location = New System.Drawing.Point(190, 29)
        Me.pnlB.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.Size = New System.Drawing.Size(355, 28)
        Me.pnlB.TabIndex = 74
        '
        'pnlC
        '
        Me.pnlC.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlC.Controls.Add(Me.lbOperatingSystem)
        Me.pnlC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlC.Location = New System.Drawing.Point(190, 58)
        Me.pnlC.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.Size = New System.Drawing.Size(355, 28)
        Me.pnlC.TabIndex = 75
        '
        'BMPToolStripMenuItem
        '
        Me.BMPToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BMPToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BMPToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BMPToolStripMenuItem.Name = "BMPToolStripMenuItem"
        Me.BMPToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.BMPToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BMPToolStripMenuItem.Size = New System.Drawing.Size(283, 24)
        Me.BMPToolStripMenuItem.Text = "Save scores as BMP (High)"
        '
        'JPGToolStripMenuItem
        '
        Me.JPGToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.JPGToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JPGToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.JPGToolStripMenuItem.Name = "JPGToolStripMenuItem"
        Me.JPGToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.JPGToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.JPGToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JPGToolStripMenuItem.Size = New System.Drawing.Size(283, 24)
        Me.JPGToolStripMenuItem.Text = "Save scores as JPG (Low)"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PNGToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PNGToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.PNGToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(283, 24)
        Me.PNGToolStripMenuItem.Text = "Save scores as PNG (Med)"
        '
        'TXTToolStripMenuItem
        '
        Me.TXTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TXTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TXTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTToolStripMenuItem.Name = "TXTToolStripMenuItem"
        Me.TXTToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.TXTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TXTToolStripMenuItem.Size = New System.Drawing.Size(283, 24)
        Me.TXTToolStripMenuItem.Text = "Save scores to text file"
        '
        'cmsExport
        '
        Me.cmsExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmsExport.DropShadowEnabled = False
        Me.cmsExport.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JPGToolStripMenuItem, Me.PNGToolStripMenuItem, Me.BMPToolStripMenuItem, Me.ToolStripSeparator4, Me.TXTToolStripMenuItem, Me.ToolStripSeparator1, Me.ImgurToolStripMenuItem})
        Me.cmsExport.Name = "ContextMenuStrip1"
        Me.cmsExport.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsExport.ShowImageMargin = False
        Me.cmsExport.Size = New System.Drawing.Size(284, 136)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(280, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(280, 6)
        '
        'ImgurToolStripMenuItem
        '
        Me.ImgurToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ImgurToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ImgurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ImgurToolStripMenuItem.Name = "ImgurToolStripMenuItem"
        Me.ImgurToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ImgurToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImgurToolStripMenuItem.Size = New System.Drawing.Size(283, 24)
        Me.ImgurToolStripMenuItem.Text = "Upload screenshot to Imgur"
        '
        'cmsOptions
        '
        Me.cmsOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmsOptions.DropShadowEnabled = False
        Me.cmsOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewImgurLinksToolStripMenuItem, Me.ViewLogToolStripMenuItem, Me.ToolStripSeparator5, Me.RefreshScoresToolStripMenuItem, Me.ToolStripSeparator2, Me.SettingsToolstripMenuItem})
        Me.cmsOptions.Name = "ContextMenuStrip1"
        Me.cmsOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsOptions.ShowImageMargin = False
        Me.cmsOptions.Size = New System.Drawing.Size(239, 112)
        '
        'ViewImgurLinksToolStripMenuItem
        '
        Me.ViewImgurLinksToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ViewImgurLinksToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewImgurLinksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewImgurLinksToolStripMenuItem.Name = "ViewImgurLinksToolStripMenuItem"
        Me.ViewImgurLinksToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewImgurLinksToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ViewImgurLinksToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ViewImgurLinksToolStripMenuItem.Text = "View Imgur links"
        '
        'ViewLogToolStripMenuItem
        '
        Me.ViewLogToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ViewLogToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewLogToolStripMenuItem.Name = "ViewLogToolStripMenuItem"
        Me.ViewLogToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ViewLogToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ViewLogToolStripMenuItem.Text = "View Xiret log"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(235, 6)
        '
        'RefreshScoresToolStripMenuItem
        '
        Me.RefreshScoresToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RefreshScoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshScoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RefreshScoresToolStripMenuItem.Name = "RefreshScoresToolStripMenuItem"
        Me.RefreshScoresToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.RefreshScoresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshScoresToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.RefreshScoresToolStripMenuItem.Text = "Refresh scores"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(235, 6)
        '
        'SettingsToolstripMenuItem
        '
        Me.SettingsToolstripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SettingsToolstripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolstripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SettingsToolstripMenuItem.Name = "SettingsToolstripMenuItem"
        Me.SettingsToolstripMenuItem.ShortcutKeyDisplayString = ""
        Me.SettingsToolstripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolstripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.SettingsToolstripMenuItem.Text = "Settings"
        '
        'cmsTools
        '
        Me.cmsTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmsTools.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanupToolStripMenuItem, Me.ViewSystemDetailsToolStripMenuItem, Me.ToolStripSeparator6, Me.RunToolStripMenuItem, Me.RunVerboseToolStripMenuItem})
        Me.cmsTools.Name = "ContextMenuStrip1"
        Me.cmsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsTools.ShowImageMargin = False
        Me.cmsTools.Size = New System.Drawing.Size(260, 106)
        '
        'CleanupToolStripMenuItem
        '
        Me.CleanupToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CleanupToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanupToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CleanupToolStripMenuItem.Name = "CleanupToolStripMenuItem"
        Me.CleanupToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.CleanupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CleanupToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.CleanupToolStripMenuItem.Text = "Cleanup"
        '
        'ViewSystemDetailsToolStripMenuItem
        '
        Me.ViewSystemDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSystemDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewSystemDetailsToolStripMenuItem.Name = "ViewSystemDetailsToolStripMenuItem"
        Me.ViewSystemDetailsToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewSystemDetailsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewSystemDetailsToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.ViewSystemDetailsToolStripMenuItem.Text = "View system details"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(256, 6)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RunToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.RunToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.RunToolStripMenuItem.Text = "Run normal assessment"
        '
        'RunVerboseToolStripMenuItem
        '
        Me.RunVerboseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RunVerboseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunVerboseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RunVerboseToolStripMenuItem.Name = "RunVerboseToolStripMenuItem"
        Me.RunVerboseToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.RunVerboseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.RunVerboseToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.RunVerboseToolStripMenuItem.Text = "Run verbose assessment"
        '
        'cmsHelp
        '
        Me.cmsHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmsHelp.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaFeaturePackToolStripMenuItem, Me.TroubleshootingToolStripMenuItem, Me.ToolStripSeparator3, Me.CheckForUpdateToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.ToolStripSeparator7, Me.AboutToolStripMenuItem})
        Me.cmsHelp.Name = "cmsHelp"
        Me.cmsHelp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsHelp.ShowImageMargin = False
        Me.cmsHelp.Size = New System.Drawing.Size(237, 136)
        '
        'MediaFeaturePackToolStripMenuItem
        '
        Me.MediaFeaturePackToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MediaFeaturePackToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MediaFeaturePackToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MediaFeaturePackToolStripMenuItem.Name = "MediaFeaturePackToolStripMenuItem"
        Me.MediaFeaturePackToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.MediaFeaturePackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MediaFeaturePackToolStripMenuItem.Size = New System.Drawing.Size(236, 24)
        Me.MediaFeaturePackToolStripMenuItem.Text = "Media Feature Pack"
        '
        'TroubleshootingToolStripMenuItem
        '
        Me.TroubleshootingToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TroubleshootingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TroubleshootingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TroubleshootingToolStripMenuItem.Name = "TroubleshootingToolStripMenuItem"
        Me.TroubleshootingToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.TroubleshootingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TroubleshootingToolStripMenuItem.Size = New System.Drawing.Size(236, 24)
        Me.TroubleshootingToolStripMenuItem.Text = "Troubleshooting"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(233, 6)
        '
        'CheckForUpdateToolStripMenuItem
        '
        Me.CheckForUpdateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CheckForUpdateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckForUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        Me.CheckForUpdateToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.CheckForUpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CheckForUpdateToolStripMenuItem.Size = New System.Drawing.Size(236, 24)
        Me.CheckForUpdateToolStripMenuItem.Text = "Check for updates"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ChangelogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(236, 24)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(233, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(236, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GSwitchHardware
        '
        Me.GSwitchHardware.ActiveBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GSwitchHardware.ActiveBorderColor = System.Drawing.Color.White
        Me.GSwitchHardware.BackColor = System.Drawing.Color.Transparent
        Me.GSwitchHardware.InactiveBorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GSwitchHardware.Location = New System.Drawing.Point(42, 5)
        Me.GSwitchHardware.Margin = New System.Windows.Forms.Padding(4)
        Me.GSwitchHardware.Name = "GSwitchHardware"
        Me.GSwitchHardware.Size = New System.Drawing.Size(36, 18)
        Me.GSwitchHardware.SwitchHeadColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GSwitchHardware.SwitchOffColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GSwitchHardware.SwitchOnColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GSwitchHardware.TabIndex = 5
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 520)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlCapture)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(850, 520)
        Me.MinimumSize = New System.Drawing.Size(850, 520)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Experience Index UI"
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSubDisk.ResumeLayout(False)
        Me.PnlSubGaming.ResumeLayout(False)
        Me.PnlSubGraphics.ResumeLayout(False)
        Me.PnlSubMemory.ResumeLayout(False)
        Me.PnlSubProcessor.ResumeLayout(False)
        Me.pnlComp.ResumeLayout(False)
        Me.pnlComp.PerformLayout()
        Me.pnlRated.ResumeLayout(False)
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.tlpMenu.ResumeLayout(False)
        Me.pnlCapture.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.pnlSubMain.ResumeLayout(False)
        Me.pnlSubMain.PerformLayout()
        Me.tlpInf.ResumeLayout(False)
        Me.tlpSubscore.ResumeLayout(False)
        Me.pnlBaseScore.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.pnlValidity.ResumeLayout(False)
        Me.pnlValidity.PerformLayout()
        Me.pnlLastUpdated.ResumeLayout(False)
        Me.pnlLastUpdated.PerformLayout()
        Me.pnlD.ResumeLayout(False)
        Me.pnlMetrics.ResumeLayout(False)
        Me.pnlMetrics.PerformLayout()
        Me.pnlOperatingSystem.ResumeLayout(False)
        Me.pnlOperatingSystem.PerformLayout()
        Me.pnlA.ResumeLayout(False)
        Me.pnlA.PerformLayout()
        Me.pnlShowHardware.ResumeLayout(False)
        Me.pnlShowHardware.PerformLayout()
        Me.pnlAssessment.ResumeLayout(False)
        Me.pnlAssessment.PerformLayout()
        Me.pnlB.ResumeLayout(False)
        Me.pnlB.PerformLayout()
        Me.pnlC.ResumeLayout(False)
        Me.pnlC.PerformLayout()
        Me.cmsExport.ResumeLayout(False)
        Me.cmsOptions.ResumeLayout(False)
        Me.cmsTools.ResumeLayout(False)
        Me.cmsHelp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents lbState As System.Windows.Forms.Label
    Friend WithEvents GSwitchHardware As GambolSwitch
    Friend WithEvents lbShowOnPrint As System.Windows.Forms.Label
    Friend WithEvents lbOperatingSystem As System.Windows.Forms.Label
    Friend WithEvents lbBaseScore As System.Windows.Forms.Label
    Friend WithEvents sEleven As System.Windows.Forms.Label
    Friend WithEvents LBaseScore As System.Windows.Forms.Label
    Friend WithEvents sSub As System.Windows.Forms.Label
    Friend WithEvents lbWhatIsRated As System.Windows.Forms.Label
    Friend WithEvents LComponent As System.Windows.Forms.Label
    Friend WithEvents lbLastUpdated As System.Windows.Forms.Label
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents sOperatingSystem As System.Windows.Forms.Label
    Friend WithEvents sLastUpdate As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdMinimize As System.Windows.Forms.Button
    Friend WithEvents PnlSubDisk As System.Windows.Forms.Panel
    Friend WithEvents lbDiskScore As System.Windows.Forms.Label
    Friend WithEvents PnlSubGaming As System.Windows.Forms.Panel
    Friend WithEvents lbGamingScore As System.Windows.Forms.Label
    Friend WithEvents PnlSubGraphics As System.Windows.Forms.Panel
    Friend WithEvents lbGraphicsScore As System.Windows.Forms.Label
    Friend WithEvents PnlSubMemory As System.Windows.Forms.Panel
    Friend WithEvents lbMemoryScore As System.Windows.Forms.Label
    Friend WithEvents PnlSubProcessor As System.Windows.Forms.Panel
    Friend WithEvents lbCpuScore As System.Windows.Forms.Label
    Friend WithEvents pnlComp As System.Windows.Forms.Panel
    Friend WithEvents lbCompProc As System.Windows.Forms.Label
    Friend WithEvents lbCompDisk As System.Windows.Forms.Label
    Friend WithEvents lbCompGaming As System.Windows.Forms.Label
    Friend WithEvents lbCompGraphics As System.Windows.Forms.Label
    Friend WithEvents lbCompMem As System.Windows.Forms.Label
    Friend WithEvents lbScaleOf As System.Windows.Forms.Label
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents cmdOptions As System.Windows.Forms.Button
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents pnlCapture As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlSubMain As System.Windows.Forms.Panel
    Friend WithEvents pnlOperatingSystem As System.Windows.Forms.Panel
    Friend WithEvents pnlLastUpdated As System.Windows.Forms.Panel
    Friend WithEvents pnlC As System.Windows.Forms.Panel
    Friend WithEvents pnlB As System.Windows.Forms.Panel
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents pnlAssessment As System.Windows.Forms.Panel
    Friend WithEvents lbAssessment As System.Windows.Forms.Label
    Friend WithEvents pnlShowHardware As System.Windows.Forms.Panel
    Friend WithEvents sShow As System.Windows.Forms.Label
    Friend WithEvents pnlD As System.Windows.Forms.Panel
    Friend WithEvents pnlA As System.Windows.Forms.Panel
    Friend WithEvents pnlRated As System.Windows.Forms.Panel
    Friend WithEvents sProcessor As System.Windows.Forms.Label
    Friend WithEvents sDisk As System.Windows.Forms.Label
    Friend WithEvents sMemory As System.Windows.Forms.Label
    Friend WithEvents sGraphics As System.Windows.Forms.Label
    Friend WithEvents sGaming As System.Windows.Forms.Label
    Friend WithEvents cmdMetrics As System.Windows.Forms.Button
    Friend WithEvents pnlMetrics As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BMPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JPGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TXTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsExport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingsToolstripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImgurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlValidity As System.Windows.Forms.Panel
    Friend WithEvents pnlValidityState As System.Windows.Forms.Panel
    Friend WithEvents sValidity As System.Windows.Forms.Label
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpInf As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpSubscore As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlBaseScore As System.Windows.Forms.Panel
    Friend WithEvents ViewLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdTools As System.Windows.Forms.Button
    Friend WithEvents cmsTools As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunVerboseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsHelp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TroubleshootingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaFeaturePackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewImgurLinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CleanupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ViewSystemDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbHeadVer As Label
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdHotfix As Button
End Class
