Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class acceptProcess
    Public aClient As TcpClient
    Dim serverListener As TcpListener
    Public myStream As NetworkStream
  Friend serverForm As Form1
    Public ifStopReceive As Boolean = False


    Public Sub New(ByVal tL As TcpListener)
        Me.serverListener = tL
    End Sub

    Public Sub ServerThreadProc()
        Dim bteAcceptData(1024) As Byte
        Dim lngAcceptData As Long
        Do While True
            Try
                aClient = serverListener.AcceptTcpClient()
                myStream = aClient.GetStream

                Dim serverInfo As IPEndPoint = CType(serverListener.LocalEndpoint, IPEndPoint)
        'serverForm.ListBox1.Items.Insert(0, "Connection OK to Server: " + serverInfo.Address.ToString() + ":" + serverInfo.Port.ToString())
                'serverForm.ListBox1.Items.Insert(0, CStr(AppDomain.GetCurrentThreadId()))

                Do While Not ifStopReceive
                    lngAcceptData = myStream.Read(bteAcceptData, 0, 1024)
                    serverForm.Label1.Text = "接收了 " + lngAcceptData.ToString + " 個位元組的資料 !!"
          'serverForm.ListBox1.Items.Insert(0, Encoding.Unicode.GetString(bteAcceptData))
                    Array.Clear(bteAcceptData, 0, 1024)
                Loop
        'serverForm.ListBox1.Items.Insert(0, "Stop receiving")
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace.ToString, "伺服端接收錯誤...")
            End Try
        Loop
    End Sub

End Class
