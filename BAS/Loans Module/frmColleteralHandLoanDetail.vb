Imports System.IO

Public Class frmColleteralHandLoanDetail
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents clSlNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clChkDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDocuments As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSurety As BankControls.NewButton
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents txtMonthlyExp As BankControls.NumericControl
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtNoofDependant As BankControls.NumericControl
    Friend WithEvents txtPerService As BankControls.NumericControl
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As BankControls.TextControl
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeName As BankControls.TextControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents tbOccupationDetails As System.Windows.Forms.TabPage
    Friend WithEvents pnlBus As System.Windows.Forms.Panel
    Friend WithEvents txtNatofBusiness As BankControls.TextControl
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents txtTaxDetail As BankControls.TextControl
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txtDocument As BankControls.TextControl
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents dtpYearofEst As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAnuIncome As BankControls.NumericControl
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtAnnuTurnover As BankControls.NumericControl
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents chkBusiness As System.Windows.Forms.CheckBox
    Friend WithEvents pnlsal As System.Windows.Forms.Panel
    Friend WithEvents txtMonthlyDomesticExp As BankControls.NumericControl
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtNetSAlary As BankControls.NumericControl
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDeduction As BankControls.NumericControl
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtOtherDeductions As BankControls.NumericControl
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtHBA As BankControls.NumericControl
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtInsuPremium As BankControls.NumericControl
    Friend WithEvents txtProvidentFund As BankControls.NumericControl
    Friend WithEvents txtIncomeTax As BankControls.NumericControl
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtOtherAll As BankControls.NumericControl
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtCityComensatoryAll As BankControls.NumericControl
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtHouseRentAll As BankControls.NumericControl
    Friend WithEvents txtDeamessAll As BankControls.NumericControl
    Friend WithEvents txtBasic As BankControls.NumericControl
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents chkSalary As System.Windows.Forms.CheckBox
    Friend WithEvents tbGoldLoanDetails As System.Windows.Forms.TabPage
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As BankControls.TextControl
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtSuplementForRepay As BankControls.TextControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtRepayCapacity As BankControls.NumericControl
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txtImmovableproperty As BankControls.TextControl
    Friend WithEvents txtReason As BankControls.TextControl
    Friend WithEvents txtNOI As BankControls.NumericControl
    Friend WithEvents dtpDemandLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbModeOfPayment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInstallmentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExpectedAmount As BankControls.NumericControl
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtInsuranceDetails As BankControls.TextControl
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtAssetDetails As BankControls.TextControl
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnLoadPic As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents btnClose2 As BankControls.NewButton
    Friend WithEvents btnSignature As BankControls.NewButton
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbLoanDocument As System.Windows.Forms.TabPage
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents lvDocuments As System.Windows.Forms.ListView
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtOtherDetails As BankControls.TextControl
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents txtChequeDetails As BankControls.TextControl
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents lvMovableAssets As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvFixedAssets As System.Windows.Forms.ListView
    Friend WithEvents colSl As System.Windows.Forms.ColumnHeader
    Friend WithEvents colParticulars As System.Windows.Forms.ColumnHeader
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPresentValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents txtOtheSource As BankControls.TextControl
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txtmemberToOtherCooperative As BankControls.TextControl
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As BankControls.NumericControl
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents dtpDemandSancDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSanctionedAmount As BankControls.NumericControl
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDirRelation As BankControls.TextControl
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents txtDirName As BankControls.TextControl
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents txtNonEarningRepayMode As BankControls.TextControl
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lvSuretyDetail As System.Windows.Forms.ListView
    Friend WithEvents txtSanctionedNo As BankControls.TextControl
    Friend WithEvents txtpnlParticularMonth As BankControls.TextControl
    Friend WithEvents txtInstAmount As BankControls.NumericControl
    Friend WithEvents chkDeselectAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalc As BankControls.NewButton
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents btnSBSearch As BankControls.NewButton
    Friend WithEvents txtSBNo As BankControls.TextControl
    Friend WithEvents Label35 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmColleteralHandLoanDetail))
        Me.clSlNo = New System.Windows.Forms.ColumnHeader
        Me.clChkDoc = New System.Windows.Forms.ColumnHeader
        Me.clDocuments = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCalc = New BankControls.NewButton
        Me.NewButton2 = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.btnSurety = New BankControls.NewButton
        Me.btnWithdraw = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.btnSBSearch = New BankControls.NewButton
        Me.txtSBNo = New BankControls.TextControl
        Me.Label35 = New System.Windows.Forms.Label
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.txtMobileNo2 = New BankControls.NumericControl
        Me.txtMonthlyExp = New BankControls.NumericControl
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.txtNoofDependant = New BankControls.NumericControl
        Me.txtPerService = New BankControls.NumericControl
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDesignation = New BankControls.TextControl
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtOfficeName = New BankControls.TextControl
        Me.Label38 = New System.Windows.Forms.Label
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
        Me.Label12 = New System.Windows.Forms.Label
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
        Me.tbOccupationDetails = New System.Windows.Forms.TabPage
        Me.pnlBus = New System.Windows.Forms.Panel
        Me.txtNatofBusiness = New BankControls.TextControl
        Me.Label76 = New System.Windows.Forms.Label
        Me.txtTaxDetail = New BankControls.TextControl
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.txtDocument = New BankControls.TextControl
        Me.Label72 = New System.Windows.Forms.Label
        Me.dtpYearofEst = New System.Windows.Forms.DateTimePicker
        Me.txtAnuIncome = New BankControls.NumericControl
        Me.Label71 = New System.Windows.Forms.Label
        Me.txtAnnuTurnover = New BankControls.NumericControl
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.chkBusiness = New System.Windows.Forms.CheckBox
        Me.pnlsal = New System.Windows.Forms.Panel
        Me.txtpnlParticularMonth = New BankControls.TextControl
        Me.txtMonthlyDomesticExp = New BankControls.NumericControl
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.txtNetSAlary = New BankControls.NumericControl
        Me.Label66 = New System.Windows.Forms.Label
        Me.txtTotalDeduction = New BankControls.NumericControl
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtOtherDeductions = New BankControls.NumericControl
        Me.Label55 = New System.Windows.Forms.Label
        Me.txtHBA = New BankControls.NumericControl
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtInsuPremium = New BankControls.NumericControl
        Me.txtProvidentFund = New BankControls.NumericControl
        Me.txtIncomeTax = New BankControls.NumericControl
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtOtherAll = New BankControls.NumericControl
        Me.Label69 = New System.Windows.Forms.Label
        Me.txtCityComensatoryAll = New BankControls.NumericControl
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtHouseRentAll = New BankControls.NumericControl
        Me.txtDeamessAll = New BankControls.NumericControl
        Me.txtBasic = New BankControls.NumericControl
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.chkSalary = New System.Windows.Forms.CheckBox
        Me.tbGoldLoanDetails = New System.Windows.Forms.TabPage
        Me.txtInstAmount = New BankControls.NumericControl
        Me.txtSanctionedNo = New BankControls.TextControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.lvSuretyDetail = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Label99 = New System.Windows.Forms.Label
        Me.dtpDemandSancDate = New System.Windows.Forms.DateTimePicker
        Me.Label100 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtSanctionedAmount = New BankControls.NumericControl
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtRepayCapacity = New BankControls.NumericControl
        Me.Label83 = New System.Windows.Forms.Label
        Me.txtImmovableproperty = New BankControls.TextControl
        Me.txtReason = New BankControls.TextControl
        Me.txtNOI = New BankControls.NumericControl
        Me.dtpDemandLoanDate = New System.Windows.Forms.DateTimePicker
        Me.cmbModeOfPayment = New System.Windows.Forms.ComboBox
        Me.cmbInstallmentType = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtExpectedAmount = New BankControls.NumericControl
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtInsuranceDetails = New BankControls.TextControl
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtAssetDetails = New BankControls.TextControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtDirRelation = New BankControls.TextControl
        Me.Label81 = New System.Windows.Forms.Label
        Me.txtDirName = New BankControls.TextControl
        Me.Label82 = New System.Windows.Forms.Label
        Me.txtOtherDetails = New BankControls.TextControl
        Me.Label98 = New System.Windows.Forms.Label
        Me.txtChequeDetails = New BankControls.TextControl
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.lvMovableAssets = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.lvFixedAssets = New System.Windows.Forms.ListView
        Me.colSl = New System.Windows.Forms.ColumnHeader
        Me.colParticulars = New System.Windows.Forms.ColumnHeader
        Me.colType = New System.Windows.Forms.ColumnHeader
        Me.colPresentValue = New System.Windows.Forms.ColumnHeader
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.Label89 = New System.Windows.Forms.Label
        Me.txtSalary = New BankControls.TextControl
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtSuplementForRepay = New BankControls.TextControl
        Me.txtNonEarningRepayMode = New BankControls.TextControl
        Me.Label103 = New System.Windows.Forms.Label
        Me.Label104 = New System.Windows.Forms.Label
        Me.Label92 = New System.Windows.Forms.Label
        Me.txtOtheSource = New BankControls.TextControl
        Me.Label85 = New System.Windows.Forms.Label
        Me.txtmemberToOtherCooperative = New BankControls.TextControl
        Me.Label84 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnLoadPic = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.btnClose2 = New BankControls.NewButton
        Me.btnSignature = New BankControls.NewButton
        Me.txtRemarks = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.tbLoanDocument = New System.Windows.Forms.TabPage
        Me.chkDeselectAll = New System.Windows.Forms.CheckBox
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.Label93 = New System.Windows.Forms.Label
        Me.lvDocuments = New System.Windows.Forms.ListView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbOccupationDetails.SuspendLayout()
        Me.pnlBus.SuspendLayout()
        Me.pnlsal.SuspendLayout()
        Me.tbGoldLoanDetails.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.tbLoanDocument.SuspendLayout()
        Me.SuspendLayout()
        '
        'clSlNo
        '
        Me.clSlNo.Text = "SlNo"
        Me.clSlNo.Width = 71
        '
        'clChkDoc
        '
        Me.clChkDoc.Text = "SelectDocuments"
        Me.clChkDoc.Width = 42
        '
        'clDocuments
        '
        Me.clDocuments.Text = "Documents"
        Me.clDocuments.Width = 232
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.btnSurety)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(4, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 626)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(16, 456)
        Me.btnCalc.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(184, 40)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Additional Charges"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.LightGray
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 104)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(184, 40)
        Me.NewButton2.TabIndex = 1
        Me.NewButton2.Text = "&Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.LightGray
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 184)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(184, 40)
        Me.NewButton1.TabIndex = 3
        Me.NewButton1.Text = "Asse&ts Detail"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSurety
        '
        Me.btnSurety.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSurety.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurety.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurety.ForeColor = System.Drawing.Color.Black
        Me.btnSurety.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnSurety.Image = CType(resources.GetObject("btnSurety.Image"), System.Drawing.Image)
        Me.btnSurety.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSurety.Location = New System.Drawing.Point(16, 144)
        Me.btnSurety.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSurety.Name = "btnSurety"
        Me.btnSurety.Size = New System.Drawing.Size(184, 40)
        Me.btnSurety.TabIndex = 2
        Me.btnSurety.Text = "Surety &Person Details"
        Me.btnSurety.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(16, 336)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(184, 40)
        Me.btnWithdraw.TabIndex = 5
        Me.btnWithdraw.Text = "&Disbursment"
        Me.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.LightGray
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 376)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(184, 40)
        Me.NewButton5.TabIndex = 6
        Me.NewButton5.Text = "&View Transaction Log"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(16, 296)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(184, 40)
        Me.btnDeposit.TabIndex = 4
        Me.btnDeposit.Text = "&Repayment"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtLoanNo)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(220, -8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 632)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(88, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(257, 25)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Colleteral Hand Loan Details"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(264, 48)
        Me.txtLoanNo.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 8
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.Size = New System.Drawing.Size(144, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.Text = "CHL"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(416, 48)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(24, 584)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "&Reset"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(512, 48)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnOk.Location = New System.Drawing.Point(552, 584)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 31
        Me.btnOk.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnCancel.Location = New System.Drawing.Point(648, 584)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "&Cancel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Colleteral Hand Loan No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbOccupationDetails)
        Me.TabControl1.Controls.Add(Me.tbGoldLoanDetails)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Controls.Add(Me.tbLoanDocument)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(16, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 496)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabStop = False
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.btnSBSearch)
        Me.tbPersonal.Controls.Add(Me.txtSBNo)
        Me.tbPersonal.Controls.Add(Me.Label35)
        Me.tbPersonal.Controls.Add(Me.cmbAccType)
        Me.tbPersonal.Controls.Add(Me.Label102)
        Me.tbPersonal.Controls.Add(Me.Label101)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo2)
        Me.tbPersonal.Controls.Add(Me.txtMonthlyExp)
        Me.tbPersonal.Controls.Add(Me.Label80)
        Me.tbPersonal.Controls.Add(Me.Label79)
        Me.tbPersonal.Controls.Add(Me.txtNoofDependant)
        Me.tbPersonal.Controls.Add(Me.txtPerService)
        Me.tbPersonal.Controls.Add(Me.Label78)
        Me.tbPersonal.Controls.Add(Me.Label77)
        Me.tbPersonal.Controls.Add(Me.Label31)
        Me.tbPersonal.Controls.Add(Me.Label15)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.txtDesignation)
        Me.tbPersonal.Controls.Add(Me.Label39)
        Me.tbPersonal.Controls.Add(Me.txtOfficeName)
        Me.tbPersonal.Controls.Add(Me.Label38)
        Me.tbPersonal.Controls.Add(Me.Panel2)
        Me.tbPersonal.Controls.Add(Me.Panel3)
        Me.tbPersonal.Controls.Add(Me.Label16)
        Me.tbPersonal.Controls.Add(Me.txtFatherName)
        Me.tbPersonal.Controls.Add(Me.cmbCaste)
        Me.tbPersonal.Controls.Add(Me.cmbReligion)
        Me.tbPersonal.Controls.Add(Me.Label12)
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
        Me.tbPersonal.Size = New System.Drawing.Size(760, 467)
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
        Me.btnMemSearch.Location = New System.Drawing.Point(304, 32)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Customer No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(160, 32)
        Me.txtCustomerID.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(136, 23)
        Me.txtCustomerID.SpecialChar = False
        Me.txtCustomerID.TabIndex = 4
        Me.txtCustomerID.Text = "CID"
        '
        'btnSBSearch
        '
        Me.btnSBSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSBSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSBSearch.Image = CType(resources.GetObject("btnSBSearch.Image"), System.Drawing.Image)
        Me.btnSBSearch.Location = New System.Drawing.Point(304, 64)
        Me.btnSBSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSBSearch.Name = "btnSBSearch"
        Me.btnSBSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSBSearch.TabIndex = 7
        '
        'txtSBNo
        '
        Me.txtSBNo.AlphaNumeric = True
        Me.txtSBNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSBNo.BlankSpace = True
        Me.txtSBNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBNo.Location = New System.Drawing.Point(160, 64)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.ReadOnly = True
        Me.txtSBNo.Size = New System.Drawing.Size(136, 23)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 6
        Me.txtSBNo.Text = ""
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 64)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 19)
        Me.Label35.TabIndex = 124
        Me.Label35.Text = "SB/CA No. :"
        '
        'cmbAccType
        '
        Me.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(552, 376)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(136, 24)
        Me.cmbAccType.TabIndex = 30
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(352, 376)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(90, 19)
        Me.Label102.TabIndex = 116
        Me.Label102.Text = "Loan Type : "
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(352, 64)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(90, 19)
        Me.Label101.TabIndex = 114
        Me.Label101.Text = "Mobile No2 :"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.AfterDecimal = 0
        Me.txtMobileNo2.BeforeDecimal = 10
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo2.Location = New System.Drawing.Point(552, 64)
        Me.txtMobileNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo2.MaxLength = 10
        Me.txtMobileNo2.MaxValue = 0
        Me.txtMobileNo2.MinValue = 0
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo2.TabIndex = 22
        Me.txtMobileNo2.Text = ""
        '
        'txtMonthlyExp
        '
        Me.txtMonthlyExp.AfterDecimal = 0
        Me.txtMonthlyExp.BeforeDecimal = 10
        Me.txtMonthlyExp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyExp.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMonthlyExp.Location = New System.Drawing.Point(552, 336)
        Me.txtMonthlyExp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMonthlyExp.MaxLength = 8
        Me.txtMonthlyExp.MaxValue = 0
        Me.txtMonthlyExp.MinValue = 0
        Me.txtMonthlyExp.Name = "txtMonthlyExp"
        Me.txtMonthlyExp.Size = New System.Drawing.Size(136, 23)
        Me.txtMonthlyExp.TabIndex = 29
        Me.txtMonthlyExp.Text = ""
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(352, 344)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(189, 19)
        Me.Label80.TabIndex = 109
        Me.Label80.Text = "applicant and dependants :"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(352, 328)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(143, 19)
        Me.Label79.TabIndex = 108
        Me.Label79.Text = "Monthly Expenses of"
        '
        'txtNoofDependant
        '
        Me.txtNoofDependant.AfterDecimal = 0
        Me.txtNoofDependant.BeforeDecimal = 10
        Me.txtNoofDependant.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoofDependant.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoofDependant.Location = New System.Drawing.Point(552, 304)
        Me.txtNoofDependant.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNoofDependant.MaxLength = 2
        Me.txtNoofDependant.MaxValue = 0
        Me.txtNoofDependant.MinValue = 0
        Me.txtNoofDependant.Name = "txtNoofDependant"
        Me.txtNoofDependant.Size = New System.Drawing.Size(64, 23)
        Me.txtNoofDependant.TabIndex = 28
        Me.txtNoofDependant.Text = ""
        '
        'txtPerService
        '
        Me.txtPerService.AfterDecimal = 0
        Me.txtPerService.BeforeDecimal = 10
        Me.txtPerService.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerService.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPerService.Location = New System.Drawing.Point(552, 264)
        Me.txtPerService.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPerService.MaxLength = 2
        Me.txtPerService.MaxValue = 0
        Me.txtPerService.MinValue = 0
        Me.txtPerService.Name = "txtPerService"
        Me.txtPerService.Size = New System.Drawing.Size(64, 23)
        Me.txtPerService.TabIndex = 27
        Me.txtPerService.Text = ""
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(352, 304)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(176, 19)
        Me.Label78.TabIndex = 105
        Me.Label78.Text = "Number of Dependants : "
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(352, 272)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(88, 19)
        Me.Label77.TabIndex = 103
        Me.Label77.Text = "Completed :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(352, 256)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 19)
        Me.Label31.TabIndex = 102
        Me.Label31.Text = "Period of  Service "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(352, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 19)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Office Address :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 19)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "Husband Name : "
        '
        'txtDesignation
        '
        Me.txtDesignation.AlphaNumeric = True
        Me.txtDesignation.BlankSpace = False
        Me.txtDesignation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDesignation.Location = New System.Drawing.Point(552, 160)
        Me.txtDesignation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDesignation.Mandatory = False
        Me.txtDesignation.MaxLength = 30
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(184, 23)
        Me.txtDesignation.SpecialChar = True
        Me.txtDesignation.TabIndex = 25
        Me.txtDesignation.Text = ""
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(352, 160)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 19)
        Me.Label39.TabIndex = 98
        Me.Label39.Text = "Working as :"
        '
        'txtOfficeName
        '
        Me.txtOfficeName.AlphaNumeric = True
        Me.txtOfficeName.BlankSpace = False
        Me.txtOfficeName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeName.Location = New System.Drawing.Point(552, 128)
        Me.txtOfficeName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeName.Mandatory = False
        Me.txtOfficeName.MaxLength = 30
        Me.txtOfficeName.Name = "txtOfficeName"
        Me.txtOfficeName.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeName.SpecialChar = True
        Me.txtOfficeName.TabIndex = 24
        Me.txtOfficeName.Text = ""
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(352, 128)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(98, 19)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Office Name :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(160, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 32)
        Me.Panel2.TabIndex = 14
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 7)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 15
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 7)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 16
        Me.rdbFemale.Text = "Female"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbMajor)
        Me.Panel3.Controls.Add(Me.rdbMinor)
        Me.Panel3.Enabled = False
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(160, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 32)
        Me.Panel3.TabIndex = 11
        '
        'rdbMajor
        '
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 7)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 12
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.rdbMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 7)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 13
        Me.rdbMinor.Text = "Minor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Age Status :"
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.AutoSize = False
        Me.txtFatherName.BlankSpace = True
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(160, 96)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(184, 24)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 8
        Me.txtFatherName.Text = ""
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(160, 296)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(184, 24)
        Me.cmbCaste.TabIndex = 18
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(160, 264)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(184, 24)
        Me.cmbReligion.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 19)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Occupational/"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(160, 128)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 23)
        Me.dtpDOB.TabIndex = 9
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father Name/ "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(352, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Residential Address  "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(552, 96)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 400)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 19)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(352, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 19)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No1 :"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(160, 160)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(80, 23)
        Me.txtAge.TabIndex = 10
        Me.txtAge.Text = ""
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.AutoSize = False
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(552, 192)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 26
        Me.txtPresAddress.Text = ""
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(160, 400)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.TabIndex = 20
        Me.txtPhoneNo.Text = ""
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(552, 32)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.TabIndex = 21
        Me.txtMobileNo.Text = ""
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.AutoSize = False
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(160, 328)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 19
        Me.txtPermAddress.Text = ""
        '
        'tbOccupationDetails
        '
        Me.tbOccupationDetails.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.tbOccupationDetails.Controls.Add(Me.pnlBus)
        Me.tbOccupationDetails.Controls.Add(Me.chkBusiness)
        Me.tbOccupationDetails.Controls.Add(Me.pnlsal)
        Me.tbOccupationDetails.Controls.Add(Me.chkSalary)
        Me.tbOccupationDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbOccupationDetails.Name = "tbOccupationDetails"
        Me.tbOccupationDetails.Size = New System.Drawing.Size(760, 467)
        Me.tbOccupationDetails.TabIndex = 5
        Me.tbOccupationDetails.Text = "OccupationDetails"
        Me.tbOccupationDetails.Visible = False
        '
        'pnlBus
        '
        Me.pnlBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBus.Controls.Add(Me.txtNatofBusiness)
        Me.pnlBus.Controls.Add(Me.Label76)
        Me.pnlBus.Controls.Add(Me.txtTaxDetail)
        Me.pnlBus.Controls.Add(Me.Label75)
        Me.pnlBus.Controls.Add(Me.Label74)
        Me.pnlBus.Controls.Add(Me.Label73)
        Me.pnlBus.Controls.Add(Me.txtDocument)
        Me.pnlBus.Controls.Add(Me.Label72)
        Me.pnlBus.Controls.Add(Me.dtpYearofEst)
        Me.pnlBus.Controls.Add(Me.txtAnuIncome)
        Me.pnlBus.Controls.Add(Me.Label71)
        Me.pnlBus.Controls.Add(Me.txtAnnuTurnover)
        Me.pnlBus.Controls.Add(Me.Label70)
        Me.pnlBus.Controls.Add(Me.Label68)
        Me.pnlBus.Location = New System.Drawing.Point(16, 328)
        Me.pnlBus.Name = "pnlBus"
        Me.pnlBus.Size = New System.Drawing.Size(696, 128)
        Me.pnlBus.TabIndex = 19
        '
        'txtNatofBusiness
        '
        Me.txtNatofBusiness.AlphaNumeric = True
        Me.txtNatofBusiness.BlankSpace = False
        Me.txtNatofBusiness.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNatofBusiness.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNatofBusiness.Location = New System.Drawing.Point(208, 8)
        Me.txtNatofBusiness.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNatofBusiness.Mandatory = False
        Me.txtNatofBusiness.MaxLength = 50
        Me.txtNatofBusiness.Name = "txtNatofBusiness"
        Me.txtNatofBusiness.Size = New System.Drawing.Size(128, 22)
        Me.txtNatofBusiness.SpecialChar = True
        Me.txtNatofBusiness.TabIndex = 20
        Me.txtNatofBusiness.Text = ""
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(344, 80)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(144, 32)
        Me.Label76.TabIndex = 91
        Me.Label76.Text = "Income Tax/Sales Tax Details"
        '
        'txtTaxDetail
        '
        Me.txtTaxDetail.AlphaNumeric = True
        Me.txtTaxDetail.BlankSpace = False
        Me.txtTaxDetail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxDetail.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTaxDetail.Location = New System.Drawing.Point(496, 80)
        Me.txtTaxDetail.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTaxDetail.Mandatory = False
        Me.txtTaxDetail.MaxLength = 100
        Me.txtTaxDetail.Multiline = True
        Me.txtTaxDetail.Name = "txtTaxDetail"
        Me.txtTaxDetail.Size = New System.Drawing.Size(192, 40)
        Me.txtTaxDetail.SpecialChar = True
        Me.txtTaxDetail.TabIndex = 25
        Me.txtTaxDetail.Text = ""
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(392, 48)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(56, 16)
        Me.Label75.TabIndex = 89
        Me.Label75.Text = "Business"
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(360, 32)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(136, 16)
        Me.Label74.TabIndex = 88
        Me.Label74.Text = "in support of nature of "
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(344, 16)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(144, 16)
        Me.Label73.TabIndex = 87
        Me.Label73.Text = "Document evidence Produced "
        '
        'txtDocument
        '
        Me.txtDocument.AlphaNumeric = True
        Me.txtDocument.BlankSpace = False
        Me.txtDocument.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocument.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDocument.Location = New System.Drawing.Point(496, 8)
        Me.txtDocument.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDocument.Mandatory = False
        Me.txtDocument.MaxLength = 100
        Me.txtDocument.Multiline = True
        Me.txtDocument.Name = "txtDocument"
        Me.txtDocument.Size = New System.Drawing.Size(192, 64)
        Me.txtDocument.SpecialChar = True
        Me.txtDocument.TabIndex = 24
        Me.txtDocument.Text = ""
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(8, 80)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(112, 16)
        Me.Label72.TabIndex = 85
        Me.Label72.Text = "Annual Income"
        '
        'dtpYearofEst
        '
        Me.dtpYearofEst.CustomFormat = "dd - MMM - yyyy"
        Me.dtpYearofEst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYearofEst.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearofEst.Location = New System.Drawing.Point(208, 32)
        Me.dtpYearofEst.MaxDate = New Date(9998, 11, 11, 0, 0, 0, 0)
        Me.dtpYearofEst.Name = "dtpYearofEst"
        Me.dtpYearofEst.Size = New System.Drawing.Size(128, 22)
        Me.dtpYearofEst.TabIndex = 21
        Me.dtpYearofEst.Value = New Date(2008, 10, 30, 0, 0, 0, 0)
        '
        'txtAnuIncome
        '
        Me.txtAnuIncome.AfterDecimal = 0
        Me.txtAnuIncome.BeforeDecimal = 8
        Me.txtAnuIncome.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnuIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAnuIncome.Location = New System.Drawing.Point(208, 80)
        Me.txtAnuIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAnuIncome.MaxLength = 10
        Me.txtAnuIncome.MaxValue = 99999999
        Me.txtAnuIncome.MinValue = 0
        Me.txtAnuIncome.Name = "txtAnuIncome"
        Me.txtAnuIncome.Size = New System.Drawing.Size(128, 22)
        Me.txtAnuIncome.TabIndex = 23
        Me.txtAnuIncome.Text = ""
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(8, 32)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(136, 16)
        Me.Label71.TabIndex = 83
        Me.Label71.Text = "Year of  Establishment"
        '
        'txtAnnuTurnover
        '
        Me.txtAnnuTurnover.AfterDecimal = 0
        Me.txtAnnuTurnover.BeforeDecimal = 8
        Me.txtAnnuTurnover.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnnuTurnover.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAnnuTurnover.Location = New System.Drawing.Point(208, 56)
        Me.txtAnnuTurnover.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAnnuTurnover.MaxLength = 10
        Me.txtAnnuTurnover.MaxValue = 99999999
        Me.txtAnnuTurnover.MinValue = 0
        Me.txtAnnuTurnover.Name = "txtAnnuTurnover"
        Me.txtAnnuTurnover.Size = New System.Drawing.Size(128, 22)
        Me.txtAnnuTurnover.TabIndex = 22
        Me.txtAnnuTurnover.Text = ""
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(8, 56)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(112, 16)
        Me.Label70.TabIndex = 81
        Me.Label70.Text = "Annual Turnover"
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(8, 8)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(200, 16)
        Me.Label68.TabIndex = 79
        Me.Label68.Text = "Nature Of Business/Profession"
        '
        'chkBusiness
        '
        Me.chkBusiness.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBusiness.Location = New System.Drawing.Point(16, 296)
        Me.chkBusiness.Name = "chkBusiness"
        Me.chkBusiness.Size = New System.Drawing.Size(136, 24)
        Me.chkBusiness.TabIndex = 18
        Me.chkBusiness.Text = "Business Person"
        '
        'pnlsal
        '
        Me.pnlsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlsal.Controls.Add(Me.txtpnlParticularMonth)
        Me.pnlsal.Controls.Add(Me.txtMonthlyDomesticExp)
        Me.pnlsal.Controls.Add(Me.Label67)
        Me.pnlsal.Controls.Add(Me.Label65)
        Me.pnlsal.Controls.Add(Me.txtNetSAlary)
        Me.pnlsal.Controls.Add(Me.Label66)
        Me.pnlsal.Controls.Add(Me.txtTotalDeduction)
        Me.pnlsal.Controls.Add(Me.Label60)
        Me.pnlsal.Controls.Add(Me.txtAmount)
        Me.pnlsal.Controls.Add(Me.Label64)
        Me.pnlsal.Controls.Add(Me.Label50)
        Me.pnlsal.Controls.Add(Me.Label51)
        Me.pnlsal.Controls.Add(Me.Label52)
        Me.pnlsal.Controls.Add(Me.Label53)
        Me.pnlsal.Controls.Add(Me.Label54)
        Me.pnlsal.Controls.Add(Me.txtOtherDeductions)
        Me.pnlsal.Controls.Add(Me.Label55)
        Me.pnlsal.Controls.Add(Me.txtHBA)
        Me.pnlsal.Controls.Add(Me.Label56)
        Me.pnlsal.Controls.Add(Me.txtInsuPremium)
        Me.pnlsal.Controls.Add(Me.txtProvidentFund)
        Me.pnlsal.Controls.Add(Me.txtIncomeTax)
        Me.pnlsal.Controls.Add(Me.Label57)
        Me.pnlsal.Controls.Add(Me.Label58)
        Me.pnlsal.Controls.Add(Me.Label59)
        Me.pnlsal.Controls.Add(Me.Label49)
        Me.pnlsal.Controls.Add(Me.Label48)
        Me.pnlsal.Controls.Add(Me.Label43)
        Me.pnlsal.Controls.Add(Me.Label42)
        Me.pnlsal.Controls.Add(Me.Label41)
        Me.pnlsal.Controls.Add(Me.Label40)
        Me.pnlsal.Controls.Add(Me.txtOtherAll)
        Me.pnlsal.Controls.Add(Me.Label69)
        Me.pnlsal.Controls.Add(Me.txtCityComensatoryAll)
        Me.pnlsal.Controls.Add(Me.Label33)
        Me.pnlsal.Controls.Add(Me.txtHouseRentAll)
        Me.pnlsal.Controls.Add(Me.txtDeamessAll)
        Me.pnlsal.Controls.Add(Me.txtBasic)
        Me.pnlsal.Controls.Add(Me.Label47)
        Me.pnlsal.Controls.Add(Me.Label44)
        Me.pnlsal.Controls.Add(Me.Label45)
        Me.pnlsal.Controls.Add(Me.Label46)
        Me.pnlsal.Location = New System.Drawing.Point(16, 40)
        Me.pnlsal.Name = "pnlsal"
        Me.pnlsal.Size = New System.Drawing.Size(696, 248)
        Me.pnlsal.TabIndex = 2
        '
        'txtpnlParticularMonth
        '
        Me.txtpnlParticularMonth.AlphaNumeric = True
        Me.txtpnlParticularMonth.BlankSpace = False
        Me.txtpnlParticularMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpnlParticularMonth.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtpnlParticularMonth.Location = New System.Drawing.Point(240, 8)
        Me.txtpnlParticularMonth.LostFocusColour = System.Drawing.Color.Empty
        Me.txtpnlParticularMonth.Mandatory = False
        Me.txtpnlParticularMonth.MaxLength = 30
        Me.txtpnlParticularMonth.Name = "txtpnlParticularMonth"
        Me.txtpnlParticularMonth.Size = New System.Drawing.Size(128, 23)
        Me.txtpnlParticularMonth.SpecialChar = True
        Me.txtpnlParticularMonth.TabIndex = 3
        Me.txtpnlParticularMonth.Text = ""
        '
        'txtMonthlyDomesticExp
        '
        Me.txtMonthlyDomesticExp.AfterDecimal = 0
        Me.txtMonthlyDomesticExp.BeforeDecimal = 8
        Me.txtMonthlyDomesticExp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyDomesticExp.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMonthlyDomesticExp.Location = New System.Drawing.Point(240, 216)
        Me.txtMonthlyDomesticExp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMonthlyDomesticExp.MaxLength = 10
        Me.txtMonthlyDomesticExp.MaxValue = 99999999
        Me.txtMonthlyDomesticExp.MinValue = 0
        Me.txtMonthlyDomesticExp.Name = "txtMonthlyDomesticExp"
        Me.txtMonthlyDomesticExp.Size = New System.Drawing.Size(128, 23)
        Me.txtMonthlyDomesticExp.TabIndex = 11
        Me.txtMonthlyDomesticExp.Text = ""
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(8, 208)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(168, 32)
        Me.Label67.TabIndex = 77
        Me.Label67.Text = "Family's Monthly Domestic Expenses  "
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(200, 184)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(24, 16)
        Me.Label65.TabIndex = 75
        Me.Label65.Text = "Rs."
        '
        'txtNetSAlary
        '
        Me.txtNetSAlary.AfterDecimal = 0
        Me.txtNetSAlary.BeforeDecimal = 8
        Me.txtNetSAlary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSAlary.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNetSAlary.Location = New System.Drawing.Point(240, 184)
        Me.txtNetSAlary.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNetSAlary.MaxLength = 10
        Me.txtNetSAlary.MaxValue = 99999999
        Me.txtNetSAlary.MinValue = 0
        Me.txtNetSAlary.Name = "txtNetSAlary"
        Me.txtNetSAlary.Size = New System.Drawing.Size(128, 23)
        Me.txtNetSAlary.TabIndex = 10
        Me.txtNetSAlary.Text = ""
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(8, 184)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(88, 16)
        Me.Label66.TabIndex = 74
        Me.Label66.Text = "Net  Salary"
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.AfterDecimal = 0
        Me.txtTotalDeduction.BackColor = System.Drawing.Color.White
        Me.txtTotalDeduction.BeforeDecimal = 8
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeduction.GotFocusColour = System.Drawing.Color.White
        Me.txtTotalDeduction.Location = New System.Drawing.Point(536, 152)
        Me.txtTotalDeduction.LostFocusColour = System.Drawing.Color.White
        Me.txtTotalDeduction.MaxLength = 10
        Me.txtTotalDeduction.MaxValue = 99999999
        Me.txtTotalDeduction.MinValue = 0
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.ReadOnly = True
        Me.txtTotalDeduction.Size = New System.Drawing.Size(128, 23)
        Me.txtTotalDeduction.TabIndex = 17
        Me.txtTotalDeduction.TabStop = False
        Me.txtTotalDeduction.Text = ""
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(200, 152)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(24, 16)
        Me.Label60.TabIndex = 70
        Me.Label60.Text = "Rs."
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 8
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.Color.White
        Me.txtAmount.Location = New System.Drawing.Point(240, 152)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.White
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 99999999
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtAmount.TabIndex = 9
        Me.txtAmount.TabStop = False
        Me.txtAmount.Text = ""
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(8, 152)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(48, 16)
        Me.Label64.TabIndex = 69
        Me.Label64.Text = "Total"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(504, 80)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(24, 16)
        Me.Label50.TabIndex = 67
        Me.Label50.Text = "Rs."
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(504, 104)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(24, 16)
        Me.Label51.TabIndex = 66
        Me.Label51.Text = "Rs."
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(504, 128)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(24, 16)
        Me.Label52.TabIndex = 65
        Me.Label52.Text = "Rs."
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(504, 56)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(24, 16)
        Me.Label53.TabIndex = 64
        Me.Label53.Text = "Rs."
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(504, 32)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(24, 16)
        Me.Label54.TabIndex = 63
        Me.Label54.Text = "Rs."
        '
        'txtOtherDeductions
        '
        Me.txtOtherDeductions.AfterDecimal = 0
        Me.txtOtherDeductions.BeforeDecimal = 8
        Me.txtOtherDeductions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherDeductions.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherDeductions.Location = New System.Drawing.Point(536, 128)
        Me.txtOtherDeductions.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherDeductions.MaxLength = 10
        Me.txtOtherDeductions.MaxValue = 99999999
        Me.txtOtherDeductions.MinValue = 0
        Me.txtOtherDeductions.Name = "txtOtherDeductions"
        Me.txtOtherDeductions.Size = New System.Drawing.Size(128, 23)
        Me.txtOtherDeductions.TabIndex = 16
        Me.txtOtherDeductions.Text = ""
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(376, 128)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(104, 40)
        Me.Label55.TabIndex = 62
        Me.Label55.Text = "Other Deductions"
        '
        'txtHBA
        '
        Me.txtHBA.AfterDecimal = 0
        Me.txtHBA.BeforeDecimal = 8
        Me.txtHBA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHBA.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtHBA.Location = New System.Drawing.Point(536, 104)
        Me.txtHBA.LostFocusColour = System.Drawing.Color.Empty
        Me.txtHBA.MaxLength = 10
        Me.txtHBA.MaxValue = 99999999
        Me.txtHBA.MinValue = 0
        Me.txtHBA.Name = "txtHBA"
        Me.txtHBA.Size = New System.Drawing.Size(128, 23)
        Me.txtHBA.TabIndex = 15
        Me.txtHBA.Text = ""
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(376, 104)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(128, 16)
        Me.Label56.TabIndex = 59
        Me.Label56.Text = "H.B.A"
        '
        'txtInsuPremium
        '
        Me.txtInsuPremium.AfterDecimal = 0
        Me.txtInsuPremium.BeforeDecimal = 8
        Me.txtInsuPremium.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsuPremium.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInsuPremium.Location = New System.Drawing.Point(536, 80)
        Me.txtInsuPremium.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInsuPremium.MaxLength = 10
        Me.txtInsuPremium.MaxValue = 99999999
        Me.txtInsuPremium.MinValue = 0
        Me.txtInsuPremium.Name = "txtInsuPremium"
        Me.txtInsuPremium.Size = New System.Drawing.Size(128, 23)
        Me.txtInsuPremium.TabIndex = 14
        Me.txtInsuPremium.Text = ""
        '
        'txtProvidentFund
        '
        Me.txtProvidentFund.AfterDecimal = 0
        Me.txtProvidentFund.BeforeDecimal = 8
        Me.txtProvidentFund.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvidentFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtProvidentFund.Location = New System.Drawing.Point(536, 56)
        Me.txtProvidentFund.LostFocusColour = System.Drawing.Color.Empty
        Me.txtProvidentFund.MaxLength = 10
        Me.txtProvidentFund.MaxValue = 99999999
        Me.txtProvidentFund.MinValue = 0
        Me.txtProvidentFund.Name = "txtProvidentFund"
        Me.txtProvidentFund.Size = New System.Drawing.Size(128, 23)
        Me.txtProvidentFund.TabIndex = 13
        Me.txtProvidentFund.Text = ""
        '
        'txtIncomeTax
        '
        Me.txtIncomeTax.AfterDecimal = 0
        Me.txtIncomeTax.BeforeDecimal = 8
        Me.txtIncomeTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncomeTax.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIncomeTax.Location = New System.Drawing.Point(536, 32)
        Me.txtIncomeTax.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIncomeTax.MaxLength = 10
        Me.txtIncomeTax.MaxValue = 99999999
        Me.txtIncomeTax.MinValue = 0
        Me.txtIncomeTax.Name = "txtIncomeTax"
        Me.txtIncomeTax.Size = New System.Drawing.Size(128, 23)
        Me.txtIncomeTax.TabIndex = 12
        Me.txtIncomeTax.Text = ""
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(376, 80)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(128, 16)
        Me.Label57.TabIndex = 53
        Me.Label57.Text = "Insurance Premium"
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(376, 32)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 16)
        Me.Label58.TabIndex = 54
        Me.Label58.Text = "Incom Tax"
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(376, 56)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(128, 16)
        Me.Label59.TabIndex = 55
        Me.Label59.Text = "Provident Fund"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(200, 80)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(24, 16)
        Me.Label49.TabIndex = 52
        Me.Label49.Text = "Rs."
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(200, 104)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(24, 16)
        Me.Label48.TabIndex = 51
        Me.Label48.Text = "Rs."
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(200, 128)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(24, 16)
        Me.Label43.TabIndex = 50
        Me.Label43.Text = "Rs."
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(200, 56)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(24, 16)
        Me.Label42.TabIndex = 49
        Me.Label42.Text = "Rs."
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(200, 32)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(24, 16)
        Me.Label41.TabIndex = 48
        Me.Label41.Text = "Rs."
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(544, 8)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(96, 16)
        Me.Label40.TabIndex = 47
        Me.Label40.Text = "Deduction"
        '
        'txtOtherAll
        '
        Me.txtOtherAll.AfterDecimal = 0
        Me.txtOtherAll.BeforeDecimal = 8
        Me.txtOtherAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherAll.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherAll.Location = New System.Drawing.Point(240, 128)
        Me.txtOtherAll.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherAll.MaxLength = 10
        Me.txtOtherAll.MaxValue = 99999999
        Me.txtOtherAll.MinValue = 0
        Me.txtOtherAll.Name = "txtOtherAll"
        Me.txtOtherAll.Size = New System.Drawing.Size(128, 23)
        Me.txtOtherAll.TabIndex = 8
        Me.txtOtherAll.Text = ""
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(8, 128)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(136, 16)
        Me.Label69.TabIndex = 46
        Me.Label69.Text = "Other allowance"
        '
        'txtCityComensatoryAll
        '
        Me.txtCityComensatoryAll.AfterDecimal = 0
        Me.txtCityComensatoryAll.BeforeDecimal = 8
        Me.txtCityComensatoryAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCityComensatoryAll.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCityComensatoryAll.Location = New System.Drawing.Point(240, 104)
        Me.txtCityComensatoryAll.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCityComensatoryAll.MaxLength = 10
        Me.txtCityComensatoryAll.MaxValue = 99999999
        Me.txtCityComensatoryAll.MinValue = 0
        Me.txtCityComensatoryAll.Name = "txtCityComensatoryAll"
        Me.txtCityComensatoryAll.Size = New System.Drawing.Size(128, 23)
        Me.txtCityComensatoryAll.TabIndex = 7
        Me.txtCityComensatoryAll.Text = ""
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 104)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(176, 16)
        Me.Label33.TabIndex = 37
        Me.Label33.Text = "City Comensatory all"
        '
        'txtHouseRentAll
        '
        Me.txtHouseRentAll.AfterDecimal = 0
        Me.txtHouseRentAll.BeforeDecimal = 8
        Me.txtHouseRentAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseRentAll.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtHouseRentAll.Location = New System.Drawing.Point(240, 80)
        Me.txtHouseRentAll.LostFocusColour = System.Drawing.Color.Empty
        Me.txtHouseRentAll.MaxLength = 10
        Me.txtHouseRentAll.MaxValue = 99999999
        Me.txtHouseRentAll.MinValue = 0
        Me.txtHouseRentAll.Name = "txtHouseRentAll"
        Me.txtHouseRentAll.Size = New System.Drawing.Size(128, 23)
        Me.txtHouseRentAll.TabIndex = 6
        Me.txtHouseRentAll.Text = ""
        '
        'txtDeamessAll
        '
        Me.txtDeamessAll.AfterDecimal = 0
        Me.txtDeamessAll.BeforeDecimal = 8
        Me.txtDeamessAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeamessAll.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDeamessAll.Location = New System.Drawing.Point(240, 56)
        Me.txtDeamessAll.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDeamessAll.MaxLength = 10
        Me.txtDeamessAll.MaxValue = 99999999
        Me.txtDeamessAll.MinValue = 0
        Me.txtDeamessAll.Name = "txtDeamessAll"
        Me.txtDeamessAll.Size = New System.Drawing.Size(128, 23)
        Me.txtDeamessAll.TabIndex = 5
        Me.txtDeamessAll.Text = ""
        '
        'txtBasic
        '
        Me.txtBasic.AfterDecimal = 0
        Me.txtBasic.BeforeDecimal = 8
        Me.txtBasic.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBasic.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBasic.Location = New System.Drawing.Point(240, 32)
        Me.txtBasic.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBasic.MaxLength = 10
        Me.txtBasic.MaxValue = 99999999
        Me.txtBasic.MinValue = 0
        Me.txtBasic.Name = "txtBasic"
        Me.txtBasic.Size = New System.Drawing.Size(128, 23)
        Me.txtBasic.TabIndex = 4
        Me.txtBasic.Text = ""
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(8, 80)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(160, 16)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "House Rent allowance"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(8, 8)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(208, 16)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Surety Particulars of the month 0f "
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(8, 32)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 16)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Basic Pay"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(8, 56)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(152, 16)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "Deamess allowance"
        '
        'chkSalary
        '
        Me.chkSalary.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalary.Location = New System.Drawing.Point(16, 16)
        Me.chkSalary.Name = "chkSalary"
        Me.chkSalary.Size = New System.Drawing.Size(136, 24)
        Me.chkSalary.TabIndex = 1
        Me.chkSalary.Text = "Salaryed Person"
        '
        'tbGoldLoanDetails
        '
        Me.tbGoldLoanDetails.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.tbGoldLoanDetails.Controls.Add(Me.txtInstAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label20)
        Me.tbGoldLoanDetails.Controls.Add(Me.lvSuretyDetail)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label99)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDemandSancDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label100)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label30)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label36)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label19)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDueDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label94)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label24)
        Me.tbGoldLoanDetails.Controls.Add(Me.TxtRepayCapacity)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label83)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtImmovableproperty)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReason)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtNOI)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDemandLoanDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbModeOfPayment)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbInstallmentType)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label34)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label11)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtExpectedAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label21)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtROI)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label22)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label23)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label37)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label18)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label27)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtInsuranceDetails)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label28)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtAssetDetails)
        Me.tbGoldLoanDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldLoanDetails.Name = "tbGoldLoanDetails"
        Me.tbGoldLoanDetails.Size = New System.Drawing.Size(760, 467)
        Me.tbGoldLoanDetails.TabIndex = 4
        Me.tbGoldLoanDetails.Text = "LoanDetails"
        Me.tbGoldLoanDetails.Visible = False
        '
        'txtInstAmount
        '
        Me.txtInstAmount.AfterDecimal = 0
        Me.txtInstAmount.BackColor = System.Drawing.Color.White
        Me.txtInstAmount.BeforeDecimal = 8
        Me.txtInstAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInstAmount.Location = New System.Drawing.Point(184, 272)
        Me.txtInstAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInstAmount.MaxLength = 8
        Me.txtInstAmount.MaxValue = 0
        Me.txtInstAmount.MinValue = 0
        Me.txtInstAmount.Name = "txtInstAmount"
        Me.txtInstAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtInstAmount.TabIndex = 32
        Me.txtInstAmount.Text = ""
        '
        'txtSanctionedNo
        '
        Me.txtSanctionedNo.AlphaNumeric = True
        Me.txtSanctionedNo.AutoSize = False
        Me.txtSanctionedNo.BlankSpace = False
        Me.txtSanctionedNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanctionedNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSanctionedNo.Location = New System.Drawing.Point(184, 144)
        Me.txtSanctionedNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSanctionedNo.Mandatory = False
        Me.txtSanctionedNo.MaxLength = 30
        Me.txtSanctionedNo.Name = "txtSanctionedNo"
        Me.txtSanctionedNo.Size = New System.Drawing.Size(160, 24)
        Me.txtSanctionedNo.SpecialChar = True
        Me.txtSanctionedNo.TabIndex = 28
        Me.txtSanctionedNo.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 336)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 19)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "Surety Person Detail"
        '
        'lvSuretyDetail
        '
        Me.lvSuretyDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvSuretyDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSuretyDetail.FullRowSelect = True
        Me.lvSuretyDetail.GridLines = True
        Me.lvSuretyDetail.Location = New System.Drawing.Point(16, 360)
        Me.lvSuretyDetail.Name = "lvSuretyDetail"
        Me.lvSuretyDetail.Size = New System.Drawing.Size(672, 96)
        Me.lvSuretyDetail.TabIndex = 136
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
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(8, 144)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(102, 19)
        Me.Label99.TabIndex = 135
        Me.Label99.Text = "Sanctioned No"
        '
        'dtpDemandSancDate
        '
        Me.dtpDemandSancDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDemandSancDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDemandSancDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDemandSancDate.Location = New System.Drawing.Point(184, 112)
        Me.dtpDemandSancDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpDemandSancDate.Name = "dtpDemandSancDate"
        Me.dtpDemandSancDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDemandSancDate.TabIndex = 27
        Me.dtpDemandSancDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label100.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(8, 112)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(122, 19)
        Me.Label100.TabIndex = 132
        Me.Label100.Text = "Sanctioned Date:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(576, 80)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(160, 23)
        Me.txtReceiptNo.TabIndex = 36
        Me.txtReceiptNo.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(352, 80)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 19)
        Me.Label30.TabIndex = 131
        Me.Label30.Text = "Receipt No :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 240)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(74, 19)
        Me.Label36.TabIndex = 127
        Me.Label36.Text = "Due Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 19)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "Sanctioned Amount  :"
        '
        'txtSanctionedAmount
        '
        Me.txtSanctionedAmount.AfterDecimal = 2
        Me.txtSanctionedAmount.BackColor = System.Drawing.Color.White
        Me.txtSanctionedAmount.BeforeDecimal = 7
        Me.txtSanctionedAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanctionedAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSanctionedAmount.Location = New System.Drawing.Point(184, 80)
        Me.txtSanctionedAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSanctionedAmount.MaxLength = 10
        Me.txtSanctionedAmount.MaxValue = 0
        Me.txtSanctionedAmount.MinValue = 0
        Me.txtSanctionedAmount.Name = "txtSanctionedAmount"
        Me.txtSanctionedAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtSanctionedAmount.TabIndex = 26
        Me.txtSanctionedAmount.Text = ""
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(184, 240)
        Me.dtpDueDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDueDate.TabIndex = 31
        Me.dtpDueDate.Value = New Date(2008, 10, 31, 0, 0, 0, 0)
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label94.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(8, 272)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(155, 19)
        Me.Label94.TabIndex = 99
        Me.Label94.Text = "Instralement Amount:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(352, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(215, 19)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Repaying Capacity Per month :"
        '
        'TxtRepayCapacity
        '
        Me.TxtRepayCapacity.AfterDecimal = 2
        Me.TxtRepayCapacity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtRepayCapacity.BeforeDecimal = 7
        Me.TxtRepayCapacity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRepayCapacity.GotFocusColour = System.Drawing.SystemColors.HighlightText
        Me.TxtRepayCapacity.Location = New System.Drawing.Point(576, 112)
        Me.TxtRepayCapacity.LostFocusColour = System.Drawing.Color.Empty
        Me.TxtRepayCapacity.MaxValue = 0
        Me.TxtRepayCapacity.MinValue = 0
        Me.TxtRepayCapacity.Name = "TxtRepayCapacity"
        Me.TxtRepayCapacity.Size = New System.Drawing.Size(112, 23)
        Me.TxtRepayCapacity.TabIndex = 37
        Me.TxtRepayCapacity.Text = ""
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(352, 208)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(154, 19)
        Me.Label83.TabIndex = 78
        Me.Label83.Text = "Immovable prpoerty :"
        '
        'txtImmovableproperty
        '
        Me.txtImmovableproperty.AlphaNumeric = True
        Me.txtImmovableproperty.AutoSize = False
        Me.txtImmovableproperty.BlankSpace = True
        Me.txtImmovableproperty.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImmovableproperty.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtImmovableproperty.Location = New System.Drawing.Point(576, 208)
        Me.txtImmovableproperty.LostFocusColour = System.Drawing.Color.Empty
        Me.txtImmovableproperty.Mandatory = False
        Me.txtImmovableproperty.MaxLength = 100
        Me.txtImmovableproperty.Multiline = True
        Me.txtImmovableproperty.Name = "txtImmovableproperty"
        Me.txtImmovableproperty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImmovableproperty.Size = New System.Drawing.Size(168, 56)
        Me.txtImmovableproperty.SpecialChar = True
        Me.txtImmovableproperty.TabIndex = 41
        Me.txtImmovableproperty.Text = ""
        '
        'txtReason
        '
        Me.txtReason.AlphaNumeric = True
        Me.txtReason.AutoSize = False
        Me.txtReason.BlankSpace = False
        Me.txtReason.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReason.Location = New System.Drawing.Point(576, 48)
        Me.txtReason.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReason.Mandatory = False
        Me.txtReason.MaxLength = 30
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(160, 24)
        Me.txtReason.SpecialChar = True
        Me.txtReason.TabIndex = 35
        Me.txtReason.Text = ""
        '
        'txtNOI
        '
        Me.txtNOI.AfterDecimal = 0
        Me.txtNOI.BeforeDecimal = 3
        Me.txtNOI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNOI.Location = New System.Drawing.Point(184, 208)
        Me.txtNOI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNOI.MaxLength = 10
        Me.txtNOI.MaxValue = 0
        Me.txtNOI.MinValue = 0
        Me.txtNOI.Name = "txtNOI"
        Me.txtNOI.Size = New System.Drawing.Size(64, 23)
        Me.txtNOI.TabIndex = 30
        Me.txtNOI.Text = ""
        '
        'dtpDemandLoanDate
        '
        Me.dtpDemandLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDemandLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDemandLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDemandLoanDate.Location = New System.Drawing.Point(184, 48)
        Me.dtpDemandLoanDate.MaxDate = New Date(9998, 11, 11, 0, 0, 0, 0)
        Me.dtpDemandLoanDate.Name = "dtpDemandLoanDate"
        Me.dtpDemandLoanDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDemandLoanDate.TabIndex = 25
        Me.dtpDemandLoanDate.Value = New Date(2008, 10, 31, 0, 0, 0, 0)
        '
        'cmbModeOfPayment
        '
        Me.cmbModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeOfPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeOfPayment.Items.AddRange(New Object() {"Cheque", "Cash", "DD"})
        Me.cmbModeOfPayment.Location = New System.Drawing.Point(576, 16)
        Me.cmbModeOfPayment.Name = "cmbModeOfPayment"
        Me.cmbModeOfPayment.Size = New System.Drawing.Size(160, 24)
        Me.cmbModeOfPayment.TabIndex = 34
        '
        'cmbInstallmentType
        '
        Me.cmbInstallmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstallmentType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInstallmentType.Items.AddRange(New Object() {"Monthly", "Quaterly", "Yearly"})
        Me.cmbInstallmentType.Location = New System.Drawing.Point(184, 304)
        Me.cmbInstallmentType.Name = "cmbInstallmentType"
        Me.cmbInstallmentType.Size = New System.Drawing.Size(160, 24)
        Me.cmbInstallmentType.TabIndex = 33
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(352, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(119, 19)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Purpose of Loan:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Amount Applied :"
        '
        'txtExpectedAmount
        '
        Me.txtExpectedAmount.AfterDecimal = 2
        Me.txtExpectedAmount.BeforeDecimal = 7
        Me.txtExpectedAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpectedAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtExpectedAmount.Location = New System.Drawing.Point(184, 16)
        Me.txtExpectedAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtExpectedAmount.MaxLength = 10
        Me.txtExpectedAmount.MaxValue = 0
        Me.txtExpectedAmount.MinValue = 0
        Me.txtExpectedAmount.Name = "txtExpectedAmount"
        Me.txtExpectedAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtExpectedAmount.TabIndex = 24
        Me.txtExpectedAmount.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 19)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Rate Of Intrest :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtROI.BeforeDecimal = 2
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.HighlightText
        Me.txtROI.Location = New System.Drawing.Point(184, 176)
        Me.txtROI.LostFocusColour = System.Drawing.Color.White
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(64, 23)
        Me.txtROI.TabIndex = 29
        Me.txtROI.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 304)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 19)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Installment Type :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(352, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(135, 19)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Mode Of Payment :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(97, 19)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "Applied Date:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 208)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 19)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "No Of Installments :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(352, 272)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(153, 19)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Details Of  Insurance:"
        '
        'txtInsuranceDetails
        '
        Me.txtInsuranceDetails.AlphaNumeric = True
        Me.txtInsuranceDetails.AutoSize = False
        Me.txtInsuranceDetails.BlankSpace = True
        Me.txtInsuranceDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsuranceDetails.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInsuranceDetails.Location = New System.Drawing.Point(576, 272)
        Me.txtInsuranceDetails.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInsuranceDetails.Mandatory = False
        Me.txtInsuranceDetails.MaxLength = 100
        Me.txtInsuranceDetails.Multiline = True
        Me.txtInsuranceDetails.Name = "txtInsuranceDetails"
        Me.txtInsuranceDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInsuranceDetails.Size = New System.Drawing.Size(168, 56)
        Me.txtInsuranceDetails.SpecialChar = True
        Me.txtInsuranceDetails.TabIndex = 42
        Me.txtInsuranceDetails.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(352, 144)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(151, 19)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Document Produced :"
        '
        'txtAssetDetails
        '
        Me.txtAssetDetails.AlphaNumeric = True
        Me.txtAssetDetails.AutoSize = False
        Me.txtAssetDetails.BlankSpace = True
        Me.txtAssetDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetDetails.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAssetDetails.Location = New System.Drawing.Point(576, 144)
        Me.txtAssetDetails.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAssetDetails.Mandatory = False
        Me.txtAssetDetails.MaxLength = 100
        Me.txtAssetDetails.Multiline = True
        Me.txtAssetDetails.Name = "txtAssetDetails"
        Me.txtAssetDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAssetDetails.Size = New System.Drawing.Size(168, 56)
        Me.txtAssetDetails.SpecialChar = True
        Me.txtAssetDetails.TabIndex = 40
        Me.txtAssetDetails.Text = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.txtOtherDetails)
        Me.TabPage1.Controls.Add(Me.Label98)
        Me.TabPage1.Controls.Add(Me.txtChequeDetails)
        Me.TabPage1.Controls.Add(Me.Label97)
        Me.TabPage1.Controls.Add(Me.Label96)
        Me.TabPage1.Controls.Add(Me.Label95)
        Me.TabPage1.Controls.Add(Me.lvMovableAssets)
        Me.TabPage1.Controls.Add(Me.lvFixedAssets)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(760, 467)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Securety Details"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtDirRelation)
        Me.GroupBox6.Controls.Add(Me.Label81)
        Me.GroupBox6.Controls.Add(Me.txtDirName)
        Me.GroupBox6.Controls.Add(Me.Label82)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox6.TabIndex = 78
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Relationship to any of Board of  directors"
        '
        'txtDirRelation
        '
        Me.txtDirRelation.AlphaNumeric = True
        Me.txtDirRelation.AutoSize = False
        Me.txtDirRelation.BlankSpace = True
        Me.txtDirRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirRelation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDirRelation.Location = New System.Drawing.Point(504, 24)
        Me.txtDirRelation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDirRelation.Mandatory = False
        Me.txtDirRelation.MaxLength = 30
        Me.txtDirRelation.Name = "txtDirRelation"
        Me.txtDirRelation.Size = New System.Drawing.Size(200, 24)
        Me.txtDirRelation.SpecialChar = True
        Me.txtDirRelation.TabIndex = 27
        Me.txtDirRelation.Text = ""
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(336, 24)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(162, 19)
        Me.Label81.TabIndex = 6
        Me.Label81.Text = "Nature of relationship :"
        '
        'txtDirName
        '
        Me.txtDirName.AlphaNumeric = True
        Me.txtDirName.AutoSize = False
        Me.txtDirName.BlankSpace = True
        Me.txtDirName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDirName.Location = New System.Drawing.Point(104, 24)
        Me.txtDirName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDirName.Mandatory = False
        Me.txtDirName.MaxLength = 30
        Me.txtDirName.Name = "txtDirName"
        Me.txtDirName.Size = New System.Drawing.Size(200, 24)
        Me.txtDirName.SpecialChar = True
        Me.txtDirName.TabIndex = 26
        Me.txtDirName.Text = ""
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(8, 24)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(55, 19)
        Me.Label82.TabIndex = 4
        Me.Label82.Text = "Name :"
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.AlphaNumeric = True
        Me.txtOtherDetails.AutoSize = False
        Me.txtOtherDetails.BlankSpace = False
        Me.txtOtherDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherDetails.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherDetails.Location = New System.Drawing.Point(496, 312)
        Me.txtOtherDetails.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherDetails.Mandatory = False
        Me.txtOtherDetails.MaxLength = 100
        Me.txtOtherDetails.Multiline = True
        Me.txtOtherDetails.Name = "txtOtherDetails"
        Me.txtOtherDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtherDetails.Size = New System.Drawing.Size(224, 72)
        Me.txtOtherDetails.SpecialChar = True
        Me.txtOtherDetails.TabIndex = 77
        Me.txtOtherDetails.Text = ""
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(384, 312)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(104, 19)
        Me.Label98.TabIndex = 76
        Me.Label98.Text = "Other Details :"
        '
        'txtChequeDetails
        '
        Me.txtChequeDetails.AlphaNumeric = True
        Me.txtChequeDetails.AutoSize = False
        Me.txtChequeDetails.BlankSpace = False
        Me.txtChequeDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeDetails.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeDetails.Location = New System.Drawing.Point(136, 312)
        Me.txtChequeDetails.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeDetails.Mandatory = False
        Me.txtChequeDetails.MaxLength = 100
        Me.txtChequeDetails.Multiline = True
        Me.txtChequeDetails.Name = "txtChequeDetails"
        Me.txtChequeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChequeDetails.Size = New System.Drawing.Size(224, 72)
        Me.txtChequeDetails.SpecialChar = True
        Me.txtChequeDetails.TabIndex = 75
        Me.txtChequeDetails.Text = ""
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(8, 320)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(117, 19)
        Me.Label97.TabIndex = 74
        Me.Label97.Text = "Cheque Details :"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(16, 88)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(112, 19)
        Me.Label96.TabIndex = 73
        Me.Label96.Text = "Movable Asset :"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(16, 200)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(92, 19)
        Me.Label95.TabIndex = 72
        Me.Label95.Text = "Fixed Asset :"
        '
        'lvMovableAssets
        '
        Me.lvMovableAssets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9})
        Me.lvMovableAssets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMovableAssets.FullRowSelect = True
        Me.lvMovableAssets.GridLines = True
        Me.lvMovableAssets.Location = New System.Drawing.Point(136, 88)
        Me.lvMovableAssets.Name = "lvMovableAssets"
        Me.lvMovableAssets.Size = New System.Drawing.Size(584, 96)
        Me.lvMovableAssets.TabIndex = 71
        Me.lvMovableAssets.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "slNo"
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Particulars"
        Me.ColumnHeader2.Width = 400
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Present Value"
        Me.ColumnHeader9.Width = 130
        '
        'lvFixedAssets
        '
        Me.lvFixedAssets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSl, Me.colParticulars, Me.colType, Me.colPresentValue})
        Me.lvFixedAssets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFixedAssets.FullRowSelect = True
        Me.lvFixedAssets.GridLines = True
        Me.lvFixedAssets.Location = New System.Drawing.Point(136, 200)
        Me.lvFixedAssets.Name = "lvFixedAssets"
        Me.lvFixedAssets.Size = New System.Drawing.Size(584, 96)
        Me.lvFixedAssets.TabIndex = 70
        Me.lvFixedAssets.View = System.Windows.Forms.View.Details
        '
        'colSl
        '
        Me.colSl.Text = "slNO"
        Me.colSl.Width = 37
        '
        'colParticulars
        '
        Me.colParticulars.Text = "Particulars"
        Me.colParticulars.Width = 220
        '
        'colType
        '
        Me.colType.Text = "Type"
        Me.colType.Width = 130
        '
        'colPresentValue
        '
        Me.colPresentValue.Text = "Present Value"
        Me.colPresentValue.Width = 180
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbOthers.Controls.Add(Me.Label89)
        Me.tbOthers.Controls.Add(Me.txtSalary)
        Me.tbOthers.Controls.Add(Me.Label88)
        Me.tbOthers.Controls.Add(Me.Label87)
        Me.tbOthers.Controls.Add(Me.Label86)
        Me.tbOthers.Controls.Add(Me.Label29)
        Me.tbOthers.Controls.Add(Me.txtSuplementForRepay)
        Me.tbOthers.Controls.Add(Me.txtNonEarningRepayMode)
        Me.tbOthers.Controls.Add(Me.Label103)
        Me.tbOthers.Controls.Add(Me.Label104)
        Me.tbOthers.Controls.Add(Me.Label92)
        Me.tbOthers.Controls.Add(Me.txtOtheSource)
        Me.tbOthers.Controls.Add(Me.Label85)
        Me.tbOthers.Controls.Add(Me.txtmemberToOtherCooperative)
        Me.tbOthers.Controls.Add(Me.Label84)
        Me.tbOthers.Controls.Add(Me.Panel6)
        Me.tbOthers.Controls.Add(Me.txtRemarks)
        Me.tbOthers.Controls.Add(Me.Label17)
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(760, 467)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(8, 96)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(180, 18)
        Me.Label89.TabIndex = 111
        Me.Label89.Text = "being remitted to  Sahakari "
        '
        'txtSalary
        '
        Me.txtSalary.AlphaNumeric = True
        Me.txtSalary.AutoSize = False
        Me.txtSalary.BlankSpace = False
        Me.txtSalary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSalary.Location = New System.Drawing.Point(216, 80)
        Me.txtSalary.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSalary.Mandatory = False
        Me.txtSalary.MaxLength = 30
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(160, 24)
        Me.txtSalary.SpecialChar = True
        Me.txtSalary.TabIndex = 3
        Me.txtSalary.Text = ""
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label88.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(16, 80)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(139, 18)
        Me.Label88.TabIndex = 110
        Me.Label88.Text = "Salary of applicant is "
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label87.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(64, 48)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(51, 18)
        Me.Label87.TabIndex = 109
        Me.Label87.Text = "of  loan"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label86.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(8, 32)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(203, 18)
        Me.Label86.TabIndex = 108
        Me.Label86.Text = "Can supplement for repayment "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(202, 18)
        Me.Label29.TabIndex = 107
        Me.Label29.Text = "Details Of  family member who "
        '
        'txtSuplementForRepay
        '
        Me.txtSuplementForRepay.AlphaNumeric = True
        Me.txtSuplementForRepay.AutoSize = False
        Me.txtSuplementForRepay.BlankSpace = True
        Me.txtSuplementForRepay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuplementForRepay.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSuplementForRepay.Location = New System.Drawing.Point(216, 16)
        Me.txtSuplementForRepay.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSuplementForRepay.Mandatory = False
        Me.txtSuplementForRepay.MaxLength = 100
        Me.txtSuplementForRepay.Multiline = True
        Me.txtSuplementForRepay.Name = "txtSuplementForRepay"
        Me.txtSuplementForRepay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSuplementForRepay.Size = New System.Drawing.Size(160, 56)
        Me.txtSuplementForRepay.SpecialChar = True
        Me.txtSuplementForRepay.TabIndex = 2
        Me.txtSuplementForRepay.Text = ""
        '
        'txtNonEarningRepayMode
        '
        Me.txtNonEarningRepayMode.AlphaNumeric = True
        Me.txtNonEarningRepayMode.AutoSize = False
        Me.txtNonEarningRepayMode.BlankSpace = False
        Me.txtNonEarningRepayMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonEarningRepayMode.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNonEarningRepayMode.Location = New System.Drawing.Point(584, 88)
        Me.txtNonEarningRepayMode.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNonEarningRepayMode.Mandatory = False
        Me.txtNonEarningRepayMode.MaxLength = 30
        Me.txtNonEarningRepayMode.Name = "txtNonEarningRepayMode"
        Me.txtNonEarningRepayMode.Size = New System.Drawing.Size(168, 24)
        Me.txtNonEarningRepayMode.SpecialChar = True
        Me.txtNonEarningRepayMode.TabIndex = 6
        Me.txtNonEarningRepayMode.Text = ""
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(376, 96)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(189, 18)
        Me.Label103.TabIndex = 104
        Me.Label103.Text = "how repayment will be made "
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(376, 80)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(199, 18)
        Me.Label104.TabIndex = 103
        Me.Label104.Text = "For non earning member state "
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(384, 48)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(158, 18)
        Me.Label92.TabIndex = 101
        Me.Label92.Text = "Other Sources of income"
        '
        'txtOtheSource
        '
        Me.txtOtheSource.AlphaNumeric = True
        Me.txtOtheSource.AutoSize = False
        Me.txtOtheSource.BlankSpace = False
        Me.txtOtheSource.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtheSource.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtheSource.Location = New System.Drawing.Point(584, 48)
        Me.txtOtheSource.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtheSource.Mandatory = False
        Me.txtOtheSource.MaxLength = 30
        Me.txtOtheSource.Name = "txtOtheSource"
        Me.txtOtheSource.Size = New System.Drawing.Size(168, 24)
        Me.txtOtheSource.SpecialChar = True
        Me.txtOtheSource.TabIndex = 5
        Me.txtOtheSource.Text = ""
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(384, 24)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(174, 18)
        Me.Label85.TabIndex = 100
        Me.Label85.Text = " Co-Operative   Institution:"
        '
        'txtmemberToOtherCooperative
        '
        Me.txtmemberToOtherCooperative.AlphaNumeric = True
        Me.txtmemberToOtherCooperative.AutoSize = False
        Me.txtmemberToOtherCooperative.BlankSpace = False
        Me.txtmemberToOtherCooperative.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmemberToOtherCooperative.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtmemberToOtherCooperative.Location = New System.Drawing.Point(584, 16)
        Me.txtmemberToOtherCooperative.LostFocusColour = System.Drawing.Color.Empty
        Me.txtmemberToOtherCooperative.Mandatory = False
        Me.txtmemberToOtherCooperative.MaxLength = 30
        Me.txtmemberToOtherCooperative.Name = "txtmemberToOtherCooperative"
        Me.txtmemberToOtherCooperative.Size = New System.Drawing.Size(168, 24)
        Me.txtmemberToOtherCooperative.SpecialChar = True
        Me.txtmemberToOtherCooperative.TabIndex = 4
        Me.txtmemberToOtherCooperative.Text = ""
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(384, 8)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(140, 18)
        Me.Label84.TabIndex = 99
        Me.Label84.Text = "Member to any other "
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnLoadPic)
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Controls.Add(Me.picSignature)
        Me.Panel6.Controls.Add(Me.Label61)
        Me.Panel6.Controls.Add(Me.picPhoto)
        Me.Panel6.Controls.Add(Me.Label62)
        Me.Panel6.Controls.Add(Me.btnClose2)
        Me.Panel6.Controls.Add(Me.btnSignature)
        Me.Panel6.Location = New System.Drawing.Point(10, 128)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(726, 240)
        Me.Panel6.TabIndex = 7
        '
        'btnLoadPic
        '
        Me.btnLoadPic.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnLoadPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPic.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPic.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPic.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnLoadPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPic.Location = New System.Drawing.Point(80, 192)
        Me.btnLoadPic.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnLoadPic.Name = "btnLoadPic"
        Me.btnLoadPic.Size = New System.Drawing.Size(72, 40)
        Me.btnLoadPic.TabIndex = 8
        Me.btnLoadPic.Text = "Load"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnClose.Location = New System.Drawing.Point(176, 192)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Cancel"
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(456, 16)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(168, 160)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 59
        Me.picSignature.TabStop = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(371, -21)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(57, 17)
        Me.Label61.TabIndex = 58
        Me.Label61.Text = "Signature"
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(80, 16)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(168, 160)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 57
        Me.picPhoto.TabStop = False
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(83, -21)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(37, 17)
        Me.Label62.TabIndex = 56
        Me.Label62.Text = "Photo"
        '
        'btnClose2
        '
        Me.btnClose2.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnClose2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose2.ForeColor = System.Drawing.Color.Black
        Me.btnClose2.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnClose2.Location = New System.Drawing.Point(552, 192)
        Me.btnClose2.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(72, 40)
        Me.btnClose2.TabIndex = 11
        Me.btnClose2.Text = "Cancel"
        '
        'btnSignature
        '
        Me.btnSignature.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignature.ForeColor = System.Drawing.Color.Black
        Me.btnSignature.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnSignature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignature.Location = New System.Drawing.Point(456, 192)
        Me.btnSignature.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(72, 40)
        Me.btnSignature.TabIndex = 10
        Me.btnSignature.Text = "Load"
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.AutoSize = False
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(104, 376)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(600, 80)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 12
        Me.txtRemarks.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 19)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Remarks :"
        '
        'tbLoanDocument
        '
        Me.tbLoanDocument.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.tbLoanDocument.Controls.Add(Me.chkDeselectAll)
        Me.tbLoanDocument.Controls.Add(Me.chkSelectAll)
        Me.tbLoanDocument.Controls.Add(Me.Label93)
        Me.tbLoanDocument.Controls.Add(Me.lvDocuments)
        Me.tbLoanDocument.Location = New System.Drawing.Point(4, 25)
        Me.tbLoanDocument.Name = "tbLoanDocument"
        Me.tbLoanDocument.Size = New System.Drawing.Size(760, 467)
        Me.tbLoanDocument.TabIndex = 6
        Me.tbLoanDocument.Text = "Check List"
        Me.tbLoanDocument.Visible = False
        '
        'chkDeselectAll
        '
        Me.chkDeselectAll.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.chkDeselectAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeselectAll.Location = New System.Drawing.Point(56, 232)
        Me.chkDeselectAll.Name = "chkDeselectAll"
        Me.chkDeselectAll.TabIndex = 52
        Me.chkDeselectAll.Text = "Deselect All"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.BackColor = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.chkSelectAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(56, 184)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(88, 24)
        Me.chkSelectAll.TabIndex = 51
        Me.chkSelectAll.Text = "Select All"
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(32, 37)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(176, 16)
        Me.Label93.TabIndex = 42
        Me.Label93.Text = "Documents Presented To Bank"
        '
        'lvDocuments
        '
        Me.lvDocuments.CheckBoxes = True
        Me.lvDocuments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clChkDoc, Me.clSlNo, Me.clDocuments})
        Me.lvDocuments.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDocuments.FullRowSelect = True
        Me.lvDocuments.GridLines = True
        Me.lvDocuments.Location = New System.Drawing.Point(240, 29)
        Me.lvDocuments.Name = "lvDocuments"
        Me.lvDocuments.Size = New System.Drawing.Size(368, 392)
        Me.lvDocuments.TabIndex = 41
        Me.lvDocuments.View = System.Windows.Forms.View.Details
        '
        'frmColleteralHandLoanDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 655)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmColleteralHandLoanDetail"
        Me.ShowInTaskbar = False
        Me.Text = "Colleteral Hand Loan Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbOccupationDetails.ResumeLayout(False)
        Me.pnlBus.ResumeLayout(False)
        Me.pnlsal.ResumeLayout(False)
        Me.tbGoldLoanDetails.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.tbOthers.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.tbLoanDocument.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"

    Dim objHandLoan As New clsHandLoan
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim objclsRepyment As New clsRePayment
    Dim objSBAccount As New clsSavingsBank1
    Dim objAssets As New clsAssets
    Dim objSBAccount1 As New clsSavingsBank
    Dim objSurety As New clsHomeLoanSurety
    Dim OfficeNo As String
    Dim objPerson As New clsPerson
#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmColleteralHandLoanDetail
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmColleteralHandLoanDetail
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmColleteralHandLoanDetail
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmColleteralHandLoanDetail)
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
        sbLoadDocumentList()
        ' sbLoadSBIntroAccount()
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

    Sub sbLoadDocumentList()
        Dim dt As New DataTable
        Dim intCount As Integer = 0
        Dim lvItem As ListViewItem
        If objHandLoan.fnGetDocuments Then
            dt = objHandLoan.DocumentTable
            While intCount < dt.Rows.Count
                lvItem = lvDocuments.Items.Add("")
                lvItem.SubItems.Add(dt.Rows(intCount).Item("DocId"))
                lvItem.SubItems.Add(dt.Rows(intCount).Item("DocName"))
                intCount += 1

            End While

        End If

    End Sub

#End Region

#Region "Photo and Signature Loading"

    Private Sub btnLoadPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPic.Click
        Dim OfdPic As New OpenFileDialog
        OfdPic.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdPic.ShowDialog() = DialogResult.OK Then
            picPhoto.Image = Image.FromFile(OfdPic.FileName)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnSignature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignature.Click
        Dim OfdSign As New OpenFileDialog
        OfdSign.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdSign.ShowDialog() = DialogResult.OK Then
            picSignature.Image = Image.FromFile(OfdSign.FileName)
        End If
    End Sub

    Private Sub btnClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose2.Click
        picSignature.Image = Nothing
    End Sub

#End Region

#Region "Functions "

    Function fnCheck() As Boolean

        Dim intCount As Integer

        If Trim(txtLoanNo.Text) = "CHL" Then
            MsgBox("Enter account no ", MsgBoxStyle.Exclamation)
            txtLoanNo.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
            'ElseIf Trim(txtSBNo.Text) = String.Empty Then
            '    MsgBox("Please Enter SB account number")
            '    txtSBNo.Focus()
            '    Return False
            'ElseIf Trim(txtSBNo.Text) = String.Empty Or Trim(txtMemberNo.Text) = String.Empty Then
            '    MsgBox("Please check SB account number and Member number")
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
        ElseIf Trim(cmbAccType.SelectedItem) = String.Empty Then
            MsgBox("Enter loan type", MsgBoxStyle.Exclamation)
            cmbAccType.Focus()
            Return False
        ElseIf Trim(txtExpectedAmount.Text) = String.Empty Then
            MsgBox("Enter applied amount for loan", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbGoldLoanDetails
            txtExpectedAmount.Focus()
            Return False
        ElseIf Trim(txtSanctionedAmount.Text) = String.Empty Then
            MsgBox("Enter sanctioned amount for loan", MsgBoxStyle.Exclamation)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf Val(txtSanctionedAmount.Text) > Trim(txtExpectedAmount.Text) Then
            MsgBox("Please check applied amount and saction amount", MsgBoxStyle.Exclamation)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf Trim(txtSanctionedNo.Text) = String.Empty Then
            MsgBox("Enter sanctioned number", MsgBoxStyle.Exclamation)
            txtSanctionedNo.Focus()
            Return False
        ElseIf Trim(txtROI.Text) = String.Empty Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False
        ElseIf txtNOI.Text = String.Empty Then
            MsgBox("Enter no of Installments", MsgBoxStyle.Exclamation)
            txtNOI.Focus()
            Return False
        ElseIf txtInstAmount.Text = String.Empty Then
            MsgBox("Enter instalment amount", MsgBoxStyle.Exclamation)
            txtInstAmount.Focus()
            Return False
        ElseIf cmbInstallmentType.SelectedIndex = -1 Then
            MsgBox("Select installment for loan payment", MsgBoxStyle.Exclamation)
            cmbInstallmentType.Focus()
            Return False
        ElseIf cmbModeOfPayment.SelectedIndex = -1 Then
            MsgBox("Select mode of payment for loan", MsgBoxStyle.Exclamation)
            cmbModeOfPayment.Focus()
            Return False
        ElseIf Trim(txtReason.Text) = String.Empty Then
            MsgBox("Enter reason for loan", MsgBoxStyle.Exclamation)
            txtReason.Focus()
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Enter receipt no", MsgBoxStyle.Exclamation, "Loan Module")
            txtReceiptNo.Focus()
            Return False
        ElseIf (Mid(txtSanctionedAmount.Text, 1, 1)) = 0 Then
            MsgBox("Please check the sanctioned amount", MsgBoxStyle.Information)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf (dtpDemandSancDate.Value < dtpDemandLoanDate.Value) Then
            MsgBox("Sanctioned date should be greater than Applied date", MsgBoxStyle.Information)
            dtpDemandLoanDate.Focus()
            Return False
        ElseIf (dtpDueDate.Value < dtpDemandSancDate.Value) Then
            MsgBox("Due date should be greater than Sanctioned date", MsgBoxStyle.Information)
            dtpDueDate.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    Public Function fnGetROI() As Boolean

        If objSBAccount.fnGetROI(txtLoanNo.Text, txtSanctionedAmount.Text) Then

            txtROI.Text = (objSBAccount.Loantypetable.Rows(0).Item("ROI"))

        End If

    End Function
    Function fnUpdateLoanDocunentStat(ByVal objTrans As IDbTransaction) As Boolean
        If objHandLoan.fnDeleteLoanDocunentStat(Trim(txtLoanNo.Text), objTrans) Then
            If objHandLoan.fnInsertLoanDocunentStat(objTrans) Then

            End If
        End If
    End Function

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objHandLoan.fnChekHLAccount(Trim(txtLoanNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objHandLoan.fnAddDLAccount(objTrans) = True Then

                'Log Entry
                fnLogEntry(pbUserId, "New CHL created " & txtLoanNo.Text, Date.Now, "New CHL", objTrans)
                MessageBox.Show("New colleteral hand loan created successfully.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                Return True

            Else

                MessageBox.Show("New colleteral hand loan  creation failed, because of internal error.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                Return False

            End If

        Else

            'update details (edit mode)

            If objHandLoan.fnUpdateLoanDetails(Trim(txtLoanNo.Text), objTrans) Then

                If objHandLoan.fnUpDateHLDet(Trim(txtLoanNo.Text), objTrans) Then
                    fnUpdateLoanDocunentStat(objTrans)
                    fnLogEntry(pbUserId, "CHL updated" & txtLoanNo.Text, Date.Now, "Update CHL account", objTrans)
                    MessageBox.Show("Colleteral hand loan updated successfully.", "Loan  module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                    Return True

                Else

                    MessageBox.Show("Colleteral hand loan updation failed, because of internal error.", "Loan module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                    Return False

                End If

            End If

        End If

    End Function
    Function fnGenerateVoucher() As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDemandLoanDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReceiptNo.Text, dtpDemandLoanDate.Value, txtSanctionedAmount.Text, "By new hand loan" & txtCustomerID.Text, lngSlNo, "Y")

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDemandLoanDate.Value, "By hand loan account " & txtLoanNo.Text, "To", 1, 0, Val(txtSanctionedAmount.Text), 1, "Y")

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDemandLoanDate.Value, "By cash account " & txtLoanNo.Text, "By", 17, Val(txtSanctionedAmount.Text), 0, 2, "Y")

        Return True

    End Function

    Function fnSetData() As Boolean

        ' Person Deatils

        If lngPersonNo <> 0 Then
            objHandLoan.PersonNo = lngPersonNo
        Else
            objHandLoan.PersonNo = objHandLoan.fnGetNewPersonNo()
        End If

        objHandLoan.Name = txtName.Text
        objHandLoan.FatherName = txtFatherName.Text
        objHandLoan.PermAddress = txtPermAddress.Text
        objHandLoan.PresAddress = txtPresAddress.Text
        objHandLoan.PhoneNo = txtPhoneNo.Text
        objHandLoan.MobileNo = txtMobileNo.Text
        objHandLoan.DOB = Format(dtpDOB.Value, "yyyy-MM-dd")
        objHandLoan.Age = txtAge.Text
        objHandLoan.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objHandLoan.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objHandLoan.ReligionCode = cmbReligion.SelectedValue
        objHandLoan.OccupationCode = cmbOccupation.SelectedValue
        objHandLoan.OfficeNo = OfficeNo
        'Loan Details

        objHandLoan.LoanNo = txtLoanNo.Text
        objHandLoan.SBNo = txtSBNo.Text
        objHandLoan.MemberNo = txtCustomerID.Text
        objHandLoan.FDNo = ""
        objHandLoan.OfficeName = txtOfficeName.Text
        objHandLoan.Designation = txtDesignation.Text
        objHandLoan.MobileNo2 = txtMobileNo2.Text
        objHandLoan.ServiceCompleted = Val(txtPerService.Text)
        objHandLoan.NoOfDependants = Val(txtNoofDependant.Text)
        objHandLoan.MonthlyExpenses = Val(txtMonthlyExp.Text)
        objHandLoan.DirName = txtDirName.Text
        objHandLoan.DirNatureOfRelation = txtDirRelation.Text

        Select Case cmbAccType.SelectedItem
            Case "Joint"
                objHandLoan.LoanType = "J"
            Case "Single"
                objHandLoan.LoanType = "S"
        End Select

        If chkSalary.Checked = True Then
            objHandLoan.SalaryPerson = "Y"
        Else
            objHandLoan.SalaryPerson = "N"
        End If

        objHandLoan.SurParticularsOfMonth = txtpnlParticularMonth.Text
        objHandLoan.Salary = Val(txtBasic.Text)
        objHandLoan.DeamessAllowance = Val(txtDeamessAll.Text)
        objHandLoan.HouseRentAllowance = Val(txtHouseRentAll.Text)
        objHandLoan.ComensatoryAllowance = Val(txtCityComensatoryAll.Text)
        objHandLoan.Otherallowance = Val(txtOtherAll.Text)
        objHandLoan.TotalAmount = Val(txtAmount.Text)
        objHandLoan.NetSalary = Val(txtNetSAlary.Text)
        objHandLoan.IncomeTax = Val(txtIncomeTax.Text)
        objHandLoan.ProvidentFund = Val(txtProvidentFund.Text)
        objHandLoan.InsurancePremium = Val(txtInsuPremium.Text)
        objHandLoan.HBA = Val(txtHBA.Text)
        objHandLoan.OtherDeduction = Val(txtOtherDeductions.Text)
        objHandLoan.TotalDeduction = Val(txtTotalDeduction.Text)
        objHandLoan.familyMonthlyExpenses = Val(txtMonthlyDomesticExp.Text)


        If chkBusiness.Checked = True Then
            objHandLoan.BusinessPerson = "Y"
        Else
            objHandLoan.BusinessPerson = "N"
        End If

        objHandLoan.NatureOfBusiness = txtNatofBusiness.Text
        objHandLoan.YearOfEstablishment = Format(dtpYearofEst.Value, "yyyy-MM-dd")

        objHandLoan.AnnualTurnOver = Val(txtAnnuTurnover.Text)
        objHandLoan.AnnualIncome = Val(txtAnuIncome.Text)
        objHandLoan.DocumentsProduced = txtDocument.Text
        objHandLoan.TaxDetails = txtTaxDetail.Text


        objHandLoan.HandLReason = txtReason.Text
        objHandLoan.HandLROI = (txtROI.Text / 100)
        objHandLoan.HandLExpectedAmount = txtExpectedAmount.Text
        objHandLoan.HandLSanctioned = Val(txtSanctionedAmount.Text)

        objHandLoan.Status = "Active"
        objHandLoan.LastInstDate = "9999-9-9"
        objHandLoan.HandLoanAmtBalance = 0
        objHandLoan.HandLDisbAmt = 0

        objHandLoan.HandLoanLastPaidDate = "9999-9-9"
        objHandLoan.HandLInstallments = cmbInstallmentType.SelectedItem
        objHandLoan.HandLModeOfPayment = cmbModeOfPayment.SelectedItem
        objHandLoan.HandLoanDate = Format(dtpDemandLoanDate.Value, "yyyy-MM-dd")
        objHandLoan.Remarks = txtRemarks.Text
        objHandLoan.NOI = txtNOI.Text
        objHandLoan.HandLSanctionedNo = txtSanctionedNo.Text
        objHandLoan.HandLoanSancDate = Format(dtpDemandSancDate.Value, "yyyy-MM-dd")
        objHandLoan.HandLoanDueDate = Format(dtpDueDate.Value, "yyyy-MM-dd")
        objHandLoan.ReciptNo = txtReceiptNo.Text
        objHandLoan.HandLoanInstPrinciple = Val(txtInstAmount.Text)
        ''Demand LoanDetails

        objHandLoan.OfficeName = txtOfficeName.Text
        objHandLoan.Designation = txtDesignation.Text
        objHandLoan.RemittedToSahakari = txtSalary.Text
        objHandLoan.AssetDetails = txtAssetDetails.Text
        objHandLoan.ImmoveableProperty = txtImmovableproperty.Text
        objHandLoan.OtherMemebrShip = txtmemberToOtherCooperative.Text
        objHandLoan.RepaymentCapacity = Val(TxtRepayCapacity.Text)
        objHandLoan.InsuranceDetail = txtInsuranceDetails.Text
        objHandLoan.SupplementDetail = txtSuplementForRepay.Text
        objHandLoan.RepayModeForNonEarning = txtNonEarningRepayMode.Text
        objHandLoan.OtherSourceOfIncome = txtOtheSource.Text
        objHandLoan.ChequeDetail = txtChequeDetails.Text
        objHandLoan.OtherDetail = txtOtherDetails.Text

        Dim dtDocuments As New DataTable
        Dim drRow As DataRow
        dtDocuments.Columns.Add("DocId")
        dtDocuments.Columns.Add("DocName")
        dtDocuments.Columns.Add("DocStatus")
        Dim intCOuntter As Integer = 0
        While intCOuntter < lvDocuments.Items.Count
            drRow = dtDocuments.NewRow
            drRow(0) = txtLoanNo.Text
            If lvDocuments.Items(intCOuntter).Checked = True Then
                drRow(1) = lvDocuments.Items(intCOuntter).SubItems(1).Text
                drRow(2) = "Y"
                dtDocuments.Rows.Add(drRow)
            End If
            intCOuntter += 1
        End While
        objHandLoan.DocumentTable = dtDocuments

        Return True

    End Function


    Function fnLoadFAssets()
        Dim objDT As New DataTable
        Dim lvItem As ListViewItem
        Dim intCounter As Integer = 0
        lvFixedAssets.Items.Clear()
        If objAssets.fnGetFixedAsset(txtLoanNo.Text) Then
            objDT = objAssets.FixedAssetsTable
            While intCounter < objDT.Rows.Count
                lvItem = lvFixedAssets.Items.Add(objDT.Rows(intCounter).Item("SlNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PName"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PType"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PresentVal"))
                intCounter += 1
            End While
        End If
    End Function

    Function fnLoadMAssets()
        Dim objDT As New DataTable
        Dim lvItem As ListViewItem
        Dim intCounter As Integer = 0
        lvMovableAssets.Items.Clear()
        If objAssets.fnGetMovableAsset(txtLoanNo.Text) Then
            objDT = objAssets.MovableAssetsTable
            While intCounter < objDT.Rows.Count
                lvItem = lvMovableAssets.Items.Add(objDT.Rows(intCounter).Item("SlNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PName"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PresentVal"))
                intCounter += 1
            End While
        End If
    End Function

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
                    objTrans = fnGetTransaction()
                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                    End If
                    btnAdd_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try


    End Sub

    Private Sub frmSBAccCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = Date.Now
        dtpDOB.Value = Date.Now
        dtpDemandLoanDate.Value = Date.Now
        dtpDemandSancDate.Value = Date.Now
        dtpDueDate.Value = Date.Now
        sbLoadControlValues() 'Load Values 
        If txtLoanNo.Text <> String.Empty Then
            sbLoadDLAccDetails()
            txtLoanNo.Text = "CHL"
        End If
        pnlBus.Enabled = False
        pnlsal.Enabled = False
        btnAdd_Click(sender, e)
        txtLoanNo.Focus()
    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtLoanNo.Text = "CHL" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanNo.KeyPress

        If txtLoanNo.Text = "CHL" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyDown

        If txtLoanNo.Text = "CHL" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmCHandLoanCust As New frmColleteralHandLoanCustl
        objfrmCHandLoanCust.strCHandLoan = String.Empty
        objfrmCHandLoanCust.ShowDialog(Me)
        If objfrmCHandLoanCust.strCHandLoan <> String.Empty Then
            txtLoanNo.Text = objfrmCHandLoanCust.strCHandLoan
            sbLoadDLAccDetails()
        End If
        objfrmCHandLoanCust.Dispose()

    End Sub

    Private Sub btnMemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            sbClear()
            txtCustomerID.Text = objMemberSearch.strMemberNo
            sbGeneral()
        End If
        objMemberSearch.Dispose()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click

        If objclsRepyment.fnGetData(txtLoanNo.Text) Then
            If objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") > 0 Then
                Dim ObjRepayment As New FrmRePayement
                ObjRepayment.txtLoanNo.Text = txtLoanNo.Text
                ObjRepayment.txtName.Text = txtName.Text
                ObjRepayment.ShowDialog(Me)
            Else
                MsgBox("Please disburse the amount first", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click

        If objHandLoan.fnChekHLAccount(Trim(txtLoanNo.Text)) = True Then
            Dim ObjfrmDisb As New frmDisbursment
            ObjfrmDisb.txtLoanNo.Text = txtLoanNo.Text
            ObjfrmDisb.ShowDialog(Me)
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If

    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click

        If objHandLoan.fnChekHLAccount(Trim(txtLoanNo.Text)) = True Then
            Dim objfrmTransaction As New frmTransaction
            objfrmTransaction.txtLoanNo.Text = txtLoanNo.Text
            objfrmTransaction.txtName.Text = txtName.Text
            objfrmTransaction.ShowDialog(Me)
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        nMode = CTAdd
        sbClear()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objSBAccount.fnGetNewLoanNo("CHL"), 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "CHL" & String.Format("{0:00000}", CInt(TempNewNo))
            txtLoanNo.Text = Temp
            txtLoanNo.Focus()
        Else
            MsgBox("CHL number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
        End If

    End Sub
    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.TextChanged

        If txtLoanNo.Text.StartsWith("CHL") = False Then
            txtLoanNo.Undo()
            txtLoanNo.ClearUndo()
        End If

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

    Private Sub chkSalary_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSalary.CheckedChanged
        If chkSalary.Checked = True Then
            pnlsal.Enabled = True
        Else
            pnlsal.Enabled = False
        End If
    End Sub
    Private Sub chkBusiness_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBusiness.CheckedChanged
        If chkBusiness.Checked = True Then
            pnlBus.Enabled = True
        Else
            pnlBus.Enabled = False
        End If
    End Sub

    Private Sub txtBasic_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBasic.TextChanged, txtDeamessAll.TextChanged, txtHouseRentAll.TextChanged, txtCityComensatoryAll.TextChanged, txtOtherAll.TextChanged
        txtAmount.Text = Val(txtBasic.Text) + Val(txtDeamessAll.Text) + Val(txtHouseRentAll.Text) + Val(txtCityComensatoryAll.Text) + Val(txtOtherAll.Text)
    End Sub

    Private Sub txtIncomeTax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIncomeTax.TextChanged, txtProvidentFund.TextChanged, txtInsuPremium.TextChanged, txtHBA.TextChanged, txtOtherDeductions.TextChanged
        txtTotalDeduction.Text = Val(txtIncomeTax.Text) + Val(txtProvidentFund.Text) + Val(txtInsuPremium.Text) + Val(txtHBA.Text) + Val(txtOtherDeductions.Text)
    End Sub

    Private Sub txtLoanNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.TextChanged
        If txtLoanNo.Text.StartsWith("CHL") = False Then
            txtLoanNo.Undo()
            txtLoanNo.ClearUndo()
        End If
    End Sub

    Private Sub txtLoanNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoanNo.Leave
        If objHandLoan.fnChekHLAccount(Trim(txtLoanNo.Text)) = True Then
            If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sbLoadDLAccDetails()
            Else
                txtLoanNo.Focus()
            End If
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        Dim intcount As Integer = 0
        'chkDeselectAll.Checked = False
        While intcount < lvDocuments.Items.Count
            lvDocuments.Items(intcount).Checked = True
            intcount += 1
        End While

    End Sub


    Private Sub chkDeselectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDeselectAll.CheckedChanged
        Dim intcount As Integer = 0
        ' chkSelectAll.Checked = False
        While intcount < lvDocuments.Items.Count
            lvDocuments.Items(intcount).Checked = False
            intcount += 1
        End While
    End Sub


#End Region

#Region "Genral Subroutines"

    Sub sbLoadDLAccDetails()

        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objHandLoan.fnGetLoanDetails(txtLoanNo.Text) Then
                sbClear()

                objDT = objHandLoan.HandLoanDettable()

                'Sb Details

                txtLoanNo.Text = objDT.Rows(0).Item("LoanNo")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                'Person Deatils

                'Dim str As String = objDT.Rows(0).Item("SBNo")
                'Dim TempNewNo As String = Mid(str, 1, 2)
                'If (TempNewNo = "CA") Then
                '    Label39.Text = "CA No. :"
                'Else
                '    Label39.Text = "SB No. :"
                'End If
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
                Select Case objDT.Rows(0).Item("LoanType")
                    Case "S"
                        cmbAccType.SelectedItem = "Single"
                    Case "J"
                        cmbAccType.SelectedItem = "Joint"
                End Select
                txtExpectedAmount.Text = objDT.Rows(0).Item("ExpAmount")
                txtSanctionedAmount.Text = objDT.Rows(0).Item("SancAmount")
                dtpDemandLoanDate.Value = CDate(objDT.Rows(0).Item("ApplDate"))
                dtpDemandSancDate.Value = CDate(objDT.Rows(0).Item("SancDate"))
                txtSanctionedNo.Text = objDT.Rows(0).Item("SancNo")
                dtpDueDate.Value = CDate(objDT.Rows(0).Item("DueDate"))
                txtROI.Text = Format((objDT.Rows(0).Item("ROI") * 100), "00.00")
                txtNOI.Text = objDT.Rows(0).Item("NOI")
                txtInstAmount.Text = objDT.Rows(0).Item("InstPrinciple")
                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")

                cmbInstallmentType.SelectedItem = objDT.Rows(0).Item("Type")
                cmbModeOfPayment.Text = objDT.Rows(0).Item("RepayMode")
                txtReason.Text = objDT.Rows(0).Item("Purpose")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtSBNo.Text = objDT.Rows(0).Item("SBNo")
                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")


                'VehicleDetails
                If objHandLoan.fnGetHandLoanDet(txtLoanNo.Text) Then

                    txtOfficeName.Text = objHandLoan.HLDetailstable.Rows(0).Item("OfficeName")
                    txtDesignation.Text = objHandLoan.HLDetailstable.Rows(0).Item("Designation")
                    txtPerService.Text = objHandLoan.HLDetailstable.Rows(0).Item("NoOfServiceCompleted")
                    txtNoofDependant.Text = objHandLoan.HLDetailstable.Rows(0).Item("NoDependants")
                    txtMonthlyExp.Text = objHandLoan.HLDetailstable.Rows(0).Item("MonthlyExpenses")
                    txtDirName.Text = objHandLoan.HLDetailstable.Rows(0).Item("DirectorName")
                    txtDirRelation.Text = objHandLoan.HLDetailstable.Rows(0).Item("DirRelationship")
                    txtMobileNo2.Text = objHandLoan.HLDetailstable.Rows(0).Item("MobileNo2")

                    If objHandLoan.HLDetailstable.Rows(0).Item("SalariedPerson") = "Y" Then
                        chkSalary.Checked = True
                        txtpnlParticularMonth.Text = objHandLoan.HLDetailstable.Rows(0).Item("SuretyParticulars")
                        txtBasic.Text = objHandLoan.HLDetailstable.Rows(0).Item("SBasicPay")
                        txtDeamessAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SDeamessAllowance")
                        txtHouseRentAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SHouseREntAllowance")
                        txtCityComensatoryAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SCityComensatoryAllowance")
                        txtOtherAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SotherIncome")
                        txtAmount.Text = objHandLoan.HLDetailstable.Rows(0).Item("STotalAmount")
                        txtNetSAlary.Text = objHandLoan.HLDetailstable.Rows(0).Item("SNetSalary")
                        txtIncomeTax.Text = objHandLoan.HLDetailstable.Rows(0).Item("SincomeTax")
                        txtProvidentFund.Text = objHandLoan.HLDetailstable.Rows(0).Item("SProvidentFund")
                        txtInsuPremium.Text = objHandLoan.HLDetailstable.Rows(0).Item("SInsurancePremium")
                        txtHBA.Text = objHandLoan.HLDetailstable.Rows(0).Item("SHBA")
                        txtOtherDeductions.Text = objHandLoan.HLDetailstable.Rows(0).Item("SOtherDeduction")
                        txtTotalDeduction.Text = objHandLoan.HLDetailstable.Rows(0).Item("STotalDeduction")
                        txtMonthlyDomesticExp.Text = objHandLoan.HLDetailstable.Rows(0).Item("FamilyMonDomesticExpn")
                    Else
                        chkSalary.Checked = False
                        txtpnlParticularMonth.Text = objHandLoan.HLDetailstable.Rows(0).Item("SuretyParticulars")
                        txtBasic.Text = objHandLoan.HLDetailstable.Rows(0).Item("SBasicPay")
                        txtDeamessAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SDeamessAllowance")
                        txtHouseRentAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SHouseREntAllowance")
                        txtCityComensatoryAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SCityComensatoryAllowance")
                        txtOtherAll.Text = objHandLoan.HLDetailstable.Rows(0).Item("SotherIncome")
                        txtAmount.Text = objHandLoan.HLDetailstable.Rows(0).Item("STotalAmount")
                        txtNetSAlary.Text = objHandLoan.HLDetailstable.Rows(0).Item("SNetSalary")
                        txtIncomeTax.Text = objHandLoan.HLDetailstable.Rows(0).Item("SincomeTax")
                        txtProvidentFund.Text = objHandLoan.HLDetailstable.Rows(0).Item("SProvidentFund")
                        txtInsuPremium.Text = objHandLoan.HLDetailstable.Rows(0).Item("SInsurancePremium")
                        txtHBA.Text = objHandLoan.HLDetailstable.Rows(0).Item("SHBA")
                        txtOtherDeductions.Text = objHandLoan.HLDetailstable.Rows(0).Item("SOtherDeduction")
                        txtTotalDeduction.Text = objHandLoan.HLDetailstable.Rows(0).Item("STotalDeduction")
                        txtMonthlyDomesticExp.Text = objHandLoan.HLDetailstable.Rows(0).Item("FamilyMonDomesticExpn")

                    End If

                    If objHandLoan.HLDetailstable.Rows(0).Item("BusinessPerson") = "Y" Then
                        chkBusiness.Checked = True
                        txtNatofBusiness.Text = objHandLoan.HLDetailstable.Rows(0).Item("BNatureOfBusiness")
                        dtpYearofEst.Value = CDate(objHandLoan.HLDetailstable.Rows(0).Item("BYearofEstablished"))
                        txtAnnuTurnover.Text = objHandLoan.HLDetailstable.Rows(0).Item("BAnnualTurnover")
                        txtAnuIncome.Text = objHandLoan.HLDetailstable.Rows(0).Item("BAnnualIncome")
                        txtDocument.Text = objHandLoan.HLDetailstable.Rows(0).Item("BDocForBusiness")
                        txtTaxDetail.Text = objHandLoan.HLDetailstable.Rows(0).Item("BIncomeSalesTax")

                    Else
                        chkBusiness.Checked = False
                        txtNatofBusiness.Text = objHandLoan.HLDetailstable.Rows(0).Item("BNatureOfBusiness")
                        dtpYearofEst.Value = CDate(objHandLoan.HLDetailstable.Rows(0).Item("BYearofEstablished"))
                        txtAnnuTurnover.Text = objHandLoan.HLDetailstable.Rows(0).Item("BAnnualTurnover")
                        txtAnuIncome.Text = objHandLoan.HLDetailstable.Rows(0).Item("BAnnualIncome")
                        txtDocument.Text = objHandLoan.HLDetailstable.Rows(0).Item("BDocForBusiness")
                        txtTaxDetail.Text = objHandLoan.HLDetailstable.Rows(0).Item("BIncomeSalesTax")

                    End If


                    objHandLoan.HandLoanAmtBalance = 0
                    objHandLoan.HandLDisbAmt = 0

                    ''Hand LoanDetails


                    txtAssetDetails.Text = objHandLoan.HLDetailstable.Rows(0).Item("AssetDetails")
                    txtImmovableproperty.Text = objHandLoan.HLDetailstable.Rows(0).Item("Immovableproperty")
                    txtmemberToOtherCooperative.Text = objHandLoan.HLDetailstable.Rows(0).Item("memberToAnyOtherCooperative")
                    TxtRepayCapacity.Text = objHandLoan.HLDetailstable.Rows(0).Item("RepayingCapacityPerMonth")
                    txtSuplementForRepay.Text = objHandLoan.HLDetailstable.Rows(0).Item("SuppleForRepay")
                    txtInsuranceDetails.Text = objHandLoan.HLDetailstable.Rows(0).Item("InsuranceDetail")
                    txtNonEarningRepayMode.Text = objHandLoan.HLDetailstable.Rows(0).Item("RepaymentModeForNonEarning")
                    txtOtheSource.Text = objHandLoan.HLDetailstable.Rows(0).Item("OtherSourceOfIncome")
                    txtSalary.Text = objHandLoan.HLDetailstable.Rows(0).Item("SalaryRemitanceToSahakari")
                    txtChequeDetails.Text = objHandLoan.HLDetailstable.Rows(0).Item("ChequeDetails")
                    txtOtherDetails.Text = objHandLoan.HLDetailstable.Rows(0).Item("OtherDetails")

                End If

                fnLoadFAssets()
                fnLoadMAssets()
                fnLoadSuretyPerson()

                If objHandLoan.fnGetDoc(Trim(txtLoanNo.Text)) Then
                    Dim dtdoc As New DataTable
                    Dim intcount As Integer = 0
                    Dim intcount1 As Integer = 0
                    dtdoc = objHandLoan.DocumentTable
                    While intcount1 < dtdoc.Rows.Count
                        While intcount < lvDocuments.Items.Count
                            If lvDocuments.Items(intcount).SubItems(1).Text = dtdoc.Rows(intcount1).Item(1) Then
                                lvDocuments.Items(intcount).Checked = True
                            End If
                            intcount += 1
                        End While
                        intcount1 += 1
                        intcount = 0
                    End While
                End If

                'txtSanctionedAmount.Enabled = False
                'txtROI.Enabled = False
                'txtReceiptNo.ReadOnly = True
                'txtExpectedAmount.ReadOnly = True
                'txtLoanNo.ReadOnly = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub sbClear()

        Dim intCount As Integer = 0
        lngPersonNo = 0
        txtLoanNo.ReadOnly = False
        txtSanctionedAmount.ReadOnly = False
        txtCustomerID.ResetText()
        txtCustomerID.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        txtSBNo.ResetText()
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
        txtInsuranceDetails.ResetText()
        txtRemarks.ResetText()
        txtExpectedAmount.ResetText()
        txtSanctionedAmount.ResetText()
        txtROI.ResetText()
        cmbInstallmentType.SelectedIndex = -1
        cmbModeOfPayment.SelectedIndex = -1
        txtReason.ResetText()
        txtOfficeName.Text = ""
        txtDesignation.Text = ""
        txtAssetDetails.Text = ""
        txtNOI.Text = ""
        txtInstAmount.Text = ""
        txtPerService.Text = ""
        txtNoofDependant.Text = ""
        txtMonthlyExp.Text = ""
        txtDirName.Text = ""
        txtDirRelation.Text = ""

        chkSalary.Checked = False

        txtpnlParticularMonth.Text = ""
        txtBasic.Text = ""
        txtDeamessAll.Text = ""
        txtHouseRentAll.Text = ""
        txtCityComensatoryAll.Text = ""
        txtOtherAll.Text = ""
        txtAmount.Text = ""
        txtNetSAlary.Text = ""
        txtIncomeTax.Text = ""
        txtProvidentFund.Text = ""
        txtInsuPremium.Text = ""
        txtHBA.Text = ""
        txtOtherDeductions.Text = ""
        txtTotalDeduction.Text = ""
        txtMonthlyDomesticExp.Text = ""
        txtMobileNo2.ResetText()
        txtSanctionedNo.ResetText()


        chkBusiness.Checked = False

        txtNatofBusiness.Text = ""
        txtAnnuTurnover.Text = ""
        txtAnuIncome.Text = ""
        txtDocument.Text = ""
        txtTaxDetail.Text = ""


        txtReason.Text = ""
        txtROI.Text = ""
        txtExpectedAmount.Text = ""
        txtSanctionedAmount.Text = ""

        txtRemarks.Text = ""
        txtNOI.Text = ""
        txtReceiptNo.Text = ""


        txtSalary.Text = ""
        txtAssetDetails.Text = ""
        txtImmovableproperty.Text = ""
        txtmemberToOtherCooperative.Text = ""
        TxtRepayCapacity.Text = ""
        txtSuplementForRepay.Text = ""
        txtNonEarningRepayMode.Text = ""
        txtOtheSource.Text = ""

        txtSanctionedAmount.ReadOnly = False
        txtSanctionedAmount.Enabled = True
        txtROI.Enabled = True
        txtReceiptNo.ReadOnly = False
        txtExpectedAmount.ReadOnly = False
        txtLoanNo.ReadOnly = False

        txtSBNo.ReadOnly = False
        btnMemSearch.Enabled = True

        txtChequeDetails.ResetText()
        txtOtherDetails.ResetText()
        lvFixedAssets.Items.Clear()
        lvMovableAssets.Items.Clear()


        chkSelectAll.Checked = False
        chkDeselectAll.Checked = False


        btnSBSearch.Enabled = True
        btnMemSearch.Enabled = True
        txtCustomerID.ReadOnly = False
        txtSBNo.ReadOnly = False

        While intCount < lvDocuments.Items.Count
            lvDocuments.Items(intCount).Checked = False
            intCount += 1
        End While

        lvSuretyDetail.Items.Clear()


    End Sub

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

                txtSBNo.ReadOnly = True
                txtCustomerID.ReadOnly = True

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
            End If
        Catch ex As Exception
        End Try

    End Sub



#End Region

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        If txtLoanNo.Text <> "CHL" Then
            Dim objfrmLaonSuretyDet As New frmLoanSuretyDetails
            objfrmLaonSuretyDet.txtLoanNo.Text = txtLoanNo.Text
            objfrmLaonSuretyDet.txtLoanerName.Text = txtName.Text
            objfrmLaonSuretyDet.ShowDialog(Me)
            objfrmLaonSuretyDet.Dispose()
            fnLoadFAssets()
            fnLoadMAssets()

        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If
    End Sub

    Private Sub txtSanctionedAmount_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSanctionedAmount.Leave
        If txtSanctionedAmount.Text = "" Then
            MsgBox("Enter sanctioned amount to load rate of intrest", MsgBoxStyle.Exclamation)
        Else
            fnGetROI()
        End If

    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objSBSearch As New frmSBAccSearch
        objSBSearch.strSBAccountNo = ""
        objSBSearch.ShowDialog(Me)
        If objSBSearch.strSBAccountNo <> "" Then
            sbClear()
            txtSBNo.Text = objSBSearch.strSBAccountNo
            sbGeneral()
            objSBSearch.Dispose()
        End If
    End Sub

    Private Sub txtNOI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOI.TextChanged
        Dim TempDate As Date = DateAdd(DateInterval.Month, Val(txtNOI.Text), dtpDemandSancDate.Value)
        dtpDueDate.Value = DateAdd(DateInterval.Day, -1, TempDate)
    End Sub

    Private Sub NewButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click

        If cmbAccType.SelectedItem = "Joint" Then
            If Trim(txtLoanNo.Text) <> "CHL" Then
                Dim objfrmSurety As New frmHomeLoanSurety
                objfrmSurety.BackColor = GroupBox1.BackColor
                objfrmSurety.TabPage1.BackColor = GroupBox1.BackColor
                objfrmSurety.btnOk.GotFocusColour = btnAdd.GotFocusColour
                objfrmSurety.txtLoanNo.Text = txtLoanNo.Text
                objfrmSurety.txtLoanerName.Text = txtName.Text
                objfrmSurety.chrType = "J"
                objfrmSurety.ShowDialog(Me)
            Else
                MsgBox("Enter valid account number", MsgBoxStyle.Information, "LOan Module")
                txtLoanNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnSurety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurety.Click
        If txtLoanNo.Text <> "CHL" Then
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
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        If objclsRepyment.fnGetData(txtLoanNo.Text) Then
            If objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") > 0 Then
                Dim objfrmRepay As New frmLoanAdditionalCharges
                objfrmRepay.txtLoanNo.Text = txtLoanNo.Text
                objfrmRepay.txtName.Text = txtName.Text
                objfrmRepay.ShowDialog()
            Else
                MsgBox("Please disburse amount first", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
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

    Private Sub btnSBSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSearch.Click
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
        txtSBNo.Text = objAccountSelection.strAccountNo
        objAccountSelection.Dispose()
        Dim strType1 As String = Mid(objAccountSelection.strAccountNo, 1, 2)
      
        If (strType1 = "SB") Then
            Label35.Text = "SB No. :"
        Else
            Label35.Text = "CA No. :"

        End If

        objAccountSelection.Dispose()

    End Sub

    Private Sub tbOccupationDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbOccupationDetails.Click

    End Sub
End Class

