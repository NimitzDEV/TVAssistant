Module mdSitesOpr
    Dim reader As New Xml.XmlDocument
    Dim ele As Xml.XmlElement
    Public Sub tv_updateInfo(ByVal NodeId As Integer, ByVal name As String, ByVal sitec As String, ByVal linkd As String, ByVal path As String)
        If name = "" Or sitec = "" Or linkd = "" Or path = "" Then
            MsgBox("数据不全")
            Exit Sub
        End If
        reader.Load(folderPath & "\tvseries.xml")
        ele = reader.SelectSingleNode("NimitzDEV").ChildNodes(NodeId)
        ele.SelectSingleNode("name").InnerText = ""
        ele.SelectSingleNode("name").AppendChild(reader.CreateCDataSection(name))
        ele.SelectSingleNode("sitechecker").InnerText = ""
        ele.SelectSingleNode("sitechecker").AppendChild(reader.CreateCDataSection(sitec))
        ele.SelectSingleNode("linkdata").InnerText = ""
        ele.SelectSingleNode("linkdata").AppendChild(reader.CreateCDataSection(linkd))
        ele.SelectSingleNode("path").InnerText = ""
        ele.SelectSingleNode("path").AppendChild(reader.CreateCDataSection(path))
        reader.Save(folderPath & "\tvseries.xml")
    End Sub
    Public Sub tv_addInfo(ByVal name As String, ByVal sitec As String, ByVal linkd As String, ByVal path As String)
        If name = "" Or sitec = "" Or linkd = "" Or path = "" Then
            MsgBox("数据不全")
            Exit Sub
        End If
        reader.Load(folderPath & "\tvseries.xml")
        Dim mainSection As Xml.XmlElement
        mainSection = reader.CreateElement("media")
        mainSection.AppendChild(reader.CreateElement("name")).AppendChild(reader.CreateCDataSection(name))
        mainSection.AppendChild(reader.CreateElement("sitechecker")).AppendChild(reader.CreateCDataSection(sitec))
        mainSection.AppendChild(reader.CreateElement("linkdata")).AppendChild(reader.CreateCDataSection(linkd))
        mainSection.AppendChild(reader.CreateElement("path")).AppendChild(reader.CreateCDataSection(path))
        reader.SelectSingleNode("NimitzDEV").AppendChild(mainSection)
        reader.Save(folderPath & "\tvseries.xml")
    End Sub
    Public Sub site_updateInfo(ByVal id As Integer, ByVal name As String, ByVal exclude As String, _
                               ByVal listlink As String, ByVal failtrue As String, ByVal failfalse As String _
                               , ByVal okfalse As String, ByVal oktrue As String _
                                , ByVal pos As String, ByVal prefix As String, ByVal suffix As String _
                               , ByVal rlogin As String, ByVal scanexp As String, ByVal splitter As String, ByVal loginlink As String)
        reader.Load(folderPath & "\sites.xml")
        ele = reader.SelectSingleNode("NimitzDEV").ChildNodes(id)
        ele.SelectSingleNode("name").InnerText = ""
        ele.SelectSingleNode("name").AppendChild(reader.CreateCDataSection(name))
        ele.SelectSingleNode("scanExclude").InnerText = ""
        ele.SelectSingleNode("scanExclude").AppendChild(reader.CreateCDataSection(exclude))
        ele.SelectSingleNode("listlink").InnerText = ""
        ele.SelectSingleNode("listlink").AppendChild(reader.CreateCDataSection(listlink))
        ele.SelectSingleNode("link_prefix").InnerText = ""
        ele.SelectSingleNode("link_prefix").AppendChild(reader.CreateCDataSection(prefix))
        ele.SelectSingleNode("link_suffix").InnerText = ""
        ele.SelectSingleNode("link_suffix").AppendChild(reader.CreateCDataSection(suffix))
        ele.SelectSingleNode("scanRegularExp").InnerText = ""
        ele.SelectSingleNode("scanRegularExp").AppendChild(reader.CreateCDataSection(scanexp))
        ele.SelectSingleNode("scanSplitter").InnerText = ""
        ele.SelectSingleNode("scanSplitter").AppendChild(reader.CreateCDataSection(splitter))
        ele.SelectSingleNode("fileNamePos").InnerText = ""
        ele.SelectSingleNode("fileNamePos").AppendChild(reader.CreateCDataSection(pos))
        ele.SelectSingleNode("requireLogin").InnerText = ""
        ele.SelectSingleNode("requireLogin").AppendChild(reader.CreateCDataSection(rlogin))
        ele.SelectSingleNode("loginLink").InnerText = ""
        ele.SelectSingleNode("loginLink").AppendChild(reader.CreateCDataSection(loginlink))
        ele.SelectSingleNode("loginFail_TrueRegex").InnerText = ""
        ele.SelectSingleNode("loginFail_TrueRegex").AppendChild(reader.CreateCDataSection(failtrue))
        ele.SelectSingleNode("loginFail_FalseRegex").InnerText = ""
        ele.SelectSingleNode("loginFail_FalseRegex").AppendChild(reader.CreateCDataSection(failfalse))
        ele.SelectSingleNode("loginOK_TrueRegex").InnerText = ""
        ele.SelectSingleNode("loginOK_TrueRegex").AppendChild(reader.CreateCDataSection(oktrue))
        ele.SelectSingleNode("loginOK_FalseRegex").InnerText = ""
        ele.SelectSingleNode("loginOK_FalseRegex").AppendChild(reader.CreateCDataSection(okfalse))
        reader.Save(folderPath & "\sites.xml")
    End Sub
End Module
