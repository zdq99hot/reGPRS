Public Class Form5About
    Inherits System.Windows.Forms.Form

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
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
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
    Me.Label1.Text = "�����Ϣ��"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.Label2.Location = New System.Drawing.Point(172, 32)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(190, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "��    �ƣ�HZY-GPRS�������ϵͳ"
    '
    'LabelVer
    '
    Me.LabelVer.AutoSize = True
    Me.LabelVer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelVer.Location = New System.Drawing.Point(172, 48)
    Me.LabelVer.Name = "LabelVer"
    Me.LabelVer.Size = New System.Drawing.Size(252, 17)
    Me.LabelVer.TabIndex = 3
    Me.LabelVer.Text = "��    ������ʾ�� Ver1.0.0 Build 20050405"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.Label4.Location = New System.Drawing.Point(172, 65)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(208, 17)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "��Ȩ��˾���������Զ����Ǳ��о��� "
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
    Me.Button1.Text = "ȷ��"
    '
    'LabelCopyRight
    '
    Me.LabelCopyRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelCopyRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.LabelCopyRight.Location = New System.Drawing.Point(168, 120)
    Me.LabelCopyRight.Name = "LabelCopyRight"
    Me.LabelCopyRight.Size = New System.Drawing.Size(296, 48)
    Me.LabelCopyRight.TabIndex = 8
    Me.LabelCopyRight.Text = "�����԰����������ɢ��������Ҫ����ԭ������"
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(168, 100)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(88, 16)
    Me.Label6.TabIndex = 7
    Me.Label6.Text = "���Э�飺"
    '
    'LabelUseRight
    '
    Me.LabelUseRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelUseRight.Location = New System.Drawing.Point(168, 136)
    Me.LabelUseRight.Name = "LabelUseRight"
    Me.LabelUseRight.Size = New System.Drawing.Size(232, 16)
    Me.LabelUseRight.TabIndex = 9
    Me.LabelUseRight.Text = "���÷����롢�޸ĺ�������ҵ��;��"
    '
    'LabelHit
    '
    Me.LabelHit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.LabelHit.Location = New System.Drawing.Point(168, 152)
    Me.LabelHit.Name = "LabelHit"
    Me.LabelHit.Size = New System.Drawing.Size(296, 16)
    Me.LabelHit.TabIndex = 10
    Me.LabelHit.Text = "3.���򣬱���˾��Ȩ����������������⳥��"
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
    Me.Text = "����"
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
      S = "��ʾ��"
    Else
      S = "��ʽ��"
    End If

    If PM.VerMode = "Demo" Then
      RTxtXieYi.AppendText("1.�����԰����������ɢ��������Ҫ����ԭ������" & vbNewLine)
      RTxtXieYi.AppendText("2.���÷����롢�޸ĺ�������ҵ��;��" & vbNewLine)
      RTxtXieYi.AppendText("��Υ�������������˾��Ȩ����������������⳥��" & vbNewLine)
    ElseIf PM.VerMode = "Public" Then
      RTxtXieYi.AppendText("1.������Ȩ�û����⣬���ð�װӦ�ñ������" & vbNewLine)
      RTxtXieYi.AppendText("2.���÷����롢�޸ĺ��ٷ����������" & vbNewLine)
      RTxtXieYi.AppendText("��Υ�������������˾��Ȩ����������������⳥��" & vbNewLine)
      'RTxtXieYi.AppendText("4.���򣬱���˾��Ȩ����������������⳥��")
    End If

    'If PM.VerMode = "Demo" Then
    '  LabelCopyRight.Text = "1.�����԰����������ɢ��������Ҫ����ԭ������"
    'Else
    '  LabelCopyRight.Text = "1.������Ȩ�û����⣬���ð�װӦ�ñ������"
    'End If

    'If PM.VerMode = "Demo" Then
    '  LabelUseRight.Text = "2.���÷����롢�޸ĺ�������ҵ��;��"
    'Else
    '  LabelUseRight.Text = "2.���÷����롢�޸ĺ��ٷ����������"
    'End If

    'If PM.VerMode = "Demo" Then
    '  LabelHit.Text = "3.���򣬱���˾��Ȩ����������������⳥��"
    'Else
    '  LabelHit.Text = "3.���򣬱���˾��Ȩ����������������⳥��"
    'End If

    LabelVer.Text = "��    ����" & S & " Ver1.0.0 Build " & PM.VerNum
    RichTextBox1.Text = "2005��4��5�գ���һ����ʾ�淢����" & vbNewLine
    RichTextBox1.AppendText("2005��04��07��00:43�����RWini�ࣻ������ShowStationGif()������Ϊ��ȡվ����׼����" & vbNewLine)
    RichTextBox1.AppendText("2005��04��07��20:05��SetWorkAll��������,Ϊ��ȡվ����׼����INI�洢���̲���ʵ�֡�" & vbNewLine)
    RichTextBox1.AppendText("2005��04��10��02:25�����ڽ����ȡ�����ļ����ļ�ֵ�����⡣" & vbNewLine)
    RichTextBox1.AppendText("2005��04��25��02:11����ɱ��桢��ȡ���̵�ͼ��վ����Ϣ��" & vbNewLine)
    RichTextBox1.AppendText("2005��0X��XX��XX:XX����ɱ��桢��ȡվ��������Ϣ����ֻʣ��ͨѶ�ˡ�" & vbNewLine)
    RichTextBox1.AppendText("2005��07��28��10:11�����ڿ��������ˣ�����Ϊ�ֻ���ûǮ�ˡ�" & vbNewLine)
    RichTextBox1.AppendText("2005��08��07��05:41�����д��������ɡ�" & vbNewLine)
    RichTextBox1.AppendText("2005��08��17��17:39���޸�վ����ϸ������ʾ��" & vbNewLine)
    RichTextBox1.AppendText("2005��08��19��17:25���޸�վ����ϸ������ʾ����ͼ������Ӳ�ѯ��ť��" & vbNewLine)
    RichTextBox1.AppendText("2005��09��14��17:22������û����èID�������б����ʾ���⣻������ϸ��Ϣ�ڵ�һ�ν����Ժ��ٴν������ݲ�ˢ�����⡣" & vbNewLine)
    RichTextBox1.AppendText("2005��XX��XX��XX:XX����ӱ����ʾ��վ�������" & vbNewLine)
    RichTextBox1.AppendText("2005��12��28��01:39������߳����⡣" & vbNewLine)
    RichTextBox1.AppendText("2005��12��29��20:08�����ͨѶ�������⡣" & vbNewLine)
    RichTextBox1.AppendText("2006��01��05��02:02����Ӽ�¼�汾���ܡ�" & vbNewLine)
    RichTextBox1.AppendText("2006��01��14��05:38������RST��" & vbNewLine)


    '������tools����汾�š�
  End Sub
End Class
