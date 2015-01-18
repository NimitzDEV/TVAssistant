Imports System.Text.RegularExpressions.Regex
Public Class frmLogin
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If IIf(site_loginFail_FalsePart = "", False, IsMatch(getRightText(WebBrowser1), site_loginFail_FalsePart)) = False And IIf(site_loginFail_TruePart = "", True, IsMatch(getRightText(WebBrowser1), site_loginFail_TruePart)) = True Then
            Exit Sub
        End If
        If IIf(site_loginOK_FalsePart = "", False, IsMatch(getRightText(WebBrowser1), site_loginOK_FalsePart)) = False And IIf(site_loginOK_TruePart = "", True, IsMatch(getRightText(WebBrowser1), site_loginOK_TruePart)) = True Then
            MsgBox("登录成功")
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 3 / 4
        WebBrowser1.Navigate(site_loginLink)
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        If e.CurrentProgress > 0 And e.MaximumProgress > 0 Then
            Me.Text = "追剧源 " & site_name & " 需要登录才能继续 - [" & e.CurrentProgress / e.MaximumProgress * 100 & "%]"
        Else
            Me.Text = "追剧源 " & site_name & " 需要登录才能继续 - [加载完成]"
        End If
    End Sub
End Class