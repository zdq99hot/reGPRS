<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlShowParameterNew
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.LabelValue = New System.Windows.Forms.Label
    Me.LabelPartName = New System.Windows.Forms.Label
    Me.LabelName = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'LabelValue
    '
    Me.LabelValue.BackColor = System.Drawing.Color.DimGray
    Me.LabelValue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
    Me.LabelValue.ForeColor = System.Drawing.Color.Navy
    Me.LabelValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.LabelValue.Location = New System.Drawing.Point(170, 4)
    Me.LabelValue.Name = "LabelValue"
    Me.LabelValue.Size = New System.Drawing.Size(111, 18)
    Me.LabelValue.TabIndex = 33
    Me.LabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelPartName
    '
    Me.LabelPartName.BackColor = System.Drawing.Color.DimGray
    Me.LabelPartName.ForeColor = System.Drawing.Color.Gold
    Me.LabelPartName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.LabelPartName.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.LabelPartName.Location = New System.Drawing.Point(282, 4)
    Me.LabelPartName.Name = "LabelPartName"
    Me.LabelPartName.Size = New System.Drawing.Size(64, 18)
    Me.LabelPartName.TabIndex = 35
    Me.LabelPartName.Text = "立方米/秒"
    Me.LabelPartName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelName
    '
    Me.LabelName.BackColor = System.Drawing.Color.Transparent
    Me.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.LabelName.Location = New System.Drawing.Point(4, 4)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(166, 18)
    Me.LabelName.TabIndex = 34
    Me.LabelName.Text = "一号锅炉出水流量："
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Navy
    Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
    Me.Label1.ForeColor = System.Drawing.Color.Cyan
    Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label1.Location = New System.Drawing.Point(2, 2)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(344, 22)
    Me.Label1.TabIndex = 36
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ControlShowParameterNew
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Gold
    Me.Controls.Add(Me.LabelValue)
    Me.Controls.Add(Me.LabelPartName)
    Me.Controls.Add(Me.LabelName)
    Me.Controls.Add(Me.Label1)
    Me.MaximumSize = New System.Drawing.Size(348, 26)
    Me.MinimumSize = New System.Drawing.Size(348, 26)
    Me.Name = "ControlShowParameterNew"
    Me.Size = New System.Drawing.Size(348, 26)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LabelValue As System.Windows.Forms.Label
  Friend WithEvents LabelPartName As System.Windows.Forms.Label
  Friend WithEvents LabelName As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
