Public Class frmFDPayments
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "

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
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFDAccountNo As BankControls.TextControl
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents btnPayInterest As BankControls.NewButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInterestdate As BankControls.TextControl
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents chkFundTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents txtSchemeType As System.Windows.Forms.TextBox
    Friend WithEvents txtIPDCr As BankControls.TextControl
    Friend WithEvents rdoIPDCr As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIPDDr As System.Windows.Forms.RadioButton
    Friend WithEvents txtIPDDr As BankControls.TextControl
    Friend WithEvents txtPayAmount As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDPayments))
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.Total_Amt = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.btnPayInterest = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtPayAmount = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIPDDr = New BankControls.TextControl
        Me.rdoIPDDr = New System.Windows.Forms.RadioButton
        Me.rdoIPDCr = New System.Windows.Forms.RadioButton
        Me.txtIPDCr = New BankControls.TextControl
        Me.chkFundTransfer = New System.Windows.Forms.CheckBox
        Me.txtAccountNo = New BankControls.TextControl
        Me.lblAccount = New System.Windows.Forms.Label
        Me.txtInterestdate = New BankControls.TextControl
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.txtFDAmount = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFDAccountNo = New BankControls.TextControl
        Me.btnSearchFD = New BankControls.NewButton
        Me.txtRemarks = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtSchemeType = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Int_Date.Width = 113
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Int_Amt.Width = 131
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lvInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Int_Amt, Me.Int_Date, Me.Total_Amt})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.HideSelection = False
        Me.lvInterest.Location = New System.Drawing.Point(8, 387)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(608, 316)
        Me.lvInterest.TabIndex = 2
        Me.lvInterest.TabStop = False
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 74
        '
        'Total_Amt
        '
        Me.Total_Amt.Text = "Total Amount"
        Me.Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total_Amt.Width = 103
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(464, 340)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 40)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        '
        'btnPayInterest
        '
        Me.btnPayInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayInterest.ForeColor = System.Drawing.Color.Black
        Me.btnPayInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPayInterest.Image = CType(resources.GetObject("btnPayInterest.Image"), System.Drawing.Image)
        Me.btnPayInterest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayInterest.Location = New System.Drawing.Point(336, 340)
        Me.btnPayInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnPayInterest.Name = "btnPayInterest"
        Me.btnPayInterest.Size = New System.Drawing.Size(128, 40)
        Me.btnPayInterest.TabIndex = 10
        Me.btnPayInterest.Text = "Pay Interest"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPayAmount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtIPDDr)
        Me.Panel1.Controls.Add(Me.rdoIPDDr)
        Me.Panel1.Controls.Add(Me.rdoIPDCr)
        Me.Panel1.Controls.Add(Me.txtIPDCr)
        Me.Panel1.Controls.Add(Me.chkFundTransfer)
        Me.Panel1.Controls.Add(Me.txtAccountNo)
        Me.Panel1.Controls.Add(Me.lblAccount)
        Me.Panel1.Controls.Add(Me.txtInterestdate)
        Me.Panel1.Controls.Add(Me.dtp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtFDAmount)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtFDAccountNo)
        Me.Panel1.Controls.Add(Me.btnSearchFD)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtReceiptNo)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 246)
        Me.Panel1.TabIndex = 2
        '
        'txtPayAmount
        '
        Me.txtPayAmount.AfterDecimal = 2
        Me.txtPayAmount.BeforeDecimal = 8
        Me.txtPayAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPayAmount.Location = New System.Drawing.Point(377, 100)
        Me.txtPayAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPayAmount.MaxLength = 10
        Me.txtPayAmount.MaxValue = 0
        Me.txtPayAmount.MinValue = 0
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.ReadOnly = True
        Me.txtPayAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtPayAmount.TabIndex = 13
        Me.txtPayAmount.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(283, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pay Amount:"
        '
        'txtIPDDr
        '
        Me.txtIPDDr.AlphaNumeric = True
        Me.txtIPDDr.BackColor = System.Drawing.Color.White
        Me.txtIPDDr.BlankSpace = True
        Me.txtIPDDr.Enabled = False
        Me.txtIPDDr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPDDr.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIPDDr.Location = New System.Drawing.Point(376, 159)
        Me.txtIPDDr.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIPDDr.Mandatory = False
        Me.txtIPDDr.MaxLength = 10
        Me.txtIPDDr.Name = "txtIPDDr"
        Me.txtIPDDr.Size = New System.Drawing.Size(76, 23)
        Me.txtIPDDr.SpecialChar = False
        Me.txtIPDDr.TabIndex = 8
        Me.txtIPDDr.Text = "0"
        '
        'rdoIPDDr
        '
        Me.rdoIPDDr.AutoSize = True
        Me.rdoIPDDr.Location = New System.Drawing.Point(99, 160)
        Me.rdoIPDDr.Name = "rdoIPDDr"
        Me.rdoIPDDr.Size = New System.Drawing.Size(272, 20)
        Me.rdoIPDDr.TabIndex = 7
        Me.rdoIPDDr.TabStop = True
        Me.rdoIPDDr.Text = "Pay amount become greater(IPD Dr):"
        Me.rdoIPDDr.UseVisualStyleBackColor = True
        '
        'rdoIPDCr
        '
        Me.rdoIPDCr.AutoSize = True
        Me.rdoIPDCr.Location = New System.Drawing.Point(100, 130)
        Me.rdoIPDCr.Name = "rdoIPDCr"
        Me.rdoIPDCr.Size = New System.Drawing.Size(249, 20)
        Me.rdoIPDCr.TabIndex = 5
        Me.rdoIPDCr.TabStop = True
        Me.rdoIPDCr.Text = "Pay amount become less(IPD Cr):"
        Me.rdoIPDCr.UseVisualStyleBackColor = True
        '
        'txtIPDCr
        '
        Me.txtIPDCr.AlphaNumeric = True
        Me.txtIPDCr.BackColor = System.Drawing.Color.White
        Me.txtIPDCr.BlankSpace = True
        Me.txtIPDCr.Enabled = False
        Me.txtIPDCr.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPDCr.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIPDCr.Location = New System.Drawing.Point(376, 128)
        Me.txtIPDCr.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIPDCr.Mandatory = False
        Me.txtIPDCr.MaxLength = 10
        Me.txtIPDCr.Name = "txtIPDCr"
        Me.txtIPDCr.Size = New System.Drawing.Size(76, 23)
        Me.txtIPDCr.SpecialChar = False
        Me.txtIPDCr.TabIndex = 6
        Me.txtIPDCr.Text = "0"
        '
        'chkFundTransfer
        '
        Me.chkFundTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.chkFundTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFundTransfer.Location = New System.Drawing.Point(123, 71)
        Me.chkFundTransfer.Name = "chkFundTransfer"
        Me.chkFundTransfer.Size = New System.Drawing.Size(164, 24)
        Me.chkFundTransfer.TabIndex = 4
        Me.chkFundTransfer.Text = "Transfer to Account"
        Me.chkFundTransfer.UseVisualStyleBackColor = False
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = True
        Me.txtAccountNo.BackColor = System.Drawing.Color.White
        Me.txtAccountNo.BlankSpace = True
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccountNo.Location = New System.Drawing.Point(377, 72)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.MaxLength = 10
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 14
        Me.txtAccountNo.TabStop = False
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(306, 75)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(53, 16)
        Me.lblAccount.TabIndex = 15
        Me.lblAccount.Text = "SB No:"
        '
        'txtInterestdate
        '
        Me.txtInterestdate.AlphaNumeric = True
        Me.txtInterestdate.BlankSpace = False
        Me.txtInterestdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestdate.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterestdate.Location = New System.Drawing.Point(120, 42)
        Me.txtInterestdate.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterestdate.Mandatory = False
        Me.txtInterestdate.MaxLength = 10
        Me.txtInterestdate.Name = "txtInterestdate"
        Me.txtInterestdate.Size = New System.Drawing.Size(160, 23)
        Me.txtInterestdate.SpecialChar = True
        Me.txtInterestdate.TabIndex = 13
        Me.txtInterestdate.TabStop = False
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd / MMM / yyyy"
        Me.dtp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(120, 42)
        Me.dtp.MaxDate = New Date(2754, 11, 15, 0, 0, 0, 0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(120, 23)
        Me.dtp.TabIndex = 18
        Me.dtp.Value = New Date(2007, 10, 5, 0, 0, 0, 0)
        Me.dtp.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(312, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(376, 5)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 11
        Me.txtName.TabStop = False
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmount.Location = New System.Drawing.Point(120, 102)
        Me.txtFDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAmount.MaxLength = 10
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAmount.TabIndex = 11
        Me.txtFDAmount.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Account No:"
        '
        'txtFDAccountNo
        '
        Me.txtFDAccountNo.AlphaNumeric = True
        Me.txtFDAccountNo.BlankSpace = False
        Me.txtFDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAccountNo.Location = New System.Drawing.Point(120, 6)
        Me.txtFDAccountNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAccountNo.Mandatory = False
        Me.txtFDAccountNo.MaxLength = 10
        Me.txtFDAccountNo.Name = "txtFDAccountNo"
        Me.txtFDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAccountNo.SpecialChar = True
        Me.txtFDAccountNo.TabIndex = 9
        Me.txtFDAccountNo.TabStop = False
        '
        'btnSearchFD
        '
        Me.btnSearchFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchFD.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchFD.Image = CType(resources.GetObject("btnSearchFD.Image"), System.Drawing.Image)
        Me.btnSearchFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFD.Location = New System.Drawing.Point(256, 5)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 0
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(120, 190)
        Me.txtRemarks.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(472, 48)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 9
        Me.txtRemarks.Text = "Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Remarks:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "IP Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Interest Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(288, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Receipt No:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(376, 42)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 3
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(128, 8)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(80, 24)
        Me.cmbDepositType.TabIndex = 2
        Me.cmbDepositType.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(16, 11)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 16)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Deposit Type:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtSchemeType)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.dtpDate)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.cmbDepositType)
        Me.Panel2.Controls.Add(Me.cmbSchemeType)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 72)
        Me.Panel2.TabIndex = 0
        '
        'txtSchemeType
        '
        Me.txtSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeType.Location = New System.Drawing.Point(128, 44)
        Me.txtSchemeType.Name = "txtSchemeType"
        Me.txtSchemeType.Size = New System.Drawing.Size(212, 23)
        Me.txtSchemeType.TabIndex = 5
        Me.txtSchemeType.TabStop = False
        Me.txtSchemeType.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(336, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Date: "
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(392, 9)
        Me.dtpDate.MaxDate = New Date(9998, 11, 15, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.Value = New Date(2007, 10, 5, 0, 0, 0, 0)
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Enabled = False
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(128, 40)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(192, 24)
        Me.cmbSchemeType.TabIndex = 6
        Me.cmbSchemeType.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Scheme Type:"
        '
        'frmFDPayments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(626, 709)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPayInterest)
        Me.Controls.Add(Me.lvInterest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFDPayments"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interest Payments List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"

    Dim objFDAccount As New clsFDAccount
    Dim objMember As New clsMember
    Dim dtInterest As New DataTable
    Public strAccNo As String
    Dim bolCumulative As Boolean = False
    Dim bolMonth As Boolean = False
    Dim intLedgerNo As Integer
    Dim intLedIntNo As Integer
    Dim dblIPAmt As Double = 0

#End Region

#Region "Sub Routine and Functions"


    'To load SchemeTbl values to the Scheme ComboBox Control
    Sub sbLoadScheme()
        Dim objScheme As New clsFDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.FdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
            cmbSchemeType.SelectedIndex = -1
        End If
        'objScheme = Nothing
    End Sub

    Sub sbSetSchemeMaster()
        If cmbSchemeType.SelectedValue <> 0 Then
            objFDAccount.SchemeCode = cmbSchemeType.SelectedValue
            If objFDAccount.fnCheckScheme() Then
                Dim dtMasterData As DataTable = objFDAccount.FDMasterDetailTbl
                If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                    bolCumulative = True
                    objFDAccount.FDType = "C"
                Else
                    objFDAccount.FDType = "N"
                End If
                bolMonth = IIf(dtMasterData.Rows(0).Item("CalType") = "M", True, False)

            Else
                MsgBox("Load failed due to internal error", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Sub sbLoadFD()
        If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or txtFDAccountNo.Text <> "SCC" Then
            Dim objDT As DataTable
            Dim objIntTable As DataTable
            Dim FDAmount As Double
            Dim dblInterest As Double
            If txtSchemeType.Text = "Double" Or txtSchemeType.Text = "Triple" Or txtSchemeType.Text = "Lakshadhipathy(87313)" Or txtSchemeType.Text = "Lakshadhipathy(76640)" Or txtSchemeType.Text = "Lakshadhipathy(65980)" Or txtSchemeType.Text = "Lakshadhipathy(53755)" Or txtSchemeType.Text = "Lakshadhipathy(49196)" Then
                If objFDAccount.fnGetDoubleThriableLakshadipathiDetails(txtFDAccountNo.Text) Then
                    sbClear()
                    objDT = objFDAccount.FDTable
                    txtName.Text = objDT.Rows(0).Item("Name")
                    txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
                    'txtAccountNo.Text = objDT.Rows(0).Item("AccountNo")

                    If Not objFDAccount.InterestTable Is Nothing Then
                        objIntTable = objFDAccount.InterestTable
                        Dim intCounter As Integer = 0
                        Dim lvItem As New ListViewItem
                        lvItem.UseItemStyleForSubItems = False
                        lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                        If lvInterest.Columns.Count > 5 Then
                            lvInterest.Columns.RemoveAt(5)
                        End If
                        While intCounter < objIntTable.Rows.Count
                            lvItem = lvInterest.Items.Add(intCounter + 1)
                            lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                            Dim dt As Date = Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy")
                            If DateDiff(DateInterval.Day, dt, Date.Today) > 0 Then
                                lvItem.ForeColor = Color.Blue
                            End If
                            lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                            dblInterest += objIntTable.Rows(intCounter).Item("IntAmount")
                            lvItem.SubItems.Add(dblInterest)
                            'lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                            lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                            intCounter += 1
                        End While
                    End If
                    txtFDAccountNo.ReadOnly = True
                    txtName.ReadOnly = True
                    cmbDepositType.Enabled = False
                    txtFDAmount.ReadOnly = False
                    txtInterestdate.ReadOnly = True
                End If
                txtName.Focus()
                sbSetSchemeMaster()

            Else
                If objFDAccount.fnGetFDDetails(txtFDAccountNo.Text) Then
                    sbClear()
                    objDT = objFDAccount.FDTable
                    txtName.Text = objDT.Rows(0).Item("Name")
                    cmbSchemeType.SelectedValue = objDT.Rows(0).Item("SchemeCode")

                    txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
                    'txtAccountNo.Text = objDT.Rows(0).Item("AccountNo")

                    If Not objFDAccount.InterestTable Is Nothing Then
                        objIntTable = objFDAccount.InterestTable
                        Dim intCounter As Integer = 0
                        Dim lvItem As New ListViewItem
                        lvItem.UseItemStyleForSubItems = False
                        lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                        If lvInterest.Columns.Count > 5 Then
                            lvInterest.Columns.RemoveAt(5)
                        End If
                        While intCounter < objIntTable.Rows.Count
                            lvItem = lvInterest.Items.Add(intCounter + 1)
                            lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                            Dim dt As Date = Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy")
                            If DateDiff(DateInterval.Day, dt, Date.Today) > 0 Then
                                lvItem.ForeColor = Color.Blue
                            End If
                            lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                            dblInterest += objIntTable.Rows(intCounter).Item("IntAmount")
                            lvItem.SubItems.Add(dblInterest)
                            'lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                            lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                            intCounter += 1
                        End While
                    End If
                    txtFDAccountNo.ReadOnly = True
                    txtName.ReadOnly = True
                    cmbDepositType.Enabled = False
                    txtFDAmount.ReadOnly = False
                    txtInterestdate.ReadOnly = True
                End If
                txtName.Focus()
                sbSetSchemeMaster()
            End If
        End If


    End Sub

    Sub sbClear()
        txtIPDCr.ResetText()
        txtIPDDr.ResetText()
        txtFDAmount.ResetText()
        lvInterest.Items.Clear()
        txtInterestdate.ResetText()
        txtReceiptNo.ResetText()
        'txtRemarks.ResetText()
        txtRemarks.Text = "Payment"
        cmbDepositType.Enabled = True
        txtFDAmount.ReadOnly = False
        txtInterestdate.ReadOnly = False
        txtPayAmount.ResetText()
    End Sub

    Function fnCheck() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Please select the type of deposit", MsgBoxStyle.Exclamation)
            cmbDepositType.Focus()
            Return False
        ElseIf Trim(txtFDAccountNo.Text) = "" Then
            MsgBox("Please Select the account no.", MsgBoxStyle.Exclamation)
            txtFDAccountNo.Focus()
            Return False
        ElseIf chkFundTransfer.Checked = True And txtAccountNo.Text = String.Empty Then
            MsgBox("Amount cannot be transfered to SB because of non availability of SB account no.", MsgBoxStyle.Exclamation)
            chkFundTransfer.Focus()
            Return False
        ElseIf Trim(txtFDAmount.Text) = "" Then
            MsgBox("Amount cannot be null", MsgBoxStyle.Exclamation)
            txtFDAmount.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = "" Then
            MsgBox("Receipt no. cannot be null", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Function fnSetData() As Boolean

        If lvInterest.SelectedItems(0).SubItems(4).Text = "Provision" Then

            intLedgerNo = 14

        ElseIf lvInterest.SelectedItems(0).SubItems(4).Text = "Due" Then
            Select Case cmbDepositType.SelectedItem
                Case "FD"
                    intLedgerNo = 30
                Case "ENNVY"
                    intLedgerNo = 55
                Case "SCC"
                    intLedgerNo = 56
            End Select

        End If

        Return True
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        If txtSchemeType.Text = "Double" Or txtSchemeType.Text = "Triple" Or txtSchemeType.Text = "Lakshadhipathy(87313)" Or txtSchemeType.Text = "Lakshadhipathy(76640)" Or txtSchemeType.Text = "Lakshadhipathy(65980)" Or txtSchemeType.Text = "Lakshadhipathy(53755)" Or txtSchemeType.Text = "Lakshadhipathy(49196)" Then
            strSQL = "Update fdcumulativeinttbl set status='Paid',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "',CollectDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "' where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
        Else
            If bolCumulative = False Then
                strSQL = "Update fdintpaymentstbl set status='Paid',CollectDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "'  where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
            Else
                strSQL = "Update fdcumulativeinttbl set status='Paid',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "',CollectDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "' where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
            End If
        End If
        fnExecuteNonQuery(strSQL, objTrans)

        ' Inset into FdPosting Deatils 
        strSQL = "insert into fdintpostingstbl(FDNo,TrDate,Amount,Remarks,Voucherno,RefNo) values('" & Trim(txtFDAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd") & "','" & Trim(txtFDAmount.Text) & "','" & Trim(txtRemarks.Text) & "','" & lngVoucherNo & "','" & Trim(txtReceiptNo.Text) & "')"
        fnExecuteNonQuery(strSQL, objTrans)

        If chkFundTransfer.Checked = True Then

            Dim strNarration As String = "Transfered to " & txtAccountNo.Text

            Dim strType As String
            strType = Mid(txtAccountNo.Text, 1, 2)
            Select Case strType
                Case "SB"

                    'Transaction Entry
                    Dim strsql As String = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtPayAmount.Text) & "','0','" & Trim(txtPayAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtPayAmount.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccountNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    ''voucher details
                    fnVoucherEnterMain(lngVoucherNo, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpDate.Value, txtFDAmount.Text, "Transfered by " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpDate.Value, "Interest by account " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 1, "Y", objTrans)
                    'Credit accounts
                    If rdoIPDCr.Checked = True Then
                        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Reverse Amt from IP " & txtFDAccountNo.Text, "To", 30, 0, Val(txtIPDCr.Text), 2, "Y", objTrans)
                    End If
                    'Debit accounts 
                    If rdoIPDDr.Checked = True Then
                        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Reverse Amt from IP " & txtFDAccountNo.Text, "By", 30, Val(txtIPDDr.Text), 0, 2, "Y", objTrans)
                    End If
                    'Credit accounts
                    fnVoucherEnterSub(lngVoucherNo, 7, txtAccountNo.Text, dtpDate.Value, "Interest credited by account " & txtFDAccountNo.Text, "To", 10, 0, Val(txtPayAmount.Text), 2, "Y", objTrans)

                Case "CA"

                    'Transaction Entry
                    Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccountNo.Text) & "','" & Format(dtpDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtFDAmount.Text) & "','0','" & Trim(txtFDAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtFDAmount.Text) & "','0','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccountNo.Text) & "' group by CAccountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    ''voucher details
                    fnVoucherEnterMain(lngVoucherNo, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpDate.Value, txtFDAmount.Text, "Transfered by " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpDate.Value, "Interest by account " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 1, "Y", objTrans)

                    'Credit accounts
                    If rdoIPDCr.Checked = True Then
                        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Reverse Amt from IP " & txtFDAccountNo.Text, "To", 30, 0, Val(txtIPDCr.Text), 2, "Y", objTrans)
                    End If
                    'Debit accounts 
                    If rdoIPDDr.Checked = True Then
                        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Reverse Amt from IP " & txtFDAccountNo.Text, "By", 30, Val(txtIPDDr.Text), 0, 2, "Y", objTrans)
                    End If

                    'Credit accounts
                    fnVoucherEnterSub(lngVoucherNo, 7, txtAccountNo.Text, dtpDate.Value, "Interest credited by account " & txtFDAccountNo.Text, "To", 11, 0, Val(txtPayAmount.Text), 2, "Y", objTrans)

            End Select

        Else
            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtFDAccountNo.Text, txtReceiptNo.Text, dtpDate.Value, txtFDAmount.Text, "Interest to account " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Interest to account " & txtFDAccountNo.Text, "To", 1, 0, Val(txtPayAmount.Text), 2, "Y", objTrans)

            'Credit accounts
            If rdoIPDCr.Checked = True Then
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Reverse Amt from IP " & txtFDAccountNo.Text, "To", 30, 0, Val(txtIPDCr.Text), 2, "Y", objTrans)
            End If
            'Debit accounts 
            If rdoIPDDr.Checked = True Then
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpDate.Value, "Reverse Amt from IP " & txtFDAccountNo.Text, "By", 30, Val(txtIPDDr.Text), 0, 2, "Y", objTrans)
            End If

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpDate.Value, "Interest by account " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 1, "Y", objTrans)

        End If

        Return True

    End Function

    Public Function fnCheckReceiptNo() As Boolean
        Dim chrFDType As Char

        If bolCumulative = True Then
            chrFDType = "C"
        Else
            chrFDType = "N"
        End If
        If objFDAccount.fnFDReceiptNo(chrFDType, Trim(txtReceiptNo.Text)) Then
            MsgBox("ReceiptNo already exist, enter another receipt no.", MsgBoxStyle.Exclamation, "Deposit Module")
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnClear()

        txtFDAmount.Text = String.Empty
        txtInterestdate.Text = String.Empty
        txtName.Text = String.Empty
        txtReceiptNo.Text = String.Empty
        txtRemarks.Text = String.Empty

    End Function

#End Region

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        txtFDAccountNo.ResetText()
        Me.Close()

    End Sub

    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click

        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strFDNo = ""
            objFDSearch.strForm = "FDPayment"
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFD()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select The Deposit Type ")
            cmbDepositType.Focus()
        End If

    End Sub

    Private Sub frmFDPayments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtSchemeType.Text = "Double" Or txtSchemeType.Text = "Triple" Or txtSchemeType.Text = "Lakshadhipathy(87313)" Or txtSchemeType.Text = "Lakshadhipathy(76640)" Or txtSchemeType.Text = "Lakshadhipathy(65980)" Or txtSchemeType.Text = "Lakshadhipathy(53755)" Or txtSchemeType.Text = "Lakshadhipathy(49196)" Then
        Else
            sbLoadScheme()
        End If

        dtpDate.Value = Date.Today
        sbLoadFD()

    End Sub

    Private Sub lvInterest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInterest.DoubleClick

        If lvInterest.SelectedItems.Count > 0 Then
            If lvInterest.SelectedItems(0).SubItems(4).Text <> "Paid" Then
                dtp.Value = lvInterest.SelectedItems(0).SubItems(2).Text
                If DateDiff(DateInterval.DayOfYear, dtp.Value, Date.Today, FirstDayOfWeek.System) < 0 Then
                    MsgBox("Maturity date is not yet over,intrest cannot be paied", MsgBoxStyle.Exclamation, "Deposit Module")
                Else
                    txtFDAmount.Text = lvInterest.SelectedItems(0).SubItems(1).Text
                    txtPayAmount.Text = lvInterest.SelectedItems(0).SubItems(1).Text
                    txtInterestdate.Text = lvInterest.SelectedItems(0).SubItems(2).Text
                End If
            End If
        End If

    End Sub

    Private Sub btnPayInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayInterest.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnCheckReceiptNo() Then
                        If fnGenerateVoucher(objTrans) Then
                            fnLogEntry(pbUserId, "FD interest paid to " & txtFDAccountNo.Text, Date.Now, "New Deposit", objTrans)
                            objTrans.Commit()
                            MsgBox("Interest is successfully paid to the account '" & txtFDAccountNo.Text & "'", MsgBoxStyle.Information, "Deposit Module")
                            sbLoadFD()
                        Else
                            MsgBox("Interest cannot be paid to the account '" & txtFDAccountNo.Text & "'", MsgBoxStyle.Information, "Deposit Module")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try


    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDPayments
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDPayments
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDPayments
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDPayments)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        If txtFDAccountNo.Text = "" Then
            Select Case cmbDepositType.SelectedItem
                Case "FD"
                    txtFDAccountNo.Text = "FD"
                Case "ENNVY"
                    txtFDAccountNo.Text = "ENNVY"
                Case "SCC"
                    txtFDAccountNo.Text = "SCC"
            End Select
        End If

    End Sub

    Private Sub txtFDAccountNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAccountNo.TextChanged
        Select Case cmbDepositType.SelectedItem

            Case "FD"
                If txtFDAccountNo.Text.StartsWith("FD") = True Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
            Case "ENNVY"
                If txtFDAccountNo.Text.StartsWith("ENNVY") = True Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
            Case "SCC"
                If txtFDAccountNo.Text.StartsWith("SCC") = True Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
        End Select
    End Sub

    Private Sub chkFundTransfer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFundTransfer.CheckedChanged

        Dim objDT As DataTable

        If chkFundTransfer.Checked = True Then

            Dim objAccountSelection As New frmAccountSelection
            objAccountSelection.ShowDialog(Me)
            txtAccountNo.Text = objAccountSelection.strAccountNo
            objAccountSelection.Dispose()

            Dim strType As String
            strType = Mid(txtAccountNo.Text, 1, 2)
            Select Case strType
                Case "SB"
                    lblAccount.Text = "SB No. :"
                Case "CA"
                    lblAccount.Text = "CA No. :"
            End Select

        ElseIf chkFundTransfer.Checked = False Then
            lblAccount.Text = "SB No. :"
            txtAccountNo.ResetText()
        End If

    End Sub



    Private Sub txtIPDCr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIPDCr.TextChanged
        dblIPAmt = Val(txtFDAmount.Text)
        txtPayAmount.Text = dblIPAmt - Val(txtIPDCr.Text)
    End Sub

    Private Sub rdoIPDCr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoIPDCr.CheckedChanged
        If rdoIPDCr.Checked = True Then
            txtIPDCr.Enabled = True
            txtIPDDr.Enabled = False
        ElseIf rdoIPDCr.Checked = False Then
            txtIPDDr.Enabled = False
        End If
    End Sub

    Private Sub rdoIPDDr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoIPDDr.CheckedChanged
        If rdoIPDDr.Checked = True Then
            txtIPDDr.Enabled = True
            txtIPDCr.Enabled = False
        ElseIf rdoIPDDr.Checked = False Then
            txtIPDDr.Enabled = False
        End If
    End Sub

    Private Sub txtIPDDr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIPDDr.TextChanged
        dblIPAmt = Val(txtFDAmount.Text)
        txtPayAmount.Text = dblIPAmt + Val(txtIPDDr.Text)
    End Sub

    
End Class
