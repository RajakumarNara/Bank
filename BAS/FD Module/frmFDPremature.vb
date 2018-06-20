Imports System.Math

Public Class frmFDPremature
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
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents btnClear As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoStandard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDayWise As System.Windows.Forms.RadioButton
    Friend WithEvents txtCashPaid As BankControls.NumericControl
    Public WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtPreROI As BankControls.NumericControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtFDLoanAmt As BankControls.NumericControl
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents txtBalanceAmount As BankControls.NumericControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtInterestAmount As BankControls.NumericControl
    Friend WithEvents txtTotalAmount As BankControls.NumericControl
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFDName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFDAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents dtpFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents txtP As System.Windows.Forms.Label
    Friend WithEvents txtPrematureDays As BankControls.NumericControl
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReductionPercentage As BankControls.NumericControl
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSeniorCitizenPercentage As BankControls.NumericControl
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrematureIntAmount As BankControls.NumericControl
    Friend WithEvents chkTransferToSB As System.Windows.Forms.CheckBox
    Friend WithEvents txtSBAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherAmount As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDPremature))
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnClear = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdoStandard = New System.Windows.Forms.RadioButton
        Me.rdoDayWise = New System.Windows.Forms.RadioButton
        Me.txtCashPaid = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtPreROI = New BankControls.NumericControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtFDLoanAmt = New BankControls.NumericControl
        Me.btnCalInterest = New BankControls.NewButton
        Me.txtBalanceAmount = New BankControls.NumericControl
        Me.txtROI = New BankControls.NumericControl
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtInterestAmount = New BankControls.NumericControl
        Me.txtTotalAmount = New BankControls.NumericControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtOtherAmount = New BankControls.NumericControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFDName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFDAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtRefNo = New BankControls.NumericControl
        Me.dtpFDDate = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.txtP = New System.Windows.Forms.Label
        Me.txtPrematureDays = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtReductionPercentage = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSeniorCitizenPercentage = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPrematureIntAmount = New BankControls.NumericControl
        Me.chkTransferToSB = New System.Windows.Forms.CheckBox
        Me.txtSBAccountNo = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.Transparent
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(432, 502)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(112, 40)
        Me.btnWithdraw.TabIndex = 10
        Me.btnWithdraw.Text = "    &Pre close"
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.GotFocusColour = System.Drawing.Color.Transparent
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(8, 502)
        Me.btnClear.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 40)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Reset"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Transparent
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(560, 502)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 48)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Standard"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 18)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Day wise "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(24, 266)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 16)
        Me.Label17.TabIndex = 145
        Me.Label17.Text = "Scheme Type:"
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(150, 263)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(666, 24)
        Me.cmbSchemeType.TabIndex = 144
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoStandard)
        Me.GroupBox3.Controls.Add(Me.rdoDayWise)
        Me.GroupBox3.Location = New System.Drawing.Point(640, 307)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 70)
        Me.GroupBox3.TabIndex = 143
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interest Calculation Type"
        '
        'rdoStandard
        '
        Me.rdoStandard.AutoSize = True
        Me.rdoStandard.Location = New System.Drawing.Point(10, 48)
        Me.rdoStandard.Name = "rdoStandard"
        Me.rdoStandard.Size = New System.Drawing.Size(68, 17)
        Me.rdoStandard.TabIndex = 1
        Me.rdoStandard.Text = "Standard"
        Me.rdoStandard.UseVisualStyleBackColor = True
        '
        'rdoDayWise
        '
        Me.rdoDayWise.AutoSize = True
        Me.rdoDayWise.Checked = True
        Me.rdoDayWise.Location = New System.Drawing.Point(8, 18)
        Me.rdoDayWise.Name = "rdoDayWise"
        Me.rdoDayWise.Size = New System.Drawing.Size(71, 17)
        Me.rdoDayWise.TabIndex = 0
        Me.rdoDayWise.TabStop = True
        Me.rdoDayWise.Text = "Day wise "
        Me.rdoDayWise.UseVisualStyleBackColor = True
        '
        'txtCashPaid
        '
        Me.txtCashPaid.AfterDecimal = 2
        Me.txtCashPaid.BackColor = System.Drawing.Color.White
        Me.txtCashPaid.BeforeDecimal = 7
        Me.txtCashPaid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPaid.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCashPaid.Location = New System.Drawing.Point(445, 294)
        Me.txtCashPaid.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCashPaid.MaxValue = 0
        Me.txtCashPaid.MinValue = 0
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.ReadOnly = True
        Me.txtCashPaid.Size = New System.Drawing.Size(152, 23)
        Me.txtCashPaid.TabIndex = 142
        Me.txtCashPaid.TabStop = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(317, 297)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 17)
        Me.Label18.TabIndex = 141
        Me.Label18.Text = "Cash Paid :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(214, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 22)
        Me.Button2.TabIndex = 140
        Me.Button2.Text = "Premature %"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'txtPreROI
        '
        Me.txtPreROI.AfterDecimal = 2
        Me.txtPreROI.BackColor = System.Drawing.Color.White
        Me.txtPreROI.BeforeDecimal = 8
        Me.txtPreROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreROI.GotFocusColour = System.Drawing.Color.White
        Me.txtPreROI.Location = New System.Drawing.Point(150, 405)
        Me.txtPreROI.LostFocusColour = System.Drawing.Color.White
        Me.txtPreROI.MaxLength = 10
        Me.txtPreROI.MaxValue = 0
        Me.txtPreROI.MinValue = 0
        Me.txtPreROI.Name = "txtPreROI"
        Me.txtPreROI.Size = New System.Drawing.Size(56, 23)
        Me.txtPreROI.TabIndex = 129
        Me.txtPreROI.TabStop = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 404)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 23)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "Premature ROI :"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(22, 462)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 17)
        Me.Label20.TabIndex = 138
        Me.Label20.Text = "Loan Amount :"
        Me.Label20.Visible = False
        '
        'txtFDLoanAmt
        '
        Me.txtFDLoanAmt.AfterDecimal = 2
        Me.txtFDLoanAmt.BackColor = System.Drawing.Color.White
        Me.txtFDLoanAmt.BeforeDecimal = 7
        Me.txtFDLoanAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDLoanAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDLoanAmt.Location = New System.Drawing.Point(148, 462)
        Me.txtFDLoanAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFDLoanAmt.MaxValue = 0
        Me.txtFDLoanAmt.MinValue = 0
        Me.txtFDLoanAmt.Name = "txtFDLoanAmt"
        Me.txtFDLoanAmt.ReadOnly = True
        Me.txtFDLoanAmt.Size = New System.Drawing.Size(152, 23)
        Me.txtFDLoanAmt.TabIndex = 127
        Me.txtFDLoanAmt.TabStop = False
        Me.txtFDLoanAmt.Visible = False
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(575, 324)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(63, 24)
        Me.btnCalInterest.TabIndex = 123
        Me.btnCalInterest.Text = "Int Cal"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.AfterDecimal = 2
        Me.txtBalanceAmount.BackColor = System.Drawing.Color.White
        Me.txtBalanceAmount.BeforeDecimal = 7
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalanceAmount.Location = New System.Drawing.Point(445, 353)
        Me.txtBalanceAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalanceAmount.MaxValue = 0
        Me.txtBalanceAmount.MinValue = 0
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.ReadOnly = True
        Me.txtBalanceAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtBalanceAmount.TabIndex = 122
        Me.txtBalanceAmount.TabStop = False
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.White
        Me.txtROI.Location = New System.Drawing.Point(150, 377)
        Me.txtROI.LostFocusColour = System.Drawing.Color.White
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ReadOnly = True
        Me.txtROI.Size = New System.Drawing.Size(56, 23)
        Me.txtROI.TabIndex = 128
        Me.txtROI.TabStop = False
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpMaturityDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpMaturityDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(150, 433)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(122, 23)
        Me.dtpMaturityDate.TabIndex = 130
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(317, 353)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 17)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "FD Amount :"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 377)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(104, 23)
        Me.Label23.TabIndex = 131
        Me.Label23.Text = "ROI :"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(236, 384)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(229, 17)
        Me.Label25.TabIndex = 133
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(253, 414)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(189, 17)
        Me.Label26.TabIndex = 134
        Me.Label26.Text = "Total Amount now pay:"
        '
        'txtInterestAmount
        '
        Me.txtInterestAmount.AfterDecimal = 2
        Me.txtInterestAmount.BackColor = System.Drawing.Color.White
        Me.txtInterestAmount.BeforeDecimal = 7
        Me.txtInterestAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterestAmount.Location = New System.Drawing.Point(471, 382)
        Me.txtInterestAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInterestAmount.MaxValue = 0
        Me.txtInterestAmount.MinValue = 0
        Me.txtInterestAmount.Name = "txtInterestAmount"
        Me.txtInterestAmount.Size = New System.Drawing.Size(125, 23)
        Me.txtInterestAmount.TabIndex = 124
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AfterDecimal = 2
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BeforeDecimal = 7
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotalAmount.Location = New System.Drawing.Point(445, 412)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotalAmount.MaxValue = 0
        Me.txtTotalAmount.MinValue = 0
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtTotalAmount.TabIndex = 126
        Me.txtTotalAmount.TabStop = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(24, 433)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(113, 23)
        Me.Label27.TabIndex = 135
        Me.Label27.Text = "Maturity Date :"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(608, 398)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(111, 17)
        Me.Label28.TabIndex = 136
        Me.Label28.Text = "Other Amount :"
        Me.Label28.Visible = False
        '
        'txtOtherAmount
        '
        Me.txtOtherAmount.AfterDecimal = 2
        Me.txtOtherAmount.BeforeDecimal = 7
        Me.txtOtherAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherAmount.Location = New System.Drawing.Point(725, 397)
        Me.txtOtherAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherAmount.MaxValue = 0
        Me.txtOtherAmount.MinValue = 0
        Me.txtOtherAmount.Name = "txtOtherAmount"
        Me.txtOtherAmount.Size = New System.Drawing.Size(41, 23)
        Me.txtOtherAmount.TabIndex = 125
        Me.txtOtherAmount.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.cmbDepositType)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.dtpDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(804, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deposit Details"
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 10
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(128, 16)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(168, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(24, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(106, 16)
        Me.Label39.TabIndex = 131
        Me.Label39.Text = "Deposit Type :"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(416, 16)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDate.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(358, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFDName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFDAccNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.dtpFDDate)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Holder Details"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Reference No. :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(408, 64)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(200, 52)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Name :"
        '
        'txtFDName
        '
        Me.txtFDName.AlphaNumeric = False
        Me.txtFDName.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDName.BlankSpace = False
        Me.txtFDName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDName.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDName.Location = New System.Drawing.Point(128, 63)
        Me.txtFDName.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDName.Mandatory = False
        Me.txtFDName.Name = "txtFDName"
        Me.txtFDName.ReadOnly = True
        Me.txtFDName.Size = New System.Drawing.Size(168, 23)
        Me.txtFDName.SpecialChar = False
        Me.txtFDName.TabIndex = 6
        Me.txtFDName.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Account No. :"
        '
        'txtFDAccNo
        '
        Me.txtFDAccNo.AlphaNumeric = True
        Me.txtFDAccNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAccNo.BlankSpace = False
        Me.txtFDAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAccNo.Location = New System.Drawing.Point(128, 32)
        Me.txtFDAccNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAccNo.Mandatory = False
        Me.txtFDAccNo.MaxLength = 10
        Me.txtFDAccNo.Name = "txtFDAccNo"
        Me.txtFDAccNo.ReadOnly = True
        Me.txtFDAccNo.Size = New System.Drawing.Size(136, 23)
        Me.txtFDAccNo.SpecialChar = False
        Me.txtFDAccNo.TabIndex = 4
        Me.txtFDAccNo.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(272, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(128, 95)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(168, 23)
        Me.txtRefNo.TabIndex = 7
        '
        'dtpFDDate
        '
        Me.dtpFDDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDDate.Enabled = False
        Me.dtpFDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(408, 32)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpFDDate.TabIndex = 8
        Me.dtpFDDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(328, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 121
        Me.Label24.Text = "FD Date :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(812, 220)
        Me.TabControl1.TabIndex = 0
        '
        'txtP
        '
        Me.txtP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP.Location = New System.Drawing.Point(24, 295)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(124, 17)
        Me.txtP.TabIndex = 147
        Me.txtP.Text = "Premature Days :"
        '
        'txtPrematureDays
        '
        Me.txtPrematureDays.AfterDecimal = 2
        Me.txtPrematureDays.BackColor = System.Drawing.Color.White
        Me.txtPrematureDays.BeforeDecimal = 7
        Me.txtPrematureDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrematureDays.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPrematureDays.Location = New System.Drawing.Point(150, 293)
        Me.txtPrematureDays.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPrematureDays.MaxValue = 0
        Me.txtPrematureDays.MinValue = 0
        Me.txtPrematureDays.Name = "txtPrematureDays"
        Me.txtPrematureDays.ReadOnly = True
        Me.txtPrematureDays.Size = New System.Drawing.Size(99, 23)
        Me.txtPrematureDays.TabIndex = 146
        Me.txtPrematureDays.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Reduction % :"
        '
        'txtReductionPercentage
        '
        Me.txtReductionPercentage.AfterDecimal = 2
        Me.txtReductionPercentage.BackColor = System.Drawing.Color.White
        Me.txtReductionPercentage.BeforeDecimal = 7
        Me.txtReductionPercentage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReductionPercentage.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReductionPercentage.Location = New System.Drawing.Point(150, 320)
        Me.txtReductionPercentage.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReductionPercentage.MaxValue = 0
        Me.txtReductionPercentage.MinValue = 0
        Me.txtReductionPercentage.Name = "txtReductionPercentage"
        Me.txtReductionPercentage.ReadOnly = True
        Me.txtReductionPercentage.Size = New System.Drawing.Size(56, 23)
        Me.txtReductionPercentage.TabIndex = 148
        Me.txtReductionPercentage.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Senior Citizen % :"
        '
        'txtSeniorCitizenPercentage
        '
        Me.txtSeniorCitizenPercentage.AfterDecimal = 2
        Me.txtSeniorCitizenPercentage.BackColor = System.Drawing.Color.White
        Me.txtSeniorCitizenPercentage.BeforeDecimal = 7
        Me.txtSeniorCitizenPercentage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeniorCitizenPercentage.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSeniorCitizenPercentage.Location = New System.Drawing.Point(150, 350)
        Me.txtSeniorCitizenPercentage.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSeniorCitizenPercentage.MaxValue = 0
        Me.txtSeniorCitizenPercentage.MinValue = 0
        Me.txtSeniorCitizenPercentage.Name = "txtSeniorCitizenPercentage"
        Me.txtSeniorCitizenPercentage.ReadOnly = True
        Me.txtSeniorCitizenPercentage.Size = New System.Drawing.Size(56, 23)
        Me.txtSeniorCitizenPercentage.TabIndex = 150
        Me.txtSeniorCitizenPercentage.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 17)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Premature Interest Amount :"
        '
        'txtPrematureIntAmount
        '
        Me.txtPrematureIntAmount.AfterDecimal = 2
        Me.txtPrematureIntAmount.BackColor = System.Drawing.Color.White
        Me.txtPrematureIntAmount.BeforeDecimal = 7
        Me.txtPrematureIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrematureIntAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPrematureIntAmount.Location = New System.Drawing.Point(445, 324)
        Me.txtPrematureIntAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPrematureIntAmount.MaxValue = 0
        Me.txtPrematureIntAmount.MinValue = 0
        Me.txtPrematureIntAmount.Name = "txtPrematureIntAmount"
        Me.txtPrematureIntAmount.Size = New System.Drawing.Size(125, 23)
        Me.txtPrematureIntAmount.TabIndex = 152
        '
        'chkTransferToSB
        '
        Me.chkTransferToSB.AutoSize = True
        Me.chkTransferToSB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTransferToSB.Location = New System.Drawing.Point(313, 443)
        Me.chkTransferToSB.Name = "chkTransferToSB"
        Me.chkTransferToSB.Size = New System.Drawing.Size(129, 20)
        Me.chkTransferToSB.TabIndex = 154
        Me.chkTransferToSB.Text = "Transfer to SB:"
        Me.chkTransferToSB.UseVisualStyleBackColor = True
        '
        'txtSBAccountNo
        '
        Me.txtSBAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBAccountNo.Location = New System.Drawing.Point(445, 442)
        Me.txtSBAccountNo.Name = "txtSBAccountNo"
        Me.txtSBAccountNo.ReadOnly = True
        Me.txtSBAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtSBAccountNo.TabIndex = 155
        '
        'frmFDPremature
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(828, 550)
        Me.Controls.Add(Me.txtSBAccountNo)
        Me.Controls.Add(Me.chkTransferToSB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrematureIntAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSeniorCitizenPercentage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReductionPercentage)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txtPrematureDays)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbSchemeType)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtCashPaid)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPreROI)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtFDLoanAmt)
        Me.Controls.Add(Me.btnCalInterest)
        Me.Controls.Add(Me.txtBalanceAmount)
        Me.Controls.Add(Me.txtROI)
        Me.Controls.Add(Me.dtpMaturityDate)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtInterestAmount)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtOtherAmount)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFDPremature"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposit Premature"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDPremature
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDPremature
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDPremature
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDPremature)
            m_FormDefInstance = Value
        End Set
    End Property



#End Region

#Region "Variables"
    Dim objFDAccount As New clsFDAccount
    Dim objClsFDAcc As New clsFDAccount
    Dim intDateDiff As Integer
    Dim dblBalance As Double
    Dim strsql As String
    Dim dblROI As Double
    Dim BI As Double
    Dim BI1 As Double
    Dim BI2 As Double
    Dim dblIntDiff As Double
    Dim dtMasterData As DataTable
    Dim TempSubdays As Integer = 0
    Dim TempSubMonth As Integer = 0
    Dim TempTotalDays As Integer = 0
    Dim tempNOM As Integer = 0
    Dim timeTemp As Date
    Dim bolTemp As Boolean = True
    Dim datFDDate As Date
    Dim bolMonth As Boolean = False
    Dim bolCumulative As Boolean
    Dim objDT As DataTable
    Dim SelectScheme As String
    Dim SchemeType As String
    Dim FDAmount As Double = 0
    Dim datFDDateTemp As Date
    Dim IntMode As String
    Dim lngPeriod As Double = 0
    Dim dblTotalInt As Double = 0

    Dim intLedgerNo As Integer
    Dim intLedIntNo As Integer
    Dim intLedPreClose As Integer

    Dim dblProvisionInterest As Double
    Dim dblPaidInterest As Double
    Dim dblDueInterest As Double

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select deposit type", MsgBoxStyle.Exclamation)
            cmbDepositType.Focus()
            Return False
        ElseIf txtFDAccNo.Text = "FD" Or txtFDAccNo.Text = "ENNVY" Or txtFDAccNo.Text = "SCC" Then
            MsgBox("Enter valid account no.", MsgBoxStyle.Information)
            btnSearch.Focus()
            Return False
        ElseIf txtFDName.Text = String.Empty Then
            MsgBox("Please enter the name", MsgBoxStyle.Information)
            txtFDName.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference no. cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
            Return False
        ElseIf txtTotalAmount.Text = String.Empty Then
            MsgBox("Please enter the total amount to deposit", MsgBoxStyle.Information)
            'Me.TabControl1.SelectedTab = Me.TabPage2
            txtTotalAmount.Focus()
            Return False
            'ElseIf Val(txtTotalAmount.Text) < Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text) + Val(txtOtherAmount.Text) Then
            '    MsgBox("You have to Draw Full Amount", MsgBoxStyle.Exclamation, "RD Module")
            '''    Return False

        ElseIf Val(txtTotalAmount.Text) < 0 Then
            MsgBox("Amount cannot be negative", MsgBoxStyle.Exclamation, "Deposit Module")
            'Me.TabControl1.SelectedTab = Me.TabPage2
            txtTotalAmount.Focus()
            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnCheckRefNo() As Boolean

        If objClsFDAcc.fnCheckFDRefNo(txtRefNo.Text) Then
            MsgBox("Reference no. already exist", MsgBoxStyle.Exclamation, "Deposit Modlue")
            txtRefNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnCalcInterest() As Boolean

        If objClsFDAcc.fnGetFDDet(txtFDAccNo.Text) Then
            ' BI = objClsFDAcc.FDDetTable.Rows(0).Item("IntPaid")
            fnProcessFDAccount()
            fnCalPreMaturity()
        End If
    End Function
    'To load SchemeTbl values to the Scheme ComboBox Control
    Sub sbLoadScheme()
        Dim objScheme As New clsFDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.FdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
            cmbSchemeType.SelectedIndex = -1
        End If
        objScheme = Nothing
    End Sub
    Function fnIntCalOfFDAccount()
        If SchemeType <> "Q" Then
            'FnCalIntForOtherThanQterly()
            Return True
        End If
        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim intNOD1 As Integer = 0
        Dim intMonth As Integer = 0
        Dim intNODTemp As Integer = 0
        Dim dblFDAmount As Double
        Dim dblInitialFDAmt As Double
        Dim dblIntAmt As Double = 0
        Dim dblIntAmtBelow As Double = 0
        Dim dblFDCumBeforeAmt As Double = 0
        Dim dblTotalInterestAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim Counter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim intMode As Integer = 0
        Dim iv As ListViewItem
        Dim dblFDAmt As Double = 0
        Dim x, y As Double
        Dim intTempPeriod As Integer
        Dim dblTempPower As Double
        Dim datNextDate As Date
        Dim datPrevDate As Date
        Dim intDivide As Integer
        Dim datMatdate As Date
        Dim intQuater As Integer = 0
        Dim dtTemp As Date
        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True
        '''''''''''
        Dim tempMonth As Integer
        Dim temp As Integer = 0
        timeTemp = dtpFDDate.Value
        Dim tempDayAmount As Double = 0
        Dim dblTemp As Double
        Dim dblTempFDTotal As Double
        Dim dblPrev As Double

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FoQuater = New Integer() {"10", "11", "12"}
        datFDDate = CDate(dtpFDDate.Value)
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpDate.Value)
        datMatdate = CDate(dtpDate.Value)
        Dim PerMonthIntAmt As Double
        Dim PerDayIntAmt As Double
        Dim PerQuerterIntAmt As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        Dim NoOfQurters As Decimal
        Dim OnlyMonth As Integer
        Dim Number As Decimal
        Dim IntegerResult As Integer

        If SelectScheme = "QuerterlyEqualAmount" Then  'Noncumulative for quterly for equal int amount generate 
            intCounter = 1
            Select Case intMode
                Case "M"
                    intIntMode = 1
                Case "Q"
                    intIntMode = 3
                Case "H"
                    intIntMode = 6
                Case "Y"
                    intIntMode = 12
            End Select

            dblFDAmt = CDbl(FDAmount)
            dblROI = Val(txtROI.Text)
            dblIntAmt = Round((dblFDAmt * dblROI) / 100, 2) 'IntAmount without days
            datFDDateTemp = dtpFDDate.Value
            'lvInterest.Items.Clear()
            'If Next querter date is different from the FDDate 
            If dtpDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpDate.Value) - 1
                'datMatdate = dtpMaturityDate.Value
                intNOD = DateDiff("d", datFDDateTemp, dtpDate.Value) - 1
                ' dblIntAmtBelow = dblIntAmt * intNOD
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                'dtpFDDate.Value = dtpDate.Value
                'Counter += 1

                dblFDAmt += (PerDayIntAmt * intNOD)
                dblTotalInt += (PerDayIntAmt * intNOD)
                datFDDate = dtpDate.Value
            End If
            'If NextQuerter date is same as the FDDate 
            'If dtpDate.Value = dtpFDDate.Value Then
            '    datFDDate = CDate(dtpFDDate.Value)
            '    NoOfQurters = intNOM / 3 'per year
            '    PerQuerterIntAmt = Round(dblIntAmt / 4)
            '    PerMonthIntAmt = Round(dblIntAmt / 12) 'per year
            '    IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
            '    'Dim t As Decimal = CDec(Math.Truncate(NoOfQurters)) 'Important method for get only inter part of real number
            '    'per day
            '    'lvInterest.Items.Clear()
            '    intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
            '    'While IntegerResult > intCounter
            '    While (intNOM / intIntMode) > intCounter
            '        datPrevDate = datNextDate
            '        datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
            '        intMonth = datNextDate.Month
            '        If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
            '            If (datNextDate.Day = 30) Then
            '                datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
            '            End If
            '        End If
            '        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
            '        dblFDAmt += Round(PerQuerterIntAmt)
            '        dblTotalInt += Round(PerQuerterIntAmt)
            '        datFDDate = datNextDate
            '        intCounter += 1
            '    End While
            '    OnlyMonth = intNOM Mod 3
            '    intNOD = DateDiff(DateInterval.Day, datFDDate, datMatdate)   'days for remaining months
            '    If intNOD > 0 Then
            '        ' dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
            '        dblInitialFDAmt += dblIntAmt

            '        datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
            '        intCounter += 1
            '        dblFDAmt += (PerDayIntAmt * intNOD)
            '        dblTotalInt += (PerDayIntAmt * intNOD)
            '        datFDDate = dtpDate.Value
            '    End If

            '    'dblTotalInt = dblInitialFDAmt - dblFDAmount
            '    'dblFDAmount = dblInitialFDAmt
            '    'txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
            '    txtInterestAmount.Text = Convert.ToString(Round(dblTotalInt))
            '    'If OnlyMonth > 0 Then
            '    '    iv = lvInterest.Items.Add(intCounter)
            '    '    iv.SubItems.Add(Round(PerMonthIntAmt * OnlyMonth))
            '    '    iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
            '    '    iv.SubItems.Add(Format(Round(PerMonthIntAmt * OnlyMonth) + dblFDAmt, "0.00"))
            '    '    dblFDAmt += Round(PerMonthIntAmt * OnlyMonth)
            '    '    dblTotalInt += Round(PerMonthIntAmt * OnlyMonth)
            '    '    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
            '    '    intCounter += 1
            '    'End If
            '    'txtFDIntAmount.Text = Math.Round(dblTotalInt)
            '    'txtFDIntAmount.Text = (dblTotalInt)
            '    'Else
            '    '    ' Near querter calculation
            '    '    lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
            '    '    datMatdate = dtpFDMatDate.Value
            '    '    intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpNextDate.Value)
            '    '    dblIntAmtBelow = ((dblFDAmt * dblROI) / (365 * 100)) * intNOD

            '    '    'dtpFDDate.Value = dtpNextDate.Value
            '    '    Counter += 1
            '    '    iv = lvInterest.Items.Add(Counter)
            '    '    iv.SubItems.Add(Round(dblIntAmtBelow, 2))
            '    '    iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
            '    '    iv.SubItems.Add(Format(Round(dblIntAmtBelow) + dblFDAmt, "0.00"))
            '    '    datFDDate = dtpNextDate.Value

            'End If

            'dtpFDDate.Value = datFDDateTemp


        ElseIf SelectScheme = "QuerterlyNotEqualAmount" Then '30day and 31 day 

            dblFDAmount = CDbl(FDAmount)
            dblInitialFDAmt = CDbl(FDAmount)
            dblFDAmt = CDbl(FDAmount)
            dblROI = Val(txtROI.Text)
            ' intNOM = Val(txtFDMonths.Text)
            'intNOM += (Val(txtFDYears.Text) * 12)
            intCounter = 1
            If bolCumulative = True Then
                Select Case intMode
                    Case "M"
                        intIntMode = 12
                        intMode = 1
                    Case "Q"
                        intIntMode = 4
                        intMode = 3
                    Case "H"
                        intIntMode = 2
                        intMode = 6
                    Case "Y"
                        intIntMode = 1
                        intMode = 12
                End Select
                '' "Changes for cumulative cd "
                ' dblTempFDTotal = FnCalculateCD(intIntMode)

                datFDDateTemp = dtpFDDate.Value
                If dtpDate.Value = dtpFDDate.Value Then
                    dtpFDDate.Value = dtpDate.Value
                    lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpMaturityDate.Value)
                    datFDDate = dtpFDDate.Value
                Else
                    lngPeriod = DateDiff(DateInterval.Day, dtpDate.Value, dtpMaturityDate.Value)
                    datMatdate = dtpMaturityDate.Value
                    intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpDate.Value)
                    dblIntAmtBelow = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD

                    dtpFDDate.Value = dtpDate.Value
                    Counter += 1
                    datFDDate = dtpDate.Value
                    dblFDAmount += Round(dblIntAmtBelow)

                End If
                dblIntAmtBelow += dblFDAmount
                ''endchanges 
                x = (1 + ((Val(txtROI.Text)) / (intIntMode * 100)))
                intTempPeriod = intMode

                While (intNOM / intMode) > intCounter
                    datPrevDate = datNextDate
                    y = (Val(intTempPeriod) / intMode)
                    dblTempPower = Math.Pow(x, y)
                    dblIntAmt = (dblIntAmtBelow * (dblTempPower)) - dblIntAmtBelow

                    datNextDate = DateAdd(DateInterval.Month, intMode, datFDDate)
                    intMonth = datNextDate.Month
                    If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                        If (datNextDate.Day = 30) Then
                            datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
                        End If
                    End If
                    dblTemp = dblIntAmt - dblPrev


                    dblPrev = dblIntAmt
                    dblFDAmount += Math.Round(dblTemp)
                    'dblFDAmount += (dblTemp)
                    datFDDate = datNextDate
                    dblTotalInt += Math.Round(dblTemp)
                    'dblTotalInt += (dblTemp)
                    intTempPeriod += intMode
                    intCounter += 1
                End While
                intNOD = DateDiff(DateInterval.Day, datPrevDate, datMatdate)
                If datNextDate > dtpMaturityDate.Value Then
                    datNextDate = dtpMaturityDate.Value
                End If

                If intNOD > 0 Then

                End If
                ' txtFDMatAmount.Text = Convert.ToString(dblTempFDTotal)
                'txtInterestAmount.Text = Convert.ToString(dblTempFDTotal - Convert.ToDouble(txtFDAmount.Text))
            Else            'for NON-CUMULATIVE 

                Select Case intMode
                    Case "M"
                        intIntMode = 1
                    Case "Q"
                        intIntMode = 3
                    Case "H"
                        intIntMode = 6
                    Case "Y"
                        intIntMode = 12
                End Select
                '' "Changes"

                datFDDateTemp = dtpFDDate.Value
                If dtpDate.Value = dtpFDDate.Value Then
                    dtpFDDate.Value = dtpDate.Value
                    lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpMaturityDate.Value)
                    datFDDate = dtpFDDate.Value
                Else
                    lngPeriod = DateDiff(DateInterval.Day, dtpDate.Value, dtpMaturityDate.Value)
                    datMatdate = dtpMaturityDate.Value
                    intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpDate.Value)
                    dblIntAmtBelow = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD

                    dtpFDDate.Value = dtpDate.Value
                    Counter += 1
                    datFDDate = dtpDate.Value
                End If

                ''endchanges 
                dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365), 2)
                intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, datMatdate)

                dblInitialFDAmt += dblIntAmtBelow

                intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)


                While (intNOM / intIntMode) > intCounter
                    datPrevDate = datNextDate
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    intMonth = datNextDate.Month
                    If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                        If (datNextDate.Day = 30) Then
                            datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
                        End If
                    End If
                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                    dblInitialFDAmt += dblIntAmt
                    dblTotalInt += dblIntAmt
                    datFDDate = datNextDate

                    intCounter += 1
                End While
                intNOM = intNOM Mod intIntMode    'remaining no of months
                datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate) 'get next date for remaining months
                intNOD = DateDiff(DateInterval.Day, datPrevDate, datMatdate)
                If datNextDate > dtpMaturityDate.Value Then
                    datNextDate = dtpMaturityDate.Value
                End If


                If intNOD > 0 Then
                    dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                    dblInitialFDAmt += dblIntAmt
                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                    intCounter += 1
                End If

                dblTotalInt = dblInitialFDAmt - dblFDAmount
                dblFDAmount = dblInitialFDAmt
                'txtFDMatAmount.Text = Convert.ToString(Round(dblInitialFDAmt))
                txtInterestAmount.Text = Convert.ToString(Round(dblTotalInt))
            End If
            dtpFDDate.Value = datFDDateTemp


        End If

    End Function
    Public Function fnCheckPeriod() As Boolean

        ''' To be written after FD Min Setting Form is done

    End Function

    Public Function fnCalPreMaturity() As Boolean

        BI1 = dblTotalInt
        If BI1 > BI Then
            Label25.Text = "Extra interest amount payable"
            dblIntDiff = BI1 - BI
            txtInterestAmount.Text = Math.Round(dblIntDiff)
            txtBalanceAmount.Text = objClsFDAcc.FDDetTable.Rows(0).Item("FDAmount")
            txtTotalAmount.Text = Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text) '''- Val(txtFDLoanAmt.Text)
        ElseIf BI > BI1 Then
            Label25.Text = "Extra interest amount paid"
            dblIntDiff = BI - BI1
            txtInterestAmount.Text = Math.Round(dblIntDiff)
            txtBalanceAmount.Text = objClsFDAcc.FDDetTable.Rows(0).Item("FDAmount")
            txtTotalAmount.Text = Val(txtBalanceAmount.Text) - Val(txtInterestAmount.Text) ' - Val(txtFDLoanAmt.Text)
        ElseIf BI = BI1 Then
            Label25.Text = "Premature with in 30 days, so not pay any interest"
            dblIntDiff = BI - BI1
            txtInterestAmount.Text = Math.Round(dblIntDiff)
            txtBalanceAmount.Text = objClsFDAcc.FDDetTable.Rows(0).Item("FDAmount")
            txtTotalAmount.Text = Val(txtBalanceAmount.Text) - Val(txtInterestAmount.Text) ' - Val(txtFDLoanAmt.Text)

        End If

    End Function

    Function funCalculateQDays(ByVal MON As Integer)


        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True

        If timeTemp.Month <> MON Then
            While timeTemp.Month <> MON
                timeTemp = timeTemp.AddMonths(1)
                timeTemp = timeTemp.AddDays(-(timeTemp.Day))
                If bolTemp = True Then
                    TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                    TempSubdays += 1
                    bolTemp = False
                End If
                TempSubMonth += 1
                timeTemp = timeTemp.AddMonths(1)
            End While
            timeTemp = timeTemp.AddMonths(1)
            timeTemp = timeTemp.AddDays(-(timeTemp.Day))
            If bolMonth = False Then
                TempTotalDays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                TempTotalDays += 1
                TempTotalDays -= TempSubdays
                tempNOM = 1
            End If
        ElseIf timeTemp.Month = MON Then
            While timeTemp.Month = MON
                timeTemp = timeTemp.AddMonths(1)
                timeTemp = timeTemp.AddDays(-(timeTemp.Day))
                TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                TempSubdays += 1
                tempNOM = 2
                TempSubMonth += 1
                timeTemp = timeTemp.AddMonths(1)
            End While
            timeTemp = timeTemp.AddMonths(-1)
        End If

    End Function

    Function fnGetScheme(ByVal SchemeNo As Integer)

        objClsFDAcc.SchemeCode = SchemeNo
        If objClsFDAcc.fnCheckScheme() Then
            Dim dtMasterData As DataTable = objClsFDAcc.FDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                bolCumulative = True
                objClsFDAcc.FDType = "C"
            Else
                bolCumulative = False
                objClsFDAcc.FDType = "N"
            End If
            bolMonth = IIf(dtMasterData.Rows(0).Item("CalType") = "M", True, False)
        End If
    End Function
#Region "Old FDPremature Calculation"
    Function fnProcessFDAccount()

        dblTotalInt = 0
        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim dblFDAmount As Double
        Dim dblIntAmt As Double = 0
        dblTotalInt = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim intIntMode As Integer = 0
        Dim iv As ListViewItem
        Dim PerDayIntAmt As Double
        Dim PerMonthIntAmt As Double
        Dim datNextDate As Date
        Dim intDivide As Integer
        Dim intQuater As Integer = 0
        Dim PreMatureInt As Double
        Dim FDAmount As Double
        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True
        'Dim PerDayIntAmt As Double
        '''''''''''
        Dim tempMonth As Integer
        Dim temp As Integer = 0
        Dim FDDdate As Date = dtpFDDate.Value
        timeTemp = dtpFDDate.Value
        Dim tempDayAmount As Double = 0
        Dim tempMonthSub As Integer = 0

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FoQuater = New Integer() {"10", "11", "12"}

        Try
            datFDDate = dtpFDDate.Value

            intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpDate.Value)

            dblFDAmount = objDT.Rows(0).Item("FDAmount")
            intCounter = 1
            fnGetScheme(objDT.Rows(0).Item("FDScheme"))
            If rdoDayWise.Checked = True Then
                'FDAmount = Convert.ToDouble()
                'intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpDate.Value)
                PreMatureInt = Convert.ToDouble(txtPreROI.Text)
                dblIntAmt = Round((dblFDAmount * PreMatureInt) / 100)
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                dblTotalInt = Round(PerDayIntAmt * Convert.ToInt32(txtPrematureDays.Text))
                txtPrematureIntAmount.Text = Round(PerDayIntAmt * Convert.ToInt32(txtPrematureDays.Text))
                'txtInterestAmount.Text = Convert.ToString(dblTotalInt)

            ElseIf rdoStandard.Checked = True Then
                'if FD is CUMULATIVE
                If bolCumulative = True Then
                    Select Case objDT.Rows(0).Item("IntMode")
                        Case "M"
                            intIntMode = 1
                        Case "Q"
                            intIntMode = 3
                        Case "H"
                            intIntMode = 6
                        Case "Y"
                            intIntMode = 12

                    End Select

                    If intIntMode = 3 Then
                        If datFDDate.Month >= FQuater(0) And datFDDate.Month <= FQuater(2) Then
                            funCalculateQDays(3)
                        ElseIf datFDDate.Month >= SQuater(0) And datFDDate.Month <= SQuater(2) Then
                            funCalculateQDays(6)
                        ElseIf datFDDate.Month >= TQuater(0) And datFDDate.Month <= TQuater(2) Then
                            funCalculateQDays(9)
                        ElseIf datFDDate.Month >= FoQuater(0) And datFDDate.Month <= FoQuater(2) Then
                            funCalculateQDays(12)
                        End If
                        datNextDate = timeTemp
                        intNOM = intNOM - TempSubMonth
                    ElseIf intIntMode = 6 Then
                        If datFDDate.Month >= FQuater(0) And datFDDate.Month <= SQuater(2) Then
                            funCalculateQDays(6)
                        ElseIf datFDDate.Month >= TQuater(0) And datFDDate.Month <= FoQuater(2) Then
                            funCalculateQDays(12)
                        End If
                        datNextDate = timeTemp
                        intNOM = intNOM - TempSubMonth
                    ElseIf intIntMode = 12 Then
                        funCalculateQDays(12)
                        datNextDate = timeTemp
                        intNOM = intNOM - TempSubMonth
                    Else
                        timeTemp = timeTemp.AddMonths(1)
                        timeTemp = timeTemp.AddDays(-(timeTemp.Day))
                        TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                        TempSubMonth += 1
                        datNextDate = timeTemp
                        tempNOM = 2
                        intNOM = intNOM - TempSubMonth
                    End If

                    If bolMonth = True Then
                        If intIntMode <> 1 Then
                            tempDayAmount = Round((dblFDAmount * TempSubdays * Val(txtROI.Text) - 1) / (100 * 365), 2)
                            If TempSubMonth > 0 Then
                                dblIntAmt = Round((dblFDAmount * TempSubMonth * Val(txtROI.Text)) / (100 * 12), 2)
                            End If
                            dblIntAmt += tempDayAmount
                        Else
                            dblIntAmt = Round((dblFDAmount * TempSubdays * Val(txtROI.Text)) / (100 * 365), 2)
                        End If
                    Else
                        If intIntMode <> 1 Then
                            tempDayAmount = Round((dblFDAmount * TempSubdays * Val(txtROI.Text)) / (100 * 365), 2)
                            If TempSubMonth > 0 Then
                                dblIntAmt = Round((dblFDAmount * TempTotalDays * Val(txtROI.Text)) / (100 * 365), 2)
                            End If
                            dblIntAmt += tempDayAmount
                        Else
                            dblIntAmt = Round((dblFDAmount * TempSubdays * Val(txtROI.Text)) / (100 * 365), 2)
                        End If
                    End If
                    dblTotalInt += dblIntAmt
                    dblFDAmount += dblIntAmt
                    datFDDate = timeTemp

                    While (intNOM / intIntMode) >= intCounter
                        datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                        datNextDate = datNextDate.AddMonths(1)
                        datNextDate = datNextDate.AddDays(-(datNextDate.Day))

                        If datNextDate > dtpDate.Value Then
                            'if nextdate is greater than dtpdate
                            'it is exceeding 
                            datNextDate = dtpDate.Value
                        End If

                        If bolMonth = True Then
                            Dim intNOMonths As Integer = Val(datNextDate)
                            dblIntAmt = Round((dblFDAmount * intIntMode * Val(txtROI.Text)) / (100 * 12), 2)
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                            dblIntAmt = Round((dblFDAmount * intNOD * Val(txtROI.Text)) / (100 * 365), 2)
                        End If
                        dblTotalInt += dblIntAmt
                        dblFDAmount += dblIntAmt
                        datFDDate = datNextDate
                        intCounter += 1
                    End While

                    intNOM = intNOM Mod intIntMode    'remaining no of months
                    If bolMonth Then
                        tempDayAmount = Round((dblFDAmount * intNOM * Val(txtROI.Text)) / (100 * 12), 2)
                        timeTemp = datNextDate
                        timeTemp = timeTemp.AddMonths(1)
                        intNOD = DateDiff(DateInterval.Day, datNextDate, timeTemp) 'days for remaining months
                        intNOD = intNOD - TempSubdays + 1
                        dblIntAmt = Round((dblFDAmount * intNOD * Val(txtROI.Text)) / (100 * 365), 2)
                        dblIntAmt += tempDayAmount
                        dblTotalInt += dblIntAmt

                    Else
                        datNextDate = datFDDate.AddMonths(intNOM + tempNOM)
                        datNextDate = datNextDate.AddDays(-(datNextDate.Day))
                        If datNextDate > dtpDate.Value Then
                            datNextDate = dtpDate.Value
                        End If
                        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate) 'days for remaining months
                        dblIntAmt = Round((dblFDAmount * intNOD * Val(txtROI.Text)) / (100 * 365), 2)
                        dblTotalInt += dblIntAmt

                    End If
                    dblFDAmount += dblIntAmt
                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)

                Else

                    'for NON-CUMULATIVE 
                    Select Case objDT.Rows(0).Item("IntMode")
                        Case "M"
                            intIntMode = 1
                        Case "Q"
                            intIntMode = 3
                        Case "H"
                            intIntMode = 6
                        Case "Y"
                            intIntMode = 12
                    End Select

                    If intIntMode = 3 Then
                        If datFDDate.Month = FQuater(0) Or datFDDate.Month = FQuater(1) Or datFDDate.Month = FQuater(2) Then
                            funCalculateQDays(3)
                        ElseIf datFDDate.Month = SQuater(0) Or datFDDate.Month = SQuater(1) Or datFDDate.Month = SQuater(2) Then
                            funCalculateQDays(6)
                        ElseIf datFDDate.Month = TQuater(0) Or datFDDate.Month = TQuater(1) Or datFDDate.Month = TQuater(2) Then
                            funCalculateQDays(9)
                        ElseIf datFDDate.Month = FoQuater(0) Or datFDDate.Month = FoQuater(1) Or datFDDate.Month = FoQuater(2) Then
                            funCalculateQDays(12)
                        End If
                    ElseIf intIntMode = 6 Then
                        If datFDDate.Month >= FQuater(0) And datFDDate.Month <= SQuater(2) Then
                            funCalculateQDays(6)
                        ElseIf datFDDate.Month >= TQuater(0) And datFDDate.Month <= FoQuater(2) Then
                            funCalculateQDays(12)
                        End If
                    ElseIf intIntMode = 12 Then
                        funCalculateQDays(12)
                        datNextDate = timeTemp
                        intNOM = intNOM - TempSubMonth
                    Else
                        timeTemp = timeTemp.AddMonths(1)
                        timeTemp = timeTemp.AddDays(-(timeTemp.Day))
                        TempSubdays = DateDiff(DateInterval.Day, datFDDate, timeTemp)
                        TempSubMonth += 1
                        tempNOM = 2
                    End If
                    datNextDate = timeTemp
                    intNOM = intNOM - TempSubMonth
                    If bolMonth = True Then
                        If intIntMode = 3 Then
                            tempDayAmount = Round((dblFDAmount * TempSubdays * Val(txtROI.Text)) / (100 * 365), 2)
                            If TempSubMonth - 1 > 0 Then
                                dblIntAmt = Round((dblFDAmount * TempSubMonth * Val(txtROI.Text)) / (100 * 12), 2)
                            End If
                            dblIntAmt += tempDayAmount
                        Else
                            dblIntAmt = Round((dblFDAmount * TempSubdays * Val(txtROI.Text)) / (100 * 365), 2)
                        End If
                    Else
                        If intIntMode = 3 Then
                            tempDayAmount = Round((dblFDAmount * TempSubdays * Val(txtROI.Text)) / (100 * 365), 2)
                            If TempSubMonth > 0 Then
                                dblIntAmt = Round((dblFDAmount * TempTotalDays * Val(txtROI.Text)) / (100 * 365), 2)
                            End If
                            dblIntAmt += tempDayAmount
                        Else
                            PerMonthIntAmt = Round((dblFDAmount * Val(txtROI.Text)) / (1200 + Val(txtROI.Text)), 2)
                            PerDayIntAmt = Round(PerMonthIntAmt / 30, 2)
                            dblIntAmt = Round(PerDayIntAmt * TempSubdays, 2)
                        End If
                    End If
                    dblTotalInt += dblIntAmt
                    While (intNOM / intIntMode) >= intCounter
                        ' datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                        datNextDate = DateAdd(DateInterval.Month, intIntMode, datNextDate)
                        datNextDate = datNextDate.AddMonths(1)
                        datNextDate = datNextDate.AddDays(-(datNextDate.Day))

                        If datNextDate > dtpDate.Value Then
                            datNextDate = dtpDate.Value
                        End If

                        If bolMonth = True Then
                            Dim intNOMonths As Integer = Val(datNextDate)
                            dblIntAmt = Round((dblFDAmount * intIntMode * Val(txtROI.Text)) / (100 * 12), 2)
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                            dblIntAmt = Round((PerDayIntAmt * intNOD), 2)
                        End If
                        dblTotalInt += dblIntAmt
                        intCounter += 1
                    End While
                    intNOM = intNOM Mod intIntMode    'remaining no of months
                    If bolMonth Then
                        tempDayAmount = Round((dblFDAmount * intNOM * Val(txtROI.Text)) / (100 * 12), 2)
                        timeTemp = datNextDate
                        timeTemp = timeTemp.AddMonths(1)
                        intNOD = DateDiff(DateInterval.Day, datNextDate, timeTemp) 'days for remaining months
                        intNOD = intNOD - TempSubdays + 1
                        dblIntAmt = Round((dblFDAmount * intNOD * Val(txtROI.Text)) / (100 * 365), 2)
                        dblIntAmt += tempDayAmount
                        dblTotalInt += dblIntAmt
                    Else
                        datNextDate = datFDDate.AddMonths(intNOM + tempNOM)
                        datNextDate = datNextDate.AddDays(-(datNextDate.Day))
                        If datNextDate > dtpDate.Value Then
                            datNextDate = dtpDate.Value
                        End If
                        intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate) 'days for remaining months

                        dblIntAmt = Round((dblFDAmount * intNOD * Val(txtROI.Text)) / (100 * 365), 2)
                        dblTotalInt += dblIntAmt
                    End If
                End If
            Else
                MsgBox("Please select any one type of interest calculation", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function
#End Region


    Public Function fnClear()

        txtBalanceAmount.Text = ""
        txtFDName.Text = ""
        txtInterestAmount.Text = ""
        txtNarration.Text = ""
        txtOtherAmount.Text = ""
        txtRefNo.Text = ""
        txtROI.Text = ""
        txtTotalAmount.Text = ""
        txtFDAccNo.Text = ""
        cmbDepositType.SelectedIndex = -1
        txtROI.Text = ""

    End Function

    Public Function fnLoanDet() As Boolean

        If Trim(txtFDAccNo.Text) <> "FD" Or txtFDAccNo.Text <> "ENNVY" Or txtFDAccNo.Text <> "SCC" Then
            If objClsFDAcc.fnGetLoanDet(txtFDAccNo.Text) Then
                txtFDLoanAmt.Text = objClsFDAcc.FDLoanDet.Rows(0).Item("Balance")
            Else
                txtFDLoanAmt.Text = 0
            End If
        End If

    End Function

    Public Function fnLoadIntetest() As Boolean
        dblProvisionInterest = 0
        dblDueInterest = 0
        dblPaidInterest = 0

        If objClsFDAcc.fnCheckFDScheme(txtFDAccNo.Text) Then
            Dim dtMasterData As DataTable = objClsFDAcc.FDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                'bolCumulative = True
                'objFDAccount.FDType = "C"
                If objClsFDAcc.fnGetInterestDet(txtFDAccNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objClsFDAcc.dtIntPost.Rows.Count
                        Select Case objClsFDAcc.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objClsFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Provision"
                                dblProvisionInterest = objClsFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Paid"
                                dblPaidInterest = objClsFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                        End Select
                        intCount += 1
                    End While
                End If
            Else
                'objFDAccount.FDType = "N"
                If objClsFDAcc.fnGetNonInterestDet(txtFDAccNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objClsFDAcc.dtIntPost.Rows.Count
                        Select Case objClsFDAcc.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objClsFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Provision"
                                dblProvisionInterest = objClsFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Paid"
                                dblPaidInterest = objClsFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                        End Select
                        intCount += 1
                    End While
                End If
            End If
        End If

    End Function

    Public Function fnSetData() As Boolean

        objClsFDAcc.FDNo = txtFDAccNo.Text
        objClsFDAcc.ReceiptNo = txtRefNo.Text
        objClsFDAcc.IntPaid = BI
        objClsFDAcc.FDIntPayable = BI1
        objClsFDAcc.FdIntDiff = dblIntDiff
        objClsFDAcc.FDROI = txtROI.Text
        objClsFDAcc.FDDate = Format(dtpDate.Value, "yyyy-MM-dd")
        objClsFDAcc.FDAmtPaid = txtTotalAmount.Text
        objClsFDAcc.Remarks = txtNarration.Text

        Select Case cmbDepositType.SelectedItem
            Case "FD"
                intLedgerNo = 27
                intLedIntNo = 30
                intLedPreClose = 47
            Case "ENNVY"
                intLedgerNo = 53
                intLedIntNo = 55
                intLedPreClose = 57
            Case "SCC"
                intLedgerNo = 54
                intLedIntNo = 56
                intLedPreClose = 58
        End Select

        Return True

    End Function

    'Function fnGenerateVoucher() As Boolean

    '    Dim lngVoucherNo As Long
    '    Dim lngSlNo As Long

    '    lngVoucherNo = fnVoucherGetNewVNo(dtpDate.Value)
    '    lngSlNo = fnVoucherGetNewSlNo()

    '    objClsFDAcc.fnPreMatureAcc(lngVoucherNo)
    '    objClsFDAcc.fnUpdateStatus(txtFDAccNo.Text)

    '    fnLogEntry(pbUserId, "Premature By Account No " & txtFDAccNo.Text & " Amount " & txtTotalAmount.Text, Date.Now, "Transaction Premature")

    '    'voucher details
    '    fnVoucherEnterMain(lngVoucherNo, 2, txtFDAccNo.Text, txtRefNo.Text, dtpDate.Value, txtTotalAmount.Text, "By Premature of Account No" & txtFDAccNo.Text, lngSlNo, "Y")

    '    'Credit accounts - Cash account
    '    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "WithDraw Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 1, "Y")

    '    If BI > BI1 Then
    '        'Credit Account- Premature
    '        fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", intLedPreClose, 0, Val(txtInterestAmount.Text), 2, "Y")
    '    Else
    '        'Debit accounts -Interest
    '        fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Interest By Account No" & txtFDAccNo.Text, "To", intLedIntNo, Val(txtInterestAmount.Text), 0, 2, "Y")
    '    End If

    '    If txtOtherAmount.Text <> "" Or Val(txtOtherAmount.Text) <> 0 Then
    '        fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Misc Charges Paid By " & txtFDAccNo.Text, "To", 13, 0, Val(txtOtherAmount.Text), 4, "Y")
    '    End If

    '    'Debit accounts - Fixed Deposit account
    '    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "By Account No " & txtFDAccNo.Text, "By", intLedgerNo, Val(txtBalanceAmount.Text), 0, 3, "Y")

    '    Return True

    'End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim dblInterestProvision As Double = 0
        Dim intCounter As Integer = 0
        lngVoucherNo = fnVoucherGetNewVNo(dtpDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        objClsFDAcc.fnPreMatureAcc(lngVoucherNo, objTrans)
        objClsFDAcc.fnUpdateStatus(txtFDAccNo.Text, objTrans)
        objClsFDAcc.fnGetFDDetails(txtFDAccNo.Text)
        BI = Convert.ToDouble(txtCashPaid.Text) 'Here BI means already cash paid to the customer 
        BI1 = Convert.ToDouble(txtPrematureIntAmount.Text) ' BI1 means now we pay the cash to the customer 
        While intCounter < Convert.ToInt32(objClsFDAcc.InterestTable.Rows.Count)
            If objClsFDAcc.InterestTable.Rows(intCounter).Item("Status") = "Provision" Then
                dblInterestProvision += objClsFDAcc.InterestTable.Rows(intCounter).Item("IntAmount")  'Total provision amount
            End If
            intCounter = intCounter + 1
        End While

        fnLogEntry(pbUserId, "Premature by account " & txtFDAccNo.Text & " Amount " & txtTotalAmount.Text, Date.Now, "Transaction Premature", objTrans)
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtFDAccNo.Text, txtRefNo.Text, dtpDate.Value, txtBalanceAmount.Text, "By premature of account " & txtFDAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts - Cash account
        'fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "WithDraw account  " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 1, "Y", objTrans)
        'If dblProvisionInterest <> 0 Then
        '    'Debit accounts -Interest Payable
        '    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "IntProvision by account " & txtFDAccNo.Text, "To", 14, Val(dblProvisionInterest), 0, 2, "Y", objTrans)
        'End If
        'If Convert.ToDouble(txtTotalAmount.Text) > 20000 And txtSBAccountNo.Text = "" Then
        '    MsgBox("Amount is greater then 20000 so can not be transfer to Cash Account. Please select SB Account", MsgBoxStyle.Exclamation, "Premature module")
        'Else
        If dblInterestProvision = 0 Then     'Total provision amount
            If BI > BI1 Then
                ''Credit Account- Premature
                If txtSBAccountNo.Text <> "" Then
                    Dim strNarration As String = txtNarration.Text
                    strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtSBAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtTotalAmount.Text) & "','0','" & Trim(txtTotalAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtTotalAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    fnVoucherEnterSub(lngVoucherNo, 2, txtSBAccountNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 10, 0, Val(txtTotalAmount.Text), 2, "Y")
                Else
                    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 2, "Y")

                End If
                'Credit Account- Premature
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "To", intLedIntNo, 0, Val(txtInterestAmount.Text), 3, "Y", objTrans)
            ElseIf BI < BI1 Then
                ''Credit Account- Premature
                If txtSBAccountNo.Text <> "" Then
                    Dim strNarration As String = txtNarration.Text
                    strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtSBAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtTotalAmount.Text) & "','0','" & Trim(txtTotalAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtTotalAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    fnVoucherEnterSub(lngVoucherNo, 2, txtSBAccountNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 10, 0, Val(txtTotalAmount.Text), 2, "Y")
                Else
                    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 2, "Y")

                End If
                'Credit Account- Premature
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "By", intLedIntNo, Val(txtInterestAmount.Text), 0, 3, "Y", objTrans)

                ''If Val(txtInterestAmount.Text) > dblProvisionInterest Then
                ''    'Debit accounts -Interest
                ''    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Interest by account " & txtFDAccNo.Text, "To", intLedIntNo, Val(txtInterestAmount.Text) - Val(dblProvisionInterest), 0, 3, "Y", objTrans)
                ''Else
                ''    'Credit Account- Premature
                ''    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "To", intLedIntNo, 0, Val(dblProvisionInterest) - Val(txtInterestAmount.Text), 3, "Y", objTrans)
                ''End If
            ElseIf BI = BI1 Then
                ''Credit Account- Premature
                If txtSBAccountNo.Text <> "" Then
                    Dim strNarration As String = txtNarration.Text
                    strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtSBAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtTotalAmount.Text) & "','0','" & Trim(txtTotalAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtTotalAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    fnVoucherEnterSub(lngVoucherNo, 2, txtSBAccountNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 10, 0, Val(txtTotalAmount.Text), 2, "Y")
                Else
                    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 2, "Y")

                End If
            End If
        Else
            If BI1 > dblInterestProvision Then  ' 'BI1' represent total preclosure interest amount and 'dblInterstProvision' represent amount to be provision
                ''Credit Account- Premature
                If txtSBAccountNo.Text <> "" Then
                    Dim strNarration As String = txtNarration.Text
                    strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtSBAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtTotalAmount.Text) & "','0','" & Trim(txtTotalAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtTotalAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    fnVoucherEnterSub(lngVoucherNo, 2, txtSBAccountNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 10, 0, Val(txtTotalAmount.Text), 2, "Y")
                Else
                    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 2, "Y")

                End If
                'Credit Account- Premature
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "By", intLedIntNo, Val(txtPrematureIntAmount.Text) - dblInterestProvision, 0, 3, "Y", objTrans)
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "To", 14, dblInterestProvision, 0, 3, "Y", objTrans)

            ElseIf BI1 < dblInterestProvision Then
                ''Credit Account- Premature
                If txtSBAccountNo.Text <> "" Then
                    Dim strNarration As String = txtNarration.Text
                    strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtSBAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtTotalAmount.Text) & "','0','" & Trim(txtTotalAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtTotalAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    fnVoucherEnterSub(lngVoucherNo, 2, txtSBAccountNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 10, 0, Val(txtTotalAmount.Text), 2, "Y")
                Else
                    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 2, "Y")

                End If
                'Credit Account- Premature
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "To", intLedIntNo, 0, dblInterestProvision - Val(txtPrematureIntAmount.Text), 3, "Y", objTrans)
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "By", 14, dblInterestProvision, 0, 3, "Y", objTrans)

                ''If Val(txtInterestAmount.Text) > dblProvisionInterest Then
                ''    'Debit accounts -Interest
                ''    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Interest by account " & txtFDAccNo.Text, "To", intLedIntNo, Val(txtInterestAmount.Text) - Val(dblProvisionInterest), 0, 3, "Y", objTrans)
                ''Else
                ''    'Credit Account- Premature
                ''    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "To", intLedIntNo, 0, Val(dblProvisionInterest) - Val(txtInterestAmount.Text), 3, "Y", objTrans)
                ''End If
            ElseIf BI1 = dblInterestProvision Then
                ''Credit Account- Premature
                If txtSBAccountNo.Text <> "" Then
                    Dim strNarration As String = txtNarration.Text
                    strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtSBAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtTotalAmount.Text) & "','0','" & Trim(txtTotalAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtTotalAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    fnVoucherEnterSub(lngVoucherNo, 2, txtSBAccountNo.Text, dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 10, 0, Val(txtTotalAmount.Text), 2, "Y")
                Else
                    fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Premature Interest on Account No " & txtFDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 2, "Y")
                End If
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Premature interest on account " & txtFDAccNo.Text, "By", 14, dblInterestProvision, 0, 3, "Y", objTrans)

            End If

        End If
        'Debit accounts - Fixed Deposit account
        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "By account " & txtFDAccNo.Text, "By", intLedgerNo, Val(txtBalanceAmount.Text), 0, 4, "Y", objTrans)

        'If txtOtherAmount.Text <> "" Or Val(txtOtherAmount.Text) <> 0 Then
        '    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccNo.Text, dtpDate.Value, "Misc charges paid by " & txtFDAccNo.Text, "To", 13, 0, Val(txtOtherAmount.Text), 5, "Y", objTrans)
        'End If
        '' End If
        Return True

    End Function

#End Region

#Region "Procedures"

    Sub sbLoadFD()
        Dim lngPeriod As Double = 0
        If Trim(txtFDAccNo.Text) <> "FD" Or txtFDAccNo.Text <> "ENNVY" Or txtFDAccNo.Text <> "SCC" Then
            If objClsFDAcc.fnGetFDRenewalDet(txtFDAccNo.Text) Then
                objDT = objClsFDAcc.FDDetailstbl
                txtBalanceAmount.Text = objDT.Rows(0).Item("FDAmount")
                objClsFDAcc.SchemeCode = objDT.Rows(0).Item("FDscheme")
                txtROI.Text = objDT.Rows(0).Item("FDRoi").ToString()
                dtpFDDate.Value = Format(objDT.Rows(0).Item("FDDate"), "yyyy-MM-dd")
                lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpDate.Value)
                objClsFDAcc.SchemeCode = objDT.Rows(0).Item("FDScheme")
                If objClsFDAcc.fnGetROI(lngPeriod) Then
                    txtROI.Text = Format(objClsFDAcc.FdMasterTbl.Rows(0).Item(0), "00.00") - 1
                End If
                txtFDName.Text = objDT.Rows(0).Item("Name")
                txtFDName.Enabled = False
                txtFDAccNo.Enabled = False
                dtpMaturityDate.Enabled = False
                txtBalanceAmount.Enabled = False
                dtpMaturityDate.Value = Format(objDT.Rows(0).Item("MatDate"), "yyyy-MM-dd")
            End If
        End If

    End Sub

#End Region

#Region "Events"

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        If txtFDAccNo.Text = String.Empty Or txtFDAccNo.Text = "FD" Or txtFDAccNo.Text = "ENNVY" Or txtFDAccNo.Text = "SCC" Then
            MsgBox("Enter valid account no.", MsgBoxStyle.Information)
            btnSearch.Focus()
        ElseIf txtROI.Text <> String.Empty Then
            fnCalcInterest()
        Else
            MsgBox("Enter Rate of interest", MsgBoxStyle.Information)
            txtROI.Focus()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strForm = "FDDoubleThriableLakshadipathi"
            objFDSearch.strFDNo = ""
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccNo.Text = objFDSearch.strFDNo
                sbLoadFD()
                fnLoanDet()
                fnLoadIntetest()
                txtFDAccNo.Focus()
                txtFDName.Focus()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select The deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnGenerateVoucher(objTrans) Then
                        objTrans.Commit()
                        MsgBox("FD account is premature closed", MsgBoxStyle.Information, "Deposit Module")
                    Else
                        MsgBox("FD account cannot be premature closed,due to internal error", MsgBoxStyle.Exclamation, "Deposit Module")
                    End If
                    fnClear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try



    End Sub

    Private Sub frmFDPremature_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'txtInterestAmount.ReadOnly = True
        'txtBalanceAmount.ReadOnly = True
        'txtTotalAmount.ReadOnly = True
        'txtFDLoanAmt.ReadOnly = True
        sbLoadScheme()
        cmbDepositType.SelectedIndex = -1
        dtpDate.MaxDate = Date.Now
        dtpDate.Value = Date.Now


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        fnClear()

    End Sub

#End Region


    Private Sub txtOtherAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        ' txtTotalAmount.Text = Val(txtBalanceAmount.Text) - Val(txtInterestAmount.Text) - Val(txtFDLoanAmt.Text) - Val(txtOtherAmount.Text)

        If BI1 > BI Then
            dblIntDiff = BI1 - BI
            ' txtInterestAmount.Text = Math.Round(dblIntDiff)
            ' txtBalanceAmount.Text = objClsFDAcc.FDDetTable.Rows(0).Item("FDAmount")
            txtTotalAmount.Text = Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text) - Val(txtFDLoanAmt.Text) - Val(txtOtherAmount.Text)
        Else
            dblIntDiff = BI - BI1
            ' txtInterestAmount.Text = Math.Round(dblIntDiff)
            ' txtBalanceAmount.Text = objClsFDAcc.FDDetTable.Rows(0).Item("FDAmount")
            txtTotalAmount.Text = Val(txtBalanceAmount.Text) - Val(txtInterestAmount.Text) - Val(txtFDLoanAmt.Text) - Val(txtOtherAmount.Text)
        End If


    End Sub

    Private Sub txtNarration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarration.KeyDown
        If e.KeyData = Keys.Enter Then
            TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        Select Case cmbDepositType.SelectedItem

            Case "FD"
                txtFDAccNo.Text = "FD"

            Case "ENNVY"
                txtFDAccNo.Text = "ENNVY"

            Case "SCC"
                txtFDAccNo.Text = "SCC"

        End Select
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Below code for Calculation of rate of interest for preClosure
        txtROI.ResetText()
        Dim lngPeriod As Double = 0
        Dim dblROI As Double = 0
        Dim SchemeCode As Integer

        Dim dtFDDetails As DataTable
        Dim ReductionInt As Double
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpDate.Value)
        If txtFDAccNo.Text <> String.Empty Then
            If objFDAccount.fnGetSchemeCode(txtFDAccNo.Text) Then
                SchemeCode = objFDAccount.FDSchemeTbl.Rows(0).Item(0)
                IntMode = objFDAccount.FDSchemeTbl.Rows(0).Item(1)
                FDAmount = objFDAccount.FDSchemeTbl.Rows(0).Item(2)
            End If
        End If
        objFDAccount.SchemeCode = SchemeCode
        If objFDAccount.fnCheckScheme() Then
            ReductionInt = objFDAccount.FDMasterDetailTbl.Rows(0).Item(6)
            SchemeType = objFDAccount.FDSchemeTbl.Rows(0).Item(2)
        End If
        If objFDAccount.fnGetPaidInt(txtFDAccNo.Text) Then
            BI = Convert.ToDouble(objFDAccount.PaidIntTable.Rows(0).Item(0))
            If Convert.ToString(objFDAccount.PaidIntTable.Rows(0).Item(0)) = "" Then
                txtCashPaid.Text = "0"
            Else
                txtCashPaid.Text = Convert.ToString(objFDAccount.PaidIntTable.Rows(0).Item(0))
            End If
        End If
        If objFDAccount.fnGetPrematureROI(lngPeriod, SchemeCode) Then
            'If rdbSYes.Checked = True Then
            '    dblROI = objFDAccount.FdMasterTbl.Rows(0).Item(0) + dtMasterData.Rows(0).Item("SCROI")
            'ElseIf rdbSNo.Checked = True Then
            dblROI = objFDAccount.PrematureROITbl.Rows(0).Item(0) - ReductionInt
            ' End If
        End If
        txtROI.Text = Format(dblROI, "00.00")
    End Sub

    Private Sub txtFDAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDAccNo.TextChanged
        txtROI.ResetText()
        txtInterestAmount.ResetText()
        txtBalanceAmount.ResetText()
        txtTotalAmount.ResetText()
    End Sub
    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged, dtpFDDate.ValueChanged
        txtPrematureDays.Text = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpDate.Value)
        If txtFDAccNo.Text <> "" Then
            If objFDAccount.fnGetPaidInt(txtFDAccNo.Text) Then
                BI = Convert.ToDouble(objFDAccount.PaidIntTable.Rows(0).Item("paidAmount"))
                txtCashPaid.Text = Convert.ToString(objFDAccount.PaidIntTable.Rows(0).Item("paidAmount"))
            Else
                BI = 0
                txtCashPaid.Text = "0"

            End If
        End If
    End Sub

    Private Sub cmbSchemeType_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSchemeType.LostFocus
        objFDAccount.SchemeCode = Convert.ToInt32(cmbSchemeType.SelectedValue)
        Dim SeniorCitizenROI As Double
        Dim intPreROI As Double
        If objFDAccount.fnCheckScheme() Then
            dtMasterData = objFDAccount.FDMasterDetailTbl
            If Convert.ToString(dtMasterData.Rows(0).Item("ReductionInt")) <> "" Then
                txtReductionPercentage.Text = Convert.ToString(dtMasterData.Rows(0).Item("ReductionInt"))
                SeniorCitizenROI = Convert.ToDouble(dtMasterData.Rows(0).Item("SCROI"))
                txtSeniorCitizenPercentage.Text = SeniorCitizenROI
            End If
        End If
        If objFDAccount.fnGetROI(txtPrematureDays.Text) Then
            If SeniorCitizenROI <> 0 Then
                'If SeniorCitizenROI + Convert.ToInt32(objFDAccount.FdMasterTbl.Rows(0).Item(0)) - Convert.ToInt32(txtReductionPercentage.Text) = "" Then
                '    txtPreROI.Text = "0"
                'Else
                txtPreROI.Text = SeniorCitizenROI + Convert.ToDecimal(objFDAccount.FdMasterTbl.Rows(0).Item(0)) - Convert.ToDecimal(txtReductionPercentage.Text)
                ' End If
            Else
                'If Convert.ToInt32(objFDAccount.FdMasterTbl.Rows(0).Item(0)) - Convert.ToInt32(txtReductionPercentage.Text) = "" Then
                '    txtPreROI.Text = "0"
                'Else
                txtPreROI.Text = Convert.ToDecimal(objFDAccount.FdMasterTbl.Rows(0).Item(0)) - Convert.ToDecimal(txtReductionPercentage.Text)
                '' End
            End If
        Else
            txtPreROI.Text = "0"
        End If
    End Sub

    Private Sub chkTransferToSB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransferToSB.CheckedChanged
        If chkTransferToSB.Checked = True Then
            If objFDAccount.fnGetSBAccount(txtFDAccNo.Text) Then
                txtSBAccountNo.Text = objFDAccount.SBdetailsTable.Rows(0).Item("AccountNo").ToString()
            End If
        End If
    End Sub
End Class

