<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentVoucher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentVoucher))
        Me.Lbl_PaymentAmount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_Name = New System.Windows.Forms.TextBox()
        Me.Cmd_StaffId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_StaffId = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_PaymentAmount = New BankControls.NumericControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New BankControls.NumericControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnShow = New BankControls.NewButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMemberNo = New BankControls.TextControl()
        Me.txtName = New BankControls.TextControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_BankName = New System.Windows.Forms.Label()
        Me.Cmd_BankList = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_VoucherType = New System.Windows.Forms.Label()
        Me.Cmb_VoucherType = New System.Windows.Forms.ComboBox()
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNarration = New BankControls.TextControl()
        Me.txtRefno = New BankControls.NumericControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReceipt = New BankControls.NewButton()
        Me.btnSave = New BankControls.NewButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnTransfer = New BankControls.NewButton()
        Me.btnCancel = New BankControls.NewButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_PaymentAmount
        '
        Me.Lbl_PaymentAmount.AutoSize = True
        Me.Lbl_PaymentAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PaymentAmount.Location = New System.Drawing.Point(23, 31)
        Me.Lbl_PaymentAmount.Name = "Lbl_PaymentAmount"
        Me.Lbl_PaymentAmount.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_PaymentAmount.TabIndex = 113
        Me.Lbl_PaymentAmount.Text = "Amount:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(90, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 590)
        Me.Panel1.TabIndex = 135
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 172)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(539, 190)
        Me.GroupBox5.TabIndex = 152
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Account"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(519, 165)
        Me.DataGridView1.TabIndex = 140
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_Name)
        Me.GroupBox4.Controls.Add(Me.Cmd_StaffId)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Lbl_StaffId)
        Me.GroupBox4.Location = New System.Drawing.Point(720, 373)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 102)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Prepared By"
        Me.GroupBox4.Visible = False
        '
        'Txt_Name
        '
        Me.Txt_Name.Location = New System.Drawing.Point(94, 61)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Name.TabIndex = 151
        '
        'Cmd_StaffId
        '
        Me.Cmd_StaffId.FormattingEnabled = True
        Me.Cmd_StaffId.Location = New System.Drawing.Point(94, 24)
        Me.Cmd_StaffId.Name = "Cmd_StaffId"
        Me.Cmd_StaffId.Size = New System.Drawing.Size(121, 21)
        Me.Cmd_StaffId.TabIndex = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(13, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Name:"
        '
        'Lbl_StaffId
        '
        Me.Lbl_StaffId.AutoSize = True
        Me.Lbl_StaffId.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Lbl_StaffId.Location = New System.Drawing.Point(13, 29)
        Me.Lbl_StaffId.Name = "Lbl_StaffId"
        Me.Lbl_StaffId.Size = New System.Drawing.Size(65, 16)
        Me.Lbl_StaffId.TabIndex = 145
        Me.Lbl_StaffId.Text = "Staff Id:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl_PaymentAmount)
        Me.GroupBox3.Controls.Add(Me.Txt_PaymentAmount)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 80)
        Me.GroupBox3.TabIndex = 150
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Mode"
        '
        'Txt_PaymentAmount
        '
        Me.Txt_PaymentAmount.AfterDecimal = 2
        Me.Txt_PaymentAmount.BackColor = System.Drawing.Color.White
        Me.Txt_PaymentAmount.BeforeDecimal = 7
        Me.Txt_PaymentAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PaymentAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.Txt_PaymentAmount.Location = New System.Drawing.Point(109, 31)
        Me.Txt_PaymentAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.Txt_PaymentAmount.MaxValue = 0.0R
        Me.Txt_PaymentAmount.MinValue = 0.0R
        Me.Txt_PaymentAmount.Name = "Txt_PaymentAmount"
        Me.Txt_PaymentAmount.Size = New System.Drawing.Size(160, 23)
        Me.Txt_PaymentAmount.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(441, 370)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0.0R
        Me.txtAmount.MinValue = 0.0R
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(106, 23)
        Me.txtAmount.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Lbl_BankName)
        Me.GroupBox1.Controls.Add(Me.Cmd_BankList)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Lbl_VoucherType)
        Me.GroupBox1.Controls.Add(Me.Cmb_VoucherType)
        Me.GroupBox1.Controls.Add(Me.dtpDepositDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 158)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnShow)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtMemberNo)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(14, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(553, 50)
        Me.Panel3.TabIndex = 154
        '
        'btnShow
        '
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Black
        Me.btnShow.GotFocusColour = System.Drawing.Color.Beige
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(248, 16)
        Me.btnShow.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(24, 24)
        Me.btnShow.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Member No. :"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.Color.White
        Me.txtMemberNo.BlankSpace = True
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMemberNo.Location = New System.Drawing.Point(112, 16)
        Me.txtMemberNo.LostFocusColour = System.Drawing.Color.White
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.Size = New System.Drawing.Size(152, 23)
        Me.txtMemberNo.SpecialChar = False
        Me.txtMemberNo.TabIndex = 3
        Me.txtMemberNo.TabStop = False
        Me.txtMemberNo.Text = "MB"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(347, 19)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 10
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 80
        Me.txtName.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, -32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 16)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Closing Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd / MMM / yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, -24)
        Me.DateTimePicker1.MaxDate = New Date(2501, 9, 17, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 23)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2007, 9, 18, 0, 0, 0, 0)
        '
        'Lbl_BankName
        '
        Me.Lbl_BankName.AutoSize = True
        Me.Lbl_BankName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Lbl_BankName.Location = New System.Drawing.Point(281, 22)
        Me.Lbl_BankName.Name = "Lbl_BankName"
        Me.Lbl_BankName.Size = New System.Drawing.Size(86, 16)
        Me.Lbl_BankName.TabIndex = 150
        Me.Lbl_BankName.Text = "Bank Name:"
        '
        'Cmd_BankList
        '
        Me.Cmd_BankList.FormattingEnabled = True
        Me.Cmd_BankList.Items.AddRange(New Object() {"State Bank", "Syndicate Bank", "Canera Bank" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.Cmd_BankList.Location = New System.Drawing.Point(373, 19)
        Me.Cmd_BankList.Name = "Cmd_BankList"
        Me.Cmd_BankList.Size = New System.Drawing.Size(160, 24)
        Me.Cmd_BankList.TabIndex = 149
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date :"
        '
        'Lbl_VoucherType
        '
        Me.Lbl_VoucherType.AutoSize = True
        Me.Lbl_VoucherType.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Lbl_VoucherType.Location = New System.Drawing.Point(11, 19)
        Me.Lbl_VoucherType.Name = "Lbl_VoucherType"
        Me.Lbl_VoucherType.Size = New System.Drawing.Size(106, 16)
        Me.Lbl_VoucherType.TabIndex = 141
        Me.Lbl_VoucherType.Text = "Voucher Type:"
        '
        'Cmb_VoucherType
        '
        Me.Cmb_VoucherType.FormattingEnabled = True
        Me.Cmb_VoucherType.Items.AddRange(New Object() {"Cash", "Bank"})
        Me.Cmb_VoucherType.Location = New System.Drawing.Point(144, 15)
        Me.Cmb_VoucherType.Name = "Cmb_VoucherType"
        Me.Cmb_VoucherType.Size = New System.Drawing.Size(121, 24)
        Me.Cmb_VoucherType.TabIndex = 142
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(103, 126)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDepositDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(578, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(663, 232)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(416, 72)
        Me.txtNarration.SpecialChar = True
        Me.txtNarration.TabIndex = 13
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 2
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(127, 517)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxValue = 0.0R
        Me.txtRefno.MinValue = 0.0R
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(160, 23)
        Me.txtRefno.TabIndex = 14
        Me.txtRefno.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 524)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No .:"
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnReceipt.Image = CType(resources.GetObject("btnReceipt.Image"), System.Drawing.Image)
        Me.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceipt.Location = New System.Drawing.Point(465, 692)
        Me.btnReceipt.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(112, 40)
        Me.btnReceipt.TabIndex = 136
        Me.btnReceipt.Text = "&Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        Me.btnReceipt.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(601, 692)
        Me.btnSave.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 40)
        Me.btnSave.TabIndex = 139
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 141
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(105, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(213, 23)
        Me.Label32.TabIndex = 140
        Me.Label32.Text = "Payment Voucher Entry"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnTransfer.Image = CType(resources.GetObject("btnTransfer.Image"), System.Drawing.Image)
        Me.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransfer.Location = New System.Drawing.Point(327, 692)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(112, 40)
        Me.btnTransfer.TabIndex = 137
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        Me.btnTransfer.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(738, 692)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 138
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmPaymentVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmPaymentVoucher"
        Me.Text = "frmPaymentVoucher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_PaymentAmount As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_StaffId As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_StaffId As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_PaymentAmount As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_BankName As System.Windows.Forms.Label
    Friend WithEvents Cmd_BankList As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_VoucherType As System.Windows.Forms.Label
    Friend WithEvents Cmb_VoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents btnReceipt As BankControls.NewButton
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnTransfer As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
