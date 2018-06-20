Imports System.Math

Public Class frmLoanAdditionalCharges
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents cmbFromLedger As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtpRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtChalanNo As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpLastPaidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipleAmount As BankControls.NumericControl
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtReceiptnO As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtReceiptnO = New BankControls.NumericControl
        Me.btnClose = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.cmbFromLedger = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rtpRemarks = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtChalanNo = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtBalance = New BankControls.NumericControl
        Me.txtAmount = New BankControls.NumericControl
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpLastPaidDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPrincipleAmount = New BankControls.NumericControl
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReceiptnO)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.cmbFromLedger)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rtpRemarks)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtChalanNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtReferenceNo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.dtpPayDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpLastPaidDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPrincipleAmount)
        Me.GroupBox1.Controls.Add(Me.dtpDueDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLoanNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtReceiptnO
        '
        Me.txtReceiptnO.AfterDecimal = 0
        Me.txtReceiptnO.BeforeDecimal = 10
        Me.txtReceiptnO.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReceiptnO.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptnO.Location = New System.Drawing.Point(120, 184)
        Me.txtReceiptnO.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptnO.MaxValue = 9999999999999
        Me.txtReceiptnO.MinValue = 0
        Me.txtReceiptnO.Name = "txtReceiptnO"
        Me.txtReceiptnO.Size = New System.Drawing.Size(168, 23)
        Me.txtReceiptnO.TabIndex = 13
        Me.txtReceiptnO.Text = ""
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnClose.Location = New System.Drawing.Point(400, 296)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 40)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "&Close"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnOk.Location = New System.Drawing.Point(312, 296)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 40)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "&Save"
        '
        'cmbFromLedger
        '
        Me.cmbFromLedger.DropDownWidth = 200
        Me.cmbFromLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFromLedger.Location = New System.Drawing.Point(120, 152)
        Me.cmbFromLedger.Name = "cmbFromLedger"
        Me.cmbFromLedger.Size = New System.Drawing.Size(168, 24)
        Me.cmbFromLedger.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(16, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 689
        Me.Label2.Text = "Credit Account"
        '
        'rtpRemarks
        '
        Me.rtpRemarks.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rtpRemarks.Location = New System.Drawing.Point(120, 216)
        Me.rtpRemarks.MaxLength = 100
        Me.rtpRemarks.Name = "rtpRemarks"
        Me.rtpRemarks.Size = New System.Drawing.Size(480, 64)
        Me.rtpRemarks.TabIndex = 15
        Me.rtpRemarks.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(16, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 19)
        Me.Label8.TabIndex = 687
        Me.Label8.Text = "Remarks :"
        '
        'txtChalanNo
        '
        Me.txtChalanNo.AfterDecimal = 0
        Me.txtChalanNo.BeforeDecimal = 10
        Me.txtChalanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtChalanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChalanNo.Location = New System.Drawing.Point(440, 152)
        Me.txtChalanNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChalanNo.MaxLength = 10
        Me.txtChalanNo.MaxValue = 9999999999999
        Me.txtChalanNo.MinValue = 0
        Me.txtChalanNo.Name = "txtChalanNo"
        Me.txtChalanNo.Size = New System.Drawing.Size(160, 23)
        Me.txtChalanNo.TabIndex = 12
        Me.txtChalanNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(320, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 686
        Me.Label4.Text = "Challan No. :"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 10
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(440, 184)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReferenceNo.MaxValue = 9999999999999
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(160, 23)
        Me.txtReferenceNo.TabIndex = 14
        Me.txtReferenceNo.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(320, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 684
        Me.Label9.Text = "Reference No. :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(16, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 19)
        Me.Label16.TabIndex = 685
        Me.Label16.Text = "Receipt No. :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(16, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 19)
        Me.Label21.TabIndex = 679
        Me.Label21.Text = "Balance :"
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 0
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.BeforeDecimal = 10
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalance.Location = New System.Drawing.Point(120, 88)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalance.MaxValue = 9999999999999
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(168, 23)
        Me.txtBalance.TabIndex = 678
        Me.txtBalance.TabStop = False
        Me.txtBalance.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BeforeDecimal = 8
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(120, 120)
        Me.txtAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtAmount.TabIndex = 10
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(16, 128)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(64, 16)
        Me.Label40.TabIndex = 677
        Me.Label40.Text = "Amount :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(384, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(216, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 665
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'dtpPayDate
        '
        Me.dtpPayDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpPayDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPayDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPayDate.Location = New System.Drawing.Point(440, 56)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpPayDate.TabIndex = 1
        Me.dtpPayDate.Value = New Date(2008, 10, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(320, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 676
        Me.Label3.Text = "Date :"
        '
        'dtpLastPaidDate
        '
        Me.dtpLastPaidDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpLastPaidDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpLastPaidDate.Enabled = False
        Me.dtpLastPaidDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpLastPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPaidDate.Location = New System.Drawing.Point(440, 88)
        Me.dtpLastPaidDate.Name = "dtpLastPaidDate"
        Me.dtpLastPaidDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpLastPaidDate.TabIndex = 668
        Me.dtpLastPaidDate.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(320, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.TabIndex = 675
        Me.Label6.Text = "Last Paid Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 673
        Me.Label5.Text = "Sanc Amt :"
        '
        'txtPrincipleAmount
        '
        Me.txtPrincipleAmount.AfterDecimal = 0
        Me.txtPrincipleAmount.BackColor = System.Drawing.Color.White
        Me.txtPrincipleAmount.BeforeDecimal = 10
        Me.txtPrincipleAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPrincipleAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPrincipleAmount.Location = New System.Drawing.Point(120, 56)
        Me.txtPrincipleAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPrincipleAmount.MaxValue = 9999999999999
        Me.txtPrincipleAmount.MinValue = 0
        Me.txtPrincipleAmount.Name = "txtPrincipleAmount"
        Me.txtPrincipleAmount.ReadOnly = True
        Me.txtPrincipleAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtPrincipleAmount.TabIndex = 666
        Me.txtPrincipleAmount.TabStop = False
        Me.txtPrincipleAmount.Text = ""
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDueDate.Enabled = False
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(440, 120)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDueDate.TabIndex = 669
        Me.dtpDueDate.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(320, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 674
        Me.Label7.Text = "Due Date :"
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(120, 24)
        Me.txtLoanNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.Size = New System.Drawing.Size(168, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 664
        Me.txtLoanNo.TabStop = False
        Me.txtLoanNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 672
        Me.Label1.Text = "LoanNo. :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(320, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 19)
        Me.Label17.TabIndex = 671
        Me.Label17.Text = "Name :"
        '
        'frmLoanAdditionalCharges
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(650, 391)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanAdditionalCharges"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Additional Charges"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Golble Variables"

    Dim objLedger As New clsLedger
    Dim objclsRepayment As New clsRePayment
    Dim objclsDisb As New clsDisbursment
    Dim intMaxAmt As Integer
    Dim intSancAmt As Integer
    Dim intcalInterest As Double
    Dim intDueDate As Integer
    Dim intInterestDiff As Integer
    Dim dblROI As Double
    Dim dblPROI As Double
    Dim intPROI As Integer
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
    Dim dblBalance As Double


    Dim dblIntReceivable As Double
    Dim dblCoverAmount As Double

#End Region

#Region "Functions"

    Public Function fnGetData() As Boolean

        If objclsRepayment.fnGetData(txtLoanNo.Text) Then
            txtPrincipleAmount.Text = objclsRepayment.PaymentTable.Rows(0).Item("SancAmount")
            dtpDueDate.Value = Format(objclsRepayment.PaymentTable.Rows(0).Item("DueDate"), "yyyy-MM-dd")
            dtpLastPaidDate.Value = Format(objclsRepayment.PaymentTable.Rows(0).Item("LastPaidDate"), "yyyy-MM-dd")
            txtBalance.Text = objclsRepayment.PaymentTable.Rows(0).Item("Balance")
            dblIntReceivable = objclsRepayment.PaymentTable.Rows(0).Item("IntReceivable")
            dblCoverAmount = objclsRepayment.PaymentTable.Rows(0).Item("IntCOver")
        End If

    End Function
    Public Function fnGetDisb() As Boolean

        If objclsRepayment.fnGetDisb(txtLoanNo.Text) Then
        End If

    End Function

    Public Function fnClearData() As Boolean

        txtAmount.Text = ""
        txtChalanNo.Text = ""
        rtpRemarks.Text = ""
        txtReceiptnO.ResetText()
        txtReferenceNo.ResetText()

        txtReceiptnO.ResetText()

        dblIntReceivable = 0
        intMaxAmt = 0
        intSancAmt = 0
        intcalInterest = 0
        intInterestDiff = 0
        intCalPenel = 0
        intAmount = 0
        intTotalInterest = 0
        intTotalPenal = 0
        lngVoucher = 0
        intNOD = 0
        intNODPenal = 0

        Return True

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

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

        objclsRepayment.fnAddData(lngVoucher, objTrans)

        Dim strNarration As String = "Amount debited to " & txtLoanNo.Text & "  Narration:" & rtpRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtLoanNo.Text, txtReferenceNo.Text, dtpPayDate.Value, Val(txtAmount.Text), "Deposit By " & Val(txtLoanNo.Text), lngSlNo, "Y", objTrans)

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


        'Credit Interest on Loan
        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Amount credited from account " & txtLoanNo.Text, "To", cmbFromLedger.SelectedValue, 0, Val(txtAmount.Text), 2, "Y", objTrans)


        'Loan Account /Debit
        fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpPayDate.Value, "Amount debited to account " & txtLoanNo.Text, "By", intLedgerNo, Val(txtAmount.Text), 0, 3, "Y", objTrans)

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
        objclsRepayment.Others = 0                       'Val(txtOthers.Text)
        objclsRepayment.Debit = Val(txtAmount.Text)      'Val(txtRemainingInt.Text)
        objclsRepayment.IntrestPaid = 0                  'Val(txtIntPaid.Text)
        objclsRepayment.FromDate = Format(datFromDate, "yyyy-MM-dd")
        objclsRepayment.ToDate = Format(datToDate, "yyyy-MM-dd")
        objclsRepayment.Amount = Val(txtAmount.Text)                       '(Val(txtRemainingInt.Text) - Val(txtPrinciple.Text))

        'Interest Receivable
        objclsRepayment.IntReceivable = Val(dblIntReceivable)

        'Interest carryover
        objclsRepayment.IntPreCOver = dblCoverAmount
        dblCoverAmount = Math.Round(intTotalInterest) + Math.Round(intTotalPenal)

        objclsRepayment.IntCOver = dblCoverAmount

        If txtReferenceNo.Text = "" Then
            objclsRepayment.ReferenceNo = 0
        Else
            objclsRepayment.ReferenceNo = txtReferenceNo.Text
        End If

        objclsRepayment.Intrest = 0 'Val(txtInterest.Text)
        objclsRepayment.PenelIntrest = 0 ' Val(txtPenelInterest.Text)

        'If txtPrinciple.Text < 0 Then
        '    MsgBox("Amount cannot be less than 0", MsgBoxStyle.Information)
        '    Return False
        'Else
        objclsRepayment.Credit = 0 'Math.Round(Val(txtAmount.Text))

        'End If

        If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then

            objclsRepayment.InstNo = objclsRepayment.MaxInstNoTable.Rows(0).Item("InstNo") + 1

        End If

        objclsRepayment.LastInstDate = Format(datToDate, "yyyy-MM-dd")

        If fnSetBalace() Then

        End If

        Return True
    End Function

    Public Function fnSetBalace() As Boolean

        '   '   ' *********** fucntion to calculate the balance amount 
        '   '   ' *********** cond to check the weather pervious balance is paid
        If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then
            'If objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") = 0 Then
            '    objclsRepayment.Balance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - objclsRepayment.Credit + objclsRepayment.Debit
            'Else
            objclsRepayment.Balance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") + objclsRepayment.Debit
            'End If
        End If

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

            intcalInterest = 0

        Else

            intInterestDiff = DateDiff(DateInterval.Month, datFromDate, datToDate)
            While intInterestDiff >= intCOunter
                datNextDate = DateAdd(DateInterval.Month, 2, datLoanDate)
                datNextDate = datNextDate.AddDays(-(datNextDate.Day))

                If datNextDate > datToDate Then
                    datNextDate = datToDate
                End If
                intNOD = DateDiff(DateInterval.Day, datLoanDate, datNextDate)
                intcalInterest += Math.Round((((dblBalance + intcalInterest + intCalPenel) * intNOD * (dblROI / 100)) / 365), 2)
                datLoanDate = datNextDate
                intCOunter += 1
            End While
            intNOD = DateDiff(DateInterval.Day, datNextDate, datToDate)

            If intNOD > 0 Then
                intcalInterest += Math.Round((((dblBalance + intcalInterest + intCalPenel) * intNOD * (dblROI / 100)) / 365), 2)
            End If

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

        intcalInterest = 0
        intCalPenel = 0
        intTotalInterest = 0
        intTotalPenal = 0


        '   '   ' ************** Function to calculate penel interest and interest

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
                    datLoanDate = DateAdd(DateInterval.Day, -1, dvDisb.Item(intCount).Item("DisbDate"))
                    datFromDate = dvDisb.Item(intCount).Item("DisbDate")

                    datToDate = DateAdd(DateInterval.Day, -1, dtpPayDate.Value)

                    dblBalance = dvDisb.Item(intCount).Item("Amount")
                    dblTempAmount += dblBalance
                    fncalculate()
                    intTotalInterest += intcalInterest
                    intTotalPenal += intCalPenel
                    intCount += 1
                End While
                dvDisb.RowFilter = "DisbUsability='Y'"
                If dvDisb.Count > 0 Then
                    datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                    datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
                    dblBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - dblTempAmount

                    datToDate = DateAdd(DateInterval.Day, -1, dtpPayDate.Value)

                    fncalculate()
                    intTotalInterest += intcalInterest
                    intTotalPenal += intCalPenel
                End If
            Else
                datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))

                datToDate = DateAdd(DateInterval.Day, -1, dtpPayDate.Value)

                dblBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance")
                fncalculate()
                intTotalInterest += intcalInterest
                intTotalPenal += intCalPenel
            End If

            'txtInterest.Text = Math.Round(intTotalInterest) + dblCoverAmount
            'txtPenelInterest.Text = Math.Round(intTotalPenal)

        End If

        Return True

    End Function

    Public Function fnCheck() As Boolean
        Dim strLoan As String

        If Val(txtAmount.Text) = 0 Then
            MsgBox("Enter amount ", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        ElseIf cmbFromLedger.SelectedIndex = -1 Then
            MsgBox("Select the credit account", MsgBoxStyle.Exclamation)
            cmbFromLedger.Focus()
            Return False
        ElseIf txtChalanNo.Text = "" Then
            MsgBox("Enter challan no", MsgBoxStyle.Exclamation)
            txtChalanNo.Focus()
            Return False
        ElseIf txtReferenceNo.Text = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Exclamation)
            txtReferenceNo.Focus()
            Return False
        ElseIf txtReceiptnO.Text = String.Empty Then
            MsgBox("Enter receipt number", MsgBoxStyle.Exclamation)
            txtReceiptnO.Focus()
            Return False
        ElseIf rtpRemarks.Text = "" Then
            MsgBox("Emter remarks", MsgBoxStyle.Exclamation)
            rtpRemarks.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'Public Function fnCheckAmt() As Boolean

    '    If objclsRepayment.fnGetData(txtLoanNo.Text) = True Then

    '    End If

    'End Function

    Public Function fnCheckReceiptNo() As Boolean

        If objclsRepayment.fnCheckReceiptNo(txtReceiptnO.Text) Then

            MsgBox("Receipt no, alreadyexist", MsgBoxStyle.Information)

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

                MsgBox("The amount is not yet sanctioned", MsgBoxStyle.Information, "Loans Module")
                Return False

            Else
                Return True
            End If
        End If
    End Function

    Public Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean
        Dim dvDisb As DataView
        Dim intCount As Integer = 0


        If objclsRepayment.fnUpdataLoanDate(txtLoanNo.Text, objTrans) Then

            fnGenerateVoucher(objTrans)

            'fnGenerateReceipt()

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

            dtpLastPaidDate.Value = Date.Today

            fnGetStatus()

            Return True
        Else
            Return False

        End If


    End Function

    Public Function fnGetROI() As Boolean

        If objclsRepayment.fnGetROI(txtLoanNo.Text) Then
            dblROI = (objclsRepayment.LoanTypetable.Rows(0).Item("ROI") * 100)
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetPenel() As Boolean

        If objclsRepayment.fnGetPenelInterest(txtLoanNo.Text) Then
            dblPROI = objclsRepayment.PenelInteresttable.Rows(0).Item("PI")
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

    Public Sub sbFromloaddetails()
        Dim objDV As DataView
        If objLedger.fnGetLedgerListExcept Then
            objDV = New DataView(objLedger.LedgerTable, "", "Name", DataViewRowState.OriginalRows)
            cmbFromLedger.DataSource = objDV
            cmbFromLedger.DisplayMember = "Name"
            cmbFromLedger.ValueMember = "LedgerNo"
            cmbFromLedger.SelectedIndex = -1
        End If
    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub FrmRePayement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpPayDate.Value = Date.Now.Date
        txtLoanNo.ReadOnly = True
        sbFromloaddetails()
        fnGetROI()
        fnGetPenel()
        fnGetData()

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction

        If fnCheck() Then

            If fnCheckAmount() Then

                If fnCheckReceiptNo() Then

                    Try
                        objTrans = fnGetTransaction()

                        If fnCalcInterest() Then

                            If fnSetData() Then

                                If fnSaveData(objTrans) Then
                                    objTrans.Commit()
                                    MsgBox("Amount paid sccessfully", MsgBoxStyle.Information, "Re-Payment Module")

                                End If

                                fnClearData()

                                fnGetData()
                            End If

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

    Private Sub cmbFromLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFromLedger.KeyPress
        cmbFromLedger.DroppedDown = True
    End Sub


End Class
