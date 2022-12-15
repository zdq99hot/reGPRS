
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
      '作用: 连接Access数据库 
      '参数: DBName 数据库名 
      mCnnDB.CursorLocation = adUseClient
      mCnnDB.Provider = "Microsoft.Jet.OLEDB.4.0"
      mCnnDB.Open(DBName, "Admin")
    End Sub

    '在ODBC中设置DNS,在下面的ConnectionString中指定用户名和密码，最后用open方法打开。由于ODBC分有用户名和无用户名两者，我们必须分别实现，借助类的函数名重载功能，我们编写两个同名的过程，完整的代码如下：
    Public Sub ConnODBC(ByVal dsnName As String)
      '作用: 连接ODBC数据库(不需指定用户和密码 ) 
      '参数：dsnName为ODBC名 
      mCnnDB.Provider = "MSDASQL"
      mCnnDB.ConnectionString = "Data Source='" & dsnName & "'"
      mCnnDB.Open()
    End Sub


    Public Sub ConnODBC(ByVal dsnName As String, ByVal UserID As String, ByVal UserPwd As String)
      '作用: 连接ODBC数据库(需指定用户和密码 ) 
      '参数：dsnName ODBC名,UserID 用户名，UserPwd 用户密码 
      mCnnDB.Provider = "MSDASQL"
      mCnnDB.ConnectionString = "Data Source='" & dsnName & "'User ID='" & UserID & "';" & _
      "Password='" & UserPwd & " "
      mCnnDB.Open()
    End Sub
    'SQL Server数据库是Microsoft开发的一种广泛使用的后台数据库。访问SQL Server可以通过指明ODBC驱动程序为SQL Server来实现，即在连接字符串中要有driver={SQL Server},由于它是后台数据库，所以必须指明SQL Server所在的计算机名，通常把它称为服务器，下面的ServerName就说明这点，然后指明是连接哪个数据库。其它的类似上面的ODBC。SQL Server的用户分为WIN NT 和授权用户，WIN NT用户是不需要指定用户名和密码的超级用户，否则要指明用户名和密码，这决定于SQL Server数据库管理员，在此不作详细说明，完整的代码如下： 

    Public Sub ConnSQLServer(ByVal ServerName As String, ByVal DBName As String)
      '作用: 连接SQL Server数据库 
      '参数：ServerName 服务器名,DBName 数据库名 
      With mCnnDB
        .ConnectionString = "uid=;pwd= ;driver={SQL Server};" & _
        "server=" & ServerName & _
        ";database=" & DBName
        .Open()
      End With
    End Sub

    Public Sub ConnSQLServer(ByVal ServerName As String, ByVal DBName As String, ByVal UserID As String, ByVal UserPwd As String)
      '作用: 连接SQL Server数据库 
      '参数：ServerName 服务器名,DBName 数据库名,UserID 用户名，UserPwd 用户密码 
      With mCnnDB
        .ConnectionString = "uid='" & UserID & "';pwd='" & UserPwd & "';driver={SQL Server};" & _
        "server=" & ServerName & _
        ";database=" & DBName
        .Open()
      End With
    End Sub


    'Oracle数据库是目前最有影响的一种广泛使用的后台数据库。访问Oracle先指明其提供者MSDAORA。Oracle与Sql Server不同的是它不是通过数据库来管理的，所以它不需指明数据库，但它连接时必须指明用户，即使是超级用户也如此，这是它的安全性能高于Sql Server的理现之一，所以我们只须编写一个过程。其它类似。完整的代码如下： 

    Public Sub ConnOracle(ByVal ServerName As String, ByVal UserID As String, ByVal UserPwd As String)
      '作用: 连接Oracle数据库 
      '参数：ServerName 服务器名,DBName 数据库名,UserID 用户名，UserPwd 用户密码 
      With mCnnDB
        .Provider = "MSDAORA"
        .ConnectionString = "User ID='" & UserID & "';" & _
        "Password='" & UserPwd & "';" & _
        "Data Source='" & ServerName & "'"
        .Open()
      End With
    End Sub

    '连结数据库后，就可以利用ADO扩充读写数据的函数。 

    'ADO在访问表时要指明其光标类型和锁类型，且指定其读写权限，这里我们编写的是有读写权限的通用的函数，所以我们指定光标CursorType为adOpenKeyset，锁为adLockOptimistic，.NET需指明其来源，这是为什么开始要有 "Imports ADODB.CursorLocationEnum"语句的原因。有了这些，就可通过执行查询语句来打开一个表。打开表后，我们判断表是否为空表，不是则移动记录至尾后再现移至记录头（这是为了可以访问其中每条记录，特别是用RecordCount求记录数时不至于返回-1的关键），最后返回一个记录集，完整的代码如下： 



    Public Overloads Function OpenTable(ByVal TableName As String) As ADODB.Recordset
      '作用:连接表 
      '参数：TableName表名 
      '返回：记录集 
      Dim strSql As String
      Dim rec As ADODB.Recordset
      rec = New ADODB.Recordset
      OpenTable = rec
      rec.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
      rec.LockType = ADODB.LockTypeEnum.adLockOptimistic
      strSql = "SELECT * FROM " & TableName
      Try
        rec.Open(strSql, mCnnDB) '打开记录集 
        If Not rec.EOF Then
          rec.MoveLast()
          rec.MoveFirst()
        End If
        OpenTable = rec
      Catch ex As Exception
        MessageBox.Show("类在打开表的时候发生错误：" & ex.Message.ToString)
      End Try

    End Function

    '下面是扩充上面函数的功能，可以跟据条件访问单个表。 

    Public Overloads Function OpenTable(ByVal TableName As String, ByVal strWhere As String) As ADODB.Recordset
      Dim strSql As String
      Dim rec As ADODB.Recordset
      rec = New ADODB.Recordset
      OpenTable = rec
      rec.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
      rec.LockType = ADODB.LockTypeEnum.adLockOptimistic
      strSql = "SELECT * FROM " & TableName & " where " & strWhere
      Try
        rec.Open(strSql, mCnnDB) '打开记录集 
        If Not rec.EOF Then
          rec.MoveLast()
          rec.MoveFirst()
        End If
        Return rec
      Catch ex As Exception
        MessageBox.Show("类在打开表的时候发生错误：" & ex.Message.ToString)
      End Try

    End Function

    '继续扩充访问表的功能。有时要打开多个表，读写其中的数据，我们可以通过建立查询视图实现，其它类似上面的OpenTable，完整的代码如下： 

    Public Function ExecuteSQL(ByVal strSql As String) As ADODB.Recordset
      '作用:连接多表 
      '参数：strSQL 
      '返回：记录集 
      Dim rec As New ADODB.Recordset
      rec.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
      rec.LockType = ADODB.LockTypeEnum.adLockOptimistic
      rec.Open(strSql, mCnnDB) '打开记录集 
      ExecuteSQL = rec
    End Function

    '下面编写了一个用记录集填充AxMSFlexGrid网格的过程。其中函数RecordCount是我自己编写的求记录集中记录的函数。这里不能直接用ADO的RecordCount求得。如果记录集是空，则退出过程。否则求出记录集的记录数和字段来确定AxMSFlexGrid网格的行列数据，然后读出记录集的数据直接填充到AxMSFlexGrid网格。要说明的是读出记录集的数据时要先判断是否为空值，由函数IsDBNull实现(函数IsDBNull来源于System.DBNull).最后记录集应该返回到记录首位，否则影响了原有的记录集，完整的代码如下： 

    'Public Sub FillMsGrid(ByVal MSGrid As AxMSFlexGridLib.AxMSFlexGrid, ByVal rec As ADODB.Recordset)
    '  '作用：用记录集的数据填充网格 
    '  '参数：MSGrid 网格对象，rec 记录集对象 
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
      '作用：取记录集的记录数 
      '参数：rec 记录集对象 
      '返回：记录集的记录数 
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


    '以上代码编好后放在所定义的类中.下面的省略号代表上面的函数和过程。可直接生成为DLL组件。方法是在.NET编辑环境下选择生成菜单中按生成就生成了DLL文件。然后，你可以直接调用该组件了。 


    'Imports ADODB.Connection 
    'Imports ADODB.Recordset 
    'Imports ADODB.CursorLocationEnum 
    'Imports System.DBNull '函数IsDBNull的来源 
    '    Class ADOAccess
    '      Private mCnnDB As New ADODB.Connection
    '… 
    '    End Class

    '调用上面生成的组件方法如下：在Visual Basic.NET中建立一项目，在窗口Form1中加入一AxMSFlexGrid网格命名为MsGrid1,布置如下 

    '然后引用刚建立的Dll。方法是选择项目菜单的添加引用，选择项目页，按浏览找到其DLL文件确定后引用完成。在Form1中定义一ADOAccess对象，在Load事件中编写调用代码，分别测试其功能，代码如下： 

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

    '说明： 

    '1.你的机上要有Access数据库文件（e:\test.mdb），MS Server数据库中有数据库test，doc_file 为test中的表，Oracle数据库中有表DEMO.customer 

    '2. wj-1058为MS Server服务器名，wj-1059为Oracle服务器名，"system", "manager"分别为用户名及口令。 

    '3. 一次仅连接一种数据库。 

    '以上程序在Visual Studio.NET中调试通过。　 

    '总结：上面方法介绍了刚面世不久的Visual Basic.NET中有关数据库的开发，ADO在Visual Basic.NET中的应用，连接几种最实用的数据库，且介绍了编写组件的方法。
  End Class
End Module
