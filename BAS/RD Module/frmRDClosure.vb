Public Class frmRDClosure
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnSearchRD As BankControls.NewButton
    Friend WithEvents txtRDAccountNo As BankControls.TextControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents dtpRDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDeposit As BankControls.NumericControl
    Friend WithEvents txtYY As BankControls.NumericControl
    Friend WithEvents txtMM As BankControls.NumericControl
    Friend WithEvents txtDD As BankControls.NumericControl
    Friend WithEvents txtIntAmount As BankControls.NumericControl
    Friend WithEvents txtPaidInterest As BankControls.NumericControl
    Friend WithEvents txtMaturityAmt As BankControls.NumericControl
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtClosingAmout As BankControls.NumericControl
    Friend WithEvents dtpClosingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOK As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnRDTransaction As BankControls.NewButton
    Friend WithEvents btnRDWithDraw As BankControls.NewButton
    Friend WithEvents btnRDCreation As BankControls.NewButton
    Friend WithEvents btnRDPremature As BankControls.NewButton
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dep_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dep_Amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents By As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtDPC As BankControls.NumericControl
    Friend WithEvents lblDelayedCharge As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDClosure))
        Me.Label32 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtROI = New BankControls.NumericControl
        Me.dtpRDDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDeposit = New BankControls.NumericControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtYY = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMM = New BankControls.NumericControl
        Me.txtDD = New BankControls.NumericControl
        Me.txtIntAmount = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPaidInterest = New BankControls.NumericControl
        Me.btnCalInterest = New BankControls.NewButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMaturityAmt = New BankControls.NumericControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblDelayedCharge = New System.Windows.Forms.Label
        Me.txtDPC = New BankControls.NumericControl
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtClosingAmout = New BankControls.NumericControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpClosingDate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnOK = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnRDTransaction = New BankControls.NewButton
        Me.btnRDWithDraw = New BankControls.NewButton
        Me.btnRDCreation = New BankControls.NewButton
        Me.btnRDPremature = New BankControls.NewButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtRDAccountNo = New BankControls.TextControl
        Me.btnSearchRD = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.Dep_Date = New System.Windows.Forms.ColumnHeader
        Me.Dep_Amount = New System.Windows.Forms.ColumnHeader
        Me.By = New System.Windows.Forms.ColumnHeader
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Ivory
        Me.Label32.Location = New System.Drawing.Point(232, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(233, 23)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "Recurring Deposit Closure"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtROI)
        Me.GroupBox1.Controls.Add(Me.dtpRDDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDeposit)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(208, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 132)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit Details"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Enabled = False
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.Beige
        Me.txtROI.Location = New System.Drawing.Point(80, 90)
        Me.txtROI.LostFocusColour = System.Drawing.Color.White
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ReadOnly = True
        Me.txtROI.Size = New System.Drawing.Size(136, 23)
        Me.txtROI.TabIndex = 7
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpRDDate
        '
        Me.dtpRDDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpRDDate.Enabled = False
        Me.dtpRDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRDDate.Location = New System.Drawing.Point(80, 26)
        Me.dtpRDDate.MaxDate = New Date(9998, 1, 29, 0, 0, 0, 0)
        Me.dtpRDDate.Name = "dtpRDDate"
        Me.dtpRDDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpRDDate.TabIndex = 5
        Me.dtpRDDate.Value = New Date(2007, 8, 8, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "ROI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Deposit:"
        '
        'txtDeposit
        '
        Me.txtDeposit.AfterDecimal = 2
        Me.txtDeposit.BackColor = System.Drawing.Color.White
        Me.txtDeposit.BeforeDecimal = 8
        Me.txtDeposit.Enabled = False
        Me.txtDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.txtDeposit.Location = New System.Drawing.Point(80, 58)
        Me.txtDeposit.LostFocusColour = System.Drawing.Color.White
        Me.txtDeposit.MaxLength = 10
        Me.txtDeposit.MaxValue = 0
        Me.txtDeposit.MinValue = 0
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.ReadOnly = True
        Me.txtDeposit.Size = New System.Drawing.Size(136, 23)
        Me.txtDeposit.TabIndex = 6
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtYY)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtMM)
        Me.GroupBox2.Controls.Add(Me.txtDD)
        Me.GroupBox2.Controls.Add(Me.txtIntAmount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPaidInterest)
        Me.GroupBox2.Controls.Add(Me.btnCalInterest)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(456, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 133)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deposit Period Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "Int Amount"
        '
        'txtYY
        '
        Me.txtYY.AfterDecimal = 2
        Me.txtYY.BackColor = System.Drawing.Color.White
        Me.txtYY.BeforeDecimal = 8
        Me.txtYY.Enabled = False
        Me.txtYY.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYY.GotFocusColour = System.Drawing.Color.White
        Me.txtYY.Location = New System.Drawing.Point(120, 43)
        Me.txtYY.LostFocusColour = System.Drawing.Color.White
        Me.txtYY.MaxLength = 10
        Me.txtYY.MaxValue = 0
        Me.txtYY.MinValue = 0
        Me.txtYY.Name = "txtYY"
        Me.txtYY.ReadOnly = True
        Me.txtYY.Size = New System.Drawing.Size(32, 23)
        Me.txtYY.TabIndex = 9
        Me.txtYY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 16)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "YY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Period:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(160, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 16)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "MM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(208, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "DD"
        '
        'txtMM
        '
        Me.txtMM.AfterDecimal = 2
        Me.txtMM.BackColor = System.Drawing.Color.White
        Me.txtMM.BeforeDecimal = 8
        Me.txtMM.Enabled = False
        Me.txtMM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMM.GotFocusColour = System.Drawing.Color.White
        Me.txtMM.Location = New System.Drawing.Point(160, 43)
        Me.txtMM.LostFocusColour = System.Drawing.Color.White
        Me.txtMM.MaxLength = 10
        Me.txtMM.MaxValue = 0
        Me.txtMM.MinValue = 0
        Me.txtMM.Name = "txtMM"
        Me.txtMM.ReadOnly = True
        Me.txtMM.Size = New System.Drawing.Size(32, 23)
        Me.txtMM.TabIndex = 10
        Me.txtMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDD
        '
        Me.txtDD.AfterDecimal = 2
        Me.txtDD.BackColor = System.Drawing.Color.White
        Me.txtDD.BeforeDecimal = 8
        Me.txtDD.Enabled = False
        Me.txtDD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDD.GotFocusColour = System.Drawing.Color.White
        Me.txtDD.Location = New System.Drawing.Point(200, 43)
        Me.txtDD.LostFocusColour = System.Drawing.Color.White
        Me.txtDD.MaxLength = 10
        Me.txtDD.MaxValue = 0
        Me.txtDD.MinValue = 0
        Me.txtDD.Name = "txtDD"
        Me.txtDD.ReadOnly = True
        Me.txtDD.Size = New System.Drawing.Size(32, 23)
        Me.txtDD.TabIndex = 11
        Me.txtDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIntAmount
        '
        Me.txtIntAmount.AfterDecimal = 2
        Me.txtIntAmount.BackColor = System.Drawing.Color.White
        Me.txtIntAmount.BeforeDecimal = 8
        Me.txtIntAmount.Enabled = False
        Me.txtIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntAmount.GotFocusColour = System.Drawing.Color.Beige
        Me.txtIntAmount.Location = New System.Drawing.Point(120, 75)
        Me.txtIntAmount.LostFocusColour = System.Drawing.Color.White
        Me.txtIntAmount.MaxLength = 10
        Me.txtIntAmount.MaxValue = 0
        Me.txtIntAmount.MinValue = 0
        Me.txtIntAmount.Name = "txtIntAmount"
        Me.txtIntAmount.ReadOnly = True
        Me.txtIntAmount.Size = New System.Drawing.Size(112, 23)
        Me.txtIntAmount.TabIndex = 12
        Me.txtIntAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "Paid Interest:"
        '
        'txtPaidInterest
        '
        Me.txtPaidInterest.AfterDecimal = 2
        Me.txtPaidInterest.BackColor = System.Drawing.Color.White
        Me.txtPaidInterest.BeforeDecimal = 8
        Me.txtPaidInterest.Enabled = False
        Me.txtPaidInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidInterest.GotFocusColour = System.Drawing.Color.Beige
        Me.txtPaidInterest.Location = New System.Drawing.Point(120, 107)
        Me.txtPaidInterest.LostFocusColour = System.Drawing.Color.White
        Me.txtPaidInterest.MaxLength = 10
        Me.txtPaidInterest.MaxValue = 0
        Me.txtPaidInterest.MinValue = 0
        Me.txtPaidInterest.Name = "txtPaidInterest"
        Me.txtPaidInterest.ReadOnly = True
        Me.txtPaidInterest.Size = New System.Drawing.Size(112, 23)
        Me.txtPaidInterest.TabIndex = 13
        Me.txtPaidInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.Enabled = False
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(240, 43)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(32, 32)
        Me.btnCalInterest.TabIndex = 14
        Me.btnCalInterest.Text = "Int"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        Me.btnCalInterest.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMaturityAmt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpMaturityDate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(744, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 133)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Maturity Details"
        '
        'txtMaturityAmt
        '
        Me.txtMaturityAmt.AfterDecimal = 2
        Me.txtMaturityAmt.BackColor = System.Drawing.Color.White
        Me.txtMaturityAmt.BeforeDecimal = 8
        Me.txtMaturityAmt.Enabled = False
        Me.txtMaturityAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaturityAmt.GotFocusColour = System.Drawing.Color.Beige
        Me.txtMaturityAmt.Location = New System.Drawing.Point(71, 76)
        Me.txtMaturityAmt.LostFocusColour = System.Drawing.Color.White
        Me.txtMaturityAmt.MaxLength = 10
        Me.txtMaturityAmt.MaxValue = 0
        Me.txtMaturityAmt.MinValue = 0
        Me.txtMaturityAmt.Name = "txtMaturityAmt"
        Me.txtMaturityAmt.ReadOnly = True
        Me.txtMaturityAmt.Size = New System.Drawing.Size(120, 23)
        Me.txtMaturityAmt.TabIndex = 17
        Me.txtMaturityAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Date:"
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(70, 43)
        Me.dtpMaturityDate.MaxDate = New Date(9998, 11, 30, 0, 0, 0, 0)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(137, 23)
        Me.dtpMaturityDate.TabIndex = 16
        Me.dtpMaturityDate.Value = New Date(2007, 8, 8, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "Amount:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblDelayedCharge)
        Me.GroupBox4.Controls.Add(Me.txtDPC)
        Me.GroupBox4.Controls.Add(Me.txtReceiptNo)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtClosingAmout)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.dtpClosingDate)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(208, 273)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(752, 74)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Closing Details"
        '
        'lblDelayedCharge
        '
        Me.lblDelayedCharge.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDelayedCharge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelayedCharge.ForeColor = System.Drawing.Color.Red
        Me.lblDelayedCharge.Location = New System.Drawing.Point(265, 46)
        Me.lblDelayedCharge.Name = "lblDelayedCharge"
        Me.lblDelayedCharge.Size = New System.Drawing.Size(157, 18)
        Me.lblDelayedCharge.TabIndex = 134
        Me.lblDelayedCharge.Text = "Delayed paid charges"
        '
        'txtDPC
        '
        Me.txtDPC.AfterDecimal = 2
        Me.txtDPC.BackColor = System.Drawing.Color.White
        Me.txtDPC.BeforeDecimal = 8
        Me.txtDPC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPC.GotFocusColour = System.Drawing.Color.Beige
        Me.txtDPC.Location = New System.Drawing.Point(428, 46)
        Me.txtDPC.LostFocusColour = System.Drawing.Color.White
        Me.txtDPC.MaxLength = 10
        Me.txtDPC.MaxValue = 0
        Me.txtDPC.MinValue = 0
        Me.txtDPC.Name = "txtDPC"
        Me.txtDPC.Size = New System.Drawing.Size(128, 23)
        Me.txtDPC.TabIndex = 132
        Me.txtDPC.Text = "0"
        Me.txtDPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 2
        Me.txtReceiptNo.BackColor = System.Drawing.Color.White
        Me.txtReceiptNo.BeforeDecimal = 8
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.Color.Beige
        Me.txtReceiptNo.Location = New System.Drawing.Point(114, 44)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.White
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 16)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Receipt No. :"
        '
        'txtClosingAmout
        '
        Me.txtClosingAmout.AfterDecimal = 2
        Me.txtClosingAmout.BackColor = System.Drawing.Color.White
        Me.txtClosingAmout.BeforeDecimal = 8
        Me.txtClosingAmout.Enabled = False
        Me.txtClosingAmout.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClosingAmout.GotFocusColour = System.Drawing.Color.Beige
        Me.txtClosingAmout.Location = New System.Drawing.Point(428, 15)
        Me.txtClosingAmout.LostFocusColour = System.Drawing.Color.White
        Me.txtClosingAmout.MaxLength = 10
        Me.txtClosingAmout.MaxValue = 0
        Me.txtClosingAmout.MinValue = 0
        Me.txtClosingAmout.Name = "txtClosingAmout"
        Me.txtClosingAmout.ReadOnly = True
        Me.txtClosingAmout.Size = New System.Drawing.Size(128, 23)
        Me.txtClosingAmout.TabIndex = 21
        Me.txtClosingAmout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(327, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 16)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Amount Pay:"
        '
        'dtpClosingDate
        '
        Me.dtpClosingDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClosingDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosingDate.Location = New System.Drawing.Point(115, 15)
        Me.dtpClosingDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpClosingDate.Name = "dtpClosingDate"
        Me.dtpClosingDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpClosingDate.TabIndex = 19
        Me.dtpClosingDate.Value = New Date(2007, 8, 8, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Closing Date:"
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(744, 574)
        Me.btnOK.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 40)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(856, 574)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "&Close"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnRDTransaction)
        Me.Panel2.Controls.Add(Me.btnRDWithDraw)
        Me.Panel2.Controls.Add(Me.btnRDCreation)
        Me.Panel2.Controls.Add(Me.btnRDPremature)
        Me.Panel2.Location = New System.Drawing.Point(8, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 442)
        Me.Panel2.TabIndex = 24
        '
        'btnRDTransaction
        '
        Me.btnRDTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRDTransaction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnRDTransaction.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnRDTransaction.Image = CType(resources.GetObject("btnRDTransaction.Image"), System.Drawing.Image)
        Me.btnRDTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRDTransaction.Location = New System.Drawing.Point(16, 184)
        Me.btnRDTransaction.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRDTransaction.Name = "btnRDTransaction"
        Me.btnRDTransaction.Size = New System.Drawing.Size(160, 40)
        Me.btnRDTransaction.TabIndex = 26
        Me.btnRDTransaction.Text = "Transaction Det"
        Me.btnRDTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRDWithDraw
        '
        Me.btnRDWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRDWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDWithDraw.ForeColor = System.Drawing.Color.Black
        Me.btnRDWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnRDWithDraw.Image = CType(resources.GetObject("btnRDWithDraw.Image"), System.Drawing.Image)
        Me.btnRDWithDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRDWithDraw.Location = New System.Drawing.Point(16, 120)
        Me.btnRDWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRDWithDraw.Name = "btnRDWithDraw"
        Me.btnRDWithDraw.Size = New System.Drawing.Size(160, 40)
        Me.btnRDWithDraw.TabIndex = 25
        Me.btnRDWithDraw.Text = "WithDrawal"
        Me.btnRDWithDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRDWithDraw.Visible = False
        '
        'btnRDCreation
        '
        Me.btnRDCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDCreation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRDCreation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDCreation.ForeColor = System.Drawing.Color.Black
        Me.btnRDCreation.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnRDCreation.Image = CType(resources.GetObject("btnRDCreation.Image"), System.Drawing.Image)
        Me.btnRDCreation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRDCreation.Location = New System.Drawing.Point(16, 240)
        Me.btnRDCreation.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRDCreation.Name = "btnRDCreation"
        Me.btnRDCreation.Size = New System.Drawing.Size(160, 40)
        Me.btnRDCreation.TabIndex = 27
        Me.btnRDCreation.Text = "New RD Creation"
        Me.btnRDCreation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRDPremature
        '
        Me.btnRDPremature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDPremature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRDPremature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDPremature.ForeColor = System.Drawing.Color.Black
        Me.btnRDPremature.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnRDPremature.Image = CType(resources.GetObject("btnRDPremature.Image"), System.Drawing.Image)
        Me.btnRDPremature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRDPremature.Location = New System.Drawing.Point(16, 304)
        Me.btnRDPremature.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRDPremature.Name = "btnRDPremature"
        Me.btnRDPremature.Size = New System.Drawing.Size(160, 40)
        Me.btnRDPremature.TabIndex = 28
        Me.btnRDPremature.Text = "RD Premature"
        Me.btnRDPremature.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtRDAccountNo)
        Me.GroupBox5.Controls.Add(Me.btnSearchRD)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txtName)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(208, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(752, 72)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Account Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 16)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Account No. :"
        '
        'txtRDAccountNo
        '
        Me.txtRDAccountNo.AlphaNumeric = True
        Me.txtRDAccountNo.BackColor = System.Drawing.Color.White
        Me.txtRDAccountNo.BlankSpace = False
        Me.txtRDAccountNo.Enabled = False
        Me.txtRDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDAccountNo.GotFocusColour = System.Drawing.Color.Beige
        Me.txtRDAccountNo.Location = New System.Drawing.Point(128, 32)
        Me.txtRDAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtRDAccountNo.Mandatory = False
        Me.txtRDAccountNo.MaxLength = 10
        Me.txtRDAccountNo.Name = "txtRDAccountNo"
        Me.txtRDAccountNo.ReadOnly = True
        Me.txtRDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtRDAccountNo.SpecialChar = True
        Me.txtRDAccountNo.TabIndex = 1
        Me.txtRDAccountNo.Text = "RD"
        '
        'btnSearchRD
        '
        Me.btnSearchRD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchRD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchRD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchRD.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSearchRD.Image = CType(resources.GetObject("btnSearchRD.Image"), System.Drawing.Image)
        Me.btnSearchRD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchRD.Location = New System.Drawing.Point(264, 32)
        Me.btnSearchRD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSearchRD.Name = "btnSearchRD"
        Me.btnSearchRD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchRD.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.Beige
        Me.txtName.Location = New System.Drawing.Point(408, 36)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(328, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.White
        Me.lvInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Dep_Date, Me.Dep_Amount, Me.By})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.HideSelection = False
        Me.lvInterest.Location = New System.Drawing.Point(214, 354)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(744, 214)
        Me.lvInterest.TabIndex = 25
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 84
        '
        'Dep_Date
        '
        Me.Dep_Date.Text = "Deposit Date"
        Me.Dep_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dep_Date.Width = 157
        '
        'Dep_Amount
        '
        Me.Dep_Amount.Text = "Deposit Amount"
        Me.Dep_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dep_Amount.Width = 202
        '
        'By
        '
        Me.By.Text = "By"
        Me.By.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.By.Width = 150
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmRDClosure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 685)
        Me.Controls.Add(Me.lvInterest)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRDClosure"
        Me.ShowInTaskbar = False
        Me.Text = "RDClosure"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Single instance creation"

    Private Shared m_FormDefInstance As frmRDClosure
    Private Shared m_InitilizeDefInstance As Boolean

    Public Shared Property DefInstance() As frmRDClosure
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitilizeDefInstance = True
                m_FormDefInstance = New frmRDClosure
                m_InitilizeDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmRDClosure)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objClsRDClosure As New clsRDClousure
    Dim objRDAccount As New clsRDAccount
    Dim intDateDiff As Integer
    Dim intDateDiff1 As Integer
    Dim objRDAcc As New clsRDAccount
    Dim AmountPay As Double
    Dim dblProvisionInterest As Double
    Dim dblDueInterest As Double
    Dim bolVisible As Boolean
    Dim dblTotalDeposit As New Double
    Dim rdDate As New Date
    Dim rdMatDate As New Date
    Dim NumberOfMonths As Integer = 0
    Dim NumberOfDays As Integer = 0
    Dim RdRateOfInterest As Double = 0
#End Region

#Region "Functions"

    Sub clear()

        txtRDAccountNo.Text = "RD"
        txtName.ResetText()
        txtDeposit.ResetText()
        txtROI.ResetText()
        txtYY.ResetText()
        txtMM.ResetText()
        txtDD.ResetText()
        txtIntAmount.ResetText()
        txtPaidInterest.ResetText()
        txtMaturityAmt.ResetText()
        txtReceiptNo.ResetText()
        txtMaturityAmt.ResetText()
        txtClosingAmout.ResetText()
        btnSearchRD.Focus()
        lvInterest.Items.Clear()


    End Sub


    Public Function fnGetDetails() As Boolean
        Dim objIntTable As DataTable
        Try
            If objClsRDClosure.fnGetRdDetails(txtRDAccountNo.Text) Then
                dtpRDDate.Value = Format(objClsRDClosure.RDDetailstable.Rows(0).Item("RDDate"), "yyyy-MM-dd")
                txtROI.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("RDROI")
                txtYY.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("Years")
                txtDeposit.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("Balance")
                txtMM.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("Months")
                txtDD.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("Days")
                txtIntAmount.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("IntAmount") - objClsRDClosure.RDDetailstable.Rows(0).Item("CAmount")
                txtPaidInterest.Text = 0
                dtpMaturityDate.Value = Format(objClsRDClosure.RDDetailstable.Rows(0).Item("RDMaturityDate"), "yyyy-MM-dd")
                txtMaturityAmt.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("MatAmount")
                dtpClosingDate.Value = Format(Date.Today, "yyyy-MM-dd")
                txtClosingAmout.Text = objClsRDClosure.RDDetailstable.Rows(0).Item("MatAmount")
                AmountPay = objClsRDClosure.RDDetailstable.Rows(0).Item("MatAmount")
                RdRateOfInterest = Convert.ToDouble(objClsRDClosure.RDDetailstable.Rows(0).Item("RDROI"))

                If Not objClsRDClosure.RDTransaction Is Nothing Then
                    objIntTable = objClsRDClosure.RDTransaction
                    Dim intCounter As Integer = 0
                    Dim lvItem As ListViewItem
                    lvInterest.Items.Clear()
                    If lvInterest.Columns.Count > 5 Then
                        lvInterest.Columns.RemoveAt(5)
                    End If

                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("TrDate"), "dd-MMM-yyyy"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Deposit"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Type"))
                        dblTotalDeposit += Convert.ToDouble(objIntTable.Rows(intCounter).Item("Deposit"))
                        intCounter += 1
                    End While

                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("TrDate"), "dd-MMM-yyyy"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Deposit"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Type"))
                        dblTotalDeposit += Convert.ToDouble(objIntTable.Rows(intCounter).Item("Deposit"))
                        intCounter += 1
                    End While

                    ''penalty interest calculation
                    txtDPC.ResetText()
                    NumberOfDays = 0
                    NumberOfMonths = 0
                    rdDate = objClsRDClosure.RDDetailstable.Rows(0).Item("RDDate")
                    rdMatDate = objClsRDClosure.RDDetailstable.Rows(0).Item("RDMaturityDate")
                    If rdMatDate < Date.Today Then
                        NumberOfMonths = DateDiff(DateInterval.Month, rdDate, rdMatDate)
                        Dim i As Integer = 0
                        Dim j As Integer = 0
                        Dim Nextdate As Date
                        While (i <= NumberOfMonths) And (j < objClsRDClosure.RDTransaction.Rows.Count)
                            Nextdate = DateAdd(DateInterval.Month, i + 1, rdDate)

                            If Nextdate.Date < objClsRDClosure.RDTransaction.Rows(j).Item("TrDate") Then
                                Dim temptrdate As Date = objClsRDClosure.RDTransaction.Rows(j).Item("TrDate")
                                Dim tempNextDate As Integer = DateDiff(DateInterval.Day, Nextdate, objClsRDClosure.RDTransaction.Rows(j).Item("TrDate"))
                                NumberOfDays += DateDiff(DateInterval.Day, Nextdate, objClsRDClosure.RDTransaction.Rows(j).Item("TrDate"))
                                If tempNextDate = 30 Or tempNextDate = 31 Then
                                    i += 1
                                    NumberOfMonths -= 1
                                End If
                            ElseIf (Nextdate.Date >= objClsRDClosure.RDTransaction.Rows(j).Item("TrDate")) Then
                                Dim temptrdate As Date = objClsRDClosure.RDTransaction.Rows(j).Item("TrDate")
                                NumberOfDays += 0
                            End If
                            i += 1
                            j += 1
                        End While
                        txtDPC.Text = Math.Round((dblTotalDeposit * NumberOfDays * RdRateOfInterest) / 36500)
                    End If
                End If
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function fnCheckDet() As Boolean

        If txtMaturityAmt.Text <> "0" Then
            MsgBox("Cannot  Be Closed, As still '" & txtMaturityAmt.Text & "' left", MsgBoxStyle.Exclamation, " RD Module")
            Return False
        Else
            fnCheckDate()
        End If

    End Function

    Public Function fnCheckDate() As Boolean
        Dim intDate As Integer
        Dim test As Double = Val(txtMaturityAmt.Text) - Val(txtIntAmount.Text)
        intDate = DateDiff(DateInterval.DayOfYear, Date.Today, dtpMaturityDate.Value)
        If intDate > 0 Or Val(txtDeposit.Text) < test Then
            MsgBox("Account Cannot Be Closed,You have to Premature the Account, Because either maturity date not yet completed or total deposit amount not given(Maturity amt-Interest amt)", MsgBoxStyle.Exclamation, "RD Module")
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnCalInterest() As Boolean

        If objRDAcc.fnGetDetails(txtRDAccountNo.Text) Then
            intDateDiff = DateDiff(DateInterval.DayOfYear, objRDAcc.GetRDDetailstbl.Rows(0).Item("RDDate"), Date.Today) / 30
            intDateDiff1 = DateDiff(DateInterval.DayOfYear, objRDAcc.GetRDDetailstbl.Rows(0).Item("RDDate"), dtpMaturityDate.Value) '/ 30
            If fnCheckPeriod() Then
                If fnPostInterest() Then
                End If
            End If
        End If

    End Function

    Public Function fnCheckPeriod() As Boolean

        If objRDAcc.fnGetMinPeriod Then
            If intDateDiff < objRDAcc.MinPeriodTable.Rows(0).Item("MinMonth") Then
                MsgBox("Sorry,interest cannot be posted for this account", MsgBoxStyle.Exclamation, "RD Module")
                Return False
            Else
                MsgBox("Interest can be posted for this account", MsgBoxStyle.Exclamation, "RD Module")
                Return True
            End If
        End If

    End Function

    Public Function fnPostInterest() As Boolean

        Dim dblBalance As Double
        Dim dblROI As Double
        Dim dblInterestAmount As Double
        Dim dblOtherAmt As Double

        dblBalance = objRDAcc.GetRDDetailstbl.Rows(0).Item("Balance")
        dblROI = objRDAcc.GetRDDetailstbl.Rows(0).Item("RDROI")
        dblInterestAmount = Math.Round((dblBalance * intDateDiff1 * dblROI) / (365 * 100), 2)
        txtIntAmount.Text = Math.Round(dblInterestAmount)
        txtPaidInterest.Text = Math.Round(dblInterestAmount)
        txtMaturityAmt.Text = Val(txtDeposit.Text) + Val(txtIntAmount.Text)
        txtClosingAmout.Text = Val(txtMaturityAmt.Text)
        Return True

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpClosingDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Account Closure By  " & txtRDAccountNo.Text & ""

        objRDAcc.fnWithDrawl(lngVoucherNo, objTrans) 'To insert into RD Transaction table
        objRDAcc.fnUpdateStatus(txtRDAccountNo.Text, lngVoucherNo, objTrans) 'Query to close RD Account
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtRDAccountNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, txtMaturityAmt.Text, "Account closure by  " & txtRDAccountNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpClosingDate.Value, "Account closure by " & txtRDAccountNo.Text, "To", 1, 0, Val(txtMaturityAmt.Text), 1, "Y", objTrans)

        'Credit accounts :-monthly monthly delayed paid chages to customer while closing the RD.
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpClosingDate.Value, "Monthly delayed paid chages of RD" & txtRDAccountNo.Text, "To", 13, 0, Val(txtDPC.Text), 1, "Y", objTrans)

        'Debit accounts 
        '''First one for the ledger no 48 i.e RD Ledger
        '''Second is for the legere no 50 i.e Interest on RD Ledger

        fnVoucherEnterSub(lngVoucherNo, 1, txtRDAccountNo.Text, dtpClosingDate.Value, "Account closure by  " & txtRDAccountNo.Text, "By", 29, Val(txtDeposit.Text), 0, 2, "Y", objTrans)

        If dblProvisionInterest <> 0 Then
            'Debit accounts -Interest Payable
            fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccountNo.Text, dtpClosingDate.Value, "IntProvision by account no" & txtRDAccountNo.Text, "By", 14, Val(dblProvisionInterest), 0, 2, "Y", objTrans)
        End If

        fnVoucherEnterSub(lngVoucherNo, 1, txtRDAccountNo.Text, dtpClosingDate.Value, "Account closure by  " & txtRDAccountNo.Text, "By", 32, Val(txtIntAmount.Text) - Val(dblProvisionInterest), 0, 3, "Y", objTrans)

        Return True

    End Function

    Public Function fnSetData() As Boolean

        objRDAcc.Amount = txtDeposit.Text
        objRDAcc.Reference = txtReceiptNo.Text
        objRDAcc.TransDate = dtpClosingDate.Value
        objRDAcc.RDNo = txtRDAccountNo.Text
        objRDAcc.IntPaid = txtPaidInterest.Text
        objRDAcc.MatAmount = txtMaturityAmt.Text
        objRDAcc.intAmount = txtIntAmount.Text
        Return True

    End Function

    Public Function fnRDClouser(ByVal objTrans As IDbTransaction)

        If fnCheckDate() Then
            If fnSetData() Then
                If fnGenerateVoucher(objTrans) Then
                    fnLogEntry(pbUserId, "Account closure by  " & txtRDAccountNo.Text & " Amount " & txtMaturityAmt.Text, Date.Now, "Transaction Withdraw", objTrans)
                    objTrans.Commit()
                    MsgBox("Account closed successfully", MsgBoxStyle.Information, "RD Module")
                    clear()
                Else
                    MsgBox("Account cannot be closed due to internal error ", MsgBoxStyle.Critical, "RD Module")
                End If
            Else
                MsgBox("Account cannot be closed due to internal error ", MsgBoxStyle.Critical, "RD Module")
            End If
        End If

    End Function
    Public Function fnCheckAmount() As Boolean
        'If Val(txtDeposit.Text) + Val(txtIntAmount.Text) = Val(txtMaturityAmt.Text) Then
        '    MsgBox("Please check collected principal amount", MsgBoxStyle.Exclamation)
        '    Return False
        'Else
        If txtReceiptNo.Text = String.Empty Then
            MsgBox("Please enter receipt number", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnLoadIntetest() As Boolean
        dblProvisionInterest = 0
        dblDueInterest = 0

        If objRDAcc.fnCheckRDScheme(txtRDAccountNo.Text) Then
            Dim dtMasterData As DataTable = objRDAcc.RDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                If objRDAcc.fnGetInterestDet(txtRDAccountNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objRDAcc.dtIntPost.Rows.Count
                        Select Case objRDAcc.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objRDAcc.dtIntPost.Rows(intCount).Item("ProvisionAmount")
                            Case "Provision"
                                dblProvisionInterest = objRDAcc.dtIntPost.Rows(intCount).Item("ProvisionAmount")
                        End Select
                        intCount += 1
                    End While
                End If
            Else
                If objRDAcc.fnGetNonInterestDet(txtRDAccountNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objRDAcc.dtIntPost.Rows.Count
                        Select Case objRDAcc.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objRDAcc.dtIntPost.Rows(intCount).Item("ProvisionAmount")
                            Case "Provision"
                                dblProvisionInterest = objRDAcc.dtIntPost.Rows(intCount).Item("ProvisionAmount")
                        End Select
                        intCount += 1
                    End While
                End If
            End If
        End If

    End Function

#End Region

    Private Sub btnSearchRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRD.Click

        Dim objRDAccCust As New frmRDCust
        dblTotalDeposit = 0
        objRDAccCust.strRDNo = String.Empty
        objRDAccCust.ShowDialog(Me)

        If objRDAccCust.strRDNo <> String.Empty Then
            txtRDAccountNo.Text = objRDAccCust.strRDNo
            txtName.Text = objRDAccCust.strRDName
              fnGetDetails()
            fnLoadIntetest()
        End If

        objRDAccCust.Dispose()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheckAmount() Then
                If MsgBox("are you  sure you want to close this account", MsgBoxStyle.YesNo, "RD Details") = MsgBoxResult.Yes Then
                    objTrans = fnGetTransaction()
                    If objRDAcc.fnCheckRDAccount(txtRDAccountNo.Text) Then
                        fnRDClouser(objTrans)

                    Else
                        MsgBox("Please check the account no, account no doesnot exist", MsgBoxStyle.Exclamation, "RD Module")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub

    Private Sub btnRDTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDTransaction.Click

        If txtRDAccountNo.Text <> "RD" Then
            Dim objRDTransaction As New frmRDTransaction
            objRDTransaction.strAccNo = txtRDAccountNo.Text
            objRDTransaction.strName = txtName.Text
            objRDTransaction.ShowDialog()
        Else
            MsgBox("Enter valid account number", MsgBoxStyle.Information)
            txtRDAccountNo.Focus()
        End If

    End Sub

    Private Sub btnRDWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDWithDraw.Click

        If txtRDAccountNo.Text <> "RD" Then

            Dim objRDWithDraw As New frmRDWithDraw
            objRDWithDraw.strAccNo = txtRDAccountNo.Text
            objRDWithDraw.strName = txtName.Text
            objRDWithDraw.ShowDialog()

        End If

    End Sub

    Private Sub btnRDCreation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDCreation.Click

        Dim objRDCreation As New frmRDAccCreation
        objRDCreation = frmRDAccCreation.DefInstance
        objRDCreation.MdiParent = Me.MdiParent
        objRDCreation.BringToFront()
        objRDCreation.Show()
        objRDCreation = Nothing


    End Sub

    Private Sub txtRDAccountNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRDAccountNo.TextChanged

        If txtRDAccountNo.Text.StartsWith("RD") = False Then
            txtRDAccountNo.Undo()
            txtRDAccountNo.ClearUndo()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnRDPremature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDPremature.Click
        If txtRDAccountNo.Text <> "RD" Then
            Dim objRDPreMature As New frmRDPreMature
            objRDPreMature.strAccNo = txtRDAccountNo.Text
            objRDPreMature.strName = txtName.Text
            objRDPreMature.ShowDialog()
        Else
            MsgBox("Enter valid Account Account Number", MsgBoxStyle.Information)
            txtRDAccountNo.Focus()
        End If
    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        Dim intDate As Integer
        intDate = DateDiff(DateInterval.DayOfYear, Date.Today, dtpMaturityDate.Value)
        If intDate > 0 Then
            MsgBox("Maturity date is not yet over so interest cannot be calculated", MsgBoxStyle.Exclamation, "RD Module")
        ElseIf txtROI.Text = String.Empty Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Information)
        Else
            fnCalInterest()
        End If
    End Sub



    Private Sub frmRDClosure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpClosingDate.Value = Date.Now
        dtpMaturityDate.Value = Date.Now
        dtpRDDate.Value = Date.Now
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolVisible = False Then
            lblDelayedCharge.Text = ""
            bolVisible = True
        Else
            lblDelayedCharge.Text = "Delayed paid charges"
            bolVisible = False
        End If
    End Sub
    Private Sub txtDPC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDPC.TextChanged
        txtClosingAmout.Text = AmountPay - Val(txtDPC.Text)
    End Sub
End Class
