
Public Class frmUpdateDetail

    Private Sub frmUpdateDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To updateCategory.Count
            cbUpdateSelect.Items.Add(updateCategory(i))
        Next
        cbUpdateSelect.SelectedIndex = 0
    End Sub


    Private Sub btnThunder_Click(sender As Object, e As EventArgs) Handles btnThunder.Click
        Try
            Dim thunderEng As New ThunderAgentLib.Agent
            For i = 1 To lvPreview.Items.Count
                If lvPreview.Items(i - 1).Checked Then thunderEng.AddTask(lvPreview.Items(i - 1).Tag, "", media_path, "", "", 1, 0, -1)
            Next
            thunderEng.CommitTasks()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("加载迅雷下载组件错误，请确保迅雷已经正确安装")
        End Try
    End Sub

   

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