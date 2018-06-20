Public Class frmSBChequeStatusUpdate
    Inherits System.Windows.Forms.Form

#Region "Form Global Functions"

    Dim objSavingsBank As New clsSavingsBank
    Public slNo As Double
    Dim dblAvailAmount As Double

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents dtpDepositdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtBranchName As BankControls.TextControl
    Friend WithEvents btnClear As BankControls.NewButton
    Friend WithEvents txtClearedAmt As BankControls.NumericControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBankCharges As BankControls.NumericControl
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextControl1 As BankControls.TextControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpClearanceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBChequeStatusUpdate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBankName = New BankControls.TextControl
        Me.txtBranchName = New BankControls.TextControl
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.txtChequeNo = New BankControls.TextControl
        Me.dtpDepositdate = New System.Windows.Forms.DateTimePicker
        Me.txtRemarks = New BankControls.TextControl
        Me.txtAccNo = New BankControls.TextControl
        Me.btnClear = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.txtClearedAmt = New BankControls.NumericControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBankCharges = New BankControls.NumericControl
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextControl1 = New BankControls.TextControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpClearanceDate = New System.Windows.Forms.DateTimePicker
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnSearch = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Bank Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Branch Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Cheque Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Cheque No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Account No. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Deposit Date :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Remarks :"
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Enabled = False
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(432, 16)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 50
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(200, 23)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 43
        Me.txtBankName.TabStop = False
        Me.txtBankName.Text = ""
        '
        'txtBranchName
        '
        Me.txtBranchName.AlphaNumeric = True
        Me.txtBranchName.BlankSpace = True
        Me.txtBranchName.Enabled = False
        Me.txtBranchName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBranchName.Location = New System.Drawing.Point(432, 48)
        Me.txtBranchName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBranchName.Mandatory = False
        Me.txtBranchName.MaxLength = 20
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(200, 23)
        Me.txtBranchName.SpecialChar = True
        Me.txtBranchName.TabIndex = 43
        Me.txtBranchName.TabStop = False
        Me.txtBranchName.Text = ""
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpChequeDate.Enabled = False
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(136, 80)
        Me.dtpChequeDate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpChequeDate.TabIndex = 44
        Me.dtpChequeDate.TabStop = False
        Me.dtpChequeDate.Value = New Date(2007, 10, 10, 0, 0, 0, 0)
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BlankSpace = True
        Me.txtChequeNo.Enabled = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(136, 48)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(136, 23)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 43
        Me.txtChequeNo.TabStop = False
        Me.txtChequeNo.Text = ""
        '
        'dtpDepositdate
        '
        Me.dtpDepositdate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDepositdate.Enabled = False
        Me.dtpDepositdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositdate.Location = New System.Drawing.Point(136, 112)
        Me.dtpDepositdate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpDepositdate.Name = "dtpDepositdate"
        Me.dtpDepositdate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDepositdate.TabIndex = 44
        Me.dtpDepositdate.TabStop = False
        Me.dtpDepositdate.Value = New Date(2007, 10, 10, 0, 0, 0, 0)
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = False
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(136, 240)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(480, 64)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 7
        Me.txtRemarks.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BlankSpace = True
        Me.txtAccNo.Enabled = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(136, 16)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 43
        Me.txtAccNo.TabStop = False
        Me.txtAccNo.Text = ""
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnClear.Location = New System.Drawing.Point(400, 320)
        Me.btnClear.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 40)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
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
        Me.btnCancel.Location = New System.Drawing.Point(504, 320)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        '
        'txtClearedAmt
        '
        Me.txtClearedAmt.AfterDecimal = 0
        Me.txtClearedAmt.BeforeDecimal = 10
        Me.txtClearedAmt.Enabled = False
        Me.txtClearedAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClearedAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtClearedAmt.Location = New System.Drawing.Point(136, 208)
        Me.txtClearedAmt.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtClearedAmt.MaxLength = 10
        Me.txtClearedAmt.MaxValue = 0
        Me.txtClearedAmt.MinValue = 0
        Me.txtClearedAmt.Name = "txtClearedAmt"
        Me.txtClearedAmt.Size = New System.Drawing.Size(136, 23)
        Me.txtClearedAmt.TabIndex = 3
        Me.txtClearedAmt.TabStop = False
        Me.txtClearedAmt.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Cleared Amount :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Bank Charges :"
        '
        'txtBankCharges
        '
        Me.txtBankCharges.AfterDecimal = 2
        Me.txtBankCharges.BeforeDecimal = 8
        Me.txtBankCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankCharges.Location = New System.Drawing.Point(112, 32)
        Me.txtBankCharges.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBankCharges.MaxLength = 10
        Me.txtBankCharges.MaxValue = 0
        Me.txtBankCharges.MinValue = 0
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(80, 22)
        Me.txtBankCharges.TabIndex = 5
        Me.txtBankCharges.Text = ""
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 8
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(136, 176)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReferenceNo.MaxLength = 10
        Me.txtReferenceNo.MaxValue = 0
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReferenceNo.TabIndex = 2
        Me.txtReferenceNo.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 19)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Reference No. :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextControl1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBankCharges)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(312, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 104)
        Me.GroupBox1.TabIndex = 4
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
        Me.TextControl1.Location = New System.Drawing.Point(112, 64)
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
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Bank Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Clearance Date :"
        '
        'dtpClearanceDate
        '
        Me.dtpClearanceDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClearanceDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClearanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClearanceDate.Location = New System.Drawing.Point(136, 144)
        Me.dtpClearanceDate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpClearanceDate.Name = "dtpClearanceDate"
        Me.dtpClearanceDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpClearanceDate.TabIndex = 1
        Me.dtpClearanceDate.Value = New Date(2007, 10, 10, 0, 0, 0, 0)
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 2
        Me.txtChequeAmount.BeforeDecimal = 8
        Me.txtChequeAmount.Enabled = False
        Me.txtChequeAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeAmount.Location = New System.Drawing.Point(432, 80)
        Me.txtChequeAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtChequeAmount.MaxLength = 10
        Me.txtChequeAmount.MaxValue = 0
        Me.txtChequeAmount.MinValue = 0
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.Size = New System.Drawing.Size(80, 23)
        Me.txtChequeAmount.TabIndex = 43
        Me.txtChequeAmount.TabStop = False
        Me.txtChequeAmount.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 19)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Cheque Amount :"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(280, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 68
        Me.btnSearch.Visible = False
        '
        'frmSBChequeStatusUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(690, 370)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtChequeAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpClearanceDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtReferenceNo)
        Me.Controls.Add(Me.Label13)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBChequeStatusUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Cheque Deposit"
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
        ElseIf Trim(txtClearedAmt.Text) > Trim(txtChequeAmount.Text) + Trim(txtBankCharges.Text) Then
            MsgBox("Amount cannot be greater than amount in cheque", MsgBoxStyle.Exclamation, "SB Module")
            txtClearedAmt.Focus()
            Return False
        ElseIf Trim(txtClearedAmt.Text) < Trim(txtChequeAmount.Text) Then
            MsgBox("Amount cannout be lesser than amount in cheque", MsgBoxStyle.Exclamation, "SB Module")
            txtClearedAmt.Focus()
            Return False
        ElseIf objSavingsBank.fnGetChecks(Trim(txtChequeNo.Text)) = True Then
            If Val(dblAvailAmount) - Val(txtClearedAmt.Text) < 0 Then
                ' MsgBox("WithDrawal Amount is Exeeding Balance Amount Please Enter Valid Amount")
                MsgBox("Inufficient fund", MsgBoxStyle.Exclamation)
                Return False
            End If
            Return True
        ElseIf Trim(txtReferenceNo.Text) = String.Empty Then
            MsgBox("Please enter reference amount", MsgBoxStyle.Exclamation, "SB Module")
            txtReferenceNo.Focus()
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

    End Function
    Function fnSetData() As Boolean

        objSavingsBank.SBNo = Trim(txtAccNo.Text)
        objSavingsBank.BankName = txtBankName.Text
        objSavingsBank.BranchName = txtBranchName.Text
        objSavingsBank.ChequeNo = txtChequeNo.Text
        objSavingsBank.ChequeDate = dtpChequeDate.Value
        objSavingsBank.ChequeDepositDate = dtpDepositdate.Value
        objSavingsBank.chequeClearanceDate = dtpClearanceDate.Value
        If txtBankCharges.Text = "" Then
            objSavingsBank.BankCharges = "0"
        Else
            objSavingsBank.BankCharges = txtBankCharges.Text
        End If
        objSavingsBank.ChequeAmount = txtChequeAmount.Text
        objSavingsBank.Remarks = txtRemarks.Text
        objSavingsBank.ChequeClearedAmt = txtClearedAmt.Text
        Return True

    End Function
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpClearanceDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery

        Dim strNarration As String = "Cheque Cleared " & "Cheque Number " & txtChequeNo.Text & " Narration:" & txtRemarks.Text
        objSavingsBank.fnUpdateStatus(lngVoucherNo, strNarration, objTrans)

        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpClearanceDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtClearedAmt.Text) & "','0','0','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtClearedAmt.Text) & "','" & Trim(txtReferenceNo.Text) & "','" & lngVoucherNo & "','Cheque','" & txtChequeNo.Text & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)


        If objSavingsBank.fnGetChecks(Trim(txtChequeNo.Text)) = True Then

            Dim strAccountNo As String = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("AccountNo")
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(strAccountNo) & "','" & Format(dtpClearanceDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtClearedAmt.Text) & "','0','0',sum(Deposit)-sum(withdraw)-'" & Trim(txtClearedAmt.Text) & "','" & Trim(txtReferenceNo.Text) & "','" & lngVoucherNo & "','Cheque','" & txtChequeNo.Text & "' from sbtransactiontbl where accountno='" & Trim(strAccountNo) & "' group by Accountno"
            fnExecuteNonQuery(strsql1, objTrans)

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, txtReferenceNo.Text, dtpClearanceDate.Value, txtClearedAmt.Text, "Cheque Cleared By Account " & txtAccNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpClearanceDate.Value, "Cheque cleared by account" & txtAccNo.Text, "To", 10, 0, Val(txtClearedAmt.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpClearanceDate.Value, "Cheque celared by account " & txtAccNo.Text, "By", 10, Val(txtClearedAmt.Text), 0, 2, "Y", objTrans)

            Return True
        Else

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtReferenceNo.Text, dtpClearanceDate.Value, txtClearedAmt.Text, "Cheque cleared by account " & txtAccNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "To", 10, 0, Val(txtClearedAmt.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpClearanceDate.Value, "Cheque cleared by account " & txtAccNo.Text, "By", 1, Val(txtClearedAmt.Text), 0, 2, "Y", objTrans)

            Return True
        End If

        'If Val(txtBankCharges.Text) <> 0 Then
        '    fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpOpenDate.Value, "By Member " & txtMemberNo.Text, "To", 6, 0, Val(txtBuildingFund.Text), 4, "Y")
        'End If

    End Function
    Function fnGenerateBounceVoucher() As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery                                     '" & Trim(txtClearedAmt.Text) & "'
        Dim strNarration As String = "Bounce cheque deposit by " & txtAccNo.Text & "  Narration:" & txtRemarks.Text
        objSavingsBank.fnChequeBounceStatus(lngVoucherNo, strNarration)
        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,AvalDeposit,AvalWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','" & Trim(txtClearedAmt.Text) & "',sum(Deposit)-sum(withdraw)+'" & Trim(txtClearedAmt.Text) & "','" & Trim(txtReferenceNo.Text) & "','" & lngVoucherNo & "','Cheque','" & txtChequeNo.Text & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql)

        If objSavingsBank.fnGetChecks(Trim(txtChequeNo.Text)) = True Then
            Dim strAccountNo As String = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("AccountNo")
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,AvalDeposit,AvalWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(strAccountNo) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','" & Trim(txtClearedAmt.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtClearedAmt.Text) & "','" & Trim(txtReferenceNo.Text) & "','" & lngVoucherNo & "','Cheque','txtChequeNo.Text' from sbtransactiontbl where accountno='" & Trim(strAccountNo) & "' group by Accountno"
            fnExecuteNonQuery(strsql1)
        End If

        If txtBankCharges.Text > 0 Then
            fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, "", dtpChequeDate.Value, txtBankCharges.Text, "Cheque bounce charges (" & Trim(txtChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y")
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpChequeDate.Value, "Cheque bounce by SB accountNo " & txtAccNo.Text & " on ChequeNo" & txtChequeNo.Text & " " & txtAccNo.Text, "To", 36, 0, Val(txtBankCharges.Text), 1, "Y")
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpChequeDate.Value, "Cheque bounce by SB accountno " & txtAccNo.Text & " on ChequeNo " & txtChequeNo.Text & "  " & txtAccNo.Text, "By", 10, Val(txtBankCharges.Text), 0, 2, "Y")
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
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If MsgBox("are u sure you want to clear the cheque", MsgBoxStyle.YesNo + MsgBoxStyle.Question, " SB Module") = MsgBoxResult.Yes Then
                    If fnSetData() Then
                        objSavingsBank.ChequeStatus = "Cleared"

                        If fnGenerateVoucher(objTrans) Then
                            fnLogEntry(pbUserId, "Cheque Cleared by " & txtAccNo.Text & " Amount " & Val(txtChequeAmount.Text), Date.Now, "Cheque Cleared", objTrans)
                            objTrans.Commit()
                            MsgBox("Cheque cleared successfully", MsgBoxStyle.Exclamation, "SB Module")
                            fnClear()
                        Else
                            MsgBox("Cheque cannot be cleared, due to internal error", MsgBoxStyle.Exclamation, " SB Module")
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

    Private Sub btnBounce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fnCheck() Then
            If MsgBox("are u sure you want to clear the cheque", MsgBoxStyle.YesNo + MsgBoxStyle.Question, " SB Module") = MsgBoxResult.Yes Then
                If fnSetData() Then
                    If fnGenerateBounceVoucher() Then
                        MsgBox("Cheque status altered successfully", MsgBoxStyle.Exclamation, "SB Module")
                        fnClear()

                    Else
                        MsgBox("Cheque status cannot be altred, due to internal error", MsgBoxStyle.Exclamation, "SB Module")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmSBChequeStatusUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpChequeDate.Value = Date.Now
        dtpDepositdate.Value = Date.Now
        dtpClearanceDate.Value = Date.Now
        If Trim(txtAccNo.Text <> String.Empty) Then
            If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
                dblAvailAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
            End If
        End If

    End Sub

#End Region

End Class
