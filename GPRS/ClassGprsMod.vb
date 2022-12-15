
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Namespace com.Hzy.common
  Public Class ClassGprsMod
    Public Shared msgTitle As String = "��Ϣ��ʾ"
  End Class
  Public Module GlobalVal

    '������ʹ�õı���
    Public SrvPort As Int32  '����˿�
    Public WaitTime As Int32  '��ѯʱ��
    Public redcolor As Int32
    Public greencolor As Int32
    Public bluecolor As Int32
    Public colorflag As Int32
    Public LineCount As Int32
    Public SysAutoM As Int32
    Public oldwindow As Long
    Public frmdetailshow As Boolean
    '      Public frmDetail As frmDetail
    ' Public db As New db
    Public connection As SqlClient.SqlConnection
    Public server As String
    Public database As String

    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" _
       (ByVal lpApplicationName As String, _
       ByVal lpKeyName As String, _
       ByVal lpString As String, _
       ByVal lpFileName As String) As Long

    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" _
       (ByVal lpApplicationName As String, _
       ByVal lpKeyName As String, _
       ByVal lpDefault As String, _
       ByVal lpReturnedString As String, _
       ByVal nSize As Int32, _
       ByVal lpFileName As String) As Long

    Public Sub setPort(ByVal Text As String)
      'Dim success As Long
      'success = WritePrivateProfileString("PORT", "port", text, Application.StartupPath & "\gprs.ini")
      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      Dim PINI As New GprsRWini
      With PINI
        Dim SPath As String

        If CW.GPRSWorkFilePath <> "" Then
          SPath = CW.GPRSWorkFilePath
        Else
          SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
        End If

        '''''''''read
        '.FileName = SPath
        '.AppName = "TX"
        '.KeyName = "SrvPort"
        'S = .ReadINI(RWiniBZString)

        '''''''''write
        .FileName = SPath
        .AppName = "TX"
        .KeyName = "SrvPort"
        .ValueStr = Text
        .WriteINI(RWini_BZString)

      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    End Sub

    Public Function getPort() As Int32 'as string

      'Dim ret As Long
      'Dim buff As String
      'buff = New String(" ", 100)
      'ret = GlobalVal.GetPrivateProfileString("PORT", "port", "", buff, 100, Application.StartupPath & "\gprs.ini")
      'Return CType(buff, Int32)

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      Dim PINI As New GprsRWini
      With PINI
        Dim SPath, S As String

        If CW.GPRSWorkFilePath <> "" Then
          SPath = CW.GPRSWorkFilePath
        Else
          SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
        End If

        '''''''''read
        .FileName = SPath
        .AppName = "TX"
        .KeyName = "SrvPort"
        S = .ReadINI(RWini_BZString)

        getPort = CSng(S)

        '''''''''write
        '.FileName = SPath
        '.AppName = "TX"
        '.KeyName = "SrvPort"
        '.ValueStr = CStr(SrvPort)
        '.WriteINI(RWiniBZString)

      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    End Function

    Public Function getServer() As String
      'Dim retserver As String
      'Dim buffserver As String
      'buffserver = New String(" ", 100)
      'retserver = GetPrivateProfileString("DB", "server", "", buffserver, 100, Application.StartupPath & "\gprs.ini")
      'Return buffserver
      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      Dim PINI As New GprsRWini
      With PINI
        Dim SPath, S As String

        If CW.GPRSWorkFilePath <> "" Then
          SPath = CW.GPRSWorkFilePath
        Else
          SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
        End If

        '''''''''read
        .FileName = SPath
        .AppName = "DB"
        .KeyName = "server"
        S = .ReadINI(RWini_BZString)

        getServer = S
        '''''''''write
        '.FileName = SPath
        '.AppName = "TX"
        '.KeyName = "SrvPort"
        '.ValueStr = CStr(SrvPort)
        '.WriteINI(RWiniBZString)

      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    End Function

    Public Function getDatabase() As String
      'Dim retdatebase As String
      'Dim buffdatabase As String
      'buffdatabase = New String(" ", 100)
      'retdatebase = GetPrivateProfileString("DB", "database", "", buffdatabase, 100, Application.StartupPath & "\gprs.ini")
      'Return buffdatabase

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      Dim PINI As New GprsRWini
      With PINI
        Dim SPath, S As String

        If CW.GPRSWorkFilePath <> "" Then
          SPath = CW.GPRSWorkFilePath
        Else
          SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
        End If

        '''''''''read
        .FileName = SPath
        .AppName = "DB"
        .KeyName = "database"
        S = .ReadINI(RWini_BZString)

        getDatabase = S
        '''''''''write
        '.FileName = SPath
        '.AppName = "TX"
        '.KeyName = "SrvPort"
        '.ValueStr = CStr(SrvPort)
        '.WriteINI(RWiniBZString)

      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    End Function
    Public Sub setTime(ByVal Text As String)
      'Dim success As Long
      'success = WritePrivateProfileString("TIME", "time", text, Application.StartupPath & "\gprs.ini")

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      Dim PINI As New GprsRWini
      With PINI
        Dim SPath As String

        If CW.GPRSWorkFilePath <> "" Then
          SPath = CW.GPRSWorkFilePath
        Else
          SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
        End If

        '''''''''read
        '.FileName = SPath
        '.AppName = "DB"
        '.KeyName = "database"
        'S = .ReadINI(RWiniBZString)

        '''''''''write
        .FileName = SPath
        .AppName = "TX"
        .KeyName = "time"
        .ValueStr = Text
        .WriteINI(RWini_BZString)

      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    End Sub
    Public Function getTime() As Int32 ' As String
      'Dim ret As Long
      'Dim buff As String
      'buff = New String(" ", 100)
      'ret = GlobalVal.GetPrivateProfileString("TIME", "time", "", buff, 100, Application.StartupPath & "\gprs.ini")
      'Return CType(buff, Int32)

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      Dim PINI As New GprsRWini
      With PINI
        Dim SPath, S As String

        If CW.GPRSWorkFilePath <> "" Then
          SPath = CW.GPRSWorkFilePath
        Else
          SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
        End If

        '''''''''read
        .FileName = SPath
        .AppName = "TX"
        .KeyName = "time"
        S = .ReadINI(RWini_BZString)

        getTime = CSng(S)

        '''''''''write
        '.FileName = SPath
        '.AppName = "TX"
        '.KeyName = "SrvPort"
        '.ValueStr = CStr(SrvPort)
        '.WriteINI(RWiniBZString)

      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    End Function
  End Module


  <StructLayout(LayoutKind.Sequential)> Public Structure ModemInfoStruct
    Public m_ModemId As Int32        'Modemģ���id��
    <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Public m_PhoneNo() As Byte                 '=new byte[12]; 'Modem��11λ�绰���룬������'\0'�ַ���β
    <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Public m_DynIp() As Byte                  '=new byte[4]; 'modem��4λ��̬ip��ַ
    Public m_Conn_Time As Int32       'modemģ�����һ�ν���tcp���ӵ�ʱ��
    Public m_Refresh_Time As Int32    'modemģ�����һ���շ����ݵ�ʱ��
  End Structure

  <StructLayout(LayoutKind.Sequential)> Public Structure ModemDataStruct
    Public m_ModemId As Int32    'modemģ���Id��
    Public m_Recv_Time As Int32    '���յ����ݰ���ʱ��
    <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1451)> Public m_Data_Buf() As Byte
    Public m_Data_Len As Int16     '���յ����ݰ�����
    Public m_Data_Type As Byte   '���յ������ݱ����ͣ�0x01:�û����ݰ� 0x02:�Կ���������Ļ�Ӧ 
  End Structure

  Public Class GprsMod

    Public Const GWL_WNDPROC As Long = -4
    Public Const GWL_USERDATA As Long = -21
    Public Const WM_SIZE As Long = &H5
    Public Const WM_USER As Long = &H400
    Public Const DLLNAME As String = "GprsDll.dll"

    '�������񷽷�

    Public Declare Function DSStartService Lib "GprsDll.dll" (ByVal ListenPort As Int32) As Boolean

    '��ʾ����

    Public Declare Function DSGetLastError Lib "GprsDll.dll" (ByVal Str As String, ByVal MaxSize As Int32) As String

    'ֹͣ���񷽷�

    Public Declare Function DSStopService Lib "GprsDll.dll" () As Long

    '��ȡ�û���Ϣ

    Public Declare Function DSGetModemByPosition Lib "GprsDll.dll" (ByVal Index As Int32, ByRef ModemInfo As ModemInfoStruct) As Long

    '��ȡ���ݺ���

    Public Declare Function DSGetNextData Lib "GprsDll.dll" (ByRef Data As ModemDataStruct, ByVal TimeoutSends As Int32) As Long

    '�������ݺ���

    Public Declare Function DSSendData Lib "GprsDll.dll" (ByVal Id As Int32, ByVal Length As Int32, ByRef Mess As Byte) As Int32

    '��ȡ��ǰ�����û�������

    Public Declare Function DSGetModemCount Lib "GprsDll.dll" () As Integer

    '���Ϳ�������

    Public Declare Function DSSendControl Lib "GprsDll.dll" (ByVal ModemId As Int32, ByVal Ctrlen As Int32, ByRef buf As Byte) As Int32
    'Public Shared<DllImport("GprsDll.dll")> Function DSGetNextData(data As ModemDataStruct, timeoutsends As Integer) As Long
  End Class
End Namespace

