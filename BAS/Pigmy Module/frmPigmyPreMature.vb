Public Class frmPigmyPreMature
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInterestAmount As BankControls.NumericControl
    Friend WithEvents txtTotalAmount As BankControls.NumericControl
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOtherAmount As BankControls.NumericControl
    Friend WithEvents txtPAccNo As BankControls.TextControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents cmbAGNo As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAGName As BankControls.TextControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPreROI As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBNNC As BankControls.NumericControl
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBNND As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPigmyPreMature))
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dtpWithDrawDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.cmbAGNo = New MTGCComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAGName = New BankControls.TextControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRefNo = New BankControls.NumericControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtBNND = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPreROI = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.btnCalInterest = New BankControls.NewButton
        Me.txtBNNC = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtInterestAmount = New BankControls.NumericControl
        Me.txtTotalAmount = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOtherAmount = New BankControls.NumericControl
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.Beige
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(432, 240)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(104, 40)
        Me.btnWithdraw.TabIndex = 10
        Me.btnWithdraw.Text = "Withdrawl"
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
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(552, 240)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 224)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dtpWithDrawDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtRefNo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(672, 195)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deposit Details"
        '
        'dtpWithDrawDate
        '
        Me.dtpWithDrawDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpWithDrawDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWithDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWithDrawDate.Location = New System.Drawing.Point(120, 16)
        Me.dtpWithDrawDate.Name = "dtpWithDrawDate"
        Me.dtpWithDrawDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpWithDrawDate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpMaturityDate)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.dtpDepositDate)
        Me.GroupBox1.Controls.Add(Me.cmbAGNo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtAGName)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPAccNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Maturity Date :"
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpMaturityDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpMaturityDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(424, 32)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpMaturityDate.TabIndex = 125
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(-2, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 17)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "Deposite Date:"
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDepositDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Enabled = False
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(112, 32)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpDepositDate.TabIndex = 123
        '
        'cmbAGNo
        '
        Me.cmbAGNo.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cmbAGNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbAGNo.ColumnNum = 2
        Me.cmbAGNo.ColumnWidth = "200;50"
        Me.cmbAGNo.DisplayMember = "Text"
        Me.cmbAGNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAGNo.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbAGNo.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmbAGNo.DropDownForeColor = System.Drawing.Color.Black
        Me.cmbAGNo.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.cmbAGNo.DropDownWidth = 270
        Me.cmbAGNo.Enabled = False
        Me.cmbAGNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAGNo.GridLineColor = System.Drawing.Color.LightGray
        Me.cmbAGNo.GridLineHorizontal = False
        Me.cmbAGNo.GridLineVertical = False
        Me.cmbAGNo.HighlightBorderColor = System.Drawing.Color.Blue
        Me.cmbAGNo.HighlightBorderOnMouseEvents = True
        Me.cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cmbAGNo.Location = New System.Drawing.Point(112, 67)
        Me.cmbAGNo.ManagingFastMouseMoving = True
        Me.cmbAGNo.ManagingFastMouseMovingInterval = 30
        Me.cmbAGNo.Name = "cmbAGNo"
        Me.cmbAGNo.NormalBorderColor = System.Drawing.Color.Black
        Me.cmbAGNo.Size = New System.Drawing.Size(160, 24)
        Me.cmbAGNo.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(314, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 16)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "Agent Name :"
        '
        'txtAGName
        '
        Me.txtAGName.AlphaNumeric = False
        Me.txtAGName.BlankSpace = False
        Me.txtAGName.Enabled = False
        Me.txtAGName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAGName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAGName.Location = New System.Drawing.Point(427, 67)
        Me.txtAGName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAGName.Mandatory = False
        Me.txtAGName.Name = "txtAGName"
        Me.txtAGName.Size = New System.Drawing.Size(160, 23)
        Me.txtAGName.SpecialChar = False
        Me.txtAGName.TabIndex = 8
        Me.txtAGName.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 16)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Agent No. :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(360, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BlankSpace = False
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(424, 1)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 7
        Me.txtName.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Account No :"
        '
        'txtPAccNo
        '
        Me.txtPAccNo.AlphaNumeric = True
        Me.txtPAccNo.BlankSpace = False
        Me.txtPAccNo.Enabled = False
        Me.txtPAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPAccNo.Location = New System.Drawing.Point(112, 0)
        Me.txtPAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPAccNo.Mandatory = False
        Me.txtPAccNo.MaxLength = 10
        Me.txtPAccNo.Name = "txtPAccNo"
        Me.txtPAccNo.Size = New System.Drawing.Size(120, 23)
        Me.txtPAccNo.SpecialChar = False
        Me.txtPAccNo.TabIndex = 4
        Me.txtPAccNo.TabStop = False
        Me.txtPAccNo.Text = "BNN"
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
        Me.btnSearch.Location = New System.Drawing.Point(248, -3)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Reference No. :"
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(432, 16)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(160, 23)
        Me.txtRefNo.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.txtBNND)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtPreROI)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtNarration)
        Me.TabPage2.Controls.Add(Me.btnCalInterest)
        Me.TabPage2.Controls.Add(Me.txtBNNC)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtROI)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtInterestAmount)
        Me.TabPage2.Controls.Add(Me.txtTotalAmount)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtOtherAmount)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(672, 195)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Interest Details"
        '
        'txtBNND
        '
        Me.txtBNND.AfterDecimal = 2
        Me.txtBNND.BackColor = System.Drawing.Color.White
        Me.txtBNND.BeforeDecimal = 7
        Me.txtBNND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBNND.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBNND.Location = New System.Drawing.Point(441, 10)
        Me.txtBNND.LostFocusColour = System.Drawing.Color.White
        Me.txtBNND.MaxValue = 0
        Me.txtBNND.MinValue = 0
        Me.txtBNND.Name = "txtBNND"
        Me.txtBNND.ReadOnly = True
        Me.txtBNND.Size = New System.Drawing.Size(128, 23)
        Me.txtBNND.TabIndex = 2
        Me.txtBNND.TabStop = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(290, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 17)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Piggmy Deposite :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(502, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 16)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "%"
        '
        'txtPreROI
        '
        Me.txtPreROI.AfterDecimal = 2
        Me.txtPreROI.BackColor = System.Drawing.Color.White
        Me.txtPreROI.BeforeDecimal = 8
        Me.txtPreROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreROI.GotFocusColour = System.Drawing.Color.White
        Me.txtPreROI.Location = New System.Drawing.Point(440, 74)
        Me.txtPreROI.LostFocusColour = System.Drawing.Color.White
        Me.txtPreROI.MaxLength = 10
        Me.txtPreROI.MaxValue = 0
        Me.txtPreROI.MinValue = 0
        Me.txtPreROI.Name = "txtPreROI"
        Me.txtPreROI.Size = New System.Drawing.Size(56, 23)
        Me.txtPreROI.TabIndex = 7
        Me.txtPreROI.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(320, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 17)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Penalty ROI :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(440, 109)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(212, 56)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 9
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(580, 9)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(79, 24)
        Me.btnCalInterest.TabIndex = 3
        Me.btnCalInterest.Text = "Calculate"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        '
        'txtBNNC
        '
        Me.txtBNNC.AfterDecimal = 2
        Me.txtBNNC.BackColor = System.Drawing.Color.White
        Me.txtBNNC.BeforeDecimal = 7
        Me.txtBNNC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBNNC.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBNNC.Location = New System.Drawing.Point(138, 19)
        Me.txtBNNC.LostFocusColour = System.Drawing.Color.White
        Me.txtBNNC.MaxValue = 0
        Me.txtBNNC.MinValue = 0
        Me.txtBNNC.Name = "txtBNNC"
        Me.txtBNNC.ReadOnly = True
        Me.txtBNNC.Size = New System.Drawing.Size(128, 23)
        Me.txtBNNC.TabIndex = 1
        Me.txtBNNC.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(502, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "%"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(440, 41)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(56, 23)
        Me.txtROI.TabIndex = 6
        Me.txtROI.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 17)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Piggmy Collection :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(292, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 17)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Rate of Interest :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 17)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Interest Amount :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 17)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Total Amount :"
        '
        'txtInterestAmount
        '
        Me.txtInterestAmount.AfterDecimal = 2
        Me.txtInterestAmount.BackColor = System.Drawing.Color.White
        Me.txtInterestAmount.BeforeDecimal = 7
        Me.txtInterestAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterestAmount.Location = New System.Drawing.Point(139, 53)
        Me.txtInterestAmount.LostFocusColour = System.Drawing.Color.White
        Me.txtInterestAmount.MaxValue = 0
        Me.txtInterestAmount.MinValue = 0
        Me.txtInterestAmount.Name = "txtInterestAmount"
        Me.txtInterestAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtInterestAmount.TabIndex = 4
        Me.txtInterestAmount.TabStop = False
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AfterDecimal = 2
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BeforeDecimal = 7
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotalAmount.Location = New System.Drawing.Point(141, 123)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.White
        Me.txtTotalAmount.MaxValue = 0
        Me.txtTotalAmount.MinValue = 0
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtTotalAmount.TabIndex = 5
        Me.txtTotalAmount.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Penalty Amount :"
        '
        'txtOtherAmount
        '
        Me.txtOtherAmount.AfterDecimal = 2
        Me.txtOtherAmount.BeforeDecimal = 7
        Me.txtOtherAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherAmount.Location = New System.Drawing.Point(140, 89)
        Me.txtOtherAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherAmount.MaxValue = 0
        Me.txtOtherAmount.MinValue = 0
        Me.txtOtherAmount.Name = "txtOtherAmount"
        Me.txtOtherAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtOtherAmount.TabIndex = 4
        '
        'frmPigmyPreMature
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(690, 285)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPigmyPreMature"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piggmy PreMature"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Single instance creation"

    Private Shared m_FormDefInstance As frmPigmyPreMature
    Private Shared m_InitilizeDefInstance As Boolean

    Public Shared Property DefInstance() As frmPigmyPreMature
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitilizeDefInstance = True
                m_FormDefInstance = New frmPigmyPreMature
                m_InitilizeDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmPigmyPreMature)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Varaibles"

    Dim objPGAcc As New clsPigmyAccount
    Public strAccNo As String
    Public strName As String
    Dim intDateDiff As Integer
    Dim intMonthDiff As Integer

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If txtPAccNo.Text = String.Empty Then
            MsgBox("Please select the agent ID", MsgBoxStyle.Information)
            txtPAccNo.Focus()
            Return False
        ElseIf txtName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf Val(txtBNNC.Text) <> 0 Then
            MsgBox("Please transfer BNNC amount to BNND", MsgBoxStyle.Information)
            txtBNNC.Focus()
            Return False
        ElseIf txtTotalAmount.Text = String.Empty Or Val(txtTotalAmount.Text) = 0 Then
            MsgBox("Please run interest calculation", MsgBoxStyle.Information)
            btnCalInterest.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference no cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnCheckRefNo() As Boolean

        If objPGAcc.fnCheckRefNo(txtRefNo.Text) Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnSetData() As Boolean

        objPGAcc.Amount = txtBNND.Text
        objPGAcc.Reference = txtRefNo.Text
        objPGAcc.TransDate = dtpWithDrawDate.Value
        objPGAcc.PGNo = txtPAccNo.Text
        objPGAcc.Narration = txtNarration.Text
        objPGAcc.intAmount = Val(txtInterestAmount.Text)
        objPGAcc.OtherCharge = Val(txtOtherAmount.Text)
        objPGAcc.MatAmount = Val(txtTotalAmount.Text)
        objPGAcc.AgnetNo = cmbAGNo.SelectedItem.col1

        Return True

    End Function

    Public Function fnClear()

        txtRefNo.Text = ""
        txtPAccNo.Text = "BNN"
        txtNarration.Text = ""
        txtName.Text = ""
        txtAGName.ResetText()
        txtBNNC.ResetText()
        txtBNND.ResetText()
        txtInterestAmount.Text = String.Empty

        txtOtherAmount.ResetText()
        txtTotalAmount.ResetText()
        txtROI.ResetText()

    End Function

    Sub sbGetAgents()

        Dim objClsAgets As New clsPigmyAgent
        Dim dtAgents As DataTable
        If objClsAgets.fnGetAgents() Then

            dtAgents = objClsAgets.getAgentsTable
            cmbAGNo.Items.Clear()
            cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            cmbAGNo.SourceDataString = New String(1) {"AgentID", "AgentName"}
            cmbAGNo.SourceDataTable = dtAgents

        End If

    End Sub

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpWithDrawDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Premature by " & txtPAccNo.Text & " Narration:" & txtNarration.Text

        objPGAcc.fnWithDrawlData(lngVoucherNo, strNarration, objTrans) 'To insert into RD Transaction table
        objPGAcc.fnUpdateStatus(txtPAccNo.Text, lngVoucherNo, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtPAccNo.Text, txtRefNo.Text, dtpWithDrawDate.Value, txtTotalAmount.Text, "Premature by " & txtPAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithDrawDate.Value, "Premature by " & txtPAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        '''First one for the ledger no 123 i.e BNN Ledger
        '''Second is for the legere no 31 i.e Interest on BNN Ledger
        fnVoucherEnterSub(lngVoucherNo, 1, txtPAccNo.Text, dtpWithDrawDate.Value, "Premature by " & txtPAccNo.Text, "By", 123, Val(txtBNND.Text), 0, 2, "Y", objTrans)
        fnVoucherEnterSub(lngVoucherNo, 1, txtPAccNo.Text, dtpWithDrawDate.Value, "PreMature interest by " & txtPAccNo.Text, "By", 31, Val(txtInterestAmount.Text), 0, 3, "Y", objTrans)

        If txtOtherAmount.Text <> "" Or Val(txtOtherAmount.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtPAccNo.Text, dtpWithDrawDate.Value, "Misc charges paid by " & txtPAccNo.Text, "To", 13, 0, Val(txtOtherAmount.Text), 4, "Y", objTrans)
        End If

        Return True

    End Function

    Public Function fnGetPigmyAccDet() As Boolean

        If objPGAcc.fnGetPGAccountDetails(txtPAccNo.Text) Then
            txtBNNC.Text = objPGAcc.PGAccTable.Rows(0).Item("AvailCollection")
            txtBNND.Text = objPGAcc.PGAccTable.Rows(0).Item("AvailDeposit")
            txtROI.Text = objPGAcc.PGAccTable.Rows(0).Item("ROI")
            dtpMaturityDate.Value = Format(objPGAcc.PGAccTable.Rows(0).Item("MaturityDate"), "yyyy-MM-dd")
            dtpDepositDate.Value = Format(objPGAcc.PGAccTable.Rows(0).Item("AccDate"), "yyyy-MM-dd")
            cmbAGNo.Text = objPGAcc.PGAccTable.Rows(0).Item("AgentNo")
        End If

    End Function

    Public Function fnCalInterest() As Boolean

        If objPGAcc.fnGetPGAccountDetails(txtPAccNo.Text) Then
            intDateDiff = DateDiff(DateInterval.DayOfYear, objPGAcc.PGAccTable.Rows(0).Item("AccDate"), dtpWithDrawDate.Value) ' / 30
            'intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, dtpFDMatDate.Value)
            'intMonthDiff = DateDiff(DateInterval.DayOfYear, objPGAcc.PGAccTable.Rows(0).Item("AccDate"), dtpWithDrawDate.Value) / 30
            intMonthDiff = DateDiff(DateInterval.Month, objPGAcc.PGAccTable.Rows(0).Item("AccDate"), dtpWithDrawDate.Value)
            'If fnCheckPeriod() Then
            If fnChkPreMaturity() Then
                'If fnPostInterest() Then
                'End If
            End If
        End If

    End Function
    Public Function fnGetROI() As Boolean

        If objPGAcc.fnGetMinPeriod() Then
            txtPreROI.Text = objPGAcc.MinPeriodtable.Rows(0).Item("BankCharges")
        Else
            txtPreROI.ResetText()
        End If

    End Function


#End Region


#Region "Events"

    Private Sub frmPigmyDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'dtpMaturityDate.MaxDate = Date.Now
        dtpWithDrawDate.MaxDate = Date.Now

        dtpMaturityDate.Value = Date.Now
        dtpWithDrawDate.Value = Date.Now

        txtPAccNo.Text = strAccNo
        txtName.Text = strName
        sbGetAgents()
        fnGetPigmyAccDet()
        fnGetROI()

    End Sub

    Public Function fnCheckPeriod() As Boolean

        If objPGAcc.fnGetMinPeriod Then
            If intDateDiff > 12 Then
                MsgBox("Sorry,BNN period is greater than 12 months " & Chr(13) & "This transaction can be done with BNN closure form", MsgBoxStyle.Exclamation, "BNN Module")
                Return False
            Else
                fnChkPreMaturity()
                Return False
            End If
        End If

    End Function

    Public Function fnCalculateTot()
        txtTotalAmount.Text = Math.Round(Val(txtBNND.Text) - Val(txtInterestAmount.Text) - Val(txtOtherAmount.Text))
    End Function

    Public Function fnChkPreMaturity() As Boolean

        If intMonthDiff > 12 Then
            MsgBox("Sorry,BNN period is greater than 12 months " & Chr(13) & " This transaction can be done with BNN Closure form", MsgBoxStyle.Exclamation, "BNN Module")
            Return False
        ElseIf MsgBox("Do you want to premature this account", MsgBoxStyle.YesNo, "BNN Module") = MsgBoxResult.Yes Then
            'fnCalPreMaturity()

            Dim dblBalance As Double
            Dim dblROI As Double
            Dim dblPreROI As Double
            Dim BI As Double
            Dim CalSixthMonth As Integer
            Dim day As Integer
            Dim month As Integer
            Dim year As Integer
            Dim ColserDate As Date
            Dim DateStringFormat As String
            Dim MinPeriods As Integer
            Dim BankCharges As Integer
            Dim ROI As Integer
            If objPGAcc.fnGetMinPeriod Then
                day = dtpDepositDate.Value.Day
                month = dtpDepositDate.Value.Month
                year = dtpDepositDate.Value.Year
                MinPeriods = Convert.ToInt32(objPGAcc.MinPeriodtable.Rows(0).Item("MinPeriod"))
                BankCharges = Convert.ToInt32(objPGAcc.MinPeriodtable.Rows(0).Item("BankCharges"))
                ROI = Convert.ToInt32(objPGAcc.MinPeriodtable.Rows(0).Item("ROI"))
                CalSixthMonth = month + MinPeriods
                dblBalance = Val(txtBNND.Text)
                dblROI = Val(txtPreROI.Text)
                If CalSixthMonth > 12 Then
                    CalSixthMonth = CalSixthMonth - 12
                    year = year + 1
                End If
                DateStringFormat = " " & day & "-" & CalSixthMonth.ToString("00") & "-" & year & ""
                'Dim ConvertToDate As New Date(DateStringFormat(0), DateStringFormat(1), DateStringFormat(2))"
                'Dim ConvertToDate As Date = Date.ParseExact(DateStringFormat, "dd-MM-yyyy", _
                '    Globalization.CultureInfo.InvariantCulture)

                Dim ConvertToDate As Date = Date.Parse(DateStringFormat)

                ColserDate = dtpWithDrawDate.Value
                If ColserDate.Date < ConvertToDate.Date Then
                    MsgBox(dblROI, )

                    Dim PeneltAmt As Double = Math.Round((dblBalance * dblROI) / 100, 2)
                    txtOtherAmount.Text = Math.Round(PeneltAmt)
                Else
                    txtOtherAmount.Text = 0
                End If
                ' If intMonthDiff < objPGAcc.MinPeriodtable.Rows(0).Item("MinPeriod") Then

                'BI = Math.Round((dblBalance * dblROI * intDateDiff) / (365 * 100), 2)
                'txtInterestAmount.Text = Math.Round(BI)
                'ElseIf intMonthDiff >= objPGAcc.MinPeriodtable.Rows(0).Item("MinPeriod") And intMonthDiff <= 12 Then
                txtInterestAmount.Text = 0
                'End If
            End If


        Else
            Return True
        End If

    End Function

    Public Function fnCalPreMaturity() As Boolean

        Dim dblBalance As Double
        Dim dblROI As Double
        Dim dblPreROI As Double
        Dim BI As Double
        Dim CalSixthMonth As Integer
        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim ColserDate As Date
        Dim DateStringFormat As String
        Dim MinPeriods As Integer
        Dim BankCharges As Integer
        Dim ROI As Integer
        If objPGAcc.fnGetMinPeriod Then
            day = dtpDepositDate.Value.Day
            month = dtpDepositDate.Value.Month
            year = dtpDepositDate.Value.Year
            MinPeriods = Convert.ToInt32(objPGAcc.MinPeriodtable.Rows(0).Item("MinPeriod"))
            BankCharges = Convert.ToInt32(objPGAcc.MinPeriodtable.Rows(0).Item("BankCharges"))
            ROI = Convert.ToInt32(objPGAcc.MinPeriodtable.Rows(0).Item("ROI"))
            CalSixthMonth = month + MinPeriods
            dblBalance = Val(txtBNND.Text)
            dblROI = Val(txtPreROI.Text)
            If CalSixthMonth > 12 Then
                CalSixthMonth = CalSixthMonth - 12
                year = year + 1
            End If
            DateStringFormat = " " & day & "-" & CalSixthMonth & "-" & year & ""
            'Dim ConvertToDate As New Date(DateStringFormat(0), DateStringFormat(1), DateStringFormat(2))"
            Dim ConvertToDate As Date = Date.Parse(DateStringFormat)
            'Dim ConvertToDate As Date = Date.Parse( Format ( DateStringFormat,"yyyy-MM-dd"))

            ColserDate = dtpWithDrawDate.Value
            If ColserDate.Date < ConvertToDate.Date Then
                MsgBox(dblROI)

                Dim PeneltAmt As Double = Math.Round((dblBalance * dblROI) / 100, 2)
                txtOtherAmount.Text = Math.Round(PeneltAmt)
            Else
                txtOtherAmount.Text = 0
            End If
            ' If intMonthDiff < objPGAcc.MinPeriodtable.Rows(0).Item("MinPeriod") Then

            'BI = Math.Round((dblBalance * dblROI * intDateDiff) / (365 * 100), 2)
            'txtInterestAmount.Text = Math.Round(BI)
            'ElseIf intMonthDiff >= objPGAcc.MinPeriodtable.Rows(0).Item("MinPeriod") And intMonthDiff <= 12 Then
            txtInterestAmount.Text = 0
            'End If
        End If

    End Function


#End Region



    Private Sub txtPGAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPAccNo.TextChanged
        If txtPAccNo.Text.StartsWith("BNN") = False Then
            txtPAccNo.Undo()
            txtPAccNo.ClearUndo()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnCheckRefNo() = False Then
                    If fnSetData() Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Premature by " & txtPAccNo.Text & " Amount " & txtTotalAmount.Text, Date.Now, "Transaction Premature", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed successfully,do u want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            fnClear()
                        Else
                            Me.Close()
                        End If
                    Else
                        MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Exclamation, "BNN Module")
                    End If
                Else
                    MsgBox("Reference no already exist,please try other reference no", MsgBoxStyle.Exclamation, "BNN Module")
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objfrmPigmyCust As New frmPGCust
        objfrmPigmyCust.ShowDialog()
        txtPAccNo.Text = objfrmPigmyCust.strPGNo
        txtName.Text = objfrmPigmyCust.strPGName
        fnGetPigmyAccDet()
        fnGetROI()
    End Sub

    Private Sub cmbAGNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAGNo.SelectedIndexChanged
        txtAGName.Text = cmbAGNo.SelectedItem.col2
    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        fnCalInterest()
    End Sub


    Private Sub txtTotalAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmount.TextChanged

    End Sub

    Private Sub txtNarration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNarration.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub
End Class
