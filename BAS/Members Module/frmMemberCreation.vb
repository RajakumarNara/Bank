Imports System.ComponentModel
Imports System.IO

Public Class frmMemberCreation
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objshare As New clsShares
    Dim objMember As New clsMember
    Dim objLedger As New clsLedger
    Dim lngPersonNo As Long = 0
    Dim lngVoucherNo As Long
    Dim dblShareAmount As Double = 0
    Dim dblShareFee As Double = 0
    Dim dblBuildingFund As Double = 0
    Friend WithEvents txtMenOtherEduSociety As BankControls.TextControl
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtAppOtherSuggestions As BankControls.TextControl
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents txtIntroAccNo2 As BankControls.TextControl
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtApplicationFee As BankControls.NumericControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmount As BankControls.NumericControl
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtBalanceAmount As BankControls.NumericControl
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Cmb_VoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents Cmd_BankList As System.Windows.Forms.ComboBox
    Friend WithEvents NarrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents CheckDetailsGroupBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents BalloonToolTip1 As CustomTooltip.BalloonToolTip
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnReceipt As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnIDCard As BankControls.NewButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMembersList As BankControls.NewButton
    Friend WithEvents btnLoanDetails As BankControls.NewButton
    Friend WithEvents btnDepositDetails As BankControls.NewButton
    Friend WithEvents btnSBdetails As BankControls.NewButton
    Friend WithEvents btnShareDetails As BankControls.NewButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents chkIDCard As System.Windows.Forms.CheckBox
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPermAddress As BankControls.TextControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPresAddress As BankControls.TextControl
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbMemberType As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As BankControls.TextControl
    Friend WithEvents txtMobileNo As BankControls.TextControl
    Friend WithEvents dtpOpenDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpApplDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tbShares As System.Windows.Forms.TabPage
    Friend WithEvents grpShares As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNoOfShares As BankControls.NumericControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtShareFee As BankControls.NumericControl
    Friend WithEvents txtShareAmount As BankControls.NumericControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtBuildingFund As BankControls.NumericControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As BankControls.NumericControl
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents btnLoadSign As BankControls.NewButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtEntryFee As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtTotalIncome As BankControls.NumericControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As BankControls.NumericControl
    Friend WithEvents txtOtherIncome As BankControls.NumericControl
    Friend WithEvents txtEducation As BankControls.TextControl
    Friend WithEvents txtOffAddress As BankControls.TextControl
    Friend WithEvents txtRemark1 As BankControls.TextControl
    Friend WithEvents chkIDCard1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtIntroAccNo As BankControls.TextControl
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents btnNewMember As BankControls.NewButton
    Friend WithEvents txtOfficeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberCreation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMemberNo = New BankControls.TextControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New BankControls.TextControl()
        Me.btnClose = New BankControls.NewButton()
        Me.btnOk = New BankControls.NewButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReceipt = New BankControls.NewButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnIDCard = New BankControls.NewButton()
        Me.btnNominees = New BankControls.NewButton()
        Me.btnFamilyDetails = New BankControls.NewButton()
        Me.btnMembersList = New BankControls.NewButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbPersonal = New System.Windows.Forms.TabPage()
        Me.NewButton3 = New BankControls.NewButton()
        Me.txtIntroAccNo2 = New BankControls.TextControl()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtAppOtherSuggestions = New BankControls.TextControl()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtMenOtherEduSociety = New BankControls.TextControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPermAddress = New BankControls.TextControl()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtOfficeNo = New BankControls.NumericControl()
        Me.btnNewMember = New BankControls.NewButton()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.NewButton2 = New BankControls.NewButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New BankControls.TextControl()
        Me.NewButton1 = New BankControls.NewButton()
        Me.txtIntroAccNo = New BankControls.TextControl()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtEducation = New BankControls.TextControl()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOffAddress = New BankControls.TextControl()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.chkSame = New System.Windows.Forms.CheckBox()
        Me.cmbCaste = New System.Windows.Forms.ComboBox()
        Me.cmbReligion = New System.Windows.Forms.ComboBox()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.txtAge = New BankControls.NumericControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFatherName = New BankControls.TextControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPresAddress = New BankControls.TextControl()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.cmbOccupation = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbMemberType = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New BankControls.TextControl()
        Me.txtMobileNo = New BankControls.TextControl()
        Me.dtpOpenDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpApplDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbShares = New System.Windows.Forms.TabPage()
        Me.grpShares = New System.Windows.Forms.GroupBox()
        Me.NarrationTextBox = New System.Windows.Forms.TextBox()
        Me.Cmd_BankList = New System.Windows.Forms.ComboBox()
        Me.Cmb_VoucherType = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtBalanceAmount = New BankControls.NumericControl()
        Me.txtPaidAmount = New BankControls.NumericControl()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtApplicationFee = New BankControls.NumericControl()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSalary = New BankControls.NumericControl()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtOtherIncome = New BankControls.NumericControl()
        Me.txtTotalIncome = New BankControls.NumericControl()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNoOfShares = New BankControls.NumericControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtShareFee = New BankControls.NumericControl()
        Me.txtShareAmount = New BankControls.NumericControl()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEntryFee = New BankControls.NumericControl()
        Me.txtBuildingFund = New BankControls.NumericControl()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtReceiptNo = New BankControls.NumericControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New BankControls.NumericControl()
        Me.tbOthers = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtRemark1 = New BankControls.TextControl()
        Me.chkIDCard1 = New System.Windows.Forms.CheckBox()
        Me.btnLoadPhoto = New BankControls.NewButton()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.btnCancelPhoto = New BankControls.NewButton()
        Me.btnCancelSign = New BankControls.NewButton()
        Me.btnLoadSign = New BankControls.NewButton()
        Me.btnSearch = New BankControls.NewButton()
        Me.btnAdd = New BankControls.NewButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BalloonToolTip1 = New CustomTooltip.BalloonToolTip()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRemarks = New BankControls.TextControl()
        Me.chkIDCard = New System.Windows.Forms.CheckBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CheckDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.tbShares.SuspendLayout()
        Me.grpShares.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label1, Nothing)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member No:"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.SystemColors.Window
        Me.BalloonToolTip1.SetBalloonText(Me.txtMemberNo, Nothing)
        Me.txtMemberNo.BlankSpace = False
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMemberNo.Location = New System.Drawing.Point(120, 15)
        Me.txtMemberNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(128, 23)
        Me.txtMemberNo.SpecialChar = True
        Me.txtMemberNo.TabIndex = 2
        Me.txtMemberNo.Text = "MB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label2, Nothing)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 3
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
        Me.txtName.Location = New System.Drawing.Point(400, 15)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 4
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
        Me.btnClose.Location = New System.Drawing.Point(659, 569)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'btnOk
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnOk, Nothing)
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(552, 569)
        Me.btnOk.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&Save"
        '
        'GroupBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox1, Nothing)
        Me.GroupBox1.Controls.Add(Me.btnReceipt)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnIDCard)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox1.Controls.Add(Me.btnMembersList)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnReceipt, Nothing)
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnReceipt.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceipt.Location = New System.Drawing.Point(16, 312)
        Me.btnReceipt.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(168, 40)
        Me.btnReceipt.TabIndex = 3
        Me.btnReceipt.Text = "&Receipt Details"
        Me.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReceipt.UseVisualStyleBackColor = False
        Me.btnReceipt.Visible = False
        '
        'PictureBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox1, Nothing)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnIDCard
        '
        Me.btnIDCard.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnIDCard, Nothing)
        Me.btnIDCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIDCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIDCard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDCard.ForeColor = System.Drawing.Color.Black
        Me.btnIDCard.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIDCard.Image = CType(resources.GetObject("btnIDCard.Image"), System.Drawing.Image)
        Me.btnIDCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIDCard.Location = New System.Drawing.Point(16, 400)
        Me.btnIDCard.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnIDCard.Name = "btnIDCard"
        Me.btnIDCard.Size = New System.Drawing.Size(168, 40)
        Me.btnIDCard.TabIndex = 4
        Me.btnIDCard.Text = "Issue &ID Card"
        Me.btnIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIDCard.UseVisualStyleBackColor = False
        Me.btnIDCard.Visible = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnNominees, Nothing)
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 272)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 2
        Me.btnNominees.Text = "&Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'btnFamilyDetails
        '
        Me.btnFamilyDetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnFamilyDetails, Nothing)
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(16, 232)
        Me.btnFamilyDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnFamilyDetails.Name = "btnFamilyDetails"
        Me.btnFamilyDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFamilyDetails.TabIndex = 1
        Me.btnFamilyDetails.Text = "&Family Details"
        Me.btnFamilyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFamilyDetails.UseVisualStyleBackColor = False
        '
        'btnMembersList
        '
        Me.btnMembersList.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnMembersList, Nothing)
        Me.btnMembersList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMembersList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMembersList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembersList.ForeColor = System.Drawing.Color.Black
        Me.btnMembersList.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMembersList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembersList.Location = New System.Drawing.Point(16, 192)
        Me.btnMembersList.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnMembersList.Name = "btnMembersList"
        Me.btnMembersList.Size = New System.Drawing.Size(168, 40)
        Me.btnMembersList.TabIndex = 0
        Me.btnMembersList.Text = "Members &List"
        Me.btnMembersList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMembersList.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.Label21, Nothing)
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(47, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 23)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Member Master"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox2, Nothing)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtMemberNo)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.TabControl1, Nothing)
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.tbShares)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(24, 44)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 519)
        Me.TabControl1.TabIndex = 5
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.tbPersonal, Nothing)
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPersonal.Controls.Add(Me.NewButton3)
        Me.tbPersonal.Controls.Add(Me.txtIntroAccNo2)
        Me.tbPersonal.Controls.Add(Me.Label39)
        Me.tbPersonal.Controls.Add(Me.txtAppOtherSuggestions)
        Me.tbPersonal.Controls.Add(Me.Label36)
        Me.tbPersonal.Controls.Add(Me.Label37)
        Me.tbPersonal.Controls.Add(Me.txtMenOtherEduSociety)
        Me.tbPersonal.Controls.Add(Me.Label14)
        Me.tbPersonal.Controls.Add(Me.txtPermAddress)
        Me.tbPersonal.Controls.Add(Me.Label34)
        Me.tbPersonal.Controls.Add(Me.Label35)
        Me.tbPersonal.Controls.Add(Me.txtOfficeNo)
        Me.tbPersonal.Controls.Add(Me.btnNewMember)
        Me.tbPersonal.Controls.Add(Me.Label33)
        Me.tbPersonal.Controls.Add(Me.NewButton2)
        Me.tbPersonal.Controls.Add(Me.Label32)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.NewButton1)
        Me.tbPersonal.Controls.Add(Me.txtIntroAccNo)
        Me.tbPersonal.Controls.Add(Me.Label31)
        Me.tbPersonal.Controls.Add(Me.txtEducation)
        Me.tbPersonal.Controls.Add(Me.Label38)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.txtOffAddress)
        Me.tbPersonal.Controls.Add(Me.Label29)
        Me.tbPersonal.Controls.Add(Me.cmbStatus)
        Me.tbPersonal.Controls.Add(Me.chkSame)
        Me.tbPersonal.Controls.Add(Me.cmbCaste)
        Me.tbPersonal.Controls.Add(Me.cmbReligion)
        Me.tbPersonal.Controls.Add(Me.rdbMale)
        Me.tbPersonal.Controls.Add(Me.txtAge)
        Me.tbPersonal.Controls.Add(Me.Label12)
        Me.tbPersonal.Controls.Add(Me.dtpDOB)
        Me.tbPersonal.Controls.Add(Me.Label4)
        Me.tbPersonal.Controls.Add(Me.txtFatherName)
        Me.tbPersonal.Controls.Add(Me.Label5)
        Me.tbPersonal.Controls.Add(Me.Label6)
        Me.tbPersonal.Controls.Add(Me.Label7)
        Me.tbPersonal.Controls.Add(Me.Label8)
        Me.tbPersonal.Controls.Add(Me.Label9)
        Me.tbPersonal.Controls.Add(Me.Label10)
        Me.tbPersonal.Controls.Add(Me.txtPresAddress)
        Me.tbPersonal.Controls.Add(Me.rdbFemale)
        Me.tbPersonal.Controls.Add(Me.cmbOccupation)
        Me.tbPersonal.Controls.Add(Me.Label16)
        Me.tbPersonal.Controls.Add(Me.cmbMemberType)
        Me.tbPersonal.Controls.Add(Me.Label25)
        Me.tbPersonal.Controls.Add(Me.Label26)
        Me.tbPersonal.Controls.Add(Me.txtPhoneNo)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo)
        Me.tbPersonal.Controls.Add(Me.dtpOpenDate)
        Me.tbPersonal.Controls.Add(Me.Label3)
        Me.tbPersonal.Controls.Add(Me.dtpApplDate)
        Me.tbPersonal.Controls.Add(Me.Label18)
        Me.tbPersonal.Controls.Add(Me.Label28)
        Me.tbPersonal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPersonal.ForeColor = System.Drawing.Color.Black
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(752, 490)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'NewButton3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton3, "Search for Member")
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(304, 364)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(24, 24)
        Me.NewButton3.TabIndex = 27
        '
        'txtIntroAccNo2
        '
        Me.txtIntroAccNo2.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtIntroAccNo2, Nothing)
        Me.txtIntroAccNo2.BlankSpace = True
        Me.txtIntroAccNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntroAccNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntroAccNo2.Location = New System.Drawing.Point(160, 365)
        Me.txtIntroAccNo2.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtIntroAccNo2.Mandatory = False
        Me.txtIntroAccNo2.MaxLength = 30
        Me.txtIntroAccNo2.Name = "txtIntroAccNo2"
        Me.txtIntroAccNo2.ReadOnly = True
        Me.txtIntroAccNo2.Size = New System.Drawing.Size(138, 23)
        Me.txtIntroAccNo2.SpecialChar = True
        Me.txtIntroAccNo2.TabIndex = 28
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.Label39, Nothing)
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(16, 368)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(138, 16)
        Me.Label39.TabIndex = 26
        Me.Label39.Text = "Introducer's No.2 : "
        '
        'txtAppOtherSuggestions
        '
        Me.txtAppOtherSuggestions.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtAppOtherSuggestions, Nothing)
        Me.txtAppOtherSuggestions.BlankSpace = True
        Me.txtAppOtherSuggestions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppOtherSuggestions.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAppOtherSuggestions.Location = New System.Drawing.Point(544, 396)
        Me.txtAppOtherSuggestions.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAppOtherSuggestions.Mandatory = False
        Me.txtAppOtherSuggestions.MaxLength = 255
        Me.txtAppOtherSuggestions.Multiline = True
        Me.txtAppOtherSuggestions.Name = "txtAppOtherSuggestions"
        Me.txtAppOtherSuggestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAppOtherSuggestions.Size = New System.Drawing.Size(184, 56)
        Me.txtAppOtherSuggestions.SpecialChar = True
        Me.txtAppOtherSuggestions.TabIndex = 51
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label36, Nothing)
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(384, 417)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(99, 16)
        Me.Label36.TabIndex = 50
        Me.Label36.Text = "Suggestions :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label37, Nothing)
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(384, 399)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(111, 16)
        Me.Label37.TabIndex = 49
        Me.Label37.Text = "Applicant Other"
        '
        'txtMenOtherEduSociety
        '
        Me.txtMenOtherEduSociety.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtMenOtherEduSociety, Nothing)
        Me.txtMenOtherEduSociety.BlankSpace = True
        Me.txtMenOtherEduSociety.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenOtherEduSociety.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMenOtherEduSociety.Location = New System.Drawing.Point(160, 401)
        Me.txtMenOtherEduSociety.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtMenOtherEduSociety.Mandatory = False
        Me.txtMenOtherEduSociety.MaxLength = 255
        Me.txtMenOtherEduSociety.Multiline = True
        Me.txtMenOtherEduSociety.Name = "txtMenOtherEduSociety"
        Me.txtMenOtherEduSociety.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMenOtherEduSociety.Size = New System.Drawing.Size(186, 56)
        Me.txtMenOtherEduSociety.SpecialChar = True
        Me.txtMenOtherEduSociety.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label14, Nothing)
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(384, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Permanent Address : "
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtPermAddress, Nothing)
        Me.txtPermAddress.BlankSpace = True
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(544, 93)
        Me.txtPermAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 100
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 36
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label34, Nothing)
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(15, 419)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(139, 16)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "Education Society :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label35, Nothing)
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(16, 401)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(119, 16)
        Me.Label35.TabIndex = 29
        Me.Label35.Text = "Member of Other"
        '
        'txtOfficeNo
        '
        Me.txtOfficeNo.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtOfficeNo, Nothing)
        Me.txtOfficeNo.BeforeDecimal = 20
        Me.txtOfficeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeNo.Location = New System.Drawing.Point(544, 365)
        Me.txtOfficeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeNo.MaxLength = 20
        Me.txtOfficeNo.MaxValue = 0.0R
        Me.txtOfficeNo.MinValue = 0.0R
        Me.txtOfficeNo.Name = "txtOfficeNo"
        Me.txtOfficeNo.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeNo.TabIndex = 48
        '
        'btnNewMember
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnNewMember, Nothing)
        Me.btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMember.ForeColor = System.Drawing.Color.Black
        Me.btnNewMember.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNewMember.Image = CType(resources.GetObject("btnNewMember.Image"), System.Drawing.Image)
        Me.btnNewMember.Location = New System.Drawing.Point(336, 12)
        Me.btnNewMember.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(32, 24)
        Me.btnNewMember.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label33, Nothing)
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(384, 365)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(85, 16)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Office No. :"
        '
        'NewButton2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton2, "Search for Member")
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(304, 333)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(24, 24)
        Me.NewButton2.TabIndex = 24
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label32, Nothing)
        Me.Label32.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(16, 12)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(119, 16)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Customer Code :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.BalloonToolTip1.SetBalloonText(Me.txtCustomerID, Nothing)
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(160, 12)
        Me.txtCustomerID.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(128, 23)
        Me.txtCustomerID.SpecialChar = True
        Me.txtCustomerID.TabIndex = 3
        Me.txtCustomerID.Text = "CID"
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton1, "Search for Member")
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(296, 12)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(24, 24)
        Me.NewButton1.TabIndex = 1
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'txtIntroAccNo
        '
        Me.txtIntroAccNo.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtIntroAccNo, Nothing)
        Me.txtIntroAccNo.BlankSpace = True
        Me.txtIntroAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntroAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntroAccNo.Location = New System.Drawing.Point(160, 334)
        Me.txtIntroAccNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtIntroAccNo.Mandatory = False
        Me.txtIntroAccNo.MaxLength = 30
        Me.txtIntroAccNo.Name = "txtIntroAccNo"
        Me.txtIntroAccNo.ReadOnly = True
        Me.txtIntroAccNo.Size = New System.Drawing.Size(138, 23)
        Me.txtIntroAccNo.SpecialChar = True
        Me.txtIntroAccNo.TabIndex = 25
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.Label31, Nothing)
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(16, 337)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(138, 16)
        Me.Label31.TabIndex = 23
        Me.Label31.Text = "Introducer's No.1 : "
        '
        'txtEducation
        '
        Me.txtEducation.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtEducation, Nothing)
        Me.txtEducation.BlankSpace = False
        Me.txtEducation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEducation.Location = New System.Drawing.Point(544, 229)
        Me.txtEducation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEducation.Mandatory = False
        Me.txtEducation.MaxLength = 20
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(184, 23)
        Me.txtEducation.SpecialChar = True
        Me.txtEducation.TabIndex = 42
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label38, Nothing)
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(384, 229)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(89, 16)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "Education : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label13, Nothing)
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(384, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Office Address :"
        '
        'txtOffAddress
        '
        Me.txtOffAddress.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtOffAddress, Nothing)
        Me.txtOffAddress.BlankSpace = True
        Me.txtOffAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOffAddress.Location = New System.Drawing.Point(544, 293)
        Me.txtOffAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOffAddress.Mandatory = False
        Me.txtOffAddress.MaxLength = 100
        Me.txtOffAddress.Multiline = True
        Me.txtOffAddress.Name = "txtOffAddress"
        Me.txtOffAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtOffAddress.SpecialChar = True
        Me.txtOffAddress.TabIndex = 46
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label29, Nothing)
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 310)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 16)
        Me.Label29.TabIndex = 21
        Me.Label29.Text = "Status : "
        '
        'cmbStatus
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbStatus, Nothing)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "InActive", "Closed"})
        Me.cmbStatus.Location = New System.Drawing.Point(160, 302)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(168, 24)
        Me.cmbStatus.TabIndex = 22
        '
        'chkSame
        '
        Me.BalloonToolTip1.SetBalloonText(Me.chkSame, Nothing)
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(544, 68)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(184, 24)
        Me.chkSame.TabIndex = 34
        Me.chkSame.Text = "same as present address"
        '
        'cmbCaste
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbCaste, Nothing)
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(160, 238)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 18
        '
        'cmbReligion
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbReligion, Nothing)
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(160, 206)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 16
        '
        'rdbMale
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbMale, Nothing)
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(544, 459)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 53
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtAge, Nothing)
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(160, 172)
        Me.txtAge.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100.0R
        Me.txtAge.MinValue = 0.0R
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(56, 23)
        Me.txtAge.TabIndex = 14
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label12, Nothing)
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(384, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Present Address :"
        '
        'dtpDOB
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpDOB, Nothing)
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(160, 140)
        Me.dtpDOB.MaxDate = New Date(9998, 12, 19, 0, 0, 0, 0)
        Me.dtpDOB.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtpDOB.TabIndex = 12
        Me.dtpDOB.Value = New Date(2007, 10, 23, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label4, Nothing)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Father Name/"
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtFatherName, Nothing)
        Me.txtFatherName.BlankSpace = True
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(160, 108)
        Me.txtFatherName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label5, Nothing)
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date of Birth : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label6, Nothing)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label7, Nothing)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 462)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label8, Nothing)
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label9, Nothing)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label10, Nothing)
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Occupation :"
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtPresAddress, Nothing)
        Me.txtPresAddress.BlankSpace = True
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(544, 3)
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
        'rdbFemale
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbFemale, Nothing)
        Me.rdbFemale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(616, 459)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 54
        Me.rdbFemale.Text = "Female"
        '
        'cmbOccupation
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbOccupation, Nothing)
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(544, 261)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label16, Nothing)
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 278)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 16)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Member Type : "
        '
        'cmbMemberType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbMemberType, Nothing)
        Me.cmbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMemberType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMemberType.Items.AddRange(New Object() {"", "Share Capital A", "Share Capital B", "Souharda Risk Fund"})
        Me.cmbMemberType.Location = New System.Drawing.Point(160, 270)
        Me.cmbMemberType.Name = "cmbMemberType"
        Me.cmbMemberType.Size = New System.Drawing.Size(168, 24)
        Me.cmbMemberType.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label25, Nothing)
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(384, 197)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 16)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label26, Nothing)
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(384, 165)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 16)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Mobile No. :"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtPhoneNo, Nothing)
        Me.txtPhoneNo.BlankSpace = False
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(544, 197)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPhoneNo.Mandatory = False
        Me.txtPhoneNo.MaxLength = 20
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.SpecialChar = True
        Me.txtPhoneNo.TabIndex = 40
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtMobileNo, Nothing)
        Me.txtMobileNo.BlankSpace = False
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(544, 165)
        Me.txtMobileNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtMobileNo.Mandatory = False
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.SpecialChar = True
        Me.txtMobileNo.TabIndex = 38
        '
        'dtpOpenDate
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpOpenDate, Nothing)
        Me.dtpOpenDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpOpenDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOpenDate.Location = New System.Drawing.Point(160, 76)
        Me.dtpOpenDate.MaxDate = New Date(9998, 10, 30, 0, 0, 0, 0)
        Me.dtpOpenDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpOpenDate.Name = "dtpOpenDate"
        Me.dtpOpenDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpOpenDate.TabIndex = 7
        Me.dtpOpenDate.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label3, Nothing)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Membership Date :"
        '
        'dtpApplDate
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpApplDate, Nothing)
        Me.dtpApplDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpApplDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpApplDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApplDate.Location = New System.Drawing.Point(160, 44)
        Me.dtpApplDate.MaxDate = New Date(9998, 10, 30, 0, 0, 0, 0)
        Me.dtpApplDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpApplDate.Name = "dtpApplDate"
        Me.dtpApplDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpApplDate.TabIndex = 5
        Me.dtpApplDate.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label18, Nothing)
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Applied Date :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label28, Nothing)
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 124)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 16)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "Husband Name :  "
        '
        'tbShares
        '
        Me.tbShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.tbShares, Nothing)
        Me.tbShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbShares.Controls.Add(Me.grpShares)
        Me.tbShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShares.Location = New System.Drawing.Point(4, 25)
        Me.tbShares.Name = "tbShares"
        Me.tbShares.Size = New System.Drawing.Size(752, 490)
        Me.tbShares.TabIndex = 3
        Me.tbShares.Text = "Shares"
        Me.tbShares.Visible = False
        '
        'grpShares
        '
        Me.BalloonToolTip1.SetBalloonText(Me.grpShares, Nothing)
        Me.grpShares.Controls.Add(Me.CheckDetailsGroupBox)
        Me.grpShares.Controls.Add(Me.NarrationTextBox)
        Me.grpShares.Controls.Add(Me.Cmd_BankList)
        Me.grpShares.Controls.Add(Me.Cmb_VoucherType)
        Me.grpShares.Controls.Add(Me.Label46)
        Me.grpShares.Controls.Add(Me.Label45)
        Me.grpShares.Controls.Add(Me.Label43)
        Me.grpShares.Controls.Add(Me.Label42)
        Me.grpShares.Controls.Add(Me.txtBalanceAmount)
        Me.grpShares.Controls.Add(Me.txtPaidAmount)
        Me.grpShares.Controls.Add(Me.Label41)
        Me.grpShares.Controls.Add(Me.txtApplicationFee)
        Me.grpShares.Controls.Add(Me.Label40)
        Me.grpShares.Controls.Add(Me.Label15)
        Me.grpShares.Controls.Add(Me.Panel5)
        Me.grpShares.Controls.Add(Me.Panel4)
        Me.grpShares.Controls.Add(Me.txtSalary)
        Me.grpShares.Controls.Add(Me.Label44)
        Me.grpShares.Controls.Add(Me.txtOtherIncome)
        Me.grpShares.Controls.Add(Me.txtTotalIncome)
        Me.grpShares.Controls.Add(Me.Label49)
        Me.grpShares.Controls.Add(Me.Label51)
        Me.grpShares.Controls.Add(Me.Panel1)
        Me.grpShares.Controls.Add(Me.txtNoOfShares)
        Me.grpShares.Controls.Add(Me.Label11)
        Me.grpShares.Controls.Add(Me.Label22)
        Me.grpShares.Controls.Add(Me.Label23)
        Me.grpShares.Controls.Add(Me.txtShareFee)
        Me.grpShares.Controls.Add(Me.txtShareAmount)
        Me.grpShares.Controls.Add(Me.Label24)
        Me.grpShares.Controls.Add(Me.txtEntryFee)
        Me.grpShares.Controls.Add(Me.txtBuildingFund)
        Me.grpShares.Controls.Add(Me.Label27)
        Me.grpShares.Controls.Add(Me.Label17)
        Me.grpShares.Controls.Add(Me.txtReceiptNo)
        Me.grpShares.Controls.Add(Me.Panel2)
        Me.grpShares.Controls.Add(Me.Label20)
        Me.grpShares.Controls.Add(Me.txtTotalAmount)
        Me.grpShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShares.Location = New System.Drawing.Point(8, 0)
        Me.grpShares.Name = "grpShares"
        Me.grpShares.Size = New System.Drawing.Size(720, 437)
        Me.grpShares.TabIndex = 0
        Me.grpShares.TabStop = False
        '
        'NarrationTextBox
        '
        Me.BalloonToolTip1.SetBalloonText(Me.NarrationTextBox, Nothing)
        Me.NarrationTextBox.Location = New System.Drawing.Point(184, 408)
        Me.NarrationTextBox.Name = "NarrationTextBox"
        Me.NarrationTextBox.Size = New System.Drawing.Size(449, 23)
        Me.NarrationTextBox.TabIndex = 159
        '
        'Cmd_BankList
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Cmd_BankList, Nothing)
        Me.Cmd_BankList.FormattingEnabled = True
        Me.Cmd_BankList.Location = New System.Drawing.Point(184, 286)
        Me.Cmd_BankList.Name = "Cmd_BankList"
        Me.Cmd_BankList.Size = New System.Drawing.Size(128, 24)
        Me.Cmd_BankList.TabIndex = 158
        '
        'Cmb_VoucherType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Cmb_VoucherType, Nothing)
        Me.Cmb_VoucherType.FormattingEnabled = True
        Me.Cmb_VoucherType.Items.AddRange(New Object() {"Cash", "Bank"})
        Me.Cmb_VoucherType.Location = New System.Drawing.Point(184, 258)
        Me.Cmb_VoucherType.Name = "Cmb_VoucherType"
        Me.Cmb_VoucherType.Size = New System.Drawing.Size(128, 24)
        Me.Cmb_VoucherType.TabIndex = 157
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label46, Nothing)
        Me.Label46.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(101, 408)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(79, 16)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "Narration :"
        Me.Label46.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label45, Nothing)
        Me.Label45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(89, 289)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(91, 16)
        Me.Label45.TabIndex = 17
        Me.Label45.Text = "Bank Name :"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label43, Nothing)
        Me.Label43.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(87, 262)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(93, 16)
        Me.Label43.TabIndex = 15
        Me.Label43.Text = "Cash/ Bank :"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label42, Nothing)
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(345, 367)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(104, 16)
        Me.Label42.TabIndex = 35
        Me.Label42.Text = "Due Amount : "
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.AfterDecimal = 2
        Me.txtBalanceAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtBalanceAmount, Nothing)
        Me.txtBalanceAmount.BeforeDecimal = 8
        Me.txtBalanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtBalanceAmount.Location = New System.Drawing.Point(480, 365)
        Me.txtBalanceAmount.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtBalanceAmount.MaxLength = 10
        Me.txtBalanceAmount.MaxValue = 0.0R
        Me.txtBalanceAmount.MinValue = 0.0R
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.ReadOnly = True
        Me.txtBalanceAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtBalanceAmount.TabIndex = 36
        Me.txtBalanceAmount.TabStop = False
        Me.txtBalanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtPaidAmount, Nothing)
        Me.txtPaidAmount.BeforeDecimal = 10
        Me.txtPaidAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPaidAmount.Location = New System.Drawing.Point(184, 202)
        Me.txtPaidAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPaidAmount.MaxLength = 15
        Me.txtPaidAmount.MaxValue = 0.0R
        Me.txtPaidAmount.MinValue = 0.0R
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtPaidAmount.TabIndex = 12
        Me.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label41, Nothing)
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(79, 205)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(101, 16)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "Paid Amount :"
        '
        'txtApplicationFee
        '
        Me.txtApplicationFee.AfterDecimal = 2
        Me.txtApplicationFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtApplicationFee, Nothing)
        Me.txtApplicationFee.BeforeDecimal = 8
        Me.txtApplicationFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApplicationFee.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtApplicationFee.Location = New System.Drawing.Point(480, 293)
        Me.txtApplicationFee.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtApplicationFee.MaxLength = 10
        Me.txtApplicationFee.MaxValue = 0.0R
        Me.txtApplicationFee.MinValue = 0.0R
        Me.txtApplicationFee.Name = "txtApplicationFee"
        Me.txtApplicationFee.ReadOnly = True
        Me.txtApplicationFee.Size = New System.Drawing.Size(128, 23)
        Me.txtApplicationFee.TabIndex = 30
        Me.txtApplicationFee.TabStop = False
        Me.txtApplicationFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label40, Nothing)
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(345, 296)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(125, 16)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "Application Fee : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label15, Nothing)
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(336, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Total : "
        '
        'Panel5
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Panel5, Nothing)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(129, 113)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(504, 2)
        Me.Panel5.TabIndex = 8
        '
        'Panel4
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Panel4, Nothing)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(129, 76)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(504, 2)
        Me.Panel4.TabIndex = 5
        '
        'txtSalary
        '
        Me.txtSalary.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtSalary, Nothing)
        Me.txtSalary.BeforeDecimal = 8
        Me.txtSalary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSalary.Location = New System.Drawing.Point(480, 15)
        Me.txtSalary.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSalary.MaxLength = 10
        Me.txtSalary.MaxValue = 99999999.0R
        Me.txtSalary.MinValue = 0.0R
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(128, 23)
        Me.txtSalary.TabIndex = 2
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label44
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Label44, Nothing)
        Me.Label44.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(336, 15)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "Salary :"
        '
        'txtOtherIncome
        '
        Me.txtOtherIncome.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtOtherIncome, Nothing)
        Me.txtOtherIncome.BeforeDecimal = 8
        Me.txtOtherIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherIncome.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherIncome.Location = New System.Drawing.Point(480, 47)
        Me.txtOtherIncome.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherIncome.MaxLength = 10
        Me.txtOtherIncome.MaxValue = 999999999.0R
        Me.txtOtherIncome.MinValue = 0.0R
        Me.txtOtherIncome.Name = "txtOtherIncome"
        Me.txtOtherIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtOtherIncome.TabIndex = 4
        Me.txtOtherIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalIncome
        '
        Me.txtTotalIncome.AfterDecimal = 0
        Me.txtTotalIncome.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtTotalIncome, Nothing)
        Me.txtTotalIncome.BeforeDecimal = 8
        Me.txtTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalIncome.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtTotalIncome.Location = New System.Drawing.Point(480, 84)
        Me.txtTotalIncome.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtTotalIncome.MaxLength = 10
        Me.txtTotalIncome.MaxValue = 999999999.0R
        Me.txtTotalIncome.MinValue = 0.0R
        Me.txtTotalIncome.Name = "txtTotalIncome"
        Me.txtTotalIncome.ReadOnly = True
        Me.txtTotalIncome.Size = New System.Drawing.Size(128, 23)
        Me.txtTotalIncome.TabIndex = 7
        Me.txtTotalIncome.TabStop = False
        Me.txtTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label49
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Label49, Nothing)
        Me.Label49.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(80, 32)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(194, 16)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Applicant's Monthly Income"
        '
        'Label51
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Label51, Nothing)
        Me.Label51.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(336, 55)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 16)
        Me.Label51.TabIndex = 3
        Me.Label51.Text = "Other Income : "
        '
        'Panel1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Panel1, Nothing)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(333, 322)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 2)
        Me.Panel1.TabIndex = 31
        '
        'Panel3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Panel3, Nothing)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-1, -96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(504, 39)
        Me.Panel3.TabIndex = 0
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtNoOfShares, Nothing)
        Me.txtNoOfShares.BeforeDecimal = 5
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoOfShares.Location = New System.Drawing.Point(184, 174)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtNoOfShares.MaxLength = 15
        Me.txtNoOfShares.MaxValue = 0.0R
        Me.txtNoOfShares.MinValue = 0.0R
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.Size = New System.Drawing.Size(128, 23)
        Me.txtNoOfShares.TabIndex = 10
        Me.txtNoOfShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label11, Nothing)
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(76, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "No of Shares :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label22, Nothing)
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(345, 207)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 16)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Share Fee :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label23, Nothing)
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(345, 238)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(117, 16)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Share Amount : "
        '
        'txtShareFee
        '
        Me.txtShareFee.AfterDecimal = 2
        Me.txtShareFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtShareFee, Nothing)
        Me.txtShareFee.BeforeDecimal = 8
        Me.txtShareFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareFee.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareFee.Location = New System.Drawing.Point(480, 204)
        Me.txtShareFee.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareFee.MaxLength = 10
        Me.txtShareFee.MaxValue = 0.0R
        Me.txtShareFee.MinValue = 0.0R
        Me.txtShareFee.Name = "txtShareFee"
        Me.txtShareFee.ReadOnly = True
        Me.txtShareFee.Size = New System.Drawing.Size(128, 23)
        Me.txtShareFee.TabIndex = 24
        Me.txtShareFee.TabStop = False
        Me.txtShareFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShareAmount
        '
        Me.txtShareAmount.AfterDecimal = 2
        Me.txtShareAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtShareAmount, Nothing)
        Me.txtShareAmount.BeforeDecimal = 8
        Me.txtShareAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Location = New System.Drawing.Point(480, 235)
        Me.txtShareAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtShareAmount.MaxLength = 10
        Me.txtShareAmount.MaxValue = 0.0R
        Me.txtShareAmount.MinValue = 0.0R
        Me.txtShareAmount.Name = "txtShareAmount"
        Me.txtShareAmount.ReadOnly = True
        Me.txtShareAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtShareAmount.TabIndex = 26
        Me.txtShareAmount.TabStop = False
        Me.txtShareAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label24, Nothing)
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(345, 177)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 16)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Share Entry  Fee :"
        '
        'txtEntryFee
        '
        Me.txtEntryFee.AfterDecimal = 2
        Me.txtEntryFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtEntryFee, Nothing)
        Me.txtEntryFee.BeforeDecimal = 8
        Me.txtEntryFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryFee.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtEntryFee.Location = New System.Drawing.Point(480, 174)
        Me.txtEntryFee.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtEntryFee.MaxLength = 10
        Me.txtEntryFee.MaxValue = 0.0R
        Me.txtEntryFee.MinValue = 0.0R
        Me.txtEntryFee.Name = "txtEntryFee"
        Me.txtEntryFee.ReadOnly = True
        Me.txtEntryFee.Size = New System.Drawing.Size(128, 23)
        Me.txtEntryFee.TabIndex = 22
        Me.txtEntryFee.TabStop = False
        Me.txtEntryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBuildingFund
        '
        Me.txtBuildingFund.AfterDecimal = 2
        Me.txtBuildingFund.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtBuildingFund, Nothing)
        Me.txtBuildingFund.BeforeDecimal = 8
        Me.txtBuildingFund.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuildingFund.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtBuildingFund.Location = New System.Drawing.Point(480, 265)
        Me.txtBuildingFund.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtBuildingFund.MaxLength = 10
        Me.txtBuildingFund.MaxValue = 0.0R
        Me.txtBuildingFund.MinValue = 0.0R
        Me.txtBuildingFund.Name = "txtBuildingFund"
        Me.txtBuildingFund.ReadOnly = True
        Me.txtBuildingFund.Size = New System.Drawing.Size(128, 23)
        Me.txtBuildingFund.TabIndex = 28
        Me.txtBuildingFund.TabStop = False
        Me.txtBuildingFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label27, Nothing)
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(345, 268)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(110, 16)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Building Fund : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label17, Nothing)
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(85, 234)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Receipt No. :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 2
        Me.txtReceiptNo.BackColor = System.Drawing.Color.White
        Me.BalloonToolTip1.SetBalloonText(Me.txtReceiptNo, Nothing)
        Me.txtReceiptNo.BeforeDecimal = 8
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(184, 231)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0.0R
        Me.txtReceiptNo.MinValue = 0.0R
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(128, 23)
        Me.txtReceiptNo.TabIndex = 14
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Panel2, Nothing)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(333, 357)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 2)
        Me.Panel2.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label20, Nothing)
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(360, 330)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 16)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Total : "
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AfterDecimal = 2
        Me.txtTotalAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.txtTotalAmount, Nothing)
        Me.txtTotalAmount.BeforeDecimal = 8
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtTotalAmount.Location = New System.Drawing.Point(480, 328)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtTotalAmount.MaxLength = 10
        Me.txtTotalAmount.MaxValue = 0.0R
        Me.txtTotalAmount.MinValue = 0.0R
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtTotalAmount.TabIndex = 33
        Me.txtTotalAmount.TabStop = False
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.tbOthers, Nothing)
        Me.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOthers.Controls.Add(Me.GroupBox4)
        Me.tbOthers.Controls.Add(Me.btnLoadPhoto)
        Me.tbOthers.Controls.Add(Me.picSignature)
        Me.tbOthers.Controls.Add(Me.lblSignature)
        Me.tbOthers.Controls.Add(Me.picPhoto)
        Me.tbOthers.Controls.Add(Me.lblPhoto)
        Me.tbOthers.Controls.Add(Me.btnCancelPhoto)
        Me.tbOthers.Controls.Add(Me.btnCancelSign)
        Me.tbOthers.Controls.Add(Me.btnLoadSign)
        Me.tbOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOthers.Location = New System.Drawing.Point(4, 25)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Size = New System.Drawing.Size(752, 490)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.Visible = False
        '
        'GroupBox4
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox4, Nothing)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.txtRemark1)
        Me.GroupBox4.Controls.Add(Me.chkIDCard1)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 144)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label30, Nothing)
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(40, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 16)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Remarks : "
        '
        'txtRemark1
        '
        Me.txtRemark1.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtRemark1, Nothing)
        Me.txtRemark1.BlankSpace = True
        Me.txtRemark1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemark1.Location = New System.Drawing.Point(128, 48)
        Me.txtRemark1.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemark1.Mandatory = False
        Me.txtRemark1.MaxLength = 100
        Me.txtRemark1.Multiline = True
        Me.txtRemark1.Name = "txtRemark1"
        Me.txtRemark1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark1.Size = New System.Drawing.Size(480, 80)
        Me.txtRemark1.SpecialChar = True
        Me.txtRemark1.TabIndex = 2
        '
        'chkIDCard1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.chkIDCard1, Nothing)
        Me.chkIDCard1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIDCard1.Location = New System.Drawing.Point(136, 16)
        Me.chkIDCard1.Name = "chkIDCard1"
        Me.chkIDCard1.Size = New System.Drawing.Size(136, 24)
        Me.chkIDCard1.TabIndex = 0
        Me.chkIDCard1.Text = "ID Card Issued?"
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnLoadPhoto, Nothing)
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 224)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.AntiqueWhite
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
        Me.BalloonToolTip1.SetBalloonText(Me.lblSignature, Nothing)
        Me.lblSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(360, 40)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(87, 16)
        Me.lblSignature.TabIndex = 3
        Me.lblSignature.Text = "Signature : "
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.BalloonToolTip1.SetBalloonText(Me.picPhoto, Nothing)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.BalloonToolTip1.SetBalloonText(Me.lblPhoto, Nothing)
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(64, 40)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(62, 16)
        Me.lblPhoto.TabIndex = 0
        Me.lblPhoto.Text = "Photo : "
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnCancelPhoto, Nothing)
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 224)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 2
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnCancelSign, Nothing)
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelSign.Location = New System.Drawing.Point(536, 224)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 5
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnLoadSign, Nothing)
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(456, 224)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 4
        Me.btnLoadSign.Text = "Load"
        Me.btnLoadSign.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnSearch, "Search for Member")
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(256, 14)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        '
        'btnAdd
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnAdd, Nothing)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(32, 569)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Reset"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "BMP files|*.bmp|JPEG files|*.jpg|GIF files|*.gif"
        Me.OpenFileDialog1.Title = "Select Image"
        '
        'BalloonToolTip1
        '
        Me.BalloonToolTip1.BackColor = System.Drawing.SystemColors.Info
        Me.BalloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BalloonToolTip1.Title = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label19, Nothing)
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(64, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 17)
        Me.Label19.TabIndex = 38
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtRemarks, Nothing)
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(128, 48)
        Me.txtRemarks.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(480, 80)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 1
        '
        'chkIDCard
        '
        Me.BalloonToolTip1.SetBalloonText(Me.chkIDCard, Nothing)
        Me.chkIDCard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIDCard.Location = New System.Drawing.Point(128, 16)
        Me.chkIDCard.Name = "chkIDCard"
        Me.chkIDCard.Size = New System.Drawing.Size(136, 24)
        Me.chkIDCard.TabIndex = 0
        Me.chkIDCard.Text = "ID Card Issued?"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label47, Nothing)
        Me.Label47.Location = New System.Drawing.Point(84, 14)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(86, 16)
        Me.Label47.TabIndex = 160
        Me.Label47.Text = "Bank Name:"
        '
        'TextBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.TextBox1, Nothing)
        Me.TextBox1.Location = New System.Drawing.Point(174, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 23)
        Me.TextBox1.TabIndex = 161
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label48, Nothing)
        Me.Label48.Location = New System.Drawing.Point(70, 40)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 16)
        Me.Label48.TabIndex = 162
        Me.Label48.Text = "Branch Name:"
        '
        'TextBox2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.TextBox2, Nothing)
        Me.TextBox2.Location = New System.Drawing.Point(174, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 23)
        Me.TextBox2.TabIndex = 163
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label50, Nothing)
        Me.Label50.Location = New System.Drawing.Point(96, 72)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 16)
        Me.Label50.TabIndex = 164
        Me.Label50.Text = "Check No:"
        '
        'TextBox3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.TextBox3, Nothing)
        Me.TextBox3.Location = New System.Drawing.Point(174, 65)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 23)
        Me.TextBox3.TabIndex = 165
        '
        'CheckDetailsGroupBox
        '
        Me.BalloonToolTip1.SetBalloonText(Me.CheckDetailsGroupBox, Nothing)
        Me.CheckDetailsGroupBox.Controls.Add(Me.Label47)
        Me.CheckDetailsGroupBox.Controls.Add(Me.TextBox3)
        Me.CheckDetailsGroupBox.Controls.Add(Me.Label50)
        Me.CheckDetailsGroupBox.Controls.Add(Me.TextBox1)
        Me.CheckDetailsGroupBox.Controls.Add(Me.Label48)
        Me.CheckDetailsGroupBox.Controls.Add(Me.TextBox2)
        Me.CheckDetailsGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CheckDetailsGroupBox.Location = New System.Drawing.Point(6, 308)
        Me.CheckDetailsGroupBox.Name = "CheckDetailsGroupBox"
        Me.CheckDetailsGroupBox.Size = New System.Drawing.Size(321, 94)
        Me.CheckDetailsGroupBox.TabIndex = 166
        Me.CheckDetailsGroupBox.TabStop = False
        Me.CheckDetailsGroupBox.Text = "Check Details"
        '
        'frmMemberCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 623)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmMemberCreation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.tbShares.ResumeLayout(False)
        Me.grpShares.ResumeLayout(False)
        Me.grpShares.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckDetailsGroupBox.ResumeLayout(False)
        Me.CheckDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmMemberCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmMemberCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmMemberCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmMemberCreation)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines to Load Control Values from Database"

    Sub sbLoadControlValues()
        'to load database values to form controls        
        Label46.Visible = False
        sbLoadOccupation()
        sbLoadReligion()
        sbLoadCaste()
    End Sub

    ''To load sharesconfigTbl value to the ShareAmount textbox
    Sub sbLoadMaster()
        If objMember.fnGetShareConfig Then
            Dim objdt As DataTable = objMember.SharesTable
            dblShareAmount = objdt.Rows(0).Item("AmountPerShare")
            dblShareFee = objdt.Rows(0).Item("ShareFee")
            dblBuildingFund = objdt.Rows(0).Item("BuildingFund")
            txtEntryFee.Text = Format(objdt.Rows(0).Item("ShareEntryFee"), "0.00")
            txtApplicationFee.Text = Format(objdt.Rows(0).Item("ApplicationFee"), "0.00")

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

#Region "Sub Routines and Functions"

    'To load member details
    Sub sbLoadMember()
        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objMember.fnGetMemberDetails(txtMemberNo.Text) Then
                sbClear()

                objDT = objMember.MemberTable

                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                txtMemberNo.Text = objDT.Rows(0).Item("MemberNo")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtName.Text = objDT.Rows(0).Item("Name")

                dtpApplDate.Value = CDate(objDT.Rows(0).Item("ApplDate"))
                dtpApplDate.Enabled = False
                dtpOpenDate.Value = CDate(objDT.Rows(0).Item("OpenDate"))
                dtpOpenDate.Enabled = False

                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")
                cmbStatus.SelectedItem = objDT.Rows(0).Item("status")

                If objDT.Rows(0).Item("Gender") = "M" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If

                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")

                If objDT.Rows(0).Item("Type") = "SCA" Then
                    cmbMemberType.SelectedItem = "Share Capital A"
                    objMember.Type = "SCA"

                ElseIf objDT.Rows(0).Item("Type") = "SCB" Then
                    cmbMemberType.SelectedItem = "Share Capital B"
                    objMember.Type = "SCB"
                Else
                    cmbMemberType.SelectedItem = "Souharda Risk Fund"
                    objMember.Type = "SRF"
                End If

                cmbMemberType.Enabled = False
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")
                txtEducation.Text = objDT.Rows(0).Item("Education")
                txtOffAddress.Text = objDT.Rows(0).Item("OfficeAddress")
                txtOfficeNo.Text = objDT.Rows(0).Item("OfficeNo")

                grpShares.Enabled = False
                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")
                txtNoOfShares.Text = objDT.Rows(0).Item("NoOfShares")
                txtShareAmount.Text = objDT.Rows(0).Item("ShareAmount")
                txtShareFee.Text = objDT.Rows(0).Item("ShareFee")
                txtEntryFee.Text = objDT.Rows(0).Item("EntryFee")
                txtBuildingFund.Text = objDT.Rows(0).Item("BuildingFee")
                sbCalcTotal()

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

                chkIDCard.Checked = IIf(objDT.Rows(0).Item("IDCard") = "Y", True, False)
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtSalary.Text = objDT.Rows(0).Item("Salary")
                txtOtherIncome.Text = objDT.Rows(0).Item("OtherIncome")
                txtIntroAccNo.Text = objDT.Rows(0).Item("IntroNo1")

                txtIntroAccNo2.Text = objDT.Rows(0).Item("IntroNo2")
                txtMenOtherEduSociety.Text = objDT.Rows(0).Item("MemToOtherEduSociety")
                txtAppOtherSuggestions.Text = objDT.Rows(0).Item("ApplicantOtherSugestions")
                txtBalanceAmount.Text = objDT.Rows(0).Item("CallsInArrier")
                txtPaidAmount.Text = Val(txtTotalAmount.Text) - Val(txtBalanceAmount.Text)


                txtMemberNo.Enabled = False
                txtName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)

        End Try
    End Sub

    'To check data entered by the User, function called when "OK" button is clicked 
    Function fnCheck() As Boolean
        If txtMemberNo.Text = "" Then
            MsgBox("Enter member no ", MsgBoxStyle.Exclamation)
            txtMemberNo.Focus()
            Return False
        ElseIf txtCustomerID.Text = "CID" Then
            MsgBox("Enter customer ID ", MsgBoxStyle.Exclamation)
            txtCustomerID.Focus()
            Return False
        ElseIf txtName.Text = "" Then
            MsgBox("Enter name ", MsgBoxStyle.Exclamation)

            txtName.Focus()
            Return False
        ElseIf txtFatherName.Text = "" Then
            MsgBox("Enter father name ", MsgBoxStyle.Exclamation)
            txtFatherName.Focus()
            Return False
        ElseIf Val(txtAge.Text) = 0 Then
            MsgBox("Enter age ", MsgBoxStyle.Exclamation)
            txtAge.Focus()
            Return False
        ElseIf txtPermAddress.Text = "" Then
            MsgBox("Enter address", MsgBoxStyle.Exclamation)
            txtPermAddress.Focus()
            Return False
        ElseIf cmbMemberType.SelectedItem = "" Then
            MsgBox("Select member type", MsgBoxStyle.Exclamation)
            cmbMemberType.Focus()
            Return False
        ElseIf txtReceiptNo.Text = "" And cmbStatus.SelectedItem = "Active" Then
            MsgBox("Enter receipt no.", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbShares
            txtReceiptNo.Focus()
            Return False
        ElseIf (lngPersonNo = 0 And fnReceiptCheckNo(txtReceiptNo.Text, dtpOpenDate.Value)) Then
            MsgBox("Receipt no. already exists. Enter another receipt no.")
            txtReceiptNo.Focus()
            Return False
        ElseIf txtNoOfShares.Text = "" And cmbStatus.SelectedItem = "Active" Then
            MsgBox("Enter no of shares", MsgBoxStyle.Exclamation)

            txtNoOfShares.Focus()
            Return False
        ElseIf txtPaidAmount.Text = "" And cmbStatus.SelectedItem = "Active" Then
            MsgBox("Please enter paid amount.", MsgBoxStyle.Exclamation)
            txtPaidAmount.Focus()
            Return False
        ElseIf Val(txtShareAmount.Text) = 0 And cmbStatus.SelectedItem = "Active" Then
            MsgBox("Enter share amount", MsgBoxStyle.Exclamation)
            txtShareAmount.Focus()
            Return False
        ElseIf dtpApplDate.Value > dtpOpenDate.Value Then
            MsgBox("Check applied and membeship date", MsgBoxStyle.Exclamation)
            dtpApplDate.Focus()
            Return False
        ElseIf Val(txtPaidAmount.Text) < (Val(txtShareFee.Text) + Val(txtEntryFee.Text) + Val(txtApplicationFee.Text) + Val(txtBuildingFund.Text)) Then
            MsgBox("Amount should not be less than fees (500)", MsgBoxStyle.Exclamation)
            txtPaidAmount.Focus()
            Return False
        ElseIf Val(txtPaidAmount.Text) > Val(txtTotalAmount.Text) Then
            MsgBox("Paid amount is more than total share amount ", MsgBoxStyle.Exclamation)
            txtPaidAmount.Focus()
            Return False
        ElseIf Cmb_VoucherType.SelectedIndex = -1 Then
            MsgBox("Select Cash/ Bank account type", MsgBoxStyle.Information)
            Cmb_VoucherType.Focus()
            Return False
        ElseIf Cmb_VoucherType.SelectedIndex <> -1 Then
            If Cmb_VoucherType.SelectedItem = "Bank" Then
                If Cmd_BankList.SelectedIndex = -1 Then
                    MsgBox("Select Bank account type", MsgBoxStyle.Information)
                    Cmd_BankList.Focus()
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function


    'To set form control values to Class Properties, function called when "OK" button is clicked
    Function fnSetData() As Boolean

        If lngPersonNo <> 0 Then
            objMember.PersonNo = lngPersonNo
        Else
            objMember.PersonNo = objMember.fnGetNewPersonNo()
        End If

        lngVoucherNo = fnVoucherGetNewVNo(dtpOpenDate.Value)

        objMember.Name = txtName.Text
        objMember.FatherName = txtFatherName.Text
        objMember.PermAddress = txtPermAddress.Text
        objMember.PresAddress = txtPresAddress.Text
        objMember.PhoneNo = txtPhoneNo.Text
        objMember.MobileNo = txtMobileNo.Text
        objMember.DOB = dtpDOB.Value
        objMember.Age = txtAge.Text
        objMember.AgeStatus = IIf(Val(txtAge.Text) >= 18, "M", "N")
        objMember.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objMember.ReligionCode = cmbReligion.SelectedValue
        objMember.CasteCode = cmbCaste.SelectedValue
        objMember.OccupationCode = cmbOccupation.SelectedValue
        objMember.Education = txtEducation.Text
        objMember.OffAddress = txtOffAddress.Text
        objMember.OfficeNo = txtOfficeNo.Text
        ' objMember.Photo = fnGetPhoto()
        objMember.Photo = picPhoto.ImageLocation
        'objMember.Sign = fnGetSign()
        objMember.Sign = picSignature.ImageLocation
        objMember.CustomerID = txtCustomerID.Text

        objMember.MemberNo = txtMemberNo.Text
        objMember.ApplDate = dtpApplDate.Value
        objMember.OpenDate = dtpOpenDate.Value
        If cmbMemberType.SelectedItem = "Share Capital A" Then
            objMember.Type = "SCA"
        ElseIf cmbMemberType.SelectedItem = "Share Capital B" Then
            objMember.Type = "SCB"
        Else
            objMember.Type = "SRF"
        End If
        objMember.RefNo = txtReceiptNo.Text
        'objMember.BankName =  txtBankName.Text
        If Cmb_VoucherType.SelectedItem = "Bank" Then
            objMember.BankName = Cmd_BankList.SelectedValue.ToString()
        ElseIf Cmb_VoucherType.SelectedItem = "Cash" Then
            objMember.BankName = "1"
        Else
            objMember.BankName = ""
        End If        
        objMember.NoOfShares = Val(txtNoOfShares.Text)
        objMember.ShareAmount = Val(txtShareAmount.Text)
        objMember.ShareFee = Val(txtShareFee.Text)
        objMember.ApplicationFee = Val(txtApplicationFee.Text)
        objMember.BuildingFee = Val(txtBuildingFund.Text)
        objMember.EntryFee = Val(txtEntryFee.Text)        
        objMember.AmountPaid = Val(txtPaidAmount.Text)
        objMember.BalanceAmount = Val(txtBalanceAmount.Text)
        objMember.Status = CStr(cmbStatus.SelectedItem)
        objMember.IDCard = IIf(chkIDCard1.Checked, "Y", "N")
        objMember.Remarks = txtRemark1.Text
        If txtSalary.Text = "" Then
            objMember.Salary = 0
        Else
            objMember.Salary = txtSalary.Text
        End If
        If txtOtherIncome.Text = "" Then
            objMember.OtherIncome = 0
        Else
            objMember.OtherIncome = txtOtherIncome.Text
        End If
        objMember.IntroMBNo1 = txtIntroAccNo.Text
        objMember.IntroMBNo2 = txtIntroAccNo2.Text
        objMember.ApplicantOtherSugestions = txtAppOtherSuggestions.Text
        objMember.OtherEducationSociety = txtMenOtherEduSociety.Text
        objMember.VoucherNo = lngVoucherNo
        Return True
    End Function

    'To SAVE data to table, ADD or UPDATE data
    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean
        'Check for Member Existance
        If objMember.fnCheckMember = False Then
            'ADD new Member  (ADD Mode)
            If objMember.fnAddMember(objTrans) Then
                If cmbStatus.SelectedItem = "Active" Then
                    fnGenerateVoucher(objTrans)
                    'fnGenerateReceipt(objTrans)
                End If
                fnLogEntry(pbUserId, "New member" & txtMemberNo.Text & "Created", Date.Now, "New member", objTrans)
                MessageBox.Show("New member added successfully.", "Members Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New member addition failed, because of internal error.", "Members Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else
            'Update Details (EDIT Mode)
            If objMember.fnUpdateMember(objTrans) Then
                fnLogEntry(pbUserId, "Member" & txtMemberNo.Text & "details dpdated", Date.Now, "Updated Member", objTrans)
                MessageBox.Show("Member updated successfully.", "Members Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Member updation failed, because of internal error.", "Members Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function

    'To clear form control values
    Sub sbClear()
        lngPersonNo = 0
        txtMemberNo.Text = "MB"
        txtMemberNo.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        'dtpApplDate.MaxDate = Date.Now
        dtpApplDate.Enabled = True
        'dtpApplDate.Text = Date.MaxValue
        'dtpOpenDate.MaxDate = Date.Now
        'dtpOpenDate.Text = Date.MaxValue
        dtpOpenDate.Enabled = True
        rdbMale.Checked = True
        txtAge.ResetText()
        cmbReligion.SelectedIndex = 0
        cmbCaste.SelectedIndex = 0
        cmbOccupation.SelectedIndex = 0
        cmbMemberType.SelectedIndex = 0
        cmbMemberType.Enabled = True
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()

        grpShares.Enabled = True
        txtReceiptNo.ResetText()
        txtNoOfShares.ResetText()
        txtPaidAmount.ResetText()
        txtBalanceAmount.ResetText()
        txtApplicationFee.ResetText()
        txtEntryFee.ResetText()        
        txtShareFee.ResetText()
        txtShareAmount.ResetText()
        txtBuildingFund.ResetText()
        txtTotalAmount.ResetText()
        txtReceiptNo.ResetText()
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        chkIDCard.Checked = False
        txtSalary.ResetText()
        txtOtherIncome.ResetText()
        txtEducation.ResetText()
        txtIntroAccNo.ResetText()
        txtIntroAccNo.Enabled = True
        txtOffAddress.ResetText()
        txtRemarks.ResetText()
        txtIntroAccNo2.ResetText()
        txtAppOtherSuggestions.ResetText()
        txtMenOtherEduSociety.ResetText()
        txtOfficeNo.ResetText()
        txtCustomerID.Text = "CID"
        txtCustomerID.Enabled = False
    End Sub

    'To enter details into Receipt table 
    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptNo.Text, txtName.Text, dtpOpenDate.Value, txtTotalAmount.Text, "")

        'Receipt sub details
        If Val(txtEntryFee.Text) <> 0 Then
            fnReceiptEnterSub(txtReceiptNo.Text, dtpOpenDate.Value, "Entrance Fee", Val(txtEntryFee.Text), 1)
        End If
        If Val(txtShareFee.Text) <> 0 Then
            fnReceiptEnterSub(txtReceiptNo.Text, dtpOpenDate.Value, "Share Fee", Val(txtShareFee.Text), 2)
        End If
        If Val(txtShareAmount.Text) <> 0 Then
            fnReceiptEnterSub(txtReceiptNo.Text, dtpOpenDate.Value, "Share Amount ", Val(txtShareAmount.Text), 3)
        End If
        If Val(txtBuildingFund.Text) <> 0 Then
            fnReceiptEnterSub(txtReceiptNo.Text, dtpOpenDate.Value, "Building Fund", Val(txtBuildingFund.Text), 4)
        End If

        Return True

    End Function

    'To enter Voucher details
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngSlNo As Long

        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtMemberNo.Text, txtReceiptNo.Text, dtpOpenDate.Value, Val(txtPaidAmount.Text), NarrationTextBox.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        If Val(txtEntryFee.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By member " & txtMemberNo.Text, "To", 7, 0, Val(txtEntryFee.Text), 1, "Y", objTrans)
        End If

        If Val(txtShareFee.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By member " & txtMemberNo.Text, "To", 8, 0, Val(txtShareFee.Text), 2, "Y", objTrans)
        End If

        If Val(txtShareAmount.Text) <> 0 Then
            If cmbMemberType.SelectedItem = "Share Capital A" Then
                'fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "To", 3, 0, Val(txtShareAmount.Text), 3, "Y", objTrans)

            ElseIf cmbMemberType.SelectedItem = "Share Capital B" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "To", 4, 0, Val(txtShareAmount.Text), 3, "Y", objTrans)

            Else
                fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "To", 5, 0, Val(txtShareAmount.Text), 3, "Y", objTrans)
            End If
        End If

        If Val(txtBuildingFund.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "To", 6, 0, Val(txtBuildingFund.Text), 4, "Y", objTrans)
        End If

        If Val(txtApplicationFee.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "To", 175, 0, Val(txtApplicationFee.Text), 4, "Y", objTrans)
        End If

        'Debit accounts 
        If Val(txtPaidAmount.Text) <> 0 Then
            'fnVoucherEnterSub(lngVoucherNo, 2, "", dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "By", 1, Val(txtPaidAmount.Text), 0, 5, "Y", objTrans)          
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "By", Integer.Parse(objMember.BankName), Val(txtPaidAmount.Text), 0, 5, "Y", objTrans)
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "By", 184, 0, Val(Convert.ToDecimal(txtPaidAmount.Text) - Convert.ToDecimal(txtApplicationFee.Text) - Convert.ToDecimal(txtShareFee.Text) - Convert.ToDecimal(txtEntryFee.Text)), 5, "Y", objTrans)
        End If
        If Val(txtBalanceAmount.Text) <> 0 Then
            ' fnVoucherEnterSub(lngVoucherNo, 2, "", dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "By", 176, Val(txtBalanceAmount.Text), 0, 5, "Y", objTrans)
        End If

        Return True

    End Function

    'to calculate Total amount
    Sub sbCalcTotal()
        Dim dblTotal As Double = 0
        Dim dblSAmount As Double = 0
        dblTotal = Val(txtEntryFee.Text)
        'txtShareFee.Text = Format((Val(dblShareFee) * Val(txtNoOfShares.Text)), "0.00")
        txtShareFee.Text = Format((Val(dblShareFee)), "0.00")
        dblTotal += Val(txtShareFee.Text)
        txtBuildingFund.Text = Format((Val(dblBuildingFund)), "0.00")
        dblTotal += Val(txtBuildingFund.Text)
        txtShareAmount.Text = Format(Val(dblShareAmount) * Val(txtNoOfShares.Text), "0.00")
        dblTotal += Val(txtShareAmount.Text)
        txtTotalAmount.Text = Format(dblTotal, "0.00")
        dblTotal += Val(txtApplicationFee.Text)
        txtTotalAmount.Text = Format(dblTotal, "0.00")

        ''Balance amount, if customer not paid full share amount
        txtBalanceAmount.Text = Val(txtTotalAmount.Text) - Val(txtPaidAmount.Text)
    End Sub

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

#End Region

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalary.TextChanged, txtOtherIncome.TextChanged
        txtTotalIncome.Text = Val(txtSalary.Text)
        txtTotalIncome.Text += Val(txtOtherIncome.Text)
    End Sub

    Function fnCheckRoles() As Boolean
        Dim tempDt As New DataTable
        'Dim obj As New frmViewShares
        Dim objUser As New clsUsers
        ' pbUserId = txtUserName.Text

        tempDt = objUser.fnSubModule(pbUserId, "NewMember")
        ' MsgBox(tempDt.Select("Module='Master'")(0).Item(0))

        If Not tempDt.Select("SubModule='FamilyDetail'").Length > 0 Then
            Me.btnFamilyDetails.Enabled = False
            'objfrmMain.btnMembers.Visible = False
        End If
        If Not tempDt.Select("SubModule='MembersDetail'").Length > 0 Then
            Me.btnMembersList.Enabled = False
        End If
        If Not tempDt.Select("SubModule='Add'").Length > 0 Then
            Me.btnAdd.Enabled = False
        End If
        If Not tempDt.Select("SubModule='NomineeDetail'").Length > 0 Then
            Me.btnNominees.Enabled = False
        End If
        If Not tempDt.Select("SubModule='ReceptDetail'").Length > 0 Then
            Me.btnReceipt.Enabled = False
        End If
        If Not tempDt.Select("SubModule='Issueidcard'").Length > 0 Then
            Me.btnIDCard.Enabled = False
        End If

    End Function

    Private Sub frmMemberCreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated

        dtpDOB.MaxDate = "31/Dec/9998 12:00:00 AM"

        dtpApplDate.MaxDate = "31/Dec/9998 12:00:00 AM"
        dtpApplDate.Value = Date.Now
        dtpOpenDate.MaxDate = "31/Dec/9998 12:00:00 AM"
        dtpOpenDate.Value = Date.Now
        cmbStatus.SelectedItem = "Active"
        sbLoadControlValues()

        If txtMemberNo.Text <> "MB" Then
            sbLoadMember()
        Else
            btnAdd_Click(sender, e)
        End If

    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtMemberNo.Text) <> "MB" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtMemberNo.Text
            objNominees.txtName.Text = txtName.Text
            If txtPermAddress.Text = String.Empty Then
                objNominees.txtAddress.Text = txtPresAddress.Text
            Else
                objNominees.txtAddress.Text = txtPermAddress.Text
            End If
            objNominees.chrType = "N"
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Enter valid Member No", MsgBoxStyle.Information, "Members Module")
            txtMemberNo.Focus()
        End If
    End Sub

    Private Sub btnLoadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPhoto.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
                picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
                MsgBox("Select Image files only")
            End Try
        End If
    End Sub

    Private Sub btnCancelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPhoto.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnLoadSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSign.Click

        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picSignature.Image = Image.FromFile(OpenFileDialog1.FileName)
                picSignature.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
                MsgBox("Select Image files only")
            End Try
        End If
    End Sub

    Private Sub btnCancelSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSign.Click

        picSignature.Image = Nothing

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then

                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        If MsgBox("You want to Add another Member?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
                            btnAdd_Click(sender, e)
                        Else
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            objTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            objTrans.Dispose()
        End Try


    End Sub

    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click
        If Trim(txtMemberNo.Text) <> "MB" Then
            Dim objFamilyDetails As New frmFamily_Detail
            objFamilyDetails.txtAccountNo.Text = txtMemberNo.Text
            objFamilyDetails.txtName.Text = txtName.Text
            objFamilyDetails.chrType = "F"
            objFamilyDetails.ShowDialog(Me)
            objFamilyDetails.Dispose()
        Else
            MsgBox("Enter valid Member No", MsgBoxStyle.Information, "Members")
            txtMemberNo.Focus()
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

#Region "Text Changed Events"

    Private Sub txtEntranceFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoOfShares.TextChanged ', txtShareFee.TextChanged, txtBuildingFund.TextChanged, txtEntryFee.TextChanged
        sbCalcTotal()
    End Sub

#End Region

    Private Sub btnReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceipt.Click
        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/ReceiptKan.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{receiptmaintbl.ReceiptNo}='" & txtReceiptNo.Text & "' and {ReceiptMainTbl.ReceiptDate}=#" & Format(dtpOpenDate.Value, "MM-dd-yyyy") & "#"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtMemberNo.Text = objMemberSearch.strMemberNo
            sbLoadMember()
        End If
        objMemberSearch.Dispose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        nMode = CTAdd
        sbClear()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objMember.fnGetNewMembershipNo, 4, 8)
        dtpApplDate.MaxDate = "31/Dec/9998 12:00:00 AM"
        dtpApplDate.Value = Date.Now
        dtpOpenDate.MaxDate = "31/Dec/9998 12:00:00 AM"
        dtpOpenDate.Value = Date.Now
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "MB" & String.Format("{0:00000}", CInt(TempNewNo))
            txtMemberNo.Text = Temp
            txtMemberNo.Focus()
        Else
            MsgBox("MemberShip number exceeds the maximum alloted number", MsgBoxStyle.Information, "Members Module")
        End If
    End Sub

    Private Sub frmMemberCreation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F3 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnIDCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDCard.Click
        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/MemberIDCardKan.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{MemberTbl.MemberNo} startswith '" & txtMemberNo.Text & "'"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()
    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        If chkSame.Checked = True Then
            txtPermAddress.Text = txtPresAddress.Text
        End If
    End Sub

    Private Sub txtPermAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermAddress.TextChanged
        If chkSame.Checked = True Then
            txtPresAddress.Text = txtPermAddress.Text
        End If
    End Sub

    Private Sub txtMemberNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberNo.Leave

        If Trim(txtMemberNo.Text) <> "MB" Then
            objMember.MemberNo = txtMemberNo.Text
            If objMember.fnCheckMember() Then
                If MsgBox("Member no already exists! " & Chr(13) & Chr(13) & "You want to edit member details?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Edit") = MsgBoxResult.Yes Then
                    sbLoadMember()
                Else
                    btnAdd_Click(sender, e)
                End If
            End If
        End If

    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged

        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)

    End Sub

    Private Sub btnMembersList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMembersList.Click

        Dim objfrmMembersList As frmMembersList
        objfrmMembersList = frmMembersList.DefInstance
        objfrmMembersList.MdiParent = Me.MdiParent
        objfrmMembersList.BringToFront()
        objfrmMembersList.Show()
        objfrmMembersList = Nothing

    End Sub

    Private Sub btnShareDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShareDetails.Click
        If Trim(txtMemberNo.Text) <> "MB" Then
            Dim objfrmShareTransaction As frmSharesTransaction
            objfrmShareTransaction = frmSharesTransaction.DefInstance
            objfrmShareTransaction.BringToFront()
            objfrmShareTransaction.MdiParent = Me.MdiParent
            objfrmShareTransaction.txtMemberNo.Text = txtMemberNo.Text
            objfrmShareTransaction.Show()
            objfrmShareTransaction = Nothing
        Else
            MsgBox("Enter valid member no.", MsgBoxStyle.Information, "Members Module")
            txtMemberNo.Focus()
        End If
    End Sub

    Private Sub txtMemberNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberNo.TextChanged
        If Not txtMemberNo.Text.StartsWith("MB") Then
            txtMemberNo.Undo()
            txtMemberNo.ClearUndo()
        End If
    End Sub

    Private Sub cmbMemberType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMemberType.SelectedIndexChanged

        If cmbMemberType.SelectedItem = "Share Capital A" Then
            objMember.Type = "SCA"
        ElseIf cmbMemberType.SelectedItem = "Share Capital B" Then
            objMember.Type = "SCB"
        Else
            objMember.Type = "SRF"
        End If
        txtNoOfShares.Text = ""
        sbLoadMaster()
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            'btnAdd_Click(sender, e)
            txtCustomerID.Text = objCustomerList.strCustomerID
            sbLoadCustomer()
        End If
        objCustomerList.Dispose()
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtIntroAccNo.Text = objMemberSearch.strMemberNo
            txtIntroAccNo.Enabled = False
        End If
        objMemberSearch.Dispose()
    End Sub

#End Region

#Region "ENTER KEY Events"

    Private Sub dtpApplDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpApplDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpDOB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpOpenDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpOpenDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbCaste_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbMemberType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbOccupation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbPermVillage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbPresVillage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbReligion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub txtOffAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub txtNoOfShares_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoOfShares.KeyDown
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

    Private Sub chkIDCard_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIDCard.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkSame_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbMale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbFemale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtIntroAccNo2.Text = objMemberSearch.strMemberNo
            txtIntroAccNo2.Enabled = False
        End If
        objMemberSearch.Dispose()
    End Sub
#End Region




    Private Sub txtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaidAmount.TextChanged
        If Val(txtPaidAmount.Text) <= Val(txtTotalAmount.Text) Then
            txtBalanceAmount.Text = Convert.ToDouble(Val(txtTotalAmount.Text)) - Convert.ToDouble(Val(txtPaidAmount.Text))
        Else
            MsgBox("Pay amount is more then Share Amount", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
        End If
    End Sub




    Private Sub Cmb_VoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_VoucherType.SelectedIndexChanged
        If Cmb_VoucherType.SelectedItem = "Cash" Then
            Cmd_BankList.Visible = False
            Label45.Visible = False
            '  CheckDetailsGroupBox.Visible = False
        Else
            Cmd_BankList.Visible = True
            Label45.Visible = True
            '  CheckDetailsGroupBox.Visible = True
            Dim objDV As DataView
            If objLedger.fnGetBankLedger Then
                objDV = New DataView(objLedger.LedgerTable, "", "Name", DataViewRowState.OriginalRows)
                Cmd_BankList.DataSource = objDV
                Cmd_BankList.DisplayMember = "Name"
                Cmd_BankList.ValueMember = "LedgerNo"
                Cmd_BankList.SelectedIndex = -1
            End If
        End If
    End Sub
End Class
