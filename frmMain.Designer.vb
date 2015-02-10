<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnAddRes = New System.Windows.Forms.Button()
        Me.pbSub = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSrc = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.lbWbStatus = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wbCheck = New System.Windows.Forms.WebBrowser()
        Me.pnlFunctions = New System.Windows.Forms.Panel()
        Me.libtnStart = New 字幕组追剧助手.LogInButtonWithProgress()
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        Me.pnlControl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddRes
        '
        Me.btnAddRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAddRes.FlatAppearance.BorderSize = 0
        Me.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRes.ForeColor = System.Drawing.Color.White
        Me.btnAddRes.Location = New System.Drawing.Point(3, 3)
        Me.btnAddRes.Name = "btnAddRes"
        Me.btnAddRes.Size = New System.Drawing.Size(100, 33)
        Me.btnAddRes.TabIndex = 14
        Me.btnAddRes.Text = "追剧管理"
        Me.btnAddRes.UseVisualStyleBackColor = False
        '
        'pbSub
        '
        Me.pbSub.Location = New System.Drawing.Point(5, 180)
        Me.pbSub.Name = "pbSub"
        Me.pbSub.Size = New System.Drawing.Size(370, 23)
        Me.pbSub.TabIndex = 15
        Me.pbSub.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "欢迎使用字幕组追剧助手"
        '
        'btnSrc
        '
        Me.btnSrc.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSrc.FlatAppearance.BorderSize = 0
        Me.btnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrc.ForeColor = System.Drawing.Color.White
        Me.btnSrc.Location = New System.Drawing.Point(109, 3)
        Me.btnSrc.Name = "btnSrc"
        Me.btnSrc.Size = New System.Drawing.Size(100, 33)
        Me.btnSrc.TabIndex = 17
        Me.btnSrc.Text = "追剧源管理"
        Me.btnSrc.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(109, 42)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(100, 26)
        Me.btnAbout.TabIndex = 18
        Me.btnAbout.Text = "关于/更新"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(3, 42)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(100, 26)
        Me.btnSettings.TabIndex = 19
        Me.btnSettings.Text = "设置/帮助"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.lbWbStatus)
        Me.pnlControl.Controls.Add(Me.btnRefresh)
        Me.pnlControl.Controls.Add(Me.btnNext)
        Me.pnlControl.Enabled = False
        Me.pnlControl.Location = New System.Drawing.Point(5, 203)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(370, 28)
        Me.pnlControl.TabIndex = 20
        '
        'lbWbStatus
        '
        Me.lbWbStatus.AutoSize = True
        Me.lbWbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lbWbStatus.Location = New System.Drawing.Point(3, 8)
        Me.lbWbStatus.Name = "lbWbStatus"
        Me.lbWbStatus.Size = New System.Drawing.Size(77, 12)
        Me.lbWbStatus.TabIndex = 2
        Me.lbWbStatus.Text = "点击按钮开始"
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRefresh.Image = Global.字幕组追剧助手.My.Resources.Resources.refresh_16
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(250, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(57, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "重试"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnNext.Image = Global.字幕组追剧助手.My.Resources.Resources.cancel_16
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(310, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(57, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "跳过"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.字幕组追剧助手.My.Resources.Resources.main_new
        Me.PictureBox1.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'wbCheck
        '
        Me.wbCheck.Location = New System.Drawing.Point(25, 16)
        Me.wbCheck.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCheck.Name = "wbCheck"
        Me.wbCheck.ScriptErrorsSuppressed = True
        Me.wbCheck.Size = New System.Drawing.Size(119, 47)
        Me.wbCheck.TabIndex = 21
        Me.wbCheck.Visible = False
        '
        'pnlFunctions
        '
        Me.pnlFunctions.Controls.Add(Me.btnSrc)
        Me.pnlFunctions.Controls.Add(Me.btnAddRes)
        Me.pnlFunctions.Controls.Add(Me.btnAbout)
        Me.pnlFunctions.Controls.Add(Me.btnSettings)
        Me.pnlFunctions.Location = New System.Drawing.Point(166, 60)
        Me.pnlFunctions.Name = "pnlFunctions"
        Me.pnlFunctions.Size = New System.Drawing.Size(218, 82)
        Me.pnlFunctions.TabIndex = 22
        '
        'libtnStart
        '
        Me.libtnStart.BackColor = System.Drawing.Color.Transparent
        Me.libtnStart.BaseColour = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.libtnStart.BorderColour = System.Drawing.Color.Transparent
        Me.libtnStart.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.libtnStart.HoverColour = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.libtnStart.Location = New System.Drawing.Point(5, 148)
        Me.libtnStart.Maximum = 100
        Me.libtnStart.Name = "libtnStart"
        Me.libtnStart.PressedColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.libtnStart.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.libtnStart.Size = New System.Drawing.Size(370, 50)
        Me.libtnStart.TabIndex = 3
        Me.libtnStart.Text = "点我检查剧集更新"
        Me.libtnStart.Value = 100
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(5, 131)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(370, 20)
        Me.LogInSeperator1.TabIndex = 5
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 231)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.libtnStart)
        Me.Controls.Add(Me.pbSub)
        Me.Controls.Add(Me.LogInSeperator1)
        Me.Controls.Add(Me.pnlFunctions)
        Me.Controls.Add(Me.wbCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFunctions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents libtnStart As 字幕组追剧助手.LogInButtonWithProgress
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents btnAddRes As System.Windows.Forms.Button
    Friend WithEvents pbSub As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSrc As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lbWbStatus As System.Windows.Forms.Label
    Friend WithEvents wbCheck As System.Windows.Forms.WebBrowser
    Friend WithEvents pnlFunctions As System.Windows.Forms.Panel

End Class
