Public Class Form9User
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
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents BtnExit As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents LabelMM As System.Windows.Forms.Label
  Friend WithEvents TextBoxY As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxJ As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxK As System.Windows.Forms.TextBox
  Friend WithEvents BtnY As System.Windows.Forms.Button
  Friend WithEvents BtnJ As System.Windows.Forms.Button
  Friend WithEvents TextBoxUserPwdOld As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxUserPwdNew0 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxUserPwdNew1 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
  Friend WithEvents BtnUserAdd As System.Windows.Forms.Button
  Friend WithEvents BtnUserDel As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9User))
    Me.ListBox1 = New System.Windows.Forms.ListBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.TextBoxUserName = New System.Windows.Forms.TextBox
    Me.TextBoxUserPwdOld = New System.Windows.Forms.TextBox
    Me.TextBoxUserPwdNew0 = New System.Windows.Forms.TextBox
    Me.TextBoxUserPwdNew1 = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.BtnUserAdd = New System.Windows.Forms.Button
    Me.BtnExit = New System.Windows.Forms.Button
    Me.BtnUserDel = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.BtnJ = New System.Windows.Forms.Button
    Me.BtnY = New System.Windows.Forms.Button
    Me.TextBoxK = New System.Windows.Forms.TextBox
    Me.TextBoxJ = New System.Windows.Forms.TextBox
    Me.TextBoxY = New System.Windows.Forms.TextBox
    Me.LabelMM = New System.Windows.Forms.Label
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ListBox1
    '
    Me.ListBox1.ItemHeight = 12
    Me.ListBox1.Location = New System.Drawing.Point(0, 24)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(184, 244)
    Me.ListBox1.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(0, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(136, 24)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "已有用户："
    '
    'TextBoxUserName
    '
    Me.TextBoxUserName.Location = New System.Drawing.Point(200, 40)
    Me.TextBoxUserName.Name = "TextBoxUserName"
    Me.TextBoxUserName.Size = New System.Drawing.Size(200, 21)
    Me.TextBoxUserName.TabIndex = 2
    '
    'TextBoxUserPwdOld
    '
    Me.TextBoxUserPwdOld.Location = New System.Drawing.Point(200, 80)
    Me.TextBoxUserPwdOld.Name = "TextBoxUserPwdOld"
    Me.TextBoxUserPwdOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
    Me.TextBoxUserPwdOld.Size = New System.Drawing.Size(200, 21)
    Me.TextBoxUserPwdOld.TabIndex = 3
    '
    'TextBoxUserPwdNew0
    '
    Me.TextBoxUserPwdNew0.Location = New System.Drawing.Point(200, 136)
    Me.TextBoxUserPwdNew0.Name = "TextBoxUserPwdNew0"
    Me.TextBoxUserPwdNew0.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
    Me.TextBoxUserPwdNew0.Size = New System.Drawing.Size(200, 21)
    Me.TextBoxUserPwdNew0.TabIndex = 4
    '
    'TextBoxUserPwdNew1
    '
    Me.TextBoxUserPwdNew1.Location = New System.Drawing.Point(200, 176)
    Me.TextBoxUserPwdNew1.Name = "TextBoxUserPwdNew1"
    Me.TextBoxUserPwdNew1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
    Me.TextBoxUserPwdNew1.Size = New System.Drawing.Size(200, 21)
    Me.TextBoxUserPwdNew1.TabIndex = 5
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(200, 24)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(136, 24)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "用户名："
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(200, 64)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(136, 24)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "密码："
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(200, 120)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(136, 24)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "新密码："
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(200, 160)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(136, 24)
    Me.Label5.TabIndex = 9
    Me.Label5.Text = "重复新密码："
    '
    'BtnUserAdd
    '
    Me.BtnUserAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnUserAdd.Image = CType(resources.GetObject("BtnUserAdd.Image"), System.Drawing.Image)
    Me.BtnUserAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnUserAdd.Location = New System.Drawing.Point(416, 24)
    Me.BtnUserAdd.Name = "BtnUserAdd"
    Me.BtnUserAdd.Size = New System.Drawing.Size(88, 29)
    Me.BtnUserAdd.TabIndex = 54
    Me.BtnUserAdd.Text = "修改/添加"
    Me.BtnUserAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnExit
    '
    Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
    Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit.Location = New System.Drawing.Point(416, 176)
    Me.BtnExit.Name = "BtnExit"
    Me.BtnExit.Size = New System.Drawing.Size(88, 29)
    Me.BtnExit.TabIndex = 53
    Me.BtnExit.Text = "退出"
    Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnUserDel
    '
    Me.BtnUserDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnUserDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnUserDel.Image = CType(resources.GetObject("BtnUserDel.Image"), System.Drawing.Image)
    Me.BtnUserDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnUserDel.Location = New System.Drawing.Point(416, 72)
    Me.BtnUserDel.Name = "BtnUserDel"
    Me.BtnUserDel.Size = New System.Drawing.Size(88, 29)
    Me.BtnUserDel.TabIndex = 52
    Me.BtnUserDel.Text = "删除用户"
    Me.BtnUserDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Panel1
    '
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel1.Controls.Add(Me.BtnJ)
    Me.Panel1.Controls.Add(Me.BtnY)
    Me.Panel1.Controls.Add(Me.TextBoxK)
    Me.Panel1.Controls.Add(Me.TextBoxJ)
    Me.Panel1.Controls.Add(Me.TextBoxY)
    Me.Panel1.Location = New System.Drawing.Point(200, 208)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(272, 56)
    Me.Panel1.TabIndex = 55
    Me.Panel1.Visible = False
    '
    'BtnJ
    '
    Me.BtnJ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.BtnJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnJ.Image = CType(resources.GetObject("BtnJ.Image"), System.Drawing.Image)
    Me.BtnJ.Location = New System.Drawing.Point(48, 32)
    Me.BtnJ.Name = "BtnJ"
    Me.BtnJ.Size = New System.Drawing.Size(48, 24)
    Me.BtnJ.TabIndex = 4
    '
    'BtnY
    '
    Me.BtnY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.BtnY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnY.Image = CType(resources.GetObject("BtnY.Image"), System.Drawing.Image)
    Me.BtnY.Location = New System.Drawing.Point(0, 32)
    Me.BtnY.Name = "BtnY"
    Me.BtnY.Size = New System.Drawing.Size(48, 24)
    Me.BtnY.TabIndex = 3
    '
    'TextBoxK
    '
    Me.TextBoxK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxK.Location = New System.Drawing.Point(240, 0)
    Me.TextBoxK.Name = "TextBoxK"
    Me.TextBoxK.Size = New System.Drawing.Size(32, 21)
    Me.TextBoxK.TabIndex = 2
    '
    'TextBoxJ
    '
    Me.TextBoxJ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxJ.Location = New System.Drawing.Point(32, 32)
    Me.TextBoxJ.Name = "TextBoxJ"
    Me.TextBoxJ.Size = New System.Drawing.Size(240, 21)
    Me.TextBoxJ.TabIndex = 1
    '
    'TextBoxY
    '
    Me.TextBoxY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.TextBoxY.Location = New System.Drawing.Point(0, 0)
    Me.TextBoxY.Name = "TextBoxY"
    Me.TextBoxY.Size = New System.Drawing.Size(240, 21)
    Me.TextBoxY.TabIndex = 0
    '
    'LabelMM
    '
    Me.LabelMM.Location = New System.Drawing.Point(528, 0)
    Me.LabelMM.Name = "LabelMM"
    Me.LabelMM.Size = New System.Drawing.Size(24, 24)
    Me.LabelMM.TabIndex = 56
    '
    'Form9User
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(520, 270)
    Me.Controls.Add(Me.LabelMM)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.BtnUserAdd)
    Me.Controls.Add(Me.BtnExit)
    Me.Controls.Add(Me.BtnUserDel)
    Me.Controls.Add(Me.TextBoxUserPwdNew1)
    Me.Controls.Add(Me.TextBoxUserPwdNew0)
    Me.Controls.Add(Me.TextBoxUserPwdOld)
    Me.Controls.Add(Me.TextBoxUserName)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label5)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.Name = "Form9User"
    Me.Text = "用户管理"
    Me.TopMost = True
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region

  Dim IsAdmin As Boolean
  Private Sub SetLocation()
    Dim i As Integer

    TextBoxUserName.Text = ""
    TextBoxUserPwdOld.Text = ""
    TextBoxUserPwdNew0.Text = ""
    TextBoxUserPwdNew1.Text = ""

    If AUsers.ActiveNo <= 1 Then
      IsAdmin = True
      ListBox1.Items.Clear()
      For i = 1 To AUsers.UserAmount
        ListBox1.Items.Add(AUsers.Users(i).Name)
      Next i
    Else
      IsAdmin = False
      ListBox1.Items.Clear()
      ListBox1.Items.Add(AUsers.Users(AUsers.ActiveNo).Name)
    End If
    TextBoxUserName.Enabled = IsAdmin
    BtnUserDel.Enabled = IsAdmin
  End Sub

  Private Sub Form9User_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
    Form1.SetLocationActivePerson()
  End Sub
  Private Sub Form9User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SetLocation()
  End Sub

  Private Sub BtnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJ.Click
    TextBoxJ.Text = EDS.En(TextBoxY.Text)
  End Sub

  Private Sub BtnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnY.Click
    TextBoxY.Text = EDS.De(TextBoxJ.Text)
  End Sub

  Private Sub LabelMM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelMM.DoubleClick
    Panel1.Visible = Not (Panel1.Visible)
  End Sub

  Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    If IsAdmin Then
      TextBoxUserName.Text = AUsers.Users(ListBox1.SelectedIndex + 1).Name
    Else
      TextBoxUserName.Text = AUsers.Users(AUsers.ActiveNo).Name
    End If
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    Me.Close()
  End Sub

  Private Sub BtnUserDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUserDel.Click
    Dim i, UserNo As Integer
    If AUsers.UserAmount <= 1 Then Exit Sub
    UserNo = ListBox1.SelectedIndex + 1
    Dim UserName As String

    UserName = StrConv(Trim(TextBoxUserName.Text), VbStrConv.LowerCase)

    If UserName = StrConv(AUsers.Users(1).Name, VbStrConv.LowerCase) Then
      MessageBox.Show("不能删除管理员。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    If UserName <> StrConv(AUsers.Users(UserNo).Name, VbStrConv.LowerCase) Then
      UserNo = -1
      For i = 2 To AUsers.UserAmount
        If UserName = StrConv(AUsers.Users(i).Name, VbStrConv.LowerCase) Then
          UserNo = i
          Exit For
        End If
      Next i
      If UserNo = -1 Then
        MessageBox.Show("不能删除,因为不识别用户名。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If
    End If

    If MessageBox.Show("真的要删除用户:" & Trim(AUsers.Users(UserNo).Name) & " 吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
      If TextBoxUserPwdOld.Text = AUsers.Users(1).Password Then
        For i = UserNo To AUsers.UserAmount - 1
          AUsers.Users(i) = AUsers.Users(i + 1)
        Next i
        AUsers.UserAmount -= 1
        RWUsersIni(False)
        SetLocation()
      Else
        MessageBox.Show("请在密码框里输入管理员 Administrator 的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub BtnUserAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUserAdd.Click
    Dim i, UserNo As Integer
    Dim S As String
    If IsAdmin Then
      UserNo = ListBox1.SelectedIndex + 1
    Else
      UserNo = AUsers.ActiveNo
    End If
    Dim UserName As String
    UserName = StrConv(Trim(TextBoxUserName.Text), VbStrConv.LowerCase)

    Select Case IsAdmin

      Case True
        If UserName <> StrConv(AUsers.Users(UserNo).Name, VbStrConv.LowerCase) Then
          UserNo = -1
          For i = 1 To AUsers.UserAmount
            If UserName = StrConv(AUsers.Users(i).Name, VbStrConv.LowerCase) Then
              UserNo = i
              Exit For
            End If
          Next i
          If UserNo = -1 Then
            If MessageBox.Show("真的要添加用户：" & Trim(TextBoxUserName.Text) & " 吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
              If TextBoxUserPwdOld.Text = AUsers.Users(1).Password Then
                If TextBoxUserPwdNew0.Text <> TextBoxUserPwdNew1.Text Then
                  MessageBox.Show("新密码验证错误，请从新输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                  UserNo = AUsers.UserAmount + 1
                  AUsers.UserAmount = UserNo
                  AUsers.Users(UserNo).Name = Trim(TextBoxUserName.Text)
                  AUsers.Users(UserNo).ChangePassword("", TextBoxUserPwdNew0.Text, TextBoxUserPwdNew0.Text)
                  RWUsersIni(False, UserNo)
                  MessageBox.Show("用户：" & AUsers.Users(UserNo).Name & " 已成功添加。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                  SetLocation()
                End If
              Else
                MessageBox.Show("请在密码框里输入管理员 Administrator 的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
              End If
            End If
          Else
            If TextBoxUserPwdOld.Text = AUsers.Users(1).Password Then
              S = AUsers.Users(UserNo).ChangePassword(AUsers.Users(UserNo).Password, TextBoxUserPwdNew0.Text, TextBoxUserPwdNew1.Text)
              If S = "" Then
                RWUsersIni(False, UserNo)
                MessageBox.Show("用户：" & AUsers.Users(UserNo).Name & " 已成功修改。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
              Else
                MessageBox.Show(S, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
              End If
            Else
              MessageBox.Show("请在密码框里输入管理员 Administrator 的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

          End If
        Else
          If TextBoxUserPwdOld.Text = AUsers.Users(1).Password Then
            S = AUsers.Users(UserNo).ChangePassword(AUsers.Users(UserNo).Password, TextBoxUserPwdNew0.Text, TextBoxUserPwdNew1.Text)
            If S = "" Then
              RWUsersIni(False, UserNo)
              MessageBox.Show("用户：" & AUsers.Users(UserNo).Name & " 已成功修改。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
              MessageBox.Show(S, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
          Else
            MessageBox.Show("请在密码框里输入管理员 Administrator 的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        End If

      Case False

        S = AUsers.Users(UserNo).ChangePassword(TextBoxUserPwdOld.Text, TextBoxUserPwdNew0.Text, TextBoxUserPwdNew1.Text)
        If S <> "" Then
          MessageBox.Show(S, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
          RWUsersIni(False, UserNo)
          MessageBox.Show("用户信息已成功修改。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Select


  End Sub
End Class
