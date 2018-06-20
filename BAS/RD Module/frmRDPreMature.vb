
Public Class frmRDPreMature
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPreROI As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDPreMature))
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dtpWithDrawDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRDName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRDAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtRefNo = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPreROI = New BankControls.NumericControl
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.Beige
        Me.btnWithdraw.Location = New System.Drawing.Point(428, 413)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(104, 40)
        Me.btnWithdraw.TabIndex = 9
        Me.btnWithdraw.Text = "&Premeture"
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Location = New System.Drawing.Point(548, 413)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 224)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dtpWithDrawDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(648, 195)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deposit Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpWithDrawDate
        '
        Me.dtpWithDrawDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpWithDrawDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWithDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWithDrawDate.Location = New System.Drawing.Point(128, 13)
        Me.dtpWithDrawDate.Name = "dtpWithDrawDate"
        Me.dtpWithDrawDate.Size = New System.Drawing.Size(140, 23)
        Me.dtpWithDrawDate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Premature Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dtpDepositDate)
        Me.GroupBox1.Controls.Add(Me.Label15)
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
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Holder Details"
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDepositDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Enabled = False
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(113, 103)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpDepositDate.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Deposit Date"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Reference No"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
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
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
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
        Me.txtRDName.BlankSpace = False
        Me.txtRDName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDName.Location = New System.Drawing.Point(112, 72)
        Me.txtRDName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRDName.Mandatory = False
        Me.txtRDName.Name = "txtRDName"
        Me.txtRDName.ReadOnly = True
        Me.txtRDName.Size = New System.Drawing.Size(160, 23)
        Me.txtRDName.SpecialChar = False
        Me.txtRDName.TabIndex = 4
        Me.txtRDName.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
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
        Me.txtRDAccNo.ReadOnly = True
        Me.txtRDAccNo.Size = New System.Drawing.Size(120, 23)
        Me.txtRDAccNo.SpecialChar = False
        Me.txtRDAccNo.TabIndex = 2
        Me.txtRDAccNo.TabStop = False
        Me.txtRDAccNo.Text = "RD"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(240, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = False
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
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(540, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "%"
        '
        'txtPreROI
        '
        Me.txtPreROI.AfterDecimal = 2
        Me.txtPreROI.BackColor = System.Drawing.Color.White
        Me.txtPreROI.BeforeDecimal = 8
        Me.txtPreROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreROI.GotFocusColour = System.Drawing.Color.White
        Me.txtPreROI.Location = New System.Drawing.Point(482, 298)
        Me.txtPreROI.LostFocusColour = System.Drawing.Color.White
        Me.txtPreROI.MaxLength = 10
        Me.txtPreROI.MaxValue = 0
        Me.txtPreROI.MinValue = 0
        Me.txtPreROI.Name = "txtPreROI"
        Me.txtPreROI.Size = New System.Drawing.Size(56, 23)
        Me.txtPreROI.TabIndex = 7
        Me.txtPreROI.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(372, 301)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 17)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Premature ROI         "
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(307, 258)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(40, 24)
        Me.btnCalInterest.TabIndex = 2
        Me.btnCalInterest.Text = "Int"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        '
        'txtBalanceAmount
        '
        Me.txtBalanceAmount.AfterDecimal = 2
        Me.txtBalanceAmount.BackColor = System.Drawing.Color.White
        Me.txtBalanceAmount.BeforeDecimal = 7
        Me.txtBalanceAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalanceAmount.Location = New System.Drawing.Point(155, 258)
        Me.txtBalanceAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalanceAmount.MaxValue = 0
        Me.txtBalanceAmount.MinValue = 0
        Me.txtBalanceAmount.Name = "txtBalanceAmount"
        Me.txtBalanceAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtBalanceAmount.TabIndex = 1
        Me.txtBalanceAmount.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(542, 262)
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
        Me.txtInterest.GotFocusColour = System.Drawing.Color.White
        Me.txtInterest.Location = New System.Drawing.Point(482, 258)
        Me.txtInterest.LostFocusColour = System.Drawing.Color.White
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.ReadOnly = True
        Me.txtInterest.Size = New System.Drawing.Size(56, 23)
        Me.txtInterest.TabIndex = 6
        Me.txtInterest.TabStop = False
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpMaturityDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpMaturityDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(482, 339)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpMaturityDate.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Balance Amount :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(372, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 17)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Previous ROI"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 17)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Interest Amount :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 17)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Total Amount"
        '
        'txtInterestAmount
        '
        Me.txtInterestAmount.AfterDecimal = 2
        Me.txtInterestAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtInterestAmount.BeforeDecimal = 7
        Me.txtInterestAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtInterestAmount.Location = New System.Drawing.Point(155, 298)
        Me.txtInterestAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtInterestAmount.MaxValue = 0
        Me.txtInterestAmount.MinValue = 0
        Me.txtInterestAmount.Name = "txtInterestAmount"
        Me.txtInterestAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtInterestAmount.TabIndex = 3
        Me.txtInterestAmount.TabStop = False
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AfterDecimal = 2
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BeforeDecimal = 7
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotalAmount.Location = New System.Drawing.Point(155, 378)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotalAmount.MaxValue = 0
        Me.txtTotalAmount.MinValue = 0
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtTotalAmount.TabIndex = 5
        Me.txtTotalAmount.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(372, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Maturity Date"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 344)
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
        Me.txtOtherAmount.Location = New System.Drawing.Point(155, 338)
        Me.txtOtherAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherAmount.MaxValue = 0
        Me.txtOtherAmount.MinValue = 0
        Me.txtOtherAmount.Name = "txtOtherAmount"
        Me.txtOtherAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtOtherAmount.TabIndex = 4
        '
        'frmRDPreMature
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(664, 465)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtPreROI)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.dtpMaturityDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCalInterest)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBalanceAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOtherAmount)
        Me.Controls.Add(Me.txtInterestAmount)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDPreMature"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RD Premature"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Varaibles"

    Dim objRDAcc As New clsRDAccount
    'Dim objFDAccount As New clsFDAccount
    Public strAccNo As String
    Public strName As String
    Dim intDateDiff As Integer
    Dim intMonthDiff As Integer

    Dim dblProvisionInterest As Double
    Dim dblDueInterest As Double

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If txtRDAccNo.Text = String.Empty Then
            MsgBox("Please Select the RD Accoun No", MsgBoxStyle.Information)
            txtRDAccNo.Focus()
            Return False
        ElseIf txtRDName.Text = String.Empty Then
            MsgBox("Please enter the Name", MsgBoxStyle.Information)
            txtRDName.Focus()
            Return False
        ElseIf txtTotalAmount.Text = String.Empty Then
            MsgBox("Please enter the Total amount to deposit", MsgBoxStyle.Information)
            txtTotalAmount.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference No cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
            Return False
        ElseIf Val(txtBalanceAmount.Text) < Val(txtInterestAmount.Text) Then
            MsgBox("Interest amount is not greater than the balance amount ", MsgBoxStyle.Exclamation)
            btnCalInterest.Focus()
            Return False
        ElseIf Val(txtOtherAmount.Text) > Val(txtBalanceAmount.Text) Then
            MsgBox("Bank charges is not greater than the balance amount", MsgBoxStyle.Exclamation)
            txtOtherAmount.Focus()
            Return False
            'ElseIf Val(txtTotalAmount.Text) > Val(txtBalanceAmount.Text) Then
            '    MsgBox("please check bank charges and interest amount", MsgBoxStyle.Exclamation)
            '    txtOtherAmount.Focus()
            '    Return False
            'ElseIf Val(txtTotalAmount.Text) < Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text) + Val(txtOtherAmount.Text) Then
            '    MsgBox("You have to Draw Full Amount", MsgBoxStyle.Exclamation, "RD Module")
            '''    Return False
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
        If objRDAcc.fnGetInterestDet(txtRDAccNo.Text) Then
            objRDAcc.ProvisionAmount = objRDAcc.dtIntPost.Rows(0).Item("ProvisionAmount")
        Else
            objRDAcc.ProvisionAmount = 0
        End If
        Return True

    End Function

    Public Function fnClear()

        txtRefNo.Text = ""
        txtRDAccNo.Text = "RD"
        txtNarration.Text = ""
        txtRDName.Text = ""
        txtBalanceAmount.ResetText()
        txtInterest.ResetText()
        txtOtherAmount.ResetText()
        txtTotalAmount.ResetText()
        txtPreROI.ResetText()
        txtInterestAmount.ResetText()
        TabControl1.SelectedIndex = 1
        btnSearch.Enabled = True

    End Function
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpWithDrawDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        Dim strNarration As String = "Premature By " & txtRDAccNo.Text & " Narration:" & txtNarration.Text
        objRDAcc.fnWithDrawl(lngVoucherNo, objTrans) 'To insert into RD Transaction table
        objRDAcc.fnUpdateStatus(txtRDAccNo.Text, lngVoucherNo, objTrans)
        ''voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtRDAccNo.Text, txtRefNo.Text, dtpWithDrawDate.Value, txtTotalAmount.Text, "Premature By " & txtRDAccNo.Text, lngSlNo, "Y", objTrans)
        ''Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithDrawDate.Value, "By Account No " & txtRDAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 1, "Y", objTrans)

        If objRDAcc.ProvisionAmount <> 0 Then
            'Debit accounts -Interest Payable
            fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccNo.Text, dtpWithDrawDate.Value, "IntPaid By Account No" & txtRDAccNo.Text, "By", 14, objRDAcc.ProvisionAmount - Val(txtInterestAmount.Text), 0, 2, "Y", objTrans)
            fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccNo.Text, dtpWithDrawDate.Value, "Interest paid b Account No " & txtRDAccNo.Text, "To", 32, 0, objRDAcc.ProvisionAmount - Val(txtInterestAmount.Text), 3, "Y", objTrans)

        End If

        '''Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccNo.Text, dtpWithDrawDate.Value, "Precloser By Account No " & txtRDAccNo.Text, "By", 29, Val(txtBalanceAmount.Text), 0, 2, "Y", objTrans)
        If txtOtherAmount.Text <> "" Or Val(txtOtherAmount.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccNo.Text, dtpWithDrawDate.Value, "Misc Charges Paid By " & txtRDAccNo.Text, "To", 13, 0, Val(txtOtherAmount.Text), 4, "Y", objTrans)
        End If
        Return True
    End Function

    Public Function fnGetBalance()

        If objRDAcc.fnGetBalance(txtRDAccNo.Text) Then
            Dim lngPeriod As Double = 0
            txtBalanceAmount.Text = objRDAcc.Balance.Rows(0).Item("Balance")
            txtBalanceAmount.ReadOnly = True
            dtpMaturityDate.Value = Format(objRDAcc.Balance.Rows(0).Item("RDMaturityDate"), "yyyy-MM-dd")
            dtpDepositDate.Text = Format(objRDAcc.Balance.Rows(0).Item("RDDate"), "yyyy-MM-dd")
            txtInterest.Text = objRDAcc.Balance.Rows(0).Item("rdROI")
            txtInterest.ReadOnly = True
            objRDAcc.SchemeCode = objRDAcc.Balance.Rows(0).Item("RDScheme")
            lngPeriod = DateDiff(DateInterval.Day, objRDAcc.Balance.Rows(0).Item("RDDate"), dtpWithDrawDate.Value)
            If objRDAcc.fnGetSB_ROI() Then
                txtPreROI.Text = objRDAcc.SBMasterTbl.Rows(0).Item("SBRoi")
            End If

        End If

    End Function

#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmRDCust As New frmRDCust
        objfrmRDCust.strRDNo = ""
        objfrmRDCust.ShowDialog(Me)
        If objfrmRDCust.strRDNo <> "" Then
            txtRDAccNo.Text = objfrmRDCust.strRDNo
            txtRDName.Text = objfrmRDCust.strRDName
            fnGetBalance()
            'fnLoadIntetest()
        End If
        objfrmRDCust.Dispose()

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmAgents As New frmAGAccSearch
        objfrmAgents.ShowDialog()

    End Sub

    Private Sub frmPigmyDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRDAccNo.Text = strAccNo
        dtpMaturityDate.Value = Date.Now
        dtpWithDrawDate.Value = Date.Now

        If txtRDAccNo.Text <> "RD" And txtRDAccNo.Text <> "" Then
            txtRDAccNo.Text = strAccNo
            txtRDName.Text = strName
            fnGetBalance()
        End If

    End Sub

    Public Function fnCalculateTot()

        txtTotalAmount.Text = Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text) - Val(txtOtherAmount.Text)

    End Function

    Public Function fnChkPreMaturity() As Boolean

        If MsgBox("Do u Want to PreMature This Account", MsgBoxStyle.YesNo, "RD Module") = MsgBoxResult.Yes Then
            fnCalPreMaturity()
        Else
            Return True
        End If

    End Function

    Public Function fnCalPreMaturity() As Boolean
        '' Interest Calculation 
        'Dim dblBalance As Double
        'Dim intDateDiff2 As Integer
        'Dim datMaturityDate As Date
        'Dim dblROI As Double
        'Dim dblPreROI As Double
        'Dim BI1 As Double
        'Dim BI2 As Double
        'Dim BI As Double
        'dblBalance = objRDAcc.GetRDDetailstbl.Rows(0).Item("Balance")
        'dblROI = txtPreROI.Text
        'BI1 = Math.Round((dblBalance * dblROI * intDateDiff) / (365 * 100), 2)
        'txtInterestAmount.Text = Math.Round(BI1)
        'txtBalanceAmount.Text = objRDAcc.GetRDDetailstbl.Rows(0).Item("Balance")

        If dtpWithDrawDate.Value < dtpMaturityDate.Value Then
            txtTotalAmount.Text = Val(txtBalanceAmount.Text)
            Label14.Visible = False
            txtPreROI.Visible = False
            Label13.Visible = False
        ElseIf dtpWithDrawDate.Value >= dtpMaturityDate.Value Then
            If objRDAcc.fnGetSB_ROI() Then
                txtPreROI.Text = objRDAcc.SBMasterTbl.Rows(0).Item("SBRoi")
                txtInterestAmount.Text = Math.Round(Val(txtBalanceAmount.Text) * Val(txtPreROI.Text) / 100)
                txtTotalAmount.Text = Val(txtBalanceAmount.Text) + Val(txtInterestAmount.Text)
            End If
        End If
    End Function
#End Region

#Region "Single instance creation"

    Private Shared m_FormDefInstance As frmRDPreMature
    Private Shared m_InitilizeDefInstance As Boolean

    Public Shared Property DefInstance() As frmRDPreMature
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitilizeDefInstance = True
                m_FormDefInstance = New frmRDPreMature
                m_InitilizeDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmRDPreMature)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        If txtInterest.Text = String.Empty Then
            MsgBox("Enter the ROI", MsgBoxStyle.Information)
            txtInterest.Focus()

            'ElseIf txtPreROI.Text = String.Empty Then
            '    MsgBox("Enter prematureROI", MsgBoxStyle.Information)
            '    txtPreROI.Focus()
        Else

            fnChkPreMaturity()

        End If

    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnCheckRefNo() = False Then
                    If fnSetData() Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Closing of account no " & txtRDAccNo.Text & " Amount " & txtTotalAmount.Text, Date.Now, "Transaction Premature", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed successfully,do u want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            fnClear()
                        Else
                            Me.Close()
                        End If
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

    End Sub

    Private Sub txtInterestAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterestAmount.TextChanged, txtOtherAmount.TextChanged

        fnCalculateTot()

    End Sub

    Private Sub txtRDAccNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRDAccNo.TextChanged
        If txtRDAccNo.Text.StartsWith("RD") = False Then
            txtRDAccNo.Undo()
            txtRDAccNo.ClearUndo()
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
