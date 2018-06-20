Public Class frmVoucherEntry
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtToAccountNo As BankControls.TextControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnToSearch As BankControls.NewButton
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents cmbToLedger As System.Windows.Forms.ComboBox
    Friend WithEvents btnReceipt As BankControls.NewButton
    Friend WithEvents btnTransfer As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdReceipt As System.Windows.Forms.RadioButton
    Friend WithEvents rdPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rdTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents cmbFromLedger As System.Windows.Forms.ComboBox
    Friend WithEvents txtChequeNo As BankControls.NumericControl
    Friend WithEvents rdContra As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As BankControls.NewButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_BankName As System.Windows.Forms.Label
    Friend WithEvents Cmd_BankList As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_VoucherType As System.Windows.Forms.Label
    Friend WithEvents Cmb_VoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoucherEntry))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_BankName = New System.Windows.Forms.Label()
        Me.btnShow = New BankControls.NewButton()
        Me.Cmd_BankList = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lbl_VoucherType = New System.Windows.Forms.Label()
        Me.txtMemberNo = New BankControls.TextControl()
        Me.Cmb_VoucherType = New System.Windows.Forms.ComboBox()
        Me.txtName = New BankControls.TextControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker()
        Me.txtChequeNo = New BankControls.NumericControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New BankControls.NumericControl()
        Me.cmbFromLedger = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdContra = New System.Windows.Forms.RadioButton()
        Me.rdTransfer = New System.Windows.Forms.RadioButton()
        Me.rdReceipt = New System.Windows.Forms.RadioButton()
        Me.rdPayment = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbToLedger = New System.Windows.Forms.ComboBox()
        Me.txtNarration = New BankControls.TextControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtToAccountNo = New BankControls.TextControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnToSearch = New BankControls.NewButton()
        Me.txtAccNo = New BankControls.TextControl()
        Me.btnSearch = New BankControls.NewButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRefno = New BankControls.NumericControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New BankControls.NewButton()
        Me.btnReceipt = New BankControls.NewButton()
        Me.btnSave = New BankControls.NewButton()
        Me.btnTransfer = New BankControls.NewButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(133, 23)
        Me.Label32.TabIndex = 119
        Me.Label32.Text = "Voucher Entry"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtChequeNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.cmbFromLedger)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbToLedger)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtToAccountNo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnToSearch)
        Me.Panel1.Controls.Add(Me.txtAccNo)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 461)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Lbl_BankName)
        Me.Panel3.Controls.Add(Me.btnShow)
        Me.Panel3.Controls.Add(Me.Cmd_BankList)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Lbl_VoucherType)
        Me.Panel3.Controls.Add(Me.txtMemberNo)
        Me.Panel3.Controls.Add(Me.Cmb_VoucherType)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtpDepositDate)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(22, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(596, 148)
        Me.Panel3.TabIndex = 154
        '
        'Lbl_BankName
        '
        Me.Lbl_BankName.AutoSize = True
        Me.Lbl_BankName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Lbl_BankName.Location = New System.Drawing.Point(273, 22)
        Me.Lbl_BankName.Name = "Lbl_BankName"
        Me.Lbl_BankName.Size = New System.Drawing.Size(86, 16)
        Me.Lbl_BankName.TabIndex = 158
        Me.Lbl_BankName.Text = "Bank Name:"
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
        Me.btnShow.Location = New System.Drawing.Point(261, 64)
        Me.btnShow.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(24, 24)
        Me.btnShow.TabIndex = 2
        '
        'Cmd_BankList
        '
        Me.Cmd_BankList.FormattingEnabled = True
        Me.Cmd_BankList.Items.AddRange(New Object() {"BDCC BANK", "BANK OF MAHARASTRA"})
        Me.Cmd_BankList.Location = New System.Drawing.Point(365, 19)
        Me.Cmd_BankList.Name = "Cmd_BankList"
        Me.Cmd_BankList.Size = New System.Drawing.Size(160, 24)
        Me.Cmd_BankList.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Member No. :"
        '
        'Lbl_VoucherType
        '
        Me.Lbl_VoucherType.AutoSize = True
        Me.Lbl_VoucherType.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Lbl_VoucherType.Location = New System.Drawing.Point(22, 22)
        Me.Lbl_VoucherType.Name = "Lbl_VoucherType"
        Me.Lbl_VoucherType.Size = New System.Drawing.Size(106, 16)
        Me.Lbl_VoucherType.TabIndex = 155
        Me.Lbl_VoucherType.Text = "Voucher Type:"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.Color.White
        Me.txtMemberNo.BlankSpace = True
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMemberNo.Location = New System.Drawing.Point(125, 64)
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
        'Cmb_VoucherType
        '
        Me.Cmb_VoucherType.FormattingEnabled = True
        Me.Cmb_VoucherType.Items.AddRange(New Object() {"Cash", "Bank"})
        Me.Cmb_VoucherType.Location = New System.Drawing.Point(134, 19)
        Me.Cmb_VoucherType.Name = "Cmb_VoucherType"
        Me.Cmb_VoucherType.Size = New System.Drawing.Size(121, 24)
        Me.Cmb_VoucherType.TabIndex = 156
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(360, 67)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(304, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Name:"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date :"
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(147, 108)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDepositDate.TabIndex = 4
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AfterDecimal = 0
        Me.txtChequeNo.BackColor = System.Drawing.Color.White
        Me.txtChequeNo.BeforeDecimal = 7
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(536, 298)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.MaxValue = 0.0R
        Me.txtChequeNo.MinValue = 0.0R
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(160, 23)
        Me.txtChequeNo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Cheque No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 308)
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
        Me.txtAmount.Location = New System.Drawing.Point(141, 305)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0.0R
        Me.txtAmount.MinValue = 0.0R
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 11
        '
        'cmbFromLedger
        '
        Me.cmbFromLedger.DropDownWidth = 200
        Me.cmbFromLedger.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFromLedger.Location = New System.Drawing.Point(140, 216)
        Me.cmbFromLedger.Name = "cmbFromLedger"
        Me.cmbFromLedger.Size = New System.Drawing.Size(264, 24)
        Me.cmbFromLedger.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = " Account No :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdContra)
        Me.GroupBox1.Controls.Add(Me.rdTransfer)
        Me.GroupBox1.Controls.Add(Me.rdReceipt)
        Me.GroupBox1.Controls.Add(Me.rdPayment)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rdContra
        '
        Me.rdContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.rdContra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdContra.Location = New System.Drawing.Point(294, 16)
        Me.rdContra.Name = "rdContra"
        Me.rdContra.Size = New System.Drawing.Size(88, 24)
        Me.rdContra.TabIndex = 4
        Me.rdContra.TabStop = True
        Me.rdContra.Text = "Contra"
        Me.rdContra.UseVisualStyleBackColor = False
        '
        'rdTransfer
        '
        Me.rdTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.rdTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTransfer.Location = New System.Drawing.Point(200, 16)
        Me.rdTransfer.Name = "rdTransfer"
        Me.rdTransfer.Size = New System.Drawing.Size(88, 24)
        Me.rdTransfer.TabIndex = 3
        Me.rdTransfer.TabStop = True
        Me.rdTransfer.Text = "Transfer"
        Me.rdTransfer.UseVisualStyleBackColor = False
        '
        'rdReceipt
        '
        Me.rdReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.rdReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdReceipt.Location = New System.Drawing.Point(112, 16)
        Me.rdReceipt.Name = "rdReceipt"
        Me.rdReceipt.Size = New System.Drawing.Size(88, 24)
        Me.rdReceipt.TabIndex = 2
        Me.rdReceipt.TabStop = True
        Me.rdReceipt.Text = "Receipt"
        Me.rdReceipt.UseVisualStyleBackColor = False
        '
        'rdPayment
        '
        Me.rdPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.rdPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPayment.Location = New System.Drawing.Point(8, 16)
        Me.rdPayment.Name = "rdPayment"
        Me.rdPayment.Size = New System.Drawing.Size(88, 24)
        Me.rdPayment.TabIndex = 1
        Me.rdPayment.TabStop = True
        Me.rdPayment.Text = "Payment"
        Me.rdPayment.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration :"
        '
        'cmbToLedger
        '
        Me.cmbToLedger.DropDownWidth = 200
        Me.cmbToLedger.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToLedger.Location = New System.Drawing.Point(551, 216)
        Me.cmbToLedger.Name = "cmbToLedger"
        Me.cmbToLedger.Size = New System.Drawing.Size(247, 24)
        Me.cmbToLedger.TabIndex = 8
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(131, 335)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(416, 72)
        Me.txtNarration.SpecialChar = True
        Me.txtNarration.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Debit  Account:"
        '
        'txtToAccountNo
        '
        Me.txtToAccountNo.AlphaNumeric = True
        Me.txtToAccountNo.BackColor = System.Drawing.Color.White
        Me.txtToAccountNo.BlankSpace = False
        Me.txtToAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToAccountNo.Location = New System.Drawing.Point(536, 267)
        Me.txtToAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtToAccountNo.Mandatory = False
        Me.txtToAccountNo.Name = "txtToAccountNo"
        Me.txtToAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtToAccountNo.SpecialChar = False
        Me.txtToAccountNo.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(424, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Account No :"
        '
        'btnToSearch
        '
        Me.btnToSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSearch.ForeColor = System.Drawing.Color.Black
        Me.btnToSearch.GotFocusColour = System.Drawing.Color.ForestGreen
        Me.btnToSearch.Image = CType(resources.GetObject("btnToSearch.Image"), System.Drawing.Image)
        Me.btnToSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToSearch.Location = New System.Drawing.Point(668, 266)
        Me.btnToSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnToSearch.Name = "btnToSearch"
        Me.btnToSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnToSearch.TabIndex = 10
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(140, 266)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.ForestGreen
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(274, 266)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Credit Account:"
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 2
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(145, 423)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxValue = 0.0R
        Me.txtRefno.MinValue = 0.0R
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(160, 23)
        Me.txtRefno.TabIndex = 14
        Me.txtRefno.Text = "Ref"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No .:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(589, 543)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnReceipt.Image = CType(resources.GetObject("btnReceipt.Image"), System.Drawing.Image)
        Me.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceipt.Location = New System.Drawing.Point(316, 543)
        Me.btnReceipt.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(112, 40)
        Me.btnReceipt.TabIndex = 14
        Me.btnReceipt.Text = "&Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(452, 543)
        Me.btnSave.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 40)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnTransfer.Image = CType(resources.GetObject("btnTransfer.Image"), System.Drawing.Image)
        Me.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransfer.Location = New System.Drawing.Point(178, 543)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(112, 40)
        Me.btnTransfer.TabIndex = 14
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'frmVoucherEntry
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1024, 618)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Globle Diclaration"
    Dim lngVoucherNo As Long
    Dim dtLedger As New DataTable
    Dim objGroup As New clsGroups
    Dim objLedger As New clsLedger
    Dim bolFlag As Boolean = False
    Dim AutoIncreRefNo As Integer
    Dim objCurrentAccount As New clsCurrentAccount
    Dim objSavingsBank As New clsSavingsBank
    Dim dblAvalAmount As Double
#End Region

#Region "Variables"

    Dim objClsMember As New clsMember
    'Dim objLedger As New clsLedger

#End Region



    Dim objTempDt As New DataTable

    Public Sub sbFromloaddetails()
        Dim objDV As DataView
        If objLedger.fnGetLedgerListExcCash Then
            objDV = New DataView(objLedger.LedgerTable, "", "Name", DataViewRowState.OriginalRows)
            cmbFromLedger.DataSource = objDV
            cmbFromLedger.DisplayMember = "Name"
            cmbFromLedger.ValueMember = "LedgerNo"
            cmbFromLedger.SelectedIndex = -1
        End If

       
    End Sub

    Public Sub sbToloaddetails()
        Dim objDV As DataView
        If objLedger.fnGetLedgerListExcCash Then
            objDV = New DataView(objLedger.LedgerTable, "", "Name", DataViewRowState.OriginalRows)
            cmbToLedger.DataSource = objDV
            cmbToLedger.DisplayMember = "Name"
            cmbToLedger.ValueMember = "LedgerNo"
            cmbToLedger.SelectedIndex = -1
        End If
        'If objLedger.fnGetLedgerListExcCash Then
        '    objDV = New DataView(objLedger.LedgerTable, "", "Name", DataViewRowState.OriginalRows)
        '    DataGridView1.DataSource = objDV
        '    'DataGridView1.DisplayMember = "Name"
        '    'DataGridView1.ValueMember = "LedgerNo"
        '    'DataGridView1.SelectedIndex = -1
        'End If


    End Sub

    Public Function fnLoadData() As Boolean
        Try
            If objClsMember.fnLoadCloseMember(txtMemberNo.Text) Then
                objClsMember.MemberNo = txtMemberNo.Text
                txtName.Text = objClsMember.CloseMemberDet.Rows(0).Item("Name")

            End If

           
       
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Function

    Public Function fnFromCheck() As Boolean
        If cmbFromLedger.SelectedIndex = -1 Then
            MsgBox("Select credit account type", MsgBoxStyle.Information)
            cmbFromLedger.Focus()
            Return False
        ElseIf cmbToLedger.SelectedIndex = -1 Then
            MsgBox("Select debit account type", MsgBoxStyle.Information)
            cmbToLedger.Focus()
            Return False
        ElseIf cmbFromLedger.SelectedValue = cmbToLedger.SelectedValue Then
            MsgBox("Both accounts cannot be same", MsgBoxStyle.Information)
            cmbFromLedger.Focus()
            Return False
        ElseIf txtAmount.Text = "" Then
            MsgBox("Enter amount to be transfer", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf txtRefno.Text = "" Then
            MsgBox("Enter reference number", MsgBoxStyle.Information)
            txtRefno.Focus()
            Return False
        ElseIf cmbFromLedger.SelectedValue = 11 Or cmbFromLedger.SelectedValue = 10 Or cmbFromLedger.SelectedValue = 12 Then
            If txtAccNo.Text = "" Then
                MsgBox("Enter account number", MsgBoxStyle.Information)
                txtAccNo.Focus()
                Return False
            Else
                Return True
            End If
        ElseIf cmbToLedger.SelectedValue = 11 Or cmbToLedger.SelectedValue = 10 Or cmbToLedger.SelectedValue = 12 Then
            If txtToAccountNo.Text = "" Then
                MsgBox("Enter account number", MsgBoxStyle.Information)
                txtToAccountNo.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Public Function fnToCheck() As Boolean
        If cmbToLedger.SelectedValue = 11 Or cmbToLedger.SelectedValue = 10 Then
            If txtToAccountNo.Text = "" Then
                MsgBox("Enter account number", MsgBoxStyle.Information)
                txtAccNo.Focus()
                Return False
            ElseIf cmbToLedger.SelectedValue = 10 Then
                If (fnCheckBalance() = False) Then
                    Return False
                Else
                    Return True
                End If
            ElseIf cmbToLedger.SelectedValue = 11 Then
                If (fnCheckCABalance() = False) Then
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
    Sub sbClear()

        cmbFromLedger.SelectedIndex = -1
        cmbToLedger.SelectedIndex = -1
        txtAccNo.ResetText()
        txtToAccountNo.ResetText()
        txtAmount.ResetText()
        txtRefno.ResetText()
        txtNarration.ResetText()
        dtpDepositDate.Focus()
        txtChequeNo.ResetText()
        AutoIncreRefNo = 0

    End Sub

#Region "Events"

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim ObjMemberSearch As New frmMemberSearch
        ObjMemberSearch.ShowDialog(Me)
        txtMemberNo.Text = ObjMemberSearch.strMemberNo
        If ObjMemberSearch.strMemberNo = "" Then
            txtMemberNo.Text = "MB"
            btnShow.Focus()
        Else
            fnLoadData()
        End If
    End Sub
#End Region

    Function fnGenerateVoucher(ByVal objtrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim IntType As Integer
        Dim strVoucherType As String
        Dim strTMode As String

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If rdPayment.Checked = True Then
            IntType = 1
            strVoucherType = "Payment"
        ElseIf rdReceipt.Checked = True Then
            IntType = 2
            strVoucherType = "Receipt"
        ElseIf rdContra.Checked = True Then
            IntType = 3
            strVoucherType = "Contra"
        ElseIf rdTransfer.Checked = True Then
            IntType = 7
            strVoucherType = "Transfer"
        End If

        If txtChequeNo.Text = String.Empty Then
            strTMode = "Cash"
        Else
            strTMode = "Cheque"
        End If


        If cmbFromLedger.SelectedValue = 10 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            Dim strNarration As String ' = "Deposit By Cash" & " Narration:" & txtNarration.Text
            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)

        ElseIf cmbFromLedger.SelectedValue = 11 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from catransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            Dim strNarration As String ' = "Deposit By Cash" & txtAccNo.Text & "  Narration:" & txtNarration.Text
            Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','0','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql, objtrans)

        ElseIf cmbFromLedger.SelectedValue = 12 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from odtransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            Dim strNarration As String '= "Deposit By " & txtAccNo.Text & "  Narration:" & txtNarration.Text
            Dim strsql = "insert into odtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Val(txtAmount.Text) & "','0',sum(Withdraw)-sum(Deposit)-'" & Val(txtAmount.Text) & "','0','0',0,'" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','" & txtChequeNo.Text & "' from odtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)
        ElseIf cmbFromLedger.SelectedValue = 123 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from pigmytransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            Dim strNarration As String '= "Deposit By " & txtAccNo.Text & "  Narration:" & txtNarration.Text
            Dim strsql = "insert into pigmytransactiontbl (accountno,trdate,narration,deposit,withdraw,postbalance,ddeposit,dwithdraw,dpostbalance,                                               refno                  ,voucherno,     type,             cheque) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','" & Val(txtAmount.Text) & "','0',sum(ddeposit)-sum(dwithdraw)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from pigmytransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)


        ElseIf cmbFromLedger.SelectedValue = 29 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from rdtransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            Dim strNarration As String ' = "Deposit By Cash" & txtAccNo.Text & "  Narration:" & txtNarration.Text
            Dim strsql = "insert into rdtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbalance,refno,voucherno,type,cheque) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from rdtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)

        End If

        If cmbToLedger.SelectedValue = 10 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            If AutoIncreRefNo = 0 Then
                Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
                objTempDt = fnExecuteQuery(strsql3, 2)
                AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
            End If

            Dim strNarration As String ' = "Withdrawal By Cash " & " Narration:" & txtNarration.Text
            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from sbtransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)

        ElseIf cmbToLedger.SelectedValue = 11 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            If AutoIncreRefNo = 0 Then
                Dim strsql3 = "select max(RefNo) as RefNo from catransactiontbl"
                objTempDt = fnExecuteQuery(strsql3, 2)
                AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
            End If

            Dim strNarration As String '= "Withdrawal By Cash " & " Narration:" & txtNarration.Text
            Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','0','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from catransactiontbl where caccountno='" & Trim(txtToAccountNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql, objtrans)

        ElseIf cmbToLedger.SelectedValue = 12 Then
            ''Auto increment num as a Ref number
            If AutoIncreRefNo = 0 Then
                Dim strsql3 = "select max(RefNo) as RefNo from odtransactiontbl"
                objTempDt = fnExecuteQuery(strsql3, 2)
                AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
            End If

            Dim strNarration As String '= "Withdrawal By " & txtToAccountNo.Text & " Narration:" & txtNarration.Text

            Dim strsql = "insert into odtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Val(txtAmount.Text) & "',sum(withdraw)-sum(Deposit)+'" & Val(txtAmount.Text) & "','0','0',0,'" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','" & txtChequeNo.Text & "' from odtransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)

        ElseIf cmbToLedger.SelectedValue = 123 Then

            'Transaction Entry
            ''Auto increment num as a Ref number
            If AutoIncreRefNo = 0 Then
                Dim strsql3 = "select max(RefNo) as RefNo from pigmytransactiontbl"
                objTempDt = fnExecuteQuery(strsql3, 2)
                AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
            End If

            Dim strNarration As String '= "Withdrawal By " & "  Narration:" & txtNarration.Text
            Dim strsql = "insert into pigmytransactiontbl (accountno,             trdate,                                                      narration,        deposit,withdraw,postbalance,ddeposit,dwithdraw,     dpostbalance,                                                         refno                  ,voucherno,               type,             cheque) "
            strsql = strsql & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','0','" & Val(txtAmount.Text) & "',sum(ddeposit)-sum(dwithdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','" & strTMode & "','0' from pigmytransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objtrans)
        Else
            If AutoIncreRefNo = 0 Then
                Dim strsql3 = "select max(voucherNo) as RefNo from fasvouchermaintbl where vdate='" & Format(CDate(dtpDepositDate.Value), "yyyy-MM-dd") & "'"
                objTempDt = fnExecuteQuery(strsql3, 2)
                If objTempDt.Rows.Count < 0 Then
                    AutoIncreRefNo = 1
                Else
                    Dim a As String = objTempDt.Rows(0).Item("RefNo").ToString()
                    If a = "" Then
                        AutoIncreRefNo = 1
                    Else
                        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

                    End If
                End If
            End If
        End If


        'voucher details
        fnVoucherEnterMain(lngVoucherNo, IntType, "LNo:" & cmbFromLedger.SelectedValue, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Credited by " & cmbFromLedger.Text.ToString(), lngSlNo, "Y", objtrans)

        'Credit accounts
        ' fnVoucherEnterSub(lngVoucherNo, IntType, "LNo:" & cmbFromLedger.SelectedValue, dtpDepositDate.Value, "Credited by " & cmbFromLedger.Text.ToString() & " Narration:" & txtNarration.Text, "To", cmbFromLedger.SelectedValue, 0, Val(txtAmount.Text), 1, "Y", objtrans)

        fnVoucherEnterSub(lngVoucherNo, IntType, "LNo:" & cmbFromLedger.SelectedValue, dtpDepositDate.Value, txtNarration.Text, "To", cmbFromLedger.SelectedValue, 0, Val(txtAmount.Text), 1, "Y", objtrans)

        'Debit accounts 
        ' fnVoucherEnterSub(lngVoucherNo, IntType, "LNo:" & cmbToLedger.SelectedValue, dtpDepositDate.Value, "Debited by  " & cmbToLedger.Text.ToString() & " Narration:" & txtNarration.Text, "By", cmbToLedger.SelectedValue, Val(txtAmount.Text), 0, 2, "Y", objtrans)

        fnVoucherEnterSub(lngVoucherNo, IntType, "LNo:" & cmbToLedger.SelectedValue, dtpDepositDate.Value, txtNarration.Text, "By", cmbToLedger.SelectedValue, Val(txtAmount.Text), 0, 2, "Y", objtrans)

        fnLogEntry(pbUserId, strVoucherType & " by " & cmbFromLedger.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction" & strVoucherType, objtrans)
    End Function

    Private Sub frmVoucherEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDepositDate.Value = Date.Now
        sbFromloaddetails()
        sbToloaddetails()
        bolFlag = True
    End Sub

    Private Sub cmbFromLedger_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFromLedger.SelectedIndexChanged
        If bolFlag = True Then
            If cmbFromLedger.SelectedValue = 10 Or cmbFromLedger.SelectedValue = 11 Or cmbFromLedger.SelectedValue = 123 Or cmbFromLedger.SelectedValue = 29 Then
                txtAccNo.Enabled = True
                btnSearch.Enabled = True
            Else
                txtAccNo.Enabled = False
                btnSearch.Enabled = False
                txtAccNo.ResetText()
            End If
        End If
      
    End Sub

    Private Sub cmbToLedger_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbToLedger.SelectedIndexChanged
        If bolFlag = True Then
            If cmbToLedger.SelectedValue = 10 Or cmbToLedger.SelectedValue = 11 Or cmbToLedger.SelectedValue = 123 Then
                txtToAccountNo.Enabled = True
                btnToSearch.Enabled = True
            Else
                txtToAccountNo.Enabled = False
                btnToSearch.Enabled = False
                txtToAccountNo.ResetText()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cmbFromLedger.SelectedValue = 11 Then
            Dim objCAccSearch As New frmCAccSearch
            objCAccSearch.strCAccountNo = String.Empty
            objCAccSearch.ShowDialog(Me)
            If objCAccSearch.strCAccountNo <> String.Empty Then
                txtAccNo.Text = objCAccSearch.strCAccountNo
            End If
            objCAccSearch.Dispose()
        ElseIf cmbFromLedger.SelectedValue = 10 Then
            Dim objSBAccSearch As New frmSBAccSearch
            objSBAccSearch.strSBAccountNo = String.Empty
            objSBAccSearch.ShowDialog(Me)
            If objSBAccSearch.strSBAccountNo <> String.Empty Then
                txtAccNo.Text = objSBAccSearch.strSBAccountNo
            End If
            objSBAccSearch.Dispose()
        ElseIf cmbFromLedger.SelectedValue = 12 Then
            Dim objODAccSearch As New frmODLoanCust
            objODAccSearch.strODLoan = String.Empty
            objODAccSearch.ShowDialog(Me)
            If objODAccSearch.strODLoan <> String.Empty Then
                txtAccNo.Text = objODAccSearch.strODLoan
            End If
            objODAccSearch.Dispose()
        ElseIf cmbFromLedger.SelectedValue = 123 Then
            Dim objBNNDAccSearch As New frmPGCust
            objBNNDAccSearch.strPGNo = String.Empty
            objBNNDAccSearch.ShowDialog(Me)
            If objBNNDAccSearch.strPGNo <> String.Empty Then
                txtAccNo.Text = objBNNDAccSearch.strPGNo
            End If
            objBNNDAccSearch.Dispose()

        ElseIf cmbFromLedger.SelectedValue = 29 Then
            Dim objRDAccSearch As New frmRDCust
            objRDAccSearch.strRDNo = String.Empty
            objRDAccSearch.ShowDialog(Me)
            If objRDAccSearch.strRDNo <> String.Empty Then
                txtAccNo.Text = objRDAccSearch.strRDNo
            End If
            objRDAccSearch.Dispose()
        End If

    End Sub

    Private Sub btnToSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToSearch.Click
        If cmbToLedger.SelectedValue = 11 Then
            Dim objCAccSearch As New frmCAccSearch
            objCAccSearch.strCAccountNo = String.Empty
            objCAccSearch.ShowDialog(Me)
            If objCAccSearch.strCAccountNo <> String.Empty Then
                txtToAccountNo.Text = objCAccSearch.strCAccountNo
            End If
            objCAccSearch.Dispose()
        ElseIf cmbToLedger.SelectedValue = 10 Then
            Dim objSBAccSearch As New frmSBAccSearch
            objSBAccSearch.strSBAccountNo = String.Empty
            objSBAccSearch.ShowDialog(Me)
            If objSBAccSearch.strSBAccountNo <> String.Empty Then
                txtToAccountNo.Text = objSBAccSearch.strSBAccountNo
            End If
            objSBAccSearch.Dispose()
        ElseIf cmbToLedger.SelectedValue = 12 Then
            Dim objODAccSearch As New frmODLoanCust
            objODAccSearch.strODLoan = String.Empty
            objODAccSearch.ShowDialog(Me)
            If objODAccSearch.strODLoan <> String.Empty Then
                txtToAccountNo.Text = objODAccSearch.strODLoan
            End If
            objODAccSearch.Dispose()
        ElseIf cmbToLedger.SelectedValue = 123 Then
            Dim objBNNDAccSearch As New frmPGCust
            objBNNDAccSearch.strPGNo = String.Empty
            objBNNDAccSearch.ShowDialog(Me)
            If objBNNDAccSearch.strPGNo <> String.Empty Then
                txtToAccountNo.Text = objBNNDAccSearch.strPGNo
            End If
            objBNNDAccSearch.Dispose()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnFromCheck() Then
                If fnToCheck() Then
                    If MsgBox("Ledger :" & cmbFromLedger.Text & " " & Chr(13) & " Amount :" & txtAmount.Text & "" & Chr(13) & " Type :  Cash", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        'sbClear()
                        fnGenerateVoucher(objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & " Do You Want To Make Another Transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            sbClear()
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

    Private Sub cmbFromLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFromLedger.KeyPress
        cmbFromLedger.DroppedDown = True
    End Sub

    Private Sub cmbToLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbToLedger.KeyPress
        cmbToLedger.DroppedDown = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function fnCheckBalance() As Boolean
        ''Check available balance in account
        If objSavingsBank.fnGetSBAccountDetails(Trim(txtToAccountNo.Text)) Then
            If objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") < Val(txtAmount.Text) Then
                MsgBox("Low balance in the account,please check account", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            ElseIf objSavingsBank.fnGetMasterSetting() Then
                If objSavingsBank.SBMasterTable.Rows(0).Item("SBminAmount") > (objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") - Val(txtToAccountNo.Text)) Then
                    'If MsgBox("Available Balance Is Less Than Minimum Amount For account holder,Still Do You Want To continue transaction? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Issue") = MsgBoxResult.Yes Then
                    MsgBox("Available balance is less than minimum amount for account holder", MsgBoxStyle.Exclamation, Me.Text)
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        End If
    End Function

    Private Function fnCheckCABalance() As Boolean

        If objCurrentAccount.fnGetCAccountDetails(txtToAccountNo.Text) Then
            dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
            'dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
            If Val(txtAmount.Text) > Val(dblAvalAmount) Then '+ Val(dblOverDrawLimit) Then
                MsgBox("Withdrawal amount is exeeding limited amount please enter valid amount")
                txtAmount.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function


    Private Sub rdContra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdContra.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cmbToLedger.SelectedValue = "Cash"
        'cmbFromLedger.Visible = False

        'If ComboBox1.SelectedItem = "Cash" Then

        '    cmbFromLedger.Enabled = False
        '    Label10.Enabled = False
        '    rdrCash.Checked = True
        'ElseIf

        '        ComboBox1.SelectedItem = "Cheque" Then  

        '    cmbFromLedger.Enabled = True
        '    Label10.Enabled = True
        '    rdrCheque.Checked = True
        'End If

        'If ComboBox1.SelectedItem = "Cash" Then
        '    cmbFromLedger.Visible = False
        '    Label10.Visible = False
        '    rdrCash.Checked = True
        '    rdrCheque.Visible = False
        '    'rdrCash.Focus()

        'ElseIf ComboBox1.SelectedItem = "Cheque" Then
        '    cmbFromLedger.Enabled = True
        '    Label10.Enabled = True
        '    rdrCheque.Checked = True
        '    rdrCash.Visible = False
        '    'rdrCheque.Focus()

        'End If


    End Sub

    Private Sub Cmb_VoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_VoucherType.SelectedIndexChanged
        If Cmb_VoucherType.SelectedItem = "Cash" Then
            Cmd_BankList.Visible = False
            Lbl_BankName.Visible = False
        Else
            Cmd_BankList.Visible = True
            Lbl_BankName.Visible = True

        End If
    End Sub

  
End Class
