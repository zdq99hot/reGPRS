Module M1



  'Public Const MAP_INFO_NO As Short = 5 '�м��ֵ�ͼ����
  'Public Const STATION_INFO_NO As Short = 8  '�м���վ������
  'Public Const STATION_PROPERTY_NO As Short = 2  '�м���վ�����Ե�����
  'Public StationGifAlarm(1) As String '��¼վ�������ͱ���ʱ���õ�ͼƬ,20050313 ��Ϊ������StationGifPic
  Dim i, j, k As Short

  
  '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  Public Function GetAppPath() As String
    'GetAppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
    'GetAppPath = Application.StartupPath
    'GetAppPath = Application.ExecutablePath()
    'GetAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
    If Len(Application.StartupPath) > 3 Then
      '·�������һ���ַ��ܲ��� \ ����Ϊ�˼������е�·���ǲ������·���������һ���ַ��� \ ��˵�������·��
      GetAppPath = Application.StartupPath
    Else
      GetAppPath = Left(Application.StartupPath, 2)
    End If
  End Function
End Module
