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
      '�Ƿ񼤻��û�
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
    '      If pName = "Administrator" Then '���������Administrator��ǿ�Ʋ��ı����Ա���
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
          ChangePassword = "������������֤����"
        End If
      Else
        ChangePassword = "ԭ�������벻��ȷ��"
      End If
    End Function
    Public ReadOnly Property Password() As String
      'ֻ�ܶ�ȡ���ܸ�ֵ
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
