Imports GPRS.com.hzy.common
Imports System.Threading
'Imports gprs_vbnet.FrmMain
Imports GPRS.Form1

'���߳�
Public Class Detail
  '�����������Ϊ���ܹ��������崫������
    Public threadDelegateChild As ThreadStart '���߳�ί��
    Public threadChild As Thread '���߳�

  'Dim frmmain As frmmain
  Dim FrmMain As Form1

    '   Dim frmdetail As frmdetail
  Dim tModemInfo As New ModemInfoStruct
    Dim AddDataInfo() As String = New String(3) {}
    '��д������
  Public Sub New()
    'ThreadStart ί�У�������msn�ϲ飢ThreadStart ί�У�������about()�����߳���Դ��
    threadDelegateChild = New ThreadStart(AddressOf ThreadMethodChild)
    threadChild = New Thread(threadDelegateChild)
  End Sub
  '�������ֳ������������ݰ�
  Public Sub setModemInfo(ByRef tModemInfo As ModemInfoStruct)
    Me.tModemInfo = tModemInfo
  End Sub
  '�������������
  Public Sub setFrmMain(ByRef FrmMain As Form1)
    'Public Sub setFrmMain(ByRef frmmain As frmmain)


    Me.FrmMain = FrmMain
  End Sub

  Public Sub ThreadMethodChild()
    'Me.XYZ()

  End Sub

  Private Sub XYZ()
    '�ж�ȡ�û�����
    'Dim lpPrevWinProc As Long
    Dim PCount As Long

    Dim rvData As New ModemDataStruct
    rvData.m_Data_Buf = New Byte(1450) {}

    Dim result As Boolean
    result = GprsMod.DSGetNextData(rvData, 0)
    'MsgBox(result)

    If result Then

      If rvData.m_Data_Len > 0 Then

        If FrmMain.txtPCount.Text = "HZY" Then
          pcount = 0
        Else
          pcount = Convert.ToInt32(FrmMain.txtPCount.Text)
        End If
        If pcount Mod 20 = 0 Then
          FrmMain.txtInfo.Text = ""
        End If
        If rvData.m_Data_Type = 2 Then
          FrmMain.AddText("�Կ�������֡�Ļ�Ӧ")
        End If
        FrmMain.AddText(ControlChars.Cr)
        FrmMain.AddText(("�û�ID��" + Hex(CStr(rvData.m_ModemId))))
        FrmMain.AddText(("����ʱ�䣺" + DateTime.Now.ToLongTimeString()))
        FrmMain.AddText(("���ݳ��ȣ�" + rvData.m_Data_Len.ToString))

        'Dim showdata As String
        Dim Ascii As New System.Text.ASCIIEncoding
        Dim ShowData As String = Mid(Ascii.GetString(rvData.m_Data_Buf), 1, rvData.m_Data_Len)

        'showdata = StrConv(rvdata.m_data_buf, VbStrConv.LowerCase)
        'showdata = ASCIIEncoding.GetString()
        'rvdata.m_data_buf(rvdata.m_data_len) = 0
        'Dim i As Integer

        'For i = 0 To rvdata.m_data_len - 1
        '    showdata += rvdata.m_data_buf(i).ToString()
        'Next i
        'Dim i, bufLength As Int32
        Dim sDataBuf As String
        'bufLength = rvdata.m_data_buf.Length
        'For i = 0 To bufLength - 1
        '    sDataBuf = sDataBuf + Hex(rvdata.m_data_buf(i))
        'Next
        rvData.m_Data_Buf(rvData.m_Data_Len) = 0
        sDataBuf = byteToHexStr(rvData.m_Data_Buf, rvData.m_Data_Len)
        FrmMain.AddText("get data:::" + "----------------------------------------------------")
        FrmMain.AddText(sDataBuf)
        FrmMain.AddText("---------------------------------------------------------------")
        FrmMain.AddText(("�������ݣ�" + ShowData))

        'Dim int1 As Int32 = Hex(rvdata.m_data_buf(0))

        FrmMain.txtPCount.Text = (PCount + 1).ToString()
      Else
        If rvData.m_Data_Len = 0 Then
          'PollUserTable()
        End If
      End If
    End If
  End Sub
  
  Private Sub ShuoMing()
    ' Զ�����ݲɼ�ͨѶЭ��()
    '1.���ĸ�ʽ()

    '��ͷ	Ŀ��ID	����ID	��������	���ݳ���	Ӧ������	У���	��β
    '0X7E	8 BYTE	8 BYTE	1 BYTE	  1 BYTE		          1 BYTE	0X6A
    '        |--------------У�鷶Χ----------------|
    '2.����˵��()
    '  1.��ͷ�̶�Ϊ0X7E()
    '  2.Ŀ��ID�ͱ���ID��Ϊ Ϊ8�ֽ�BCD�� . ������ĵ�Ŀ��ID�̶�Ϊ 88888888 ;Զ���ն�IDΪGPRSģ�� ID
    '3.��������()
    '    'P'  >���������ѯԶ���ն˲ɼ����ݵı�������;�ն�վӦ��ı�������
    '    'S'  >�����������Զ���ն˲����ı�������;�ն�վӦ��ı�������
    '    'R'  >������ĸ�λԶ���ն�ϵͳ�ı�������;�ն�վӦ��ı�������
    '    'A'  <Զ���ն��ϴ����ݵ�������ĵı�������;�������Ӧ��ı�������
    '    'T'  <Զ���ն���������ͨѶ���Եı�������;�������Ӧ��ı�������
    '4.Ӧ�����ݳ���()
    '   ΪӦ�����ݳ���
    '5 .Ӧ������()
    '  ÿ4�ֽ�Ϊһ���������ݣ�˳��Ϊ:4��ѹ������(16�ֽ�);2����������(8�ֽ�);4���¶�����(16�ֽ�);4������������(16�ֽ�);ʱ������(18�ֽ�).ע:ʱ������Ϊ�ַ���:��XX-XX-XX HH:MM:SS��.?��β�ӽ�β��0
    '6.У���()
    '  1�ֽ��ۼӺ�У��
    '7.��β()
    '    �̶�Ϊ0X6A()
    '���������Զ���ն˵����ݽ���,˫����Ҫ����ͬ�ı�������Ӧ��

    '����ڹ̶�ʱ��(Ŀǰ1����)�ڵò����Է���Ӧ��,���ط�����,�ط�����Ϊ2��,�Եò���Ӧ��,����ͨѶʧ�� 

  End Sub
End Class
