Imports System.IO
Imports System.Math
Public Class frmCAChequeWithdraw
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookNo As BankControls.TextControl
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents dtpWithdrawldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnVerifyPhotoSign As BankControls.NewButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInterst As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblODLimit As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbTranType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSBChequeNo As BankControls.NumericControl
    Friend WithEvents txtRefNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAChequeWithdraw))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRefNo = New BankControls.NumericControl
        Me.txtSBChequeNo = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbTranType = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblInterst = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblODLimit = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblBookBal = New System.Windows.Forms.Label
        Me.btnSearch = New BankControls.NewButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.txtAccNo = New BankControls.TextControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBookNo = New BankControls.TextControl
        Me.btnWithDraw = New BankControls.NewButton
        Me.dtpWithdrawldate = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New BankControls.NewButton
        Me.btnVerifyPhotoSign = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.txtSBChequeNo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbTranType)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblInterst)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblODLimit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblAvalBal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblBookBal)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtAccNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBookNo)
        Me.GroupBox1.Controls.Add(Me.btnWithDraw)
        Me.GroupBox1.Controls.Add(Me.dtpWithdrawldate)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnVerifyPhotoSign)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 0
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(136, 184)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(152, 22)
        Me.txtRefNo.TabIndex = 9
        Me.txtRefNo.Text = ""
        '
        'txtSBChequeNo
        '
        Me.txtSBChequeNo.AfterDecimal = 0
        Me.txtSBChequeNo.BackColor = System.Drawing.Color.White
        Me.txtSBChequeNo.BeforeDecimal = 10
        Me.txtSBChequeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBChequeNo.GotFocusColour = System.Drawing.Color.White
        Me.txtSBChequeNo.Location = New System.Drawing.Point(136, 24)
        Me.txtSBChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBChequeNo.MaxLength = 10
        Me.txtSBChequeNo.MaxValue = 0
        Me.txtSBChequeNo.MinValue = 0
        Me.txtSBChequeNo.Name = "txtSBChequeNo"
        Me.txtSBChequeNo.Size = New System.Drawing.Size(152, 22)
        Me.txtSBChequeNo.TabIndex = 0
        Me.txtSBChequeNo.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 18)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "Transaction Type"
        '
        'cmbTranType
        '
        Me.cmbTranType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTranType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTranType.Items.AddRange(New Object() {"Clearing Cheque", "Cheque Withdraw"})
        Me.cmbTranType.Location = New System.Drawing.Point(136, 56)
        Me.cmbTranType.Name = "cmbTranType"
        Me.cmbTranType.Size = New System.Drawing.Size(152, 24)
        Me.cmbTranType.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(336, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 19)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Intrest"
        '
        'lblInterst
        '
        Me.lblInterst.AutoSize = True
        Me.lblInterst.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.lblInterst.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblInterst.Location = New System.Drawing.Point(464, 187)
        Me.lblInterst.Name = "lblInterst"
        Me.lblInterst.Size = New System.Drawing.Size(29, 19)
        Me.lblInterst.TabIndex = 156
        Me.lblInterst.Text = "0.0"
        Me.lblInterst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(336, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 19)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "OverDraw Limit"
        '
        'lblODLimit
        '
        Me.lblODLimit.AutoSize = True
        Me.lblODLimit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.lblODLimit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblODLimit.Location = New System.Drawing.Point(464, 155)
        Me.lblODLimit.Name = "lblODLimit"
        Me.lblODLimit.Size = New System.Drawing.Size(29, 19)
        Me.lblODLimit.TabIndex = 154
        Me.lblODLimit.Text = "0.0"
        Me.lblODLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(336, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 19)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "AvailableBalance"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(464, 91)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(29, 19)
        Me.lblAvalBal.TabIndex = 152
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(336, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 19)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "BookBalance"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblBookBal.Location = New System.Drawing.Point(464, 123)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(29, 19)
        Me.lblBookBal.TabIndex = 150
        Me.lblBookBal.Text = "0.0"
        Me.lblBookBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Enabled = False
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(296, 88)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Cheque No"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(136, 152)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 22)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = False
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(136, 88)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(152, 22)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 5
        Me.txtAccNo.TabStop = False
        Me.txtAccNo.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 19)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Reference No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Account No."
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(136, 216)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(400, 48)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 10
        Me.txtNarration.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(392, 56)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 4
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Book No."
        '
        'txtBookNo
        '
        Me.txtBookNo.AlphaNumeric = False
        Me.txtBookNo.BackColor = System.Drawing.Color.White
        Me.txtBookNo.BlankSpace = False
        Me.txtBookNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookNo.Location = New System.Drawing.Point(136, 120)
        Me.txtBookNo.LostFocusColour = System.Drawing.Color.White
        Me.txtBookNo.Mandatory = False
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.ReadOnly = True
        Me.txtBookNo.Size = New System.Drawing.Size(152, 22)
        Me.txtBookNo.SpecialChar = False
        Me.txtBookNo.TabIndex = 7
        Me.txtBookNo.TabStop = False
        Me.txtBookNo.Text = ""
        '
        'btnWithDraw
        '
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnWithDraw.Location = New System.Drawing.Point(280, 280)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(128, 40)
        Me.btnWithDraw.TabIndex = 12
        Me.btnWithDraw.Text = "&Withdraw"
        '
        'dtpWithdrawldate
        '
        Me.dtpWithdrawldate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpWithdrawldate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWithdrawldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWithdrawldate.Location = New System.Drawing.Point(392, 24)
        Me.dtpWithdrawldate.Name = "dtpWithdrawldate"
        Me.dtpWithdrawldate.Size = New System.Drawing.Size(144, 23)
        Me.dtpWithdrawldate.TabIndex = 2
        Me.dtpWithdrawldate.Value = New Date(2007, 10, 15, 0, 0, 0, 0)
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(432, 280)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        '
        'btnVerifyPhotoSign
        '
        Me.btnVerifyPhotoSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifyPhotoSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerifyPhotoSign.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifyPhotoSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnVerifyPhotoSign.Location = New System.Drawing.Point(132, 280)
        Me.btnVerifyPhotoSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnVerifyPhotoSign.Name = "btnVerifyPhotoSign"
        Me.btnVerifyPhotoSign.Size = New System.Drawing.Size(128, 40)
        Me.btnVerifyPhotoSign.TabIndex = 11
        Me.btnVerifyPhotoSign.Text = "&Verify Signature"
        '
        'frmCAChequeWithdraw
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(592, 347)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAChequeWithdraw"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Account  Withdraw (Cheque)"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "form Global Variables"
    Dim objCurrentAccount As New clsCurrentAccount
    Dim objLedger As New clsLedger
    Dim ToolTip1 As New ToolTip

    Dim dblAvalAmount As Double
    Dim dblBookAmount As Double
    Dim dblOverDrawLimit As Double

    Dim dblCalIntrest As Double

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAChequeWithdraw
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAChequeWithdraw
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAChequeWithdraw
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAChequeWithdraw)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Function"

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strNarration As String

        lngVoucherNo = fnVoucherGetNewVNo(dtpWithdrawldate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        If cmbTranType.SelectedItem = "Clearing Cheque" Then
            strNarration = "Clearing Cheque By " & txtName.Text & " Cheque No " & txtSBChequeNo.Text & " Narration:  " & txtNarration.Text
        ElseIf cmbTranType.SelectedItem = "Cheque Withdraw" Then
            strNarration = "Cheque Withdrawal By " & txtName.Text & " Cheque No " & txtSBChequeNo.Text & " Narration:  " & txtNarration.Text
        End If

        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblCalIntrest & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','cheque','" & Trim(txtSBChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        strsql = "Insert into caChequeDeposittbl(CAccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,VoucherNo,Narration)"
        strsql = strsql & " Values( '" & txtAccNo.Text & "',' ','  ','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','" & txtSBChequeNo.Text & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','" & Val(txtAmount.Text) & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','0.00',' Cleared ','" & Val(txtRefNo.Text) & "','" & txtNarration.Text & "')"
        fnExecuteNonQuery(strsql, objTrans)

        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtRefNo.Text, dtpWithdrawldate.Value, txtAmount.Text, "Cheque Wwithdraw by account  " & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If dblAvalAmount <= 0 Then
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithdrawldate.Value, "Cheque withdraw by account  " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpWithdrawldate.Value, "Cheque withdraw by account  " & txtAccNo.Text, "By", 12, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtAmount.Text)
            If dblTempBalance < 0 Then
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithdrawldate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpWithdrawldate.Value, "Cheque withdraw by account " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 2, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpWithdrawldate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 12, Abs(dblTempBalance), 0, 3, "Y", objTrans)
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithdrawldate.Value, "Cheque withdraw by account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpWithdrawldate.Value, "Cheque withdraw by account " & txtAccNo.Text, "By", 11, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            End If
        End If

        Return True
    End Function

    Function fnCheck() As Boolean

        If Trim(txtSBChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtSBChequeNo.Focus()
            Return False
        ElseIf cmbTranType.SelectedIndex = -1 Then
            MsgBox("Select transaction type", MsgBoxStyle.Information)
            cmbTranType.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf Trim(txtRefNo.Text) = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Information)
            txtRefNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetdata() As Boolean
        objCurrentAccount.CurAccountNo = txtAccNo.Text
        objCurrentAccount.Accdate = dtpWithdrawldate.Value
        Return True

    End Function

    Function fnGetCheqkExistance()
        If objCurrentAccount.fnGetCheckDet(Trim(txtSBChequeNo.Text), Trim(txtAccNo.Text)) Then
            Return True
        Else
            MsgBox("Cheque no " & Trim(txtSBChequeNo.Text) & " Dosent belong to CAccount " & Trim(txtAccNo.Text))
            Return False
        End If
    End Function


#End Region

#Region "Events"
    Private Sub frmCAChequeWithdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpWithdrawldate.Value = Date.Now
        dtpWithdrawldate.MaxDate = Date.Now
        If Trim(txtAccNo.Text <> String.Empty) Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then
                caLoadDetails()
            End If
        End If
    End Sub
    Private Sub txtSBChequeNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSBChequeNo.Leave
        If Trim(txtSBChequeNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCheques(Trim(txtSBChequeNo.Text)) = True Then
                txtAccNo.Text = objCurrentAccount.CACheckBookBookTable.Rows(0).Item("CAccountNO")
                txtBookNo.Text = objCurrentAccount.CACheckBookBookTable.Rows(0).Item("Book_SNo")
                caLoadDetails()
            Else
                MsgBox("Sorry! cheque is from other bank ", MsgBoxStyle.Critical)
                txtSBChequeNo.Focus()
                txtSBChequeNo.SelectAll()
            End If
        End If
    End Sub
    Private Function fnCheakBalance() As Boolean

        If objCurrentAccount.fnGetCAccountDetails(txtAccNo.Text) Then
            dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
            dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
            If Val(txtAmount.Text) > Val(dblAvalAmount) + Val(dblOverDrawLimit) Then
                MsgBox("Withdrawal amount is exeeding limited amount please enter valid amount")
                txtAmount.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function
    Private Function fnCheckFund() As Boolean
        ''Check availabilities of cash (1 is the ledgerID)
        If (objLedger.fnGetCBalanceWRTLedger(1)) Then
            If (objLedger.LedgerTable.Rows(0).Item("Balance") > Val(txtAmount.Text)) Then
                Return True
            Else
                MsgBox("Insufficient fund,please check the cash", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If
    End Function


    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()

        Try
            If fnCheck() Then
                If fnGetCheqkExistance() Then
                    If Not objCurrentAccount.fnCheckChequeLeafNo(Trim(txtSBChequeNo.Text)) Then
                        If fnCheckFund() Then
                            If fnCheakBalance() Then
                                If MsgBox("Current accountno :  " & txtAccNo.Text & " " & Chr(13) & " WithDraw Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cheque", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                                    If fnSetdata() Then

                                        fnGenerateVoucher(objTrans)
                                        fnLogEntry(pbUserId, "Cheque withdraw by account " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction withdraw", objTrans)
                                        objTrans.Commit()
                                        If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                            caClear()
                                            caLoadDetails()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        Me.Close()
                    Else
                        If objCurrentAccount.CACheckBookBookTable.Rows(0).Item("Status") = "Stopped" Then
                            MsgBox("Sorry! cheque has been stopped", MsgBoxStyle.Critical)
                        Else
                            MsgBox("Sorry! cheque is already withdrawn ", MsgBoxStyle.Critical)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()
        End Try


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objSBAccSearch As New frmCAccSearch
        objSBAccSearch.strCAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strCAccountNo <> String.Empty Then
            txtAccNo.Text = objSBAccSearch.strCAccountNo
            txtName.Text = objSBAccSearch.lvCAAccs.SelectedItems(0).SubItems(1).Text
            caLoadDetails()
        End If
        objSBAccSearch.Dispose()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


#End Region

#Region "Subroutine"
    Sub caLoadDetails()
        Try
            Dim msStream As System.IO.MemoryStream
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) = True Then
                dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                ToolTip1.SetToolTip(lblAvalBal, GetFigures(dblAvalAmount))
                dblBookAmount = objCurrentAccount.CAAccTable.Rows(0).Item("BookBalance")
                lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
                lblODLimit.Text = Format(dblOverDrawLimit, "0,00.00")
                lblInterst.Text = objCurrentAccount.CAAccTable.Rows(0).Item("IntAmount")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Sub caClear()
        txtSBChequeNo.ResetText()
        txtBookNo.ResetText()
        txtAmount.ResetText()
        txtNarration.ResetText()
        txtRefNo.ResetText()
    End Sub

#End Region


    Private Sub btnVerifyPhotoSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyPhotoSign.Click

        Dim ObjPhotoSign As New frmCASignPhoto
        ObjPhotoSign.txtAccno.Text = Me.txtAccNo.Text
        ObjPhotoSign.txtName.Text = Me.txtName.Text
        ObjPhotoSign.ShowDialog(Me)
    End Sub
End Class
