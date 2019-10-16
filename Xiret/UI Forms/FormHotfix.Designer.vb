<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHotfix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHotfix))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdInstall = New System.Windows.Forms.Button()
        Me.LabDownload = New System.Windows.Forms.Label()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.LabInfo2 = New System.Windows.Forms.Label()
        Me.LnkHotfix = New System.Windows.Forms.LinkLabel()
        Me.LabError = New System.Windows.Forms.Label()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.PbrPercentage = New Xiret.Controls.GambolProgressBar()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanHead.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(2)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(538, 40)
        Me.PanHead.TabIndex = 126
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
        Me.LabHead.Size = New System.Drawing.Size(458, 40)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "Application Support"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PbxHead.Image = Global.Xiret.My.Resources.Resources.icon24px
        Me.PbxHead.Location = New System.Drawing.Point(9, 8)
        Me.PbxHead.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PbxHead.Name = "PbxHead"
        Me.PbxHead.Size = New System.Drawing.Size(24, 24)
        Me.PbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHead.TabIndex = 1
        Me.PbxHead.TabStop = False
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
        Me.CmdClose.Location = New System.Drawing.Point(498, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(538, 2)
        Me.PanSplit.TabIndex = 127
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanMain.Controls.Add(Me.PbrPercentage)
        Me.PanMain.Controls.Add(Me.TlpBottom)
        Me.PanMain.Controls.Add(Me.LabInfo2)
        Me.PanMain.Controls.Add(Me.LnkHotfix)
        Me.PanMain.Controls.Add(Me.LabError)
        Me.PanMain.Controls.Add(Me.LabInfo)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(538, 276)
        Me.PanMain.TabIndex = 128
        '
        'TlpBottom
        '
        Me.TlpBottom.ColumnCount = 3
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TlpBottom.Controls.Add(Me.CmdInstall, 2, 0)
        Me.TlpBottom.Controls.Add(Me.LabDownload, 0, 0)
        Me.TlpBottom.Controls.Add(Me.CmdCancel, 1, 0)
        Me.TlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TlpBottom.Location = New System.Drawing.Point(0, 229)
        Me.TlpBottom.Margin = New System.Windows.Forms.Padding(3, 3, 3, 67)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 1
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(538, 47)
        Me.TlpBottom.TabIndex = 136
        '
        'CmdInstall
        '
        Me.CmdInstall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdInstall.FlatAppearance.BorderSize = 0
        Me.CmdInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdInstall.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdInstall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInstall.Location = New System.Drawing.Point(452, 6)
        Me.CmdInstall.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdInstall.Name = "CmdInstall"
        Me.CmdInstall.Size = New System.Drawing.Size(80, 35)
        Me.CmdInstall.TabIndex = 2
        Me.CmdInstall.Text = "Install"
        Me.CmdInstall.UseVisualStyleBackColor = False
        '
        'LabDownload
        '
        Me.LabDownload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabDownload.AutoSize = True
        Me.LabDownload.BackColor = System.Drawing.Color.Transparent
        Me.LabDownload.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDownload.ForeColor = System.Drawing.Color.White
        Me.LabDownload.Location = New System.Drawing.Point(3, 13)
        Me.LabDownload.Name = "LabDownload"
        Me.LabDownload.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabDownload.Size = New System.Drawing.Size(5, 20)
        Me.LabDownload.TabIndex = 1
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdCancel.FlatAppearance.BorderSize = 0
        Me.CmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(363, 6)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(80, 35)
        Me.CmdCancel.TabIndex = 1
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'LabInfo2
        '
        Me.LabInfo2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo2.ForeColor = System.Drawing.Color.White
        Me.LabInfo2.Location = New System.Drawing.Point(0, 98)
        Me.LabInfo2.Name = "LabInfo2"
        Me.LabInfo2.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.LabInfo2.Size = New System.Drawing.Size(538, 88)
        Me.LabInfo2.TabIndex = 132
        Me.LabInfo2.Text = resources.GetString("LabInfo2.Text")
        Me.LabInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkHotfix
        '
        Me.LnkHotfix.ActiveLinkColor = System.Drawing.Color.White
        Me.LnkHotfix.AutoSize = True
        Me.LnkHotfix.BackColor = System.Drawing.Color.Transparent
        Me.LnkHotfix.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkHotfix.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkHotfix.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LnkHotfix.Location = New System.Drawing.Point(7, 197)
        Me.LnkHotfix.Name = "LnkHotfix"
        Me.LnkHotfix.Size = New System.Drawing.Size(136, 20)
        Me.LnkHotfix.TabIndex = 0
        Me.LnkHotfix.TabStop = True
        Me.LnkHotfix.Text = "Hotfix Information"
        '
        'LabError
        '
        Me.LabError.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LabError.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabError.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabError.ForeColor = System.Drawing.Color.Tomato
        Me.LabError.Location = New System.Drawing.Point(0, 66)
        Me.LabError.Name = "LabError"
        Me.LabError.Padding = New System.Windows.Forms.Padding(7, 5, 0, 0)
        Me.LabError.Size = New System.Drawing.Size(538, 32)
        Me.LabError.TabIndex = 1
        Me.LabError.Text = """Failed to properly assess the disk. The parameter is incorrect."""
        '
        'LabInfo
        '
        Me.LabInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LabInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInfo.ForeColor = System.Drawing.Color.White
        Me.LabInfo.Location = New System.Drawing.Point(0, 0)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Padding = New System.Windows.Forms.Padding(7, 7, 0, 0)
        Me.LabInfo.Size = New System.Drawing.Size(538, 66)
        Me.LabInfo.TabIndex = 0
        Me.LabInfo.Text = "This system is missing a hotfix that patches an bug with winsat.exe. If you're" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" &
    "xperiencing the below error when running an assessment said hotfix can be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "insta" &
    "lled from here:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PbrPercentage
        '
        Me.PbrPercentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PbrPercentage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PbrPercentage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PbrPercentage.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PbrPercentage.ForeColor = System.Drawing.Color.White
        Me.PbrPercentage.Location = New System.Drawing.Point(0, 224)
        Me.PbrPercentage.Maximum = 100
        Me.PbrPercentage.Name = "PbrPercentage"
        Me.PbrPercentage.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PbrPercentage.ShowBorder = False
        Me.PbrPercentage.Size = New System.Drawing.Size(538, 5)
        Me.PbrPercentage.TabIndex = 137
        Me.PbrPercentage.Value = 0
        '
        'FormHotfix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 320)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(540, 320)
        Me.MinimumSize = New System.Drawing.Size(540, 320)
        Me.Name = "FormHotfix"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Application Support"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.PanMain.PerformLayout()
        Me.TlpBottom.ResumeLayout(False)
        Me.TlpBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents LabHead As Label
    Friend WithEvents PanSplit As Panel
    Friend WithEvents PanMain As Panel
    Friend WithEvents LabInfo As Label
    Friend WithEvents LabError As Label
    Friend WithEvents LnkHotfix As LinkLabel
    Friend WithEvents LabInfo2 As Label
    Friend WithEvents TlpBottom As TableLayoutPanel
    Friend WithEvents CmdInstall As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents LabDownload As Label
    Friend WithEvents PbrPercentage As Controls.GambolProgressBar
End Class
