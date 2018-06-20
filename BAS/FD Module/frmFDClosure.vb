
Public Class frmFDClosure
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim lngPersonNo As Long = 0
    Dim objFDAccount As New clsFDAccount
    Dim dtInterest As New DataTable
    Dim objDT As DataTable
    Dim dblReminingIntrest As Double = 0
    Dim objIntTable As DataTable
    Dim intLedgerNo As Integer
    Dim intLedIntNo As Integer

    Dim dblProvisionInterest As Double
    Dim dblPaidInterest As Double
    Dim dblDueInterest As Double

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFDAccountNo As BankControls.TextControl
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grpFDDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    Friend WithEvents dtpFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDDays As BankControls.NumericControl
    Friend WithEvents txtFDMonths As BankControls.NumericControl
    Friend WithEvents txtFDYears As BankControls.NumericControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtFDROI As BankControls.NumericControl
    Friend WithEvents txtFDIntAmount As BankControls.NumericControl
    Friend WithEvents dtpFDMatDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDMatAmount As BankControls.NumericControl
    Friend WithEvents btnFDDetails As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Coll_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIntPaid As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnIntPayment As BankControls.NewButton
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents dtpClosingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents chkFundTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents txtSBNo As BankControls.TextControl
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents lblCInterest As System.Windows.Forms.Label
    Friend WithEvents txtCInterest As BankControls.NumericControl
    Friend WithEvents chkCorrection As System.Windows.Forms.CheckBox
    Friend WithEvents Correction As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorrectionAmount As BankControls.NumericControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents chkSubtract As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdd As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDClosure))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnFDDetails = New BankControls.NewButton
        Me.btnIntPayment = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAdd = New BankControls.NewButton
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Coll_Date = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpClosingDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.grpFDDetails = New System.Windows.Forms.GroupBox
        Me.chkCorrection = New System.Windows.Forms.CheckBox
        Me.Correction = New System.Windows.Forms.GroupBox
        Me.txtCorrectionAmount = New BankControls.NumericControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.chkSubtract = New System.Windows.Forms.CheckBox
        Me.chkAdd = New System.Windows.Forms.CheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.lblCInterest = New System.Windows.Forms.Label
        Me.txtCInterest = New BankControls.NumericControl
        Me.txtFDAmount = New BankControls.NumericControl
        Me.dtpFDDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDDays = New BankControls.NumericControl
        Me.txtFDMonths = New BankControls.NumericControl
        Me.txtFDYears = New BankControls.NumericControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtFDROI = New BankControls.NumericControl
        Me.txtFDIntAmount = New BankControls.NumericControl
        Me.dtpFDMatDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDMatAmount = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIntPaid = New BankControls.NumericControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkFundTransfer = New System.Windows.Forms.CheckBox
        Me.txtSBNo = New BankControls.TextControl
        Me.Label42 = New System.Windows.Forms.Label
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFDAccountNo = New BankControls.TextControl
        Me.btnSearchFD = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.btnCancel = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.Label32 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpFDDetails.SuspendLayout()
        Me.Correction.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFDDetails)
        Me.GroupBox1.Controls.Add(Me.btnIntPayment)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnFDDetails
        '
        Me.btnFDDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFDDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFDDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFDDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFDDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFDDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnFDDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFDDetails.Location = New System.Drawing.Point(16, 280)
        Me.btnFDDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFDDetails.Name = "btnFDDetails"
        Me.btnFDDetails.Size = New System.Drawing.Size(160, 40)
        Me.btnFDDetails.TabIndex = 21
        Me.btnFDDetails.Text = "Deposit &Details"
        Me.btnFDDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFDDetails.UseVisualStyleBackColor = False
        '
        'btnIntPayment
        '
        Me.btnIntPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnIntPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntPayment.ForeColor = System.Drawing.Color.Black
        Me.btnIntPayment.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnIntPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntPayment.Location = New System.Drawing.Point(16, 320)
        Me.btnIntPayment.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnIntPayment.Name = "btnIntPayment"
        Me.btnIntPayment.Size = New System.Drawing.Size(160, 40)
        Me.btnIntPayment.TabIndex = 22
        Me.btnIntPayment.Text = "&Int. Payments"
        Me.btnIntPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIntPayment.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.lvInterest)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.grpFDDetails)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(16, 568)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lvInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Int_Amt, Me.Int_Date, Me.Coll_Date, Me.Status})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.HideSelection = False
        Me.lvInterest.Location = New System.Drawing.Point(8, 328)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(752, 176)
        Me.lvInterest.TabIndex = 16
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 80
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Int_Amt.Width = 151
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Int_Date.Width = 175
        '
        'Coll_Date
        '
        Me.Coll_Date.Text = "Collection Date"
        Me.Coll_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Coll_Date.Width = 160
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 135
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtReceiptNo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtpClosingDate)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtAmount)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(752, 56)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Closing Details"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(112, 22)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 14
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Receipt No. :"
        '
        'dtpClosingDate
        '
        Me.dtpClosingDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClosingDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosingDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpClosingDate.MaxDate = New Date(2500, 12, 2, 0, 0, 0, 0)
        Me.dtpClosingDate.Name = "dtpClosingDate"
        Me.dtpClosingDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpClosingDate.TabIndex = 15
        Me.dtpClosingDate.Value = New Date(2008, 11, 27, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(248, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Closing Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(496, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Amt To Be Paid :"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtAmount.BeforeDecimal = 8
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(616, 22)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtAmount.TabIndex = 16
        Me.txtAmount.TabStop = False
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpFDDetails
        '
        Me.grpFDDetails.Controls.Add(Me.chkCorrection)
        Me.grpFDDetails.Controls.Add(Me.Correction)
        Me.grpFDDetails.Controls.Add(Me.lblCInterest)
        Me.grpFDDetails.Controls.Add(Me.txtCInterest)
        Me.grpFDDetails.Controls.Add(Me.txtFDAmount)
        Me.grpFDDetails.Controls.Add(Me.dtpFDDate)
        Me.grpFDDetails.Controls.Add(Me.txtFDDays)
        Me.grpFDDetails.Controls.Add(Me.txtFDMonths)
        Me.grpFDDetails.Controls.Add(Me.txtFDYears)
        Me.grpFDDetails.Controls.Add(Me.Label38)
        Me.grpFDDetails.Controls.Add(Me.Label11)
        Me.grpFDDetails.Controls.Add(Me.Label16)
        Me.grpFDDetails.Controls.Add(Me.Label17)
        Me.grpFDDetails.Controls.Add(Me.Label19)
        Me.grpFDDetails.Controls.Add(Me.Label20)
        Me.grpFDDetails.Controls.Add(Me.Label21)
        Me.grpFDDetails.Controls.Add(Me.Label22)
        Me.grpFDDetails.Controls.Add(Me.Label23)
        Me.grpFDDetails.Controls.Add(Me.Label24)
        Me.grpFDDetails.Controls.Add(Me.txtFDROI)
        Me.grpFDDetails.Controls.Add(Me.txtFDIntAmount)
        Me.grpFDDetails.Controls.Add(Me.dtpFDMatDate)
        Me.grpFDDetails.Controls.Add(Me.txtFDMatAmount)
        Me.grpFDDetails.Controls.Add(Me.Label3)
        Me.grpFDDetails.Controls.Add(Me.txtIntPaid)
        Me.grpFDDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFDDetails.ForeColor = System.Drawing.Color.Black
        Me.grpFDDetails.Location = New System.Drawing.Point(8, 136)
        Me.grpFDDetails.Name = "grpFDDetails"
        Me.grpFDDetails.Size = New System.Drawing.Size(752, 184)
        Me.grpFDDetails.TabIndex = 7
        Me.grpFDDetails.TabStop = False
        Me.grpFDDetails.Text = "Deposit Details"
        '
        'chkCorrection
        '
        Me.chkCorrection.Enabled = False
        Me.chkCorrection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorrection.Location = New System.Drawing.Point(120, 104)
        Me.chkCorrection.Name = "chkCorrection"
        Me.chkCorrection.Size = New System.Drawing.Size(96, 16)
        Me.chkCorrection.TabIndex = 8
        Me.chkCorrection.Text = "Correction"
        '
        'Correction
        '
        Me.Correction.Controls.Add(Me.txtCorrectionAmount)
        Me.Correction.Controls.Add(Me.Panel6)
        Me.Correction.Controls.Add(Me.Label35)
        Me.Correction.Enabled = False
        Me.Correction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correction.Location = New System.Drawing.Point(120, 104)
        Me.Correction.Name = "Correction"
        Me.Correction.Size = New System.Drawing.Size(304, 64)
        Me.Correction.TabIndex = 9
        Me.Correction.TabStop = False
        '
        'txtCorrectionAmount
        '
        Me.txtCorrectionAmount.AfterDecimal = 2
        Me.txtCorrectionAmount.BeforeDecimal = 10
        Me.txtCorrectionAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectionAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCorrectionAmount.Location = New System.Drawing.Point(176, 32)
        Me.txtCorrectionAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCorrectionAmount.MaxValue = 0
        Me.txtCorrectionAmount.MinValue = 0
        Me.txtCorrectionAmount.Name = "txtCorrectionAmount"
        Me.txtCorrectionAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtCorrectionAmount.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel6.Controls.Add(Me.chkSubtract)
        Me.Panel6.Controls.Add(Me.chkAdd)
        Me.Panel6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(8, 27)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(160, 32)
        Me.Panel6.TabIndex = 9
        '
        'chkSubtract
        '
        Me.chkSubtract.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubtract.Location = New System.Drawing.Point(64, 8)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(88, 16)
        Me.chkSubtract.TabIndex = 11
        Me.chkSubtract.Text = "Subtract"
        '
        'chkAdd
        '
        Me.chkAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdd.Location = New System.Drawing.Point(8, 8)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(56, 16)
        Me.chkAdd.TabIndex = 10
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
        'lblCInterest
        '
        Me.lblCInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblCInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCInterest.ForeColor = System.Drawing.Color.Black
        Me.lblCInterest.Location = New System.Drawing.Point(472, 94)
        Me.lblCInterest.Name = "lblCInterest"
        Me.lblCInterest.Size = New System.Drawing.Size(112, 16)
        Me.lblCInterest.TabIndex = 142
        Me.lblCInterest.Text = "Corrected Int :"
        Me.lblCInterest.Visible = False
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
        Me.txtCInterest.Location = New System.Drawing.Point(584, 91)
        Me.txtCInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCInterest.MaxLength = 10
        Me.txtCInterest.MaxValue = 0
        Me.txtCInterest.MinValue = 0
        Me.txtCInterest.Name = "txtCInterest"
        Me.txtCInterest.ReadOnly = True
        Me.txtCInterest.Size = New System.Drawing.Size(136, 23)
        Me.txtCInterest.TabIndex = 143
        Me.txtCInterest.TabStop = False
        Me.txtCInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCInterest.Visible = False
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAmount.Location = New System.Drawing.Point(120, 62)
        Me.txtFDAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAmount.MaxLength = 10
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.ReadOnly = True
        Me.txtFDAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDAmount.TabIndex = 11
        Me.txtFDAmount.TabStop = False
        Me.txtFDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFDDate
        '
        Me.dtpFDDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDDate.Enabled = False
        Me.dtpFDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(120, 30)
        Me.dtpFDDate.MaxDate = New Date(9998, 11, 22, 0, 0, 0, 0)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpFDDate.TabIndex = 6
        Me.dtpFDDate.TabStop = False
        Me.dtpFDDate.Value = New Date(2007, 10, 6, 0, 0, 0, 0)
        '
        'txtFDDays
        '
        Me.txtFDDays.AfterDecimal = 0
        Me.txtFDDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDDays.BeforeDecimal = 3
        Me.txtFDDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDDays.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDDays.Location = New System.Drawing.Point(408, 30)
        Me.txtFDDays.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDDays.MaxLength = 2
        Me.txtFDDays.MaxValue = 0
        Me.txtFDDays.MinValue = 0
        Me.txtFDDays.Name = "txtFDDays"
        Me.txtFDDays.ReadOnly = True
        Me.txtFDDays.Size = New System.Drawing.Size(48, 23)
        Me.txtFDDays.TabIndex = 9
        Me.txtFDDays.TabStop = False
        Me.txtFDDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDMonths
        '
        Me.txtFDMonths.AfterDecimal = 0
        Me.txtFDMonths.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMonths.BeforeDecimal = 2
        Me.txtFDMonths.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMonths.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMonths.Location = New System.Drawing.Point(368, 30)
        Me.txtFDMonths.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMonths.MaxLength = 2
        Me.txtFDMonths.MaxValue = 0
        Me.txtFDMonths.MinValue = 0
        Me.txtFDMonths.Name = "txtFDMonths"
        Me.txtFDMonths.ReadOnly = True
        Me.txtFDMonths.Size = New System.Drawing.Size(32, 23)
        Me.txtFDMonths.TabIndex = 8
        Me.txtFDMonths.TabStop = False
        Me.txtFDMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDYears
        '
        Me.txtFDYears.AfterDecimal = 0
        Me.txtFDYears.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDYears.BeforeDecimal = 2
        Me.txtFDYears.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDYears.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDYears.Location = New System.Drawing.Point(328, 30)
        Me.txtFDYears.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDYears.MaxLength = 1
        Me.txtFDYears.MaxValue = 0
        Me.txtFDYears.MinValue = 0
        Me.txtFDYears.Name = "txtFDYears"
        Me.txtFDYears.ReadOnly = True
        Me.txtFDYears.Size = New System.Drawing.Size(32, 23)
        Me.txtFDYears.TabIndex = 7
        Me.txtFDYears.TabStop = False
        Me.txtFDYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(472, 122)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 16)
        Me.Label38.TabIndex = 103
        Me.Label38.Text = "Maturity Amt :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(472, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Interest Amt :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(472, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Maturity Date :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(264, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 16)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "ROI :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(424, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 16)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "D"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(376, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 16)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "M"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(336, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 16)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "Y"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(264, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 16)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "Period :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(32, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 16)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Amount :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(32, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "FD Date :"
        '
        'txtFDROI
        '
        Me.txtFDROI.AfterDecimal = 2
        Me.txtFDROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDROI.BeforeDecimal = 8
        Me.txtFDROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDROI.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDROI.Location = New System.Drawing.Point(328, 62)
        Me.txtFDROI.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDROI.MaxLength = 10
        Me.txtFDROI.MaxValue = 0
        Me.txtFDROI.MinValue = 0
        Me.txtFDROI.Name = "txtFDROI"
        Me.txtFDROI.ReadOnly = True
        Me.txtFDROI.Size = New System.Drawing.Size(128, 23)
        Me.txtFDROI.TabIndex = 14
        Me.txtFDROI.TabStop = False
        Me.txtFDROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDIntAmount
        '
        Me.txtFDIntAmount.AfterDecimal = 2
        Me.txtFDIntAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDIntAmount.BeforeDecimal = 8
        Me.txtFDIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDIntAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDIntAmount.Location = New System.Drawing.Point(584, 60)
        Me.txtFDIntAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDIntAmount.MaxLength = 10
        Me.txtFDIntAmount.MaxValue = 0
        Me.txtFDIntAmount.MinValue = 0
        Me.txtFDIntAmount.Name = "txtFDIntAmount"
        Me.txtFDIntAmount.ReadOnly = True
        Me.txtFDIntAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDIntAmount.TabIndex = 12
        Me.txtFDIntAmount.TabStop = False
        Me.txtFDIntAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFDMatDate
        '
        Me.dtpFDMatDate.CustomFormat = "dd -MMM - yyyy"
        Me.dtpFDMatDate.Enabled = False
        Me.dtpFDMatDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDMatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDMatDate.Location = New System.Drawing.Point(584, 30)
        Me.dtpFDMatDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpFDMatDate.Name = "dtpFDMatDate"
        Me.dtpFDMatDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpFDMatDate.TabIndex = 10
        Me.dtpFDMatDate.TabStop = False
        Me.dtpFDMatDate.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'txtFDMatAmount
        '
        Me.txtFDMatAmount.AfterDecimal = 2
        Me.txtFDMatAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.BeforeDecimal = 8
        Me.txtFDMatAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMatAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.Location = New System.Drawing.Point(584, 119)
        Me.txtFDMatAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDMatAmount.MaxLength = 10
        Me.txtFDMatAmount.MaxValue = 0
        Me.txtFDMatAmount.MinValue = 0
        Me.txtFDMatAmount.Name = "txtFDMatAmount"
        Me.txtFDMatAmount.ReadOnly = True
        Me.txtFDMatAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtFDMatAmount.TabIndex = 13
        Me.txtFDMatAmount.TabStop = False
        Me.txtFDMatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(472, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Interest Paid :"
        '
        'txtIntPaid
        '
        Me.txtIntPaid.AfterDecimal = 2
        Me.txtIntPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtIntPaid.BeforeDecimal = 8
        Me.txtIntPaid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntPaid.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtIntPaid.Location = New System.Drawing.Point(584, 150)
        Me.txtIntPaid.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtIntPaid.MaxLength = 10
        Me.txtIntPaid.MaxValue = 0
        Me.txtIntPaid.MinValue = 0
        Me.txtIntPaid.Name = "txtIntPaid"
        Me.txtIntPaid.ReadOnly = True
        Me.txtIntPaid.Size = New System.Drawing.Size(136, 23)
        Me.txtIntPaid.TabIndex = 15
        Me.txtIntPaid.TabStop = False
        Me.txtIntPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkFundTransfer)
        Me.GroupBox3.Controls.Add(Me.txtSBNo)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.cmbDepositType)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtFDAccountNo)
        Me.GroupBox3.Controls.Add(Me.btnSearchFD)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(752, 104)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'chkFundTransfer
        '
        Me.chkFundTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.chkFundTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFundTransfer.Location = New System.Drawing.Point(88, 57)
        Me.chkFundTransfer.Name = "chkFundTransfer"
        Me.chkFundTransfer.Size = New System.Drawing.Size(128, 25)
        Me.chkFundTransfer.TabIndex = 5
        Me.chkFundTransfer.Text = "Transfer to SB"
        Me.chkFundTransfer.UseVisualStyleBackColor = False
        '
        'txtSBNo
        '
        Me.txtSBNo.AlphaNumeric = True
        Me.txtSBNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSBNo.BlankSpace = True
        Me.txtSBNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBNo.Location = New System.Drawing.Point(296, 56)
        Me.txtSBNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBNo.Mandatory = False
        Me.txtSBNo.MaxLength = 10
        Me.txtSBNo.Name = "txtSBNo"
        Me.txtSBNo.ReadOnly = True
        Me.txtSBNo.Size = New System.Drawing.Size(128, 23)
        Me.txtSBNo.SpecialChar = False
        Me.txtSBNo.TabIndex = 6
        Me.txtSBNo.TabStop = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(232, 60)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(58, 16)
        Me.Label42.TabIndex = 158
        Me.Label42.Text = "SB No :"
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(112, 23)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(96, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(8, 26)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(106, 16)
        Me.Label39.TabIndex = 133
        Me.Label39.Text = "Deposit Type :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(216, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Account No.:"
        '
        'txtFDAccountNo
        '
        Me.txtFDAccountNo.AlphaNumeric = True
        Me.txtFDAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAccountNo.BlankSpace = False
        Me.txtFDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccountNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAccountNo.Location = New System.Drawing.Point(312, 24)
        Me.txtFDAccountNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtFDAccountNo.Mandatory = False
        Me.txtFDAccountNo.MaxLength = 10
        Me.txtFDAccountNo.Name = "txtFDAccountNo"
        Me.txtFDAccountNo.ReadOnly = True
        Me.txtFDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAccountNo.SpecialChar = True
        Me.txtFDAccountNo.TabIndex = 2
        Me.txtFDAccountNo.TabStop = False
        '
        'btnSearchFD
        '
        Me.btnSearchFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchFD.GotFocusColour = System.Drawing.Color.Green
        Me.btnSearchFD.Image = CType(resources.GetObject("btnSearchFD.Image"), System.Drawing.Image)
        Me.btnSearchFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFD.Location = New System.Drawing.Point(448, 23)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(536, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(208, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 4
        Me.txtName.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(648, 568)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "&Close"
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(544, 568)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 17
        Me.btnOk.Text = "&Account Close"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(143, 23)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Deposit Closure"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFDClosure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1002, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmFDClosure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Deposit Closure"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpFDDetails.ResumeLayout(False)
        Me.grpFDDetails.PerformLayout()
        Me.Correction.ResumeLayout(False)
        Me.Correction.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDClosure
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDClosure
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDClosure
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDClosure)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines and Functions"

    'To load FD Details
    Sub sbLoadFD()


        If objFDAccount.fnGetFDDetails(txtFDAccountNo.Text) Then
            objDT = objFDAccount.FDTable

            txtName.Text = objDT.Rows(0).Item("Name")
            txtSBNo.Text = objDT.Rows(0).Item("AccountNo")
            txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
            dtpFDDate.Value = objDT.Rows(0).Item("FDDate")
            txtFDYears.Text = objDT.Rows(0).Item("Years")
            txtFDMonths.Text = objDT.Rows(0).Item("Months")
            txtFDDays.Text = objDT.Rows(0).Item("Days")
            txtFDAmount.Text = objDT.Rows(0).Item("FDAmount")
            txtFDROI.Text = objDT.Rows(0).Item("FDROI")
            txtFDIntAmount.Text = objDT.Rows(0).Item("IntAmount")
            txtIntPaid.Text = objDT.Rows(0).Item("IntPaid")
            objFDAccount.Scheme = objDT.Rows(0).Item("schemeType")
            dblReminingIntrest = Val(txtFDIntAmount.Text) - Val(txtIntPaid.Text)

            If objDT.Rows(0).Item("Correction") = "Y" Then
                chkCorrection.Checked = True
                If objDT.Rows(0).Item("CType") = "A" Then
                    chkAdd.Checked = True
                ElseIf objDT.Rows(0).Item("CType") = "S" Then
                    chkSubtract.Checked = True
                End If
                txtCorrectionAmount.Text = objDT.Rows(0).Item("CAmount")
            End If

            txtFDMatAmount.Text = objDT.Rows(0).Item("MatAmount")
            dtpFDMatDate.Value = objDT.Rows(0).Item("MatDate")
            txtAmount.Text = Format(Val(txtFDMatAmount.Text) - Val(txtIntPaid.Text), "00.00")
        Else
            MsgBox("Account details not found ", MsgBoxStyle.Information, "Deposit Module")
        End If

    End Sub

    Sub sbLoadFDInt()
        lvInterest.Items.Clear()
        If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
            Dim objDT As DataTable
            Dim objIntTable As DataTable
            If objFDAccount.fnGetFDDetails(txtFDAccountNo.Text) Then

                objDT = objFDAccount.FDTable
                txtName.Text = objDT.Rows(0).Item("Name")
                txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
                If Not objFDAccount.InterestTable Is Nothing Then
                    objIntTable = objFDAccount.InterestTable
                    Dim intCounter As Integer = 0
                    Dim lvItem As New ListViewItem
                    lvItem.UseItemStyleForSubItems = False
                    lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                    If lvInterest.Columns.Count > 5 Then
                        lvInterest.Columns.RemoveAt(5)
                    End If
                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        Dim dt As Date = Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy")
                        If DateDiff(DateInterval.Day, dt, Date.Today) > 0 Then
                            lvItem.ForeColor = Color.Blue
                        End If
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                        If IsDBNull(objIntTable.Rows(intCounter).Item("CollectDate")) = True Then
                            lvItem.SubItems.Add("")
                        Else
                            lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("CollectDate"), "dd-MMM-yyyy"))
                        End If
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                        intCounter += 1
                    End While
                End If
                txtFDAccountNo.ReadOnly = True
            End If
            txtName.Focus()
        Else
            MsgBox("Check the account no.", MsgBoxStyle.MsgBoxHelp, "Deposit Module")
        End If

    End Sub

    'To clear form control values
    Sub sbClear()

        txtFDAccountNo.ResetText()
        dtpFDDate.ResetText()
        txtFDAmount.ResetText()
        txtFDIntAmount.ResetText()
        txtFDROI.ResetText()
        txtFDMatAmount.ResetText()
        txtFDYears.ResetText()
        txtFDMonths.ResetText()
        txtFDDays.ResetText()
        dtpFDMatDate.ResetText()
        lvInterest.Items.Clear()
        txtAmount.ResetText()
        cmbDepositType.SelectedIndex = -1
        txtReceiptNo.ResetText()
        cmbDepositType.Focus()
        txtName.ResetText()
        txtIntPaid.ResetText()

    End Sub

    Public Function fnCloseAcc(ByVal objTrans As IDbTransaction) As Boolean

        objFDAccount.fnGetFDDet(txtFDAccountNo.Text)
        If objFDAccount.FDDetTable.Rows(0).Item("LoanStatus") = "Open" Then
            MsgBox("Cannot be closed ,loan has been issued for this account '" & txtFDAccountNo.Text & "'", MsgBoxStyle.Critical, "Deposit Module")
            Return False
        Else
            objFDAccount.fnCloseFDAccount(txtFDAccountNo.Text, objTrans)
            MsgBox("Account no. '" & txtFDAccountNo.Text & "' closed succesfully", MsgBoxStyle.Information, "Deposit Module")
            Return True
        End If

    End Function

    Public Function fnCheck() As Boolean
        Dim intCounter As Integer = 0
        ' objFDAccount.fnGetFDDetails(txtFDAccountNo.Text)
        objIntTable = objFDAccount.InterestTable
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select the type of deposit", MsgBoxStyle.Information, "Deposit Module")
            cmbDepositType.Focus()
            Return False
        ElseIf txtFDAccountNo.Text = "FD" Or txtFDAccountNo.Text = "ENNVY" Or Trim(txtFDAccountNo.Text) = "SCC" Then
            MsgBox("Enter account no.", MsgBoxStyle.Exclamation, " Deposit Module")
            txtFDAccountNo.Focus()
            Return False
        ElseIf DateDiff(DateInterval.DayOfYear, dtpFDMatDate.Value, Date.Today, FirstDayOfWeek.System) < 0 Then
            MsgBox("Maturity date is not yet over,account cannot be closed", MsgBoxStyle.Exclamation, " Deposit Module")
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("enter receipt number", MsgBoxStyle.Exclamation, "Deposit Module")
            txtReceiptNo.Focus()
            Return False
        ElseIf objFDAccount.Scheme = "C" Then
            While intCounter < objIntTable.Rows.Count
                If objIntTable.Rows(intCounter).Item("status") <> "Provision" Then
                    MsgBox("This FD account of type on maturity, please do provision first", MsgBoxStyle.Exclamation, "Deposit Module")
                    Return False
                End If
                intCounter = intCounter + 1
            End While
            Return True
        ElseIf objFDAccount.Scheme = "N" Then
            intCounter = 0
            While intCounter < objIntTable.Rows.Count
                If objIntTable.Rows(intCounter).Item("status") <> "Paid" Then
                    MsgBox("This FD account of type monthly/quaterly interest, please do payment first", MsgBoxStyle.Exclamation, "Deposit Module")
                    Return False
                End If
                intCounter = intCounter + 1
            End While
            Return True
        Else
            Return True
        End If

    End Function

    Function fnSetData() As Boolean
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
        Return True
    End Function

    Public Function fnPaidStatus() As Boolean

        Dim intCount As Integer
        While intCount < lvInterest.Items.Count
            If lvInterest.Items(intCount).SubItems(4).Text = "Due" Then
                ' MsgBox("Please Post The interest for the Month '" & lvInterest.Items(intCount).SubItems(2).Text & "'", MsgBoxStyle.Exclamation, "FD Module")
                If MsgBox("Do you want to  post interest for the month '" & lvInterest.Items(intCount).SubItems(2).Text & "' Or want to close FD ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Deposit Module") = MsgBoxResult.Yes Then
                    Return False
                Else
                    Return True
                End If
            Else
                intCount += 1
            End If
        End While
        Return True
    End Function


    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpClosingDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        ''objFDAccount.fnUpdateDueStatus(txtFDAccountNo.Text, lngVoucherNo, txtReceiptNo.Text, dtpClosingDate.Value)

        ' '' Inset into FdPosting Deatils 
        ''strsql = "insert into fdintpostingstbl(FDNo,TrDate,Amount,Remarks,Voucherno,RefNo) values('" & Trim(txtFDAccountNo.Text) & "','" & Format(dtpClosingDate.Value, "yyyy-MM-dd") & "','" & dblReminingIntrest & "','','" & lngVoucherNo & "','" & txtReceiptNo.Text & "')"
        ''fnExecuteNonQuery(strsql, objTrans)

        If chkFundTransfer.Checked = True Then

            Dim strNarration As String = "Transfered to " & txtSBNo.Text & " from " & txtFDAccountNo.Text
            If objFDAccount.Scheme = "C" Then
                'Transaction Entry
                Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                strsql = strsql & " select '" & Trim(txtSBNo.Text) & "','" & Format(dtpClosingDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtFDAmount.Text) + dblReminingIntrest & "','0','" & Trim(txtFDAmount.Text) + dblReminingIntrest & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtFDAmount.Text) + dblReminingIntrest & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBNo.Text) & "' group by Accountno"
                fnExecuteNonQuery(strsql, objTrans)

                ''voucher details
                fnVoucherEnterMain(lngVoucherNo, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, txtFDAmount.Text + dblReminingIntrest, "Transfered by account " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpClosingDate.Value, "Account closure by " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpClosingDate.Value, "Interest paid by " & txtFDAccountNo.Text, "By", 14, dblReminingIntrest, 0, 3, "Y", objTrans)

                'If dblProvisionInterest <> 0 Then
                '    'Debit accounts 
                '    fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpClosingDate.Value, "Interest paid by " & txtFDAccountNo.Text, "By", 14, dblProvisionInterest, 0, 2, "Y", objTrans)
                'End If

                ''Credit  - SB account
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpClosingDate.Value, "Account closure by account " & txtFDAccountNo.Text, "To", 10, 0, Val(txtFDAmount.Text) + dblReminingIntrest, 1, "Y", objTrans)
            ElseIf objFDAccount.Scheme = "N" Then
                'Transaction Entry
                Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                strsql = strsql & " select '" & Trim(txtSBNo.Text) & "','" & Format(dtpClosingDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtFDAmount.Text) & "','0','" & Trim(txtFDAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtFDAmount.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBNo.Text) & "' group by Accountno"
                fnExecuteNonQuery(strsql, objTrans)

                ''voucher details
                fnVoucherEnterMain(lngVoucherNo, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, txtFDAmount.Text, "Transfered by account " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpClosingDate.Value, "Account closure by " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 1, "Y", objTrans)

                'If dblProvisionInterest <> 0 Then
                '    'Debit accounts 
                '    fnVoucherEnterSub(lngVoucherNo, 7, txtFDAccountNo.Text, dtpClosingDate.Value, "Interest paid by " & txtFDAccountNo.Text, "By", 14, dblProvisionInterest, 0, 2, "Y", objTrans)
                'End If

                ''Credit  - SB account
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpClosingDate.Value, "Account closure by account " & txtFDAccountNo.Text, "To", 10, 0, Val(txtFDAmount.Text), 1, "Y", objTrans)

            End If
        Else
            If objFDAccount.Scheme = "C" Then
                ''voucher details
                fnVoucherEnterMain(lngVoucherNo, 2, txtFDAccountNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, Val(txtFDAmount.Text) + dblReminingIntrest, "Account Closure By  " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

                ''Credit  - Cash account
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpClosingDate.Value, "Account closure by account " & txtFDAccountNo.Text, "To", 1, 0, Val(txtFDAmount.Text) + dblReminingIntrest, 1, "Y", objTrans)

                ''Debit  - Fixed Deposit account 
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpClosingDate.Value, "Account closure by " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 2, "Y", objTrans)

                ''Debit  - Interest PAyment
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpClosingDate.Value, "Interest paid by  " & txtFDAccountNo.Text, "By", 14, dblReminingIntrest - dblProvisionInterest, 0, 3, "Y", objTrans)

                ''If dblProvisionInterest <> 0 Then
                ''    'Debit accounts 
                ''    fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpClosingDate.Value, "Interest paid by " & txtFDAccountNo.Text, "By", 14, dblProvisionInterest, 0, 4, "Y", objTrans)
                ''End If
            ElseIf objFDAccount.Scheme = "N" Then
                ''voucher details
                fnVoucherEnterMain(lngVoucherNo, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpClosingDate.Value, txtFDAmount.Text + dblReminingIntrest, "Transfered by account " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

                ''Credit  - Cash account
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpClosingDate.Value, "Account closure by account " & txtFDAccountNo.Text, "To", 1, 0, Val(txtFDAmount.Text), 1, "Y", objTrans)

                ''Debit  - Fixed Deposit account 
                fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpClosingDate.Value, "Account closure by " & txtFDAccountNo.Text, "By", intLedgerNo, Val(txtFDAmount.Text), 0, 2, "Y", objTrans)
            End If
        End If

            Return True

    End Function

    Public Function fnLoadIntetest() As Boolean
        dblProvisionInterest = 0
        dblDueInterest = 0
        dblPaidInterest = 0

        If objFDAccount.fnCheckFDScheme(txtFDAccountNo.Text) Then
            Dim dtMasterData As DataTable = objFDAccount.FDMasterDetailTbl
            If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                If objFDAccount.fnGetInterestDet(txtFDAccountNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objFDAccount.dtIntPost.Rows.Count
                        Select Case objFDAccount.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objFDAccount.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Provision"
                                dblProvisionInterest = objFDAccount.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Paid"
                                dblPaidInterest = objFDAccount.dtIntPost.Rows(intCount).Item("Amount")
                        End Select
                        intCount += 1
                    End While
                End If
            Else
                If objFDAccount.fnGetNonInterestDet(txtFDAccountNo.Text) Then
                    Dim intCount As Integer = 0
                    While intCount < objFDAccount.dtIntPost.Rows.Count
                        Select Case objFDAccount.dtIntPost.Rows(intCount).Item("Status")
                            Case "Due"
                                dblDueInterest = objFDAccount.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Provision"
                                dblProvisionInterest = objFDAccount.dtIntPost.Rows(intCount).Item("Amount")
                            Case "Paid"
                                dblPaidInterest = objFDAccount.dtIntPost.Rows(intCount).Item("Amount")
                        End Select
                        intCount += 1
                    End While
                End If
            End If
        End If
    End Function

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click

        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strFDNo = ""
            objFDSearch.strForm = "FDDoubleThriableLakshadipathi"
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFDInt()
                sbLoadFD()
                fnLoadIntetest()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select The Deposit Type ")
            cmbDepositType.Focus()
        End If

    End Sub

    Private Sub frmFDClosure_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F3 Then
            btnSearchFD_Click(sender, e)
        End If

    End Sub

    Private Sub frmFDClosure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpClosingDate.MaxDate = Date.Now
        dtpClosingDate.Value = Date.Now
        cmbDepositType.SelectedIndex = -1

    End Sub

    Private Sub btnIntPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntPayment.Click
        If txtFDAccountNo.Text <> String.Empty Then
            If Trim(txtFDAccountNo.Text) <> "FD" Or Trim(txtFDAccountNo.Text) <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
                Dim objFrmIntPayment As New frmFDPayments
                objFrmIntPayment.txtFDAccountNo.Text = txtFDAccountNo.Text
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        objFrmIntPayment.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        objFrmIntPayment.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        objFrmIntPayment.cmbDepositType.SelectedItem = "SCC"
                End Select
                objFrmIntPayment.cmbDepositType.SelectedItem = cmbDepositType.SelectedItem
                objFrmIntPayment.ShowDialog()
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "FD Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Enter FD no.", MsgBoxStyle.Information, "FD Module")
            txtFDAccountNo.Focus()
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If MsgBox("Do want to close this account permanently", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Deposit Module") = MsgBoxResult.Yes Then
                        If fnGenerateVoucher(objTrans) Then
                            fnCloseAcc(objTrans)
                            objTrans.Commit()
                            sbClear()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try


    End Sub

    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                txtFDAccountNo.Text = "FD"
            Case "ENNVY"
                txtFDAccountNo.Text = "ENNVY"
            Case "SCC"
                txtFDAccountNo.Text = "SCC"
        End Select
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbClear()
    End Sub

    Private Sub btnFDDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFDDetails.Click
        If txtFDAccountNo.Text <> String.Empty Then
            If Trim(txtFDAccountNo.Text) <> "FD" Or Trim(txtFDAccountNo.Text) <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
                Dim objfrmFDCreation As frmFDCreation
                objfrmFDCreation = frmFDCreation.DefInstance
                objfrmFDCreation.txtFDAccountNo.Text = txtFDAccountNo.Text
                objfrmFDCreation.MdiParent = Me.MdiParent
                objfrmFDCreation.BringToFront()
                objfrmFDCreation.Show()
                objfrmFDCreation = Nothing
            Else
                MsgBox("Enter correct account no.", MsgBoxStyle.Information, "FD Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Enter FD no. ", MsgBoxStyle.Information, "FD Module")
            txtFDAccountNo.Focus()
        End If
    End Sub

    Private Sub chkCorrection_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCorrection.CheckedChanged
        If chkCorrection.Checked = True Then
            txtCInterest.Visible = True
            lblCInterest.Visible = True
            txtCInterest.Text = Val(txtFDIntAmount.Text)
        Else
            Correction.Enabled = False
            chkAdd.Checked = False
            chkSubtract.Checked = False
            txtCorrectionAmount.ResetText()
            txtCInterest.ResetText()
            txtCInterest.Visible = False
            lblCInterest.Visible = False
        End If
    End Sub

    Private Sub txtCorrectionAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorrectionAmount.TextChanged

        Dim dblAmt As Double = Val(txtFDIntAmount.Text)

        If chkAdd.Checked = True Then
            txtFDMatAmount.ResetText()
            txtCInterest.Text = dblAmt + Val(txtCorrectionAmount.Text)
            txtFDMatAmount.Text = Val(txtCInterest.Text) + Val(txtFDAmount.Text)
        ElseIf chkSubtract.Checked = True Then
            txtCInterest.Text = dblAmt - Val(txtCorrectionAmount.Text)
            txtFDMatAmount.Text = Val(txtCInterest.Text) + Val(txtFDAmount.Text)
        Else
            txtFDMatAmount.Text = Val(dblAmt) + Val(txtFDAmount.Text)
        End If


    End Sub


End Class
