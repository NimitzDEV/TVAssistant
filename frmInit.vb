Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class frmInit
    Private fileDld As Net.WebClient
    Private Sub llbOfficial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbOfficial.LinkClicked
        Process.Start("http://nimitzdev.org")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If rbEmpty.Checked Then
            emptyFile("sites.xml")
            emptyFile("tvseries.xml")
            Me.Close()
            Exit Sub
        End If
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("当前网络不可用，无法使用此选项~")
            Exit Sub
        End If
        btnOK.Text = "稍后..."
        btnOK.Enabled = False
        Application.DoEvents()
        downloadFile()
        Me.Close()
    End Sub

    Private Sub downloadFile()
        Try
            fileDld = New Net.WebClient
            fileDld.DownloadFile(New Uri("http://dl.nimitzdev.org/tva/tvseries.xml"), folderPath & "\tvseries.xml")
            fileDld.DownloadFile(New Uri("http://dl.nimitzdev.org/tva/sites.xml"), folderPath & "\sites.xml")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmInit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FileExists(folderPath & "\tvseries.xml") Or FileExists(folderPath & "\sites.xml") Then btnCancel.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class