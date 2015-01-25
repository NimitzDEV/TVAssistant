Imports System.Web.HttpUtility
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
    Public site_loginOK_FalsePart As String
    Public site_name As String
    Public site_listlink As String
    Public site_xmlName As String
    Public site_scanExclude As String
    '----------------
    Public siteCfgReader As New Xml.XmlDocument
    Public Function getSiteInfo(ByVal mainSection As String, ByVal subSection As String) As String
        If FileExists(folderPath & "\sites.xml") = False Then
            MsgBox("无法加载站点信息配置")
            Return ""
        End If
        siteCfgReader.Load(folderPath & "\sites.xml")
        Return siteCfgReader.SelectSingleNode("NimitzDEV").SelectSingleNode(mainSection).SelectSingleNode(subSection).InnerText
    End Function

    Public Sub getSiteInfo(ByVal require As String, ByVal rootElement2 As Xml.XmlElement)
        site_fileNamePos = rootElement2.SelectSingleNode(require).SelectSingleNode("fileNamePos").InnerText
        site_link_prefix = UrlDecode(rootElement2.SelectSingleNode(require).SelectSingleNode("link_prefix").InnerText)
        site_link_suffix = UrlDecode(rootElement2.SelectSingleNode(require).SelectSingleNode("link_suffix").InnerText)
        site_loginFail_FalsePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginFail_FalseRegex").InnerText
        site_loginFail_TruePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginFail_TrueRegex").InnerText
        site_loginLink = rootElement2.SelectSingleNode(require).SelectSingleNode("loginLink").InnerText
        site_loginOK_TruePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginOK_TrueRegex").InnerText
        site_loginOK_FalsePart = rootElement2.SelectSingleNode(require).SelectSingleNode("loginOK_FalseRegex").InnerText
        site_requireLogin = rootElement2.SelectSingleNode(require).SelectSingleNode("requireLogin").InnerText
        site_scanRegularExp = rootElement2.SelectSingleNode(require).SelectSingleNode("scanRegularExp").InnerText
        site_scanSpliter = rootElement2.SelectSingleNode(require).SelectSingleNode("scanSplitter").InnerText
        site_name = rootElement2.SelectSingleNode(require).SelectSingleNode("name").InnerText
        site_listlink = rootElement2.SelectSingleNode(require).SelectSingleNode("listlink").InnerText
        site_scanExclude = rootElement2.SelectSingleNode(require).SelectSingleNode("scanExclude").InnerText
        site_xmlName = require
    End Sub

    Public Function getRightText(ByVal wb As WebBrowser) As String
        Dim reader As New System.IO.StreamReader(wb.DocumentStream, System.Text.Encoding.GetEncoding(wb.Document.Encoding))
        Return reader.ReadToEnd
    End Function

    Public Function getReadableName(ByVal fileName As String)
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
            Return (regx)
        End If
        Return ""
    End Function

    Public Sub emptyFile(ByVal fileName As String)
        System.IO.File.WriteAllText(folderPath & "\" & fileName, "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>" _
                                    & vbCrLf & "<NimitzDEV>" & vbCrLf & "</NimitzDEV>")
    End Sub
End Module
