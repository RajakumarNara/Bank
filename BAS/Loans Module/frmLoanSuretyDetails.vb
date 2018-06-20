Public Class frmLoanSuretyDetails
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents colSl As System.Windows.Forms.ColumnHeader
    Friend WithEvents colParticulars As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDatOfPurchase As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents colArea As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPresentValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAmtBorrowed As System.Windows.Forms.ColumnHeader
    Friend WithEvents colacquiredDetails As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbParticulars As System.Windows.Forms.ComboBox
    Friend WithEvents dtpYOP As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmtBorrowed As BankControls.NumericControl
    Friend WithEvents txtPreValue As BankControls.NumericControl
    Friend WithEvents txtLocation As BankControls.TextControl
    Friend WithEvents txtArea As BankControls.TextControl
    Friend WithEvents txtAcquiredStatus As BankControls.TextControl
    Friend WithEvents txtSurveyNo As BankControls.TextControl
    Friend WithEvents lvFixedAssets As System.Windows.Forms.ListView
    Friend WithEvents lvMovableAssets As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbMovParticulars As System.Windows.Forms.ComboBox
    Friend WithEvents txtMovAcquired As BankControls.TextControl
    Friend WithEvents txtMovPreValue As BankControls.NumericControl
    Friend WithEvents datMovYOP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMovDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMovAmtBorrowed As BankControls.NumericControl
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtLoanerName As BankControls.TextControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnAddFAsset As BankControls.NewButton
    Friend WithEvents btnAddMAssets As BankControls.NewButton
    Friend WithEvents txtMovAmtPaid As BankControls.NumericControl
    Friend WithEvents lblNomineeNo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMAssetNo As BankControls.TextControl
    Friend WithEvents txtFAssetNo As BankControls.TextControl
    Friend WithEvents colPCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSurHoNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLoanSuretyDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtFAssetNo = New BankControls.TextControl
        Me.btnAddFAsset = New BankControls.NewButton
        Me.txtSurveyNo = New BankControls.TextControl
        Me.txtAcquiredStatus = New BankControls.TextControl
        Me.txtArea = New BankControls.TextControl
        Me.txtLocation = New BankControls.TextControl
        Me.txtPreValue = New BankControls.NumericControl
        Me.txtAmtBorrowed = New BankControls.NumericControl
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.dtpYOP = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbParticulars = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvFixedAssets = New System.Windows.Forms.ListView
        Me.colSl = New System.Windows.Forms.ColumnHeader
        Me.colPCode = New System.Windows.Forms.ColumnHeader
        Me.colParticulars = New System.Windows.Forms.ColumnHeader
        Me.colType = New System.Windows.Forms.ColumnHeader
        Me.colStatus = New System.Windows.Forms.ColumnHeader
        Me.colDatOfPurchase = New System.Windows.Forms.ColumnHeader
        Me.colSurHoNo = New System.Windows.Forms.ColumnHeader
        Me.colLocation = New System.Windows.Forms.ColumnHeader
        Me.colArea = New System.Windows.Forms.ColumnHeader
        Me.colacquiredDetails = New System.Windows.Forms.ColumnHeader
        Me.colPresentValue = New System.Windows.Forms.ColumnHeader
        Me.colAmtBorrowed = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblNomineeNo = New System.Windows.Forms.Label
        Me.txtMAssetNo = New BankControls.TextControl
        Me.btnAddMAssets = New BankControls.NewButton
        Me.txtMovAmtPaid = New BankControls.NumericControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtpMovDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMovAcquired = New BankControls.TextControl
        Me.txtMovPreValue = New BankControls.NumericControl
        Me.txtMovAmtBorrowed = New BankControls.NumericControl
        Me.datMovYOP = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbMovParticulars = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lvMovableAssets = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.txtLoanNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtLoanerName = New BankControls.TextControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(16, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 400)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtFAssetNo)
        Me.TabPage1.Controls.Add(Me.btnAddFAsset)
        Me.TabPage1.Controls.Add(Me.txtSurveyNo)
        Me.TabPage1.Controls.Add(Me.txtAcquiredStatus)
        Me.TabPage1.Controls.Add(Me.txtArea)
        Me.TabPage1.Controls.Add(Me.txtLocation)
        Me.TabPage1.Controls.Add(Me.txtPreValue)
        Me.TabPage1.Controls.Add(Me.txtAmtBorrowed)
        Me.TabPage1.Controls.Add(Me.cmbStatus)
        Me.TabPage1.Controls.Add(Me.cmbType)
        Me.TabPage1.Controls.Add(Me.dtpYOP)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmbParticulars)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lvFixedAssets)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(976, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fixed Assets"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 19)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = " No. :"
        '
        'txtFAssetNo
        '
        Me.txtFAssetNo.AlphaNumeric = False
        Me.txtFAssetNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtFAssetNo.BlankSpace = False
        Me.txtFAssetNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAssetNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtFAssetNo.Location = New System.Drawing.Point(184, 16)
        Me.txtFAssetNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtFAssetNo.Mandatory = False
        Me.txtFAssetNo.Name = "txtFAssetNo"
        Me.txtFAssetNo.ReadOnly = True
        Me.txtFAssetNo.Size = New System.Drawing.Size(104, 23)
        Me.txtFAssetNo.SpecialChar = False
        Me.txtFAssetNo.TabIndex = 0
        Me.txtFAssetNo.TabStop = False
        Me.txtFAssetNo.Text = ""
        '
        'btnAddFAsset
        '
        Me.btnAddFAsset.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnAddFAsset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFAsset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddFAsset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFAsset.ForeColor = System.Drawing.Color.Black
        Me.btnAddFAsset.GotFocusColour = System.Drawing.Color.FromArgb(CType(201, Byte), CType(247, Byte), CType(181, Byte))
        Me.btnAddFAsset.Location = New System.Drawing.Point(824, 160)
        Me.btnAddFAsset.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnAddFAsset.Name = "btnAddFAsset"
        Me.btnAddFAsset.Size = New System.Drawing.Size(96, 40)
        Me.btnAddFAsset.TabIndex = 11
        Me.btnAddFAsset.Text = "&Add"
        '
        'txtSurveyNo
        '
        Me.txtSurveyNo.AlphaNumeric = True
        Me.txtSurveyNo.BlankSpace = True
        Me.txtSurveyNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurveyNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSurveyNo.Location = New System.Drawing.Point(184, 176)
        Me.txtSurveyNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSurveyNo.Mandatory = False
        Me.txtSurveyNo.MaxLength = 15
        Me.txtSurveyNo.Name = "txtSurveyNo"
        Me.txtSurveyNo.Size = New System.Drawing.Size(208, 23)
        Me.txtSurveyNo.SpecialChar = True
        Me.txtSurveyNo.TabIndex = 5
        Me.txtSurveyNo.Text = ""
        '
        'txtAcquiredStatus
        '
        Me.txtAcquiredStatus.AlphaNumeric = True
        Me.txtAcquiredStatus.AutoSize = False
        Me.txtAcquiredStatus.BlankSpace = False
        Me.txtAcquiredStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcquiredStatus.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAcquiredStatus.Location = New System.Drawing.Point(632, 104)
        Me.txtAcquiredStatus.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAcquiredStatus.Mandatory = False
        Me.txtAcquiredStatus.MaxLength = 100
        Me.txtAcquiredStatus.Multiline = True
        Me.txtAcquiredStatus.Name = "txtAcquiredStatus"
        Me.txtAcquiredStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcquiredStatus.Size = New System.Drawing.Size(272, 40)
        Me.txtAcquiredStatus.SpecialChar = True
        Me.txtAcquiredStatus.TabIndex = 8
        Me.txtAcquiredStatus.Text = ""
        '
        'txtArea
        '
        Me.txtArea.AlphaNumeric = True
        Me.txtArea.AutoSize = False
        Me.txtArea.BlankSpace = False
        Me.txtArea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtArea.Location = New System.Drawing.Point(632, 56)
        Me.txtArea.LostFocusColour = System.Drawing.Color.Empty
        Me.txtArea.Mandatory = False
        Me.txtArea.MaxLength = 100
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArea.Size = New System.Drawing.Size(272, 40)
        Me.txtArea.SpecialChar = True
        Me.txtArea.TabIndex = 7
        Me.txtArea.Text = ""
        '
        'txtLocation
        '
        Me.txtLocation.AlphaNumeric = True
        Me.txtLocation.AutoSize = False
        Me.txtLocation.BlankSpace = False
        Me.txtLocation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLocation.Location = New System.Drawing.Point(632, 8)
        Me.txtLocation.LostFocusColour = System.Drawing.Color.Empty
        Me.txtLocation.Mandatory = False
        Me.txtLocation.MaxLength = 100
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLocation.Size = New System.Drawing.Size(272, 40)
        Me.txtLocation.SpecialChar = True
        Me.txtLocation.TabIndex = 6
        Me.txtLocation.Text = ""
        '
        'txtPreValue
        '
        Me.txtPreValue.AfterDecimal = 0
        Me.txtPreValue.BeforeDecimal = 10
        Me.txtPreValue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreValue.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPreValue.Location = New System.Drawing.Point(632, 152)
        Me.txtPreValue.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPreValue.MaxLength = 12
        Me.txtPreValue.MaxValue = 0
        Me.txtPreValue.MinValue = 0
        Me.txtPreValue.Name = "txtPreValue"
        Me.txtPreValue.Size = New System.Drawing.Size(176, 23)
        Me.txtPreValue.TabIndex = 9
        Me.txtPreValue.Text = ""
        '
        'txtAmtBorrowed
        '
        Me.txtAmtBorrowed.AfterDecimal = 0
        Me.txtAmtBorrowed.BeforeDecimal = 10
        Me.txtAmtBorrowed.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtBorrowed.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmtBorrowed.Location = New System.Drawing.Point(632, 184)
        Me.txtAmtBorrowed.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmtBorrowed.MaxLength = 12
        Me.txtAmtBorrowed.MaxValue = 0
        Me.txtAmtBorrowed.MinValue = 0
        Me.txtAmtBorrowed.Name = "txtAmtBorrowed"
        Me.txtAmtBorrowed.Size = New System.Drawing.Size(176, 23)
        Me.txtAmtBorrowed.TabIndex = 10
        Me.txtAmtBorrowed.Text = ""
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Items.AddRange(New Object() {"Lease hold", "Free land", "Residential", "Commercial"})
        Me.cmbStatus.Location = New System.Drawing.Point(184, 112)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(208, 24)
        Me.cmbStatus.TabIndex = 3
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Agriculture", "Farm", "Estates", "Sites", "House", "Factory", "Shed", "Complex"})
        Me.cmbType.Location = New System.Drawing.Point(184, 80)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(208, 24)
        Me.cmbType.TabIndex = 2
        '
        'dtpYOP
        '
        Me.dtpYOP.CustomFormat = "dd - MMM - yyyy"
        Me.dtpYOP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYOP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYOP.Location = New System.Drawing.Point(184, 144)
        Me.dtpYOP.Name = "dtpYOP"
        Me.dtpYOP.Size = New System.Drawing.Size(208, 23)
        Me.dtpYOP.TabIndex = 4
        Me.dtpYOP.Value = New Date(2008, 11, 14, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(400, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Amount If Borrowed :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(400, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Present Value :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(400, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 32)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "How acquired whether in self possession / leased :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Area Acer / Cent / Square Feet :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Location And Boundaries : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Survey No. / House No. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Year Of Purchase :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Particulars Type Status : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Particulars Type :"
        '
        'cmbParticulars
        '
        Me.cmbParticulars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParticulars.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParticulars.Location = New System.Drawing.Point(184, 48)
        Me.cmbParticulars.Name = "cmbParticulars"
        Me.cmbParticulars.Size = New System.Drawing.Size(208, 24)
        Me.cmbParticulars.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Particulars : "
        '
        'lvFixedAssets
        '
        Me.lvFixedAssets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSl, Me.colPCode, Me.colParticulars, Me.colType, Me.colStatus, Me.colDatOfPurchase, Me.colSurHoNo, Me.colLocation, Me.colArea, Me.colacquiredDetails, Me.colPresentValue, Me.colAmtBorrowed})
        Me.lvFixedAssets.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lvFixedAssets.FullRowSelect = True
        Me.lvFixedAssets.GridLines = True
        Me.lvFixedAssets.Location = New System.Drawing.Point(8, 216)
        Me.lvFixedAssets.Name = "lvFixedAssets"
        Me.lvFixedAssets.Size = New System.Drawing.Size(960, 152)
        Me.lvFixedAssets.TabIndex = 12
        Me.lvFixedAssets.View = System.Windows.Forms.View.Details
        '
        'colSl
        '
        Me.colSl.Text = "slNO"
        Me.colSl.Width = 36
        '
        'colPCode
        '
        Me.colPCode.Text = "colPCode"
        Me.colPCode.Width = 0
        '
        'colParticulars
        '
        Me.colParticulars.Text = "Particulars"
        Me.colParticulars.Width = 100
        '
        'colType
        '
        Me.colType.Text = "Type"
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        Me.colStatus.Width = 71
        '
        'colDatOfPurchase
        '
        Me.colDatOfPurchase.Text = "Year Of Purchase"
        Me.colDatOfPurchase.Width = 114
        '
        'colSurHoNo
        '
        Me.colSurHoNo.Text = "SurHoNo"
        '
        'colLocation
        '
        Me.colLocation.Text = "Location"
        Me.colLocation.Width = 93
        '
        'colArea
        '
        Me.colArea.Text = "Area"
        Me.colArea.Width = 114
        '
        'colacquiredDetails
        '
        Me.colacquiredDetails.Text = "Acquired Details"
        Me.colacquiredDetails.Width = 115
        '
        'colPresentValue
        '
        Me.colPresentValue.Text = "Present Value"
        Me.colPresentValue.Width = 115
        '
        'colAmtBorrowed
        '
        Me.colAmtBorrowed.Text = "Amount Borrowed"
        Me.colAmtBorrowed.Width = 115
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.TabPage2.Controls.Add(Me.lblNomineeNo)
        Me.TabPage2.Controls.Add(Me.txtMAssetNo)
        Me.TabPage2.Controls.Add(Me.btnAddMAssets)
        Me.TabPage2.Controls.Add(Me.txtMovAmtPaid)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.dtpMovDueDate)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtMovAcquired)
        Me.TabPage2.Controls.Add(Me.txtMovPreValue)
        Me.TabPage2.Controls.Add(Me.txtMovAmtBorrowed)
        Me.TabPage2.Controls.Add(Me.datMovYOP)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.cmbMovParticulars)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.lvMovableAssets)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(976, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Movable Assets"
        '
        'lblNomineeNo
        '
        Me.lblNomineeNo.AutoSize = True
        Me.lblNomineeNo.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.lblNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomineeNo.Location = New System.Drawing.Point(40, 24)
        Me.lblNomineeNo.Name = "lblNomineeNo"
        Me.lblNomineeNo.Size = New System.Drawing.Size(34, 19)
        Me.lblNomineeNo.TabIndex = 93
        Me.lblNomineeNo.Text = " No:"
        '
        'txtMAssetNo
        '
        Me.txtMAssetNo.AlphaNumeric = False
        Me.txtMAssetNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtMAssetNo.BlankSpace = False
        Me.txtMAssetNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAssetNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtMAssetNo.Location = New System.Drawing.Point(176, 24)
        Me.txtMAssetNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtMAssetNo.Mandatory = False
        Me.txtMAssetNo.Name = "txtMAssetNo"
        Me.txtMAssetNo.ReadOnly = True
        Me.txtMAssetNo.Size = New System.Drawing.Size(104, 23)
        Me.txtMAssetNo.SpecialChar = False
        Me.txtMAssetNo.TabIndex = 94
        Me.txtMAssetNo.TabStop = False
        Me.txtMAssetNo.Text = ""
        '
        'btnAddMAssets
        '
        Me.btnAddMAssets.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnAddMAssets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMAssets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMAssets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMAssets.ForeColor = System.Drawing.Color.Black
        Me.btnAddMAssets.GotFocusColour = System.Drawing.Color.FromArgb(CType(201, Byte), CType(247, Byte), CType(181, Byte))
        Me.btnAddMAssets.Location = New System.Drawing.Point(808, 112)
        Me.btnAddMAssets.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnAddMAssets.Name = "btnAddMAssets"
        Me.btnAddMAssets.Size = New System.Drawing.Size(96, 40)
        Me.btnAddMAssets.TabIndex = 8
        Me.btnAddMAssets.Text = "A&dd "
        '
        'txtMovAmtPaid
        '
        Me.txtMovAmtPaid.AfterDecimal = 0
        Me.txtMovAmtPaid.BeforeDecimal = 10
        Me.txtMovAmtPaid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovAmtPaid.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMovAmtPaid.Location = New System.Drawing.Point(176, 128)
        Me.txtMovAmtPaid.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMovAmtPaid.MaxLength = 12
        Me.txtMovAmtPaid.MaxValue = 0
        Me.txtMovAmtPaid.MinValue = 0
        Me.txtMovAmtPaid.Name = "txtMovAmtPaid"
        Me.txtMovAmtPaid.Size = New System.Drawing.Size(208, 23)
        Me.txtMovAmtPaid.TabIndex = 3
        Me.txtMovAmtPaid.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(40, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 19)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Amount Paid"
        '
        'dtpMovDueDate
        '
        Me.dtpMovDueDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpMovDueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMovDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMovDueDate.Location = New System.Drawing.Point(584, 72)
        Me.dtpMovDueDate.Name = "dtpMovDueDate"
        Me.dtpMovDueDate.Size = New System.Drawing.Size(176, 23)
        Me.dtpMovDueDate.TabIndex = 5
        Me.dtpMovDueDate.Value = New Date(2008, 11, 14, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(440, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 19)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Due Date"
        '
        'txtMovAcquired
        '
        Me.txtMovAcquired.AlphaNumeric = True
        Me.txtMovAcquired.AutoSize = False
        Me.txtMovAcquired.BlankSpace = False
        Me.txtMovAcquired.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovAcquired.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMovAcquired.Location = New System.Drawing.Point(584, 8)
        Me.txtMovAcquired.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMovAcquired.Mandatory = False
        Me.txtMovAcquired.MaxLength = 100
        Me.txtMovAcquired.Multiline = True
        Me.txtMovAcquired.Name = "txtMovAcquired"
        Me.txtMovAcquired.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMovAcquired.Size = New System.Drawing.Size(272, 56)
        Me.txtMovAcquired.SpecialChar = True
        Me.txtMovAcquired.TabIndex = 4
        Me.txtMovAcquired.Text = ""
        '
        'txtMovPreValue
        '
        Me.txtMovPreValue.AfterDecimal = 0
        Me.txtMovPreValue.BeforeDecimal = 10
        Me.txtMovPreValue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovPreValue.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMovPreValue.Location = New System.Drawing.Point(584, 104)
        Me.txtMovPreValue.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMovPreValue.MaxLength = 12
        Me.txtMovPreValue.MaxValue = 0
        Me.txtMovPreValue.MinValue = 0
        Me.txtMovPreValue.Name = "txtMovPreValue"
        Me.txtMovPreValue.Size = New System.Drawing.Size(176, 23)
        Me.txtMovPreValue.TabIndex = 6
        Me.txtMovPreValue.Text = ""
        '
        'txtMovAmtBorrowed
        '
        Me.txtMovAmtBorrowed.AfterDecimal = 0
        Me.txtMovAmtBorrowed.BeforeDecimal = 10
        Me.txtMovAmtBorrowed.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovAmtBorrowed.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMovAmtBorrowed.Location = New System.Drawing.Point(584, 136)
        Me.txtMovAmtBorrowed.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMovAmtBorrowed.MaxLength = 12
        Me.txtMovAmtBorrowed.MaxValue = 0
        Me.txtMovAmtBorrowed.MinValue = 0
        Me.txtMovAmtBorrowed.Name = "txtMovAmtBorrowed"
        Me.txtMovAmtBorrowed.Size = New System.Drawing.Size(176, 23)
        Me.txtMovAmtBorrowed.TabIndex = 7
        Me.txtMovAmtBorrowed.Text = ""
        '
        'datMovYOP
        '
        Me.datMovYOP.CustomFormat = "dd - MMM - yyyy"
        Me.datMovYOP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datMovYOP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datMovYOP.Location = New System.Drawing.Point(176, 88)
        Me.datMovYOP.Name = "datMovYOP"
        Me.datMovYOP.Size = New System.Drawing.Size(208, 23)
        Me.datMovYOP.TabIndex = 2
        Me.datMovYOP.Value = New Date(2008, 11, 14, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(440, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 19)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Amount If Borrowed"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(440, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 19)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Present Value"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(440, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "How acquired"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(40, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 19)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Year Of Purchase"
        '
        'cmbMovParticulars
        '
        Me.cmbMovParticulars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMovParticulars.DropDownWidth = 300
        Me.cmbMovParticulars.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMovParticulars.ItemHeight = 16
        Me.cmbMovParticulars.Location = New System.Drawing.Point(176, 56)
        Me.cmbMovParticulars.MaxDropDownItems = 12
        Me.cmbMovParticulars.Name = "cmbMovParticulars"
        Me.cmbMovParticulars.Size = New System.Drawing.Size(248, 24)
        Me.cmbMovParticulars.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Particulars "
        '
        'lvMovableAssets
        '
        Me.lvMovableAssets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader12, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader10})
        Me.lvMovableAssets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMovableAssets.FullRowSelect = True
        Me.lvMovableAssets.GridLines = True
        Me.lvMovableAssets.Location = New System.Drawing.Point(8, 176)
        Me.lvMovableAssets.Name = "lvMovableAssets"
        Me.lvMovableAssets.Size = New System.Drawing.Size(960, 152)
        Me.lvMovableAssets.TabIndex = 9
        Me.lvMovableAssets.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "slNo"
        Me.ColumnHeader1.Width = 43
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "colPCode"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Particulars"
        Me.ColumnHeader2.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Year Of Purchase"
        Me.ColumnHeader5.Width = 123
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "How Acquired "
        Me.ColumnHeader8.Width = 180
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Amount Paid"
        Me.ColumnHeader12.Width = 115
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Present Value"
        Me.ColumnHeader9.Width = 115
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DueDate"
        Me.ColumnHeader11.Width = 115
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Amount If Borrowed"
        Me.ColumnHeader10.Width = 140
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = False
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.Color.Honeydew
        Me.txtLoanNo.Location = New System.Drawing.Point(128, 16)
        Me.txtLoanNo.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 10
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.Size = New System.Drawing.Size(156, 23)
        Me.txtLoanNo.SpecialChar = False
        Me.txtLoanNo.TabIndex = 87
        Me.txtLoanNo.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(312, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 88
        Me.btnSearch.Visible = False
        '
        'txtLoanerName
        '
        Me.txtLoanerName.AlphaNumeric = True
        Me.txtLoanerName.AutoSize = False
        Me.txtLoanerName.BackColor = System.Drawing.Color.White
        Me.txtLoanerName.BlankSpace = False
        Me.txtLoanerName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanerName.GotFocusColour = System.Drawing.Color.White
        Me.txtLoanerName.Location = New System.Drawing.Point(480, 16)
        Me.txtLoanerName.LostFocusColour = System.Drawing.Color.White
        Me.txtLoanerName.Mandatory = False
        Me.txtLoanerName.MaxLength = 30
        Me.txtLoanerName.Name = "txtLoanerName"
        Me.txtLoanerName.ReadOnly = True
        Me.txtLoanerName.Size = New System.Drawing.Size(168, 20)
        Me.txtLoanerName.SpecialChar = True
        Me.txtLoanerName.TabIndex = 86
        Me.txtLoanerName.TabStop = False
        Me.txtLoanerName.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 19)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Loan No. :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(360, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 19)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Loaner Name :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.OrangeRed
        Me.btnCancel.Location = New System.Drawing.Point(840, 464)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        '
        'frmLoanSuretyDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1016, 511)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtLoanNo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtLoanerName)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanSuretyDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Global Variable"
    Dim objAssets As New clsAssets
#End Region

#Region "Load Control Value"

    Sub sbLoadControlValue()
        LoadFixedAssetControl()
        LoadMovableAssetControl()
    End Sub

    Sub LoadFixedAssetControl()
        If objAssets.fnGetparticulars("Fixed") Then
            cmbParticulars.DataSource = objAssets.ParticularsTable
            cmbParticulars.DisplayMember = "PName"
            cmbParticulars.ValueMember = "PNo"
        End If
    End Sub

    Sub LoadMovableAssetControl()
        If objAssets.fnGetparticulars("Movable") Then
            cmbMovParticulars.DataSource = objAssets.ParticularsTable
            cmbMovParticulars.DisplayMember = "PName"
            cmbMovParticulars.ValueMember = "PNo"
        End If
    End Sub

#End Region

#Region "Function"

    Function SetFixedAssetData() As Boolean
        objAssets.SlNo = txtFAssetNo.Text
        objAssets.LoanNo = txtLoanNo.Text
        objAssets.ParticularId = cmbParticulars.SelectedValue
        objAssets.Ptype = cmbType.SelectedItem
        objAssets.PTypeStatus = cmbStatus.SelectedItem
        objAssets.YOP = Format(dtpYOP.Value, "yyyy-MM-dd")
        objAssets.SurveyOrHouseNo = txtSurveyNo.Text
        objAssets.PresentValue = Val(txtPreValue.Text)
        objAssets.LocationAndBoundries = txtLocation.Text
        objAssets.Area = txtArea.Text
        objAssets.AcquiredStatus = txtAcquiredStatus.Text
        objAssets.AmtIfBarrowed = Val(txtAmtBorrowed.Text)
        Return True
    End Function

    Function setMovableAssetData() As Boolean
        objAssets.LoanNo = txtLoanNo.Text
        objAssets.SlNo = txtMAssetNo.Text
        objAssets.ParticularId = cmbMovParticulars.SelectedValue
        objAssets.YOP = Format(dtpMovDueDate.Value, "yyyy-MM-dd")
        objAssets.AmountPaid = Val(txtMovAmtPaid.Text)
        objAssets.PresentValue = Val(txtMovPreValue.Text)
        objAssets.DueDate = Format(dtpMovDueDate.Value, "yyyy-MM-dd")
        objAssets.AcquiredStatus = txtMovAcquired.Text
        objAssets.AmtIfBarrowed = Val(txtMovAmtBorrowed.Text)
        Return True
    End Function

    Sub ClearData()
        txtSurveyNo.ResetText()
        txtPreValue.ResetText()
        txtLocation.ResetText()
        txtArea.ResetText()
        txtAcquiredStatus.ResetText()
        txtAmtBorrowed.ResetText()
        txtMovAmtBorrowed.ResetText()
        txtMovAcquired.ResetText()
        txtMovAmtPaid.ResetText()
        txtMovPreValue.ResetText()
        cmbParticulars.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        cmbType.SelectedIndex = -1
    End Sub

    Function fnLoadFAssets()

        Dim objDT As New DataTable
        Dim lvItem As ListViewItem
        Dim intCounter As Integer = 0
        lvFixedAssets.Items.Clear()
        If objAssets.fnGetFixedAsset(txtLoanNo.Text) Then
            objDT = objAssets.FixedAssetsTable
            While intCounter < objDT.Rows.Count
                lvItem = lvFixedAssets.Items.Add(objDT.Rows(intCounter).Item("SlNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Particulars"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PName"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PType"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PTypeStatus"))
                lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("YOP"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("SurveyOrHouseNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("LocationAndBoundaries"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Area"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("AcquiredStatus"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PresentVal"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("AmtIfBorrowed"))
                intCounter += 1
            End While
        End If
    End Function

    Function fnLoadMAssets()
        Dim objDT As New DataTable
        Dim lvItem As ListViewItem
        Dim intCounter As Integer = 0
        lvMovableAssets.Items.Clear()
        If objAssets.fnGetMovableAsset(txtLoanNo.Text) Then
            objDT = objAssets.MovableAssetsTable
            While intCounter < objDT.Rows.Count
                lvItem = lvMovableAssets.Items.Add(objDT.Rows(intCounter).Item("SlNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Particulars"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PName"))
                lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("YOP"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("AcquiredStatus"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("AmtPaid"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("PresentVal"))
                lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("DueDate"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("AmtIfBorrowed"))
                intCounter += 1
            End While
        End If
    End Function
    Function fnCheck() As Boolean
        If cmbParticulars.SelectedIndex = -1 Then
            MsgBox("Select the particulars", MsgBoxStyle.Information)
            cmbParticulars.Focus()
            Return False
        ElseIf cmbType.SelectedIndex = -1 Then
            MsgBox("Select particulars type", MsgBoxStyle.Information)
            cmbType.Focus()
            Return False
        ElseIf cmbStatus.SelectedIndex = -1 Then
            MsgBox("Select particulars status", MsgBoxStyle.Information)
            cmbStatus.Focus()
            Return False
        Else
            Return True
        End If

    End Function


    Function fnsaveFAData() As Boolean

        If objAssets.fnCheckFAsset() = True Then
            If objAssets.fnUpdateFAsset Then
                MsgBox("Fixed asset details updated successfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Else
            If objAssets.fnAddFAsset() Then
                MsgBox("Fixed asset details added successfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Function fnsaveMAData() As Boolean

        If objAssets.fnCheckMAsset() = True Then
            If objAssets.fnUpdateMAsset Then
                MsgBox("Movable asset details updated successfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Else
            If objAssets.fnAddMAsset() Then
                MsgBox("Movable asset details added successfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        End If
    End Function


#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLoanSuretyDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpMovDueDate.MaxDate = Date.Now
        dtpMovDueDate.Value = Date.Now
        dtpYOP.MaxDate = Date.Now
        dtpYOP.Value = Date.Now
        datMovYOP.MaxDate = Date.Now
        datMovYOP.Value = Date.Now

        sbLoadControlValue()
        fnLoadMAssets()
        fnLoadFAssets()
        txtMAssetNo.Text = objAssets.fnGetNewMAssetNo(txtLoanNo.Text)
        txtFAssetNo.Text = objAssets.fnGetNewFAssetNo(txtLoanNo.Text)

    End Sub

    Private Sub btnAddFAsset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFAsset.Click
        If fnCheck() Then
            If SetFixedAssetData() Then
                If fnsaveFAData() Then
                    fnLoadFAssets()
                    ClearData()
                    txtFAssetNo.Text = objAssets.fnGetNewFAssetNo(txtLoanNo.Text)
                Else
                    MsgBox("Updation failed, because of internal error", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub lvFixedAssets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvFixedAssets.Click
        If lvFixedAssets.SelectedItems.Count > 0 Then
            txtFAssetNo.Text = lvFixedAssets.SelectedItems(0).SubItems(0).Text
            cmbParticulars.SelectedValue = lvFixedAssets.SelectedItems(0).SubItems(1).Text
            cmbType.SelectedItem = lvFixedAssets.SelectedItems(0).SubItems(3).Text
            cmbStatus.SelectedItem = lvFixedAssets.SelectedItems(0).SubItems(4).Text
            dtpYOP.Value = lvFixedAssets.SelectedItems(0).SubItems(5).Text
            txtSurveyNo.Text = lvFixedAssets.SelectedItems(0).SubItems(6).Text
            txtLocation.Text = lvFixedAssets.SelectedItems(0).SubItems(7).Text
            txtArea.Text = lvFixedAssets.SelectedItems(0).SubItems(8).Text
            txtAcquiredStatus.Text = lvFixedAssets.SelectedItems(0).SubItems(9).Text
            txtPreValue.Text = lvFixedAssets.SelectedItems(0).SubItems(10).Text
            txtAmtBorrowed.Text = lvFixedAssets.SelectedItems(0).SubItems(11).Text
        End If
    End Sub

    Private Sub btnAddMAssets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMAssets.Click
        If cmbMovParticulars.SelectedIndex <> -1 Then
            If setMovableAssetData() Then
                If fnsaveMAData() Then
                    fnLoadMAssets()
                    ClearData()
                    txtMAssetNo.Text = objAssets.fnGetNewMAssetNo(txtLoanNo.Text)
                Else
                    MsgBox("Updation failed, because of internal error", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Selct The Particulars", MsgBoxStyle.Information)
            cmbMovParticulars.Focus()
        End If
    End Sub

    Private Sub lvMovableAssets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvMovableAssets.Click
        If lvMovableAssets.SelectedItems.Count > 0 Then
            txtMAssetNo.Text = lvMovableAssets.SelectedItems(0).SubItems(0).Text
            cmbMovParticulars.SelectedValue = lvMovableAssets.SelectedItems(0).SubItems(1).Text
            datMovYOP.Value = lvMovableAssets.SelectedItems(0).SubItems(3).Text
            txtMovAcquired.Text = lvMovableAssets.SelectedItems(0).SubItems(4).Text
            txtMovAmtPaid.Text = lvMovableAssets.SelectedItems(0).SubItems(5).Text
            txtMovPreValue.Text = lvMovableAssets.SelectedItems(0).SubItems(6).Text
            dtpMovDueDate.Value = lvMovableAssets.SelectedItems(0).SubItems(7).Text
            txtMovAmtBorrowed.Text = lvMovableAssets.SelectedItems(0).SubItems(8).Text
        End If
    End Sub
End Class
