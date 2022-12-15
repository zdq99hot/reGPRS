Public Class Form4Print
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
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  'Friend WithEvents AxmyOCXPrint1 As AxmyPrintOCX.AxmyOCXPrint
  Friend WithEvents BtnSelctNextStation As System.Windows.Forms.Button
  Friend WithEvents BtnSelctPerStation As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxMap As System.Windows.Forms.ComboBox
  Friend WithEvents ComboBoxSingleStation As System.Windows.Forms.ComboBox
  Friend WithEvents ComboBoxMulitStop As System.Windows.Forms.ComboBox
  Friend WithEvents ComboBoxMulitStart As System.Windows.Forms.ComboBox
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPageSingle As System.Windows.Forms.TabPage
  Friend WithEvents TabPageMulit As System.Windows.Forms.TabPage
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents BtnExit As System.Windows.Forms.Button
  Friend WithEvents BtnNextMap As System.Windows.Forms.Button
  Friend WithEvents BtnPerMap As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents PanelPrint As System.Windows.Forms.Panel
  Friend WithEvents BtnNextPage As System.Windows.Forms.Button
  Friend WithEvents BtnPerPage As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxSelectPage As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents NumericUpDownTop As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDownLeft As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents BtnRefresh As System.Windows.Forms.Button
  Friend WithEvents BtnPrinting As System.Windows.Forms.Button
  Friend WithEvents GroupBoxSelectPrinter As System.Windows.Forms.GroupBox
  Friend WithEvents TextBoxSelectedPrinter As System.Windows.Forms.TextBox
  Friend WithEvents ListBoxPrinter As System.Windows.Forms.ListBox
  Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents MOP As AxmyPrintOCX.AxmyOCXPrint
  Friend WithEvents BtnExit2 As System.Windows.Forms.Button
  Friend WithEvents Axset_printer1 As AxSETPRINTERLib.Axset_printer
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4Print))
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
    Me.ComboBoxMap = New System.Windows.Forms.ComboBox
    Me.ComboBoxSingleStation = New System.Windows.Forms.ComboBox
    Me.BtnSelctNextStation = New System.Windows.Forms.Button
    Me.BtnSelctPerStation = New System.Windows.Forms.Button
    Me.BtnPrint = New System.Windows.Forms.Button
    Me.BtnExit = New System.Windows.Forms.Button
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.ComboBoxMulitStop = New System.Windows.Forms.ComboBox
    Me.ComboBoxMulitStart = New System.Windows.Forms.ComboBox
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPageSingle = New System.Windows.Forms.TabPage
    Me.TabPageMulit = New System.Windows.Forms.TabPage
    Me.PanelPrint = New System.Windows.Forms.Panel
    Me.MOP = New AxmyPrintOCX.AxmyOCXPrint
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.BtnRefresh = New System.Windows.Forms.Button
    Me.NumericUpDownLeft = New System.Windows.Forms.NumericUpDown
    Me.NumericUpDownTop = New System.Windows.Forms.NumericUpDown
    Me.BtnPrinting = New System.Windows.Forms.Button
    Me.ComboBoxSelectPage = New System.Windows.Forms.ComboBox
    Me.BtnPerPage = New System.Windows.Forms.Button
    Me.BtnNextPage = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.BtnExit2 = New System.Windows.Forms.Button
    Me.GroupBoxSelectPrinter = New System.Windows.Forms.GroupBox
    Me.ListBoxPrinter = New System.Windows.Forms.ListBox
    Me.TextBoxSelectedPrinter = New System.Windows.Forms.TextBox
    Me.BtnNextMap = New System.Windows.Forms.Button
    Me.BtnPerMap = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
    Me.Axset_printer1 = New AxSETPRINTERLib.Axset_printer
    Me.TabControl1.SuspendLayout()
    Me.TabPageSingle.SuspendLayout()
    Me.TabPageMulit.SuspendLayout()
    Me.PanelPrint.SuspendLayout()
    CType(Me.MOP, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    CType(Me.NumericUpDownLeft, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDownTop, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.GroupBoxSelectPrinter.SuspendLayout()
    CType(Me.Axset_printer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ComboBoxMap
    '
    Me.ComboBoxMap.Location = New System.Drawing.Point(20, 28)
    Me.ComboBoxMap.Name = "ComboBoxMap"
    Me.ComboBoxMap.Size = New System.Drawing.Size(131, 20)
    Me.ComboBoxMap.TabIndex = 2
    '
    'ComboBoxSingleStation
    '
    Me.ComboBoxSingleStation.Location = New System.Drawing.Point(12, 12)
    Me.ComboBoxSingleStation.Name = "ComboBoxSingleStation"
    Me.ComboBoxSingleStation.Size = New System.Drawing.Size(128, 20)
    Me.ComboBoxSingleStation.TabIndex = 4
    '
    'BtnSelctNextStation
    '
    Me.BtnSelctNextStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnSelctNextStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnSelctNextStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSelctNextStation.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnSelctNextStation.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnSelctNextStation.Image = CType(resources.GetObject("BtnSelctNextStation.Image"), System.Drawing.Image)
    Me.BtnSelctNextStation.Location = New System.Drawing.Point(104, 36)
    Me.BtnSelctNextStation.Name = "BtnSelctNextStation"
    Me.BtnSelctNextStation.Size = New System.Drawing.Size(33, 19)
    Me.BtnSelctNextStation.TabIndex = 10
    Me.BtnSelctNextStation.Tag = ""
    Me.BtnSelctNextStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnSelctPerStation
    '
    Me.BtnSelctPerStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnSelctPerStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnSelctPerStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSelctPerStation.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnSelctPerStation.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnSelctPerStation.Image = CType(resources.GetObject("BtnSelctPerStation.Image"), System.Drawing.Image)
    Me.BtnSelctPerStation.Location = New System.Drawing.Point(64, 36)
    Me.BtnSelctPerStation.Name = "BtnSelctPerStation"
    Me.BtnSelctPerStation.Size = New System.Drawing.Size(33, 19)
    Me.BtnSelctPerStation.TabIndex = 9
    Me.BtnSelctPerStation.Tag = ""
    Me.BtnSelctPerStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnPrint
    '
    Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
    Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnPrint.Location = New System.Drawing.Point(93, 263)
    Me.BtnPrint.Name = "BtnPrint"
    Me.BtnPrint.Size = New System.Drawing.Size(72, 29)
    Me.BtnPrint.TabIndex = 25
    Me.BtnPrint.Text = "预览"
    Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnExit
    '
    Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
    Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit.Location = New System.Drawing.Point(764, 6)
    Me.BtnExit.Name = "BtnExit"
    Me.BtnExit.Size = New System.Drawing.Size(72, 29)
    Me.BtnExit.TabIndex = 26
    Me.BtnExit.Text = "退出"
    Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(8, 40)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(60, 16)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "到："
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(8, 12)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(36, 16)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "从："
    '
    'ComboBoxMulitStop
    '
    Me.ComboBoxMulitStop.Location = New System.Drawing.Point(32, 36)
    Me.ComboBoxMulitStop.Name = "ComboBoxMulitStop"
    Me.ComboBoxMulitStop.Size = New System.Drawing.Size(110, 20)
    Me.ComboBoxMulitStop.TabIndex = 5
    '
    'ComboBoxMulitStart
    '
    Me.ComboBoxMulitStart.Location = New System.Drawing.Point(32, 12)
    Me.ComboBoxMulitStart.Name = "ComboBoxMulitStart"
    Me.ComboBoxMulitStart.Size = New System.Drawing.Size(110, 20)
    Me.ComboBoxMulitStart.TabIndex = 4
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPageSingle)
    Me.TabControl1.Controls.Add(Me.TabPageMulit)
    Me.TabControl1.Location = New System.Drawing.Point(5, 96)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(159, 89)
    Me.TabControl1.TabIndex = 31
    '
    'TabPageSingle
    '
    Me.TabPageSingle.Controls.Add(Me.ComboBoxSingleStation)
    Me.TabPageSingle.Controls.Add(Me.BtnSelctNextStation)
    Me.TabPageSingle.Controls.Add(Me.BtnSelctPerStation)
    Me.TabPageSingle.Location = New System.Drawing.Point(4, 21)
    Me.TabPageSingle.Name = "TabPageSingle"
    Me.TabPageSingle.Size = New System.Drawing.Size(151, 64)
    Me.TabPageSingle.TabIndex = 0
    Me.TabPageSingle.Text = "单站打印"
    '
    'TabPageMulit
    '
    Me.TabPageMulit.Controls.Add(Me.ComboBoxMulitStop)
    Me.TabPageMulit.Controls.Add(Me.ComboBoxMulitStart)
    Me.TabPageMulit.Controls.Add(Me.Label4)
    Me.TabPageMulit.Controls.Add(Me.Label3)
    Me.TabPageMulit.Location = New System.Drawing.Point(4, 21)
    Me.TabPageMulit.Name = "TabPageMulit"
    Me.TabPageMulit.Size = New System.Drawing.Size(151, 64)
    Me.TabPageMulit.TabIndex = 1
    Me.TabPageMulit.Text = "多站打印"
    '
    'PanelPrint
    '
    Me.PanelPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelPrint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.PanelPrint.Controls.Add(Me.MOP)
    Me.PanelPrint.Controls.Add(Me.Panel1)
    Me.PanelPrint.Location = New System.Drawing.Point(173, 0)
    Me.PanelPrint.Name = "PanelPrint"
    Me.PanelPrint.Size = New System.Drawing.Size(843, 702)
    Me.PanelPrint.TabIndex = 34
    '
    'MOP
    '
    Me.MOP.ContainingControl = Me
    Me.MOP.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.MOP.Enabled = True
    Me.MOP.Location = New System.Drawing.Point(0, 39)
    Me.MOP.Name = "MOP"
    Me.MOP.OcxState = CType(resources.GetObject("MOP.OcxState"), System.Windows.Forms.AxHost.State)
    Me.MOP.Size = New System.Drawing.Size(839, 659)
    Me.MOP.TabIndex = 37
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.BtnRefresh)
    Me.Panel1.Controls.Add(Me.NumericUpDownLeft)
    Me.Panel1.Controls.Add(Me.NumericUpDownTop)
    Me.Panel1.Controls.Add(Me.BtnPrinting)
    Me.Panel1.Controls.Add(Me.ComboBoxSelectPage)
    Me.Panel1.Controls.Add(Me.BtnPerPage)
    Me.Panel1.Controls.Add(Me.BtnNextPage)
    Me.Panel1.Controls.Add(Me.BtnExit)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label5)
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(843, 40)
    Me.Panel1.TabIndex = 36
    Me.Panel1.Visible = False
    '
    'BtnRefresh
    '
    Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
    Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnRefresh.Location = New System.Drawing.Point(285, 6)
    Me.BtnRefresh.Name = "BtnRefresh"
    Me.BtnRefresh.Size = New System.Drawing.Size(72, 29)
    Me.BtnRefresh.TabIndex = 46
    Me.BtnRefresh.Text = "刷新"
    Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'NumericUpDownLeft
    '
    Me.NumericUpDownLeft.Location = New System.Drawing.Point(175, 9)
    Me.NumericUpDownLeft.Name = "NumericUpDownLeft"
    Me.NumericUpDownLeft.Size = New System.Drawing.Size(62, 21)
    Me.NumericUpDownLeft.TabIndex = 44
    '
    'NumericUpDownTop
    '
    Me.NumericUpDownTop.Location = New System.Drawing.Point(54, 9)
    Me.NumericUpDownTop.Name = "NumericUpDownTop"
    Me.NumericUpDownTop.Size = New System.Drawing.Size(62, 21)
    Me.NumericUpDownTop.TabIndex = 43
    '
    'BtnPrinting
    '
    Me.BtnPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnPrinting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPrinting.Image = CType(resources.GetObject("BtnPrinting.Image"), System.Drawing.Image)
    Me.BtnPrinting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnPrinting.Location = New System.Drawing.Point(677, 6)
    Me.BtnPrinting.Name = "BtnPrinting"
    Me.BtnPrinting.Size = New System.Drawing.Size(72, 29)
    Me.BtnPrinting.TabIndex = 38
    Me.BtnPrinting.Text = "打印"
    Me.BtnPrinting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ComboBoxSelectPage
    '
    Me.ComboBoxSelectPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxSelectPage.Location = New System.Drawing.Point(574, 10)
    Me.ComboBoxSelectPage.Name = "ComboBoxSelectPage"
    Me.ComboBoxSelectPage.Size = New System.Drawing.Size(65, 20)
    Me.ComboBoxSelectPage.TabIndex = 37
    '
    'BtnPerPage
    '
    Me.BtnPerPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnPerPage.BackColor = System.Drawing.Color.Transparent
    Me.BtnPerPage.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnPerPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPerPage.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnPerPage.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnPerPage.Image = CType(resources.GetObject("BtnPerPage.Image"), System.Drawing.Image)
    Me.BtnPerPage.Location = New System.Drawing.Point(539, 10)
    Me.BtnPerPage.Name = "BtnPerPage"
    Me.BtnPerPage.Size = New System.Drawing.Size(33, 19)
    Me.BtnPerPage.TabIndex = 35
    Me.BtnPerPage.Tag = ""
    Me.BtnPerPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnNextPage
    '
    Me.BtnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnNextPage.BackColor = System.Drawing.Color.Transparent
    Me.BtnNextPage.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnNextPage.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnNextPage.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnNextPage.Image = CType(resources.GetObject("BtnNextPage.Image"), System.Drawing.Image)
    Me.BtnNextPage.Location = New System.Drawing.Point(640, 10)
    Me.BtnNextPage.Name = "BtnNextPage"
    Me.BtnNextPage.Size = New System.Drawing.Size(33, 19)
    Me.BtnNextPage.TabIndex = 36
    Me.BtnNextPage.Tag = ""
    Me.BtnNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(6, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(58, 14)
    Me.Label1.TabIndex = 41
    Me.Label1.Text = "上边距："
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(126, 12)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(58, 14)
    Me.Label2.TabIndex = 42
    Me.Label2.Text = "左边距："
    '
    'Label5
    '
    Me.Label5.Location = New System.Drawing.Point(235, 11)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(57, 15)
    Me.Label5.TabIndex = 45
    Me.Label5.Text = "（毫米）"
    '
    'Panel2
    '
    Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel2.Controls.Add(Me.Axset_printer1)
    Me.Panel2.Controls.Add(Me.BtnExit2)
    Me.Panel2.Controls.Add(Me.GroupBoxSelectPrinter)
    Me.Panel2.Controls.Add(Me.BtnNextMap)
    Me.Panel2.Controls.Add(Me.BtnPerMap)
    Me.Panel2.Controls.Add(Me.BtnPrint)
    Me.Panel2.Controls.Add(Me.ComboBoxMap)
    Me.Panel2.Controls.Add(Me.TabControl1)
    Me.Panel2.Controls.Add(Me.GroupBox1)
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(172, 699)
    Me.Panel2.TabIndex = 35
    '
    'BtnExit2
    '
    Me.BtnExit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit2.Image = CType(resources.GetObject("BtnExit2.Image"), System.Drawing.Image)
    Me.BtnExit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit2.Location = New System.Drawing.Point(93, 303)
    Me.BtnExit2.Name = "BtnExit2"
    Me.BtnExit2.Size = New System.Drawing.Size(72, 29)
    Me.BtnExit2.TabIndex = 37
    Me.BtnExit2.Text = "退出"
    Me.BtnExit2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'GroupBoxSelectPrinter
    '
    Me.GroupBoxSelectPrinter.Controls.Add(Me.ListBoxPrinter)
    Me.GroupBoxSelectPrinter.Controls.Add(Me.TextBoxSelectedPrinter)
    Me.GroupBoxSelectPrinter.Location = New System.Drawing.Point(8, 196)
    Me.GroupBoxSelectPrinter.Name = "GroupBoxSelectPrinter"
    Me.GroupBoxSelectPrinter.Size = New System.Drawing.Size(159, 60)
    Me.GroupBoxSelectPrinter.TabIndex = 35
    Me.GroupBoxSelectPrinter.TabStop = False
    Me.GroupBoxSelectPrinter.Text = "打印机"
    '
    'ListBoxPrinter
    '
    Me.ListBoxPrinter.ItemHeight = 12
    Me.ListBoxPrinter.Location = New System.Drawing.Point(11, 54)
    Me.ListBoxPrinter.Name = "ListBoxPrinter"
    Me.ListBoxPrinter.Size = New System.Drawing.Size(138, 184)
    Me.ListBoxPrinter.TabIndex = 1
    Me.ListBoxPrinter.Visible = False
    '
    'TextBoxSelectedPrinter
    '
    Me.TextBoxSelectedPrinter.Enabled = False
    Me.TextBoxSelectedPrinter.Location = New System.Drawing.Point(11, 24)
    Me.TextBoxSelectedPrinter.Name = "TextBoxSelectedPrinter"
    Me.TextBoxSelectedPrinter.Size = New System.Drawing.Size(138, 21)
    Me.TextBoxSelectedPrinter.TabIndex = 0
    Me.TextBoxSelectedPrinter.Text = ""
    '
    'BtnNextMap
    '
    Me.BtnNextMap.BackColor = System.Drawing.Color.Transparent
    Me.BtnNextMap.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnNextMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnNextMap.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnNextMap.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnNextMap.Image = CType(resources.GetObject("BtnNextMap.Image"), System.Drawing.Image)
    Me.BtnNextMap.Location = New System.Drawing.Point(115, 55)
    Me.BtnNextMap.Name = "BtnNextMap"
    Me.BtnNextMap.Size = New System.Drawing.Size(33, 19)
    Me.BtnNextMap.TabIndex = 33
    Me.BtnNextMap.Tag = ""
    Me.BtnNextMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'BtnPerMap
    '
    Me.BtnPerMap.BackColor = System.Drawing.Color.Transparent
    Me.BtnPerMap.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnPerMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPerMap.Font = New System.Drawing.Font("华文行楷", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnPerMap.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnPerMap.Image = CType(resources.GetObject("BtnPerMap.Image"), System.Drawing.Image)
    Me.BtnPerMap.Location = New System.Drawing.Point(75, 55)
    Me.BtnPerMap.Name = "BtnPerMap"
    Me.BtnPerMap.Size = New System.Drawing.Size(33, 19)
    Me.BtnPerMap.TabIndex = 32
    Me.BtnPerMap.Tag = ""
    Me.BtnPerMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'GroupBox1
    '
    Me.GroupBox1.Location = New System.Drawing.Point(5, 9)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(159, 77)
    Me.GroupBox1.TabIndex = 34
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "请选择地图"
    '
    'Axset_printer1
    '
    Me.Axset_printer1.ContainingControl = Me
    Me.Axset_printer1.Enabled = True
    Me.Axset_printer1.Location = New System.Drawing.Point(11, 396)
    Me.Axset_printer1.Name = "Axset_printer1"
    Me.Axset_printer1.OcxState = CType(resources.GetObject("Axset_printer1.OcxState"), System.Windows.Forms.AxHost.State)
    Me.Axset_printer1.Size = New System.Drawing.Size(146, 150)
    Me.Axset_printer1.TabIndex = 38
    '
    'Form4Print
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(1016, 702)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.PanelPrint)
    Me.Name = "Form4Print"
    Me.Text = "打印"
    Me.TabControl1.ResumeLayout(False)
    Me.TabPageSingle.ResumeLayout(False)
    Me.TabPageMulit.ResumeLayout(False)
    Me.PanelPrint.ResumeLayout(False)
    CType(Me.MOP, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    CType(Me.NumericUpDownLeft, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDownTop, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.GroupBoxSelectPrinter.ResumeLayout(False)
    CType(Me.Axset_printer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region
  Dim WithEvents Report As grproLib.GridppReport
  'Dim NameField As grproLib.IGRStringField
  'Dim ValueFields() As grproLib.IGRFloatField
  'Dim MOP As New AxmyPrintOCX.AxmyOCXPrint
  Dim PageNo As Integer '当前显示的页号
  Dim UsedPageNo As Integer '当前要打印的文档页数
  Dim MaxPageNo As Integer '当前已激活控件的数量
  Dim PY As Point '上边距和左边距
  'Public WorkWillPrint As New GPRSWorkPrint
  'Dim PP As Boolean '是否要打印了
  Dim MOPsPD As New PrintDialog

  Dim ODefaultPrinter As String '原来的默认打印机

  Dim form4Run As Boolean
  Dim SetlocationRun As Boolean

  Private Sub ListPrinter()
    Dim i As Integer
    Dim S As String
    With MOPsPD.PrinterSettings
      If .InstalledPrinters.Count > 0 Then
        For i = 1 To .InstalledPrinters.Count
          ListBoxPrinter.Items.Add(.InstalledPrinters.Item(i - 1).ToString)
          'S = .PrinterName
          '.PrinterName = .InstalledPrinters.Item(i - 1).ToString
          'If .IsDefaultPrinter Then
          '  j = i
          'End If
        Next
        S = Axset_printer1.DPGetDefaultPrinter()
        TextBoxSelectedPrinter.Text = S
        ODefaultPrinter = S
      End If
    End With

  End Sub
  Private Function MM(ByVal M As Single) As Integer
    MM = Int(M * (10 * m_m_m)) '毫米换算成控件的实际数据
  End Function
  Private Function CreatReportMOP(ByVal PPageNo As Integer, ByVal Printing As Boolean) As Boolean
    'PageNo是要打印的第几张
    Dim S As String
    Dim i As Integer
    Dim X, Y As Single
    Dim Xmm, Ymm As Integer
    Dim PSN, PMN As Integer
    Dim Font10High As Integer = 5 '10号字的高度，字下画线用
    Dim LineWidth As Integer = 1 '线宽
    Dim LineLong As Integer = 180 '线长
    Dim TowFW As Integer = 90 '两列时的列间距
    Dim FourFW As Integer = 45 '4列时的列间距
    Dim Font10RW As Integer = 6 '10号字时的行间距
    Dim ZWFontSize As Integer = 11 '正文时的字号

    If Printing Then
      MOP.set_bToPrinter(True)
    Else
      MOP.set_bToPrinter(False)
    End If

    If Printing = False Then
      MOP.EndPage() ''''''''''''''''''''''''''''''''''清空
    End If

    'Try
    '''''''''''''''''''''''''''''''''''把张数转换为站点号
    With WorkWillPrint
      If CW.MapAmount > 0 Then
        If .MapNo > 0 And .MapNo <= CW.MapAmount Then
          PMN = .MapNo
        Else
          PMN = 1
        End If
      Else
        Exit Function
      End If

      If CW.Maps(PMN).MapStationPlacedAmount > 0 Then
        Select Case .MulitStationPrint
          Case False
            If .StationNo > 0 And .StationNo <= CW.Maps(PMN).MapStationPlacedAmount Then
              PSN = .StationNo
            Else
              PSN = 1
            End If
          Case True
            If PPageNo > .StationNoStop - .StationNoStart + 1 Then
              PSN = .StationNoStop
            Else
              PSN = PPageNo + .StationNoStart - 1
            End If
        End Select
      Else
        Exit Function
      End If
    End With

    With MOP
      S = CW.WorkName

      .set_FontName("宋体")
      .set_FontSize(30)
      .set_FontBold(True)
      .PrintStringToRech(False, 1, 1, "") '改变字体后需要打一下空行，控件的问题

      Xmm = PY.X '''''''''''''''''''''''''''''主标题
      Ymm = PY.Y
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_FontSize(22)
      .set_FontBold(True)
      .PrintStringToRech(True, X, Y, S)

      Ymm += 10 '''''''''''''''''''''''''''''''''''''''''''副标题
      Xmm = 55 + PY.X
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_FontSize(36)
      .set_FontBold(True)
      .set_FontUnderline(True)
      S = "站点参数报表"
      .PrintStringToRech(False, X, Y, S)

      ''''''''''''''''''''''''''''''''''''''''''''''''''站点基本信息
      Xmm = PY.X
      Ymm += 20
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_FontSize(ZWFontSize)
      .set_FontBold(False)
      .set_FontUnderline(False)
      S = "打印人：" & CStr(ActivePerson.Name)
      .PrintStringToRech(False, X, Y, S)

      Xmm += 55
      X = MM(Xmm)
      S = "打印时间：" & CStr(Today) & " " & CStr(TimeOfDay)
      .PrintStringToRech(False, X, Y, S)



      Xmm += 65
      X = MM(Xmm)
      S = "检测时间：" & CStr(CW.Maps(PMN).Stations(PSN).TestDate) & "  " & CStr(CW.Maps(PMN).Stations(PSN).TestTime)
      .PrintStringToRech(False, X, Y, S)

      Xmm = PY.X '''''''''''''''''''''''''''''''''''''''''''''第一条线
      Ymm += Font10High
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_DrawLineWidth(LineWidth)
      .DrawLine(X, Y, MM(Xmm + LineLong), Y)

      'Dim TowFW As Integer = 90 '两列时的列间距
      'Dim FourFW As Integer = 45 '4列时的列间距
      'Dim Font10RW As Integer = 8 '10号字时的行间距

      Xmm = PY.X
      Ymm += 3
      X = MM(Xmm)
      Y = MM(Ymm)
      S = "站点名称：" & CW.Maps(PMN).Stations(PSN).StationIndex & "：" & CW.Maps(PMN).Stations(PSN).StationName
      .PrintStringToRech(False, X, Y, S)

      Xmm = PY.X
      Ymm += Font10RW
      X = MM(Xmm)
      Y = MM(Ymm)
      S = "站点地址：" & CW.Maps(PMN).Stations(PSN).StationAddress
      .PrintStringToRech(False, X, Y, S)

      Xmm = PY.X
      Ymm += Font10RW
      X = MM(Xmm)
      Y = MM(Ymm)
      S = "站点ID：" & CW.Maps(PMN).Stations(PSN).ModemInfo.ID
      .PrintStringToRech(False, X, Y, S)

      Xmm += TowFW
      'Ymm += Font10RW
      X = MM(Xmm)
      'Y = MM(Ymm)
      S = "站点IP：" & CW.Maps(PMN).Stations(PSN).ModemInfo.IP
      .PrintStringToRech(False, X, Y, S)

      Xmm = PY.X
      Ymm += Font10RW
      X = MM(Xmm)
      Y = MM(Ymm)
      S = "站点电话号码：" & CW.Maps(PMN).Stations(PSN).ModemInfo.PhoneNo
      .PrintStringToRech(False, X, Y, S)

      Xmm += TowFW
      'Ymm += Font10RW
      X = MM(Xmm)
      'Y = MM(Ymm)
      S = "站点所属地图：" & CW.Maps(PMN).MapName
      .PrintStringToRech(False, X, Y, S)

      Xmm = PY.X '''''''''''''''''''''''''''''''''''''''''''''第2条线
      Ymm += Font10High
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_DrawLineWidth(LineWidth)
      .DrawLine(X, Y, MM(Xmm + LineLong), Y)
      ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''参数列名
      .set_FontBold(True)
      Xmm = PY.X
      Ymm += 3
      X = MM(Xmm)
      Y = MM(Ymm)
      S = "参数名称"
      .PrintStringToRech(False, X, Y, S)

      Xmm += FourFW
      X = MM(Xmm)
      'Ymm += Font10RW
      'Y = MM(Ymm)
      S = "参数数值"
      .PrintStringToRech(False, X, Y, S)

      Xmm += FourFW
      X = MM(Xmm)
      'Ymm += Font10RW
      'Y = MM(Ymm)
      S = "报警线值"
      .PrintStringToRech(False, X, Y, S)

      Xmm += FourFW
      X = MM(Xmm)
      'Ymm += Font10RW
      'Y = MM(Ymm)
      S = "参数单位"
      .PrintStringToRech(False, X, Y, S)

      .set_FontBold(False)

      For i = 1 To CW.Maps(PMN).Stations(PSN).StationParameterAmount

        Xmm = PY.X
        Ymm += Font10RW
        X = MM(Xmm)
        Y = MM(Ymm)
        S = CW.Maps(PMN).Stations(PSN).StationParameters(i, 0)
        .PrintStringToRech(False, X, Y, S)

        Xmm += FourFW
        X = MM(Xmm)
        'Ymm += Font10RW
        'Y = MM(Ymm)
        S = CW.Maps(PMN).Stations(PSN).StationParameters(i, 1)
        .PrintStringToRech(False, X, Y, S)

        Xmm += FourFW
        X = MM(Xmm)
        'Ymm += Font10RW
        'Y = MM(Ymm)
        S = CW.Maps(PMN).Stations(PSN).StationParameters(i, 3)
        .PrintStringToRech(False, X, Y, S)

        Xmm += FourFW
        X = MM(Xmm)
        'Ymm += Font10RW
        'Y = MM(Ymm)
        S = CW.Maps(PMN).Stations(PSN).StationParameters(i, 2)
        .PrintStringToRech(False, X, Y, S)

      Next i

      Xmm = PY.X '''''''''''''''''''''''''''''''''''''''''''''第3条线
      Ymm += Font10High
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_DrawLineWidth(LineWidth)
      .DrawLine(X, Y, MM(Xmm + LineLong), Y)
      Xmm = PY.X '''''''''''''''''''''''''''''''''''''''''''''第4条线
      Ymm += 1
      X = MM(Xmm)
      Y = MM(Ymm)
      .set_DrawLineWidth(LineWidth)
      .DrawLine(X, Y, MM(Xmm + LineLong), Y)

      If Printing = True Then
        MOP.EndPage() ''''''''''''''''''''''''''''''''''打印
      End If
    End With

    'PP = False
    'Finally
    'End Try
  End Function
  Private Sub RefreshMOP()
    ''MOP = New AxmyPrintOCX.AxmyOCXPrint
    'PanelPrint.Controls.Add(MOP)
    'With MOP
    '  .BringToFront()
    '  .Height = PanelPrint.Height - 40
    '  .Width = PanelPrint.Width
    '  .Location = New Point(0, 40)
    '  .Dock = DockStyle.Bottom
    'End With
  End Sub
  Private Function SetLocation() As Boolean
    'RefreshMOP()
    SetlocationRun = True
    Dim i, j As Integer
    SetLocation = False
    ComboBoxMap.Items.Clear()
    If CW.MapAmount > 0 Then
      For i = 1 To CW.MapAmount
        ComboBoxMap.Items.Add(CW.Maps(i).MapName)
      Next i
      If WorkWillPrint.MapNo <= CW.MapAmount Then
        ComboBoxMap.SelectedIndex = WorkWillPrint.MapNo - 1
      Else
        WorkWillPrint.MapNo = 1
        ComboBoxMap.SelectedIndex = 0
      End If
    End If
    i = WorkWillPrint.StationNoStop

    Select Case WorkWillPrint.MulitStationPrint

      Case False

        ComboBoxSingleStation.Items.Clear()
        ComboBoxSingleStation.Text = ""
        If CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount > 0 Then
          For i = 1 To CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount
            ComboBoxSingleStation.Items.Add(CStr(i) & "：" & CW.Maps(WorkWillPrint.MapNo).Stations(i).StationName)
          Next i


          If WorkWillPrint.StationNo <= CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount Then
            ComboBoxSingleStation.SelectedIndex = WorkWillPrint.StationNo - 1
          Else
            ComboBoxSingleStation.SelectedIndex = CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount - 1
            WorkWillPrint.StationNo = CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount
          End If
          BtnSelctPerStation.Enabled = True
          BtnSelctNextStation.Enabled = True
          SetLocation = True
        Else
          BtnSelctPerStation.Enabled = False
          BtnSelctNextStation.Enabled = False
        End If


      Case True '如果是多站打印

        ComboBoxMulitStart.Items.Clear()
        ComboBoxMulitStart.Text = ""
        ComboBoxMulitStop.Items.Clear()
        ComboBoxMulitStop.Text = ""

        If CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount > 0 Then

          For i = 1 To CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount
            ComboBoxMulitStart.Items.Add(CStr(i) & "：" & CW.Maps(WorkWillPrint.MapNo).Stations(i).StationName)
            ComboBoxMulitStop.Items.Add(CStr(i) & "：" & CW.Maps(WorkWillPrint.MapNo).Stations(i).StationName)
          Next i

          j = WorkWillPrint.StationNoStart
          If j > 0 And j <= CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount Then
            ComboBoxMulitStart.SelectedIndex = j - 1
          Else
            ComboBoxMulitStart.SelectedIndex = 0
            WorkWillPrint.StationNoStart = 1
          End If

          j = WorkWillPrint.StationNoStop
          If j > 0 And j <= CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount Then
            ComboBoxMulitStop.SelectedIndex = j - 1
          Else
            ComboBoxMulitStop.SelectedIndex = ComboBoxMulitStop.Items.Count - 1
            WorkWillPrint.StationNoStop = ComboBoxMulitStop.Items.Count
          End If

          If WorkWillPrint.StationNoStart = WorkWillPrint.StationNoStop Then
            WorkWillPrint.MulitStationPrint = False
            WorkWillPrint.StationNo = WorkWillPrint.StationNoStart
          ElseIf WorkWillPrint.StationNoStart > WorkWillPrint.StationNoStop Then
            j = WorkWillPrint.StationNoStart
            WorkWillPrint.MulitStationPrint = True
            WorkWillPrint.StationNoStart = WorkWillPrint.StationNoStop
            WorkWillPrint.StationNoStop = j
          ElseIf WorkWillPrint.StationNoStart < WorkWillPrint.StationNoStop Then
            '就不用改变了
          End If
          SetLocation = True
        End If
    End Select


    NumericUpDownTop.Value = 20
    NumericUpDownLeft.Value = 15
    PY.X = NumericUpDownLeft.Value
    PY.Y = NumericUpDownTop.Value

    SetlocationRun = False
  End Function

  Private Sub Form4Print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    form4Run = False

    '(((((((((((((((((((((((((((((((((((((((
    'SetGPRSWork(Me)
    'CW.Maps(1).AddStation()
    ')))))))))))))))))))))))))))))))))))))))
    ListPrinter()
    Me.Location = New Point(0, 0)
    SetLocation()
    'MaxPageNo = 1000
    'PageNo = 1
    'Report = New grproLib.GridppReport

    form4Run = True
  End Sub
  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    Dim PMN, PSN As Integer
    Dim i As Integer

    With WorkWillPrint

      If CW.MapAmount > 0 Then
        If .MapNo > 0 And .MapNo <= CW.MapAmount Then
          PMN = .MapNo
        Else
          PMN = 1
        End If
      Else
        Exit Sub
      End If

      If CW.Maps(PMN).MapStationPlacedAmount > 0 Then
        Select Case .MulitStationPrint
          Case False
            If .StationNo > 0 And .StationNo <= CW.Maps(PMN).MapStationPlacedAmount Then
              PSN = .StationNo
            Else
              PSN = 1
            End If
          Case True
            If PageNo > .StationNoStop - .StationNoStart + 1 Then
              PSN = .StationNoStop
            Else
              PSN = PageNo + .StationNoStart - 1
            End If
        End Select
      Else
        Exit Sub
      End If

      ComboBoxSelectPage.Items.Clear()

      Select Case .MulitStationPrint
        Case False
          ComboBoxSelectPage.Items.Add("1/1页")

        Case True
          For i = 1 To .StationNoStop - .StationNoStart + 1
            ComboBoxSelectPage.Items.Add(CStr(i) & "/" & CStr(.StationNoStop - .StationNoStart + 1) & "页")
          Next i
      End Select
      ComboBoxSelectPage.SelectedIndex = 0
      System.Windows.Forms.Application.DoEvents() '''''''''''''''''''''''''''''''''DoEvents

    End With

    CreatReportMOP(ComboBoxSelectPage.SelectedIndex + 1, False)
    Panel1.Visible = True
  End Sub
  Private Sub BtnSelctPerStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelctPerStation.Click
    If ComboBoxSingleStation.SelectedIndex > 0 Then
      ComboBoxSingleStation.SelectedIndex = ComboBoxSingleStation.SelectedIndex - 1
      WorkWillPrint.MulitStationPrint = False
      WorkWillPrint.StationNo = ComboBoxSingleStation.SelectedIndex + 1
    End If
  End Sub

  Private Sub BtnSelctNextStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelctNextStation.Click
    If ComboBoxSingleStation.SelectedIndex < ComboBoxSingleStation.Items.Count - 1 Then
      ComboBoxSingleStation.SelectedIndex = ComboBoxSingleStation.SelectedIndex + 1
      WorkWillPrint.MulitStationPrint = False
      WorkWillPrint.StationNo = ComboBoxSingleStation.SelectedIndex + 1
    End If
  End Sub
  Private Sub ComboBoxSingleStation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSingleStation.SelectedIndexChanged
    WorkWillPrint.MulitStationPrint = False
    WorkWillPrint.StationNo = ComboBoxSingleStation.SelectedIndex + 1
  End Sub

  Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    Me.Close()
  End Sub

  Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    Select Case TabControl1.SelectedIndex
      Case 0
        WorkWillPrint.MulitStationPrint = False
        If ComboBoxSingleStation.SelectedIndex >= 0 Then
          WorkWillPrint.StationNo = ComboBoxSingleStation.SelectedIndex + 1
          SetLocation()
        End If

      Case 1
        WorkWillPrint.MulitStationPrint = True
        SetLocation()
    End Select
  End Sub

  Private Sub ComboBoxMap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMap.SelectedIndexChanged
    If SetlocationRun Then Exit Sub
    WorkWillPrint.MapNo = ComboBoxMap.SelectedIndex + 1
    If CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount > 0 Then
      WorkWillPrint.StationNo = 1
      WorkWillPrint.StationNoStart = 1
      WorkWillPrint.StationNoStop = CW.Maps(WorkWillPrint.MapNo).MapStationPlacedAmount

      TabControl1.SelectedIndex = 0
      SetLocation()
    Else
      WorkWillPrint.StationNo = 0
      WorkWillPrint.StationNoStart = 0
      ComboBoxSingleStation.Items.Clear()
      ComboBoxSingleStation.Text = ""
      ComboBoxMulitStart.Items.Clear()
      ComboBoxMulitStart.Text = ""
      ComboBoxMulitStop.Items.Clear()
      ComboBoxMulitStop.Text = ""
    End If

  End Sub

  Private Sub ComboBoxMulitStart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMulitStart.SelectedIndexChanged
    If SetlocationRun = True Then Exit Sub
    WorkWillPrint.StationNoStart = ComboBoxMulitStart.SelectedIndex + 1
    SetLocation()
  End Sub

  Private Sub ComboBoxMulitStop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMulitStop.SelectedIndexChanged
    If SetlocationRun = True Then Exit Sub
    WorkWillPrint.StationNoStop = ComboBoxMulitStop.SelectedIndex + 1
    SetLocation()
  End Sub

  Private Sub BtnPerMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPerMap.Click
    With ComboBoxMap
      If .Items.Count > 0 Then
        If .SelectedIndex > 0 Then
          .SelectedIndex -= 1
        End If
      End If
    End With
  End Sub

  Private Sub BtnNextMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextMap.Click
    With ComboBoxMap
      If .Items.Count > 0 Then
        If .SelectedIndex < .Items.Count - 1 Then
          .SelectedIndex += 1
        End If
      End If
    End With
  End Sub

  Private Sub BtnPerPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPerPage.Click
    If ComboBoxSelectPage.Items.Count > 0 Then
      If ComboBoxSelectPage.SelectedIndex > 0 Then
        ComboBoxSelectPage.SelectedIndex -= 1
      End If
    End If
  End Sub

  Private Sub BtnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextPage.Click
    If ComboBoxSelectPage.Items.Count > 0 Then
      If ComboBoxSelectPage.SelectedIndex < ComboBoxSelectPage.Items.Count - 1 Then
        ComboBoxSelectPage.SelectedIndex += 1
      End If
    End If
  End Sub

  Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
    PY.X = NumericUpDownLeft.Value
    PY.Y = NumericUpDownTop.Value
    CreatReportMOP(ComboBoxSelectPage.SelectedIndex + 1, False)
  End Sub

  Private Sub ComboBoxSelectPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectPage.SelectedIndexChanged
    CreatReportMOP(ComboBoxSelectPage.SelectedIndex + 1, False)
  End Sub

  Private Sub BtnPrinting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrinting.Click
    'Dim SPrint() As String
    'SPrint = PrintDialog1.PrinterSettings.InstalledPrinters.
    'PrintDialog1.ShowDialog()
    If ComboBoxSelectPage.SelectedIndex > -1 Then
      CreatReportMOP(ComboBoxSelectPage.SelectedIndex + 1, True)
      'CreatReportMOP(ComboBoxSelectPage.SelectedIndex + 1, False)
    End If
    'PP = True
  End Sub

  Private Sub ListBoxPrinter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPrinter.SelectedIndexChanged
    'TextBoxSelectedPrinter.Text = ListBoxPrinter.SelectedItem
    'System.Windows.Forms.Application.DoEvents()
    'Axset_printer1.DPSetDefaultPrinter(TextBoxSelectedPrinter.Text)
    'RefreshMOP()
    'MOP.SetPrinter(MOP)
  End Sub

  Private Sub Form4Print_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    'Axset_printer1.DPSetDefaultPrinter(ODefaultPrinter)
  End Sub
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 

  
  '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

  Private Sub BtnExit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit2.Click
    BtnExit_Click(sender, e)
  End Sub

End Class
