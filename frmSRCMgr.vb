Public Class frmSRCMgr
    Dim siteInfoXML As New Xml.XmlDocument
    Dim rootElement2 As Xml.XmlElement
    Private Sub lbAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAll.SelectedIndexChanged
        If lbAll.SelectedIndex = -1 Then
            gb.Enabled = False
            Exit Sub
        End If
        gb.Enabled = True
        getSiteInfo(rootElement2.ChildNodes(lbAll.SelectedIndex).Name, rootElement2)
        tbXmlName.Text = site_xmlName
        tbSiteName.Text = site_name
        tbExclude.Text = site_scanExclude
        tbListLink.Text = site_listlink
        tbLoginFailFalse.Text = site_loginFail_FalsePart
        tbLoginFailTrue.Text = site_loginFail_TruePart
        tbLoginOKFalse.Text = site_loginOK_FalsePart
        tbLoginOKTrue.Text = site_loginOK_TruePart
        tbPos.Text = site_fileNamePos
        tbPrefix.Text = site_link_prefix
        tbSuffix.Text = site_link_suffix
        tbRlogin.Text = site_requireLogin
        tbScanExp.Text = site_scanRegularExp
        tbSplitter.Text = site_scanSpliter
        tbLoginLink.Text = site_loginLink
    End Sub

    Private Sub frmSRCMgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sitesLoader()
    End Sub

    Private Sub sitesLoader()
        siteInfoXML.Load(folderPath & "\sites.xml")
        rootElement2 = siteInfoXML.SelectSingleNode("NimitzDEV")
        lbAll.Items.Clear()
        gb.Enabled = False
        For i = 0 To rootElement2.ChildNodes.Count - 1
            lbAll.Items.Add(rootElement2.ChildNodes(i).SelectSingleNode("name").InnerText)
        Next
        If lbAll.Items.Count <> 0 Then
            lbAll.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("确定要删除 " & tbSiteName.Text & " 这个追剧源吗？", vbOKCancel) = MsgBoxResult.Cancel Then Exit Sub
        Dim nod As Xml.XmlNode = rootElement2.ChildNodes(lbAll.SelectedIndex)
        nod.ParentNode.RemoveChild(nod)
        siteInfoXML.Save(folderPath & "\sites.xml")
        sitesLoader()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("确定更新当前信息到 " & tbSiteName.Text & " 这个追剧源中吗？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        site_updateInfo(lbAll.SelectedIndex, tbSiteName.Text, tbExclude.Text, tbListLink.Text, tbLoginFailTrue.Text, tbLoginFailFalse.Text, tbLoginOKFalse.Text, _
                         tbLoginOKTrue.Text, tbPos.Text, tbPrefix.Text, tbSuffix.Text, tbRlogin.Text, tbScanExp.Text, tbSplitter.Text, tbLoginLink.Text)
        sitesLoader()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddSrc.ShowDialog(Me)
        frmAddSrc.Dispose()
        sitesLoader()
    End Sub
End Class