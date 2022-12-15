Public Class ControlShowParameter
    Inherits System.Windows.Forms.UserControl

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
    MyBase.New()

    '该调用是 Windows 窗体设计器所必需的。
    InitializeComponent()

    '在 InitializeComponent() 调用之后添加任何初始化
    LabelName.Text = ""
    LabelValue.Text = ""
    LabelPartName.Text = ""
    Tag0 = ""
    Tag1 = ""
    Tag2 = ""
    'AddHandler LabelName.Click, AddressOf ControlShowParameter_Click
    'AddHandler LabelValue.Click, AddressOf ControlShowParameter_Click
    'AddHandler LabelPartName.Click, AddressOf ControlShowParameter_Click
    'AddHandler Label1.Click, AddressOf ControlShowParameter_Click
    End Sub

    'UserControl 重写 dispose 以清理组件列表。
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
  Friend WithEvents LabelValue As System.Windows.Forms.Label
  Friend WithEvents LabelName As System.Windows.Forms.Label
  Friend WithEvents LabelPartName As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ControlShowParameter))
    Me.LabelValue = New System.Windows.Forms.Label
    Me.LabelName = New System.Windows.Forms.Label
    Me.LabelPartName = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'LabelValue
    '
    Me.LabelValue.AccessibleDescription = resources.GetString("LabelValue.AccessibleDescription")
    Me.LabelValue.AccessibleName = resources.GetString("LabelValue.AccessibleName")
    Me.LabelValue.Anchor = CType(resources.GetObject("LabelValue.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.LabelValue.AutoSize = CType(resources.GetObject("LabelValue.AutoSize"), Boolean)
    Me.LabelValue.BackColor = System.Drawing.Color.DimGray
    Me.LabelValue.Dock = CType(resources.GetObject("LabelValue.Dock"), System.Windows.Forms.DockStyle)
    Me.LabelValue.Enabled = CType(resources.GetObject("LabelValue.Enabled"), Boolean)
    Me.LabelValue.Font = CType(resources.GetObject("LabelValue.Font"), System.Drawing.Font)
    Me.LabelValue.ForeColor = System.Drawing.Color.Navy
    Me.LabelValue.Image = CType(resources.GetObject("LabelValue.Image"), System.Drawing.Image)
    Me.LabelValue.ImageAlign = CType(resources.GetObject("LabelValue.ImageAlign"), System.Drawing.ContentAlignment)
    Me.LabelValue.ImageIndex = CType(resources.GetObject("LabelValue.ImageIndex"), Integer)
    Me.LabelValue.ImeMode = CType(resources.GetObject("LabelValue.ImeMode"), System.Windows.Forms.ImeMode)
    Me.LabelValue.Location = CType(resources.GetObject("LabelValue.Location"), System.Drawing.Point)
    Me.LabelValue.Name = "LabelValue"
    Me.LabelValue.RightToLeft = CType(resources.GetObject("LabelValue.RightToLeft"), System.Windows.Forms.RightToLeft)
    Me.LabelValue.Size = CType(resources.GetObject("LabelValue.Size"), System.Drawing.Size)
    Me.LabelValue.TabIndex = CType(resources.GetObject("LabelValue.TabIndex"), Integer)
    Me.LabelValue.Text = resources.GetString("LabelValue.Text")
    Me.LabelValue.TextAlign = CType(resources.GetObject("LabelValue.TextAlign"), System.Drawing.ContentAlignment)
    Me.LabelValue.Visible = CType(resources.GetObject("LabelValue.Visible"), Boolean)
    '
    'LabelName
    '
    Me.LabelName.AccessibleDescription = resources.GetString("LabelName.AccessibleDescription")
    Me.LabelName.AccessibleName = resources.GetString("LabelName.AccessibleName")
    Me.LabelName.Anchor = CType(resources.GetObject("LabelName.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.LabelName.AutoSize = CType(resources.GetObject("LabelName.AutoSize"), Boolean)
    Me.LabelName.BackColor = System.Drawing.Color.Transparent
    Me.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelName.Dock = CType(resources.GetObject("LabelName.Dock"), System.Windows.Forms.DockStyle)
    Me.LabelName.Enabled = CType(resources.GetObject("LabelName.Enabled"), Boolean)
    Me.LabelName.Font = CType(resources.GetObject("LabelName.Font"), System.Drawing.Font)
    Me.LabelName.Image = CType(resources.GetObject("LabelName.Image"), System.Drawing.Image)
    Me.LabelName.ImageAlign = CType(resources.GetObject("LabelName.ImageAlign"), System.Drawing.ContentAlignment)
    Me.LabelName.ImageIndex = CType(resources.GetObject("LabelName.ImageIndex"), Integer)
    Me.LabelName.ImeMode = CType(resources.GetObject("LabelName.ImeMode"), System.Windows.Forms.ImeMode)
    Me.LabelName.Location = CType(resources.GetObject("LabelName.Location"), System.Drawing.Point)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.RightToLeft = CType(resources.GetObject("LabelName.RightToLeft"), System.Windows.Forms.RightToLeft)
    Me.LabelName.Size = CType(resources.GetObject("LabelName.Size"), System.Drawing.Size)
    Me.LabelName.TabIndex = CType(resources.GetObject("LabelName.TabIndex"), Integer)
    Me.LabelName.Text = resources.GetString("LabelName.Text")
    Me.LabelName.TextAlign = CType(resources.GetObject("LabelName.TextAlign"), System.Drawing.ContentAlignment)
    Me.LabelName.Visible = CType(resources.GetObject("LabelName.Visible"), Boolean)
    '
    'LabelPartName
    '
    Me.LabelPartName.AccessibleDescription = resources.GetString("LabelPartName.AccessibleDescription")
    Me.LabelPartName.AccessibleName = resources.GetString("LabelPartName.AccessibleName")
    Me.LabelPartName.Anchor = CType(resources.GetObject("LabelPartName.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.LabelPartName.AutoSize = CType(resources.GetObject("LabelPartName.AutoSize"), Boolean)
    Me.LabelPartName.BackColor = System.Drawing.Color.DimGray
    Me.LabelPartName.Dock = CType(resources.GetObject("LabelPartName.Dock"), System.Windows.Forms.DockStyle)
    Me.LabelPartName.Enabled = CType(resources.GetObject("LabelPartName.Enabled"), Boolean)
    Me.LabelPartName.Font = CType(resources.GetObject("LabelPartName.Font"), System.Drawing.Font)
    Me.LabelPartName.ForeColor = System.Drawing.Color.Gold
    Me.LabelPartName.Image = CType(resources.GetObject("LabelPartName.Image"), System.Drawing.Image)
    Me.LabelPartName.ImageAlign = CType(resources.GetObject("LabelPartName.ImageAlign"), System.Drawing.ContentAlignment)
    Me.LabelPartName.ImageIndex = CType(resources.GetObject("LabelPartName.ImageIndex"), Integer)
    Me.LabelPartName.ImeMode = CType(resources.GetObject("LabelPartName.ImeMode"), System.Windows.Forms.ImeMode)
    Me.LabelPartName.Location = CType(resources.GetObject("LabelPartName.Location"), System.Drawing.Point)
    Me.LabelPartName.Name = "LabelPartName"
    Me.LabelPartName.RightToLeft = CType(resources.GetObject("LabelPartName.RightToLeft"), System.Windows.Forms.RightToLeft)
    Me.LabelPartName.Size = CType(resources.GetObject("LabelPartName.Size"), System.Drawing.Size)
    Me.LabelPartName.TabIndex = CType(resources.GetObject("LabelPartName.TabIndex"), Integer)
    Me.LabelPartName.Text = resources.GetString("LabelPartName.Text")
    Me.LabelPartName.TextAlign = CType(resources.GetObject("LabelPartName.TextAlign"), System.Drawing.ContentAlignment)
    Me.LabelPartName.Visible = CType(resources.GetObject("LabelPartName.Visible"), Boolean)
    '
    'Label1
    '
    Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
    Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
    Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
    Me.Label1.BackColor = System.Drawing.Color.Navy
    Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
    Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
    Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
    Me.Label1.ForeColor = System.Drawing.Color.Cyan
    Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
    Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
    Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
    Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
    Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
    Me.Label1.Name = "Label1"
    Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
    Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
    Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
    Me.Label1.Text = resources.GetString("Label1.Text")
    Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
    Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
    '
    'ControlShowParameter
    '
    Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
    Me.AccessibleName = resources.GetString("$this.AccessibleName")
    Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
    Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
    Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
    Me.BackColor = System.Drawing.Color.Gold
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.Controls.Add(Me.LabelValue)
    Me.Controls.Add(Me.LabelPartName)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.LabelName)
    Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
    Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
    Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
    Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
    Me.Name = "ControlShowParameter"
    Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
    Me.Size = CType(resources.GetObject("$this.Size"), System.Drawing.Size)
    Me.ResumeLayout(False)

  End Sub

#End Region
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
