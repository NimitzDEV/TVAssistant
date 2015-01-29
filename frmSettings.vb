Public Class frmSettings


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

    Private Sub cbFuzzySearch_CheckedChanged(sender As Object, e As EventArgs) Handles cbFuzzySearch.CheckedChanged
        fuzzy_search = cbFuzzySearch.Checked
    End Sub
End Class