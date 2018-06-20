Public Class frmPigmyWithDraw
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
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPGName As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPGAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpWithDrawDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLastPaidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtInterest As BankControls.NumericControl
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtOthers As BankControls.NumericControl
    Friend WithEvents txtTotalAmount As BankControls.NumericControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClear As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPigmyWithDraw))
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRemarks = New BankControls.TextControl
        Me.dtpWithDrawDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPGName = New BankControls.TextControl
        Me.txtBalance = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPGAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpLastPaidDate = New System.Windows.Forms.DateTimePicker
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtInterest = New BankControls.NumericControl
        Me.btnCalInterest = New BankControls.NewButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRefNo = New BankControls.NumericControl
        Me.txtROI = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtOthers = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalAmount = New BankControls.NumericControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnClear = New BankControls.NewButton
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnWithdraw.Image = CType(resources.GetObject("btnWithdraw.Image"), System.Drawing.Image)
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(408, 232)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(96, 40)
        Me.btnWithdraw.TabIndex = 7
        Me.btnWithdraw.Text = "Withdrawl"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(528, 232)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 216)
        Me.TabControl1.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtRemarks)
        Me.TabPage1.Controls.Add(Me.dtpWithDrawDate)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtPGName)
        Me.TabPage1.Controls.Add(Me.txtBalance)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPGAccNo)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.dtpLastPaidDate)
        Me.TabPage1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(624, 187)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Remarks :"
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(448, 112)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(160, 52)
        Me.txtRemarks.SpecialChar = False
        Me.txtRemarks.TabIndex = 7
        Me.txtRemarks.Text = ""
        '
        'dtpWithDrawDate
        '
        Me.dtpWithDrawDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpWithDrawDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWithDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWithDrawDate.Location = New System.Drawing.Point(448, 32)
        Me.dtpWithDrawDate.Name = "dtpWithDrawDate"
        Me.dtpWithDrawDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpWithDrawDate.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Date :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Name :"
        '
        'txtPGName
        '
        Me.txtPGName.AlphaNumeric = False
        Me.txtPGName.AutoSize = False
        Me.txtPGName.BlankSpace = False
        Me.txtPGName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPGName.Location = New System.Drawing.Point(112, 72)
        Me.txtPGName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPGName.Mandatory = False
        Me.txtPGName.Name = "txtPGName"
        Me.txtPGName.Size = New System.Drawing.Size(168, 20)
        Me.txtPGName.SpecialChar = False
        Me.txtPGName.TabIndex = 3
        Me.txtPGName.Text = ""
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 2
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.BeforeDecimal = 7
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalance.Location = New System.Drawing.Point(112, 112)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalance.MaxValue = 0
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(168, 23)
        Me.txtBalance.TabIndex = 4
        Me.txtBalance.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Amount :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "AccountNo. :"
        '
        'txtPGAccNo
        '
        Me.txtPGAccNo.AlphaNumeric = True
        Me.txtPGAccNo.BlankSpace = False
        Me.txtPGAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPGAccNo.Location = New System.Drawing.Point(112, 32)
        Me.txtPGAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPGAccNo.Mandatory = False
        Me.txtPGAccNo.MaxLength = 10
        Me.txtPGAccNo.Name = "txtPGAccNo"
        Me.txtPGAccNo.Size = New System.Drawing.Size(112, 23)
        Me.txtPGAccNo.SpecialChar = False
        Me.txtPGAccNo.TabIndex = 1
        Me.txtPGAccNo.Text = "BNN"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(232, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 19)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Last Paid Date :"
        '
        'dtpLastPaidDate
        '
        Me.dtpLastPaidDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpLastPaidDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLastPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPaidDate.Location = New System.Drawing.Point(448, 72)
        Me.dtpLastPaidDate.Name = "dtpLastPaidDate"
        Me.dtpLastPaidDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpLastPaidDate.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtInterest)
        Me.TabPage2.Controls.Add(Me.btnCalInterest)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtAmount)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtRefNo)
        Me.TabPage2.Controls.Add(Me.txtROI)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtOthers)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtTotalAmount)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(624, 187)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Interest Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 18)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "%"
        '
        'txtInterest
        '
        Me.txtInterest.AfterDecimal = 2
        Me.txtInterest.BackColor = System.Drawing.Color.White
        Me.txtInterest.BeforeDecimal = 8
        Me.txtInterest.Enabled = False
        Me.txtInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterest.Location = New System.Drawing.Point(152, 64)
        Me.txtInterest.LostFocusColour = System.Drawing.Color.Empty
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(144, 23)
        Me.txtInterest.TabIndex = 2
        Me.txtInterest.Text = ""
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnCalInterest.Location = New System.Drawing.Point(296, 24)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(40, 24)
        Me.btnCalInterest.TabIndex = 9
        Me.btnCalInterest.Text = "Cal Interest"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 19)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "Interest :"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 10
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(152, 24)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 9999999999999
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 19)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "WithDrawl Amount :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Reference No. :"
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(480, 72)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(136, 23)
        Me.txtRefNo.TabIndex = 6
        Me.txtRefNo.Text = ""
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BeforeDecimal = 7
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(480, 32)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(40, 23)
        Me.txtROI.TabIndex = 5
        Me.txtROI.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "ROI :"
        '
        'txtOthers
        '
        Me.txtOthers.AfterDecimal = 2
        Me.txtOthers.BackColor = System.Drawing.Color.White
        Me.txtOthers.BeforeDecimal = 8
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOthers.Location = New System.Drawing.Point(152, 104)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.MaxLength = 10
        Me.txtOthers.MaxValue = 0
        Me.txtOthers.MinValue = 0
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(144, 23)
        Me.txtOthers.TabIndex = 3
        Me.txtOthers.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 19)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Others :"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.AfterDecimal = 2
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BeforeDecimal = 8
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotalAmount.Location = New System.Drawing.Point(152, 144)
        Me.txtTotalAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotalAmount.MaxLength = 10
        Me.txtTotalAmount.MaxValue = 0
        Me.txtTotalAmount.MinValue = 0
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtTotalAmount.TabIndex = 4
        Me.txtTotalAmount.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 19)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Total Amount :"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(8, 232)
        Me.btnClear.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'frmPigmyWithDraw
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(632, 277)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPigmyWithDraw"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BNN Withdraw"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Varaibles"

    Dim objPigmyAcc As New clsPigmyAccount
    Public strAccNo As String
    Public strName As String
    Dim intDateDiff As Integer = 0
    Dim intPrinciple As Integer = 0
    Dim dblROI As Double = 0.0
    Dim dblIntereset As Double = 0.0

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean
        If txtPGAccNo.Text = String.Empty Then
            MsgBox("Please select the agent ID", MsgBoxStyle.Information)
            txtPGAccNo.Focus()
            Return False
        ElseIf txtPGName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            txtPGName.Focus()
            Return False
        ElseIf txtAmount.Text = String.Empty Then
            MsgBox("Please enter the amount to deposit", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf txtPGAccNo.Text = String.Empty Then
            MsgBox("Please select the agents account no", MsgBoxStyle.Information)
            'cmbAGNo.Focus()
            Return False
        ElseIf txtPGName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            'cmbAGNo.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference no cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
            Return False
        ElseIf Val(txtTotalAmount.Text) > Val(txtBalance.Text) Then
            MsgBox("Amount to withdraw is greater than balance ", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnCheckRefNo() As Boolean

        If objPigmyAcc.fnCheckRefNo(txtRefNo.Text) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnSetData() As Boolean
        'objAgent.AgnetNo = cmbAGNo.SelectedIndex
        objPigmyAcc.Amount = txtAmount.Text
        objPigmyAcc.Reference = txtRefNo.Text
        objPigmyAcc.TransDate = dtpWithDrawDate.Value
        objPigmyAcc.PGNo = txtPGAccNo.Text
        objPigmyAcc.Narration = txtRemarks.Text
        objPigmyAcc.PGName = txtPGName.Text
        Return True
    End Function

    Public Function fnClear()
        'txtAGName.Text = ""
        txtAmount.Text = ""
        txtRefNo.Text = ""
        txtPGAccNo.Text = "BNN"
        txtRemarks.Text = ""
        txtPGName.Text = ""
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpWithDrawDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        Dim strNarration As String = "Withdrawal by " & txtPGAccNo.Text & " Narration:" & txtRemarks.Text
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtPGAccNo.Text, txtRefNo.Text, dtpWithDrawDate.Value, txtAmount.Text, "Withdraw by " & txtPGAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithDrawDate.Value, "Withdraw by BNN account " & txtPGAccNo.Text, "To", 1, 0, Val(txtTotalAmount.Text), 1, "Y", objTrans)
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 1, txtPGAccNo.Text, dtpWithDrawDate.Value, "Withdraw by BNN account " & txtPGAccNo.Text, "By", 28, Val(txtAmount.Text), 0, 2, "Y", objTrans) '''' This voucher calculation is for pigmy account Ledger ie ledger No 47
        fnVoucherEnterSub(lngVoucherNo, 1, txtPGAccNo.Text, dtpWithDrawDate.Value, "Interest paid to BNN account " & txtPGAccNo.Text, "By", 31, Val(txtInterest.Text), 0, 2, "Y", objTrans) '''' This voucher is for interest calculation ledger ie ledger No 49
        Return True

    End Function

    Public Function fnGetPigmyBalance()

        If objPigmyAcc.fnGetBalance(txtPGAccNo.Text) Then
            txtBalance.Text = objPigmyAcc.PimgyBalancetable.Rows(0).Item("Balance")
            txtROI.Text = objPigmyAcc.PimgyBalancetable.Rows(0).Item("ROI")
        End If

    End Function

    Public Function fnInterestPost() As Boolean

        If objPigmyAcc.fnGetBalance(txtPGAccNo.Text) Then
            intDateDiff = DateDiff(DateInterval.DayOfYear, objPigmyAcc.PimgyBalancetable.Rows(0).Item("AccDate"), Date.Today) / 30
            If fnCalPeriod() Then
                fnInterestCalc()
            End If
        End If

    End Function

    Public Function fnCalPeriod() As Boolean

        If objPigmyAcc.fnGetMinPeriod Then
            If intDateDiff < objPigmyAcc.MinPeriodtable.Rows(0).Item("MinPeriod") Then
                MsgBox("Sorry,interest cannot be posted as the minimum period for deposit is not yet over", MsgBoxStyle.Exclamation)
                Return False
            Else
                MsgBox("Interset can be posted for this account", MsgBoxStyle.Information)
                Return True
            End If
        End If

    End Function

    Public Function fnInterestCalc()    ''''' This is The Main Function where Interest Calculation is Done

        ''' Formula for interest calcualation in terms of Number of Months
        ''' BI = (PRINCIPLE*RATEOFINTEREST*NO OF MONTHS) / (12 * 100)
        ''' Formula for interest calculation in terms of Number Of Days
        ''' BI = (PRINCIPLE*RATEOFINTEREST*NO OF DAYS)/(365*100) 


        If objPigmyAcc.fnGetLastPaidDet(txtPGAccNo.Text) Then
            If IsDBNull(objPigmyAcc.GetMaxLastPaidTable.Rows(0).Item("TrDate")) Then

                '''' This Code Executes during First Withdrawl of ACCOUNT
                ''''  Here Interest is calculated based upno Number of Months

                intPrinciple = objPigmyAcc.PimgyBalancetable.Rows(0).Item("Balance")
                dblROI = objPigmyAcc.PimgyBalancetable.Rows(0).Item("ROI")

                dblIntereset = Math.Round((intPrinciple * dblROI * intDateDiff) / 1200)
                txtInterest.Text = dblIntereset
            Else
                intDateDiff = 0
                intDateDiff = DateDiff(DateInterval.DayOfYear, objPigmyAcc.GetMaxLastPaidTable.Rows(0).Item("TrDate"), Date.Today)
                If intDateDiff < 30 Then
                    ''''    This Code Executes, If the Customer withdraws within One Month of Perious withdraw Date
                    ''''    Here Interest Calculation is done depending on Number of Days of previous wothdrawl Date

                    intPrinciple = objPigmyAcc.PimgyBalancetable.Rows(0).Item("Balance")
                    dblROI = objPigmyAcc.PimgyBalancetable.Rows(0).Item("ROI")
                    dblIntereset = Math.Round((intPrinciple * dblROI * intDateDiff) / 36500)
                    txtInterest.Text = dblIntereset
                Else
                    ''''    This Code Executes If the customer is withdrawing  many time not within 1 month
                    ''''    Here Interest is calculated based upon Number of Months

                    intDateDiff = Math.Round(intDateDiff / 30)
                    intPrinciple = objPigmyAcc.PimgyBalancetable.Rows(0).Item("Balance")
                    dblROI = objPigmyAcc.PimgyBalancetable.Rows(0).Item("ROI")
                    dblIntereset = Math.Round((intPrinciple * dblROI * intDateDiff) / 1200)
                    txtInterest.Text = dblIntereset
                End If
            End If

        End If

    End Function

    Public Function fnCalcTotal()

        txtTotalAmount.Text = Val(txtAmount.Text) + Val(txtInterest.Text)

    End Function

#End Region

#Region "Procedure"

    Sub sbGetAgents()

        Dim objClsAgets As New clsPigmyAgent
        Dim dtAgents As DataTable
        If objClsAgets.fnGetAgents() Then

            dtAgents = objClsAgets.getAgentsTable

            '''''cmbAGNo.Items.Clear()
            '''''cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            '''''cmbAGNo.SourceDataString = New String(1) {"AgentID", "AgentName"}
            '''''cmbAGNo.SourceDataTable = dtAgents

        End If

    End Sub

    Sub sbLoadData()

        'If objAgent.fnGetData(txtPGAccNo.Text) Then
        'txtPGName.Text = objAgent.PigmyAccTable.Rows(0).Item("   


        'End If

    End Sub

#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmPigmyCust As New frmPGCust
        objfrmPigmyCust.strPGNo = ""
        objfrmPigmyCust.ShowDialog(Me)
        If objfrmPigmyCust.strPGNo <> "" Then
            txtPGAccNo.Text = objfrmPigmyCust.strPGNo
            txtPGName.Text = objfrmPigmyCust.strPGName
            '''''   sbLoadFD()
            txtPGAccNo.Focus()
        End If
        objfrmPigmyCust.Dispose()

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmAgents As New frmAGAccSearch
        objfrmAgents.ShowDialog()

    End Sub

    Private Sub frmPigmyDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpLastPaidDate.Value = Date.Now
        dtpWithDrawDate.Value = Date.Now

        txtPGAccNo.Text = strAccNo
        txtPGName.Text = strName
        ''''''sbChangeFont(txtAGName)
        ''''''sbChangeFont(cmbAGNo)
        sbGetAgents()
        fnGetPigmyBalance()

    End Sub

    Private Sub cmbAGNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ''txtAGName.Text = cmbAGNo.SelectedItem.col1

    End Sub

    Private Sub txtPGAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPGAccNo.TextChanged

        If txtPGAccNo.Text.StartsWith("BNN") = False Then
            txtPGAccNo.Undo()
            txtPGAccNo.ClearUndo()
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
                        ' If objPigmyAcc.fnWithDrawlData Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "WithDraw by " & txtPGAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Withdraw", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed successfully,do you want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            fnClear()
                            txtPGAccNo.Text = String.Empty
                        Else
                            Me.Close()
                        End If
                        'Else
                        '    MsgBox("Transaction Cannot be completed,Due to Internal Error", MsgBoxStyle.Exclamation)
                        'End If
                    Else
                        MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Reference no already exist,please try other reference no", MsgBoxStyle.Exclamation)
                    txtRefNo.Focus()
                End If
        End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub


#End Region

    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objCustList As New frmPGCust
        txtPGName.Text = objCustList.strPGName
        txtPGAccNo.Text = objCustList.strPGNo
        objCustList.ShowDialog()

    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click

        fnInterestPost()

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged, txtInterest.TextChanged

        fnCalcTotal()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        fnClear()
    End Sub


End Class
