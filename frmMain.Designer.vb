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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.wbCheck = New System.Windows.Forms.WebBrowser()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddRes = New System.Windows.Forms.Button()
        Me.pbSub = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.libtnStart = New 字幕组追剧助手.LogInButtonWithProgress()
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(344, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "使用说明"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(344, 69)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "软件更新"
        '
        'wbCheck
        '
        Me.wbCheck.Location = New System.Drawing.Point(566, 295)
        Me.wbCheck.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCheck.Name = "wbCheck"
        Me.wbCheck.ScriptErrorsSuppressed = True
        Me.wbCheck.Size = New System.Drawing.Size(175, 44)
        Me.wbCheck.TabIndex = 12
        Me.wbCheck.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Powered by NimitzDEV"
        '
        'btnAddRes
        '
        Me.btnAddRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddRes.FlatAppearance.BorderSize = 0
        Me.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRes.ForeColor = System.Drawing.Color.White
        Me.btnAddRes.Location = New System.Drawing.Point(236, 114)
        Me.btnAddRes.Name = "btnAddRes"
        Me.btnAddRes.Size = New System.Drawing.Size(161, 33)
        Me.btnAddRes.TabIndex = 14
        Me.btnAddRes.Text = "追剧管理"
        Me.btnAddRes.UseVisualStyleBackColor = False
        '
        'pbSub
        '
        Me.pbSub.Location = New System.Drawing.Point(12, 224)
        Me.pbSub.Name = "pbSub"
        Me.pbSub.Size = New System.Drawing.Size(385, 23)
        Me.pbSub.TabIndex = 15
        Me.pbSub.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(176, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "欢迎使用字幕组追剧助手~"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.字幕组追剧助手.My.Resources.Resources.main_new
        Me.PictureBox1.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'libtnStart
        '
        Me.libtnStart.BackColor = System.Drawing.Color.Transparent
        Me.libtnStart.BaseColour = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.libtnStart.BorderColour = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.libtnStart.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.libtnStart.HoverColour = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.libtnStart.Location = New System.Drawing.Point(12, 191)
        Me.libtnStart.Maximum = 100
        Me.libtnStart.Name = "libtnStart"
        Me.libtnStart.PressedColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.libtnStart.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.libtnStart.Size = New System.Drawing.Size(385, 50)
        Me.libtnStart.TabIndex = 3
        Me.libtnStart.Text = "点我检查更新"
        Me.libtnStart.Value = 100
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(12, 153)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(385, 20)
        Me.LogInSeperator1.TabIndex = 5
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.libtnStart)
        Me.Controls.Add(Me.pbSub)
        Me.Controls.Add(Me.btnAddRes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.wbCheck)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LogInSeperator1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents libtnStart As 字幕组追剧助手.LogInButtonWithProgress
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents wbCheck As System.Windows.Forms.WebBrowser
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddRes As System.Windows.Forms.Button
    Friend WithEvents pbSub As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
