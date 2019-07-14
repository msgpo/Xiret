<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormException
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormException))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.cmdForceQuit = New System.Windows.Forms.Button()
        Me.lbText = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSendReport = New System.Windows.Forms.Button()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.pnlHead.Controls.Add(Me.tlpIcon)
        Me.pnlHead.Controls.Add(Me.lbHead)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(1, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(648, 40)
        Me.pnlHead.TabIndex = 1
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
        Me.tlpIcon.Size = New System.Drawing.Size(41, 40)
        Me.tlpIcon.TabIndex = 16
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
        Me.lbHead.Location = New System.Drawing.Point(205, 2)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(240, 38)
        Me.lbHead.TabIndex = 15
        Me.lbHead.Text = "Application Support"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbStatus
        '
        Me.lbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.ForeColor = System.Drawing.Color.White
        Me.lbStatus.Location = New System.Drawing.Point(4, 224)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(640, 30)
        Me.lbStatus.TabIndex = 14
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdContinue
        '
        Me.cmdContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdContinue.Enabled = False
        Me.cmdContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdContinue.FlatAppearance.BorderSize = 0
        Me.cmdContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContinue.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdContinue.Location = New System.Drawing.Point(115, 0)
        Me.cmdContinue.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.Size = New System.Drawing.Size(108, 35)
        Me.cmdContinue.TabIndex = 10
        Me.cmdContinue.TabStop = False
        Me.cmdContinue.Text = "Continue"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'cmdForceQuit
        '
        Me.cmdForceQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdForceQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdForceQuit.FlatAppearance.BorderSize = 0
        Me.cmdForceQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdForceQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdForceQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdForceQuit.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForceQuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdForceQuit.Location = New System.Drawing.Point(0, 0)
        Me.cmdForceQuit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdForceQuit.Name = "cmdForceQuit"
        Me.cmdForceQuit.Size = New System.Drawing.Size(108, 35)
        Me.cmdForceQuit.TabIndex = 9
        Me.cmdForceQuit.TabStop = False
        Me.cmdForceQuit.Text = "Force Quit"
        Me.cmdForceQuit.UseVisualStyleBackColor = False
        '
        'lbText
        '
        Me.lbText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbText.Location = New System.Drawing.Point(4, 114)
        Me.lbText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbText.Name = "lbText"
        Me.lbText.Size = New System.Drawing.Size(640, 93)
        Me.lbText.TabIndex = 7
        Me.lbText.Text = resources.GetString("lbText.Text")
        Me.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbInfo
        '
        Me.lbInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbInfo.Location = New System.Drawing.Point(4, 10)
        Me.lbInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(640, 91)
        Me.lbInfo.TabIndex = 6
        Me.lbInfo.Text = "..."
        Me.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(648, 2)
        Me.pnlSplit.TabIndex = 73
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lbStatus)
        Me.pnlMain.Controls.Add(Me.tlpButtons)
        Me.pnlMain.Controls.Add(Me.lbInfo)
        Me.pnlMain.Controls.Add(Me.lbText)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(648, 326)
        Me.pnlMain.TabIndex = 74
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 5
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.tlpButtons.Controls.Add(Me.cmdForceQuit, 0, 0)
        Me.tlpButtons.Controls.Add(Me.cmdContinue, 2, 0)
        Me.tlpButtons.Controls.Add(Me.cmdSendReport, 4, 0)
        Me.tlpButtons.Location = New System.Drawing.Point(155, 271)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(340, 35)
        Me.tlpButtons.TabIndex = 12
        '
        'cmdSendReport
        '
        Me.cmdSendReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdSendReport.Enabled = False
        Me.cmdSendReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdSendReport.FlatAppearance.BorderSize = 0
        Me.cmdSendReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdSendReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdSendReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSendReport.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSendReport.Location = New System.Drawing.Point(230, 0)
        Me.cmdSendReport.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSendReport.Name = "cmdSendReport"
        Me.cmdSendReport.Size = New System.Drawing.Size(108, 35)
        Me.cmdSendReport.TabIndex = 11
        Me.cmdSendReport.TabStop = False
        Me.cmdSendReport.Text = "Send Report"
        Me.cmdSendReport.UseVisualStyleBackColor = False
        '
        'FormException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 370)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(650, 370)
        Me.MinimumSize = New System.Drawing.Size(650, 370)
        Me.Name = "FormException"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Support (Exception)"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbText As System.Windows.Forms.Label
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents cmdContinue As System.Windows.Forms.Button
    Friend WithEvents cmdForceQuit As System.Windows.Forms.Button
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents tlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdSendReport As System.Windows.Forms.Button
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
End Class
