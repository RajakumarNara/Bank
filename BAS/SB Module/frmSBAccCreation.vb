#Region "Import Statements"
Imports System.IO
#End Region

Public Class frmSBAccCreation
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objSBAccount As New clsSavingsBank
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSBAccDetails As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAvailBal As BankControls.NumericControl
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkphotoId As System.Windows.Forms.CheckBox
    Friend WithEvents chkSdressId As System.Windows.Forms.CheckBox
    Friend WithEvents cmbOpMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbAccStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnChqStopPay As BankControls.NewButton
    Friend WithEvents btnStopChqDet As BankControls.NewButton
    Friend WithEvents btnNewMember As BankControls.NewButton
    Friend WithEvents txtEducation As BankControls.TextControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtOffAddress As BankControls.TextControl
    Friend WithEvents txtIntroAccNo As BankControls.TextControl
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents txtOfficeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSBAccCreation))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.txtOfficeNo = New BankControls.NumericControl
        Me.txtCustomerID = New BankControls.TextControl
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtOffAddress = New BankControls.TextControl
        Me.txtEducation = New BankControls.TextControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.btnNewMember = New BankControls.NewButton
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
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbSBAccDetails = New System.Windows.Forms.TabPage
        Me.NewButton1 = New BankControls.NewButton
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.txtIntroAccNo = New BankControls.TextControl
        Me.Label24 = New System.Windows.Forms.Label
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkphotoId = New System.Windows.Forms.CheckBox
        Me.chkSdressId = New System.Windows.Forms.CheckBox
        Me.txtAvailBal = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbOpMode = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbAccStatus = New System.Windows.Forms.ComboBox
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
        Me.NewButton3 = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.NewButton6 = New BankControls.NewButton
        Me.btnStopChqDet = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnChqStopPay = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbSBAccDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(24, 120)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 424)
        Me.TabControl1.TabIndex = 3
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPersonal.Controls.Add(Me.txtOfficeNo)
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Controls.Add(Me.Label33)
        Me.tbPersonal.Controls.Add(Me.Label28)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.txtOffAddress)
        Me.tbPersonal.Controls.Add(Me.txtEducation)
        Me.tbPersonal.Controls.Add(Me.Label38)
        Me.tbPersonal.Controls.Add(Me.btnNewMember)
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
        Me.tbPersonal.Controls.Add(Me.btnMemSearch)
        Me.tbPersonal.Controls.Add(Me.Label1)
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(728, 395)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'txtOfficeNo
        '
        Me.txtOfficeNo.AfterDecimal = 0
        Me.txtOfficeNo.BeforeDecimal = 20
        Me.txtOfficeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeNo.Location = New System.Drawing.Point(496, 352)
        Me.txtOfficeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeNo.MaxLength = 20
        Me.txtOfficeNo.MaxValue = 0
        Me.txtOfficeNo.MinValue = 0
        Me.txtOfficeNo.Name = "txtOfficeNo"
        Me.txtOfficeNo.Size = New System.Drawing.Size(184, 22)
        Me.txtOfficeNo.TabIndex = 18
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(144, 32)
        Me.txtCustomerID.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(128, 22)
        Me.txtCustomerID.SpecialChar = True
        Me.txtCustomerID.TabIndex = 0
        Me.txtCustomerID.TabStop = False
        Me.txtCustomerID.Text = "CID"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(352, 352)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 14)
        Me.Label33.TabIndex = 77
        Me.Label33.Text = "Office No :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(32, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(111, 14)
        Me.Label28.TabIndex = 72
        Me.Label28.Text = "Husband Name  "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(352, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 14)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Office Address :"
        '
        'txtOffAddress
        '
        Me.txtOffAddress.AlphaNumeric = True
        Me.txtOffAddress.BlankSpace = True
        Me.txtOffAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOffAddress.Location = New System.Drawing.Point(496, 280)
        Me.txtOffAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOffAddress.Mandatory = False
        Me.txtOffAddress.MaxLength = 255
        Me.txtOffAddress.Multiline = True
        Me.txtOffAddress.Name = "txtOffAddress"
        Me.txtOffAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtOffAddress.SpecialChar = True
        Me.txtOffAddress.TabIndex = 17
        '
        'txtEducation
        '
        Me.txtEducation.AlphaNumeric = True
        Me.txtEducation.BlankSpace = False
        Me.txtEducation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEducation.Location = New System.Drawing.Point(144, 328)
        Me.txtEducation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEducation.Mandatory = False
        Me.txtEducation.MaxLength = 50
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(168, 23)
        Me.txtEducation.SpecialChar = True
        Me.txtEducation.TabIndex = 10
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(32, 328)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(82, 14)
        Me.Label38.TabIndex = 69
        Me.Label38.Text = "Education : "
        '
        'btnNewMember
        '
        Me.btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMember.ForeColor = System.Drawing.Color.Black
        Me.btnNewMember.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewMember.Image = CType(resources.GetObject("btnNewMember.Image"), System.Drawing.Image)
        Me.btnNewMember.Location = New System.Drawing.Point(312, 32)
        Me.btnNewMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(32, 24)
        Me.btnNewMember.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Location = New System.Drawing.Point(144, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
        Me.Panel2.TabIndex = 7
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
        Me.rdbFemale.Text = "Female"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbMajor)
        Me.Panel3.Controls.Add(Me.rdbMinor)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(144, 184)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 32)
        Me.Panel3.TabIndex = 6
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
        Me.rdbMinor.Text = "Minor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 14)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Age Status :  "
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.BlankSpace = False
        Me.txtFatherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(144, 72)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 255
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 22)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 3
        '
        'chkSame
        '
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(496, 88)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(216, 24)
        Me.chkSame.TabIndex = 12
        Me.chkSame.Text = "same as permanent address"
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(144, 296)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 9
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(144, 264)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 14)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Present Address : "
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd -MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(144, 120)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 22)
        Me.dtpDOB.TabIndex = 4
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father Name /"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date of Birth :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(352, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(352, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 14)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Permanent Address : "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(496, 248)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 16
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(352, 184)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 14)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No : "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(352, 216)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 14)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Mobile No : "
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(144, 152)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 22)
        Me.txtAge.TabIndex = 5
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(496, 112)
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
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(496, 184)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxLength = 20
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 22)
        Me.txtPhoneNo.TabIndex = 14
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 20
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(496, 216)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 20
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 22)
        Me.txtMobileNo.TabIndex = 15
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.BlankSpace = False
        Me.txtPermAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(496, 24)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 255
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 11
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(280, 32)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustomerID :"
        '
        'tbSBAccDetails
        '
        Me.tbSBAccDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tbSBAccDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSBAccDetails.Controls.Add(Me.NewButton1)
        Me.tbSBAccDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbSBAccDetails.Controls.Add(Me.txtIntroAccNo)
        Me.tbSBAccDetails.Controls.Add(Me.Label24)
        Me.tbSBAccDetails.Controls.Add(Me.dtpAccDate)
        Me.tbSBAccDetails.Controls.Add(Me.Label11)
        Me.tbSBAccDetails.Controls.Add(Me.cmbAccType)
        Me.tbSBAccDetails.Controls.Add(Me.Panel1)
        Me.tbSBAccDetails.Controls.Add(Me.txtAvailBal)
        Me.tbSBAccDetails.Controls.Add(Me.Label18)
        Me.tbSBAccDetails.Controls.Add(Me.Label19)
        Me.tbSBAccDetails.Controls.Add(Me.Label20)
        Me.tbSBAccDetails.Controls.Add(Me.Label21)
        Me.tbSBAccDetails.Controls.Add(Me.Label22)
        Me.tbSBAccDetails.Controls.Add(Me.cmbOpMode)
        Me.tbSBAccDetails.Controls.Add(Me.Label23)
        Me.tbSBAccDetails.Controls.Add(Me.cmbAccStatus)
        Me.tbSBAccDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbSBAccDetails.Name = "tbSBAccDetails"
        Me.tbSBAccDetails.Size = New System.Drawing.Size(728, 395)
        Me.tbSBAccDetails.TabIndex = 3
        Me.tbSBAccDetails.Text = "SB Account Details"
        '
        'NewButton1
        '
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(360, 155)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(24, 24)
        Me.NewButton1.TabIndex = 22
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 10
        Me.txtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(216, 221)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(168, 22)
        Me.txtReceiptNo.TabIndex = 25
        '
        'txtIntroAccNo
        '
        Me.txtIntroAccNo.AlphaNumeric = True
        Me.txtIntroAccNo.BackColor = System.Drawing.Color.White
        Me.txtIntroAccNo.BlankSpace = False
        Me.txtIntroAccNo.Enabled = False
        Me.txtIntroAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIntroAccNo.GotFocusColour = System.Drawing.Color.White
        Me.txtIntroAccNo.Location = New System.Drawing.Point(216, 155)
        Me.txtIntroAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtIntroAccNo.Mandatory = False
        Me.txtIntroAccNo.MaxLength = 10
        Me.txtIntroAccNo.Name = "txtIntroAccNo"
        Me.txtIntroAccNo.ReadOnly = True
        Me.txtIntroAccNo.Size = New System.Drawing.Size(136, 22)
        Me.txtIntroAccNo.SpecialChar = True
        Me.txtIntroAccNo.TabIndex = 23
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(32, 221)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 14)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Receipt No : "
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpAccDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(216, 56)
        Me.dtpAccDate.MaxDate = New Date(2012, 12, 6, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(168, 22)
        Me.dtpAccDate.TabIndex = 19
        Me.dtpAccDate.Value = New Date(1976, 1, 1, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 14)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Account Opening Date :"
        '
        'cmbAccType
        '
        Me.cmbAccType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(216, 120)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccType.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkphotoId)
        Me.Panel1.Controls.Add(Me.chkSdressId)
        Me.Panel1.Location = New System.Drawing.Point(216, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 104)
        Me.Panel1.TabIndex = 25
        '
        'chkphotoId
        '
        Me.chkphotoId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkphotoId.Location = New System.Drawing.Point(8, 16)
        Me.chkphotoId.Name = "chkphotoId"
        Me.chkphotoId.Size = New System.Drawing.Size(176, 32)
        Me.chkphotoId.TabIndex = 0
        Me.chkphotoId.Text = "Photo Id Proof"
        '
        'chkSdressId
        '
        Me.chkSdressId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSdressId.Location = New System.Drawing.Point(8, 56)
        Me.chkSdressId.Name = "chkSdressId"
        Me.chkSdressId.Size = New System.Drawing.Size(176, 32)
        Me.chkSdressId.TabIndex = 1
        Me.chkSdressId.Text = "Address Proof"
        '
        'txtAvailBal
        '
        Me.txtAvailBal.AfterDecimal = 2
        Me.txtAvailBal.BeforeDecimal = 10
        Me.txtAvailBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAvailBal.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAvailBal.Location = New System.Drawing.Point(216, 88)
        Me.txtAvailBal.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAvailBal.MaxValue = 0
        Me.txtAvailBal.MinValue = 0
        Me.txtAvailBal.Name = "txtAvailBal"
        Me.txtAvailBal.Size = New System.Drawing.Size(168, 22)
        Me.txtAvailBal.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(129, 14)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Available Balance : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 14)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Type : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(32, 155)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(187, 14)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Introducer Membership No : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(390, 126)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 14)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Operational Mode : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(164, 253)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 16)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Proof :"
        '
        'cmbOpMode
        '
        Me.cmbOpMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbOpMode.Items.AddRange(New Object() {"Together", "Either"})
        Me.cmbOpMode.Location = New System.Drawing.Point(523, 120)
        Me.cmbOpMode.Name = "cmbOpMode"
        Me.cmbOpMode.Size = New System.Drawing.Size(168, 24)
        Me.cmbOpMode.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(32, 187)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 14)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Account Status :  "
        '
        'cmbAccStatus
        '
        Me.cmbAccStatus.DisplayMember = "A,S,C"
        Me.cmbAccStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbAccStatus.Items.AddRange(New Object() {"Active", "Suspended", "Closed"})
        Me.cmbAccStatus.Location = New System.Drawing.Point(216, 187)
        Me.cmbAccStatus.Name = "cmbAccStatus"
        Me.cmbAccStatus.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccStatus.TabIndex = 24
        Me.cmbAccStatus.ValueMember = "A,S,C"
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.tbOthers.Size = New System.Drawing.Size(728, 395)
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
        Me.txtRemarks.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(64, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Remarks :"
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
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 232)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 25
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
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 232)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.lblSignature.Location = New System.Drawing.Point(368, 32)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(87, 16)
        Me.lblSignature.TabIndex = 50
        Me.lblSignature.Text = "Signature : "
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
        Me.lblPhoto.Location = New System.Drawing.Point(80, 36)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(57, 16)
        Me.lblPhoto.TabIndex = 48
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
        Me.btnCancelSign.Location = New System.Drawing.Point(536, 232)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 28
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
        Me.btnLoadSign.Location = New System.Drawing.Point(456, 232)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtName.Location = New System.Drawing.Point(464, 64)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 255
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name : "
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
        Me.NewButton2.Location = New System.Drawing.Point(16, 168)
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
        Me.btnNominees.Location = New System.Drawing.Point(16, 208)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 1
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
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
        Me.NewButton3.Location = New System.Drawing.Point(16, 248)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 2
        Me.NewButton3.Text = "Issue Cheque Book"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
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
        Me.NewButton5.Location = New System.Drawing.Point(16, 320)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 5
        Me.NewButton5.Text = "View Transaction Log(All)"
        Me.NewButton5.UseVisualStyleBackColor = False
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton6.Location = New System.Drawing.Point(16, 440)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(168, 40)
        Me.NewButton6.TabIndex = 6
        Me.NewButton6.Text = "View Transaction Log(Cheque)"
        Me.NewButton6.UseVisualStyleBackColor = False
        Me.NewButton6.Visible = False
        '
        'btnStopChqDet
        '
        Me.btnStopChqDet.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnStopChqDet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopChqDet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopChqDet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopChqDet.ForeColor = System.Drawing.Color.Black
        Me.btnStopChqDet.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStopChqDet.Location = New System.Drawing.Point(16, 360)
        Me.btnStopChqDet.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnStopChqDet.Name = "btnStopChqDet"
        Me.btnStopChqDet.Size = New System.Drawing.Size(168, 40)
        Me.btnStopChqDet.TabIndex = 7
        Me.btnStopChqDet.Text = "View Stopped Cheque Details"
        Me.btnStopChqDet.UseVisualStyleBackColor = False
        Me.btnStopChqDet.Visible = False
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
        Me.btnOk.TabIndex = 3
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
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Account No : "
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(160, 64)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 7
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 0
        Me.txtAccNo.Text = "SB"
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
        Me.btnSearch.Location = New System.Drawing.Point(296, 64)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.NewButton6)
        Me.GroupBox1.Controls.Add(Me.btnStopChqDet)
        Me.GroupBox1.Controls.Add(Me.btnChqStopPay)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'btnChqStopPay
        '
        Me.btnChqStopPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnChqStopPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChqStopPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChqStopPay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChqStopPay.ForeColor = System.Drawing.Color.Black
        Me.btnChqStopPay.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChqStopPay.Location = New System.Drawing.Point(16, 400)
        Me.btnChqStopPay.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnChqStopPay.Name = "btnChqStopPay"
        Me.btnChqStopPay.Size = New System.Drawing.Size(168, 40)
        Me.btnChqStopPay.TabIndex = 7
        Me.btnChqStopPay.Text = "Cheque Stop Pay"
        Me.btnChqStopPay.UseVisualStyleBackColor = False
        Me.btnChqStopPay.Visible = False
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
        Me.btnAdd.TabIndex = 5
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
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(88, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(215, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Savings Account Master"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'frmSBAccCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmSBAccCreation"
        Me.ShowInTaskbar = False
        Me.Text = "SB Account "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbSBAccDetails.ResumeLayout(False)
        Me.tbSBAccDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
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

    Private Shared m_FormDefInstance As frmSBAccCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBAccCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBAccCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBAccCreation)
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
        If Trim(txtAccNo.Text) = "SB" Then
            MsgBox("Enter account no ", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf txtCustomerID.Text = "CID" Then
            MsgBox("Enter customer ID ")
            txtCustomerID.Focus()
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
        ElseIf Trim(txtAvailBal.Text) = String.Empty Then
            MsgBox("Enter available balance", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            txtAvailBal.Focus()
            Return False
        ElseIf Trim(cmbAccType.SelectedItem) = String.Empty Then
            MsgBox("Enter acces type", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            cmbAccType.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = String.Empty Then
            MsgBox("Enter receipt number", MsgBoxStyle.Exclamation)
            Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            txtReceiptNo.Focus()
            Return False
        ElseIf dtpDOB.Value > dtpAccDate.Value Then
            MsgBox("Check date of birth and account opeaning date", MsgBoxStyle.Information)
            Return False
        ElseIf cmbAccType.Text = "Joint" Then
            If Trim(cmbOpMode.SelectedItem) = String.Empty Then
                MsgBox("Enter operation mode", MsgBoxStyle.Exclamation)
                Me.TabControl1.SelectedTab = Me.tbSBAccDetails
                cmbOpMode.Focus()
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
        If objSBAccount.fnCheckSBAccount(Trim(txtAccNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objSBAccount.fnAddSBAccount(objTrans) Then
                fnGenerateVoucher(objTrans)
                'Log Entry
                fnLogEntry(pbUserId, "New SB account created" & txtAccNo.Text, Date.Now, "New SB account", objTrans)
                MessageBox.Show("New SB account created successfully.", "SB Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New SB account creation failed, because of internal error.", "SB Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objSBAccount.fnUpdateSBAccount(objTrans) Then
                fnLogEntry(pbUserId, "SB updated" & txtAccNo.Text, Date.Now, "update SB account", objTrans)
                MessageBox.Show("SB account updated successfully.", "SB Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("SB account updation failed, because of internal error.", "SB Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        End If
    End Function

    Function fnSetData() As Boolean

        '''Person Deatils
        If lngPersonNo <> 0 Then
            objSBAccount.PersonNo = lngPersonNo
        Else
            objSBAccount.PersonNo = objSBAccount.fnGetNewPersonNo()
        End If
        objSBAccount.Name = txtName.Text
        objSBAccount.FatherName = txtFatherName.Text
        objSBAccount.PermAddress = txtPermAddress.Text
        objSBAccount.PresAddress = txtPresAddress.Text
        objSBAccount.PhoneNo = txtPhoneNo.Text
        objSBAccount.MobileNo = txtMobileNo.Text
        objSBAccount.DOB = dtpDOB.Value
        objSBAccount.Age = txtAge.Text
        objSBAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
        objSBAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objSBAccount.ReligionCode = cmbReligion.SelectedValue
        objSBAccount.CasteCode = cmbCaste.SelectedValue
        objSBAccount.OccupationCode = cmbOccupation.SelectedValue
        'objSBAccount.Photo = fnGetPhoto()
        objSBAccount.Photo = picPhoto.ImageLocation

        'objSBAccount.Sign = fnGetSign()
        objSBAccount.Sign = picSignature.ImageLocation

        objSBAccount.Education = txtEducation.Text
        objSBAccount.OffAddress = txtOffAddress.Text

        '' Sb Details

        objSBAccount.SBNo = txtAccNo.Text
        objSBAccount.CustomerID = txtCustomerID.Text


        objSBAccount.AccDate = dtpAccDate.Value
        objSBAccount.AccBal = txtAvailBal.Text

        Select Case cmbAccType.SelectedItem
            Case "Single"
                objSBAccount.AccType = "S"
            Case "Joint"
                objSBAccount.AccType = "J"
        End Select

        Select Case cmbOpMode.SelectedItem
            Case ""
                objSBAccount.OpMode = "E"
            Case "Together"
                objSBAccount.OpMode = "T"
            Case "Either"
                objSBAccount.OpMode = "E"
        End Select

        objSBAccount.IntroSBNo = txtIntroAccNo.Text

        Select Case cmbAccStatus.SelectedItem
            Case "Active"
                objSBAccount.AccStatus = "A"
            Case "Suspended"
                objSBAccount.AccStatus = "S"
            Case "Closed"
                objSBAccount.AccStatus = "C"
        End Select

        objSBAccount.Remarks = txtRemarks.Text
        objSBAccount.PhotoID = IIf(chkphotoId.Checked = True, "Y", "N")
        objSBAccount.AddrID = IIf(chkSdressId.Checked = True, "Y", "N")
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
                        ''msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        'picPhoto.Image = Image.FromStream(msStream)                        
                        picPhoto.Image = Image.FromFile(objDT.Rows(0).Item("Photo"))
                        picPhoto.ImageLocation = objDT.Rows(0).Item("Photo")


                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        'msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        ''msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
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

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpAccDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        objSBAccount.fnSbtransactionEnter(Trim(txtAccNo.Text), dtpAccDate.Value, "By new SB account " & txtAccNo.Text, Trim(txtAvailBal.Text), 0, Trim(txtAvailBal.Text), 0, Trim(txtAvailBal.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReceiptNo.Text, dtpAccDate.Value, txtAvailBal.Text, "By new SB account" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpAccDate.Value, "By new SB account " & txtAccNo.Text, "To", 10, 0, Val(txtAvailBal.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpAccDate.Value, "By new SB account " & txtAccNo.Text, "By", 1, Val(txtAvailBal.Text), 0, 2, "Y", objTrans)

        Return True

    End Function

#End Region

#Region "EVENTS"

    Private Sub btnChqTransLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objChequeDetails As New frmSBChequeDetails
        objChequeDetails.ShowDialog(Me)

    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        If objSBAccount.fnCheckSBAccount(txtAccNo.Text) Then
            Dim objChequeBookIsue As New frmSBChequeBookIssue
            objChequeBookIsue.strSbno = Trim(txtAccNo.Text)
            objChequeBookIsue.txtName.Text = Me.txtName.Text
            objChequeBookIsue.cmbAccountNo.Enabled = False
            objChequeBookIsue.txtName.ReadOnly = True
            objChequeBookIsue.btnSearch.Enabled = False
            objChequeBookIsue.ShowDialog(Me)
        Else
            MsgBox("Account Number Dosent Exist ", MsgBoxStyle.Information, "SB Module")
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

    ''To check data entered by the User, function called when "OK" button is clicked 
    ''save The Data into DataBase
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    objTrans = fnGetTransaction()
                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        If MsgBox("You want to add another SB Account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
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

    Private Sub frmSBAccCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAvailBal.ContextMenu = New ContextMenu
        cmbAccStatus.SelectedIndex = 0
        cmbAccType.SelectedText = "Single"
        dtpDOB.MaxDate = Date.Now
        'dtpAccDate.MaxDate = Date.Now
        'dtpAccDate.Value = Date.Now

        sbLoadControlValues() 'Load Values 
        txtAccNo.Focus()
        If txtAccNo.Text <> "SB" Then
            sbLoadSBAccDetails()
        Else
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyUp

        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtAccNo.Text = "SB" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccNo.KeyPress

        If txtAccNo.Text = "SB" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyDown

        If txtAccNo.Text = "SB" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccNo.Text = objSBAccSearch.strSBAccountNo
            sbLoadSBAccDetails()
        End If
        objSBAccSearch.Dispose()
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

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtAccNo.Text) <> "" And txtName.Text <> "" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtAccNo.Text
            objNominees.txtAddress.Text = txtPermAddress.Text
            objNominees.chrType = "N"

            objNominees.Text = "Savings bank nominees for account no  " & txtAccNo.Text
            objNominees.txtName.Text = txtName.Text
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Enter account no and name", MsgBoxStyle.Information, "SB Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If Trim(txtAccNo.Text) <> "" And txtName.Text <> "" Then
            If cmbAccType.SelectedItem = "Joint" Then
                Dim objJointHolders As New frmNominees
                objJointHolders.txtAccountNo.Text = txtAccNo.Text
                objJointHolders.chrType = "J"
                objJointHolders.Text = "Savings Bank Joint-Holders for Account No  " & txtAccNo.Text
                objJointHolders.txtName.Text = txtName.Text
                objJointHolders.ShowDialog(Me)
                objJointHolders.Dispose()
            Else
                MsgBox("Account type is not joint", MsgBoxStyle.Information, "SB Module")
            End If
        Else
            MsgBox("Enter account no and name", MsgBoxStyle.Information, "SB Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If objSBAccount.fnCheckSBAccount(txtAccNo.Text) Then
            Dim objfrmAccountStmt As New frmSBStmtOfAccount
            objfrmAccountStmt.txtAccno.Text = Me.txtAccNo.Text
            objfrmAccountStmt.txtName.Text = Me.txtName.Text
            objfrmAccountStmt.txtAccno.ReadOnly = True
            objfrmAccountStmt.txtName.ReadOnly = True
            objfrmAccountStmt.btnSearch.Enabled = False
            objfrmAccountStmt.ShowDialog(Me)
        Else
            MsgBox("Account number dosent exist ", MsgBoxStyle.Information, "SB Module")
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
        Dim TempNewNo As String = Mid(objSBAccount.fnGetNewSBNo, 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "SB" & String.Format("{0:00000}", CInt(TempNewNo))
            txtAccNo.Text = Temp
            txtAccNo.Focus()
        Else
            MsgBox("SB number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        txtPermAddress_TextChanged(Me, e.Empty)
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.TextChanged
        If txtAccNo.Text.StartsWith("SB") = False Then
            txtAccNo.Undo()
            txtAccNo.ClearUndo()
        End If
    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave

        If txtAccNo.Text <> "SB" Then
            If objSBAccount.fnCheckSBAccount(Trim(txtAccNo.Text)) = True Then
                If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sbLoadSBAccDetails()
                Else
                    btnAdd_Click(sender, e)
                    txtAccNo.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub dtpDOB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
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
    End Sub

    Private Sub btnChqStopPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChqStopPay.Click
        Dim objfrmSBChequeStopPay As New frmSBChequeStopPay
        objfrmSBChequeStopPay.txtAccNo.Text = Trim(txtAccNo.Text)
        objfrmSBChequeStopPay.ShowDialog(Me)
    End Sub

    Private Sub btnStopChqDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopChqDet.Click
        Dim objfrmStopChqDet As New frmSBStopChequeDet
        objfrmStopChqDet.ShowDialog()
    End Sub

#End Region

#Region "Genral Subroutines"

    Sub sbLoadSBAccDetails()
        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objSBAccount.fnGetSBAccountDetails(txtAccNo.Text) Then
                sbClear()

                objDT = objSBAccount.SBAccTable

                'Sb Details

                txtAccNo.Text = objDT.Rows(0).Item("AccountNo")
                txtAccNo.ReadOnly = True
                txtAccNo.Enabled = False
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                dtpAccDate.Value = CDate(objDT.Rows(0).Item("AccDate"))
                '' dtpAccDate.Text = CDate(objDT.Rows(0).Item("AccDate"))
                dtpAccDate.Enabled = False
                txtAvailBal.Text = Format(objDT.Rows(0).Item("AvailBalance"), "0,00.00")
                txtAvailBal.Enabled = False
                'btnMemSearch.Enabled = False
                'txtMemberNo.Enabled = False
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
                Select Case objDT.Rows(0).Item("AccStatus")
                    Case "A"
                        cmbAccStatus.SelectedItem = "Active"
                    Case "S"
                        cmbAccStatus.SelectedItem = "Suspended"
                    Case "C"
                        cmbAccStatus.SelectedItem = "Closed"
                End Select
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")
                Select Case objDT.Rows(0).Item("Photo_Id")
                    Case "Y"
                        chkphotoId.Checked = True
                    Case "N"
                        chkphotoId.Checked = False
                End Select
                Select Case objDT.Rows(0).Item("Address_Id")
                    Case "Y"
                        chkSdressId.Checked = True
                    Case "N"
                        chkSdressId.Checked = False
                End Select
                txtReceiptNo.Text = IIf(IsDBNull(objDT.Rows(0).Item("ReciptNo")) = True, "", objDT.Rows(0).Item("ReciptNo"))


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
                txtOffAddress.Text = objDT.Rows(0).Item("OfficeAddress")
                txtOfficeNo.Text = objDT.Rows(0).Item("OfficeNo")
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
        Catch ex As Exception
        End Try
    End Sub

    Sub sbClear()
        lngPersonNo = 0
        txtAccNo.ReadOnly = False
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
        txtIntroAccNo.ResetText()
        txtIntroAccNo.Enabled = True
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        txtEducation.ResetText()
        txtOffAddress.ResetText()
        txtReceiptNo.ResetText()
        txtAvailBal.ResetText()
        txtAvailBal.Enabled = True
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtRemarks.ResetText()
        btnMemSearch.Enabled = True
        txtCustomerID.Text = "CID"
        txtAccNo.Enabled = True
        txtCustomerID.Enabled = False
        txtOfficeNo.ResetText()
    End Sub


#End Region

#Region " Key Down Events"

    Private Sub txtOffAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
            dtpAccDate.Focus()
        End If
    End Sub

    Private Sub dtpDOB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDOB.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbReligion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReligion.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbCaste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCaste.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbOccupation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOccupation.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbPermVillage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbMajor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbMajor.KeyDown, rdbMinor.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkSame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkSame.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbPresVillage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpAccDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpAccDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAccType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAccType.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub cmbOpMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbOpMode.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAccStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAccStatus.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbMale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbMale.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rdbFemale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbFemale.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkphotoId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkphotoId.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

    Private Sub chkSdressId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkSdressId.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            TabControl1.SelectedIndex = 2
        End If
    End Sub

#End Region

    Private Sub frmSBAccCreation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F3 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtIntroAccNo.Text = objMemberSearch.strMemberNo
        End If
        objMemberSearch.Dispose()
    End Sub

    Private Sub cmbAccType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccType.TextChanged
        If (cmbAccType.Text = "Single") Then
            cmbOpMode.Visible = False
            Label21.Visible = False
        End If
        If (cmbAccType.Text = "Joint") Then
            cmbOpMode.Visible = True
            Label21.Visible = True
        End If
    End Sub
End Class
