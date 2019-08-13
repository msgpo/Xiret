Imports Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAssess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAssess))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxLoad = New System.Windows.Forms.PictureBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.lbProgress = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.GProgressBar = New Gambol.Controls.GambolProgressBar()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pbxLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(0, 0)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(110, 35)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Quit Process"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.pnlHead.Controls.Add(Me.CmdClose)
        Me.pnlHead.Controls.Add(Me.tlpIcon)
        Me.pnlHead.Controls.Add(Me.lbHead)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(1, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(598, 40)
        Me.pnlHead.TabIndex = 1
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(558, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 73
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
        Me.tlpIcon.Size = New System.Drawing.Size(42, 40)
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
        Me.lbHead.Location = New System.Drawing.Point(233, 3)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(135, 36)
        Me.lbHead.TabIndex = 70
        Me.lbHead.Text = "Assessment"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbInfo
        '
        Me.lbInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lbInfo.Location = New System.Drawing.Point(4, 0)
        Me.lbInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(590, 144)
        Me.lbInfo.TabIndex = 4
        Me.lbInfo.Text = "This process may take several minutes. Your screen may flash or go black during t" &
    "he assessment."
        Me.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(598, 2)
        Me.pnlSplit.TabIndex = 73
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(598, 47)
        Me.pnlTop.TabIndex = 74
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pbxLoad, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbStatus, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbProgress, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(598, 47)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'pbxLoad
        '
        Me.pbxLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxLoad.BackColor = System.Drawing.Color.Transparent
        Me.pbxLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLoad.Image = Global.Xiret.My.Resources.Resources.imgprocess
        Me.pbxLoad.Location = New System.Drawing.Point(515, 11)
        Me.pbxLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxLoad.Name = "pbxLoad"
        Me.pbxLoad.Size = New System.Drawing.Size(24, 24)
        Me.pbxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLoad.TabIndex = 5
        Me.pbxLoad.TabStop = False
        '
        'lbStatus
        '
        Me.lbStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.ForeColor = System.Drawing.Color.White
        Me.lbStatus.Location = New System.Drawing.Point(4, 0)
        Me.lbStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(507, 47)
        Me.lbStatus.TabIndex = 2
        Me.lbStatus.Text = "Gathering system information..."
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbProgress
        '
        Me.lbProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProgress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProgress.ForeColor = System.Drawing.Color.White
        Me.lbProgress.Location = New System.Drawing.Point(543, 0)
        Me.lbProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbProgress.Name = "lbProgress"
        Me.lbProgress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbProgress.Size = New System.Drawing.Size(51, 47)
        Me.lbProgress.TabIndex = 4
        Me.lbProgress.Text = "0"
        Me.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlMain.Controls.Add(Me.tlpButtons)
        Me.pnlMain.Controls.Add(Me.GProgressBar)
        Me.pnlMain.Controls.Add(Me.pnlTop)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(598, 256)
        Me.pnlMain.TabIndex = 75
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbInfo, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 49)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.97453!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(598, 144)
        Me.TableLayoutPanel3.TabIndex = 78
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 3
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
        Me.tlpButtons.Controls.Add(Me.cmdCancel, 0, 0)
        Me.tlpButtons.Controls.Add(Me.cmdLog, 2, 0)
        Me.tlpButtons.Location = New System.Drawing.Point(9, 211)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(228, 35)
        Me.tlpButtons.TabIndex = 77
        '
        'cmdLog
        '
        Me.cmdLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdLog.FlatAppearance.BorderSize = 0
        Me.cmdLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLog.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLog.Location = New System.Drawing.Point(117, 0)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(110, 35)
        Me.cmdLog.TabIndex = 1
        Me.cmdLog.Text = "View Log"
        Me.cmdLog.UseVisualStyleBackColor = False
        '
        'GProgressBar
        '
        Me.GProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GProgressBar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GProgressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.GProgressBar.Location = New System.Drawing.Point(0, 47)
        Me.GProgressBar.Margin = New System.Windows.Forms.Padding(2)
        Me.GProgressBar.Maximum = 100
        Me.GProgressBar.Name = "GProgressBar"
        Me.GProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GProgressBar.ShowBorder = False
        Me.GProgressBar.Size = New System.Drawing.Size(598, 2)
        Me.GProgressBar.TabIndex = 75
        Me.GProgressBar.Text = "GProgressBar"
        Me.GProgressBar.Value = 0
        '
        'FormAssess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(600, 300)
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "FormAssess"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assessment"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.pbxLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents GProgressBar As GambolProgressBar
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents tlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdLog As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxLoad As System.Windows.Forms.PictureBox
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents lbProgress As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents CmdClose As Button
End Class
