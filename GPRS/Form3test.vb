Imports System.Drawing.Drawing2D
Imports System.Drawing.Graphics

Public Class Form3test
    Inherits System.Windows.Forms.Form
    Private pen As Pen '����һ�����ʶ��� 
    Private GPath As New GraphicsPath() 'ʵ����·������ 
    Private Dpattern() As Single = {5.0, 7.0} 'ʵ�ߵĳ��Ⱥ����߳��� 
    Private offset As Single = 0.0 'ƫ��ֵ 

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ� 
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ�� 

    End Sub

    '������д dispose ����������б� 
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

    'Windows ���������������� 
    Private components As System.ComponentModel.IContainer

    'ע��: ���¹����� Windows ���������������� 
    '����ʹ�� Windows ����������޸Ĵ˹��̡� 
    '��Ҫʹ�ô���༭���޸����� 
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
        Me.Refresh() 'ˢ�´��� 
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        pen.DashOffset = offset '����ƫ��ֵ 
        e.Graphics.DrawPath(pen, GPath) '��·�� 

        '�ı�ƫ��ֵ���� 
        offset += 1.0
        If offset / 100 = 1 Then
            offset = 0.0
        End If

    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GPath.AddString("����", _
        New FontFamily("��Բ"), _
        FontStyle.Bold + FontStyle.Italic, _
        120.0F, _
        New PointF(30.0F, 20.0F), _
        New StringFormat()) '���һ���ַ�·�� 
        pen = New Pen(Color.Black) '���컭�� 
        pen.DashPattern = Dpattern '�Զ���Ķ̻��ߺͿհ����� 
        pen.DashStyle = DashStyle.Custom '�����Ե� DashStyle.Custom ֵָ������ DashPattern ���Զ���Ķ̻��ߺͿհ�������Զ���ͼ�� 
    End Sub
End Class

