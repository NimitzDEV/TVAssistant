Module mdSitesOpr
    Dim reader As New Xml.XmlDocument
    Dim ele As Xml.XmlElement
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
    Public Sub tv_addInfo(ByVal name As String, ByVal sitec As String, ByVal linkd As String, ByVal path As String)
        If name = "" Or sitec = "" Or linkd = "" Or path = "" Then
            MsgBox("数据不全")
            Exit Sub
        End If
        reader.Load(Application.StartupPath & "\tvseries.xml")
        Dim mainSection As Xml.XmlElement
        mainSection = reader.CreateElement("media")
        mainSection.AppendChild(reader.CreateElement("name")).AppendChild(reader.CreateCDataSection(name))
        mainSection.AppendChild(reader.CreateElement("sitechecker")).AppendChild(reader.CreateCDataSection(sitec))
        mainSection.AppendChild(reader.CreateElement("linkdata")).AppendChild(reader.CreateCDataSection(linkd))
        mainSection.AppendChild(reader.CreateElement("path")).AppendChild(reader.CreateCDataSection(path))
        reader.SelectSingleNode("NimitzDEV").AppendChild(mainSection)
        reader.Save(Application.StartupPath & "\tvseries.xml")
    End Sub
End Module
