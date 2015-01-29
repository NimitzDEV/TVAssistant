Public Class frmAddSrc
    Private Sub txtData_TextChanged(sender As Object, e As EventArgs) Handles txtData.TextChanged
        If txtData.Text.Trim = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        txtData.Text = Clipboard.GetText
    End Sub

    Private Sub btnGift_Click(sender As Object, e As EventArgs) Handles btnGift.Click
        Process.Start("http://nimitzdev.org/?post_type=gift")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'txtData.Text = txtData.Text.Replace(" ", vbCrLf)
        Dim checkCount As Integer = 0
        If Mid(txtData.Text, 1, 1) = "<" And Mid(txtData.Text, Len(txtData.Text), 1) = ">" Then checkCount += 1
        If txtData.Text.Contains("False") And txtData.Text.Contains("True") Then checkCount += 1
        If txtData.Text.Contains("<index>") And txtData.Text.Contains("</index>") Then checkCount += 1
        If txtData.Text.Contains("<name>") And txtData.Text.Contains("</name>") Then checkCount += 1
        If txtData.Text.Contains("<scanExclude>") And txtData.Text.Contains("</scanExclude>") Then checkCount += 1
        If txtData.Text.Contains("<listlink>") And txtData.Text.Contains("</listlink>") Then checkCount += 1
        If txtData.Text.Contains("<link_prefix>") And txtData.Text.Contains("</link_prefix>") Then checkCount += 1
        If txtData.Text.Contains("<link_suffix>") And txtData.Text.Contains("</link_suffix>") Then checkCount += 1
        If txtData.Text.Contains("<scanRegularExp>") And txtData.Text.Contains("</scanRegularExp>") Then checkCount += 1
        If txtData.Text.Contains("<scanSplitter>") And txtData.Text.Contains("</scanSplitter>") Then checkCount += 1
        If txtData.Text.Contains("<fileNamePos>") And txtData.Text.Contains("</fileNamePos>") Then checkCount += 1
        If txtData.Text.Contains("<requireLogin>") And txtData.Text.Contains("</requireLogin>") Then checkCount += 1
        If txtData.Text.Contains("<loginLink>") And txtData.Text.Contains("</loginLink>") Then checkCount += 1
        If txtData.Text.Contains("<loginFail_TrueRegex>") And txtData.Text.Contains("</loginFail_TrueRegex>") Then checkCount += 1
        If txtData.Text.Contains("<loginFail_FalseRegex>") And txtData.Text.Contains("</loginFail_FalseRegex>") Then checkCount += 1
        If txtData.Text.Contains("<loginOK_TrueRegex>") And txtData.Text.Contains("</loginOK_TrueRegex>") Then checkCount += 1
        If txtData.Text.Contains("<loginOK_FalseRegex>") And txtData.Text.Contains("</loginOK_FalseRegex>") Then checkCount += 1
        If checkCount <> 17 Then
            MsgBox("数据不正确")
            Exit Sub
        End If

        Dim streamReader() As String
        Dim lineInput As String = ""
        Dim require As String = ""
        Dim lineCounter As Integer = 0
        streamReader = System.IO.File.ReadAllLines(folderPath & "\sites.xml")
        For i = 0 To UBound(streamReader)
            require &= streamReader(i) & vbCrLf
            If i = 1 Then
                require &= txtData.Text & vbCrLf
            End If
        Next

        System.IO.File.WriteAllText(folderPath & "\sites.xml", require)
        MsgBox("添加成功")
        txtData.Text = ""
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        txtData.Text = ""
    End Sub

    Private Sub llbAddSrcHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbAddSrcHelp.LinkClicked
        Process.Start("http://nimitzdev.org/?page_id=266")
    End Sub
End Class