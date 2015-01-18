Public Class frmTVMgr
    Dim tvInfoXml As New Xml.XmlDocument
    Dim rootElement As Xml.XmlElement
    Dim allCount As Integer
    Dim siteInfoXML As New Xml.XmlDocument
    Dim rootElement2 As Xml.XmlElement
    Private Sub frmTVMgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub loader()
        gb.Enabled = False
        lbAll.Items.Clear()
        cbSelecter.Items.Clear()
        tvInfoXml.Load(Application.StartupPath & "\tvseries.xml")
        rootElement = tvInfoXml.SelectSingleNode("NimitzDEV")
        siteInfoXML.Load(Application.StartupPath & "\sites.xml")
        rootElement2 = siteInfoXML.SelectSingleNode("NimitzDEV")
        listLoader()
        sitesLoader()
    End Sub

    Private Sub confirmSites(ByVal keyStr As String)
        For i = 0 To cbSelecter.Items.Count - 1
            cbSelecter.SelectedIndex = i
            If cbSelecter.Items(cbSelecter.SelectedIndex) = keyStr Then

                Exit Sub
            End If
        Next
    End Sub

    Private Sub sitesLoader()
        allCount = rootElement2.ChildNodes.Count
        If allCount = 0 Then Exit Sub
        For i = 0 To allCount - 1
            cbSelecter.Items.Add(rootElement2.ChildNodes(i).SelectSingleNode("name").InnerText)
        Next
    End Sub

    Private Sub listLoader()
        allCount = tvInfoXml.SelectSingleNode("NimitzDEV").SelectNodes("media").Count
        If allCount = 0 Then Exit Sub
        For i = 0 To allCount - 1
            lbAll.Items.Add(tvxmlDataReader(i, "name"))
        Next
    End Sub

    Private Function tvxmlDataReader(ByVal p1 As Integer, ByVal p2 As String) As String
        Return rootElement.SelectNodes("media")(p1).SelectSingleNode(p2).InnerText
    End Function

    Private Function sitexmlDataReader(ByVal p1 As String, ByVal p2 As String) As String
        Return rootElement2.SelectSingleNode(p1).SelectSingleNode(p2).InnerText
    End Function

    Private Sub lbAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAll.SelectedIndexChanged
        If lbAll.SelectedIndex = -1 Then
            gb.Enabled = False
            Exit Sub
        End If
        confirmSites(sitexmlDataReader(tvxmlDataReader(lbAll.SelectedIndex, "sitechecker"), "name"))
        tbResName.Text = tvxmlDataReader(lbAll.SelectedIndex, "name")
        tbLinkData.Text = tvxmlDataReader(lbAll.SelectedIndex, "linkdata")
        tbPath.Text = tvxmlDataReader(lbAll.SelectedIndex, "path")
        gb.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("确定更新当前信息到 " & lbAll.Items(lbAll.SelectedIndex) & " 吗？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        'Debug.Print(rootElement2.ChildNodes(cbSelecter.SelectedIndex).Name)
        tv_updateInfo(lbAll.SelectedIndex, tbResName.Text, rootElement2.ChildNodes(cbSelecter.SelectedIndex).Name, tbLinkData.Text, tbPath.Text)
        loader()
    End Sub

    Private Sub btnPathSel_Click(sender As Object, e As EventArgs) Handles btnPathSel.Click
        fbdPath.Description = "请选择 " & tbResName.Text & " 的储存位置" & vbCrLf & "并且每次更新该电视剧都存这个地方，这样才能准确的判断更新"
        fbdPath.ShowDialog()
        If fbdPath.SelectedPath = "" Then Exit Sub
        tbPath.Text = fbdPath.SelectedPath & "\"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddTV.ShowDialog(Me)
        frmAddTV.Dispose()
        loader()
    End Sub
End Class