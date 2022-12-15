Imports grproLib
Imports System.Data
Imports System.Data.OleDb


Public Class GridppReportUtility
  Public Const ACCESS_CONNECTION_STRING As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Data\Northwind.mdb"

  '此函数用来注册Grid++Report，使Grid++Report不会运行在试用版状态下，你必须在你的应用程序启动时调用此函数
  '用你自己的序列号代替"BS530DTAS2"，"BS530DTAS2"是一个无效的序列号
  Public Shared Sub RegisterGridppReport()
    Dim TempGridppReport As New GridppReport
    Dim Succeeded As Boolean
    Succeeded = TempGridppReport.Register("BEK9C3DURX24")
    If Succeeded = False Then
      System.Windows.Forms.MessageBox.Show("Register Grid++Report Failed, Grid++Report will run in trial mode.", "Register", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Structure MatchFieldPairType
    Public grField As IGRField
    Public MatchColumnIndex As Integer
  End Structure

  Public Shared Sub FillDataRowsToReport(ByVal Report As IGridppReport, ByVal DRs() As DataRow)

    Dim i, k, RN As Integer
    RN = DRs.GetUpperBound(0)
    If RN < 0 Then
      Exit Sub
    End If

    Dim MatchFieldPairs() As MatchFieldPairType
    ReDim MatchFieldPairs(Math.Min(Report.DetailGrid.Recordset.Fields.Count, DRs(0).Table.Columns.Count))

    '根据字段名称与列名称进行匹配，建立DataReader字段与Grid++Report记录集的字段之间的对应关系
    Dim MatchFieldCount As Integer
    MatchFieldCount = 0
    For i = 0 To DRs(0).Table.Columns.Count - 1
      Dim fld As IGRField
      For Each fld In Report.DetailGrid.Recordset.Fields
        If String.Compare(fld.Name, DRs(0).Table.Columns.Item(i).ColumnName, True) = 0 Then
          MatchFieldPairs(MatchFieldCount).grField = fld
          MatchFieldPairs(MatchFieldCount).MatchColumnIndex = i
          MatchFieldCount = MatchFieldCount + 1
          Exit For
        End If
      Next fld
    Next

    '将 DataTable 中的每一条记录转储到Grid++Report 的数据集中去
    For k = 0 To RN
      Report.DetailGrid.Recordset.Append()
      '[[[[[[[[[[[[[[[20071013A3[[[[[[[[[[[[[[[[[[[[[[[[[[
      ''通过这次试验，证明其实可以象数据库一样逐条添加
      ''Report.DetailGrid.Recordset.Append()
      'Try
      '  'Report.DetailGrid.Recordset.Last()
      '  Report.DetailGrid.Recordset.Fields("公司名称").Value = CW.WorkFactoryName
      '  Report.DetailGrid.Recordset.Fields("站名称").Value = CW.Stations(DRs(k).Item("站ID")).StationName
      '  Report.DetailGrid.Recordset.Fields("家庭名称").Value = CW.Stations(DRs(k).Item("站ID")).Familys(DRs(k).Item("家庭ID")).FamilyManName
      '  Report.DetailGrid.Recordset.Fields("家庭信息及地址").Value = CW.Stations(DRs(k).Item("站ID")).Familys(DRs(k).Item("家庭ID")).FamilyAddress
      'Catch ex As Exception
      '  'MessageBox.Show(ex.Message)
      'End Try
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]


      For i = 0 To MatchFieldCount - 1
        If Not DRs(k).IsNull(MatchFieldPairs(i).MatchColumnIndex) Then
          If i = 2 Then
            Select Case DRs(k).Item(MatchFieldPairs(i).MatchColumnIndex).ToString.Trim
              Case "0"
                MatchFieldPairs(i).grField.Value = "大气温度"
              Case "-1"
                MatchFieldPairs(i).grField.Value = "出水温度"
              Case "-2"
                MatchFieldPairs(i).grField.Value = "回水温度"
              Case Else
                MatchFieldPairs(i).grField.Value = DRs(k).Item(MatchFieldPairs(i).MatchColumnIndex)
            End Select

          Else
            MatchFieldPairs(i).grField.Value = DRs(k).Item(MatchFieldPairs(i).MatchColumnIndex)
          End If
        End If
      Next i
      Report.DetailGrid.Recordset.Post()
    Next k
  End Sub

  Public Shared Sub FillRecordToReport(ByVal Report As IGridppReport, ByVal dr As IDataReader)
    Dim MatchFieldPairs() As MatchFieldPairType
    Dim S As String
    ReDim MatchFieldPairs(Math.Min(Report.DetailGrid.Recordset.Fields.Count, dr.FieldCount))

    '根据字段名称与列名称进行匹配，建立DataReader字段与Grid++Report记录集的字段之间的对应关系
    Dim MatchFieldCount As Integer
    MatchFieldCount = 0
    Dim I As Integer
    For I = 0 To dr.FieldCount - 1
      Dim fld As IGRField
      For Each fld In Report.DetailGrid.Recordset.Fields
        S = dr.GetName(I)
        If String.Compare(fld.Name, S, True) = 0 Then
          MatchFieldPairs(MatchFieldCount).grField = fld
          MatchFieldPairs(MatchFieldCount).MatchColumnIndex = I
          MatchFieldCount = MatchFieldCount + 1
          Exit For
        End If
      Next fld
    Next


    'Loop through the contents of the OleDbDataReader object.
    '将 DataReader 中的每一条记录转储到Grid++Report 的数据集中去
    While dr.Read()
      Report.DetailGrid.Recordset.Append()

      For I = 0 To MatchFieldCount - 1
        If Not dr.IsDBNull(MatchFieldPairs(I).MatchColumnIndex) Then
          MatchFieldPairs(I).grField.Value = dr.GetValue(MatchFieldPairs(I).MatchColumnIndex)
        End If
      Next

      Report.DetailGrid.Recordset.Post()
    End While
  End Sub

  Public Shared Sub FillRecordToReport(ByVal Report As IGridppReport, ByVal dt As DataTable)
    Dim MatchFieldPairs() As MatchFieldPairType
    ReDim MatchFieldPairs(Math.Min(Report.DetailGrid.Recordset.Fields.Count, dt.Columns.Count))

    '根据字段名称与列名称进行匹配，建立DataReader字段与Grid++Report记录集的字段之间的对应关系
    Dim MatchFieldCount As Integer
    MatchFieldCount = 0
    Dim I As Integer
    For I = 0 To dt.Columns.Count - 1
      Dim fld As IGRField
      For Each fld In Report.DetailGrid.Recordset.Fields
        If String.Compare(fld.Name, dt.Columns.Item(I).ColumnName, True) = 0 Then
          MatchFieldPairs(MatchFieldCount).grField = fld
          MatchFieldPairs(MatchFieldCount).MatchColumnIndex = I
          MatchFieldCount = MatchFieldCount + 1
          Exit For
        End If
      Next fld
    Next


    '将 DataTable 中的每一条记录转储到Grid++Report 的数据集中去
    Dim dr As DataRow
    For Each dr In dt.Rows
      Report.DetailGrid.Recordset.Append()

      For I = 0 To MatchFieldCount - 1
        If Not dr.IsNull(MatchFieldPairs(I).MatchColumnIndex) Then
          MatchFieldPairs(I).grField.Value = dr.Item(MatchFieldPairs(I).MatchColumnIndex)
        End If
      Next

      Report.DetailGrid.Recordset.Post()
    Next
  End Sub

  Public Shared Function RGBToOleColor(ByVal r As Byte, ByVal g As Byte, ByVal b As Byte) As System.UInt32
    RGBToOleColor = System.Convert.ToUInt32((System.Convert.ToInt32(b) * 256 * 256 + System.Convert.ToInt32(g) * 256 + r))
  End Function

  Public Shared Function ColorToOleColor(ByVal Val As System.Drawing.Color) As System.UInt32
    ColorToOleColor = RGBToOleColor(Val.R, Val.G, Val.B)
  End Function

End Class
