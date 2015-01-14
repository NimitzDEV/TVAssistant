<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.wbStart = New System.Windows.Forms.WebBrowser()
        Me.cmsDownloadList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tmrTimeOut = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.Enabled = False
        Me.btnDownload.Location = New System.Drawing.Point(287, 188)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnDownload.TabIndex = 24
        Me.btnDownload.Text = "立即下载"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(12, 55)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(348, 130)
        Me.txtDetails.TabIndex = 23
        Me.txtDetails.Visible = False
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(12, 8)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(107, 12)
        Me.lbStatus.TabIndex = 21
        Me.lbStatus.Text = "正在查找更新....."
        '
        'wbStart
        '
        Me.wbStart.Location = New System.Drawing.Point(24, 147)
        Me.wbStart.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbStart.Name = "wbStart"
        Me.wbStart.ScriptErrorsSuppressed = True
        Me.wbStart.Size = New System.Drawing.Size(160, 94)
        Me.wbStart.TabIndex = 22
        Me.wbStart.Visible = False
        '
        'cmsDownloadList
        '
        Me.cmsDownloadList.Name = "cmsDownloadList"
        Me.cmsDownloadList.Size = New System.Drawing.Size(61, 4)
        '
        'tmrTimeOut
        '
        Me.tmrTimeOut.Enabled = True
        Me.tmrTimeOut.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 26)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(348, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 25
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 218)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.wbStart)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "软件更新"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents wbStart As System.Windows.Forms.WebBrowser
    Friend WithEvents cmsDownloadList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tmrTimeOut As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
