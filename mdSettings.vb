Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdSettings

    '====
    Public fuzzy_search As Boolean = False
    '====
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    Public Sub ReadSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        If FileExists(folderPath & "config.ini") = False Then Exit Sub
        fuzzy_search = GetINI("search", "fuzzy", "False")
    End Sub
    Public Sub SaveSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        WriteINI("search", "fuzzy", fuzzy_search)
    End Sub
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), folderPath & iniName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, folderPath & iniName)
    End Function
End Module
