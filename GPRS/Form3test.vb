Imports System.Drawing.Drawing2D
Imports System.Drawing.Graphics

Public Class Form3test
    Inherits System.Windows.Forms.Form
    Private pen As Pen '创建一个画笔对象 
    Private GPath As New GraphicsPath() '实例化路径对象 
    Private Dpattern() As Single = {5.0, 7.0} '实线的长度和虚线长度 
    Private offset As Single = 0.0 '偏移值 

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
            GPath.Dispose()
            Pen.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的 
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的 
    '可以使用 Windows 窗体设计器修改此过程。 
    '不要使用代码编辑器修改它。 
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Form3test
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(416, 166)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photo For VB.NET"

    End Sub

#End Region



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Refresh() '刷新窗口 
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        pen.DashOffset = offset '设置偏移值 
        e.Graphics.DrawPath(pen, GPath) '画路径 

        '改变偏移值的量 
        offset += 1.0
        If offset / 100 = 1 Then
            offset = 0.0
        End If

    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GPath.AddString("电脑", _
        New FontFamily("幼圆"), _
        FontStyle.Bold + FontStyle.Italic, _
        120.0F, _
        New PointF(30.0F, 20.0F), _
        New StringFormat()) '添加一个字符路径 
        pen = New Pen(Color.Black) '构造画笔 
        pen.DashPattern = Dpattern '自定义的短划线和空白区域 
        pen.DashStyle = DashStyle.Custom '此属性的 DashStyle.Custom 值指定：由 DashPattern 属性定义的短划线和空白区域的自定义图案 
    End Sub
End Class

