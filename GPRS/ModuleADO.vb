
Imports ADODB.ConnectionClass
Imports ADODB.RecordsetClass
Imports ADODB.CursorLocationEnum
Imports System.DBNull
Module ModuleADO
  Public Class GPRSADO
    Private mCnnDB As New ADODB.Connection

    Public Sub Close()
      Try
        mCnnDB.Close()
        mCnnDB = Nothing
      Catch ex As Exception

      End Try
    End Sub
    Public Sub ConnAccess(ByVal DBName As String)
      '����: ����Access���ݿ� 
      '����: DBName ���ݿ��� 
      mCnnDB.CursorLocation = adUseClient
      mCnnDB.Provider = "Microsoft.Jet.OLEDB.4.0"
      mCnnDB.Open(DBName, "Admin")
    End Sub

    '��ODBC������DNS,�������ConnectionString��ָ���û��������룬�����open�����򿪡�����ODBC�����û��������û������ߣ����Ǳ���ֱ�ʵ�֣�������ĺ��������ع��ܣ����Ǳ�д����ͬ���Ĺ��̣������Ĵ������£�
    Public Sub ConnODBC(ByVal dsnName As String)
      '����: ����ODBC���ݿ�(����ָ���û������� ) 
      '������dsnNameΪODBC�� 
      mCnnDB.Provider = "MSDASQL"
      mCnnDB.ConnectionString = "Data Source='" & dsnName & "'"
      mCnnDB.Open()
    End Sub


    Public Sub ConnODBC(ByVal dsnName As String, ByVal UserID As String, ByVal UserPwd As String)
      '����: ����ODBC���ݿ�(��ָ���û������� ) 
      '������dsnName ODBC��,UserID �û�����UserPwd �û����� 
      mCnnDB.Provider = "MSDASQL"
      mCnnDB.ConnectionString = "Data Source='" & dsnName & "'User ID='" & UserID & "';" & _
      "Password='" & UserPwd & " "
      mCnnDB.Open()
    End Sub
    'SQL Server���ݿ���Microsoft������һ�ֹ㷺ʹ�õĺ�̨���ݿ⡣����SQL Server����ͨ��ָ��ODBC��������ΪSQL Server��ʵ�֣����������ַ�����Ҫ��driver={SQL Server},�������Ǻ�̨���ݿ⣬���Ա���ָ��SQL Server���ڵļ��������ͨ��������Ϊ�������������ServerName��˵����㣬Ȼ��ָ���������ĸ����ݿ⡣���������������ODBC��SQL Server���û���ΪWIN NT ����Ȩ�û���WIN NT�û��ǲ���Ҫָ���û���������ĳ����û�������Ҫָ���û��������룬�������SQL Server���ݿ����Ա���ڴ˲�����ϸ˵���������Ĵ������£� 

    Public Sub ConnSQLServer(ByVal ServerName As String, ByVal DBName As String)
      '����: ����SQL Server���ݿ� 
      '������ServerName ��������,DBName ���ݿ��� 
      With mCnnDB
        .ConnectionString = "uid=;pwd= ;driver={SQL Server};" & _
        "server=" & ServerName & _
        ";database=" & DBName
        .Open()
      End With
    End Sub

    Public Sub ConnSQLServer(ByVal ServerName As String, ByVal DBName As String, ByVal UserID As String, ByVal UserPwd As String)
      '����: ����SQL Server���ݿ� 
      '������ServerName ��������,DBName ���ݿ���,UserID �û�����UserPwd �û����� 
      With mCnnDB
        .ConnectionString = "uid='" & UserID & "';pwd='" & UserPwd & "';driver={SQL Server};" & _
        "server=" & ServerName & _
        ";database=" & DBName
        .Open()
      End With
    End Sub


    'Oracle���ݿ���Ŀǰ����Ӱ���һ�ֹ㷺ʹ�õĺ�̨���ݿ⡣����Oracle��ָ�����ṩ��MSDAORA��Oracle��Sql Server��ͬ����������ͨ�����ݿ�������ģ�����������ָ�����ݿ⣬��������ʱ����ָ���û�����ʹ�ǳ����û�Ҳ��ˣ��������İ�ȫ���ܸ���Sql Server������֮һ����������ֻ���дһ�����̡��������ơ������Ĵ������£� 

    Public Sub ConnOracle(ByVal ServerName As String, ByVal UserID As String, ByVal UserPwd As String)
      '����: ����Oracle���ݿ� 
      '������ServerName ��������,DBName ���ݿ���,UserID �û�����UserPwd �û����� 
      With mCnnDB
        .Provider = "MSDAORA"
        .ConnectionString = "User ID='" & UserID & "';" & _
        "Password='" & UserPwd & "';" & _
        "Data Source='" & ServerName & "'"
        .Open()
      End With
    End Sub

    '�������ݿ�󣬾Ϳ�������ADO�����д���ݵĺ����� 

    'ADO�ڷ��ʱ�ʱҪָ���������ͺ������ͣ���ָ�����дȨ�ޣ��������Ǳ�д�����ж�дȨ�޵�ͨ�õĺ�������������ָ�����CursorTypeΪadOpenKeyset����ΪadLockOptimistic��.NET��ָ������Դ������Ϊʲô��ʼҪ�� "Imports ADODB.CursorLocationEnum"����ԭ��������Щ���Ϳ�ͨ��ִ�в�ѯ�������һ�����򿪱�������жϱ��Ƿ�Ϊ�ձ��������ƶ���¼��β������������¼ͷ������Ϊ�˿��Է�������ÿ����¼���ر�����RecordCount���¼��ʱ�����ڷ���-1�Ĺؼ�������󷵻�һ����¼���������Ĵ������£� 



    Public Overloads Function OpenTable(ByVal TableName As String) As ADODB.Recordset
      '����:���ӱ� 
      '������TableName���� 
      '���أ���¼�� 
      Dim strSql As String
      Dim rec As ADODB.Recordset
      rec = New ADODB.Recordset
      OpenTable = rec
      rec.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
      rec.LockType = ADODB.LockTypeEnum.adLockOptimistic
      strSql = "SELECT * FROM " & TableName
      Try
        rec.Open(strSql, mCnnDB) '�򿪼�¼�� 
        If Not rec.EOF Then
          rec.MoveLast()
          rec.MoveFirst()
        End If
        OpenTable = rec
      Catch ex As Exception
        MessageBox.Show("���ڴ򿪱��ʱ��������" & ex.Message.ToString)
      End Try

    End Function

    '�������������溯���Ĺ��ܣ����Ը����������ʵ����� 

    Public Overloads Function OpenTable(ByVal TableName As String, ByVal strWhere As String) As ADODB.Recordset
      Dim strSql As String
      Dim rec As ADODB.Recordset
      rec = New ADODB.Recordset
      OpenTable = rec
      rec.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
      rec.LockType = ADODB.LockTypeEnum.adLockOptimistic
      strSql = "SELECT * FROM " & TableName & " where " & strWhere
      Try
        rec.Open(strSql, mCnnDB) '�򿪼�¼�� 
        If Not rec.EOF Then
          rec.MoveLast()
          rec.MoveFirst()
        End If
        Return rec
      Catch ex As Exception
        MessageBox.Show("���ڴ򿪱��ʱ��������" & ex.Message.ToString)
      End Try

    End Function

    '����������ʱ�Ĺ��ܡ���ʱҪ�򿪶������д���е����ݣ����ǿ���ͨ��������ѯ��ͼʵ�֣��������������OpenTable�������Ĵ������£� 

    Public Function ExecuteSQL(ByVal strSql As String) As ADODB.Recordset
      '����:���Ӷ�� 
      '������strSQL 
      '���أ���¼�� 
      Dim rec As New ADODB.Recordset
      rec.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
      rec.LockType = ADODB.LockTypeEnum.adLockOptimistic
      rec.Open(strSql, mCnnDB) '�򿪼�¼�� 
      ExecuteSQL = rec
    End Function

    '�����д��һ���ü�¼�����AxMSFlexGrid����Ĺ��̡����к���RecordCount�����Լ���д�����¼���м�¼�ĺ��������ﲻ��ֱ����ADO��RecordCount��á������¼���ǿգ����˳����̡����������¼���ļ�¼�����ֶ���ȷ��AxMSFlexGrid������������ݣ�Ȼ�������¼��������ֱ����䵽AxMSFlexGrid����Ҫ˵�����Ƕ�����¼��������ʱҪ���ж��Ƿ�Ϊ��ֵ���ɺ���IsDBNullʵ��(����IsDBNull��Դ��System.DBNull).����¼��Ӧ�÷��ص���¼��λ������Ӱ����ԭ�еļ�¼���������Ĵ������£� 

    'Public Sub FillMsGrid(ByVal MSGrid As AxMSFlexGridLib.AxMSFlexGrid, ByVal rec As ADODB.Recordset)
    '  '���ã��ü�¼��������������� 
    '  '������MSGrid �������rec ��¼������ 
    '  Dim i, j, RecordNum As Integer
    '  If rec.EOF Then Exit Sub
    '  RecordNum = RecordCount(rec)
    '  MSGrid.Rows = RecordNum + 1
    '  MSGrid.Cols = rec.Fields.Count + 1
    '  For i = 0 To RecordNum - 1
    '    For j = 0 To rec.Fields.Count - 1
    '      If IsDBNull(rec(j).Value) Then
    '        MSGrid.set_TextMatrix(i + 1, j + 1, "")
    '      Else
    '        MSGrid.set_TextMatrix(i + 1, j + 1, rec(j).Value)
    '      End If
    '    Next
    '    MSGrid.set_TextMatrix(i + 1, 0, i)
    '    rec.MoveNext()
    '  Next
    '  rec.MoveFrist()
    'End Sub

    Public Function RecordCount(ByVal rec As ADODB.Recordset) As Integer
      '���ã�ȡ��¼���ļ�¼�� 
      '������rec ��¼������ 
      '���أ���¼���ļ�¼�� 
      Dim i As Integer
      If rec.EOF Then
        RecordCount = 0
        Exit Function
      End If
      With rec
        .MoveFirst()
        Do While Not .EOF
          i += 1
          .MoveNext()
        Loop
        .MoveFirst()
      End With
      RecordCount = i
    End Function


    '���ϴ����ú���������������.�����ʡ�ԺŴ�������ĺ����͹��̡���ֱ������ΪDLL�������������.NET�༭������ѡ�����ɲ˵��а����ɾ�������DLL�ļ���Ȼ�������ֱ�ӵ��ø�����ˡ� 


    'Imports ADODB.Connection 
    'Imports ADODB.Recordset 
    'Imports ADODB.CursorLocationEnum 
    'Imports System.DBNull '����IsDBNull����Դ 
    '    Class ADOAccess
    '      Private mCnnDB As New ADODB.Connection
    '�� 
    '    End Class

    '�����������ɵ�����������£���Visual Basic.NET�н���һ��Ŀ���ڴ���Form1�м���һAxMSFlexGrid��������ΪMsGrid1,�������� 

    'Ȼ�����øս�����Dll��������ѡ����Ŀ�˵���������ã�ѡ����Ŀҳ��������ҵ���DLL�ļ�ȷ����������ɡ���Form1�ж���һADOAccess������Load�¼��б�д���ô��룬�ֱ�����书�ܣ��������£� 

    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '  Public Class Form1
    '    Inherits System.Windows.Forms.Form
    '    Dim DB As New ADOAccess
    '    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '      Dim rec As New ADODB.Recordset
    '      'DB.ConnAccess("e:\test.mdb") 
    '      'DB.ConnSQLServer("wj-1058", "test") 
    '      'DB.ConnODBC("testODBC") 
    '      'DB.ConnOracle("wj-1059", "system", "manager") 
    '      'rec = DB.OpenTable("DEMO.customer") 
    '      rec = DB.OpenTable("doc_file")
    '      DB.FillMsGrid(MSGrid1, rec)
    '    End Sub

    '˵���� 

    '1.��Ļ���Ҫ��Access���ݿ��ļ���e:\test.mdb����MS Server���ݿ��������ݿ�test��doc_file Ϊtest�еı�Oracle���ݿ����б�DEMO.customer 

    '2. wj-1058ΪMS Server����������wj-1059ΪOracle����������"system", "manager"�ֱ�Ϊ�û�������� 

    '3. һ�ν�����һ�����ݿ⡣ 

    '���ϳ�����Visual Studio.NET�е���ͨ������ 

    '�ܽ᣺���淽�������˸��������õ�Visual Basic.NET���й����ݿ�Ŀ�����ADO��Visual Basic.NET�е�Ӧ�ã����Ӽ�����ʵ�õ����ݿ⣬�ҽ����˱�д����ķ�����
  End Class
End Module
