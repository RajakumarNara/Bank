Imports System.IO
Imports System.ComponentModel

Public Class frmCustomer
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbPersonal As System.Windows.Forms.TabPage
    Friend WithEvents txtEducation As BankControls.TextControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtOffAddress As BankControls.TextControl
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
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As BankControls.TextControl
    Friend WithEvents txtMobileNo As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpCreationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents Others As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtRemark1 As BankControls.TextControl
    Friend WithEvents btnLoadPhoto As BankControls.NewButton
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnCancelPhoto As BankControls.NewButton
    Friend WithEvents btnLoadSign As BankControls.NewButton
    Friend WithEvents btnCancelSign As BankControls.NewButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmailId As BankControls.TextControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPANNo As BankControls.TextControl
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtPersonNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtPersonNo = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbPersonal = New System.Windows.Forms.TabPage
        Me.txtPANNo = New BankControls.TextControl
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtEmailId = New BankControls.TextControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtOfficeNo = New BankControls.NumericControl
        Me.Label29 = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtEducation = New BankControls.TextControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtOffAddress = New BankControls.TextControl
        Me.chkSame = New System.Windows.Forms.CheckBox
        Me.cmbCaste = New System.Windows.Forms.ComboBox
        Me.cmbReligion = New System.Windows.Forms.ComboBox
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.txtAge = New BankControls.NumericControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFatherName = New BankControls.TextControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPermAddress = New BankControls.TextControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPresAddress = New BankControls.TextControl
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.cmbOccupation = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtPhoneNo = New BankControls.TextControl
        Me.txtMobileNo = New BankControls.TextControl
        Me.dtpCreationDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Others = New System.Windows.Forms.TabPage
        Me.btnCancelSign = New BankControls.NewButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtRemark1 = New BankControls.TextControl
        Me.btnLoadPhoto = New BankControls.NewButton
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.lblSignature = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnCancelPhoto = New BankControls.NewButton
        Me.btnLoadSign = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.btnClose = New BankControls.NewButton
        Me.btnSave = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerID = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.Label21 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbPersonal.SuspendLayout()
        Me.Others.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.txtPersonNo)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCustomerID)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(112, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label43.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(469, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(85, 16)
        Me.Label43.TabIndex = 10
        Me.Label43.Text = "Person No :"
        Me.Label43.Visible = False
        '
        'txtPersonNo
        '
        Me.txtPersonNo.Location = New System.Drawing.Point(557, 13)
        Me.txtPersonNo.Name = "txtPersonNo"
        Me.txtPersonNo.Size = New System.Drawing.Size(70, 23)
        Me.txtPersonNo.TabIndex = 11
        Me.txtPersonNo.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPersonal)
        Me.TabControl1.Controls.Add(Me.Others)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(24, 83)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 471)
        Me.TabControl1.TabIndex = 6
        '
        'tbPersonal
        '
        Me.tbPersonal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPersonal.Controls.Add(Me.txtPANNo)
        Me.tbPersonal.Controls.Add(Me.Label16)
        Me.tbPersonal.Controls.Add(Me.txtEmailId)
        Me.tbPersonal.Controls.Add(Me.Label15)
        Me.tbPersonal.Controls.Add(Me.txtOfficeNo)
        Me.tbPersonal.Controls.Add(Me.Label29)
        Me.tbPersonal.Controls.Add(Me.cmbStatus)
        Me.tbPersonal.Controls.Add(Me.Label11)
        Me.tbPersonal.Controls.Add(Me.txtEducation)
        Me.tbPersonal.Controls.Add(Me.Label38)
        Me.tbPersonal.Controls.Add(Me.Label13)
        Me.tbPersonal.Controls.Add(Me.txtOffAddress)
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
        Me.tbPersonal.Controls.Add(Me.txtPermAddress)
        Me.tbPersonal.Controls.Add(Me.Label14)
        Me.tbPersonal.Controls.Add(Me.txtPresAddress)
        Me.tbPersonal.Controls.Add(Me.rdbFemale)
        Me.tbPersonal.Controls.Add(Me.cmbOccupation)
        Me.tbPersonal.Controls.Add(Me.Label25)
        Me.tbPersonal.Controls.Add(Me.Label26)
        Me.tbPersonal.Controls.Add(Me.txtPhoneNo)
        Me.tbPersonal.Controls.Add(Me.txtMobileNo)
        Me.tbPersonal.Controls.Add(Me.dtpCreationDate)
        Me.tbPersonal.Controls.Add(Me.Label3)
        Me.tbPersonal.Controls.Add(Me.Label28)
        Me.tbPersonal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPersonal.ForeColor = System.Drawing.Color.Black
        Me.tbPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tbPersonal.Name = "tbPersonal"
        Me.tbPersonal.Size = New System.Drawing.Size(736, 442)
        Me.tbPersonal.TabIndex = 0
        Me.tbPersonal.Text = "Personal"
        '
        'txtPANNo
        '
        Me.txtPANNo.AlphaNumeric = True
        Me.txtPANNo.BlankSpace = False
        Me.txtPANNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPANNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPANNo.Location = New System.Drawing.Point(523, 333)
        Me.txtPANNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPANNo.Mandatory = False
        Me.txtPANNo.MaxLength = 20
        Me.txtPANNo.Name = "txtPANNo"
        Me.txtPANNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPANNo.SpecialChar = True
        Me.txtPANNo.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(395, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "PAN No : "
        '
        'txtEmailId
        '
        Me.txtEmailId.AlphaNumeric = True
        Me.txtEmailId.BlankSpace = False
        Me.txtEmailId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailId.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEmailId.Location = New System.Drawing.Point(523, 159)
        Me.txtEmailId.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtEmailId.Mandatory = False
        Me.txtEmailId.MaxLength = 99
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(184, 23)
        Me.txtEmailId.SpecialChar = True
        Me.txtEmailId.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(395, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Email ID : "
        '
        'txtOfficeNo
        '
        Me.txtOfficeNo.AfterDecimal = 0
        Me.txtOfficeNo.BeforeDecimal = 20
        Me.txtOfficeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOfficeNo.Location = New System.Drawing.Point(523, 269)
        Me.txtOfficeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOfficeNo.MaxLength = 20
        Me.txtOfficeNo.MaxValue = 0
        Me.txtOfficeNo.MinValue = 0
        Me.txtOfficeNo.Name = "txtOfficeNo"
        Me.txtOfficeNo.Size = New System.Drawing.Size(184, 23)
        Me.txtOfficeNo.TabIndex = 34
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(395, 301)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 16)
        Me.Label29.TabIndex = 35
        Me.Label29.Text = "Status : "
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "InActive", "Closed"})
        Me.cmbStatus.Location = New System.Drawing.Point(523, 301)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(184, 24)
        Me.cmbStatus.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(395, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Office No :"
        '
        'txtEducation
        '
        Me.txtEducation.AlphaNumeric = True
        Me.txtEducation.BlankSpace = False
        Me.txtEducation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEducation.Location = New System.Drawing.Point(523, 199)
        Me.txtEducation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEducation.Mandatory = False
        Me.txtEducation.MaxLength = 50
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(184, 23)
        Me.txtEducation.SpecialChar = True
        Me.txtEducation.TabIndex = 30
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(395, 199)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(89, 16)
        Me.Label38.TabIndex = 29
        Me.Label38.Text = "Education : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(395, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 16)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Office Address :"
        '
        'txtOffAddress
        '
        Me.txtOffAddress.AlphaNumeric = True
        Me.txtOffAddress.BlankSpace = True
        Me.txtOffAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOffAddress.Location = New System.Drawing.Point(523, 6)
        Me.txtOffAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOffAddress.Mandatory = False
        Me.txtOffAddress.MaxLength = 255
        Me.txtOffAddress.Multiline = True
        Me.txtOffAddress.Name = "txtOffAddress"
        Me.txtOffAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtOffAddress.SpecialChar = True
        Me.txtOffAddress.TabIndex = 22
        '
        'chkSame
        '
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(173, 306)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(216, 24)
        Me.chkSame.TabIndex = 18
        Me.chkSame.Text = "same as present address"
        '
        'cmbCaste
        '
        Me.cmbCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCaste.Location = New System.Drawing.Point(173, 198)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.Size = New System.Drawing.Size(184, 24)
        Me.cmbCaste.TabIndex = 15
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.Location = New System.Drawing.Point(173, 166)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(184, 24)
        Me.cmbReligion.TabIndex = 13
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(173, 134)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 10
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(173, 102)
        Me.txtAge.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(56, 23)
        Me.txtAge.TabIndex = 8
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Present Address :"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(173, 70)
        Me.dtpDOB.MaxDate = New Date(9998, 12, 19, 0, 0, 0, 0)
        Me.dtpDOB.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(176, 23)
        Me.dtpDOB.TabIndex = 6
        Me.dtpDOB.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Father /"
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = False
        Me.txtFatherName.BlankSpace = True
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(173, 38)
        Me.txtFatherName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 255
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(176, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date of Birth : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Gender :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Religion :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Caste :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(395, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Occupation :"
        '
        'txtPermAddress
        '
        Me.txtPermAddress.AlphaNumeric = True
        Me.txtPermAddress.BlankSpace = True
        Me.txtPermAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPermAddress.Location = New System.Drawing.Point(173, 341)
        Me.txtPermAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPermAddress.Mandatory = False
        Me.txtPermAddress.MaxLength = 255
        Me.txtPermAddress.Multiline = True
        Me.txtPermAddress.Name = "txtPermAddress"
        Me.txtPermAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPermAddress.SpecialChar = True
        Me.txtPermAddress.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Permanent Address : "
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.BlankSpace = True
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(173, 234)
        Me.txtPresAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 255
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(184, 64)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 17
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(255, 136)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 11
        Me.rdbFemale.Text = "Female"
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(523, 231)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 32
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(395, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 16)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Phone No :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(395, 95)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 16)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Mobile No :"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AlphaNumeric = True
        Me.txtPhoneNo.BlankSpace = False
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(523, 127)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPhoneNo.Mandatory = False
        Me.txtPhoneNo.MaxLength = 20
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 23)
        Me.txtPhoneNo.SpecialChar = True
        Me.txtPhoneNo.TabIndex = 26
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AlphaNumeric = True
        Me.txtMobileNo.BlankSpace = False
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(523, 95)
        Me.txtMobileNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtMobileNo.Mandatory = False
        Me.txtMobileNo.MaxLength = 20
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 23)
        Me.txtMobileNo.SpecialChar = True
        Me.txtMobileNo.TabIndex = 24
        '
        'dtpCreationDate
        '
        Me.dtpCreationDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpCreationDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCreationDate.Location = New System.Drawing.Point(173, 6)
        Me.dtpCreationDate.MaxDate = New Date(9998, 5, 24, 0, 0, 0, 0)
        Me.dtpCreationDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpCreationDate.Name = "dtpCreationDate"
        Me.dtpCreationDate.Size = New System.Drawing.Size(176, 23)
        Me.dtpCreationDate.TabIndex = 1
        Me.dtpCreationDate.Value = New Date(2010, 5, 20, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Creation Date  :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(13, 46)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 16)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Husband Name :  "
        '
        'Others
        '
        Me.Others.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Others.Controls.Add(Me.btnCancelSign)
        Me.Others.Controls.Add(Me.GroupBox4)
        Me.Others.Controls.Add(Me.btnLoadPhoto)
        Me.Others.Controls.Add(Me.picSignature)
        Me.Others.Controls.Add(Me.lblSignature)
        Me.Others.Controls.Add(Me.picPhoto)
        Me.Others.Controls.Add(Me.lblPhoto)
        Me.Others.Controls.Add(Me.btnCancelPhoto)
        Me.Others.Controls.Add(Me.btnLoadSign)
        Me.Others.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Others.Location = New System.Drawing.Point(4, 25)
        Me.Others.Name = "Others"
        Me.Others.Size = New System.Drawing.Size(736, 442)
        Me.Others.TabIndex = 1
        Me.Others.Text = "Others"
        '
        'btnCancelSign
        '
        Me.btnCancelSign.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancelSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSign.ForeColor = System.Drawing.Color.Black
        Me.btnCancelSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelSign.Location = New System.Drawing.Point(536, 192)
        Me.btnCancelSign.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnCancelSign.Name = "btnCancelSign"
        Me.btnCancelSign.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelSign.TabIndex = 5
        Me.btnCancelSign.Text = "Cancel"
        Me.btnCancelSign.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.txtRemark1)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 128)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(56, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 15)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Remarks : "
        '
        'txtRemark1
        '
        Me.txtRemark1.AlphaNumeric = True
        Me.txtRemark1.BlankSpace = True
        Me.txtRemark1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemark1.Location = New System.Drawing.Point(128, 32)
        Me.txtRemark1.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemark1.Mandatory = False
        Me.txtRemark1.MaxLength = 255
        Me.txtRemark1.Multiline = True
        Me.txtRemark1.Name = "txtRemark1"
        Me.txtRemark1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark1.Size = New System.Drawing.Size(480, 80)
        Me.txtRemark1.SpecialChar = True
        Me.txtRemark1.TabIndex = 1
        '
        'btnLoadPhoto
        '
        Me.btnLoadPhoto.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnLoadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadPhoto.Location = New System.Drawing.Point(136, 191)
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
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSignature.Location = New System.Drawing.Point(456, 24)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(160, 160)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 59
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(376, 24)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(87, 16)
        Me.lblSignature.TabIndex = 3
        Me.lblSignature.Text = "Signature : "
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto.Location = New System.Drawing.Point(136, 24)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 161)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 57
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(56, 24)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(62, 16)
        Me.lblPhoto.TabIndex = 0
        Me.lblPhoto.Text = "Photo : "
        '
        'btnCancelPhoto
        '
        Me.btnCancelPhoto.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancelPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPhoto.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelPhoto.Location = New System.Drawing.Point(216, 191)
        Me.btnCancelPhoto.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnCancelPhoto.Name = "btnCancelPhoto"
        Me.btnCancelPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btnCancelPhoto.TabIndex = 2
        Me.btnCancelPhoto.Text = "Cancel"
        Me.btnCancelPhoto.UseVisualStyleBackColor = False
        '
        'btnLoadSign
        '
        Me.btnLoadSign.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnLoadSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSign.ForeColor = System.Drawing.Color.Black
        Me.btnLoadSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoadSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadSign.Location = New System.Drawing.Point(456, 192)
        Me.btnLoadSign.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnLoadSign.Name = "btnLoadSign"
        Me.btnLoadSign.Size = New System.Drawing.Size(80, 32)
        Me.btnLoadSign.TabIndex = 4
        Me.btnLoadSign.Text = "Load"
        Me.btnLoadSign.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(472, 53)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 255
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(664, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(552, 560)
        Me.btnSave.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer ID :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AlphaNumeric = True
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustomerID.BlankSpace = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCustomerID.Location = New System.Drawing.Point(192, 53)
        Me.txtCustomerID.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCustomerID.Mandatory = False
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(128, 23)
        Me.txtCustomerID.SpecialChar = True
        Me.txtCustomerID.TabIndex = 3
        Me.txtCustomerID.Text = "CID"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(328, 53)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(32, 560)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Reset"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(157, 23)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Customer Master"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCustomer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1016, 629)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCustomer"
        Me.ShowInTaskbar = False
        Me.Text = "Customer Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbPersonal.ResumeLayout(False)
        Me.tbPersonal.PerformLayout()
        Me.Others.ResumeLayout(False)
        Me.Others.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Global Variables"

    Dim objPerson As New clsPerson
    Dim lngPersonNo As Long = 0

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCustomer
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCustomer
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCustomer
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCustomer)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "User Definde Methods"

    'To check data entered by the User, function called when "OK" button is clicked 
    Function fnCheck() As Boolean
        If txtCustomerID.Text = "" Then
            MsgBox("Enter customer ID", MsgBoxStyle.Exclamation)
            txtCustomerID.Focus()
            Return False
        ElseIf txtName.Text = "" Then
            MsgBox("Enter name", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
        ElseIf txtFatherName.Text = "" Then
            MsgBox("Enter father name ", MsgBoxStyle.Exclamation)
            txtFatherName.Focus()
            Return False
        ElseIf Convert.ToString(dtpDOB.Value) = "" Then
            MsgBox("Enter date of birth ", MsgBoxStyle.Exclamation)
            dtpDOB.Focus()
            Return False
        ElseIf Val(txtAge.Text) <= 0 Then
            MsgBox("Please enter age and it should be greater than zero", MsgBoxStyle.Exclamation)
            txtAge.Focus()
            Return False
        ElseIf txtPresAddress.Text = "" Then
            MsgBox("Enter address", MsgBoxStyle.Exclamation)
            txtPermAddress.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'To set form control values to Class Properties, function called when "OK" button is clicked
    Function fnSetData() As Boolean

        If lngPersonNo <> 0 Then
            objPerson.PersonNo = lngPersonNo
        Else
            objPerson.PersonNo = objPerson.fnGetNewPersonNo()
        End If

        objPerson.Name = txtName.Text
        objPerson.CustomerID = txtCustomerID.Text
        objPerson.FatherName = txtFatherName.Text
        objPerson.DOB = dtpDOB.Value
        objPerson.CreationDate = dtpCreationDate.Value

        objPerson.Age = txtAge.Text
        objPerson.AgeStatus = IIf(Val(txtAge.Text) >= 18, "M", "N")
        objPerson.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objPerson.ReligionCode = cmbReligion.SelectedValue
        objPerson.CasteCode = cmbCaste.SelectedValue
        objPerson.PermAddress = txtPermAddress.Text
        objPerson.PresAddress = txtPresAddress.Text
        objPerson.PhoneNo = txtPhoneNo.Text
        objPerson.MobileNo = txtMobileNo.Text
        objPerson.Education = txtEducation.Text
        objPerson.OccupationCode = cmbOccupation.SelectedValue
        objPerson.OffAddress = txtOffAddress.Text
        objPerson.OfficeNo = txtOfficeNo.Text


        Select Case (cmbStatus.Text)
            Case "Active"
                objPerson.CustomerStatus = "A"
            Case "InActive"
                objPerson.CustomerStatus = "I"
            Case "Closed"
                objPerson.CustomerStatus = "C"
        End Select

        ' objPerson.Photo = fnGetPhoto()
        objPerson.Photo = picPhoto.ImageLocation


        ' objPerson.Sign = fnGetSign()
        objPerson.Sign = picSignature.ImageLocation

        objPerson.Remarks = txtRemark1.Text
        objPerson.EmailId = txtEmailId.Text
        objPerson.PANNo = txtPANNo.Text
        Return True
    End Function

    'To clear form control values
    Sub sbClear()
        lngPersonNo = 0
        txtCustomerID.Text = "CID"
        txtCustomerID.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpCreationDate.Enabled = True
        rdbMale.Checked = True
        txtAge.ResetText()
        txtPersonNo.ResetText()
        ' cmbReligion.SelectedIndex = 0  'commented for testing
        ' cmbCaste.SelectedIndex = 0
        ' cmbOccupation.SelectedIndex = 0
        ' cmbStatus.SelectedIndex = 0
        cmbStatus.Enabled = True
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()

        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtEducation.ResetText()
        txtOffAddress.ResetText()
        txtRemark1.ResetText()
        txtOfficeNo.ResetText()
        txtEmailId.ResetText()
        txtPANNo.ResetText()

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
        Dim emptyStr As String



        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If (objPerson.fnGetCustomerID(txtCustomerID.Text)) Then
                sbClear()

                objDT = objPerson.PersonTable

                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                txtPersonNo.Text = lngPersonNo
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtName.Text = objDT.Rows(0).Item("Name")

                'dtpApplDate.Value = CDate(objDT.Rows(0).Item("ApplDate"))
                'dtpApplDate.Enabled = False

                txtFatherName.Text = objDT.Rows(0).Item("FatherName")

                txtEmailId.Text = Convert.ToString(objDT.Rows(0).Item("EmailId"))

                txtPANNo.Text = Convert.ToString(objDT.Rows(0).Item("PANNo"))






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
                dtpCreationDate.Value = Date.Now
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")
                txtEducation.Text = objDT.Rows(0).Item("Education")
                txtOffAddress.Text = objDT.Rows(0).Item("OfficeAddress")
                txtOfficeNo.Text = objDT.Rows(0).Item("OfficeNo")
                txtRemark1.Text = objDT.Rows(0).Item("Remarks")
                dtpCreationDate.Value = CDate(objDT.Rows(0).Item("CreationDate"))


                Select Case (objDT.Rows(0).Item("OfficeNo"))
                    Case "A"
                        cmbStatus.SelectedItem = "Active"
                    Case "I"
                        cmbStatus.SelectedItem = "InActive"
                    Case "C"
                        cmbStatus.SelectedItem = "Closed"
                End Select


                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        ' msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        '  msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        ' picPhoto.Image = Image.FromStream(msStream)
                        picPhoto.Image = Image.FromFile(objDT.Rows(0).Item("Photo"))
                        picPhoto.ImageLocation = objDT.Rows(0).Item("Photo")
                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        'msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        'msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        ''msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        ''picSignature.Image = Image.FromStream(msStream)                        
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

    'To SAVE data to table, ADD or UPDATE data
    Function fnSaveData() As Boolean

        'Check for Customer Existance

        '''If objPerson.fnCheckCustomer = False Then

        If objPerson.fnCheckCustomerID = True And objPerson.fnCheckCustomer = True Then
            'ADD new Customer  (ADD Mode)
            ' ''If objPerson.fnAddPerson() Then

            ' ''    fnLogEntry(pbUserId, "New customer" & txtCustomerID.Text & " created", Date.Now, "New customer")
            ' ''    MessageBox.Show("New customer added successfully.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            ' ''    Return True
            ' ''Else
            ' ''    MessageBox.Show("New customer addition failed, because of internal error.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            ' ''    Return False
            ' ''End If

            If objPerson.fnUpdatePersonWRTCustomer Then
                fnLogEntry(pbUserId, "customer " & txtCustomerID.Text & "details updated", Date.Now, "updated customer")
                MessageBox.Show("Customer updated successfully.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                Return True
            Else
                MessageBox.Show("Customrt updation failed, because of internal error.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        ElseIf objPerson.fnCheckCustomer = False Then
            'Update Details (EDIT Mode)

            If objPerson.fnAddPerson() Then

                fnLogEntry(pbUserId, "New customer" & txtCustomerID.Text & " created", Date.Now, "New customer")
                MessageBox.Show("New customer added successfully.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New customer addition failed, because of internal error.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else
            MessageBox.Show("Customer already exist", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Return False
            ' ''If objPerson.fnUpdatePersonWRTCustomer Then
            ' ''    fnLogEntry(pbUserId, "customer " & txtCustomerID.Text & "details updated", Date.Now, "updated customer")
            ' ''    MessageBox.Show("Customer updated successfully.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

            ' ''    Return True
            ' ''Else
            ' ''    MessageBox.Show("Customrt updation failed, because of internal error.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            ' ''    Return False
            ' ''End If

        End If
        '' ''Else
        '' ''    MessageBox.Show("Customer already exist", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        '' ''    Return False
        '' ''End If

    End Function

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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If fnCheck() Then
            If fnSetData() Then
                If fnSaveData() Then
                    If MsgBox("You want to add another customer?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "confirm addition") = MsgBoxResult.Yes Then
                        txtPersonNo.ResetText()
                        btnAdd_Click(sender, e)
                    Else
                        Me.Close()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnLoadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPhoto.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
                picPhoto.ImageLocation = OpenFileDialog1.FileName
                picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnCancelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPhoto.Click
        picPhoto.Image = Nothing
        picPhoto.ImageLocation = Nothing
    End Sub

    Private Sub btnLoadSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSign.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picSignature.Image = Image.FromFile(OpenFileDialog1.FileName)
                picSignature.ImageLocation = OpenFileDialog1.FileName

                picSignature.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnCancelSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSign.Click
        picSignature.Image = Nothing
        picSignature.ImageLocation = Nothing
    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'dtpDOB.MaxDate = Date.Now
        'dtpCreationDate.MaxDate = Date.Now
        dtpCreationDate.Value = Date.Now
        cmbStatus.SelectedItem = "Active"
        sbLoadControlValues()

        If txtCustomerID.Text <> "CID" Then
            sbLoadCustomer()
        Else
            btnAdd_Click(sender, e)
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        nMode = CTAdd
        sbClear()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objPerson.fnGetNewCustomerID, 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "CID" & String.Format("{0:00000}", CInt(TempNewNo))
            txtCustomerID.Text = Temp
            txtCustomerID.Focus()
        Else
            MsgBox("Customer ID exceeds the maximum alloted number", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtCustomerID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerID.LostFocus
        If txtCustomerID.Text <> "CID" Then
            sbLoadCustomer()
        Else
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        If chkSame.Checked = True Then
            txtPermAddress.Text = txtPresAddress.Text
        Else
            txtPermAddress.ResetText()
        End If
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objPerson As New clsPerson
        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            txtCustomerID.Text = objCustomerList.strCustomerID
            ' txtPersonNo.Text =
            sbLoadCustomer()
        End If
        objCustomerList.Dispose()
    End Sub

    Private Sub txtCustomerID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged
        If Not txtCustomerID.Text.StartsWith("CID") Then
            txtCustomerID.Undo()
            txtCustomerID.ClearUndo()
        End If
    End Sub

    Private Sub Others_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Others.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPresAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPresAddress.TextChanged
        If chkSame.Checked = True Then
            txtPermAddress.Text = txtPresAddress.Text
        End If
    End Sub


    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged

    End Sub
End Class

