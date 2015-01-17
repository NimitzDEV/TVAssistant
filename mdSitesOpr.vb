Module mdSitesOpr
    Dim reader As New Xml.XmlDocument
    Dim ele As Xml.XmlElement
    Dim cdata As Xml.XmlCDataSection
    Public Sub tv_updateInfo(ByVal NodeId As Integer, ByVal name As String, ByVal sitec As String, ByVal linkd As String, ByVal path As String)
        If name = "" Or sitec = "" Or linkd = "" Or path = "" Then
            MsgBox("数据不全")
            Exit Sub
        End If
        reader.Load(Application.StartupPath & "\tvseries.xml")
        ele = reader.SelectSingleNode("NimitzDEV").ChildNodes(NodeId)
        ele.SelectSingleNode("name").InnerText = ""
        ele.SelectSingleNode("name").AppendChild(reader.CreateCDataSection(name))
        ele.SelectSingleNode("sitechecker").InnerText = ""
        ele.SelectSingleNode("sitechecker").AppendChild(reader.CreateCDataSection(sitec))
        ele.SelectSingleNode("linkdata").InnerText = ""
        ele.SelectSingleNode("linkdata").AppendChild(reader.CreateCDataSection(linkd))
        ele.SelectSingleNode("path").InnerText = ""
        ele.SelectSingleNode("path").AppendChild(reader.CreateCDataSection(path))
        reader.Save(Application.StartupPath & "\tvseries.xml")
    End Sub
End Module
