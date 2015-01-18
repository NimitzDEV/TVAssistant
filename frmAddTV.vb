Public Class frmAddTV
    Dim tvInfoXml As New Xml.XmlDocument
    Dim rootElement As Xml.XmlElement
    Dim allCount As Integer
    Dim siteInfoXML As New Xml.XmlDocument
    Dim rootElement2 As Xml.XmlElement
    Private Sub frmAddTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 3 / 4
        pnl.Top = 0
        pnl.Left = 0
        wbOperate.Top = 0
        wbOperate.Left = pnl.Width
        cbSelecter.Items.Clear()
        gb.Enabled = False
        For i = 0 To frmTVMgr.cbSelecter.Items.Count - 1
            cbSelecter.Items.Add(frmTVMgr.cbSelecter.Items(i))
        Next
        siteInfoXML.Load(Application.StartupPath & "\sites.xml")
        rootElement2 = siteInfoXML.SelectSingleNode("NimitzDEV")
        loader()
    End Sub

    Private Sub loader()
        tvInfoXml.Load(Application.StartupPath & "\tvseries.xml")
        rootElement = tvInfoXml.SelectSingleNode("NimitzDEV")
    End Sub

    Private Sub frmAddTV_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pnl.Height = Me.ClientRectangle.Height
        wbOperate.Height = Me.ClientRectangle.Height
        wbOperate.Width = Me.ClientRectangle.Width - pnl.Width
    End Sub

    Private Sub cbSelecter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSelecter.SelectedIndexChanged
        Debug.Print(cbSelecter.SelectedIndex)
        getSiteInfo(rootElement2.ChildNodes(cbSelecter.SelectedIndex).Name, rootElement2)
        wbOperate.Navigate(site_listlink)
    End Sub

    Private Sub btnNavBack_Click(sender As Object, e As EventArgs) Handles btnNavBack.Click
        If wbOperate.CanGoBack Then wbOperate.GoBack()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If wbOperate.CanGoForward Then wbOperate.GoForward()
    End Sub

    Private Sub wbOperate_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbOperate.DocumentCompleted
        If wbOperate.ReadyState <> WebBrowserReadyState.Complete Then Exit Sub
        summarizeData(wbOperate.Url.ToString, wbOperate.DocumentTitle)
    End Sub

    Private Sub summarizeData(ByVal linkdata As String, ByVal title As String)
        tbPath.Text = ""
        gb.Enabled = False
        lbStatus.Text = "未检测到可用追剧信息"
        lbStatus.ForeColor = Color.OrangeRed
        If linkdata = site_listlink Then
            Exit Sub
        End If
        If Mid(linkdata, 1, Len(site_link_prefix)) = site_link_prefix And Mid(linkdata, Len(linkdata) - Len(site_link_suffix) + 1, Len(site_link_suffix)) = site_link_suffix Then
            tbResName.Text = title
            tbLinkData.Text = Mid(linkdata, Len(site_link_prefix) + 1, Len(linkdata) - Len(site_link_suffix) - Len(site_link_prefix))
            If isDuplicate(tbLinkData.Text) Then
                'gbo(False)
                lbStatus.Text = "当前剧集已经在列表中"
                lbStatus.ForeColor = Color.Blue
                Exit Sub
            End If
        End If
        gb.Enabled = True
        lbStatus.Text = "检测到可用追剧信息"
        lbStatus.ForeColor = Color.Green
    End Sub


    Private Sub wbOperate_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbOperate.ProgressChanged
        If e.CurrentProgress > 0 And e.MaximumProgress > 0 Then
            lbb.Text = "检测中"
            pbB.Maximum = e.MaximumProgress
            pbB.Value = e.CurrentProgress
        ElseIf wbOperate.ReadyState = WebBrowserReadyState.Complete Then
            lbb.Text = "完成"
            pbB.Value = pbB.Maximum
        End If
    End Sub

    Private Function isDuplicate(ByVal linkdata As String) As Boolean
        For i = 0 To rootElement.SelectNodes("media").Count - 1
            If rootElement.SelectNodes("media")(i).SelectSingleNode("linkdata").InnerText = linkdata And _
                rootElement.SelectNodes("media")(i).SelectSingleNode("sitechecker").InnerText = site_xmlName Then Return True
        Next
        Return False
    End Function

    Private Sub btnPathSel_Click(sender As Object, e As EventArgs) Handles btnPathSel.Click
        fbdPath.Description = "请选择 " & tbResName.Text & " 的储存位置" & vbCrLf & "并且每次更新该电视剧都存这个地方，这样才能准确的判断更新"
        fbdPath.ShowDialog()
        If fbdPath.SelectedPath = "" Then Exit Sub
        tbPath.Text = fbdPath.SelectedPath & "\"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If MsgBox("确认添加追剧吗？" & vbCrLf & "点击 确认 将添加，点击 取消 可以继续修改信息", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        tv_addInfo(tbResName.Text, site_xmlName, tbLinkData.Text, tbPath.Text)
        loader()
        summarizeData(wbOperate.Url.ToString, tbResName.Text)
    End Sub
End Class