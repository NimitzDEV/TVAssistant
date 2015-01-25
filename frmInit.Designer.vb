<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbEmpty = New System.Windows.Forms.RadioButton()
        Me.llbOfficial = New System.Windows.Forms.LinkLabel()
        Me.rbPreset = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        Me.LogInSeperator2 = New 字幕组追剧助手.LogInSeperator()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "欢迎使用字幕组追剧助手"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "首次使用，您想如何初始化您的追剧信息？"
        '
        'rbEmpty
        '
        Me.rbEmpty.AutoSize = True
        Me.rbEmpty.Location = New System.Drawing.Point(38, 129)
        Me.rbEmpty.Name = "rbEmpty"
        Me.rbEmpty.Size = New System.Drawing.Size(185, 16)
        Me.rbEmpty.TabIndex = 3
        Me.rbEmpty.Text = "使用空白的配置，稍后我再从 "
        Me.rbEmpty.UseVisualStyleBackColor = True
        '
        'llbOfficial
        '
        Me.llbOfficial.AutoSize = True
        Me.llbOfficial.Location = New System.Drawing.Point(216, 131)
        Me.llbOfficial.Name = "llbOfficial"
        Me.llbOfficial.Size = New System.Drawing.Size(53, 12)
        Me.llbOfficial.TabIndex = 4
        Me.llbOfficial.TabStop = True
        Me.llbOfficial.Text = "官网获取"
        '
        'rbPreset
        '
        Me.rbPreset.AutoSize = True
        Me.rbPreset.Checked = True
        Me.rbPreset.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rbPreset.Location = New System.Drawing.Point(38, 95)
        Me.rbPreset.Name = "rbPreset"
        Me.rbPreset.Size = New System.Drawing.Size(244, 16)
        Me.rbPreset.TabIndex = 5
        Me.rbPreset.TabStop = True
        Me.rbPreset.Text = "自动下载预配置好的追剧信息（推荐）"
        Me.rbPreset.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Tomato
        Me.Label3.Location = New System.Drawing.Point(55, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "稍后您可以从""设置/帮助""按钮中获取使用说明或者重新运行本步骤"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(350, 200)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 33)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "完成"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(16, 36)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(434, 20)
        Me.LogInSeperator1.TabIndex = 1
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'LogInSeperator2
        '
        Me.LogInSeperator2.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator2.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator2.Location = New System.Drawing.Point(16, 185)
        Me.LogInSeperator2.Name = "LogInSeperator2"
        Me.LogInSeperator2.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator2.Size = New System.Drawing.Size(434, 20)
        Me.LogInSeperator2.TabIndex = 19
        Me.LogInSeperator2.Text = "LogInSeperator2"
        Me.LogInSeperator2.Thickness = 1.0!
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(244, 200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 33)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'frmInit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(462, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbPreset)
        Me.Controls.Add(Me.llbOfficial)
        Me.Controls.Add(Me.rbEmpty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogInSeperator1)
        Me.Controls.Add(Me.LogInSeperator2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "首次使用"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbEmpty As System.Windows.Forms.RadioButton
    Friend WithEvents llbOfficial As System.Windows.Forms.LinkLabel
    Friend WithEvents rbPreset As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents LogInSeperator2 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
