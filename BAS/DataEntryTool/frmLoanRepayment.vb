Imports System.Windows.Forms



Public Class frmLoanRepayment
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
    Friend WithEvents chkUse As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSecDeposit As BankControls.NumericControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipleAmount As BankControls.NumericControl
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPrinciple As BankControls.NumericControl
    Friend WithEvents txtOthers As BankControls.NumericControl
    Friend WithEvents txtPenelInterest As BankControls.NumericControl
    Friend WithEvents txtInterest As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLoanType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rtpRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtChalanNo As BankControls.NumericControl
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRemainingIntrest As BankControls.NumericControl
    Friend WithEvents txtReceiptnO As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLoanRepayment))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkUse = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtSecDeposit = New BankControls.NumericControl
        Me.txtName = New BankControls.TextControl
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPrincipleAmount = New BankControls.NumericControl
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtPrinciple = New BankControls.NumericControl
        Me.txtOthers = New BankControls.NumericControl
        Me.txtPenelInterest = New BankControls.NumericControl
        Me.txtInterest = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLoanType = New System.Windows.Forms.ComboBox
        Me.btnSearch = New BankControls.NewButton
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.rtpRemarks = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtChalanNo = New BankControls.NumericControl
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtRemainingIntrest = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtReceiptnO = New BankControls.NumericControl
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chkUse)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtSecDeposit)
        Me.Panel1.Location = New System.Drawing.Point(24, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 64)
        Me.Panel1.TabIndex = 7
        '
        'chkUse
        '
        Me.chkUse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chkUse.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.chkUse.Location = New System.Drawing.Point(48, 40)
        Me.chkUse.Name = "chkUse"
        Me.chkUse.Size = New System.Drawing.Size(184, 16)
        Me.chkUse.TabIndex = 9
        Me.chkUse.Text = "Use Security Deposit"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 18)
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
        Me.txtSecDeposit.Location = New System.Drawing.Point(144, 6)
        Me.txtSecDeposit.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSecDeposit.MaxValue = 9999999999999
        Me.txtSecDeposit.MinValue = 0
        Me.txtSecDeposit.Name = "txtSecDeposit"
        Me.txtSecDeposit.ReadOnly = True
        Me.txtSecDeposit.Size = New System.Drawing.Size(160, 23)
        Me.txtSecDeposit.TabIndex = 8
        Me.txtSecDeposit.TabStop = False
        Me.txtSecDeposit.Text = ""
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(168, 88)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 5
        Me.txtName.Text = ""
        '
        'dtpToDate
        '
        Me.dtpToDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpToDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpToDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(512, 64)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpToDate.TabIndex = 16
        Me.dtpToDate.Value = New Date(2009, 3, 11, 12, 47, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(400, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 659
        Me.Label3.Text = "To Date"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFromDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFromDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(512, 32)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpFromDate.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(400, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 658
        Me.Label6.Text = "From Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(24, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 656
        Me.Label5.Text = "Sanctioned Amount"
        '
        'txtPrincipleAmount
        '
        Me.txtPrincipleAmount.AfterDecimal = 0
        Me.txtPrincipleAmount.BackColor = System.Drawing.Color.White
        Me.txtPrincipleAmount.BeforeDecimal = 10
        Me.txtPrincipleAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPrincipleAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPrincipleAmount.Location = New System.Drawing.Point(168, 120)
        Me.txtPrincipleAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPrincipleAmount.MaxValue = 9999999999999
        Me.txtPrincipleAmount.MinValue = 0
        Me.txtPrincipleAmount.Name = "txtPrincipleAmount"
        Me.txtPrincipleAmount.ReadOnly = True
        Me.txtPrincipleAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtPrincipleAmount.TabIndex = 6
        Me.txtPrincipleAmount.Text = ""
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDueDate.Enabled = False
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(512, 104)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDueDate.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 657
        Me.Label7.Text = "Due Date"
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(168, 57)
        Me.txtLoanNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.Size = New System.Drawing.Size(168, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 3
        Me.txtLoanNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 655
        Me.Label1.Text = "Loan No."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(24, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 19)
        Me.Label17.TabIndex = 654
        Me.Label17.Text = "Name"
        '
        'txtPrinciple
        '
        Me.txtPrinciple.AfterDecimal = 0
        Me.txtPrinciple.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrinciple.BeforeDecimal = 10
        Me.txtPrinciple.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPrinciple.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtPrinciple.Location = New System.Drawing.Point(168, 320)
        Me.txtPrinciple.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPrinciple.MaxLength = 10
        Me.txtPrinciple.MaxValue = 9999999999999
        Me.txtPrinciple.MinValue = 0
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(168, 23)
        Me.txtPrinciple.TabIndex = 13
        Me.txtPrinciple.Text = "0"
        '
        'txtOthers
        '
        Me.txtOthers.AfterDecimal = 0
        Me.txtOthers.BeforeDecimal = 10
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtOthers.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOthers.Location = New System.Drawing.Point(168, 288)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.MaxLength = 10
        Me.txtOthers.MaxValue = 9999999999999
        Me.txtOthers.MinValue = 0
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(168, 23)
        Me.txtOthers.TabIndex = 12
        Me.txtOthers.Text = ""
        '
        'txtPenelInterest
        '
        Me.txtPenelInterest.AfterDecimal = 0
        Me.txtPenelInterest.BackColor = System.Drawing.SystemColors.Window
        Me.txtPenelInterest.BeforeDecimal = 10
        Me.txtPenelInterest.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPenelInterest.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtPenelInterest.Location = New System.Drawing.Point(168, 224)
        Me.txtPenelInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPenelInterest.MaxLength = 10
        Me.txtPenelInterest.MaxValue = 9999999999999
        Me.txtPenelInterest.MinValue = 0
        Me.txtPenelInterest.Name = "txtPenelInterest"
        Me.txtPenelInterest.Size = New System.Drawing.Size(168, 23)
        Me.txtPenelInterest.TabIndex = 10
        Me.txtPenelInterest.TabStop = False
        Me.txtPenelInterest.Text = ""
        '
        'txtInterest
        '
        Me.txtInterest.AfterDecimal = 2
        Me.txtInterest.BackColor = System.Drawing.SystemColors.Window
        Me.txtInterest.BeforeDecimal = 8
        Me.txtInterest.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtInterest.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterest.Location = New System.Drawing.Point(168, 256)
        Me.txtInterest.LostFocusColour = System.Drawing.Color.White
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(168, 23)
        Me.txtInterest.TabIndex = 11
        Me.txtInterest.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(24, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 19)
        Me.Label13.TabIndex = 671
        Me.Label13.Text = "Principle"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(24, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 19)
        Me.Label12.TabIndex = 670
        Me.Label12.Text = "Others"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(24, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 19)
        Me.Label11.TabIndex = 669
        Me.Label11.Text = "PenelInterest"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(24, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 19)
        Me.Label10.TabIndex = 668
        Me.Label10.Text = "Paid Interest"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 674
        Me.Label2.Text = "Loan Type "
        '
        'cmbLoanType
        '
        Me.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoanType.ForeColor = System.Drawing.Color.Black
        Me.cmbLoanType.ItemHeight = 16
        Me.cmbLoanType.Items.AddRange(New Object() {"Jewel Loan", "Vehicle Loan", "Surety Loan", "Hand Loan", "Over Draft", "Colleteral Hand Loan", "Loans On Term Deposit", "Souharda Daily Recovery Laon"})
        Me.cmbLoanType.Location = New System.Drawing.Point(168, 24)
        Me.cmbLoanType.Name = "cmbLoanType"
        Me.cmbLoanType.Size = New System.Drawing.Size(208, 24)
        Me.cmbLoanType.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(352, 56)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(384, 336)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 32)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "S&ave"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(492, 336)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 32)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "&Reset"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(600, 336)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "C&lose"
        '
        'rtpRemarks
        '
        Me.rtpRemarks.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rtpRemarks.Location = New System.Drawing.Point(512, 232)
        Me.rtpRemarks.MaxLength = 100
        Me.rtpRemarks.Name = "rtpRemarks"
        Me.rtpRemarks.Size = New System.Drawing.Size(160, 64)
        Me.rtpRemarks.TabIndex = 21
        Me.rtpRemarks.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(400, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 682
        Me.Label8.Text = "Remarks"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(400, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 19)
        Me.Label16.TabIndex = 681
        Me.Label16.Text = "Receipt No."
        '
        'txtChalanNo
        '
        Me.txtChalanNo.AfterDecimal = 0
        Me.txtChalanNo.BeforeDecimal = 10
        Me.txtChalanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtChalanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChalanNo.Location = New System.Drawing.Point(512, 136)
        Me.txtChalanNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChalanNo.MaxLength = 10
        Me.txtChalanNo.MaxValue = 9999999999999
        Me.txtChalanNo.MinValue = 0
        Me.txtChalanNo.Name = "txtChalanNo"
        Me.txtChalanNo.Size = New System.Drawing.Size(160, 23)
        Me.txtChalanNo.TabIndex = 18
        Me.txtChalanNo.Text = ""
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 10
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(512, 168)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReferenceNo.MaxValue = 9999999999999
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(160, 23)
        Me.txtReferenceNo.TabIndex = 19
        Me.txtReferenceNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(400, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 686
        Me.Label4.Text = "Challan No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(400, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 685
        Me.Label9.Text = "Reference No."
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.txtAmount.BeforeDecimal = 10
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(168, 384)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 9
        Me.txtAmount.MaxValue = 9999999999999
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtAmount.TabIndex = 687
        Me.txtAmount.TabStop = False
        Me.txtAmount.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(24, 386)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 19)
        Me.Label14.TabIndex = 688
        Me.Label14.Text = "Total Amount"
        '
        'txtRemainingIntrest
        '
        Me.txtRemainingIntrest.AfterDecimal = 2
        Me.txtRemainingIntrest.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemainingIntrest.BeforeDecimal = 8
        Me.txtRemainingIntrest.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtRemainingIntrest.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemainingIntrest.Location = New System.Drawing.Point(168, 352)
        Me.txtRemainingIntrest.LostFocusColour = System.Drawing.Color.White
        Me.txtRemainingIntrest.MaxLength = 10
        Me.txtRemainingIntrest.MaxValue = 0
        Me.txtRemainingIntrest.MinValue = 0
        Me.txtRemainingIntrest.Name = "txtRemainingIntrest"
        Me.txtRemainingIntrest.Size = New System.Drawing.Size(168, 23)
        Me.txtRemainingIntrest.TabIndex = 14
        Me.txtRemainingIntrest.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(24, 354)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 19)
        Me.Label15.TabIndex = 690
        Me.Label15.Text = "Remaining Interest"
        '
        'txtReceiptnO
        '
        Me.txtReceiptnO.AfterDecimal = 0
        Me.txtReceiptnO.BeforeDecimal = 10
        Me.txtReceiptnO.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReceiptnO.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptnO.Location = New System.Drawing.Point(512, 200)
        Me.txtReceiptnO.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptnO.MaxValue = 9999999999999
        Me.txtReceiptnO.MinValue = 0
        Me.txtReceiptnO.Name = "txtReceiptnO"
        Me.txtReceiptnO.Size = New System.Drawing.Size(160, 23)
        Me.txtReceiptnO.TabIndex = 20
        Me.txtReceiptnO.Text = ""
        '
        'frmLoanRepayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(696, 421)
        Me.Controls.Add(Me.txtReceiptnO)
        Me.Controls.Add(Me.txtRemainingIntrest)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtChalanNo)
        Me.Controls.Add(Me.txtReferenceNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrinciple)
        Me.Controls.Add(Me.txtOthers)
        Me.Controls.Add(Me.txtPenelInterest)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrincipleAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLoanNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.rtpRemarks)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbLoanType)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.dtpDueDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanRepayment"
        Me.Text = "Loan Repayment"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Golbal Variables"

    Dim objclsRepayment As New clsRePayment
    Dim objclsDisb As New clsDisbursment

    Dim intMaxAmt As Integer
    Dim intSancAmt As Integer
    Dim intInterestDiff As Integer

#End Region

    Sub fnLoadName()
        objclsRepayment.fngetLoneeName(txtLoanNo.Text)
        txtName.Text = objclsRepayment.PaymentTable.Rows(0).Item("Name")
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Select Case cmbLoanType.SelectedItem
            Case "Jewel Loan"
                Dim objfrmGoldLoanCust As New frmGoldLoanCust
                objfrmGoldLoanCust.strGoldLoan = String.Empty
                objfrmGoldLoanCust.ShowDialog(Me)
                If objfrmGoldLoanCust.strGoldLoan <> String.Empty Then
                    txtLoanNo.Text = objfrmGoldLoanCust.strGoldLoan
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objfrmGoldLoanCust.Dispose()

            Case "Vehicle Loan"
                Dim objfrmVehicleLoanCust As New frmVehicleLoanCust
                objfrmVehicleLoanCust.strVehicleLoan = String.Empty
                objfrmVehicleLoanCust.ShowDialog(Me)
                If objfrmVehicleLoanCust.strVehicleLoan <> String.Empty Then
                    txtLoanNo.Text = objfrmVehicleLoanCust.strVehicleLoan
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objfrmVehicleLoanCust.Dispose()


            Case "Surety Loan"
                Dim objfrmSuretyLoanCust As New frmSuretyLoanCust
                objfrmSuretyLoanCust.strSuretyLoan = String.Empty
                objfrmSuretyLoanCust.ShowDialog(Me)
                If objfrmSuretyLoanCust.strSuretyLoan <> String.Empty Then
                    txtLoanNo.Text = objfrmSuretyLoanCust.strSuretyLoan
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objfrmSuretyLoanCust.Dispose()

            Case "Hand Loan"
                Dim objHandLoanCust As New frmHandLoanCust
                objHandLoanCust.strHandLoan = String.Empty
                objHandLoanCust.ShowDialog(Me)
                If objHandLoanCust.strHandLoan <> String.Empty Then
                    txtLoanNo.Text = objHandLoanCust.strHandLoan
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objHandLoanCust.Dispose()

            Case "Colleteral Hand Loan"
                Dim objColateralHandLoanCust As New frmColleteralHandLoanCustl
                objColateralHandLoanCust.strCHandLoan = String.Empty
                objColateralHandLoanCust.ShowDialog(Me)
                If objColateralHandLoanCust.strCHandLoan <> String.Empty Then
                    txtLoanNo.Text = objColateralHandLoanCust.strCHandLoan
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objColateralHandLoanCust.Dispose()

            Case "Loans On Term Deposit"
                Dim objDepositLoanCust As New frmLoanAgainstDepositCust
                objDepositLoanCust.strLoansOnDep = String.Empty
                objDepositLoanCust.ShowDialog(Me)
                If objDepositLoanCust.strLoansOnDep <> String.Empty Then
                    txtLoanNo.Text = objDepositLoanCust.strLoansOnDep
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objDepositLoanCust.Dispose()

            Case "Over Draft"


            Case "Souharda Daily Recovery Laon"
                Dim objDailyRecoveryLoanCust As New frmDailyRecoveryLoanCust
                objDailyRecoveryLoanCust.strLoan = String.Empty
                objDailyRecoveryLoanCust.ShowDialog(Me)
                If objDailyRecoveryLoanCust.strLoan <> String.Empty Then
                    txtLoanNo.Text = objDailyRecoveryLoanCust.strLoan
                    If fnGetData() Then
                        fnLoadName()
                    Else
                        btnClear_Click(sender, e)
                    End If
                End If
                objDailyRecoveryLoanCust.Dispose()

        End Select


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Public Function fnGetData() As Boolean

        If objclsRepayment.fnGetData(txtLoanNo.Text) Then

            If objclsRepayment.PaymentTable.Rows(0).Item("DisbAmount") <> 0 Then

                txtPrincipleAmount.Text = objclsRepayment.PaymentTable.Rows(0).Item("SancAmount")

                dtpDueDate.Value = Format(objclsRepayment.PaymentTable.Rows(0).Item("DueDate"), "yyyy-MM-dd")

                txtSecDeposit.Text = objclsRepayment.PaymentTable.Rows(0).Item("SecurityDeposit")

                Return True
            Else
                MsgBox("Please Disbursement the Amount First", MsgBoxStyle.Information)

                Return False
            End If

        End If

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objTrans As IDbTransaction

        If fnCheck() Then

            If fnCheckAmount() Then

                If fnCheckReceiptNo() Then

                    Try
                        objTrans = fnGetTransaction()
                        If fnSetData() Then

                            If fnSaveData(objTrans) Then
                                objTrans.Commit()
                                MsgBox("Amount Paid Sccessfully", MsgBoxStyle.Information, "Re-Payment Module")

                            End If

                            fnClearData()

                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Finally
                        objTrans.Dispose()
                    End Try

                End If

            End If

        End If

    End Sub

    Public Function fnClearData() As Boolean

        txtChalanNo.Text = ""
        rtpRemarks.Text = ""
        txtReceiptnO.ResetText()
        txtOthers.ResetText()
        txtPrinciple.ResetText()

        txtReferenceNo.ResetText()
        txtPenelInterest.ResetText()
        txtInterest.ResetText()
        chkUse.Checked = False
        txtReceiptnO.ResetText()
        txtLoanNo.ResetText()
        txtName.ResetText()
        txtSecDeposit.ResetText()
        txtPrincipleAmount.ResetText()
        txtRemainingIntrest.ResetText()

        intMaxAmt = 0
        intSancAmt = 0
        txtPrinciple.Text = 0
        txtAmount.Text = 0
        Return True

    End Function

    Public Function fnCheck() As Boolean
        Dim strLoan As String
        If Val(txtPrinciple.Text) < 0 Then
            MsgBox("Principle Amount Cannot Be Less Than 0", MsgBoxStyle.Exclamation)
            txtPrinciple.Focus()
            Return False
        ElseIf txtChalanNo.Text = "" Then
            MsgBox("Enter Challan No")
            txtChalanNo.Focus()
            Return False
        ElseIf rtpRemarks.Text = "" Then
            MsgBox("Emter Remarks")
            rtpRemarks.Focus()
            Return False
        ElseIf txtReceiptnO.Text = "" Then
            MsgBox("Enter Recipt Number")
            txtReceiptnO.Focus()
            Return False
        ElseIf txtReferenceNo.Text = "" Then
            MsgBox("Enter Reference Number")
            txtReferenceNo.Focus()
            Return False
        ElseIf Val(txtInterest.Text) < 0 Then
            MsgBox("Amount Cannot Be Less Than Zero", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
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

                If objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") + Val(txtPrinciple.Text) > objclsRepayment.MaxInstNoTable.Rows(0).Item("LoanAmount") Then

                    MsgBox("Amount to be paid is more than loaned Amount")

                    Return False

                    '   '   ' **************** To check weather the amount to be paid is disbursed,
                    '   '   ' **************** A part of loaned amount is disbursed not Full amount 

                ElseIf objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") + Val(txtPrinciple.Text) > objclsRepayment.MaxInstNoTable.Rows(0).Item("LoanAmount") Then

                    MsgBox("Amount Is not yet Disbursed", MsgBoxStyle.Information, "Re-Pay Module")

                    Return False

                Else

                    Return True

                End If

            Else

                Return True

            End If

        End If

        'End If

    End Function
    Public Function fnCheckReceiptNo() As Boolean

        If objclsRepayment.fnCheckReceiptNo(txtReceiptnO.Text) Then

            MsgBox("Receipt No, Already Exist", MsgBoxStyle.Information)

            Return False
        Else
            Return True

        End If

    End Function
    Public Function fnSetData() As Boolean
        Dim strTemp As String
        Dim datTemp As Date
        Dim strLoan As String

        objclsRepayment.LoanNo = txtLoanNo.Text
        objclsRepayment.Remarks = rtpRemarks.Text
        objclsRepayment.PaidDate = Format(dtpToDate.Value, "yyyy-MM-dd")
        objclsRepayment.ChallanNo = txtChalanNo.Text
        objclsRepayment.VoucherNo = 0
        objclsRepayment.Others = Val(txtOthers.Text)
        objclsRepayment.Debit = Val(txtRemainingIntrest.Text)
        objclsRepayment.IntrestPaid = Val(txtInterest.Text)
        objclsRepayment.FromDate = Format(dtpFromDate.Value, "yyyy-MM-dd")
        objclsRepayment.ToDate = Format(dtpToDate.Value, "yyyy-MM-dd")
        objclsRepayment.Amount = (Val(txtRemainingIntrest.Text) - Val(txtPrinciple.Text))

        If txtReferenceNo.Text = "" Then
            objclsRepayment.ReferenceNo = 0
        Else
            objclsRepayment.ReferenceNo = txtReferenceNo.Text
        End If

        objclsRepayment.IntReceivable = Val(txtRemainingIntrest.Text)
        objclsRepayment.Intrest = Val(txtInterest.Text)
        objclsRepayment.PenelIntrest = Val(txtPenelInterest.Text)

        If Val(txtPrinciple.Text) < 0 Then
            MsgBox("Amount cannot be less than 0", MsgBoxStyle.Information)
            Return False
        Else
            objclsRepayment.Credit = Math.Round(Val(txtPrinciple.Text))

        End If

        If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then

            objclsRepayment.InstNo = objclsRepayment.MaxInstNoTable.Rows(0).Item("InstNo") + 1

        End If

        objclsRepayment.LastInstDate = dtpToDate.Value

        If chkUse.Checked = True Then
            objclsRepayment.SecurityDeposit = 0
        Else
            objclsRepayment.SecurityDeposit = txtSecDeposit.Text
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

    Public Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean
        Dim dvDisb As DataView
        Dim intCount As Integer = 0

        If objclsRepayment.fnUpdataLoanDate(txtLoanNo.Text, objTrans) Then
            fnGenerateVoucher(objTrans)
            If txtPrinciple.Text <> 0 Then
                fnLogEntry(pbUserId, "Loan Repayment BY " & txtLoanNo.Text & " Amount " & Val(txtPrinciple.Text), Date.Now, "Transaction Repayment", objTrans)
            End If
            If objclsRepayment.fnGetDisb(txtLoanNo.Text) Then
                dvDisb = New DataView(objclsRepayment.disbtable, "", "", DataViewRowState.OriginalRows)
                dvDisb.RowFilter = "DisbUsability='N'"
                If dvDisb.Count > 0 Then
                    While intCount < dvDisb.Count
                        objclsDisb.fnUpdateDisbStatus(txtLoanNo.Text, dvDisb.Item(intCount).Item("SlNo"), objTrans)
                        intCount += 1
                    End While
                End If
            End If
            fnGetStatus()
            Return True
        Else
            Return False

        End If
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

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        'Loan Repayment With Securety Deposit Dr to repay Loan 

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strLoan As String
        Dim dblRemPrinciple As Double
        Dim lngVoucher As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpToDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        lngVoucher = lngVoucherNo

        objclsRepayment.fnAddData(lngVoucher, objTrans)

        Dim strNarration As String = "Repayment of Loan By " & txtLoanNo.Text & "  Narration:" & rtpRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReferenceNo.Text, dtpToDate.Value, txtAmount.Text, "Deposit By" & txtAmount.Text, lngSlNo, "Y", objTrans)

        strLoan = Mid(txtLoanNo.Text, 1, 2)

        Select Case strLoan

            Case "JL"


                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 15, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If txtPrinciple.Text <> 0 Then
                    'Credit
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 15, 0, Math.Round(Val(txtPrinciple.Text)), 2, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 21, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 3, "Y", objTrans)

                If chkUse.Checked = True Then
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 36, Val(txtSecDeposit.Text), 0, 7, "Y", objTrans)
                End If

            Case "LM"

                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 16, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If Val(txtPrinciple.Text) <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 16, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 22, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 2, "Y", objTrans)

                If chkUse.Checked = True Then
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 37, Val(txtSecDeposit.Text), 0, 7, "Y", objTrans)
                End If

            Case "LT"

                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 20, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If Val(txtPrinciple.Text) <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 20, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 26, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 2, "Y", objTrans)

                If chkUse.Checked = True Then
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 42, Val(txtSecDeposit.Text), 0, 7, "Y", objTrans)
                End If


            Case "CH"

                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 19, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If Val(txtPrinciple.Text) <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 19, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 25, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 2, "Y", objTrans)

                If chkUse.Checked = True Then
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 41, Val(txtSecDeposit.Text), 0, 7, "Y", objTrans)
                End If


            Case "SL"

                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 18, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If Val(txtPrinciple.Text) <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 18, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 24, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 2, "Y", objTrans)

                If chkUse.Checked = True Then
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 39, Val(txtSecDeposit.Text), 0, 7, "Y", objTrans)
                End If

            Case "HL"

                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 17, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If Val(txtPrinciple.Text) <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 17, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 23, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 2, "Y", objTrans)

                If chkUse.Checked = True Then
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 38, Val(txtSecDeposit.Text), 0, 6, "Y", objTrans)
                End If

            Case "SD"

                If Val(txtRemainingIntrest.Text) <> 0 Then
                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 43, Math.Round(Val(txtRemainingIntrest.Text)), 0, 1, "Y", objTrans)
                End If

                If Val(txtPrinciple.Text) <> 0 Then
                    'Credit account
                    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "To", 43, 0, Math.Round(Val(txtPrinciple.Text)), 1, "Y", objTrans)
                End If

                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Interest Paid By Account " & txtLoanNo.Text, "To", 44, 0, Val(txtInterest.Text) + Val(txtRemainingIntrest.Text), 2, "Y", objTrans)

        End Select

        If chkUse.Checked = True Then
            dblRemPrinciple = Val(txtAmount.Text) - Val(txtSecDeposit.Text)
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "By", 1, dblRemPrinciple, 0, 4, "Y", objTrans)
        Else
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpToDate.Value, "Loan Repayment By Account " & txtLoanNo.Text, "By", 1, txtAmount.Text, 0, 4, "Y", objTrans)
        End If

        If Val(txtPenelInterest.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "PenalInterest Paid By Account " & txtLoanNo.Text, "To", 40, 0, Val(txtPenelInterest.Text), 5, "Y", objTrans)
        End If

        If txtOthers.Text <> "" Or Val(txtOthers.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Misc Charges Paid By Account " & txtLoanNo.Text, "To", 13, 0, Val(txtOthers.Text), 6, "Y", objTrans)
        End If

        If txtRemainingIntrest.Text <> "" Or Val(txtRemainingIntrest.Text) <> 0 Then
            'Credit account interest recivable
            fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpToDate.Value, "Loan interest recivable By Account " & txtLoanNo.Text, "To", 59, 0, Math.Round(Val(txtRemainingIntrest.Text)), 7, "Y", objTrans)
        End If

        Return True

    End Function

    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptnO.Text, txtName.Text, dtpToDate.Value, Val(txtPrinciple.Text), "")

        'Receipt sub details
        fnReceiptEnterSub(txtReceiptnO.Text, dtpToDate.Value, "¸Á® ªÀÄgÀÄ¥ÁªÀw", Val(txtPrinciple.Text), 1)

        Return True

    End Function
    Private Sub txtPenelInterest_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPenelInterest.TextChanged, txtOthers.TextChanged, txtInterest.TextChanged, txtPrinciple.TextChanged
        If chkUse.Checked = True Then
            txtAmount.Text = Val(txtPenelInterest.Text) + Val(txtInterest.Text) + Val(txtOthers.Text) + Val(txtPrinciple.Text) + Val(txtSecDeposit.Text)
        ElseIf chkUse.Checked = False Then
            txtAmount.Text = Val(txtPenelInterest.Text) + Val(txtInterest.Text) + Val(txtOthers.Text) + Val(txtPrinciple.Text)
        End If
    End Sub

    Private Sub chkUse_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUse.CheckedChanged
        txtPenelInterest_TextChanged(sender, e)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        fnClearData()
    End Sub

    Private Sub frmLoanRepayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtpDueDate.MaxDate = Date.Now
        'dtpFromDate.MaxDate = Date.Now
        'dtpToDate.MaxDate = Date.Now
        dtpDueDate.Value = Date.Now
        dtpFromDate.Value = Date.Now
        dtpToDate.Value = Date.Now
    End Sub
End Class
