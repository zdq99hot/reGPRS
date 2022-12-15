Public Class MyClassData

#Region "参数定义"
  Public Conn As OleDb.OleDbConnection
  Public ConnConnectionString As String
  Public CommandString As String
  Public Command As OleDb.OleDbCommand
  Public DataTable As DataTable
  Public DataAdapter As OleDb.OleDbDataAdapter
  Public DACommandBuilder As OleDb.OleDbCommandBuilder

  Public DataSet As Data.DataSet

  Public DataRow As Data.DataRow
  Public DataRows_AtmosphereTemp() As Data.DataRow
  Public DataRows() As Data.DataRow
  Public DataRows_OutBackWaterTemp() As Data.DataRow
  Public DataRows_Alarm_TempLine() As Data.DataRow

  Public Column As Data.DataColumn
  Public Columns() As Data.DataColumn
  Public SQLString As String
  Public DataView As Data.DataView
  Public S As String
  Public DataRowCollection As Data.DataRowCollection

  Public InsertCommandText As String
  Public UpdateCommandText As String

  Public DataTableNonceTemp As DataTable

#End Region


End Class
