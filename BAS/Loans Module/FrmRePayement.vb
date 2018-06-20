Imports System.Math

Public Class FrmRePayement
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
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LoanDetails As System.Windows.Forms.TabPage
    Friend WithEvents InterestDetails As System.Windows.Forms.TabPage
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpLastPaidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrinciple As BankControls.NumericControl
    Friend WithEvents txtOthers As BankControls.NumericControl
    Friend WithEvents txtPenelInterest As BankControls.NumericControl
    Friend WithEvents txtInterest As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPI As BankControls.NumericControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipleAmount As BankControls.NumericControl
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvPaidDet As System.Windows.Forms.ListView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtIntPaid As BankControls.NumericControl
    Friend WithEvents txtRemainingInt As BankControls.NumericControl
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtReceiptnO As BankControls.TextControl
    Friend WithEvents txtChalanNo As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkFundTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chkCA As System.Windows.Forms.CheckBox
    Friend WithEvents chkSB As System.Windows.Forms.CheckBox
    Friend WithEvents txtTransFund As BankControls.NumericControl
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtRemainingAmount As BankControls.NumericControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtTransferAmount As BankControls.NumericControl
    Friend WithEvents lblAType As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSecDeposit As BankControls.NumericControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkUse As System.Windows.Forms.CheckBox
    Friend WithEvents rtpRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtInt As BankControls.NumericControl
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkCarryOver As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbRepayType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRePayement))
        Me.txtLoanNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.LoanDetails = New System.Windows.Forms.TabPage
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbRepayType = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtBalance = New BankControls.NumericControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkUse = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtSecDeposit = New BankControls.NumericControl
        Me.txtRemainingAmount = New BankControls.NumericControl
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtTransferAmount = New BankControls.NumericControl
        Me.lblAType = New System.Windows.Forms.Label
        Me.chkFundTransfer = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.chkCA = New System.Windows.Forms.CheckBox
        Me.chkSB = New System.Windows.Forms.CheckBox
        Me.txtTransFund = New BankControls.NumericControl
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpLastPaidDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPrincipleAmount = New BankControls.NumericControl
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.InterestDetails = New System.Windows.Forms.TabPage
        Me.chkCarryOver = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtInt = New BankControls.NumericControl
        Me.rtpRemarks = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtChalanNo = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRemainingInt = New BankControls.NumericControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtIntPaid = New BankControls.NumericControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtReceiptnO = New BankControls.TextControl
        Me.txtPI = New BankControls.NumericControl
        Me.txtROI = New BankControls.NumericControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPrinciple = New BankControls.NumericControl
        Me.txtOthers = New BankControls.NumericControl
        Me.txtPenelInterest = New BankControls.NumericControl
        Me.txtInterest = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnCalInterest = New BankControls.NewButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.lvPaidDet = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.TabControl1.SuspendLayout()
        Me.LoanDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.InterestDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(96, 16)
        Me.txtLoanNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.Size = New System.Drawing.Size(168, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "LoanNo"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(528, 520)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 40)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LoanDetails)
        Me.TabControl1.Controls.Add(Me.InterestDetails)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 328)
        Me.TabControl1.TabIndex = 0
        '
        'LoanDetails
        '
        Me.LoanDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.LoanDetails.Controls.Add(Me.Label23)
        Me.LoanDetails.Controls.Add(Me.cmbRepayType)
        Me.LoanDetails.Controls.Add(Me.Label21)
        Me.LoanDetails.Controls.Add(Me.txtBalance)
        Me.LoanDetails.Controls.Add(Me.Panel1)
        Me.LoanDetails.Controls.Add(Me.txtRemainingAmount)
        Me.LoanDetails.Controls.Add(Me.Label40)
        Me.LoanDetails.Controls.Add(Me.txtTransferAmount)
        Me.LoanDetails.Controls.Add(Me.lblAType)
        Me.LoanDetails.Controls.Add(Me.chkFundTransfer)
        Me.LoanDetails.Controls.Add(Me.Panel3)
        Me.LoanDetails.Controls.Add(Me.txtName)
        Me.LoanDetails.Controls.Add(Me.dtpPayDate)
        Me.LoanDetails.Controls.Add(Me.Label3)
        Me.LoanDetails.Controls.Add(Me.dtpLastPaidDate)
        Me.LoanDetails.Controls.Add(Me.Label6)
        Me.LoanDetails.Controls.Add(Me.Label5)
        Me.LoanDetails.Controls.Add(Me.txtPrincipleAmount)
        Me.LoanDetails.Controls.Add(Me.dtpDueDate)
        Me.LoanDetails.Controls.Add(Me.Label7)
        Me.LoanDetails.Controls.Add(Me.txtLoanNo)
        Me.LoanDetails.Controls.Add(Me.Label1)
        Me.LoanDetails.Controls.Add(Me.Label17)
        Me.LoanDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanDetails.Location = New System.Drawing.Point(4, 25)
        Me.LoanDetails.Name = "LoanDetails"
        Me.LoanDetails.Size = New System.Drawing.Size(624, 299)
        Me.LoanDetails.TabIndex = 0
        Me.LoanDetails.Text = "Loan Details"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(8, 112)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 16)
        Me.Label23.TabIndex = 647
        Me.Label23.Text = "Repay Type"
        '
        'cmbRepayType
        '
        Me.cmbRepayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepayType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepayType.Items.AddRange(New Object() {"Monthly interes", "Repaymen", "Closure"})
        Me.cmbRepayType.Location = New System.Drawing.Point(96, 112)
        Me.cmbRepayType.Name = "cmbRepayType"
        Me.cmbRepayType.Size = New System.Drawing.Size(168, 24)
        Me.cmbRepayType.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(8, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 645
        Me.Label21.Text = "Balance"
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 0
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.BeforeDecimal = 10
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalance.Location = New System.Drawing.Point(96, 80)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalance.MaxValue = 9999999999999
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(168, 23)
        Me.txtBalance.TabIndex = 644
        Me.txtBalance.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chkUse)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtSecDeposit)
        Me.Panel1.Location = New System.Drawing.Point(312, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 64)
        Me.Panel1.TabIndex = 11
        '
        'chkUse
        '
        Me.chkUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.chkUse.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.chkUse.Location = New System.Drawing.Point(48, 36)
        Me.chkUse.Name = "chkUse"
        Me.chkUse.Size = New System.Drawing.Size(184, 21)
        Me.chkUse.TabIndex = 12
        Me.chkUse.Text = "Use Security Deposit"
        Me.chkUse.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(0, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 16)
        Me.Label18.TabIndex = 638
        Me.Label18.Text = "Security Deposit"
        '
        'txtSecDeposit
        '
        Me.txtSecDeposit.AfterDecimal = 0
        Me.txtSecDeposit.BackColor = System.Drawing.Color.White
        Me.txtSecDeposit.BeforeDecimal = 10
        Me.txtSecDeposit.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSecDeposit.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSecDeposit.Location = New System.Drawing.Point(120, 8)
        Me.txtSecDeposit.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSecDeposit.MaxValue = 9999999999999
        Me.txtSecDeposit.MinValue = 0
        Me.txtSecDeposit.Name = "txtSecDeposit"
        Me.txtSecDeposit.ReadOnly = True
        Me.txtSecDeposit.Size = New System.Drawing.Size(160, 23)
        Me.txtSecDeposit.TabIndex = 5
        '
        'txtRemainingAmount
        '
        Me.txtRemainingAmount.AfterDecimal = 2
        Me.txtRemainingAmount.BeforeDecimal = 8
        Me.txtRemainingAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemainingAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemainingAmount.Location = New System.Drawing.Point(432, 256)
        Me.txtRemainingAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemainingAmount.MaxLength = 10
        Me.txtRemainingAmount.MaxValue = 0
        Me.txtRemainingAmount.MinValue = 0
        Me.txtRemainingAmount.Name = "txtRemainingAmount"
        Me.txtRemainingAmount.Size = New System.Drawing.Size(160, 22)
        Me.txtRemainingAmount.TabIndex = 13
        Me.txtRemainingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(304, 256)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(128, 16)
        Me.Label40.TabIndex = 643
        Me.Label40.Text = "Amount by Cash :"
        '
        'txtTransferAmount
        '
        Me.txtTransferAmount.AfterDecimal = 2
        Me.txtTransferAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.txtTransferAmount.BeforeDecimal = 8
        Me.txtTransferAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTransferAmount.Location = New System.Drawing.Point(432, 224)
        Me.txtTransferAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtTransferAmount.MaxLength = 10
        Me.txtTransferAmount.MaxValue = 0
        Me.txtTransferAmount.MinValue = 0
        Me.txtTransferAmount.Name = "txtTransferAmount"
        Me.txtTransferAmount.ReadOnly = True
        Me.txtTransferAmount.Size = New System.Drawing.Size(160, 22)
        Me.txtTransferAmount.TabIndex = 641
        Me.txtTransferAmount.TabStop = False
        Me.txtTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAType
        '
        Me.lblAType.AutoSize = True
        Me.lblAType.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAType.ForeColor = System.Drawing.Color.Black
        Me.lblAType.Location = New System.Drawing.Point(304, 224)
        Me.lblAType.Name = "lblAType"
        Me.lblAType.Size = New System.Drawing.Size(128, 15)
        Me.lblAType.TabIndex = 642
        Me.lblAType.Text = "Amount Transfered :"
        '
        'chkFundTransfer
        '
        Me.chkFundTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.chkFundTransfer.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.chkFundTransfer.Location = New System.Drawing.Point(16, 144)
        Me.chkFundTransfer.Name = "chkFundTransfer"
        Me.chkFundTransfer.Size = New System.Drawing.Size(112, 16)
        Me.chkFundTransfer.TabIndex = 4
        Me.chkFundTransfer.Text = "Fund Transfer"
        Me.chkFundTransfer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.chkCA)
        Me.Panel3.Controls.Add(Me.chkSB)
        Me.Panel3.Controls.Add(Me.txtTransFund)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.lblAvalBal)
        Me.Panel3.Controls.Add(Me.txtAccNo)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Location = New System.Drawing.Point(8, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 120)
        Me.Panel3.TabIndex = 5
        '
        'chkCA
        '
        Me.chkCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.chkCA.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.chkCA.Location = New System.Drawing.Point(112, 8)
        Me.chkCA.Name = "chkCA"
        Me.chkCA.Size = New System.Drawing.Size(48, 24)
        Me.chkCA.TabIndex = 7
        Me.chkCA.Text = "CA"
        Me.chkCA.UseVisualStyleBackColor = False
        '
        'chkSB
        '
        Me.chkSB.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.chkSB.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.chkSB.Location = New System.Drawing.Point(16, 8)
        Me.chkSB.Name = "chkSB"
        Me.chkSB.Size = New System.Drawing.Size(48, 24)
        Me.chkSB.TabIndex = 6
        Me.chkSB.Text = "SB"
        Me.chkSB.UseVisualStyleBackColor = False
        '
        'txtTransFund
        '
        Me.txtTransFund.AfterDecimal = 2
        Me.txtTransFund.BeforeDecimal = 8
        Me.txtTransFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTransFund.Location = New System.Drawing.Point(112, 88)
        Me.txtTransFund.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtTransFund.MaxLength = 10
        Me.txtTransFund.MaxValue = 0
        Me.txtTransFund.MinValue = 0
        Me.txtTransFund.Name = "txtTransFund"
        Me.txtTransFund.Size = New System.Drawing.Size(128, 22)
        Me.txtTransFund.TabIndex = 10
        Me.txtTransFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(8, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 15)
        Me.Label37.TabIndex = 124
        Me.Label37.Text = "Amount:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(8, 64)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(96, 16)
        Me.Label36.TabIndex = 122
        Me.Label36.Text = "AvailBalance: "
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(112, 64)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(28, 16)
        Me.lblAvalBal.TabIndex = 121
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(112, 32)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(248, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 8
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 32)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(81, 15)
        Me.Label35.TabIndex = 66
        Me.Label35.Text = "Account No: "
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(360, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 2
        Me.txtName.TabStop = False
        '
        'dtpPayDate
        '
        Me.dtpPayDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpPayDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpPayDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPayDate.Location = New System.Drawing.Point(432, 48)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpPayDate.TabIndex = 7
        Me.dtpPayDate.Value = New Date(2008, 10, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(312, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 631
        Me.Label3.Text = "Date"
        '
        'dtpLastPaidDate
        '
        Me.dtpLastPaidDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpLastPaidDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpLastPaidDate.Enabled = False
        Me.dtpLastPaidDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpLastPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPaidDate.Location = New System.Drawing.Point(432, 80)
        Me.dtpLastPaidDate.Name = "dtpLastPaidDate"
        Me.dtpLastPaidDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpLastPaidDate.TabIndex = 8
        Me.dtpLastPaidDate.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(312, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 630
        Me.Label6.Text = "Last Paid Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 625
        Me.Label5.Text = "Sanc Amt"
        '
        'txtPrincipleAmount
        '
        Me.txtPrincipleAmount.AfterDecimal = 0
        Me.txtPrincipleAmount.BackColor = System.Drawing.Color.White
        Me.txtPrincipleAmount.BeforeDecimal = 10
        Me.txtPrincipleAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPrincipleAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPrincipleAmount.Location = New System.Drawing.Point(96, 48)
        Me.txtPrincipleAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPrincipleAmount.MaxValue = 9999999999999
        Me.txtPrincipleAmount.MinValue = 0
        Me.txtPrincipleAmount.Name = "txtPrincipleAmount"
        Me.txtPrincipleAmount.ReadOnly = True
        Me.txtPrincipleAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtPrincipleAmount.TabIndex = 3
        Me.txtPrincipleAmount.TabStop = False
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDueDate.Enabled = False
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(432, 112)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDueDate.TabIndex = 9
        Me.dtpDueDate.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 626
        Me.Label7.Text = "Due Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(312, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Name"
        '
        'InterestDetails
        '
        Me.InterestDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.InterestDetails.Controls.Add(Me.chkCarryOver)
        Me.InterestDetails.Controls.Add(Me.Label22)
        Me.InterestDetails.Controls.Add(Me.txtInt)
        Me.InterestDetails.Controls.Add(Me.rtpRemarks)
        Me.InterestDetails.Controls.Add(Me.Label8)
        Me.InterestDetails.Controls.Add(Me.txtChalanNo)
        Me.InterestDetails.Controls.Add(Me.Label4)
        Me.InterestDetails.Controls.Add(Me.txtRemainingInt)
        Me.InterestDetails.Controls.Add(Me.Label20)
        Me.InterestDetails.Controls.Add(Me.txtIntPaid)
        Me.InterestDetails.Controls.Add(Me.Label19)
        Me.InterestDetails.Controls.Add(Me.txtReceiptnO)
        Me.InterestDetails.Controls.Add(Me.txtPI)
        Me.InterestDetails.Controls.Add(Me.txtROI)
        Me.InterestDetails.Controls.Add(Me.Label14)
        Me.InterestDetails.Controls.Add(Me.Label15)
        Me.InterestDetails.Controls.Add(Me.btnCancel)
        Me.InterestDetails.Controls.Add(Me.btnOk)
        Me.InterestDetails.Controls.Add(Me.txtReferenceNo)
        Me.InterestDetails.Controls.Add(Me.Label9)
        Me.InterestDetails.Controls.Add(Me.txtPrinciple)
        Me.InterestDetails.Controls.Add(Me.txtOthers)
        Me.InterestDetails.Controls.Add(Me.txtPenelInterest)
        Me.InterestDetails.Controls.Add(Me.txtInterest)
        Me.InterestDetails.Controls.Add(Me.Label13)
        Me.InterestDetails.Controls.Add(Me.btnCalInterest)
        Me.InterestDetails.Controls.Add(Me.Label12)
        Me.InterestDetails.Controls.Add(Me.Label11)
        Me.InterestDetails.Controls.Add(Me.Label10)
        Me.InterestDetails.Controls.Add(Me.txtAmount)
        Me.InterestDetails.Controls.Add(Me.Label2)
        Me.InterestDetails.Controls.Add(Me.Label16)
        Me.InterestDetails.Location = New System.Drawing.Point(4, 25)
        Me.InterestDetails.Name = "InterestDetails"
        Me.InterestDetails.Size = New System.Drawing.Size(624, 299)
        Me.InterestDetails.TabIndex = 1
        Me.InterestDetails.Text = "Interest Details"
        '
        'chkCarryOver
        '
        Me.chkCarryOver.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.chkCarryOver.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.chkCarryOver.Location = New System.Drawing.Point(144, 46)
        Me.chkCarryOver.Name = "chkCarryOver"
        Me.chkCarryOver.Size = New System.Drawing.Size(136, 20)
        Me.chkCarryOver.TabIndex = 641
        Me.chkCarryOver.TabStop = False
        Me.chkCarryOver.Text = "Interest Carry Over"
        Me.chkCarryOver.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(8, 264)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 16)
        Me.Label22.TabIndex = 639
        Me.Label22.Text = "Interest Receivable"
        '
        'txtInt
        '
        Me.txtInt.AfterDecimal = 0
        Me.txtInt.BackColor = System.Drawing.SystemColors.Window
        Me.txtInt.BeforeDecimal = 10
        Me.txtInt.Enabled = False
        Me.txtInt.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtInt.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtInt.Location = New System.Drawing.Point(144, 264)
        Me.txtInt.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtInt.MaxLength = 10
        Me.txtInt.MaxValue = 9999999999999
        Me.txtInt.MinValue = 0
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(144, 23)
        Me.txtInt.TabIndex = 638
        Me.txtInt.TabStop = False
        '
        'rtpRemarks
        '
        Me.rtpRemarks.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rtpRemarks.Location = New System.Drawing.Point(448, 176)
        Me.rtpRemarks.MaxLength = 100
        Me.rtpRemarks.Name = "rtpRemarks"
        Me.rtpRemarks.Size = New System.Drawing.Size(152, 64)
        Me.rtpRemarks.TabIndex = 24
        Me.rtpRemarks.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 637
        Me.Label8.Text = "Remarks"
        '
        'txtChalanNo
        '
        Me.txtChalanNo.AfterDecimal = 0
        Me.txtChalanNo.BeforeDecimal = 10
        Me.txtChalanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtChalanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChalanNo.Location = New System.Drawing.Point(448, 16)
        Me.txtChalanNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChalanNo.MaxLength = 10
        Me.txtChalanNo.MaxValue = 9999999999999
        Me.txtChalanNo.MinValue = 0
        Me.txtChalanNo.Name = "txtChalanNo"
        Me.txtChalanNo.Size = New System.Drawing.Size(152, 23)
        Me.txtChalanNo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(344, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 635
        Me.Label4.Text = "Challan No"
        '
        'txtRemainingInt
        '
        Me.txtRemainingInt.AfterDecimal = 2
        Me.txtRemainingInt.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemainingInt.BeforeDecimal = 8
        Me.txtRemainingInt.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtRemainingInt.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemainingInt.Location = New System.Drawing.Point(144, 200)
        Me.txtRemainingInt.LostFocusColour = System.Drawing.Color.White
        Me.txtRemainingInt.Mandatory = True
        Me.txtRemainingInt.MaxLength = 10
        Me.txtRemainingInt.MaxValue = 0
        Me.txtRemainingInt.MinValue = 0
        Me.txtRemainingInt.Name = "txtRemainingInt"
        Me.txtRemainingInt.Size = New System.Drawing.Size(144, 23)
        Me.txtRemainingInt.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(8, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 16)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "Remaining Interest"
        '
        'txtIntPaid
        '
        Me.txtIntPaid.AfterDecimal = 2
        Me.txtIntPaid.BackColor = System.Drawing.SystemColors.Window
        Me.txtIntPaid.BeforeDecimal = 8
        Me.txtIntPaid.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtIntPaid.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtIntPaid.Location = New System.Drawing.Point(144, 136)
        Me.txtIntPaid.LostFocusColour = System.Drawing.Color.White
        Me.txtIntPaid.MaxLength = 10
        Me.txtIntPaid.MaxValue = 0
        Me.txtIntPaid.MinValue = 0
        Me.txtIntPaid.Name = "txtIntPaid"
        Me.txtIntPaid.Size = New System.Drawing.Size(144, 23)
        Me.txtIntPaid.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(8, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 16)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Paid Interest"
        '
        'txtReceiptnO
        '
        Me.txtReceiptnO.AlphaNumeric = True
        Me.txtReceiptnO.BlankSpace = True
        Me.txtReceiptnO.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptnO.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptnO.Location = New System.Drawing.Point(448, 144)
        Me.txtReceiptnO.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptnO.Mandatory = False
        Me.txtReceiptnO.MaxLength = 10
        Me.txtReceiptnO.Name = "txtReceiptnO"
        Me.txtReceiptnO.Size = New System.Drawing.Size(152, 23)
        Me.txtReceiptnO.SpecialChar = False
        Me.txtReceiptnO.TabIndex = 23
        '
        'txtPI
        '
        Me.txtPI.AfterDecimal = 0
        Me.txtPI.BackColor = System.Drawing.SystemColors.Window
        Me.txtPI.BeforeDecimal = 10
        Me.txtPI.Enabled = False
        Me.txtPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPI.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtPI.Location = New System.Drawing.Point(448, 112)
        Me.txtPI.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPI.MaxLength = 10
        Me.txtPI.MaxValue = 9999999999999
        Me.txtPI.MinValue = 0
        Me.txtPI.Name = "txtPI"
        Me.txtPI.Size = New System.Drawing.Size(152, 22)
        Me.txtPI.TabIndex = 22
        Me.txtPI.TabStop = False
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.SystemColors.Window
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Enabled = False
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.Empty
        Me.txtROI.Location = New System.Drawing.Point(448, 80)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(152, 22)
        Me.txtROI.TabIndex = 21
        Me.txtROI.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(344, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 16)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Actuall Penel"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(344, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "Actuall ROI"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(448, 248)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 40)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cance&l"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(344, 248)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 40)
        Me.btnOk.TabIndex = 25
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 10
        Me.txtReferenceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(448, 48)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReferenceNo.MaxValue = 9999999999999
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(152, 22)
        Me.txtReferenceNo.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(344, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Reference No"
        '
        'txtPrinciple
        '
        Me.txtPrinciple.AfterDecimal = 0
        Me.txtPrinciple.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrinciple.BeforeDecimal = 10
        Me.txtPrinciple.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPrinciple.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtPrinciple.Location = New System.Drawing.Point(144, 232)
        Me.txtPrinciple.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPrinciple.MaxLength = 10
        Me.txtPrinciple.MaxValue = 9999999999999
        Me.txtPrinciple.MinValue = 0
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(144, 23)
        Me.txtPrinciple.TabIndex = 18
        '
        'txtOthers
        '
        Me.txtOthers.AfterDecimal = 0
        Me.txtOthers.BeforeDecimal = 10
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtOthers.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOthers.Location = New System.Drawing.Point(144, 168)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.MaxLength = 10
        Me.txtOthers.MaxValue = 9999999999999
        Me.txtOthers.MinValue = 0
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(144, 23)
        Me.txtOthers.TabIndex = 16
        '
        'txtPenelInterest
        '
        Me.txtPenelInterest.AfterDecimal = 0
        Me.txtPenelInterest.BackColor = System.Drawing.SystemColors.Window
        Me.txtPenelInterest.BeforeDecimal = 10
        Me.txtPenelInterest.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPenelInterest.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtPenelInterest.Location = New System.Drawing.Point(144, 72)
        Me.txtPenelInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPenelInterest.MaxLength = 10
        Me.txtPenelInterest.MaxValue = 9999999999999
        Me.txtPenelInterest.MinValue = 0
        Me.txtPenelInterest.Name = "txtPenelInterest"
        Me.txtPenelInterest.Size = New System.Drawing.Size(144, 23)
        Me.txtPenelInterest.TabIndex = 12
        '
        'txtInterest
        '
        Me.txtInterest.AfterDecimal = 2
        Me.txtInterest.BackColor = System.Drawing.SystemColors.Window
        Me.txtInterest.BeforeDecimal = 8
        Me.txtInterest.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtInterest.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterest.Location = New System.Drawing.Point(144, 104)
        Me.txtInterest.LostFocusColour = System.Drawing.Color.White
        Me.txtInterest.Mandatory = True
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(144, 23)
        Me.txtInterest.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(8, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Principle"
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(296, 16)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(40, 24)
        Me.btnCalInterest.TabIndex = 11
        Me.btnCalInterest.Text = "Cal Interest"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(8, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Others"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(8, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "PenelInterest"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(8, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 16)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Raised Interest"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 10
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(144, 16)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 9
        Me.txtAmount.MaxValue = 9999999999999
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtAmount.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(344, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 16)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Receipt No"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Paid Date"
        Me.ColumnHeader1.Width = 73
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Debit"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 62
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "InstNo"
        Me.ColumnHeader3.Width = 44
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "RaisedInt"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 64
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Penel Intrest"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "fromDate"
        Me.ColumnHeader6.Width = 85
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ToDate"
        Me.ColumnHeader7.Width = 85
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Balance"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 74
        '
        'lvPaidDet
        '
        Me.lvPaidDet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader8, Me.ColumnHeader4, Me.ColumnHeader10, Me.ColumnHeader5, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader13})
        Me.lvPaidDet.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lvPaidDet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvPaidDet.FullRowSelect = True
        Me.lvPaidDet.GridLines = True
        Me.lvPaidDet.Location = New System.Drawing.Point(8, 336)
        Me.lvPaidDet.MultiSelect = False
        Me.lvPaidDet.Name = "lvPaidDet"
        Me.lvPaidDet.Size = New System.Drawing.Size(1072, 176)
        Me.lvPaidDet.TabIndex = 21
        Me.lvPaidDet.UseCompatibleStateImageBehavior = False
        Me.lvPaidDet.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Credit"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "PaidInt"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Remaining Int"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Int Receivable"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "IntCarryOver"
        '
        'FrmRePayement
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1113, 567)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvPaidDet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRePayement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Payment"
        Me.TabControl1.ResumeLayout(False)
        Me.LoanDetails.ResumeLayout(False)
        Me.LoanDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.InterestDetails.ResumeLayout(False)
        Me.InterestDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Golble Variables"

    Dim objclsRepayment As New clsRePayment
    Dim objclsDisb As New clsDisbursment
    Dim intMaxAmt As Integer
    Dim intSancAmt As Integer
    Dim intcalInterest As Double
    Dim intDueDate As Integer
    Dim intInterestDiff As Integer
    Dim intROI As Integer
    Dim intCalPenel As Integer
    Dim lstvItems As ListViewItem
    Dim intAmount As Integer
    Dim intTotalInterest As Integer
    Dim intTotalPenal As Integer

    Dim lngVoucher As Long

    Dim datFromDate As Date
    Dim datToDate As Date
    ' Dim dblBalance As Double

    Dim datLoanDate As Date
    Dim datLoanInst As Date
    Dim intNOD As Integer
    Dim intNODPenal As Integer

    'For SB Transfer
    Dim dblAvalAmount As Double
    Dim objSavingsBank As New clsSavingsBank
    Dim objCurrentAccount As New clsCurrentAccount
    Dim dblOverDrawLimit As Double
    Public dblCalIntrest As Double
    Dim dblBalance As Double

    Dim dblIntReceivable As Double

    Dim dblCoverAmount As Double
    Dim countCalBtnCount As Integer = 0

#End Region

#Region "Functions"

    'To Load SB Account Balance Detail
    Sub sbloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
                dblAvalAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
                lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
            Else
                MsgBox("Account No does not Exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub

    'To Load Current Account Balance and OD limit Detail 
    Sub caloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then
                dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
            Else
                MsgBox("Account No does not Exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub

    Public Function fnGetData() As Boolean

        If objclsRepayment.fnGetData(txtLoanNo.Text) Then
            txtPrincipleAmount.Text = objclsRepayment.PaymentTable.Rows(0).Item("SancAmount")
            dtpDueDate.Value = Format(objclsRepayment.PaymentTable.Rows(0).Item("DueDate"), "yyyy-MM-dd")
            dtpLastPaidDate.Value = Format(objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate"), "yyyy-MM-dd")
            txtSecDeposit.Text = objclsRepayment.PaymentTable.Rows(0).Item("SecurityDeposit")
            txtBalance.Text = objclsRepayment.PaymentTable.Rows(0).Item("Balance")
            txtInt.Text = objclsRepayment.PaymentTable.Rows(0).Item("IntReceivable")
            dblCoverAmount = objclsRepayment.PaymentTable.Rows(0).Item("IntCOver")
        End If

    End Function
    Public Function fnGetDisb() As Boolean

        If objclsRepayment.fnGetDisb(txtLoanNo.Text) Then
        End If

    End Function

    Public Function fnCalTotal() As Boolean
        Dim DblAmount As Double = 0
        Dim TotalMount As Double = 0
        Dim intIntrest As Double = Math.Round(Val(txtInterest.Text))
        Dim intPenal As Double = Math.Round(Val(txtPenelInterest.Text))
        TotalMount = Val(txtAmount.Text)

        DblAmount = TotalMount - intPenal
        If DblAmount > 0 Then
            If DblAmount > intIntrest Then
                txtIntPaid.Text = intIntrest
                DblAmount = DblAmount - intIntrest
                If DblAmount > Val(txtOthers.Text) Then
                    txtRemainingInt.Text = 0
                    txtPrinciple.Text = DblAmount - Val(txtOthers.Text)
                Else
                    txtRemainingInt.Text = Val(txtOthers.Text) - DblAmount
                    txtPrinciple.Text = 0
                End If
            Else
                txtIntPaid.Text = DblAmount
                txtRemainingInt.Text = intIntrest + Val(txtOthers.Text) - DblAmount
                txtPrinciple.Text = 0
            End If
        Else
            txtIntPaid.Text = 0
            txtRemainingInt.Text = intIntrest + Val(txtOthers.Text) + (intPenal - TotalMount)
            txtPrinciple.Text = 0
        End If

    End Function

    Public Function fnClearData() As Boolean

        txtAmount.Text = ""
        txtChalanNo.Text = ""
        rtpRemarks.Text = ""
        txtReceiptnO.ResetText()
        txtOthers.ResetText()
        txtPrinciple.ResetText()
        txtReferenceNo.ResetText()

        txtPenelInterest.ResetText()
        txtInterest.ResetText()
        txtIntPaid.ResetText()
        txtRemainingInt.ResetText()
        txtRemainingAmount.ResetText()
        chkFundTransfer.Checked = False
        chkUse.Checked = False
        txtRemainingInt.ResetText()
        txtReceiptnO.ResetText()
        txtInt.ResetText()

        dblIntReceivable = 0
        intMaxAmt = 0
        intSancAmt = 0
        intcalInterest = 0
        intInterestDiff = 0
        intROI = 0
        intCalPenel = 0
        intAmount = 0
        intTotalInterest = 0
        intTotalPenal = 0
        lngVoucher = 0
        intNOD = 0
        intNODPenal = 0
        cmbRepayType.SelectedIndex = -1

        'For SB Transfer
        dblAvalAmount = 0
        dblOverDrawLimit = 0
        dblCalIntrest = 0
        dblBalance = 0

        chkCarryOver.Checked = False

        Return True

    End Function

    Function fnGenerateVoucherW() As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpPayDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        If chkCA.Checked = True Then
            objCurrentAccount.Accdate = dtpPayDate.Value
            If fnCalcInterest() Then
                If objCurrentAccount.fnUpdateLastPaid(txtAccNo.Text) Then
                    'Transaction Entry
                    Dim strNarration As String = "Transfered To " & txtLoanNo.Text '& " Narration:" & txtNarration.Text
                    Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpPayDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & dblCalIntrest & "','" & Trim(txtReceiptnO.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
                    fnExecuteNonQuery(strsql)
                    'voucher details

                    If dblAvalAmount <> 0 Then
                        'Credit accounts
                        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 1, "Y")
                        'Debit accounts 
                        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "By", 48, Val(txtTransFund.Text), 0, 2, "Y")
                    Else
                        Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtTransFund.Text)
                        If dblTempBalance < 0 Then
                            'Credit accounts
                            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 1, "Y")
                            'Debit accounts
                            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 2, "Y")
                            'Debit accounts 
                            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "To", 48, Abs(dblTempBalance), 0, 3, "Y")
                        Else
                            'Credit accounts
                            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 1, "Y")
                            'Debit accounts 
                            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Withdraw By Current Account " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 2, "Y")
                        End If
                    End If
                End If

            End If
        ElseIf chkSB.Checked = True Then

            Dim strNarration As String = "Transfered To " & txtLoanNo.Text '& " Narration:" & txtNarration.Text

            'Transaction Entry
            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpPayDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptnO.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql)
            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtReceiptnO.Text, dtpPayDate.Value, txtTransFund.Text, "Withdraw By " & txtAccNo.Text, lngSlNo, "Y")
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Withdraw By SB Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 1, "Y")
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Withdraw By SB Account " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "Y")

        End If

    End Function

    ''Previous Version "WITH DEBITED AMOUNT IS CONSIDERED AS INTEREST COLLECTED"
    'Function fnGenerateVoucher() As Boolean

    '    'Loan Repayment With Securety Deposit Dr to repay Loan 

    '    Dim lngVoucherNo As Long
    '    Dim lngSlNo As Long
    '    Dim strLoan As String
    '    Dim dblRemPrinciple As Double

    '    lngVoucherNo = fnVoucherGetNewVNo(dtpPayDate.Value)
    '    lngSlNo = fnVoucherGetNewSlNo()
    '    lngVoucher = lngVoucherNo

    '    objclsRepayment.fnAddData(lngVoucher)

    '    Dim strNarration As String = "Repayment of Loan By " & txtLoanNo.Text & "  Narration:" & rtpRemarks.Text

    '    'voucher details
    '    fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReferenceNo.Text, dtpPayDate.Value, Val(txtAmount.Text), "Deposit By" & Val(txtAmount.Text), lngSlNo, "Y")

    '    strLoan = Mid(txtLoanNo.Text, 1, 2)

    '    'If Val(txtTransFund.Text) <> 0 Then

    '    '    fnGenerateVoucherW()

    '    'End If


    '    Select Case strLoan

    '        Case "JL"
    '            'Credit accounts 
    '            If txtPrinciple.Text <> 0 Then

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 15, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 21, 0, Val(txtIntPaid.Text), 2, "Y")
    '            Else

    '                'If txtIntPaid.Text <> 0 Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 21, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 2, "Y")
    '                'End If

    '                'Loan Interest Receaveable Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '                'Loan Interest Receaveable Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '                'Loan Account /Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 15, Val(txtRemainingInt.Text), 0, 1, "Y")


    '            End If

    '            If chkUse.Checked = True Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 36, Val(txtSecDeposit.Text), 0, 6, "Y")
    '            End If

    '        Case "LM"

    '            '''Credit accounts 
    '            ''If txtPrinciple.Text <> 0 Then

    '            ''    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 16, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '            ''    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtIntPaid.Text), 2, "Y")

    '            ''Else

    '            ''    'If txtIntPaid.Text <> 0 Then
    '            ''    'Loan interest Credit
    '            ''    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 1, "Y")
    '            ''    'End If

    '            ''    'Loan Interest Receaveable Debit
    '            ''    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '            ''    'Loan Interest Receaveable Credit
    '            ''    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '            ''    'Loan Account Debit
    '            ''    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 16, Val(txtRemainingInt.Text), 0, 5, "Y")

    '            ''End If


    '            'Credit accounts 
    '            If txtPrinciple.Text <> 0 Then
    '                If txtInt.Text <> 0 Then
    '                    If Val(txtPrinciple.Text) > Val(txtInt.Text) Then
    '                        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 16, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")
    '                        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtInt.Text), 2, "Y")
    '                    Else
    '                        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 16, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")
    '                        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtPrinciple.Text), 2, "Y")
    '                    End If
    '                Else
    '                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 16, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")
    '                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtIntPaid.Text), 2, "Y")
    '                End If
    '            Else

    '                'If txtIntPaid.Text <> 0 Then
    '                'Loan interest Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 1, "Y")
    '                'End If

    '                'Loan Interest Receaveable Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '                'Loan Interest Receaveable Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '                'Loan Account Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 16, Val(txtRemainingInt.Text), 0, 5, "Y")

    '            End If

    '            If chkUse.Checked = True Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 37, Val(txtSecDeposit.Text), 0, 6, "Y")
    '            End If

    '        Case "LT"

    '            'Credit accounts 
    '            If txtPrinciple.Text <> 0 Then

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 20, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 26, 0, Val(txtIntPaid.Text), 2, "Y")
    '            Else

    '                ' If txtIntPaid.Text <> 0 Then
    '                'Loan Interest Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 26, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 1, "Y")
    '                '    End If

    '                'Loan Interest Receaveable Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '                'Loan Interest Receaveable Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '                'Loan Account Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 20, Val(txtRemainingInt.Text), 0, 5, "Y")


    '            End If

    '            If chkUse.Checked = True Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 42, Val(txtSecDeposit.Text), 0, 6, "Y")
    '            End If


    '        Case "CH"

    '            'Credit accounts 
    '            If txtPrinciple.Text <> 0 Then

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 19, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 25, 0, Val(txtIntPaid.Text), 2, "Y")
    '            Else

    '                'If txtIntPaid.Text <> 0 Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 25, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 1, "Y")
    '                'End If

    '                'Loan Interest Receaveable Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '                'Loan Interest Receaveable Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '                'Loan Account Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 19, Val(txtRemainingInt.Text), 0, 5, "Y")


    '            End If

    '            If chkUse.Checked = True Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 41, Val(txtSecDeposit.Text), 0, 6, "Y")
    '            End If


    '        Case "SL"

    '            'Credit accounts 
    '            If txtPrinciple.Text <> 0 Then

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 18, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 24, 0, Val(txtIntPaid.Text), 2, "Y")
    '            Else

    '                'If txtIntPaid.Text <> 0 Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 24, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 1, "Y")
    '                'End If

    '                'Loan Interest Receaveable Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '                'Loan Interest Receaveable Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '                'Laon Account Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 18, Val(txtRemainingInt.Text), 0, 5, "Y")


    '            End If

    '            If chkUse.Checked = True Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 39, Val(txtSecDeposit.Text), 0, 6, "Y")
    '            End If

    '        Case "HL"

    '            'Credit accounts 
    '            If txtPrinciple.Text <> 0 Then

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 17, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 23, 0, Val(txtIntPaid.Text), 2, "Y")
    '            Else

    '                'If txtIntPaid.Text <> 0 Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 23, 0, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 1, "Y")
    '                'End If

    '                'Loan Interest Receaveable Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, Val(txtRemainingInt.Text), 0, 2, "Y")

    '                'Loan Interest Receaveable Credit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 56, 0, Val(txtRemainingInt.Text), 4, "Y")

    '                'Laon Account Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 17, Val(txtRemainingInt.Text), 0, 5, "Y")


    '            End If

    '            If chkUse.Checked = True Then
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 38, Val(txtSecDeposit.Text), 0, 6, "Y")
    '            End If

    '        Case "SD"

    '            'objclsDisb.fnAddData(lngVoucherNo)

    '            If txtPrinciple.Text <> 0 Then

    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 43, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")

    '                If txtIntPaid.Text <> 0 Then
    '                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 44, 0, Val(txtIntPaid.Text), 2, "Y")
    '                End If
    '            Else
    '                'Debit
    '                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "By", 43, Val(txtRemainingInt.Text), 0, 1, "Y")

    '                If txtIntPaid.Text <> 0 Then
    '                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 44, Val(txtIntPaid.Text) + Val(txtRemainingInt.Text), 0, 2, "Y")
    '                End If

    '            End If

    '    End Select

    '    '' Cash Account Debit
    '    If chkUse.Checked = True Then
    '        dblRemPrinciple = Val(txtAmount.Text) - Val(txtSecDeposit.Text)
    '        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "By", 1, dblRemPrinciple, 0, 3, "Y")
    '    Else
    '        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "By", 1, Val(txtAmount.Text), 0, 3, "Y")
    '    End If

    '    'Savings Bank or Cash Account Transaction
    '    If chkCA.Checked = True Then
    '        objCurrentAccount.Accdate = dtpPayDate.Value
    '        If fnCAInterest() Then
    '            If objCurrentAccount.fnUpdateLastPaid(txtAccNo.Text) Then
    '                'Transaction Entry
    '                strNarration = "Loan Repayment of " & txtLoanNo.Text
    '                Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
    '                strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpPayDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & dblCalIntrest & "','" & Trim(txtReceiptnO.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
    '                fnExecuteNonQuery(strsql)

    '                'voucher details
    '                If dblAvalAmount <> 0 Then
    '                    'Credit accounts
    '                    fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Loan Repayment of " & txtLoanNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
    '                    'Debit accounts 
    '                    fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repayment " & txtLoanNo.Text, "By", 48, Val(txtTransFund.Text), 0, 7, "Y")
    '                Else
    '                    Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtTransFund.Text)
    '                    If dblTempBalance < 0 Then
    '                        'Credit accounts
    '                        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Loan Repaymen of  " & txtLoanNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
    '                        'Debit accounts
    '                        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repaymen of " & txtLoanNo.Text, "By", 11, Abs(dblAvalAmount), 0, 7, "Y")
    '                        'Debit accounts 
    '                        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repaymen of " & txtLoanNo.Text, "To", 48, Abs(dblTempBalance), 0, 8, "Y")
    '                    Else
    '                        'Credit accounts
    '                        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Loan Repaymen of  " & txtLoanNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
    '                        'Debit accounts 
    '                        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repaymen of " & txtLoanNo.Text, "By", 11, Val(txtTransFund.Text), 0, 7, "Y")
    '                    End If
    '                End If
    '            End If

    '        End If
    '    ElseIf chkSB.Checked = True Then


    '        strNarration = txtLoanNo.Text & "Loan Repayment by " & txtAccNo.Text
    '        'Transaction Entry
    '        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
    '        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpPayDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptnO.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
    '        fnExecuteNonQuery(strsql)

    '        'Credit accounts
    '        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, txtLoanNo.Text & "Loan Repayment by " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
    '        'Debit accounts 
    '        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, txtLoanNo.Text & "Loan Repayment by " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 7, "Y")

    '    End If


    '    If Val(txtPenelInterest.Text) <> 0 Then
    '        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "PenalInterest Paid By Account " & txtLoanNo.Text, "To", 40, 0, Val(txtPenelInterest.Text), 7, "Y")
    '    End If

    '    If txtOthers.Text <> "" Or Val(txtOthers.Text) <> 0 Then
    '        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Misc Charges Paid By Account " & txtLoanNo.Text, "To", 13, 0, Val(txtOthers.Text), 8, "Y")
    '    End If

    '    Return True

    'End Function

    'Previous Version "WITH DEBITED AMOUNT IS CONSIDERED AS INTEREST COLLECTED"

    Function fnGenerateVoucher() As Boolean

        'Loan Repayment With Securety Deposit Dr to repay Loan 

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strLoan As String
        Dim dblRemPrinciple As Double
        Dim intLedgerNo As Integer = 0
        Dim intInterestLedgerNo As Integer = 0
        Dim intSDLedgerNo As Integer = 0

        lngVoucherNo = fnVoucherGetNewVNo(dtpPayDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        lngVoucher = lngVoucherNo

        objclsRepayment.fnAddData(lngVoucher)

        Dim strNarration As String = "Repayment of Loan By " & txtLoanNo.Text & "  Narration:" & rtpRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReferenceNo.Text, dtpPayDate.Value, Val(txtAmount.Text), "Deposit By " & Val(txtLoanNo.Text), lngSlNo, "Y")

        strLoan = Mid(txtLoanNo.Text, 1, 2)
        Select Case strLoan
            Case "JL"
                intLedgerNo = "15"
                intInterestLedgerNo = "21"
                intSDLedgerNo = "36"
            Case "LM"
                intLedgerNo = "16"
                intInterestLedgerNo = "22"
                intSDLedgerNo = "37"
            Case "HL"
                intLedgerNo = "17"
                intInterestLedgerNo = "23"
                intSDLedgerNo = "38"
            Case "SL"
                intLedgerNo = "18"
                intInterestLedgerNo = "24"
                intSDLedgerNo = "39"
            Case "CH"
                intLedgerNo = "19"
                intInterestLedgerNo = "25"
                intSDLedgerNo = "41"
            Case "LT"
                intLedgerNo = "20"
                intInterestLedgerNo = "26"
                intSDLedgerNo = "42"
            Case "SD"
                intLedgerNo = "43"
                intInterestLedgerNo = "44"
        End Select
        If Val(txtPrinciple.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", intLedgerNo, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y")
            If Val(txtIntPaid.Text) <> 0 Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", intInterestLedgerNo, 0, Val(txtIntPaid.Text), 2, "Y")
            End If
            If Val(txtInt.Text) <> 0 Then
                If Val(txtPrinciple.Text) > Val(txtInt.Text) Then
                    'Credit Interest on Loan
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", intInterestLedgerNo, 0, Val(txtInt.Text), 2, "Y")
                    'Debit The Interest Recivable of Particular loan
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 59, Val(txtInt.Text), 0, 3, "Y")
                Else
                    'Credit Interest on Loan
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", intInterestLedgerNo, 0, Val(txtPrinciple.Text), 2, "Y")
                    'Debit The Interest Recivable of Perticularr loan
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 59, Val(txtPrinciple.Text), 0, 3, "Y")
                End If
            End If
        ElseIf Val(txtRemainingInt.Text) <> 0 Then
            If Val(txtIntPaid.Text) <> 0 Then
                'Credit to Interest Account
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", intInterestLedgerNo, 0, Val(txtIntPaid.Text), 1, "Y")
            End If
            'Credit Interest on Loan
            'fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest To be Paid By Account " & txtLoanNo.Text, "To", 59, 0, Val(txtRemainingInt.Text), 2, "Y")
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest To be Paid By Account " & txtLoanNo.Text, "To", 59, 0, Val(txtInterest.Text), 2, "Y")
            'Loan Account /Debit
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Interest Debited To Account " & txtLoanNo.Text, "By", intLedgerNo, Val(txtRemainingInt.Text), 0, 3, "Y")

        End If


        '' Cash Account Debit

        If chkUse.Checked = True Then
            dblRemPrinciple = Val(txtAmount.Text) - Val(txtSecDeposit.Text)
            If dblRemPrinciple <> 0 Then
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "By", 1, dblRemPrinciple, 0, 3, "Y")

            End If
        ElseIf Val(txtAmount.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "By", 1, Val(txtAmount.Text), 0, 3, "Y")
        End If

        'Savings Bank or Cash Account Transaction
        If chkCA.Checked = True Then
            objCurrentAccount.Accdate = dtpPayDate.Value
            If fnCAInterest() Then
                If objCurrentAccount.fnUpdateLastPaid(txtAccNo.Text) Then
                    'Transaction Entry
                    strNarration = "Loan Repayment of " & txtLoanNo.Text
                    Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpPayDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & dblCalIntrest & "','" & Trim(txtReceiptnO.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
                    fnExecuteNonQuery(strsql)

                    If dblAvalAmount <= 0 Then
                        'Credit accounts
                        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
                        'Debit accounts 
                        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 7, "Y")
                    Else
                        Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtTransFund.Text)
                        If dblTempBalance < 0 Then
                            'Credit accounts
                            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")

                            'Debit accounts
                            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 7, "Y")

                            ' If dblTempBalance <> 0 Then
                            'Debit accounts 
                            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "By", 11, Abs(dblTempBalance), 0, 8, "Y")
                            'End If
                        Else
                            'Credit accounts
                            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
                            'Debit accounts 
                            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtAccNo.Text, "By", 11, Val(txtAmount.Text), 0, 7, "Y")
                        End If
                    End If
                End If

            End If
        ElseIf chkSB.Checked = True Then


            strNarration = txtLoanNo.Text & "Loan Repayment by " & txtAccNo.Text
            'Transaction Entry
            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpPayDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptnO.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpPayDate.Value, txtLoanNo.Text & "Loan Repayment by " & txtAccNo.Text, "To", 1, 0, Val(txtTransFund.Text), 6, "Y")
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpPayDate.Value, txtLoanNo.Text & "Loan Repayment by " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 7, "Y")

        End If

        If chkUse.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", intSDLedgerNo, Val(txtSecDeposit.Text), 0, 6, "Y")
        End If

        If Val(txtPenelInterest.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "PenalInterest Paid By Account " & txtLoanNo.Text, "To", 40, 0, Val(txtPenelInterest.Text), 7, "Y")
        End If

        If Val(txtOthers.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Misc Charges Paid By Account " & txtLoanNo.Text, "To", 13, 0, Val(txtOthers.Text), 8, "Y")
        End If

        Return True

    End Function

    Function fnCAInterest() As Boolean

        Dim ROI As Double
        Dim intNOD As Integer
        dblCalIntrest = 0
        Dim intInterestDiff As Integer
        Dim dblAmount As Double = lblAvalBal.Text

        If Trim(lblAvalBal.Text < 0) Then
            Dim datLastPaid As Date = CDate(objCurrentAccount.CAAccTable.Rows(0).Item("LastPaidDate"))
            If objCurrentAccount.fnGetCAMasterData Then
                ROI = objCurrentAccount.CAMasterTable.Rows(0).Item("CAROI")
            End If
            intInterestDiff = DateDiff(DateInterval.Day, datLastPaid, dtpPayDate.Value)
            If intInterestDiff > 0 Then
                dblCalIntrest = Math.Round(((Abs(dblAmount) * intInterestDiff * (ROI / 100)) / 365), 2)
                objCurrentAccount.IntAmt = dblCalIntrest
            End If
        End If
        Return True

    End Function


    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptnO.Text, txtName.Text, dtpPayDate.Value, Val(txtAmount.Text), "")

        'Receipt sub details
        fnReceiptEnterSub(txtReceiptnO.Text, dtpPayDate.Value, "¸Á® ªÀÄgÀÄ¥ÁªÀw", Val(txtAmount.Text), 1)

        Return True

    End Function
    Public Function fnSetData() As Boolean
        Dim strTemp As String
        Dim datTemp As Date
        Dim strLoan As String

        objclsRepayment.LoanNo = txtLoanNo.Text
        objclsRepayment.Remarks = rtpRemarks.Text
        objclsRepayment.PaidDate = Format(dtpPayDate.Value, "yyyy-MM-dd")
        objclsRepayment.ChallanNo = txtChalanNo.Text
        objclsRepayment.VoucherNo = 0
        objclsRepayment.Others = Val(txtOthers.Text)
        objclsRepayment.Debit = Val(txtRemainingInt.Text)
        objclsRepayment.IntrestPaid = Val(txtIntPaid.Text)
        objclsRepayment.FromDate = Format(datFromDate, "yyyy-MM-dd")
        objclsRepayment.ToDate = Format(datToDate, "yyyy-MM-dd")
        objclsRepayment.Amount = (Val(txtRemainingInt.Text) - Val(txtPrinciple.Text))

        'Interest Receivable
        If txtPrinciple.Text <> 0 Then
            If txtInt.Text <> 0 Then
                If Val(txtPrinciple.Text) > Val(txtInt.Text) Then
                    objclsRepayment.IntReceivable = 0
                Else
                    objclsRepayment.IntReceivable = Val(txtInt.Text) - Val(txtPrinciple.Text)
                End If
            End If
        ElseIf txtRemainingInt.Text <> 0 Then
            objclsRepayment.IntReceivable = Val(txtInt.Text) + Val(txtRemainingInt.Text)
        Else
            objclsRepayment.IntReceivable = Val(txtInt.Text)
        End If

        If chkCarryOver.Checked = True Then
            objclsRepayment.IntPreCOver = dblCoverAmount
            dblCoverAmount = Math.Round(intTotalInterest) + Math.Round(intTotalPenal)
        ElseIf chkCarryOver.Checked = False Then
            dblCoverAmount = 0
        End If

        objclsRepayment.IntCOver = dblCoverAmount

        If txtReferenceNo.Text = "" Then
            objclsRepayment.ReferenceNo = 0
        Else
            objclsRepayment.ReferenceNo = txtReferenceNo.Text
        End If

        objclsRepayment.Intrest = Val(txtInterest.Text)
        objclsRepayment.PenelIntrest = Val(txtPenelInterest.Text)

        If txtPrinciple.Text < 0 Then
            MsgBox("Amount cannot be less than 0", MsgBoxStyle.Information)
            Return False
        Else
            objclsRepayment.Credit = Math.Round(Val(txtPrinciple.Text))

        End If

        If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then

            objclsRepayment.InstNo = objclsRepayment.MaxInstNoTable.Rows(0).Item("InstNo") + 1

        End If

        'strLoan = Mid(txtLoanNo.Text, 1, 2)
        'If strLoan = "SD" Then
        '    datTemp = DateAdd(DateInterval.Day, intInterestDiff, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
        '    objclsRepayment.LastInstDate = datTemp
        'Else
        '    If intInterestDiff <> 0 Then
        '        datTemp = DateAdd(DateInterval.Month, intInterestDiff, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
        '        objclsRepayment.LastInstDate = datTemp
        '    Else
        '        objclsRepayment.LastInstDate = datToDate
        '    End If

        'End If

        'objclsRepayment.LastInstDate = datToDate
        objclsRepayment.LastInstDate = Format(datToDate, "yyyy-MM-dd")

        If chkUse.Checked = True Then
            objclsRepayment.SecurityDeposit = txtSecDeposit.Text
        Else
            objclsRepayment.SecurityDeposit = 0
        End If

        If fnSetBalace() Then

        End If

        Return True
    End Function

    Public Function fnSetBalace() As Boolean

        '   '   ' *********** fucntion to calculate the balance amount 
        '   '   ' *********** cond to check the weather pervious balance is paid
        If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then
            If objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") = 0 Then
                objclsRepayment.Balance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - objclsRepayment.Credit + objclsRepayment.Debit
            Else
                objclsRepayment.Balance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - (objclsRepayment.Credit - objclsRepayment.Debit)
            End If
        End If

        Return True
    End Function

    Public Function fnCalculatePrePayment() As Boolean

        Dim RemInst As Integer = 0

        Dim TempBalance As Double

        'If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then
        '    If objclsRepayment.MaxInstNoTable.Rows(0).Item("Balance") = 0 Then
        '        TempBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - Math.Round(Val(txtPrinciple.Text)) + Math.Round(Val(txtRemainingInt.Text))
        '    Else
        '        TempBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - Math.Round(Val(txtPrinciple.Text)) + Math.Round(Val(txtRemainingInt.Text))
        '    End If
        'End If

        'If TempBalance <= 0 Then
        RemInst = DateDiff(DateInterval.Month, datToDate, dtpDueDate.Value)
        If RemInst > 0 Then
            If MsgBox("Loan Is Going to Be Preclosed,Do You Want To Close Loan Account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conform Closure") = MsgBoxResult.Yes Then
                txtOthers.Text = (objclsRepayment.PaymentTable.Rows(0).Item("InstPrinciple") * 0.02 * RemInst)
            Else
                txtRemainingAmount.ResetText()
                txtPenelInterest.ResetText()
                txtInterest.ResetText()
                txtOthers.ResetText()
                txtIntPaid.ResetText()
                txtRemainingInt.ResetText()
                txtPrinciple.ResetText()
            End If
        Else
            txtOthers.Text = 0
        End If

        'Else
        'txtOthers.ResetText()
        'End If
        Return True
    End Function

    Public Function fncalculate() As Boolean
        Dim intCOunter As Integer = 1
        Dim datNextDate As Date = datLoanDate
        Dim intNOD As Integer
        intcalInterest = 0
        intCalPenel = 0

        Dim intNODPenal As Integer = 0
        Dim strLoan As String
        Dim datTemp As Date
        Dim RepaymentPeriod As Integer = 0

        Dim intIntMode As Integer = 0
        Dim str As String = objclsRepayment.PaymentTable.Rows(0).Item("Type")
        Select Case str
            Case "Monthly"
                intIntMode = 1
                RepaymentPeriod = 1
            Case "Quaterly"
                intIntMode = 3
                RepaymentPeriod = 3
            Case "Yearly"
                intIntMode = 12
                RepaymentPeriod = 12
        End Select

        strLoan = Mid(txtLoanNo.Text, 1, 2)

        If strLoan = "SD" Then

            'intInterestDiff = DateDiff(DateInterval.Day, datFromDate, dtpPayDate.Value)
            'If dtpPayDate.Value > dtpDueDate.Value Then
            '    If datLoanDate > dtpDueDate.Value tetThen
            '        intCalPenel = Math.Round(((objclsRepayment.PaymentTable.Rows(0).Item("Balance") * intInterestDiff * (2 / 100)) / 365), 2)
            '    Else
            '        intCalPenel = Math.Round(((objclsRepayment.PaymentTable.Rows(0).Item("Balance") * intInterestDiff * (10 / 100)) / 365), 2)
            '    End If
            'ElseIf dtpPayDate.Value >= datLoanDate And dtpPayDate.Value <= dtpDueDate.Value Then
            '    If intInterestDiff >= 15 Then
            '        intCalPenel = Math.Round(((objclsRepayment.PaymentTable.Rows(0).Item("Balance") * intInterestDiff * (2 / 100)) / 365), 2)
            '    Else
            '        intCalPenel = 0
            '    End If
            'End If
            intcalInterest = 0

        Else

            intInterestDiff = DateDiff(DateInterval.Month, datFromDate, datToDate)
            While intInterestDiff >= intCOunter
                datNextDate = DateAdd(DateInterval.Month, 2, datLoanDate)
                datNextDate = datNextDate.AddDays(-(datNextDate.Day))

                ' datTemp = DateAdd(DateInterval.Month, intCOunter, datLoanInst)
                If datNextDate > datToDate Then
                    datNextDate = datToDate
                End If
                intNOD = DateDiff(DateInterval.Day, datLoanDate, datNextDate)
                intcalInterest += Math.Round((((dblBalance + Round(intcalInterest, 2) + intCalPenel) * intNOD * (txtROI.Text / 100)) / 365), 2)
                'If intCOunter = RepaymentPeriod Then
                '    intNODPenal = DateDiff(DateInterval.Day, datLoanDate, datToDate)
                '    If intNODPenal > 0 Then
                '        If strLoan = "JL" Then
                '            intCalPenel += Math.Round(((intcalInterest * intNODPenal * (txtPI.Text / 100)) / 365), 2)
                '        Else
                '            intCalPenel += Math.Round(((objclsRepayment.PaymentTable.Rows(0).Item("InstPrinciple") * intNODPenal * (txtPI.Text / 100)) / 365), 2)
                '        End If
                '    End If
                '    'This Commented line will allow for PenalIntrest Cummulative
                'End If
                datLoanDate = datNextDate
                intCOunter += 1
            End While
            intNOD = DateDiff(DateInterval.Day, datNextDate, datToDate)

            If intNOD > 0 Then
                intcalInterest += Math.Round((((dblBalance + intcalInterest + intCalPenel) * intNOD * (txtROI.Text / 100)) / 365), 2)
            End If

        End If


    End Function


    Public Function fnCheck() As Boolean
        Dim strLoan As String
        'If txtAmount.Text = "" Then
        '    MsgBox("Enter the Amount")
        '    txtAmount.Focus()
        '    Return False
        ' Else
        
        If Val(txtPrinciple.Text) < 0 Then
            MsgBox("Principle Amount Cannot Be Less Than 0", MsgBoxStyle.Exclamation)
            txtPrinciple.Focus()
            Return False
            'ElseIf txtAmount.Text = "0" Then
            '    If chkUse.Checked = False Then
            '        MsgBox("Enter the Amount")
            '        txtAmount.Focus()
            '        Return False
            '    Else
            '        Return True
            '    End If
        ElseIf txtChalanNo.Text = "" Then
            MsgBox("Enter Challan No")
            txtChalanNo.Focus()
            Return False
        ElseIf txtReferenceNo.Text = String.Empty Then
            MsgBox("Enter Reference Number")
            txtReferenceNo.Focus()
            Return False
        ElseIf txtReceiptnO.Text = String.Empty Then
            MsgBox("Enter Receipt Number")
            txtReceiptnO.Focus()
            Return False
        ElseIf rtpRemarks.Text = "" Then
            MsgBox("Enter Remarks")
            rtpRemarks.Focus()
            Return False
        ElseIf txtInterest.Text = "" Then
            strLoan = Mid(txtLoanNo.Text, 1, 2)
            If strLoan <> "DR" Then
                MsgBox("Cal Interest")
                btnCalInterest.Focus()
                Return False
            Else
                Return True
            End If
        ElseIf txtInterest.Text < 0 Then
            MsgBox("Amount Cannot Be Less Than Zero", MsgBoxStyle.Exclamation)
            Return False
        ElseIf countCalBtnCount = 0 Then
            MsgBox("Please click the Cal Button")
            btnCalInterest.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'Working Correctly loan intrest calculation without month end 31st Day calculation

    Public Function fnCalcInterest() As Boolean
        Dim strLoan As String

        Dim intDate3 As Integer
        Dim intDate4 As Integer
        Dim intCount As Integer = 0
        Dim intCalInterest1 As Integer = 0
        Dim intCalInterest2 As Integer = 0
        Dim dvDisb As DataView
        Dim dblTempAmount As Double

        'For SB Transfer
        dblAvalAmount = 0
        dblOverDrawLimit = 0
        dblCalIntrest = 0
        dblBalance = 0
        intcalInterest = 0
        intCalPenel = 0
        intTotalInterest = 0
        intTotalPenal = 0


        '   '   ' ************** Function to calculate penel interest and interest
        txtInterest.ReadOnly = False
        txtPenelInterest.ReadOnly = False
        txtPrinciple.ReadOnly = False

        If objclsRepayment.fnGetData(txtLoanNo.Text) Then

        End If

        objclsRepayment.fnGetPaidDet(txtLoanNo.Text)

        '   '   '**To check weather it is first repayment of loan
        '   '   'If it is first repayment then second condition is checked weather the disbursment of the loan is
        '   '   'done once or many times.If it is done 2 times then the cal in If part is executed else
        '   '   'if cal in corresponding else part will get executed.
        '   '   'Same for payment of loan if the payment of loan is second time then disbursment is not checked.direct
        '   '   'direct corresponding else part gets executed.

        objclsDisb.fnCheckDis(txtLoanNo.Text)

        If objclsRepayment.fnGetDisb(txtLoanNo.Text) Then
            dvDisb = New DataView(objclsRepayment.disbtable, "", "", DataViewRowState.OriginalRows)
            dvDisb.RowFilter = "DisbUsability='N'"
            If dvDisb.Count > 0 Then
                While intCount < dvDisb.Count
                    'datLoanDate = dvDisb.Item(intCount).Item("DisbDate")
                    datLoanDate = DateAdd(DateInterval.Day, -1, dvDisb.Item(intCount).Item("DisbDate"))
                    datFromDate = dvDisb.Item(intCount).Item("DisbDate")
                    'datLoanInst = dvDisb.Item(intCount).Item("DisbDate")
                    'datToDate = dtpPayDate.Value
                    If cmbRepayType.Text = "Monthly interes" Then
                        datToDate = dtpPayDate.Value
                    Else
                        datToDate = DateAdd(DateInterval.Day, -1, dtpPayDate.Value)
                    End If
                    dblBalance = dvDisb.Item(intCount).Item("Amount")
                    dblTempAmount += dblBalance
                    fncalculate()
                    intTotalInterest += intcalInterest
                    intTotalPenal += intCalPenel
                    intCount += 1
                End While
                dvDisb.RowFilter = "DisbUsability='Y'"
                If dvDisb.Count > 0 Then
                    'datLoanInst = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                    'datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate")
                    'datFromDate = objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate")
                    datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                    datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
                    dblBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - dblTempAmount
                    'datToDate = dtpPayDate.Value
                    If cmbRepayType.Text = "Monthly interes" Then
                        datToDate = dtpPayDate.Value
                    Else
                        datToDate = DateAdd(DateInterval.Day, -1, dtpPayDate.Value)
                    End If
                    fncalculate()
                    intTotalInterest += intcalInterest
                    intTotalPenal += intCalPenel
                End If
            Else
                'datLoanInst = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                'datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate")
                'datFromDate = objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate")
                'datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate"))
                datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
                If cmbRepayType.Text = "Monthly interes" Then
                    datToDate = dtpPayDate.Value
                Else
                    datToDate = DateAdd(DateInterval.Day, -1, dtpPayDate.Value)
                End If
                If datLoanDate > datToDate Then
                    datToDate = dtpPayDate.Value
                End If


                dblBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance")
                fncalculate()
                intTotalInterest += intcalInterest
                intTotalPenal += intCalPenel
            End If

            txtInterest.Text = Math.Round(intTotalInterest) + dblCoverAmount
            txtPenelInterest.Text = Math.Round(intTotalPenal)

        End If

        Return True

    End Function


    Public Function fnCheckAmt() As Boolean

        If objclsRepayment.fnGetData(txtLoanNo.Text) = True Then

        End If

    End Function

    Public Function fnCheckReceiptNo() As Boolean

        If objclsRepayment.fnCheckReceiptNo(txtReceiptnO.Text) Then

            MsgBox("Receipt No, Already Exist", MsgBoxStyle.Information)

            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnAddDataList() As Boolean
        Dim intCount As Integer
        lvPaidDet.Items.Clear()
        If objclsRepayment.fnGetPaidDet(txtLoanNo.Text) Then
            While intCount < objclsRepayment.GetPaymentTable.Rows.Count
                lstvItems = (lvPaidDet.Items.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("InstNo")))
                lstvItems.SubItems.Add(Format(objclsRepayment.GetPaymentTable.Rows(intCount).Item("RepayDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("Debit"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("Credit"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("Balance"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("InterestRaised"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("InterestPaid"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("PenelInterest"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("InterestRaised") - objclsRepayment.GetPaymentTable.Rows(intCount).Item("InterestPaid") + objclsRepayment.GetPaymentTable.Rows(intCount).Item("PenelInterest"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("IntReceivable"))
                lstvItems.SubItems.Add(Format(objclsRepayment.GetPaymentTable.Rows(intCount).Item("FromDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(Format(objclsRepayment.GetPaymentTable.Rows(intCount).Item("ToDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(objclsRepayment.GetPaymentTable.Rows(intCount).Item("IntCOver"))
                intCount += 1
            End While
        End If

    End Function

    Public Function fnCheckAmount() As Boolean

        If objclsRepayment.fnMaxAmount(txtLoanNo.Text) Then

            intMaxAmt = objclsRepayment.MaxAmountTable.Rows(0).Item("Amount")

            '   '   '************** To check weather the amount is Disbursed Or not **********''

            If intMaxAmt = 0 Then

                MsgBox("The Amount is not yet Sanctioned", MsgBoxStyle.Information, "Loans Module")

                Return False

                '   '   '************* To check weather the borrower has paid more than the loaned Amount *********'

            ElseIf objclsRepayment.fnGetData(txtLoanNo.Text) Then

                intSancAmt = objclsRepayment.PaymentTable.Rows(0).Item("SancAmount")

                objclsRepayment.fnMaxNo(txtLoanNo.Text)

                'If objclsRepayment.MaxInstNoTable.Rows(0).Item("Principle") + txtAmount.Text > intSancAmt Then
                ' If objclsRepayment.MaxInstNoTable.Rows(0).Item("Principle") + txtPrinciple.Text > objclsRepayment.MaxInstNoTable.Rows(0).Item("Amount") Then
                If objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") + txtPrinciple.Text > objclsRepayment.MaxInstNoTable.Rows(0).Item("LoanAmount") Then

                    MsgBox("Amount to be paid is more than loaned Amount")

                    Return False

                    '   '   ' **************** To check weather the amount to be paid is disbursed,
                    '   '   ' **************** A part of loaned amount is disbursed not Full amount 

                    'ElseIf objclsRepayment.MaxInstNoTable.Rows(0).Item("Principle") + txtAmount.Text > objclsRepayment.PaymentTable.Rows(0).Item("DisbAmount") Then
                    'ElseIf objclsRepayment.MaxInstNoTable.Rows(0).Item("Principle") + txtPrinciple.Text > objclsRepayment.MaxInstNoTable.Rows(0).Item("Amount") Then
                ElseIf objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") + txtPrinciple.Text > objclsRepayment.MaxInstNoTable.Rows(0).Item("LoanAmount") Then

                    MsgBox("Amount Is not yet Disbursed", MsgBoxStyle.Information, "Re-Pay Module")

                    Return False

                    '   '   '   *************** To check the no of installments to be paid 


                    'ElseIf objclsRepayment.MaxInstNoTable.Rows(0).Item("instNo")) >= MsgBox(objclsRepayment.PaymentTable.Rows(0).Item("NOI")) Then

                    '    'If MsgBox(objclsRepayment.MaxInstNoTable.Rows(0).Item("principle")) + (objclsRepayment.GetPaymentTable.Rows(0).Item("Interest") + objclsRepayment.GetPaymentTable.Rows(0).Item("PenelInterest") + txtAmount.Text) <> MsgBox(objclsRepayment.GetPaymentTable.Rows(0).Item("Balance")) Then

                    '    If MsgBox(objclsRepayment.MaxInstNoTable.Rows(0).Item("principle") + txtAmount.Text) <> MsgBox(objclsRepayment.GetPaymentTable.Rows(0).Item("Balance")) Then

                    '        MsgBox("This is the last Installments pay full amount", MsgBoxStyle.Information, "Re-Pay Module")

                    '        Return False

                Else
                    Return True
                End If
            Else
                Return True
            End If
        End If
    End Function

    Public Function fnSaveData() As Boolean
        Dim dvDisb As DataView
        Dim intCount As Integer = 0


        If objclsRepayment.fnUpdataLoanDate(txtLoanNo.Text) Then
            fnAddDataList()

            fnGenerateVoucher()

            fnGenerateReceipt()

            If txtPrinciple.Text <> 0 Then
                fnLogEntry(pbUserId, "Loan Repayment BY " & txtLoanNo.Text & " Amount " & txtPrinciple.Text, Date.Now, "Transaction Repayment")
            End If

            If objclsRepayment.fnGetDisb(txtLoanNo.Text) Then
                dvDisb = New DataView(objclsRepayment.disbtable, "", "", DataViewRowState.OriginalRows)
                dvDisb.RowFilter = "DisbUsability='N'"
                If dvDisb.Count > 0 Then
                    While intCount < dvDisb.Count
                        objclsDisb.fnUpdateDisbStatus(txtLoanNo.Text, dvDisb.Item(intCount).Item("SlNo"))
                        intCount += 1
                    End While
                End If
            End If


            fnAddDataList()

            dtpLastPaidDate.Value = Date.Today

            fnGetStatus()

            Return True
        Else
            Return False

        End If


    End Function

    Public Function fnGetROI() As Boolean

        If objclsRepayment.fnGetROI(txtLoanNo.Text) Then

            txtROI.Text = (objclsRepayment.LoanTypetable.Rows(0).Item("ROI") * 100)

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetPenel() As Boolean

        If objclsRepayment.fnGetPenelInterest(txtLoanNo.Text) Then

            txtPI.Text = objclsRepayment.PenelInteresttable.Rows(0).Item("PI")

        End If

    End Function

    Public Function fnReportGeneration() As Boolean

        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/ReceiptKan.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{receiptmaintbl.ReceiptNo}='" & txtReceiptnO.Text & "' and {ReceiptMainTbl.ReceiptDate}=#" & Format(dtpPayDate.Value, "MM-dd-yyyy") & "#"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Function

    Public Function fnGetStatus() As Boolean

        If objclsRepayment.fnGetROI(txtLoanNo.Text) Then

            If objclsRepayment.LoanTypetable.Rows(0).Item("SancAmount") = objclsRepayment.LoanTypetable.Rows(0).Item("DisbAmount") Then

                If objclsRepayment.LoanTypetable.Rows(0).Item("Balance") = 0 Then

                    If objclsRepayment.fnUpdateStatus(txtLoanNo.Text) Then

                    End If
                End If
            End If
        End If
    End Function

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub FrmRePayement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpPayDate.Value = Date.Now.Date
        txtLoanNo.ReadOnly = True
        fnGetROI()
        fnGetPenel()
        fnGetData()
        fnAddDataList()
        Panel3.Enabled = False

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If fnCheck() Then

            If fnCheckAmount() Then

                If fnCheckReceiptNo() Then

                    If fnSetData() Then

                        If fnSaveData() Then

                            MsgBox("Amount Paid Sccessfully", MsgBoxStyle.Information, "Re-Payment Module")
                            countCalBtnCount = 0

                        End If

                        fnClearData()

                        fnAddDataList()

                        fnGetData()
                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/CrystalReport1.rpt"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        If cmbRepayType.Text = String.Empty Then
            MsgBox("Select loan repayment type")
            Me.TabControl1.SelectedTab = Me.LoanDetails
            cmbRepayType.Focus()
        ElseIf txtROI.Text = "" Then
            MsgBox("Enter the Rate Of Interest")
            txtROI.Focus()
        ElseIf txtPI.Text = "" Then
            MsgBox("Enter the Penal Interest")
            txtPI.Focus()
        ElseIf IsDBNull(objclsRepayment.PaymentTable.Rows(0).Item("Type")) = True Then
            MsgBox("Installment Type is not mentioned in Loan detail form")
        Else
            If fnCalcInterest() Then
                If cmbRepayType.Text = "Closure" Then
                    fnCalculatePrePayment()
                End If
                chkCarryOver_CheckedChanged(sender, e)
                countCalBtnCount = countCalBtnCount + 1
            End If
        End If
    End Sub

    Private Sub txtInterest_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterest.TextChanged, txtOthers.TextChanged, txtPenelInterest.TextChanged, txtAmount.TextChanged
        fnCalTotal()
    End Sub


#Region "Navigation"

    Private Sub lvPaidDet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvPaidDet.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub rtpRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtChalanNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtInterest_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtLoanNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtOthers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPenelInterest_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPrinciple_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPrincipleAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtReferenceNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub
    Private Sub rtpRemarks_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
        End If
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        fnClearData()
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fnCalTotal()
    End Sub

    Private Sub chkUse_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUse.CheckedChanged
        If chkUse.Checked = True Then
            txtTransferAmount.Text = Val(txtTransFund.Text) + Val(txtSecDeposit.Text)
        Else
            txtTransferAmount.Text = Val(txtTransFund.Text)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If chkSB.Checked = True Then
            Dim objSBAccSearch As New frmSBAccSearch
            objSBAccSearch.strSBAccountNo = String.Empty
            objSBAccSearch.ShowDialog(Me)
            If objSBAccSearch.strSBAccountNo <> String.Empty Then
                txtAccNo.Text = objSBAccSearch.strSBAccountNo
                sbloaddetails()
                objSBAccSearch.Dispose()
            End If
        ElseIf chkCA.Checked = True Then
            Dim objCAccountSearch As New frmCAccSearch
            objCAccountSearch.strCAccountNo = String.Empty
            objCAccountSearch.ShowDialog(Me)
            If objCAccountSearch.strCAccountNo <> String.Empty Then
                txtAccNo.Text = objCAccountSearch.strCAccountNo
                caloaddetails()
                objCAccountSearch.Dispose()
            End If
        Else
            MsgBox("Select Account Type")
        End If

    End Sub

    Private Sub chkFundTransfer_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFundTransfer.CheckedChanged
        If chkFundTransfer.Checked = True Then
            Panel3.Enabled = True

        ElseIf chkFundTransfer.Checked = False Then
            Panel3.Enabled = False
            txtAccNo.ResetText()
            txtTransFund.ResetText()
            lblAvalBal.Text = 0.0
            chkCA.Checked = False
            chkSB.Checked = False
        End If
    End Sub

    Private Sub txtTransferAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransferAmount.TextChanged, txtRemainingAmount.TextChanged
        txtAmount.Text = Val(txtTransferAmount.Text) + Val(txtRemainingAmount.Text)
    End Sub

    Private Sub txtTransFund_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransFund.TextChanged
        If chkUse.Checked = True Then
            txtTransferAmount.Text = Val(txtTransFund.Text) + Val(txtSecDeposit.Text)
        Else
            txtTransferAmount.Text = Val(txtTransFund.Text)
        End If
    End Sub

    Private Sub txtTransFund_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransFund.LostFocus

        If chkSB.Checked = True Then
            If Val(txtTransFund.Text) > lblAvalBal.Text Then
                MsgBox("Amount is Greater Than Available Amount")
                txtTransFund.Focus()
            End If
        ElseIf chkCA.Checked = True Then
            If Val(txtTransFund.Text) > Val(dblAvalAmount) + Val(dblOverDrawLimit) Then
                MsgBox("WithDrawal Amount is Exceeding Limited Amount Please Enter Valid Amount")
                txtTransFund.Focus()
            End If
        End If

    End Sub

    Private Sub chkCA_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCA.CheckedChanged
        If chkCA.Checked = True Then
            chkSB.Checked = False
            lblAType.Text = "Amt From CA:"
        End If
    End Sub

    Private Sub chkSB_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSB.CheckedChanged
        If chkSB.Checked = True Then
            chkCA.Checked = False
            lblAType.Text = "Amt From SB:"
        End If
    End Sub

    Private Sub chkCarryOver_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCarryOver.CheckedChanged
        If chkCarryOver.Checked = True Then
            txtInterest.Text = 0
            txtPenelInterest.Text = 0
        ElseIf chkCarryOver.Checked = False Then
            txtInterest.Text = Math.Round(intTotalInterest) + dblCoverAmount
            txtPenelInterest.Text = Math.Round(intTotalPenal)
        End If
    End Sub

    Private Sub cmbRepayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRepayType.SelectedIndexChanged
        If cmbRepayType.Text = "Repaymen" Then
            chkCarryOver.Checked = True
        Else
            chkCarryOver.Checked = False
        End If




    End Sub
End Class

