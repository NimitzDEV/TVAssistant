Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdMain
    Dim siteCfgReader As New Xml.XmlDocument
    Public Function getSiteInfo(ByVal mainSection As String, ByVal subSection As String) As String
        If FileExists(Application.StartupPath & "\sites.xml") = False Then
            MsgBox("无法加载站点信息配置")
            Return ""
        End If
        siteCfgReader.Load(Application.StartupPath & "\sites.xml")
        Return siteCfgReader.SelectSingleNode("NimitzDEV").SelectSingleNode(mainSection).SelectSingleNode(subSection).InnerText
    End Function
End Module
