Imports grproLib
Imports System.Data
Imports System.Data.OleDb
Public Class Form6PrintLS
  Inherits System.Windows.Forms.Form
  '定义Grid++Report报表主对象
  Private WithEvents Report As New GridppReport

  Private m_pNameField As IGRField
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
  Friend WithEvents ButtonPrintPerview As System.Windows.Forms.Button
  Friend WithEvents BtnExit As System.Windows.Forms.Button
  Friend WithEvents RadioButtonOneMap As System.Windows.Forms.RadioButton
  Friend WithEvents ComboBoxselectMap As System.Windows.Forms.ComboBox
  Friend WithEvents RadioButtonAllMap As System.Windows.Forms.RadioButton
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form6PrintLS))
    Me.ButtonPrintPerview = New System.Windows.Forms.Button
    Me.BtnExit = New System.Windows.Forms.Button
    Me.RadioButtonOneMap = New System.Windows.Forms.RadioButton
    Me.RadioButtonAllMap = New System.Windows.Forms.RadioButton
    Me.ComboBoxselectMap = New System.Windows.Forms.ComboBox
    Me.SuspendLayout()
    '
    'ButtonPrintPerview
    '
    Me.ButtonPrintPerview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.ButtonPrintPerview.Image = CType(resources.GetObject("ButtonPrintPerview.Image"), System.Drawing.Image)
    Me.ButtonPrintPerview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.ButtonPrintPerview.Location = New System.Drawing.Point(112, 108)
    Me.ButtonPrintPerview.Name = "ButtonPrintPerview"
    Me.ButtonPrintPerview.Size = New System.Drawing.Size(92, 29)
    Me.ButtonPrintPerview.TabIndex = 35
    Me.ButtonPrintPerview.Text = "打印预览"
    Me.ButtonPrintPerview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnExit
    '
    Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
    Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit.Location = New System.Drawing.Point(224, 108)
    Me.BtnExit.Name = "BtnExit"
    Me.BtnExit.Size = New System.Drawing.Size(72, 29)
    Me.BtnExit.TabIndex = 38
    Me.BtnExit.Text = "退出"
    Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'RadioButtonOneMap
    '
    Me.RadioButtonOneMap.Location = New System.Drawing.Point(136, 16)
    Me.RadioButtonOneMap.Name = "RadioButtonOneMap"
    Me.RadioButtonOneMap.Size = New System.Drawing.Size(160, 24)
    Me.RadioButtonOneMap.TabIndex = 39
    Me.RadioButtonOneMap.Text = "只打印单个地图站点数据"
    '
    'RadioButtonAllMap
    '
    Me.RadioButtonAllMap.Location = New System.Drawing.Point(136, 52)
    Me.RadioButtonAllMap.Name = "RadioButtonAllMap"
    Me.RadioButtonAllMap.Size = New System.Drawing.Size(160, 24)
    Me.RadioButtonAllMap.TabIndex = 40
    Me.RadioButtonAllMap.Text = "要打印所有地图站点数据"
    '
    'ComboBoxselectMap
    '
    Me.ComboBoxselectMap.Location = New System.Drawing.Point(20, 20)
    Me.ComboBoxselectMap.Name = "ComboBoxselectMap"
    Me.ComboBoxselectMap.Size = New System.Drawing.Size(104, 20)
    Me.ComboBoxselectMap.TabIndex = 41
    '
    'Form6PrintLS
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(308, 150)
    Me.Controls.Add(Me.ComboBoxselectMap)
    Me.Controls.Add(Me.RadioButtonAllMap)
    Me.Controls.Add(Me.RadioButtonOneMap)
    Me.Controls.Add(Me.BtnExit)
    Me.Controls.Add(Me.ButtonPrintPerview)
    Me.Name = "Form6PrintLS"
    Me.Text = "流水打印"
    Me.ResumeLayout(False)

  End Sub

#End Region

  'Private ReportDB As New GPRSADO

  Dim AdoAdo As GPRSADO
  'Dim AdoCnn As ADODB.Connection
  Dim AdoRst As ADODB.Recordset

  Dim dsReport As New DataSet
  Dim StrCnnString As String
  Dim StrSQL As String
  Dim oledbCnn As OleDb.OleDbConnection
  Dim daCommand As OleDb.OleDbDataAdapter
  Dim MapNo As Integer
  Private Sub BuildReportDB(ByVal MapNo As Integer)
    '-1为全部地图
    If MapNo < -1 Then
      Exit Sub
    End If
    Dim i, j, k, ID As Integer
    Dim MyRst As New ADODB.Recordset
    Dim ReportDB As New GPRSADO
    With ReportDB
      .ConnAccess(CW.WorkPath & "\" & PrintLS_MDBFileName)
      MyRst = .OpenTable("TablePrintLS")
    End With

    With MyRst

      If .RecordCount > 0 Then
        Try
          .MoveFirst()
          While Not .EOF
            .Delete()
            .MoveNext()
          End While
          .UpdateBatch()
        Catch ex As Exception
          MessageBox.Show("清空报表数据库时发生错误：" & ex.Message.ToString)
        End Try
    
      End If

      If MapNo > -1 Then

        Try
          For i = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            .AddNew()
            .Fields("ID").Value = i
            .Fields("站点索引").Value = CW.Maps(MapNo).Stations(i).StationIndex
            .Fields("站点名称").Value = CW.Maps(MapNo).Stations(i).StationName

            'If CW.Maps(MapNo).Stations(i).TestTime = Nothing Then
            '  .Fields("检测时间").Value = CStr(TimeOfDay)
            'Else
            Try
              .Fields("检测时间").Value = CStr(CW.Maps(MapNo).Stations(i).TestTime)
            Catch ex As Exception
            End Try
            'End If

            For j = 1 To CW.Maps(MapNo).Stations(i).StationParameterAmount
              .Fields("参数" & CStr(j)).Value = CW.Maps(MapNo).Stations(i).StationParameters(j, 1)
            Next j
          Next i
          '解决奇怪的少一行的问题200504302133
          .AddNew()
          ID += 1
          .Fields("ID").Value = ID
          .UpdateBatch()
          .Close()
        Catch ex As Exception
          MessageBox.Show("形成单地图报表数据时发生错误：" & ex.Message.ToString)
        End Try

      ElseIf MapNo = -1 Then

        Try
          ID = 0
          For i = 1 To CW.MapAmount
            .AddNew()
            ID += 1
            .Fields("ID").Value = ID
            .Fields("站点名称").Value = "地图" & CStr(i) & "："
            .Fields("检测时间").Value = CW.Maps(i).MapName
            For j = 1 To CW.Maps(i).Stations(1).StationParameterAmount
              .Fields("参数" & CStr(j)).Value = "----------"
            Next j

            For k = 1 To CW.Maps(i).MapStationPlacedAmount
              .AddNew()
              ID += 1
              .Fields("ID").Value = ID
              .Fields("站点索引").Value = CW.Maps(i).Stations(k).StationIndex
              .Fields("站点名称").Value = CW.Maps(i).Stations(k).StationName

              'If CW.Maps(MapNo).Stations(i).TestTime = Nothing Then
              '  .Fields("检测时间").Value = CStr(TimeOfDay)
              'Else
              Try
                .Fields("检测时间").Value = CStr(CW.Maps(MapNo).Stations(i).TestTime)
              Catch ex As Exception
              End Try
              'End If

              For j = 1 To CW.Maps(i).Stations(k).StationParameterAmount
                .Fields("参数" & CStr(j)).Value = CW.Maps(i).Stations(k).StationParameters(j, 1)
              Next j
            Next k

          Next i
          '解决奇怪的少一行的问题200504302133
          .AddNew()
          ID += 1
          .Fields("ID").Value = ID
          .UpdateBatch()
          .Close()
        Catch ex As Exception
          MessageBox.Show("形成所有地图报表数据时发生错误：" & ex.Message.ToString)
        End Try

      End If

    End With
    MyRst = Nothing
    ReportDB = Nothing

  End Sub
  Private Sub ShowReport()
    'Dim i, j, k As Integer
    'Dim dsReport As New DataSet
    'Dim StrCnnString As String
    'Dim StrSQL As String
    'Dim oledbCnn As OleDb.OleDbConnection
    'Dim dsCommand As OleDb.OleDbDataAdapter

    StrCnnString = CreatAdoAccessCnnString(CW.WorkPath & "\" & PrintLS_MDBFileName)
    StrSQL = "SELECT * FROM TablePrintLS"
    oledbCnn = New OleDb.OleDbConnection(StrCnnString)
    daCommand = New OleDb.OleDbDataAdapter(StrSQL, oledbCnn)
    daCommand.Fill(dsReport, "TablePrintLS")

    'DataGrid1.DataSource = dsReport


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''不行200504290458
    'AdoAdo = New GPRSADO
    'AdoRst = New ADODB.Recordset
    'AdoAdo.ConnAccess(CW.WorkPath & "\" & PrintLSMDBFileName)
    'AdoRst = AdoAdo.OpenTable("TablePrintLS")

    'DataGrid1.DataSource = AdoRst
  End Sub
  Private Sub SetLocation()
    Dim i As Integer
    For i = 1 To CW.MapAmount
      ComboBoxselectMap.Items.Add(CW.Maps(i).MapName)
    Next i
    ComboBoxselectMap.SelectedIndex = CW.MapNo - 1
    RadioButtonOneMap.Checked = True
    MapNo = CW.MapNo
  End Sub
  Private Sub Form6PrintLS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Utility.RegisterGridppReport()
    Dim S As String
    S = CW.WorkPath & "\PrintLS6.grf"
    Report.LoadFromFile(S)
    SetLocation()
  End Sub

  Private Class ReportInfo
    Public Sub New(ByVal Name As String, ByVal TemplateFileName As String, ByVal SQL As String)
      m_Name = Name
      m_TemplateFileName = TemplateFileName
      m_SQL = SQL
    End Sub

    Public m_Name As String
    Public m_TemplateFileName As String
    Public m_SQL As String

    Public Overrides Function ToString() As String
      Return m_Name
    End Function
  End Class

  Private Sub Report_FetchRecord(ByRef pEof As Boolean) Handles Report.FetchRecord
    Try
      Dim ocnnNorthwind As OleDbConnection = New OleDbConnection(CreatAdoAccessCnnString(CW.WorkPath & "\" & PrintLS_MDBFileName))
      StrSQL = "SELECT 站点索引,站点名称,检测时间,参数1,参数2,参数3,参数4,参数5,参数6,参数7,参数8,参数9,参数10 FROM TablePrintLS"
      Dim ocmd As OleDbCommand = New OleDbCommand(StrSQL, ocnnNorthwind)
      ocnnNorthwind.Open()
      Dim odr As OleDbDataReader = ocmd.ExecuteReader(CommandBehavior.CloseConnection)
      GridppReportUtility.FillRecordToReport(Report, odr)
      odr.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub Report_Initialize() Handles Report.Initialize
    Dim MyStaticBox As IGRStaticBox
    MyStaticBox = Report.ControlByName("StaticBoxTitle")
    MyStaticBox.Text = CW.WorkName & "站点数据流水报表"

    MyStaticBox = Report.ControlByName("StaticBoxDYR")
    MyStaticBox.Text = "打印人：" & ActivePerson.Name

    MyStaticBox = Report.ControlByName("StaticBoxDYTime")
    MyStaticBox.Text = "打印时间：" & CStr(Today.Date) & " " & CStr(TimeOfDay)

    MyStaticBox = Report.ControlByName("StaticBoxSaveTime")
    Dim Sd, St As String
    If CWSaveDT.SaveDate = Nothing Then
      Sd = CStr(Today.Date)
    Else
      Sd = CWSaveDT.SaveDate.ToString
    End If
    If CWSaveDT.SaveTime = Nothing Then
      St = CStr(TimeOfDay)
    Else
      St = CWSaveDT.SaveTime.ToString
    End If
    MyStaticBox.Text = "检测日期：" & Sd

    MyStaticBox = Report.ControlByName("StaticBoxMapInfo")
    If MapNo = -1 Then
      MyStaticBox.Text = "地图：所有地图"
    Else
      MyStaticBox.Text = "地图：" & CW.Maps(MapNo).MapName
    End If

    'Dim BT As IGRColumnTitle
    'With Report

    'End With


    'Dim MyBTG As IGRColumnTitleCell
    'MyBTG = Report.ControlByName("StaticBoxTitle")
  End Sub

  Private Sub ButtonPrintPerview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintPerview.Click
    'If RadioButtonOneMap.Checked Then
    BuildReportDB(MapNo)
    'Else
    '  BuildReportDB(-1)
    'End If
    'ReportFetchRecord(True)
    Report.PrintPreview(True)
    'ShowReport()
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    Me.Close()
  End Sub

  Private Sub ComboBoxselectMap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxselectMap.SelectedIndexChanged
    RadioButtonOneMap.Checked = True
    MapNo = ComboBoxselectMap.SelectedIndex + 1
  End Sub

  Private Sub RadioButtonOneMap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonOneMap.Click
    If RadioButtonOneMap.Checked Then
      MapNo = ComboBoxselectMap.SelectedIndex + 1
    End If
  End Sub

  Private Sub RadioButtonAllMap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonAllMap.Click
    If RadioButtonAllMap.Checked Then
      MapNo = -1
    End If
  End Sub
End Class
