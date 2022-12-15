Module ModuleRWini
  Public Class GprsRWini
    '中文名称：INI文件操作类
    '英文名称：Blood_INI Class
    '作者：Blood
    '制作时间：2002.2.8
    '版本：1.0
    '版权所有 Blood 2002-2003
    '

    '申明变量
    Private strAppName As String              'INI小节名称
    Private strKeyName As String              'INI项目名
    Private strValueStr As String             'INI的项目值
    Private strFileName As String             'INI文件名

    '申明操作INI文件的API
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    '
    '开始定义函数
    '
    '定义写INI文件的函数
    Public Function WriteINI(ByVal BZString As String) As Long
      '通过API将值写入INI文件
      'BZString 标记字符，自动在末尾添加，是为了能够读写汉字的键值
      Dim S As String
      S = strValueStr & RWini_BZString
      WriteINI = WritePrivateProfileString(strAppName, strKeyName, S, strFileName)
    End Function

    '定义读INI文件的函数
    Public Function ReadINI(ByVal BZString As String) As String
      Dim STRING_SIZE As Int32 = 255 '指定字符串长度
      Dim lngLength As Long                         '定义API函数返回的长度
      'Dim strDefault As String = CStr(STRING_SIZE)        '定义在没有找到指定的项目时返回的默认值
      Dim strDefault As String = ""       '定义在没有找到指定的项目时返回的默认值
      Dim strReturn As String        '定义一个字符串缓冲区
      strReturn = New String(" ", STRING_SIZE)
      Dim j As Integer

      '通过API函数取得INI文件的内容
      lngLength = GetPrivateProfileString(strAppName, strKeyName, strDefault, strReturn, STRING_SIZE, strFileName)

      '通过判断API函数返回的长度来确定返回的值
      If (lngLength = 0) Then
        ReadINI = strValueStr
      Else
        'ReadINI = Mid(strReturn, 1, lngLength - 1) '原句

        '(((((((((((((((((((((((((((((((((((((((((((
        j = InStr(strReturn, RWini_BZString)
        If j > 0 Then
          'For i = 1 To j
          '  ReadINI += Mid(strReturn, i, 1)
          'Next i
          ReadINI = Mid(strReturn, 1, j - 1)
        Else
          ReadINI = Mid(strReturn, 1, lngLength - 1)
        End If
        ')))))))))))))))))))))))))))))))))))))))))))

      End If

    End Function

    '定义函数结束

    '开始定义属性

    '取得INI文件的名称
    Public Property FileName() As String
      Get
        Return strFileName
      End Get
      Set(ByVal Value As String)
        strFileName = Value
      End Set
    End Property

    '取得项目值
    Public Property ValueStr() As String
      Get
        Return strValueStr
      End Get
      Set(ByVal Value As String)
        strValueStr = Value
      End Set
    End Property

    '取得项目名称
    Public Property KeyName() As String
      Get
        Return strKeyName
      End Get
      Set(ByVal Value As String)
        strKeyName = Value
      End Set
    End Property

    '取得小节名称
    Public Property AppName() As String
      Get
        Return strAppName
      End Get
      Set(ByVal Value As String)
        strAppName = Value
      End Set
    End Property
    '
    '结束定义属性
    '
  End Class
End Module
