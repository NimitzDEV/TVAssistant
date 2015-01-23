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
End Class