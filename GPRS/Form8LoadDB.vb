Public Class Form8LoadDB
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents BtnLoadDB As System.Windows.Forms.Button
  Friend WithEvents BtnExit As System.Windows.Forms.Button
  Friend WithEvents BtnRefresh As System.Windows.Forms.Button
  Friend WithEvents TV As System.Windows.Forms.TreeView
  Friend WithEvents LabelInfo As System.Windows.Forms.Label
  Friend WithEvents BtnPrintLS As System.Windows.Forms.Button
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lstInfo As System.Windows.Forms.ListView
  Friend WithEvents StationName As System.Windows.Forms.ColumnHeader
  Friend WithEvents TestDate As System.Windows.Forms.ColumnHeader
  Friend WithEvents No As System.Windows.Forms.ColumnHeader
  Friend WithEvents CS1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents CS2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents CS3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents CS4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents CS5 As System.Windows.Forms.ColumnHeader
  Friend WithEvents CheckBoxListMap As System.Windows.Forms.CheckBox
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
  Friend WithEvents CS6 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ComboBoxMap As System.Windows.Forms.ComboBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8LoadDB))
    Me.ListBox1 = New System.Windows.Forms.ListBox
    Me.TV = New System.Windows.Forms.TreeView
    Me.BtnLoadDB = New System.Windows.Forms.Button
    Me.BtnExit = New System.Windows.Forms.Button
    Me.BtnRefresh = New System.Windows.Forms.Button
    Me.LabelInfo = New System.Windows.Forms.Label
    Me.BtnPrintLS = New System.Windows.Forms.Button
    Me.ComboBox1 = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lstInfo = New System.Windows.Forms.ListView
    Me.No = New System.Windows.Forms.ColumnHeader
    Me.StationName = New System.Windows.Forms.ColumnHeader
    Me.TestDate = New System.Windows.Forms.ColumnHeader
    Me.CS1 = New System.Windows.Forms.ColumnHeader
    Me.CS2 = New System.Windows.Forms.ColumnHeader
    Me.CS3 = New System.Windows.Forms.ColumnHeader
    Me.CS4 = New System.Windows.Forms.ColumnHeader
    Me.CS5 = New System.Windows.Forms.ColumnHeader
    Me.CS6 = New System.Windows.Forms.ColumnHeader
    Me.CheckBoxListMap = New System.Windows.Forms.CheckBox
    Me.ComboBoxMap = New System.Windows.Forms.ComboBox
    Me.ListView1 = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
    Me.SuspendLayout()
    '
    'ListBox1
    '
    Me.ListBox1.ItemHeight = 12
    Me.ListBox1.Location = New System.Drawing.Point(176, 24)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(180, 112)
    Me.ListBox1.TabIndex = 0
    '
    'TV
    '
    Me.TV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.TV.Location = New System.Drawing.Point(0, 24)
    Me.TV.Name = "TV"
    Me.TV.Size = New System.Drawing.Size(176, 670)
    Me.TV.TabIndex = 3
    '
    'BtnLoadDB
    '
    Me.BtnLoadDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnLoadDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnLoadDB.Image = CType(resources.GetObject("BtnLoadDB.Image"), System.Drawing.Image)
    Me.BtnLoadDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnLoadDB.Location = New System.Drawing.Point(600, 24)
    Me.BtnLoadDB.Name = "BtnLoadDB"
    Me.BtnLoadDB.Size = New System.Drawing.Size(72, 29)
    Me.BtnLoadDB.TabIndex = 49
    Me.BtnLoadDB.Text = "读取"
    Me.BtnLoadDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnExit
    '
    Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
    Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit.Location = New System.Drawing.Point(932, 24)
    Me.BtnExit.Name = "BtnExit"
    Me.BtnExit.Size = New System.Drawing.Size(72, 29)
    Me.BtnExit.TabIndex = 50
    Me.BtnExit.Text = "退出"
    Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnRefresh
    '
    Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
    Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnRefresh.Location = New System.Drawing.Point(692, 24)
    Me.BtnRefresh.Name = "BtnRefresh"
    Me.BtnRefresh.Size = New System.Drawing.Size(72, 29)
    Me.BtnRefresh.TabIndex = 51
    Me.BtnRefresh.Text = "刷新"
    Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'LabelInfo
    '
    Me.LabelInfo.Enabled = False
    Me.LabelInfo.Location = New System.Drawing.Point(364, 24)
    Me.LabelInfo.Name = "LabelInfo"
    Me.LabelInfo.Size = New System.Drawing.Size(204, 112)
    Me.LabelInfo.TabIndex = 53
    '
    'BtnPrintLS
    '
    Me.BtnPrintLS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnPrintLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPrintLS.Image = CType(resources.GetObject("BtnPrintLS.Image"), System.Drawing.Image)
    Me.BtnPrintLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnPrintLS.Location = New System.Drawing.Point(788, 24)
    Me.BtnPrintLS.Name = "BtnPrintLS"
    Me.BtnPrintLS.Size = New System.Drawing.Size(72, 29)
    Me.BtnPrintLS.TabIndex = 54
    Me.BtnPrintLS.Text = "打印"
    Me.BtnPrintLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ComboBox1
    '
    Me.ComboBox1.Location = New System.Drawing.Point(356, 0)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(88, 20)
    Me.ComboBox1.TabIndex = 55
    Me.ComboBox1.Text = "ComboBox1"
    Me.ComboBox1.Visible = False
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(0, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(116, 16)
    Me.Label1.TabIndex = 56
    Me.Label1.Text = "请选择年、月、日："
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(176, 8)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(160, 16)
    Me.Label2.TabIndex = 57
    Me.Label2.Text = "所选择日期的记录："
    '
    'lstInfo
    '
    Me.lstInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstInfo.BackColor = System.Drawing.SystemColors.Info
    Me.lstInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.StationName, Me.TestDate, Me.CS1, Me.CS2, Me.CS3, Me.CS4, Me.CS5, Me.CS6})
    Me.lstInfo.GridLines = True
    Me.lstInfo.Location = New System.Drawing.Point(176, 140)
    Me.lstInfo.MultiSelect = False
    Me.lstInfo.Name = "lstInfo"
    Me.lstInfo.Size = New System.Drawing.Size(839, 554)
    Me.lstInfo.TabIndex = 58
    Me.lstInfo.UseCompatibleStateImageBehavior = False
    Me.lstInfo.View = System.Windows.Forms.View.Details
    '
    'No
    '
    Me.No.Text = "编号"
    Me.No.Width = 38
    '
    'StationName
    '
    Me.StationName.Text = "站点名称"
    Me.StationName.Width = 120
    '
    'TestDate
    '
    Me.TestDate.Text = "检测日期"
    Me.TestDate.Width = 100
    '
    'CS1
    '
    Me.CS1.Text = " 出水温度"
    Me.CS1.Width = 90
    '
    'CS2
    '
    Me.CS2.Text = "出水压力"
    Me.CS2.Width = 90
    '
    'CS3
    '
    Me.CS3.Text = "一号锅炉出水流量"
    Me.CS3.Width = 90
    '
    'CS4
    '
    Me.CS4.Text = "回水温度"
    Me.CS4.Width = 90
    '
    'CS5
    '
    Me.CS5.Text = "回水压力"
    Me.CS5.Width = 90
    '
    'CS6
    '
    Me.CS6.Text = "二号锅炉出水流量"
    Me.CS6.Width = 90
    '
    'CheckBoxListMap
    '
    Me.CheckBoxListMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CheckBoxListMap.Location = New System.Drawing.Point(704, 108)
    Me.CheckBoxListMap.Name = "CheckBoxListMap"
    Me.CheckBoxListMap.Size = New System.Drawing.Size(100, 24)
    Me.CheckBoxListMap.TabIndex = 59
    Me.CheckBoxListMap.Text = "只显示地图："
    '
    'ComboBoxMap
    '
    Me.ComboBoxMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxMap.Location = New System.Drawing.Point(808, 108)
    Me.ComboBoxMap.Name = "ComboBoxMap"
    Me.ComboBoxMap.Size = New System.Drawing.Size(196, 20)
    Me.ComboBoxMap.TabIndex = 60
    '
    'ListView1
    '
    Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListView1.BackColor = System.Drawing.SystemColors.Info
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
    Me.ListView1.GridLines = True
    Me.ListView1.Location = New System.Drawing.Point(344, 170)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(832, 554)
    Me.ListView1.TabIndex = 61
    Me.ListView1.UseCompatibleStateImageBehavior = False
    Me.ListView1.View = System.Windows.Forms.View.Details
    Me.ListView1.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "编号"
    Me.ColumnHeader1.Width = 38
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "站点名称"
    Me.ColumnHeader2.Width = 120
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "检测日期"
    Me.ColumnHeader3.Width = 100
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "一供压"
    Me.ColumnHeader4.Width = 50
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "一供温"
    Me.ColumnHeader5.Width = 50
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "二供压"
    Me.ColumnHeader6.Width = 50
    '
    'ColumnHeader7
    '
    Me.ColumnHeader7.Text = "二供温"
    Me.ColumnHeader7.Width = 50
    '
    'ColumnHeader8
    '
    Me.ColumnHeader8.Text = "二回压"
    Me.ColumnHeader8.Width = 50
    '
    'ColumnHeader9
    '
    Me.ColumnHeader9.Text = "二回温"
    Me.ColumnHeader9.Width = 50
    '
    'ColumnHeader10
    '
    Me.ColumnHeader10.Text = "一回压"
    Me.ColumnHeader10.Width = 50
    '
    'ColumnHeader11
    '
    Me.ColumnHeader11.Text = "一回温"
    Me.ColumnHeader11.Width = 50
    '
    'ColumnHeader12
    '
    Me.ColumnHeader12.Text = "补水流量"
    '
    'ColumnHeader13
    '
    Me.ColumnHeader13.Text = "供热流量"
    '
    'Form8LoadDB
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(1016, 696)
    Me.Controls.Add(Me.ComboBoxMap)
    Me.Controls.Add(Me.lstInfo)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.BtnPrintLS)
    Me.Controls.Add(Me.LabelInfo)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.BtnRefresh)
    Me.Controls.Add(Me.BtnExit)
    Me.Controls.Add(Me.BtnLoadDB)
    Me.Controls.Add(Me.TV)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.CheckBoxListMap)
    Me.Controls.Add(Me.ListView1)
    Me.Name = "Form8LoadDB"
    Me.Text = "查询数据"
    Me.ResumeLayout(False)

  End Sub

#End Region
  Dim dsReport As New DataSet
  Dim StrCnnString As String
  Dim StrSQL As String
  Dim oledbCnn As OleDb.OleDbConnection
  Dim daCommand As OleDb.OleDbDataAdapter

  Dim SelectDate As String
  Dim LastDateDB As Date '数据库中最后有数据的一天

  Private Sub SetLocation()
    Dim i As Integer
    For i = 1 To CW.MapAmount
      ComboBoxMap.Items.Add(CW.Maps(i).MapName)
    Next i
    If ComboBoxMap.Items.Count > 0 Then
      ComboBoxMap.SelectedIndex = 0
    End If

    Me.Location = New Point(0, 0)
    BtnPrintLS.Enabled = False

  End Sub
  Private Function ShowDB() As Boolean
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim i, j, k, Years, Y, M, D, Ds, Mi, Di, NNo As Integer
    Dim FS, S As String
    S = ""
    Dim StartDate As Date
    Dim tNode As TreeNode

    SelectDate = ""
    LastDateDB = CDate(NoDate_DB)
    TV.Nodes.Clear()
    ListBox1.Items.Clear()
    ComboBox1.Items.Clear()
    LabelInfo.Text = ""

    StartDate = CDate(LoadDB_StartDate)
    Years = DatePart(DateInterval.Year, Today) - DatePart(DateInterval.Year, StartDate) + 1

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      Rst = Ado.OpenTable("StationInfo")
      With Rst
        k = 0
        For Y = DatePart(DateInterval.Year, StartDate) To DatePart(DateInterval.Year, Today) ''''''''年
          .Filter = ""
          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & Y & "'" & " AND " & "SaveMonth= " & "'" & "" & "'"
          If .RecordCount > 0 Then
            Try
              TV.Nodes.Add(CStr(Y) & "年")
            Catch ex As Exception
            End Try
            Mi = 0
            For M = 1 To 12 ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''月
              .Filter = ""
              FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & Y & "'" & " AND " & "SaveMonth= " & "'" & CStr(M) & "'"
              .Filter = FS
              If .RecordCount > 0 Then
                Try
                  TV.Nodes(k).Nodes.Add(CStr(Y) & "年" & CStr(M) & "月")
                Catch ex As Exception
                  MessageBox.Show(ex.Message.ToString)
                End Try

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''日
                Ds = Date.DaysInMonth(Y, M)
                Di = 0
                For D = 1 To Ds
                  .Filter = ""
                  FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID<> 0 AND SaveID= 0 AND SaveDate= " & CStr(Y) & "-" & CStr(M) & "-" & CStr(D)
                  .Filter = FS
                  If .RecordCount > 0 Then
                    Try
                      S = CStr(Y) & "年" & CStr(M) & "月" & CStr(D) & "日"
                      TV.Nodes(k).Nodes(Mi).Nodes.Add(S)
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
            k += 1 '记录第几个年头了，从0开始
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

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''读取最后一天的记录条目
        .Filter = ""
        If LastDateDB <> CDate(NoDate_DB) Then
          i = TV.GetNodeCount(False)
          '[[[[[[[[[[[[展开数最后一个节点[[[[[[[[[[[[[[[[[[[[
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
              LabelInfo.Text = "选择了：" & S
              SelectDate = S
            End If
          End If

          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID<> 0 AND SaveID= 0 AND SaveDate= " & S
          Try
            .Filter = FS
            If .RecordCount > 0 Then
              For i = 1 To .Fields("SaveAllID").Value
                .Filter = ""
                FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= " & CStr(i) & " AND SaveDate= " & S
                Try
                  .Filter = FS
                  If .RecordCount > 0 Then
                    j = ListBox1.Items.Count
                    If Not (IsDBNull(.Fields("SaveTime").Value)) Then
                      ListBox1.Items.Add("第" & CStr(j + 1) & "条存储于时间：" & CStr(.Fields("SaveTime").Value))
                    End If
                    If Not (IsDBNull(.Fields("SaveTime").Value)) Then
                      ComboBox1.Items.Add(CStr(.Fields("SaveTime").Value))
                    End If

                  End If
                Catch ex As Exception
                  MessageBox.Show(ex.Message.ToString)
                End Try
              Next i
            End If
          Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
          End Try

        End If

      End With

      Rst.Close()
      Rst = Nothing
      Ado.Close()
      Ado = Nothing

    Catch ex As Exception
      MessageBox.Show("读取数据库时发生错误:" & ex.Message.ToString)
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
  Private Function LoadDB(ByVal MyDate As Date, ByVal SaveID As Integer) As Boolean
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim i, MapNo, StationIndex As Integer
    Dim FS, S As String
    Dim bLoaded As Boolean
    bLoaded = False

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      Rst = Ado.OpenTable("StationInfo")
      With Rst
        For MapNo = 1 To CW.MapAmount
          For StationIndex = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            .Filter = ""
            S = CStr(CW.Maps(MapNo).Stations(StationIndex).StationID)
            FS = "StationID= " & "'" & S & "'" & " AND SaveDate= " & CStr(MyDate) & " AND SaveID= " & CStr(SaveID)
            Try
              .Filter = FS
              If .RecordCount > 0 Then
                'If .Fields("HaveData").Value Then
                If .Fields("TestDate").Value <> CDate(NoDate_DB) Then
                  If Not (IsDBNull(.Fields("TestDate").Value)) Then
                    CW.Maps(MapNo).Stations(StationIndex).TestDate = CStr(.Fields("TestDate").Value)
                  End If
                  If Not (IsDBNull(.Fields("TestTime").Value)) Then
                    CW.Maps(MapNo).Stations(StationIndex).TestTime = CStr(.Fields("TestTime").Value)
                  End If
                Else
                  CW.Maps(MapNo).Stations(StationIndex).TestDate = ""
                End If
                If Not (IsDBNull(.Fields("StationIp").Value)) Then
                  CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP = .Fields("StationIp").Value
                End If

                For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                  If Not (IsDBNull(.Fields("ParameterData" & CStr(i)).Value)) Then
                    CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1) = .Fields("ParameterData" & CStr(i)).Value
                  End If

                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                  'If CW.Maps(MapNo).Stations(StationIndex).Alarm = True Then
                  '  CW.Maps(MapNo).Stations(StationIndex).StationGif.ReadGIF(SGif.GifFilePath_Alarm)
                  'Else
                  '  CW.Maps(MapNo).Stations(StationIndex).StationGif.ReadGIF(SGif.GifFilePath_OK)
                  'End If
                  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                Next i
                'End If
                '[[[[[[[[[[[[[[[[[[[[[[[[[[200508012349[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                If .Fields("HaveData").Value Then
                  CW.Maps(MapNo).Stations(StationIndex).HaveData = True
                  CW.Maps(MapNo).Stations(StationIndex).DBed = True
                  CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                  CW.Maps(MapNo).Stations(StationIndex).LookedRevNewData = True
                Else
                  CW.Maps(MapNo).Stations(StationIndex).HaveData = False
                  CW.Maps(MapNo).Stations(StationIndex).DBed = False
                  CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                  CW.Maps(MapNo).Stations(StationIndex).LookedRevNewData = False
                End If
                ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              Else
                CW.Maps(MapNo).Stations(StationIndex).TestDate = ""
                CW.Maps(MapNo).Stations(StationIndex).TestTime = ""
                CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP = ""
                For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                  CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1) = ""
                Next i
                '[[[[[[[[[[[[[[[[[[[[[[[[[[200508012349[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                CW.Maps(MapNo).Stations(StationIndex).HaveData = False
                CW.Maps(MapNo).Stations(StationIndex).DBed = False
                CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                CW.Maps(MapNo).Stations(StationIndex).LookedRevNewData = False
                ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                'If CW.Maps(MapNo).Stations(StationIndex).Alarm = True Then
                '  CW.Maps(MapNo).Stations(StationIndex).StationGif.ReadGIF(SGif.GifFilePath_Alarm)
                'Else
                '  CW.Maps(MapNo).Stations(StationIndex).StationGif.ReadGIF(SGif.GifFilePath_OK)
                'End If
                ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              End If

              LoadDB = True
            Catch ex As Exception
              LoadDB = False
              MessageBox.Show(ex.Message.ToString)
            End Try
          Next StationIndex
        Next MapNo
      End With
    Catch ex As Exception
      LoadDB = False
      MessageBox.Show("Load数据时发生错误：" & ex.Message.ToString)
    End Try
    Rst.Close()
    Ado.Close()
    Rst = Nothing
    Ado = Nothing

  End Function
  Private Sub ReadDB(ByVal MyDate As String)
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim i, j, k As Integer
    Dim FS As String
    ListBox1.Items.Clear()
    ComboBox1.Items.Clear()

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      Rst = Ado.OpenTable("StationInfo")
      With Rst
        FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID<> 0 AND SaveID= 0 AND SaveDate= " & MyDate
        Try
          .Filter = FS
          If .RecordCount > 0 Then
            k = 0
            If Not (IsDBNull(.Fields("SaveAllID").Value)) Then
              k = .Fields("SaveAllID").Value
            End If
            For i = 1 To k
              .Filter = ""
              FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= " & CStr(i) & " AND SaveDate= " & MyDate
              Try
                .Filter = FS
                If .RecordCount > 0 Then
                  j = ListBox1.Items.Count
                  If Not (IsDBNull(.Fields("SaveTime").Value)) Then
                    ListBox1.Items.Add("第" & CStr(j + 1) & "条存储于时间：" & CStr(.Fields("SaveTime").Value))
                  End If
                  If Not (IsDBNull(.Fields("SaveTime").Value)) Then
                    ComboBox1.Items.Add(CStr(.Fields("SaveTime").Value))
                  End If

                End If
              Catch ex As Exception
                'MessageBox.Show(ex.Message.ToString)
              End Try
            Next i
          End If
        Catch ex As Exception
          'MessageBox.Show(ex.Message.ToString)
        End Try
      End With
    Catch ex As Exception
      'MessageBox.Show(ex.Message.ToString)
    End Try
    Rst.Close()
    Ado.Close()
    Rst = Nothing
    Ado = Nothing
  End Sub

  Private Sub ShowCSs(ByVal MapNo As Integer)
    Dim i, j, k, m, LvtCount As Integer
    Dim AddData(12) As String
    Dim Lvt As ListViewItem

    lstInfo.Items.Clear()
    If MapNo = 0 Then
      k = 0
      For i = 1 To CW.MapAmount
        For j = 1 To CW.Maps(i).MapStationPlacedAmount
          k += 1
          For m = 0 To STATION_PROPERTY_MAX_NO + 2
            AddData(m) = ""
          Next m
          AddData(0) = k
          AddData(1) = CW.Maps(i).MapName & ":" & CW.Maps(i).Stations(j).StationName
          AddData(2) = CW.Maps(i).Stations(j).TestDate & " " & CW.Maps(i).Stations(j).TestTime
          For m = 1 To STATION_PROPERTY_MAX_NO
            AddData(m + 2) = CW.Maps(i).Stations(j).StationParameters(m, 1)
          Next m
          Lvt = New ListViewItem(AddData)
          LvtCount = Me.lstInfo.Items.Count
          lstInfo.Items.Insert(LvtCount, Lvt)
        Next j
      Next i
    Else
      If MapNo <= CW.MapAmount Then
        k = 0
        For j = 1 To CW.Maps(MapNo).MapStationPlacedAmount
          k += 1
          For m = 0 To STATION_PROPERTY_MAX_NO + 2
            AddData(m) = ""
          Next m
          AddData(0) = k
          AddData(1) = CW.Maps(MapNo).MapName & ":" & CW.Maps(MapNo).Stations(j).StationName
          AddData(2) = CW.Maps(MapNo).Stations(j).TestDate & " " & CW.Maps(MapNo).Stations(j).TestTime
          For m = 1 To STATION_PROPERTY_MAX_NO
            AddData(m + 2) = CW.Maps(MapNo).Stations(j).StationParameters(m, 1)
          Next m
          Lvt = New ListViewItem(AddData)
          LvtCount = Me.lstInfo.Items.Count
          lstInfo.Items.Insert(LvtCount, Lvt)
        Next j
      End If
    End If
  End Sub

  Private Sub Form8LoadDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SetLocation()
    ShowDB()
    ShowCSs(0)

  End Sub

  Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect
    'Dim Node As New TreeNode
    'Dim MNode As New TreeNode
    'Node = e.Node
    'MNode = Node.Parent
    'If Not (IsNothing(MNode)) Then
    '  MessageBox.Show(MNode.Text & Node.Text)
    'End If
    LabelInfo.Text = "选择了：" & e.Node.Text
    If e.Node.GetNodeCount(False) < 1 Then
      SelectDate = e.Node.Text
      ReadDB(SelectDate)
    End If
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    Me.Close()
  End Sub

  Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
    ShowDB()
    If CheckBoxListMap.Checked Then
      If ComboBoxMap.SelectedIndex >= 0 Then
        ShowCSs(ComboBoxMap.SelectedIndex + 1)
      End If
    Else
      ShowCSs(0)
    End If
  End Sub

  Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    ComboBox1.SelectedIndex = ListBox1.SelectedIndex
    LabelInfo.Text = "选择了：" & SelectDate & " " & ComboBox1.Text
    BtnLoadDB_Click(sender, e)
  End Sub

  Private Sub BtnLoadDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadDB.Click
    If SelectDate <> "" Then
      If ComboBox1.Items.Count > 0 Then
        If ComboBox1.SelectedIndex >= 0 Then
          BtnPrintLS.Enabled = LoadDB(CDate(SelectDate), ComboBox1.SelectedIndex + 1)
          If BtnPrintLS.Enabled Then
            LabelInfo.Text = "数据读取成功，已经发送到主窗口，点击打印按钮可直接打印查询数据。"
            If CheckBoxListMap.Checked Then
              If ComboBoxMap.SelectedIndex >= 0 Then
                ShowCSs(ComboBoxMap.SelectedIndex + 1)
              End If
            Else
              ShowCSs(0)
            End If
          End If
        End If
      End If
    End If
  End Sub

  Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
    'BtnLoadDB_Click(sender, e)
  End Sub

  Private Sub BtnPrintLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintLS.Click
    Dim PF As New Form6PrintLS
    PF.Show()

  End Sub

  Private Sub ComboBoxMap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMap.SelectedIndexChanged
    If CheckBoxListMap.Checked Then
      If ComboBoxMap.SelectedIndex >= 0 Then
        ShowCSs(ComboBoxMap.SelectedIndex + 1)
      End If
    End If
  End Sub

  Private Sub CheckBoxListMap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxListMap.CheckedChanged

    If CheckBoxListMap.Checked Then
      If ComboBoxMap.SelectedIndex >= 0 Then
        ShowCSs(ComboBoxMap.SelectedIndex + 1)
      End If
    Else
      ShowCSs(0)
    End If

  End Sub
End Class
