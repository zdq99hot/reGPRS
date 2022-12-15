Imports GPRS.com.hzy.common
Imports System.Threading
'Imports gprs_vbnet.FrmMain
Imports GPRS.Form1

'子线程
Public Class Detail
  '利用这个类是为了能够给主窗体传送数据
    Public threadDelegateChild As ThreadStart '子线程委托
    Public threadChild As Thread '子线程

  'Dim frmmain As frmmain
  Dim FrmMain As Form1

    '   Dim frmdetail As frmdetail
  Dim tModemInfo As New ModemInfoStruct
    Dim AddDataInfo() As String = New String(3) {}
    '重写构造器
  Public Sub New()
    'ThreadStart 委托（可以在msn上查＂ThreadStart 委托＂作用在about()后收线程资源）
    threadDelegateChild = New ThreadStart(AddressOf ThreadMethodChild)
    threadChild = New Thread(threadDelegateChild)
  End Sub
  '接收主现成所传来的数据包
  Public Sub setModemInfo(ByRef tModemInfo As ModemInfoStruct)
    Me.tModemInfo = tModemInfo
  End Sub
  '接收主窗体对象
  Public Sub setFrmMain(ByRef FrmMain As Form1)
    'Public Sub setFrmMain(ByRef frmmain As frmmain)


    Me.FrmMain = FrmMain
  End Sub

  Public Sub ThreadMethodChild()
    'Me.XYZ()

  End Sub

  Private Sub XYZ()
    '行读取用户数据
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
          FrmMain.AddText("对控制命令帧的回应")
        End If
        FrmMain.AddText(ControlChars.Cr)
        FrmMain.AddText(("用户ID：" + Hex(CStr(rvData.m_ModemId))))
        FrmMain.AddText(("接收时间：" + DateTime.Now.ToLongTimeString()))
        FrmMain.AddText(("数据长度：" + rvData.m_Data_Len.ToString))

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
        FrmMain.AddText(("接收数据：" + ShowData))

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
    ' 远端数据采集通讯协议()
    '1.报文格式()

    '报头	目的ID	本机ID	数据类型	数据长度	应用数据	校验和	报尾
    '0X7E	8 BYTE	8 BYTE	1 BYTE	  1 BYTE		          1 BYTE	0X6A
    '        |--------------校验范围----------------|
    '2.报文说明()
    '  1.报头固定为0X7E()
    '  2.目的ID和本机ID均为 为8字节BCD码 . 监控中心的目的ID固定为 88888888 ;远程终端ID为GPRS模块 ID
    '3.数据类型()
    '    'P'  >监控中心轮询远程终端采集数据的报文类型;终端站应答的报文类型
    '    'S'  >监控中心设置远程终端参数的报文类型;终端站应答的报文类型
    '    'R'  >监控中心复位远程终端系统的报文类型;终端站应答的报文类型
    '    'A'  <远程终端上传数据到监控中心的报文类型;监控中心应答的报文类型
    '    'T'  <远程终端与监控中心通讯测试的报文类型;监控中心应答的报文类型
    '4.应用数据长度()
    '   为应用数据长度
    '5 .应用数据()
    '  每4字节为一个完整数据，顺序为:4个压力数据(16字节);2个流量数据(8字节);4个温度数据(16字节);4个开关量数据(16字节);时间数据(18字节).注:时间数据为字符串:”XX-XX-XX HH:MM:SS”.?结尾加结尾符0
    '6.校验和()
    '  1字节累加和校验
    '7.报尾()
    '    固定为0X6A()
    '监控中心与远程终端的数据交换,双方都要以相同的报文类型应答

    '如果在固定时间(目前1分钟)内得不到对方的应答,需重发报文,重发次数为2次,仍得不到应答,本次通讯失败 

  End Sub
End Class
