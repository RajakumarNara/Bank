Public Class frmPigmyAgent
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPresAddress As BankControls.TextControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As BankControls.NumericControl
    Friend WithEvents txtMobileNo As BankControls.NumericControl
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtAgentNo As BankControls.TextControl
    Friend WithEvents txtAgentName As BankControls.TextControl
    Friend WithEvents txtPremAddress As BankControls.TextControl
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPigmyAgent))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAgentNo = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAgentName = New BankControls.TextControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPresAddress = New BankControls.TextControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAge = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtPhoneNo = New BankControls.NumericControl
        Me.txtMobileNo = New BankControls.NumericControl
        Me.chkSame = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPremAddress = New BankControls.TextControl
        Me.btnAdd = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnSearch = New BankControls.NewButton
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AgentNo. :"
        '
        'txtAgentNo
        '
        Me.txtAgentNo.AlphaNumeric = True
        Me.txtAgentNo.BlankSpace = False
        Me.txtAgentNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAgentNo.Location = New System.Drawing.Point(128, 32)
        Me.txtAgentNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAgentNo.Mandatory = False
        Me.txtAgentNo.MaxLength = 10
        Me.txtAgentNo.Name = "txtAgentNo"
        Me.txtAgentNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAgentNo.SpecialChar = False
        Me.txtAgentNo.TabIndex = 1
        Me.txtAgentNo.Text = "AG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AgentName : "
        '
        'txtAgentName
        '
        Me.txtAgentName.AlphaNumeric = True
        Me.txtAgentName.BlankSpace = False
        Me.txtAgentName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAgentName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtAgentName.Location = New System.Drawing.Point(448, 32)
        Me.txtAgentName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAgentName.Mandatory = False
        Me.txtAgentName.MaxLength = 20
        Me.txtAgentName.Name = "txtAgentName"
        Me.txtAgentName.Size = New System.Drawing.Size(168, 23)
        Me.txtAgentName.SpecialChar = True
        Me.txtAgentName.TabIndex = 3
        Me.txtAgentName.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(296, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 19)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Present Address :"
        '
        'txtPresAddress
        '
        Me.txtPresAddress.AlphaNumeric = True
        Me.txtPresAddress.AutoSize = False
        Me.txtPresAddress.BlankSpace = False
        Me.txtPresAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresAddress.Location = New System.Drawing.Point(432, 24)
        Me.txtPresAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPresAddress.Mandatory = False
        Me.txtPresAddress.MaxLength = 200
        Me.txtPresAddress.Multiline = True
        Me.txtPresAddress.Name = "txtPresAddress"
        Me.txtPresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresAddress.Size = New System.Drawing.Size(192, 80)
        Me.txtPresAddress.SpecialChar = True
        Me.txtPresAddress.TabIndex = 11
        Me.txtPresAddress.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(112, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
        Me.Panel2.TabIndex = 8
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 7)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(112, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 32)
        Me.Panel3.TabIndex = 7
        '
        'rdbMajor
        '
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(8, 7)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 0
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'rdbMinor
        '
        Me.rdbMinor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(88, 7)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 1
        Me.rdbMinor.Text = "Minor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 19)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Age Status :  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Age :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Gender :"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 2
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(112, 64)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 23)
        Me.txtAge.TabIndex = 6
        Me.txtAge.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date Of Birth :"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(112, 24)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(144, 23)
        Me.dtpDOB.TabIndex = 5
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.txtPhoneNo)
        Me.Panel1.Controls.Add(Me.txtMobileNo)
        Me.Panel1.Controls.Add(Me.chkSame)
        Me.Panel1.Controls.Add(Me.dtpDOB)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtPresAddress)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPremAddress)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(16, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 264)
        Me.Panel1.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 184)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 19)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "Phone No. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 216)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 19)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Mobile No. :"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(112, 184)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(168, 23)
        Me.txtPhoneNo.TabIndex = 9
        Me.txtPhoneNo.Text = ""
        '
        'txtMobileNo
        '
        Me.txtMobileNo.AfterDecimal = 0
        Me.txtMobileNo.BeforeDecimal = 10
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMobileNo.Location = New System.Drawing.Point(112, 216)
        Me.txtMobileNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.MaxValue = 0
        Me.txtMobileNo.MinValue = 0
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(168, 23)
        Me.txtMobileNo.TabIndex = 10
        Me.txtMobileNo.Text = ""
        '
        'chkSame
        '
        Me.chkSame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSame.Location = New System.Drawing.Point(448, 120)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(160, 16)
        Me.chkSame.TabIndex = 12
        Me.chkSame.Text = "Same As Above"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Premenent Address "
        '
        'txtPremAddress
        '
        Me.txtPremAddress.AlphaNumeric = True
        Me.txtPremAddress.AutoSize = False
        Me.txtPremAddress.BlankSpace = False
        Me.txtPremAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPremAddress.Location = New System.Drawing.Point(432, 152)
        Me.txtPremAddress.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPremAddress.Mandatory = False
        Me.txtPremAddress.MaxLength = 200
        Me.txtPremAddress.Multiline = True
        Me.txtPremAddress.Name = "txtPremAddress"
        Me.txtPremAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPremAddress.Size = New System.Drawing.Size(192, 80)
        Me.txtPremAddress.SpecialChar = True
        Me.txtPremAddress.TabIndex = 13
        Me.txtPremAddress.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.Beige
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(16, 352)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 40)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Reset"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.Beige
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(448, 352)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 40)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(544, 352)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Cancel"
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
        Me.btnSearch.Location = New System.Drawing.Point(272, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.SeaShell
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'frmPigmyAgent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(666, 404)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAgentNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAgentName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPigmyAgent"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BNN Agent"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objClsPigmyAgent As New clsPigmyAgent

#End Region

#Region "Events"


#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If txtAgentNo.Text = "AG" Then
            MsgBox("Please enter the agent no")
            txtAgentNo.Focus()
            Return False
        ElseIf txtAgentName.Text = String.Empty Then
            MsgBox("Please enter the agent name")
            txtAgentName.Focus()
            Return False
        ElseIf txtAge.Text = String.Empty Then
            MsgBox("Please enter the agents age")
            txtAge.Focus()
            Return False
        ElseIf txtPresAddress.Text = String.Empty Then
            MsgBox("Please enter address")
            txtPresAddress.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnSetData() As Boolean

        With objClsPigmyAgent

            .AgentAge = Val(txtAge.Text)
            .AgentNo = txtAgentNo.Text
            .AgentName = txtAgentName.Text
            .AgentDOB = Format(dtpDOB.Value, "yyyy-MM-dd")
            .AgentMobNo = Val(txtMobileNo.Text)
            .AgentContNo = Val(txtPhoneNo.Text)
            .AgentPremAddr = txtPremAddress.Text
            .AgentPresAddr = txtPresAddress.Text
            .AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
            .Gender = IIf(rdbMale.Checked = True, "M", "F")

            Return True

        End With

    End Function

    Public Function fnSaveData() As Boolean

        If objClsPigmyAgent.fnCheckAgent(txtAgentNo.Text) Then
            If objClsPigmyAgent.fnUpdateAgent(txtAgentNo.Text) Then
                MsgBox("Agent's account updated successfully", MsgBoxStyle.Information)
                Return True
            Else
                MsgBox("Internal error !!New agent's cannot be updated ", MsgBoxStyle.Exclamation)
                Return False
            End If
        Else
            If objClsPigmyAgent.fnInsertData Then
                MsgBox("New agent's account created sucessfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function fnGetData() As Boolean

        If objClsPigmyAgent.fnCheckAgent(txtAgentNo.Text) Then

            txtAge.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("Age")
            txtAgentName.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("AgentName")
            txtMobileNo.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("MobileNo")
            txtAge.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("Age")
            txtPhoneNo.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("PhoneNo")
            txtPremAddress.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("PremAddress")
            txtPresAddress.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("PremAddress")


        End If

    End Function

#End Region

#Region "Procedures"

    Sub sbClearData()

        txtAgentNo.Text = "AG"
        txtAgentName.ResetText()
        txtMobileNo.ResetText()
        txtPhoneNo.ResetText()
        txtAge.ResetText()
        txtPremAddress.ResetText()
        txtPresAddress.ResetText()
        chkSame.Checked = False

    End Sub

#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If fnCheck() Then
            If fnSetData() Then
                If fnSaveData() Then
                    If MsgBox("You want to add another Agent?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
                        btnAdd_Click(sender, e)
                    Else

                        Me.Close()

                    End If
                End If
            Else
                : MsgBox("Internal error! failed to create agent's account", MsgBoxStyle.Exclamation)

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbClearData()
        nMode = CTAdd

        'txtAccNo.Text = "RD"

        '  txtYears.Enabled = True
        '   txtMonths.Enabled = True
        '  txtDays.Enabled = True

        Dim Temp As String
        Dim TempNewNo As String = Mid(objClsPigmyAgent.fnGetAgentNo(), 3, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "AG" & String.Format("{0:00000}", CInt(TempNewNo))
            txtAgentNo.Text = Temp
            txtAgentNo.Focus()
        Else
            MsgBox("Agent number exceeds the maximum alloted number", MsgBoxStyle.Information, "Recurring Deposit Module")
        End If

    End Sub

    Private Sub txtAgentNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgentNo.TextChanged
        If txtAgentNo.Text.StartsWith("AG") = False Then
            txtAgentNo.Undo()
            txtAgentNo.ClearUndo()
        End If
    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged
        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objAGSearch As New frmAGAccSearch
        objAGSearch.ShowDialog()
        If objAGSearch.strAGAccountNo <> String.Empty Then
            txtAgentNo.Text = objAGSearch.strAGAccountNo
            fnGetData()
        End If
        objAGSearch.Dispose()

    End Sub

    Private Sub frmPigmyAgent_Activated(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles MyBase.Activated
        fnGetData()
    End Sub

    Private Sub chkSame_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        txtPresAddress_TextChanged(Me, e.Empty)
    End Sub

    Private Sub txtPresAddress_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPresAddress.TextChanged
        If chkSame.Checked = True Then
            txtPremAddress.Text = txtPresAddress.Text
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub frmPigmyAgent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = Date.Now
        dtpDOB.Value = Date.Now
        txtAgentNo.Focus()
        If txtAgentNo.Text <> "AG" Then
            fnGetData()
        Else
            btnAdd_Click(sender, e)
        End If
    End Sub
End Class
