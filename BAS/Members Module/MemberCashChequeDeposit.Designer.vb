<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberCashChequeDeposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberCashChequeDeposit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUpdateAmount = New BankControls.NumericControl()
        Me.txtVoucherDate = New BankControls.TextControl()
        Me.txtVoucherNo = New BankControls.TextControl()
        Me.BtnDelete = New BankControls.NewButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReferenceNo = New BankControls.TextControl()
        Me.txtBalanceAmount = New BankControls.NumericControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMemberSearch = New BankControls.NewButton()
        Me.btnReset = New BankControls.NewButton()
        Me.btnSave = New BankControls.NewButton()
        Me.btnCancel = New BankControls.NewButton()
        Me.txtPaidAmount = New BankControls.NumericControl()
        Me.txtBankName = New BankControls.TextControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBranchName = New BankControls.TextControl()
        Me.txtChequeNo = New BankControls.TextControl()
        Me.dtpDepositdate = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New BankControls.TextControl()
        Me.txtMemberNo = New BankControls.TextControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New BankControls.TextControl()
        Me.lvMemDepositDetails = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUpdateAmount)
        Me.GroupBox1.Controls.Add(Me.txtVoucherDate)
        Me.GroupBox1.Controls.Add(Me.txtVoucherNo)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtReferenceNo)
        Me.GroupBox1.Controls.Add(Me.txtBalanceAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnMemberSearch)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.txtPaidAmount)
        Me.GroupBox1.Controls.Add(Me.txtBankName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBranchName)
        Me.GroupBox1.Controls.Add(Me.txtChequeNo)
        Me.GroupBox1.Controls.Add(Me.dtpDepositdate)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.txtMemberNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtUpdateAmount
        '
        Me.txtUpdateAmount.AfterDecimal = 0
        Me.txtUpdateAmount.BeforeDecimal = 8
        Me.txtUpdateAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtUpdateAmount.Location = New System.Drawing.Point(11, 213)
        Me.txtUpdateAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtUpdateAmount.MaxLength = 10
        Me.txtUpdateAmount.MaxValue = 0.0R
        Me.txtUpdateAmount.MinValue = 0.0R
        Me.txtUpdateAmount.Name = "txtUpdateAmount"
        Me.txtUpdateAmount.Size = New System.Drawing.Size(119, 23)
        Me.txtUpdateAmount.TabIndex = 27
        Me.txtUpdateAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUpdateAmount.Visible = False
        '
        'txtVoucherDate
        '
        Me.txtVoucherDate.AlphaNumeric = True
        Me.txtVoucherDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtVoucherDate.BlankSpace = True
        Me.txtVoucherDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherDate.GotFocusColour = System.Drawing.SystemColors.ControlLightLight
        Me.txtVoucherDate.Location = New System.Drawing.Point(77, 144)
        Me.txtVoucherDate.LostFocusColour = System.Drawing.Color.White
        Me.txtVoucherDate.Mandatory = False
        Me.txtVoucherDate.MaxLength = 35
        Me.txtVoucherDate.Name = "txtVoucherDate"
        Me.txtVoucherDate.ReadOnly = True
        Me.txtVoucherDate.Size = New System.Drawing.Size(178, 23)
        Me.txtVoucherDate.SpecialChar = False
        Me.txtVoucherDate.TabIndex = 26
        Me.txtVoucherDate.Visible = False
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.AlphaNumeric = True
        Me.txtVoucherNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtVoucherNo.BlankSpace = True
        Me.txtVoucherNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherNo.GotFocusColour = System.Drawing.SystemColors.ControlLightLight
        Me.txtVoucherNo.Location = New System.Drawing.Point(11, 169)
        Me.txtVoucherNo.LostFocusColour = System.Drawing.Color.White
        Me.txtVoucherNo.Mandatory = False
        Me.txtVoucherNo.MaxLength = 35
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.ReadOnly = True
        Me.txtVoucherNo.Size = New System.Drawing.Size(119, 23)
        Me.txtVoucherNo.SpecialChar = False
        Me.txtVoucherNo.TabIndex = 25
        Me.txtVoucherNo.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.GotFocusColour = System.Drawing.Color.Red
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(287, 263)
        Me.BtnDelete.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(104, 40)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(331, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Reference No.:"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AlphaNumeric = True
        Me.txtReferenceNo.BlankSpace = True
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(440, 148)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReferenceNo.Mandatory = False
        Me.txtReferenceNo.MaxLength = 35
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReferenceNo.SpecialChar = False
        Me.txtReferenceNo.TabIndex = 18
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.AfterDecimal = 0
        Me.txtBalanceAmount.BeforeDecimal = 8
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalanceAmount.Location = New System.Drawing.Point(136, 87)
        Me.txtBalanceAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBalanceAmount.MaxLength = 10
        Me.txtBalanceAmount.MaxValue = 0.0R
        Me.txtBalanceAmount.MinValue = 0.0R
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.ReadOnly = True
        Me.txtBalanceAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtBalanceAmount.TabIndex = 6
        Me.txtBalanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Due Amount :"
        '
        'btnMemberSearch
        '
        Me.btnMemberSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemberSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemberSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemberSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnMemberSearch.Image = CType(resources.GetObject("btnMemberSearch.Image"), System.Drawing.Image)
        Me.btnMemberSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemberSearch.Location = New System.Drawing.Point(280, 24)
        Me.btnMemberSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnMemberSearch.Name = "btnMemberSearch"
        Me.btnMemberSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemberSearch.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(137, 263)
        Me.btnReset.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 40)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(397, 263)
        Me.btnSave.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 40)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(501, 263)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.AfterDecimal = 0
        Me.txtPaidAmount.BeforeDecimal = 8
        Me.txtPaidAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPaidAmount.Location = New System.Drawing.Point(136, 119)
        Me.txtPaidAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPaidAmount.MaxLength = 10
        Me.txtPaidAmount.MaxValue = 0.0R
        Me.txtPaidAmount.MinValue = 0.0R
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtPaidAmount.TabIndex = 8
        Me.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(440, 87)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 35
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(200, 23)
        Me.txtBankName.SpecialChar = False
        Me.txtBankName.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bank Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Branch Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(332, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cheque No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Member No :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Deposit Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Paid Amount :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Remarks:"
        '
        'txtBranchName
        '
        Me.txtBranchName.AlphaNumeric = True
        Me.txtBranchName.BlankSpace = True
        Me.txtBranchName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBranchName.Location = New System.Drawing.Point(440, 119)
        Me.txtBranchName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBranchName.Mandatory = False
        Me.txtBranchName.MaxLength = 35
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(200, 23)
        Me.txtBranchName.SpecialChar = False
        Me.txtBranchName.TabIndex = 16
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BlankSpace = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(440, 56)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.MaxLength = 15
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(136, 23)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 12
        '
        'dtpDepositdate
        '
        Me.dtpDepositdate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDepositdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositdate.Location = New System.Drawing.Point(136, 53)
        Me.dtpDepositdate.MaxDate = New Date(9998, 11, 17, 0, 0, 0, 0)
        Me.dtpDepositdate.Name = "dtpDepositdate"
        Me.dtpDepositdate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDepositdate.TabIndex = 4
        Me.dtpDepositdate.Value = New Date(2008, 2, 13, 0, 0, 0, 0)
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(136, 186)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(464, 64)
        Me.txtRemarks.SpecialChar = False
        Me.txtRemarks.TabIndex = 20
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BlankSpace = False
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMemberNo.Location = New System.Drawing.Point(136, 24)
        Me.txtMemberNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.Size = New System.Drawing.Size(136, 23)
        Me.txtMemberNo.SpecialChar = False
        Me.txtMemberNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.ControlLightLight
        Me.txtName.Location = New System.Drawing.Point(440, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 10
        '
        'lvMemDepositDetails
        '
        Me.lvMemDepositDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader10, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader11})
        Me.lvMemDepositDetails.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lvMemDepositDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvMemDepositDetails.FullRowSelect = True
        Me.lvMemDepositDetails.GridLines = True
        Me.lvMemDepositDetails.Location = New System.Drawing.Point(12, 324)
        Me.lvMemDepositDetails.MultiSelect = False
        Me.lvMemDepositDetails.Name = "lvMemDepositDetails"
        Me.lvMemDepositDetails.Size = New System.Drawing.Size(681, 205)
        Me.lvMemDepositDetails.TabIndex = 1
        Me.lvMemDepositDetails.UseCompatibleStateImageBehavior = False
        Me.lvMemDepositDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Deposit"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Withdraw"
        Me.ColumnHeader9.Width = 25
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Paid"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Narration"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cheque No."
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Bank Name"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Branch Name"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Reference No."
        Me.ColumnHeader7.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TrDate"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "VoucherNo"
        '
        'MemberCashChequeDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 534)
        Me.Controls.Add(Me.lvMemDepositDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MemberCashChequeDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Share Balance Amount Deposit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMemberSearch As BankControls.NewButton
    Friend WithEvents btnReset As BankControls.NewButton
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtPaidAmount As BankControls.NumericControl
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As BankControls.TextControl
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents dtpDepositdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtBalanceAmount As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNo As BankControls.TextControl
    Friend WithEvents lvMemDepositDetails As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnDelete As BankControls.NewButton
    Friend WithEvents txtVoucherDate As BankControls.TextControl
    Friend WithEvents txtVoucherNo As BankControls.TextControl
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtUpdateAmount As BankControls.NumericControl
End Class
