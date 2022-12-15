Public Class Form7SaveDB
  Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

  Public Sub New()
    MyBase.New()

    '该调用是 Windows 窗体设计器所必需的。
    InitializeComponent()

    '在 InitializeComponent() 调用之后添加任何初始化
    CW.bForm7SaveDB_Runing = True

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
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBoxSaveOld As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents BtnSaveOld As System.Windows.Forms.Button
  Friend WithEvents BtnExit As System.Windows.Forms.Button
  Friend WithEvents LabelSaveTimeOld As System.Windows.Forms.Label
  Friend WithEvents LabelSaveTimeNew As System.Windows.Forms.Label
  Friend WithEvents ButtonSaveNew As System.Windows.Forms.Button
  Friend WithEvents LabelSaveIDOld As System.Windows.Forms.Label
  Friend WithEvents LabelSaveIDNew As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents ListBoxSave As System.Windows.Forms.ListBox
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents ChkCover As System.Windows.Forms.CheckBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7SaveDB))
    Me.Label1 = New System.Windows.Forms.Label
    Me.ListBoxSave = New System.Windows.Forms.ListBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.ChkCover = New System.Windows.Forms.CheckBox
    Me.CheckBox1 = New System.Windows.Forms.CheckBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.LabelSaveTimeOld = New System.Windows.Forms.Label
    Me.LabelSaveIDOld = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.BtnSaveOld = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.LabelSaveTimeNew = New System.Windows.Forms.Label
    Me.LabelSaveIDNew = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label9 = New System.Windows.Forms.Label
    Me.ButtonSaveNew = New System.Windows.Forms.Button
    Me.GroupBoxSaveOld = New System.Windows.Forms.GroupBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.BtnExit = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    Me.GroupBoxSaveOld.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(8, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(128, 16)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "今天已存在的记录："
    '
    'ListBoxSave
    '
    Me.ListBoxSave.ItemHeight = 12
    Me.ListBoxSave.Location = New System.Drawing.Point(0, 24)
    Me.ListBoxSave.Name = "ListBoxSave"
    Me.ListBoxSave.Size = New System.Drawing.Size(180, 256)
    Me.ListBoxSave.TabIndex = 2
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.ChkCover)
    Me.GroupBox1.Controls.Add(Me.CheckBox1)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.LabelSaveTimeOld)
    Me.GroupBox1.Controls.Add(Me.LabelSaveIDOld)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.BtnSaveOld)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Location = New System.Drawing.Point(4, 20)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(280, 100)
    Me.GroupBox1.TabIndex = 50
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "覆盖保存"
    '
    'ChkCover
    '
    Me.ChkCover.Location = New System.Drawing.Point(44, 76)
    Me.ChkCover.Name = "ChkCover"
    Me.ChkCover.Size = New System.Drawing.Size(140, 20)
    Me.ChkCover.TabIndex = 56
    Me.ChkCover.Text = "不覆盖已有站点数据"
    '
    'CheckBox1
    '
    Me.CheckBox1.Location = New System.Drawing.Point(44, 56)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(100, 24)
    Me.CheckBox1.TabIndex = 55
    Me.CheckBox1.Text = "刷新保存时间"
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("方正舒体", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.DeepPink
    Me.Label5.Location = New System.Drawing.Point(184, 32)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(84, 24)
    Me.Label5.TabIndex = 54
    Me.Label5.Text = "COVER"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelSaveTimeOld
    '
    Me.LabelSaveTimeOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelSaveTimeOld.Location = New System.Drawing.Point(80, 40)
    Me.LabelSaveTimeOld.Name = "LabelSaveTimeOld"
    Me.LabelSaveTimeOld.Size = New System.Drawing.Size(100, 16)
    Me.LabelSaveTimeOld.TabIndex = 52
    '
    'LabelSaveIDOld
    '
    Me.LabelSaveIDOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelSaveIDOld.Location = New System.Drawing.Point(8, 40)
    Me.LabelSaveIDOld.Name = "LabelSaveIDOld"
    Me.LabelSaveIDOld.Size = New System.Drawing.Size(56, 16)
    Me.LabelSaveIDOld.TabIndex = 51
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(8, 24)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(56, 16)
    Me.Label2.TabIndex = 49
    Me.Label2.Text = "条目号："
    '
    'BtnSaveOld
    '
    Me.BtnSaveOld.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnSaveOld.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSaveOld.Image = CType(resources.GetObject("BtnSaveOld.Image"), System.Drawing.Image)
    Me.BtnSaveOld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnSaveOld.Location = New System.Drawing.Point(184, 60)
    Me.BtnSaveOld.Name = "BtnSaveOld"
    Me.BtnSaveOld.Size = New System.Drawing.Size(88, 29)
    Me.BtnSaveOld.TabIndex = 48
    Me.BtnSaveOld.Text = "覆盖保存"
    Me.BtnSaveOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(80, 24)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(120, 16)
    Me.Label3.TabIndex = 50
    Me.Label3.Text = "保存时间："
    '
    'LabelSaveTimeNew
    '
    Me.LabelSaveTimeNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelSaveTimeNew.Location = New System.Drawing.Point(80, 44)
    Me.LabelSaveTimeNew.Name = "LabelSaveTimeNew"
    Me.LabelSaveTimeNew.Size = New System.Drawing.Size(100, 16)
    Me.LabelSaveTimeNew.TabIndex = 52
    '
    'LabelSaveIDNew
    '
    Me.LabelSaveIDNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelSaveIDNew.Location = New System.Drawing.Point(8, 44)
    Me.LabelSaveIDNew.Name = "LabelSaveIDNew"
    Me.LabelSaveIDNew.Size = New System.Drawing.Size(56, 16)
    Me.LabelSaveIDNew.TabIndex = 51
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(80, 28)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(120, 16)
    Me.Label8.TabIndex = 50
    Me.Label8.Text = "保存时间："
    '
    'Label9
    '
    Me.Label9.Location = New System.Drawing.Point(8, 28)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(56, 16)
    Me.Label9.TabIndex = 49
    Me.Label9.Text = "条目号："
    '
    'ButtonSaveNew
    '
    Me.ButtonSaveNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.ButtonSaveNew.Image = CType(resources.GetObject("ButtonSaveNew.Image"), System.Drawing.Image)
    Me.ButtonSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.ButtonSaveNew.Location = New System.Drawing.Point(184, 48)
    Me.ButtonSaveNew.Name = "ButtonSaveNew"
    Me.ButtonSaveNew.Size = New System.Drawing.Size(88, 29)
    Me.ButtonSaveNew.TabIndex = 48
    Me.ButtonSaveNew.Text = "全新保存"
    Me.ButtonSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'GroupBoxSaveOld
    '
    Me.GroupBoxSaveOld.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBoxSaveOld.Controls.Add(Me.GroupBox2)
    Me.GroupBoxSaveOld.Controls.Add(Me.GroupBox1)
    Me.GroupBoxSaveOld.Location = New System.Drawing.Point(184, 24)
    Me.GroupBoxSaveOld.Name = "GroupBoxSaveOld"
    Me.GroupBoxSaveOld.Size = New System.Drawing.Size(288, 212)
    Me.GroupBoxSaveOld.TabIndex = 49
    Me.GroupBoxSaveOld.TabStop = False
    Me.GroupBoxSaveOld.Text = "保存"
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.Label4)
    Me.GroupBox2.Controls.Add(Me.ButtonSaveNew)
    Me.GroupBox2.Controls.Add(Me.LabelSaveTimeNew)
    Me.GroupBox2.Controls.Add(Me.LabelSaveIDNew)
    Me.GroupBox2.Controls.Add(Me.Label8)
    Me.GroupBox2.Controls.Add(Me.Label9)
    Me.GroupBox2.Location = New System.Drawing.Point(4, 124)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(280, 84)
    Me.GroupBox2.TabIndex = 53
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "新建保存"
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("方正舒体", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
    Me.Label4.Location = New System.Drawing.Point(196, 20)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(72, 24)
    Me.Label4.TabIndex = 53
    Me.Label4.Text = "NEW"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'BtnExit
    '
    Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
    Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit.Location = New System.Drawing.Point(388, 244)
    Me.BtnExit.Name = "BtnExit"
    Me.BtnExit.Size = New System.Drawing.Size(72, 29)
    Me.BtnExit.TabIndex = 47
    Me.BtnExit.Text = "退出"
    Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Form7SaveDB
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(472, 282)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ListBoxSave)
    Me.Controls.Add(Me.BtnExit)
    Me.Controls.Add(Me.GroupBoxSaveOld)
    Me.Name = "Form7SaveDB"
    Me.Text = "保存数据"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBoxSaveOld.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Dim MyDate As Date
  Dim MyTime As Date
  Dim DBRstAmount As Integer '今天数据有多少条记录
  Dim TimeArry() As Date '记录条目对应的存储时间，从1开始

  Private Sub SetLocation()

    'LabelSaveTimeOld.Text = MyTime
    LabelSaveTimeNew.Text = TimeOfDay

    If ListBoxSave.Items.Count > 0 Then
      ListBoxSave.SelectedIndex = 0
    End If

    If DBRstAmount > 0 Then
      LabelSaveIDNew.Text = CStr(DBRstAmount + 1)
    Else
      LabelSaveIDNew.Text = "1"
    End If
  End Sub
  Private Sub ReadDB()
    Dim i As Integer
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim FS As String

    'MyDate = Today()
    'MyTime = TimeOfDay()

    ListBoxSave.Items.Clear()
    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      'strSQL = "StationID=0 AND SaveDate=" & CStr(MyDate)
      Rst = Ado.OpenTable("StationInfo")
      FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= 0"

      With Rst

        .Filter = FS

        If .RecordCount < 1 Then
          DBRstAmount = 0
          ListBoxSave.Items.Add("今日还没有存储数据。")
          .Close()
          Rst = Nothing
          Ado.Close()
          Ado = Nothing

          Exit Sub

        Else
          If Not (IsDBNull(.Fields("SaveAllID").Value)) Then
            DBRstAmount = CSng(.Fields("SaveAllID").Value)
          End If

          ReDim TimeArry(DBRstAmount)
          For i = 1 To DBRstAmount
            .Filter = ""
            FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveDate= " & CStr(MyDate) & " AND SaveID= " & CStr(i)
            Try
              .Filter = FS
              If Not (IsDBNull(.Fields("SaveTime").Value)) Then
                TimeArry(i) = .Fields("SaveTime").Value
              End If

              ListBoxSave.Items.Add("第" & CStr(i) & "条存储于时间：" & CStr(TimeArry(i)))
            Catch ex As Exception
              MessageBox.Show("读取数据库时发生错误：" & ex.Message.ToString)
              .Close()
              Rst = Nothing
              Ado.Close()
              Ado = Nothing
              'Me.Close()
            End Try
          Next i
        End If
      End With
    Catch ex As Exception
      MessageBox.Show("读取数据库时发生错误：" & ex.Message.ToString)
      'Rst.Close()
      Rst = Nothing
      Ado.Close()
      Ado = Nothing
      Me.Close()
    End Try
    'Rst.Close()
    Rst = Nothing
    'Ado.Close()
    Ado = Nothing
  End Sub
  Private Overloads Function SaveDB() As Boolean
    '全新存储
    Dim i, MapNo, StationIndex As Integer
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim FS, S, S1 As String
    Dim bSaved As Boolean
    bSaved = False

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      'strSQL = "StationID=0 AND SaveDate=" & CStr(MyDate)
      Rst = Ado.OpenTable("StationInfo")

      With Rst

        For MapNo = 1 To CW.MapAmount ''''''''''''''''''''''''''''''该存各站点数据了
          For StationIndex = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            .Filter = ""
            S = CW.Maps(MapNo).Stations(StationIndex).StationID

            'MyDate = Today ''''''''''重要的赋值20070207，放到按钮按下处了
            FS = "StationID= " & "'" & S & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= " & CStr(LabelSaveIDNew.Text)

            '+++++++++++++++++++++++++++++++200508072002添加此判断+++++++++++++++
            If CW.Maps(MapNo).Stations(StationIndex).HaveData Then

              .Filter = FS '''''''''''''其实查找有没有本时间的存储条不是必需的

              If .RecordCount < 1 Then
                .AddNew()
              End If

              .Fields("StationID").Value = S
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[[[[[[[[[[[[[[
              .Fields("HaveData").Value = CW.Maps(MapNo).Stations(StationIndex).HaveData
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              .Fields("SaveID").Value = CSng(LabelSaveIDNew.Text)
              .Fields("SaveDate").Value = MyDate
              .Fields("SaveTime").Value = LabelSaveTimeNew.Text

              .Fields("StationName").Value = CW.Maps(MapNo).Stations(StationIndex).StationName

              S = CW.Maps(MapNo).Stations(StationIndex).TestDate
              If S = "" Then
                .Fields("TestDate").Value = CDate(NoDate_DB)
              Else
                .Fields("TestDate").Value = CDate(S)
                .Fields("TestTime").Value = CW.Maps(MapNo).Stations(StationIndex).TestTime
              End If

              .Fields("StationIp").Value = CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP
              For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                .Fields("ParameterData" & CStr(i)).Value = CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1)
              Next i
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[
              CW.Maps(MapNo).Stations(StationIndex).Saved = True
              CW.Maps(MapNo).Stations(StationIndex).DBed = True
              CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              bSaved = True
            End If
          Next StationIndex
        Next MapNo

        '+++++++++++++++++++++++++++++++200508072002添加此判断+++++++++++++++
        If bSaved Then
          '''''''''''''''更新记录有多少条了
          FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= 0"
          .Filter = ""
          .Filter = FS

          If .RecordCount < 1 Then
            .AddNew()
            .Fields("StationID").Value = "00000000"
            .Fields("SaveID").Value = 0
            .Fields("SaveDate").Value = MyDate
          End If
          Try
            .Fields("SaveAllID").Value = CSng(LabelSaveIDNew.Text)
          Catch ex As Exception
          End Try

          '[[[[[[[[[可能并不需要，20070207；还是需要，多站就看出需要了[[[[[[
          .Filter = ""
          .AddNew() ''''''''''''''''''''''''''''''''''记录新加的条的信息
          .Fields("StationID").Value = "00000000"
          .Fields("SaveID").Value = CSng(LabelSaveIDNew.Text)
          .Fields("SaveDate").Value = MyDate
          .Fields("SaveTime").Value = LabelSaveTimeNew.Text
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]


          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          '下面存储年和月有无数据的标志
          .Filter = ""
          S = CStr(DatePart(DateInterval.Year, MyDate))
          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & S & "'" & " AND " & "SaveMonth= " & "'" & "" & "'"
          Try
            .Filter = FS
            If .RecordCount < 1 Then
              .AddNew()
            End If
            .Fields("StationID").Value = "00000000"
            .Fields("SAveAllID").Value = 0
            .Fields("SaveID").Value = 0
            .Fields("SaveYear").Value = S
            .Fields("SaveMonth").Value = ""
          Catch ex As Exception
            MessageBox.Show("保存年索引数据时发生错误：" & ex.Message.ToString)
          End Try

          .Filter = ""
          S1 = CStr(DatePart(DateInterval.Month, MyDate))
          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & S & "'" & " AND " & "SaveMonth= " & "'" & S1 & "'"
          Try
            .Filter = FS
            If .RecordCount < 1 Then
              .AddNew()
            End If
            .Fields("StationID").Value = "00000000"
            .Fields("SAveAllID").Value = 0
            .Fields("SaveID").Value = 0
            .Fields("SaveYear").Value = S
            .Fields("SaveMonth").Value = S1
          Catch ex As Exception
            MessageBox.Show("保存月索引数据时发生错误：" & ex.Message.ToString)
          End Try

          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          .UpdateBatch()

        Else
          MessageBox.Show("无数据可存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '.Close()
      End With
    Catch ex As Exception
      MessageBox.Show("保存数据时发生错误：" & ex.Message.ToString)
    End Try
    'Rst.Close()
    Rst = Nothing
    'Ado.Close()
    Ado = Nothing
    If bSaved Then
      MessageBox.Show("数据保存完毕。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
    Me.Close()
  End Function
  Private Overloads Function SaveDB(ByVal TM As String) As Boolean
    '覆盖存储
    If TM = "" Then
      SaveDB()
      Exit Function
    End If
    Dim i, MapNo, StationIndex As Integer
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim FS, S As String
    Dim bSaved As Boolean
    bSaved = False

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataMDB_FileName)
      'strSQL = "StationID=0 AND SaveDate=" & CStr(MyDate)
      Rst = Ado.OpenTable("StationInfo")

      With Rst

        '''''''''''''''更新记录有多少条了
        'FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= 0"
        '.Filter = ""
        '.Filter = FS

        'If .RecordCount < 1 Then
        '  .AddNew()
        '  .Fields("StationID").Value = "00000000"
        '  .Fields("SaveID").Value = 0
        '  .Fields("SaveDate").Value = MyDate
        'End If
        'Try
        '  .Fields("SaveAllID").Value = CSng(LabelSaveIDOld.Text)
        'Catch ex As Exception
        'End Try

        '.Filter = ""
        '.AddNew() ''''''''''''''''''''''''''''''''''记录新加的条的信息
        '.Fields("StationID").Value = "00000000"
        '.Fields("SaveID").Value = CSng(LabelSaveIDNew.Text)
        '.Fields("SaveDate").Value = MyDate
        '.Fields("SaveTime").Value = LabelSaveTimeNew.Text

        If CheckBox1.Checked Then '是否覆盖保存时间
          FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= " & TM
          .Filter = FS
          Try
            .Fields("SaveTime").Value = LabelSaveTimeOld.Text
          Catch ex As Exception
          End Try
        End If

        For MapNo = 1 To CW.MapAmount ''''''''''''''''''''''''''''''该存各站点数据了
          For StationIndex = 1 To CW.Maps(MapNo).MapStationPlacedAmount

            .Filter = ""
            S = CW.Maps(MapNo).Stations(StationIndex).StationID
            FS = "StationID= " & "'" & S & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= " & TM
            .Filter = FS
            i = .RecordCount

            '+++++++++++++++++++++++++++++++200508072002添加此判断+++++++++++++++
            If i > 0 Then
              If CW.Maps(MapNo).Stations(StationIndex).HaveData Then '有数据才存
                bSaved = True
                If .Fields("HaveData").Value Then  '数据库中有此站数据
                  If ChkCover.Checked = False Then '并容许覆盖的话,保存
                    'If .RecordCount < 1 Then
                    '  .AddNew()
                    'End If
                    .Fields("StationID").Value = S
                    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[[[[[[[[[[[[[[
                    .Fields("HaveData").Value = True
                    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                    .Fields("SaveID").Value = TM
                    .Fields("SaveDate").Value = MyDate

                    .Fields("SaveTime").Value = LabelSaveTimeNew.Text

                    .Fields("StationName").Value = CW.Maps(MapNo).Stations(StationIndex).StationName

                    S = CW.Maps(MapNo).Stations(StationIndex).TestDate
                    If S = "" Then
                      .Fields("TestDate").Value = CDate(NoDate_DB)
                    Else
                      .Fields("TestDate").Value = CDate(S)
                      .Fields("TestTime").Value = CW.Maps(MapNo).Stations(StationIndex).TestTime
                    End If

                    .Fields("StationIp").Value = CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP
                    For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                      .Fields("ParameterData" & CStr(i)).Value = CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1)
                    Next i
                    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[
                    CW.Maps(MapNo).Stations(StationIndex).Saved = True
                    CW.Maps(MapNo).Stations(StationIndex).DBed = True
                    CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                    'bSaved = True
                  End If

                Else '数据库中没有的话无论容许覆盖与否都保存
                  'If .RecordCount < 1 Then
                  '  .AddNew()
                  'End If
                  .Fields("StationID").Value = S
                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[[[[[[[[[[[[[[
                  .Fields("HaveData").Value = CW.Maps(MapNo).Stations(StationIndex).HaveData
                  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                  .Fields("SaveID").Value = TM
                  .Fields("SaveDate").Value = MyDate

                  .Fields("SaveTime").Value = LabelSaveTimeNew.Text

                  .Fields("StationName").Value = CW.Maps(MapNo).Stations(StationIndex).StationName

                  S = CW.Maps(MapNo).Stations(StationIndex).TestDate
                  If S = "" Then
                    .Fields("TestDate").Value = CDate(NoDate_DB)
                  Else
                    .Fields("TestDate").Value = CDate(S)
                    .Fields("TestTime").Value = CW.Maps(MapNo).Stations(StationIndex).TestTime
                  End If

                  .Fields("StationIp").Value = CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP
                  For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                    .Fields("ParameterData" & CStr(i)).Value = CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1)
                  Next i
                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[
                  CW.Maps(MapNo).Stations(StationIndex).DBed = True
                  CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                  bSaved = True
                End If
              Else '界面没有数据的站点不保存

              End If
            Else '数据库中没有的站点，无论覆盖容许与否，界面有数据保存，无数据不保存
              If CW.Maps(MapNo).Stations(StationIndex).HaveData Then '有数据才存
                .AddNew()
                .Fields("StationID").Value = S
                '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[[[[[[[[[[[[[[
                .Fields("HaveData").Value = True
                ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                .Fields("SaveID").Value = TM
                .Fields("SaveDate").Value = MyDate

                .Fields("SaveTime").Value = LabelSaveTimeNew.Text

                .Fields("StationName").Value = CW.Maps(MapNo).Stations(StationIndex).StationName

                S = CW.Maps(MapNo).Stations(StationIndex).TestDate
                If S = "" Then
                  .Fields("TestDate").Value = CDate(NoDate_DB)
                Else
                  .Fields("TestDate").Value = CDate(S)
                  .Fields("TestTime").Value = CW.Maps(MapNo).Stations(StationIndex).TestTime
                End If

                .Fields("StationIp").Value = CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP
                For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                  .Fields("ParameterData" & CStr(i)).Value = CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1)
                Next i
                '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002添加[[[[[[[[[[[[[[
                CW.Maps(MapNo).Stations(StationIndex).DBed = True
                CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                bSaved = True

              End If
            End If

          Next StationIndex
        Next MapNo

        If bSaved Then
          .UpdateBatch()
        Else
          MessageBox.Show("无数据可存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        '.Close()
      End With
    Catch ex As Exception
      MessageBox.Show("保存数据时发生错误：" & ex.Message.ToString)
    End Try
    'Rst.Close()
    Rst = Nothing
    'Ado.Close()
    Ado = Nothing
    If bSaved Then
      MessageBox.Show("数据保存完毕。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
    Me.Close()
  End Function

  Private Sub Form7SaveDB_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    CW.bForm7SaveDB_Runing = False
  End Sub
  Private Sub Form7SaveDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'MyDate = Today()
    'MyTime = TimeOfDay()'''用的时候直接调用，放到保存按钮按下那一刻
    ChkCover.Checked = True

    MyDate = Today()
    MyTime = TimeOfDay()
    ReadDB()

    SetLocation()
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    Me.Close()
  End Sub

  Private Sub ListBoxSave_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxSave.SelectedIndexChanged
    If DBRstAmount > 0 Then
      LabelSaveIDOld.Text = CStr(ListBoxSave.SelectedIndex + 1)
      If Not CheckBox1.Checked Then
        LabelSaveTimeOld.Text = TimeArry(ListBoxSave.SelectedIndex + 1)
      End If
    End If
  End Sub

  Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
    If Not CheckBox1.Checked Then
      LabelSaveTimeOld.Text = TimeArry(ListBoxSave.SelectedIndex + 1)
    Else
      LabelSaveTimeOld.Text = CStr(MyTime)
    End If
  End Sub

  Private Sub ButtonSaveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveNew.Click
    MyDate = Today()
    MyTime = TimeOfDay()
    SaveDB()
  End Sub

  Private Sub BtnSaveOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveOld.Click
    MyDate = Today()
    MyTime = TimeOfDay()
    SaveDB(LabelSaveIDOld.Text)
  End Sub
End Class
