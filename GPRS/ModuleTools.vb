Imports System.Security.Cryptography
Module ModuleTools

#Region "20070202�����"
  Public String_Separator As String = ","
  Public DataInfo_MDB_File As String = "DataInfo"
  Public DataInfo_MDB_Table As String = "StationInfo"
  Public FN As New MyFieldsName
  Public TCB As New MyTChartBasicSet


#Region "�ṹMyFieldsName"
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
#Region "�ֶ����Ƹ�ֵSetFN"
  Public Function SetFN() As Boolean
    Dim i As Integer
    Dim S As String
    With FN
      .MyID = "���"
      .MyMapName = "��ͼ����"
      .MyStationName = "վ������"
      .MyTestDate = "���ʱ��"

      .WorkID = "ID"
      .FamilyAddress = "��ͥ��ַ"
      .FamilyID = "��ͥID"
      .FamilyName = "��ͥ����"
      .FamilyPhoneNum = "��ͥ�绰"
      .StationAddress = "վ��ַ"
      .StationID = "վID"
      .StationName = "վ����"
      .StationPhoneNum = "վ�绰"
      .TestDate = "����"
      .TH = "վ��λ"
      .mm = "վ�ܾ�"

      ReDim .TimeString(23)
      For i = 0 To 23
        S = CStr(i)
        If Len(S) < 2 Then
          S = "0" & S
        End If
        S = S & "��"
        .TimeString(i) = S
      Next

    End With
  End Function
#End Region

#Region "TChart�Ļ���������MyTChartBasicSet"
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

#Region "�γ�SQLѡ���ַ���BuildSelectString"
  Public Function BuildSelectString(ByVal SelectStation As Point, ByVal DateYMD As Date, ByVal BuildSelectStringMode As String) As String
    Dim S, StartDate, EndDate As String
    BuildSelectString = ""

    If (SelectStation.X < 0) Or (SelectStation.Y < 0) Then Exit Function

    DateYMD = DateYMD.Date

    Select Case BuildSelectStringMode

      Case "��"

        StartDate = CStr(CDate(DateYMD.Year.ToString & "��" & DateYMD.Month.ToString & "��").Date)
        EndDate = CStr(DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, CDate(StartDate).Date))).Date)
        'If (SelectStation.Y < 0) Then ''''''''''��Ȼѡ�����һ����ͼ���Ȱ����еĶ�Ū��������ʾ��ʱ����ɸѡ,һ����ͼȫѡ����һ����ȫѡ��������
        '  S = ""
        '  S = "StationID > '0' AND SaveID > 0 AND TestDate >= " & StartDate & " AND TestDate <= " & EndDate
        'Else
        S = ""
        'S = "StationID = '" & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationID.ToString.Trim & "' AND SaveID >0 AND TestDate >= " & StartDate & " AND TestDate <= " & EndDate

        S = "StationID = '" & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationID.ToString.Trim & "' AND SaveID >0 AND TestDate >= '" & StartDate & "' AND TestDate <= '" & EndDate & "'"
        'End If

        BuildSelectString = S

      Case "��"
        StartDate = CStr(CDate(DateYMD.Year.ToString & "��" & DateYMD.Month.ToString & "��" & DateYMD.Day.ToString & "��").Date)

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

#Region "��ǰ�Ķ���"
  Public Const BulidDate_Txt As String = "BulidDate.txt"
  Public Const STATION_LOCATION_OFFSET As Integer = 1000000 '��ͼͼƬ���߼���С
  Public Const MAP_MAX_NO As Short = 10  '�������ŵ�ͼ
  Public Const STATION_MAX_NO As Short = 100   'ÿ�ŵ�ͼ���վ������
  Public Const STATION_PROPERTY_MAX_NO As Short = 10 'վ������м�������
  Public Const FDSX_FD_PEC As Decimal = 1.3  '���ŵ�ͼ�İٷֱ�
  Public Const FDSX_SX_PEC As Decimal = 0.8  '���ŵ�ͼ�İٷֱ�
  Public Const PLACE_STATION_OFFSET As Short = 16 '����վ���ǵ����ƫ����
  Public Const DATA_LEN As Integer = 55 '���ݳ���  ͷ1+ID4+����1+����1+���ݰ�46+У��1+β1
  Public Const Max_Print_XY As Integer = 11842 '����A4ֽ��Ŀؼ�����
  Public Const m_m_m As Single = 5.63904761904762 '0.1mm��Ӧ��ƽ����ֵ
  Public Const Default_GprsWork_INIFilesName As String = "hzg"
  Public Const AppConfig_FilesName As String = "winapp32.dll" '�����ڹ��̵Ĺ���Ŀ¼��
  Public Const GprsWork_MdbFileName As String = "GPRSMdb.mdb" '�����ڹ��̵Ĺ���Ŀ¼��
  Public Const CWMap_Station_InfoMDB As String = "Info.mdb" '���湤����Ϣ�����ݿ�����
  Public Const PrintLS_MDBFileName As String = "PrintLS.mdb" '���湤����Ϣ�����ݿ�����
  Public Const DataMDB_FileName As String = "DataInfo.mdb" '����������ֵ�����ݿ�����
  Public Const NoDate_DB As String = "2000-1-1" '���ݿ��д�����ʱ��ĳ��� 
  Public Const PMs_Name As String = "HZY-GPRS�������ϵͳ"
  Public Const LoadDB_StartDate As String = "2005-05-01" '��ѯ���ݿ�ʱ�����꿪ʼ�ж���������
  Public Const MaxUser_Amount As Short = 20 '����û���
  Public Const Crypt_KEY As String = "zdq"
  Public Const RWini_BZString As String = "*" 'ini��ֵ�ı���ַ�
  Public Const PA_Key As String = "+3feoje+HgM="
  Public Const PA_KeyIV As String = "hOhewSk3leM="
  Public Const JiaGeString As String = "          "
  Public Const HZY As String = "HZY"
  Public Const TX_RetryNo As Integer = 3 '''''''''''��ʱ�ط�����
  Public Const PollUserTable_WaitTime As Integer = 1000
  Public Const ThreadRevMSend_WaitTime As Integer = 200
  Public Const AppVer_FileName As String = "AppVer.ini"
  '###########################ͨѶ���#################################
  Public Const SendData_BasicLong As Short = 21
  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
  'SDȡSendData����д
  Public Const SD_Start As Byte = &H7E
  Public Const SD_End As Byte = &H6A
  Public Const Host_ID As String = "88888888"
  Public Const Rev_WaitTime As Long = 5

  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  '��Щ�����Ժ�ŵ�config.dll��
  '####################################################################
  'Public dsParameterData As New DataSet
  'Public daParameterData
  Public EDS As New GprsCrypt
  Public bForm7SaveLoad As Boolean 'Form7����ʱ��ģʽ��TrueΪ���棬LoadΪ��ѯ

  Public RCWError As Boolean '��ȡ���̹������Ƿ��д����д���Ļ������й�������
  Public bMoMove As Boolean  'ͼƬ�ȿ�󣬿����ƶ�
  Public bMoPointChangED As Boolean '���ƶ��Ļ���������Ѿ�������?
  Public CW As New GPRSWork
  Public CWActive As Boolean
  Public CWChanged As Boolean
  Public Form1Run As Boolean
  Public form2WorkSettingRun As Boolean '���ô����Ƿ������У���CWChanged��ϣ�ȷ���Ƿ��ˢ�¹���
  Public WorkWillPrint As New GPRSWorkPrint

  Public GprsWorkINI As New GprsRWini '��¼������Ϣ��INI����

  Public PM As New GprsProgramMe '�����Լ��������ǹ���
  Public AUsers As New GprsUesrs
  Public ActivePerson As New GPRSPerson
  Public SGif As New GPRSImagesResource '����ͼ����Դ����,�ŵ�ģ����Ϊ����
  Public TXDM As New GprsTXDataMode 'ͨѶ�������ͼ�¼
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

      ''''''������Rows


      Exit Function ''''''''''''''''����������Զ���������:2261210,������,�ֲ������ˣ�1211

    End With
  End Function

  Public Function CheckString(ByVal Str As String, ByVal strSeparator As String, ByVal RorW As String, ByVal Num As Integer, ByRef strRWReturn As String) As Integer
    'str��������ַ�����strSeparator�ָ�����RorW������д��R����W����Num�ڼ������ݣ�strWҪд��Ļ�������ַ���,ByRef strRWReturn As String ByRef�ź�ʹ��
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

#Region "����������"
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

        For i = 1 To StationModeHowMany '''''''''''''''''''��ȡ����վ���ͺŵ�����

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

          '''''''''''''''''''''''''''''''''''''''20080106����ʵʱ����
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
      Public Order() As Integer  '��Ӧ�����ݿⱣ���վ�������˳��(��������˳����δ�������)
      Public Order_Dot() As Integer '������С����λ��
      Private i As Int32

      Public Sub SetHowManyParameter(ByVal HowMany As Integer)
        If HowMany < 1 Then
          Exit Sub
        End If

        ReDim Order(HowMany)
        ReDim Order_Dot(HowMany) 'С����λ��

      End Sub

      Sub New()
        HowManyParameter = 10
        ParameterByteLong = 4
        ReDim Order(HowManyParameter)
        ReDim Order_Dot(HowManyParameter) 'С����λ��
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
    '��¼�ѷ��͹��������ʷ��¼
    Public StationID As String
    Public ModemID As String
    Public DataMode As String
    Public DataString As String
    Public SendDate As Date
    Public SendSuccess As Boolean
    Public SendByteArray() As Byte
    Public RevED As Boolean '�յ�������
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
    ' ����У���,StartIndex��0��ʼ,Ҳ���������е���ʵ����
    Dim i, j As Integer
    Dim tL As Long
    tL = 0
    j = ByteData.GetLowerBound(0)
    For i = 0 To Num - 1
      If StartIndex + Num - 1 > ByteData.GetUpperBound(0) Then Exit For '����������鳤����У�鵽���
      tL += ByteData(i + j + StartIndex)
    Next i
    tL = tL - ((tL \ 256) * 256)
    JYHByte = tL
  End Function

  Public Overloads Function JYHByte(ByVal ByteData() As Byte, ByVal StartIndex As Integer, ByVal Num As Integer, ByVal CheckSumByte As Byte) As Boolean
    ' ����У���,StartIndex��0��ʼ
    Dim i, j As Integer
    Dim tB As Byte
    Dim tL As Long
    JYHByte = False
    tL = 0
    j = ByteData.GetLowerBound(0)
    For i = 0 To Num - 1
      If StartIndex + Num - 1 > ByteData.GetUpperBound(0) Then Exit For '����������鳤����У�鵽���
      tL += ByteData(i + j + StartIndex)
    Next i
    tL = tL - ((tL \ 256) * 256)
    tB = tL
    If tB = CheckSumByte Then JYHByte = True
  End Function

  Public Class GprsUesrs
    Public Users() As GPRSPerson
    Private pUserAmount As Short
    Public ActiveNo As Integer  '�����û��ǻ�û�
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

        Case True '��
          Try
            RWIni = .ReadINI(RWini_BZString)
          Catch ex As Exception
          End Try

        Case False 'д

          .ValueStr = KeyValue
          Try
            .WriteINI(RWini_BZString)
          Catch ex As Exception
          End Try

      End Select
    End With
  End Function

  Public Overloads Function RWUsersIni(ByVal RW As Boolean, ByVal UserNo As Integer) As Boolean
    '��д�����û���Ϣ
    If UserNo < 1 Then Exit Function
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    Dim i As Integer

    SPath = GetAppPath() & "\" & AppConfig_FilesName

    With PINI

      Select Case RW
        Case True ''''''''''''''''''''''''''''''''''''''''''''''''''''''��
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

        Case False ''''''''''''''''''''''''''''''''''''''''''''''''д
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
    '��дȫ���û���Ϣ
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    Dim i As Integer

    SPath = GetAppPath() & "\" & AppConfig_FilesName

    With PINI

      Select Case RW
        Case True ''''''''''''''''''''''''''''''''''''''''''''''''''''''��
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


        Case False ''''''''''''''''''''''''''''''''''''''''''''''''д
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

  '    ' �����̽���һ���ļ�·����Ȼ����ݴ���ĳ�����
  '    ' ����·�������ļ���������������֣���
  '    ' ��������
  '    ' �����ļ���չ����

  '    Dim lngPos As Long
  '    Dim strPart As String
  '    Dim blnIncludesFile As Boolean

  '    ' ���������Ƿ���һ���ļ�·����
  '    ' �������һ���ָ�����
  '    lngPos = InStrRev(strPath, "\")
  '    ' �ж����һ����б�ܺ�����ַ����Ƿ����
  '    ' ��㡣
  '    blnIncludesFile = InStrRev(strPath, ".") > lngPos

  '    If lngPos > 0 Then
  '      Select Case lngPart
  '        ' �����ļ�����
  '      Case opgParsePath.FILE_ONLY
  '          If blnIncludesFile Then
  '            strPart = Right$(strPath, Len(strPath) - lngPos)
  '          Else
  '            strPart = ""
  '          End If
  '          ' ����·����
  '        Case opgParsePath.PATH_ONLY
  '          If blnIncludesFile Then
  '            strPart = Left$(strPath, lngPos)
  '          Else
  '            strPart = strPath
  '          End If
  '          ' �����������š�
  '        Case opgParsePath.DRIVE_ONLY
  '          strPart = Left$(strPath, 3)
  '          ' �����ļ���չ����
  '        Case opgParsePath.FILEEXT_ONLY
  '          If blnIncludesFile Then
  '            ' ȡ����������ַ���
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

      'i = INIFileName.LastIndexOf("\") '''''''''''''''''���̵Ĺ���·������һ��ReadSettingsINI�Ĳ���
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
        Case False ''''''''''''''''''''''''''''''''''''''���湤��
          Try
            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkName"
            .ValueStr = CW.WorkName
            .WriteINI(RWini_BZString)

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkPath"
            .ValueStr = "\����һ"
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
          '    '''''''''''''''''''''''''''''''''''''����ÿ�ŵ�ͼ����Ϣ
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

        Case True     ''''''''''''''''''''''''''''''''''''������

          Try

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkName"
            '.ValueStr = CW.WorkName
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              CW.WorkName = tmpS
            Else
              CW.WorkName = "����һ"
            End If

            .FileName = SPath
            .AppName = "WORK"
            .KeyName = "WorkPath"
            '.ValueStr = "\����һ"
            tmpS = CStr(.ReadINI(RWini_BZString))
            If tmpS <> "" Then
              If Left(tmpS, 1) <> "\" Then
                CW.WorkPath = tmpS
              Else
                CW.WorkPath = GetAppPath() & tmpS  '���Ŀ¼��������ڳ������е�Ŀ¼
              End If
            Else
              CW.WorkPath = GetAppPath() & "\����һ" 'Ĭ�ϵ�
            End If
            ']20070220����·�����Ǻ�INI�ļ�һ]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
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
              CW.MapAmount = CSng(tmpS) '�����������ȡ���̳ɹ�

              RWGprsWorkINI = True
            Catch ex As Exception
              CW.MapAmount = 0
            End Try

            RWTXini(True)

            '''''''''''''''''''''''''''''''20070207�Զ���ѯ���
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
            'For i = 1 To CW.MapAmount '''''''''''''''''''��ÿ�ŵ�ͼ����Ϣ,20050423�ŵ����ݿ�����

            '  .FileName = SPath
            '  .AppName = "MAP" & CStr(i)
            '  .KeyName = "MapName"
            '  '.ValueStr = CW.Maps(i).MapName
            '  tmpS = CStr(.ReadINI(RWiniBZString))
            '  If tmpS <> "" Then
            '    CW.Maps(i).MapName = tmpS
            '  Else
            '    CW.Maps(i).MapName = "��ͼ" & CStr(i)
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
            '      'tmpS1 = GetAppPath() & "\" & "����һ" & "\maps\map" & CStr(i) & ".bmp"
            '      '')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
            '      CW.Maps(i).MapPath = tmpS1
            '    End If
            '  Else
            '    CW.Maps(i).MapPath = GetAppPath() & "\" & "����һ" & "\maps\map" & CStr(i) & ".bmp"
            '  End If

            'Next i

          Catch
            RWGprsWorkINI = False
          End Try

      End Select

    End With
  End Function

  Public Function RWTXini(ByVal RW As Boolean) As String
    '�������������Ĳ���ֱֵ�Ӹ����������Checkbox�����Է����������SetWorkAll()�������ˡ�
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
      'CW.MapAmount = 2 '������Ѿ�����GPRSMap����
      If CW.WorkName = "" Then
        CW.WorkName = "����һ"
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
              CW.Maps(i).MapName = "��ͼ" & CStr(i)
            End If
            'CW.Maps(i).MapStationAmount = 100
          Next i
          CW.MapNo = 1
        Else
        End If
      Else
      End If

      'CW.Maps(1).MapName = "������"
      'CW.Maps(2).MapName = "������"
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
  Public Class GPRSImagesResource '��¼վ�㲻ͬ״̬��Ӧ�õ�GifͼƬ·�����࣬�Ժ����չΪ�෽��Ӧ��
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
    '���������ַ����Ƿ��ǺϷ���IP��ʽ
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
    '��Ӧ�ó�����Ƕ����Դ�����Ա����û���ɾ����Դ�ļ������Ӧ�ó�����ִ���Ҫʹ����Դ�ļ��е��ļ���ֻ��Ҫ������ķ������ü��ɣ�
    Return System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strName)
  End Function
  'Public SP(STATION_MAX_NO) As AxAniGIFCtrl.AxAniGIF  '��ͼ��վ��ؼ�����

  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  'EZ_Crypt.vb(�ַ������ܺͽ�����)
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

      ' �����µļ��ܷ����ṩ�������
      md5 = New MD5CryptoServiceProvider

      ' ��ԭʼ�ַ���ת�����ֽ�����
      bytValue = System.Text.Encoding. _
       UTF8.GetBytes(TextToHash)

      ' ����ɢ�У�������һ���ֽ�����
      bytHash = md5.ComputeHash(bytValue)

      md5.Clear()

      ' ����ɢ��ֵ�� Base64 �����ַ���
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
      '·�������һ���ַ��ܲ��� \ ����Ϊ�˼������е�·���ǲ������·���������һ���ַ��� \ ��˵�������·��
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
