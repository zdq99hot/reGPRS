Public Class Form3TXSetting
    Inherits System.Windows.Forms.Form

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
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents BtnSelctNextStation As System.Windows.Forms.Button
  Friend WithEvents BtnSelctPerStation As System.Windows.Forms.Button
  Friend WithEvents TrackBarListenTimeLong As System.Windows.Forms.TrackBar
  Friend WithEvents NumericUpDownSrvPort As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents CheckBoxSysAutoM As System.Windows.Forms.CheckBox
  Friend WithEvents NumericUpDownListenTimeLong As System.Windows.Forms.NumericUpDown
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3TXSetting))
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.TrackBarListenTimeLong = New System.Windows.Forms.TrackBar
    Me.BtnSelctNextStation = New System.Windows.Forms.Button
    Me.BtnSelctPerStation = New System.Windows.Forms.Button
    Me.NumericUpDownSrvPort = New System.Windows.Forms.NumericUpDown
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label9 = New System.Windows.Forms.Label
    Me.CheckBoxSysAutoM = New System.Windows.Forms.CheckBox
    Me.NumericUpDownListenTimeLong = New System.Windows.Forms.NumericUpDown
    CType(Me.TrackBarListenTimeLong, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownSrvPort, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownListenTimeLong, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(14, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(68, 18)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "侦听端口："
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(14, 50)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(104, 18)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "侦听延时(毫秒)："
    '
    'TrackBarListenTimeLong
    '
    Me.TrackBarListenTimeLong.LargeChange = 50
    Me.TrackBarListenTimeLong.Location = New System.Drawing.Point(116, 47)
    Me.TrackBarListenTimeLong.Maximum = 1000
    Me.TrackBarListenTimeLong.Name = "TrackBarListenTimeLong"
    Me.TrackBarListenTimeLong.Size = New System.Drawing.Size(207, 45)
    Me.TrackBarListenTimeLong.TabIndex = 3
    Me.TrackBarListenTimeLong.Value = 50
    '
    'BtnSelctNextStation
    '
    Me.BtnSelctNextStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnSelctNextStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnSelctNextStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSelctNextStation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnSelctNextStation.ForeColor = System.Drawing.Color.Black
    Me.BtnSelctNextStation.Image = CType(resources.GetObject("BtnSelctNextStation.Image"), System.Drawing.Image)
    Me.BtnSelctNextStation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnSelctNextStation.Location = New System.Drawing.Point(251, 113)
    Me.BtnSelctNextStation.Name = "BtnSelctNextStation"
    Me.BtnSelctNextStation.Size = New System.Drawing.Size(68, 23)
    Me.BtnSelctNextStation.TabIndex = 10
    Me.BtnSelctNextStation.Tag = ""
    Me.BtnSelctNextStation.Text = "取消"
    Me.BtnSelctNextStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnSelctPerStation
    '
    Me.BtnSelctPerStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnSelctPerStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnSelctPerStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSelctPerStation.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnSelctPerStation.ForeColor = System.Drawing.Color.Black
    Me.BtnSelctPerStation.Image = CType(resources.GetObject("BtnSelctPerStation.Image"), System.Drawing.Image)
    Me.BtnSelctPerStation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnSelctPerStation.Location = New System.Drawing.Point(166, 113)
    Me.BtnSelctPerStation.Name = "BtnSelctPerStation"
    Me.BtnSelctPerStation.Size = New System.Drawing.Size(62, 23)
    Me.BtnSelctPerStation.TabIndex = 9
    Me.BtnSelctPerStation.Tag = ""
    Me.BtnSelctPerStation.Text = "确定"
    Me.BtnSelctPerStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'NumericUpDownSrvPort
    '
    Me.NumericUpDownSrvPort.Location = New System.Drawing.Point(116, 15)
    Me.NumericUpDownSrvPort.Maximum = New Decimal(New Integer() {5500, 0, 0, 0})
    Me.NumericUpDownSrvPort.Minimum = New Decimal(New Integer() {5000, 0, 0, 0})
    Me.NumericUpDownSrvPort.Name = "NumericUpDownSrvPort"
    Me.NumericUpDownSrvPort.Size = New System.Drawing.Size(207, 21)
    Me.NumericUpDownSrvPort.TabIndex = 11
    Me.NumericUpDownSrvPort.Value = New Decimal(New Integer() {5000, 0, 0, 0})
    '
    'Label3
    '
    Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(120, 79)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(34, 11)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "0"
    '
    'Label4
    '
    Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Location = New System.Drawing.Point(155, 79)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(34, 11)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "200"
    '
    'Label5
    '
    Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Location = New System.Drawing.Point(190, 79)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(34, 11)
    Me.Label5.TabIndex = 14
    Me.Label5.Text = "400"
    '
    'Label6
    '
    Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Location = New System.Drawing.Point(225, 79)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(34, 11)
    Me.Label6.TabIndex = 15
    Me.Label6.Text = "600"
    '
    'Label7
    '
    Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Location = New System.Drawing.Point(260, 79)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(34, 11)
    Me.Label7.TabIndex = 16
    Me.Label7.Text = "800"
    '
    'Label8
    '
    Me.Label8.BackColor = System.Drawing.Color.Transparent
    Me.Label8.Location = New System.Drawing.Point(313, 2)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(23, 11)
    Me.Label8.TabIndex = 17
    Me.Label8.Text = "450"
    Me.Label8.Visible = False
    '
    'Label9
    '
    Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label9.BackColor = System.Drawing.Color.Transparent
    Me.Label9.Location = New System.Drawing.Point(288, 79)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(29, 11)
    Me.Label9.TabIndex = 18
    Me.Label9.Text = "1000"
    '
    'CheckBoxSysAutoM
    '
    Me.CheckBoxSysAutoM.Location = New System.Drawing.Point(11, 112)
    Me.CheckBoxSysAutoM.Name = "CheckBoxSysAutoM"
    Me.CheckBoxSysAutoM.Size = New System.Drawing.Size(125, 18)
    Me.CheckBoxSysAutoM.TabIndex = 20
    Me.CheckBoxSysAutoM.Text = "自动维护用户列表"
    '
    'NumericUpDownListenTimeLong
    '
    Me.NumericUpDownListenTimeLong.Increment = New Decimal(New Integer() {50, 0, 0, 0})
    Me.NumericUpDownListenTimeLong.Location = New System.Drawing.Point(19, 68)
    Me.NumericUpDownListenTimeLong.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
    Me.NumericUpDownListenTimeLong.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
    Me.NumericUpDownListenTimeLong.Name = "NumericUpDownListenTimeLong"
    Me.NumericUpDownListenTimeLong.Size = New System.Drawing.Size(77, 21)
    Me.NumericUpDownListenTimeLong.TabIndex = 22
    Me.NumericUpDownListenTimeLong.Value = New Decimal(New Integer() {50, 0, 0, 0})
    '
    'Form3TXSetting
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(337, 151)
    Me.Controls.Add(Me.NumericUpDownListenTimeLong)
    Me.Controls.Add(Me.CheckBoxSysAutoM)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.NumericUpDownSrvPort)
    Me.Controls.Add(Me.BtnSelctNextStation)
    Me.Controls.Add(Me.BtnSelctPerStation)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.TrackBarListenTimeLong)
    Me.Controls.Add(Me.Label2)
    Me.Name = "Form3TXSetting"
    Me.Text = "监听设置"
    CType(Me.TrackBarListenTimeLong, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownSrvPort, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownListenTimeLong, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub SetLocation()
    Try
      NumericUpDownSrvPort.Text = SrvPort
    Catch ex As Exception
      NumericUpDownSrvPort.Text = 5000
    End Try

    'Try
    '  TrackBarListenTimeLong.Value = ListenTimeLong / 50 - 3
    'Catch ex As Exception
    '  TrackBarListenTimeLong.Value = 200
    'End Try
    Try
      TrackBarListenTimeLong.Value = ListenTimeLong
      NumericUpDownListenTimeLong.Text = ListenTimeLong
    Catch ex As Exception
      TrackBarListenTimeLong.Value = 200
      NumericUpDownListenTimeLong.Text = 200
    End Try

    Try
      If CSng(SysAutoM) <> 0 Then
        CheckBoxSysAutoM.Checked = True
      Else
        CheckBoxSysAutoM.Checked = False
      End If
    Catch ex As Exception
      CheckBoxSysAutoM.Checked = False
    End Try
  End Sub

  Private Sub Form3TXSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SetLocation()
  End Sub

  Private Sub BtnSelctPerStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelctPerStation.Click
    SrvPort = NumericUpDownSrvPort.Text
    'ListenTimeLong = (TrackBarListenTimeLong.Value + 3) * 50
    ListenTimeLong = NumericUpDownListenTimeLong.Text
    RWTXini(False)
    Me.Close()
  End Sub

  Private Sub BtnSelctNextStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelctNextStation.Click
    Me.Close()
  End Sub

  Private Sub CheckBoxSysAutoM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSysAutoM.CheckedChanged
    If CheckBoxSysAutoM.Checked Then
      SysAutoM = 1
    Else
      SysAutoM = 0
    End If
  End Sub

  Private Sub TrackBarListenTimeLong_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarListenTimeLong.Scroll
    Try
      NumericUpDownListenTimeLong.Text = TrackBarListenTimeLong.Value
    Catch ex As Exception
      NumericUpDownListenTimeLong.Text = 50
    End Try
  End Sub
End Class
