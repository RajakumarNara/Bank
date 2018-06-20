Public Class frmRemitShares
    Inherits System.Windows.Forms.Form

#Region " Form Global Variables"

    Dim objMember As New clsMember
    Dim lngVoucherNo As Long
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtEntryFee As BankControls.NumericControl
    Dim dblShareAmount As Double = 0

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpShares As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtShareFee As BankControls.NumericControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfShares As BankControls.TextControl
    Friend WithEvents txtShareAmount As BankControls.TextControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpApplDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNewNOS As BankControls.NumericControl
    Friend WithEvents txtNewShareAmt As BankControls.NumericControl
    Friend WithEvents txtTotalAmount As BankControls.TextControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemitShares))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMemberNo = New BankControls.TextControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New BankControls.NewButton()
        Me.txtName = New BankControls.TextControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpShares = New System.Windows.Forms.GroupBox()
        Me.dtpApplDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtReceiptNo = New BankControls.NumericControl()
        Me.txtNewNOS = New BankControls.NumericControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtShareFee = New BankControls.NumericControl()
        Me.txtNewShareAmt = New BankControls.NumericControl()
        Me.txtTotalAmount = New BankControls.TextControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoOfShares = New BankControls.TextControl()
        Me.txtShareAmount = New BankControls.TextControl()
        Me.btnOk = New BankControls.NewButton()
        Me.btnClose = New BankControls.NewButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEntryFee = New BankControls.NumericControl()
        Me.GroupBox3.SuspendLayout()
        Me.grpShares.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMemberNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 64)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.BlankSpace = False
        Me.txtMemberNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.Location = New System.Drawing.Point(128, 24)
        Me.txtMemberNo.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.Size = New System.Drawing.Size(128, 23)
        Me.txtMemberNo.SpecialChar = True
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.TabStop = False
        Me.txtMemberNo.Text = "MB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name :"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(264, 23)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtName.BlankSpace = True
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Location = New System.Drawing.Point(416, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(216, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 9
        Me.txtName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Member No. :"
        '
        'grpShares
        '
        Me.grpShares.Controls.Add(Me.txtEntryFee)
        Me.grpShares.Controls.Add(Me.Label24)
        Me.grpShares.Controls.Add(Me.dtpApplDate)
        Me.grpShares.Controls.Add(Me.Label18)
        Me.grpShares.Controls.Add(Me.Label17)
        Me.grpShares.Controls.Add(Me.txtReceiptNo)
        Me.grpShares.Controls.Add(Me.txtNewNOS)
        Me.grpShares.Controls.Add(Me.Label11)
        Me.grpShares.Controls.Add(Me.Label22)
        Me.grpShares.Controls.Add(Me.Label23)
        Me.grpShares.Controls.Add(Me.txtShareFee)
        Me.grpShares.Controls.Add(Me.txtNewShareAmt)
        Me.grpShares.Controls.Add(Me.txtTotalAmount)
        Me.grpShares.Controls.Add(Me.Label5)
        Me.grpShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShares.Location = New System.Drawing.Point(8, 192)
        Me.grpShares.Name = "grpShares"
        Me.grpShares.Size = New System.Drawing.Size(640, 160)
        Me.grpShares.TabIndex = 2
        Me.grpShares.TabStop = False
        '
        'dtpApplDate
        '
        Me.dtpApplDate.CustomFormat = "dd -MMM - yyyy "
        Me.dtpApplDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpApplDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApplDate.Location = New System.Drawing.Point(427, 24)
        Me.dtpApplDate.MaxDate = New Date(9998, 12, 29, 0, 0, 0, 0)
        Me.dtpApplDate.MinDate = New Date(1976, 1, 1, 0, 0, 0, 0)
        Me.dtpApplDate.Name = "dtpApplDate"
        Me.dtpApplDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpApplDate.TabIndex = 1
        Me.dtpApplDate.Value = New Date(2007, 9, 8, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(304, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Date :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Receipt No.  :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 2
        Me.txtReceiptNo.BackColor = System.Drawing.Color.White
        Me.txtReceiptNo.BeforeDecimal = 8
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(153, 24)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0.0R
        Me.txtReceiptNo.MinValue = 0.0R
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(128, 23)
        Me.txtReceiptNo.TabIndex = 0
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNewNOS
        '
        Me.txtNewNOS.AfterDecimal = 0
        Me.txtNewNOS.BeforeDecimal = 5
        Me.txtNewNOS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewNOS.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNewNOS.Location = New System.Drawing.Point(153, 59)
        Me.txtNewNOS.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtNewNOS.MaxLength = 5
        Me.txtNewNOS.MaxValue = 0.0R
        Me.txtNewNOS.MinValue = 0.0R
        Me.txtNewNOS.Name = "txtNewNOS"
        Me.txtNewNOS.Size = New System.Drawing.Size(128, 23)
        Me.txtNewNOS.TabIndex = 2
        Me.txtNewNOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "No of Shares :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(304, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 16)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Share Fee :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(304, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(117, 16)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Share Amount : "
        '
        'txtShareFee
        '
        Me.txtShareFee.AfterDecimal = 2
        Me.txtShareFee.BeforeDecimal = 8
        Me.txtShareFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtShareFee.Location = New System.Drawing.Point(427, 56)
        Me.txtShareFee.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtShareFee.MaxLength = 10
        Me.txtShareFee.MaxValue = 0.0R
        Me.txtShareFee.MinValue = 0.0R
        Me.txtShareFee.Name = "txtShareFee"
        Me.txtShareFee.Size = New System.Drawing.Size(128, 23)
        Me.txtShareFee.TabIndex = 3
        Me.txtShareFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNewShareAmt
        '
        Me.txtNewShareAmt.AfterDecimal = 2
        Me.txtNewShareAmt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtNewShareAmt.BeforeDecimal = 8
        Me.txtNewShareAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewShareAmt.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNewShareAmt.Location = New System.Drawing.Point(427, 88)
        Me.txtNewShareAmt.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNewShareAmt.MaxLength = 10
        Me.txtNewShareAmt.MaxValue = 0.0R
        Me.txtNewShareAmt.MinValue = 0.0R
        Me.txtNewShareAmt.Name = "txtNewShareAmt"
        Me.txtNewShareAmt.ReadOnly = True
        Me.txtNewShareAmt.Size = New System.Drawing.Size(128, 23)
        Me.txtNewShareAmt.TabIndex = 4
        Me.txtNewShareAmt.TabStop = False
        Me.txtNewShareAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AlphaNumeric = True
        Me.txtTotalAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtTotalAmount.BlankSpace = False
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtTotalAmount.Location = New System.Drawing.Point(427, 120)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtTotalAmount.Mandatory = False
        Me.txtTotalAmount.MaxLength = 10
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtTotalAmount.SpecialChar = True
        Me.txtTotalAmount.TabIndex = 7
        Me.txtTotalAmount.TabStop = False
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtNoOfShares)
        Me.GroupBox5.Controls.Add(Me.txtShareAmount)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(640, 64)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No of Shares :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Share Amount : "
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AlphaNumeric = True
        Me.txtNoOfShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.BlankSpace = False
        Me.txtNoOfShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.Location = New System.Drawing.Point(128, 24)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.Mandatory = False
        Me.txtNoOfShares.MaxLength = 10
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.ReadOnly = True
        Me.txtNoOfShares.Size = New System.Drawing.Size(128, 23)
        Me.txtNoOfShares.SpecialChar = True
        Me.txtNoOfShares.TabIndex = 7
        Me.txtNoOfShares.TabStop = False
        Me.txtNoOfShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShareAmount
        '
        Me.txtShareAmount.AlphaNumeric = True
        Me.txtShareAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.BlankSpace = False
        Me.txtShareAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShareAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Location = New System.Drawing.Point(416, 24)
        Me.txtShareAmount.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Mandatory = False
        Me.txtShareAmount.MaxLength = 10
        Me.txtShareAmount.Name = "txtShareAmount"
        Me.txtShareAmount.ReadOnly = True
        Me.txtShareAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtShareAmount.SpecialChar = True
        Me.txtShareAmount.TabIndex = 7
        Me.txtShareAmount.TabStop = False
        Me.txtShareAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(432, 368)
        Me.btnOk.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&save"
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
        Me.btnClose.Location = New System.Drawing.Point(536, 368)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(72, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 23)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Remit Shares"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 95)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Share Entry  Fee :"
        '
        'txtEntryFee
        '
        Me.txtEntryFee.AfterDecimal = 0
        Me.txtEntryFee.BeforeDecimal = 5
        Me.txtEntryFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEntryFee.Location = New System.Drawing.Point(153, 88)
        Me.txtEntryFee.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtEntryFee.MaxLength = 15
        Me.txtEntryFee.MaxValue = 0.0R
        Me.txtEntryFee.MinValue = 0.0R
        Me.txtEntryFee.Name = "txtEntryFee"
        Me.txtEntryFee.Size = New System.Drawing.Size(128, 23)
        Me.txtEntryFee.TabIndex = 47
        Me.txtEntryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmRemitShares
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(658, 423)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpShares)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemitShares"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remit Shares"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpShares.ResumeLayout(False)
        Me.grpShares.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Sub Routines and Functions"

    'To load member share details
    Sub sbLoadMember()
        Dim objDT As DataTable
        sbClear()
        If objMember.fnGetMemberDetails(txtMemberNo.Text) Then
            objDT = objMember.MemberTable
            txtMemberNo.Text = objDT.Rows(0).Item("MemberNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            txtNoOfShares.Text = objDT.Rows(0).Item("NoOfShares")
            txtShareAmount.Text = objDT.Rows(0).Item("ShareAmount")
            objMember.Type = objDT.Rows(0).Item("Type")
            sbLoadMaster()
        Else
            MsgBox("No member exist", MsgBoxStyle.Exclamation)
            txtMemberNo.Focus()
        End If
    End Sub

    Sub sbLoadMaster()
        If objMember.fnGetShareConfig Then
            dblShareAmount = objMember.SharesTable.Rows(0).Item("AmountPerShare")
        End If
    End Sub

    'To clear form control values
    Sub sbClear()
        'txtMemberNo.Text = "MB"
        txtName.ResetText()
        txtReceiptNo.ResetText()
        txtNewNOS.ResetText()
        txtShareFee.ResetText()
        txtNewShareAmt.ResetText()
        txtNoOfShares.ResetText()
        txtShareAmount.ResetText()
        txtTotalAmount.ResetText()

    End Sub

    Function fnCheck() As Boolean

        If txtMemberNo.Text = "" Or txtName.Text = "" Then
            MsgBox("Select member ", MsgBoxStyle.Information, Me.Text)
            btnSearch.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = "" Then
            MsgBox("Enter receipt no", MsgBoxStyle.Information, Me.Text)
            txtReceiptNo.Focus()
            Return False
        ElseIf Val(txtNewNOS.Text) = 0 Then
            MsgBox("Enter no of shares", MsgBoxStyle.Information, Me.Text)
            txtNewNOS.Focus()
            Return False
        ElseIf Val(txtShareFee.Text) = 0 Then
            MsgBox("Enter share fee", MsgBoxStyle.Information, Me.Text)
            txtNewShareAmt.Focus()
            Return False
        ElseIf Val(txtNewShareAmt.Text) = 0 Then
            MsgBox("Enter share amount", MsgBoxStyle.Information, Me.Text)
            txtNewShareAmt.Focus()
            Return False
        ElseIf Val(txtEntryFee.Text) = 0 Then
            MsgBox("Enter share Entry amount", MsgBoxStyle.Information, Me.Text)
            txtEntryFee.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Function fnSetData() As Boolean

        objMember.MemberNo = txtMemberNo.Text
        objMember.ShareAmount = txtNewShareAmt.Text
        objMember.ShareFee = txtShareFee.Text
        objMember.NoOfShares = txtNewNOS.Text
        objMember.ShareDate = dtpApplDate.Value
        objMember.RefNo = txtReceiptNo.Text
        lngVoucherNo = fnVoucherGetNewVNo(dtpApplDate.Value)
        objMember.VoucherNo = lngVoucherNo

        Return True

    End Function

    'To enter details into Receipt table 
    Function fnGenerateReceipt() As Boolean

        'Receipt main details
        fnReceiptEnterMain(txtReceiptNo.Text, txtName.Text, dtpApplDate.Value, txtTotalAmount.Text, "")

        'Receipt sub details
        fnReceiptEnterSub(txtReceiptNo.Text, dtpApplDate.Value, "Share fee", Val(txtShareFee.Text), 1)
        fnReceiptEnterSub(txtReceiptNo.Text, dtpApplDate.Value, "Share amount ", Val(txtNewShareAmt.Text), 2)
        fnReceiptEnterSub(txtReceiptNo.Text, dtpApplDate.Value, "Entrance Fee", Val(txtEntryFee.Text), 1)

        Return True

    End Function

    'To enter Voucher details
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngSlNo As Long

        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtMemberNo.Text, txtReceiptNo.Text, dtpApplDate.Value, txtTotalAmount.Text, "Share remittance by member " & txtMemberNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        If Val(txtEntryFee.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpApplDate.Value, "Share remittance by member " & txtMemberNo.Text, "To", 7, 0, Val(txtEntryFee.Text), 1, "Y", objTrans)
        End If

        If Val(txtShareFee.Text) <> 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpApplDate.Value, "Share remittance by member " & txtMemberNo.Text, "To", 8, 0, Val(txtShareFee.Text), 1, "Y", objTrans)
        End If

        If objMember.MemberTable.Rows(0).Item("Type") = "SCA" Then
            'commented by vishwanath because customer said remit shares must go to paid up share capital
            'fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpApplDate.Value, "Share remittance by member " & txtMemberNo.Text, "To", 3, 0, Val(txtNewShareAmt.Text), 2, "Y", objTrans)
        ElseIf objMember.MemberTable.Rows(0).Item("Type") = "SCB" Then
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpApplDate.Value, "Share remittance by member " & txtMemberNo.Text, "To", 4, 0, Val(txtNewShareAmt.Text), 2, "Y", objTrans)
        Else
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpApplDate.Value, "Share remittance by member " & txtMemberNo.Text, "To", 5, 0, Val(txtNewShareAmt.Text), 2, "Y", objTrans)
        End If

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpApplDate.Value, "Share remittance by Member " & txtMemberNo.Text, "By", 1, Val(txtTotalAmount.Text), 0, 3, "Y", objTrans)
        'below line added by vishwanath because customer said remit shares must go to paid up share capital
        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpApplDate.Value, "Share remittance by Member " & txtMemberNo.Text, "By", 184, 0, Val(txtNewShareAmt.Text), 3, "Y", objTrans)

        Return True

    End Function

    'to calculate Total amount
    Sub sbCalcTotal()

        Dim dblTotal As Double = 0
        dblTotal += Val(txtShareFee.Text)
        dblTotal += Val(txtNewShareAmt.Text)
        dblTotal += Val(txtEntryFee.Text)
        txtTotalAmount.Text = Format(dblTotal, "0.00")

    End Sub

#End Region

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtMemberNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberNo.Leave
        If txtMemberNo.Text <> "MB" Then
            sbLoadMember()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtMemberNo.Text = objMemberSearch.strMemberNo
            sbLoadMember()
        Else
            txtMemberNo.Text = "MB"
            objMemberSearch.Dispose()
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If objMember.fnRemitShares(objTrans) Then
                        'fnGenerateReceipt()
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Shares remited by" & txtMemberNo.Text, Date.Now, "Member Module", objTrans)
                        objTrans.Commit()
                        If MsgBox("Shares remitted successfully to the members account" & Chr(13) & Chr(13) & "You want to do another transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                            Me.Close()
                        Else
                            sbClear()
                            txtMemberNo.Text = "MB"
                        End If
                    Else
                        MsgBox("Shares remitance failed, because of internal error" & Chr(13) & "Retry again after verifying data", MsgBoxStyle.Exclamation, "Error")
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

    Private Sub frmRemitShares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpApplDate.Value = Date.Now
        If txtMemberNo.Text <> "MB" Then
            sbLoadMember()
        End If
    End Sub

    Private Sub txtShareFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShareFee.TextChanged
        sbCalcTotal()
    End Sub

    Private Sub txtNewShareAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewShareAmt.TextChanged
        sbCalcTotal()
    End Sub

    Private Sub txtEntryFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntryFee.TextChanged
        sbCalcTotal()
    End Sub

    Private Sub frmRemitShares_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F3 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtNewNOS_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewNOS.TextChanged
        txtNewShareAmt.Text = (Val(txtNewNOS.Text) * Val(dblShareAmount))
    End Sub

    

#End Region

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub grpShares_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpShares.Enter

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    
End Class
