#Region "Import Statements"
Imports System.IO
#End Region

Public Class frmGoldLoanDetails
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objSBAccount As New clsSavingsBank1
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim GoldLoanDet(10) As GoldLoanControl
    Dim objclsRepyment As New clsRePayment
    Dim objSBAccount1 As New clsSavingsBank
    Dim objSurety As New clsHomeLoanSurety
    Dim OfficeNo As String
    Dim objPerson As New clsPerson
    'Dim objDT As DataTable

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
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
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
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
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
    Friend WithEvents txtAccNo As BankControls.TextControl
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
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tbGoldDetails As System.Windows.Forms.TabPage
    Friend WithEvents tbGoldLoanDetails As System.Windows.Forms.TabPage
    Friend WithEvents pnlGoldDetails As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
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
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dtpGoldLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtInstallments As BankControls.NumericControl
    Friend WithEvents btnLoanList As BankControls.NewButton
    Friend WithEvents txtGoldAmount As BankControls.NumericControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents txtpurpose As BankControls.TextControl
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As BankControls.NumericControl
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents dtpDemandSancDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lvSuretyDetail As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents btnSurety As BankControls.NewButton
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents txtSanctionedNo As BankControls.TextControl
    Friend WithEvents txtInstAmount As BankControls.NumericControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents btnCalc As BankControls.NewButton
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents btnSBSearch As BankControls.NewButton
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtSBNo As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGoldLoanDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtMobileNo2 = New BankControls.NumericControl
        Me.Label45 = New System.Windows.Forms.Label
        Me.btnSBSearch = New BankControls.NewButton
        Me.Label44 = New System.Windows.Forms.Label
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
        Me.txtSBNo = New BankControls.TextControl
        Me.Label39 = New System.Windows.Forms.Label
        Me.tbGoldLoanDetails = New System.Windows.Forms.TabPage
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.txtInstAmount = New BankControls.NumericControl
        Me.txtSanctionedNo = New BankControls.TextControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.lvSuretyDetail = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Label105 = New System.Windows.Forms.Label
        Me.dtpDemandSancDate = New System.Windows.Forms.DateTimePicker
        Me.Label106 = New System.Windows.Forms.Label
        Me.txtpurpose = New BankControls.TextControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtInstallments = New BankControls.NumericControl
        Me.dtpGoldLoanDate = New System.Windows.Forms.DateTimePicker
        Me.cmbModeOfPayment = New System.Windows.Forms.ComboBox
        Me.cmbInstallmentType = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtGoldAmount = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtExpectedAmount = New BankControls.NumericControl
        Me.txtSanctionedAmount = New BankControls.NumericControl
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label38 = New System.Windows.Forms.Label
        Me.tbGoldDetails = New System.Windows.Forms.TabPage
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.pnlGoldDetails = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
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
        Me.btnWithdraw = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCalc = New BankControls.NewButton
        Me.NewButton2 = New BankControls.NewButton
        Me.btnSurety = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.btnLoanList = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbGoldLoanDetails.SuspendLayout()
        Me.tbGoldDetails.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbGoldLoanDetails)
        Me.TabControl1.Controls.Add(Me.tbGoldDetails)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(32, 120)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 416)
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.TabStop = False
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.Khaki
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.cmbAccType)
        Me.tbPersonal.Controls.Add(Me.Label102)
        Me.tbPersonal.Controls.Add(Me.Label46)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo2)
        Me.tbPersonal.Controls.Add(Me.Label45)
        Me.tbPersonal.Controls.Add(Me.btnSBSearch)
        Me.tbPersonal.Controls.Add(Me.Label44)
        Me.tbPersonal.Controls.Add(Me.Panel2)
        Me.tbPersonal.Controls.Add(Me.Panel3)
        Me.tbPersonal.Controls.Add(Me.Label16)
        Me.tbPersonal.Controls.Add(Me.txtFatherName)
        Me.tbPersonal.Controls.Add(Me.chkSame)
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
        Me.tbPersonal.Controls.Add(Me.txtSBNo)
        Me.tbPersonal.Controls.Add(Me.Label39)
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(720, 387)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(304, 16)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Customer No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(160, 16)
        Me.txtCustomerID.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(136, 23)
        Me.txtCustomerID.SpecialChar = False
        Me.txtCustomerID.TabIndex = 3
        Me.txtCustomerID.Text = "CID"
        '
        'cmbAccType
        '
        Me.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(504, 312)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(136, 24)
        Me.cmbAccType.TabIndex = 25
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(352, 312)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(94, 19)
        Me.Label102.TabIndex = 120
        Me.Label102.Text = "Loan Type  : "
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(352, 280)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(95, 19)
        Me.Label46.TabIndex = 114
        Me.Label46.Text = "Mobile No2  :"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.AfterDecimal = 0
        Me.txtMobileNo2.BeforeDecimal = 10
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo2.Location = New System.Drawing.Point(504, 280)
        Me.txtMobileNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo2.MaxLength = 10
        Me.txtMobileNo2.MaxValue = 0
        Me.txtMobileNo2.MinValue = 0
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo2.TabIndex = 24
        Me.txtMobileNo2.Text = ""
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(352, 168)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(117, 19)
        Me.Label45.TabIndex = 101
        Me.Label45.Text = "Office Address  :"
        '
        'btnSBSearch
        '
        Me.btnSBSearch.BackColor = System.Drawing.Color.Khaki
        Me.btnSBSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSBSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSBSearch.Image = CType(resources.GetObject("btnSBSearch.Image"), System.Drawing.Image)
        Me.btnSBSearch.Location = New System.Drawing.Point(304, 48)
        Me.btnSBSearch.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnSBSearch.Name = "btnSBSearch"
        Me.btnSBSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSBSearch.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Khaki
        Me.Label44.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(24, 88)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(123, 19)
        Me.Label44.TabIndex = 74
        Me.Label44.Text = "Husband Name  :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(160, 216)
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
        Me.Panel3.Controls.Add(Me.rdbMajor)
        Me.Panel3.Controls.Add(Me.rdbMinor)
        Me.Panel3.Enabled = False
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(160, 176)
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
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Age Status :"
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.AutoSize = False
        Me.txtFatherName.BlankSpace = False
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFatherName.Location = New System.Drawing.Point(160, 80)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 24)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 7
        Me.txtFatherName.Text = ""
        '
        'chkSame
        '
        Me.chkSame.BackColor = System.Drawing.Color.Khaki
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(504, 88)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(200, 24)
        Me.chkSame.TabIndex = 19
        Me.chkSame.Text = "same as permanent address"
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(160, 288)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 17
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(160, 256)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 19)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Present /"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(160, 112)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtpDOB.TabIndex = 8
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father/ "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion  :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(352, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation  :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(344, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Permanent Address  : "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(504, 120)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(168, 24)
        Me.cmbOccupation.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(352, 216)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 19)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No.  :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(352, 248)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 19)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No1  :"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(160, 144)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 23)
        Me.txtAge.TabIndex = 9
        Me.txtAge.Text = ""
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.AutoSize = False
        Me.txtPresAddress.BlankSpace = True
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtPresAddress.Location = New System.Drawing.Point(504, 152)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 100
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 56)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 21
        Me.txtPresAddress.Text = ""
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(504, 216)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.TabIndex = 22
        Me.txtPhoneNo.Text = ""
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(504, 248)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.TabIndex = 23
        Me.txtMobileNo.Text = ""
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.AutoSize = False
        Me.txtPermAddress.BlankSpace = True
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtPermAddress.Location = New System.Drawing.Point(504, 16)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 18
        Me.txtPermAddress.Text = ""
        '
        'txtSBNo
        '
        Me.txtSBNo.AlphaNumeric = True
        Me.txtSBNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSBNo.BlankSpace = True
        Me.txtSBNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBNo.Location = New System.Drawing.Point(160, 48)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.ReadOnly = True
        Me.txtSBNo.Size = New System.Drawing.Size(136, 23)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 5
        Me.txtSBNo.Text = ""
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Khaki
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(24, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(86, 19)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "SB/CA No. :"
        '
        'tbGoldLoanDetails
        '
        Me.tbGoldLoanDetails.BackColor = System.Drawing.Color.Khaki
        Me.tbGoldLoanDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbGoldLoanDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtInstAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedNo)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label20)
        Me.tbGoldLoanDetails.Controls.Add(Me.lvSuretyDetail)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label105)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDemandSancDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label106)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtpurpose)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label13)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label40)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label41)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtInstallments)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpGoldLoanDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbModeOfPayment)
        Me.tbGoldLoanDetails.Controls.Add(Me.cmbInstallmentType)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label34)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label19)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtGoldAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label18)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label11)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtExpectedAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtSanctionedAmount)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label21)
        Me.tbGoldLoanDetails.Controls.Add(Me.txtROI)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label22)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label23)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label37)
        Me.tbGoldLoanDetails.Controls.Add(Me.dtpDueDate)
        Me.tbGoldLoanDetails.Controls.Add(Me.Label38)
        Me.tbGoldLoanDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldLoanDetails.Name = "tbGoldLoanDetails"
        Me.tbGoldLoanDetails.Size = New System.Drawing.Size(720, 387)
        Me.tbGoldLoanDetails.TabIndex = 4
        Me.tbGoldLoanDetails.Text = "Jewel Loan Details"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(504, 216)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(160, 23)
        Me.txtReceiptNo.TabIndex = 14
        Me.txtReceiptNo.Text = ""
        '
        'txtInstAmount
        '
        Me.txtInstAmount.AfterDecimal = 0
        Me.txtInstAmount.BackColor = System.Drawing.Color.White
        Me.txtInstAmount.BeforeDecimal = 8
        Me.txtInstAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInstAmount.Location = New System.Drawing.Point(504, 88)
        Me.txtInstAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInstAmount.MaxLength = 8
        Me.txtInstAmount.MaxValue = 0
        Me.txtInstAmount.MinValue = 0
        Me.txtInstAmount.Name = "txtInstAmount"
        Me.txtInstAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtInstAmount.TabIndex = 10
        Me.txtInstAmount.Text = ""
        '
        'txtSanctionedNo
        '
        Me.txtSanctionedNo.AlphaNumeric = True
        Me.txtSanctionedNo.AutoSize = False
        Me.txtSanctionedNo.BlankSpace = False
        Me.txtSanctionedNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanctionedNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSanctionedNo.Location = New System.Drawing.Point(168, 184)
        Me.txtSanctionedNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSanctionedNo.Mandatory = False
        Me.txtSanctionedNo.MaxLength = 30
        Me.txtSanctionedNo.Name = "txtSanctionedNo"
        Me.txtSanctionedNo.Size = New System.Drawing.Size(160, 24)
        Me.txtSanctionedNo.SpecialChar = True
        Me.txtSanctionedNo.TabIndex = 6
        Me.txtSanctionedNo.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 19)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "Surety Person Detail"
        '
        'lvSuretyDetail
        '
        Me.lvSuretyDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvSuretyDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSuretyDetail.FullRowSelect = True
        Me.lvSuretyDetail.GridLines = True
        Me.lvSuretyDetail.Location = New System.Drawing.Point(16, 280)
        Me.lvSuretyDetail.Name = "lvSuretyDetail"
        Me.lvSuretyDetail.Size = New System.Drawing.Size(656, 96)
        Me.lvSuretyDetail.TabIndex = 152
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
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(16, 184)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(118, 19)
        Me.Label105.TabIndex = 151
        Me.Label105.Text = "Sanctioned No. :"
        '
        'dtpDemandSancDate
        '
        Me.dtpDemandSancDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDemandSancDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDemandSancDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDemandSancDate.Location = New System.Drawing.Point(168, 152)
        Me.dtpDemandSancDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpDemandSancDate.Name = "dtpDemandSancDate"
        Me.dtpDemandSancDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDemandSancDate.TabIndex = 5
        Me.dtpDemandSancDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.Khaki
        Me.Label106.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(16, 152)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(126, 19)
        Me.Label106.TabIndex = 150
        Me.Label106.Text = "Sanctioned Date :"
        '
        'txtpurpose
        '
        Me.txtpurpose.AlphaNumeric = True
        Me.txtpurpose.AutoSize = False
        Me.txtpurpose.BlankSpace = False
        Me.txtpurpose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurpose.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtpurpose.Location = New System.Drawing.Point(504, 184)
        Me.txtpurpose.LostFocusColour = System.Drawing.Color.Empty
        Me.txtpurpose.Mandatory = False
        Me.txtpurpose.MaxLength = 30
        Me.txtpurpose.Name = "txtpurpose"
        Me.txtpurpose.Size = New System.Drawing.Size(160, 24)
        Me.txtpurpose.SpecialChar = True
        Me.txtpurpose.TabIndex = 13
        Me.txtpurpose.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Khaki
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(352, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 19)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Instralement Amount:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(352, 216)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(93, 19)
        Me.Label40.TabIndex = 35
        Me.Label40.Text = "Receipt No. :"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(352, 24)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(142, 19)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "No Of Installments :"
        '
        'txtInstallments
        '
        Me.txtInstallments.AfterDecimal = 0
        Me.txtInstallments.BeforeDecimal = 3
        Me.txtInstallments.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallments.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInstallments.Location = New System.Drawing.Point(504, 24)
        Me.txtInstallments.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInstallments.MaxLength = 3
        Me.txtInstallments.MaxValue = 0
        Me.txtInstallments.MinValue = 0
        Me.txtInstallments.Name = "txtInstallments"
        Me.txtInstallments.Size = New System.Drawing.Size(64, 23)
        Me.txtInstallments.TabIndex = 8
        Me.txtInstallments.Text = ""
        '
        'dtpGoldLoanDate
        '
        Me.dtpGoldLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpGoldLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGoldLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGoldLoanDate.Location = New System.Drawing.Point(168, 56)
        Me.dtpGoldLoanDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpGoldLoanDate.Name = "dtpGoldLoanDate"
        Me.dtpGoldLoanDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpGoldLoanDate.TabIndex = 2
        Me.dtpGoldLoanDate.Value = New Date(2008, 7, 23, 0, 0, 0, 0)
        '
        'cmbModeOfPayment
        '
        Me.cmbModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeOfPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeOfPayment.Items.AddRange(New Object() {"Cheque", "Cash", "DD"})
        Me.cmbModeOfPayment.Location = New System.Drawing.Point(504, 152)
        Me.cmbModeOfPayment.Name = "cmbModeOfPayment"
        Me.cmbModeOfPayment.Size = New System.Drawing.Size(160, 24)
        Me.cmbModeOfPayment.TabIndex = 12
        '
        'cmbInstallmentType
        '
        Me.cmbInstallmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstallmentType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInstallmentType.Items.AddRange(New Object() {"Monthly", "Quaterly", "Yearly"})
        Me.cmbInstallmentType.Location = New System.Drawing.Point(504, 120)
        Me.cmbInstallmentType.Name = "cmbInstallmentType"
        Me.cmbInstallmentType.Size = New System.Drawing.Size(160, 24)
        Me.cmbInstallmentType.TabIndex = 11
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(352, 184)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(128, 19)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Purpose of Loan  :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 19)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Sanctioned Amount  :"
        '
        'txtGoldAmount
        '
        Me.txtGoldAmount.AfterDecimal = 2
        Me.txtGoldAmount.BeforeDecimal = 7
        Me.txtGoldAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtGoldAmount.Location = New System.Drawing.Point(168, 88)
        Me.txtGoldAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtGoldAmount.MaxLength = 8
        Me.txtGoldAmount.MaxValue = 0
        Me.txtGoldAmount.MinValue = 0
        Me.txtGoldAmount.Name = "txtGoldAmount"
        Me.txtGoldAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtGoldAmount.TabIndex = 3
        Me.txtGoldAmount.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 19)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Estimated Amount :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Amount Applied  :"
        '
        'txtExpectedAmount
        '
        Me.txtExpectedAmount.AfterDecimal = 2
        Me.txtExpectedAmount.BeforeDecimal = 7
        Me.txtExpectedAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpectedAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtExpectedAmount.Location = New System.Drawing.Point(168, 24)
        Me.txtExpectedAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtExpectedAmount.MaxLength = 8
        Me.txtExpectedAmount.MaxValue = 0
        Me.txtExpectedAmount.MinValue = 0
        Me.txtExpectedAmount.Name = "txtExpectedAmount"
        Me.txtExpectedAmount.Size = New System.Drawing.Size(160, 23)
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
        Me.txtSanctionedAmount.Location = New System.Drawing.Point(168, 120)
        Me.txtSanctionedAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSanctionedAmount.MaxLength = 8
        Me.txtSanctionedAmount.MaxValue = 0
        Me.txtSanctionedAmount.MinValue = 0
        Me.txtSanctionedAmount.Name = "txtSanctionedAmount"
        Me.txtSanctionedAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtSanctionedAmount.TabIndex = 4
        Me.txtSanctionedAmount.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 216)
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
        Me.txtROI.Location = New System.Drawing.Point(168, 216)
        Me.txtROI.LostFocusColour = System.Drawing.Color.White
        Me.txtROI.MaxLength = 5
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(64, 23)
        Me.txtROI.TabIndex = 7
        Me.txtROI.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(352, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 19)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Installment Type :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(352, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(143, 19)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Re-Payment Mode : "
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(16, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(101, 19)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "Applied Date :"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(504, 56)
        Me.dtpDueDate.MaxDate = New Date(9998, 12, 16, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDueDate.TabIndex = 9
        Me.dtpDueDate.Value = New Date(2007, 4, 11, 0, 0, 0, 0)
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(352, 56)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 19)
        Me.Label38.TabIndex = 13
        Me.Label38.Text = "Due Date :"
        '
        'tbGoldDetails
        '
        Me.tbGoldDetails.BackColor = System.Drawing.Color.Khaki
        Me.tbGoldDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbGoldDetails.Controls.Add(Me.Label15)
        Me.tbGoldDetails.Controls.Add(Me.Label33)
        Me.tbGoldDetails.Controls.Add(Me.Label31)
        Me.tbGoldDetails.Controls.Add(Me.Label30)
        Me.tbGoldDetails.Controls.Add(Me.Label29)
        Me.tbGoldDetails.Controls.Add(Me.Label28)
        Me.tbGoldDetails.Controls.Add(Me.Label27)
        Me.tbGoldDetails.Controls.Add(Me.pnlGoldDetails)
        Me.tbGoldDetails.Controls.Add(Me.Panel4)
        Me.tbGoldDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbGoldDetails.Name = "tbGoldDetails"
        Me.tbGoldDetails.Size = New System.Drawing.Size(720, 387)
        Me.tbGoldDetails.TabIndex = 3
        Me.tbGoldDetails.Text = "Security Details"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(432, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 19)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Appraised Wt"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(616, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 16)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "Estimated "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(544, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 19)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Rate/"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(440, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 19)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Net Wt or"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(344, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 19)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Gross Wt"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(72, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 19)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "JewelType"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 19)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "SLNo ."
        '
        'pnlGoldDetails
        '
        Me.pnlGoldDetails.AutoScroll = True
        Me.pnlGoldDetails.BackColor = System.Drawing.Color.Khaki
        Me.pnlGoldDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGoldDetails.Location = New System.Drawing.Point(8, 80)
        Me.pnlGoldDetails.Name = "pnlGoldDetails"
        Me.pnlGoldDetails.Size = New System.Drawing.Size(696, 272)
        Me.pnlGoldDetails.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Khaki
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Location = New System.Drawing.Point(8, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(696, 48)
        Me.Panel4.TabIndex = 12
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(624, 24)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(47, 19)
        Me.Label43.TabIndex = 15
        Me.Label43.Text = "Value"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(536, 24)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(45, 19)
        Me.Label42.TabIndex = 14
        Me.Label42.Text = "Gram"
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.Khaki
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.tbOthers.Size = New System.Drawing.Size(720, 387)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.AutoSize = False
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(144, 280)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(480, 72)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 5
        Me.txtRemarks.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(64, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 19)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Remarks :"
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.Khaki
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(144, 232)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 1
        Me.btnLoadPhoto.Text = "Load"
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.Khaki
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(224, 232)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 2
        Me.btnCancelPhoto.Text = "Cancel"
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(464, 32)
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
        Me.lblSignature.Location = New System.Drawing.Point(376, 32)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(85, 19)
        Me.lblSignature.TabIndex = 2
        Me.lblSignature.Text = "Signature  :"
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(144, 32)
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
        Me.lblPhoto.Location = New System.Drawing.Point(80, 32)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(58, 19)
        Me.lblPhoto.TabIndex = 1
        Me.lblPhoto.Text = "Photo  :"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.Khaki
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnCancelSign.Location = New System.Drawing.Point(544, 232)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 4
        Me.btnCancelSign.Text = "Cancel"
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.Khaki
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(464, 232)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 3
        Me.btnLoadSign.Text = "Load"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtName.Location = New System.Drawing.Point(456, 72)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.Khaki
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(16, 376)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(168, 40)
        Me.btnWithdraw.TabIndex = 6
        Me.btnWithdraw.Text = "&Disbursment"
        Me.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.Khaki
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 416)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.Khaki
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 7
        Me.NewButton5.Text = "&View Transaction Log"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.Khaki
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(16, 336)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(168, 40)
        Me.btnDeposit.TabIndex = 5
        Me.btnDeposit.Text = "R&epayment"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Khaki
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnOk.Location = New System.Drawing.Point(568, 544)
        Me.btnOk.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 26
        Me.btnOk.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Khaki
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(664, 544)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&Cancel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "JewelLoan No. :"
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = True
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(192, 72)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 7
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 0
        Me.txtAccNo.Text = "JL"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(328, 72)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnSurety)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.Controls.Add(Me.btnLoanList)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Khaki
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(16, 488)
        Me.btnCalc.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(168, 40)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Additional Charges"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.Khaki
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 192)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.Khaki
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(168, 40)
        Me.NewButton2.TabIndex = 3
        Me.NewButton2.Text = "&Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSurety
        '
        Me.btnSurety.BackColor = System.Drawing.Color.Khaki
        Me.btnSurety.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSurety.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSurety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurety.ForeColor = System.Drawing.Color.Black
        Me.btnSurety.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnSurety.Image = CType(resources.GetObject("btnSurety.Image"), System.Drawing.Image)
        Me.btnSurety.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSurety.Location = New System.Drawing.Point(16, 232)
        Me.btnSurety.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnSurety.Name = "btnSurety"
        Me.btnSurety.Size = New System.Drawing.Size(168, 40)
        Me.btnSurety.TabIndex = 4
        Me.btnSurety.Text = "Surety &Person Details"
        Me.btnSurety.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.Khaki
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 152)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 2
        Me.btnNominees.Text = "&Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLoanList
        '
        Me.btnLoanList.BackColor = System.Drawing.Color.Khaki
        Me.btnLoanList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanList.ForeColor = System.Drawing.Color.Black
        Me.btnLoanList.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnLoanList.Image = CType(resources.GetObject("btnLoanList.Image"), System.Drawing.Image)
        Me.btnLoanList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoanList.Location = New System.Drawing.Point(16, 360)
        Me.btnLoanList.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnLoanList.Name = "btnLoanList"
        Me.btnLoanList.Size = New System.Drawing.Size(168, 40)
        Me.btnLoanList.TabIndex = 6
        Me.btnLoanList.Text = "View Loan List"
        Me.btnLoanList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoanList.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(32, 544)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.Khaki
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "&Reset"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Khaki
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
        Me.GroupBox2.Size = New System.Drawing.Size(800, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Khaki
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Olive
        Me.Label32.Location = New System.Drawing.Point(96, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(170, 25)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Jewel Loan Details"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Khaki
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'frmGoldLoanDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(236, Byte), CType(244, Byte), CType(132, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 607)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGoldLoanDetails"
        Me.ShowInTaskbar = False
        Me.Text = "Jewel Loan Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbGoldLoanDetails.ResumeLayout(False)
        Me.tbGoldDetails.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.tbOthers.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmGoldLoanDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmGoldLoanDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmGoldLoanDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmGoldLoanDetails)
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
        Dim intCount As Integer

        If Trim(txtAccNo.Text) = "JL" Then
            MsgBox("Enter loanno", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name ", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
            'ElseIf Trim(txtMemberNo.Text) = "" And Trim(txtSBNo.Text) = "" Then
            '    MsgBox("Enter member number or SB number ")
            '    btnMemSearch.Focus()
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
        ElseIf Trim(txtGoldAmount.Text) = "" Then
            MsgBox("Enter estimated amount for loan", MsgBoxStyle.Exclamation)
            txtGoldAmount.Focus()
            Return False
        ElseIf Trim(txtSanctionedAmount.Text) = "" Then
            MsgBox("Please check the sanctioned amount", MsgBoxStyle.Information)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf Val(txtSanctionedAmount.Text) > Val(txtGoldAmount.Text) Then
            MsgBox("Please check the sanctioned amount", MsgBoxStyle.Information)
            txtSanctionedAmount.Focus()
            Return False
        ElseIf Trim(txtSanctionedNo.Text) = String.Empty Then
            MsgBox("Please enter sanctioned number", MsgBoxStyle.Information)
            txtSanctionedNo.Focus()
            Return False
        ElseIf Trim(txtROI.Text) = String.Empty Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False
        ElseIf Trim(txtInstallments.Text) = "" Then
            MsgBox("Enter number of installments", MsgBoxStyle.Exclamation)
            txtInstallments.Focus()
            Return False
        ElseIf cmbInstallmentType.SelectedIndex = -1 Then
            MsgBox("Select installment for loan payment", MsgBoxStyle.Exclamation)
            cmbInstallmentType.Focus()
            Return False
        ElseIf cmbModeOfPayment.SelectedIndex = -1 Then
            MsgBox("Select mode of payment for loan", MsgBoxStyle.Exclamation)
            cmbModeOfPayment.Focus()
            Return False
        ElseIf Trim(txtpurpose.Text) = String.Empty Then
            MsgBox("Enter reason for loan", MsgBoxStyle.Exclamation)
            txtpurpose.Focus()
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Please enter receiptno", MsgBoxStyle.Exclamation, "Loan Module")
            txtReceiptNo.Focus()
            Return False
        ElseIf (dtpDemandSancDate.Value < dtpGoldLoanDate.Value) Then
            MsgBox("Sanctioned date should be greater than Applied date", MsgBoxStyle.Information)
            dtpGoldLoanDate.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Function fnCheckItems() As Boolean
        Dim intCount As Integer

        While intCount < pnlGoldDetails.Controls.Count

            If GoldLoanDet(intCount).txtGoldDetails.Text <> "" Then

                If GoldLoanDet(intCount).txtGoldWeight.Text = String.Empty Then
                    MsgBox("Enter gold weight", MsgBoxStyle.Exclamation)
                    GoldLoanDet(intCount).txtGoldWeight.Focus()
                    Return False
                ElseIf GoldLoanDet(intCount).txtNetWeight.Text = String.Empty Then
                    MsgBox("Enter net weight", MsgBoxStyle.Exclamation)
                    GoldLoanDet(intCount).txtNetWeight.Focus()
                    Return False
                ElseIf GoldLoanDet(intCount).txtPurity.Text = String.Empty Then
                    MsgBox("Enter purity of gold", MsgBoxStyle.Exclamation)
                    GoldLoanDet(intCount).txtPurity.Focus()
                    Return False
                ElseIf GoldLoanDet(intCount).txtTotalWeight.Text = String.Empty Then
                    MsgBox("Enter total weight of gold", MsgBoxStyle.Exclamation)
                    GoldLoanDet(intCount).txtTotalWeight.Focus()
                    Return False
                End If
                intCount += 1
            Else
                Return True
            End If
        End While
        Return True
    End Function

    Function fnLoadSuretyPerson()
        Dim objdT As New DataTable
        Dim lvItem As ListViewItem
        Dim IntCounter As Integer = 0
        lvSuretyDetail.Items.Clear()
        If objSurety.fnGetSurety(txtAccNo.Text, "S") Then
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

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objSBAccount.fnCheckGoldAccount(Trim(txtAccNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objSBAccount.fnAddGLAccount(objTrans) = True Then

                'fnGenerateVoucher()
                'Log Entry
                fnLogEntry(pbUserId, "New JL created " & txtAccNo.Text, Date.Now, "new JL", objTrans)
                MessageBox.Show("New jewel loan created successfully.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New jewel loan creation failed, because of internal error.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objSBAccount.fnUpdateGLAccount(Trim(txtAccNo.Text), objTrans) Then
                objSBAccount.fnUpdateGLWitnessDet(objTrans)
                fnUpdateGLItemsDetails(objTrans)
                fnLogEntry(pbUserId, "JL updated" & txtAccNo.Text, Date.Now, "update JL account", objTrans)
                MessageBox.Show("Jewel loan updated successfully.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Jewel loan updation failed, because of internal error.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If
    End Function

    Function fnUpdateGLItemsDetails(ByVal objTrans As IDbTransaction) As Boolean
        If objSBAccount.fnDeleteGLItemsAccount(Trim(txtAccNo.Text), objTrans) Then
            If objSBAccount.fnInsertGlDetailsAccount(objTrans) Then
            End If
        End If
    End Function


    Function fnSetData() As Boolean
        ' Person Deatils
        Dim dtGoldTable As DataTable
        Dim dtGoldDet As GoldLoanControl
        Dim i As Integer
        Dim dr As DataRow
        If lngPersonNo <> 0 Then
            objSBAccount.PersonNo = lngPersonNo
        Else
            objSBAccount.PersonNo = objSBAccount.fnGetNewPersonNo()
        End If
        objSBAccount.Name = txtName.Text
        objSBAccount.FatherName = txtFatherName.Text
        objSBAccount.PermAddress = txtPermAddress.Text
        objSBAccount.PresAddress = txtPresAddress.Text

        If txtPhoneNo.Text = "" Then
            objSBAccount.PhoneNo = 0
        Else
            objSBAccount.PhoneNo = txtPhoneNo.Text
        End If

        If txtMobileNo.Text = "" Then
            objSBAccount.MobileNo = 0
        Else
            objSBAccount.MobileNo = txtMobileNo.Text
        End If

        objSBAccount.DOB = dtpDOB.Value
        objSBAccount.Age = txtAge.Text
        objSBAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objSBAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objSBAccount.ReligionCode = cmbReligion.SelectedValue
        objSBAccount.CasteCode = cmbCaste.SelectedValue
        objSBAccount.OccupationCode = cmbOccupation.SelectedValue
        objSBAccount.ReciptNo = txtReceiptNo.Text
        ' objSBAccount.Photo = fnGetPhoto()
        objSBAccount.Photo = picPhoto.ImageLocation

        'objSBAccount.Sign = fnGetSign()
        objSBAccount.Sign = picSignature.ImageLocation
        objSBAccount.OfficeNo = OfficeNo

        'Sb Details

        objSBAccount.SBNo = txtSBNo.Text
        objSBAccount.MemberNo = txtCustomerID.Text

        dtGoldTable = New DataTable
        dtGoldTable.Columns.Add("GoldLoanNo")
        dtGoldTable.Columns.Add("GoldType")
        dtGoldTable.Columns.Add("Weight")
        dtGoldTable.Columns.Add("NetWeight")
        dtGoldTable.Columns.Add("Purity")
        dtGoldTable.Columns.Add("TotalWeight")

        While i < 10

            dtGoldDet = pnlGoldDetails.Controls(i)
            dr = dtGoldTable.NewRow
            dr(0) = txtAccNo.Text
            If dtGoldDet.GoldDetails.Text <> "" Then
                dr(1) = dtGoldDet.GoldDetails.Text
                dr(2) = dtGoldDet.GoldWeight.Text
                dr(3) = dtGoldDet.netWeight.Text
                dr(4) = dtGoldDet.Purity.Text
                dr(5) = dtGoldDet.txtTotalWeight.Text
                dtGoldTable.Rows.Add(dr)
            End If
            i += 1
        End While
        dr = Nothing
        objSBAccount.GoldDetailsTable = dtGoldTable

        objSBAccount.GoldNo = txtAccNo.Text
        objSBAccount.GoldReason = txtpurpose.Text
        objSBAccount.GoldROI = (txtROI.Text / 100)
        objSBAccount.GoldSanctioned = txtSanctionedAmount.Text
        objSBAccount.GoldExpectedAmount = txtExpectedAmount.Text
        objSBAccount.GoldInstallments = cmbInstallmentType.SelectedItem
        objSBAccount.GoldModeOfPayment = cmbModeOfPayment.SelectedItem
        objSBAccount.GoldDate = dtpGoldLoanDate.Value
        objSBAccount.SBNo = txtSBNo.Text
        objSBAccount.GoldInstPrinciple = Val(txtInstAmount.Text)

        objSBAccount.GoldSancDate = dtpDemandSancDate.Value
        objSBAccount.GoldSancNo = txtSanctionedNo.Text
        objSBAccount.GoldMobileNo2 = txtMobileNo2.Text

        Select Case cmbAccType.SelectedItem
            Case "Joint"
                objSBAccount.LoanType = "J"
            Case "Single"
                objSBAccount.LoanType = "S"
        End Select


        objSBAccount.GoldDueDate = dtpDueDate.Value
        objSBAccount.GoldSubsidy = ""
        objSBAccount.GoldAmtBalance = 0
        If txtInstallments.Text = "" Then
            objSBAccount.NOI = 0
        Else
            objSBAccount.NOI = txtInstallments.Text
        End If

        objSBAccount.Status = "Active"
        objSBAccount.GoldDisbAmt = 0

        If txtGoldAmount.Text = "" Then
            objSBAccount.GoldAmt = 0
        Else
            objSBAccount.GoldAmt = txtGoldAmount.Text
        End If
        objSBAccount.GoldLastPaidDate = "9999-9-9"
        objSBAccount.GoldLastInstDate = "9999-9-9"

        objSBAccount.Remarks = txtRemarks.Text
        objSBAccount.ReciptNo = txtReceiptNo.Text

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

    Function fnGenerateVoucher() As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpGoldLoanDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery

        '   '   'objSBAccount.fnSbtransactionEnter(Trim(txtAccNo.Text), dtpGoldLoanDate.Value, "By New SB Account  " & txtAccNo.Text, Trim(txtAvailBal.Text), 0, Trim(txtAvailBal.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0)

        'voucher details

        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReceiptNo.Text, dtpGoldLoanDate.Value, txtSanctionedAmount.Text, "By new jewel loan" & txtCustomerID.Text, lngSlNo, "Y")

        'Credit accounts

        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpGoldLoanDate.Value, "By jewel loan  " & txtAccNo.Text, "To", 1, 0, Val(txtSanctionedAmount.Text), 1, "Y")

        'Debit accounts 

        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpGoldLoanDate.Value, "By cash account " & txtAccNo.Text, "By", 15, Val(txtSanctionedAmount.Text), 0, 2, "Y")

        Return True

    End Function

    Public Function fnLoadGoldDetails() As Boolean
        Dim intCount As Integer = 0
        Dim Controlht As Integer = 0
        While intCount < 10

            GoldLoanDet(intCount) = New GoldLoanControl
            Controlht = GoldLoanDet(intCount).Height
            GoldLoanDet(intCount).Top = Controlht * intCount
            pnlGoldDetails.Controls.Add(GoldLoanDet(intCount))

            pnlGoldDetails.Controls.Add(GoldLoanDet(intCount))
            intCount += 1

        End While

    End Function

    Public Function fnGetROI() As Boolean

        If objSBAccount.fnGetROI(txtAccNo.Text, txtSanctionedAmount.Text) Then

            txtROI.Text = (objSBAccount.Loantypetable.Rows(0).Item("ROI"))

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
                If fnCheckItems() Then
                    If fnSetData() Then
                        If fnSaveData(objTrans) Then
                            objTrans.Commit()
                        End If
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
        dtpDOB.MaxDate = Date.Now.Date
        dtpDOB.Value = Date.Now.Date
        dtpDueDate.Value = Date.Now.Date
        dtpGoldLoanDate.Value = Date.Now.Date
        dtpDemandSancDate.Value = Date.Now
        sbLoadControlValues() 'Load Values 

        nMode = CTAdd
        If txtAccNo.Text <> String.Empty Then
            sbLoadGLAccDetails()
            txtAccNo.Text = "JL"
        End If
        btnAdd_Click(sender, e)
        txtAccNo.Focus()
        fnLoadGoldDetails()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objfrmGoldLoanCust As New frmGoldLoanCust
        objfrmGoldLoanCust.strGoldLoan = String.Empty
        objfrmGoldLoanCust.ShowDialog(Me)
        If objfrmGoldLoanCust.strGoldLoan <> String.Empty Then
            txtAccNo.Text = objfrmGoldLoanCust.strGoldLoan
            sbLoadGLAccDetails()
        End If
        objfrmGoldLoanCust.Dispose()

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
        If objclsRepyment.fnGetData(txtAccNo.Text) Then
            If objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") <> 0 Then
                Dim ObjfrmRePayment As New FrmRePayement
                ObjfrmRePayment.txtLoanNo.Text = txtAccNo.Text
                ObjfrmRePayment.txtName.Text = txtName.Text
                ObjfrmRePayment.ShowDialog(Me)
            Else
                MsgBox("Please disbursement the amount first", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Enter valid loanno", MsgBoxStyle.Information, "Loan Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        If objSBAccount.fnCheckGoldAccount(Trim(txtAccNo.Text)) = True Then
            Dim ObjfrmDisbAmt As New frmDisbursment
            ObjfrmDisbAmt.txtLoanNo.Text = txtAccNo.Text
            ObjfrmDisbAmt.ShowDialog(Me)
        Else
            MsgBox("Enter valid loanno", MsgBoxStyle.Information, "Loan Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If objSBAccount.fnCheckGoldAccount(Trim(txtAccNo.Text)) = True Then
            Dim objfrmTransaction As New frmTransaction
            objfrmTransaction.txtLoanNo.Text = txtAccNo.Text
            objfrmTransaction.txtName.Text = txtName.Text
            objfrmTransaction.ShowDialog(Me)
        Else
            MsgBox("Enter valid loanno", MsgBoxStyle.Information, "Loan Module")
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
        sbClear()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objSBAccount.fnGetNewLoanNo("JL"), 3, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "JL" & String.Format("{0:00000}", CInt(TempNewNo))
            txtAccNo.Text = Temp
            txtAccNo.Focus()
        Else
            MsgBox("JL number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
        End If




    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        txtPermAddress_TextChanged(Me, e.Empty)
    End Sub

#End Region

#Region "Genral Subroutines"

    Sub sbLoadGLAccDetails()
        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Dim intCount As Integer
        Dim objGoldItemDet As DataTable

        Try
            If objSBAccount.fnGetGLAccountDetails(txtAccNo.Text) Then
                sbClear()

                objDT = objSBAccount.GoldLoanTable

                'Sb Details

                txtAccNo.Text = objDT.Rows(0).Item("LoanNo")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
               

                Dim str As String = objDT.Rows(0).Item("SBNo")
                Dim TempNewNo As String = Mid(str, 1, 2)
                If (TempNewNo = "CA") Then
                    Label39.Text = "CA No. :"
                Else
                    Label39.Text = "SB No. :"
                End If
                txtSBNo.Text = objDT.Rows(0).Item("SBNo")
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

                txtExpectedAmount.Text = objDT.Rows(0).Item("ExpAmount")
                txtSanctionedAmount.Text = objDT.Rows(0).Item("Sancamount")
                txtROI.Text = (objDT.Rows(0).Item("ROI") * 100)
                cmbInstallmentType.SelectedItem = objDT.Rows(0).Item("Type")
                cmbModeOfPayment.Text = objDT.Rows(0).Item("RepayMode")
                txtpurpose.Text = objDT.Rows(0).Item("Purpose")
                dtpGoldLoanDate.Text = Format(objDT.Rows(0).Item("ApplDate"), "yyyy-MM-dd")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtInstallments.Text = objDT.Rows(0).Item("NOI")
                txtInstAmount.Text = objDT.Rows(0).Item("InstPrinciple")
                dtpDueDate.Value = Format(objDT.Rows(0).Item("DueDate"), "yyyy-MM-dd")
                txtGoldAmount.Text = objDT.Rows(0).Item("GoldAmount")
                txtSBNo.Text = objDT.Rows(0).Item("SBNo")
                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")
                txtCustomerID.Text = objDT.Rows(0).Item("MemberNo")

                txtSanctionedNo.Text = objDT.Rows(0).Item("SancNo")
                dtpDemandSancDate.Value = objDT.Rows(0).Item("SancDate")
                txtMobileNo2.Text = objDT.Rows(0).Item("MobileNo2")


                Select Case objDT.Rows(0).Item("LoanType")
                    Case "S"
                        cmbAccType.SelectedItem = "Single"
                    Case "J"
                        cmbAccType.SelectedItem = "Joint"
                End Select


                If objSBAccount.fnGetGoldDetails(txtAccNo.Text) = True Then
                    objGoldItemDet = objSBAccount.GoldLoanItemDetTable
                    While intCount < objGoldItemDet.Rows.Count
                        GoldLoanDet(intCount).txtSlNo.Text = intCount + 1
                        GoldLoanDet(intCount).txtGoldDetails.Text = objGoldItemDet.Rows(intCount).Item("GoldType")
                        GoldLoanDet(intCount).txtGoldWeight.Text = objGoldItemDet.Rows(intCount).Item("Weight")
                        GoldLoanDet(intCount).txtNetWeight.Text = objGoldItemDet.Rows(intCount).Item("NetWeight")
                        GoldLoanDet(intCount).txtPurity.Text = objGoldItemDet.Rows(intCount).Item("Purity")
                        GoldLoanDet(intCount).txtTotalWeight.Text = objGoldItemDet.Rows(intCount).Item("TotalWeight")
                        intCount += 1
                    End While
                End If
                fnLoadSuretyPerson()

                'txtSanctionedAmount.ReadOnly = True
                'txtSanctionedAmount.Enabled = False
                'txtROI.Enabled = False
                'txtReceiptNo.ReadOnly = True
                'txtExpectedAmount.ReadOnly = True
                'txtGoldAmount.ReadOnly = True
                'txtAccNo.ReadOnly = True
                'txtInstAmount.ReadOnly = True
                'cmbInstallmentType.Enabled = False
                'dtpDueDate.Enabled = False
                'dtpGoldLoanDate.Enabled = False



            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub sbClear()
        Dim intCount As Integer = 0
        lngPersonNo = 0
        'txtAccNo.Text = "JL"
        txtCustomerID.ResetText()
        txtCustomerID.ResetText()
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpDOB.ResetText()
        rdbMale.Checked = True
        txtSBNo.ResetText()
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
        While intCount < pnlGoldDetails.Controls.Count
            GoldLoanDet(intCount).txtSlNo.ResetText()
            GoldLoanDet(intCount).txtGoldDetails.ResetText()
            GoldLoanDet(intCount).txtGoldWeight.ResetText()
            GoldLoanDet(intCount).txtNetWeight.ResetText()
            GoldLoanDet(intCount).txtPurity.ResetText()
            GoldLoanDet(intCount).txtTotalWeight.ResetText()
            intCount += 1
        End While
        txtExpectedAmount.ResetText()
        txtSanctionedAmount.ResetText()
        txtROI.ResetText()
        txtInstAmount.Text = ""
        txtGoldAmount.ResetText()
        txtReceiptNo.ResetText()
        txtInstallments.ResetText()
        cmbInstallmentType.SelectedIndex = -1
        cmbModeOfPayment.SelectedIndex = -1
        txtpurpose.ResetText()

        txtSanctionedNo.ResetText()
        txtMobileNo2.ResetText()
        lvSuretyDetail.Items.Clear()

        txtSanctionedAmount.ReadOnly = False
        txtGoldAmount.ReadOnly = False
        txtAccNo.ReadOnly = False

        txtSanctionedAmount.Enabled = True
        txtROI.Enabled = True
        txtReceiptNo.ReadOnly = False
        txtExpectedAmount.ReadOnly = False

        btnSBSearch.Enabled = True
        btnMemSearch.Enabled = True
        'txtMemberNo.ReadOnly = False
        ' txtSBNo.ReadOnly = False
        txtInstAmount.ReadOnly = False
        cmbInstallmentType.Enabled = True
        dtpDueDate.Enabled = True
        dtpGoldLoanDate.Enabled = True

    End Sub

    Sub sbLoadSBAccDetails()
        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objSBAccount1.fnGetSBAccountDetails(txtSBNo.Text) Then
                sbClear()

                objDT = objSBAccount1.SBAccTable

                'Sb Details

                txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
                txtSBNo.ReadOnly = True
                txtCustomerID.Text = objDT.Rows(0).Item("MemberNo")
                txtCustomerID.Enabled = False
                btnMemSearch.Enabled = False
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
                        ' msStream.Close()
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


    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        If objSBAccount.fnCheckGoldAccount(Trim(txtAccNo.Text)) = True Then
            If MsgBox("Account no already exists do you want To update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sbLoadGLAccDetails()
            Else
                txtAccNo.Focus()
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

    Private Sub cmbReligion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReligion.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpDOB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpGoldLoanDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpGoldLoanDate.KeyDown
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

    Private Sub txtExpectedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExpectedAmount.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtFatherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFatherName.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtGoldWeight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGoldAmount.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtMemberNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            TabControl1.SelectedIndex = 1
        End If

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

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
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

    Private Sub txtWitnessPerson2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub chkSame_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkSame.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtReceiptNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

#End Region


    Private Sub btnNominees_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtAccNo.Text) <> "JL" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtAccNo.Text
            objNominees.txtName.Text = txtName.Text
            objNominees.chrType = "N"
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Enter valid LoanNo", MsgBoxStyle.Information, "Loan Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub txtSanctionedAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSanctionedAmount.Leave
        If txtSanctionedAmount.Text = "" Then
            MsgBox("Enter Sanctioned Amount To Load Rate Of Intrest")
        Else
            fnGetROI()
        End If

    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSearch.Click
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
        Dim strType1 As String = Mid(objAccountSelection.strAccountNo, 1, 2)
        Dim strType As String = Mid(txtAccNo.Text, 1, 2)
        Select Case strType
            Case "SB"

                Label42.Text = "SB No. :"

            Case "CA"

                Label42.Text = "CA No. :"

        End Select
        If (strType1 = "SB") Then
            Label39.Text = "SB No. :"
        Else
            Label39.Text = "CA No. :"

        End If

        objAccountSelection.Dispose()
    End Sub
    Private Sub txtInstallments_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInstallments.TextChanged
        Dim TempDate As Date
        TempDate = DateAdd(DateInterval.Month, Val(txtInstallments.Text), dtpDemandSancDate.Value)
        dtpDueDate.Value = DateAdd(DateInterval.Day, -1, TempDate)

    End Sub

    Private Sub NewButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click

        If cmbAccType.SelectedItem = "Joint" Then
            If Trim(txtAccNo.Text) <> "JL" Then
                Dim objfrmSurety As New frmHomeLoanSurety
                objfrmSurety.BackColor = GroupBox1.BackColor
                objfrmSurety.TabPage1.BackColor = GroupBox1.BackColor
                objfrmSurety.btnOk.GotFocusColour = btnAdd.GotFocusColour
                objfrmSurety.txtLoanNo.Text = txtAccNo.Text
                objfrmSurety.txtLoanerName.Text = txtName.Text
                objfrmSurety.chrType = "J"
                objfrmSurety.ShowDialog(Me)
            Else
                MsgBox("Enter valid account no", MsgBoxStyle.Information, "Loan Module")
                txtAccNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSurety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSurety.Click
        If txtAccNo.Text <> "JL" Then
            Dim objfrmSurety As New frmHomeLoanSurety
            objfrmSurety.BackColor = GroupBox1.BackColor
            objfrmSurety.TabPage1.BackColor = GroupBox1.BackColor
            objfrmSurety.btnOk.GotFocusColour = btnAdd.GotFocusColour
            objfrmSurety.txtLoanNo.Text = txtAccNo.Text
            objfrmSurety.txtLoanerName.Text = txtName.Text
            objfrmSurety.chrType = "S"
            objfrmSurety.ShowDialog(Me)
            objfrmSurety.Dispose()
            fnLoadSuretyPerson()
        Else
            MsgBox("Enter valid loanno", MsgBoxStyle.Information, "Loan Module")
            txtAccNo.Focus()
        End If
    End Sub
    Private Sub txtAccNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtAccNo.Text = "JL" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccNo.KeyPress
        If txtAccNo.Text = "JL" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyDown
        If txtAccNo.Text = "JL" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.TextChanged

        If txtAccNo.Text.StartsWith("JL") = False Then
            txtAccNo.Undo()
            txtAccNo.ClearUndo()
        End If

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        If objclsRepyment.fnGetData(txtAccNo.Text) Then
            If objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") > 0 Then
                Dim objfrmRepay As New frmLoanAdditionalCharges
                objfrmRepay.txtLoanNo.Text = txtAccNo.Text
                objfrmRepay.txtName.Text = txtName.Text
                objfrmRepay.ShowDialog()
            Else
                MsgBox("Please disburse amount first", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Enter valid loan number", MsgBoxStyle.Information, "Loan Module")
            txtAccNo.Focus()
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

    Private Sub txtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
