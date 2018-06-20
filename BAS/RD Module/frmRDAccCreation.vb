#Region "Import Statements"
Imports System.IO
Imports System.Math
#End Region

Public Class frmRDAccCreation
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objRDAccount As New clsRDAccount
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim strAccNo As String
    Dim strAccName As String
    Dim dtMasterData As DataTable
    Dim datRDDate As Date
    'Dim objFDAccount As New clsFDAccount

    Dim dblTotalInt As Double = 0
    Dim dblTotalPrincipal As Double = 0
    Dim dtInterest As New DataTable

    Dim TempSubdays As Integer = 0
    Dim TempSubMonth As Integer = 0
    Dim TempTotalDays As Integer = 0
    Dim tempNOM As Integer = 0
    Dim timeTemp As Date
    Dim bolTemp As Boolean = True
    Dim datFDDate As Date
    Dim bolVisible As Boolean
    Dim bolCumulative As Boolean = False
    Dim bolMonth As Boolean = False
    Dim objSavingsBank As New clsSavingsBank
    Dim dblAvalAmount As Double
    Dim objCurrentAccount As New clsCurrentAccount
    Dim dblOverDrawLimit As Double
    Dim dblCalIntrest As Double
    Dim dblTempInt As Double
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtpNextDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rdbSYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSNo As System.Windows.Forms.RadioButton

    Dim objPerson As New clsPerson

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSBAccDetails As System.Windows.Forms.TabPage
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents btnLoadSign As BankControls.NewButton
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents txtPresAddress As BankControls.TextControl
    Friend WithEvents txtPhoneNo As BankControls.NumericControl
    Friend WithEvents txtMobileNo As BankControls.NumericControl
    Friend WithEvents txtPermAddress As BankControls.TextControl
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents txtIntroAccNo As BankControls.TextControl
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbOpMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents grpFDDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAType As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As BankControls.NewButton
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents txtRDAmount As BankControls.NumericControl
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtIntAmount As BankControls.NumericControl
    Friend WithEvents txtMatAmount As BankControls.NumericControl
    Friend WithEvents Correction As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkAdd As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubtract As System.Windows.Forms.CheckBox
    Friend WithEvents txtCorrectionAmount As BankControls.NumericControl
    Friend WithEvents chkCorrection As System.Windows.Forms.CheckBox
    Friend WithEvents grpRDType As System.Windows.Forms.GroupBox
    Friend WithEvents lblCInterest As System.Windows.Forms.Label
    Friend WithEvents txtCInterest As BankControls.NumericControl
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbAccStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtYears As BankControls.NumericControl
    Friend WithEvents txtDays As BankControls.NumericControl
    Friend WithEvents txtMonths As BankControls.NumericControl
    Friend WithEvents txtAvailBal As BankControls.NumericControl
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents btnNewMember As BankControls.NewButton
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents txtEducation As BankControls.TextControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtOffAddress As BankControls.TextControl
    Friend WithEvents txtOfficeNo As BankControls.NumericControl
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDAccCreation))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.Label29 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.rdbSYes = New System.Windows.Forms.RadioButton
        Me.rdbSNo = New System.Windows.Forms.RadioButton
        Me.txtOfficeNo = New BankControls.NumericControl
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtOffAddress = New BankControls.TextControl
        Me.txtEducation = New BankControls.TextControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnNewMember = New BankControls.NewButton
        Me.Label35 = New System.Windows.Forms.Label
        Me.cmbAccStatus = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.NewButton4 = New BankControls.NewButton
        Me.txtIntroAccNo = New BankControls.TextControl
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbOpMode = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtFatherName = New BankControls.TextControl
        Me.chkSame = New System.Windows.Forms.CheckBox
        Me.cmbCaste = New System.Windows.Forms.ComboBox
        Me.cmbReligion = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbOccupation = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtAge = New BankControls.NumericControl
        Me.txtPresAddress = New BankControls.TextControl
        Me.txtPhoneNo = New BankControls.NumericControl
        Me.txtMobileNo = New BankControls.NumericControl
        Me.txtPermAddress = New BankControls.TextControl
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.tbSBAccDetails = New System.Windows.Forms.TabPage
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Total_Amt = New System.Windows.Forms.ColumnHeader
        Me.grpFDDetails = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCalculate = New BankControls.NewButton
        Me.Label28 = New System.Windows.Forms.Label
        Me.dtpNextDate = New System.Windows.Forms.DateTimePicker
        Me.lblCInterest = New System.Windows.Forms.Label
        Me.txtCInterest = New BankControls.NumericControl
        Me.Correction = New System.Windows.Forms.GroupBox
        Me.txtCorrectionAmount = New BankControls.NumericControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.chkSubtract = New System.Windows.Forms.CheckBox
        Me.chkAdd = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkCorrection = New System.Windows.Forms.CheckBox
        Me.txtRDAmount = New BankControls.NumericControl
        Me.lblAType = New System.Windows.Forms.Label
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.txtDays = New BankControls.NumericControl
        Me.txtMonths = New BankControls.NumericControl
        Me.txtYears = New BankControls.NumericControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.txtIntAmount = New BankControls.NumericControl
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.txtMatAmount = New BankControls.NumericControl
        Me.txtAvailBal = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.grpRDType = New System.Windows.Forms.GroupBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.txtRemarks = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnLoadPhoto = New BankControls.NewButton
        Me.btnCancelPhoto = New BankControls.NewButton
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.lblSignature = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnCancelSign = New BankControls.NewButton
        Me.btnLoadSign = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.NewButton2 = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.btnWithdraw = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton6 = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbSBAccDetails.SuspendLayout()
        Me.grpFDDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Correction.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.grpRDType.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbSBAccDetails)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(8, 88)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 484)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabStop = False
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPersonal.Controls.Add(Me.Label29)
        Me.tbPersonal.Controls.Add(Me.Panel5)
        Me.tbPersonal.Controls.Add(Me.txtOfficeNo)
        Me.tbPersonal.Controls.Add(Me.Label33)
        Me.tbPersonal.Controls.Add(Me.Label24)
        Me.tbPersonal.Controls.Add(Me.txtOffAddress)
        Me.tbPersonal.Controls.Add(Me.txtEducation)
        Me.tbPersonal.Controls.Add(Me.Label22)
        Me.tbPersonal.Controls.Add(Me.btnNewMember)
        Me.tbPersonal.Controls.Add(Me.Label35)
        Me.tbPersonal.Controls.Add(Me.cmbAccStatus)
        Me.tbPersonal.Controls.Add(Me.Label27)
        Me.tbPersonal.Controls.Add(Me.txtReceiptNo)
        Me.tbPersonal.Controls.Add(Me.NewButton4)
        Me.tbPersonal.Controls.Add(Me.txtIntroAccNo)
        Me.tbPersonal.Controls.Add(Me.cmbAccType)
        Me.tbPersonal.Controls.Add(Me.Label19)
        Me.tbPersonal.Controls.Add(Me.Label20)
        Me.tbPersonal.Controls.Add(Me.Label21)
        Me.tbPersonal.Controls.Add(Me.cmbOpMode)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.Label15)
        Me.tbPersonal.Controls.Add(Me.Panel2)
        Me.tbPersonal.Controls.Add(Me.Panel3)
        Me.tbPersonal.Controls.Add(Me.Label16)
        Me.tbPersonal.Controls.Add(Me.txtFatherName)
        Me.tbPersonal.Controls.Add(Me.chkSame)
        Me.tbPersonal.Controls.Add(Me.cmbCaste)
        Me.tbPersonal.Controls.Add(Me.cmbReligion)
        Me.tbPersonal.Controls.Add(Me.Label12)
        Me.tbPersonal.Controls.Add(Me.dtpDOB)
        Me.tbPersonal.Controls.Add(Me.Label5)
        Me.tbPersonal.Controls.Add(Me.Label6)
        Me.tbPersonal.Controls.Add(Me.Label7)
        Me.tbPersonal.Controls.Add(Me.Label8)
        Me.tbPersonal.Controls.Add(Me.Label9)
        Me.tbPersonal.Controls.Add(Me.Label10)
        Me.tbPersonal.Controls.Add(Me.Label14)
        Me.tbPersonal.Controls.Add(Me.cmbOccupation)
        Me.tbPersonal.Controls.Add(Me.Label25)
        Me.tbPersonal.Controls.Add(Me.Label26)
        Me.tbPersonal.Controls.Add(Me.txtAge)
        Me.tbPersonal.Controls.Add(Me.txtPresAddress)
        Me.tbPersonal.Controls.Add(Me.txtPhoneNo)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo)
        Me.tbPersonal.Controls.Add(Me.txtPermAddress)
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(760, 455)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(24, 427)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 16)
        Me.Label29.TabIndex = 154
        Me.Label29.Text = "senior citizen :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.rdbSYes)
        Me.Panel5.Controls.Add(Me.rdbSNo)
        Me.Panel5.Enabled = False
        Me.Panel5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(169, 424)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(168, 27)
        Me.Panel5.TabIndex = 153
        '
        'rdbSYes
        '
        Me.rdbSYes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSYes.Location = New System.Drawing.Point(3, 4)
        Me.rdbSYes.Name = "rdbSYes"
        Me.rdbSYes.Size = New System.Drawing.Size(72, 16)
        Me.rdbSYes.TabIndex = 19
        Me.rdbSYes.Text = "Yes"
        '
        'rdbSNo
        '
        Me.rdbSNo.Checked = True
        Me.rdbSNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSNo.Location = New System.Drawing.Point(88, 4)
        Me.rdbSNo.Name = "rdbSNo"
        Me.rdbSNo.Size = New System.Drawing.Size(72, 16)
        Me.rdbSNo.TabIndex = 20
        Me.rdbSNo.TabStop = True
        Me.rdbSNo.Text = "No"
        '
        'txtOfficeNo
        '
        Me.txtOfficeNo.AfterDecimal = 0
        Me.txtOfficeNo.BeforeDecimal = 20
        Me.txtOfficeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeNo.Location = New System.Drawing.Point(544, 352)
        Me.txtOfficeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeNo.MaxLength = 20
        Me.txtOfficeNo.MaxValue = 0
        Me.txtOfficeNo.MinValue = 0
        Me.txtOfficeNo.Name = "txtOfficeNo"
        Me.txtOfficeNo.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeNo.TabIndex = 31
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(384, 352)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(85, 16)
        Me.Label33.TabIndex = 143
        Me.Label33.Text = "Office No. :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(384, 288)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 16)
        Me.Label24.TabIndex = 141
        Me.Label24.Text = "Office Address :"
        '
        'txtOffAddress
        '
        Me.txtOffAddress.AlphaNumeric = True
        Me.txtOffAddress.BlankSpace = True
        Me.txtOffAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOffAddress.Location = New System.Drawing.Point(544, 280)
        Me.txtOffAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOffAddress.Mandatory = False
        Me.txtOffAddress.MaxLength = 255
        Me.txtOffAddress.Multiline = True
        Me.txtOffAddress.Name = "txtOffAddress"
        Me.txtOffAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtOffAddress.SpecialChar = True
        Me.txtOffAddress.TabIndex = 30
        '
        'txtEducation
        '
        Me.txtEducation.AlphaNumeric = True
        Me.txtEducation.BlankSpace = False
        Me.txtEducation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEducation.Location = New System.Drawing.Point(168, 272)
        Me.txtEducation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEducation.Mandatory = False
        Me.txtEducation.MaxLength = 50
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(168, 23)
        Me.txtEducation.SpecialChar = True
        Me.txtEducation.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 272)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 139
        Me.Label22.Text = "Education : "
        '
        'btnNewMember
        '
        Me.btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMember.ForeColor = System.Drawing.Color.Black
        Me.btnNewMember.GotFocusColour = System.Drawing.Color.OliveDrab
        Me.btnNewMember.Image = CType(resources.GetObject("btnNewMember.Image"), System.Drawing.Image)
        Me.btnNewMember.Location = New System.Drawing.Point(344, 8)
        Me.btnNewMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(32, 24)
        Me.btnNewMember.TabIndex = 6
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(24, 398)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(138, 16)
        Me.Label35.TabIndex = 135
        Me.Label35.Text = "Account Status  :  "
        '
        'cmbAccStatus
        '
        Me.cmbAccStatus.DisplayMember = "A,S,C"
        Me.cmbAccStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccStatus.Items.AddRange(New Object() {"Active", "Suspended", "Closed"})
        Me.cmbAccStatus.Location = New System.Drawing.Point(168, 398)
        Me.cmbAccStatus.Name = "cmbAccStatus"
        Me.cmbAccStatus.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccStatus.TabIndex = 23
        Me.cmbAccStatus.ValueMember = "A,S,C"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(392, 384)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 16)
        Me.Label27.TabIndex = 136
        Me.Label27.Text = "Receipt No. :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(544, 384)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(120, 23)
        Me.txtReceiptNo.TabIndex = 32
        '
        'NewButton4
        '
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.ForeColor = System.Drawing.Color.Black
        Me.NewButton4.GotFocusColour = System.Drawing.Color.OliveDrab
        Me.NewButton4.Image = CType(resources.GetObject("NewButton4.Image"), System.Drawing.Image)
        Me.NewButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton4.Location = New System.Drawing.Point(344, 304)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(24, 24)
        Me.NewButton4.TabIndex = 20
        '
        'txtIntroAccNo
        '
        Me.txtIntroAccNo.AlphaNumeric = False
        Me.txtIntroAccNo.BlankSpace = True
        Me.txtIntroAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntroAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntroAccNo.Location = New System.Drawing.Point(168, 304)
        Me.txtIntroAccNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtIntroAccNo.Mandatory = False
        Me.txtIntroAccNo.MaxLength = 30
        Me.txtIntroAccNo.Name = "txtIntroAccNo"
        Me.txtIntroAccNo.Size = New System.Drawing.Size(168, 23)
        Me.txtIntroAccNo.SpecialChar = True
        Me.txtIntroAccNo.TabIndex = 19
        '
        'cmbAccType
        '
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(168, 334)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccType.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 334)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 16)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Account Type  :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 304)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(125, 16)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "Introducer's No. :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 366)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 16)
        Me.Label21.TabIndex = 109
        Me.Label21.Text = "Operational Mode :"
        '
        'cmbOpMode
        '
        Me.cmbOpMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOpMode.Items.AddRange(New Object() {"Together", "Either"})
        Me.cmbOpMode.Location = New System.Drawing.Point(168, 366)
        Me.cmbOpMode.Name = "cmbOpMode"
        Me.cmbOpMode.Size = New System.Drawing.Size(168, 24)
        Me.cmbOpMode.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 16)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Husband Name "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(24, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Father / "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(168, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
        Me.Panel2.TabIndex = 13
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 7)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 14
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 7)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 15
        Me.rdbFemale.Text = "Female"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel3.Controls.Add(Me.rdbMajor)
        Me.Panel3.Controls.Add(Me.rdbMinor)
        Me.Panel3.Enabled = False
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(168, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 32)
        Me.Panel3.TabIndex = 10
        '
        'rdbMajor
        '
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 7)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 11
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.rdbMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 7)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 12
        Me.rdbMinor.Text = "Minor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 16)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Age Status  :"
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.BlankSpace = False
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(168, 40)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 35
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 7
        '
        'chkSame
        '
        Me.chkSame.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(544, 120)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(200, 24)
        Me.chkSame.TabIndex = 26
        Me.chkSame.Text = "same as permanent address"
        Me.chkSame.UseVisualStyleBackColor = False
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.ItemHeight = 16
        Me.cmbCaste.Location = New System.Drawing.Point(168, 240)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 17
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.ItemHeight = 16
        Me.cmbReligion.Location = New System.Drawing.Point(168, 208)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(384, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Present Address :"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(168, 72)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtpDOB.TabIndex = 8
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(384, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Permanent Address  :"
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.ItemHeight = 16
        Me.cmbOccupation.Location = New System.Drawing.Point(544, 16)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 24
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(384, 248)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(384, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 16)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No. :"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(168, 104)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 23)
        Me.txtAge.TabIndex = 9
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(544, 144)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 27
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(544, 248)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.TabIndex = 29
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(544, 216)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.TabIndex = 28
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(544, 48)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 25
        '
        'btnMemSearch
        '
        Me.btnMemSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.OliveDrab
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(312, 8)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 5
        Me.btnMemSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(168, 8)
        Me.txtCustomerID.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(136, 23)
        Me.txtCustomerID.SpecialChar = False
        Me.txtCustomerID.TabIndex = 4
        Me.txtCustomerID.Text = "CID"
        '
        'tbSBAccDetails
        '
        Me.tbSBAccDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tbSBAccDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSBAccDetails.Controls.Add(Me.lvInterest)
        Me.tbSBAccDetails.Controls.Add(Me.grpFDDetails)
        Me.tbSBAccDetails.Controls.Add(Me.grpRDType)
        Me.tbSBAccDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.tbSBAccDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbSBAccDetails.Name = "tbSBAccDetails"
        Me.tbSBAccDetails.Size = New System.Drawing.Size(760, 455)
        Me.tbSBAccDetails.TabIndex = 3
        Me.tbSBAccDetails.Text = "RD Account Details"
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.White
        Me.lvInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Int_Amt, Me.Int_Date, Me.Total_Amt})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.HideSelection = False
        Me.lvInterest.Location = New System.Drawing.Point(8, 304)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(744, 144)
        Me.lvInterest.TabIndex = 13
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 84
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Int_Amt.Width = 157
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Int_Date.Width = 202
        '
        'Total_Amt
        '
        Me.Total_Amt.Text = "Total Amount"
        Me.Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total_Amt.Width = 194
        '
        'grpFDDetails
        '
        Me.grpFDDetails.Controls.Add(Me.Panel1)
        Me.grpFDDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFDDetails.ForeColor = System.Drawing.Color.Black
        Me.grpFDDetails.Location = New System.Drawing.Point(8, 70)
        Me.grpFDDetails.Name = "grpFDDetails"
        Me.grpFDDetails.Size = New System.Drawing.Size(744, 226)
        Me.grpFDDetails.TabIndex = 3
        Me.grpFDDetails.TabStop = False
        Me.grpFDDetails.Text = "Deposit Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.dtpNextDate)
        Me.Panel1.Controls.Add(Me.lblCInterest)
        Me.Panel1.Controls.Add(Me.txtCInterest)
        Me.Panel1.Controls.Add(Me.Correction)
        Me.Panel1.Controls.Add(Me.txtRDAmount)
        Me.Panel1.Controls.Add(Me.lblAType)
        Me.Panel1.Controls.Add(Me.dtpAccDate)
        Me.Panel1.Controls.Add(Me.txtDays)
        Me.Panel1.Controls.Add(Me.txtMonths)
        Me.Panel1.Controls.Add(Me.txtYears)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.txtROI)
        Me.Panel1.Controls.Add(Me.txtIntAmount)
        Me.Panel1.Controls.Add(Me.dtpMaturityDate)
        Me.Panel1.Controls.Add(Me.txtMatAmount)
        Me.Panel1.Controls.Add(Me.txtAvailBal)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Enabled = False
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(8, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 204)
        Me.Panel1.TabIndex = 3
        Me.Panel1.TabStop = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(73, 119)
        Me.btnCalculate.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 24)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(5, 11)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(131, 21)
        Me.Label28.TabIndex = 146
        Me.Label28.Text = "Next Quater Date:"
        '
        'dtpNextDate
        '
        Me.dtpNextDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpNextDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNextDate.Location = New System.Drawing.Point(135, 10)
        Me.dtpNextDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpNextDate.Name = "dtpNextDate"
        Me.dtpNextDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpNextDate.TabIndex = 145
        Me.dtpNextDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'lblCInterest
        '
        Me.lblCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCInterest.ForeColor = System.Drawing.Color.Black
        Me.lblCInterest.Location = New System.Drawing.Point(480, 77)
        Me.lblCInterest.Name = "lblCInterest"
        Me.lblCInterest.Size = New System.Drawing.Size(80, 40)
        Me.lblCInterest.TabIndex = 138
        Me.lblCInterest.Text = "Corrected Interest:"
        Me.lblCInterest.Visible = False
        '
        'txtCInterest
        '
        Me.txtCInterest.AfterDecimal = 2
        Me.txtCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtCInterest.BeforeDecimal = 8
        Me.txtCInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCInterest.Enabled = False
        Me.txtCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCInterest.Location = New System.Drawing.Point(584, 86)
        Me.txtCInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCInterest.MaxLength = 10
        Me.txtCInterest.MaxValue = 0
        Me.txtCInterest.MinValue = 0
        Me.txtCInterest.Name = "txtCInterest"
        Me.txtCInterest.ReadOnly = True
        Me.txtCInterest.Size = New System.Drawing.Size(136, 23)
        Me.txtCInterest.TabIndex = 139
        Me.txtCInterest.TabStop = False
        Me.txtCInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCInterest.Visible = False
        '
        'Correction
        '
        Me.Correction.Controls.Add(Me.txtCorrectionAmount)
        Me.Correction.Controls.Add(Me.Panel4)
        Me.Correction.Controls.Add(Me.Label11)
        Me.Correction.Controls.Add(Me.chkCorrection)
        Me.Correction.Enabled = False
        Me.Correction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correction.Location = New System.Drawing.Point(140, 149)
        Me.Correction.Name = "Correction"
        Me.Correction.Size = New System.Drawing.Size(336, 48)
        Me.Correction.TabIndex = 136
        Me.Correction.TabStop = False
        Me.Correction.Text = "Correction"
        Me.Correction.Visible = False
        '
        'txtCorrectionAmount
        '
        Me.txtCorrectionAmount.AfterDecimal = 2
        Me.txtCorrectionAmount.BeforeDecimal = 10
        Me.txtCorrectionAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectionAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCorrectionAmount.Location = New System.Drawing.Point(200, 32)
        Me.txtCorrectionAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCorrectionAmount.MaxValue = 0
        Me.txtCorrectionAmount.MinValue = 0
        Me.txtCorrectionAmount.Name = "txtCorrectionAmount"
        Me.txtCorrectionAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtCorrectionAmount.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel4.Controls.Add(Me.chkSubtract)
        Me.Panel4.Controls.Add(Me.chkAdd)
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(8, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(152, 32)
        Me.Panel4.TabIndex = 13
        '
        'chkSubtract
        '
        Me.chkSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkSubtract.Location = New System.Drawing.Point(64, 8)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(80, 16)
        Me.chkSubtract.TabIndex = 13
        Me.chkSubtract.Text = "Subtract"
        '
        'chkAdd
        '
        Me.chkAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkAdd.Location = New System.Drawing.Point(8, 8)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(48, 16)
        Me.chkAdd.TabIndex = 12
        Me.chkAdd.Text = "Add"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(200, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Amount :"
        '
        'chkCorrection
        '
        Me.chkCorrection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorrection.Location = New System.Drawing.Point(8, 0)
        Me.chkCorrection.Name = "chkCorrection"
        Me.chkCorrection.Size = New System.Drawing.Size(96, 16)
        Me.chkCorrection.TabIndex = 11
        Me.chkCorrection.Text = "Correction"
        '
        'txtRDAmount
        '
        Me.txtRDAmount.AfterDecimal = 2
        Me.txtRDAmount.BackColor = System.Drawing.Color.White
        Me.txtRDAmount.BeforeDecimal = 8
        Me.txtRDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDAmount.Location = New System.Drawing.Point(135, 82)
        Me.txtRDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRDAmount.MaxLength = 11
        Me.txtRDAmount.MaxValue = 0
        Me.txtRDAmount.MinValue = 0
        Me.txtRDAmount.Name = "txtRDAmount"
        Me.txtRDAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtRDAmount.TabIndex = 8
        Me.txtRDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAType
        '
        Me.lblAType.AutoSize = True
        Me.lblAType.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblAType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAType.ForeColor = System.Drawing.Color.Black
        Me.lblAType.Location = New System.Drawing.Point(8, 87)
        Me.lblAType.Name = "lblAType"
        Me.lblAType.Size = New System.Drawing.Size(91, 16)
        Me.lblAType.TabIndex = 135
        Me.lblAType.Text = "RD Amount :"
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAccDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(135, 49)
        Me.dtpAccDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpAccDate.TabIndex = 4
        Me.dtpAccDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'txtDays
        '
        Me.txtDays.AfterDecimal = 0
        Me.txtDays.BeforeDecimal = 2
        Me.txtDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDays.Location = New System.Drawing.Point(432, 53)
        Me.txtDays.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtDays.MaxLength = 2
        Me.txtDays.MaxValue = 0
        Me.txtDays.MinValue = 0
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(32, 23)
        Me.txtDays.TabIndex = 7
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDays.Visible = False
        '
        'txtMonths
        '
        Me.txtMonths.AfterDecimal = 0
        Me.txtMonths.BeforeDecimal = 2
        Me.txtMonths.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonths.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMonths.Location = New System.Drawing.Point(384, 53)
        Me.txtMonths.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtMonths.MaxLength = 2
        Me.txtMonths.MaxValue = 11
        Me.txtMonths.MinValue = 0
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(32, 23)
        Me.txtMonths.TabIndex = 6
        Me.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYears
        '
        Me.txtYears.AfterDecimal = 0
        Me.txtYears.BeforeDecimal = 2
        Me.txtYears.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYears.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtYears.Location = New System.Drawing.Point(336, 53)
        Me.txtYears.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtYears.MaxLength = 2
        Me.txtYears.MaxValue = 0
        Me.txtYears.MinValue = 0
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(32, 23)
        Me.txtYears.TabIndex = 5
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(480, 114)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 32)
        Me.Label38.TabIndex = 128
        Me.Label38.Text = "Maturity Amount :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(480, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Interest Amt :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(468, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 16)
        Me.Label23.TabIndex = 126
        Me.Label23.Text = "Maturity Date : "
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(272, 87)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 16)
        Me.Label36.TabIndex = 125
        Me.Label36.Text = "ROI : "
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(440, 37)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(17, 16)
        Me.Label37.TabIndex = 124
        Me.Label37.Text = "D"
        Me.Label37.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(392, 37)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(19, 16)
        Me.Label39.TabIndex = 123
        Me.Label39.Text = "M"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(344, 37)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(17, 16)
        Me.Label40.TabIndex = 122
        Me.Label40.Text = "Y"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(272, 53)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(59, 16)
        Me.Label41.TabIndex = 121
        Me.Label41.Text = "Period :"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(8, 54)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(50, 16)
        Me.Label42.TabIndex = 119
        Me.Label42.Text = "Date :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(336, 87)
        Me.txtROI.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(128, 23)
        Me.txtROI.TabIndex = 115
        Me.txtROI.TabStop = False
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIntAmount
        '
        Me.txtIntAmount.AfterDecimal = 2
        Me.txtIntAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtIntAmount.BeforeDecimal = 8
        Me.txtIntAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntAmount.Enabled = False
        Me.txtIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntAmount.Location = New System.Drawing.Point(584, 52)
        Me.txtIntAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtIntAmount.MaxLength = 10
        Me.txtIntAmount.MaxValue = 0
        Me.txtIntAmount.MinValue = 0
        Me.txtIntAmount.Name = "txtIntAmount"
        Me.txtIntAmount.ReadOnly = True
        Me.txtIntAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtIntAmount.TabIndex = 131
        Me.txtIntAmount.TabStop = False
        Me.txtIntAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(584, 12)
        Me.dtpMaturityDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpMaturityDate.TabIndex = 11
        Me.dtpMaturityDate.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'txtMatAmount
        '
        Me.txtMatAmount.AfterDecimal = 2
        Me.txtMatAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtMatAmount.BeforeDecimal = 8
        Me.txtMatAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatAmount.Enabled = False
        Me.txtMatAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtMatAmount.Location = New System.Drawing.Point(584, 122)
        Me.txtMatAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtMatAmount.MaxLength = 10
        Me.txtMatAmount.MaxValue = 0
        Me.txtMatAmount.MinValue = 0
        Me.txtMatAmount.Name = "txtMatAmount"
        Me.txtMatAmount.ReadOnly = True
        Me.txtMatAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtMatAmount.TabIndex = 130
        Me.txtMatAmount.TabStop = False
        Me.txtMatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAvailBal
        '
        Me.txtAvailBal.AfterDecimal = 2
        Me.txtAvailBal.BeforeDecimal = 10
        Me.txtAvailBal.Enabled = False
        Me.txtAvailBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailBal.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAvailBal.Location = New System.Drawing.Point(336, 120)
        Me.txtAvailBal.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAvailBal.MaxValue = 0
        Me.txtAvailBal.MinValue = 0
        Me.txtAvailBal.Name = "txtAvailBal"
        Me.txtAvailBal.ReadOnly = True
        Me.txtAvailBal.Size = New System.Drawing.Size(128, 23)
        Me.txtAvailBal.TabIndex = 10
        Me.txtAvailBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAvailBal.Visible = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(200, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 19)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Available Balance : "
        Me.Label18.Visible = False
        '
        'grpRDType
        '
        Me.grpRDType.Controls.Add(Me.Label45)
        Me.grpRDType.Controls.Add(Me.Label46)
        Me.grpRDType.Controls.Add(Me.cmbType)
        Me.grpRDType.Controls.Add(Me.cmbSchemeType)
        Me.grpRDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRDType.ForeColor = System.Drawing.Color.Black
        Me.grpRDType.Location = New System.Drawing.Point(8, 0)
        Me.grpRDType.Name = "grpRDType"
        Me.grpRDType.Size = New System.Drawing.Size(744, 64)
        Me.grpRDType.TabIndex = 3
        Me.grpRDType.TabStop = False
        Me.grpRDType.Text = "Deposit Type"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(501, 27)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(107, 16)
        Me.Label45.TabIndex = 62
        Me.Label45.Text = "Intrest Type : "
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(8, 27)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(109, 16)
        Me.Label46.TabIndex = 61
        Me.Label46.Text = "Scheme Type :"
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Enabled = False
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.Items.AddRange(New Object() {"", "Monthly", "Quarterly", "Half-Yearly", "Yearly"})
        Me.cmbType.Location = New System.Drawing.Point(612, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(116, 24)
        Me.cmbType.TabIndex = 2
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(120, 24)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(375, 24)
        Me.cmbSchemeType.TabIndex = 1
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOthers.Controls.Add(Me.txtRemarks)
        Me.tbOthers.Controls.Add(Me.Label17)
        Me.tbOthers.Controls.Add(Me.btnLoadPhoto)
        Me.tbOthers.Controls.Add(Me.btnCancelPhoto)
        Me.tbOthers.Controls.Add(Me.picSignature)
        Me.tbOthers.Controls.Add(Me.lblSignature)
        Me.tbOthers.Controls.Add(Me.picPhoto)
        Me.tbOthers.Controls.Add(Me.lblPhoto)
        Me.tbOthers.Controls.Add(Me.btnCancelSign)
        Me.tbOthers.Controls.Add(Me.btnLoadSign)
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(760, 455)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(136, 304)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(480, 72)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 52
        Me.txtRemarks.Text = "7"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(48, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Remarks :"
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 232)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 25
        Me.btnLoadPhoto.Text = "Load"
        Me.btnLoadPhoto.UseVisualStyleBackColor = False
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 232)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 26
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(456, 32)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(160, 184)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 51
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(368, 40)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(71, 16)
        Me.lblSignature.TabIndex = 50
        Me.lblSignature.Text = "Signature"
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(136, 32)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 184)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 49
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(72, 36)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(46, 16)
        Me.lblPhoto.TabIndex = 48
        Me.lblPhoto.Text = "Photo"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCancelSign.Location = New System.Drawing.Point(536, 232)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 28
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(456, 232)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 27
        Me.btnLoadSign.Text = "Load"
        Me.btnLoadSign.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtName.Location = New System.Drawing.Point(560, 56)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 128)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(168, 40)
        Me.NewButton2.TabIndex = 0
        Me.NewButton2.Text = "Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton2.UseVisualStyleBackColor = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 168)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 1
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(16, 272)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(168, 40)
        Me.btnWithdraw.TabIndex = 4
        Me.btnWithdraw.Text = "Premature"
        Me.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWithdraw.UseVisualStyleBackColor = False
        Me.btnWithdraw.Visible = False
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 392)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 5
        Me.NewButton5.Text = "View Transaction Log(All)"
        Me.NewButton5.UseVisualStyleBackColor = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(16, 312)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(168, 40)
        Me.btnDeposit.TabIndex = 3
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(560, 580)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 33
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(664, 580)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Account No. :"
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(184, 56)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 7
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.Text = "RD"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.OliveDrab
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(328, 56)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton6)
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NewButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton6.Location = New System.Drawing.Point(16, 432)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(168, 40)
        Me.NewButton6.TabIndex = 8
        Me.NewButton6.Text = "RD Provision"
        Me.NewButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton6.UseVisualStyleBackColor = False
        Me.NewButton6.Visible = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 232)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 7
        Me.NewButton3.Text = "RD Provision"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        Me.NewButton3.Visible = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 352)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 6
        Me.NewButton1.Text = "Provision"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(24, 581)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtAccNo)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 626)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Ivory
        Me.Label32.Location = New System.Drawing.Point(88, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(283, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "New Recurring Deposit Account"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'frmRDAccCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 685)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmRDAccCreation"
        Me.ShowInTaskbar = False
        Me.Text = "RD Account Creation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbSBAccDetails.ResumeLayout(False)
        Me.grpFDDetails.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Correction.ResumeLayout(False)
        Me.Correction.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.grpRDType.ResumeLayout(False)
        Me.grpRDType.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmRDAccCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmRDAccCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmRDAccCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmRDAccCreation)
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
        ' Dim objScheme As New clsFDAccount
        Dim objScheme As New clsRDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.RdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
            cmbSchemeType.SelectedIndex = -1
        End If
        objScheme = Nothing
    End Sub

#End Region

#Region "Photo and Signature Loading"

    Private Sub btnLoadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPhoto.Click
        Dim OfdPic As New OpenFileDialog
        OfdPic.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdPic.ShowDialog() = DialogResult.OK Then
            picPhoto.Image = Image.FromFile(OfdPic.FileName)
        End If
    End Sub

    Private Sub btnCancelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPhoto.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnLoadSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSign.Click
        Dim OfdSign As New OpenFileDialog
        OfdSign.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdSign.ShowDialog() = DialogResult.OK Then
            picSignature.Image = Image.FromFile(OfdSign.FileName)
        End If
    End Sub

    Private Sub btnCancelSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSign.Click
        picSignature.Image = Nothing
    End Sub

#End Region

#Region "Functions "

    Function fnCheck() As Boolean

        If Trim(txtAccNo.Text) = "RD" Then
            MsgBox("Enter account no ", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name ", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf Trim(txtFatherName.Text) = String.Empty Then
            MsgBox("Enter father name ", MsgBoxStyle.Information)
            txtFatherName.Focus()
            Return False
        ElseIf Trim(txtAge.Text) = String.Empty Then
            MsgBox("Enter age ", MsgBoxStyle.Information)
            txtAge.Focus()
            Return False
        ElseIf Trim(txtPermAddress.Text) = String.Empty Then
            MsgBox("Enter address", MsgBoxStyle.Information)
            txtPermAddress.Focus()
            Return False
            'ElseIf Trim(txtAvailBal.Text) = String.Empty Then
            '    MsgBox("Enter available balance", MsgBoxStyle.Information)
            '    Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            '    txtAvailBal.Focus()
            '    Return False
        ElseIf cmbAccType.SelectedIndex = -1 Then
            MsgBox("Select account type", MsgBoxStyle.Information)
            cmbAccType.Focus()
            Return False
        ElseIf cmbOpMode.SelectedIndex = -1 Then
            MsgBox("Select opereation modue", MsgBoxStyle.Information)
            cmbOpMode.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = String.Empty Then
            MsgBox("Enter receipt number", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
        ElseIf (Val(txtYears.Text) = 0 And Val(txtMonths.Text) = 0 And Val(txtDays.Text) = 0) Then
            MsgBox("Please enter period of deposit")
            txtYears.Focus()
            Return False
        ElseIf txtROI.Text = String.Empty Then
            MsgBox("Enter ROI", MsgBoxStyle.Information)
            txtROI.Focus()
            Return False
        ElseIf chkCorrection.Checked = True Then
            If chkAdd.Checked = False And chkSubtract.Checked = False Then
                MsgBox("Please select correction type", MsgBoxStyle.Information)
                chkAdd.Focus()
                Return False
            ElseIf txtCorrectionAmount.Text = "" Then
                MsgBox("Enter correction amount", MsgBoxStyle.Information)
                txtCorrectionAmount.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If

    End Function

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objRDAccount.fnCheckRDAccount(Trim(txtAccNo.Text)) = False Then
            'ADD new Member  (ADD Mode)
            If fnGenerateVoucher(objTrans) Then
                '''Log Entry
                fnLogEntry(pbUserId, "New RDAccount created" & txtAccNo.Text, Date.Now, "New RD Account")
                MessageBox.Show("New RD account created successfully.", "RD Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New RD account creation failed, because of internal error.", "RD Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else
            'Update Details (EDIT Mode)
            If objRDAccount.fnUpdateRDAccount(txtAccNo.Text) Then
                fnLogEntry(pbUserId, "RD updated" & txtAccNo.Text, Date.Now, "Update RD Account")
                MessageBox.Show("RD account updated successfully.", "RD Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("RD account updation failed, because of internal error.", "RD Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function

    Function fnSetData() As Boolean
        Dim intCounter As Integer = 0
        Dim dtRow As DataRow

        ' Person Deatils
        If lngPersonNo <> 0 Then
            objRDAccount.PersonNo = lngPersonNo
        Else
            objRDAccount.PersonNo = objRDAccount.fnGetNewPersonNo()
        End If
        objRDAccount.Name = txtName.Text
        objRDAccount.FatherName = txtFatherName.Text
        objRDAccount.PermAddress = txtPermAddress.Text
        objRDAccount.PresAddress = txtPresAddress.Text
        objRDAccount.PhoneNo = txtPhoneNo.Text
        objRDAccount.MobileNo = txtMobileNo.Text
        objRDAccount.DOB = dtpDOB.Value
        objRDAccount.Age = txtAge.Text
        objRDAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objRDAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objRDAccount.ReligionCode = cmbReligion.SelectedValue
        objRDAccount.CasteCode = cmbCaste.SelectedValue
        objRDAccount.OccupationCode = cmbOccupation.SelectedValue
        ' objRDAccount.Photo = fnGetPhoto()
        objRDAccount.Photo = picPhoto.ImageLocation
        ' objRDAccount.Sign = fnGetSign()
        objRDAccount.Sign = picSignature.ImageLocation
        objRDAccount.Education = txtEducation.Text
        'RD Details

        objRDAccount.RDNo = txtAccNo.Text
        objRDAccount.CustomerNo = txtCustomerID.Text
        objRDAccount.AccDate = dtpAccDate.Value
        objRDAccount.AccBal = Val(txtAvailBal.Text)
        Select Case cmbAccType.SelectedItem
            Case "Single"
                objRDAccount.AccType = "S"
            Case "Joint"
                objRDAccount.AccType = "J"
        End Select
        Select Case cmbOpMode.SelectedItem
            Case "Together"
                objRDAccount.OpMode = "T"
            Case "Either"
                objRDAccount.OpMode = "E"
        End Select
        objRDAccount.IntroSBNo = txtIntroAccNo.Text
        Select Case cmbAccStatus.SelectedItem
            Case "Active"
                objRDAccount.AccStatus = "A"
            Case "Suspended"
                objRDAccount.AccStatus = "S"
            Case "Closed"
                objRDAccount.AccStatus = "C"
        End Select

        objRDAccount.Remarks = txtRemarks.Text
        objRDAccount.ReciptNo = txtReceiptNo.Text
        objRDAccount.RDYears = Val(txtYears.Text)
        objRDAccount.RDMonths = Val(txtMonths.Text)
        objRDAccount.RDDays = Val(txtDays.Text)
        objRDAccount.RDMaturityDate = Format(dtpMaturityDate.Value, "yyyy-MM-dd")
        objRDAccount.RDRoi = txtROI.Text
        objRDAccount.IntroName = txtIntroAccNo.Text
        objRDAccount.ReceiptNo = txtReceiptNo.Text

        objRDAccount.MatAmount = Val(txtMatAmount.Text)
        objRDAccount.intAmount = Val(txtIntAmount.Text)
        objRDAccount.SchemeCode = cmbSchemeType.SelectedValue
        objRDAccount.RDAmount = (txtRDAmount.Text)

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
        objRDAccount.InterestTable = dtInterest


        If chkCorrection.Checked = True Then
            objRDAccount.Correction = "Y"
        Else
            objRDAccount.Correction = "N"
        End If

        If chkAdd.Checked = True Then
            objRDAccount.CorrectioType = "A"
        ElseIf chkSubtract.Checked = True Then
            objRDAccount.CorrectioType = "S"
        Else
            objRDAccount.CorrectioType = "N"
        End If

        objRDAccount.CAmount = Val(txtCorrectionAmount.Text)

        Return True

    End Function

    'To get Byte array for Photo object, function called while setting values to the Class Properties
    Function fnGetPhoto() As Byte()
        Try
            Dim msStream As New MemoryStream
            Dim bytArr() As Byte
            picPhoto.Image.Save(msStream, picPhoto.Image.RawFormat)
            bytArr = msStream.GetBuffer
            msStream.Close()
            Return bytArr
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'To get Byte array for Signature object, function called while setting values to the Class Properties
    Function fnGetSign() As Byte()
        Try
            Dim msStream As New MemoryStream
            Dim bytArr() As Byte
            picSignature.Image.Save(msStream, picSignature.Image.RawFormat)
            bytArr = msStream.GetBuffer
            msStream.Close()
            Return bytArr
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        'lngVoucherNo = fnVoucherGetNewVNo(dtpAccDate.Value)
        'objRDAccount.VoucherNo = lngVoucherNo
        'lngSlNo = fnVoucherGetNewSlNo()

        objRDAccount.fnAddRDAccount(objTrans)

        ''''Transaction Entery
        'objRDAccount.fnRDTransaction(Trim(txtAccNo.Text), dtpAccDate.Value, "By new RD account  " & txtAccNo.Text, Val(txtAvailBal.Text), 0, Val(txtAvailBal.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0, objTrans)

        ''voucher details
        'fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReceiptNo.Text, dtpAccDate.Value, Val(txtAvailBal.Text), "By new member" & txtCustomerID.Text, lngSlNo, "Y", objTrans)

        ''Credit accounts
        'fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpAccDate.Value, "By RD account " & txtAccNo.Text, "To", 29, 0, Val(txtAvailBal.Text), 1, "Y", objTrans)

        ''Debit accounts 
        'fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpAccDate.Value, "By RD account " & txtAccNo.Text, "By", 1, Val(txtAvailBal.Text), 0, 2, "Y", objTrans)

        Return True

    End Function

    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptNo.Text, txtName.Text, dtpAccDate.Value, txtAvailBal.Text, "")

        'Receipt sub details
        fnReceiptEnterSub(txtReceiptNo.Text, dtpAccDate.Value, "Pigmy Deposit", txtAvailBal.Text, 1)

        Return True

    End Function

    Public Function fnGetROI() As Boolean
        Dim IntYears As Integer
        Dim intMonths As Integer
        Dim IntDays As Integer

        If txtYears.Text = String.Empty Then
            IntYears = 0
        Else
            IntYears = Math.Round(txtYears.Text * 365)
        End If

        If txtMonths.Text = String.Empty Then
            intMonths = 0
        Else
            intMonths = Math.Round(txtMonths.Text * 30)
        End If

        If txtDays.Text = String.Empty Then
            IntDays = 0
        Else
            IntDays = txtDays.Text
        End If

        objRDAccount.DepositPeriod = IntYears + intMonths + IntDays
        If objRDAccount.fnGetROI() Then
            txtROI.Text = objRDAccount.ROITable.Rows(0).Item("RateOfInterest")
        Else
            txtROI.ResetText()
        End If
    End Function

#End Region

#Region "EVENTS"


    'To check data entered by the User, function called when "OK" button is clicked 
    ' save The Data into DataBase

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then

                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        If MsgBox("You want to Add another RD?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objRDAccCust As New frmRDCust
        objRDAccCust.strRDNo = String.Empty
        objRDAccCust.ShowDialog(Me)
        If objRDAccCust.strRDNo <> String.Empty Then
            txtAccNo.Text = objRDAccCust.strRDNo
            sbLoadRDAccDetails()
        End If
        objRDAccCust.Dispose()

    End Sub

    Private Sub btnMemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemSearch.Click
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            ' btnAdd_Click(sender, e)
            txtCustomerID.Text = objCustomerList.strCustomerID
            sbLoadCustomer()
        End If
        objCustomerList.Dispose()
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
                txtEducation.Text = objDT.Rows(0).Item("Education")
                txtOffAddress.Text = objDT.Rows(0).Item("OfficeAddress")
                txtOfficeNo.Text = objDT.Rows(0).Item("OfficeNo")

                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        'msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        'msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        'picPhoto.Image = Image.FromStream(msStream)                        
                        picPhoto.Image = Image.FromFile(objDT.Rows(0).Item("Photo"))
                        picPhoto.ImageLocation = objDT.Rows(0).Item("Photo")


                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        'msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        'msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        'msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        'picSignature.Image = Image.FromStream(msStream)                        
                        picSignature.Image = Image.FromFile(objDT.Rows(0).Item("Signature"))
                        picSignature.ImageLocation = objDT.Rows(0).Item("Signature")


                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                        'msStream.Close()
                    End If
                End If

                txtCustomerID.Enabled = False
                txtName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub
    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtAccNo.Text) <> "RD" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtAccNo.Text
            objNominees.chrType = "N"
            objNominees.txtName.Text = txtName.Text
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Enter valid account number", MsgBoxStyle.Information, "RD Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If cmbAccType.SelectedItem = "Joint" Then
            If Trim(txtAccNo.Text) <> "RD" Then
                Dim objJointHolders As New frmNominees
                objJointHolders.txtAccountNo.Text = txtAccNo.Text
                objJointHolders.txtName.Text = txtName.Text
                objJointHolders.Text = "Joint-Holders for Account No  " & txtAccNo.Text
                objJointHolders.chrType = "J"
                objJointHolders.ShowDialog(Me)
                objJointHolders.Dispose()
            Else
                MsgBox("Enter valid account number", MsgBoxStyle.Information, "RD Module")
                txtAccNo.Focus()
            End If
        Else
            MsgBox("Account Type should be joint account", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click

        If objRDAccount.fnCheckRDAccount(Trim(txtAccNo.Text)) = True Then
            If objRDAccount.CheckRDTable.Rows(0).Item("Status") <> "C" Then
                Dim objRDDeposit As New frmRDDeposit
                objRDDeposit.strAccNo = txtAccNo.Text
                objRDDeposit.strName = txtName.Text
                objRDDeposit.btnSearch.Enabled = False
                objRDDeposit.ShowDialog()
            Else
                MsgBox("Cannot deposit, account closed", MsgBoxStyle.Exclamation, " RD Module")
            End If
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Exclamation, " RD Module")
        End If

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        If objRDAccount.fnCheckRDAccount(Trim(txtAccNo.Text)) = True Then
            If objRDAccount.CheckRDTable.Rows(0).Item("Status") <> "C" Then
                Dim objRDWithDrawl As New frmRDPreMature
                objRDWithDrawl.strAccNo = txtAccNo.Text
                objRDWithDrawl.strName = txtName.Text
                objRDWithDrawl.btnSearch.Enabled = False
                objRDWithDrawl.ShowDialog()
            Else
                MsgBox("Cannot premature, account closed", MsgBoxStyle.Exclamation, "RD Module")
            End If
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Exclamation, "RD Module")
            txtAccNo.Focus()
        End If

    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If objRDAccount.fnCheckRDAccount(Trim(txtAccNo.Text)) = True Then
            Dim objfrmRDTrans As New frmRDTransaction
            objfrmRDTrans.strAccNo = txtAccNo.Text
            objfrmRDTrans.strName = txtName.Text
            objfrmRDTrans.txtName.ReadOnly = True
            objfrmRDTrans.txtRDNo.ReadOnly = True
            objfrmRDTrans.btnSearch.Enabled = False
            objfrmRDTrans.ShowDialog(Me)
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Exclamation, "RD Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub txtPermAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermAddress.TextChanged
        If chkSame.Checked = True Then
            txtPresAddress.Text = txtPermAddress.Text
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        nMode = CTAdd
        'txtAccNo.Text = "RD"
        fnPGClear()
        '  txtYears.Enabled = True
        '   txtMonths.Enabled = True
        '  txtDays.Enabled = True

        Dim Temp As String
        Dim TempNewNo As String = Mid(objRDAccount.fnGetNewRDNo, 3, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "RD" & String.Format("{0:00000}", CInt(TempNewNo))
            txtAccNo.Text = Temp
            txtAccNo.Focus()
        Else
            MsgBox("Recurring Deposit Number Exceeds The Maximum Alloted Number", MsgBoxStyle.Information, "Recurring Deposit Module")
        End If

    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        txtPermAddress_TextChanged(Me, e.Empty)
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.TextChanged
        If txtAccNo.Text.StartsWith("RD") = False Then
            txtAccNo.Undo()
            txtAccNo.ClearUndo()
        End If
    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave

        If txtAccNo.Text <> "RD" Then
            If objRDAccount.fnCheckRDAccount(Trim(txtAccNo.Text)) = True Then
                If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sbLoadRDAccDetails()
                Else
                    ' txtAccNo.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub dtpDOB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub txtAe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged
        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If

        If Val(txtAge.Text) >= 60 Then
            rdbSYes.Checked = True
            rdbSNo.Checked = False

        Else
            rdbSNo.Checked = True
            rdbSYes.Checked = False
        End If
    End Sub

#End Region

#Region "Genral Subroutines"

    Sub sbLoadRDAccDetails()
        Try

            Dim objDT As DataTable
            Dim msStream As MemoryStream
            Dim objIntTable As DataTable

            If objRDAccount.fnGetRDAccountDetails(txtAccNo.Text) Then
                fnPGClear()

                objDT = objRDAccount.RDDetails

                'RD Details

                txtAccNo.Text = objDT.Rows(0).Item("RDNo")
                txtAccNo.ReadOnly = True
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerId")
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                'dtpAccDate.Value = CDate(objDT.Rows(0).Item("RDDate"))
                dtpAccDate.Value = Convert.ToDateTime(objDT.Rows(0).Item("RDDate"))
                dtpAccDate.Enabled = False

                If IsDBNull(objDT.Rows(0).Item("Balance")) Then
                    txtAvailBal.Text = 0
                Else
                    txtAvailBal.Text = objDT.Rows(0).Item("Balance")
                End If

                txtAvailBal.Enabled = False
                btnMemSearch.Enabled = False
                txtCustomerID.Enabled = False

                Select Case objDT.Rows(0).Item("AccType")
                    Case "S"
                        cmbAccType.SelectedItem = "Single"
                    Case "J"
                        cmbAccType.SelectedItem = "Joint"
                End Select

                Select Case objDT.Rows(0).Item("opMode")
                    Case "T"
                        cmbOpMode.SelectedItem = "Together"
                    Case "E"
                        cmbOpMode.SelectedItem = "Either"
                End Select
                txtIntroAccNo.Text = objDT.Rows(0).Item("IntroNo")

                Select Case objDT.Rows(0).Item("Status")
                    Case "A"
                        cmbAccStatus.SelectedItem = "Active"
                    Case "S"
                        cmbAccStatus.SelectedItem = "Suspended"
                    Case "C"
                        cmbAccStatus.Enabled = False
                        cmbAccStatus.SelectedItem = "Closed"
                End Select
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")

                txtReceiptNo.Text = IIf(IsDBNull(objDT.Rows(0).Item("ReceiptNo")) = True, "", objDT.Rows(0).Item("ReceiptNo"))
                txtROI.Text = objDT.Rows(0).Item("RDROI")

                If IsDBNull(objDT.Rows(0).Item("Years")) = True Then
                    txtYears.Text = 0
                Else
                    txtYears.Text = objDT.Rows(0).Item("Years")
                End If

                If IsDBNull(objDT.Rows(0).Item("Months")) = True Then
                    txtMonths.Text = 0
                Else
                    txtMonths.Text = objDT.Rows(0).Item("Months")
                End If

                If IsDBNull(objDT.Rows(0).Item("Days")) = True Then
                    txtDays.Text = 0
                Else
                    txtDays.Text = objDT.Rows(0).Item("Days")
                End If

                txtYears.Enabled = False
                txtMonths.Enabled = False
                txtDays.Enabled = False
                grpRDType.Enabled = False

                cmbSchemeType.SelectedValue = objDT.Rows(0).Item("RDScheme")

                'Select Case objDT.Rows(0).Item("IntMode").ToString
                '    Case "M" : cmbType.SelectedItem = "Monthly"
                '    Case "Q" : cmbType.SelectedItem = "Quarterly"
                '    Case "H" : cmbType.SelectedItem = "Half-Yearly"
                '    Case "Y" : cmbType.SelectedItem = "Yearly"
                '    Case "C" : cmbType.SelectedItem = "Closure Date"
                'End Select

                txtRDAmount.Text = objDT.Rows(0).Item("RDAmount")
                txtIntAmount.Text = objDT.Rows(0).Item("IntAmount")

                If objDT.Rows(0).Item("Correction") = "Y" Then
                    chkCorrection.Checked = True
                    If objDT.Rows(0).Item("CType") = "A" Then
                        chkAdd.Checked = True
                    ElseIf objDT.Rows(0).Item("CType") = "S" Then
                        chkSubtract.Checked = True
                    End If
                    txtCorrectionAmount.Text = objDT.Rows(0).Item("CAmount")
                End If


                txtMatAmount.Text = objDT.Rows(0).Item("MatAmount")

                'Person Deatils
                txtName.Text = objDT.Rows(0).Item("Name")
                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")
                IIf(objDT.Rows(0).Item("Gender") = "M", rdbMale.Checked = True, rdbFemale.Checked = True)
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtOfficeNo.Text = objDT.Rows(0).Item("OfficeNo")
                txtOffAddress.Text = objDT.Rows(0).Item("OfficeAddress")
                txtEducation.Text = objDT.Rows(0).Item("Education")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")
                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")

                If Not objRDAccount.InterestTable Is Nothing Then
                    objIntTable = objRDAccount.InterestTable
                    Dim intCounter As Integer = 0
                    Dim lvItem As ListViewItem

                    lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                    lvInterest.Items.Clear()
                    If lvInterest.Columns.Count > 5 Then
                        lvInterest.Columns.RemoveAt(5)
                    End If

                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("CumuAmount"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                        intCounter += 1
                    End While
                End If

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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub fnPGClear()
        lngPersonNo = 0
        txtAccNo.ReadOnly = False
        dtpMaturityDate.Value = Date.Now.Date
        txtAccNo.ReadOnly = False
        txtCustomerID.ResetText()
        txtCustomerID.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        'dtpAccDate.ResetText()
        dtpAccDate.Enabled = True
        dtpDOB.ResetText()
        rdbMale.Checked = True
        txtAge.ResetText()
        cmbReligion.SelectedIndex = 0
        cmbCaste.ResetText()
        cmbOccupation.ResetText()
        txtOffAddress.ResetText()
        txtOfficeNo.ResetText()
        txtEducation.ResetText()
        txtIntroAccNo.ResetText()
        txtIntroAccNo.Enabled = True
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        txtReceiptNo.ResetText()
        txtAvailBal.ResetText()
        txtAvailBal.Enabled = True
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtRemarks.ResetText()
        btnMemSearch.Enabled = True
        txtCustomerID.Enabled = True
        txtYears.ResetText()
        txtMonths.ResetText()
        txtDays.ResetText()
        txtROI.ResetText()
        cmbAccType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        txtRemarks.ResetText()
        txtIntAmount.ResetText()
        txtMatAmount.ResetText()
        txtRDAmount.ResetText()
        cmbSchemeType.SelectedIndex = -1
        cmbType.SelectedIndex = -1
        grpRDType.Enabled = True
        chkAdd.Checked = False
        chkSubtract.Checked = False
        chkCorrection.Checked = False
        txtCorrectionAmount.ResetText()

        If lvInterest.Columns.Count > 4 Then
            lvInterest.Columns.RemoveAt(4)
        End If
        lvInterest.Items.Clear()

    End Sub

    Sub sbLoadMember()
        Dim objDT As DataTable
        Dim msStream As MemoryStream

        Try

            If objMember.fnGetMemberDetails(txtCustomerID.Text) Then
                fnPGClear()

                objDT = objMember.MemberTable

                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                txtCustomerID.Text = objDT.Rows(0).Item("MemberNo")
                txtName.Text = objDT.Rows(0).Item("Name")
                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")
                IIf(objDT.Rows(0).Item("Gender") = "M", rdbMale.Checked = True, rdbFemale.Checked = True)
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


                txtRemarks.Text = objDT.Rows(0).Item("Remarks")

                ' txtName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'to calculate 'MATURITY DATE' depending on the 'FD DATE' and 'PERIOD'
    Sub sbCalcMatDate()
        dtpMaturityDate.Value = DateAdd(DateInterval.Year, Val(txtYears.Text), dtpAccDate.Value)
        dtpMaturityDate.Value = DateAdd(DateInterval.Month, Val(txtMonths.Text), dtpMaturityDate.Value)
        dtpMaturityDate.Value = DateAdd(DateInterval.Day, Val(txtDays.Text), dtpMaturityDate.Value)
        ''dtpMaturityDate.Value = DateAdd(DateInterval.Day, 1, dtpMaturityDate.Value)
    End Sub

    'Function FnCalInterestRD()

    '    Dim intNOM As Integer = 0
    '    Dim intNOD As Integer = 0
    '    Dim dblFDAmount As Double
    '    Dim dblIntAmt As Double = 0
    '    Dim dblTotalInt As Double = 0
    '    Dim dblROI As Double = 0
    '    Dim intCounter As Integer = 1  '50527.22
    '    Dim lngPeriod As Double = 0
    '    Dim intIntMode As Integer = 0
    '    Dim iv As ListViewItem

    '    Dim datNextDate As Date
    '    Dim datMatdate As Date

    '    Dim ANil As Double
    '    Dim ANil1 As Double

    '    intNOM = Val(txtFDMonths.Text)
    '    intNOM += (Val(txtFDYears.Text) * 12)


    '    datFDDate = CDate(dtpFDDate.Value)
    '    lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)

    '    datMatdate = CDate(dtpFDMatDate.Value)
    '    dblFDAmount = txtFDAmount.Text
    '    dblROI = txtFDROI.Text
    '    lvInterest.Items.Clear()
    '    While intCounter <= intNOM

    '        datNextDate = DateAdd(DateInterval.Month, 1, datFDDate)
    '        'datNextDate = datNextDate.AddMonths(1)
    '        'datNextDate = datNextDate.AddDays(-(datNextDate.Day))

    '        'intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
    '        dblIntAmt = Round((dblFDAmount * 1 * dblROI) / (100 * 12))
    '        iv = lvInterest.Items.Add(intCounter)
    '        iv.SubItems.Add(Math.Round(dblIntAmt))
    '        iv.SubItems.Add(Math.Round(intNOD))
    '        iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
    '        ANil += dblIntAmt
    '        ANil1 += Val(txtFDAmount.Text)
    '        If intCounter Mod 3 = 0 Then
    '            iv.SubItems.Add(Math.Round(ANil + dblFDAmount))
    '        End If

    '        dblFDAmount += Val(txtFDAmount.Text)


    '        If intCounter Mod 3 = 0 Then
    '            dblFDAmount = dblFDAmount + ANil
    '            ANil = 0
    '        End If


    '        datFDDate = datNextDate
    '        dblTotalInt += dblIntAmt
    '        intCounter += 1

    '    End While
    '    txtFDIntAmount.Text = Math.Round(dblTotalInt)
    '    txtFDMatAmount.Text = Math.Round(dblTotalInt + ANil1)

    'End Function

    Function FnCalInterestRD()

        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim dblFDAmount As Double
        Dim dblIntAmt As Double = 0
        dblTotalInt = 0

        Dim dblROI As Double = 0
        Dim intCounter As Integer = 1
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim iv As ListViewItem

        Dim datNextDate As Date
        Dim datMatdate As Date

        Dim dblTempInt As Double
        dblTotalPrincipal = 0

        intNOM = Val(txtMonths.Text)
        intNOM += (Val(txtYears.Text) * 12)


        datRDDate = CDate(dtpAccDate.Value)
        lngPeriod = DateDiff(DateInterval.Day, dtpAccDate.Value, dtpMaturityDate.Value)

        datMatdate = CDate(dtpMaturityDate.Value)
        dblFDAmount = txtRDAmount.Text
        dblROI = txtROI.Text
        'lvInterest.Items.Clear()
        While intCounter <= intNOM

            datNextDate = DateAdd(DateInterval.Month, 1, datRDDate)
            'datNextDate = datNextDate.AddMonths(1)
            'datNextDate = datNextDate.AddDays(-(datNextDate.Day))

            'intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
            dblIntAmt = Round((dblFDAmount * 1 * dblROI) / (100 * 12))
            'iv = lvInterest.Items.Add(intCounter)
            'iv.SubItems.Add(Math.Round(dblIntAmt))
            'iv.SubItems.Add(Math.Round(intNOD))
            'iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
            dblTempInt += dblIntAmt
            dblTotalPrincipal += Val(txtRDAmount.Text)
            'If intCounter Mod 3 = 0 Then
            '    iv.SubItems.Add(Math.Round(ANil + dblFDAmount))
            'End If

            dblFDAmount += Val(txtRDAmount.Text)


            If intCounter Mod 3 = 0 Then
                dblFDAmount = dblFDAmount + dblTempInt
                dblTempInt = 0
            End If


            datRDDate = datNextDate
            dblTotalInt += dblIntAmt
            intCounter += 1

        End While
        txtIntAmount.Text = Math.Round(dblTotalInt)
        txtMatAmount.Text = Math.Round(dblTotalInt + dblTotalPrincipal)

    End Function

#End Region

#Region " Key Down Events"

    Private Sub txtMobileNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
            TabControl1.Focus()
        End If
    End Sub

    Private Sub dtpDOB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbReligion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReligion.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbCaste_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCaste.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbOccupation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOccupation.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbMajor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbMajor.KeyDown, rdbMinor.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkSame_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkSame.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub dtpAccDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpAccDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAccType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAccType.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbOpMode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOpMode.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbAccStatus_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbMale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbMale.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbFemale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbFemale.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkphotoId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

    Private Sub chkSdressId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

#End Region


    Private Sub frmRDAccCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        dtInterest.Columns.Add("SlNo")
        dtInterest.Columns.Add("IntAmount")
        dtInterest.Columns.Add("IntDate")
        dtInterest.Columns.Add("TotalAmount")

        txtAvailBal.ContextMenu = New ContextMenu
        cmbAccType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        cmbAccStatus.SelectedIndex = -1
        cmbAccStatus.Enabled = True

        'dtpDOB.MaxDate = Date.Now
        'dtpAccDate.MaxDate = Date.Now
        'dtpDOB.Value = Date.Now
        'dtpAccDate.Value = Date.Now

        sbLoadControlValues() 'Load Values 
        txtAccNo.Focus()

        If txtAccNo.Text <> "RD" Then
            sbLoadRDAccDetails()
        Else
            btnAdd_Click(sender, e)
        End If

    End Sub

    Private Sub NewButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton4.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtIntroAccNo.Text = objMemberSearch.strMemberNo
        End If
        objMemberSearch.Dispose()
    End Sub

    Private Sub txtYears_TextChanged1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYears.TextChanged, txtDays.TextChanged, txtMonths.TextChanged
        sbCalcMatDate()
    End Sub

    Private Sub dtpAccDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpAccDate.ValueChanged
        sbCalcMatDate()
    End Sub


    Private Sub cmbSchemeType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSchemeType.LostFocus
        objRDAccount.SchemeCode = cmbSchemeType.SelectedValue
        If objRDAccount.fnCheckScheme() Then
            dtMasterData = objRDAccount.RDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                bolCumulative = True
                objRDAccount.RDType = "C"
            Else
                bolCumulative = False
                objRDAccount.RDType = "N"
            End If
            cmbType.SelectedItem = dtMasterData.Rows(0).Item("IntPostingPrd")
        Else

            MsgBox("Load failed due to internal error", MsgBoxStyle.Exclamation)

        End If

        If cmbType.SelectedIndex <> 0 Then
            Panel1.Enabled = True
            dtpAccDate.Focus()
        Else
            Panel1.Enabled = False
        End If



    End Sub

    Private Sub txtRDAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRDAmount.GotFocus
        txtROI.ResetText()
        Dim lngPeriod As Double = 0
        Dim dblROI As Double = 0
        lngPeriod = DateDiff(DateInterval.Day, dtpAccDate.Value, dtpMaturityDate.Value)
        lngPeriod -= 1

        If objRDAccount.fnGetROI(lngPeriod) Then
            dblROI = objRDAccount.RdMasterTbl.Rows(0).Item(0)
        End If

        txtROI.Text = Format(dblROI, "00.00")
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If cmbSchemeType.SelectedIndex = -1 Then
            MsgBox("Please select Scheme type")
            cmbSchemeType.Focus()
        ElseIf (Val(txtYears.Text) = 0 And Val(txtMonths.Text) = 0 And Val(txtDays.Text) = 0) Then
            MsgBox("Please enter Period of Deposit")
            txtYears.Focus()
        ElseIf Val(txtRDAmount.Text) = 0 Then
            MsgBox("Enter RD Amount", MsgBoxStyle.Information)
            txtRDAmount.Focus()
        ElseIf txtROI.Text = String.Empty Then
            MsgBox("Enter ROI", MsgBoxStyle.Information)
            txtROI.Focus()
        Else
            FnCalInterest()
        End If

    End Sub

    Function fnCheckFDDetails() As Boolean
        If cmbType.SelectedIndex = -1 Then
            MsgBox("Select interest mode", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            fnCheckFDDetails = False
            cmbType.Focus()
        ElseIf (Val(txtYears.Text) = 0 And Val(txtMonths.Text) = 0 And Val(txtDays.Text) = 0) Then
            MsgBox("Please enter period of deposit", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            fnCheckFDDetails = False
            txtYears.Focus()
        ElseIf Val(txtRDAmount.Text) <= 0 Or txtRDAmount.Text = "" Then
            MsgBox("Amount should not be zero", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            fnCheckFDDetails = False
        ElseIf Val(txtROI.Text) = 0 Then
            MsgBox("Please enter FD ROI", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            fnCheckFDDetails = False
            txtROI.Focus()
        Else
            fnCheckFDDetails = True
        End If
    End Function
    Function FnCalInterest()
        Dim intIntMode As Integer = 0
        Dim intPreMode As Integer = 0
        Dim intNOM As Integer = 0
        Dim intMonth As Integer = 0
        Dim intNOD As Integer
        Dim datNextDate As Date
        Dim NumberOfQuerters As Double
        Dim UnQuaterDayCal As Double
        Dim i As Double
        Dim datAccDate As Date
        Dim ActualNextDate As Date
        Dim principal As Integer
        Dim rate As Double
        Dim ci As Integer
        Dim time As Integer
        Dim irate As Double
        Dim intCounter As Integer
        Dim tempTime As Double
        Dim intCounter1 As Integer
        Dim iv As ListViewItem
        Dim intPAmount As Integer = 0
        Dim dblPrevInt As Double = 0
        Dim DayIntermsOfMonth As Double
        lvInterest.Items.Clear()
        Select Case cmbType.SelectedItem.ToString
            Case "Monthly"
                intIntMode = 12
                intPreMode = 1
            Case "Quarterly"
                intIntMode = 4
                intPreMode = 3
            Case "Half-Yearly"
                intIntMode = 2
                intPreMode = 6
            Case "Yearly"
                intIntMode = 1
                intPreMode = 12
        End Select
        '''datNextDate = CDate(dtpAccDate.Value)
        intNOM = Val(txtMonths.Text)
        intNOM += (Val(txtYears.Text) * 12)
        NumberOfQuerters = intNOM / 3
        principal = Val(txtRDAmount.Text) '4000
        rate = Val(txtROI.Text)             '9.5
        i = rate / 400
        time = Val(intNOM)        '39
        ci = Val(intIntMode)               '4
        irate = rate / ci
        lvInterest.Items.Clear()
        ''Marigowder given formula for RD creation
        'txtMatAmount.Text = Math.Round((principal * (Math.Pow((1 + i), NumberOfQuerters) - 1)) / (1 - Math.Pow((1 + i), (-1 / 3))))
        ''txtMatAmount.Text = Math.Round((principal * (Math.Pow((1 + irate / 100), (time / 12) * ci) - 1) / (1 - Math.Pow((1 + irate / 100), -ci / 12)) * 100) / 100)
        txtMatAmount.Text = Math.Round((principal * (Math.Pow((1 + irate / 100), (time / 12) * ci) - 1) / (1 - Math.Pow((1 + irate / 100), -ci / 12)) * 100) / 100)
        txtIntAmount.Text = Math.Round(Val(txtMatAmount.Text)) - (principal * time)
        intCounter = 1
        'tempTime = intPreMode '3
        datAccDate = dtpAccDate.Value
        ActualNextDate = dtpNextDate.Value
        If dtpAccDate.Value <> dtpNextDate.Value Then
            dblTempInt = 0
            intNOD = DateDiff(DateInterval.Day, dtpAccDate.Value, dtpNextDate.Value)
            DayIntermsOfMonth = intNOD / 30
            intPAmount = principal * DayIntermsOfMonth
            'dblTempInt = Math.Round((principal * (Math.Pow((1 + i), DayIntermsOfMonth) - 1)) / (1 - Math.Pow((1 + i), (-1 / 3))))
            dblTempInt = Math.Round((principal * (Math.Pow((1 + irate / 100), (DayIntermsOfMonth / 12) * ci) - 1) / (1 - Math.Pow((1 + irate / 100), -ci / 12)) * 100) / 100)
            intCounter1 += 1
            iv = lvInterest.Items.Add(intCounter1)
            iv.SubItems.Add(Math.Round(dblTempInt - intPAmount - dblPrevInt))
            iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
            iv.SubItems.Add(Math.Round(dblTempInt))
            dblPrevInt = dblTempInt - intPAmount
            tempTime += DayIntermsOfMonth
            'intCounter += 1
            datAccDate = dtpNextDate.Value
            datNextDate = dtpNextDate.Value
        End If
        datNextDate = dtpNextDate.Value
        'tempTime = intPreMode + DayIntermsOfMonth  '3
        time = DateDiff(DateInterval.Month, datAccDate, dtpMaturityDate.Value)

        While (time / intPreMode) > intCounter
            dblTempInt = 0
            'datNextDate = datNextDate.AddMonths(intPreMode)
            tempTime += intPreMode
            intPAmount = principal * tempTime
            datNextDate = DateAdd(DateInterval.Month, intPreMode, datNextDate)
            intMonth = datNextDate.Month
            If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                If (datNextDate.Day = 30) Then
                    datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
                End If
            End If
            ''dblTempInt = Math.Round((principal * (Math.Pow((1 + i), tempTime) - 1)) / (1 - Math.Pow((1 + i), (-1 / 3))))
            dblTempInt = Math.Round((principal * (Math.Pow((1 + irate / 100), (tempTime / 12) * ci) - 1) / (1 - Math.Pow((1 + irate / 100), -ci / 12)) * 100) / 100)
            intCounter1 += 1
            iv = lvInterest.Items.Add(intCounter1)
            iv.SubItems.Add(Math.Round(dblTempInt - intPAmount - dblPrevInt))
            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
            iv.SubItems.Add(Math.Round(dblTempInt))
            dblPrevInt = dblTempInt - intPAmount
            'tempTime += intPreMode
            intCounter += 1
        End While
        time = time Mod 3
        intNOD = DateDiff(DateInterval.Day, datNextDate, dtpMaturityDate.Value)   'days for remaining months
        'DayIntermsOfMonth = Math.Round(intNOD / 30, 1)
        UnQuaterDayCal = intPreMode - DayIntermsOfMonth
        tempTime += UnQuaterDayCal
        If intNOD > 0 Then
            dblTempInt = 0
            'tempTime -= intPreMode
            'tempTime += time
            intPAmount = principal * tempTime
            ''dblTempInt = Math.Round((principal * (Math.Pow((1 + i), temp5Time) - 1)) / (1 - Math.Pow((1 + i), (-1 / 3))))
            dblTempInt = (principal * (Math.Pow((1 + irate / 100), (tempTime / 12) * ci) - 1) / (1 - Math.Pow((1 + irate / 100), -ci / 12)) * 100) / 100
            ''dblPrevInt = dblTempInt - intPAmount
            iv = lvInterest.Items.Add(intCounter)
            iv.SubItems.Add(Math.Round(dblTempInt - intPAmount - dblPrevInt))
            iv.SubItems.Add(Format(dtpMaturityDate.Value, "dd-MMM-yyyy"))
            iv.SubItems.Add(Math.Round(dblTempInt))
        End If
        dtpNextDate.Value = ActualNextDate
    End Function

    Private Sub chkCorrection_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCorrection.CheckedChanged
        If chkCorrection.Checked = True Then
            Correction.Enabled = True
            txtCInterest.Visible = True
            lblCInterest.Visible = True
            txtCInterest.Text = Val(txtIntAmount.Text)
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

        Dim dblAmt As Double = Val(txtIntAmount.Text)

        If chkAdd.Checked = True Then
            txtMatAmount.ResetText()
            txtCInterest.Text = dblAmt + Val(txtCorrectionAmount.Text)
            txtMatAmount.Text = Val(txtCInterest.Text) + Val(dblTotalPrincipal)
        ElseIf chkSubtract.Checked = True Then
            txtCInterest.Text = dblAmt - Val(txtCorrectionAmount.Text)
            txtMatAmount.Text = Val(txtCInterest.Text) + Val(dblTotalPrincipal)
        Else
            txtMatAmount.Text = Val(dblAmt) + Val(dblTotalPrincipal)
        End If


    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        If objRDAccount.fnCheckRDAccount(Trim(txtAccNo.Text)) = True Then
            If objRDAccount.CheckRDTable.Rows(0).Item("Status") <> "C" Then
                Dim objprovision As New frmProvision
                objprovision.txtRDAccountNo.Text = txtAccNo.Text
                objprovision.cmbSchemeType.SelectedValue = cmbSchemeType.SelectedValue
                objprovision.ShowDialog(Me)
            Else
                MsgBox("Cannot premature, account closed", MsgBoxStyle.Exclamation, "RD Module")
            End If
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Exclamation, "RD Module")
            txtAccNo.Focus()
        End If

    End Sub


    Private Sub btnNewMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMember.Click
        Dim objCustomer As New frmCustomer
        objCustomer = frmCustomer.DefInstance
        objCustomer.MdiParent = Me.MdiParent
        objCustomer.BringToFront()
        objCustomer.Show()
        objCustomer = Nothing
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        Dim objRDProvision As New frmProvisionPayments
        objRDProvision.dtpDate.Value = Date.Now
        objRDProvision.ShowDialog()

    End Sub


    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub
    Private Sub txtRemainingAmount_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRDAmount.GotFocus

        txtROI.ResetText()
        Dim lngPeriod As Double = 0
        Dim dblROI As Double = 0
        lngPeriod = DateDiff(DateInterval.Day, dtpAccDate.Value, dtpMaturityDate.Value)
        If objRDAccount.fnGetROI(lngPeriod) Then
            If rdbSYes.Checked = True Then
                dblROI = objRDAccount.RdMasterTbl.Rows(0).Item(0) + dtMasterData.Rows(0).Item("ReductionInt")
            ElseIf rdbSNo.Checked = True Then
                dblROI = objRDAccount.RdMasterTbl.Rows(0).Item(0)
            End If
        End If

        'If cmbPeriod.SelectedItem = "As Scheme Period" Then
        'dblROI += dtMasterData.Rows(0).Item("ReductionInt")
        'End If

        txtROI.Text = Format(dblROI, "00.00")



    End Sub
End Class

