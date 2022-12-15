<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10FlexTChart
  Inherits System.Windows.Forms.Form

  'Form 重写 Dispose，以清理组件列表。
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
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10FlexTChart))
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
    Me.TreeSelectStation = New System.Windows.Forms.TreeView
    Me.TreeSelectDate = New System.Windows.Forms.TreeView
    Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
    Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.ChkLst_SelectPars = New System.Windows.Forms.CheckedListBox
    Me.Btn_ChkLst_None = New System.Windows.Forms.Button
    Me.Btn_ChkLst_All = New System.Windows.Forms.Button
    Me.PanelTChartSetting = New System.Windows.Forms.Panel
    Me.CheckBoxTChart3D = New System.Windows.Forms.CheckBox
    Me.CheckBoxTChartY = New System.Windows.Forms.CheckBox
    Me.CheckBoxTChartLine = New System.Windows.Forms.CheckBox
    Me.TChartMain = New AxTeeChart.AxTChart
    Me.PanelToolBar = New System.Windows.Forms.Panel
    Me.LabelTmp = New System.Windows.Forms.Label
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.lblStationMsg = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.LblDateMsg = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.ImageListFlexMain = New System.Windows.Forms.ImageList(Me.components)
    Me.BtnPrint = New System.Windows.Forms.Button
    Me.BtnExit = New System.Windows.Forms.Button
    Me.BtnReCDMain = New System.Windows.Forms.Button
    Me.FlexMain = New AxMSFlexGridLib.AxMSFlexGrid
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.SplitContainer2.Panel1.SuspendLayout()
    Me.SplitContainer2.Panel2.SuspendLayout()
    Me.SplitContainer2.SuspendLayout()
    Me.SplitContainer3.Panel1.SuspendLayout()
    Me.SplitContainer3.Panel2.SuspendLayout()
    Me.SplitContainer3.SuspendLayout()
    Me.SplitContainer4.Panel1.SuspendLayout()
    Me.SplitContainer4.Panel2.SuspendLayout()
    Me.SplitContainer4.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.PanelTChartSetting.SuspendLayout()
    CType(Me.TChartMain, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelToolBar.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.FlexMain, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
    Me.SplitContainer1.Size = New System.Drawing.Size(1016, 622)
    Me.SplitContainer1.SplitterDistance = 282
    Me.SplitContainer1.TabIndex = 0
    '
    'SplitContainer2
    '
    Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer2.Name = "SplitContainer2"
    '
    'SplitContainer2.Panel1
    '
    Me.SplitContainer2.Panel1.Controls.Add(Me.TreeSelectStation)
    '
    'SplitContainer2.Panel2
    '
    Me.SplitContainer2.Panel2.Controls.Add(Me.TreeSelectDate)
    Me.SplitContainer2.Size = New System.Drawing.Size(278, 618)
    Me.SplitContainer2.SplitterDistance = 112
    Me.SplitContainer2.TabIndex = 0
    '
    'TreeSelectStation
    '
    Me.TreeSelectStation.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TreeSelectStation.Location = New System.Drawing.Point(0, 0)
    Me.TreeSelectStation.Name = "TreeSelectStation"
    Me.TreeSelectStation.Size = New System.Drawing.Size(112, 618)
    Me.TreeSelectStation.TabIndex = 0
    '
    'TreeSelectDate
    '
    Me.TreeSelectDate.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TreeSelectDate.Location = New System.Drawing.Point(0, 0)
    Me.TreeSelectDate.Name = "TreeSelectDate"
    Me.TreeSelectDate.Size = New System.Drawing.Size(162, 618)
    Me.TreeSelectDate.TabIndex = 0
    '
    'SplitContainer3
    '
    Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer3.Name = "SplitContainer3"
    Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer3.Panel1
    '
    Me.SplitContainer3.Panel1.Controls.Add(Me.FlexMain)
    '
    'SplitContainer3.Panel2
    '
    Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
    Me.SplitContainer3.Size = New System.Drawing.Size(726, 618)
    Me.SplitContainer3.SplitterDistance = 327
    Me.SplitContainer3.TabIndex = 0
    '
    'SplitContainer4
    '
    Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer4.Name = "SplitContainer4"
    '
    'SplitContainer4.Panel1
    '
    Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox1)
    '
    'SplitContainer4.Panel2
    '
    Me.SplitContainer4.Panel2.Controls.Add(Me.PanelTChartSetting)
    Me.SplitContainer4.Panel2.Controls.Add(Me.TChartMain)
    Me.SplitContainer4.Size = New System.Drawing.Size(726, 287)
    Me.SplitContainer4.SplitterDistance = 122
    Me.SplitContainer4.TabIndex = 0
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.ChkLst_SelectPars)
    Me.GroupBox1.Controls.Add(Me.Btn_ChkLst_None)
    Me.GroupBox1.Controls.Add(Me.Btn_ChkLst_All)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(122, 287)
    Me.GroupBox1.TabIndex = 9
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "显示参数选择："
    '
    'ChkLst_SelectPars
    '
    Me.ChkLst_SelectPars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ChkLst_SelectPars.CheckOnClick = True
    Me.ChkLst_SelectPars.FormattingEnabled = True
    Me.ChkLst_SelectPars.Location = New System.Drawing.Point(0, 40)
    Me.ChkLst_SelectPars.Name = "ChkLst_SelectPars"
    Me.ChkLst_SelectPars.ScrollAlwaysVisible = True
    Me.ChkLst_SelectPars.Size = New System.Drawing.Size(123, 244)
    Me.ChkLst_SelectPars.TabIndex = 8
    '
    'Btn_ChkLst_None
    '
    Me.Btn_ChkLst_None.Location = New System.Drawing.Point(62, 16)
    Me.Btn_ChkLst_None.Name = "Btn_ChkLst_None"
    Me.Btn_ChkLst_None.Size = New System.Drawing.Size(52, 22)
    Me.Btn_ChkLst_None.TabIndex = 10
    Me.Btn_ChkLst_None.Text = "全不选"
    Me.Btn_ChkLst_None.UseVisualStyleBackColor = True
    '
    'Btn_ChkLst_All
    '
    Me.Btn_ChkLst_All.Location = New System.Drawing.Point(6, 16)
    Me.Btn_ChkLst_All.Name = "Btn_ChkLst_All"
    Me.Btn_ChkLst_All.Size = New System.Drawing.Size(52, 22)
    Me.Btn_ChkLst_All.TabIndex = 9
    Me.Btn_ChkLst_All.Text = "全选"
    Me.Btn_ChkLst_All.UseVisualStyleBackColor = True
    '
    'PanelTChartSetting
    '
    Me.PanelTChartSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelTChartSetting.BackColor = System.Drawing.SystemColors.Control
    Me.PanelTChartSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PanelTChartSetting.Controls.Add(Me.CheckBoxTChart3D)
    Me.PanelTChartSetting.Controls.Add(Me.CheckBoxTChartY)
    Me.PanelTChartSetting.Controls.Add(Me.CheckBoxTChartLine)
    Me.PanelTChartSetting.Location = New System.Drawing.Point(423, 3)
    Me.PanelTChartSetting.Name = "PanelTChartSetting"
    Me.PanelTChartSetting.Size = New System.Drawing.Size(174, 24)
    Me.PanelTChartSetting.TabIndex = 7
    '
    'CheckBoxTChart3D
    '
    Me.CheckBoxTChart3D.BackColor = System.Drawing.SystemColors.Control
    Me.CheckBoxTChart3D.ForeColor = System.Drawing.SystemColors.WindowText
    Me.CheckBoxTChart3D.Location = New System.Drawing.Point(12, 4)
    Me.CheckBoxTChart3D.Name = "CheckBoxTChart3D"
    Me.CheckBoxTChart3D.Size = New System.Drawing.Size(44, 16)
    Me.CheckBoxTChart3D.TabIndex = 2
    Me.CheckBoxTChart3D.Text = "3D"
    Me.CheckBoxTChart3D.UseVisualStyleBackColor = False
    '
    'CheckBoxTChartY
    '
    Me.CheckBoxTChartY.BackColor = System.Drawing.SystemColors.Control
    Me.CheckBoxTChartY.ForeColor = System.Drawing.SystemColors.WindowText
    Me.CheckBoxTChartY.Location = New System.Drawing.Point(60, 4)
    Me.CheckBoxTChartY.Name = "CheckBoxTChartY"
    Me.CheckBoxTChartY.Size = New System.Drawing.Size(32, 16)
    Me.CheckBoxTChartY.TabIndex = 4
    Me.CheckBoxTChartY.Text = "Y"
    Me.CheckBoxTChartY.UseVisualStyleBackColor = False
    '
    'CheckBoxTChartLine
    '
    Me.CheckBoxTChartLine.BackColor = System.Drawing.SystemColors.Control
    Me.CheckBoxTChartLine.ForeColor = System.Drawing.SystemColors.WindowText
    Me.CheckBoxTChartLine.Location = New System.Drawing.Point(100, 4)
    Me.CheckBoxTChartLine.Name = "CheckBoxTChartLine"
    Me.CheckBoxTChartLine.Size = New System.Drawing.Size(52, 16)
    Me.CheckBoxTChartLine.TabIndex = 5
    Me.CheckBoxTChartLine.Text = "Line"
    Me.CheckBoxTChartLine.UseVisualStyleBackColor = False
    '
    'TChartMain
    '
    Me.TChartMain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TChartMain.Enabled = True
    Me.TChartMain.Location = New System.Drawing.Point(0, 0)
    Me.TChartMain.Name = "TChartMain"
    Me.TChartMain.OcxState = CType(resources.GetObject("TChartMain.OcxState"), System.Windows.Forms.AxHost.State)
    Me.TChartMain.Size = New System.Drawing.Size(600, 287)
    Me.TChartMain.TabIndex = 0
    '
    'PanelToolBar
    '
    Me.PanelToolBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.PanelToolBar.Controls.Add(Me.BtnPrint)
    Me.PanelToolBar.Controls.Add(Me.LabelTmp)
    Me.PanelToolBar.Controls.Add(Me.GroupBox3)
    Me.PanelToolBar.Controls.Add(Me.BtnExit)
    Me.PanelToolBar.Controls.Add(Me.BtnReCDMain)
    Me.PanelToolBar.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelToolBar.Location = New System.Drawing.Point(0, 0)
    Me.PanelToolBar.Name = "PanelToolBar"
    Me.PanelToolBar.Size = New System.Drawing.Size(1016, 60)
    Me.PanelToolBar.TabIndex = 30
    '
    'LabelTmp
    '
    Me.LabelTmp.BackColor = System.Drawing.Color.Transparent
    Me.LabelTmp.Location = New System.Drawing.Point(897, 13)
    Me.LabelTmp.Name = "LabelTmp"
    Me.LabelTmp.Size = New System.Drawing.Size(30, 37)
    Me.LabelTmp.TabIndex = 34
    '
    'GroupBox3
    '
    Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.GroupBox3.Controls.Add(Me.Panel1)
    Me.GroupBox3.Location = New System.Drawing.Point(202, 3)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(690, 51)
    Me.GroupBox3.TabIndex = 33
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "显示范围："
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.lblStationMsg)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.LblDateMsg)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(3, 17)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(684, 31)
    Me.Panel1.TabIndex = 34
    '
    'lblStationMsg
    '
    Me.lblStationMsg.BackColor = System.Drawing.Color.DarkSlateGray
    Me.lblStationMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblStationMsg.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.lblStationMsg.ForeColor = System.Drawing.Color.Cyan
    Me.lblStationMsg.Location = New System.Drawing.Point(346, 0)
    Me.lblStationMsg.Name = "lblStationMsg"
    Me.lblStationMsg.Size = New System.Drawing.Size(335, 24)
    Me.lblStationMsg.TabIndex = 34
    Me.lblStationMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Gold
    Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label2.Location = New System.Drawing.Point(246, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(96, 16)
    Me.Label2.TabIndex = 35
    Me.Label2.Text = "当前所选站点："
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Gold
    Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label1.Location = New System.Drawing.Point(14, 4)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(96, 16)
    Me.Label1.TabIndex = 33
    Me.Label1.Text = "当前数据时间："
    '
    'LblDateMsg
    '
    Me.LblDateMsg.BackColor = System.Drawing.Color.DarkSlateGray
    Me.LblDateMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.LblDateMsg.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.LblDateMsg.ForeColor = System.Drawing.Color.Cyan
    Me.LblDateMsg.Location = New System.Drawing.Point(114, 0)
    Me.LblDateMsg.Name = "LblDateMsg"
    Me.LblDateMsg.Size = New System.Drawing.Size(126, 24)
    Me.LblDateMsg.TabIndex = 32
    Me.LblDateMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.DimGray
    Me.Label3.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.Aqua
    Me.Label3.Location = New System.Drawing.Point(242, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(116, 24)
    Me.Label3.TabIndex = 36
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.DimGray
    Me.Label4.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.Aqua
    Me.Label4.Location = New System.Drawing.Point(10, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(116, 24)
    Me.Label4.TabIndex = 37
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ImageListFlexMain
    '
    Me.ImageListFlexMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
    Me.ImageListFlexMain.ImageSize = New System.Drawing.Size(16, 16)
    Me.ImageListFlexMain.TransparentColor = System.Drawing.Color.Transparent
    '
    'BtnPrint
    '
    Me.BtnPrint.BackColor = System.Drawing.Color.Transparent
    Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPrint.Image = Global.GPRS.My.Resources.Resources._32printer
    Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnPrint.Location = New System.Drawing.Point(116, 0)
    Me.BtnPrint.Name = "BtnPrint"
    Me.BtnPrint.Size = New System.Drawing.Size(70, 36)
    Me.BtnPrint.TabIndex = 35
    Me.BtnPrint.Text = "打印"
    Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnPrint.UseVisualStyleBackColor = False
    '
    'BtnExit
    '
    Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnExit.BackColor = System.Drawing.Color.Transparent
    Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnExit.Image = Global.GPRS.My.Resources.Resources._32Exit
    Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnExit.Location = New System.Drawing.Point(935, 10)
    Me.BtnExit.Name = "BtnExit"
    Me.BtnExit.Size = New System.Drawing.Size(74, 36)
    Me.BtnExit.TabIndex = 30
    Me.BtnExit.Text = "退出"
    Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnExit.UseVisualStyleBackColor = False
    '
    'BtnReCDMain
    '
    Me.BtnReCDMain.BackColor = System.Drawing.Color.Transparent
    Me.BtnReCDMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnReCDMain.Image = Global.GPRS.My.Resources.Resources._32ReCDMain
    Me.BtnReCDMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnReCDMain.Location = New System.Drawing.Point(0, 0)
    Me.BtnReCDMain.Name = "BtnReCDMain"
    Me.BtnReCDMain.Size = New System.Drawing.Size(112, 36)
    Me.BtnReCDMain.TabIndex = 29
    Me.BtnReCDMain.Text = "刷新数据库"
    Me.BtnReCDMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnReCDMain.UseVisualStyleBackColor = False
    '
    'FlexMain
    '
    Me.FlexMain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlexMain.Location = New System.Drawing.Point(0, 0)
    Me.FlexMain.Name = "FlexMain"
    Me.FlexMain.OcxState = CType(resources.GetObject("FlexMain.OcxState"), System.Windows.Forms.AxHost.State)
    Me.FlexMain.Size = New System.Drawing.Size(726, 327)
    Me.FlexMain.TabIndex = 0
    '
    'Form10FlexTChart
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1016, 686)
    Me.Controls.Add(Me.PanelToolBar)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Name = "Form10FlexTChart"
    Me.Text = "数据察看"
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    Me.SplitContainer2.Panel1.ResumeLayout(False)
    Me.SplitContainer2.Panel2.ResumeLayout(False)
    Me.SplitContainer2.ResumeLayout(False)
    Me.SplitContainer3.Panel1.ResumeLayout(False)
    Me.SplitContainer3.Panel2.ResumeLayout(False)
    Me.SplitContainer3.ResumeLayout(False)
    Me.SplitContainer4.Panel1.ResumeLayout(False)
    Me.SplitContainer4.Panel2.ResumeLayout(False)
    Me.SplitContainer4.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.PanelTChartSetting.ResumeLayout(False)
    CType(Me.TChartMain, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelToolBar.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    CType(Me.FlexMain, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
  Friend WithEvents TreeSelectStation As System.Windows.Forms.TreeView
  Friend WithEvents TreeSelectDate As System.Windows.Forms.TreeView
  Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
  Friend WithEvents FlexMain As AxMSFlexGridLib.AxMSFlexGrid
  Friend WithEvents TChartMain As AxTeeChart.AxTChart
  Friend WithEvents BtnReCDMain As System.Windows.Forms.Button
  Friend WithEvents PanelToolBar As System.Windows.Forms.Panel
  Friend WithEvents BtnExit As System.Windows.Forms.Button
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblStationMsg As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents LblDateMsg As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents PanelTChartSetting As System.Windows.Forms.Panel
  Friend WithEvents CheckBoxTChart3D As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBoxTChartY As System.Windows.Forms.CheckBox
  Friend WithEvents CheckBoxTChartLine As System.Windows.Forms.CheckBox
  Friend WithEvents ImageListFlexMain As System.Windows.Forms.ImageList
  Friend WithEvents ChkLst_SelectPars As System.Windows.Forms.CheckedListBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Btn_ChkLst_All As System.Windows.Forms.Button
  Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
  Friend WithEvents Btn_ChkLst_None As System.Windows.Forms.Button
  Friend WithEvents LabelTmp As System.Windows.Forms.Label
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
End Class
