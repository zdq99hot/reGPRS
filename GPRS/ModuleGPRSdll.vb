Module ModuleGPRSdll
  Public Const RAS95_MaxEntryName As Integer = 256

  Public Class RASENTRYNAME95
    Public dwSize As Long
    Public szEntryName(RAS95_MaxEntryName) As Byte
  End Class

  '**********************************
  '* RAS API ���� *
  '**********************************
  Public Declare Function RasEnumConnections Lib "rasapi32.dll" Alias "RasEnumConnectionsA" (ByVal lprasconn As VariantType, ByVal lpcb As Integer, ByVal lpcConnections As Long) As Integer
  Public Declare Function RasEnumEntries Lib "rasapi32.dll" Alias "RasEnumEntriesA" (ByVal reserved As String, ByVal lpszPhonebook As String, ByVal lprasentryname As String, ByVal lpcb As Integer, ByVal lpcEntries As Long) As Integer

  '****************************************************************************************
  '* GPRSDll.dll ������ *
  '****************************************************************************************
  Private Const GWL_WNDPROC As Integer = -4
  Private Const GWL_USERDATA As Integer = (-21)
  Private Const WM_SIZE As Byte = &H5
  Public Const WM_USER As Integer = &H400
  Private Const DLLNAME As String = "gprsdll.dll"

  '������ʹ�õı���
  Public SrvPort As Integer     '����˿�
  Public ListenTimeLong As Integer '����ʱ����ʱʱ��
  Public SysAutoM As Integer '�Ƿ��Զ�ά���û��б�

  'Public WaitTime As Integer    '��ѯʱ��
  'Public RedColor As Integer
  'Public GreenColor As Integer
  'Public BlueColor As Integer
  'Public ColorFlag As Integer
  'Public LineCount As Integer

  'Public OldWindow As Long

  ''Public Structure ModemInfoStruct
  ''  Public m_ModemID As Long                             'Modemģ���ID��
  ''  Public m_PhoneNo() As Byte                  'Modem��11λ�绰���룬������'\0'�ַ���β
  ''  Public m_DynIP() As Byte                       'Modem��4λ��̬ip��ַ
  ''  Public m_Conn_Time As Long                         'Modemģ�����һ�ν���TCP���ӵ�ʱ��
  ''  Public m_Refresh_Time As Long                     '���յ������ݰ�����
  ''End Structure

  'Public Structure ModemDataStruct
  '  Public m_ModemID As Long                             'Modemģ���ID��
  '  Public m_Recv_Time As Long                         '���յ����ݰ���ʱ��
  '  '    m_data_buf(0 To MAX_RECEIVE_BUF + 1) As Byte '�洢���յ�������

  '  Public m_Data_Len As Integer                           '���յ������ݰ�����
  '  Public m_Data_Type As Byte                            '���յ������ݰ�����,0x01���û����ݰ�    0x02���Կ�������֡�Ļ�Ӧ
  '  Public m_Data_Buf() As Byte
  'End Structure

  'Public Class ModemInfoStruct
  '  Public M_ModemID As Long                            'Modemģ���ID��
  '  Public M_PhoneNo(11) As Byte                    'Modem��11λ�绰���룬������'\0'�ַ���β
  '  Public M_DynIP(3) As Byte                       'Modem��4λ��̬ip��ַ
  '  Public M_conn_Time As Long                        'Modemģ�����һ�ν���TCP���ӵ�ʱ��
  '  Public M_Refresh_Time As Long                     '���յ������ݰ�����
  'End Class

  ''Public Class ModemDataStruct
  ''  Public M_ModemID As Long                            'Modemģ���ID��
  ''  Public M_Recv_Time As Long                         '���յ����ݰ���ʱ��
  ''  '    m_data_buf(0 To MAX_RECEIVE_BUF + 1) As Byte '�洢���յ�������

  ''  Public M_Data_Len As Integer                         '���յ������ݰ�����
  ''  Public M_Data_Type As Byte                           '���յ������ݰ�����,0x01���û����ݰ�    0x02���Կ�������֡�Ļ�Ӧ
  ''  Public M_Data_Buf(8192) As Byte
  ''End Class

  ''����������
  ''Public Declare Function start_gprs_server Lib "gprsdll.dll" '(ByVal hw As Long, ByVal Msg As Long, ByVal serport As Long, '            mess As Byte, Optional ByVal iPollTime As Integer = 0, Optional ByVal iTimerval As Integer = 30 '            ) As Long
  ''Public Declare Function DSGetLastError Lib "gprsdll.dll" () As String
  'Public Declare Function DSStartService Lib "gprsdll.dll" (ByVal listenport As Long) As Integer   '//û��16λ���޷�����������ֻ�в���32λ���з�����

  ''ֹͣ������
  'Public Declare Function DSStopService Lib "gprsdll.dll" () As Integer

  ''����û���Ϣ
  'Public Declare Function DSGetModemByPosition Lib "gprsdll.dll" (ByVal Index As Integer, ByVal modeminfo As ModemInfoStruct) As Integer

  ''�����ݺ���
  'Public Declare Function DSGetNextData Lib "gprsdll.dll" (ByVal data As ModemDataStruct, ByVal timeoutseconds As Integer) As Integer

  ''�������ݺ���
  'Public Declare Function DSSendData Lib "gprsdll.dll" (ByVal id As Long, ByVal length As Integer, ByVal mess As Byte) As Integer

  ''�õ���ǰ�����û�������
  'Public Declare Function DSGetModemCount Lib "gprsdll.dll" () As Integer

  ''���Ϳ�������
  'Public Declare Function DSSendControl Lib "gprsdll.dll" (ByVal modemId As Long, ByVal Ctrlen As Integer, ByVal buf As Byte) As Integer

  ''windos API���������Բ鿴MSDN
  'Public Declare Function CallWindowProc Lib "user32" Alias "CallWindowProcA" (ByVal lpPrevWndFunc As Long, ByVal hwnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer


  ''windos API���������Բ鿴MSDN
  'Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer

  ''windos API���������Բ鿴MSDN
  'Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer

  ''windos API���������Բ鿴MSDN
  'Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

  'Public Function GetAddressOf(ByVal AddressOfProc As Integer) As Integer
  '  GetAddressOf = AddressOfProc
  'End Function
End Module
