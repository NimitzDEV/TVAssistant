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
    Public site_listlink As String
    Public site_xmlName As String
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

    Public Sub getSiteInfo(ByVal require As String, ByVal rootElement2 As Xml.XmlElement)
        site_fileNamePos = rootElement2.SelectSingleNode(require).SelectSingleNode("fileNamePos").InnerText
        site_link_prefix = rootElement2.SelectSingleNode(require).SelectSingleNode("link_prefix").InnerText
        site_link_suffix = rootElement2.SelectSingleNode(require).SelectSingleNode("link_suffix").InnerText
        site_loginFail_FalsePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginFail_FalsePart").InnerText
        site_loginFail_TruePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginFail_TruePart").InnerText
        site_loginLink = rootElement2.SelectSingleNode(require).SelectSingleNode("loginLink").InnerText
        site_loginOK_TruePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginOK_TruePart").InnerText
        site_requireLogin = rootElement2.SelectSingleNode(require).SelectSingleNode("requireLogin").InnerText
        site_scanRegularExp = rootElement2.SelectSingleNode(require).SelectSingleNode("scanRegularExp").InnerText
        site_scanSpliter = rootElement2.SelectSingleNode(require).SelectSingleNode("scanSpliter").InnerText
        site_name = rootElement2.SelectSingleNode(require).SelectSingleNode("name").InnerText
        site_listlink = rootElement2.SelectSingleNode(require).SelectSingleNode("listlink").InnerText
        site_xmlName = require
    End Sub
End Module
