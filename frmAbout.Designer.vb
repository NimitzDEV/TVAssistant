<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnOfficialSite = New System.Windows.Forms.Button()
        Me.lbCheckStatus = New System.Windows.Forms.Label()
        Me.btnDonload = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.LogInSeperator1 = New 字幕组追剧助手.LogInSeperator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(66, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NimitzDEV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nimitz Software Developments"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.字幕组追剧助手.My.Resources.Resources.n_48
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnOfficialSite
        '
        Me.btnOfficialSite.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnOfficialSite.FlatAppearance.BorderSize = 0
        Me.btnOfficialSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficialSite.ForeColor = System.Drawing.Color.White
        Me.btnOfficialSite.Image = Global.字幕组追剧助手.My.Resources.Resources.off
        Me.btnOfficialSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOfficialSite.Location = New System.Drawing.Point(247, 12)
        Me.btnOfficialSite.Name = "btnOfficialSite"
        Me.btnOfficialSite.Size = New System.Drawing.Size(106, 48)
        Me.btnOfficialSite.TabIndex = 31
        Me.btnOfficialSite.Text = "访问官网"
        Me.btnOfficialSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOfficialSite.UseVisualStyleBackColor = False
        '
        'lbCheckStatus
        '
        Me.lbCheckStatus.AutoSize = True
        Me.lbCheckStatus.Location = New System.Drawing.Point(10, 89)
        Me.lbCheckStatus.Name = "lbCheckStatus"
        Me.lbCheckStatus.Size = New System.Drawing.Size(11, 12)
        Me.lbCheckStatus.TabIndex = 33
        Me.lbCheckStatus.Text = "-"
        '
        'btnDonload
        '
        Me.btnDonload.Location = New System.Drawing.Point(278, 84)
        Me.btnDonload.Name = "btnDonload"
        Me.btnDonload.Size = New System.Drawing.Size(75, 23)
        Me.btnDonload.TabIndex = 34
        Me.btnDonload.Text = "下载新版"
        Me.btnDonload.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(197, 84)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnDetails.TabIndex = 35
        Me.btnDetails.Text = "更新详情"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = 字幕组追剧助手.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(12, 66)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(341, 20)
        Me.LogInSeperator1.TabIndex = 32
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 116)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnDonload)
        Me.Controls.Add(Me.lbCheckStatus)
        Me.Controls.Add(Me.LogInSeperator1)
        Me.Controls.Add(Me.btnOfficialSite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "关于与更新"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOfficialSite As System.Windows.Forms.Button
    Friend WithEvents LogInSeperator1 As 字幕组追剧助手.LogInSeperator
    Friend WithEvents lbCheckStatus As System.Windows.Forms.Label
    Friend WithEvents btnDonload As System.Windows.Forms.Button
    Friend WithEvents btnDetails As System.Windows.Forms.Button
End Class
