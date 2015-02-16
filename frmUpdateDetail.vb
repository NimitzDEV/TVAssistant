
Public Class frmUpdateDetail
    Dim formatList As New List(Of String)
    Dim clipboardStr As String
    Private Sub frmUpdateDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To updateCategory.Count
            cbUpdateSelect.Items.Add(updateCategory(i))
        Next
        cbUpdateSelect.SelectedIndex = 0
    End Sub


    Private Sub btnThunder_Click(sender As Object, e As EventArgs) Handles btnThunder.Click
        cmsDownload.Show(btnThunder, 0, 0)
    End Sub

    Private Sub cbUpdateSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUpdateSelect.SelectedIndexChanged
        lvPreview.Items.Clear()
        showList(cbUpdateSelect.Text, "", True)
        llbSiteIndex.Text = Split(siteIndex(cbUpdateSelect.SelectedIndex + 1), "/=/")(0)
        llbSiteIndex.Tag = Split(siteIndex(cbUpdateSelect.SelectedIndex + 1), "/=/")(1)
    End Sub

    Private Sub showList(ByVal showName As String, ByVal formatRegx As String, ByVal fresh As Boolean)
        formatList.Clear()
        lvPreview.Items.Clear()
        For i = 1 To updateList.Count
            If Split(updateList(i), "/=/")(0) = showName Then
                If Not fresh Then
                    If Not System.Text.RegularExpressions.Regex.IsMatch(Split(updateList(i), "/=/")(1), formatRegx) Then
                        Continue For
                    End If
                End If
                Dim lv As New ListViewItem()
                lv.SubItems(0).Text = "下载"
                lv.SubItems.Add(getReadableName(Split(updateList(i), "/=/")(1)))
                lv.SubItems.Add(Split(updateList(i), "/=/")(1))
                'lv.SubItems.Add(Split(updateList(i), "/=/")(3))
                lv.Tag = Split(updateList(i), "/=/")(2)
                lv.Checked = True
                lvPreview.Items.Add(lv)
                formatList.Add(System.IO.Path.GetExtension(Split(updateList(i), "/=/")(1)))
            End If
        Next
        If Not fresh Then Exit Sub
        cbFormat.Items.Clear()
        cbFormat.Items.Add("全部")
        formatList = formatList.Distinct.ToList
        cbFormat.Items.AddRange(formatList.ToArray)
        cbFormat.SelectedIndex = 0
    End Sub

    Private Sub cbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormat.SelectedIndexChanged
        If cbFormat.SelectedIndex = 0 Then
            showList(cbUpdateSelect.Text, "", False)
            Exit Sub
        End If

        showList(cbUpdateSelect.Text, cbFormat.Text & "$", False)
    End Sub

    Private Sub llbSiteIndex_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbSiteIndex.LinkClicked
        If llbSiteIndex.Tag = "" Then Exit Sub
        Process.Start(llbSiteIndex.Tag)
    End Sub

    Private Sub tsmiThunder_Click(sender As Object, e As EventArgs) Handles tsmiThunder.Click
        Try
            Dim thunderEng As New ThunderAgentLib.Agent
            For i = 1 To lvPreview.Items.Count
                If lvPreview.Items(i - 1).Checked Then thunderEng.AddTask(lvPreview.Items(i - 1).Tag, "", Split(siteIndex(cbUpdateSelect.SelectedIndex + 1), "/=/")(2), "", "", 1, 0, -1)
            Next
            thunderEng.CommitTasks()
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.HResult & vbCrLf & "加载迅雷下载组件错误，请确保迅雷已经正确安装")
        End Try
    End Sub

    Private Sub tsmiQQDownload_Click(sender As Object, e As EventArgs) Handles tsmiQQDownload.Click
        Try
            Dim qqdlEng As New QQIEHELPERLib.QQRightClick
            For i = 1 To lvPreview.Items.Count
                If lvPreview.Items(i - 1).Checked Then qqdlEng.SendUrl(lvPreview.Items(i - 1).Tag, "", "", "")
            Next
            qqdlEng.CommitTasks2(1)
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.HResult & vbCrLf & "加载QQ旋风下载组件错误，请确保QQ旋风已经正确安装")
        End Try
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        clipboardStr = ""
        For i = 1 To lvPreview.Items.Count
            If lvPreview.Items(i - 1).Checked Then clipboardStr &= lvPreview.Items(i - 1).Tag & vbCrLf
        Next
        Clipboard.SetText(clipboardStr)
    End Sub
End Class