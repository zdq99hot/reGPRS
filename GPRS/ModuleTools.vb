Imports System.Security.Cryptography
Module ModuleTools

#Region "20070202后添加"
  Public String_Separator As String = ","
  Public DataInfo_MDB_File As String = "DataInfo"
  Public DataInfo_MDB_Table As String = "StationInfo"
  Public FN As New MyFieldsName
  Public TCB As New MyTChartBasicSet


#Region "结构MyFieldsName"
  Public Structure MyFieldsName
    Public MyID As String
    Public MyMapName As String
    Public MyStationName As String
    Public MyTestDate As String

    Public StationID As String
    Public WorkID As String
    Public FamilyID As String

    Public StationName As String
    Public StationAddress As String
    Public StationPhoneNum As String
    Public TH As String
    Public mm As String

    Public FamilyAddress As String
    Public FamilyPhoneNum As String
    Public FamilyName As String

    Public TestDate As String

    Public TimeString() As String

  End Structure
#End Region
#Region "字段名称赋值SetFN"
  Public Function SetFN() As Boolean
    Dim i As Integer
    Dim S As String
    With FN
      .MyID = "编号"
      .MyMapName = "地图名称"
      .MyStationName = "站点名称"
      .MyTestDate = "检测时间"

      .WorkID = "ID"
      .FamilyAddress = "家庭地址"
      .FamilyID = "家庭ID"
      .FamilyName = "家庭名称"
      .FamilyPhoneNum = "家庭电话"
      .StationAddress = "站地址"
      .StationID = "站ID"
      .StationName = "站名称"
      .StationPhoneNum = "站电话"
      .TestDate = "日期"
      .TH = "站吨位"
      .mm = "站管径"

      ReDim .TimeString(23)
      For i = 0 To 23
        S = CStr(i)
        If Len(S) < 2 Then
          S = "0" & S
        End If
        S = S & "点"
        .TimeString(i) = S
      Next

    End With
  End Function
#End Region

#Region "TChart的基本设置类MyTChartBasicSet"
  Public Class MyTChartBasicSet
    Public AxixLeftMin As Double
    Public AxixLeftMax As Double
    Public AxixBottomMin As Double
    Public AxixBottomMax As Double
    Sub New()
      AxixLeftMin = 0
      AxixLeftMax = 30
      AxixBottomMin = 0
      AxixBottomMax = 23
    End Sub
  End Class

#End Region


#End Region

#Region "形成SQL选择字符串BuildSelectString"
  Public Function BuildSelectString(ByVal SelectStation As Point, ByVal DateYMD As Date, ByVal BuildSelectStringMode As String) As String
    Dim S, StartDate, EndDate As String
    BuildSelectString = ""

    If (SelectStation.X < 0) Or (SelectStation.Y < 0) Then Exit Function

    DateYMD = DateYMD.Date

    Select Case BuildSelectStringMode

      Case "月"

        StartDate = CStr(CDate(DateYMD.Year.ToString & "年" & DateYMD.Month.ToString & "月").Date)
        EndDate = CStr(DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, CDate(StartDate).Date))).Date)
        'If (SelectStation.Y < 0) Then ''''''''''虽然选择的是一个地图，先把所有的都弄出来在显示的时候再筛选,一个地图全选，和一个月全选，不处理
        '  S = ""
        '  S = "StationID > '0' AND SaveID > 0 AND TestDate >= " & StartDate & " AND TestDate <= " & EndDate
        'Else
        S = ""
        'S = "StationID = '" & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationID.ToString.Trim & "' AND SaveID >0 AND TestDate >= " & StartDate & " AND TestDate <= " & EndDate

        S = "StationID = '" & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationID.ToString.Trim & "' AND SaveID >0 AND TestDate >= '" & StartDate & "' AND TestDate <= '" & EndDate & "'"
        'End If

        BuildSelectString = S

      Case "日"
        StartDate = CStr(CDate(DateYMD.Year.ToString & "年" & DateYMD.Month.ToString & "月" & DateYMD.Day.ToString & "日").Date)

        'If (SelectStation.Y < 0) Then
        '  S = ""
        '  S = "StationID > '0' AND SaveID > 0 AND TestDate = " & StartDate
        'Else
        S = ""
        'S = "StationID = '" & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationID.ToString.Trim & "' AND SaveID > 0 AND TestDate = " & StartDate
        S = "StationID = '" & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationID.ToString.Trim & "' AND SaveID > 0 AND TestDate = '" & StartDate & "'"
        'End If

        BuildSelectString = S

    End Select

  End Function
#End Region

#Region "以前的定义"
  Public Const BulidDate_Txt As String = "BulidDate.txt"
  Public Const STATION_LOCATION_OFFSET As Integer = 1000000 '地图图片的逻辑大小
  Public Const MAP_MAX_NO As Short = 10  '最大多少张地图
  Public Const STATION_MAX_NO As Short = 100   '每张地图最大站点数量
  Public Const STATION_PROPERTY_MAX_NO As Short = 10 '站点最多有几种属性
  Public Const FDSX_FD_PEC As Decimal = 1.3  '缩放地图的百分比
  Public Const FDSX_SX_PEC As Decimal = 0.8  '缩放地图的百分比
  Public Const PLACE_STATION_OFFSET As Short = 16 '放置站点是的鼠标偏移量
  Public Const DATA_LEN As Integer = 55 '数据长度  头1+ID4+类型1+长度1+数据包46+校验1+尾1
  Public Const Max_Print_XY As Integer = 11842 '代表A4纸宽的控件数据
  Public Const m_m_m As Single = 5.63904761904762 '0.1mm对应的平移数值
  Public Const Default_GprsWork_INIFilesName As String = "hzg"
  Public Const AppConfig_FilesName As String = "winapp32.dll" '总是在工程的工作目录里
  Public Const GprsWork_MdbFileName As String = "GPRSMdb.mdb" '总是在工程的工作目录里
  Public Const CWMap_Station_InfoMDB As String = "Info.mdb" '保存工程信息的数据库名称
  Public Const PrintLS_MDBFileName As String = "PrintLS.mdb" '保存工程信息的数据库名称
  Public Const DataMDB_FileName As String = "DataInfo.mdb" '保存参数检测值的数据库名称
  Public Const NoDate_DB As String = "2000-1-1" '数据库中代表无时间的常数 
  Public Const PMs_Name As String = "HZY-GPRS热网监测系统"
  Public Const LoadDB_StartDate As String = "2005-05-01" '查询数据库时从哪年开始判断有无数据
  Public Const MaxUser_Amount As Short = 20 '最多用户数
  Public Const Crypt_KEY As String = "zdq"
  Public Const RWini_BZString As String = "*" 'ini键值的标记字符
  Public Const PA_Key As String = "+3feoje+HgM="
  Public Const PA_KeyIV As String = "hOhewSk3leM="
  Public Const JiaGeString As String = "          "
  Public Const HZY As String = "HZY"
  Public Const TX_RetryNo As Integer = 3 '''''''''''超时重发次数
  Public Const PollUserTable_WaitTime As Integer = 1000
  Public Const ThreadRevMSend_WaitTime As Integer = 200
  Public Const AppVer_FileName As String = "AppVer.ini"
  '###########################通讯相关#################################
  Public Const SendData_BasicLong As Short = 21
  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
  'SD取SendData的缩写
  Public Const SD_Start As Byte = &H7E
  Public Const SD_End As Byte = &H6A
  Public Const Host_ID As String = "88888888"
  Public Const Rev_WaitTime As Long = 5

  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  '这些常数以后放到config.dll里
  '####################################################################
  'Public dsParameterData As New DataSet
  'Public daParameterData
  Public EDS As New GprsCrypt
  Public bForm7SaveLoad As Boolean 'Form7运行时的模式，True为保存，Load为查询

  Public RCWError As Boolean '读取工程过程中是否有错误，有错误的话不进行工程设置
  Public bMoMove As Boolean  '图片比框大，可以移动
  Public bMoPointChangED As Boolean '能移动的话，鼠标光标已经变了吗?
  Public CW As New GPRSWork
  Public CWActive As Boolean
  Public CWChanged As Boolean
  Public Form1Run As Boolean
  Public form2WorkSettingRun As Boolean '设置窗口是否在运行，和CWChanged配合，确定是否该刷新工程
  Public WorkWillPrint As New GPRSWorkPrint

  Public GprsWorkINI As New GprsRWini '记录工程信息的INI对象

  Public PM As New GprsProgramMe '程序自己，而不是工程
  Public AUsers As New GprsUesrs
  Public ActivePerson As New GPRSPerson
  Public SGif As New GPRSImagesResource '所有图形资源的类,放到模块作为公用
  Public TXDM As New GprsTXDataMode '通讯数据类型记录
  Public StationDataInfo As GprsRevStationDataInfo
  Public Const EM_LINESCROLL As Integer = &HB6
  Public Declare Function SendMessage Lib "User32" Alias _
  "SendMessageA" _
  (ByVal hWnd As Integer, _
  ByVal wMsg As Int16, _
  ByVal wParam As Int16, _
  ByVal lParam As Integer) As Integer
#End Region

  Public Class GprsProgramMe
    Public VerMode As String
    Public VerNum As String
    Public Name As String
    Sub New()
      VerNum = 200810201052
    End Sub

  End Class

  Public Function BuildCDMain(ByVal CDMain As MyClassData) As Boolean

    BuildCDMain = False
    With CDMain

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      '.DataSet = New DataSet
      '.DataSet.Dispose()
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      .ConnConnectionString = CreatAdoAccessCnnString(CW.WorkPath & "\" & DataInfo_MDB_File & ".mdb")
      .SQLString = "SELECT * FROM " & DataInfo_MDB_Table
      .Conn = New OleDb.OleDbConnection(.ConnConnectionString)
      .DataSet = New DataSet
      .DataAdapter = New OleDb.OleDbDataAdapter(.SQLString, .Conn)
      .DACommandBuilder = New OleDb.OleDbCommandBuilder(.DataAdapter)
      Try
        '.Conn.Open()
        .DataAdapter.Fill(.DataSet, DataInfo_MDB_Table)
        .DataTable = .DataSet.Tables(DataInfo_MDB_Table)
        BuildCDMain = True
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

      .Conn.Close()

      'CDP.CreatCDTable(CDNonceTemp.DataTable)

      ''''''报警线Rows


      Exit Function ''''''''''''''''挂起命令，用自动生成试试:2261210,可以了,又不可以了，1211

    End With
  End Function

  Public Function CheckString(ByVal Str As String, ByVal strSeparator As String, ByVal RorW As String, ByVal Num As Integer, ByRef strRWReturn As String) As Integer
    'str待处理的字符串，strSeparator分隔符，RorW读还是写“R”“W”，Num第几个数据，strW要写入的或读出的字符串,ByRef strRWReturn As String ByRef才好使。
    Dim Sno, Eno, StartNo, EndNo, tNum, i, k As Integer
    Dim S, SS As String
    Dim strGEr As System.CharEnumerator
    CheckString = -1
    If Str.Length < 1 Then Exit Function

    SS = Str

    If Not (Str.StartsWith(strSeparator)) Then
      SS = strSeparator & SS
    End If

    If Not (Str.EndsWith(strSeparator)) Then
      SS = SS & strSeparator
    End If

    tNum = 0
    Sno = Eno = 0
    strGEr = SS.GetEnumerator
    With strGEr
      For i = 1 To SS.Length
        .MoveNext()
        S = .Current
        If S = strSeparator Then
          If Sno = -1 Then
            Sno = i
          End If
          If i > Sno Then
            tNum += 1
            If tNum = Num Then
              StartNo = Sno
              EndNo = i
            End If
            Sno = i
          End If
        End If
      Next i
      CheckString = tNum

      Select Case RorW
        Case "R"
          k = EndNo - StartNo
          strRWReturn = Mid(Str, StartNo, k - 1)
        Case "W"
          Str = Mid(SS, 1, StartNo) & strRWReturn & Mid(SS, EndNo)
        Case Else

      End Select
    End With
  End Function

  Public Function CheckHavePrinter() As Boolean
    Dim Prn As New Printing.PrinterSettings
    Dim i As Integer
    i = Printing.PrinterSettings.InstalledPrinters().Count
    If i > 0 Then
      CheckHavePrinter = True
    Else
      CheckHavePrinter = False
    End If
  End Function

#Region "接收数据类"
  Public Class GprsRevStationDataInfo
    Dim HaveError As Boolean = False
    Public StationModeHowMany As Integer

    Public StationModeInfo() As GprsStationMode

    Sub New()
      Dim i, j, k As Integer
      Dim S As String
      S = RWIni(True, CW.GPRSWorkFilePath, "STATIONMODE", "StationModeHowMany", "")
      Try
        i = S
        Try
          If i > 0 Then
            StationModeHowMany = i
            ReDim StationModeInfo(StationModeHowMany) ''''''''''''''''''''''
          Else
            HaveError = True
          End If
        Catch ex As Exception
          HaveError = True
        End Try
      Catch ex As Exception
        HaveError = True
      End Try

      If HaveError = False Then

        For i = 1 To StationModeHowMany '''''''''''''''''''读取各个站点型号的设置

          StationModeInfo(i) = New GprsStationMode
          Dim HowManyParameter As Integer
          S = RWIni(True, CW.GPRSWorkFilePath, "STATIONMODE", "StationMode" & CStr(i) & "HowManyParameter", "")
          Try
            HowManyParameter = S
            If HowManyParameter > 0 Then

              S = RWIni(True, CW.GPRSWorkFilePath, "STATIONMODE", "StationMode" & CStr(i) & "ParameterByteLong", "")
              Try
                k = -1
                k = S
                If k > 0 Then
                  StationModeInfo(i).ParameterByteLong = k
                Else
                  HaveError = True
                End If
              Catch ex As Exception
                MessageBox.Show(ex.Message)
                HaveError = True
              End Try

              'StationModeInfo(i) = New GprsStationMode ''''''''''''''''''
              StationModeInfo(i).HowManyParameter = HowManyParameter
              StationModeInfo(i).SetHowManyParameter(HowManyParameter)

              For j = 1 To HowManyParameter

                S = RWIni(True, CW.GPRSWorkFilePath, "STATIONMODE", "StationMode" & CStr(i) & "Order" & CStr(j), "")
                Try
                  k = -1
                  k = S
                  If k > 0 Then
                    StationModeInfo(i).Order(j) = k
                  Else
                    HaveError = True
                  End If
                Catch ex As Exception
                  HaveError = True
                End Try

                S = RWIni(True, CW.GPRSWorkFilePath, "STATIONMODE", "StationMode" & CStr(i) & "Order_Dot" & CStr(j), "")
                Try
                  k = -1
                  k = S
                  If k >= 0 Then
                    StationModeInfo(i).Order_Dot(j) = k
                  Else
                    HaveError = True
                  End If
                Catch ex As Exception
                  HaveError = True
                End Try

              Next j
            Else
              HaveError = True
            End If
          Catch ex As Exception
            HaveError = True
          End Try

          '''''''''''''''''''''''''''''''''''''''20080106发送实时数据
          S = RWIni(True, CW.GPRSWorkFilePath, "SendMessage", "StationMode" & CStr(i) & "SendMessageHowMany", "")
          Try
            k = -1
            k = S
            If k > 0 Then
              StationModeInfo(i).SendMessageHowManySet(k)
            Else
              StationModeInfo(i).SendMessageHowManySet(0)
              'HaveError = True
            End If
          Catch ex As Exception
            'HaveError = True
          End Try

          For j = 1 To StationModeInfo(i).SendMessageHowMany

            S = RWIni(True, CW.GPRSWorkFilePath, "SendMessage", "StationMode" & CStr(i) & "SendMessageName" & CStr(j), "")
            Try
              StationModeInfo(i).SendMessageName(j) = S
            Catch ex As Exception
              'HaveError = True
            End Try

            S = RWIni(True, CW.GPRSWorkFilePath, "SendMessage", "StationMode" & CStr(i) & "SendMessageDanWei" & CStr(j), "")
            Try
              StationModeInfo(i).SendMessageDanWei(j) = S
            Catch ex As Exception
              'HaveError = True
            End Try

          Next j

        Next i



      End If

      If HaveError Then
        ReDim StationModeInfo(1)
        StationModeInfo(1) = New GprsStationMode
      End If

    End Sub

    Public Class GprsStationMode

      Public SendMessageHowMany As Integer
      Public SendMessageName() As String
      Public SendMessageDanWei() As String
      Public SendMessageIsNumeric() As Boolean

      Public Sub SendMessageHowManySet(ByVal HowMany As Integer)
        If HowMany < 0 Then Exit Sub
        SendMessageHowMany = HowMany
        ReDim SendMessageName(HowMany)
        ReDim SendMessageDanWei(HowMany)
      End Sub

      Public HowManyParameter As Integer
      Public ParameterByteLong As Integer
      Public Order() As Integer  '对应到数据库保存的站点参数的顺序(接收来的顺序如何从新排列)
      Public Order_Dot() As Integer '参数的小数点位数
      Private i As Int32

      Public Sub SetHowManyParameter(ByVal HowMany As Integer)
        If HowMany < 1 Then
          Exit Sub
        End If

        ReDim Order(HowMany)
        ReDim Order_Dot(HowMany) '小数点位数

      End Sub

      Sub New()
        HowManyParameter = 10
        ParameterByteLong = 4
        ReDim Order(HowManyParameter)
        ReDim Order_Dot(HowManyParameter) '小数点位数
        For i = 1 To HowManyParameter
          Select Case i
            'Case 1
            '  Order(i) = 2 '
            '  Order_Dot(i) = 2
            'Case 2
            '  Order(i) = 5 '
            '  Order_Dot(i) = 2
            'Case 3
            '  Order(i) = 1
            '  Order_Dot(i) = 2
            'Case 4
            '  Order(i) = 4 '
            '  Order_Dot(i) = 2
            'Case 5
            '  Order(i) = 3 '
            '  Order_Dot(i) = 2
            'Case 6
            '  Order(i) = 6
            '  Order_Dot(i) = 2

            Case 1
              Order(i) = 1
              Order_Dot(i) = 3
            Case 2
              Order(i) = 7
              Order_Dot(i) = 3
            Case 3
              Order(i) = 3
              Order_Dot(i) = 3
            Case 4
              Order(i) = 5
              Order_Dot(i) = 3
            Case 5
              Order(i) = 10
              Order_Dot(i) = 2
            Case 6
              Order(i) = 9
              Order_Dot(i) = 2
            Case 7
              Order(i) = 2
              Order_Dot(i) = 2
            Case 8
              Order(i) = 8
              Order_Dot(i) = 2
            Case 9
              Order(i) = 4
              Order_Dot(i) = 2
            Case 10
              Order(i) = 6
              Order_Dot(i) = 2
          End Select
        Next i
      End Sub
    End Class

  End Class
#End Region

  Public Class GprsTXDataMode
    Private pP As String
    Private pS As String
    Private pR As String
    Private pA As String
    Private pT As String
    Sub New()
      pP = "P"
      pS = "S"
      pR = "R"
      pA = "A"
      pT = "T"
    End Sub
    Public Function CheckP(ByVal ModeStr As String) As Boolean
      If ModeStr = pP Then
        CheckP = True
      Else
        CheckP = False
      End If
    End Function
    Public Function CheckS(ByVal ModeStr As String) As Boolean
      If ModeStr = pS Then
        CheckS = True
      Else
        CheckS = False
      End If
    End Function
    Public Function CheckR(ByVal ModeStr As String) As Boolean
      If ModeStr = pR Then
        CheckR = True
      Else
        CheckR = False
      End If
    End Function
    Public Function CheckA(ByVal ModeStr As String) As Boolean
      If ModeStr = pA Then
        CheckA = True
      Else
        CheckA = False
      End If
    End Function
    Public Function CheckT(ByVal ModeStr As String) As Boolean
      If ModeStr = pT Then
        CheckT = True
      Else
        CheckT = False
      End If
    End Function

    Public ReadOnly Property P() As String
      Get
        Return pP
      End Get
    End Property
    Public ReadOnly Property S() As String
      Get
        Return pS
      End Get
    End Property
    Public ReadOnly Property R() As String
      Get
        Return pR
      End Get
    End Property
    Public ReadOnly Property A() As String
      Get
        Return pA
      End Get
    End Property
    Public ReadOnly Property T() As String
      Get
        Return pT
      End Get
    End Property
  End Class

  Public Class GprsSendDataBackup
    '纪录已发送过请求的历史记录
    Public StationID As String
    Public ModemID As String
    Public DataMode As String
    Public DataString As String
    Public SendDate As Date
    Public SendSuccess As Boolean
    Public SendByteArray() As Byte
    Public RevED As Boolean '收到过了吗？
    Public RevSuccess As Boolean
    Public ReSendNo As Short
    Sub New()
      SendSuccess = False
      RevED = False
      RevSuccess = False
      ReSendNo = 0
    End Sub
  End Class

  Public Function ModemIDtoStationID(ByVal ModemID As String) As String
    ModemIDtoStationID = ""
    Dim i, j As Integer
    Dim bHave As Boolean

    bHave = False
    For i = 1 To CW.MapAmount
      For j = 1 To CW.Maps(i).MapStationPlacedAmount
        If ModemID = CW.Maps(i).Stations(j).ModemInfo.ID Then
          ModemIDtoStationID = CW.Maps(i).Stations(j).StationID
          bHave = True
          Exit For
        End If
        If bHave Then Exit For
      Next j
    Next i
  End Function

  Public Overloads Function JYHByte(ByVal ByteData() As Byte, ByVal StartIndex As Integer, ByVal Num As Integer) As Byte
    ' 计算校验和,StartIndex从0开始,也就是数组中的真实索引
    Dim i, j As Integer
    Dim tL As Long
    tL = 0
    j = ByteData.GetLowerBound(0)
    For i = 0 To Num - 1
      If StartIndex + Num - 1 > ByteData.GetUpperBound(0) Then Exit For '如果超出数组长度则校验到最后
      tL += ByteData(i + j + StartIndex)
    Next i
    tL = tL - ((tL \ 256) * 256)
    JYHByte = tL
  End Function

  Public Overloads Function JYHByte(ByVal ByteData() As Byte, ByVal StartIndex As Integer, ByVal Num As Integer, ByVal CheckSumByte As Byte) As Boolean
    ' 计算校验和,StartIndex从0开始
    Dim i, j As Integer
    Dim tB As Byte
    Dim tL As Long
    JYHByte = False
    tL = 0
    j = ByteData.GetLowerBound(0)
    For i = 0 To Num - 1
      If StartIndex + Num - 1 > ByteData.GetUpperBound(0) Then Exit For '如果超出数组长度则校验到最后
      tL += ByteData(i + j + StartIndex)
    Next i
    tL = tL - ((tL \ 256) * 256)
    tB = tL
    If tB = CheckSumByte Then JYHByte = True
  End Function

  Public Class GprsUesrs
    Public Users() As GPRSPerson
    Private pUserAmount As Short
    Public ActiveNo As Integer  '几号用户是活动用户
    Private i, j As Integer
    Sub New()
      pUserAmount = 0
      ActiveNo = -1

    End Sub
    Public Property UserAmount() As Short
      Get
        Return pUserAmount
      End Get
      Set(ByVal Value As Short)
        j = pUserAmount
        If Value >= 1 Then
          pUserAmount = Value
          ReDim Preserve Users(pUserAmount)

          If j <= 0 Then
            For i = 0 To pUserAmount
              Users(i) = New GPRSPerson
            Next i
          ElseIf pUserAmount > j Then
            For i = j + 1 To pUserAmount
              Users(i) = New GPRSPerson
            Next i
          End If

        End If
      End Set
    End Property

  End Class

  Public Function StringToLen8(ByVal CS As String) As String
    Dim i, j As Integer
    Dim S As String = ""
    StringToLen8 = ""
    i = CS.Length
    If i = 8 Then
      StringToLen8 = CS
    Else
      If i < 8 Then
        S = ""
        For j = 1 To 8 - i
          S &= "0"
        Next j
        StringToLen8 = S & CS
      End If

      If i > 8 Then
        StringToLen8 = Mid(S, 1, 8)
      End If
    End If
  End Function

  Public Function RWIni(ByVal ROrW As Boolean, ByVal FileName As String, ByVal AppName As String, ByVal KeyName As String, ByVal KeyValue As String) As String
    RWIni = ""
    Dim PINI As New GprsRWini
    With PINI

      .FileName = FileName
      .AppName = AppName
      .KeyName = KeyName

      Select Case ROrW

        Case True '读
          Try
            RWIni = .ReadINI(RWini_BZString)
          Catch ex As Exception
          End Try

        Case False '写

          .ValueStr = KeyValue
          Try
            .WriteINI(RWini_BZString)
          Catch ex As Exception
          End Try

      End Select
    End With
  End Function

  Public Overloads Function RWUsersIni(ByVal RW As Boolean, ByVal UserNo As Integer) As Boolean
    '读写单个用户信息
    If UserNo < 1 Then Exit Function
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    Dim i As Integer

    SPath = GetAppPath() & "\" & AppConfig_FilesName

    With PINI

      Select Case RW
        Case True ''''''''''''''''''''''''''''''''''''''''''''''''''''''读
          .FileName = SPath
          .AppName = "UserAmount"
          .KeyName = "Amount"
          S = .ReadINI(RWini_BZString)
          If S <> "" Then
            If IsNumeric(S) Then
              If CSng(S < 1) Then
                S = "1"
              End If
            Else
              S = "1"
            End If
          Else
            S = "1"
          End If
          AUsers.UserAmount = CSng(S)

          i = UserNo

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "Name"
          S = .ReadINI(RWini_BZString)
          If S = "" Then
            AUsers.Users(i).Name = "User" & CStr(i)
          Else
            AUsers.Users(i).Name = S
          End If

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "Pwd"
          S = .ReadINI(RWini_BZString)
          S = EDS.De(S)
          AUsers.Users(i).ChangePassword(AUsers.Users(i).Password, S, S)

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "PerLogin"
          S = .ReadINI(RWini_BZString)
          If S = "" Then S = "0"
          AUsers.Users(i).PerLogin = CSng(S)

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "SavePws"
          S = .ReadINI(RWini_BZString)
          If S = "" Then S = "0"
          AUsers.Users(i).SavePws = CSng(S)

        Case False ''''''''''''''''''''''''''''''''''''''''''''''''写
          .FileName = SPath
          .AppName = "UserAmount"
          .KeyName = "Amount"
          S = CStr(AUsers.UserAmount)
          .ValueStr = S
          .WriteINI(RWini_BZString)

          i = UserNo

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "Name"
          S = Trim(AUsers.Users(i).Name)
          'S = StrConv(S, VbStrConv.LinguisticCasing)
          If S = "" Then
            S = "User" & CStr(i)
          End If
          .ValueStr = S
          .WriteINI(RWini_BZString)

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "Pwd"
          S = AUsers.Users(i).Password
          S = EDS.En(S)
          .ValueStr = S
          .WriteINI(RWini_BZString)

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "PerLogin"
          .ValueStr = CStr(AUsers.Users(i).PerLogin)
          .WriteINI(RWini_BZString)

          .FileName = SPath
          .AppName = "User" & CStr(i)
          .KeyName = "SavePws"
          .ValueStr = CStr(AUsers.Users(i).SavePws)
          .WriteINI(RWini_BZString)

      End Select
    End With
  End Function
  Public Overloads Function RWUsersIni(ByVal RW As Boolean) As Boolean
    '读写全部用户信息
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    Dim i As Integer

    SPath = GetAppPath() & "\" & AppConfig_FilesName

    With PINI

      Select Case RW
        Case True ''''''''''''''''''''''''''''''''''''''''''''''''''''''读
          .FileName = SPath
          .AppName = "UserAmount"
          .KeyName = "Amount"
          S = .ReadINI(RWini_BZString)
          If S <> "" Then
            If IsNumeric(S) Then
              If CSng(S < 1) Then
                S = "1"
              End If
            Else
              S = "1"
            End If
          Else
            S = "1"
          End If
          AUsers.UserAmount = CSng(S)

          For i = 0 To AUsers.UserAmount

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "Name"
            S = .ReadINI(RWini_BZString)
            If S = "" Then
              AUsers.Users(i).Name = "User" & CStr(i)
            Else
              AUsers.Users(i).Name = S
            End If

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "Pwd"
            S = .ReadINI(RWini_BZString)
            S = EDS.De(S)
            AUsers.Users(i).ChangePassword(AUsers.Users(i).Password, S, S)

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "PerLogin"
            S = .ReadINI(RWini_BZString)
            If S = "" Then S = "0"
            AUsers.Users(i).PerLogin = CSng(S)

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "SavePws"
            S = .ReadINI(RWini_BZString)
            If S = "" Then S = "0"
            AUsers.Users(i).SavePws = CSng(S)

          Next i


        Case False ''''''''''''''''''''''''''''''''''''''''''''''''写
          .FileName = SPath
          .AppName = "UserAmount"
          .KeyName = "Amount"
          S = CStr(AUsers.UserAmount)
          .ValueStr = S
          .WriteINI(RWini_BZString)


          For i = 0 To AUsers.UserAmount

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "Name"
            S = Trim(AUsers.Users(i).Name)
            'S = StrConv(S, VbStrConv.LowerCase)
            If S = "" Then
              S = "User" & CStr(i)
            End If
            .ValueStr = S
            .WriteINI(RWini_BZString)

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "Pwd"
            S = AUsers.Users(i).Password
            S = EDS.En(S)
            .ValueStr = S
            .WriteINI(RWini_BZString)

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "PerLogin"
            .ValueStr = CStr(AUsers.Users(i).PerLogin)
            .WriteINI(RWini_BZString)

            .FileName = SPath
            .AppName = "User" & CStr(i)
            .KeyName = "SavePws"
            .ValueStr = CStr(AUsers.Users(i).SavePws)
            .WriteINI(RWini_BZString)

          Next i
      End Select
    End With

  End Function

  Public Structure GPRSCWSaveDateTime
    Public SaveDate As Date
    Public SaveTime As Date
  End Structure

  Public CWSaveDT As New GPRSCWSaveDateTime

  Public Function CreatAdoAccessCnnString(ByVal FilePath As String) As String
    CreatAdoAccessCnnString = _
        "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & FilePath
  End Function

  'Public Structure opgParsePath
  '  Public FILE_ONLY As Integer

  'End Structure
  '  Public Function ParsePath(ByVal strPath As String, _
  '  ByVal lngPart As opgParsePath) As String

  '    ' 本过程接受一个文件路径，然后根据传入的常量，
  '    ' 返回路径（除文件名以外的其它部分）、
  '    ' 驱动器号
  '    ' 或者文件扩展名。

  '    Dim lngPos As Long
  '    Dim strPart As String
  '    Dim blnIncludesFile As Boolean

  '    ' 检查输入的是否是一个文件路径。
  '    ' 查找最后一个分隔符。
  '    lngPos = InStrRev(strPath, "\")
  '    ' 判断最后一个反斜杠后面的字符串是否包含
  '    ' 句点。
  '    blnIncludesFile = InStrRev(strPath, ".") > lngPos

  '    If lngPos > 0 Then
  '      Select Case lngPart
  '        ' 返回文件名。
  '      Case opgParsePath.FILE_ONLY
  '          If blnIncludesFile Then
  '            strPart = Right$(strPath, Len(strPath) - lngPos)
  '          Else
  '            strPart = ""
  '          End If
  '          ' 返回路径。
  '        Case opgParsePath.PATH_ONLY
  '          If blnIncludesFile Then
  '            strPart = Left$(strPath, lngPos)
  '          Else
  '            strPart = strPath
  '          End If
  '          ' 返回驱动器号。
  '        Case opgParsePath.DRIVE_ONLY
  '          strPart = Left$(strPath, 3)
  '          ' 返回文件扩展名。
  '        Case opgParsePath.FILEEXT_ONLY
  '          If blnIncludesFile Then
  '            ' 取句点后的三个字符。
  '            strPart = Mid(strPath, InStrRev(strPath, ".") + 1, 3)
  '          Else
  '            strPart = ""
  '          End If
  '        Case Else
  '          strPart = ""
  '      End Select
  '    End If
  '    ParsePath = strPart

  'ParsePath_End:
  '    Exit Function
  '  End Function

  Public Function RWGprsWorkINI(ByVal INIFileName As String, ByVal ROrW As Boolean) As Boolean

    Dim i As Integer

    RWGprsWorkINI = False

    Dim SPath, tmpS, S As String

    With GprsWorkINI

      If INIFileName <> "" Then
        SPath = INIFileName
      Else
        SPath = GetAppPath() & "\Default." & Default_GprsWork_INIFilesName
      End If

      CW.GPRSWorkFilePath = SPath

      'i = INIFileName.LastIndexOf("\") '''''''''''''''''工程的工作路径，下一步ReadSettingsINI的参数
      'If i > 1 Then
      '  S = Mid(INIFileName, 1, i + 1)
      'Else
      '  S = GetAppPath() & "\" & CW.WorkName
      'End If
      'CW.WorkPath = S

      '((((((((((((((((((((((((((((((((((((((((((
      'If INIFileName <> "" Then
      '  SPath = INIFileName
      'Else
      '  SPath = CW.WorkPath & "\Default.hgs"
      'End If
      '))))))))))))))))))))))))))))))))))))))))))

      Select Case ROrW
        Case False ''''''''''''''''''''''''''''''''''''''保存工程
          Try
            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkName"
            .ValueStr = CW.WorkName
            .WriteINI(RWini_BZString)

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkPath"
            .ValueStr = "\工程一"
            .WriteINI(RWini_BZString)

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "MapAmount"
            .ValueStr = CW.MapAmount
            .WriteINI(RWini_BZString)
            RWGprsWorkINI = True
          Catch ex As Exception
            RWGprsWorkINI = False
          End Try


          '  For i = 1 To CW.MapAmount
          '    '''''''''''''''''''''''''''''''''''''保存每张地图的信息
          '    .FileName = SPath
          '    .AppName = "MAP" & CStr(i)
          '    .KeyName = "MapName"
          '    .ValueStr = CW.Maps(i).MapName
          '    .WriteINI(RWiniBZString)

          '    .FileName = SPath
          '    .AppName = "MAP" & CStr(i)
          '    .KeyName = "MapIndex"
          '    .ValueStr = CW.Maps(i).MapIndex
          '    .WriteINI(RWiniBZString)

          '    .FileName = SPath
          '    .AppName = "MAP" & CStr(i)
          '    .KeyName = "MapStationAmount"
          '    .ValueStr = CW.Maps(i).MapStationAmount
          '    .WriteINI(RWiniBZString)

          '    .FileName = SPath
          '    .AppName = "MAP" & CStr(i)
          '    .KeyName = "MapStationPlacedAmount"
          '    .ValueStr = CW.Maps(i).MapStationPlacedAmount
          '    .WriteINI(RWiniBZString)

          '    .FileName = SPath
          '    .AppName = "MAP" & CStr(i)
          '    .KeyName = "MapPath"
          '    .ValueStr = "\" & CW.WorkName & "\Maps\map" & CStr(i) & ".bmp"
          '    .WriteINI(RWiniBZString)

          '  Next i
          '  RWGprsWorkINI = True
          'Catch
          '  RWGprsWorkINI = False
          'End Try

        Case True     ''''''''''''''''''''''''''''''''''''读工程

          Try

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkName"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              CW.WorkName = tmpS
            Else
              CW.WorkName = "工程一"
            End If

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkPath"
            '.ValueStr = "\工程一"
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              If Left(tmpS, 1) <> "\" Then
                CW.WorkPath = tmpS
              Else
                CW.WorkPath = GetAppPath() & tmpS  '相对目录，是相对于程序运行的目录
              End If
            Else
              CW.WorkPath = GetAppPath() & "\工程一" '默认的
            End If
            ']20070220工作路径总是和INI文件一]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
            i = INIFileName.LastIndexOf("\")
            If i > 1 Then
              S = Mid(INIFileName, 1, i + 1)
            Else
              S = GetAppPath() & "\" & CW.WorkName
            End If
            CW.WorkPath = S
            '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "MapAmount"
            '.ValueStr = CW.MapAmount
            tmpS = CStr(.ReadINI(RWini_BZString))
            Try
              CW.MapAmount = CSng(tmpS) '到这里决定读取工程成功

              RWGprsWorkINI = True
            Catch ex As Exception
              CW.MapAmount = 0
            End Try

            RWTXini(True)

            '''''''''''''''''''''''''''''''20070207自动轮询相关
            'Dim RadioBtn_ATX_Times As Integer
            .FileName = SPath
            .AppName = "ATX"
            .KeyName = "RadioBtn_ATX_TimeN"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              If IsNumeric(tmpS) Then
                CW.RadioBtn_ATX_TimeN = CSng(tmpS)
              Else
                CW.RadioBtn_ATX_TimeN = 3
              End If
            Else
              CW.RadioBtn_ATX_TimeN = 3
            End If

            .FileName = SPath
            .AppName = "ATX"
            .KeyName = "RadioBtn_ATX_Time1"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              If IsNumeric(tmpS) Then
                CW.RadioBtn_ATX_Time1 = CSng(tmpS)
              Else
                CW.RadioBtn_ATX_Time1 = 10
              End If
            Else
              CW.RadioBtn_ATX_Time1 = 10
            End If

            .FileName = SPath
            .AppName = "ATX"
            .KeyName = "RadioBtn_ATX_Time2"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              If IsNumeric(tmpS) Then
                CW.RadioBtn_ATX_Time2 = CSng(tmpS)
              Else
                CW.RadioBtn_ATX_Time2 = 30
              End If
            Else
              CW.RadioBtn_ATX_Time2 = 30
            End If

            .FileName = SPath
            .AppName = "ATX"
            .KeyName = "RadioBtn_ATX_Time3"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              If IsNumeric(tmpS) Then
                CW.RadioBtn_ATX_Time3 = CSng(tmpS)
              Else
                CW.RadioBtn_ATX_Time3 = 60
              End If
            Else
              CW.RadioBtn_ATX_Time3 = 60
            End If

            .FileName = SPath
            .AppName = "ATX"
            .KeyName = "Label_ATX_Note"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            CW.Label_ATX_Note = tmpS
            'For i = 1 To CW.MapAmount '''''''''''''''''''读每张地图的信息,20050423放到数据库里了

            '  .FileName = SPath
            '  .AppName = "MAP" & CStr(i)
            '  .KeyName = "MapName"
            '  '.ValueStr = CW.Maps(i).MapName
            '  tmpS = CStr(.ReadINI(RWiniBZString))
            '  If tmpS <> "" Then
            '    CW.Maps(i).MapName = tmpS
            '  Else
            '    CW.Maps(i).MapName = "地图" & CStr(i)
            '  End If

            '  .FileName = SPath
            '  .AppName = "MAP" & CStr(i)
            '  .KeyName = "MapIndex"
            '  '.ValueStr = CW.Maps(i).MapIndex
            '  tmpS = CStr(.ReadINI(RWiniBZString))
            '  Try
            '    CW.Maps(i).MapIndex = CSng(tmpS)
            '  Catch
            '    CW.Maps(i).MapIndex = i
            '  End Try

            '  .FileName = SPath
            '  .AppName = "MAP" & CStr(i)
            '  .KeyName = "MapStationAmount"
            '  '.ValueStr = CW.Maps(i).MapStationAmount
            '  tmpS = CStr(.ReadINI(RWiniBZString))
            '  Try
            '    CW.Maps(i).MapStationAmount = CSng(tmpS)
            '  Catch
            '    CW.Maps(i).MapStationAmount = 100
            '  End Try

            '  .FileName = SPath
            '  .AppName = "MAP" & CStr(i)
            '  .KeyName = "MapStationPlacedAmount"
            '  '.ValueStr = CW.Maps(i).MapStationPlacedAmount
            '  tmpS = CStr(.ReadINI(RWiniBZString))
            '  Try
            '    CW.Maps(i).MapStationPlacedAmount = CSng(tmpS)
            '    CW.Maps(i).Initializing()
            '  Catch
            '    CW.Maps(i).MapStationPlacedAmount = 0
            '  End Try

            '  .FileName = SPath
            '  .AppName = "MAP" & CStr(i)
            '  .KeyName = "MapPath"
            '  '.ValueStr = "\Maps\map" & CStr(i) & ".bmp"
            '  tmpS = CStr(.ReadINI(RWiniBZString))
            '  If tmpS <> "" Then
            '    If Left(tmpS, 1) <> "\" Then
            '      CW.Maps(i).MapPath = tmpS
            '    Else
            '      tmpS1 = CW.WorkPath
            '      tmpS1 = tmpS1 & tmpS
            '      ''(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
            '      'tmpS1 = GetAppPath() & "\" & "工程一" & "\maps\map" & CStr(i) & ".bmp"
            '      '')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
            '      CW.Maps(i).MapPath = tmpS1
            '    End If
            '  Else
            '    CW.Maps(i).MapPath = GetAppPath() & "\" & "工程一" & "\maps\map" & CStr(i) & ".bmp"
            '  End If

            'Next i

          Catch
            RWGprsWorkINI = False
          End Try

      End Select

    End With
  End Function

  Public Function RWTXini(ByVal RW As Boolean) As String
    '由于其他新增的参数值直接赋给主窗体的Checkbox，所以放在主窗体的SetWorkAll()过程中了。
    Dim PINI As New GprsRWini
    With PINI
      Dim SPath, S As String
      RWTXini = ""
      If CW.GPRSWorkFilePath <> "" Then
        SPath = CW.GPRSWorkFilePath
      Else
        SPath = CW.WorkPath & "\Default." & Default_GprsWork_INIFilesName
      End If

      Select Case RW
        Case True

          .FileName = SPath
          .AppName = "TX"
          .KeyName = "SrvPort"
          S = .ReadINI(RWini_BZString)
          Try
            SrvPort = CSng(S)
            If SrvPort < 5000 Then
              SrvPort = 5000
            ElseIf SrvPort > 5500 Then
              SrvPort = 5500
            End If
          Catch ex As Exception
            SrvPort = 5001
          End Try

          .FileName = SPath
          .AppName = "TX"
          .KeyName = "ListenTimeLong"
          S = .ReadINI(RWini_BZString)
          Try
            ListenTimeLong = CSng(S)
            If ListenTimeLong < 200 Then
              ListenTimeLong = 200
            ElseIf ListenTimeLong > 500 Then
              ListenTimeLong = 500
            End If
          Catch ex As Exception
            ListenTimeLong = 200
          End Try

          .FileName = SPath
          .AppName = "TX"
          .KeyName = "SysAutoM"
          S = .ReadINI(RWini_BZString)
          Try
            SysAutoM = CSng(S)
          Catch ex As Exception
            SysAutoM = 0
          End Try


        Case False

          .FileName = SPath
          .AppName = "TX"
          .KeyName = "SrvPort"
          .ValueStr = CStr(SrvPort)
          .WriteINI(RWini_BZString)

          .FileName = SPath
          .AppName = "TX"
          .KeyName = "ListenTimeLong"
          .ValueStr = CStr(ListenTimeLong)
          .WriteINI(RWini_BZString)

          .FileName = SPath
          .AppName = "TX"
          .KeyName = "SysAutoM"
          .ValueStr = CStr(SysAutoM)
          .WriteINI(RWini_BZString)

      End Select
    End With
  End Function

  Public Function SetPM(ByVal RW As Boolean) As String
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    SetPM = ""
    SPath = GetAppPath() & "\" & AppConfig_FilesName

    With PINI

      Select Case RW
        Case True
          .FileName = SPath
          .AppName = "PM"
          .KeyName = "VerMode"
          S = .ReadINI(RWini_BZString)
          If S <> "" Then
            PM.VerMode = S
          Else
            PM.VerMode = "Public"
          End If

          .FileName = SPath
          .AppName = "PM"
          .KeyName = "Name"
          S = .ReadINI(RWini_BZString)
          If S <> "" Then
            PM.Name = S
          Else
            PM.Name = PMs_Name
          End If


        Case False
          .FileName = SPath
          .AppName = "PM"
          .KeyName = "VerMode"
          .ValueStr = PM.VerMode
          .WriteINI(RWini_BZString)

          .FileName = SPath
          .AppName = "PM"
          .KeyName = "Name"
          .ValueStr = PM.Name
          .WriteINI(RWini_BZString)
      End Select
    End With

  End Function

  Public Class GPRSWorkPrint
    Public MapNo As Short
    Public StationNo As Short
    Public StationNoStart As Short
    Public StationNoStop As Short
    Public MulitStationPrint As Boolean
    Sub New()
      MapNo = 1
      StationNo = 1
      StationNoStart = 1

      'StationNoStop = CW.Maps(MapNo).MapStationPlacedAmount
      MulitStationPrint = False
    End Sub
  End Class

  Public Sub SetGPRSWork(ByVal F As Form)
    Dim i As Short
    Dim S As String

    If CW.Active = False Then
      'CW.MapAmount = 2 '这里就已经激活GPRSMap对象
      If CW.WorkName = "" Then
        CW.WorkName = "工程一"
      End If

      S = CW.WorkPath
      If S = "" Then
        CW.WorkPath = GetAppPath() & "\" & CW.WorkName
      End If

      If IsNumeric(CW.MapAmount) Then
        If CW.MapAmount > 0 Then
          For i = 1 To CW.MapAmount
            S = CW.Maps(i).MapPath
            If S = "" Then
              CW.Maps(i).MapPath = CW.WorkPath & "\maps\map" & CStr(i) & ".bmp"
            End If
            S = CW.Maps(i).MapName
            If S = "" Then
              CW.Maps(i).MapName = "地图" & CStr(i)
            End If
            'CW.Maps(i).MapStationAmount = 100
          Next i
          CW.MapNo = 1
        Else
        End If
      Else
      End If

      'CW.Maps(1).MapName = "道里区"
      'CW.Maps(2).MapName = "道外区"
      F.Text = PM.Name & "  " & CW.WorkName
      CW.Active = True

    End If

  End Sub

  Public Function StrToHexStr(ByVal src() As Byte, ByVal ln As Integer) As Boolean
    Dim i As Integer
    Dim st As String = ""
    Dim temp As Integer

    For i = 0 To ln - 1
      temp = src(i) \ 16
      If temp > 9 Then
        temp = temp + 55
      Else
        temp = temp + 48
      End If
      st = st & Chr(temp)

      temp = src(i) Mod 16
      If temp > 9 Then
        temp = temp + 55
      Else
        temp = temp + 48
      End If
      st = st & Chr(temp)

      st = st & " "
    Next
    StrToHexStr = st
  End Function
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  Public Class GPRSImagesResource '记录站点不同状态所应用的Gif图片路径的类，以后可扩展为多方面应用
    Private pGifFilePath_OK As String
    Private pGifFilePath_Alarm As String
    Private pGifServiceStart As String
    Private pGifNoLooked As String
    Public GifMSendStart As String
    Public GifAsend As String
    Public GifMsendStop As String
    Public GifOnLine As String
    Public Cur(10) As Cursor
    Private pEaglEyeRedDot As String
    'Public EaglEyeRedDot As String

    Property EaglEyeRedDot() As String
      Get
        Return pEaglEyeRedDot
      End Get
      Set(ByVal Value As String)
        pEaglEyeRedDot = Value
      End Set
    End Property
    'Sub New()
    '  EaglEyeRedDot = New AxAniGIFCtrl.AxAniGIF
    '  Try
    '    EaglEyeRedDot.ReadGIF(GetAppPath() & "\Resource\EaglEyeRedDot.gif")
    '  Catch ex As Exception

    '  End Try

    'End Sub
    Property GifNoLooked() As String
      Get
        Return pGifNoLooked
      End Get
      Set(ByVal Value As String)
        pGifNoLooked = Value
      End Set
    End Property

    Property GifServiceStart() As String
      Get
        Return pGifServiceStart
      End Get
      Set(ByVal Value As String)
        pGifServiceStart = Value
      End Set
    End Property
    Property GifFilePath_OK() As String
      Get
        Return pGifFilePath_OK
      End Get
      Set(ByVal Value As String)
        pGifFilePath_OK = Value
      End Set
    End Property

    Property GifFilePath_Alarm() As String
      Get
        Return pGifFilePath_Alarm
      End Get
      Set(ByVal Value As String)
        pGifFilePath_Alarm = Value
      End Set
    End Property

  End Class
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

  Public Function CheckStringIP(ByVal SIP As String) As String
    '检测输入的字符串是否是合法的IP格式
    CheckStringIP = SIP
  End Function

  'Public Function GetAppPath() As String
  '    'GetAppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
  '    'GetAppPath = Application.StartupPath
  '    'GetAppPath = Application.ExecutablePath()
  '    'GetAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
  '    If Len(Application.StartupPath) > 3 Then
  '        GetAppPath = Application.StartupPath & "\"
  '    Else
  '        GetAppPath = Application.StartupPath
  '    End If
  'End Function

  Function GetEmbeddedResource(ByVal strName As String) As System.IO.Stream
    '在应用程序里嵌入资源，可以避免用户因删除资源文件而造成应用程序出现错误。要使用资源文件中的文件，只需要按下面的方法调用即可：
    Return System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strName)
  End Function
  'Public SP(STATION_MAX_NO) As AxAniGIFCtrl.AxAniGIF  '地图上站点控件数组

  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  'EZ_Crypt.vb(字符串加密和解密类)
  Public Class GprsCrypt
    'Public mCSP As SymmetricAlgorithm
    Public mCSP As New DESCryptoServiceProvider
    Private Key As String
    Private KeyIV As String
    Dim i, j As Integer
    Public MyPA As New PDSA.PDSACryptography.PDSASymmetric(PDSA.PDSACryptography.PDSASymmetric.PDSAEncryptionType.DES)
    Sub New()
      Dim RWini As New GprsRWini
      RWini.FileName = GetAppPath() & "\" & AppConfig_FilesName
      With RWini
        .AppName = "Fft"
        .KeyName = "Jhu"
        '.ValueStr = MyPA.KeyString
        Key = .ReadINI(RWini_BZString)

        .AppName = "Fft"
        .KeyName = "Xzz"
        '.ValueStr = MyPA.IVString
        '.WriteINI(RWiniBZString)
        KeyIV = .ReadINI(RWini_BZString)
      End With
      Try
        If Key = "" Then
          MyPA.KeyString = PA_Key
        Else
          MyPA.KeyString = Key
        End If
        If KeyIV = "" Then
          MyPA.IVString = PA_KeyIV
        Else
          MyPA.IVString = KeyIV
        End If
      Catch ex As Exception
      End Try

    End Sub
    Public Function En(ByVal MyS As String) As String
      En = ""
      'Dim RWini As New GprsRWini
      'RWini.FileName = GetAppPath() & "\" & AppConfigFilesName
      'With RWini
      '  .AppName = "Md5"
      '  .KeyName = "Key"
      '  .ValueStr = MyPA.KeyString
      '  .WriteINI(RWiniBZString)

      '  .AppName = "Md5"
      '  .KeyName = "IV"
      '  .ValueStr = MyPA.IVString
      '  .WriteINI(RWiniBZString)

      'End With
      'MyPA.KeyString = Key
      'MyPA.IVString = KeyIV
      Try
        En = MyPA.Encrypt(MyS)
      Catch ex As Exception

      End Try

    End Function
    Public Function De(ByVal YouS As String) As String
      De = ""
      'MyPA.KeyString = Key
      'MyPA.IVString = KeyIV
      Try
        De = MyPA.Decrypt(YouS)
      Catch ex As Exception

      End Try

    End Function

    Public Function EnMD5(ByVal TextToHash As String) As String
      Dim md5 As MD5CryptoServiceProvider
      Dim bytValue() As Byte
      Dim bytHash() As Byte

      ' 创建新的加密服务提供程序对象
      md5 = New MD5CryptoServiceProvider

      ' 将原始字符串转换成字节数组
      bytValue = System.Text.Encoding. _
       UTF8.GetBytes(TextToHash)

      ' 计算散列，并返回一个字节数组
      bytHash = md5.ComputeHash(bytValue)

      md5.Clear()

      ' 返回散列值的 Base64 编码字符串
      'Debug.WriteLine(Convert.ToBase64String(bytHash))
      EnMD5 = Convert.ToBase64String(bytHash)
    End Function

  End Class

  Public Function GetAppPath() As String
    'GetAppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
    'GetAppPath = Application.StartupPath
    'GetAppPath = Application.ExecutablePath()
    'GetAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
    If Len(Application.StartupPath) > 3 Then
      '路径的最后一个字符总不是 \ ，是为了检测程序中的路径是不是相对路径，如果第一个字符是 \ 就说明是相对路径
      GetAppPath = Application.StartupPath
    Else
      GetAppPath = Left(Application.StartupPath, 2)
    End If
  End Function

  Public Function byteToHexStr(ByVal src() As Byte, ByVal Len As Int16) As String
    Dim i As Int16
    Dim result As String = ""
    Dim temp As Int16
    For i = 0 To Len - 1
      temp = src(i) \ 16
      If temp > 9 Then
        temp = temp + 55
      Else
        temp = temp + 48
      End If
      result = result & Chr(temp)

      temp = src(i) Mod 16
      If temp > 9 Then
        temp = temp + 55
      Else
        temp = temp + 48
      End If
      result = result & Chr(temp)
      result = result & " "
    Next i
    result = result.Trim
    Return result
  End Function

End Module
