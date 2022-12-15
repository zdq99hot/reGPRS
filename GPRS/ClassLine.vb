Public Class ClassLine
  Public Class Line
    Inherits System.Windows.Forms.UserControl
    Public TopLC As System.Drawing.Color = System.Drawing.Color.White '������ɫ 
    Public FootLC As System.Drawing.Color = System.Drawing.Color.Black '������ɫ 
    Public LineT As Type 'ֱ������ 
    Public Enum Type
      Tf '͹ 
      Ft '�� 
      Flat 'ƽ�� 
    End Enum
#Region " Windows ������������ɵĴ��� "
    Public Sub New()
      MyBase.New()
      '�õ����� Windows ���������������ġ� 
      InitializeComponent()
      '�� InitializeComponent() ����֮������κγ�ʼ�� 
    End Sub
    'UserControl ��д dispose ����������б� 
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      ' 
      'Line 
      ' 
      Me.Name = "Line"
      Me.Size = New System.Drawing.Size(304, 72)
    End Sub
#End Region
#Region " ���� "
    <System.ComponentModel.Description("ֱ�����ͣ�" & vbCrLf & "Tf '͹" & vbCrLf & "Ft '��" & vbCrLf & "Flat 'ƽ��")> Public Property LineType() As Type
      Get
        LineType = LineT
      End Get
      Set(ByVal Value As Type)
        LineT = Value
      End Set
    End Property
    <System.ComponentModel.Description("������ɫ")> Public Property TopLineColor() As System.Drawing.Color
      Get
        TopLineColor = TopLC
      End Get
      Set(ByVal Value As System.Drawing.Color)
        TopLC = Value
      End Set
    End Property
    <System.ComponentModel.Description("������ɫ")> Public Property FootLineColor() As System.Drawing.Color
      Get
        FootLineColor = FootLC
      End Get
      Set(ByVal Value As System.Drawing.Color)
        FootLC = Value
      End Set
    End Property
#End Region
    Private Sub Line_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
      Dim TopLine As New Pen(Me.TopLineColor)
      Dim FootLine As New Pen(Me.FootLineColor)
      Dim startX As Integer
      Dim startY As Integer
      Select Case LineT
        Case LineT.Flat
          e.Graphics.DrawLine(TopLine, 0 + startX, 0, Me.Width + startX, 0)
          e.Graphics.DrawLine(TopLine, 1 + startX, 1, Me.Width + startX, 1)
        Case LineT.Tf
          e.Graphics.DrawLine(TopLine, 0 + startX, 0, Me.Width + startX, 0)
          e.Graphics.DrawLine(FootLine, 1 + startX, 1, Me.Width + startX, 1)
        Case LineT.Ft
          e.Graphics.DrawLine(FootLine, 0 + startX, 0, Me.Width + startX, 0)
          e.Graphics.DrawLine(TopLine, 1 + startX, 1, Me.Width + startX, 1)
      End Select
    End Sub
    Private Sub Line_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
      Me.Height = 2
    End Sub
  End Class

End Class
