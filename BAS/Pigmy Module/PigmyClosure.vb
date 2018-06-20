Imports System.Math
Public Class frmPigmyClosure
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NumericControl6 As BankControls.NumericControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnPGTransaction As BankControls.NewButton
    Friend WithEvents btnPGWithDraw As BankControls.NewButton
    Friend WithEvents btnPGCreation As BankControls.NewButton
    Friend WithEvents txtMaturityAmount As BankControls.NumericControl
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents txtDD As BankControls.NumericControl
    Friend WithEvents txtMM As BankControls.NumericControl
    Friend WithEvents txtYY As BankControls.NumericControl
    Friend WithEvents dtpOpeningDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpClosingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtClosingBalance As BankControls.NumericControl
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents grpMaturity As System.Windows.Forms.GroupBox
    Friend WithEvents grpInteresetDet As System.Windows.Forms.GroupBox
    Friend WithEvents grpAccount As System.Windows.Forms.GroupBox
    Friend WithEvents grpAccountDet As System.Windows.Forms.GroupBox
    Friend WithEvents grpClosingDet As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIntAmount As BankControls.NumericControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAGNo As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAGName As BankControls.TextControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBNNC As BankControls.NumericControl
    Friend WithEvents txtBNND As BankControls.NumericControl
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPigmyClosure))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnPGTransaction = New BankControls.NewButton
        Me.btnPGWithDraw = New BankControls.NewButton
        Me.btnPGCreation = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.grpMaturity = New System.Windows.Forms.GroupBox
        Me.txtMaturityAmount = New BankControls.NumericControl
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.NumericControl6 = New BankControls.NumericControl
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.grpInteresetDet = New System.Windows.Forms.GroupBox
        Me.btnCalInterest = New BankControls.NewButton
        Me.txtROI = New BankControls.NumericControl
        Me.txtDD = New BankControls.NumericControl
        Me.txtMM = New BankControls.NumericControl
        Me.txtYY = New BankControls.NumericControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtIntAmount = New BankControls.NumericControl
        Me.grpAccount = New System.Windows.Forms.GroupBox
        Me.txtBNND = New BankControls.NumericControl
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtBNNC = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpOpeningDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.grpAccountDet = New System.Windows.Forms.GroupBox
        Me.btnSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAccountNo = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.grpClosingDet = New System.Windows.Forms.GroupBox
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtpClosingDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtClosingBalance = New BankControls.NumericControl
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbAGNo = New MTGCComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAGName = New BankControls.TextControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.grpMaturity.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpInteresetDet.SuspendLayout()
        Me.grpAccount.SuspendLayout()
        Me.grpAccountDet.SuspendLayout()
        Me.grpClosingDet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnPGTransaction)
        Me.Panel4.Controls.Add(Me.btnPGWithDraw)
        Me.Panel4.Controls.Add(Me.btnPGCreation)
        Me.Panel4.Location = New System.Drawing.Point(8, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 520)
        Me.Panel4.TabIndex = 1
        '
        'btnPGTransaction
        '
        Me.btnPGTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPGTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPGTransaction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPGTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnPGTransaction.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnPGTransaction.Image = CType(resources.GetObject("btnPGTransaction.Image"), System.Drawing.Image)
        Me.btnPGTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPGTransaction.Location = New System.Drawing.Point(16, 160)
        Me.btnPGTransaction.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnPGTransaction.Name = "btnPGTransaction"
        Me.btnPGTransaction.Size = New System.Drawing.Size(184, 40)
        Me.btnPGTransaction.TabIndex = 17
        Me.btnPGTransaction.Text = "Transaction Detail"
        Me.btnPGTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPGWithDraw
        '
        Me.btnPGWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPGWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPGWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPGWithDraw.ForeColor = System.Drawing.Color.Black
        Me.btnPGWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnPGWithDraw.Image = CType(resources.GetObject("btnPGWithDraw.Image"), System.Drawing.Image)
        Me.btnPGWithDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPGWithDraw.Location = New System.Drawing.Point(16, 232)
        Me.btnPGWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnPGWithDraw.Name = "btnPGWithDraw"
        Me.btnPGWithDraw.Size = New System.Drawing.Size(184, 40)
        Me.btnPGWithDraw.TabIndex = 18
        Me.btnPGWithDraw.Text = "PreClosure"
        Me.btnPGWithDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPGCreation
        '
        Me.btnPGCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPGCreation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPGCreation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPGCreation.ForeColor = System.Drawing.Color.Black
        Me.btnPGCreation.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnPGCreation.Image = CType(resources.GetObject("btnPGCreation.Image"), System.Drawing.Image)
        Me.btnPGCreation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPGCreation.Location = New System.Drawing.Point(16, 312)
        Me.btnPGCreation.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnPGCreation.Name = "btnPGCreation"
        Me.btnPGCreation.Size = New System.Drawing.Size(184, 40)
        Me.btnPGCreation.TabIndex = 19
        Me.btnPGCreation.Text = "    New Pigmy Creation"
        Me.btnPGCreation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(680, 480)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 40)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "&Account &Close"
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(816, 480)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 40)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        '
        'grpMaturity
        '
        Me.grpMaturity.Controls.Add(Me.txtMaturityAmount)
        Me.grpMaturity.Controls.Add(Me.GroupBox4)
        Me.grpMaturity.Controls.Add(Me.NumericControl6)
        Me.grpMaturity.Controls.Add(Me.dtpMaturityDate)
        Me.grpMaturity.Controls.Add(Me.Label12)
        Me.grpMaturity.Controls.Add(Me.Label13)
        Me.grpMaturity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMaturity.Location = New System.Drawing.Point(768, 160)
        Me.grpMaturity.Name = "grpMaturity"
        Me.grpMaturity.Size = New System.Drawing.Size(200, 168)
        Me.grpMaturity.TabIndex = 17
        Me.grpMaturity.TabStop = False
        Me.grpMaturity.Text = "Maturity Details"
        '
        'txtMaturityAmount
        '
        Me.txtMaturityAmount.AfterDecimal = 0
        Me.txtMaturityAmount.BackColor = System.Drawing.Color.White
        Me.txtMaturityAmount.BeforeDecimal = 12
        Me.txtMaturityAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaturityAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMaturityAmount.Location = New System.Drawing.Point(72, 88)
        Me.txtMaturityAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMaturityAmount.MaxValue = 0
        Me.txtMaturityAmount.MinValue = 0
        Me.txtMaturityAmount.Name = "txtMaturityAmount"
        Me.txtMaturityAmount.Size = New System.Drawing.Size(128, 23)
        Me.txtMaturityAmount.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(236, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 168)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Maturity Details"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd / MMM / yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(72, 48)
        Me.DateTimePicker2.MaxDate = New Date(2006, 11, 16, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(128, 22)
        Me.DateTimePicker2.TabIndex = 12
        Me.DateTimePicker2.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 15)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Date:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 15)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Amount"
        '
        'NumericControl6
        '
        Me.NumericControl6.AfterDecimal = 0
        Me.NumericControl6.BeforeDecimal = 12
        Me.NumericControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericControl6.GotFocusColour = System.Drawing.SystemColors.Info
        Me.NumericControl6.Location = New System.Drawing.Point(-236, 8)
        Me.NumericControl6.LostFocusColour = System.Drawing.Color.Empty
        Me.NumericControl6.MaxValue = 0
        Me.NumericControl6.MinValue = 0
        Me.NumericControl6.Name = "NumericControl6"
        Me.NumericControl6.Size = New System.Drawing.Size(142, 22)
        Me.NumericControl6.TabIndex = 26
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpMaturityDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpMaturityDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(72, 48)
        Me.dtpMaturityDate.MaxDate = New Date(9998, 11, 11, 0, 0, 0, 0)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpMaturityDate.TabIndex = 13
        Me.dtpMaturityDate.Value = New Date(2007, 8, 11, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Amount"
        '
        'grpInteresetDet
        '
        Me.grpInteresetDet.Controls.Add(Me.btnCalInterest)
        Me.grpInteresetDet.Controls.Add(Me.txtROI)
        Me.grpInteresetDet.Controls.Add(Me.txtDD)
        Me.grpInteresetDet.Controls.Add(Me.txtMM)
        Me.grpInteresetDet.Controls.Add(Me.txtYY)
        Me.grpInteresetDet.Controls.Add(Me.Label7)
        Me.grpInteresetDet.Controls.Add(Me.Label6)
        Me.grpInteresetDet.Controls.Add(Me.Label8)
        Me.grpInteresetDet.Controls.Add(Me.Label9)
        Me.grpInteresetDet.Controls.Add(Me.Label10)
        Me.grpInteresetDet.Controls.Add(Me.Label11)
        Me.grpInteresetDet.Controls.Add(Me.txtIntAmount)
        Me.grpInteresetDet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInteresetDet.Location = New System.Drawing.Point(496, 160)
        Me.grpInteresetDet.Name = "grpInteresetDet"
        Me.grpInteresetDet.Size = New System.Drawing.Size(264, 168)
        Me.grpInteresetDet.TabIndex = 16
        Me.grpInteresetDet.TabStop = False
        Me.grpInteresetDet.Text = "Interest Details"
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(224, 48)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(32, 32)
        Me.btnCalInterest.TabIndex = 10
        Me.btnCalInterest.Text = "Int"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 0
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 12
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(112, 80)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(112, 23)
        Me.txtROI.TabIndex = 11
        '
        'txtDD
        '
        Me.txtDD.AfterDecimal = 0
        Me.txtDD.BackColor = System.Drawing.Color.White
        Me.txtDD.BeforeDecimal = 12
        Me.txtDD.Enabled = False
        Me.txtDD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDD.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDD.Location = New System.Drawing.Point(192, 48)
        Me.txtDD.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDD.MaxValue = 0
        Me.txtDD.MinValue = 0
        Me.txtDD.Name = "txtDD"
        Me.txtDD.Size = New System.Drawing.Size(28, 23)
        Me.txtDD.TabIndex = 9
        '
        'txtMM
        '
        Me.txtMM.AfterDecimal = 0
        Me.txtMM.BackColor = System.Drawing.Color.White
        Me.txtMM.BeforeDecimal = 12
        Me.txtMM.Enabled = False
        Me.txtMM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMM.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMM.Location = New System.Drawing.Point(152, 48)
        Me.txtMM.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMM.MaxValue = 0
        Me.txtMM.MinValue = 0
        Me.txtMM.Name = "txtMM"
        Me.txtMM.Size = New System.Drawing.Size(28, 23)
        Me.txtMM.TabIndex = 8
        '
        'txtYY
        '
        Me.txtYY.AfterDecimal = 0
        Me.txtYY.BackColor = System.Drawing.Color.White
        Me.txtYY.BeforeDecimal = 12
        Me.txtYY.Enabled = False
        Me.txtYY.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYY.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtYY.Location = New System.Drawing.Point(112, 48)
        Me.txtYY.LostFocusColour = System.Drawing.Color.Empty
        Me.txtYY.MaxValue = 0
        Me.txtYY.MinValue = 0
        Me.txtYY.Name = "txtYY"
        Me.txtYY.Size = New System.Drawing.Size(28, 23)
        Me.txtYY.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "YY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Period:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(152, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "MM"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "ROI:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Int Amount:"
        '
        'txtIntAmount
        '
        Me.txtIntAmount.AfterDecimal = 0
        Me.txtIntAmount.BackColor = System.Drawing.Color.White
        Me.txtIntAmount.BeforeDecimal = 12
        Me.txtIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntAmount.Location = New System.Drawing.Point(112, 112)
        Me.txtIntAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIntAmount.MaxValue = 0
        Me.txtIntAmount.MinValue = 0
        Me.txtIntAmount.Name = "txtIntAmount"
        Me.txtIntAmount.Size = New System.Drawing.Size(112, 23)
        Me.txtIntAmount.TabIndex = 12
        '
        'grpAccount
        '
        Me.grpAccount.Controls.Add(Me.txtBNND)
        Me.grpAccount.Controls.Add(Me.Label20)
        Me.grpAccount.Controls.Add(Me.txtBNNC)
        Me.grpAccount.Controls.Add(Me.Label5)
        Me.grpAccount.Controls.Add(Me.dtpOpeningDate)
        Me.grpAccount.Controls.Add(Me.Label3)
        Me.grpAccount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccount.Location = New System.Drawing.Point(232, 160)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Size = New System.Drawing.Size(256, 168)
        Me.grpAccount.TabIndex = 15
        Me.grpAccount.TabStop = False
        Me.grpAccount.Text = "Account Details"
        '
        'txtBNND
        '
        Me.txtBNND.AfterDecimal = 0
        Me.txtBNND.BackColor = System.Drawing.Color.White
        Me.txtBNND.BeforeDecimal = 12
        Me.txtBNND.Enabled = False
        Me.txtBNND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBNND.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBNND.Location = New System.Drawing.Point(132, 120)
        Me.txtBNND.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBNND.MaxValue = 0
        Me.txtBNND.MinValue = 0
        Me.txtBNND.Name = "txtBNND"
        Me.txtBNND.Size = New System.Drawing.Size(120, 23)
        Me.txtBNND.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 123)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 16)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Pigmy Deposit:"
        '
        'txtBNNC
        '
        Me.txtBNNC.AfterDecimal = 0
        Me.txtBNNC.BackColor = System.Drawing.Color.White
        Me.txtBNNC.BeforeDecimal = 12
        Me.txtBNNC.Enabled = False
        Me.txtBNNC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBNNC.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBNNC.Location = New System.Drawing.Point(131, 85)
        Me.txtBNNC.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBNNC.MaxValue = 0
        Me.txtBNNC.MinValue = 0
        Me.txtBNNC.Name = "txtBNNC"
        Me.txtBNNC.Size = New System.Drawing.Size(120, 23)
        Me.txtBNNC.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Pigmy Collection:"
        '
        'dtpOpeningDate
        '
        Me.dtpOpeningDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpOpeningDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpOpeningDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpOpeningDate.Enabled = False
        Me.dtpOpeningDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOpeningDate.Location = New System.Drawing.Point(114, 48)
        Me.dtpOpeningDate.MaxDate = New Date(9998, 11, 11, 0, 0, 0, 0)
        Me.dtpOpeningDate.Name = "dtpOpeningDate"
        Me.dtpOpeningDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpOpeningDate.TabIndex = 4
        Me.dtpOpeningDate.Value = New Date(2007, 8, 11, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Opening Date:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(232, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(201, 23)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "BNN Account Closure:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAccountDet
        '
        Me.grpAccountDet.Controls.Add(Me.btnSearch)
        Me.grpAccountDet.Controls.Add(Me.Label1)
        Me.grpAccountDet.Controls.Add(Me.txtAccountNo)
        Me.grpAccountDet.Controls.Add(Me.Label2)
        Me.grpAccountDet.Controls.Add(Me.txtName)
        Me.grpAccountDet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccountDet.Location = New System.Drawing.Point(232, 72)
        Me.grpAccountDet.Name = "grpAccountDet"
        Me.grpAccountDet.Size = New System.Drawing.Size(728, 72)
        Me.grpAccountDet.TabIndex = 20
        Me.grpAccountDet.TabStop = False
        Me.grpAccountDet.Text = "Account Details"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(264, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Account No. :"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = True
        Me.txtAccountNo.BackColor = System.Drawing.Color.White
        Me.txtAccountNo.BlankSpace = False
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccountNo.Location = New System.Drawing.Point(120, 32)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.MaxLength = 8
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 1
        Me.txtAccountNo.Text = "BNN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(416, 32)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(272, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 3
        Me.txtName.TabStop = False
        '
        'grpClosingDet
        '
        Me.grpClosingDet.Controls.Add(Me.txtReceiptNo)
        Me.grpClosingDet.Controls.Add(Me.Label17)
        Me.grpClosingDet.Controls.Add(Me.dtpClosingDate)
        Me.grpClosingDet.Controls.Add(Me.Label4)
        Me.grpClosingDet.Controls.Add(Me.txtClosingBalance)
        Me.grpClosingDet.Controls.Add(Me.Label16)
        Me.grpClosingDet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpClosingDet.Location = New System.Drawing.Point(232, 400)
        Me.grpClosingDet.Name = "grpClosingDet"
        Me.grpClosingDet.Size = New System.Drawing.Size(736, 72)
        Me.grpClosingDet.TabIndex = 21
        Me.grpClosingDet.TabStop = False
        Me.grpClosingDet.Text = "Closing Details"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 2
        Me.txtReceiptNo.BackColor = System.Drawing.Color.White
        Me.txtReceiptNo.BeforeDecimal = 8
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.Color.Beige
        Me.txtReceiptNo.Location = New System.Drawing.Point(320, 32)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.White
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(240, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 16)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "Receipt No:"
        '
        'dtpClosingDate
        '
        Me.dtpClosingDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpClosingDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClosingDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosingDate.Location = New System.Drawing.Point(104, 32)
        Me.dtpClosingDate.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpClosingDate.Name = "dtpClosingDate"
        Me.dtpClosingDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpClosingDate.TabIndex = 17
        Me.dtpClosingDate.Value = New Date(2010, 10, 9, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Closing Date:"
        '
        'txtClosingBalance
        '
        Me.txtClosingBalance.AfterDecimal = 0
        Me.txtClosingBalance.BackColor = System.Drawing.Color.White
        Me.txtClosingBalance.BeforeDecimal = 12
        Me.txtClosingBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClosingBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtClosingBalance.Location = New System.Drawing.Point(576, 32)
        Me.txtClosingBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtClosingBalance.MaxValue = 0
        Me.txtClosingBalance.MinValue = 0
        Me.txtClosingBalance.Name = "txtClosingBalance"
        Me.txtClosingBalance.Size = New System.Drawing.Size(152, 23)
        Me.txtClosingBalance.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(464, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 16)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Closing Balance:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbAGNo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtAGName)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(320, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 53)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agent Details"
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
        Me.cmbAGNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAGNo.GridLineColor = System.Drawing.Color.LightGray
        Me.cmbAGNo.GridLineHorizontal = False
        Me.cmbAGNo.GridLineVertical = False
        Me.cmbAGNo.HighlightBorderColor = System.Drawing.Color.Blue
        Me.cmbAGNo.HighlightBorderOnMouseEvents = True
        Me.cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cmbAGNo.Location = New System.Drawing.Point(112, 24)
        Me.cmbAGNo.ManagingFastMouseMoving = True
        Me.cmbAGNo.ManagingFastMouseMovingInterval = 30
        Me.cmbAGNo.Name = "cmbAGNo"
        Me.cmbAGNo.NormalBorderColor = System.Drawing.Color.Black
        Me.cmbAGNo.Size = New System.Drawing.Size(160, 24)
        Me.cmbAGNo.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(280, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Agent Name"
        '
        'txtAGName
        '
        Me.txtAGName.AlphaNumeric = False
        Me.txtAGName.BlankSpace = False
        Me.txtAGName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAGName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAGName.Location = New System.Drawing.Point(376, 24)
        Me.txtAGName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAGName.Mandatory = False
        Me.txtAGName.Name = "txtAGName"
        Me.txtAGName.Size = New System.Drawing.Size(160, 23)
        Me.txtAGName.SpecialChar = False
        Me.txtAGName.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 16)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Agent No"
        '
        'frmPigmyClosure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(978, 535)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpClosingDet)
        Me.Controls.Add(Me.grpAccountDet)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.grpMaturity)
        Me.Controls.Add(Me.grpInteresetDet)
        Me.Controls.Add(Me.grpAccount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPigmyClosure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BNN Closure"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.grpMaturity.ResumeLayout(False)
        Me.grpMaturity.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpInteresetDet.ResumeLayout(False)
        Me.grpInteresetDet.PerformLayout()
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        Me.grpAccountDet.ResumeLayout(False)
        Me.grpAccountDet.PerformLayout()
        Me.grpClosingDet.ResumeLayout(False)
        Me.grpClosingDet.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Code For Single Instance"

    Private Shared m_FormInstance As frmPigmyClosure
    Private Shared m_InitializeDefInstance As Boolean

    Public Shared Property DefInstance() As frmPigmyClosure
        Get
            If m_FormInstance Is Nothing OrElse m_FormInstance.IsDisposed Then
                m_InitializeDefInstance = True
                m_FormInstance = New frmPigmyClosure

                m_InitializeDefInstance = False
            End If
            DefInstance = m_FormInstance
        End Get
        Set(ByVal Value As frmPigmyClosure)
            m_FormInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"

    Dim objclsPGAccount As New clsPigmyAccount
    Dim objPGTransaction As New frmPigmyTransaction
    Dim objPGWithDrawl As New frmPigmyWithDraw
    Dim objPGCreation As New frmPigmyAccCreation

    Dim intDateDiff As Integer
    Dim intDateDiff1 As Integer

#End Region

#Region "Function"

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

    Public Function fnGetPigmyAccDet() As Boolean

        If objclsPGAccount.fnGetPGAccountDetails(txtAccountNo.Text) Then

            dtpOpeningDate.Value = Format(objclsPGAccount.PGAccTable.Rows(0).Item("AccDate"), "yyyy-MM-dd")
            txtBNNC.Text = objclsPGAccount.PGAccTable.Rows(0).Item("AvailCollection")
            txtBNND.Text = objclsPGAccount.PGAccTable.Rows(0).Item("AvailDeposit")
            txtYY.Text = objclsPGAccount.PGAccTable.Rows(0).Item("Years")
            txtMM.Text = objclsPGAccount.PGAccTable.Rows(0).Item("Months")
            txtDD.Text = objclsPGAccount.PGAccTable.Rows(0).Item("Days")
            txtROI.Text = objclsPGAccount.PGAccTable.Rows(0).Item("ROI")
            'txtAmount.Text = 0
            dtpMaturityDate.Value = Format(objclsPGAccount.PGAccTable.Rows(0).Item("MaturityDate"), "yyyy-MM-dd")
            'txtClosingBalance.Text = objclsPGAccount.PGAccTable.Rows(0).Item("Balance")
            cmbAGNo.Text = objclsPGAccount.PGAccTable.Rows(0).Item("AgentNo")
        End If

    End Function

    Public Function fnCalInterest() As Boolean

        If objclsPGAccount.fnCheckPGAccount(txtAccountNo.Text) Then
            intDateDiff = DateDiff(DateInterval.DayOfYear, objclsPGAccount.PGAccTable.Rows(0).Item("AccDate"), Date.Today) / 30
            intDateDiff1 = DateDiff(DateInterval.DayOfYear, objclsPGAccount.PGAccTable.Rows(0).Item("AccDate"), dtpMaturityDate.Value) '/ 30
            If fnCheckPeriod() Then
                If fnPostInterest() Then
                End If
            End If
        End If

    End Function
    Public Function fnPostInterest() As Boolean
        Dim intCounter As Integer = 0
        Dim dblBalance As Double = 0
        Dim dblClosingBalance As Double = 0
        Dim dblROI As Double
        Dim dblInterestAmount As Double
        Dim dblTotalInt As Double = 0
        Dim objDt As DataTable
        Dim intNoOfRows As Integer

        intNoOfRows = objclsPGAccount.GetClosingBalance.Rows.Count
        ' dblClosingBalance = Convert.ToDouble(objclsPGAccount.GetClosingBalance.Rows(intNoOfRows - 1).Item("DDeposit"))
        objDt = objclsPGAccount.GetClosingBalance

        While intCounter < objclsPGAccount.GetClosingBalance.Rows.Count - 1
            dblClosingBalance += Convert.ToDouble(objclsPGAccount.GetClosingBalance.Rows(intCounter).Item("MonthEndBal"))
            intCounter += 1
        End While




        dblROI = objclsPGAccount.PGAccTable.Rows(0).Item("ROI")

        dblBalance = objclsPGAccount.PGAccTable.Rows(0).Item("AvailDeposit")
        'dblBalance = dblBalance - dblClosingBalance
        ''dblInterestAmount = Math.Round((dblBalance * intDateDiff1 * dblROI) / (365 * 100), 2)
        dblInterestAmount = Math.Round((dblClosingBalance * 30 * dblROI) / (365 * 100), 2)
        txtIntAmount.Text = Math.Round(dblInterestAmount)
        txtMaturityAmount.Text = Math.Round(Val(txtBNND.Text) + Val(txtIntAmount.Text))
        txtClosingBalance.Text = Math.Round(Val(txtMaturityAmount.Text))

        'If objclsPGAccount.fnGetTransaction(txtAccountNo.Text) Then
        '    Dim intCount As Integer = 0
        '    objDt = objclsPGAccount.PigmyDepTransTable
        '    While intCount < objDt.Rows.Count
        '        dblBalance += objDt.Rows(intCount).Item("Amount")
        '        dblInterestAmount = Math.Round((dblBalance * 1 * dblROI) / (12 * 100), 2)
        '        dblTotalInt += dblInterestAmount
        '        intCount += 1
        '    End While
        '    txtIntAmount.Text = Round(dblTotalInt)
        '    txtMaturityAmount.Text = Val(txtBalance.Text) + Val(txtIntAmount.Text)
        '    txtClosingBalance.Text = Val(txtMaturityAmount.Text)
        'End If

        Return True

    End Function

    Public Function fnCheckPeriod() As Boolean

        If objclsPGAccount.fnGetMinPeriod Then
            If intDateDiff < objclsPGAccount.MinPeriodtable.Rows(0).Item("MinPeriod") Then
                MsgBox("Sorry,minimum period is not compleated ," & Chr(13) & " It can be preclosed ", MsgBoxStyle.Exclamation, "BNN Module")
                Return False
            ElseIf intDateDiff <= 12 Then
                MsgBox("Sorry,BNN period is not compleated 12 months," & Chr(13) & " It can be preclosed ", MsgBoxStyle.Exclamation, "BNN Module")
                Return False
            Else
                MsgBox("Interest can be posted for this account", MsgBoxStyle.Exclamation, "BNN Module")
                Return True
            End If
        End If

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpClosingDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Account closure by  " & txtAccountNo.Text & ""

        'objclsPGAccount.fnWithDrawlData(lngVoucherNo, strNarration) 'To insert into RD Transaction table
        objclsPGAccount.frnPGDepositWithdraw(Trim(txtAccountNo.Text), dtpClosingDate.Value, "Account closed by   " & txtAccountNo.Text, 0, Trim(txtBNND.Text), Trim(txtBNND.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0, cmbAGNo.SelectedItem.col1, objTrans)

        objclsPGAccount.fnUpdateStatus(txtAccountNo.Text, lngVoucherNo, objTrans) 'Query to close RD Account

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccountNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, txtMaturityAmount.Text, "Account closure by  " & txtAccountNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpClosingDate.Value, "Account closure by  " & txtAccountNo.Text, "To", 1, 0, Val(txtMaturityAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        '''First one for the ledger no 123 i.e BNN Ledger
        '''Second is for the legere no 31 i.e Interest on BNN Ledger
        fnVoucherEnterSub(lngVoucherNo, 1, txtAccountNo.Text, dtpClosingDate.Value, "Account closure by " & txtAccountNo.Text, "By", 123, Val(txtBNND.Text), 0, 2, "Y", objTrans)
        fnVoucherEnterSub(lngVoucherNo, 1, txtAccountNo.Text, dtpClosingDate.Value, "Account closure by  " & txtAccountNo.Text, "By", 31, Val(txtIntAmount.Text), 0, 3, "Y", objTrans)

        Return True

    End Function

    Public Function fnSetData() As Boolean

        objclsPGAccount.Amount = txtBNND.Text
        objclsPGAccount.Reference = txtReceiptNo.Text
        objclsPGAccount.TransDate = dtpClosingDate.Value
        objclsPGAccount.PGNo = txtAccountNo.Text
        objclsPGAccount.MatAmount = txtMaturityAmount.Text
        objclsPGAccount.intAmount = txtIntAmount.Text
        objclsPGAccount.AgnetNo = cmbAGNo.SelectedItem.col1
        Return True

    End Function

    Public Function fnCheckDate() As Boolean
        Dim intDate As Integer
        intDate = DateDiff(DateInterval.DayOfYear, Date.Today, dtpMaturityDate.Value)
        'If intDate > 0 Then
        '    MsgBox("Account Cannot Be Closed,You have to Premature the Account", MsgBoxStyle.Exclamation, "BNN Module")
        '    Return False
        'Else
        If txtMaturityAmount.Text = String.Empty Then
            MsgBox("Maturity amount cannot be empty  " & Chr(13) & " ,Run Interest calculaton ")
            btnCalInterest.Focus()
            Return False
        ElseIf txtBNNC.Text <> 0 Then
            MsgBox("Please transfer BNNC to BNND", MsgBoxStyle.Information)
            txtBNNC.Focus()
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Enter receiptno ")
            txtReceiptNo.Focus()
            Return False
        ElseIf txtAGName.Text = String.Empty Then
            MsgBox("Select agent ")
            cmbAGNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnBNNClouser()
        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If fnCheckDate() Then
                If fnSetData() Then
                    If fnGenerateVoucher(objTrans) Then
                        fnLogEntry(pbUserId, "WithDraw BY " & txtAccountNo.Text & " Amount " & txtMaturityAmount.Text, Date.Now, "Transaction withdraw", objTrans)
                        objTrans.Commit()
                        MsgBox("Account closed successfully", MsgBoxStyle.Information, "BNN Module")
                    Else
                        MsgBox("Account cannot be closed due to internal error ", MsgBoxStyle.Critical, "BNN Module")
                    End If
                Else
                    MsgBox("Account cannot be closed due to internal error ", MsgBoxStyle.Critical, "BNN Module")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try



    End Function

#End Region

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmPigmyCust As New frmPGCust
        objfrmPigmyCust.ShowDialog()
        txtAccountNo.Text = objfrmPigmyCust.strPGNo
        txtName.Text = objfrmPigmyCust.strPGName
        fnGetPigmyAccDet()

    End Sub

    Private Sub frmPigmyClosure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpClosingDate.Value = Date.Now
        dtpMaturityDate.Value = Date.Now
        dtpOpeningDate.Value = Date.Now

        GroupBox2.Enabled = False
        fnGetPigmyAccDet()
        sbGetAgents()
        dtpClosingDate.Value = Date.Now
    End Sub

    Private Sub cmbAGNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAGNo.SelectedIndexChanged

        txtAGName.Text = cmbAGNo.SelectedItem.col2

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If MsgBox("Are you sure, you want to close this account", MsgBoxStyle.YesNo, "BNN Details") = MsgBoxResult.Yes Then
                If objclsPGAccount.fnCheckPGAccount(txtAccountNo.Text) Then
                    fnBNNClouser()
                Else
                    MsgBox("Please check the account no, account no doesnot exist or it had already closed", MsgBoxStyle.Exclamation, "BNN Module")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub


    Private Sub btnPGTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPGTransaction.Click

        objPGTransaction.strAccNo = txtAccountNo.Text
        objPGTransaction.strName = txtName.Text
        objPGTransaction.ShowDialog()

    End Sub

    Private Sub btnPGWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPGWithDraw.Click

        Dim objPigmyWithDrawl As New frmPigmyPreMature
        objPigmyWithDrawl.strAccNo = txtAccountNo.Text
        objPigmyWithDrawl.strName = txtName.Text
        objPigmyWithDrawl.ShowDialog(Me)

    End Sub

    Private Sub btnPGCreation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPGCreation.Click

        Dim objfrmPGCreation As frmPigmyAccCreation
        objfrmPGCreation = frmPigmyAccCreation.DefInstance
        objfrmPGCreation.Show()
        objfrmPGCreation = Nothing

    End Sub

    Private Sub txtAccountNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountNo.TextChanged

        If txtAccountNo.Text.StartsWith("BNN") = False Then
            txtAccountNo.Undo()
            txtAccountNo.ClearUndo()
        End If

    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        If Val(txtBNNC.Text) = 0 Then
            fnCalInterest()
        Else
            MsgBox("Please transfer BNNC amount to BNND ", MsgBoxStyle.Information)
            txtBNNC.Focus()
        End If
    End Sub
End Class
