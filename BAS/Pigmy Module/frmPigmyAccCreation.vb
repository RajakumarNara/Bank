#Region "Import Statements"
Imports System.IO
#End Region

Public Class frmPigmyAccCreation
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objPGAccount As New clsPigmyAccount
    'Dim objRDAccount As New clsRDAccount
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Friend WithEvents lblAgentName As System.Windows.Forms.Label
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkphotoId As System.Windows.Forms.CheckBox
    Friend WithEvents chkSdressId As System.Windows.Forms.CheckBox
    Friend WithEvents cmbOpMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbAccStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents txtReceiptNo As BankControls.TextControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAgents As BankControls.NewButton
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtYY As BankControls.TextControl
    Friend WithEvents txtMM As BankControls.TextControl
    Friend WithEvents txtDD As BankControls.TextControl
    Friend WithEvents grpPeriod As System.Windows.Forms.GroupBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents txtAgentNo As BankControls.TextControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents txtBNNC As BankControls.NumericControl
    Friend WithEvents txtBNND As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents btnNewMember As BankControls.NewButton
    Friend WithEvents txtOfficeNo As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtOffAddress As BankControls.TextControl
    Friend WithEvents txtEducation As BankControls.TextControl
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents btnBNNCPROCESS As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents NewButton7 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPigmyAccCreation))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.txtOfficeNo = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtOffAddress = New BankControls.TextControl
        Me.txtEducation = New BankControls.TextControl
        Me.Label35 = New System.Windows.Forms.Label
        Me.NewButton4 = New BankControls.NewButton
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
        Me.txtCustomerID = New BankControls.TextControl
        Me.tbSBAccDetails = New System.Windows.Forms.TabPage
        Me.lblAgentName = New System.Windows.Forms.Label
        Me.txtBNND = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.NewButton1 = New BankControls.NewButton
        Me.txtAgentNo = New BankControls.TextControl
        Me.grpPeriod = New System.Windows.Forms.GroupBox
        Me.txtROI = New BankControls.NumericControl
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtYY = New BankControls.TextControl
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMM = New BankControls.TextControl
        Me.txtDD = New BankControls.TextControl
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.TextControl
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmbAccType = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkphotoId = New System.Windows.Forms.CheckBox
        Me.chkSdressId = New System.Windows.Forms.CheckBox
        Me.txtBNNC = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbOpMode = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbAccStatus = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
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
        Me.NewButton7 = New BankControls.NewButton
        Me.NewButton6 = New BankControls.NewButton
        Me.btnBNNCPROCESS = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.btnAgents = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbSBAccDetails.SuspendLayout()
        Me.grpPeriod.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(736, 400)
        Me.TabControl1.TabIndex = 4
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPersonal.Controls.Add(Me.txtOfficeNo)
        Me.tbPersonal.Controls.Add(Me.Label15)
        Me.tbPersonal.Controls.Add(Me.Label20)
        Me.tbPersonal.Controls.Add(Me.txtOffAddress)
        Me.tbPersonal.Controls.Add(Me.txtEducation)
        Me.tbPersonal.Controls.Add(Me.Label35)
        Me.tbPersonal.Controls.Add(Me.NewButton4)
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
        Me.tbPersonal.Controls.Add(Me.txtCustomerID)
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(728, 371)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        Me.tbPersonal.UseVisualStyleBackColor = True
        '
        'txtOfficeNo
        '
        Me.txtOfficeNo.AfterDecimal = 0
        Me.txtOfficeNo.BeforeDecimal = 20
        Me.txtOfficeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeNo.Location = New System.Drawing.Point(504, 256)
        Me.txtOfficeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeNo.MaxLength = 20
        Me.txtOfficeNo.MaxValue = 0
        Me.txtOfficeNo.MinValue = 0
        Me.txtOfficeNo.Name = "txtOfficeNo"
        Me.txtOfficeNo.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeNo.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(360, 264)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 16)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Office No. :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(360, 288)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 16)
        Me.Label20.TabIndex = 149
        Me.Label20.Text = "Office Address :"
        '
        'txtOffAddress
        '
        Me.txtOffAddress.AlphaNumeric = True
        Me.txtOffAddress.BlankSpace = True
        Me.txtOffAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOffAddress.Location = New System.Drawing.Point(504, 288)
        Me.txtOffAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOffAddress.Mandatory = False
        Me.txtOffAddress.MaxLength = 255
        Me.txtOffAddress.Multiline = True
        Me.txtOffAddress.Name = "txtOffAddress"
        Me.txtOffAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtOffAddress.SpecialChar = True
        Me.txtOffAddress.TabIndex = 26
        '
        'txtEducation
        '
        Me.txtEducation.AlphaNumeric = True
        Me.txtEducation.BlankSpace = False
        Me.txtEducation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEducation.Location = New System.Drawing.Point(144, 312)
        Me.txtEducation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEducation.Mandatory = False
        Me.txtEducation.MaxLength = 50
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(168, 23)
        Me.txtEducation.SpecialChar = True
        Me.txtEducation.TabIndex = 19
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(24, 312)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(89, 16)
        Me.Label35.TabIndex = 148
        Me.Label35.Text = "Education : "
        '
        'NewButton4
        '
        Me.NewButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.ForeColor = System.Drawing.Color.Black
        Me.NewButton4.GotFocusColour = System.Drawing.Color.OliveDrab
        Me.NewButton4.Image = CType(resources.GetObject("NewButton4.Image"), System.Drawing.Image)
        Me.NewButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton4.Location = New System.Drawing.Point(299, -24)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(24, 24)
        Me.NewButton4.TabIndex = 144
        Me.NewButton4.UseVisualStyleBackColor = False
        '
        'btnNewMember
        '
        Me.btnNewMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMember.ForeColor = System.Drawing.Color.Black
        Me.btnNewMember.GotFocusColour = System.Drawing.Color.Beige
        Me.btnNewMember.Image = CType(resources.GetObject("btnNewMember.Image"), System.Drawing.Image)
        Me.btnNewMember.Location = New System.Drawing.Point(320, 16)
        Me.btnNewMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(32, 24)
        Me.btnNewMember.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(144, 176)
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
        Me.Panel3.Location = New System.Drawing.Point(144, 144)
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
        Me.Label16.Location = New System.Drawing.Point(24, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 16)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Age Status : "
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.BlankSpace = False
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(144, 48)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(168, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 7
        '
        'chkSame
        '
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(504, 88)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(200, 24)
        Me.chkSame.TabIndex = 21
        Me.chkSame.Text = "same as permanent address"
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(144, 248)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(168, 24)
        Me.cmbCaste.TabIndex = 17
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(144, 216)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(168, 24)
        Me.cmbReligion.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(360, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Present Address : "
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(144, 80)
        Me.dtpDOB.MaxDate = New Date(9998, 9, 3, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(168, 23)
        Me.dtpDOB.TabIndex = 8
        Me.dtpDOB.Value = New Date(2007, 8, 14, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Father Name : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
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
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Occupation :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Permanent Address  "
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(144, 280)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(168, 24)
        Me.cmbOccupation.TabIndex = 18
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(360, 192)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(360, 224)
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
        Me.txtAge.Location = New System.Drawing.Point(144, 112)
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
        Me.txtPresAddress.Location = New System.Drawing.Point(504, 120)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
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
        Me.txtPhoneNo.Location = New System.Drawing.Point(504, 192)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
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
        Me.txtMobileNo.Location = New System.Drawing.Point(504, 224)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
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
        Me.txtPermAddress.Location = New System.Drawing.Point(504, 16)
        Me.txtPermAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 20
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
        Me.btnMemSearch.Location = New System.Drawing.Point(288, 16)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
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
        Me.txtCustomerID.Location = New System.Drawing.Point(144, 16)
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
        Me.tbSBAccDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.tbSBAccDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSBAccDetails.Controls.Add(Me.lblAgentName)
        Me.tbSBAccDetails.Controls.Add(Me.txtBNND)
        Me.tbSBAccDetails.Controls.Add(Me.Label13)
        Me.tbSBAccDetails.Controls.Add(Me.NewButton1)
        Me.tbSBAccDetails.Controls.Add(Me.txtAgentNo)
        Me.tbSBAccDetails.Controls.Add(Me.grpPeriod)
        Me.tbSBAccDetails.Controls.Add(Me.txtReceiptNo)
        Me.tbSBAccDetails.Controls.Add(Me.Label24)
        Me.tbSBAccDetails.Controls.Add(Me.cmbAccType)
        Me.tbSBAccDetails.Controls.Add(Me.Panel1)
        Me.tbSBAccDetails.Controls.Add(Me.txtBNNC)
        Me.tbSBAccDetails.Controls.Add(Me.Label18)
        Me.tbSBAccDetails.Controls.Add(Me.Label19)
        Me.tbSBAccDetails.Controls.Add(Me.Label21)
        Me.tbSBAccDetails.Controls.Add(Me.Label22)
        Me.tbSBAccDetails.Controls.Add(Me.cmbOpMode)
        Me.tbSBAccDetails.Controls.Add(Me.Label23)
        Me.tbSBAccDetails.Controls.Add(Me.cmbAccStatus)
        Me.tbSBAccDetails.Controls.Add(Me.Label27)
        Me.tbSBAccDetails.Location = New System.Drawing.Point(4, 25)
        Me.tbSBAccDetails.Name = "tbSBAccDetails"
        Me.tbSBAccDetails.Size = New System.Drawing.Size(728, 371)
        Me.tbSBAccDetails.TabIndex = 3
        Me.tbSBAccDetails.Text = "Pigmy Account Details"
        Me.tbSBAccDetails.UseVisualStyleBackColor = True
        '
        'lblAgentName
        '
        Me.lblAgentName.AutoSize = True
        Me.lblAgentName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgentName.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblAgentName.Location = New System.Drawing.Point(358, 181)
        Me.lblAgentName.Name = "lblAgentName"
        Me.lblAgentName.Size = New System.Drawing.Size(98, 16)
        Me.lblAgentName.TabIndex = 47
        Me.lblAgentName.Text = "Agent's Name"
        '
        'txtBNND
        '
        Me.txtBNND.AfterDecimal = 2
        Me.txtBNND.BeforeDecimal = 10
        Me.txtBNND.Enabled = False
        Me.txtBNND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBNND.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBNND.Location = New System.Drawing.Point(160, 48)
        Me.txtBNND.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBNND.MaxValue = 0
        Me.txtBNND.MinValue = 0
        Me.txtBNND.Name = "txtBNND"
        Me.txtBNND.Size = New System.Drawing.Size(168, 23)
        Me.txtBNND.TabIndex = 2
        Me.txtBNND.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(45, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 16)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Pigmy Deposit :"
        '
        'NewButton1
        '
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(330, 177)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(24, 24)
        Me.NewButton1.TabIndex = 8
        '
        'txtAgentNo
        '
        Me.txtAgentNo.AlphaNumeric = False
        Me.txtAgentNo.BackColor = System.Drawing.Color.White
        Me.txtAgentNo.BlankSpace = True
        Me.txtAgentNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentNo.GotFocusColour = System.Drawing.Color.White
        Me.txtAgentNo.Location = New System.Drawing.Point(160, 177)
        Me.txtAgentNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAgentNo.Mandatory = False
        Me.txtAgentNo.MaxLength = 30
        Me.txtAgentNo.Name = "txtAgentNo"
        Me.txtAgentNo.ReadOnly = True
        Me.txtAgentNo.Size = New System.Drawing.Size(168, 23)
        Me.txtAgentNo.SpecialChar = True
        Me.txtAgentNo.TabIndex = 7
        Me.txtAgentNo.TabStop = False
        '
        'grpPeriod
        '
        Me.grpPeriod.Controls.Add(Me.dtpAccDate)
        Me.grpPeriod.Controls.Add(Me.txtROI)
        Me.grpPeriod.Controls.Add(Me.dtpMaturityDate)
        Me.grpPeriod.Controls.Add(Me.Label34)
        Me.grpPeriod.Controls.Add(Me.Label30)
        Me.grpPeriod.Controls.Add(Me.txtYY)
        Me.grpPeriod.Controls.Add(Me.Label29)
        Me.grpPeriod.Controls.Add(Me.Label28)
        Me.grpPeriod.Controls.Add(Me.Label11)
        Me.grpPeriod.Controls.Add(Me.txtMM)
        Me.grpPeriod.Controls.Add(Me.txtDD)
        Me.grpPeriod.Controls.Add(Me.Label31)
        Me.grpPeriod.Controls.Add(Me.Label33)
        Me.grpPeriod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPeriod.Location = New System.Drawing.Point(16, 240)
        Me.grpPeriod.Name = "grpPeriod"
        Me.grpPeriod.Size = New System.Drawing.Size(672, 120)
        Me.grpPeriod.TabIndex = 12
        Me.grpPeriod.TabStop = False
        Me.grpPeriod.Text = "Period Details"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BeforeDecimal = 10
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(144, 72)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(80, 23)
        Me.txtROI.TabIndex = 10
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(512, 72)
        Me.dtpMaturityDate.MaxDate = New Date(9998, 12, 28, 0, 0, 0, 0)
        Me.dtpMaturityDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpMaturityDate.TabIndex = 17
        Me.dtpMaturityDate.TabStop = False
        Me.dtpMaturityDate.Value = New Date(2007, 8, 14, 0, 0, 0, 0)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(392, 72)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 16)
        Me.Label34.TabIndex = 57
        Me.Label34.Text = "Maturity Date :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(512, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(26, 16)
        Me.Label30.TabIndex = 55
        Me.Label30.Text = "YY"
        '
        'txtYY
        '
        Me.txtYY.AlphaNumeric = True
        Me.txtYY.BlankSpace = False
        Me.txtYY.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYY.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtYY.Location = New System.Drawing.Point(512, 40)
        Me.txtYY.LostFocusColour = System.Drawing.Color.Empty
        Me.txtYY.Mandatory = False
        Me.txtYY.Name = "txtYY"
        Me.txtYY.Size = New System.Drawing.Size(32, 23)
        Me.txtYY.SpecialChar = False
        Me.txtYY.TabIndex = 14
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(392, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "Period :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 72)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 16)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "ROI :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 16)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Opening Date :"
        '
        'txtMM
        '
        Me.txtMM.AlphaNumeric = True
        Me.txtMM.BlankSpace = False
        Me.txtMM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMM.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMM.Location = New System.Drawing.Point(552, 40)
        Me.txtMM.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMM.Mandatory = False
        Me.txtMM.Name = "txtMM"
        Me.txtMM.Size = New System.Drawing.Size(32, 23)
        Me.txtMM.SpecialChar = False
        Me.txtMM.TabIndex = 15
        '
        'txtDD
        '
        Me.txtDD.AlphaNumeric = True
        Me.txtDD.BlankSpace = False
        Me.txtDD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDD.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDD.Location = New System.Drawing.Point(592, 40)
        Me.txtDD.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDD.Mandatory = False
        Me.txtDD.Name = "txtDD"
        Me.txtDD.Size = New System.Drawing.Size(32, 23)
        Me.txtDD.SpecialChar = False
        Me.txtDD.TabIndex = 16
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(552, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 16)
        Me.Label31.TabIndex = 55
        Me.Label31.Text = "MM"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(600, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(26, 16)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "DD"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AlphaNumeric = True
        Me.txtReceiptNo.BlankSpace = False
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(160, 145)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.Mandatory = False
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(168, 23)
        Me.txtReceiptNo.SpecialChar = False
        Me.txtReceiptNo.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(50, 147)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 16)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Receipt No. :"
        '
        'cmbAccType
        '
        Me.cmbAccType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.Items.AddRange(New Object() {"Single", "Joint"})
        Me.cmbAccType.Location = New System.Drawing.Point(160, 80)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccType.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkphotoId)
        Me.Panel1.Controls.Add(Me.chkSdressId)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(418, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 48)
        Me.Panel1.TabIndex = 11
        '
        'chkphotoId
        '
        Me.chkphotoId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkphotoId.Location = New System.Drawing.Point(8, 5)
        Me.chkphotoId.Name = "chkphotoId"
        Me.chkphotoId.Size = New System.Drawing.Size(127, 32)
        Me.chkphotoId.TabIndex = 12
        Me.chkphotoId.Text = "Photo Id Proof"
        '
        'chkSdressId
        '
        Me.chkSdressId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSdressId.Location = New System.Drawing.Point(152, 5)
        Me.chkSdressId.Name = "chkSdressId"
        Me.chkSdressId.Size = New System.Drawing.Size(128, 32)
        Me.chkSdressId.TabIndex = 13
        Me.chkSdressId.Text = "Address Proof"
        '
        'txtBNNC
        '
        Me.txtBNNC.AfterDecimal = 2
        Me.txtBNNC.BeforeDecimal = 10
        Me.txtBNNC.Enabled = False
        Me.txtBNNC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBNNC.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBNNC.Location = New System.Drawing.Point(160, 16)
        Me.txtBNNC.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBNNC.MaxValue = 0
        Me.txtBNNC.MinValue = 0
        Me.txtBNNC.Name = "txtBNNC"
        Me.txtBNNC.Size = New System.Drawing.Size(168, 23)
        Me.txtBNNC.TabIndex = 1
        Me.txtBNNC.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Pigmy Collection :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(92, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 16)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Type :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(346, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 16)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Operational Mode :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(362, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 16)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Proof :"
        '
        'cmbOpMode
        '
        Me.cmbOpMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOpMode.Items.AddRange(New Object() {"Together", "Either"})
        Me.cmbOpMode.Location = New System.Drawing.Point(484, 82)
        Me.cmbOpMode.Name = "cmbOpMode"
        Me.cmbOpMode.Size = New System.Drawing.Size(168, 24)
        Me.cmbOpMode.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 16)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Account Status : "
        '
        'cmbAccStatus
        '
        Me.cmbAccStatus.DisplayMember = "A,S,C"
        Me.cmbAccStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccStatus.Items.AddRange(New Object() {"Active", "Suspended", "Closed"})
        Me.cmbAccStatus.Location = New System.Drawing.Point(160, 112)
        Me.cmbAccStatus.Name = "cmbAccStatus"
        Me.cmbAccStatus.Size = New System.Drawing.Size(168, 24)
        Me.cmbAccStatus.TabIndex = 5
        Me.cmbAccStatus.ValueMember = "A,S,C"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(65, 180)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Agent No :"
        '
        'tbOthers
        '
        Me.tbOthers.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
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
        Me.tbOthers.Size = New System.Drawing.Size(728, 371)
        Me.tbOthers.TabIndex = 2
        Me.tbOthers.Text = "Others"
        Me.tbOthers.UseVisualStyleBackColor = True
        Me.tbOthers.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(136, 264)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(480, 72)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(56, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Remarks :"
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.Beige
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 216)
        Me.btnLoadPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoadPhoto.Name = "btnLoadPhoto"
        Me.btnLoadPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadPhoto.TabIndex = 1
        Me.btnLoadPhoto.Text = "Load"
        Me.btnLoadPhoto.UseVisualStyleBackColor = False
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 216)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 2
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'picSignature
        '
        Me.picSignature.BackgroundImage = CType(resources.GetObject("picSignature.BackgroundImage"), System.Drawing.Image)
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(456, 16)
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
        Me.lblSignature.Location = New System.Drawing.Point(368, 24)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(87, 16)
        Me.lblSignature.TabIndex = 50
        Me.lblSignature.Text = "Signature : "
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(136, 16)
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
        Me.lblPhoto.Location = New System.Drawing.Point(56, 24)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(57, 16)
        Me.lblPhoto.TabIndex = 48
        Me.lblPhoto.Text = "Photo :"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancelSign.Location = New System.Drawing.Point(536, 216)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 4
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.Beige
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(456, 216)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 3
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
        Me.txtName.Location = New System.Drawing.Point(536, 72)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 96)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(168, 48)
        Me.NewButton2.TabIndex = 40
        Me.NewButton2.Text = "Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton2.UseVisualStyleBackColor = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.Beige
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 136)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 48)
        Me.btnNominees.TabIndex = 41
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.Beige
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(6, 376)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(188, 40)
        Me.btnWithdraw.TabIndex = 44
        Me.btnWithdraw.Text = "&Premature"
        Me.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(6, 416)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(188, 40)
        Me.NewButton5.TabIndex = 45
        Me.NewButton5.Text = "View Transaction Log(All)"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton5.UseVisualStyleBackColor = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(6, 296)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(188, 40)
        Me.btnDeposit.TabIndex = 43
        Me.btnDeposit.Text = "Pigmy Collection"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.Beige
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(553, 560)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 27
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(656, 560)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 75)
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
        Me.txtAccNo.Location = New System.Drawing.Point(176, 72)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 8
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.Text = "BNN"
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
        Me.btnSearch.Location = New System.Drawing.Point(312, 72)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton7)
        Me.GroupBox1.Controls.Add(Me.NewButton6)
        Me.GroupBox1.Controls.Add(Me.btnBNNCPROCESS)
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.Controls.Add(Me.btnAgents)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'NewButton7
        '
        Me.NewButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton7.ForeColor = System.Drawing.Color.Black
        Me.NewButton7.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton7.Image = CType(resources.GetObject("NewButton7.Image"), System.Drawing.Image)
        Me.NewButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton7.Location = New System.Drawing.Point(6, 496)
        Me.NewButton7.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton7.Name = "NewButton7"
        Me.NewButton7.Size = New System.Drawing.Size(188, 40)
        Me.NewButton7.TabIndex = 53
        Me.NewButton7.Text = "Agent's  Commission"
        Me.NewButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton7.UseVisualStyleBackColor = False
        Me.NewButton7.Visible = False
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton6.Image = CType(resources.GetObject("NewButton6.Image"), System.Drawing.Image)
        Me.NewButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton6.Location = New System.Drawing.Point(6, 216)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(188, 40)
        Me.NewButton6.TabIndex = 52
        Me.NewButton6.Text = "Pigmy Deposit Process"
        Me.NewButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton6.UseVisualStyleBackColor = False
        Me.NewButton6.Visible = False
        '
        'btnBNNCPROCESS
        '
        Me.btnBNNCPROCESS.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnBNNCPROCESS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBNNCPROCESS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBNNCPROCESS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBNNCPROCESS.ForeColor = System.Drawing.Color.Black
        Me.btnBNNCPROCESS.GotFocusColour = System.Drawing.Color.Beige
        Me.btnBNNCPROCESS.Image = CType(resources.GetObject("btnBNNCPROCESS.Image"), System.Drawing.Image)
        Me.btnBNNCPROCESS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBNNCPROCESS.Location = New System.Drawing.Point(6, 256)
        Me.btnBNNCPROCESS.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnBNNCPROCESS.Name = "btnBNNCPROCESS"
        Me.btnBNNCPROCESS.Size = New System.Drawing.Size(188, 40)
        Me.btnBNNCPROCESS.TabIndex = 51
        Me.btnBNNCPROCESS.Text = "Pigmy Collection Process"
        Me.btnBNNCPROCESS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBNNCPROCESS.UseVisualStyleBackColor = False
        Me.btnBNNCPROCESS.Visible = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(6, 336)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(188, 40)
        Me.NewButton3.TabIndex = 50
        Me.NewButton3.Text = "Pigmy Deposit"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'btnAgents
        '
        Me.btnAgents.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAgents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgents.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgents.ForeColor = System.Drawing.Color.Black
        Me.btnAgents.GotFocusColour = System.Drawing.Color.Beige
        Me.btnAgents.Image = CType(resources.GetObject("btnAgents.Image"), System.Drawing.Image)
        Me.btnAgents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgents.Location = New System.Drawing.Point(6, 456)
        Me.btnAgents.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAgents.Name = "btnAgents"
        Me.btnAgents.Size = New System.Drawing.Size(188, 40)
        Me.btnAgents.TabIndex = 49
        Me.btnAgents.Text = "Agent's Creation"
        Me.btnAgents.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgents.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.Beige
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(32, 560)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
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
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(88, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(170, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "New BNN Account"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpAccDate.Enabled = False
        Me.dtpAccDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(144, 40)
        Me.dtpAccDate.MaxDate = New Date(9998, 12, 28, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpAccDate.TabIndex = 58
        Me.dtpAccDate.TabStop = False
        Me.dtpAccDate.Value = New Date(2007, 8, 14, 0, 0, 0, 0)
        '
        'frmPigmyAccCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPigmyAccCreation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pigmy Account Creation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbSBAccDetails.ResumeLayout(False)
        Me.tbSBAccDetails.PerformLayout()
        Me.grpPeriod.ResumeLayout(False)
        Me.grpPeriod.PerformLayout()
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

    Private Shared m_FormDefInstance As frmPigmyAccCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmPigmyAccCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmPigmyAccCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmPigmyAccCreation)
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

    Sub sbCalMaturity()

        dtpMaturityDate.Value = DateAdd(DateInterval.Year, Val(txtYY.Text), dtpAccDate.Value)
        dtpMaturityDate.Value = DateAdd(DateInterval.Month, Val(txtMM.Text), dtpMaturityDate.Value)
        dtpMaturityDate.Value = DateAdd(DateInterval.Day, Val(txtDD.Text), dtpMaturityDate.Value)
        fnGetROI()

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
        If Trim(txtAccNo.Text) = "BNN" Then
            MsgBox("Enter account no ", MsgBoxStyle.Exclamation)
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
            'ElseIf Trim(txtAvailBal.Text) = String.Empty Then
            '    MsgBox("Enter Available Balance")
            '    Me.TabControl1.SelectedTab = Me.tbSBAccDetails
            '    txtAvailBal.Focus()
            '    Return False
        ElseIf cmbAccType.SelectedIndex = -1 Then
            MsgBox("Select account type", MsgBoxStyle.Exclamation)
            cmbAccType.Focus()
            Return False
        ElseIf cmbOpMode.SelectedIndex = -1 Then
            MsgBox("Selece operation mode", MsgBoxStyle.Exclamation)
            cmbOpMode.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = String.Empty Then
            MsgBox("Enter recipt no number", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        ElseIf Trim(txtAgentNo.Text) = String.Empty Then
            MsgBox("Enter agent number", MsgBoxStyle.Exclamation)
            txtAgentNo.Focus()
            Return False
        ElseIf (Val(txtYY.Text) = 0 And Val(txtMM.Text) = 0 And Val(txtDD.Text) = 0) Then
            MsgBox("Please enter period of deposit", MsgBoxStyle.Exclamation)
            txtYY.Focus()
            Return False
        ElseIf Trim(txtROI.Text) = String.Empty Then
            MsgBox("Enter rate of intereset", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objPGAccount.fnCheckPGAccount(Trim(txtAccNo.Text)) = False Then

            'ADD new Member  (ADD Mode)
            If objPGAccount.fnAddPGAccount(objTrans) Then
                ' fnGenerateVoucher(objTrans)
                'Log Entry
                fnLogEntry(pbUserId, "New account created" & txtAccNo.Text, Date.Now, "New Account", objTrans)
                objTrans.Commit()
                MessageBox.Show("New BNN Account created successfully.", "BNN Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New BNN account creation failed, because of internal error.", "BNN Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objPGAccount.fnUpdateSBAccount(objTrans) Then
                fnLogEntry(pbUserId, "BNN updated" & txtAccNo.Text, Date.Now, "Update BNN account", objTrans)
                MessageBox.Show("BNN account updated successfully.", "BNN Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("BNN account updation failed, because of internal error.", "BNN Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        End If
    End Function

    Function fnSetData() As Boolean
        ' Person Deatils
        Try
            If lngPersonNo <> 0 Then
                objPGAccount.PersonNo = lngPersonNo
            Else
                objPGAccount.PersonNo = objPGAccount.fnGetNewPersonNo()
            End If
            objPGAccount.Name = txtName.Text
            objPGAccount.FatherName = txtFatherName.Text
            objPGAccount.PermAddress = txtPermAddress.Text
            objPGAccount.PresAddress = txtPresAddress.Text
            objPGAccount.PhoneNo = txtPhoneNo.Text
            objPGAccount.MobileNo = txtMobileNo.Text
            objPGAccount.DOB = dtpDOB.Value
            objPGAccount.Age = txtAge.Text
            objPGAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
            objPGAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
            objPGAccount.ReligionCode = cmbReligion.SelectedValue
            objPGAccount.CasteCode = cmbCaste.SelectedValue
            objPGAccount.OccupationCode = cmbOccupation.SelectedValue
            ' objPGAccount.Photo = fnGetPhoto()
            objPGAccount.Photo = picPhoto.ImageLocation
            'objPGAccount.Sign = fnGetSign()
            objPGAccount.Sign = picSignature.ImageLocation
            'PG Details

            objPGAccount.SBNo = txtAccNo.Text
            objPGAccount.MemberNo = txtCustomerID.Text
            objPGAccount.AccDate = dtpAccDate.Value
            objPGAccount.AccCollectionBal = 0
            objPGAccount.AccDepositBal = 0
            Select Case cmbAccType.SelectedItem
                Case "Single"
                    objPGAccount.AccType = "S"
                Case "Joint"
                    objPGAccount.AccType = "J"
            End Select
            Select Case cmbOpMode.SelectedItem
                Case "Together"
                    objPGAccount.OpMode = "T"
                Case "Either"
                    objPGAccount.OpMode = "E"
            End Select
            'objPGAccount.IntroSBNo = txtIntroAccNo.Text
            objPGAccount.AgnetNo = txtAgentNo.Text
            Select Case cmbAccStatus.SelectedItem
                Case "Active"
                    objPGAccount.AccStatus = "A"
                Case "Suspended"
                    objPGAccount.AccStatus = "S"
                Case "Closed"
                    objPGAccount.AccStatus = "C"
            End Select

            objPGAccount.Remarks = txtRemarks.Text
            objPGAccount.PhotoID = IIf(chkphotoId.Checked = True, "Y", "N")
            objPGAccount.AddrID = IIf(chkSdressId.Checked = True, "Y", "N")
            objPGAccount.ReciptNo = txtReceiptNo.Text
            objPGAccount.AgentId = txtAgentNo.Text
            objPGAccount.ROI = txtROI.Text
            objPGAccount.PeriodDD = Val(txtDD.Text)
            objPGAccount.PeriodMM = Val(txtMM.Text)
            objPGAccount.PeriodYY = Val(txtYY.Text)
            objPGAccount.MaturityDate = Format(dtpMaturityDate.Value, "yyyy-MM-dd")

            'objSBAccount.closingDate=dtpclosingDate.value

            Return True
        Catch ex As Exception
            Return False
        End Try
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

        lngVoucherNo = fnVoucherGetNewVNo(dtpAccDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        objPGAccount.fnPGtransactionEnter(Trim(txtAccNo.Text), dtpAccDate.Value, "By new account  " & txtAccNo.Text, 0, 0, 0, txtReceiptNo.Text, lngVoucherNo, "Cash", 0, txtAgentNo.Text, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReceiptNo.Text, dtpAccDate.Value, 0, "By new account" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpAccDate.Value, "By account " & txtAccNo.Text, "To", 28, 0, 0, 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpAccDate.Value, "By  account " & txtAccNo.Text, "By", 1, 0, 0, 2, "Y", objTrans)

        Return True

    End Function

    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptNo.Text, txtName.Text, dtpAccDate.Value, 0, "")

        'Receipt sub details
        fnReceiptEnterSub(txtReceiptNo.Text, dtpAccDate.Value, "Pigmy Deposit", 0, 1)

        Return True

    End Function


    Public Function fnGetROI() As Boolean

        If objPGAccount.fnGetMinPeriod() Then
            txtROI.Text = objPGAccount.MinPeriodtable.Rows(0).Item("ROI")
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
        Dim objfrmPigmyList As New frmPigmyList
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnSaveData(objTrans) Then

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

        cmbAccStatus.SelectedIndex = 0
        cmbAccType.SelectedText = "Single"
        cmbAccStatus.Enabled = True
        ' dtpAccDate.Value = Date.Now
        dtpMaturityDate.Value = Date.Now

        'dtpDOB.MaxDate = Date.Now
        'dtpAccDate.MaxDate = Date.Now
        'dtpDOB.Value = Date.Now
        'dtpAccDate.Value = Date.Now

        sbLoadControlValues() 'Load Values 
        txtAccNo.Focus()
        If txtAccNo.Text <> "BNN" Then
            sbLoadPGAccDetails()
        Else
            btnAdd_Click(sender, e)
        End If


    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtAccNo.Text = "BNN" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccNo.KeyPress
        If txtAccNo.Text = "BNN" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyDown
        If txtAccNo.Text = "BNN" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objPGAccCust As New frmPGCust
        objPGAccCust.strPGNo = String.Empty
        objPGAccCust.ShowDialog(Me)
        If objPGAccCust.strPGNo <> String.Empty Then
            txtAccNo.Text = objPGAccCust.strPGNo
            sbLoadPGAccDetails()
        End If
        objPGAccCust.Dispose()

    End Sub

    Private Sub btnMemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemSearch.Click
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            txtCustomerID.Text = objCustomerList.strCustomerID
            sbLoadMember()
        End If
        objCustomerList.Dispose()
    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtAccNo.Text) <> "BNN" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtAccNo.Text
            objNominees.chrType = "N"

            objNominees.txtName.Text = txtName.Text
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Enter valid Account Number", MsgBoxStyle.Information, "BNN Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If cmbAccType.SelectedItem = "Joint" Then
            If Trim(txtAccNo.Text) <> "BNN" Then
                Dim objJointHolders As New frmNominees
                objJointHolders.txtAccountNo.Text = txtAccNo.Text
                objJointHolders.txtName.Text = txtName.Text
                objJointHolders.Text = "Joint-Holders for Account No  " & txtAccNo.Text
                objJointHolders.chrType = "J"
                objJointHolders.ShowDialog(Me)
                objJointHolders.Dispose()
            Else
                MsgBox("Enter valid account number", MsgBoxStyle.Information, "BNN Module")
                txtAccNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Dim objfrmPigmyList As New frmPigmyList
        Me.Close()
        'objfrmPigmyList.frmPigmyList_Load(sender, e)
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click

        'Dim objPGDeposit As New frmPigmyDeposit
        'objPGDeposit.strAccNo = txtAccNo.Text
        'objPGDeposit.strName = txtName.Text
        ''objPGDeposit.btnSearch.Enabled = False
        'objPGDeposit.ShowDialog(Me)


        Dim objPGDeposit As New frmPigmyDeposit
        objPGDeposit.strAccNo = txtAccNo.Text
        objPGDeposit.strName = txtName.Text
        objPGDeposit.ShowDialog(Me)
        sbLoadPGAccDetails()


        'If objPGAccount.fnCheckPGAccount(Trim(txtAccNo.Text)) = True Then
        '    If objPGAccount.PGAccTable.Rows(0).Item("AccStatus") <> "C" Then
        '        Try

        '            Dim objPGDeposit As New frmPigmyDeposit
        '            objPGDeposit.strAccNo = txtAccNo.Text
        '            objPGDeposit.strName = txtName.Text
        '            objPGDeposit.btnSearch.Enabled = False
        '            objPGDeposit.ShowDialog(Me)

        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try

        '    Else
        '        MsgBox("Cannot Deposit, Account Closed", MsgBoxStyle.Exclamation, "BNN Module")
        '    End If
        'Else
        '    MsgBox("Enter valid Account Number", MsgBoxStyle.Information, "BNN Module")
        '    txtAccNo.Focus()
        'End If

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click

        If objPGAccount.fnCheckPGAccount(Trim(txtAccNo.Text)) = True Then
            If objPGAccount.PGAccTable.Rows(0).Item("AccStatus") <> "C" Then

                Dim objPigmyWithDrawl As New frmPigmyPreMature
                objPigmyWithDrawl.strAccNo = txtAccNo.Text
                objPigmyWithDrawl.strName = txtName.Text
                objPigmyWithDrawl.ShowDialog(Me)

            Else
                MsgBox("Cannot premature,account closed", MsgBoxStyle.Exclamation, "BNN Closed")
            End If
        Else
            MsgBox("Enter valid account number", MsgBoxStyle.Information, "BNN Module")
            txtAccNo.Focus()
        End If

    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click

        If txtAccNo.Text <> "BNN" Then
            Dim objPigmyTran As New frmPigmyTransaction
            Dim intCount As Integer
            objPigmyTran.strAccNo = txtAccNo.Text
            objPigmyTran.strName = txtName.Text
            objPigmyTran.btnSearch.Enabled = False
            objPigmyTran.Show()
        Else
            MsgBox("Enter valid account number", MsgBoxStyle.Information, "BNN Module")
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
        Dim TempNewNo As String = Mid(objPGAccount.fnGetNewPGANo, 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "BNN" & String.Format("{0:00000}", CInt(TempNewNo))
            txtAccNo.Text = Temp
            txtAccNo.Focus()
        Else
            MsgBox("Pigmy deposit number exceeds the maximum alloted number", MsgBoxStyle.Information, "Pigmy Deposit Module")
        End If

    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        txtPermAddress_TextChanged(Me, e.Empty)
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.TextChanged

        If txtAccNo.Text.StartsWith("BNN") = False Then
            txtAccNo.Undo()
            txtAccNo.ClearUndo()
        End If

    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave

        If txtAccNo.Text <> "BNN" Then
            If objPGAccount.fnCheckPGAccount(Trim(txtAccNo.Text)) = True Then
                If MsgBox("Account no already exists do you want to update it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    txtName.Focus()
                    sbLoadPGAccDetails()
                Else
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

#End Region

#Region "Genral Subroutines"

    Sub sbLoadPGAccDetails()
        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objPGAccount.fnGetPGAccountDetails(txtAccNo.Text) Then
                fnPGClear()

                objDT = objPGAccount.PGAccTable

                'PG Details

                txtAccNo.Text = objDT.Rows(0).Item("PigmyAccNo")
                txtAccNo.ReadOnly = True
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                lngPersonNo = objDT.Rows(0).Item("PigmyPersonNo")

                txtAgentNo.Text = objDT.Rows(0).Item("AgentNo")
                txtAgentNo.ReadOnly = True
                dtpAccDate.Value = Format(objDT.Rows(0).Item("AccDate"), "yyyy-MM-dd")
                dtpAccDate.Enabled = False
                txtBNNC.Text = objDT.Rows(0).Item("AvailCollection")
                txtBNND.Text = objDT.Rows(0).Item("AvailDeposit")

                txtBNNC.Enabled = False
                txtBNND.Enabled = False


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

                Select Case objDT.Rows(0).Item("AccStatus")
                    Case "A"
                        cmbAccStatus.SelectedItem = "Active"
                    Case "S"
                        cmbAccStatus.SelectedItem = "Suspended"
                    Case "C"
                        cmbAccStatus.Enabled = False
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
                txtReceiptNo.Text = IIf(IsDBNull(objDT.Rows(0).Item("ReceiptNo")) = True, "", objDT.Rows(0).Item("ReceiptNo"))
                txtYY.Text = objDT.Rows(0).Item("Years")
                txtMM.Text = objDT.Rows(0).Item("Months")
                txtDD.Text = objDT.Rows(0).Item("Days")
                txtROI.Text = objDT.Rows(0).Item("ROI")
                txtROI.ReadOnly = True
                dtpMaturityDate.Value = Format(objDT.Rows(0).Item("MaturityDate"), "yyyy-MM-dd")


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
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub fnPGClear()

        lngPersonNo = 0
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

        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        txtReceiptNo.ResetText()
        txtBNNC.ResetText()
        txtBNND.ResetText()
        'txtAvailBal.Enabled = True
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtRemarks.ResetText()
        btnMemSearch.Enabled = True
        txtCustomerID.Enabled = True
        txtAgentNo.ResetText()
        ' txtAgentNo.ReadOnly = False
        lblAgentName.Text = "Agent's Name"
        cmbAccType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        txtYY.ResetText()
        txtMM.ResetText()
        txtDD.ResetText()
        txtROI.ResetText()
        txtROI.ReadOnly = False
    End Sub

    Sub sbLoadMember()
        Dim objDT As DataTable
        Dim msStream As MemoryStream

        Try

            If objPerson.fnGetCustomerID(txtCustomerID.Text) Then
                fnPGClear()

                objDT = objPerson.PersonTable


                lngPersonNo = objDT.Rows(0).Item("PersonNo")

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

                txtName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region " Key Down Events"

    Private Sub txtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
            TabControl1.Focus()
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

    Private Sub dtpAccDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

    Private Sub btnAgents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgents.Click

        Dim objAgentList As New frmPigmyAgent
        objAgentList.ShowDialog()

    End Sub

    Private Sub txtYY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYY.TextChanged, txtMM.TextChanged, txtDD.TextChanged

        sbCalMaturity()

    End Sub

    Private Sub NewButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        Dim objAGSearch As New frmAGAccSearch
        objAGSearch.ShowDialog()
        txtAgentNo.Text = objAGSearch.strAGAccountNo
        lblAgentName.Text = objAGSearch.strAGAccName

    End Sub

    Private Sub dtpAccDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        sbCalMaturity()
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click

        Dim objPGDeposit123 As New frmPigmyTransfer
        objPGDeposit123.strAccNo = txtAccNo.Text
        objPGDeposit123.strName = txtName.Text
        objPGDeposit123.ShowDialog(Me)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNewMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMember.Click
        Dim objCustomer As New frmCustomer
        objCustomer = frmCustomer.DefInstance
        objCustomer.MdiParent = Me.MdiParent
        objCustomer.BringToFront()
        objCustomer.Show()
        objCustomer = Nothing
    End Sub

    Private Sub btnBNNCPROCESS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBNNCPROCESS.Click
        Dim objCustomer As New fmAgentsCustomers

        objCustomer.ShowDialog()


    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click
        Dim objCustomer As New frmBnncToBnnd

        objCustomer.ShowDialog()
    End Sub

    Private Sub NewButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton7.Click
        Dim objCustomer As New frmAgentsPerCaliculation

        objCustomer.ShowDialog()
    End Sub
    Private Sub cmbAccType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccType.TextChanged
        If cmbAccType.Text = "Single" Then
            cmbOpMode.Visible = False
            Label21.Visible = False
            cmbOpMode.Text = "Either"
        End If
        If cmbAccType.Text = "Joint" Then
            cmbOpMode.Visible = True
            Label21.Visible = True
        End If
    End Sub

End Class
