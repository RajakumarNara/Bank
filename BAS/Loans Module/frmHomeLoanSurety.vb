Imports System.IO
Public Class frmHomeLoanSurety
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPermAddress As BankControls.TextControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtService As BankControls.NumericControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlBusiness As System.Windows.Forms.Panel
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtBtotalIncome As BankControls.NumericControl
    Friend WithEvents txtBotherIncome As BankControls.NumericControl
    Friend WithEvents txtBRent As BankControls.NumericControl
    Friend WithEvents txtBIncome As BankControls.NumericControl
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents pnlSalary As System.Windows.Forms.Panel
    Friend WithEvents txtSTotalIncome As BankControls.NumericControl
    Friend WithEvents txtSOtherIncome As BankControls.NumericControl
    Friend WithEvents txtSRent As BankControls.NumericControl
    Friend WithEvents txtSSalary As BankControls.NumericControl
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSaving As BankControls.NumericControl
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtBusinessPersonDet As BankControls.TextControl
    Friend WithEvents txtSuretyPersonName As BankControls.TextControl
    Friend WithEvents txtLoanerName As BankControls.TextControl
    Friend WithEvents txtDeclaration As BankControls.TextControl
    Friend WithEvents txtImmovableDet As BankControls.TextControl
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents txtLoanType As BankControls.TextControl
    Friend WithEvents txtOthers As BankControls.TextControl
    Friend WithEvents txtSalariedPersonDet As BankControls.TextControl
    Friend WithEvents txtRelationship As BankControls.TextControl
    Friend WithEvents txtBTotalSavings As BankControls.NumericControl
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlSalariedDet As System.Windows.Forms.Panel
    Friend WithEvents pnlBusinessDet As System.Windows.Forms.Panel
    Friend WithEvents chkSalary As System.Windows.Forms.CheckBox
    Friend WithEvents chkBusiness As System.Windows.Forms.CheckBox
    Friend WithEvents chkBusiness1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalary1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLoanAmount As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtSTotalExpenses As BankControls.NumericControl
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtIncomeTax As BankControls.TextControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrgResp As BankControls.TextControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPersonResp As BankControls.TextControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As BankControls.TextControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBankResp As BankControls.TextControl
    Friend WithEvents txtBTotalExpenses As BankControls.NumericControl
    Friend WithEvents lblNomineeNo As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnDelete As BankControls.NewButton
    Friend WithEvents btnPrevious As BankControls.NewButton
    Friend WithEvents btnNext As BankControls.NewButton
    Friend WithEvents txtSuretyNo As BankControls.TextControl
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As BankControls.NumericControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSignLoad As BankControls.NewButton
    Friend WithEvents btnSignCancel As BankControls.NewButton
    Friend WithEvents btnPhotoLoad As BankControls.NewButton
    Friend WithEvents btnPhotoCancel As BankControls.NewButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDeclaration As System.Windows.Forms.Label
    Friend WithEvents btnSBSearch As BankControls.NewButton
    Friend WithEvents txtSBNo As BankControls.TextControl
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCustomerSearch As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHomeLoanSurety))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.pnlSalariedDet = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSalariedPersonDet = New BankControls.TextControl
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtService = New BankControls.NumericControl
        Me.chkSalary = New System.Windows.Forms.CheckBox
        Me.pnlBusinessDet = New System.Windows.Forms.Panel
        Me.txtBusinessPersonDet = New BankControls.TextControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkBusiness = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtMobileNo = New BankControls.NumericControl
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAge = New BankControls.NumericControl
        Me.txtFatherName = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRelationship = New BankControls.TextControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPermAddress = New BankControls.TextControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtIncomeTax = New BankControls.TextControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.pnlBusiness = New System.Windows.Forms.Panel
        Me.txtBTotalExpenses = New BankControls.NumericControl
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtBTotalSavings = New BankControls.NumericControl
        Me.Label72 = New System.Windows.Forms.Label
        Me.txtBtotalIncome = New BankControls.NumericControl
        Me.txtBotherIncome = New BankControls.NumericControl
        Me.txtBRent = New BankControls.NumericControl
        Me.txtBIncome = New BankControls.NumericControl
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.chkBusiness1 = New System.Windows.Forms.CheckBox
        Me.pnlSalary = New System.Windows.Forms.Panel
        Me.txtSTotalExpenses = New BankControls.NumericControl
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtSTotalIncome = New BankControls.NumericControl
        Me.txtSOtherIncome = New BankControls.NumericControl
        Me.txtSRent = New BankControls.NumericControl
        Me.txtSSalary = New BankControls.NumericControl
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtTotalSaving = New BankControls.NumericControl
        Me.Label52 = New System.Windows.Forms.Label
        Me.chkSalary1 = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtOrgResp = New BankControls.TextControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPersonResp = New BankControls.TextControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotal = New BankControls.TextControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtBankResp = New BankControls.TextControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtImmovableDet = New BankControls.TextControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtLoanAmount = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBankName = New BankControls.TextControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtLoanType = New BankControls.TextControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtOthers = New BankControls.TextControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnPhotoLoad = New BankControls.NewButton
        Me.btnPhotoCancel = New BankControls.NewButton
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.lblSignature = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnSignCancel = New BankControls.NewButton
        Me.btnSignLoad = New BankControls.NewButton
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnCustomerSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSBSearch = New BankControls.NewButton
        Me.txtSBNo = New BankControls.TextControl
        Me.Label63 = New System.Windows.Forms.Label
        Me.lblNomineeNo = New System.Windows.Forms.Label
        Me.txtSuretyNo = New BankControls.TextControl
        Me.txtCustomerNo = New BankControls.TextControl
        Me.lblName = New System.Windows.Forms.Label
        Me.txtSuretyPersonName = New BankControls.TextControl
        Me.lblDeclaration = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtLoanerName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDeclaration = New BankControls.TextControl
        Me.lblRecords = New System.Windows.Forms.Label
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.btnDelete = New BankControls.NewButton
        Me.btnPrevious = New BankControls.NewButton
        Me.btnNext = New BankControls.NewButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlSalariedDet.SuspendLayout()
        Me.pnlBusinessDet.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlBusiness.SuspendLayout()
        Me.pnlSalary.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 184)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 352)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Beige
        Me.TabPage1.Controls.Add(Me.pnlSalariedDet)
        Me.TabPage1.Controls.Add(Me.chkSalary)
        Me.TabPage1.Controls.Add(Me.pnlBusinessDet)
        Me.TabPage1.Controls.Add(Me.chkBusiness)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(672, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal"
        '
        'pnlSalariedDet
        '
        Me.pnlSalariedDet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalariedDet.Controls.Add(Me.Label5)
        Me.pnlSalariedDet.Controls.Add(Me.txtSalariedPersonDet)
        Me.pnlSalariedDet.Controls.Add(Me.Label40)
        Me.pnlSalariedDet.Controls.Add(Me.txtService)
        Me.pnlSalariedDet.Location = New System.Drawing.Point(352, 48)
        Me.pnlSalariedDet.Name = "pnlSalariedDet"
        Me.pnlSalariedDet.Size = New System.Drawing.Size(304, 120)
        Me.pnlSalariedDet.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Official Address : "
        '
        'txtSalariedPersonDet
        '
        Me.txtSalariedPersonDet.AlphaNumeric = True
        Me.txtSalariedPersonDet.AutoSize = False
        Me.txtSalariedPersonDet.BlankSpace = False
        Me.txtSalariedPersonDet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalariedPersonDet.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtSalariedPersonDet.Location = New System.Drawing.Point(136, 8)
        Me.txtSalariedPersonDet.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSalariedPersonDet.Mandatory = False
        Me.txtSalariedPersonDet.MaxLength = 100
        Me.txtSalariedPersonDet.Multiline = True
        Me.txtSalariedPersonDet.Name = "txtSalariedPersonDet"
        Me.txtSalariedPersonDet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSalariedPersonDet.Size = New System.Drawing.Size(160, 64)
        Me.txtSalariedPersonDet.SpecialChar = True
        Me.txtSalariedPersonDet.TabIndex = 22
        Me.txtSalariedPersonDet.Text = ""
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(8, 80)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(125, 18)
        Me.Label40.TabIndex = 78
        Me.Label40.Text = "Service Available : "
        '
        'txtService
        '
        Me.txtService.AfterDecimal = 0
        Me.txtService.BeforeDecimal = 2
        Me.txtService.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtService.Location = New System.Drawing.Point(136, 80)
        Me.txtService.LostFocusColour = System.Drawing.Color.Empty
        Me.txtService.MaxValue = 100
        Me.txtService.MinValue = 0
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(80, 23)
        Me.txtService.TabIndex = 23
        Me.txtService.Text = ""
        '
        'chkSalary
        '
        Me.chkSalary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalary.Location = New System.Drawing.Point(352, 16)
        Me.chkSalary.Name = "chkSalary"
        Me.chkSalary.Size = New System.Drawing.Size(176, 24)
        Me.chkSalary.TabIndex = 20
        Me.chkSalary.Text = "Salaried Person"
        '
        'pnlBusinessDet
        '
        Me.pnlBusinessDet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBusinessDet.Controls.Add(Me.txtBusinessPersonDet)
        Me.pnlBusinessDet.Controls.Add(Me.Label8)
        Me.pnlBusinessDet.Location = New System.Drawing.Point(352, 208)
        Me.pnlBusinessDet.Name = "pnlBusinessDet"
        Me.pnlBusinessDet.Size = New System.Drawing.Size(304, 96)
        Me.pnlBusinessDet.TabIndex = 23
        '
        'txtBusinessPersonDet
        '
        Me.txtBusinessPersonDet.AlphaNumeric = True
        Me.txtBusinessPersonDet.AutoSize = False
        Me.txtBusinessPersonDet.BlankSpace = False
        Me.txtBusinessPersonDet.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusinessPersonDet.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBusinessPersonDet.Location = New System.Drawing.Point(136, 16)
        Me.txtBusinessPersonDet.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBusinessPersonDet.Mandatory = False
        Me.txtBusinessPersonDet.MaxLength = 100
        Me.txtBusinessPersonDet.Multiline = True
        Me.txtBusinessPersonDet.Name = "txtBusinessPersonDet"
        Me.txtBusinessPersonDet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBusinessPersonDet.Size = New System.Drawing.Size(160, 64)
        Me.txtBusinessPersonDet.SpecialChar = True
        Me.txtBusinessPersonDet.TabIndex = 24
        Me.txtBusinessPersonDet.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 18)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Details :"
        '
        'chkBusiness
        '
        Me.chkBusiness.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBusiness.Location = New System.Drawing.Point(352, 176)
        Me.chkBusiness.Name = "chkBusiness"
        Me.chkBusiness.Size = New System.Drawing.Size(216, 24)
        Me.chkBusiness.TabIndex = 22
        Me.chkBusiness.Text = "Business Man/Professional"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.txtMobileNo)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtAge)
        Me.Panel2.Controls.Add(Me.txtFatherName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.dtpDOB)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtRelationship)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtPermAddress)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 304)
        Me.Panel2.TabIndex = 12
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 240)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 19)
        Me.Label29.TabIndex = 93
        Me.Label29.Text = "Phone No. :"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(128, 240)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(176, 23)
        Me.txtMobileNo.TabIndex = 18
        Me.txtMobileNo.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(117, 19)
        Me.Label23.TabIndex = 92
        Me.Label23.Text = "Husband Name  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 19)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(128, 40)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(80, 23)
        Me.txtAge.TabIndex = 13
        Me.txtAge.Text = ""
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.AutoSize = False
        Me.txtFatherName.BlankSpace = False
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtFatherName.Location = New System.Drawing.Point(128, 144)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(176, 24)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 16
        Me.txtFatherName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Father Name/ "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 19)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Date of Birth"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(128, 8)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(176, 23)
        Me.dtpDOB.TabIndex = 12
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 19)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Relationship "
        '
        'txtRelationship
        '
        Me.txtRelationship.AlphaNumeric = True
        Me.txtRelationship.AutoSize = False
        Me.txtRelationship.BlankSpace = False
        Me.txtRelationship.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelationship.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtRelationship.Location = New System.Drawing.Point(128, 272)
        Me.txtRelationship.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRelationship.Mandatory = False
        Me.txtRelationship.MaxLength = 15
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(176, 24)
        Me.txtRelationship.SpecialChar = False
        Me.txtRelationship.TabIndex = 19
        Me.txtRelationship.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 19)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = " Address "
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.AutoSize = False
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtPermAddress.Location = New System.Drawing.Point(128, 176)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(176, 56)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 17
        Me.txtPermAddress.Text = ""
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbMale)
        Me.Panel3.Controls.Add(Me.rdbFemale)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(128, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 32)
        Me.Panel3.TabIndex = 15
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 7)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 10
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 7)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 11
        Me.rdbFemale.Text = "Female"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rdbMajor)
        Me.Panel4.Controls.Add(Me.rdbMinor)
        Me.Panel4.Enabled = False
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(128, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 32)
        Me.Panel4.TabIndex = 14
        '
        'rdbMajor
        '
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 7)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 8
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.rdbMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 7)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 9
        Me.rdbMinor.Text = "Minor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Age Status: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Gender"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Beige
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(672, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Occupation Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtIncomeTax)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.pnlBusiness)
        Me.GroupBox1.Controls.Add(Me.chkBusiness1)
        Me.GroupBox1.Controls.Add(Me.pnlSalary)
        Me.GroupBox1.Controls.Add(Me.chkSalary1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 312)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Income  Details"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 280)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 16)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "SalesTax Details"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIncomeTax
        '
        Me.txtIncomeTax.AlphaNumeric = True
        Me.txtIncomeTax.AutoSize = False
        Me.txtIncomeTax.BlankSpace = True
        Me.txtIncomeTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncomeTax.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIncomeTax.Location = New System.Drawing.Point(160, 264)
        Me.txtIncomeTax.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIncomeTax.Mandatory = False
        Me.txtIncomeTax.MaxLength = 100
        Me.txtIncomeTax.Multiline = True
        Me.txtIncomeTax.Name = "txtIncomeTax"
        Me.txtIncomeTax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIncomeTax.Size = New System.Drawing.Size(344, 40)
        Me.txtIncomeTax.SpecialChar = True
        Me.txtIncomeTax.TabIndex = 43
        Me.txtIncomeTax.Text = ""
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 264)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "IncomeTax Details/"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBusiness
        '
        Me.pnlBusiness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBusiness.Controls.Add(Me.txtBTotalExpenses)
        Me.pnlBusiness.Controls.Add(Me.Label26)
        Me.pnlBusiness.Controls.Add(Me.txtBTotalSavings)
        Me.pnlBusiness.Controls.Add(Me.Label72)
        Me.pnlBusiness.Controls.Add(Me.txtBtotalIncome)
        Me.pnlBusiness.Controls.Add(Me.txtBotherIncome)
        Me.pnlBusiness.Controls.Add(Me.txtBRent)
        Me.pnlBusiness.Controls.Add(Me.txtBIncome)
        Me.pnlBusiness.Controls.Add(Me.Label48)
        Me.pnlBusiness.Controls.Add(Me.Label49)
        Me.pnlBusiness.Controls.Add(Me.Label50)
        Me.pnlBusiness.Controls.Add(Me.Label51)
        Me.pnlBusiness.Location = New System.Drawing.Point(304, 48)
        Me.pnlBusiness.Name = "pnlBusiness"
        Me.pnlBusiness.Size = New System.Drawing.Size(272, 208)
        Me.pnlBusiness.TabIndex = 35
        '
        'txtBTotalExpenses
        '
        Me.txtBTotalExpenses.AfterDecimal = 0
        Me.txtBTotalExpenses.BeforeDecimal = 8
        Me.txtBTotalExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTotalExpenses.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBTotalExpenses.Location = New System.Drawing.Point(127, 144)
        Me.txtBTotalExpenses.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBTotalExpenses.MaxLength = 10
        Me.txtBTotalExpenses.MaxValue = 99999999
        Me.txtBTotalExpenses.MinValue = 0
        Me.txtBTotalExpenses.Name = "txtBTotalExpenses"
        Me.txtBTotalExpenses.Size = New System.Drawing.Size(128, 22)
        Me.txtBTotalExpenses.TabIndex = 40
        Me.txtBTotalExpenses.Text = ""
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(15, 144)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Total Expenses"
        '
        'txtBTotalSavings
        '
        Me.txtBTotalSavings.AfterDecimal = 0
        Me.txtBTotalSavings.BackColor = System.Drawing.Color.White
        Me.txtBTotalSavings.BeforeDecimal = 9
        Me.txtBTotalSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTotalSavings.GotFocusColour = System.Drawing.Color.White
        Me.txtBTotalSavings.Location = New System.Drawing.Point(128, 176)
        Me.txtBTotalSavings.LostFocusColour = System.Drawing.Color.White
        Me.txtBTotalSavings.MaxLength = 10
        Me.txtBTotalSavings.MaxValue = 99999999
        Me.txtBTotalSavings.MinValue = 0
        Me.txtBTotalSavings.Name = "txtBTotalSavings"
        Me.txtBTotalSavings.ReadOnly = True
        Me.txtBTotalSavings.Size = New System.Drawing.Size(128, 22)
        Me.txtBTotalSavings.TabIndex = 41
        Me.txtBTotalSavings.Text = ""
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(8, 176)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(104, 16)
        Me.Label72.TabIndex = 46
        Me.Label72.Text = "Total Savings"
        '
        'txtBtotalIncome
        '
        Me.txtBtotalIncome.AfterDecimal = 0
        Me.txtBtotalIncome.BackColor = System.Drawing.Color.White
        Me.txtBtotalIncome.BeforeDecimal = 9
        Me.txtBtotalIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtotalIncome.GotFocusColour = System.Drawing.Color.White
        Me.txtBtotalIncome.Location = New System.Drawing.Point(128, 112)
        Me.txtBtotalIncome.LostFocusColour = System.Drawing.Color.White
        Me.txtBtotalIncome.MaxLength = 10
        Me.txtBtotalIncome.MaxValue = 999999999
        Me.txtBtotalIncome.MinValue = 0
        Me.txtBtotalIncome.Name = "txtBtotalIncome"
        Me.txtBtotalIncome.ReadOnly = True
        Me.txtBtotalIncome.Size = New System.Drawing.Size(128, 22)
        Me.txtBtotalIncome.TabIndex = 39
        Me.txtBtotalIncome.Text = ""
        '
        'txtBotherIncome
        '
        Me.txtBotherIncome.AfterDecimal = 0
        Me.txtBotherIncome.BeforeDecimal = 8
        Me.txtBotherIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotherIncome.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBotherIncome.Location = New System.Drawing.Point(128, 80)
        Me.txtBotherIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBotherIncome.MaxLength = 10
        Me.txtBotherIncome.MaxValue = 999999999
        Me.txtBotherIncome.MinValue = 0
        Me.txtBotherIncome.Name = "txtBotherIncome"
        Me.txtBotherIncome.Size = New System.Drawing.Size(128, 22)
        Me.txtBotherIncome.TabIndex = 38
        Me.txtBotherIncome.Text = ""
        '
        'txtBRent
        '
        Me.txtBRent.AfterDecimal = 0
        Me.txtBRent.BeforeDecimal = 8
        Me.txtBRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRent.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBRent.Location = New System.Drawing.Point(128, 48)
        Me.txtBRent.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBRent.MaxLength = 10
        Me.txtBRent.MaxValue = 999999999
        Me.txtBRent.MinValue = 0
        Me.txtBRent.Name = "txtBRent"
        Me.txtBRent.Size = New System.Drawing.Size(128, 22)
        Me.txtBRent.TabIndex = 37
        Me.txtBRent.Text = ""
        '
        'txtBIncome
        '
        Me.txtBIncome.AfterDecimal = 0
        Me.txtBIncome.BeforeDecimal = 8
        Me.txtBIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBIncome.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBIncome.Location = New System.Drawing.Point(128, 16)
        Me.txtBIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBIncome.MaxLength = 10
        Me.txtBIncome.MaxValue = 999999999
        Me.txtBIncome.MinValue = 0
        Me.txtBIncome.Name = "txtBIncome"
        Me.txtBIncome.Size = New System.Drawing.Size(128, 22)
        Me.txtBIncome.TabIndex = 36
        Me.txtBIncome.Text = ""
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(8, 112)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(104, 16)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "Total Income"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(8, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(120, 16)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Monthly Income"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(8, 48)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 16)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Rent"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(8, 80)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 16)
        Me.Label51.TabIndex = 1
        Me.Label51.Text = "Other Income"
        '
        'chkBusiness1
        '
        Me.chkBusiness1.Enabled = False
        Me.chkBusiness1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBusiness1.Location = New System.Drawing.Point(304, 24)
        Me.chkBusiness1.Name = "chkBusiness1"
        Me.chkBusiness1.Size = New System.Drawing.Size(136, 24)
        Me.chkBusiness1.TabIndex = 34
        Me.chkBusiness1.Text = "Business Person"
        '
        'pnlSalary
        '
        Me.pnlSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalary.Controls.Add(Me.txtSTotalExpenses)
        Me.pnlSalary.Controls.Add(Me.Label25)
        Me.pnlSalary.Controls.Add(Me.txtSTotalIncome)
        Me.pnlSalary.Controls.Add(Me.txtSOtherIncome)
        Me.pnlSalary.Controls.Add(Me.txtSRent)
        Me.pnlSalary.Controls.Add(Me.txtSSalary)
        Me.pnlSalary.Controls.Add(Me.Label47)
        Me.pnlSalary.Controls.Add(Me.Label44)
        Me.pnlSalary.Controls.Add(Me.Label45)
        Me.pnlSalary.Controls.Add(Me.Label46)
        Me.pnlSalary.Controls.Add(Me.txtTotalSaving)
        Me.pnlSalary.Controls.Add(Me.Label52)
        Me.pnlSalary.Location = New System.Drawing.Point(16, 48)
        Me.pnlSalary.Name = "pnlSalary"
        Me.pnlSalary.Size = New System.Drawing.Size(264, 208)
        Me.pnlSalary.TabIndex = 27
        '
        'txtSTotalExpenses
        '
        Me.txtSTotalExpenses.AfterDecimal = 0
        Me.txtSTotalExpenses.BeforeDecimal = 8
        Me.txtSTotalExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTotalExpenses.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSTotalExpenses.Location = New System.Drawing.Point(120, 144)
        Me.txtSTotalExpenses.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSTotalExpenses.MaxLength = 10
        Me.txtSTotalExpenses.MaxValue = 99999999
        Me.txtSTotalExpenses.MinValue = 0
        Me.txtSTotalExpenses.Name = "txtSTotalExpenses"
        Me.txtSTotalExpenses.Size = New System.Drawing.Size(128, 22)
        Me.txtSTotalExpenses.TabIndex = 32
        Me.txtSTotalExpenses.Text = ""
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 144)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 16)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Total Expenses"
        '
        'txtSTotalIncome
        '
        Me.txtSTotalIncome.AfterDecimal = 0
        Me.txtSTotalIncome.BackColor = System.Drawing.Color.White
        Me.txtSTotalIncome.BeforeDecimal = 9
        Me.txtSTotalIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTotalIncome.GotFocusColour = System.Drawing.Color.White
        Me.txtSTotalIncome.Location = New System.Drawing.Point(120, 112)
        Me.txtSTotalIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSTotalIncome.MaxLength = 10
        Me.txtSTotalIncome.MaxValue = 99999999
        Me.txtSTotalIncome.MinValue = 0
        Me.txtSTotalIncome.Name = "txtSTotalIncome"
        Me.txtSTotalIncome.ReadOnly = True
        Me.txtSTotalIncome.Size = New System.Drawing.Size(128, 22)
        Me.txtSTotalIncome.TabIndex = 31
        Me.txtSTotalIncome.Text = ""
        '
        'txtSOtherIncome
        '
        Me.txtSOtherIncome.AfterDecimal = 0
        Me.txtSOtherIncome.BeforeDecimal = 8
        Me.txtSOtherIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOtherIncome.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtSOtherIncome.Location = New System.Drawing.Point(120, 80)
        Me.txtSOtherIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSOtherIncome.MaxLength = 10
        Me.txtSOtherIncome.MaxValue = 99999999
        Me.txtSOtherIncome.MinValue = 0
        Me.txtSOtherIncome.Name = "txtSOtherIncome"
        Me.txtSOtherIncome.Size = New System.Drawing.Size(128, 22)
        Me.txtSOtherIncome.TabIndex = 30
        Me.txtSOtherIncome.Text = ""
        '
        'txtSRent
        '
        Me.txtSRent.AfterDecimal = 0
        Me.txtSRent.BeforeDecimal = 8
        Me.txtSRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRent.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtSRent.Location = New System.Drawing.Point(120, 48)
        Me.txtSRent.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSRent.MaxLength = 10
        Me.txtSRent.MaxValue = 99999999
        Me.txtSRent.MinValue = 0
        Me.txtSRent.Name = "txtSRent"
        Me.txtSRent.Size = New System.Drawing.Size(128, 22)
        Me.txtSRent.TabIndex = 29
        Me.txtSRent.Text = ""
        '
        'txtSSalary
        '
        Me.txtSSalary.AfterDecimal = 0
        Me.txtSSalary.BeforeDecimal = 8
        Me.txtSSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSalary.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtSSalary.Location = New System.Drawing.Point(120, 16)
        Me.txtSSalary.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSSalary.MaxLength = 10
        Me.txtSSalary.MaxValue = 99999999
        Me.txtSSalary.MinValue = 0
        Me.txtSSalary.Name = "txtSSalary"
        Me.txtSSalary.Size = New System.Drawing.Size(128, 22)
        Me.txtSSalary.TabIndex = 28
        Me.txtSSalary.Text = ""
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(8, 112)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(104, 16)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Total Income"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(8, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Salary"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(8, 48)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 16)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Rent"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(8, 80)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(104, 16)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "Other Income"
        '
        'txtTotalSaving
        '
        Me.txtTotalSaving.AfterDecimal = 0
        Me.txtTotalSaving.BackColor = System.Drawing.Color.White
        Me.txtTotalSaving.BeforeDecimal = 9
        Me.txtTotalSaving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSaving.GotFocusColour = System.Drawing.Color.White
        Me.txtTotalSaving.Location = New System.Drawing.Point(120, 176)
        Me.txtTotalSaving.LostFocusColour = System.Drawing.Color.White
        Me.txtTotalSaving.MaxLength = 10
        Me.txtTotalSaving.MaxValue = 99999999
        Me.txtTotalSaving.MinValue = 0
        Me.txtTotalSaving.Name = "txtTotalSaving"
        Me.txtTotalSaving.ReadOnly = True
        Me.txtTotalSaving.Size = New System.Drawing.Size(128, 22)
        Me.txtTotalSaving.TabIndex = 33
        Me.txtTotalSaving.Text = ""
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(8, 176)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(104, 16)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "Total Savings"
        '
        'chkSalary1
        '
        Me.chkSalary1.Enabled = False
        Me.chkSalary1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalary1.Location = New System.Drawing.Point(16, 24)
        Me.chkSalary1.Name = "chkSalary1"
        Me.chkSalary1.Size = New System.Drawing.Size(136, 24)
        Me.chkSalary1.TabIndex = 26
        Me.chkSalary1.Text = "Salaried Person"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Beige
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.txtImmovableDet)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.txtOthers)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(672, 323)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Responsiblity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOrgResp)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPersonResp)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtBankResp)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 184)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liabilities To"
        '
        'txtOrgResp
        '
        Me.txtOrgResp.AlphaNumeric = True
        Me.txtOrgResp.AutoSize = False
        Me.txtOrgResp.BlankSpace = False
        Me.txtOrgResp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrgResp.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtOrgResp.Location = New System.Drawing.Point(132, 60)
        Me.txtOrgResp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOrgResp.Mandatory = False
        Me.txtOrgResp.MaxLength = 30
        Me.txtOrgResp.Name = "txtOrgResp"
        Me.txtOrgResp.Size = New System.Drawing.Size(168, 24)
        Me.txtOrgResp.SpecialChar = False
        Me.txtOrgResp.TabIndex = 2
        Me.txtOrgResp.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 17)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Other Institutions: "
        '
        'txtPersonResp
        '
        Me.txtPersonResp.AlphaNumeric = True
        Me.txtPersonResp.AutoSize = False
        Me.txtPersonResp.BlankSpace = False
        Me.txtPersonResp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonResp.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtPersonResp.Location = New System.Drawing.Point(132, 100)
        Me.txtPersonResp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPersonResp.Mandatory = False
        Me.txtPersonResp.MaxLength = 30
        Me.txtPersonResp.Name = "txtPersonResp"
        Me.txtPersonResp.Size = New System.Drawing.Size(168, 24)
        Me.txtPersonResp.SpecialChar = False
        Me.txtPersonResp.TabIndex = 3
        Me.txtPersonResp.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Individuals:   "
        '
        'txtTotal
        '
        Me.txtTotal.AlphaNumeric = True
        Me.txtTotal.AutoSize = False
        Me.txtTotal.BlankSpace = False
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtTotal.Location = New System.Drawing.Point(132, 140)
        Me.txtTotal.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotal.Mandatory = False
        Me.txtTotal.MaxLength = 30
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(168, 24)
        Me.txtTotal.SpecialChar = False
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 17)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Total: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 17)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "The Sahakari:  "
        '
        'txtBankResp
        '
        Me.txtBankResp.AlphaNumeric = True
        Me.txtBankResp.AutoSize = False
        Me.txtBankResp.BlankSpace = False
        Me.txtBankResp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankResp.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBankResp.Location = New System.Drawing.Point(132, 20)
        Me.txtBankResp.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankResp.Mandatory = False
        Me.txtBankResp.MaxLength = 30
        Me.txtBankResp.Name = "txtBankResp"
        Me.txtBankResp.Size = New System.Drawing.Size(168, 24)
        Me.txtBankResp.SpecialChar = False
        Me.txtBankResp.TabIndex = 1
        Me.txtBankResp.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(336, 224)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 40)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "Details Of Immovable Property"
        '
        'txtImmovableDet
        '
        Me.txtImmovableDet.AlphaNumeric = True
        Me.txtImmovableDet.AutoSize = False
        Me.txtImmovableDet.BackColor = System.Drawing.Color.White
        Me.txtImmovableDet.BlankSpace = False
        Me.txtImmovableDet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImmovableDet.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtImmovableDet.Location = New System.Drawing.Point(464, 216)
        Me.txtImmovableDet.LostFocusColour = System.Drawing.Color.Empty
        Me.txtImmovableDet.Mandatory = False
        Me.txtImmovableDet.MaxLength = 100
        Me.txtImmovableDet.Multiline = True
        Me.txtImmovableDet.Name = "txtImmovableDet"
        Me.txtImmovableDet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImmovableDet.Size = New System.Drawing.Size(176, 56)
        Me.txtImmovableDet.SpecialChar = True
        Me.txtImmovableDet.TabIndex = 10
        Me.txtImmovableDet.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtBankName)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtLoanType)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(344, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 184)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Surety Liability In The Sahakari"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.AfterDecimal = 0
        Me.txtLoanAmount.BeforeDecimal = 8
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtLoanAmount.Location = New System.Drawing.Point(112, 112)
        Me.txtLoanAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLoanAmount.MaxLength = 10
        Me.txtLoanAmount.MaxValue = 99999999
        Me.txtLoanAmount.MinValue = 0
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(168, 22)
        Me.txtLoanAmount.TabIndex = 8
        Me.txtLoanAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Name: "
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.AutoSize = False
        Me.txtBankName.BlankSpace = False
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtBankName.Location = New System.Drawing.Point(112, 32)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 30
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(168, 24)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 6
        Me.txtBankName.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 17)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "Type Of Loan: "
        '
        'txtLoanType
        '
        Me.txtLoanType.AlphaNumeric = True
        Me.txtLoanType.AutoSize = False
        Me.txtLoanType.BlankSpace = False
        Me.txtLoanType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanType.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtLoanType.Location = New System.Drawing.Point(112, 72)
        Me.txtLoanType.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLoanType.Mandatory = False
        Me.txtLoanType.MaxLength = 30
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(168, 24)
        Me.txtLoanType.SpecialChar = True
        Me.txtLoanType.TabIndex = 7
        Me.txtLoanType.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 17)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Loan Sanctioned:  "
        '
        'txtOthers
        '
        Me.txtOthers.AlphaNumeric = True
        Me.txtOthers.AutoSize = False
        Me.txtOthers.BlankSpace = False
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtOthers.Location = New System.Drawing.Point(152, 216)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.Mandatory = False
        Me.txtOthers.MaxLength = 100
        Me.txtOthers.Multiline = True
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(176, 56)
        Me.txtOthers.SpecialChar = True
        Me.txtOthers.TabIndex = 9
        Me.txtOthers.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 216)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 17)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Any Other Particulars :"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Beige
        Me.TabPage4.Controls.Add(Me.btnPhotoLoad)
        Me.TabPage4.Controls.Add(Me.btnPhotoCancel)
        Me.TabPage4.Controls.Add(Me.picSignature)
        Me.TabPage4.Controls.Add(Me.lblSignature)
        Me.TabPage4.Controls.Add(Me.picPhoto)
        Me.TabPage4.Controls.Add(Me.lblPhoto)
        Me.TabPage4.Controls.Add(Me.btnSignCancel)
        Me.TabPage4.Controls.Add(Me.btnSignLoad)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(672, 323)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other"
        '
        'btnPhotoLoad
        '
        Me.btnPhotoLoad.BackColor = System.Drawing.Color.Beige
        Me.btnPhotoLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoLoad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoLoad.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoLoad.GotFocusColour = System.Drawing.Color.Tan
        Me.btnPhotoLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhotoLoad.Location = New System.Drawing.Point(112, 240)
        Me.btnPhotoLoad.LostFocusColour = System.Drawing.Color.Beige
        Me.btnPhotoLoad.Name = "btnPhotoLoad"
        Me.btnPhotoLoad.Size = New System.Drawing.Size(80, 32)
        Me.btnPhotoLoad.TabIndex = 52
        Me.btnPhotoLoad.Text = "Load"
        '
        'btnPhotoCancel
        '
        Me.btnPhotoCancel.BackColor = System.Drawing.Color.Beige
        Me.btnPhotoCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoCancel.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnPhotoCancel.Location = New System.Drawing.Point(192, 240)
        Me.btnPhotoCancel.LostFocusColour = System.Drawing.Color.Beige
        Me.btnPhotoCancel.Name = "btnPhotoCancel"
        Me.btnPhotoCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnPhotoCancel.TabIndex = 53
        Me.btnPhotoCancel.Text = "Cancel"
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(432, 40)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(160, 184)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 59
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(360, 40)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(67, 17)
        Me.lblSignature.TabIndex = 58
        Me.lblSignature.Text = "Signature : "
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(112, 40)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 184)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 57
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(56, 40)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(44, 17)
        Me.lblPhoto.TabIndex = 56
        Me.lblPhoto.Text = "Photo :"
        '
        'btnSignCancel
        '
        Me.btnSignCancel.BackColor = System.Drawing.Color.Beige
        Me.btnSignCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignCancel.ForeColor = System.Drawing.Color.Black
        Me.btnSignCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnSignCancel.Location = New System.Drawing.Point(512, 240)
        Me.btnSignCancel.LostFocusColour = System.Drawing.Color.Beige
        Me.btnSignCancel.Name = "btnSignCancel"
        Me.btnSignCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnSignCancel.TabIndex = 55
        Me.btnSignCancel.Text = "Cancel"
        '
        'btnSignLoad
        '
        Me.btnSignLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignLoad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignLoad.ForeColor = System.Drawing.Color.Black
        Me.btnSignLoad.GotFocusColour = System.Drawing.Color.Tan
        Me.btnSignLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignLoad.Location = New System.Drawing.Point(432, 240)
        Me.btnSignLoad.LostFocusColour = System.Drawing.Color.Beige
        Me.btnSignLoad.Name = "btnSignLoad"
        Me.btnSignLoad.Size = New System.Drawing.Size(80, 32)
        Me.btnSignLoad.TabIndex = 54
        Me.btnSignLoad.Text = "Load"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.btnCustomerSearch)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.btnSBSearch)
        Me.Panel7.Controls.Add(Me.txtSBNo)
        Me.Panel7.Controls.Add(Me.Label63)
        Me.Panel7.Controls.Add(Me.lblNomineeNo)
        Me.Panel7.Controls.Add(Me.txtSuretyNo)
        Me.Panel7.Controls.Add(Me.txtCustomerNo)
        Me.Panel7.Controls.Add(Me.lblName)
        Me.Panel7.Controls.Add(Me.txtSuretyPersonName)
        Me.Panel7.Controls.Add(Me.lblDeclaration)
        Me.Panel7.Controls.Add(Me.txtLoanNo)
        Me.Panel7.Controls.Add(Me.btnSearch)
        Me.Panel7.Controls.Add(Me.txtLoanerName)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.txtDeclaration)
        Me.Panel7.Controls.Add(Me.lblRecords)
        Me.Panel7.Location = New System.Drawing.Point(8, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(680, 168)
        Me.Panel7.TabIndex = 0
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerSearch.ForeColor = System.Drawing.Color.Black
        Me.btnCustomerSearch.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnCustomerSearch.Image = CType(resources.GetObject("btnCustomerSearch.Image"), System.Drawing.Image)
        Me.btnCustomerSearch.Location = New System.Drawing.Point(632, 48)
        Me.btnCustomerSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnCustomerSearch.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Customer No. "
        '
        'btnSBSearch
        '
        Me.btnSBSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSBSearch.GotFocusColour = System.Drawing.Color.LightGray
        Me.btnSBSearch.Image = CType(resources.GetObject("btnSBSearch.Image"), System.Drawing.Image)
        Me.btnSBSearch.Location = New System.Drawing.Point(632, 80)
        Me.btnSBSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(239, Byte), CType(237, Byte), CType(220, Byte))
        Me.btnSBSearch.Name = "btnSBSearch"
        Me.btnSBSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSBSearch.TabIndex = 9
        '
        'txtSBNo
        '
        Me.txtSBNo.AlphaNumeric = True
        Me.txtSBNo.BlankSpace = True
        Me.txtSBNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBNo.Location = New System.Drawing.Point(472, 80)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.Size = New System.Drawing.Size(152, 23)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 8
        Me.txtSBNo.Text = ""
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(368, 80)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(62, 19)
        Me.Label63.TabIndex = 94
        Me.Label63.Text = "SB No. :"
        '
        'lblNomineeNo
        '
        Me.lblNomineeNo.AutoSize = True
        Me.lblNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomineeNo.Location = New System.Drawing.Point(8, 80)
        Me.lblNomineeNo.Name = "lblNomineeNo"
        Me.lblNomineeNo.Size = New System.Drawing.Size(43, 19)
        Me.lblNomineeNo.TabIndex = 90
        Me.lblNomineeNo.Text = " No. :"
        '
        'txtSuretyNo
        '
        Me.txtSuretyNo.AlphaNumeric = False
        Me.txtSuretyNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtSuretyNo.BlankSpace = False
        Me.txtSuretyNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuretyNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtSuretyNo.Location = New System.Drawing.Point(168, 80)
        Me.txtSuretyNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtSuretyNo.Mandatory = False
        Me.txtSuretyNo.Name = "txtSuretyNo"
        Me.txtSuretyNo.ReadOnly = True
        Me.txtSuretyNo.Size = New System.Drawing.Size(64, 23)
        Me.txtSuretyNo.SpecialChar = False
        Me.txtSuretyNo.TabIndex = 91
        Me.txtSuretyNo.TabStop = False
        Me.txtSuretyNo.Text = ""
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.AlphaNumeric = True
        Me.txtCustomerNo.BlankSpace = True
        Me.txtCustomerNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerNo.Location = New System.Drawing.Point(472, 48)
        Me.txtCustomerNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCustomerNo.Mandatory = False
        Me.txtCustomerNo.MaxLength = 10
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.Size = New System.Drawing.Size(152, 23)
        Me.txtCustomerNo.SpecialChar = False
        Me.txtCustomerNo.TabIndex = 5
        Me.txtCustomerNo.Text = "CID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(8, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(154, 19)
        Me.lblName.TabIndex = 88
        Me.lblName.Text = "Surety Person Name :"
        '
        'txtSuretyPersonName
        '
        Me.txtSuretyPersonName.AlphaNumeric = True
        Me.txtSuretyPersonName.AutoSize = False
        Me.txtSuretyPersonName.BlankSpace = False
        Me.txtSuretyPersonName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuretyPersonName.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtSuretyPersonName.Location = New System.Drawing.Point(168, 48)
        Me.txtSuretyPersonName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSuretyPersonName.Mandatory = False
        Me.txtSuretyPersonName.MaxLength = 30
        Me.txtSuretyPersonName.Name = "txtSuretyPersonName"
        Me.txtSuretyPersonName.Size = New System.Drawing.Size(188, 20)
        Me.txtSuretyPersonName.SpecialChar = True
        Me.txtSuretyPersonName.TabIndex = 4
        Me.txtSuretyPersonName.Text = ""
        '
        'lblDeclaration
        '
        Me.lblDeclaration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeclaration.Location = New System.Drawing.Point(8, 112)
        Me.lblDeclaration.Name = "lblDeclaration"
        Me.lblDeclaration.Size = New System.Drawing.Size(104, 32)
        Me.lblDeclaration.TabIndex = 86
        Me.lblDeclaration.Text = "Surety Person Declaration :"
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = False
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtLoanNo.Location = New System.Drawing.Point(168, 16)
        Me.txtLoanNo.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 10
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.Size = New System.Drawing.Size(156, 23)
        Me.txtLoanNo.SpecialChar = False
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Beige
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Tan
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(328, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Visible = False
        '
        'txtLoanerName
        '
        Me.txtLoanerName.AlphaNumeric = True
        Me.txtLoanerName.AutoSize = False
        Me.txtLoanerName.BackColor = System.Drawing.Color.White
        Me.txtLoanerName.BlankSpace = False
        Me.txtLoanerName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanerName.GotFocusColour = System.Drawing.Color.White
        Me.txtLoanerName.Location = New System.Drawing.Point(472, 16)
        Me.txtLoanerName.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanerName.Mandatory = False
        Me.txtLoanerName.MaxLength = 30
        Me.txtLoanerName.Name = "txtLoanerName"
        Me.txtLoanerName.ReadOnly = True
        Me.txtLoanerName.Size = New System.Drawing.Size(156, 20)
        Me.txtLoanerName.SpecialChar = True
        Me.txtLoanerName.TabIndex = 3
        Me.txtLoanerName.TabStop = False
        Me.txtLoanerName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Loan No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Loaner Name:"
        '
        'txtDeclaration
        '
        Me.txtDeclaration.AlphaNumeric = True
        Me.txtDeclaration.AutoSize = False
        Me.txtDeclaration.BlankSpace = False
        Me.txtDeclaration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeclaration.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtDeclaration.Location = New System.Drawing.Point(168, 112)
        Me.txtDeclaration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDeclaration.Mandatory = False
        Me.txtDeclaration.MaxLength = 100
        Me.txtDeclaration.Multiline = True
        Me.txtDeclaration.Name = "txtDeclaration"
        Me.txtDeclaration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDeclaration.Size = New System.Drawing.Size(424, 48)
        Me.txtDeclaration.SpecialChar = True
        Me.txtDeclaration.TabIndex = 10
        Me.txtDeclaration.Text = ""
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(72, 128)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(0, 19)
        Me.lblRecords.TabIndex = 67
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Beige
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.Tan
        Me.btnOk.Location = New System.Drawing.Point(488, 560)
        Me.btnOk.LostFocusColour = System.Drawing.Color.Beige
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 37
        Me.btnOk.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Beige
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Tan
        Me.btnCancel.Location = New System.Drawing.Point(584, 560)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "&Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Beige
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.Tan
        Me.btnAdd.Location = New System.Drawing.Point(16, 560)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.Beige
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 40)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "&New "
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Beige
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.GotFocusColour = System.Drawing.Color.Tan
        Me.btnDelete.Location = New System.Drawing.Point(104, 560)
        Me.btnDelete.LostFocusColour = System.Drawing.Color.Beige
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 40)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "&Delete"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Beige
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.GotFocusColour = System.Drawing.Color.Tan
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(272, 560)
        Me.btnPrevious.LostFocusColour = System.Drawing.Color.Beige
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(48, 40)
        Me.btnPrevious.TabIndex = 63
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Beige
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.GotFocusColour = System.Drawing.Color.Tan
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(344, 560)
        Me.btnNext.LostFocusColour = System.Drawing.Color.Beige
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 40)
        Me.btnNext.TabIndex = 62
        '
        'frmHomeLoanSurety
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Beige
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(696, 605)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHomeLoanSurety"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Surety Person Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlSalariedDet.ResumeLayout(False)
        Me.pnlBusinessDet.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlBusiness.ResumeLayout(False)
        Me.pnlSalary.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objHomeSurety As New clsHomeLoanSurety
    Dim objMember As New clsMember

    Dim intNo As Integer = 0
    Dim objDT As DataTable
    Public chrType As Char
    Dim objSBAccount1 As New clsSavingsBank
    Dim objPerson As New clsPerson
    Dim lngPersonNo As Long = 0
    Dim _dtSBNO As DataTable
#End Region


#Region "Funcitons"

    Sub sbSetColor()

        '        objfrmSurety.BackColor = GroupBox1.BackColor
        TabPage1.BackColor = Me.BackColor
        TabPage2.BackColor = Me.BackColor
        TabPage3.BackColor = Me.BackColor
        TabPage4.BackColor = Me.BackColor

        btnSearch.BackColor = Me.BackColor
        btnCancel.BackColor = Me.BackColor
        btnOk.BackColor = Me.BackColor
        btnCustomerSearch.BackColor = Me.BackColor
        btnSBSearch.BackColor = Me.BackColor

        btnSearch.GotFocusColour = btnOk.GotFocusColour
        btnCancel.GotFocusColour = btnOk.GotFocusColour
        btnCustomerSearch.GotFocusColour = btnOk.GotFocusColour
        btnSBSearch.GotFocusColour = btnOk.GotFocusColour

        btnSearch.LostFocusColour = Me.BackColor
        btnCancel.LostFocusColour = Me.BackColor
        btnOk.LostFocusColour = Me.BackColor
        btnCustomerSearch.LostFocusColour = Me.BackColor
        btnSBSearch.LostFocusColour = Me.BackColor

        btnAdd.BackColor = Me.BackColor
        btnDelete.BackColor = Me.BackColor
        btnPrevious.BackColor = Me.BackColor
        btnNext.BackColor = Me.BackColor

        btnAdd.GotFocusColour = btnOk.GotFocusColour
        btnDelete.GotFocusColour = btnOk.GotFocusColour
        btnPrevious.GotFocusColour = btnOk.GotFocusColour
        btnNext.GotFocusColour = btnOk.GotFocusColour

        btnAdd.LostFocusColour = Me.BackColor
        btnDelete.LostFocusColour = Me.BackColor
        btnPrevious.LostFocusColour = Me.BackColor
        btnNext.LostFocusColour = Me.BackColor

        btnPhotoCancel.BackColor = Me.BackColor
        btnPhotoLoad.BackColor = Me.BackColor
        btnSignCancel.BackColor = Me.BackColor
        btnSignLoad.BackColor = Me.BackColor

        btnPhotoCancel.LostFocusColour = Me.BackColor
        btnPhotoLoad.LostFocusColour = Me.BackColor
        btnSignCancel.LostFocusColour = Me.BackColor
        btnSignLoad.LostFocusColour = Me.BackColor

        btnPhotoLoad.GotFocusColour = btnOk.GotFocusColour
        btnSignLoad.GotFocusColour = btnOk.GotFocusColour

    End Sub


    Sub sbLoadMember()
        Dim objDT As DataTable
        Dim flag As Boolean = False

        If txtCustomerNo.Text <> "" Then
            If objMember.fnGetMemberDetails(txtCustomerNo.Text) Then
                objDT = objMember.MemberTable
                flag = True
            End If
        ElseIf txtSBNo.Text <> "" Then
            objSBAccount1.fnGetSBAccountDetails(txtSBNo.Text)
            objDT = objSBAccount1.SBAccTable
        End If
        fnClearData()

        If objDT.Rows.Count > 0 Then

            txtCustomerNo.Text = objDT.Rows(0).Item("MemberNo")
            If flag Then
                If objSBAccount1.fnGetSBDetal(txtCustomerNo.Text) Then
                    txtSBNo.Text = objSBAccount1.SBAccTable.Rows(0).Item("AccountNo")
                End If
                btnSBSearch.Enabled = False
            Else
                txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
                btnCustomerSearch.Enabled = False
            End If
            txtSuretyPersonName.Text = objDT.Rows(0).Item("Name")
            txtFatherName.Text = objDT.Rows(0).Item("FatherName")
            dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
            txtAge.Text = objDT.Rows(0).Item("Age")
            IIf(objDT.Rows(0).Item("Age") > 18, rdbMajor.Checked = True, rdbMinor.Checked = True)
            IIf(objDT.Rows(0).Item("Gender") = "M", rdbMale.Checked = True, rdbFemale.Checked = True)
            txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")

        End If

    End Sub

    Sub sbGeneral()
        Dim msStream As MemoryStream
        Dim objDT As DataTable
        Dim flag As Boolean = False
        Try
            If txtCustomerNo.Text <> "" Then
                If objPerson.fnGetCustomerID(txtCustomerNo.Text) Then
                    objDT = objPerson.PersonTable
                    flag = True
                End If
                'ElseIf txtSBNo.Text <> "" Then
                '    objSBAccount1.fnGetSBAccountDetails(txtSBNo.Text)
                '    objDT = objSBAccount1.SBAccTable
            End If
            'sbClear()
            If objDT.Rows.Count > 0 Then

                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                txtCustomerNo.Text = objDT.Rows(0).Item("CustomerID")
                'If flag Then
                '   If objSBAccount1.fnGetSBDetal(txtCustomerID.Text) Then
                '        txtSBNo.Text = objSBAccount1.SBAccTable.Rows(0).Item("AccountNo")
                '    End If
                '    ' btnSBSearch.Enabled = False
                '    'Else
                '    '    txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
                '    '    btnMemSearch.Enabled = False
                'End If

                'txtSBNo.ReadOnly = True
                'txtMemberNo.ReadOnly = True
              

                txtSuretyPersonName.Text = objDT.Rows(0).Item("Name")
                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")
                IIf(objDT.Rows(0).Item("Gender") = "M", rdbMale.Checked = True, rdbFemale.Checked = True)
                ' cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                '   cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                '   cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                ' txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                '  txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")
                ' OfficeNo = objDT.Rows(0).Item("OfficeNo")



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
                _dtSBNO = objSBAccount1.fnGetSBNO(txtCustomerNo.Text)
                If (_dtSBNO.Rows.Count > 0) Then
                    txtSBNo.Text = objSBAccount1.SBAccTable.Rows(0).Item("AccountNo")
                End If
                txtLoanerName.Focus()
            End If


        Catch ex As Exception
        End Try


    End Sub

    Public Function fnSetData() As Boolean

        objHomeSurety.SBNo = txtSBNo.Text
        objHomeSurety.No = txtSuretyNo.Text
        objHomeSurety.LoanNo = txtLoanNo.Text
        objHomeSurety.Name = txtSuretyPersonName.Text
        objHomeSurety.PhoneNo = txtMobileNo.Text
        objHomeSurety.CustomerNO = txtCustomerNo.Text
        objHomeSurety.FatherName = txtFatherName.Text
        objHomeSurety.PermAddress = txtPermAddress.Text
        objHomeSurety.DOB = Format(dtpDOB.Value, "yyyy-MM-dd")
        objHomeSurety.Age = txtAge.Text
        objHomeSurety.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objHomeSurety.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objHomeSurety.Type = chrType
        If txtService.Text = "" Then
            objHomeSurety.NoOfService = 0
        Else
            objHomeSurety.NoOfService = txtService.Text
        End If

        objHomeSurety.SalariedPersonDet = txtSalariedPersonDet.Text
        objHomeSurety.BusinessPersonDet = txtBusinessPersonDet.Text
        objHomeSurety.Relationship = txtRelationship.Text
        objHomeSurety.immovablePeropertyDet = txtImmovableDet.Text

        If chkSalary.Checked = True Then
            objHomeSurety.SalariedPerson = "Y"
            objHomeSurety.SSalary = Val(txtSSalary.Text)
            objHomeSurety.SRent = Val(txtSRent.Text)
            objHomeSurety.SOtherIncome = Val(txtSOtherIncome.Text)
            objHomeSurety.STotalIncome = Val(txtSTotalIncome.Text)
            objHomeSurety.SExpenses = Val(txtSTotalExpenses.Text)
            objHomeSurety.STotalSavings = Val(txtTotalSaving.Text)
        Else
            objHomeSurety.SalariedPerson = "N"
            objHomeSurety.SSalary = 0
            objHomeSurety.SRent = 0
            objHomeSurety.SOtherIncome = 0
            objHomeSurety.STotalIncome = 0
            objHomeSurety.SExpenses = 0
            objHomeSurety.STotalSavings = 0
        End If

        If chkBusiness.Checked = True Then
            objHomeSurety.BusinessPerson = "Y"
            objHomeSurety.BMonthlyIncome = Val(txtBIncome.Text)
            objHomeSurety.BRent = Val(txtBRent.Text)
            objHomeSurety.BotherIncome = Val(txtBotherIncome.Text)
            objHomeSurety.BTotalIncome = Val(txtBtotalIncome.Text)
            objHomeSurety.BExpenses = Val(txtBTotalExpenses.Text)
            objHomeSurety.BTotalSavings = Val(txtBTotalSavings.Text)
        Else
            objHomeSurety.BusinessPerson = "N"
            objHomeSurety.BMonthlyIncome = 0
            objHomeSurety.BRent = 0
            objHomeSurety.BotherIncome = 0
            objHomeSurety.BTotalIncome = 0
            objHomeSurety.BExpenses = 0
            objHomeSurety.BTotalSavings = 0
        End If

        objHomeSurety.BankResp = txtBankResp.Text
        objHomeSurety.OrgResp = txtOrgResp.Text
        objHomeSurety.PersonResp = txtPersonResp.Text
        objHomeSurety.TotalResp = txtTotal.Text
        objHomeSurety.BankName = txtBankName.Text
        objHomeSurety.LoanType = txtLoanType.Text
        objHomeSurety.IncomeTaxDet = txtIncomeTax.Text

        If txtLoanAmount.Text = "" Then
            objHomeSurety.LoanAmount = 0
        Else
            objHomeSurety.LoanAmount = txtLoanAmount.Text
        End If

        objHomeSurety.OtherParticulars = txtOthers.Text
        objHomeSurety.Declaration = txtDeclaration.Text

        objHomeSurety.Photo = fnGetPhoto()
        objHomeSurety.Sign = fnGetSign()

        Return True

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
                Dim bytArr1() As Byte
                picSignature.Image.Save(msStream, picSignature.Image.RawFormat)
                bytArr1 = msStream.GetBuffer
                msStream.Close()
                Return bytArr1
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function fnCheckSurety() As Boolean
        If objHomeSurety.fnGetSurety(Trim(txtLoanNo.Text), chrType) Then
            objDT = objHomeSurety.CheckSuretytable
            intNo = 0
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnLoadSuretyDet() As Boolean

        Dim msStream As New MemoryStream
        If Not objDT Is Nothing Then
            If intNo >= objDT.Rows.Count Then
                Exit Function
            End If
        Else
            Exit Function
        End If
        fnClearData()
        'lblRecords.Text = "Record " & intNo + 1 & " of " & objDT.Rows.Count

        txtSuretyNo.Text = objDT.Rows(intNo).Item("No")
        txtSuretyPersonName.Text = objDT.Rows(intNo).Item("Name")
        txtFatherName.Text = objDT.Rows(intNo).Item("FatherName")
        dtpDOB.Value = CDate(objDT.Rows(intNo).Item("DOB"))
        txtAge.Text = objDT.Rows(intNo).Item("Age")
        IIf(objDT.Rows(intNo).Item("Gender") = "M", rdbMale.Checked = True, rdbFemale.Checked = True)
        txtPermAddress.Text = objDT.Rows(intNo).Item("Address")
        txtSalariedPersonDet.Text = objDT.Rows(intNo).Item("OfficeAddress")
        txtCustomerNo.Text = objDT.Rows(intNo).Item("CustomerNo")
        txtMobileNo.Text = objDT.Rows(intNo).Item("PhoneNo")

        If objDT.Rows(intNo).Item("SalariedPerson") = "Y" Then
            chkSalary.Checked = True
            txtSSalary.Text = objDT.Rows(intNo).Item("SSalary")
            txtSRent.Text = objDT.Rows(0).Item("SRent")
            txtSOtherIncome.Text = objDT.Rows(intNo).Item("SOtherIncome")
            txtSTotalIncome.Text = objDT.Rows(intNo).Item("STotalIncome")
            txtSTotalExpenses.Text = objDT.Rows(intNo).Item("SExpenses")
            txtTotalSaving.Text = objDT.Rows(intNo).Item("STotalSavings")
        Else
            chkSalary.Checked = False
            txtSSalary.Text = objDT.Rows(intNo).Item("SSalary")
            txtSRent.Text = objDT.Rows(intNo).Item("SRent")
            txtSOtherIncome.Text = objDT.Rows(intNo).Item("SOtherIncome")
            txtSTotalIncome.Text = objDT.Rows(intNo).Item("STotalIncome")
            txtSTotalExpenses.Text = objDT.Rows(intNo).Item("SExpenses")
            txtTotalSaving.Text = objDT.Rows(intNo).Item("STotalSavings")

        End If

        If objDT.Rows(intNo).Item("BusinessPerson") = "Y" Then
            chkBusiness.Checked = True
            txtBIncome.Text = objDT.Rows(intNo).Item("BSalary")
            txtBRent.Text = objDT.Rows(intNo).Item("BRent")
            txtBotherIncome.Text = objDT.Rows(intNo).Item("BOtherIncome")
            txtBtotalIncome.Text = objDT.Rows(intNo).Item("BTotalIncome")
            txtBTotalExpenses.Text = objDT.Rows(intNo).Item("BExpenses")
            txtBTotalSavings.Text = objDT.Rows(intNo).Item("BTotalSaving")
        Else
            chkBusiness.Checked = False
            txtBIncome.Text = objDT.Rows(intNo).Item("BSalary")
            txtBRent.Text = objDT.Rows(intNo).Item("BRent")
            txtBotherIncome.Text = objDT.Rows(intNo).Item("BOtherIncome")
            txtBtotalIncome.Text = objDT.Rows(intNo).Item("BTotalIncome")
            txtBTotalExpenses.Text = objDT.Rows(intNo).Item("BExpenses")
            txtBTotalSavings.Text = objDT.Rows(intNo).Item("BTotalSaving")
        End If

        txtIncomeTax.Text = objDT.Rows(intNo).Item("IncomeTaxDetails")
        txtService.Text = objDT.Rows(intNo).Item("NoOfService")
        txtBusinessPersonDet.Text = objDT.Rows(intNo).Item("BusinessPersonDet")

        txtRelationship.Text = objDT.Rows(intNo).Item("Relation")
        txtImmovableDet.Text = objDT.Rows(intNo).Item("ImmovableProperty")
        txtBankResp.Text = objDT.Rows(intNo).Item("AnyBankResp")
        txtOrgResp.Text = objDT.Rows(intNo).Item("OrgResp")
        txtPersonResp.Text = objDT.Rows(intNo).Item("PersonResp")
        txtTotal.Text = objDT.Rows(intNo).Item("Total")
        txtBankName.Text = objDT.Rows(intNo).Item("BankName")
        txtLoanType.Text = objDT.Rows(intNo).Item("LoanType")
        txtLoanAmount.Text = objDT.Rows(intNo).Item("Amount")
        txtOthers.Text = objDT.Rows(intNo).Item("OtherParticulars")
        txtDeclaration.Text = objDT.Rows(intNo).Item("Declaration")

        If (IsDBNull(objDT.Rows(intNo).Item("SBAccountNo"))) Then
            txtSBNo.Text = ""
        Else
            txtSBNo.Text = objDT.Rows(intNo).Item("SBAccountNo")
        End If


        If Not IsDBNull(objDT.Rows(intNo).Item("Photo")) Then
            If objDT.Rows(intNo).Item("Photo").length > 0 Then
                msStream = New MemoryStream(objDT.Rows(intNo).Item("Photo"), True)
                msStream.Write(objDT.Rows(intNo).Item("Photo"), 0, objDT.Rows(intNo).Item("Photo").length)
                picPhoto.Image = Image.FromStream(msStream)
                msStream.Close()
            End If
        End If

        If Not IsDBNull(objDT.Rows(intNo).Item("Signature")) Then
            If objDT.Rows(intNo).Item("Signature").length > 0 Then
                msStream = New MemoryStream(objDT.Rows(intNo).Item("Signature"), True)
                msStream.Write(objDT.Rows(intNo).Item("Signature"), 0, objDT.Rows(intNo).Item("Signature").length)
                picSignature.Image = Image.FromStream(msStream)
                msStream.Close()
            End If
        End If
    End Function

    Public Function fnClearData() As Boolean
        txtLoanAmount.Text = ""
        txtSuretyPersonName.Text = ""
        txtCustomerNo.Text = ""
        txtFatherName.Text = ""
        txtAge.Text = ""
        txtPermAddress.Text = ""
        txtSalariedPersonDet.Text = ""
        txtBusinessPersonDet.Text = ""
        pnlSalariedDet.Enabled = False
        pnlBusinessDet.Enabled = False
        pnlBusiness.Enabled = False
        pnlBusinessDet.Enabled = False
        chkBusiness.Checked = False
        chkBusiness1.Checked = False
        chkSalary.Checked = False
        chkSalary1.Checked = False
        txtService.Text = ""
        txtSSalary.Text = ""
        txtSRent.Text = ""
        txtSTotalIncome.Text = ""
        txtSTotalExpenses.Text = ""
        txtTotalSaving.Text = ""
        txtBIncome.Text = ""
        txtBotherIncome.Text = ""
        txtBRent.Text = ""
        txtBtotalIncome.Text = ""
        txtBTotalExpenses.Text = ""
        txtBTotalSavings.Text = ""
        txtRelationship.Text = ""
        txtIncomeTax.Text = ""
        txtImmovableDet.Text = ""
        txtBankResp.Text = ""
        txtOrgResp.Text = ""
        txtPersonResp.Text = ""
        txtTotal.Text = ""
        txtBankName.Text = ""
        txtLoanType.Text = ""
        txtOthers.Text = ""
        txtDeclaration.Text = ""
        txtMobileNo.ResetText()
        txtSBNo.ResetText()
        btnSBSearch.Enabled = True
        btnCustomerSearch.Enabled = True
        txtSOtherIncome.Text = ""
        dtpDOB.ResetText()
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        Return True

    End Function

    Public Function fnCheckSalary() As Boolean

        If chkSalary.Checked = True Then

            If txtSSalary.Text = String.Empty Then
                MsgBox("Please enter salary details", MsgBoxStyle.Exclamation)
                txtSSalary.Focus()
                Return False

            ElseIf txtSRent.Text = String.Empty Then
                MsgBox("Please enter rent details", MsgBoxStyle.Exclamation)
                txtSRent.Focus()
                Return False

            ElseIf txtSTotalExpenses.Text = String.Empty Then
                MsgBox("Please enter total expenses", MsgBoxStyle.Exclamation)
                txtSTotalIncome.Focus()
                Return False

            ElseIf txtSOtherIncome.Text = String.Empty Then
                MsgBox("Please enter other income details", MsgBoxStyle.Exclamation)
                txtSOtherIncome.Focus()
                Return False

            Else

                Return True

            End If
        Else
            Return True

        End If

    End Function

    Public Function fnCheckBusiness() As Boolean

        If chkBusiness.Checked = True Then

            If txtBIncome.Text = String.Empty Then
                MsgBox("Please enter monthly income", MsgBoxStyle.Exclamation)
                txtBIncome.Focus()
                Return False

            ElseIf txtBRent.Text = String.Empty Then
                MsgBox("Please enter rent details", MsgBoxStyle.Exclamation)
                txtBRent.Focus()
                Return False

            ElseIf txtBTotalExpenses.Text = String.Empty Then
                MsgBox("Please enter total expenses details", MsgBoxStyle.Exclamation)
                txtBtotalIncome.Focus()
                Return False

            ElseIf txtBotherIncome.Text = String.Empty Then
                MsgBox("Please enter other income details", MsgBoxStyle.Exclamation)
                txtBotherIncome.Focus()
                Return False

            Else

                Return True

            End If

        Else

            Return True

        End If

    End Function

    Public Function fnCheck() As Boolean

        If txtAge.Text = "" Then
            MsgBox("Please enter age", MsgBoxStyle.Exclamation)
            txtAge.Focus()
            Return False
        ElseIf txtDeclaration.Text = "" Then
            MsgBox("Please enter declaration for loan", MsgBoxStyle.Exclamation)
            txtDeclaration.Focus()
            Return False

        Else

            Return True

        End If
    End Function

    Public Function fnCheckItem() As Boolean
        If txtLoanNo.Text <> "JL" Then
            If fnCheckBusiness() Then
                If fnCheckSalary() Then
                    If fnCheck() Then
                        Return True
                    End If
                End If
            End If
        Else
            MsgBox("Loan number dosent exist", MsgBoxStyle.Information)
            Return False
        End If

    End Function


#End Region


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheckItem() Then
                If fnSetData() Then
                    If objHomeSurety.fnCheckData(Trim(txtLoanNo.Text), Trim(txtSuretyNo.Text)) Then
                        If objHomeSurety.fnUpdateSuretyDet(Trim(txtLoanNo.Text), Trim(txtSuretyNo.Text), objTrans) Then
                            objTrans.Commit()
                            MsgBox("Surety details updated successfully", MsgBoxStyle.Information, "Loan Module")
                        Else
                            MsgBox("Internal error, surety details cannot updated successfully", MsgBoxStyle.Exclamation, "Loan Module")
                        End If
                    Else
                        If objHomeSurety.fnInsertSuretyDet(objTrans) Then
                            objTrans.Commit()
                            MsgBox("Added succesfully", MsgBoxStyle.Information, " Loan Module")
                        Else
                            MsgBox("Addition failed due to internal problem", MsgBoxStyle.Exclamation, "Loan Module")
                        End If
                    End If
                End If
                fnCheckSurety()
                btnAdd_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

    Private Sub frmHomeLoanSurety_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = Date.Now
        dtpDOB.Value = Date.Now
        If chrType = "J" Then
            lblName.Text = "Joint Holder Name:"
            lblDeclaration.Text = "Joint Holder Declaration:"
            Me.Text = "Joint Holder Detail"
        End If
        sbSetColor()
        pnlSalary.Enabled = False
        pnlBusiness.Enabled = False
        pnlBusinessDet.Enabled = False
        pnlSalariedDet.Enabled = False
        pnlSalary.Enabled = False
        pnlBusiness.Enabled = False
        If txtLoanNo.Text <> "" Then
            If fnCheckSurety() Then
                fnLoadSuretyDet()
            Else
                btnAdd_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub chkSalary_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSalary.CheckedChanged

        If chkSalary.Checked = True Then
            pnlSalary.Enabled = True
            pnlSalariedDet.Enabled = True
            chkSalary1.Checked = True
        End If

        If chkSalary.Checked = False Then
            pnlSalary.Enabled = False
            chkSalary1.Checked = False
            pnlSalariedDet.Enabled = False
        End If

    End Sub

    Private Sub chkBusiness_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBusiness.CheckedChanged

        If chkBusiness.Checked = True Then
            pnlBusiness.Enabled = True
            pnlBusinessDet.Enabled = True
            chkBusiness1.Checked = True
        End If
        If chkBusiness.Checked = False Then
            pnlBusiness.Enabled = False
            pnlBusinessDet.Enabled = False
            chkBusiness1.Checked = False
        End If


    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged
        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If
    End Sub

    Private Sub chkSalary1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSalary1.CheckedChanged
        If chkSalary1.Checked = True Then
            pnlSalary.Enabled = True
        Else
            pnlSalary.Enabled = False
        End If
    End Sub
    Private Sub chkBusiness1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBusiness1.CheckedChanged
        If chkBusiness1.Checked = True Then
            pnlBusiness.Enabled = True
        Else
            pnlBusiness.Enabled = False
        End If
    End Sub

    Private Sub dtpDOB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub


    Private Sub txtSSalary_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSalary.TextChanged, txtSRent.TextChanged, txtSOtherIncome.TextChanged
        txtSTotalIncome.Text = Val(txtSSalary.Text) + Val(txtSRent.Text) + Val(txtSOtherIncome.Text)
    End Sub

    Private Sub txtSTotalExpenses_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSTotalExpenses.TextChanged
        txtTotalSaving.Text = Val(txtSTotalIncome.Text) - Val(txtSTotalExpenses.Text)
    End Sub


    Private Sub txtBIncome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBIncome.TextChanged, txtBRent.TextChanged, txtBotherIncome.TextChanged
        txtBtotalIncome.Text = Val(txtBIncome.Text) + Val(txtBRent.Text) + Val(txtBotherIncome.Text)
    End Sub

    Private Sub txtBTotalExpenses_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBTotalExpenses.TextChanged
        txtBTotalSavings.Text = Val(txtBtotalIncome.Text) - Val(txtBTotalExpenses.Text)
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged

        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)

    End Sub

    Private Sub txtService_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtService.KeyDown, txtBusinessPersonDet.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub txtIncomeTax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIncomeTax.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

   

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Not objDT Is Nothing Then
            If intNo <> objDT.Rows.Count - 1 Then
                intNo += 1
                fnLoadSuretyDet()
            End If
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If intNo <> 0 Then
            intNo -= 1
            fnLoadSuretyDet()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtSuretyNo.Text = objHomeSurety.fnGetNewSuretyNo(txtLoanNo.Text, chrType)
        intNo += 1
        fnClearData()
        txtSuretyPersonName.Focus()
    End Sub


    Private Sub btnPhotoCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoCancel.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnSignCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignCancel.Click
        picSignature.Image = Nothing
    End Sub

    Private Sub btnPhotoLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoLoad.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnSignLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignLoad.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picSignature.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub picPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPhoto.Click
        btnPhotoLoad_Click(sender, e)
    End Sub

    Private Sub picSignature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSignature.Click
        btnSignLoad_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            If objHomeSurety.fnDeleteNominee(txtLoanNo.Text, txtSuretyNo.Text, chrType) Then
                MsgBox("Deleted successfully", MsgBoxStyle.Information)
                btnAdd_Click(sender, e)
                If fnCheckSurety() Then
                    fnLoadSuretyDet()
                End If
            End If
        End If
    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSearch.Click
        Dim objSBSearch As New frmSBAccSearch
        objSBSearch.strSBAccountNo = ""
        objSBSearch.ShowDialog(Me)
        If objSBSearch.strSBAccountNo <> "" Then
            txtSBNo.Text = objSBSearch.strSBAccountNo
            sbLoadMember()
            objSBSearch.Dispose()
        End If
    End Sub

    Private Sub btnCustomerSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerSearch.Click
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            txtCustomerNo.Text = objCustomerList.strCustomerID
            sbGeneral()
        End If
        objCustomerList.Dispose()
    End Sub

End Class
