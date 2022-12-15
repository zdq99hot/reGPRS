Module M1



  'Public Const MAP_INFO_NO As Short = 5 '有几种地图属性
  'Public Const STATION_INFO_NO As Short = 8  '有几种站点属性
  'Public Const STATION_PROPERTY_NO As Short = 2  '有几种站点属性的属性
  'Public StationGifAlarm(1) As String '记录站点正常和报警时所用的图片,20050313 改为对象了StationGifPic
  Dim i, j, k As Short

  
  '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  Public Function GetAppPath() As String
    'GetAppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
    'GetAppPath = Application.StartupPath
    'GetAppPath = Application.ExecutablePath()
    'GetAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
    If Len(Application.StartupPath) > 3 Then
      '路径的最后一个字符总不是 \ ，是为了检测程序中的路径是不是相对路径，如果第一个字符是 \ 就说明是相对路径
      GetAppPath = Application.StartupPath
    Else
      GetAppPath = Left(Application.StartupPath, 2)
    End If
  End Function
End Module
