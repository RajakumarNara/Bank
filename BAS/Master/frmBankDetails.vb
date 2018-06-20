Public Class frmBankDetails
    Inherits System.Windows.Forms.Form

    Dim objBank As New clsBank

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpRegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents txtAddress As BankControls.TextControl
    Friend WithEvents txtPhoneNo1 As BankControls.TextControl
    Friend WithEvents txtPhoneNo2 As BankControls.TextControl
    Friend WithEvents txtKSTNo As BankControls.TextControl
    Friend WithEvents txtCSTNo As BankControls.TextControl
    Friend WithEvents txtRegNo As BankControls.TextControl
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReportHeader As BankControls.TextControl
    Friend WithEvents txtRepSubHeader As BankControls.TextControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtManager As BankControls.TextControl
    Friend WithEvents txtPresident As BankControls.TextControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpFinancialStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtWebsite As BankControls.TextControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEmailID As BankControls.TextControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpFinancialEnd As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankDetails))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWebsite = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtEmailID = New BankControls.TextControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpFinancialEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpFinancialStart = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnOk = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.dtpRegDate = New System.Windows.Forms.DateTimePicker
        Me.txtBankName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAddress = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPhoneNo1 = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPhoneNo2 = New BankControls.TextControl
        Me.txtKSTNo = New BankControls.TextControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCSTNo = New BankControls.TextControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRegNo = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtReportHeader = New BankControls.TextControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRepSubHeader = New BankControls.TextControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtManager = New BankControls.TextControl
        Me.txtPresident = New BankControls.TextControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWebsite)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtEmailID)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpFinancialEnd)
        Me.GroupBox1.Controls.Add(Me.dtpFinancialStart)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.dtpRegDate)
        Me.GroupBox1.Controls.Add(Me.txtBankName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNo2)
        Me.GroupBox1.Controls.Add(Me.txtKSTNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCSTNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRegNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtReportHeader)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtRepSubHeader)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtManager)
        Me.GroupBox1.Controls.Add(Me.txtPresident)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(232, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 624)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtWebsite
        '
        Me.txtWebsite.AlphaNumeric = True
        Me.txtWebsite.BlankSpace = True
        Me.txtWebsite.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsite.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtWebsite.Location = New System.Drawing.Point(200, 395)
        Me.txtWebsite.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtWebsite.Mandatory = False
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(408, 23)
        Me.txtWebsite.SpecialChar = True
        Me.txtWebsite.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label17.Location = New System.Drawing.Point(32, 395)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 16)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Website :  "
        '
        'txtEmailID
        '
        Me.txtEmailID.AlphaNumeric = True
        Me.txtEmailID.BlankSpace = True
        Me.txtEmailID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEmailID.Location = New System.Drawing.Point(200, 360)
        Me.txtEmailID.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtEmailID.Mandatory = False
        Me.txtEmailID.Name = "txtEmailID"
        Me.txtEmailID.Size = New System.Drawing.Size(200, 23)
        Me.txtEmailID.SpecialChar = True
        Me.txtEmailID.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label15.Location = New System.Drawing.Point(32, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Email ID :  "
        '
        'dtpFinancialEnd
        '
        Me.dtpFinancialEnd.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFinancialEnd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinancialEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFinancialEnd.Location = New System.Drawing.Point(200, 328)
        Me.dtpFinancialEnd.Name = "dtpFinancialEnd"
        Me.dtpFinancialEnd.Size = New System.Drawing.Size(200, 23)
        Me.dtpFinancialEnd.TabIndex = 17
        '
        'dtpFinancialStart
        '
        Me.dtpFinancialStart.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFinancialStart.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinancialStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFinancialStart.Location = New System.Drawing.Point(200, 296)
        Me.dtpFinancialStart.Name = "dtpFinancialStart"
        Me.dtpFinancialStart.Size = New System.Drawing.Size(200, 23)
        Me.dtpFinancialStart.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label16.Location = New System.Drawing.Point(32, 328)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Financial End Date :   "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label14.Location = New System.Drawing.Point(32, 296)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(166, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Financial Start Date :   "
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(544, 568)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "O&k"
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
        Me.btnClose.Location = New System.Drawing.Point(648, 568)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        '
        'dtpRegDate
        '
        Me.dtpRegDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpRegDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegDate.Location = New System.Drawing.Point(512, 224)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpRegDate.TabIndex = 7
        Me.dtpRegDate.Visible = False
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(200, 88)
        Me.txtBankName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBankName.Mandatory = False
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(560, 23)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(32, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bank Name :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 23)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Bank Details"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(32, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Address :"
        '
        'txtAddress
        '
        Me.txtAddress.AlphaNumeric = True
        Me.txtAddress.BlankSpace = True
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAddress.Location = New System.Drawing.Point(200, 128)
        Me.txtAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAddress.Mandatory = False
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(312, 88)
        Me.txtAddress.SpecialChar = True
        Me.txtAddress.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(32, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Phone No1 :"
        '
        'txtPhoneNo1
        '
        Me.txtPhoneNo1.AlphaNumeric = True
        Me.txtPhoneNo1.BlankSpace = True
        Me.txtPhoneNo1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo1.Location = New System.Drawing.Point(200, 232)
        Me.txtPhoneNo1.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPhoneNo1.Mandatory = False
        Me.txtPhoneNo1.Name = "txtPhoneNo1"
        Me.txtPhoneNo1.Size = New System.Drawing.Size(200, 23)
        Me.txtPhoneNo1.SpecialChar = True
        Me.txtPhoneNo1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(32, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Phone No2 :"
        '
        'txtPhoneNo2
        '
        Me.txtPhoneNo2.AlphaNumeric = True
        Me.txtPhoneNo2.BlankSpace = True
        Me.txtPhoneNo2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo2.Location = New System.Drawing.Point(200, 264)
        Me.txtPhoneNo2.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPhoneNo2.Mandatory = False
        Me.txtPhoneNo2.Name = "txtPhoneNo2"
        Me.txtPhoneNo2.Size = New System.Drawing.Size(200, 23)
        Me.txtPhoneNo2.SpecialChar = True
        Me.txtPhoneNo2.TabIndex = 3
        '
        'txtKSTNo
        '
        Me.txtKSTNo.AlphaNumeric = True
        Me.txtKSTNo.BlankSpace = True
        Me.txtKSTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKSTNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtKSTNo.Location = New System.Drawing.Point(512, 128)
        Me.txtKSTNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtKSTNo.Mandatory = False
        Me.txtKSTNo.Name = "txtKSTNo"
        Me.txtKSTNo.Size = New System.Drawing.Size(200, 23)
        Me.txtKSTNo.SpecialChar = True
        Me.txtKSTNo.TabIndex = 4
        Me.txtKSTNo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(416, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "KST No :"
        Me.Label5.Visible = False
        '
        'txtCSTNo
        '
        Me.txtCSTNo.AlphaNumeric = True
        Me.txtCSTNo.BlankSpace = True
        Me.txtCSTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSTNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCSTNo.Location = New System.Drawing.Point(512, 160)
        Me.txtCSTNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCSTNo.Mandatory = False
        Me.txtCSTNo.Name = "txtCSTNo"
        Me.txtCSTNo.Size = New System.Drawing.Size(200, 23)
        Me.txtCSTNo.SpecialChar = True
        Me.txtCSTNo.TabIndex = 5
        Me.txtCSTNo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(416, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CST No :"
        Me.Label6.Visible = False
        '
        'txtRegNo
        '
        Me.txtRegNo.AlphaNumeric = True
        Me.txtRegNo.BlankSpace = True
        Me.txtRegNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRegNo.Location = New System.Drawing.Point(512, 192)
        Me.txtRegNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRegNo.Mandatory = False
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(200, 23)
        Me.txtRegNo.SpecialChar = True
        Me.txtRegNo.TabIndex = 6
        Me.txtRegNo.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(416, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reg No :"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(416, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Reg Date :"
        Me.Label8.Visible = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(512, 256)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpStartDate.TabIndex = 8
        Me.dtpStartDate.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(416, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Start Date :"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Location = New System.Drawing.Point(32, 430)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Report Header :"
        Me.Label10.Visible = False
        '
        'txtReportHeader
        '
        Me.txtReportHeader.AlphaNumeric = True
        Me.txtReportHeader.BlankSpace = True
        Me.txtReportHeader.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportHeader.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReportHeader.Location = New System.Drawing.Point(200, 430)
        Me.txtReportHeader.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReportHeader.Mandatory = False
        Me.txtReportHeader.Name = "txtReportHeader"
        Me.txtReportHeader.Size = New System.Drawing.Size(560, 23)
        Me.txtReportHeader.SpecialChar = True
        Me.txtReportHeader.TabIndex = 9
        Me.txtReportHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtReportHeader.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(32, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Sub Header :"
        Me.Label11.Visible = False
        '
        'txtRepSubHeader
        '
        Me.txtRepSubHeader.AlphaNumeric = True
        Me.txtRepSubHeader.BlankSpace = True
        Me.txtRepSubHeader.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepSubHeader.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRepSubHeader.Location = New System.Drawing.Point(200, 457)
        Me.txtRepSubHeader.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRepSubHeader.Mandatory = False
        Me.txtRepSubHeader.Name = "txtRepSubHeader"
        Me.txtRepSubHeader.Size = New System.Drawing.Size(560, 23)
        Me.txtRepSubHeader.SpecialChar = True
        Me.txtRepSubHeader.TabIndex = 10
        Me.txtRepSubHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRepSubHeader.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label12.Location = New System.Drawing.Point(32, 512)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Manager:"
        Me.Label12.Visible = False
        '
        'txtManager
        '
        Me.txtManager.AlphaNumeric = True
        Me.txtManager.BlankSpace = True
        Me.txtManager.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManager.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtManager.Location = New System.Drawing.Point(200, 512)
        Me.txtManager.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtManager.Mandatory = False
        Me.txtManager.Name = "txtManager"
        Me.txtManager.Size = New System.Drawing.Size(408, 23)
        Me.txtManager.SpecialChar = True
        Me.txtManager.TabIndex = 10
        Me.txtManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtManager.Visible = False
        '
        'txtPresident
        '
        Me.txtPresident.AlphaNumeric = True
        Me.txtPresident.BlankSpace = True
        Me.txtPresident.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresident.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPresident.Location = New System.Drawing.Point(200, 484)
        Me.txtPresident.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPresident.Mandatory = False
        Me.txtPresident.Name = "txtPresident"
        Me.txtPresident.Size = New System.Drawing.Size(408, 23)
        Me.txtPresident.SpecialChar = True
        Me.txtPresident.TabIndex = 10
        Me.txtPresident.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPresident.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label13.Location = New System.Drawing.Point(32, 484)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "President:"
        Me.Label13.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 624)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'frmBankDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBankDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmBankDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmBankDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmBankDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmBankDetails)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region


    Function fnCheck() As Boolean
        If Trim(txtBankName.Text) = "" Then
            MsgBox("Bank name can not be blank ", MsgBoxStyle.Information, Me.Text)
            txtBankName.Focus()
            Return False
        ElseIf Trim(txtAddress.Text) = "" Then
            MsgBox("Bank address can not be blank ", MsgBoxStyle.Information, Me.Text)
            txtAddress.Focus()
            Return False
        ElseIf dtpFinancialStart.Value > dtpFinancialEnd.Value Then
            MsgBox("Financial End Date should be greater then Financial Start Date", MsgBoxStyle.OkOnly)
        Else
            Return True
        End If

    End Function

    Function fnSetData() As Boolean
        objBank.BankName = txtBankName.Text
        objBank.Address = txtAddress.Text
        objBank.PhoneNo1 = txtPhoneNo1.Text
        objBank.PhoneNo2 = txtPhoneNo2.Text
        objBank.FinancialStart = dtpFinancialStart.Value
        objBank.FinancialEnd = dtpFinancialEnd.Value
        objBank.EmailId = txtEmailID.Text
        objBank.Website = txtWebsite.Text
        'objBank.KSTNo = txtKSTNo.Text
        'objBank.CSTNo = txtCSTNo.Text
        'objBank.RegNo = txtRegNo.Text
        'objBank.RegDate = dtpRegDate.Value
        'objBank.StartDate = dtpStartDate.Value
        'objBank.ReportHeader = txtReportHeader.Text
        'objBank.ReportSubHeader = txtRepSubHeader.Text
        'objBank.president = txtPresident.Text
        'objBank.Manager = txtManager.Text
        Return True
    End Function

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmBankDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbChangeFont(txtReportHeader)
        sbChangeFont(txtRepSubHeader)
        sbChangeFont(txtPresident)
        sbChangeFont(txtManager)
        Dim objDT As DataTable
        If objBank.fnGetBankDetails Then
            objDT = objBank.BankTable
            If objDT.Rows.Count > 0 Then
                txtBankName.Text = objDT.Rows(0).Item("BankName")
                txtAddress.Text = objDT.Rows(0).Item("Address")
                txtPhoneNo1.Text = objDT.Rows(0).Item("PhoneNo1")
                txtPhoneNo2.Text = objDT.Rows(0).Item("PhoneNo2")
                dtpFinancialStart.Value = CDate(objDT.Rows(0).Item("FinancialStart"))
                dtpFinancialEnd.Value = CDate(objDT.Rows(0).Item("FinancialEnd"))
                txtEmailID.Text = objDT.Rows(0).Item("EmailId")
                txtWebsite.Text = objDT.Rows(0).Item("Website")
                'txtKSTNo.Text = objDT.Rows(0).Item("KSTNo")
                'txtCSTNo.Text = objDT.Rows(0).Item("CSTNo")
                'txtRegNo.Text = objDT.Rows(0).Item("RegNo")
                'dtpRegDate.Value = objDT.Rows(0).Item("RegDate")
                'dtpStartDate.Value = objDT.Rows(0).Item("StartDate")
                'txtReportHeader.Text = objDT.Rows(0).Item("RepHeader")
                'txtRepSubHeader.Text = objDT.Rows(0).Item("RepSubHeader")
                'txtPresident.Text = objDT.Rows(0).Item("President")
                'txtManager.Text = objDT.Rows(0).Item("Manager")
            End If
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If fnCheck() Then
            If fnSetData() Then
                If objBank.fnGetBankDetails Then
                    If objBank.fnUpdateBankDetails Then
                        MsgBox("Details updated successfully", MsgBoxStyle.Information, Me.Text)
                    End If
                Else
                    If objBank.fnInsertBankDetails Then
                        MsgBox("Details updated successfully", MsgBoxStyle.Information, Me.Text)
                    End If
                End If
            End If
        End If
    End Sub
End Class
