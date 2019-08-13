Imports Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormToast
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
        Me.tDraw = New System.Windows.Forms.Timer(Me.components)
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GProgressBar = New Gambol.Controls.GambolProgressBar()
        Me.pnlmain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tDraw
        '
        Me.tDraw.Enabled = True
        Me.tDraw.Interval = 10
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlmain.BackgroundImage = Global.Xiret.My.Resources.Resources.imgtilehead
        Me.pnlmain.Controls.Add(Me.cmdClose)
        Me.pnlmain.Controls.Add(Me.lbTitle)
        Me.pnlmain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlmain.Location = New System.Drawing.Point(1, 1)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(498, 40)
        Me.pnlmain.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(458, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.White
        Me.lbTitle.Location = New System.Drawing.Point(13, 9)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(25, 23)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "..."
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMessage
        '
        Me.lbMessage.BackColor = System.Drawing.Color.Transparent
        Me.lbMessage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessage.ForeColor = System.Drawing.Color.White
        Me.lbMessage.Location = New System.Drawing.Point(13, 12)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(475, 109)
        Me.lbMessage.TabIndex = 1
        Me.lbMessage.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GProgressBar)
        Me.Panel1.Controls.Add(Me.lbMessage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 138)
        Me.Panel1.TabIndex = 2
        '
        'GProgressBar
        '
        Me.GProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GProgressBar.BorderColor = System.Drawing.Color.Transparent
        Me.GProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GProgressBar.ForeColor = System.Drawing.Color.Transparent
        Me.GProgressBar.Location = New System.Drawing.Point(0, 128)
        Me.GProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.GProgressBar.Maximum = 200
        Me.GProgressBar.Name = "GProgressBar"
        Me.GProgressBar.ProgressColor = System.Drawing.Color.White
        Me.GProgressBar.ShowBorder = False
        Me.GProgressBar.Size = New System.Drawing.Size(498, 10)
        Me.GProgressBar.TabIndex = 3
        Me.GProgressBar.Text = "GProgressBar"
        Me.GProgressBar.Value = 0
        '
        'FormToast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 180)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlmain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(500, 180)
        Me.MinimumSize = New System.Drawing.Size(500, 180)
        Me.Name = "FormToast"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notification"
        Me.pnlmain.ResumeLayout(False)
        Me.pnlmain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tDraw As System.Windows.Forms.Timer
    Friend WithEvents pnlmain As System.Windows.Forms.Panel
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GProgressBar As GambolProgressBar
End Class
