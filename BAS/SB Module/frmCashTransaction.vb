Imports System.Math
Public Class frmCashTransaction
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
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents btnVerifyPhotoSign As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents rdDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    Friend WithEvents btnTransfer As BankControls.NewButton
    Friend WithEvents rdTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnToSearch As BankControls.NewButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents txtToAccountNo As BankControls.TextControl
    Friend WithEvents cmbChkCash As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepositWithdraw As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransation As System.Windows.Forms.Label
    Friend WithEvents txtOthers As BankControls.NumericControl
    Friend WithEvents lblOthers As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As BankControls.NumericControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As BankControls.TextControl
    Friend WithEvents txtChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbTranType As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBookNo As BankControls.TextControl
    Friend WithEvents cmbTransferToAc As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashTransaction))
        Me.btnDeposit = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtBookNo = New BankControls.TextControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtBankName = New BankControls.TextControl
        Me.cmbTranType = New System.Windows.Forms.ComboBox
        Me.txtChequeDate = New System.Windows.Forms.DateTimePicker
        Me.txtBranchName = New BankControls.TextControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtChequeNo = New BankControls.NumericControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtOthers = New BankControls.NumericControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdTransfer = New System.Windows.Forms.RadioButton
        Me.rdWithdraw = New System.Windows.Forms.RadioButton
        Me.rdDeposit = New System.Windows.Forms.RadioButton
        Me.lblOthers = New System.Windows.Forms.Label
        Me.txtToAccountNo = New BankControls.TextControl
        Me.txtAccNo = New BankControls.TextControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnToSearch = New BankControls.NewButton
        Me.txtRefno = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblBookBal = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.btnTransfer = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnVerifyPhotoSign = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.NewButton1 = New BankControls.NewButton
        Me.cmbChkCash = New System.Windows.Forms.ComboBox
        Me.cmbDepositWithdraw = New System.Windows.Forms.ComboBox
        Me.cmbAccount = New System.Windows.Forms.ComboBox
        Me.lblTransation = New System.Windows.Forms.Label
        Me.cmbTransferToAc = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(182, 488)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(128, 40)
        Me.btnDeposit.TabIndex = 8
        Me.btnDeposit.Text = "&Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        Me.btnDeposit.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtBookNo)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtBankName)
        Me.Panel1.Controls.Add(Me.cmbTranType)
        Me.Panel1.Controls.Add(Me.txtChequeDate)
        Me.Panel1.Controls.Add(Me.txtBranchName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtChequeNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtOthers)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblOthers)
        Me.Panel1.Controls.Add(Me.txtToAccountNo)
        Me.Panel1.Controls.Add(Me.txtAccNo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnToSearch)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblAvalBal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblBookBal)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.dtpDepositDate)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 408)
        Me.Panel1.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 163
        Me.Label16.Text = "Book No. :"
        Me.Label16.Visible = False
        '
        'txtBookNo
        '
        Me.txtBookNo.AlphaNumeric = False
        Me.txtBookNo.BackColor = System.Drawing.Color.White
        Me.txtBookNo.BlankSpace = False
        Me.txtBookNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookNo.Location = New System.Drawing.Point(152, 344)
        Me.txtBookNo.LostFocusColour = System.Drawing.Color.White
        Me.txtBookNo.Mandatory = False
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(152, 22)
        Me.txtBookNo.SpecialChar = False
        Me.txtBookNo.TabIndex = 162
        Me.txtBookNo.TabStop = False
        Me.txtBookNo.WordWrap = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(323, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 16)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Transaction Type :"
        Me.Label15.Visible = False
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(432, 310)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 30
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(200, 23)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 139
        '
        'cmbTranType
        '
        Me.cmbTranType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTranType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTranType.Items.AddRange(New Object() {"Clearing Cheque", "Cheque Withdraw"})
        Me.cmbTranType.Location = New System.Drawing.Point(464, 31)
        Me.cmbTranType.Name = "cmbTranType"
        Me.cmbTranType.Size = New System.Drawing.Size(152, 24)
        Me.cmbTranType.TabIndex = 160
        Me.cmbTranType.Visible = False
        '
        'txtChequeDate
        '
        Me.txtChequeDate.CustomFormat = "dd - MMM - yyyy"
        Me.txtChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtChequeDate.Location = New System.Drawing.Point(152, 313)
        Me.txtChequeDate.MaxDate = New Date(9998, 11, 17, 0, 0, 0, 0)
        Me.txtChequeDate.Name = "txtChequeDate"
        Me.txtChequeDate.Size = New System.Drawing.Size(144, 23)
        Me.txtChequeDate.TabIndex = 138
        Me.txtChequeDate.Value = New Date(2007, 10, 12, 0, 0, 0, 0)
        '
        'txtBranchName
        '
        Me.txtBranchName.AlphaNumeric = True
        Me.txtBranchName.BlankSpace = True
        Me.txtBranchName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBranchName.Location = New System.Drawing.Point(433, 343)
        Me.txtBranchName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBranchName.Mandatory = False
        Me.txtBranchName.MaxLength = 30
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(200, 23)
        Me.txtBranchName.SpecialChar = True
        Me.txtBranchName.TabIndex = 137
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(320, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 18)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Branch Name :"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Cheque Date. :"
        Me.Label14.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(320, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 18)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Bank Name :"
        Me.Label11.Visible = False
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AfterDecimal = 0
        Me.txtChequeNo.BeforeDecimal = 7
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(152, 31)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.MaxValue = 0
        Me.txtChequeNo.MinValue = 0
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(160, 23)
        Me.txtChequeNo.TabIndex = 129
        Me.txtChequeNo.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 16)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Cheque No. :"
        Me.Label12.Visible = False
        '
        'txtOthers
        '
        Me.txtOthers.AfterDecimal = 0
        Me.txtOthers.BeforeDecimal = 7
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOthers.Location = New System.Drawing.Point(432, 280)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.MaxLength = 7
        Me.txtOthers.MaxValue = 0
        Me.txtOthers.MinValue = 0
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(168, 23)
        Me.txtOthers.TabIndex = 127
        Me.txtOthers.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdTransfer)
        Me.GroupBox1.Controls.Add(Me.rdWithdraw)
        Me.GroupBox1.Controls.Add(Me.rdDeposit)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(47, 24)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'rdTransfer
        '
        Me.rdTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.rdTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTransfer.Location = New System.Drawing.Point(26, 13)
        Me.rdTransfer.Name = "rdTransfer"
        Me.rdTransfer.Size = New System.Drawing.Size(10, 17)
        Me.rdTransfer.TabIndex = 3
        Me.rdTransfer.TabStop = True
        Me.rdTransfer.Text = "Transfer"
        Me.rdTransfer.UseVisualStyleBackColor = False
        '
        'rdWithdraw
        '
        Me.rdWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.rdWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdWithdraw.Location = New System.Drawing.Point(15, 12)
        Me.rdWithdraw.Name = "rdWithdraw"
        Me.rdWithdraw.Size = New System.Drawing.Size(10, 18)
        Me.rdWithdraw.TabIndex = 2
        Me.rdWithdraw.TabStop = True
        Me.rdWithdraw.Text = "Withdraw"
        Me.rdWithdraw.UseVisualStyleBackColor = False
        '
        'rdDeposit
        '
        Me.rdDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.rdDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDeposit.Location = New System.Drawing.Point(3, 12)
        Me.rdDeposit.Name = "rdDeposit"
        Me.rdDeposit.Size = New System.Drawing.Size(10, 18)
        Me.rdDeposit.TabIndex = 1
        Me.rdDeposit.TabStop = True
        Me.rdDeposit.Text = "Deposit"
        Me.rdDeposit.UseVisualStyleBackColor = False
        '
        'lblOthers
        '
        Me.lblOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOthers.Location = New System.Drawing.Point(320, 280)
        Me.lblOthers.Name = "lblOthers"
        Me.lblOthers.Size = New System.Drawing.Size(119, 18)
        Me.lblOthers.TabIndex = 128
        Me.lblOthers.Text = "Other Charges :"
        Me.lblOthers.Visible = False
        '
        'txtToAccountNo
        '
        Me.txtToAccountNo.AlphaNumeric = True
        Me.txtToAccountNo.BackColor = System.Drawing.Color.White
        Me.txtToAccountNo.BlankSpace = True
        Me.txtToAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToAccountNo.Location = New System.Drawing.Point(464, 64)
        Me.txtToAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtToAccountNo.Mandatory = False
        Me.txtToAccountNo.MaxLength = 7
        Me.txtToAccountNo.Name = "txtToAccountNo"
        Me.txtToAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtToAccountNo.SpecialChar = False
        Me.txtToAccountNo.TabIndex = 6
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = True
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(152, 64)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 7
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 16)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "From Account No. :"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(336, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 16)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "To Account No. :"
        '
        'btnToSearch
        '
        Me.btnToSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSearch.ForeColor = System.Drawing.Color.Black
        Me.btnToSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnToSearch.Image = CType(resources.GetObject("btnToSearch.Image"), System.Drawing.Image)
        Me.btnToSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToSearch.Location = New System.Drawing.Point(600, 64)
        Me.btnToSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnToSearch.Name = "btnToSearch"
        Me.btnToSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnToSearch.TabIndex = 7
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 0
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(152, 280)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxValue = 0
        Me.txtRefno.MinValue = 0
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(160, 23)
        Me.txtRefno.TabIndex = 12
        Me.txtRefno.Text = "1"
        Me.txtRefno.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No. :"
        Me.Label4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "AvailableBalance : "
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblAvalBal.Location = New System.Drawing.Point(472, 136)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(31, 16)
        Me.lblAvalBal.TabIndex = 119
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(336, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "BookBalance : "
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblBookBal.Location = New System.Drawing.Point(472, 168)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(31, 16)
        Me.lblBookBal.TabIndex = 117
        Me.lblBookBal.Text = "0.0"
        Me.lblBookBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(152, 168)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Amount :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Account No"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(152, 200)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(448, 74)
        Me.txtNarration.SpecialChar = True
        Me.txtNarration.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(152, 104)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(352, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 8
        Me.txtName.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(288, 64)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 5
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(152, 136)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDepositDate.TabIndex = 9
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransfer.Location = New System.Drawing.Point(182, 488)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(128, 40)
        Me.btnTransfer.TabIndex = 14
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        Me.btnTransfer.Visible = False
        '
        'btnWithDraw
        '
        Me.btnWithDraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWithDraw.Location = New System.Drawing.Point(182, 488)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(128, 40)
        Me.btnWithDraw.TabIndex = 9
        Me.btnWithDraw.Text = "&Withdraw"
        Me.btnWithDraw.UseVisualStyleBackColor = False
        Me.btnWithDraw.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(456, 488)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnVerifyPhotoSign
        '
        Me.btnVerifyPhotoSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnVerifyPhotoSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifyPhotoSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerifyPhotoSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifyPhotoSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVerifyPhotoSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerifyPhotoSign.Location = New System.Drawing.Point(56, 488)
        Me.btnVerifyPhotoSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnVerifyPhotoSign.Name = "btnVerifyPhotoSign"
        Me.btnVerifyPhotoSign.Size = New System.Drawing.Size(120, 40)
        Me.btnVerifyPhotoSign.TabIndex = 13
        Me.btnVerifyPhotoSign.Text = "&Verify Signature"
        Me.btnVerifyPhotoSign.UseVisualStyleBackColor = False
        Me.btnVerifyPhotoSign.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton1.Location = New System.Drawing.Point(320, 488)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(128, 40)
        Me.NewButton1.TabIndex = 15
        Me.NewButton1.Text = "&Reset"
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'cmbChkCash
        '
        Me.cmbChkCash.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChkCash.FormattingEnabled = True
        Me.cmbChkCash.Items.AddRange(New Object() {"Cash", "Cheque"})
        Me.cmbChkCash.Location = New System.Drawing.Point(399, 32)
        Me.cmbChkCash.Name = "cmbChkCash"
        Me.cmbChkCash.Size = New System.Drawing.Size(99, 24)
        Me.cmbChkCash.TabIndex = 116
        '
        'cmbDepositWithdraw
        '
        Me.cmbDepositWithdraw.Enabled = False
        Me.cmbDepositWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositWithdraw.FormattingEnabled = True
        Me.cmbDepositWithdraw.Items.AddRange(New Object() {"Deposit", "Withdraw", "Transfer"})
        Me.cmbDepositWithdraw.Location = New System.Drawing.Point(277, 32)
        Me.cmbDepositWithdraw.Name = "cmbDepositWithdraw"
        Me.cmbDepositWithdraw.Size = New System.Drawing.Size(121, 24)
        Me.cmbDepositWithdraw.TabIndex = 115
        '
        'cmbAccount
        '
        Me.cmbAccount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccount.FormattingEnabled = True
        Me.cmbAccount.Items.AddRange(New Object() {"Savings Account", "Current Account", "Recurring Deposit"})
        Me.cmbAccount.Location = New System.Drawing.Point(101, 32)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.Size = New System.Drawing.Size(175, 24)
        Me.cmbAccount.TabIndex = 114
        '
        'lblTransation
        '
        Me.lblTransation.AutoSize = True
        Me.lblTransation.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblTransation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTransation.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransation.ForeColor = System.Drawing.Color.Black
        Me.lblTransation.Location = New System.Drawing.Point(70, 29)
        Me.lblTransation.Name = "lblTransation"
        Me.lblTransation.Size = New System.Drawing.Size(2, 25)
        Me.lblTransation.TabIndex = 127
        Me.lblTransation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransation.Visible = False
        '
        'cmbTransferToAc
        '
        Me.cmbTransferToAc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransferToAc.FormattingEnabled = True
        Me.cmbTransferToAc.Items.AddRange(New Object() {"", "Recurring Deposit", "Savings Account", "Current Account"})
        Me.cmbTransferToAc.Location = New System.Drawing.Point(499, 32)
        Me.cmbTransferToAc.Name = "cmbTransferToAc"
        Me.cmbTransferToAc.Size = New System.Drawing.Size(165, 24)
        Me.cmbTransferToAc.TabIndex = 128
        Me.cmbTransferToAc.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(104, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 16)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "From Account :"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label18.Location = New System.Drawing.Point(531, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "To Account :"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(280, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 16)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "Type :"
        Me.Label19.Visible = False
        '
        'frmCashTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(674, 546)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbTransferToAc)
        Me.Controls.Add(Me.lblTransation)
        Me.Controls.Add(Me.cmbChkCash)
        Me.Controls.Add(Me.cmbDepositWithdraw)
        Me.Controls.Add(Me.cmbAccount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnWithDraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnVerifyPhotoSign)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.NewButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCashTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Form Global Variables"
    Dim objCurrentAccount As New clsCurrentAccount
    Dim objSavingsBank As New clsSavingsBank
    Dim objRDAccount As New clsRDAccount
    Dim dblBookAmount As Double
    Dim dblAvalAmount As Double
    Dim ToolTip1 As New ToolTip
    Dim Counter As Integer = 0
    Dim objTempDt As New DataTable
    Dim dblMinAmount As Double
    Dim objStr As String
    Dim objLedger As New clsLedger
    Dim dblInterest1 As Double
    Dim dblCalIntrest As Double
    Dim dblInterest2 As Double
    Dim dblOverDrawLimit As Double
    Dim AutoIncreRefNo As Decimal
#End Region

#Region "SubRoutine And Functions"

    Public Sub sbClear()
        txtAmount.ResetText()
        txtNarration.ResetText()
        'txtRefno.ResetText()
        txtName.ResetText()
        'cmbAccountNo.SelectedIndex = -1
        lblAvalBal.Text = "0.0"
        lblBookBal.Text = "0.0"
        txtAccNo.Text = ""
        txtToAccountNo.ResetText()
        txtAccNo.Focus()
        AutoIncreRefNo = 0
    End Sub

    Function fnCheck() As Boolean
        If txtAccNo.Text = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
            'ElseIf Trim(txtRefno.Text) = String.Empty Then
            '    MsgBox("Enter reference number", MsgBoxStyle.Exclamation)
            '    txtRefno.Focus()
            '    Return False
        Else
            Return True
        End If
    End Function

    Sub sbloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
                If objSavingsBank.SBAccTable.Rows(0).Item("AccStatus") = "A" Then
                    txtAccNo.Text = objSavingsBank.SBAccTable.Rows(0).Item("AccountNo")
                    txtName.Text = objSavingsBank.SBAccTable.Rows(0).Item("Name")
                    dblBookAmount = objSavingsBank.SBAccTable.Rows(0).Item("BookBalance")
                    lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                    dblAvalAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    ToolTip1.SetToolTip(lblBookBal, GetFigures(dblBookAmount))
                Else
                    MsgBox("Account number " & Trim(txtAccNo.Text) & " is Closed", MsgBoxStyle.Information)
                    txtAccNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
            End If
        End If
    End Sub
    Sub caloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then
                If objCurrentAccount.CAAccTable.Rows(0).Item("AccStatus") = "A" Then
                    txtAccNo.Text = objCurrentAccount.CAAccTable.Rows(0).Item("CAccountNo")
                    txtName.Text = objCurrentAccount.CAAccTable.Rows(0).Item("Name")
                    dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    ToolTip1.SetToolTip(lblAvalBal, GetFigures(dblAvalAmount))
                    dblBookAmount = objCurrentAccount.CAAccTable.Rows(0).Item("BookBalance")
                    lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                    'dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
                    'lblODLimit.Text = Format(dblOverDrawLimit, "0,00.00")
                    'lblInterst.Text = objCurrentAccount.CAAccTable.Rows(0).Item("IntAmount")
                Else
                    MsgBox("This account no." & Trim(txtAccNo.Text) & " is already closed")
                    txtAccNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub
    Sub ca_To_Ac_loaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtToAccountNo.Text)) Then
                If objCurrentAccount.CAAccTable.Rows(0).Item("AccStatus") = "A" Then
                    txtToAccountNo.Text = objCurrentAccount.CAAccTable.Rows(0).Item("CAccountNo")
                    ''txtName.Text = objCurrentAccount.CAAccTable.Rows(0).Item("Name")
                    ''dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                    ''lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    ''ToolTip1.SetToolTip(lblAvalBal, GetFigures(dblAvalAmount))
                    ''dblBookAmount = objCurrentAccount.CAAccTable.Rows(0).Item("BookBalance")
                    ''lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                    'dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
                    'lblODLimit.Text = Format(dblOverDrawLimit, "0,00.00")
                    'lblInterst.Text = objCurrentAccount.CAAccTable.Rows(0).Item("IntAmount")
                Else
                    MsgBox("This account no." & Trim(txtAccNo.Text) & " is already closed")
                    txtAccNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub
    Sub rdloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objRDAccount.fnGetRDAccountDetails(Trim(txtAccNo.Text)) Then
                If objRDAccount.RDDetails.Rows(0).Item("Status") = "A" Then
                    txtAccNo.Text = objRDAccount.RDDetails.Rows(0).Item("RDNo")
                    txtName.Text = objRDAccount.RDDetails.Rows(0).Item("Name")
                    dblBookAmount = objRDAccount.RDDetails.Rows(0).Item("Balance")
                    lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                    dblAvalAmount = objRDAccount.RDDetails.Rows(0).Item("Balance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    ToolTip1.SetToolTip(lblBookBal, GetFigures(dblBookAmount))
                Else
                    MsgBox("Account number " & Trim(txtAccNo.Text) & " is Closed", MsgBoxStyle.Information)
                    txtAccNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
            End If
        End If
    End Sub
    Sub rd_To_Ac_loaddetails()
        If Trim(txtToAccountNo.Text) <> String.Empty Then
            If objRDAccount.fnGetRDAccountDetails(Trim(txtToAccountNo.Text)) Then
                If objRDAccount.RDDetails.Rows(0).Item("Status") = "A" Then
                    txtToAccountNo.Text = objRDAccount.RDDetails.Rows(0).Item("RDNo")
                    'txtName.Text = objRDAccount.RDDetails.Rows(0).Item("Name")
                    'dblBookAmount = objRDAccount.RDDetails.Rows(0).Item("Balance")
                    'lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                    'dblAvalAmount = objRDAccount.RDDetails.Rows(0).Item("Balance")
                    'lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    'ToolTip1.SetToolTip(lblBookBal, GetFigures(dblBookAmount))
                Else
                    MsgBox("Account number " & Trim(txtAccNo.Text) & " is Closed", MsgBoxStyle.Information)
                    txtAccNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
            End If
        End If
    End Sub


    Function fnGenerateVoucherD(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'Dim strNarration As String = "Deposit by cash" & " Narration:" & txtNarration.Text
        Dim strNarration As String = txtNarration.Text
        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)


        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Cash deposit by account" & txtAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by account " & txtAccNo.Text, "To", 10, 0, Val(txtAmount.Text), 1, "Y", objTrans)
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by account " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)

        Return True
    End Function


    Function fnGenerateVoucherW(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strNarration As String

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'strNarration = "Withdrawal by cash " & " Narration:" & txtNarration.Text
        strNarration = txtNarration.Text
        Try

            'Transaction Entry
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            ' If objTempDt.Rows .Count <0 Then
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objTrans)


            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Cash withdraw by account" & txtAccNo.Text, lngSlNo, "Y", objTrans)
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by account " & txtAccNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
        End Try


        Return True
    End Function

    Function fnGenerateVoucherT(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim refNo As Int32
        ' fnGenerateVoucherW()

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If Trim(txtRefno.Text) = "" Then
            refNo = 0
        Else
            refNo = Trim(txtRefno.Text)
        End If
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'To Account Transaction Entery
        'Dim strToAccNarration As String = "Received from " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        Dim strToAccNarration As String = txtNarration.Text
        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strToAccNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        'From Account Transaction Entery
        Dim strFromAccNarration As String = txtNarration.Text
        Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql1 = strsql1 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strFromAccNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql1, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Transfered by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Cash recived from account " & txtAccNo.Text, "To", 10, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Cash transfered to account " & txtToAccountNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
    Function fnGenerateVoucherSBToRDTransfer(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim refNo As Int32
        ' fnGenerateVoucherW()

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If Trim(txtRefno.Text) = "" Then
            refNo = 0
        Else
            refNo = Trim(txtRefno.Text)
        End If

        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'To Account Transaction Entery
        'Dim strToAccNarration As String = "Received from " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        strSQL = "Insert into RDTransactiontbl(AccountNo,TrDate,Narration,Deposit,WithDraw,PostBalance,RefNo,VoucherNo,Type,Cheque)"
        'strSQL = strSQL & "values('" & _strRDNo & "', '" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "','" & _intAmount & "',0,0,'" & _StrReference & "','" & lngVersionNo & "','Cash',0)"
        strSQL = strSQL & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & txtNarration.Text & "','" & Trim(txtAmount.Text) & "','0',ifnull(sum(Deposit)-sum(withdraw),0)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from RDTransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"

        fnExecuteNonQuery(strSQL, objTrans)

        'From Account Transaction Entery
        Dim strFromAccNarration As String = txtNarration.Text
        Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql1 = strsql1 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strFromAccNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql1, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Transfered by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Cash recived from account " & txtAccNo.Text, "To", 29, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Cash transfered to account " & txtToAccountNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
    Function fnGenerateVoucherCAToRDTransfer(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim refNo As Int32
        ' fnGenerateVoucherW()

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If Trim(txtRefno.Text) = "" Then
            refNo = 0
        Else
            refNo = Trim(txtRefno.Text)
        End If
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo)  as RefNo from catransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'To Account Transaction Entery
        'Dim strToAccNarration As String = "Received from " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        Dim strSQL1 = "Insert into RDTransactiontbl(AccountNo,TrDate,Narration,Deposit,WithDraw,PostBalance,RefNo,VoucherNo,Type,Cheque)"
        'strSQL = strSQL & "values('" & _strRDNo & "', '" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "','" & _intAmount & "',0,0,'" & _StrReference & "','" & lngVersionNo & "','Cash',0)"
        strSQL1 = strSQL1 & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & txtNarration.Text & "','" & Trim(txtAmount.Text) & "','0',ifnull(sum(Deposit)-sum(withdraw),0)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from RDTransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"

        fnExecuteNonQuery(strSQL1, objTrans)

        'From Account
        Dim strNarration As String = txtNarration.Text

        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Transfered by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Cash recived from account " & txtAccNo.Text, "To", 29, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Cash transfered to account " & txtToAccountNo.Text, "By", 11, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function

    Function fnGenerateVoucherFrmSBToCA(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim refNo As Int32
        ' fnGenerateVoucherW()

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If Trim(txtRefno.Text) = "" Then
            refNo = 0
        Else
            refNo = Trim(txtRefno.Text)
        End If
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'To Account Transaction Entery
        Dim strToAccNarration As String = txtNarration.Text
        Dim strsql2 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql2 = strsql2 & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strToAccNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest2 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtToAccountNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql2, objTrans)

        'From Account Transaction Entery
        Dim strFromAccNarration As String = txtNarration.Text
        Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql1 = strsql1 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strFromAccNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql1, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Transfered by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Cash recived from account " & txtAccNo.Text, "To", 11, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Cash transfered to account " & txtToAccountNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function

    Function fnGenerateVoucherFrmCAToSB(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim refNo As Int32
        ' fnGenerateVoucherW()

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If Trim(txtRefno.Text) = "" Then
            refNo = 0
        Else
            refNo = Trim(txtRefno.Text)
        End If
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'From Account Transaction Entery

        ''Dim strToAccNarration As String = txtNarration.Text
        ''Dim strsql2 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        ''strsql2 = strsql2 & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strToAccNarration & "','0','" & Trim(txtAmount.Text) & "','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest2 & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtToAccountNo.Text) & "' group by CAccountno"
        ''fnExecuteNonQuery(strsql2, objTrans)

        Dim strFromAccNarration As String = txtNarration.Text
        Dim strsql2 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql2 = strsql2 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strFromAccNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblInterest2 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql2, objTrans)
        ''To Account Transaction Entery

        ''Dim strFromAccNarration As String = txtNarration.Text
        ''Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        ''strsql1 = strsql1 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strFromAccNarration & "','" & Trim(txtAmount.Text) & "','0','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & refNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        ''fnExecuteNonQuery(strsql1, objTrans)
        Dim strToAccNarration As String = txtNarration.Text
        Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql1 = strsql1 & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & Trim(strToAccNarration) & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtToAccountNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql1, objTrans)


        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Transfered by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Cash recived from account " & txtAccNo.Text, "To", 10, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Cash transfered to account " & txtToAccountNo.Text, "By", 11, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
#End Region

#Region "Events"

    Private Sub rdDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDeposit.CheckedChanged
        btnDeposit.Visible = True
        btnTransfer.Visible = False
        btnWithDraw.Visible = False
        btnVerifyPhotoSign.Visible = False
        txtToAccountNo.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        btnToSearch.Visible = False
        Panel1.BackColor = Panel1.BackColor.PaleGreen()
    End Sub

    Private Sub rdWithdraw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdWithdraw.CheckedChanged
        btnDeposit.Visible = False
        btnTransfer.Visible = False
        btnWithDraw.Visible = True
        btnVerifyPhotoSign.Visible = True
        txtToAccountNo.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        btnToSearch.Visible = False
        Panel1.BackColor = Panel1.BackColor.Pink()
    End Sub

    Private Sub rdTransfer_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdTransfer.CheckedChanged
        btnDeposit.Visible = False
        btnTransfer.Visible = True
        btnWithDraw.Visible = False
        btnVerifyPhotoSign.Visible = False
        txtToAccountNo.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        btnToSearch.Visible = True
        Panel1.BackColor = Panel1.BackColor.PowderBlue()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If (cmbAccount.Text = "Savings Account") Then 'And cmbDepositWithdraw.Text = "Deposit" Or cmbDepositWithdraw.Text = "Withdraw" And cmbChkCash.Text = "Cash" Or cmbChkCash.Text = "Cheque") Then
            Dim objSBAccSearch As New frmSBAccSearch
            objSBAccSearch.strSBAccountNo = String.Empty
            objSBAccSearch.ShowDialog(Me)
            If objSBAccSearch.strSBAccountNo <> String.Empty Then
                txtAccNo.Text = objSBAccSearch.strSBAccountNo
                sbloaddetails()
            End If
            objSBAccSearch.Dispose()
        ElseIf (cmbAccount.Text = "Current Account") Then
            Dim objCAccSearch As New frmCAccSearch
            objCAccSearch.strCAccountNo = String.Empty
            objCAccSearch.ShowDialog(Me)
            If objCAccSearch.strCAccountNo <> String.Empty Then
                txtAccNo.Text = objCAccSearch.strCAccountNo
                caloaddetails()
            End If
            objCAccSearch.Dispose()

        ElseIf (cmbAccount.Text = "Recurring Deposit") Then
            Dim objfrmRDCust As New frmRDCust
            objfrmRDCust.strRDNo = ""
            objfrmRDCust.ShowDialog(Me)
            If objfrmRDCust.strRDNo <> "" Then
                txtAccNo.Text = objfrmRDCust.strRDNo
                txtName.Text = objfrmRDCust.strRDName
                fnGetBalance()
            End If
            objfrmRDCust.Dispose()

        End If
    End Sub
    Public Function fnGetBalance()

        If objRDAccount.fnGetBalance(txtToAccountNo.Text) Then
            'lblAvalBal.Text = objRDAccount.Balance.Rows(0).Item("Balance")
        End If

    End Function



    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim objTrans As IDbTransaction

        If (cmbAccount.Text = "Savings Account" And cmbDepositWithdraw.Text = "Deposit" And cmbChkCash.Text = "Cash") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = True
            objTrans = fnGetTransaction()
            Try
                If fnCheck() Then
                    If MsgBox("SB accountno  :  " & txtAccNo.Text & " " & Chr(13) & " Deposit amount  :  " & txtAmount.Text & " " & Chr(13) & " Type :  Cash") = MsgBoxResult.Ok Then

                        fnGenerateVoucherD(objTrans)
                        fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction deposit", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            sbClear()
                            txtAccNo.Focus()
                        Else
                            Me.Close()
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try


        ElseIf ((cmbAccount.Text = "Current Account") And (cmbDepositWithdraw.Text = "Deposit") And (cmbChkCash.Text = "Cash")) Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            objTrans = fnGetTransaction()
            Try
                If fnCheck() Then
                    If MsgBox("Current accountno:" & txtAccNo.Text & " " & Chr(13) & " Deposit Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type :  Cash") = MsgBoxResult.Ok Then
                        If fnSetdata() Then
                            fnGenerateVoucherCashD(objTrans)
                            fnLogEntry(pbUserId, "Cash deposit by account" & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Deposit", objTrans)
                            objTrans.Commit()
                            If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                sbClear()
                                caloaddetails()
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

        ElseIf ((cmbAccount.Text = "Recurring Deposit") And (cmbDepositWithdraw.Text = "Deposit") And (cmbChkCash.Text = "Cash")) Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            lblOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            Try
                objTrans = fnGetTransaction()
                'If fnChequeCheck() Then
                '' If fnCheckRefNo() = False Then
                If fnSetRDData() Then
                    fnGenerateVoucher(objTrans)
                    fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Deposit", objTrans)
                    objTrans.Commit()
                    If MsgBox("Transaction completed successfully and Reference number=" & AutoIncreRefNo & Chr(13) & "Do you want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        fnClear()
                        dtpDepositDate.Focus()
                    Else
                        Me.Close()
                    End If
                Else
                    MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Critical, "RD Module")
                End If
                ''Else
                ''MsgBox("Reference no already exist,please try other reference no", MsgBoxStyle.Exclamation, "RD Module")
                ''txtRefno.Focus()
                ''End If
                ' End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try


        ElseIf ((cmbAccount.Text = "Savings Account") And (cmbDepositWithdraw.Text = "Deposit") And (cmbChkCash.Text = "Cheque")) Then
            Label12.Visible = True
            txtChequeNo.Visible = True
            Label11.Visible = True
            txtOthers.Visible = True
            Label14.Visible = True
            txtBranchName.Visible = True
            txtChequeDate.Visible = True
            ''Label4.Visible = True
            Try
                objTrans = fnGetTransaction()
                If fnCheckSBChequeDeposit() Then
                    If fnSetSavingsChequeData() Then
                        If objSavingsBank.fnGetDepositedCheque(Trim(txtChequeNo.Text)) Or objSavingsBank.fnCheckChequeLeafNo(Trim(txtChequeNo.Text)) Then
                            MsgBox("Cheque number is already present in DataBase", MsgBoxStyle.Information)
                        Else

                            If fnSBTransaction(objTrans) Then
                                If objSavingsBank.fnAddDepositedCheque(objTrans) = True Then
                                    fnLogEntry(pbUserId, "Cheque deposited by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Cheque Deposit", objTrans)
                                    objTrans.Commit()
                                    If MsgBox("Cheque deposited sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & "Do you want another transactoin", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                        btnAdd_Click(sender, e)
                                    Else
                                        Me.Close()
                                    End If
                                Else
                                    MsgBox("Cheque deposition failed due to internal error", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Cheque deposition failed due to internal error", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                objTrans.Dispose()
            End Try

        ElseIf ((cmbAccount.Text = "Current Account") And (cmbDepositWithdraw.Text = "Deposit") And (cmbChkCash.Text = "Cheque")) Then
            objTrans = fnGetTransaction()
            Try
                If fnCheckCheque() Then
                    If fnSetDataCashCheque() Then
                        If objCurrentAccount.fnGetDepositedCheque(Trim(txtChequeNo.Text)) Or objCurrentAccount.fnCheckChequeLeafNo(Trim(txtChequeNo.Text)) Then
                            MsgBox("Cheque number is already present in database", MsgBoxStyle.Information)
                            txtChequeNo.Focus()
                        Else

                            If fnSBTransaction(objTrans) Then
                                If objCurrentAccount.fnAddDepositedCheque(objTrans) = True Then
                                    fnLogEntry(pbUserId, "Cheque deposited by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Cheque deposited", objTrans)
                                    objTrans.Commit()
                                    If MsgBox("Cheque deposited sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & "Do you want deposit another cheque ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                        sbClear()
                                        txtChequeNo.Focus()
                                    Else
                                        Me.Close()
                                    End If
                                Else
                                    MsgBox("Cheque deposition failed due to internal error", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Cheque deposition failed due to internal error", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                objTrans.Dispose()
            End Try
        End If
    End Sub

#End Region

    'Private Sub txtPGAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRDAccNo.TextChanged

    '    If txtRDAccNo.Text.StartsWith("RD") = False Then
    '        txtRDAccNo.Undo()
    '        txtRDAccNo.ClearUndo()
    '    End If

    'End Sub

    Public Function fnCheckRefNo() As Boolean

        If objRDAccount.fnCheckRefNo(txtRefno.Text) Then
            MsgBox("Reference no already exist,try another RefNo ", MsgBoxStyle.Information)
            Return True
        Else
            Return False
        End If

    End Function
    Function fnCheckSBChequeDeposit() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountNo", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf Trim(txtBankName.Text) = String.Empty Then
            MsgBox("Enter bank name", MsgBoxStyle.Information)
            txtBankName.Focus()
            Return False
        ElseIf Trim(txtBranchName.Text) = String.Empty Then
            MsgBox("Enter branch name", MsgBoxStyle.Information)
            txtBranchName.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Function fnSetDataCashCheque() As Boolean
        objCurrentAccount.BankName = txtBankName.Text
        objCurrentAccount.BranchName = txtBranchName.Text
        objCurrentAccount.ChequeDate = dtpDepositDate.Value
        objCurrentAccount.ChequeNo = txtChequeNo.Text
        objCurrentAccount.ChequeDepositDate = dtpDepositDate.Value

        objCurrentAccount.CurAccountNo = txtAccNo.Text
        objCurrentAccount.ChequeAmount = txtAmount.Text
        objCurrentAccount.ChequeStatus = "Pending"
        objCurrentAccount.Remarks = txtNarration.Text

        Return True
    End Function
    Function fnCheckCheque() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Exclamation)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtBankName.Text) = String.Empty Then
            MsgBox("Enter bank name", MsgBoxStyle.Exclamation)
            txtBankName.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles btnAdd.Click
        sbClear()
        txtAccNo.Text = ""
        txtName.ResetText()
        txtAccNo.Focus()
    End Sub
    Function fnSBTransaction(ByVal objTrnas As IDbTransaction) As Boolean

        Try
            'Dim strNarration As String = "Cheque deposited " & "Cheque No " & txtChequeNo.Text & " Narration:" & txtNarration.Text
            Dim strNarration As String = txtNarration.Text
            ''Auto increment num as a Ref number
            Dim strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

            'Transaction Entry

            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,RefNo,VoucherNo,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw),'" & AutoIncreRefNo & "','0','Cheque','" & Trim(txtChequeNo.Text) & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objTrnas)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function
    Function fnChequeCheck() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountNo", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf Trim(txtBankName.Text) = String.Empty Then
            MsgBox("Enter bank name", MsgBoxStyle.Information)
            txtBankName.Focus()
            Return False
        ElseIf Trim(txtBranchName.Text) = String.Empty Then
            MsgBox("Enter branch name", MsgBoxStyle.Information)
            txtBranchName.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Public Function fnSetRDData() As Boolean

        objRDAccount.Amount = txtAmount.Text
        objRDAccount.Reference = txtRefno.Text
        objRDAccount.TransDate = dtpDepositDate.Value
        objRDAccount.RDNo = txtAccNo.Text
        objRDAccount.Narration = txtNarration.Text

        Return True

    End Function
    Function fnGenerateVoucherCashD(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(SlNo) as RefNo from catransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        ' Dim strNarration As String = "Cash deposit by " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        Dim strNarration As String = txtNarration.Text
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If Val(dblAvalAmount) < 0 Then
            Dim dblTempBalance As Double = Val(dblAvalAmount) + Val(txtAmount.Text)

            If dblTempBalance < 0 Then

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 12, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            Else

                If dblTempBalance <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 11, 0, Abs(dblTempBalance), 1, "Y", objTrans)
                End If

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 12, 0, Abs(dblAvalAmount), 2, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 3, "Y", objTrans)
            End If
        Else
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 11, 0, Val(txtAmount.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        End If

        Return True

    End Function
    Public Function fnClear()

        txtAmount.Text = ""
        txtRefno.Text = ""
        'txtRDAccNo.Text = "RD"
        txtNarration.Text = ""
        'txtRDName.Text = ""
        btnSearch.Enabled = True
        'lblBalance.Text = "0.00"
        'txtOthers.ResetText()
        fnGetBalance()
        AutoIncreRefNo = 0
    End Function
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngvoucherno As Long
        Dim lngslno As Long

        lngvoucherno = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngslno = fnVoucherGetNewSlNo()

        'transaction entery
        AutoIncreRefNo = objRDAccount.fnInsertTransaction(lngvoucherno, objTrans)


        If Val(txtOthers.Text) <> 0 Then

            'voucher details
            fnVoucherEnterMain(lngvoucherno, 2, txtToAccountNo.Text, AutoIncreRefNo, dtpDepositDate.Value, Val(txtAmount.Text) + Val(txtOthers.Text), "Deposit by" & txtToAccountNo.Text, lngslno, "y", objTrans)

            'credit accounts
            fnVoucherEnterSub(lngvoucherno, 2, txtToAccountNo.Text, dtpDepositDate.Value, "Deposit by RD account " & txtToAccountNo.Text, "To", 29, 0, Val(txtAmount.Text), 1, "y", objTrans)

            'credit accounts
            fnVoucherEnterSub(lngvoucherno, 2, txtToAccountNo.Text, dtpDepositDate.Value, "Misc charges paid by account " & txtToAccountNo.Text, "To", 13, 0, Val(txtOthers.Text), 2, "Y", objTrans)

            'debit accounts 
            fnVoucherEnterSub(lngvoucherno, 2, " ", dtpDepositDate.Value, "Deposit by RD account " & txtToAccountNo.Text, "By", 1, Val(txtAmount.Text) + Val(txtOthers.Text), 0, 3, "y", objTrans)

        Else

            'voucher details
            fnVoucherEnterMain(lngvoucherno, 2, txtToAccountNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Deposit by" & txtToAccountNo.Text, lngslno, "y", objTrans)

            'credit accounts
            fnVoucherEnterSub(lngvoucherno, 2, txtToAccountNo.Text, dtpDepositDate.Value, "Deposit by RD account " & txtToAccountNo.Text, "To", 29, 0, Val(txtAmount.Text), 1, "y", objTrans)

            'debit accounts 
            fnVoucherEnterSub(lngvoucherno, 2, " ", dtpDepositDate.Value, "Deposit by RD account " & txtToAccountNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "y", objTrans)

        End If

        Return True

    End Function

    Function fnSetdata() As Boolean
        objCurrentAccount.CurAccountNo = txtAccNo.Text
        objCurrentAccount.Accdate = dtpDepositDate.Value
        Return True
    End Function
    Function fnSetSavingsChequeData() As Boolean
        objSavingsBank.SBNo = Trim(txtAccNo.Text)
        objSavingsBank.BankName = txtBankName.Text
        objSavingsBank.BranchName = txtBranchName.Text
        objSavingsBank.ChequeDate = dtpDepositDate.Value
        objSavingsBank.ChequeNo = txtChequeNo.Text
        objSavingsBank.ChequeDepositDate = dtpDepositDate.Value
        objSavingsBank.ChequeAmount = txtAmount.Text
        objSavingsBank.ChequeStatus = "Pending"
        objSavingsBank.Remarks = txtNarration.Text
        Return True
    End Function

    Private Function fnCheckFund() As Boolean
        ''Check availabilities of cash (1 is the ledgerID)
        If (objLedger.fnGetCBalanceWRTLedger(1)) Then
            If (objLedger.LedgerTable.Rows(0).Item("Balance") > Val(txtAmount.Text)) Then
                Return True
            Else
                MsgBox("Insufficient fund,please check the cash", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If

    End Function
    Private Function fnCheckBalance() As Boolean
        ''Check available balance in account
        If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
            If objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") < Val(txtAmount.Text) Then
                MsgBox("Low balance in the account,please check account", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            ElseIf objSavingsBank.fnGetMasterSetting() Then
                If objSavingsBank.SBMasterTable.Rows(0).Item("SBminAmount") > (objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") - Val(txtAmount.Text)) Then
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

    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click
        Dim objTrans As IDbTransaction
        If (cmbAccount.Text = "Savings Account" And cmbDepositWithdraw.Text = "Withdraw" And cmbChkCash.Text = "Cash") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False

            Try
                objTrans = fnGetTransaction()

                If fnCheck() Then
                    'If rdWithdraw.Checked = True Then
                    'If fnCheckFund() Then
                    If fnCheckBalance() Then
                        If MsgBox("SB accountno  :  " & txtAccNo.Text & " " & Chr(13) & Chr(13) & "WithDraw amount  :  " & txtAmount.Text & " " & Chr(13) & Chr(13) & "Type  :  Cash", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                            fnGenerateVoucherW(objTrans)
                            fnLogEntry(pbUserId, "WithDraw BY " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction withdraw", objTrans)
                            objTrans.Commit()
                            If MsgBox("Transaction completed sucessfully and Reference No=" & AutoIncreRefNo & Chr(13) & " Do You Want To Make Another Transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                sbClear()
                                txtAccNo.Focus()
                            Else
                                Me.Close()
                            End If
                        End If
                    End If
                    'End If
                    'End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try

        ElseIf ((cmbAccount.Text = "Current Account") And (cmbDepositWithdraw.Text = "Withdraw") And (cmbChkCash.Text = "Cash")) Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            objTrans = fnGetTransaction()
            Try
                If fnCheck() Then
                    'If rdWithdraw.Checked = True Then
                    'If fnCheckFund() Then
                    If fnCheakBalance() Then
                        If MsgBox("Current accountno  :  " & txtAccNo.Text & " " & Chr(13) & " WithDraw Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cash", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                            If fnSetdata() Then
                                fnGenerateVoucherCashAccountW(objTrans)
                                fnLogEntry(pbUserId, "Cash withdraw by account " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Withdraw", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                    sbClear()
                                    caloaddetails()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                        'End If
                    End If
                    'End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                objTrans.Dispose()
            End Try
        ElseIf (cmbAccount.Text = "Savings Account" And cmbDepositWithdraw.Text = "Withdraw" And cmbChkCash.Text = "Cheque") Then

            Try
                objTrans = fnGetTransaction()
                If fnCheckSB() Then
                    If fnGetCheqkExistanceSB() Then
                        If objSavingsBank.fnCheckChequeLeafNo(txtChequeNo.Text) Then
                            If objSavingsBank.SBCheckBookBookTable.Rows(0).Item("Status") = "Stopped" Then
                                MsgBox("Sorry! cheque has been stopped", MsgBoxStyle.Critical)
                            Else
                                MsgBox("Sorry! cheque is already withdrawn ", MsgBoxStyle.Critical)
                            End If
                        Else
                            If fnSetDataSB() Then
                                If fnCheckBalanceSB() Then
                                    If MsgBox("SB accountno :" & txtAccNo.Text & " " & Chr(13) & " WithDraw Amount :" & txtAmount.Text & " " & Chr(13) & " Cheque No : " & txtChequeNo.Text) = MsgBoxResult.Ok Then

                                        fnGenerateVoucherSB(objTrans)
                                        fnLogEntry(pbUserId, "Cheque withdraw by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Withdraw", objTrans)
                                        objTrans.Commit()
                                        If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & "Do you want make another transaction", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                                            sbClear()
                                            sbloaddetails()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try

        ElseIf ((cmbAccount.Text = "Current Account") And (cmbDepositWithdraw.Text = "Withdraw") And (cmbChkCash.Text = "Cheque")) Then
            objTrans = fnGetTransaction()
            Try
                If fnCheckCACheque() Then
                    If fnGetCheqkExistance() Then
                        If Not objCurrentAccount.fnCheckChequeLeafNo(Trim(txtChequeNo.Text)) Then
                            If fnCheckFund() Then
                                If fnCheakBalance() Then
                                    If MsgBox("Current accountno :  " & txtAccNo.Text & " " & Chr(13) & " WithDraw Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cheque", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                                        If fnSetdata() Then

                                            fnGenerateVoucherCA(objTrans)
                                            fnLogEntry(pbUserId, "Cheque withdraw by account " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction withdraw", objTrans)
                                            objTrans.Commit()
                                            If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                                caClear()
                                                caloaddetails()
                                            Else
                                                Me.Close()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Me.Close()
                        Else
                            If objCurrentAccount.CACheckBookBookTable.Rows(0).Item("Status") = "Stopped" Then
                                MsgBox("Sorry! cheque has been stopped", MsgBoxStyle.Critical)
                            Else
                                MsgBox("Sorry! cheque is already withdrawn ", MsgBoxStyle.Critical)
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                objTrans.Dispose()
            End Try
        End If
    End Sub
    Function fnGenerateVoucherSB(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strNarration As String

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        If cmbTranType.SelectedItem = "Clearing Cheque" Then
            ' strNarration = "Clearing Cheque By " & txtName.Text & " Cheque No " & txtChequeNo.Text & " Narration:  " & txtNarration.Text
            strNarration = txtNarration.Text
        ElseIf cmbTranType.SelectedItem = "Cheque Withdraw" Then
            'strNarration = "Cheque Withdrawal By " & txtName.Text & " Cheque No " & txtChequeNo.Text & " Narration:  " & txtNarration.Text
            strNarration = txtNarration.Text
        End If
        ''Auto increment num as a Ref number
        Dim strsql3 = "select  max(RefNo) from sbtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'Transaction Entery
        Dim strsql As String = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cheque','" & Trim(txtChequeNo.Text) & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        strsql = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,VoucherNo,Narration) Values( '" & txtAccNo.Text & "',' ','','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & txtChequeNo.Text & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & Val(txtAmount.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','0.00','Cleared','" & AutoIncreRefNo & "','" & txtNarration.Text & "')"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Cheque withdraw by account " & txtAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
    Function fnCheckBalanceSB() As Boolean
        If lblAvalBal.Text - Val(txtAmount.Text) < 0 Then
            MsgBox("WithDrawl amount is greater than the balance amount", MsgBoxStyle.Exclamation, "SB Module")
            txtAmount.Text = ""
            txtAmount.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Function fnSetDataSB() As Boolean
        objSavingsBank.SBNo = Trim(txtAccNo.Text)
        objSavingsBank.ChequeNo = txtChequeNo.Text
        objSavingsBank.ChequeDepositDate = dtpDepositDate.Value
        objSavingsBank.ChequeAmount = txtAmount.Text
        objSavingsBank.Remarks = txtNarration.Text
        Return True
    End Function
    Function fnGetCheqkExistanceSB()
        If objSavingsBank.fnGetCheckDet(Trim(txtChequeNo.Text), Trim(txtAccNo.Text)) Then
            Return True
        Else
            MsgBox("Cheque no " & Trim(txtChequeNo.Text) & " Dosent Belong to Account " & Trim(txtAccNo.Text))
            Return False
        End If
    End Function
    Function fnCheckSB() As Boolean
        If Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf Val(lblAvalBal.Text) < 0 Then
            MsgBox("Enter valid amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
            ''ElseIf Trim(txtRefno.Text) = String.Empty Then
            ''    MsgBox("Enter reference number", MsgBoxStyle.Information)
            ''    txtRefno.Focus()
            ''    Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf cmbTranType.SelectedIndex = -1 Then
            MsgBox("Select transaction type", MsgBoxStyle.Information)
            cmbTranType.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Sub caClear()
        txtChequeNo.ResetText()
        txtBookNo.ResetText()
        txtAmount.ResetText()
        txtNarration.ResetText()
        txtRefno.ResetText()
    End Sub

    Function fnGenerateVoucherCA(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strNarration As String

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        If cmbTranType.SelectedItem = "Clearing Cheque" Then
            'strNarration = "Clearing Cheque By " & txtName.Text & " Cheque No " & txtChequeNo.Text & " Narration:  " & txtNarration.Text
            strNarration = txtNarration.Text
        ElseIf cmbTranType.SelectedItem = "Cheque Withdraw" Then
            ' strNarration = "Cheque Withdrawal By " & txtName.Text & " Cheque No " & txtChequeNo.Text & " Narration:  " & txtNarration.Text
            strNarration = txtNarration.Text
        End If
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo)  as RefNo from catransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1


        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblCalIntrest & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','cheque','" & Trim(txtChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)


        strsql = "Insert into caChequeDeposittbl(CAccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,VoucherNo,Narration)"
        strsql = strsql & " Values( '" & txtAccNo.Text & "',' ','  ','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & txtChequeNo.Text & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','" & Val(txtAmount.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd") & "','0.00',' Cleared ','" & AutoIncreRefNo & "','" & txtNarration.Text & "')"
        fnExecuteNonQuery(strsql, objTrans)

        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Cheque Wwithdraw by account  " & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If dblAvalAmount <= 0 Then
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cheque withdraw by account  " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cheque withdraw by account  " & txtAccNo.Text, "By", 12, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtAmount.Text)
            If dblTempBalance < 0 Then
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 2, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 12, Abs(dblTempBalance), 0, 3, "Y", objTrans)
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cheque withdraw by account " & txtAccNo.Text, "By", 11, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            End If
        End If

        Return True
    End Function
    Function fnGetCheqkExistance()
        If objCurrentAccount.fnGetCheckDet(Trim(txtChequeNo.Text), Trim(txtAccNo.Text)) Then
            Return True
        Else
            MsgBox("Cheque no " & Trim(txtChequeNo.Text) & " Dosent belong to CAccount " & Trim(txtAccNo.Text))
            Return False
        End If
    End Function

    Function fnCheckCACheque() As Boolean
        If Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtChequeNo.Focus()
            Return False
        ElseIf cmbTranType.SelectedIndex = -1 Then
            MsgBox("Select transaction type", MsgBoxStyle.Information)
            cmbTranType.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
            ''ElseIf Trim(txtRefno.Text) = String.Empty Then
            ''    MsgBox("Enter reference number", MsgBoxStyle.Information)
            ''    txtRefno.Focus()
            ''    Return False
        Else
            Return True
        End If
    End Function
    Function fnGenerateVoucherCashAccountW(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        'Dim strNarration As String = "Cash withdraw by " & txtAccNo.Text & " Narration:" & txtNarration.Text
        Dim strsql3 = "select max(SlNo) as RefNo from catransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1


        Dim strNarration As String = txtNarration.Text
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Cash withdraw by " & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If dblAvalAmount <= 0 Then
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 12, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtAmount.Text)
            If dblTempBalance < 0 Then
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 2, "Y", objTrans)

                ' If dblTempBalance <> 0 Then
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 12, Abs(dblTempBalance), 0, 3, "Y", objTrans)
                'End If
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 11, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            End If
        End If
        Return True
    End Function
    Private Function fnCheakBalance() As Boolean

        If objCurrentAccount.fnGetCAccountDetails(txtAccNo.Text) Then
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

    Private Sub frmCashTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Label12.Visible = False
        'txtChequeNo.Visible = False
        'Label11.Visible = False
        'txtOthers.Visible = False
        'Label14.Visible = False
        'txtBranchName.Visible = False
        'txtChequeDate.Visible = False
        'Label4.Visible = False
        'txtBankName.Visible = False
        'Label13.Visible = False
        'Label4.Visible = True
        'Label15.Visible = False
        'cmbTranType.Visible = False
        'Label16.Visible = False
        'txtBookNo.Visible = False
        'Label9.Visible = False
        'txtToAccountNo.Visible = False
        'btnToSearch.Visible = False
        'Panel1.BackColor = Panel1.BackColor.PaleGreen()
        dtpDepositDate.Value = Date.Now
        If Trim(txtAccNo.Text <> String.Empty) Then
            sbloaddetails()
        Else
            txtAccNo.Focus()
        End If
    End Sub



    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        If Trim(txtAccNo.Text <> String.Empty) Then
            AutoLoad()
            If cmbAccount.SelectedItem = "Savings Account" Then
                If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
                    If objSavingsBank.SBAccTable.Rows(0).Item("AccStatus") = "C" Then
                        MsgBox("Account number " & Trim(txtAccNo.Text) & " is closed", MsgBoxStyle.Information)
                        txtAccNo.ResetText()
                        txtAccNo.Focus()
                    Else
                        sbloaddetails()
                    End If

                End If
            ElseIf cmbAccount.SelectedItem = "Current Account" Then
                If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then

                    If objCurrentAccount.CAAccTable.Rows(0).Item("AccStatus") = "C" Then
                        MsgBox("Account number " & Trim(txtAccNo.Text) & " is closed", MsgBoxStyle.Information)
                        txtAccNo.ResetText()
                        txtAccNo.Focus()
                    Else
                        caloaddetails()
                    End If

                End If
            ElseIf cmbAccount.SelectedItem = "Recurring Deposit" Then
                If objRDAccount.fnGetRDAccountDetails(Trim(txtAccNo.Text)) Then
                    If objRDAccount.RDDetails.Rows(0).Item("Status") = "C" Then
                        MsgBox("Account number " & Trim(txtAccNo.Text) & " is closed", MsgBoxStyle.Information)
                        txtAccNo.ResetText()
                        txtAccNo.Focus()
                    Else
                        rdloaddetails()
                    End If

                End If
            Else
                MsgBox("To account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.ResetText()
                txtAccNo.Focus()

            End If
        End If
    End Sub

    Private Sub btnVerifyPhotoSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyPhotoSign.Click
        If txtAccNo.Text <> String.Empty Then
            Dim ObjPhotoSign As New frmSBSignPhoto
            ObjPhotoSign.txtAccno.Text = Me.txtAccNo.Text
            ObjPhotoSign.txtName.Text = Me.txtName.Text
            ObjPhotoSign.ShowDialog(Me)
        Else
            MsgBox("Enter account number", MsgBoxStyle.Information, "SB Module")
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim objTrans As IDbTransaction
        If (cmbDepositWithdraw.Text = "Transfer" And cmbAccount.Text = "Savings Account" And cmbTransferToAc.Text = "Savings Account") Then

            Try
                objTrans = fnGetTransaction()
                If fnCheck() Then
                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter to account number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account number should not be the same", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheckBalance() Then
                            If MsgBox("SB accountno :" & txtAccNo.Text & " " & Chr(13) & Chr(13) & " Transfer Amount:" & txtAmount.Text & " " & Chr(13) & Chr(13) & " Type:Transfer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                                fnGenerateVoucherT(objTrans)
                                fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction transfer", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then


                                    sbClear()
                                    txtAccNo.Focus()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try

        ElseIf (cmbDepositWithdraw.Text = "Transfer" And cmbAccount.Text = "Current Account" And cmbTransferToAc.Text = "Current Account") Then
            objTrans = fnGetTransaction()

            Try

                If fnCATransferCheck() Then

                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter to account number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account no. sould not be same", MsgBoxStyle.Information)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheakBalanceCATransfer() Then
                            If MsgBox("Current accountno  :  " & txtAccNo.Text & " " & Chr(13) & " Transfer Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Transfer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                                If fnSetdataCATransfer() Then
                                    fnGenerateVoucherT_CATransfer(objTrans)
                                    fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " amount " & txtAmount.Text, Date.Now, "Transaction Transfer", objTrans)
                                    objTrans.Commit()
                                    If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & " ,Do tou want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                        sbClear()
                                        caloaddetails()
                                    Else
                                        Me.Close()
                                    End If
                                End If
                            End If
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                objTrans.Dispose()
            End Try

        ElseIf (cmbDepositWithdraw.Text = "Transfer" And cmbAccount.Text = "Savings Account" And cmbTransferToAc.Text = "Recurring Deposit") Then
            Try
                objTrans = fnGetTransaction()
                If fnCheck() Then
                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter to account number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account number should not be the same", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheckBalance() Then
                            If MsgBox("SB accountno :" & txtAccNo.Text & " " & Chr(13) & Chr(13) & " Transfer Amount:" & txtAmount.Text & " " & Chr(13) & Chr(13) & " Type:Transfer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                                fnGenerateVoucherSBToRDTransfer(objTrans)
                                fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction transfer", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                    sbClear()
                                    txtAccNo.Focus()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try


        ElseIf (cmbDepositWithdraw.Text = "Transfer" And cmbAccount.Text = "Savings Account" And cmbTransferToAc.Text = "Current Account") Then

            Try
                objTrans = fnGetTransaction()
                If fnCheck() Then
                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter to account number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account number should not be the same", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheckBalance() Then
                            If MsgBox("SB accountno :" & txtAccNo.Text & " " & Chr(13) & Chr(13) & " Transfer Amount:" & txtAmount.Text & " " & Chr(13) & Chr(13) & " Type:Transfer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                                fnGenerateVoucherFrmSBToCA(objTrans)
                                fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction transfer", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                    sbClear()
                                    txtAccNo.Focus()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try


        ElseIf (cmbDepositWithdraw.Text = "Transfer" And cmbAccount.Text = "Current Account" And cmbTransferToAc.Text = "Recurring Deposit") Then
            Try
                objTrans = fnGetTransaction()
                If fnCheck() Then
                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter to account number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account number should not be the same", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheakBalanceCATransfer() Then
                            If MsgBox("CA accountno :" & txtAccNo.Text & " " & Chr(13) & Chr(13) & " Transfer Amount:" & txtAmount.Text & " " & Chr(13) & Chr(13) & " Type:Transfer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                                fnGenerateVoucherCAToRDTransfer(objTrans)
                                fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction transfer", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                    sbClear()
                                    txtAccNo.Focus()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try

        ElseIf (cmbDepositWithdraw.Text = "Transfer" And cmbAccount.Text = "Current Account" And cmbTransferToAc.Text = "Savings Account") Then

            Try
                objTrans = fnGetTransaction()
                If fnCheck() Then
                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter to account number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account number should not be the same", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheakBalance() Then
                            If MsgBox("CA accountno :" & txtAccNo.Text & " " & Chr(13) & Chr(13) & " Transfer Amount:" & txtAmount.Text & " " & Chr(13) & Chr(13) & " Type:Transfer", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                                fnGenerateVoucherFrmCAToSB(objTrans)
                                fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction transfer", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully and Reference number=" & AutoIncreRefNo & Chr(13) & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                    sbClear()
                                    txtAccNo.Focus()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try

        Else
            MsgBox("This type of transfer not given", MsgBoxStyle.Exclamation)
        End If

    End Sub
    Function fnGenerateVoucherT_CATransfer(ByVal objTrans As IDbTransaction) As Boolean

        Dim dblAmount As Double

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo)  as RefNo from catransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1


        'Transaction Entery

        'Dim strNarration As String = "Transfer by " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        Dim strNarration As String = txtNarration.Text
        ' objSavingsBank.fnUpdateStatus(lngVoucherNo, strNarration)
        'From Account
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)
        'To Account
        ' Dim strAccountNo As String = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("AccountNo")
        Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql1 = strsql1 & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest2 & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtToAccountNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql1, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, AutoIncreRefNo, dtpDepositDate.Value, txtAmount.Text, "Transfer by" & txtAccNo.Text, lngSlNo, "Y", objTrans)


        If dblAvalAmount <= 0 Then
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtAccNo.Text, "By", 12, Val(txtAmount.Text), 0, 1, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtAmount.Text)
            If dblTempBalance < 0 Then
                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtToAccountNo.Text, "By", 11, Abs(dblAvalAmount), 0, 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtToAccountNo.Text, "By", 12, Abs(dblTempBalance), 0, 2, "Y", objTrans)
            Else
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtToAccountNo.Text, "By", 11, Val(txtAmount.Text), 0, 1, "Y", objTrans)
            End If
        End If


        If objCurrentAccount.fnGetCAccountDetails(Trim(txtToAccountNo.Text)) Then
            dblAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")

            If Val(dblAmount) < 0 Then
                Dim dblTempBalance As Double = Val(dblAmount) + Val(txtAmount.Text)

                If dblTempBalance < 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "to", 12, 0, Val(txtAmount.Text), 2, "Y", objTrans)
                Else
                    If dblTempBalance <> 0 Then
                        'Credit accounts 
                        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "To", 11, 0, Abs(dblTempBalance), 2, "Y", objTrans)
                    End If
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "To", 12, 0, Abs(dblAvalAmount), 2, "Y", objTrans)
                End If
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "To", 11, 0, Val(txtAmount.Text), 2, "Y", objTrans)
            End If

        End If

        Return True

    End Function
    Function fnSetdataCATransfer() As Boolean
        objCurrentAccount.CurAccountNo = txtAccNo.Text
        objCurrentAccount.Accdate = dtpDepositDate.Value
        Return True
    End Function

    Private Function fnCheakBalanceCATransfer() As Boolean

        If objCurrentAccount.fnGetCAccountDetails(txtAccNo.Text) Then
            dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
            dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
            If Val(txtAmount.Text) > Val(dblAvalAmount) + Val(dblOverDrawLimit) Then
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
    Function fnCATransferCheck() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter account no.", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
            'ElseIf Trim(txtRefno.Text) = String.Empty Then
            '    MsgBox("Enter reference no.", MsgBoxStyle.Exclamation)
            '    txtRefno.Focus()
            '    Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnToSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToSearch.Click
        If cmbDepositWithdraw.Text = "Transfer" Then
            If (cmbTransferToAc.Text = "Savings Account") Then 'And cmbDepositWithdraw.Text = "Deposit" Or cmbDepositWithdraw.Text = "Withdraw" And cmbChkCash.Text = "Cash" Or cmbChkCash.Text = "Cheque") Then
                Dim objSBAccSearch As New frmSBAccSearch
                objSBAccSearch.strSBAccountNo = String.Empty
                objSBAccSearch.ShowDialog(Me)
                If objSBAccSearch.strSBAccountNo <> String.Empty Then
                    txtToAccountNo.Text = objSBAccSearch.strSBAccountNo
                    sbloaddetails()
                End If
                objSBAccSearch.Dispose()
            ElseIf (cmbTransferToAc.Text = "Current Account") Then
                Dim objCAccSearch As New frmCAccSearch
                objCAccSearch.strCAccountNo = String.Empty
                objCAccSearch.ShowDialog(Me)
                If objCAccSearch.strCAccountNo <> String.Empty Then
                    txtToAccountNo.Text = objCAccSearch.strCAccountNo
                    'caloaddetails()
                End If
                objCAccSearch.Dispose()
            ElseIf cmbTransferToAc.Text = "Recurring Deposit" Then
                Dim objfrmRDCust As New frmRDCust
                objfrmRDCust.strRDNo = ""
                objfrmRDCust.ShowDialog(Me)
                If objfrmRDCust.strRDNo <> "" Then
                    txtToAccountNo.Text = objfrmRDCust.strRDNo
                    'txtName.Text = objfrmRDCust.strRDName
                    fnGetBalance()
                End If
                objfrmRDCust.Dispose()
            ElseIf cmbTransferToAc.Text = "Fixed Deposit" Then
                Dim objfrmFDSearch As New frmFDSearch
                objfrmFDSearch.strFDNo = ""
                objfrmFDSearch.ShowDialog(Me)
                If objfrmFDSearch.strFDNo <> "" Then
                    txtToAccountNo.Text = objfrmFDSearch.strFDNo
                    'txtName.Text = objfrmRDCust.strRDName
                    fnGetBalance()
                End If
                objfrmFDSearch.Dispose()
            End If
        End If
    End Sub

    Public Sub AutoLoad()
        Select Case txtAccNo.Text.Length
            Case "1"
                If (cmbAccount.SelectedItem = "Savings Account") Then
                    txtAccNo.Text = "SB0000" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Current Account") Then
                    txtAccNo.Text = "CA0000" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Recurring Deposit") Then
                    txtAccNo.Text = "RD0000" & txtAccNo.Text
                End If
            Case "2"
                If (cmbAccount.SelectedItem = "Savings Account") Then
                    txtAccNo.Text = "SB000" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Current Account") Then
                    txtAccNo.Text = "CA000" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Recurring Deposit") Then
                    txtAccNo.Text = "RD000" & txtAccNo.Text
                End If
            Case "3"
                If (cmbAccount.SelectedItem = "Savings Account") Then
                    txtAccNo.Text = "SB00" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Current Account") Then
                    txtAccNo.Text = "CA00" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Recurring Deposit") Then
                    txtAccNo.Text = "RD00" & txtAccNo.Text
                End If
            Case "4"
                If (cmbAccount.SelectedItem = "Savings Account") Then
                    txtAccNo.Text = "SB0" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Current Account") Then
                    txtAccNo.Text = "CA0" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Recurring Deposit") Then
                    txtAccNo.Text = "RD0" & txtAccNo.Text
                End If
            Case "5"
                If (cmbAccount.SelectedItem = "Savings Account") Then
                    txtAccNo.Text = "SB" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Current Account") Then
                    txtAccNo.Text = "CA" & txtAccNo.Text
                ElseIf (cmbAccount.SelectedItem = "Recurring Deposit") Then
                    txtAccNo.Text = "RD" & txtAccNo.Text
                End If
            Case Else
                MsgBox("Account should be with in 5 digits", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        End Select
    End Sub
    Public Sub AutoLoadTo()
        Select Case txtToAccountNo.Text.Length
            Case "1"
                If (cmbTransferToAc.SelectedItem = "Savings Account") Then
                    txtToAccountNo.Text = "SB0000" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Current Account") Then
                    txtToAccountNo.Text = "CA0000" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Recurring Deposit") Then
                    txtToAccountNo.Text = "RD0000" & txtToAccountNo.Text
                End If
            Case "2"
                If (cmbTransferToAc.SelectedItem = "Savings Account") Then
                    txtToAccountNo.Text = "SB000" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Current Account") Then
                    txtToAccountNo.Text = "CA000" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Recurring Deposit") Then
                    txtToAccountNo.Text = "RD000" & txtToAccountNo.Text
                End If
            Case "3"
                If (cmbTransferToAc.SelectedItem = "Savings Account") Then
                    txtToAccountNo.Text = "SB00" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Current Account") Then
                    txtToAccountNo.Text = "CA00" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Recurring Deposit") Then
                    txtToAccountNo.Text = "RD00" & txtToAccountNo.Text
                End If
            Case "4"
                If (cmbTransferToAc.SelectedItem = "Savings Account") Then
                    txtToAccountNo.Text = "SB0" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Current Account") Then
                    txtToAccountNo.Text = "CA0" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Recurring Deposit") Then
                    txtToAccountNo.Text = "RD0" & txtToAccountNo.Text
                End If
            Case "5"
                If (cmbTransferToAc.SelectedItem = "Savings Account") Then
                    txtToAccountNo.Text = "SB" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Current Account") Then
                    txtToAccountNo.Text = "CA" & txtToAccountNo.Text
                ElseIf (cmbTransferToAc.SelectedItem = "Recurring Deposit") Then
                    txtToAccountNo.Text = "RD" & txtToAccountNo.Text
                End If
            Case Else
                MsgBox("Account number should be with in 5 digits", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
                '    Case "1"
                '        txtToAccountNo.Text = "SB0000" & txtToAccountNo.Text
                '    Case "2"
                '        txtToAccountNo.Text = "SB000" & txtToAccountNo.Text
                '    Case "3"
                '        txtToAccountNo.Text = "SB00" & txtToAccountNo.Text
                '    Case "4"
                '        txtToAccountNo.Text = "SB0" & txtToAccountNo.Text
                '    Case "5"
                '        txtToAccountNo.Text = "SB" & txtToAccountNo.Text
        End Select
    End Sub

    Private Sub txtToAccountNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtToAccountNo.Leave
        If Trim(txtToAccountNo.Text <> String.Empty) Then
            AutoLoadTo()
            If cmbTransferToAc.SelectedItem = "Savings Account" Then
                If objSavingsBank.fnGetSBAccountDetails(Trim(txtToAccountNo.Text)) Then
                    If objSavingsBank.SBAccTable.Rows(0).Item("AccStatus") = "C" Then
                        MsgBox("Account number " & Trim(txtToAccountNo.Text) & " is closed", MsgBoxStyle.Information)
                        txtToAccountNo.ResetText()
                        txtToAccountNo.Focus()
                    End If
                Else
                    sbloaddetails()
                End If
            ElseIf cmbTransferToAc.SelectedItem = "Current Account" Then
                If objCurrentAccount.fnGetCAccountDetails(Trim(txtToAccountNo.Text)) Then
                    If objCurrentAccount.CAAccTable.Rows(0).Item("AccStatus") = "C" Then
                        MsgBox("Account number " & Trim(txtToAccountNo.Text) & " is closed", MsgBoxStyle.Information)
                        txtToAccountNo.ResetText()
                        txtToAccountNo.Focus()
                    Else
                        ca_To_Ac_loaddetails()
                    End If
                End If
            ElseIf cmbTransferToAc.SelectedItem = "Recurring Deposit" Then
                If objRDAccount.fnGetRDAccountDetails(Trim(txtToAccountNo.Text)) Then
                    If objRDAccount.RDDetails.Rows(0).Item("Status") = "C" Then
                        MsgBox("Account number " & Trim(txtToAccountNo.Text) & " is closed", MsgBoxStyle.Information)
                        txtToAccountNo.ResetText()
                        txtToAccountNo.Focus()
                    Else
                        rd_To_Ac_loaddetails()
                    End If
                End If
            Else
                MsgBox("To account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtToAccountNo.ResetText()
                txtToAccountNo.Focus()
            End If
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        sbClear()
    End Sub
    Private Sub cmbAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccount.TextChanged
        If (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnWithDraw.Visible = True
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
            lblTransation.Text = "Savings Account Deposited by Cash"
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnDeposit.Visible = True
            cmbTransferToAc.Visible = False
            btnVerifyPhotoSign.Visible = False
            lblTransation.Text = "Savings Account Deposited by Cash"
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = True
            txtChequeNo.Visible = True
            Label11.Visible = True
            txtOthers.Visible = True
            Label14.Visible = True
            txtBranchName.Visible = True
            txtChequeDate.Visible = True
            ''Label4.Visible = True
            lblOthers.Visible = True
            txtBankName.Visible = True
            Label13.Visible = True
            txtRefno.Visible = False
            Label4.Visible = False
            lblOthers.Visible = False
            txtOthers.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnDeposit.Visible = True
            cmbTransferToAc.Visible = False
            btnVerifyPhotoSign.Visible = False
            lblTransation.Text = "Savings Account Deposited by Cheque"
            Panel1.BackColor = Panel1.BackColor.PaleGreen()

        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Savings Account") Then
            Label15.Visible = True
            cmbTranType.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            '''txtRefno.Visible = True
            ''Label4.Visible = True
            Label14.Visible = False
            txtChequeDate.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtChequeNo.Visible = True
            Label12.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            btnWithDraw.Visible = True
            cmbTransferToAc.Visible = False
            btnVerifyPhotoSign.Visible = True
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = True
            cmbTranType.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            Label12.Visible = True
            txtChequeNo.Visible = True
            btnWithDraw.Visible = True
            btnVerifyPhotoSign.Visible = True
            ''txtRefno.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            Label4.Visible = False
            txtRefno.Visible = False
            Label14.Visible = True
            Label11.Visible = True
            txtBankName.Visible = True
            Label13.Visible = True
            txtBranchName.Visible = True
            Label12.Visible = True
            txtChequeNo.Visible = True
            btnDeposit.Visible = True
            txtChequeDate.Visible = True
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnWithDraw.Visible = True
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            txtOthers.Visible = False
            txtBankName.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
            Label16.Visible = False
            txtBookNo.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            btnDeposit.Visible = True
            cmbTransferToAc.Visible = False
            btnVerifyPhotoSign.Visible = False
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Recurring Deposit") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = True
            lblOthers.Visible = True
            txtChequeDate.Visible = False
            btnDeposit.Visible = True
            cmbTransferToAc.Visible = False
            btnVerifyPhotoSign.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbAccount.Text = "Savings Account") Then
            lblTransation.Text = "Savings Account"
            cmbDepositWithdraw.Enabled = True
            'Panel1.BackColor = Panel1.BackColor.PaleGreen()
            lblOthers.Visible = False
            txtOthers.Visible = False

        ElseIf (cmbAccount.Text = "Current Account") Then
            lblTransation.Text = "Current Account"
            cmbDepositWithdraw.Enabled = True
            'Panel1.BackColor = Panel1.BackColor.Pink()
            lblOthers.Visible = False
            txtOthers.Visible = False

        ElseIf (cmbAccount.Text = "Recurring Deposit") Then
            lblTransation.Text = "Recurring"
            cmbDepositWithdraw.Enabled = True
            'Panel1.BackColor = Panel1.BackColor.PowderBlue()
            lblOthers.Visible = True
            txtOthers.Visible = True
        End If

    End Sub



    Private Sub cmbDepositWithdraw_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositWithdraw.TextChanged
        If (cmbDepositWithdraw.Text = "Transfer") Then
            Panel1.BackColor = Panel1.BackColor.PowderBlue()
            Label9.Visible = True
            btnToSearch.Visible = True
            txtToAccountNo.Visible = True
            btnTransfer.Visible = True
            btnVerifyPhotoSign.Visible = False
            btnWithDraw.Visible = False
            btnDeposit.Visible = False
            txtChequeDate.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            txtBranchName.Visible = False
            cmbTransferToAc.Visible = True
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Savings Account") Then
            Label15.Visible = True
            cmbTranType.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            ''txtRefno.Visible = True
            ''Label4.Visible = True
            Label14.Visible = False
            txtChequeDate.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtChequeNo.Visible = True
            Label12.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            Label9.Visible = False
            txtToAccountNo.Visible = False
            btnToSearch.Visible = False
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = True
            txtChequeNo.Visible = True
            Label11.Visible = True
            txtOthers.Visible = True
            Label14.Visible = True
            txtBranchName.Visible = True
            txtChequeDate.Visible = True
            ''Label4.Visible = True
            lblOthers.Visible = True
            txtBankName.Visible = True
            Label13.Visible = True
            txtRefno.Visible = False
            Label4.Visible = False
            lblOthers.Visible = False
            txtOthers.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            Label9.Visible = False
            txtToAccountNo.Visible = False
            btnToSearch.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            cmbTransferToAc.Visible = False
            lblTransation.Text = "Savings Account Deposited by Cheque"
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            txtToAccountNo.Visible = False
            btnToSearch.Visible = False
            Label9.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            ''Label4.Visible = True
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            cmbTransferToAc.Visible = False
            txtToAccountNo.Visible = False
            Label9.Visible = False
            btnToSearch.Visible = False
            lblTransation.Text = "Savings Account Deposited by Cash"
            Panel1.BackColor = Panel1.BackColor.PaleGreen()

        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = True
            cmbTranType.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            Label12.Visible = True
            txtChequeNo.Visible = True
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            ''txtRefno.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            Label4.Visible = False
            txtRefno.Visible = False
            Label14.Visible = True
            Label11.Visible = True
            txtBankName.Visible = True
            Label13.Visible = True
            txtBranchName.Visible = True
            Label12.Visible = True
            txtChequeNo.Visible = True
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            txtChequeDate.Visible = True
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            cmbTransferToAc.Visible = False
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = True
            txtToAccountNo.Visible = False
            Label9.Visible = False
            btnToSearch.Visible = False
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            txtOthers.Visible = False
            txtBankName.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
            Label16.Visible = False
            txtBookNo.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            cmbTransferToAc.Visible = False
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Recurring Deposit") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            cmbTransferToAc.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = True
            lblOthers.Visible = True
            txtChequeDate.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbDepositWithdraw.Text = "Deposit") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            Label9.Visible = False
            txtToAccountNo.Visible = False
            btnToSearch.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbDepositWithdraw.Text = "Withdraw") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            Label9.Visible = False
            txtToAccountNo.Visible = False
            btnToSearch.Visible = False
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            Panel1.BackColor = Panel1.BackColor.Pink()
            lblTransation.Text = "Savings Account Deposited by Cash"
        End If
    End Sub


    Private Sub cmbChkCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChkCash.TextChanged

        If (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            Label4.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            Panel1.BackColor = Panel1.BackColor.Pink()
            lblTransation.Text = "Savings Account Deposited by Cash"
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = False
            txtChequeNo.Visible = False
            Label11.Visible = False
            txtOthers.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            txtChequeDate.Visible = False
            txtBankName.Visible = False
            Label13.Visible = False
            ''Label4.Visible = True
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            ''txtRefno.Visible = True
            lblTransation.Text = "Savings Account Deposited by Cash"
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Savings Account") Then
            Label12.Visible = True
            txtChequeNo.Visible = True
            Label11.Visible = True
            txtOthers.Visible = True
            Label14.Visible = True
            txtBranchName.Visible = True
            txtChequeDate.Visible = True
            ''Label4.Visible = True
            lblOthers.Visible = True
            txtBankName.Visible = True
            Label13.Visible = True
            txtRefno.Visible = False
            Label4.Visible = False
            lblOthers.Visible = False
            txtOthers.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            lblTransation.Text = "Savings Account Deposited by Cheque"
            Panel1.BackColor = Panel1.BackColor.PaleGreen()

        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Savings Account") Then
            Label15.Visible = True
            cmbTranType.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            ''txtRefno.Visible = True
            ''Label4.Visible = True
            Label14.Visible = False
            txtChequeDate.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtChequeNo.Visible = True
            Label12.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = True
            cmbTranType.Visible = True
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            Label12.Visible = True
            txtChequeNo.Visible = True
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            ''txtRefno.Visible = True
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            Label4.Visible = False
            txtRefno.Visible = False
            Label14.Visible = True
            Label11.Visible = True
            txtBankName.Visible = True
            Label13.Visible = True
            txtBranchName.Visible = True
            Label12.Visible = True
            txtChequeNo.Visible = True
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            txtChequeDate.Visible = True
            btnVerifyPhotoSign.Visible = True
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Withdraw" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            btnWithDraw.Visible = True
            btnDeposit.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = True
            Panel1.BackColor = Panel1.BackColor.Pink()
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Current Account") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = True
            txtBookNo.Visible = True
            txtBankName.Visible = False
            Label11.Visible = False
            txtChequeNo.Visible = False
            Label12.Visible = False
            Label14.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = False
            txtChequeDate.Visible = False
            txtOthers.Visible = False
            txtBankName.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()
            Label16.Visible = False
            txtBookNo.Visible = False
            Label15.Visible = False
            cmbTranType.Visible = False
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
        ElseIf (cmbChkCash.Text = "Cash" And cmbDepositWithdraw.Text = "Deposit" And cmbAccount.Text = "Recurring Deposit") Then
            Label15.Visible = False
            cmbTranType.Visible = False
            Label16.Visible = False
            txtBookNo.Visible = False
            txtBankName.Visible = False
            Label11.Visible = False
            txtBranchName.Visible = False
            Label13.Visible = False
            txtOthers.Visible = True
            lblOthers.Visible = True
            txtChequeDate.Visible = False
            btnDeposit.Visible = True
            btnTransfer.Visible = False
            btnVerifyPhotoSign.Visible = False
            Panel1.BackColor = Panel1.BackColor.PaleGreen()

        End If
    End Sub


    Private Sub txtChequeNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChequeNo.Leave
        If (cmbAccount.Text = "Savings Account" And cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw") Then
            Try
                If Trim(txtChequeNo.Text) <> "" Then
                    If objSavingsBank.fnGetChecks(Trim(txtChequeNo.Text)) = True Then
                        txtAccNo.Text = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("AccountNo")
                        txtName.Text = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("Name")
                        sbloaddetails()
                    Else
                        MsgBox("Sorry! cheque is from other bank ", MsgBoxStyle.Critical)
                        txtChequeNo.Focus()
                        txtChequeNo.SelectAll()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        ElseIf (cmbAccount.Text = "Current Account" And cmbChkCash.Text = "Cheque" And cmbDepositWithdraw.Text = "Withdraw") Then
            If Trim(txtChequeNo.Text) <> String.Empty Then
                If objCurrentAccount.fnGetCheques(Trim(txtChequeNo.Text)) = True Then
                    txtAccNo.Text = objCurrentAccount.CACheckBookBookTable.Rows(0).Item("CAccountNO")
                    txtBookNo.Text = objCurrentAccount.CACheckBookBookTable.Rows(0).Item("Book_SNo")
                    caloaddetails()
                Else
                    MsgBox("Sorry! cheque is from other bank ", MsgBoxStyle.Critical)
                    txtChequeNo.Focus()
                    txtChequeNo.SelectAll()
                End If
            End If

        End If

    End Sub


    Private Sub cmbTransferToAc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTransferToAc.TextChanged
        If cmbDepositWithdraw.Text = "Transfer" Then
            If cmbTransferToAc.Text = "Recurring Deposit" Then

            End If
        End If
    End Sub



End Class

