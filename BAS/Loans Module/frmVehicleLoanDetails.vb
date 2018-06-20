#Region "Import Statements"

Imports System.IO

#End Region

Public Class frmVehicleLoanDetails
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objVehAccount As New clsVehicleLoan
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim objclsRepyment As New clsRePayment
    Dim objSBAccount As New clsSavingsBank1
    Dim objSBAccount1 As New clsSavingsBank
    Dim objSurety As New clsHomeLoanSurety
    Dim OfficeNo As String
    Dim objPerson As New clsPerson

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
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tbGoldDetails As System.Windows.Forms.TabPage
    Friend WithEvents tbGoldLoanDetails As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbModeOfPayment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInstallmentType As System.Windows.Forms.ComboBox
    Friend WithEvents txtExpectedAmount As BankControls.NumericControl
    Friend WithEvents txtSanctionedAmount As BankControls.NumericControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeName As BankControls.TextControl
    Friend WithEvents txtDesignation As BankControls.TextControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtService As BankControls.NumericControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtLicenceNo As BankControls.TextControl
    Friend WithEvents txtArea As BankControls.TextControl
    Friend WithEvents txtVehAddr As BankControls.TextControl
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents pnlBorrower As System.Windows.Forms.Panel
    Friend WithEvents txtBtotalIncome As BankControls.NumericControl
    Friend WithEvents txtBotherIncome As BankControls.NumericControl
    Friend WithEvents txtBRent As BankControls.NumericControl
    Friend WithEvents txtBIncome As BankControls.NumericControl
    Friend WithEvents txtSTotalIncome As BankControls.NumericControl
    Friend WithEvents txtSOtherIncome As BankControls.NumericControl
    Friend WithEvents txtSRent As BankControls.NumericControl
    Friend WithEvents txtSSalary As BankControls.NumericControl
    Friend WithEvents chkSalary As System.Windows.Forms.CheckBox
    Friend WithEvents txtOtherParticular As BankControls.TextControl
    Friend WithEvents txtMortage As BankControls.TextControl
    Friend WithEvents txtImmovable As BankControls.TextControl
    Friend WithEvents pnlBusiness As System.Windows.Forms.Panel
    Friend WithEvents pnlSalary As System.Windows.Forms.Panel
    Friend WithEvents txtSBNo As BankControls.TextControl
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents dtpValidity As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNOI As BankControls.NumericControl
    Friend WithEvents txtRelationship As BankControls.TextControl
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents chkBusiness As System.Windows.Forms.CheckBox
    Friend WithEvents pnlAsSurety As System.Windows.Forms.Panel
    Friend WithEvents chkSurety As System.Windows.Forms.CheckBox
    Friend WithEvents chkBorrower As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoadPic As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnClose2 As BankControls.NewButton
    Friend WithEvents btnSignature As BankControls.NewButton
    Friend WithEvents btnCalc As BankControls.NewButton
    Friend WithEvents btnSurety As BankControls.NewButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSTotalExpenses As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBTotalExpenses As BankControls.NumericControl
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtBTotalSavings As BankControls.NumericControl
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtSTotalSavings As BankControls.NumericControl
    Friend WithEvents txtOrgResp As BankControls.TextControl
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtPersonResp As BankControls.TextControl
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtBankResp As BankControls.TextControl
    Friend WithEvents txtLoanAmount As BankControls.NumericControl
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtLoanType As BankControls.TextControl
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents dtpVehicleLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbGoldDetails1 As System.Windows.Forms.TabPage
    Friend WithEvents dtpPValidity As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPermit As BankControls.TextControl
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDealerName As BankControls.TextControl
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtOtherVehicle As BankControls.TextControl
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtVehicleName As BankControls.TextControl
    Friend WithEvents txtCost As BankControls.NumericControl
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txtModeofUse As BankControls.TextControl
    Friend WithEvents dtpPDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPMarketPrice As BankControls.NumericControl
    Friend WithEvents txtTax As BankControls.NumericControl
    Friend WithEvents txtNetAmtPayable As BankControls.NumericControl
    Friend WithEvents txtExpTB As BankControls.TextControl
    Friend WithEvents txtLoanToRepay As BankControls.TextControl
    Friend WithEvents txtBBuildingCost As BankControls.NumericControl
    Friend WithEvents txtAdditionalFittingCost As BankControls.NumericControl
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents txtReason As BankControls.TextControl
    Friend WithEvents tbSecDetail As System.Windows.Forms.TabPage
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents txtEngineNo As BankControls.TextControl
    Friend WithEvents txtRegistrationNo As BankControls.TextControl
    Friend WithEvents txtChaseNo As BankControls.TextControl
    Friend WithEvents txtFC As BankControls.TextControl
    Friend WithEvents txtRoadTax As BankControls.NumericControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rdbOld As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNew As System.Windows.Forms.RadioButton
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents dtpDemandSancDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkGTreeProduced As System.Windows.Forms.CheckBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtIncomeTax As BankControls.TextControl
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDirRelation As BankControls.TextControl
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txtDirName As BankControls.TextControl
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As BankControls.NumericControl
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkDeselectAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents lvDocuments As System.Windows.Forms.ListView
    Friend WithEvents clChkDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSlNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDocuments As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lvSuretyDetail As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents txtSanctionedNo As BankControls.TextControl
    Friend WithEvents txtInstAmount As BankControls.NumericControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicleLoanDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.txtMobileNo2 = New BankControls.NumericControl
        Me.Label104 = New System.Windows.Forms.Label
        Me.chkGTreeProduced = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NewButton1 = New BankControls.NewButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSBNo = New BankControls.TextControl
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtService = New BankControls.NumericControl
        Me.txtDesignation = New BankControls.TextControl
        Me.txtOfficeName = New BankControls.TextControl
        Me.Label39 = New System.Windows.Forms.Label
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
        Me.tbGoldDetails = New System.Windows.Forms.TabPage
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtIncomeTax = New BankControls.TextControl
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.pnlBusiness = New System.Windows.Forms.Panel
        Me.txtBTotalSavings = New BankControls.NumericControl
        Me.Label68 = New System.Windows.Forms.Label
        Me.txtBTotalExpenses = New BankControls.NumericControl
        Me.Label67 = New System.Windows.Forms.Label
        Me.txtBtotalIncome = New BankControls.NumericControl
        Me.txtBotherIncome = New BankControls.NumericControl
        Me.txtBRent = New BankControls.NumericControl
        Me.txtBIncome = New BankControls.NumericControl
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.chkBusiness = New System.Windows.Forms.CheckBox
        Me.pnlSalary = New System.Windows.Forms.Panel
        Me.txtSTotalSavings = New BankControls.NumericControl
        Me.Label69 = New System.Windows.Forms.Label
        Me.txtSTotalExpenses = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSTotalIncome = New BankControls.NumericControl
        Me.txtSOtherIncome = New BankControls.NumericControl
        Me.txtSRent = New BankControls.NumericControl
        Me.txtSSalary = New BankControls.NumericControl
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.chkSalary = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.txtModeofUse = New BankControls.TextControl
        Me.Label76 = New System.Windows.Forms.Label
        Me.dtpPValidity = New System.Windows.Forms.DateTimePicker
        Me.txtPermit = New BankControls.TextControl
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.dtpValidity = New System.Windows.Forms.DateTimePicker
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtVehAddr = New BankControls.TextControl
        Me.txtArea = New BankControls.TextControl
        Me.txtLicenceNo = New BankControls.TextControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.tbGoldDetails1 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.rdbOld = New System.Windows.Forms.RadioButton
        Me.rdbNew = New System.Windows.Forms.RadioButton
        Me.Label85 = New System.Windows.Forms.Label
        Me.txtLoanToRepay = New BankControls.TextControl
        Me.Label84 = New System.Windows.Forms.Label
        Me.txtExpTB = New BankControls.TextControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label79 = New System.Windows.Forms.Label
        Me.txtPMarketPrice = New BankControls.NumericControl
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.dtpPDate = New System.Windows.Forms.DateTimePicker
        Me.txtVehicleName = New BankControls.TextControl
        Me.txtCost = New BankControls.NumericControl
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.txtNetAmtPayable = New BankControls.NumericControl
        Me.Label82 = New System.Windows.Forms.Label
        Me.txtBBuildingCost = New BankControls.NumericControl
        Me.Label80 = New System.Windows.Forms.Label
        Me.txtAdditionalFittingCost = New BankControls.NumericControl
        Me.Label81 = New System.Windows.Forms.Label
        Me.txtTax = New BankControls.NumericControl
        Me.txtDealerName = New BankControls.TextControl
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtOtherVehicle = New BankControls.TextControl
        Me.tbGoldLoanDetails = New System.Windows.Forms.TabPage
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.txtInstAmount = New BankControls.NumericControl
        Me.txtSanctionedNo = New BankControls.TextControl
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label105 = New System.Windows.Forms.Label
        Me.dtpDemandSancDate = New System.Windows.Forms.DateTimePicker
        Me.Label106 = New System.Windows.Forms.Label
        Me.txtReason = New BankControls.TextControl
        Me.Label94 = New System.Windows.Forms.Label
        Me.dtpVehicleLoanDate = New System.Windows.Forms.DateTimePicker
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.txtNOI = New BankControls.NumericControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnLoadPic = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.btnClose2 = New BankControls.NewButton
        Me.btnSignature = New BankControls.NewButton
        Me.cmbModeOfPayment = New System.Windows.Forms.ComboBox
        Me.cmbInstallmentType = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtExpectedAmount = New BankControls.NumericControl
        Me.txtSanctionedAmount = New BankControls.NumericControl
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.tbSecDetail = New System.Windows.Forms.TabPage
        Me.Label20 = New System.Windows.Forms.Label
        Me.lvSuretyDetail = New System.Windows.Forms.ListView
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtDirRelation = New BankControls.TextControl
        Me.Label73 = New System.Windows.Forms.Label
        Me.txtDirName = New BankControls.TextControl
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.txtRoadTax = New BankControls.NumericControl
        Me.Label89 = New System.Windows.Forms.Label
        Me.txtFC = New BankControls.TextControl
        Me.Label88 = New System.Windows.Forms.Label
        Me.txtChaseNo = New BankControls.TextControl
        Me.Label87 = New System.Windows.Forms.Label
        Me.txtEngineNo = New BankControls.TextControl
        Me.Label86 = New System.Windows.Forms.Label
        Me.txtRegistrationNo = New BankControls.TextControl
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.txtRemarks = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtRelationship = New BankControls.TextControl
        Me.Label64 = New System.Windows.Forms.Label
        Me.txtOtherParticular = New BankControls.TextControl
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtMortage = New BankControls.TextControl
        Me.Label59 = New System.Windows.Forms.Label
        Me.txtImmovable = New BankControls.TextControl
        Me.Label58 = New System.Windows.Forms.Label
        Me.pnlAsSurety = New System.Windows.Forms.Panel
        Me.txtLoanAmount = New BankControls.NumericControl
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtBankName = New BankControls.TextControl
        Me.Label57 = New System.Windows.Forms.Label
        Me.txtLoanType = New BankControls.TextControl
        Me.Label71 = New System.Windows.Forms.Label
        Me.chkSurety = New System.Windows.Forms.CheckBox
        Me.pnlBorrower = New System.Windows.Forms.Panel
        Me.txtOrgResp = New BankControls.TextControl
        Me.Label53 = New System.Windows.Forms.Label
        Me.txtPersonResp = New BankControls.TextControl
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.txtBankResp = New BankControls.TextControl
        Me.chkBorrower = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkDeselectAll = New System.Windows.Forms.CheckBox
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.Label93 = New System.Windows.Forms.Label
        Me.lvDocuments = New System.Windows.Forms.ListView
        Me.clChkDoc = New System.Windows.Forms.ColumnHeader
        Me.clSlNo = New System.Windows.Forms.ColumnHeader
        Me.clDocuments = New System.Windows.Forms.ColumnHeader
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnWithdraw = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton3 = New BankControls.NewButton
        Me.btnSurety = New BankControls.NewButton
        Me.btnCalc = New BankControls.NewButton
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
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbGoldDetails.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlBusiness.SuspendLayout()
        Me.pnlSalary.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbGoldDetails1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tbGoldLoanDetails.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSecDetail.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.pnlAsSurety.SuspendLayout()
        Me.pnlBorrower.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.tbGoldDetails)
        Me.TabControl1.Controls.Add(Me.tbGoldDetails1)
        Me.TabControl1.Controls.Add(Me.tbGoldLoanDetails)
        Me.TabControl1.Controls.Add(Me.tbSecDetail)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(16, 88)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 480)
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.TabStop = False
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.cmbAccType)
        Me.tbPersonal.Controls.Add(Me.Label92)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo2)
        Me.tbPersonal.Controls.Add(Me.Label104)
        Me.tbPersonal.Controls.Add(Me.chkGTreeProduced)
        Me.tbPersonal.Controls.Add(Me.Label12)
        Me.tbPersonal.Controls.Add(Me.NewButton1)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.txtSBNo)
        Me.tbPersonal.Controls.Add(Me.Label63)
        Me.tbPersonal.Controls.Add(Me.Label40)
        Me.tbPersonal.Controls.Add(Me.txtService)
        Me.tbPersonal.Controls.Add(Me.txtDesignation)
        Me.tbPersonal.Controls.Add(Me.txtOfficeName)
        Me.tbPersonal.Controls.Add(Me.Label39)
        Me.tbPersonal.Controls.Add(Me.Label38)
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
        Me.tbPersonal.Size = New System.Drawing.Size(736, 451)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(336, 16)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Customer No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(176, 16)
        Me.txtCustomerID.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(136, 23)
        Me.txtCustomerID.SpecialChar = False
        Me.txtCustomerID.TabIndex = 4
        Me.txtCustomerID.Text = "CID"
        '
        'cmbAccType
        '
        Me.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(528, 312)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(136, 24)
        Me.cmbAccType.TabIndex = 28
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(384, 320)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(93, 16)
        Me.Label92.TabIndex = 125
        Me.Label92.Text = "Loan Type : "
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.AfterDecimal = 0
        Me.txtMobileNo2.BeforeDecimal = 10
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo2.Location = New System.Drawing.Point(528, 280)
        Me.txtMobileNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo2.MaxLength = 10
        Me.txtMobileNo2.MaxValue = 0
        Me.txtMobileNo2.MinValue = 0
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo2.TabIndex = 27
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(384, 280)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(90, 16)
        Me.Label104.TabIndex = 121
        Me.Label104.Text = "Mobile No2 :"
        '
        'chkGTreeProduced
        '
        Me.chkGTreeProduced.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGTreeProduced.Location = New System.Drawing.Point(528, 344)
        Me.chkGTreeProduced.Name = "chkGTreeProduced"
        Me.chkGTreeProduced.Size = New System.Drawing.Size(144, 24)
        Me.chkGTreeProduced.TabIndex = 29
        Me.chkGTreeProduced.Text = "GTree Produced"
        Me.chkGTreeProduced.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(384, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 48)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Occupational / Office Address :"
        '
        'NewButton1
        '
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.Location = New System.Drawing.Point(336, 48)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(24, 24)
        Me.NewButton1.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 16)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Husband Name : "
        '
        'txtSBNo
        '
        Me.txtSBNo.AlphaNumeric = True
        Me.txtSBNo.BlankSpace = True
        Me.txtSBNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBNo.Location = New System.Drawing.Point(176, 48)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.ReadOnly = True
        Me.txtSBNo.Size = New System.Drawing.Size(144, 23)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 6
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(16, 48)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(87, 16)
        Me.Label63.TabIndex = 74
        Me.Label63.Text = "SB/CA No. :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(384, 112)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(141, 16)
        Me.Label40.TabIndex = 72
        Me.Label40.Text = "Length of  Service :"
        '
        'txtService
        '
        Me.txtService.AfterDecimal = 0
        Me.txtService.BeforeDecimal = 2
        Me.txtService.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtService.Location = New System.Drawing.Point(528, 112)
        Me.txtService.LostFocusColour = System.Drawing.Color.Empty
        Me.txtService.MaxLength = 3
        Me.txtService.MaxValue = 100
        Me.txtService.MinValue = 0
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(80, 23)
        Me.txtService.TabIndex = 23
        '
        'txtDesignation
        '
        Me.txtDesignation.AlphaNumeric = True
        Me.txtDesignation.BlankSpace = False
        Me.txtDesignation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDesignation.Location = New System.Drawing.Point(528, 80)
        Me.txtDesignation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDesignation.Mandatory = False
        Me.txtDesignation.MaxLength = 30
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(184, 23)
        Me.txtDesignation.SpecialChar = True
        Me.txtDesignation.TabIndex = 22
        '
        'txtOfficeName
        '
        Me.txtOfficeName.AlphaNumeric = True
        Me.txtOfficeName.BlankSpace = True
        Me.txtOfficeName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeName.Location = New System.Drawing.Point(528, 48)
        Me.txtOfficeName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeName.Mandatory = False
        Me.txtOfficeName.MaxLength = 30
        Me.txtOfficeName.Name = "txtOfficeName"
        Me.txtOfficeName.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeName.SpecialChar = True
        Me.txtOfficeName.TabIndex = 21
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(384, 80)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(95, 16)
        Me.Label39.TabIndex = 67
        Me.Label39.Text = "Designation :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(384, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(99, 16)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Office Name :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(176, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 32)
        Me.Panel2.TabIndex = 14
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 8)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 16)
        Me.rdbMale.TabIndex = 15
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 8)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 16)
        Me.rdbFemale.TabIndex = 16
        Me.rdbFemale.Text = "Female"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbMajor)
        Me.Panel3.Controls.Add(Me.rdbMinor)
        Me.Panel3.Enabled = False
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(176, 176)
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
        Me.Label16.Location = New System.Drawing.Point(16, 184)
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
        Me.txtFatherName.Location = New System.Drawing.Point(176, 80)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(184, 24)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 8
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(176, 288)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(184, 24)
        Me.cmbCaste.TabIndex = 18
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(176, 256)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(184, 24)
        Me.cmbReligion.TabIndex = 17
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd -  MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(176, 112)
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
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father /  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
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
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Residential Address :"
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(528, 16)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(384, 216)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(384, 248)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 16)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No1 :"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(176, 144)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(80, 23)
        Me.txtAge.TabIndex = 10
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(528, 144)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 24
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(528, 216)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.TabIndex = 25
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(528, 248)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.TabIndex = 26
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(176, 328)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 19
        '
        'tbGoldDetails
        '
        Me.tbGoldDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tbGoldDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbGoldDetails.Controls.Add(Me.Label70)
        Me.tbGoldDetails.Controls.Add(Me.txtIncomeTax)
        Me.tbGoldDetails.Controls.Add(Me.Label52)
        Me.tbGoldDetails.Controls.Add(Me.GroupBox4)
        Me.tbGoldDetails.Controls.Add(Me.GroupBox3)
        Me.tbGoldDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldDetails.Name = "tbGoldDetails"
        Me.tbGoldDetails.Size = New System.Drawing.Size(736, 451)
        Me.tbGoldDetails.TabIndex = 3
        Me.tbGoldDetails.Text = "Personal Details"
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(392, 48)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(112, 16)
        Me.Label70.TabIndex = 63
        Me.Label70.Text = "SalesTax Details"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIncomeTax
        '
        Me.txtIncomeTax.AlphaNumeric = True
        Me.txtIncomeTax.BlankSpace = True
        Me.txtIncomeTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncomeTax.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIncomeTax.Location = New System.Drawing.Point(528, 32)
        Me.txtIncomeTax.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIncomeTax.Mandatory = False
        Me.txtIncomeTax.MaxLength = 100
        Me.txtIncomeTax.Multiline = True
        Me.txtIncomeTax.Name = "txtIncomeTax"
        Me.txtIncomeTax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIncomeTax.Size = New System.Drawing.Size(192, 56)
        Me.txtIncomeTax.SpecialChar = True
        Me.txtIncomeTax.TabIndex = 18
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(376, 32)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(136, 16)
        Me.Label52.TabIndex = 62
        Me.Label52.Text = "IncomeTax /"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pnlBusiness)
        Me.GroupBox4.Controls.Add(Me.chkBusiness)
        Me.GroupBox4.Controls.Add(Me.pnlSalary)
        Me.GroupBox4.Controls.Add(Me.chkSalary)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 432)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Salary Details"
        '
        'pnlBusiness
        '
        Me.pnlBusiness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBusiness.Controls.Add(Me.txtBTotalSavings)
        Me.pnlBusiness.Controls.Add(Me.Label68)
        Me.pnlBusiness.Controls.Add(Me.txtBTotalExpenses)
        Me.pnlBusiness.Controls.Add(Me.Label67)
        Me.pnlBusiness.Controls.Add(Me.txtBtotalIncome)
        Me.pnlBusiness.Controls.Add(Me.txtBotherIncome)
        Me.pnlBusiness.Controls.Add(Me.txtBRent)
        Me.pnlBusiness.Controls.Add(Me.txtBIncome)
        Me.pnlBusiness.Controls.Add(Me.Label48)
        Me.pnlBusiness.Controls.Add(Me.Label49)
        Me.pnlBusiness.Controls.Add(Me.Label50)
        Me.pnlBusiness.Controls.Add(Me.Label51)
        Me.pnlBusiness.Location = New System.Drawing.Point(16, 256)
        Me.pnlBusiness.Name = "pnlBusiness"
        Me.pnlBusiness.Size = New System.Drawing.Size(328, 160)
        Me.pnlBusiness.TabIndex = 11
        '
        'txtBTotalSavings
        '
        Me.txtBTotalSavings.AfterDecimal = 0
        Me.txtBTotalSavings.BeforeDecimal = 8
        Me.txtBTotalSavings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTotalSavings.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBTotalSavings.Location = New System.Drawing.Point(176, 128)
        Me.txtBTotalSavings.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBTotalSavings.MaxLength = 10
        Me.txtBTotalSavings.MaxValue = 99999999
        Me.txtBTotalSavings.MinValue = 0
        Me.txtBTotalSavings.Name = "txtBTotalSavings"
        Me.txtBTotalSavings.ReadOnly = True
        Me.txtBTotalSavings.Size = New System.Drawing.Size(128, 23)
        Me.txtBTotalSavings.TabIndex = 17
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(32, 128)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(104, 16)
        Me.Label68.TabIndex = 44
        Me.Label68.Text = "Total Savings"
        '
        'txtBTotalExpenses
        '
        Me.txtBTotalExpenses.AfterDecimal = 0
        Me.txtBTotalExpenses.BeforeDecimal = 8
        Me.txtBTotalExpenses.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTotalExpenses.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBTotalExpenses.Location = New System.Drawing.Point(176, 104)
        Me.txtBTotalExpenses.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBTotalExpenses.MaxLength = 10
        Me.txtBTotalExpenses.MaxValue = 99999999
        Me.txtBTotalExpenses.MinValue = 0
        Me.txtBTotalExpenses.Name = "txtBTotalExpenses"
        Me.txtBTotalExpenses.Size = New System.Drawing.Size(128, 23)
        Me.txtBTotalExpenses.TabIndex = 16
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(32, 104)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(104, 16)
        Me.Label67.TabIndex = 42
        Me.Label67.Text = "Total Expenses"
        '
        'txtBtotalIncome
        '
        Me.txtBtotalIncome.AfterDecimal = 0
        Me.txtBtotalIncome.BeforeDecimal = 8
        Me.txtBtotalIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtotalIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBtotalIncome.Location = New System.Drawing.Point(176, 80)
        Me.txtBtotalIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBtotalIncome.MaxLength = 10
        Me.txtBtotalIncome.MaxValue = 999999999
        Me.txtBtotalIncome.MinValue = 0
        Me.txtBtotalIncome.Name = "txtBtotalIncome"
        Me.txtBtotalIncome.ReadOnly = True
        Me.txtBtotalIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtBtotalIncome.TabIndex = 15
        '
        'txtBotherIncome
        '
        Me.txtBotherIncome.AfterDecimal = 0
        Me.txtBotherIncome.BeforeDecimal = 8
        Me.txtBotherIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotherIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBotherIncome.Location = New System.Drawing.Point(176, 56)
        Me.txtBotherIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBotherIncome.MaxLength = 10
        Me.txtBotherIncome.MaxValue = 999999999
        Me.txtBotherIncome.MinValue = 0
        Me.txtBotherIncome.Name = "txtBotherIncome"
        Me.txtBotherIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtBotherIncome.TabIndex = 14
        '
        'txtBRent
        '
        Me.txtBRent.AfterDecimal = 0
        Me.txtBRent.BeforeDecimal = 8
        Me.txtBRent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRent.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBRent.Location = New System.Drawing.Point(176, 32)
        Me.txtBRent.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBRent.MaxLength = 10
        Me.txtBRent.MaxValue = 999999999
        Me.txtBRent.MinValue = 0
        Me.txtBRent.Name = "txtBRent"
        Me.txtBRent.Size = New System.Drawing.Size(128, 23)
        Me.txtBRent.TabIndex = 13
        '
        'txtBIncome
        '
        Me.txtBIncome.AfterDecimal = 0
        Me.txtBIncome.BeforeDecimal = 8
        Me.txtBIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBIncome.Location = New System.Drawing.Point(176, 8)
        Me.txtBIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBIncome.MaxLength = 10
        Me.txtBIncome.MaxValue = 999999999
        Me.txtBIncome.MinValue = 0
        Me.txtBIncome.Name = "txtBIncome"
        Me.txtBIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtBIncome.TabIndex = 12
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(32, 80)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(104, 16)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "Total Income"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(32, 8)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(120, 16)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Monthly Income"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(32, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 16)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Rent"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(32, 56)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 16)
        Me.Label51.TabIndex = 1
        Me.Label51.Text = "Other Income"
        '
        'chkBusiness
        '
        Me.chkBusiness.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBusiness.Location = New System.Drawing.Point(16, 224)
        Me.chkBusiness.Name = "chkBusiness"
        Me.chkBusiness.Size = New System.Drawing.Size(136, 24)
        Me.chkBusiness.TabIndex = 10
        Me.chkBusiness.Text = "Business Person"
        '
        'pnlSalary
        '
        Me.pnlSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalary.Controls.Add(Me.txtSTotalSavings)
        Me.pnlSalary.Controls.Add(Me.Label69)
        Me.pnlSalary.Controls.Add(Me.txtSTotalExpenses)
        Me.pnlSalary.Controls.Add(Me.Label15)
        Me.pnlSalary.Controls.Add(Me.txtSTotalIncome)
        Me.pnlSalary.Controls.Add(Me.txtSOtherIncome)
        Me.pnlSalary.Controls.Add(Me.txtSRent)
        Me.pnlSalary.Controls.Add(Me.txtSSalary)
        Me.pnlSalary.Controls.Add(Me.Label47)
        Me.pnlSalary.Controls.Add(Me.Label44)
        Me.pnlSalary.Controls.Add(Me.Label45)
        Me.pnlSalary.Controls.Add(Me.Label46)
        Me.pnlSalary.Location = New System.Drawing.Point(18, 56)
        Me.pnlSalary.Name = "pnlSalary"
        Me.pnlSalary.Size = New System.Drawing.Size(326, 160)
        Me.pnlSalary.TabIndex = 3
        '
        'txtSTotalSavings
        '
        Me.txtSTotalSavings.AfterDecimal = 0
        Me.txtSTotalSavings.BeforeDecimal = 8
        Me.txtSTotalSavings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTotalSavings.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSTotalSavings.Location = New System.Drawing.Point(176, 128)
        Me.txtSTotalSavings.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSTotalSavings.MaxLength = 10
        Me.txtSTotalSavings.MaxValue = 99999999
        Me.txtSTotalSavings.MinValue = 0
        Me.txtSTotalSavings.Name = "txtSTotalSavings"
        Me.txtSTotalSavings.ReadOnly = True
        Me.txtSTotalSavings.Size = New System.Drawing.Size(128, 23)
        Me.txtSTotalSavings.TabIndex = 9
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(32, 128)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(104, 16)
        Me.Label69.TabIndex = 46
        Me.Label69.Text = "Total Savings"
        '
        'txtSTotalExpenses
        '
        Me.txtSTotalExpenses.AfterDecimal = 0
        Me.txtSTotalExpenses.BeforeDecimal = 8
        Me.txtSTotalExpenses.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTotalExpenses.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSTotalExpenses.Location = New System.Drawing.Point(176, 104)
        Me.txtSTotalExpenses.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSTotalExpenses.MaxLength = 10
        Me.txtSTotalExpenses.MaxValue = 99999999
        Me.txtSTotalExpenses.MinValue = 0
        Me.txtSTotalExpenses.Name = "txtSTotalExpenses"
        Me.txtSTotalExpenses.Size = New System.Drawing.Size(128, 23)
        Me.txtSTotalExpenses.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Total Expenses"
        '
        'txtSTotalIncome
        '
        Me.txtSTotalIncome.AfterDecimal = 0
        Me.txtSTotalIncome.BeforeDecimal = 8
        Me.txtSTotalIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTotalIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSTotalIncome.Location = New System.Drawing.Point(176, 80)
        Me.txtSTotalIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSTotalIncome.MaxLength = 10
        Me.txtSTotalIncome.MaxValue = 99999999
        Me.txtSTotalIncome.MinValue = 0
        Me.txtSTotalIncome.Name = "txtSTotalIncome"
        Me.txtSTotalIncome.ReadOnly = True
        Me.txtSTotalIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtSTotalIncome.TabIndex = 7
        '
        'txtSOtherIncome
        '
        Me.txtSOtherIncome.AfterDecimal = 0
        Me.txtSOtherIncome.BeforeDecimal = 8
        Me.txtSOtherIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOtherIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSOtherIncome.Location = New System.Drawing.Point(176, 56)
        Me.txtSOtherIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSOtherIncome.MaxLength = 10
        Me.txtSOtherIncome.MaxValue = 99999999
        Me.txtSOtherIncome.MinValue = 0
        Me.txtSOtherIncome.Name = "txtSOtherIncome"
        Me.txtSOtherIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtSOtherIncome.TabIndex = 6
        '
        'txtSRent
        '
        Me.txtSRent.AfterDecimal = 0
        Me.txtSRent.BeforeDecimal = 8
        Me.txtSRent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRent.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSRent.Location = New System.Drawing.Point(176, 32)
        Me.txtSRent.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSRent.MaxLength = 10
        Me.txtSRent.MaxValue = 99999999
        Me.txtSRent.MinValue = 0
        Me.txtSRent.Name = "txtSRent"
        Me.txtSRent.Size = New System.Drawing.Size(128, 23)
        Me.txtSRent.TabIndex = 5
        '
        'txtSSalary
        '
        Me.txtSSalary.AfterDecimal = 0
        Me.txtSSalary.BeforeDecimal = 8
        Me.txtSSalary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSalary.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSSalary.Location = New System.Drawing.Point(176, 8)
        Me.txtSSalary.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSSalary.MaxLength = 10
        Me.txtSSalary.MaxValue = 99999999
        Me.txtSSalary.MinValue = 0
        Me.txtSSalary.Name = "txtSSalary"
        Me.txtSSalary.Size = New System.Drawing.Size(128, 23)
        Me.txtSSalary.TabIndex = 4
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(32, 80)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(104, 16)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Total Income"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(32, 8)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Salary"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(32, 32)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 16)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Rent"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(32, 56)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(104, 16)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "Other Income"
        '
        'chkSalary
        '
        Me.chkSalary.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalary.Location = New System.Drawing.Point(24, 24)
        Me.chkSalary.Name = "chkSalary"
        Me.chkSalary.Size = New System.Drawing.Size(136, 24)
        Me.chkSalary.TabIndex = 2
        Me.chkSalary.Text = "Salaried Person"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label77)
        Me.GroupBox3.Controls.Add(Me.txtModeofUse)
        Me.GroupBox3.Controls.Add(Me.Label76)
        Me.GroupBox3.Controls.Add(Me.dtpPValidity)
        Me.GroupBox3.Controls.Add(Me.txtPermit)
        Me.GroupBox3.Controls.Add(Me.Label74)
        Me.GroupBox3.Controls.Add(Me.Label75)
        Me.GroupBox3.Controls.Add(Me.dtpValidity)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.txtVehAddr)
        Me.GroupBox3.Controls.Add(Me.txtArea)
        Me.GroupBox3.Controls.Add(Me.txtLicenceNo)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(392, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 336)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vehicle Details"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(16, 208)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(120, 16)
        Me.Label77.TabIndex = 34
        Me.Label77.Text = "own Use or for hire"
        '
        'txtModeofUse
        '
        Me.txtModeofUse.AlphaNumeric = True
        Me.txtModeofUse.BlankSpace = True
        Me.txtModeofUse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeofUse.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtModeofUse.Location = New System.Drawing.Point(168, 200)
        Me.txtModeofUse.LostFocusColour = System.Drawing.Color.Empty
        Me.txtModeofUse.Mandatory = False
        Me.txtModeofUse.MaxLength = 30
        Me.txtModeofUse.Name = "txtModeofUse"
        Me.txtModeofUse.Size = New System.Drawing.Size(136, 23)
        Me.txtModeofUse.SpecialChar = True
        Me.txtModeofUse.TabIndex = 25
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(8, 192)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(136, 16)
        Me.Label76.TabIndex = 32
        Me.Label76.Text = "Whether Vehicle Is For"
        '
        'dtpPValidity
        '
        Me.dtpPValidity.CustomFormat = "dd - MMM - yyyy"
        Me.dtpPValidity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPValidity.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPValidity.Location = New System.Drawing.Point(168, 160)
        Me.dtpPValidity.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpPValidity.Name = "dtpPValidity"
        Me.dtpPValidity.Size = New System.Drawing.Size(136, 23)
        Me.dtpPValidity.TabIndex = 24
        Me.dtpPValidity.Value = New Date(2007, 4, 12, 0, 0, 0, 0)
        '
        'txtPermit
        '
        Me.txtPermit.AlphaNumeric = True
        Me.txtPermit.BlankSpace = True
        Me.txtPermit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermit.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermit.Location = New System.Drawing.Point(168, 128)
        Me.txtPermit.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermit.Mandatory = False
        Me.txtPermit.MaxLength = 15
        Me.txtPermit.Name = "txtPermit"
        Me.txtPermit.Size = New System.Drawing.Size(136, 23)
        Me.txtPermit.SpecialChar = True
        Me.txtPermit.TabIndex = 23
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(16, 128)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(80, 16)
        Me.Label74.TabIndex = 28
        Me.Label74.Text = "Permit No"
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(16, 160)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(80, 16)
        Me.Label75.TabIndex = 29
        Me.Label75.Text = "Validity"
        '
        'dtpValidity
        '
        Me.dtpValidity.CustomFormat = "dd - MMM - yyyy"
        Me.dtpValidity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpValidity.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpValidity.Location = New System.Drawing.Point(168, 64)
        Me.dtpValidity.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpValidity.Name = "dtpValidity"
        Me.dtpValidity.Size = New System.Drawing.Size(136, 23)
        Me.dtpValidity.TabIndex = 21
        Me.dtpValidity.Value = New Date(2007, 4, 12, 0, 0, 0, 0)
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"LMV", "HMV"})
        Me.cmbType.Location = New System.Drawing.Point(168, 96)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(136, 24)
        Me.cmbType.TabIndex = 22
        '
        'txtVehAddr
        '
        Me.txtVehAddr.AlphaNumeric = True
        Me.txtVehAddr.BlankSpace = True
        Me.txtVehAddr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehAddr.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtVehAddr.Location = New System.Drawing.Point(168, 272)
        Me.txtVehAddr.LostFocusColour = System.Drawing.Color.Empty
        Me.txtVehAddr.Mandatory = False
        Me.txtVehAddr.MaxLength = 100
        Me.txtVehAddr.Multiline = True
        Me.txtVehAddr.Name = "txtVehAddr"
        Me.txtVehAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVehAddr.Size = New System.Drawing.Size(136, 48)
        Me.txtVehAddr.SpecialChar = True
        Me.txtVehAddr.TabIndex = 27
        '
        'txtArea
        '
        Me.txtArea.AlphaNumeric = True
        Me.txtArea.BlankSpace = False
        Me.txtArea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtArea.Location = New System.Drawing.Point(168, 240)
        Me.txtArea.LostFocusColour = System.Drawing.Color.Empty
        Me.txtArea.Mandatory = False
        Me.txtArea.MaxLength = 30
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(136, 23)
        Me.txtArea.SpecialChar = True
        Me.txtArea.TabIndex = 26
        '
        'txtLicenceNo
        '
        Me.txtLicenceNo.AlphaNumeric = True
        Me.txtLicenceNo.BlankSpace = True
        Me.txtLicenceNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLicenceNo.Location = New System.Drawing.Point(168, 32)
        Me.txtLicenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLicenceNo.Mandatory = False
        Me.txtLicenceNo.MaxLength = 15
        Me.txtLicenceNo.Name = "txtLicenceNo"
        Me.txtLicenceNo.Size = New System.Drawing.Size(136, 23)
        Me.txtLicenceNo.SpecialChar = True
        Me.txtLicenceNo.TabIndex = 20
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Licence No"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 16)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Validity"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 248)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 16)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Area Of Operaion"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 280)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 16)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Parked Address"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(16, 96)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(112, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Vehicle Type "
        '
        'tbGoldDetails1
        '
        Me.tbGoldDetails1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tbGoldDetails1.Controls.Add(Me.GroupBox7)
        Me.tbGoldDetails1.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldDetails1.Name = "tbGoldDetails1"
        Me.tbGoldDetails1.Size = New System.Drawing.Size(736, 451)
        Me.tbGoldDetails1.TabIndex = 5
        Me.tbGoldDetails1.Text = "VDetails"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Panel4)
        Me.GroupBox7.Controls.Add(Me.Label85)
        Me.GroupBox7.Controls.Add(Me.txtLoanToRepay)
        Me.GroupBox7.Controls.Add(Me.Label84)
        Me.GroupBox7.Controls.Add(Me.txtExpTB)
        Me.GroupBox7.Controls.Add(Me.Panel1)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.txtDealerName)
        Me.GroupBox7.Controls.Add(Me.Label42)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.txtOtherVehicle)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(712, 432)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Vehicle Details"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rdbOld)
        Me.Panel4.Controls.Add(Me.rdbNew)
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(16, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(248, 32)
        Me.Panel4.TabIndex = 2
        '
        'rdbOld
        '
        Me.rdbOld.Checked = True
        Me.rdbOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOld.Location = New System.Drawing.Point(8, 7)
        Me.rdbOld.Name = "rdbOld"
        Me.rdbOld.Size = New System.Drawing.Size(112, 24)
        Me.rdbOld.TabIndex = 3
        Me.rdbOld.TabStop = True
        Me.rdbOld.Text = "Old Vehicle"
        '
        'rdbNew
        '
        Me.rdbNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNew.Location = New System.Drawing.Point(128, 7)
        Me.rdbNew.Name = "rdbNew"
        Me.rdbNew.Size = New System.Drawing.Size(112, 24)
        Me.rdbNew.TabIndex = 4
        Me.rdbNew.Text = "New Vehicle"
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(352, 328)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(128, 48)
        Me.Label85.TabIndex = 55
        Me.Label85.Text = "Loan applied to repay the existing loan for purchase of vehicle"
        '
        'txtLoanToRepay
        '
        Me.txtLoanToRepay.AlphaNumeric = True
        Me.txtLoanToRepay.BlankSpace = True
        Me.txtLoanToRepay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanToRepay.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanToRepay.Location = New System.Drawing.Point(504, 320)
        Me.txtLoanToRepay.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLoanToRepay.Mandatory = False
        Me.txtLoanToRepay.MaxLength = 100
        Me.txtLoanToRepay.Multiline = True
        Me.txtLoanToRepay.Name = "txtLoanToRepay"
        Me.txtLoanToRepay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLoanToRepay.Size = New System.Drawing.Size(200, 72)
        Me.txtLoanToRepay.SpecialChar = True
        Me.txtLoanToRepay.TabIndex = 18
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(352, 224)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(128, 36)
        Me.Label84.TabIndex = 53
        Me.Label84.Text = "Exprience in Transport business"
        '
        'txtExpTB
        '
        Me.txtExpTB.AlphaNumeric = True
        Me.txtExpTB.BlankSpace = True
        Me.txtExpTB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpTB.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtExpTB.Location = New System.Drawing.Point(504, 224)
        Me.txtExpTB.LostFocusColour = System.Drawing.Color.Empty
        Me.txtExpTB.Mandatory = False
        Me.txtExpTB.MaxLength = 100
        Me.txtExpTB.Multiline = True
        Me.txtExpTB.Name = "txtExpTB"
        Me.txtExpTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExpTB.Size = New System.Drawing.Size(200, 80)
        Me.txtExpTB.SpecialChar = True
        Me.txtExpTB.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label79)
        Me.Panel1.Controls.Add(Me.txtPMarketPrice)
        Me.Panel1.Controls.Add(Me.Label78)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.dtpPDate)
        Me.Panel1.Controls.Add(Me.txtVehicleName)
        Me.Panel1.Controls.Add(Me.txtCost)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(16, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 168)
        Me.Panel1.TabIndex = 5
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label79.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(16, 133)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(140, 16)
        Me.Label79.TabIndex = 58
        Me.Label79.Text = "Present Market Price"
        '
        'txtPMarketPrice
        '
        Me.txtPMarketPrice.AfterDecimal = 0
        Me.txtPMarketPrice.BeforeDecimal = 8
        Me.txtPMarketPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPMarketPrice.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPMarketPrice.Location = New System.Drawing.Point(180, 133)
        Me.txtPMarketPrice.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPMarketPrice.MaxLength = 10
        Me.txtPMarketPrice.MaxValue = 99999999
        Me.txtPMarketPrice.MinValue = 0
        Me.txtPMarketPrice.Name = "txtPMarketPrice"
        Me.txtPMarketPrice.Size = New System.Drawing.Size(128, 23)
        Me.txtPMarketPrice.TabIndex = 9
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label78.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(16, 56)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(112, 16)
        Me.Label78.TabIndex = 56
        Me.Label78.Text = "Purchase Date"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(16, 96)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(136, 16)
        Me.Label41.TabIndex = 52
        Me.Label41.Text = "Purchase Amount"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(108, 16)
        Me.Label33.TabIndex = 53
        Me.Label33.Text = "Vehicle Name"
        '
        'dtpPDate
        '
        Me.dtpPDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpPDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPDate.Location = New System.Drawing.Point(180, 56)
        Me.dtpPDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpPDate.Name = "dtpPDate"
        Me.dtpPDate.Size = New System.Drawing.Size(140, 23)
        Me.dtpPDate.TabIndex = 7
        Me.dtpPDate.Value = New Date(2007, 4, 12, 0, 0, 0, 0)
        '
        'txtVehicleName
        '
        Me.txtVehicleName.AlphaNumeric = True
        Me.txtVehicleName.BlankSpace = True
        Me.txtVehicleName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtVehicleName.Location = New System.Drawing.Point(180, 24)
        Me.txtVehicleName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtVehicleName.Mandatory = False
        Me.txtVehicleName.MaxLength = 30
        Me.txtVehicleName.Name = "txtVehicleName"
        Me.txtVehicleName.Size = New System.Drawing.Size(128, 20)
        Me.txtVehicleName.SpecialChar = True
        Me.txtVehicleName.TabIndex = 6
        '
        'txtCost
        '
        Me.txtCost.AfterDecimal = 0
        Me.txtCost.BeforeDecimal = 8
        Me.txtCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCost.Location = New System.Drawing.Point(180, 96)
        Me.txtCost.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCost.MaxLength = 10
        Me.txtCost.MaxValue = 99999999
        Me.txtCost.MinValue = 0
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(128, 23)
        Me.txtCost.TabIndex = 8
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.Label83)
        Me.GroupBox8.Controls.Add(Me.txtNetAmtPayable)
        Me.GroupBox8.Controls.Add(Me.Label82)
        Me.GroupBox8.Controls.Add(Me.txtBBuildingCost)
        Me.GroupBox8.Controls.Add(Me.Label80)
        Me.GroupBox8.Controls.Add(Me.txtAdditionalFittingCost)
        Me.GroupBox8.Controls.Add(Me.Label81)
        Me.GroupBox8.Controls.Add(Me.txtTax)
        Me.GroupBox8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(16, 248)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(328, 176)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cost of vehicle as per invoice/Quotation"
        '
        'Label83
        '
        Me.Label83.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label83.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(14, 144)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(140, 16)
        Me.Label83.TabIndex = 66
        Me.Label83.Text = "Net amount Payable"
        '
        'txtNetAmtPayable
        '
        Me.txtNetAmtPayable.AfterDecimal = 0
        Me.txtNetAmtPayable.BeforeDecimal = 8
        Me.txtNetAmtPayable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmtPayable.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNetAmtPayable.Location = New System.Drawing.Point(178, 144)
        Me.txtNetAmtPayable.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNetAmtPayable.MaxLength = 10
        Me.txtNetAmtPayable.MaxValue = 99999999
        Me.txtNetAmtPayable.MinValue = 0
        Me.txtNetAmtPayable.Name = "txtNetAmtPayable"
        Me.txtNetAmtPayable.Size = New System.Drawing.Size(128, 23)
        Me.txtNetAmtPayable.TabIndex = 14
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label82.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(14, 104)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(140, 16)
        Me.Label82.TabIndex = 64
        Me.Label82.Text = "Cost of body building"
        '
        'txtBBuildingCost
        '
        Me.txtBBuildingCost.AfterDecimal = 0
        Me.txtBBuildingCost.BeforeDecimal = 8
        Me.txtBBuildingCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBBuildingCost.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBBuildingCost.Location = New System.Drawing.Point(178, 104)
        Me.txtBBuildingCost.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBBuildingCost.MaxLength = 10
        Me.txtBBuildingCost.MaxValue = 99999999
        Me.txtBBuildingCost.MinValue = 0
        Me.txtBBuildingCost.Name = "txtBBuildingCost"
        Me.txtBBuildingCost.Size = New System.Drawing.Size(128, 23)
        Me.txtBBuildingCost.TabIndex = 13
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label80.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(14, 72)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(146, 16)
        Me.Label80.TabIndex = 62
        Me.Label80.Text = "Cost of additional fittings"
        '
        'txtAdditionalFittingCost
        '
        Me.txtAdditionalFittingCost.AfterDecimal = 0
        Me.txtAdditionalFittingCost.BeforeDecimal = 8
        Me.txtAdditionalFittingCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditionalFittingCost.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAdditionalFittingCost.Location = New System.Drawing.Point(178, 72)
        Me.txtAdditionalFittingCost.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAdditionalFittingCost.MaxLength = 10
        Me.txtAdditionalFittingCost.MaxValue = 99999999
        Me.txtAdditionalFittingCost.MinValue = 0
        Me.txtAdditionalFittingCost.Name = "txtAdditionalFittingCost"
        Me.txtAdditionalFittingCost.Size = New System.Drawing.Size(128, 23)
        Me.txtAdditionalFittingCost.TabIndex = 12
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label81.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(14, 32)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(106, 16)
        Me.Label81.TabIndex = 60
        Me.Label81.Text = "Insurance,Taxes"
        '
        'txtTax
        '
        Me.txtTax.AfterDecimal = 0
        Me.txtTax.BeforeDecimal = 8
        Me.txtTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTax.Location = New System.Drawing.Point(178, 32)
        Me.txtTax.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTax.MaxLength = 10
        Me.txtTax.MaxValue = 99999999
        Me.txtTax.MinValue = 0
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(128, 23)
        Me.txtTax.TabIndex = 11
        '
        'txtDealerName
        '
        Me.txtDealerName.AlphaNumeric = True
        Me.txtDealerName.BlankSpace = True
        Me.txtDealerName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDealerName.Location = New System.Drawing.Point(504, 64)
        Me.txtDealerName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDealerName.Mandatory = False
        Me.txtDealerName.MaxLength = 100
        Me.txtDealerName.Multiline = True
        Me.txtDealerName.Name = "txtDealerName"
        Me.txtDealerName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDealerName.Size = New System.Drawing.Size(200, 64)
        Me.txtDealerName.SpecialChar = True
        Me.txtDealerName.TabIndex = 15
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(352, 72)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(128, 32)
        Me.Label42.TabIndex = 41
        Me.Label42.Text = "Name,Addr Of Dealer"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(352, 152)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(128, 32)
        Me.Label43.TabIndex = 42
        Me.Label43.Text = "Other Vehilcle Details"
        '
        'txtOtherVehicle
        '
        Me.txtOtherVehicle.AlphaNumeric = True
        Me.txtOtherVehicle.BlankSpace = True
        Me.txtOtherVehicle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherVehicle.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherVehicle.Location = New System.Drawing.Point(504, 144)
        Me.txtOtherVehicle.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherVehicle.Mandatory = False
        Me.txtOtherVehicle.MaxLength = 100
        Me.txtOtherVehicle.Multiline = True
        Me.txtOtherVehicle.Name = "txtOtherVehicle"
        Me.txtOtherVehicle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtherVehicle.Size = New System.Drawing.Size(200, 72)
        Me.txtOtherVehicle.SpecialChar = True
        Me.txtOtherVehicle.TabIndex = 16
        '
        'tbGoldLoanDetails
        '
        Me.tbGoldLoanDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tbGoldLoanDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtInstAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label66)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label105)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDemandSancDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label106)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReason)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label94)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpVehicleLoanDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label36)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label37)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDueDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtNOI)
        Me.tbGoldLoanDetails.Controls.Add(Me.Panel6)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbModeOfPayment)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbInstallmentType)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label34)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label19)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label11)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtExpectedAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label21)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtROI)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label22)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label23)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label18)
        Me.tbGoldLoanDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldLoanDetails.Name = "tbGoldLoanDetails"
        Me.tbGoldLoanDetails.Size = New System.Drawing.Size(736, 451)
        Me.tbGoldLoanDetails.TabIndex = 4
        Me.tbGoldLoanDetails.Text = "VLoanDetails"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(536, 208)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(168, 23)
        Me.txtReceiptNo.TabIndex = 13
        '
        'txtInstAmount
        '
        Me.txtInstAmount.AfterDecimal = 0
        Me.txtInstAmount.BackColor = System.Drawing.Color.White
        Me.txtInstAmount.BeforeDecimal = 8
        Me.txtInstAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInstAmount.Location = New System.Drawing.Point(536, 56)
        Me.txtInstAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInstAmount.MaxLength = 8
        Me.txtInstAmount.MaxValue = 0
        Me.txtInstAmount.MinValue = 0
        Me.txtInstAmount.Name = "txtInstAmount"
        Me.txtInstAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtInstAmount.TabIndex = 9
        '
        'txtSanctionedNo
        '
        Me.txtSanctionedNo.AlphaNumeric = True
        Me.txtSanctionedNo.BlankSpace = False
        Me.txtSanctionedNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanctionedNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSanctionedNo.Location = New System.Drawing.Point(184, 144)
        Me.txtSanctionedNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSanctionedNo.Mandatory = False
        Me.txtSanctionedNo.MaxLength = 30
        Me.txtSanctionedNo.Name = "txtSanctionedNo"
        Me.txtSanctionedNo.Size = New System.Drawing.Size(168, 24)
        Me.txtSanctionedNo.SpecialChar = True
        Me.txtSanctionedNo.TabIndex = 5
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(376, 208)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 16)
        Me.Label66.TabIndex = 147
        Me.Label66.Text = "Receipt No.  :"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(24, 144)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(120, 16)
        Me.Label105.TabIndex = 145
        Me.Label105.Text = "Sanctioned No. :"
        '
        'dtpDemandSancDate
        '
        Me.dtpDemandSancDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDemandSancDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDemandSancDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDemandSancDate.Location = New System.Drawing.Point(184, 112)
        Me.dtpDemandSancDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpDemandSancDate.Name = "dtpDemandSancDate"
        Me.dtpDemandSancDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpDemandSancDate.TabIndex = 4
        Me.dtpDemandSancDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label106.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(24, 112)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(129, 16)
        Me.Label106.TabIndex = 142
        Me.Label106.Text = "Sanctioned Date :"
        '
        'txtReason
        '
        Me.txtReason.AlphaNumeric = True
        Me.txtReason.BlankSpace = False
        Me.txtReason.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReason.Location = New System.Drawing.Point(536, 168)
        Me.txtReason.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReason.Mandatory = False
        Me.txtReason.MaxLength = 50
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(168, 24)
        Me.txtReason.SpecialChar = True
        Me.txtReason.TabIndex = 12
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label94.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(376, 56)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(139, 16)
        Me.Label94.TabIndex = 101
        Me.Label94.Text = "Instalment Amount:"
        '
        'dtpVehicleLoanDate
        '
        Me.dtpVehicleLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpVehicleLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVehicleLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVehicleLoanDate.Location = New System.Drawing.Point(184, 48)
        Me.dtpVehicleLoanDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpVehicleLoanDate.Name = "dtpVehicleLoanDate"
        Me.dtpVehicleLoanDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpVehicleLoanDate.TabIndex = 2
        Me.dtpVehicleLoanDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(376, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 16)
        Me.Label36.TabIndex = 74
        Me.Label36.Text = "DueDate"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(24, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(97, 16)
        Me.Label37.TabIndex = 73
        Me.Label37.Text = "Applied Date:"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(536, 16)
        Me.dtpDueDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpDueDate.TabIndex = 8
        Me.dtpDueDate.Value = New Date(2007, 4, 12, 0, 0, 0, 0)
        '
        'txtNOI
        '
        Me.txtNOI.AfterDecimal = 0
        Me.txtNOI.BackColor = System.Drawing.Color.White
        Me.txtNOI.BeforeDecimal = 3
        Me.txtNOI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOI.GotFocusColour = System.Drawing.Color.White
        Me.txtNOI.Location = New System.Drawing.Point(184, 208)
        Me.txtNOI.LostFocusColour = System.Drawing.Color.White
        Me.txtNOI.MaxLength = 10
        Me.txtNOI.MaxValue = 0
        Me.txtNOI.MinValue = 0
        Me.txtNOI.Name = "txtNOI"
        Me.txtNOI.Size = New System.Drawing.Size(72, 23)
        Me.txtNOI.TabIndex = 7
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
        Me.Panel6.Location = New System.Drawing.Point(16, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(688, 200)
        Me.Panel6.TabIndex = 14
        '
        'btnLoadPic
        '
        Me.btnLoadPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPic.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPic.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPic.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnLoadPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPic.Location = New System.Drawing.Point(104, 160)
        Me.btnLoadPic.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLoadPic.Name = "btnLoadPic"
        Me.btnLoadPic.Size = New System.Drawing.Size(72, 24)
        Me.btnLoadPic.TabIndex = 15
        Me.btnLoadPic.Text = "Load"
        Me.btnLoadPic.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(200, 160)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(432, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 136)
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
        Me.PictureBox3.Location = New System.Drawing.Point(104, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 136)
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
        Me.btnClose2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClose2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose2.ForeColor = System.Drawing.Color.Black
        Me.btnClose2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnClose2.Location = New System.Drawing.Point(528, 160)
        Me.btnClose2.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(64, 24)
        Me.btnClose2.TabIndex = 18
        Me.btnClose2.Text = "Cancel"
        Me.btnClose2.UseVisualStyleBackColor = False
        '
        'btnSignature
        '
        Me.btnSignature.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignature.ForeColor = System.Drawing.Color.Black
        Me.btnSignature.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSignature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignature.Location = New System.Drawing.Point(432, 160)
        Me.btnSignature.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(72, 24)
        Me.btnSignature.TabIndex = 17
        Me.btnSignature.Text = "Load"
        Me.btnSignature.UseVisualStyleBackColor = False
        '
        'cmbModeOfPayment
        '
        Me.cmbModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeOfPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeOfPayment.Items.AddRange(New Object() {"Cheque", "Cash", "DD"})
        Me.cmbModeOfPayment.Location = New System.Drawing.Point(536, 136)
        Me.cmbModeOfPayment.Name = "cmbModeOfPayment"
        Me.cmbModeOfPayment.Size = New System.Drawing.Size(168, 24)
        Me.cmbModeOfPayment.TabIndex = 11
        '
        'cmbInstallmentType
        '
        Me.cmbInstallmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstallmentType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInstallmentType.Items.AddRange(New Object() {"Monthly", "Quaterly", "Yearly"})
        Me.cmbInstallmentType.Location = New System.Drawing.Point(536, 96)
        Me.cmbInstallmentType.Name = "cmbInstallmentType"
        Me.cmbInstallmentType.Size = New System.Drawing.Size(168, 24)
        Me.cmbInstallmentType.TabIndex = 10
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(376, 176)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(125, 16)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Purpose of Loan :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 16)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Sanctioned Amount :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 16)
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
        Me.txtExpectedAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtExpectedAmount.TabIndex = 1
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
        Me.txtSanctionedAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtSanctionedAmount.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 16)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Rate Of Intrest :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 2
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.White
        Me.txtROI.Location = New System.Drawing.Point(184, 176)
        Me.txtROI.LostFocusColour = System.Drawing.Color.White
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(72, 23)
        Me.txtROI.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(376, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(127, 16)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Instalment Type :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(376, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 16)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Mode Of Payment :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 208)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 16)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "No Of Installments :"
        '
        'tbSecDetail
        '
        Me.tbSecDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tbSecDetail.Controls.Add(Me.Label20)
        Me.tbSecDetail.Controls.Add(Me.lvSuretyDetail)
        Me.tbSecDetail.Controls.Add(Me.GroupBox6)
        Me.tbSecDetail.Controls.Add(Me.Label91)
        Me.tbSecDetail.Controls.Add(Me.Label90)
        Me.tbSecDetail.Controls.Add(Me.txtRoadTax)
        Me.tbSecDetail.Controls.Add(Me.Label89)
        Me.tbSecDetail.Controls.Add(Me.txtFC)
        Me.tbSecDetail.Controls.Add(Me.Label88)
        Me.tbSecDetail.Controls.Add(Me.txtChaseNo)
        Me.tbSecDetail.Controls.Add(Me.Label87)
        Me.tbSecDetail.Controls.Add(Me.txtEngineNo)
        Me.tbSecDetail.Controls.Add(Me.Label86)
        Me.tbSecDetail.Controls.Add(Me.txtRegistrationNo)
        Me.tbSecDetail.Location = New System.Drawing.Point(4, 25)
        Me.tbSecDetail.Name = "tbSecDetail"
        Me.tbSecDetail.Size = New System.Drawing.Size(736, 451)
        Me.tbSecDetail.TabIndex = 6
        Me.tbSecDetail.Text = "SecuretyDetails"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 216)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 16)
        Me.Label20.TabIndex = 155
        Me.Label20.Text = "Surety Person Detail"
        '
        'lvSuretyDetail
        '
        Me.lvSuretyDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.lvSuretyDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSuretyDetail.FullRowSelect = True
        Me.lvSuretyDetail.GridLines = True
        Me.lvSuretyDetail.Location = New System.Drawing.Point(48, 240)
        Me.lvSuretyDetail.Name = "lvSuretyDetail"
        Me.lvSuretyDetail.Size = New System.Drawing.Size(640, 96)
        Me.lvSuretyDetail.TabIndex = 9
        Me.lvSuretyDetail.UseCompatibleStateImageBehavior = False
        Me.lvSuretyDetail.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "SlNo."
        Me.ColumnHeader18.Width = 42
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Name"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Address"
        Me.ColumnHeader20.Width = 322
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "PhoneNo."
        Me.ColumnHeader21.Width = 122
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtDirRelation)
        Me.GroupBox6.Controls.Add(Me.Label73)
        Me.GroupBox6.Controls.Add(Me.txtDirName)
        Me.GroupBox6.Controls.Add(Me.Label72)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Relationship to any of the sitting directors"
        '
        'txtDirRelation
        '
        Me.txtDirRelation.AlphaNumeric = True
        Me.txtDirRelation.BlankSpace = True
        Me.txtDirRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirRelation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDirRelation.Location = New System.Drawing.Point(496, 32)
        Me.txtDirRelation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDirRelation.Mandatory = False
        Me.txtDirRelation.MaxLength = 30
        Me.txtDirRelation.Name = "txtDirRelation"
        Me.txtDirRelation.Size = New System.Drawing.Size(200, 20)
        Me.txtDirRelation.SpecialChar = True
        Me.txtDirRelation.TabIndex = 3
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(328, 32)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(161, 16)
        Me.Label73.TabIndex = 6
        Me.Label73.Text = "Nature of relationship :"
        '
        'txtDirName
        '
        Me.txtDirName.AlphaNumeric = True
        Me.txtDirName.BlankSpace = True
        Me.txtDirName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDirName.Location = New System.Drawing.Point(144, 32)
        Me.txtDirName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDirName.Mandatory = False
        Me.txtDirName.MaxLength = 30
        Me.txtDirName.Name = "txtDirName"
        Me.txtDirName.Size = New System.Drawing.Size(184, 20)
        Me.txtDirName.SpecialChar = True
        Me.txtDirName.TabIndex = 2
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(16, 32)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(50, 16)
        Me.Label72.TabIndex = 4
        Me.Label72.Text = "Name:"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(16, 104)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(66, 16)
        Me.Label91.TabIndex = 76
        Me.Label91.Text = "Vehicle /"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(368, 152)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(80, 16)
        Me.Label90.TabIndex = 64
        Me.Label90.Text = "Road Tax :"
        '
        'txtRoadTax
        '
        Me.txtRoadTax.AfterDecimal = 2
        Me.txtRoadTax.BeforeDecimal = 7
        Me.txtRoadTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoadTax.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRoadTax.Location = New System.Drawing.Point(504, 152)
        Me.txtRoadTax.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRoadTax.MaxLength = 20
        Me.txtRoadTax.MaxValue = 0
        Me.txtRoadTax.MinValue = 0
        Me.txtRoadTax.Name = "txtRoadTax"
        Me.txtRoadTax.Size = New System.Drawing.Size(208, 23)
        Me.txtRoadTax.TabIndex = 8
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(368, 112)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(139, 16)
        Me.Label89.TabIndex = 62
        Me.Label89.Text = "Fitness certificate :"
        '
        'txtFC
        '
        Me.txtFC.AlphaNumeric = True
        Me.txtFC.BlankSpace = False
        Me.txtFC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFC.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFC.Location = New System.Drawing.Point(504, 112)
        Me.txtFC.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFC.Mandatory = False
        Me.txtFC.MaxLength = 20
        Me.txtFC.Name = "txtFC"
        Me.txtFC.Size = New System.Drawing.Size(208, 20)
        Me.txtFC.SpecialChar = True
        Me.txtFC.TabIndex = 7
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(16, 184)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(91, 16)
        Me.Label88.TabIndex = 60
        Me.Label88.Text = "Chase  No. :"
        '
        'txtChaseNo
        '
        Me.txtChaseNo.AlphaNumeric = True
        Me.txtChaseNo.BlankSpace = False
        Me.txtChaseNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaseNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChaseNo.Location = New System.Drawing.Point(152, 184)
        Me.txtChaseNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChaseNo.Mandatory = False
        Me.txtChaseNo.MaxLength = 20
        Me.txtChaseNo.Name = "txtChaseNo"
        Me.txtChaseNo.Size = New System.Drawing.Size(184, 20)
        Me.txtChaseNo.SpecialChar = True
        Me.txtChaseNo.TabIndex = 6
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(16, 152)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(89, 16)
        Me.Label87.TabIndex = 58
        Me.Label87.Text = "Engine No. :"
        '
        'txtEngineNo
        '
        Me.txtEngineNo.AlphaNumeric = True
        Me.txtEngineNo.BlankSpace = False
        Me.txtEngineNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngineNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEngineNo.Location = New System.Drawing.Point(152, 152)
        Me.txtEngineNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEngineNo.Mandatory = False
        Me.txtEngineNo.MaxLength = 20
        Me.txtEngineNo.Name = "txtEngineNo"
        Me.txtEngineNo.Size = New System.Drawing.Size(184, 20)
        Me.txtEngineNo.SpecialChar = True
        Me.txtEngineNo.TabIndex = 5
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(16, 120)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(124, 16)
        Me.Label86.TabIndex = 56
        Me.Label86.Text = "Registration No. :"
        '
        'txtRegistrationNo
        '
        Me.txtRegistrationNo.AlphaNumeric = True
        Me.txtRegistrationNo.BlankSpace = False
        Me.txtRegistrationNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRegistrationNo.Location = New System.Drawing.Point(152, 112)
        Me.txtRegistrationNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRegistrationNo.Mandatory = False
        Me.txtRegistrationNo.MaxLength = 20
        Me.txtRegistrationNo.Name = "txtRegistrationNo"
        Me.txtRegistrationNo.Size = New System.Drawing.Size(184, 24)
        Me.txtRegistrationNo.SpecialChar = True
        Me.txtRegistrationNo.TabIndex = 4
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbOthers.Controls.Add(Me.txtRemarks)
        Me.tbOthers.Controls.Add(Me.Label17)
        Me.tbOthers.Controls.Add(Me.GroupBox5)
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(736, 451)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(104, 352)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(592, 64)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 352)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Remarks :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtRelationship)
        Me.GroupBox5.Controls.Add(Me.Label64)
        Me.GroupBox5.Controls.Add(Me.txtOtherParticular)
        Me.GroupBox5.Controls.Add(Me.Label60)
        Me.GroupBox5.Controls.Add(Me.txtMortage)
        Me.GroupBox5.Controls.Add(Me.Label59)
        Me.GroupBox5.Controls.Add(Me.txtImmovable)
        Me.GroupBox5.Controls.Add(Me.Label58)
        Me.GroupBox5.Controls.Add(Me.pnlAsSurety)
        Me.GroupBox5.Controls.Add(Me.chkSurety)
        Me.GroupBox5.Controls.Add(Me.pnlBorrower)
        Me.GroupBox5.Controls.Add(Me.chkBorrower)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(712, 312)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Details Of Liablity In Any Bank"
        '
        'txtRelationship
        '
        Me.txtRelationship.AlphaNumeric = True
        Me.txtRelationship.BlankSpace = True
        Me.txtRelationship.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelationship.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRelationship.Location = New System.Drawing.Point(176, 272)
        Me.txtRelationship.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRelationship.Mandatory = False
        Me.txtRelationship.MaxLength = 100
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(168, 24)
        Me.txtRelationship.SpecialChar = True
        Me.txtRelationship.TabIndex = 8
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(24, 264)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(112, 32)
        Me.Label64.TabIndex = 62
        Me.Label64.Text = "Relationship Between Both :"
        '
        'txtOtherParticular
        '
        Me.txtOtherParticular.AlphaNumeric = True
        Me.txtOtherParticular.BlankSpace = True
        Me.txtOtherParticular.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherParticular.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherParticular.Location = New System.Drawing.Point(520, 272)
        Me.txtOtherParticular.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherParticular.Mandatory = False
        Me.txtOtherParticular.MaxLength = 100
        Me.txtOtherParticular.Name = "txtOtherParticular"
        Me.txtOtherParticular.Size = New System.Drawing.Size(168, 24)
        Me.txtOtherParticular.SpecialChar = True
        Me.txtOtherParticular.TabIndex = 15
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(384, 264)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(120, 32)
        Me.Label60.TabIndex = 60
        Me.Label60.Text = "Any Other Particulars :"
        '
        'txtMortage
        '
        Me.txtMortage.AlphaNumeric = True
        Me.txtMortage.BlankSpace = True
        Me.txtMortage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMortage.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMortage.Location = New System.Drawing.Point(520, 184)
        Me.txtMortage.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMortage.Mandatory = False
        Me.txtMortage.MaxLength = 100
        Me.txtMortage.Multiline = True
        Me.txtMortage.Name = "txtMortage"
        Me.txtMortage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMortage.Size = New System.Drawing.Size(168, 64)
        Me.txtMortage.SpecialChar = True
        Me.txtMortage.TabIndex = 14
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(384, 192)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(128, 32)
        Me.Label59.TabIndex = 58
        Me.Label59.Text = "Details Of Mortage Property"
        '
        'txtImmovable
        '
        Me.txtImmovable.AlphaNumeric = True
        Me.txtImmovable.BlankSpace = True
        Me.txtImmovable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImmovable.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtImmovable.Location = New System.Drawing.Point(176, 192)
        Me.txtImmovable.LostFocusColour = System.Drawing.Color.Empty
        Me.txtImmovable.Mandatory = False
        Me.txtImmovable.MaxLength = 100
        Me.txtImmovable.Multiline = True
        Me.txtImmovable.Name = "txtImmovable"
        Me.txtImmovable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImmovable.Size = New System.Drawing.Size(168, 64)
        Me.txtImmovable.SpecialChar = True
        Me.txtImmovable.TabIndex = 7
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(24, 192)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(152, 40)
        Me.Label58.TabIndex = 4
        Me.Label58.Text = "Details Of Immovable Property :"
        '
        'pnlAsSurety
        '
        Me.pnlAsSurety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAsSurety.Controls.Add(Me.txtLoanAmount)
        Me.pnlAsSurety.Controls.Add(Me.Label56)
        Me.pnlAsSurety.Controls.Add(Me.txtBankName)
        Me.pnlAsSurety.Controls.Add(Me.Label57)
        Me.pnlAsSurety.Controls.Add(Me.txtLoanType)
        Me.pnlAsSurety.Controls.Add(Me.Label71)
        Me.pnlAsSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAsSurety.Location = New System.Drawing.Point(368, 56)
        Me.pnlAsSurety.Name = "pnlAsSurety"
        Me.pnlAsSurety.Size = New System.Drawing.Size(328, 112)
        Me.pnlAsSurety.TabIndex = 10
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.AfterDecimal = 0
        Me.txtLoanAmount.BeforeDecimal = 8
        Me.txtLoanAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtLoanAmount.Location = New System.Drawing.Point(152, 80)
        Me.txtLoanAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLoanAmount.MaxLength = 10
        Me.txtLoanAmount.MaxValue = 99999999
        Me.txtLoanAmount.MinValue = 0
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtLoanAmount.TabIndex = 13
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(16, 16)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(55, 16)
        Me.Label56.TabIndex = 88
        Me.Label56.Text = "Name: "
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = False
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBankName.Location = New System.Drawing.Point(152, 16)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 30
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(168, 24)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 11
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(16, 48)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(108, 16)
        Me.Label57.TabIndex = 89
        Me.Label57.Text = "Type Of Loan: "
        '
        'txtLoanType
        '
        Me.txtLoanType.AlphaNumeric = True
        Me.txtLoanType.BlankSpace = False
        Me.txtLoanType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanType.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtLoanType.Location = New System.Drawing.Point(152, 48)
        Me.txtLoanType.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLoanType.Mandatory = False
        Me.txtLoanType.MaxLength = 30
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(168, 24)
        Me.txtLoanType.SpecialChar = True
        Me.txtLoanType.TabIndex = 12
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(16, 80)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(134, 16)
        Me.Label71.TabIndex = 87
        Me.Label71.Text = "Loan Sanctioned:  "
        '
        'chkSurety
        '
        Me.chkSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSurety.Location = New System.Drawing.Point(376, 24)
        Me.chkSurety.Name = "chkSurety"
        Me.chkSurety.Size = New System.Drawing.Size(112, 24)
        Me.chkSurety.TabIndex = 9
        Me.chkSurety.Text = "As Surety"
        '
        'pnlBorrower
        '
        Me.pnlBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrower.Controls.Add(Me.txtOrgResp)
        Me.pnlBorrower.Controls.Add(Me.Label53)
        Me.pnlBorrower.Controls.Add(Me.txtPersonResp)
        Me.pnlBorrower.Controls.Add(Me.Label54)
        Me.pnlBorrower.Controls.Add(Me.Label55)
        Me.pnlBorrower.Controls.Add(Me.txtBankResp)
        Me.pnlBorrower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBorrower.Location = New System.Drawing.Point(16, 56)
        Me.pnlBorrower.Name = "pnlBorrower"
        Me.pnlBorrower.Size = New System.Drawing.Size(344, 112)
        Me.pnlBorrower.TabIndex = 3
        '
        'txtOrgResp
        '
        Me.txtOrgResp.AlphaNumeric = True
        Me.txtOrgResp.BlankSpace = False
        Me.txtOrgResp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrgResp.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtOrgResp.Location = New System.Drawing.Point(160, 48)
        Me.txtOrgResp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOrgResp.Mandatory = False
        Me.txtOrgResp.MaxLength = 30
        Me.txtOrgResp.Name = "txtOrgResp"
        Me.txtOrgResp.Size = New System.Drawing.Size(168, 24)
        Me.txtOrgResp.SpecialChar = True
        Me.txtOrgResp.TabIndex = 5
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(16, 48)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(141, 16)
        Me.Label53.TabIndex = 102
        Me.Label53.Text = "Other Institutions : "
        '
        'txtPersonResp
        '
        Me.txtPersonResp.AlphaNumeric = True
        Me.txtPersonResp.BlankSpace = False
        Me.txtPersonResp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonResp.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtPersonResp.Location = New System.Drawing.Point(160, 80)
        Me.txtPersonResp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPersonResp.Mandatory = False
        Me.txtPersonResp.MaxLength = 30
        Me.txtPersonResp.Name = "txtPersonResp"
        Me.txtPersonResp.Size = New System.Drawing.Size(168, 24)
        Me.txtPersonResp.SpecialChar = True
        Me.txtPersonResp.TabIndex = 6
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(16, 80)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(103, 16)
        Me.Label54.TabIndex = 100
        Me.Label54.Text = "Individuals :   "
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(16, 16)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(115, 16)
        Me.Label55.TabIndex = 101
        Me.Label55.Text = "The Sahakari :  "
        '
        'txtBankResp
        '
        Me.txtBankResp.AlphaNumeric = True
        Me.txtBankResp.BlankSpace = False
        Me.txtBankResp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankResp.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBankResp.Location = New System.Drawing.Point(160, 16)
        Me.txtBankResp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankResp.Mandatory = False
        Me.txtBankResp.MaxLength = 30
        Me.txtBankResp.Name = "txtBankResp"
        Me.txtBankResp.Size = New System.Drawing.Size(168, 24)
        Me.txtBankResp.SpecialChar = True
        Me.txtBankResp.TabIndex = 4
        '
        'chkBorrower
        '
        Me.chkBorrower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBorrower.Location = New System.Drawing.Point(24, 24)
        Me.chkBorrower.Name = "chkBorrower"
        Me.chkBorrower.Size = New System.Drawing.Size(112, 24)
        Me.chkBorrower.TabIndex = 2
        Me.chkBorrower.Text = "As Borrower"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.chkDeselectAll)
        Me.TabPage1.Controls.Add(Me.chkSelectAll)
        Me.TabPage1.Controls.Add(Me.Label93)
        Me.TabPage1.Controls.Add(Me.lvDocuments)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(736, 451)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Check List"
        '
        'chkDeselectAll
        '
        Me.chkDeselectAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeselectAll.Location = New System.Drawing.Point(80, 129)
        Me.chkDeselectAll.Name = "chkDeselectAll"
        Me.chkDeselectAll.Size = New System.Drawing.Size(104, 24)
        Me.chkDeselectAll.TabIndex = 2
        Me.chkDeselectAll.Text = "Deselect All"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(80, 81)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(88, 24)
        Me.chkSelectAll.TabIndex = 1
        Me.chkSelectAll.Text = "Select All"
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(56, 41)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(176, 16)
        Me.Label93.TabIndex = 46
        Me.Label93.Text = "Documents Presented To Bank"
        '
        'lvDocuments
        '
        Me.lvDocuments.CheckBoxes = True
        Me.lvDocuments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clChkDoc, Me.clSlNo, Me.clDocuments})
        Me.lvDocuments.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDocuments.FullRowSelect = True
        Me.lvDocuments.GridLines = True
        Me.lvDocuments.Location = New System.Drawing.Point(264, 33)
        Me.lvDocuments.Name = "lvDocuments"
        Me.lvDocuments.Size = New System.Drawing.Size(368, 392)
        Me.lvDocuments.TabIndex = 3
        Me.lvDocuments.UseCompatibleStateImageBehavior = False
        Me.lvDocuments.View = System.Windows.Forms.View.Details
        '
        'clChkDoc
        '
        Me.clChkDoc.Text = "SelectDocuments"
        Me.clChkDoc.Width = 42
        '
        'clSlNo
        '
        Me.clSlNo.Text = "SlNo"
        Me.clSlNo.Width = 71
        '
        'clDocuments
        '
        Me.clDocuments.Text = "Documents"
        Me.clDocuments.Width = 232
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(464, 56)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(16, 336)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(168, 40)
        Me.btnWithdraw.TabIndex = 4
        Me.btnWithdraw.Text = "&Disbursment"
        Me.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 376)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 5
        Me.NewButton5.Text = "&View Transaction Log"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton5.UseVisualStyleBackColor = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(16, 296)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(168, 40)
        Me.btnDeposit.TabIndex = 3
        Me.btnDeposit.Text = "&Repayment"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(528, 576)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 30
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(632, 576)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Vehicle Loan No. :"
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(208, 56)
        Me.txtLoanNo.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 8
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.Size = New System.Drawing.Size(144, 23)
        Me.txtLoanNo.SpecialChar = False
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.Text = "LMV"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(360, 56)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.Controls.Add(Me.btnSurety)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 632)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 144)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 1
        Me.NewButton3.Text = "&Joint Holders"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'btnSurety
        '
        Me.btnSurety.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSurety.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurety.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurety.ForeColor = System.Drawing.Color.Black
        Me.btnSurety.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSurety.Image = CType(resources.GetObject("btnSurety.Image"), System.Drawing.Image)
        Me.btnSurety.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSurety.Location = New System.Drawing.Point(16, 184)
        Me.btnSurety.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSurety.Name = "btnSurety"
        Me.btnSurety.Size = New System.Drawing.Size(168, 40)
        Me.btnSurety.TabIndex = 2
        Me.btnSurety.Text = "Surety &Person Details"
        Me.btnSurety.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSurety.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(16, 456)
        Me.btnCalc.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(168, 40)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Additional Charges"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(24, 576)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
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
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 624)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Olive
        Me.Label32.Location = New System.Drawing.Point(96, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(183, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Vehicle Loan Details"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
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
        'frmVehicleLoanDetails
        '
        Me.AccessibleDescription = "]q"
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 639)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmVehicleLoanDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Loan Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbGoldDetails.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.pnlBusiness.ResumeLayout(False)
        Me.pnlBusiness.PerformLayout()
        Me.pnlSalary.ResumeLayout(False)
        Me.pnlSalary.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbGoldDetails1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tbGoldLoanDetails.ResumeLayout(False)
        Me.tbGoldLoanDetails.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSecDetail.ResumeLayout(False)
        Me.tbSecDetail.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.pnlAsSurety.ResumeLayout(False)
        Me.pnlAsSurety.PerformLayout()
        Me.pnlBorrower.ResumeLayout(False)
        Me.pnlBorrower.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
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

    Private Shared m_FormDefInstance As frmVehicleLoanDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmVehicleLoanDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmVehicleLoanDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmVehicleLoanDetails)
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
    Sub sbLoadDocumentList()
        Dim dt As New DataTable
        Dim intCount As Integer = 0
        Dim lvItem As ListViewItem
        If objVehAccount.fnGetDocuments Then
            dt = objVehAccount.DocumentTable
            While intCount < dt.Rows.Count
                lvItem = lvDocuments.Items.Add("")
                lvItem.SubItems.Add(dt.Rows(intCount).Item("DocId"))
                lvItem.SubItems.Add(dt.Rows(intCount).Item("DocName"))
                intCount += 1
            End While
        End If
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

    Private Sub btnLoadPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPic.Click
        Dim OfdPic As New OpenFileDialog
        OfdPic.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdPic.ShowDialog() = DialogResult.OK Then
            PictureBox3.Image = Image.FromFile(OfdPic.FileName)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnSignature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignature.Click
        Dim OfdSign As New OpenFileDialog
        OfdSign.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdSign.ShowDialog() = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OfdSign.FileName)
        End If
    End Sub

    Private Sub btnClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose2.Click
        picSignature.Image = Nothing
    End Sub

#End Region

#Region "Functions "
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

        If Trim(txtLoanNo.Text) = "LMV" Then
            MsgBox("Enter account no", MsgBoxStyle.Exclamation)
            txtLoanNo.Focus()
            Return False

        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name ", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
            '
            'Trim(txtMemberNo.Text) = "" Or
        ElseIf Trim(txtSBNo.Text) = "" Then
            MsgBox("Enter SB number", MsgBoxStyle.Exclamation)
            btnMemSearch.Focus()
            Return False

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

        ElseIf cmbType.SelectedIndex = -1 Then
            MsgBox("Please select type of vehicle", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbGoldDetails
            cmbType.Focus()
            Return False

        ElseIf Trim(txtExpectedAmount.Text) = String.Empty Then
            MsgBox("Enter expected amount for loan", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbGoldLoanDetails
            txtExpectedAmount.Focus()
            Return False

        ElseIf Trim(txtSanctionedAmount.Text) = String.Empty Then
            MsgBox("Enter sanctioned amount for loan", MsgBoxStyle.Exclamation)
            txtSanctionedAmount.Focus()
            Return False

        ElseIf Val(txtSanctionedAmount.Text) > Val(txtExpectedAmount.Text) Then
            MsgBox("Please check applied amount and sanction amount", MsgBoxStyle.Exclamation)
            txtSanctionedAmount.Focus()
            Return False

        ElseIf Trim(txtSanctionedNo.Text) = String.Empty Then
            MsgBox("Enter sanctioned number", MsgBoxStyle.Exclamation)
            txtSanctionedNo.Focus()
            Return False

        ElseIf Trim(txtROI.Text) = String.Empty Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbGoldLoanDetails
            txtROI.Focus()
            Return False

        ElseIf txtNOI.Text = String.Empty Then
            MsgBox("Enter no of installments", MsgBoxStyle.Exclamation)
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
            MsgBox("Select Mode Of Payment For Loan")
            cmbModeOfPayment.Focus()
            Return False

        ElseIf Trim(txtReason.Text) = String.Empty Then
            MsgBox("Enter reason for loan", MsgBoxStyle.Exclamation)
            txtReason.Focus()
            Return False

        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Please enter receiptno", MsgBoxStyle.Exclamation, "Loan Module")
            txtReceiptNo.Focus()
            Return False

        ElseIf (Mid(txtSanctionedAmount.Text, 1, 1)) = 0 Then
            MsgBox("Please check the sanctioned amount", MsgBoxStyle.Information)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf (dtpDemandSancDate.Value < dtpVehicleLoanDate.Value) Then
            MsgBox("Sanctioned date should be greater than Applied date", MsgBoxStyle.Information)
            dtpVehicleLoanDate.Focus()
            Return False
        ElseIf (dtpDueDate.Value < dtpDemandSancDate.Value) Then
            MsgBox("Due date should be greater than Sanctioned date", MsgBoxStyle.Information)
            dtpDueDate.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objVehAccount.fnChekVLAccount(Trim(txtLoanNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objVehAccount.fnAddVLAccount(objTrans) = True Then

                'fnGenerateVoucher()
                'Log Entry
                fnLogEntry(pbUserId, "New LMV created " & txtLoanNo.Text, Date.Now, "New LMV", objTrans)
                MessageBox.Show("New vehicle loan created successfully.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New vehicle loan  creation failed, because of internal error.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False

            End If

        Else

            'update details (edit mode)
            If objVehAccount.fnUpdateLoanDetails(Trim(txtLoanNo.Text)) Then

                If objVehAccount.fnUpdateVehicleDetails(Trim(txtLoanNo.Text)) Then
                    fnUpdateLoanDocunentStat(objTrans)
                    fnLogEntry(pbUserId, "LMV updated" & txtLoanNo.Text, Date.Now, "Update LMV account")
                    MessageBox.Show("Vehicle loan updated successfully.", "Loan module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                    Return True

                Else

                    MessageBox.Show("Vehicle loan updation failed, because of internal error.", "Loan module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                    Return False

                End If

            End If

        End If

    End Function
    Function fnUpdateLoanDocunentStat(ByVal objTrans As IDbTransaction) As Boolean
        If objVehAccount.fnDeleteLoanDocunentStat(Trim(txtLoanNo.Text), objTrans) Then
            If objVehAccount.fnInsertLoanDocunentStat(objTrans) Then

            End If
        End If
    End Function
    Function fnGenerateVoucher() As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpVehicleLoanDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()


        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReceiptNo.Text, dtpVehicleLoanDate.Value, txtSanctionedAmount.Text, "By new gold loan" & txtCustomerID.Text, lngSlNo, "Y")

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpVehicleLoanDate.Value, "By vehicle loan account " & txtLoanNo.Text, "To", 1, 0, Val(txtSanctionedAmount.Text), 1, "Y")

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpVehicleLoanDate.Value, "By cash account " & txtLoanNo.Text, "By", 16, Val(txtSanctionedAmount.Text), 0, 2, "Y")

        Return True

    End Function

    Function fnSetData() As Boolean

        ' Person Deatils
        Dim dtGoldTable As DataTable
        Dim dtGoldDet As GoldLoanControl
        Dim i As Integer
        Dim dr As DataRow
        If lngPersonNo <> 0 Then
            objVehAccount.PersonNo = lngPersonNo
        Else
            objVehAccount.PersonNo = objVehAccount.fnGetNewPersonNo()
        End If
        objVehAccount.Name = txtName.Text
        objVehAccount.FatherName = txtFatherName.Text
        objVehAccount.PermAddress = txtPermAddress.Text
        objVehAccount.PresAddress = txtPresAddress.Text

        If txtPhoneNo.Text = "" Then
            objVehAccount.PhoneNo = 0
        Else
            objVehAccount.PhoneNo = txtPhoneNo.Text
        End If

        If txtMobileNo.Text = "" Then
            objVehAccount.MobileNo = 0
        Else
            objVehAccount.MobileNo = txtMobileNo.Text
        End If

        objVehAccount.DOB = Format(dtpDOB.Value, "yyyy-MM-dd")
        objVehAccount.Age = txtAge.Text
        objVehAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objVehAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objVehAccount.ReligionCode = cmbReligion.SelectedValue
        objVehAccount.OccupationCode = cmbOccupation.SelectedValue

        objVehAccount.Status = "Active"
        ' objVehAccount.Photo = fnGetPhoto()
        objVehAccount.Photo = picPhoto.ImageLocation
        ' objVehAccount.Sign = fnGetSign()
        objVehAccount.Sign = picSignature.ImageLocation
        objVehAccount.OfficeNo = OfficeNo
        'Vehicle Details

        objVehAccount.LoanNo = txtLoanNo.Text
        objVehAccount.SBNo = txtSBNo.Text
        objVehAccount.MemberNo = txtCustomerID.Text
        objVehAccount.VehicleReason = txtReason.Text
        objVehAccount.VehicleROI = (txtROI.Text / 100)
        objVehAccount.VehicleExpectedAmount = txtExpectedAmount.Text
        objVehAccount.VehicleSanctioned = txtSanctionedAmount.Text
        objVehAccount.VehicleAmtBalance = 0
        objVehAccount.VehicleDisbAmt = 0

        Select Case cmbAccType.SelectedItem
            Case "Joint"
                objVehAccount.LoanAccType = "J"
            Case "Single"
                objVehAccount.LoanAccType = "S"
        End Select


        objVehAccount.VehicleLastInstDate = "9999-9-9"
        objVehAccount.VehicleLastPaidDate = "9999-9-9"
        objVehAccount.VehicleInstallments = cmbInstallmentType.SelectedItem
        objVehAccount.VehicleModeOfPayment = cmbModeOfPayment.SelectedItem
        objVehAccount.VehicleDate = Format(dtpVehicleLoanDate.Value, "yyyy-MM-dd")
        objVehAccount.Remarks = txtRemarks.Text
        objVehAccount.NOI = txtNOI.Text
        objVehAccount.VehicleDueDate = Format(dtpDueDate.Value, "yyyy-MM-dd")
        objVehAccount.ReciptNo = txtReceiptNo.Text


        objVehAccount.VehicleSancNo = txtSanctionedNo.Text
        objVehAccount.VehicleSancDate = dtpDemandSancDate.Value
        objVehAccount.MobileNo2 = txtMobileNo2.Text

        objVehAccount.VehicleInstPrinciple = Val(txtInstAmount.Text)
        ''Vehicle LoanDetails

        objVehAccount.OfficeName = txtOfficeName.Text
        objVehAccount.Designation = txtDesignation.Text

        If txtService.Text = "" Then
            objVehAccount.ServiceAvailable = 0
        Else
            objVehAccount.ServiceAvailable = txtService.Text
        End If

        If chkGTreeProduced.Checked = True Then
            objVehAccount.GTree = "Y"
        Else
            objVehAccount.GTree = "N"
        End If
        objVehAccount.LicenceNo = txtLicenceNo.Text
        objVehAccount.Validity = dtpValidity.Value
        objVehAccount.PermitNo = txtPermit.Text
        objVehAccount.PermitValidity = dtpPDate.Value
        objVehAccount.ModeOfUse = txtModeofUse.Text

        objVehAccount.AreaOfOperation = txtArea.Text
        objVehAccount.parkedAddress = txtVehAddr.Text

        If rdbOld.Checked = True Then
            objVehAccount.OldVehicle = "O"
        Else
            objVehAccount.OldVehicle = "N"
        End If
        objVehAccount.VehicleType = cmbType.SelectedItem
        objVehAccount.VehicleName = txtVehicleName.Text
        objVehAccount.PurchaseDate = dtpPDate.Value
        If txtCost.Text = "" Then
            objVehAccount.CostOfVehicle = 0
        Else
            objVehAccount.CostOfVehicle = txtCost.Text
        End If
        objVehAccount.PreMarketPrice = Val(txtPMarketPrice.Text)
        objVehAccount.InsuSerTax = Val(txtTax.Text)
        objVehAccount.FittingCost = Val(txtAdditionalFittingCost.Text)
        objVehAccount.BBuildingCharges = Val(txtBBuildingCost.Text)
        objVehAccount.Netamount = Val(txtNetAmtPayable.Text)
        objVehAccount.ExpInTBusiness = txtExpTB.Text
        objVehAccount.LoanToRepay = txtLoanToRepay.Text
        objVehAccount.DirName = txtDirName.Text
        objVehAccount.DirRelation = txtDirRelation.Text

        objVehAccount.DealerName = txtDealerName.Text
        objVehAccount.otherVehicle = txtOtherVehicle.Text
        objVehAccount.IncomeTaxDet = txtIncomeTax.Text
        objVehAccount.ImmovablePropertyDet = txtImmovable.Text
        objVehAccount.mortagagePropertyDet = txtMortage.Text
        objVehAccount.Relationship = txtRelationship.Text
        objVehAccount.Others = txtOtherParticular.Text

        If chkBorrower.Checked = True Then
            objVehAccount.AsBorrower = "Y"
            objVehAccount.BankResp = Val(txtBankResp.Text)
            objVehAccount.OrgResp = txtOrgResp.Text
            objVehAccount.PersonResp = txtPersonResp.Text
        Else
            objVehAccount.AsBorrower = "N"
            objVehAccount.BankResp = 0
            objVehAccount.OrgResp = 0
            objVehAccount.PersonResp = 0
        End If

        If chkSurety.Checked = True Then
            objVehAccount.AsSurety = "Y"
            objVehAccount.BankName = txtBankName.Text
            objVehAccount.LoanType = txtLoanType.Text
            objVehAccount.LoanAmount = Val(txtLoanAmount.Text)
        Else
            objVehAccount.AsSurety = "N"
            objVehAccount.BankName = 0
            objVehAccount.LoanType = 0
            objVehAccount.LoanAmount = 0
        End If

        If chkSalary.Checked = True Then
            objVehAccount.AsSalaried = "Y"
            objVehAccount.SSalary = Val(txtSSalary.Text)
            objVehAccount.SRent = Val(txtSRent.Text)
            objVehAccount.SOtherIncome = Val(txtSOtherIncome.Text)
            objVehAccount.STotalIncome = Val(txtSTotalIncome.Text)
            objVehAccount.STotalSavings = Val(txtSTotalSavings.Text)
            objVehAccount.SExpenses = Val(txtSTotalExpenses.Text)
        Else
            objVehAccount.AsSalaried = "N"
            objVehAccount.SSalary = 0
            objVehAccount.SRent = 0
            objVehAccount.SOtherIncome = 0
            objVehAccount.STotalIncome = 0
            objVehAccount.STotalSavings = 0
            objVehAccount.SExpenses = 0
        End If

        If chkBusiness.Checked = True Then
            objVehAccount.AsBusiness = "Y"
            objVehAccount.BMonthlyIncome = Val(txtBIncome.Text)
            objVehAccount.BRent = Val(txtBRent.Text)
            objVehAccount.BotherIncome = Val(txtBotherIncome.Text)
            objVehAccount.BTotalIncome = Val(txtBtotalIncome.Text)
            objVehAccount.BTotalSavings = Val(txtBTotalSavings.Text)
            objVehAccount.BExpenses = Val(txtBTotalExpenses.Text)
        Else
            objVehAccount.AsBusiness = "N"
            objVehAccount.BMonthlyIncome = 0
            objVehAccount.BRent = 0
            objVehAccount.BotherIncome = 0
            objVehAccount.BTotalIncome = 0
            objVehAccount.BTotalSavings = 0
            objVehAccount.BExpenses = 0
        End If

        objVehAccount.RegistrationNo = txtRegistrationNo.Text
        objVehAccount.ChaseNo = txtChaseNo.Text
        objVehAccount.EngineNo = txtEngineNo.Text
        objVehAccount.RoadTax = Val(txtRoadTax.Text)
        objVehAccount.FC = txtFC.Text



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
        objVehAccount.DocumentTable = dtDocuments

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

    Public Function fnGetROI() As Boolean

        If objSBAccount.fnGetROI(txtLoanNo.Text, txtSanctionedAmount.Text) Then

            txtROI.Text = (objSBAccount.Loantypetable.Rows(0).Item("ROI"))

        End If

    End Function

    Public Function fnCalculate() As Boolean

        txtSTotalIncome.Text = Val(txtSSalary.Text) + Val(txtSRent.Text) + Val(txtSOtherIncome.Text)

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
        dtpDOB.MaxDate = Date.Now.Date
        dtpDOB.Value = Date.Now.Date
        dtpDueDate.Value = Date.Now.Date
        dtpVehicleLoanDate.Value = Date.Now.Date
        dtpDemandSancDate.Value = Date.Now
        sbLoadControlValues() 'Load Values 
        If txtLoanNo.Text <> String.Empty Then
            sbLoadVLAccDetails()
            txtLoanNo.Text = "LMV"
        End If

        txtLoanNo.Focus()
        btnAdd_Click(sender, e)
        pnlBorrower.Enabled = False
        pnlBusiness.Enabled = False
        pnlSalary.Enabled = False
        pnlAsSurety.Enabled = False

    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtLoanNo.Text = "LMV" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanNo.KeyPress
        If txtLoanNo.Text = "LMV" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyDown
        If txtLoanNo.Text = "LMV" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmVehLoanCust As New frmVehicleLoanCust
        objfrmVehLoanCust.strVehicleLoan = String.Empty
        objfrmVehLoanCust.ShowDialog(Me)
        If objfrmVehLoanCust.strVehicleLoan <> String.Empty Then
            txtLoanNo.Text = objfrmVehLoanCust.strVehicleLoan
            sbLoadVLAccDetails()
        End If
        objfrmVehLoanCust.Dispose()

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
                MsgBox("Please disburse amount first", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click

        If objVehAccount.fnChekVLAccount(Trim(txtLoanNo.Text)) = True Then
            Dim ObjfrmDisb As New frmDisbursment
            ObjfrmDisb.txtLoanNo.Text = txtLoanNo.Text
            ObjfrmDisb.ShowDialog(Me)
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If

    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click

        If objVehAccount.fnChekVLAccount(Trim(txtLoanNo.Text)) = True Then
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
        Dim TempNewNo As String = Mid(objSBAccount.fnGetNewLoanNo("LMV"), 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "LMV" & String.Format("{0:00000}", CInt(TempNewNo))
            txtLoanNo.Text = Temp
            txtLoanNo.Focus()
        Else
            MsgBox("LMV number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

#End Region

#Region "Genral Subroutines"

    Sub sbLoadVLAccDetails()
        Dim objDT As DataTable
        Dim msStream As MemoryStream

        If objVehAccount.fnGetLoanDetails(txtLoanNo.Text) Then
            sbClear()

            objDT = objVehAccount.vehicleLoanDettable

            'Sb Details

            txtLoanNo.Text = objDT.Rows(0).Item("LoanNo")
            txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
            lngPersonNo = objDT.Rows(0).Item("PersonNo")

            'Person Deatils
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
            txtExpectedAmount.Text = objDT.Rows(0).Item("ExpAmount")
            txtSanctionedAmount.Text = objDT.Rows(0).Item("SancAmount")
            dtpVehicleLoanDate.Value = objDT.Rows(0).Item("ApplDate")
            dtpDueDate.Value = objDT.Rows(0).Item("DueDate")

            Select Case objDT.Rows(0).Item("LoanType")
                Case "S"
                    cmbAccType.SelectedItem = "Single"
                Case "J"
                    cmbAccType.SelectedItem = "Joint"
            End Select

            dtpDemandSancDate.Value = objDT.Rows(0).Item("SancDate")
            txtSanctionedNo.Text = objDT.Rows(0).Item("SancNo")

            cmbModeOfPayment.Text = objDT.Rows(0).Item("RepayMode")
            txtReason.Text = objDT.Rows(0).Item("Purpose")
            txtRemarks.Text = objDT.Rows(0).Item("Remarks")
            txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
            txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")
            txtMobileNo2.Text = objDT.Rows(0).Item("MobileNo2")


            'VehicleDetails

            txtOfficeName.Text = objDT.Rows(0).Item("OfficeName")
            txtDesignation.Text = objDT.Rows(0).Item("Designation")
            txtService.Text = objDT.Rows(0).Item("ServiceAvailable")
            txtNOI.Text = objDT.Rows(0).Item("NOI")
            If objDT.Rows(0).Item("GreeProduced") = "Y" Then
                chkGTreeProduced.Checked = True
            Else
                chkGTreeProduced.Checked = False
            End If


            txtSBNo.Text = objDT.Rows(0).Item("SBNo")
            txtLicenceNo.Text = objDT.Rows(0).Item("LicenceNo")
            dtpValidity.Value = Format(objDT.Rows(0).Item("Validity"), "yyyy-MM-dd")

            txtPermit.Text = objDT.Rows(0).Item("VPermitNo")
            dtpPValidity.Value = Format(objDT.Rows(0).Item("VPValidity"), "yyyy-MM-dd")
            txtModeofUse.Text = objDT.Rows(0).Item("VmodeofUse")
            dtpPDate.Value = Format(objDT.Rows(0).Item("Vpurchasedate"), "yyyy-MM-dd")
            txtPMarketPrice.Text = objDT.Rows(0).Item("PreMarketrate")
            txtTax.Text = objDT.Rows(0).Item("VTax")
            txtAdditionalFittingCost.Text = objDT.Rows(0).Item("VAdditionalFittingCost")
            txtBBuildingCost.Text = objDT.Rows(0).Item("VBBuildingCost")
            txtNetAmtPayable.Text = objDT.Rows(0).Item("NetAmount")
            txtExpTB.Text = objDT.Rows(0).Item("ExpTBusiness")
            txtLoanToRepay.Text = objDT.Rows(0).Item("ReasonForloan")
            txtDirName.Text = objDT.Rows(0).Item("DirectorName")
            txtDirRelation.Text = objDT.Rows(0).Item("RelationWthDirector")


            txtArea.Text = objDT.Rows(0).Item("AreaOfOperation")
            txtVehAddr.Text = objDT.Rows(0).Item("ParkedAddress")
            If objDT.Rows(0).Item("VehicleModel") = "N" Then
                rdbNew.Checked = True
            Else
                rdbOld.Checked = True
            End If

            cmbType.Text = objDT.Rows(0).Item("VehicleType")
            txtCost.Text = objDT.Rows(0).Item("CostOfVehicle")
            txtVehicleName.Text = objDT.Rows(0).Item("VehicleName")

            txtDealerName.Text = objDT.Rows(0).Item("DealerName")
            txtOtherVehicle.Text = objDT.Rows(0).Item("OtherVehcileDet")

            txtROI.Text = (objDT.Rows(0).Item("ROI") * 100)
            txtInstAmount.Text = objDT.Rows(0).Item("InstPrinciple")
            cmbInstallmentType.SelectedItem = objDT.Rows(0).Item("Type")


            If objDT.Rows(0).Item("SalaryPerson") = "Y" Then
                chkSalary.Checked = True
                txtSSalary.Text = objDT.Rows(0).Item("SSalary")
                txtSRent.Text = objDT.Rows(0).Item("SRent")
                txtSOtherIncome.Text = objDT.Rows(0).Item("SOtherIncome")
                txtSTotalIncome.Text = objDT.Rows(0).Item("STotal")
                txtSTotalExpenses.Text = objDT.Rows(0).Item("SExpenses")
                txtSTotalSavings.Text = objDT.Rows(0).Item("STotalSavings")
            Else
                chkSalary.Checked = False
                txtSSalary.Text = objDT.Rows(0).Item("SSalary")
                txtSRent.Text = objDT.Rows(0).Item("SRent")
                txtSOtherIncome.Text = objDT.Rows(0).Item("SOtherIncome")
                txtSTotalIncome.Text = objDT.Rows(0).Item("STotal")
                txtSTotalExpenses.Text = objDT.Rows(0).Item("SExpenses")
                txtSTotalSavings.Text = objDT.Rows(0).Item("STotalSavings")
            End If


            If objDT.Rows(0).Item("BusinessPerson") = "Y" Then
                chkBusiness.Checked = True
                txtBIncome.Text = objDT.Rows(0).Item("BMonthlyIncome")
                txtBRent.Text = objDT.Rows(0).Item("BRent")
                txtBotherIncome.Text = objDT.Rows(0).Item("BOtherIncome")
                txtBtotalIncome.Text = objDT.Rows(0).Item("BTotalIncome")
                txtBTotalExpenses.Text = objDT.Rows(0).Item("BExpenses")
                txtBTotalSavings.Text = objDT.Rows(0).Item("BTotalSavings")
            Else
                chkBusiness.Checked = False
                txtBIncome.Text = objDT.Rows(0).Item("BMonthlyIncome")
                txtBRent.Text = objDT.Rows(0).Item("BRent")
                txtBotherIncome.Text = objDT.Rows(0).Item("BOtherIncome")
                txtBtotalIncome.Text = objDT.Rows(0).Item("BTotalIncome")
                txtBTotalExpenses.Text = objDT.Rows(0).Item("BExpenses")
                txtBTotalSavings.Text = objDT.Rows(0).Item("BTotalSavings")
            End If


            txtIncomeTax.Text = objDT.Rows(0).Item("IncomeTaxDetails")
            If objDT.Rows(0).Item("AsBorrower") = "Y" Then
                chkBorrower.Checked = True
                txtBankResp.Text = objDT.Rows(0).Item("ToSahakari")
                txtOrgResp.Text = objDT.Rows(0).Item("OtherInstitution")
                txtPersonResp.Text = objDT.Rows(0).Item("Individual")
            Else
                chkBorrower.Checked = False
                txtBankResp.Text = objDT.Rows(0).Item("ToSahakari")
                txtOrgResp.Text = objDT.Rows(0).Item("OtherInstitution")
                txtPersonResp.Text = objDT.Rows(0).Item("Individual")
            End If

            If objDT.Rows(0).Item("AsSurety") = "Y" Then

                chkSurety.Checked = True
                txtBankName.Text = objDT.Rows(0).Item("SuretyName1")
                txtLoanType.Text = objDT.Rows(0).Item("SuretyLoanType1")
                txtLoanAmount.Text = objDT.Rows(0).Item("SuretyAmount1")
            Else

                chkSurety.Checked = False
                txtBankName.Text = objDT.Rows(0).Item("SuretyName1")
                txtLoanType.Text = objDT.Rows(0).Item("SuretyLoanType1")
                txtLoanAmount.Text = objDT.Rows(0).Item("SuretyAmount1")

            End If

            txtRelationship.Text = objDT.Rows(0).Item("Relationship")
            txtImmovable.Text = objDT.Rows(0).Item("ImmovablePropertyDet")
            txtMortage.Text = objDT.Rows(0).Item("MortagagePropertyDet")
            txtOtherParticular.Text = objDT.Rows(0).Item("Others")

            'txtSanctionedAmount.Enabled = False
            'txtROI.Enabled = False
            'txtReceiptNo.ReadOnly = True
            'txtExpectedAmount.ReadOnly = True
            'txtLoanNo.ReadOnly = True

            '  txtVehicleNo.Text = objDT.Rows(0).Item("VehicleNo")
            txtRegistrationNo.Text = objDT.Rows(0).Item("RegistrationNo")
            txtEngineNo.Text = objDT.Rows(0).Item("EngineNo")
            txtChaseNo.Text = objDT.Rows(0).Item("ChaseNo")
            txtFC.Text = objDT.Rows(0).Item("FC")
            txtRoadTax.Text = objDT.Rows(0).Item("RoadTax")
            fnLoadSuretyPerson()

            If objVehAccount.fnGetDoc(Trim(txtLoanNo.Text)) Then
                Dim dtdoc As New DataTable
                Dim intcount As Integer = 0
                Dim intcount1 As Integer = 0
                dtdoc = objVehAccount.DocumentTable
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
        End If





    End Sub

    Sub sbClear()

        Dim intCount As Integer = 0
        lngPersonNo = 0
        'txtLoanNo.Text = "LMV"
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
        txtRemarks.ResetText()
        txtExpectedAmount.ResetText()
        txtSanctionedAmount.ResetText()
        lvSuretyDetail.Items.Clear()
        txtROI.ResetText()
        cmbInstallmentType.SelectedIndex = -1
        cmbModeOfPayment.SelectedIndex = -1
        txtReason.Text = ""
        txtOfficeName.Text = ""
        txtDesignation.Text = ""
        txtService.Text = ""
        chkGTreeProduced.Checked = False
        txtLicenceNo.Text = ""
        txtArea.Text = ""
        txtVehAddr.Text = ""
        txtVehicleName.Text = ""
        txtCost.Text = ""
        txtDealerName.Text = ""
        txtOtherVehicle.Text = ""
        txtSSalary.Text = ""
        txtSRent.Text = ""
        txtSOtherIncome.Text = ""
        txtSTotalIncome.Text = ""
        txtSTotalExpenses.Text = ""
        txtSTotalSavings.Text = ""
        txtReceiptNo.Text = ""
        txtBIncome.Text = ""
        txtBRent.Text = ""
        txtBotherIncome.Text = ""
        txtBtotalIncome.Text = ""
        txtBRent.Text = ""
        txtBTotalExpenses.Text = ""
        txtBTotalSavings.Text = ""
        txtIncomeTax.Text = ""
        txtNOI.Text = ""
        txtRelationship.Text = ""
        txtImmovable.Text = ""
        txtOtherParticular.Text = ""
        txtBankResp.Text = ""
        txtOrgResp.Text = ""
        txtPersonResp.Text = ""
        txtBankName.Text = ""
        txtLoanType.Text = ""
        txtLoanAmount.Text = ""
        txtMortage.Text = ""

        txtMobileNo2.ResetText()
        txtSanctionedNo.ResetText()

        txtPMarketPrice.Text = ""
        txtTax.Text = ""
        txtAdditionalFittingCost.Text = ""
        txtBBuildingCost.Text = ""
        txtNetAmtPayable.Text = ""
        txtExpTB.Text = ""
        txtLoanToRepay.Text = ""
        txtDirName.Text = ""
        txtDirRelation.Text = ""
        txtPermit.Text = ""
        txtModeofUse.Text = ""
        txtInstAmount.Text = ""

        ' txtVehicleNo.ResetText()
        txtEngineNo.ResetText()
        txtChaseNo.ResetText()
        txtRegistrationNo.ResetText()
        txtFC.ResetText()
        txtRoadTax.ResetText()

        chkBorrower.Checked = False
        chkSalary.Checked = False
        chkBusiness.Checked = False
        chkSurety.Checked = False

        txtSanctionedAmount.ReadOnly = False
        txtReceiptNo.ReadOnly = False

        txtSanctionedAmount.Enabled = True
        txtROI.Enabled = True
        txtReceiptNo.ReadOnly = False
        txtExpectedAmount.ReadOnly = False
        txtLoanNo.ReadOnly = False


        NewButton1.Enabled = True
        btnMemSearch.Enabled = True
        txtCustomerID.ReadOnly = False
        txtSBNo.ReadOnly = False


        While intCount < lvDocuments.Items.Count
            lvDocuments.Items(intCount).Checked = False
            intCount += 1
        End While

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
                '    ' btnSBSearch.Enabled = False
                '    'Else
                '    '    txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
                '    '    btnMemSearch.Enabled = False
                'End If

                'txtSBNo.ReadOnly = True
                'txtMemberNo.ReadOnly = True

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
                txtName.Focus()
            End If
        Catch ex As Exception
        End Try


    End Sub

#End Region

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.TextChanged

        If txtLoanNo.Text.StartsWith("LMV") = False Then
            txtLoanNo.Undo()
            txtLoanNo.ClearUndo()
        End If

    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.Leave
        If objVehAccount.fnChekVLAccount(Trim(txtLoanNo.Text)) = True Then
            If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sbLoadVLAccDetails()
            Else
                txtLoanNo.Focus()
            End If
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

#Region "Navigation"

    Private Sub cmbInstallmentType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbInstallmentType.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbCaste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCaste.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbModeOfPayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbModeOfPayment.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbOccupation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOccupation.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbReason_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbReligion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReligion.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub dtpDOB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyDown

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

    Private Sub txtAge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAge.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtExpectedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExpectedAmount.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtFatherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFatherName.KeyDown

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
    Private Sub txtROI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtROI.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtSanctionedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSanctionedAmount.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtWitnessPerson1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub
    Private Sub chkSame_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

#End Region

    Private Sub chkSalary_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSalary.CheckedChanged

        If chkSalary.Checked = True Then

            pnlSalary.Enabled = True

        Else

            pnlSalary.Enabled = False

        End If

    End Sub

    Private Sub chkBorrower_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBorrower.CheckedChanged

        If chkBorrower.Checked = True Then

            pnlBorrower.Enabled = True

        Else

            pnlBorrower.Enabled = False

        End If

    End Sub

    Private Sub chkBusiness_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBusiness.CheckedChanged
        If chkBusiness.Checked = True Then
            pnlBusiness.Enabled = True
        Else
            pnlBusiness.Enabled = False

        End If

    End Sub

    Private Sub chkSurety_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSurety.CheckedChanged
        If chkSurety.Checked = True Then
            pnlAsSurety.Enabled = True
        Else
            pnlAsSurety.Enabled = False
        End If


    End Sub

    Private Sub txtSSalary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSalary.TextChanged, txtSRent.TextChanged, txtSOtherIncome.TextChanged

        fnCalculate()

    End Sub


    Private Sub txtBIncome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBIncome.TextChanged, txtBRent.TextChanged, txtBotherIncome.TextChanged

        txtBtotalIncome.Text = Val(txtBIncome.Text) + Val(txtBRent.Text) + Val(txtBotherIncome.Text)

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ''If txtLoanNo.Text <> "VL" Then
        ''    Dim objFrmCalc As New frmIntrestCalc
        ''    objFrmCalc.txtLoanNo.Text = txtLoanNo.Text
        ''    objFrmCalc.txtLoanerName.Text = txtName.Text
        ''    objFrmCalc.ShowDialog(Me)
        ''End If

    End Sub

    Private Sub btnSurety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurety.Click
        If txtLoanNo.Text <> "LMV" Then
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

    Private Sub txtSTotalExpenses_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSTotalExpenses.TextChanged
        txtSTotalSavings.Text = Val(txtSTotalIncome.Text) - Val(txtSTotalExpenses.Text)
    End Sub

    Private Sub txtBTotalExpenses_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBTotalExpenses.TextChanged
        txtBTotalSavings.Text = Val(txtBtotalIncome.Text) - Val(txtBTotalExpenses.Text)
    End Sub

    Private Sub txtReceiptNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReason.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 4
            TabControl1.Focus()
        End If
    End Sub

    Private Sub txtVehAddr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVehAddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 2
            TabControl1.Focus()
        End If
    End Sub

    Private Sub txtLoanToRepay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanToRepay.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 3
            TabControl1.Focus()
        End If
    End Sub

    Private Sub txtSanctionedAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSanctionedAmount.Leave
        If txtSanctionedAmount.Text = "" Then
            MsgBox("Enter sanctioned amount to load rate of intrest")
        Else
            fnGetROI()
        End If
    End Sub
    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        Dim objAccountSelection As New frmAccountSelection
        objAccountSelection.ShowDialog(Me)
        txtSBNo.Text = objAccountSelection.strAccountNo
        objAccountSelection.Dispose()
        Dim strType1 As String = Mid(objAccountSelection.strAccountNo, 1, 2)

        If (strType1 = "SB") Then
            Label63.Text = "SB No. :"
        Else
            Label63.Text = "CA No. :"

        End If

        objAccountSelection.Dispose()


    End Sub
    Private Sub txtNOI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOI.TextChanged
        Dim TempDate As Date = DateAdd(DateInterval.Month, Val(txtNOI.Text), dtpDemandSancDate.Value)
        dtpDueDate.Value = DateAdd(DateInterval.Day, -1, TempDate)
    End Sub
    Private Sub chkSelectAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        Dim intcount As Integer = 0
        While intcount < lvDocuments.Items.Count
            lvDocuments.Items(intcount).Checked = True
            intcount += 1
        End While

    End Sub

    Private Sub chkDeselectAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDeselectAll.CheckedChanged
        Dim intcount As Integer = 0
        While intcount < lvDocuments.Items.Count
            lvDocuments.Items(intcount).Checked = False
            intcount += 1
        End While
    End Sub

    Private Sub NewButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
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
                MsgBox("Enter valid account no", MsgBoxStyle.Information, "LOan Module")
                txtLoanNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCalc_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
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

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub
End Class
