Public Class Form7SaveDB
  Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

  Public Sub New()
    MyBase.New()

    '�õ����� Windows ���������������ġ�
    InitializeComponent()

    '�� InitializeComponent() ����֮������κγ�ʼ��
    CW.bForm7SaveDB_Runing = True

  End Sub

  '������д dispose ����������б�
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Windows ����������������
  Private components As System.ComponentModel.IContainer

  'ע��: ���¹����� Windows ����������������
  '����ʹ�� Windows ����������޸Ĵ˹��̡�
  '��Ҫʹ�ô���༭���޸�����
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
    Me.Label1.Text = "�����Ѵ��ڵļ�¼��"
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
    Me.GroupBox1.Text = "���Ǳ���"
    '
    'ChkCover
    '
    Me.ChkCover.Location = New System.Drawing.Point(44, 76)
    Me.ChkCover.Name = "ChkCover"
    Me.ChkCover.Size = New System.Drawing.Size(140, 20)
    Me.ChkCover.TabIndex = 56
    Me.ChkCover.Text = "����������վ������"
    '
    'CheckBox1
    '
    Me.CheckBox1.Location = New System.Drawing.Point(44, 56)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(100, 24)
    Me.CheckBox1.TabIndex = 55
    Me.CheckBox1.Text = "ˢ�±���ʱ��"
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("��������", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
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
    Me.Label2.Text = "��Ŀ�ţ�"
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
    Me.BtnSaveOld.Text = "���Ǳ���"
    Me.BtnSaveOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(80, 24)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(120, 16)
    Me.Label3.TabIndex = 50
    Me.Label3.Text = "����ʱ�䣺"
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
    Me.Label8.Text = "����ʱ�䣺"
    '
    'Label9
    '
    Me.Label9.Location = New System.Drawing.Point(8, 28)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(56, 16)
    Me.Label9.TabIndex = 49
    Me.Label9.Text = "��Ŀ�ţ�"
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
    Me.ButtonSaveNew.Text = "ȫ�±���"
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
    Me.GroupBoxSaveOld.Text = "����"
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
    Me.GroupBox2.Text = "�½�����"
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("��������", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
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
    Me.BtnExit.Text = "�˳�"
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
    Me.Text = "��������"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBoxSaveOld.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Dim MyDate As Date
  Dim MyTime As Date
  Dim DBRstAmount As Integer '���������ж�������¼
  Dim TimeArry() As Date '��¼��Ŀ��Ӧ�Ĵ洢ʱ�䣬��1��ʼ

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
          ListBoxSave.Items.Add("���ջ�û�д洢���ݡ�")
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

              ListBoxSave.Items.Add("��" & CStr(i) & "���洢��ʱ�䣺" & CStr(TimeArry(i)))
            Catch ex As Exception
              MessageBox.Show("��ȡ���ݿ�ʱ��������" & ex.Message.ToString)
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
      MessageBox.Show("��ȡ���ݿ�ʱ��������" & ex.Message.ToString)
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
    'ȫ�´洢
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

        For MapNo = 1 To CW.MapAmount ''''''''''''''''''''''''''''''�ô��վ��������
          For StationIndex = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            .Filter = ""
            S = CW.Maps(MapNo).Stations(StationIndex).StationID

            'MyDate = Today ''''''''''��Ҫ�ĸ�ֵ20070207���ŵ���ť���´���
            FS = "StationID= " & "'" & S & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= " & CStr(LabelSaveIDNew.Text)

            '+++++++++++++++++++++++++++++++200508072002��Ӵ��ж�+++++++++++++++
            If CW.Maps(MapNo).Stations(StationIndex).HaveData Then

              .Filter = FS '''''''''''''��ʵ������û�б�ʱ��Ĵ洢�����Ǳ����

              If .RecordCount < 1 Then
                .AddNew()
              End If

              .Fields("StationID").Value = S
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[[[[[[[[[[[[[[
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
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[
              CW.Maps(MapNo).Stations(StationIndex).Saved = True
              CW.Maps(MapNo).Stations(StationIndex).DBed = True
              CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              bSaved = True
            End If
          Next StationIndex
        Next MapNo

        '+++++++++++++++++++++++++++++++200508072002��Ӵ��ж�+++++++++++++++
        If bSaved Then
          '''''''''''''''���¼�¼�ж�������
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

          '[[[[[[[[[���ܲ�����Ҫ��20070207��������Ҫ����վ�Ϳ�����Ҫ��[[[[[[
          .Filter = ""
          .AddNew() ''''''''''''''''''''''''''''''''''��¼�¼ӵ�������Ϣ
          .Fields("StationID").Value = "00000000"
          .Fields("SaveID").Value = CSng(LabelSaveIDNew.Text)
          .Fields("SaveDate").Value = MyDate
          .Fields("SaveTime").Value = LabelSaveTimeNew.Text
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]


          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          '����洢������������ݵı�־
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
            MessageBox.Show("��������������ʱ��������" & ex.Message.ToString)
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
            MessageBox.Show("��������������ʱ��������" & ex.Message.ToString)
          End Try

          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          .UpdateBatch()

        Else
          MessageBox.Show("�����ݿɴ档", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '.Close()
      End With
    Catch ex As Exception
      MessageBox.Show("��������ʱ��������" & ex.Message.ToString)
    End Try
    'Rst.Close()
    Rst = Nothing
    'Ado.Close()
    Ado = Nothing
    If bSaved Then
      MessageBox.Show("���ݱ�����ϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
    Me.Close()
  End Function
  Private Overloads Function SaveDB(ByVal TM As String) As Boolean
    '���Ǵ洢
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

        '''''''''''''''���¼�¼�ж�������
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
        '.AddNew() ''''''''''''''''''''''''''''''''''��¼�¼ӵ�������Ϣ
        '.Fields("StationID").Value = "00000000"
        '.Fields("SaveID").Value = CSng(LabelSaveIDNew.Text)
        '.Fields("SaveDate").Value = MyDate
        '.Fields("SaveTime").Value = LabelSaveTimeNew.Text

        If CheckBox1.Checked Then '�Ƿ񸲸Ǳ���ʱ��
          FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= " & TM
          .Filter = FS
          Try
            .Fields("SaveTime").Value = LabelSaveTimeOld.Text
          Catch ex As Exception
          End Try
        End If

        For MapNo = 1 To CW.MapAmount ''''''''''''''''''''''''''''''�ô��վ��������
          For StationIndex = 1 To CW.Maps(MapNo).MapStationPlacedAmount

            .Filter = ""
            S = CW.Maps(MapNo).Stations(StationIndex).StationID
            FS = "StationID= " & "'" & S & "'" & " And SaveDate= " & CStr(MyDate) & " AND " & "SaveID= " & TM
            .Filter = FS
            i = .RecordCount

            '+++++++++++++++++++++++++++++++200508072002��Ӵ��ж�+++++++++++++++
            If i > 0 Then
              If CW.Maps(MapNo).Stations(StationIndex).HaveData Then '�����ݲŴ�
                bSaved = True
                If .Fields("HaveData").Value Then  '���ݿ����д�վ����
                  If ChkCover.Checked = False Then '�������ǵĻ�,����
                    'If .RecordCount < 1 Then
                    '  .AddNew()
                    'End If
                    .Fields("StationID").Value = S
                    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[[[[[[[[[[[[[[
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
                    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[
                    CW.Maps(MapNo).Stations(StationIndex).Saved = True
                    CW.Maps(MapNo).Stations(StationIndex).DBed = True
                    CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                    'bSaved = True
                  End If

                Else '���ݿ���û�еĻ�������������񶼱���
                  'If .RecordCount < 1 Then
                  '  .AddNew()
                  'End If
                  .Fields("StationID").Value = S
                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[[[[[[[[[[[[[[
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
                  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[
                  CW.Maps(MapNo).Stations(StationIndex).DBed = True
                  CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
                  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
                  bSaved = True
                End If
              Else '����û�����ݵ�վ�㲻����

              End If
            Else '���ݿ���û�е�վ�㣬���۸���������񣬽��������ݱ��棬�����ݲ�����
              If CW.Maps(MapNo).Stations(StationIndex).HaveData Then '�����ݲŴ�
                .AddNew()
                .Fields("StationID").Value = S
                '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[[[[[[[[[[[[[[
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
                '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[
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
          MessageBox.Show("�����ݿɴ档", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        '.Close()
      End With
    Catch ex As Exception
      MessageBox.Show("��������ʱ��������" & ex.Message.ToString)
    End Try
    'Rst.Close()
    Rst = Nothing
    'Ado.Close()
    Ado = Nothing
    If bSaved Then
      MessageBox.Show("���ݱ�����ϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
    Me.Close()
  End Function

  Private Sub Form7SaveDB_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    CW.bForm7SaveDB_Runing = False
  End Sub
  Private Sub Form7SaveDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'MyDate = Today()
    'MyTime = TimeOfDay()'''�õ�ʱ��ֱ�ӵ��ã��ŵ����水ť������һ��
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
