﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTVMgr
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
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPathSel = New System.Windows.Forms.Button()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbLinkData = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbResName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSelecter = New System.Windows.Forms.ComboBox()
        Me.fbdPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAll = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb
        '
        Me.gb.Controls.Add(Me.btnSave)
        Me.gb.Controls.Add(Me.btnPathSel)
        Me.gb.Controls.Add(Me.tbPath)
        Me.gb.Controls.Add(Me.Label6)
        Me.gb.Controls.Add(Me.tbLinkData)
        Me.gb.Controls.Add(Me.Label5)
        Me.gb.Controls.Add(Me.tbResName)
        Me.gb.Controls.Add(Me.Label4)
        Me.gb.Controls.Add(Me.Label3)
        Me.gb.Controls.Add(Me.cbSelecter)
        Me.gb.Enabled = False
        Me.gb.Location = New System.Drawing.Point(179, 12)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(304, 153)
        Me.gb.TabIndex = 5
        Me.gb.TabStop = False
        Me.gb.Text = "追剧信息"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(223, 121)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPathSel
        '
        Me.btnPathSel.Location = New System.Drawing.Point(256, 92)
        Me.btnPathSel.Name = "btnPathSel"
        Me.btnPathSel.Size = New System.Drawing.Size(42, 23)
        Me.btnPathSel.TabIndex = 13
        Me.btnPathSel.Text = "..."
        Me.btnPathSel.UseVisualStyleBackColor = True
        '
        'tbPath
        '
        Me.tbPath.Enabled = False
        Me.tbPath.Location = New System.Drawing.Point(74, 94)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(176, 21)
        Me.tbPath.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "储存位置"
        '
        'tbLinkData
        '
        Me.tbLinkData.Location = New System.Drawing.Point(74, 67)
        Me.tbLinkData.Name = "tbLinkData"
        Me.tbLinkData.Size = New System.Drawing.Size(224, 21)
        Me.tbLinkData.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "连接数据"
        '
        'tbResName
        '
        Me.tbResName.Location = New System.Drawing.Point(74, 14)
        Me.tbResName.Name = "tbResName"
        Me.tbResName.Size = New System.Drawing.Size(121, 21)
        Me.tbResName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "资源名称"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "资源来源"
        '
        'cbSelecter
        '
        Me.cbSelecter.FormattingEnabled = True
        Me.cbSelecter.Location = New System.Drawing.Point(74, 41)
        Me.cbSelecter.Name = "cbSelecter"
        Me.cbSelecter.Size = New System.Drawing.Size(121, 20)
        Me.cbSelecter.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbAll)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 182)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "追剧列表"
        '
        'lbAll
        '
        Me.lbAll.FormattingEnabled = True
        Me.lbAll.ItemHeight = 12
        Me.lbAll.Location = New System.Drawing.Point(6, 20)
        Me.lbAll.Name = "lbAll"
        Me.lbAll.Size = New System.Drawing.Size(149, 148)
        Me.lbAll.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(179, 171)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "添加追剧"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmTVMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 201)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTVMgr"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "追剧管理"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents tbLinkData As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbResName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSelecter As System.Windows.Forms.ComboBox
    Friend WithEvents btnPathSel As System.Windows.Forms.Button
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents fbdPath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbAll As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
