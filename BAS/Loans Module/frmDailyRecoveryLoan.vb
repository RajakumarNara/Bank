Imports System.IO
Public Class frmDailyRecoveryLoan
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSurety As BankControls.NewButton
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
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
    Friend WithEvents tbGoldLoanDetails As System.Windows.Forms.TabPage
    Friend WithEvents dtpODLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents btnSignature As BankControls.NewButton
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkConditions1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents txtReason As BankControls.TextControl
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtNOI As BankControls.NumericControl
    Friend WithEvents cmbModeOfPayment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInstallmentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExpectedAmount As BankControls.NumericControl
    Friend WithEvents txtSanctionedAmount As BankControls.NumericControl
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkConditions2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkConditions3 As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents txtMonthlyIncome As BankControls.NumericControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As BankControls.NumericControl
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents dtpODSancDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lvSuretyDetail As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents txtSanctionedNo As BankControls.TextControl
    Friend WithEvents txtInstAmount As BankControls.NumericControl
    Friend WithEvents btnCalc As BankControls.NewButton
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents btnSBSearch As BankControls.NewButton
    Friend WithEvents txtSBNo As BankControls.TextControl
    Friend WithEvents Label39 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDailyRecoveryLoan))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.btnSBSearch = New BankControls.NewButton
        Me.txtSBNo = New BankControls.TextControl
        Me.Label39 = New System.Windows.Forms.Label
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtMobileNo2 = New BankControls.NumericControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtMonthlyIncome = New BankControls.NumericControl
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
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
        Me.txtInstAmount = New BankControls.NumericControl
        Me.txtSanctionedNo = New BankControls.TextControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.lvSuretyDetail = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.dtpODSancDate = New System.Windows.Forms.DateTimePicker
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.txtReason = New BankControls.TextControl
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtNOI = New BankControls.NumericControl
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
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label38 = New System.Windows.Forms.Label
        Me.dtpODLoanDate = New System.Windows.Forms.DateTimePicker
        Me.Label37 = New System.Windows.Forms.Label
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnLoadPhoto = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.btnCancelSign = New BankControls.NewButton
        Me.btnSignature = New BankControls.NewButton
        Me.txtRemarks = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkConditions1 = New System.Windows.Forms.CheckBox
        Me.chkConditions2 = New System.Windows.Forms.CheckBox
        Me.chkConditions3 = New System.Windows.Forms.CheckBox
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCalc = New BankControls.NewButton
        Me.NewButton2 = New BankControls.NewButton
        Me.btnSurety = New BankControls.NewButton
        Me.btnWithdraw = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbGoldLoanDetails.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.GroupBox2.Controls.Add(Me.TabControl1)
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
        Me.GroupBox2.Location = New System.Drawing.Point(220, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 632)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbGoldLoanDetails)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(32, 112)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 392)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabStop = False
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.btnSBSearch)
        Me.tbPersonal.Controls.Add(Me.txtSBNo)
        Me.tbPersonal.Controls.Add(Me.Label39)
        Me.tbPersonal.Controls.Add(Me.cmbAccType)
        Me.tbPersonal.Controls.Add(Me.Label102)
        Me.tbPersonal.Controls.Add(Me.Label29)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo2)
        Me.tbPersonal.Controls.Add(Me.Label27)
        Me.tbPersonal.Controls.Add(Me.txtMonthlyIncome)
        Me.tbPersonal.Controls.Add(Me.Label79)
        Me.tbPersonal.Controls.Add(Me.Label12)
        Me.tbPersonal.Controls.Add(Me.Label18)
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
        Me.tbPersonal.Size = New System.Drawing.Size(736, 363)
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
        Me.btnMemSearch.Location = New System.Drawing.Point(296, 16)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
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
        Me.txtCustomerID.Location = New System.Drawing.Point(152, 16)
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
        Me.btnSBSearch.Location = New System.Drawing.Point(296, 48)
        Me.btnSBSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
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
        Me.txtSBNo.Location = New System.Drawing.Point(152, 48)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.ReadOnly = True
        Me.txtSBNo.Size = New System.Drawing.Size(136, 23)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 125
        Me.txtSBNo.Text = ""
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(16, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(86, 19)
        Me.Label39.TabIndex = 124
        Me.Label39.Text = "SB/CA No. :"
        '
        'cmbAccType
        '
        Me.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(520, 320)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(136, 24)
        Me.cmbAccType.TabIndex = 26
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(368, 320)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(90, 19)
        Me.Label102.TabIndex = 118
        Me.Label102.Text = "Loan Type : "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(368, 152)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 19)
        Me.Label29.TabIndex = 112
        Me.Label29.Text = "Mobile No2 :"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.AfterDecimal = 0
        Me.txtMobileNo2.BeforeDecimal = 10
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo2.Location = New System.Drawing.Point(520, 152)
        Me.txtMobileNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo2.MaxLength = 10
        Me.txtMobileNo2.MaxValue = 0
        Me.txtMobileNo2.MinValue = 0
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo2.TabIndex = 22
        Me.txtMobileNo2.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 96)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 19)
        Me.Label27.TabIndex = 111
        Me.Label27.Text = "Husband Name  "
        '
        'txtMonthlyIncome
        '
        Me.txtMonthlyIncome.AfterDecimal = 0
        Me.txtMonthlyIncome.BeforeDecimal = 7
        Me.txtMonthlyIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMonthlyIncome.Location = New System.Drawing.Point(520, 288)
        Me.txtMonthlyIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMonthlyIncome.MaxLength = 7
        Me.txtMonthlyIncome.MaxValue = 0
        Me.txtMonthlyIncome.MinValue = 0
        Me.txtMonthlyIncome.Name = "txtMonthlyIncome"
        Me.txtMonthlyIncome.Size = New System.Drawing.Size(184, 23)
        Me.txtMonthlyIncome.TabIndex = 25
        Me.txtMonthlyIncome.Text = ""
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(368, 288)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(131, 19)
        Me.Label79.TabIndex = 110
        Me.Label79.Text = "Monthly Income of"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(368, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 19)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Office Address :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(368, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 19)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Occupational/"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(152, 216)
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
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(152, 176)
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
        Me.txtFatherName.Location = New System.Drawing.Point(152, 80)
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
        Me.cmbCaste.Location = New System.Drawing.Point(152, 288)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(184, 24)
        Me.cmbCaste.TabIndex = 18
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(152, 256)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(184, 24)
        Me.cmbReligion.TabIndex = 17
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(152, 112)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 23, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 23)
        Me.dtpDOB.TabIndex = 9
        Me.dtpDOB.Value = New Date(2007, 10, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father  /"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(368, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(368, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Residential Address : "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(520, 184)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(368, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 19)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(368, 120)
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
        Me.txtAge.Location = New System.Drawing.Point(152, 144)
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
        Me.txtPresAddress.Location = New System.Drawing.Point(520, 216)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 24
        Me.txtPresAddress.Text = ""
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(520, 88)
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
        Me.txtMobileNo.Location = New System.Drawing.Point(520, 120)
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
        Me.txtPermAddress.Location = New System.Drawing.Point(520, 16)
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
        'tbGoldLoanDetails
        '
        Me.tbGoldLoanDetails.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.tbGoldLoanDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbGoldLoanDetails.Controls.Add(Me.txtInstAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label20)
        Me.tbGoldLoanDetails.Controls.Add(Me.lvSuretyDetail)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label33)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label31)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpODSancDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label28)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label94)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReason)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label30)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtNOI)
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
        Me.tbGoldLoanDetails.Controls.Add(Me.Label13)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label15)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDueDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label38)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpODLoanDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label37)
        Me.tbGoldLoanDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGoldLoanDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldLoanDetails.Name = "tbGoldLoanDetails"
        Me.tbGoldLoanDetails.Size = New System.Drawing.Size(736, 363)
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
        Me.txtInstAmount.Location = New System.Drawing.Point(520, 56)
        Me.txtInstAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInstAmount.MaxLength = 8
        Me.txtInstAmount.MaxValue = 0
        Me.txtInstAmount.MinValue = 0
        Me.txtInstAmount.Name = "txtInstAmount"
        Me.txtInstAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtInstAmount.TabIndex = 9
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
        Me.txtSanctionedNo.Size = New System.Drawing.Size(168, 24)
        Me.txtSanctionedNo.SpecialChar = True
        Me.txtSanctionedNo.TabIndex = 5
        Me.txtSanctionedNo.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 19)
        Me.Label20.TabIndex = 138
        Me.Label20.Text = "Surety Person Detail"
        '
        'lvSuretyDetail
        '
        Me.lvSuretyDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvSuretyDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSuretyDetail.FullRowSelect = True
        Me.lvSuretyDetail.GridLines = True
        Me.lvSuretyDetail.Location = New System.Drawing.Point(16, 272)
        Me.lvSuretyDetail.Name = "lvSuretyDetail"
        Me.lvSuretyDetail.Size = New System.Drawing.Size(664, 96)
        Me.lvSuretyDetail.TabIndex = 137
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
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(264, 208)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(38, 19)
        Me.Label33.TabIndex = 122
        Me.Label33.Text = "Days"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(24, 144)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(118, 19)
        Me.Label31.TabIndex = 121
        Me.Label31.Text = "Sanctioned No. :"
        '
        'dtpODSancDate
        '
        Me.dtpODSancDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpODSancDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpODSancDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpODSancDate.Location = New System.Drawing.Point(184, 112)
        Me.dtpODSancDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpODSancDate.Name = "dtpODSancDate"
        Me.dtpODSancDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpODSancDate.TabIndex = 4
        Me.dtpODSancDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(24, 112)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 19)
        Me.Label28.TabIndex = 118
        Me.Label28.Text = "Sanctioned Date :"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label94.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(360, 56)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(145, 19)
        Me.Label94.TabIndex = 117
        Me.Label94.Text = "Installment Amount:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(520, 184)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxLength = 7
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(168, 23)
        Me.txtReceiptNo.TabIndex = 13
        Me.txtReceiptNo.Text = ""
        '
        'txtReason
        '
        Me.txtReason.AlphaNumeric = True
        Me.txtReason.AutoSize = False
        Me.txtReason.BlankSpace = False
        Me.txtReason.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReason.Location = New System.Drawing.Point(520, 152)
        Me.txtReason.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReason.Mandatory = False
        Me.txtReason.MaxLength = 30
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(168, 24)
        Me.txtReason.SpecialChar = True
        Me.txtReason.TabIndex = 12
        Me.txtReason.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(360, 192)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 19)
        Me.Label30.TabIndex = 116
        Me.Label30.Text = "Receipt No. :"
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
        Me.txtNOI.Size = New System.Drawing.Size(72, 23)
        Me.txtNOI.TabIndex = 7
        Me.txtNOI.Text = ""
        '
        'cmbModeOfPayment
        '
        Me.cmbModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeOfPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeOfPayment.Items.AddRange(New Object() {"Cheque", "Cash", "DD"})
        Me.cmbModeOfPayment.Location = New System.Drawing.Point(520, 120)
        Me.cmbModeOfPayment.Name = "cmbModeOfPayment"
        Me.cmbModeOfPayment.Size = New System.Drawing.Size(168, 24)
        Me.cmbModeOfPayment.TabIndex = 11
        '
        'cmbInstallmentType
        '
        Me.cmbInstallmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstallmentType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInstallmentType.Items.AddRange(New Object() {"Daily", "Monthly", "Quaterly", "Yearly"})
        Me.cmbInstallmentType.Location = New System.Drawing.Point(520, 88)
        Me.cmbInstallmentType.Name = "cmbInstallmentType"
        Me.cmbInstallmentType.Size = New System.Drawing.Size(168, 24)
        Me.cmbInstallmentType.TabIndex = 10
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(360, 160)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(128, 19)
        Me.Label34.TabIndex = 106
        Me.Label34.Text = "Purpose of Loan  :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 19)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Sanctioned Amount  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 19)
        Me.Label11.TabIndex = 100
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
        Me.txtExpectedAmount.Text = ""
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
        Me.txtSanctionedAmount.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 19)
        Me.Label21.TabIndex = 101
        Me.Label21.Text = "Rate Of Intrest. :"
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
        Me.txtROI.Size = New System.Drawing.Size(72, 23)
        Me.txtROI.TabIndex = 6
        Me.txtROI.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(360, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 19)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "Installment Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(360, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 19)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Mode Of Payment :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 19)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "No Of Installments :"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(520, 24)
        Me.dtpDueDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpDueDate.TabIndex = 8
        Me.dtpDueDate.Value = New Date(2007, 4, 11, 0, 0, 0, 0)
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(360, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 19)
        Me.Label38.TabIndex = 89
        Me.Label38.Text = "Due Date:"
        '
        'dtpODLoanDate
        '
        Me.dtpODLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpODLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpODLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpODLoanDate.Location = New System.Drawing.Point(184, 48)
        Me.dtpODLoanDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpODLoanDate.Name = "dtpODLoanDate"
        Me.dtpODLoanDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpODLoanDate.TabIndex = 2
        Me.dtpODLoanDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(24, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(101, 19)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "Applied Date :"
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbOthers.Controls.Add(Me.Panel6)
        Me.tbOthers.Controls.Add(Me.txtRemarks)
        Me.tbOthers.Controls.Add(Me.Label17)
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(736, 363)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnLoadPhoto)
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.Label61)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Label62)
        Me.Panel6.Controls.Add(Me.btnCancelSign)
        Me.Panel6.Controls.Add(Me.btnSignature)
        Me.Panel6.Location = New System.Drawing.Point(10, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(696, 248)
        Me.Panel6.TabIndex = 1
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(80, 192)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(72, 40)
        Me.btnLoadPhoto.TabIndex = 2
        Me.btnLoadPhoto.Text = "Load"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnClose.Location = New System.Drawing.Point(176, 192)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Cancel"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(464, 16)
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
        Me.Label61.Size = New System.Drawing.Size(57, 17)
        Me.Label61.TabIndex = 58
        Me.Label61.Text = "Signature"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(80, 16)
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
        Me.Label62.Size = New System.Drawing.Size(37, 17)
        Me.Label62.TabIndex = 56
        Me.Label62.Text = "Photo"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnCancelSign.Location = New System.Drawing.Point(560, 192)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(72, 40)
        Me.btnCancelSign.TabIndex = 5
        Me.btnCancelSign.Text = "Cancel"
        '
        'btnSignature
        '
        Me.btnSignature.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignature.ForeColor = System.Drawing.Color.Black
        Me.btnSignature.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnSignature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignature.Location = New System.Drawing.Point(464, 192)
        Me.btnSignature.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(72, 40)
        Me.btnSignature.TabIndex = 4
        Me.btnSignature.Text = "Load"
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.AutoSize = False
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(120, 280)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(576, 88)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 6
        Me.txtRemarks.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 19)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Remarks :"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.TabPage1.Controls.Add(Me.chkSelectAll)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(736, 363)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Conditions"
        Me.TabPage1.Visible = False
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(24, 48)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(88, 24)
        Me.chkSelectAll.TabIndex = 1
        Me.chkSelectAll.Text = "Select All"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkConditions1)
        Me.Panel1.Controls.Add(Me.chkConditions2)
        Me.Panel1.Controls.Add(Me.chkConditions3)
        Me.Panel1.Location = New System.Drawing.Point(16, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 184)
        Me.Panel1.TabIndex = 80
        '
        'chkConditions1
        '
        Me.chkConditions1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConditions1.Location = New System.Drawing.Point(8, 16)
        Me.chkConditions1.Name = "chkConditions1"
        Me.chkConditions1.Size = New System.Drawing.Size(640, 40)
        Me.chkConditions1.TabIndex = 2
        Me.chkConditions1.Text = "2% penalty for balance amount will be chainged if loan is default continuously fo" & _
        "r 15 days with in the loan term of 100 days."
        '
        'chkConditions2
        '
        Me.chkConditions2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConditions2.Location = New System.Drawing.Point(8, 72)
        Me.chkConditions2.Name = "chkConditions2"
        Me.chkConditions2.Size = New System.Drawing.Size(640, 40)
        Me.chkConditions2.TabIndex = 3
        Me.chkConditions2.Text = "10% penalty for balance amount will be charged if loan is not cleared with in 100" & _
        " days and thereafter additional 2% will be charged for balance amount till closu" & _
        "re of the loan."
        '
        'chkConditions3
        '
        Me.chkConditions3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConditions3.Location = New System.Drawing.Point(8, 128)
        Me.chkConditions3.Name = "chkConditions3"
        Me.chkConditions3.Size = New System.Drawing.Size(584, 24)
        Me.chkConditions3.TabIndex = 4
        Me.chkConditions3.Text = "I accept for all above conditions."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(96, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(350, 25)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Souhardha Daily Recovery Loan Details"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(312, 72)
        Me.txtLoanNo.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 9
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.Size = New System.Drawing.Size(144, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.Text = "SDRL"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(464, 72)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(40, 528)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Reset"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(568, 72)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnOk.Location = New System.Drawing.Point(560, 528)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(656, 528)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Souhardha Daily Recovery Loan No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnSurety)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 632)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(16, 432)
        Me.btnCalc.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(184, 40)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Additional Charges"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 128)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(184, 40)
        Me.NewButton2.TabIndex = 1
        Me.NewButton2.Text = "&Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSurety
        '
        Me.btnSurety.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSurety.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurety.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurety.ForeColor = System.Drawing.Color.Black
        Me.btnSurety.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnSurety.Image = CType(resources.GetObject("btnSurety.Image"), System.Drawing.Image)
        Me.btnSurety.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSurety.Location = New System.Drawing.Point(16, 168)
        Me.btnSurety.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSurety.Name = "btnSurety"
        Me.btnSurety.Size = New System.Drawing.Size(184, 40)
        Me.btnSurety.TabIndex = 2
        Me.btnSurety.Text = "Surety &Person Details"
        Me.btnSurety.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(16, 320)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(184, 40)
        Me.btnWithdraw.TabIndex = 4
        Me.btnWithdraw.Text = "&Disbursment"
        Me.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 360)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(184, 40)
        Me.NewButton5.TabIndex = 5
        Me.NewButton5.Text = "&View Transaction Log"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(16, 280)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(184, 40)
        Me.btnDeposit.TabIndex = 3
        Me.btnDeposit.Text = "&Repayment"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDailyRecoveryLoan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 607)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDailyRecoveryLoan"
        Me.ShowInTaskbar = False
        Me.Text = "Souhardha Daily Recovery Loan Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbGoldLoanDetails.ResumeLayout(False)
        Me.tbOthers.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"

    Dim objDailyRecoveryLoan As New clsDailyRecoveryLoan
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim objclsRepyment As New clsRePayment
    Dim objSBAccount As New clsSavingsBank1
    Dim objSBAccount1 As New clsSavingsBank
    Dim objSurety As New clsHomeLoanSurety
    Dim OfficeNo As String
    Dim objPerson As New clsPerson

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmDailyRecoveryLoan
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmDailyRecoveryLoan
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmDailyRecoveryLoan
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmDailyRecoveryLoan)
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
            PictureBox3.Image = Image.FromFile(OfdPic.FileName)
        End If
    End Sub

    Private Sub btnCancelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox3.Image = Nothing
    End Sub

    Private Sub btnSignature_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignature.Click
        Dim OfdSign As New OpenFileDialog
        OfdSign.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp"
        If OfdSign.ShowDialog() = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OfdSign.FileName)
        End If
    End Sub

    Private Sub btnCancelSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSign.Click
        PictureBox2.Image = Nothing
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

        If Trim(txtLoanNo.Text) = "SDRL" Then
            MsgBox("Enter account no ", MsgBoxStyle.Exclamation)
            txtLoanNo.Focus()
            Return False

        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name ", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False

            'ElseIf Trim(txtMemberNo.Text) = String.Empty Or Trim(txtSBNo.Text) = String.Empty Then
            '    MsgBox("Please enter member and SB account number")
            '    txtSBNo.Focus()
            '    Return False

            'ElseIf Trim(txtSBNo.Text) = String.Empty Then
            '    MsgBox("Please Enter SB account number")
            '    txtSBNo.Focus()
            '    Return False

        ElseIf Trim(txtPermAddress.Text) = String.Empty Then
            MsgBox("Enter address", MsgBoxStyle.Exclamation)
            txtPermAddress.Focus()
            Return False

        ElseIf Trim(cmbAccType.SelectedItem) = String.Empty Then
            MsgBox("Enter loan type", MsgBoxStyle.Exclamation)
            cmbAccType.Focus()
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

        ElseIf Trim(txtSanctionedNo.Text) = String.Empty Then
            MsgBox("Enter sanction number", MsgBoxStyle.Exclamation)
            txtSanctionedNo.Focus()
            Return False

        ElseIf Val(txtSanctionedAmount.Text) > Val(txtExpectedAmount.Text) Then
            MsgBox("Please check applied and sanctioned amount", MsgBoxStyle.Exclamation)
            txtSanctionedAmount.Focus()
            Return False

        ElseIf Trim(txtROI.Text) = String.Empty Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False

        ElseIf txtNOI.Text = String.Empty Then
            MsgBox("Enter no of installments", MsgBoxStyle.Exclamation)
            txtNOI.Focus()
            Return False


        ElseIf Trim(txtInstAmount.Text) = String.Empty Then
            MsgBox("Enter instralement amount", MsgBoxStyle.Exclamation)
            txtInstAmount.Focus()

        ElseIf Trim(cmbInstallmentType.SelectedItem) = String.Empty Then
            MsgBox("Select installement type", MsgBoxStyle.Exclamation)
            cmbInstallmentType.Focus()
            Return False
        ElseIf Trim(cmbModeOfPayment.SelectedItem) = String.Empty Then
            MsgBox("Select mode of payment", MsgBoxStyle.Exclamation)
            cmbModeOfPayment.Focus()
            Return False

        ElseIf Trim(txtReason.Text) = String.Empty Then
            MsgBox("Enter reason for loan", MsgBoxStyle.Exclamation)
            txtReason.Focus()
            Return False

        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Please enter receipt no", MsgBoxStyle.Exclamation, "Loan Module")
            txtReceiptNo.Focus()
            Return False

        ElseIf chkConditions1.Checked = False And chkConditions2.Checked = False And chkConditions3.Checked = False Then
            MsgBox("Please check all conditions", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.TabPage1
            chkConditions1.Focus()
            Return False


        ElseIf (Mid(txtSanctionedAmount.Text, 1, 1)) = 0 Then
            MsgBox("Please check the sanctioned amount", MsgBoxStyle.Information)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf (dtpODSancDate.Value < dtpODLoanDate.Value) Then
            MsgBox("Sanctioned date should be greater than Applied date", MsgBoxStyle.Information)
            dtpODLoanDate.Focus()
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

    Sub sbGeneral()
        Dim msStream As MemoryStream
        Dim objDT As DataTable
        Dim flag As Boolean = False
        Try
            If txtCustomerID.Text <> "" Then
                If objPerson.fnGetCustomerID(txtCustomerID.Text) Then
                    objDT = objPerson.PersonTable

                End If
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
                'Else
                '    txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
                '    btnMemSearch.Enabled = False
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
            End If
        Catch ex As Exception
        End Try

    End Sub

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objDailyRecoveryLoan.fnChekDRLAccount(Trim(txtLoanNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objDailyRecoveryLoan.fnAddODLAccount(objTrans) = True Then
                ' fnGenerateVoucher()
                'Log Entry
                fnLogEntry(pbUserId, "New SDRL created " & txtLoanNo.Text, Date.Now, "New SDRL", objTrans)
                MessageBox.Show("New dailyrecovery loan created successfully.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New dailyrecovery loan creation failed, because of internal error.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else

            'update details (edit mode)

            If objDailyRecoveryLoan.fnUpdateLoanDetails(Trim(txtLoanNo.Text)) Then
                If objDailyRecoveryLoan.fnUpDateDRLDet(Trim(txtLoanNo.Text)) Then
                    fnLogEntry(pbUserId, "SDRL updated" & txtLoanNo.Text, Date.Now, "Update SDRL account")
                    MessageBox.Show("DailyRecovery loan updated successfully.", "Loan module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Return True
                Else
                    MessageBox.Show("DailyRecovery loan updation failed, because of internal error.", "Loan module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Return False
                End If
            End If
        End If

    End Function

    Function fnSetData() As Boolean

        ' Person Deatils

        If lngPersonNo <> 0 Then
            objDailyRecoveryLoan.PersonNo = lngPersonNo
        Else
            objDailyRecoveryLoan.PersonNo = objDailyRecoveryLoan.fnGetNewPersonNo()
        End If

        objDailyRecoveryLoan.Name = txtName.Text
        objDailyRecoveryLoan.FatherName = txtFatherName.Text
        objDailyRecoveryLoan.PermAddress = txtPermAddress.Text
        objDailyRecoveryLoan.PresAddress = txtPresAddress.Text
        If txtPhoneNo.Text = "" Then
            objDailyRecoveryLoan.PhoneNo = 0
        Else
            objDailyRecoveryLoan.PhoneNo = txtPhoneNo.Text
        End If

        If txtMobileNo.Text = "" Then
            objDailyRecoveryLoan.MobileNo = 0
        Else
            objDailyRecoveryLoan.MobileNo = txtMobileNo.Text
        End If

        objDailyRecoveryLoan.DOB = Format(dtpDOB.Value, "yyyy-MM-dd")
        objDailyRecoveryLoan.Age = txtAge.Text
        objDailyRecoveryLoan.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objDailyRecoveryLoan.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objDailyRecoveryLoan.ReligionCode = cmbReligion.SelectedValue
        objDailyRecoveryLoan.OccupationCode = cmbOccupation.SelectedValue
        objDailyRecoveryLoan.OfficeNo = OfficeNo
        'Loan Details

        Select Case cmbAccType.SelectedItem
            Case "Joint"
                objDailyRecoveryLoan.LoanType = "J"
            Case "Single"
                objDailyRecoveryLoan.LoanType = "S"
        End Select

        objDailyRecoveryLoan.LoanNo = txtLoanNo.Text
        objDailyRecoveryLoan.SBNo = txtSBNo.Text
        objDailyRecoveryLoan.MemberNo = txtCustomerID.Text
        objDailyRecoveryLoan.DemandReason = txtReason.Text
        objDailyRecoveryLoan.RIO = (txtROI.Text / 100)
        objDailyRecoveryLoan.ExpectedAmount = txtExpectedAmount.Text
        objDailyRecoveryLoan.Sanctioned = txtSanctionedAmount.Text
        objDailyRecoveryLoan.sancNo = txtSanctionedNo.Text
        objDailyRecoveryLoan.Balance = 0
        objDailyRecoveryLoan.DisbAmt = 0
        objDailyRecoveryLoan.LastPaidDate = "9999-9-9"
        objDailyRecoveryLoan.Installments = ""
        objDailyRecoveryLoan.ModeOfPayment = ""
        objDailyRecoveryLoan.AccAtatus = "Active"
        objDailyRecoveryLoan.AppDate = Format(dtpODLoanDate.Value, "yyyy-MM-dd")
        objDailyRecoveryLoan.Remarks = txtRemarks.Text
        objDailyRecoveryLoan.NOI = txtNOI.Text
        objDailyRecoveryLoan.DueDate = Format(dtpDueDate.Value, "yyyy-MM-dd")
        objDailyRecoveryLoan.SancDate = Format(dtpODSancDate.Value, "yyyy-MM-dd")
        objDailyRecoveryLoan.InstPrinciple = txtInstAmount.Text
        objDailyRecoveryLoan.ReciptNo = txtReceiptNo.Text
        objDailyRecoveryLoan.Installments = cmbInstallmentType.SelectedItem
        objDailyRecoveryLoan.ModeOfPayment = cmbModeOfPayment.SelectedItem
        objDailyRecoveryLoan.MonthlyIncome = Val(txtMonthlyIncome.Text)
        objDailyRecoveryLoan.MobileNo2 = txtMobileNo2.Text

        If chkConditions1.Checked = True Then
            objDailyRecoveryLoan.Conditons1 = "Y"
        Else
            objDailyRecoveryLoan.Conditons1 = "N"
        End If

        If chkConditions2.Checked = True Then
            objDailyRecoveryLoan.Conditons2 = "Y"
        Else
            objDailyRecoveryLoan.Conditons2 = "N"
        End If

        If chkConditions3.Checked = True Then
            objDailyRecoveryLoan.Conditons3 = "Y"
        Else
            objDailyRecoveryLoan.Conditons3 = "N"
        End If


        Return True

    End Function

    'To get Byte array for Photo object, function called while setting values to the Class Properties
    Function fnGetPhoto() As Byte()
        Try
            Dim msStream As New MemoryStream
            Dim bytArr() As Byte
            PictureBox3.Image.Save(msStream, PictureBox3.Image.RawFormat)
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
            PictureBox2.Image.Save(msStream, PictureBox2.Image.RawFormat)
            bytArr = msStream.GetBuffer
            msStream.Close()
            Return bytArr
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function fnCheckStatus()

        If objDailyRecoveryLoan.fnChekDRLAccount(txtLoanNo.Text) Then

            If objDailyRecoveryLoan.DRLoanTable.Rows(0).Item("Balance") = 0 Then


            End If

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

        dtpDOB.Value = Date.Now
        dtpODLoanDate.Value = Date.Now
        dtpODSancDate.Value = Date.Now
        dtpDueDate.Value = Date.Now

        sbLoadControlValues() 'Load Values 
        If txtLoanNo.Text <> String.Empty Then
            sbLoadDRLAccDetails()
        End If
        btnAdd_Click(sender, e)
        txtLoanNo.Focus()
    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtLoanNo.Text = "SDRL" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanNo.KeyPress

        If txtLoanNo.Text = "SDRL" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyDown

        If txtLoanNo.Text = "SDRL" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmLoanCust As New frmDailyRecoveryLoanCust
        objfrmLoanCust.strLoan = String.Empty
        objfrmLoanCust.ShowDialog(Me)
        If objfrmLoanCust.strLoan <> String.Empty Then
            txtLoanNo.Text = objfrmLoanCust.strLoan
            sbLoadDRLAccDetails()
        End If
        objfrmLoanCust.Dispose()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        If objclsRepyment.fnGetData(txtLoanNo.Text) Then
            If objclsRepyment.PaymentTable.Rows(0).Item("SancAmount") = objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") Then
                Dim ObjRepayment As New FrmRePayement
                ObjRepayment.txtLoanNo.Text = txtLoanNo.Text
                ObjRepayment.txtName.Text = txtName.Text
                ObjRepayment.ShowDialog(Me)
            Else
                MsgBox("Please Disburse the amount first", MsgBoxStyle.Information)
            End If
            fnCheckStatus()
        Else
            MsgBox("Enter valid Loan Number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        If objDailyRecoveryLoan.fnChekDRLAccount(Trim(txtLoanNo.Text)) = True Then
            Dim ObjfrmDisb As New frmDisbursment
            ObjfrmDisb.txtLoanNo.Text = txtLoanNo.Text
            ObjfrmDisb.lblSecuretyAmount.Text = "Interest Amount"
            ObjfrmDisb.txtIntrestAmt.Visible = True
            ObjfrmDisb.txtSecurityAmt.Visible = False
            ObjfrmDisb.txtProcCharges.Enabled = False
            ObjfrmDisb.ShowDialog(Me)
        Else
            MsgBox("Enter valid Loan Number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If
    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If objDailyRecoveryLoan.fnChekDRLAccount(Trim(txtLoanNo.Text)) = True Then
            Dim objfrmTransaction As New frmTransaction
            objfrmTransaction.txtLoanNo.Text = txtLoanNo.Text
            objfrmTransaction.txtName.Text = txtName.Text
            objfrmTransaction.ShowDialog(Me)
        Else
            MsgBox("Enter valid Loan Number", MsgBoxStyle.Information, "Loan Module")
            txtLoanNo.Focus()
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        nMode = CTAdd
        sbClear()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objSBAccount.fnGetNewLoanNo("SDRL"), 5, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "SDRL" & String.Format("{0:00000}", CInt(TempNewNo))
            txtLoanNo.Text = Temp
            txtLoanNo.Focus()
        Else
            MsgBox("SDRL number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
        End If


    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged

        If chkSelectAll.Checked = True Then
            chkConditions1.Checked = True
            chkConditions2.Checked = True
            chkConditions3.Checked = True
        Else
            chkConditions1.Checked = False
            chkConditions2.Checked = False
            chkConditions3.Checked = False
        End If

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

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.TextChanged

        If Not txtLoanNo.Text.StartsWith("SDRL") Then
            txtLoanNo.Undo()
            txtLoanNo.ClearUndo()
        End If

    End Sub

    'Private Sub txtAccNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanNo.Leave

    '    If objDailyRecoveryLoan.fnChekDRLAccount(Trim(txtLoanNo.Text)) = True Then
    '        If MsgBox("Account No already Exists Do You Want To Update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            sbLoadDRLAccDetails()
    '        Else
    '            txtLoanNo.Focus()
    '        End If
    '    End If

    'End Sub

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

#End Region

#Region "Genral Subroutines"

    Sub sbLoadDRLAccDetails()

        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objDailyRecoveryLoan.fnGetLoanDetails(txtLoanNo.Text) Then
                sbClear()

                objDT = objDailyRecoveryLoan.DRLDetailstable

                'Sb Details

                txtLoanNo.Text = objDT.Rows(0).Item("LoanNo")
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                txtSBNo.Text = objDT.Rows(0).Item("SBNo")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")

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

                txtExpectedAmount.Text = objDT.Rows(0).Item("ExpAmount")
                txtSanctionedAmount.Text = objDT.Rows(0).Item("SancAmount")
                txtROI.Text = (objDT.Rows(0).Item("ROI") * 100)
                txtNOI.Text = objDT.Rows(0).Item("NOI")
                txtInstAmount.Text = objDT.Rows(0).Item("InstPrinciple")

                cmbInstallmentType.SelectedItem = objDT.Rows(0).Item("Type")
                cmbModeOfPayment.SelectedItem = objDT.Rows(0).Item("RepayMode")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtSBNo.Text = objDT.Rows(0).Item("SBNo")
                dtpODLoanDate.Value = CDate(objDT.Rows(0).Item("ApplDate"))
                dtpDueDate.Value = CDate(objDT.Rows(0).Item("DueDate"))
                dtpODSancDate.Value = CDate(objDT.Rows(0).Item("SancDate"))
                txtSanctionedNo.Text = objDT.Rows(0).Item("SancNo")

                Select Case objDT.Rows(0).Item("LoanType")
                    Case "S"
                        cmbAccType.SelectedItem = "Single"
                    Case "J"
                        cmbAccType.SelectedItem = "Joint"
                End Select

                txtReason.Text = objDT.Rows(0).Item("Purpose")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")

                'VehicleDetailss
                If objDailyRecoveryLoan.fnGetDRLoanDet(txtLoanNo.Text) Then

                    txtMonthlyIncome.Text = objDailyRecoveryLoan.DRLDetailstable.Rows(0).Item("MonthlyIncome")
                    txtMobileNo2.Text = objDailyRecoveryLoan.DRLDetailstable.Rows(0).Item("MobileNo2")

                    If objDailyRecoveryLoan.DRLDetailstable.Rows(0).Item("Conditions1") = "Y" Then
                        chkConditions1.Checked = True
                    Else
                        chkConditions1.Checked = False
                    End If

                    If objDailyRecoveryLoan.DRLDetailstable.Rows(0).Item("Conditions2") = "Y" Then
                        chkConditions2.Checked = True
                    Else
                        chkConditions2.Checked = False
                    End If

                    If objDailyRecoveryLoan.DRLDetailstable.Rows(0).Item("Conditions3") = "Y" Then
                        chkConditions3.Checked = True
                    Else
                        chkConditions3.Checked = False
                    End If

                End If

                'txtSanctionedAmount.Enabled = False
                'txtROI.Enabled = False
                'txtReceiptNo.ReadOnly = True
                'txtExpectedAmount.ReadOnly = True
                'txtLoanNo.ReadOnly = True
                fnLoadSuretyPerson()

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
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub sbClear()

        Dim intCount As Integer = 0
        lngPersonNo = 0
        txtLoanNo.ReadOnly = False
        txtSanctionedAmount.ReadOnly = False

        ' txtLoanNo.Text = "SDRL"
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpDOB.ResetText()
        txtSBNo.ResetText()
        rdbMale.Checked = True
        txtAge.ResetText()
        cmbReligion.SelectedIndex = 0
        cmbCaste.ResetText()
        cmbOccupation.ResetText()
        txtPermAddress.ResetText()
        txtMonthlyIncome.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        PictureBox3.Image = Nothing
        PictureBox2.Image = Nothing
        txtRemarks.ResetText()
        txtExpectedAmount.ResetText()
        txtSanctionedAmount.ResetText()
        txtROI.ResetText()
        txtCustomerID.ResetText()
        txtMonthlyIncome.ResetText()
        txtNOI.ResetText()
        txtInstAmount.ResetText()
        txtReason.ResetText()
        txtReceiptNo.ResetText()


        txtReason.ResetText()
        chkSelectAll.Checked = False
        chkConditions1.Checked = False
        chkConditions2.Checked = False
        chkConditions3.Checked = False

        txtSBNo.ReadOnly = False
        btnMemSearch.Enabled = True
        txtSanctionedAmount.Enabled = True
        txtROI.Enabled = True
        txtReceiptNo.ReadOnly = False
        txtExpectedAmount.ReadOnly = False
        txtLoanNo.ReadOnly = False
        txtCustomerID.Enabled = True

        btnSBSearch.Enabled = True
        btnMemSearch.Enabled = True
        txtCustomerID.ReadOnly = False
        txtSBNo.ReadOnly = False
        txtSanctionedNo.ResetText()
        txtMobileNo2.ResetText()
        lvSuretyDetail.Items.Clear()

    End Sub


#End Region

#Region "Navigation"

    Private Sub cmbInstallmentType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbInstallmentType.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbCaste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCaste.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub cmbOccupation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOccupation.KeyDown

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

    Private Sub txtExpectedAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExpectedAmount.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtFatherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFatherName.KeyDown

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

    Private Sub txtRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtROI_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtROI.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtSanctionedAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSanctionedAmount.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtWitnessPerson1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

    Private Sub txtWitnessPerson2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub
    Private Sub txtAddress2_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub
    Private Sub txtWitnessPerson2_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")

    End Sub

#End Region

    Private Sub txtSanctionedAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSanctionedAmount.Leave
        If txtSanctionedAmount.Text = "" Then
            MsgBox("Enter Sanctioned Amount To Load Rate Of Intrest")
        Else
            fnGetROI()
        End If

    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = ""
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> "" Then
            sbClear()
            txtSBNo.Text = objSBAccSearch.strSBAccountNo
            sbGeneral()
            objSBAccSearch.Dispose()
        End If
    End Sub


    Private Sub txtNOI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOI.TextChanged
        Dim TempDate As Date = DateAdd(DateInterval.Day, Val(txtNOI.Text), dtpODSancDate.Value)
        dtpDueDate.Value = DateAdd(DateInterval.Day, -1, TempDate)
    End Sub

    Private Sub btnSurety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurety.Click
        If txtLoanNo.Text <> "SDRL" Then
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

    Private Sub NewButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If cmbAccType.SelectedItem = "Joint" Then
            If Trim(txtLoanNo.Text) <> "SDRL" Then
                Dim objfrmSurety As New frmHomeLoanSurety
                objfrmSurety.BackColor = GroupBox1.BackColor
                objfrmSurety.TabPage1.BackColor = GroupBox1.BackColor
                objfrmSurety.btnOk.GotFocusColour = btnAdd.GotFocusColour
                objfrmSurety.txtLoanNo.Text = txtLoanNo.Text
                objfrmSurety.txtLoanerName.Text = txtName.Text
                objfrmSurety.chrType = "J"
                objfrmSurety.ShowDialog(Me)
            Else
                MsgBox("Enter valid account number", MsgBoxStyle.Information, "Loan Module")
                txtLoanNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtLoanNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoanNo.Leave
        If objDailyRecoveryLoan.fnChekDRLAccount(Trim(txtLoanNo.Text)) = True Then
            If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sbLoadDRLAccDetails()
            Else
                txtLoanNo.Focus()
            End If
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
            Label39.Text = "SB No. :"
        Else
            Label39.Text = "CA No. :"

        End If

        objAccountSelection.Dispose()
    End Sub
End Class
