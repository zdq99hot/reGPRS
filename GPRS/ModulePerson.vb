Module ModulePerson
  Public Class GPRSPerson
    Private pName As String
    'Private pGroup As String
    'Private pIsAdministrator As Boolean
    'Private pIsSuperAdministrator As Boolean
    Private pPassword As String
    Private pActive As Boolean
    Public PerLogin As Integer
    Public SavePws As Integer
    'Public OldPassword, InputPassword1, InputPassword2 As String
    Sub New()
      pName = "Guest" & CInt(Int(900 * Rnd() + 100))
      'pGroup = "Guests"
      'pIsAdministrator = False
      pPassword = ""
      PerLogin = 0
      SavePws = 0
    End Sub
    Public Property Active() As Boolean
      '是否激活用户
      Get
        Return pActive
      End Get
      Set(ByVal Value As Boolean)
        pActive = Value
      End Set
    End Property
    'Public Property IsAdministrator() As Boolean
    '  Get
    '    Return pIsAdministrator
    '  End Get
    '  Set(ByVal Value As Boolean)
    '    pIsAdministrator = Value
    '    If pIsAdministrator = True Then
    '      pGroup = "Administrators"
    '      'If Right(pName, 5) = "Guest" Then
    '      '  pName = "Administrator" & CInt(Int(900 * Rnd() + 100))
    '      'End If
    '    Else
    '      If pName = "Administrator" Then '如果名字是Administrator则强制不改变管理员身份
    '        pIsAdministrator = True
    '      Else
    '        pGroup = "Guests"
    '      End If
    '    End If
    '  End Set
    'End Property
    Public Function ChangePassword(ByVal OldPassword As String, ByVal InputPassword1 As String, ByVal InputPassword2 As String) As String
      ChangePassword = ""
      If OldPassword = pPassword Then
        If InputPassword1 = InputPassword2 Then
          pPassword = InputPassword1
        Else
          ChangePassword = "新密码输入验证错误。"
        End If
      Else
        ChangePassword = "原密码输入不正确。"
      End If
    End Function
    Public ReadOnly Property Password() As String
      '只能读取不能赋值
      Get
        Return pPassword
      End Get
    End Property


    Public Property Name() As String
      Get
        Return pName
      End Get
      Set(ByVal Value As String)
        If pName <> "Administrator" And pName <> "Superadministrator" Then
          If Value <> "" Then
            pName = Value
          End If
        End If
      End Set
    End Property

  End Class
End Module
