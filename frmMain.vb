Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class frmMain

    '-------------
    Dim tvInfoXml As New Xml.XmlDocument
    Dim rootElement As Xml.XmlElement
    Dim siteInfoXml As New Xml.XmlDocument
    Dim rootElement2 As Xml.XmlElement
    Dim allCount As Integer = 0
    Dim seasonCount As Integer = 0
    Dim nowChecking As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        If FileExists(Application.StartupPath & "\tvseries.xml") = False Or FileExists(Application.StartupPath & "\sites.xml") = False Then
            MsgBox("配置文件缺失")
            libtnStart.Enabled = False
        End If
        tvInfoXml.Load(Application.StartupPath & "\tvseries.xml")
        rootElement = tvInfoXml.SelectSingleNode("NimitzDEV")
        siteInfoXml.Load(Application.StartupPath & "\sites.xml")
        rootElement2 = siteInfoXml.SelectSingleNode("NimitzDEV")
    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles libtnStart.Click
        tvInfoXml.Load(Application.StartupPath & "\tvseries.xml")
        rootElement = tvInfoXml.SelectSingleNode("NimitzDEV")
        siteInfoXml.Load(Application.StartupPath & "\sites.xml")
        rootElement2 = siteInfoXml.SelectSingleNode("NimitzDEV")
        libtnStart.Enabled = False
        updateList.Clear()
        updateCategory.Clear()
        allCount = tvInfoXml.SelectSingleNode("NimitzDEV").SelectNodes("media").Count
        libtnStart.Value = 0
        libtnStart.Maximum = allCount
        checkNextItem()
    End Sub

    Private Sub checkNextItem()
        If nowChecking = allCount Then
            libtnStart.Text = "再来一次"
            libtnStart.Enabled = True
            nowChecking = 0
            Me.Refresh()
            If updateCategory.Count = 0 Then
                MsgBox("当前所有剧集为最新一集了，无需更新")
                Exit Sub
            End If
            frmUpdateDetail.ShowDialog(Me)
            frmUpdateDetail.Dispose()
            Exit Sub
        End If
        prepareData()
        wbCheck.Navigate(site_link_prefix & media_linkData & site_link_suffix)
        libtnStart.Text = "正在进行：" & media_name
        nowChecking += 1
        libtnStart.Value = nowChecking
        Me.Refresh()
    End Sub

    Private Sub prepareData()
        media_linkData = getCurrent("linkdata")
        media_name = getCurrent("name")
        media_path = getCurrent("path")
        media_siteChecker = getCurrent("sitechecker")
        getSiteInfo(media_siteChecker)
    End Sub

    Private Function getCurrent(ByVal require As String) As String
        Return rootElement.SelectNodes("media")(nowChecking).SelectSingleNode(require).InnerText
    End Function

    Public Sub getSiteInfo(ByVal require As String)
        site_fileNamePos = rootElement2.SelectSingleNode(require).SelectSingleNode("fileNamePos").InnerText
        site_link_prefix = rootElement2.SelectSingleNode(require).SelectSingleNode("link_prefix").InnerText
        site_link_suffix = rootElement2.SelectSingleNode(require).SelectSingleNode("link_suffix").InnerText
        site_loginFail_FalsePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginFail_FalsePart").InnerText
        site_loginFail_TruePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginFail_TruePart").InnerText
        site_loginLink = rootElement2.SelectSingleNode(require).SelectSingleNode("loginLink").InnerText
        site_loginOK_TruePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginOK_TruePart").InnerText
        site_requireLogin = rootElement2.SelectSingleNode(require).SelectSingleNode("requireLogin").InnerText
        site_scanRegularExp = rootElement2.SelectSingleNode(require).SelectSingleNode("scanRegularExp").InnerText
        site_scanSpliter = rootElement2.SelectSingleNode(require).SelectSingleNode("scanSpliter").InnerText
        site_name = rootElement2.SelectSingleNode(require).SelectSingleNode("name").InnerText
    End Sub


    Private Sub wbCheck_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbCheck.DocumentCompleted
        Dim isOK As Boolean = False
        If wbCheck.ReadyState <> WebBrowserReadyState.Complete Then Exit Sub
        Dim gs() As String = (From mt As HtmlElement In wbCheck.Document.Links Select System.Text.RegularExpressions.Regex.Match(mt.OuterHtml, site_scanRegularExp).Value).ToArray
        For i = 0 To UBound(gs)
            If gs(i) <> "" Then
                If FileExists(media_path & "\" & Split(gs(i), site_scanSpliter)(site_fileNamePos)) = False Then
                    '-- 名称 -- 文件名 -- 地址 -- 来源 -- SC
                    updateList.Add(media_name & "/=/" & Split(gs(i), site_scanSpliter)(site_fileNamePos) & "/=/" & gs(i) & "/=/" & site_name & "/=/" & media_siteChecker)
                    Debug.Print(gs(i))
                    isOK = True
                End If
            End If
        Next
        If isOK Then
            updateCategory.Add(media_name)
        End If
        checkNextItem()
        If gs.Length = 0 Then Exit Sub
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://github.com/nimitzdev/TVAssistant")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmUpdate.ShowDialog(Me)
    End Sub

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        frmTVMgr.ShowDialog(Me)
        frmTVMgr.Dispose()
    End Sub
End Class
