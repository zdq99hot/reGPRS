Public Class Form2
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
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

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    '
    'Form2
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(728, 478)
    Me.Name = "Form2"

  End Sub

#End Region
    
    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

  Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub
End Class
