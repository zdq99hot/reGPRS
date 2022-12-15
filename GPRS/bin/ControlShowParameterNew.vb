Public Class ControlShowParameterNew
  Public Tag0 As String
  Public Tag1 As String
  Public Tag2 As String
  Public Sub Alarm()
    LabelValue.ForeColor = System.Drawing.Color.Navy
    LabelValue.BackColor = System.Drawing.Color.Red
  End Sub
  Public Sub OK()
    LabelValue.ForeColor = System.Drawing.Color.Navy
    LabelValue.BackColor = System.Drawing.Color.SpringGreen
  End Sub
  Public Sub NoIdea()
    LabelValue.ForeColor = System.Drawing.Color.White
    LabelValue.BackColor = System.Drawing.Color.DimGray
  End Sub
  Public Property MyForeColor() As System.Drawing.Color
    Get
      Return LabelValue.ForeColor
    End Get
    Set(ByVal Value As System.Drawing.Color)
      LabelValue.ForeColor = Value
    End Set
  End Property
  Public Property FontBackColor() As System.Drawing.Color
    Get
      Return LabelValue.BackColor
    End Get
    Set(ByVal Value As System.Drawing.Color)
      LabelValue.BackColor = Value
      'Label1.BackColor = Value
    End Set
  End Property

  Public Property ParameterName() As String
    Get
      Return LabelName.Text
    End Get
    Set(ByVal Value As String)
      LabelName.Text = Value
    End Set
  End Property
  Public Property ValueString() As String
    Get
      Return LabelValue.Text
    End Get
    Set(ByVal Value As String)
      LabelValue.Text = Value
    End Set
  End Property
  Public Property PartName() As String
    Get
      Return LabelPartName.Text
    End Get
    Set(ByVal Value As String)
      LabelPartName.Text = Value
    End Set
  End Property
  Public Property MyBackColor() As System.Drawing.Color
    Get
      Return Me.BackColor
    End Get
    Set(ByVal Value As System.Drawing.Color)
      Me.BackColor = Value
    End Set
  End Property

  'Public Sub ControlShowParameter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click

  'End Sub

End Class
