<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSRCMgr
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAll = New System.Windows.Forms.ListBox()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbXmlName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSiteName = New System.Windows.Forms.TextBox()
        Me.tbListLink = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPrefix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSuffix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbScanExp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSplitter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbPos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbExclude = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbRlogin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbLoginLink = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbLoginOKTrue = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbLoginOKFalse = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbLoginFailTrue = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbLoginFailFalse = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gb)
        Me.GroupBox1.Controls.Add(Me.lbAll)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 425)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "追剧源管理"
        '
        'lbAll
        '
        Me.lbAll.FormattingEnabled = True
        Me.lbAll.ItemHeight = 12
        Me.lbAll.Location = New System.Drawing.Point(6, 20)
        Me.lbAll.Name = "lbAll"
        Me.lbAll.Size = New System.Drawing.Size(194, 400)
        Me.lbAll.TabIndex = 0
        '
        'gb
        '
        Me.gb.Controls.Add(Me.btnDelete)
        Me.gb.Controls.Add(Me.btnSave)
        Me.gb.Controls.Add(Me.tbLoginFailFalse)
        Me.gb.Controls.Add(Me.Label15)
        Me.gb.Controls.Add(Me.tbLoginFailTrue)
        Me.gb.Controls.Add(Me.Label14)
        Me.gb.Controls.Add(Me.tbLoginOKFalse)
        Me.gb.Controls.Add(Me.Label13)
        Me.gb.Controls.Add(Me.tbLoginOKTrue)
        Me.gb.Controls.Add(Me.Label12)
        Me.gb.Controls.Add(Me.tbLoginLink)
        Me.gb.Controls.Add(Me.Label11)
        Me.gb.Controls.Add(Me.tbRlogin)
        Me.gb.Controls.Add(Me.Label10)
        Me.gb.Controls.Add(Me.tbExclude)
        Me.gb.Controls.Add(Me.Label9)
        Me.gb.Controls.Add(Me.tbPos)
        Me.gb.Controls.Add(Me.Label8)
        Me.gb.Controls.Add(Me.tbSplitter)
        Me.gb.Controls.Add(Me.Label7)
        Me.gb.Controls.Add(Me.tbScanExp)
        Me.gb.Controls.Add(Me.Label6)
        Me.gb.Controls.Add(Me.tbSuffix)
        Me.gb.Controls.Add(Me.Label5)
        Me.gb.Controls.Add(Me.tbPrefix)
        Me.gb.Controls.Add(Me.Label4)
        Me.gb.Controls.Add(Me.tbListLink)
        Me.gb.Controls.Add(Me.Label3)
        Me.gb.Controls.Add(Me.tbSiteName)
        Me.gb.Controls.Add(Me.Label2)
        Me.gb.Controls.Add(Me.tbXmlName)
        Me.gb.Controls.Add(Me.Label1)
        Me.gb.Location = New System.Drawing.Point(206, 12)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(425, 411)
        Me.gb.TabIndex = 1
        Me.gb.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "xml名称"
        '
        'tbXmlName
        '
        Me.tbXmlName.Enabled = False
        Me.tbXmlName.Location = New System.Drawing.Point(69, 14)
        Me.tbXmlName.Name = "tbXmlName"
        Me.tbXmlName.Size = New System.Drawing.Size(100, 21)
        Me.tbXmlName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "站点名称"
        '
        'tbSiteName
        '
        Me.tbSiteName.Location = New System.Drawing.Point(69, 41)
        Me.tbSiteName.Name = "tbSiteName"
        Me.tbSiteName.Size = New System.Drawing.Size(100, 21)
        Me.tbSiteName.TabIndex = 3
        '
        'tbListLink
        '
        Me.tbListLink.Location = New System.Drawing.Point(69, 70)
        Me.tbListLink.Name = "tbListLink"
        Me.tbListLink.Size = New System.Drawing.Size(350, 21)
        Me.tbListLink.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "列表链接"
        '
        'tbPrefix
        '
        Me.tbPrefix.Location = New System.Drawing.Point(69, 97)
        Me.tbPrefix.Name = "tbPrefix"
        Me.tbPrefix.Size = New System.Drawing.Size(350, 21)
        Me.tbPrefix.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "资源前缀"
        '
        'tbSuffix
        '
        Me.tbSuffix.Location = New System.Drawing.Point(69, 124)
        Me.tbSuffix.Name = "tbSuffix"
        Me.tbSuffix.Size = New System.Drawing.Size(350, 21)
        Me.tbSuffix.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "资源后缀"
        '
        'tbScanExp
        '
        Me.tbScanExp.Location = New System.Drawing.Point(125, 153)
        Me.tbScanExp.Name = "tbScanExp"
        Me.tbScanExp.Size = New System.Drawing.Size(294, 21)
        Me.tbScanExp.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "提取资源正则表达式"
        '
        'tbSplitter
        '
        Me.tbSplitter.Location = New System.Drawing.Point(113, 181)
        Me.tbSplitter.Name = "tbSplitter"
        Me.tbSplitter.Size = New System.Drawing.Size(56, 21)
        Me.tbSplitter.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "文件名提取分隔符"
        '
        'tbPos
        '
        Me.tbPos.Location = New System.Drawing.Point(256, 180)
        Me.tbPos.Name = "tbPos"
        Me.tbPos.Size = New System.Drawing.Size(54, 21)
        Me.tbPos.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "文件名位置"
        '
        'tbExclude
        '
        Me.tbExclude.Location = New System.Drawing.Point(149, 208)
        Me.tbExclude.Name = "tbExclude"
        Me.tbExclude.Size = New System.Drawing.Size(270, 21)
        Me.tbExclude.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "连接数据排除正则表达式"
        '
        'tbRlogin
        '
        Me.tbRlogin.Location = New System.Drawing.Point(268, 14)
        Me.tbRlogin.Name = "tbRlogin"
        Me.tbRlogin.Size = New System.Drawing.Size(100, 21)
        Me.tbRlogin.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(185, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "是否需求登陆"
        '
        'tbLoginLink
        '
        Me.tbLoginLink.Location = New System.Drawing.Point(89, 235)
        Me.tbLoginLink.Name = "tbLoginLink"
        Me.tbLoginLink.Size = New System.Drawing.Size(330, 21)
        Me.tbLoginLink.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 12)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "登陆页面链接"
        '
        'tbLoginOKTrue
        '
        Me.tbLoginOKTrue.Location = New System.Drawing.Point(227, 262)
        Me.tbLoginOKTrue.Name = "tbLoginOKTrue"
        Me.tbLoginOKTrue.Size = New System.Drawing.Size(192, 21)
        Me.tbLoginOKTrue.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(215, 12)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "登陆成功-应该返回 True 的正则表达式"
        '
        'tbLoginOKFalse
        '
        Me.tbLoginOKFalse.Location = New System.Drawing.Point(227, 291)
        Me.tbLoginOKFalse.Name = "tbLoginOKFalse"
        Me.tbLoginOKFalse.Size = New System.Drawing.Size(192, 21)
        Me.tbLoginOKFalse.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(221, 12)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "登陆成功-应该返回 False 的正则表达式"
        '
        'tbLoginFailTrue
        '
        Me.tbLoginFailTrue.Location = New System.Drawing.Point(227, 320)
        Me.tbLoginFailTrue.Name = "tbLoginFailTrue"
        Me.tbLoginFailTrue.Size = New System.Drawing.Size(192, 21)
        Me.tbLoginFailTrue.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 326)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(215, 12)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "登陆失败-应该返回 True 的正则表达式"
        '
        'tbLoginFailFalse
        '
        Me.tbLoginFailFalse.Location = New System.Drawing.Point(227, 349)
        Me.tbLoginFailFalse.Name = "tbLoginFailFalse"
        Me.tbLoginFailFalse.Size = New System.Drawing.Size(192, 21)
        Me.tbLoginFailFalse.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 355)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(221, 12)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "登陆失败-应该返回 False 的正则表达式"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(106, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(115, 23)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "删除这个追剧源"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(227, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 23)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "更新信息"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmSRCMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSRCMgr"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "追剧源管理"
        Me.GroupBox1.ResumeLayout(False)
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents lbAll As System.Windows.Forms.ListBox
    Friend WithEvents tbSuffix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbListLink As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbSiteName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbXmlName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbLoginFailFalse As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbLoginFailTrue As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbLoginOKFalse As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbLoginOKTrue As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbLoginLink As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbRlogin As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbExclude As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbPos As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbSplitter As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbScanExp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
