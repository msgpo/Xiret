<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFont
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFont))
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.cmdInstall = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbInformation = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tlpBottom)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(488, 254)
        Me.pnlMain.TabIndex = 131
        '
        'tlpBottom
        '
        Me.tlpBottom.ColumnCount = 3
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpBottom.Controls.Add(Me.lbInfo, 0, 0)
        Me.tlpBottom.Controls.Add(Me.cmdInstall, 2, 0)
        Me.tlpBottom.Controls.Add(Me.cmdCancel, 1, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpBottom.Location = New System.Drawing.Point(0, 194)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 3, 3, 67)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 1
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(488, 60)
        Me.tlpBottom.TabIndex = 135
        '
        'lbInfo
        '
        Me.lbInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbInfo.ForeColor = System.Drawing.Color.White
        Me.lbInfo.Location = New System.Drawing.Point(3, 0)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.lbInfo.Size = New System.Drawing.Size(305, 60)
        Me.lbInfo.TabIndex = 1
        Me.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdInstall
        '
        Me.cmdInstall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdInstall.FlatAppearance.BorderSize = 0
        Me.cmdInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInstall.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInstall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdInstall.Location = New System.Drawing.Point(402, 22)
        Me.cmdInstall.Margin = New System.Windows.Forms.Padding(0, 14, 0, 0)
        Me.cmdInstall.Name = "cmdInstall"
        Me.cmdInstall.Size = New System.Drawing.Size(79, 30)
        Me.cmdInstall.TabIndex = 133
        Me.cmdInstall.Text = "Install"
        Me.cmdInstall.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(314, 22)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0, 14, 0, 0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(78, 30)
        Me.cmdCancel.TabIndex = 134
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbInformation, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 184)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbInformation
        '
        Me.lbInformation.AutoSize = True
        Me.lbInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformation.ForeColor = System.Drawing.Color.White
        Me.lbInformation.Location = New System.Drawing.Point(0, 0)
        Me.lbInformation.Margin = New System.Windows.Forms.Padding(0)
        Me.lbInformation.Name = "lbInformation"
        Me.lbInformation.Padding = New System.Windows.Forms.Padding(6)
        Me.lbInformation.Size = New System.Drawing.Size(453, 172)
        Me.lbInformation.TabIndex = 132
        Me.lbInformation.Text = resources.GetString("lbInformation.Text")
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(488, 2)
        Me.pnlSplit.TabIndex = 130
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
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(488, 40)
        Me.pnlHead.TabIndex = 129
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
        Me.CmdClose.Location = New System.Drawing.Point(448, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
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
        Me.lbHead.Location = New System.Drawing.Point(181, 2)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(129, 38)
        Me.lbHead.TabIndex = 70
        Me.lbHead.Text = "Support"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 298)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(490, 298)
        Me.Name = "FormFont"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFont"
        Me.pnlMain.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlHead As Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents tlpIcon As TableLayoutPanel
    Friend WithEvents pbxMain As PictureBox
    Friend WithEvents lbHead As Label
    Friend WithEvents tlpBottom As TableLayoutPanel
    Friend WithEvents cmdInstall As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbInformation As Label
    Friend WithEvents lbInfo As Label
End Class
