Public Class frmUpdate
    Dim docString As String
    Dim versionString As String
    Dim linkString As String
    Dim updateString As String
    Dim spliter() As String = {"≠"}
    Public timeout As Integer = 20
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wbStart.Navigate("http://nimitzdev.byethost12.com/update/update_zmzzjzs.txt?" & Date.Now)
        Me.Height = 94
    End Sub
    Private Sub wbStart_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbStart.DocumentCompleted
        splitPageString()
    End Sub
    Private Sub splitPageString()
        docString = New System.IO.StreamReader(wbStart.DocumentStream, System.Text.Encoding.Default).ReadToEnd
        versionString = Split(docString, "≡")(1).Trim
        updateString = Split(docString, "≡")(2).Trim
        linkString = Split(docString, "≡")(3).Trim
        detectUpdate()
    End Sub
    Private Sub detectUpdate()
        If isNew() = False Then
            ProgressBar1.Visible = False
            lbStatus.Text = "当前已经是最新版本 （" & Application.ProductVersion & "）"
            lbStatus.ForeColor = Color.DodgerBlue
        Else
            If listLoaded() = True Then
                btnDownload.Enabled = True
            Else
                btnDownload.Text = "暂无下载"
            End If

            Me.Height = 250
            txtDetails.Visible = True
            txtDetails.Text = updateString
            ProgressBar1.Visible = False
            lbStatus.Text = "检测到新的版本可以下载！" & vbCrLf & "- 新的版本：" & versionString & vbCrLf & "- 当前版本：" & Application.ProductVersion
            lbStatus.ForeColor = Color.Green
        End If
        tmrTimeOut.Enabled = False
    End Sub

    Private Function isNew() As Boolean
        For i = 0 To 3
            If Int(Split(versionString, ".")(i)) > Int(Split(Application.ProductVersion, ".")(i)) Then
                Return True
            ElseIf Int(Split(versionString, ".")(i)) < Int(Split(Application.ProductVersion, ".")(i)) Then
                Return False
            End If
        Next
        Return False
    End Function

    Private Function listLoaded() As Boolean
        Dim downloadList() As String
        If linkString = "" Then Return False
        Try
            downloadList = linkString.Split(spliter, StringSplitOptions.RemoveEmptyEntries)
            For i = 0 To downloadList.Count - 1
                cmsDownloadList.Items.Add(Split(downloadList(i), "∫")(0), _
                               Nothing, AddressOf downloadClickHandler).Tag = Split(downloadList(i), "∫")(1)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub downloadClickHandler(sender As Object, e As EventArgs)
        Process.Start(sender.tag)
    End Sub

    Private Sub tmrTimeOut_Tick(sender As Object, e As EventArgs) Handles tmrTimeOut.Tick
        timeout -= 1
        If timeout < 0 Then
            wbStart.Stop()
            tmrTimeOut.Enabled = False
            MsgBox("与服务器的连接超时" & vbCrLf & "建议您重试即可")
            Me.Close()
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        cmsDownloadList.Show(btnDownload, 0, btnDownload.Height)
    End Sub

End Class