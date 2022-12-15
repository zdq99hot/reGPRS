
Public Class GPRSWork
#Region "20070202����ӵ�"
  'Public Enum ATX
  'End Enum

  Public bMsendRevHaveData As Boolean = False  ''��ʾ������
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

  Public ATX_Runing As Boolean = False ''''�Ƿ�ʼ���Զ���ѯ
  Public ATX_MAbort As Boolean = False '''''''�ֶ���ֹ

  Public ATX_StartRunTime_OLD As Date ''''''''��¼����ͨѶ��ʱ���
  Public ATX_StartRunTime_Next As Date
  Public ATX_StartRunTime_First As Date ''''''''''''���ÿ�ʼʱ�䣬��û����
  Public ATX_StartRunTime_First_RunED As Boolean = False '''''''''��Ϊ�˼������㿪ʼʱ����
  Public bAsendED As Boolean = False
#End Region


  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

  Public Maps(MAP_MAX_NO) As GPRSMap
  Public Active As Boolean
  Public CWHostID As String
  Private pWorkName As String '��ǰ��������
  '------------------------------------------------------------------------------
  Private pMapAmount As Short '���ж����ŵ�ͼ
  'Private i As Short
  '------------------------------------------------------------------------------
  Private pMapNo As Short   '��ǰ��ͼ���
  Private pWorkPath As String '���̹���Ŀ¼
  Private pGPRSWorkFilePath As String '�����ļ�·��
  'Public Const GprsWorkMdbFileName As String = "GPRSMdb.mdb" '�����ڹ��̵Ĺ���Ŀ¼��,��toolģ����
  Private i, j, k As Integer
  ''------------------------------------------------------------------------------
  'Private pMapStationNo As Short '��ǰվ���ţ�վ�������ڵ�ͼ

  ''------------------------------------------------------------------------------
  'Private pMapStationPropertyNo As Short  '��ǰվ�����Ա�ţ�������վ��

  Sub New()
    pWorkName = "����һ"
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
  Public SameFromMDB As Boolean '�Ƿ��Ѵ�������վ����Ϣ
  Private pMapName As String  '��ͼ���� MI(1,1,0,0,0)
  Private pMapPath As String '��ͼ�ļ�·�� MI(1,2,0,0,0)
  Private pMapSize As Point '��ͼʵ�����ش�С��XY������
  Private pMapStationAmount As Short '��ͼ��ư���վ������
  Private pMapStationPlacedAmount As Short '��ͼʵ���ѷ���վ������
  Private pPerShowStationNo As Short '��һ��TabShowStationʱ��ʾ��վ������
  Private pMapIndex As Short '��ͼ����Ŀ�е�����,��1��ʼ��

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
    '��ȡ�����ݿ��е�MapStationPlacedAmount����ʵ����վ��
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
  Private pStationModeIndex As Short 'վ���ͺ�����
  Private pStationIndex As Short  'վ���ڵ�ͼ�е���������1��ʼ��
  Public StationGif As AxAniGIFCtrl.AxAniGIF
  Private pStationName As String 'StationName
  'Private SID As String 'StationID '�ŵ���������
  'Private SIP As String 'StationIP
  Private pStationLocation As Point 'StationLocation  X,Yֵ������1000000���еı���
  'pMapStationY
  Private pTestDate As String  'TestDate200505030139��Ϊ�ַ������ݣ�subnew�и�Ϊ���ַ���
  Private pTestTime As String  'TestTime
  Private pActive As Boolean 'վ���Ƿ񼤻�
  Private pStationParameterAmount As Short '��վ���ж��ٸ����������ڵ���STATION_PROPERTY_MAX_NO
  'Private pStationAlarm As Boolean

  'pMapStationPropertyAmount  --->STATION_INFO_NO=8public
  '------------------------------------------------------------------------------
  '������0Ϊ�������ƣ�1Ϊ������ֵ��2��λ��3Ϊ������
  Private pStationParameters(STATION_PROPERTY_MAX_NO, 3) As String
  Public pLabelToolTip As Label '��꾭��վ��ʱ����ʾ
  Public ModemInfo As GPRSModemInfo
  Private pStationID As String 'ͨѶ���ݽṹ�е�ID����ֹ��һ��ModemID����ͬ
  'Private pAlarmRun As Boolean  '�Ƿ����б����Ĳ�����
  Private pAlarm As Boolean '��������
  Private pSaved As Boolean '�Ƿ��Ѵ������ݿ�
  Private pStationAddress As String  'վ��Ľֵ���ַ
  Private pDBed As Boolean '�Ƿ������ݿ��е�����
  Private pRevNewData As Boolean '�Ƿ���յ�������
  Private pLookedRevNewData As Boolean '�������Ƿ�쿴��
  Private pHaveData As Boolean 'վ���Ƿ�������

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
    pStationParameterAmount = STATION_PROPERTY_MAX_NO '��佫���ٴ���
    pStationName = ""
    pSaved = False
    pStationLocation.X = -1 '������ʾ��û������
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
        pLabelToolTip.Text = CStr(pStationIndex) & "��"
      Else
        pLabelToolTip.Text = (CStr(pStationIndex) & "��" & pStationName)
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
        pLabelToolTip.Text = (CStr(pStationIndex) & "��" & pStationName)
      Else
        pLabelToolTip.Text = CStr(pStationIndex) & "��"
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
  Public ID As String                          'Modemģ���ID��
  Public PhoneNo As String               'Modem��11λ�绰����
  Public DynIP(3) As Integer                       'Modem��4λ��̬ip��ַ
  Public IP As String

  'Public M_Conn_Time As Long                        'Modemģ�����һ�ν���TCP���ӵ�ʱ��
  'Public M_Refresh_Time As Long                     '���յ������ݰ�����
End Class

#Region "�¶ȸߵ���Ϣ��MyClassTempAlarm"
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

