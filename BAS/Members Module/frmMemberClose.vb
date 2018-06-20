Public Class frmMemberClose
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfShares As BankControls.TextControl
    Friend WithEvents txtShareAmount As BankControls.TextControl
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpOpenDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpApplDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSBNo As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpClosingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberClose))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtShareAmount = New BankControls.TextControl()
        Me.txtNoOfShares = New BankControls.TextControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClose = New BankControls.NewButton()
        Me.btnExit = New BankControls.NewButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtReceiptNo = New BankControls.NumericControl()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSBNo = New BankControls.TextControl()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbAccountType = New System.Windows.Forms.ComboBox()
        Me.dtpOpenDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpApplDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnShow = New BankControls.NewButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMemberNo = New BankControls.TextControl()
        Me.txtName = New BankControls.TextControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpClosingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmbStatus)
        Me.Panel2.Controls.Add(Me.txtShareAmount)
        Me.Panel2.Controls.Add(Me.txtNoOfShares)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Enabled = False
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(336, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 136)
        Me.Panel2.TabIndex = 10
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Closed"})
        Me.cmbStatus.Location = New System.Drawing.Point(136, 96)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(136, 24)
        Me.cmbStatus.TabIndex = 11
        '
        'txtShareAmount
        '
        Me.txtShareAmount.AlphaNumeric = True
        Me.txtShareAmount.BlankSpace = True
        Me.txtShareAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtShareAmount.Location = New System.Drawing.Point(136, 56)
        Me.txtShareAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtShareAmount.Mandatory = False
        Me.txtShareAmount.MaxLength = 20
        Me.txtShareAmount.Name = "txtShareAmount"
        Me.txtShareAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtShareAmount.SpecialChar = True
        Me.txtShareAmount.TabIndex = 10
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AlphaNumeric = True
        Me.txtNoOfShares.BlankSpace = False
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoOfShares.Location = New System.Drawing.Point(136, 16)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtNoOfShares.Mandatory = False
        Me.txtNoOfShares.MaxLength = 20
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.Size = New System.Drawing.Size(136, 23)
        Me.txtNoOfShares.SpecialChar = True
        Me.txtNoOfShares.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ShareAmount : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NoOfShares : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Present Status :  "
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(376, 280)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 40)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close Membership"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(504, 280)
        Me.btnExit.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Close"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "SBNo : "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtReceiptNo)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtSBNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.cmbAccountType)
        Me.Panel1.Controls.Add(Me.dtpOpenDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpApplDate)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 216)
        Me.Panel1.TabIndex = 1
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 2
        Me.txtReceiptNo.BackColor = System.Drawing.Color.White
        Me.txtReceiptNo.BeforeDecimal = 8
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtReceiptNo.Location = New System.Drawing.Point(160, 176)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0.0R
        Me.txtReceiptNo.MinValue = 0.0R
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(152, 23)
        Me.txtReceiptNo.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 16)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Receipt No : "
        '
        'txtSBNo
        '
        Me.txtSBNo.AlphaNumeric = True
        Me.txtSBNo.BackColor = System.Drawing.Color.White
        Me.txtSBNo.BlankSpace = True
        Me.txtSBNo.Enabled = False
        Me.txtSBNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBNo.Location = New System.Drawing.Point(160, 144)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.White
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Multiline = True
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.Size = New System.Drawing.Size(152, 20)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 104)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(0, 16)
        Me.Label29.TabIndex = 49
        '
        'cmbAccountType
        '
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.Enabled = False
        Me.cmbAccountType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountType.Items.AddRange(New Object() {"Share Capital A", "Share Capital B", "Souharda Risk Fund"})
        Me.cmbAccountType.Location = New System.Drawing.Point(160, 104)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(152, 24)
        Me.cmbAccountType.TabIndex = 7
        '
        'dtpOpenDate
        '
        Me.dtpOpenDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpOpenDate.Enabled = False
        Me.dtpOpenDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOpenDate.Location = New System.Drawing.Point(160, 64)
        Me.dtpOpenDate.MaxDate = New Date(9998, 9, 17, 0, 0, 0, 0)
        Me.dtpOpenDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpOpenDate.Name = "dtpOpenDate"
        Me.dtpOpenDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpOpenDate.TabIndex = 6
        Me.dtpOpenDate.Value = New Date(2007, 9, 17, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 5
        '
        'dtpApplDate
        '
        Me.dtpApplDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpApplDate.Enabled = False
        Me.dtpApplDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpApplDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApplDate.Location = New System.Drawing.Point(160, 24)
        Me.dtpApplDate.MaxDate = New Date(9998, 9, 17, 0, 0, 0, 0)
        Me.dtpApplDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpApplDate.Name = "dtpApplDate"
        Me.dtpApplDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpApplDate.TabIndex = 5
        Me.dtpApplDate.Value = New Date(2007, 9, 17, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 16)
        Me.Label18.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "ApplDate : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Membership Date : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 16)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Account Type : "
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnShow)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtMemberNo)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(8, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(608, 56)
        Me.Panel3.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Black
        Me.btnShow.GotFocusColour = System.Drawing.Color.Beige
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(248, 16)
        Me.btnShow.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(24, 24)
        Me.btnShow.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Member No. :"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.Color.White
        Me.txtMemberNo.BlankSpace = True
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMemberNo.Location = New System.Drawing.Point(112, 16)
        Me.txtMemberNo.LostFocusColour = System.Drawing.Color.White
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.Size = New System.Drawing.Size(152, 23)
        Me.txtMemberNo.SpecialChar = False
        Me.txtMemberNo.TabIndex = 3
        Me.txtMemberNo.TabStop = False
        Me.txtMemberNo.Text = "MB"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(368, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 10
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 80
        Me.txtName.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, -32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 16)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Closing Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd / MMM / yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, -24)
        Me.DateTimePicker1.MaxDate = New Date(2501, 9, 17, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 23)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2007, 9, 18, 0, 0, 0, 0)
        '
        'dtpClosingDate
        '
        Me.dtpClosingDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClosingDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosingDate.Location = New System.Drawing.Point(128, 16)
        Me.dtpClosingDate.MaxDate = New Date(9998, 9, 17, 0, 0, 0, 0)
        Me.dtpClosingDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpClosingDate.Name = "dtpClosingDate"
        Me.dtpClosingDate.Size = New System.Drawing.Size(176, 23)
        Me.dtpClosingDate.TabIndex = 0
        Me.dtpClosingDate.Value = New Date(2007, 9, 18, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 16)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Closing Date :"
        '
        'frmMemberClose
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(642, 335)
        Me.Controls.Add(Me.dtpClosingDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemberClose"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership  Close"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmMemberClose
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmMemberClose
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmMemberClose
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmMemberClose)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objClsMember As New clsMember
    Dim objLedger As New clsLedger

#End Region

#Region "Functions"

    Public Function fnLoadData() As Boolean
        Try
            If objClsMember.fnLoadCloseMember(txtMemberNo.Text) Then
                objClsMember.MemberNo = txtMemberNo.Text
                txtName.Text = objClsMember.CloseMemberDet.Rows(0).Item("Name")
                dtpApplDate.Value = Format(objClsMember.CloseMemberDet.Rows(0).Item("ApplDate"), "yyyy-MM-dd")
                dtpOpenDate.Value = Format(objClsMember.CloseMemberDet.Rows(0).Item("OpenDate"), "yyyy-MM-dd")
                txtNoOfShares.Text = objClsMember.CloseMemberDet.Rows(0).Item("NoOfShares")
                txtShareAmount.Text = objClsMember.CloseMemberDet.Rows(0).Item("ShareAmount")

                If IsDBNull(objClsMember.CloseMemberDet.Rows(0).Item("SBNo")) = True Then
                    txtSBNo.Text = 0
                Else
                    txtSBNo.Text = objClsMember.CloseMemberDet.Rows(0).Item("SBNo")
                End If

                If objClsMember.CloseMemberDet.Rows(0).Item("Type") = "SCA" Then
                    cmbAccountType.SelectedItem = "Share Capital A"
                ElseIf objClsMember.CloseMemberDet.Rows(0).Item("Type") = "SCB" Then
                    cmbAccountType.SelectedItem = "Share Capital B"
                Else
                    cmbAccountType.SelectedItem = "Souharda Risk Fund"
                End If

                If objClsMember.CloseMemberDet.Rows(0).Item("Status") = "Active" Then
                    cmbStatus.SelectedItem = "Active"
                ElseIf objClsMember.CloseMemberDet.Rows(0).Item("Status") = "Closed" Then
                    cmbStatus.SelectedItem = "Closed"
                End If

            End If

            txtReceiptNo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
        
    End Function

    Public Function fnClearData()

        txtSBNo.Text = String.Empty
        txtMemberNo.Text = String.Empty
        txtNoOfShares.Text = String.Empty
        txtShareAmount.Text = String.Empty
        txtName.Text = String.Empty
        txtMemberNo.Text = String.Empty
        cmbAccountType.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtReceiptNo.Text = String.Empty
        txtMemberNo.Text = "MB"

    End Function

    Public Function fnValidate() As Boolean

        'If objClsMember.fnCheckMember() = False Then
        '    MsgBox("Please Check The Account No", MsgBoxStyle.Exclamation, "Member Module")
        '    txtMemberNo.Focus()
        '    Return False
        If txtMemberNo.Text = "MB" Then
            MsgBox("Please check the account no", MsgBoxStyle.Exclamation, "Member Module")
            txtMemberNo.Focus()
            Return False
        ElseIf cmbStatus.SelectedItem <> "Active" Then
            MsgBox("Membership already closed", MsgBoxStyle.Exclamation, "Member Module")
            txtMemberNo.Focus()
            Return False
        ElseIf Val(txtReceiptNo.Text) = 0 Then
            MsgBox("Enter receipt number", MsgBoxStyle.Exclamation, "Member Module")
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Private Function fnCheckFund() As Boolean
        ''Check availabilities of cash (1 is the ledgerID)
        If (objLedger.fnGetCBalanceWRTLedger(1)) Then
            If (objLedger.LedgerTable.Rows(0).Item("Balance") > Val(txtShareAmount.Text)) Then
                Return True
            Else
                MsgBox("Insufficient fund,please check the cash", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpClosingDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Member Clouser By " & txtMemberNo.Text & ""

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtMemberNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, txtShareAmount.Text, "Clouser By " & txtMemberNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpClosingDate.Value, "Clouser By Mmember No " & txtMemberNo.Text, "To", 1, 0, Val(txtShareAmount.Text), 1, "Y", objTrans)

        If cmbAccountType.SelectedItem = "Share Capital A" Then
            fnVoucherEnterSub(lngVoucherNo, 1, txtMemberNo.Text, dtpClosingDate.Value, "Clouser By member No " & txtMemberNo.Text, "By", 3, Val(txtShareAmount.Text), 0, 2, "Y", objTrans)
        ElseIf cmbAccountType.SelectedItem = "Share Capital B" Then
            fnVoucherEnterSub(lngVoucherNo, 1, txtMemberNo.Text, dtpClosingDate.Value, "Clouser By member No " & txtMemberNo.Text, "By", 4, Val(txtShareAmount.Text), 0, 2, "Y", objTrans)
        Else
            fnVoucherEnterSub(lngVoucherNo, 1, txtMemberNo.Text, dtpClosingDate.Value, "Clouser By member No " & txtMemberNo.Text, "By", 5, Val(txtShareAmount.Text), 0, 2, "Y", objTrans)
        End If

        Return True

    End Function

#End Region

#Region "Events"

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim ObjMemberSearch As New frmMemberSearch
        ObjMemberSearch.ShowDialog(Me)
        txtMemberNo.Text = ObjMemberSearch.strMemberNo
        If ObjMemberSearch.strMemberNo = "" Then
            txtMemberNo.Text = "MB"
            btnShow.Focus()
        Else
            fnLoadData()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnValidate() Then
                If fnCheckFund() Then
                    fnGenerateVoucher(objTrans)
                    If objClsMember.fnCloseMembera(txtMemberNo.Text, dtpClosingDate.Value, objTrans) Then
                        fnLogEntry(pbUserId, "MemberShip Closed" & txtMemberNo.Text, Date.Now, "Member Module", objTrans)
                        objTrans.Commit()
                        MsgBox("Account closed successfully", MsgBoxStyle.Information, "Member Module")
                        fnClearData()
                    Else
                        MsgBox("Account cannot be closed due to internal error", MsgBoxStyle.Information, "Member Module")
                    End If
                End If
            End If
        Catch ex As Exception
            objTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub

    Private Sub frmMemberClose_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpClosingDate.Value = Date.Now
        dtpApplDate.Value = Date.Now
        dtpOpenDate.Value = Date.Now

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMemberNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberNo.TextChanged
        If Not txtMemberNo.Text.StartsWith("MB") Then
            txtMemberNo.Undo()
            txtMemberNo.ClearUndo()
        End If
    End Sub

#End Region

    
End Class
