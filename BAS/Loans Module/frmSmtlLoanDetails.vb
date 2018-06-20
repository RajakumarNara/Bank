#Region "Import Statements"
Imports System.IO
#End Region

Public Class frmSMTLLoanDetails
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objSBAccount1 As New clsSavingsBank
    Dim objSMTL As New clsSMTLLoan
    Dim objMember As New clsMember
    Dim objSBAccount As New clsSavingsBank1
    Dim objBankCharges As New clsBankCharges
    Dim lngPersonNo As Long = 0
    Dim objclsRepyment As New clsRePayment
    Dim OfficeNo As String
    Dim OdLimit As Double
    Dim LoanAgDepositCont(10) As LoansOnDepositControl
    Dim LoanAgNSCCont(5) As LoansOnDepositControl
    Dim objPerson As New clsPerson
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtSecuredDeposit As BankControls.NumericControl
    Friend WithEvents txtLoanProcessing As BankControls.NumericControl
    Friend WithEvents txtDocument As BankControls.NumericControl
    Friend WithEvents txtBuildingFund As BankControls.NumericControl
    Friend WithEvents btnBankCharges As System.Windows.Forms.CheckBox
    Dim objSurety As New clsHomeLoanSurety

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                'm_FormDefInstance = 
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
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents txtPresAddress As BankControls.TextControl
    Friend WithEvents txtPhoneNo As BankControls.NumericControl
    Friend WithEvents txtMobileNo As BankControls.NumericControl
    Friend WithEvents txtPermAddress As BankControls.TextControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents btnLoadSign As BankControls.NewButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents tbGoldLoanDetails As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnLoadPic As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents btnClose2 As BankControls.NewButton
    Friend WithEvents btnSignature As BankControls.NewButton
    Friend WithEvents txtLFNo As BankControls.TextControl
    Friend WithEvents txtRCTNo As BankControls.TextControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdbDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents rdbShare As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtODLimit As BankControls.NumericControl
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIntAmount As BankControls.TextControl
    Friend WithEvents dtpODLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents txtEstAmount As BankControls.NumericControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As BankControls.NumericControl
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnSurety As BankControls.NewButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lvSuretyDetail As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents NewButton2 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMTLLoanDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtMobileNo2 = New BankControls.NumericControl
        Me.Label104 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdbDeposit = New System.Windows.Forms.RadioButton
        Me.rdbShare = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtFatherName = New BankControls.TextControl
        Me.cmbCaste = New System.Windows.Forms.ComboBox
        Me.cmbReligion = New System.Windows.Forms.ComboBox
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.tbGoldLoanDetails = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnBankCharges = New System.Windows.Forms.CheckBox
        Me.txtSecuredDeposit = New BankControls.NumericControl
        Me.txtLoanProcessing = New BankControls.NumericControl
        Me.txtDocument = New BankControls.NumericControl
        Me.txtBuildingFund = New BankControls.NumericControl
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.lvSuretyDetail = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIntAmount = New BankControls.TextControl
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtEstAmount = New BankControls.NumericControl
        Me.txtLFNo = New BankControls.TextControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtRCTNo = New BankControls.TextControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtpODLoanDate = New System.Windows.Forms.DateTimePicker
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtODLimit = New BankControls.NumericControl
        Me.txtBalance = New BankControls.NumericControl
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label37 = New System.Windows.Forms.Label
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnLoadPic = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.btnClose2 = New BankControls.NewButton
        Me.btnSignature = New BankControls.NewButton
        Me.txtRemarks = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label91 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.NewButton5 = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton2 = New BankControls.NewButton
        Me.btnSurety = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.lblSignature = New System.Windows.Forms.Label
        Me.btnCancelSign = New BankControls.NewButton
        Me.btnLoadSign = New BankControls.NewButton
        Me.btnLoadPhoto = New BankControls.NewButton
        Me.btnCancelPhoto = New BankControls.NewButton
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbGoldLoanDetails.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbGoldLoanDetails)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(8, 120)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 441)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabStop = False
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.LightYellow
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label23)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.Label29)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo2)
        Me.tbPersonal.Controls.Add(Me.Label104)
        Me.tbPersonal.Controls.Add(Me.Label12)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.Panel1)
        Me.tbPersonal.Controls.Add(Me.Panel2)
        Me.tbPersonal.Controls.Add(Me.Panel3)
        Me.tbPersonal.Controls.Add(Me.Label16)
        Me.tbPersonal.Controls.Add(Me.txtFatherName)
        Me.tbPersonal.Controls.Add(Me.cmbCaste)
        Me.tbPersonal.Controls.Add(Me.cmbReligion)
        Me.tbPersonal.Controls.Add(Me.dtpDOB)
        Me.tbPersonal.Controls.Add(Me.Label4)
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
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(736, 412)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(288, 48)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 16)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "Customer No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(144, 48)
        Me.txtCustomerID.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(136, 23)
        Me.txtCustomerID.SpecialChar = False
        Me.txtCustomerID.TabIndex = 7
        Me.txtCustomerID.Text = "CID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(24, 88)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(111, 16)
        Me.Label29.TabIndex = 119
        Me.Label29.Text = "Husband Name:"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.AfterDecimal = 0
        Me.txtMobileNo2.BeforeDecimal = 10
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo2.Location = New System.Drawing.Point(534, 256)
        Me.txtMobileNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo2.MaxLength = 10
        Me.txtMobileNo2.MaxValue = 0
        Me.txtMobileNo2.MinValue = 0
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo2.TabIndex = 25
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(384, 256)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(95, 16)
        Me.Label104.TabIndex = 117
        Me.Label104.Text = "Mobile No2. :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(384, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 56)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Occupational / Office Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 16)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "SMTL Against :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbDeposit)
        Me.Panel1.Controls.Add(Me.rdbShare)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(144, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 32)
        Me.Panel1.TabIndex = 4
        '
        'rdbDeposit
        '
        Me.rdbDeposit.Checked = True
        Me.rdbDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDeposit.Location = New System.Drawing.Point(16, 4)
        Me.rdbDeposit.Name = "rdbDeposit"
        Me.rdbDeposit.Size = New System.Drawing.Size(82, 24)
        Me.rdbDeposit.TabIndex = 5
        Me.rdbDeposit.TabStop = True
        Me.rdbDeposit.Text = "Deposit"
        '
        'rdbShare
        '
        Me.rdbShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbShare.Location = New System.Drawing.Point(104, 4)
        Me.rdbShare.Name = "rdbShare"
        Me.rdbShare.Size = New System.Drawing.Size(72, 24)
        Me.rdbShare.TabIndex = 6
        Me.rdbShare.Text = "Shares"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(144, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 32)
        Me.Panel2.TabIndex = 15
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 7)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 16
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 7)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 17
        Me.rdbFemale.Text = "Female"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbMajor)
        Me.Panel3.Controls.Add(Me.rdbMinor)
        Me.Panel3.Enabled = False
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(144, 176)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 32)
        Me.Panel3.TabIndex = 12
        '
        'rdbMajor
        '
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 7)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 13
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.rdbMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 7)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 14
        Me.rdbMinor.Text = "Minor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 16)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Age Status :"
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.BlankSpace = True
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(144, 80)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(184, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 9
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(144, 280)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(184, 24)
        Me.cmbCaste.TabIndex = 19
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(144, 248)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(184, 24)
        Me.cmbReligion.TabIndex = 18
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(144, 112)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 23, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 23)
        Me.dtpDOB.TabIndex = 10
        Me.dtpDOB.Value = New Date(2007, 10, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father/ "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
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
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(384, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Permanent Address: "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(534, 88)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 21
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(384, 192)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(384, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 16)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No1. : "
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(144, 144)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(80, 23)
        Me.txtAge.TabIndex = 11
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(534, 120)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 22
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(534, 192)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.TabIndex = 23
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(534, 224)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.TabIndex = 24
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(534, 16)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 20
        '
        'tbGoldLoanDetails
        '
        Me.tbGoldLoanDetails.BackColor = System.Drawing.Color.LightYellow
        Me.tbGoldLoanDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbGoldLoanDetails.Controls.Add(Me.GroupBox3)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label20)
        Me.tbGoldLoanDetails.Controls.Add(Me.lvSuretyDetail)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label1)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtIntAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label28)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label27)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtEstAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtLFNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label18)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtRCTNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label22)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpODLoanDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbStatus)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label34)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label19)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label11)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtODLimit)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtBalance)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label21)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtROI)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label37)
        Me.tbGoldLoanDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGoldLoanDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldLoanDetails.Name = "tbGoldLoanDetails"
        Me.tbGoldLoanDetails.Size = New System.Drawing.Size(736, 412)
        Me.tbGoldLoanDetails.TabIndex = 4
        Me.tbGoldLoanDetails.Text = "LoanDetails"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox3.Controls.Add(Me.btnBankCharges)
        Me.GroupBox3.Controls.Add(Me.txtSecuredDeposit)
        Me.GroupBox3.Controls.Add(Me.txtLoanProcessing)
        Me.GroupBox3.Controls.Add(Me.txtDocument)
        Me.GroupBox3.Controls.Add(Me.txtBuildingFund)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 88)
        Me.GroupBox3.TabIndex = 152
        Me.GroupBox3.TabStop = False
        '
        'btnBankCharges
        '
        Me.btnBankCharges.AutoSize = True
        Me.btnBankCharges.Location = New System.Drawing.Point(9, -1)
        Me.btnBankCharges.Name = "btnBankCharges"
        Me.btnBankCharges.Size = New System.Drawing.Size(127, 20)
        Me.btnBankCharges.TabIndex = 157
        Me.btnBankCharges.Text = "Bank Charges"
        Me.btnBankCharges.UseVisualStyleBackColor = True
        '
        'txtSecuredDeposit
        '
        Me.txtSecuredDeposit.AfterDecimal = 2
        Me.txtSecuredDeposit.BeforeDecimal = 7
        Me.txtSecuredDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecuredDeposit.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSecuredDeposit.Location = New System.Drawing.Point(351, 55)
        Me.txtSecuredDeposit.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSecuredDeposit.MaxLength = 10
        Me.txtSecuredDeposit.MaxValue = 0
        Me.txtSecuredDeposit.MinValue = 0
        Me.txtSecuredDeposit.Name = "txtSecuredDeposit"
        Me.txtSecuredDeposit.Size = New System.Drawing.Size(125, 23)
        Me.txtSecuredDeposit.TabIndex = 156
        '
        'txtLoanProcessing
        '
        Me.txtLoanProcessing.AfterDecimal = 2
        Me.txtLoanProcessing.BeforeDecimal = 7
        Me.txtLoanProcessing.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanProcessing.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanProcessing.Location = New System.Drawing.Point(351, 22)
        Me.txtLoanProcessing.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLoanProcessing.MaxLength = 10
        Me.txtLoanProcessing.MaxValue = 0
        Me.txtLoanProcessing.MinValue = 0
        Me.txtLoanProcessing.Name = "txtLoanProcessing"
        Me.txtLoanProcessing.Size = New System.Drawing.Size(125, 23)
        Me.txtLoanProcessing.TabIndex = 155
        '
        'txtDocument
        '
        Me.txtDocument.AfterDecimal = 2
        Me.txtDocument.BeforeDecimal = 7
        Me.txtDocument.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocument.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDocument.Location = New System.Drawing.Point(96, 55)
        Me.txtDocument.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDocument.MaxLength = 10
        Me.txtDocument.MaxValue = 0
        Me.txtDocument.MinValue = 0
        Me.txtDocument.Name = "txtDocument"
        Me.txtDocument.Size = New System.Drawing.Size(125, 23)
        Me.txtDocument.TabIndex = 154
        '
        'txtBuildingFund
        '
        Me.txtBuildingFund.AfterDecimal = 2
        Me.txtBuildingFund.BeforeDecimal = 7
        Me.txtBuildingFund.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuildingFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBuildingFund.Location = New System.Drawing.Point(96, 22)
        Me.txtBuildingFund.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBuildingFund.MaxLength = 10
        Me.txtBuildingFund.MaxValue = 0
        Me.txtBuildingFund.MinValue = 0
        Me.txtBuildingFund.Name = "txtBuildingFund"
        Me.txtBuildingFund.Size = New System.Drawing.Size(125, 23)
        Me.txtBuildingFund.TabIndex = 153
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.LightYellow
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(231, 58)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(121, 16)
        Me.Label33.TabIndex = 87
        Me.Label33.Text = "Secured deposit:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.LightYellow
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(231, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(125, 16)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Loan processing :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.LightYellow
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 58)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 16)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "Document:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.LightYellow
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 16)
        Me.Label24.TabIndex = 84
        Me.Label24.Text = "Building fund:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(488, 134)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxLength = 7
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(168, 23)
        Me.txtReceiptNo.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 16)
        Me.Label20.TabIndex = 151
        Me.Label20.Text = "Surety Person Detail"
        '
        'lvSuretyDetail
        '
        Me.lvSuretyDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvSuretyDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSuretyDetail.FullRowSelect = True
        Me.lvSuretyDetail.GridLines = True
        Me.lvSuretyDetail.Location = New System.Drawing.Point(16, 281)
        Me.lvSuretyDetail.Name = "lvSuretyDetail"
        Me.lvSuretyDetail.Size = New System.Drawing.Size(656, 96)
        Me.lvSuretyDetail.TabIndex = 24
        Me.lvSuretyDetail.UseCompatibleStateImageBehavior = False
        Me.lvSuretyDetail.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "slNo"
        Me.ColumnHeader3.Width = 42
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        Me.ColumnHeader5.Width = 322
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PhoneNo"
        Me.ColumnHeader6.Width = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Interest Amount :"
        '
        'txtIntAmount
        '
        Me.txtIntAmount.AlphaNumeric = True
        Me.txtIntAmount.BackColor = System.Drawing.Color.White
        Me.txtIntAmount.BlankSpace = True
        Me.txtIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntAmount.GotFocusColour = System.Drawing.Color.White
        Me.txtIntAmount.Location = New System.Drawing.Point(488, 96)
        Me.txtIntAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIntAmount.Mandatory = False
        Me.txtIntAmount.MaxLength = 10
        Me.txtIntAmount.Name = "txtIntAmount"
        Me.txtIntAmount.ReadOnly = True
        Me.txtIntAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtIntAmount.SpecialChar = False
        Me.txtIntAmount.TabIndex = 7
        Me.txtIntAmount.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(353, 137)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 16)
        Me.Label28.TabIndex = 85
        Me.Label28.Text = "ReceiptNo :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.LightYellow
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(139, 16)
        Me.Label27.TabIndex = 83
        Me.Label27.Text = "Estimated Amount :"
        '
        'txtEstAmount
        '
        Me.txtEstAmount.AfterDecimal = 2
        Me.txtEstAmount.BeforeDecimal = 7
        Me.txtEstAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEstAmount.Location = New System.Drawing.Point(160, 16)
        Me.txtEstAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEstAmount.MaxLength = 10
        Me.txtEstAmount.MaxValue = 0
        Me.txtEstAmount.MinValue = 0
        Me.txtEstAmount.Name = "txtEstAmount"
        Me.txtEstAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtEstAmount.TabIndex = 1
        '
        'txtLFNo
        '
        Me.txtLFNo.AlphaNumeric = True
        Me.txtLFNo.BlankSpace = True
        Me.txtLFNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLFNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLFNo.Location = New System.Drawing.Point(472, 383)
        Me.txtLFNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLFNo.Mandatory = False
        Me.txtLFNo.MaxLength = 10
        Me.txtLFNo.Name = "txtLFNo"
        Me.txtLFNo.Size = New System.Drawing.Size(168, 23)
        Me.txtLFNo.SpecialChar = False
        Me.txtLFNo.TabIndex = 10
        Me.txtLFNo.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.LightYellow
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(352, 391)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "LF No:"
        Me.Label18.Visible = False
        '
        'txtRCTNo
        '
        Me.txtRCTNo.AlphaNumeric = True
        Me.txtRCTNo.BlankSpace = True
        Me.txtRCTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRCTNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRCTNo.Location = New System.Drawing.Point(144, 383)
        Me.txtRCTNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRCTNo.Mandatory = False
        Me.txtRCTNo.MaxLength = 10
        Me.txtRCTNo.Name = "txtRCTNo"
        Me.txtRCTNo.Size = New System.Drawing.Size(168, 23)
        Me.txtRCTNo.SpecialChar = False
        Me.txtRCTNo.TabIndex = 9
        Me.txtRCTNo.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 383)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 16)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "Dep.Rct.No"
        Me.Label22.Visible = False
        '
        'dtpODLoanDate
        '
        Me.dtpODLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpODLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpODLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpODLoanDate.Location = New System.Drawing.Point(488, 56)
        Me.dtpODLoanDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpODLoanDate.Name = "dtpODLoanDate"
        Me.dtpODLoanDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpODLoanDate.TabIndex = 6
        Me.dtpODLoanDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.ItemHeight = 16
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Suspended", "Closed"})
        Me.cmbStatus.Location = New System.Drawing.Point(488, 16)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(168, 24)
        Me.cmbStatus.TabIndex = 5
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.LightYellow
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(352, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(128, 16)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Account Status : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.LightYellow
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 16)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Balance  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightYellow
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "SMTL Limit :"
        '
        'txtODLimit
        '
        Me.txtODLimit.AfterDecimal = 2
        Me.txtODLimit.BeforeDecimal = 7
        Me.txtODLimit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtODLimit.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtODLimit.Location = New System.Drawing.Point(160, 56)
        Me.txtODLimit.LostFocusColour = System.Drawing.Color.Empty
        Me.txtODLimit.MaxLength = 10
        Me.txtODLimit.MaxValue = 0
        Me.txtODLimit.MinValue = 0
        Me.txtODLimit.Name = "txtODLimit"
        Me.txtODLimit.Size = New System.Drawing.Size(168, 23)
        Me.txtODLimit.TabIndex = 2
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 2
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.BeforeDecimal = 7
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.GotFocusColour = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(160, 96)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.White
        Me.txtBalance.MaxLength = 10
        Me.txtBalance.MaxValue = 0
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(168, 23)
        Me.txtBalance.TabIndex = 3
        Me.txtBalance.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.LightYellow
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 136)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 16)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Rate of Intrest :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtROI.BeforeDecimal = 2
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.HighlightText
        Me.txtROI.Location = New System.Drawing.Point(160, 136)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(72, 23)
        Me.txtROI.TabIndex = 4
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.LightYellow
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(352, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(97, 16)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "Applied Date:"
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.LightYellow
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbOthers.Controls.Add(Me.Panel6)
        Me.tbOthers.Controls.Add(Me.txtRemarks)
        Me.tbOthers.Controls.Add(Me.Label17)
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(736, 412)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnLoadPic)
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.Label61)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Label62)
        Me.Panel6.Controls.Add(Me.btnClose2)
        Me.Panel6.Controls.Add(Me.btnSignature)
        Me.Panel6.Location = New System.Drawing.Point(10, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(696, 232)
        Me.Panel6.TabIndex = 1
        '
        'btnLoadPic
        '
        Me.btnLoadPic.BackColor = System.Drawing.Color.LightYellow
        Me.btnLoadPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPic.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPic.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPic.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnLoadPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPic.Location = New System.Drawing.Point(80, 184)
        Me.btnLoadPic.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnLoadPic.Name = "btnLoadPic"
        Me.btnLoadPic.Size = New System.Drawing.Size(88, 40)
        Me.btnLoadPic.TabIndex = 2
        Me.btnLoadPic.Text = "Load"
        Me.btnLoadPic.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightYellow
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(168, 184)
        Me.btnClose.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(464, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 168)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(371, -21)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(65, 15)
        Me.Label61.TabIndex = 58
        Me.Label61.Text = "Signature"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(80, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 168)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(83, -21)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(39, 15)
        Me.Label62.TabIndex = 56
        Me.Label62.Text = "Photo"
        '
        'btnClose2
        '
        Me.btnClose2.BackColor = System.Drawing.Color.LightYellow
        Me.btnClose2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose2.ForeColor = System.Drawing.Color.Black
        Me.btnClose2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnClose2.Location = New System.Drawing.Point(552, 184)
        Me.btnClose2.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(80, 40)
        Me.btnClose2.TabIndex = 5
        Me.btnClose2.Text = "Cancel"
        Me.btnClose2.UseVisualStyleBackColor = False
        '
        'btnSignature
        '
        Me.btnSignature.BackColor = System.Drawing.Color.LightYellow
        Me.btnSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignature.ForeColor = System.Drawing.Color.Black
        Me.btnSignature.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnSignature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignature.Location = New System.Drawing.Point(464, 184)
        Me.btnSignature.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(88, 40)
        Me.btnSignature.TabIndex = 4
        Me.btnSignature.Text = "Load"
        Me.btnSignature.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(104, 248)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(600, 88)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Remarks :"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightYellow
        Me.TabPage1.Controls.Add(Me.Label96)
        Me.TabPage1.Controls.Add(Me.Label97)
        Me.TabPage1.Controls.Add(Me.Label98)
        Me.TabPage1.Controls.Add(Me.Label99)
        Me.TabPage1.Controls.Add(Me.Label100)
        Me.TabPage1.Controls.Add(Me.Label101)
        Me.TabPage1.Controls.Add(Me.Label102)
        Me.TabPage1.Controls.Add(Me.Label103)
        Me.TabPage1.Controls.Add(Me.Label87)
        Me.TabPage1.Controls.Add(Me.Label86)
        Me.TabPage1.Controls.Add(Me.Label89)
        Me.TabPage1.Controls.Add(Me.Label80)
        Me.TabPage1.Controls.Add(Me.Label77)
        Me.TabPage1.Controls.Add(Me.Label75)
        Me.TabPage1.Controls.Add(Me.Label74)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label95)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Label91)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(736, 412)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "SecurityDetails "
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(640, 240)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(80, 32)
        Me.Label96.TabIndex = 102
        Me.Label96.Text = "Maturity Amount"
        '
        'Label97
        '
        Me.Label97.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(552, 240)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(72, 32)
        Me.Label97.TabIndex = 101
        Me.Label97.Text = "Maturity Date"
        '
        'Label98
        '
        Me.Label98.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(456, 256)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(70, 16)
        Me.Label98.TabIndex = 100
        Me.Label98.Text = "Amount"
        '
        'Label99
        '
        Me.Label99.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(464, 240)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(32, 16)
        Me.Label99.TabIndex = 99
        Me.Label99.Text = "NSC"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(352, 248)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(71, 16)
        Me.Label100.TabIndex = 98
        Me.Label100.Text = "NSC Date"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(200, 248)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(44, 16)
        Me.Label101.TabIndex = 97
        Me.Label101.Text = "Name"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(56, 248)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(57, 16)
        Me.Label102.TabIndex = 96
        Me.Label102.Text = "NSC No"
        '
        'Label103
        '
        Me.Label103.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(16, 248)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(40, 19)
        Me.Label103.TabIndex = 95
        Me.Label103.Text = "SlNo"
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(648, 24)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(80, 32)
        Me.Label87.TabIndex = 94
        Me.Label87.Text = "Maturity Amount"
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(560, 24)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(72, 32)
        Me.Label86.TabIndex = 93
        Me.Label86.Text = "Maturity Date"
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(464, 40)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(70, 16)
        Me.Label89.TabIndex = 92
        Me.Label89.Text = "Amount"
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(472, 24)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(32, 16)
        Me.Label80.TabIndex = 91
        Me.Label80.Text = " FD "
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(360, 32)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(61, 16)
        Me.Label77.TabIndex = 90
        Me.Label77.Text = "FD Date"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(200, 32)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(44, 16)
        Me.Label75.TabIndex = 89
        Me.Label75.Text = "Name"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(56, 32)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(47, 16)
        Me.Label74.TabIndex = 88
        Me.Label74.Text = "FD No"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 19)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "SlNo"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(16, 224)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(84, 16)
        Me.Label95.TabIndex = 86
        Me.Label95.Text = "NSC Details"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.LightYellow
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(8, 272)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(736, 96)
        Me.Panel5.TabIndex = 85
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(16, 8)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(74, 16)
        Me.Label91.TabIndex = 84
        Me.Label91.Text = "FD Details"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.LightYellow
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(8, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 152)
        Me.Panel4.TabIndex = 83
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(504, 72)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 312)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(184, 40)
        Me.NewButton5.TabIndex = 5
        Me.NewButton5.Text = "&View Transaction Log"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton5.UseVisualStyleBackColor = False
        Me.NewButton5.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.LightYellow
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(555, 567)
        Me.btnOk.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 26
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightYellow
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(656, 567)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "SMTL Loan No:"
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(184, 72)
        Me.txtLoanNo.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 10
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.Size = New System.Drawing.Size(144, 23)
        Me.txtLoanNo.SpecialChar = False
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.Text = "SMTL"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(336, 72)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnSurety)
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 632)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 192)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(184, 40)
        Me.NewButton2.TabIndex = 8
        Me.NewButton2.Text = "SMTL Day End"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton2.UseVisualStyleBackColor = False
        Me.NewButton2.Visible = False
        '
        'btnSurety
        '
        Me.btnSurety.BackColor = System.Drawing.Color.LightYellow
        Me.btnSurety.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurety.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurety.ForeColor = System.Drawing.Color.Black
        Me.btnSurety.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnSurety.Image = CType(resources.GetObject("btnSurety.Image"), System.Drawing.Image)
        Me.btnSurety.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSurety.Location = New System.Drawing.Point(16, 232)
        Me.btnSurety.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnSurety.Name = "btnSurety"
        Me.btnSurety.Size = New System.Drawing.Size(184, 40)
        Me.btnSurety.TabIndex = 7
        Me.btnSurety.Text = "Surety &Person Details"
        Me.btnSurety.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSurety.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 272)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(184, 40)
        Me.NewButton1.TabIndex = 4
        Me.NewButton1.Text = "SMTL &Transaction"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightYellow
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(32, 567)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtLoanNo)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 632)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.LightYellow
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Olive
        Me.Label32.Location = New System.Drawing.Point(96, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(173, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "SMTL Loan Details"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightYellow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(472, 8)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(168, 128)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 80
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(360, 12)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(57, 17)
        Me.lblSignature.TabIndex = 79
        Me.lblSignature.Text = "Signature"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancelSign.Location = New System.Drawing.Point(560, 148)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 78
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(472, 148)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(88, 32)
        Me.btnLoadSign.TabIndex = 77
        Me.btnLoadSign.Text = "Load"
        Me.btnLoadSign.UseVisualStyleBackColor = False
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 148)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 73
        Me.btnLoadPhoto.Text = "Load"
        Me.btnLoadPhoto.UseVisualStyleBackColor = False
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 148)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 74
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(136, 12)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 128)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 76
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(16, 8)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(37, 17)
        Me.lblPhoto.TabIndex = 75
        Me.lblPhoto.Text = "Photo"
        '
        'frmSMTLLoanDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1010, 615)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSMTLLoanDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMTL Loan Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbGoldLoanDetails.ResumeLayout(False)
        Me.tbGoldLoanDetails.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSMTLLoanDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSMTLLoanDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSMTLLoanDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSMTLLoanDetails)
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

#End Region

#Region "Photo and Signature Loading"

    Private Sub btnLoadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OfdPic As New OpenFileDialog
        OfdPic.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdPic.ShowDialog() = DialogResult.OK Then
            picPhoto.Image = Image.FromFile(OfdPic.FileName)
        End If
    End Sub

    Private Sub btnCancelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Sub sbGeneral()
        Dim msStream As MemoryStream
        Dim objDT As DataTable
        Dim flag As Boolean = False
        Try
            If txtCustomerID.Text <> "" Then
                If objPerson.fnGetCustomerID(txtCustomerID.Text) Then
                    objDT = objPerson.PersonTable
                    flag = True
                End If
                'ElseIf txtSBNo.Text <> "" Then
                '    objSBAccount1.fnGetSBAccountDetails(txtSBNo.Text)
                '    objDT = objSBAccount1.SBAccTable
            End If
            sbClear()
            If objDT.Rows.Count > 0 Then

                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                'If flag Then
                '    If objSBAccount1.fnGetSBDetal(txtCustomerID.Text) Then
                '        txtSBNo.Text = objSBAccount1.SBAccTable.Rows(0).Item("AccountNo")
                '    End If
                '    btnSBSearch.Enabled = False
                '    'Else
                '    '    txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
                '    '    btnMemSearch.Enabled = False
                'End If

                'txtSBNo.ReadOnly = True
                'txtMem    berNo.ReadOnly = True

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
                OfficeNo = objDT.Rows(0).Item("OfficeNo")


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
                txtName.Focus()
            End If
        Catch ex As Exception
        End Try

    End Sub
    Function fnLoadSuretyPerson()
        Dim objdT As New DataTable
        Dim lvItem As ListViewItem
        Dim IntCounter As Integer = 0
        lvSuretyDetail.Items.Clear()
        If objSurety.fnGetSurety(txtLoanNo.Text, "S") Then
            objdT = objSurety.CheckSuretytable
            While IntCounter < objdT.Rows.Count
                lvItem = lvSuretyDetail.Items.Add(IntCounter + 1)
                lvItem.SubItems.Add(objdT.Rows(IntCounter).Item("Name"))
                lvItem.SubItems.Add(objdT.Rows(IntCounter).Item("Address"))
                lvItem.SubItems.Add(objdT.Rows(IntCounter).Item("PhoneNo"))
                IntCounter += 1
            End While
        End If
    End Function

    Function fnCheck() As Boolean
        Dim intCount As Integer
        If Trim(txtLoanNo.Text) = "OD" Then
            MsgBox("Enter account no ", MsgBoxStyle.Exclamation)
            txtLoanNo.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name ", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
            'ElseIf Trim(txtMemberNo.Text) = String.Empty Then
            '    MsgBox("Please check Member Number")
            '    txtMemberNo.Focus()
            '    Return False
        ElseIf Trim(txtFatherName.Text) = String.Empty Then
            MsgBox("Enter father name ", MsgBoxStyle.Exclamation)
            txtFatherName.Focus()
            Return False
        ElseIf Trim(txtAge.Text) = String.Empty Then
            MsgBox("Enter age ", MsgBoxStyle.Exclamation)
            txtAge.Focus()
            Return False
        ElseIf Trim(txtPermAddress.Text) = String.Empty Then
            MsgBox("Enter address", MsgBoxStyle.Exclamation)
            txtPermAddress.Focus()
            Return False
        ElseIf txtEstAmount.Text = "" Then
            MsgBox("Enter estimated amount", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbGoldLoanDetails
            txtEstAmount.Focus()
        ElseIf Trim(txtODLimit.Text) = String.Empty Then
            MsgBox("Enter OD limit amount", MsgBoxStyle.Exclamation)
            txtODLimit.Focus()
            Return False
        ElseIf (Mid(txtODLimit.Text, 1, 1)) = 0 Then
            MsgBox("Please check the OD limit amount", MsgBoxStyle.Information)
            txtODLimit.Focus()
            Return False
        ElseIf Val(txtODLimit.Text) > Val(txtEstAmount.Text) Then
            MsgBox("OD limit amount should not be more than" & Label27.Text & " Amount", MsgBoxStyle.Exclamation, "Loan Module")
            txtODLimit.Focus()
            Return False
        ElseIf Trim(txtROI.Text) = String.Empty Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False
        ElseIf cmbStatus.SelectedIndex = -1 Then
            MsgBox("Select status of OD", MsgBoxStyle.Exclamation)
            cmbStatus.Focus()
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Please enter receipt no", MsgBoxStyle.Exclamation, "Loan Module")
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    Public Function fnGetROI() As Boolean
        If objSBAccount.fnGetROI(txtLoanNo.Text, txtODLimit.Text) Then
            txtROI.Text = (objSBAccount.Loantypetable.Rows(0).Item("ROI"))
        End If
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpODLoanDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        Dim strNarration As String = "By new OD account " & txtLoanNo.Text & "  "

        Dim strsql = "insert into odtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtLoanNo.Text) & "','" & Format(dtpODLoanDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Val(txtBalance.Text) & "','0',sum(Withdraw)-sum(Deposit)+'" & Val(txtBalance.Text) & "','0','0',0,'" & Val(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from odtransactiontbl where accountno='" & Trim(txtLoanNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReceiptNo.Text, dtpODLoanDate.Value, Val(txtBalance.Text), "Deposit by" & txtLoanNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpODLoanDate.Value, "Deposit by OD account " & txtLoanNo.Text, "To", 12, 0, Val(txtBalance.Text), 1, "Y", objTrans)
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpODLoanDate.Value, "Deposit by OD account " & txtLoanNo.Text, "By", 1, Val(txtBalance.Text), 0, 2, "Y", objTrans)

        Return True

    End Function

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objSMTL.fnChekSMTLAccount(Trim(txtLoanNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objSMTL.fnAddSMTLAccount(objTrans) = True Then
                'fnGenerateVoucher()
                'Log Entry
                fnLogEntry(pbUserId, "New SMTL created " & txtLoanNo.Text, Date.Now, "New SMTL", objTrans)

                MessageBox.Show("New SMTL created successfully.", "SMTL Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New SMTL creation failed, because of internal error.", "SMTL Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
        Else

            'update details (edit mode)

            If objSMTL.fnUpdateLoanDetails(Trim(txtLoanNo.Text), objTrans) Then
                fnUpdateSecuretyDetails(objTrans)
                fnLogEntry(pbUserId, "SMTL updated" & txtLoanNo.Text, Date.Now, "Update SMTL Account", objTrans)
                MessageBox.Show("SMTL(Secured Multi Transaction Loan) account updated successfully.", "SMTL Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("SMTL account updation failed, because of internal error.", "SMTL Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function

    Function fnUpdateSecuretyDetails(ByVal objTrans As IDbTransaction) As Boolean
        'If objSMTL.fnDeleteSecuretyDetail(Trim(txtLoanNo.Text), objTrans) Then
        '    If objSMTL.fnInsertSecurityDetailsInfo(objTrans) Then
        '    End If
        'End If
    End Function

    Public Function fnLoadLoanAgDepositControl() As Boolean
        Dim intCount As Integer = 0
        Dim Controlht As Integer = 0
        While intCount < 10
            LoanAgDepositCont(intCount) = New LoansOnDepositControl
            Controlht = LoanAgDepositCont(intCount).Height
            LoanAgDepositCont(intCount).Top = Controlht * intCount
            Panel4.Controls.Add(LoanAgDepositCont(intCount))
            Panel4.Controls.Add(LoanAgDepositCont(intCount))
            intCount += 1
        End While
    End Function

    Public Function fnLoadLoanAgNSCControl() As Boolean
        Dim intCount As Integer = 0
        Dim Controlht As Integer = 0
        While intCount < 5
            LoanAgNSCCont(intCount) = New LoansOnDepositControl
            Controlht = LoanAgNSCCont(intCount).Height
            LoanAgNSCCont(intCount).Top = Controlht * intCount
            Panel5.Controls.Add(LoanAgNSCCont(intCount))
            Panel5.Controls.Add(LoanAgNSCCont(intCount))
            intCount += 1
        End While
    End Function
    Function fnSetData() As Boolean
        Dim intcount As Integer
        ' Person Deatils
        If lngPersonNo <> 0 Then
            objSMTL.PersonNo = lngPersonNo
        Else
            objSMTL.PersonNo = objSMTL.fnGetNewPersonNo()
        End If

        objSMTL.Name = txtName.Text
        objSMTL.FatherName = txtFatherName.Text
        objSMTL.PermAddress = txtPermAddress.Text
        objSMTL.PresAddress = txtPresAddress.Text

        If txtPhoneNo.Text = "" Then
            objSMTL.PhoneNo = 0
        Else
            objSMTL.PhoneNo = txtPhoneNo.Text
        End If

        If txtMobileNo.Text = "" Then
            objSMTL.MobileNo = 0
        Else
            objSMTL.MobileNo = txtMobileNo.Text
        End If

        objSMTL.DOB = Format(dtpDOB.Value, "yyyy-MM-dd")
        objSMTL.Age = txtAge.Text
        objSMTL.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objSMTL.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objSMTL.ReligionCode = cmbReligion.SelectedValue
        objSMTL.OccupationCode = cmbOccupation.SelectedValue
        objSMTL.Balance = "0.00"
        objSMTL.IntrestAmount = "0.00"
        objSMTL.OfficeNo = OfficeNo
        'Loan Details

        objSMTL.AccountNo = txtLoanNo.Text

        If rdbDeposit.Checked = True Then
            objSMTL.SMTLAgainst = "D"
        Else
            objSMTL.SMTLAgainst = "S"
        End If

        objSMTL.FDNo = 0
        objSMTL.MemberNo = txtCustomerID.Text
        objSMTL.SBNo = 0

        Select Case cmbStatus.SelectedItem
            Case "Active"
                objSMTL.AccAtatus = "A"
            Case "Suspended"
                objSMTL.AccAtatus = "S"
            Case "Closed"
                objSMTL.AccAtatus = "C"
        End Select

        objSMTL.AppDate = Format(dtpODLoanDate.Value, "yyyy-MM-dd")
        objSMTL.LastTransaction = Format(dtpODLoanDate.Value, "yyyy-MM-dd")
        objSMTL.SMTLLimit = txtODLimit.Text
        objSMTL.EstAmount = txtEstAmount.Text

        objSMTL.RIO = (txtROI.Text / 100)
        objSMTL.Remarks = txtRemarks.Text
        objSMTL.ReciptNo = txtReceiptNo.Text
        objSMTL.Balance = Val(txtBalance.Text)
        objSMTL.IntrestAmount = Val(txtIntAmount.Text)

        objSMTL.ReciptNo = txtReceiptNo.Text

        objSMTL.LFNo = txtLFNo.Text
        objSMTL.DepRCTNo = txtRCTNo.Text

        intcount = 0
        Dim dtDepositDet As LoansOnDepositControl
        Dim dr As DataRow

        Dim dtFD As New DataTable
        dtFD.Columns.Add("LoanNo")
        dtFD.Columns.Add("DepositType")
        dtFD.Columns.Add("DepositTypeNo")
        dtFD.Columns.Add("NameOfDepositor")
        dtFD.Columns.Add("DepositDate")
        dtFD.Columns.Add("DepositAmt")
        dtFD.Columns.Add("MatDate")
        dtFD.Columns.Add("MatAmt")

        While intcount < 10
            dtDepositDet = Panel4.Controls(intcount)
            dr = dtFD.NewRow
            dr(0) = txtLoanNo.Text
            dr(1) = "FD"
            If dtDepositDet.FDNumber.Text <> "" Then
                dr(2) = dtDepositDet.FDNumber.Text
                dr(3) = dtDepositDet.FDPName.Text
                dr(4) = Format(dtDepositDet.FDMatdate.Value, "yyyy-MM-dd")
                dr(5) = dtDepositDet.FDAmount.Text
                dr(6) = Format(dtDepositDet.FDMatdate.Value, "yyyy-MM-dd")
                dr(7) = dtDepositDet.FDMatAmount.Text
                dtFD.Rows.Add(dr)
            End If
            intcount += 1
        End While
        dr = Nothing
        objSMTL.FDDetailstable = dtFD

        intcount = 0
        While intcount < 5
            dtDepositDet = Panel5.Controls(intcount)
            dr = dtFD.NewRow
            dr(0) = txtLoanNo.Text
            dr(1) = "NSC"
            If dtDepositDet.FDNumber.Text <> "" Then
                dr(2) = dtDepositDet.FDNumber.Text
                dr(3) = dtDepositDet.FDPName.Text
                dr(4) = Format(dtDepositDet.FDMatdate.Value, "yyyy-MM-dd")
                dr(5) = dtDepositDet.FDAmount.Text
                dr(6) = Format(dtDepositDet.FDMatdate.Value, "yyyy-MM-dd")
                dr(7) = dtDepositDet.FDMatAmount.Text
                dtFD.Rows.Add(dr)
            End If
            intcount += 1
        End While
        dr = Nothing
        objSMTL.NSCDetailsTable = dtFD


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
                        btnAdd_Click(sender, e)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

    Private Sub frmSBAccCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = "12/31/9988 11:59:59 PM"
        dtpODLoanDate.MaxDate = "12/31/9988 11:59:59 PM"
        dtpODLoanDate.Value = Date.Now
        sbLoadControlValues() 'Load Values 
        If txtLoanNo.Text <> String.Empty Then
            sbLoadSMTLAccDetails()
        End If
        fnLoadLoanAgDepositControl()
        fnLoadLoanAgNSCControl()
        btnAdd_Click(sender, e)
        txtLoanNo.Focus()
    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtLoanNo.Text = "OD" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanNo.KeyPress

        If txtLoanNo.Text = "OD" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyDown

        If txtLoanNo.Text = "OD" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmSMTLsearch As New frmSMTLsearch
        objfrmSMTLsearch.strODLoan = String.Empty
        objfrmSMTLsearch.ShowDialog(Me)
        If objfrmSMTLsearch.strODLoan <> String.Empty Then
            txtLoanNo.Text = objfrmSMTLsearch.strODLoan
            sbLoadSMTLAccDetails()
        End If
        objfrmSMTLsearch.Dispose()

    End Sub

    Private Sub btnMemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtCustomerID.Text = objMemberSearch.strMemberNo
            sbLoadMember()
        End If
        objMemberSearch.Dispose()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click

        If txtLoanNo.Text <> "OD" Then
            Dim objfrmTransaction As New frmTransaction
            objfrmTransaction.txtLoanNo.Text = txtLoanNo.Text
            objfrmTransaction.txtName.Text = txtName.Text
            objfrmTransaction.ShowDialog(Me)
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        nMode = CTAdd
        sbClear()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objSBAccount.fnGetNewSMTLNo("SMTL"), 5, 10)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "SMTL" & String.Format("{0:00000}", CInt(TempNewNo))
            txtLoanNo.Text = Temp
            txtLoanNo.Focus()
        Else
            MsgBox("SMTL number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub
#End Region

#Region "Genral Subroutines"

    Sub sbLoadSMTLAccDetails()

        Dim objDT As DataTable
        Dim intcount As Integer
        Dim msStream As MemoryStream
        Try
            If objSMTL.fnGetLoanDetails(txtLoanNo.Text) Then
                sbClear()

                objDT = objSMTL.SMTLLoanDettable

                'Sb(Details)

                txtLoanNo.Text = objDT.Rows(0).Item("AccountNo")
                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                'Person(Deatils)
                txtName.Text = objDT.Rows(0).Item("Name")
                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")
                IIf(objDT.Rows(0).Item("Gender") = "M", rdbMale.Checked = True, rdbFemale.Checked = True)
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")
                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                txtName.Focus()

                If objDT.Rows(0).Item("ODAgainst") = "D" Then
                    rdbDeposit.Checked = True
                Else
                    rdbShare.Checked = True
                End If
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtODLimit.Text = objDT.Rows(0).Item("OdLimit")
                txtEstAmount.Text = objDT.Rows(0).Item("EstimatedAmt")
                txtBalance.Text = objDT.Rows(0).Item("Balance")
                txtBalance.ReadOnly = True
                txtROI.Text = (objDT.Rows(0).Item("ROI") * 100)
                Select Case objDT.Rows(0).Item("AccStatus")
                    Case "A"
                        cmbStatus.SelectedItem = "Active"
                    Case "S"
                        cmbStatus.SelectedItem = "Suspended"
                    Case "C"
                        cmbStatus.SelectedItem = "Closed"
                End Select
                dtpODLoanDate.Value = CDate(objDT.Rows(0).Item("AccDate"))
                txtIntAmount.Text = objDT.Rows(0).Item("IntAmount")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")

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

                Dim dtSecurity As DataTable
                If objSMTL.fnGetFDSecurityDetails(txtLoanNo.Text) = True Then
                    dtSecurity = objSMTL.FDDetailstable
                    intcount = 0
                    While intcount < dtSecurity.Rows.Count
                        LoanAgDepositCont(intcount).txtSlNo.Text = intcount + 1
                        LoanAgDepositCont(intcount).txtFDNo.Text = dtSecurity.Rows(intcount).Item("DepositTypeNo")
                        LoanAgDepositCont(intcount).txtName.Text = dtSecurity.Rows(intcount).Item("NameOfDepositor")
                        LoanAgDepositCont(intcount).dtpFDDate.Value = Format(dtSecurity.Rows(intcount).Item("DepositDate"), "yyyy-MM-dd")
                        LoanAgDepositCont(intcount).txtFDAmt.Text = dtSecurity.Rows(intcount).Item("DepositAmt")
                        LoanAgDepositCont(intcount).dtpMatDate.Value = Format(dtSecurity.Rows(intcount).Item("MatDate"), "yyyy-MM-dd")
                        LoanAgDepositCont(intcount).txtMatAmt.Text = dtSecurity.Rows(intcount).Item("MatAmt")
                        intcount += 1
                    End While
                End If
                If objSMTL.fnGetNSCSecurityDetails(txtLoanNo.Text) = True Then
                    dtSecurity = objSMTL.NSCDetailsTable
                    intcount = 0
                    While intcount < dtSecurity.Rows.Count
                        LoanAgNSCCont(intcount).txtSlNo.Text = intcount + 1
                        LoanAgNSCCont(intcount).txtFDNo.Text = dtSecurity.Rows(intcount).Item("DepositTypeNo")
                        LoanAgNSCCont(intcount).txtName.Text = dtSecurity.Rows(intcount).Item("NameOfDepositor")
                        LoanAgNSCCont(intcount).dtpFDDate.Value = Format(dtSecurity.Rows(intcount).Item("DepositDate"), "yyyy-MM-dd")
                        LoanAgNSCCont(intcount).txtFDAmt.Text = dtSecurity.Rows(intcount).Item("DepositAmt")
                        LoanAgNSCCont(intcount).dtpMatDate.Value = Format(dtSecurity.Rows(intcount).Item("MatDate"), "yyyy-MM-dd")
                        LoanAgNSCCont(intcount).txtMatAmt.Text = dtSecurity.Rows(intcount).Item("MatAmt")
                        intcount += 1
                    End While
                End If
                fnLoadSuretyPerson()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub sbClear()

        Dim intCount As Integer = 0
        lngPersonNo = 0
        txtCustomerID.ResetText()
        txtCustomerID.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpDOB.ResetText()
        rdbMale.Checked = True
        txtAge.ResetText()
        cmbReligion.SelectedIndex = 0
        cmbCaste.ResetText()
        cmbOccupation.ResetText()
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        picPhoto.Image = Nothing
        picSignature.Image = Nothing

        txtRemarks.ResetText()
        txtMobileNo2.ResetText()
        txtODLimit.ResetText()
        txtEstAmount.ResetText()
        txtBalance.ResetText()
        txtIntAmount.ResetText()
        txtReceiptNo.ResetText()

        cmbStatus.SelectedIndex = -1
        lvSuretyDetail.Items.Clear()

        txtODLimit.Enabled = True
        txtROI.Enabled = True
        txtReceiptNo.ReadOnly = False
        txtEstAmount.ReadOnly = False
        txtLoanNo.ReadOnly = False
        ' txtBalance.ReadOnly = False


        intCount = 0
        While intCount < Panel1.Controls.Count
            LoanAgDepositCont(intCount).txtSlNo.ResetText()
            LoanAgDepositCont(intCount).txtFDNo.ResetText()
            LoanAgDepositCont(intCount).txtName.ResetText()
            LoanAgDepositCont(intCount).txtFDAmt.ResetText()
            LoanAgDepositCont(intCount).txtMatAmt.ResetText()
            intCount += 1
        End While
        intCount = 0
        While intCount < Panel5.Controls.Count
            LoanAgNSCCont(intCount).txtSlNo.ResetText()
            LoanAgNSCCont(intCount).txtFDNo.ResetText()
            LoanAgNSCCont(intCount).txtName.ResetText()
            LoanAgNSCCont(intCount).txtFDAmt.ResetText()
            LoanAgNSCCont(intCount).txtMatAmt.ResetText()
            intCount += 1
        End While

    End Sub

    Sub sbLoadMember()
        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            objMember.fnGetMemberDetails(txtCustomerID.Text)
            objDT = objMember.MemberTable


            If objDT.Rows.Count > 0 Then
                sbClear()
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
                        PictureBox3.Image = Image.FromStream(msStream)
                        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        PictureBox2.Image = Image.FromStream(msStream)
                        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If

                End If
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtName.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.TextChanged

        If Not txtLoanNo.Text.StartsWith("OD") Then
            txtLoanNo.Undo()
            txtLoanNo.ClearUndo()
        End If

    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.Leave

        'If objSMTL.fnChekODLAccount(Trim(txtLoanNo.Text)) = True Then
        '    If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        sbLoadODLAccDetails()
        '    Else
        '        txtLoanNo.Focus()
        '    End If
        'End If

    End Sub

    Private Sub dtpDOB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged

        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)

    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged

        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If

    End Sub

#Region "Navigation"

    Private Sub cmbInstallmentType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbCaste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCaste.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbModeOfPayment_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbOccupation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOccupation.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbPermVillage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbPresVillage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbReason_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbStatus.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbReligion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReligion.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub dtpDOB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub dtpGoldLoanDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpODLoanDate.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub rdbFemale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbFemale.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub rdbMajor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbMajor.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtAddress1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtAddress2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtAge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAge.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtExpectedAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtODLimit.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtFatherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFatherName.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtGoldWeight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtMemberNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtPermAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPermAddress.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhoneNo.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtPresAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPresAddress.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtROI_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtROI.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtSanctionedAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBalance.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtWitnessPerson1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtWitnessPerson2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub chkSame_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtAddress2_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtRCTNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRCTNo.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtWitnessPerson2_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

#End Region

    Private Sub btnLoadPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPic.Click

        Dim OfdPic As New OpenFileDialog
        OfdPic.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdPic.ShowDialog() = DialogResult.OK Then
            PictureBox3.Image = Image.FromFile(OfdPic.FileName)
        End If

    End Sub

    Private Sub btnSignature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignature.Click

        Dim OfdSig As New OpenFileDialog
        OfdSig.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdSig.ShowDialog() = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OfdSig.FileName)
        End If

    End Sub

    Private Sub rdbDeposit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbDeposit.CheckedChanged
        If rdbDeposit.Checked = True Then

        End If
    End Sub

    Private Sub rdbShare_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbShare.CheckedChanged
        If rdbShare.Checked = True Then

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        PictureBox3.Image = Nothing
    End Sub

    Private Sub btnClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose2.Click
        PictureBox2.Image = Nothing
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        If objSMTL.fnChekSMTLAccount(Trim(txtLoanNo.Text)) = True Then
            Dim ObjWithDraw As New frmSMTLTransaction
            ObjWithDraw.txtAccNo.Text = txtLoanNo.Text
            ObjWithDraw.txtName.Text = txtName.Text
            ObjWithDraw.ShowDialog(Me)
        Else
            MsgBox("Please enter valid SMTL number", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtODLimit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtODLimit.Leave
        If txtODLimit.Text = "" Then
            MsgBox("Enter sanctioned amount to load rate of intrest", MsgBoxStyle.Exclamation)
        Else
            fnGetROI()
            txtODLimit_TabIndexChanged(sender, e)
        End If

    End Sub

    Private Sub btnSurety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurety.Click
        If txtLoanNo.Text <> "SMTL" Then
            Dim objfrmSurety As New frmHomeLoanSurety
            objfrmSurety.BackColor = GroupBox1.BackColor
            objfrmSurety.TabPage1.BackColor = GroupBox1.BackColor
            objfrmSurety.btnOk.GotFocusColour = btnAdd.GotFocusColour
            objfrmSurety.txtLoanNo.Text = txtLoanNo.Text
            objfrmSurety.txtLoanerName.Text = txtName.Text
            objfrmSurety.chrType = "S"
            objfrmSurety.ShowDialog(Me)
            objfrmSurety.Dispose()
            fnLoadSuretyPerson()
        Else
            MsgBox("Enter valid SMTL number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If
    End Sub

    Private Sub txtMobileNo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
            TabControl1.Focus()
        End If
    End Sub

    Private Sub txtReceiptNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 2
            TabControl1.Focus()
        End If
    End Sub

    Private Sub txtRemarks_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 3
            TabControl1.Focus()
        End If
    End Sub

    Private Sub btnMemSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemSearch.Click
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            txtCustomerID.Text = objCustomerList.strCustomerID
            sbGeneral()
        End If
        objCustomerList.Dispose()
    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim objSBSearch As New frmSBAccSearch
        'objSBSearch.strSBAccountNo = ""
        'objSBSearch.ShowDialog(Me)
        'If objSBSearch.strSBAccountNo <> "" Then
        '    sbClear()
        '    txtSBNo.Text = objSBSearch.strSBAccountNo
        '    sbGeneral()
        '    objSBSearch.Dispose()
        'End If
        Dim objAccountSelection As New frmAccountSelection
        objAccountSelection.ShowDialog(Me)
        'txtSBNo.Text = objAccountSelection.strAccountNo
        objAccountSelection.Dispose()
        Dim strType1 As String = Mid(objAccountSelection.strAccountNo, 1, 2)

        'If (strType1 = "SB") Then
        '    Label39.Text = "SB No. :"
        'Else
        '    Label39.Text = "CA No. :"

        'End If

        objAccountSelection.Dispose()

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        Dim objfrmoddayend As New frmoddayend
        objfrmoddayend.ShowDialog(Me)
    End Sub
    Private Sub txtODLimit_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        funChargeClear()
        If txtODLimit.Text = "" Then
            OdLimit = 0
        Else
            OdLimit = Convert.ToDouble(txtODLimit.Text)
        End If

      
    End Sub
    Sub funChargeClear()

        txtBuildingFund.ResetText()
        txtSecuredDeposit.ResetText()
        txtDocument.ResetText()
        txtLoanProcessing.ResetText()

    End Sub
    Function fnLoadBuildingFundData() As Boolean
        Dim ComparisionOperator As String
        Dim CompareNumber As Double
        Dim Charge As Double
        Dim counter As Integer = 0
        Dim dtTable As DataTable
        'If objBankCharges.fnGetBuildingFund = True Then
        If objBankCharges.fnGetBuildingFund() = True Then
            dtTable = objBankCharges.BuildingFundTable
            While counter <= objBankCharges.BuildingFundTable.Rows.Count
                ComparisionOperator = objBankCharges.BuildingFundTable.Rows.Item(counter).Item("Comparision").ToString()
                CompareNumber = Convert.ToDouble(objBankCharges.BuildingFundTable.Rows.Item(counter).Item("Amount").ToString())
                Charge = Convert.ToDouble(objBankCharges.BuildingFundTable.Rows.Item(counter).Item("Charges").ToString())

                Select Case ComparisionOperator
                    Case "="
                        If OdLimit = CompareNumber Then
                            txtBuildingFund.Text = Charge
                            Return True
                        End If
                    Case "<"
                        If OdLimit < CompareNumber Then
                            txtBuildingFund.Text = Charge
                            Return True
                        End If
                    Case "<="
                        If OdLimit <= CompareNumber Then
                            txtBuildingFund.Text = Charge
                            Return True
                        End If
                    Case ">"
                        If OdLimit > CompareNumber Then
                            txtBuildingFund.Text = Charge
                            Return True
                        End If
                    Case ">="
                        If OdLimit >= CompareNumber Then
                            txtBuildingFund.Text = Charge
                            Return True
                        End If

                End Select
                counter += 1
            End While
        End If
    End Function
    Function fnLoadComputerOperatorData() As Boolean
        Dim ComparisionOperator As String
        Dim CompareNumber As Double
        Dim Charge As Double
        Dim counter As Integer = 0
        Dim dtTable As DataTable

        If objBankCharges.fnDocTable() = True Then
            While counter < objBankCharges.DocTable.Rows.Count
                ComparisionOperator = objBankCharges.DocTable.Rows.Item(counter).Item("Comparision").ToString()
                CompareNumber = Convert.ToDouble(objBankCharges.DocTable.Rows.Item(counter).Item("Amount").ToString())
                Charge = Convert.ToDouble(objBankCharges.DocTable.Rows.Item(counter).Item("Charges").ToString())

                Select Case ComparisionOperator
                    Case "="
                        If OdLimit = CompareNumber Then
                            txtDocument.Text = Charge
                            Return True
                        End If
                    Case "<"
                        If OdLimit < CompareNumber Then
                            txtDocument.Text = Charge
                            Return True
                        End If
                    Case "<="
                        If OdLimit <= CompareNumber Then
                            txtDocument.Text = Charge
                            Return True
                        End If
                    Case ">"
                        If OdLimit > CompareNumber Then
                            txtDocument.Text = Charge
                            Return True
                        End If
                    Case ">="
                        If OdLimit >= CompareNumber Then
                            txtDocument.Text = Charge
                            Return True
                        End If

                End Select
                counter += 1
            End While
        End If
    End Function
    Function fnLoadLoanProcessingData() As Boolean
        Dim ComparisionOperator As String
        Dim CompareNumber As Double
        Dim Charge As Double
        Dim counter As Integer = 0
        Dim dtTable As DataTable
        If objBankCharges.fnLoanProcessing() = True Then
            While counter < objBankCharges.LoanProcessingTable.Rows.Count
                ComparisionOperator = objBankCharges.LoanProcessingTable.Rows.Item(counter).Item("Comparision").ToString()
                CompareNumber = Convert.ToDouble(objBankCharges.LoanProcessingTable.Rows.Item(counter).Item("Amount").ToString())
                Charge = Convert.ToDouble(objBankCharges.LoanProcessingTable.Rows.Item(counter).Item("Charges").ToString())

                Select Case ComparisionOperator
                    Case "="
                        If OdLimit = CompareNumber Then
                            txtLoanProcessing.Text = Charge
                            Return True
                        End If
                    Case "<"
                        If OdLimit < CompareNumber Then
                            txtLoanProcessing.Text = Charge
                            Return True
                        End If
                    Case "<="
                        If OdLimit <= CompareNumber Then
                            txtLoanProcessing.Text = Charge
                            Return True
                        End If
                    Case ">"
                        If OdLimit > CompareNumber Then
                            txtLoanProcessing.Text = Charge
                            Return True
                        End If
                    Case ">="
                        If OdLimit >= CompareNumber Then
                            txtLoanProcessing.Text = Charge
                            Return True
                        End If

                End Select
                counter += 1
            End While
        End If
    End Function
    Function fnLoadSecurityDepositData() As Boolean
        Dim ComparisionOperator As String
        Dim CompareNumber As Double
        Dim Charge As Double
        Dim counter As Integer = 0
        Dim dtTable As DataTable

        If objBankCharges.fnSecuredDeposit() = True Then
            While counter < objBankCharges.SecuredDepositTable.Rows.Count
                ComparisionOperator = objBankCharges.SecuredDepositTable.Rows.Item(counter).Item("Comparision").ToString()
                CompareNumber = Convert.ToDouble(objBankCharges.SecuredDepositTable.Rows.Item(counter).Item("Amount").ToString())
                Charge = Convert.ToDouble(objBankCharges.SecuredDepositTable.Rows.Item(counter).Item("Charges").ToString())

                Select Case ComparisionOperator
                    Case "="
                        If OdLimit = CompareNumber Then
                            txtSecuredDeposit.Text = CompareNumber
                            Return True
                        End If
                    Case "<"
                        If OdLimit < CompareNumber Then
                            txtSecuredDeposit.Text = Charge
                            Return True
                        End If
                    Case "<="
                        If OdLimit <= CompareNumber Then
                            txtSecuredDeposit.Text = Charge
                            Return True
                        End If
                    Case ">"
                        If OdLimit > CompareNumber Then
                            txtSecuredDeposit.Text = Charge
                            Return True
                        End If
                    Case ">="
                        If OdLimit >= CompareNumber Then
                            txtSecuredDeposit.Text = Charge

                        End If

                End Select
                counter += 1
            End While
        End If

    End Function


    Private Sub btnBankCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBankCharges.Click
        If btnBankCharges.Checked = True Then
            fnLoadBuildingFundData()
            fnLoadComputerOperatorData()
            fnLoadLoanProcessingData()
            fnLoadSecurityDepositData()
        Else
            txtSecuredDeposit.ResetText()
            txtLoanProcessing.ResetText()
            txtDocument.ResetText()
            txtBuildingFund.ResetText()
        End If
        
    End Sub
End Class
