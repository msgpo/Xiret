<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnvironment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEnvironment))
        Me.cmdOkay = New System.Windows.Forms.Button()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.tlpIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.llWebsite = New System.Windows.Forms.LinkLabel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlHead.SuspendLayout()
        Me.tlpIcon.SuspendLayout()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdOkay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOkay.Location = New System.Drawing.Point(343, 137)
        Me.cmdOkay.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOkay.Name = "cmdOkay"
        Me.cmdOkay.Size = New System.Drawing.Size(75, 31)
        Me.cmdOkay.TabIndex = 1
        Me.cmdOkay.TabStop = False
        Me.cmdOkay.Text = "OK"
        Me.cmdOkay.UseVisualStyleBackColor = False
        '
        'lbMessage
        '
        Me.lbMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lbMessage.Location = New System.Drawing.Point(13, 15)
        Me.lbMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(405, 98)
        Me.lbMessage.TabIndex = 4
        Me.lbMessage.Text = ",,,"
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
        Me.pnlHead.Size = New System.Drawing.Size(428, 40)
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
        Me.tlpIcon.Size = New System.Drawing.Size(51, 40)
        Me.tlpIcon.TabIndex = 10
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
        Me.lbHead.Location = New System.Drawing.Point(118, 2)
        Me.lbHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(195, 38)
        Me.lbHead.TabIndex = 1
        Me.lbHead.Text = "Application Support"
        Me.lbHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llWebsite
        '
        Me.llWebsite.ActiveLinkColor = System.Drawing.Color.White
        Me.llWebsite.AutoSize = True
        Me.llWebsite.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llWebsite.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llWebsite.Location = New System.Drawing.Point(13, 141)
        Me.llWebsite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llWebsite.Name = "llWebsite"
        Me.llWebsite.Size = New System.Drawing.Size(168, 23)
        Me.llWebsite.TabIndex = 6
        Me.llWebsite.TabStop = True
        Me.llWebsite.Text = "View Support Forum"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlSplit)
        Me.pnlMain.Controls.Add(Me.lbMessage)
        Me.pnlMain.Controls.Add(Me.llWebsite)
        Me.pnlMain.Controls.Add(Me.cmdOkay)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 41)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(428, 178)
        Me.pnlMain.TabIndex = 7
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(0, 0)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(428, 2)
        Me.pnlSplit.TabIndex = 73
        '
        'FormEnvironment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 220)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(430, 220)
        Me.MinimumSize = New System.Drawing.Size(430, 220)
        Me.Name = "FormEnvironment"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Support (Unsupported OS)"
        Me.pnlHead.ResumeLayout(False)
        Me.tlpIcon.ResumeLayout(False)
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents lbHead As System.Windows.Forms.Label
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents cmdOkay As System.Windows.Forms.Button
    Friend WithEvents llWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents tlpIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxMain As System.Windows.Forms.PictureBox
End Class
