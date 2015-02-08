<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTV
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
        Me.pnl = New System.Windows.Forms.Panel()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.lbb = New System.Windows.Forms.Label()
        Me.pbB = New System.Windows.Forms.ProgressBar()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnPathSel = New System.Windows.Forms.Button()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbLinkData = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbResName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNavBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSelecter = New System.Windows.Forms.ComboBox()
        Me.wbOperate = New System.Windows.Forms.WebBrowser()
        Me.fbdPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        Me.pnl.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.gb.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.Controls.Add(Me.gb2)
        Me.pnl.Controls.Add(Me.gb1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(260, 574)
        Me.pnl.TabIndex = 0
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.lbb)
        Me.gb2.Controls.Add(Me.pbB)
        Me.gb2.Controls.Add(Me.gb)
        Me.gb2.Controls.Add(Me.lbStatus)
        Me.gb2.Location = New System.Drawing.Point(12, 151)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(232, 413)
        Me.gb2.TabIndex = 3
        Me.gb2.TabStop = False
        Me.gb2.Text = "状态信息"
        '
        'lbb
        '
        Me.lbb.AutoSize = True
        Me.lbb.Location = New System.Drawing.Point(14, 42)
        Me.lbb.Name = "lbb"
        Me.lbb.Size = New System.Drawing.Size(29, 12)
        Me.lbb.TabIndex = 8
        Me.lbb.Text = "完成"
        '
        'pbB
        '
        Me.pbB.Location = New System.Drawing.Point(71, 37)
        Me.pbB.Name = "pbB"
        Me.pbB.Size = New System.Drawing.Size(155, 23)
        Me.pbB.TabIndex = 7
        '
        'gb
        '
        Me.gb.Controls.Add(Me.btnConfirm)
        Me.gb.Controls.Add(Me.LogInSeperator1)
        Me.gb.Controls.Add(Me.btnPathSel)
        Me.gb.Controls.Add(Me.tbPath)
        Me.gb.Controls.Add(Me.Label6)
        Me.gb.Controls.Add(Me.tbLinkData)
        Me.gb.Controls.Add(Me.Label5)
        Me.gb.Controls.Add(Me.tbResName)
        Me.gb.Controls.Add(Me.Label4)
        Me.gb.Enabled = False
        Me.gb.Location = New System.Drawing.Point(6, 66)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(220, 335)
        Me.gb.TabIndex = 6
        Me.gb.TabStop = False
        Me.gb.Text = "追剧信息"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(3, 287)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(211, 38)
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "添加到追剧列表"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnPathSel
        '
        Me.btnPathSel.Location = New System.Drawing.Point(129, 232)
        Me.btnPathSel.Name = "btnPathSel"
        Me.btnPathSel.Size = New System.Drawing.Size(85, 23)
        Me.btnPathSel.TabIndex = 13
        Me.btnPathSel.Text = "选择路径"
        Me.btnPathSel.UseVisualStyleBackColor = True
        '
        'tbPath
        '
        Me.tbPath.Enabled = False
        Me.tbPath.Location = New System.Drawing.Point(10, 169)
        Me.tbPath.Multiline = True
        Me.tbPath.Name = "tbPath"
        Me.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPath.Size = New System.Drawing.Size(204, 57)
        Me.tbPath.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "请选择该剧的下载位置"
        '
        'tbLinkData
        '
        Me.tbLinkData.Location = New System.Drawing.Point(65, 116)
        Me.tbLinkData.Name = "tbLinkData"
        Me.tbLinkData.Size = New System.Drawing.Size(149, 21)
        Me.tbLinkData.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "连接数据"
        '
        'tbResName
        '
        Me.tbResName.Location = New System.Drawing.Point(6, 32)
        Me.tbResName.Multiline = True
        Me.tbResName.Name = "tbResName"
        Me.tbResName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbResName.Size = New System.Drawing.Size(208, 78)
        Me.tbResName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "资源名称"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbStatus.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbStatus.Location = New System.Drawing.Point(6, 17)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(157, 14)
        Me.lbStatus.TabIndex = 0
        Me.lbStatus.Text = "未检测到可用追剧信息"
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.Button1)
        Me.gb1.Controls.Add(Me.btnNavBack)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.cbSelecter)
        Me.gb1.Location = New System.Drawing.Point(12, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(232, 133)
        Me.gb1.TabIndex = 2
        Me.gb1.TabStop = False
        Me.gb1.Text = "请先选择资源来源"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "然后在右边的页面中点击进入剧集" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "程序会自动判断是否可以加入追剧"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "前进 >"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNavBack
        '
        Me.btnNavBack.Location = New System.Drawing.Point(6, 58)
        Me.btnNavBack.Name = "btnNavBack"
        Me.btnNavBack.Size = New System.Drawing.Size(75, 23)
        Me.btnNavBack.TabIndex = 2
        Me.btnNavBack.Text = "< 后退"
        Me.btnNavBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "请选择剧集来源"
        '
        'cbSelecter
        '
        Me.cbSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelecter.FormattingEnabled = True
        Me.cbSelecter.Location = New System.Drawing.Point(6, 32)
        Me.cbSelecter.Name = "cbSelecter"
        Me.cbSelecter.Size = New System.Drawing.Size(220, 20)
        Me.cbSelecter.TabIndex = 1
        '
        'wbOperate
        '
        Me.wbOperate.Location = New System.Drawing.Point(266, 0)
        Me.wbOperate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOperate.Name = "wbOperate"
        Me.wbOperate.ScriptErrorsSuppressed = True
        Me.wbOperate.Size = New System.Drawing.Size(250, 250)
        Me.wbOperate.TabIndex = 1
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(3, 261)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(211, 20)
        Me.LogInSeperator1.TabIndex = 14
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'frmAddTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 604)
        Me.Controls.Add(Me.wbOperate)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmAddTV"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "追剧添加向导"
        Me.pnl.ResumeLayout(False)
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbSelecter As System.Windows.Forms.ComboBox
    Friend WithEvents wbOperate As System.Windows.Forms.WebBrowser
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNavBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents btnPathSel As System.Windows.Forms.Button
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbLinkData As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbResName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbb As System.Windows.Forms.Label
    Friend WithEvents pbB As System.Windows.Forms.ProgressBar
    Friend WithEvents fbdPath As System.Windows.Forms.FolderBrowserDialog
End Class
