Module ModuleGPRSdll
  Public Const RAS95_MaxEntryName As Integer = 256

  Public Class RASENTRYNAME95
    Public dwSize As Long
    Public szEntryName(RAS95_MaxEntryName) As Byte
  End Class

  '**********************************
  '* RAS API 声明 *
  '**********************************
  Public Declare Function RasEnumConnections Lib "rasapi32.dll" Alias "RasEnumConnectionsA" (ByVal lprasconn As VariantType, ByVal lpcb As Integer, ByVal lpcConnections As Long) As Integer
  Public Declare Function RasEnumEntries Lib "rasapi32.dll" Alias "RasEnumEntriesA" (ByVal reserved As String, ByVal lpszPhonebook As String, ByVal lprasentryname As String, ByVal lpcb As Integer, ByVal lpcEntries As Long) As Integer

  '****************************************************************************************
  '* GPRSDll.dll 的声明 *
  '****************************************************************************************
  Private Const GWL_WNDPROC As Integer = -4
  Private Const GWL_USERDATA As Integer = (-21)
  Private Const WM_SIZE As Byte = &H5
  Public Const WM_USER As Integer = &H400
  Private Const DLLNAME As String = "gprsdll.dll"

  '程序中使用的变量
  Public SrvPort As Integer     '服务端口
  Public ListenTimeLong As Integer '监听时的延时时间
  Public SysAutoM As Integer '是否自动维护用户列表

  'Public WaitTime As Integer    '轮询时间
  'Public RedColor As Integer
  'Public GreenColor As Integer
  'Public BlueColor As Integer
  'Public ColorFlag As Integer
  'Public LineCount As Integer

  'Public OldWindow As Long

  ''Public Structure ModemInfoStruct
  ''  Public m_ModemID As Long                             'Modem模块的ID号
  ''  Public m_PhoneNo() As Byte                  'Modem的11位电话号码，必须以'\0'字符结尾
  ''  Public m_DynIP() As Byte                       'Modem的4位动态ip地址
  ''  Public m_Conn_Time As Long                         'Modem模块最后一次建立TCP连接的时间
  ''  Public m_Refresh_Time As Long                     '接收到的数据包长度
  ''End Structure

  'Public Structure ModemDataStruct
  '  Public m_ModemID As Long                             'Modem模块的ID号
  '  Public m_Recv_Time As Long                         '接收到数据包的时间
  '  '    m_data_buf(0 To MAX_RECEIVE_BUF + 1) As Byte '存储接收到的数据

  '  Public m_Data_Len As Integer                           '接收到的数据包长度
  '  Public m_Data_Type As Byte                            '接收到的数据包类型,0x01：用户数据包    0x02：对控制命令帧的回应
  '  Public m_Data_Buf() As Byte
  'End Structure

  'Public Class ModemInfoStruct
  '  Public M_ModemID As Long                            'Modem模块的ID号
  '  Public M_PhoneNo(11) As Byte                    'Modem的11位电话号码，必须以'\0'字符结尾
  '  Public M_DynIP(3) As Byte                       'Modem的4位动态ip地址
  '  Public M_conn_Time As Long                        'Modem模块最后一次建立TCP连接的时间
  '  Public M_Refresh_Time As Long                     '接收到的数据包长度
  'End Class

  ''Public Class ModemDataStruct
  ''  Public M_ModemID As Long                            'Modem模块的ID号
  ''  Public M_Recv_Time As Long                         '接收到数据包的时间
  ''  '    m_data_buf(0 To MAX_RECEIVE_BUF + 1) As Byte '存储接收到的数据

  ''  Public M_Data_Len As Integer                         '接收到的数据包长度
  ''  Public M_Data_Type As Byte                           '接收到的数据包类型,0x01：用户数据包    0x02：对控制命令帧的回应
  ''  Public M_Data_Buf(8192) As Byte
  ''End Class

  ''启动服务函数
  ''Public Declare Function start_gprs_server Lib "gprsdll.dll" '(ByVal hw As Long, ByVal Msg As Long, ByVal serport As Long, '            mess As Byte, Optional ByVal iPollTime As Integer = 0, Optional ByVal iTimerval As Integer = 30 '            ) As Long
  ''Public Declare Function DSGetLastError Lib "gprsdll.dll" () As String
  'Public Declare Function DSStartService Lib "gprsdll.dll" (ByVal listenport As Long) As Integer   '//没有16位的无符号数，所以只有采用32位的有符号数

  ''停止服务函数
  'Public Declare Function DSStopService Lib "gprsdll.dll" () As Integer

  ''获得用户信息
  'Public Declare Function DSGetModemByPosition Lib "gprsdll.dll" (ByVal Index As Integer, ByVal modeminfo As ModemInfoStruct) As Integer

  ''读数据函数
  'Public Declare Function DSGetNextData Lib "gprsdll.dll" (ByVal data As ModemDataStruct, ByVal timeoutseconds As Integer) As Integer

  ''发送数据函数
  'Public Declare Function DSSendData Lib "gprsdll.dll" (ByVal id As Long, ByVal length As Integer, ByVal mess As Byte) As Integer

  ''得到当前在线用户的数量
  'Public Declare Function DSGetModemCount Lib "gprsdll.dll" () As Integer

  ''发送控制命令
  'Public Declare Function DSSendControl Lib "gprsdll.dll" (ByVal modemId As Long, ByVal Ctrlen As Integer, ByVal buf As Byte) As Integer

  ''windos API函数，可以查看MSDN
  'Public Declare Function CallWindowProc Lib "user32" Alias "CallWindowProcA" (ByVal lpPrevWndFunc As Long, ByVal hwnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer


  ''windos API函数，可以查看MSDN
  'Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer

  ''windos API函数，可以查看MSDN
  'Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer

  ''windos API函数，可以查看MSDN
  'Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

  'Public Function GetAddressOf(ByVal AddressOfProc As Integer) As Integer
  '  GetAddressOf = AddressOfProc
  'End Function
End Module
