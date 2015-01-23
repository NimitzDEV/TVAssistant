Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class frmAbout
    Private fileDld As Net.WebClient
    Dim trdBGTrd As System.Threading.Thread
    Private Delegate Sub VoidDelegate(ByVal text As String, ByVal color As Color, ByVal detail As String, ByVal dl As String)
    Private Sub btnOfficialSite_Click(sender As Object, e As EventArgs) Handles btnOfficialSite.Click
        Process.Start("http://nimitzdev.org")
    End Sub

    Private Sub frmAbout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        trdBGTrd.Abort()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        udCfgDownloadStarter()
    End Sub

    Public Sub downloadFile(ByVal Url As String, ByVal Path As String)
        Try
            fileDld = New Net.WebClient
            fileDld.DownloadFile(New Uri(Url), Path)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub udCfgDownloadStarter()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        trdBGTrd = New Threading.Thread(New System.Threading.ThreadStart(AddressOf udCfg))
        trdBGTrd.Start()
    End Sub

    Private Sub udCfg()
        Me.Invoke(New VoidDelegate(AddressOf updateLb), {"正在检查更新...", Color.Black, "", ""})
        downloadFile("http://dl.nimitzdev.org/ud/ud_zmzzjzs.ini", folderPath & "ud.ini")
        Try
            If isNew(GetINI("ud", "ver", "", "\ud.ini")) = True Then
                Me.Invoke(New VoidDelegate(AddressOf updateLb), {"发现新版本 - " & GetINI("ud", "ver", "", "\ud.ini"), Color.DodgerBlue, GetINI("ud", "details", "", "\ud.ini"), GetINI("ud", "download", "", "\ud.ini")})
            Else
                Me.Invoke(New VoidDelegate(AddressOf updateLb), {"当前已经是最新版本 - " & Application.ProductVersion, Color.Green, "", ""})
            End If
            DeleteFile(folderPath & "ud.ini")
        Catch ex As Exception
            MsgBox("检查更新的过程中出现问题")
        End Try

    End Sub

    Private Sub updateLb(ByVal text As String, ByVal color As Color, ByVal detail As String, ByVal dl As String)
        lbCheckStatus.Text = text
        lbCheckStatus.ForeColor = color
        If detail <> "" Then
            btnDetails.Enabled = True
            btnDetails.Tag = detail
        Else
            btnDetails.Enabled = False
        End If
        If dl <> "" Then
            btnDonload.Enabled = True
            btnDonload.Tag = dl
        Else
            btnDonload.Enabled = False
        End If
    End Sub

    Private Function isNew(ByVal versionString As String) As Boolean
        For i = 0 To 3
            If Int(Split(versionString, ".")(i)) > Int(Split(Application.ProductVersion, ".")(i)) Then
                Return True
            ElseIf Int(Split(versionString, ".")(i)) < Int(Split(Application.ProductVersion, ".")(i)) Then
                Return False
            End If
        Next
        Return False
    End Function

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        Process.Start(btnDetails.Tag)
    End Sub

    Private Sub btnDonload_Click(sender As Object, e As EventArgs) Handles btnDonload.Click
        Process.Start(btnDonload.Tag)
    End Sub
End Class