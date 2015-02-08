<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSrc
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
        Me.llbAddSrcHelp = New System.Windows.Forms.LinkLabel()
        Me.btnGift = New System.Windows.Forms.Button()
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.字幕组追剧助手.My.Resources.Resources.gift_64
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "追剧源如何添加？查看"
        '
        'llbAddSrcHelp
        '
        Me.llbAddSrcHelp.AutoSize = True
        Me.llbAddSrcHelp.Location = New System.Drawing.Point(206, 24)
        Me.llbAddSrcHelp.Name = "llbAddSrcHelp"
        Me.llbAddSrcHelp.Size = New System.Drawing.Size(89, 12)
        Me.llbAddSrcHelp.TabIndex = 2
        Me.llbAddSrcHelp.TabStop = True
        Me.llbAddSrcHelp.Text = "追剧源添加教程"
        '
        'btnGift
        '
        Me.btnGift.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnGift.FlatAppearance.BorderSize = 0
        Me.btnGift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGift.ForeColor = System.Drawing.Color.White
        Me.btnGift.Location = New System.Drawing.Point(77, 49)
        Me.btnGift.Name = "btnGift"
        Me.btnGift.Size = New System.Drawing.Size(218, 26)
        Me.btnGift.TabIndex = 20
        Me.btnGift.Text = "或者进入官网注册直接复制模板"
        Me.btnGift.UseVisualStyleBackColor = False
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(12, 72)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(283, 20)
        Me.LogInSeperator1.TabIndex = 21
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.ForeColor = System.Drawing.Color.White
        Me.btnPaste.Location = New System.Drawing.Point(77, 91)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(218, 23)
        Me.btnPaste.TabIndex = 31
        Me.btnPaste.Text = "粘贴数据到下面的数据框"
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(12, 120)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtData.Size = New System.Drawing.Size(283, 226)
        Me.txtData.TabIndex = 32
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(195, 352)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "确认添加"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClean
        '
        Me.btnClean.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnClean.FlatAppearance.BorderSize = 0
        Me.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClean.ForeColor = System.Drawing.Color.White
        Me.btnClean.Location = New System.Drawing.Point(12, 91)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(59, 23)
        Me.btnClean.TabIndex = 34
        Me.btnClean.Text = "清除"
        Me.btnClean.UseVisualStyleBackColor = False
        '
        'frmAddSrc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 385)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnGift)
        Me.Controls.Add(Me.llbAddSrcHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogInSeperator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSrc"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "添加追剧源"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llbAddSrcHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents btnGift As System.Windows.Forms.Button
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClean As System.Windows.Forms.Button
End Class
