<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenewalFDList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRenewalFDList))
        Me.lvRenewalList = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.FdNo = New System.Windows.Forms.ColumnHeader
        Me.Renewal_Date = New System.Windows.Forms.ColumnHeader
        Me.FDAdditionalDetailID = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbFDType = New System.Windows.Forms.ComboBox
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.dtpFDMatDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDIntAmount = New BankControls.NumericControl
        Me.txtFDMatAmount = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBondNo = New BankControls.NumericControl
        Me.txtFDAmount = New BankControls.NumericControl
        Me.lblAType = New System.Windows.Forms.Label
        Me.dtpFDDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDDays = New BankControls.NumericControl
        Me.txtFDMonths = New BankControls.NumericControl
        Me.txtFDYears = New BankControls.NumericControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label111 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtFDROI = New BankControls.NumericControl
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvRenewalList
        '
        Me.lvRenewalList.BackColor = System.Drawing.Color.AliceBlue
        Me.lvRenewalList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.FdNo, Me.Renewal_Date, Me.FDAdditionalDetailID})
        Me.lvRenewalList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRenewalList.FullRowSelect = True
        Me.lvRenewalList.GridLines = True
        Me.lvRenewalList.Location = New System.Drawing.Point(10, 33)
        Me.lvRenewalList.Name = "lvRenewalList"
        Me.lvRenewalList.Size = New System.Drawing.Size(321, 563)
        Me.lvRenewalList.TabIndex = 6
        Me.lvRenewalList.UseCompatibleStateImageBehavior = False
        Me.lvRenewalList.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        '
        'FdNo
        '
        Me.FdNo.Text = "FD No."
        Me.FdNo.Width = 120
        '
        'Renewal_Date
        '
        Me.Renewal_Date.Text = "Renewal Date"
        Me.Renewal_Date.Width = 130
        '
        'FDAdditionalDetailID
        '
        Me.FDAdditionalDetailID.Text = "FD Additional Detail ID"
        Me.FDAdditionalDetailID.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Renewaled FD List :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbFDType)
        Me.Panel1.Controls.Add(Me.cmbSchemeType)
        Me.Panel1.Controls.Add(Me.dtpFDMatDate)
        Me.Panel1.Controls.Add(Me.txtFDIntAmount)
        Me.Panel1.Controls.Add(Me.txtFDMatAmount)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBondNo)
        Me.Panel1.Controls.Add(Me.txtFDAmount)
        Me.Panel1.Controls.Add(Me.lblAType)
        Me.Panel1.Controls.Add(Me.dtpFDDate)
        Me.Panel1.Controls.Add(Me.txtFDDays)
        Me.Panel1.Controls.Add(Me.txtFDMonths)
        Me.Panel1.Controls.Add(Me.txtFDYears)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label111)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.txtFDROI)
        Me.Panel1.Enabled = False
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(370, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 259)
        Me.Panel1.TabIndex = 10
        Me.Panel1.TabStop = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(63, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(113, 65)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(476, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 154
        Me.txtName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Scheme Type:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 16)
        Me.Label15.TabIndex = 152
        Me.Label15.Text = "Intrest Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(-195, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "Scheme Type:"
        '
        'cmbFDType
        '
        Me.cmbFDType.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cmbFDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFDType.Enabled = False
        Me.cmbFDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFDType.ForeColor = System.Drawing.Color.Black
        Me.cmbFDType.Items.AddRange(New Object() {"", "Monthly", "Quarterly", "Half-Yearly", "Yearly"})
        Me.cmbFDType.Location = New System.Drawing.Point(112, 34)
        Me.cmbFDType.Name = "cmbFDType"
        Me.cmbFDType.Size = New System.Drawing.Size(128, 24)
        Me.cmbFDType.TabIndex = 150
        Me.cmbFDType.TabStop = False
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Enabled = False
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(112, 5)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(477, 24)
        Me.cmbSchemeType.TabIndex = 149
        '
        'dtpFDMatDate
        '
        Me.dtpFDMatDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDMatDate.Enabled = False
        Me.dtpFDMatDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDMatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDMatDate.Location = New System.Drawing.Point(410, 94)
        Me.dtpFDMatDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpFDMatDate.Name = "dtpFDMatDate"
        Me.dtpFDMatDate.Size = New System.Drawing.Size(145, 23)
        Me.dtpFDMatDate.TabIndex = 14
        Me.dtpFDMatDate.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'txtFDIntAmount
        '
        Me.txtFDIntAmount.AfterDecimal = 2
        Me.txtFDIntAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDIntAmount.BeforeDecimal = 8
        Me.txtFDIntAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFDIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDIntAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDIntAmount.Location = New System.Drawing.Point(410, 158)
        Me.txtFDIntAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDIntAmount.MaxLength = 10
        Me.txtFDIntAmount.MaxValue = 0
        Me.txtFDIntAmount.MinValue = 0
        Me.txtFDIntAmount.Name = "txtFDIntAmount"
        Me.txtFDIntAmount.ReadOnly = True
        Me.txtFDIntAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDIntAmount.TabIndex = 148
        Me.txtFDIntAmount.TabStop = False
        Me.txtFDIntAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDMatAmount
        '
        Me.txtFDMatAmount.AfterDecimal = 2
        Me.txtFDMatAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.BeforeDecimal = 8
        Me.txtFDMatAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFDMatAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMatAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.Location = New System.Drawing.Point(410, 190)
        Me.txtFDMatAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.MaxLength = 10
        Me.txtFDMatAmount.MaxValue = 0
        Me.txtFDMatAmount.MinValue = 0
        Me.txtFDMatAmount.Name = "txtFDMatAmount"
        Me.txtFDMatAmount.ReadOnly = True
        Me.txtFDMatAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDMatAmount.TabIndex = 147
        Me.txtFDMatAmount.TabStop = False
        Me.txtFDMatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Bond No :"
        '
        'txtBondNo
        '
        Me.txtBondNo.AfterDecimal = 0
        Me.txtBondNo.BeforeDecimal = 8
        Me.txtBondNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBondNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBondNo.Location = New System.Drawing.Point(113, 206)
        Me.txtBondNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBondNo.MaxLength = 10
        Me.txtBondNo.MaxValue = 0
        Me.txtBondNo.MinValue = 0
        Me.txtBondNo.Name = "txtBondNo"
        Me.txtBondNo.Size = New System.Drawing.Size(136, 23)
        Me.txtBondNo.TabIndex = 18
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BackColor = System.Drawing.Color.White
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmount.Location = New System.Drawing.Point(112, 174)
        Me.txtFDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAmount.MaxLength = 11
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.Size = New System.Drawing.Size(137, 23)
        Me.txtFDAmount.TabIndex = 16
        Me.txtFDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAType
        '
        Me.lblAType.AutoSize = True
        Me.lblAType.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblAType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAType.ForeColor = System.Drawing.Color.Black
        Me.lblAType.Location = New System.Drawing.Point(49, 178)
        Me.lblAType.Name = "lblAType"
        Me.lblAType.Size = New System.Drawing.Size(64, 16)
        Me.lblAType.TabIndex = 135
        Me.lblAType.Text = "Amount:"
        '
        'dtpFDDate
        '
        Me.dtpFDDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(113, 94)
        Me.dtpFDDate.MaxDate = New Date(9998, 5, 19, 0, 0, 0, 0)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(146, 23)
        Me.dtpFDDate.TabIndex = 10
        Me.dtpFDDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'txtFDDays
        '
        Me.txtFDDays.AfterDecimal = 0
        Me.txtFDDays.BeforeDecimal = 3
        Me.txtFDDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDDays.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDDays.Location = New System.Drawing.Point(196, 145)
        Me.txtFDDays.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDDays.MaxLength = 3
        Me.txtFDDays.MaxValue = 120
        Me.txtFDDays.MinValue = 0
        Me.txtFDDays.Name = "txtFDDays"
        Me.txtFDDays.Size = New System.Drawing.Size(53, 23)
        Me.txtFDDays.TabIndex = 13
        Me.txtFDDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDMonths
        '
        Me.txtFDMonths.AfterDecimal = 0
        Me.txtFDMonths.BeforeDecimal = 2
        Me.txtFDMonths.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMonths.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDMonths.Location = New System.Drawing.Point(156, 145)
        Me.txtFDMonths.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDMonths.MaxLength = 2
        Me.txtFDMonths.MaxValue = 11
        Me.txtFDMonths.MinValue = 0
        Me.txtFDMonths.Name = "txtFDMonths"
        Me.txtFDMonths.Size = New System.Drawing.Size(32, 23)
        Me.txtFDMonths.TabIndex = 12
        Me.txtFDMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDYears
        '
        Me.txtFDYears.AfterDecimal = 0
        Me.txtFDYears.BeforeDecimal = 2
        Me.txtFDYears.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDYears.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDYears.Location = New System.Drawing.Point(112, 145)
        Me.txtFDYears.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDYears.MaxLength = 2
        Me.txtFDYears.MaxValue = 0
        Me.txtFDYears.MinValue = 0
        Me.txtFDYears.Name = "txtFDYears"
        Me.txtFDYears.Size = New System.Drawing.Size(38, 23)
        Me.txtFDYears.TabIndex = 11
        Me.txtFDYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(306, 192)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 24)
        Me.Label38.TabIndex = 128
        Me.Label38.Text = "Maturity Amt:"
        '
        'Label111
        '
        Me.Label111.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label111.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.Black
        Me.Label111.Location = New System.Drawing.Point(310, 157)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(98, 24)
        Me.Label111.TabIndex = 127
        Me.Label111.Text = "Interest Amt:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(303, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Maturity Date: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(306, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 16)
        Me.Label17.TabIndex = 125
        Me.Label17.Text = "Interest Rate:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label19.Location = New System.Drawing.Point(212, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 16)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "D"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label20.Location = New System.Drawing.Point(164, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 16)
        Me.Label20.TabIndex = 123
        Me.Label20.Text = "M"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label21.Location = New System.Drawing.Point(124, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 16)
        Me.Label21.TabIndex = 122
        Me.Label21.Text = "Y"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(58, 148)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 16)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "Period:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(43, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 16)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "FD Date:"
        '
        'txtFDROI
        '
        Me.txtFDROI.AfterDecimal = 2
        Me.txtFDROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDROI.BeforeDecimal = 8
        Me.txtFDROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDROI.Location = New System.Drawing.Point(410, 126)
        Me.txtFDROI.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDROI.MaxLength = 10
        Me.txtFDROI.MaxValue = 0
        Me.txtFDROI.MinValue = 0
        Me.txtFDROI.Name = "txtFDROI"
        Me.txtFDROI.Size = New System.Drawing.Size(136, 23)
        Me.txtFDROI.TabIndex = 115
        Me.txtFDROI.TabStop = False
        Me.txtFDROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.AliceBlue
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Int_Amt, Me.Int_Date, Me.Status})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.Location = New System.Drawing.Point(368, 292)
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(623, 247)
        Me.lvInterest.TabIndex = 11
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl. No."
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.Width = 130
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.Width = 130
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 130
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
        Me.btnClose.Location = New System.Drawing.Point(885, 556)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 40
        Me.btnClose.Text = "&Close"
        '
        'frmRenewalFDList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 608)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvInterest)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvRenewalList)
        Me.Name = "frmRenewalFDList"
        Me.Text = "frmRenewalFDList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvRenewalList As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents FdNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Renewal_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents FDAdditionalDetailID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpFDMatDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDIntAmount As BankControls.NumericControl
    Friend WithEvents txtFDMatAmount As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBondNo As BankControls.NumericControl
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    Friend WithEvents lblAType As System.Windows.Forms.Label
    Friend WithEvents dtpFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDDays As BankControls.NumericControl
    Friend WithEvents txtFDMonths As BankControls.NumericControl
    Friend WithEvents txtFDYears As BankControls.NumericControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtFDROI As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbFDType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
End Class
