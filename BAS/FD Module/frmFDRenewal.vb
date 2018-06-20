Imports System.Math

Public Class frmFDRenewal
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOldFDNo As BankControls.TextControl
    Friend WithEvents dtpMaturiedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    'Friend WithEvents txtFDIntAmount As BankControls.NumericControl
    Friend WithEvents Label33 As System.Windows.Forms.Label
    'Friend WithEvents txtBondNo As BankControls.NumericControl
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnFDList As BankControls.NewButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOldBondNo As BankControls.NumericControl
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents grpFDType As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbFDType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCInterest As System.Windows.Forms.Label
    Friend WithEvents chkCorrection As System.Windows.Forms.CheckBox
    Friend WithEvents Correction As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorrectionAmount As BankControls.NumericControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents chkSubtract As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdd As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCInterest As BankControls.NumericControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    Friend WithEvents lblAType As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As BankControls.NewButton
    Friend WithEvents txtBondNo As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFDMatAmount As BankControls.NumericControl
    Friend WithEvents txtFDIntAmount As BankControls.NumericControl
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents dtpNextDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents StandardMtd As System.Windows.Forms.RadioButton
    Friend WithEvents BTMMethod As System.Windows.Forms.RadioButton
    Friend WithEvents NaveenSirMtd As System.Windows.Forms.RadioButton
    Friend WithEvents txtSchemeType As System.Windows.Forms.TextBox
    Friend WithEvents dtpFDMatDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDRenewal))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpMaturiedDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnFDList = New BankControls.NewButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtOldFDNo = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.txtOldBondNo = New BankControls.NumericControl
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Total_Amt = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.grpFDType = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbFDType = New System.Windows.Forms.ComboBox
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.lblCInterest = New System.Windows.Forms.Label
        Me.chkCorrection = New System.Windows.Forms.CheckBox
        Me.Correction = New System.Windows.Forms.GroupBox
        Me.txtCorrectionAmount = New BankControls.NumericControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.chkSubtract = New System.Windows.Forms.CheckBox
        Me.chkAdd = New System.Windows.Forms.CheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtCInterest = New BankControls.NumericControl
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.txtFDAmount = New BankControls.NumericControl
        Me.lblAType = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.StandardMtd = New System.Windows.Forms.RadioButton
        Me.BTMMethod = New System.Windows.Forms.RadioButton
        Me.NaveenSirMtd = New System.Windows.Forms.RadioButton
        Me.btnCalculate = New BankControls.NewButton
        Me.Label40 = New System.Windows.Forms.Label
        Me.dtpNextDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFDMatDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDIntAmount = New BankControls.NumericControl
        Me.txtFDMatAmount = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBondNo = New BankControls.NumericControl
        Me.cmbPeriod = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtSchemeType = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        Me.grpFDType.SuspendLayout()
        Me.Correction.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmbDepositType)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.dtpMaturiedDate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnFDList)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtOldFDNo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.txtOldBondNo)
        Me.Panel2.Location = New System.Drawing.Point(126, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 120)
        Me.Panel2.TabIndex = 0
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY"})
        Me.cmbDepositType.Location = New System.Drawing.Point(120, 16)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(152, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(16, 19)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 16)
        Me.Label39.TabIndex = 137
        Me.Label39.Text = "Deposit Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Old Bond No:"
        '
        'dtpMaturiedDate
        '
        Me.dtpMaturiedDate.CustomFormat = "dd -  MMM - yyyy"
        Me.dtpMaturiedDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturiedDate.Location = New System.Drawing.Point(424, 48)
        Me.dtpMaturiedDate.MaxDate = New Date(9998, 11, 30, 0, 0, 0, 0)
        Me.dtpMaturiedDate.Name = "dtpMaturiedDate"
        Me.dtpMaturiedDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpMaturiedDate.TabIndex = 4
        Me.dtpMaturiedDate.Value = New Date(2007, 9, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(296, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Old MaturityDate:"
        '
        'btnFDList
        '
        Me.btnFDList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFDList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFDList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFDList.ForeColor = System.Drawing.Color.Black
        Me.btnFDList.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFDList.Image = CType(resources.GetObject("btnFDList.Image"), System.Drawing.Image)
        Me.btnFDList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFDList.Location = New System.Drawing.Point(569, 16)
        Me.btnFDList.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFDList.Name = "btnFDList"
        Me.btnFDList.Size = New System.Drawing.Size(24, 24)
        Me.btnFDList.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(368, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "FD No:"
        '
        'txtOldFDNo
        '
        Me.txtOldFDNo.AlphaNumeric = True
        Me.txtOldFDNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtOldFDNo.BlankSpace = False
        Me.txtOldFDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldFDNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldFDNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtOldFDNo.Location = New System.Drawing.Point(424, 17)
        Me.txtOldFDNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtOldFDNo.Mandatory = False
        Me.txtOldFDNo.MaxLength = 10
        Me.txtOldFDNo.Name = "txtOldFDNo"
        Me.txtOldFDNo.ReadOnly = True
        Me.txtOldFDNo.Size = New System.Drawing.Size(144, 23)
        Me.txtOldFDNo.SpecialChar = True
        Me.txtOldFDNo.TabIndex = 1
        Me.txtOldFDNo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(120, 80)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(384, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 5
        Me.txtName.TabStop = False
        '
        'txtOldBondNo
        '
        Me.txtOldBondNo.AfterDecimal = 2
        Me.txtOldBondNo.BeforeDecimal = 8
        Me.txtOldBondNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldBondNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOldBondNo.Location = New System.Drawing.Point(120, 48)
        Me.txtOldBondNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOldBondNo.MaxLength = 10
        Me.txtOldBondNo.MaxValue = 0
        Me.txtOldBondNo.MinValue = 0
        Me.txtOldBondNo.Name = "txtOldBondNo"
        Me.txtOldBondNo.Size = New System.Drawing.Size(152, 23)
        Me.txtOldBondNo.TabIndex = 3
        Me.txtOldBondNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lvInterest
        '
        Me.lvInterest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lvInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lvInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Int_Amt, Me.Int_Date, Me.Total_Amt})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.HideSelection = False
        Me.lvInterest.Location = New System.Drawing.Point(126, 368)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(728, 192)
        Me.lvInterest.TabIndex = 25
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 74
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Int_Amt.Width = 100
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Int_Date.Width = 189
        '
        'Total_Amt
        '
        Me.Total_Amt.Text = "Total Amount"
        Me.Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total_Amt.Width = 130
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(622, 568)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 27
        Me.btnOk.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(742, 568)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "&Close"
        '
        'grpFDType
        '
        Me.grpFDType.Controls.Add(Me.txtSchemeType)
        Me.grpFDType.Controls.Add(Me.Label15)
        Me.grpFDType.Controls.Add(Me.Label13)
        Me.grpFDType.Controls.Add(Me.cmbFDType)
        Me.grpFDType.Controls.Add(Me.cmbSchemeType)
        Me.grpFDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFDType.ForeColor = System.Drawing.Color.Black
        Me.grpFDType.Location = New System.Drawing.Point(8, 128)
        Me.grpFDType.Name = "grpFDType"
        Me.grpFDType.Size = New System.Drawing.Size(968, 48)
        Me.grpFDType.TabIndex = 6
        Me.grpFDType.TabStop = False
        Me.grpFDType.Text = "Deposit Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(731, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Intrest Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 61
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
        Me.cmbFDType.Location = New System.Drawing.Point(835, 16)
        Me.cmbFDType.Name = "cmbFDType"
        Me.cmbFDType.Size = New System.Drawing.Size(128, 24)
        Me.cmbFDType.TabIndex = 8
        Me.cmbFDType.TabStop = False
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(118, 16)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(581, 24)
        Me.cmbSchemeType.TabIndex = 7
        '
        'lblCInterest
        '
        Me.lblCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCInterest.ForeColor = System.Drawing.Color.Black
        Me.lblCInterest.Location = New System.Drawing.Point(673, 122)
        Me.lblCInterest.Name = "lblCInterest"
        Me.lblCInterest.Size = New System.Drawing.Size(104, 16)
        Me.lblCInterest.TabIndex = 140
        Me.lblCInterest.Text = "Corrected Int:"
        Me.lblCInterest.Visible = False
        '
        'chkCorrection
        '
        Me.chkCorrection.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.chkCorrection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorrection.ForeColor = System.Drawing.Color.Black
        Me.chkCorrection.Location = New System.Drawing.Point(507, 164)
        Me.chkCorrection.Name = "chkCorrection"
        Me.chkCorrection.Size = New System.Drawing.Size(96, 16)
        Me.chkCorrection.TabIndex = 20
        Me.chkCorrection.Text = "Correction"
        Me.chkCorrection.UseVisualStyleBackColor = False
        Me.chkCorrection.Visible = False
        '
        'Correction
        '
        Me.Correction.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Correction.Controls.Add(Me.txtCorrectionAmount)
        Me.Correction.Controls.Add(Me.Panel6)
        Me.Correction.Controls.Add(Me.Label35)
        Me.Correction.Enabled = False
        Me.Correction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Correction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correction.ForeColor = System.Drawing.Color.Black
        Me.Correction.Location = New System.Drawing.Point(400, 155)
        Me.Correction.Name = "Correction"
        Me.Correction.Size = New System.Drawing.Size(139, 29)
        Me.Correction.TabIndex = 21
        Me.Correction.TabStop = False
        Me.Correction.Visible = False
        '
        'txtCorrectionAmount
        '
        Me.txtCorrectionAmount.AfterDecimal = 2
        Me.txtCorrectionAmount.BeforeDecimal = 10
        Me.txtCorrectionAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectionAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCorrectionAmount.Location = New System.Drawing.Point(176, 29)
        Me.txtCorrectionAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCorrectionAmount.MaxValue = 0
        Me.txtCorrectionAmount.MinValue = 0
        Me.txtCorrectionAmount.Name = "txtCorrectionAmount"
        Me.txtCorrectionAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtCorrectionAmount.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel6.Controls.Add(Me.chkSubtract)
        Me.Panel6.Controls.Add(Me.chkAdd)
        Me.Panel6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(8, 24)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(152, 32)
        Me.Panel6.TabIndex = 22
        '
        'chkSubtract
        '
        Me.chkSubtract.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubtract.Location = New System.Drawing.Point(64, 8)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(80, 16)
        Me.chkSubtract.TabIndex = 24
        Me.chkSubtract.Text = "Subtract"
        '
        'chkAdd
        '
        Me.chkAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdd.Location = New System.Drawing.Point(8, 8)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(56, 16)
        Me.chkAdd.TabIndex = 23
        Me.chkAdd.Text = "Add"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(176, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(69, 16)
        Me.Label35.TabIndex = 137
        Me.Label35.Text = "Amount :"
        '
        'txtCInterest
        '
        Me.txtCInterest.AfterDecimal = 2
        Me.txtCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtCInterest.BeforeDecimal = 8
        Me.txtCInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCInterest.Enabled = False
        Me.txtCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCInterest.Location = New System.Drawing.Point(777, 120)
        Me.txtCInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCInterest.MaxLength = 10
        Me.txtCInterest.MaxValue = 0
        Me.txtCInterest.MinValue = 0
        Me.txtCInterest.Name = "txtCInterest"
        Me.txtCInterest.ReadOnly = True
        Me.txtCInterest.Size = New System.Drawing.Size(136, 23)
        Me.txtCInterest.TabIndex = 141
        Me.txtCInterest.TabStop = False
        Me.txtCInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCInterest.Visible = False
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(499, 122)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(128, 23)
        Me.txtReceiptNo.TabIndex = 19
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BackColor = System.Drawing.Color.White
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmount.Location = New System.Drawing.Point(499, 56)
        Me.txtFDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAmount.MaxLength = 11
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAmount.TabIndex = 16
        Me.txtFDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAType
        '
        Me.lblAType.AutoSize = True
        Me.lblAType.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblAType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAType.ForeColor = System.Drawing.Color.Black
        Me.lblAType.Location = New System.Drawing.Point(414, 63)
        Me.lblAType.Name = "lblAType"
        Me.lblAType.Size = New System.Drawing.Size(64, 16)
        Me.lblAType.TabIndex = 135
        Me.lblAType.Text = "Amount:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(412, 126)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 16)
        Me.Label27.TabIndex = 132
        Me.Label27.Text = "Receipt No:"
        '
        'dtpFDDate
        '
        Me.dtpFDDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(139, 41)
        Me.dtpFDDate.MaxDate = New Date(9998, 5, 19, 0, 0, 0, 0)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpFDDate.TabIndex = 10
        Me.dtpFDDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'txtFDDays
        '
        Me.txtFDDays.AfterDecimal = 0
        Me.txtFDDays.BeforeDecimal = 3
        Me.txtFDDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDDays.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDDays.Location = New System.Drawing.Point(579, 25)
        Me.txtFDDays.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDDays.MaxLength = 3
        Me.txtFDDays.MaxValue = 364
        Me.txtFDDays.MinValue = 0
        Me.txtFDDays.Name = "txtFDDays"
        Me.txtFDDays.Size = New System.Drawing.Size(48, 23)
        Me.txtFDDays.TabIndex = 13
        Me.txtFDDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDMonths
        '
        Me.txtFDMonths.AfterDecimal = 0
        Me.txtFDMonths.BeforeDecimal = 2
        Me.txtFDMonths.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMonths.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDMonths.Location = New System.Drawing.Point(539, 25)
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
        Me.txtFDYears.Location = New System.Drawing.Point(499, 25)
        Me.txtFDYears.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDYears.MaxLength = 2
        Me.txtFDYears.MaxValue = 0
        Me.txtFDYears.MinValue = 0
        Me.txtFDYears.Name = "txtFDYears"
        Me.txtFDYears.Size = New System.Drawing.Size(32, 23)
        Me.txtFDYears.TabIndex = 11
        Me.txtFDYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(673, 155)
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
        Me.Label111.Location = New System.Drawing.Point(673, 87)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(104, 24)
        Me.Label111.TabIndex = 127
        Me.Label111.Text = "Interest Amt:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(673, 26)
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
        Me.Label17.Location = New System.Drawing.Point(673, 58)
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
        Me.Label19.Location = New System.Drawing.Point(595, 9)
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
        Me.Label20.Location = New System.Drawing.Point(547, 9)
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
        Me.Label21.Location = New System.Drawing.Point(507, 9)
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
        Me.Label22.Location = New System.Drawing.Point(413, 31)
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
        Me.Label24.Location = New System.Drawing.Point(32, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 16)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "Renewal Date:"
        '
        'txtFDROI
        '
        Me.txtFDROI.AfterDecimal = 2
        Me.txtFDROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDROI.BeforeDecimal = 8
        Me.txtFDROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDROI.Location = New System.Drawing.Point(777, 56)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.dtpNextDate)
        Me.Panel1.Controls.Add(Me.dtpFDMatDate)
        Me.Panel1.Controls.Add(Me.txtFDIntAmount)
        Me.Panel1.Controls.Add(Me.txtFDMatAmount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBondNo)
        Me.Panel1.Controls.Add(Me.cmbPeriod)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.lblCInterest)
        Me.Panel1.Controls.Add(Me.chkCorrection)
        Me.Panel1.Controls.Add(Me.Correction)
        Me.Panel1.Controls.Add(Me.txtCInterest)
        Me.Panel1.Controls.Add(Me.txtReceiptNo)
        Me.Panel1.Controls.Add(Me.txtFDAmount)
        Me.Panel1.Controls.Add(Me.lblAType)
        Me.Panel1.Controls.Add(Me.Label27)
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
        Me.Panel1.Location = New System.Drawing.Point(8, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 192)
        Me.Panel1.TabIndex = 9
        Me.Panel1.TabStop = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StandardMtd)
        Me.GroupBox3.Controls.Add(Me.BTMMethod)
        Me.GroupBox3.Controls.Add(Me.NaveenSirMtd)
        Me.GroupBox3.Controls.Add(Me.btnCalculate)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(59, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 84)
        Me.GroupBox3.TabIndex = 151
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculation Type "
        '
        'StandardMtd
        '
        Me.StandardMtd.AutoSize = True
        Me.StandardMtd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StandardMtd.Location = New System.Drawing.Point(9, 61)
        Me.StandardMtd.Name = "StandardMtd"
        Me.StandardMtd.Size = New System.Drawing.Size(86, 20)
        Me.StandardMtd.TabIndex = 12
        Me.StandardMtd.TabStop = True
        Me.StandardMtd.Text = "Standard"
        Me.StandardMtd.UseVisualStyleBackColor = True
        '
        'BTMMethod
        '
        Me.BTMMethod.AutoSize = True
        Me.BTMMethod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMMethod.Location = New System.Drawing.Point(10, 38)
        Me.BTMMethod.Name = "BTMMethod"
        Me.BTMMethod.Size = New System.Drawing.Size(80, 20)
        Me.BTMMethod.TabIndex = 11
        Me.BTMMethod.TabStop = True
        Me.BTMMethod.Text = "Daywise"
        Me.BTMMethod.UseVisualStyleBackColor = True
        '
        'NaveenSirMtd
        '
        Me.NaveenSirMtd.AutoSize = True
        Me.NaveenSirMtd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NaveenSirMtd.Location = New System.Drawing.Point(10, 15)
        Me.NaveenSirMtd.Name = "NaveenSirMtd"
        Me.NaveenSirMtd.Size = New System.Drawing.Size(147, 20)
        Me.NaveenSirMtd.TabIndex = 10
        Me.NaveenSirMtd.TabStop = True
        Me.NaveenSirMtd.Text = "365/12 Monthwise"
        Me.NaveenSirMtd.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(96, 50)
        Me.btnCalculate.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 24)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(5, 16)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(133, 24)
        Me.Label40.TabIndex = 150
        Me.Label40.Text = "Next Quater Date:"
        '
        'dtpNextDate
        '
        Me.dtpNextDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpNextDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNextDate.Location = New System.Drawing.Point(140, 14)
        Me.dtpNextDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpNextDate.Name = "dtpNextDate"
        Me.dtpNextDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpNextDate.TabIndex = 149
        Me.dtpNextDate.Value = New Date(1974, 2, 16, 0, 0, 0, 0)
        '
        'dtpFDMatDate
        '
        Me.dtpFDMatDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDMatDate.Enabled = False
        Me.dtpFDMatDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDMatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDMatDate.Location = New System.Drawing.Point(777, 24)
        Me.dtpFDMatDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpFDMatDate.Name = "dtpFDMatDate"
        Me.dtpFDMatDate.Size = New System.Drawing.Size(136, 23)
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
        Me.txtFDIntAmount.Location = New System.Drawing.Point(777, 88)
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
        Me.txtFDMatAmount.Location = New System.Drawing.Point(777, 152)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(412, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Bond No :"
        '
        'txtBondNo
        '
        Me.txtBondNo.AfterDecimal = 0
        Me.txtBondNo.BeforeDecimal = 8
        Me.txtBondNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBondNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBondNo.Location = New System.Drawing.Point(499, 89)
        Me.txtBondNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtBondNo.MaxLength = 10
        Me.txtBondNo.MaxValue = 0
        Me.txtBondNo.MinValue = 0
        Me.txtBondNo.Name = "txtBondNo"
        Me.txtBondNo.Size = New System.Drawing.Size(128, 23)
        Me.txtBondNo.TabIndex = 18
        '
        'cmbPeriod
        '
        Me.cmbPeriod.BackColor = System.Drawing.Color.White
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriod.ForeColor = System.Drawing.Color.Black
        Me.cmbPeriod.Items.AddRange(New Object() {"At the end", "As Scheme Period"})
        Me.cmbPeriod.Location = New System.Drawing.Point(136, 72)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(136, 24)
        Me.cmbPeriod.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(125, 16)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "Interest Posting :"
        '
        'txtSchemeType
        '
        Me.txtSchemeType.Location = New System.Drawing.Point(110, 16)
        Me.txtSchemeType.Name = "txtSchemeType"
        Me.txtSchemeType.Size = New System.Drawing.Size(388, 23)
        Me.txtSchemeType.TabIndex = 63
        Me.txtSchemeType.Visible = False
        '
        'frmFDRenewal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(981, 613)
        Me.Controls.Add(Me.grpFDType)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lvInterest)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFDRenewal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FD Renewal"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grpFDType.ResumeLayout(False)
        Me.grpFDType.PerformLayout()
        Me.Correction.ResumeLayout(False)
        Me.Correction.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objFDAcc As New clsFDAccount
    Dim bolCumulative As Boolean = False
    Dim bolMonth As Boolean = False
    'Dim objFDAccount As New clsFDAccount
    Dim dtMasterData As DataTable
    Dim datFDDate As Date
    Dim bolSCitizen As Boolean = False
    'Dim dtInterest As New DataTable
    Dim datFDDateTemp As Date
    Dim intLedgerNo As Integer
    Dim intLedIntNo As Integer
    Public strFDNo As String

    Dim dblProvisionInterest As Double
    Dim dblPaidInterest As Double
    Dim dblDueInterest As Double
    Dim dblInterest As Double
    Dim timeTemp As Date
    Dim TempSubdays As Integer = 0
    Dim TempSubMonth As Integer = 0
    Dim TempTotalDays As Integer = 0
    Dim bolTemp As Boolean = True

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDRenewal
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDRenewal
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDRenewal
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDRenewal)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Functions"


    'To load SchemeTbl values to the Scheme ComboBox Control
    Sub sbLoadScheme()
        Dim objScheme As New clsFDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.FdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
        End If
        objScheme = Nothing
    End Sub

    Sub sbSetSchemeMaster()
        If cmbSchemeType.SelectedValue <> 0 Then
            objFDAcc.SchemeCode = cmbSchemeType.SelectedValue
            If objFDAcc.fnCheckScheme() Then
                Dim dtMasterData As DataTable = objFDAcc.FDMasterDetailTbl
                If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                    bolCumulative = True
                    objFDAcc.FDType = "C"
                Else
                    objFDAcc.FDType = "N"
                End If
                bolMonth = IIf(dtMasterData.Rows(0).Item("CalType") = "M", True, False)

            Else
                MsgBox("Load failed due to internal error", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub


    Public Function fnGetRenewalDet() As Boolean
        Dim intCount As Integer = 0
        Dim strFDScheme As String
            Try

            If objFDAcc.fnGetFDRenewalDet(txtOldFDNo.Text) Then
                txtName.Text = objFDAcc.FDDetailstbl.Rows(0).Item("Name")
                dtpMaturiedDate.Value = Format(objFDAcc.FDDetailstbl.Rows(0).Item("MatDate"), "yyyy-MM-dd")
                dtpFDDate.Value = Format(objFDAcc.FDDetailstbl.Rows(0).Item("MatDate"), "yyyy-MM-dd")
                txtOldBondNo.Text = objFDAcc.FDDetailstbl.Rows(0).Item("BondNo")
                strFDScheme = objFDAcc.FDDetailstbl.Rows(0).Item("FDScheme").ToString
                If strFDScheme = "1001" Or strFDScheme = "1002" Or strFDScheme = "1003" Or strFDScheme = "1004" Or strFDScheme = "1005" Or strFDScheme = "1006" Or strFDScheme = "1007" Then
                    txtSchemeType.Visible = True
                    cmbSchemeType.Visible = False
                    Select Case strFDScheme
                        Case "1001" : txtSchemeType.Text = "Double"
                        Case "1002" : txtSchemeType.Text = "Triple"
                        Case "1003" : txtSchemeType.Text = "Lakshadhipathy(87313)"
                        Case "1004" : txtSchemeType.Text = "Lakshadhipathy(76640)"
                        Case "1005" : txtSchemeType.Text = "Lakshadhipathy(65980)"
                        Case "1006" : txtSchemeType.Text = "Lakshadhipathy(53755)"
                        Case "1007" : txtSchemeType.Text = "Lakshadhipathy(49196)"
                    End Select
                    objFDAcc.fnGetDoubleThriableLakshadipathiDetails(txtOldFDNo.Text)
                Else
                    cmbSchemeType.SelectedValue = objFDAcc.FDDetailstbl.Rows(0).Item("FDScheme")
                    objFDAcc.SchemeTypeCheck = objFDAcc.FDDetailstbl.Rows(0).Item("SchemeType")
                    objFDAcc.fnGetFDDetails(txtOldFDNo.Text)

                End If

                objFDAcc.FDAmountCheck = objFDAcc.FDDetailstbl.Rows(0).Item("FDAmount")
                objFDAcc.MatAmountCheck = objFDAcc.FDDetailstbl.Rows(0).Item("MatAmount")
                objFDAcc.FDDetailID = objFDAcc.FDDetailstbl.Rows(0).Item("FDDetailID")
                objFDAcc.TransferAccNo = objFDAcc.FDDetailstbl.Rows(0).Item("TransferAccountNo")
                objFDAcc.FDAdditionDetailID = Convert.ToInt32(objFDAcc.FDDetailstbl.Rows(0).Item("FDAdditionalDetailID"))
                dblInterest = objFDAcc.FDDetailstbl.Rows(0).Item("IntAmount")
                If Val(objFDAcc.FDDetailstbl.Rows(0).Item("Age")) >= 60 Then
                    bolSCitizen = True
                Else
                    bolSCitizen = False
                End If

            Else
                Return False
            End If
            If objFDAcc.InterestTable.Rows.Count > 0 Then

                intCount = 0
                objFDAcc.TotalInterestPaid = 0
                objFDAcc.TotalInterestProvision = 0
                While intCount < Convert.ToInt32(objFDAcc.InterestTable.Rows.Count)

                    If objFDAcc.InterestTable.Rows(intCount).Item("Status").ToString() = "Paid" Then
                        objFDAcc.TotalInterestPaid += Convert.ToDouble(objFDAcc.InterestTable.Rows(intCount).Item("IntAmount"))
                    End If
                    If objFDAcc.InterestTable.Rows(intCount).Item("Status").ToString() = "Provision" Then
                        objFDAcc.TotalInterestProvision += Convert.ToDouble(objFDAcc.InterestTable.Rows(intCount).Item("IntAmount"))
                    End If
                    If objFDAcc.InterestTable.Rows(intCount).Item("Status").ToString() = "Due" Then
                        MsgBox("Can't renewal because there is 'due' amount, first provision that amount", MsgBoxStyle.OkOnly, "FD Renewal")
                        Return False
                    End If
                    intCount = intCount + 1
                End While
                If dblInterest = objFDAcc.TotalInterestPaid Then
                    txtFDAmount.Text = objFDAcc.FDAmountCheck.ToString()
                ElseIf objFDAcc.TotalInterestProvision <> 0 Then
                    txtFDAmount.Text = Convert.ToString(objFDAcc.FDAmountCheck + objFDAcc.TotalInterestProvision)
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Function fnCheckFDDetails() As Boolean
        If cmbFDType.SelectedIndex = -1 Then
            MsgBox("Select interest mode", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            cmbFDType.Focus()
        ElseIf (Val(txtFDYears.Text) = 0 And Val(txtFDMonths.Text) = 0 And Val(txtFDDays.Text) = 0) Then
            MsgBox("Please enter period of deposit", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            txtFDYears.Focus()
        ElseIf cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select interest posting type", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            cmbPeriod.Focus()
        ElseIf Val(txtFDAmount.Text) <= 0 Or txtFDAmount.Text = "" Then
            MsgBox("Amount should not be zero", MsgBoxStyle.Information)
            fnCheckFDDetails = False
        ElseIf Val(txtFDROI.Text) = 0 Then
            MsgBox("Please enter FD ROI", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            txtFDROI.Focus()
        ElseIf Val(txtReceiptNo.Text) = 0 Then
            MsgBox("Please enter receipt number", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            txtReceiptNo.Focus()
            ''ElseIf objFDAcc.SchemeTypeCheck = "N" And Val(txtFDAmount.Text) <> objFDAcc.FDAmountCheck Then
            ''    MsgBox("FDAmount should be principle amount because noncumulative, otherwise close create new FD account", MsgBoxStyle.Information)
            ''    fnCheckFDDetails = False
            ''    txtFDAmount.Focus()
            ''ElseIf objFDAcc.SchemeTypeCheck = "C" And Val(txtFDAmount.Text) <> objFDAcc.MatAmountCheck Then
            ''    MsgBox("FDAmount should be principle amount plus interest because cumulative, otherwise close create new FD account", MsgBoxStyle.Information)
            ''    fnCheckFDDetails = False
            ''    txtFDAmount.Focus()
        Else
            fnCheckFDDetails = True
            End If
    End Function
    Function fnCheck() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
            Return False
        ElseIf txtOldFDNo.Text = "FD" Or txtOldFDNo.Text = "ENNVY" Or txtOldFDNo.Text = "SCC" Then
            MsgBox("Enter account no.", MsgBoxStyle.Information)
            txtOldFDNo.Focus()
            Return False
        ElseIf txtName.Text = "" Then
            MsgBox("Enter name ", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf fnCheckFDDetails() = False Then
            Return False
        ElseIf Val(txtFDIntAmount.Text) = 0 Or lvInterest.Items.Count = 0 Then
            MsgBox("Run calculate", MsgBoxStyle.Information)
            btnCalculate.Focus()
            Return False
        ElseIf txtReceiptNo.Text = "" Then
            MsgBox("Enter receipt no.", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
        ElseIf txtBondNo.Text = String.Empty Then
            MsgBox("Please enter bond no.", MsgBoxStyle.Exclamation, "Deposit Module")
            txtBondNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Function fnSbCalPeriod()

        dtpFDMatDate.Value = DateAdd(DateInterval.Year, Val(txtFDYears.Text), dtpFDDate.Value)
        dtpFDMatDate.Value = DateAdd(DateInterval.Month, Val(txtFDMonths.Text), dtpFDMatDate.Value)
        dtpFDMatDate.Value = DateAdd(DateInterval.Day, Val(txtFDDays.Text), dtpFDMatDate.Value)

    End Function

    Public Function fnSetData() As Boolean

        'If objFDAcc.fnGetFDRenewalDet(txtOldFDNo.Text) Then

        '    objFDAcc.FDROI = txtFDROI.Text
        '    objFDAcc.MatAmount = txtFDMatAmount.Text
        '    objFDAcc.MatDate = Format(dtpFDMatDate.Value, "yyyy-MM-dd")
        '    objFDAcc.FDYears = objFDAcc.FDDetailstbl.Rows(0).Item("Years") + Val(txtFDYears.Text)
        '    objFDAcc.FDMonths = objFDAcc.FDDetailstbl.Rows(0).Item("Months") + Val(txtFDMonths.Text)
        '    objFDAcc.FDDays = objFDAcc.FDDetailstbl.Rows(0).Item("Days") + Val(txtFDDays.Text)
        '    objFDAcc.ReceiptNo = txtReceiptNo.Text
        '    objFDAcc.FDNo = txtOldFDNo.Text
        '    objFDAcc.FDDate = Format(dtpFDDate.Value, "yyyy-MM-dd")
        '    objFDAcc.ReceiptNo = txtReceiptNo.Text

        '    Return True
        'Else
        '    Return False
        ' End If


        Dim intCounter As Integer = 0
        Dim dtRow As DataRow

        objFDAcc.FDNo = txtOldFDNo.Text
        objFDAcc.SchemeCode = cmbSchemeType.SelectedValue


        If cmbFDType.SelectedItem = "Monthly" Then
            objFDAcc.IntMode = "M"
        ElseIf cmbFDType.SelectedItem = "Quarterly" Then
            objFDAcc.IntMode = "Q"
        ElseIf cmbFDType.SelectedItem = "Half-Yearly" Then
            objFDAcc.IntMode = "H"
        ElseIf cmbFDType.SelectedItem = "Yearly" Then
            objFDAcc.IntMode = "Y"
        End If

        If cmbPeriod.SelectedItem = "At the end" Then
            objFDAcc.chPostingPeriod = "E"
        ElseIf cmbPeriod.SelectedItem = "As Scheme Period" Then
            objFDAcc.chPostingPeriod = "P"
        End If

        Select Case cmbDepositType.SelectedItem
            Case "FD"
                intLedgerNo = 27
                intLedIntNo = 30
            Case "ENNVY"
                intLedgerNo = 53
                intLedIntNo = 55
            Case "SCC"
                intLedgerNo = 54
                intLedIntNo = 56
        End Select


        If chkCorrection.Checked = True Then
            objFDAcc.Correction = "Y"
        Else
            objFDAcc.Correction = "N"
        End If

        If chkAdd.Checked = True Then
            objFDAcc.CorrectioType = "A"
        ElseIf chkSubtract.Checked = True Then
            objFDAcc.CorrectioType = "S"
        Else
            objFDAcc.CorrectioType = "N"
        End If

        objFDAcc.CAmount = Val(txtCorrectionAmount.Text)
        ' objFDAccount.TransferAccNo = txtTransferAccount.Text
        objFDAcc.ChTransferAmount = "N"

        objFDAcc.FDDate = dtpFDDate.Value
        objFDAcc.FDAmount = Val(txtFDAmount.Text)
        objFDAcc.FDYears = Val(txtFDYears.Text)
        objFDAcc.FDMonths = Val(txtFDMonths.Text)
        objFDAcc.FDDays = Val(txtFDDays.Text)
        objFDAcc.FDROI = Val(txtFDROI.Text)
        objFDAcc.IntAmount = Val(txtFDIntAmount.Text)
        objFDAcc.MatAmount = Val(txtFDMatAmount.Text)
        objFDAcc.MatDate = dtpFDMatDate.Value

        Dim dtInterest As New DataTable

        dtInterest.Columns.Add("SlNo")
        dtInterest.Columns.Add("IntAmount")
        dtInterest.Columns.Add("IntDate")
        dtInterest.Columns.Add("TotalAmount")
        dtInterest.Rows.Clear()

        While intCounter < lvInterest.Items.Count
            dtRow = dtInterest.NewRow
            dtRow.Item("SlNo") = lvInterest.Items(intCounter).SubItems(0).Text
            dtRow.Item("IntAmount") = lvInterest.Items(intCounter).SubItems(1).Text
            dtRow.Item("IntDate") = lvInterest.Items(intCounter).SubItems(2).Text
            dtRow.Item("TotalAmount") = lvInterest.Items(intCounter).SubItems(3).Text
            dtInterest.Rows.Add(dtRow)
            intCounter += 1
        End While
        objFDAcc.InterestTable = dtInterest
        objFDAcc.VoucherNo = fnVoucherGetNewVNo(dtpFDDate.Value)
        objFDAcc.ReceiptNo = txtReceiptNo.Text
        objFDAcc.BondNo = Convert.ToDouble(txtBondNo.Text)
        objFDAcc.Status = "Active"
        'objFDAcc.Remarks = txtRemarks.Text

        Return True
    End Function

    Public Function fnSaveData()
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If objFDAcc.fnFdRenewal(objTrans) Then
                If objFDAcc.fnUpdateMaturity(txtOldFDNo.Text, objTrans) Then
                    If fnGenerateVoucher(objTrans) Then
                        objTrans.Commit()
                        fnClear()
                        MsgBox("FD renewal done successfully", MsgBoxStyle.Information, " FD Module")
                    Else
                        MsgBox("FD cannot be Renewed due to internal error ", MsgBoxStyle.Information, " FD Module")
                    End If
                End If
            Else
                MsgBox("FD cannot be renewed due to internal error ", MsgBoxStyle.Information, " FD Module")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpFDDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        If objFDAcc.TotalInterestProvision = 0 Then

        ElseIf objFDAcc.TotalInterestProvision <> 0 Then
            ''voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtOldFDNo.Text, txtReceiptNo.Text, dtpFDDate.Value, Val(dblInterest), "Account Renewal by  " & txtOldFDNo.Text, lngSlNo, "Y", objTrans)

            ''Credit  - Fixed Deposit account 
            fnVoucherEnterSub(lngVoucherNo, 2, txtOldFDNo.Text, dtpFDDate.Value, "Reneval of account  " & txtOldFDNo.Text, "By", 14, Val(dblInterest), 0, 2, "Y", objTrans)

            ''Debit  - Interest PAyment
            fnVoucherEnterSub(lngVoucherNo, 2, txtOldFDNo.Text, dtpFDDate.Value, "Interest paid by  " & txtOldFDNo.Text, "To", intLedgerNo, 0, Val(dblInterest), 3, "Y", objTrans)
        End If
        '' ''voucher details
        ''fnVoucherEnterMain(lngVoucherNo, 2, txtOldFDNo.Text, txtReceiptNo.Text, dtpFDDate.Value, Val(dblInterest), "Account closure by  " & txtOldFDNo.Text, lngSlNo, "Y", objTrans)

        '' ''Credit  - Fixed Deposit account 
        ''fnVoucherEnterSub(lngVoucherNo, 2, txtOldFDNo.Text, dtpFDDate.Value, "Reneval of account  " & txtOldFDNo.Text, "By", intLedgerNo, 0, Val(dblInterest), 2, "Y", objTrans)

        '' ''Debit  - Interest PAyment
        ''fnVoucherEnterSub(lngVoucherNo, 2, txtOldFDNo.Text, dtpFDDate.Value, "Interest paid by  " & txtOldFDNo.Text, "By", intLedIntNo, Val(dblInterest) - Val(dblProvisionInterest), 0, 3, "Y", objTrans)

        ''If dblProvisionInterest <> 0 Then
        ''    'Debit accounts 
        ''    fnVoucherEnterSub(lngVoucherNo, 2, txtOldFDNo.Text, dtpFDDate.Value, "Interest paid by " & txtOldFDNo.Text, "By", 14, dblProvisionInterest, 0, 4, "Y", objTrans)
        ''End If

        Return True

    End Function

    Public Function fnCalcIntr()

        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim dblFDAmount As Double
        Dim dblIntAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim iv As ListViewItem
        Dim datFDDate As Date
        Dim datNextDate As Date
        Dim intDivide As Integer

        datFDDate = CDate(dtpFDDate.Value)
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)

        If fnCheckFDDetails() = True Then

            Try
                dblFDAmount = CDbl(txtFDAmount.Text)
                dblROI = Val(txtFDROI.Text)
                intNOM = Val(txtFDMonths.Text)
                intNOM += (Val(txtFDYears.Text) * 12)
                'intNOD = Val(txtFDDays.Text)
                intCounter = 1
                lvInterest.Items.Clear()

                ' If rdbCumulative.Checked = True Then      'if FD is CUMULATIVE
                If bolCumulative = True Then      'if FD is CUMULATIVE
                    Select Case cmbFDType.SelectedItem.ToString
                        Case "Monthly"
                            intIntMode = 1
                        Case "Quarterly"
                            intIntMode = 3
                        Case "Half-Yearly"
                            intIntMode = 6
                        Case "Yearly"
                            intIntMode = 12
                        Case "Closure Date"
                            intIntMode = 12
                    End Select

                    While (intNOM / intIntMode) >= intCounter
                        datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)

                        If bolMonth = True Then
                            Dim intNOMonths As Integer = Val(datNextDate)
                            dblIntAmt = Round((dblFDAmount * intIntMode * dblROI) / (100 * 12), 2)
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                            dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
                        End If
                        iv = lvInterest.Items.Add(intCounter)
                        iv.SubItems.Add(dblIntAmt)
                        iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                        iv.SubItems.Add(Format(dblIntAmt + dblFDAmount, "0.00"))
                        dblFDAmount += dblIntAmt
                        datFDDate = datNextDate
                        dblTotalInt += dblIntAmt
                        intCounter += 1
                    End While
                    intNOM = intNOM Mod intIntMode    'remaining no of months
                    datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate)    'get next date for remaining months
                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate) 'days for remaining months
                    intNOD += Val(txtFDDays.Text)   'total remaining days
                    dblIntAmt = Round((dblFDAmount * intNOD * dblROI) / (100 * 365), 2)
                    dblTotalInt += dblIntAmt

                    If dblIntAmt > 0 Then
                        iv = lvInterest.Items.Add(intCounter)
                        iv.SubItems.Add(dblIntAmt)
                        iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                        iv.SubItems.Add(Format(dblIntAmt + dblFDAmount, "0.00"))
                        dblFDAmount += dblIntAmt
                        datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                        intCounter += 1
                    End If
                Else            'for NON-CUMULATIVE 
                    Select Case cmbFDType.SelectedItem.ToString
                        Case "Monthly"
                            intDivide = 30
                        Case "Quarterly"
                            intDivide = 90
                        Case "Half-Yearly"
                            intDivide = 180
                        Case "Yearly"
                            intDivide = 365
                        Case "Closure Date"
                            intDivide = intNOD
                    End Select
                    If bolMonth = True Then
                        Dim intMonth As Integer = (intDivide / 30)
                        dblIntAmt = Round((dblFDAmount * intMonth * dblROI) / (100 * 12), 2)
                        dblTotalInt = dblIntAmt
                    Else
                        dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365), 2)
                        dblTotalInt = dblIntAmt
                    End If
                    intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                    dblIntAmt = dblIntAmt / intNOD


                    While (intNOD / intDivide) >= intCounter
                        iv = lvInterest.Items.Add(intCounter)
                        iv.SubItems.Add(Round(dblIntAmt * intDivide, 2))
                        iv.SubItems.Add(Format(DateAdd(DateInterval.Month, intDivide \ 30, datFDDate), "dd-MMM-yyyy"))
                        iv.SubItems.Add(Round(dblIntAmt * intDivide, 2) + dblFDAmount)
                        dblFDAmount += Round(dblIntAmt * intDivide, 2)
                        datFDDate = DateAdd(DateInterval.Month, intDivide \ 30, datFDDate)
                        intCounter += 1
                    End While
                    dblIntAmt = Round(dblIntAmt * (intNOD Mod intDivide), 2)

                    If dblIntAmt > 0 Then
                        iv = lvInterest.Items.Add(intCounter)
                        iv.SubItems.Add(dblIntAmt)
                        iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                        iv.SubItems.Add(dblIntAmt + dblFDAmount)
                        dblFDAmount += dblIntAmt
                        datFDDate = DateAdd(DateInterval.Day, (intNOD Mod intDivide), datFDDate)
                        intCounter += 1
                    End If
                End If

                txtFDMatAmount.Text = dblFDAmount

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If

    End Function

    Public Function fnLoadIntetest() As Boolean
        dblProvisionInterest = 0
        dblDueInterest = 0
        dblPaidInterest = 0

        If objFDAcc.fnCheckFDScheme(txtOldFDNo.Text) Then
            Dim dtMasterData As DataTable = objFDAcc.FDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                'bolCumulative = True
                'objFDAccount.FDType = "C"
                If objFDAcc.fnGetInterestDet(txtOldFDNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objFDAcc.dtIntPost.Rows.Count
                        Select Case objFDAcc.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Provision"
                                dblProvisionInterest = objFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Paid"
                                dblPaidInterest = objFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                        End Select
                        intCount += 1
                    End While
                End If
            Else
                'objFDAccount.FDType = "N"
                If objFDAcc.fnGetNonInterestDet(txtOldFDNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objFDAcc.dtIntPost.Rows.Count
                        Select Case objFDAcc.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Provision"
                                dblProvisionInterest = objFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Paid"
                                dblPaidInterest = objFDAcc.dtIntPost.Rows(intCount).Item("Amount")
                        End Select
                        intCount += 1
                    End While
                End If
            End If
        End If

    End Function

#End Region

#Region "Events"

    Private Sub btnFDList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFDList.Click
        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(txtOldFDNo.Text)
            objFDSearch.strForm = "FDDoubleThriableLakshadipathi"
            objFDSearch.strFDNo = ""
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtOldFDNo.Text = objFDSearch.strFDNo
                fnGetRenewalDet()
                fnLoadIntetest()
                txtOldFDNo.Focus()
                txtName.Focus()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select the deposit type ", MsgBoxStyle.Information)
            cmbDepositType.Focus()
        End If

    End Sub

    Private Sub txtFDYears_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDYears.TextChanged, txtFDMonths.TextChanged, txtFDDays.TextChanged

        fnSbCalPeriod()

    End Sub

    Private Sub txtOldFDNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOldFDNo.TextChanged

        If Not txtOldFDNo.Text.StartsWith("FD") Then
            txtOldFDNo.Undo()
            txtOldFDNo.ClearUndo()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If fnCheckFDDetails() Then
            If fnSetData() Then
                fnSaveData()

            End If
        End If
    End Sub

#End Region

    Function fnClear() As Boolean
        txtOldBondNo.ResetText()
        txtOldFDNo.ResetText()
        cmbDepositType.SelectedIndex = -1
        txtName.ResetText()
        cmbSchemeType.SelectedIndex = -1
        txtFDYears.ResetText()
        txtFDMonths.ResetText()
        txtFDDays.ResetText()
        cmbPeriod.SelectedIndex = -1
        txtBondNo.ResetText()
        cmbFDType.SelectedIndex = -1
        txtFDROI.ResetText()
        txtFDIntAmount.ResetText()
        txtCInterest.ResetText()
        txtFDMatAmount.ResetText()
        txtCorrectionAmount.ResetText()
        chkCorrection.Checked = False
        chkAdd.Checked = False
        chkSubtract.Checked = False
        txtReceiptNo.ResetText()
        lvInterest.Items.Clear()
        cmbDepositType.SelectedIndex = -1
        txtOldFDNo.ResetText()



    End Function
    Private Sub frmFDRenewal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtInterest.Columns.Add("SlNo")
        'dtInterest.Columns.Add("IntAmount")
        'dtInterest.Columns.Add("IntDate")
        'dtInterest.Columns.Add("TotalAmount")
        sbLoadScheme()
        fnClear()
        cmbDepositType.SelectedIndex = 0

    End Sub
    Private Sub dtpFDDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFDDate.ValueChanged

        fnSbCalPeriod()

    End Sub

    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                txtOldFDNo.Text = "FD"
            Case "ENNVY"
                txtOldFDNo.Text = "ENNVY"
        End Select
    End Sub

    Private Sub cmbSchemeType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSchemeType.LostFocus

        objFDAcc.SchemeCode = cmbSchemeType.SelectedValue
        If objFDAcc.fnCheckScheme() Then
            dtMasterData = objFDAcc.FDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                bolCumulative = True
                objFDAcc.FDType = "C"
                txtFDDays.BeforeDecimal = 3
                txtFDDays.MaxValue = 30
                txtFDDays.Enabled = True
                txtFDYears.ResetText()
                txtFDMonths.ResetText()
                txtFDDays.ResetText()
            Else
                bolCumulative = False
                objFDAcc.FDType = "N"
                txtFDDays.BeforeDecimal = 3
                txtFDDays.MaxValue = 364
                txtFDDays.Enabled = True
                txtFDYears.ResetText()
                txtFDMonths.ResetText()
                txtFDDays.ResetText()
            End If
            bolMonth = IIf(dtMasterData.Rows(0).Item("CalType") = "M", True, False)

            cmbFDType.SelectedItem = dtMasterData.Rows(0).Item("IntPostingPrd")
        Else
            MsgBox("Load failed due to internal error", MsgBoxStyle.Exclamation)
        End If

        If cmbFDType.SelectedIndex <> 0 Then
            Panel1.Enabled = True
            dtpFDDate.Focus()
        Else
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub btnCalculate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If cmbPeriod.SelectedIndex <> -1 Then
            FnCalInterest()
        ElseIf cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select interest posting Type")
            cmbPeriod.Focus()
        End If

    End Sub
#Region "Working with date wise Quater according to chart"



    '---STARTS--------IT WILL GIVE PERFECT VALUES WITH RESPECT TO THE VALUES FROM THE CHART---------
    '
    Function FnCalculateCD(ByVal CoType As Integer) As Double '-----Function for caliculating compound interest------'
        Dim intNOM As Integer = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpFDMatDate.Value)
        Dim dblTotal As Double = 0
        Dim dblROI As Double = 0
        Dim CompType As Double = CoType
        Dim dblFDAmount As Double = 0
        Dim dblPeriod As Double = 0

        dblFDAmount = Convert.ToDouble(txtFDAmount.Text)
        dblROI = Convert.ToDouble(txtFDROI.Text) / 100
        dblPeriod = intNOM / 12
        dblTotal = (1 + (dblROI) / CompType)
        dblTotal = Math.Round(dblFDAmount * Math.Pow(dblTotal, CompType * dblPeriod))
        Return dblTotal
    End Function
#End Region



    Function FnCalIntForOtherThanQterly()
        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim dblFDAmount As Double
        Dim dblIntAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim intMode As Integer = 0
        Dim iv As ListViewItem
        Dim dblFDAmt As Double = 0
        Dim x, y As Double
        Dim intTempPeriod As Integer
        Dim dblTempPower As Double

        Dim datNextDate As Date
        Dim intDivide As Integer
        Dim datMatdate As Date
        Dim intQuater As Integer = 0

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
        Dim dblPrev As Double

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FoQuater = New Integer() {"10", "11", "12"}
        Dim PerMonth As Double
        Dim PerDay As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        'Below is the method for 30 days used in pavagada BTM for Noncumulative(Simple Interest)
        'Here D day textbox should not be empty or select the '365'
        If BTMMethod.Checked = True Then
            If txtFDDays.Text = String.Empty Then
                MsgBox("Please enter the number of days or select the '356/12 monthe type'.", MsgBoxStyle.Information, "Deposit Module")
            Else
                Select Case cmbFDType.SelectedItem.ToString()
                    Case "Monthly"
                        intIntMode = 1
                    Case "Quarterly"
                        intIntMode = 3
                    Case "Half-Yearly"
                        intIntMode = 6
                    Case "Yearly"
                        intIntMode = 12
                End Select
                datFDDate = CDate(dtpFDDate.Value)
                dblFDAmt = CDbl(txtFDAmount.Text)
                dblROI = Val(txtFDROI.Text)
                dblIntAmt = Round((dblFDAmt * dblROI) / (1200 + dblROI), 2) 'IntAmount without days
                PerDay = Round((dblIntAmt / 30), 2)
                datMatdate = CDate(dtpFDMatDate.Value)
                If txtFDYears.Text <> String.Empty Then
                    'intNOD = (Val(txtFDYears.Text) * 365)
                    intNOM += (Val(txtFDYears.Text) * 12)
                End If
                If txtFDMonths.Text <> String.Empty Then
                    'intNOD += (Val(txtFDMonths.Text) * 30)
                    intNOM += Val(txtFDMonths.Text)
                End If
                If txtFDDays.Text <> String.Empty Then
                    intNOD += Val(txtFDDays.Text)
                    Days = Val(txtFDDays.Text)
                End If
                lvInterest.Items.Clear()
                While (intNOM / intIntMode) > intCounter
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    'intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    iv = lvInterest.Items.Add(intCounter)
                    'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                    iv.SubItems.Add(Round(dblIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                    iv.SubItems.Add(Format(Round(dblIntAmt) + dblFDAmt))
                    'dblFDAmount += Round(dblIntAmt * intNOD)
                    'dblTotalInt += Round(dblIntAmt * intNOD)
                    dblFDAmt += (dblIntAmt)
                    dblTotalInt += (dblIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                End While
                iv = lvInterest.Items.Add(intCounter)
                iv.SubItems.Add(Round(PerDay * Days))
                iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(PerDay * Days) + dblFDAmt))
                dblFDAmt += Round(PerDay * Days)
                dblTotalInt += Round(PerDay * Days)
                datFDDate = DateAdd(DateInterval.Day, Days, datFDDate)
                intCounter += 1
            End If
            'txtFDIntAmount.Text = Math.Round(dblTotalInt)
            txtFDIntAmount.Text = Round(dblTotalInt)
        End If

        If NaveenSirMtd.Checked = True Then 'Month wise mtd for Noncumulative(Simple Interest)
            If txtFDDays.Text = String.Empty Then
                Select Case cmbFDType.SelectedItem.ToString
                    Case "Monthly"
                        intIntMode = 1
                    Case "Quarterly"
                        intIntMode = 3
                    Case "Half-Yearly"
                        intIntMode = 6
                    Case "Yearly"
                        intIntMode = 12
                End Select
                datFDDate = CDate(dtpFDDate.Value)
                dblFDAmt = CDbl(txtFDAmount.Text)
                dblROI = Val(txtFDROI.Text)
                dblIntAmt = Round((dblFDAmt * dblROI) / (1200 + dblROI), 2) 'IntAmount without days

                If txtFDYears.Text <> String.Empty Then
                    intNOD = (Val(txtFDYears.Text) * 365)
                    intNOM += (Val(txtFDYears.Text) * 12)
                End If
                If txtFDMonths.Text <> String.Empty Then
                    intNOD += (Val(txtFDMonths.Text) * 30)
                    intNOM += Val(txtFDMonths.Text)
                End If
                If txtFDDays.Text <> String.Empty Then
                    intNOD = Val(txtFDDays.Text)
                End If

                ''PerMonth = dblIntAmt / 12

                'PerDay = dblIntAmt / 365
                lvInterest.Items.Clear()
                While (intNOM / intIntMode) > intCounter
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    iv = lvInterest.Items.Add(intCounter)
                    iv.SubItems.Add(Round(dblIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    iv.SubItems.Add(Format(Round(dblIntAmt) + dblFDAmt))
                    dblFDAmt += Round(dblIntAmt)
                    dblTotalInt += Round(dblIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                End While
                txtFDIntAmount.Text = (dblTotalInt)
            Else
                MsgBox("Please not give the number of days or select the 'Monthwise'.", MsgBoxStyle.Information, "Deposit Module")
            End If
        End If
        'Below is the standard method for FD calculation 
        If StandardMtd.Checked = True Then
            datFDDate = CDate(dtpFDDate.Value)
            lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
            datMatdate = CDate(dtpFDMatDate.Value)
            If fnCheckFDDetails() = True Then
                Try
                    dblFDAmount = CDbl(txtFDAmount.Text)
                    dblFDAmt = CDbl(txtFDAmount.Text)
                    dblROI = Val(txtFDROI.Text)
                    intNOM = Val(txtFDMonths.Text)
                    intNOM += (Val(txtFDYears.Text) * 12)
                    intCounter = 1
                    lvInterest.Items.Clear()
                    If bolCumulative = True Then
                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 12
                                intMode = 1
                            Case "Quarterly"
                                intIntMode = 4
                                intMode = 3
                            Case "Half-Yearly"
                                intIntMode = 2
                                intMode = 6
                            Case "Yearly"
                                intIntMode = 1
                                intMode = 12
                        End Select
                        x = (1 + ((Val(txtFDROI.Text)) / (intIntMode * 100)))
                        intTempPeriod = intMode
                        While (intNOM / intMode) >= intCounter
                            y = (Val(intTempPeriod) / intMode)
                            dblTempPower = Math.Pow(x, y)
                            dblIntAmt = (Val(txtFDAmount.Text) * (dblTempPower)) - Val(txtFDAmount.Text)
                            datNextDate = DateAdd(DateInterval.Month, intMode, datFDDate)
                            dblTemp = dblIntAmt - dblPrev
                            iv = lvInterest.Items.Add(intCounter + 1)
                            iv.SubItems.Add(Math.Round(dblTemp))
                            'iv.SubItems.Add(Math.Round(dblTemp, 3))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            'iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            iv.SubItems.Add((dblTemp) + (dblFDAmount))
                            dblPrev = dblIntAmt
                            dblFDAmount += Math.Round(dblTemp)
                            'dblFDAmount += (dblTemp)
                            datFDDate = datNextDate
                            dblTotalInt += Math.Round(dblTemp)
                            'dblTotalInt += (dblTemp)
                            intTempPeriod += intMode
                            intCounter += 1
                        End While
                        intNOM = intNOM Mod intMode
                        If intNOM > 0 Then
                            intTempPeriod -= intMode
                            intTempPeriod += intNOM
                            y = (Val(intTempPeriod) / intMode)
                            dblTempPower = Math.Pow(x, y)
                            dblIntAmt = (Val(txtFDAmount.Text) * (dblTempPower)) - Val(txtFDAmount.Text)
                            datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate)
                            dblTemp = dblIntAmt - dblPrev
                            iv = lvInterest.Items.Add(intCounter + 1)
                            iv.SubItems.Add(Math.Round(dblTemp))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            dblPrev = dblIntAmt
                            dblFDAmount += Math.Round(dblTemp)
                            datFDDate = datNextDate
                            dblTotalInt += Math.Round(dblTemp)
                            intTempPeriod += intMode
                        End If
                    Else            'for NON-CUMULATIVE 
                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 1
                            Case "Quarterly"
                                intIntMode = 3
                            Case "Half-Yearly"
                                intIntMode = 6
                            Case "Yearly"
                                intIntMode = 12
                        End Select
                        dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365), 2)
                        intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                        dblIntAmt = dblIntAmt / intNOD
                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpFDMatDate.Value)
                        End If
                        While (intNOM / intIntMode) >= intCounter
                            datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                            iv = lvInterest.Items.Add(intCounter)
                            'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                            iv.SubItems.Add(Round(dblIntAmt * intNOD, 2))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                            iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00"))
                            'dblFDAmount += Round(dblIntAmt * intNOD)
                            'dblTotalInt += Round(dblIntAmt * intNOD)
                            dblFDAmount += (dblIntAmt * intNOD)
                            dblTotalInt += (dblIntAmt * intNOD)
                            datFDDate = datNextDate
                            intCounter += 1
                        End While
                        intNOM = intNOM Mod intIntMode    'remaining no of months
                        datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate) 'get next date for remaining months
                        If datNextDate > dtpFDMatDate.Value Then
                            datNextDate = dtpFDMatDate.Value
                        End If
                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            Dim int As Integer = intNOD
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)  'days for remaining months
                            intNOD += Val(txtFDDays.Text) - int 'total remaining days
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)  'days for remaining months
                            intNOD += Val(txtFDDays.Text)  'total remaining days
                        End If
                        If intNOD > 0 Then
                            iv = lvInterest.Items.Add(intCounter)
                            iv.SubItems.Add(Round(dblIntAmt * intNOD))
                            iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00"))
                            dblFDAmount += Round(dblIntAmt * intNOD)
                            dblTotalInt += Round(dblIntAmt * intNOD)
                            datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                            intCounter += 1
                        End If
                    End If
                    'txtFDIntAmount.Text = Math.Round(dblTotalInt)
                    txtFDIntAmount.Text = (dblTotalInt)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Function



    Function FnCalInterest()
        If cmbFDType.Text <> "Quarterly" Then
            FnCalIntForOtherThanQterly()
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
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
        datMatdate = CDate(dtpFDMatDate.Value)
        Dim PerMonthIntAmt As Double
        Dim PerDayIntAmt As Double
        Dim PerQuerterIntAmt As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        Dim NoOfQurters As Decimal
        Dim OnlyMonth As Integer
        Dim Number As Decimal
        Dim IntegerResult As Integer

        If BTMMethod.Checked = True Then
            intCounter = 1
            Select Case cmbFDType.SelectedItem.ToString
                Case "Monthly"
                    intIntMode = 1
                Case "Quarterly"
                    intIntMode = 3
                Case "Half-Yearly"
                    intIntMode = 6
                Case "Yearly"
                    intIntMode = 12
            End Select

            dblFDAmt = CDbl(txtFDAmount.Text)
            dblROI = Val(txtFDROI.Text)
            dblIntAmt = Round((dblFDAmt * dblROI) / 100, 2) 'IntAmount without days

            If txtFDYears.Text <> String.Empty Then
                intNOD = (Val(txtFDYears.Text) * 365)
                intNOM += (Val(txtFDYears.Text) * 12)
            End If
            If txtFDMonths.Text <> String.Empty Then
                intNOD += (Val(txtFDMonths.Text) * 30)
                intNOM += Val(txtFDMonths.Text)
            End If
            If txtFDDays.Text <> String.Empty Then
                intNOD += Val(txtFDDays.Text)
            End If
            datFDDateTemp = dtpFDDate.Value
            lvInterest.Items.Clear()
            If dtpFDMatDate.Value < dtpNextDate.Value Then
                'intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                Counter += 1
                iv = lvInterest.Items.Add(Counter)
                iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                dblFDAmt += (PerDayIntAmt * intNOD)
                dblTotalInt += (PerDayIntAmt * intNOD)
                datFDDate = dtpFDMatDate.Value
                txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                'If Next querter date is different from the FDDate 
            ElseIf dtpNextDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpNextDate.Value)
                datMatdate = dtpFDMatDate.Value
                intNOD = DateDiff("d", datFDDateTemp, dtpNextDate.Value)
                ' dblIntAmtBelow = dblIntAmt * intNOD
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                dtpFDDate.Value = dtpNextDate.Value
                Counter += 1
                iv = lvInterest.Items.Add(Counter)
                iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                Dim t1 As Double = Round(PerDayIntAmt * intNOD) + dblFDAmt
                iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                dblFDAmt += Math.Round(PerDayIntAmt * intNOD)
                dblTotalInt += Math.Round(PerDayIntAmt * intNOD)
                datFDDate = dtpNextDate.Value
            End If
            'If NextQuerter date is same as the FDDate 
            If dtpNextDate.Value = dtpFDDate.Value Then
                datFDDate = CDate(dtpFDDate.Value)
                NoOfQurters = intNOM / 3 'per year
                PerQuerterIntAmt = Round(dblIntAmt / 4)
                PerMonthIntAmt = Round(dblIntAmt / 12) 'per year
                IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
                'Dim t As Decimal = CDec(Math.Truncate(NoOfQurters)) 'Important method for get only inter part of real number
                'per day
                'lvInterest.Items.Clear()
                intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
                'While IntegerResult > intCounter
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
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                    iv.SubItems.Add(Round(intNOD * PerDayIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                    iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                    'dblFDAmount += Round(dblIntAmt * intNOD)
                    'dblTotalInt += Round(dblIntAmt * intNOD)
                    dblFDAmt += Round(intNOD * PerDayIntAmt)
                    dblTotalInt += Round(intNOD * PerDayIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                End While
                OnlyMonth = intNOM Mod 3
                intNOD = DateDiff(DateInterval.Day, datFDDate, datMatdate)   'days for remaining months
                If intNOD > 0 Then
                    dblInitialFDAmt += dblIntAmt
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                    iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                    Dim t2 As Double = Round(PerDayIntAmt * intNOD) + dblFDAmt
                    iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                    intCounter += 1
                    dblFDAmt += (PerDayIntAmt * intNOD)
                    dblTotalInt += (PerDayIntAmt * intNOD)
                    datFDDate = dtpNextDate.Value
                End If

                'dblTotalInt = dblInitialFDAmt - dblFDAmount
                'dblFDAmount = dblInitialFDAmt
                txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))

            End If
            dtpFDDate.Value = datFDDateTemp
        End If
        If NaveenSirMtd.Checked = True Then  'Noncumulative for quterly for equal int amount generate 
            intCounter = 1
            Select Case cmbFDType.SelectedItem.ToString
                Case "Monthly"
                    intIntMode = 1
                Case "Quarterly"
                    intIntMode = 3
                Case "Half-Yearly"
                    intIntMode = 6
                Case "Yearly"
                    intIntMode = 12
            End Select

            dblFDAmt = CDbl(txtFDAmount.Text)
            dblROI = Val(txtFDROI.Text)
            dblIntAmt = Round((dblFDAmt * dblROI) / 100, 2) 'IntAmount without days

            If txtFDYears.Text <> String.Empty Then
                intNOD = (Val(txtFDYears.Text) * 365)
                intNOM += (Val(txtFDYears.Text) * 12)
            End If
            If txtFDMonths.Text <> String.Empty Then
                intNOD += (Val(txtFDMonths.Text) * 30)
                intNOM += Val(txtFDMonths.Text)
            End If
            If txtFDDays.Text <> String.Empty Then
                intNOD += Val(txtFDDays.Text)
            End If
            datFDDateTemp = dtpFDDate.Value
            lvInterest.Items.Clear()

            'code for If Next querter date is different from the FDDate 
            If dtpNextDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpNextDate.Value)
                datMatdate = dtpFDMatDate.Value
                intNOD = DateDiff("d", datFDDateTemp, dtpNextDate.Value)
                ' dblIntAmtBelow = dblIntAmt * intNOD
                PerDayIntAmt = Round(dblIntAmt / 365, 2)
                dtpFDDate.Value = dtpNextDate.Value
                Counter += 1
                iv = lvInterest.Items.Add(Counter)
                iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                dblFDAmt += Math.Round(PerDayIntAmt * intNOD)
                dblTotalInt += Math.Round(PerDayIntAmt * intNOD)
                datFDDate = dtpNextDate.Value
            End If
            'Code for If NextQuerter date is same as the FDDate 
            If dtpNextDate.Value = dtpFDDate.Value Then

                datFDDate = CDate(dtpFDDate.Value)
                NoOfQurters = intNOM / 3 'per year
                PerQuerterIntAmt = Round(dblIntAmt / 4)
                PerMonthIntAmt = Round(dblIntAmt / 12) 'per year
                IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
                'Dim t As Decimal = CDec(Math.Truncate(NoOfQurters)) 'Important method for get only inter part of real number
                'per day
                'lvInterest.Items.Clear()
                intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
                'While IntegerResult > intCounter
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
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    'iv.SubItems.Add(Round(dblIntAmt * intNOD))
                    iv.SubItems.Add(Round(PerQuerterIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    'iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00")) '
                    iv.SubItems.Add(Format(Round(PerQuerterIntAmt) + dblFDAmt))
                    'dblFDAmount += Round(dblIntAmt * intNOD)
                    'dblTotalInt += Round(dblIntAmt * intNOD)
                    dblFDAmt += Round(PerQuerterIntAmt)
                    dblTotalInt += Round(PerQuerterIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                    '''''''''''''''''''''''''''''''''''''''''
                    'datPrevDate = datNextDate
                    'datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    'intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    ' dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                    ' dblInitialFDAmt += dblIntAmt
                    ' iv = lvInterest.Items.Add(intCounter + Counter)
                    ' iv.SubItems.Add(Round(dblIntAmt))
                    '  iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    ' iv.SubItems.Add(Format(Round(dblInitialFDAmt), "0.00"))
                    ' dblTotalInt += dblIntAmt
                    ' datFDDate = datNextDate

                End While
                OnlyMonth = intNOM Mod 3
                intNOD = DateDiff(DateInterval.Day, datFDDate, datMatdate)   'days for remaining months
                intNOD += Val(txtFDDays.Text)  'total remaining days

                If intNOD > 0 Then
                    ' dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                    dblInitialFDAmt += dblIntAmt
                    iv = lvInterest.Items.Add(intCounter + Counter)
                    iv.SubItems.Add(Round(PerDayIntAmt * intNOD))
                    iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                    iv.SubItems.Add(Format(Round(PerDayIntAmt * intNOD) + dblFDAmt))
                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                    intCounter += 1
                    dblFDAmt += (PerDayIntAmt * intNOD)
                    dblTotalInt += (PerDayIntAmt * intNOD)
                    datFDDate = dtpNextDate.Value
                End If

                'dblTotalInt = dblInitialFDAmt - dblFDAmount
                'dblFDAmount = dblInitialFDAmt
                txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                'If OnlyMonth > 0 Then
                '    iv = lvInterest.Items.Add(intCounter)
                '    iv.SubItems.Add(Round(PerMonthIntAmt * OnlyMonth))
                '    iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
                '    iv.SubItems.Add(Format(Round(PerMonthIntAmt * OnlyMonth) + dblFDAmt, "0.00"))
                '    dblFDAmt += Round(PerMonthIntAmt * OnlyMonth)
                '    dblTotalInt += Round(PerMonthIntAmt * OnlyMonth)
                '    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                '    intCounter += 1
                'End If
                'txtFDIntAmount.Text = Math.Round(dblTotalInt)
                'txtFDIntAmount.Text = (dblTotalInt)
                'Else
                '    ' Near querter calculation
                '    lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
                '    datMatdate = dtpFDMatDate.Value
                '    intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpNextDate.Value)
                '    dblIntAmtBelow = ((dblFDAmt * dblROI) / (365 * 100)) * intNOD

                '    'dtpFDDate.Value = dtpNextDate.Value
                '    Counter += 1
                '    iv = lvInterest.Items.Add(Counter)
                '    iv.SubItems.Add(Round(dblIntAmtBelow, 2))
                '    iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                '    iv.SubItems.Add(Format(Round(dblIntAmtBelow) + dblFDAmt, "0.00"))
                '    datFDDate = dtpNextDate.Value


            End If
            dtpFDDate.Value = datFDDateTemp
        End If

        If StandardMtd.Checked = True Then
            If fnCheckFDDetails() = True Then
                Try
                    dblFDAmount = CDbl(txtFDAmount.Text)
                    dblInitialFDAmt = CDbl(txtFDAmount.Text)
                    dblFDAmt = CDbl(txtFDAmount.Text)
                    dblROI = Val(txtFDROI.Text)
                    intNOM = Val(txtFDMonths.Text)
                    intNOM += (Val(txtFDYears.Text) * 12)
                    intCounter = 1
                    lvInterest.Items.Clear()
                    If bolCumulative = True Then
                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 12
                                intMode = 1
                            Case "Quarterly"
                                intIntMode = 4
                                intMode = 3
                            Case "Half-Yearly"
                                intIntMode = 2
                                intMode = 6
                            Case "Yearly"
                                intIntMode = 1
                                intMode = 12
                        End Select
                        '' "Changes for cumulative cd "
                        dblTempFDTotal = FnCalculateCD(intIntMode)

                        datFDDateTemp = dtpFDDate.Value
                        If dtpNextDate.Value = dtpFDDate.Value Then
                            dtpFDDate.Value = dtpNextDate.Value
                            lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                            datFDDate = dtpFDDate.Value
                        Else
                            lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
                            datMatdate = dtpFDMatDate.Value
                            intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpNextDate.Value)
                            dblIntAmtBelow = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD

                            dtpFDDate.Value = dtpNextDate.Value
                            Counter += 1
                            iv = lvInterest.Items.Add(Counter)
                            iv.SubItems.Add(Round(dblIntAmtBelow, 2))
                            iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblIntAmtBelow, 2) + dblFDAmount))
                            datFDDate = dtpNextDate.Value
                            dblFDAmount += Round(dblIntAmtBelow)

                        End If
                        dblIntAmtBelow += dblFDAmount
                        ''endchanges 
                        x = (1 + ((Val(txtFDROI.Text)) / (intIntMode * 100)))
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

                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Math.Round(dblTemp, 2))
                            'iv.SubItems.Add(Math.Round(dblTemp, 3))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTemp, 2) + Math.Round(dblFDAmount, 2))
                            'iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
                            iv.SubItems.Add((dblTemp) + (dblFDAmount))
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
                        If datNextDate > dtpFDMatDate.Value Then
                            datNextDate = dtpFDMatDate.Value
                        End If

                        If intNOD > 0 Then
                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Math.Round(dblTempFDTotal - dblFDAmount, 2))
                            iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Math.Round(dblTempFDTotal, 2))
                        End If
                        txtFDMatAmount.Text = Convert.ToString(dblTempFDTotal)
                        txtFDIntAmount.Text = Convert.ToString(dblTempFDTotal - Convert.ToDouble(txtFDAmount.Text))
                    Else            'for NON-CUMULATIVE 

                        Select Case cmbFDType.SelectedItem.ToString
                            Case "Monthly"
                                intIntMode = 1
                            Case "Quarterly"
                                intIntMode = 3
                            Case "Half-Yearly"
                                intIntMode = 6
                            Case "Yearly"
                                intIntMode = 12
                        End Select
                        '' "Changes"

                        datFDDateTemp = dtpFDDate.Value
                        If dtpNextDate.Value = dtpFDDate.Value Then
                            dtpFDDate.Value = dtpNextDate.Value
                            lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
                            datFDDate = dtpFDDate.Value
                        Else
                            lngPeriod = DateDiff(DateInterval.Day, dtpNextDate.Value, dtpFDMatDate.Value)
                            datMatdate = dtpFDMatDate.Value
                            intNOD = DateDiff(DateInterval.Day, datFDDateTemp, dtpNextDate.Value)
                            dblIntAmtBelow = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD

                            dtpFDDate.Value = dtpNextDate.Value
                            Counter += 1
                            iv = lvInterest.Items.Add(Counter)
                            iv.SubItems.Add(Round(dblIntAmtBelow, 2))
                            iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblIntAmtBelow) + dblFDAmount, "0.00"))
                            datFDDate = dtpNextDate.Value
                        End If

                        ''endchanges 
                        dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365), 2)
                        intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, datMatdate)

                        dblInitialFDAmt += dblIntAmtBelow

                        intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
                        End If

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
                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Round(dblIntAmt))
                            iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblInitialFDAmt), "0.00"))
                            dblTotalInt += dblIntAmt
                            datFDDate = datNextDate

                            intCounter += 1
                        End While
                        intNOM = intNOM Mod intIntMode    'remaining no of months
                        datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate) 'get next date for remaining months
                        intNOD = DateDiff(DateInterval.Day, datPrevDate, datMatdate)
                        If datNextDate > dtpFDMatDate.Value Then
                            datNextDate = dtpFDMatDate.Value
                        End If

                        If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
                            Dim int As Integer = intNOD
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datMatdate)  'days for remaining months
                            intNOD += Val(txtFDDays.Text) - int 'total remaining days
                        Else
                            intNOD = DateDiff(DateInterval.Day, datFDDate, datMatdate)  'days for remaining months
                            intNOD += Val(txtFDDays.Text)  'total remaining days
                        End If

                        If intNOD > 0 Then
                            dblIntAmt = ((dblFDAmount * dblROI) / (365 * 100)) * intNOD
                            dblInitialFDAmt += dblIntAmt
                            iv = lvInterest.Items.Add(intCounter + Counter)
                            iv.SubItems.Add(Round((dblIntAmt)))
                            iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                            iv.SubItems.Add(Format(Round(dblInitialFDAmt), "0.00"))
                            datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
                            intCounter += 1
                        End If

                        dblTotalInt = dblInitialFDAmt - dblFDAmount
                        dblFDAmount = dblInitialFDAmt
                        txtFDMatAmount.Text = Convert.ToString(Round(dblInitialFDAmt))
                        txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                    End If
                    dtpFDDate.Value = datFDDateTemp

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If





        ''    Dim intNOM As Integer = 0
        ''    Dim intNOD As Integer = 0
        ''    Dim dblFDAmount As Double
        ''    Dim dblIntAmt As Double = 0
        ''    Dim dblTotalInt As Double = 0
        ''    Dim dblROI As Double = 0
        ''    Dim intCounter1 As Integer = 0
        ''    Dim intCounter As Integer = 0
        ''    Dim lngPeriod As Double = 0
        ''    Dim intIntMode As Integer = 0
        ''    Dim intMode As Integer = 0
        ''    Dim iv As ListViewItem
        ''    Dim dblFDAmt As Double = 0
        ''    Dim x, y As Double
        ''    Dim intTempPeriod As Integer
        ''    Dim dblTempPower As Double

        ''    Dim datNextDate As Date
        ''    Dim intDivide As Integer
        ''    Dim datMatdate As Date
        ''    Dim intQuater As Integer = 0

        ''    '''''''''''
        ''    Dim tempMonth As Integer
        ''    Dim temp As Integer = 0
        ''    Dim tempDayAmount As Double = 0
        ''    Dim dblTemp As Double
        ''    Dim dblPrev As Double

        ''    datFDDate = CDate(dtpFDDate.Value)
        ''    lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)

        ''    datMatdate = CDate(dtpFDMatDate.Value)

        ''    If fnCheckFDDetails() = True Then

        ''        Try
        ''            dblFDAmount = CDbl(txtFDAmount.Text)
        ''            dblFDAmt = CDbl(txtFDAmount.Text)
        ''            dblROI = Val(txtFDROI.Text)
        ''            intNOM = Val(txtFDMonths.Text)
        ''            intNOM += (Val(txtFDYears.Text) * 12)
        ''            intCounter = 1
        ''            lvInterest.Items.Clear()

        ''            If bolCumulative = True Then
        ''                Select Case cmbFDType.SelectedItem.ToString
        ''                    Case "Monthly"
        ''                        intIntMode = 12
        ''                        intMode = 1
        ''                    Case "Quarterly"
        ''                        intIntMode = 4
        ''                        intMode = 3
        ''                    Case "Half-Yearly"
        ''                        intIntMode = 2
        ''                        intMode = 6
        ''                    Case "Yearly"
        ''                        intIntMode = 1
        ''                        intMode = 12
        ''                End Select


        ''                x = (1 + ((Val(txtFDROI.Text)) / (intIntMode * 100)))
        ''                intTempPeriod = intMode

        ''                While (intNOM / intMode) >= intCounter
        ''                    y = (Val(intTempPeriod) / intMode)
        ''                    dblTempPower = Math.Pow(x, y)
        ''                    dblIntAmt = (Val(txtFDAmount.Text) * (dblTempPower)) - Val(txtFDAmount.Text)
        ''                    datNextDate = DateAdd(DateInterval.Month, intMode, datFDDate)
        ''                    dblTemp = dblIntAmt - dblPrev

        ''                    iv = lvInterest.Items.Add(intCounter + 1)
        ''                    iv.SubItems.Add(Math.Round(dblTemp))
        ''                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
        ''                    iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
        ''                    dblPrev = dblIntAmt
        ''                    dblFDAmount += Math.Round(dblTemp)
        ''                    datFDDate = datNextDate
        ''                    dblTotalInt += Math.Round(dblTemp)
        ''                    intTempPeriod += intMode
        ''                    intCounter += 1
        ''                End While
        ''                intNOM = intNOM Mod intMode

        ''                If intNOM > 0 Then
        ''                    intTempPeriod -= intMode
        ''                    intTempPeriod += intNOM
        ''                    y = (Val(intTempPeriod) / intMode)
        ''                    dblTempPower = Math.Pow(x, y)
        ''                    dblIntAmt = (Val(txtFDAmount.Text) * (dblTempPower)) - Val(txtFDAmount.Text)
        ''                    datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate)
        ''                    dblTemp = dblIntAmt - dblPrev

        ''                    iv = lvInterest.Items.Add(intCounter + 1)
        ''                    iv.SubItems.Add(Math.Round(dblTemp))
        ''                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
        ''                    iv.SubItems.Add(Math.Round(dblTemp) + Math.Round(dblFDAmount))
        ''                    dblPrev = dblIntAmt
        ''                    dblFDAmount += Math.Round(dblTemp)
        ''                    datFDDate = datNextDate
        ''                    dblTotalInt += Math.Round(dblTemp)
        ''                    intTempPeriod += intMode
        ''                End If
        ''            Else            'for NON-CUMULATIVE 

        ''                Select Case cmbFDType.SelectedItem.ToString
        ''                    Case "Monthly"
        ''                        intIntMode = 1
        ''                    Case "Quarterly"
        ''                        intIntMode = 3
        ''                    Case "Half-Yearly"
        ''                        intIntMode = 6
        ''                    Case "Yearly"
        ''                        intIntMode = 12
        ''                End Select

        ''                dblIntAmt = Round((dblFDAmount * lngPeriod * dblROI) / (100 * 365), 2)
        ''                dblTotalInt = dblIntAmt

        ''                intNOD = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
        ''                dblIntAmt = dblIntAmt / intNOD

        ''                If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
        ''                    intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpFDMatDate.Value)
        ''                End If

        ''                While (intNOM / intIntMode) >= intCounter
        ''                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
        ''                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
        ''                    iv = lvInterest.Items.Add(intCounter)
        ''                    iv.SubItems.Add(Round(dblIntAmt * intNOD))
        ''                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
        ''                    iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00"))
        ''                    dblFDAmount += Round(dblIntAmt * intNOD)
        ''                    datFDDate = datNextDate
        ''                    intCounter += 1
        ''                End While
        ''                intNOM = intNOM Mod intIntMode    'remaining no of months
        ''                datNextDate = DateAdd(DateInterval.Month, intNOM, datFDDate) 'get next date for remaining months
        ''                If datNextDate > dtpFDMatDate.Value Then
        ''                    datNextDate = dtpFDMatDate.Value
        ''                End If
        ''                If txtFDYears.Text = "" And txtFDMonths.Text = "" Then
        ''                    Dim int As Integer = intNOD
        ''                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)  'days for remaining months
        ''                    intNOD += Val(txtFDDays.Text) - int 'total remaining days
        ''                Else
        ''                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)  'days for remaining months
        ''                    intNOD += Val(txtFDDays.Text)  'total remaining days
        ''                End If

        ''                If dblIntAmt > 0 Then
        ''                    iv = lvInterest.Items.Add(intCounter)
        ''                    iv.SubItems.Add(Round(dblIntAmt * intNOD))
        ''                    iv.SubItems.Add(Format(dtpFDMatDate.Value, "dd-MMM-yyyy"))
        ''                    iv.SubItems.Add(Format(Round(dblIntAmt * intNOD) + dblFDAmount, "0.00"))
        ''                    dblFDAmount += Round(dblIntAmt * intNOD)
        ''                    datFDDate = DateAdd(DateInterval.Day, intNOD, datFDDate)
        ''                    intCounter += 1
        ''                End If

        ''            End If
        ''            txtFDIntAmount.Text = Math.Round(dblTotalInt)
        ''            '       txtFDMatAmount.Text = Val(txtFDAmount) + Math.Round(dblTotalInt)
        ''        Catch ex As Exception
        ''            MsgBox(ex.Message)
        ''        End Try
        ''    End If
    End Function
    Private Sub txtFDIntAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDIntAmount.TextChanged

        txtFDMatAmount.Text = Val(txtFDAmount.Text) + Val(txtFDIntAmount.Text)

    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged
        If cmbPeriod.SelectedItem = "As Scheme Period" Then
            bolCumulative = False
        Else
            objFDAcc.SchemeCode = cmbSchemeType.SelectedValue
            If objFDAcc.fnCheckScheme() Then
                dtMasterData = objFDAcc.FDMasterDetailTbl
                If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                    bolCumulative = True
                    objFDAcc.FDType = "C"
                Else
                    bolCumulative = False
                    objFDAcc.FDType = "N"
                End If

            End If
        End If

        txtFDAmount.Focus()
    End Sub

    Private Sub txtFDAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAmount.GotFocus
        txtFDROI.ResetText()
        Dim lngPeriod As Double = 0
        Dim dblROI As Double = 0
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
        If Val(txtFDDays.Text) = 0 Then
            lngPeriod -= 1
        End If

        If objFDAcc.fnGetROI(lngPeriod) Then
            If bolSCitizen = True Then
                dblROI = objFDAcc.FdMasterTbl.Rows(0).Item(0) + dtMasterData.Rows(0).Item("SCROI")
            Else
                dblROI = objFDAcc.FdMasterTbl.Rows(0).Item(0)
            End If
        End If

        If cmbPeriod.SelectedItem = "As Scheme Period" Then
            dblROI -= dtMasterData.Rows(0).Item("ReductionInt")
        End If

        txtFDROI.Text = Format(dblROI, "00.00")

    End Sub

    Private Sub lblAType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAType.Click

    End Sub
End Class
