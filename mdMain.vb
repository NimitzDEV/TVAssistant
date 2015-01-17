Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdMain
    Public updateList As New Collection
    Public updateCategory As New Collection
    '--------------
    Public media_name As String
    Public media_linkData As String
    Public media_siteChecker As String
    Public media_path As String
    '--------------
    Public site_link_prefix As String
    Public site_link_suffix As String
    Public site_scanRegularExp As String
    Public site_scanSpliter As String
    Public site_fileNamePos As Integer
    Public site_requireLogin As Boolean
    Public site_loginLink As String
    Public site_loginFail_TruePart As String
    Public site_loginFail_FalsePart As String
    Public site_loginOK_TruePart As String
    Public site_name As String
    '----------------
    Public siteCfgReader As New Xml.XmlDocument
    Public Function getSiteInfo(ByVal mainSection As String, ByVal subSection As String) As String
        If FileExists(Application.StartupPath & "\sites.xml") = False Then
            MsgBox("无法加载站点信息配置")
            Return ""
        End If
        siteCfgReader.Load(Application.StartupPath & "\sites.xml")
        Return siteCfgReader.SelectSingleNode("NimitzDEV").SelectSingleNode(mainSection).SelectSingleNode(subSection).InnerText
    End Function

    Public Function cdataPhrase(ByVal input As String) As String
        Return "<![CDATA[" & input & "]]>"
    End Function
End Module
