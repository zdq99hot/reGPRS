Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Imports System.Threading
Imports GPRS.com.hzy.common
'Imports System.Threading
Imports System.ComponentModel
Imports System.Math
Public Class Form1
  Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

  Public Sub New()
    MyBase.New()

    '�õ����� Windows ���������������ġ�
    InitializeComponent()

    '�� InitializeComponent() ����֮������κγ�ʼ��

  End Sub

  '������д��������������б�
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

  'ע�⣺���¹����� Windows ����������������
  '����ʹ�� Windows ����������޸Ĵ˹��̡�
  '��Ҫʹ�ô���༭���޸�����
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents PicBoxMap As System.Windows.Forms.PictureBox
  Friend WithEvents BtnPlaceStation As System.Windows.Forms.Button
  Friend WithEvents BtnFDHY As System.Windows.Forms.Button
  Friend WithEvents BtnFDSX As System.Windows.Forms.Button
  Friend WithEvents BtnFDFD As System.Windows.Forms.Button
  Friend WithEvents PanelEaglEye As System.Windows.Forms.Panel
  Friend WithEvents PicBoxEaglEye As System.Windows.Forms.PictureBox
  Friend WithEvents PanelToolBar As System.Windows.Forms.Panel
  Friend WithEvents PanelPicBoxMap As System.Windows.Forms.Panel
  Friend WithEvents PanelPicBoxMapMove As System.Windows.Forms.Panel
  Friend WithEvents AniGifMainForm As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents AniGIFStation As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents BtnLogout As System.Windows.Forms.Button
  Friend WithEvents PanelPassword As System.Windows.Forms.Panel
  Friend WithEvents CheckBoxPassword As System.Windows.Forms.CheckBox
  Friend WithEvents ComboBoxPersonName As System.Windows.Forms.ComboBox
  Friend WithEvents BtnOut As System.Windows.Forms.Button
  Friend WithEvents BtnIn As System.Windows.Forms.Button
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
  Friend WithEvents TabShowMap As System.Windows.Forms.TabPage
  Friend WithEvents TabShowStation As System.Windows.Forms.TabPage
  Friend WithEvents TabShowComm As System.Windows.Forms.TabPage
  Friend WithEvents PanelStation As System.Windows.Forms.Panel
  Friend WithEvents PicboxStation As System.Windows.Forms.PictureBox
  Friend WithEvents PanelComm As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents ComboBoxSelectMap1 As System.Windows.Forms.ComboBox
  Friend WithEvents ImageListTab As System.Windows.Forms.ImageList
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBoxAboutStation As System.Windows.Forms.GroupBox
  Friend WithEvents BtnStationQuXiao As System.Windows.Forms.Button
  Friend WithEvents BtnStationYingYong As System.Windows.Forms.Button
  Friend WithEvents TabStationInfo As System.Windows.Forms.TabControl
  Friend WithEvents TabStationIDIPName As System.Windows.Forms.TabPage
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents TextBoxStationModeIndex As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents TextBoxStationNo As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxStationIP As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxStationID As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents CheckBoxStationActive As System.Windows.Forms.CheckBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents TabStationParameter As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnSelctNextStation As System.Windows.Forms.Button
  Friend WithEvents BtnSelctPerStation As System.Windows.Forms.Button
  Friend WithEvents ComboBoxSelectStation As System.Windows.Forms.ComboBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents TextBoxParameter0 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxParameter1 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxParameter2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxParameter3 As System.Windows.Forms.TextBox
  Friend WithEvents BtnStationParameterYingYong As System.Windows.Forms.Button
  Friend WithEvents BtnStationParameterQuXiao As System.Windows.Forms.Button
  Friend WithEvents ListBoxTabStationParameter As System.Windows.Forms.ListBox
  Friend WithEvents TextBoxStationParameterAmount As System.Windows.Forms.TextBox
  Friend WithEvents CheckBoxTabStationParameter As System.Windows.Forms.CheckBox
  Friend WithEvents BtnCS22 As System.Windows.Forms.Button
  Friend WithEvents BtnCS21 As System.Windows.Forms.Button
  Friend WithEvents ComboBoxSelectMap0 As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents BtnDelStation As System.Windows.Forms.Button
  Friend WithEvents ToolBarTongXun As System.Windows.Forms.ToolBar
  Friend WithEvents ToolBarTXStartServer As System.Windows.Forms.ToolBarButton
  Friend WithEvents ImageListToolBarTongXun As System.Windows.Forms.ImageList
  Friend WithEvents ToolBarTXStopServer As System.Windows.Forms.ToolBarButton
  Friend WithEvents ToolBarButtonTXSetting As System.Windows.Forms.ToolBarButton
  Friend WithEvents LabelSelectNo As System.Windows.Forms.Label
  Friend WithEvents TimerPollUserTable As System.Windows.Forms.Timer
  Friend WithEvents BtnNextMap As System.Windows.Forms.Button
  Friend WithEvents ButtonPerMap As System.Windows.Forms.Button
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents TextBoxStationAddress As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxStationName As System.Windows.Forms.TextBox
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents LabelStationAddress As System.Windows.Forms.Label
  Friend WithEvents OpenFileDialogWork As System.Windows.Forms.OpenFileDialog
  Friend WithEvents SaveFileDialogWork As System.Windows.Forms.SaveFileDialog
  Friend WithEvents AxWinsock2 As AxMSWinsockLib.AxWinsock
  Friend WithEvents AxShockwaveFlashMainForm As AxShockwaveFlashObjects.AxShockwaveFlash
  Friend WithEvents BtnSaveWork As System.Windows.Forms.Button
  Friend WithEvents BtnOpenWork As System.Windows.Forms.Button
  Friend WithEvents BtnPrintLS As System.Windows.Forms.Button
  Friend WithEvents PanelTmp As System.Windows.Forms.Panel
  Friend WithEvents ButtonSaveDB As System.Windows.Forms.Button
  Friend WithEvents ButtonLoadDB As System.Windows.Forms.Button
  Friend WithEvents lstInfo As System.Windows.Forms.ListView
  Friend WithEvents modemId As System.Windows.Forms.ColumnHeader
  Friend WithEvents telNo As System.Windows.Forms.ColumnHeader
  Friend WithEvents loginTime As System.Windows.Forms.ColumnHeader
  Friend WithEvents dynamicIP As System.Windows.Forms.ColumnHeader
  Friend WithEvents txtInfo As System.Windows.Forms.RichTextBox
  Friend WithEvents txtPCount As System.Windows.Forms.TextBox
  Friend WithEvents TimerNow As System.Windows.Forms.Timer
  Friend WithEvents ChkAutoStart As System.Windows.Forms.CheckBox
  Friend WithEvents GrpTXMode As System.Windows.Forms.GroupBox
  Friend WithEvents RaBtnA As System.Windows.Forms.RadioButton
  Friend WithEvents RaBtnM As System.Windows.Forms.RadioButton
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents GrpMTX As System.Windows.Forms.GroupBox
  Friend WithEvents RadBtnSin As System.Windows.Forms.RadioButton
  Friend WithEvents RadBtnAll As System.Windows.Forms.RadioButton
  Friend WithEvents ChkRevTest As System.Windows.Forms.CheckBox
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents NumUDID As System.Windows.Forms.NumericUpDown
  Friend WithEvents BtnSend As System.Windows.Forms.Button
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnDel As System.Windows.Forms.Button
  Friend WithEvents BtnClear As System.Windows.Forms.Button
  Friend WithEvents RtxtSendData As System.Windows.Forms.RichTextBox
  Friend WithEvents gifServiceStart As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents LstSuccess As System.Windows.Forms.ListBox
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents gifMSend As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents BtnMSendAbort As System.Windows.Forms.Button
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents TextBoxStationModemID As System.Windows.Forms.TextBox
  Friend WithEvents BtnCbinFile As System.Windows.Forms.Button
  Friend WithEvents DoUDTXDataMode As System.Windows.Forms.DomainUpDown
  Friend WithEvents BtnCleartxtInfo As System.Windows.Forms.Button
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents GrpATX As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
  Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
  Friend WithEvents Btn_ListBoxAtxTimePoint_Add As System.Windows.Forms.Button
  Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents Btn_ListBoxAtxTimePoint_Clear As System.Windows.Forms.Button
  Friend WithEvents Btn_ListBoxAtxTimePoint_Del As System.Windows.Forms.Button
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxOnLineStationInfo As System.Windows.Forms.ComboBox
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
  Friend WithEvents Btn_StartStop_ATX As System.Windows.Forms.Button
  Friend WithEvents GifASend As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents BtnShowStationSend As System.Windows.Forms.Button
  Friend WithEvents TimerCheckRev As System.Windows.Forms.Timer
  Friend WithEvents TimerThreadRevMSend As System.Windows.Forms.Timer
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents BtnLieBiao As System.Windows.Forms.Button
  Friend WithEvents AxAniGIFRedDotHandel As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents AxAniGIFOnLine As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents AxAniGIFAsend As AxAniGIFCtrl.AxAniGIF
  Friend WithEvents PanelPicBoxEaglEye As System.Windows.Forms.Panel
  Friend WithEvents LblRecordVer As System.Windows.Forms.Label
  Friend WithEvents CS6 As GPRS.ControlShowParameterNew
  Friend WithEvents CS3 As GPRS.ControlShowParameterNew
  Friend WithEvents CS5 As GPRS.ControlShowParameterNew
  Friend WithEvents CS2 As GPRS.ControlShowParameterNew
  Friend WithEvents CS4 As GPRS.ControlShowParameterNew
  Friend WithEvents CS1 As GPRS.ControlShowParameterNew
  Friend WithEvents CS9 As GPRS.ControlShowParameterNew
  Friend WithEvents CS8 As GPRS.ControlShowParameterNew
  Friend WithEvents CS7 As GPRS.ControlShowParameterNew
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents MenuItemFile As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemOpenWork As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemSaveWork As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuItemLogout As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuFileExit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemView As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemViewMap As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemViewStation As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemViewTX As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemSetting As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuWorkSetting As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuItemTXSetting As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuItemSettingPerson As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemTools As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ͨѶ����TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemTXStartServer As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemTXStopServer As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuItemSaveShuJu As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemChaXun As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuItemPrint As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemPrintXX As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemPrintLS As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ����HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents RadioBtn_ATX_Time2 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioBtn_ATX_Time1 As System.Windows.Forms.RadioButton
  Friend WithEvents Label30 As System.Windows.Forms.Label
  Friend WithEvents RadioBtn_ATX_Time3 As System.Windows.Forms.RadioButton
  Friend WithEvents NumericUpDown_ATX_Hours As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label_ATX_Note As System.Windows.Forms.Label
  Friend WithEvents Label31 As System.Windows.Forms.Label
  Friend WithEvents Lbl_ATX_StartRunTime_Next As System.Windows.Forms.Label
  Friend WithEvents TimerATX As System.Windows.Forms.Timer
  Friend WithEvents TimerATXRev As System.Windows.Forms.Timer
  Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
  Friend WithEvents Btn_Clear_LstATXSuccess As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents LstATXSuccess As System.Windows.Forms.ListBox
  Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuItemFlexTChart As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Lbl_ATX_Now As System.Windows.Forms.Label
  Friend WithEvents BtnTmpSave As System.Windows.Forms.Button
  Friend WithEvents BtnViewDB As System.Windows.Forms.Button
  Friend WithEvents CS10 As GPRS.ControlShowParameterNew
  Friend WithEvents GroupBoxSendMessage As System.Windows.Forms.GroupBox
  Friend WithEvents TextBoxSendMessage10 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage9 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage8 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage7 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage6 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage5 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage4 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage3 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxSendMessage1 As System.Windows.Forms.TextBox
  Friend WithEvents lblSendMessageDanWei1 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei10 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei9 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei8 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei7 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei6 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei5 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei4 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei3 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageDanWei2 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName8 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName7 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName6 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName5 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName4 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName3 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName2 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName1 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName10 As System.Windows.Forms.Label
  Friend WithEvents lblSendMessageName9 As System.Windows.Forms.Label
  Friend WithEvents btnSendMessageSend As System.Windows.Forms.Button
  Friend WithEvents btnShowSendMessage As System.Windows.Forms.Button
  Friend WithEvents PanelSendMessage As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents LabelSendMessageSendState As System.Windows.Forms.Label
  Friend WithEvents TimerSendSSS As System.Windows.Forms.Timer
  Friend WithEvents LabelSendSSSWaiTimeS As System.Windows.Forms.Label
  Friend WithEvents ListBoxAtxTimePoint As System.Windows.Forms.ListBox

  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.Button1 = New System.Windows.Forms.Button
    Me.StatusBar1 = New System.Windows.Forms.StatusBar
    Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
    Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
    Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.gifServiceStart = New AxAniGIFCtrl.AxAniGIF
    Me.BtnMSendAbort = New System.Windows.Forms.Button
    Me.Btn_ListBoxAtxTimePoint_Add = New System.Windows.Forms.Button
    Me.Btn_ListBoxAtxTimePoint_Clear = New System.Windows.Forms.Button
    Me.Btn_ListBoxAtxTimePoint_Del = New System.Windows.Forms.Button
    Me.AxAniGIFOnLine = New AxAniGIFCtrl.AxAniGIF
    Me.AxAniGIFAsend = New AxAniGIFCtrl.AxAniGIF
    Me.BtnLogout = New System.Windows.Forms.Button
    Me.BtnLieBiao = New System.Windows.Forms.Button
    Me.BtnNextMap = New System.Windows.Forms.Button
    Me.ButtonPerMap = New System.Windows.Forms.Button
    Me.BtnFDHY = New System.Windows.Forms.Button
    Me.BtnFDSX = New System.Windows.Forms.Button
    Me.BtnFDFD = New System.Windows.Forms.Button
    Me.BtnPlaceStation = New System.Windows.Forms.Button
    Me.BtnSelctNextStation = New System.Windows.Forms.Button
    Me.BtnSelctPerStation = New System.Windows.Forms.Button
    Me.BtnDelStation = New System.Windows.Forms.Button
    Me.BtnStationQuXiao = New System.Windows.Forms.Button
    Me.BtnStationYingYong = New System.Windows.Forms.Button
    Me.BtnStationParameterYingYong = New System.Windows.Forms.Button
    Me.BtnStationParameterQuXiao = New System.Windows.Forms.Button
    Me.BtnShowStationSend = New System.Windows.Forms.Button
    Me.Btn_StartStop_ATX = New System.Windows.Forms.Button
    Me.btnShowSendMessage = New System.Windows.Forms.Button
    Me.PanelToolBar = New System.Windows.Forms.Panel
    Me.BtnViewDB = New System.Windows.Forms.Button
    Me.BtnPrintLS = New System.Windows.Forms.Button
    Me.Label19 = New System.Windows.Forms.Label
    Me.Label18 = New System.Windows.Forms.Label
    Me.ButtonSaveDB = New System.Windows.Forms.Button
    Me.ButtonLoadDB = New System.Windows.Forms.Button
    Me.BtnSaveWork = New System.Windows.Forms.Button
    Me.BtnOpenWork = New System.Windows.Forms.Button
    Me.BtnPrint = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.LblRecordVer = New System.Windows.Forms.Label
    Me.ComboBoxSelectMap0 = New System.Windows.Forms.ComboBox
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabShowMap = New System.Windows.Forms.TabPage
    Me.AxAniGIFRedDotHandel = New AxAniGIFCtrl.AxAniGIF
    Me.PanelPicBoxMap = New System.Windows.Forms.Panel
    Me.PanelPicBoxMapMove = New System.Windows.Forms.Panel
    Me.AniGIFStation = New AxAniGIFCtrl.AxAniGIF
    Me.PicBoxMap = New System.Windows.Forms.PictureBox
    Me.PanelPassword = New System.Windows.Forms.Panel
    Me.BtnOut = New System.Windows.Forms.Button
    Me.BtnIn = New System.Windows.Forms.Button
    Me.CheckBoxPassword = New System.Windows.Forms.CheckBox
    Me.ComboBoxPersonName = New System.Windows.Forms.ComboBox
    Me.TextBoxPassword = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.PanelEaglEye = New System.Windows.Forms.Panel
    Me.PanelPicBoxEaglEye = New System.Windows.Forms.Panel
    Me.PicBoxEaglEye = New System.Windows.Forms.PictureBox
    Me.AxShockwaveFlashMainForm = New AxShockwaveFlashObjects.AxShockwaveFlash
    Me.PanelTmp = New System.Windows.Forms.Panel
    Me.TabShowStation = New System.Windows.Forms.TabPage
    Me.GroupBoxAboutStation = New System.Windows.Forms.GroupBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.ComboBoxSelectStation = New System.Windows.Forms.ComboBox
    Me.TabStationInfo = New System.Windows.Forms.TabControl
    Me.TabStationIDIPName = New System.Windows.Forms.TabPage
    Me.TextBoxStationModemID = New System.Windows.Forms.TextBox
    Me.Label23 = New System.Windows.Forms.Label
    Me.TextBoxStationAddress = New System.Windows.Forms.TextBox
    Me.Label17 = New System.Windows.Forms.Label
    Me.TextBoxStationNo = New System.Windows.Forms.TextBox
    Me.TextBoxStationName = New System.Windows.Forms.TextBox
    Me.TextBoxStationIP = New System.Windows.Forms.TextBox
    Me.TextBoxStationID = New System.Windows.Forms.TextBox
    Me.TextBoxStationParameterAmount = New System.Windows.Forms.TextBox
    Me.Label12 = New System.Windows.Forms.Label
    Me.TextBoxStationModeIndex = New System.Windows.Forms.TextBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.CheckBoxStationActive = New System.Windows.Forms.CheckBox
    Me.Label10 = New System.Windows.Forms.Label
    Me.Label9 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.TabStationParameter = New System.Windows.Forms.TabPage
    Me.LabelSelectNo = New System.Windows.Forms.Label
    Me.TextBoxParameter1 = New System.Windows.Forms.TextBox
    Me.TextBoxParameter0 = New System.Windows.Forms.TextBox
    Me.CheckBoxTabStationParameter = New System.Windows.Forms.CheckBox
    Me.ListBoxTabStationParameter = New System.Windows.Forms.ListBox
    Me.TextBoxParameter3 = New System.Windows.Forms.TextBox
    Me.TextBoxParameter2 = New System.Windows.Forms.TextBox
    Me.Label15 = New System.Windows.Forms.Label
    Me.Label16 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label13 = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.ComboBoxSelectMap1 = New System.Windows.Forms.ComboBox
    Me.PanelStation = New System.Windows.Forms.Panel
    Me.PanelSendMessage = New System.Windows.Forms.Panel
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.LabelSendSSSWaiTimeS = New System.Windows.Forms.Label
    Me.LabelSendMessageSendState = New System.Windows.Forms.Label
    Me.btnSendMessageSend = New System.Windows.Forms.Button
    Me.GroupBoxSendMessage = New System.Windows.Forms.GroupBox
    Me.lblSendMessageName10 = New System.Windows.Forms.Label
    Me.lblSendMessageName9 = New System.Windows.Forms.Label
    Me.lblSendMessageName8 = New System.Windows.Forms.Label
    Me.lblSendMessageName7 = New System.Windows.Forms.Label
    Me.lblSendMessageName6 = New System.Windows.Forms.Label
    Me.lblSendMessageName5 = New System.Windows.Forms.Label
    Me.lblSendMessageName4 = New System.Windows.Forms.Label
    Me.lblSendMessageName3 = New System.Windows.Forms.Label
    Me.lblSendMessageName2 = New System.Windows.Forms.Label
    Me.lblSendMessageName1 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei10 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei9 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei8 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei7 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei6 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei5 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei4 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei3 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei2 = New System.Windows.Forms.Label
    Me.lblSendMessageDanWei1 = New System.Windows.Forms.Label
    Me.TextBoxSendMessage10 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage9 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage8 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage7 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage6 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage5 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage4 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage3 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage2 = New System.Windows.Forms.TextBox
    Me.TextBoxSendMessage1 = New System.Windows.Forms.TextBox
    Me.LabelStationAddress = New System.Windows.Forms.Label
    Me.BtnCS21 = New System.Windows.Forms.Button
    Me.BtnCS22 = New System.Windows.Forms.Button
    Me.PicboxStation = New System.Windows.Forms.PictureBox
    Me.TabShowComm = New System.Windows.Forms.TabPage
    Me.GrpMTX = New System.Windows.Forms.GroupBox
    Me.ComboBoxOnLineStationInfo = New System.Windows.Forms.ComboBox
    Me.DoUDTXDataMode = New System.Windows.Forms.DomainUpDown
    Me.BtnCbinFile = New System.Windows.Forms.Button
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.BtnClear = New System.Windows.Forms.Button
    Me.BtnDel = New System.Windows.Forms.Button
    Me.LstSuccess = New System.Windows.Forms.ListBox
    Me.Label22 = New System.Windows.Forms.Label
    Me.NumUDID = New System.Windows.Forms.NumericUpDown
    Me.RadBtnSin = New System.Windows.Forms.RadioButton
    Me.RadBtnAll = New System.Windows.Forms.RadioButton
    Me.BtnSend = New System.Windows.Forms.Button
    Me.Label20 = New System.Windows.Forms.Label
    Me.RtxtSendData = New System.Windows.Forms.RichTextBox
    Me.GroupBox4 = New System.Windows.Forms.GroupBox
    Me.gifMSend = New AxAniGIFCtrl.AxAniGIF
    Me.Label24 = New System.Windows.Forms.Label
    Me.Label27 = New System.Windows.Forms.Label
    Me.PanelComm = New System.Windows.Forms.Panel
    Me.GrpATX = New System.Windows.Forms.GroupBox
    Me.GroupBox7 = New System.Windows.Forms.GroupBox
    Me.Btn_Clear_LstATXSuccess = New System.Windows.Forms.Button
    Me.Button3 = New System.Windows.Forms.Button
    Me.LstATXSuccess = New System.Windows.Forms.ListBox
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.BtnTmpSave = New System.Windows.Forms.Button
    Me.Lbl_ATX_Now = New System.Windows.Forms.Label
    Me.Lbl_ATX_StartRunTime_Next = New System.Windows.Forms.Label
    Me.Label31 = New System.Windows.Forms.Label
    Me.Label_ATX_Note = New System.Windows.Forms.Label
    Me.NumericUpDown_ATX_Hours = New System.Windows.Forms.NumericUpDown
    Me.Label30 = New System.Windows.Forms.Label
    Me.RadioBtn_ATX_Time3 = New System.Windows.Forms.RadioButton
    Me.RadioBtn_ATX_Time2 = New System.Windows.Forms.RadioButton
    Me.RadioBtn_ATX_Time1 = New System.Windows.Forms.RadioButton
    Me.GroupBox5 = New System.Windows.Forms.GroupBox
    Me.GifASend = New AxAniGIFCtrl.AxAniGIF
    Me.GroupBox6 = New System.Windows.Forms.GroupBox
    Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown
    Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
    Me.ListBoxAtxTimePoint = New System.Windows.Forms.ListBox
    Me.Label26 = New System.Windows.Forms.Label
    Me.Label28 = New System.Windows.Forms.Label
    Me.CheckBox1 = New System.Windows.Forms.CheckBox
    Me.Label29 = New System.Windows.Forms.Label
    Me.Label25 = New System.Windows.Forms.Label
    Me.RadioButton1 = New System.Windows.Forms.RadioButton
    Me.RadioButton2 = New System.Windows.Forms.RadioButton
    Me.ChkRevTest = New System.Windows.Forms.CheckBox
    Me.GrpTXMode = New System.Windows.Forms.GroupBox
    Me.RaBtnM = New System.Windows.Forms.RadioButton
    Me.RaBtnA = New System.Windows.Forms.RadioButton
    Me.ChkAutoStart = New System.Windows.Forms.CheckBox
    Me.txtPCount = New System.Windows.Forms.TextBox
    Me.BtnCleartxtInfo = New System.Windows.Forms.Button
    Me.Label21 = New System.Windows.Forms.Label
    Me.txtInfo = New System.Windows.Forms.RichTextBox
    Me.lstInfo = New System.Windows.Forms.ListView
    Me.modemId = New System.Windows.Forms.ColumnHeader
    Me.telNo = New System.Windows.Forms.ColumnHeader
    Me.loginTime = New System.Windows.Forms.ColumnHeader
    Me.dynamicIP = New System.Windows.Forms.ColumnHeader
    Me.ToolBarTongXun = New System.Windows.Forms.ToolBar
    Me.ToolBarTXStartServer = New System.Windows.Forms.ToolBarButton
    Me.ToolBarTXStopServer = New System.Windows.Forms.ToolBarButton
    Me.ToolBarButtonTXSetting = New System.Windows.Forms.ToolBarButton
    Me.ImageListToolBarTongXun = New System.Windows.Forms.ImageList(Me.components)
    Me.ImageListTab = New System.Windows.Forms.ImageList(Me.components)
    Me.TimerCheckRev = New System.Windows.Forms.Timer(Me.components)
    Me.AniGifMainForm = New AxAniGIFCtrl.AxAniGIF
    Me.TimerThreadRevMSend = New System.Windows.Forms.Timer(Me.components)
    Me.TimerPollUserTable = New System.Windows.Forms.Timer(Me.components)
    Me.OpenFileDialogWork = New System.Windows.Forms.OpenFileDialog
    Me.SaveFileDialogWork = New System.Windows.Forms.SaveFileDialog
    Me.TimerNow = New System.Windows.Forms.Timer(Me.components)
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
    Me.MenuItemFile = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemOpenWork = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemSaveWork = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemLogout = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemView = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemViewMap = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemViewStation = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemViewTX = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemFlexTChart = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemSetting = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuWorkSetting = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemTXSetting = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemSettingPerson = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemTools = New System.Windows.Forms.ToolStripMenuItem
    Me.ͨѶ����TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemTXStartServer = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemTXStopServer = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemSaveShuJu = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemChaXun = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemPrint = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemPrintXX = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemPrintLS = New System.Windows.Forms.ToolStripMenuItem
    Me.����HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemAbout = New System.Windows.Forms.ToolStripMenuItem
    Me.TimerATX = New System.Windows.Forms.Timer(Me.components)
    Me.TimerATXRev = New System.Windows.Forms.Timer(Me.components)
    Me.TimerSendSSS = New System.Windows.Forms.Timer(Me.components)
    Me.CS10 = New GPRS.ControlShowParameterNew
    Me.CS9 = New GPRS.ControlShowParameterNew
    Me.CS8 = New GPRS.ControlShowParameterNew
    Me.CS7 = New GPRS.ControlShowParameterNew
    Me.CS6 = New GPRS.ControlShowParameterNew
    Me.CS3 = New GPRS.ControlShowParameterNew
    Me.CS5 = New GPRS.ControlShowParameterNew
    Me.CS2 = New GPRS.ControlShowParameterNew
    Me.CS4 = New GPRS.ControlShowParameterNew
    Me.CS1 = New GPRS.ControlShowParameterNew
    CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gifServiceStart, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.AxAniGIFOnLine, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.AxAniGIFAsend, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelToolBar.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabShowMap.SuspendLayout()
    CType(Me.AxAniGIFRedDotHandel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelPicBoxMap.SuspendLayout()
    Me.PanelPicBoxMapMove.SuspendLayout()
    CType(Me.AniGIFStation, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PicBoxMap, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelPassword.SuspendLayout()
    Me.PanelEaglEye.SuspendLayout()
    Me.PanelPicBoxEaglEye.SuspendLayout()
    CType(Me.PicBoxEaglEye, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.AxShockwaveFlashMainForm, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabShowStation.SuspendLayout()
    Me.GroupBoxAboutStation.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.TabStationInfo.SuspendLayout()
    Me.TabStationIDIPName.SuspendLayout()
    Me.TabStationParameter.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.PanelStation.SuspendLayout()
    Me.PanelSendMessage.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.GroupBoxSendMessage.SuspendLayout()
    CType(Me.PicboxStation, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabShowComm.SuspendLayout()
    Me.GrpMTX.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    CType(Me.NumUDID, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox4.SuspendLayout()
    CType(Me.gifMSend, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelComm.SuspendLayout()
    Me.GrpATX.SuspendLayout()
    Me.GroupBox7.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.NumericUpDown_ATX_Hours, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox5.SuspendLayout()
    CType(Me.GifASend, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox6.SuspendLayout()
    CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpTXMode.SuspendLayout()
    CType(Me.AniGifMainForm, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button1.Location = New System.Drawing.Point(881, 542)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(128, 32)
    Me.Button1.TabIndex = 6
    Me.Button1.Text = "����"
    Me.Button1.Visible = False
    '
    'StatusBar1
    '
    Me.StatusBar1.Location = New System.Drawing.Point(0, 674)
    Me.StatusBar1.Name = "StatusBar1"
    Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3})
    Me.StatusBar1.Size = New System.Drawing.Size(1016, 22)
    Me.StatusBar1.TabIndex = 8
    Me.StatusBar1.Text = "��������"
    '
    'StatusBarPanel1
    '
    Me.StatusBarPanel1.Name = "StatusBarPanel1"
    Me.StatusBarPanel1.Text = "StatusBarPanel1"
    '
    'StatusBarPanel2
    '
    Me.StatusBarPanel2.Name = "StatusBarPanel2"
    Me.StatusBarPanel2.Text = "StatusBarPanel2"
    '
    'StatusBarPanel3
    '
    Me.StatusBarPanel3.Name = "StatusBarPanel3"
    Me.StatusBarPanel3.Text = "StatusBarPanel3"
    '
    'gifServiceStart
    '
    Me.gifServiceStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gifServiceStart.Enabled = True
    Me.gifServiceStart.Location = New System.Drawing.Point(912, -2)
    Me.gifServiceStart.Name = "gifServiceStart"
    Me.gifServiceStart.OcxState = CType(resources.GetObject("gifServiceStart.OcxState"), System.Windows.Forms.AxHost.State)
    Me.gifServiceStart.Size = New System.Drawing.Size(40, 40)
    Me.gifServiceStart.TabIndex = 35
    Me.ToolTip1.SetToolTip(Me.gifServiceStart, "�Ѿ����ߣ���������")
    Me.gifServiceStart.Visible = False
    '
    'BtnMSendAbort
    '
    Me.BtnMSendAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnMSendAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnMSendAbort.Location = New System.Drawing.Point(109, 31)
    Me.BtnMSendAbort.Name = "BtnMSendAbort"
    Me.BtnMSendAbort.Size = New System.Drawing.Size(64, 26)
    Me.BtnMSendAbort.TabIndex = 32
    Me.BtnMSendAbort.Text = "����ж�"
    Me.BtnMSendAbort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnMSendAbort, "����ж�")
    '
    'Btn_ListBoxAtxTimePoint_Add
    '
    Me.Btn_ListBoxAtxTimePoint_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.Btn_ListBoxAtxTimePoint_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Btn_ListBoxAtxTimePoint_Add.Location = New System.Drawing.Point(124, 244)
    Me.Btn_ListBoxAtxTimePoint_Add.Name = "Btn_ListBoxAtxTimePoint_Add"
    Me.Btn_ListBoxAtxTimePoint_Add.Size = New System.Drawing.Size(52, 24)
    Me.Btn_ListBoxAtxTimePoint_Add.TabIndex = 32
    Me.Btn_ListBoxAtxTimePoint_Add.Text = "���"
    Me.ToolTip1.SetToolTip(Me.Btn_ListBoxAtxTimePoint_Add, "����ж�")
    '
    'Btn_ListBoxAtxTimePoint_Clear
    '
    Me.Btn_ListBoxAtxTimePoint_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.Btn_ListBoxAtxTimePoint_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Btn_ListBoxAtxTimePoint_Clear.Location = New System.Drawing.Point(112, 176)
    Me.Btn_ListBoxAtxTimePoint_Clear.Name = "Btn_ListBoxAtxTimePoint_Clear"
    Me.Btn_ListBoxAtxTimePoint_Clear.Size = New System.Drawing.Size(64, 24)
    Me.Btn_ListBoxAtxTimePoint_Clear.TabIndex = 44
    Me.Btn_ListBoxAtxTimePoint_Clear.Text = "���"
    Me.ToolTip1.SetToolTip(Me.Btn_ListBoxAtxTimePoint_Clear, "����ж�")
    '
    'Btn_ListBoxAtxTimePoint_Del
    '
    Me.Btn_ListBoxAtxTimePoint_Del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.Btn_ListBoxAtxTimePoint_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Btn_ListBoxAtxTimePoint_Del.Location = New System.Drawing.Point(12, 176)
    Me.Btn_ListBoxAtxTimePoint_Del.Name = "Btn_ListBoxAtxTimePoint_Del"
    Me.Btn_ListBoxAtxTimePoint_Del.Size = New System.Drawing.Size(64, 24)
    Me.Btn_ListBoxAtxTimePoint_Del.TabIndex = 45
    Me.Btn_ListBoxAtxTimePoint_Del.Text = "ɾ��"
    Me.ToolTip1.SetToolTip(Me.Btn_ListBoxAtxTimePoint_Del, "����ж�")
    '
    'AxAniGIFOnLine
    '
    Me.AxAniGIFOnLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.AxAniGIFOnLine.Enabled = True
    Me.AxAniGIFOnLine.Location = New System.Drawing.Point(856, 24)
    Me.AxAniGIFOnLine.Name = "AxAniGIFOnLine"
    Me.AxAniGIFOnLine.OcxState = CType(resources.GetObject("AxAniGIFOnLine.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AxAniGIFOnLine.Size = New System.Drawing.Size(40, 40)
    Me.AxAniGIFOnLine.TabIndex = 36
    Me.ToolTip1.SetToolTip(Me.AxAniGIFOnLine, "Ŀǰ������վ��")
    Me.AxAniGIFOnLine.Visible = False
    '
    'AxAniGIFAsend
    '
    Me.AxAniGIFAsend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.AxAniGIFAsend.Enabled = True
    Me.AxAniGIFAsend.Location = New System.Drawing.Point(828, 16)
    Me.AxAniGIFAsend.Name = "AxAniGIFAsend"
    Me.AxAniGIFAsend.OcxState = CType(resources.GetObject("AxAniGIFAsend.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AxAniGIFAsend.Size = New System.Drawing.Size(40, 40)
    Me.AxAniGIFAsend.TabIndex = 37
    Me.ToolTip1.SetToolTip(Me.AxAniGIFAsend, "Ŀǰ������վ��")
    Me.AxAniGIFAsend.Visible = False
    '
    'BtnLogout
    '
    Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnLogout.ForeColor = System.Drawing.Color.Indigo
    Me.BtnLogout.Image = Global.GPRS.My.Resources.Resources._32logout
    Me.BtnLogout.Location = New System.Drawing.Point(968, 2)
    Me.BtnLogout.Name = "BtnLogout"
    Me.BtnLogout.Size = New System.Drawing.Size(40, 32)
    Me.BtnLogout.TabIndex = 23
    Me.ToolTip1.SetToolTip(Me.BtnLogout, "ע���û�")
    '
    'BtnLieBiao
    '
    Me.BtnLieBiao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnLieBiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnLieBiao.Image = CType(resources.GetObject("BtnLieBiao.Image"), System.Drawing.Image)
    Me.BtnLieBiao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnLieBiao.Location = New System.Drawing.Point(766, 2)
    Me.BtnLieBiao.Name = "BtnLieBiao"
    Me.BtnLieBiao.Size = New System.Drawing.Size(32, 29)
    Me.BtnLieBiao.TabIndex = 35
    Me.BtnLieBiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnLieBiao, "�б�鿴����")
    '
    'BtnNextMap
    '
    Me.BtnNextMap.BackColor = System.Drawing.Color.Transparent
    Me.BtnNextMap.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnNextMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnNextMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnNextMap.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnNextMap.Image = CType(resources.GetObject("BtnNextMap.Image"), System.Drawing.Image)
    Me.BtnNextMap.Location = New System.Drawing.Point(120, 4)
    Me.BtnNextMap.Name = "BtnNextMap"
    Me.BtnNextMap.Size = New System.Drawing.Size(23, 18)
    Me.BtnNextMap.TabIndex = 28
    Me.BtnNextMap.Tag = ""
    Me.BtnNextMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnNextMap, "��һ��ͼ")
    Me.BtnNextMap.UseVisualStyleBackColor = False
    '
    'ButtonPerMap
    '
    Me.ButtonPerMap.BackColor = System.Drawing.Color.Transparent
    Me.ButtonPerMap.Cursor = System.Windows.Forms.Cursors.Hand
    Me.ButtonPerMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.ButtonPerMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.ButtonPerMap.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.ButtonPerMap.Image = CType(resources.GetObject("ButtonPerMap.Image"), System.Drawing.Image)
    Me.ButtonPerMap.Location = New System.Drawing.Point(3, 4)
    Me.ButtonPerMap.Name = "ButtonPerMap"
    Me.ButtonPerMap.Size = New System.Drawing.Size(23, 18)
    Me.ButtonPerMap.TabIndex = 27
    Me.ButtonPerMap.Tag = ""
    Me.ButtonPerMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.ButtonPerMap, "��һ��ͼ")
    Me.ButtonPerMap.UseVisualStyleBackColor = False
    '
    'BtnFDHY
    '
    Me.BtnFDHY.Cursor = System.Windows.Forms.Cursors.Default
    Me.BtnFDHY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnFDHY.Image = CType(resources.GetObject("BtnFDHY.Image"), System.Drawing.Image)
    Me.BtnFDHY.Location = New System.Drawing.Point(229, 3)
    Me.BtnFDHY.Name = "BtnFDHY"
    Me.BtnFDHY.Size = New System.Drawing.Size(34, 29)
    Me.BtnFDHY.TabIndex = 21
    Me.BtnFDHY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnFDHY, "��ԭ")
    '
    'BtnFDSX
    '
    Me.BtnFDSX.Cursor = System.Windows.Forms.Cursors.Default
    Me.BtnFDSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnFDSX.Image = CType(resources.GetObject("BtnFDSX.Image"), System.Drawing.Image)
    Me.BtnFDSX.Location = New System.Drawing.Point(190, 3)
    Me.BtnFDSX.Name = "BtnFDSX"
    Me.BtnFDSX.Size = New System.Drawing.Size(34, 29)
    Me.BtnFDSX.TabIndex = 20
    Me.BtnFDSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnFDSX, "��С")
    '
    'BtnFDFD
    '
    Me.BtnFDFD.Cursor = System.Windows.Forms.Cursors.Default
    Me.BtnFDFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnFDFD.Image = CType(resources.GetObject("BtnFDFD.Image"), System.Drawing.Image)
    Me.BtnFDFD.Location = New System.Drawing.Point(151, 3)
    Me.BtnFDFD.Name = "BtnFDFD"
    Me.BtnFDFD.Size = New System.Drawing.Size(34, 29)
    Me.BtnFDFD.TabIndex = 19
    Me.BtnFDFD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnFDFD, "�Ŵ�")
    '
    'BtnPlaceStation
    '
    Me.BtnPlaceStation.Cursor = System.Windows.Forms.Cursors.Default
    Me.BtnPlaceStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnPlaceStation.Image = CType(resources.GetObject("BtnPlaceStation.Image"), System.Drawing.Image)
    Me.BtnPlaceStation.Location = New System.Drawing.Point(268, 3)
    Me.BtnPlaceStation.Name = "BtnPlaceStation"
    Me.BtnPlaceStation.Size = New System.Drawing.Size(34, 29)
    Me.BtnPlaceStation.TabIndex = 22
    Me.BtnPlaceStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnPlaceStation, "����վ��")
    '
    'BtnSelctNextStation
    '
    Me.BtnSelctNextStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnSelctNextStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnSelctNextStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSelctNextStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnSelctNextStation.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnSelctNextStation.Image = CType(resources.GetObject("BtnSelctNextStation.Image"), System.Drawing.Image)
    Me.BtnSelctNextStation.Location = New System.Drawing.Point(142, 47)
    Me.BtnSelctNextStation.Name = "BtnSelctNextStation"
    Me.BtnSelctNextStation.Size = New System.Drawing.Size(33, 19)
    Me.BtnSelctNextStation.TabIndex = 8
    Me.BtnSelctNextStation.Tag = ""
    Me.BtnSelctNextStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnSelctNextStation, "��һվ��")
    Me.BtnSelctNextStation.UseVisualStyleBackColor = False
    '
    'BtnSelctPerStation
    '
    Me.BtnSelctPerStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnSelctPerStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnSelctPerStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSelctPerStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnSelctPerStation.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnSelctPerStation.Image = CType(resources.GetObject("BtnSelctPerStation.Image"), System.Drawing.Image)
    Me.BtnSelctPerStation.Location = New System.Drawing.Point(105, 47)
    Me.BtnSelctPerStation.Name = "BtnSelctPerStation"
    Me.BtnSelctPerStation.Size = New System.Drawing.Size(33, 19)
    Me.BtnSelctPerStation.TabIndex = 7
    Me.BtnSelctPerStation.Tag = ""
    Me.BtnSelctPerStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnSelctPerStation, "��һվ��")
    Me.BtnSelctPerStation.UseVisualStyleBackColor = False
    '
    'BtnDelStation
    '
    Me.BtnDelStation.BackColor = System.Drawing.Color.Transparent
    Me.BtnDelStation.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnDelStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnDelStation.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnDelStation.ForeColor = System.Drawing.Color.Black
    Me.BtnDelStation.Image = CType(resources.GetObject("BtnDelStation.Image"), System.Drawing.Image)
    Me.BtnDelStation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnDelStation.Location = New System.Drawing.Point(100, 157)
    Me.BtnDelStation.Name = "BtnDelStation"
    Me.BtnDelStation.Size = New System.Drawing.Size(64, 24)
    Me.BtnDelStation.TabIndex = 15
    Me.BtnDelStation.Tag = ""
    Me.BtnDelStation.Text = "ɾ��"
    Me.BtnDelStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnDelStation, "ɾ��վ��")
    Me.BtnDelStation.UseVisualStyleBackColor = False
    '
    'BtnStationQuXiao
    '
    Me.BtnStationQuXiao.BackColor = System.Drawing.Color.Transparent
    Me.BtnStationQuXiao.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnStationQuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnStationQuXiao.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnStationQuXiao.ForeColor = System.Drawing.Color.Black
    Me.BtnStationQuXiao.Image = CType(resources.GetObject("BtnStationQuXiao.Image"), System.Drawing.Image)
    Me.BtnStationQuXiao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnStationQuXiao.Location = New System.Drawing.Point(100, 275)
    Me.BtnStationQuXiao.Name = "BtnStationQuXiao"
    Me.BtnStationQuXiao.Size = New System.Drawing.Size(64, 24)
    Me.BtnStationQuXiao.TabIndex = 9
    Me.BtnStationQuXiao.Tag = ""
    Me.BtnStationQuXiao.Text = "ȡ��"
    Me.BtnStationQuXiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnStationQuXiao, "ȡ�����ĵ��ǻ�û��Ӧ�õ����ݡ�")
    Me.BtnStationQuXiao.UseVisualStyleBackColor = False
    '
    'BtnStationYingYong
    '
    Me.BtnStationYingYong.BackColor = System.Drawing.Color.Transparent
    Me.BtnStationYingYong.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnStationYingYong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnStationYingYong.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnStationYingYong.ForeColor = System.Drawing.Color.Black
    Me.BtnStationYingYong.Image = CType(resources.GetObject("BtnStationYingYong.Image"), System.Drawing.Image)
    Me.BtnStationYingYong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnStationYingYong.Location = New System.Drawing.Point(20, 275)
    Me.BtnStationYingYong.Name = "BtnStationYingYong"
    Me.BtnStationYingYong.Size = New System.Drawing.Size(64, 24)
    Me.BtnStationYingYong.TabIndex = 8
    Me.BtnStationYingYong.Tag = ""
    Me.BtnStationYingYong.Text = "Ӧ��"
    Me.BtnStationYingYong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnStationYingYong, "Ӧ��")
    Me.BtnStationYingYong.UseVisualStyleBackColor = False
    '
    'BtnStationParameterYingYong
    '
    Me.BtnStationParameterYingYong.BackColor = System.Drawing.Color.Transparent
    Me.BtnStationParameterYingYong.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnStationParameterYingYong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnStationParameterYingYong.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnStationParameterYingYong.ForeColor = System.Drawing.Color.Black
    Me.BtnStationParameterYingYong.Image = CType(resources.GetObject("BtnStationParameterYingYong.Image"), System.Drawing.Image)
    Me.BtnStationParameterYingYong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnStationParameterYingYong.Location = New System.Drawing.Point(20, 275)
    Me.BtnStationParameterYingYong.Name = "BtnStationParameterYingYong"
    Me.BtnStationParameterYingYong.Size = New System.Drawing.Size(64, 24)
    Me.BtnStationParameterYingYong.TabIndex = 24
    Me.BtnStationParameterYingYong.Tag = "BtnStationParameterYingYong"
    Me.BtnStationParameterYingYong.Text = "Ӧ��"
    Me.BtnStationParameterYingYong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnStationParameterYingYong, "Ӧ��")
    Me.BtnStationParameterYingYong.UseVisualStyleBackColor = False
    '
    'BtnStationParameterQuXiao
    '
    Me.BtnStationParameterQuXiao.BackColor = System.Drawing.Color.Transparent
    Me.BtnStationParameterQuXiao.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnStationParameterQuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnStationParameterQuXiao.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnStationParameterQuXiao.ForeColor = System.Drawing.Color.Black
    Me.BtnStationParameterQuXiao.Image = CType(resources.GetObject("BtnStationParameterQuXiao.Image"), System.Drawing.Image)
    Me.BtnStationParameterQuXiao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnStationParameterQuXiao.Location = New System.Drawing.Point(100, 275)
    Me.BtnStationParameterQuXiao.Name = "BtnStationParameterQuXiao"
    Me.BtnStationParameterQuXiao.Size = New System.Drawing.Size(64, 24)
    Me.BtnStationParameterQuXiao.TabIndex = 25
    Me.BtnStationParameterQuXiao.Tag = "BtnStationParameterQuXiao"
    Me.BtnStationParameterQuXiao.Text = "ȡ��"
    Me.BtnStationParameterQuXiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnStationParameterQuXiao, "ȡ�����ĵ��ǻ�û��Ӧ�õ����ݡ�")
    Me.BtnStationParameterQuXiao.UseVisualStyleBackColor = False
    '
    'BtnShowStationSend
    '
    Me.BtnShowStationSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnShowStationSend.BackColor = System.Drawing.Color.Transparent
    Me.BtnShowStationSend.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnShowStationSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnShowStationSend.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnShowStationSend.ForeColor = System.Drawing.Color.Black
    Me.BtnShowStationSend.Image = CType(resources.GetObject("BtnShowStationSend.Image"), System.Drawing.Image)
    Me.BtnShowStationSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnShowStationSend.Location = New System.Drawing.Point(675, 5)
    Me.BtnShowStationSend.Name = "BtnShowStationSend"
    Me.BtnShowStationSend.Size = New System.Drawing.Size(121, 31)
    Me.BtnShowStationSend.TabIndex = 29
    Me.BtnShowStationSend.Tag = ""
    Me.BtnShowStationSend.Text = "��ѯ��վ����"
    Me.BtnShowStationSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.BtnShowStationSend, "Ӧ��")
    Me.BtnShowStationSend.UseVisualStyleBackColor = False
    '
    'Btn_StartStop_ATX
    '
    Me.Btn_StartStop_ATX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.Btn_StartStop_ATX.Image = Global.GPRS.My.Resources.Resources._48ATX
    Me.Btn_StartStop_ATX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Btn_StartStop_ATX.Location = New System.Drawing.Point(90, 12)
    Me.Btn_StartStop_ATX.Name = "Btn_StartStop_ATX"
    Me.Btn_StartStop_ATX.Size = New System.Drawing.Size(94, 56)
    Me.Btn_StartStop_ATX.TabIndex = 32
    Me.Btn_StartStop_ATX.Text = "��ʼ"
    Me.Btn_StartStop_ATX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolTip1.SetToolTip(Me.Btn_StartStop_ATX, "����ж�")
    '
    'btnShowSendMessage
    '
    Me.btnShowSendMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnShowSendMessage.BackColor = System.Drawing.Color.Transparent
    Me.btnShowSendMessage.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnShowSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.btnShowSendMessage.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.btnShowSendMessage.ForeColor = System.Drawing.Color.Black
    Me.btnShowSendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnShowSendMessage.Location = New System.Drawing.Point(675, 66)
    Me.btnShowSendMessage.Name = "btnShowSendMessage"
    Me.btnShowSendMessage.Size = New System.Drawing.Size(121, 31)
    Me.btnShowSendMessage.TabIndex = 41
    Me.btnShowSendMessage.Tag = ""
    Me.btnShowSendMessage.Text = "��ʾ/�����´�����"
    Me.ToolTip1.SetToolTip(Me.btnShowSendMessage, "Ӧ��")
    Me.btnShowSendMessage.UseVisualStyleBackColor = False
    '
    'PanelToolBar
    '
    Me.PanelToolBar.BackColor = System.Drawing.Color.Transparent
    Me.PanelToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PanelToolBar.Controls.Add(Me.BtnViewDB)
    Me.PanelToolBar.Controls.Add(Me.AxAniGIFAsend)
    Me.PanelToolBar.Controls.Add(Me.AxAniGIFOnLine)
    Me.PanelToolBar.Controls.Add(Me.gifServiceStart)
    Me.PanelToolBar.Controls.Add(Me.BtnPrintLS)
    Me.PanelToolBar.Controls.Add(Me.Label19)
    Me.PanelToolBar.Controls.Add(Me.Label18)
    Me.PanelToolBar.Controls.Add(Me.ButtonSaveDB)
    Me.PanelToolBar.Controls.Add(Me.ButtonLoadDB)
    Me.PanelToolBar.Controls.Add(Me.BtnSaveWork)
    Me.PanelToolBar.Controls.Add(Me.BtnOpenWork)
    Me.PanelToolBar.Controls.Add(Me.BtnPrint)
    Me.PanelToolBar.Controls.Add(Me.BtnLogout)
    Me.PanelToolBar.Controls.Add(Me.Label3)
    Me.PanelToolBar.Controls.Add(Me.Label2)
    Me.PanelToolBar.Controls.Add(Me.Label4)
    Me.PanelToolBar.Controls.Add(Me.Label1)
    Me.PanelToolBar.Controls.Add(Me.LblRecordVer)
    Me.PanelToolBar.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelToolBar.Location = New System.Drawing.Point(0, 24)
    Me.PanelToolBar.Name = "PanelToolBar"
    Me.PanelToolBar.Size = New System.Drawing.Size(1016, 40)
    Me.PanelToolBar.TabIndex = 9
    '
    'BtnViewDB
    '
    Me.BtnViewDB.BackColor = System.Drawing.Color.Transparent
    Me.BtnViewDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnViewDB.Image = Global.GPRS.My.Resources.Resources._24LieBiao
    Me.BtnViewDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnViewDB.Location = New System.Drawing.Point(386, 4)
    Me.BtnViewDB.Name = "BtnViewDB"
    Me.BtnViewDB.Size = New System.Drawing.Size(92, 29)
    Me.BtnViewDB.TabIndex = 39
    Me.BtnViewDB.Text = "�鿴����"
    Me.BtnViewDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnViewDB.UseVisualStyleBackColor = False
    '
    'BtnPrintLS
    '
    Me.BtnPrintLS.BackColor = System.Drawing.Color.Transparent
    Me.BtnPrintLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPrintLS.Image = CType(resources.GetObject("BtnPrintLS.Image"), System.Drawing.Image)
    Me.BtnPrintLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnPrintLS.Location = New System.Drawing.Point(586, 4)
    Me.BtnPrintLS.Name = "BtnPrintLS"
    Me.BtnPrintLS.Size = New System.Drawing.Size(92, 29)
    Me.BtnPrintLS.TabIndex = 34
    Me.BtnPrintLS.Text = "��ˮ��ӡ"
    Me.BtnPrintLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnPrintLS.UseVisualStyleBackColor = False
    '
    'Label19
    '
    Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label19.Location = New System.Drawing.Point(484, 2)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(4, 36)
    Me.Label19.TabIndex = 33
    '
    'Label18
    '
    Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label18.Location = New System.Drawing.Point(192, 0)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(4, 36)
    Me.Label18.TabIndex = 32
    '
    'ButtonSaveDB
    '
    Me.ButtonSaveDB.BackColor = System.Drawing.Color.Transparent
    Me.ButtonSaveDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.ButtonSaveDB.Image = CType(resources.GetObject("ButtonSaveDB.Image"), System.Drawing.Image)
    Me.ButtonSaveDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.ButtonSaveDB.Location = New System.Drawing.Point(200, 4)
    Me.ButtonSaveDB.Name = "ButtonSaveDB"
    Me.ButtonSaveDB.Size = New System.Drawing.Size(88, 29)
    Me.ButtonSaveDB.TabIndex = 31
    Me.ButtonSaveDB.Text = "��������"
    Me.ButtonSaveDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ButtonSaveDB.UseVisualStyleBackColor = False
    '
    'ButtonLoadDB
    '
    Me.ButtonLoadDB.BackColor = System.Drawing.Color.Transparent
    Me.ButtonLoadDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.ButtonLoadDB.Image = CType(resources.GetObject("ButtonLoadDB.Image"), System.Drawing.Image)
    Me.ButtonLoadDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.ButtonLoadDB.Location = New System.Drawing.Point(293, 4)
    Me.ButtonLoadDB.Name = "ButtonLoadDB"
    Me.ButtonLoadDB.Size = New System.Drawing.Size(88, 29)
    Me.ButtonLoadDB.TabIndex = 30
    Me.ButtonLoadDB.Text = "��ѯ����"
    Me.ButtonLoadDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ButtonLoadDB.UseVisualStyleBackColor = False
    '
    'BtnSaveWork
    '
    Me.BtnSaveWork.BackColor = System.Drawing.Color.Transparent
    Me.BtnSaveWork.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSaveWork.Image = CType(resources.GetObject("BtnSaveWork.Image"), System.Drawing.Image)
    Me.BtnSaveWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnSaveWork.Location = New System.Drawing.Point(96, 4)
    Me.BtnSaveWork.Name = "BtnSaveWork"
    Me.BtnSaveWork.Size = New System.Drawing.Size(88, 29)
    Me.BtnSaveWork.TabIndex = 29
    Me.BtnSaveWork.Text = "���湤��"
    Me.BtnSaveWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnSaveWork.UseVisualStyleBackColor = False
    '
    'BtnOpenWork
    '
    Me.BtnOpenWork.BackColor = System.Drawing.Color.Transparent
    Me.BtnOpenWork.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnOpenWork.Image = CType(resources.GetObject("BtnOpenWork.Image"), System.Drawing.Image)
    Me.BtnOpenWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnOpenWork.Location = New System.Drawing.Point(4, 4)
    Me.BtnOpenWork.Name = "BtnOpenWork"
    Me.BtnOpenWork.Size = New System.Drawing.Size(88, 29)
    Me.BtnOpenWork.TabIndex = 28
    Me.BtnOpenWork.Text = "�򿪹���"
    Me.BtnOpenWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnOpenWork.UseVisualStyleBackColor = False
    '
    'BtnPrint
    '
    Me.BtnPrint.BackColor = System.Drawing.Color.Transparent
    Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
    Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnPrint.Location = New System.Drawing.Point(490, 4)
    Me.BtnPrint.Name = "BtnPrint"
    Me.BtnPrint.Size = New System.Drawing.Size(92, 29)
    Me.BtnPrint.TabIndex = 24
    Me.BtnPrint.Text = "��ϸ��ӡ"
    Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnPrint.UseVisualStyleBackColor = False
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Location = New System.Drawing.Point(628, 2)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(83, 23)
    Me.Label3.TabIndex = 14
    Me.Label3.Text = "Label3"
    Me.Label3.Visible = False
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(628, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(132, 23)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "Label2"
    Me.Label2.Visible = False
    '
    'Label4
    '
    Me.Label4.Location = New System.Drawing.Point(778, 8)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(72, 17)
    Me.Label4.TabIndex = 27
    Me.Label4.Text = "ѡ���ͼ��"
    Me.Label4.Visible = False
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(784, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(56, 20)
    Me.Label1.TabIndex = 25
    Me.Label1.Text = "Label1"
    Me.Label1.Visible = False
    '
    'LblRecordVer
    '
    Me.LblRecordVer.Location = New System.Drawing.Point(915, 4)
    Me.LblRecordVer.Name = "LblRecordVer"
    Me.LblRecordVer.Size = New System.Drawing.Size(57, 30)
    Me.LblRecordVer.TabIndex = 38
    '
    'ComboBoxSelectMap0
    '
    Me.ComboBoxSelectMap0.BackColor = System.Drawing.Color.LightGoldenrodYellow
    Me.ComboBoxSelectMap0.Location = New System.Drawing.Point(27, 3)
    Me.ComboBoxSelectMap0.Name = "ComboBoxSelectMap0"
    Me.ComboBoxSelectMap0.Size = New System.Drawing.Size(92, 20)
    Me.ComboBoxSelectMap0.TabIndex = 26
    '
    'TabControl1
    '
    Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControl1.Controls.Add(Me.TabShowMap)
    Me.TabControl1.Controls.Add(Me.TabShowStation)
    Me.TabControl1.Controls.Add(Me.TabShowComm)
    Me.TabControl1.ImageList = Me.ImageListTab
    Me.TabControl1.Location = New System.Drawing.Point(0, 65)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1020, 611)
    Me.TabControl1.TabIndex = 10
    '
    'TabShowMap
    '
    Me.TabShowMap.BackColor = System.Drawing.SystemColors.Control
    Me.TabShowMap.Controls.Add(Me.AxAniGIFRedDotHandel)
    Me.TabShowMap.Controls.Add(Me.PanelPicBoxMap)
    Me.TabShowMap.Controls.Add(Me.PanelEaglEye)
    Me.TabShowMap.Controls.Add(Me.AxShockwaveFlashMainForm)
    Me.TabShowMap.Controls.Add(Me.PanelTmp)
    Me.TabShowMap.ImageIndex = 0
    Me.TabShowMap.Location = New System.Drawing.Point(4, 23)
    Me.TabShowMap.Name = "TabShowMap"
    Me.TabShowMap.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.TabShowMap.Size = New System.Drawing.Size(1012, 584)
    Me.TabShowMap.TabIndex = 0
    Me.TabShowMap.Text = "��ͼ"
    '
    'AxAniGIFRedDotHandel
    '
    Me.AxAniGIFRedDotHandel.Enabled = True
    Me.AxAniGIFRedDotHandel.Location = New System.Drawing.Point(828, 484)
    Me.AxAniGIFRedDotHandel.Name = "AxAniGIFRedDotHandel"
    Me.AxAniGIFRedDotHandel.OcxState = CType(resources.GetObject("AxAniGIFRedDotHandel.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AxAniGIFRedDotHandel.Size = New System.Drawing.Size(62, 46)
    Me.AxAniGIFRedDotHandel.TabIndex = 14
    Me.AxAniGIFRedDotHandel.Tag = "AxAniGIFRedDotHandel"
    Me.AxAniGIFRedDotHandel.Visible = False
    '
    'PanelPicBoxMap
    '
    Me.PanelPicBoxMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelPicBoxMap.BackColor = System.Drawing.SystemColors.Control
    Me.PanelPicBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PanelPicBoxMap.Controls.Add(Me.BtnLieBiao)
    Me.PanelPicBoxMap.Controls.Add(Me.BtnNextMap)
    Me.PanelPicBoxMap.Controls.Add(Me.ButtonPerMap)
    Me.PanelPicBoxMap.Controls.Add(Me.BtnFDHY)
    Me.PanelPicBoxMap.Controls.Add(Me.BtnFDSX)
    Me.PanelPicBoxMap.Controls.Add(Me.BtnFDFD)
    Me.PanelPicBoxMap.Controls.Add(Me.BtnPlaceStation)
    Me.PanelPicBoxMap.Controls.Add(Me.ComboBoxSelectMap0)
    Me.PanelPicBoxMap.Controls.Add(Me.PanelPicBoxMapMove)
    Me.PanelPicBoxMap.Controls.Add(Me.PanelPassword)
    Me.PanelPicBoxMap.Location = New System.Drawing.Point(0, 0)
    Me.PanelPicBoxMap.Name = "PanelPicBoxMap"
    Me.PanelPicBoxMap.Size = New System.Drawing.Size(802, 584)
    Me.PanelPicBoxMap.TabIndex = 1
    '
    'PanelPicBoxMapMove
    '
    Me.PanelPicBoxMapMove.Controls.Add(Me.AniGIFStation)
    Me.PanelPicBoxMapMove.Controls.Add(Me.PicBoxMap)
    Me.PanelPicBoxMapMove.Location = New System.Drawing.Point(17, 92)
    Me.PanelPicBoxMapMove.Name = "PanelPicBoxMapMove"
    Me.PanelPicBoxMapMove.Size = New System.Drawing.Size(240, 191)
    Me.PanelPicBoxMapMove.TabIndex = 2
    '
    'AniGIFStation
    '
    Me.AniGIFStation.Enabled = True
    Me.AniGIFStation.Location = New System.Drawing.Point(75, 59)
    Me.AniGIFStation.Name = "AniGIFStation"
    Me.AniGIFStation.OcxState = CType(resources.GetObject("AniGIFStation.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AniGIFStation.Size = New System.Drawing.Size(192, 192)
    Me.AniGIFStation.TabIndex = 1
    '
    'PicBoxMap
    '
    Me.PicBoxMap.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PicBoxMap.Location = New System.Drawing.Point(0, 0)
    Me.PicBoxMap.Name = "PicBoxMap"
    Me.PicBoxMap.Size = New System.Drawing.Size(240, 191)
    Me.PicBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PicBoxMap.TabIndex = 0
    Me.PicBoxMap.TabStop = False
    '
    'PanelPassword
    '
    Me.PanelPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.PanelPassword.Controls.Add(Me.BtnOut)
    Me.PanelPassword.Controls.Add(Me.BtnIn)
    Me.PanelPassword.Controls.Add(Me.CheckBoxPassword)
    Me.PanelPassword.Controls.Add(Me.ComboBoxPersonName)
    Me.PanelPassword.Controls.Add(Me.TextBoxPassword)
    Me.PanelPassword.Controls.Add(Me.Label6)
    Me.PanelPassword.Controls.Add(Me.Label5)
    Me.PanelPassword.Location = New System.Drawing.Point(311, 62)
    Me.PanelPassword.Name = "PanelPassword"
    Me.PanelPassword.Size = New System.Drawing.Size(1016, 611)
    Me.PanelPassword.TabIndex = 18
    '
    'BtnOut
    '
    Me.BtnOut.BackColor = System.Drawing.Color.Transparent
    Me.BtnOut.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnOut.Font = New System.Drawing.Font("�����п�", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnOut.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnOut.Image = CType(resources.GetObject("BtnOut.Image"), System.Drawing.Image)
    Me.BtnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnOut.Location = New System.Drawing.Point(166, 157)
    Me.BtnOut.Name = "BtnOut"
    Me.BtnOut.Size = New System.Drawing.Size(86, 33)
    Me.BtnOut.TabIndex = 7
    Me.BtnOut.Tag = "BtnPassword1"
    Me.BtnOut.Text = "�˳�"
    Me.BtnOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnOut.UseVisualStyleBackColor = False
    '
    'BtnIn
    '
    Me.BtnIn.BackColor = System.Drawing.Color.Transparent
    Me.BtnIn.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnIn.Font = New System.Drawing.Font("�����п�", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnIn.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnIn.Image = CType(resources.GetObject("BtnIn.Image"), System.Drawing.Image)
    Me.BtnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnIn.Location = New System.Drawing.Point(24, 157)
    Me.BtnIn.Name = "BtnIn"
    Me.BtnIn.Size = New System.Drawing.Size(86, 33)
    Me.BtnIn.TabIndex = 6
    Me.BtnIn.Tag = "BtnPassword0"
    Me.BtnIn.Text = "��½"
    Me.BtnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnIn.UseVisualStyleBackColor = False
    '
    'CheckBoxPassword
    '
    Me.CheckBoxPassword.BackColor = System.Drawing.Color.Transparent
    Me.CheckBoxPassword.Checked = True
    Me.CheckBoxPassword.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBoxPassword.Font = New System.Drawing.Font("��Բ", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.CheckBoxPassword.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.CheckBoxPassword.Location = New System.Drawing.Point(24, 133)
    Me.CheckBoxPassword.Name = "CheckBoxPassword"
    Me.CheckBoxPassword.Size = New System.Drawing.Size(108, 21)
    Me.CheckBoxPassword.TabIndex = 9
    Me.CheckBoxPassword.Text = "��ס����"
    Me.CheckBoxPassword.UseVisualStyleBackColor = False
    '
    'ComboBoxPersonName
    '
    Me.ComboBoxPersonName.BackColor = System.Drawing.Color.LightGoldenrodYellow
    Me.ComboBoxPersonName.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.ComboBoxPersonName.ForeColor = System.Drawing.Color.Black
    Me.ComboBoxPersonName.Items.AddRange(New Object() {"Administrator", "Guest"})
    Me.ComboBoxPersonName.Location = New System.Drawing.Point(24, 46)
    Me.ComboBoxPersonName.Name = "ComboBoxPersonName"
    Me.ComboBoxPersonName.Size = New System.Drawing.Size(228, 20)
    Me.ComboBoxPersonName.TabIndex = 8
    '
    'TextBoxPassword
    '
    Me.TextBoxPassword.BackColor = System.Drawing.Color.LightGoldenrodYellow
    Me.TextBoxPassword.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.TextBoxPassword.ForeColor = System.Drawing.Color.Black
    Me.TextBoxPassword.Location = New System.Drawing.Point(24, 106)
    Me.TextBoxPassword.Name = "TextBoxPassword"
    Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
    Me.TextBoxPassword.Size = New System.Drawing.Size(228, 21)
    Me.TextBoxPassword.TabIndex = 3
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Font = New System.Drawing.Font("�����п�", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.Label6.Location = New System.Drawing.Point(24, 81)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(123, 19)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "���������룺"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.Font = New System.Drawing.Font("�����п�", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    Me.Label5.Location = New System.Drawing.Point(24, 21)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(142, 19)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "�������û�����"
    '
    'PanelEaglEye
    '
    Me.PanelEaglEye.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelEaglEye.BackColor = System.Drawing.SystemColors.Control
    Me.PanelEaglEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PanelEaglEye.Controls.Add(Me.PanelPicBoxEaglEye)
    Me.PanelEaglEye.Location = New System.Drawing.Point(803, 0)
    Me.PanelEaglEye.Name = "PanelEaglEye"
    Me.PanelEaglEye.Size = New System.Drawing.Size(208, 156)
    Me.PanelEaglEye.TabIndex = 11
    '
    'PanelPicBoxEaglEye
    '
    Me.PanelPicBoxEaglEye.Controls.Add(Me.PicBoxEaglEye)
    Me.PanelPicBoxEaglEye.Location = New System.Drawing.Point(58, 29)
    Me.PanelPicBoxEaglEye.Name = "PanelPicBoxEaglEye"
    Me.PanelPicBoxEaglEye.Size = New System.Drawing.Size(119, 88)
    Me.PanelPicBoxEaglEye.TabIndex = 1
    '
    'PicBoxEaglEye
    '
    Me.PicBoxEaglEye.Cursor = System.Windows.Forms.Cursors.Default
    Me.PicBoxEaglEye.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PicBoxEaglEye.Location = New System.Drawing.Point(0, 0)
    Me.PicBoxEaglEye.Name = "PicBoxEaglEye"
    Me.PicBoxEaglEye.Size = New System.Drawing.Size(119, 88)
    Me.PicBoxEaglEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PicBoxEaglEye.TabIndex = 0
    Me.PicBoxEaglEye.TabStop = False
    '
    'AxShockwaveFlashMainForm
    '
    Me.AxShockwaveFlashMainForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.AxShockwaveFlashMainForm.Enabled = True
    Me.AxShockwaveFlashMainForm.Location = New System.Drawing.Point(832, 184)
    Me.AxShockwaveFlashMainForm.Name = "AxShockwaveFlashMainForm"
    Me.AxShockwaveFlashMainForm.OcxState = CType(resources.GetObject("AxShockwaveFlashMainForm.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AxShockwaveFlashMainForm.Size = New System.Drawing.Size(270, 234)
    Me.AxShockwaveFlashMainForm.TabIndex = 12
    Me.AxShockwaveFlashMainForm.Visible = False
    '
    'PanelTmp
    '
    Me.PanelTmp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelTmp.Location = New System.Drawing.Point(862, 378)
    Me.PanelTmp.Name = "PanelTmp"
    Me.PanelTmp.Size = New System.Drawing.Size(96, 154)
    Me.PanelTmp.TabIndex = 13
    '
    'TabShowStation
    '
    Me.TabShowStation.Controls.Add(Me.GroupBoxAboutStation)
    Me.TabShowStation.Controls.Add(Me.GroupBox1)
    Me.TabShowStation.Controls.Add(Me.PanelStation)
    Me.TabShowStation.ImageIndex = 1
    Me.TabShowStation.Location = New System.Drawing.Point(4, 23)
    Me.TabShowStation.Name = "TabShowStation"
    Me.TabShowStation.Size = New System.Drawing.Size(1012, 584)
    Me.TabShowStation.TabIndex = 2
    Me.TabShowStation.Text = "վ��"
    '
    'GroupBoxAboutStation
    '
    Me.GroupBoxAboutStation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBoxAboutStation.Controls.Add(Me.GroupBox2)
    Me.GroupBoxAboutStation.Controls.Add(Me.TabStationInfo)
    Me.GroupBoxAboutStation.Location = New System.Drawing.Point(808, 77)
    Me.GroupBoxAboutStation.Name = "GroupBoxAboutStation"
    Me.GroupBoxAboutStation.Size = New System.Drawing.Size(197, 431)
    Me.GroupBoxAboutStation.TabIndex = 7
    Me.GroupBoxAboutStation.TabStop = False
    Me.GroupBoxAboutStation.Text = "����վ�㣺"
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.BtnSelctNextStation)
    Me.GroupBox2.Controls.Add(Me.BtnSelctPerStation)
    Me.GroupBox2.Controls.Add(Me.ComboBoxSelectStation)
    Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(188, 74)
    Me.GroupBox2.TabIndex = 7
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "��ѡ��վ�㣺"
    '
    'ComboBoxSelectStation
    '
    Me.ComboBoxSelectStation.Location = New System.Drawing.Point(15, 20)
    Me.ComboBoxSelectStation.Name = "ComboBoxSelectStation"
    Me.ComboBoxSelectStation.Size = New System.Drawing.Size(162, 20)
    Me.ComboBoxSelectStation.TabIndex = 2
    '
    'TabStationInfo
    '
    Me.TabStationInfo.Controls.Add(Me.TabStationIDIPName)
    Me.TabStationInfo.Controls.Add(Me.TabStationParameter)
    Me.TabStationInfo.Location = New System.Drawing.Point(10, 96)
    Me.TabStationInfo.Name = "TabStationInfo"
    Me.TabStationInfo.SelectedIndex = 0
    Me.TabStationInfo.Size = New System.Drawing.Size(179, 329)
    Me.TabStationInfo.TabIndex = 2
    '
    'TabStationIDIPName
    '
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationModemID)
    Me.TabStationIDIPName.Controls.Add(Me.Label23)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationAddress)
    Me.TabStationIDIPName.Controls.Add(Me.Label17)
    Me.TabStationIDIPName.Controls.Add(Me.BtnDelStation)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationNo)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationName)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationIP)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationID)
    Me.TabStationIDIPName.Controls.Add(Me.BtnStationQuXiao)
    Me.TabStationIDIPName.Controls.Add(Me.BtnStationYingYong)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationParameterAmount)
    Me.TabStationIDIPName.Controls.Add(Me.Label12)
    Me.TabStationIDIPName.Controls.Add(Me.TextBoxStationModeIndex)
    Me.TabStationIDIPName.Controls.Add(Me.Label11)
    Me.TabStationIDIPName.Controls.Add(Me.CheckBoxStationActive)
    Me.TabStationIDIPName.Controls.Add(Me.Label10)
    Me.TabStationIDIPName.Controls.Add(Me.Label9)
    Me.TabStationIDIPName.Controls.Add(Me.Label8)
    Me.TabStationIDIPName.Controls.Add(Me.Label7)
    Me.TabStationIDIPName.Location = New System.Drawing.Point(4, 21)
    Me.TabStationIDIPName.Name = "TabStationIDIPName"
    Me.TabStationIDIPName.Size = New System.Drawing.Size(171, 304)
    Me.TabStationIDIPName.TabIndex = 0
    Me.TabStationIDIPName.Text = "������Ϣ"
    '
    'TextBoxStationModemID
    '
    Me.TextBoxStationModemID.Location = New System.Drawing.Point(75, 189)
    Me.TextBoxStationModemID.Name = "TextBoxStationModemID"
    Me.TextBoxStationModemID.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxStationModemID.TabIndex = 18
    '
    'Label23
    '
    Me.Label23.BackColor = System.Drawing.Color.Transparent
    Me.Label23.Location = New System.Drawing.Point(8, 190)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(79, 15)
    Me.Label23.TabIndex = 19
    Me.Label23.Text = "ModemID  ��"
    '
    'TextBoxStationAddress
    '
    Me.TextBoxStationAddress.Location = New System.Drawing.Point(55, 126)
    Me.TextBoxStationAddress.Name = "TextBoxStationAddress"
    Me.TextBoxStationAddress.Size = New System.Drawing.Size(111, 21)
    Me.TextBoxStationAddress.TabIndex = 17
    '
    'Label17
    '
    Me.Label17.Location = New System.Drawing.Point(13, 130)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(68, 14)
    Me.Label17.TabIndex = 16
    Me.Label17.Text = "��ַ ��"
    '
    'TextBoxStationNo
    '
    Me.TextBoxStationNo.Enabled = False
    Me.TextBoxStationNo.Location = New System.Drawing.Point(55, 13)
    Me.TextBoxStationNo.Name = "TextBoxStationNo"
    Me.TextBoxStationNo.Size = New System.Drawing.Size(111, 21)
    Me.TextBoxStationNo.TabIndex = 10
    '
    'TextBoxStationName
    '
    Me.TextBoxStationName.Location = New System.Drawing.Point(55, 98)
    Me.TextBoxStationName.Name = "TextBoxStationName"
    Me.TextBoxStationName.Size = New System.Drawing.Size(111, 21)
    Me.TextBoxStationName.TabIndex = 6
    '
    'TextBoxStationIP
    '
    Me.TextBoxStationIP.Location = New System.Drawing.Point(55, 71)
    Me.TextBoxStationIP.Name = "TextBoxStationIP"
    Me.TextBoxStationIP.Size = New System.Drawing.Size(111, 21)
    Me.TextBoxStationIP.TabIndex = 4
    '
    'TextBoxStationID
    '
    Me.TextBoxStationID.Location = New System.Drawing.Point(55, 42)
    Me.TextBoxStationID.Name = "TextBoxStationID"
    Me.TextBoxStationID.Size = New System.Drawing.Size(111, 21)
    Me.TextBoxStationID.TabIndex = 2
    '
    'TextBoxStationParameterAmount
    '
    Me.TextBoxStationParameterAmount.Location = New System.Drawing.Point(75, 246)
    Me.TextBoxStationParameterAmount.Name = "TextBoxStationParameterAmount"
    Me.TextBoxStationParameterAmount.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxStationParameterAmount.TabIndex = 13
    '
    'Label12
    '
    Me.Label12.BackColor = System.Drawing.Color.Transparent
    Me.Label12.Location = New System.Drawing.Point(8, 246)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(72, 15)
    Me.Label12.TabIndex = 14
    Me.Label12.Text = "�������� ��"
    '
    'TextBoxStationModeIndex
    '
    Me.TextBoxStationModeIndex.Location = New System.Drawing.Point(75, 217)
    Me.TextBoxStationModeIndex.Name = "TextBoxStationModeIndex"
    Me.TextBoxStationModeIndex.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxStationModeIndex.TabIndex = 11
    '
    'Label11
    '
    Me.Label11.BackColor = System.Drawing.Color.Transparent
    Me.Label11.Location = New System.Drawing.Point(8, 218)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(79, 15)
    Me.Label11.TabIndex = 12
    Me.Label11.Text = "ModeIndex��"
    '
    'CheckBoxStationActive
    '
    Me.CheckBoxStationActive.BackColor = System.Drawing.Color.Transparent
    Me.CheckBoxStationActive.Location = New System.Drawing.Point(12, 160)
    Me.CheckBoxStationActive.Name = "CheckBoxStationActive"
    Me.CheckBoxStationActive.Size = New System.Drawing.Size(90, 19)
    Me.CheckBoxStationActive.TabIndex = 8
    Me.CheckBoxStationActive.Text = "����վ��"
    Me.CheckBoxStationActive.UseVisualStyleBackColor = False
    '
    'Label10
    '
    Me.Label10.BackColor = System.Drawing.Color.Transparent
    Me.Label10.Location = New System.Drawing.Point(13, 16)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(79, 17)
    Me.Label10.TabIndex = 9
    Me.Label10.Text = "Index��"
    '
    'Label9
    '
    Me.Label9.BackColor = System.Drawing.Color.Transparent
    Me.Label9.Location = New System.Drawing.Point(13, 103)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(50, 15)
    Me.Label9.TabIndex = 7
    Me.Label9.Text = "Name ��"
    '
    'Label8
    '
    Me.Label8.BackColor = System.Drawing.Color.Transparent
    Me.Label8.Location = New System.Drawing.Point(13, 76)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(50, 15)
    Me.Label8.TabIndex = 5
    Me.Label8.Text = "IP   ��"
    '
    'Label7
    '
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Location = New System.Drawing.Point(13, 46)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(50, 15)
    Me.Label7.TabIndex = 3
    Me.Label7.Text = "վID ��"
    '
    'TabStationParameter
    '
    Me.TabStationParameter.Controls.Add(Me.LabelSelectNo)
    Me.TabStationParameter.Controls.Add(Me.TextBoxParameter1)
    Me.TabStationParameter.Controls.Add(Me.TextBoxParameter0)
    Me.TabStationParameter.Controls.Add(Me.CheckBoxTabStationParameter)
    Me.TabStationParameter.Controls.Add(Me.ListBoxTabStationParameter)
    Me.TabStationParameter.Controls.Add(Me.TextBoxParameter3)
    Me.TabStationParameter.Controls.Add(Me.BtnStationParameterYingYong)
    Me.TabStationParameter.Controls.Add(Me.BtnStationParameterQuXiao)
    Me.TabStationParameter.Controls.Add(Me.TextBoxParameter2)
    Me.TabStationParameter.Controls.Add(Me.Label15)
    Me.TabStationParameter.Controls.Add(Me.Label16)
    Me.TabStationParameter.Controls.Add(Me.Label14)
    Me.TabStationParameter.Controls.Add(Me.Label13)
    Me.TabStationParameter.Location = New System.Drawing.Point(4, 21)
    Me.TabStationParameter.Name = "TabStationParameter"
    Me.TabStationParameter.Size = New System.Drawing.Size(171, 304)
    Me.TabStationParameter.TabIndex = 1
    Me.TabStationParameter.Text = "������Ϣ"
    Me.TabStationParameter.Visible = False
    '
    'LabelSelectNo
    '
    Me.LabelSelectNo.Location = New System.Drawing.Point(8, 3)
    Me.LabelSelectNo.Name = "LabelSelectNo"
    Me.LabelSelectNo.Size = New System.Drawing.Size(151, 15)
    Me.LabelSelectNo.TabIndex = 28
    '
    'TextBoxParameter1
    '
    Me.TextBoxParameter1.Location = New System.Drawing.Point(74, 167)
    Me.TextBoxParameter1.Name = "TextBoxParameter1"
    Me.TextBoxParameter1.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxParameter1.TabIndex = 17
    Me.TextBoxParameter1.Tag = "TextBoxParameter1"
    '
    'TextBoxParameter0
    '
    Me.TextBoxParameter0.Location = New System.Drawing.Point(74, 139)
    Me.TextBoxParameter0.Name = "TextBoxParameter0"
    Me.TextBoxParameter0.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxParameter0.TabIndex = 15
    Me.TextBoxParameter0.Tag = "TextBoxParameter0"
    '
    'CheckBoxTabStationParameter
    '
    Me.CheckBoxTabStationParameter.BackColor = System.Drawing.Color.Transparent
    Me.CheckBoxTabStationParameter.Location = New System.Drawing.Point(7, 250)
    Me.CheckBoxTabStationParameter.Name = "CheckBoxTabStationParameter"
    Me.CheckBoxTabStationParameter.Size = New System.Drawing.Size(112, 18)
    Me.CheckBoxTabStationParameter.TabIndex = 27
    Me.CheckBoxTabStationParameter.Text = "Ӧ�õ�����վ��"
    Me.CheckBoxTabStationParameter.UseVisualStyleBackColor = False
    '
    'ListBoxTabStationParameter
    '
    Me.ListBoxTabStationParameter.ItemHeight = 12
    Me.ListBoxTabStationParameter.Location = New System.Drawing.Point(7, 19)
    Me.ListBoxTabStationParameter.Name = "ListBoxTabStationParameter"
    Me.ListBoxTabStationParameter.Size = New System.Drawing.Size(158, 112)
    Me.ListBoxTabStationParameter.TabIndex = 26
    '
    'TextBoxParameter3
    '
    Me.TextBoxParameter3.Location = New System.Drawing.Point(74, 223)
    Me.TextBoxParameter3.Name = "TextBoxParameter3"
    Me.TextBoxParameter3.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxParameter3.TabIndex = 21
    Me.TextBoxParameter3.Tag = "TextBoxParameter3"
    '
    'TextBoxParameter2
    '
    Me.TextBoxParameter2.Location = New System.Drawing.Point(74, 195)
    Me.TextBoxParameter2.Name = "TextBoxParameter2"
    Me.TextBoxParameter2.Size = New System.Drawing.Size(91, 21)
    Me.TextBoxParameter2.TabIndex = 19
    Me.TextBoxParameter2.Tag = "TextBoxParameter2"
    '
    'Label15
    '
    Me.Label15.BackColor = System.Drawing.Color.Transparent
    Me.Label15.Location = New System.Drawing.Point(7, 195)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(72, 15)
    Me.Label15.TabIndex = 20
    Me.Label15.Text = "������λ ��"
    '
    'Label16
    '
    Me.Label16.BackColor = System.Drawing.Color.Transparent
    Me.Label16.Location = New System.Drawing.Point(7, 223)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(72, 15)
    Me.Label16.TabIndex = 22
    Me.Label16.Text = "�������� ��"
    '
    'Label14
    '
    Me.Label14.BackColor = System.Drawing.Color.Transparent
    Me.Label14.Location = New System.Drawing.Point(7, 167)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(72, 15)
    Me.Label14.TabIndex = 18
    Me.Label14.Text = "������ֵ ��"
    '
    'Label13
    '
    Me.Label13.BackColor = System.Drawing.Color.Transparent
    Me.Label13.Location = New System.Drawing.Point(7, 139)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(72, 15)
    Me.Label13.TabIndex = 16
    Me.Label13.Text = "�������� ��"
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.ComboBoxSelectMap1)
    Me.GroupBox1.Location = New System.Drawing.Point(808, 7)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(197, 63)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "��ѡ���ͼ��"
    '
    'ComboBoxSelectMap1
    '
    Me.ComboBoxSelectMap1.Location = New System.Drawing.Point(15, 26)
    Me.ComboBoxSelectMap1.Name = "ComboBoxSelectMap1"
    Me.ComboBoxSelectMap1.Size = New System.Drawing.Size(168, 20)
    Me.ComboBoxSelectMap1.TabIndex = 2
    '
    'PanelStation
    '
    Me.PanelStation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelStation.Controls.Add(Me.PanelSendMessage)
    Me.PanelStation.Controls.Add(Me.btnShowSendMessage)
    Me.PanelStation.Controls.Add(Me.CS10)
    Me.PanelStation.Controls.Add(Me.CS9)
    Me.PanelStation.Controls.Add(Me.CS8)
    Me.PanelStation.Controls.Add(Me.CS7)
    Me.PanelStation.Controls.Add(Me.CS6)
    Me.PanelStation.Controls.Add(Me.CS3)
    Me.PanelStation.Controls.Add(Me.CS5)
    Me.PanelStation.Controls.Add(Me.CS2)
    Me.PanelStation.Controls.Add(Me.CS4)
    Me.PanelStation.Controls.Add(Me.CS1)
    Me.PanelStation.Controls.Add(Me.BtnShowStationSend)
    Me.PanelStation.Controls.Add(Me.LabelStationAddress)
    Me.PanelStation.Controls.Add(Me.BtnCS21)
    Me.PanelStation.Controls.Add(Me.BtnCS22)
    Me.PanelStation.Controls.Add(Me.PicboxStation)
    Me.PanelStation.Location = New System.Drawing.Point(0, 0)
    Me.PanelStation.Name = "PanelStation"
    Me.PanelStation.Size = New System.Drawing.Size(802, 584)
    Me.PanelStation.TabIndex = 0
    Me.PanelStation.Visible = False
    '
    'PanelSendMessage
    '
    Me.PanelSendMessage.BackColor = System.Drawing.Color.Gold
    Me.PanelSendMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.PanelSendMessage.Controls.Add(Me.Panel2)
    Me.PanelSendMessage.Controls.Add(Me.btnSendMessageSend)
    Me.PanelSendMessage.Controls.Add(Me.GroupBoxSendMessage)
    Me.PanelSendMessage.Location = New System.Drawing.Point(395, 98)
    Me.PanelSendMessage.Name = "PanelSendMessage"
    Me.PanelSendMessage.Size = New System.Drawing.Size(401, 363)
    Me.PanelSendMessage.TabIndex = 42
    Me.PanelSendMessage.Visible = False
    '
    'Panel2
    '
    Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel2.Controls.Add(Me.LabelSendSSSWaiTimeS)
    Me.Panel2.Controls.Add(Me.LabelSendMessageSendState)
    Me.Panel2.Location = New System.Drawing.Point(17, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(80, 24)
    Me.Panel2.TabIndex = 41
    '
    'LabelSendSSSWaiTimeS
    '
    Me.LabelSendSSSWaiTimeS.Location = New System.Drawing.Point(62, 5)
    Me.LabelSendSSSWaiTimeS.Name = "LabelSendSSSWaiTimeS"
    Me.LabelSendSSSWaiTimeS.Size = New System.Drawing.Size(46, 10)
    Me.LabelSendSSSWaiTimeS.TabIndex = 1
    Me.LabelSendSSSWaiTimeS.Text = "5"
    '
    'LabelSendMessageSendState
    '
    Me.LabelSendMessageSendState.BackColor = System.Drawing.Color.LightGray
    Me.LabelSendMessageSendState.Location = New System.Drawing.Point(2, 2)
    Me.LabelSendMessageSendState.Name = "LabelSendMessageSendState"
    Me.LabelSendMessageSendState.Size = New System.Drawing.Size(54, 18)
    Me.LabelSendMessageSendState.TabIndex = 0
    Me.LabelSendMessageSendState.Text = " �ȴ� "
    Me.LabelSendMessageSendState.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    '
    'btnSendMessageSend
    '
    Me.btnSendMessageSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.btnSendMessageSend.Image = Global.GPRS.My.Resources.Resources._16SendMessage
    Me.btnSendMessageSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSendMessageSend.Location = New System.Drawing.Point(338, 3)
    Me.btnSendMessageSend.Name = "btnSendMessageSend"
    Me.btnSendMessageSend.Size = New System.Drawing.Size(56, 24)
    Me.btnSendMessageSend.TabIndex = 30
    Me.btnSendMessageSend.Text = "����"
    Me.btnSendMessageSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSendMessageSend.UseVisualStyleBackColor = True
    '
    'GroupBoxSendMessage
    '
    Me.GroupBoxSendMessage.BackColor = System.Drawing.Color.Gray
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName10)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName9)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName8)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName7)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName6)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName5)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName4)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName3)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName2)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageName1)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei10)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei9)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei8)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei7)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei6)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei5)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei4)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei3)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei2)
    Me.GroupBoxSendMessage.Controls.Add(Me.lblSendMessageDanWei1)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage10)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage9)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage8)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage7)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage6)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage5)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage4)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage3)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage2)
    Me.GroupBoxSendMessage.Controls.Add(Me.TextBoxSendMessage1)
    Me.GroupBoxSendMessage.Location = New System.Drawing.Point(1, 32)
    Me.GroupBoxSendMessage.Name = "GroupBoxSendMessage"
    Me.GroupBoxSendMessage.Size = New System.Drawing.Size(398, 327)
    Me.GroupBoxSendMessage.TabIndex = 40
    Me.GroupBoxSendMessage.TabStop = False
    Me.GroupBoxSendMessage.Text = "�������ݣ�"
    '
    'lblSendMessageName10
    '
    Me.lblSendMessageName10.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName10.Location = New System.Drawing.Point(10, 291)
    Me.lblSendMessageName10.Name = "lblSendMessageName10"
    Me.lblSendMessageName10.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName10.TabIndex = 29
    Me.lblSendMessageName10.Tag = "SMName10"
    Me.lblSendMessageName10.Text = "Label41"
    Me.lblSendMessageName10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName10.Visible = False
    '
    'lblSendMessageName9
    '
    Me.lblSendMessageName9.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName9.Location = New System.Drawing.Point(10, 262)
    Me.lblSendMessageName9.Name = "lblSendMessageName9"
    Me.lblSendMessageName9.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName9.TabIndex = 28
    Me.lblSendMessageName9.Tag = "SMName9"
    Me.lblSendMessageName9.Text = "Label40"
    Me.lblSendMessageName9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName9.Visible = False
    '
    'lblSendMessageName8
    '
    Me.lblSendMessageName8.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName8.Location = New System.Drawing.Point(10, 233)
    Me.lblSendMessageName8.Name = "lblSendMessageName8"
    Me.lblSendMessageName8.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName8.TabIndex = 27
    Me.lblSendMessageName8.Tag = "SMName8"
    Me.lblSendMessageName8.Text = "Label39"
    Me.lblSendMessageName8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName8.Visible = False
    '
    'lblSendMessageName7
    '
    Me.lblSendMessageName7.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName7.Location = New System.Drawing.Point(10, 204)
    Me.lblSendMessageName7.Name = "lblSendMessageName7"
    Me.lblSendMessageName7.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName7.TabIndex = 26
    Me.lblSendMessageName7.Tag = "SMName7"
    Me.lblSendMessageName7.Text = "Label38"
    Me.lblSendMessageName7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName7.Visible = False
    '
    'lblSendMessageName6
    '
    Me.lblSendMessageName6.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName6.Location = New System.Drawing.Point(10, 175)
    Me.lblSendMessageName6.Name = "lblSendMessageName6"
    Me.lblSendMessageName6.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName6.TabIndex = 25
    Me.lblSendMessageName6.Tag = "SMName6"
    Me.lblSendMessageName6.Text = "Label37"
    Me.lblSendMessageName6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName6.Visible = False
    '
    'lblSendMessageName5
    '
    Me.lblSendMessageName5.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName5.Location = New System.Drawing.Point(10, 146)
    Me.lblSendMessageName5.Name = "lblSendMessageName5"
    Me.lblSendMessageName5.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName5.TabIndex = 24
    Me.lblSendMessageName5.Tag = "SMName5"
    Me.lblSendMessageName5.Text = "Label36"
    Me.lblSendMessageName5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName5.Visible = False
    '
    'lblSendMessageName4
    '
    Me.lblSendMessageName4.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName4.Location = New System.Drawing.Point(10, 117)
    Me.lblSendMessageName4.Name = "lblSendMessageName4"
    Me.lblSendMessageName4.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName4.TabIndex = 23
    Me.lblSendMessageName4.Tag = "SMName4"
    Me.lblSendMessageName4.Text = "Label35"
    Me.lblSendMessageName4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName4.Visible = False
    '
    'lblSendMessageName3
    '
    Me.lblSendMessageName3.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName3.Location = New System.Drawing.Point(10, 88)
    Me.lblSendMessageName3.Name = "lblSendMessageName3"
    Me.lblSendMessageName3.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName3.TabIndex = 22
    Me.lblSendMessageName3.Tag = "SMName3"
    Me.lblSendMessageName3.Text = "Label34"
    Me.lblSendMessageName3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName3.Visible = False
    '
    'lblSendMessageName2
    '
    Me.lblSendMessageName2.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName2.Location = New System.Drawing.Point(10, 59)
    Me.lblSendMessageName2.Name = "lblSendMessageName2"
    Me.lblSendMessageName2.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName2.TabIndex = 21
    Me.lblSendMessageName2.Tag = "SMName2"
    Me.lblSendMessageName2.Text = "Label33"
    Me.lblSendMessageName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName2.Visible = False
    '
    'lblSendMessageName1
    '
    Me.lblSendMessageName1.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageName1.Location = New System.Drawing.Point(10, 30)
    Me.lblSendMessageName1.Name = "lblSendMessageName1"
    Me.lblSendMessageName1.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageName1.TabIndex = 20
    Me.lblSendMessageName1.Tag = "SMName1"
    Me.lblSendMessageName1.Text = "Label32"
    Me.lblSendMessageName1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.lblSendMessageName1.Visible = False
    '
    'lblSendMessageDanWei10
    '
    Me.lblSendMessageDanWei10.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei10.Location = New System.Drawing.Point(272, 295)
    Me.lblSendMessageDanWei10.Name = "lblSendMessageDanWei10"
    Me.lblSendMessageDanWei10.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei10.TabIndex = 19
    Me.lblSendMessageDanWei10.Tag = "SMDanWei9"
    Me.lblSendMessageDanWei10.Text = "Label32"
    Me.lblSendMessageDanWei10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei10.Visible = False
    '
    'lblSendMessageDanWei9
    '
    Me.lblSendMessageDanWei9.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei9.Location = New System.Drawing.Point(272, 266)
    Me.lblSendMessageDanWei9.Name = "lblSendMessageDanWei9"
    Me.lblSendMessageDanWei9.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei9.TabIndex = 18
    Me.lblSendMessageDanWei9.Tag = "SMDanWei9"
    Me.lblSendMessageDanWei9.Text = "Label32"
    Me.lblSendMessageDanWei9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei9.Visible = False
    '
    'lblSendMessageDanWei8
    '
    Me.lblSendMessageDanWei8.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei8.Location = New System.Drawing.Point(272, 237)
    Me.lblSendMessageDanWei8.Name = "lblSendMessageDanWei8"
    Me.lblSendMessageDanWei8.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei8.TabIndex = 17
    Me.lblSendMessageDanWei8.Tag = "SMDanWei8"
    Me.lblSendMessageDanWei8.Text = "Label32"
    Me.lblSendMessageDanWei8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei8.Visible = False
    '
    'lblSendMessageDanWei7
    '
    Me.lblSendMessageDanWei7.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei7.Location = New System.Drawing.Point(272, 208)
    Me.lblSendMessageDanWei7.Name = "lblSendMessageDanWei7"
    Me.lblSendMessageDanWei7.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei7.TabIndex = 16
    Me.lblSendMessageDanWei7.Tag = "SMDanWei7"
    Me.lblSendMessageDanWei7.Text = "Label32"
    Me.lblSendMessageDanWei7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei7.Visible = False
    '
    'lblSendMessageDanWei6
    '
    Me.lblSendMessageDanWei6.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei6.Location = New System.Drawing.Point(272, 179)
    Me.lblSendMessageDanWei6.Name = "lblSendMessageDanWei6"
    Me.lblSendMessageDanWei6.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei6.TabIndex = 15
    Me.lblSendMessageDanWei6.Tag = "SMDanWei6"
    Me.lblSendMessageDanWei6.Text = "Label32"
    Me.lblSendMessageDanWei6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei6.Visible = False
    '
    'lblSendMessageDanWei5
    '
    Me.lblSendMessageDanWei5.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei5.Location = New System.Drawing.Point(272, 150)
    Me.lblSendMessageDanWei5.Name = "lblSendMessageDanWei5"
    Me.lblSendMessageDanWei5.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei5.TabIndex = 14
    Me.lblSendMessageDanWei5.Tag = "SMDanWei5"
    Me.lblSendMessageDanWei5.Text = "Label32"
    Me.lblSendMessageDanWei5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei5.Visible = False
    '
    'lblSendMessageDanWei4
    '
    Me.lblSendMessageDanWei4.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei4.Location = New System.Drawing.Point(272, 121)
    Me.lblSendMessageDanWei4.Name = "lblSendMessageDanWei4"
    Me.lblSendMessageDanWei4.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei4.TabIndex = 13
    Me.lblSendMessageDanWei4.Tag = "SMDanWei4"
    Me.lblSendMessageDanWei4.Text = "Label32"
    Me.lblSendMessageDanWei4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei4.Visible = False
    '
    'lblSendMessageDanWei3
    '
    Me.lblSendMessageDanWei3.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei3.Location = New System.Drawing.Point(272, 92)
    Me.lblSendMessageDanWei3.Name = "lblSendMessageDanWei3"
    Me.lblSendMessageDanWei3.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei3.TabIndex = 12
    Me.lblSendMessageDanWei3.Tag = "SMDanWei3"
    Me.lblSendMessageDanWei3.Text = "Label32"
    Me.lblSendMessageDanWei3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei3.Visible = False
    '
    'lblSendMessageDanWei2
    '
    Me.lblSendMessageDanWei2.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei2.Location = New System.Drawing.Point(272, 65)
    Me.lblSendMessageDanWei2.Name = "lblSendMessageDanWei2"
    Me.lblSendMessageDanWei2.Size = New System.Drawing.Size(47, 12)
    Me.lblSendMessageDanWei2.TabIndex = 11
    Me.lblSendMessageDanWei2.Tag = "SMDanWei2"
    Me.lblSendMessageDanWei2.Text = "Label32"
    Me.lblSendMessageDanWei2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblSendMessageDanWei2.Visible = False
    '
    'lblSendMessageDanWei1
    '
    Me.lblSendMessageDanWei1.ForeColor = System.Drawing.Color.Gold
    Me.lblSendMessageDanWei1.Location = New System.Drawing.Point(272, 32)
    Me.lblSendMessageDanWei1.Name = "lblSendMessageDanWei1"
    Me.lblSendMessageDanWei1.Size = New System.Drawing.Size(130, 16)
    Me.lblSendMessageDanWei1.TabIndex = 10
    Me.lblSendMessageDanWei1.Tag = "SMDanWei1"
    Me.lblSendMessageDanWei1.Text = "��ʽ 08-03-06 08:40"
    Me.lblSendMessageDanWei1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.lblSendMessageDanWei1.Visible = False
    '
    'TextBoxSendMessage10
    '
    Me.TextBoxSendMessage10.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage10.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage10.Location = New System.Drawing.Point(140, 288)
    Me.TextBoxSendMessage10.Name = "TextBoxSendMessage10"
    Me.TextBoxSendMessage10.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage10.TabIndex = 9
    Me.TextBoxSendMessage10.Tag = "SMValue10"
    Me.TextBoxSendMessage10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage10.Visible = False
    '
    'TextBoxSendMessage9
    '
    Me.TextBoxSendMessage9.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage9.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage9.Location = New System.Drawing.Point(140, 259)
    Me.TextBoxSendMessage9.Name = "TextBoxSendMessage9"
    Me.TextBoxSendMessage9.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage9.TabIndex = 8
    Me.TextBoxSendMessage9.Tag = "SMValue9"
    Me.TextBoxSendMessage9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage9.Visible = False
    '
    'TextBoxSendMessage8
    '
    Me.TextBoxSendMessage8.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage8.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage8.Location = New System.Drawing.Point(140, 230)
    Me.TextBoxSendMessage8.Name = "TextBoxSendMessage8"
    Me.TextBoxSendMessage8.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage8.TabIndex = 7
    Me.TextBoxSendMessage8.Tag = "SMValue8"
    Me.TextBoxSendMessage8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage8.Visible = False
    '
    'TextBoxSendMessage7
    '
    Me.TextBoxSendMessage7.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage7.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage7.Location = New System.Drawing.Point(140, 201)
    Me.TextBoxSendMessage7.Name = "TextBoxSendMessage7"
    Me.TextBoxSendMessage7.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage7.TabIndex = 6
    Me.TextBoxSendMessage7.Tag = "SMValue7"
    Me.TextBoxSendMessage7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage7.Visible = False
    '
    'TextBoxSendMessage6
    '
    Me.TextBoxSendMessage6.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage6.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage6.Location = New System.Drawing.Point(140, 172)
    Me.TextBoxSendMessage6.Name = "TextBoxSendMessage6"
    Me.TextBoxSendMessage6.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage6.TabIndex = 5
    Me.TextBoxSendMessage6.Tag = "SMValue6"
    Me.TextBoxSendMessage6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage6.Visible = False
    '
    'TextBoxSendMessage5
    '
    Me.TextBoxSendMessage5.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage5.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage5.Location = New System.Drawing.Point(140, 143)
    Me.TextBoxSendMessage5.Name = "TextBoxSendMessage5"
    Me.TextBoxSendMessage5.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage5.TabIndex = 4
    Me.TextBoxSendMessage5.Tag = "SMValue5"
    Me.TextBoxSendMessage5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage5.Visible = False
    '
    'TextBoxSendMessage4
    '
    Me.TextBoxSendMessage4.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage4.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage4.Location = New System.Drawing.Point(140, 114)
    Me.TextBoxSendMessage4.Name = "TextBoxSendMessage4"
    Me.TextBoxSendMessage4.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage4.TabIndex = 3
    Me.TextBoxSendMessage4.Tag = "SMValue4"
    Me.TextBoxSendMessage4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage4.Visible = False
    '
    'TextBoxSendMessage3
    '
    Me.TextBoxSendMessage3.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage3.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage3.Location = New System.Drawing.Point(140, 85)
    Me.TextBoxSendMessage3.Name = "TextBoxSendMessage3"
    Me.TextBoxSendMessage3.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage3.TabIndex = 2
    Me.TextBoxSendMessage3.Tag = "SMValue3"
    Me.TextBoxSendMessage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage3.Visible = False
    '
    'TextBoxSendMessage2
    '
    Me.TextBoxSendMessage2.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage2.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage2.Location = New System.Drawing.Point(140, 56)
    Me.TextBoxSendMessage2.Name = "TextBoxSendMessage2"
    Me.TextBoxSendMessage2.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage2.TabIndex = 1
    Me.TextBoxSendMessage2.Tag = "SMValue2"
    Me.TextBoxSendMessage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage2.Visible = False
    '
    'TextBoxSendMessage1
    '
    Me.TextBoxSendMessage1.BackColor = System.Drawing.Color.DimGray
    Me.TextBoxSendMessage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxSendMessage1.ForeColor = System.Drawing.Color.DarkTurquoise
    Me.TextBoxSendMessage1.Location = New System.Drawing.Point(140, 27)
    Me.TextBoxSendMessage1.Name = "TextBoxSendMessage1"
    Me.TextBoxSendMessage1.Size = New System.Drawing.Size(130, 23)
    Me.TextBoxSendMessage1.TabIndex = 0
    Me.TextBoxSendMessage1.Tag = "SMValue1"
    Me.TextBoxSendMessage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.TextBoxSendMessage1.Visible = False
    '
    'LabelStationAddress
    '
    Me.LabelStationAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelStationAddress.BackColor = System.Drawing.SystemColors.Info
    Me.LabelStationAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LabelStationAddress.Font = New System.Drawing.Font("����_GB2312", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.LabelStationAddress.Location = New System.Drawing.Point(0, 557)
    Me.LabelStationAddress.Name = "LabelStationAddress"
    Me.LabelStationAddress.Size = New System.Drawing.Size(801, 27)
    Me.LabelStationAddress.TabIndex = 26
    Me.LabelStationAddress.Tag = "StationParameter23"
    Me.LabelStationAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'BtnCS21
    '
    Me.BtnCS21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnCS21.BackColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnCS21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnCS21.Font = New System.Drawing.Font("����", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnCS21.Image = CType(resources.GetObject("BtnCS21.Image"), System.Drawing.Image)
    Me.BtnCS21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnCS21.Location = New System.Drawing.Point(551, 523)
    Me.BtnCS21.Name = "BtnCS21"
    Me.BtnCS21.Size = New System.Drawing.Size(251, 31)
    Me.BtnCS21.TabIndex = 25
    Me.BtnCS21.Tag = "StationParameter21"
    Me.BtnCS21.Text = "XXX��վ"
    Me.BtnCS21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnCS21.UseVisualStyleBackColor = False
    '
    'BtnCS22
    '
    Me.BtnCS22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.BtnCS22.BackColor = System.Drawing.Color.LightGoldenrodYellow
    Me.BtnCS22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnCS22.Font = New System.Drawing.Font("����", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.BtnCS22.Image = CType(resources.GetObject("BtnCS22.Image"), System.Drawing.Image)
    Me.BtnCS22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnCS22.Location = New System.Drawing.Point(0, 523)
    Me.BtnCS22.Name = "BtnCS22"
    Me.BtnCS22.Size = New System.Drawing.Size(251, 31)
    Me.BtnCS22.TabIndex = 24
    Me.BtnCS22.Tag = "StationParameter22"
    Me.BtnCS22.Text = "���ʱ�䣺"
    Me.BtnCS22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.BtnCS22.UseVisualStyleBackColor = False
    '
    'PicboxStation
    '
    Me.PicboxStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PicboxStation.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PicboxStation.Image = Global.GPRS.My.Resources.Resources.Station1
    Me.PicboxStation.Location = New System.Drawing.Point(0, 0)
    Me.PicboxStation.Name = "PicboxStation"
    Me.PicboxStation.Size = New System.Drawing.Size(802, 584)
    Me.PicboxStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PicboxStation.TabIndex = 0
    Me.PicboxStation.TabStop = False
    '
    'TabShowComm
    '
    Me.TabShowComm.Controls.Add(Me.Button1)
    Me.TabShowComm.Controls.Add(Me.GrpMTX)
    Me.TabShowComm.Controls.Add(Me.PanelComm)
    Me.TabShowComm.ImageIndex = 2
    Me.TabShowComm.Location = New System.Drawing.Point(4, 23)
    Me.TabShowComm.Name = "TabShowComm"
    Me.TabShowComm.Size = New System.Drawing.Size(1012, 584)
    Me.TabShowComm.TabIndex = 1
    Me.TabShowComm.Text = "ͨѶ"
    '
    'GrpMTX
    '
    Me.GrpMTX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GrpMTX.Controls.Add(Me.ComboBoxOnLineStationInfo)
    Me.GrpMTX.Controls.Add(Me.DoUDTXDataMode)
    Me.GrpMTX.Controls.Add(Me.BtnCbinFile)
    Me.GrpMTX.Controls.Add(Me.GroupBox3)
    Me.GrpMTX.Controls.Add(Me.Label22)
    Me.GrpMTX.Controls.Add(Me.NumUDID)
    Me.GrpMTX.Controls.Add(Me.RadBtnSin)
    Me.GrpMTX.Controls.Add(Me.RadBtnAll)
    Me.GrpMTX.Controls.Add(Me.BtnSend)
    Me.GrpMTX.Controls.Add(Me.Label20)
    Me.GrpMTX.Controls.Add(Me.RtxtSendData)
    Me.GrpMTX.Controls.Add(Me.GroupBox4)
    Me.GrpMTX.Controls.Add(Me.Label24)
    Me.GrpMTX.Controls.Add(Me.Label27)
    Me.GrpMTX.Location = New System.Drawing.Point(810, 10)
    Me.GrpMTX.Name = "GrpMTX"
    Me.GrpMTX.Size = New System.Drawing.Size(197, 531)
    Me.GrpMTX.TabIndex = 32
    Me.GrpMTX.TabStop = False
    Me.GrpMTX.Text = "��ѯ"
    Me.GrpMTX.Visible = False
    '
    'ComboBoxOnLineStationInfo
    '
    Me.ComboBoxOnLineStationInfo.Location = New System.Drawing.Point(44, 70)
    Me.ComboBoxOnLineStationInfo.Name = "ComboBoxOnLineStationInfo"
    Me.ComboBoxOnLineStationInfo.Size = New System.Drawing.Size(147, 20)
    Me.ComboBoxOnLineStationInfo.TabIndex = 42
    '
    'DoUDTXDataMode
    '
    Me.DoUDTXDataMode.Items.Add(" P")
    Me.DoUDTXDataMode.Items.Add(" S")
    Me.DoUDTXDataMode.Items.Add(" R")
    Me.DoUDTXDataMode.Items.Add(" A")
    Me.DoUDTXDataMode.Items.Add(" T")
    Me.DoUDTXDataMode.Location = New System.Drawing.Point(153, 45)
    Me.DoUDTXDataMode.Name = "DoUDTXDataMode"
    Me.DoUDTXDataMode.Size = New System.Drawing.Size(36, 21)
    Me.DoUDTXDataMode.TabIndex = 41
    '
    'BtnCbinFile
    '
    Me.BtnCbinFile.Location = New System.Drawing.Point(129, 13)
    Me.BtnCbinFile.Name = "BtnCbinFile"
    Me.BtnCbinFile.Size = New System.Drawing.Size(61, 22)
    Me.BtnCbinFile.TabIndex = 40
    Me.BtnCbinFile.Text = "�γɶ������ļ�"
    Me.BtnCbinFile.Visible = False
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.BtnClear)
    Me.GroupBox3.Controls.Add(Me.BtnDel)
    Me.GroupBox3.Controls.Add(Me.LstSuccess)
    Me.GroupBox3.Location = New System.Drawing.Point(4, 255)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(189, 194)
    Me.GroupBox3.TabIndex = 39
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "�����б�"
    '
    'BtnClear
    '
    Me.BtnClear.Location = New System.Drawing.Point(112, 165)
    Me.BtnClear.Name = "BtnClear"
    Me.BtnClear.Size = New System.Drawing.Size(62, 22)
    Me.BtnClear.TabIndex = 36
    Me.BtnClear.Text = "���"
    '
    'BtnDel
    '
    Me.BtnDel.Location = New System.Drawing.Point(19, 165)
    Me.BtnDel.Name = "BtnDel"
    Me.BtnDel.Size = New System.Drawing.Size(62, 22)
    Me.BtnDel.TabIndex = 35
    Me.BtnDel.Text = "ɾ��"
    '
    'LstSuccess
    '
    Me.LstSuccess.HorizontalScrollbar = True
    Me.LstSuccess.ItemHeight = 12
    Me.LstSuccess.Location = New System.Drawing.Point(5, 22)
    Me.LstSuccess.Name = "LstSuccess"
    Me.LstSuccess.ScrollAlwaysVisible = True
    Me.LstSuccess.Size = New System.Drawing.Size(177, 136)
    Me.LstSuccess.TabIndex = 34
    '
    'Label22
    '
    Me.Label22.Location = New System.Drawing.Point(116, 48)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(43, 19)
    Me.Label22.TabIndex = 38
    Me.Label22.Text = "Mode��"
    '
    'NumUDID
    '
    Me.NumUDID.Location = New System.Drawing.Point(44, 45)
    Me.NumUDID.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
    Me.NumUDID.Name = "NumUDID"
    Me.NumUDID.Size = New System.Drawing.Size(73, 21)
    Me.NumUDID.TabIndex = 37
    '
    'RadBtnSin
    '
    Me.RadBtnSin.Location = New System.Drawing.Point(18, 17)
    Me.RadBtnSin.Name = "RadBtnSin"
    Me.RadBtnSin.Size = New System.Drawing.Size(107, 22)
    Me.RadBtnSin.TabIndex = 35
    Me.RadBtnSin.Text = "��ѯѡ��վ��"
    '
    'RadBtnAll
    '
    Me.RadBtnAll.Location = New System.Drawing.Point(19, 192)
    Me.RadBtnAll.Name = "RadBtnAll"
    Me.RadBtnAll.Size = New System.Drawing.Size(130, 20)
    Me.RadBtnAll.TabIndex = 34
    Me.RadBtnAll.Text = "��ѯ��������վ��"
    '
    'BtnSend
    '
    Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnSend.Image = CType(resources.GetObject("BtnSend.Image"), System.Drawing.Image)
    Me.BtnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnSend.Location = New System.Drawing.Point(93, 215)
    Me.BtnSend.Name = "BtnSend"
    Me.BtnSend.Size = New System.Drawing.Size(93, 34)
    Me.BtnSend.TabIndex = 31
    Me.BtnSend.Text = "��������"
    Me.BtnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label20
    '
    Me.Label20.Location = New System.Drawing.Point(7, 48)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(55, 19)
    Me.Label20.TabIndex = 33
    Me.Label20.Text = "èID��"
    '
    'RtxtSendData
    '
    Me.RtxtSendData.Location = New System.Drawing.Point(4, 99)
    Me.RtxtSendData.Name = "RtxtSendData"
    Me.RtxtSendData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
    Me.RtxtSendData.Size = New System.Drawing.Size(187, 83)
    Me.RtxtSendData.TabIndex = 18
    Me.RtxtSendData.Text = ""
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.gifMSend)
    Me.GroupBox4.Controls.Add(Me.BtnMSendAbort)
    Me.GroupBox4.Location = New System.Drawing.Point(4, 456)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(189, 71)
    Me.GroupBox4.TabIndex = 33
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "ͨѶ״̬"
    '
    'gifMSend
    '
    Me.gifMSend.Enabled = True
    Me.gifMSend.Location = New System.Drawing.Point(28, 21)
    Me.gifMSend.Name = "gifMSend"
    Me.gifMSend.OcxState = CType(resources.GetObject("gifMSend.OcxState"), System.Windows.Forms.AxHost.State)
    Me.gifMSend.Size = New System.Drawing.Size(74, 54)
    Me.gifMSend.TabIndex = 0
    '
    'Label24
    '
    Me.Label24.Location = New System.Drawing.Point(18, 225)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(93, 22)
    Me.Label24.TabIndex = 33
    Me.Label24.Text = "*"
    '
    'Label27
    '
    Me.Label27.Location = New System.Drawing.Point(7, 74)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(55, 19)
    Me.Label27.TabIndex = 43
    Me.Label27.Text = "վ  ��"
    '
    'PanelComm
    '
    Me.PanelComm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PanelComm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.PanelComm.Controls.Add(Me.GrpATX)
    Me.PanelComm.Controls.Add(Me.ChkRevTest)
    Me.PanelComm.Controls.Add(Me.GrpTXMode)
    Me.PanelComm.Controls.Add(Me.ChkAutoStart)
    Me.PanelComm.Controls.Add(Me.txtPCount)
    Me.PanelComm.Controls.Add(Me.BtnCleartxtInfo)
    Me.PanelComm.Controls.Add(Me.Label21)
    Me.PanelComm.Controls.Add(Me.txtInfo)
    Me.PanelComm.Controls.Add(Me.lstInfo)
    Me.PanelComm.Controls.Add(Me.ToolBarTongXun)
    Me.PanelComm.Location = New System.Drawing.Point(0, 0)
    Me.PanelComm.Name = "PanelComm"
    Me.PanelComm.Size = New System.Drawing.Size(802, 584)
    Me.PanelComm.TabIndex = 1
    '
    'GrpATX
    '
    Me.GrpATX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GrpATX.Controls.Add(Me.GroupBox7)
    Me.GrpATX.Controls.Add(Me.Panel1)
    Me.GrpATX.Controls.Add(Me.GroupBox5)
    Me.GrpATX.Controls.Add(Me.GroupBox6)
    Me.GrpATX.Controls.Add(Me.RadioButton1)
    Me.GrpATX.Controls.Add(Me.RadioButton2)
    Me.GrpATX.Location = New System.Drawing.Point(592, 8)
    Me.GrpATX.Name = "GrpATX"
    Me.GrpATX.Size = New System.Drawing.Size(197, 567)
    Me.GrpATX.TabIndex = 42
    Me.GrpATX.TabStop = False
    Me.GrpATX.Text = "�Զ���ѯ"
    Me.GrpATX.Visible = False
    '
    'GroupBox7
    '
    Me.GroupBox7.Controls.Add(Me.Btn_Clear_LstATXSuccess)
    Me.GroupBox7.Controls.Add(Me.Button3)
    Me.GroupBox7.Controls.Add(Me.LstATXSuccess)
    Me.GroupBox7.Location = New System.Drawing.Point(4, 349)
    Me.GroupBox7.Name = "GroupBox7"
    Me.GroupBox7.Size = New System.Drawing.Size(189, 212)
    Me.GroupBox7.TabIndex = 44
    Me.GroupBox7.TabStop = False
    Me.GroupBox7.Text = "�����б�"
    '
    'Btn_Clear_LstATXSuccess
    '
    Me.Btn_Clear_LstATXSuccess.Location = New System.Drawing.Point(112, 184)
    Me.Btn_Clear_LstATXSuccess.Name = "Btn_Clear_LstATXSuccess"
    Me.Btn_Clear_LstATXSuccess.Size = New System.Drawing.Size(62, 22)
    Me.Btn_Clear_LstATXSuccess.TabIndex = 36
    Me.Btn_Clear_LstATXSuccess.Text = "���"
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(19, 184)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(62, 22)
    Me.Button3.TabIndex = 35
    Me.Button3.Text = "ɾ��"
    Me.Button3.Visible = False
    '
    'LstATXSuccess
    '
    Me.LstATXSuccess.HorizontalScrollbar = True
    Me.LstATXSuccess.ItemHeight = 12
    Me.LstATXSuccess.Location = New System.Drawing.Point(5, 22)
    Me.LstATXSuccess.Name = "LstATXSuccess"
    Me.LstATXSuccess.ScrollAlwaysVisible = True
    Me.LstATXSuccess.Size = New System.Drawing.Size(177, 160)
    Me.LstATXSuccess.TabIndex = 34
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.BtnTmpSave)
    Me.Panel1.Controls.Add(Me.Lbl_ATX_Now)
    Me.Panel1.Controls.Add(Me.Lbl_ATX_StartRunTime_Next)
    Me.Panel1.Controls.Add(Me.Label31)
    Me.Panel1.Controls.Add(Me.Label_ATX_Note)
    Me.Panel1.Controls.Add(Me.NumericUpDown_ATX_Hours)
    Me.Panel1.Controls.Add(Me.Label30)
    Me.Panel1.Controls.Add(Me.RadioBtn_ATX_Time3)
    Me.Panel1.Controls.Add(Me.RadioBtn_ATX_Time2)
    Me.Panel1.Controls.Add(Me.RadioBtn_ATX_Time1)
    Me.Panel1.Location = New System.Drawing.Point(10, 17)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(178, 244)
    Me.Panel1.TabIndex = 43
    '
    'BtnTmpSave
    '
    Me.BtnTmpSave.Location = New System.Drawing.Point(122, 210)
    Me.BtnTmpSave.Name = "BtnTmpSave"
    Me.BtnTmpSave.Size = New System.Drawing.Size(43, 22)
    Me.BtnTmpSave.TabIndex = 45
    Me.BtnTmpSave.Text = "Save"
    Me.BtnTmpSave.UseVisualStyleBackColor = True
    Me.BtnTmpSave.Visible = False
    '
    'Lbl_ATX_Now
    '
    Me.Lbl_ATX_Now.ForeColor = System.Drawing.Color.Green
    Me.Lbl_ATX_Now.Location = New System.Drawing.Point(5, 203)
    Me.Lbl_ATX_Now.Name = "Lbl_ATX_Now"
    Me.Lbl_ATX_Now.Size = New System.Drawing.Size(202, 18)
    Me.Lbl_ATX_Now.TabIndex = 44
    Me.Lbl_ATX_Now.Text = "    ��ǰʱ�䣺"
    '
    'Lbl_ATX_StartRunTime_Next
    '
    Me.Lbl_ATX_StartRunTime_Next.ForeColor = System.Drawing.Color.Green
    Me.Lbl_ATX_StartRunTime_Next.Location = New System.Drawing.Point(5, 222)
    Me.Lbl_ATX_StartRunTime_Next.Name = "Lbl_ATX_StartRunTime_Next"
    Me.Lbl_ATX_StartRunTime_Next.Size = New System.Drawing.Size(195, 18)
    Me.Lbl_ATX_StartRunTime_Next.TabIndex = 43
    Me.Lbl_ATX_StartRunTime_Next.Text = "�´ο�ʼʱ�䣺"
    '
    'Label31
    '
    Me.Label31.AutoSize = True
    Me.Label31.Location = New System.Drawing.Point(120, 97)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(53, 12)
    Me.Label31.TabIndex = 42
    Me.Label31.Text = "(1��6��)"
    '
    'Label_ATX_Note
    '
    Me.Label_ATX_Note.Location = New System.Drawing.Point(10, 132)
    Me.Label_ATX_Note.Name = "Label_ATX_Note"
    Me.Label_ATX_Note.Size = New System.Drawing.Size(160, 60)
    Me.Label_ATX_Note.TabIndex = 41
    Me.Label_ATX_Note.Text = "ע��"
    '
    'NumericUpDown_ATX_Hours
    '
    Me.NumericUpDown_ATX_Hours.Location = New System.Drawing.Point(72, 92)
    Me.NumericUpDown_ATX_Hours.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
    Me.NumericUpDown_ATX_Hours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.NumericUpDown_ATX_Hours.Name = "NumericUpDown_ATX_Hours"
    Me.NumericUpDown_ATX_Hours.Size = New System.Drawing.Size(44, 21)
    Me.NumericUpDown_ATX_Hours.TabIndex = 40
    Me.NumericUpDown_ATX_Hours.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.Location = New System.Drawing.Point(10, 10)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(89, 12)
    Me.Label30.TabIndex = 39
    Me.Label30.Text = "���ʱ�����ã�"
    '
    'RadioBtn_ATX_Time3
    '
    Me.RadioBtn_ATX_Time3.Location = New System.Drawing.Point(12, 92)
    Me.RadioBtn_ATX_Time3.Name = "RadioBtn_ATX_Time3"
    Me.RadioBtn_ATX_Time3.Size = New System.Drawing.Size(62, 22)
    Me.RadioBtn_ATX_Time3.TabIndex = 38
    Me.RadioBtn_ATX_Time3.Text = "��Сʱ"
    '
    'RadioBtn_ATX_Time2
    '
    Me.RadioBtn_ATX_Time2.Location = New System.Drawing.Point(12, 64)
    Me.RadioBtn_ATX_Time2.Name = "RadioBtn_ATX_Time2"
    Me.RadioBtn_ATX_Time2.Size = New System.Drawing.Size(62, 22)
    Me.RadioBtn_ATX_Time2.TabIndex = 37
    Me.RadioBtn_ATX_Time2.Text = "30����"
    '
    'RadioBtn_ATX_Time1
    '
    Me.RadioBtn_ATX_Time1.Location = New System.Drawing.Point(12, 36)
    Me.RadioBtn_ATX_Time1.Name = "RadioBtn_ATX_Time1"
    Me.RadioBtn_ATX_Time1.Size = New System.Drawing.Size(62, 22)
    Me.RadioBtn_ATX_Time1.TabIndex = 36
    Me.RadioBtn_ATX_Time1.Text = "10����"
    '
    'GroupBox5
    '
    Me.GroupBox5.Controls.Add(Me.GifASend)
    Me.GroupBox5.Controls.Add(Me.Btn_StartStop_ATX)
    Me.GroupBox5.Location = New System.Drawing.Point(4, 267)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.Size = New System.Drawing.Size(189, 76)
    Me.GroupBox5.TabIndex = 40
    Me.GroupBox5.TabStop = False
    Me.GroupBox5.Text = "ͨѶ״̬"
    '
    'GifASend
    '
    Me.GifASend.Enabled = True
    Me.GifASend.Location = New System.Drawing.Point(12, 24)
    Me.GifASend.Name = "GifASend"
    Me.GifASend.OcxState = CType(resources.GetObject("GifASend.OcxState"), System.Windows.Forms.AxHost.State)
    Me.GifASend.Size = New System.Drawing.Size(60, 45)
    Me.GifASend.TabIndex = 0
    '
    'GroupBox6
    '
    Me.GroupBox6.Controls.Add(Me.NumericUpDown4)
    Me.GroupBox6.Controls.Add(Me.Btn_ListBoxAtxTimePoint_Del)
    Me.GroupBox6.Controls.Add(Me.Btn_ListBoxAtxTimePoint_Clear)
    Me.GroupBox6.Controls.Add(Me.NumericUpDown2)
    Me.GroupBox6.Controls.Add(Me.NumericUpDown1)
    Me.GroupBox6.Controls.Add(Me.ListBoxAtxTimePoint)
    Me.GroupBox6.Controls.Add(Me.Label26)
    Me.GroupBox6.Controls.Add(Me.Btn_ListBoxAtxTimePoint_Add)
    Me.GroupBox6.Controls.Add(Me.Label28)
    Me.GroupBox6.Controls.Add(Me.CheckBox1)
    Me.GroupBox6.Controls.Add(Me.Label29)
    Me.GroupBox6.Controls.Add(Me.Label25)
    Me.GroupBox6.Location = New System.Drawing.Point(4, 17)
    Me.GroupBox6.Name = "GroupBox6"
    Me.GroupBox6.Size = New System.Drawing.Size(189, 224)
    Me.GroupBox6.TabIndex = 39
    Me.GroupBox6.TabStop = False
    Me.GroupBox6.Text = "��ѯʱ������"
    Me.GroupBox6.Visible = False
    '
    'NumericUpDown4
    '
    Me.NumericUpDown4.Location = New System.Drawing.Point(60, 244)
    Me.NumericUpDown4.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
    Me.NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.NumericUpDown4.Name = "NumericUpDown4"
    Me.NumericUpDown4.Size = New System.Drawing.Size(36, 21)
    Me.NumericUpDown4.TabIndex = 49
    Me.NumericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'NumericUpDown2
    '
    Me.NumericUpDown2.Location = New System.Drawing.Point(128, 208)
    Me.NumericUpDown2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
    Me.NumericUpDown2.Name = "NumericUpDown2"
    Me.NumericUpDown2.Size = New System.Drawing.Size(36, 21)
    Me.NumericUpDown2.TabIndex = 41
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Location = New System.Drawing.Point(76, 208)
    Me.NumericUpDown1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(36, 21)
    Me.NumericUpDown1.TabIndex = 37
    '
    'ListBoxAtxTimePoint
    '
    Me.ListBoxAtxTimePoint.ItemHeight = 12
    Me.ListBoxAtxTimePoint.Location = New System.Drawing.Point(6, 22)
    Me.ListBoxAtxTimePoint.Name = "ListBoxAtxTimePoint"
    Me.ListBoxAtxTimePoint.ScrollAlwaysVisible = True
    Me.ListBoxAtxTimePoint.Size = New System.Drawing.Size(177, 148)
    Me.ListBoxAtxTimePoint.TabIndex = 34
    '
    'Label26
    '
    Me.Label26.Location = New System.Drawing.Point(112, 212)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(24, 20)
    Me.Label26.TabIndex = 43
    Me.Label26.Text = "ʱ"
    '
    'Label28
    '
    Me.Label28.Location = New System.Drawing.Point(96, 248)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(36, 16)
    Me.Label28.TabIndex = 48
    Me.Label28.Text = "ʱ"
    '
    'CheckBox1
    '
    Me.CheckBox1.Location = New System.Drawing.Point(16, 244)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(52, 24)
    Me.CheckBox1.TabIndex = 46
    Me.CheckBox1.Text = "���"
    '
    'Label29
    '
    Me.Label29.Location = New System.Drawing.Point(16, 212)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(72, 20)
    Me.Label29.TabIndex = 50
    Me.Label29.Text = "��ѯʱ�䣺"
    '
    'Label25
    '
    Me.Label25.Location = New System.Drawing.Point(164, 212)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(16, 20)
    Me.Label25.TabIndex = 40
    Me.Label25.Text = "��"
    '
    'RadioButton1
    '
    Me.RadioButton1.Location = New System.Drawing.Point(18, 17)
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.Size = New System.Drawing.Size(126, 22)
    Me.RadioButton1.TabIndex = 35
    Me.RadioButton1.Text = "��ѯ��������վ��"
    '
    'RadioButton2
    '
    Me.RadioButton2.Location = New System.Drawing.Point(18, 40)
    Me.RadioButton2.Name = "RadioButton2"
    Me.RadioButton2.Size = New System.Drawing.Size(130, 20)
    Me.RadioButton2.TabIndex = 34
    Me.RadioButton2.Text = "��ѯ��������վ��"
    '
    'ChkRevTest
    '
    Me.ChkRevTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ChkRevTest.BackColor = System.Drawing.SystemColors.Control
    Me.ChkRevTest.Cursor = System.Windows.Forms.Cursors.Hand
    Me.ChkRevTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.ChkRevTest.Location = New System.Drawing.Point(533, 10)
    Me.ChkRevTest.Name = "ChkRevTest"
    Me.ChkRevTest.Size = New System.Drawing.Size(74, 36)
    Me.ChkRevTest.TabIndex = 16
    Me.ChkRevTest.Text = "������ʾ��������"
    Me.ChkRevTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.ChkRevTest.UseVisualStyleBackColor = False
    '
    'GrpTXMode
    '
    Me.GrpTXMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GrpTXMode.Controls.Add(Me.RaBtnM)
    Me.GrpTXMode.Controls.Add(Me.RaBtnA)
    Me.GrpTXMode.Location = New System.Drawing.Point(675, 5)
    Me.GrpTXMode.Name = "GrpTXMode"
    Me.GrpTXMode.Size = New System.Drawing.Size(120, 39)
    Me.GrpTXMode.TabIndex = 14
    Me.GrpTXMode.TabStop = False
    Me.GrpTXMode.Text = "��ѯ��ʽ"
    '
    'RaBtnM
    '
    Me.RaBtnM.Location = New System.Drawing.Point(66, 15)
    Me.RaBtnM.Name = "RaBtnM"
    Me.RaBtnM.Size = New System.Drawing.Size(49, 22)
    Me.RaBtnM.TabIndex = 1
    Me.RaBtnM.Text = "�ֶ�"
    '
    'RaBtnA
    '
    Me.RaBtnA.Location = New System.Drawing.Point(12, 15)
    Me.RaBtnA.Name = "RaBtnA"
    Me.RaBtnA.Size = New System.Drawing.Size(48, 20)
    Me.RaBtnA.TabIndex = 0
    Me.RaBtnA.Text = "�Զ�"
    '
    'ChkAutoStart
    '
    Me.ChkAutoStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ChkAutoStart.Location = New System.Drawing.Point(428, 17)
    Me.ChkAutoStart.Name = "ChkAutoStart"
    Me.ChkAutoStart.Size = New System.Drawing.Size(99, 18)
    Me.ChkAutoStart.TabIndex = 13
    Me.ChkAutoStart.Text = "�Զ���������"
    '
    'txtPCount
    '
    Me.txtPCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtPCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPCount.Font = New System.Drawing.Font("����", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.txtPCount.ForeColor = System.Drawing.Color.Orange
    Me.txtPCount.Location = New System.Drawing.Point(609, 12)
    Me.txtPCount.Name = "txtPCount"
    Me.txtPCount.Size = New System.Drawing.Size(57, 34)
    Me.txtPCount.TabIndex = 11
    Me.txtPCount.Text = "HZY"
    Me.txtPCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'BtnCleartxtInfo
    '
    Me.BtnCleartxtInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BtnCleartxtInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.BtnCleartxtInfo.Image = CType(resources.GetObject("BtnCleartxtInfo.Image"), System.Drawing.Image)
    Me.BtnCleartxtInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.BtnCleartxtInfo.Location = New System.Drawing.Point(714, 286)
    Me.BtnCleartxtInfo.Name = "BtnCleartxtInfo"
    Me.BtnCleartxtInfo.Size = New System.Drawing.Size(63, 27)
    Me.BtnCleartxtInfo.TabIndex = 32
    Me.BtnCleartxtInfo.Text = "���"
    Me.BtnCleartxtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label21
    '
    Me.Label21.Location = New System.Drawing.Point(315, 13)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(93, 23)
    Me.Label21.TabIndex = 17
    Me.Label21.Text = "*"
    Me.Label21.Visible = False
    '
    'txtInfo
    '
    Me.txtInfo.BackColor = System.Drawing.Color.LightYellow
    Me.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.txtInfo.ForeColor = System.Drawing.Color.ForestGreen
    Me.txtInfo.Location = New System.Drawing.Point(0, 282)
    Me.txtInfo.Name = "txtInfo"
    Me.txtInfo.ReadOnly = True
    Me.txtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
    Me.txtInfo.Size = New System.Drawing.Size(798, 298)
    Me.txtInfo.TabIndex = 10
    Me.txtInfo.Tag = "1"
    Me.txtInfo.Text = ""
    '
    'lstInfo
    '
    Me.lstInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstInfo.BackColor = System.Drawing.SystemColors.Info
    Me.lstInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.modemId, Me.telNo, Me.loginTime, Me.dynamicIP})
    Me.lstInfo.GridLines = True
    Me.lstInfo.Location = New System.Drawing.Point(2, 46)
    Me.lstInfo.MultiSelect = False
    Me.lstInfo.Name = "lstInfo"
    Me.lstInfo.Size = New System.Drawing.Size(798, 230)
    Me.lstInfo.TabIndex = 9
    Me.lstInfo.UseCompatibleStateImageBehavior = False
    Me.lstInfo.View = System.Windows.Forms.View.Details
    '
    'modemId
    '
    Me.modemId.Text = "Modem Id"
    Me.modemId.Width = 124
    '
    'telNo
    '
    Me.telNo.Text = "�绰����"
    Me.telNo.Width = 128
    '
    'loginTime
    '
    Me.loginTime.Text = "��¼ʱ��"
    Me.loginTime.Width = 134
    '
    'dynamicIP
    '
    Me.dynamicIP.Text = "��̬IP"
    Me.dynamicIP.Width = 196
    '
    'ToolBarTongXun
    '
    Me.ToolBarTongXun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ToolBarTongXun.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.ToolBarTongXun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ToolBarTongXun.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarTXStartServer, Me.ToolBarTXStopServer, Me.ToolBarButtonTXSetting})
    Me.ToolBarTongXun.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolBarTongXun.DropDownArrows = True
    Me.ToolBarTongXun.ImageList = Me.ImageListToolBarTongXun
    Me.ToolBarTongXun.Location = New System.Drawing.Point(0, 0)
    Me.ToolBarTongXun.Name = "ToolBarTongXun"
    Me.ToolBarTongXun.ShowToolTips = True
    Me.ToolBarTongXun.Size = New System.Drawing.Size(799, 50)
    Me.ToolBarTongXun.TabIndex = 2
    '
    'ToolBarTXStartServer
    '
    Me.ToolBarTXStartServer.ImageIndex = 0
    Me.ToolBarTXStartServer.Name = "ToolBarTXStartServer"
    Me.ToolBarTXStartServer.Text = "��������"
    '
    'ToolBarTXStopServer
    '
    Me.ToolBarTXStopServer.ImageIndex = 1
    Me.ToolBarTXStopServer.Name = "ToolBarTXStopServer"
    Me.ToolBarTXStopServer.Text = "ֹͣ����"
    '
    'ToolBarButtonTXSetting
    '
    Me.ToolBarButtonTXSetting.ImageIndex = 2
    Me.ToolBarButtonTXSetting.Name = "ToolBarButtonTXSetting"
    Me.ToolBarButtonTXSetting.Text = "ͨѶ����"
    '
    'ImageListToolBarTongXun
    '
    Me.ImageListToolBarTongXun.ImageStream = CType(resources.GetObject("ImageListToolBarTongXun.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageListToolBarTongXun.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageListToolBarTongXun.Images.SetKeyName(0, "")
    Me.ImageListToolBarTongXun.Images.SetKeyName(1, "")
    Me.ImageListToolBarTongXun.Images.SetKeyName(2, "")
    '
    'ImageListTab
    '
    Me.ImageListTab.ImageStream = CType(resources.GetObject("ImageListTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageListTab.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageListTab.Images.SetKeyName(0, "")
    Me.ImageListTab.Images.SetKeyName(1, "")
    Me.ImageListTab.Images.SetKeyName(2, "")
    Me.ImageListTab.Images.SetKeyName(3, "")
    '
    'TimerCheckRev
    '
    Me.TimerCheckRev.Interval = 200
    '
    'AniGifMainForm
    '
    Me.AniGifMainForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.AniGifMainForm.Enabled = True
    Me.AniGifMainForm.Location = New System.Drawing.Point(812, 244)
    Me.AniGifMainForm.Name = "AniGifMainForm"
    Me.AniGifMainForm.OcxState = CType(resources.GetObject("AniGifMainForm.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AniGifMainForm.Size = New System.Drawing.Size(192, 307)
    Me.AniGifMainForm.TabIndex = 12
    Me.AniGifMainForm.Tag = "AniGifMainForm"
    Me.AniGifMainForm.Visible = False
    '
    'TimerThreadRevMSend
    '
    Me.TimerThreadRevMSend.Interval = 200
    '
    'TimerPollUserTable
    '
    Me.TimerPollUserTable.Interval = 10000
    '
    'ImageList1
    '
    Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
    Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFile, Me.MenuItemView, Me.MenuItemSetting, Me.MenuItemTools, Me.����HToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
    Me.MenuStrip1.TabIndex = 13
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'MenuItemFile
    '
    Me.MenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemOpenWork, Me.MenuItemSaveWork, Me.ToolStripSeparator1, Me.MenuItemLogout, Me.ToolStripSeparator2, Me.MenuFileExit})
    Me.MenuItemFile.Name = "MenuItemFile"
    Me.MenuItemFile.Size = New System.Drawing.Size(59, 20)
    Me.MenuItemFile.Text = "�ļ�(&F)"
    '
    'MenuItemOpenWork
    '
    Me.MenuItemOpenWork.Name = "MenuItemOpenWork"
    Me.MenuItemOpenWork.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemOpenWork.Text = "�򿪹���(&O)"
    '
    'MenuItemSaveWork
    '
    Me.MenuItemSaveWork.Name = "MenuItemSaveWork"
    Me.MenuItemSaveWork.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemSaveWork.Text = "���湤��(&S)"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
    '
    'MenuItemLogout
    '
    Me.MenuItemLogout.Name = "MenuItemLogout"
    Me.MenuItemLogout.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemLogout.Text = "ע��(&U)"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(133, 6)
    '
    'MenuFileExit
    '
    Me.MenuFileExit.Name = "MenuFileExit"
    Me.MenuFileExit.Size = New System.Drawing.Size(136, 22)
    Me.MenuFileExit.Text = "�˳�(&E)"
    '
    'MenuItemView
    '
    Me.MenuItemView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemViewMap, Me.MenuItemViewStation, Me.MenuItemViewTX, Me.ToolStripSeparator7, Me.MenuItemFlexTChart})
    Me.MenuItemView.Name = "MenuItemView"
    Me.MenuItemView.Size = New System.Drawing.Size(59, 20)
    Me.MenuItemView.Text = "�鿴(&V)"
    '
    'MenuItemViewMap
    '
    Me.MenuItemViewMap.Name = "MenuItemViewMap"
    Me.MenuItemViewMap.Size = New System.Drawing.Size(172, 22)
    Me.MenuItemViewMap.Text = "��ͼ(&M)"
    '
    'MenuItemViewStation
    '
    Me.MenuItemViewStation.Name = "MenuItemViewStation"
    Me.MenuItemViewStation.Size = New System.Drawing.Size(172, 22)
    Me.MenuItemViewStation.Text = "վ��(&S)"
    '
    'MenuItemViewTX
    '
    Me.MenuItemViewTX.Name = "MenuItemViewTX"
    Me.MenuItemViewTX.Size = New System.Drawing.Size(172, 22)
    Me.MenuItemViewTX.Text = "ͨѶ(&C)"
    '
    'ToolStripSeparator7
    '
    Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
    Me.ToolStripSeparator7.Size = New System.Drawing.Size(169, 6)
    '
    'MenuItemFlexTChart
    '
    Me.MenuItemFlexTChart.Name = "MenuItemFlexTChart"
    Me.MenuItemFlexTChart.Size = New System.Drawing.Size(172, 22)
    Me.MenuItemFlexTChart.Text = "����������ʾ(&G)"
    '
    'MenuItemSetting
    '
    Me.MenuItemSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuWorkSetting, Me.ToolStripSeparator3, Me.MenuItemTXSetting, Me.ToolStripSeparator4, Me.MenuItemSettingPerson})
    Me.MenuItemSetting.Name = "MenuItemSetting"
    Me.MenuItemSetting.Size = New System.Drawing.Size(59, 20)
    Me.MenuItemSetting.Text = "����(&S)"
    '
    'MenuWorkSetting
    '
    Me.MenuWorkSetting.Name = "MenuWorkSetting"
    Me.MenuWorkSetting.Size = New System.Drawing.Size(136, 22)
    Me.MenuWorkSetting.Text = "��������(&W)"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(133, 6)
    '
    'MenuItemTXSetting
    '
    Me.MenuItemTXSetting.Name = "MenuItemTXSetting"
    Me.MenuItemTXSetting.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemTXSetting.Text = "ͨѶ����(&J)"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(133, 6)
    '
    'MenuItemSettingPerson
    '
    Me.MenuItemSettingPerson.Name = "MenuItemSettingPerson"
    Me.MenuItemSettingPerson.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemSettingPerson.Text = "�û�����(&G)"
    '
    'MenuItemTools
    '
    Me.MenuItemTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ͨѶ����TToolStripMenuItem, Me.ToolStripSeparator5, Me.MenuItemSaveShuJu, Me.MenuItemChaXun, Me.ToolStripSeparator6, Me.MenuItemPrint})
    Me.MenuItemTools.Name = "MenuItemTools"
    Me.MenuItemTools.Size = New System.Drawing.Size(59, 20)
    Me.MenuItemTools.Text = "����(&T)"
    '
    'ͨѶ����TToolStripMenuItem
    '
    Me.ͨѶ����TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemTXStartServer, Me.MenuItemTXStopServer})
    Me.ͨѶ����TToolStripMenuItem.Name = "ͨѶ����TToolStripMenuItem"
    Me.ͨѶ����TToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
    Me.ͨѶ����TToolStripMenuItem.Text = "ͨѶ����(&T)"
    '
    'MenuItemTXStartServer
    '
    Me.MenuItemTXStartServer.Name = "MenuItemTXStartServer"
    Me.MenuItemTXStartServer.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemTXStartServer.Text = "��������(&S)"
    '
    'MenuItemTXStopServer
    '
    Me.MenuItemTXStopServer.Name = "MenuItemTXStopServer"
    Me.MenuItemTXStopServer.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemTXStopServer.Text = "ֹͣ����(&P)"
    '
    'ToolStripSeparator5
    '
    Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    Me.ToolStripSeparator5.Size = New System.Drawing.Size(133, 6)
    '
    'MenuItemSaveShuJu
    '
    Me.MenuItemSaveShuJu.Name = "MenuItemSaveShuJu"
    Me.MenuItemSaveShuJu.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemSaveShuJu.Text = "��������(&B)"
    '
    'MenuItemChaXun
    '
    Me.MenuItemChaXun.Name = "MenuItemChaXun"
    Me.MenuItemChaXun.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemChaXun.Text = "��ѯ����(&C)"
    '
    'ToolStripSeparator6
    '
    Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
    Me.ToolStripSeparator6.Size = New System.Drawing.Size(133, 6)
    '
    'MenuItemPrint
    '
    Me.MenuItemPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemPrintXX, Me.MenuItemPrintLS})
    Me.MenuItemPrint.Name = "MenuItemPrint"
    Me.MenuItemPrint.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemPrint.Text = "��ӡ(&P)"
    '
    'MenuItemPrintXX
    '
    Me.MenuItemPrintXX.Name = "MenuItemPrintXX"
    Me.MenuItemPrintXX.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemPrintXX.Text = "��ϸ��ӡ(&X)"
    '
    'MenuItemPrintLS
    '
    Me.MenuItemPrintLS.Name = "MenuItemPrintLS"
    Me.MenuItemPrintLS.Size = New System.Drawing.Size(136, 22)
    Me.MenuItemPrintLS.Text = "��ˮ��ӡ(&W)"
    '
    '����HToolStripMenuItem
    '
    Me.����HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAbout})
    Me.����HToolStripMenuItem.Name = "����HToolStripMenuItem"
    Me.����HToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
    Me.����HToolStripMenuItem.Text = "����(&H)"
    '
    'MenuItemAbout
    '
    Me.MenuItemAbout.Name = "MenuItemAbout"
    Me.MenuItemAbout.Size = New System.Drawing.Size(112, 22)
    Me.MenuItemAbout.Text = "����(&A)"
    '
    'TimerATX
    '
    Me.TimerATX.Interval = 10
    '
    'TimerATXRev
    '
    Me.TimerATXRev.Interval = 200
    '
    'TimerSendSSS
    '
    Me.TimerSendSSS.Interval = 200
    '
    'CS10
    '
    Me.CS10.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS10.BackColor = System.Drawing.Color.Gold
    Me.CS10.FontBackColor = System.Drawing.Color.DimGray
    Me.CS10.Location = New System.Drawing.Point(41, 417)
    Me.CS10.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS10.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS10.MyBackColor = System.Drawing.Color.Gold
    Me.CS10.MyForeColor = System.Drawing.Color.Navy
    Me.CS10.Name = "CS10"
    Me.CS10.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS10.PartName = "������/��"
    Me.CS10.Size = New System.Drawing.Size(348, 26)
    Me.CS10.TabIndex = 39
    Me.CS10.TabStop = False
    Me.CS10.Tag = "p10"
    Me.CS10.ValueString = ""
    '
    'CS9
    '
    Me.CS9.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS9.BackColor = System.Drawing.Color.Gold
    Me.CS9.FontBackColor = System.Drawing.Color.DimGray
    Me.CS9.Location = New System.Drawing.Point(41, 388)
    Me.CS9.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS9.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS9.MyBackColor = System.Drawing.Color.Gold
    Me.CS9.MyForeColor = System.Drawing.Color.Navy
    Me.CS9.Name = "CS9"
    Me.CS9.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS9.PartName = "������/��"
    Me.CS9.Size = New System.Drawing.Size(348, 26)
    Me.CS9.TabIndex = 38
    Me.CS9.TabStop = False
    Me.CS9.Tag = "p9"
    Me.CS9.ValueString = ""
    '
    'CS8
    '
    Me.CS8.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS8.BackColor = System.Drawing.Color.Gold
    Me.CS8.FontBackColor = System.Drawing.Color.DimGray
    Me.CS8.Location = New System.Drawing.Point(41, 359)
    Me.CS8.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS8.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS8.MyBackColor = System.Drawing.Color.Gold
    Me.CS8.MyForeColor = System.Drawing.Color.Navy
    Me.CS8.Name = "CS8"
    Me.CS8.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS8.PartName = "������/��"
    Me.CS8.Size = New System.Drawing.Size(348, 26)
    Me.CS8.TabIndex = 37
    Me.CS8.TabStop = False
    Me.CS8.Tag = "p8"
    Me.CS8.ValueString = ""
    '
    'CS7
    '
    Me.CS7.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS7.BackColor = System.Drawing.Color.Gold
    Me.CS7.FontBackColor = System.Drawing.Color.DimGray
    Me.CS7.Location = New System.Drawing.Point(41, 330)
    Me.CS7.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS7.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS7.MyBackColor = System.Drawing.Color.Gold
    Me.CS7.MyForeColor = System.Drawing.Color.Navy
    Me.CS7.Name = "CS7"
    Me.CS7.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS7.PartName = "������/��"
    Me.CS7.Size = New System.Drawing.Size(348, 26)
    Me.CS7.TabIndex = 36
    Me.CS7.TabStop = False
    Me.CS7.Tag = "p7"
    Me.CS7.ValueString = ""
    '
    'CS6
    '
    Me.CS6.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS6.BackColor = System.Drawing.Color.Gold
    Me.CS6.FontBackColor = System.Drawing.Color.DimGray
    Me.CS6.Location = New System.Drawing.Point(41, 301)
    Me.CS6.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS6.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS6.MyBackColor = System.Drawing.Color.Gold
    Me.CS6.MyForeColor = System.Drawing.Color.Navy
    Me.CS6.Name = "CS6"
    Me.CS6.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS6.PartName = "������/��"
    Me.CS6.Size = New System.Drawing.Size(348, 26)
    Me.CS6.TabIndex = 35
    Me.CS6.TabStop = False
    Me.CS6.Tag = "p6"
    Me.CS6.ValueString = ""
    '
    'CS3
    '
    Me.CS3.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS3.BackColor = System.Drawing.Color.Gold
    Me.CS3.FontBackColor = System.Drawing.Color.DimGray
    Me.CS3.Location = New System.Drawing.Point(41, 214)
    Me.CS3.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS3.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS3.MyBackColor = System.Drawing.Color.Gold
    Me.CS3.MyForeColor = System.Drawing.Color.Navy
    Me.CS3.Name = "CS3"
    Me.CS3.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS3.PartName = "������/��"
    Me.CS3.Size = New System.Drawing.Size(348, 26)
    Me.CS3.TabIndex = 34
    Me.CS3.TabStop = False
    Me.CS3.Tag = "p3"
    Me.CS3.ValueString = ""
    '
    'CS5
    '
    Me.CS5.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS5.BackColor = System.Drawing.Color.Gold
    Me.CS5.FontBackColor = System.Drawing.Color.DimGray
    Me.CS5.Location = New System.Drawing.Point(41, 272)
    Me.CS5.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS5.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS5.MyBackColor = System.Drawing.Color.Gold
    Me.CS5.MyForeColor = System.Drawing.Color.Navy
    Me.CS5.Name = "CS5"
    Me.CS5.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS5.PartName = "������/��"
    Me.CS5.Size = New System.Drawing.Size(348, 26)
    Me.CS5.TabIndex = 33
    Me.CS5.TabStop = False
    Me.CS5.Tag = "p5"
    Me.CS5.ValueString = ""
    '
    'CS2
    '
    Me.CS2.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS2.BackColor = System.Drawing.Color.Gold
    Me.CS2.FontBackColor = System.Drawing.Color.DimGray
    Me.CS2.Location = New System.Drawing.Point(41, 185)
    Me.CS2.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS2.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS2.MyBackColor = System.Drawing.Color.Gold
    Me.CS2.MyForeColor = System.Drawing.Color.Navy
    Me.CS2.Name = "CS2"
    Me.CS2.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS2.PartName = "������/��"
    Me.CS2.Size = New System.Drawing.Size(348, 26)
    Me.CS2.TabIndex = 32
    Me.CS2.TabStop = False
    Me.CS2.Tag = "p2"
    Me.CS2.ValueString = ""
    '
    'CS4
    '
    Me.CS4.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS4.BackColor = System.Drawing.Color.Gold
    Me.CS4.FontBackColor = System.Drawing.Color.DimGray
    Me.CS4.Location = New System.Drawing.Point(41, 243)
    Me.CS4.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS4.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS4.MyBackColor = System.Drawing.Color.Gold
    Me.CS4.MyForeColor = System.Drawing.Color.Navy
    Me.CS4.Name = "CS4"
    Me.CS4.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS4.PartName = "������/��"
    Me.CS4.Size = New System.Drawing.Size(348, 26)
    Me.CS4.TabIndex = 31
    Me.CS4.TabStop = False
    Me.CS4.Tag = "p4"
    Me.CS4.ValueString = ""
    '
    'CS1
    '
    Me.CS1.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.CS1.BackColor = System.Drawing.Color.Gold
    Me.CS1.FontBackColor = System.Drawing.Color.DimGray
    Me.CS1.Location = New System.Drawing.Point(41, 156)
    Me.CS1.MaximumSize = New System.Drawing.Size(348, 26)
    Me.CS1.MinimumSize = New System.Drawing.Size(348, 26)
    Me.CS1.MyBackColor = System.Drawing.Color.Gold
    Me.CS1.MyForeColor = System.Drawing.Color.Navy
    Me.CS1.Name = "CS1"
    Me.CS1.ParameterName = "һ�Ź�¯��ˮ������"
    Me.CS1.PartName = "������/��"
    Me.CS1.Size = New System.Drawing.Size(348, 26)
    Me.CS1.TabIndex = 30
    Me.CS1.TabStop = False
    Me.CS1.Tag = "p1"
    Me.CS1.ValueString = ""
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.ClientSize = New System.Drawing.Size(1016, 696)
    Me.Controls.Add(Me.PanelToolBar)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.AniGifMainForm)
    Me.Controls.Add(Me.StatusBar1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.MaximumSize = New System.Drawing.Size(1024, 730)
    Me.MinimumSize = New System.Drawing.Size(1022, 730)
    Me.Name = "Form1"
    CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gifServiceStart, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.AxAniGIFOnLine, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.AxAniGIFAsend, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelToolBar.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabShowMap.ResumeLayout(False)
    CType(Me.AxAniGIFRedDotHandel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelPicBoxMap.ResumeLayout(False)
    Me.PanelPicBoxMapMove.ResumeLayout(False)
    CType(Me.AniGIFStation, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PicBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelPassword.ResumeLayout(False)
    Me.PanelPassword.PerformLayout()
    Me.PanelEaglEye.ResumeLayout(False)
    Me.PanelPicBoxEaglEye.ResumeLayout(False)
    CType(Me.PicBoxEaglEye, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.AxShockwaveFlashMainForm, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabShowStation.ResumeLayout(False)
    Me.GroupBoxAboutStation.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.TabStationInfo.ResumeLayout(False)
    Me.TabStationIDIPName.ResumeLayout(False)
    Me.TabStationIDIPName.PerformLayout()
    Me.TabStationParameter.ResumeLayout(False)
    Me.TabStationParameter.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.PanelStation.ResumeLayout(False)
    Me.PanelSendMessage.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.GroupBoxSendMessage.ResumeLayout(False)
    Me.GroupBoxSendMessage.PerformLayout()
    CType(Me.PicboxStation, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabShowComm.ResumeLayout(False)
    Me.GrpMTX.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    CType(Me.NumUDID, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox4.ResumeLayout(False)
    CType(Me.gifMSend, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelComm.ResumeLayout(False)
    Me.PanelComm.PerformLayout()
    Me.GrpATX.ResumeLayout(False)
    Me.GroupBox7.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.NumericUpDown_ATX_Hours, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox5.ResumeLayout(False)
    CType(Me.GifASend, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox6.ResumeLayout(False)
    CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpTXMode.ResumeLayout(False)
    CType(Me.AniGifMainForm, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region

#Region " 20070207����ӵ� "
  Dim SetWorkAll_Run As Boolean = False
  Dim PanelPicBoxMapMove_MoveToSelectStation_Alow As Boolean = False
  Dim TimerATX_Tick_Runing As Boolean = False
  Dim ThreadRevASendRun As Boolean = False
#End Region

  Public Class ClassSendMessageState
        Public SendMessageStateStrWait As String = "�ȴ�"
        Public SendMessageStateStrSucc As String = "�ɹ�"
    Public SendMessageStateStrLost As String = "ʧ��"
    Public SendMessageStateColorWait As System.Drawing.Color = Color.LightGray
    Public SendMessageStateColorSucc As System.Drawing.Color = Color.Lime
    Public SendMessageStateColorLost As System.Drawing.Color = Color.Red
  End Class
  Dim SendMessageStateClass As New ClassSendMessageState
  Dim SendSSStartTime As Date
  Dim bSendSSSucess As Boolean = False
  Dim SendSSStationID As String


  Dim PicBoxEaglEyeMouseDown As Boolean = False
  Dim MeOrignWindowState As Integer
  Dim MeOrignSize As Size
  Dim MeOrignLocation As Point

  Dim myTcpServer As TcpListener
  Dim Ap1 As acceptProcess
  Dim TS1 As Thread
  Dim Ap2 As acceptProcess
  Dim TS2 As Thread

  'Dim PicBoxMap_OldPoint As Point
  Dim bPicBoxMap_MouseDown As Boolean
  Dim PointMouseOld, PointMouseNew, PointPicOld, PointPicNew As Point
  Dim MM As Boolean  '�����ƶ����
  'Dim FormWorkSetting As New Form2WorkSetting
  'Public Property ShareCw() As ClassGPRSWork
  '  Get
  '    Return CW
  '  End Get
  '  Set(ByVal Value As ClassGPRSWork)
  '    CW = Value
  '  End Set
  'End Property
  'Dim CW As New ClassGPRSWork
  Dim SSelectIndex As Integer 'Ŀǰ�� ѡ�����ĸ�����������
  Dim PlaceSNo As Integer
  Dim PicBoxMapFDSX_No As Short  '�Ŵ����С�ļ���
  Dim PicBoxMapFDSX(19) As Point  '��ͼ�Ŵ���С����ʷ��������,�õ�������ʽ������
  Dim PointStationPlace As Point 'վ���ڵ�ͼ�ϵ����꣬Ӧ������Image�ϵ�
  Dim bPlaceStation As Boolean '�Ƿ��Ƿ���վ��״̬
  Dim bPicBoxEaglEyeED As Boolean 'ӥ��ͼ��ؼ��Ƿ���װ�����ͼ
  Dim RevMapNo, RevStationNo As Integer
  Dim RevStationID As String
  'Dim CurHand0, CurHand1 As Cursor '�����,�ŵ�SGif����
  'Dim SGif As New GPRSImagesResource '����ͼ����Դ����,�ŵ�ģ����Ϊ����
  'Dim ActivePerson As GPRSPerson '��ǰ�����ʵ��,�ŵ�ģ�����Ϊ���ж���
  'Dim PerShowStationNo '�ڵ�ǰ��ͼ����У���һ����ʾ��վ����ͼ��վ���ţ���Ϊ��ε��TabShowStation��Ĭ��ֵ,���ڶ���ΪGPRSMap�����һ������
  Dim tmpStationParameter(STATION_MAX_NO, STATION_PROPERTY_MAX_NO, 3) As String 'վ���������ʱ����ʱ��¼���飬
  Dim bAChangeTextBoxParameter As Boolean = False
  Dim Form1Active As Boolean
  'Dim CWActive As Boolean '�ŵ�ģ�����ˣ���Ϊ���б�־
  'Dim MeRun As Boolean
  Dim ComboBoxSelectMap0Or1 As Short '��¼����һ��ѡ���˵�ͼ�������ظ�����
  Dim SetMapStationSelectComboBoxRun As Boolean = False 'Ϊ�˷�ֹ�����õ�ʱ������SelectMap
  'Dim ExitOk As Boolean = False '�Ƿ�Ҫ�˳��ˣ�Ҳ�����Ƿ��ǵ���˳���ť
  'Dim GprsWorkINI As New RWini '��¼������Ϣ��INI����
  Dim bMDataChanged As Boolean '�ֶ�����������
  Dim MSDBak(), ASDBak() As GprsSendDataBackup '��ʷ��¼�����͹������
  Dim tmpSDBak(0) As GprsSendDataBackup
  Dim ASendTimePoint() As String '�Զ���ѵʱ������飬��ά 

  Dim bAsend As Boolean '�Զ���ѯ����ͨѶ��־��һ��bMsend���ֶ�����ͨѶ��־
  Dim bMsend As Boolean '�ֶ������Զ��Ĳ�ѯվ�������������������˵Ļ����߳�Ӧ���ƹ�
  Dim bMsendED As Boolean 'ThreadRevMSend()�߳����ڷ��������ˣ�����Ҫ�ж��Ƿ��������
  Dim bMsendMAbort As Boolean '�ֶ�ֹͣͨѶ
  Dim FSendOneModemID As Int32
  Dim FSendOneData() As Byte
  Dim FSendOneDataLen As Integer
  Dim CheckRevSubRun As Boolean
  Dim PollUserTableRun As Boolean
  Dim ThreadRevMSendRun As Boolean
  Dim CheckRevFunRun As Boolean
  Dim bAddText As Boolean
  Dim AddTextColor1 As New System.Drawing.Color
  Dim AddTextColor2 As New System.Drawing.Color
  Dim EaglEyeRedDotGif(STATION_MAX_NO) As AxAniGIFCtrl.AxAniGIF
  Dim SendMode As String '��ѯʱ��PARST
  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
  Dim AdoNetAtxCN As New OleDb.OleDbConnection
  Dim AdoNetAtxDS As New DataSet
  Dim AdoNetAtxDA As New OleDb.OleDbDataAdapter
  Dim AdoNetAtxDV As New DataView
  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  '(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
  Dim S1, S2 As AxAniGIFCtrl.AxAniGIF
  Dim TTXX As Long
  ')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
  '----------------thread ----------------------------
  '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
  Dim ThreadTSMsend As ThreadStart
  Dim ThreadMSend As Thread
  Dim ThreadTSAsend As ThreadStart
  Dim ThreadASend As Thread
  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  Dim threadDelegateMain As ThreadStart '���߳�ί��
  Dim threadMain As Thread '���߳�
  'Dim threadChildArraylist As New ArrayList '���̼߳���
  Dim bStop As Boolean '���߳̿�����־
  Dim detail As New Detail
  '��ʼ��FrmMain����
  Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" _
    (ByVal lpApplicationName As String, _
     ByVal lpKeyName As String, _
     ByVal lpDefault As String, _
     ByVal lpReturnedString As String, _
     ByVal nSize As Int32, _
     ByVal lpFileName As String) As Long
  '[[[[[[[[[[[[[[[[[[[[[[Thread[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[

  Private Sub ThreadMethodMain()
    '���߳�start()����
    'SetAddTextColor()
    Me.AddText("���߳�������")
    'Dim i, j, k As Integer
    'Dim tuCount As Integer
    'Dim S As String
    'Dim ModemIDMapNo, ModemIDStationNo As Integer
    'Dim ModemID As String

    tmpSDBak(0) = New GprsSendDataBackup

    ' Dim frmdetail As New FrmDetail
    TimerCheckRev.Interval = ListenTimeLong
    TimerPollUserTable.Interval = PollUserTable_WaitTime
    TimerThreadRevMSend.Interval = ThreadRevMSend_WaitTime
    TimerATXRev.Interval = ThreadRevMSend_WaitTime
    'Do While bStop = False

    If (bMsend = False) And (bAsend = False) Then '���û����ʽ�ֶ������Զ���ѯ������ά���б�

      '[[[[[[[[[[[[[[[[[200512170237�����������߳��ö�ʱ������[[[[[[[
      TimerCheckRev.Start()
      TimerPollUserTable.Start()
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
      '((((((((((((((((((((((
      'TTXX += 1
      'Label21.Text = TTXX
      '))))))))))))))))))))))
      Application.DoEvents()
      '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
      'tuCount = GprsMod.DSGetModemCount() 'ȡ���û���

      'If tuCount > 0 Then

      '  '''[[[[[[[[[[[[[[[[['''''''''''''ά���û������б���ش���,�����
      '  For i = 0 To lstInfo.Items.Count - 1
      '    lstInfo.Items(i).Tag = "Del"
      '  Next
      '  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      '  For i = 0 To tuCount - 1
      '    '����û���Ϣ
      '    Dim TModemInfo As New ModemInfoStruct
      '    Call GprsMod.DSGetModemByPosition(i, TModemInfo)

      '    '����waittime�����߳�
      '    'Dim b As Date = #5/12/2005#
      '    Dim dayTemp = #1/1/1970#
      '    Dim daysDiff As Int32 = Abs(DateDiff(DateInterval.Second, dayTemp, Now))
      '    Dim tmpLong As Long
      '    tmpLong = daysDiff - TModemInfo.m_Refresh_Time - 28800

      '    '(((((((((((((((((((((((((
      '    'Label21.Text = CStr(TTXX) & "  " & CStr(tuCount)
      '    'Application.DoEvents()
      '    ')))))))))))))))))))))))))

      '    If WaitTime = 0 Or tmpLong < WaitTime Then

      '      '-------------------------------------------------------
      '      '���ݰ����ݽ�������
      '      Dim AddDataInfo(4) As String
      '      ModemID = StringToLen8(Hex(CStr(TModemInfo.m_ModemId))) '�������е�ModeID��Ӧ��ͨ���������ת����8����
      '      AddDataInfo(0) = ModemID
      '      Dim PhoneData As String = ""
      '      Dim a As Integer
      '      For a = 0 To 11
      '        PhoneData = PhoneData & Chr(CInt(TModemInfo.m_PhoneNo(a)))
      '      Next a

      '      AddDataInfo(1) = PhoneData
      '      AddDataInfo(2) = DateAdd("s", TModemInfo.m_Conn_Time, "1970-1-1 8:00:00")
      '      AddDataInfo(3) = Me.ByteToIp(TModemInfo.m_DynIp)

      '      '��������������ʾ��������
      '      'Me.AddText("tmodeminfo.m_modemid showmain :::" & tmodeminfo.m_modemid)
      '      Dim lvt As New ListViewItem(AddDataInfo)
      '      Dim lvtCount As Integer = Me.lstInfo.Items.Count

      '      If Not existRecord(AddDataInfo(0), AddDataInfo(1)) Then
      '        Me.lstInfo.Items.Insert(lvtCount, lvt)
      '        Me.lstInfo.Items(lvtCount).Tag = "Stay"

      '        Application.DoEvents()

      '        '''''''''''''''�ж��Ƿ�������վ��
      '        Dim bHave As Boolean = False
      '        For j = 1 To CW.MapAmount
      '          For k = 1 To CW.Maps(j).MapStationPlacedAmount
      '            If ModemID = CW.Maps(j).Stations(k).ModemInfo.ID Then
      '              ModemIDMapNo = j
      '              ModemIDStationNo = k
      '              bHave = True
      '              Exit For
      '            End If
      '            If bHave Then Exit For
      '          Next k
      '        Next j
      '        If bHave Then
      '          ComboBoxOnLineStationInfo.Items.Add(CW.Maps(ModemIDMapNo).MapName & "��" & CW.Maps(ModemIDMapNo).Stations(ModemIDStationNo).StationName)
      '        Else
      '          ComboBoxOnLineStationInfo.Items.Add("��èIDû����վ��")
      '        End If
      '      End If

      '      'lstInfo = lstInfoB

      '      '---------------------------------------------------------
      '      '[[[[[[[[[[[[[[[[[[[[[[[[ԭ���������̴߳���[[[[[[[[[[[[[[[[[[[[
      '      If ChkRevTest.Checked Then '��ʾ�������ݵĿ���
      '        'Dim detail As New Detail

      '        ''threadChildArraylist.Add(detail.threadChild)
      '        'detail.setModemInfo(TModemInfo)
      '        'detail.setFrmMain(Me)
      '        ''���߳̿���
      '        'detail.threadChild.Start()
      '        ''���̹߳ر�
      '        'detail.threadChild.Join()
      '        'detail.threadChild.Abort()
      '        'detail.threadChild = Nothing
      '      End If
      '      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      '    Else
      '      'Form1.ListView1.ListItems.Remove(i + 1)
      '    End If
      '    '[[[[[[[[[[[[[[[[[[[[[[[[�ִ��������̴߳���[[[[[[[[[[[[[[[[[[[[
      '    '����join�����̣߳�����ֱ�����к�������
      '    'CheckRev(ASDBak, False)
      '    Application.DoEvents()

      '    ''(((((((((((((((((((((����������(((((((((((((((((((((((((((((((((((((((
      '    Try
      '      ThreadTSAsend = New ThreadStart(AddressOf CheckRevSub)
      '      ThreadASend = New Thread(ThreadTSAsend)
      '      Application.DoEvents()
      '      ThreadASend.Start()
      '      ThreadASend.Join()
      '      ThreadASend.Abort()
      '      ThreadASend = Nothing

      '    Catch ex As ThreadStateException
      '      MessageBox.Show("�߳�����::: " & ex.Message)
      '    End Try
      '    '')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))

      '    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
      '  Next i
      '  '((((((((((((((((((((((���������((((((((((((((((((((((((((((((((
      '  'Try
      '  '  ThreadTSAsend = New ThreadStart(AddressOf CheckRevSub)
      '  '  ThreadASend = New Thread(ThreadTSAsend)
      '  '  Application.DoEvents()
      '  '  ThreadASend.Start()
      '  '  ThreadASend.Join()
      '  '  ThreadASend.Abort()
      '  '  ThreadASend = Nothing

      '  'Catch ex As ThreadStateException
      '  '  MessageBox.Show("�߳�����::: " & ex.Message)
      '  'End Try
      '  ')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
      '  '''[[[[[[[[[[[[[[[[['''''''''''''ά���û������б���ش���'�����Ȳ�ɾ����saroû�����������
      '  'For i = 0 To lstInfo.Items.Count - 1
      '  '  If lstInfo.Items(i).Tag = "Del" Then
      '  '    lstInfo.Items(i).Remove()
      '  '  End If
      '  'Next
      '  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      'End If
      '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
    End If
    'Loop
  End Sub

  'Private Function SendOrderOne(ByVal ModemID As String, ByVal Data() As Byte) As String
  '  Dim sendResult As Int32
  '  Dim sendId As Int32
  '  Dim sendResultClen As Int32
  '  Dim sendResultSrc() As Byte

  '  'Dim sendResultSrc As Byte

  '  Dim i, j As Int32

  '  sendId = CType(Val("&H" & ModemID), Int32)

  '  sendResultSrc = New Byte(1451) {}

  '  sendResultClen = Data.Length
  '  For i = 0 To Data.Length - 1
  '    sendResultSrc(i) = Data(i)
  '  Next
  '  sendResult = GprsMod.DSSendData(sendId, sendResultClen, Data(0))


  '  If sendResult = 1 Then
  '    AddText("����ID��" & CStr(ModemID) & " ����ɹ���")
  '  Else
  '    AddText("����ID��" & CStr(ModemID) & " ����ʧ�ܣ�")
  '  End If
  'End Function

  Private Function existRecord(ByVal modemId As String, ByVal phoneNo As String) As Boolean
    '�ж����������Ƿ����ظ���¼��������Ӧ����
    Dim lvtCount As Integer = Me.lstInfo.Items.Count

    While lvtCount > 0
      Dim sModemInfo As String = Me.lstInfo.Items.Item(lvtCount - 1).SubItems.Item(0).Text
      Dim sPhoneNo As String = Me.lstInfo.Items.Item(lvtCount - 1).SubItems.Item(1).Text
      If modemId = sModemInfo And phoneNo = sPhoneNo Then
        ''''''''''[[[[[[[[[[[[[[[[['''''''''''''ά���û������б���ش���
        Me.lstInfo.Items.Item(lvtCount - 1).Tag = "Stay"
        ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        Return True '���������˳���
        'Exit Function
      End If
      lvtCount = lvtCount - 1
    End While
    Return False
  End Function
  Public Function ByteToIp(ByVal intip() As Byte) As Boolean
    '��̬IP����
    Dim ipstr As String = ""

    ipstr = ipstr & Str((intip(0) + 256) Mod 256)
    ipstr = ipstr & "."
    ipstr = ipstr & Str((intip(1) + 256) Mod 256)
    ipstr = ipstr & "."
    ipstr = ipstr & Str((intip(2) + 256) Mod 256)
    ipstr = ipstr & "."
    ipstr = ipstr & Str((intip(3) + 256) Mod 256)
    If ipstr <> "" Then
      ByteToIp = True
    Else
      ByteToIp = False
    End If
    'ByteToIp = ipstr
  End Function

  Private Sub ServiceStart()

    ''��ȡ�����ļ��ж˿ںŵ�����()
    'Dim ret As Long
    'Dim buff As String
    'buff = New String(" ", 100)
    'ret = GetPrivateProfileString("PORT", "port", "", buff, 100, Application.StartupPath & "\gprs.ini")
    'GlobalVal.SrvPort = CType(buff, Int32)

    GlobalVal.SrvPort = GlobalVal.getPort

    SetAddTextColor()

    Dim result As Boolean
    Dim flag As Int16 = 0 '������־��0ʧ�ܣ�1�ɹ�
    result = GprsMod.DSStartService(GlobalVal.SrvPort) '�����������񷽷�

    If (result) Then
      gifServiceStart.Visible = True
      gifServiceStart.ReadGIF(SGif.GifServiceStart)
      gifServiceStart.BringToFront()

      Me.AddText("�������ķ����������ɹ��� �˿ںţ�" + GlobalVal.SrvPort.ToString())
      txtPCount.Text = GlobalVal.SrvPort.ToString()
      flag = 1
    Else

      flag = 0
      Me.AddText("������������ʧ��")
      MessageBox.Show(GprsMod.DSGetLastError("", 50)) '��ʾ����ԭ��

    End If

    If (GlobalVal.SysAutoM = 1) Then

    End If

    If (flag = 1) Then

      'Me.startOrStop.Text = "����"
      'Me.btnStart.Enabled = False
      'Me.btnStop.Enabled = True
      'Me.btnConfig.Enabled = False
      'Me.btnExit.Enabled = True
      'Me.lineSplit.Enabled = True
      'Me.txtPCount.Text = "HZY"
    End If

    '���߳̿���
    bStop = False
    ThreadMethodMain()
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'bStop = False
    'Try
    '  'ThreadStart ί�У�������msn�ϲ飢ThreadStart ί�У�������about()�����߳���Դ��
    '  threadDelegateMain = New ThreadStart(AddressOf ThreadMethodMain)
    '  'threadMain = New Thread(threadDelegateMain)
    '  threadMain = New Thread(AddressOf ThreadMethodMain)
    '  'threadMain.Priority = ThreadPriority.Highest
    '  threadMain.Start()

    'Catch ex As ThreadStateException
    '  MessageBox.Show("threadMain.start::: " & ex.Message)
    'End Try
  End Sub
  Private Sub SetAddTextColor()
    If bAddText Then
      txtInfo.SelectionStart = Len(txtInfo.Text)
      txtInfo.SelectionColor = AddTextColor1
      bAddText = False
    Else
      txtInfo.SelectionStart = Len(txtInfo.Text)
      txtInfo.SelectionColor = AddTextColor2
      bAddText = True
    End If
  End Sub
  Public Sub AddText(ByVal Content As String)

    If (GlobalVal.LineCount > 600) Then
      Me.txtInfo.Text = ""
      GlobalVal.LineCount = 0
    End If

    Me.txtInfo.Focus()
    If (Me.txtInfo.Text = "") Then
      Me.txtInfo.Text = Content
    Else
      Me.txtInfo.AppendText(ControlChars.Cr + Content)

      'Me.txtInfo.Text += ControlChars.Cr + Content
      txtInfo.SelectionStart = Len(txtInfo.Text)
      GlobalVal.LineCount += 1

    End If

  End Sub

  Private Sub ServiceEnd()
    Dim result As Long
    'Dim closeonemess As Byte
    gifServiceStart.Visible = True = False
    result = GprsMod.DSStopService()

    SetAddTextColor()

    If result = 9222812402616107009 Then
      Me.AddText("�������ķ�����ֹͣ�ɹ���")
    Else
      Me.AddText("�������ķ�����ֹͣ�ɹ���") '("��������ֹͣʧ�ܣ�")
    End If
    Me.lstInfo.Items.Clear()
    ComboBoxOnLineStationInfo.Items.Clear()
    'Me.startOrStop.Text = "ֹͣ"
    'Me.btnStart.Enabled = True
    'Me.btnStop.Enabled = False
    'Me.btnConfig.Enabled = True
    'Me.btnExit.Enabled = True
    'Me.lineSplit.Enabled = True
    '���̹߳ر�
    'threadChildArraylist = Nothing
    bStop = True
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%555
    'Try
    '  'threadMain.Join()
    '  threadMain.Abort()
    '  Me.AddText("���̹߳رգ�")
    'Catch ex As ThreadStateException
    '  MessageBox.Show("threadMain.abort::: " & ex.Message)
    'End Try
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    'ListView���
    lstInfo.Items.Clear()

  End Sub

  ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

  Public Function SetPerson() As Boolean
    RWUsersIni(True)
  End Function
  'Private Sub SetGPRSWork(ByVal F As Form)
  '�ŵ�ģ�����ˣ���Ϊ���й���
  'End Sub
  Private Function SaveLoginInfoINI(ByVal UserNo As Short, ByVal PerLogin As Short, ByVal SavePws As Short) As Boolean
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    Dim i, j As Integer

    If UserNo < 1 Or PerLogin < 0 Or SavePws < 0 Then Exit Function

    SPath = GetAppPath() & "\" & AppConfig_FilesName

    With PINI

      .FileName = SPath
      .AppName = "UserAmount"
      .KeyName = "Amount"
      S = .ReadINI(RWini_BZString)
      If S = "" Then
        Exit Function
      End If

      If IsNumeric(S) Then
        j = CSng(S)
        If j < 1 Then Exit Function
      Else
        Exit Function
      End If

      If UserNo > j Then Exit Function

      For i = 1 To j

        .FileName = SPath
        .AppName = "User" & CStr(i)
        .KeyName = "PerLogin"
        If i = UserNo Then
          If PerLogin > 0 Then
            .ValueStr = "1"
          Else
            .ValueStr = "0"
          End If
        Else
          .ValueStr = "0"
        End If
        .WriteINI(RWini_BZString)

        .FileName = SPath
        .AppName = "User" & CStr(i)
        .KeyName = "SavePws"
        If i = UserNo Then
          If SavePws > 0 Then
            .ValueStr = "1"
          Else
            .ValueStr = "0"
          End If
        End If
        .WriteINI(RWini_BZString)

      Next i

    End With
  End Function
  Public Sub SetLocationActivePerson()
    Dim i, MJ As Integer

    Me.Controls.Add(PanelPassword)
    PanelPassword.BringToFront()
    'TabControl1.SendToBack()
    'PanelToolBar.SendToBack()
    PanelPassword.Location = New Point(0, 0)
    PanelPassword.Width = 1024
    PanelPassword.Height = 700
    Try
      PanelPassword.BackgroundImage = Image.FromFile(GetAppPath() & "\Resource\Login.jpg")
    Catch ex As Exception
      'MessageBox.Show(ex.StackTrace.ToString)
    End Try

    ComboBoxPersonName.Items.Clear()
    ComboBoxPersonName.Text = ""
    For i = 1 To AUsers.UserAmount
      ComboBoxPersonName.Items.Add(AUsers.Users(i).Name)
    Next i

    MJ = 0
    For i = 1 To AUsers.UserAmount
      If AUsers.Users(i).PerLogin = 1 Then
        MJ = i
        ComboBoxPersonName.SelectedIndex = i - 1
        Exit For
      End If
    Next i

    If MJ = 0 Then '''''''''''''''''''''''''''''''''''''���û���ϴε�¼�û�
      CheckBoxPassword.Checked = False
      ComboBoxPersonName.SelectedIndex = 0
    ElseIf MJ > 1 Then ''''''''''''''''''''''''''''''''''������ϴε�¼�û������Ҳ��ǹ���Ա
      If AUsers.Users(MJ).SavePws = 1 Then '''''''''''''''������ǹ���Ա���û��б�������
        TextBoxPassword.Text = AUsers.Users(MJ).Password
        CheckBoxPassword.Checked = True
      Else
        TextBoxPassword.Text = ""
        CheckBoxPassword.Checked = False
      End If
    End If

    Me.Location = New Point(0, 0)
    'AniGIFPassword.ReadGIF(CW.WorkPath & "\images\GEARS.GIF")
  End Sub
  Private Sub DumpPmVer()
    Dim WAppVer As New GprsRWini
    Dim S As String = ""
    If PM.VerMode = "Demo" Then
      S = "��ʾ��"
    ElseIf PM.VerMode = "Public" Then
      S = "��ʽ��"
    End If
    Try
      WAppVer.FileName = GetAppPath() & "\" & AppVer_FileName
      WAppVer.AppName = "VER"
      WAppVer.KeyName = "AppVer"
      WAppVer.ValueStr = "�汾��" & S & " Ver1.0.0 Build " & PM.VerNum
      WAppVer.WriteINI(RWini_BZString)
    Catch ex As Exception

    End Try
  End Sub
  Private Sub SetLocation()
    'If cw.active = False Then Exit Sub
    Dim i As Integer
    If Form1Active = False Then
      'Me.Controls.Add(PanelPassword)
      'PanelPassword.BringToFront()
      ''TabControl1.SendToBack()
      ''PanelToolBar.SendToBack()
      'PanelPassword.Location = New Point(0, 0)
      'PanelPassword.Width = 1024
      'PanelPassword.Height = 700
      'PanelPassword.BackgroundImage = Image.FromFile(CW.WorkPath & "\images\desktop_257.jpg")
      'Me.Location = New Point(0, 0)
      ''AniGIFPassword.ReadGIF(CW.WorkPath & "\images\GEARS.GIF")
      DoUDTXDataMode.SelectedIndex = 0

    End If
    Try
      SGif.Cur(0) = New Cursor(GetAppPath() & "\Resource\hand-0.cur")
    Catch ex As Exception
      SGif.Cur(0) = System.Windows.Forms.Cursors.Hand
    End Try

    Try
      SGif.Cur(1) = New Cursor(GetAppPath() & "\Resource\hand-1.cur")
    Catch ex As Exception
      SGif.Cur(1) = System.Windows.Forms.Cursors.Hand
    End Try

    Try
      SGif.Cur(2) = New Cursor(GetAppPath() & "\Resource\cross.cur")
    Catch ex As Exception
      SGif.Cur(2) = System.Windows.Forms.Cursors.Cross
    End Try

    With ComboBoxSelectMap0
      .Items.Clear()
      For i = 1 To CW.MapAmount
        .Items.Add(CW.Maps(i).MapName)
        'ComboBoxSelectMap1.Items.Add(CW.Maps(i).MapName)
      Next i
      If .Items.Count > 0 Then
        .SelectedIndex = CW.MapNo - 1
        'ComboBoxSelectMap1.SelectedIndex = CW.MapNo - 1
      End If
    End With

    Try
      SGif.GifFilePath_OK = GetAppPath() & "\Resource\32Station.gif"
    Catch ex As Exception

    End Try

    Try
      SGif.GifFilePath_Alarm = GetAppPath() & "\Resource\32Alarm.gif"
    Catch ex As Exception

    End Try

    Try
      SGif.GifServiceStart = GetAppPath() & "\Resource\ServiceStart.gif"
    Catch ex As Exception

    End Try

    Try
      SGif.GifNoLooked = GetAppPath() & "\Resource\RevDataNoLooked.GIF"
    Catch ex As Exception

    End Try

    Try
      SGif.GifMSendStart = GetAppPath() & "\Resource\MSendStart.gif"
    Catch ex As Exception

    End Try

    Try
      SGif.GifMsendStop = GetAppPath() & "\Resource\MSendStop.gif"
    Catch ex As Exception

    End Try

    Try
      SGif.EaglEyeRedDot = GetAppPath() & "\Resource\EaglEyeRedDot.gif"
    Catch ex As Exception

    End Try

    Try
      SGif.GifAsend = GetAppPath() & "\Resource\Asend.gif"
      AxAniGIFAsend.ReadGIF(SGif.GifAsend)
      AxAniGIFAsend.AutoSize = True
      AxAniGIFAsend.Top = 4
      AxAniGIFAsend.Left = 820
      'AxAniGIFAsend.Visible = True
    Catch ex As Exception

    End Try

    Try
      SGif.GifOnLine = GetAppPath() & "\Resource\OnLine.gif"
      AxAniGIFOnLine.ReadGIF(SGif.GifOnLine)
      AxAniGIFOnLine.Top = 24
      AxAniGIFOnLine.Left = 856
      'AxAniGIFOnLine.Visible = True
    Catch ex As Exception

    End Try


    AxShockwaveFlashMainForm.BackgroundColor = 15723486
    Dim X, Y As Integer
    X = TabShowMap.Width - 180
    Y = 180
    AxShockwaveFlashMainForm.Height = 150
    AxShockwaveFlashMainForm.Width = 150
    AxShockwaveFlashMainForm.Location = New Point(X, Y)
    AxShockwaveFlashMainForm.BringToFront()

    AddTextColor1 = System.Drawing.Color.ForestGreen
    AddTextColor2 = System.Drawing.Color.Red

    PicboxStation.Location = New Point(0, 0)

    For i = 1 To STATION_MAX_NO
      EaglEyeRedDotGif(i) = New AxAniGIFCtrl.AxAniGIF
      'EaglEyeRedDotGif(i).Parent = PanelTmp
      'EaglEyeRedDotGif(i).Visible = False
    Next i

    DumpPmVer()

    Form1Active = True

  End Sub

  Private Function PicBoxMapLoadMap(ByVal MNo As Short) As Boolean
    If CW.Active = False Then Exit Function

    With PicBoxMap
      '.SizeMode = PictureBoxSizeMode.AutoSize
      .Location = New Point(0, 0)
      Dim S As String
      S = CW.Maps(MNo).MapPath
      Try
        .Image = Image.FromFile(S)
      Catch ex As Exception
        S = GetAppPath() & "\Images\maperror.jpg"
        .Image = Image.FromFile(S)
      End Try

      bMoMove = False
      bMoPointChangED = False

      PanelPicBoxMapMove.Size = .Image.Size

      PanelPicBoxMapMove.Location = New Point(0, 0)

      If (PanelPicBoxMapMove.Height <> PanelPicBoxMap.Height) Or (PanelPicBoxMapMove.Width <> PanelPicBoxMap.Width) Then
        bMoMove = True
        bMoPointChangED = False
      End If

      .SizeMode = PictureBoxSizeMode.StretchImage

    End With
  End Function

  Private Sub EaglEye(ByVal Initialization As Boolean)
    If CW.Active = False Then Exit Sub
    Dim B, TB As Double
    If Initialization Then
      PanelPicBoxEaglEye.Visible = False
      PicBoxEaglEye.Image = PicBoxMap.Image
      PicBoxEaglEye.SizeMode = PictureBoxSizeMode.StretchImage
      PanelPicBoxEaglEye.Size = PicBoxEaglEye.Image.Size
      B = PanelPicBoxEaglEye.Width / PanelPicBoxEaglEye.Height
      TB = PanelEaglEye.Width / PanelEaglEye.Height
      If B > TB Then
        TB = PanelEaglEye.Width / PanelPicBoxEaglEye.Width
        PanelPicBoxEaglEye.Width = PanelEaglEye.Width
        PanelPicBoxEaglEye.Height = PanelPicBoxEaglEye.Height * TB
        PanelPicBoxEaglEye.Left = 0
        PanelPicBoxEaglEye.Top = (PanelEaglEye.Height - PanelPicBoxEaglEye.Height) / 2
      Else
        TB = PanelEaglEye.Height / PanelPicBoxEaglEye.Height
        PanelPicBoxEaglEye.Height = PanelEaglEye.Height
        PanelPicBoxEaglEye.Width = PanelPicBoxEaglEye.Width * TB
        PanelPicBoxEaglEye.Top = 0
        PanelPicBoxEaglEye.Left = (PanelEaglEye.Width - PanelPicBoxEaglEye.Width) / 2
      End If
      bPicBoxEaglEyeED = True
      PanelPicBoxEaglEye.Visible = True
      'PicBoxEaglEye.CreateControl()
      'SetEaglEyeRedDotGif()
    Else

      With PointPicNew

        If PanelPicBoxMap.Height < PanelPicBoxMapMove.Height Then
          If .Y > 0 Then .Y = 0
          If -.Y + PanelPicBoxMap.Height > PanelPicBoxMapMove.Height Then .Y = PanelPicBoxMap.Height - PanelPicBoxMapMove.Height
        Else
          If .Y + PanelPicBoxMapMove.Height > PanelPicBoxMap.Height Then
            .Y = PanelPicBoxMap.Height - PanelPicBoxMapMove.Height
          End If
          If .Y < 0 Then .Y = 0
        End If

        If PanelPicBoxMap.Width < PanelPicBoxMapMove.Width Then
          If .X > 0 Then .X = 0
          If -.X + PanelPicBoxMap.Width > PanelPicBoxMapMove.Width Then .X = PanelPicBoxMap.Width - PanelPicBoxMapMove.Width
        Else
          If .X + PanelPicBoxMapMove.Width > PanelPicBoxMap.Width Then
            .X = PanelPicBoxMap.Width - PanelPicBoxMapMove.Width
          End If
          If .X < 0 Then .X = 0
        End If

      End With

    End If

    PicBoxEaglEye.Cursor = System.Windows.Forms.Cursors.Cross

    '"""""""""""""""""""""""""""""""""""""""""""""""""""�����Ժ����ӥ���ж�λ�����
    'PicBoxEaglEye()
    'setEaglEyeRedDot()
  End Sub
  Private Sub SetEaglEyeRedDotGif()

    Dim XX, YY, i As Integer
    Dim tmpPoint As New Point

    'ReDim EaglEyeRedDot(STATION_MAX_NO)
    With CW.Maps(CW.MapNo)
      For i = 1 To STATION_MAX_NO

        'EaglEyeRedDotGif(i) = New AxAniGIFCtrl.AxAniGIF����˸��Ԫ�ף��ŵ�SetLocation����
        If Not (PanelPicBoxEaglEye.Contains(EaglEyeRedDotGif(i))) Then
          EaglEyeRedDotGif(i).Parent = PanelPicBoxEaglEye
          EaglEyeRedDotGif(i).Visible = False
          EaglEyeRedDotGif(i).ReadGIF(SGif.EaglEyeRedDot)
          EaglEyeRedDotGif(i).AutoSize = True
          EaglEyeRedDotGif(i).Tag = i
          AddHandler EaglEyeRedDotGif(i).MouseMoveEvent, AddressOf AxAniGIFRedDotHandel_MouseMoveEvent
          AddHandler EaglEyeRedDotGif(i).ClickEvent, AddressOf AxAniGIFRedDotHandel_ClickEvent
          AddHandler EaglEyeRedDotGif(i).DblClick, AddressOf AxAniGIFRedDotHandel_DblClick
          AddHandler EaglEyeRedDotGif(i).MouseUpEvent, AddressOf AxAniGIFRedDotHandel_MouseUpEvent
        Else
          EaglEyeRedDotGif(i).Visible = False
        End If

        If i <= .MapStationPlacedAmount Then
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          XX = .Stations(i).StationLocation.X
          YY = .Stations(i).StationLocation.Y
          tmpPoint.X = (XX / STATION_LOCATION_OFFSET) * PanelPicBoxEaglEye.Width - 1 + PicBoxEaglEye.Left
          tmpPoint.Y = (YY / STATION_LOCATION_OFFSET) * PanelPicBoxEaglEye.Height - 1 + PicBoxEaglEye.Top
          EaglEyeRedDotGif(i).Location = tmpPoint
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          EaglEyeRedDotGif(i).BringToFront()
          EaglEyeRedDotGif(i).Visible = True
          'EaglEyeRedDot(i).Play()
        Else

        End If
      Next i

    End With

  End Sub

  Private Sub FDSX(ByVal FS As Boolean, ByVal HY As Boolean)
    'True,FalseΪ�Ŵ�False,TrueΪ��С
    'True,True�ǻ�ԭ��False,Fslse�������м��
    If CW.Active = False Then Exit Sub
    Dim X, Y, i As Integer
    PicBoxMap.SizeMode = PictureBoxSizeMode.StretchImage

    Select Case FS
      Case True
        If HY = False Then '"""""""""""""""""""""""""""""""""""�Ŵ�
          If PicBoxMapFDSX_No <= 10 And PicBoxMapFDSX_No > 1 Then
            PicBoxMapFDSX_No = PicBoxMapFDSX_No - 1
            If PicBoxMapFDSX_No < 1 Then
              PicBoxMapFDSX_No = 1
              Exit Sub
            End If
            X = PicBoxMap.Width * FDSX_FD_PEC
            Y = PicBoxMap.Height * FDSX_FD_PEC
            PicBoxMapFDSX(PicBoxMapFDSX_No).X = X
            PicBoxMapFDSX(PicBoxMapFDSX_No).Y = Y
            PanelPicBoxMapMove.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PicBoxMap.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PanelPicBoxMapMove.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            'PicBoxMapFDSX_No = PicBoxMapFDSX_No - 1
            PicBoxMap.SizeMode = PictureBoxSizeMode.StretchImage
            'If PicBoxMapFDSX_No < 1 Then PicBoxMapFDSX_No = 1
            '((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
            Label2.Text = PicBoxMap.Height.ToString
            Label3.Text = PicBoxMap.Width.ToString
            Label1.Text = PicBoxMapFDSX_No
            '))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
          ElseIf PicBoxMapFDSX_No > 10 Then
            PicBoxMapFDSX_No = PicBoxMapFDSX_No - 1
            PanelPicBoxMapMove.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PicBoxMap.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PanelPicBoxMapMove.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.SizeMode = PictureBoxSizeMode.StretchImage
            '((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
            Label2.Text = PicBoxMap.Height.ToString
            Label3.Text = PicBoxMap.Width.ToString
            Label1.Text = PicBoxMapFDSX_No
            '))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
          End If
        Else  '""""""""""""""""""""""""""""""""""""""""""��ԭ
          PicBoxMapFDSX_No = 10
          PanelPicBoxMapMove.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
          PicBoxMap.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
          PanelPicBoxMapMove.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
          PicBoxMap.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
          PanelPicBoxMapMove.Top = 0
          PanelPicBoxMapMove.Left = 0
          PicBoxMap.SizeMode = PictureBoxSizeMode.StretchImage
          '((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
          Label2.Text = PicBoxMap.Height.ToString
          Label3.Text = PicBoxMap.Width.ToString
          Label1.Text = PicBoxMapFDSX_No
          '))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
        End If

      Case False '"""""""""""""""""""""""""""""""""""��С'""""""""""""""�ü������Ʊ߽�Ĵ���--�Ѽ���
        If HY = True Then
          If PicBoxMapFDSX_No >= 10 And PicBoxMapFDSX_No < 19 Then
            PicBoxMapFDSX_No = PicBoxMapFDSX_No + 1
            If PicBoxMapFDSX_No > 19 Then
              PicBoxMapFDSX_No = 19
              Exit Sub
            End If
            X = PicBoxMap.Width * FDSX_SX_PEC
            Y = PicBoxMap.Height * FDSX_SX_PEC
            PicBoxMapFDSX(PicBoxMapFDSX_No).X = X
            PicBoxMapFDSX(PicBoxMapFDSX_No).Y = Y
            PanelPicBoxMapMove.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PicBoxMap.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PanelPicBoxMapMove.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.SizeMode = PictureBoxSizeMode.StretchImage

            PointPicNew.X = PanelPicBoxMapMove.Left
            PointPicNew.Y = PanelPicBoxMapMove.Top
            EaglEye(False)
            PanelPicBoxMapMove.Location = PointPicNew
            'PicBoxMapFDSX_No = PicBoxMapFDSX_No + 1
            'If PicBoxMapFDSX_No > 19 Then PicBoxMapFDSX_No = 19
            '((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
            Label2.Text = PicBoxMap.Height.ToString
            Label3.Text = PicBoxMap.Width.ToString
            Label1.Text = PicBoxMapFDSX_No
            ')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))

          ElseIf PicBoxMapFDSX_No < 10 Then

            PicBoxMapFDSX_No = PicBoxMapFDSX_No + 1
            PanelPicBoxMapMove.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PicBoxMap.Height = PicBoxMapFDSX(PicBoxMapFDSX_No).Y
            PanelPicBoxMapMove.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.Width = PicBoxMapFDSX(PicBoxMapFDSX_No).X
            PicBoxMap.SizeMode = PictureBoxSizeMode.StretchImage

            PointPicNew.X = PanelPicBoxMapMove.Left
            PointPicNew.Y = PanelPicBoxMapMove.Top
            EaglEye(False)
            PanelPicBoxMapMove.Location = PointPicNew
            '(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
            Label2.Text = PicBoxMap.Height.ToString
            Label3.Text = PicBoxMap.Width.ToString
            Label1.Text = PicBoxMapFDSX_No
            '))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
          End If
        Else '""""""""""""""""""""""""""""""""""�����м��,�Ժ���ini�ļ��м�¼ÿ����ͼ��Ĭ�����ű���
          PicBoxMapFDSX_No = 10
          PicBoxMapFDSX(PicBoxMapFDSX_No).Y = PanelPicBoxMapMove.Height
          PicBoxMapFDSX(PicBoxMapFDSX_No).X = PanelPicBoxMapMove.Width
        End If
    End Select

    'If FS = False And HY = False Then Exit Sub
    With CW.Maps(CW.MapNo) '���¼���վ�����λ��
      For i = 1 To .MapStationPlacedAmount
        X = (PanelPicBoxMapMove.Width / STATION_LOCATION_OFFSET) * .Stations(i).StationLocation.X
        Y = (PanelPicBoxMapMove.Height / STATION_LOCATION_OFFSET) * .Stations(i).StationLocation.Y
        .Stations(i).Location = New Point(X - PLACE_STATION_OFFSET, Y - PLACE_STATION_OFFSET)
      Next
    End With
  End Sub
  Private Sub ShowStationGif(ByVal StationNo As Integer, ByVal Show As Boolean)
    'ʵ����ʾվ���ͼ�ζ������� PicboxMapDrawStation() �з������
    'StationNo��ǰ��ͼ�ĵڼ���վ
    '��һ�η��û��߶�ȡλ����ʾ
    If CW.Active = False Then Exit Sub
    Dim X, Y As Integer
    Dim tB As Boolean

    With CW.Maps(CW.MapNo).Stations(StationNo)

      tB = PanelPicBoxMapMove.Contains(.StationGif)
      'S = .StationGif.Parent.Name

      If tB Then

        .StationGif.Enabled = Show
        .StationGif.Visible = Show
        .ToolTap = False

      Else

        'PanelPicBoxMapMove.Controls.Add(.StationGif)
        'PanelPicBoxMapMove.Controls.Add(.pLabelToolTip)
        .StationGif.Parent = PanelPicBoxMapMove
        .pLabelToolTip.Parent = PanelPicBoxMapMove

        .pLabelToolTip.BringToFront()
        .pLabelToolTip.Visible = True

        If .StationLocation.X = -1 Then
          .StationGif.Location = New Point(PointStationPlace.X - PLACE_STATION_OFFSET, PointStationPlace.Y - PLACE_STATION_OFFSET)  '�����˾���λ�ú�
          X = (PointStationPlace.X / PanelPicBoxMapMove.Width) * STATION_LOCATION_OFFSET
          Y = (PointStationPlace.Y / PanelPicBoxMapMove.Height) * STATION_LOCATION_OFFSET
          .StationLocation = New Point(X, Y) '���������λ��
        Else
          X = (.StationLocation.X / STATION_LOCATION_OFFSET) * PanelPicBoxMapMove.Width - PLACE_STATION_OFFSET
          Y = (.StationLocation.Y / STATION_LOCATION_OFFSET) * PanelPicBoxMapMove.Height - PLACE_STATION_OFFSET
          .StationGif.Location = New Point(X, Y)  'һ��ü��ϱ������㣻�Ѿ������ˣ����λ��ת��Ϊ����λ��
        End If

        AddHandler .StationGif.MouseMoveEvent, AddressOf AniGifMainForm_MouseMoveEvent
        AddHandler .StationGif.ClickEvent, AddressOf AniGifMainForm_ClickEvent
        AddHandler .StationGif.DblClick, AddressOf AniGifMainForm_DblClick
        AddHandler .StationGif.MouseUpEvent, AddressOf AniGifMainForm_MouseUpEvent

        With CW.Maps(CW.MapNo).Stations(StationNo).StationGif
          .Enabled = Show
          .AutoSize = False
          .Transparent = True
          .Height = 32
          .Width = 32
          .Stretch = 0
          .ReadGIF(SGif.GifFilePath_OK)
          .Show()
          .Visible = Show
          .Playing = CW.Maps(CW.MapNo).Stations(StationNo).Active
          .BringToFront()
        End With

      End If

    End With
  End Sub
  Private Sub PicboxMapDrawStation()
    'PicBoxMap.CreateGraphics.DrawIcon(New Icon(GetAppPath() & CW.WorkName & "\images\16Station.ico"), .X, PointStationPlace.Y)
    If CW.Active = False Then Exit Sub

    If CW.Maps(CW.MapNo).MapStationPlacedAmount < STATION_MAX_NO Then
      'PlaceSNo = PlaceSNo + 1

      If CW.Maps(CW.MapNo).AddStation() Then

        ShowStationGif(CW.Maps(CW.MapNo).MapStationPlacedAmount, True)

        'PanelPicBoxMapMove.Controls.Add(CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationGif) '@@@
        'PanelPicBoxMapMove.Controls.Add(CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).pLabelToolTip) '@@@

        With CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount)

          '.pLabelToolTip.Visible = False

          '.Location = New Point(PointStationPlace.X - PLACE_STATION_OFFSET, PointStationPlace.Y - PLACE_STATION_OFFSET)

          'AddHandler (CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationGif.MouseMoveEvent), AddressOf AniGifMainForm_MouseMoveEvent
          'AddHandler (CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationGif.ClickEvent), AddressOf AniGifMainForm_ClickEvent
          'AddHandler (CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationGif.DblClick), AddressOf AniGifMainForm_DblClick
          'AddHandler (CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationGif.MouseUpEvent), AddressOf AniGifMainForm_MouseUpEvent '''''''''''''''�治����200503140203@@@@
          .DBed = False
          .HaveData = False
          .LookedRevNewData = False
          .RevNewData = False
          .Saved = False
          .Active = False 'վ�㻹û�м���
          .StationModeIndex = 1
          .StationIndex = CW.Maps(CW.MapNo).MapStationPlacedAmount
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          'Ĭ�ϲ���
          'CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).Active = True
          .StationName = "��" & CW.Maps(CW.MapNo).MapStationPlacedAmount.ToString & "��վ"
          .pLabelToolTip.Visible = True
          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          '����200505030137
          '.TestDate = ""
          '.TestTime = ""�ָ���������

          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          Dim i As Integer
          For i = 1 To .StationParameterAmount

            Select Case i
              '�����ŵ�ini�ļ���config.dll
              Case 1
                .StationParameters(i, 0) = "һ������ˮѹ��"
                .StationParameters(i, 2) = "����"
              Case 2
                .StationParameters(i, 0) = "һ������ˮ�¶�"
                .StationParameters(i, 2) = "���϶�"
              Case 3
                .StationParameters(i, 0) = "��������ˮѹ��"
                .StationParameters(i, 2) = "����"
              Case 4
                .StationParameters(i, 0) = "��������ˮ�¶�"
                .StationParameters(i, 2) = "���϶�"
              Case 5
                .StationParameters(i, 0) = "��������ˮѹ��"
                .StationParameters(i, 2) = "����"
              Case 6
                .StationParameters(i, 0) = "��������ˮ�¶�"
                .StationParameters(i, 2) = "���϶�"
              Case 7
                .StationParameters(i, 0) = "һ������ˮѹ��"
                .StationParameters(i, 2) = "����"
              Case 8
                .StationParameters(i, 0) = "һ������ˮ�¶�"
                .StationParameters(i, 2) = "���϶�"
              Case 9
                .StationParameters(i, 0) = "��ˮ����"
                .StationParameters(i, 2) = "������/��"
              Case 10
                .StationParameters(i, 0) = "��������"
                .StationParameters(i, 2) = "������/��"
              Case 11

            End Select

          Next i
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        End With

        'With CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationGif
        '  '.Location = New Point(PointStationPlace.X - PLACE_STATION_OFFSET, PointStationPlace.Y - PLACE_STATION_OFFSET)
        '  .AutoSize = False
        '  '.Anchor = AnchorStyles.None
        '  '.Dock = DockStyle.None
        '  .Transparent = True
        '  .Height = 32
        '  .Width = 32
        '  .Stretch = 0
        '  '.Tag = CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationIndex '��Ϊ���ʱ��ʶ��---200503150404 �ŵ���������
        '  .ReadGIF(SGif.GifFilePath_OK)
        '  '.Playing = True
        '  .Show()
        '  .BringToFront()

        'End With '@@@@@@@

        'X = (PointStationPlace.X / PanelPicBoxMapMove.Width) * STATION_LOCATION_OFFSET
        'Y = (PointStationPlace.Y / PanelPicBoxMapMove.Height) * STATION_LOCATION_OFFSET
        'CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).MapStationPlacedAmount).StationLocation = New Point(X, Y) '@@@@@@@@

        'TabShowMap.Controls.Add(GroupBoxAboutStation)
        PanelPicBoxMapMove_MoveToSelectStation_Alow = False
        SetMapStationSelectComboBox("s")
        'SetTabStationInfo(CW.Maps(CW.MapNo).MapStationPlacedAmount)
        PanelPicBoxMapMove_MoveToSelectStation_Alow = False
        ComboBoxSelectStation.SelectedIndex = CW.Maps(CW.MapNo).MapStationPlacedAmount - 1
        'PanelPicBoxMapMove_MoveToSelectStation_Alow = False
        'GroupBoxAboutStation.Location = New Point(808, 160)
        'ComboBoxSelectStation.SelectedIndex = CSng(sender.tag)

      End If
    End If

  End Sub
  Private Function ShowStationParameter(ByVal MapNo As Integer, ByVal SNo As Integer) As Boolean
    Dim i, j, k As Integer

    Dim MyCs As New ControlShowParameterNew

    If CW.Active = False Then Exit Function
    If CW.Maps(MapNo).MapStationPlacedAmount < 1 Then Exit Function
    With CW.Maps(MapNo).Stations(SNo)
      .LookedRevNewData = True
      If .Active = False Then
        ''''''''''''''''''''''''''''''�Ժ󿴿�Ӧ��������ʾվ�㻹û�м���
        'Exit Function
      End If

      'Dim MyControls As GPRS.ControlShowParameter
      'For Each MyControls In Me.Controls
      '  For j = 1 To .StationParameterAmount
      '    If MyControls.Tag = "p" & CStr(j) Then
      '      If IsNumeric(.StationParameters(j, 1)) Then
      '        MyControls.BackColor = System.Drawing.Color.Gold
      '        If IsNumeric(.StationParameters(j, 3)) Then
      '          If CSng(.StationParameters(j, 3)) < CSng(.StationParameters(j, 1)) Then
      '            MyControls.BackColor = System.Drawing.Color.LightPink
      '          End If
      '        End If
      '      Else
      '        MyControls.BackColor = System.Drawing.Color.White
      '      End If
      '      MyControls.ParameterName = Trim(.StationParameters(j, 0)) & "��"
      '      MyControls.Text = Trim(.StationParameters(j, 1))
      '      MyControls.PartName = Trim(.StationParameters(j, 2))
      '      Exit For
      '    End If
      '  Next j
      'Next

      For i = 1 To PanelStation.Controls.Count

        If PanelStation.Controls(i - 1).GetType.ToString = "GPRS.ControlShowParameterNew" Then

          MyCs = PanelStation.Controls(i - 1)
          MyCs.Visible = False
          For j = 1 To .StationParameterAmount
            If MyCs.Name = "CS" & CStr(j) Then
              MyCs.Visible = True
              If IsNumeric(.StationParameters(j, 1)) Then
                MyCs.OK()
                'MyCs.FontBackColor = System.Drawing.Color.SteelBlue
                If IsNumeric(.StationParameters(j, 3)) Then
                  If CSng(.StationParameters(j, 3)) < CSng(.StationParameters(j, 1)) Then
                    MyCs.Alarm()
                    'MyCs.FontBackColor = System.Drawing.Color.Red
                    'MyCs.BackColor = System.Drawing.Color.LightPink
                  End If
                End If
              Else
                MyCs.NoIdea()
                'MyCs.FontBackColor = System.Drawing.Color.White
                'MyCs.BackColor = System.Drawing.Color.White
              End If

              MyCs.ParameterName = Trim(.StationParameters(j, 0)) & "��"
              MyCs.ValueString = Trim(.StationParameters(j, 1))
              MyCs.PartName = Trim(.StationParameters(j, 2))

              'MyCs.Text = Trim(.StationParameters(j, 0)) & ":" & Trim(.StationParameters(j, 1)) & Trim(.StationParameters(j, 2))
              Exit For
            End If
          Next j

        End If
      Next i

      '[[[[[[[[[[[[[[[[[[[[20080106��ȡ��������������Ϣ[[[[[[[[

      For i = 1 To STATION_PROPERTY_MAX_NO
        lblSendMessageName1.Visible = False
        TextBoxSendMessage1.Visible = False
        lblSendMessageDanWei1.Visible = False

        lblSendMessageName2.Visible = False
        TextBoxSendMessage2.Visible = False
        lblSendMessageDanWei2.Visible = False

        lblSendMessageName3.Visible = False
        TextBoxSendMessage3.Visible = False
        lblSendMessageDanWei3.Visible = False

        lblSendMessageName4.Visible = False
        TextBoxSendMessage4.Visible = False
        lblSendMessageDanWei4.Visible = False

        lblSendMessageName5.Visible = False
        TextBoxSendMessage5.Visible = False
        lblSendMessageDanWei5.Visible = False

        lblSendMessageName6.Visible = False
        TextBoxSendMessage6.Visible = False
        lblSendMessageDanWei6.Visible = False

        lblSendMessageName7.Visible = False
        TextBoxSendMessage7.Visible = False
        lblSendMessageDanWei7.Visible = False

        lblSendMessageName8.Visible = False
        TextBoxSendMessage8.Visible = False
        lblSendMessageDanWei8.Visible = False

        lblSendMessageName9.Visible = False
        TextBoxSendMessage9.Visible = False
        lblSendMessageDanWei9.Visible = False

        lblSendMessageName10.Visible = False
        TextBoxSendMessage10.Visible = False
        lblSendMessageDanWei10.Visible = False
      Next i

      Try
        k = StationDataInfo.StationModeInfo(CW.Maps(MapNo).Stations(SNo).StationModeIndex).SendMessageHowMany
        For i = 0 To GroupBoxSendMessage.Controls.Count - 1
          For j = 1 To k
            If GroupBoxSendMessage.Controls(i).Name = "lblSendMessageName" & CStr(j) Then
              GroupBoxSendMessage.Controls(i).Text = StationDataInfo.StationModeInfo(CW.Maps(MapNo).Stations(SNo).StationModeIndex).SendMessageName(j) & "��"
              GroupBoxSendMessage.Controls(i).Visible = True
            End If
            If GroupBoxSendMessage.Controls(i).Name = "lblSendMessageDanWei" & CStr(j) Then
              GroupBoxSendMessage.Controls(i).Text = StationDataInfo.StationModeInfo(CW.Maps(MapNo).Stations(SNo).StationModeIndex).SendMessageDanWei(j)
              GroupBoxSendMessage.Controls(i).Visible = True
            End If
            If GroupBoxSendMessage.Controls(i).Name = "TextBoxSendMessage" & CStr(j) Then
              GroupBoxSendMessage.Controls(i).Text = CStr(CW.Maps(MapNo).Stations(SNo).SendMessageValue(j))
              GroupBoxSendMessage.Controls(i).Visible = True
            End If
          Next j
        Next i
      Catch ex As Exception

      End Try

      LabelSendMessageSendState.BackColor = SendMessageStateClass.SendMessageStateColorWait
      LabelSendMessageSendState.Text = SendMessageStateClass.SendMessageStateStrWait

      LabelSendSSSWaiTimeS.Text = ""
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      BtnCS21.Text = CStr(SNo) & ":" & .StationName
      BtnCS22.Text = "���ʱ�䣺" & .TestDate & "  " & .TestTime
      LabelStationAddress.Text = "��ַ��" & .StationAddress
      'LabelStationAddress.AutoSize = True
    End With

  End Function
  Private Sub SetMapStationSelectComboBox(ByVal S As String)
    'MΪֻ���õ�ͼѡ�� SΪֻ����վ��ѡ�� AΪȫ����
    If CW.Active = False Then Exit Sub
    SetMapStationSelectComboBoxRun = True
    Dim i As Integer
    'PicboxStation.Image = Image.FromFile(CW.WorkPath & "\maps\Station1.jpg")
    If S = "A" Or S = "a" Then
      ComboBoxSelectMap1.Items.Clear() 'ѡ���ͼ����
      ComboBoxSelectMap1.Text = ""
      ComboBoxSelectMap0.Items.Clear()
      ComboBoxSelectMap0.Text = ""
      For i = 1 To CW.MapAmount
        ComboBoxSelectMap1.Items.Add(CW.Maps(i).MapName)
        ComboBoxSelectMap0.Items.Add(CW.Maps(i).MapName)
      Next i
      ComboBoxSelectMap1.SelectedIndex = CW.MapNo - 1
      ComboBoxSelectMap0.SelectedIndex = CW.MapNo - 1

      ComboBoxSelectStation.Items.Clear() 'ѡ��վ������
      ComboBoxSelectStation.Text = ""
      For i = 1 To CW.Maps(CW.MapNo).MapStationPlacedAmount
        With CW.Maps(CW.MapNo).Stations(i)
          'If .Active = True Then
          ComboBoxSelectStation.Items.Add(.StationName)
          'End If
        End With
      Next
      If ComboBoxSelectStation.Items.Count > 0 Then
        ComboBoxSelectStation.SelectedIndex = 0
      End If
    End If

    If S = "M" Or S = "m" Then

      ComboBoxSelectMap1.Items.Clear() 'ѡ���ͼ����
      ComboBoxSelectMap1.Text = ""
      ComboBoxSelectMap0.Items.Clear()
      ComboBoxSelectMap0.Text = ""
      For i = 1 To CW.MapAmount
        ComboBoxSelectMap1.Items.Add(CW.Maps(i).MapName)
        ComboBoxSelectMap0.Items.Add(CW.Maps(i).MapName)
      Next i
      ComboBoxSelectMap1.SelectedIndex = CW.MapNo - 1
      ComboBoxSelectMap0.SelectedIndex = CW.MapNo - 1
    End If

    If S = "S" Or S = "s" Then
      ComboBoxSelectStation.Items.Clear() 'ѡ��վ������
      ComboBoxSelectStation.Text = ""
      For i = 1 To CW.Maps(CW.MapNo).MapStationPlacedAmount
        With CW.Maps(CW.MapNo).Stations(i)
          ComboBoxSelectStation.Items.Add(.StationName)
        End With
      Next
    End If
    If ComboBoxSelectStation.Items.Count > 0 Then
      ComboBoxSelectStation.SelectedIndex = 0
    End If

    SetMapStationSelectComboBoxRun = False
    'If ComboBoxSelectStation.Items.Count > 0 Then
    '  ComboBoxSelectStation.SelectedIndex = CW.Maps(CW.MapNo).PerShowStationNo - 1
    'End If
  End Sub

  Private Sub SetTabStationInfo(ByVal MNo As Integer, ByVal SNo As Short)
    If CW.Active = False Then Exit Sub
    Dim i As Integer

    With CW.Maps(MNo).Stations(SNo)

      If SNo > 0 Then

        If .Active Then ''''''''''''''''''''''''''''''''''TabStationIDIPName
          CheckBoxStationActive.Checked = True
        Else
          CheckBoxStationActive.Checked = False
        End If
        TextBoxStationNo.Text = SNo
        TextBoxStationID.Text = .StationID
        TextBoxStationModemID.Text = .ModemInfo.ID
        TextBoxStationIP.Text = .ModemInfo.IP
        TextBoxStationName.Text = .StationName
        TextBoxStationAddress.Text = .StationAddress
        TextBoxStationModeIndex.Text = .StationModeIndex
        TextBoxStationParameterAmount.Text = .StationParameterAmount
        'TextBoxStation()
        ''''''''''''''''''''''''''''''''''''''''''''''TabStationParameter

        'TreeViewTabStationParameter.Nodes.Clear()
        'For i = 1 To .StationParameterAmount
        '  'TreeViewTabStationParameter.CheckBoxes = True
        '  TreeViewTabStationParameter.Nodes.Add("����" & CStr(i) & ":" & .StationParameters(i, 0))
        'Next i
        'TreeViewTabStationParameter.CheckBoxes = True
        ListBoxTabStationParameter.Items.Clear()
        For i = 1 To .StationParameterAmount
          If IsNumeric(Trim(.StationParameters(i, 1))) And IsNumeric(Trim(.StationParameters(i, 3))) Then
            If CSng(Trim(.StationParameters(i, 1))) > CSng(Trim(.StationParameters(i, 3))) Then
              ListBoxTabStationParameter.Items.Add("(��)" & CStr(i) & ":" & .StationParameters(i, 0))
            Else
              ListBoxTabStationParameter.Items.Add("(OK)" & CStr(i) & ":" & .StationParameters(i, 0))
            End If
          Else
            ListBoxTabStationParameter.Items.Add("(OK)" & CStr(i) & ":" & .StationParameters(i, 0))
          End If
        Next i
        If SSelectIndex + 1 <= .StationParameterAmount Then
          ListBoxTabStationParameter.SelectedIndex = SSelectIndex
        End If
      Else '''''''''''''''''''''''''''''''''''''''''���
        CheckBoxStationActive.Checked = False
        TextBoxStationNo.Text = ""
        TextBoxStationID.Text = ""
        TextBoxStationIP.Text = ""
        TextBoxStationName.Text = ""
        TextBoxStationAddress.Text = ""
        TextBoxStationModeIndex.Text = ""
        TextBoxStationParameterAmount.Text = ""
        TextBoxParameter0.Text = ""
        TextBoxParameter1.Text = ""
        TextBoxParameter2.Text = ""
        TextBoxParameter3.Text = ""
        ListBoxTabStationParameter.Items.Clear()
      End If

      BtnStationParameterYingYong.Enabled = False

    End With
  End Sub
  Private Function SelectMap(ByVal MMNo As Short) As Boolean
    If CW.Active = False Then Exit Function
    Form1Run = False
    Dim i As Integer

    If MMNo < 0 Or MMNo > CW.MapAmount Then
      SelectMap = False
      Form1Run = True
      Exit Function
    End If

    PicBoxMapLoadMap(MMNo)
    EaglEye(True)

    For i = 1 To CW.Maps(CW.MapNo).MapStationPlacedAmount '�Ȱ�ǰһ����ʾ��ͼ��վ�㶼����
      ShowStationGif(i, False)
    Next i

    CW.MapNo = MMNo '���������µ���ѡ��ͼ��

    SetEaglEyeRedDotGif()

    With CW.Maps(MMNo)
      Try
        PicBoxMap.Image = Image.FromFile(CW.Maps(MMNo).MapPath)
      Catch
        MsgBox("��ͼ�ļ���ʧ��")
      End Try
      For i = 1 To .MapStationPlacedAmount
        ShowStationGif(i, True)
      Next i

    End With

    SetMapStationSelectComboBox("a")
    FDSX(False, False)
    'SetTabStationInfo(0)'����û��õ��׸�����
    If CW.Maps(CW.MapNo).MapStationPlacedAmount < 1 Then
      SetTabStationInfo(CW.MapNo, 0) '''''''''''''''''�õ�ͼû��վ��Ļ������
    Else
      '''''''''''''''''''''''''''��վ��Ļ�,��������վ����ϸ��Ϣҳ������ʾ��ϸ������Ϣ������Ӧ����ѡ��վ���SelectIndexChang�¼����ôû������200504241546
      'CW.Maps(MMNo).PerShowStationNo = 1
      'If TabControl1.SelectedIndex = 1 Then
      '  ShowStationParameter(1)
      'End If
    End If

    SelectMap = True
    Form1Run = True
  End Function

  Public Sub PollUserTable()
    'ά�������б�
    Dim i, j, k As Integer
    'Dim itmX As ListViewItem
    'Dim Temp As Long
    Dim Tucount As Long
    'Dim D As Date
    'Dim S As String

    Dim ModemIDMapNo, ModemIDStationNo As Integer
    Dim ModemID As String

    PollUserTableRun = True

    Tucount = GprsMod.DSGetModemCount() 'ȡ���û���

    If Tucount > 0 Then

      AxAniGIFOnLine.Visible = True
      '''''''''[[[[[[[[[[[[[[[[['''''''''''ά���û������б���ش���,�����
      For i = 0 To lstInfo.Items.Count - 1
        lstInfo.Items(i).Tag = "Del"
      Next
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      For i = 0 To Tucount - 1
        '����û���Ϣ
        Dim TModemInfo As New ModemInfoStruct
        Call GprsMod.DSGetModemByPosition(i, TModemInfo)

        '����waittime�����߳�

        Dim dayTemp As Date = #1/1/1970#
        Dim daysDiff As Int32 = Abs(DateDiff(DateInterval.Second, dayTemp, Now))
        Dim tmpLong As Long
        tmpLong = daysDiff - TModemInfo.m_Refresh_Time - 28800

        If WaitTime = 0 Or tmpLong < WaitTime Then

          '-------------------------------------------------------
          '���ݰ����ݽ�������
          Dim AddDataInfo(4) As String
          ModemID = StringToLen8(Hex(CStr(TModemInfo.m_ModemId))) '�������е�ModeID��Ӧ��ͨ���������ת����8����
          AddDataInfo(0) = ModemID
          Dim PhoneData As String = ""
          Dim a As Integer
          For a = 0 To 11
            PhoneData = PhoneData & Chr(CInt(TModemInfo.m_PhoneNo(a)))
          Next a

          AddDataInfo(1) = PhoneData
          AddDataInfo(2) = DateAdd("s", TModemInfo.m_Conn_Time, "1970-1-1 8:00:00")
          AddDataInfo(3) = Me.ByteToIp(TModemInfo.m_DynIp)

          '��������������ʾ��������
          'Me.AddText("tmodeminfo.m_modemid showmain :::" & tmodeminfo.m_modemid)
          Dim lvt As New ListViewItem(AddDataInfo)
          Dim lvtCount As Integer = Me.lstInfo.Items.Count

          If Not existRecord(AddDataInfo(0), AddDataInfo(1)) Then
            Me.lstInfo.Items.Insert(lvtCount, lvt)
            Me.lstInfo.Items(lvtCount).Tag = "Stay"
            '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
            If Me.lstInfo.Items.Count = 1 Then

            End If
            ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

            Application.DoEvents()

            '''''''''''''''�ж��Ƿ�������վ��
            Dim bHave As Boolean = False
            For j = 1 To CW.MapAmount
              For k = 1 To CW.Maps(j).MapStationPlacedAmount
                If ModemID = CW.Maps(j).Stations(k).ModemInfo.ID Then
                  ModemIDMapNo = j
                  ModemIDStationNo = k
                  bHave = True
                  Exit For
                End If
                If bHave Then Exit For
              Next k
            Next j
            If bHave Then
              ComboBoxOnLineStationInfo.Items.Add(CW.Maps(ModemIDMapNo).MapName & "��" & CW.Maps(ModemIDMapNo).Stations(ModemIDStationNo).StationName)
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
              If Me.ComboBoxOnLineStationInfo.Items.Count = 1 Then
                ComboBoxOnLineStationInfo.SelectedIndex = 0
              End If
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]


            Else
              ComboBoxOnLineStationInfo.Items.Add("��èIDû����վ��")
            End If
          End If

        Else
          'Form1.ListView1.ListItems.Remove(i + 1)
        End If
        Application.DoEvents()

      Next i

    End If

    PollUserTableRun = False

  End Sub

  Private Sub SetAtxTimePointAdoNet()
    'Dim AdoNetAtxCN As New OleDb.OleDbConnection
    'Dim AdoNetAtxDS As New DataSet
    'Dim AdoNetAtxDA As New OleDb.OleDbDataAdapter
    'Dim AdoNetAtxDV As New DataView

    Dim ColNo As Integer
    Dim S As String
    Dim TableName As String = "ATXTimePoint"

    Try
      AdoNetAtxCN = New OleDb.OleDbConnection( _
               "Provider=Microsoft.Jet.OLEDB.4.0;" & _
               "Data Source=" & CW.WorkPath & "\" & CWMap_Station_InfoMDB)
      'AdoNetCN.Open()
      AdoNetAtxDA = New OleDb.OleDbDataAdapter("SELECT * FROM " & TableName, AdoNetAtxCN)
      AdoNetAtxDS = New DataSet
      AdoNetAtxDA.Fill(AdoNetAtxDS, TableName)
      AdoNetAtxDV = New DataView(AdoNetAtxDS.Tables.Item(TableName))
      'AdoNetDV.Sort = "ID DESC"
      AdoNetAtxDV.Sort = AdoNetAtxDV.Table.Columns.Item(1).ColumnName & " ASC"
    Catch ex As Exception

    End Try

    Dim myDRV As DataRowView
    ColNo = 1
    For Each myDRV In AdoNetAtxDV
      S = Trim(CStr(myDRV(ColNo)))
      If S <> "" Then
        ListBoxAtxTimePoint.Items.Add(S)
      End If
    Next

  End Sub

  Private Sub PanelPicBoxMapMove_MoveToSelectStation(ByVal SID As Integer)
    'PanelPicBoxMap
    If PanelPicBoxMapMove_MoveToSelectStation_Alow Then
      Dim P As Point
      With PanelPicBoxMapMove
        P = New Point(CW.Maps(CW.MapNo).Stations(SID).StationGif.Location)
        PointPicNew.X = -(P.X - (.Parent.Width / 2))
        PointPicNew.Y = -(P.Y - (.Parent.Height / 2))
        EaglEye(False)
        .Location = PointPicNew
      End With
    End If
  End Sub
  Private Sub SetWorkAll()
    SetWorkAll_Run = True
    Dim i, j, k As Integer
    '����������أ������ŵ��򿪹���֮��
    SetGPRSWork(Me) '��ʼ����ǰ��Ŀ��,������SetLocationǰ��
    If CW.Active Then
      PanelStation.Visible = True
    End If
    ''''[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[['�Զ���ѯ�������
    Select Case CW.RadioBtn_ATX_TimeN
      Case 1
        RadioBtn_ATX_Time1.Checked = True
      Case 2
        RadioBtn_ATX_Time2.Checked = True
      Case Else
        RadioBtn_ATX_Time3.Checked = True
    End Select

    i = CInt(CW.RadioBtn_ATX_Time3 / 60)
    If i < 1 Then i = 1
    If i > 6 Then i = 6
    NumericUpDown_ATX_Hours.Value = i
    Label_ATX_Note.Text = CW.Label_ATX_Note
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    ''''[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[['��ȡͨѶ�������
    Dim S As String
    S = "2"
    If RWIni(True, CW.GPRSWorkFilePath, "TX", "RevTestData", S) = "1" Then
      ChkRevTest.Checked = True
    Else
      ChkRevTest.Checked = False
    End If

    If RWIni(True, CW.GPRSWorkFilePath, "TX", "AutoServiceStart", S) = "1" Then
      ChkAutoStart.Checked = True
    Else
      ChkAutoStart.Checked = False
    End If

    '[[[[[[[[[���ɺͶ�ȡ�Զ���ѯʱ�����Ϣ[[[[[[[[[[[
    SetAtxTimePointAdoNet()
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    If RWIni(True, CW.GPRSWorkFilePath, "TX", "MTX", S) = "1" Then
      RaBtnM.Checked = True
    Else
      RaBtnA.Checked = True
    End If


    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    'SetLocation() '���ô���Ԫ��λ��

    'SetGPRSWork() '��ʼ����ǰ��Ŀ��

    PicBoxMapLoadMap(CW.MapNo)  'װ�ص�ͼ

    EaglEye(True)  '������ʾӥ��
    SetEaglEyeRedDotGif()
    FDSX(False, False) '���÷Ŵ���С�����ĵ�
    '(((((((((((((((((((((((((((((((((((((((((((((((((((

    Dim Show As Boolean
    k = CW.MapNo
    For i = 1 To CW.MapAmount
      If i = k Then
        Show = True
      Else
        Show = False
      End If
      CW.MapNo = i
      For j = 1 To CW.Maps(i).MapStationPlacedAmount
        ShowStationGif(j, Show)
      Next j
    Next i
    CW.MapNo = k
    ')))))))))))))))))))))))))))))))))))))))))))))))))))))))))
    SetMapStationSelectComboBox("m")  '���õ�ͼ��վ��ѡ��ؼ�

    '�Զ�������������
    If ChkAutoStart.Checked Then
      If CW.Active = False Then Exit Sub
      If ActivePerson.Active = False Then Exit Sub
      If bStop = False Then Exit Sub
      Me.ServiceStart()
    End If

    SendMode = DoUDTXDataMode.Text.Trim

    PanelPicBoxMapMove_MoveToSelectStation_Alow = True
    PanelPicBoxMapMove_MoveToSelectStation(1)
    PanelPicBoxMapMove_MoveToSelectStation_Alow = False
    '[[[[[[[[[[[[[[[[[[[[20071023����˳������[[[[[[[[[[[[[[[
    StationDataInfo = New GprsRevStationDataInfo
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    '[[[[[[[[[[[[[[[[[[[[20080106��ȡ��������������Ϣ[[[[[[[[
    '���Ͼ�StationDataInfo = New GprsRevStationDataInfoһ���ʼ����,�������ٶ�ȡÿ��վ��ķ������ݱ���
    For i = 1 To CW.MapAmount
      For j = 1 To CW.Maps(i).MapStationPlacedAmount
        CW.Maps(i).Stations(j).SendMessageHowMany(StationDataInfo.StationModeInfo(CW.Maps(i).Stations(j).StationModeIndex).SendMessageHowMany)
        For k = 1 To StationDataInfo.StationModeInfo(CW.Maps(i).Stations(j).StationModeIndex).SendMessageHowMany

          S = RWIni(True, CW.GPRSWorkFilePath, "SendMessageMap" & CStr(i), "S" & CStr(j) & "SM" & CStr(k), "")
          Try
            If S <> "" Then
              If Not (IsNothing(S)) Then
                If k = 1 Then '20080303����,����ʱ��
                  CW.Maps(i).Stations(j).SendMessageValue(k) = Trim(S)
                End If
                CW.Maps(i).Stations(j).SendMessageValue(k) = CSng(S)
              End If
            End If
          Catch ex As Exception
            'HaveError = True
          End Try

        Next k
      Next j
    Next i
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    SetWorkAll_Run = False
  End Sub

  Private Function RorWMapStationInfoMDB(ByVal MapNo As Integer, ByVal RorW As Boolean) As String
    Dim i, j, k As Integer
    Dim S As String

    RorWMapStationInfoMDB = ""

    If CW.MapAmount < 1 Then
      RorWMapStationInfoMDB = "Ŀǰ���̻�û�е�ͼ��"
      Exit Function
    End If

    If MapNo > CW.MapAmount Then
      RorWMapStationInfoMDB = "Ŀǰ��ͼ��û������վ��������"
      Exit Function
    End If

    If CW.Maps(MapNo).MapStationAmount < 1 Then
      RorWMapStationInfoMDB = "Ŀǰ��ͼ��û�з���վ�㡣"
      Exit Function
    End If

    Dim MyRst As New ADODB.Recordset
    Dim MyAdo As New GPRSADO

    Try
      MyAdo.ConnAccess(CW.WorkPath & "\" & CWMap_Station_InfoMDB)
    Catch ex As Exception
      RorWMapStationInfoMDB = "û�ҵ���Ϣ���ݿ�" & CWMap_Station_InfoMDB & "��"
      Exit Function
    End Try

    Try
      MyRst = MyAdo.OpenTable("Map")
    Catch ex As Exception
      RorWMapStationInfoMDB = "û�ҵ���ͼ��Ϣ��:Map��"
    End Try

    Select Case RorW

      Case True
        '''''''''''''''''''''''''''''''''''''''''''''''''''��
        With MyRst
          Dim SF As String
          Dim tB As Boolean
          For i = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            SF = "MapNo= " & CStr(MapNo) & " And " & " StationIndex= " & CStr(i) & " And " & "SID= 0"
            .Filter = ""
            Try
              .Filter = SF
              If Not .EOF And Not .BOF Then
                'On Error Resume Next
                'Me.Controls.Add(CW.Maps(MapNo).Stations(i).StationGif)
                PanelTmp.Controls.Add(CW.Maps(MapNo).Stations(i).StationGif)

                CW.Maps(MapNo).Stations(i).StationGif.ReadGIF(SGif.GifFilePath_OK)
                CW.Maps(MapNo).Stations(i).StationGif.Visible = False
                tB = .Fields("Active").Value
                CW.Maps(MapNo).Stations(i).Active = tB
                If (Not (IsDBNull(.Fields("X").Value))) And Not ((IsDBNull(.Fields("Y").Value))) Then
                  CW.Maps(MapNo).Stations(i).StationLocation = New Point(.Fields("X").Value, .Fields("Y").Value)
                End If
                If IsNumeric(.Fields("StationID").Value) Then
                  CW.Maps(MapNo).Stations(i).StationID = .Fields("StationID").Value
                End If
                If IsNumeric(.Fields("ModemID").Value) Then
                  CW.Maps(MapNo).Stations(i).ModemInfo.ID = .Fields("ModemID").Value
                End If
                If Not (IsDBNull(.Fields("StationIp").Value)) Then
                  CW.Maps(MapNo).Stations(i).ModemInfo.IP = .Fields("StationIp").Value
                End If
                If Not (IsDBNull(.Fields("PhoneNo").Value)) Then
                  CW.Maps(MapNo).Stations(i).ModemInfo.PhoneNo = .Fields("PhoneNo").Value
                End If
                If Not (IsDBNull(.Fields("StationAddress").Value)) Then
                  CW.Maps(MapNo).Stations(i).StationAddress = .Fields("StationAddress").Value
                End If

                If Not (IsDBNull(.Fields("StationIndex").Value)) Then
                  k = .Fields("StationIndex").Value
                  CW.Maps(MapNo).Stations(i).StationIndex = k
                  CW.Maps(MapNo).Stations(i).StationGif.Tag = CStr(k)
                End If
                If Not (IsDBNull(.Fields("StationModeIndex").Value)) Then
                  CW.Maps(MapNo).Stations(i).StationModeIndex = .Fields("StationModeIndex").Value
                End If

                If Not (IsDBNull(.Fields("StationName").Value)) Then
                  CW.Maps(MapNo).Stations(i).StationName = .Fields("StationName").Value
                End If

                If Not (IsDBNull(.Fields("StationParameterAmount").Value)) Then
                  k = .Fields("StationParameterAmount").Value
                  CW.Maps(MapNo).Stations(i).StationParameterAmount = k
                End If


                For j = 1 To k
                  If Not (IsDBNull(.Fields("ParameterName" & CStr(j)).Value)) Then
                    CW.Maps(MapNo).Stations(i).StationParameters(j, 0) = .Fields("ParameterName" & CStr(j)).Value
                  End If
                  If Not (IsDBNull(.Fields("ParameterAlarmLine" & CStr(j)).Value)) Then
                    S = .Fields("ParameterAlarmLine" & CStr(j)).Value
                    CW.Maps(MapNo).Stations(i).StationParameters(j, 3) = S
                  Else
                    CW.Maps(MapNo).Stations(i).StationParameters(j, 3) = ""
                  End If
                  If Not (IsDBNull(.Fields("ParameterPartName" & CStr(j)).Value)) Then
                    CW.Maps(MapNo).Stations(i).StationParameters(j, 2) = .Fields("ParameterPartName" & CStr(j)).Value
                  End If

                Next j

              End If

            Catch ex As Exception
              '((((((((((((((((((((((((((((((((((((((((((((
              If PM.VerMode = "Debug" Then
                MsgBox(ex.Message.ToString)
              End If
              '))))))))))))))))))))))))))))))))))))))))))))
              RorWMapStationInfoMDB = "��վ����Ϣ��ȡ����"
            End Try

          Next i
          '.Close()
        End With
        MyRst = Nothing
        MyAdo.Close()
        MyAdo = Nothing

      Case False
        '''''''''''''''''''''''''''''''''''''''''''''''''''д
        With MyRst
          Dim SF As String
          For i = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            SF = "MapNo=" & CStr(MapNo) & " And " & " StationIndex=" & CStr(i) & " And " & "SID=0"
            .Filter = ""
            Try
              .Filter = SF
              If Not .EOF And Not .BOF Then
                'On Error Resume Next

              Else
                .AddNew()
              End If
              .Fields("StationIndex").Value = i
              .Fields("SID").Value = 0
              .Fields("MapNo").Value = MapNo '������ˣ����Ҹ�����200504250202
              .Fields("Active").Value = CW.Maps(MapNo).Stations(i).Active
              .Fields("X").Value = CW.Maps(MapNo).Stations(i).StationLocation.X
              .Fields("Y").Value = CW.Maps(MapNo).Stations(i).StationLocation.Y
              .Fields("StationID").Value = CW.Maps(MapNo).Stations(i).StationID
              .Fields("ModemID").Value = CW.Maps(MapNo).Stations(i).ModemInfo.ID
              .Fields("StationIp").Value = CW.Maps(MapNo).Stations(i).ModemInfo.IP
              .Fields("PhoneNo").Value = CW.Maps(MapNo).Stations(i).ModemInfo.PhoneNo
              .Fields("StationAddress").Value = CW.Maps(MapNo).Stations(i).StationAddress
              .Fields("StationIndex").Value = CW.Maps(MapNo).Stations(i).StationIndex
              .Fields("StationModeIndex").Value = CW.Maps(MapNo).Stations(i).StationModeIndex
              .Fields("StationName").Value = CW.Maps(MapNo).Stations(i).StationName
              k = CW.Maps(MapNo).Stations(i).StationParameterAmount
              .Fields("StationParameterAmount").Value = k
              For j = 1 To k
                .Fields("ParameterName" & CStr(j)).Value = CW.Maps(MapNo).Stations(i).StationParameters(j, 0)
                .Fields("ParameterAlarmLine" & CStr(j)).Value = CW.Maps(MapNo).Stations(i).StationParameters(j, 3)
                .Fields("ParameterPartName" & CStr(j)).Value = CW.Maps(MapNo).Stations(i).StationParameters(j, 2)
              Next j
              j = 0
              .Update()
            Catch ex As Exception
              RorWMapStationInfoMDB = "��վ����Ϣд�����"
            End Try

          Next i
          '.UpdateBatch()
          '.Close()
        End With
        MyRst = Nothing
        MyAdo.Close()
        MyAdo = Nothing
    End Select
  End Function
  Private Function RorWCWMapInfoMDB(ByVal RorW As Boolean) As String
    Dim i As Integer

    RorWCWMapInfoMDB = ""

    If CW.MapAmount < 1 Then
      RorWCWMapInfoMDB = "Ŀǰ���̻�û�е�ͼ��"
      Exit Function
    End If

    Dim MyRst As New ADODB.Recordset
    Dim MyAdo As New GPRSADO

    Try
      MyAdo.ConnAccess(CW.WorkPath & "\" & CWMap_Station_InfoMDB)
    Catch ex As Exception
      RorWCWMapInfoMDB = "û�ҵ���Ϣ���ݿ�" & CWMap_Station_InfoMDB & "��"
      Exit Function
    End Try

    Try
      MyRst = MyAdo.OpenTable("CW")
    Catch ex As Exception
      RorWCWMapInfoMDB = "û�ҵ���Ϣ��CW��"
      Exit Function
    End Try


    Select Case RorW

      Case True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''��
        With MyRst
          Dim FS, S As String
          S = ""
          For i = 1 To CW.MapAmount
            .Filter = ""
            FS = "MapIndex=" & CStr(i)
            Try
              .Filter = FS
              If Not .EOF And Not .BOF Then
                If Not (IsDBNull(.Fields("MapName").Value)) Then
                  CW.Maps(i).MapName = .Fields("MapName").Value
                End If
                If Not (IsDBNull(.Fields("MapStationAmount").Value)) Then
                  CW.Maps(i).MapStationAmount = .Fields("MapStationAmount").Value
                End If
                If Not (IsDBNull(.Fields("MapStationPlacedAmount").Value)) Then
                  CW.Maps(i).MapStationPlacedAmount = .Fields("MapStationPlacedAmount").Value
                End If

                CW.Maps(i).Initializing() '��ȡ�����ݿ��е�MapStationPlacedAmount����ʵ����վ��
                If Not (IsDBNull(.Fields("MapPath").Value)) Then
                  S = Trim(.Fields("MapPath").Value)
                End If

                If S <> "" Then
                  If Mid(S, 1, 1) = "\" Then
                    CW.Maps(i).MapPath = CW.WorkPath & S
                  End If
                Else
                  'CW.Maps(i).MapPath = GetAppPath() & "\����һ\Maps\Map" & CStr(i) & ".bmp"
                  CW.Maps(i).MapPath = CW.WorkPath & "\����һ\Maps\Map" & CStr(i) & ".bmp"
                End If

                '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
                'CW.Maps(i).MapPath = CW.WorkPath & "\" & CW.WorkName & "\Maps\Map" & CStr(i) & ".bmp"
                CW.Maps(i).MapPath = CW.WorkPath & "\Maps\Map" & CStr(i) & ".bmp"
                ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

              End If
            Catch ex As Exception
              '((((((((((((((((((((((((((((((((((((((
              'MessageBox.Show(ex.Message.ToString)
              '))))))))))))))))))))))))))))))))))))))
              RorWCWMapInfoMDB = "��ȡ������Ϣ�������д���" & ex.Message.ToString
              MyRst = Nothing
              MyAdo.Close()
              MyAdo = Nothing
              Exit Function
            End Try
          Next i
        End With
        MyRst = Nothing
        MyAdo.Close()
        MyAdo = Nothing

      Case False
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''д
        With MyRst

          Dim FS As String
          For i = 1 To CW.MapAmount
            .Filter = ""
            FS = "MapIndex=" & CStr(i)
            Try
              .Filter = FS
              If .RecordCount <= 0 Then
                .AddNew()
                .Fields("MapIndex").Value = i
              End If
              .Fields("MapName").Value = CW.Maps(i).MapName
              .Fields("MapStationAmount").Value = CW.Maps(i).MapStationAmount
              .Fields("MapStationPlacedAmount").Value = CW.Maps(i).MapStationPlacedAmount
              .Fields("MapPath").Value = CW.Maps(i).MapPath
            Catch ex As Exception
              RorWCWMapInfoMDB = "���湤����Ϣ�������д���"
              Exit Function
            End Try
            .Update()
          Next i
          '.UpdateBatch()
        End With
        MyRst = Nothing
        MyAdo.Close()
        MyAdo = Nothing

    End Select

  End Function

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    GridppReportUtility.RegisterGridppReport()
    Me.Size = New Size(1024, 734)
    '((((((((((((((((((((((((((((((((((((((((
    Label1.Text = GetAppPath()
    'Dim D As Date
    'D = CDate("2007��")
    'D = CDate("2007��2��")
    '))))))))))))))))))))))))))))))))))))))))
    'Me.Text = "HZY-GPRS�������ϵͳ"
    SetPM(True)
    SetPerson()
    SetLocationActivePerson() '���õ�¼����
    '
    bMDataChanged = False
    bMsend = False
    bMsendMAbort = False

    Me.Text = PM.Name
    SetLocation()
    'SetTongXun() 'ͨѶ����,��ΪRWTXini(True)�ŵ�SetGPRSWork() ���ˣ���Ϊ���ڹ������ö����ǳ�������

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    '����������أ������ŵ��򿪹���֮��
    'SetGPRSWork(Me) '��ʼ����ǰ��Ŀ��,������SetLocationǰ��

    'SetLocation() '���ô���Ԫ��λ��

    ''SetGPRSWork() '��ʼ����ǰ��Ŀ��

    'PicBoxMapLoadMap(CW.MapNo)  'װ�ص�ͼ

    'EaglEye(True)  '������ʾӥ��

    'FDSX(False, False) '���÷Ŵ���С�����ĵ�

    'SetMapStationSelectComboBox("m") '���õ�ͼ��վ��ѡ��ؼ�
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    CWChanged = False '�Ƿ���Ŀ�����б仯

    PlaceSNo = 1

    bStop = True
    'SysAutoM = 1 '�Զ�ά���û��б�

    'PerShowStationNo = 1

    '"""""""""""""""""""""""""""""""""""""""""""""""""����ΪGIF�ؼ�Ӧ�õ�ʾ����˵��
    AniGifMainForm.Transparent = True '����͸��
    AniGifMainForm.AutoSize = True '�Զ���С
    AniGifMainForm.Stretch = 0 '��չ��ʽ 0����չ1�������չ2�����Ϳ���չ
    AniGifMainForm.Sequence = 0 '����˳��0˳��1���2˳�潻��
    'AniGifMainForm.Stop()
    'AniGifMainForm.Play()
    '    AniGifMainForm(��Step�¼�Ϊ���ڲ��ŵ�����)
    '    Private Sub AniGifMainForm_Step()
    '      Label1 = "Frame " & AniGIF1.Frame
    '    End Sub
    AniGifMainForm.ReadGIF(CW.WorkPath & "images\ANIMFAN.GIF")

    AxShockwaveFlashMainForm.Movie = GetAppPath() & "\Resource\clock1.swf"
    'AxShockwaveFlashMainForm.Playing = True
    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    Me.TimerNow.Enabled = True
    GlobalVal.LineCount = 0
    GlobalVal.SysAutoM = 1
    lstInfo.FullRowSelect = True

    '��ȡ�����ļ��ж˿ںŵ�����
    GlobalVal.SrvPort = GlobalVal.getPort        'GlobalVal.srvport = 5001
    '��ȡ��ѭʱ��
    GlobalVal.WaitTime = GlobalVal.getTime       'GlobalVal.waittime = 3
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    gifMSend.ReadGIF(SGif.GifMsendStop)
    gifMSend.BringToFront()

    Form1Run = True
    Application.DoEvents()
    Me.Focus()
    Application.DoEvents()
    TTXX = 0
  End Sub

  Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    If CWChanged = True And form2WorkSettingRun = False Then
      Form1Run = False

      SetWorkAll()

      CWChanged = False
      Form1Run = True

      '+++++++++++++++++++++++++++++++++++++

    End If
  End Sub

  Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.Escape Then
      If bPlaceStation Then
        Me.Cursor = Cursors.Default
        bPlaceStation = False
      End If
    End If
  End Sub
  Private Sub PicBoxMap_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBoxMap.MouseMove
    '(((((((((((((((((((((((((((((((((((((((((((((((((((((((((
    Label2.Text = e.X()
    Label3.Text = e.Y()
    ')))))))))))))))))))))))))))))))))))))))))))))))))))))))))
    If ActivePerson.Active = False Then Exit Sub

    If bPlaceStation Then Exit Sub
    If bMoMove Then
      If e.Button = Windows.Forms.MouseButtons.Left Then


        'If Not bPlaceStation Then
        '    MM = True
        'End If
        If MM Then
          'PicBoxMap.Cursor.Current = New Cursor(GetAppPath() & CStr(CW.WorkName) & "\images\hand-1.cur")
          Windows.Forms.Cursor.Current = SGif.Cur(1)
        End If

        '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
        Dim PP As Point
        'If PicBoxEaglEyeMouseDown Then
        PP.X = e.X - PointMouseOld.X
        PP.Y = e.Y - PointMouseOld.Y
        PointPicNew.X = PointPicOld.X + PP.X
        PointPicNew.Y = PointPicOld.Y + PP.Y

        EaglEye(False)

        PanelPicBoxMapMove.Location = PointPicNew
        PointPicOld = PointPicNew
        'End If
        ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      Else
        'PicBoxMap.Cursor.Current = New Cursor(GetAppPath() & CStr(CW.WorkName) & "\images\hand-0.cur")
        Windows.Forms.Cursor.Current = SGif.Cur(0)
      End If


    End If
  End Sub
  Private Sub PicBoxMap_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
  End Sub

  Private Sub PicBoxMap_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBoxMap.MouseDown

    If ActivePerson.Active = False Then Exit Sub

    If e.Button = Windows.Forms.MouseButtons.Left Then
      bPicBoxMap_MouseDown = True
      If bPlaceStation Then
        ''''''''''''''''''''''''''''''''''''''''''����վ��
        Me.Cursor = Cursors.Default
        'bPlaceStation = False
        PointStationPlace = New Point(e.X, e.Y)
        PicboxMapDrawStation()
        bPlaceStation = False
      Else
        If Not bPlaceStation Then
          MM = True
        End If
        If bMoMove Then

          Windows.Forms.Cursor.Current = SGif.Cur(1)
          PointMouseOld = New Point(e.X, e.Y)
          'PointPicOld = New Point(PicBoxMap.Left, PicBoxMap.Top)
          PointPicOld = New Point(PanelPicBoxMapMove.Left, PanelPicBoxMapMove.Top)
        End If
      End If
    ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

      If bPlaceStation Then
        Me.Cursor = Cursors.Default
        bPlaceStation = False
      End If

    End If
  End Sub
  Private Sub PanelPicBoxMap_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PanelPicBoxMap.DragDrop

  End Sub
  Private Sub PicBoxMap_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBoxMap.MouseUp
    bPicBoxMap_MouseDown = False
    If ActivePerson.Active = False Then Exit Sub

    If e.Button = Windows.Forms.MouseButtons.Left Then
      If bPlaceStation Then
        '((((((((((((((((((((((((((((((((((((((((
        'MsgBox("����ȡ��״̬�ˣ�")
        '))))))))))))))))))))))))))))))))))))))))
        bPlaceStation = False
        Exit Sub
      End If

      If MM Then
        PointMouseNew = New Point(e.X, e.Y)
        PointPicNew = New Point(PointPicOld.X + PointMouseNew.X - PointMouseOld.X, PointPicOld.Y + PointMouseNew.Y - PointMouseOld.Y)
        MM = False

        EaglEye(False)

        PanelPicBoxMapMove.Location = PointPicNew
        'PanelPicBoxMap.Refresh()
        'TabControl1.Refresh()

      End If
    End If
    'PicboxMapDrawStation()
  End Sub

  Private Sub MenuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click

    'If ActivePerson.Active = False Then Exit Sub
    'Me.Close()
    BtnOut_Click(sender, e)

  End Sub


  Private Sub BtnFDFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFDFD.Click
    If ActivePerson.Active = False Then Exit Sub
    If TabControl1.SelectedIndex <> 0 Then Exit Sub
    FDSX(True, False)
  End Sub

  Private Sub BtnFDSX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFDSX.Click
    If ActivePerson.Active = False Then Exit Sub
    If TabControl1.SelectedIndex <> 0 Then Exit Sub
    FDSX(False, True)
  End Sub

  Private Sub BtnFDHY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFDHY.Click
    If ActivePerson.Active = False Then Exit Sub
    If TabControl1.SelectedIndex <> 0 Then Exit Sub
    FDSX(True, True)
  End Sub

  Private Sub BtnPlaceStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlaceStation.Click
    If ActivePerson.Active = False Then Exit Sub
    If TabControl1.SelectedIndex <> 0 Then Exit Sub

    Me.Cursor = Cursors.NoMove2D

    bPlaceStation = True

  End Sub

  Private Sub PicBoxEaglEye_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBoxEaglEye.MouseDown
    If ActivePerson.Active = False Then Exit Sub
    PicBoxEaglEyeMouseDown = True
    'PanelPicBoxMap.AutoScroll = False
  End Sub

  Private Sub PicBoxEaglEye_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBoxEaglEye.MouseUp

    If ActivePerson.Active = False Then Exit Sub
    PicBoxEaglEyeMouseDown = False
    'Dim XBL, YBL, X, Y As Single
    Dim PP As Point

    PP.X = e.X * (PicBoxMap.Width / PicBoxEaglEye.Width)
    PP.Y = e.Y * (PicBoxMap.Height / PicBoxEaglEye.Height)
    PointPicNew.X = -(PP.X - PanelPicBoxMap.Width / 2)
    PointPicNew.Y = -(PP.Y - PanelPicBoxMap.Height / 2)

    EaglEye(False)

    PanelPicBoxMapMove.Location = PointPicNew
    'PicboxMapDrawStation()
    'PanelPicBoxMap.AutoScroll = True

  End Sub

  Private Sub PicBoxEaglEye_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBoxEaglEye.MouseMove
    If ActivePerson.Active = False Then Exit Sub
    'If ActivePerson.Active = False Then Exit Sub

    Dim PP As Point
    If PicBoxEaglEyeMouseDown Then
      PP.X = e.X * (PicBoxMap.Width / PicBoxEaglEye.Width)
      PP.Y = e.Y * (PicBoxMap.Height / PicBoxEaglEye.Height)
      PointPicNew.X = -(PP.X - PanelPicBoxMap.Width / 2)
      PointPicNew.Y = -(PP.Y - PanelPicBoxMap.Height / 2)

      EaglEye(False)

      PanelPicBoxMapMove.Location = PointPicNew
    End If

    'PicboxMapDrawStation()
    'PanelPicBoxMap.AutoScroll = True
  End Sub

  Private Sub PicBoxEaglEye_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicBoxEaglEye.MouseLeave
    If ActivePerson.Active = False Then Exit Sub

  End Sub

  Private Sub AniGifMainForm_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AniGifMainForm.DblClick
    Dim S As String

    S = sender.tag

    Select Case S

      Case "AniGifMainForm"

        If ActivePerson.Active = False Then Exit Sub
        If AniGifMainForm.Playing = False Then
          AniGifMainForm.Play()
        Else
          AniGifMainForm.Stop()
        End If

      Case Else
        CW.Maps(CW.MapNo).PerShowStationNo = CSng(S)
        CW.Maps(CW.MapNo).Stations(CSng(S)).LookedRevNewData = True
        TabShowMap.Controls.Add(GroupBoxAboutStation)
        GroupBoxAboutStation.Location = New Point(TabControl1.Width - 212, 160)
        GroupBoxAboutStation.Anchor = AnchorStyles.Top + AnchorStyles.Right
        GroupBoxAboutStation.BringToFront()

        SetMapStationSelectComboBox("s")
        SetTabStationInfo(CW.MapNo, CSng(S))
        ComboBoxSelectStation.SelectedIndex = CSng(S) - 1


    End Select
  End Sub
  Private Sub AniGifMainForm_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles AniGifMainForm.ClickEvent
    Dim S As String
    S = sender.tag
    Select Case S
      Case "AniGifMainForm"
      Case Else
        CW.Maps(CW.MapNo).PerShowStationNo = CSng(S)
    End Select
  End Sub
  Private Sub AniGifMainForm_MouseMoveEvent(ByVal sender As Object, ByVal e As AxAniGIFCtrl.IAniGIFEvents_MouseMoveEvent) Handles AniGifMainForm.MouseMoveEvent
    Dim S As String

    S = sender.tag

    Select Case S

      Case "AniGifMainForm"

      Case Else
        ''''''''''����������ʾ
        With CW.Maps(CW.MapNo).Stations(CSng(S))
          Dim LMD As Integer '������
          LMD = 6
          .pLabelToolTip.BringToFront()
          .ToolTap = True
          'If (e.x <= LMD Or e.x >= .StationGif.Width - LMD) Or (e.y <= LMD Or e.y >= .StationGif.Height - LMD) Then
          '  .ToolTap = False
          'End If

        End With
    End Select
  End Sub


  Private Sub BtnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIn.Click
    'ExitOk = False
    'ActivePerson.IsAdministrator = True
    'ActivePerson.Name = ComboBoxPersonName.Text
    Dim i, UserNo, PerLogin, SavePws As Short
    Dim UserName, Pws As String

    UserNo = ComboBoxPersonName.SelectedIndex + 1
    UserName = StrConv(Trim(ComboBoxPersonName.Text), VbStrConv.Lowercase)
    Pws = TextBoxPassword.Text
    PerLogin = 0
    If CheckBoxPassword.Checked Then
      SavePws = 1
    Else
      SavePws = 0
    End If

    If UserName = StrConv(AUsers.Users(UserNo).Name, VbStrConv.Lowercase) Then
      If Pws = AUsers.Users(UserNo).Password Then
        PerLogin = 1
        SaveLoginInfoINI(UserNo, PerLogin, SavePws)
        ActivePerson = AUsers.Users(UserNo)
        AUsers.ActiveNo = UserNo
        ActivePerson.Active = True
        PanelPassword.Hide()
      Else
        MessageBox.Show("������������", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
    Else

      UserNo = -1
      For i = 0 To AUsers.UserAmount
        If UserName = StrConv(AUsers.Users(i).Name, VbStrConv.Lowercase) Then
          UserNo = i
          Exit For
        End If
      Next i

      If UserNo = 0 Then
        If AUsers.Users(UserNo).Password = Pws Then
          'SaveLoginInfoINI(UserNo, PerLogin, SavePws)
          ActivePerson = AUsers.Users(UserNo)
          AUsers.ActiveNo = UserNo
          ActivePerson.Active = True
          PanelPassword.Hide()
        Else
          MessageBox.Show("������������", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
      ElseIf UserNo > 0 Then
        If AUsers.Users(UserNo).Password = Pws Then
          PerLogin = 1
          SaveLoginInfoINI(UserNo, PerLogin, SavePws)
          AUsers.ActiveNo = UserNo
          ActivePerson = AUsers.Users(UserNo)
          ActivePerson.Active = True
          PanelPassword.Hide()
        Else
          MessageBox.Show("������������", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
      Else
        MessageBox.Show("������û�������", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If

    End If

    'SaveLoginInfoINI(UserNo, 0, 0)
    'ActivePerson.Active = True
    'PanelPassword.Hide()
  End Sub

  Private Sub BtnOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOut.Click
    'ExitOk = True
    If MessageBox.Show("���Ҫ�˳�������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
      Me.ServiceEnd() '''''''''��ֹͣ����,��Ȼ���г�����ʾ
      Me.Dispose()
    End If

  End Sub

  Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
    MenuItemLogout_Click(sender, e)
  End Sub

  Private Sub BtnIn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnIn.MouseMove, BtnOut.MouseMove
    Dim S As String = sender.tag
    Select Case S
      Case "BtnPassword0"
        BtnIn.ForeColor = System.Drawing.Color.DeepSkyBlue
      Case "BtnPassword1"
        BtnOut.ForeColor = System.Drawing.Color.DeepSkyBlue
    End Select
  End Sub

  Private Sub BtnIn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIn.MouseLeave, BtnOut.MouseLeave
    Dim S As String = sender.tag
    Select Case S
      Case "BtnPassword0"
        BtnIn.ForeColor = System.Drawing.Color.LightGoldenrodYellow
      Case "BtnPassword1"
        BtnOut.ForeColor = System.Drawing.Color.LightGoldenrodYellow
    End Select
  End Sub

  Private Sub BtnSelctPerStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelctPerStation.Click
    'Dim i As Integer
    With ComboBoxSelectStation
      If .Items.Count > 1 Then
        If .SelectedIndex > 0 Then
          PanelPicBoxMapMove_MoveToSelectStation_Alow = True
          .SelectedIndex = .SelectedIndex - 1
          CW.Maps(CW.MapNo).PerShowStationNo = .SelectedIndex + 1
        End If
        'ShowStationParameter(.SelectedIndex + 1)
      End If
    End With

  End Sub

  Private Sub BtnSelctNextStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelctNextStation.Click
    'Dim i As Integer
    With ComboBoxSelectStation
      If .Items.Count > 1 Then
        If .SelectedIndex < .Items.Count - 1 Then
          PanelPicBoxMapMove_MoveToSelectStation_Alow = True
          .SelectedIndex = .SelectedIndex + 1
          CW.Maps(CW.MapNo).PerShowStationNo = .SelectedIndex + 1
        End If
        'ShowStationParameter(.SelectedIndex + 1)
      End If
    End With
  End Sub

  Private Sub BtnStationYingYong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStationYingYong.Click
    Dim i, j, k, m As Integer

    If Trim(TextBoxStationNo.Text) <> "" Then

      With CW.Maps(CW.MapNo).Stations(TextBoxStationNo.Text)
        '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[վID����
        m = 0
        If IsNumeric(TextBoxStationID.Text) Then
          k = TextBoxStationID.Text
          For i = 1 To CW.MapAmount
            For j = 1 To CW.Maps(i).MapStationPlacedAmount
              Dim Ti As Integer
              Ti = CW.Maps(i).Stations(j).StationID
              If k = Ti Then
                If Not (i = CW.MapNo And j = TextBoxStationNo.Text) Then
                  MessageBox.Show("�� վID=" & CStr(k) & " �ѱ�ռ�ã�������������롣", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                  m = 1
                  TextBoxStationID.Text = Ti
                  TextBoxStationID.Focus()
                  TextBoxStationID.SelectionStart = 0
                  TextBoxStationID.SelectionLength = TextBoxStationID.Text.Length
                  Exit Sub
                End If
              End If
            Next j
          Next i
          .StationID = StringToLen8(TextBoxStationID.Text)
        Else
          MessageBox.Show("վID�����˷Ƿ�ID�ַ���������������롣", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
          TextBoxStationID.Focus()
          TextBoxStationID.SelectionStart = 0
          TextBoxStationID.SelectionLength = TextBoxStationID.Text.Length
          Exit Sub
        End If
        ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

        '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[ModemID����
        Dim bErr As Boolean
        bErr = False
        If IsNumeric(TextBoxStationModemID.Text) Then
          If CSng(TextBoxStationModemID.Text) < 1 Then
            bErr = True
            MessageBox.Show("ModemID�������0����������롣", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
          Else
            .ModemInfo.ID = TextBoxStationModemID.Text
          End If
        Else
          bErr = True
          MessageBox.Show("ModemID�����˷Ƿ��ַ���������������롣", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If bErr Then
          TextBoxStationModemID.Focus()
          TextBoxStationModemID.SelectionStart = 0
          TextBoxStationModemID.SelectionLength = TextBoxStationID.Text.Length
          Exit Sub
        End If
        ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

        If CheckBoxStationActive.Checked Then
          .Active = True
        Else
          .Active = False
        End If

        .ModemInfo.IP = CheckStringIP(TextBoxStationIP.Text)
        .StationName = TextBoxStationName.Text
        .StationAddress = TextBoxStationAddress.Text
        .StationModeIndex = TextBoxStationModeIndex.Text
        .StationParameterAmount = TextBoxStationParameterAmount.Text

      End With

      ShowStationParameter(CW.MapNo, TextBoxStationNo.Text)
    End If

  End Sub

  Private Sub ComboBoxSelectStation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxSelectStation.Click
    PanelPicBoxMapMove_MoveToSelectStation_Alow = True
  End Sub

  Private Sub ComboBoxSelectStation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectStation.SelectedIndexChanged
    'If btnSendMessageSend.Enabled = False Then Exit Sub
    'PanelPicBoxMapMove_MoveToSelectStation_Alow = False
    SetTabStationInfo(CW.MapNo, ComboBoxSelectStation.SelectedIndex + 1)
    ShowStationParameter(CW.MapNo, ComboBoxSelectStation.SelectedIndex + 1)
    If TabControl1.SelectedIndex = 0 Then
      'PanelPicBoxMapMove_MoveToSelectStation_Alow = True
      'If PanelPicBoxMapMove_MoveToSelectStation_Alow Then

      'End If
      PanelPicBoxMapMove_MoveToSelectStation(ComboBoxSelectStation.SelectedIndex + 1)
      PanelPicBoxMapMove_MoveToSelectStation_Alow = False
    End If

  End Sub

  Private Sub ListBoxTabStationParameter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxTabStationParameter.SelectedIndexChanged
    'Dim i As Integer
    Dim S As String
    SSelectIndex = ListBoxTabStationParameter.SelectedIndex
    LabelSelectNo.Text = "ѡ�в���:" & CStr(SSelectIndex + 1)
    'If BtnStationParameterYingYong.Enabled = False Then Exit Sub

    With CW.Maps(CW.MapNo).Stations(TextBoxStationNo.Text)
      bAChangeTextBoxParameter = True
      If Trim(tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 0)) = "" Then
        If Trim(.StationParameters(SSelectIndex + 1, 0)) <> "" Then
          TextBoxParameter0.Text = .StationParameters(SSelectIndex + 1, 0)
        Else
          TextBoxParameter0.Text = ""
        End If
      Else
        TextBoxParameter0.Text = tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 0)
      End If

      If Trim(tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 1)) = "" Then
        TextBoxParameter1.Text = .StationParameters(SSelectIndex + 1, 1)
      Else
        TextBoxParameter1.Text = tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 1)
      End If

      If Trim(tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 2)) = "" Then
        TextBoxParameter2.Text = .StationParameters(SSelectIndex + 1, 2)
      Else
        TextBoxParameter2.Text = tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 2)
      End If

      If Trim(tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 3)) = "" Then
        '((((((((((((((((((((((((((((((((
        S = .StationParameters(SSelectIndex + 1, 3)
        '))))))))))))))))))))))))))))))))
        TextBoxParameter3.Text = S
      Else
        '((((((((((((((((((((((((((((((((
        S = tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 3)
        '))))))))))))))))))))))))))))))))
        TextBoxParameter3.Text = S
      End If
      bAChangeTextBoxParameter = False
    End With
  End Sub

  Private Sub TextBoxParameter0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxParameter0.TextChanged
    If bAChangeTextBoxParameter = False Then
      BtnStationParameterYingYong.Enabled = True
      If IsNumeric(TextBoxStationNo.Text) Then
        If CSng(TextBoxStationNo.Text) > 0 Then
          tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 0) = TextBoxParameter0.Text
        End If
      End If
    End If
  End Sub
  Private Sub TextBoxParameter1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxParameter1.TextChanged
    If bAChangeTextBoxParameter = False Then
      BtnStationParameterYingYong.Enabled = True
      If IsNumeric(TextBoxStationNo.Text) Then
        If CSng(TextBoxStationNo.Text) > 0 Then
          If IsNumeric(TextBoxParameter1.Text) Then
            tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 1) = TextBoxParameter1.Text
            bMDataChanged = True
          ElseIf TextBoxParameter1.Text = "" Then
            tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 1) = TextBoxParameter1.Text
          End If
        End If
      End If
    End If
  End Sub
  Private Sub TextBoxParameter2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxParameter2.TextChanged
    If bAChangeTextBoxParameter = False Then
      BtnStationParameterYingYong.Enabled = True
      If IsNumeric(TextBoxStationNo.Text) Then
        If CSng(TextBoxStationNo.Text) > 0 Then
          tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 2) = TextBoxParameter2.Text
        End If
      End If
    End If
  End Sub
  Private Sub TextBoxParameter3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxParameter3.TextChanged
    If bAChangeTextBoxParameter = False Then
      BtnStationParameterYingYong.Enabled = True
      If IsNumeric(TextBoxStationNo.Text) Then
        If CSng(TextBoxStationNo.Text) > 0 Then
          If IsNumeric(TextBoxParameter3.Text) Or TextBoxParameter3.Text = "" Then
            tmpStationParameter(TextBoxStationNo.Text, SSelectIndex + 1, 3) = TextBoxParameter3.Text
          End If
        End If
      End If
    End If
  End Sub
  Private Sub TextBoxParameter0_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxParameter0.KeyDown, TextBoxParameter1.KeyDown, TextBoxParameter2.KeyDown, TextBoxParameter3.KeyDown
    BtnStationParameterYingYong.Enabled = True
  End Sub
  Private Sub CheckBoxTabStationParameter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTabStationParameter.CheckedChanged
    BtnStationParameterYingYong.Enabled = True
  End Sub

  Private Sub BtnStationParameterYingYong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStationParameterYingYong.Click, BtnStationParameterQuXiao.Click
    Dim i, j, k, si As Integer
    Dim S As String = sender.tag
    If Not IsNumeric(Trim(TextBoxStationNo.Text)) Then Exit Sub

    With CW.Maps(CW.MapNo)

      Select Case S

        Case "BtnStationParameterYingYong"
          ''''''''''''''��ֻӦ�õ���վ��---200503240516�������ϲŵ�����ȫ��Ӧ�ã�ԭ���ǹ��������ʱ������
          For i = 1 To .Stations(TextBoxStationNo.Text).StationParameterAmount
            'If i > .Stations(TextBoxStationNo.Text).StationParameterAmount Then Exit For
            For j = 0 To 3
              S = tmpStationParameter(TextBoxStationNo.Text, i, j)
              S = Trim(S)
              'If j = 1 Or 3 Then
              '  If Not IsNumeric(S) Then
              '    .Stations(TextBoxStationNo.Text).StationParameters(i, j) = ""
              '    tmpStationParameter(TextBoxStationNo.Text, i, j) = ""
              '  End If
              'Else
              If S <> "" Then
                .Stations(TextBoxStationNo.Text).StationParameters(i, j) = S
                tmpStationParameter(TextBoxStationNo.Text, i, j) = ""
              Else
                If i = ListBoxTabStationParameter.SelectedIndex + 1 Then
                  If j = 1 Then
                    If TextBoxParameter1.Text.Trim = "" Then
                      .Stations(TextBoxStationNo.Text).StationParameters(i, j) = ""
                    End If
                  End If
                  If j = 3 Then
                    If TextBoxParameter3.Text.Trim = "" Then
                      .Stations(TextBoxStationNo.Text).StationParameters(i, j) = ""
                    End If
                  End If
                End If
              End If
              'End If
            Next j
          Next i
          'If .Stations(TextBoxStationNo.Text).Alarm = True Then
          '  .Stations(TextBoxStationNo.Text).StationGif.ReadGIF(SGif.GifFilePath_Alarm)
          'Else
          '  .Stations(TextBoxStationNo.Text).StationGif.ReadGIF(SGif.GifFilePath_OK)
          'End If
          '[[[[[[[[[[[[[[[[[[[[[[[[[200508020029[[[[[[[[[[[[[[[[[[[[[[[[[
          If bMDataChanged Then
            .Stations(TextBoxStationNo.Text).HaveData = True
          End If
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          If CheckBoxTabStationParameter.Checked Then
            '''''''''''''''''''''''''''''''''''''''''''''''��Ӧ�õ�����վ��
            For si = 1 To .MapStationPlacedAmount
              For i = 1 To .Stations(TextBoxStationNo.Text).StationParameterAmount '����ѡվ���������Ϊѭ������
                If i > .Stations(si).StationParameterAmount Then Exit For
                For j = 0 To 3
                  .Stations(si).StationParameters(i, j) = .Stations(TextBoxStationNo.Text).StationParameters(i, j)
                Next j
              Next i
              If .Stations(si).Alarm = True Then
                .Stations(si).StationGif.ReadGIF(SGif.GifFilePath_Alarm)
              Else
                .Stations(si).StationGif.ReadGIF(SGif.GifFilePath_OK)
              End If
              '[[[[[[[[[[[[[[[[[[[[[[[[[200508020029[[[[[[[[[[[[[[[[[[[[[[[[[
              'If bMDataChanged Then
              .Stations(si).HaveData = .Stations(TextBoxStationNo.Text).HaveData
              'End If
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
            Next si

          End If
          bMDataChanged = False
          BtnStationParameterYingYong.Enabled = False
          'SetTabStationInfo(TextBoxStationNo.Text)
          SetTabStationInfo(CW.MapNo, TextBoxStationNo.Text)

          ShowStationParameter(CW.MapNo, TextBoxStationNo.Text)

          ''''''''''''''''''''''''''''''''''''''''�Ժ�ü��ϴ������ݿ����

        Case "BtnStationParameterQuXiao"
          '[[[[[[[[[[[[[[[[[[[[[[[[[200508020029[[[[[[[[[[[[[[[[[[[[[[[[[
          bMDataChanged = False
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          CheckBoxTabStationParameter.Checked = False
          For k = 1 To .MapStationPlacedAmount
            For i = 1 To STATION_PROPERTY_MAX_NO
              If i > .Stations(k).StationParameterAmount Then Exit For
              For j = 0 To 3
                tmpStationParameter(TextBoxStationNo.Text, i, j) = ""
              Next j
            Next i
          Next k
          BtnStationParameterYingYong.Enabled = False
          SetTabStationInfo(CW.MapNo, TextBoxStationNo.Text)
          ShowStationParameter(CW.MapNo, TextBoxStationNo.Text)
      End Select
    End With
  End Sub
  Private Sub BtnDelStation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelStation.Click

    If IsNumeric(TextBoxStationNo.Text) Then
      If MessageBox.Show("���Ҫɾ�� " & TextBoxStationNo.Text & "�ţ�" & CW.Maps(CW.MapNo).Stations(TextBoxStationNo.Text).StationName & " վ����", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
        If CSng(TextBoxStationNo.Text) > 0 Then
          CW.Maps(CW.MapNo).DelStation(TextBoxStationNo.Text)
          SetMapStationSelectComboBox("s")
          If CW.Maps(CW.MapNo).MapStationPlacedAmount > 0 Then
            SetTabStationInfo(CW.MapNo, 1)
          Else
            SetTabStationInfo(CW.MapNo, 0)
          End If
        End If
      End If
    End If
  End Sub

  Private Sub CheckBoxStationActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStationActive.CheckedChanged
    BtnStationYingYong.Enabled = True
  End Sub

  Private Sub ComboBoxSelectMap0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxSelectMap0.Click
    ComboBoxSelectMap0Or1 = 0
  End Sub
  Private Sub ComboBoxSelectMap0_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectMap0.SelectedIndexChanged
    If SetMapStationSelectComboBoxRun Then Exit Sub
    If ComboBoxSelectMap0Or1 = 1 Then Exit Sub
    'If btnSendMessageSend.Enabled = False Then Exit Sub
    If Form1Run Then
      ComboBoxSelectMap1.SelectedIndex = ComboBoxSelectMap0.SelectedIndex
      SelectMap(ComboBoxSelectMap0.SelectedIndex + 1)
    End If
  End Sub
  Private Sub ComboBoxSelectMap1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxSelectMap1.Click
    ComboBoxSelectMap0Or1 = 1
  End Sub
  Private Sub ComboBoxSelectMap1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectMap1.SelectedIndexChanged
    If SetMapStationSelectComboBoxRun Then Exit Sub
    If ComboBoxSelectMap0Or1 = 0 Then Exit Sub
    'If btnSendMessageSend.Enabled = False Then Exit Sub
    If Form1Run Then
      ComboBoxSelectMap0.SelectedIndex = ComboBoxSelectMap1.SelectedIndex
      SelectMap(ComboBoxSelectMap1.SelectedIndex + 1)
    End If
  End Sub

  Private Sub MenuItemTXStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTXStartServer.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    If bStop = False Then Exit Sub

    Me.ServiceStart()

  End Sub

  Private Sub MenuItemTXStopServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTXStopServer.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    If bStop Then Exit Sub

    If CW.ATX_Runing Then
      MessageBox.Show("���ȹر��Զ���ѯ��ֹͣ����", "��ʾ", MessageBoxButtons.OK)
      Exit Sub
    End If

    NumUDID.Text = 0
    ComboBoxOnLineStationInfo.Items.Clear()
    ComboBoxOnLineStationInfo.Text = ""
    LstSuccess.Items.Clear()
    txtPCount.Text = HZY
    AxAniGIFOnLine.Visible = False
    Me.ServiceEnd()

  End Sub
  Private Sub ToolBarTongXun_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarTongXun.ButtonClick

    If (e.Button Is Me.ToolBarTXStartServer) Then '��������
      'If bStop = False Then Exit Sub

      MenuItemTXStartServer_Click(sender, e)

    ElseIf (e.Button Is Me.ToolBarTXStopServer) Then 'ֹͣ����
      'If bStop Then Exit Sub

      MenuItemTXStopServer_Click(sender, e)

    ElseIf (e.Button Is Me.ToolBarButtonTXSetting) Then '����
      MenuItemTXSetting_Click(sender, e)
      'ElseIf (e.Button Is Me.btnConfig) Then '����
      '  Dim config As New FrmConfig
      '  config.ShowDialog(Me)
      'ElseIf (e.Button Is Me.btnSend) Then '����

      '  If lstInfo.Items.Count <> 0 Then
      '    Dim send As New FrmSend
      '    send.setFrmSendId(lstInfo.FocusedItem.SubItems(0).Text)
      '    send.setFrmSendTelNo(lstInfo.FocusedItem.SubItems(1).Text)
      '    send.setFrmSendTime(lstInfo.FocusedItem.SubItems(2).Text)
      '    send.setFrmSendIp(lstInfo.FocusedItem.SubItems(3).Text)
      '    send.setFrmMain(Me)
      '    send.ShowDialog(Me)
      '  End If

      'ElseIf (e.Button Is Me.btnExit) Then '�˳�
      '  Dim chooseAction As Int32
      '  chooseAction = MsgBox("��ȷ���˳���", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Constant.msgTitle)
      '  If chooseAction = Constants.vbYes Then
      '    Me.Close()
      '    Application.Exit()
    End If

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    'If CheckHavePrinter() Then
    MenuItemPrintXX_Click(sender, e)
    'Else
    '  MessageBox.Show("ϵͳû�а�װ��ӡ�������Ȱ�װ��ӡ����")
    'End If
    'If cw.active = False Then Exit Sub
    'Dim MyPrint As New Form4Print
    'MyPrint.Show()
  End Sub

  Private Sub ComboBoxSelectMap0_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBoxSelectMap0.MouseMove
    'ComboBoxSelectMap0.Items()
  End Sub



  Private Sub ButtonPerMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPerMap.Click
    If ComboBoxSelectMap0.Items.Count > 0 Then
      ComboBoxSelectMap0Or1 = 0
      If ComboBoxSelectMap0.SelectedIndex > 0 Then
        ComboBoxSelectMap0.SelectedIndex -= 1
      End If
    End If
  End Sub

  Private Sub BtnNextMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextMap.Click
    If ComboBoxSelectMap0.Items.Count > 0 Then
      ComboBoxSelectMap0Or1 = 0
      If ComboBoxSelectMap0.SelectedIndex < ComboBoxSelectMap0.Items.Count - 1 Then
        ComboBoxSelectMap0.SelectedIndex += 1
      End If
    End If
  End Sub

  Private Sub MenuWorkSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuWorkSetting.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    Dim FormWorkSetting As New Form2WorkSetting
    FormWorkSetting.Show()
  End Sub

  Private Sub MenuItemTXSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTXSetting.Click
    If ActivePerson.Active = False Then Exit Sub
    If CW.Active = False Then Exit Sub
    Dim tmpFrm As New Form3TXSetting
    tmpFrm.Show()
  End Sub

  Private Sub MenuItemSettingPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSettingPerson.Click
    If ActivePerson.Active = False Then
      MessageBox.Show("���ȵ�¼��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Dim F As New Form9User
    F.Show()
  End Sub

  Private Sub MenuItemChaXun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemChaXun.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    Dim frmLoadDB As New Form8LoadDB
    frmLoadDB.Show()
    'Dim TabLoadDB As New TabPage
    'TabControl1.TabPages.Add(TabLoadDB)
    'With TabLoadDB
    '  .Name = "TabLoadDB"
    '  .Text = "��ѯ"
    '  .ImageIndex = 3
    'End With
    'TabControl1.SelectedIndex = 3
    'Dim PanelLoadDB As New Panel
    'With PanelLoadDB
    '  .Parent = TabLoadDB
    '  .Size = PanelComm.Size
    '  .BorderStyle = BorderStyle.Fixed3D
    '  .Location = New Point(0, 0)
    '  .Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
    'End With

  End Sub

  Private Sub MenuItemSaveShuJu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSaveShuJu.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    bForm7SaveLoad = True
    Dim FormSave As New Form7SaveDB
    FormSave.Show()
  End Sub

  Private Sub AniGifMainForm_MouseUpEvent(ByVal sender As Object, ByVal e As AxAniGIFCtrl.IAniGIFEvents_MouseUpEvent) Handles AniGifMainForm.MouseUpEvent
    '��Ҫɾ��ί����
  End Sub

  Private Sub MenuItemViewMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemViewMap.Click
    If ActivePerson.Active = False Then Exit Sub
    TabControl1.SelectedIndex = 0
  End Sub

  Private Sub MenuItemViewStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemViewStation.Click
    If ActivePerson.Active = False Then Exit Sub
    TabControl1.SelectedIndex = 1
  End Sub

  Private Sub MenuItemViewTX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemViewTX.Click
    If ActivePerson.Active = False Then Exit Sub
    TabControl1.SelectedIndex = 2
  End Sub

  Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    If ActivePerson.Active = True Then
      e.Cancel = True
      BtnLogout_Click(sender, e)
    End If
    'If ExitOk = False Then

    'End If
  End Sub

  Private Sub MenuItemLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemLogout.Click
    If PanelPassword.Visible Then Exit Sub
    AUsers.ActiveNo = -1
    ActivePerson.Active = False
    Me.Controls.Add(PanelPassword)
    PanelPassword.BringToFront()
    'TabControl1.SendToBack()
    'PanelToolBar.SendToBack()
    TextBoxPassword.Text = ""
    CheckBoxPassword.Checked = False
    PanelPassword.Visible = True

  End Sub

  Private Sub BtnOpenWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenWork.Click
    'If cw.active = True Then Exit Sub
    MenuItemOpenWork_Click(sender, e)
  End Sub

  Private Sub BtnSaveWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveWork.Click
    MenuItemSaveWork_Click(sender, e)
  End Sub

  Private Sub MenuItemAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAbout.Click
    Dim AboutForm As New Form5About
    AboutForm.Show()
  End Sub

  Private Sub MenuItemSaveWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSaveWork.Click

    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    If PM.VerMode = "Demo" Then
      MessageBox.Show("��Ǹ������Ϊ��ʾ�棬���ܴ洢���̡��������������빺����ʽ�档", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    SaveFileDialogWork.DefaultExt = Default_GprsWork_INIFilesName
    SaveFileDialogWork.Filter = "HZY-GPRSϵͳ�����ļ� (*." & Default_GprsWork_INIFilesName & ")|*." & Default_GprsWork_INIFilesName
    SaveFileDialogWork.InitialDirectory = CW.WorkPath
    SaveFileDialogWork.ShowDialog()
    If SaveFileDialogWork.FileName <> "" Then
      RWGprsWorkINI(SaveFileDialogWork.FileName, False)
      Dim i, j As Integer
      Dim S As String
      S = RorWCWMapInfoMDB(False)
      If S <> "" Then
        MessageBox.Show("���湤����Ϣ���ִ���,������̽��жϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
      End If
      j = CW.MapAmount
      For i = 1 To j
        S = RorWMapStationInfoMDB(i, False)
        If S <> "" Then
          If i < j Then
            If MessageBox.Show("�����ͼ" & CStr(i) & "���ִ���[" & S & "]���Ƿ��������������ͼ��Ϣ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit For
          End If
        End If
      Next i
      MessageBox.Show("�洢��ϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub MenuItemPrintXX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPrintXX.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    If CheckHavePrinter() Then
      Dim MyPrint As New Form4Print
      MyPrint.Show()
    Else
      MessageBox.Show("ϵͳû�а�װ��ӡ�������Ȱ�װ��ӡ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

  Private Sub MenuItemPrintLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPrintLS.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    If CheckHavePrinter() Then
      Dim FormPrintLS As New Form6PrintLS
      FormPrintLS.Show()
    Else
      MessageBox.Show("ϵͳû�а�װ��ӡ�������Ȱ�װ��ӡ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

  Private Sub BtnPrintLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintLS.Click
    MenuItemPrintLS_Click(sender, e)
  End Sub

  Private Sub ButtonSaveDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveDB.Click
    MenuItemSaveShuJu_Click(sender, e)
  End Sub

  Private Sub ButtonLoadDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadDB.Click
    MenuItemChaXun_Click(sender, e)

  End Sub
  Private Sub BtnViewDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewDB.Click
    MenuItemFlexTChart_Click(sender, e)
  End Sub
  Private Sub BtnLieBiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLieBiao.Click
    MenuItemFlexTChart_Click(sender, e)
  End Sub

  Private Sub ComboBoxPersonName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPersonName.SelectedIndexChanged
    TextBoxPassword.Text = ""
    CheckBoxPassword.Checked = False
  End Sub

  Private Sub TextBoxPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPassword.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
      BtnIn_Click(sender, e)
    End If
  End Sub

  Private Sub AxShockwaveFlashMainForm_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlashMainForm.Enter

  End Sub

  Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '���̹߳ر�
    If Not threadMain Is Nothing Then
      Try
        bStop = True
        'threadMain.Join()
        threadMain.Abort()
      Catch ex As ThreadStateException
        MessageBox.Show("threadMain.abort ::: " & ex.Message)
      End Try
    End If
  End Sub

  Private Sub lstInfo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstInfo.SelectedIndexChanged
    Dim i As Integer
    i = lstInfo.SelectedItems.Count
    If i > 0 Then
      NumUDID.Text = lstInfo.Items.Item(lstInfo.SelectedItems(0).Index).Text
      ComboBoxOnLineStationInfo.SelectedIndex = lstInfo.SelectedItems(0).Index
    End If
  End Sub

  Private Sub RaBtnM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RaBtnM.CheckedChanged
    Dim S As String
    If RaBtnM.Checked Then
      TabShowComm.Controls.Add(GrpMTX)
      GrpMTX.Location = New Point(TabControl1.Width - 212, 10)
      GrpMTX.Visible = True
      S = "1"
      RadBtnSin.Checked = True
    Else
      GrpMTX.Visible = False
      S = "0"
    End If
    RWIni(False, CW.GPRSWorkFilePath, "TX", "MTX", S)
  End Sub
  Private Sub RaBtnA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RaBtnA.CheckedChanged
    Dim S As String
    If RaBtnA.Checked Then
      TabShowComm.Controls.Add(GrpATX)
      GrpATX.Location = New Point(TabControl1.Width - 212, 10)
      GrpATX.Visible = True
      S = "0"
      RadBtnSin.Checked = True
    Else
      GrpATX.Visible = False
      S = "1"
    End If
    RWIni(False, CW.GPRSWorkFilePath, "TX", "MTX", S)
  End Sub

  Private Sub ChkAutoStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAutoStart.CheckedChanged
    Dim S As String
    If ChkAutoStart.Checked Then
      S = "1"
    Else
      S = "0"
    End If
    RWIni(False, CW.GPRSWorkFilePath, "TX", "AutoServiceStart", S)

  End Sub

  Private Sub ChkRevTest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRevTest.CheckedChanged
    Dim S As String
    If ChkRevTest.Checked Then
      S = "1"
    Else
      S = "0"
    End If
    RWIni(False, CW.GPRSWorkFilePath, "TX", "RevTestData", S)
  End Sub

  Private Sub GprsRealSend()
    Dim sendResult As Int32
    sendResult = GprsMod.DSSendData(FSendOneModemID, FSendOneDataLen, FSendOneData(0))
  End Sub
  Private Overloads Function FSendOne(ByVal ModemID As String, ByVal Data() As Byte) As Boolean
    Dim sendResult As Int32
    Dim sendId As Int32
    Dim sendResultClen As Int32
    Dim sendResultSrc() As Byte
    sendResultSrc = New Byte(1451) {}
    FSendOneData = New Byte(1451) {}
    Dim i, M As Integer

    If Data.Length > 1451 Then
      M = 1451
    Else
      M = Data.Length - 1
    End If
    For i = 0 To M
      sendResultSrc(i) = Data(i)
      FSendOneData(i) = Data(i)
    Next

    FSendOne = False

    sendId = CType(Val("&H" & ModemID), Int32)
    FSendOneModemID = sendId

    sendResultClen = Data.Length
    FSendOneDataLen = Data.Length


    Try
      '(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((
      sendResult = GprsMod.DSSendData(sendId, sendResultClen, Data(0))
      'Dim tData(10) As Byte

      'tData(0) = 1
      'For i = 1 To 9
      '  tData(i) = i
      'Next
      'tData(10) = 9
      'sendResult = GprsMod.DSSendData(sendId, 11, tData(0))

      'sendResult = GprsMod.DSSendData(FSendOneModemID, FSendOneDataLen, FSendOneData(0))
      'Dim tT As Thread
      'Try
      '  tT = New Thread(AddressOf GprsTealSend)
      '  'ThreadASend = New Thread(ThreadTSAsend)
      '  Application.DoEvents()
      '  tT.Start()
      '  tT.Join()
      '  tT.Abort()
      '  tT = Nothing
      'Catch ex As ThreadStateException
      '  MessageBox.Show("�߳�����::: " & ex.Message)
      'End Try

      ')))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
      Application.DoEvents()

      SetAddTextColor()
      If sendResult = 1 Then
        FSendOne = True
        AddText("����ID��" & CStr(ModemID) & " �ɹ���")
      Else
        FSendOne = False
        AddText("����ID��" & CStr(ModemID) & " ʧ�ܣ�")
      End If
    Catch ex As Exception
      FSendOne = False
      AddText("����ID��" & CStr(ModemID) & ex.Message & "��")
    End Try

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    Dim Ascii As New System.Text.ASCIIEncoding
    Dim ShowData As String = Mid(Ascii.GetString(Data), 1, Data.Length)
    Dim sDataBuf As String

    'data(rvData.m_Data_Len) = 0
    sDataBuf = byteToHexStr(Data, Data.Length)
    AddText("Send data>>>" + "------------------------------------------------------------------------------------------------------------------")
    AddText(sDataBuf)
    AddText(("�������ݣ�" + ShowData))
    AddText("------------------------------------------------------------------------------------------------------------------------------")

    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  End Function

  Private Overloads Function FSendOne(ByVal ModemID As String, ByVal SDBakNo As Integer, ByVal SDBakArray() As GprsSendDataBackup) As Boolean
    'SDBakNo ��Ϊ�˼�¼����ʱ��
    Dim sendResult As Int32
    Dim sendId As Int32
    Dim sendResultClen As Int32
    Dim sendResultSrc() As Byte
    Dim i, M As Integer

    sendResultSrc = New Byte(1451) {}

    If SDBakArray(SDBakNo).SendByteArray.Length > 1451 Then
      M = 1451
    Else
      M = SDBakArray(SDBakNo).SendByteArray.Length - 1
    End If
    For i = 0 To M
      sendResultSrc(i) = SDBakArray(SDBakNo).SendByteArray(i)
    Next

    FSendOne = False
    'Dim sendResultSrc As Byte

    sendId = CType(Val("&H" & ModemID), Int32)

    'sendResultSrc = New Byte(1451) {}

    sendResultClen = SDBakArray(SDBakNo).SendByteArray.Length
    'For i = 0 To Data.Length - 1
    '  sendResultSrc(i) = Data(i)
    'Next
    '[[[[[[[[[[[[[[[20071028,�Զ���ѯ���������쳣�������Try������[[[��ȷ���������������
    '    ************** �쳣�ı� **************
    'System.NullReferenceException: δ�������������õ������ʵ����
    '    ��(GPRS.Form1.ThreadRevASend())
    '   �� GPRS.Form1.TimerATXRev_Tick(Object sender, EventArgs e)
    '   �� System.Windows.Forms.Timer.OnTick(EventArgs e)
    '   �� System.Windows.Forms.Timer.TimerNativeWindow.WndProc(Message& m)
    '   �� System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)
    Try
      sendResult = GprsMod.DSSendData(sendId, sendResultClen, SDBakArray(SDBakNo).SendByteArray(0))
      Application.DoEvents()
      'SDBakArray(SDBakNo).SendByteArray = Data
      SetAddTextColor()
      If sendResult = 1 Then
        SDBakArray(SDBakNo).SendDate = Now
        FSendOne = True
        SDBakArray(SDBakNo).SendSuccess = True
        AddText("����ID��" & CStr(ModemID) & " �ɹ���")
      Else
        SDBakArray(SDBakNo).SendSuccess = False
        FSendOne = False
        AddText("����ID��" & CStr(ModemID) & " ʧ�ܣ�")
      End If
    Catch ex As Exception
      SDBakArray(SDBakNo).SendSuccess = False
      FSendOne = False
      SetAddTextColor()
      AddText("����ID��" & CStr(ModemID) & ex.Message & "��")
    End Try
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    Dim Ascii As New System.Text.ASCIIEncoding
    Dim ShowData As String = Mid(Ascii.GetString(SDBakArray(SDBakNo).SendByteArray), 1, SDBakArray(SDBakNo).SendByteArray.Length)
    Dim sDataBuf As String

    'data(rvData.m_Data_Len) = 0
    sDataBuf = byteToHexStr(SDBakArray(SDBakNo).SendByteArray, SDBakArray(SDBakNo).SendByteArray.Length)
    AddText("Send data>>>" + "------------------------------------------------------------------------------------------------------------------")
    AddText(sDataBuf)
    AddText(("�������ݣ�" + ShowData))
    AddText("------------------------------------------------------------------------------------------------------------------------------")

    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  End Function
  Private Function BuildSendByte(ByVal ClientID As String, ByVal HostID As String, ByVal DataMode As String, ByVal DataString As String, ByVal BuildByteArry() As Byte) As Boolean
    Dim i, DataLen As Integer
    'Dim S As String
    'Dim tByte() As Byte
    DataLen = Len(DataString)
    'If DataLen < 1 Then
    '  Data = "1"
    '  DataLen = 1
    'End If
    'ReDim BuildByteArry(21 + DataLen - 1)'��������棬��Ȼ����Ϊ��
    BuildByteArry(0) = SD_Start
    'tByte(1) = CType(Val("&H" & ClientID), Int32)

    For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''Ŀ��ID
      If i <= 8 - Len(ClientID) Then '�����ַ���С�ڰ˸�
        BuildByteArry(i) = 0
      Else
        BuildByteArry(i) = CSng(Mid(ClientID, (i - 8 + Len(ClientID)), 1))
      End If
    Next

    For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''����ID
      If i <= 8 - Len(HostID) Then '�����ַ���С�ڰ˸�
        BuildByteArry(8 + i) = 0
      Else
        BuildByteArry(8 + i) = CSng(Mid(HostID, (i - 8 + Len(HostID)), 1))
      End If
    Next

    '(((((((((((((((((((((((((((((((((((((((
    'For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''Ŀ��ID
    '  If i <= 8 - Len(HostID) Then '�����ַ���С�ڰ˸�
    '    BuildByteArry(i) = 0
    '  Else
    '    BuildByteArry(i) = CSng(Mid(HostID, (i - 8 + Len(HostID)), 1))
    '  End If
    'Next

    'For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''����ID
    '  If i <= 8 - Len(ClientID) Then '�����ַ���С�ڰ˸�
    '    BuildByteArry(8 + i) = 0
    '  Else
    '    BuildByteArry(8 + i) = CSng(Mid(ClientID, (i - 8 + Len(ClientID)), 1))
    '  End If
    'Next
    ')))))))))))))))))))))))))))))))))))))))
    DataMode = Trim(DataMode)
    If Len(DataMode) <> 1 Then
      DataMode = TXDM.T
    End If
    If DataMode <> TXDM.P And DataMode <> TXDM.S And DataMode <> TXDM.R And DataMode <> TXDM.A And DataMode <> TXDM.T Then
      DataMode = TXDM.T
    End If
    BuildByteArry(17) = AscW(DataMode)

    BuildByteArry(18) = DataLen

    For i = 1 To DataLen
      BuildByteArry(i + 18) = AscW(Mid(DataString, i, 1))
    Next

    BuildByteArry(DataLen + 19) = JYHByte(BuildByteArry, 1, DataLen + 18)

    BuildByteArry(DataLen + 20) = &H6A

    'ASCIIEncoding.ASCII(DataMode)

  End Function
  Private Function BuildSendByteSendMessage(ByVal ClientID As String, ByVal HostID As String, ByVal DataMode As String, ByVal DataByte() As Byte, ByVal BuildByteArry() As Byte) As Boolean
    Dim i, DataLen As Integer
    'Dim S As String
    'Dim tByte() As Byte
    DataLen = DataByte.GetUpperBound(0) + 1
    'If DataLen < 1 Then
    '  Data = "1"
    '  DataLen = 1
    'End If
    'ReDim BuildByteArry(21 + DataLen - 1)'��������棬��Ȼ����Ϊ��
    BuildByteArry(0) = SD_Start
    'tByte(1) = CType(Val("&H" & ClientID), Int32)

    For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''Ŀ��ID
      If i <= 8 - Len(ClientID) Then '�����ַ���С�ڰ˸�
        BuildByteArry(i) = 0
      Else
        BuildByteArry(i) = CSng(Mid(ClientID, (i - 8 + Len(ClientID)), 1))
      End If
    Next

    For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''����ID
      If i <= 8 - Len(HostID) Then '�����ַ���С�ڰ˸�
        BuildByteArry(8 + i) = 0
      Else
        BuildByteArry(8 + i) = CSng(Mid(HostID, (i - 8 + Len(HostID)), 1))
      End If
    Next

    '(((((((((((((((((((((((((((((((((((((((
    'For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''Ŀ��ID
    '  If i <= 8 - Len(HostID) Then '�����ַ���С�ڰ˸�
    '    BuildByteArry(i) = 0
    '  Else
    '    BuildByteArry(i) = CSng(Mid(HostID, (i - 8 + Len(HostID)), 1))
    '  End If
    'Next

    'For i = 1 To 8 '''''''''''''''''''''''''''''''''''''''''''''''''����ID
    '  If i <= 8 - Len(ClientID) Then '�����ַ���С�ڰ˸�
    '    BuildByteArry(8 + i) = 0
    '  Else
    '    BuildByteArry(8 + i) = CSng(Mid(ClientID, (i - 8 + Len(ClientID)), 1))
    '  End If
    'Next
    ')))))))))))))))))))))))))))))))))))))))
    DataMode = Trim(DataMode)
    If Len(DataMode) <> 1 Then
      DataMode = TXDM.T
    End If
    If DataMode <> TXDM.P And DataMode <> TXDM.S And DataMode <> TXDM.R And DataMode <> TXDM.A And DataMode <> TXDM.T Then
      DataMode = TXDM.T
    End If
    BuildByteArry(17) = AscW(DataMode)

    BuildByteArry(18) = DataLen

    For i = 1 To DataLen
      BuildByteArry(i + 18) = DataByte(i - 1)
    Next

    BuildByteArry(DataLen + 19) = JYHByte(BuildByteArry, 1, DataLen + 18)

    BuildByteArry(DataLen + 20) = &H6A

    'ASCIIEncoding.ASCII(DataMode)

  End Function

  Private Sub BtnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
    Dim tByte() As Byte
    Dim S As String
    Dim i, DataLen As Integer
    'Dim tB As Byte
    Dim StationID, ModemID As String
    Dim bSuc As Boolean

    If CW.ATX_Runing Then
      If MessageBox.Show("���������Զ���ѯ���ֶ���ѯ����Ӱ�쵽�Զ���ѯ��ͨѶ���Ƿ������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
        Exit Sub
      End If
    End If

    If bAsend Then
      MessageBox.Show("���ڽ����Զ���ѯ��ͨѶ�����Ժ����ԡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    If bStop Then
      MessageBox.Show("��û�����ߡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    If bMsend Then
      MessageBox.Show("����ͨѶ�����Ժ����ԡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    If RadBtnSin.Checked Then
      If NumUDID.Text = "" Or NumUDID.Text < 1 Then
        MessageBox.Show("���ڷ���ǰ��ȷѡ������վ�㡣", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
    End If

    If RadBtnAll.Checked Then
      If lstInfo.Items.Count < 1 Then
        MessageBox.Show("û������վ�㣬���ܷ��͡�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
    End If

    ''''''''''''''''''''''''''���������ռ�ʱ��
    CW.bMsendRevHaveData = False
    TimerThreadRevMSend.Start()
    bMsend = True
    bMsendED = True 'һ��ʼ����True��Ϊ�˷�ֹ��û��������Ѿ��л�Ӧ��������
    bMsendMAbort = False
    gifMSend.ReadGIF(SGif.GifMSendStart)
    gifMSend.Playing = True
    gifMSend.BringToFront()

    ''''''''''''''''''''''''''''''''''''''''''''''''''''����÷�����

    If RadBtnSin.Checked Then 'ֻһ��վ�㷢��

      '[[[[[[[[[[[[[[[[[[[[[[[[20051125�ŵ�ǰ���ˣ��жϺ��������߳�[[[[[[[[[[[[[[[[[[[[[[[[[[
      ModemID = StringToLen8(NumUDID.Text)
      StationID = ModemIDtoStationID(ModemID)
      If StationID = "" Then
        MessageBox.Show("��ѡվ��û�����ã������ú���ͨѶ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      '''''''''''''''''''�����ź����ˣ���������Ӧ�÷��ڷ���ǰ���������߳�200508191723
      'Try
      '  ThreadTSMsend = New ThreadStart(AddressOf ThreadRevMSend)
      '  ThreadMSend = New Thread(ThreadTSMsend)
      '  LstSuccess.Items.Clear()
      '  bMsend = True
      '  bMsendMAbort = False
      '  gifMSend.ReadGIF(SGif.GifMSendStart)
      '  gifMSend.BringToFront()
      '  'BtnGifMSend.Image = Image.FromFile(SGif.GifMSendStart)
      '  Application.DoEvents()
      '  ThreadMSend.Start()
      'Catch ex As ThreadStateException
      '  MessageBox.Show("�߳�����::: " & ex.Message)
      'End Try

      ReDim MSDBak(0)
      MSDBak(0) = Nothing
      MSDBak(0) = New GprsSendDataBackup
      MSDBak(0).ModemID = ModemID
      MSDBak(0).StationID = StationID
      MSDBak(0).DataMode = SendMode
      '(((((((((((((((((((((((((((
      S = MSDBak(0).DataMode
      ')))))))))))))))))))))))))))
      MSDBak(0).DataString = RtxtSendData.Text
      MSDBak(0).ReSendNo = 0
      MSDBak(0).RevED = False
      MSDBak(0).RevSuccess = False
      MSDBak(0).SendSuccess = False
      '''''''''''''''''''''''''''''''''''�Ժ���϶����ĵ�֧�֣��������������
      DataLen = Len(RtxtSendData.Text)

      ReDim tByte(SendData_BasicLong + DataLen - 1)
      BuildSendByte(StationID, Host_ID, MSDBak(0).DataMode, MSDBak(0).DataString, tByte)
      MSDBak(0).SendByteArray = tByte
      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
      bSuc = True
      If FSendOne(ModemID, 0, MSDBak) = False Then  '��������ʧ����ͨѶʧ��,�淢��ʱ����
        If FSendOne(ModemID, 0, MSDBak) = False Then
          If FSendOne(ModemID, 0, MSDBak) = False Then
            bSuc = False
          End If
        End If
      End If

      If bSuc Then
        'bMsendED = True
        MSDBak(0).SendSuccess = True
        MSDBak(0).ReSendNo = 0
        MSDBak(0).RevED = False '���ˣ����True��
        MSDBak(0).RevSuccess = False
        AddText("����ModemID��" & ModemID & " " & MSDBak(0).DataMode & "����ɹ���")
      Else
        'bMsend = False
        MSDBak(0).StationID = ""
        MSDBak(0).SendSuccess = True
        MSDBak(0).ReSendNo = TX_RetryNo - 1
        MSDBak(0).RevED = True
        MSDBak(0).RevSuccess = False
        AddText("����ModemID��" & ModemID & " " & MSDBak(0).DataMode & " ����ʧ�ܡ�")
      End If
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    Else '''''''''''''''''''''''''''''''''''''''''''''''''''''����վ�㷢��

      ReDim MSDBak(lstInfo.Items.Count - 1)

      For i = 0 To lstInfo.Items.Count - 1 ''''''''''''''''''''''''20071028
        MSDBak(i) = Nothing
        MSDBak(i) = New GprsSendDataBackup
        MSDBak(i).ModemID = ""
        'MSDBak(i).StationID = ""
        'MSDBak(i).DataMode = SendMode
        'MSDBak(i).DataString = ""
        'MSDBak(i).ReSendNo = 0
        'MSDBak(i).RevED = False
        'MSDBak(i).RevSuccess = False
        'MSDBak(i).SendSuccess = False
      Next i

      For i = 0 To lstInfo.Items.Count - 1
        'MSDBak(i) = Nothing
        S = lstInfo.Items(i).Text
        'NumUDID.Text = S
        ModemID = StringToLen8(S)
        StationID = ModemIDtoStationID(ModemID)
        'MSDBak(i) = New GprsSendDataBackup
        If StationID <> "" Then
          MSDBak(i).ModemID = ModemID
          MSDBak(i).StationID = StationID
          MSDBak(i).DataMode = SendMode
          MSDBak(i).DataString = RtxtSendData.Text
          MSDBak(i).ReSendNo = 0
          MSDBak(i).RevED = False
          MSDBak(i).RevSuccess = False
          MSDBak(i).SendSuccess = False
          'If DataLen < 1 The
          '  MSDBak(i).DataString = "1"
          '  DataLen = 1
          'End If
          ReDim tByte(SendData_BasicLong + DataLen - 1)

          BuildSendByte(StationID, Host_ID, MSDBak(i).DataMode, MSDBak(i).DataString, tByte)
          MSDBak(i).SendByteArray = tByte

          bSuc = True
          If FSendOne(ModemID, i, MSDBak) = False Then  '��������ʧ����ͨѶʧ��
            If FSendOne(ModemID, i, MSDBak) = False Then
              If FSendOne(ModemID, i, MSDBak) = False Then
                bSuc = False
              End If
            End If
          End If
          If bSuc Then
            MSDBak(i).SendSuccess = True
            MSDBak(i).ReSendNo = 0
            MSDBak(i).RevED = False
            MSDBak(i).RevSuccess = False
            AddText("����ModemID��" & ModemID & " " & MSDBak(i).DataMode & "����ɹ���")
          Else
            MSDBak(i).StationID = ""
            MSDBak(i).SendSuccess = True
            MSDBak(i).ReSendNo = TX_RetryNo - 1
            MSDBak(i).RevED = True
            MSDBak(i).RevSuccess = False
            AddText("����ModemID��" & ModemID & " " & MSDBak(i).DataMode & "����ʧ�ܡ�")
          End If
        Else
          MSDBak(i).StationID = ""
          MSDBak(i).SendSuccess = True
          MSDBak(i).ReSendNo = TX_RetryNo - 1
          MSDBak(i).RevED = True
          MSDBak(i).RevSuccess = False
          AddText("ModemID:" & ModemID & " û������վID������δ���͡�")
        End If
      Next i
      'bMsendED = True
    End If


    ''''''''''''''''''''''''''''''''''''''''''''''��������������߳���
    ''ThreadRevMSend()
    'Try
    '  ThreadTSMsend = New ThreadStart(AddressOf ThreadRevMSend)
    '  ThreadMSend = New Thread(ThreadTSMsend)
    '  LstSuccess.Items.Clear()
    '  bMsend = True
    '  bMsendMAbort = False
    '  gifMSend.ReadGIF(SGif.GifMSendStart)
    '  gifMSend.BringToFront()
    '  'BtnGifMSend.Image = Image.FromFile(SGif.GifMSendStart)
    '  Application.DoEvents()
    '  ThreadMSend.Start()
    'Catch ex As ThreadStateException
    '  MessageBox.Show("�߳�����::: " & ex.Message)
    'End Try

  End Sub

  Private Sub ThreadRevMSend()
    '���ռ�ʱ��TimerThreadRevMSend_Tick�����Ĺ���
    Dim i, j, k As Integer
    Dim WillEnd As Boolean
    Dim bSuc As Boolean = False
    Dim ModemID As String
    Dim SDBakStops As Integer

    'While True'''''''''''''''ѭ���ô�����ʱ��ȡ��200512280111
    '�ֶ���ֹ����
    If bMsendMAbort Then
      '�رռ�ʱ��
      TimerThreadRevMSend.Stop()
      bMsend = False
      bMsendMAbort = False
      gifMSend.ReadGIF(SGif.GifMsendStop)
      gifMSend.BringToFront()
      Exit Sub
    End If

    If bMsendED Then '��������û��

      WillEnd = True '�����óɼ���ѭ�������ж�

      SDBakStops = 0 ''''�м���վ�����ͣ��
      For i = 0 To MSDBak.Length - 1 '''''''''''''''''''''Ȼ�󰤸��жϸ�վ��Ľ������

        Try
          If MSDBak(i).ModemID <> "" Then ''''20071029˵���Ƿ��͹���

            Dim B1, B2, B3 As Boolean

            If MSDBak(i).StationID <> "" Then ''''''''''''''

              B1 = MSDBak(i).SendSuccess
              B2 = MSDBak(i).RevED
              B3 = MSDBak(i).RevSuccess
              j = MSDBak(i).ReSendNo

              If (B1) Then '������
                If j < (TX_RetryNo - 1) Then '���ǻ�û�������ֲ������һ��
                  k = DateDiff(DateInterval.Second, MSDBak(i).SendDate, Now)
                  If Rev_WaitTime >= k Then
                    '(((((((((((((((((((((((((((((((((
                    Label24.Text = Rev_WaitTime - k
                    ')))))))))))))))))))))))))))))))))
                  Else
                    '[[[[[[[[[[[��ʱ�˾�Ӧ���ٷ�����һ��
                    MSDBak(i).ReSendNo += 1
                    MSDBak(i).SendSuccess = False
                    MSDBak(i).RevED = False
                    MSDBak(i).RevSuccess = False

                    Dim Suc As Boolean = True
                    ModemID = MSDBak(i).ModemID
                    If FSendOne(ModemID, i, MSDBak) = False Then
                      If FSendOne(ModemID, i, MSDBak) = False Then
                        If FSendOne(ModemID, i, MSDBak) = False Then
                          Suc = False
                          'AddText(("��ModemID: " & CStr(ModemID) & " �ϴ��Ļظ���Ϣ����ʧ�ܡ�"))
                        End If
                      End If
                    End If
                    If Suc Then
                      MSDBak(i).SendDate = Now
                      MSDBak(i).SendSuccess = True
                    Else 'ʧ���ˣ�����ͣ��
                      SDBakStops += 1
                      MSDBak(i).StationID = ""
                      MSDBak(i).SendSuccess = True
                      MSDBak(i).RevED = True
                      MSDBak(i).ReSendNo = TX_RetryNo - 1
                    End If
                    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]
                  End If

                ElseIf j >= (TX_RetryNo - 1) Then  '����Ѿ������һ����

                  k = DateDiff(DateInterval.Second, MSDBak(i).SendDate, Now)
                  If Rev_WaitTime >= k Then
                    '(((((((((((((((((((((((((((((((((
                    Label24.Text = Rev_WaitTime - k
                    ')))))))))))))))))))))))))))))))))
                  Else
                    '���һ��Ҳ��ʱ��
                    SDBakStops += 1
                    MSDBak(i).StationID = ""
                    MSDBak(i).RevED = True
                    MSDBak(i).RevSuccess = False
                  End If
                End If

              End If

            Else
              SDBakStops += 1
            End If

          End If
        Catch ex As Exception

        End Try



      Next i

      If SDBakStops < MSDBak.Length Then
        WillEnd = False
      Else
        WillEnd = True
      End If

      If WillEnd = False Then
        CheckRev(MSDBak, True) ''''''''''''''''''''''''''''����
      Else
        '�رռ�ʱ��
        TimerThreadRevMSend.Stop()
        'bMsend = False
        bMsendMAbort = False
        gifMSend.ReadGIF(SGif.GifMsendStop)
        gifMSend.Playing = False
        gifMSend.BringToFront()
        ''''''''''''''''''''''''''''''''''''��ʾ����
        If CW.bMsendRevHaveData Then
          CW.bMsendRevHaveData = False
          If bMsend Then
            'If MessageBox.Show("���յ������ݣ��Ƿ�洢��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            If CW.bForm7SaveDB_Runing = False Then
              Dim F As New Form7SaveDB
              F.Show()
            End If
            'End If
          End If
        End If
        bMsend = False
      End If
    End If

  End Sub
  Private Sub RevAddText(ByVal RvData As ModemDataStruct)
    Dim ModemID, S As String
    Dim RevDate As Date
    AddText(ControlChars.Cr)
    ModemID = StringToLen8(CStr(Hex(CStr(RvData.m_ModemId))))
    RevDate = DateAdd("s", RvData.m_Recv_Time, "1970-1-1 8:00:00")
    S = "ModemID��" + ModemID
    S &= "  " & ("����ʱ�䣺" + RevDate.ToLongTimeString())
    S &= "  " & ("���ݳ��ȣ�" + RvData.m_Data_Len.ToString)
    AddText(S)
    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    Dim Ascii As New System.Text.ASCIIEncoding
    Dim ShowData As String = Mid(Ascii.GetString(RvData.m_Data_Buf), 1, RvData.m_Data_Len)
    Dim sDataBuf As String

    RvData.m_Data_Buf(RvData.m_Data_Len) = 0
    sDataBuf = byteToHexStr(RvData.m_Data_Buf, RvData.m_Data_Len)
    AddText("Get data<<<" + "-------------------------------------------------------------------------------------------------------------------")
    AddText(sDataBuf)
    AddText(("�������ݣ�" + ShowData))
    AddText("------------------------------------------------------------------------------------------------------------------------------")
  End Sub
  Private Sub CheckRevSub()
    'If bMsend Then Exit Sub
    'CheckRevSubRun = True
    CheckRev(tmpSDBak, False)
    'CheckRevSubRun = False
  End Sub

  Private Function CheckRev(ByVal SDBak() As GprsSendDataBackup, ByVal bUseSDBak As Boolean) As Boolean
    'bUseSDBakΪ�Ƿ�Ӧ��SDBak��������,�Ͳ���������
    If CheckRevFunRun Then
      Exit Function
    End If
    CheckRevFunRun = True
    Dim i, j, k, RevNo, RevDegree, SDBakNo, m_Data_Len As Integer
    'Dim S As String
    Dim result As Boolean
    Dim rvData As New ModemDataStruct
    rvData.m_Data_Buf = New Byte(1450) {}
    'Dim RevDate As Date
    Dim ModemID As String
    'Dim RevStationID As String��ȫ�ֱ����ˣ�����RevMapNo��RevStationNOһ��
    Dim MapNo, StationNo As Integer
    Dim RevError As Boolean = False   '���յ�������ȫ���������
    Dim RevSDBakSuc As Boolean = False  '�յ���������SDBak���͵���
    Dim RevDataMode As String '���յ����ݵ���������
    Dim TXDMSame As Boolean = False '��ӦSDBakNo<>-1��˵��������Ļ�Ӧ
    Dim Suc As Boolean
    MapNo = 1 : StationNo = 1
    Dim tByte() As Byte

    CheckRev = False

    result = GprsMod.DSGetNextData(rvData, 0)
    If Not (result) Then
      CheckRevFunRun = False
      Exit Function
    End If

    '((((((((((((((((((((((((((
    m_Data_Len = rvData.m_Data_Len
    If m_Data_Len > 0 Then
      Label21.Text = i
    Else
      'Label21.Text = "***"
    End If
    '))))))))))))))))))))))))))

    If m_Data_Len <= 0 Then '���û�յ�������
      CheckRevFunRun = False
      Exit Function
    End If

    If bUseSDBak Then
      RevNo = SDBak.Length
    End If

    If ChkRevTest.Checked Then
      SetAddTextColor()
      RevAddText(rvData)
    End If

    If rvData.m_Data_Type = 2 Then
      SetAddTextColor()
      AddText("�Կ�������֡�Ļ�Ӧ")
      CheckRevFunRun = False
      Exit Function
    End If

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[������������[[[[[[[[[[[[[[[[[[[[[[[[[[[[

    Dim StartNo, EndNo As Integer
    Dim bHaveStartNo As Boolean = False
    Dim B As Boolean '�Ƿ����ĿǰҪ��ı�־������������ж���仯

    StartNo = -1 : EndNo = -1 '�ҵ�һ����ʼ�����һ����β���
    For i = 0 To rvData.m_Data_Len - 1
      j = rvData.m_Data_Buf(i)
      If bHaveStartNo = False Then
        If j = SD_Start Then
          StartNo = i
          bHaveStartNo = True
        End If
      End If
      If rvData.m_Data_Buf(i) = SD_End Then
        EndNo = i
      End If
    Next i

    SetAddTextColor()
    B = False
    If (StartNo > -1) And ((EndNo - StartNo + 1) >= SendData_BasicLong) Then '�ﵽ���Ҫ��''''''''����
      k = SendData_BasicLong + rvData.m_Data_Buf(StartNo + 18)
      If (EndNo - StartNo + 1) >= k Then '�ʹ������ĳ��ȱ��ķ���
        If rvData.m_Data_Buf(k - 1) = SD_End Then '����β����β���
          B = True
        Else
          AddText(("��������û�б�β��"))
        End If
      Else
        AddText(("�������ݳ��Ȳ�����"))
      End If
    Else
      If StartNo < 0 Then
        AddText(("��������û�б�ͷ��"))
      Else
        AddText(("�������ݳ���̫�̡�"))
      End If
    End If
    If B = False Then
      RevError = True
      GoTo NextStep
    End If

    If JYHByte(rvData.m_Data_Buf, StartNo, k) = False Then '''''''''''''''''''''''''''''''''''У���
      AddText(("У��Ͳ�ƥ�䡣"))
      RevError = True
      GoTo NextStep
    End If

    RevDataMode = Chr(rvData.m_Data_Buf(StartNo + 17)) ''''''''''''''''''''''''''''''''''''''''PARST
    RevStationID = ""
    For i = 1 To 8
      RevStationID += Hex(rvData.m_Data_Buf(8 + i))
    Next i
    RevStationID = StringToLen8(RevStationID) ''''''''''''''''''''''''''''''''''''''�ȼ����վ��ID
    ModemID = StringToLen8(CStr(Hex(CStr(rvData.m_ModemId)))) '''''''''''''''''''''�ټ����ModemID

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    If bUseSDBak Then
      SDBakNo = -1 '�Ƿ��Ƿ�������Ļ�Ӧ���
      For RevDegree = 0 To RevNo
        If SDBak(RevDegree).SendSuccess Then
          If CSng(ModemID) = CSng(SDBak(RevDegree).ModemID) Then 'ת��Ϊ�����ٱȽϣ��ؼ�����ӦP��A�Ȼ��ҿ��ܸ����й�ϵ
            SDBakNo = RevDegree '�ж��Ƿ�������Ļ�Ӧ
            Exit For
          End If
        End If
      Next RevDegree
    End If
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    RevMapNo = -1
    RevStationNo = -1
    Dim Have As Boolean = False
    For i = 1 To CW.MapAmount
      For j = 1 To CW.Maps(i).MapStationPlacedAmount
        If RevStationID = CW.Maps(i).Stations(j).StationID Then '�ټ������Ӧվ��ID�ĵ�ͼ��վ������
          RevMapNo = i
          RevStationNo = j
          Have = True '''''''''''''''''''''''''''''''''''''''''''''''''''''''�Ƿ�������վ�������
          Exit For
        End If
      Next j
      If Have Then Exit For
    Next i

    SetAddTextColor()

    If Have Then ''''''''''''''''''''''''''''''''''''''''''''���������վ��ID�����ж�ModemID
      If CW.Maps(RevMapNo).Stations(RevStationNo).ModemInfo.ID <> ModemID Then
        CW.Maps(RevMapNo).Stations(RevStationNo).ModemInfo.ID = ModemID
        AddText("�����˵�ͼ:" & CW.Maps(RevMapNo).MapName & " " & "վ��:" & CW.Maps(RevMapNo).Stations(RevStationNo).StationName & " ��ModemID-->" & ModemID & "�����豣���뱣�湤�̡�")
      End If
    Else
      'RevStationData = False
      AddText("û��StationID��" & RevStationID & " ��վ�����á�")
      '��Ȼû��վ�㣬����ҲӦ�ظ�������û���ý��մ���
      'Exit Function
    End If

    If (TXDM.CheckA(RevDataMode) Or TXDM.CheckP(RevDataMode)) Then  'У�����ȷ������AP������Ӧ������

      '[[[[[[[[[[[[[[[[�����AҪ���ϻظ�
      Suc = True
      If TXDM.CheckA(RevDataMode) Then
        Dim tSB() As Byte
        ReDim tSB(21)
        BuildSendByte(RevStationID, Host_ID, TXDM.A, "", tSB)
        If FSendOne(ModemID, tSB) = False Then
          If FSendOne(ModemID, tSB) = False Then
            If FSendOne(ModemID, tSB) = False Then
              Suc = False
            End If
          End If
        End If

        If Suc Then
          AddText(("��ModemID: " & CStr(ModemID) & " A�ϴ��Ļظ���Ϣ���ͳɹ���"))
        Else

          AddText(("��ModemID: " & CStr(ModemID) & " A�ϴ��Ļظ���Ϣ����ʧ�ܡ�"))
        End If
      End If
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      If SDBakNo <> -1 Then
        If RevDataMode = SDBak(SDBakNo).DataMode Then
          RevSDBakSuc = True '''''''''''''''''''''''''�յ���������SDBak���͵�
        Else
          RevSDBakSuc = False
        End If
      End If

      If Have Then ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ReDim tByte(k - 1)
        j = 0
        For i = StartNo To StartNo + k - 1
          tByte(j) = rvData.m_Data_Buf(i)
          j += 1
        Next i

        If RevStationData(RevMapNo, RevStationNo, tByte) Then '''''''''''''�ѽ��յ����ݸ���վ��

          AddText("���յ�ModemID: " & CStr(ModemID) & " " & RevDataMode & "�ϴ������ݳɹ���")
          CW.bMsendRevHaveData = True
          With CW.Maps(RevMapNo).Stations(RevStationNo)
            .RevNewData = True
            .HaveData = True
            .DBed = False
            If bMsend Then
              .LookedRevNewData = False
            End If
            .Saved = False
          End With
          'CheckRev = True
          RevError = False

          '�����Ƿ�bUseSDBak��ֻҪ��P(S,R,T 200601140441�ٴ��޸�,P��������,SRT�ź���)��Ҫ���ɹ���ǣ������������ô��һ������200512291939
          If bAsend Then
            If TXDM.CheckP(RevDataMode) Then
              If ASDBak.Length > 0 Then
                For i = 0 To ASDBak.Length - 1
                  If (RevStationID = ASDBak(i).StationID) And (RevDataMode = ASDBak(i).DataMode) Then
                    ASDBak(i).StationID = ""
                    ASDBak(i).SendSuccess = True
                    ASDBak(i).RevED = True
                    ASDBak(i).RevSuccess = True
                  End If
                Next i
              End If
            End If
          End If

          If bMsend Then
            If TXDM.CheckP(RevDataMode) Then
              If MSDBak.Length > 0 Then
                For i = 0 To MSDBak.Length - 1
                  If (RevStationID = MSDBak(i).StationID) And (RevDataMode = MSDBak(i).DataMode) Then
                    MSDBak(i).StationID = ""
                    MSDBak(i).SendSuccess = True
                    MSDBak(i).RevED = True
                    MSDBak(i).RevSuccess = True
                  End If
                Next i
              End If
            End If
          End If

          If TabControl1.SelectedIndex = 1 Then
            If (RevMapNo = CW.MapNo) And (RevStationNo = CW.Maps(CW.MapNo).PerShowStationNo) Then
              SetTabStationInfo(CW.MapNo, CW.Maps(CW.MapNo).PerShowStationNo)
              ShowStationParameter(CW.MapNo, CW.Maps(CW.MapNo).PerShowStationNo)
            End If
          End If

          If bAsend Then
            LstATXSuccess.Items.Add(CW.ATX_StartRunTime_OLD & ":" & CW.Maps(RevMapNo).MapName & ":" & CW.Maps(RevMapNo).Stations(RevStationNo).StationName)
          End If

          If bMsend Then
            LstSuccess.Items.Add("��ͼ:" & CW.Maps(RevMapNo).MapName & " վ��:" & CW.Maps(RevMapNo).Stations(RevStationNo).StationName)
          End If


          '����������������ɹ��յ����ݵ�վ��
          AddText(("���ݴ�����ϣ������ѷ��͵�վ�������"))
        Else
          AddText(("���ݴ������,�����ݷ��͸�վ�������"))
          RevError = True
        End If
      End If

    Else '�����S R T

      AddText(("���յ�ModemID��" & CStr(ModemID) & " " & RevDataMode & "�����������ݡ�"))

      '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[

      '�����Ƿ�bUseSDBak��ֻҪ��P(R,S,(T)200601140441�ٴ��޸�)��Ҫ���ɹ���ǣ������������ô��һ������200512291939
      If bMsend Then
        If MSDBak.Length > 0 Then
          For i = 0 To MSDBak.Length - 1
            If (RevStationID = MSDBak(i).StationID) And (RevDataMode = MSDBak(i).DataMode) Then
              MSDBak(i).StationID = ""
              MSDBak(i).SendSuccess = True
              MSDBak(i).RevED = True
              MSDBak(i).RevSuccess = True
            End If
          Next i
        End If
      End If

      If bAsend Then
        If ASDBak.Length > 0 Then
          For i = 0 To ASDBak.Length - 1
            If (RevStationID = ASDBak(i).StationID) And (RevDataMode = ASDBak(i).DataMode) Then
              ASDBak(i).StationID = ""
              ASDBak(i).SendSuccess = True
              ASDBak(i).RevED = True
              ASDBak(i).RevSuccess = True
            End If
          Next i
        End If
      End If
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

      '[[[[[[[[[[[[[[[[�����T(S��Ҫ�ظ�20060114)Ҫ���ϻظ�,R�Ͳ��ظ��ˣ���Ȼ�ظ���λ��
      '[[[[[[[[[[[[[[[[S�Ͳ��ظ��ˣ����д���20080123
      If (RevDataMode <> TXDM.R) And (RevDataMode <> TXDM.S) Then
        Dim tTSB() As Byte
        'Dim Suc As Boolean
        Suc = True
        ReDim tTSB(21)
        BuildSendByte(RevStationID, Host_ID, RevDataMode, "", tTSB)
        If FSendOne(ModemID, tTSB) = False Then
          If FSendOne(ModemID, tTSB) = False Then
            If FSendOne(ModemID, tTSB) = False Then
              Suc = False
            End If
          End If
        End If
        If Suc Then
          If Have Then
            AddText(("�ظ���ͼ:" & CW.Maps(RevMapNo).MapName & " " & "վ��:" & CW.Maps(RevMapNo).Stations(RevStationNo).StationName & " " & RevDataMode & "�����������ݳɹ���"))
          Else
            AddText(("�ظ�ModemID��" & CStr(ModemID) & " " & RevDataMode & "�����������ݳɹ���"))
          End If
        Else
          If Have Then
            AddText(("�ظ���ͼ:" & CW.Maps(RevMapNo).MapName & " " & "վ��:" & CW.Maps(RevMapNo).Stations(RevStationNo).StationName & " " & RevDataMode & "������������ʧ�ܡ�"))
          Else
            AddText(("�ظ�ModemID��" & CStr(ModemID) & " " & RevDataMode & "������������ʧ�ܡ�"))
          End If
        End If
      End If

      '[[[[[[[[[[[[[[[[S�Ͳ��ظ��ˣ����д���20080123
      If (RevDataMode = TXDM.S) Then
        If SendSSStationID = RevStationID Then
          bSendSSSucess = True
        End If
      End If
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    End If

NextStep:

    If bUseSDBak Then

      If RevSDBakSuc Then

        If RevError Then
          If Have Then
            SDBak(SDBakNo).RevED = True '���յ�������
            SDBak(SDBakNo).RevSuccess = False '����ʧ����
            If SDBak(SDBakNo).ReSendNo < TX_RetryNo - 1 Then
              SDBak(SDBakNo).ReSendNo += 1
              SDBak(SDBakNo).SendSuccess = False
              SDBak(SDBakNo).RevSuccess = False
              SDBak(SDBakNo).RevED = False
              '����һ�η���
              FSendOne(SDBak(SDBakNo).ModemID, SDBakNo, SDBak)
              If SDBak(SDBakNo).SendSuccess = False Then
                FSendOne(SDBak(SDBakNo).ModemID, SDBakNo, SDBak)
              End If
              If SDBak(SDBakNo).SendSuccess = False Then
                FSendOne(SDBak(SDBakNo).ModemID, SDBakNo, SDBak)
              End If
              If SDBak(SDBakNo).SendSuccess = False Then '�����ζ�û�ɹ���˵�������ߣ�ͨѶʧ��
                SDBak(SDBakNo).StationID = ""
                SDBak(SDBakNo).ReSendNo = TX_RetryNo - 1 '�ټ���SendSuccess=True �����˵�����ͨѶʧ��
                SDBak(SDBakNo).SendSuccess = True
                SDBak(SDBakNo).RevED = True
                SDBak(SDBakNo).RevSuccess = False
              End If
            Else '����2,����ʧ����
              'SDBak(SDBakNo).ReSendNo = 2 '�ټ���SendSuccess=True �����˵�����ͨѶʧ��
              SDBak(SDBakNo).StationID = ""
              SDBak(SDBakNo).ReSendNo = TX_RetryNo - 1
              SDBak(SDBakNo).SendSuccess = True
              SDBak(SDBakNo).RevED = True
              SDBak(SDBakNo).RevSuccess = False
            End If

          End If

        Else

          If Have Then
            '((((((((((((((((((((((((((((((((((
            Label24.Text = "stop"
            Application.DoEvents()
            '))))))))))))))))))))))))))))))))))
            SDBak(SDBakNo).StationID = ""
            SDBak(SDBakNo).SendSuccess = True
            SDBak(SDBakNo).RevED = True '���յ�������
            SDBak(SDBakNo).RevSuccess = True  '���ҳɹ���

          End If

        End If

      End If

    End If
    CheckRevFunRun = False
  End Function

  Private Function RevStationData(ByVal aMapNo As Integer, ByVal aStationNo As Integer, ByVal Data() As Byte) As Boolean
    '�����յ������ݽ��������͵�վ�����
    Dim i, j, k, tInt, tSint As Integer
    Dim tDouble As Double = 0
    'Dim tLong As Single
    Dim S As String
    Dim TD As Date
    'Dim StationID As String

    'If ModemID <> "" Then
    '  Try
    '    CW.Maps(MapNo).Stations(StationNo).ModemInfo.ID = CSng(ModemID)
    '  Catch ex As Exception
    '  End Try
    'End If

    'StationID = ""
    'For i = 9 To 16
    '  tInt = Data(i)
    '  StationID = StationID & Hex(tInt)
    'Next i
    'StationID = StringToLen8(StationID)

    'Dim Have As Boolean = False
    'For i = 1 To CW.MapAmount
    '  For j = 1 To CW.Maps(i).MapStationPlacedAmount
    '    If StationID = CW.Maps(i).Stations(j).StationID Then
    '      RevMapNo = i
    '      RevStationNo = j
    '      Have = True
    '      Exit For
    '    End If
    '  Next j
    '  If Have Then Exit For
    'Next i
    'If Have Then
    '  CW.Maps(RevMapNo).Stations(RevStationNo).StationID = StationID
    'Else
    '  'RevStationData = False
    '  AddText("û��StationID��" & StationID & " ��վ�����á�")
    '  'Exit Function
    'End If

    S = ""
    For i = 1 To 8
      tInt = Data(i)
      S = S & CStr(tInt)
    Next i
    CW.CWHostID = S

    k = Data(18) '���ݳ���
    tSint = 19
    Dim ParameterNo As Integer = 0
    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[14��������ֵ����û��
    For i = 1 To StationDataInfo.StationModeInfo(CW.Maps(aMapNo).Stations(aStationNo).StationModeIndex).HowManyParameter '''''''��������
      ParameterNo += 1
      tDouble = 0
      For j = 1 To StationDataInfo.StationModeInfo(CW.Maps(aMapNo).Stations(aStationNo).StationModeIndex).ParameterByteLong 'ÿ��������ת��

        '�ĸ��ֽڣ�''''''''''''''''''''''''''''���ȸߺ��|
        '''''''''''''''''''''''''''''''''''''''''''''''''V
        If tSint <= Data.GetUpperBound(0) - 2 Then '20071023�ɼ����ĳɼ���
          'tDouble += Data(tSint) * (256 ^ (j))
          tDouble += Data(tSint) * (256 ^ (StationDataInfo.StationModeInfo(CW.Maps(aMapNo).Stations(aStationNo).StationModeIndex).ParameterByteLong - j))
        Else
          S = "XXX"
        End If
        tSint += 1
      Next j
      tDouble = tDouble / 10 ^ (StationDataInfo.StationModeInfo(CW.Maps(aMapNo).Stations(aStationNo).StationModeIndex).Order_Dot(ParameterNo))
      S = CStr(tDouble)
      CW.Maps(aMapNo).Stations(aStationNo).StationParameters(StationDataInfo.StationModeInfo(CW.Maps(aMapNo).Stations(aStationNo).StationModeIndex).Order(ParameterNo), 1) = S
    Next i
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    tSint += 16
    S = "20"
    For i = tSint To tSint + 7
      If i > Data.GetUpperBound(0) Then
        Exit For
      Else
        S = S & Chr(CSng(Data(i)))
        tSint += 1
      End If
    Next i
    If IsDate(S) Then
      CW.Maps(RevMapNo).Stations(RevStationNo).TestDate = S
    End If

    'TD = Now
    'S = TD.Date
    'CW.Maps(RevMapNo).Stations(RevStationNo).TestDate = S
    'S = CDate(TD.Hour & ":" & TD.Minute & ":" & TD.Second)
    'CW.Maps(RevMapNo).Stations(RevStationNo).TestTime = S

    tSint += 1
    S = ""
    For i = tSint To tSint + 7
      If i > Data.GetUpperBound(0) Then
        Exit For
      Else
        S = S & Chr(CSng(Data(i)))
      End If
    Next i
    If IsDate(S) Then
      CW.Maps(RevMapNo).Stations(RevStationNo).TestTime = S
    End If

    If bMsend Then
      TD = Now
      S = TD.Date
      CW.Maps(RevMapNo).Stations(RevStationNo).TestDate = S
      S = CDate(TD.Hour & ":" & TD.Minute & ":" & TD.Second)
      CW.Maps(RevMapNo).Stations(RevStationNo).TestTime = S
    End If

    If bAsend Then
      TD = CW.ATX_StartRunTime_OLD
      S = TD.Date
      CW.Maps(RevMapNo).Stations(RevStationNo).TestDate = S
      S = CDate(TD.Hour & ":" & TD.Minute & ":" & TD.Second)
      CW.Maps(RevMapNo).Stations(RevStationNo).TestTime = S
    End If

    RevStationData = True

    'ˢ������,�����滹�Ƿ����棿
    'ShowStationParameter(CW.MapNo, CW.Maps(CW.MapNo).PerShowStationNo)
  End Function
  Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
    With LstSuccess
      If .SelectedIndex >= 0 Then
        .Items.RemoveAt(.SelectedIndex)
      End If
    End With
  End Sub

  Private Sub BtnMSendAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMSendAbort.Click
    If bMsend = False Then Exit Sub
    If MessageBox.Show("���Ҫ�ж�ͨѶ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
      bMsendMAbort = True
    End If
  End Sub

  Private Sub BtnGifMSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    BtnMSendAbort_Click(sender, e)
  End Sub

  Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
    LstSuccess.Items.Clear()
  End Sub

  Private Sub BtnCbinFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCbinFile.Click
    Dim i As Integer
    Dim tBA() As Byte
    'Dim S As String
    Select Case RadBtnSin.Checked
      Case True '�ⷢ
        i = RtxtSendData.TextLength
        ReDim tBA(SendData_BasicLong + i)
        BuildSendByte(NumUDID.Text, Host_ID, DoUDTXDataMode.Text.Trim, RtxtSendData.Text, tBA)
        'Dim fStream As New FileStream(path, fileMode, fileAccess)

      Case False '��ȡ
        i = RtxtSendData.TextLength
        ReDim tBA(SendData_BasicLong + i)
        BuildSendByte(Host_ID, NumUDID.Text, DoUDTXDataMode.Text.Trim, RtxtSendData.Text, tBA)
    End Select


  End Sub

  Private Sub BtnCleartxtInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCleartxtInfo.Click
    'If MessageBox.Show("Ҫ�����Ϣ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    'txtInfo.Clear()
    txtInfo.Text = "         "
    'End If
  End Sub

  Private Sub ComboBoxOnLineStationInfo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxOnLineStationInfo.SelectedIndexChanged
    Dim i As Integer
    Dim S As String

    i = lstInfo.Items.Count
    If i > 0 Then
      S = lstInfo.Items(ComboBoxOnLineStationInfo.SelectedIndex).Text
      NumUDID.Text = S
    End If
  End Sub

  Private Sub CS1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Dim i As Integer
    Dim S As String
    S = sender.tag

    For i = 1 To CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).PerShowStationNo).StationParameterAmount
      If S = "p" & CStr(i) Then
        ListBoxTabStationParameter.SelectedIndex = i - 1
      End If
    Next i

  End Sub

  Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    If CW.Active = False Then Exit Sub

    Select Case TabControl1.SelectedIndex

      Case 1 '''''''''''''''''''''''''''''''''''''�������վ����ͼ
        TabShowStation.Controls.Add(GroupBoxAboutStation)
        GroupBoxAboutStation.Location = New Point(TabControl1.Width - 212, 77)
        GroupBoxAboutStation.Anchor = AnchorStyles.Top + AnchorStyles.Right
        GroupBoxAboutStation.BringToFront()
        'PicboxStation.Image = Image.FromFile(CW.WorkPath & "\maps\Station1.jpg")
        SetMapStationSelectComboBox("s")

        If ComboBoxSelectStation.Items.Count > 0 Then
          ComboBoxSelectStation.SelectedIndex = CW.Maps(CW.MapNo).PerShowStationNo - 1
        End If
        ShowStationParameter(CW.MapNo, CW.Maps(CW.MapNo).PerShowStationNo)

        'Case 3

        '  LstShowAllStation.Columns.Clear()
        '  LstShowAllStation.Columns.Add("վ ID", -2, HorizontalAlignment.Left)
        '  LstShowAllStation.Columns.Add("վ����", -2, HorizontalAlignment.Left)
        '  LstShowAllStation.Columns.Add("���ʱ��", -2, HorizontalAlignment.Left)
        '  For i = 1 To 10
        '    S = CW.Maps(CW.MapNo).Stations(1).StationParameters(i, 0)
        '    LstShowAllStation.Columns.Add(S, -2, HorizontalAlignment.Left)
        '  Next i


    End Select
  End Sub

  Private Sub BtnShowStationSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowStationSend.Click
    If lstInfo.Items.Count > 0 Then
      Dim S As String
      S = CW.Maps(CW.MapNo).Stations(CW.Maps(CW.MapNo).PerShowStationNo).ModemInfo.ID
      If Trim(S) <> "" Then
        RadBtnSin.Checked = True
        S = StringToLen8(S)
        NumUDID.Text = S
        SendMode = TXDM.P
        If DoUDTXDataMode.Items.Count > 0 Then
          DoUDTXDataMode.SelectedIndex = 0
        End If
        BtnSend_Click(sender, e)
      End If
    Else
      MessageBox.Show("û������վ�㣬���ܷ��͡�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub
  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'Dim FrmMPB As New Form2
    'FrmMPB.Show()
    'Dim GprsW As GPRSWork
    'gprsw.ArrayMap(3).ArrayStation(3).
    'PicBoxMap.Size = New Point(100, 100)
    Dim tData(0) As Byte
    tData(0) = 0
    'For i = 1 To 10
    '  tData(i) = i
    'Next i

    FSendOne("74736574", tData)
  End Sub
  Private Sub Btn1Click()
    Dim tData(0) As Byte
    tData(0) = 0
    FSendOne("88888888", tData)
  End Sub

  Private Sub TimerPollUserTable_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPollUserTable.Tick

    If bStop Then
      TimerCheckRev.Stop()
      TimerPollUserTable.Stop()
      Exit Sub
    End If

    If (bMsend = False) And (bAsend = False) Then
      If PollUserTableRun = False Then
        PollUserTable()
      End If
    End If
  End Sub
  Private Sub TimerCheckRev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCheckRev.Tick
    Dim i As Integer
    If ActivePerson.Active = False Then Exit Sub

    If bStop Then
      TimerCheckRev.Stop()
      TimerPollUserTable.Stop()
      Exit Sub
    End If

    If (bMsend = False) And (bAsend = False) Then
      If CheckRevSubRun = False Then
        CheckRevSubRun = True
        CheckRevSub()
        CheckRevSubRun = False

      End If
    Else
      i = i
    End If
  End Sub

  Private Sub TimerThreadRevMSend_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerThreadRevMSend.Tick
    If ThreadRevMSendRun = False Then
      ThreadRevMSendRun = True
      ThreadRevMSend()
      ThreadRevMSendRun = False
    End If
  End Sub

  Private Sub txtInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInfo.Click

  End Sub

  Private Sub txtInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtInfo.MouseUp
    'Dim i As Integer
    'i = CSng(txtInfo.Tag)
    'If i = 1 Then
    '  txtInfo.BackColor = System.Drawing.Color.DarkBlue
    '  txtInfo.Tag = 2
    'ElseIf i = 2 Then
    '  txtInfo.BackColor = System.Drawing.Color.LawnGreen
    '  txtInfo.Tag = 3
    'ElseIf i = 3 Then
    '  txtInfo.BackColor = System.Drawing.Color.Gold
    '  txtInfo.Tag = 4
    'ElseIf i = 4 Then
    '  txtInfo.BackColor = System.Drawing.Color.LightYellow
    '  txtInfo.Tag = 1
    'End If
  End Sub

  Private Sub AxAniGIFRedDotHandel_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxAniGIFRedDotHandel.ClickEvent

  End Sub

  Private Sub AxAniGIFRedDotHandel_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxAniGIFRedDotHandel.DblClick

  End Sub

  Private Sub AxAniGIFRedDotHandel_MouseMoveEvent(ByVal sender As Object, ByVal e As AxAniGIFCtrl.IAniGIFEvents_MouseMoveEvent) Handles AxAniGIFRedDotHandel.MouseMoveEvent

  End Sub

  Private Sub AxAniGIFRedDotHandel_MouseUpEvent(ByVal sender As Object, ByVal e As AxAniGIFCtrl.IAniGIFEvents_MouseUpEvent) Handles AxAniGIFRedDotHandel.MouseUpEvent

  End Sub

  Private Sub AniGifMainForm_Step(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AniGifMainForm.Step

  End Sub

  Private Sub txtInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInfo.TextChanged

  End Sub

  Private Sub DoUDTXDataMode_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoUDTXDataMode.SelectedItemChanged
    SendMode = DoUDTXDataMode.Text.Trim
  End Sub
  Private Sub RecordVer(ByVal MsgString As String)
    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[��¼����ʱ��
    Dim PINI As New GprsRWini
    Dim SPath, S As String
    Dim Count As Integer
    SPath = GetAppPath() & "\" & BulidDate_Txt
    With PINI '

      .FileName = SPath '
      .AppName = "Count"
      .KeyName = "Count"
      S = Trim(.ReadINI(RWini_BZString))
      S = Trim(S)
      '.ValueStr = Date.Now
      If S <> "" Then
        If IsNumeric(S) Then
          S = S
        Else
          S = "0"
        End If
      Else
        S = "0"
      End If

      Count = CSng(S)
      Count += 1


      .FileName = SPath '
      .AppName = "Count"
      .KeyName = "Count"
      .ValueStr = CStr(Count)
      Try
        If Trim(.ValueStr) <> "" Then
          .WriteINI(RWini_BZString)
          'MessageBox.Show("OK!")
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

      .FileName = SPath '
      .AppName = "BulidDate"
      .KeyName = "BulidDate" & "-" & CStr(Count)
      .ValueStr = MsgString
      Try
        If Trim(.ValueStr) <> "" Then
          .WriteINI(RWini_BZString)
          MessageBox.Show("OK!")
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

    End With ''''''''''''''''''''''''''''''''''''
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
  End Sub
  Private Sub LblRecordVer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblRecordVer.DoubleClick
    Dim S As String
    S = InputBox("�������¼���Ϣ���֣�", "�¼���¼", "û���쳣��", , )
    S = "��" & S
    RecordVer(Date.Now & S)
  End Sub

  Private Sub MenuItemOpenWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOpenWork.Click

    If ActivePerson.Active = False Then Exit Sub

    If CW.Active Then
      MessageBox.Show("�����Ѿ��򿪡�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    MeOrignWindowState = Me.WindowState
    Me.WindowState = FormWindowState.Normal
    MeOrignLocation = Me.Location
    Me.Visible = False
    Me.Location = New Point(-Me.Size.Width, -Me.Size.Height)
    Me.Visible = True

    TabControl1.SelectedIndex = 0

    OpenFileDialogWork.DefaultExt = Default_GprsWork_INIFilesName
    OpenFileDialogWork.Multiselect = False
    OpenFileDialogWork.Filter = "HZY-GPRSϵͳ�����ļ� (*." & Default_GprsWork_INIFilesName & ")|*." & Default_GprsWork_INIFilesName
    OpenFileDialogWork.InitialDirectory = GetAppPath()
    OpenFileDialogWork.ShowDialog()
    If OpenFileDialogWork.FileName <> "" Then
      If RWGprsWorkINI(OpenFileDialogWork.FileName, True) Then
        '��ȡվ������λ�����Ƶ�
        Dim i, j As Integer
        Dim S As String
        S = RorWCWMapInfoMDB(True) '����ͼ��Ϣ
        If S = "" Then

          j = CW.MapAmount
          For i = 1 To j
            If CW.Maps(i).MapStationAmount > 0 Then
              If CW.Maps(i).MapStationPlacedAmount > 0 Then
                S = Trim(RorWMapStationInfoMDB(i, True))
                If S <> "" Then
                  If i < j Then
                    If MessageBox.Show("��ȡ��ͼ" & CStr(i) & "���ִ���[" & S & "]���Ƿ������ȡ������ͼ��Ϣ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit For
                  End If
                End If
              End If
            End If
          Next i
          If S = "" Then
            SetWorkAll()
            'MessageBox.Show("��ȡ��ϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        Else
          MessageBox.Show(S & " ��ȡ���̽��жϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
      End If
    End If

    Me.Location = MeOrignLocation
    Me.WindowState = MeOrignWindowState

  End Sub


  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ListBoxAtxTimePoint_Del.Click

  End Sub

  Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

  End Sub

  Private Sub RadioBtn_ATX_Time1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtn_ATX_Time1.CheckedChanged
    If SetWorkAll_Run Then Exit Sub
    If RadioBtn_ATX_Time1.Checked Then
      CW.RadioBtn_ATX_TimeN = 1
      RWIni(False, CW.GPRSWorkFilePath, "ATX", "RadioBtn_ATX_TimeN", "1")
    End If
  End Sub

  Private Sub RadioBtn_ATX_Time2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtn_ATX_Time2.CheckedChanged
    If SetWorkAll_Run Then Exit Sub
    If RadioBtn_ATX_Time2.Checked Then
      CW.RadioBtn_ATX_TimeN = 2
      RWIni(False, CW.GPRSWorkFilePath, "ATX", "RadioBtn_ATX_TimeN", "2")
    End If
  End Sub

  Private Sub RadioBtn_ATX_Time3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtn_ATX_Time3.CheckedChanged
    If SetWorkAll_Run Then Exit Sub
    Dim j As Integer
    If RadioBtn_ATX_Time3.Checked Then
      CW.RadioBtn_ATX_TimeN = 3
      RWIni(False, CW.GPRSWorkFilePath, "ATX", "RadioBtn_ATX_TimeN", "3")
      j = NumericUpDown_ATX_Hours.Value
      If j < 0 Then
        NumericUpDown_ATX_Hours.Value = 1
        j = 1
      End If
      If j > 6 Then
        NumericUpDown_ATX_Hours.Value = 6
        j = 6
      End If
      j *= 60
      CW.RadioBtn_ATX_Time3 = j
      RWIni(False, CW.GPRSWorkFilePath, "ATX", "RadioBtn_ATX_Time3", j.ToString)
    End If
  End Sub

  Private Sub NumericUpDown_ATX_Hours_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_ATX_Hours.ValueChanged
    If SetWorkAll_Run Then Exit Sub
    Dim j As Integer
    j = NumericUpDown_ATX_Hours.Value
    If j < 0 Then
      NumericUpDown_ATX_Hours.Value = 1
      j = 1
    End If
    If j > 6 Then
      NumericUpDown_ATX_Hours.Value = 6
      j = 6
    End If
    j *= 60
    CW.RadioBtn_ATX_Time3 = j
    RWIni(False, CW.GPRSWorkFilePath, "ATX", "RadioBtn_ATX_Time3", j.ToString)
  End Sub

  Private Sub PicBoxMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBoxMap.Click

  End Sub

  Private Function ATX_StartRunTime_Next() As Boolean
    Dim FDate As Date
    Dim NowDate As Date = Now.Date
    Dim NowTime As Date = TimeOfDay()

    Dim i, j As Integer
    Dim S As String = ""

    ATX_StartRunTime_Next = False

    Select Case CW.RadioBtn_ATX_TimeN
      Case 1
        i = NowTime.Minute
        j = NowTime.Hour
        i = CInt(i \ 10) * 10 '/����������������

        S = NowDate.ToString
        FDate = CDate(S)
        FDate = DateAdd(DateInterval.Hour, j, FDate)
        FDate = DateAdd(DateInterval.Minute, i, FDate)
        FDate = DateAdd(DateInterval.Minute, CW.RadioBtn_ATX_Time1, FDate)

        CW.ATX_StartRunTime_Next = FDate

        Lbl_ATX_StartRunTime_Next.Text = "�´ο�ʼʱ�䣺" & Format(FDate, "HH:mm:ss")
        Application.DoEvents()
        ATX_StartRunTime_Next = True

      Case 2

        i = NowTime.Minute
        j = NowTime.Hour
        i = CInt(i \ 10) * 10

        S = NowDate.ToString
        FDate = CDate(S)
        FDate = DateAdd(DateInterval.Hour, j, FDate)

        If i < 30 Then
          FDate = DateAdd(DateInterval.Minute, CW.RadioBtn_ATX_Time2, FDate)
        Else
          FDate = DateAdd(DateInterval.Hour, 1, FDate)
        End If

        CW.ATX_StartRunTime_Next = FDate

        Lbl_ATX_StartRunTime_Next.Text = "�´ο�ʼʱ�䣺" & Format(FDate, "HH:mm:ss")
        Application.DoEvents()
        ATX_StartRunTime_Next = True

      Case 3

        i = NowTime.Minute
        j = NowTime.Hour
        i = CInt(i \ 10) * 10

        S = NowDate.ToString
        FDate = CDate(S)
        FDate = DateAdd(DateInterval.Hour, j, FDate)
        If CW.ATX_Runing Then ''''''''''''''
          FDate = DateAdd(DateInterval.Minute, CW.RadioBtn_ATX_Time3, FDate)
        Else
          FDate = DateAdd(DateInterval.Hour, 1, FDate)
        End If

        CW.ATX_StartRunTime_Next = FDate

        Lbl_ATX_StartRunTime_Next.Text = "�´ο�ʼʱ�䣺" & Format(FDate, "HH:mm:ss")
        Application.DoEvents()
        ATX_StartRunTime_Next = True
    End Select

  End Function

  Private Sub BtnSend_Auto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_StartStop_ATX.Click

    If bMsend Then
      MessageBox.Show("���������ֶ���ѯ����ȴ��������������Զ���ѯ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    If CW.ATX_Runing = True Then
      If MessageBox.Show("���������Զ���ѯ���Ƿ����Ҫֹͣ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
        Exit Sub
      End If
      CW.ATX_MAbort = True '''''''�������һ��վһ��վ�Ľ����ǣ���ô�����ͣ��
      TimerATX.Stop() '''''''''''������ڵȴ���ʼʱ�䣬��ʱ��ͣ�ˣ�OK��
      CW.ATX_Runing = False
      ATX_Controls_ChangeState(False)
      LstATXSuccess.Items.Clear()
      Exit Sub
    End If

    If bAsend Then
      MessageBox.Show("���������Զ���ѯͨѶ����������ԡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    ''''''''''''''''''�Ƿ�������վ�㷢�͵�ʱ�����ж�

    ''''''''''''''1.���㿪ʼʱ��
    'CW.ATX_StartRunTime_First_RunED = False
    ATX_StartRunTime_Next()
    CW.ATX_StartRunTime_OLD = CW.ATX_StartRunTime_Next '''''Ϊ�洢ʱ��׼��

    '''''''''''''''''2.������ʱ��
    TimerATX.Start()

    '''''''''''''''3.��ť�����ÿؼ��ı�״̬
    'bAsend = True
    CW.ATX_Runing = True
    CW.ATX_MAbort = False
    ATX_Controls_ChangeState(True)

  End Sub

  Private Sub ATX_Controls_ChangeState(ByVal TF As Boolean)

    RadioBtn_ATX_Time1.Enabled = Not TF
    RadioBtn_ATX_Time2.Enabled = Not TF
    RadioBtn_ATX_Time3.Enabled = Not TF

    NumericUpDown_ATX_Hours.Enabled = Not TF

    Select Case TF
      Case True
        Btn_StartStop_ATX.Text = "����"
        Btn_StartStop_ATX.Image = My.Resources._48ATX_Stop
      Case False
        Btn_StartStop_ATX.Text = "��ʼ"
        Btn_StartStop_ATX.Image = My.Resources._48ATX
        Lbl_ATX_StartRunTime_Next.Text = "�´ο�ʼʱ�䣺"
        Lbl_ATX_Now.Text = "    ��ǰʱ�䣺"
    End Select

    AxAniGIFAsend.Visible = TF

  End Sub

  Private Sub SendATX()
    Dim tByte() As Byte
    Dim S As String
    Dim i, j, DataLen As Integer
    'Dim tB As Byte
    Dim StationID, ModemID As String
    Dim bSuc As Boolean


    If lstInfo.Items.Count < 1 Then
      'MessageBox.Show("û������վ�㣬���ܷ��͡�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      'CW.ATX_StartRunTime_First_RunED = True
      SetAddTextColor()
      AddText(CW.ATX_StartRunTime_OLD & " ʱ����Զ���ѯͨѶû������վ�㡣")
      'ATX_StartRunTime_Next()
      Exit Sub
    End If

    bAsend = True

    ''''''''''''''''''�����ÿ��վ��������ݺʹ洢��־λ��ΪͨѶ��洢��׼��
    For i = 1 To CW.MapAmount
      For j = 1 To CW.Maps(i).MapStationPlacedAmount
        CW.Maps(i).Stations(j).HaveData = False
        CW.Maps(i).Stations(j).Saved = False
        'CW.Maps(i).Stations(j).RevNewData = False
      Next j
    Next i

    ''''''''''''''''''''''''''���������ռ�ʱ��
    TimerATXRev.Start()
    'bAsend = True
    CW.bAsendED = True 'һ��ʼ����True��Ϊ�˷�ֹ��û��������Ѿ��л�Ӧ��������
    CW.ATX_MAbort = False
    GifASend.ReadGIF(SGif.GifMSendStart)
    GifASend.Playing = True
    GifASend.BringToFront()

    ''''''''''''''''''''''''''''''''''''''''''''''''''''����÷���
    ReDim ASDBak(lstInfo.Items.Count - 1)

    For i = 0 To lstInfo.Items.Count - 1 ''20071028,���ܾͽ�ֶ��ͨѶ�󲻶��ڡ�δ�������������õ������ʵ�������������ȶ�ʵ����
      ASDBak(i) = Nothing
      ASDBak(i) = New GprsSendDataBackup
      ASDBak(i).ModemID = ""
      'ASDBak(i).StationID = ""
      'ASDBak(i).DataMode = TXDM.P
      'ASDBak(i).DataString = ""
      'ASDBak(i).ReSendNo = 0
      'ASDBak(i).RevED = False
      'ASDBak(i).RevSuccess = False
      'ASDBak(i).SendSuccess = False
    Next i

    For i = 0 To lstInfo.Items.Count - 1
      'ASDBak(i) = Nothing
      S = lstInfo.Items(i).Text
      'NumUDID.Text = S
      ModemID = StringToLen8(S)
      StationID = ModemIDtoStationID(ModemID)
      'ASDBak(i) = New GprsSendDataBackup
      If StationID <> "" Then
        ASDBak(i).ModemID = ModemID
        ASDBak(i).StationID = StationID
        ASDBak(i).DataMode = TXDM.P
        ASDBak(i).DataString = ""
        ASDBak(i).ReSendNo = 0
        ASDBak(i).RevED = False
        ASDBak(i).RevSuccess = False
        ASDBak(i).SendSuccess = False
        'If DataLen < 1 The
        '  MSDBak(i).DataString = "1"
        '  DataLen = 1
        'End If
        ReDim tByte(SendData_BasicLong + DataLen - 1)

        BuildSendByte(StationID, Host_ID, ASDBak(i).DataMode, ASDBak(i).DataString, tByte)
        ASDBak(i).SendByteArray = tByte

        bSuc = True
        If FSendOne(ModemID, i, ASDBak) = False Then  '��������ʧ����ͨѶʧ��
          If FSendOne(ModemID, i, ASDBak) = False Then
            If FSendOne(ModemID, i, ASDBak) = False Then
              bSuc = False
            End If
          End If
        End If
        If bSuc Then
          ASDBak(i).SendSuccess = True
          ASDBak(i).ReSendNo = 0
          ASDBak(i).RevED = False
          ASDBak(i).RevSuccess = False
          AddText("����ModemID��" & ModemID & " " & ASDBak(i).DataMode & "����ɹ���")
        Else
          ASDBak(i).StationID = ""
          ASDBak(i).SendSuccess = True
          ASDBak(i).ReSendNo = TX_RetryNo - 1
          ASDBak(i).RevED = True
          ASDBak(i).RevSuccess = False
          AddText("����ModemID��" & ModemID & " " & ASDBak(i).DataMode & "����ʧ�ܡ�")
        End If
      Else
        ASDBak(i).StationID = ""
        ASDBak(i).SendSuccess = True
        ASDBak(i).ReSendNo = TX_RetryNo - 1
        ASDBak(i).RevED = True
        ASDBak(i).RevSuccess = False
        AddText("ModemID:" & ModemID & " û������վID������δ���͡�")
      End If
    Next i

  End Sub

  Private Sub ThreadRevASend()
    '���ռ�ʱ��TimerThreadRevMSend_Tick�����Ĺ���
    Dim i, j, k As Integer
    Dim WillEnd As Boolean
    Dim bSuc As Boolean = False
    Dim ModemID As String
    Dim SDBakStops As Integer

    'While True'''''''''''''''ѭ���ô�����ʱ��ȡ��200512280111
    '�ֶ���ֹ����
    If CW.ATX_MAbort Then
      '�رռ�ʱ��

      TimerATXRev.Stop()
      bAsend = False
      CW.ATX_MAbort = False
      GifASend.ReadGIF(SGif.GifMsendStop)
      GifASend.BringToFront()
      Exit Sub
    End If

    If CW.bAsendED Then '��������û��

      WillEnd = True '�����óɼ���ѭ�������ж�

      SDBakStops = 0 ''''�м���վ�����ͣ��
      For i = 0 To ASDBak.Length - 1 '''''''''''''''''''''Ȼ�󰤸��жϸ�վ��Ľ������

        Try
          If ASDBak(i).ModemID <> "" Then '''''˵���Ƿ�������20071029
            Dim B1, B2, B3 As Boolean

            If ASDBak(i).StationID <> "" Then ''''''''''''''

              B1 = ASDBak(i).SendSuccess
              B2 = ASDBak(i).RevED
              B3 = ASDBak(i).RevSuccess
              j = ASDBak(i).ReSendNo

              If (B1) Then '������
                If j < (TX_RetryNo - 1) Then '���ǻ�û�������ֲ������һ��
                  k = DateDiff(DateInterval.Second, ASDBak(i).SendDate, Now)
                  If Rev_WaitTime >= k Then
                    '(((((((((((((((((((((((((((((((((
                    Label24.Text = Rev_WaitTime - k
                    ')))))))))))))))))))))))))))))))))
                  Else
                    '[[[[[[[[[[[��ʱ�˾�Ӧ���ٷ�����һ��
                    ASDBak(i).ReSendNo += 1
                    ASDBak(i).SendSuccess = False
                    ASDBak(i).RevED = False
                    ASDBak(i).RevSuccess = False

                    Dim Suc As Boolean = True
                    ModemID = ASDBak(i).ModemID
                    If FSendOne(ModemID, i, ASDBak) = False Then
                      If FSendOne(ModemID, i, ASDBak) = False Then
                        If FSendOne(ModemID, i, ASDBak) = False Then
                          Suc = False
                          'AddText(("��ModemID: " & CStr(ModemID) & " �ϴ��Ļظ���Ϣ����ʧ�ܡ�"))
                        End If
                      End If
                    End If
                    If Suc Then
                      ASDBak(i).SendDate = Now
                      ASDBak(i).SendSuccess = True
                    Else 'ʧ���ˣ�����ͣ��
                      SDBakStops += 1
                      ASDBak(i).StationID = ""
                      ASDBak(i).SendSuccess = True
                      ASDBak(i).RevED = True
                      ASDBak(i).ReSendNo = TX_RetryNo - 1
                    End If
                    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]
                  End If

                ElseIf j >= (TX_RetryNo - 1) Then  '����Ѿ������һ����

                  k = DateDiff(DateInterval.Second, ASDBak(i).SendDate, Now)
                  If Rev_WaitTime >= k Then
                    '(((((((((((((((((((((((((((((((((
                    Label24.Text = Rev_WaitTime - k
                    ')))))))))))))))))))))))))))))))))
                  Else
                    '���һ��Ҳ��ʱ��
                    SDBakStops += 1
                    ASDBak(i).StationID = ""
                    ASDBak(i).RevED = True
                    ASDBak(i).RevSuccess = False
                  End If
                End If

              End If

            Else
              SDBakStops += 1
            End If

          End If
        Catch ex As Exception

        End Try



      Next i

      If SDBakStops < ASDBak.Length Then
        WillEnd = False
      Else
        WillEnd = True
      End If

      If WillEnd = False Then
        CheckRev(ASDBak, True) ''''''''''''''''''''''''''''����
      Else
        '�رռ�ʱ��
        TimerATXRev.Stop()

        'CW.ATX_StartRunTime_First_RunED = True
        'ATX_StartRunTime_Next()

        bAsend = False
        CW.ATX_MAbort = False
        GifASend.ReadGIF(SGif.GifMsendStop)
        GifASend.Playing = False
        GifASend.BringToFront()
        ''''''''''''''''''''''''''''''������յ�������
        SaveDB()
      End If
    End If
  End Sub
  Private Overloads Function SaveDB() As Boolean
    'ȫ�´洢
    Dim i, MapNo, StationIndex As Integer
    Dim Ado As New GPRSADO
    Dim Rst As New ADODB.Recordset
    Dim FS, S, S1 As String
    Dim bSaved As Boolean = False

    Dim DBRstAmount As Integer '���������ж�������¼
    Dim TimeArry() As Date '��¼��Ŀ��Ӧ�Ĵ洢ʱ�䣬��1��ʼ

    Dim MyDate As Date = CW.ATX_StartRunTime_OLD

    Try
      Ado.ConnAccess(CW.WorkPath & "\" & DataInfo_MDB_File & ".mdb")
      'strSQL = "StationID=0 AND SaveDate=" & CStr(MyDate)
      Rst = Ado.OpenTable(DataInfo_MDB_Table)

      '[[[[[[[[[[[[[[[[[[[[[��ȡ���ݿ��Ѵ���Ϣ
      FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate.Date) & " AND " & "SaveID= 0"

      With Rst

        .Filter = FS

        If .RecordCount < 1 Then
          DBRstAmount = 0
          'ListBoxSave.Items.Add("���ջ�û�д洢���ݡ�")
          '.Close()
          'Rst = Nothing
          'Ado.Close()
          'Ado = Nothing

          'Exit Function

        Else
          If Not (IsDBNull(.Fields("SaveAllID").Value)) Then
            DBRstAmount = CSng(.Fields("SaveAllID").Value)
          End If

          ReDim TimeArry(DBRstAmount)
          For i = 1 To DBRstAmount
            .Filter = ""
            FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveDate= " & CStr(MyDate.Date) & " AND SaveID= " & CStr(i)
            Try
              .Filter = FS
              If Not (IsDBNull(.Fields("SaveTime").Value)) Then
                TimeArry(i) = .Fields("SaveTime").Value
              End If

              'ListBoxSave.Items.Add("��" & CStr(i) & "���洢��ʱ�䣺" & CStr(TimeArry(i)))
            Catch ex As Exception
              'MessageBox.Show("��ȡ���ݿ�ʱ��������" & ex.Message.ToString)
              .Close()
              Rst = Nothing
              Ado.Close()
              Ado = Nothing
              'Me.Close()
            End Try
          Next i
        End If


        ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

        'With Rst

        For MapNo = 1 To CW.MapAmount ''''''''''''''''''''''''''''''�ô��վ��������
          For StationIndex = 1 To CW.Maps(MapNo).MapStationPlacedAmount
            .Filter = ""
            S = CW.Maps(MapNo).Stations(StationIndex).StationID

            FS = "StationID= " & "'" & S & "'" & " And SaveDate= " & CStr(MyDate.Date) & " AND " & "SaveID= " & CStr(DBRstAmount + 1)

            '+++++++++++++++++++++++++++++++200508072002��Ӵ��ж�+++++++++++++++
            If CW.Maps(MapNo).Stations(StationIndex).HaveData Then

              .Filter = FS '''''''''''''��ʵ������û�б�ʱ��Ĵ洢�����Ǳ����

              If .RecordCount < 1 Then
                .AddNew()
              End If

              .Fields("StationID").Value = S
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[[[[[[[[[[[[[[
              .Fields("HaveData").Value = CW.Maps(MapNo).Stations(StationIndex).HaveData
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              .Fields("SaveID").Value = CSng(DBRstAmount + 1)
              .Fields("SaveDate").Value = MyDate.Date
              .Fields("SaveTime").Value = CDate(MyDate.TimeOfDay.ToString)

              .Fields("StationName").Value = CW.Maps(MapNo).Stations(StationIndex).StationName

              S = CW.Maps(MapNo).Stations(StationIndex).TestDate
              If S = "" Then
                .Fields("TestDate").Value = CDate(NoDate_DB)
              Else
                .Fields("TestDate").Value = CDate(S)
                .Fields("TestTime").Value = CW.Maps(MapNo).Stations(StationIndex).TestTime
              End If

              .Fields("StationIp").Value = CW.Maps(MapNo).Stations(StationIndex).ModemInfo.IP
              For i = 1 To CW.Maps(MapNo).Stations(StationIndex).StationParameterAmount
                .Fields("ParameterData" & CStr(i)).Value = CW.Maps(MapNo).Stations(StationIndex).StationParameters(i, 1)
              Next i
              '[[[[[[[[[[[[[[[[[[[[[[[[[[[[200508072002���[[[[[[[[[[[[[[
              CW.Maps(MapNo).Stations(StationIndex).Saved = True
              CW.Maps(MapNo).Stations(StationIndex).DBed = True
              CW.Maps(MapNo).Stations(StationIndex).RevNewData = False
              ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
              bSaved = True
            End If
          Next StationIndex
        Next MapNo

        '+++++++++++++++++++++++++++++++200508072002��Ӵ��ж�+++++++++++++++
        If bSaved Then
          '''''''''''''''���¼�¼�ж�������
          FS = "StationID= " & "'" & "00000000" & "'" & " And SaveDate= " & CStr(MyDate.Date) & " AND " & "SaveID= 0"
          .Filter = ""
          .Filter = FS

          If .RecordCount < 1 Then
            .AddNew()
            .Fields("StationID").Value = "00000000"
            .Fields("SaveID").Value = 0
            .Fields("SaveDate").Value = MyDate.Date
          End If
          Try
            .Fields("SaveAllID").Value = CSng(DBRstAmount + 1)
          Catch ex As Exception
          End Try

          '[[[[[[[[[���ܲ�����Ҫ��20070207��������Ҫ����վ�Ϳ�����Ҫ��[[[[[[
          .Filter = ""
          .AddNew() ''''''''''''''''''''''''''''''''''��¼�¼ӵ�������Ϣ
          .Fields("StationID").Value = "00000000"
          .Fields("SaveID").Value = CSng(DBRstAmount + 1)
          .Fields("SaveDate").Value = MyDate.Date
          .Fields("SaveTime").Value = CDate(MyDate.TimeOfDay.ToString)
          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]


          '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
          '����洢������������ݵı�־
          .Filter = ""
          S = CStr(DatePart(DateInterval.Year, MyDate))
          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & S & "'" & " AND " & "SaveMonth= " & "'" & "" & "'"
          Try
            .Filter = FS
            If .RecordCount < 1 Then
              .AddNew()
            End If
            .Fields("StationID").Value = "00000000"
            .Fields("SAveAllID").Value = 0
            .Fields("SaveID").Value = 0
            .Fields("SaveYear").Value = S
            .Fields("SaveMonth").Value = ""
          Catch ex As Exception
            'MessageBox.Show("��������������ʱ��������" & ex.Message.ToString)
          End Try

          .Filter = ""
          S1 = CStr(DatePart(DateInterval.Month, MyDate))
          FS = "StationID= " & "'" & "00000000" & "'" & " AND SaveAllID= 0 AND SaveID= 0 AND SaveYear= " & "'" & S & "'" & " AND " & "SaveMonth= " & "'" & S1 & "'"
          Try
            .Filter = FS
            If .RecordCount < 1 Then
              .AddNew()
            End If
            .Fields("StationID").Value = "00000000"
            .Fields("SAveAllID").Value = 0
            .Fields("SaveID").Value = 0
            .Fields("SaveYear").Value = S
            .Fields("SaveMonth").Value = S1
          Catch ex As Exception
            'MessageBox.Show("��������������ʱ��������" & ex.Message.ToString)
          End Try

          ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
          .UpdateBatch()

        Else
          'MessageBox.Show("�����ݿɴ档", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '.Close()
      End With
    Catch ex As Exception
      'MessageBox.Show("��������ʱ��������" & ex.Message.ToString)
    End Try
    'Rst.Close()
    Rst = Nothing
    'Ado.Close()
    Ado = Nothing
    If bSaved Then
      SetAddTextColor()
      AddText("��ѯ���ݴ洢��ϣ�" & CW.ATX_StartRunTime_OLD & ":" & CW.Maps(RevMapNo).MapName & ":" & CW.Maps(RevMapNo).Stations(RevStationNo).StationName)
      'MessageBox.Show("���ݱ�����ϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
    'Me.Close()
  End Function
  Private Sub TimerATX_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerATX.Tick
    Lbl_ATX_Now.Text = "    ��ǰʱ�䣺" & Format(Now, "HH:mm:ss")
    Application.DoEvents()
    If bAsend Then Exit Sub
    If bMsend Then Exit Sub
    If TimerATX_Tick_Runing Then Exit Sub
    TimerATX_Tick_Runing = True
    If Now > CW.ATX_StartRunTime_Next Then
      CW.ATX_StartRunTime_OLD = CW.ATX_StartRunTime_Next
      ATX_StartRunTime_Next()
      SendATX()
    End If
    TimerATX_Tick_Runing = False
  End Sub

  Private Sub TimerATXRev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerATXRev.Tick
    If ThreadRevASendRun = False Then
      ThreadRevASendRun = True
      ThreadRevASend()
      ThreadRevASendRun = False
    End If
  End Sub

  Private Sub Btn_Clear_LstATXSuccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clear_LstATXSuccess.Click
    LstATXSuccess.Items.Clear()
  End Sub

  Private Sub MenuItemFlexTChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFlexTChart.Click
    If CW.Active = False Then Exit Sub
    If ActivePerson.Active = False Then Exit Sub
    If CW.bForm10FlexTChart_runing = False Then
      Dim frm10 As New Form10FlexTChart
      frm10.Show()
    End If

  End Sub

  Private Sub BtnTmpSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTmpSave.Click
    SaveDB()
  End Sub


  Private Sub TextBoxSendMessage1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSendMessage1.TextChanged, TextBoxSendMessage2.TextChanged, TextBoxSendMessage3.TextChanged, TextBoxSendMessage4.TextChanged, TextBoxSendMessage5.TextChanged, TextBoxSendMessage6.TextChanged, TextBoxSendMessage7.TextChanged, TextBoxSendMessage8.TextChanged, TextBoxSendMessage9.TextChanged, TextBoxSendMessage10.TextChanged
    Dim MapNo, SNo, i As Integer
    Dim S As String

    MapNo = CW.MapNo
    SNo = ComboBoxSelectStation.SelectedIndex + 1
    S = sender.tag


    For i = 1 To STATION_PROPERTY_MAX_NO
      If S = "SMValue" & CStr(i) Then

        Try
          RWIni(False, CW.GPRSWorkFilePath, "SendMessageMap" & CStr(MapNo), "S" & CStr(SNo) & "SM" & CStr(i), sender.text)
          CW.Maps(MapNo).Stations(SNo).SendMessageValue(i) = sender.text
        Catch ex As Exception

        End Try

        Exit For
      End If
    Next i

  End Sub

  Private Sub btnSendMessageSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMessageSend.Click
    Dim MapNo, StationNo As Integer
    MapNo = CW.MapNo
    StationNo = ComboBoxSelectStation.SelectedIndex + 1
    Dim tDate As Date = Now
    Dim tByte() As Byte
    Dim i, j, k, DataLen As Integer
    'Dim tB As Byte
    Dim StationID, ModemID As String
    Dim bSuc As Boolean
    Dim tmpSingle As Single

    If CW.ATX_Runing Then
      If MessageBox.Show("���������Զ���ѯ���������ݿ���Ӱ�쵽�Զ���ѯ��ͨѶ���Ƿ������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
        Exit Sub
      End If
    End If

    If bAsend Then
      MessageBox.Show("���ڽ����Զ���ѯ��ͨѶ�����Ժ����ԡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    If bStop Then
      MessageBox.Show("��û�����ߡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    If bMsend Then
      MessageBox.Show("����ͨѶ�����Ժ����ԡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    'If RadBtnSin.Checked Then
    '  If NumUDID.Text = "" Or NumUDID.Text < 1 Then
    '    MessageBox.Show("���ڷ���ǰ��ȷѡ������վ�㡣", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Exit Sub
    '  End If
    'End If

    'If RadBtnAll.Checked Then
    '  If lstInfo.Items.Count < 1 Then
    '    MessageBox.Show("û������վ�㣬���ܷ��͡�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Exit Sub
    '  End If
    'End If

    ''''''''''''''''''''''''''���������ռ�ʱ��
    'CW.bMsendRevHaveData = False
    'TimerThreadRevMSend.Start()
    bMsend = True '���ֶ�������ѯ��ͬһ����־��
    'bMsendED = True 'һ��ʼ����True��Ϊ�˷�ֹ��û��������Ѿ��л�Ӧ��������
    'bMsendMAbort = False
    'gifMSend.ReadGIF(SGif.GifMSendStart)
    'gifMSend.Playing = True
    'gifMSend.BringToFront()

    ''''''''''''''''''''''''''''''''''''''''''''''''''''����÷�����

    '[[[[[[[[[[[[[[[[[[[[[20080106�жϷ��������Ƿ񶼺Ϸ�
    Dim SendMessageHowMany As Integer = StationDataInfo.StationModeInfo(CW.Maps(MapNo).Stations(StationNo).StationModeIndex).SendMessageHowMany

    If Not (IsDate(CW.Maps(MapNo).Stations(StationNo).SendMessageValue(1))) Then
      bMsend = False
      MessageBox.Show("����ȷ����ʱ�䡣", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    Else
      tDate = CDate(CW.Maps(MapNo).Stations(StationNo).SendMessageValue(1))
    End If

    For i = 2 To SendMessageHowMany '20080303����Ϊ2�Է���ʱ��
      Try
        If Not (IsNumeric(CW.Maps(MapNo).Stations(StationNo).SendMessageValue(i))) Then
          bMsend = False
          MessageBox.Show("����ȷ����Ҫ���͵���ֵ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Exit Sub
        Else
          tmpSingle = CSng(CW.Maps(MapNo).Stations(StationNo).SendMessageValue(i))
          If tmpSingle < -99.99 Or tmpSingle > 999.99 Then
            bMsend = False
            MessageBox.Show("����ȷ����Ҫ���͵���ֵ,��ֵ������ -99.99 �� 999.99 ֮�䡣", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
          End If
        End If
      Catch ex As Exception
        bMsend = False
        MessageBox.Show("����ȷ����Ҫ���͵���ֵ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End Try
    Next i
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    '[[[[[[[[[[[[[[[[[[[[[[[[20051125�ŵ�ǰ���ˣ��жϺ��������߳�[[[[[[[[[[[[[[[[[[[[[[[[[[
    ModemID = CW.Maps(MapNo).Stations(StationNo).ModemInfo.ID
    StationID = ModemIDtoStationID(ModemID)
    If StationID = "" Then
      MessageBox.Show("��ѡվ��û�����ã������ú���ͨѶ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
      bMsend = False
      Exit Sub
    End If
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    '''''''''''''''''''''''''''''''''''�Ժ���϶����ĵ�֧�֣��������������
    '[[[[[[[[[[[[[[[[20080106[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    Dim DataMode As String
    DataMode = TXDM.S
    Dim tByteSM() As Byte
    Dim ValueInt As Long
    Dim FFFFFFFF As Long = 4294967296
    Dim bFuShu As Boolean = False

    'Dim SendMessageHowMany As Integer = StationDataInfo.StationModeInfo(CW.Maps(MapNo).Stations(StationNo).StationModeIndex).SendMessageHowMany
    Dim ParameterByteLong As Integer = StationDataInfo.StationModeInfo(CW.Maps(MapNo).Stations(StationNo).StationModeIndex).ParameterByteLong
    Dim OrderDot As Integer = 2
    DataLen = SendMessageHowMany * ParameterByteLong
    ReDim tByteSM(DataLen - 1)
    ReDim tByte(SendData_BasicLong + DataLen - 1)

    Try

      'tByteSM(0) = tDate.Month
      'tByteSM(1) = tDate.Day
      'tByteSM(2) = tDate.Hour
      'tByteSM(3) = tDate.Minute
      k = 0 '20080303��0��Ϊ4�Է���ʱ��;20081020�Ļ�0����Ϊ���ǰ�ʱ��ź�����
      For i = 2 To SendMessageHowMany '20080303��1��Ϊ2�Է���ʱ�䣻20081020���Ǳ���2����Ϊʱ���������ļ�����Ȼ����ǰ��
        bFuShu = False
        ValueInt = CLng((CW.Maps(MapNo).Stations(StationNo).SendMessageValue(i)) * (10 ^ OrderDot))
        If ValueInt < 0 Then
          bFuShu = True
          ValueInt = Abs(ValueInt)
          ValueInt = FFFFFFFF - ValueInt
        End If
        Debug.Print(ValueInt.ToString)

        For j = ParameterByteLong To 1 Step -1
          tByteSM(k) = ValueInt \ (256 ^ (j - 1))
          ValueInt -= tByteSM(k) * (256 ^ (j - 1))
          'If j = ParameterByteLong Then
          '  If bFuShu Then
          '    tByteSM(k) += 128 '''''''''''�ø���
          '  End If
          'End If
          k += 1
        Next j

      Next i
      '[[[[[[[[20081020���ǰ�ʱ��ź�����
      tByteSM(k) = tDate.Month
      tByteSM(k + 1) = tDate.Day
      tByteSM(k + 2) = tDate.Hour
      tByteSM(k + 3) = tDate.Minute
      ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    Catch ex As Exception
      Debug.Print(ex.Message)
      bMsend = False
      Exit Sub
    End Try


    'DataLen = Len(RtxtSendData.Text)
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

    BuildSendByteSendMessage(StationID, Host_ID, DataMode, tByteSM, tByte)

    '[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[
    bSuc = True
    If FSendOne(ModemID, tByte) = False Then  '��������ʧ����ͨѶʧ��,�淢��ʱ����
      If FSendOne(ModemID, tByte) = False Then
        If FSendOne(ModemID, tByte) = False Then
          bSuc = False
        End If
      End If
    End If

    If bSuc Then
      LabelSendMessageSendState.BackColor = SendMessageStateClass.SendMessageStateColorWait
      LabelSendMessageSendState.Text = SendMessageStateClass.SendMessageStateStrWait
      AddText("����ModemID��" & ModemID & " " & "���ݳɹ���")

      btnSendMessageSend.Enabled = False
      ComboBoxSelectMap0.Enabled = False
      ComboBoxSelectMap1.Enabled = False
      ComboBoxSelectStation.Enabled = False
      ButtonPerMap.Enabled = False
      BtnNextMap.Enabled = False
      BtnSelctPerStation.Enabled = False
      BtnSelctNextStation.Enabled = False

      SendSSStationID = StationID
      SendSSStartTime = Now
      bSendSSSucess = False
      TimerSendSSS.Start()

    Else
      LabelSendMessageSendState.BackColor = SendMessageStateClass.SendMessageStateColorLost
      LabelSendMessageSendState.Text = SendMessageStateClass.SendMessageStateStrLost
      AddText("����ModemID��" & ModemID & " " & "����ʧ�ܡ�")
    End If

    '((((((((((((((((((((((((((((((((((((((((((((((((((
    'btnSendMessageSend.Enabled = False
    'ComboBoxSelectMap0.Enabled = False
    'ComboBoxSelectMap1.Enabled = False
    'ComboBoxSelectStation.Enabled = False
    'ButtonPerMap.Enabled = False
    'BtnNextMap.Enabled = False
    'BtnSelctPerStation.Enabled = False
    'BtnSelctNextStation.Enabled = False

    'SendSSStationID = StationID
    'SendSSStartTime = Now
    'bSendSSSucess = False
    'TimerSendSSS.Start()
    '))))))))))))))))))))))))))))))))))))))))))))))))))))
    ']]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
    bMsend = False

  End Sub

  Private Sub btnShowSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSendMessage.Click
    If PanelSendMessage.Visible Then
      PanelSendMessage.Visible = False
    Else
      PanelSendMessage.Visible = True
    End If
  End Sub

  Private Sub TimerSendSSS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSendSSS.Tick
    If bSendSSSucess Then
      bSendSSSucess = False
      LabelSendMessageSendState.BackColor = SendMessageStateClass.SendMessageStateColorSucc
      LabelSendMessageSendState.Text = SendMessageStateClass.SendMessageStateStrSucc

      btnSendMessageSend.Enabled = True
      ComboBoxSelectMap0.Enabled = True
      ComboBoxSelectMap1.Enabled = True
      ComboBoxSelectStation.Enabled = True
      ButtonPerMap.Enabled = True
      BtnNextMap.Enabled = True
      BtnSelctPerStation.Enabled = True
      BtnSelctNextStation.Enabled = True
      LabelSendSSSWaiTimeS.Text = ""
      TimerSendSSS.Stop()

      Exit Sub

    End If

    If DateDiff(DateInterval.Second, SendSSStartTime, Now) >= 10 Then
      bSendSSSucess = False
      LabelSendMessageSendState.BackColor = SendMessageStateClass.SendMessageStateColorLost
      LabelSendMessageSendState.Text = SendMessageStateClass.SendMessageStateStrLost

      btnSendMessageSend.Enabled = True
      ComboBoxSelectMap0.Enabled = True
      ComboBoxSelectMap1.Enabled = True
      ComboBoxSelectStation.Enabled = True
      ButtonPerMap.Enabled = True
      BtnNextMap.Enabled = True
      BtnSelctPerStation.Enabled = True
      BtnSelctNextStation.Enabled = True
      LabelSendSSSWaiTimeS.Text = ""
      TimerSendSSS.Stop()
    Else
      LabelSendSSSWaiTimeS.Text = 10 - DateDiff(DateInterval.Second, SendSSStartTime, Now)

    End If
  End Sub

End Class