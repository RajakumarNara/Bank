Public Class frmLoanAppliers
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchText As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvLoanList As System.Windows.Forms.ListView
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents lblLoanList As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRepayment As BankControls.NewButton
    Friend WithEvents btnLoanDisb As BankControls.NewButton
    Friend WithEvents btnLoanTran As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVehicleLoan As BankControls.NewButton
    Friend WithEvents btnHandLoan As BankControls.NewButton
    Friend WithEvents btnColleteralHandLoan As BankControls.NewButton
    Friend WithEvents btnSuretyLoan As BankControls.NewButton
    Friend WithEvents btnLoansonTermDeposit As BankControls.NewButton
    Friend WithEvents btnDailyRecoveryLoan As BankControls.NewButton
    Friend WithEvents btnJewelLoan As BankControls.NewButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearchText = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblLoanList = New System.Windows.Forms.Label
        Me.lvLoanList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.NewButton6 = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NewButton1 = New BankControls.NewButton
        Me.btnRepayment = New BankControls.NewButton
        Me.btnLoanDisb = New BankControls.NewButton
        Me.btnLoanTran = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDailyRecoveryLoan = New BankControls.NewButton
        Me.btnLoansonTermDeposit = New BankControls.NewButton
        Me.btnSuretyLoan = New BankControls.NewButton
        Me.btnColleteralHandLoan = New BankControls.NewButton
        Me.btnHandLoan = New BankControls.NewButton
        Me.btnVehicleLoan = New BankControls.NewButton
        Me.btnJewelLoan = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearchText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(216, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 48)
        Me.Panel1.TabIndex = 0
        '
        'txtSearchText
        '
        Me.txtSearchText.AlphaNumeric = True
        Me.txtSearchText.BlankSpace = True
        Me.txtSearchText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearchText.Location = New System.Drawing.Point(520, 8)
        Me.txtSearchText.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSearchText.Mandatory = False
        Me.txtSearchText.MaxLength = 30
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(193, 24)
        Me.txtSearchText.SpecialChar = True
        Me.txtSearchText.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Search Text :"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"Name", "LoanNo", ""})
        Me.cmbSearchBy.Location = New System.Drawing.Point(152, 8)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(184, 24)
        Me.cmbSearchBy.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Search By :"
        '
        'lblLoanList
        '
        Me.lblLoanList.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblLoanList.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLoanList.Location = New System.Drawing.Point(240, 16)
        Me.lblLoanList.Name = "lblLoanList"
        Me.lblLoanList.Size = New System.Drawing.Size(728, 24)
        Me.lblLoanList.TabIndex = 1
        '
        'lvLoanList
        '
        Me.lvLoanList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader16, Me.ColumnHeader15, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvLoanList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoanList.FullRowSelect = True
        Me.lvLoanList.GridLines = True
        Me.lvLoanList.Location = New System.Drawing.Point(216, 104)
        Me.lvLoanList.Name = "lvLoanList"
        Me.lvLoanList.Size = New System.Drawing.Size(784, 456)
        Me.lvLoanList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvLoanList.TabIndex = 2
        Me.lvLoanList.UseCompatibleStateImageBehavior = False
        Me.lvLoanList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LoanNo"
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 216
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SancAmount"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Disbursed  Amount"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Int Receivable"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 74
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Sanc Date"
        Me.ColumnHeader15.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "LastPaidDate"
        Me.ColumnHeader6.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 95
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DueDate"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "SancNo"
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ROI"
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "NOI"
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Instralemenr Amt"
        Me.ColumnHeader12.Width = 90
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "RepayMode"
        Me.ColumnHeader13.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "SecurityDeposit"
        Me.ColumnHeader14.Width = 90
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.IndianRed
        Me.NewButton6.Location = New System.Drawing.Point(848, 576)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(112, 40)
        Me.NewButton6.TabIndex = 4
        Me.NewButton6.Text = "&Close"
        Me.NewButton6.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NewButton1)
        Me.GroupBox2.Controls.Add(Me.btnRepayment)
        Me.GroupBox2.Controls.Add(Me.btnLoanDisb)
        Me.GroupBox2.Controls.Add(Me.btnLoanTran)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 216)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.NewButton1.Location = New System.Drawing.Point(8, 160)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(174, 40)
        Me.NewButton1.TabIndex = 11
        Me.NewButton1.Text = "Additional Charges"
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'btnRepayment
        '
        Me.btnRepayment.AllowDrop = True
        Me.btnRepayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnRepayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepayment.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRepayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRepayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepayment.ForeColor = System.Drawing.Color.Black
        Me.btnRepayment.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnRepayment.Location = New System.Drawing.Point(8, 16)
        Me.btnRepayment.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnRepayment.Name = "btnRepayment"
        Me.btnRepayment.Size = New System.Drawing.Size(174, 40)
        Me.btnRepayment.TabIndex = 8
        Me.btnRepayment.Text = "Loan Re-Payment"
        Me.btnRepayment.UseVisualStyleBackColor = False
        '
        'btnLoanDisb
        '
        Me.btnLoanDisb.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLoanDisb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanDisb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoanDisb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanDisb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanDisb.ForeColor = System.Drawing.Color.Black
        Me.btnLoanDisb.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnLoanDisb.Location = New System.Drawing.Point(8, 64)
        Me.btnLoanDisb.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLoanDisb.Name = "btnLoanDisb"
        Me.btnLoanDisb.Size = New System.Drawing.Size(174, 40)
        Me.btnLoanDisb.TabIndex = 9
        Me.btnLoanDisb.Text = "Loan Disbursment"
        Me.btnLoanDisb.UseVisualStyleBackColor = False
        '
        'btnLoanTran
        '
        Me.btnLoanTran.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLoanTran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanTran.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoanTran.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanTran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanTran.ForeColor = System.Drawing.Color.Black
        Me.btnLoanTran.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnLoanTran.Location = New System.Drawing.Point(8, 112)
        Me.btnLoanTran.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLoanTran.Name = "btnLoanTran"
        Me.btnLoanTran.Size = New System.Drawing.Size(174, 40)
        Me.btnLoanTran.TabIndex = 10
        Me.btnLoanTran.Text = " Loan Transaction Details Print"
        Me.btnLoanTran.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnDailyRecoveryLoan)
        Me.GroupBox1.Controls.Add(Me.btnLoansonTermDeposit)
        Me.GroupBox1.Controls.Add(Me.btnSuretyLoan)
        Me.GroupBox1.Controls.Add(Me.btnColleteralHandLoan)
        Me.GroupBox1.Controls.Add(Me.btnHandLoan)
        Me.GroupBox1.Controls.Add(Me.btnVehicleLoan)
        Me.GroupBox1.Controls.Add(Me.btnJewelLoan)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 352)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btnDailyRecoveryLoan
        '
        Me.btnDailyRecoveryLoan.AllowDrop = True
        Me.btnDailyRecoveryLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnDailyRecoveryLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDailyRecoveryLoan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDailyRecoveryLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDailyRecoveryLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyRecoveryLoan.ForeColor = System.Drawing.Color.Black
        Me.btnDailyRecoveryLoan.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnDailyRecoveryLoan.Location = New System.Drawing.Point(16, 304)
        Me.btnDailyRecoveryLoan.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnDailyRecoveryLoan.Name = "btnDailyRecoveryLoan"
        Me.btnDailyRecoveryLoan.Size = New System.Drawing.Size(174, 40)
        Me.btnDailyRecoveryLoan.TabIndex = 17
        Me.btnDailyRecoveryLoan.Text = "&Daily Recovery Loan"
        Me.btnDailyRecoveryLoan.UseVisualStyleBackColor = False
        '
        'btnLoansonTermDeposit
        '
        Me.btnLoansonTermDeposit.AllowDrop = True
        Me.btnLoansonTermDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLoansonTermDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoansonTermDeposit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoansonTermDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoansonTermDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoansonTermDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnLoansonTermDeposit.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnLoansonTermDeposit.Location = New System.Drawing.Point(16, 256)
        Me.btnLoansonTermDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLoansonTermDeposit.Name = "btnLoansonTermDeposit"
        Me.btnLoansonTermDeposit.Size = New System.Drawing.Size(174, 40)
        Me.btnLoansonTermDeposit.TabIndex = 16
        Me.btnLoansonTermDeposit.Text = "Loans on &Term Deposit"
        Me.btnLoansonTermDeposit.UseVisualStyleBackColor = False
        '
        'btnSuretyLoan
        '
        Me.btnSuretyLoan.AllowDrop = True
        Me.btnSuretyLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSuretyLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuretyLoan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSuretyLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSuretyLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuretyLoan.ForeColor = System.Drawing.Color.Black
        Me.btnSuretyLoan.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnSuretyLoan.Location = New System.Drawing.Point(16, 208)
        Me.btnSuretyLoan.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSuretyLoan.Name = "btnSuretyLoan"
        Me.btnSuretyLoan.Size = New System.Drawing.Size(174, 40)
        Me.btnSuretyLoan.TabIndex = 15
        Me.btnSuretyLoan.Text = "&Surety Loan"
        Me.btnSuretyLoan.UseVisualStyleBackColor = False
        '
        'btnColleteralHandLoan
        '
        Me.btnColleteralHandLoan.AllowDrop = True
        Me.btnColleteralHandLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnColleteralHandLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColleteralHandLoan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnColleteralHandLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColleteralHandLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColleteralHandLoan.ForeColor = System.Drawing.Color.Black
        Me.btnColleteralHandLoan.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnColleteralHandLoan.Location = New System.Drawing.Point(16, 160)
        Me.btnColleteralHandLoan.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnColleteralHandLoan.Name = "btnColleteralHandLoan"
        Me.btnColleteralHandLoan.Size = New System.Drawing.Size(174, 40)
        Me.btnColleteralHandLoan.TabIndex = 14
        Me.btnColleteralHandLoan.Text = "&Colleteral Hand Loan"
        Me.btnColleteralHandLoan.UseVisualStyleBackColor = False
        '
        'btnHandLoan
        '
        Me.btnHandLoan.AllowDrop = True
        Me.btnHandLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnHandLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHandLoan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHandLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHandLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHandLoan.ForeColor = System.Drawing.Color.Black
        Me.btnHandLoan.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnHandLoan.Location = New System.Drawing.Point(16, 112)
        Me.btnHandLoan.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnHandLoan.Name = "btnHandLoan"
        Me.btnHandLoan.Size = New System.Drawing.Size(174, 40)
        Me.btnHandLoan.TabIndex = 13
        Me.btnHandLoan.Text = "&Hand Loan"
        Me.btnHandLoan.UseVisualStyleBackColor = False
        '
        'btnVehicleLoan
        '
        Me.btnVehicleLoan.AllowDrop = True
        Me.btnVehicleLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnVehicleLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehicleLoan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVehicleLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVehicleLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleLoan.ForeColor = System.Drawing.Color.Black
        Me.btnVehicleLoan.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnVehicleLoan.Location = New System.Drawing.Point(16, 64)
        Me.btnVehicleLoan.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnVehicleLoan.Name = "btnVehicleLoan"
        Me.btnVehicleLoan.Size = New System.Drawing.Size(174, 40)
        Me.btnVehicleLoan.TabIndex = 12
        Me.btnVehicleLoan.Text = "&Vehicle Loan"
        Me.btnVehicleLoan.UseVisualStyleBackColor = False
        '
        'btnJewelLoan
        '
        Me.btnJewelLoan.AllowDrop = True
        Me.btnJewelLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnJewelLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJewelLoan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnJewelLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJewelLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJewelLoan.ForeColor = System.Drawing.Color.Black
        Me.btnJewelLoan.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnJewelLoan.Location = New System.Drawing.Point(16, 16)
        Me.btnJewelLoan.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnJewelLoan.Name = "btnJewelLoan"
        Me.btnJewelLoan.Size = New System.Drawing.Size(174, 40)
        Me.btnJewelLoan.TabIndex = 11
        Me.btnJewelLoan.Text = "&Jewel Loan"
        Me.btnJewelLoan.UseVisualStyleBackColor = False
        '
        'frmLoanAppliers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.CancelButton = Me.NewButton6
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NewButton6)
        Me.Controls.Add(Me.lvLoanList)
        Me.Controls.Add(Me.lblLoanList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLoanAppliers"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Appliers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Varaibles"

    Dim objLoanDetails As New clsLoanDet
    Dim dvLoan As New DataView
    Dim strFilter As String = "Name like '%'"
    Dim objclsRepyment As New clsRePayment

#End Region

#Region "Functions"

    Public Function fnLoadData() As Boolean
        Dim intCount As Integer = 0
        Dim lstvItems As New ListViewItem

        dvLoan.RowFilter = strFilter
        lvLoanList.Items.Clear()
        While intCount < dvLoan.Count

            lstvItems = lvLoanList.Items.Add(dvLoan.Item(intCount).Item("LoanNo"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("SancAmount"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("DisbAmount"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("Balance"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("IntReceivable"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("SancDate"), "dd-MM-yyyy"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("LastPaidDate"), "dd-MM-yyyy"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("Status"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("DueDate"), "dd-MM-yyyy"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("SancNo"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("ROI") * 100)
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("NOI"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("InstPrinciple"), "0,00.00"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("RepayMode"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("SecurityDeposit"), "0,00.00"))
            intCount += 1

        End While

    End Function

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmLoanAppliers
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmLoanAppliers
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmLoanAppliers
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmLoanAppliers)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub frmLoanAppliers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblLoanList.Text = "List Of Loan Borrower's Avaliable As On '" & Date.Today & "'"

    End Sub

    Private Sub btnGoldLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepayment.Click

        If lvLoanList.SelectedItems.Count > 0 Then
            If objclsRepyment.fnGetData(lvLoanList.SelectedItems(0).SubItems(0).Text) Then
                If objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") <> 0 Then
                    Dim objfrmRepay As New FrmRePayement
                    objfrmRepay.txtLoanNo.Text = lvLoanList.SelectedItems(0).SubItems(0).Text
                    objfrmRepay.txtName.Text = lvLoanList.SelectedItems(0).SubItems(1).Text
                    objfrmRepay.ShowDialog()
                Else
                    MsgBox("Amount not yet disbursed", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Please select the item from the loan list", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnVehicleLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoanDisb.Click
        Dim Str As String
      
        If lvLoanList.SelectedItems.Count > 0 Then
            Str = Mid(lvLoanList.SelectedItems(0).SubItems(0).Text, 1, 2)
            Dim ObjfrmDisb As New frmDisbursment
            ObjfrmDisb.txtLoanNo.Text = lvLoanList.SelectedItems(0).SubItems(0).Text
            If Str = "SD" Then
                ObjfrmDisb.lblSecuretyAmount.Text = "Interest Amount"
                ObjfrmDisb.txtIntrestAmt.Visible = True
                ObjfrmDisb.txtSecurityAmt.Visible = False
                ObjfrmDisb.txtProcCharges.Enabled = False
            Else
                ObjfrmDisb.lblSecuretyAmount.Text = "Security Amount"
                ObjfrmDisb.txtIntrestAmt.Visible = False
                ObjfrmDisb.txtSecurityAmt.Visible = True
                ObjfrmDisb.txtProcCharges.Enabled = True
            End If
            ObjfrmDisb.ShowDialog(Me)
        Else
            MsgBox("Please select the loan from the list avaliable", MsgBoxStyle.Information)
            lvLoanList.Focus()
        End If

    End Sub

    Private Sub btnKL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoanTran.Click

        If lvLoanList.SelectedItems.Count > 0 Then
            Dim objTrans As New frmTransaction
            objTrans.txtLoanNo.Text = lvLoanList.SelectedItems(0).SubItems(0).Text
            objTrans.txtName.Text = lvLoanList.SelectedItems(0).SubItems(1).Text
            objTrans.ShowDialog()
        Else
            MsgBox("Please select the loan from list avaiable", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click

        Me.Close()

    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged

        If cmbSearchBy.SelectedItem = "LoanNo" Then
            strFilter = "LoanNo"
            strFilter = "LoanNo like '" & txtSearchText.Text & "%'"
            fnLoadData()

        ElseIf cmbSearchBy.SelectedItem = "Name" Then
            strFilter = "Name"
            strFilter = "Name like '" & txtSearchText.Text & "%'"
            fnLoadData()

        End If

    End Sub

    Private Sub btnJewelLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJewelLoan.Click
        'strFilter = "LoanNo like 'JL%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("JL") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub btnVehicleLoan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehicleLoan.Click
        'strFilter = "LoanNo like 'LMV%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("LMV") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub btnHandLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHandLoan.Click
        'strFilter = "LoanNo like 'HL%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("HL") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub btnColleteralHandLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColleteralHandLoan.Click
        'strFilter = "LoanNo like 'CHL%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("CHL") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub btnSuretyLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuretyLoan.Click
        ' strFilter = "LoanNo like 'SL%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("SL") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub btnLoansonTermDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoansonTermDeposit.Click
        'strFilter = "LoanNo like 'LTD%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("LTD") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub btnDailyRecoveryLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDailyRecoveryLoan.Click
        'strFilter = "LoanNo like 'SDRL%'"
        lvLoanList.Items.Clear()
        If objLoanDetails.fnLoanList("SDRL") Then
            dvLoan = New DataView(objLoanDetails.LoanListTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        If lvLoanList.SelectedItems.Count > 0 Then
            If objclsRepyment.fnGetData(lvLoanList.SelectedItems(0).SubItems(0).Text) Then
                If objclsRepyment.PaymentTable.Rows(0).Item("DisbAmount") <> 0 Then
                    Dim objfrmRepay As New frmLoanAdditionalCharges
                    objfrmRepay.txtLoanNo.Text = lvLoanList.SelectedItems(0).SubItems(0).Text
                    objfrmRepay.txtName.Text = lvLoanList.SelectedItems(0).SubItems(1).Text
                    objfrmRepay.ShowDialog()
                Else
                    MsgBox("Amount not yet disbursed", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Please select the item from the loan list", MsgBoxStyle.Information)
        End If
    End Sub

  
End Class
