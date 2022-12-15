Public Class ClassLine
  Public Class Line
    Inherits System.Windows.Forms.UserControl
    Public TopLC As System.Drawing.Color = System.Drawing.Color.White '上线颜色 
    Public FootLC As System.Drawing.Color = System.Drawing.Color.Black '下线颜色 
    Public LineT As Type '直线类型 
    Public Enum Type
      Tf '凸 
      Ft '凹 
      Flat '平面 
    End Enum
#Region " Windows 窗体设计器生成的代码 "
    Public Sub New()
      MyBase.New()
      '该调用是 Windows 窗体设计器所必需的。 
      InitializeComponent()
      '在 InitializeComponent() 调用之后添加任何初始化 
    End Sub
    'UserControl 重写 dispose 以清理组件列表。 
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      ' 
      'Line 
      ' 
      Me.Name = "Line"
      Me.Size = New System.Drawing.Size(304, 72)
    End Sub
#End Region
#Region " 属性 "
    <System.ComponentModel.Description("直线类型：" & vbCrLf & "Tf '凸" & vbCrLf & "Ft '凹" & vbCrLf & "Flat '平面")> Public Property LineType() As Type
      Get
        LineType = LineT
      End Get
      Set(ByVal Value As Type)
        LineT = Value
      End Set
    End Property
    <System.ComponentModel.Description("上线颜色")> Public Property TopLineColor() As System.Drawing.Color
      Get
        TopLineColor = TopLC
      End Get
      Set(ByVal Value As System.Drawing.Color)
        TopLC = Value
      End Set
    End Property
    <System.ComponentModel.Description("下线颜色")> Public Property FootLineColor() As System.Drawing.Color
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
