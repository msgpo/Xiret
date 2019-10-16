Imports Xiret.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAssess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAssess))
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanTop = New System.Windows.Forms.Panel()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxLoad = New System.Windows.Forms.PictureBox()
        Me.LabStatus = New System.Windows.Forms.Label()
        Me.LabProgress = New System.Windows.Forms.Label()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.TlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdViewLog = New System.Windows.Forms.Button()
        Me.GProgressBar = New Controls.GambolProgressBar()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        CType(Me.PbxLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(0, 0)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(110, 35)
        Me.CmdCancel.TabIndex = 0
        Me.CmdCancel.Text = "Quit Process"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(598, 40)
        Me.PanHead.TabIndex = 1
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
        Me.CmdClose.TabIndex = 0
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
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(233, 3)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(135, 36)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "Assessment"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(598, 2)
        Me.PanSplit.TabIndex = 73
        '
        'PanTop
        '
        Me.PanTop.BackColor = System.Drawing.Color.Transparent
        Me.PanTop.Controls.Add(Me.TlpTop)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(598, 47)
        Me.PanTop.TabIndex = 74
        '
        'TlpTop
        '
        Me.TlpTop.BackColor = System.Drawing.Color.Transparent
        Me.TlpTop.ColumnCount = 3
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TlpTop.Controls.Add(Me.PbxLoad, 0, 0)
        Me.TlpTop.Controls.Add(Me.LabStatus, 0, 0)
        Me.TlpTop.Controls.Add(Me.LabProgress, 2, 0)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpTop.Location = New System.Drawing.Point(0, 0)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.Size = New System.Drawing.Size(598, 47)
        Me.TlpTop.TabIndex = 1
        '
        'PbxLoad
        '
        Me.PbxLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxLoad.BackColor = System.Drawing.Color.Transparent
        Me.PbxLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxLoad.Image = Global.Xiret.My.Resources.Resources.imgprocess
        Me.PbxLoad.Location = New System.Drawing.Point(515, 11)
        Me.PbxLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLoad.Name = "PbxLoad"
        Me.PbxLoad.Size = New System.Drawing.Size(24, 24)
        Me.PbxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLoad.TabIndex = 5
        Me.PbxLoad.TabStop = False
        '
        'LabStatus
        '
        Me.LabStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabStatus.ForeColor = System.Drawing.Color.White
        Me.LabStatus.Location = New System.Drawing.Point(4, 0)
        Me.LabStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabStatus.Name = "LabStatus"
        Me.LabStatus.Size = New System.Drawing.Size(507, 47)
        Me.LabStatus.TabIndex = 2
        Me.LabStatus.Text = "..."
        Me.LabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabProgress
        '
        Me.LabProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabProgress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabProgress.ForeColor = System.Drawing.Color.White
        Me.LabProgress.Location = New System.Drawing.Point(543, 0)
        Me.LabProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabProgress.Name = "LabProgress"
        Me.LabProgress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabProgress.Size = New System.Drawing.Size(51, 47)
        Me.LabProgress.TabIndex = 4
        Me.LabProgress.Text = "..."
        Me.LabProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.LabInfo)
        Me.PanMain.Controls.Add(Me.TlpButtons)
        Me.PanMain.Controls.Add(Me.GProgressBar)
        Me.PanMain.Controls.Add(Me.PanTop)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(598, 256)
        Me.PanMain.TabIndex = 75
        '
        'LabInfo
        '
        Me.LabInfo.BackColor = System.Drawing.Color.Transparent
        Me.LabInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.LabInfo.Location = New System.Drawing.Point(0, 49)
        Me.LabInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Size = New System.Drawing.Size(598, 144)
        Me.LabInfo.TabIndex = 78
        Me.LabInfo.Text = "This process may take several minutes. Your screen may flash or go black during t" &
    "he assessment."
        Me.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TlpButtons
        '
        Me.TlpButtons.ColumnCount = 3
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 464.0!))
        Me.TlpButtons.Controls.Add(Me.CmdCancel, 0, 0)
        Me.TlpButtons.Controls.Add(Me.CmdViewLog, 2, 0)
        Me.TlpButtons.Location = New System.Drawing.Point(9, 211)
        Me.TlpButtons.Name = "TlpButtons"
        Me.TlpButtons.RowCount = 1
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpButtons.Size = New System.Drawing.Size(228, 35)
        Me.TlpButtons.TabIndex = 77
        '
        'CmdViewLog
        '
        Me.CmdViewLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdViewLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdViewLog.FlatAppearance.BorderSize = 0
        Me.CmdViewLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdViewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdViewLog.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdViewLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdViewLog.Location = New System.Drawing.Point(117, 0)
        Me.CmdViewLog.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdViewLog.Name = "CmdViewLog"
        Me.CmdViewLog.Size = New System.Drawing.Size(110, 35)
        Me.CmdViewLog.TabIndex = 1
        Me.CmdViewLog.Text = "View Log"
        Me.CmdViewLog.UseVisualStyleBackColor = False
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
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
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        CType(Me.PbxLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanTop As System.Windows.Forms.Panel
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents GProgressBar As GambolProgressBar
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents TlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CmdViewLog As System.Windows.Forms.Button
    Friend WithEvents TlpTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxLoad As System.Windows.Forms.PictureBox
    Friend WithEvents LabStatus As System.Windows.Forms.Label
    Friend WithEvents LabProgress As System.Windows.Forms.Label
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents LabInfo As Label
End Class
