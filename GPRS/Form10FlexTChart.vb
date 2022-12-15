Imports grproLib
Public Class Form10FlexTChart
  Private WithEvents GRDM As New grproLib.GridppReport
  Private m_pColumnContent As IGRColumnContent
  Private m_pTempsContentCell As IGRColumnContentCell
  Private m_pTempsField As IGRField


  Dim CDMain As New MyClassData
  Dim MyCD As New MyClassData
  Dim bBuildCDMain As Boolean = False
  Dim SelectDateString As String '''''''''''''��¼�ǡ��ꡱ���¡����ա�
  Dim LastDateDB As Date
  Dim SelectDate As Date
  Dim SelectStation As Point = New Point(-1, -1)
  Dim numVertaxis, numHorizaxis As Object

  Dim bSetLocationRun As Boolean = False
  'Dim bSetWorkAllRun As Boolean = False

  Dim SetTChartMinMax As New Point

  Dim FlexGridMain_ColsCount As Integer = CW.Max_ParameterAmount + CW.FlexGridMain_ColsCount_Basic

  Private Overloads Function InitializingTChartMain(ByRef ActiveTChart As AxTeeChart.AxTChart) As Boolean

    With ActiveTChart

      '.ClearChart()
      .RemoveAllSeries()

      '.Axis.Bottom.Title.Caption = "ʱ����"

      'CheckBoxTChart3D.Checked = True
      .Aspect.View3D = CheckBoxTChart3D.Checked

      If CheckBoxTChartLine.Checked Then
        CW.TChartSeriesType = TeeChart.ESeriesClass.scLine
      Else
        CW.TChartSeriesType = TeeChart.ESeriesClass.scFastLine
      End If

      '.Aspect.View3D() = True
      .Axis.DrawAxesBeforeSeries = CheckBoxTChart3D.Checked

      '[[[[[[[[[[[[[[[[[[[[[[[[[[20070214���

      With ActiveTChart.Axis.Bottom
        .ExactDateTime = True
        .Labels.Multiline = True
        If (Me.SelectDateString = "��") Then
          .Increment = ActiveTChart.GetDateTimeStep(TeeChart.EDateTimeStep.dtTenMinutes)
          .Labels.DateTimeFormat = "hh-mm"
          '.SetMinMax(0, 24)
        ElseIf (Me.SelectDateString = "��") Then
          .Increment = ActiveTChart.GetDateTimeStep(TeeChart.EDateTimeStep.dtOneDay)
          .Labels.DateTimeFormat = "yyyy-mm-dd"
          '.SetMinMax(0, 24)
        End If
      End With
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
      numVertaxis = .Axis.AddCustom(False)

      '.Name = "�¶�����"
      '.Axis.Left.Maximum = TCB.AxixLeftMax
      '.Axis.Left.Minimum = TCB.AxixLeftMin
      '.Axis.Bottom.Minimum = TCB.AxixBottomMin
      '.Axis.Bottom.Maximum = TCB.AxixBottomMax
      '(((((((((((((((((((((((((((((((((((((((((
      '.AddSeries(TeeChart.ESeriesClass.scFastLine)
      '.Series(0).FillSampleValues(24)
      '))))))))))))))))))))))))))))))))))))))
    End With
    With ActiveTChart.Axis.Custom(numVertaxis)
      '.StartPosition = -35
      '.EndPosition = 45
      '.Maximum = 45
      '.Minimum = -35
    End With
  End Function
  Private Overloads Function InitializingTChartMain(ByRef ActiveTChart As AxTeeChart.AxTChart, ByVal myCD As MyClassData, ByVal SeriesType As Integer) As Boolean
    Dim i, j, RN, CN, SerieNo As Integer
    Dim S As String = ""
    Dim TDouble As Double = 0
    Dim ttDouble As Double = 0

    Dim MaxD, MinD As Double
    Dim OneSet As Boolean = False

    Dim AddDate, AddDate_Date, AddDate_Time As Date
    MaxD = 0
    MinD = 0

    For i = 0 To TChartMain.SeriesCount - 1
      TChartMain.Series(i).Clear()
    Next i

    Try
      RN = myCD.DataRows.GetUpperBound(0)
      If RN < 0 Then Exit Function
    Catch ex As Exception
      'MessageBox.Show(ex.Message)
      Exit Function
    End Try

    Try
      CN = myCD.DataRows(0).Table.Columns.Count - 1
    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Exit Function
    End Try

    InitializingTChartMain(ActiveTChart)

    With ActiveTChart

      For i = 1 To CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameterAmount

        Try
          If ChkLst_SelectPars.GetItemChecked(i - 1) Then

            SerieNo = .AddSeries(SeriesType)
            .Series(SerieNo).XValues.DateTime = True
            .Series(SerieNo).Title = CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameters(i, 0)

            For j = 0 To RN

              If Not (IsDBNull(myCD.DataRows(j)("TestDate"))) Then
                S = CStr(myCD.DataRows(j)("TestDate")) & " "
                AddDate_Date = CDate(S).Date
                If Not (IsDBNull(myCD.DataRows(j)("TestTime"))) Then
                  AddDate_Time = CStr(myCD.DataRows(j)("TestTime"))
                  S += CStr(myCD.DataRows(j)("TestTime"))
                  AddDate = CDate(S)
                End If
              End If

              Try
                If Not (IsDBNull(myCD.DataRows(j)("ParameterData" & i.ToString))) Then
                  TDouble = myCD.DataRows(j)("ParameterData" & i.ToString)
                  If OneSet = False Then
                    MaxD = TDouble
                    MinD = TDouble
                    OneSet = True
                  End If
                  If TDouble > MaxD Then MaxD = TDouble
                  If TDouble < MinD Then MinD = TDouble

                  ttDouble = AddDate.ToOADate()

                  '.Series(SerieNo).AddXY(ttDouble, TDouble, "", System.Convert.ToUInt32(TeeChart.EConstants.clTeeColor))
                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                  Select Case Me.SelectDateString
                    Case "��"
                      .Series(SerieNo).Add(TDouble, Format(AddDate_Time, "HH:mm:ss"), System.Convert.ToUInt32(TeeChart.EConstants.clTeeColor))
                    Case "��"
                      .Series(SerieNo).Add(TDouble, Format(AddDate_Date, "yyyy-MM-dd") & vbCrLf & Format(AddDate_Time, "HH:mm:ss"), System.Convert.ToUInt32(TeeChart.EConstants.clTeeColor))
                  End Select

                  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

                Else
                  TDouble = Nothing
                  '.Series(SerieNo).AddNullXY(AddDate.ToOADate(), 0, "")
                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                  Select Case Me.SelectDateString
                    Case "��"
                      .Series(SerieNo).AddNull(Format(AddDate_Time, "HH:mm:ss"))
                    Case "��"
                      .Series(SerieNo).AddNull(Format(AddDate_Date, "yyyy-MM-dd") & vbCrLf & Format(AddDate_Time, "HH:mm:ss"))
                  End Select

                  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                End If

              Catch ex As Exception
                MessageBox.Show(ex.Message)
              End Try

            Next j
          End If
        Catch ex As Exception

        End Try

      Next i

      Select Case Me.SelectDateString

        Case "��"

          .Axis.Bottom.Increment = ActiveTChart.GetDateTimeStep(TeeChart.EDateTimeStep.dtOneMinute)
          .Axis.Bottom.Labels.DateTimeFormat = "hh:mm"

        Case "��"
          .Axis.Bottom.Increment = ActiveTChart.GetDateTimeStep(TeeChart.EDateTimeStep.dtOneHour)
          .Axis.Bottom.Labels.DateTimeFormat = "yyyy-mm-dd"
        Case Else

          Exit Function

      End Select

      SetTChartMinMax = New Point(CInt(MinD - 0.5), CInt(MaxD + 0.5))
      .Axis.Left.SetMinMax(SetTChartMinMax.X, SetTChartMinMax.Y)

      Exit Function
      '##################################################################
      S = ""
      For i = 0 To RN

        SerieNo = .AddSeries(SeriesType)
        .Series(SerieNo).XValues.DateTime = True
        .Series(SerieNo).Title = myCD.DataRows(i).Item(FN.FamilyID) & "�ż�ͥ"

        'k = .Aspect.Chart3DPercent()
        'k = .Aspect.VertOffset

        '.Series(i).VerticalAxisCustom = numVertaxis
        For j = 0 To 23
          '.Series(i).Add(myCD.DataRows(i).Item(j), FN.TimeString(j - Start_00Dian_No), System.Convert.ToUInt32(TeeChart.EConstants.clTeeColor))
          Try
            If Not (IsDBNull(myCD.DataRows(i)(FN.TimeString(j)))) Then
              TDouble = myCD.DataRows(i)(FN.TimeString(j))
              If TDouble > MaxD Then MaxD = TDouble
              If TDouble < MinD Then MinD = TDouble
              .Series(SerieNo).Add(TDouble, FN.TimeString(j), System.Convert.ToUInt32(TeeChart.EConstants.clTeeColor))
            Else
              TDouble = Nothing
              '.Series(SerieNo).Add(TDouble, FN.TimeString(j), System.Convert.ToUInt32(TeeChart.EConstants.clTeeColor))
              .Series(SerieNo).AddNull(FN.TimeString(j))
            End If

          Catch ex As Exception
            MessageBox.Show(ex.Message)
          End Try
          '.Series(i).PointLabel(j) = CStr(TDouble)
          '.Series(i).PointValue(j) = CStr(TDouble)
          'S = .Series(i).ValueMarkText(j)
        Next j

      Next i

      SetTChartMinMax = New Point(CInt(MinD - 0.5), CInt(MaxD + 0.5))
      .Axis.Left.SetMinMax(SetTChartMinMax.X, SetTChartMinMax.Y)

    End With
  End Function

  Private Overloads Function InitializingFlexMain(ByVal ActiveFlexGrid As AxMSFlexGridLib.AxMSFlexGrid, ByVal MyCD As MyClassData, ByVal Clear As Boolean) As Boolean
    Dim i, j, RN, CN, iFG As Integer
    Dim S, TempS As String
    'Dim SID, FID As Integer
    'Dim RowCount As Integer
    Dim RowHeight As Integer = 250

    Dim ShowDate As Date ''''׼�������ָ�ÿ�������
    Dim ID As Integer = 0

    Dim CellColor As System.Drawing.Color = System.Drawing.Color.Black

    RN = -1
    With ActiveFlexGrid

      InitializingFlexMain(ActiveFlexGrid, Clear)

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[�ָ�����
      .Redraw = False
      .Tag += 1
      Try
        .Col = 0
        .Row = .Tag
      Catch ex As Exception
        'If ex.Message = "ex.Message = "�쳣���� HRESULT:0x800A7539" Then
        .AddItem("")
        .Col = 0
        .Row = .Tag
        'End If
      End Try
      .set_RowHeight(.Tag, CInt(RowHeight * 0.2))

      For iFG = 0 To FlexGridMain_ColsCount - 1
        .Col = iFG
        .CellBackColor = System.Drawing.Color.LightSlateGray
      Next iFG
      .Redraw = True
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]����������ʾ
      .Redraw = False
      .Tag += 1
      Try
        .Col = 0
        .Row = .Tag
      Catch ex As Exception
        'If ex.Message = "ex.Message = "�쳣���� HRESULT:0x800A7539" Then
        .AddItem("")
        .Col = 0
        .Row = .Tag
        'End If
      End Try
      .set_RowHeight(.Tag, RowHeight)

      .Row = .Tag
      .Col = 0
      .Text = FN.MyID

      .Row = .Tag
      .Col = 1
      .Text = FN.MyMapName

      .Row = .Tag
      .Col = 2
      .Text = FN.MyStationName

      .Row = .Tag
      .Col = 3
      .Text = FN.MyTestDate

      For j = 1 To CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameterAmount
        .Row = .Tag
        .Col = CW.FlexGridMain_ColsCount_Basic + j - 1

        S = CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameters(j, 0) ''''''''''''''''''''''''''''''''''''''''��������
        .Text = S
      Next j
      .Redraw = True
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]��ʾ����
      .Redraw = False
      Try
        RN = MyCD.DataRows.GetUpperBound(0)
        If RN < 0 Then
          .Redraw = True
          Exit Function
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

      Try
        CN = MyCD.DataRows(0).Table.Columns.Count - 1
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

      Try
        ShowDate = CDate(MyCD.DataRows(0)("TestDate")).Date
      Catch ex As Exception
      End Try
      ID = 0
      For i = 0 To RN '#############################################

        If ShowDate <> CDate(MyCD.DataRows(i)("TestDate")).Date Then
          ShowDate = CDate(MyCD.DataRows(i)("TestDate")).Date
          ID = 1
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[�ָ�����
          '.Redraw = False
          .Tag += 1
          Try
            .Col = 0
            .Row = .Tag
          Catch ex As Exception
            'If ex.Message = "ex.Message = "�쳣���� HRESULT:0x800A7539" Then
            .AddItem("")
            .Col = 0
            .Row = .Tag
            'End If
          End Try
          .set_RowHeight(.Tag, CInt(RowHeight * 0.2))

          For iFG = 0 To FlexGridMain_ColsCount - 1
            .Col = iFG
            .CellBackColor = System.Drawing.Color.LightSlateGray
          Next iFG
          '.Redraw = True
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]����������ʾ
          '.Redraw = False
          .Tag += 1
          Try
            .Col = 0
            .Row = .Tag
          Catch ex As Exception
            'If ex.Message = "ex.Message = "�쳣���� HRESULT:0x800A7539" Then
            .AddItem("")
            .Col = 0
            .Row = .Tag
            'End If
          End Try
          .set_RowHeight(.Tag, RowHeight)

          .Row = .Tag
          .Col = 0
          .Text = FN.MyID

          .Row = .Tag
          .Col = 1
          .Text = FN.MyMapName

          .Row = .Tag
          .Col = 2
          .Text = FN.MyStationName

          .Row = .Tag
          .Col = 3
          .Text = FN.MyTestDate

          For j = 1 To CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameterAmount
            .Row = .Tag
            .Col = CW.FlexGridMain_ColsCount_Basic + j - 1

            S = CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameters(j, 0)
            .Text = S
          Next j
          '.Redraw = True
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        Else
          ID += 1
        End If

        .Tag += 1
        Try
          .Col = 0
          .Row = .Tag
        Catch ex As Exception
          'If ex.Message = "HRESULT �е��쳣��0x800A7539��" Then
          .AddItem("")
          .Col = 0
          .Row = .Tag
          'End If
        End Try
        .set_RowHeight(.Tag, RowHeight)

        '.CellPicture = ImageListFlexMain.Images(2)

        .Row = .Tag
        .Col = 0
        .Text = ID.ToString

        .Row = .Tag
        .Col = 1
        .Text = CW.Maps(Me.SelectStation.X).MapName

        .Row = .Tag
        .Col = 2
        .Text = CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationName

        .Row = .Tag
        .Col = 3
        If Not (IsDBNull(MyCD.DataRows(i)("TestDate"))) Then
          S = CStr(MyCD.DataRows(i)("TestDate")) & " "
          If Not (IsDBNull(MyCD.DataRows(i)("TestTime"))) Then
            S += CStr(MyCD.DataRows(i)("TestTime"))
            .Text = CDate(S).ToString
          End If
        End If

        'FlexGridMain_ColsCount_Basic
        For j = 1 To CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameterAmount

          .Row = .Tag
          .Col = CW.FlexGridMain_ColsCount_Basic + j - 1

          If Not (IsDBNull(MyCD.DataRows(i)("ParameterData" & j.ToString))) Then
            S = MyCD.DataRows(i)("ParameterData" & j.ToString) & " " & CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameters(j, 2)
            .Text = S


            TempS = CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameters(j, 3)

            If IsNumeric(TempS) Then

              If CSng(S) > CSng(TempS) Then
                .CellBackColor = CW.ColorAlarm.ColorLower
              Else
                .CellBackColor = CW.ColorAlarm.ColorStandard
              End If
            Else
              .CellBackColor = CW.ColorAlarm.ColorStandard
            End If

          End If

        Next j

      Next i

      .Redraw = True
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    End With
  End Function
  Private Overloads Function InitializingFlexMain(ByVal ActiveFlexGrid As AxMSFlexGridLib.AxMSFlexGrid, ByVal Clear As Boolean) As Boolean
    Dim i, j As Integer

    With ActiveFlexGrid

      Select Case .Name

        Case "FlexMain"
          If Clear Then
            .Clear()
            .Tag = 0
          End If

          .Cols = CW.FlexGridMain_ColsCount_Basic + CW.Max_ParameterAmount
          'For i = 0 To .Cols - 1
          '  .set_ColWidth(i, 530)
          'Next i
          .set_ColWidth(0, 530)
          .set_ColWidth(1, 1000)
          .set_ColWidth(2, 1000)
          .set_ColWidth(3, 1800)
          '.set_ColWidth(3, 1000)
          '.set_ColWidth(4, 1000)
          '.set_ColWidth(5, 1000)
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          '.set_ColWidth(3, 5) '����������
          '.set_ColWidth(4, 5)
          '.set_ColWidth(5, 5)
          '.set_ColWidth(6, 5)

          'FlexGridMainInfoSF(ActiveFlexGrid, False)
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

          .set_TextMatrix(0, 0, FN.MyID)
          .set_TextMatrix(0, 1, FN.MyMapName)
          .set_TextMatrix(0, 2, FN.MyStationName)
          .set_TextMatrix(0, 3, FN.MyTestDate)
          For i = 1 To CW.Max_ParameterAmount
            .set_TextMatrix(0, CW.FlexGridMain_ColsCount_Basic + i - 1, "����" & i.ToString)
            .set_ColWidth(CW.FlexGridMain_ColsCount_Basic + i - 1, 1000)
          Next i

        Case "FlexGridTaskList"

          If Clear Then
            .Clear()
            .Tag = 0
          End If
          .Cols = 8
          For i = 0 To 7
            .set_ColWidth(i, 530)
          Next i
          .set_ColWidth(0, 550)
          .set_ColWidth(1, 550)
          .set_ColWidth(2, 650)
          .set_ColWidth(3, 650)
          .set_ColWidth(4, 1000)
          .set_ColWidth(5, 1000)
          .set_ColWidth(6, 2000)
          .set_ColWidth(7, 3000)

          .set_TextMatrix(0, 0, "")
          .set_TextMatrix(0, 1, "���")
          .set_TextMatrix(0, 2, FN.StationID)
          .set_TextMatrix(0, 3, FN.FamilyID)
          .set_TextMatrix(0, 4, "��������")
          .set_TextMatrix(0, 5, "����״̬")
          .set_TextMatrix(0, 6, FN.TestDate)
          .set_TextMatrix(0, 7, "������")

        Case Else

          'ImageListTreeStationsFamilys()
          '.Dispose()
          'ActiveFlexGrid = New AxMSFlexGridLib.AxMSFlexGrid
          If Clear Then
            .Clear()
            .Tag = 0
          End If

          .Cols = FlexGridMain_ColsCount
          For i = 0 To FlexGridMain_ColsCount - 1
            .set_ColWidth(i, 530)
          Next i
          .set_ColWidth(0, 550)
          .set_ColWidth(1, 550)
          .set_ColWidth(2, 650)
          '.set_ColWidth(3, 1000)
          '.set_ColWidth(4, 1000)
          '.set_ColWidth(5, 1000)
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          '.set_ColWidth(3, 5) '����������
          '.set_ColWidth(4, 5)
          '.set_ColWidth(5, 5)
          '.set_ColWidth(6, 5)

          'FlexGridMainInfoSF(ActiveFlexGrid, False)
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

          .set_TextMatrix(0, 0, FN.WorkID)
          .set_TextMatrix(0, 1, FN.StationID)
          .set_TextMatrix(0, 2, FN.FamilyID)
          .set_TextMatrix(0, 3, FN.FamilyAddress)
          .set_TextMatrix(0, 4, FN.FamilyPhoneNum)
          .set_TextMatrix(0, 5, FN.FamilyName)
          .set_TextMatrix(0, 6, FN.TestDate) '20061118

          j = 7

          For i = 0 To 23
            .set_TextMatrix(0, i + j, FN.TimeString(i))
          Next i
          '((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
          ''.set_TextMatrix(0, 12, "22.4")
          '.set_TextMatrix(1, 3, "�������е������е½�253��")
          '.set_TextMatrix(1, 4, "88888888")
          '.set_TextMatrix(1, 5, "��������")
          '))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))

      End Select

    End With
  End Function
  Private Function ShowDB(ByRef TV As TreeView) As Boolean
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim i, j, k, Years, Y, M, D, Ds, Mi, Di As Integer
    Dim FS, S As String
    S = ""
    Dim StartDate As Date
    Dim tNode As TreeNode

    'SelectDateString = ""
    LastDateDB = CDate(NoDate_DB)
    TV.Nodes.Clear()
    'ListBox1.Items.Clear()
    'ComboBox1.Items.Clear()
    'LabelInfo.Text = ""

    StartDate = CDate(LoadDB_StartDate)
    Years = DatePart(DateInterval.Year, Today) - DatePart(DateInterval.Year, StartDate) + 1

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      Rst = Ado.OpenTable(DataInfo_MDB_Table)
      With Rst
        k = 0
        For Y = DatePart(DateInterval.Year, StartDate) To DatePart(DateInterval.Year, Today) ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''��
          .Filter = ""
          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & Y & "'" & " AND " & "SaveMonth= " & "'" & "" & "'"
          If .RecordCount > 0 Then
            Try
              tNode = (TV.Nodes.Add(CStr(Y) & "��"))
              tNode.Tag = "��"
            Catch ex As Exception
            End Try
            Mi = 0
            For M = 1 To 12 '''''''''''''''''''''''''''''''''''''''''''''''''��
              .Filter = ""
              FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & Y & "'" & " AND " & "SaveMonth= " & "'" & CStr(M) & "'"
              .Filter = FS
              If .RecordCount > 0 Then
                Try
                  tNode = TV.Nodes(k).Nodes.Add(CStr(Y) & "��" & CStr(M) & "��")
                  tNode.Tag = "��"
                Catch ex As Exception
                  MessageBox.Show(ex.Message.ToString)
                End Try

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''��
                Ds = Date.DaysInMonth(Y, M)
                Di = 0
                For D = 1 To Ds
                  .Filter = ""
                  FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID<> 0 AND SaveID= 0 AND SaveDate= " & CStr(Y) & "-" & CStr(M) & "-" & CStr(D)
                  .Filter = FS
                  If .RecordCount > 0 Then
                    Try
                      S = CStr(Y) & "��" & CStr(M) & "��" & CStr(D) & "��"
                      tNode = (TV.Nodes(k).Nodes(Mi).Nodes.Add(S))
                      tNode.Tag = "��"
                      LastDateDB = CDate(S)
                      Di += 1
                    Catch ex As Exception
                      MessageBox.Show(ex.Message.ToString)
                    End Try
                  End If
                Next D
                Mi += 1
              End If
            Next M
            k += 1 '��¼�ڼ�����ͷ�ˣ���0��ʼ
          End If
        Next Y

        Dim GoGo As Boolean = False
        While True
          GoGo = False
          Try
            For i = 0 To TV.Nodes.Count - 1
              If TV.Nodes(i).GetNodeCount(False) < 1 Then
                GoGo = True
                TV.Nodes.Remove(TV.Nodes(i))
              End If
            Next
          Catch ex As Exception

          End Try
          If GoGo = False Then Exit While
        End While

        If TV.Nodes.Count > 0 Then
          TV.Nodes(TV.Nodes.Count - 1).Expand()
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''��ȡ���һ��ļ�¼��Ŀ
        Dim NNo As Integer
        .Filter = ""
        If LastDateDB <> CDate(NoDate_DB) Then
          i = TV.GetNodeCount(False)
          '[[[[[[[[[[[[չ�������һ���ڵ�[[[[[[[[[[[[[[[[[[[[
          If i > 0 Then
            tNode = TV.Nodes(i - 1)
            NNo = tNode.GetNodeCount(False)
            While NNo > 0
              tNode.Expand()
              tNode = tNode.Nodes(NNo - 1)
              NNo = tNode.GetNodeCount(False)
            End While

          Else
            Exit Function
          End If
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          j = TV.Nodes(i - 1).GetNodeCount(False)
          If j > 0 Then
            TV.Nodes(i - 1).Nodes(j - 1).Expand()
            k = TV.Nodes(i - 1).Nodes(j - 1).GetNodeCount(False)
            If k > 0 Then
              S = TV.Nodes(i - 1).Nodes(j - 1).Nodes(k - 1).Text
              'LabelInfo.Text = "ѡ���ˣ�" & S
              SelectDate = CDate(S)
              SelectDateString = TV.Nodes(i - 1).Nodes(j - 1).Nodes(k - 1).Tag
              'LblDateMsg.Text = S'''''�ŵ��������еĶ����ݻ��������ߵĺ�����
            End If
          End If

          '  FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID<> 0 AND SaveID= 0 AND SaveDate= " & S
          '  Try
          '    .Filter = FS
          '    If .RecordCount > 0 Then
          '      For i = 1 To .Fields("SaveAllID").Value
          '        .Filter = ""
          '        FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= " & CStr(i) & " AND SaveDate= " & S
          '        Try
          '          .Filter = FS
          '          If .RecordCount > 0 Then
          '            j = ListBox1.Items.Count
          '            If Not (IsDBNull(.Fields("SaveTime").Value)) Then
          '              ListBox1.Items.Add("��" & CStr(j + 1) & "���洢��ʱ�䣺" & CStr(.Fields("SaveTime").Value))
          '            End If
          '            If Not (IsDBNull(.Fields("SaveTime").Value)) Then
          '              ComboBox1.Items.Add(CStr(.Fields("SaveTime").Value))
          '            End If

          '          End If
          '        Catch ex As Exception
          '          MessageBox.Show(ex.Message.ToString)
          '        End Try
          '      Next i
          '    End If
          '  Catch ex As Exception
          '    MessageBox.Show(ex.Message.ToString)
          '  End Try

        End If

      End With

      Rst.Close()
      Rst = Nothing
      Ado.Close()
      Ado = Nothing

    Catch ex As Exception
      MessageBox.Show("��ȡ���ݿ�ʱ��������:" & ex.Message.ToString)
    End Try

    'Dim GoGo As Boolean = False
    'While True
    '  GoGo = False
    '  Try
    '    For i = 0 To TV.Nodes.Count - 1
    '      If TV.Nodes(i).GetNodeCount(False) < 1 Then
    '        GoGo = True
    '        TV.Nodes.Remove(TV.Nodes(i))
    '      End If
    '    Next
    '  Catch ex As Exception

    '  End Try
    '  If GoGo = False Then Exit While
    'End While

  End Function

  Private Sub SetTreeSelectStation(ByVal TV As TreeView)
    Dim i, j As Integer
    Dim tmpNode As New TreeNode
    With TV
      .Nodes.Clear()
      For i = 1 To CW.MapAmount
        tmpNode = .Nodes.Add(CW.Maps(i).MapName)
        tmpNode.Tag = i.ToString
        For j = 1 To CW.Maps(i).MapStationPlacedAmount
          tmpNode = .Nodes(i - 1).Nodes.Add(CW.Maps(i).Stations(j).StationName)
          tmpNode.Tag = i.ToString & String_Separator & j.ToString
        Next j
      Next i

      Try
        If .Nodes.Count > 0 Then
          For i = 0 To TV.Nodes.Count - 1
            .Nodes(i).Expand()
          Next
          If .Nodes(0).Nodes.Count > 0 Then
            SelectStation = New Point(1, 1)
            Setting_ChkLst_SelectPars(True)
            'lblStationMsg.Text = CW.Maps(1).MapName & "��" & CW.Maps(1).Stations(1).StationName''''''''''''''�ŵ��������еĶ����ݻ��������ߵĺ�����
          End If
        End If
      Catch ex As Exception

      End Try


    End With

  End Sub

  Private Sub SetLocation()
    bSetLocationRun = True
    Me.Location = New Point(0, 0)
    CheckBoxTChartLine.Checked = True
    CW.TChartSeriesType = TeeChart.ESeriesClass.scLine
    CheckBoxTChart3D.Checked = True
    bSetLocationRun = False
  End Sub

  Private Sub Form10FlexTChart_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    CW.bForm10FlexTChart_runing = False
  End Sub

  Private Sub Form10FlexTChart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim S As String
    S = CW.WorkPath & "\PrintLTime6.grf"
    Try
      GRDM.LoadFromFile(S)
    Catch ex As Exception

    End Try


    CW.bForm10FlexTChart_runing = True
    SetFN()
    SetLocation()
    SetTreeSelectStation(TreeSelectStation)
    ShowDB(TreeSelectDate)
    bBuildCDMain = BuildCDMain(CDMain)
    InitializingFlexMain(FlexMain, True)
    DrawFlexTChart()
  End Sub

  Private Sub BtnReCDMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReCDMain.Click
    SetTreeSelectStation(TreeSelectStation)
    ShowDB(TreeSelectDate)
    BuildCDMain(CDMain)
    InitializingFlexMain(FlexMain, True)
    DrawFlexTChart()
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    Me.Close()
  End Sub

  Private Sub CheckBoxTChart3D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTChart3D.CheckedChanged
    If bSetLocationRun Then Exit Sub
    'If bSetWorkAllRun Then Exit Sub
    With TChartMain
      .Aspect.View3D = CheckBoxTChart3D.Checked
      '.Rotation = 60
      '.Elevation = 60
      '.Axis.DrawAxesBeforeSeries = CheckBoxTChart3D.Checked
      '.Repaint()'���ʹSeriesType�ָ�ԭ���ģ�����ֻ���ػ�
      InitializingTChartMain(TChartMain, MyCD, CW.TChartSeriesType)
    End With
  End Sub

  Private Sub CheckBoxTChartY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTChartY.CheckedChanged
    If bSetLocationRun Then Exit Sub
    With TChartMain
      If CheckBoxTChartY.Checked Then
        Try
          .Axis.Left.SetMinMax(TCB.AxixLeftMin, SetTChartMinMax.Y + 1)
        Catch ex As Exception
          MessageBox.Show(ex.Message)
        End Try

      Else
        .Axis.Left.SetMinMax(SetTChartMinMax.X - 1, SetTChartMinMax.Y + 1)
      End If
      .Repaint()
    End With
  End Sub

  Private Sub CheckBoxTChartLine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTChartLine.CheckedChanged
    If bSetLocationRun Then Exit Sub
    'If bSetWorkAllRun Then Exit Sub

    Dim TSeriesType As Integer
    Try
      With TChartMain
        If .SeriesCount > 1 Then
          If .Series(2).SeriesType = TeeChart.ESeriesClass.scFastLine Then '��ʼ�������2����Ϊǰ���иߵ�����
            TSeriesType = TeeChart.ESeriesClass.scLine
            CheckBoxTChart3D.Checked = True
            CheckBoxTChartLine.Checked = True
          Else
            TSeriesType = TeeChart.ESeriesClass.scFastLine
            CheckBoxTChartLine.Checked = False
          End If
          CW.TChartSeriesType = TSeriesType
          InitializingTChartMain(TChartMain, MyCD, TSeriesType)
        End If
        'j = .SeriesCount
        'For i = 0 To j - 1
        '  .Series(i).m()
        'Next i
      End With
    Catch ex As Exception

    End Try

  End Sub
  Private Sub Setting_ChkLst_SelectPars(ByVal CheckEd As Boolean)
    Dim i As Integer
    With ChkLst_SelectPars
      .Items.Clear()
      For i = 1 To CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameterAmount
        .Items.Add(CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationParameters(i, 0))
        .SetItemChecked(.Items.Count - 1, CheckEd)
      Next i
    End With
  End Sub
  Private Sub TreeSelectStation_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeSelectStation.AfterSelect

    Me.SelectStation = New Point(-1, -1)

    Dim S, SS1, SS2 As String
    SS1 = ""
    SS2 = ""
    S = e.Node.Tag
    Dim i, j As Integer
    i = CheckString(S, String_Separator, "O", 1, SS1)

    Select Case i
      Case 1
        CheckString(S, String_Separator, "R", 1, SS1)
        If IsNumeric(SS1) Then
          j = CSng(SS1)
          Me.SelectStation = New Point(j, -1)

          '''''''''''''''''''''''''''''''ѡ���˵�ͼ�Ļ��ͳ�Ϊѡ���ͼ�ĵ�һ��վ
          If CW.Maps(j).MapStationPlacedAmount > 0 Then
            Me.SelectStation = New Point(j, 1)
            Setting_ChkLst_SelectPars(True)
          End If

          S = String.Format("ѡ���ˣ���ͼ{0}��{1}", j.ToString, CW.Maps(j).MapName)
        End If
      Case 2
        CheckString(S, String_Separator, "R", 1, SS1)
        CheckString(S, String_Separator, "R", 2, SS2)
        If IsNumeric(SS1) And IsNumeric(SS2) Then
          Me.SelectStation = New Point(CSng(SS1), CSng(SS2))
          Setting_ChkLst_SelectPars(True)
          S = String.Format("ѡ���ˣ���ͼ��{0} վ{1}��{2}", CW.Maps(Me.SelectStation.X).MapName, SS1, CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationName)
        End If
    End Select

    DrawFlexTChart()

  End Sub

  Private Sub TreeSelectDate_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeSelectDate.AfterSelect
    Try
      Me.SelectDate = CDate(e.Node.Text)
      Me.SelectDateString = e.Node.Tag

      DrawFlexTChart()

    Catch ex As Exception

    End Try

  End Sub

  Private Function BuildShowCD(ByVal MyCD As MyClassData) As Boolean
    BuildShowCD = False
    Dim SQLString As String
    Dim sASCDESC As String
    SQLString = BuildSelectString(Me.SelectStation, Me.SelectDate, Me.SelectDateString)
    sASCDESC = "StationID ASC,TestDate ASC,TestTime ASC"

    With MyCD
      Try
        .DataRows = CDMain.DataTable.Select(SQLString, sASCDESC)
        BuildShowCD = True
      Catch ex As Exception
        Exit Function
      End Try

    End With
  End Function

  Private Sub DrawFlexTChart()
    '''''''ֻ��Ӧ��վѡ����»���
    If bBuildCDMain = False Then Exit Sub
    If (Me.SelectStation.X < 0) Then Exit Sub
    If (Me.SelectStation.Y < 0) Then Exit Sub
    If Me.SelectDateString.Trim = "��" Then Exit Sub

    LblDateMsg.Text = ""
    lblStationMsg.Text = ""
    Dim S As String

    Select Case Me.SelectDateString.Trim
      Case "��"
        S = Me.SelectDate.Year.ToString & "��" & Me.SelectDate.Month.ToString & "��"
        LblDateMsg.Text = S
      Case "��"
        LblDateMsg.Text = Me.SelectDate.Year.ToString & "��" & Me.SelectDate.Month.ToString & "��" & Me.SelectDate.Day.ToString & "��"
    End Select

    lblStationMsg.Text = "��ͼ" & Me.SelectStation.X.ToString & "��" & CW.Maps(Me.SelectStation.X).MapName & "  վ��" & Me.SelectStation.Y & "��" & CW.Maps(Me.SelectStation.X).Stations(Me.SelectStation.Y).StationName

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''�������������
    If BuildShowCD(MyCD) = False Then Exit Sub
    InitializingFlexMain(FlexMain, MyCD, True)
    InitializingTChartMain(TChartMain, MyCD, CW.TChartSeriesType)
    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Ȼ���γɱ���]]]]]]]]]]]]]]
    '�������Ĳ��ã����������ӡ����ť��ʱ���ٸ��ݵ�ǰMyCD�γɱ���
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

  End Sub

  Private Sub Btn_ChkLst_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ChkLst_All.Click
    If ChkLst_SelectPars.Items.Count > 0 Then
      Setting_ChkLst_SelectPars(True)
      DrawFlexTChart()
    End If
  End Sub

  Private Sub Btn_ChkLst_None_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ChkLst_None.Click
    If ChkLst_SelectPars.Items.Count > 0 Then
      Setting_ChkLst_SelectPars(False)
      DrawFlexTChart()
    End If
  End Sub

  Private Sub ChkLst_SelectPars_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLst_SelectPars.SelectedIndexChanged
    DrawFlexTChart()
  End Sub

  Private Sub LabelTmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelTmp.Click
    'Dim D As Date = Now
    'D = Date.FromOADate(2000.45674)
  End Sub


  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    If Me.SelectDateString.Trim = "��" Then Exit Sub
    GRDM.PrintPreview(True)
  End Sub


#Region " ������ش��롣 "

 

  Private Function BuildPrintDataRows(ByRef MyTable As Data.DataTable) As Boolean

    'Dim S1, S2 As String
    'S2 = FN.StationID & " ASC," & FN.FamilyID & " ASC"

    'S1 = BuildSelectString(SelectSFToPrint, SelectDate, BSSM.AtmosphereTemp)
    'MyCD.DataRows_AtmosphereTemp = Form1Main.CDMain.DataTable.Select(S1, S2)

    'S1 = BuildSelectString(SelectSFToPrint, SelectDate, BSSM.Standard)
    'MyCD.DataRows = Form1Main.CDMain.DataTable.Select(S1, S2)

    'S1 = BuildSelectString(SelectSFToPrint, SelectDate, BSSM.OutBackWaterTemp)
    'S2 = FN.StationID & " ASC," & FN.FamilyID & " DESC"
    'MyCD.DataRows_OutBackWaterTemp = Form1Main.CDMain.DataTable.Select(S1, S2)

    ''GRDM.PrintPreview(True) ''��һ��


  End Function

  Private Sub GRDM_Initialize() Handles GRDM.Initialize
    ''�ڶ���

    Dim MyStaticBox As IGRStaticBox
    Try
      MyStaticBox = GRDM.ControlByName("StaticBoxTitle")
      MyStaticBox.Text = CW.WorkName & " ��վ���ݱ���"
    Catch ex As Exception

    End Try

    Try
      MyStaticBox = GRDM.ControlByName("StaticBoxPrintUser")
      MyStaticBox.Text = "��ӡ�ˣ�" & ActivePerson.Name
    Catch ex As Exception

    End Try

    Try
      MyStaticBox = GRDM.ControlByName("StaticBoxPrintTime")
      MyStaticBox.Text = "��ӡʱ�䣺" & CStr(Today.Date) & " " & CStr(TimeOfDay)
    Catch ex As Exception

    End Try

    Try
      MyStaticBox = GRDM.ControlByName("StaticBoxMapInfo")
      MyStaticBox.Text = "��ͼ��" & CW.Maps(SelectStation.X).MapName
    Catch ex As Exception

    End Try

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[��ӡ��Χ[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    'Dim S As String = ""
    'With SelectSFToPrint
    '  If .X < 0 Then
    '    S = "ȫ��վ��ͼ�ͥ"
    '  ElseIf .X > 0 And .Y < 0 Then
    '    S = CW.Stations(.X).StationName & " ��ַ:" & CW.Stations(.X).StationAddress & " �绰:" & CW.Stations(.X).StationPhoneNum & " " & FN.TH & ":" & CW.Stations(.X).TH & "T/H " & FN.mm & ":" & CW.Stations(.X).mm & "mm"
    '  ElseIf .X > 0 And .Y > 0 Then
    '    S = CW.Stations(.X).StationName & " " & CW.Stations(.X).Familys(.Y).FamilyManName
    '    S = S & " �绰��" & CW.Stations(.X).Familys(.Y).FamilyPhoneNUM & " ��ַ��" & CW.Stations(.X).Familys(.Y).FamilyAddress
    '  End If
    'End With
    'MyStaticBox.Text = "��ӡ��Χ��" & S
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  End Sub
  Private Structure MatchFieldPairType
    Public grField As IGRField
    Public MatchColumnIndex As Integer
  End Structure
  Private Function FillReportTable(ByVal Report As IGridppReport, ByVal DRs() As DataRow) As Boolean
    Dim i, k, RN, CN As Integer
    Dim S As String
    RN = DRs.GetUpperBound(0)
    If RN < 0 Then
      Exit Function
    End If

    Try
      CN = DRs(0).Table.Columns.Count - 1
    Catch ex As Exception
      'MessageBox.Show(ex.Message)
      Exit Function
    End Try

    'Dim MatchFieldPairs() As MatchFieldPairType
    'ReDim MatchFieldPairs(Math.Min(Report.DetailGrid.Recordset.Fields.Count, DRs(0).Table.Columns.Count))

    ''�����ֶ������������ƽ���ƥ�䣬����DataReader�ֶ���Grid++Report��¼�����ֶ�֮��Ķ�Ӧ��ϵ
    'Dim MatchFieldCount As Integer
    'MatchFieldCount = 0
    'For i = 0 To DRs(0).Table.Columns.Count - 1
    '  Dim fld As IGRField
    '  For Each fld In Report.DetailGrid.Recordset.Fields
    '    If String.Compare(fld.Name, DRs(0).Table.Columns.Item(i).ColumnName, True) = 0 Then
    '      MatchFieldPairs(MatchFieldCount).grField = fld
    '      MatchFieldPairs(MatchFieldCount).MatchColumnIndex = i
    '      MatchFieldCount = MatchFieldCount + 1
    '      Exit For
    '    End If
    '  Next fld
    'Next

    '�� DataTable �е�ÿһ����¼ת����Grid++Report �����ݼ���ȥ
    With Report


      For k = 0 To RN
        .DetailGrid.Recordset.Append()
        '[[[[[[[[[[[[[[[20071013A3-20071028��������[[[[[[[[[[[[[[[[[[[[[[[[[[
        ''ͨ��������飬֤����ʵ���������ݿ�һ���������
        Try
          'Report.DetailGrid.Recordset.Last()
          .DetailGrid.Recordset.Fields("վ������").Value = CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationName
          .DetailGrid.Recordset.Fields("վ���").Value = SelectStation.Y.ToString

          If Not (IsDBNull(DRs(k)("TestDate"))) Then
            S = CStr(DRs(k)("TestDate"))
            .DetailGrid.Recordset.Fields("�������").Value = S
            If Not (IsDBNull(DRs(k)("TestTime"))) Then
              S = CStr(DRs(k)("TestTime"))
              .DetailGrid.Recordset.Fields("���ʱ��").Value = S
            End If
          End If

          For i = 1 To CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationParameterAmount
            If Not (IsDBNull(DRs(k)("ParameterData" & i.ToString))) Then
              S = DRs(k)("ParameterData" & i.ToString) ' & " " & CW.Maps(SelectStation.X).Stations(SelectStation.Y).StationParameters(i, 2)
              .DetailGrid.Recordset.Fields("����" & i.ToString).Value = S
            End If
          Next i

        Catch ex As Exception
          'MessageBox.Show(ex.Message)
        End Try
        ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        .DetailGrid.Recordset.Post()
      Next k
    End With
    '[[[[[[[[[[[[[[[[[[[[[20071028�ó����ˣ�����[[[[[[[[[[[[[[[[[[[[[
    'GridppReportUtility.FillDataRowsToReport(GRDM, MyCD.DataRows)
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  End Function
  Private Sub GRDM_FetchRecord(ByRef pEof As Boolean) Handles GRDM.FetchRecord
    ''������
    FillReportTable(GRDM, MyCD.DataRows)
  End Sub
  Private Sub GRDM_SectionFormat(ByVal pSender As grproLib.IGRSection) Handles GRDM.SectionFormat
    ' ''���Ĳ�
    'Dim i As Integer
    'Dim FontBold As Boolean = False
    'Dim FontItalic As Boolean = False
    'Dim TextColor(23) As System.Drawing.Color
    'Dim BackColor As System.Drawing.Color = System.Drawing.Color.White

    'Dim Cell(23) As IGRColumnContentCell
    'Dim field(23) As IGRField

    'If RadioButtonColor.Checked Then

    '  If (m_pColumnContent Is pSender) Then
    '    For i = 0 To 23
    '      Cell(i) = m_pColumnContent.ContentCells(FN.TimeString(i))
    '      field(i) = GRDM.FieldByName(FN.TimeString(i))
    '      If IsNumeric(field(i).Value) Then
    '        If CSng(field(i).Value) > CW.ColorAlarm.TempHighLineArray(i) Then
    '          TextColor(i) = Color.Blue
    '        ElseIf CSng(field(i).Value) < CW.ColorAlarm.TempLowLineArray(i) Then
    '          TextColor(i) = Color.Red
    '        Else
    '          TextColor(i) = Color.Green
    '        End If
    '      End If
    '      Cell(i).ForeColor = GridppReportUtility.ColorToOleColor(TextColor(i))
    '    Next i
    '  End If

    'Else

    '  If (m_pColumnContent Is pSender) Then
    '    For i = 0 To 23
    '      Cell(i) = m_pColumnContent.ContentCells(FN.TimeString(i))
    '      field(i) = GRDM.FieldByName(FN.TimeString(i))
    '      Cell(i).ForeColor = GridppReportUtility.ColorToOleColor(System.Drawing.Color.Black)
    '    Next i
    '  End If

    'End If

    ''  '��Ϊ��ӡ���״̬ʱ��������ɫʼ��Ϊ��ɫ,����ɫʼ��Ϊ��ɫ
    ''  If (Report.DisplayMode = GRReportDisplayMode.grrdmPrintGenerate) Then
    ''    TextColor = System.Drawing.Color.Black
    ''    BackColor = System.Drawing.Color.White
    ''  End If

  End Sub

#End Region
End Class