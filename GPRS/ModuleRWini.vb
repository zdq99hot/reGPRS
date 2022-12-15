Module ModuleRWini
  Public Class GprsRWini
    '�������ƣ�INI�ļ�������
    'Ӣ�����ƣ�Blood_INI Class
    '���ߣ�Blood
    '����ʱ�䣺2002.2.8
    '�汾��1.0
    '��Ȩ���� Blood 2002-2003
    '

    '��������
    Private strAppName As String              'INIС������
    Private strKeyName As String              'INI��Ŀ��
    Private strValueStr As String             'INI����Ŀֵ
    Private strFileName As String             'INI�ļ���

    '��������INI�ļ���API
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    '
    '��ʼ���庯��
    '
    '����дINI�ļ��ĺ���
    Public Function WriteINI(ByVal BZString As String) As Long
      'ͨ��API��ֵд��INI�ļ�
      'BZString ����ַ����Զ���ĩβ��ӣ���Ϊ���ܹ���д���ֵļ�ֵ
      Dim S As String
      S = strValueStr & RWini_BZString
      WriteINI = WritePrivateProfileString(strAppName, strKeyName, S, strFileName)
    End Function

    '�����INI�ļ��ĺ���
    Public Function ReadINI(ByVal BZString As String) As String
      Dim STRING_SIZE As Int32 = 255 'ָ���ַ�������
      Dim lngLength As Long                         '����API�������صĳ���
      'Dim strDefault As String = CStr(STRING_SIZE)        '������û���ҵ�ָ������Ŀʱ���ص�Ĭ��ֵ
      Dim strDefault As String = ""       '������û���ҵ�ָ������Ŀʱ���ص�Ĭ��ֵ
      Dim strReturn As String        '����һ���ַ���������
      strReturn = New String(" ", STRING_SIZE)
      Dim j As Integer

      'ͨ��API����ȡ��INI�ļ�������
      lngLength = GetPrivateProfileString(strAppName, strKeyName, strDefault, strReturn, STRING_SIZE, strFileName)

      'ͨ���ж�API�������صĳ�����ȷ�����ص�ֵ
      If (lngLength = 0) Then
        ReadINI = strValueStr
      Else
        'ReadINI = Mid(strReturn, 1, lngLength - 1) 'ԭ��

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

    '���庯������

    '��ʼ��������

    'ȡ��INI�ļ�������
    Public Property FileName() As String
      Get
        Return strFileName
      End Get
      Set(ByVal Value As String)
        strFileName = Value
      End Set
    End Property

    'ȡ����Ŀֵ
    Public Property ValueStr() As String
      Get
        Return strValueStr
      End Get
      Set(ByVal Value As String)
        strValueStr = Value
      End Set
    End Property

    'ȡ����Ŀ����
    Public Property KeyName() As String
      Get
        Return strKeyName
      End Get
      Set(ByVal Value As String)
        strKeyName = Value
      End Set
    End Property

    'ȡ��С������
    Public Property AppName() As String
      Get
        Return strAppName
      End Get
      Set(ByVal Value As String)
        strAppName = Value
      End Set
    End Property
    '
    '������������
    '
  End Class
End Module
