Public Class Form2WorkSetting
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
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TextBoxWorkName As System.Windows.Forms.TextBox
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents TextBoxWorkPath As System.Windows.Forms.TextBox
  Friend WithEvents LabelStationNoAddnew As System.Windows.Forms.Label
  Friend WithEvents TextBoxMapNameAddnew As System.Windows.Forms.TextBox
  Friend WithEvents LabelStationNoSelected As System.Windows.Forms.Label
  Friend WithEvents TextBoxMapNameSelected As System.Windows.Forms.TextBox
  Friend WithEvents NumericUpDownStationAmountAddnew As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDownStationPlacedAmountAddnew As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDownStationPlacedAmountSelected As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDownStationAmountSelected As System.Windows.Forms.NumericUpDown
  Friend WithEvents ListBoxMaps As System.Windows.Forms.ListBox
  Friend WithEvents BtnAdd As System.Windows.Forms.Button
  Friend WithEvents BtnChange As System.Windows.Forms.Button
  Friend WithEvents BtnDel As System.Windows.Forms.Button
  Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents BtnWorkPathBrowser As System.Windows.Forms.Button
  Friend WithEvents BtnMapPicBrowerAddnew As System.Windows.Forms.Button
  Friend WithEvents BtnMapPicBrowerChange As System.Windows.Forms.Button
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents BtnQuXiao As System.Windows.Forms.Button
  Friend WithEvents BtnQueDing As System.Windows.Forms.Button
  Friend WithEvents TextBoxMapPathAddnew As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxMapPathSelected As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2WorkSetting))
    Me.TextBoxWorkName = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.TextBoxWorkPath = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.BtnWorkPathBrowser = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.ListBoxMaps = New System.Windows.Forms.ListBox
    Me.Panel4 = New System.Windows.Forms.Panel
    Me.NumericUpDownStationPlacedAmountAddnew = New System.Windows.Forms.NumericUpDown
    Me.NumericUpDownStationAmountAddnew = New System.Windows.Forms.NumericUpDown
    Me.BtnAdd = New System.Windows.Forms.Button
    Me.BtnMapPicBrowerAddnew = New System.Windows.Forms.Button
    Me.TextBoxMapPathAddnew = New System.Windows.Forms.TextBox
    Me.TextBoxMapNameAddnew = New System.Windows.Forms.TextBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label13 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label15 = New System.Windows.Forms.Label
    Me.Label16 = New System.Windows.Forms.Label
    Me.LabelStationNoAddnew = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.Label9 = New System.Windows.Forms.Label
    Me.BtnDel = New System.Windows.Forms.Button
    Me.NumericUpDownStationPlacedAmountSelected = New System.Windows.Forms.NumericUpDown
    Me.NumericUpDownStationAmountSelected = New System.Windows.Forms.NumericUpDown
    Me.BtnChange = New System.Windows.Forms.Button
    Me.BtnMapPicBrowerChange = New System.Windows.Forms.Button
    Me.TextBoxMapPathSelected = New System.Windows.Forms.TextBox
    Me.TextBoxMapNameSelected = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.LabelStationNoSelected = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.BtnQuXiao = New System.Windows.Forms.Button
    Me.BtnQueDing = New System.Windows.Forms.Button
    Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel4.SuspendLayout()
    CType(Me.NumericUpDownStationPlacedAmountAddnew, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownStationAmountAddnew, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3.SuspendLayout()
    CType(Me.NumericUpDownStationPlacedAmountSelected, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownStationAmountSelected, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TextBoxWorkName
    '
    Me.TextBoxWorkName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxWorkName.Location = New System.Drawing.Point(63, 10)
    Me.TextBoxWorkName.Name = "TextBoxWorkName"
    Me.TextBoxWorkName.Size = New System.Drawing.Size(460, 21)
    Me.TextBoxWorkName.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label2.Location = New System.Drawing.Point(4, 11)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(109, 21)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "项目名称："
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(137, 419)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox1.TabIndex = 5
    Me.PictureBox1.TabStop = False
    '
    'TextBoxWorkPath
    '
    Me.TextBoxWorkPath.Enabled = False
    Me.TextBoxWorkPath.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxWorkPath.Location = New System.Drawing.Point(63, 43)
    Me.TextBoxWorkPath.Name = "TextBoxWorkPath"
    Me.TextBoxWorkPath.Size = New System.Drawing.Size(399, 21)
    Me.TextBoxWorkPath.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label1.Location = New System.Drawing.Point(4, 44)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(109, 21)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "工作目录："
    '
    'BtnWorkPathBrowser
    '
    Me.BtnWorkPathBrowser.BackColor = System.Drawing.Color.Transparent
    Me.BtnWorkPathBrowser.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnWorkPathBrowser.Enabled = False
    Me.BtnWorkPathBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnWorkPathBrowser.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnWorkPathBrowser.ForeColor = System.Drawing.Color.Black
    Me.BtnWorkPathBrowser.Image = CType(resources.GetObject("BtnWorkPathBrowser.Image"), System.Drawing.Image)
    Me.BtnWorkPathBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnWorkPathBrowser.Location = New System.Drawing.Point(467, 43)
    Me.BtnWorkPathBrowser.Name = "BtnWorkPathBrowser"
    Me.BtnWorkPathBrowser.Size = New System.Drawing.Size(56, 21)
    Me.BtnWorkPathBrowser.TabIndex = 9
    Me.BtnWorkPathBrowser.Tag = ""
    Me.BtnWorkPathBrowser.Text = "..."
    Me.BtnWorkPathBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnWorkPathBrowser, "浏览")
    Me.BtnWorkPathBrowser.UseVisualStyleBackColor = False
    '
    'Panel1
    '
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel1.Controls.Add(Me.TextBoxWorkName)
    Me.Panel1.Controls.Add(Me.TextBoxWorkPath)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.BtnWorkPathBrowser)
    Me.Panel1.Location = New System.Drawing.Point(145, 6)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(529, 74)
    Me.Panel1.TabIndex = 10
    '
    'Panel2
    '
    Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel2.Controls.Add(Me.ListBoxMaps)
    Me.Panel2.Controls.Add(Me.Panel4)
    Me.Panel2.Controls.Add(Me.Panel3)
    Me.Panel2.Font = New System.Drawing.Font("华文行楷", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Panel2.Location = New System.Drawing.Point(145, 81)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(529, 295)
    Me.Panel2.TabIndex = 11
    '
    'ListBoxMaps
    '
    Me.ListBoxMaps.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.ListBoxMaps.ItemHeight = 12
    Me.ListBoxMaps.Location = New System.Drawing.Point(3, 2)
    Me.ListBoxMaps.Name = "ListBoxMaps"
    Me.ListBoxMaps.Size = New System.Drawing.Size(147, 280)
    Me.ListBoxMaps.TabIndex = 20
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.NumericUpDownStationPlacedAmountAddnew)
    Me.Panel4.Controls.Add(Me.NumericUpDownStationAmountAddnew)
    Me.Panel4.Controls.Add(Me.BtnAdd)
    Me.Panel4.Controls.Add(Me.BtnMapPicBrowerAddnew)
    Me.Panel4.Controls.Add(Me.TextBoxMapPathAddnew)
    Me.Panel4.Controls.Add(Me.TextBoxMapNameAddnew)
    Me.Panel4.Controls.Add(Me.Label11)
    Me.Panel4.Controls.Add(Me.Label13)
    Me.Panel4.Controls.Add(Me.Label14)
    Me.Panel4.Controls.Add(Me.Label15)
    Me.Panel4.Controls.Add(Me.Label16)
    Me.Panel4.Controls.Add(Me.LabelStationNoAddnew)
    Me.Panel4.Controls.Add(Me.Label12)
    Me.Panel4.Location = New System.Drawing.Point(152, 150)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(374, 139)
    Me.Panel4.TabIndex = 19
    '
    'NumericUpDownStationPlacedAmountAddnew
    '
    Me.NumericUpDownStationPlacedAmountAddnew.Enabled = False
    Me.NumericUpDownStationPlacedAmountAddnew.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.NumericUpDownStationPlacedAmountAddnew.Location = New System.Drawing.Point(66, 111)
    Me.NumericUpDownStationPlacedAmountAddnew.Name = "NumericUpDownStationPlacedAmountAddnew"
    Me.NumericUpDownStationPlacedAmountAddnew.Size = New System.Drawing.Size(51, 21)
    Me.NumericUpDownStationPlacedAmountAddnew.TabIndex = 24
    '
    'NumericUpDownStationAmountAddnew
    '
    Me.NumericUpDownStationAmountAddnew.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.NumericUpDownStationAmountAddnew.Location = New System.Drawing.Point(66, 83)
    Me.NumericUpDownStationAmountAddnew.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.NumericUpDownStationAmountAddnew.Name = "NumericUpDownStationAmountAddnew"
    Me.NumericUpDownStationAmountAddnew.Size = New System.Drawing.Size(51, 21)
    Me.NumericUpDownStationAmountAddnew.TabIndex = 23
    Me.NumericUpDownStationAmountAddnew.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'BtnAdd
    '
    Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
    Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnAdd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnAdd.ForeColor = System.Drawing.Color.Black
    Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnAdd.Location = New System.Drawing.Point(311, 107)
    Me.BtnAdd.Name = "BtnAdd"
    Me.BtnAdd.Size = New System.Drawing.Size(58, 24)
    Me.BtnAdd.TabIndex = 22
    Me.BtnAdd.Tag = ""
    Me.BtnAdd.Text = "添加"
    Me.ToolTip1.SetToolTip(Me.BtnAdd, "添加")
    Me.BtnAdd.UseVisualStyleBackColor = False
    '
    'BtnMapPicBrowerAddnew
    '
    Me.BtnMapPicBrowerAddnew.BackColor = System.Drawing.Color.Transparent
    Me.BtnMapPicBrowerAddnew.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnMapPicBrowerAddnew.Enabled = False
    Me.BtnMapPicBrowerAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnMapPicBrowerAddnew.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnMapPicBrowerAddnew.ForeColor = System.Drawing.Color.Black
    Me.BtnMapPicBrowerAddnew.Image = CType(resources.GetObject("BtnMapPicBrowerAddnew.Image"), System.Drawing.Image)
    Me.BtnMapPicBrowerAddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnMapPicBrowerAddnew.Location = New System.Drawing.Point(313, 59)
    Me.BtnMapPicBrowerAddnew.Name = "BtnMapPicBrowerAddnew"
    Me.BtnMapPicBrowerAddnew.Size = New System.Drawing.Size(56, 21)
    Me.BtnMapPicBrowerAddnew.TabIndex = 10
    Me.BtnMapPicBrowerAddnew.Tag = ""
    Me.BtnMapPicBrowerAddnew.Text = "..."
    Me.BtnMapPicBrowerAddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnMapPicBrowerAddnew, "浏览")
    Me.BtnMapPicBrowerAddnew.UseVisualStyleBackColor = False
    '
    'TextBoxMapPathAddnew
    '
    Me.TextBoxMapPathAddnew.Enabled = False
    Me.TextBoxMapPathAddnew.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxMapPathAddnew.Location = New System.Drawing.Point(67, 58)
    Me.TextBoxMapPathAddnew.Name = "TextBoxMapPathAddnew"
    Me.TextBoxMapPathAddnew.Size = New System.Drawing.Size(243, 21)
    Me.TextBoxMapPathAddnew.TabIndex = 7
    '
    'TextBoxMapNameAddnew
    '
    Me.TextBoxMapNameAddnew.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxMapNameAddnew.Location = New System.Drawing.Point(66, 32)
    Me.TextBoxMapNameAddnew.Name = "TextBoxMapNameAddnew"
    Me.TextBoxMapNameAddnew.Size = New System.Drawing.Size(303, 21)
    Me.TextBoxMapNameAddnew.TabIndex = 5
    '
    'Label11
    '
    Me.Label11.BackColor = System.Drawing.Color.Transparent
    Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label11.Location = New System.Drawing.Point(52, 8)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(74, 21)
    Me.Label11.TabIndex = 17
    Me.Label11.Text = "张地图"
    '
    'Label13
    '
    Me.Label13.BackColor = System.Drawing.Color.Transparent
    Me.Label13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label13.Location = New System.Drawing.Point(5, 62)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(109, 21)
    Me.Label13.TabIndex = 8
    Me.Label13.Text = "地图文件："
    '
    'Label14
    '
    Me.Label14.BackColor = System.Drawing.Color.Transparent
    Me.Label14.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label14.Location = New System.Drawing.Point(5, 35)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(109, 21)
    Me.Label14.TabIndex = 6
    Me.Label14.Text = "地图名称："
    '
    'Label15
    '
    Me.Label15.BackColor = System.Drawing.Color.Transparent
    Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label15.Location = New System.Drawing.Point(5, 89)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(109, 21)
    Me.Label15.TabIndex = 12
    Me.Label15.Text = "站点数量："
    '
    'Label16
    '
    Me.Label16.BackColor = System.Drawing.Color.Transparent
    Me.Label16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label16.Location = New System.Drawing.Point(5, 113)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(110, 21)
    Me.Label16.TabIndex = 14
    Me.Label16.Text = "已有数量："
    '
    'LabelStationNoAddnew
    '
    Me.LabelStationNoAddnew.BackColor = System.Drawing.Color.Transparent
    Me.LabelStationNoAddnew.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.LabelStationNoAddnew.ForeColor = System.Drawing.Color.RoyalBlue
    Me.LabelStationNoAddnew.Location = New System.Drawing.Point(28, 5)
    Me.LabelStationNoAddnew.Name = "LabelStationNoAddnew"
    Me.LabelStationNoAddnew.Size = New System.Drawing.Size(26, 21)
    Me.LabelStationNoAddnew.TabIndex = 20
    Me.LabelStationNoAddnew.Text = "10"
    '
    'Label12
    '
    Me.Label12.BackColor = System.Drawing.Color.Transparent
    Me.Label12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label12.Location = New System.Drawing.Point(9, 8)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(26, 21)
    Me.Label12.TabIndex = 16
    Me.Label12.Text = "第"
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.Label9)
    Me.Panel3.Controls.Add(Me.BtnDel)
    Me.Panel3.Controls.Add(Me.NumericUpDownStationPlacedAmountSelected)
    Me.Panel3.Controls.Add(Me.NumericUpDownStationAmountSelected)
    Me.Panel3.Controls.Add(Me.BtnChange)
    Me.Panel3.Controls.Add(Me.BtnMapPicBrowerChange)
    Me.Panel3.Controls.Add(Me.TextBoxMapPathSelected)
    Me.Panel3.Controls.Add(Me.TextBoxMapNameSelected)
    Me.Panel3.Controls.Add(Me.Label8)
    Me.Panel3.Controls.Add(Me.Label4)
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Controls.Add(Me.Label5)
    Me.Panel3.Controls.Add(Me.Label6)
    Me.Panel3.Controls.Add(Me.LabelStationNoSelected)
    Me.Panel3.Controls.Add(Me.Label7)
    Me.Panel3.Location = New System.Drawing.Point(152, 5)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(374, 139)
    Me.Panel3.TabIndex = 18
    '
    'Label9
    '
    Me.Label9.Location = New System.Drawing.Point(163, 10)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(95, 18)
    Me.Label9.TabIndex = 28
    Me.Label9.Text = "Label9"
    Me.Label9.Visible = False
    '
    'BtnDel
    '
    Me.BtnDel.BackColor = System.Drawing.Color.Transparent
    Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnDel.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnDel.ForeColor = System.Drawing.Color.Black
    Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnDel.Location = New System.Drawing.Point(242, 107)
    Me.BtnDel.Name = "BtnDel"
    Me.BtnDel.Size = New System.Drawing.Size(58, 24)
    Me.BtnDel.TabIndex = 27
    Me.BtnDel.Tag = ""
    Me.BtnDel.Text = "删除"
    Me.ToolTip1.SetToolTip(Me.BtnDel, "删除")
    Me.BtnDel.UseVisualStyleBackColor = False
    '
    'NumericUpDownStationPlacedAmountSelected
    '
    Me.NumericUpDownStationPlacedAmountSelected.Enabled = False
    Me.NumericUpDownStationPlacedAmountSelected.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.NumericUpDownStationPlacedAmountSelected.Location = New System.Drawing.Point(67, 108)
    Me.NumericUpDownStationPlacedAmountSelected.Name = "NumericUpDownStationPlacedAmountSelected"
    Me.NumericUpDownStationPlacedAmountSelected.Size = New System.Drawing.Size(51, 21)
    Me.NumericUpDownStationPlacedAmountSelected.TabIndex = 26
    '
    'NumericUpDownStationAmountSelected
    '
    Me.NumericUpDownStationAmountSelected.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.NumericUpDownStationAmountSelected.Location = New System.Drawing.Point(67, 84)
    Me.NumericUpDownStationAmountSelected.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.NumericUpDownStationAmountSelected.Name = "NumericUpDownStationAmountSelected"
    Me.NumericUpDownStationAmountSelected.Size = New System.Drawing.Size(51, 21)
    Me.NumericUpDownStationAmountSelected.TabIndex = 25
    Me.NumericUpDownStationAmountSelected.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'BtnChange
    '
    Me.BtnChange.BackColor = System.Drawing.Color.Transparent
    Me.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnChange.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnChange.ForeColor = System.Drawing.Color.Black
    Me.BtnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnChange.Location = New System.Drawing.Point(311, 107)
    Me.BtnChange.Name = "BtnChange"
    Me.BtnChange.Size = New System.Drawing.Size(58, 24)
    Me.BtnChange.TabIndex = 19
    Me.BtnChange.Tag = ""
    Me.BtnChange.Text = "修改"
    Me.ToolTip1.SetToolTip(Me.BtnChange, "修改")
    Me.BtnChange.UseVisualStyleBackColor = False
    '
    'BtnMapPicBrowerChange
    '
    Me.BtnMapPicBrowerChange.BackColor = System.Drawing.Color.Transparent
    Me.BtnMapPicBrowerChange.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnMapPicBrowerChange.Enabled = False
    Me.BtnMapPicBrowerChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnMapPicBrowerChange.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnMapPicBrowerChange.ForeColor = System.Drawing.Color.Black
    Me.BtnMapPicBrowerChange.Image = CType(resources.GetObject("BtnMapPicBrowerChange.Image"), System.Drawing.Image)
    Me.BtnMapPicBrowerChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnMapPicBrowerChange.Location = New System.Drawing.Point(313, 59)
    Me.BtnMapPicBrowerChange.Name = "BtnMapPicBrowerChange"
    Me.BtnMapPicBrowerChange.Size = New System.Drawing.Size(56, 21)
    Me.BtnMapPicBrowerChange.TabIndex = 10
    Me.BtnMapPicBrowerChange.Tag = ""
    Me.BtnMapPicBrowerChange.Text = "..."
    Me.BtnMapPicBrowerChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnMapPicBrowerChange, "浏览")
    Me.BtnMapPicBrowerChange.UseVisualStyleBackColor = False
    '
    'TextBoxMapPathSelected
    '
    Me.TextBoxMapPathSelected.Enabled = False
    Me.TextBoxMapPathSelected.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxMapPathSelected.Location = New System.Drawing.Point(67, 58)
    Me.TextBoxMapPathSelected.Name = "TextBoxMapPathSelected"
    Me.TextBoxMapPathSelected.Size = New System.Drawing.Size(243, 21)
    Me.TextBoxMapPathSelected.TabIndex = 7
    '
    'TextBoxMapNameSelected
    '
    Me.TextBoxMapNameSelected.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxMapNameSelected.Location = New System.Drawing.Point(67, 32)
    Me.TextBoxMapNameSelected.Name = "TextBoxMapNameSelected"
    Me.TextBoxMapNameSelected.Size = New System.Drawing.Size(302, 21)
    Me.TextBoxMapNameSelected.TabIndex = 5
    '
    'Label8
    '
    Me.Label8.BackColor = System.Drawing.Color.Transparent
    Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label8.Location = New System.Drawing.Point(52, 5)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(74, 21)
    Me.Label8.TabIndex = 17
    Me.Label8.Text = "张地图"
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label4.Location = New System.Drawing.Point(4, 63)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(109, 21)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "地图文件："
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label3.Location = New System.Drawing.Point(5, 34)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(109, 21)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "地图名称："
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label5.Location = New System.Drawing.Point(5, 87)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(109, 21)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "站点数量："
    '
    'Label6
    '
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label6.Location = New System.Drawing.Point(5, 115)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(110, 21)
    Me.Label6.TabIndex = 14
    Me.Label6.Text = "已有数量："
    '
    'LabelStationNoSelected
    '
    Me.LabelStationNoSelected.BackColor = System.Drawing.Color.Transparent
    Me.LabelStationNoSelected.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.LabelStationNoSelected.ForeColor = System.Drawing.Color.RoyalBlue
    Me.LabelStationNoSelected.Location = New System.Drawing.Point(28, 2)
    Me.LabelStationNoSelected.Name = "LabelStationNoSelected"
    Me.LabelStationNoSelected.Size = New System.Drawing.Size(26, 21)
    Me.LabelStationNoSelected.TabIndex = 20
    Me.LabelStationNoSelected.Text = "10"
    '
    'Label7
    '
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label7.Location = New System.Drawing.Point(9, 5)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(26, 21)
    Me.Label7.TabIndex = 16
    Me.Label7.Text = "第"
    '
    'BtnQuXiao
    '
    Me.BtnQuXiao.BackColor = System.Drawing.Color.Transparent
    Me.BtnQuXiao.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnQuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnQuXiao.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnQuXiao.ForeColor = System.Drawing.Color.Black
    Me.BtnQuXiao.Image = CType(resources.GetObject("BtnQuXiao.Image"), System.Drawing.Image)
    Me.BtnQuXiao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnQuXiao.Location = New System.Drawing.Point(600, 389)
    Me.BtnQuXiao.Name = "BtnQuXiao"
    Me.BtnQuXiao.Size = New System.Drawing.Size(69, 25)
    Me.BtnQuXiao.TabIndex = 13
    Me.BtnQuXiao.Tag = ""
    Me.BtnQuXiao.Text = "退出"
    Me.BtnQuXiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnQuXiao, "退出")
    Me.BtnQuXiao.UseVisualStyleBackColor = False
    Me.BtnQuXiao.Visible = False
    '
    'BtnQueDing
    '
    Me.BtnQueDing.BackColor = System.Drawing.Color.Transparent
    Me.BtnQueDing.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnQueDing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnQueDing.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnQueDing.ForeColor = System.Drawing.Color.Black
    Me.BtnQueDing.Image = CType(resources.GetObject("BtnQueDing.Image"), System.Drawing.Image)
    Me.BtnQueDing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnQueDing.Location = New System.Drawing.Point(600, 389)
    Me.BtnQueDing.Name = "BtnQueDing"
    Me.BtnQueDing.Size = New System.Drawing.Size(69, 25)
    Me.BtnQueDing.TabIndex = 14
    Me.BtnQueDing.Tag = ""
    Me.BtnQueDing.Text = "确定"
    Me.BtnQueDing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnQueDing, "取消")
    Me.BtnQueDing.UseVisualStyleBackColor = False
    '
    'Form2WorkSetting
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(675, 425)
    Me.Controls.Add(Me.BtnQueDing)
    Me.Controls.Add(Me.BtnQuXiao)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Name = "Form2WorkSetting"
    Me.Text = "工程设置"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.Panel4.PerformLayout()
    CType(Me.NumericUpDownStationPlacedAmountAddnew, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownStationAmountAddnew, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    CType(Me.NumericUpDownStationPlacedAmountSelected, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownStationAmountSelected, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region
  Dim tmpCW As GPRSWork
  Dim ClickBtnQueDing As Boolean
  Private Sub SetLocation()
    If CW.Active = False Then Exit Sub
    Dim i As Integer
    With tmpCW
      TextBoxWorkName.Text = .WorkName
      TextBoxWorkPath.Text = .WorkPath
      ListBoxMaps.Items.Clear()
      For i = 1 To .MapAmount
        ListBoxMaps.Items.Add(.Maps(i).MapName)
      Next i
      ListBoxMaps.SelectedIndex = 0
      LabelStationNoAddnew.Text = .MapAmount + 1
      NumericUpDownStationAmountAddnew.Text = STATION_MAX_NO
      NumericUpDownStationPlacedAmountAddnew.Text = 0

    End With
  End Sub

  Private Sub Form2WorkSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    tmpCW = New GPRSWork
    tmpCW = CW
    ClickBtnQueDing = False
    form2WorkSettingRun = True
    SetLocation()
  End Sub

  Private Sub ListBoxMaps_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxMaps.SelectedIndexChanged
    With tmpCW.Maps(ListBoxMaps.SelectedIndex + 1)
      LabelStationNoSelected.Text = ListBoxMaps.SelectedIndex + 1
      TextBoxMapNameSelected.Text = .MapName
      'TextBoxMapNameAddnew.Text = .MapName
      TextBoxMapPathSelected.Text = .MapPath
      'TextBoxMapPicAddnew.Text = .MapPath
      NumericUpDownStationAmountSelected.Text = .MapStationAmount
      NumericUpDownStationPlacedAmountSelected.Text = .MapStationPlacedAmount


    End With
  End Sub

  Private Sub NumericUpDownStationAmountSelected_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownStationAmountSelected.ValueChanged, NumericUpDownStationAmountAddnew.ValueChanged
    CWChanged = True
    If NumericUpDownStationAmountSelected.Text < 1 Then
      NumericUpDownStationAmountSelected.Text = 1
    ElseIf NumericUpDownStationAmountSelected.Text > STATION_MAX_NO Then
      NumericUpDownStationAmountSelected.Text = STATION_MAX_NO
    End If

    If NumericUpDownStationAmountAddnew.Text < 1 Then
      NumericUpDownStationAmountAddnew.Text = 1
    ElseIf NumericUpDownStationAmountAddnew.Text > STATION_MAX_NO Then
      NumericUpDownStationAmountAddnew.Text = STATION_MAX_NO
    End If
  End Sub
  Private Sub NumericUpDownStationAmountAddnew_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDownStationAmountAddnew.KeyDown, NumericUpDownStationAmountSelected.KeyDown
    CWChanged = True
    If NumericUpDownStationAmountSelected.Text < 1 Then
      NumericUpDownStationAmountSelected.Text = 1
    ElseIf NumericUpDownStationAmountSelected.Text > STATION_MAX_NO Then
      NumericUpDownStationAmountSelected.Text = STATION_MAX_NO
    End If

    If NumericUpDownStationAmountAddnew.Text < 1 Then
      NumericUpDownStationAmountAddnew.Text = 1
    ElseIf NumericUpDownStationAmountAddnew.Text > STATION_MAX_NO Then
      NumericUpDownStationAmountAddnew.Text = STATION_MAX_NO
    End If
  End Sub


  Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChange.Click
    CWChanged = True
    If NumericUpDownStationAmountSelected.Text < 1 Then
      NumericUpDownStationAmountSelected.Text = 1
    ElseIf NumericUpDownStationAmountSelected.Text > STATION_MAX_NO Then
      NumericUpDownStationAmountSelected.Text = STATION_MAX_NO
    End If

    With tmpCW.Maps(ListBoxMaps.SelectedIndex + 1)
      If Trim(TextBoxMapNameSelected.Text) <> "" Then
        .MapName = TextBoxMapNameSelected.Text
        'Else
        '  Exit Sub
      End If

      If Trim(TextBoxMapPathSelected.Text) <> "" Then
        .MapPath = TextBoxMapPathSelected.Text
        '.MapPath = CW.WorkPath & "\Maps\Map" & tmpCW.MapAmount.ToString & ".bmp"
        'Else
        '  Exit Sub
      End If

      .MapStationAmount = NumericUpDownStationAmountSelected.Text
      SetLocation()
    End With
    '((((((((((((((((((((((((((((((
    Label9.Text = CW.MapAmount
    '))))))))))))))))))))))))))))))
  End Sub

  Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
    CWChanged = True
    If NumericUpDownStationAmountAddnew.Text < 1 Then
      NumericUpDownStationAmountAddnew.Text = 1
    ElseIf NumericUpDownStationAmountAddnew.Text > STATION_MAX_NO Then
      NumericUpDownStationAmountAddnew.Text = STATION_MAX_NO
    End If

    'tmpCW.AddMap()
    'With tmpCW.Maps(tmpCW.MapAmount)
    If Trim(TextBoxMapNameAddnew.Text) <> "" Then
      tmpCW.AddMap()
      With tmpCW.Maps(tmpCW.MapAmount)
        .MapName = TextBoxMapNameAddnew.Text
        If Trim(TextBoxMapPathAddnew.Text) <> "" Then
          .MapPath = TextBoxMapPathAddnew.Text
          .MapPath = CW.WorkPath & "\Maps\Map" & tmpCW.MapAmount.ToString & ".bmp"
        Else
          .MapPath = CW.WorkPath & "\Maps\Map" & tmpCW.MapAmount.ToString & ".bmp"
        End If
        .MapStationAmount = NumericUpDownStationAmountAddnew.Text
        SetLocation()
      End With
    Else
      MsgBox("请输入地图名称。")
      Exit Sub
    End If
    '((((((((((((((((((((((((((((((
    Label9.Text = CW.MapAmount
    '))))))))))))))))))))))))))))))
    'If Trim(TextBoxMapPathAddnew.Text) <> "" Then
    '  .MapPath = TextBoxMapPathAddnew.Text
    'Else
    '  Exit Sub
    'End If
    '.MapStationAmount = NumericUpDownStationAmountAddnew.Text
    'SetLocation()


  End Sub

  Protected Overrides Sub OnClosed(ByVal e As System.EventArgs)
    form2WorkSettingRun = False
  End Sub

  Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
    Dim i As Integer
    i = MsgBox("真的要删除吗？", MsgBoxStyle.YesNo)
    If i = vbYes Then
      If tmpCW.DelMap(ListBoxMaps.SelectedIndex + 1) Then
        CWChanged = True
      End If
      SetLocation()
    End If

    '((((((((((((((((((((((((((((((
    Label9.Text = CW.MapAmount
    '))))))))))))))))))))))))))))))
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuXiao.Click
    CWChanged = False
    Me.Close()
  End Sub

  Private Sub BtnWorkPathBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWorkPathBrowser.Click
    FolderBrowserDialog1.Description = "请选择当前工程的工作目录。"
    FolderBrowserDialog1.ShowNewFolderButton = False
    FolderBrowserDialog1.ShowDialog()
    If FolderBrowserDialog1.SelectedPath <> "" Then
      TextBoxWorkPath.Text = FolderBrowserDialog1.SelectedPath
      CWChanged = True
    End If
  End Sub

  Private Sub BtnMapPicBrowerChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMapPicBrowerChange.Click
    OpenFileDialog1.DefaultExt = "bmp"
    OpenFileDialog1.Multiselect = False
    OpenFileDialog1.Filter = "图像文件 (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"
    OpenFileDialog1.ShowDialog()
    If OpenFileDialog1.FileName <> "" Then
      TextBoxMapPathSelected.Text = OpenFileDialog1.FileName
      CWChanged = True
    End If
  End Sub

  Private Sub BtnMapPicBrowerAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMapPicBrowerAddnew.Click
    OpenFileDialog1.DefaultExt = "bmp"
    OpenFileDialog1.Multiselect = False
    OpenFileDialog1.Filter = "图像文件 (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"
    OpenFileDialog1.ShowDialog()
    If OpenFileDialog1.FileName <> "" Then
      TextBoxMapPathAddnew.Text = OpenFileDialog1.FileName
      CWChanged = True
    End If
  End Sub

  Private Sub TextBoxWorkName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxWorkName.TextChanged
    CWChanged = True
  End Sub

  Private Sub BtnQueDing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQueDing.Click
    ClickBtnQueDing = True

    Me.Close()
  End Sub

End Class
