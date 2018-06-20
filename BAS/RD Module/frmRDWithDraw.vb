
Public Class frmRDWithDraw
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
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dtpWithDrawDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInterest As BankControls.NumericControl
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBalanceAmount As BankControls.NumericControl
    Friend WithEvents txtInterestAmount As BankControls.NumericControl
    Friend WithEvents txtTotalAmount As BankControls.NumericControl
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRDName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRDAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOtherAmount As BankControls.NumericControl
    Friend WithEvents btnPreMature As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRDWithDraw))
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dtpWithDrawDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRDName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRDAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtRefNo = New BankControls.NumericControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnCalInterest = New BankControls.NewButton
        Me.txtBalanceAmount = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtInterest = New BankControls.NumericControl
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtInterestAmount = New BankControls.NumericControl
        Me.txtTotalAmount = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOtherAmount = New BankControls.NumericControl
        Me.btnPreMature = New BankControls.NewButton
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.Beige
        Me.btnWithdraw.Location = New System.Drawing.Point(432, 240)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(104, 40)
        Me.btnWithdraw.TabIndex = 7
        Me.btnWithdraw.Text = "Withdrawl"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Location = New System.Drawing.Point(552, 240)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 224)
        Me.TabControl1.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.TabPage1.Controls.Add(Me.dtpWithDrawDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(648, 195)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deposit Details"
        '
        'dtpWithDrawDate
        '
        Me.dtpWithDrawDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpWithDrawDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWithDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWithDrawDate.Location = New System.Drawing.Point(120, 16)
        Me.dtpWithDrawDate.Name = "dtpWithDrawDate"
        Me.dtpWithDrawDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpWithDrawDate.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 19)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRDName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRDAccNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 136)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Holder Details"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Reference No"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Narration"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(400, 72)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(200, 52)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 6
        Me.txtNarration.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Name"
        '
        'txtRDName
        '
        Me.txtRDName.AlphaNumeric = False
        Me.txtRDName.AutoSize = False
        Me.txtRDName.BlankSpace = False
        Me.txtRDName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDName.Location = New System.Drawing.Point(112, 72)
        Me.txtRDName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRDName.Mandatory = False
        Me.txtRDName.Name = "txtRDName"
        Me.txtRDName.Size = New System.Drawing.Size(160, 20)
        Me.txtRDName.SpecialChar = False
        Me.txtRDName.TabIndex = 3
        Me.txtRDName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "AccountNo"
        '
        'txtRDAccNo
        '
        Me.txtRDAccNo.AlphaNumeric = True
        Me.txtRDAccNo.BlankSpace = False
        Me.txtRDAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDAccNo.Location = New System.Drawing.Point(112, 32)
        Me.txtRDAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRDAccNo.Mandatory = False
        Me.txtRDAccNo.MaxLength = 10
        Me.txtRDAccNo.Name = "txtRDAccNo"
        Me.txtRDAccNo.Size = New System.Drawing.Size(120, 23)
        Me.txtRDAccNo.SpecialChar = False
        Me.txtRDAccNo.TabIndex = 1
        Me.txtRDAccNo.Text = "RD"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(240, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(400, 32)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(168, 23)
        Me.txtRefNo.TabIndex = 5
        Me.txtRefNo.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.TabPage2.Controls.Add(Me.btnCalInterest)
        Me.TabPage2.Controls.Add(Me.txtBalanceAmount)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtInterest)
        Me.TabPage2.Controls.Add(Me.dtpMaturityDate)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtInterestAmount)
        Me.TabPage2.Controls.Add(Me.txtTotalAmount)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtOtherAmount)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(648, 195)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Interest Details"
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnCalInterest.Location = New System.Drawing.Point(296, 24)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(40, 24)
        Me.btnCalInterest.TabIndex = 2
        Me.btnCalInterest.Text = "Int"
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.AfterDecimal = 2
        Me.txtBalanceAmount.BackColor = System.Drawing.Color.White
        Me.txtBalanceAmount.BeforeDecimal = 7
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalanceAmount.Location = New System.Drawing.Point(144, 24)
        Me.txtBalanceAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalanceAmount.MaxValue = 0
        Me.txtBalanceAmount.MinValue = 0
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtBalanceAmount.TabIndex = 1
        Me.txtBalanceAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(544, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "%"
        '
        'txtInterest
        '
        Me.txtInterest.AfterDecimal = 2
        Me.txtInterest.BackColor = System.Drawing.Color.White
        Me.txtInterest.BeforeDecimal = 8
        Me.txtInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterest.Location = New System.Drawing.Point(480, 32)
        Me.txtInterest.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(56, 23)
        Me.txtInterest.TabIndex = 4
        Me.txtInterest.Text = ""
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpMaturityDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpMaturityDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(480, 72)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpMaturityDate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Balance Amount"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(368, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 17)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "ROI"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 17)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Interest Amount"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 17)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Total Amount"
        '
        'txtInterestAmount
        '
        Me.txtInterestAmount.AfterDecimal = 2
        Me.txtInterestAmount.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.txtInterestAmount.BeforeDecimal = 7
        Me.txtInterestAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterestAmount.Location = New System.Drawing.Point(144, 64)
        Me.txtInterestAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInterestAmount.MaxValue = 0
        Me.txtInterestAmount.MinValue = 0
        Me.txtInterestAmount.Name = "txtInterestAmount"
        Me.txtInterestAmount.ReadOnly = True
        Me.txtInterestAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtInterestAmount.TabIndex = 4
        Me.txtInterestAmount.Text = ""
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AfterDecimal = 2
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BeforeDecimal = 7
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotalAmount.Location = New System.Drawing.Point(144, 144)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotalAmount.MaxValue = 0
        Me.txtTotalAmount.MinValue = 0
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtTotalAmount.TabIndex = 6
        Me.txtTotalAmount.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Maturity Date"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Other Amount"
        '
        'txtOtherAmount
        '
        Me.txtOtherAmount.AfterDecimal = 2
        Me.txtOtherAmount.BeforeDecimal = 7
        Me.txtOtherAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherAmount.Location = New System.Drawing.Point(144, 104)
        Me.txtOtherAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherAmount.MaxValue = 0
        Me.txtOtherAmount.MinValue = 0
        Me.txtOtherAmount.Name = "txtOtherAmount"
        Me.txtOtherAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtOtherAmount.TabIndex = 3
        Me.txtOtherAmount.Text = ""
        '
        'btnPreMature
        '
        Me.btnPreMature.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnPreMature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreMature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreMature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreMature.GotFocusColour = System.Drawing.Color.Beige
        Me.btnPreMature.Location = New System.Drawing.Point(8, 240)
        Me.btnPreMature.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnPreMature.Name = "btnPreMature"
        Me.btnPreMature.Size = New System.Drawing.Size(104, 40)
        Me.btnPreMature.TabIndex = 9
        Me.btnPreMature.Text = "PreMature"
        '
        'frmRDWithDraw
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(664, 285)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPreMature)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDWithDraw"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RDWithdraw"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Varaibles"

    Dim objRDAcc As New clsRDAccount
    Public strAccNo As String
    Public strName As String
    Dim intDateDiff As Integer

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If txtRDAccNo.Text = String.Empty Then
            MsgBox("Please select the agent ID", MsgBoxStyle.Information)
            txtRDAccNo.Focus()
            Return False
        ElseIf txtRDName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            txtRDName.Focus()
            Return False
        ElseIf txtTotalAmount.Text = String.Empty Then
            MsgBox("Please enter the total amount to deposit", MsgBoxStyle.Information)
            txtTotalAmount.Focus()
            Return False
        ElseIf txtRDAccNo.Text = String.Empty Then
            MsgBox("Please select the agents account no", MsgBoxStyle.Information)
            'cmbAGNo.Focus()
            Return False
        ElseIf txtRDName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            'cmbAGNo.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference no cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
            Return False
        ElseIf Val(txtTotalAmount.Text) < Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text) + Val(txtOtherAmount.Text) Then
            MsgBox("You have to draw full amount", MsgBoxStyle.Exclamation, "RD Module")
            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnCheckRefNo() As Boolean

        If objRDAcc.fnCheckRefNo(txtRefNo.Text) Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnSetData() As Boolean

        objRDAcc.Amount = txtBalanceAmount.Text
        objRDAcc.Reference = txtRefNo.Text
        objRDAcc.TransDate = dtpWithDrawDate.Value
        objRDAcc.RDNo = txtRDAccNo.Text
        objRDAcc.Narration = txtNarration.Text
        Return True

    End Function

    Public Function fnClear()

        ''''   txtAmount.Text = ""
        txtRefNo.Text = ""
        txtRDAccNo.Text = "RD"
        txtNarration.Text = ""
        txtRDName.Text = ""

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpWithDrawDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Withdrawal By " & txtRDAccNo.Text & " Narration:" & txtNarration.Text

        objRDAcc.fnWithDrawl(lngVoucherNo, objTrans) 'To insert into RD Transaction table
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtRDAccNo.Text, txtRefNo.Text, dtpWithDrawDate.Value, txtTotalAmount.Text, "Withdraw by " & txtRDAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithDrawDate.Value, "Withdraw by RD account " & txtRDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        '''First one for the ledger no 48 i.e RD Ledger
        '''Second is for the legere no 50 i.e Interest on RD Ledger
        fnVoucherEnterSub(lngVoucherNo, 1, txtRDAccNo.Text, dtpWithDrawDate.Value, "Withdraw by RD account " & txtRDAccNo.Text, "By", 29, Val(txtBalanceAmount.Text), 0, 2, "Y", objTrans)
        fnVoucherEnterSub(lngVoucherNo, 1, txtRDAccNo.Text, dtpWithDrawDate.Value, "Withdraw by RD account " & txtRDAccNo.Text, "By", 32, Val(txtInterestAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function

    Public Function fnGetBalance()

        If objRDAcc.fnGetBalance(txtRDAccNo.Text) Then
            txtBalanceAmount.Text = objRDAcc.Balance.Rows(0).Item("Balance")
            txtBalanceAmount.ReadOnly = True
            dtpMaturityDate.Value = Format(objRDAcc.Balance.Rows(0).Item("RDMaturityDate"), "yyyy-MM-dd")
            txtInterest.Text = objRDAcc.Balance.Rows(0).Item("rdROI")
            txtInterest.ReadOnly = True
        End If

    End Function

#End Region

#Region "Procedure"

    Sub sbGetAgents()

        Dim objClsAgets As New clsPigmyAgent
        Dim dtAgents As DataTable
        If objClsAgets.fnGetAgents() Then

            dtAgents = objClsAgets.getAgentsTable
            'cmbAGNo.Items.Clear()
            'cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            'cmbAGNo.SourceDataString = New String(1) {"AgentID", "AgentName"}
            'cmbAGNo.SourceDataTable = dtAgents

        End If

    End Sub

    Sub sbLoadData()

        'If objAgent.fnGetData(txtPGAccNo.Text) Then
        'txtPGName.Text = objAgent.PigmyAccTable.Rows(0).Item("   


        'End If

    End Sub

#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmRDCust As New frmRDCust
        objfrmRDCust.strRDNo = ""
        objfrmRDCust.ShowDialog(Me)
        If objfrmRDCust.strRDNo <> "" Then
            txtRDAccNo.Text = objfrmRDCust.strRDNo
            txtRDName.Text = objfrmRDCust.strRDName
            txtRDAccNo.Focus()
        End If
        objfrmRDCust.Dispose()

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmAgents As New frmAGAccSearch
        objfrmAgents.ShowDialog()

    End Sub

    Private Sub frmPigmyDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpMaturityDate.Value = Date.Now
        dtpWithDrawDate.Value = Date.Now

        txtRDAccNo.Text = strAccNo
        txtRDName.Text = strName
        '''' sbGetAgents()
        fnGetBalance()

    End Sub

    Public Function fnCalInterest() As Boolean

        If objRDAcc.fnGetDetails(txtRDAccNo.Text) Then
            intDateDiff = DateDiff(DateInterval.DayOfYear, objRDAcc.GetRDDetailstbl.Rows(0).Item("RDDate"), Date.Today) / 30
            If fnCheckPeriod() Then
                If fnPostInterest() Then
                End If
            End If
        End If

    End Function

    Public Function fnCheckPeriod() As Boolean

        If objRDAcc.fnGetMinPeriod Then
            If intDateDiff < objRDAcc.MinPeriodTable.Rows(0).Item("MinMonth") Then
                MsgBox("Sorry,interest cannot be posted for this account", MsgBoxStyle.Exclamation, "RD Module")
                Return False
            Else
                MsgBox("Interest can be posted for this account", MsgBoxStyle.Exclamation, "RD Module")
                Return True
            End If
        End If

    End Function

    Public Function fnPostInterest() As Boolean
        Dim dblBalance As Double
        Dim dblROI As Double
        Dim dblInterestAmount As Double
        Dim dblOtherAmt As Double

        If objRDAcc.fnIntestPost(txtRDAccNo.Text) Then
            If objRDAcc.InterestPosttbl.Rows(0).Item("WithDraw") = 0 Then
                dblBalance = objRDAcc.GetRDDetailstbl.Rows(0).Item("Balance")
                dblROI = objRDAcc.GetRDDetailstbl.Rows(0).Item("RDROI")
                dblInterestAmount = Math.Round((dblBalance * intDateDiff * dblROI) / 1200)
                '''''dblOtherAmt = txtOtherAmount.Text
                txtInterestAmount.Text = dblInterestAmount
                txtTotalAmount.Text = Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text)
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Public Function fnCalculateTot()

        txtTotalAmount.Text = txtInterestAmount.Text + Val(txtOtherAmount.Text) + txtBalanceAmount.Text

    End Function

    Public Function fnChkPreMaturity() As Boolean

        If objRDAcc.fnGetMinPeriod Then
            If intDateDiff < objRDAcc.MinPeriodTable.Rows(0).Item("MinMonth") Then
                If MsgBox("Do u want to premature this account", MsgBoxStyle.YesNo, "RD Module") = MsgBoxResult.Yes Then
                    fnCalPreMaturity()
                Else
                    Return True
                End If
            Else
                Return True
            End If
        End If

    End Function

    Public Function fnCalPreMaturity() As Boolean
        '' Interest Calculation 
        Dim dblBalance As Double
        Dim dblROI As Double
        Dim BI1 As Double
        Dim BI2 As Double
        Dim BI As Double
        If objRDAcc.fnIntestPost(txtRDAccNo.Text) Then
            dblBalance = objRDAcc.GetRDDetailstbl.Rows(0).Item("Balance")
            dblROI = objRDAcc.GetRDDetailstbl.Rows(0).Item("ROI")
            BI1 = Math.Round(dblBalance * dblROI * intDateDiff) / 1200
            BI2 = Math.Round(dblBalance * dblROI * (12 - intDateDiff)) / 1200
            BI = BI2 - BI1
            If BI > 0 Then
            End If
        End If

    End Function

#End Region

    Private Sub cmbAGNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '''''txtAGName.Text = cmbAGNo.SelectedItem.col1

    End Sub

    Private Sub txtPGAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtRDAccNo.Text.StartsWith("RD") = False Then
            txtRDAccNo.Undo()
            txtRDAccNo.ClearUndo()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub frmRDWithDraw_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        fnGetBalance()

    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click

        fnCalInterest()

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click

        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnCheckRefNo() = False Then
                    If fnSetData() Then
                        ''''If objRDAcc.fnWithDrawl(txtRDAccNo.Text) Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Withdraw by " & txtRDAccNo.Text & " Amount " & txtTotalAmount.Text, Date.Now, "Transaction Withdraw", objTrans)
                        objTrans.Commit()
                        'objRDAcc.fnUpdateStatus(txtRDAccNo.Text)
                        If MsgBox("Transaction completed successfully,do u want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            fnClear()
                            txtRDAccNo.Text = String.Empty
                        Else
                            Me.Close()
                        End If
                    Else
                        MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Exclamation, "RD Module")
                    End If
                Else
                    MsgBox("Reference no already exist,please try other reference no", MsgBoxStyle.Exclamation, "RD Module")
                    txtRefNo.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
        ''''End If

    End Sub

    Private Sub txtInterestAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterestAmount.TextChanged, txtOtherAmount.TextChanged

        fnCalculateTot()

    End Sub

    Private Sub btnPreMature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreMature.Click

        Dim objFrmRDPreMature As New frmRDPreMature
        objFrmRDPreMature.strName = txtRDName.Text
        objFrmRDPreMature.strAccNo = txtRDAccNo.Text
        objFrmRDPreMature.ShowDialog()

    End Sub
End Class
