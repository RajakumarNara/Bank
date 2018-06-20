Imports System.Math
Imports System.IO

Public Class frmFDCreation
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objCA As New clsCurrentAccount

    Dim lngPersonNo As Long = 0
    Dim objFDAccount As New clsFDAccount
    Dim objMember As New clsMember
    Dim dtInterest As New DataTable
    Dim objPerson As New clsPerson
    Dim bolVisible As Boolean
    Dim bolCumulative As Boolean = False
    Dim bolMonth As Boolean = False
    Dim objSavingsBank As New clsSavingsBank
    Dim dblAvalAmount As Double
    Dim objCurrentAccount As New clsCurrentAccount
    Dim dblOverDrawLimit As Double
    Dim dblCalIntrest As Double
    ''''''''
    Dim TempSubdays As Integer = 0
    Dim TempSubMonth As Integer = 0
    Dim TempTotalDays As Integer = 0
    Dim tempNOM As Integer = 0
    Dim timeTemp As Date
    Dim bolTemp As Boolean = True
    Dim datFDDate As Date
    Dim datFDDateTemp As Date
    Dim datFDMatDate As Date
    Dim dtMasterData As DataTable

    Dim intLedgerNo As Integer
    Public strFDNo As String
    Dim strEducation As String
    Dim strOffAddress As String
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NaveenSirMtd As System.Windows.Forms.RadioButton
    Friend WithEvents BTMMethod As System.Windows.Forms.RadioButton
    Friend WithEvents StandardMtd As System.Windows.Forms.RadioButton
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Dim strOfficeNo As String

    ''
    '
    ' Dim timeTemp As Date

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents btnLoadSign As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents tbFDDetails As System.Windows.Forms.TabPage
    Friend WithEvents cmbFDType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtFDAccountNo As BankControls.TextControl
    Friend WithEvents grpFDDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpFDType As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents btnReceiptDetails As BankControls.NewButton
    Friend WithEvents btnJointHolders As BankControls.NewButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents BalloonToolTip1 As CustomTooltip.BalloonToolTip
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnFDBond As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents chkFundTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTransFund As BankControls.NumericControl
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents dtpMajor As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPermAddress As BankControls.TextControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As BankControls.TextControl
    Friend WithEvents txtMobileNo As BankControls.TextControl
    Friend WithEvents btnSearchMember As BankControls.NewButton
    Friend WithEvents btnNewMember As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtIntroNo As BankControls.TextControl
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbOpMode As System.Windows.Forms.ComboBox
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rdbSYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents btnSBSearch As BankControls.NewButton
    Friend WithEvents txtPresAddress As BankControls.TextControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents lblAType As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDDays As BankControls.NumericControl
    Friend WithEvents txtFDMonths As BankControls.NumericControl
    Friend WithEvents txtFDYears As BankControls.NumericControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtFDROI As BankControls.NumericControl
    Friend WithEvents txtFDIntAmount As BankControls.NumericControl
    Friend WithEvents dtpFDMatDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDMatAmount As BankControls.NumericControl
    Friend WithEvents btnCalculate As BankControls.NewButton
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtBondNo As BankControls.NumericControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents lblCInterest As System.Windows.Forms.Label
    Friend WithEvents txtCInterest As BankControls.NumericControl
    Friend WithEvents Correction As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorrectionAmount As BankControls.NumericControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents chkSubtract As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdd As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents chkCorrection As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnTransafer As BankControls.NewButton
    Friend WithEvents txtTransferAccount As BankControls.TextControl
    Friend WithEvents dtpNextDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDCreation))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnAdd = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.chkFundTransfer = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtTransFund = New BankControls.NumericControl
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSBSearch = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.dtpMajor = New System.Windows.Forms.DateTimePicker
        Me.lblMajor = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkSame = New System.Windows.Forms.CheckBox
        Me.cmbCaste = New System.Windows.Forms.ComboBox
        Me.cmbReligion = New System.Windows.Forms.ComboBox
        Me.txtAge = New BankControls.NumericControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.txtFatherName = New BankControls.TextControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPermAddress = New BankControls.TextControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPresAddress = New BankControls.TextControl
        Me.cmbOccupation = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtPhoneNo = New BankControls.TextControl
        Me.txtMobileNo = New BankControls.TextControl
        Me.btnSearchMember = New BankControls.NewButton
        Me.btnNewMember = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtIntroNo = New BankControls.TextControl
        Me.Label29 = New System.Windows.Forms.Label
        Me.cmbAccountType = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.cmbOpMode = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.rdbSYes = New System.Windows.Forms.RadioButton
        Me.rdbSNo = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbFDDetails = New System.Windows.Forms.TabPage
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Total_Amt = New System.Windows.Forms.ColumnHeader
        Me.grpFDDetails = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.StandardMtd = New System.Windows.Forms.RadioButton
        Me.BTMMethod = New System.Windows.Forms.RadioButton
        Me.NaveenSirMtd = New System.Windows.Forms.RadioButton
        Me.btnCalculate = New BankControls.NewButton
        Me.Correction = New System.Windows.Forms.GroupBox
        Me.txtCorrectionAmount = New BankControls.NumericControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.chkSubtract = New System.Windows.Forms.CheckBox
        Me.chkAdd = New System.Windows.Forms.CheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.chkCorrection = New System.Windows.Forms.CheckBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.dtpNextDate = New System.Windows.Forms.DateTimePicker
        Me.btnTransafer = New BankControls.NewButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTransferAccount = New BankControls.TextControl
        Me.lblCInterest = New System.Windows.Forms.Label
        Me.txtCInterest = New BankControls.NumericControl
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.txtFDAmount = New BankControls.NumericControl
        Me.lblAType = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.dtpFDDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDDays = New BankControls.NumericControl
        Me.txtFDMonths = New BankControls.NumericControl
        Me.txtFDYears = New BankControls.NumericControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label111 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtFDROI = New BankControls.NumericControl
        Me.txtFDIntAmount = New BankControls.NumericControl
        Me.dtpFDMatDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDMatAmount = New BankControls.NumericControl
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtBondNo = New BankControls.NumericControl
        Me.cmbPeriod = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.grpFDType = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbFDType = New System.Windows.Forms.ComboBox
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtRemarks = New BankControls.TextControl
        Me.btnLoadPhoto = New BankControls.NewButton
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.lblSignature = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnCancelPhoto = New BankControls.NewButton
        Me.btnCancelSign = New BankControls.NewButton
        Me.btnLoadSign = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFDAccountNo = New BankControls.TextControl
        Me.btnSearchFD = New BankControls.NewButton
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton4 = New BankControls.NewButton
        Me.NewButton2 = New BankControls.NewButton
        Me.btnReceiptDetails = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.btnFamilyDetails = New BankControls.NewButton
        Me.btnJointHolders = New BankControls.NewButton
        Me.btnFDBond = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BalloonToolTip1 = New CustomTooltip.BalloonToolTip
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tbFDDetails.SuspendLayout()
        Me.grpFDDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Correction.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.grpFDType.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox2, Nothing)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtFDAccountNo)
        Me.GroupBox2.Controls.Add(Me.btnSearchFD)
        Me.GroupBox2.Controls.Add(Me.cmbDepositType)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 624)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox1, Nothing)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnAdd, Nothing)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(32, 576)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label2, Nothing)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(472, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.BalloonToolTip1.SetBalloonText(Me.txtName, Nothing)
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(528, 56)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 4
        '
        'TabControl1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.TabControl1, Nothing)
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbFDDetails)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(6, 97)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(780, 471)
        Me.TabControl1.TabIndex = 4
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.tbPersonal, Nothing)
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPersonal.Controls.Add(Me.Panel4)
        Me.tbPersonal.Controls.Add(Me.chkFundTransfer)
        Me.tbPersonal.Controls.Add(Me.Panel3)
        Me.tbPersonal.Controls.Add(Me.NewButton3)
        Me.tbPersonal.Controls.Add(Me.dtpMajor)
        Me.tbPersonal.Controls.Add(Me.lblMajor)
        Me.tbPersonal.Controls.Add(Me.Label34)
        Me.tbPersonal.Controls.Add(Me.Panel1)
        Me.tbPersonal.Controls.Add(Me.Label3)
        Me.tbPersonal.Controls.Add(Me.Label7)
        Me.tbPersonal.Controls.Add(Me.chkSame)
        Me.tbPersonal.Controls.Add(Me.cmbCaste)
        Me.tbPersonal.Controls.Add(Me.cmbReligion)
        Me.tbPersonal.Controls.Add(Me.txtAge)
        Me.tbPersonal.Controls.Add(Me.Label12)
        Me.tbPersonal.Controls.Add(Me.dtpDOB)
        Me.tbPersonal.Controls.Add(Me.txtFatherName)
        Me.tbPersonal.Controls.Add(Me.Label5)
        Me.tbPersonal.Controls.Add(Me.Label6)
        Me.tbPersonal.Controls.Add(Me.Label8)
        Me.tbPersonal.Controls.Add(Me.Label9)
        Me.tbPersonal.Controls.Add(Me.Label10)
        Me.tbPersonal.Controls.Add(Me.txtPermAddress)
        Me.tbPersonal.Controls.Add(Me.Label14)
        Me.tbPersonal.Controls.Add(Me.txtPresAddress)
        Me.tbPersonal.Controls.Add(Me.cmbOccupation)
        Me.tbPersonal.Controls.Add(Me.Label25)
        Me.tbPersonal.Controls.Add(Me.Label26)
        Me.tbPersonal.Controls.Add(Me.txtPhoneNo)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo)
        Me.tbPersonal.Controls.Add(Me.btnSearchMember)
        Me.tbPersonal.Controls.Add(Me.btnNewMember)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.Label31)
        Me.tbPersonal.Controls.Add(Me.txtIntroNo)
        Me.tbPersonal.Controls.Add(Me.Label29)
        Me.tbPersonal.Controls.Add(Me.cmbAccountType)
        Me.tbPersonal.Controls.Add(Me.Label30)
        Me.tbPersonal.Controls.Add(Me.cmbOpMode)
        Me.tbPersonal.Controls.Add(Me.Label41)
        Me.tbPersonal.Controls.Add(Me.Panel5)
        Me.tbPersonal.Controls.Add(Me.Label4)
        Me.tbPersonal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(772, 442)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Panel4, Nothing)
        Me.Panel4.Controls.Add(Me.rdbMajor)
        Me.Panel4.Controls.Add(Me.rdbMinor)
        Me.Panel4.Enabled = False
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(160, 144)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(168, 32)
        Me.Panel4.TabIndex = 11
        '
        'rdbMajor
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbMajor, Nothing)
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Enabled = False
        Me.rdbMajor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 8)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 16)
        Me.rdbMajor.TabIndex = 12
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbMinor, Nothing)
        Me.rdbMinor.Enabled = False
        Me.rdbMinor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 8)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 16)
        Me.rdbMinor.TabIndex = 13
        Me.rdbMinor.Text = "Minor"
        '
        'chkFundTransfer
        '
        Me.chkFundTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.chkFundTransfer, Nothing)
        Me.chkFundTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFundTransfer.Location = New System.Drawing.Point(376, 16)
        Me.chkFundTransfer.Name = "chkFundTransfer"
        Me.chkFundTransfer.Size = New System.Drawing.Size(128, 24)
        Me.chkFundTransfer.TabIndex = 26
        Me.chkFundTransfer.Text = "Fund Transfer"
        Me.chkFundTransfer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Panel3, Nothing)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtTransFund)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.lblAvalBal)
        Me.Panel3.Controls.Add(Me.Label42)
        Me.Panel3.Controls.Add(Me.txtAccNo)
        Me.Panel3.Controls.Add(Me.btnSBSearch)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(376, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 128)
        Me.Panel3.TabIndex = 27
        '
        'txtTransFund
        '
        Me.txtTransFund.AfterDecimal = 2
        Me.BalloonToolTip1.SetBalloonText(Me.txtTransFund, Nothing)
        Me.txtTransFund.BeforeDecimal = 8
        Me.txtTransFund.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTransFund.Location = New System.Drawing.Point(72, 84)
        Me.txtTransFund.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtTransFund.MaxLength = 10
        Me.txtTransFund.MaxValue = 0
        Me.txtTransFund.MinValue = 0
        Me.txtTransFund.Name = "txtTransFund"
        Me.txtTransFund.Size = New System.Drawing.Size(128, 23)
        Me.txtTransFund.TabIndex = 30
        Me.txtTransFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label37, Nothing)
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(8, 87)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 16)
        Me.Label37.TabIndex = 124
        Me.Label37.Text = "Amount:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label36, Nothing)
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 53)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(128, 16)
        Me.Label36.TabIndex = 122
        Me.Label36.Text = "AvailableBalance: "
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblAvalBal, Nothing)
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(136, 53)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(31, 16)
        Me.lblAvalBal.TabIndex = 121
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label42, Nothing)
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(8, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 16)
        Me.Label42.TabIndex = 153
        Me.Label42.Text = "SB No:"
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.SystemColors.Window
        Me.BalloonToolTip1.SetBalloonText(Me.txtAccNo, Nothing)
        Me.txtAccNo.BlankSpace = True
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(72, 17)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 28
        Me.txtAccNo.TabStop = False
        '
        'btnSBSearch
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnSBSearch, Nothing)
        Me.btnSBSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSBSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSBSearch.Image = CType(resources.GetObject("btnSBSearch.Image"), System.Drawing.Image)
        Me.btnSBSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSBSearch.Location = New System.Drawing.Point(216, 16)
        Me.btnSBSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSBSearch.Name = "btnSBSearch"
        Me.btnSBSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSBSearch.TabIndex = 29
        Me.btnSBSearch.Visible = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton3, "Search for Member")
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(672, 416)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(24, 24)
        Me.NewButton3.TabIndex = 37
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'dtpMajor
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpMajor, "Date Of Becoming Major")
        Me.dtpMajor.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtpMajor.CustomFormat = "dd - MMM - yyyy"
        Me.dtpMajor.Enabled = False
        Me.dtpMajor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMajor.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMajor.Location = New System.Drawing.Point(160, 184)
        Me.dtpMajor.MaxDate = New Date(3000, 11, 29, 0, 0, 0, 0)
        Me.dtpMajor.Name = "dtpMajor"
        Me.dtpMajor.Size = New System.Drawing.Size(168, 23)
        Me.dtpMajor.TabIndex = 14
        Me.dtpMajor.TabStop = False
        Me.dtpMajor.Value = New Date(1950, 3, 1, 0, 0, 0, 0)
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.lblMajor, Nothing)
        Me.lblMajor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.ForeColor = System.Drawing.Color.Black
        Me.lblMajor.Location = New System.Drawing.Point(24, 184)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(148, 16)
        Me.lblMajor.TabIndex = 103
        Me.lblMajor.Text = "Date He Turn Major :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label34, Nothing)
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(24, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 16)
        Me.Label34.TabIndex = 102
        Me.Label34.Text = "Husband Name "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Panel1, Nothing)
        Me.Panel1.Controls.Add(Me.rdbMale)
        Me.Panel1.Controls.Add(Me.rdbFemale)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(160, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 32)
        Me.Panel1.TabIndex = 15
        '
        'rdbMale
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbMale, Nothing)
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 8)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 16)
        Me.rdbMale.TabIndex = 16
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbFemale, Nothing)
        Me.rdbFemale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 8)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 16)
        Me.rdbFemale.TabIndex = 17
        Me.rdbFemale.Text = "Female"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label3, Nothing)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Gender:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label7, Nothing)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(24, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Age Status:"
        '
        'chkSame
        '
        Me.chkSame.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.chkSame, Nothing)
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(504, 248)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(216, 24)
        Me.chkSame.TabIndex = 32
        Me.chkSame.Text = "same as permanent address"
        Me.chkSame.UseVisualStyleBackColor = False
        '
        'cmbCaste
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbCaste, Nothing)
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(160, 320)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 22
        '
        'cmbReligion
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbReligion, Nothing)
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(160, 288)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 21
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtAge, Nothing)
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(160, 112)
        Me.txtAge.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(56, 23)
        Me.txtAge.TabIndex = 10
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label12, Nothing)
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(376, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Present Address:"
        '
        'dtpDOB
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpDOB, Nothing)
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(160, 80)
        Me.dtpDOB.MaxDate = New Date(2999, 11, 29, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtpDOB.TabIndex = 9
        Me.dtpDOB.Value = New Date(1950, 3, 1, 0, 0, 0, 0)
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtFatherName, Nothing)
        Me.txtFatherName.BlankSpace = True
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(160, 46)
        Me.txtFatherName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 35
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label5, Nothing)
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label6, Nothing)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label8, Nothing)
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(24, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label9, Nothing)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(24, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label10, Nothing)
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(24, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation:"
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtPermAddress, Nothing)
        Me.txtPermAddress.BlankSpace = True
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(520, 184)
        Me.txtPermAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label14, Nothing)
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(376, 207)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Permanent Address:"
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtPresAddress, Nothing)
        Me.txtPresAddress.BlankSpace = True
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(520, 280)
        Me.txtPresAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 33
        '
        'cmbOccupation
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbOccupation, Nothing)
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(160, 352)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(168, 24)
        Me.cmbOccupation.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label25, Nothing)
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(376, 386)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label26, Nothing)
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(376, 354)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 16)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No:"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtPhoneNo, Nothing)
        Me.txtPhoneNo.BlankSpace = False
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(520, 385)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPhoneNo.Mandatory = False
        Me.txtPhoneNo.MaxLength = 20
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.SpecialChar = True
        Me.txtPhoneNo.TabIndex = 35
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtMobileNo, Nothing)
        Me.txtMobileNo.BlankSpace = False
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(520, 353)
        Me.txtMobileNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtMobileNo.Mandatory = False
        Me.txtMobileNo.MaxLength = 20
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.SpecialChar = True
        Me.txtMobileNo.TabIndex = 34
        '
        'btnSearchMember
        '
        Me.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnSearchMember, "Search for Member")
        Me.btnSearchMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchMember.ForeColor = System.Drawing.Color.Black
        Me.btnSearchMember.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchMember.Image = CType(resources.GetObject("btnSearchMember.Image"), System.Drawing.Image)
        Me.btnSearchMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchMember.Location = New System.Drawing.Point(296, 16)
        Me.btnSearchMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearchMember.Name = "btnSearchMember"
        Me.btnSearchMember.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchMember.TabIndex = 6
        Me.btnSearchMember.UseVisualStyleBackColor = False
        '
        'btnNewMember
        '
        Me.btnNewMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnNewMember, "Create New Member")
        Me.btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMember.ForeColor = System.Drawing.Color.Black
        Me.btnNewMember.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewMember.Image = CType(resources.GetObject("btnNewMember.Image"), System.Drawing.Image)
        Me.btnNewMember.Location = New System.Drawing.Point(328, 16)
        Me.btnNewMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(32, 24)
        Me.btnNewMember.TabIndex = 7
        Me.btnNewMember.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label1, Nothing)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.txtCustomerID, Nothing)
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtCustomerID.Location = New System.Drawing.Point(160, 17)
        Me.txtCustomerID.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(128, 23)
        Me.txtCustomerID.SpecialChar = True
        Me.txtCustomerID.TabIndex = 5
        Me.txtCustomerID.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label31, Nothing)
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(376, 419)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Introducer No :"
        '
        'txtIntroNo
        '
        Me.txtIntroNo.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtIntroNo, Nothing)
        Me.txtIntroNo.BlankSpace = True
        Me.txtIntroNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntroNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntroNo.Location = New System.Drawing.Point(520, 417)
        Me.txtIntroNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtIntroNo.Mandatory = False
        Me.txtIntroNo.MaxLength = 30
        Me.txtIntroNo.Name = "txtIntroNo"
        Me.txtIntroNo.Size = New System.Drawing.Size(136, 23)
        Me.txtIntroNo.SpecialChar = True
        Me.txtIntroNo.TabIndex = 36
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label29, Nothing)
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(24, 384)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(107, 16)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Account Type:"
        '
        'cmbAccountType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbAccountType, Nothing)
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccountType.Location = New System.Drawing.Point(160, 384)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccountType.TabIndex = 24
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label30, Nothing)
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(24, 416)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(118, 16)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Operation Mode:"
        '
        'cmbOpMode
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbOpMode, Nothing)
        Me.cmbOpMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOpMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOpMode.Items.AddRange(New Object() {"Either", "Either or Survivor", "Both"})
        Me.cmbOpMode.Location = New System.Drawing.Point(160, 416)
        Me.cmbOpMode.Name = "cmbOpMode"
        Me.cmbOpMode.Size = New System.Drawing.Size(168, 24)
        Me.cmbOpMode.TabIndex = 25
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label41, Nothing)
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(24, 256)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(106, 16)
        Me.Label41.TabIndex = 152
        Me.Label41.Text = "senior citizen :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Panel5, Nothing)
        Me.Panel5.Controls.Add(Me.rdbSYes)
        Me.Panel5.Controls.Add(Me.rdbSNo)
        Me.Panel5.Enabled = False
        Me.Panel5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(160, 248)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(168, 32)
        Me.Panel5.TabIndex = 18
        '
        'rdbSYes
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbSYes, Nothing)
        Me.rdbSYes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSYes.Location = New System.Drawing.Point(8, 8)
        Me.rdbSYes.Name = "rdbSYes"
        Me.rdbSYes.Size = New System.Drawing.Size(72, 16)
        Me.rdbSYes.TabIndex = 19
        Me.rdbSYes.Text = "Yes"
        '
        'rdbSNo
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbSNo, Nothing)
        Me.rdbSNo.Checked = True
        Me.rdbSNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSNo.Location = New System.Drawing.Point(88, 8)
        Me.rdbSNo.Name = "rdbSNo"
        Me.rdbSNo.Size = New System.Drawing.Size(72, 16)
        Me.rdbSNo.TabIndex = 20
        Me.rdbSNo.TabStop = True
        Me.rdbSNo.Text = "No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label4, Nothing)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father / "
        '
        'tbFDDetails
        '
        Me.tbFDDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.tbFDDetails, Nothing)
        Me.tbFDDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFDDetails.Controls.Add(Me.lvInterest)
        Me.tbFDDetails.Controls.Add(Me.grpFDDetails)
        Me.tbFDDetails.Controls.Add(Me.grpFDType)
        Me.tbFDDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbFDDetails.Name = "tbFDDetails"
        Me.tbFDDetails.Size = New System.Drawing.Size(772, 442)
        Me.tbFDDetails.TabIndex = 3
        Me.tbFDDetails.Text = "Deposit Details"
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.AliceBlue
        Me.BalloonToolTip1.SetBalloonText(Me.lvInterest, Nothing)
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Int_Amt, Me.Int_Date, Me.Total_Amt})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.Location = New System.Drawing.Point(10, 285)
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(747, 152)
        Me.lvInterest.TabIndex = 5
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.Width = 130
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.Width = 130
        '
        'Total_Amt
        '
        Me.Total_Amt.Text = "Total Amount"
        Me.Total_Amt.Width = 130
        '
        'grpFDDetails
        '
        Me.BalloonToolTip1.SetBalloonText(Me.grpFDDetails, Nothing)
        Me.grpFDDetails.Controls.Add(Me.Panel2)
        Me.grpFDDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFDDetails.ForeColor = System.Drawing.Color.Black
        Me.grpFDDetails.Location = New System.Drawing.Point(8, 40)
        Me.grpFDDetails.Name = "grpFDDetails"
        Me.grpFDDetails.Size = New System.Drawing.Size(749, 240)
        Me.grpFDDetails.TabIndex = 3
        Me.grpFDDetails.TabStop = False
        Me.grpFDDetails.Text = "Deposit Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Panel2, Nothing)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.Correction)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.dtpNextDate)
        Me.Panel2.Controls.Add(Me.btnTransafer)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtTransferAccount)
        Me.Panel2.Controls.Add(Me.lblCInterest)
        Me.Panel2.Controls.Add(Me.txtCInterest)
        Me.Panel2.Controls.Add(Me.txtReceiptNo)
        Me.Panel2.Controls.Add(Me.txtFDAmount)
        Me.Panel2.Controls.Add(Me.lblAType)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.dtpFDDate)
        Me.Panel2.Controls.Add(Me.txtFDDays)
        Me.Panel2.Controls.Add(Me.txtFDMonths)
        Me.Panel2.Controls.Add(Me.txtFDYears)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.Label111)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.txtFDROI)
        Me.Panel2.Controls.Add(Me.txtFDIntAmount)
        Me.Panel2.Controls.Add(Me.dtpFDMatDate)
        Me.Panel2.Controls.Add(Me.txtFDMatAmount)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.txtBondNo)
        Me.Panel2.Controls.Add(Me.cmbPeriod)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Enabled = False
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(8, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 213)
        Me.Panel2.TabIndex = 4
        Me.Panel2.TabStop = True
        '
        'GroupBox3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox3, Nothing)
        Me.GroupBox3.Controls.Add(Me.StandardMtd)
        Me.GroupBox3.Controls.Add(Me.BTMMethod)
        Me.GroupBox3.Controls.Add(Me.NaveenSirMtd)
        Me.GroupBox3.Controls.Add(Me.btnCalculate)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 84)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculation Type "
        '
        'StandardMtd
        '
        Me.StandardMtd.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.StandardMtd, Nothing)
        Me.StandardMtd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StandardMtd.Location = New System.Drawing.Point(9, 61)
        Me.StandardMtd.Name = "StandardMtd"
        Me.StandardMtd.Size = New System.Drawing.Size(86, 20)
        Me.StandardMtd.TabIndex = 12
        Me.StandardMtd.TabStop = True
        Me.StandardMtd.Text = "Standard"
        Me.StandardMtd.UseVisualStyleBackColor = True
        '
        'BTMMethod
        '
        Me.BTMMethod.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.BTMMethod, Nothing)
        Me.BTMMethod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMMethod.Location = New System.Drawing.Point(10, 38)
        Me.BTMMethod.Name = "BTMMethod"
        Me.BTMMethod.Size = New System.Drawing.Size(80, 20)
        Me.BTMMethod.TabIndex = 11
        Me.BTMMethod.TabStop = True
        Me.BTMMethod.Text = "Daywise"
        Me.BTMMethod.UseVisualStyleBackColor = True
        '
        'NaveenSirMtd
        '
        Me.NaveenSirMtd.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.NaveenSirMtd, Nothing)
        Me.NaveenSirMtd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NaveenSirMtd.Location = New System.Drawing.Point(10, 15)
        Me.NaveenSirMtd.Name = "NaveenSirMtd"
        Me.NaveenSirMtd.Size = New System.Drawing.Size(147, 20)
        Me.NaveenSirMtd.TabIndex = 10
        Me.NaveenSirMtd.TabStop = True
        Me.NaveenSirMtd.Text = "365/12 Monthwise"
        Me.NaveenSirMtd.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnCalculate, Nothing)
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(117, 47)
        Me.btnCalculate.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 24)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Correction
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Correction, Nothing)
        Me.Correction.Controls.Add(Me.txtCorrectionAmount)
        Me.Correction.Controls.Add(Me.Panel6)
        Me.Correction.Controls.Add(Me.Label35)
        Me.Correction.Controls.Add(Me.chkCorrection)
        Me.Correction.Enabled = False
        Me.Correction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correction.Location = New System.Drawing.Point(227, 145)
        Me.Correction.Name = "Correction"
        Me.Correction.Size = New System.Drawing.Size(239, 21)
        Me.Correction.TabIndex = 16
        Me.Correction.TabStop = False
        Me.Correction.Visible = False
        '
        'txtCorrectionAmount
        '
        Me.txtCorrectionAmount.AfterDecimal = 2
        Me.BalloonToolTip1.SetBalloonText(Me.txtCorrectionAmount, Nothing)
        Me.txtCorrectionAmount.BeforeDecimal = 10
        Me.txtCorrectionAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCorrectionAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCorrectionAmount.Location = New System.Drawing.Point(240, 26)
        Me.txtCorrectionAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCorrectionAmount.MaxValue = 0
        Me.txtCorrectionAmount.MinValue = 0
        Me.txtCorrectionAmount.Name = "txtCorrectionAmount"
        Me.txtCorrectionAmount.Size = New System.Drawing.Size(120, 22)
        Me.txtCorrectionAmount.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Panel6, Nothing)
        Me.Panel6.Controls.Add(Me.chkSubtract)
        Me.Panel6.Controls.Add(Me.chkAdd)
        Me.Panel6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(8, 21)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(168, 32)
        Me.Panel6.TabIndex = 17
        '
        'chkSubtract
        '
        Me.BalloonToolTip1.SetBalloonText(Me.chkSubtract, Nothing)
        Me.chkSubtract.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubtract.Location = New System.Drawing.Point(72, 8)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(88, 16)
        Me.chkSubtract.TabIndex = 12
        Me.chkSubtract.Text = "Subtract"
        '
        'chkAdd
        '
        Me.BalloonToolTip1.SetBalloonText(Me.chkAdd, Nothing)
        Me.chkAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdd.Location = New System.Drawing.Point(8, 8)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(56, 16)
        Me.chkAdd.TabIndex = 11
        Me.chkAdd.Text = "Add"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label35, Nothing)
        Me.Label35.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(176, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 15)
        Me.Label35.TabIndex = 137
        Me.Label35.Text = "Amount :"
        '
        'chkCorrection
        '
        Me.BalloonToolTip1.SetBalloonText(Me.chkCorrection, Nothing)
        Me.chkCorrection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorrection.Location = New System.Drawing.Point(0, 0)
        Me.chkCorrection.Name = "chkCorrection"
        Me.chkCorrection.Size = New System.Drawing.Size(96, 16)
        Me.chkCorrection.TabIndex = 10
        Me.chkCorrection.Text = "Correction"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label40, Nothing)
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(37, 3)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 32)
        Me.Label40.TabIndex = 144
        Me.Label40.Text = "Next Quater Date:"
        '
        'dtpNextDate
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpNextDate, Nothing)
        Me.dtpNextDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpNextDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNextDate.Location = New System.Drawing.Point(136, 8)
        Me.dtpNextDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpNextDate.Name = "dtpNextDate"
        Me.dtpNextDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpNextDate.TabIndex = 143
        Me.dtpNextDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'btnTransafer
        '
        Me.btnTransafer.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnTransafer, "Search for Member")
        Me.btnTransafer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransafer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransafer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransafer.ForeColor = System.Drawing.Color.Black
        Me.btnTransafer.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransafer.Image = CType(resources.GetObject("btnTransafer.Image"), System.Drawing.Image)
        Me.btnTransafer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransafer.Location = New System.Drawing.Point(447, 181)
        Me.btnTransafer.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnTransafer.Name = "btnTransafer"
        Me.btnTransafer.Size = New System.Drawing.Size(24, 24)
        Me.btnTransafer.TabIndex = 15
        Me.btnTransafer.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label11, Nothing)
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(172, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 16)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Interest transfer to  :"
        '
        'txtTransferAccount
        '
        Me.txtTransferAccount.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtTransferAccount, Nothing)
        Me.txtTransferAccount.BlankSpace = True
        Me.txtTransferAccount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferAccount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTransferAccount.Location = New System.Drawing.Point(326, 182)
        Me.txtTransferAccount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtTransferAccount.Mandatory = False
        Me.txtTransferAccount.MaxLength = 30
        Me.txtTransferAccount.Name = "txtTransferAccount"
        Me.txtTransferAccount.Size = New System.Drawing.Size(118, 23)
        Me.txtTransferAccount.SpecialChar = True
        Me.txtTransferAccount.TabIndex = 14
        '
        'lblCInterest
        '
        Me.lblCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.lblCInterest, Nothing)
        Me.lblCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCInterest.ForeColor = System.Drawing.Color.Black
        Me.lblCInterest.Location = New System.Drawing.Point(479, 115)
        Me.lblCInterest.Name = "lblCInterest"
        Me.lblCInterest.Size = New System.Drawing.Size(104, 16)
        Me.lblCInterest.TabIndex = 140
        Me.lblCInterest.Text = "Corrected Int:"
        Me.lblCInterest.Visible = False
        '
        'txtCInterest
        '
        Me.txtCInterest.AfterDecimal = 2
        Me.txtCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.txtCInterest, Nothing)
        Me.txtCInterest.BeforeDecimal = 8
        Me.txtCInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCInterest.Enabled = False
        Me.txtCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCInterest.Location = New System.Drawing.Point(591, 112)
        Me.txtCInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCInterest.MaxLength = 10
        Me.txtCInterest.MaxValue = 0
        Me.txtCInterest.MinValue = 0
        Me.txtCInterest.Name = "txtCInterest"
        Me.txtCInterest.ReadOnly = True
        Me.txtCInterest.Size = New System.Drawing.Size(136, 23)
        Me.txtCInterest.TabIndex = 141
        Me.txtCInterest.TabStop = False
        Me.txtCInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCInterest.Visible = False
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtReceiptNo, Nothing)
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(591, 182)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 17
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BackColor = System.Drawing.Color.White
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDAmount, Nothing)
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmount.Location = New System.Drawing.Point(349, 49)
        Me.txtFDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAmount.MaxLength = 11
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAmount.TabIndex = 8
        Me.txtFDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAType
        '
        Me.lblAType.AutoSize = True
        Me.lblAType.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.lblAType, Nothing)
        Me.lblAType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAType.ForeColor = System.Drawing.Color.Black
        Me.lblAType.Location = New System.Drawing.Point(277, 51)
        Me.lblAType.Name = "lblAType"
        Me.lblAType.Size = New System.Drawing.Size(64, 16)
        Me.lblAType.TabIndex = 135
        Me.lblAType.Text = "Amount:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label27, Nothing)
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(479, 184)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 16)
        Me.Label27.TabIndex = 132
        Me.Label27.Text = "Receipt No:"
        '
        'dtpFDDate
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpFDDate, Nothing)
        Me.dtpFDDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(136, 40)
        Me.dtpFDDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpFDDate.TabIndex = 3
        Me.dtpFDDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'txtFDDays
        '
        Me.txtFDDays.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDDays, Nothing)
        Me.txtFDDays.BeforeDecimal = 3
        Me.txtFDDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDDays.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDDays.Location = New System.Drawing.Point(429, 19)
        Me.txtFDDays.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDDays.MaxLength = 3
        Me.txtFDDays.MaxValue = 200
        Me.txtFDDays.MinValue = 0
        Me.txtFDDays.Name = "txtFDDays"
        Me.txtFDDays.Size = New System.Drawing.Size(48, 23)
        Me.txtFDDays.TabIndex = 6
        Me.txtFDDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDMonths
        '
        Me.txtFDMonths.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDMonths, Nothing)
        Me.txtFDMonths.BeforeDecimal = 2
        Me.txtFDMonths.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMonths.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDMonths.Location = New System.Drawing.Point(389, 19)
        Me.txtFDMonths.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDMonths.MaxLength = 2
        Me.txtFDMonths.MaxValue = 11
        Me.txtFDMonths.MinValue = 0
        Me.txtFDMonths.Name = "txtFDMonths"
        Me.txtFDMonths.Size = New System.Drawing.Size(32, 23)
        Me.txtFDMonths.TabIndex = 5
        Me.txtFDMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDYears
        '
        Me.txtFDYears.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDYears, Nothing)
        Me.txtFDYears.BeforeDecimal = 2
        Me.txtFDYears.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDYears.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDYears.Location = New System.Drawing.Point(349, 19)
        Me.txtFDYears.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDYears.MaxLength = 2
        Me.txtFDYears.MaxValue = 0
        Me.txtFDYears.MinValue = 0
        Me.txtFDYears.Name = "txtFDYears"
        Me.txtFDYears.Size = New System.Drawing.Size(32, 23)
        Me.txtFDYears.TabIndex = 4
        Me.txtFDYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label38, Nothing)
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(479, 144)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 24)
        Me.Label38.TabIndex = 128
        Me.Label38.Text = "Maturity Amt:"
        '
        'Label111
        '
        Me.Label111.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label111, Nothing)
        Me.Label111.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.Black
        Me.Label111.Location = New System.Drawing.Point(479, 80)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(88, 24)
        Me.Label111.TabIndex = 127
        Me.Label111.Text = "Int Amt:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label16, Nothing)
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(479, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Maturity Date: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label17, Nothing)
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(479, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 16)
        Me.Label17.TabIndex = 125
        Me.Label17.Text = "Interest Rate:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label19, Nothing)
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label19.Location = New System.Drawing.Point(445, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 16)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "D"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label20, Nothing)
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label20.Location = New System.Drawing.Point(397, 3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 16)
        Me.Label20.TabIndex = 123
        Me.Label20.Text = "M"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label21, Nothing)
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label21.Location = New System.Drawing.Point(357, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 16)
        Me.Label21.TabIndex = 122
        Me.Label21.Text = "Y"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label22, Nothing)
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(277, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 16)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "Period:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label24, Nothing)
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(38, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 16)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "FD Date:"
        '
        'txtFDROI
        '
        Me.txtFDROI.AfterDecimal = 2
        Me.txtFDROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDROI, Nothing)
        Me.txtFDROI.BeforeDecimal = 8
        Me.txtFDROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDROI.Location = New System.Drawing.Point(591, 49)
        Me.txtFDROI.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDROI.MaxLength = 10
        Me.txtFDROI.MaxValue = 365
        Me.txtFDROI.MinValue = 0
        Me.txtFDROI.Name = "txtFDROI"
        Me.txtFDROI.Size = New System.Drawing.Size(136, 23)
        Me.txtFDROI.TabIndex = 115
        Me.txtFDROI.TabStop = False
        Me.txtFDROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDIntAmount
        '
        Me.txtFDIntAmount.AfterDecimal = 2
        Me.txtFDIntAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDIntAmount, Nothing)
        Me.txtFDIntAmount.BeforeDecimal = 8
        Me.txtFDIntAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFDIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDIntAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDIntAmount.Location = New System.Drawing.Point(591, 81)
        Me.txtFDIntAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDIntAmount.MaxLength = 10
        Me.txtFDIntAmount.MaxValue = 0
        Me.txtFDIntAmount.MinValue = 0
        Me.txtFDIntAmount.Name = "txtFDIntAmount"
        Me.txtFDIntAmount.ReadOnly = True
        Me.txtFDIntAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDIntAmount.TabIndex = 131
        Me.txtFDIntAmount.TabStop = False
        Me.txtFDIntAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFDMatDate
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpFDMatDate, Nothing)
        Me.dtpFDMatDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDMatDate.Enabled = False
        Me.dtpFDMatDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDMatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDMatDate.Location = New System.Drawing.Point(591, 19)
        Me.dtpFDMatDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpFDMatDate.Name = "dtpFDMatDate"
        Me.dtpFDMatDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpFDMatDate.TabIndex = 16
        Me.dtpFDMatDate.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'txtFDMatAmount
        '
        Me.txtFDMatAmount.AfterDecimal = 2
        Me.txtFDMatAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDMatAmount, Nothing)
        Me.txtFDMatAmount.BeforeDecimal = 8
        Me.txtFDMatAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFDMatAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMatAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.Location = New System.Drawing.Point(591, 145)
        Me.txtFDMatAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.MaxLength = 10
        Me.txtFDMatAmount.MaxValue = 0
        Me.txtFDMatAmount.MinValue = 0
        Me.txtFDMatAmount.Name = "txtFDMatAmount"
        Me.txtFDMatAmount.ReadOnly = True
        Me.txtFDMatAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDMatAmount.TabIndex = 130
        Me.txtFDMatAmount.TabStop = False
        Me.txtFDMatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label33, Nothing)
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(277, 83)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 16)
        Me.Label33.TabIndex = 133
        Me.Label33.Text = "Bond No:"
        '
        'txtBondNo
        '
        Me.txtBondNo.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtBondNo, Nothing)
        Me.txtBondNo.BeforeDecimal = 8
        Me.txtBondNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBondNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBondNo.Location = New System.Drawing.Point(349, 81)
        Me.txtBondNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBondNo.MaxLength = 10
        Me.txtBondNo.MaxValue = 0
        Me.txtBondNo.MinValue = 0
        Me.txtBondNo.Name = "txtBondNo"
        Me.txtBondNo.Size = New System.Drawing.Size(128, 23)
        Me.txtBondNo.TabIndex = 10
        '
        'cmbPeriod
        '
        Me.cmbPeriod.BackColor = System.Drawing.Color.White
        Me.BalloonToolTip1.SetBalloonText(Me.cmbPeriod, Nothing)
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriod.ForeColor = System.Drawing.Color.Black
        Me.cmbPeriod.Items.AddRange(New Object() {"At the end", "As Scheme Period"})
        Me.cmbPeriod.Location = New System.Drawing.Point(136, 64)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(136, 24)
        Me.cmbPeriod.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label23, Nothing)
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(39, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 16)
        Me.Label23.TabIndex = 137
        Me.Label23.Text = "Int Posting :"
        '
        'grpFDType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.grpFDType, Nothing)
        Me.grpFDType.Controls.Add(Me.Label15)
        Me.grpFDType.Controls.Add(Me.Label13)
        Me.grpFDType.Controls.Add(Me.cmbFDType)
        Me.grpFDType.Controls.Add(Me.cmbSchemeType)
        Me.grpFDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFDType.ForeColor = System.Drawing.Color.Black
        Me.grpFDType.Location = New System.Drawing.Point(8, 0)
        Me.grpFDType.Name = "grpFDType"
        Me.grpFDType.Size = New System.Drawing.Size(749, 48)
        Me.grpFDType.TabIndex = 0
        Me.grpFDType.TabStop = False
        Me.grpFDType.Text = "Deposit Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label15, Nothing)
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(514, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Intrest Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label13, Nothing)
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(9, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Scheme Type:"
        '
        'cmbFDType
        '
        Me.cmbFDType.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.cmbFDType, Nothing)
        Me.cmbFDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFDType.Enabled = False
        Me.cmbFDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFDType.ForeColor = System.Drawing.Color.Black
        Me.cmbFDType.Items.AddRange(New Object() {"", "Monthly", "Quarterly", "Half-Yearly", "Yearly"})
        Me.cmbFDType.Location = New System.Drawing.Point(615, 16)
        Me.cmbFDType.Name = "cmbFDType"
        Me.cmbFDType.Size = New System.Drawing.Size(128, 24)
        Me.cmbFDType.TabIndex = 2
        '
        'cmbSchemeType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbSchemeType, Nothing)
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(114, 16)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(394, 24)
        Me.cmbSchemeType.TabIndex = 1
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.tbOthers, Nothing)
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOthers.Controls.Add(Me.Label28)
        Me.tbOthers.Controls.Add(Me.txtRemarks)
        Me.tbOthers.Controls.Add(Me.btnLoadPhoto)
        Me.tbOthers.Controls.Add(Me.picSignature)
        Me.tbOthers.Controls.Add(Me.lblSignature)
        Me.tbOthers.Controls.Add(Me.picPhoto)
        Me.tbOthers.Controls.Add(Me.lblPhoto)
        Me.tbOthers.Controls.Add(Me.btnCancelPhoto)
        Me.tbOthers.Controls.Add(Me.btnCancelSign)
        Me.tbOthers.Controls.Add(Me.btnLoadSign)
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(772, 442)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label28, Nothing)
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(56, 312)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 16)
        Me.Label28.TabIndex = 55
        Me.Label28.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtRemarks, Nothing)
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(136, 312)
        Me.txtRemarks.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 225
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(480, 80)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 5
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnLoadPhoto, Nothing)
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 232)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 1
        Me.btnLoadPhoto.Text = "Load"
        Me.btnLoadPhoto.UseVisualStyleBackColor = False
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.BalloonToolTip1.SetBalloonText(Me.picSignature, Nothing)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSignature.Location = New System.Drawing.Point(456, 40)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(160, 184)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 51
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblSignature, Nothing)
        Me.lblSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(368, 40)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(77, 16)
        Me.lblSignature.TabIndex = 50
        Me.lblSignature.Text = "Signature:"
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.BalloonToolTip1.SetBalloonText(Me.picPhoto, Nothing)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto.Location = New System.Drawing.Point(136, 40)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 184)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 49
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblPhoto, Nothing)
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(72, 40)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(52, 16)
        Me.lblPhoto.TabIndex = 48
        Me.lblPhoto.Text = "Photo:"
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnCancelPhoto, Nothing)
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 232)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 2
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnCancelSign, Nothing)
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelSign.Location = New System.Drawing.Point(536, 232)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 4
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnLoadSign, Nothing)
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(456, 232)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 3
        Me.btnLoadSign.Text = "Load"
        Me.btnLoadSign.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnClose, Nothing)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(656, 576)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 39
        Me.btnClose.Text = "&Close"
        '
        'btnOk
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnOk, Nothing)
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(544, 576)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 38
        Me.btnOk.Text = "&Save"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label32, Nothing)
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(72, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(118, 23)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "New Deposit"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label18, Nothing)
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(216, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Account No: "
        '
        'txtFDAccountNo
        '
        Me.txtFDAccountNo.AlphaNumeric = True
        Me.txtFDAccountNo.BackColor = System.Drawing.SystemColors.Window
        Me.BalloonToolTip1.SetBalloonText(Me.txtFDAccountNo, Nothing)
        Me.txtFDAccountNo.BlankSpace = False
        Me.txtFDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAccountNo.Location = New System.Drawing.Point(312, 56)
        Me.txtFDAccountNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAccountNo.Mandatory = False
        Me.txtFDAccountNo.MaxLength = 10
        Me.txtFDAccountNo.Name = "txtFDAccountNo"
        Me.txtFDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAccountNo.SpecialChar = True
        Me.txtFDAccountNo.TabIndex = 3
        '
        'btnSearchFD
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnSearchFD, "Search for FD Account")
        Me.btnSearchFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchFD.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchFD.Image = CType(resources.GetObject("btnSearchFD.Image"), System.Drawing.Image)
        Me.btnSearchFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFD.Location = New System.Drawing.Point(440, 55)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 2
        '
        'cmbDepositType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbDepositType, Nothing)
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 100
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(128, 55)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(88, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label39, Nothing)
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(24, 58)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 16)
        Me.Label39.TabIndex = 64
        Me.Label39.Text = "Deposit Type:"
        '
        'GroupBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox1, Nothing)
        Me.GroupBox1.Controls.Add(Me.NewButton4)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnReceiptDetails)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox1.Controls.Add(Me.btnJointHolders)
        Me.GroupBox1.Controls.Add(Me.btnFDBond)
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 624)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'NewButton4
        '
        Me.NewButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton4, Nothing)
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.ForeColor = System.Drawing.Color.Black
        Me.NewButton4.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NewButton4.Image = CType(resources.GetObject("NewButton4.Image"), System.Drawing.Image)
        Me.NewButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton4.Location = New System.Drawing.Point(16, 520)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(168, 40)
        Me.NewButton4.TabIndex = 6
        Me.NewButton4.Text = "Delete Entry"
        Me.NewButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton4.UseVisualStyleBackColor = False
        Me.NewButton4.Visible = False
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton2, Nothing)
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(24, 448)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(168, 40)
        Me.NewButton2.TabIndex = 5
        Me.NewButton2.Text = "Provision"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton2.UseVisualStyleBackColor = False
        '
        'btnReceiptDetails
        '
        Me.btnReceiptDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnReceiptDetails, Nothing)
        Me.btnReceiptDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceiptDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceiptDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiptDetails.ForeColor = System.Drawing.Color.Black
        Me.btnReceiptDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReceiptDetails.Image = CType(resources.GetObject("btnReceiptDetails.Image"), System.Drawing.Image)
        Me.btnReceiptDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceiptDetails.Location = New System.Drawing.Point(24, 328)
        Me.btnReceiptDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnReceiptDetails.Name = "btnReceiptDetails"
        Me.btnReceiptDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnReceiptDetails.TabIndex = 3
        Me.btnReceiptDetails.Text = "Receipt Details"
        Me.btnReceiptDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReceiptDetails.UseVisualStyleBackColor = False
        Me.btnReceiptDetails.Visible = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnNominees, Nothing)
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(24, 248)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 1
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'btnFamilyDetails
        '
        Me.btnFamilyDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnFamilyDetails, Nothing)
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFamilyDetails.Image = CType(resources.GetObject("btnFamilyDetails.Image"), System.Drawing.Image)
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(24, 208)
        Me.btnFamilyDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFamilyDetails.Name = "btnFamilyDetails"
        Me.btnFamilyDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFamilyDetails.TabIndex = 0
        Me.btnFamilyDetails.Text = "Family Details"
        Me.btnFamilyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFamilyDetails.UseVisualStyleBackColor = False
        '
        'btnJointHolders
        '
        Me.btnJointHolders.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnJointHolders, Nothing)
        Me.btnJointHolders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJointHolders.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJointHolders.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJointHolders.ForeColor = System.Drawing.Color.Black
        Me.btnJointHolders.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnJointHolders.Image = CType(resources.GetObject("btnJointHolders.Image"), System.Drawing.Image)
        Me.btnJointHolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJointHolders.Location = New System.Drawing.Point(24, 288)
        Me.btnJointHolders.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnJointHolders.Name = "btnJointHolders"
        Me.btnJointHolders.Size = New System.Drawing.Size(168, 40)
        Me.btnJointHolders.TabIndex = 2
        Me.btnJointHolders.Text = "Joint Holders"
        Me.btnJointHolders.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnJointHolders.UseVisualStyleBackColor = False
        '
        'btnFDBond
        '
        Me.btnFDBond.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnFDBond, Nothing)
        Me.btnFDBond.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFDBond.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFDBond.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFDBond.ForeColor = System.Drawing.Color.Black
        Me.btnFDBond.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFDBond.Image = CType(resources.GetObject("btnFDBond.Image"), System.Drawing.Image)
        Me.btnFDBond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFDBond.Location = New System.Drawing.Point(24, 368)
        Me.btnFDBond.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFDBond.Name = "btnFDBond"
        Me.btnFDBond.Size = New System.Drawing.Size(168, 40)
        Me.btnFDBond.TabIndex = 4
        Me.btnFDBond.Text = "Issue  Bond"
        Me.btnFDBond.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFDBond.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton1, Nothing)
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(24, 408)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 4
        Me.NewButton1.Text = "Payments"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'BalloonToolTip1
        '
        Me.BalloonToolTip1.BackColor = System.Drawing.SystemColors.Info
        Me.BalloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BalloonToolTip1.Title = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmFDCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmFDCreation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Deposit Creation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.tbFDDetails.ResumeLayout(False)
        Me.grpFDDetails.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Correction.ResumeLayout(False)
        Me.Correction.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.grpFDType.ResumeLayout(False)
        Me.grpFDType.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDCreation)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines to Load Control Values from Database"


    Sub sbLoadControlValues()
        'to load database values to form controls
        sbLoadOccupation()
        sbLoadReligion()
        sbLoadCaste()
        sbLoadScheme()
    End Sub


    'To load OccupationTbl values to the Occupation ComboBox control
    Sub sbLoadOccupation()
        Dim objOccupation As New clsOccupation
        If objOccupation.fnGetOccupations Then
            cmbOccupation.DataSource = objOccupation.OccupationTable
            cmbOccupation.DisplayMember = "OccupationName"
            cmbOccupation.ValueMember = "OccupationCode"
        End If
        objOccupation = Nothing
    End Sub


    'To load ReligionTbl values to the Religion ComboBox control
    Sub sbLoadReligion()
        Dim objReligion As New clsReligion
        If objReligion.fnGetReligions Then
            cmbReligion.DataSource = objReligion.ReligionTable
            cmbReligion.DisplayMember = "ReligionName"
            cmbReligion.ValueMember = "ReligionCode"
        End If
        objReligion = Nothing
    End Sub


    'To load CasteTbl values to the Caste ComboBox control
    Sub sbLoadCaste()
        Dim objCaste As New clsCaste
        If objCaste.fnGetCastes Then
            cmbCaste.DataSource = objCaste.CasteTable
            cmbCaste.DisplayMember = "CasteName"
            cmbCaste.ValueMember = "CasteCode"
        End If
        objCaste = Nothing
    End Sub

    'To load SchemeTbl values to the Scheme ComboBox Control
    Sub sbLoadScheme()
        Dim objScheme As New clsFDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.FdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
            cmbSchemeType.SelectedIndex = -1
        End If
        objScheme = Nothing
    End Sub

#End Region

#Region "Sub Routines and Functions"

    ''To load FD Detailst
    Sub sbLoadFD()
        Dim msStream As MemoryStream
        Dim objDT As DataTable
        Dim objIntTable As DataTable
        Try
            If objFDAccount.fnGetFDDetails(txtFDAccountNo.Text) Then
                sbClear()
                objDT = objFDAccount.FDTable

                txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")

                'Preson Detail
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                txtCustomerID.Enabled = False
                txtName.Text = objDT.Rows(0).Item("Name")

                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")

                If objDT.Rows(0).Item("Gender") = "M" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If

                If objDT.Rows(0).Item("AgeStatus") = "M" Then
                    rdbMajor.Checked = True
                Else
                    rdbMinor.Checked = True
                End If

                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")

                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        picPhoto.Image = Image.FromStream(msStream)
                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        picSignature.Image = Image.FromStream(msStream)
                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                btnSearchMember.Enabled = False
                btnNewMember.Enabled = False
                grpFDType.Enabled = False
                grpFDDetails.Enabled = False


                Select Case objDT.Rows(0).Item("AccType").ToString
                    Case "S" : cmbAccountType.SelectedItem = "Single"
                    Case "J" : cmbAccountType.SelectedItem = "Joint"
                End Select

                Select Case objDT.Rows(0).Item("OpMode").ToString
                    Case "E" : cmbOpMode.SelectedItem = "Either"
                    Case "S" : cmbOpMode.SelectedItem = "Either or Survivor"
                    Case "B" : cmbOpMode.SelectedItem = "Both"
                End Select

                txtIntroNo.Text = objDT.Rows(0).Item("IntroName")
                txtAccNo.Text = objDT.Rows(0).Item("AccountNo")

                If objDT.Rows(0).Item("TransferedAmt") = "Y" Then
                    txtTransFund.Text = objDT.Rows(0).Item("FDAmount")
                    'chkFundTransfer.Checked = True
                    Panel3.Enabled = False
                End If
                chkFundTransfer.Enabled = False

                cmbSchemeType.SelectedValue = objDT.Rows(0).Item("SchemeCode")

                Select Case objDT.Rows(0).Item("IntMode").ToString
                    Case "M" : cmbFDType.SelectedItem = "Monthly"
                    Case "Q" : cmbFDType.SelectedItem = "Quarterly"
                    Case "H" : cmbFDType.SelectedItem = "Half-Yearly"
                    Case "Y" : cmbFDType.SelectedItem = "Yearly"
                    Case "C" : cmbFDType.SelectedItem = "Closure Date"
                End Select

                Select Case objDT.Rows(0).Item("PostingPeriod").ToString
                    Case "P" : cmbPeriod.SelectedItem = "As Scheme Period"
                    Case "E" : cmbPeriod.SelectedItem = "At the end"
                End Select

                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")
                txtBondNo.Text = objDT.Rows(0).Item("BondNo")
                dtpFDDate.Value = objDT.Rows(0).Item("FDDate")
                txtFDYears.Text = objDT.Rows(0).Item("Years")
                txtFDMonths.Text = objDT.Rows(0).Item("Months")
                txtFDDays.Text = objDT.Rows(0).Item("Days")
                txtFDAmount.Text = objDT.Rows(0).Item("FDAmount")
                txtFDROI.Text = objDT.Rows(0).Item("FDROI")
                txtFDIntAmount.Text = objDT.Rows(0).Item("IntAmount")
                txtFDMatAmount.Text = objDT.Rows(0).Item("MatAmount")
                dtpFDMatDate.Value = objDT.Rows(0).Item("MatDate")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")

                If objDT.Rows(0).Item("Correction") = "Y" Then
                    chkCorrection.Checked = True
                    If objDT.Rows(0).Item("CType") = "A" Then
                        chkAdd.Checked = True
                    ElseIf objDT.Rows(0).Item("CType") = "S" Then
                        chkSubtract.Checked = True
                    End If
                    txtCorrectionAmount.Text = objDT.Rows(0).Item("CAmount")
                End If


                If Not objFDAccount.InterestTable Is Nothing Then
                    objIntTable = objFDAccount.InterestTable
                    Dim intCounter As Integer = 0
                    Dim lvItem As ListViewItem
                    Dim dblSumInterest As Double = 0

                    lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                    lvInterest.Columns.Add("Renewal", 100, HorizontalAlignment.Left)
                    lvInterest.Items.Clear()
                    If lvInterest.Columns.Count > 6 Then
                        lvInterest.Columns.RemoveAt(6)
                    End If

                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        dblSumInterest += objIntTable.Rows(intCounter).Item("IntAmount")
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                        'lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        lvItem.SubItems.Add(dblSumInterest)
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                        If Convert.ToString(objIntTable.Rows(intCounter).Item("Renewal")) = "" Then
                            lvItem.SubItems.Add("No")
                        Else
                            lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Renewal"))
                        End If
                        intCounter += 1
                    End While
                End If
                txtFDAccountNo.ReadOnly = True
                txtFDAccountNo.Enabled = False
                cmbDepositType.Enabled = False
            End If
        Catch ex As Exception
        End Try

    End Sub

    Sub sbLoadCustomer()

        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If (objPerson.fnGetCustomerID(txtCustomerID.Text)) Then

                objDT = objPerson.PersonTable

                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtName.Text = objDT.Rows(0).Item("Name")

                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")

                strEducation = objDT.Rows(0).Item("Education")
                strOffAddress = objDT.Rows(0).Item("OfficeAddress")
                strOfficeNo = objDT.Rows(0).Item("OfficeNo")

                If objDT.Rows(0).Item("Gender") = "M" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If

                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")

                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")


                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        ' msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        ' msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        'picPhoto.Image = Image.FromStream(msStream)



                        picPhoto.Image = Image.FromFile(objDT.Rows(0).Item("Photo"))
                        picPhoto.ImageLocation = objDT.Rows(0).Item("Photo")


                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        'msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        '  msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        ' msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        '  picSignature.Image = Image.FromStream(msStream)

                        picSignature.Image = Image.FromFile(objDT.Rows(0).Item("Signature"))
                        picSignature.ImageLocation = objDT.Rows(0).Item("Signature")


                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                        ' msStream.Close()
                    End If
                End If

                txtCustomerID.Enabled = False
                txtName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub
    'To Load SB Account Balance Detail

    Sub sbloaddetails()

        Dim strType As String
        strType = Mid(txtAccNo.Text, 1, 2)
        Select Case strType
            Case "SB"
                If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
                    dblAvalAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    Label42.Text = "SB No. :"
                    lblAType.Text = "Amt From SB "
                Else
                    MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                    txtAccNo.SelectAll()
                End If
            Case "CA"
                If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) Then
                    dblAvalAmount = objCA.CAAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    Label42.Text = "CA No. :"
                    lblAType.Text = "Amt From CA "
                Else
                    MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                    txtAccNo.SelectAll()
                End If



        End Select


    End Sub

    'To Calculate CA intrest if Balance is less than or equal to zero 
    Function fnCalcInterest() As Boolean
        Dim ROI As Double
        Dim intNOD As Integer
        dblCalIntrest = 0
        Dim intInterestDiff As Integer
        Dim dblAmount As Double = lblAvalBal.Text

        If Trim(lblAvalBal.Text < 0) Then
            Dim datLastPaid As Date = CDate(objCurrentAccount.CAAccTable.Rows(0).Item("LastPaidDate"))
            If objCurrentAccount.fnGetCAMasterData Then
                ROI = objCurrentAccount.CAMasterTable.Rows(0).Item("CAROI")
            End If
            intInterestDiff = DateDiff(DateInterval.Day, datLastPaid, dtpFDDate.Value)
            If intInterestDiff > 0 Then
                dblCalIntrest = Math.Round(((Abs(dblAmount) * intInterestDiff * (ROI / 100)) / 365), 2)
                objCurrentAccount.IntAmt = dblCalIntrest
            End If
        End If
        Return True

    End Function

    'To clear Personal details 
    Sub sbClearPersonal()
        lngPersonNo = 0
        txtCustomerID.ResetText()
        txtCustomerID.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpDOB.ResetText()
        rdbMale.Checked = True
        rdbMajor.Checked = True
        txtAge.ResetText()
        cmbReligion.SelectedIndex = -1
        cmbCaste.SelectedIndex = -1
        cmbOccupation.SelectedIndex = -1
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        txtIntroNo.ResetText()

    End Sub

    'To clear form control values
    Sub sbClear()

        sbClearPersonal()

        btnSearchMember.Enabled = True
        btnNewMember.Enabled = True
        cmbDepositType.Enabled = True

        cmbAccountType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        grpFDType.Enabled = True
        grpFDDetails.Enabled = True
        cmbFDType.SelectedIndex = -1
        txtAccNo.ResetText()
        txtReceiptNo.ResetText()
        txtFDAmount.ResetText()
        txtFDIntAmount.ResetText()
        txtFDROI.ResetText()
        txtFDMatAmount.ResetText()
        txtFDYears.ResetText()
        txtFDMonths.ResetText()
        txtFDDays.ResetText()
        dtpFDMatDate.ResetText()
        txtReceiptNo.ResetText()
        txtBondNo.ResetText()

        If lvInterest.Columns.Count > 4 Then
            lvInterest.Columns.RemoveAt(4)
        End If
        lvInterest.Items.Clear()

        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtRemarks.ResetText()
        Panel2.Enabled = False

        chkFundTransfer.Checked = False
        chkFundTransfer.Enabled = True
        lblAvalBal.ResetText()
        txtTransFund.ResetText()
        txtFDAccountNo.Enabled = True
        cmbSchemeType.SelectedIndex = -1
        btnSBSearch.Enabled = True
        lblAType.Text = "Amount"
        txtFDAccountNo.ReadOnly = False
        cmbPeriod.SelectedIndex = -1

        chkAdd.Checked = False
        chkSubtract.Checked = False
        chkCorrection.Checked = False
        txtCorrectionAmount.ResetText()
        txtCInterest.ResetText()

    End Sub

    'To check data entered by the User, function called when "OK" button is clicked 
    Function fnCheck() As Boolean


        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
            Return False
        ElseIf txtFDAccountNo.Text = "FD" Or txtFDAccountNo.Text = "ENNVY" Or txtFDAccountNo.Text = "SCC" Then
            MsgBox("Enter account no.", MsgBoxStyle.Information)
            txtFDAccountNo.Focus()
            Return False
        ElseIf txtName.Text = "" Then
            MsgBox("Enter name ", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf txtFatherName.Text = "" Then
            MsgBox("Enter father name ", MsgBoxStyle.Information)
            txtFatherName.Focus()
            Return False
        ElseIf Val(txtAge.Text) = 0 Then
            MsgBox("Enter age ", MsgBoxStyle.Information)
            txtAge.Focus()
            Return False
        ElseIf cmbAccountType.SelectedItem = "" Then
            MsgBox("Please select type of account", MsgBoxStyle.Exclamation, "Deposit Module")
            cmbAccountType.Focus()
            Return False
        ElseIf cmbOpMode.SelectedItem = "" Then
            MsgBox("Please select mode of operation", MsgBoxStyle.Exclamation, "Deposit Module")
            cmbOpMode.Focus()
            Return False
        ElseIf chkFundTransfer.Checked = True And Val(txtTransFund.Text) = 0 Then
            MsgBox("Please enter the transferting amount from SB", MsgBoxStyle.Exclamation, "Deposit Module")
            txtTransFund.Focus()
            Return False
        ElseIf txtPermAddress.Text = "" Then
            MsgBox("Enter address", MsgBoxStyle.Information)
            txtPermAddress.Focus()
            Return False
        ElseIf fnCheckFDDetails() = False Then
            Return False
        ElseIf Val(txtFDIntAmount.Text) = 0 Or lvInterest.Items.Count = 0 Then
            MsgBox("Run calculate", MsgBoxStyle.Information)
            btnCalculate.Focus()
            Return False
        ElseIf txtReceiptNo.Text = "" Then
            MsgBox("Enter receipt no.", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
        ElseIf txtBondNo.Text = String.Empty Then
            MsgBox("Please enter bond no.", MsgBoxStyle.Exclamation, "Deposit Module")
            txtBondNo.Focus()
            Return False
        ElseIf objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) = False And fnReceiptCheckNo(txtReceiptNo.Text, dtpFDDate.Value) = True Then
            MsgBox("Receipt no already exists. Enter correct receipt no.", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'To set form control values to Class Properties, function called when "OK" button is clicked

    Function fnSetData() As Boolean
        Dim intCounter As Integer = 0
        Dim dtRow As DataRow
        Try
            If lngPersonNo <> 0 Then
                objFDAccount.PersonNo = lngPersonNo
            Else
                objFDAccount.PersonNo = objFDAccount.fnGetNewPersonNo()
            End If
            objFDAccount.Name = txtName.Text
            objFDAccount.CustomerID = txtCustomerID.Text
            objFDAccount.SBNo = txtAccNo.Text
            objFDAccount.FatherName = txtFatherName.Text
            objFDAccount.PermAddress = txtPermAddress.Text
            objFDAccount.PresAddress = txtPresAddress.Text
            objFDAccount.PhoneNo = txtPhoneNo.Text
            objFDAccount.MobileNo = txtMobileNo.Text
            objFDAccount.DOB = dtpDOB.Value
            objFDAccount.Age = txtAge.Text
            objFDAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
            objFDAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
            objFDAccount.ReligionCode = cmbReligion.SelectedValue
            objFDAccount.CasteCode = cmbCaste.SelectedValue
            objFDAccount.OccupationCode = cmbOccupation.SelectedValue
            'objFDAccount.Photo = fnGetPhoto()
            objFDAccount.Photo = picPhoto.ImageLocation
            'objFDAccount.Sign = fnGetSign()
            objFDAccount.Sign = picSignature.ImageLocation
            objFDAccount.OfficeNo = strOfficeNo
            objFDAccount.OffAddress = strOffAddress
            objFDAccount.Education = strEducation

            'objFDAccount.MemberNo = txtMemberNo.Text
            'objFDAccount.SBNo = txtSBNo.Text
            objFDAccount.FDNo = txtFDAccountNo.Text

            If cmbAccountType.SelectedItem = "Single" Then
                objFDAccount.AccountType = "S"
            ElseIf cmbAccountType.SelectedItem = "Joint" Then
                objFDAccount.AccountType = "J"
            End If

            If cmbOpMode.SelectedItem = "Either" Then
                objFDAccount.OpMode = "E"
            ElseIf cmbOpMode.SelectedItem = "Either or Survivor" Then
                objFDAccount.OpMode = "S"
            ElseIf cmbOpMode.SelectedItem = "Both" Then
                objFDAccount.OpMode = "B"
            End If

            objFDAccount.IntroName = txtIntroNo.Text
            objFDAccount.SchemeCode = cmbSchemeType.SelectedValue


            If cmbFDType.SelectedItem = "Monthly" Then
                objFDAccount.IntMode = "M"
            ElseIf cmbFDType.SelectedItem = "Quarterly" Then
                objFDAccount.IntMode = "Q"
            ElseIf cmbFDType.SelectedItem = "Half-Yearly" Then
                objFDAccount.IntMode = "H"
            ElseIf cmbFDType.SelectedItem = "Yearly" Then
                objFDAccount.IntMode = "Y"
            End If

            If chkFundTransfer.Checked = True Then
                objFDAccount.ChTransferAmount = "Y"
            Else
                objFDAccount.ChTransferAmount = "N"
            End If

            If cmbPeriod.SelectedItem = "At the end" Then
                objFDAccount.chPostingPeriod = "E"
            ElseIf cmbPeriod.SelectedItem = "As Scheme Period" Then
                objFDAccount.chPostingPeriod = "P"
            End If

            Select Case cmbDepositType.SelectedItem
                Case "FD"
                    intLedgerNo = 27
                Case "ENNVY"
                    intLedgerNo = 53
                Case "SCC"
                    intLedgerNo = 54
            End Select


            If chkCorrection.Checked = True Then
                objFDAccount.Correction = "Y"
            Else
                objFDAccount.Correction = "N"
            End If

            If chkAdd.Checked = True Then
                objFDAccount.CorrectioType = "A"
            ElseIf chkSubtract.Checked = True Then
                objFDAccount.CorrectioType = "S"
            Else
                objFDAccount.CorrectioType = "N"
            End If

            objFDAccount.CAmount = Val(txtCorrectionAmount.Text)
            objFDAccount.TransferAccNo = txtTransferAccount.Text

            objFDAccount.FDDate = dtpFDDate.Value
            objFDAccount.FDAmount = Val(txtFDAmount.Text)
            objFDAccount.FDYears = Val(txtFDYears.Text)
            objFDAccount.FDMonths = Val(txtFDMonths.Text)
            objFDAccount.FDDays = Val(txtFDDays.Text)
            objFDAccount.FDROI = Val(txtFDROI.Text)
            objFDAccount.IntAmount = Val(txtFDIntAmount.Text)
            objFDAccount.MatAmount = Val(txtFDMatAmount.Text)
            objFDAccount.MatDate = dtpFDMatDate.Value

            dtInterest.Rows.Clear()
            While intCounter < lvInterest.Items.Count
                dtRow = dtInterest.NewRow
                dtRow.Item("SlNo") = lvInterest.Items(intCounter).SubItems(0).Text
                dtRow.Item("IntAmount") = lvInterest.Items(intCounter).SubItems(1).Text
                dtRow.Item("IntDate") = lvInterest.Items(intCounter).SubItems(2).Text
                dtRow.Item("TotalAmount") = lvInterest.Items(intCounter).SubItems(3).Text
                dtInterest.Rows.Add(dtRow)
                intCounter += 1
            End While
            objFDAccount.InterestTable = dtInterest
            objFDAccount.VoucherNo = fnVoucherGetNewVNo(dtpFDDate.Value)
            objFDAccount.ReceiptNo = txtReceiptNo.Text
            objFDAccount.BondNo = txtBondNo.Text
            objFDAccount.Status = "Active"
            objFDAccount.Remarks = txtRemarks.Text

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'To SAVE data to table, ADD or UPDATE data
    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for FD Account Existance
        If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) = False Then

            'ADD new FD Account  (ADD Mode)
            If objFDAccount.fnAddFDAccount(objTrans) Then
                fnGenerateVoucher(objTrans)
                'fnGenerateReceipt()
                fnLogEntry(pbUserId, "New deposit created " & txtFDAccountNo.Text, Date.Now, "New Deposit", objTrans)
                MessageBox.Show("New account added successfully.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New account addition failed, because of internal error.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else

            'Update Details (EDIT Mode)
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                If objFDAccount.fnUpdateFDAccount(objTrans) Then
                    fnLogEntry(pbUserId, "Account Updated " & txtFDAccountNo.Text, Date.Now, "Update Deposit", objTrans)
                    MessageBox.Show("Account updated successfully.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Return True
                Else
                    MessageBox.Show("Account updation failed, because of internal error.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Return False
                End If
            Else
                MsgBox("Can not update,account is already closed", MsgBoxStyle.Information)
                Return False
            End If

        End If

    End Function

    'To get Byte array for Photo object, function called while setting values to the Class Properties
    Function fnGetPhoto() As Byte()
        Try
            If Not picPhoto.Image Is Nothing Then
                Dim msStream As New MemoryStream
                Dim bytArr() As Byte
                picPhoto.Image.Save(msStream, picPhoto.Image.RawFormat)
                bytArr = msStream.GetBuffer
                msStream.Close()
                Return bytArr
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'To get Byte array for Signature object, function called while setting values to the Class Properties
    Function fnGetSign() As Byte()
        Try
            If Not picSignature.Image Is Nothing Then
                Dim msStream As New MemoryStream
                Dim bytArr() As Byte
                picSignature.Image.Save(msStream, picSignature.Image.RawFormat)
                bytArr = msStream.GetBuffer
                msStream.Close()
                Return bytArr
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'to calculate 'MATURITY DATE' depending on the 'FD DATE' and 'PERIOD'
    Sub sbCalcMatDate()
        dtpFDMatDate.Value = DateAdd(DateInterval.Year, Val(txtFDYears.Text), dtpFDDate.Value)
        dtpFDMatDate.Value = DateAdd(DateInterval.Month, Val(txtFDMonths.Text), dtpFDMatDate.Value)
        dtpFDMatDate.Value = DateAdd(DateInterval.Day, Val(txtFDDays.Text), dtpFDMatDate.Value)
        'If Val(txtFDDays.Text) = 0 Then
        '    dtpFDMatDate.Value = DateAdd(DateInterval.Day, 1, dtpFDMatDate.Value)
        'End If

    End Sub

    Function fnCheckFDDetails() As Boolean
        If cmbFDType.SelectedIndex = -1 Then
            MsgBox("Select interest mode", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
            cmbFDType.Focus()
        ElseIf (Val(txtFDYears.Text) = 0 And Val(txtFDMonths.Text) = 0 And Val(txtFDDays.Text) = 0) Then
            MsgBox("Please enter period of deposit", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
            txtFDYears.Focus()
        ElseIf cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select interest posting type", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            cmbPeriod.Focus()
        ElseIf Val(txtFDAmount.Text) <= 0 Or txtFDAmount.Text = "" Then
            MsgBox("Amount should not be zero", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
        ElseIf Val(txtFDROI.Text) = 0 Then
            MsgBox("Please enter FD ROI", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
            txtFDROI.Focus()
        Else
            fnCheckFDDetails = True
        End If
    End Function

    'To enter details into Receipt table 
    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptNo.Text, txtName.Text, dtpFDDate.Value, txtFDAmount.Text, "")

        'Receipt sub details
        fnReceiptEnterSub(txtReceiptNo.Text, dtpFDDate.Value, "Fixed Deposit", txtFDAmount.Text, 1)

        Return True

    End Function

    'To enter Voucher details
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngvoucherno As Long
        Dim lngslno As Long
        lngvoucherno = fnVoucherGetNewVNo(dtpFDDate.Value)
        lngslno = fnVoucherGetNewSlNo()

        If chkFundTransfer.Checked = True And txtTransFund.Text <> String.Empty Then

            Dim strnarration As String = "Transfered to " & txtFDAccountNo.Text

            Dim strType As String = Mid(Trim(txtAccNo.Text), 1, 2)

            Select Case strType

                Case "SB"

                    'transaction entry
                    'Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,bookdeposit,bookwithdraw,postbal,refno,voucherno,type,chequeno) "
                    'strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpFDDate.Value, "yyyy-mm-dd:hh:mm:ss") & "','" & strnarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngvoucherno & "','cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by accountno"
                    'fnExecuteNonQuery(strsql, objTrans)

                    Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpFDDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strnarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngvoucherno & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)


                    ''voucher details
                    fnVoucherEnterMain(lngvoucherno, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, " Transfered by " & txtAccNo.Text, lngslno, "y", objTrans)

                    ''credit accounts - fixed deposit account
                    fnVoucherEnterSub(lngvoucherno, 7, txtFDAccountNo.Text, dtpFDDate.Value, "Cash recived from account " & txtAccNo.Text & " by " & txtFDAccountNo.Text, "To", intLedgerNo, 0, Val(txtFDAmount.Text), 1, "y", objTrans)

                    ''debit accounts 
                    fnVoucherEnterSub(lngvoucherno, 7, txtAccNo.Text, dtpFDDate.Value, "Cash transfered to account " & txtFDAccountNo.Text & " by " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "y", objTrans)

                Case "CA"

                    'transaction entry
                    Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpFDDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strnarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','0.00','" & Trim(txtReceiptNo.Text) & "','" & lngvoucherno & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    ''voucher details
                    fnVoucherEnterMain(lngvoucherno, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, " Transfered by " & txtAccNo.Text, lngslno, "y", objTrans)

                    ''credit accounts - fixed deposit account
                    fnVoucherEnterSub(lngvoucherno, 7, txtFDAccountNo.Text, dtpFDDate.Value, "Cash recived from account " & txtAccNo.Text & " by " & txtFDAccountNo.Text, "To", intLedgerNo, 0, Val(txtFDAmount.Text), 1, "y", objTrans)

                    ''debit accounts 
                    fnVoucherEnterSub(lngvoucherno, 7, txtAccNo.Text, dtpFDDate.Value, "Cash transfered to account " & txtFDAccountNo.Text & " by " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 2, "y", objTrans)

            End Select

        Else

            ''voucher details
            fnVoucherEnterMain(lngvoucherno, 2, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, " By new account " & txtFDAccountNo.Text, lngslno, "y", objTrans)

            ''credit accounts - fixed deposit account
            fnVoucherEnterSub(lngvoucherno, 2, txtFDAccountNo.Text, dtpFDDate.Value, "By account " & txtFDAccountNo.Text, "to", intLedgerNo, 0, Val(txtFDAmount.Text), 1, "y", objTrans)

            ''debit accounts - cash account
            fnVoucherEnterSub(lngvoucherno, 2, "", dtpFDDate.Value, "By account " & txtFDAccountNo.Text, "by", 1, Val(txtFDAmount.Text), 0, 2, "y", objTrans)

        End If

        Return True

    End Function

    Sub fnGetNextdate()
        timeTemp = timeTemp.AddMonths(1)
        timeTemp = timeTemp.AddDays(-(timeTemp.Day))
        timeTemp = timeTemp.AddMonths(1)
    End Sub
#End Region

#Region "events"

    Function funCalculateQDays(ByVal MON As Integer)

        TempSubdays = 0
        TempSubMonth = 0

        TempTotalDays = 0
        bolTemp = True

        If timeTemp.Month <> MON Then
            While timeTemp.Month <> MON
                timeTemp = timeTemp.AddMonths(1)
                timeTemp = timeTemp.AddDays(-(timeTemp.Day))
                If bolTemp = True Then
                    TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                    TempSubdays += 1
                    bolTemp = False
                End If
                TempSubMonth += 1
                timeTemp = timeTemp.AddMonths(1)
            End While
            timeTemp = timeTemp.AddMonths(1)
            timeTemp = timeTemp.AddDays(-(timeTemp.Day))
            If bolMonth = False Then
                TempTotalDays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                TempTotalDays += 1
                TempTotalDays -= TempSubdays
                tempNOM = 1
            End If
        ElseIf timeTemp.Month = MON Then
            While timeTemp.Month = MON
                timeTemp = timeTemp.AddMonths(1)
                timeTemp = timeTemp.AddDays(-(timeTemp.Day))
                TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                TempSubdays += 1
                tempNOM = 2
                TempSubMonth += 1
                timeTemp = timeTemp.AddMonths(1)
            End While
            timeTemp = timeTemp.AddDays(-(timeTemp.Day))
            'timeTemp = timeTemp.AddMonths(-1)
        End If

    End Function

#Region "'Working fine with calender quater"

    'Function FnCalInterest()

    '    Dim intNOM As Integer = 0
    '    Dim intNOD As Integer = 0
    '    Dim dblFDAmount As Double
    '    Dim dblIntAmt As Double = 0
    '    Dim dblTotalInt As Double = 0
    '    Dim dblROI As Double = 0
    '    Dim intCounter1 As Integer = 0
    '    Dim intCounter As Integer = 0
    '    Dim lngPeriod As Double = 0
    '    Dim intIntMode As Integer = 0
    '    Dim iv As ListViewItem
    '    Dim dblFDAmt As Double = 0

    '    Dim datNextDate As Date
    '    Dim intDivide As Integer
    '    Dim datMatdate As Date
    '    Dim intQuater As Integer = 0

    '    TempSubdays = 0
    '    TempSubMonth = 0
    '    TempTotalDays = 0
    '    bolTemp = True

    '    '''''''''''
    '    Dim tempMonth As Integer
    '    Dim temp As Integer = 0
    '    timeTemp = dtpFDDate.Value
    '    Dim tempDayAmount As Double = 0

    '    Dim FQuater() As Integer
    '    FQuater = New Integer() {"1", "2", "3"}
    '    Dim SQuater() As Integer
    '    SQuater = New Integer() {"4", "5", "6"}
    '    Dim TQuater() As Integer
    '    TQuater = New Integer() {"7", "8", "9"}
    '    Dim FoQuater() As Integer
    '    FoQuater = New Integer() {"10", "11", "12"}


    '    datFDDate = CDate(dtpFDDate.Value)
    '    lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)

    '    datMatdate = CDate(dtpFDMatDate.Value)

    '    If fnCheckFDDetails() = True Then

    '        Try
    '            dblFDAmount = CDbl(txtFDAmount.Text)
    '            dblFDAmt = CDbl(txtFDAmount.Text)
    '            dblROI = Val(txtFDROI.Text)
    '            intNOM = Val(txtFDMonths.Text)
    '            intNOM += (Val(txtFDYears.Text) * 12)
    '            intCounter = 1
    '            lvInterest.Items.Clear()

    '            If bolCumulative = True Then
    '                Select Case cmbFDType.SelectedItem.ToString
    '                    Case "Monthly"
    '                        intIntMode = 1
    '                    Case "Quarterly"
    '                        intIntMode = 3
    '                    Case "Half-Yearly"
    '                        intIntMode = 6
    '                    Case "Yearly"
    '                        intIntMode = 12
    '                End Select

    '                If intIntMode = 3 Then
    '                    If datFDDate.Month >= FQuater(0) And datFDDate.Month <= FQuater(2) Then
    '                        funCalculateQDays(3)
    '                    ElseIf datFDDate.Month >= SQuater(0) And datFDDate.Month <= SQuater(2) Then
    '                        funCalculateQDays(6)
    '                    ElseIf datFDDate.Month >= TQuater(0) And datFDDate.Month <= TQuater(2) Then
    '                        funCalculateQDays(9)
    '                    ElseIf datFDDate.Month >= FoQuater(0) And datFDDate.Month <= FoQuater(2) Then
    '                        funCalculateQDays(12)
    '                    End If
    '                    datNextDate = timeTemp
    '                    intNOM = intNOM - TempSubMonth
    '                ElseIf intIntMode = 6 Then
    '                    If datFDDate.Month >= FQuater(0) And datFDDate.Month <= SQuater(2) Then
    '                        funCalculateQDays(6)
    '                    ElseIf datFDDate.Month >= TQuater(0) And datFDDate.Month <= FoQuater(2) Then
    '                        funCalculateQDays(12)
    '                    End If
    '                    datNextDate = timeTemp
    '                    intNOM = intNOM - TempSubMonth
    '                ElseIf intIntMode = 12 Then
    '                    funCalculateQDays(12)
    '                    datNextDate = timeTemp
    '                    intNOM = intNOM - TempSubMonth
    '                Else
    '                    timeTemp = timeTemp.AddMonths(1)
    '                    timeTemp = timeTemp.AddDays(-(timeTemp.Day))
    '                    TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
    '                    TempSubMonth += 1
    '                    datNextDate = timeTemp
    '                    tempNOM = 2
    '                    intNOM = intNOM - TempSubMonth
    '                End If

    '                If bolMonth = True Then
    '                    If intIntMode <> 1 Then
    '                        tempDayAmount = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                        If TempSubMonth > 0 Then
    '                            dblIntAmt = Round((dblFDAmount * TempSubMonth * dblROI) / (100 * 12), 2)
    '                        End If
    '                        dblIntAmt += tempDayAmount
    '                    Else
    '                        dblIntAmt = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                    End If
    '                Else
    '                    If intIntMode <> 1 Then
    '                        tempDayAmount = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                        If TempSubMonth > 0 Then
    '                            dblIntAmt = Round((dblFDAmount * TempTotalDays * dblROI) / (100 * 365), 2)
    '                        End If
    '                        dblIntAmt += tempDayAmount
    '                    Else
    '                        dblIntAmt = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                    End If
    '                End If

    '                dblTotalInt += Math.Round(dblIntAmt)

    '                If dblIntAmt > 0 Then
    '                    iv = lvInterest.Items.Add(intCounter1 + 1)
    '                    iv.SubItems.Add(Math.Round(dblIntAmt))
    '                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
    '                    iv.SubItems.Add(Math.Round(dblIntAmt) + Math.Round(dblFDAmount))
    '                    dblFDAmount += Math.Round(dblIntAmt)
    '                    datFDDate = timeTemp
    '                    intCounter1 += 1
    '                End If

    '                While (intNOM / intIntMode) >= intCounter
    '                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
    '                    datNextDate = datNextDate.AddMonths(1)
    '                    datNextDate = datNextDate.AddDays(-(datNextDate.Day))

    '                    If bolMonth = True Then
    '                        Dim intNOMonths As Integer = Val(datNextDate)
    '                        dblIntAmt = Round((dblFDAmount * intIntMode * dblROI) / (100 * 12), 2)
    '                    Else
    '                        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
    '                        dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
    '                    End If
    '                    iv = lvInterest.Items.Add(intCounter + 1)
    '                    iv.SubItems.Add(Math.Round(dblIntAmt))
    '                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
    '                    iv.SubItems.Add(Math.Round(dblIntAmt) + Math.Round(dblFDAmount))
    '                    dblFDAmount += Math.Round(dblIntAmt)
    '                    datFDDate = datNextDate
    '                    dblTotalInt += Math.Round(dblIntAmt)
    '                    intCounter += 1
    '                End While

    '                intNOM = intNOM Mod intIntMode    'remaining no of months
    '                If bolMonth Then
    '                    tempDayAmount = Round((dblFDAmount * intNOM * dblROI) / (100 * 12), 2)
    '                    timeTemp = datNextDate
    '                    timeTemp = timeTemp.AddMonths(1)
    '                    intNOD = DateDiff(DateInterval.Day, datNextDate, timeTemp) 'days for remaining months
    '                    intNOD = intNOD - TempSubdays + 1
    '                    intNOD += Val(txtFDDays.Text)   'total remaining days

    '                    dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
    '                    dblIntAmt += tempDayAmount
    '                    dblTotalInt += Math.Round(dblIntAmt)
    '                Else
    '                    datNextDate = datFDDate.AddMonths(intNOM + tempNOM)
    '                    datNextDate = datNextDate.AddDays(-(datNextDate.Day))
    '                    If datNextDate > dtpFDMatDate.Value Then
    '                        datNextDate = dtpFDMatDate.Value
    '                    End If
    '                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate) 'days for remaining months
    '                    'intNOD = intNOD - TempSubdays
    '                    If datNextDate <> dtpFDMatDate.Value Then
    '                        If TempSubdays <= intNOD Then
    '                            intNOD = intNOD - TempSubdays
    '                            intNOD += Val(txtFDDays.Text)   'total remaining days
    '                        End If
    '                    End If
    '                    'intNOD += Val(txtFDDays.Text)   'total remaining days
    '                    dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
    '                    dblTotalInt += Math.Round(dblIntAmt)

    '                End If

    '                If dblIntAmt > 0 Then
    '                    iv = lvInterest.Items.Add(intCounter + 1)
    '                    iv.SubItems.Add(Math.Round(dblIntAmt))
    '                    iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
    '                    iv.SubItems.Add(Math.Round(dblIntAmt) + Math.Round(dblFDAmount))
    '                    dblFDAmount += Math.Round(dblIntAmt)
    '                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
    '                    intCounter += 1
    '                End If


    '            Else            'for NON-CUMULATIVE 

    '                Select Case cmbFDType.SelectedItem.ToString
    '                    Case "Monthly"
    '                        intIntMode = 1
    '                    Case "Quarterly"
    '                        intIntMode = 3
    '                    Case "Half-Yearly"
    '                        intIntMode = 6
    '                    Case "Yearly"
    '                        intIntMode = 12
    '                End Select

    '                If intIntMode = 3 Then
    '                    If datFDDate.Month = FQuater(0) Or datFDDate.Month = FQuater(1) Or datFDDate.Month = FQuater(2) Then
    '                        funCalculateQDays(3)
    '                    ElseIf datFDDate.Month = SQuater(0) Or datFDDate.Month = SQuater(1) Or datFDDate.Month = SQuater(2) Then
    '                        funCalculateQDays(6)
    '                    ElseIf datFDDate.Month = TQuater(0) Or datFDDate.Month = TQuater(1) Or datFDDate.Month = TQuater(2) Then
    '                        funCalculateQDays(9)
    '                    ElseIf datFDDate.Month = FoQuater(0) Or datFDDate.Month = FoQuater(1) Or datFDDate.Month = FoQuater(2) Then
    '                        funCalculateQDays(12)
    '                    End If

    '                ElseIf intIntMode = 6 Then
    '                    If datFDDate.Month >= FQuater(0) And datFDDate.Month <= SQuater(2) Then
    '                        funCalculateQDays(6)
    '                    ElseIf datFDDate.Month >= TQuater(0) And datFDDate.Month <= FoQuater(2) Then
    '                        funCalculateQDays(12)
    '                    End If

    '                ElseIf intIntMode = 12 Then
    '                    funCalculateQDays(12)
    '                    datNextDate = timeTemp
    '                    intNOM = intNOM - TempSubMonth
    '                Else
    '                    timeTemp = timeTemp.AddMonths(1)
    '                    timeTemp = timeTemp.AddDays(-(timeTemp.Day))
    '                    TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
    '                    TempSubMonth += 1
    '                    tempNOM = 2

    '                End If
    '                datNextDate = timeTemp
    '                intNOM = intNOM - TempSubMonth
    '                If bolMonth = True Then
    '                    If intIntMode = 3 Then
    '                        tempDayAmount = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                        If TempSubMonth - 1 > 0 Then
    '                            dblIntAmt = Round((dblFDAmount * TempSubMonth * dblROI) / (100 * 12), 2)
    '                        End If
    '                        dblIntAmt += tempDayAmount
    '                    Else
    '                        dblIntAmt = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                    End If

    '                Else
    '                    If intIntMode = 3 Then
    '                        tempDayAmount = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                        If TempSubMonth > 0 Then
    '                            dblIntAmt = Round((dblFDAmount * TempTotalDays * dblROI) / (100 * 365), 2)
    '                        End If
    '                        dblIntAmt += tempDayAmount
    '                    Else
    '                        dblIntAmt = Round((dblFDAmount * TempSubdays * dblROI) / (100 * 365), 2)
    '                    End If

    '                End If

    '                dblTotalInt += Math.Round(dblIntAmt)

    '                If dblIntAmt > 0 Then
    '                    iv = lvInterest.Items.Add(intCounter1 + 1)
    '                    iv.SubItems.Add(Math.Round(dblIntAmt))
    '                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
    '                    iv.SubItems.Add(Math.Round(dblIntAmt) + Math.Round(dblFDAmt))
    '                    dblFDAmt += Math.Round(dblIntAmt)
    '                    datFDDate = timeTemp
    '                    intCounter1 += 1
    '                End If

    '                While (intNOM / intIntMode) >= intCounter
    '                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
    '                    datNextDate = datNextDate.AddMonths(1)
    '                    datNextDate = datNextDate.AddDays(-(datNextDate.Day))

    '                    If bolMonth = True Then
    '                        Dim intNOMonths As Integer = Val(datNextDate)
    '                        dblIntAmt = Round((dblFDAmount * intIntMode * dblROI) / (100 * 12), 2)
    '                    Else
    '                        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
    '                        dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
    '                    End If
    '                    iv = lvInterest.Items.Add(intCounter + 1)
    '                    iv.SubItems.Add(Math.Round(dblIntAmt))

    '                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))

    '                    iv.SubItems.Add(Math.Round(dblIntAmt) + Math.Round(dblFDAmt))
    '                    datFDDate = datNextDate
    '                    dblFDAmt += Math.Round(dblIntAmt)
    '                    dblTotalInt += Math.Round(dblIntAmt)
    '                    intCounter += 1
    '                End While
    '                intNOM = intNOM Mod intIntMode    'remaining no of months
    '                If bolMonth Then

    '                    tempDayAmount = Round((dblFDAmount * intNOM * dblROI) / (100 * 12), 2)
    '                    timeTemp = datNextDate
    '                    timeTemp = timeTemp.AddMonths(1)
    '                    intNOD = DateDiff(DateInterval.Day, datNextDate, timeTemp) 'days for remaining months
    '                    intNOD = intNOD - TempSubdays + 1
    '                    intNOD += Val(txtFDDays.Text)   'total remaining days

    '                    dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
    '                    dblIntAmt += tempDayAmount
    '                    dblTotalInt += Math.Round(dblIntAmt)
    '                Else


    '                    If Val(txtFDDays.Text) <> 0 Then

    '                        datNextDate = dtpFDMatDate.Value
    '                        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate) 'days for remaining months
    '                        intNOD -= 1

    '                    Else

    '                        If (intNOM < 0) Then
    '                            intNOM = intNOM * -1
    '                        End If

    '                        datNextDate = datFDDate.AddMonths(intNOM + tempNOM)
    '                        datNextDate = datNextDate.AddDays(-(datNextDate.Day))

    '                        If datNextDate > dtpFDMatDate.Value Then
    '                            datNextDate = dtpFDMatDate.Value
    '                        End If
    '                        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate) 'days for remaining months
    '                        If datNextDate <> dtpFDMatDate.Value Then
    '                            If TempSubdays <= intNOD Then
    '                                intNOD = intNOD - TempSubdays
    '                                ''intNOD += Val(txtFDDays.Text)   'total remaining days
    '                            End If
    '                        End If

    '                    End If


    '                    'If TempSubdays <= intNOD Then
    '                    '    intNOD = intNOD - TempSubdays
    '                    'End If
    '                    'intNOD += Val(txtFDDays.Text)   'total remaining days

    '                    dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
    '                    dblTotalInt += Math.Round(dblIntAmt)
    '                End If
    '                If dblIntAmt > 0 Then
    '                    iv = lvInterest.Items.Add(intCounter + 1)
    '                    iv.SubItems.Add(Math.Round(dblIntAmt))
    '                    iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
    '                    iv.SubItems.Add(Math.Round(dblIntAmt) + Math.Round(dblFDAmt))
    '                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
    '                    dblFDAmt += Math.Round(dblIntAmt)
    '                    intCounter += 1
    '                End If

    '            End If
    '            txtFDIntAmount.Text = Math.Round(dblTotalInt)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Function

#End Region

#Region "Working with date wise Quater according to chart"



    '---STARTS--------IT WILL GIVE PERFECT VALUES WITH RESPECT TO THE VALUES FROM THE CHART---------
    '
    Function FnCalculateCD(ByVal CoType As Integer) As Double '-----Function for caliculating compound interest------'
        Dim intNOM As Integer = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpFDMatDate.Value)
        Dim dblTotal As Double = 0
        Dim dblROI As Double = 0
        Dim CompType As Double = CoType
        Dim dblFDAmount As Double = 0
        Dim dblPeriod As Double = 0

        dblFDAmount = Convert.ToDouble(txtFDAmount.Text)
        dblROI = Convert.ToDouble(txtFDROI.Text) / 100
        dblPeriod = intNOM / 12
        dblTotal = (1 + (dblROI) / CompType)
        dblTotal = Math.Round(dblFDAmount * Math.Pow(dblTotal, CompType * dblPeriod))
        Return dblTotal
    End Function
    Function FnCalIntForOtherThanQterly()
        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim dblFDAmount As Double
        Dim dblIntAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim intMode As Integer = 0
        Dim iv As ListViewItem
        Dim dblFDAmt As Double = 0
        Dim x, y As Double
        Dim intTempPeriod As Integer
        Dim dblTempPower As Double

        Dim datNextDate As Date
        Dim intDivide As Integer
        Dim datMatdate As Date
        Dim intQuater As Integer = 0

        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True

        '''''''''''
        Dim tempMonth As Integer
        Dim temp As Integer = 0
        timeTemp = dtpFDDate.Value
        Dim tempDayAmount As Double = 0
        Dim dblTemp As Double
        Dim dblPrev As Double

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FoQuater = New Integer() {"10", "11", "12"}
        Dim PerMonth As Double
        Dim PerDay As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        'Below is the method for 30 days used in pavagada BTM for Noncumulative(Simple Interest)
        'Here D day textbox should not be empty or select the '365'
        If BTMMethod.Checked = True Then
            If txtFDDays.Text = String.Empty Then
                MsgBox("Please enter the number of days or select the '356/12 monthe type'.", MsgBoxStyle.Information, "Deposit Module")
            Else
                Select Case cmbFDType.SelectedItem.ToString
                    Case "Monthly"
                        intIntMode = 1
                    Case "Quarterly"
                        intIntMode = 3
                    Case "Half-Yearly"
                        intIntMode = 6
                    Case "Yearly"
                        intIntMode = 12
                End Select
                datFDDate = CDate(dtpFDDate.Value)
                dblFDAmt = CDbl(txtFDAmount.Text)
                dblROI = Val(txtFDROI.Text)
                dblIntAmt = Round((dblFDAmt * dblROI) / (1200 + dblROI), 2) 'IntAmount without days
                PerDay = Round((dblIntAmt / 30), 2)
                datMatdate = CDate(dtpFDMatDate.Value)
                If txtFDYears.Text <> String.Empty Then
                    'intNOD = (Val(txtFDYears.Text) * 365)
                    intNOM += (Val(txtFDYears.Text) * 12)
                End If
                If txtFDMonths.Text <> String.Empty Then
                    'intNOD += (Val(txtFDMonths.Text) * 30)
                    intNOM += Val(txtFDMonths.Text)
                End If
                If txtFDDays.Text <> String.Empty Then
                    intNOD += Val(txtFDDays.Text)
                    Days = Val(txtFDDays.Text)
                End If
                lvInterest.Items.Clear()
                While (intNOM / intIntMode) > intCounter
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    'intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    iv = lvInterest.Items.Add(intCounter)
                    'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                    iv.SubItems.Add(Round(dblIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                    iv.SubItems.Add(Format(Round(dblIntAmt) + dblFDAmt))
                    'dblFDAmount += Round(dblIntAmt * intNOD)
                    'dblTotalInt += Round(dblIntAmt * intNOD)
                    dblFDAmt += Round(dblIntAmt)
                    dblTotalInt += Round(dblIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                End While
                iv = lvInterest.Items.Add(intCounter)
                iv.SubItems.Add(Round(PerDay * Days))
                iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(PerDay * Days) + dblFDAmt))
                dblFDAmt += Round(PerDay * Days)
                dblTotalInt += Round(PerDay * Days)
                datFDDate = DateAdd(DateInterval.Day, Days, datFDDate)
                intCounter += 1
            End If
            'txtFDIntAmount.Text = Math.Round(dblTotalInt)
            txtFDIntAmount.Text = Round(dblTotalInt)
        End If

        If NaveenSirMtd.Checked = True Then 'Month wise mtd for Noncumulative(Simple Interest)
                 Select Case cmbFDType.SelectedItem.ToString
                Case "Monthly"
                    intIntMode = 1
                Case "Quarterly"
                    intIntMode = 3
                Case "Half-Yearly"
                    intIntMode = 6
                Case "Yearly"
                    intIntMode = 12
            End Select
            datFDDate = CDate(dtpFDDate.Value)
            dblFDAmt = CDbl(txtFDAmount.Text)
            dblROI = Val(txtFDROI.Text)
            dblIntAmt = Round((dblFDAmt * dblROI) / (1200 + dblROI), 2) 'IntAmount without days

            If txtFDYears.Text <> String.Empty Then
                intNOD = (Val(txtFDYears.Text) * 365)
                intNOM += (Val(txtFDYears.Text) * 12)
            End If
            If txtFDMonths.Text <> String.Empty Then
                intNOD += (Val(txtFDMonths.Text) * 30)
                intNOM += Val(txtFDMonths.Text)
            End If
            If txtFDDays.Text <> String.Empty Then
                intNOD = Val(txtFDDays.Text)
            End If

            ''PerMonth = dblIntAmt / 12

            'PerDay = dblIntAmt / 365
            lvInterest.Items.Clear()
            While (intNOM / intIntMode) > intCounter
                datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                iv = lvInterest.Items.Add(intCounter)
                iv.SubItems.Add(Round(dblIntAmt))
                iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(dblIntAmt) + dblFDAmt))
                dblFDAmt += Round(dblIntAmt)
                dblTotalInt += Round(dblIntAmt)
                datFDDate = datNextDate
                intCounter += 1
            End While
            txtFDIntAmount.Text = (dblTotalInt)

        End If
        'Below is the standard method for FD calculation 
        If StandardMtd.Checked = True Then
            datFDDate = CDate(dtpFDDate.Value)
            lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
            datMatdate = CDate(dtpFDMatDate.Value)
            If fnCheckFDDetails() = True Then
                Try
                    dblFDAmount = CDbl(txtFDAmount.Text)
                    dblFDAmt = CDbl(txtFDAmount.Text)
                    dblROI = Val(txtFDROI.Text)
                    intNOM = Val(txtFDMonths.Text)
                    intNOM += (Val(txtFDYears.Text) * 12)
                    intCounter = 1
                    lvInterest.Items.Clear()
                    If bolCumulative = True Then
                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 12
                                intMode = 1
                            Case "Quarterly"
                                intIntMode = 4
                                intMode = 3
                            Case "Half-Yearly"
                                intIntMode = 2
                                intMode = 6
                            Case "Yearly"
                                intIntMode = 1
                                intMode = 12
                        End Select
                        x = (1 + ((Val(txtFDROI.Text)) / (intIntMode * 100)))
                        intTempPeriod = intMode
                        While (intNOM / intMode) >= intCounter
                            y = (Val(intTempPeriod) / intMode)
                            dblTempPower = Math.Pow(x, y)
                            dblIntAmt = (Val(txtFDAmount.Text) * (dblTempPower)) - Val(txtFDAmount.Text)
                            datNextDate = DateAdd(DateInterval.Month, intMode, datFDDate)
                            dblTemp = dblIntAmt - dblPrev
                            iv = lvInterest.Items.Add(intCounter + 1)
                            iv.SubItems.Add(Math.Round(dblTemp))
                            'iv.SubItems.Add(Math.Round(dblTemp, 3))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            'iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            iv.SubItems.Add((dblTemp) + (dblFDAmount))
                            dblPrev = dblIntAmt
                            dblFDAmount += Math.Round(dblTemp)
                            'dblFDAmount += (dblTemp)
                            datFDDate = datNextDate
                            dblTotalInt += Math.Round(dblTemp)
                            'dblTotalInt += (dblTemp)
                            intTempPeriod += intMode
                            intCounter += 1
                        End While
                        intNOM = intNOM Mod intMode
                        If intNOM > 0 Then
                            intTempPeriod -= intMode
                            intTempPeriod += intNOM
                            y = (Val(intTempPeriod) / intMode)
                            dblTempPower = Math.Pow(x, y)
                            dblIntAmt = (Val(txtFDAmount.Text) * (dblTempPower)) - Val(txtFDAmount.Text)
                            datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate)
                            dblTemp = dblIntAmt - dblPrev
                            iv = lvInterest.Items.Add(intCounter + 1)
                            iv.SubItems.Add(Math.Round(dblTemp))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            dblPrev = dblIntAmt
                            dblFDAmount += Math.Round(dblTemp)
                            datFDDate = datNextDate
                            dblTotalInt += Math.Round(dblTemp)
                            intTempPeriod += intMode
                        End If
                    Else            'for NON-CUMULATIVE 
                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 1
                            Case "Quarterly"
                                intIntMode = 3
                            Case "Half-Yearly"
                                intIntMode = 6
                            Case "Yearly"
                                intIntMode = 12
                        End Select
                        dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365))
                        intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                        dblIntAmt = dblIntAmt / intNOD
                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpFDMatDate.Value)
                        End If
                        While (intNOM / intIntMode) >= intCounter
                            datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                            iv = lvInterest.Items.Add(intCounter)
                            'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                            iv.SubItems.Add(Round(dblIntAmt * intNOD))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                            iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00"))
                            'dblFDAmount += Round(dblIntAmt * intNOD)
                            'dblTotalInt += Round(dblIntAmt * intNOD)
                            dblFDAmount += (dblIntAmt * intNOD)
                            dblTotalInt += (dblIntAmt * intNOD)
                            datFDDate = datNextDate
                            intCounter += 1
                        End While
                        intNOM = intNOM Mod intIntMode    'remaining no of months
                        datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate) 'get next date for remaining months
                        If datNextDate > dtpFDMatDate.Value Then
                            datNextDate = dtpFDMatDate.Value
                        End If
                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            Dim int As Integer = intNOD
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)  'days for remaining months
                            intNOD += Val(txtFDDays.Text) - int 'total remaining days
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)  'days for remaining months
                            intNOD += Val(txtFDDays.Text)  'total remaining days
                        End If
                        If intNOD > 0 Then
                            iv = lvInterest.Items.Add(intCounter)
                            iv.SubItems.Add(Round(dblIntAmt * intNOD))
                            iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00"))
                            dblFDAmount += Round(dblIntAmt * intNOD)
                            dblTotalInt += Round(dblIntAmt * intNOD)
                            datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                            intCounter += 1
                        End If
                    End If
                    'txtFDIntAmount.Text = Math.Round(dblTotalInt)
                    txtFDIntAmount.Text = (dblTotalInt)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Function
    Function FnCalInterest() As Boolean

        If cmbFDType.Text <> "Quarterly" Then
            FnCalIntForOtherThanQterly()
            Return True
        End If

        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim intNOD1 As Integer = 0
        Dim intMonth As Integer = 0
        Dim intNODTemp As Integer = 0
        Dim dblFDAmount As Double
        Dim dblInitialFDAmt As Double
        Dim dblIntAmt As Double = 0
        Dim dblIntAmtBelow As Double = 0
        Dim dblFDCumBeforeAmt As Double = 0
        Dim dblTotalInterestAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim Counter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim intMode As Integer = 0
        Dim iv As ListViewItem
        Dim dblFDAmt As Double = 0
        Dim x, y As Double
        Dim intTempPeriod As Integer
        Dim dblTempPower As Double

        Dim datNextDate As Date
        Dim datPrevDate As Date
        Dim intDivide As Integer
        Dim datMatdate As Date
        Dim intQuater As Integer = 0
        Dim dtTemp As Date
        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True

        '''''''''''
        Dim tempMonth As Integer
        Dim temp As Integer = 0
        timeTemp = dtpFDDate.Value
        Dim tempDayAmount As Double = 0
        Dim dblTemp As Double
        Dim dblTempFDTotal As Double
        Dim dblPrev As Double

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FQuater = New Integer() {"10", "11", "12"}
        datFDDate = CDate(dtpFDDate.Value)
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
        datMatdate = CDate(dtpFDMatDate.Value)
        Dim PerMonthIntAmt As Double
        Dim PerDayIntAmt As Double
        Dim PerQuerterIntAmt As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        Dim NoOfQurters As Decimal
        Dim OnlyMonth As Integer
        Dim Number As Decimal
        Dim IntegerResult As Integer

        If BTMMethod.Checked = True Then
            intCounter = 1
            Select Case cmbFDType.SelectedItem.ToString
                Case "Monthly"
                    intIntMode = 1
                Case "Quarterly"
                    intIntMode = 3
                Case "Half-Yearly"
                    intIntMode = 6
                Case "Yearly"
                    intIntMode = 12
            End Select

            dblFDAmt = CDbl(txtFDAmount.Text)
            dblROI = Val(txtFDROI.Text)
            dblIntAmt = Round((dblFDAmt * dblROI) / 100, 2) 'IntAmount without days

            If txtFDYears.Text <> String.Empty Then
                intNOD = (Val(txtFDYears.Text) * 365)
                intNOM += (Val(txtFDYears.Text) * 12)
            End If
            If txtFDMonths.Text <> String.Empty Then
                intNOD += (Val(txtFDMonths.Text) * 30)
                intNOM += Val(txtFDMonths.Text)
            End If
            If txtFDDays.Text <> String.Empty Then
                intNOD += Val(txtFDDays.Text)
            End If
            datFDDateTemp = dtpFDDate.Value
            lvInterest.Items.Clear()
            If dtpFDMatDate.Value < dtpNextDate.Value Then
                'intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                Counter += 1
                iv = lvInterest.Items.Add(Counter)
                iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                dblFDAmt += (PerDayIntAmt * intNOD)
                dblTotalInt += (PerDayIntAmt * intNOD)
                datFDDate = dtpFDMatDate.Value
                txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                'If Next querter date is different from the FDDate 
            ElseIf dtpNextDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpNextDate.Value)
                datMatdate = dtpFDMatDate.Value
                intNOD = DateDiff("d", datFDDateTemp.Date, dtpNextDate.Value)
                ' dblIntAmtBelow = dblIntAmt * intNOD
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                dtpFDDate.Value = dtpNextDate.Value
                Counter += 1
                iv = lvInterest.Items.Add(Counter)
                iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                Dim t1 As Double = Round(PerDayIntAmt * intNOD) + dblFDAmt
                iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                dblFDAmt += Math.Round(PerDayIntAmt * intNOD)
                dblTotalInt += Math.Round(PerDayIntAmt * intNOD)
                datFDDate = dtpNextDate.Value
            End If
            'If NextQuerter date is same as the FDDate 
            If dtpNextDate.Value = dtpFDDate.Value Then
                datFDDate = CDate(dtpFDDate.Value)
                NoOfQurters = intNOM / 3 'per year
                PerQuerterIntAmt = Round(dblIntAmt / 4)
                PerMonthIntAmt = Round(dblIntAmt / 12) 'per year
                IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
                'Dim t As Decimal = CDec(Math.Truncate(NoOfQurters)) 'Important method for get only inter part of real number
                'per day
                'lvInterest.Items.Clear()
                intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate.Date)
                'While IntegerResult > intCounter
                While (intNOM / intIntMode) > intCounter
                    datPrevDate = datNextDate
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate.Date)
                    intMonth = datNextDate.Month
                    If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                        If (datNextDate.Day = 30) Then
                            datNextDate = DateAdd(DateInterval.Day, 1, datNextDate.Date)
                        End If
                    End If
                    intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datNextDate.Date)
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                    iv.SubItems.Add(Round(intNOD * PerDayIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                    iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                    'dblFDAmount += Round(dblIntAmt * intNOD)
                    'dblTotalInt += Round(dblIntAmt * intNOD)
                    dblFDAmt += Round(intNOD * PerDayIntAmt)
                    dblTotalInt += Round(intNOD * PerDayIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                End While
                OnlyMonth = intNOM Mod 3
                intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datMatdate.Date)   'days for remaining months
                If intNOD > 0 Then
                    dblInitialFDAmt += dblIntAmt
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                    iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                    Dim t2 As Double = Round(PerDayIntAmt * intNOD) + dblFDAmt
                    iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                    intCounter += 1
                    dblFDAmt += Round(PerDayIntAmt * intNOD)
                    dblTotalInt += Round(PerDayIntAmt * intNOD)
                    datFDDate = dtpNextDate.Value
                End If

                'dblTotalInt = dblInitialFDAmt - dblFDAmount
                'dblFDAmount = dblInitialFDAmt
                txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))

            End If
            dtpFDDate.Value = datFDDateTemp
        End If
        If NaveenSirMtd.Checked = True Then  'Noncumulative for quterly for equal int amount generate 
            intCounter = 1
            Select Case cmbFDType.SelectedItem.ToString
                Case "Monthly"
                    intIntMode = 1
                Case "Quarterly"
                    intIntMode = 3
                Case "Half-Yearly"
                    intIntMode = 6
                Case "Yearly"
                    intIntMode = 12
            End Select

            dblFDAmt = CDbl(txtFDAmount.Text)
            dblROI = Val(txtFDROI.Text)
            dblIntAmt = Round((dblFDAmt * dblROI) / 100, 2) 'IntAmount without days

            If txtFDYears.Text <> String.Empty Then
                intNOD = (Val(txtFDYears.Text) * 365)
                intNOM += (Val(txtFDYears.Text) * 12)
            End If
            If txtFDMonths.Text <> String.Empty Then
                intNOD += (Val(txtFDMonths.Text) * 30)
                intNOM += Val(txtFDMonths.Text)
            End If
            If txtFDDays.Text <> String.Empty Then
                intNOD += Val(txtFDDays.Text)
            End If
            datFDDateTemp = dtpFDDate.Value
            lvInterest.Items.Clear()

            'code for If Next querter date is different from the FDDate 
            If dtpNextDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpNextDate.Value)
                datMatdate = dtpFDMatDate.Value
                intNOD = DateDiff("d", datFDDateTemp.Date, dtpNextDate.Value)
                ' dblIntAmtBelow = dblIntAmt * intNOD
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                dtpFDDate.Value = dtpNextDate.Value
                Counter += 1
                iv = lvInterest.Items.Add(Counter)
                iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                dblFDAmt += Math.Round(PerDayIntAmt * intNOD)
                dblTotalInt += Math.Round(PerDayIntAmt * intNOD)
                datFDDate = dtpNextDate.Value
            End If
            'Code for If NextQuerter date is same as the FDDate 
            If dtpNextDate.Value = dtpFDDate.Value Then

                datFDDate = CDate(dtpFDDate.Value)
                NoOfQurters = intNOM / 3 'per year
                PerQuerterIntAmt = Round(dblIntAmt / 4)
                PerMonthIntAmt = Round(dblIntAmt / 12) 'per year
                IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
                'Dim t As Decimal = CDec(Math.Truncate(NoOfQurters)) 'Important method for get only inter part of real number
                'per day
                'lvInterest.Items.Clear()
                intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate.Date)
                'While IntegerResult > intCounter
                While (intNOM / intIntMode) > intCounter
                    datPrevDate = datNextDate
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    intMonth = datNextDate.Month
                    If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                        If (datNextDate.Day = 30) Then
                            datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
                        End If
                    End If
                    intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datNextDate.Date)
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                    iv.SubItems.Add(Round(PerQuerterIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                    iv.SubItems.Add(Format(Round(PerQuerterIntAmt) + dblFDAmt))
                    'dblFDAmount += Round(dblIntAmt * intNOD)
                    'dblTotalInt += Round(dblIntAmt * intNOD)
                    dblFDAmt += Round(PerQuerterIntAmt)
                    dblTotalInt += Round(PerQuerterIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                    '''''''''''''''''''''''''''''''''''''''''
                    'datPrevDate = datNextDate
                    'datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    'intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    ' dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                    ' dblInitialFDAmt += dblIntAmt
                    ' iv = lvInterest.Items.Add(intCounter + Counter)
                    ' iv.SubItems.Add(Round(dblIntAmt))
                    '  iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    ' iv.SubItems.Add(Format(Round(dblInitialFDAmt), "0.00"))
                    ' dblTotalInt += dblIntAmt
                    ' datFDDate = datNextDate

                End While
                OnlyMonth = intNOM Mod 3
                intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datMatdate.Date)   'days for remaining months
                intNOD += Val(txtFDDays.Text)  'total remaining days

                If intNOD > 0 Then
                    ' dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                    dblInitialFDAmt += dblIntAmt
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                    iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                    iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                    intCounter += 1
                    dblFDAmt += Round(PerDayIntAmt * intNOD)
                    dblTotalInt += Round(PerDayIntAmt * intNOD)
                    datFDDate = dtpNextDate.Value
                End If

                'dblTotalInt = dblInitialFDAmt - dblFDAmount
                'dblFDAmount = dblInitialFDAmt
                txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                'If OnlyMonth > 0 Then
                '    iv = lvInterest.Items.Add(intCounter)
                '    iv.SubItems.Add(Round(PerMonthIntAmt * OnlyMonth))
                '    iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                '    iv.SubItems.Add(Format(Round(PerMonthIntAmt * OnlyMonth) + dblFDAmt, "0.00"))
                '    dblFDAmt += Round(PerMonthIntAmt * OnlyMonth)
                '    dblTotalInt += Round(PerMonthIntAmt * OnlyMonth)
                '    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                '    intCounter += 1
                'End If
                'txtFDIntAmount.Text = Math.Round(dblTotalInt)
                'txtFDIntAmount.Text = (dblTotalInt)
                'Else
                '    ' Near querter calculation
                '    lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
                '    datMatdate = dtpFDMatDate.Value
                '    intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpNextDate.Value)
                '    dblIntAmtBelow = ((dblFDAmt * dblROI) / (365 * 100)) * intNOD

                '    'dtpFDDate.Value = dtpNextDate.Value
                '    Counter += 1
                '    iv = lvInterest.Items.Add(Counter)
                '    iv.SubItems.Add(Round(dblIntAmtBelow, 2))
                '    iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                '    iv.SubItems.Add(Format(Round(dblIntAmtBelow) + dblFDAmt, "0.00"))
                '    datFDDate = dtpNextDate.Value


            End If
            dtpFDDate.Value = datFDDateTemp
        End If

        If StandardMtd.Checked = True Then
            If fnCheckFDDetails() = True Then
                Try
                    dblFDAmount = CDbl(txtFDAmount.Text)
                    dblInitialFDAmt = CDbl(txtFDAmount.Text)
                    dblFDAmt = CDbl(txtFDAmount.Text)
                    dblROI = Val(txtFDROI.Text)
                    intNOM = Val(txtFDMonths.Text)
                    intNOM += (Val(txtFDYears.Text) * 12)
                    intCounter = 1
                    lvInterest.Items.Clear()
                    If bolCumulative = True Then
                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 12
                                intMode = 1
                            Case "Quarterly"
                                intIntMode = 4
                                intMode = 3
                            Case "Half-Yearly"
                                intIntMode = 2
                                intMode = 6
                            Case "Yearly"
                                intIntMode = 1
                                intMode = 12
                        End Select
                        '' "Changes for cumulative cd "
                        dblTempFDTotal = FnCalculateCD(intIntMode)

                        datFDDateTemp = dtpFDDate.Value
                        If dtpNextDate.Value = dtpFDDate.Value Then
                            dtpFDDate.Value = dtpNextDate.Value
                            lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                            datFDDate = dtpFDDate.Value
                        Else
                            lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
                            datMatdate = dtpFDMatDate.Value
                            intNOD = DateDiff(DateInterval.Day, datFDDateTemp.Date, dtpNextDate.Value)
                            dblIntAmtBelow = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD

                            dtpFDDate.Value = dtpNextDate.Value
                            Counter += 1
                            iv = lvInterest.Items.Add(Counter)
                            iv.SubItems.Add(Round(dblIntAmtBelow))
                            iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblIntAmtBelow) + dblFDAmount))
                            datFDDate = dtpNextDate.Value
                            dblFDAmount += Round(dblIntAmtBelow)

                        End If
                        dblIntAmtBelow += dblFDAmount
                        ''endchanges 
                        x = (1 + ((Val(txtFDROI.Text)) / (intIntMode * 100)))
                        intTempPeriod = intMode

                        While (intNOM / intMode) > intCounter
                            datPrevDate = datNextDate
                            y = (Val(intTempPeriod) / intMode)
                            dblTempPower = Math.Pow(x, y)
                            Dim temp2 As Double = (dblIntAmtBelow * (dblTempPower))
                            Dim temp1 As Double = temp - dblIntAmtBelow
                            dblIntAmt = (dblIntAmtBelow * (dblTempPower)) - dblIntAmtBelow

                            datNextDate = DateAdd(DateInterval.Month, intMode, datFDDate)
                            intMonth = datNextDate.Month
                            If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                                If (datNextDate.Day = 30) Then
                                    datNextDate = DateAdd(DateInterval.Day, 1, datNextDate.Date)
                                End If
                            End If
                            dblTemp = dblIntAmt - dblPrev

                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Math.Round(dblTemp))
                            'iv.SubItems.Add(Math.Round(dblTemp, 3))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount)) ''''''
                            'iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            iv.SubItems.Add((dblTemp) + (dblFDAmount))
                            dblPrev = dblIntAmt
                            dblFDAmount += Math.Round(dblTemp)
                            'dblFDAmount += (dblTemp)
                            datFDDate = datNextDate
                            dblTotalInt += Math.Round(dblTemp)
                            'dblTotalInt += (dblTemp)
                            intTempPeriod += intMode
                            intCounter += 1
                        End While
                        intNOD = DateDiff(DateInterval.Day, datPrevDate.Date, datMatdate.Date)
                        If datNextDate > dtpFDMatDate.Value Then
                            datNextDate = dtpFDMatDate.Value
                        End If

                        If intNOD > 0 Then
                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Math.Round(dblTempFDTotal - dblFDAmount))
                            iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTempFDTotal))
                        End If
                        txtFDMatAmount.Text = Convert.ToString(dblTempFDTotal)
                        txtFDIntAmount.Text = Convert.ToString(dblTempFDTotal - Convert.ToDouble(txtFDAmount.Text))
                    Else            'for NON-CUMULATIVE 

                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 1
                            Case "Quarterly"
                                intIntMode = 3
                            Case "Half-Yearly"
                                intIntMode = 6
                            Case "Yearly"
                                intIntMode = 12
                        End Select
                        '' "Changes"

                        datFDDateTemp = dtpFDDate.Value
                        If dtpNextDate.Value = dtpFDDate.Value Then
                            dtpFDDate.Value = dtpNextDate.Value
                            lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                            datFDDate = dtpFDDate.Value
                        Else
                            lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
                            datMatdate = dtpFDMatDate.Value
                            intNOD = DateDiff(DateInterval.Day, datFDDateTemp.Date, dtpNextDate.Value)
                            dblIntAmtBelow = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD

                            dtpFDDate.Value = dtpNextDate.Value
                            Counter += 1
                            iv = lvInterest.Items.Add(Counter)
                            iv.SubItems.Add(Round(dblIntAmtBelow))
                            iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblIntAmtBelow) + dblFDAmount, "0.00"))
                            datFDDate = dtpNextDate.Value
                        End If

                        ''endchanges 
                        dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365), 2)
                        intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, datMatdate.Date)

                        dblInitialFDAmt += dblIntAmtBelow

                        intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate.Date)
                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate.Date)
                        End If

                        While (intNOM / intIntMode) > intCounter
                            datPrevDate = datNextDate
                            datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate.Date)
                            intMonth = datNextDate.Month
                            If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                                If (datNextDate.Day = 30) Then
                                    datNextDate = DateAdd(DateInterval.Day, 1, datNextDate.Date)
                                End If
                            End If
                            intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datNextDate.Date)
                            dblIntAmt = Math.Round(((dblFDAmount * dblROI) / (365 * 100)) * intNOD)
                            dblInitialFDAmt += Round(dblIntAmt)
                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Round(dblIntAmt))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblInitialFDAmt), "0.00"))
                            dblTotalInt += dblIntAmt
                            datFDDate = datNextDate

                            intCounter += 1
                        End While
                        intNOM = intNOM Mod intIntMode    'remaining no of months
                        datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate.Date) 'get next date for remaining months
                        intNOD = DateDiff(DateInterval.Day, datPrevDate.Date, datMatdate.Date)
                        If datNextDate > dtpFDMatDate.Value Then
                            datNextDate = dtpFDMatDate.Value
                        End If

                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            Dim int As Integer = intNOD
                            intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datMatdate.Date)  'days for remaining months
                            intNOD += Val(txtFDDays.Text) - int 'total remaining days
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate.Date, datMatdate.Date)  'days for remaining months
                            intNOD += Val(txtFDDays.Text)   'total remaining days
                        End If

                        If intNOD > 0 Then
                            dblIntAmt = Math.Round(((dblFDAmount * dblROI) / (365 * 100)) * intNOD)
                            dblInitialFDAmt += dblIntAmt
                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Round(dblIntAmt))
                            iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblInitialFDAmt), "0.00"))
                            datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                            intCounter += 1
                        End If

                        dblTotalInt = dblInitialFDAmt - dblFDAmount
                        dblFDAmount = dblInitialFDAmt
                        txtFDMatAmount.Text = Convert.ToString(Round(dblInitialFDAmt))
                        txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                    End If
                    dtpFDDate.Value = datFDDateTemp

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Function

    '    'Working with date wise Quater according to chart
    '    '---ENDS--------IT WILL GIVE PERFECT VALUES WITH RESPECT TO THE VALUES FROM THE CHART---------
    '    '
#End Region

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If cmbPeriod.SelectedIndex <> -1 Then
            FnCalInterest()
        ElseIf cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select interest posting type", MsgBoxStyle.Information)
            cmbPeriod.Focus()
        End If

    End Sub


    Private Sub txtFDYears_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDDays.TextChanged, txtFDMonths.TextChanged, txtFDYears.TextChanged
        sbCalcMatDate()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmFDCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtInterest.Columns.Add("SlNo")
        dtInterest.Columns.Add("IntAmount")
        dtInterest.Columns.Add("IntDate")
        dtInterest.Columns.Add("TotalAmount")
        'dtpFDDate.MaxDate = Date.Now
        dtpFDDate.Value = Date.Now
        dtpNextDate.Value = Date.Now
        'dtpDOB.MaxDate = Date.Now
        'dtpDOB.Value = Date.Now
        sbLoadControlValues()
        cmbAccountType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        cmbSchemeType.SelectedIndex = -1

        'If txtFDAccountNo.Text <> "FD" And txtFDAccountNo.Text <> "ENNVY" And txtFDAccountNo.Text <> "SCC" And txtFDAccountNo.Text <> "" And txtFDAccountNo.Text <> String.Empty Then
        If strFDNo <> "" Then
            txtFDAccountNo.Text = strFDNo
            sbLoadFD()
        Else
            btnAdd_Click(sender, e)
            cmbDepositType.SelectedIndex = 0
        End If
        Panel3.Enabled = False
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub btnLoadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPhoto.Click, picPhoto.Click
        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Try
                picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
                picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub btnCancelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPhoto.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnLoadSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSign.Click, picSignature.Click
        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Try
                picSignature.Image = Image.FromFile(OpenFileDialog1.FileName)
                picSignature.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub btnCancelSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSign.Click
        picSignature.Image = Nothing
    End Sub

    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click
        If Trim(txtFDAccountNo.Text) <> String.Empty Then
            If Trim(txtFDAccountNo.Text) <> "FD" Or Trim(txtFDAccountNo.Text) <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
                Dim objFamilyDetails As New frmFamily_Detail
                objFamilyDetails.txtAccountNo.Text = txtFDAccountNo.Text
                objFamilyDetails.txtName.Text = txtName.Text
                objFamilyDetails.chrType = "F"
                objFamilyDetails.ShowDialog(Me)
                objFamilyDetails.Dispose()
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Enter valid account no", MsgBoxStyle.Information, "Deposit Module")
            txtFDAccountNo.Focus()

        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        If MsgBox("You want to make another transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
                            btnAdd_Click(sender, e)
                        Else
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtFDAccountNo.Text) <> String.Empty Then
            If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
                Dim objNominees As New frmNominees
                objNominees.txtAccountNo.Text = txtFDAccountNo.Text
                objNominees.txtName.Text = txtName.Text
                objNominees.chrType = "N"
                objNominees.ShowDialog(Me)
                objNominees.Dispose()
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
            txtFDAccountNo.Focus()
        End If
    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        If chkSame.Checked = True Then
            txtPresAddress.Text = txtPermAddress.Text
        End If
    End Sub

    Private Sub txtPermAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermAddress.TextChanged
        If chkSame.Checked = True Then
            txtPresAddress.Text = txtPermAddress.Text
        End If


    End Sub

    Private Sub btnSearchMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMember.Click

        'Dim objMemberSearch As New frmMemberSearch
        'objMemberSearch.strMemberNo = ""
        'objMemberSearch.ShowDialog(Me)
        'If objMemberSearch.strMemberNo <> "" Then
        '    sbClear()
        '    txtMemberNo.Text = objMemberSearch.strMemberNo
        '    sbGeneral()
        'End If
        'objMemberSearch.Dispose()

        Dim objPerson As New clsPerson
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            sbClear()
            txtCustomerID.Text = objCustomerList.strCustomerID
            sbLoadCustomer()
        End If
        objCustomerList.Dispose()

    End Sub

    Private Sub btnJointHolders_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJointHolders.Click
        If cmbAccountType.SelectedItem = "Joint" Then
            If Trim(txtFDAccountNo.Text) <> String.Empty Then
                If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or txtFDAccountNo.Text <> "SCC" Then
                    Dim objJointHolders As New frmNominees
                    objJointHolders.txtAccountNo.Text = txtFDAccountNo.Text
                    objJointHolders.txtName.Text = txtName.Text
                    objJointHolders.Text = "Joint-Holders for Account No  " & txtFDAccountNo.Text
                    objJointHolders.chrType = "J"
                    objJointHolders.ShowDialog(Me)
                    objJointHolders = Nothing
                Else
                    MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                    txtFDAccountNo.Focus()
                End If
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged
        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
            Timer1.Stop()
            lblMajor.Visible = False
            dtpMajor.Visible = False

        Else
            Timer1.Start()
            rdbMinor.Checked = True
            lblMajor.Visible = True
            dtpMajor.Visible = True
            Dim objDate As Date = dtpDOB.Value
            dtpMajor.Value = DateAdd(DateInterval.Year, 18, objDate)
        End If

        If Val(txtAge.Text) >= 60 Then
            rdbSYes.Checked = True
            rdbSNo.Checked = False

        Else
            rdbSNo.Checked = True
            rdbSYes.Checked = False
        End If
    End Sub

    Private Sub btnReceiptDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptDetails.Click
        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/ReceiptKan.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{receiptmaintbl.ReceiptNo}='" & txtReceiptNo.Text & "'"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()
    End Sub

    Private Sub btnFDBond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFDBond.Click
        If objFDAccount.fnGetFDDetails(txtFDAccountNo.Text) Then
            Dim objReportViewer As New frmReportViewer
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/FDBondKan.rpt"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{FDDetailsTbl.FDNo} = '" & txtFDAccountNo.Text & "'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()
        Else
            MsgBox("Account no. dosent exist", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click
        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strFDNo = ""
            objFDSearch.strForm = "FDCreation"
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFD()
                txtName.Focus()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select the deposit type ", MsgBoxStyle.Information)
            cmbDepositType.Focus()
        End If


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbClear()
        txtFDAccountNo.ResetText()
        cmbDepositType.SelectedIndex = -1
        Timer1.Stop()
        TabControl1.SelectedIndex = 0
        cmbDepositType.Focus()


    End Sub

    Private Sub txtFDIntAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDIntAmount.TextChanged

        txtFDMatAmount.Text = Val(txtFDAmount.Text) + Val(txtFDIntAmount.Text)

    End Sub

    Private Sub btnNewMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMember.Click

        'Dim objfrmMemberCreation As frmMemberCreation
        'objfrmMemberCreation = frmMemberCreation.DefInstance
        'objfrmMemberCreation.BringToFront()
        'objfrmMemberCreation.MdiParent = Me.MdiParent
        'objfrmMemberCreation.Show()
        'objfrmMemberCreation = Nothing

        Dim objCustomer As New frmCustomer
        objCustomer = frmCustomer.DefInstance
        objCustomer.MdiParent = Me.MdiParent
        objCustomer.BringToFront()
        objCustomer.Show()
        objCustomer = Nothing

    End Sub
    Private Sub txtFDAccountNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAccountNo.Leave
        If txtFDAccountNo.Text <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
            If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) Then
                If MsgBox("Account no. already exists! " & Chr(13) & Chr(13) & "You want to edit account details?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Edit") = MsgBoxResult.Yes Then
                    sbLoadFD()
                Else
                    txtFDAccountNo.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub txtFDAccountNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFDAccountNo.KeyDown

        If e.KeyData = Keys.F3 Then
            btnSearchFD_Click(sender, e)
        End If

    End Sub

    Private Sub dtpFDDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFDDate.ValueChanged
        sbCalcMatDate()
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) Then
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                Dim ObjfrmFDPayments As New frmFDPayments
                ObjfrmFDPayments.txtFDAccountNo.Text = txtFDAccountNo.Text
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "SCC"
                End Select
                ObjfrmFDPayments.cmbSchemeType.SelectedValue = cmbSchemeType.SelectedValue
                ObjfrmFDPayments.ShowDialog(Me)
            Else
                MsgBox("Account is already closed", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Account no. dosent exist", MsgBoxStyle.Information)
        End If

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolVisible = True Then
            lblMajor.Visible = True
            bolVisible = False
        Else
            bolVisible = True
            lblMajor.Visible = False
        End If
    End Sub

    Private Sub txtRemainingAmount_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDAmount.GotFocus

        txtFDROI.ResetText()
        Dim lngPeriod As Double = 0
        Dim dblROI As Double = 0
        'If StandardMtd.Checked = True Then   'Standard mtd
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
        ' ElseIf NaveenSirMtd.Checked = True Then    'Naveen mtd
            ''If txtFDYears.Text <> String.Empty Then
            ''    lngPeriod = (Val(txtFDYears.Text) * 365)
            ''    ' intNOM += (Val(txtFDYears.Text) * 12)
            ''End If
            ''If txtFDMonths.Text <> String.Empty Then
            ''    lngPeriod += (Val(txtFDMonths.Text) * 30)
            ''    'intNOM += Val(txtFDMonths.Text)
            ''End If
            ''If txtFDDays.Text <> String.Empty Then
            ''    lngPeriod += Val(txtFDDays.Text)
            ''End If
            'ElseIf BTMMethod.Checked = True Then
            'If txtFDYears.Text <> String.Empty Then
            '    lngPeriod = (Val(txtFDYears.Text) * 365)
            '    ' intNOM += (Val(txtFDYears.Text) * 12)
            'End If
            'If txtFDMonths.Text <> String.Empty Then
            '    lngPeriod += (Val(txtFDMonths.Text) * 30)
            '    'intNOM += Val(txtFDMonths.Text)
            'End If
            'If txtFDDays.Text <> String.Empty Then
            '    lngPeriod += Val(txtFDDays.Text)
            'End If
            'End If
            'If Val(txtFDDays.Text) = 0 Then
            '    lngPeriod -= 1
            'End If

            If objFDAccount.fnGetROI(lngPeriod) Then
                If rdbSYes.Checked = True Then
                    dblROI = objFDAccount.FdMasterTbl.Rows(0).Item(0) + dtMasterData.Rows(0).Item("SCROI")
                ElseIf rdbSNo.Checked = True Then
                    dblROI = objFDAccount.FdMasterTbl.Rows(0).Item(0)
                End If
            End If

            If cmbPeriod.SelectedItem = "As Scheme Period" Then
                dblROI -= dtMasterData.Rows(0).Item("ReductionInt")
            End If

            txtFDROI.Text = Format(dblROI, "00.00")



    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        'Dim objMemberSearch As New frmMemberSearch
        'objMemberSearch.strMemberNo = ""
        'objMemberSearch.ShowDialog(Me)
        'If objMemberSearch.strMemberNo <> "" Then
        '    txtIntroNo.Text = objMemberSearch.strMemberNo
        'End If
        'objMemberSearch.Dispose()


        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            txtIntroNo.Text = objCustomerList.strCustomerID
        End If
        objCustomerList.Dispose()
    End Sub

    Private Sub cmbSchemeType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSchemeType.LostFocus
        objFDAccount.SchemeCode = cmbSchemeType.SelectedValue
        If objFDAccount.fnCheckScheme() Then
            dtMasterData = objFDAccount.FDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                bolCumulative = True
                objFDAccount.FDType = "C"
                txtFDDays.BeforeDecimal = 3
                txtFDDays.MaxValue = 365
                txtFDDays.Enabled = True
                txtFDYears.ResetText()
                txtFDMonths.ResetText()
                txtFDDays.ResetText()
            Else
                bolCumulative = False
                objFDAccount.FDType = "N"
                txtFDDays.BeforeDecimal = 3
                txtFDDays.MaxValue = 365
                txtFDDays.Enabled = True
                txtFDYears.ResetText()
                txtFDMonths.ResetText()
                txtFDDays.ResetText()
            End If
            bolMonth = IIf(dtMasterData.Rows(0).Item("CalType") = "M", True, False)

            cmbFDType.SelectedItem = dtMasterData.Rows(0).Item("IntPostingPrd")
        Else
            MsgBox("Load failed due to internal error", MsgBoxStyle.Exclamation)
        End If

        If cmbFDType.SelectedIndex <> 0 Then
            Panel2.Enabled = True
            dtpFDDate.Focus()
        Else
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub chkFundTransfer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFundTransfer.CheckedChanged
        Dim objDT As DataTable

        If chkFundTransfer.Checked = True Then
            Panel3.Enabled = True

            Dim objAccountSelection As New frmAccountSelection
            objAccountSelection.ShowDialog(Me)
            txtAccNo.Text = objAccountSelection.strAccountNo
            objAccountSelection.Dispose()
            txtFDAmount.ReadOnly = True

            Dim objCA As New clsCurrentAccount
            If txtAccNo.Text <> String.Empty Then
                sbloaddetails()
            End If

        ElseIf chkFundTransfer.Checked = False Then
            Panel3.Enabled = False
            txtTransFund.ResetText()
            txtFDAmount.ReadOnly = False
            lblAvalBal.ResetText()
            Label42.Text = "SB No. :"
            lblAType.Text = "Amount"
        End If


    End Sub

    Private Sub txtTransFund_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransFund.TextChanged
        txtFDAmount.Text = Val(txtTransFund.Text)
    End Sub

    Private Sub txtTransFund_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransFund.LostFocus

        Dim strType As String
        strType = Mid(txtAccNo.Text, 1, 2)
        Select Case strType
            Case "SB"
                fnCheckSBBalance()
            Case "CA"
                fnCheakCABalance()
        End Select



    End Sub

    Private Function fnCheckSBBalance() As Boolean
        ''Check available balance in account
        If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
            If objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") < Val(txtTransFund.Text) Then
                MsgBox("Low balance in the account,please check account", MsgBoxStyle.Exclamation, Me.Text)
                txtTransFund.Focus()
                Return False
            ElseIf objSavingsBank.fnGetMasterSetting() Then
                If objSavingsBank.SBMasterTable.Rows(0).Item("SBminAmount") > (objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") - Val(txtTransFund.Text)) Then
                    MsgBox("Available balance is less than minimum amount for account holder", MsgBoxStyle.Exclamation, Me.Text)
                    txtTransFund.Focus()
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        End If
    End Function
    Private Function fnCheakCABalance() As Boolean

        If objCurrentAccount.fnGetCAccountDetails(txtAccNo.Text) Then
            dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
            dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
            If Val(txtTransFund.Text) > Val(dblAvalAmount) + Val(dblOverDrawLimit) Then
                MsgBox("Low balance in the account,please check account", MsgBoxStyle.Exclamation, Me.Text)
                txtTransFund.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function

    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        Dim intCout As Integer = 0
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                txtFDAccountNo.Text = "FD"
                intCout = 3
            Case "ENNVY"
                txtFDAccountNo.Text = "ENNVY"
                intCout = 6
            Case "SCC"
                txtFDAccountNo.Text = "SCC"
                intCout = 4
        End Select
        nMode = CTAdd

        If txtFDAccountNo.Text <> String.Empty Then
            Dim Temp As String
            Dim TempNewNo As String = Mid(objFDAccount.fnGetNewFDNo(cmbDepositType.Text), intCout, 8)
            If TempNewNo = "" Then
                TempNewNo = 1
            Else
                TempNewNo += 1
            End If
            If TempNewNo < 99999 Then
                Temp = cmbDepositType.Text & String.Format("{0:00000}", CInt(TempNewNo))
                txtFDAccountNo.Text = Temp
                txtFDAccountNo.Focus()
            Else
                MsgBox("FD number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFDAccountNo.KeyPress
        If txtFDAccountNo.Text = cmbDepositType.SelectedItem Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFDAccountNo.KeyDown
        If txtFDAccountNo.Text = cmbDepositType.SelectedItem Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.Delete Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFDAccountNo_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAccountNo.TextChanged
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                If txtFDAccountNo.Text.StartsWith("FD") = False Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
            Case "ENNVY"
                If txtFDAccountNo.Text.StartsWith("ENNVY") = False Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
            Case "SCC"
                If txtFDAccountNo.Text.StartsWith("SCC") = False Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
        End Select
    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSearch.Click
        Dim objSBSearch As New frmSBAccSearch
        objSBSearch.strSBAccountNo = ""
        objSBSearch.ShowDialog(Me)
        If objSBSearch.strSBAccountNo <> "" Then

            sbClear()
            objSBSearch.Dispose()
        End If
    End Sub

    Private Sub cmbPeriod_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPeriod.MouseEnter

    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged

        If cmbPeriod.SelectedItem = "As Scheme Period" Then
            bolCumulative = False
            'objFDAccount.FDType = "N"
        Else
            objFDAccount.SchemeCode = cmbSchemeType.SelectedValue
            If objFDAccount.fnCheckScheme() Then
                dtMasterData = objFDAccount.FDMasterDetailTbl
                If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                    bolCumulative = True
                    objFDAccount.FDType = "C"
                Else
                    bolCumulative = False
                    objFDAccount.FDType = "N"
                End If

            End If
        End If


        txtFDAmount.Focus()
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) Then
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                Dim ObjfrmFDPayments As New frmFDProvision
                ObjfrmFDPayments.txtFDAccountNo.Text = txtFDAccountNo.Text
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "SCC"
                End Select
                ObjfrmFDPayments.cmbSchemeType.SelectedValue = cmbSchemeType.SelectedValue
                ObjfrmFDPayments.ShowDialog(Me)
            Else
                MsgBox("Account is already closed", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub NewButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton4.Click
        Dim objDElete As New frmFDDelete
        'objDElete.MdiParent = Me
        objDElete.Show()
        objDElete = Nothing

    End Sub
    Private Sub chkCorrection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCorrection.CheckedChanged
        If chkCorrection.Checked = True Then
            Correction.Enabled = True
            txtCInterest.Visible = True
            lblCInterest.Visible = True
            txtCInterest.Text = Val(txtFDIntAmount.Text)
        Else
            Correction.Enabled = False
            chkAdd.Checked = False
            chkSubtract.Checked = False
            txtCorrectionAmount.ResetText()
            txtCInterest.ResetText()
            txtCInterest.Visible = False
            lblCInterest.Visible = False
        End If
    End Sub

    Private Sub chkAdd_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAdd.CheckedChanged
        If chkAdd.Checked = True Then
            chkSubtract.Checked = False
            txtCorrectionAmount.ResetText()
        End If
    End Sub

    Private Sub chkSubtract_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSubtract.CheckedChanged
        If chkSubtract.Checked = True Then
            chkAdd.Checked = False
            txtCorrectionAmount.ResetText()
        End If
    End Sub

    Private Sub txtCorrectionAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorrectionAmount.GotFocus
        If chkAdd.Checked = False And chkSubtract.Checked = False Then
            chkAdd.Focus()
            MsgBox("Select correction type addition or subtraction", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtCorrectionAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorrectionAmount.TextChanged

        Dim dblAmt As Double = Val(txtFDIntAmount.Text)

        If chkAdd.Checked = True Then
            txtFDMatAmount.ResetText()
            txtCInterest.Text = dblAmt + Val(txtCorrectionAmount.Text)
            txtFDMatAmount.Text = Val(txtCInterest.Text) + Val(txtFDAmount.Text)
        ElseIf chkSubtract.Checked = True Then
            txtCInterest.Text = dblAmt - Val(txtCorrectionAmount.Text)
            txtFDMatAmount.Text = Val(txtCInterest.Text) + Val(txtFDAmount.Text)
        Else
            txtFDMatAmount.Text = Val(dblAmt) + Val(txtFDAmount.Text)
        End If


    End Sub

    Private Sub btnTransafer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransafer.Click

        Dim objAccountSelection As New frmAccountSelection
        objAccountSelection.ShowDialog(Me)
        txtTransferAccount.Text = objAccountSelection.strAccountNo
        objAccountSelection.Dispose()

    End Sub


    Private Sub BTMMethod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMMethod.Click
        If BTMMethod.Checked = True Then
            txtFDDays.Visible = True
        ElseIf BTMMethod.Checked = False Then
            txtFDDays.Visible = False
        End If
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.TextChanged
        txtTransferAccount.Text = txtAccNo.Text
    End Sub

    Private Sub dtpNextDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNextDate.ValueChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cmbSchemeType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSchemeType.SelectedIndexChanged

    End Sub
End Class

