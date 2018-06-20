Public Class frmReport
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbAccStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnRun As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents btnSB As BankControls.NewButton
    Friend WithEvents btnMemberAcc As BankControls.NewButton
    Friend WithEvents btnFDAcc As BankControls.NewButton
    Friend WithEvents btnPGAcc As BankControls.NewButton
    Friend WithEvents btnRDAcc As BankControls.NewButton
    Friend WithEvents btnShareList As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnLoansDetails As BankControls.NewButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLoanStatment As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReport As BankControls.NewButton
    Friend WithEvents btncls As BankControls.NewButton
    Friend WithEvents cmbLoantype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoanNumber As System.Windows.Forms.ComboBox
    Friend WithEvents btnloandetails As BankControls.NewButton
    Friend WithEvents btndefaulter As BankControls.NewButton
    Friend WithEvents Panel3 As System.Windows.Forms.GroupBox
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepositStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnDepositReport As BankControls.NewButton
    Friend WithEvents grpDeposit As System.Windows.Forms.GroupBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NewButton1 = New BankControls.NewButton
        Me.btnLoansDetails = New BankControls.NewButton
        Me.btnSB = New BankControls.NewButton
        Me.btnMemberAcc = New BankControls.NewButton
        Me.btnFDAcc = New BankControls.NewButton
        Me.btnPGAcc = New BankControls.NewButton
        Me.btnRDAcc = New BankControls.NewButton
        Me.btnShareList = New BankControls.NewButton
        Me.grpFilter = New System.Windows.Forms.GroupBox
        Me.btnRun = New BankControls.NewButton
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbAccStatus = New System.Windows.Forms.ComboBox
        Me.btnCancel = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btndefaulter = New BankControls.NewButton
        Me.btnloandetails = New BankControls.NewButton
        Me.btnLoanStatment = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLoanNumber = New System.Windows.Forms.ComboBox
        Me.cmbLoantype = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnReport = New BankControls.NewButton
        Me.btncls = New BankControls.NewButton
        Me.Panel3 = New System.Windows.Forms.GroupBox
        Me.grpDeposit = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbDepositStatus = New System.Windows.Forms.ComboBox
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.btnDepositReport = New BankControls.NewButton
        Me.NewButton2 = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.grpDeposit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NewButton1)
        Me.Panel1.Controls.Add(Me.btnLoansDetails)
        Me.Panel1.Controls.Add(Me.btnSB)
        Me.Panel1.Controls.Add(Me.btnMemberAcc)
        Me.Panel1.Controls.Add(Me.btnFDAcc)
        Me.Panel1.Controls.Add(Me.btnPGAcc)
        Me.Panel1.Controls.Add(Me.btnRDAcc)
        Me.Panel1.Controls.Add(Me.btnShareList)
        Me.Panel1.Location = New System.Drawing.Point(16, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 480)
        Me.Panel1.TabIndex = 0
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.Cornsilk
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.GotFocusColour = System.Drawing.Color.Linen
        Me.NewButton1.Location = New System.Drawing.Point(16, 416)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(184, 40)
        Me.NewButton1.TabIndex = 7
        Me.NewButton1.Text = "Current  Account"
        Me.NewButton1.UseVisualStyleBackColor = False
        Me.NewButton1.Visible = False
        '
        'btnLoansDetails
        '
        Me.btnLoansDetails.BackColor = System.Drawing.Color.Cornsilk
        Me.btnLoansDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoansDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoansDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoansDetails.GotFocusColour = System.Drawing.Color.Linen
        Me.btnLoansDetails.Location = New System.Drawing.Point(16, 352)
        Me.btnLoansDetails.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnLoansDetails.Name = "btnLoansDetails"
        Me.btnLoansDetails.Size = New System.Drawing.Size(184, 40)
        Me.btnLoansDetails.TabIndex = 6
        Me.btnLoansDetails.Text = "Loans Details"
        Me.btnLoansDetails.UseVisualStyleBackColor = False
        '
        'btnSB
        '
        Me.btnSB.BackColor = System.Drawing.Color.Cornsilk
        Me.btnSB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSB.GotFocusColour = System.Drawing.Color.Linen
        Me.btnSB.Location = New System.Drawing.Point(16, 16)
        Me.btnSB.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnSB.Name = "btnSB"
        Me.btnSB.Size = New System.Drawing.Size(184, 40)
        Me.btnSB.TabIndex = 5
        Me.btnSB.Text = "Savings Account"
        Me.btnSB.UseVisualStyleBackColor = False
        '
        'btnMemberAcc
        '
        Me.btnMemberAcc.BackColor = System.Drawing.Color.Cornsilk
        Me.btnMemberAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemberAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemberAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberAcc.GotFocusColour = System.Drawing.Color.Linen
        Me.btnMemberAcc.Location = New System.Drawing.Point(16, 72)
        Me.btnMemberAcc.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnMemberAcc.Name = "btnMemberAcc"
        Me.btnMemberAcc.Size = New System.Drawing.Size(184, 40)
        Me.btnMemberAcc.TabIndex = 5
        Me.btnMemberAcc.Text = "Members Account"
        Me.btnMemberAcc.UseVisualStyleBackColor = False
        '
        'btnFDAcc
        '
        Me.btnFDAcc.BackColor = System.Drawing.Color.Cornsilk
        Me.btnFDAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFDAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFDAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFDAcc.GotFocusColour = System.Drawing.Color.Linen
        Me.btnFDAcc.Location = New System.Drawing.Point(16, 184)
        Me.btnFDAcc.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnFDAcc.Name = "btnFDAcc"
        Me.btnFDAcc.Size = New System.Drawing.Size(184, 40)
        Me.btnFDAcc.TabIndex = 5
        Me.btnFDAcc.Text = "Fixed Deposit Account"
        Me.btnFDAcc.UseVisualStyleBackColor = False
        '
        'btnPGAcc
        '
        Me.btnPGAcc.BackColor = System.Drawing.Color.Cornsilk
        Me.btnPGAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPGAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPGAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPGAcc.GotFocusColour = System.Drawing.Color.Linen
        Me.btnPGAcc.Location = New System.Drawing.Point(16, 240)
        Me.btnPGAcc.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnPGAcc.Name = "btnPGAcc"
        Me.btnPGAcc.Size = New System.Drawing.Size(184, 40)
        Me.btnPGAcc.TabIndex = 5
        Me.btnPGAcc.Text = "BNN Account"
        Me.btnPGAcc.UseVisualStyleBackColor = False
        '
        'btnRDAcc
        '
        Me.btnRDAcc.BackColor = System.Drawing.Color.Cornsilk
        Me.btnRDAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRDAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDAcc.GotFocusColour = System.Drawing.Color.Linen
        Me.btnRDAcc.Location = New System.Drawing.Point(16, 296)
        Me.btnRDAcc.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnRDAcc.Name = "btnRDAcc"
        Me.btnRDAcc.Size = New System.Drawing.Size(184, 40)
        Me.btnRDAcc.TabIndex = 5
        Me.btnRDAcc.Text = "Recurring Deposit Account"
        Me.btnRDAcc.UseVisualStyleBackColor = False
        '
        'btnShareList
        '
        Me.btnShareList.BackColor = System.Drawing.Color.Cornsilk
        Me.btnShareList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShareList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShareList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShareList.GotFocusColour = System.Drawing.Color.Linen
        Me.btnShareList.Location = New System.Drawing.Point(16, 128)
        Me.btnShareList.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnShareList.Name = "btnShareList"
        Me.btnShareList.Size = New System.Drawing.Size(184, 40)
        Me.btnShareList.TabIndex = 5
        Me.btnShareList.Text = "Shares List"
        Me.btnShareList.UseVisualStyleBackColor = False
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.Controls.Add(Me.btnRun)
        Me.grpFilter.Controls.Add(Me.Label23)
        Me.grpFilter.Controls.Add(Me.cmbAccStatus)
        Me.grpFilter.Controls.Add(Me.btnCancel)
        Me.grpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.Location = New System.Drawing.Point(690, 64)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(272, 144)
        Me.grpFilter.TabIndex = 1
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter"
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.Cornsilk
        Me.btnRun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRun.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.Color.Black
        Me.btnRun.GotFocusColour = System.Drawing.Color.Linen
        Me.btnRun.Location = New System.Drawing.Point(104, 96)
        Me.btnRun.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(64, 32)
        Me.btnRun.TabIndex = 43
        Me.btnRun.Text = "Report"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(104, 15)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Account Status   "
        '
        'cmbAccStatus
        '
        Me.cmbAccStatus.DisplayMember = "A,S,C"
        Me.cmbAccStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbAccStatus.Items.AddRange(New Object() {"All", "Active", "Closed"})
        Me.cmbAccStatus.Location = New System.Drawing.Point(120, 48)
        Me.cmbAccStatus.Name = "cmbAccStatus"
        Me.cmbAccStatus.Size = New System.Drawing.Size(136, 24)
        Me.cmbAccStatus.TabIndex = 41
        Me.cmbAccStatus.ValueMember = "A,S,C"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Cornsilk
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Linen
        Me.btnCancel.Location = New System.Drawing.Point(184, 96)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 32)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Cornsilk
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.Linen
        Me.btnClose.Location = New System.Drawing.Point(866, 544)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 48)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btndefaulter)
        Me.Panel2.Controls.Add(Me.btnloandetails)
        Me.Panel2.Controls.Add(Me.btnLoanStatment)
        Me.Panel2.Location = New System.Drawing.Point(248, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 368)
        Me.Panel2.TabIndex = 45
        Me.Panel2.Visible = False
        '
        'btndefaulter
        '
        Me.btndefaulter.BackColor = System.Drawing.Color.Cornsilk
        Me.btndefaulter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndefaulter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndefaulter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndefaulter.GotFocusColour = System.Drawing.Color.Linen
        Me.btndefaulter.Location = New System.Drawing.Point(8, 88)
        Me.btndefaulter.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btndefaulter.Name = "btndefaulter"
        Me.btndefaulter.Size = New System.Drawing.Size(136, 40)
        Me.btndefaulter.TabIndex = 9
        Me.btndefaulter.Text = "Loan  Defaulters"
        Me.btndefaulter.UseVisualStyleBackColor = False
        '
        'btnloandetails
        '
        Me.btnloandetails.BackColor = System.Drawing.Color.Cornsilk
        Me.btnloandetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnloandetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnloandetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloandetails.GotFocusColour = System.Drawing.Color.Linen
        Me.btnloandetails.Location = New System.Drawing.Point(8, 160)
        Me.btnloandetails.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnloandetails.Name = "btnloandetails"
        Me.btnloandetails.Size = New System.Drawing.Size(136, 40)
        Me.btnloandetails.TabIndex = 8
        Me.btnloandetails.Text = "Loan  Statement"
        Me.btnloandetails.UseVisualStyleBackColor = False
        Me.btnloandetails.Visible = False
        '
        'btnLoanStatment
        '
        Me.btnLoanStatment.BackColor = System.Drawing.Color.Cornsilk
        Me.btnLoanStatment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanStatment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanStatment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanStatment.GotFocusColour = System.Drawing.Color.Linen
        Me.btnLoanStatment.Location = New System.Drawing.Point(8, 24)
        Me.btnLoanStatment.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnLoanStatment.Name = "btnLoanStatment"
        Me.btnLoanStatment.Size = New System.Drawing.Size(136, 40)
        Me.btnLoanStatment.TabIndex = 7
        Me.btnLoanStatment.Text = "Loan  Transaction"
        Me.btnLoanStatment.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Loan Number"
        '
        'cmbLoanNumber
        '
        Me.cmbLoanNumber.DisplayMember = "A,S,C"
        Me.cmbLoanNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbLoanNumber.Items.AddRange(New Object() {"Active", "Closed"})
        Me.cmbLoanNumber.Location = New System.Drawing.Point(96, 72)
        Me.cmbLoanNumber.Name = "cmbLoanNumber"
        Me.cmbLoanNumber.Size = New System.Drawing.Size(160, 24)
        Me.cmbLoanNumber.TabIndex = 45
        Me.cmbLoanNumber.ValueMember = "A,S,C"
        '
        'cmbLoantype
        '
        Me.cmbLoantype.DisplayMember = "A,S,C"
        Me.cmbLoantype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbLoantype.Items.AddRange(New Object() {"Jewelery Loan", "Vachile Loan", "Hand Loan", "Colleteral Hand Loan", "Surety Loan", "Loans On Term Deposit", "Daily Recovery Loan", "Over Draft"})
        Me.cmbLoantype.Location = New System.Drawing.Point(96, 32)
        Me.cmbLoantype.Name = "cmbLoantype"
        Me.cmbLoantype.Size = New System.Drawing.Size(160, 24)
        Me.cmbLoantype.TabIndex = 44
        Me.cmbLoantype.ValueMember = "A,S,C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Loan Type"
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Cornsilk
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.GotFocusColour = System.Drawing.Color.Linen
        Me.btnReport.Location = New System.Drawing.Point(104, 104)
        Me.btnReport.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(64, 32)
        Me.btnReport.TabIndex = 44
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btncls
        '
        Me.btncls.BackColor = System.Drawing.Color.Cornsilk
        Me.btncls.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncls.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncls.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncls.ForeColor = System.Drawing.Color.Black
        Me.btncls.GotFocusColour = System.Drawing.Color.Linen
        Me.btncls.Location = New System.Drawing.Point(184, 104)
        Me.btncls.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btncls.Name = "btncls"
        Me.btncls.Size = New System.Drawing.Size(64, 32)
        Me.btncls.TabIndex = 44
        Me.btncls.Text = "Cancel"
        Me.btncls.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.cmbLoantype)
        Me.Panel3.Controls.Add(Me.cmbLoanNumber)
        Me.Panel3.Controls.Add(Me.btnReport)
        Me.Panel3.Controls.Add(Me.btncls)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(690, 360)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 144)
        Me.Panel3.TabIndex = 44
        Me.Panel3.TabStop = False
        Me.Panel3.Text = "Transaction"
        Me.Panel3.Visible = False
        '
        'grpDeposit
        '
        Me.grpDeposit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDeposit.Controls.Add(Me.Label4)
        Me.grpDeposit.Controls.Add(Me.cmbDepositStatus)
        Me.grpDeposit.Controls.Add(Me.cmbDepositType)
        Me.grpDeposit.Controls.Add(Me.btnDepositReport)
        Me.grpDeposit.Controls.Add(Me.NewButton2)
        Me.grpDeposit.Controls.Add(Me.Label3)
        Me.grpDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeposit.Location = New System.Drawing.Point(688, 216)
        Me.grpDeposit.Name = "grpDeposit"
        Me.grpDeposit.Size = New System.Drawing.Size(272, 144)
        Me.grpDeposit.TabIndex = 46
        Me.grpDeposit.TabStop = False
        Me.grpDeposit.Text = "Deposit"
        Me.grpDeposit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Account Status   "
        '
        'cmbDepositStatus
        '
        Me.cmbDepositStatus.DisplayMember = "A,S,C"
        Me.cmbDepositStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbDepositStatus.Items.AddRange(New Object() {"All", "Active", "Closed"})
        Me.cmbDepositStatus.Location = New System.Drawing.Point(104, 64)
        Me.cmbDepositStatus.Name = "cmbDepositStatus"
        Me.cmbDepositStatus.Size = New System.Drawing.Size(136, 24)
        Me.cmbDepositStatus.TabIndex = 45
        Me.cmbDepositStatus.ValueMember = "A,S,C"
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DisplayMember = "A,S,C"
        Me.cmbDepositType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "SCC", "ENNVY"})
        Me.cmbDepositType.Location = New System.Drawing.Point(104, 32)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(136, 24)
        Me.cmbDepositType.TabIndex = 44
        Me.cmbDepositType.ValueMember = "A,S,C"
        '
        'btnDepositReport
        '
        Me.btnDepositReport.BackColor = System.Drawing.Color.Cornsilk
        Me.btnDepositReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDepositReport.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositReport.ForeColor = System.Drawing.Color.Black
        Me.btnDepositReport.GotFocusColour = System.Drawing.Color.Linen
        Me.btnDepositReport.Location = New System.Drawing.Point(104, 104)
        Me.btnDepositReport.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.btnDepositReport.Name = "btnDepositReport"
        Me.btnDepositReport.Size = New System.Drawing.Size(64, 32)
        Me.btnDepositReport.TabIndex = 44
        Me.btnDepositReport.Text = "Report"
        Me.btnDepositReport.UseVisualStyleBackColor = False
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.Cornsilk
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.Linen
        Me.NewButton2.Location = New System.Drawing.Point(184, 104)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.Cornsilk
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(64, 32)
        Me.NewButton2.TabIndex = 44
        Me.NewButton2.Text = "Cancel"
        Me.NewButton2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Deposit Type"
        '
        'frmReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.grpDeposit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.grpDeposit.ResumeLayout(False)
        Me.grpDeposit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmReport
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmReport
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmReport
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmReport)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Public strAcc As String
    Dim objlounnumbers As New clsLoanDet
    Dim DTview As DataView
    Dim LoanType As String
    Dim reporttype As String
    Dim SqlType As String

#End Region

#Region "Functions"

    Public Function fnGenerateReport()

        Dim objReportViewer As New frmReportViewer
        Dim strStatus As String

        If strAcc = "SB" Then
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/SBAccountBalance1.rpt"

            If cmbAccStatus.SelectedItem = "Active" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{sbdetailstbl.AccStatus} = 'A'"
            ElseIf cmbAccStatus.SelectedItem = "Closed" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{sbdetailstbl.AccStatus} = 'C'"
            End If

        ElseIf strAcc = "MC" Then
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/MembersList.rpt"
            If cmbAccStatus.SelectedItem = "Active" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{membertbl.Status} = '" & cmbAccStatus.SelectedItem & "'"

            ElseIf cmbAccStatus.SelectedItem = "Closed" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{membertbl.Status} = '" & cmbAccStatus.SelectedItem & "'"
            End If
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/MembersList.rpt"
            '''objReportViewer.ShowDialog()
            '''objReportViewer.Dispose()
            '''grpFilter.Visible = False

        ElseIf strAcc = "SC" Then
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/MembersList.rpt"
            If cmbAccStatus.SelectedItem = "Active" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{membertbl.Status} = '" & cmbAccStatus.SelectedItem & "'"

            ElseIf cmbAccStatus.SelectedItem = "Closed" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{membertbl.Status} = '" & cmbAccStatus.SelectedItem & "'"
            End If

            '''objReportViewer.ShowDialog()
            '''objReportViewer.Dispose()
            '''grpFilter.Visible = False

        ElseIf strAcc = "FD" Then
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/FDCustList1.rpt"
            If cmbAccStatus.SelectedItem = "Active" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{fddetailstbl.Status} = 'A'"
            ElseIf cmbAccStatus.SelectedItem = "Closed" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{fddetailstbl.Status} = 'C'"
            End If
            ''objReportViewer.ShowDialog()
            ''objReportViewer.Dispose()
            ''grpFilter.Visible = False

        ElseIf strAcc = "PG" Then


            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/PigmyList1.rpt"
            If cmbAccStatus.SelectedItem = "Active" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{pigmyaccounttbl.AccStatus} = 'A'"
            ElseIf cmbAccStatus.SelectedItem = "Closed" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{pigmyaccounttbl.AccStatus} = 'C'"
            End If
            ''objReportViewer.ShowDialog()
            ''objReportViewer.Dispose()
            ''grpFilter.Visible = False

        ElseIf strAcc = "RD" Then
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/RDList1.rpt"
            If cmbAccStatus.SelectedItem = "Active" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{rddetailstbl.Status} = 'A'"
            ElseIf cmbAccStatus.SelectedItem = "Closed" Then
                objReportViewer.CrystalReportViewer1.SelectionFormula = "{rddetailstbl.Status} = 'C'"
            End If
            'objReportViewer.ShowDialog()
            'objReportViewer.Dispose()
            'grpFilter.Visible = False

        End If

        objReportViewer.ShowDialog()
        objReportViewer.Dispose()
        grpFilter.Visible = False

    End Function

    Sub loadLoanNumbers()

        'If objlounnumbers.fnLoanNumbers() Then


        '    cmbLoanNumber.DataSource = objlounnumbers.LoanListTable
        '    cmbLoanNumber.DisplayMember = "LoanNo"
        '    cmbLoanNumber.ValueMember = "LoanNo"


        'End If
    End Sub


#End Region

#Region "Events"

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadLoanNumbers()
        cmbLoanNumber.Enabled = False
        grpFilter.Visible = False
        cmbAccStatus.SelectedIndex = 0

    End Sub

    Private Sub btnSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSB.Click
        strAcc = "SB"
        grpFilter.Visible = True
        PanelVisible()
    End Sub
    Sub PanelVisible()
        Panel2.Visible = False
        Panel3.Visible = False
        grpDeposit.Visible = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        grpFilter.Visible = False

    End Sub

    Private Sub btnMemberAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberAcc.Click
        PanelVisible()
        strAcc = "MC"
        grpFilter.Visible = True

    End Sub

    Private Sub btnShareList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShareList.Click
        PanelVisible()
        strAcc = "SC"
        grpFilter.Visible = True

    End Sub

    Private Sub btnFDAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFDAcc.Click

        PanelVisible()
        strAcc = "FD"
        grpFilter.Visible = True
        'grpFilter.Visible = False
        'Panel3.Visible = False
        'Panel2.Visible = False
        'grpDeposit.Visible = True

    End Sub

    Private Sub btnPGAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPGAcc.Click
        PanelVisible()
        strAcc = "PG"
        grpFilter.Visible = True

    End Sub

    Private Sub btnRDAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDAcc.Click
        PanelVisible()
        strAcc = "RD"
        grpFilter.Visible = True

    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click

        fnGenerateReport()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

#End Region

    Private Sub btnLoansDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoansDetails.Click
        Panel2.Visible = True
        grpDeposit.Visible = False
        grpFilter.Visible = False
    End Sub

    Private Sub btnLoanStatment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoanStatment.Click

        Panel3.Visible = True
        reporttype = "Transaction"
        Panel3.Text = "Transaction"
    End Sub

    Private Sub cmbLoantype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoantype.SelectedIndexChanged

        cmbLoanNumber.Enabled = True
        Dim strtype As String

        ' SqlType = "loan"

        Select Case cmbLoantype.SelectedItem

            Case "Jewelery Loan"
                strtype = "JL"
                SqlType = "loan"
            Case "Vachile Loan"
                strtype = "LMV"
                SqlType = "loan"
                'Case "Personal Loan"
                '    strtype = "PL"
            Case "Hand Loan"
                strtype = "HL"
                SqlType = "loan"
            Case "Colleteral Hand Loan"
                strtype = "CHL"
                SqlType = "loan"
            Case "Surety Loan"
                strtype = "SL"
                SqlType = "loan"
            Case "Loans On Term Deposit"
                strtype = "LTD"
                SqlType = "loan"
            Case "Daily Recovery Loan"
                strtype = "SDRL"
                SqlType = "loan"
            Case "Over Draft"
                strtype = "OD"
                SqlType = "OverDft"

        End Select

        If objlounnumbers.fnLoanNumbers(SqlType) Then

            If SqlType = "loan" Then
                DTview = New DataView(objlounnumbers.LoanListTable, "", "LoanNo", DataViewRowState.CurrentRows)
                Dim int112 As Integer = DTview.Count

                DTview.RowFilter = "LoanNo like '" & strtype & "%'"
                Dim int As Integer = DTview.Count

                cmbLoanNumber.DataSource = DTview
                cmbLoanNumber.DisplayMember = "LoanNo"
                cmbLoanNumber.ValueMember = "LoanNo"

            Else

                DTview = New DataView(objlounnumbers.LoanListTable, "", "AccountNo", DataViewRowState.CurrentRows)
                Dim int112 As Integer = DTview.Count

                DTview.RowFilter = "AccountNo like '" & strtype & "%'"
                Dim int As Integer = DTview.Count

                cmbLoanNumber.DataSource = DTview
                cmbLoanNumber.DisplayMember = "AccountNo"
                cmbLoanNumber.ValueMember = "AccountNo"

            End If
        Else
            cmbLoanNumber.DataSource = Nothing
            cmbLoanNumber.Items.Clear()




        End If




    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim objReportViewer As New frmReportViewer

        If cmbLoantype.SelectedIndex <> -1 Then
            If cmbLoanNumber.SelectedIndex <> -1 Then
                If objlounnumbers.fnGetLoanDetail(cmbLoanNumber.SelectedValue) Then
                    If objlounnumbers.LoanListTable.Rows(0).Item("DisbAmount") <> 0 Then

                        'If reporttype = "Statement" Then
                        '    objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} = '" & cmbLoanNumber.SelectedValue & "'"
                        '    objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/loanstatmentDetails.rpt"
                        'Else
                        If SqlType = "loan" Then
                            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} = '" & cmbLoanNumber.SelectedValue & "'"
                            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/LoanStatement.rpt"
                        Else
                            Dim AccNumber As String = "{oddetailstbl.AccountNo} = '" & cmbLoanNumber.SelectedValue & "'"
                            objReportViewer.CrystalReportViewer1.SelectionFormula = AccNumber
                            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/LoanODStatement.rpt"
                        End If

                        ' End If
                        objReportViewer.ShowDialog()
                    Else
                        MsgBox("Amount Not Yet Disbursed", MsgBoxStyle.Information)

                    End If


                End If
                Else
                    MsgBox("Select Loan Number", MsgBoxStyle.Exclamation)
                    cmbLoanNumber.Focus()
                End If
            Else
            MsgBox("Select Loan Type", MsgBoxStyle.Exclamation)
            cmbLoantype.Focus()
        End If

    End Sub


    Private Sub btnloandetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloandetails.Click
        reporttype = "Statement"
        Panel3.Visible = True
        Panel3.Text = "Statement"
    End Sub


    Private Sub btndefaulter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefaulter.Click
        Panel3.Visible = False
        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/DefaulterList.rpt"
        objReportViewer.ShowDialog()
    End Sub

    Private Sub btncls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncls.Click
        Panel3.Visible = False
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        grpDeposit.Visible = False
    End Sub

    'Private Sub btnDepositReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositReport.Click
    '    Dim objReportViewer As New frmReportViewer
    '    Dim strStatus As String


    '    If strAcc = "FD" Then


    '    ElseIf strAcc = "FD" Then
    '        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/FDCustList1.rpt"
    '        If cmbAccStatus.SelectedItem = "Active" Then
    '            objReportViewer.CrystalReportViewer1.SelectionFormula = "{fddetailstbl.Status} = 'A'"
    '        ElseIf cmbAccStatus.SelectedItem = "Closed" Then
    '            objReportViewer.CrystalReportViewer1.SelectionFormula = "{fddetailstbl.Status} = 'C'"
    '        End If
    '    End If

    'End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        strAcc = "CA"
        grpFilter.Visible = True
        PanelVisible()
    End Sub

  
    Private Sub btnDepositReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositReport.Click

    End Sub
End Class

