Public Class Form5About
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
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents LabelVer As System.Windows.Forms.Label
  Friend WithEvents LabelCopyRight As System.Windows.Forms.Label
  Friend WithEvents LabelUseRight As System.Windows.Forms.Label
  Friend WithEvents LabelHit As System.Windows.Forms.Label
  Friend WithEvents RTxtXieYi As System.Windows.Forms.RichTextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form5About))
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.LabelVer = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
    Me.Button1 = New System.Windows.Forms.Button
    Me.LabelCopyRight = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.LabelUseRight = New System.Windows.Forms.Label
    Me.LabelHit = New System.Windows.Forms.Label
    Me.RTxtXieYi = New System.Windows.Forms.RichTextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(144, 144)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(168, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 16)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "软件信息："
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.Label2.Location = New System.Drawing.Point(172, 32)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(190, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "名    称：HZY-GPRS热网监测系统"
    '
    'LabelVer
    '
    Me.LabelVer.AutoSize = True
    Me.LabelVer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelVer.Location = New System.Drawing.Point(172, 48)
    Me.LabelVer.Name = "LabelVer"
    Me.LabelVer.Size = New System.Drawing.Size(252, 17)
    Me.LabelVer.TabIndex = 3
    Me.LabelVer.Text = "版    本：演示版 Ver1.0.0 Build 20050405"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.Label4.Location = New System.Drawing.Point(172, 65)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(208, 17)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "版权公司：哈尔滨自动化仪表研究所 "
    '
    'RichTextBox1
    '
    Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.RichTextBox1.Location = New System.Drawing.Point(156, 8)
    Me.RichTextBox1.Name = "RichTextBox1"
    Me.RichTextBox1.Size = New System.Drawing.Size(320, 260)
    Me.RichTextBox1.TabIndex = 5
    Me.RichTextBox1.Text = ""
    Me.RichTextBox1.Visible = False
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(392, 280)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(72, 24)
    Me.Button1.TabIndex = 6
    Me.Button1.Text = "确定"
    '
    'LabelCopyRight
    '
    Me.LabelCopyRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelCopyRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.LabelCopyRight.Location = New System.Drawing.Point(168, 120)
    Me.LabelCopyRight.Name = "LabelCopyRight"
    Me.LabelCopyRight.Size = New System.Drawing.Size(296, 48)
    Me.LabelCopyRight.TabIndex = 8
    Me.LabelCopyRight.Text = "本测试版软件可任意散布，但是要标明原出处。"
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(168, 100)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(88, 16)
    Me.Label6.TabIndex = 7
    Me.Label6.Text = "许可协议："
    '
    'LabelUseRight
    '
    Me.LabelUseRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelUseRight.Location = New System.Drawing.Point(168, 136)
    Me.LabelUseRight.Name = "LabelUseRight"
    Me.LabelUseRight.Size = New System.Drawing.Size(232, 16)
    Me.LabelUseRight.TabIndex = 9
    Me.LabelUseRight.Text = "不得反编译、修改和用于商业用途。"
    '
    'LabelHit
    '
    Me.LabelHit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelHit.Location = New System.Drawing.Point(168, 152)
    Me.LabelHit.Name = "LabelHit"
    Me.LabelHit.Size = New System.Drawing.Size(296, 16)
    Me.LabelHit.TabIndex = 10
    Me.LabelHit.Text = "3.否则，本公司有权在最大法律许可下提出赔偿。"
    '
    'RTxtXieYi
    '
    Me.RTxtXieYi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.RTxtXieYi.Location = New System.Drawing.Point(168, 120)
    Me.RTxtXieYi.Name = "RTxtXieYi"
    Me.RTxtXieYi.Size = New System.Drawing.Size(296, 92)
    Me.RTxtXieYi.TabIndex = 11
    Me.RTxtXieYi.Text = ""
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.White
    Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label3.Location = New System.Drawing.Point(168, 28)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(296, 60)
    Me.Label3.TabIndex = 12
    '
    'Form5About
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(480, 318)
    Me.Controls.Add(Me.RTxtXieYi)
    Me.Controls.Add(Me.LabelHit)
    Me.Controls.Add(Me.LabelUseRight)
    Me.Controls.Add(Me.LabelCopyRight)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.LabelVer)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.RichTextBox1)
    Me.Name = "Form5About"
    Me.Text = "关于"
    Me.ResumeLayout(False)

  End Sub

#End Region
  Dim CN As Integer
  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Me.Close()
  End Sub

  Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    If RichTextBox1.Visible Then
      RichTextBox1.SendToBack()
      RichTextBox1.Visible = False
    Else
      CN += 1
      If CN = 5 Then
        'If RichTextBox1.Visible = False Then
        RichTextBox1.BringToFront()
        RichTextBox1.Visible = True
        CN = 0
        'End If
      End If
    End If

  End Sub

  Private Sub Form5About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim S As String
    If PM.VerMode = "Demo" Then
      S = "演示版"
    Else
      S = "正式版"
    End If

    If PM.VerMode = "Demo" Then
      RTxtXieYi.AppendText("1.本测试版软件可任意散布，但是要声明原出处。" & vbNewLine)
      RTxtXieYi.AppendText("2.不得反编译、修改和用于商业用途。" & vbNewLine)
      RTxtXieYi.AppendText("如违反以上条款，本公司有权在最大法律许可下提出赔偿。" & vbNewLine)
    ElseIf PM.VerMode = "Public" Then
      RTxtXieYi.AppendText("1.除已授权用户以外，不得安装应用本软件。" & vbNewLine)
      RTxtXieYi.AppendText("2.不得反编译、修改和再发布本软件。" & vbNewLine)
      RTxtXieYi.AppendText("如违反以上条款，本公司有权在最大法律许可下提出赔偿。" & vbNewLine)
      'RTxtXieYi.AppendText("4.否则，本公司有权在最大法律许可下提出赔偿。")
    End If

    'If PM.VerMode = "Demo" Then
    '  LabelCopyRight.Text = "1.本测试版软件可任意散布，但是要标明原出处。"
    'Else
    '  LabelCopyRight.Text = "1.除已授权用户以外，不得安装应用本软件。"
    'End If

    'If PM.VerMode = "Demo" Then
    '  LabelUseRight.Text = "2.不得反编译、修改和用于商业用途。"
    'Else
    '  LabelUseRight.Text = "2.不得反编译、修改和再发布本软件。"
    'End If

    'If PM.VerMode = "Demo" Then
    '  LabelHit.Text = "3.否则，本公司有权在最大法律许可下提出赔偿。"
    'Else
    '  LabelHit.Text = "3.否则，本公司有权在最大法律许可下提出赔偿。"
    'End If

    LabelVer.Text = "版    本：" & S & " Ver1.0.0 Build " & PM.VerNum
    RichTextBox1.Text = "2005年4月5日，第一个演示版发布。" & vbNewLine
    RichTextBox1.AppendText("2005年04月07日00:43，添加RWini类；独立出ShowStationGif()函数，为读取站点做准备。" & vbNewLine)
    RichTextBox1.AppendText("2005年04月07日20:05，SetWorkAll独立出来,为读取站点做准备；INI存储工程不能实现。" & vbNewLine)
    RichTextBox1.AppendText("2005年04月10日02:25，终于解决读取设置文件中文键值的难题。" & vbNewLine)
    RichTextBox1.AppendText("2005年04月25日02:11，完成保存、读取工程地图及站点信息。" & vbNewLine)
    RichTextBox1.AppendText("2005年0X月XX日XX:XX，完成保存、读取站点数据信息，就只剩下通讯了。" & vbNewLine)
    RichTextBox1.AppendText("2005年07月28日10:11，终于可以连上了，是因为手机卡没钱了。" & vbNewLine)
    RichTextBox1.AppendText("2005年08月07日05:41，所有代码基本完成。" & vbNewLine)
    RichTextBox1.AppendText("2005年08月17日17:39，修改站点详细参数显示。" & vbNewLine)
    RichTextBox1.AppendText("2005年08月19日17:25，修改站点详细参数显示背景图，并添加查询按钮。" & vbNewLine)
    RichTextBox1.AppendText("2005年09月14日17:22，修正没分配猫ID在在线列表的显示问题；参数详细信息在第一次接收以后再次接收数据不刷新问题。" & vbNewLine)
    RichTextBox1.AppendText("2005年XX月XX日XX:XX，添加表格显示各站点参数。" & vbNewLine)
    RichTextBox1.AppendText("2005年12月28日01:39，解决线程问题。" & vbNewLine)
    RichTextBox1.AppendText("2005年12月29日20:08，解决通讯幽灵问题。" & vbNewLine)
    RichTextBox1.AppendText("2006年01月05日02:02，添加记录版本功能。" & vbNewLine)
    RichTextBox1.AppendText("2006年01月14日05:38，修正RST。" & vbNewLine)


    '别忘了tools里面版本号。
  End Sub
End Class
