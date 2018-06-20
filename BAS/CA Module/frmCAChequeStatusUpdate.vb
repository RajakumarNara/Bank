Imports System.Math

Public Class frmCAChequeStatusUpdate
    Inherits System.Windows.Forms.Form

#Region "Form Global Functions"

    Dim objCurrentAccount As New clsCurrentAccount
    Public slNo As Double
    Dim ToolTip1 As New ToolTip

    Dim BoolSameBank As Boolean = True

    Dim dblAvalAmount As Double
    Dim dblBookAmount As Double
    Dim dblOverDrawLimit As Double
    Dim datLastPaid As Date
    Dim dblCalIntrest As Double

    Dim strAccountNo As String
    Dim dblCheAvalAmount As Double
    Dim dblCheBookAmount As Double
    Dim dblCheOverDrawLimit As Double
    Dim datCheLastPaid As Date
    Dim dblCheCalIntrest As Double


#End Region

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
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpClearanceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextControl1 As BankControls.TextControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBankCharges As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents btnClear As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As BankControls.TextControl
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDepositdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtClearedAmt As BankControls.NumericControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAChequeStatusUpdate))
        Me.btnSearch = New BankControls.NewButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpClearanceDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextControl1 = New BankControls.TextControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBankCharges = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.btnClear = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.txtBankName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBranchName = New BankControls.TextControl
        Me.txtChequeNo = New BankControls.TextControl
        Me.txtRemarks = New BankControls.TextControl
        Me.txtAccNo = New BankControls.TextControl
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.dtpDepositdate = New System.Windows.Forms.DateTimePicker
        Me.txtClearedAmt = New BankControls.NumericControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Enabled = False
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(272, 10)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 19)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Cheque Amount"
        '
        'dtpClearanceDate
        '
        Me.dtpClearanceDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClearanceDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClearanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClearanceDate.Location = New System.Drawing.Point(128, 138)
        Me.dtpClearanceDate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpClearanceDate.Name = "dtpClearanceDate"
        Me.dtpClearanceDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpClearanceDate.TabIndex = 6
        Me.dtpClearanceDate.Value = New Date(2009, 5, 19, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextControl1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBankCharges)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(304, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 104)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bank Charges"
        Me.GroupBox1.Visible = False
        '
        'TextControl1
        '
        Me.TextControl1.AlphaNumeric = True
        Me.TextControl1.BlankSpace = True
        Me.TextControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl1.Location = New System.Drawing.Point(120, 64)
        Me.TextControl1.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl1.Mandatory = False
        Me.TextControl1.MaxLength = 50
        Me.TextControl1.Name = "TextControl1"
        Me.TextControl1.Size = New System.Drawing.Size(192, 23)
        Me.TextControl1.SpecialChar = True
        Me.TextControl1.TabIndex = 6
        Me.TextControl1.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 19)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Bank Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Bank Charges"
        '
        'txtBankCharges
        '
        Me.txtBankCharges.AfterDecimal = 2
        Me.txtBankCharges.BeforeDecimal = 8
        Me.txtBankCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankCharges.Location = New System.Drawing.Point(120, 32)
        Me.txtBankCharges.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBankCharges.MaxLength = 10
        Me.txtBankCharges.MaxValue = 0
        Me.txtBankCharges.MinValue = 0
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(80, 22)
        Me.txtBankCharges.TabIndex = 5
        Me.txtBankCharges.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Reference No."
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 2
        Me.txtChequeAmount.BeforeDecimal = 8
        Me.txtChequeAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeAmount.Location = New System.Drawing.Point(440, 74)
        Me.txtChequeAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtChequeAmount.MaxLength = 10
        Me.txtChequeAmount.MaxValue = 0
        Me.txtChequeAmount.MinValue = 0
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.ReadOnly = True
        Me.txtChequeAmount.Size = New System.Drawing.Size(80, 23)
        Me.txtChequeAmount.TabIndex = 86
        Me.txtChequeAmount.TabStop = False
        Me.txtChequeAmount.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Clearance date"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 8
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(128, 170)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReferenceNo.MaxLength = 10
        Me.txtReferenceNo.MaxValue = 0
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReferenceNo.TabIndex = 7
        Me.txtReferenceNo.Text = ""
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnClear.Location = New System.Drawing.Point(400, 314)
        Me.btnClear.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 40)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear "
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(504, 314)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = False
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(440, 10)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 35
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.ReadOnly = True
        Me.txtBankName.Size = New System.Drawing.Size(200, 23)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 3
        Me.txtBankName.TabStop = False
        Me.txtBankName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Bank Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Branch Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Cheque Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Cheque No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Account No. "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Deposit Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 19)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Remarks:"
        '
        'txtBranchName
        '
        Me.txtBranchName.AlphaNumeric = False
        Me.txtBranchName.BlankSpace = True
        Me.txtBranchName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBranchName.Location = New System.Drawing.Point(440, 42)
        Me.txtBranchName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBranchName.Mandatory = False
        Me.txtBranchName.MaxLength = 35
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.ReadOnly = True
        Me.txtBranchName.Size = New System.Drawing.Size(200, 23)
        Me.txtBranchName.SpecialChar = True
        Me.txtBranchName.TabIndex = 5
        Me.txtBranchName.TabStop = False
        Me.txtBranchName.Text = ""
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BlankSpace = False
        Me.txtChequeNo.Enabled = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(128, 42)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.ReadOnly = True
        Me.txtChequeNo.Size = New System.Drawing.Size(137, 23)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 4
        Me.txtChequeNo.Text = ""
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(128, 234)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(480, 64)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 9
        Me.txtRemarks.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(128, 10)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.TabStop = False
        Me.txtAccNo.Text = ""
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpChequeDate.Enabled = False
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(128, 74)
        Me.dtpChequeDate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpChequeDate.TabIndex = 91
        Me.dtpChequeDate.TabStop = False
        Me.dtpChequeDate.Value = New Date(2009, 5, 19, 0, 0, 0, 0)
        '
        'dtpDepositdate
        '
        Me.dtpDepositdate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDepositdate.Enabled = False
        Me.dtpDepositdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositdate.Location = New System.Drawing.Point(128, 106)
        Me.dtpDepositdate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpDepositdate.Name = "dtpDepositdate"
        Me.dtpDepositdate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDepositdate.TabIndex = 90
        Me.dtpDepositdate.TabStop = False
        Me.dtpDepositdate.Value = New Date(2009, 5, 19, 0, 0, 0, 0)
        '
        'txtClearedAmt
        '
        Me.txtClearedAmt.AfterDecimal = 0
        Me.txtClearedAmt.BeforeDecimal = 8
        Me.txtClearedAmt.Enabled = False
        Me.txtClearedAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearedAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtClearedAmt.Location = New System.Drawing.Point(128, 202)
        Me.txtClearedAmt.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtClearedAmt.MaxLength = 10
        Me.txtClearedAmt.MaxValue = 0
        Me.txtClearedAmt.MinValue = 0
        Me.txtClearedAmt.Name = "txtClearedAmt"
        Me.txtClearedAmt.Size = New System.Drawing.Size(136, 23)
        Me.txtClearedAmt.TabIndex = 8
        Me.txtClearedAmt.TabStop = False
        Me.txtClearedAmt.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 19)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Cleared Amount"
        '
        'frmCAChequeStatusUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(656, 365)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpClearanceDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtChequeAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReferenceNo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtBankName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.txtChequeNo)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtAccNo)
        Me.Controls.Add(Me.dtpChequeDate)
        Me.Controls.Add(Me.dtpDepositdate)
        Me.Controls.Add(Me.txtClearedAmt)
        Me.Controls.Add(Me.Label11)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAChequeStatusUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CA Cheque Status Update"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Functions"

    Function fnCheck() As Boolean

        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Exclamation)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtChequeAmount.Text) = String.Empty Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Exclamation)
            txtChequeAmount.Focus()
            Return False
        ElseIf Trim(txtReferenceNo.Text) = String.Empty Then
            MsgBox("Please enter reference amount", MsgBoxStyle.Exclamation, "CA Module")
            txtReferenceNo.Focus()
            Return False
        ElseIf Trim(txtClearedAmt.Text) > Trim(txtChequeAmount.Text) + Trim(txtBankCharges.Text) Then
            MsgBox("Amount cannot be greater than amount in cheque", MsgBoxStyle.Exclamation, "CA Module")
            txtClearedAmt.Focus()
            Return False
        ElseIf Trim(txtClearedAmt.Text) < Trim(txtChequeAmount.Text) Then
            MsgBox("Amount cannout be lesser than amount in cheque", MsgBoxStyle.Exclamation, "CA Module")
            txtClearedAmt.Focus()
            Return False
        ElseIf dtpClearanceDate.Value < dtpChequeDate.Value Then
            MsgBox("Check cleareance date and cheque date", MsgBoxStyle.Exclamation, "SB Module")
            dtpClearanceDate.Focus()
            Return False
        Else
            Return True
        End If

    End Function
    Public Function fnClear()

        txtAccNo.Text = String.Empty
        txtBankCharges.Text = String.Empty
        txtBankName.Text = String.Empty
        txtBranchName.Text = String.Empty
        txtChequeAmount.Text = String.Empty
        txtChequeNo.Text = String.Empty
        txtClearedAmt.Text = String.Empty
        txtReferenceNo.Text = String.Empty
        txtRemarks.Text = String.Empty
        Dim BoolSameBank As Boolean = True

    End Function
    Function fnSetData() As Boolean

        objCurrentAccount.CurAccountNo = Trim(txtAccNo.Text)
        objCurrentAccount.BankName = txtBankName.Text
        objCurrentAccount.BranchName = txtBranchName.Text
        objCurrentAccount.ChequeNo = txtChequeNo.Text
        objCurrentAccount.ChequeDate = dtpChequeDate.Value
        objCurrentAccount.ChequeDepositDate = dtpDepositdate.Value
        objCurrentAccount.chequeClearanceDate = dtpClearanceDate.Value
        objCurrentAccount.Accdate = dtpClearanceDate.Value
        If txtBankCharges.Text = "" Then
            objCurrentAccount.BankCharges = "0"
        Else
            objCurrentAccount.BankCharges = txtBankCharges.Text
        End If
        objCurrentAccount.ChequeAmount = txtChequeAmount.Text
        objCurrentAccount.Remarks = txtRemarks.Text
        objCurrentAccount.ChequeClearedAmt = txtClearedAmt.Text
        Return True

    End Function
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpClearanceDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery

        Dim strNarration As String = "Cheque Cleared " & "Cheque Number " & txtChequeNo.Text & " Narration:" & txtRemarks.Text
        objCurrentAccount.fnUpdateStatus(lngVoucherNo, strNarration, objTrans)

        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpClearanceDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtClearedAmt.Text) & "','0','0','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtClearedAmt.Text) & "','" & dblCalIntrest & "','" & Trim(txtReferenceNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        ''voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReferenceNo.Text, dtpClearanceDate.Value, txtClearedAmt.Text, "Cheque cleared by account" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If Val(dblAvalAmount) < 0 Then
            Dim dblTempBalance As Double = Val(dblAvalAmount) + Val(txtClearedAmt.Text)

            If dblTempBalance < 0 Then

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 12, 0, Val(txtClearedAmt.Text), 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 1, Val(txtClearedAmt.Text), 0, 2, "Y", objTrans)
            Else

                If dblTempBalance <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 11, 0, Abs(dblTempBalance), 1, "Y", objTrans)
                End If

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 12, 0, Abs(dblAvalAmount), 2, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 1, Val(txtClearedAmt.Text), 0, 3, "Y", objTrans)
            End If
        Else
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "To", 11, 0, Val(txtClearedAmt.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 1, Val(txtClearedAmt.Text), 0, 2, "Y", objTrans)
        End If

        Return True

    End Function

    Function fnTransaction() As Boolean
        Dim strsql1 = "insert into sbchequeleaftbl(Book_SNo,ChequeNo,Amount,Status,Remarks,Charges) values('0','" & Trim(txtChequeNo.Text) & "','" & Trim(txtChequeAmount.Text) & "','Bounce','" & Trim(txtRemarks.Text) & "','" & txtBankCharges.Text & "')"
        fnExecuteNonQuery(strsql1)
    End Function
    Public Function fnCalcTotal() As Boolean

        txtClearedAmt.Text = Val(txtClearedAmt.Text) - Val(txtBankCharges.Text)

    End Function



#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccNo.Text = objSBAccSearch.strSBAccountNo
            Me.Text = objSBAccSearch.lvSBAccs.SelectedItems(0).SubItems(1).Text
        End If
        objSBAccSearch.Dispose()
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()


        Try
            If fnCheck() Then
                If MsgBox("are you sure you want to clear the cheque", MsgBoxStyle.YesNo + MsgBoxStyle.Question, " CA Module") = MsgBoxResult.Yes Then
                    If fnSetData() Then
                        objCurrentAccount.ChequeStatus = "Cleared"
                        If fnGenerateVoucher(objTrans) Then
                            fnLogEntry(pbUserId, "Cheque cleared by " & txtAccNo.Text & " Amount " & txtChequeAmount.Text, Date.Now, "Cheque cleared", objTrans)
                            objTrans.Commit()
                            MsgBox("Cheque cleared successfully", MsgBoxStyle.Exclamation, "CA Module")
                            fnClear()
                        Else
                            MsgBox("Cheque cannot be cleared, due to internal error", MsgBoxStyle.Exclamation, " CA Module")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()
        End Try
 
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub frmSBChequeStatusUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpClearanceDate.Value = Date.Now
        dtpChequeDate.Value = Date.Now
        dtpDepositdate.Value = Date.Now

        If Trim(txtAccNo.Text <> String.Empty) Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then
                dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                dblBookAmount = objCurrentAccount.CAAccTable.Rows(0).Item("BookBalance")
                dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
                datLastPaid = CDate(objCurrentAccount.CAAccTable.Rows(0).Item("LastPaidDate"))
            End If

            If objCurrentAccount.fnGetChecks(Trim(txtChequeNo.Text)) = True Then
                strAccountNo = objCurrentAccount.CACheckBookBookTable.Rows(0).Item("CAccountNo")
                If objCurrentAccount.fnGetCAccountDetails(strAccountNo) Then
                    dblCheAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                    dblCheBookAmount = objCurrentAccount.CAAccTable.Rows(0).Item("BookBalance")
                    dblCheOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
                    datCheLastPaid = CDate(objCurrentAccount.CAAccTable.Rows(0).Item("LastPaidDate"))
                End If
            Else
                BoolSameBank = False
            End If
        End If

    End Sub

#End Region

End Class
