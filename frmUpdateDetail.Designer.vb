<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDetail
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
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbUpdateSelect = New System.Windows.Forms.ComboBox()
        Me.btnThunder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFormat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llbSiteIndex = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvPreview
        '
        Me.lvPreview.CheckBoxes = True
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvPreview.FullRowSelect = True
        Me.lvPreview.Location = New System.Drawing.Point(4, 31)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(475, 205)
        Me.lvPreview.TabIndex = 18
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
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "文件名"
        Me.ColumnHeader3.Width = 320
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "请选择剧集"
        '
        'cbUpdateSelect
        '
        Me.cbUpdateSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUpdateSelect.FormattingEnabled = True
        Me.cbUpdateSelect.Location = New System.Drawing.Point(73, 5)
        Me.cbUpdateSelect.Name = "cbUpdateSelect"
        Me.cbUpdateSelect.Size = New System.Drawing.Size(285, 20)
        Me.cbUpdateSelect.TabIndex = 15
        '
        'btnThunder
        '
        Me.btnThunder.Image = Global.字幕组追剧助手.My.Resources.Resources.thunder32
        Me.btnThunder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThunder.Location = New System.Drawing.Point(310, 242)
        Me.btnThunder.Name = "btnThunder"
        Me.btnThunder.Size = New System.Drawing.Size(169, 38)
        Me.btnThunder.TabIndex = 17
        Me.btnThunder.Text = "使用迅雷下载以上更新"
        Me.btnThunder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThunder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "格式筛选"
        '
        'cbFormat
        '
        Me.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormat.FormattingEnabled = True
        Me.cbFormat.Location = New System.Drawing.Point(423, 5)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(56, 20)
        Me.cbFormat.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "资源来自"
        '
        'llbSiteIndex
        '
        Me.llbSiteIndex.AutoSize = True
        Me.llbSiteIndex.Location = New System.Drawing.Point(71, 242)
        Me.llbSiteIndex.Name = "llbSiteIndex"
        Me.llbSiteIndex.Size = New System.Drawing.Size(65, 12)
        Me.llbSiteIndex.TabIndex = 22
        Me.llbSiteIndex.TabStop = True
        Me.llbSiteIndex.Text = "LinkLabel1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 12)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "*记得下载的路径和添加追剧时选择的路径要相同哦~"
        '
        'frmUpdateDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 285)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.llbSiteIndex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFormat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.btnThunder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbUpdateSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateDetail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "更新详情"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvPreview As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnThunder As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbUpdateSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents llbSiteIndex As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
