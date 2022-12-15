
Public Class GPRSWork
#Region "20070202后添加的"
  'Public Enum ATX
  'End Enum

  Public bMsendRevHaveData As Boolean = False  ''提示存盘用
  Public bForm7SaveDB_Runing As Boolean = False
  Public bForm10FlexTChart_runing As Boolean = False

  Public FlexGridMain_ColsCount_Basic As Integer = 4
  Public Max_ParameterAmount As Integer = 6

  Public ColorAlarm As New MyClassTempAlarm

  Public TChartSeriesType As Integer = TeeChart.ESeriesClass.scLine

  Public RadioBtn_ATX_TimeN As Integer = 0
  Public RadioBtn_ATX_Time1 As Integer = 0
  Public RadioBtn_ATX_Time2 As Integer = 0
  Public RadioBtn_ATX_Time3 As Integer = 0
  Public Label_ATX_Note As String = ""

  Public ATX_Runing As Boolean = False ''''是否开始了自动轮询
  Public ATX_MAbort As Boolean = False '''''''手动终止

  Public ATX_StartRunTime_OLD As Date ''''''''记录正在通讯的时间点
  Public ATX_StartRunTime_Next As Date
  Public ATX_StartRunTime_First As Date ''''''''''''设置开始时间，还没用上
  Public ATX_StartRunTime_First_RunED As Boolean = False '''''''''是为了计算整点开始时间用
  Public bAsendED As Boolean = False
#End Region


  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

  Public Maps(MAP_MAX_NO) As GPRSMap
  Public Active As Boolean
  Public CWHostID As String
  Private pWorkName As String '当前工程名称
  '------------------------------------------------------------------------------
  Private pMapAmount As Short '共有多少张地图
  'Private i As Short
  '------------------------------------------------------------------------------
  Private pMapNo As Short   '当前地图编号
  Private pWorkPath As String '工程工作目录
  Private pGPRSWorkFilePath As String '工程文件路径
  'Public Const GprsWorkMdbFileName As String = "GPRSMdb.mdb" '总是在工程的工作目录里,在tool模块里
  Private i, j, k As Integer
  ''------------------------------------------------------------------------------
  'Private pMapStationNo As Short '当前站点编号，站点隶属于地图

  ''------------------------------------------------------------------------------
  'Private pMapStationPropertyNo As Short  '当前站点属性编号，隶属于站点

  Sub New()
    pWorkName = "工程一"
    CWHostID = Host_ID
  End Sub
  Public Property GPRSWorkFilePath() As String
    Get
      Return pGPRSWorkFilePath
    End Get
    Set(ByVal Value As String)
      pGPRSWorkFilePath = Value
    End Set
  End Property
  Public Function AddMap() As Boolean
    If pMapAmount < MAP_MAX_NO Then
      pMapAmount = pMapAmount + 1
      Maps(pMapAmount) = New GPRSMap
      Maps(pMapAmount).MapIndex = pMapAmount
      AddMap = True
    Else
      AddMap = False
    End If
  End Function

  Public Function DelMap(ByVal DelNo As Short) As Boolean
    Dim i As Integer

    If DelNo < pMapAmount And DelNo > 0 Then
      Maps(i) = New GPRSMap
      For i = DelNo To pMapAmount - 1
        Maps(i) = Maps(i + 1)
        Maps(i).MapIndex = i
      Next
      pMapAmount = pMapAmount - 1
      DelMap = True
    ElseIf DelNo = pMapAmount Then
      Maps(i) = New GPRSMap
      pMapAmount = pMapAmount - 1
      DelMap = True
    Else
      DelMap = False
    End If
  End Function

  Public Property WorkPath() As String
    Get
      Return (pWorkPath)
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        pWorkPath = Value
      End If
    End Set
  End Property

  Public Property MapNo() As Short
    Get
      Return pMapNo
    End Get
    Set(ByVal Value As Short)
      If Value > 0 And Value <= MAP_MAX_NO Then
        pMapNo = Value
      Else
        pMapNo = 0
      End If
    End Set
  End Property
  Public Property WorkName() As String
    Get
      Return (pWorkName)
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        pWorkName = Value
      End If
    End Set
  End Property

  Public Property MapAmount() As Short
    Get
      Return pMapAmount
    End Get
    Set(ByVal Value As Short)
      If Value > 0 And Value <= MAP_MAX_NO Then
        j = pMapAmount
        pMapAmount = Value
        If pMapAmount > j Then
          For i = j + 1 To pMapAmount
            Maps(i) = New GPRSMap
          Next i
        End If
        'Else
        '  pMapAmount = 0
      End If
    End Set
  End Property

End Class
'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

<Serializable()> Public Class GPRSMap
  Private i, j, k As Integer
  Public Stations(STATION_MAX_NO) As GPRStation
  Public SameFromMDB As Boolean '是否已存入或读出站点信息
  Private pMapName As String  '地图名称 MI(1,1,0,0,0)
  Private pMapPath As String '地图文件路径 MI(1,2,0,0,0)
  Private pMapSize As Point '地图实际像素大小，XY代表长宽
  Private pMapStationAmount As Short '地图设计包含站点数量
  Private pMapStationPlacedAmount As Short '地图实际已放置站点数量
  Private pPerShowStationNo As Short '上一次TabShowStation时显示的站点索引
  Private pMapIndex As Short '地图在项目中的索引,从1开始数

  Property MapIndex() As Short
    Get
      Return pMapIndex
    End Get
    Set(ByVal Value As Short)
      pMapIndex = Value
    End Set
  End Property
  Sub New()
    pMapStationPlacedAmount = 0
    pPerShowStationNo = 1
    SameFromMDB = False
  End Sub
  Property PerShowStationNo() As Short
    Get
      Return pPerShowStationNo
    End Get
    Set(ByVal Value As Short)
      If Value < pMapStationPlacedAmount Then
        pPerShowStationNo = Value
      Else
        pPerShowStationNo = pMapStationPlacedAmount
      End If
    End Set
  End Property
  Public Function DelStation(ByVal DelNo As Short) As Boolean
    Dim i As Integer
    If DelNo < pMapStationPlacedAmount And DelNo > 0 Then
      Stations(DelNo).StationGif.Tag = ""
      Stations(DelNo).StationGif.Dispose()
      'Stations(DelNo).StationGif.Visible = False
      'Stations(DelNo).ToolTap = False
      Stations(DelNo).pLabelToolTip.Dispose()
      Stations(DelNo) = Nothing
      For i = DelNo To pMapStationPlacedAmount - 1
        Stations(i) = Stations(i + 1)
        Stations(i).StationIndex = i
        Stations(i).StationGif.Tag = CStr(i)
      Next i
      pMapStationPlacedAmount = pMapStationPlacedAmount - 1
      DelStation = True
    ElseIf DelNo = pMapStationPlacedAmount Then
      'Stations(pMapStationPlacedAmount).StationGif.Visible = False
      Stations(pMapStationPlacedAmount).StationGif.Dispose()
      Stations(pMapStationPlacedAmount).pLabelToolTip.Dispose()
      Stations(pMapStationPlacedAmount) = Nothing
      pMapStationPlacedAmount = pMapStationPlacedAmount - 1
      DelStation = True
    Else
      DelStation = False
    End If
  End Function
  Public Function AddStation() As Boolean
    If pMapStationPlacedAmount < pMapStationAmount Then
      pMapStationPlacedAmount = pMapStationPlacedAmount + 1
      Stations(pMapStationPlacedAmount) = New GPRStation
      Stations(pMapStationPlacedAmount).StationIndex = pMapStationPlacedAmount
      Stations(pMapStationPlacedAmount).StationGif.Tag = CStr(pMapStationPlacedAmount)
      AddStation = True
    Else
      AddStation = False
    End If
  End Function
  Property MapStationPlacedAmount() As Short
    Get
      Return pMapStationPlacedAmount
    End Get
    Set(ByVal Value As Short)
      If Value > 0 And Value <= pMapStationAmount Then
        pMapStationPlacedAmount = Value
      End If
    End Set
  End Property

  Public Sub Initializing()
    '读取了数据库中的MapStationPlacedAmount，好实例化站点
    Dim i As Integer
    If pMapStationPlacedAmount > 0 Then
      For i = 1 To pMapStationPlacedAmount
        Stations(i) = New GPRStation
      Next i
    End If
  End Sub

  Property MapStationAmount() As Short
    Get
      Return pMapStationAmount
    End Get
    Set(ByVal Value As Short)
      If Value > 0 And Value <= STATION_MAX_NO Then
        pMapStationAmount = Value
        If pMapStationAmount > pMapStationPlacedAmount Then
          For i = pMapStationAmount To pMapStationPlacedAmount
            Stations(i) = New GPRStation
          Next i
        End If
      Else
        pMapStationAmount = 0
      End If
    End Set
  End Property

  Property MapSize() As Point
    Get
      Return pMapSize
    End Get
    Set(ByVal Value As Point)
      pMapSize = Value
    End Set
  End Property
  Property MapPath() As String
    Get
      Return pMapPath
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        pMapPath = Value
      End If
    End Set
  End Property

  Property MapName() As String
    Get
      Return pMapName
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        pMapName = Value
      End If
    End Set
  End Property
End Class
'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
<Serializable()> Public Class GPRStation

  Public SendMessageValue() As String  '20080106

  Private i, j, k As Integer
  Private pStationModeIndex As Short '站点型号索引
  Private pStationIndex As Short  '站点在地图中的索引，从1开始数
  Public StationGif As AxAniGIFCtrl.AxAniGIF
  Private pStationName As String 'StationName
  'Private SID As String 'StationID '放到类里面了
  'Private SIP As String 'StationIP
  Private pStationLocation As Point 'StationLocation  X,Y值代表在1000000份中的比例
  'pMapStationY
  Private pTestDate As String  'TestDate200505030139改为字符型数据，subnew中赋为空字符串
  Private pTestTime As String  'TestTime
  Private pActive As Boolean '站点是否激活
  Private pStationParameterAmount As Short '本站点有多少个参数，少于等于STATION_PROPERTY_MAX_NO
  'Private pStationAlarm As Boolean

  'pMapStationPropertyAmount  --->STATION_INFO_NO=8public
  '------------------------------------------------------------------------------
  '数组中0为参数名称，1为参数数值，2单位，3为报警线
  Private pStationParameters(STATION_PROPERTY_MAX_NO, 3) As String
  Public pLabelToolTip As Label '鼠标经过站点时的提示
  Public ModemInfo As GPRSModemInfo
  Private pStationID As String '通讯数据结构中的ID，防止万一与ModemID不相同
  'Private pAlarmRun As Boolean  '是否已有报警的参数了
  Private pAlarm As Boolean '报警了吗？
  Private pSaved As Boolean '是否已存入数据库
  Private pStationAddress As String  '站点的街道地址
  Private pDBed As Boolean '是否是数据库中的数据
  Private pRevNewData As Boolean '是否接收到新数据
  Private pLookedRevNewData As Boolean '新数据是否察看过
  Private pHaveData As Boolean '站点是否有数据

  Public Sub SendMessageHowMany(ByVal HowMany As Integer)
    If HowMany > 0 Then
      ReDim SendMessageValue(HowMany)
    End If
  End Sub

  Sub New()
    StationGif = New AxAniGIFCtrl.AxAniGIF
    'StationGif.ReadGIF(StationGifAlarm(0))
    pLabelToolTip = New Label
    pLabelToolTip.Text = ""
    pLabelToolTip.BackColor = System.Drawing.Color.LightGoldenrodYellow
    'pLabelToolTip.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    pLabelToolTip.AutoSize = True
    pLabelToolTip.BorderStyle = BorderStyle.FixedSingle
    pLabelToolTip.Visible = False

    pStationModeIndex = 1
    pStationParameterAmount = STATION_PROPERTY_MAX_NO '这句将来再处理
    pStationName = ""
    pSaved = False
    pStationLocation.X = -1 '负数表示还没有坐标
    pStationLocation.Y = -1
    ModemInfo = New GPRSModemInfo
    pTestDate = ""
    pTestTime = ""
    pDBed = False
    pRevNewData = False
    pLookedRevNewData = False
    pHaveData = False

  End Sub

  Property DBed() As Boolean
    Get
      Return pDBed
    End Get
    Set(ByVal Value As Boolean)
      pDBed = Value
    End Set
  End Property

  Property RevNewData() As Boolean
    Get
      Return pRevNewData
    End Get
    Set(ByVal Value As Boolean)
      pRevNewData = Value
    End Set
  End Property

  Property LookedRevNewData() As Boolean
    Get
      Return pLookedRevNewData
    End Get
    Set(ByVal Value As Boolean)
      pLookedRevNewData = Value
      If pHaveData Then
        If pLookedRevNewData = False Then
          'If pHaveData Then
          StationGif.ReadGIF(SGif.GifNoLooked)
          'End If
        Else
          If pAlarm Then
            StationGif.ReadGIF(SGif.GifFilePath_Alarm)
          Else
            StationGif.ReadGIF(SGif.GifFilePath_OK)
          End If
        End If
      End If
    End Set
  End Property

  Property HaveData() As Boolean
    Get
      Return pHaveData
    End Get
    Set(ByVal Value As Boolean)
      pHaveData = Value
    End Set
  End Property

  Property StationAddress() As String
    Get
      Return pStationAddress
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        pStationAddress = Value
      End If
    End Set
  End Property

  Property Saved() As Boolean
    Get
      Return pSaved
    End Get
    Set(ByVal Value As Boolean)
      pSaved = Value
    End Set
  End Property
  ReadOnly Property Alarm() As Boolean
    Get
      Return pAlarm
    End Get
  End Property

  Property Location() As Point
    Get
      Return StationGif.Location
    End Get
    Set(ByVal Value As Point)
      StationGif.Location = Value
      pLabelToolTip.Location = New Point(StationGif.Left + PLACE_STATION_OFFSET * 2 + 5, StationGif.Top)
    End Set
  End Property
  Property ToolTap() As Boolean
    Get
      Return pLabelToolTip.Visible
    End Get
    Set(ByVal Value As Boolean)
      pLabelToolTip.Location = New Point(StationGif.Left + PLACE_STATION_OFFSET * 2 + 5, StationGif.Top)
      pLabelToolTip.Visible = Value
      pLabelToolTip.BringToFront()
    End Set
  End Property
  Property StationIndex() As Short
    Get
      Return pStationIndex
    End Get
    Set(ByVal Value As Short)
      pStationIndex = Value
      If pStationName = "" Then
        pLabelToolTip.Text = CStr(pStationIndex) & "："
      Else
        pLabelToolTip.Text = (CStr(pStationIndex) & "：" & pStationName)
      End If
    End Set
  End Property

  Property StationParameters(ByVal SNo As Short, ByVal PIndex As Short) As String
    Get
      Return pStationParameters(SNo, PIndex)
    End Get
    Set(ByVal Value As String)
      'If Trim(Value) <> "" Then
      pStationParameters(SNo, PIndex) = Value
      If PIndex = 1 Or PIndex = 3 Then
        pAlarm = False
        For i = 1 To pStationParameterAmount
          If IsNumeric(pStationParameters(i, 1)) And IsNumeric(pStationParameters(i, 3)) Then
            If CSng(pStationParameters(i, 1)) > CSng(pStationParameters(i, 3)) Then
              pAlarm = True
              StationGif.ReadGIF(SGif.GifFilePath_Alarm)
              Exit For
            End If
          End If
        Next i
        If pAlarm = False Then
          StationGif.ReadGIF(SGif.GifFilePath_OK)
        End If
      End If

    End Set
  End Property

  Property StationParameterAmount() As Short
    Get
      Return pStationParameterAmount
    End Get
    Set(ByVal Value As Short)
      If Value > 0 And Value <= STATION_PROPERTY_MAX_NO Then
        pStationParameterAmount = Value
      End If
    End Set
  End Property

  Property Active() As Boolean
    Get
      Return pActive
    End Get
    Set(ByVal Value As Boolean)
      pActive = Value
      Try
        StationGif.Playing = pActive
        StationGif.Frame = 0
      Catch ex As Exception

      End Try

    End Set
  End Property
  Property StationModeIndex() As Short
    Get
      Return pStationModeIndex
    End Get
    Set(ByVal Value As Short)
      pStationModeIndex = Value
    End Set
  End Property
  Property StationName() As String
    Get
      Return pStationName
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        pStationName = Value
        pLabelToolTip.Text = (CStr(pStationIndex) & "：" & pStationName)
      Else
        pLabelToolTip.Text = CStr(pStationIndex) & "："
      End If
    End Set
  End Property

  'Property StationID() As String
  '  Get
  '    Return SID
  '  End Get
  '  Set(ByVal Value As String)
  '    SID = CStr(Value)
  '  End Set
  'End Property

  'Property StationIP() As String
  '  Get
  '    Return StationIP
  '  End Get
  '  Set(ByVal Value As String)
  '    SIP = Value
  '  End Set
  'End Property

  Property StationLocation() As Point
    Get
      Return pStationLocation
    End Get
    Set(ByVal Value As Point)
      pStationLocation = Value
    End Set
  End Property

  Property TestDate() As String
    Get
      Return pTestDate
    End Get
    Set(ByVal Value As String)
      pTestDate = Value
    End Set
  End Property

  Property TestTime() As String
    Get
      Return pTestTime
    End Get
    Set(ByVal Value As String)
      pTestTime = Value
    End Set
  End Property
  Property StationID() As String
    Get
      Return pStationID
    End Get
    Set(ByVal Value As String)
      If Trim(Value) <> "" Then
        If IsNumeric(Value) Then
          pStationID = Value
        End If
      End If
    End Set
  End Property
End Class
'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Public Class GPRSModemInfo
  Public ID As String                          'Modem模块的ID号
  Public PhoneNo As String               'Modem的11位电话号码
  Public DynIP(3) As Integer                       'Modem的4位动态ip地址
  Public IP As String

  'Public M_Conn_Time As Long                        'Modem模块最后一次建立TCP连接的时间
  'Public M_Refresh_Time As Long                     '接收到的数据包长度
End Class

#Region "温度高低信息类MyClassTempAlarm"
Public Class MyClassTempAlarm
  Public TempHighLine, TempLowLine As Double
  Public TempHighLineArray() As Double
  Public TempLowLineArray() As Double
  Public ColorStandard As System.Drawing.Color
  Public ColorHigher As System.Drawing.Color
  Public ColorLower As System.Drawing.Color
  Public ColorAtmosphere As System.Drawing.Color

  Sub New()
    Dim i As Integer
    ReDim TempHighLineArray(23)
    ReDim TempLowLineArray(23)

    For i = 0 To 23
      TempHighLineArray(i) = 22
      If i <= 5 Then
        TempLowLineArray(i) = 16
      ElseIf i > 21 Then
        TempLowLineArray(i) = 16
      Else
        TempLowLineArray(i) = 18
      End If
    Next i

    TempHighLine = 23
    TempLowLine = 19
    ColorStandard = System.Drawing.Color.PaleGreen
    ColorHigher = System.Drawing.Color.LightSkyBlue
    ColorLower = System.Drawing.Color.Pink
    ColorAtmosphere = System.Drawing.Color.Azure
  End Sub
End Class
#End Region

