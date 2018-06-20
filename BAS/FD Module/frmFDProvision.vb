Public Class frmFDProvision
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
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFDAccountNo As BankControls.TextControl
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnPayInterest As BankControls.NewButton
    Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInterestdate As BankControls.TextControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSchemeType As System.Windows.Forms.TextBox
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDProvision))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtInterestdate = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker
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
        Me.btnClose = New BankControls.NewButton
        Me.btnPayInterest = New BankControls.NewButton
        Me.Total_Amt = New System.Windows.Forms.ColumnHeader
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label39 = New System.Windows.Forms.Label
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.txtSchemeType = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtInterestdate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtp)
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
        Me.Panel1.Location = New System.Drawing.Point(8, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 166)
        Me.Panel1.TabIndex = 4
        '
        'txtInterestdate
        '
        Me.txtInterestdate.AlphaNumeric = True
        Me.txtInterestdate.BlankSpace = False
        Me.txtInterestdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestdate.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterestdate.Location = New System.Drawing.Point(120, 40)
        Me.txtInterestdate.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterestdate.Mandatory = False
        Me.txtInterestdate.MaxLength = 10
        Me.txtInterestdate.Name = "txtInterestdate"
        Me.txtInterestdate.Size = New System.Drawing.Size(160, 23)
        Me.txtInterestdate.SpecialChar = True
        Me.txtInterestdate.TabIndex = 8
        Me.txtInterestdate.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(296, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Name:"
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd / MMM / yyyy"
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(120, 40)
        Me.dtp.MaxDate = New Date(2754, 11, 15, 0, 0, 0, 0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(120, 22)
        Me.dtp.TabIndex = 126
        Me.dtp.Value = New Date(2007, 10, 5, 0, 0, 0, 0)
        Me.dtp.Visible = False
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(368, 8)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 10
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmount.Location = New System.Drawing.Point(120, 72)
        Me.txtFDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAmount.MaxLength = 10
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtFDAmount.TabIndex = 9
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
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Account No:"
        '
        'txtFDAccountNo
        '
        Me.txtFDAccountNo.AlphaNumeric = True
        Me.txtFDAccountNo.BlankSpace = False
        Me.txtFDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAccountNo.Location = New System.Drawing.Point(120, 8)
        Me.txtFDAccountNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAccountNo.Mandatory = False
        Me.txtFDAccountNo.MaxLength = 10
        Me.txtFDAccountNo.Name = "txtFDAccountNo"
        Me.txtFDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAccountNo.SpecialChar = True
        Me.txtFDAccountNo.TabIndex = 5
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
        Me.btnSearchFD.Location = New System.Drawing.Point(256, 8)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 6
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(120, 104)
        Me.txtRemarks.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(472, 48)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 13
        Me.txtRemarks.Text = "Provision"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Remarks:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Interest Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(296, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Receipt No:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(384, 72)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 12
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.btnClose.Location = New System.Drawing.Point(472, 264)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 40)
        Me.btnClose.TabIndex = 20
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
        Me.btnPayInterest.Location = New System.Drawing.Point(328, 264)
        Me.btnPayInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnPayInterest.Name = "btnPayInterest"
        Me.btnPayInterest.Size = New System.Drawing.Size(136, 40)
        Me.btnPayInterest.TabIndex = 19
        Me.btnPayInterest.Text = "Make provision"
        Me.btnPayInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Total_Amt
        '
        Me.Total_Amt.Text = "Total Amount"
        Me.Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total_Amt.Width = 103
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Int_Date.Width = 113
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
        Me.Panel2.Location = New System.Drawing.Point(8, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 72)
        Me.Panel2.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(320, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "Date: "
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(368, 8)
        Me.dtpDate.MaxDate = New Date(9998, 11, 15, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Value = New Date(2007, 10, 5, 0, 0, 0, 0)
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(16, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 16)
        Me.Label39.TabIndex = 129
        Me.Label39.Text = "Deposit Type:"
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(120, 8)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(80, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Enabled = False
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(120, 40)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(192, 24)
        Me.cmbSchemeType.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Scheme Type:"
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 74
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
        Me.lvInterest.Location = New System.Drawing.Point(8, 312)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(608, 317)
        Me.lvInterest.TabIndex = 21
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Int_Amt.Width = 131
        '
        'txtSchemeType
        '
        Me.txtSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeType.Location = New System.Drawing.Point(120, 44)
        Me.txtSchemeType.Name = "txtSchemeType"
        Me.txtSchemeType.Size = New System.Drawing.Size(212, 23)
        Me.txtSchemeType.TabIndex = 131
        Me.txtSchemeType.Visible = False
        '
        'frmFDProvision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(624, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPayInterest)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lvInterest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFDProvision"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FD Provision"
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
                    'txtFDAccountNo.ReadOnly = True
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

        txtFDAmount.ResetText()
        lvInterest.Items.Clear()
        txtInterestdate.ResetText()
        txtReceiptNo.ResetText()
        'txtRemarks.ResetText()
        txtRemarks.Text = "Provision"
        cmbDepositType.Enabled = True
        txtFDAmount.ReadOnly = False
        txtInterestdate.ReadOnly = False

    End Sub

    Function fnCheck() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Please select the type of deposit", MsgBoxStyle.Exclamation)
            cmbDepositType.Focus()
            Return False
        ElseIf Trim(txtFDAccountNo.Text) = "" Then
            MsgBox("Please select the account no.", MsgBoxStyle.Exclamation)
            txtFDAccountNo.Focus()
            Return False
        ElseIf Trim(txtFDAmount.Text) = "" Then
            MsgBox("Amount cannot be null", MsgBoxStyle.Exclamation)
            txtFDAmount.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = "" Then
            MsgBox("Receipt no cannot be null", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Function fnSetData() As Boolean
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                intLedgerNo = 30
            Case "ENNVY"
                intLedgerNo = 55
            Case "SCC"
                intLedgerNo = 56
        End Select
        Return True
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        If txtSchemeType.Text = "Double" Or txtSchemeType.Text = "Triple" Or txtSchemeType.Text = "Lakshadhipathy(87313)" Or txtSchemeType.Text = "Lakshadhipathy(76640)" Or txtSchemeType.Text = "Lakshadhipathy(65980)" Or txtSchemeType.Text = "Lakshadhipathy(53755)" Or txtSchemeType.Text = "Lakshadhipathy(49196)" Then
            strSQL = "Update fdcumulativeinttbl set status='Provision',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "',CollectDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "' where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
        Else
            If bolCumulative = False Then
                strSQL = "Update fdintpaymentstbl set status='Provision'  where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
            Else
                strSQL = "Update fdcumulativeinttbl set status='Provision' where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
            End If
        End If
        fnExecuteNonQuery(strSQL, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtFDAccountNo.Text, txtReceiptNo.Text, dtpDate.Value, txtFDAmount.Text, "Interest to account " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpDate.Value, "Interest to account " & txtFDAccountNo.Text, "To", 14, 0, Val(txtFDAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpDate.Value, "Interest by account " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 2, "Y", objTrans)

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
            objFDSearch.strForm = "Provision"
            objFDSearch.strFDNo = ""
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFD()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select the deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
        End If

    End Sub

    Private Sub frmFDPayments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtSchemeType.Text = "Double" Or txtSchemeType.Text = "Triple" Or txtSchemeType.Text = "Lakshadhipathy(87313)" Or txtSchemeType.Text = "Lakshadhipathy(76640)" Or txtSchemeType.Text = "Lakshadhipathy(65980)" Or txtSchemeType.Text = "Lakshadhipathy(53755)" Or txtSchemeType.Text = "Lakshadhipathy(49196)ss" Then
        Else
            sbLoadScheme()
        End If

        dtpDate.Value = Date.Today
        sbLoadFD()

    End Sub

    Private Sub lvInterest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInterest.DoubleClick
        If lvInterest.SelectedItems.Count > 0 Then
            If lvInterest.SelectedItems(0).SubItems(4).Text = "Due" Then
                If lvInterest.SelectedItems(0).SubItems(4).Text = "Provision" Then
                    MsgBox("Proviosion is already made for the quater", MsgBoxStyle.Exclamation, "Deposit Module")
                Else
                    dtp.Value = lvInterest.SelectedItems(0).SubItems(2).Text
                    If DateDiff(DateInterval.DayOfYear, dtp.Value, Date.Today, FirstDayOfWeek.System) < 0 Then
                        MsgBox("Maturity date is not yet over,intrest cannot be posted", MsgBoxStyle.Exclamation, "Deposit Module")
                    Else
                        txtFDAmount.Text = lvInterest.SelectedItems(0).SubItems(1).Text
                        txtInterestdate.Text = lvInterest.SelectedItems(0).SubItems(2).Text
                    End If
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
                            objTrans.Commit()
                            MsgBox("Interest is successfully posted to the account '" & txtFDAccountNo.Text & "'", MsgBoxStyle.Information, "Deposit Module")
                            sbLoadFD()
                        Else
                            MsgBox("Interest cannot be posted to the account '" & txtFDAccountNo.Text & "'", MsgBoxStyle.Information, "Deposit Module")
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

    'Private Sub txtFDAccountNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAccountNo.TextChanged
    '    Select Case cmbDepositType.SelectedItem

    '        Case "FD"
    '            If txtFDAccountNo.Text.StartsWith("FD") = True Then
    '                txtFDAccountNo.Undo()
    '                txtFDAccountNo.ClearUndo()
    '            End If
    '        Case "ENNVY"
    '            If txtFDAccountNo.Text.StartsWith("ENNVY") = True Then
    '                txtFDAccountNo.Undo()
    '                txtFDAccountNo.ClearUndo()
    '            End If
    '        Case "SCC"
    '            If txtFDAccountNo.Text.StartsWith("SCC") = True Then
    '                txtFDAccountNo.Undo()
    '                txtFDAccountNo.ClearUndo()
    '            End If
    '    End Select
    'End Sub

    Private Sub txtFDAccountNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAccountNo.LostFocus

        sbLoadFD()
    End Sub

    Private Sub txtFDAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDAmount.TextChanged

    End Sub
End Class
