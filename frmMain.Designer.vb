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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cbUpdateSelect = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThunder = New System.Windows.Forms.Button()
        Me.wbCheck = New System.Windows.Forms.WebBrowser()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        Me.libtnStart = New 字幕组追剧助手.LogInButtonWithProgress()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.字幕组追剧助手.My.Resources.Resources.main
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "目前为测试版，我还没写好一体化的管理工具。。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "so,使用方法先查看我写好的使用方法" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "→_→"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(340, 67)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "使用说明"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(281, 67)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "软件更新"
        '
        'cbUpdateSelect
        '
        Me.cbUpdateSelect.FormattingEnabled = True
        Me.cbUpdateSelect.Location = New System.Drawing.Point(272, 172)
        Me.cbUpdateSelect.Name = "cbUpdateSelect"
        Me.cbUpdateSelect.Size = New System.Drawing.Size(121, 20)
        Me.cbUpdateSelect.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "请选择剧集"
        '
        'btnThunder
        '
        Me.btnThunder.Location = New System.Drawing.Point(247, 376)
        Me.btnThunder.Name = "btnThunder"
        Me.btnThunder.Size = New System.Drawing.Size(146, 23)
        Me.btnThunder.TabIndex = 11
        Me.btnThunder.Text = "使用迅雷下载以上更新"
        Me.btnThunder.UseVisualStyleBackColor = True
        '
        'wbCheck
        '
        Me.wbCheck.Location = New System.Drawing.Point(20, 151)
        Me.wbCheck.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCheck.Name = "wbCheck"
        Me.wbCheck.ScriptErrorsSuppressed = True
        Me.wbCheck.Size = New System.Drawing.Size(175, 139)
        Me.wbCheck.TabIndex = 12
        Me.wbCheck.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Powered by NimitzDEV"
        '
        'lvPreview
        '
        Me.lvPreview.CheckBoxes = True
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvPreview.FullRowSelect = True
        Me.lvPreview.Location = New System.Drawing.Point(12, 198)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(381, 172)
        Me.lvPreview.TabIndex = 14
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "执行动作"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "剧集"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "文件名"
        Me.ColumnHeader3.Width = 250
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(90, 51)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(303, 20)
        Me.LogInSeperator1.TabIndex = 5
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'libtnStart
        '
        Me.libtnStart.BackColor = System.Drawing.Color.Transparent
        Me.libtnStart.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.libtnStart.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.libtnStart.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.libtnStart.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.libtnStart.Location = New System.Drawing.Point(12, 90)
        Me.libtnStart.Maximum = 100
        Me.libtnStart.Name = "libtnStart"
        Me.libtnStart.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.libtnStart.ProgressColour = System.Drawing.Color.ForestGreen
        Me.libtnStart.Size = New System.Drawing.Size(381, 50)
        Me.libtnStart.TabIndex = 3
        Me.libtnStart.Text = "准备就绪"
        Me.libtnStart.Value = 100
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 397)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.wbCheck)
        Me.Controls.Add(Me.btnThunder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbUpdateSelect)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LogInSeperator1)
        Me.Controls.Add(Me.libtnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents libtnStart As 字幕组追剧助手.LogInButtonWithProgress
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents cbUpdateSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnThunder As System.Windows.Forms.Button
    Friend WithEvents wbCheck As System.Windows.Forms.WebBrowser
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvPreview As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader

End Class
