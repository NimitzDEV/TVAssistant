Public Class frmSettings

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        fuzzy_search = cbFuzzySearch.Checked
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFuzzySearch.Checked = fuzzy_search
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Process.Start("http://nimitzdev.org/?page_id=252")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmInit.ShowDialog(Me)
        frmInit.Dispose()
    End Sub
End Class