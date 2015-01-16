Public Class frmUpdateDetail

    Private Sub frmUpdateDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To updateCategory.Count
            cbUpdateSelect.Items.Add(updateCategory(i))
        Next
        cbUpdateSelect.SelectedIndex = 0
    End Sub


    Private Sub btnThunder_Click(sender As Object, e As EventArgs) Handles btnThunder.Click
        Dim thunderEng As New ThunderAgentLib.Agent
        For i = 1 To lvPreview.Items.Count
            If lvPreview.Items(i - 1).Checked Then thunderEng.AddTask(lvPreview.Items(i - 1).Tag, "", media_path, "", "", 1, 0, -1)
        Next
        thunderEng.CommitTasks()
    End Sub

    Private Function getReadableName(ByVal fileName As String)
        Dim tmp2 As String
        Dim regx As String
        tmp2 = fileName
        regx = System.Text.RegularExpressions.Regex.Match(fileName, "EP[0-9]+|E[0-9]+|第[0-9]+集|C[0-9]+").Value
        If regx <> "" Then
            If regx.Contains("第") = False And regx.Contains("集") = False Then
                If regx.Contains("EP") Then regx = regx.Replace("EP", "第")
                If regx.Contains("E") Then regx = regx.Replace("E", "第")
                If regx.Contains("C") Then regx = regx.Replace("C", "第")
                regx &= "集"
            End If
            Return regx
        End If
        Return ""
    End Function

    Private Sub cbUpdateSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUpdateSelect.SelectedIndexChanged
        lvPreview.Items.Clear()
        For i = 1 To updateList.Count
            If Split(updateList(i), "/=/")(0) = cbUpdateSelect.Text Then
                Dim lv As New ListViewItem()
                lv.SubItems(0).Text = "下载"
                lv.SubItems.Add(getReadableName(Split(updateList(i), "/=/")(1)))
                lv.SubItems.Add(Split(updateList(i), "/=/")(1))
                lv.SubItems.Add(Split(updateList(i), "/=/")(3))
                lv.Tag = Split(updateList(i), "/=/")(2)
                lv.Checked = True
                lvPreview.Items.Add(lv)
            End If
        Next
    End Sub
End Class