#Region "Import Statements"
Imports System.IO
#End Region

Public Class frmCAccCreation
    Inherits System.Windows.Forms.Form

#Region "GlobalVariables"
    Dim objCA As New clsCurrentAccount
    Dim lngOrganizationNo As Long = 0
    Dim lngPersonNo As Long = 0
    Dim objMember As New clsMember
    Dim objSign As New clsSignatories
    Dim objPerson As New clsPerson
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
    Friend WithEvents TabCA As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbAccStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnSignatoryDetail As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbOpMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabOrganization As System.Windows.Forms.TabPage
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAvailBal As BankControls.NumericControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents txtODAmount As BankControls.NumericControl
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkphotoId As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents btnLoadSign As BankControls.NewButton
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtOffAddress As BankControls.TextControl
    Friend WithEvents txtEducation As BankControls.TextControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents btnNewMember As BankControls.NewButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCaste As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents txtPresAddress As BankControls.TextControl
    Friend WithEvents txtPhoneNo As BankControls.NumericControl
    Friend WithEvents txtMobileNo As BankControls.NumericControl
    Friend WithEvents txtPermAddress As BankControls.TextControl
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dtpRegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKSTNo As BankControls.TextControl
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtCSTNo As BankControls.TextControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtRegNo As BankControls.TextControl
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtSecondSignature As BankControls.TextControl
    Friend WithEvents txtFirstSignature As BankControls.TextControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtManSignature As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo2 As BankControls.NumericControl
    Friend WithEvents cmborgtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhoneNo1 As BankControls.NumericControl
    Friend WithEvents txtAddress As BankControls.TextControl
    Friend WithEvents txtBusiness As BankControls.TextControl
    Friend WithEvents dtpEstablishment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents rdbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOrganization As System.Windows.Forms.RadioButton
    Friend WithEvents txtMobileNo2 As BankControls.NumericControl
    Friend WithEvents chkadressId As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents dtpPDeedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpResolutionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeNo As BankControls.NumericControl
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCAccCreation))
        Me.btnSignatoryDetail = New BankControls.NewButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rdbIndividual = New System.Windows.Forms.RadioButton()
        Me.rdbOrganization = New System.Windows.Forms.RadioButton()
        Me.txtAccNo = New BankControls.TextControl()
        Me.btnSearch = New BankControls.NewButton()
        Me.txtName = New BankControls.TextControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New BankControls.NewButton()
        Me.btnOk = New BankControls.NewButton()
        Me.btnCancel = New BankControls.NewButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtOfficeNo = New BankControls.NumericControl()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New BankControls.TextControl()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOffAddress = New BankControls.TextControl()
        Me.txtEducation = New BankControls.TextControl()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnNewMember = New BankControls.NewButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rdbMajor = New System.Windows.Forms.RadioButton()
        Me.rdbMinor = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFatherName = New BankControls.TextControl()
        Me.chkSame = New System.Windows.Forms.CheckBox()
        Me.cmbCaste = New System.Windows.Forms.ComboBox()
        Me.cmbReligion = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbOccupation = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtAge = New BankControls.NumericControl()
        Me.txtPresAddress = New BankControls.TextControl()
        Me.txtPhoneNo = New BankControls.NumericControl()
        Me.txtMobileNo = New BankControls.NumericControl()
        Me.txtPermAddress = New BankControls.TextControl()
        Me.btnMemSearch = New BankControls.NewButton()
        Me.TabOrganization = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtpResolutionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.dtpPDeedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.dtpRegDate = New System.Windows.Forms.DateTimePicker()
        Me.txtKSTNo = New BankControls.TextControl()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtCSTNo = New BankControls.TextControl()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtRegNo = New BankControls.TextControl()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtMobileNo2 = New BankControls.NumericControl()
        Me.txtSecondSignature = New BankControls.TextControl()
        Me.txtFirstSignature = New BankControls.TextControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtManSignature = New BankControls.TextControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPhoneNo2 = New BankControls.NumericControl()
        Me.cmborgtype = New System.Windows.Forms.ComboBox()
        Me.txtPhoneNo1 = New BankControls.NumericControl()
        Me.txtAddress = New BankControls.TextControl()
        Me.txtBusiness = New BankControls.TextControl()
        Me.dtpEstablishment = New System.Windows.Forms.DateTimePicker()
        Me.TabCA = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkphotoId = New System.Windows.Forms.CheckBox()
        Me.chkadressId = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtODAmount = New BankControls.NumericControl()
        Me.txtReceiptNo = New BankControls.NumericControl()
        Me.txtAvailBal = New BankControls.NumericControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbOpMode = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbAccType = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbAccStatus = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtRemarks = New BankControls.TextControl()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLoadPhoto = New BankControls.NewButton()
        Me.btnCancelPhoto = New BankControls.NewButton()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.btnCancelSign = New BankControls.NewButton()
        Me.btnLoadSign = New BankControls.NewButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NewButton3 = New BankControls.NewButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NewButton1 = New BankControls.NewButton()
        Me.NewButton5 = New BankControls.NewButton()
        Me.NewButton2 = New BankControls.NewButton()
        Me.btnNominees = New BankControls.NewButton()
        Me.GroupBox1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabOrganization.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabCA.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignatoryDetail
        '
        Me.btnSignatoryDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSignatoryDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignatoryDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignatoryDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignatoryDetail.ForeColor = System.Drawing.Color.Black
        Me.btnSignatoryDetail.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSignatoryDetail.Image = CType(resources.GetObject("btnSignatoryDetail.Image"), System.Drawing.Image)
        Me.btnSignatoryDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignatoryDetail.Location = New System.Drawing.Point(8, 216)
        Me.btnSignatoryDetail.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSignatoryDetail.Name = "btnSignatoryDetail"
        Me.btnSignatoryDetail.Size = New System.Drawing.Size(168, 40)
        Me.btnSignatoryDetail.TabIndex = 2
        Me.btnSignatoryDetail.Text = "Signatory Detail"
        Me.btnSignatoryDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSignatoryDetail.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.txtAccNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(48, 104)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(162, 16)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "Current Accouont For :"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rdbIndividual)
        Me.Panel7.Controls.Add(Me.rdbOrganization)
        Me.Panel7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(216, 96)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(224, 40)
        Me.Panel7.TabIndex = 6
        '
        'rdbIndividual
        '
        Me.rdbIndividual.Checked = True
        Me.rdbIndividual.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIndividual.Location = New System.Drawing.Point(8, 7)
        Me.rdbIndividual.Name = "rdbIndividual"
        Me.rdbIndividual.Size = New System.Drawing.Size(96, 24)
        Me.rdbIndividual.TabIndex = 0
        Me.rdbIndividual.TabStop = True
        Me.rdbIndividual.Text = "Individual"
        '
        'rdbOrganization
        '
        Me.rdbOrganization.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOrganization.Location = New System.Drawing.Point(104, 8)
        Me.rdbOrganization.Name = "rdbOrganization"
        Me.rdbOrganization.Size = New System.Drawing.Size(112, 24)
        Me.rdbOrganization.TabIndex = 1
        Me.rdbOrganization.TabStop = True
        Me.rdbOrganization.Text = "Organization"
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(200, 61)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 7
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.Text = "CA"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(336, 61)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtName.Location = New System.Drawing.Point(536, 60)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 255
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Account No. :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Individual \ Organization Name"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(40, 560)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(552, 560)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(656, 560)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabOrganization)
        Me.TabControl1.Controls.Add(Me.TabCA)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 416)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(776, 387)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Individual Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtOfficeNo)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.txtCustomerID)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtOffAddress)
        Me.Panel2.Controls.Add(Me.txtEducation)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.btnNewMember)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFatherName)
        Me.Panel2.Controls.Add(Me.chkSame)
        Me.Panel2.Controls.Add(Me.cmbCaste)
        Me.Panel2.Controls.Add(Me.cmbReligion)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.dtpDOB)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.cmbOccupation)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.txtAge)
        Me.Panel2.Controls.Add(Me.txtPresAddress)
        Me.Panel2.Controls.Add(Me.txtPhoneNo)
        Me.Panel2.Controls.Add(Me.txtMobileNo)
        Me.Panel2.Controls.Add(Me.txtPermAddress)
        Me.Panel2.Controls.Add(Me.btnMemSearch)
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 376)
        Me.Panel2.TabIndex = 0
        '
        'txtOfficeNo
        '
        Me.txtOfficeNo.AfterDecimal = 0
        Me.txtOfficeNo.BeforeDecimal = 20
        Me.txtOfficeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeNo.Location = New System.Drawing.Point(504, 344)
        Me.txtOfficeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeNo.MaxLength = 20
        Me.txtOfficeNo.MaxValue = 0.0R
        Me.txtOfficeNo.MinValue = 0.0R
        Me.txtOfficeNo.Name = "txtOfficeNo"
        Me.txtOfficeNo.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeNo.TabIndex = 35
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(352, 344)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(85, 16)
        Me.Label47.TabIndex = 34
        Me.Label47.Text = "Office No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(144, 24)
        Me.txtCustomerID.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(128, 23)
        Me.txtCustomerID.SpecialChar = True
        Me.txtCustomerID.TabIndex = 1
        Me.txtCustomerID.Text = "CID"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(24, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 16)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "CustomerID :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(24, 80)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(115, 16)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "Husband Name  "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(352, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Office Address :"
        '
        'txtOffAddress
        '
        Me.txtOffAddress.AlphaNumeric = True
        Me.txtOffAddress.BlankSpace = True
        Me.txtOffAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOffAddress.Location = New System.Drawing.Point(504, 272)
        Me.txtOffAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOffAddress.Mandatory = False
        Me.txtOffAddress.MaxLength = 255
        Me.txtOffAddress.Multiline = True
        Me.txtOffAddress.Name = "txtOffAddress"
        Me.txtOffAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtOffAddress.SpecialChar = True
        Me.txtOffAddress.TabIndex = 31
        '
        'txtEducation
        '
        Me.txtEducation.AlphaNumeric = True
        Me.txtEducation.BlankSpace = False
        Me.txtEducation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEducation.Location = New System.Drawing.Point(144, 320)
        Me.txtEducation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEducation.Mandatory = False
        Me.txtEducation.MaxLength = 50
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(168, 23)
        Me.txtEducation.SpecialChar = True
        Me.txtEducation.TabIndex = 33
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(24, 320)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(84, 16)
        Me.Label38.TabIndex = 32
        Me.Label38.Text = "Education :"
        '
        'btnNewMember
        '
        Me.btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMember.ForeColor = System.Drawing.Color.Black
        Me.btnNewMember.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewMember.Image = CType(resources.GetObject("btnNewMember.Image"), System.Drawing.Image)
        Me.btnNewMember.Location = New System.Drawing.Point(312, 24)
        Me.btnNewMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(32, 24)
        Me.btnNewMember.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbMale)
        Me.Panel3.Controls.Add(Me.rdbFemale)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(144, 200)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 32)
        Me.Panel3.TabIndex = 21
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 7)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 7)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rdbMajor)
        Me.Panel5.Controls.Add(Me.rdbMinor)
        Me.Panel5.Enabled = False
        Me.Panel5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(144, 168)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(168, 32)
        Me.Panel5.TabIndex = 17
        '
        'rdbMajor
        '
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 7)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 0
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.rdbMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 7)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 1
        Me.rdbMinor.TabStop = True
        Me.rdbMinor.Text = "Minor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Age Status :  "
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.BlankSpace = False
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(144, 64)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 255
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 7
        '
        'chkSame
        '
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(504, 76)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(216, 24)
        Me.chkSame.TabIndex = 8
        Me.chkSame.Text = "same as permanent address"
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(144, 280)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 29
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(144, 240)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(352, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Present Address : "
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(144, 104)
        Me.dtpDOB.MaxDate = New Date(9996, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtpDOB.TabIndex = 11
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 16)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Father Name /"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(24, 104)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 16)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Date of Birth :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(24, 136)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 16)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Age : "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(24, 208)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Gender : "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(24, 240)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 16)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Religion : "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(32, 280)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(62, 16)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Caste : "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(352, 240)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 16)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Occupation : "
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(352, 12)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(152, 19)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Permanent Address :   "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(504, 240)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 27
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(352, 180)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(91, 16)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = "Phone No. : "
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(352, 212)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(92, 16)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = "Mobile No. : "
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(144, 136)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxValue = 100.0R
        Me.txtAge.MinValue = 0.0R
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 23)
        Me.txtAge.TabIndex = 15
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(504, 108)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 255
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 13
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 20
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(504, 180)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxValue = 0.0R
        Me.txtPhoneNo.MinValue = 0.0R
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.TabIndex = 19
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 20
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(504, 212)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0.0R
        Me.txtMobileNo.MinValue = 0.0R
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.TabIndex = 23
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(504, 12)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 255
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 5
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(280, 24)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 2
        '
        'TabOrganization
        '
        Me.TabOrganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabOrganization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabOrganization.Controls.Add(Me.Panel6)
        Me.TabOrganization.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.TabOrganization.Location = New System.Drawing.Point(4, 25)
        Me.TabOrganization.Name = "TabOrganization"
        Me.TabOrganization.Size = New System.Drawing.Size(776, 387)
        Me.TabOrganization.TabIndex = 0
        Me.TabOrganization.Text = "Organization Detail"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dtpResolutionDate)
        Me.Panel6.Controls.Add(Me.Label46)
        Me.Panel6.Controls.Add(Me.dtpPDeedDate)
        Me.Panel6.Controls.Add(Me.Label45)
        Me.Panel6.Controls.Add(Me.dtpRegDate)
        Me.Panel6.Controls.Add(Me.txtKSTNo)
        Me.Panel6.Controls.Add(Me.Label39)
        Me.Panel6.Controls.Add(Me.txtCSTNo)
        Me.Panel6.Controls.Add(Me.Label40)
        Me.Panel6.Controls.Add(Me.txtRegNo)
        Me.Panel6.Controls.Add(Me.Label41)
        Me.Panel6.Controls.Add(Me.Label42)
        Me.Panel6.Controls.Add(Me.Label37)
        Me.Panel6.Controls.Add(Me.txtMobileNo2)
        Me.Panel6.Controls.Add(Me.txtSecondSignature)
        Me.Panel6.Controls.Add(Me.txtFirstSignature)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.txtManSignature)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.txtPhoneNo2)
        Me.Panel6.Controls.Add(Me.cmborgtype)
        Me.Panel6.Controls.Add(Me.txtPhoneNo1)
        Me.Panel6.Controls.Add(Me.txtAddress)
        Me.Panel6.Controls.Add(Me.txtBusiness)
        Me.Panel6.Controls.Add(Me.dtpEstablishment)
        Me.Panel6.Location = New System.Drawing.Point(8, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(760, 368)
        Me.Panel6.TabIndex = 0
        '
        'dtpResolutionDate
        '
        Me.dtpResolutionDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpResolutionDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpResolutionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResolutionDate.Location = New System.Drawing.Point(176, 296)
        Me.dtpResolutionDate.Name = "dtpResolutionDate"
        Me.dtpResolutionDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpResolutionDate.TabIndex = 119
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(8, 296)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(136, 16)
        Me.Label46.TabIndex = 142
        Me.Label46.Text = "Resolutation Date :"
        '
        'dtpPDeedDate
        '
        Me.dtpPDeedDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpPDeedDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPDeedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPDeedDate.Location = New System.Drawing.Point(176, 256)
        Me.dtpPDeedDate.Name = "dtpPDeedDate"
        Me.dtpPDeedDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpPDeedDate.TabIndex = 118
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(8, 256)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(167, 16)
        Me.Label45.TabIndex = 140
        Me.Label45.Text = "Partnership Deed Date :"
        '
        'dtpRegDate
        '
        Me.dtpRegDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpRegDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegDate.Location = New System.Drawing.Point(176, 224)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpRegDate.TabIndex = 117
        '
        'txtKSTNo
        '
        Me.txtKSTNo.AlphaNumeric = True
        Me.txtKSTNo.BlankSpace = True
        Me.txtKSTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKSTNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtKSTNo.Location = New System.Drawing.Point(176, 128)
        Me.txtKSTNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtKSTNo.Mandatory = False
        Me.txtKSTNo.MaxLength = 20
        Me.txtKSTNo.Name = "txtKSTNo"
        Me.txtKSTNo.Size = New System.Drawing.Size(168, 23)
        Me.txtKSTNo.SpecialChar = True
        Me.txtKSTNo.TabIndex = 114
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(8, 128)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 16)
        Me.Label39.TabIndex = 137
        Me.Label39.Text = "KST No. :"
        '
        'txtCSTNo
        '
        Me.txtCSTNo.AlphaNumeric = True
        Me.txtCSTNo.BlankSpace = True
        Me.txtCSTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSTNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCSTNo.Location = New System.Drawing.Point(176, 160)
        Me.txtCSTNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCSTNo.Mandatory = False
        Me.txtCSTNo.MaxLength = 20
        Me.txtCSTNo.Name = "txtCSTNo"
        Me.txtCSTNo.Size = New System.Drawing.Size(168, 23)
        Me.txtCSTNo.SpecialChar = True
        Me.txtCSTNo.TabIndex = 115
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(8, 160)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(73, 16)
        Me.Label40.TabIndex = 138
        Me.Label40.Text = "CST No. :"
        '
        'txtRegNo
        '
        Me.txtRegNo.AlphaNumeric = True
        Me.txtRegNo.BlankSpace = True
        Me.txtRegNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRegNo.Location = New System.Drawing.Point(176, 192)
        Me.txtRegNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRegNo.Mandatory = False
        Me.txtRegNo.MaxLength = 20
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(168, 23)
        Me.txtRegNo.SpecialChar = True
        Me.txtRegNo.TabIndex = 116
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(8, 192)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(70, 16)
        Me.Label41.TabIndex = 136
        Me.Label41.Text = "Reg No. :"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(8, 224)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(79, 16)
        Me.Label42.TabIndex = 135
        Me.Label42.Text = "Reg Date :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(352, 168)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(92, 16)
        Me.Label37.TabIndex = 129
        Me.Label37.Text = "Mobile No. : "
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.AfterDecimal = 0
        Me.txtMobileNo2.BeforeDecimal = 20
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo2.Location = New System.Drawing.Point(568, 176)
        Me.txtMobileNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo2.MaxLength = 20
        Me.txtMobileNo2.MaxValue = 0.0R
        Me.txtMobileNo2.MinValue = 0.0R
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo2.TabIndex = 123
        '
        'txtSecondSignature
        '
        Me.txtSecondSignature.AlphaNumeric = True
        Me.txtSecondSignature.BlankSpace = False
        Me.txtSecondSignature.Enabled = False
        Me.txtSecondSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondSignature.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSecondSignature.Location = New System.Drawing.Point(568, 296)
        Me.txtSecondSignature.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSecondSignature.Mandatory = False
        Me.txtSecondSignature.Name = "txtSecondSignature"
        Me.txtSecondSignature.Size = New System.Drawing.Size(184, 23)
        Me.txtSecondSignature.SpecialChar = True
        Me.txtSecondSignature.TabIndex = 126
        Me.txtSecondSignature.TabStop = False
        '
        'txtFirstSignature
        '
        Me.txtFirstSignature.AlphaNumeric = True
        Me.txtFirstSignature.BlankSpace = False
        Me.txtFirstSignature.Enabled = False
        Me.txtFirstSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstSignature.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFirstSignature.Location = New System.Drawing.Point(568, 256)
        Me.txtFirstSignature.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFirstSignature.Mandatory = False
        Me.txtFirstSignature.Name = "txtFirstSignature"
        Me.txtFirstSignature.Size = New System.Drawing.Size(184, 23)
        Me.txtFirstSignature.SpecialChar = True
        Me.txtFirstSignature.TabIndex = 125
        Me.txtFirstSignature.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(352, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 16)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Second Auxiliary Signatories :   "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(352, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 16)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "First Auxiliary Signatories :   "
        '
        'txtManSignature
        '
        Me.txtManSignature.AlphaNumeric = True
        Me.txtManSignature.BlankSpace = False
        Me.txtManSignature.Enabled = False
        Me.txtManSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManSignature.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtManSignature.Location = New System.Drawing.Point(568, 216)
        Me.txtManSignature.LostFocusColour = System.Drawing.Color.Empty
        Me.txtManSignature.Mandatory = False
        Me.txtManSignature.Name = "txtManSignature"
        Me.txtManSignature.Size = New System.Drawing.Size(184, 23)
        Me.txtManSignature.SpecialChar = True
        Me.txtManSignature.TabIndex = 124
        Me.txtManSignature.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Mandatory Signatories :   "
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(352, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 17)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Phone No.2 :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(352, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 17)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Phone No.1 :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Address"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 17)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Nature Of  Business :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 17)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Year Of Establishment :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Organization Type :  "
        '
        'txtPhoneNo2
        '
        Me.txtPhoneNo2.AfterDecimal = 0
        Me.txtPhoneNo2.BeforeDecimal = 20
        Me.txtPhoneNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo2.Location = New System.Drawing.Point(568, 136)
        Me.txtPhoneNo2.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo2.MaxLength = 20
        Me.txtPhoneNo2.MaxValue = 0.0R
        Me.txtPhoneNo2.MinValue = 0.0R
        Me.txtPhoneNo2.Name = "txtPhoneNo2"
        Me.txtPhoneNo2.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo2.TabIndex = 122
        '
        'cmborgtype
        '
        Me.cmborgtype.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmborgtype.Items.AddRange(New Object() {"Joint Hindu Family", "partnership ", "proprietorship", "Trust", "Private Ltd. Co", "Public Ltd Co.", "Co-operative Society"})
        Me.cmborgtype.Location = New System.Drawing.Point(176, 16)
        Me.cmborgtype.Name = "cmborgtype"
        Me.cmborgtype.Size = New System.Drawing.Size(168, 24)
        Me.cmborgtype.TabIndex = 111
        '
        'txtPhoneNo1
        '
        Me.txtPhoneNo1.AfterDecimal = 0
        Me.txtPhoneNo1.BeforeDecimal = 20
        Me.txtPhoneNo1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo1.Location = New System.Drawing.Point(568, 96)
        Me.txtPhoneNo1.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo1.MaxLength = 20
        Me.txtPhoneNo1.MaxValue = 0.0R
        Me.txtPhoneNo1.MinValue = 0.0R
        Me.txtPhoneNo1.Name = "txtPhoneNo1"
        Me.txtPhoneNo1.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo1.TabIndex = 121
        '
        'txtAddress
        '
        Me.txtAddress.AlphaNumeric = True
        Me.txtAddress.BlankSpace = False
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAddress.Location = New System.Drawing.Point(568, 16)
        Me.txtAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAddress.Mandatory = False
        Me.txtAddress.MaxLength = 255
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtAddress.SpecialChar = True
        Me.txtAddress.TabIndex = 120
        '
        'txtBusiness
        '
        Me.txtBusiness.AlphaNumeric = True
        Me.txtBusiness.BlankSpace = False
        Me.txtBusiness.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusiness.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBusiness.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtBusiness.Location = New System.Drawing.Point(176, 96)
        Me.txtBusiness.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBusiness.Mandatory = False
        Me.txtBusiness.MaxLength = 255
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(168, 23)
        Me.txtBusiness.SpecialChar = True
        Me.txtBusiness.TabIndex = 113
        '
        'dtpEstablishment
        '
        Me.dtpEstablishment.CustomFormat = "dd - MMM - yyyy"
        Me.dtpEstablishment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEstablishment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEstablishment.Location = New System.Drawing.Point(176, 56)
        Me.dtpEstablishment.MaxDate = New Date(9998, 12, 6, 0, 0, 0, 0)
        Me.dtpEstablishment.MinDate = New Date(1755, 1, 1, 0, 0, 0, 0)
        Me.dtpEstablishment.Name = "dtpEstablishment"
        Me.dtpEstablishment.Size = New System.Drawing.Size(168, 23)
        Me.dtpEstablishment.TabIndex = 112
        Me.dtpEstablishment.Value = New Date(2006, 12, 6, 0, 0, 0, 0)
        '
        'TabCA
        '
        Me.TabCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabCA.Controls.Add(Me.Panel1)
        Me.TabCA.Controls.Add(Me.Label22)
        Me.TabCA.Controls.Add(Me.dtpAccDate)
        Me.TabCA.Controls.Add(Me.Label11)
        Me.TabCA.Controls.Add(Me.txtODAmount)
        Me.TabCA.Controls.Add(Me.txtReceiptNo)
        Me.TabCA.Controls.Add(Me.txtAvailBal)
        Me.TabCA.Controls.Add(Me.Label5)
        Me.TabCA.Controls.Add(Me.cmbOpMode)
        Me.TabCA.Controls.Add(Me.Label21)
        Me.TabCA.Controls.Add(Me.cmbAccType)
        Me.TabCA.Controls.Add(Me.Label19)
        Me.TabCA.Controls.Add(Me.Label24)
        Me.TabCA.Controls.Add(Me.Label16)
        Me.TabCA.Controls.Add(Me.rdbYes)
        Me.TabCA.Controls.Add(Me.rdbNo)
        Me.TabCA.Controls.Add(Me.Label23)
        Me.TabCA.Controls.Add(Me.cmbAccStatus)
        Me.TabCA.Controls.Add(Me.Label18)
        Me.TabCA.Location = New System.Drawing.Point(4, 25)
        Me.TabCA.Name = "TabCA"
        Me.TabCA.Size = New System.Drawing.Size(776, 387)
        Me.TabCA.TabIndex = 1
        Me.TabCA.Text = "CA Detail"
        Me.TabCA.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkphotoId)
        Me.Panel1.Controls.Add(Me.chkadressId)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(416, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 104)
        Me.Panel1.TabIndex = 22
        '
        'chkphotoId
        '
        Me.chkphotoId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkphotoId.Location = New System.Drawing.Point(8, 16)
        Me.chkphotoId.Name = "chkphotoId"
        Me.chkphotoId.Size = New System.Drawing.Size(176, 32)
        Me.chkphotoId.TabIndex = 23
        Me.chkphotoId.Text = "Photo Id Proof"
        '
        'chkadressId
        '
        Me.chkadressId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkadressId.Location = New System.Drawing.Point(8, 56)
        Me.chkadressId.Name = "chkadressId"
        Me.chkadressId.Size = New System.Drawing.Size(176, 32)
        Me.chkadressId.TabIndex = 24
        Me.chkadressId.Text = "Address Proof"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(424, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 16)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "Proof :"
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpAccDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(216, 88)
        Me.dtpAccDate.MaxDate = New Date(9998, 12, 6, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(176, 23)
        Me.dtpAccDate.TabIndex = 14
        Me.dtpAccDate.Value = New Date(2006, 12, 6, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 16)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Account Opening Date : "
        '
        'txtODAmount
        '
        Me.txtODAmount.AfterDecimal = 2
        Me.txtODAmount.BeforeDecimal = 10
        Me.txtODAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtODAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtODAmount.Location = New System.Drawing.Point(216, 264)
        Me.txtODAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtODAmount.MaxValue = 0.0R
        Me.txtODAmount.MinValue = 0.0R
        Me.txtODAmount.Name = "txtODAmount"
        Me.txtODAmount.Size = New System.Drawing.Size(176, 23)
        Me.txtODAmount.TabIndex = 20
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 10
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(216, 296)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxValue = 0.0R
        Me.txtReceiptNo.MinValue = 0.0R
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(176, 23)
        Me.txtReceiptNo.TabIndex = 21
        '
        'txtAvailBal
        '
        Me.txtAvailBal.AfterDecimal = 2
        Me.txtAvailBal.BeforeDecimal = 10
        Me.txtAvailBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailBal.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAvailBal.Location = New System.Drawing.Point(216, 56)
        Me.txtAvailBal.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAvailBal.MaxValue = 0.0R
        Me.txtAvailBal.MinValue = 0.0R
        Me.txtAvailBal.Name = "txtAvailBal"
        Me.txtAvailBal.Size = New System.Drawing.Size(176, 23)
        Me.txtAvailBal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "OD Amount  Limit : "
        '
        'cmbOpMode
        '
        Me.cmbOpMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOpMode.Items.AddRange(New Object() {"Together", "Either"})
        Me.cmbOpMode.Location = New System.Drawing.Point(216, 184)
        Me.cmbOpMode.Name = "cmbOpMode"
        Me.cmbOpMode.Size = New System.Drawing.Size(176, 24)
        Me.cmbOpMode.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(40, 184)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 16)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "Operational Mode :"
        '
        'cmbAccType
        '
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(216, 152)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(176, 24)
        Me.cmbAccType.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(40, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 16)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "Type :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(40, 296)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 16)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "Receipt No :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(40, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 16)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "OD Facility :"
        '
        'rdbYes
        '
        Me.rdbYes.Checked = True
        Me.rdbYes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbYes.Location = New System.Drawing.Point(224, 224)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(72, 24)
        Me.rdbYes.TabIndex = 18
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        '
        'rdbNo
        '
        Me.rdbNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.Location = New System.Drawing.Point(296, 224)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(72, 24)
        Me.rdbNo.TabIndex = 19
        Me.rdbNo.Text = "No"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(40, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 16)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Account Status : "
        '
        'cmbAccStatus
        '
        Me.cmbAccStatus.DisplayMember = "A,S,C"
        Me.cmbAccStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccStatus.Items.AddRange(New Object() {"Active", "Suspended", "Closed"})
        Me.cmbAccStatus.Location = New System.Drawing.Point(216, 120)
        Me.cmbAccStatus.Name = "cmbAccStatus"
        Me.cmbAccStatus.Size = New System.Drawing.Size(176, 24)
        Me.cmbAccStatus.TabIndex = 15
        Me.cmbAccStatus.ValueMember = "A,S,C"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 16)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Available Balance :    "
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.txtRemarks)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(776, 387)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Others"
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(152, 296)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 255
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(480, 72)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 54
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(64, 296)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(73, 16)
        Me.Label43.TabIndex = 55
        Me.Label43.Text = "Remarks :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnLoadPhoto)
        Me.Panel4.Controls.Add(Me.btnCancelPhoto)
        Me.Panel4.Controls.Add(Me.picSignature)
        Me.Panel4.Controls.Add(Me.lblSignature)
        Me.Panel4.Controls.Add(Me.picPhoto)
        Me.Panel4.Controls.Add(Me.lblPhoto)
        Me.Panel4.Controls.Add(Me.btnCancelSign)
        Me.Panel4.Controls.Add(Me.btnLoadSign)
        Me.Panel4.Location = New System.Drawing.Point(56, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(616, 272)
        Me.Panel4.TabIndex = 0
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(104, 216)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 52
        Me.btnLoadPhoto.Text = "Load"
        Me.btnLoadPhoto.UseVisualStyleBackColor = False
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(184, 216)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 53
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(432, 16)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(160, 184)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 59
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(344, 16)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(87, 16)
        Me.lblSignature.TabIndex = 58
        Me.lblSignature.Text = "Signature : "
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(104, 16)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 184)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 57
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(32, 16)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(57, 16)
        Me.lblPhoto.TabIndex = 56
        Me.lblPhoto.Text = "Photo :"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelSign.Location = New System.Drawing.Point(512, 216)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 55
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(432, 216)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 54
        Me.btnLoadSign.Text = "Load"
        Me.btnLoadSign.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(304, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(184, 23)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "New Current Master"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(240, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(8, 256)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 3
        Me.NewButton3.Text = "Issue Cheque Book"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NewButton1)
        Me.GroupBox3.Controls.Add(Me.NewButton5)
        Me.GroupBox3.Controls.Add(Me.NewButton2)
        Me.GroupBox3.Controls.Add(Me.btnNominees)
        Me.GroupBox3.Controls.Add(Me.btnSignatoryDetail)
        Me.GroupBox3.Controls.Add(Me.NewButton3)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(8, 336)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 4
        Me.NewButton1.Text = "Day End Process"
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(8, 376)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 5
        Me.NewButton5.Text = "View Transaction Log(All)"
        Me.NewButton5.UseVisualStyleBackColor = False
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(8, 136)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(168, 40)
        Me.NewButton2.TabIndex = 0
        Me.NewButton2.Text = "Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton2.UseVisualStyleBackColor = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(8, 176)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 1
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'frmCAccCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmCAccCreation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cureent Account "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabOrganization.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabCA.ResumeLayout(False)
        Me.TabCA.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAccCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAccCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAccCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAccCreation)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region


    Private Sub btnSignatoryDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignatoryDetail.Click
        If Trim(txtAccNo.Text) <> "" And txtName.Text <> "" Then
            Dim objSignatoryDetails As New frmSignatoryDetails
            objSignatoryDetails.txtAccountNo.Text = txtAccNo.Text
            objSignatoryDetails.txtName.Text = txtName.Text
            objSignatoryDetails.ShowDialog(Me)
            objSignatoryDetails.Dispose()
        Else
            MsgBox("Enter valid account no", MsgBoxStyle.Information, "Current Account Module")
            txtAccNo.Focus()
        End If
        LoadSignatories()

    End Sub

#Region "functions"

    Function fnCheck() As Boolean
        If rdbIndividual.Checked = True Then
            If Trim(txtAccNo.Text) = "CA" Then
                MsgBox("Enter account no. ", MsgBoxStyle.Exclamation)
                txtAccNo.Focus()
                Return False
            ElseIf Trim(txtName.Text) = String.Empty Then
                MsgBox("Enter name ", MsgBoxStyle.Exclamation)
                txtName.Focus()
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
                'Else
                '    Return True
            End If
        ElseIf rdbOrganization.Checked = True Then
            If Trim(txtAccNo.Text) = "CA" Then
                MsgBox("Enter account no ", MsgBoxStyle.Exclamation)
                txtAccNo.Focus()
                Return False
            ElseIf Trim(txtName.Text) = "" Then
                MsgBox("Enter organization name ", MsgBoxStyle.Exclamation)
                txtName.Focus()
                Return False
            ElseIf Trim(cmborgtype.Text) = "" Then
                MsgBox("Enter type of firm ", MsgBoxStyle.Exclamation)
                cmborgtype.Focus()
                Return False
            ElseIf Trim(txtBusiness.Text) = "" Then
                MsgBox("Enter nature of business ", MsgBoxStyle.Exclamation)
                txtBusiness.Focus()
                Return False
            ElseIf Trim(txtKSTNo.Text) = "" Then
                MsgBox("Enter KST number", MsgBoxStyle.Exclamation)
                txtKSTNo.Focus()
                Return False
            ElseIf Trim(txtCSTNo.Text) = "" Then
                MsgBox("Enter CST number", MsgBoxStyle.Exclamation)
                txtCSTNo.Focus()
                Return False
            ElseIf Trim(txtRegNo.Text) = "" Then
                MsgBox("Enter registration number", MsgBoxStyle.Exclamation)
                txtRegNo.Focus()
                Return False
            ElseIf Trim(txtAddress.Text) = "" Then
                MsgBox("Enter address ", MsgBoxStyle.Exclamation)
                txtAddress.Focus()
                Return False
            End If
        End If

        If Trim(txtAvailBal.Text) = String.Empty Then
            MsgBox("Enter available balance", MsgBoxStyle.Exclamation)
            TabControl1.SelectedIndex = 2
            txtAvailBal.Focus()
            Return False
        ElseIf Trim(cmbAccType.SelectedItem) = "" Then
            MsgBox("Select account type", MsgBoxStyle.Exclamation)
            TabControl1.SelectedIndex = 2
            cmbAccType.Focus()
            Return False
        ElseIf cmbAccType.SelectedItem = "Joint" Then
            If Trim(cmbOpMode.SelectedItem) = "" Then
                MsgBox("Select account operation mode", MsgBoxStyle.Exclamation)
                TabControl1.SelectedIndex = 2
                cmbOpMode.Focus()
                Return False
            End If
            ElseIf Trim(txtODAmount.Text) = "" Then
                MsgBox("Enter overdraw amount", MsgBoxStyle.Exclamation)
                TabControl1.SelectedIndex = 2
                txtODAmount.Focus()
                Return False
            ElseIf Trim(txtReceiptNo.Text) = "" Then
                MsgBox("Enter recipt number", MsgBoxStyle.Exclamation)
                TabControl1.SelectedIndex = 2
                txtReceiptNo.Focus()
                Return False
            Else
                Return True
            End If
    End Function

    Sub Clear()
        'txtAccNo.ResetText()
        txtName.ResetText()
        txtAddress.ResetText()
        txtAvailBal.ResetText()
        txtBusiness.ResetText()
        txtFirstSignature.ResetText()
        txtSecondSignature.ResetText()
        txtManSignature.ResetText()
        txtODAmount.ResetText()
        txtPhoneNo1.ResetText()
        txtPhoneNo2.ResetText()
        txtMobileNo2.ResetText()
        txtKSTNo.ResetText()
        txtCSTNo.ResetText()
        txtRegNo.ResetText()
        lngOrganizationNo = 0
        txtReceiptNo.ResetText()

        lngPersonNo = 0
        txtAccNo.ReadOnly = False
        Panel7.Enabled = True

        txtCustomerID.Text = "CID"
        txtCustomerID.ResetText()
        txtCustomerID.Enabled = False
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpAccDate.ResetText()
        dtpAccDate.Enabled = True
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
        txtEducation.ResetText()
        txtOffAddress.ResetText()
        txtAvailBal.ResetText()
        txtAvailBal.Enabled = True
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtRemarks.ResetText()
        btnMemSearch.Enabled = True
        txtAccNo.ReadOnly = False
        btnMemSearch.Enabled = True

    End Sub

    Function fnSetData() As Boolean

        If rdbIndividual.Checked = True Then
            '''Person Deatils
            If lngPersonNo <> 0 Then
                objCA.PersonNo = lngPersonNo
            Else
                objCA.PersonNo = objCA.fnGetNewPersonNo()
            End If
            objCA.CAType = "I"
            objCA.Name = txtName.Text
            objCA.FatherName = txtFatherName.Text
            objCA.PermAddress = txtPermAddress.Text
            objCA.PresAddress = txtPresAddress.Text
            objCA.PhoneNo = txtPhoneNo.Text
            objCA.MobileNo = txtMobileNo.Text
            objCA.DOB = dtpDOB.Value
            objCA.Age = txtAge.Text
            objCA.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
            objCA.Gender = IIf(rdbMale.Checked = True, "M", "F")
            objCA.ReligionCode = cmbReligion.SelectedValue
            objCA.CasteCode = cmbCaste.SelectedValue
            objCA.OccupationCode = cmbOccupation.SelectedValue
            ' objCA.Photo = fnGetPhoto()
            objCA.Photo = picPhoto.ImageLocation

            'objCA.Sign = fnGetSign()
            objCA.Sign = picSignature.ImageLocation

            objCA.Education = txtEducation.Text
            objCA.OffAddress = txtOffAddress.Text
            objCA.CustomerID = txtCustomerID.Text
        ElseIf rdbOrganization.Checked = True Then
            '''Organization Detail
            If lngOrganizationNo <> 0 Then
                objCA.OrganizationNo = lngOrganizationNo
            Else
                objCA.OrganizationNo = objCA.fnGetNewOrganizationNo()
            End If
            objCA.CAType = "O"
            objCA.CustomerID = txtCustomerID.Text

            objCA.OrganizationName = txtName.Text
            objCA.OrganizationType = cmborgtype.SelectedItem
            objCA.YearOfEstablishment = dtpEstablishment.Value
            objCA.NatureOfBusiness = txtBusiness.Text
            objCA.KSTNo = txtKSTNo.Text
            objCA.CSTNo = txtCSTNo.Text
            objCA.RegNo = txtRegNo.Text
            objCA.RegDate = dtpRegDate.Value
            objCA.Address = txtAddress.Text
            objCA.PhoneNo1 = txtPhoneNo1.Text
            objCA.PhoneNo2 = txtPhoneNo2.Text
            objCA.OrgMobileNo = txtMobileNo2.Text
            objCA.ManDtaSignature = txtManSignature.Text
            objCA.FirstAuxSignature = txtFirstSignature.Text
            objCA.SecodAuxSignature = txtSecondSignature.Text
            objCA.PDeedDate = dtpPDeedDate.Value
            objCA.ResolutationDate = dtpResolutionDate.Value

        End If

        ''Current Account Detail
        objCA.CurAccountNo = txtAccNo.Text
        objCA.Accdate = dtpAccDate.Value
        objCA.AccBal = txtAvailBal.Text
        objCA.ODAMount = txtODAmount.Text
        objCA.ODFacility = IIf(rdbYes.Checked = True, "Y", "N")
        objCA.Receipts = txtReceiptNo.Text
        objCA.AddressID = IIf(chkadressId.Checked = True, "Y", "N")
        objCA.PhotoID = IIf(chkphotoId.Checked = True, "Y", "N")
        objCA.Remarks = txtRemarks.Text
        Select Case cmbAccStatus.SelectedItem
            Case "Active"
                objCA.AccStatus = "A"
            Case "Suspended"
                objCA.AccStatus = "S"
            Case "Closed"
                objCA.AccStatus = "C"
        End Select
        Select Case cmbAccType.SelectedItem
            Case "Single"
                objCA.AccType = "S"
            Case "Joint"
                objCA.AccType = "J"
        End Select
        Select Case cmbOpMode.SelectedItem
            Case ""
                objCA.OpMode = "E"
            Case "Together"
                objCA.OpMode = "T"
            Case "Either"
                objCA.OpMode = "E"
        End Select
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
                        ' msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        ' msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        ' picPhoto.Image = Image.FromStream(msStream)

                        picPhoto.Image = Image.FromFile(objDT.Rows(0).Item("Photo"))
                        picPhoto.ImageLocation = objDT.Rows(0).Item("Photo")



                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        ' msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        ' msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        ' picSignature.Image = Image.FromStream(msStream)

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


    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Current Account Existance
        If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objCA.fnAddCAccount(objTrans) Then
                fnGenerateVoucher(objTrans)
                'Log Entry
                fnLogEntry(pbUserId, "New current account created" & txtAccNo.Text, Date.Now, "New current account", objTrans)
                MessageBox.Show("New current account created successfully.", "CA Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New Current Account Creation Failed, because of Internal Error.", "CA Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objCA.fnUpdateCAccount(objTrans) Then
                fnLogEntry(pbUserId, "Current account updated" & txtAccNo.Text, Date.Now, "Update current account", objTrans)
                MessageBox.Show("Current account updated successfully.", "CA Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Current account updation failed, because of internal error.", "CA Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        End If
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpAccDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        objCA.fnCAtransactionEnter(Trim(txtAccNo.Text), dtpAccDate.Value, "By new current account  " & txtAccNo.Text, Trim(txtAvailBal.Text), 0, Trim(txtAvailBal.Text), 0, Trim(txtAvailBal.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReceiptNo.Text, dtpAccDate.Value, txtAvailBal.Text, "By new current account" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpAccDate.Value, "By current account " & txtAccNo.Text, "To", 11, 0, Val(txtAvailBal.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpAccDate.Value, "By current account " & txtAccNo.Text, "By", 1, Val(txtAvailBal.Text), 0, 2, "Y", objTrans)

        Return True

    End Function


#End Region

#Region "Event"



    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()

        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then

                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        If MsgBox("You want to add another account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
                            btnAdd_Click(sender, e)
                        Else
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()
        End Try
       
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        nMode = CTAdd
        txtAccNo.Text = "CA"
        Clear()

        Dim Temp As String
        Dim TempNewNo As String = Mid(objCA.fnGetNewCANo, 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "CA" & String.Format("{0:00000}", CInt(TempNewNo))
            txtAccNo.Text = Temp
            txtAccNo.Focus()
        Else
            MsgBox("Cuerrent account number exceeds the maximum alloted number", MsgBoxStyle.Information, "CA Module")
        End If
        If rdbIndividual.Checked = True Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If
        txtAccNo.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objCAccSearch As New frmCAccSearch
        objCAccSearch.strCAccountNo = String.Empty
        objCAccSearch.ShowDialog(Me)
        If objCAccSearch.strCAccountNo <> String.Empty Then
            txtAccNo.Text = objCAccSearch.strCAccountNo
            CALoadCAccDetails()
        End If
        objCAccSearch.Dispose()
    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        If txtAccNo.Text <> "CA" Then
            If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) = True Then
                If MsgBox("Account no. already exists do you want to update", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CALoadCAccDetails()
                Else
                    btnAdd_Click(sender, e)
                    txtAccNo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub frmCAccCreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAvailBal.ContextMenu = New ContextMenu
        cmbAccStatus.SelectedIndex = 0
        cmbAccType.SelectedText = "Single"
        dtpEstablishment.MaxDate = Date.Now
        dtpAccDate.MaxDate = Date.Now
        dtpResolutionDate.Value = Date.Now
        dtpEstablishment.Value = Date.Now
        dtpPDeedDate.Value = Date.Now
        dtpRegDate.Value = Date.Now
        dtpResolutionDate.Value = Date.Now

        sbLoadControlValues() 'Load Values 

        txtAccNo.Focus()
        Panel6.Enabled = False

        If txtAccNo.Text <> "CA" Then
            CALoadCAccDetails()
        Else
            'CAClear()
            btnAdd_Click(sender, e)
        End If

        ' Panel2.Enabled = False
        ' Panel4.Enabled = False
    End Sub

#End Region

#Region "GeneralSubRotine"

    Sub LoadSignatories()
        Dim objSignDt As DataTable
        Dim strStatus As String
        Dim intCount As Integer
        If objSign.fnGetSignatories(txtAccNo.Text) Then
            objSignDt = objSign.SignatoryTable
            While intCount < objSignDt.Rows.Count
                strStatus = objSignDt.Rows(intCount).Item("SignatoryStatus")
                Select Case strStatus
                    Case "Mandatory"
                        txtManSignature.Text = objSignDt.Rows(intCount).Item("SignName")
                    Case "First Signatory"
                        txtFirstSignature.Text = objSignDt.Rows(intCount).Item("SignName")
                    Case "Second Signatory"
                        txtSecondSignature.Text = objSignDt.Rows(intCount).Item("SignName")
                End Select
                intCount += 1
            End While
        End If
    End Sub
    Sub CALoadCAccDetails()
        Dim objDT As DataTable
        Dim objType As DataTable
        Dim msStream As MemoryStream
        Clear()
        Try
            If objCA.fnGetCAType(txtAccNo.Text) Then

                objType = objCA.CAAccTable
                If objType.Rows(0).Item("CAType") = "I" Then
                    rdbIndividual.Checked = True
                    TabControl1.SelectedIndex = 0
                    If objCA.fnGetIndCAccountDetails(txtAccNo.Text) Then
                        objDT = objCA.CAInfoTable
                        lngPersonNo = objDT.Rows(0).Item("PersonNo")
                        txtAccNo.ReadOnly = True
                        txtCustomerID.ReadOnly = True
                        btnMemSearch.Enabled = False
                        txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
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
                        txtOffAddress.Text = objDT.Rows(0).Item("OfficeAddress")
                        txtEducation.Text = objDT.Rows(0).Item("Education")

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

                ElseIf objType.Rows(0).Item("CAType") = "O" Then
                    rdbOrganization.Checked = True

                    TabControl1.SelectedIndex = 1
                    If objCA.fnGetOrgCAccountDetails(txtAccNo.Text) Then
                        objDT = objCA.CAInfoTable

                        'Organization Details
                        lngOrganizationNo = objDT.Rows(0).Item("OrgNo")
                        cmborgtype.SelectedItem = objDT.Rows(0).Item("OrgType")
                        dtpEstablishment.Value = CDate(objDT.Rows(0).Item("YearOfEstab"))
                        txtBusiness.Text = objDT.Rows(0).Item("NatureOfBusiness")
                        txtKSTNo.Text = objDT.Rows(0).Item("KSTNo")
                        txtCSTNo.Text = objDT.Rows(0).Item("CSTNo")
                        txtRegNo.Text = objDT.Rows(0).Item("RegNo")
                        dtpRegDate.Value = CDate(objDT.Rows(0).Item("RegDate"))
                        txtAddress.Text = objDT.Rows(0).Item("Address")
                        txtPhoneNo1.Text = objDT.Rows(0).Item("PhoneNo1")
                        txtPhoneNo2.Text = objDT.Rows(0).Item("PhoneNo2")
                        txtMobileNo2.Text = objDT.Rows(0).Item("MobileNo")
                        dtpPDeedDate.Value = CDate(objDT.Rows(0).Item("PDeedDated"))
                        dtpResolutionDate.Value = CDate(objDT.Rows(0).Item("ResolutationDated"))
                        LoadSignatories()

                    End If

                End If

                'CA Details
                txtName.Text = objDT.Rows(0).Item("Name")
                txtAccNo.Text = objDT.Rows(0).Item("CAccountNo")
                txtAccNo.ReadOnly = True
                dtpAccDate.Value = CDate(objDT.Rows(0).Item("AccDate"))
                dtpAccDate.Enabled = False
                txtAvailBal.Text = objDT.Rows(0).Item("AvailBalance")
                txtAvailBal.Enabled = False
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
                Select Case objDT.Rows(0).Item("AccStatus")
                    Case "A"
                        cmbAccStatus.SelectedItem = "Active"
                    Case "S"
                        cmbAccStatus.SelectedItem = "Suspended"
                    Case "C"
                        cmbAccStatus.SelectedItem = "Closed"
                End Select
                Select Case objDT.Rows(0).Item("Address_Id")
                    Case "Y"
                        chkadressId.Checked = True
                    Case "N"
                        chkadressId.Checked = False
                End Select

                Select Case objDT.Rows(0).Item("Photo_Id")
                    Case "Y"
                        chkphotoId.Checked = True
                    Case "N"
                        chkphotoId.Checked = False
                End Select

                Select Case objDT.Rows(0).Item("ODFacility")
                    Case "Y"
                        rdbYes.Checked = True
                    Case "N"
                        rdbNo.Checked = True
                End Select
                txtODAmount.Text = objDT.Rows(0).Item("ODLimit")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                txtReceiptNo.Text = IIf(IsDBNull(objDT.Rows(0).Item("ReciptNo")) = True, "", objDT.Rows(0).Item("ReciptNo"))
                Panel7.Enabled = False
            End If
            txtName.Focus()
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) Then
            Dim objcachequebookissue As New frmCAchequeBookIssue
            objcachequebookissue.strCAno = txtAccNo.Text
            objcachequebookissue.txtName.Text = txtName.Text
            objcachequebookissue.ShowDialog(Me)
        Else
            MsgBox("Account Number Dosent Exist")
        End If
    End Sub

#Region "Key Events"
    Private Sub txtPhoneNo2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 1
        End If
    End Sub
#End Region

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

    Private Sub btnNewMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMember.Click
        Dim objCustomer As New frmCustomer
        objCustomer = frmCustomer.DefInstance
        objCustomer.MdiParent = Me.MdiParent
        objCustomer.BringToFront()
        objCustomer.Show()
        objCustomer = Nothing

    End Sub

    Private Sub rdbIndividual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbIndividual.CheckedChanged
        If rdbIndividual.Checked = True Then
            Panel2.Enabled = True
            Panel4.Enabled = True
            TabControl1.SelectedIndex = 0
        Else
            Panel2.Enabled = False
            Panel4.Enabled = False
        End If
    End Sub

    Private Sub rdbOrganization_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbOrganization.CheckedChanged
        If rdbOrganization.Checked = True Then
            Panel6.Enabled = True
            TabControl1.SelectedIndex = 1
        Else
            Panel6.Enabled = False
        End If
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If Trim(txtAccNo.Text) <> "" And txtName.Text <> "" Then
            If cmbAccType.SelectedItem = "Joint" Then
                Dim objJointHolders As New frmNominees
                objJointHolders.txtAccountNo.Text = txtAccNo.Text
                objJointHolders.chrType = "J"
                objJointHolders.Text = "Current Account Joint-Holders For Account No  " & txtAccNo.Text
                objJointHolders.txtName.Text = txtName.Text
                objJointHolders.ShowDialog(Me)
                objJointHolders.Dispose()
            Else
                MsgBox("Account type is not joint", MsgBoxStyle.Information, "CA Module")
            End If
        Else
            MsgBox("Enter account no. and name", MsgBoxStyle.Information, "CA Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtAccNo.Text) <> "" And txtName.Text <> "" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtAccNo.Text
            objNominees.txtAddress.Text = txtPermAddress.Text
            objNominees.chrType = "N"

            objNominees.Text = "Current Account Nominees For Account No  " & txtAccNo.Text
            objNominees.txtName.Text = txtName.Text
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Enter account no. and name", MsgBoxStyle.Information, "CA Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) Then
            Dim objfrmAccountStmt As New frmCAStmt
            objfrmAccountStmt.txtAccno.Text = Me.txtAccNo.Text
            objfrmAccountStmt.txtName.Text = Me.txtName.Text
            objfrmAccountStmt.txtAccno.ReadOnly = True
            objfrmAccountStmt.txtName.ReadOnly = True
            objfrmAccountStmt.btnSearch.Enabled = False
            objfrmAccountStmt.ShowDialog(Me)
        Else
            MsgBox("Account number dosent exist ", MsgBoxStyle.Information, "CA Module")
            txtAccNo.Focus()
        End If
    End Sub
    Private Sub txtOffAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOffAddress.KeyDown

        If e.KeyData = Keys.Enter Then
            If rdbOrganization.Checked = True Then
                TabControl1.SelectedIndex = 1
                cmborgtype.Focus()
            Else
                TabControl1.SelectedIndex = 2
                txtAvailBal.Focus()
            End If
        End If
    End Sub

    Private Sub txtMobileNo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo2.KeyDown
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 2
            txtAvailBal.Focus()
        End If
    End Sub

    Private Sub chkadressId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkadressId.KeyDown
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 3
            btnLoadPhoto.Focus()
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub dtpDOB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub
    Private Sub txtAe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged
        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If
    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        txtPermAddress_TextChanged(sender, e)
    End Sub
    Private Sub txtPermAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermAddress.TextChanged
        If chkSame.Checked = True Then
            txtPresAddress.Text = txtPermAddress.Text
        End If
    End Sub

    Private Sub txtAccNo_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        If txtAccNo.Text <> "CA" Then
            If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) = True Then
                If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    txtName.Focus()
                    CALoadCAccDetails()
                Else
                    btnAdd_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.TextChanged
        If txtAccNo.Text.StartsWith("CA") = False Then
            txtAccNo.Undo()
            txtAccNo.ClearUndo()
        End If
    End Sub

    Private Sub frmCAccCreation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F3 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        'Dim objfrmDayEnd As New frmDDayEnd
        'objfrmDayEnd.ShowDialog(Me)
    End Sub

    Private Sub cmbAccType_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccType.TextChanged
        If (cmbAccType.Text = "Single") Then
            cmbOpMode.Visible = False
            Label21.Visible = False
        End If
        If (cmbAccType.Text = "Joint") Then
            cmbOpMode.Visible = True
            Label21.Visible = True
        End If
    End Sub

    Private Sub cmbAccType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnLoadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPhoto.Click

    End Sub
End Class
