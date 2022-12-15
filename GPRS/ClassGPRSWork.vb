Public Class ClassGPRSWork

  Public Maps(MAP_MAX_NO) As GPRSMap

  Private pWorkName As String '��ǰ��������
  '------------------------------------------------------------------------------
  Private pMapAmount As Short '���ж����ŵ�ͼ
  'Private i As Short
  '------------------------------------------------------------------------------
  Private pMapNo As Short   '��ǰ��ͼ���
  Private pWorkPath As String '���̹���Ŀ¼
  Private i, j, k As Integer
  ''------------------------------------------------------------------------------
  'Private pMapStationNo As Short '��ǰվ���ţ�վ�������ڵ�ͼ

  ''------------------------------------------------------------------------------
  'Private pMapStationPropertyNo As Short  '��ǰվ�����Ա�ţ�������վ��



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
    If DelNo <= pMapAmount And DelNo > 0 Then
      pMapAmount = pMapAmount - 1
      For i = DelNo To pMapAmount
        Maps(i) = Maps(i + 1)
        Maps(i).MapIndex = DelNo + i - 1
        Maps(pMapAmount + 1) = Nothing
      Next
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
      pWorkPath = Value
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
      pWorkName = Value
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
          For i = 1 To pMapAmount - j
            Maps(j + i) = New GPRSMap
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
Public Class GPRSMap
  Private i, j, k As Integer
  Public Stations(STATION_MAX_NO) As GPRStation
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
      Stations(DelNo).StationGif.Visible = False
      Stations(DelNo).ToolTap = False
      Stations(DelNo).StationGif.Tag = ""
      Stations(DelNo) = Nothing
      For i = DelNo To pMapStationPlacedAmount - 1
        Stations(i) = Stations(i + 1)
        Stations(i).StationIndex = i
        Stations(i).StationGif.Tag = CStr(i)
      Next i
      'Stations(pMapStationPlacedAmount).StationGif.Visible = False
      'Stations(pMapStationPlacedAmount).ToolTap = False
      'Stations(pMapStationPlacedAmount).StationGif.Tag = ""
      'Stations(pMapStationPlacedAmount) = Nothing
      pMapStationPlacedAmount = pMapStationPlacedAmount - 1
      DelStation = True

    ElseIf DelNo = pMapStationPlacedAmount Then
      Stations(pMapStationPlacedAmount).StationGif.Visible = False
      Stations(pMapStationPlacedAmount).ToolTap = False
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
  ReadOnly Property MapStationPlacedAmount() As Short
    Get
      Return pMapStationPlacedAmount
    End Get
  End Property
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
      pMapPath = CStr(Value)
    End Set
  End Property
  Property MapName() As String
    Get
      Return pMapName
    End Get
    Set(ByVal Value As String)
      pMapName = CStr(Value)
    End Set
  End Property
End Class
'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Public Class GPRStation
  Private pStationModeIndex As Short 'վ���ͺ�����
  Private pStationIndex As Short  'վ���ڵ�ͼ�е���������1��ʼ��
  Public StationGif As AxAniGIFCtrl.AxAniGIF
  Private SN As String 'StationName
  Private SID As String 'StationID
  Private SIP As String 'StationIP
  Private SL As Point 'StationLocation  X,Yֵ������1000000���еı���
  'pMapStationY
  Private TD As Date 'TestDate
  Private TT As Date 'TestTime
  Private pActive As Boolean 'վ���Ƿ񼤻�
  Private pStationParameterAmount As Short '��վ���ж��ٸ����������ڵ���STATION_PROPERTY_MAX_NO
  Private pStationAlarm As Boolean
  'pMapStationPropertyAmount  --->STATION_INFO_NO=8public
  '------------------------------------------------------------------------------
  '������0Ϊ�������ƣ�1Ϊ������ֵ��2��λ��3Ϊ������
  Private pStationParameters(STATION_PROPERTY_MAX_NO, 3) As String
  Public pLabelToolTip As Label '��꾭��վ��ʱ����ʾ
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
    pStationParameterAmount = STATION_PROPERTY_MAX_NO
    SN = ""
  End Sub
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
      If SN = "" Then
        pLabelToolTip.Text = CStr(pStationIndex) & "��"
      Else
        pLabelToolTip.Text = (CStr(pStationIndex) & "��" & SN)
      End If
    End Set
  End Property

  Property StationParameters(ByVal SNo As Short, ByVal PIndex As Short) As String
    Get
      Return pStationParameters(SNo, PIndex)
    End Get
    Set(ByVal Value As String)
      pStationParameters(SNo, PIndex) = Value
      If PIndex = 1 Or PIndex = 3 Then
        If pStationParameters(SNo, 1) > pStationParameters(SNo, 3) Then
          pStationAlarm = True
          'StationGif.ReadGIF(StationGifAlarm(0))
        Else
          pStationAlarm = False
          'StationGif.ReadGIF(StationGifAlarm(1))
        End If
      End If
    End Set
  End Property

  ReadOnly Property StationAlarm() As Boolean
    Get
      Return pStationAlarm
    End Get
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
      StationGif.Playing = pActive
      StationGif.Frame = 0
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
      Return SN
    End Get
    Set(ByVal Value As String)
      SN = CStr(Value)
      If SN = "" Then
        pLabelToolTip.Text = CStr(pStationIndex) & "��"
      Else
        pLabelToolTip.Text = (CStr(pStationIndex) & "��" & SN)
      End If

    End Set
  End Property

  Property StationID() As String
    Get
      Return SID
    End Get
    Set(ByVal Value As String)
      SID = CStr(Value)
    End Set
  End Property

  Property StationIP() As String
    Get
      Return StationIP
    End Get
    Set(ByVal Value As String)
      SIP = Value
    End Set
  End Property

  Property StationLocation() As Point
    Get
      Return SL
    End Get
    Set(ByVal Value As Point)
      SL = Value
    End Set
  End Property

  Property TestDate() As Date
    Get
      Return TD
    End Get
    Set(ByVal Value As Date)
      TD = Value
    End Set
  End Property

  Property TestTime() As Date
    Get
      Return TT
    End Get
    Set(ByVal Value As Date)
      TT = Value
    End Set
  End Property

End Class
