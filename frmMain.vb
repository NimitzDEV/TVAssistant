Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.Text.RegularExpressions
Imports System.Web.HttpUtility
Public Class frmMain
    Dim finishScan As Boolean = False
    Dim xe As Xml.XmlElement
    '-------------
    Dim tvInfoXml As New Xml.XmlDocument
    Dim rootElement As Xml.XmlElement
    Dim siteInfoXml As New Xml.XmlDocument
    Dim rootElement2 As Xml.XmlElement
    Dim allCount As Integer = 0
    Dim seasonCount As Integer = 0
    Dim nowChecking As Integer = 0

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadSettings()
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        If FileExists(folderPath & "\tvseries.xml") = False And FileExists(folderPath & "\sites.xml") = False Then
            frmInit.ShowDialog(Me)
            frmInit.Dispose()
        End If
        If FileExists(folderPath & "\tvseries.xml") = False Then emptyFile("tvseries.xml")
        If FileExists(folderPath & "\sites.xml") = False Then emptyFile("sites.xml")

    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles libtnStart.Click
        finishScan = False
        pnlControl.Enabled = True
        tvInfoXml.Load(folderPath & "\tvseries.xml")
        rootElement = tvInfoXml.SelectSingleNode("NimitzDEV")
        siteInfoXml.Load(folderPath & "\sites.xml")
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
            finishScan = True
            libtnStart.Text = "再来一次"
            lbWbStatus.Text = "点击按钮再来一次"
            libtnStart.Enabled = True
            pnlControl.Enabled = False
            nowChecking = 0
            Me.Refresh()
            If updateCategory.Count = 0 Then
                MsgBox("当前所有剧集为最新一集了，无需更新")
                libtnStart.Maximum = 1
                libtnStart.Value = 1
                Exit Sub
            End If
            frmUpdateDetail.ShowDialog(Me)
            frmUpdateDetail.Dispose()
            Exit Sub
        End If
        prepareData()
        wbCheck.Navigate(site_link_prefix & media_linkData & site_link_suffix)
        libtnStart.Text = "正在进行：" & shortString(media_name)
        nowChecking += 1
        libtnStart.Value = nowChecking
        Me.Refresh()
    End Sub

    Private Function shortString(ByVal str As String) As String
        If Len(str) > 15 Then
            Return Mid(str, 1, 15) & " ..."
        End If
        Return str
    End Function

    Private Sub prepareData()
        media_linkData = getCurrent("linkdata")
        media_name = getCurrent("name")
        media_path = getCurrent("path")
        media_siteChecker = getCurrent("sitechecker")
        xe = CType(rootElement.SelectNodes("media")(nowChecking), Xml.XmlElement)
        media_version = Int(xe.GetAttribute("version"))
        getSiteInfo(media_siteChecker, rootElement2)
    End Sub

    Private Function getCurrent(ByVal require As String) As String
        Return rootElement.SelectNodes("media")(nowChecking).SelectSingleNode(require).InnerText
    End Function

    Private Sub wbCheck_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbCheck.DocumentCompleted
        Dim isOK As Boolean = False
        Application.DoEvents()

        If wbCheck.ReadyState <> WebBrowserReadyState.Complete Or finishScan Then Exit Sub
        If site_requireLogin Then
            If Regex.IsMatch(getRightText(wbCheck), site_loginFail_FalsePart) = False And Regex.IsMatch(getRightText(wbCheck), site_loginFail_TruePart) = True Then
                Dim msgResult As MsgBoxResult
                msgResult = MsgBox("以下的追剧源需要进行会员登录" & vbCrLf & " - " & site_name & vbCrLf & "点击 确定 进行登录" & vbCrLf & "点击 取消 放弃登录并跳过检测该剧", vbOKCancel)
                If msgResult = vbOK Then
                    frmLogin.ShowDialog(Me)
                    frmLogin.Dispose()
                    nowChecking -= 1
                    checkNextItem()
                ElseIf msgResult = vbCancel Then
                    checkNextItem()
                End If
                Exit Sub
            End If
        End If


        Dim gs() As String = (From mt As HtmlElement In wbCheck.Document.Links Select System.Text.RegularExpressions.Regex.Match(mt.OuterHtml, site_scanRegularExp).Value).ToArray
        For i = 0 To UBound(gs)
            If gs(i) <> "" Then
                Dim filename As String
                filename = UrlDecode(Split(gs(i), site_scanSpliter)(site_fileNamePos))
                If fuzzy_search Then
                    If fuzzySearch(filename) Then Continue For
                End If
                If FileExists(media_path & "\" & filename) = False Then
                    '-- 名称 -- 文件名 -- 地址 
                    updateList.Add(media_name & "/=/" & (filename) & "/=/" & UrlDecode(gs(i)))
                    '& "/=/" & site_name & "/=/" & media_siteChecker)
                    Debug.Print(gs(i))
                    isOK = True
                End If
            End If
        Next
        If isOK Then
            updateCategory.Add(media_name)
            siteIndex.Add(site_name & "/=/" & site_index & "/=/" & media_path)
        End If
        checkNextItem()
        If gs.Length = 0 Then Exit Sub
    End Sub

    Private Function fuzzySearch(ByVal name As String) As Boolean
        For Each ff As String In My.Computer.FileSystem.GetFiles(media_path & "\", FileIO.SearchOption.SearchTopLevelOnly, "*.*")
            If getReadableName(My.Computer.FileSystem.GetName(ff)) = getReadableName(name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        frmTVMgr.ShowDialog(Me)
        frmTVMgr.Dispose()
    End Sub


    Private Sub wbCheck_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbCheck.ProgressChanged
        If e.CurrentProgress > 0 And e.MaximumProgress > 0 Then
            Try
                pbSub.Maximum = e.MaximumProgress / 100
                pbSub.Value = e.CurrentProgress / 100
            Catch ex As Exception
                pbSub.Value = 0
            End Try
        ElseIf wbCheck.ReadyState = WebBrowserReadyState.Complete Then
            pbSub.Value = pbSub.Maximum
        End If
        If libtnStart.Enabled = True Then Exit Sub
        lbWbStatus.Text = pbSub.Value & "% - " & shortString(wbCheck.StatusText)
    End Sub


    Private Sub btnSrc_Click(sender As Object, e As EventArgs) Handles btnSrc.Click
        frmSRCMgr.ShowDialog(Me)
        frmSRCMgr.Dispose()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.ShowDialog(Me)
        frmSettings.Dispose()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog(Me)
        frmAbout.Dispose()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        wbCheck.Refresh(WebBrowserRefreshOption.Completely)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        wbCheck.Stop()
        checkNextItem()
    End Sub
End Class
